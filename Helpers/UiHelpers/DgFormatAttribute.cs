using System.Windows.Forms;
using System;
using System.Drawing;

public static class DgFormatAttribute
{
    public static void AutoFormat(this DataGridView dataGridView)
    {
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            // DateTime formatting
            if (column.ValueType == typeof(DateTime))
            {
                column.DefaultCellStyle.Format = "MMM. dd, yy h:mm tt";
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // Decimal formatting
            else if (column.ValueType == typeof(decimal) || column.ValueType == typeof(double))
            {
                column.DefaultCellStyle.Format = "N2";
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // Integer formatting
            else if (column.ValueType == typeof(int) || column.ValueType == typeof(long))
            {
                column.DefaultCellStyle.Format = "N0";
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // string
            else if (column.ValueType == typeof(string))
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }

    public static void SetupLinkId(DataGridView dataGridView, int columnIndex)
    {
        string formattedIndex = columnIndex.ToString("D7");
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        style.ForeColor = Color.Blue;
        style.Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Underline);
        style.SelectionForeColor = Color.Blue;
        // Center the content
        style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView.Columns[columnIndex].DefaultCellStyle = style;

        dataGridView.Columns[columnIndex].DefaultCellStyle.Format = "000000000";

        // Event handlers
        DataGridViewCellEventHandler cellMouseEnterHandler = null;
        DataGridViewCellEventHandler cellMouseLeaveHandler = null;

        cellMouseEnterHandler = (sender, e) =>
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                dataGridView.Cursor = Cursors.Hand;
                dataGridView.Rows[e.RowIndex].Cells[columnIndex].Style.ForeColor = Color.FromArgb(0, 0, 192);
            }
        };

        cellMouseLeaveHandler = (sender, e) =>
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                dataGridView.Cursor = Cursors.Default;
                dataGridView.Rows[e.RowIndex].Cells[columnIndex].Style.ForeColor = Color.Blue;
            }
        };

        dataGridView.CellMouseEnter += cellMouseEnterHandler;
        dataGridView.CellMouseLeave += cellMouseLeaveHandler;

        // Cleanup event handlers when the dataGridView is disposed
        dataGridView.Disposed += (sender, e) =>
        {
            dataGridView.CellMouseEnter -= cellMouseEnterHandler;
            dataGridView.CellMouseLeave -= cellMouseLeaveHandler;
        };
    }

    public static void SetupLinkColumnsForString(DataGridView dataGridView, int columnIndex)
    {
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        style.ForeColor = Color.Blue;
        style.Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Underline);
        style.SelectionForeColor = Color.Blue;
        // Center the content
        style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridView.Columns[columnIndex].DefaultCellStyle = style;

        // Event handlers
        DataGridViewCellEventHandler cellMouseEnterHandler = null;
        DataGridViewCellEventHandler cellMouseLeaveHandler = null;

        cellMouseEnterHandler = (sender, e) =>
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                dataGridView.Cursor = Cursors.Hand;
                dataGridView.Rows[e.RowIndex].Cells[columnIndex].Style.ForeColor = Color.FromArgb(0, 0, 192);
            }
        };

        cellMouseLeaveHandler = (sender, e) =>
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                dataGridView.Cursor = Cursors.Default;
                dataGridView.Rows[e.RowIndex].Cells[columnIndex].Style.ForeColor = Color.Blue;
            }
        };

        dataGridView.CellMouseEnter += cellMouseEnterHandler;
        dataGridView.CellMouseLeave += cellMouseLeaveHandler;

        // Cleanup event handlers when the dataGridView is disposed
        dataGridView.Disposed += (sender, e) =>
        {
            dataGridView.CellMouseEnter -= cellMouseEnterHandler;
            dataGridView.CellMouseLeave -= cellMouseLeaveHandler;
        };
    }

    public static void BasicGridFormat(DataGridView dataGridView)
    {
        if (dataGridView != null)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
        }
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}