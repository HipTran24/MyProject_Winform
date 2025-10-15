namespace MyProject.GUI
{
    partial class ucSubject
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
            btnDelete = new Button();
            btnChange = new Button();
            btnAdd = new Button();
            label1 = new Label();
            SubjectDisplay = new DataGridView();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColTenMH = new DataGridViewTextBoxColumn();
            ColSoTinChi = new DataGridViewTextBoxColumn();
            ColSoTiet = new DataGridViewTextBoxColumn();
            ColNgayBatDau = new DataGridViewTextBoxColumn();
            ColNgayKetThuc = new DataGridViewTextBoxColumn();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(3, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 320);
            panel1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(3, 229);
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
            btnDelete.Location = new Point(3, 167);
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
            btnChange.Location = new Point(3, 106);
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
            btnAdd.Location = new Point(3, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 6);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 15;
            label1.Text = "Danh Sách Môn Học";
            // 
            // SubjectDisplay
            // 
            SubjectDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubjectDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaMH, ColTenMH, ColSoTinChi, ColSoTiet, ColNgayBatDau, ColNgayKetThuc, ColMaKhoa });
            SubjectDisplay.Location = new Point(165, 47);
            SubjectDisplay.Name = "SubjectDisplay";
            SubjectDisplay.RowHeadersWidth = 62;
            SubjectDisplay.Size = new Size(929, 570);
            SubjectDisplay.TabIndex = 14;
            // 
            // ColMaMH
            // 
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.HeaderText = "Mã môn học";
            ColMaMH.MinimumWidth = 160;
            ColMaMH.Name = "ColMaMH";
            ColMaMH.Width = 160;
            // 
            // ColTenMH
            // 
            ColTenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenMH.DataPropertyName = "TenMH";
            ColTenMH.HeaderText = "Tên môn học";
            ColTenMH.MinimumWidth = 160;
            ColTenMH.Name = "ColTenMH";
            // 
            // ColSoTinChi
            // 
            ColSoTinChi.DataPropertyName = "SoTinChi";
            ColSoTinChi.HeaderText = "Số tín chỉ";
            ColSoTinChi.MinimumWidth = 8;
            ColSoTinChi.Name = "ColSoTinChi";
            ColSoTinChi.Width = 145;
            // 
            // ColSoTiet
            // 
            ColSoTiet.DataPropertyName = "SoTiet";
            ColSoTiet.HeaderText = "Số tiết";
            ColSoTiet.MinimumWidth = 8;
            ColSoTiet.Name = "ColSoTiet";
            ColSoTiet.Width = 144;
            // 
            // ColNgayBatDau
            // 
            ColNgayBatDau.DataPropertyName = "NgayBatDau";
            ColNgayBatDau.HeaderText = "Ngày bắt đầu";
            ColNgayBatDau.MinimumWidth = 8;
            ColNgayBatDau.Name = "ColNgayBatDau";
            ColNgayBatDau.Width = 150;
            // 
            // ColNgayKetThuc
            // 
            ColNgayKetThuc.DataPropertyName = "NgayKetThuc";
            ColNgayKetThuc.HeaderText = "Ngày kết thúc";
            ColNgayKetThuc.MinimumWidth = 8;
            ColNgayKetThuc.Name = "ColNgayKetThuc";
            ColNgayKetThuc.Width = 150;
            // 
            // ColMaKhoa
            // 
            ColMaKhoa.DataPropertyName = "MaKhoa";
            ColMaKhoa.HeaderText = "Mã Khoa";
            ColMaKhoa.MinimumWidth = 8;
            ColMaKhoa.Name = "ColMaKhoa";
            ColMaKhoa.Width = 144;
            // 
            // ucSubject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(SubjectDisplay);
            Name = "ucSubject";
            Size = new Size(1099, 613);
            Load += ucSubject_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SubjectDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnChange;
        private Button btnAdd;
        private Label label1;
        private DataGridView SubjectDisplay;
        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColTenMH;
        private DataGridViewTextBoxColumn ColSoTinChi;
        private DataGridViewTextBoxColumn ColSoTiet;
        private DataGridViewTextBoxColumn ColNgayBatDau;
        private DataGridViewTextBoxColumn ColNgayKetThuc;
        private DataGridViewTextBoxColumn ColMaKhoa;
    }
}
