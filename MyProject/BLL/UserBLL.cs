using MyProject.DAL;
using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using MyProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    internal class UserBLL
    {
        private readonly IUserRepository _repo;

        public UserBLL()
        {
            _repo = new UserRepository();
        }

        public List<AppUsers> GetAllUser()
        {
            return _repo.GetAll();
        }

        /// <summary>
        /// Đăng nhập:
        /// - Tìm user theo Username (không cần sửa Repo – dùng GetAll rồi FirstOrDefault).
        /// - So khớp bằng BCrypt.Verify.
        /// - "Nâng cấp mềm": nếu DB còn lưu plaintext, lần đầu đăng nhập đúng sẽ hash lại & lưu.
        /// Trả về AppUsers nếu OK, ngược lại null.
        /// </summary>
        public AppUsers? Login(string username, string inputPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(inputPassword))
                return null;

            // KHÔNG đổi repository lúc này: lấy tất cả rồi lọc theo Username
            var user = _repo
                .GetAll()
                .FirstOrDefault(u => u.Username != null &&
                                     u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null) return null;

            // 1) Thử verify bằng BCrypt (chuẩn)
            if (BCrypt.Net.BCrypt.Verify(inputPassword, user.Password))
                return user;

            // 2) Nâng cấp mềm (tuỳ chọn): DB còn plaintext -> hash ngay sau khi khớp
            if (user.Password == inputPassword)
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(inputPassword);
                _repo.Update(user);
                return user;
            }

            // Sai mật khẩu
            return null;
        }

        /// <summary>
        /// Thêm user: HASH mật khẩu trước khi lưu.
        /// </summary>
        public void Add(AppUsers user)
        {
            var db = new AppDbContext();
            var student = db.SinhVien.FirstOrDefault(s => s.MaSV == user.MaSV);
            if (student != null && !string.IsNullOrEmpty(student.Email))
            {
                var emailService = new EmailService();
                _ = emailService.SendAccountActivationEmailAsync(
                    student.Email,
                    user.Username,
                    user.Password // ⚠️ gửi mật khẩu thật
                );
            }
            if (!string.IsNullOrWhiteSpace(user?.Password))
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            }
            
            _repo.Add(user);

            // ⚠️ Không gửi mật khẩu thô qua email nữa.
            // Nếu cần kích hoạt tài khoản: tạo token riêng & gửi link (làm sau).
        }

        /// <summary>
        /// Cập nhật user: nếu có đổi mật khẩu (Password khác rỗng) thì HASH trước khi lưu.
        /// </summary>
        public void Update(AppUsers user)
        {
            if (!string.IsNullOrWhiteSpace(user?.Password))
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            }

            _repo.Update(user);
        }

        public void Delete(string username)
        {
            _repo.Delete(username);
        }
    }
}
