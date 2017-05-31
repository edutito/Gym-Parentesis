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

namespace ProyectoParentesis.FrmReports
{
    public partial class FrmClienteMoroso : Form
    {
        public FrmClienteMoroso()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ClienteMoroso rpt = new ClienteMoroso();

            var dt = ClienteRepository.Instance.getClientesMorosos();
            DataSet ds = new DataSet();
            //dt.TableName = "ClienteMoroso";
            //ds.Tables[0].Merge(dt.Copy());
            ds.Tables["ClienteMoroso"].Load(dt);
            ds.AcceptChanges();
            
            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();
        }

        private void FrmClienteMoroso_Load(object sender, EventArgs e)
        {

        }
    }
}
