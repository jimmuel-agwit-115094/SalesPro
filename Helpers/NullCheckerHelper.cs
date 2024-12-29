using SalesPro.Helpers;
using System;

namespace POS_Generic.Helpers
{
    public class NullCheckerHelper
    {
        public static void NullCheck<T>(T entity) where T : class
        {
            if (entity == null)
            {
                MessageHandler.ShowWarning($"{entity.ToString()} not found on the database.Please close form and try again");
                // Stop further execution
                throw new OperationCanceledException($"{entity} validation failed.");
            }
        }
    }
}
