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
    public partial class FrmNewContact : Form
    {
        public FrmNewContact()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPhone.ResetText();
            txtAddress.ResetText();
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtGroup.ResetText();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = InternalGui.NoiChuoi(txtFirstName.Text, txtLastName.Text);
            bool inserted = NewContactBus.Insert(fullName, txtGroup.Text, txtAddress.Text, txtPhone.Text);
            if (inserted)
                MessageBox.Show("Insert successful");
            else
                MessageBox.Show("Fail");
        }
    }
}
