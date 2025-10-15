namespace MyProject.GUI
{
    partial class ucChangeInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnUpdate = new Button();
            btnEdit = new Button();
            tbRole = new TextBox();
            label9 = new Label();
            tbNumP = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            cmbSex = new ComboBox();
            label5 = new Label();
            tbDateB = new TextBox();
            label4 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(tbRole);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbNumP);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbSex);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbDateB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 613);
            panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = SystemColors.Menu;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(825, 499);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 34);
            btnUpdate.TabIndex = 56;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.BackColor = SystemColors.Menu;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(651, 499);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 34);
            btnEdit.TabIndex = 55;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // tbRole
            // 
            tbRole.Anchor = AnchorStyles.Top;
            tbRole.Location = new Point(651, 388);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(298, 31);
            tbRole.TabIndex = 54;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(558, 394);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(81, 25);
            label9.TabIndex = 53;
            label9.Text = "Vai Trò: ";
            // 
            // tbNumP
            // 
            tbNumP.Anchor = AnchorStyles.Top;
            tbNumP.Location = new Point(651, 299);
            tbNumP.Name = "tbNumP";
            tbNumP.Size = new Size(298, 31);
            tbNumP.TabIndex = 52;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(499, 302);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(140, 25);
            label8.TabIndex = 51;
            label8.Text = "Số Điện Thoạỉ: ";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top;
            tbEmail.Location = new Point(651, 209);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(298, 31);
            tbEmail.TabIndex = 50;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(571, 212);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 49;
            label7.Text = "Email: ";
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Top;
            tbAddress.Location = new Point(651, 132);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(298, 31);
            tbAddress.TabIndex = 48;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(559, 135);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 47;
            label6.Text = "Địa chỉ: ";
            // 
            // cmbSex
            // 
            cmbSex.Anchor = AnchorStyles.Top;
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cmbSex.Location = new Point(201, 388);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(182, 33);
            cmbSex.TabIndex = 46;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 396);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 45;
            label5.Text = "Giới Tính: ";
            // 
            // tbDateB
            // 
            tbDateB.Anchor = AnchorStyles.Top;
            tbDateB.Location = new Point(201, 299);
            tbDateB.Name = "tbDateB";
            tbDateB.Size = new Size(265, 31);
            tbDateB.TabIndex = 44;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 305);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 43;
            label4.Text = "Ngày Sinh: ";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top;
            tbName.Location = new Point(201, 209);
            tbName.Name = "tbName";
            tbName.Size = new Size(265, 31);
            tbName.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 215);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 41;
            label3.Text = "Họ và Tên: ";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top;
            tbID.Location = new Point(201, 132);
            tbID.Name = "tbID";
            tbID.Size = new Size(265, 31);
            tbID.TabIndex = 40;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 138);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 39;
            label2.Text = "ID: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 38);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 38;
            label1.Text = "Thông Tin Của Bạn";
            // 
            // ucChangeInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(panel1);
            Name = "ucChangeInfo";
            Size = new Size(1099, 613);
            Load += ucChangeInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private Button btnEdit;
        private TextBox tbRole;
        private Label label9;
        private TextBox tbNumP;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbAddress;
        private Label label6;
        private ComboBox cmbSex;
        private Label label5;
        private TextBox tbDateB;
        private Label label4;
        private TextBox tbName;
        private Label label3;
        private TextBox tbID;
        private Label label2;
        private Label label1;
    }
}
