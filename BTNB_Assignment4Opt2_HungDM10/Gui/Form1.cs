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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            FrmNewContact frmNc = new FrmNewContact();
            frmNc.Show();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            FrmContact h = new FrmContact();
            h.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Warning!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
