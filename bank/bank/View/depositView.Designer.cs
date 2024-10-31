namespace bank.View
{
    partial class depositView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depositView));
            panel1 = new Panel();
            cmbAccountID = new ComboBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_save = new Button();
            txtAmount = new TextBox();
            txtBalance = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbAccountID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(txtBalance);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 593);
            panel1.TabIndex = 0;
            // 
            // cmbAccountID
            // 
            cmbAccountID.FormattingEnabled = true;
            cmbAccountID.Location = new Point(166, 175);
            cmbAccountID.Name = "cmbAccountID";
            cmbAccountID.Size = new Size(222, 28);
            cmbAccountID.TabIndex = 14;
            cmbAccountID.SelectedIndexChanged += cmbAccountID_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(188, 103);
            label4.Name = "label4";
            label4.Size = new Size(164, 45);
            label4.TabIndex = 13;
            label4.Text = "Nạp tiền";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(285, 409);
            button1.Name = "button1";
            button1.Size = new Size(103, 56);
            button1.TabIndex = 11;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 321);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 10;
            label3.Text = "Số tiền nạp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 244);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 9;
            label2.Text = "Số dư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(49, 175);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Red;
            btn_save.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(157, 409);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 56);
            btn_save.TabIndex = 7;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(166, 317);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(222, 27);
            txtAmount.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(166, 243);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(222, 27);
            txtBalance.TabIndex = 1;
            // 
            // depositView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 590);
            Controls.Add(panel1);
            Name = "depositView";
            Text = "deposit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtAmount;
        private TextBox txtBalance;
        private Button btn_save;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox cmbAccountID;
    }
}