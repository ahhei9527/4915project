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

        public static void CreateOrder(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void UpdateOrder(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void UpdateShipment(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void CreateShipment(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void UpdateSalesOrder(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void UpdateDeliveryconfirmation(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void CreateDeliveryconfirmation(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void AddInward(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }

        public static void AddComplaint(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }
        public static void UpdateComplaint(int userId, string username, string role, string email = "")
        {
            UserID = userId;
            Username = username ?? "Unknown";
            Role = role ?? "User";
            Email = email ?? "";
        }
    }
}