namespace MyProject.GUI
{
    partial class ucLecturers
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
            LecturerDisplay = new DataGridView();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColSDT = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LecturerDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(1, 46);
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
            label1.Location = new Point(469, 5);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 15;
            label1.Text = "Danh Sách Giảng Viên";
            // 
            // LecturerDisplay
            // 
            LecturerDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LecturerDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LecturerDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaGV, ColHoTen, ColSDT, ColEmail, ColMaKhoa });
            LecturerDisplay.Location = new Point(163, 46);
            LecturerDisplay.Name = "LecturerDisplay";
            LecturerDisplay.RowHeadersWidth = 62;
            LecturerDisplay.Size = new Size(929, 570);
            LecturerDisplay.TabIndex = 14;
            // 
            // ColMaGV
            // 
            ColMaGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 8;
            ColMaGV.Name = "ColMaGV";
            // 
            // ColHoTen
            // 
            ColHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColHoTen.DataPropertyName = "HoTen";
            ColHoTen.HeaderText = "Họ tên";
            ColHoTen.MinimumWidth = 8;
            ColHoTen.Name = "ColHoTen";
            // 
            // ColSDT
            // 
            ColSDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSDT.DataPropertyName = "SDT";
            ColSDT.HeaderText = "Số điện thoại";
            ColSDT.MinimumWidth = 8;
            ColSDT.Name = "ColSDT";
            // 
            // ColEmail
            // 
            ColEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Email";
            ColEmail.MinimumWidth = 8;
            ColEmail.Name = "ColEmail";
            // 
            // ColMaKhoa
            // 
            ColMaKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaKhoa.DataPropertyName = "MaKhoa";
            ColMaKhoa.HeaderText = "Mã khoa";
            ColMaKhoa.MinimumWidth = 8;
            ColMaKhoa.Name = "ColMaKhoa";
            // 
            // ucLecturers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(LecturerDisplay);
            Name = "ucLecturers";
            Size = new Size(1099, 613);
            Load += ucLecturers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LecturerDisplay).EndInit();
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
        private DataGridView LecturerDisplay;
        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColSDT;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColMaKhoa;
    }
}
