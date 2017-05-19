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



namespace ProyectoParentesis.FInstructor
{
    public partial class FrmInsertar : Form
    {
        private Instructor instruct; private FrmMostrar frmMostrar;
        public FrmInsertar(Instructor instruct = null, FrmMostrar frmMostrar = null)

        {
            InitializeComponent();
             this.populate();
            this.limpiardatos();
            this.cmbEstado.Text = InstructorRepository.Activo; 

            if (instruct != null)
            {
                this.instruct = instruct;
                this.llenarData();
                this.btnLimpiar.Visible = false;
            }
            this.frmMostrar = frmMostrar;
        }

        private void llenarData()
        {
            this.txtNombre.Text = this.instruct.Nombre;
            this.txtApellidos.Text = this.instruct.Apellido;
            this.txtTelefono.Text = this.instruct.Telefono;
            this.txtDireccion.Text = this.instruct.Direccion;
            this.cmbEstado.Text = this.instruct.Estado;
            
        }

         private void populate()
        {
            foreach (String estado in Models.Model.ClienteRepository.Instance.getEstados())
            {
                this.cmbEstado.Items.Add(estado);
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             if (this.validar())
            {
                this.Salvar();
            }
        }

        private void Salvar()
        {
            Instructor instruct = new Instructor();
            if (this.instruct != null)
            {
                instruct = this.instruct;
            }

            instruct = instruct.llenar(
                this.txtNombre.Text,
                this.txtApellidos.Text,                
                this.txtDireccion.Text,
                this.txtTelefono.Text,
                this.cmbEstado.Text
                );

            InstructorRepository.Instance.persist(instruct)
               .flush();


            if (this.instruct != null)
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
                this.frmMostrar.buscar();
            }
            
        }
         private void limpiardatos()
        {
            this.txtNombre.Clear();
            this.txtApellidos.Clear();
            this.txtTelefono.Clear();
            this.txtDireccion.Clear();
           


        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }


        private bool validar()
        {

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtNombre.Text, "Campo Nombre es Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloLetras(this.txtNombre.Text, "Nombre Solo permite Letras"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtApellidos.Text, "Campo Apellidos Obligatorios"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloLetras(this.txtApellidos.Text, "Apellidos solo permite Letras"))
            {
                return false;
            }


            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtTelefono.Text, "Campo telefono es Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtTelefono.Text, "Campo telefono solo acepta Numeros y sin espacios entre ellos "))
            {
                return false;
            }
                       
            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtDireccion.Text, "Campo Direccion Obligatorio"))
            {
                return false;
            }
                  

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
