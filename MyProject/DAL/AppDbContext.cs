using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Faculty> Khoa { get; set; }
        public DbSet<Lecturers> GiangVien { get; set; }
        public DbSet<ClassRoom> LopHoc { get; set; }
        public DbSet<Students> SinhVien { get; set; }
        public DbSet<Subjects> MonHoc { get; set; }
        public DbSet<AppUsers> Users { get; set; }
        public DbSet<Score> Diem { get; set; }
        public DbSet<Calendars> LichGiangDay { get; set; }

        public DbSet<Notify> ThongBao { get; set; }

        public DbSet<SoftwareInfo> ThongtinPM { get; set; }
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-3P1MPM2S;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ==========================
            // 🔹 KHOA - LỚP / GIẢNG VIÊN / MÔN HỌC
            // ==========================
            modelBuilder.Entity<ClassRoom>()
                .HasOne(c => c.faculty)
                .WithMany(f => f.classrooms)
                .HasForeignKey(c => c.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade để tránh vòng

            modelBuilder.Entity<Lecturers>()
                .HasOne(l => l.faculty)
                .WithMany(f => f.lecturers)
                .HasForeignKey(l => l.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade

            modelBuilder.Entity<Subjects>()
                .HasOne(s => s.faculty)
                .WithMany(f => f.subjects)
                .HasForeignKey(s => s.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade


            // ==========================
            // 🔹 LỚP - SINH VIÊN
            // ==========================
            modelBuilder.Entity<Students>()
                .HasOne(s => s.classrooms)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.MaLop)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa lớp thì xóa sinh viên


            // ==========================
            // 🔹 SINH VIÊN - ĐIỂM
            // ==========================
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.students)
                .WithMany(s => s.Scores)
                .HasForeignKey(sc => sc.MaSV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa sinh viên thì xóa điểm


            // 🔹 MÔN HỌC - ĐIỂM
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.subjects)
                .WithMany(sb => sb.Scores)
                .HasForeignKey(sc => sc.MaMH)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa môn học thì xóa điểm


            // ==========================
            // 🔹 USERS (Sinh viên / Giảng viên)
            // ==========================
            modelBuilder.Entity<AppUsers>()
                .HasOne(u => u.students)
                .WithOne(s => s.users)
                .HasForeignKey<AppUsers>(u => u.MaSV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa sinh viên thì xóa user

            modelBuilder.Entity<AppUsers>()
                .HasOne(u => u.lecturers)
                .WithMany(l => l.users)
                .HasForeignKey(u => u.MaGV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa giảng viên thì xóa user


            // ==========================
            // 🔹 SCORE & CALENDARS (Composite Keys)
            // ==========================
            modelBuilder.Entity<Score>()
                .HasKey(s => new { s.MaSV, s.MaMH });

            modelBuilder.Entity<Calendars>()
                .HasKey(l => new { l.MaMH, l.MaGV });


            // ==========================
            // 🔹 CALENDARS - SUBJECTS / LECTURERS
            // ==========================
            modelBuilder.Entity<Calendars>()
                .HasOne(l => l.MonHoc)
                .WithMany(m => m.LichGiangDay)
                .HasForeignKey(l => l.MaMH)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa môn thì xóa lịch

            modelBuilder.Entity<Calendars>()
                .HasOne(l => l.GiangVien)
                .WithMany(gv => gv.LichGiangDay)
                .HasForeignKey(l => l.MaGV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa GV thì xóa lịch

            modelBuilder.Entity<Calendars>()
                .Property(l => l.Ngay)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 STUDENTS - DateOnly conversion
            // ==========================
            modelBuilder.Entity<Students>()
                .Property(s => s.NgaySinh)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 SUBJECTS - DateOnly conversion
            // ==========================
            modelBuilder.Entity<Subjects>()
                .Property(s => s.NgayBatDau)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));

            modelBuilder.Entity<Subjects>()
                .Property(s => s.NgayKetThuc)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 NOTIFY - ADMIN (USER)
            // ==========================
            modelBuilder.Entity<Notify>()
                .HasOne(n => n.Admin)
                .WithMany(u => u.Notifies)
                .HasForeignKey(n => n.Username)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notify>()
                .ToTable("ThongBao")
                .HasKey(n => n.MaTB);


            base.OnModelCreating(modelBuilder);
            // 1. Faculty
            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { MaKhoa = "KH001", TenKhoa = "Công nghệ Thông tin", TruongKhoa = "Nguyễn Văn An", PhongCongTac = "Phòng A101", SoLuongLop = 25, EmailKhoa = "cntt@hutech.edu.vn" },
                new Faculty { MaKhoa = "KH002", TenKhoa = "Kinh tế", TruongKhoa = "Trần Thị Bình", PhongCongTac = "Phòng B201", SoLuongLop = 30, EmailKhoa = "kinhte@hutech.edu.vn" },
                new Faculty { MaKhoa = "KH003", TenKhoa = "Cơ khí", TruongKhoa = "Lê Văn Cường", PhongCongTac = "Phòng C301", SoLuongLop = 20, EmailKhoa = "cokhi@hutech.edu.vn" },
                new Faculty { MaKhoa = "KH004", TenKhoa = "Điện - Điện tử", TruongKhoa = "Phạm Thị Dung", PhongCongTac = "Phòng D401", SoLuongLop = 15, EmailKhoa = "dientu@hutech.edu.vn" },
                new Faculty { MaKhoa = "KH005", TenKhoa = "Quản trị Kinh doanh", TruongKhoa = "Hoàng Văn Minh", PhongCongTac = "Phòng E501", SoLuongLop = 18, EmailKhoa = "qtkd@hutech.edu.vn" }
            );

            // 2. Lecturers
            modelBuilder.Entity<Lecturers>().HasData(
                new Lecturers { MaGV = "GV001", HoTen = "Nguyễn Văn An", SDT = "0912345678", Email = "an.nguyen@hutech.edu.vn", MaKhoa = "KH001" },
                new Lecturers { MaGV = "GV002", HoTen = "Trần Thị Bình", SDT = "0987654321", Email = "binh.tran@hutech.edu.vn", MaKhoa = "KH002" },
                new Lecturers { MaGV = "GV003", HoTen = "Lê Văn Cường", SDT = "0901234567", Email = "cuong.le@hutech.edu.vn", MaKhoa = "KH001" },
                new Lecturers { MaGV = "GV004", HoTen = "Phạm Thị Dung", SDT = "0934567890", Email = "dung.pham@hutech.edu.vn", MaKhoa = "KH003" },
                new Lecturers { MaGV = "GV005", HoTen = "Hoàng Văn Minh", SDT = "0978889999", Email = "minh.hoang@hutech.edu.vn", MaKhoa = "KH002" }
            );
            // 3. Subjects
            modelBuilder.Entity<Subjects>().HasData(
                new Subjects { MaMH = "MH001", TenMH = "Lập trình C#", SoTinChi = 3, SoTiet = 45, NgayBatDau = new DateOnly(2025, 10, 1), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH001" },
                new Subjects { MaMH = "MH002", TenMH = "Cơ sở dữ liệu", SoTinChi = 3, SoTiet = 45, NgayBatDau = new DateOnly(2025, 10, 2), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH001" },
                new Subjects { MaMH = "MH003", TenMH = "Kinh tế vi mô", SoTinChi = 2, SoTiet = 30, NgayBatDau = new DateOnly(2025, 10, 3), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH002" },
                new Subjects { MaMH = "MH004", TenMH = "Nguyên lý kế toán", SoTinChi = 2, SoTiet = 30, NgayBatDau = new DateOnly(2025, 10, 4), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH002" },
                new Subjects { MaMH = "MH005", TenMH = "Vẽ kỹ thuật", SoTinChi = 3, SoTiet = 45, NgayBatDau = new DateOnly(2025, 10, 5), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH003" },
                new Subjects { MaMH = "MH006", TenMH = "Điện tử cơ bản", SoTinChi = 3, SoTiet = 45, NgayBatDau = new DateOnly(2025, 10, 6), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH004" },
                new Subjects { MaMH = "MH007", TenMH = "Quản trị học", SoTinChi = 2, SoTiet = 30, NgayBatDau = new DateOnly(2025, 10, 7), NgayKetThuc = new DateOnly(2025, 12, 31), MaKhoa = "KH005" }
            );


            // 4. ClassRoom
            modelBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom { MaLop = "LOP001", TenLop = "CNTT1", KhoaHoc = "2021-2025", MaGV = "GV001", MaKhoa = "KH001", SoLuongSV = 0 },
                new ClassRoom { MaLop = "LOP002", TenLop = "CNTT2", KhoaHoc = "2021-2025", MaGV = "GV002", MaKhoa = "KH001", SoLuongSV = 0 },
                new ClassRoom { MaLop = "LOP003", TenLop = "QTKD1", KhoaHoc = "2021-2025", MaGV = "GV003", MaKhoa = "KH002", SoLuongSV = 0 },
                new ClassRoom { MaLop = "LOP004", TenLop = "QTKD2", KhoaHoc = "2021-2025", MaGV = "GV004", MaKhoa = "KH002", SoLuongSV = 0 }
            );

            // 5. Students
            modelBuilder.Entity<Students>().HasData(
                new Students { MaSV = "SV001", HoTen = "Nguyễn Văn A", NgaySinh = new DateOnly(2003, 5, 10), GioiTinh = "Nam", DiaChi = "TP.HCM", Email = "a@gmail.com", SDT = "0901234567", MaLop = "LOP001" },
                new Students { MaSV = "SV002", HoTen = "Trần Thị B", NgaySinh = new DateOnly(2004, 1, 15), GioiTinh = "Nữ", DiaChi = "Hà Nội", Email = "b@gmail.com", SDT = "0912345678", MaLop = "LOP001" },
                new Students { MaSV = "SV003", HoTen = "Lê Văn C", NgaySinh = new DateOnly(2002, 9, 20), GioiTinh = "Nam", DiaChi = "Đà Nẵng", Email = "c@gmail.com", SDT = "0923456789", MaLop = "LOP002" },
                new Students { MaSV = "SV004", HoTen = "Phạm Thị D", NgaySinh = new DateOnly(2003, 12, 5), GioiTinh = "Nữ", DiaChi = "Cần Thơ", Email = "d@gmail.com", SDT = "0934567890", MaLop = "LOP002" },
                new Students { MaSV = "SV005", HoTen = "Hoàng Văn E", NgaySinh = new DateOnly(2001, 3, 18), GioiTinh = "Nam", DiaChi = "Hải Phòng", Email = "e@gmail.com", SDT = "0945678901", MaLop = "LOP003" },
                new Students { MaSV = "SV006", HoTen = "Đỗ Thị F", NgaySinh = new DateOnly(2004, 7, 22), GioiTinh = "Nữ", DiaChi = "Huế", Email = "f@gmail.com", SDT = "0956789012", MaLop = "LOP003" },
                new Students { MaSV = "SV007", HoTen = "Ngô Văn G", NgaySinh = new DateOnly(2002, 11, 30), GioiTinh = "Nam", DiaChi = "Bình Dương", Email = "g@gmail.com", SDT = "0967890123", MaLop = "LOP004" },
                new Students { MaSV = "SV008", HoTen = "Võ Thị H", NgaySinh = new DateOnly(2003, 4, 25), GioiTinh = "Nữ", DiaChi = "Nha Trang", Email = "h@gmail.com", SDT = "0978901234", MaLop = "LOP004" },
                new Students { MaSV = "SV009", HoTen = "Bùi Văn I", NgaySinh = new DateOnly(2001, 8, 14), GioiTinh = "Nam", DiaChi = "Quảng Ninh", Email = "i@gmail.com", SDT = "0989012345", MaLop = "LOP001" },
                new Students { MaSV = "SV010", HoTen = "Bùi Văn I", NgaySinh = new DateOnly(2001, 8, 14), GioiTinh = "Nam", DiaChi = "Quảng Ninh", Email = "i@gmail.com", SDT = "0989012345", MaLop = "LOP001" }

            );

            // 6. Score
            modelBuilder.Entity<Score>().HasData(
                // --- Học kỳ 1A ---
                new { Id = 1, MaSV = "SV001", MaMH = "MH001", DiemGK = 7.0f, DiemCK = 8.0f, DiemTrungBinh = 7.5f, HocKy = "HK1A-2025-2026" },
                new { Id = 2, MaSV = "SV002", MaMH = "MH002", DiemGK = 6.0f, DiemCK = 7.0f, DiemTrungBinh = 6.5f, HocKy = "HK1A-2025-2026" },
                new { Id = 3, MaSV = "SV003", MaMH = "MH003", DiemGK = 8.0f, DiemCK = 8.5f, DiemTrungBinh = 8.25f, HocKy = "HK1A-2025-2026" },
                new { Id = 4, MaSV = "SV004", MaMH = "MH001", DiemGK = 9.0f, DiemCK = 9.5f, DiemTrungBinh = 9.25f, HocKy = "HK1A-2025-2026" },
                new { Id = 5, MaSV = "SV005", MaMH = "MH002", DiemGK = 5.5f, DiemCK = 6.0f, DiemTrungBinh = 5.75f, HocKy = "HK1A-2025-2026" },

                // --- Học kỳ 1B ---
                new { Id = 6, MaSV = "SV006", MaMH = "MH001", DiemGK = 6.5f, DiemCK = 7.0f, DiemTrungBinh = 6.75f, HocKy = "HK1B-2025-2026" },
                new { Id = 7, MaSV = "SV007", MaMH = "MH003", DiemGK = 7.5f, DiemCK = 8.0f, DiemTrungBinh = 7.75f, HocKy = "HK1B-2025-2026" },
                new { Id = 8, MaSV = "SV008", MaMH = "MH002", DiemGK = 8.5f, DiemCK = 9.0f, DiemTrungBinh = 8.75f, HocKy = "HK1B-2025-2026" },
                new { Id = 9, MaSV = "SV009", MaMH = "MH001", DiemGK = 9.0f, DiemCK = 9.5f, DiemTrungBinh = 9.25f, HocKy = "HK1B-2025-2026" },
                new { Id = 10, MaSV = "SV010", MaMH = "MH003", DiemGK = 5.0f, DiemCK = 6.0f, DiemTrungBinh = 5.5f, HocKy = "HK1B-2025-2026" },

                // --- Học kỳ 2A ---
                new { Id = 11, MaSV = "SV001", MaMH = "MH002", DiemGK = 6.0f, DiemCK = 7.0f, DiemTrungBinh = 6.5f, HocKy = "HK2A-2025-2026" },
                new { Id = 12, MaSV = "SV002", MaMH = "MH003", DiemGK = 7.0f, DiemCK = 7.5f, DiemTrungBinh = 7.25f, HocKy = "HK2A-2025-2026" },
                new { Id = 13, MaSV = "SV003", MaMH = "MH001", DiemGK = 8.0f, DiemCK = 8.5f, DiemTrungBinh = 8.25f, HocKy = "HK2A-2025-2026" },
                new { Id = 14, MaSV = "SV004", MaMH = "MH002", DiemGK = 5.5f, DiemCK = 6.0f, DiemTrungBinh = 5.75f, HocKy = "HK2A-2025-2026" },
                new { Id = 15, MaSV = "SV005", MaMH = "MH003", DiemGK = 9.0f, DiemCK = 9.5f, DiemTrungBinh = 9.25f, HocKy = "HK2A-2025-2026" },

                // --- Học kỳ 2B ---
                new { Id = 16, MaSV = "SV006", MaMH = "MH002", DiemGK = 7.5f, DiemCK = 8.0f, DiemTrungBinh = 7.75f, HocKy = "HK2B-2025-2026" },
                new { Id = 17, MaSV = "SV007", MaMH = "MH001", DiemGK = 8.0f, DiemCK = 8.5f, DiemTrungBinh = 8.25f, HocKy = "HK2B-2025-2026" },
                new { Id = 18, MaSV = "SV008", MaMH = "MH003", DiemGK = 6.5f, DiemCK = 7.0f, DiemTrungBinh = 6.75f, HocKy = "HK2B-2025-2026" },
                new { Id = 19, MaSV = "SV009", MaMH = "MH002", DiemGK = 9.0f, DiemCK = 9.5f, DiemTrungBinh = 9.25f, HocKy = "HK2B-2025-2026" },
                new { Id = 20, MaSV = "SV010", MaMH = "MH001", DiemGK = 5.0f, DiemCK = 6.0f, DiemTrungBinh = 5.5f, HocKy = "HK2B-2025-2026" },

                // --- Học kỳ 3 ---
                new { Id = 21, MaSV = "SV001", MaMH = "MH003", DiemGK = 7.0f, DiemCK = 8.0f, DiemTrungBinh = 7.5f, HocKy = "HK3-2025-2026" },
                new { Id = 22, MaSV = "SV002", MaMH = "MH001", DiemGK = 6.0f, DiemCK = 7.0f, DiemTrungBinh = 6.5f, HocKy = "HK3-2025-2026" },
                new { Id = 23, MaSV = "SV003", MaMH = "MH002", DiemGK = 8.0f, DiemCK = 8.5f, DiemTrungBinh = 8.25f, HocKy = "HK3-2025-2026" },
                new { Id = 24, MaSV = "SV004", MaMH = "MH003", DiemGK = 9.0f, DiemCK = 9.5f, DiemTrungBinh = 9.25f, HocKy = "HK3-2025-2026" },
                new { Id = 25, MaSV = "SV005", MaMH = "MH001", DiemGK = 5.5f, DiemCK = 6.0f, DiemTrungBinh = 5.75f, HocKy = "HK3-2025-2026" }
            );



            // 7. Calendar (Lịch giảng dạy)
            modelBuilder.Entity<Calendars>().HasData(
                new { MaMH = "MH001", MaGV = "GV001", Ngay = new DateOnly(2025, 10, 01), TietHoc = "1-3", PhongHoc = "A101" },
                new { MaMH = "MH002", MaGV = "GV001", Ngay = new DateOnly(2025, 10, 02), TietHoc = "4-6", PhongHoc = "A102" },
                new { MaMH = "MH003", MaGV = "GV002", Ngay = new DateOnly(2025, 10, 03), TietHoc = "7-9", PhongHoc = "B201" },
                new { MaMH = "MH004", MaGV = "GV002", Ngay = new DateOnly(2025, 10, 04), TietHoc = "1-3", PhongHoc = "B202" },
                new { MaMH = "MH005", MaGV = "GV004", Ngay = new DateOnly(2025, 10, 05), TietHoc = "4-6", PhongHoc = "C301" },
                new { MaMH = "MH006", MaGV = "GV004", Ngay = new DateOnly(2025, 10, 06), TietHoc = "7-9", PhongHoc = "D401" },
                new { MaMH = "MH007", MaGV = "GV005", Ngay = new DateOnly(2025, 10, 07), TietHoc = "1-3", PhongHoc = "E501" }
            );
            modelBuilder.Entity<AppUsers>().HasData(
                new AppUsers { Username = "sv001", Password = "123456", Role = "Student", MaSV = "SV001", MaGV = null, AdminID = null },
                new AppUsers { Username = "sv002", Password = "123456", Role = "Student", MaSV = "SV002", MaGV = null, AdminID = null },
                new AppUsers { Username = "gv001", Password = "123456", Role = "Lecturer", MaSV = null, MaGV = "GV001", AdminID = null },
                new AppUsers { Username = "gv002", Password = "123456", Role = "Lecturer", MaSV = null, MaGV = "GV002", AdminID = null },
                new AppUsers { Username = "admin01", Password = "admin123", Role = "Admin", MaSV = null, MaGV = null, AdminID = "AD001" },
                new AppUsers { Username = "admin02", Password = "admin456", Role = "Admin", MaSV = null, MaGV = null, AdminID = "AD002" });

            modelBuilder.Entity<Notify>().HasData(
                new Notify { MaTB = "TB001", TieuDe = "Thông báo họp", NoiDung = "Toàn thể giảng viên họp vào thứ Hai, 9h tại hội trường.", AnhURL = null, CreatedAt = new DateTime(2025, 09, 30), Username = "admin01" },
                new Notify { MaTB = "TB002", TieuDe = "Đăng ký học phần", NoiDung = "Sinh viên đăng ký học phần trước ngày 15/10.", AnhURL = "/images/guide.png", CreatedAt = new DateTime(2025, 09, 30), Username = "admin02" });

            modelBuilder.Entity<SoftwareInfo>().HasData(
              new SoftwareInfo
              {
                  MaPM = 1,
                  TenPM = "Phần mềm Quản Lý Sinh Viên",
                  MoTa = "Phần mềm được phát triển nhằm hỗ trợ quản lý toàn diện thông tin sinh viên, giảng viên, lớp học và kết quả học tập. Hệ thống cho phép admin quản lý dữ liệu trung tâm, giảng viên có thể nhập điểm và cập nhật lịch giảng dạy, sinh viên có thể tra cứu thông tin cá nhân, lịch học, điểm số cũng như nhận các thông báo mới nhất từ nhà trường. Phần mềm được xây dựng dựa trên nền tảng Entity Framework Core, hỗ trợ kết nối cơ sở dữ liệu SQL Server, giao diện thân thiện dễ sử dụng, phân quyền rõ ràng giữa admin, giảng viên và sinh viên. Mục tiêu chính là giảm tải công việc quản lý thủ công, tăng tính chính xác của dữ liệu và nâng cao trải nghiệm cho người dùng."
              }
      );
        }
    }
}
