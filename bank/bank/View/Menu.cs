using bank.Controller;
using bank.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void chiNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branchView tk = new branchView();
            tk.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeView ep = new employeeView();
            ep.Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerView cs = new customerView();
            cs.Show();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gọi phương thức đăng xuất từ EmployeeController
            EmployeeController employeeController = new EmployeeController();
            employeeController.Logout();

            // Hiển thị lại form đăng nhập
            this.Hide(); // Ẩn form chính
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close(); // Đóng form chính sau khi đăng xuất
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            depositView dw = new depositView();
            dw.Show();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            transferView tw = new transferView();
            tw.Show();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            withDrawView ww = new withDrawView();
            ww.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            transactionView tw = new transactionView();
            tw.Show();
        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AccountView tw = new AccountView();
            tw.Show();
        }
    }
}
