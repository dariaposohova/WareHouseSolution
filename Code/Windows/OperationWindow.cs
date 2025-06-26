using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseSpace.Model;
using WareHouseSpace.Models;

namespace WareHouseSpace.Windows
{
    public partial class OperationWindow : Form
    {
        ModelProduct product;
        ModelOperation operation;
        ModelInvoice invoice;
        public OperationWindow(ModelProduct product_, ModelOperation operation_, ModelInvoice invoice_, bool editing = false)
        {
            InitializeComponent();
            this.product = product_;
            this.operation = operation_;
            this.invoice = invoice_;
            tbName.Text = product_.Name;
            tbDescription.Text = product_.Description;
            tbUnits.Text = product_.Unit;
            Text = $"{product.Name} в накладну № {invoice.Id}";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text.Length == 0 || tbAmount.Text.Length == 0)
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка!");
                return;
            }
            double price, amount;

            if (!Double.TryParse(tbPrice.Text, out price) || !Double.TryParse(tbAmount.Text, out amount))
            {
                MessageBox.Show("Не коректні числові дані!", "Помилка!");
                return;
            }

            if (price <= 0 || amount <= 0)
            {
                MessageBox.Show("Не коректні числові дані!", "Помилка!");
                return;
            }

            operation.IdInvoice = invoice.Id;
            operation.IdProduct = product.Id;
            operation.Amount = amount;
            operation.Price = price;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
