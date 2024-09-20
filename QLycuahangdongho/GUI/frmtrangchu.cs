using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class trangchu : Form
    {
        private string role;
        private string email;
        public trangchu(string role, string email)
        {
            InitializeComponent();
            this.role = role;
            this.email = email;

            lbUserName.Text = "Xin chào "+email+" ";
            if (role == "PQ03")
            {
                guna2GradientButton8.Enabled = false;
            }
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            frmRevenue fRevenue = new frmRevenue();
            this.Hide();
            fRevenue.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            frmDongho fProduct = new frmDongho();
            this.Hide();
            fProduct.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật");
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            frmCustomers fCustomers = new frmCustomers();
            this.Hide();
            fCustomers.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.email = email;
            this.role = role;
            frmExportBills fBills = new frmExportBills(role, email);
            this.Hide();
            fBills.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

            frmLoaidongho frmLoaiVatTu = new frmLoaidongho();
            this.Hide();
            frmLoaiVatTu.ShowDialog();
            this.Show();
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportBill_Click(object sender, EventArgs e)
        {
            this.role = role;
            this.email = email;
            frmImportBill fImportBill = new frmImportBill(role, email);
            this.Hide(); 
            fImportBill.ShowDialog();
            this.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            frmQlnhanvien frmStaffs = new frmQlnhanvien();
            this.Hide();
            frmStaffs.ShowDialog();
            this.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
