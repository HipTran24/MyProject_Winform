namespace MyProject.GUI
{
    partial class ucItemPost
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
            lblTieuDe = new Label();
            lblNguoiDang = new Label();
            picAnh = new PictureBox();
            btnSua = new Button();
            btnXoa = new Button();
            lbNoiDung = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(369, 47);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(96, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "label1";
            // 
            // lblNguoiDang
            // 
            lblNguoiDang.AutoSize = true;
            lblNguoiDang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNguoiDang.Location = new Point(3, 2);
            lblNguoiDang.Name = "lblNguoiDang";
            lblNguoiDang.Size = new Size(93, 25);
            lblNguoiDang.TabIndex = 1;
            lblNguoiDang.Text = "Thông tin";
            // 
            // picAnh
            // 
            picAnh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picAnh.Location = new Point(3, 109);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(841, 227);
            picAnh.TabIndex = 3;
            picAnh.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(716, 465);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 6;
            btnSua.Text = "Thay đổi";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(588, 465);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // lbNoiDung
            // 
            lbNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbNoiDung.AutoSize = true;
            lbNoiDung.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNoiDung.Location = new Point(3, 352);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(89, 22);
            lbNoiDung.TabIndex = 8;
            lbNoiDung.Text = "Trạng thái";
            // 
            // ucItemPost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbNoiDung);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(picAnh);
            Controls.Add(lblNguoiDang);
            Controls.Add(lblTieuDe);
            Name = "ucItemPost";
            Size = new Size(848, 607);
            AutoSizeChanged += ucItemPost_AutoSizeChanged;
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblNguoiDang;
        private PictureBox picAnh;
        private Button btnSua;
        private Button btnXoa;
        private Label lbNoiDung;
    }
}
