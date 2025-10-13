namespace MyProject.GUI
{
    partial class ucCalendar
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
            CalendarDisplay = new DataGridView();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColTenMH = new DataGridViewTextBoxColumn();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColTenGV = new DataGridViewTextBoxColumn();
            ColNgay = new DataGridViewTextBoxColumn();
            ColTietHoc = new DataGridViewTextBoxColumn();
            ColPhongHoc = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CalendarDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(3, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 320);
            panel1.TabIndex = 19;
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
            label1.Location = new Point(471, 5);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 18;
            label1.Text = "Danh Sách Lịch Dạy";
            // 
            // CalendarDisplay
            // 
            CalendarDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CalendarDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CalendarDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaMH, ColTenMH, ColMaGV, ColTenGV, ColNgay, ColTietHoc, ColPhongHoc });
            CalendarDisplay.Location = new Point(165, 46);
            CalendarDisplay.Name = "CalendarDisplay";
            CalendarDisplay.RowHeadersWidth = 62;
            CalendarDisplay.Size = new Size(929, 570);
            CalendarDisplay.TabIndex = 17;
            // 
            // ColMaMH
            // 
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.HeaderText = "Mã môn";
            ColMaMH.MinimumWidth = 8;
            ColMaMH.Name = "ColMaMH";
            ColMaMH.Width = 120;
            // 
            // ColTenMH
            // 
            ColTenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenMH.DataPropertyName = "TenMH";
            ColTenMH.HeaderText = "Tên môn học";
            ColTenMH.MinimumWidth = 160;
            ColTenMH.Name = "ColTenMH";
            // 
            // ColMaGV
            // 
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 8;
            ColMaGV.Name = "ColMaGV";
            ColMaGV.Width = 160;
            // 
            // ColTenGV
            // 
            ColTenGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenGV.DataPropertyName = "TenGV";
            ColTenGV.HeaderText = "Tên giảng viên";
            ColTenGV.MinimumWidth = 170;
            ColTenGV.Name = "ColTenGV";
            // 
            // ColNgay
            // 
            ColNgay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNgay.DataPropertyName = "Ngay";
            ColNgay.HeaderText = "Ngày học";
            ColNgay.MinimumWidth = 8;
            ColNgay.Name = "ColNgay";
            // 
            // ColTietHoc
            // 
            ColTietHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTietHoc.DataPropertyName = "TietHoc";
            ColTietHoc.HeaderText = "Tiết học";
            ColTietHoc.MinimumWidth = 8;
            ColTietHoc.Name = "ColTietHoc";
            // 
            // ColPhongHoc
            // 
            ColPhongHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPhongHoc.DataPropertyName = "PhongHoc";
            ColPhongHoc.HeaderText = "Phòng học";
            ColPhongHoc.MinimumWidth = 8;
            ColPhongHoc.Name = "ColPhongHoc";
            // 
            // ucCalendar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(CalendarDisplay);
            Name = "ucCalendar";
            Size = new Size(1099, 613);
            Load += ucCalendar_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CalendarDisplay).EndInit();
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
        private DataGridView CalendarDisplay;
        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColTenMH;
        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColTenGV;
        private DataGridViewTextBoxColumn ColNgay;
        private DataGridViewTextBoxColumn ColTietHoc;
        private DataGridViewTextBoxColumn ColPhongHoc;
    }
}
