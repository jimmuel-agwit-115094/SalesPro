using SalesPro.Enums;
using System;

namespace SalesPro.Models.Sessions
{
    public class ActivationSession
    {
        public static string LicenseKey { get; private set; }
        public static ActivationStatus ActivationStatus { get; private set; }
        public static int TrialDays { get; private set; }

        public static void SetActivationStatus(ActivationStatus status)
        {
            ActivationStatus = status;
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
