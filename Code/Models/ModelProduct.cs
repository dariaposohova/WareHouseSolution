using System.ComponentModel;

namespace WareHouseSpace.Model
{
    public class ModelProduct
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Назва товару")]
        public string Name { get; set; }
        [DisplayName("Опис товару")]
        public string Description { get; set; }
        [DisplayName("Одиниця виміру")]
        public string Unit { get; set; }

        public void Update(ModelProduct product)
        {
            Name = product.Name;
            Description = product.Description;
            Unit = product.Unit;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
