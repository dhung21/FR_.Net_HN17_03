using Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DisableText();
            dgvNhanVien.DataSource= EmployeeBus.DisplayEmployee();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (EmployeeBus.Insert(txtHoTen.Text, txtDiaChi.Text, dtpNgaySinh.Value, int.Parse(txtLuong.Text)))
            {
                MessageBox.Show("Insert successful");
                Form1_Load(sender, e);
            }
            else
                MessageBox.Show("Failed");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            EnableText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (EmployeeBus.Update(int.Parse(txtMaNhanVien.Text), txtHoTen.Text, txtDiaChi.Text, dtpNgaySinh.Value, int.Parse(txtLuong.Text)))
            {
                MessageBox.Show("Update successful");
                Form1_Load(sender, e);
            }
            else
                MessageBox.Show("Failed");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (EmployeeBus.Delete(int.Parse(txtMaNhanVien.Text)))
            {
                MessageBox.Show("Delete successful");
                Form1_Load(sender, e);
            }
            else
                MessageBox.Show("Failed");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvNhanVien.CurrentRow.Index;
            btnXoa.Enabled = true;
            DisableText();

            txtMaNhanVien.Text = dgvNhanVien.Rows[n].Cells["EmpID"].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[n].Cells["Name"].Value.ToString().Trim();
            txtDiaChi.Text = dgvNhanVien.Rows[n].Cells["EmpAddress"].Value.ToString().Trim();
            dtpNgaySinh.Text = dgvNhanVien.Rows[n].Cells["Dob"].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[n].Cells["Salary"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = EmployeeBus.SearchEmployee(int.Parse(txtTimKiem.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            txtMaNhanVien.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtLuong.ResetText();
            dtpNgaySinh.ResetText();
            EnableText();
        }

        private void EnableText()
        {
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtLuong.Enabled = true;
        }

        private void DisableText()
        {
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtLuong.Enabled = false;
        }
    }
}
