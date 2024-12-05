using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class DgExtenstions
    {
        public static void FormatDataGrid(DataGridView dgTrans, bool setupId)
        {
            DgFormatHelper.BasicGridFormat(dgTrans);
            dgTrans.AutoFormat();
            if (setupId)
                DgFormatHelper.SetupLinkId(dgTrans, 0);
        }
    }
}
