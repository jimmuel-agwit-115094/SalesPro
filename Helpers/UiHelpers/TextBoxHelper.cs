using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class TextBoxHelper
    {
        public static void FormatDecimalTextbox(TextBox textBox)
        {


            // Allow only valid numeric input
            textBox.KeyPress += (sender, e) =>
            {
                char input = e.KeyChar;

                // Allow control keys (e.g., Backspace, Delete)
                if (char.IsControl(input))
                {
                    return;
                }

                // Allow digits and a single decimal point
                if (!char.IsDigit(input) && input != '.')
                {
                    e.Handled = true;
                    return;
                }

                var text = textBox.Text;
                int cursorPosition = textBox.SelectionStart;

                // Ensure only one decimal point
                if (input == '.' && text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                // Prevent misplaced decimal point
                if (input == '.' && cursorPosition == 0)
                {
                    e.Handled = true;
                }
            };

            // Format text when the textbox loses focus
            textBox.Leave += (sender, e) =>
            {
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    textBox.Text = string.Format("{0:N2}", value); // Format as a decimal with two places
                }
                else
                {
                    textBox.Text = "0.00"; // Default value if input is invalid
                }
            };
        }

        public static void FormatPercentageTextbox(TextBox textBox)
        {
            // Set default value to 0
            textBox.Text = "0";

            // Attach event handler to handle input validation
            textBox.KeyPress += (sender, e) => {
                // Allow only numbers, backspace, and the decimal point
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            };

            // Attach event handler to handle text changes
            textBox.TextChanged += (sender, e) => {
                // Parse and limit the value between 0 and 100
                if (int.TryParse(textBox.Text, out int value))
                {
                    if (value < 0)
                        textBox.Text = "0";
                    else if (value > 100)
                        textBox.Text = "100";
                }
                else
                {
                    textBox.Text = "0"; // Set to 0 if invalid input
                }
            };

            // Focus Lost event to ensure value is in the valid range when the user moves away from the TextBox
            textBox.Leave += (sender, e) => {
                if (int.TryParse(textBox.Text, out int value))
                {
                    if (value < 0)
                        textBox.Text = "0";
                    else if (value > 100)
                        textBox.Text = "100";
                }
            };
        }


    }
}
