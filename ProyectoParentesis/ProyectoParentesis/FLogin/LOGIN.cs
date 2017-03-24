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

namespace ProyectoParentesis.FLogin
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String Nombre_Usuario = this.txtUsuario.Text;
            String Contrasena = this.txtContrasena.Text;

             Usuario usuario = new Usuario();

             usuario.Nombre_Usuario = Nombre_Usuario;
             usuario.Contrasena = Contrasena;
             usuario.Estado = UsuarioRepository.Activo;

             List<Usuario> usuarios = UsuarioRepository.Instance.getData(usuario, false);

             if (usuarios.Count() > 0)
             {

                 Contenedor.Contenedor.setUsuario(usuarios.First());
                 Formu_Principal frm = new Formu_Principal();
                 frm.Show();
                 this.Hide();
             }
             else 
             {
                 MessageBox.Show("Usuario Invalido");

                 this.txtContrasena.Clear();
                 this.txtUsuario.Clear();

                 

             }




        }
    }
}
