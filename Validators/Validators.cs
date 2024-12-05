using SalesPro.Helpers;
using System;
using System.Windows.Forms;

public static class Validators
{
    public static bool AmountValidator(string input, string name)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            MessageHandler.ShowWarning(name + " cannot be empty.");
            return false;
        }

        decimal amount;
        if (!decimal.TryParse(input, out amount) || amount <= 0)
        {
            MessageHandler.ShowWarning("Please enter a valid positive amount for : " + name);
            return false;
        }

        return true;
    }

    public static bool DateRangeValidator(DateTimePicker startPicker, DateTimePicker endPicker)
    {
        DateTime startDate = startPicker.Value;
        DateTime endDate = endPicker.Value;

        if (endDate < startDate)
        {
            MessageHandler.ShowWarning("End date cannot be greater than  start date.");
            return false;
        }

        return true;
    }

    public static bool EmptyStringValidator(string input, string name)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            MessageHandler.ShowWarning($"{name} cannot be empty.");
            return false;
        }

        return true;
    }
}
