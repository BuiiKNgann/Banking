using bank.Controller;
using bank.Model;
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
using System.Xml.Linq;
 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace bank
{
    public partial class transactionView : Form, IView
    {
        private TransactionController controller;
        private TransactionModel transaction;
        private BindingList<TransactionModel> transactionList;
        public DateTime selectedDate;
        public transactionView()
        {
            InitializeComponent();
            controller = new TransactionController();
            transaction = new TransactionModel();
            transactionList = new BindingList<TransactionModel>();
            //txtDate.CustomFormat = "dd/MM/yyyy";
            //txtDate.Format = DateTimePickerFormat.Custom;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (transaction.IsValidate())
            {
                try
                {
                    // Create a new branch
                    if (controller.Create(transaction))
                    {
                        MessageBox.Show("Tài khoản đã được thêm thành công!");
                        ClearForm();
                        LoadTransaction(); // Refresh the list of branches
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }

        }
        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText(); // Cập nhật dữ liệu trong TextBox khi chọn dòng mới
            }

        }

        public void SetDataToText()
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                transaction = new TransactionModel
                {
                    id = int.Parse(selectedRow.Cells["id"].Value.ToString()),
                    branch_id = selectedRow.Cells["branch_id"].Value.ToString(),
                    from_account_id = int.Parse(selectedRow.Cells["from_account_id"].Value.ToString()),
                    date_of_trans = DateTime.ParseExact(selectedRow.Cells["date_of_trans"].Value.ToString(), "dd/MM/yyyy",
                     System.Globalization.CultureInfo.InvariantCulture),
                    house_no = selectedRow.Cells["house_no"].Value.ToString(),
                    amount = double.Parse(selectedRow.Cells["amount"].Value.ToString()),
                    to_account_id = int.Parse(selectedRow.Cells["to_account_id"].Value.ToString()),
                    employee_id = selectedRow.Cells["employee_id"].Value.ToString(),

                };


                //txtId.Text = transaction.id.ToString();
                //txtBranch_id.Text = transaction.branch_id;
                //txtFrom_IDACT.Text = transaction.from_account_id.ToString();
                //txtDate.Value = transaction.date_of_trans;
                //txthouse_no.Text = transaction.house_no.ToString();
                //txt_amount.Text = transaction.amount.ToString("F2");
                //txtTo_IDACT.Text = transaction.to_account_id.ToString();
                //txtNV.Text = transaction.employee_id.ToString();

            }
        }

        public void UpdateDataGridView()
        {
            transactionList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var transaction in controller.Items.Cast<TransactionModel>())
            {
                transactionList.Add(transaction); // Thêm mỗi chi nhánh vào BindingList
            }

            guna2DataGridView1.DataSource = transactionList; // Gán BindingList làm nguồn dữ liệu
        }

        public void GetDataFromText()


        {
            //transaction.id = int.Parse(txtId.Text.Trim());
            //transaction.branch_id = txtBranch_id.Text.Trim();
            //transaction.from_account_id = int.Parse(txtFrom_IDACT.Text.Trim());
            //transaction.date_of_trans = txtDate.Value;
            //transaction.house_no = txthouse_no.Text.Trim();
            //transaction.amount = float.Parse(txt_amount.Text.Trim());
            //transaction.to_account_id = int.Parse(txtTo_IDACT.Text.Trim());
            //transaction.employee_id = txtNV.Text.Trim();

        }

        private void transactionView_Load(object sender, EventArgs e)
        {
            LoadTransaction();
        }

        private void LoadTransaction()
        {
            try
            {
                if (controller.Load())
                {
                    var transactionData = controller.Items.Cast<TransactionModel>().Select(transaction => new
                    {
                        id = transaction.id,
                        from_account_id = transaction.from_account_id,
                        branch_id = transaction.branch_id,
                        date_of_trans = transaction.date_of_trans.ToString("dd/MM/yyyy"), // Định dạng ngày tháng
                        house_no = transaction.house_no,
                        amount = transaction.amount,
                        to_account_id = transaction.to_account_id,
                        employee_id = transaction.employee_id,

                    }).ToList();

                    guna2DataGridView1.DataSource = transactionData; // Gán danh sách mới
                    guna2DataGridView1.Columns["id"].HeaderText = "Mã giao dịch";
                    guna2DataGridView1.Columns["from_account_id"].HeaderText = "Từ tài khoản";
                    guna2DataGridView1.Columns["branch_id"].HeaderText = "Mã chi nhánh";
                    guna2DataGridView1.Columns["date_of_trans"].HeaderText = "Ngày chuyển tiền";
                    guna2DataGridView1.Columns["house_no"].HeaderText = "Địa chỉ";
                    guna2DataGridView1.Columns["amount"].HeaderText = "Số tiền ";
                    guna2DataGridView1.Columns["to_account_id"].HeaderText = "Đến tài khoản";
                    guna2DataGridView1.Columns["employee_id"].HeaderText = "Mã nhân viên";
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
        private void ClearForm()

        {
            //txtId.Text = string.Empty;
            //txtBranch_id.Text = string.Empty;
            //txtFrom_IDACT.Text = string.Empty;
            //txtDate.Text = string.Empty;
            //txthouse_no.Text = string.Empty;
            //txt_amount.Text = string.Empty;
            //txtTo_IDACT.Text = string.Empty;
            //txtNV.Text = string.Empty;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            GetDataFromText();

            if (transaction.IsValidate()) // Đảm bảo bạn đã cài đặt phương thức xác thực trong AccountModel
            {
                try
                {
                    // Gọi hàm Delete với đối tượng AccountModel
                    if (controller.Delete(transaction))
                    {
                        MessageBox.Show("Tài khoản đã được xóa thành công!");
                        ClearForm();
                        LoadTransaction(); // Làm mới danh sách tài khoản
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (transaction.IsValidate())
            {
                try
                {
                    if (controller.Update(transaction))
                    {
                        MessageBox.Show("Tài khoản đã được cập nhật thành công!");
                        ClearForm();
                        LoadTransaction(); // Tải lại danh sách sau khi cập nhật
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

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {

        }
        public void SearchTransactionById(string id)
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
        private void btn_search_Click(object sender, EventArgs e)
        {
            
                string id = txt_Tim.Text; // Giả sử bạn có một TextBox để nhập ID
            SearchTransactionById(id);
        }
    }
}
