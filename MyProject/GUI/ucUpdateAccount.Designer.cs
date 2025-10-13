namespace MyProject.GUI
{
    partial class ucUpdateAccount
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
            UserAccountDisplay = new DataGridView();
            tbSearch = new TextBox();
            btnSearch = new Button();
            ColUsername = new DataGridViewTextBoxColumn();
            ColPassword = new DataGridViewTextBoxColumn();
            ColRole = new DataGridViewTextBoxColumn();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColIDAdmin = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserAccountDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(3, 90);
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
            label1.Location = new Point(431, 4);
            label1.Name = "label1";
            label1.Size = new Size(293, 38);
            label1.TabIndex = 18;
            label1.Text = "Danh Sách Tài Khoản";
            // 
            // UserAccountDisplay
            // 
            UserAccountDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserAccountDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserAccountDisplay.Columns.AddRange(new DataGridViewColumn[] { ColUsername, ColPassword, ColRole, ColMaSV, ColMaGV, ColIDAdmin });
            UserAccountDisplay.Location = new Point(167, 90);
            UserAccountDisplay.Name = "UserAccountDisplay";
            UserAccountDisplay.RowHeadersWidth = 62;
            UserAccountDisplay.Size = new Size(929, 520);
            UserAccountDisplay.TabIndex = 17;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.ControlLight;
            tbSearch.Location = new Point(167, 53);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Nhập ID User";
            tbSearch.Size = new Size(284, 31);
            tbSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ScrollBar;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(457, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ColUsername
            // 
            ColUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColUsername.DataPropertyName = "Username";
            ColUsername.FillWeight = 96.04743F;
            ColUsername.HeaderText = "Tài khoản";
            ColUsername.MinimumWidth = 140;
            ColUsername.Name = "ColUsername";
            // 
            // ColPassword
            // 
            ColPassword.DataPropertyName = "Password";
            ColPassword.FillWeight = 96.04743F;
            ColPassword.HeaderText = "Mật khẩu";
            ColPassword.MinimumWidth = 8;
            ColPassword.Name = "ColPassword";
            ColPassword.Width = 138;
            // 
            // ColRole
            // 
            ColRole.DataPropertyName = "Role";
            ColRole.FillWeight = 96.04743F;
            ColRole.HeaderText = "Vai trò";
            ColRole.MinimumWidth = 8;
            ColRole.Name = "ColRole";
            ColRole.Width = 139;
            // 
            // ColMaSV
            // 
            ColMaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.FillWeight = 106.719368F;
            ColMaSV.HeaderText = "Mã sinh viên";
            ColMaSV.MinimumWidth = 160;
            ColMaSV.Name = "ColMaSV";
            // 
            // ColMaGV
            // 
            ColMaGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.FillWeight = 109.090912F;
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 160;
            ColMaGV.Name = "ColMaGV";
            // 
            // ColIDAdmin
            // 
            ColIDAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColIDAdmin.DataPropertyName = "AdminID";
            ColIDAdmin.FillWeight = 96.04743F;
            ColIDAdmin.HeaderText = "ID Admin";
            ColIDAdmin.MinimumWidth = 140;
            ColIDAdmin.Name = "ColIDAdmin";
            // 
            // ucUpdateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(UserAccountDisplay);
            Name = "ucUpdateAccount";
            Size = new Size(1099, 613);
            Load += ucUpdateAccount_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserAccountDisplay).EndInit();
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
        private DataGridView UserAccountDisplay;
        private TextBox tbSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ColUsername;
        private DataGridViewTextBoxColumn ColPassword;
        private DataGridViewTextBoxColumn ColRole;
        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColIDAdmin;
    }
}
