namespace MyProject.GUI
{
    partial class ucScore
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
            ScoreDisplay = new DataGridView();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColDiemGK = new DataGridViewTextBoxColumn();
            ColDiemCK = new DataGridViewTextBoxColumn();
            ColDiemTrungBinh = new DataGridViewTextBoxColumn();
            ColHocKy = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(1, 42);
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
            label1.Location = new Point(469, 1);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 15;
            label1.Text = "Danh Sách Điểm";
            // 
            // ScoreDisplay
            // 
            ScoreDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScoreDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaSV, ColMaMH, ColDiemGK, ColDiemCK, ColDiemTrungBinh, ColHocKy });
            ScoreDisplay.Location = new Point(163, 42);
            ScoreDisplay.Name = "ScoreDisplay";
            ScoreDisplay.RowHeadersWidth = 62;
            ScoreDisplay.Size = new Size(929, 570);
            ScoreDisplay.TabIndex = 14;
            // 
            // ColMaSV
            // 
            ColMaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.FillWeight = 98.64599F;
            ColMaSV.HeaderText = "Mã số sinh viên";
            ColMaSV.MinimumWidth = 16;
            ColMaSV.Name = "ColMaSV";
            // 
            // ColMaMH
            // 
            ColMaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.FillWeight = 95.9058151F;
            ColMaMH.HeaderText = "Mã môn học";
            ColMaMH.MinimumWidth = 8;
            ColMaMH.Name = "ColMaMH";
            // 
            // ColDiemGK
            // 
            ColDiemGK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDiemGK.DataPropertyName = "DiemGK";
            ColDiemGK.FillWeight = 95.9058151F;
            ColDiemGK.HeaderText = "Điểm giữa kỳ";
            ColDiemGK.MinimumWidth = 8;
            ColDiemGK.Name = "ColDiemGK";
            // 
            // ColDiemCK
            // 
            ColDiemCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDiemCK.DataPropertyName = "DiemCK";
            ColDiemCK.FillWeight = 95.9058151F;
            ColDiemCK.HeaderText = "Điểm cuối kỳ";
            ColDiemCK.MinimumWidth = 8;
            ColDiemCK.Name = "ColDiemCK";
            // 
            // ColDiemTrungBinh
            // 
            ColDiemTrungBinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            ColDiemTrungBinh.FillWeight = 113.6363F;
            ColDiemTrungBinh.HeaderText = "Điểm trung bình";
            ColDiemTrungBinh.MinimumWidth = 8;
            ColDiemTrungBinh.Name = "ColDiemTrungBinh";
            // 
            // ColHocKy
            // 
            ColHocKy.DataPropertyName = "HocKy";
            ColHocKy.HeaderText = "Học kỳ";
            ColHocKy.MinimumWidth = 8;
            ColHocKy.Name = "ColHocKy";
            ColHocKy.Width = 150;
            // 
            // ucScore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ScoreDisplay);
            Name = "ucScore";
            Size = new Size(1099, 613);
            Load += ucScore_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScoreDisplay).EndInit();
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
        private DataGridView ScoreDisplay;
        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColDiemGK;
        private DataGridViewTextBoxColumn ColDiemCK;
        private DataGridViewTextBoxColumn ColDiemTrungBinh;
        private DataGridViewTextBoxColumn ColHocKy;
    }
}
