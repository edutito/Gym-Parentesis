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



namespace ProyectoParentesis.FProductos.Entrada
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
         Entrada_Producto.Instance.getData()
                );
        }


        private void ColocarColumnas()
        {


            this.DGMostrarEntradaProductos.Columns.Add("Cantidad", "Cantidad Agregada");
            this.DGMostrarEntradaProductos.Columns.Add("Nombre", "Nombre del Producto");
            this.DGMostrarEntradaProductos.Columns.Add("Fecha_Creacion", "Fecha de creacion");
            this.DGMostrarEntradaProductos.Columns.Add("Id", "Id");

            this.DGMostrarEntradaProductos.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Entrada_Producto> entrada_productos)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarEntradaProductos.Rows.Clear();

            foreach (Entrada_Producto entrada_producto in entrada_productos)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarEntradaProductos.Rows.Add(

                entrada_producto.Cantidad,

                entrada_producto.N
                pago_matricula.Monto,
                pago_matricula.Id
                                );
            }

            this.AcomodarColumnas();
        }







        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
