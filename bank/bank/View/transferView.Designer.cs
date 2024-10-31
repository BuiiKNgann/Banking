namespace bank.View
{
    partial class transferView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferView));
            button1 = new Button();
            btn_save = new Button();
            cmbToAccountID = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            txtBalance = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            cmbFormAccountID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(247, 405);
            button1.Name = "button1";
            button1.Size = new Size(103, 56);
            button1.TabIndex = 32;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Red;
            btn_save.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(119, 405);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 56);
            btn_save.TabIndex = 31;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // cmbToAccountID
            // 
            cmbToAccountID.FormattingEnabled = true;
            cmbToAccountID.Location = new Point(181, 229);
            cmbToAccountID.Name = "cmbToAccountID";
            cmbToAccountID.Size = new Size(222, 28);
            cmbToAccountID.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 331);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 29;
            label3.Text = "Số tiền chuyển";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 281);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 28;
            label2.Text = "Số dư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(43, 175);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 27;
            label1.Text = "Từ tài khoản";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(181, 327);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(222, 27);
            txtAmount.TabIndex = 26;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(181, 281);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(222, 27);
            txtBalance.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(128, 90);
            label4.Name = "label4";
            label4.Size = new Size(222, 45);
            label4.TabIndex = 24;
            label4.Text = "Chuyển tiền";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(43, 230);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 33;
            label5.Text = "Đến tài khoản";
            label5.Click += label5_Click;
            // 
            // cmbFormAccountID
            // 
            cmbFormAccountID.FormattingEnabled = true;
            cmbFormAccountID.Location = new Point(181, 170);
            cmbFormAccountID.Name = "cmbFormAccountID";
            cmbFormAccountID.Size = new Size(222, 28);
            cmbFormAccountID.TabIndex = 34;
            cmbFormAccountID.SelectedIndexChanged += cmbFormAccountID_SelectedIndexChanged;
            // 
            // transferView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(447, 559);
            Controls.Add(cmbFormAccountID);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btn_save);
            Controls.Add(cmbToAccountID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(txtBalance);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Name = "transferView";
            Text = "transferView";
            Load += transferView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_save;
        private ComboBox cmbToAccountID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAmount;
        private TextBox txtBalance;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox cmbFormAccountID;
    }
}