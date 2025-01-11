using SalesPro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Helpers
{
    public static class PaymentMethodHelper
    {
        /// <summary>
        /// Gets the filtered list of PaymentMethod enum values, excluding NotSet.
        /// </summary>
        /// <returns>A list of filtered PaymentMethod values.</returns>
        public static List<PaymentMethod> GetFilteredPaymentMethods()
        {
            return Enum.GetValues(typeof(PaymentMethod))
                       .Cast<PaymentMethod>()
                       .Where(x => x != PaymentMethod.NotSet)
                       .ToList();
        }
    }

}
