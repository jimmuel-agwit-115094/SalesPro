using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Services
{
    public class GenericService
    {
        public async Task<int> GetRowVersionAsync<T>(int id) where T : class
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    // Find the entity by its ID
                    var entity = await context.Set<T>().FindAsync(id);

                    if (entity == null)
                    {
                        throw new InvalidOperationException($"Entity of type {typeof(T).Name} with ID {id} not found.");
                    }
                    // Retrieve the RowVersion property directly
                    var rowVersionProperty = context.Entry(entity).Property("RowVersion");
                    return (int)rowVersionProperty.CurrentValue;
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error getting row version: {ex.Message}");
                    return 0;
                }
            }
        }


        public bool ValidatePayment(
            PaymentStatus paymentStatus,
            int selectedPaymentIndex,
            string referenceText,
            PaymentMethod selectedPaymentMethod,
            int selectedBankIndex,
            bool isForUpdate)
        {
            if (paymentStatus == PaymentStatus.Paid && isForUpdate != true)
            {
                MessageHandler.ShowWarning("Payment already made.");
                return false;
            }

            if (selectedPaymentIndex == -1)
            {
                MessageHandler.ShowWarning("Please select payment method.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(referenceText) && selectedPaymentMethod != PaymentMethod.Cash)
            {
                MessageHandler.ShowWarning("Please enter reference number.");
                return false;
            }

            if (selectedPaymentMethod != PaymentMethod.Cash && selectedBankIndex == -1)
            {
                MessageHandler.ShowWarning("Please select bank.");
                return false;
            }

            return true;
        }

        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }

}
