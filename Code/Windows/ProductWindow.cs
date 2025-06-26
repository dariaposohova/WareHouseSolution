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

namespace WareHouseSpace
{
    public partial class ProductWindow : Form
    {
        ModelProduct model_;
        public ProductWindow(ModelProduct model, bool editing=false)
        {
            InitializeComponent();
            this.model_ = model;
            Text = editing ? $"Редагування товару [{model.Name}]" : "Стоврення нового товару";
            if (editing)
            {
                tbName.Text = model_.Name;
                tbUnits.Text = model_.Unit;
                tbDescription.Text = model_.Description;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var units = tbUnits.Text;
            var description = tbDescription.Text;

            if (name.Length == 0 || units.Length == 0 || description.Length == 0)
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                        
            model_.Name = name;
            model_.Unit = units;
            model_.Description = description;

            DialogResult = DialogResult.OK; 
            Close();
        }
    }
}
