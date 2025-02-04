using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class ActivationService
    {
        public static string GetMachineKey()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                    return obj["ProcessorId"].ToString();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting machine key: {ex}");
            }
            return "UNKNOWN";
        }

        public static bool VerifyLicenseKey(string licenseKey, string signature, string publicKeyXml)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKeyXml);
                var dataBytes = Encoding.UTF8.GetBytes(licenseKey);
                var signatureBytes = Convert.FromBase64String(signature);
                return rsa.VerifyData(dataBytes, CryptoConfig.MapNameToOID("SHA256"), signatureBytes);
            }
        }

        public static bool IsBase64String(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Check if the string length is a multiple of 4
            if (input.Length % 4 != 0)
                return false;

            // Check if the string is a valid Base64 string by attempting to convert it
            try
            {
                Convert.FromBase64String(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public async Task<int> SaveActivationData(ActivationModel data)
        {
            using (var context = new DatabaseContext())
            {
                await context.Activation.AddAsync(data);
                return await context.SaveChangesAsync();
            }
        }
    }
}
