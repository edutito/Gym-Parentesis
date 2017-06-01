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

namespace ProyectoParentesis.FCambioContrasena
{
    public partial class frmCambioContraseña : Form
    {
        public frmCambioContraseña()
        {
            InitializeComponent();
        }


        private void Salvar()
        {
            Usuario usua = Contenedor.Contenedor.getUsuario();
            usua.Contrasena = this.txtconfirmacionContraseña.Text;
            

            UsuarioRepository.Instance.persist(usua)
               .flush();


                MessageBox.Show("Informacion Guardada");
            
        }

        private bool validar()
        {

            if (!Contenedor.Contenedor.getValidacion().ContrasennaActual(this.txtContraseñaActual.Text))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ContrasennaNueva(this.txtNuevaContrasena.Text, this.txtconfirmacionContraseña.Text))
            {
                return false;
            }
                        
            return true;

        }

        private void txtContraseñaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            {
                if (this.validar())
                {
                    this.Salvar();
                }
            } 
        }
    }
}
