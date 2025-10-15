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
    public partial class ucUpdateInfo : UserControl
    {
        private readonly NotifyBLL notifyBLL = new NotifyBLL();
        private List<Notify> danhSachBaiViet = new List<Notify>();

        public ucUpdateInfo()
        {
            InitializeComponent();
        }


        private void LoadDanhSach()
        {
            flowPanel.Controls.Clear();
            danhSachBaiViet = notifyBLL.GetAllNotify();

            // Thiết lập cho flowPanel
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoSize = false;
            flowPanel.Anchor = AnchorStyles.Top;
            flowPanel.Padding = new Padding(0, 10, 0, 10);

            foreach (var bv in danhSachBaiViet)
            {
                ucItemPost item = new ucItemPost(bv);
                item.XoaClicked += Item_XoaClicked;
                item.DaSuaThanhCong += (s, e) => LoadDanhSach();

                // 👉 căn giữa từng item
                item.Anchor = AnchorStyles.None;
                item.Margin = new Padding(0, 15, 0, 15);
                item.Width = flowPanel.ClientSize.Width - 150; // trừ hai bên để còn khoảng trắng

                // thêm vào panel
                flowPanel.Controls.Add(item);

                // sau khi thêm, đặt vị trí giữa
                item.Left = (flowPanel.ClientSize.Width - item.Width) / 2;
            }

            // 👉 Khi form hoặc panel resize thì vẫn giữ giữa
            flowPanel.Resize -= FlowPanel_Resize; // tránh đăng ký trùng
            flowPanel.Resize += FlowPanel_Resize;
        }

        // 👉 Hàm giữ các bài viết căn giữa khi resize
        private void FlowPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control item in flowPanel.Controls)
            {
                item.Left = (flowPanel.ClientSize.Width - item.Width) / 2;
            }
        }

        private void Item_XoaClicked(object sender, Notify bv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bài viết này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notifyBLL.Delete(bv.MaTB);
                LoadDanhSach();
                MessageBox.Show("Đã xóa bài viết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ucUpdateInfo_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            formInfoUpdate form = new formInfoUpdate();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSach();
                MessageBox.Show("Đăng bài viết thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, Notify bv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bài viết này?",
               "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notifyBLL.Delete(bv.MaTB);
                LoadDanhSach();
            }
        }
    }
}
