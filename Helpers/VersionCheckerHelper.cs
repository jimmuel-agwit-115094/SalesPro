using System.Data;

namespace SalesPro.Helpers
{
    public class VersionCheckerHelper
    {
        public static bool ConcurrencyCheck(long oldVersion, long currentVersion)
        {
            if (oldVersion != currentVersion)
            { 
                MessageHandler.ShowWarning("Concurrency Violation: The data you are trying to modify has been updated by another user or process since you last accessed it. Please refresh the data and try again.");
                return false;
            }
            return true;
        }
    }
}
