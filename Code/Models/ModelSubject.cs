using System.ComponentModel;

namespace WareHouseSpace.Models
{
    public class ModelSubject
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("ПІБ")]
        public string Name { get; set; }
        [DisplayName("Контакти")]
        public string Contacts { get; set; }

        public override string ToString()
        {
            return $"{Name} {Contacts}";
        }
    }
}
