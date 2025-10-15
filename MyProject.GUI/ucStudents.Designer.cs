namespace MyProject.GUI
{
    partial class ucStudents
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            studentsBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnChange = new Button();
            btnAdd = new Button();
            label1 = new Label();
            StudentDisplay = new DataGridView();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColMaLop = new DataGridViewTextBoxColumn();
            ColNgaySinh = new DataGridViewTextBoxColumn();
            ColGioiTinh = new DataGridViewTextBoxColumn();
            ColDiaChi = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColSDT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(2, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 320);
            panel1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(3, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 34);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(3, 167);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Silver;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChange.Location = new Point(3, 106);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(152, 34);
            btnChange.TabIndex = 2;
            btnChange.Text = "Thay đổi";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(3, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(469, 5);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 17;
            label1.Text = "Danh Sách Sinh Viên";
            // 
            // StudentDisplay
            // 
            StudentDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaSV, ColHoTen, ColMaLop, ColNgaySinh, ColGioiTinh, ColDiaChi, ColEmail, ColSDT });
            StudentDisplay.Location = new Point(163, 43);
            StudentDisplay.Name = "StudentDisplay";
            StudentDisplay.RowHeadersWidth = 62;
            StudentDisplay.Size = new Size(929, 570);
            StudentDisplay.TabIndex = 18;
            // 
            // ColMaSV
            // 
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.FillWeight = 155.244766F;
            ColMaSV.HeaderText = "Mã số sinh viên";
            ColMaSV.MinimumWidth = 8;
            ColMaSV.Name = "ColMaSV";
            ColMaSV.Width = 180;
            // 
            // ColHoTen
            // 
            ColHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColHoTen.DataPropertyName = "HoTen";
            ColHoTen.FillWeight = 127.272751F;
            ColHoTen.HeaderText = "Họ tên";
            ColHoTen.MinimumWidth = 150;
            ColHoTen.Name = "ColHoTen";
            // 
            // ColMaLop
            // 
            ColMaLop.DataPropertyName = "MaLop";
            ColMaLop.FillWeight = 86.24709F;
            ColMaLop.HeaderText = "Mã lớp";
            ColMaLop.MinimumWidth = 8;
            ColMaLop.Name = "ColMaLop";
            ColMaLop.Width = 110;
            // 
            // ColNgaySinh
            // 
            ColNgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNgaySinh.DataPropertyName = "NgaySinh";
            ColNgaySinh.FillWeight = 86.24709F;
            ColNgaySinh.HeaderText = "Ngày sinh";
            ColNgaySinh.MinimumWidth = 140;
            ColNgaySinh.Name = "ColNgaySinh";
            // 
            // ColGioiTinh
            // 
            ColGioiTinh.DataPropertyName = "GioiTinh";
            ColGioiTinh.FillWeight = 86.24709F;
            ColGioiTinh.HeaderText = "Giới tính";
            ColGioiTinh.MinimumWidth = 8;
            ColGioiTinh.Name = "ColGioiTinh";
            ColGioiTinh.Width = 120;
            // 
            // ColDiaChi
            // 
            ColDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDiaChi.DataPropertyName = "DiaChi";
            ColDiaChi.FillWeight = 86.24709F;
            ColDiaChi.HeaderText = "Địa chỉ";
            ColDiaChi.MinimumWidth = 120;
            ColDiaChi.Name = "ColDiaChi";
            // 
            // ColEmail
            // 
            ColEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEmail.DataPropertyName = "Email";
            ColEmail.FillWeight = 86.24709F;
            ColEmail.HeaderText = "Email";
            ColEmail.MinimumWidth = 120;
            ColEmail.Name = "ColEmail";
            // 
            // ColSDT
            // 
            ColSDT.DataPropertyName = "SDT";
            ColSDT.FillWeight = 86.24709F;
            ColSDT.HeaderText = "Số điện thoại";
            ColSDT.MinimumWidth = 8;
            ColSDT.Name = "ColSDT";
            ColSDT.Width = 140;
            // 
            // ucStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(StudentDisplay);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ucStudents";
            Size = new Size(1099, 613);
            Load += ucStudents_Load;
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentDisplay).EndInit();
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
        private BindingSource studentsBindingSource;
        private DataGridView StudentDisplay;
        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColMaLop;
        private DataGridViewTextBoxColumn ColNgaySinh;
        private DataGridViewTextBoxColumn ColGioiTinh;
        private DataGridViewTextBoxColumn ColDiaChi;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColSDT;
    }
}
