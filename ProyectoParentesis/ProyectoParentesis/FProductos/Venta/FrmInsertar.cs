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



namespace ProyectoParentesis.FProductos.Venta
{
    public partial class FrmInsertar : Form
    {

        private int? posAlter;
        public FrmInsertar()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.populate();
        }


        private void populate()
        {
            this.cmbProductos.Items.Clear();
            foreach (Producto producto in ProductoRepository.Instance.getData())
            {
                this.cmbProductos.Items.Add(producto);
            }

        }

        private void ColocarColumnas()
        {

            this.DGVVentaProductos.Columns.Add("Nombre_Producto", "Nombre del Producto");
            this.DGVVentaProductos.Columns.Add("Cantidad", "Cantidad");
            this.DGVVentaProductos.Columns.Add("Precio_Articulo", "Precio por Articulo");
            this.DGVVentaProductos.Columns.Add("Precio_Cantidad", "Precio por Cantidad");
            this.DGVVentaProductos.Columns.Add("Id", "Id");

            this.DGVVentaProductos.Columns["Id"].Visible = false;


        }

        private void AcomodarColumnas()
        {


            int colCount = this.DGVVentaProductos.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGVVentaProductos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void AgregarProduco()
        {


            if (this.cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Producto.");

                return;
            }
            String cantidadtxt = this.txtCantidad.Text;
            if (cantidadtxt == "")
            {
                MessageBox.Show("Debes colocar una cantidad para un Producto.");

                return;
            }
            else if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(cantidadtxt, "Campo Cantidad  solo acepta Numeros"))
            {
                return;
            }

            Producto producto = this.cmbProductos.SelectedItem as Producto;
            if (this.ValidarProductoAgregado(producto))
            {
                MessageBox.Show("Producto ya agregado, se tiene que modificar el producto para cambiar la cantidad.");
                return;
            }
            int cantidad = Int32.Parse(cantidadtxt);

            DataGridViewRow row = new DataGridViewRow();

            this.DGVVentaProductos.Rows.Add(
                producto.Nombre,
                cantidad,
                producto.Precio,
                (producto.Precio * cantidad),
                producto.Id
            );
            this.AcomodarColumnas();
            this.limpiarCantidad();


        }

        private bool ValidarProductoAgregado(Producto producto)
        {
            foreach (DataGridViewRow fila in this.DGVVentaProductos.Rows)
            {
                int x = Int32.Parse(fila.Cells["Id"].Value.ToString());
                if (x == producto.Id)
                {
                    return true;
                }
            }

            return false;

        }

        private void Modificar(Producto prod, int pos, int cantidad)
        {
            this.DGVVentaProductos.Rows[pos].Cells["Nombre_Producto"].Value = prod.Nombre;
            this.DGVVentaProductos.Rows[pos].Cells["Cantidad"].Value = cantidad;
            this.DGVVentaProductos.Rows[pos].Cells["Precio_Articulo"].Value = prod.Precio;
            this.DGVVentaProductos.Rows[pos].Cells["Precio_Cantidad"].Value = prod.Precio*cantidad;
        }

 


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            this.AgregarProduco();
        }



        private void limpiardatos()
        {
            this.populate();
            this.txtNombreCliente.Text = "";
        }


        private void Salvar()
        {

        }

        private void CantidadTotalPrecio()
        {


        }


        private void CalculoMontoTotalVendido()
        {


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.posAlter == null) { 
                MessageBox.Show("Selecciona la columna de un producto");
                return; 
            };
            Producto producto = this.cmbProductos.SelectedItem as Producto;
            this.Modificar(producto, (int)this.posAlter, Int32.Parse(this.txtCantidad.Text));
            this.posAlter = null;
            MessageBox.Show("Producto modificado");

            this.limpiarCantidad();
        }

        private bool seleccionoColumna()
        {
            return this.DGVVentaProductos.SelectedRows.Count < 0;
        }

        private DataGridViewRow getColumna()
        {
            this.posAlter = this.DGVVentaProductos.CurrentCell.RowIndex;
            foreach (DataGridViewRow fila in this.DGVVentaProductos.SelectedRows) return fila;

            return null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (this.posAlter == null)
            {
                MessageBox.Show(" Debe seleccionar una columna primero");

                return;
            };
            this.DGVVentaProductos.Rows.RemoveAt((int)this.posAlter);
            this.posAlter = null;
            this.limpiarCantidad();

            MessageBox.Show("Producto ya fue Eliminado");

        }

        private void DGVVentaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVVentaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                DataGridViewRow columa = this.getColumna();
                if (columa == null)
                {
                    return;
                };
                this.txtCantidad.Text = columa.Cells["Cantidad"].Value.ToString();
                Producto producto = ProductoRepository.Instance.getData(new Producto { Id = (Int32.Parse(columa.Cells["Id"].Value.ToString())) }).First();
                this.cmbProductos.Text = producto.Nombre;
                this.cmbProductos.SelectedItem = producto;
            }
        }


        private void limpiarCantidad()
        {
            this.txtCantidad.Text = "";
        }

    }
}
