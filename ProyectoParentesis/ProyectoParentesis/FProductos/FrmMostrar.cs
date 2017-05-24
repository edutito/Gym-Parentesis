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


namespace ProyectoParentesis.FProductos
{
    public partial class FrmMostrar : Form
    {
        private const int idColummn = 6;
        private int clienteId;
        public FrmMostrar()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
         ProductoRepository.Instance.getData()
                );
        }

        private void ColocarColumnas()
        {


            this.DGMostrarProductos.Columns.Add("Nombre", "Nombre del Producto");
            this.DGMostrarProductos.Columns.Add("Codigo", "Código del Producto");
            this.DGMostrarProductos.Columns.Add("Cantidad", "Cantidad");
            this.DGMostrarProductos.Columns.Add("Precio", "Precio");
            this.DGMostrarProductos.Columns.Add("Estado", "Estado del Producto");
            this.DGMostrarProductos.Columns.Add("Id", "Id");

            this.DGMostrarProductos.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Producto> productos)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarProductos.Rows.Clear();

            foreach (Producto producto in productos)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarProductos.Rows.Add(

                producto.Nombre,
                producto.Codigo,
                producto.Cantidad,
                producto.Precio,
                producto.Estado

                
                );
            }

            this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            int colCount = this.DGMostrarProductos.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarProductos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

                public void buscar()
        {
            Producto producto = new Producto();

            producto.Nombre = txtNombre.Text;
          


            this.LlenarData(

               ProductoRepository.Instance.getData(producto, true)
                );
        }


        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGMostrarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
