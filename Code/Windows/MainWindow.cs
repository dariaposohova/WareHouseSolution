using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WareHouseSpace.Classes;
using WareHouseSpace.Model;
using WareHouseSpace.Models;
using WareHouseSpace.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace WareHouseSpace
{
    public partial class MainWindow : Form
    {
        DbManager db;
        Random random;
        public MainWindow()
        {
            InitializeComponent();
            db = new DbManager(@"Data Source=..\..\database.db;");
            random = new Random();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            ProductGrid.DataSource = db.GetAllProducts();
            SubjectGrid.DataSource = db.GetAllSubjects();

            TotalGrid.DataSource = new BindingList<ModelTotal>();
            InvoiceGrid.DataSource = new BindingList<ModelInvoice>();
            OperationGrid.DataSource = new BindingList<ModelOperation>();
        }

        private void ProductAddNew_Click(object sender, System.EventArgs e)
        {
            ModelProduct product = new ModelProduct();

            if(new ProductWindow(product).ShowDialog() == DialogResult.OK)
            {
                var products = db.GetAllProducts();
                int lastId = products.Count == 0 ? 1 : products.Max(x=>x.Id) + 1;
                product.Id = lastId;

                db.AddNewProduct(product);
                ProductGrid.DataSource = new BindingList<ModelProduct>(db.GetAllProducts());
            }
        }

        private void ProductDelOne_Click(object sender, System.EventArgs e)
        {
            if (ProductGrid.SelectedRows.Count > 0)
            {
                var model = ProductGrid.SelectedRows[0].DataBoundItem as ModelProduct;
                db.DelOneProduct(model);
                ProductGrid.DataSource = new BindingList<ModelProduct>(db.GetAllProducts());
            }
        }

        private void ProductUpdateOne_Click(object sender, EventArgs e)
        {
            if (ProductGrid.SelectedRows.Count > 0)
            {
                var model = ProductGrid.SelectedRows[0].DataBoundItem as ModelProduct;
                if (new ProductWindow(model, true).ShowDialog() == DialogResult.OK)
                {
                    db.UpdateOneProduct(model);
                    ProductGrid.DataSource = new BindingList<ModelProduct>(db.GetAllProducts());
                }
            }
        }

        private void SubjectAddNew_Click(object sender, EventArgs e)
        {
            var model = new ModelSubject();
            if (new SubjectWindow(model).ShowDialog() == DialogResult.OK)
            {
                db.AddNewSubject(model);
                SubjectGrid.DataSource = new BindingList<ModelSubject>(db.GetAllSubjects());
            }
        }

        private void SubjectDeleteOne_Click(object sender, EventArgs e)
        {
            if (SubjectGrid.SelectedRows.Count > 0)
            {
                var model = SubjectGrid.SelectedRows[0].DataBoundItem as ModelSubject;
                db.DelOneSubject(model);
                SubjectGrid.DataSource = new BindingList<ModelSubject>(db.GetAllSubjects());
            }
        }

        private void SubjectUpdateOne_Click(object sender, EventArgs e)
        {
            if (SubjectGrid.SelectedRows.Count > 0)
            {
                var model = SubjectGrid.SelectedRows[0].DataBoundItem as ModelSubject;
                if (new SubjectWindow(model, true).ShowDialog() == DialogResult.OK)
                {
                    db.UpdateOneSubject(model);
                    SubjectGrid.DataSource = new BindingList<ModelSubject>(db.GetAllSubjects());
                }
            }
        }

        private void TabSelecting(object sender, EventArgs e)
        {
            switch (Tabs.SelectedIndex)
            {
                case 0:
                    ProductGrid.DataSource = new BindingList<ModelProduct>(db.GetAllProducts());
                    SubjectGrid.DataSource = new BindingList<ModelSubject>(db.GetAllSubjects());
                    break;
                case 1:
                    ProductSelectGrid.DataSource = new BindingList<ModelProduct>(db.GetAllProducts()); 
                    SubjectCombo.DataSource = new BindingList<ModelSubject>(db.GetAllSubjects());
                    InvoiceGrid.DataSource = new BindingList<ModelInvoice>(db.GetAllInvoices());    
                    break;
                case 2:
                    searchText.Text = "";
                    TotalGrid.DataSource = new BindingList<ModelTotal>(db.GetTotals(""));
                    break;
                default:
                    break;
            }
        }

        private void AddNewInvoice_Click(object sender, EventArgs e)
        {
            db.AddNewInvoice();
            InvoiceGrid.DataSource = new BindingList<ModelInvoice>(db.GetAllInvoices());
        }

        private void DeleteOneInvoice_Click(object sender, EventArgs e)
        {
            if (InvoiceGrid.SelectedRows.Count > 0)
            {
                var model = InvoiceGrid.SelectedRows[0].DataBoundItem as ModelInvoice;
                db.DeleteOneInvoice(model);
                InvoiceGrid.DataSource = new BindingList<ModelInvoice>(db.GetAllInvoices());
            }
        }

        private void InvoiceSelection(object sender, EventArgs e)
        {
            if (InvoiceGrid.SelectedRows.Count > 0)
            {
                var model = InvoiceGrid.SelectedRows[0].DataBoundItem as ModelInvoice;
                if (model.Type == 0)
                {
                    InvoiceType0.Checked = true;
                }
                else
                {
                    InvoiceType1.Checked = true;
                }
                var list = SubjectCombo.DataSource as BindingList<ModelSubject>;
                var item = list.FirstOrDefault(i=>i.Id == model.IdSubject);
                SubjectCombo.SelectedItem = item;

                OperationGrid.DataSource = new BindingList<ModelOperation>(db.GetInvoiceOperations(model));

            }
        }

        private void InvoiceUpdate_Click(object sender, EventArgs e)
        {
            if (InvoiceGrid.SelectedRows.Count > 0 && SubjectCombo.SelectedIndex >=0)
            {
                var model = InvoiceGrid.SelectedRows[0].DataBoundItem as ModelInvoice;
                model.Type = InvoiceType0.Checked ? 0 : 1;
                model.IdSubject = (SubjectCombo.SelectedItem as ModelSubject).Id;
                model.UpdatedAt = DateTime.Now;
                db.UpdateOneInvoice(model);
                InvoiceGrid.DataSource = new BindingList<ModelInvoice>(db.GetAllInvoices());
            }
        }

        private void ProductOperationSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoiceGrid.SelectedRows.Count > 0 && ProductSelectGrid.SelectedRows.Count > 0)
            {
                var product = ProductSelectGrid.SelectedRows[0].DataBoundItem as ModelProduct;
                var operation = new ModelOperation();
                var invoice = InvoiceGrid.SelectedRows[0].DataBoundItem as ModelInvoice;
                if (new OperationWindow(product, operation, invoice).ShowDialog() == DialogResult.OK)
                {
                    db.AddNewOperation(operation);
                    OperationGrid.DataSource = new BindingList<ModelOperation>(db.GetInvoiceOperations(invoice));
                }
            }
        }

        private void AddOneOperation(object sender, EventArgs e)
        {
            ProductOperationSelect(sender, null);
        }

        private void DeleteOneOperation(object sender, EventArgs e)
        {
            if (OperationGrid.SelectedRows.Count >0)
            {
                var invoice = InvoiceGrid.SelectedRows[0].DataBoundItem as ModelInvoice;
                var operation = OperationGrid.SelectedRows[0].DataBoundItem as ModelOperation;
                db.DeleteOneOperation(operation);
                OperationGrid.DataSource = new BindingList<ModelOperation>(db.GetInvoiceOperations(invoice));
            }
        }

        private void TotalsFiltration(object sender, EventArgs e)
        {
            var text = searchText.Text;
            TotalGrid.DataSource = new BindingList<ModelTotal>(db.GetTotals(text));
        }
    }
}
