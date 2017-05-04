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
    public partial class FrmMostrar : Form
    {

        private const int idColummn = 5;
        private int clienteId;
        public FrmMostrar()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
               UsuarioRepository.Instance.getData()
                );
        }

        private void ColocarColumnas()
        {

            this.DGMostrarUsuarios.Columns.Add("Contrasena", "Contraseña");
            this.DGMostrarUsuarios.Columns.Add("Nombre_Usuario", "Nombre de Usuario");
            this.DGMostrarUsuarios.Columns.Add("Nombre", "Nombre");
            this.DGMostrarUsuarios.Columns.Add("Apellido", "Apellido");
            this.DGMostrarUsuarios.Columns.Add("Estado", "Estado");
            this.DGMostrarUsuarios.Columns.Add("Id", "Id");

            this.DGMostrarUsuarios.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Usuario> Usuarios)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGMostrarUsuarios.Rows.Clear();

            foreach (Usuario usuario in Usuarios)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGMostrarUsuarios.Rows.Add(
                    usuario.Contrasena,
                   usuario.Nombre_Usuario,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Estado,
                
                    usuario.Id
                    );
            }

            this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            int colCount = this.DGMostrarUsuarios.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGMostrarUsuarios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnIngresarNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }

        private void btnIngresarNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar(null, this);
            frm.Show();
        }

        private void DGMostrarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        public void buscar()
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;


            this.LlenarData(
               UsuarioRepository.Instance.getData(usuario, true)
                );
        }

        private void DGMostrarUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                if (DGMostrarUsuarios.SelectedRows.Count != 0 && this.DGMostrarUsuarios["Id", e.RowIndex].Value != null)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Int32.Parse(this.DGMostrarUsuarios["Id", e.RowIndex].Value.ToString());
                    usuario = UsuarioRepository.Instance.getData(usuario).First();
                    FrmInsertar frm = new FrmInsertar(usuario, this);
                    frm.Show();
                }
            }




        }
    }


   

}
