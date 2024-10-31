using bank.Controller;
using bank.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bank.View
{
    public partial class transferView : Form
    {
        private AccountController accountController;
        private TransactionController transactionController;
        public transferView()
        {
            InitializeComponent();
            accountController = new AccountController();
            transactionController = new TransactionController();
            LoadAccounts();

        }

        private void LoadAccounts()
        {
            List<AccountModel> accounts = accountController.GetAllAccounts();

            cmbFormAccountID.DataSource = new BindingSource(accounts, null);
            cmbFormAccountID.DisplayMember = "id";
            cmbFormAccountID.ValueMember = "id";

            cmbToAccountID.DataSource = new BindingSource(accounts, null);
            cmbToAccountID.DisplayMember = "id";
            cmbToAccountID.ValueMember = "id";
        }





        private void cmbFormAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormAccountID.SelectedValue != null)
            {
                string selectedAccountId = cmbFormAccountID.SelectedValue.ToString();
                double balance = accountController.GetBalance(selectedAccountId);
                //    txtBalance.Text = $"{balance}";
                txtBalance.Text = balance.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")); // Hiển thị số dư theo định dạng VND
            }

        }
        private void ClearForm()
        {
            txtAmount.Text = string.Empty;


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string fromAccountId = cmbFormAccountID.SelectedValue.ToString();
            string toAccountId = cmbToAccountID.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txtAmount.Text) || !double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Số tiền không hợp lệ.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0.");
                return;
            }

            if (fromAccountId == toAccountId)
            {
                MessageBox.Show("Tài khoản gửi và tài khoản nhận phải khác nhau.");
                return;
            }


            bool success = accountController.Transfer(fromAccountId, toAccountId, amount);

            if (success)
            {
                MessageBox.Show("Chuyển tiền thành công!");
                LogTransaction(fromAccountId, toAccountId, amount);
                ClearForm();
                LoadAccounts(); // Cập nhật danh sách tài khoản
            }
            else
            {
                MessageBox.Show("Chuyển tiền thất bại. Vui lòng kiểm tra số dư hoặc thử lại sau.");
            }
        }
        private bool LogTransaction(string fromAccountId, string toAccountId, double amount)
        {
            string employeeId = GetRandomEmployeeId(); // Lấy employee_id ngẫu nhiên từ bảng EMPLOYEE
            string branchId = GetRandomBranchId(); // Lấy branch_id ngẫu nhiên từ bảng BRANCH

            if (string.IsNullOrEmpty(employeeId) || string.IsNullOrEmpty(branchId))
            {
                MessageBox.Show("Không tìm thấy employee_id hoặc branch_id hợp lệ.");
                return false;
            }

            var transaction = new TransactionModel
            {
                id = GenerateTransactionId(), // Tạo ID giao dịch
                from_account_id = int.Parse(fromAccountId),
                to_account_id = int.Parse(toAccountId),
                branch_id = branchId, // Sử dụng branch_id ngẫu nhiên
                date_of_trans = DateTime.Now,
                house_no = "HN123", // Cập nhật nếu cần
                amount = amount,
                employee_id = employeeId // Sử dụng employee_id ngẫu nhiên
            };

            return transactionController.Create(transaction);
        }
        private string GetRandomEmployeeId()
        {
            using (SqlConnection connection = new SqlConnection("Server=NGANBUI2003;Initial Catalog=Banking;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT TOP 1 id FROM EMPLOYEE ORDER BY NEWID()"; // Lấy ngẫu nhiên một employee_id
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar()?.ToString(); // Trả về employee_id ngẫu nhiên
                }
            }
        }

        private string GetRandomBranchId()
        {
            using (SqlConnection connection = new SqlConnection("Server=NGANBUI2003;Initial Catalog=Banking;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT TOP 1 id FROM BRANCH ORDER BY NEWID()"; // Lấy ngẫu nhiên một branch_id
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar()?.ToString(); // Trả về branch_id ngẫu nhiên
                }
            }
        }



        private int GenerateTransactionId()
        {
            // Implement a unique ID generation logic here if necessary
            return new Random().Next(1000, 9999);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferView_Load(object sender, EventArgs e)
        {

        }
    }
}
