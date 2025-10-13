namespace MyProject.GUI
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip2 = new MenuStrip();
            MenuItemMain = new ToolStripMenuItem();
            MenuItemManagement = new ToolStripMenuItem();
            MenuItemFacutly = new ToolStripMenuItem();
            MenuItemStudents = new ToolStripMenuItem();
            MenuItemSubject = new ToolStripMenuItem();
            MenuItemScore = new ToolStripMenuItem();
            MenuItemLecturers = new ToolStripMenuItem();
            MenuItemCalendar = new ToolStripMenuItem();
            MenuItemFunction = new ToolStripMenuItem();
            MenuItemUpdateAccount = new ToolStripMenuItem();
            MenuItemUpdateInfo = new ToolStripMenuItem();
            MenuItemExportReport = new ToolStripMenuItem();
            MenuItemExportLecturers = new ToolStripMenuItem();
            MenuItemExportStudents = new ToolStripMenuItem();
            MenuItemExportScores = new ToolStripMenuItem();
            MenuItemSwInfo = new ToolStripMenuItem();
            MenuItemAccount = new ToolStripMenuItem();
            MenuItemChangeInfo = new ToolStripMenuItem();
            MenuItemLogout = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            ucCalendar1 = new ucCalendar();
            pnlEvaluate = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(142, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 102);
            panel1.TabIndex = 2;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.89194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2161255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.89194F));
            tableLayoutPanel1.Controls.Add(menuStrip2, 1, 0);
            tableLayoutPanel1.Location = new Point(39, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1305, 46);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { MenuItemMain, MenuItemManagement, MenuItemFunction, MenuItemSwInfo, MenuItemAccount });
            menuStrip2.Location = new Point(329, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(650, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // MenuItemMain
            // 
            MenuItemMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemMain.Name = "MenuItemMain";
            MenuItemMain.Size = new Size(113, 29);
            MenuItemMain.Text = "Trang chủ";
            MenuItemMain.Click += MenuItemMain_Click;
            // 
            // MenuItemManagement
            // 
            MenuItemManagement.DropDownItems.AddRange(new ToolStripItem[] { MenuItemFacutly, MenuItemStudents, MenuItemSubject, MenuItemScore, MenuItemLecturers, MenuItemCalendar });
            MenuItemManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemManagement.Name = "MenuItemManagement";
            MenuItemManagement.Size = new Size(94, 29);
            MenuItemManagement.Text = "Quản lý";
            // 
            // MenuItemFacutly
            // 
            MenuItemFacutly.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemFacutly.Name = "MenuItemFacutly";
            MenuItemFacutly.Size = new Size(230, 34);
            MenuItemFacutly.Text = "Khoa";
            MenuItemFacutly.Click += MenuItemFaculty_Click;
            // 
            // MenuItemStudents
            // 
            MenuItemStudents.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemStudents.Name = "MenuItemStudents";
            MenuItemStudents.Size = new Size(230, 34);
            MenuItemStudents.Text = "Sinh viên";
            MenuItemStudents.Click += MenuItemStudents_Click;
            // 
            // MenuItemSubject
            // 
            MenuItemSubject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemSubject.Name = "MenuItemSubject";
            MenuItemSubject.Size = new Size(230, 34);
            MenuItemSubject.Text = "Môn học";
            MenuItemSubject.Click += MenuItemSubject_Click;
            // 
            // MenuItemScore
            // 
            MenuItemScore.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemScore.Name = "MenuItemScore";
            MenuItemScore.Size = new Size(230, 34);
            MenuItemScore.Text = "Cập nhật điểm";
            MenuItemScore.Click += MenuItemScore_Click;
            // 
            // MenuItemLecturers
            // 
            MenuItemLecturers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemLecturers.Name = "MenuItemLecturers";
            MenuItemLecturers.Size = new Size(230, 34);
            MenuItemLecturers.Text = "Giảng viên";
            MenuItemLecturers.Click += MenuItemLecturers_Click;
            // 
            // MenuItemCalendar
            // 
            MenuItemCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemCalendar.Name = "MenuItemCalendar";
            MenuItemCalendar.Size = new Size(230, 34);
            MenuItemCalendar.Text = "Lịch giảng dạy";
            MenuItemCalendar.Click += MenuItemCalendar_Click;
            // 
            // MenuItemFunction
            // 
            MenuItemFunction.DropDownItems.AddRange(new ToolStripItem[] { MenuItemUpdateAccount, MenuItemUpdateInfo, MenuItemExportReport });
            MenuItemFunction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemFunction.Name = "MenuItemFunction";
            MenuItemFunction.Size = new Size(119, 29);
            MenuItemFunction.Text = "Chức năng";
            // 
            // MenuItemUpdateAccount
            // 
            MenuItemUpdateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemUpdateAccount.Name = "MenuItemUpdateAccount";
            MenuItemUpdateAccount.Size = new Size(263, 34);
            MenuItemUpdateAccount.Text = "Cập nhật tài khoản";
            MenuItemUpdateAccount.Click += MenuItemUpdateAccount_Click;
            // 
            // MenuItemUpdateInfo
            // 
            MenuItemUpdateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemUpdateInfo.Name = "MenuItemUpdateInfo";
            MenuItemUpdateInfo.Size = new Size(263, 34);
            MenuItemUpdateInfo.Text = "Cập nhật thông tin";
            MenuItemUpdateInfo.Click += MenuItemUpdateInfo_Click;
            // 
            // MenuItemExportReport
            // 
            MenuItemExportReport.DropDownItems.AddRange(new ToolStripItem[] { MenuItemExportLecturers, MenuItemExportStudents, MenuItemExportScores });
            MenuItemExportReport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemExportReport.Name = "MenuItemExportReport";
            MenuItemExportReport.Size = new Size(263, 34);
            MenuItemExportReport.Text = "Xuất báo cáo";
            // 
            // MenuItemExportLecturers
            // 
            MenuItemExportLecturers.Name = "MenuItemExportLecturers";
            MenuItemExportLecturers.Size = new Size(283, 34);
            MenuItemExportLecturers.Text = "Danh sách giảng viên";
            MenuItemExportLecturers.Click += MenuItemExportLecturers_Click;
            // 
            // MenuItemExportStudents
            // 
            MenuItemExportStudents.Name = "MenuItemExportStudents";
            MenuItemExportStudents.Size = new Size(283, 34);
            MenuItemExportStudents.Text = "Danh sách sinh viên";
            MenuItemExportStudents.Click += MenuItemExportStudents_Click;
            // 
            // MenuItemExportScores
            // 
            MenuItemExportScores.Name = "MenuItemExportScores";
            MenuItemExportScores.Size = new Size(283, 34);
            MenuItemExportScores.Text = "Danh sách điểm";
            MenuItemExportScores.Click += MenuItemExportScores_Click;
            // 
            // MenuItemSwInfo
            // 
            MenuItemSwInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItemSwInfo.Name = "MenuItemSwInfo";
            MenuItemSwInfo.Size = new Size(206, 29);
            MenuItemSwInfo.Text = "Thông tin phần mềm";
            MenuItemSwInfo.Click += MenuItemSwInfo_Click;
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
            MenuItemChangeInfo.Click += MenuItemChangeInfo_Click;
            // 
            // MenuItemLogout
            // 
            MenuItemLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemLogout.Name = "MenuItemLogout";
            MenuItemLogout.Size = new Size(260, 34);
            MenuItemLogout.Text = "Đăng xuất";
            MenuItemLogout.Click += MenuItemLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Header1;
            pictureBox1.Location = new Point(323, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(918, 102);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ucCalendar1
            // 
            ucCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ucCalendar1.Location = new Point(1289, 103);
            ucCalendar1.Name = "ucCalendar1";
            ucCalendar1.Size = new Size(8, 8);
            ucCalendar1.TabIndex = 8;
            // 
            // pnlEvaluate
            // 
            pnlEvaluate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEvaluate.AutoScroll = true;
            pnlEvaluate.BackColor = Color.WhiteSmoke;
            pnlEvaluate.Location = new Point(142, 182);
            pnlEvaluate.Name = "pnlEvaluate";
            pnlEvaluate.Size = new Size(1099, 613);
            pnlEvaluate.TabIndex = 5;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1371, 891);
            Controls.Add(ucCalendar1);
            Controls.Add(pnlEvaluate);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Phần mềm quản lý sinh viên";
            Load += formMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem MenuItemMain;
        private ToolStripMenuItem MenuItemManagement;
        private ToolStripMenuItem MenuItemFacutly;
        private ToolStripMenuItem MenuItemStudents;
        private ToolStripMenuItem MenuItemSubject;
        private ToolStripMenuItem MenuItemScore;
        private ToolStripMenuItem MenuItemLecturers;
        private ToolStripMenuItem MenuItemCalendar;
        private ToolStripMenuItem MenuItemFunction;
        private ToolStripMenuItem MenuItemUpdateAccount;
        private ToolStripMenuItem MenuItemUpdateInfo;
        private ToolStripMenuItem MenuItemExportReport;
        private ToolStripMenuItem MenuItemSwInfo;
        private ToolStripMenuItem MenuItemAccount;
        private ToolStripMenuItem MenuItemChangeInfo;
        private ToolStripMenuItem MenuItemLogout;
        private ucCalendar ucCalendar1;
        private Panel pnlEvaluate;
        private ToolStripMenuItem MenuItemExportLecturers;
        private ToolStripMenuItem MenuItemExportStudents;
        private ToolStripMenuItem MenuItemExportScores;
    }
}