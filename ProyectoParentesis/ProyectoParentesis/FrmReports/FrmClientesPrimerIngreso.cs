using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Model;

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmClientesPrimerIngreso : Form
    {
        public FrmClientesPrimerIngreso()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
               ClienteRepository.Instance.getClientesPrimerIngreso()
                );

        }

        private void FrmClientesPrimerIngreso_Load(object sender, EventArgs e)
        {
            
        }

        private void ColocarColumnas()
        {

            this.DGClientesPrimerIngreso.Columns.Add("Nombre", "Nombre");
            this.DGClientesPrimerIngreso.Columns.Add("Apellido", "Apellidos");
            this.DGClientesPrimerIngreso.Columns.Add("Telefono", "Teléfono");
            this.DGClientesPrimerIngreso.Columns.Add("Direccion", "Direccíon");
            this.DGClientesPrimerIngreso.Columns.Add("Estado", "Estado");
            this.DGClientesPrimerIngreso.Columns.Add("Fecha_Ingreso", "Fecha de Ingreso");
            this.DGClientesPrimerIngreso.Columns.Add("DNI", "Identificacíon");
            this.DGClientesPrimerIngreso.Columns.Add("Id", "Id");

            this.DGClientesPrimerIngreso.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Cliente> Clientes)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGClientesPrimerIngreso.Rows.Clear();

            foreach (Cliente cliente in Clientes)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGClientesPrimerIngreso.Rows.Add(
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Estado,
                    cliente.Fecha_Ingreso,
                    cliente.DNI,
                    cliente.Id
                    );
            }

            this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            int colCount = this.DGClientesPrimerIngreso.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGClientesPrimerIngreso.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnGenerarClientesPrimerIngreso_Click(object sender, EventArgs e)
        {
            this.LlenarData(
               ClienteRepository.Instance.getClientesPrimerIngreso()
                );
        }

        private void copyAllToClipboard()
        {
            DGClientesPrimerIngreso.SelectAll();
            DataObject dataObj = DGClientesPrimerIngreso.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

        private void exportToExcel(DataGridView transcationTableDataGridView)
        {

            //copyAllToClipboard();
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);       



            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < transcationTableDataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = transcationTableDataGridView.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < transcationTableDataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < transcationTableDataGridView.Columns.Count; j++)
                        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.exportToExcel(this.DGClientesPrimerIngreso);
        }






    }
  }


