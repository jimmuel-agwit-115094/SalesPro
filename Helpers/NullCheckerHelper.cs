using System;

namespace POS_Generic.Helpers
{
    //public class NullCheckerHelper
    //{
    //    public static void NullCheck<T>(T entity) where T : class
    //    {
    //        if (entity == null)
    //        {
    //            throw new NullReferenceException($"{entity} validation failed.");
    //        }
    //    }
    //}
    public static class NullCheckerHelper
    {
        public static void NullCheck<T>(T entity, string objectName = "Object") where T : class
        {
            if (entity == null)
            {
                string errorMessage = $"{objectName} cannot be null.";

                // Show a message box with the error message
                System.Windows.Forms.MessageBox.Show(errorMessage, "Validation Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);

                // Throw an exception with the same message
                throw new NullReferenceException(errorMessage);
            }
        }
    }

}
