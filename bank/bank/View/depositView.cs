using bank.Controller;
using bank.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bank.View
{
    public partial class depositView : Form, IView

    {
        private AccountController accountController = new AccountController();
        public depositView()
        {
            InitializeComponent();
            LoadAccountIds();



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

                // Có thể lưu accountId và amount vào một đối tượng model nào đó nếu cần
                // Ví dụ: 
                // this.currentAccountId = accountId;
                // this.depositAmount = amount;
            }
        }

        public void SetDataToText()
        { // Thiết lập dữ liệu vào các điều khiển
            if (cmbAccountID.SelectedItem != null)
            {
                // Lấy ID tài khoản đã chọn
                string accountId = cmbAccountID.SelectedItem.ToString();

                // Cập nhật số dư vào txtBalance
                double balance = accountController.GetBalance(accountId);
                txtBalance.Text = balance.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")); // Hiển thị số dư theo định dạng VND// Định dạng số dư với 2 chữ số sau dấu phẩy
            }
        }


        // Sự kiện khi nhấn nút Gửi tiền


        private void btn_save_Click(object sender, EventArgs e)
        {
            //if (cmbAccountID.SelectedItem == null || string.IsNullOrEmpty(txtAmount.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn tài khoản và nhập số tiền.");
            //    return;
            //}

            //GetDataFromText(); // Gọi để lấy dữ liệu từ các điều khiển

            //string accountId = cmbAccountID.SelectedItem.ToString();
            //if (double.TryParse(txtAmount.Text, out double amount) && amount > 0)
            //{
            //    bool success = accountController.Deposit(accountId, amount);
            //    if (success)
            //    {
            //        MessageBox.Show("Nạp tiền thành công!");
            //        SetDataToText(); // Cập nhật lại số dư
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nạp tiền thất bại. Vui lòng thử lại.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            //}

            if (cmbAccountID.SelectedItem == null || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản và nhập số tiền.");
                return;
            }

            GetDataFromText(); // Gọi để lấy dữ liệu từ các điều khiển

            string accountId = cmbAccountID.SelectedItem.ToString();
            if (double.TryParse(txtAmount.Text, out double amount) && amount > 0)
            {
                bool success = accountController.Deposit(accountId, amount);
                if (success)
                {
                    // Ghi nhận giao dịch
                    TransactionModel transaction = new TransactionModel
                    {
                        from_account_id = Convert.ToInt32(accountId), // Hoặc ID tài khoản nào khác nếu cần
                        to_account_id = Convert.ToInt32(accountId), // Cùng tài khoản cho nạp tiền
                        amount = amount,
                        date_of_trans = DateTime.Now,
                        // Bạn có thể thêm thông tin chi nhánh và ID nhân viên nếu cần
                    };

                    // Lưu transaction vào DB hoặc danh sách giao dịch
                    // transactionController.SaveTransaction(transaction); // Giả định bạn có một controller cho giao dịch

                    MessageBox.Show("Nạp tiền thành công!");
                    ClearForm();
                    SetDataToText(); // Cập nhật lại số dư
                }
                else
                {
                    MessageBox.Show("Nạp tiền thất bại. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            }

        }

        private void ClearForm()
        {
            txtAmount.Text = string.Empty;
           
        }
    }
    }
     

     
 