using System;

namespace POS_Generic.Helpers
{
    public class NullCheckerHelper
    {
        public static void NullCheck<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new NullReferenceException($"{entity} validation failed.");
            }
        }
    }
}
