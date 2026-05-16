using System;

namespace hrms_query.Session
{
    public static class UserSession
    {
        private static bool _isInitialized = false; // Tracks if session is set
        
        public static bool IsLoggedIn { get; set; }
        public static int UserId { get; private set; }
        public static string UserName { get; private set; }
        public static string Email { get; private set; }
        public static string Role { get; private set; }
        public static string Token { get; private set; }
        public static bool IsAdmin { get; private set; }
        public static DateTime Expiration { get; private set; }

        public static void SetSession(int userId, string userName, string email, string role, string token, DateTime? expiration = null)
        {
            UserId = userId;
            UserName = userName ?? throw new ArgumentNullException(nameof(userName), "Username cannot be null.");
            Email = email ?? string.Empty; // Allow empty email if not provided
            Role = role ?? throw new ArgumentNullException(nameof(role), "Role cannot be null.");
            Token = token ?? throw new ArgumentNullException(nameof(token), "Token cannot be null.");
            IsAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
            Expiration = expiration ?? DateTime.UtcNow.AddHours(1); // Default to 1-hour expiration
            _isInitialized = true;
        }
        public static void ClearSession()
        {
            UserId = 0;
            UserName = string.Empty;
            Email = string.Empty;
            Role = string.Empty;
            Token = string.Empty;
            IsAdmin = false;
            Expiration = DateTime.MinValue;
            _isInitialized = false;
        }

        public static bool IsSessionValid()
        {
            return _isInitialized &&
                   !string.IsNullOrEmpty(Token) &&
                   DateTime.UtcNow <= Expiration;
        }

        public static bool IsAuthenticated => IsSessionValid();
    }
}