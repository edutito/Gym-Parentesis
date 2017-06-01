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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            this.populate();
            this.ColocarColumnas();
            this.LlenarData(
              Usuario_PermisosRepository.Instance.getData()
                );
        }



        private void ColocarColumnas()
        {

            this.DGMostrarUsuariosYPermisos.Columns.Add("Nombre", "Nombre");
            this.DGMostrarUsuariosYPermisos.Columns.Add("Apellido", "Apellido");
            this.DGMostrarUsuariosYPermisos.Columns.Add("Usuario", "Usuario");
            this.DGMostrarUsuariosYPermisos.Columns.Add("Permiso", "Tipo de Permiso");
            this.DGMostrarUsuariosYPermisos.Columns.Add("Id", "Id");

            this.DGMostrarUsuariosYPermisos.Columns["Id"].Visible = false;

        }

        private void LlenarData(List<Usuario_Permisos> usuper)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarUsuariosYPermisos.Rows.Clear();

            foreach (Usuario_Permisos usupe in usuper)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarUsuariosYPermisos.Rows.Add(
                 usupe.getUsuario().Nombre,
                 usupe.getUsuario().Apellido,
                 usupe.getUsuario().Nombre_Usuario,
                 usupe.getPermiso().Nombre
                    );
            }

            this.AcomodarColumnas();
        }

        private void AcomodarColumnas()
        {
            int colCount = this.DGMostrarUsuariosYPermisos.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarUsuariosYPermisos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        public void buscar()
        {
            Usuario_Permisos usu = new Usuario_Permisos();

            if (this.cmbBuscarPermiso.SelectedItem != null)
            {
                usu.Permiso_id = ((Permisos)this.cmbBuscarPermiso.SelectedItem).Id;
            }
            if (this.cmbBuscarUsuario.SelectedItem != null)
            {
                usu.Usuario_id = ((Usuario)this.cmbBuscarUsuario.SelectedItem).Id;

            }
            this.LlenarData(Usuario_PermisosRepository.Instance.getData(usu, false));
        }

        private void populate()
        {

            this.cmbBuscarUsuario.Items.Clear();
            foreach (Usuario usu in UsuarioRepository.Instance.getData())
            {
                this.cmbBuscarUsuario.Items.Add(usu).ToString();
            }


            this.cmbBuscarPermiso.Items.Clear();
            foreach (Permisos permi in PermisosRepository.Instance.getData())
            {
                this.cmbBuscarPermiso.Items.Add(permi).ToString();
            }

        }


        private void btnIngresarUsuarioYPermiso_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar();
            frm.Show();
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.buscar();
        }
    }
}
