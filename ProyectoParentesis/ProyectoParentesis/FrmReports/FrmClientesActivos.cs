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
using Reports.ClienteMoroso;
using Reports.ClienteActivos;

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmClientesActivos : Form
    {
        public FrmClientesActivos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ClienteActivos rpt = new ClienteActivos();

            var dt = ClienteRepository.Instance.getClientesActivosDataReader();
            DataSet ds = new DataSet();
            
            ds.Tables["ClienteActivos"].Load(dt);
            ds.AcceptChanges();

            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();

        }

        private void FrmClientesActivos_Load(object sender, EventArgs e)
        {

        }
    }
}
