using SalesPro.Enums;

namespace SalesPro.Helpers
{
    public class AccessControlHelper
    {
        public static bool IsAdminAndDevUserAccess(UserAccess access)
        {
            return access == UserAccess.Admin || access == UserAccess.Developer;
        }
    }
}
