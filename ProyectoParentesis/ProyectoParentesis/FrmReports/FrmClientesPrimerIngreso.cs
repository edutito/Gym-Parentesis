using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Model;
using Reports.Reports;
using Reports.PrimerIngreso;
using Reports.Connection;

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmClientesPrimerIngreso : Form
    {
        public FrmClientesPrimerIngreso()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            PrimerIngreso rpt = new PrimerIngreso();

            var dt = ClienteRepository.Instance.getClientesPrimerIngresoDT();
            DataSet ds = new DataSet();
            ds.Tables[0].Merge(dt);
            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();

            //this.ColocarColumnas();
            //this.LlenarData(
            //   ClienteRepository.Instance.getClientesPrimerIngreso()
            //    );

        }

        private void FrmClientesPrimerIngreso_Load(object sender, EventArgs e)
        {
            
        }

        private void ColocarColumnas()
        {

            //this.DGClientesPrimerIngreso.Columns.Add("Nombre", "Nombre");
            //this.DGClientesPrimerIngreso.Columns.Add("Apellido", "Apellidos");
            //this.DGClientesPrimerIngreso.Columns.Add("Telefono", "Teléfono");
            //this.DGClientesPrimerIngreso.Columns.Add("Direccion", "Direccíon");
            //this.DGClientesPrimerIngreso.Columns.Add("Estado", "Estado");
            //this.DGClientesPrimerIngreso.Columns.Add("Fecha_Ingreso", "Fecha de Ingreso");
            //this.DGClientesPrimerIngreso.Columns.Add("DNI", "Identificacíon");
            //this.DGClientesPrimerIngreso.Columns.Add("Id", "Id");

            //this.DGClientesPrimerIngreso.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Cliente> Clientes)
        {

            ////this.DGMostrarClientes.DataSource = Clientes;w
            //this.DGClientesPrimerIngreso.Rows.Clear();

            //foreach (Cliente cliente in Clientes)
            //{
            //    DataGridViewRow row = new DataGridViewRow();

            //    this.DGClientesPrimerIngreso.Rows.Add(
            //        cliente.Nombre,
            //        cliente.Apellido,
            //        cliente.Telefono,
            //        cliente.Direccion,
            //        cliente.Estado,
            //        cliente.Fecha_Ingreso,
            //        cliente.DNI,
            //        cliente.Id
            //        );
            //}

            //this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            //int colCount = this.DGClientesPrimerIngreso.Columns.Count;
            //colCount = colCount - 1; // =5
            //for (int i = 0; i < colCount; i++)
            //{
            //    this.DGClientesPrimerIngreso.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}

        }

        private void btnGenerarClientesPrimerIngreso_Click(object sender, EventArgs e)
        {
            this.LlenarData(
               ClienteRepository.Instance.getClientesPrimerIngreso()
                );
        }

        private void copyAllToClipboard()
        {
            //DGClientesPrimerIngreso.SelectAll();
            //DataObject dataObj = DGClientesPrimerIngreso.GetClipboardContent();
            //if (dataObj != null)
            //{
            //    Clipboard.SetDataObject(dataObj);
            //}
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            //Report.report(this.DGClientesPrimerIngreso);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
  }


