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

namespace ProyectoParentesis.FUsuario
{
    public partial class FrmInsertar : Form
    {
      

        private Usuario usuario; private FrmMostrar frmMostrar;
        public FrmInsertar(Usuario usuario = null, FrmMostrar frmMostrar = null)
        {
            InitializeComponent();
            this.populate();
            this.limpiardatos();
            if (usuario != null)
            {
                this.usuario = usuario;
                this.llenarData();
                //this.btnLimpiar.Visible = false;
            }
            this.frmMostrar = frmMostrar;
        }

        private void llenarData()
        {
            this.txtNombre.Text = this.usuario.Nombre;
            this.txtContraseña.Text = this.usuario.Contrasena;
            this.txtNombreUsuario.Text = this.usuario.Nombre_Usuario;
            this.txtApellido.Text = this.usuario.Apellido;
            this.cmbEstado.Text = this.usuario.Estado;
           
        }

        private void populate()
        {
            foreach (String estado in Models.Model.UsuarioRepository.Instance.getEstados())
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
            Usuario usuario = new Usuario();
            if (this.usuario != null)
            {
                usuario = this.usuario;
            }

            usuario = usuario.llenar(
            this.txtNombre.Text,
            this.txtContraseña.Text,
            this.txtNombreUsuario.Text,
            this.txtApellido.Text,
            this.cmbEstado.Text
               
                );

            ClienteRepository.Instance.persist(usuario)
               .flush();


            if (this.usuario != null)
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
            this.txtContraseña.Clear();
            this.txtNombreUsuario.Clear();
            this.txtApellido.Clear();
           
          


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.limpiardatos();
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

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtTelefono.Text, "Campo telefono solo acepta Numeros"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtIdentificacion.Text, "Campo Identificacion es Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtDireccion.Text, "Campo Direccion Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarFechaIngreso(this.dateTimefechaIngreso.Value, "Fecha no ser puede mayor a la Actual "))
            {
                return false;
            }


            if (cliente == null && !Contenedor.Contenedor.getValidacion().ClienteSinRepetir(this.txtIdentificacion.Text, "Cliente ya Existe"))
            {
                return false;
            }

            
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
