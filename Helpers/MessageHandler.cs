using System.Windows.Forms;

namespace SalesPro.Helpers
{
    public class MessageHandler
    {
        public static void SuccessfullyAdded()
        {
            MessageBox.Show("Record added successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SuccessfullyUpdated()
        {
            MessageBox.Show("Record updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SuccessfullyDeleted()
        {
            MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MissingDataError(string missingfield)
        {
            MessageBox.Show("Please fill in all required fields for: " + missingfield, "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowQuestion(string question, string obj)
        {
            DialogResult result = MessageBox.Show($"{ question } {obj}?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void ShowConcurrencyWarning()
        {
            const string message = "This action could not be completed because another user has modified the data. Please refresh and try again.";
            MessageBox.Show(message, "Concurrency Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
