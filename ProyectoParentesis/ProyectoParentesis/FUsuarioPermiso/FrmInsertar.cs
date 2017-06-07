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


namespace ProyectoParentesis.FUsuarioPermiso
{
    public partial class FrmInsertar : Form
    {
        private FrmMostrar frmMostrar;

        public FrmInsertar(FrmMostrar frmMostrar)  
        {
            InitializeComponent();
            //this.ColocarColumnas();
            this.frmMostrar = frmMostrar;


            this.populate();
        }



        private void populate()
        {
           
             this.cmbUsuario.Items.Clear();
            foreach (Usuario usu in UsuarioRepository.Instance.getData())
            {
                this.cmbUsuario.Items.Add(usu).ToString();
            }


            this.cmbPermisos.Items.Clear();
            foreach (Permisos permi in PermisosRepository.Instance.getData())
            {
                this.cmbPermisos.Items.Add(permi).ToString();
            }

        }

        private void Salvar()
        {
            Usuario_Permisos usuper = new Usuario_Permisos();


            usuper.Usuario_id = ((Usuario)this.cmbUsuario.SelectedItem).Id;
            Usuario_PermisosRepository.Instance.delete(usuper);
            usuper.Permiso_id = ((Permisos)this.cmbPermisos.SelectedItem).Id;
               
            
            Usuario_PermisosRepository.Instance.persist(usuper).flush();
            MessageBox.Show("Informacion Guardada");
            this.limpiardatos();
            this.frmMostrar.buscar();
        }

        private void limpiardatos()
        {
            this.populate();
           
        }

        private bool validar()
        {

            if (this.cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Usuario.");
                return false;
            }

            if (this.cmbPermisos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Permiso.");
                return false;
            }

            //if (!Contenedor.Contenedor.getValidacion().solounpermisoporusuario(((Usuario)this.cmbUsuario.SelectedItem).Id, ((Permisos)this.cmbPermisos.SelectedItem).Id))
            //{
            //    return false;
            //}

            return true;
        }
        
        private void btnGuardarUsuarioPermiso_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.Salvar();
            }
        }
    }
}
