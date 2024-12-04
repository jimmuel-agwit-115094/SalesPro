using SalesPro.Helpers;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static class DgExtenstions
{
    public static void ShowOnlyField(DataGridView dataGridView, params string[] fieldsToShow)
    {
        // Validate inputs
        if (dataGridView == null)
            throw new ArgumentNullException(nameof(dataGridView));
        if (fieldsToShow == null || fieldsToShow.Length == 0)
            throw new ArgumentException("At least one field must be specified", nameof(fieldsToShow));

        // Hide all columns initially
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            column.Visible = false;
        }

        // Show only specified columns
        foreach (string field in fieldsToShow)
        {
            // Try to find the column by name (case-insensitive)
            DataGridViewColumn columnToShow = dataGridView.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(col =>
                    col.DataPropertyName.Equals(field, StringComparison.OrdinalIgnoreCase) ||
                    col.Name.Equals(field, StringComparison.OrdinalIgnoreCase));

            if (columnToShow != null)
            {
                columnToShow.Visible = true;

                // Add space before capital letters for display
                columnToShow.HeaderText = AddSpacesToCamelCase(field);
            }
            else
            {
                // Optional: Log or throw an exception if the field is not found
                MessageHandler.ShowError($"Column {field} not found in the DataGridView");
            }
        }
    }

    /// <summary>
    /// Adds spaces before capital letters in a camel case string
    /// </summary>
    /// <param name="input">The input string in camel case</param>
    /// <returns>A string with spaces added before capital letters</returns>
    private static string AddSpacesToCamelCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // Use Regex to insert spaces before capital letters
        // The regex looks for a lowercase letter followed by an uppercase letter
        // and inserts a space between them
        return Regex.Replace(input,
            "(?<!^)(?=[A-Z])",
            " ",
            RegexOptions.Compiled);
    }
}