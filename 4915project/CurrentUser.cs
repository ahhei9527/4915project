namespace _4915project
{
    public static class CurrentUser
    {
        public static int UserID { get; private set; } = 0;
        public static string Username { get; private set; } = string.Empty;
        public static string Role { get; private set; } = string.Empty;
        public static string Email { get; private set; } = string.Empty;

        public static bool IsLoggedIn => UserID > 0;

        public static void Login(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void Logout()
        {
            UserID = 0;
            Username = string.Empty;
            Role = string.Empty;
            Email = string.Empty;
        }
    }
}