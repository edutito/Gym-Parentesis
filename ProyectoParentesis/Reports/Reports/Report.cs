using System;
using System.Windows.Forms;

namespace Reports.Reports
{
    public class Report
    {
        public static void report(DataGridView transcationTableDataGridView)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet) workbook.Worksheets.get_Item(1);
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";
                String col;
                try
                {
                    for (int i = 0; i < transcationTableDataGridView.Columns.Count; i++)
                    {
                        col = transcationTableDataGridView.Columns[i].HeaderText;
                        if (col != "Id")
                            worksheet.Cells[1, i + 1] = col;
                    }
                    for (int i = 0; i < transcationTableDataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < transcationTableDataGridView.Columns.Count; j++)
                        {
                            col = transcationTableDataGridView.Columns[j].HeaderText;
                            if (col == "Id")
                                continue;
                            if (transcationTableDataGridView.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = transcationTableDataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    //app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
