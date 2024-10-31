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
    public partial class customerView : Form, IView
    {
        private CustomerController controller;
        private CustomerModel customer;
        private BindingList<CustomerModel> customerList; // Thêm BindingList

        public customerView()
        {
            InitializeComponent();
            controller = new CustomerController();
            customer = new CustomerModel();
            customerList = new BindingList<CustomerModel>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void customer_Load(object sender, EventArgs e)
        {

            LoadCustomer();
        }

        private void LoadCustomer()
        {
            try
            {
                if (controller.Load())
                {
                    var customerData = controller.Items.Cast<CustomerModel>().Select(customer => new
                    {
                        id = customer.id,
                        name = customer.name,
                        phone = customer.phone,
                        email = customer.email,
                        house_no = customer.house_no,
                        city = customer.city
                    }).ToList();

                    guna2DataGridView3.DataSource = customerData; // Gán danh sách mới
                                                                  // Đặt tên hiển thị cho các cột
                    guna2DataGridView3.Columns["id"].HeaderText = "Mã khách hàng";
                    guna2DataGridView3.Columns["name"].HeaderText = "Tên khách hàng";
                    guna2DataGridView3.Columns["phone"].HeaderText = "Số điện thoại";
                    guna2DataGridView3.Columns["email"].HeaderText = "Email";
                    guna2DataGridView3.Columns["house_no"].HeaderText = "Địa chỉ";
                    guna2DataGridView3.Columns["city"].HeaderText = "Thành Phố";
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
        public void UpdateDataGridView()
        {
            customerList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var customer in controller.Items.Cast<CustomerModel>())
            {
                customerList.Add(customer); // Thêm mỗi chi nhánh vào BindingList
            }

            guna2DataGridView3.DataSource = customerList; // Gán BindingList làm nguồn dữ liệu
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetDataFromText(); // Get data from input fields
                               // Validate the input
            if (customer.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {
                    // Create a new branch
                    if (controller.Create(customer))
                    {
                        MessageBox.Show("Chi nhánh đã được thêm thành công!");
                        ClearForm();
                        LoadCustomer(); // Refresh the list of branches
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (customer.IsValidate())
            {
                try
                {
                    if (controller.Update(customer))
                    {
                        MessageBox.Show("Chi nhánh đã được cập nhật thành công!");
                        ClearForm();
                        LoadCustomer(); // Tải lại danh sách sau khi cập nhật
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
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (customer.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {

                    // Gọi hàm Delete với đối tượng BranchModel
                    if (controller.Delete(customer))
                    {
                        MessageBox.Show("Khách hàng đã được xóa thành công!");
                        ClearForm();
                        LoadCustomer(); // Refresh the list of branches
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

        private void ClearForm()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtHouse_no.Text = string.Empty;
            txtCity.Text = string.Empty;
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }
        public void GetDataFromText()
        {
            customer.id = txtId.Text.Trim();
            customer.name = txtName.Text.Trim();
            customer.phone = txtPhone.Text.Trim();
            customer.email = txtEmail.Text.Trim();
            customer.house_no = txtHouse_no.Text.Trim(); // Giữ nguyên thuộc tính HouseNo
            customer.city = txtCity.Text.Trim();
        }

        public void SetDataToText()
        {
            if (guna2DataGridView3.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView3.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                customer = new CustomerModel
                {
                    id = selectedRow.Cells["id"].Value.ToString(),
                    name = selectedRow.Cells["name"].Value.ToString(),
                    phone = selectedRow.Cells["phone"].Value.ToString(),
                    email = selectedRow.Cells["email"].Value.ToString(),
                    city = selectedRow.Cells["city"].Value.ToString(),
                    house_no = selectedRow.Cells["house_no"].Value.ToString()
                };

                // Cập nhật dữ liệu vào TextBox
                txtId.Text = customer.id;
                txtName.Text = customer.name;
                txtPhone.Text = customer.phone;
                txtEmail.Text = customer.email;
                txtHouse_no.Text = customer.house_no;
                txtCity.Text = customer.city;
            }
        }


        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }
        }
        private void guna2DataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView3.SelectedRows.Count > 0)
            {
                SetDataToText(); // Cập nhật dữ liệu trong TextBox khi chọn dòng mới
            }

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        public void SearchCustomerById(string id)
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
            SearchCustomerById(id);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}