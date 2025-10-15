using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL.Auth
{
    public static class AuthContextService
    {
        public static AppUsers? CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static string? Role => CurrentUser?.Role;

        public static bool IsAdmin => Role?.Equals("Admin", StringComparison.OrdinalIgnoreCase) == true;
        public static bool IsLecturer => Role?.Equals("Lecturer", StringComparison.OrdinalIgnoreCase) == true;
        public static bool IsStudent => Role?.Equals("Student", StringComparison.OrdinalIgnoreCase) == true;

        public static void SignIn(AppUsers user) => CurrentUser = user;
        public static void SignOut() => CurrentUser = null;
    }
}
