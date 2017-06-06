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

        private bool validarCantidad()
        {
            if (this.cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Producto.");

                return false;
            }
            String cantidadtxt = this.txtCantidad.Text;
            if (cantidadtxt == "")
            {
                MessageBox.Show("Debes colocar una cantidad para un Producto.");

                return false;
            }
            else if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(cantidadtxt, "Campo Cantidad  solo acepta Numeros"))
            {
                return false;
            }

            int cantidad = Int32.Parse(cantidadtxt);

            Producto producto = this.getProductoFromCmb();
            if (producto.Cantidad < cantidad)
            {
                MessageBox.Show("El producto " + producto.Nombre + " solo tiene una cantidad de " + producto.Cantidad + " en el invetario.");
                this.txtCantidad.Text = producto.Cantidad.ToString();
                return false;
            }


            return true;
        }

        private Producto getProductoFromCmb()
        {
            return this.cmbProductos.SelectedItem as Producto;
        }

        private void AgregarProduco()
        {
            if (!this.validarCantidad()) return;

            String cantidadtxt = this.txtCantidad.Text;
            Producto producto = getProductoFromCmb();
            if ( producto.Cantidad==0 )
            {
                MessageBox.Show("Noy hay en existencia");
                return;
            }

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
                String.Format("{0:n0}", producto.Precio),
                String.Format("{0:n0}", producto.Precio * cantidad),
                producto.Id
            );
            this.AcomodarColumnas();
            this.limpiarCantidad();
            this.CalculoMontoTotalVendido();

        }

        private bool ValidarProductoAgregado(Producto producto)
        {
            foreach (DataGridViewRow fila in this.DGVVentaProductos.Rows)
            {
                int x = Int32.Parse(fila.Cells["Id"].Value.ToString());
                if (x == producto.Id && fila.Index != this.posAlter)
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
            this.DGVVentaProductos.Rows[pos].Cells["Precio_Articulo"].Value = String.Format("{0:n0}", prod.Precio);
            this.DGVVentaProductos.Rows[pos].Cells["Precio_Cantidad"].Value = String.Format("{0:n0}", prod.Precio * cantidad);
            this.DGVVentaProductos.Rows[pos].Cells["Id"].Value = prod.Id;
        }




        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            this.AgregarProduco();
        }



        private void limpiardatos()
        {
            this.populate();
            this.txtNombreCliente.Text = "";
            this.DGVVentaProductos.Rows.Clear();
        }


        private void Salvar()
        {
            if (!this.validar()) return;
            Venta_Producto venta_producto = new Venta_Producto();
            venta_producto.Id_Usuario = Contenedor.Contenedor.getUsuario().Id;
            venta_producto.Monto = Int32.Parse(this.txtMontoTotalVendo.Text.Replace(".", ""));
            venta_producto.Nombre_persona = this.txtNombreCliente.Text;
            venta_producto = Venta_ProductoRepository.Instance.save(venta_producto);
            this.saveChildrens(venta_producto);

            if (this.DGVVentaProductos != null)
            {

                MessageBox.Show("Informacion Guardada");
                this.limpiardatos();
            }
            
        }

        private void saveChildrens(Venta_Producto venta_producto)
        {
            Venta_Producto_Detalle son;
            Producto prod;
            int cantidad;
            foreach (DataGridViewRow fila in this.DGVVentaProductos.Rows)
            {
                son = new Venta_Producto_Detalle();
                prod = ProductoRepository.Instance.getData(new Producto { Id = Int32.Parse(fila.Cells["Id"].Value.ToString()) }).First();
                cantidad = Int32.Parse(fila.Cells["Cantidad"].Value.ToString()); ;
                son.Cantidad = cantidad;
                son.Nombre = prod.Nombre;
                son.Venta_Producto_id = venta_producto.Id;
                son.producto_id = prod.Id;                
                prod.Cantidad -= cantidad;
                Venta_Producto_DetalleRepository.Instance.persist(son);
                ProductoRepository.Instance.persist(prod);
            }
            ProductoRepository.Instance.flush();
            Venta_Producto_DetalleRepository.Instance.flush();
        }


        private bool validar()
        {
            if (this.txtNombreCliente.Text == "")
            {
                MessageBox.Show("Campo nombre cliente requerido");
                return false;
            }

            if (this.DGVVentaProductos.Rows.Count == 0)
            {
                MessageBox.Show("Se requiere por lo menos tener 1 producto agregado.");
                return false;
            }

            return true;
        }

        private void CantidadTotalPrecio()
        {
            if (!(this.txtCantidad.Text.All(Char.IsDigit) && !String.IsNullOrEmpty(this.txtCantidad.Text)))
            {
                this.txtCantidadVendidoTotal.Text = "0";
                return;
            }

            if (!this.validarCantidad()) return;
            int cantidad = Int32.Parse(this.txtCantidad.Text);
            Producto producto = this.getProductoFromCmb();
            this.txtCantidadVendidoTotal.Text = String.Format("{0:n0}", producto.Precio * cantidad);

        }


        private void CalculoMontoTotalVendido()
        {
            int montoTotal = 0;
            foreach (DataGridViewRow fila in this.DGVVentaProductos.Rows)
            {
                montoTotal += Int32.Parse(fila.Cells["Precio_Cantidad"].Value.ToString().Replace(".",""));                               
            }
            this.txtMontoTotalVendo.Text = String.Format("{0:n0}", montoTotal);
            this.CantidadTotalPrecio();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.posAlter == null)
            {
                MessageBox.Show("Selecciona la columna de un producto");
                return;
            };

            if (!this.validarCantidad()) return;
            Producto producto = this.cmbProductos.SelectedItem as Producto;

            if (this.ValidarProductoAgregado(producto))
            {
                MessageBox.Show("Producto ya agregado, se tiene que modificar el producto para cambiar la cantidad.");
                return;
            }            
            this.Modificar(producto, (int)this.posAlter, Int32.Parse(this.txtCantidad.Text));
            this.posAlter = null;
            MessageBox.Show("Producto modificado");

            this.limpiarCantidad();
            this.CalculoMontoTotalVendido();
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
            this.CalculoMontoTotalVendido();

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
            this.cmbProductos.SelectedItem = null;
        }
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            this.CantidadTotalPrecio();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            this.txtNombreCliente.Text = "";
            this.txtCantidad.Text = "";
            this.txtCantidadVendidoTotal.Text = "";
            this.txtMontoTotalVendo.Text = "";
            this.DGVVentaProductos.Rows.Clear();

        }

        private void cmbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            this.CantidadTotalPrecio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }
    }
}