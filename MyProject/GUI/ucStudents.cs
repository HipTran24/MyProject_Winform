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
    public partial class ucStudents : UserControl
    {
        private readonly StudentsBLL _studentBLL;
        public ucStudents()
        {
            InitializeComponent();
            _studentBLL = new StudentsBLL();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var list = db.SinhVien.ToList();
                StudentDisplay.AutoGenerateColumns = false;
                StudentDisplay.DataSource = list;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInfoStudent fInfo = new formInfoStudent("add");
            var result = fInfo.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadData(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentDisplay.CurrentRow != null)
            {
                DataGridViewRow row = StudentDisplay.CurrentRow;

                string maSV = row.Cells["ColMaSv"].Value.ToString();
                string hoTen = row.Cells["ColHoTen"].Value.ToString();
                string maLop = row.Cells["ColMaLop"].Value.ToString();
                var cellValue = row.Cells["ColNgaySinh"].Value;
                DateOnly ngaySinh = cellValue is DateOnly d
                    ? d
                    : DateOnly.FromDateTime(Convert.ToDateTime(cellValue));
                string gioiTinh = row.Cells["ColGioiTinh"].Value.ToString();
                string diaChi = row.Cells["ColDiaChi"].Value.ToString();
                string email = row.Cells["ColEmail"].Value.ToString();
                string sdt = row.Cells["ColSDT"].Value.ToString();

                formInfoStudent fInfo = new formInfoStudent("edit", maSV, hoTen, maLop, ngaySinh, gioiTinh, diaChi, email, sdt);
                var result = fInfo.ShowDialog(); 

                if (result == DialogResult.OK)
                {
                    LoadData(); 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để thay đổi thông tin!!");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ucStudents_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maSV = StudentDisplay.CurrentRow.Cells["ColMaSv"].Value.ToString();
            DialogResult result = MessageBox.Show(
            $"Bạn có chắc muốn xóa sinh viên có mã: {maSV} không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _studentBLL.Delete(maSV);
                    MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadData()
        {
            StudentDisplay.DataSource = null;
            StudentDisplay.DataSource = _studentBLL.GetAllStudents();
        }
    }
}
