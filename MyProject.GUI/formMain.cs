

using MyProject.BLL.Auth;
using MyProject.BLL.Service;
using System;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            MenuItemExportLecturers.Click += MenuItemExportLecturers_Click;
            MenuItemExportStudents.Click += MenuItemExportStudents_Click;
            MenuItemExportScores.Click += MenuItemExportScores_Click;

        }

        private void LoadControl(UserControl uc)
        {
            pnlEvaluate.Controls.Clear();   // Xóa control cũ
            uc.Dock = DockStyle.Fill;        // Fill panel
            pnlEvaluate.Controls.Add(uc);   // Thêm control mới
        }
        private void MenuItemMain_Click(object sender, EventArgs e)
        {
            LoadControl(new ucEvaluate());
        }
        private void MenuItemFaculty_Click(object sender, EventArgs e)
        {
            LoadControl(new ucFaculty());
        }


        private void MenuItemStudents_Click(object sender, EventArgs e)
        {
            LoadControl(new ucStudents());
        }

        private void MenuItemSubject_Click(object sender, EventArgs e)
        {
            LoadControl(new ucSubject());
        }

        private void MenuItemScore_Click(object sender, EventArgs e)
        {
            LoadControl(new ucScore());
        }

        private void MenuItemLecturers_Click(object sender, EventArgs e)
        {
            LoadControl(new ucLecturers());
        }

        private void MenuItemCalendar_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCalendar());
        }

        private void MenuItemUpdateAccount_Click(object sender, EventArgs e)
        {
            LoadControl(new ucUpdateAccount());
        }

        private void MenuItemUpdateInfo_Click(object sender, EventArgs e)
        {
            LoadControl(new ucUpdateInfo());
        }

        private void MenuItemChangeInfo_Click(object sender, EventArgs e)
        {
            LoadControl(new ucChangeInfo());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuItemSwInfo_Click(object sender, EventArgs e)
        {
            formSoftWareInfo fInfo = new formSoftWareInfo();
            fInfo.ShowDialog();
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            LoadControl(new ucEvaluate());
        }

        private void MenuItemExportLecturers_Click(object sender, EventArgs e)
        {
            ExportWithDialog("GiangVien");
        }

        private void MenuItemExportStudents_Click(object sender, EventArgs e)
        {
            ExportWithDialog("SinhVien");
        }

        private void MenuItemExportScores_Click(object sender, EventArgs e)
        {
            ExportWithDialog("BangDiem");
        }
        private void ExportWithDialog(string type)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = $"Chọn thư mục để lưu file danh sách {type}"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = $"DanhSach_{type}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
                string path = Path.Combine(dialog.SelectedPath, fileName);

                var exporter = new ExcelExportService();

                try
                {
                    switch (type)
                    {
                        case "GiangVien":
                            exporter.ExportLecturersOnly(path);
                            break;
                        case "SinhVien":
                            exporter.ExportStudentsOnly(path);
                            break;
                        case "BangDiem":
                            exporter.ExportScoresOnly(path);
                            break;
                    }

                    MessageBox.Show($"✅ Xuất thành công!\nĐường dẫn: {path}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file sau khi export
                    try
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo(path)
                            { UseShellExecute = true });
                    }
                    catch { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Lỗi khi xuất Excel: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            AuthContextService.SignOut();
            this.DialogResult = DialogResult.Retry; // báo Program quay lại login
            this.Close();
        }

    }
}
