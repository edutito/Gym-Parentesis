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

namespace ProyectoParentesis.FRegistroPago
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            this.populate();
            this.ColocarColumnas();
            this.LlenarData(
               PagoRepository.Instance.getData()
                );
        }

        private void ColocarColumnas()
        {

            this.DGMostrarClientes.Columns.Add("cliente", "Cliente");
            this.DGMostrarClientes.Columns.Add("monto", "Monto");
            this.DGMostrarClientes.Columns.Add("Fecha_Inicio", "Fecha Inicio");
            this.DGMostrarClientes.Columns.Add("Fecha_Final", "Fecha Final");            
            this.DGMostrarClientes.Columns.Add("Id", "Id");

            this.DGMostrarClientes.Columns["Id"].Visible = false;

        }

        private void LlenarData(List<Pago> pagos)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarClientes.Rows.Clear();

            foreach (Pago pago in pagos)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarClientes.Rows.Add(
                    pago.getCliente().getFullName(),
                    pago.Monto,
                    pago.Fecha_Inicio,
                    pago.Fecha_Final,
                    pago.Id
                    );
            }

            this.AcomodarColumnas();
        }

        private void AcomodarColumnas()
        {
            int colCount = this.DGMostrarClientes.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarClientes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        // EDITAR no se hizo ya instrucciones de la proferora ya que se maneja dinero
        //private void DGMostrarClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //    if (e.Button == MouseButtons.Left && e.RowIndex > -1)
        //    {

        //        if (DGMostrarClientes.SelectedRows.Count != 0 && this.DGMostrarClientes["Id", e.RowIndex].Value != null)
        //        {
        //            Pago pago = new Pago();
        //            pago.Id = Int32.Parse(this.DGMostrarClientes["Id", e.RowIndex].Value.ToString());
        //            pago = PagoRepository.Instance.getData(pago).First();
        //            FrmInsertar frm = new FrmInsertar(pago, this);
        //            frm.Show();
        //        }
        //    }

        //}

        public void buscar()
        {
            Pago pago = new Pago();

            if ( this.cmbCliente.SelectedItem != null) {
                pago.Cliente_id = ((Cliente)this.cmbCliente.SelectedItem).Id;
            }
            
            this.LlenarData(PagoRepository.Instance.getData(pago, false));
        }

        private void populate()
        {
            this.cmbCliente.Items.Clear();
            foreach (Cliente cliente in ClienteRepository.Instance.getClientesActivos())
            {
                this.cmbCliente.Items.Add(cliente);
            }        
        }
    }
}
