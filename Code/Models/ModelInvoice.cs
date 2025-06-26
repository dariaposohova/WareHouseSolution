using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseSpace.Models
{
    public class ModelInvoice
    {
        //[Browsable(false)]
        [DisplayName("Номер накладної")]

        public int Id { get; set; } 
        [Browsable(false)]
        public int IdSubject{ get; set; }
        [Browsable(false)]
        public int Type { get; set; }
        
        [DisplayName("Контрагент")]
        public string SubjectName { get; set; }
        [DisplayName("Тип накладної")]
        public string TypeName { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Оновлено")]
        public DateTime UpdatedAt { get; set; }
    }
}
