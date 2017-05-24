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


namespace ProyectoParentesis.FPagosMatricula
{
    public partial class FrmInsertar : Form
    {
        private Pago_Matricula pago_matricula;
        private FrmMostrar frmMostrar;
        public FrmInsertar(Pago_Matricula pago_matricula = null, FrmMostrar frmMostrar = null)
        {
            InitializeComponent();
            this.populate();
            this.limpiardatos();
            if (pago_matricula != null)
            {
                this.pago_matricula = pago_matricula;
                this.llenarData();
                this.btnLimpiar.Visible = false;
            }
            this.frmMostrar = frmMostrar;
        }

        private void llenarData()
        {
            this.txtNombre.Text = this.pago_matricula.Nombre_Cliente;
            this.txtApellidos.Text = this.pago_matricula.Apellido;
            this.txtMontoMatricula.Text = this.txtMontoMatricula.ToString();
            

        }

        private void populate()
        {
            this.cmbClientes.Items.Clear();
            foreach (Cliente cliente in ClienteRepository.Instance.getClientesActivos())
            {
                this.cmbClientes.Items.Add(cliente);
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
            Pago_Matricula pago_matricula = new Pago_Matricula();
            if (this.pago_matricula != null)
            {
                pago_matricula = this.pago_matricula;
            }

            pago_matricula = pago_matricula.llenar(
                this.txtNombre.Text,
                this.txtApellidos.Text,
                Int32.Parse(this.txtMontoMatricula.Text),
                ((Cliente)this.cmbClientes.SelectedItem).Id
   
            
            );
            


            Pago_MatriculaRepository.Instance.persist(pago_matricula)
               .flush();

            if (this.pago_matricula != null)
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
            this.txtMontoMatricula.Clear();
            this.populate();
                

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.limpiardatos();
        }

        private bool validar()
        {

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtNombre.Text, "Campo Nombre del Cliente es Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarTexto(this.txtApellidos.Text, "Campo Nombre es Obligatorio"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtMontoMatricula.Text, "Campo Monto de Matricula solo permite numeros"))
            {
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloLetras(this.txtApellidos.Text, "Apellidos solo permite Letras"))
            {
                return false;
            }
            if (!Contenedor.Contenedor.getValidacion().ValidarSoloLetras(this.txtNombre.Text, "Nombre solo permite Letras"))
            {
                return false;
            }

            return true;
        }

      

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.limpiardatos();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.Salvar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}






