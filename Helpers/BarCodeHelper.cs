using System;

namespace SalesPro.Helpers
{
    public class BarCodeHelper
    {
        public static string FormatBarcode(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty");
            }

            // Step 1: Remove unwanted characters such as "/r" or any non-numeric characters
            string formattedInput = input.Trim(); // Remove leading/trailing spaces
            formattedInput = formattedInput.Replace("/r", ""); // Remove "/r" (carriage return)

            // Step 2: Optionally, remove any non-numeric characters (if you want to support only numeric barcodes)
            formattedInput = string.Concat(System.Text.RegularExpressions.Regex.Split(formattedInput, @"\D"));

            // Step 3: Return the cleaned and formatted barcode value
            return formattedInput;
        }
    }
}
