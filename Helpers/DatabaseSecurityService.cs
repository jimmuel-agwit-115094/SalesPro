using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Helpers
{
    public class DatabaseSecurityService
    {
        public static string GetDecryptedPassword()
        {
            string encryptedPassword = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            encryptedPassword = ExtractPassword(encryptedPassword); // Extract password from connection string

            return DecryptWithDPAPI(encryptedPassword);
        }

        private static string DecryptWithDPAPI(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        public static string ExtractPassword(string connString)
        {
            int start = connString.IndexOf("Pwd=") + 4;
            int end = connString.IndexOf(";", start);
            return (end == -1) ? connString.Substring(start) : connString.Substring(start, end - start);
        }
    }
}
