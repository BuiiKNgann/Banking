using bank.Controller;
using bank.View;

namespace bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserId.Text;
            string password = txtPassword.Text;

            EmployeeController employeeController = new EmployeeController();
            string role = employeeController.Login(id, password);

            if (role != null)
            {
                Menu mainMenu = new Menu();

                switch (role)
                {
                    case "Manager":
                        // Nếu là Manager, hiển thị đầy đủ menu
                        mainMenu.Show();
                        break;

                    case "Clerk":
                        // Nếu là Clerk, hiển thị menu và ẩn các mục không liên quan
                        mainMenu.Show();

                        // Ẩn các mục không phải là deposit, transfer hoặc withdraw
                        foreach (ToolStripMenuItem item in mainMenu.MainMenuStrip.Items)
                        {
                            if (item.Name != "giaodich" )
                                //&&
                                //item.Name != "transferToolStripMenuItem" &&
                                //item.Name != "withdrawToolStripMenuItem")
                            {
                                item.Visible = false; // Ẩn mục menu chính
                            }
                        }

                        // Kiểm tra mục con nếu có
                        foreach (ToolStripMenuItem item in mainMenu.MainMenuStrip.Items)
                        {
                            foreach (ToolStripMenuItem subItem in item.DropDownItems)
                            {
                                if (subItem.Name != "deposit" &&
                                    subItem.Name != "transfer" &&
                                    subItem.Name != "withdraw" &&
                                    subItem.Name != "transactionToolStripMenuItem")   
                                {
                                    subItem.Visible = false; // Ẩn mục con nếu không phải là deposit, transfer hoặc withdraw
                                }
                            }
                        }
                        break;

                    default:
                        MessageBox.Show("Không xác định được quyền của người dùng.");
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra thông tin tài khoản.");
            }
        }

    }
}
