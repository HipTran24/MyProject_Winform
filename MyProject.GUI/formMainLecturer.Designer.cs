namespace MyProject.GUI
{
    partial class formMainLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainLecturer));
            pnlEvaluate = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip2 = new MenuStrip();
            MenuItemMain = new ToolStripMenuItem();
            MenuItemManagement = new ToolStripMenuItem();
            MenuItemFunction = new ToolStripMenuItem();
            MenuItemUpdateAccount = new ToolStripMenuItem();
            MenuItemUpdateInfo = new ToolStripMenuItem();
            MenuItemExportReport = new ToolStripMenuItem();
            MenuItemSwInfo = new ToolStripMenuItem();
            MenuItemAccount = new ToolStripMenuItem();
            MenuItemChangeInfo = new ToolStripMenuItem();
            MenuItemLogout = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEvaluate
            // 
            pnlEvaluate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEvaluate.AutoScroll = true;
            pnlEvaluate.BackColor = Color.Silver;
            pnlEvaluate.Cursor = Cursors.VSplit;
            pnlEvaluate.Location = new Point(138, 179);
            pnlEvaluate.Name = "pnlEvaluate";
            pnlEvaluate.Size = new Size(1099, 613);
            pnlEvaluate.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Cursor = Cursors.VSplit;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(918, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.VSplit;
            panel1.Location = new Point(138, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 102);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 56);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 2;
            label3.Text = "Trần Thanh Hiệp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "User: Admin";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0145988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.846714F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.21168F));
            tableLayoutPanel1.Controls.Add(menuStrip2, 1, 0);
            tableLayoutPanel1.Cursor = Cursors.VSplit;
            tableLayoutPanel1.Location = new Point(0, -1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1370, 46);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { MenuItemMain, MenuItemManagement, MenuItemFunction, MenuItemSwInfo, MenuItemAccount });
            menuStrip2.Location = new Point(328, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(723, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // MenuItemMain
            // 
            MenuItemMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemMain.Name = "MenuItemMain";
            MenuItemMain.Size = new Size(113, 29);
            MenuItemMain.Text = "Trang chủ";
            // 
            // MenuItemManagement
            // 
            MenuItemManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemManagement.Name = "MenuItemManagement";
            MenuItemManagement.Size = new Size(137, 29);
            MenuItemManagement.Text = "Xem lịch dạy";
            // 
            // MenuItemFunction
            // 
            MenuItemFunction.DropDownItems.AddRange(new ToolStripItem[] { MenuItemUpdateAccount, MenuItemUpdateInfo, MenuItemExportReport });
            MenuItemFunction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemFunction.Name = "MenuItemFunction";
            MenuItemFunction.Size = new Size(151, 29);
            MenuItemFunction.Text = "Cập nhật điểm";
            // 
            // MenuItemUpdateAccount
            // 
            MenuItemUpdateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemUpdateAccount.Name = "MenuItemUpdateAccount";
            MenuItemUpdateAccount.Size = new Size(263, 34);
            MenuItemUpdateAccount.Text = "Cập nhật tài khoản";
            // 
            // MenuItemUpdateInfo
            // 
            MenuItemUpdateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemUpdateInfo.Name = "MenuItemUpdateInfo";
            MenuItemUpdateInfo.Size = new Size(263, 34);
            MenuItemUpdateInfo.Text = "Cập nhật thông tin";
            // 
            // MenuItemExportReport
            // 
            MenuItemExportReport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemExportReport.Name = "MenuItemExportReport";
            MenuItemExportReport.Size = new Size(263, 34);
            MenuItemExportReport.Text = "Xuất báo cáo";
            // 
            // MenuItemSwInfo
            // 
            MenuItemSwInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemSwInfo.Name = "MenuItemSwInfo";
            MenuItemSwInfo.Size = new Size(206, 29);
            MenuItemSwInfo.Text = "Thông tin phần mềm";
            // 
            // MenuItemAccount
            // 
            MenuItemAccount.DropDownItems.AddRange(new ToolStripItem[] { MenuItemChangeInfo, MenuItemLogout });
            MenuItemAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemAccount.Name = "MenuItemAccount";
            MenuItemAccount.Size = new Size(110, 29);
            MenuItemAccount.Text = "Tài khoản";
            // 
            // MenuItemChangeInfo
            // 
            MenuItemChangeInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemChangeInfo.Name = "MenuItemChangeInfo";
            MenuItemChangeInfo.Size = new Size(260, 34);
            MenuItemChangeInfo.Text = "Thay đổi thông tin";
            // 
            // MenuItemLogout
            // 
            MenuItemLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemLogout.Name = "MenuItemLogout";
            MenuItemLogout.Size = new Size(260, 34);
            MenuItemLogout.Text = "Đăng xuất";
            // 
            // formMainLecturer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 891);
            Controls.Add(pnlEvaluate);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formMainLecturer";
            Text = "Giảng viên";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEvaluate;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem MenuItemMain;
        private ToolStripMenuItem MenuItemManagement;
        private ToolStripMenuItem MenuItemFunction;
        private ToolStripMenuItem MenuItemUpdateAccount;
        private ToolStripMenuItem MenuItemUpdateInfo;
        private ToolStripMenuItem MenuItemExportReport;
        private ToolStripMenuItem MenuItemSwInfo;
        private ToolStripMenuItem MenuItemAccount;
        private ToolStripMenuItem MenuItemChangeInfo;
        private ToolStripMenuItem MenuItemLogout;
    }
}