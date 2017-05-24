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

        private const int idColummn = 3;
        private int Entrada_Producto_Id;

        public FrmMostrar()
        {
            InitializeComponent();
            this.ColocarColumnas();
             this.populate();
             this.LlenarData(
            Entrada_ProductoRepository.Instance.getData()
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

        private void populate()
        {
            this.cmbEntradaProductos.Items.Clear();
            foreach (Producto producto in ProductoRepository.Instance.getData())
            {
                this.cmbEntradaProductos.Items.Add(producto);
            }
            
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
                entrada_producto.getProducto().Nombre,
                entrada_producto.Fecha_Creacion,
                entrada_producto.Id
                                );
            }

            this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            int colCount = this.DGMostrarEntradaProductos.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarEntradaProductos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            FInsertar frm = new FInsertar();
            frm.Show();
        }


        public void buscar()
        {

            if ( !this.validar() ) {               


            Entrada_Producto entrada_producto = new Entrada_Producto();

            
            entrada_producto.Producto_id = ((Producto)this.cmbEntradaProductos.SelectedItem).Id;

            //Producto.SelectedItem(cmbEntradaProductos).id;

                this.LlenarData(
               Entrada_ProductoRepository.Instance.getData(entrada_producto, true)
                );

            };

            }

            
             

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            
            {
                this.buscar();
            }
            
            
        }


        private bool validar()
        {

            if (this.cmbEntradaProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Producto.");
                return false;
            }

            {
                return false;
            }

            return true;
        }



        //private void DGMostrarEntradaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        
        //      if (e.Button == MouseButtons.Left && e.RowIndex > -1)
        //    {

        //        if (cmbEntradaProductos.SelectedRows.Count != 0 && this.cmbEntradaProductos["Id", e.RowIndex].Value != null)
        //        {
        //            Entrada_Producto entrada_producto = new Entrada_Producto();
        //            entrada_producto.Id = Int32.Parse(this.entrada_producto["Id", e.RowIndex].Value.ToString());
        //            entrada_producto = Entrada_Producto.Instance.getData(entrada_producto).First();
        //            FrmInsertar frm = new FInsertar(entrada_producto, this);
        //            frm.Show();
        //        }
        //    }
        //}



        }
    }

