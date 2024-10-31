namespace bank
{
    partial class AccountView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btn_Search = new Button();
            txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            panel4 = new Panel();
            text_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtId = new TextBox();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Create = new Button();
            txtID_KH = new TextBox();
            txtBalance = new TextBox();
            txtDate = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(1571, 66);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(2089, 69);
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
            panel3.Controls.Add(btn_Search);
            panel3.Controls.Add(txtTim);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(143, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(1298, 618);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = SystemColors.ButtonFace;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.Image = (Image)resources.GetObject("btn_Search.Image");
            btn_Search.Location = new Point(1191, 142);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(50, 39);
            btn_Search.TabIndex = 4;
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // txtTim
            // 
            txtTim.CustomizableEdges = customizableEdges1;
            txtTim.DefaultText = "";
            txtTim.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTim.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTim.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTim.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTim.Font = new Font("Segoe UI", 9F);
            txtTim.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTim.Location = new Point(895, 142);
            txtTim.Margin = new Padding(3, 4, 3, 4);
            txtTim.Name = "txtTim";
            txtTim.PasswordChar = '\0';
            txtTim.PlaceholderText = "";
            txtTim.SelectedText = "";
            txtTim.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTim.Size = new Size(290, 39);
            txtTim.TabIndex = 3;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 22;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(612, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(644, 294);
            dataGridView1.TabIndex = 2;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView1.ThemeStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            dataGridView1.ThemeStyle.ReadOnly = false;
            dataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView1.ThemeStyle.RowsStyle.Height = 29;
            dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(text_Date);
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(btn_Update);
            panel4.Controls.Add(btn_Delete);
            panel4.Controls.Add(btn_Create);
            panel4.Controls.Add(txtID_KH);
            panel4.Controls.Add(txtBalance);
            panel4.Controls.Add(txtDate);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(49, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(491, 379);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // text_Date
            // 
            text_Date.Checked = true;
            text_Date.CustomizableEdges = customizableEdges3;
            text_Date.FillColor = Color.White;
            text_Date.Font = new Font("Segoe UI", 9F);
            text_Date.Format = DateTimePickerFormat.Long;
            text_Date.Location = new Point(180, 181);
            text_Date.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            text_Date.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            text_Date.Name = "text_Date";
            text_Date.ShadowDecoration.CustomizableEdges = customizableEdges4;
            text_Date.Size = new Size(250, 27);
            text_Date.TabIndex = 20;
            text_Date.Value = new DateTime(2024, 10, 23, 20, 32, 32, 736);
            // 
            // txtId
            // 
            txtId.Location = new Point(180, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 18;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.ButtonFace;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.Location = new Point(326, 305);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 44);
            btn_Update.TabIndex = 16;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = SystemColors.ButtonFace;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.Location = new Point(180, 305);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 44);
            btn_Delete.TabIndex = 15;
            btn_Delete.Text = "Xoá";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = SystemColors.ButtonFace;
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Create.Location = new Point(43, 305);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(97, 44);
            btn_Create.TabIndex = 14;
            btn_Create.Text = "Thêm";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click_1;
            // 
            // txtID_KH
            // 
            txtID_KH.Location = new Point(180, 120);
            txtID_KH.Name = "txtID_KH";
            txtID_KH.Size = new Size(250, 27);
            txtID_KH.TabIndex = 11;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(180, 231);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(250, 27);
            txtBalance.TabIndex = 9;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(26, 181);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(90, 23);
            txtDate.TabIndex = 4;
            txtDate.Text = "Ngày mở ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 121);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 2;
            label4.Text = "Mã khách hàng";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 232);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 1;
            label3.Text = "Số dư";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 59);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(575, 42);
            label1.Name = "label1";
            label1.Size = new Size(179, 42);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // AccountView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 845);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AccountView";
            Text = "account";
            Load += AccountView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Create;
        private TextBox txtID_KH;
        private TextBox txtBalance;
        private Label txtDate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private TextBox txtId;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private Button btn_Search;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_Date;
    }
}