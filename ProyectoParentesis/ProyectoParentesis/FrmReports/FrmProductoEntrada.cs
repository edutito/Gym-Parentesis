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
using Reports.ProductoEntrada;

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmProductoEntrada : Form
    {
        public FrmProductoEntrada()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ProductoEntrada rpt = new ProductoEntrada();

            var dt = ProductoRepository.Instance.getProductosMasEntrada();
            DataSet ds = new DataSet();

            ds.Tables["ProductoEntrada"].Load(dt);
            ds.AcceptChanges();

            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();
        }

        private void FrmProductoEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
