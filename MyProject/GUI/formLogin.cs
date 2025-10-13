using MyProject.BLL;
using MyProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formLogin : Form
    {
        private readonly UserBLL _userBll = new UserBLL();

        public formLogin()
        {
            InitializeComponent();
            txbPass.UseSystemPasswordChar = true;   // ẩn ký tự
            this.AcceptButton = button1;// nhấn Enter để login
            button1.Click += button1_Click;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            string username = txbUser.Text.Trim();
            string password = txbPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userBll.Login(username, password);
            if (user != null)
            {
                AuthContextService.SignIn(user);
                this.DialogResult = DialogResult.OK; // cho Program.cs biết là login OK
                Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkClicked += (s, ev) =>
                {
                    using var f = new formForgotPassword();
                    f.ShowDialog(this);
                };
            }
            catch { /* ignore if control not present */ }
        }
    }
}
