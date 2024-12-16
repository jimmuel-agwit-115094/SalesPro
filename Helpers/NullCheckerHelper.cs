using SalesPro.Helpers;
using System;

namespace POS_Generic.Helpers
{
    public class NullCheckerHelper
    {
        public static void NullChecker<T>(T value) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException("The data you are trying to update cannot be found. Please try again.");
            }
        }
    }
}
