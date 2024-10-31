using bank.Controller;
using bank.Model;
using bank.View;
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

namespace bank
{
    public partial class employeeView : Form, IView
    {

        private EmployeeController controller;
        private EmployeeModel employee;
        private BindingList<EmployeeModel> employeeList; // Thêm BindingList



        public employeeView()
        {
            InitializeComponent();
            controller = new EmployeeController();
            employee = new EmployeeModel();
            employeeList = new BindingList<EmployeeModel>();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GetDataFromText(); // Get data from input fields
                               // Validate the input
            if (employee.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {
                    // Create a new branch
                    if (controller.Create(employee))
                    {
                        MessageBox.Show("Chi nhánh đã được thêm thành công!");
                        ClearForm();
                        LoadEmployees(); // Refresh the list of branches
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

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                employee = new EmployeeModel
                {
                    id = selectedRow.Cells["id"].Value.ToString(),
                    password = selectedRow.Cells["password"].Value.ToString(),
                    role = selectedRow.Cells["role"].Value.ToString(),

                };

                // Cập nhật dữ liệu vào TextBox
                txtId.Text = employee.id;
                txtPassword.Text = employee.password;
                txtRole.Text = employee.role;

            }
        }

        public void GetDataFromText()
        {
            employee.id = txtId.Text.Trim();
            employee.password = txtPassword.Text.Trim();
            employee.role = txtRole.Text.Trim();

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



        private void btn_delete_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {

                    // Gọi hàm Delete với đối tượng BranchModel
                    if (controller.Delete(employee))
                    {
                        MessageBox.Show("Khách hàng đã được xóa thành công!");
                          ClearForm();
                        LoadEmployees(); // Refresh the list of branches
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa khách hàng.");
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate()) // Kiểm tra tính hợp lệ của dữ liệu
            {
                try
                {
                    if (controller.Update(employee)) // Cập nhật thông tin nhân viên
                    {
                        MessageBox.Show("Nhân viên đã được cập nhật thành công!");
                        ClearForm();
                        LoadEmployees(); // Tải lại danh sách nhân viên sau khi cập nhật
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên.");
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


        private void employeeView_Load_1(object sender, EventArgs e)
        {
            LoadEmployees();

        }
        public void UpdateDataGridView()
        {
            employeeList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var employee in controller.Items.Cast<EmployeeModel>())
            {
                employeeList.Add(employee); // Thêm mỗi chi nhánh vào BindingList
            }

            guna2DataGridView1.DataSource = employeeList; // Gán BindingList làm nguồn dữ liệu
        }

        private void LoadEmployees()
        {
            try
            {
                if (controller.Load())
                {
                    var employeeData = controller.Items.Cast<EmployeeModel>().Select(employee => new
                    {
                        id = employee.id,
                        password = employee.password,
                        role = employee.role

                    }).ToList();

                    guna2DataGridView1.DataSource = employeeData; // Gán danh sách mới
                    // Đặt tên hiển thị cho các cột
                    guna2DataGridView1.Columns["id"].HeaderText = "Mã nhân viên";
                    guna2DataGridView1.Columns["password"].HeaderText = "Mật khẩu";
                    guna2DataGridView1.Columns["role"].HeaderText = "Role";

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

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {

        }

        public void SearchEmplyeeById(string id)
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
            SearchEmplyeeById(id);
        }
        private void ClearForm()
        {
            txtId.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRole.Text = string.Empty;
            

        }
    }
}
