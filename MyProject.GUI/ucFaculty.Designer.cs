namespace MyProject.GUI
{
    partial class ucFaculty
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
            lblHeader = new Label();
            FacultyDisplay = new DataGridView();
            panel1 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnChange = new Button();
            btnAdd = new Button();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            ColTenKhoa = new DataGridViewTextBoxColumn();
            ColTruongKhoa = new DataGridViewTextBoxColumn();
            ColPhongCongTac = new DataGridViewTextBoxColumn();
            ColSoLuongLop = new DataGridViewTextBoxColumn();
            ColEmailKhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)FacultyDisplay).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ImageAlign = ContentAlignment.TopCenter;
            lblHeader.Location = new Point(449, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(298, 38);
            lblHeader.TabIndex = 8;
            lblHeader.Text = "Danh Sách Khoa Viện";
            // 
            // FacultyDisplay
            // 
            FacultyDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FacultyDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FacultyDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaKhoa, ColTenKhoa, ColTruongKhoa, ColPhongCongTac, ColSoLuongLop, ColEmailKhoa });
            FacultyDisplay.Location = new Point(167, 41);
            FacultyDisplay.Name = "FacultyDisplay";
            FacultyDisplay.RowHeadersWidth = 62;
            FacultyDisplay.Size = new Size(929, 570);
            FacultyDisplay.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(3, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 329);
            panel1.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(0, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(0, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Silver;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(0, 94);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(152, 34);
            btnChange.TabIndex = 1;
            btnChange.Text = "Thay đổi";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(0, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ColMaKhoa
            // 
            ColMaKhoa.DataPropertyName = "MaKhoa";
            ColMaKhoa.HeaderText = "Mã khoa";
            ColMaKhoa.MinimumWidth = 8;
            ColMaKhoa.Name = "ColMaKhoa";
            ColMaKhoa.Width = 141;
            // 
            // ColTenKhoa
            // 
            ColTenKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenKhoa.DataPropertyName = "TenKhoa";
            ColTenKhoa.HeaderText = "Tên khoa";
            ColTenKhoa.MinimumWidth = 140;
            ColTenKhoa.Name = "ColTenKhoa";
            // 
            // ColTruongKhoa
            // 
            ColTruongKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTruongKhoa.DataPropertyName = "TruongKhoa";
            ColTruongKhoa.HeaderText = "Trưởng Khoa";
            ColTruongKhoa.MinimumWidth = 160;
            ColTruongKhoa.Name = "ColTruongKhoa";
            // 
            // ColPhongCongTac
            // 
            ColPhongCongTac.DataPropertyName = "PhongCongTac";
            ColPhongCongTac.HeaderText = "Phòng công tác";
            ColPhongCongTac.MinimumWidth = 180;
            ColPhongCongTac.Name = "ColPhongCongTac";
            ColPhongCongTac.Width = 180;
            // 
            // ColSoLuongLop
            // 
            ColSoLuongLop.DataPropertyName = "SoLuongLop";
            ColSoLuongLop.HeaderText = "Số lượng lớp";
            ColSoLuongLop.MinimumWidth = 8;
            ColSoLuongLop.Name = "ColSoLuongLop";
            ColSoLuongLop.Width = 141;
            // 
            // ColEmailKhoa
            // 
            ColEmailKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEmailKhoa.DataPropertyName = "EmailKhoa";
            ColEmailKhoa.HeaderText = "Email";
            ColEmailKhoa.MinimumWidth = 160;
            ColEmailKhoa.Name = "ColEmailKhoa";
            // 
            // ucFaculty
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblHeader);
            Controls.Add(FacultyDisplay);
            Name = "ucFaculty";
            Size = new Size(1099, 613);
            Load += ucFaculty_Load;
            ((System.ComponentModel.ISupportInitialize)FacultyDisplay).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private DataGridView FacultyDisplay;
        private Panel panel1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnChange;
        private Button btnAdd;
        private DataGridViewTextBoxColumn ColMaKhoa;
        private DataGridViewTextBoxColumn ColTenKhoa;
        private DataGridViewTextBoxColumn ColTruongKhoa;
        private DataGridViewTextBoxColumn ColPhongCongTac;
        private DataGridViewTextBoxColumn ColSoLuongLop;
        private DataGridViewTextBoxColumn ColEmailKhoa;
    }
}
