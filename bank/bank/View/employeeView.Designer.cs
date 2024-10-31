namespace bank
{
    partial class employeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeView));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_search = new Button();
            txt_Tim = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            txtRole = new TextBox();
            txtId = new TextBox();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            txtPassword = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1573, 66);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(2091, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 331);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(guna2DataGridView1);
            panel3.Controls.Add(btn_search);
            panel3.Controls.Add(txt_Tim);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(46, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(1442, 593);
            panel3.TabIndex = 4;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(720, 214);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(683, 264);
            guna2DataGridView1.TabIndex = 9;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ButtonFace;
            btn_search.Cursor = Cursors.Hand;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.Location = new Point(1323, 124);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(50, 39);
            btn_search.TabIndex = 8;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_Tim
            // 
            txt_Tim.CustomizableEdges = customizableEdges3;
            txt_Tim.DefaultText = "";
            txt_Tim.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Tim.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Tim.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Tim.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Tim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Tim.Font = new Font("Segoe UI", 9F);
            txt_Tim.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Tim.Location = new Point(1027, 124);
            txt_Tim.Margin = new Padding(3, 4, 3, 4);
            txt_Tim.Name = "txt_Tim";
            txt_Tim.PasswordChar = '\0';
            txt_Tim.PlaceholderText = "";
            txt_Tim.SelectedText = "";
            txt_Tim.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_Tim.Size = new Size(290, 39);
            txt_Tim.TabIndex = 7;
            txt_Tim.TextChanged += txt_Tim_TextChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txtRole);
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(btn_edit);
            panel4.Controls.Add(btn_delete);
            panel4.Controls.Add(btn_add);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(113, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(491, 403);
            panel4.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(170, 211);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(250, 27);
            txtRole.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(170, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 18;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(326, 305);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 44);
            btn_edit.TabIndex = 16;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(180, 305);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 44);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Xoá";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(43, 305);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(97, 44);
            btn_add.TabIndex = 14;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 215);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 4;
            label6.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 153);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 232);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(634, 40);
            label1.Name = "label1";
            label1.Size = new Size(180, 42);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // employeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 746);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "employeeView";
            Text = "employee";
            Load += employeeView_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtId;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_add;
        private TextBox txtPassword;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Tim;
        private TextBox txtRole;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}