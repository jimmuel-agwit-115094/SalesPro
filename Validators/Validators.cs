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

    // int validator
    public static bool IntValidator(string input, string name)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            MessageHandler.ShowWarning($"{name} cannot be empty.");
            return false;
        }

        int number;
        if (!int.TryParse(input, out number) || number <= 0)
        {
            MessageHandler.ShowWarning("Please enter a valid positive number for : " + name);
            return false;
        }

        return true;
    }

    // Amount 1 shhould not be greater than amount 2
    public static bool AmountComparisonValidator(string amount1, string amount2, string name1, string name2)
    {
        decimal amount1Value;
        decimal amount2Value;

        if (!decimal.TryParse(amount1, out amount1Value) || amount1Value <= 0)
        {
            MessageHandler.ShowWarning("Please enter a valid positive amount for : " + name1);
            return false;
        }

        if (!decimal.TryParse(amount2, out amount2Value) || amount2Value <= 0)
        {
            MessageHandler.ShowWarning("Please enter a valid positive amount for : " + name2);
            return false;
        }

        if (amount1Value > amount2Value)
        {
            MessageHandler.ShowWarning($"{name1} should not be greater than {name2}");
            return false;
        }

        return true;
    }

}
