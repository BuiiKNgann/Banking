namespace bank.View
{
    partial class withDrawView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withDrawView));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            cmbAccountID = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            txtBalance = new TextBox();
            btn_save = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(180, 106);
            label4.Name = "label4";
            label4.Size = new Size(157, 45);
            label4.TabIndex = 14;
            label4.Text = "Rút tiền";
            // 
            // cmbAccountID
            // 
            cmbAccountID.FormattingEnabled = true;
            cmbAccountID.Location = new Point(166, 203);
            cmbAccountID.Name = "cmbAccountID";
            cmbAccountID.Size = new Size(222, 28);
            cmbAccountID.TabIndex = 20;
            cmbAccountID.SelectedIndexChanged += cmbAccountID_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 345);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 19;
            label3.Text = "Số tiền rút";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 268);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 18;
            label2.Text = "Số dư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(57, 204);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 17;
            label1.Text = "Tài khoản";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(166, 341);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(222, 27);
            txtAmount.TabIndex = 16;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(166, 267);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(222, 27);
            txtBalance.TabIndex = 15;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Red;
            btn_save.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(147, 417);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 56);
            btn_save.TabIndex = 21;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(297, 417);
            button1.Name = "button1";
            button1.Size = new Size(103, 56);
            button1.TabIndex = 22;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = false;
            // 
            // withDrawView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 576);
            Controls.Add(button1);
            Controls.Add(btn_save);
            Controls.Add(cmbAccountID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(txtBalance);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Name = "withDrawView";
            Text = "withDrawView";
            Load += withDrawView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox cmbAccountID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAmount;
        private TextBox txtBalance;
        private Button btn_save;
        private Button button1;
    }
}