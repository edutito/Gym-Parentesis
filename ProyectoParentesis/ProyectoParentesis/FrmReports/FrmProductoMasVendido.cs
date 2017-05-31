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
using Reports.ProductoMasVendido;

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmProductoMasVendido : Form
    {
        public FrmProductoMasVendido()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ProductoMasVendido rpt = new ProductoMasVendido();

            var dt = ProductoRepository.Instance.getProductosMasVendidos();
            DataSet ds = new DataSet();
            
            ds.Tables["ProductoVendido"].Load(dt);
            ds.AcceptChanges();

            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();
        }

        private void FrmProductoMasVendido_Load(object sender, EventArgs e)
        {

        }
    }
}
