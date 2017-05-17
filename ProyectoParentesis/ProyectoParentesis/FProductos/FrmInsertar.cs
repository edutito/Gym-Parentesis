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
    public partial class FrmInsertar : Form
    {


        private Producto producto;

        private FrmMostrar frmMostrar;

        public FrmInsertar(Producto producto = null, FrmMostrar frmMostrar = null)
        {

            InitializeComponent();

            this.populate();

            this.limpiardatos();

            if (producto != null)
            {

                this.producto = producto;

                this.LlenarData();

                this.btnLimpiar.Visible = false;

            }

            this.frmMostrar = frmMostrar;

        }

        private void LlenarData()
        {

            this.txtNombre.Text = this.producto.Nombre;

            this.txtCodigo.Text = this.producto.Codigo;

            //this.txtNombreUsuario.Text = this.usuario.Nombre_Usuario;

            this.txtPrecio.Text = this.producto.Precio.ToString();

            this.cmbEstado.Text = this.producto.Estado;



        }



      



        private void populate()
        {

            foreach (String estado in ProductoRepository.Instance.getEstados())
            {

                this.cmbEstado.Items.Add(estado);

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        //public void buscar()
        //{
        //    Producto producto = new Producto();

        //    producto.Nombre = txtNombre.Text;
        //    producto.Codigo = txtCodigo.Text;


        //    this.LlenarData(
        //       ProductoRepository.Instance.getData(producto, true)
        //        );
        //}


        private void llenarData()
        {

            this.txtNombre.Text = this.producto.Nombre;

            this.txtCodigo.Text = this.producto.Codigo;

           this.txtPrecio.Text = this.producto.Precio.ToString ();

            this.cmbEstado.Text = this.producto.Estado;



        }

        private void Salvar()
        {

            Producto producto = new Producto();

            if (this.producto != null)
            {

                producto = this.producto;

            }



            producto = producto.llenar(

                this.txtNombre.Text,

                this.txtCodigo.Text,

                Int32.Parse(this.txtPrecio.Text),

               this.cmbEstado.Text 

            );



            ProductoRepository.Instance.persist(producto)

               .flush();





            if (this.producto != null)
            {



                MessageBox.Show("Informacion Actualizada");





            }

            else
            {

                MessageBox.Show("Informacion Guardada");

                this.limpiardatos();

            }



            if (this.frmMostrar != null)
            {

                //this.frmMostrar.buscar();

            }





        }


        private void limpiardatos()
        {

            this.txtNombre.Clear();

            this.txtCodigo.Clear();

            this.txtPrecio.Clear();

            //this.txtApellido.Clear();

        }


        private bool validar()
        {



            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtNombre.Text, "Campo Nombre del Producto es Obligatorio"))
            {

                return false;

            }



            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtCodigo.Text, "Campo Codigo es Obligatorio"))
            {

                return false;

            }



            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtPrecio.Text, "Campo Precio es Obligatorio"))
            {

                return false;

            }



            if (!Contenedor.Contenedor.getValidacion().ValidarSoloLetras(this.txtNombre.Text, "Nombre solo permiten Letras"))
            {

                return false;

            }


            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtPrecio.Text, "Campo Precio solo acepta Numeros"))
            {

                return false;

            }

            return true;

        }


    }
}
