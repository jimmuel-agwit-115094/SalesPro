using SalesPro.Enums;

namespace SalesPro.Models
{
    public class UserSession
    {
        public static string FullName { get; private set; }
        public static int Session_UserId { get; private set; }
        public static UserAccess UserAccess { get; private set; }

        public static void SetUserFullName(string fullName)
        {
            FullName = fullName;
        }

        public static void SetUserId(int userid)
        {
            Session_UserId = userid;
        }

        public static void SetUserAccess(UserAccess access)
        {
            UserAccess = access;
        }
    }
}
