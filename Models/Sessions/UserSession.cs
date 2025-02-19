using SalesPro.Enums;
using System.Collections.Generic;

namespace SalesPro.Models
{
    public class UserSession
    {
        public static string FullName { get; private set; }
        public static int Session_UserId { get; private set; }

        public static List<string> Roles { get; set; } = new List<string>();

        public static void SetUserFullName(string fullName)
        {
            FullName = fullName;
        }

        public static void SetUserId(int userid)
        {
            Session_UserId = userid;
        }

        public static bool HasAccess(string role)
        {
            return Roles.Contains(role);
        }
    }
}
