using SalesPro.Enums;
using System.Linq;
using System;
using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class StatusIconHelper
    {
        public static void ShowStatus(IconStatusType status, Panel statusPanel, string statusMessage)
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
                case IconStatusType.Good:
                    statusPictureBox.Image = Properties.Resources.good;  // Green icon for "Good"
                    break;
                case IconStatusType.Bad:
                    statusPictureBox.Image = Properties.Resources.bad;  // Red icon for "Bad"
                    break;
                case IconStatusType.Warning:
                    statusPictureBox.Image = Properties.Resources.warning;  // Yellow icon for "Warning"
                    break;
                case IconStatusType.Exclamation:
                    statusPictureBox.Image = Properties.Resources.bad;  // Yellow icon for "Warning"
                    break;
                case IconStatusType.Created:
                    statusPictureBox.Image = Properties.Resources.created;  // Blue icon for "Created"
                    break;
                case IconStatusType.Sent:
                    statusPictureBox.Image = Properties.Resources.sent;  // Blue icon for "Sent"
                    break;
                case IconStatusType.Completed:
                    statusPictureBox.Image = Properties.Resources.good;  // Blue icon for "Completed"
                    break;
                case IconStatusType.Cancelled:
                    statusPictureBox.Image = Properties.Resources.canceled;  // Blue icon for "Cancelled"
                    break;
            }
        }
    }
}
