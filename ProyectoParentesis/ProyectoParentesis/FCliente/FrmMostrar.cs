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

namespace ProyectoParentesis.FCliente
{
    public partial class FrmMostrar : Form
    {
        private const int idColummn = 7;
        private int clienteId;

        public FrmMostrar()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
               ClienteRepository.Instance.getData()
                );
        }

        private void ColocarColumnas()
        {

            this.DGMostrarClientes.Columns.Add("Nombre", "Nombre");
            this.DGMostrarClientes.Columns.Add("Apellido", "Apellidos");
            this.DGMostrarClientes.Columns.Add("Telefono", "Teléfono");
            this.DGMostrarClientes.Columns.Add("Direccion", "Direccíon");
            this.DGMostrarClientes.Columns.Add("Estado", "Estado");
            this.DGMostrarClientes.Columns.Add("Fecha_Ingreso", "Fecha de Ingreso");
            this.DGMostrarClientes.Columns.Add("DNI", "Identificacíon");
            this.DGMostrarClientes.Columns.Add("Id", "Id");

            this.DGMostrarClientes.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Cliente> Clientes)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarClientes.Rows.Clear();

            foreach (Cliente cliente in Clientes)
            {
                DataGridViewRow row = new DataGridViewRow();
                
                this.DGMostrarClientes.Rows.Add(
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


            int colCount = this.DGMostrarClientes.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarClientes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnIngresarNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }

        private void DGMostrarClientes_MouseClick(object sender, MouseEventArgs e)
        {


        }




        private void DGMostrarClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1) {

                if (DGMostrarClientes.SelectedRows.Count != 0 && this.DGMostrarClientes["Id", e.RowIndex].Value != null)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Int32.Parse(this.DGMostrarClientes["Id", e.RowIndex].Value.ToString());
                    cliente = ClienteRepository.Instance.getData( cliente ).First();
                    FrmInsertar frm = new FrmInsertar(cliente, this);
                    frm.Show();
                }
            }

        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            this.buscar();

        }

        public void buscar()
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.DNI = txtIdentificacion.Text;

            this.LlenarData(
               ClienteRepository.Instance.getData(cliente, true)
                );
        }

        private void DGMostrarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
