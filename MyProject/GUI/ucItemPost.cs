using MyProject.BLL;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucItemPost : UserControl
    {
        private Notify baiViet;

        public event EventHandler<Notify> XoaClicked;
        public event EventHandler DaSuaThanhCong; // để báo cho ucUpdateInfo reload

        public ucItemPost(Notify bv)
        {
            InitializeComponent();
            baiViet = bv;
            LoadData();
        }

        private void LoadData()
        {
            lblTieuDe.Text = baiViet.TieuDe;
            lblNguoiDang.Text = $"Đăng bởi {baiViet.Username} • {baiViet.CreatedAt:dd/MM/yyyy HH:mm}";
            lbNoiDung.Text = baiViet.NoiDung;
            CenterTitleLabel();

            if (!string.IsNullOrEmpty(baiViet.AnhURL))
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, baiViet.AnhURL);
                if (System.IO.File.Exists(path))
                {
                    picAnh.Image = System.Drawing.Image.FromFile(path);
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void CenterTitleLabel()
        {
            lblTieuDe.Left = (this.Width - lblTieuDe.Width) / 2;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            formInfoUpdate form = new formInfoUpdate(baiViet); // truyền bài viết cũ vào
            if (form.ShowDialog() == DialogResult.OK)
            {
                DaSuaThanhCong?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            XoaClicked?.Invoke(this, baiViet);
        }

        private void ucItemPost_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
