using SalesPro.Helpers;
using System;

namespace POS_Generic.Helpers
{
    public class NullCheckerHelper
    {
        public static bool NullCheck(object obj)
        {
            if (obj == null)
            {
                MessageHandler.ShowError($"Error getting data for: {obj}");
                return false;
            }
            return true;
        }
    }
}
