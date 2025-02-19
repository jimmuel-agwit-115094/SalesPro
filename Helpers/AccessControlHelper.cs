using SalesPro.Models;

namespace SalesPro.Helpers
{
    public class AccessControlHelper
    {
        public static bool HasAccess(string permission)
        {
            if (!UserSession.HasAccess(permission))
            {
                MessageHandler.ShowError("You do not have permission to perform this action.");
                return false;
            }
            return true;
        }

    }
}
