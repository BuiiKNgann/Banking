namespace bank
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            giaodich = new ToolStripMenuItem();
            deposit = new ToolStripMenuItem();
            transfer = new ToolStripMenuItem();
            withdraw = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            hêThôngToolStripMenuItem = new ToolStripMenuItem();
            chiNhanhToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            khachHangToolStripMenuItem = new ToolStripMenuItem();
            taiKhoanToolStripMenuItem = new ToolStripMenuItem();
            khacToolStripMenuItem = new ToolStripMenuItem();
            khacToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuâtToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ButtonFace;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, giaodich, hêThôngToolStripMenuItem, khacToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1009, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // giaodich
            // 
            giaodich.DropDownItems.AddRange(new ToolStripItem[] { deposit, transfer, withdraw, transactionToolStripMenuItem });
            giaodich.Name = "giaodich";
            giaodich.Size = new Size(86, 24);
            giaodich.Text = "Giao dịch";
            // 
            // deposit
            // 
            deposit.Name = "deposit";
            deposit.Size = new Size(203, 26);
            deposit.Text = "Nạp tiền";
            deposit.Click += deposit_Click;
            // 
            // transfer
            // 
            transfer.Name = "transfer";
            transfer.Size = new Size(203, 26);
            transfer.Text = "Chuyển tiền";
            transfer.Click += transfer_Click;
            // 
            // withdraw
            // 
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(203, 26);
            withdraw.Text = "Rút tiền";
            withdraw.Click += withdraw_Click;
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(203, 26);
            transactionToolStripMenuItem.Text = "Lịch sử giao dịch";
            transactionToolStripMenuItem.Click += transactionToolStripMenuItem_Click;
            // 
            // hêThôngToolStripMenuItem
            // 
            hêThôngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chiNhanhToolStripMenuItem, nhânViênToolStripMenuItem, khachHangToolStripMenuItem, taiKhoanToolStripMenuItem });
            hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            hêThôngToolStripMenuItem.Size = new Size(85, 24);
            hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // chiNhanhToolStripMenuItem
            // 
            chiNhanhToolStripMenuItem.Name = "chiNhanhToolStripMenuItem";
            chiNhanhToolStripMenuItem.Size = new Size(224, 26);
            chiNhanhToolStripMenuItem.Text = "Chi nhánh";
            chiNhanhToolStripMenuItem.Click += chiNhanhToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // khachHangToolStripMenuItem
            // 
            khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            khachHangToolStripMenuItem.Size = new Size(224, 26);
            khachHangToolStripMenuItem.Text = "Khách hàng";
            khachHangToolStripMenuItem.Click += khachHangToolStripMenuItem_Click;
            // 
            // taiKhoanToolStripMenuItem
            // 
            taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            taiKhoanToolStripMenuItem.Size = new Size(224, 26);
            taiKhoanToolStripMenuItem.Text = "Tài khoản";
            taiKhoanToolStripMenuItem.Click += taiKhoanToolStripMenuItem_Click;
            // 
            // khacToolStripMenuItem
            // 
            khacToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khacToolStripMenuItem1, đăngXuâtToolStripMenuItem });
            khacToolStripMenuItem.Name = "khacToolStripMenuItem";
            khacToolStripMenuItem.Size = new Size(55, 24);
            khacToolStripMenuItem.Text = "Khác";
            // 
            // khacToolStripMenuItem1
            // 
            khacToolStripMenuItem1.Name = "khacToolStripMenuItem1";
            khacToolStripMenuItem1.Size = new Size(160, 26);
            khacToolStripMenuItem1.Text = "Khác";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            đăngXuâtToolStripMenuItem.Size = new Size(160, 26);
            đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuâtToolStripMenuItem.Click += đăngXuâtToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 71);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(4149, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 331);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1009, 554);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Menu";
            Load += Menu_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem giaodich;
        private ToolStripMenuItem hêThôngToolStripMenuItem;
        private ToolStripMenuItem chiNhanhToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem khachHangToolStripMenuItem;
        private ToolStripMenuItem khacToolStripMenuItem;
        private ToolStripMenuItem khacToolStripMenuItem1;
        private ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem deposit;
        private ToolStripMenuItem transfer;
        private ToolStripMenuItem withdraw;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem taiKhoanToolStripMenuItem;
    }
}