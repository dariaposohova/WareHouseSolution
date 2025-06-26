using System;
using System.Collections.Generic;
using System.Data.SQLite;
using WareHouseSpace.Model;
using WareHouseSpace.Models;

namespace WareHouseSpace.Classes
{
    public class DbManager
    {
        SQLiteConnection connection;


        public DbManager(string connectString)
        {
            connection = new SQLiteConnection(connectString);
            connection.Open();
            CreateTables();
        }

        private void CreateTables()
        {
            var query =
                @"CREATE TABLE IF NOT EXISTS Products (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name        TEXT    NOT NULL,
                    Description TEXT    NOT NULL,
                    Unit        TEXT    NOT NULL
);
" +
                @"CREATE TABLE IF NOT EXISTS Subjects (
                    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name     TEXT    NOT NULL,
                    Contacts TEXT    NOT NULL
);
" +
                @"CREATE TABLE IF NOT EXISTS Invoices (
                    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                    IdSubject INTEGER REFERENCES Subjects (Id) ON DELETE RESTRICT,
                    Type      INTEGER DEFAULT (0),
                    CreatedAt TEXT    NOT NULL,
                    UpdatedAt TEXT    NOT NULL
);" +
                @"CREATE TABLE IF NOT EXISTS Operations (
                    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                    IdInvoice INTEGER REFERENCES Invoices (Id) ON DELETE RESTRICT,
                    IdProduct INTEGER REFERENCES Products (Id) ON DELETE RESTRICT,
                    Amount    REAL    NOT NULL,
                    Price     REAL    NOT NULL
);";

            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        public List<ModelProduct> GetAllProducts()
        {
            var list = new List<ModelProduct>();
            var query = "SELECT * FROM PRODUCTS;";

            using (var cmd = new SQLiteCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelProduct
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Unit = reader.GetString(3)
                        });
                    }
                }
            }

            return list;
        }

        public List<ModelSubject> GetAllSubjects()
        {
            var list = new List<ModelSubject>();
            var query = "SELECT * FROM SUBJECTS;";

            using (var cmd = new SQLiteCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelSubject
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Contacts = reader.GetString(2),
                        });
                    }
                }
            }


            return list;
        }

        public void AddNewSubject(ModelSubject model)
        {
            var query = "INSERT INTO Subjects(Name,Contacts) VALUES(@Name,@Contacts);";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Contacts", model.Contacts);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddNewProduct(ModelProduct model)
        {
            var query = "INSERT INTO Products(Name,Description,Unit) VALUES(@Name,@Description,@Unit);";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Description", model.Description);
                cmd.Parameters.AddWithValue("Unit", model.Unit);
                cmd.ExecuteNonQuery();
            }
        }


        public void DelOneSubject(ModelSubject model)
        {
            var query = "DELETE FROM Subjects WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DelOneProduct(ModelProduct model)
        {
            var query = "DELETE FROM Products WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOneSubject(ModelSubject model)
        {
            var query = "UPDATE Subjects SET Name = @Name, Contacts = @Contacts  WHERE id = @Id;";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Contacts", model.Contacts);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOneProduct(ModelProduct model)
        {
            var query = "UPDATE Products SET Name = @Name, Description = @Description, Unit = @Unit WHERE id = @Id;";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Description", model.Description);
                cmd.Parameters.AddWithValue("Unit", model.Unit);
                cmd.ExecuteNonQuery();
            }
        }

        internal void AddNewInvoice()
        {
            var query = "INSERT INTO INVOICES(CreatedAt, UpdatedAt) VALUES(@CreatedAt, @UpdatedAt);";
            var dt = DateTime.Now.ToString("g");
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CreatedAt", dt);
                cmd.Parameters.AddWithValue("@UpdatedAt", dt);
                cmd.ExecuteNonQuery();
            }
        }

        internal void DeleteOneInvoice(ModelInvoice model)
        {
            var query = @"
                    DELETE FROM INVOICES WHERE Id = @Id; 
                    DELETE FROM OPERATIONS WHERE IdInvoice = @Id;
            ";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.ExecuteNonQuery();
            }
        }

        internal List<ModelInvoice> GetAllInvoices()
        {
            var list = new List<ModelInvoice>();
            var query = "SELECT I.Id, IdSubject, Type, Name, CreatedAt, UpdatedAt \r\nFROM Invoices I\r\nLEFT JOIN Subjects S ON I.IdSubject == S.Id";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelInvoice
                        {
                            Id = reader.GetInt32(0),
                            IdSubject = reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                            Type = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                            TypeName = reader.IsDBNull(2) ? "Не вибрано" : reader.GetInt32(2) == 0 ? "Прийом" : "Видача",
                            SubjectName = reader.IsDBNull(3) ? "Не вибрано" : reader.GetString(3),
                            CreatedAt = DateTime.Parse(reader.GetString(4)),
                            UpdatedAt = DateTime.Parse(reader.GetString(5))
                        });
                    }
                }
            }
            return list;
        }

        internal void UpdateOneInvoice(ModelInvoice model)
        {
            var query = "UPDATE INVOICES SET IdSubject = @IdSubject, Type = @Type, UpdatedAt = @UpdatedAt WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.Parameters.AddWithValue("IdSubject", model.IdSubject);
                cmd.Parameters.AddWithValue("Type", model.Type);
                cmd.Parameters.AddWithValue("UpdatedAt", model.UpdatedAt);
                cmd.ExecuteNonQuery();
            }
        }

        internal void AddNewOperation(ModelOperation model)
        {
            var query = "INSERT INTO OPERATIONS(IdInvoice, IdProduct, Amount, Price) VALUES(@IdInvoice, @IdProduct, @Amount, @Price)";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("IdInvoice", model.IdInvoice);
                cmd.Parameters.AddWithValue("IdProduct", model.IdProduct);
                cmd.Parameters.AddWithValue("Amount", model.Amount);
                cmd.Parameters.AddWithValue("Price", model.Price);
                cmd.ExecuteNonQuery();
            }
        }

        internal List<ModelOperation> GetInvoiceOperations(ModelInvoice model)
        {
            var list = new List<ModelOperation>();
            var query = @"select 
                            o.Id,
                            o.IdInvoice,
                            o.IdProduct,
                            p.Name, 
                            p.Description,
                            o.Amount,
                            o.Price    
                        from operations o
                        join products p ON p.Id = o.IdProduct
                        where o.IdInvoice = @Id";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelOperation{
                            Id = reader.GetInt32(0),
                            IdInvoice = reader.GetInt32(1),
                            IdProduct = reader.GetInt32(2),
                            ProductName = reader.GetString(3),
                            Description = reader.GetString(4),
                            Amount = reader.GetDouble(5),
                            Price = reader.GetDouble(6),
                        });
                    }
                }
            }
            return list;
        }

        internal void DeleteOneOperation(ModelOperation model)
        {
            var query = "DELETE FROM OPERATIONS WHERE Id = @Id;";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.ExecuteNonQuery();
            }
        }

        internal List<ModelTotal> GetTotals(string text)
        {
            var list = new List<ModelTotal>();
            text = $"%{text}%";
            var query = @"
                        SELECT p.Name,
                               p.Description,
                               SUM(CASE WHEN i.type = 0 THEN o.Amount ELSE -o.Amount END) AS Amount,
                               p.Unit
                          FROM operations o
                               JOIN
                               products p ON o.IdProduct = p.Id
                               JOIN
                               invoices i ON o.IdInvoice = i.id
                         GROUP BY p.id
                        HAVING (p.Name LIKE @text) OR
                               (p.Description LIKE @text);
                        ";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("text", text);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelTotal{
                            ProductName = reader.GetString(0),
                            Desc = reader.GetString(1),
                            Amount= reader.GetDouble(2),
                            Unit = reader.GetString(3),
                        });
                    }
                }
            }
            return list;
        }
    }
}
