using Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class FrmContact : Form
    {
        public FrmContact()
        {
            InitializeComponent();
        }
        ContactBus objBus = new ContactBus();

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
                MessageBox.Show("You need to choose an ID to Update");
            else {
                btnUpdate.Enabled = true;
                TextEnable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fullName = InternalGui.NoiChuoi(txtFirstName.Text, txtLastName.Text);
            bool updated = objBus.Update(int.Parse(txtID.Text),fullName, txtGroup.Text, txtAddress.Text, txtPhone.Text);
            if (updated)
            { MessageBox.Show("Update successful");
                FrmContact_Load(sender, e);
            }
            else
                MessageBox.Show("Fail");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (objBus.Delete(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Delete successful");
                FrmContact_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void ClearText()
        {
            txtID.ResetText();
            txtPhone.ResetText();
            txtAddress.ResetText();
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtGroup.ResetText();
        }
        private void TextEnable()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
            txtGroup.Enabled = true;
            txtPhone.Enabled = true;
        }
        private void TextDisable()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtGroup.Enabled = false;
            txtPhone.Enabled = false;
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {
            TextDisable();
            ClearText();
            dgvContact.DataSource = objBus.GetAllContact();
        }

        private void dgvContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName, lastName,fullName;
            string[] arrName;
            string[] lastArr = new string[2];
            int n = dgvContact.CurrentRow.Index;
            fullName = dgvContact.Rows[n].Cells["FullName"].Value.ToString().Trim();
            arrName = InternalGui.TachChuoi(fullName);

            for (int i = 0; i < arrName.Length - 1; i++)
            {
                lastArr[0] += " "+ arrName[i];
                lastArr[1] = arrName[arrName.Length - 1];

            }

            firstName = lastArr[0];
            lastName = lastArr[1];
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
            TextDisable();

            txtID.Text = dgvContact.Rows[n].Cells["ID"].Value.ToString();
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtAddress.Text = dgvContact.Rows[n].Cells["Address"].Value.ToString().Trim();
            txtPhone.Text = dgvContact.Rows[n].Cells["Phone"].Value.ToString().Trim();
            txtGroup.Text = dgvContact.Rows[n].Cells["Group"].Value.ToString();
        }
    }
}
