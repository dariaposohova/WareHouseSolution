using System.ComponentModel;

namespace WareHouseSpace.Models
{
    public class ModelOperation
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int IdInvoice { get; set; }
        [Browsable(false)]
        public int IdProduct { get; set; }
        [DisplayName("Назва товару")]
        public string ProductName { get; set; }
        [DisplayName("Опис")]
        public string Description { get; set; }
        [DisplayName("Кількість")]
        public double Amount { get; set; }
        [DisplayName("Одиниця виміру")]
        public string Unit{ get; set; }
        [DisplayName("Ціна")]
        public double Price { get; set; }
    }
}
