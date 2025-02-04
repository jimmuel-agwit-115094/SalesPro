using System;

namespace SalesPro.Models.Sessions
{
    public class ActivationSession
    {
        public static bool IsActivated { get; private set; }
        public static string LicenseKey { get; private set; }
        public static bool IsTrial { get; private set; }
        public static int TrialDays { get; private set; }

        public static void SetIsActivated(bool isActivated)
        {
            IsActivated = isActivated;
        }

        public static void SetIsTrial(bool isTrial)
        {
            IsTrial = isTrial;
        }

        public static void SetLicenseKey(string licenseKey)
        {
            LicenseKey = licenseKey;
        }

        public static void SetTrialDays(int days)
        {
            TrialDays = days;
        }
    }
}
