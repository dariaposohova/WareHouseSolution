using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseSpace.Models
{
    public class ModelTotal
    {
        [DisplayName("Назва товару")]
        public string ProductName { get; set; }
        [DisplayName("Опис товару")]
        public string Desc { get; set; }
        [DisplayName("Кількість")]
        public double Amount { get; set; }
        [DisplayName("Одиниця виміру")]
        public string Unit{ get; set; }
    }
}
