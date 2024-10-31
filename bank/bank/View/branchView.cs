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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;


namespace bank
{
    public partial class branchView : Form, IView
    {
        private BranchController controller;
        private BranchModel branch;
        private BindingList<BranchModel> branchList; // Thêm BindingList


        public branchView()
        {
            InitializeComponent();
            controller = new BranchController();
            branch = new BranchModel();
            branchList = new BindingList<BranchModel>();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetDataFromText()
        {
            branch.id = txtId.Text.Trim();
            branch.name = txtName.Text.Trim();
            branch.house_no = txthouse_no.Text.Trim(); // Giữ nguyên thuộc tính HouseNo
            branch.city = txtCity.Text.Trim();
        }
        public void SetDataToText()
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                branch = new BranchModel
                {
                    id = selectedRow.Cells["id"].Value.ToString(),
                    name = selectedRow.Cells["name"].Value.ToString(),
                    house_no = selectedRow.Cells["house_no"].Value.ToString(),
                    city = selectedRow.Cells["city"].Value.ToString(),

                };

                // Cập nhật dữ liệu vào TextBox
                txtId.Text = branch.id;
                txtName.Text = branch.name;
                txthouse_no.Text = branch.house_no;
                txtCity.Text = branch.city;

            }

        }

        private void branchView_Load(object sender, EventArgs e)
        {
            LoadBranches();

        }

        public void UpdateDataGridView()
        {
            branchList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var branch in controller.Items.Cast<BranchModel>())
            {
                branchList.Add(branch); // Thêm mỗi chi nhánh vào BindingList
            }

            dataGridView1.DataSource = branchList; // Gán BindingList làm nguồn dữ liệu
        }

        private void LoadBranches()
        {
            try
            {
                if (controller.Load())
                {
                    var branchData = controller.Items.Cast<BranchModel>().Select(branch => new
                    {
                        id = branch.id,
                        name = branch.name,
                        house_no = branch.house_no,
                        city = branch.city
                    }).ToList();

                    dataGridView1.DataSource = branchData; // Gán danh sách mới
                    // Đặt tên hiển thị cho các cột
                    dataGridView1.Columns["id"].HeaderText = "Mã Chi Nhánh";
                    dataGridView1.Columns["name"].HeaderText = "Tên Chi Nhánh";
                    dataGridView1.Columns["house_no"].HeaderText = "Địa chỉ";
                    dataGridView1.Columns["city"].HeaderText = "Thành Phố";
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

        private void btn_create_Click_Click(object sender, EventArgs e)
        {
            GetDataFromText(); // Get data from input fields
                               // Validate the input
            if (branch.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {
                    // Create a new branch
                    if (controller.Create(branch))
                    {
                        MessageBox.Show("Chi nhánh đã được thêm thành công!");
                        ClearForm();
                        LoadBranches(); // Refresh the list of branches
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm chi nhánh.");
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

        private void btn_Delete_Click_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (branch.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {

                    // Gọi hàm Delete với đối tượng BranchModel
                    if (controller.Delete(branch))
                    {
                        MessageBox.Show("Chi nhánh đã được xóa thành công!");
                        ClearForm();
                        LoadBranches(); // Refresh the list of branches
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa chi nhánh.");
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

        private void btn_edit_Click_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (branch.IsValidate())
            {
                try
                {
                    if (controller.Update(branch))
                    {
                        MessageBox.Show("Chi nhánh đã được cập nhật thành công!");
                        ClearForm();
                        LoadBranches(); // Tải lại danh sách sau khi cập nhật
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật chi nhánh.");
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

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txthouse_no.Text = string.Empty;
            txtCity.Text = string.Empty;

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

      
        public void SearchBranchById(string id)
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
        

        private void btn_Search_Click_1(object sender, EventArgs e)
        {

            string id = txtTim.Text; // Giả sử bạn có một TextBox để nhập ID
            SearchBranchById(id);
        }
    }


}
 
