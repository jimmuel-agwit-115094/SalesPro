using SalesPro.Enums;
using System.Linq;
using System;
using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class StatusIconHelper
    {
        public static void ShowStatus(StatusType status, Panel statusPanel, string statusMessage)
        {
            // Assuming the panel contains the PictureBox and Label
            PictureBox statusPictureBox = statusPanel.Controls.OfType<PictureBox>().FirstOrDefault();
            Label statusLabel = statusPanel.Controls.OfType<Label>().FirstOrDefault();

            if (statusPictureBox == null || statusLabel == null)
            {
                throw new InvalidOperationException("The panel must contain a PictureBox and Label.");
            }

            // Make the PictureBox and Label visible
            statusLabel.Visible = true;
            statusPictureBox.Visible = true;

            // Set the label's text to the status message
            statusLabel.Text = statusMessage;

            // Change the PictureBox's image based on the status
            switch (status)
            {
                case StatusType.Good:
                    statusPictureBox.Image = Properties.Resources.good;  // Green icon for "Good"
                    break;
                case StatusType.Bad:
                    statusPictureBox.Image = Properties.Resources.bad;  // Red icon for "Bad"
                    break;
                case StatusType.Warning:
                    statusPictureBox.Image = Properties.Resources.warning;  // Yellow icon for "Warning"
                    break;
            }
        }
    }
}
