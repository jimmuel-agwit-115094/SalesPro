using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public static class CurrencyTextboxHelper
    {
        // Attach the KeyPress and Validation events to enforce strict two-decimal currency input
        public static void AttachCurrencyValidation(Control parentControl, string tag = "CurrencyOnly")
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox && (string.IsNullOrEmpty(tag) || textBox.Tag?.ToString() == tag))
                {
                    textBox.KeyPress += EnforceCurrencyOnly;
                    textBox.TextChanged += TruncateExcessDecimals;
                }
                if (control.HasChildren)
                {
                    AttachCurrencyValidation(control, tag);
                }
            }
        }

        // KeyPress event handler logic for allowing currency input
        private static void EnforceCurrencyOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Allow control keys (e.g., Backspace, Delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Allow digits (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Allow only one decimal point
                if (e.KeyChar == '.' && !textBox.Text.Contains('.'))
                {
                    return;
                }

                // Disallow any other characters
                e.Handled = true;
            }
        }

        // Truncate excess decimal places
        private static void TruncateExcessDecimals(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string text = textBox.Text;

                // If decimal point exists, truncate to two decimal places
                int decimalIndex = text.IndexOf('.');
                if (decimalIndex != -1 && text.Length > decimalIndex + 3)
                {
                    // Preserve cursor position
                    int cursorPosition = textBox.SelectionStart;

                    // Truncate to two decimal places
                    textBox.Text = text.Substring(0, decimalIndex + 3);

                    // Restore cursor position
                    textBox.SelectionStart = Math.Min(cursorPosition, textBox.Text.Length);
                }
            }
        }

        // Optional: Method to get the numeric value
        public static decimal GetNumericValue(TextBox textBox)
        {
            // Directly parse the text, which should now always be in a valid format
            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                return value;
            }

            return 0m;
        }
    }
}