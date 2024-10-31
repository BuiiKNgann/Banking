using bank.Controller;
using bank.Model;
using bank.View;
using Guna.UI2.AnimatorNS;
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
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace bank
{
    public partial class AccountView : Form, IView
    {
        private AccountController controller;
        private AccountModel account;
        private BindingList<AccountModel> accountList;
        public DateTime selectedDate;
        public AccountView()
        {
            InitializeComponent();
            controller = new AccountController();
            account = new AccountModel();
            accountList = new BindingList<AccountModel>();
            text_Date.CustomFormat = "dd/MM/yyyy";
            text_Date.Format = DateTimePickerFormat.Custom;
            this.Load += new EventHandler(AccountView_Load);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText(); // Cập nhật dữ liệu trong TextBox khi chọn dòng mới
            }

        }
        public void SetDataToText()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                account = new AccountModel
                {
                    id = int.Parse(selectedRow.Cells["id"].Value.ToString()),
                    customerid = selectedRow.Cells["customerid"].Value.ToString(),
                    date_opened = DateTime.ParseExact(selectedRow.Cells["date_opened"].Value.ToString(), "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture),
                    balance = double.Parse(selectedRow.Cells["balance"].Value.ToString()),
                };

                // Cập nhật dữ liệu vào TextBox
                txtId.Text = account.id.ToString();
                txtID_KH.Text = account.customerid;
                text_Date.Value = account.date_opened;
                txtBalance.Text = account.balance.ToString("F2");
            }
        }

        //public void GetDataFromText()
        //{
        //    account.id = int.Parse(txtId.Text.Trim());
        //    account.customerid = txtID_KH.Text.Trim();
        //    account.date_opened = txt_Date.Value;
        //    account.balance = float.Parse(txtBalance.Text.Trim());
        //}
        public void GetDataFromText()
        {

            account.id = int.Parse(txtId.Text.Trim()); // Chuyển đổi Id
            account.customerid = txtID_KH.Text.Trim(); // Lấy mã khách hàng
            account.date_opened = text_Date.Value; // Ngày mở tài khoản
            account.balance = double.Parse(txtBalance.Text.Trim());



        }

        public void UpdateDataGridView()
        {
            accountList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var account in controller.Items.Cast<AccountModel>())
            {
                accountList.Add(account); // Thêm mỗi chi nhánh vào BindingList
            }

            dataGridView1.DataSource = accountList; // Gán BindingList làm nguồn dữ liệu
        }
        //private void btn_Create_Click(object sender, EventArgs e)
        //{
           
        //}

        private void txt_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            try
            {
                if (controller.Load())
                {
                    var accountData = controller.Items.Cast<AccountModel>().Select(account => new
                    {
                        id = account.id,
                        customerid = account.customerid,
                        date_opened = account.date_opened.ToString("dd/MM/yyyy"), // Định dạng ngày tháng
                        balance = account.balance
                    }).ToList();

                    dataGridView1.DataSource = accountData; // Gán danh sách mới
                    dataGridView1.Columns["id"].HeaderText = "Mã Tài Khoản";
                    dataGridView1.Columns["customerid"].HeaderText = "Mã Khách Hàng";
                    dataGridView1.Columns["date_opened"].HeaderText = "Ngày Mở";
                    dataGridView1.Columns["balance"].HeaderText = "Số Dư Tài Khoản";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu: {ex.Message}");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (account.IsValidate()) // Đảm bảo bạn đã cài đặt phương thức xác thực trong AccountModel
            {
                try
                {
                    // Gọi hàm Delete với đối tượng AccountModel
                    if (controller.Delete(account))
                    {
                        MessageBox.Show("Tài khoản đã được xóa thành công!");
                        ClearForm();
                        LoadAccounts(); // Làm mới danh sách tài khoản
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa tài khoản.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (account.IsValidate())
            {
                try
                {
                    if (controller.Update(account))
                    {
                        MessageBox.Show("Tài khoản đã được cập nhật thành công!");
                        ClearForm();
                        LoadAccounts(); // Tải lại danh sách sau khi cập nhật
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật tài khoản.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
        public void SearchAccountById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi nhánh với ID đã cho.");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            string id = txtTim.Text; // Giả sử bạn có một TextBox để nhập ID
            SearchAccountById(id);

        }

        private void ClearForm()
        {
            txtId.Text = string.Empty;
            txtID_KH.Text = string.Empty;
            text_Date.Text = string.Empty;
            txtBalance.Text = string.Empty;

        }

        private void btn_Create_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (account.IsValidate())
            {
                try
                {
                    // Create a new branch
                    if (controller.Create(account))
                    {
                        MessageBox.Show("Tài khoản đã được thêm thành công!");
                        ClearForm();
                        LoadAccounts(); // Refresh the list of branches
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm tài khoản.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
        }
    }
}



