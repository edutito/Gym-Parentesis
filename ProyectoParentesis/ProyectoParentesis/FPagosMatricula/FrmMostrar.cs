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


namespace ProyectoParentesis.FPagosMatricula
{
    public partial class FrmMostrar : Form
    {

        private const int idColummn = 4;
        private int clienteId;
        public FrmMostrar()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
         Pago_MatriculaRepository.Instance.getData()
                );
        }

        private void ColocarColumnas()
        {

            
            this.DGMostrarClientes.Columns.Add("Nombre_Cliente", "Nombre del Cliente");
            this.DGMostrarClientes.Columns.Add("Apellido", "Apellido");
            this.DGMostrarClientes.Columns.Add("Monto", "Monto");
            this.DGMostrarClientes.Columns.Add("Id", "Id");

            this.DGMostrarClientes.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Pago_Matricula> pago_matriculas)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarClientes.Rows.Clear();

            foreach (Pago_Matricula pago_matricula in pago_matriculas)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarClientes.Rows.Add(

                   pago_matricula.Nombre_Cliente,

                    pago_matricula.Apellido,
                    pago_matricula.Monto,

                    pago_matricula.Id
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

        private void btnIngresarPagoMatricula_Click(object sender, EventArgs e)
        {
        FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }


        public void buscar()
        {
            Pago_Matricula pago_matricula = new Pago_Matricula();

            pago_matricula.Nombre_Cliente = txtNombre.Text;
            pago_matricula.Apellido = txtApellido.Text;


            this.LlenarData(
               Pago_MatriculaRepository.Instance.getData(pago_matricula, true)
                );
        }

        private void btnMostrarPagosMatriculas_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void DGMostrarClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                if (DGMostrarClientes.SelectedRows.Count != 0 && this.DGMostrarClientes["Id", e.RowIndex].Value != null)
                {
                    Pago_Matricula pago_matricula = new Pago_Matricula();
                    pago_matricula.Id = Int32.Parse(this.DGMostrarClientes["Id", e.RowIndex].Value.ToString());
                    pago_matricula = Pago_MatriculaRepository.Instance.getData(pago_matricula).First();
                    FrmInsertar frm = new FrmInsertar(pago_matricula, this);
                    frm.Show();
                }
            }

        }




    }
}
