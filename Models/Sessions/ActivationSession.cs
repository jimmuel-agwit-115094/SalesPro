namespace SalesPro.Models.Sessions
{
    public class ActivationSession
    {
        public static bool IsActivated { get; private set; }
        public static string LicenseKey { get; private set; }

        public static void SetIsActivated(bool isActivated)
        {
            IsActivated = isActivated;
        }

        public static void SetLicenseKey(string licenseKey)
        {
            LicenseKey = licenseKey;
        }
    }
}
