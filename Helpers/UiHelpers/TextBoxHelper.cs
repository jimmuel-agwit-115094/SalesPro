﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class TextBoxHelper
    {
        public static void FormatDecimalTextbox(TextBox textBox)
        {
            textBox.Text = "0";
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

        // format integer textbox   
        public static void FormatIntegerTextbox(TextBox textBox)
        {
            textBox.Text = "0";
            textBox.KeyPress += (sender, e) =>
            {
                char input = e.KeyChar;

                // Allow control keys (e.g., Backspace, Delete)
                if (char.IsControl(input))
                {
                    return;
                }

                // Allow digits only
                if (!char.IsDigit(input))
                {
                    e.Handled = true;
                    return;
                }
            };

            // Format text when the textbox loses focus
            textBox.Leave += (sender, e) =>
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    textBox.Text = value.ToString();
                }
                else
                {
                    textBox.Text = "0"; // Default value if input is invalid
                }
            };
        }

        public static void FormatBarcode(TextBox textBox)
        {
            textBox.Text = "";
            textBox.KeyPress += (sender, e) =>
            {
                char input = e.KeyChar;

                // Allow control keys (e.g., Backspace, Delete)
                if (char.IsControl(input))
                {
                    return;
                }

                // Allow digits (0-9) and the '/' symbol
                if (!char.IsDigit(input) && input != '/')
                {
                    e.Handled = true;
                    return;
                }
            };

            // Format text when the textbox loses focus
            textBox.Leave += (sender, e) =>
            {
                // Check if the text contains only allowed characters
                if (!string.IsNullOrEmpty(textBox.Text) &&
                    System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^[0-9/]+$"))
                {
                    textBox.Text = textBox.Text; // Retain valid input
                }
                else
                {
                    textBox.Text = ""; // Default value if input is invalid
                }
            };
        }


        // string only
        public static void FormatStringTextbox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                char input = e.KeyChar;

                // Allow control keys (e.g., Backspace, Delete)
                if (char.IsControl(input))
                {
                    return;
                }

                // Allow letters only
                if (!char.IsLetter(input))
                {
                    e.Handled = true;
                    return;
                }
            };
        }

        public static void HandleEmptyDecimalTextbox(TextBox textBox)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
                textBox.SelectAll();
            }
        }
    }
}
