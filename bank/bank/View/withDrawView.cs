using bank.Controller;
using bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bank.View
{
    public partial class withDrawView : Form, IView
    {
        private AccountController accountController = new AccountController();

        public withDrawView()
        {
            InitializeComponent();
            LoadAccountIds();
        }

        private void LoadAccountIds()
        {
            accountController.Load(); // Tải tất cả tài khoản từ DB
            List<IModel> accounts = accountController.Items;

            // Duyệt qua từng tài khoản và thêm ID vào ComboBox
            foreach (AccountModel account in accounts)
            {
                cmbAccountID.Items.Add(account.id);
            }
        }

        public void GetDataFromText()
        {
            // Lấy dữ liệu từ các điều khiển
            if (cmbAccountID.SelectedItem != null)
            {
                // Lấy ID tài khoản đã chọn
                string accountId = cmbAccountID.SelectedItem.ToString();

                // Lấy số tiền từ txtAmount
                double.TryParse(txtAmount.Text, out double amount);
            }
        }

        public void SetDataToText()
        {
            if (cmbAccountID.SelectedItem != null)
            {
                // Lấy ID tài khoản đã chọn
                string accountId = cmbAccountID.SelectedItem.ToString();

                // Cập nhật số dư vào txtBalance
                double balance = accountController.GetBalance(accountId);
                txtBalance.Text = balance.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")); // Hiển thị số dư theo định dạng VND
            }
        }

        private void cmbAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountID.SelectedItem != null)
            {
                string accountId = cmbAccountID.SelectedItem.ToString();
                double balance = accountController.GetBalance(accountId);
                txtBalance.Text = balance.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")); // Hiển thị số dư theo định dạng VND
            }
        }
        private void ClearForm()
        {
            txtAmount.Text = string.Empty;


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmbAccountID.SelectedItem == null || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản và nhập số tiền.");
                return;
            }
          

            GetDataFromText(); // Gọi để lấy dữ liệu từ các điều khiển

            string accountId = cmbAccountID.SelectedItem.ToString();
            if (double.TryParse(txtAmount.Text, out double amount) && amount > 0)
            {
                // Gọi phương thức Withdraw từ accountController
                bool success = accountController.Withdraw(accountId, amount);
                if (success)
                {
                    // Ghi nhận giao dịch
                    TransactionModel transaction = new TransactionModel
                    {
                        from_account_id = Convert.ToInt32(accountId), // Tài khoản rút tiền
                        to_account_id = Convert.ToInt32(accountId), // Cùng tài khoản cho việc rút tiền
                        amount = -amount, // Sử dụng giá trị âm để biểu thị việc rút tiền
                        date_of_trans = DateTime.Now,
                    };

                    // Lưu transaction vào DB hoặc danh sách giao dịch
                    // transactionController.SaveTransaction(transaction); // Giả định bạn có một controller cho giao dịch

                    MessageBox.Show("Rút tiền thành công!");
                    SetDataToText(); // Cập nhật lại số dư
                }
                else
                {
                    MessageBox.Show("Rút tiền thất bại. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void withDrawView_Load(object sender, EventArgs e)
        {

        }
    }
}
