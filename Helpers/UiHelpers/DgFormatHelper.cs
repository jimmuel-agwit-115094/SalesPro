using System.Windows.Forms;
using System;
using System.Drawing;
using SalesPro.Helpers;
using System.Linq;
using System.Text.RegularExpressions;

public static class DgFormatHelper
{
    public static void AutoFormat(this DataGridView dataGridView)
    {
        if (dataGridView == null || dataGridView.Rows.Count == 0)
            return; // Exit if no rows are present

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
            // String formatting
            else if (column.ValueType == typeof(string))
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
    }


    public static void SetupLinkId(DataGridView dataGridView, int columnIndex)
    {
        if (dataGridView == null || dataGridView.Rows.Count == 0)
            return; // Exit if no rows are present

        DataGridViewCellStyle style = new DataGridViewCellStyle
        {
            ForeColor = Color.Blue,
            Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Underline),
            SelectionForeColor = Color.Blue,
            Alignment = DataGridViewContentAlignment.MiddleCenter
        };
        dataGridView.Columns[columnIndex].DefaultCellStyle = style;

        dataGridView.Columns[columnIndex].DefaultCellStyle.Format = "000000000";

        DataGridViewColumn primaryKeyColumn = dataGridView.Columns[columnIndex];
        primaryKeyColumn.DisplayIndex = 0;

        // Event handlers
        DataGridViewCellEventHandler cellMouseEnterHandler = (sender, e) =>
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                dataGridView.Cursor = Cursors.Hand;
                dataGridView.Rows[e.RowIndex].Cells[columnIndex].Style.ForeColor = Color.FromArgb(0, 0, 192);
            }
        };

        DataGridViewCellEventHandler cellMouseLeaveHandler = (sender, e) =>
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
        // Null check
        if (dataGridView != null)
        {
            // Prevent color change of column headers when selected
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
        }

        SetDataGridStyles(dataGridView);
        // Disable sorting for all columns
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Suppress F3 key press
        dataGridView.KeyDown += (s, ev) =>
        {
            if (ev.KeyCode == Keys.F3)
            {
                ev.Handled = true;
            }
        };
        // Disable column header double-click
        dataGridView.MouseDoubleClick += (s, ev) =>
        {
            // Check if the double-click occurred on the column header
            var hitTestInfo = dataGridView.HitTest(ev.X, ev.Y);
            if (hitTestInfo.Type == DataGridViewHitTestType.ColumnHeader)
            {
                // Suppress the double-click event
                ev = null; // No action will be taken
            }
        };
    }

    public static void ShowOnlyField(DataGridView dataGridView, params string[] fieldsToShow)
    {
        //if (dataGridView == null || dataGridView.Rows.Count == 0)
        //    return; // Exit if no rows are present

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
            DataGridViewColumn columnToShow = dataGridView.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(col =>
                    col.DataPropertyName.Equals(field, StringComparison.OrdinalIgnoreCase) ||
                    col.Name.Equals(field, StringComparison.OrdinalIgnoreCase));

            if (columnToShow != null)
            {
                columnToShow.Visible = true;
                columnToShow.HeaderText = AddSpacesToCamelCase(field);
            }
            else
            {
                MessageHandler.ShowError($"Column {field} not found in the DataGridView");
            }
        }
    }


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

    public static void SearchOnGrid(DataGridView dataGridView, TextBox searchTextBox)
    {
        try
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridView.CurrentCell = null;
                bool shouldRowBeVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        shouldRowBeVisible = true;
                        break;
                    }
                }

                row.Visible = shouldRowBeVisible;
            }
        }
        catch (Exception ex)
        {
            MessageHandler.ShowError("Error on search on datagrid: " + ex.Message);
        }
    }

    public static int GetSelectedId(DataGridView dgv, DataGridViewCellEventArgs e, string columnName)
    {
        try
        {
            if (e.ColumnIndex == dgv.Columns[columnName].Index && e.RowIndex >= 0)
            {
                object cellValue = dgv.Rows[e.RowIndex].Cells[columnName].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedId))
                {
                    if (selectedId != 0)
                    {
                        return selectedId;
                    }
                }
            }
            return 0;
        }
        catch (Exception ex)
        {
            MessageHandler.ShowError($"Error getting selected id {ex.Message}");
            throw;
        }

    }

    public static void SetDataGridStyles(DataGridView dataGrid)
    {
        // Apply styles for the column headers
        foreach (DataGridViewColumn column in dataGrid.Columns)
        {
            column.HeaderCell.Style.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
        }

        // Apply styles for the cell content
        dataGrid.DefaultCellStyle.Font = new Font("Consolas", 9.75f);
    }

    public static int GetSelectedRowId(DataGridView dataGridView, string columnToConvertAsId)
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            var cellValue = selectedRow.Cells[columnToConvertAsId].Value;
            if (cellValue != null)
            {
                return Convert.ToInt32(cellValue);
            }
        }
        return 0;
    }

    public static string GetSelectedRowString(DataGridView dataGridView, string columnToGet)
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            var cellValue = selectedRow.Cells[columnToGet].Value;
            if (cellValue != null)
            {
                return cellValue.ToString();
            }
        }
        return string.Empty;
    }


    public static void HandleEnterKey(KeyEventArgs e, DataGridView dataGridView)
    {
        if (e.KeyCode == Keys.Enter && dataGridView.Rows.Count > 0)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    public static void DisableColumnClick(DataGridView dataGridView, string columnName)
    {
        // Validate input
        if (dataGridView == null || string.IsNullOrWhiteSpace(columnName))
        {
            throw new ArgumentException("Invalid column name or DataGridView");
        }

        // Find the column by name
        DataGridViewColumn column = dataGridView.Columns[columnName];
        if (column == null)
        {
            throw new ArgumentException($"Column '{columnName}' not found in the DataGridView");
        }

        // Disable column header clicking
        column.SortMode = DataGridViewColumnSortMode.NotSortable;

        // Make the column read-only
        column.ReadOnly = true;

        // Attach event handler to prevent cell interactions and change cursor
        dataGridView.CellMouseEnter += (sender, e) =>
        {
            // Check if the mouse is over the specified column
            if (e.ColumnIndex == column.Index)
            {
                // Change cursor to not allowed
                dataGridView.Cursor = Cursors.No;
            }
        };

        // Reset cursor when mouse leaves the column
        dataGridView.CellMouseLeave += (sender, e) =>
        {
            // Reset cursor to default
            dataGridView.Cursor = Cursors.Default;
        };

        // Attach event handler to prevent cell interactions
        dataGridView.CellClick += (sender, e) =>
        {
            // Check if the clicked cell is in the specified column
            if (e.ColumnIndex == column.Index)
            {
                // Prevent further processing by setting column interactions to null
                if (sender is DataGridView dgv)
                {
                    dgv.CurrentCell = null;
                }
            }
        };
    }
}