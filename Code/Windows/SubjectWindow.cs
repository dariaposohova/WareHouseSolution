using System;
using System.Windows.Forms;
using WareHouseSpace.Models;

namespace WareHouseSpace
{
    public partial class SubjectWindow : Form
    {
        ModelSubject model_;
        public SubjectWindow(ModelSubject model, bool editing = false)
        {
            InitializeComponent();
            this.model_ = model;
            Text = editing ? $"Редагування контрагенту [{model.Name}]" : "Стоврення нового контрагенту";
            if (editing)
            {
                tbName.Text = model_.Name;
                tbContacts.Text = model_.Contacts;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var contacts = tbContacts.Text;

            if (name.Length == 0 || contacts.Length == 0)
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            model_.Name = name;
            model_.Contacts = contacts;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
