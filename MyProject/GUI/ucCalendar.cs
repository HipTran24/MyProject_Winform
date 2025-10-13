using MyProject.BLL;
using MyProject.DAL;
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
    public partial class ucCalendar : UserControl
    {
        private readonly CalendarBLL _calendarBLL;
        public ucCalendar()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _calendarBLL = new CalendarBLL();
        }


        private void ucCalendar_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new formInfoCalendar("add");
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            {
                if (CalendarDisplay.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn lịch cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = CalendarDisplay.CurrentRow;
                string maMH = row.Cells["ColMaMH"].Value.ToString();
                string maGV = row.Cells["ColMaGV"].Value.ToString();
                DateOnly ngay = (DateOnly)row.Cells["ColNgay"].Value;
                string tiet = row.Cells["ColTietHoc"].Value.ToString();
                string phong = row.Cells["ColPhongHoc"].Value.ToString();

                var f = new formInfoCalendar("edit", maMH, maGV, ngay, tiet, phong);
                if (f.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }
        private void LoadData()
        {
            try
            {
                var list = _calendarBLL.GetAllCalendar();
                CalendarDisplay.DataSource = null;
                CalendarDisplay.AutoGenerateColumns = false; // để tự sinh cột
                CalendarDisplay.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CalendarDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = CalendarDisplay.CurrentRow;
            string maMH = row.Cells["ColMaMH"].Value.ToString();
            string maGV = row.Cells["ColMaGV"].Value.ToString();
            DateOnly ngay = (DateOnly)row.Cells["ColNgay"].Value;
            string tietHoc = row.Cells["ColTietHoc"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa lịch giảng của {maGV} - {maMH} ngày {ngay:dd/MM/yyyy} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _calendarBLL.Delete(maMH, maGV, ngay, tietHoc);
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lịch giảng: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
