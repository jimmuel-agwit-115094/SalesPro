using System.Windows.Forms;

public static class CurrencyTextboxHelper
{
    public static void ApplyNumericProperty(Control container)
    {
        foreach (Control control in container.Controls)
        {
            // Check if the control has the "IsNumeric" tag
            if (control.Tag != null && control.Tag.ToString() == "IsNumeric")
            {
                // Apply the behavior (e.g., hide the up/down buttons)
                if (control is NumericUpDown numericUpDown)
                {
                    HideNumericUpDownButton(numericUpDown);
                }
            }
        }
    }

    // Static method to hide the up/down buttons of a NumericUpDown control
    private static void HideNumericUpDownButton(NumericUpDown numericUpDown)
    {
        if (numericUpDown.Controls.Count > 0)
        {
            numericUpDown.Controls[0].Visible = false;  // Hide the up/down buttons
        }
    }
}
