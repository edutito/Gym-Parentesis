﻿using System;
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

                return ;
            }
            String cantidadtxt=this.txtCantidad.Text;
           if (cantidadtxt == "")
           {
               MessageBox.Show("Debes seleccionar un Producto.");

               return;
           }else if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(cantidadtxt, "Campo Cantidad  solo acepta Numeros"))
           {
               return ;
           }

           Producto producto = this.cmbProductos.SelectedItem as Producto;
            int cantidad =Int32.Parse(cantidadtxt);

            DataGridViewRow row = new DataGridViewRow();

                this.DGVVentaProductos.Rows.Add(

                producto.Nombre,
                cantidad,
                producto.Precio,
                (producto.Precio * cantidad),
                producto.Id
                                );
                        this.AcomodarColumnas();

        }

        private void Modificar(int prod, int pos)
        {


        }

        private void EliminarProducto(int pos)
        {


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


    }
}
