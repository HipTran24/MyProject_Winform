using MyProject.GUI;
using MyProject.Service;

namespace MyProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new formMain());
            while (true)
            {
                using (var login = new formLogin())
                {
                    var result = login.ShowDialog();
                    if (result != DialogResult.OK || !AuthContextService.IsLoggedIn) break;

                    Form? mainForm = AuthContextService.Role switch
                    {
                        "Admin" or "Quản trị" => new formMain(),
                        "Lecturer" or "Giảng viên" => new formLecturer(),
                        "Student" or "Sinh viên" => new formStudent(),
                        _ => null
                    };

                    if (mainForm == null)
                    {
                        MessageBox.Show("Vai trò người dùng không hợp  lệ", "Lại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AuthContextService.SignOut();
                        continue;
                    }

                    var mainResult = mainForm.ShowDialog();
                    if (mainResult == DialogResult.Retry) continue;
                    break; 
                }
            }
        }
    }
}