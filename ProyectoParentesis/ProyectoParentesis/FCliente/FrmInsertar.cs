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


namespace ProyectoParentesis.FCliente
{
    public partial class FrmInsertar : Form
    {
      
         private Cliente cliente; private FrmMostrar frmMostrar;
        public FrmInsertar(Cliente cliente = null, FrmMostrar frmMostrar = null)
        {
            InitializeComponent();
            this.populate();
            this.limpiardatos();
            if (cliente != null)
            {
                this.cliente = cliente;
                this.llenarData();
                this.btnLimpiar.Visible = false;
            }
            this.frmMostrar = frmMostrar;
        }

        private void llenarData()
        {
            this.txtNombre.Text = this.cliente.Nombre;
            this.txtApellidos.Text = this.cliente.Apellido;
            this.txtTelefono.Text = this.cliente.Telefono;
            this.txtDireccion.Text = this.cliente.Direccion;
            this.cmbEstado.Text = this.cliente.Estado;
            this.dateTimefechaIngreso.Value = this.cliente.Fecha_Ingreso;
            this.txtIdentificacion.Text = this.cliente.DNI;
        }

        private void populate()
        {
            foreach (String estado in Models.Model.ClienteRepository.Instance.getEstados())
            {
                this.cmbEstado.Items.Add(estado);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            Cliente cliente = new Cliente();
            if (this.cliente != null)
            {
                cliente = this.cliente;
            }

            cliente = cliente.llenar(
                this.txtNombre.Text,
                this.txtApellidos.Text,
                this.txtTelefono.Text,
                this.txtDireccion.Text,
                this.cmbEstado.Text,
                this.dateTimefechaIngreso.Value.Date,
                this.txtIdentificacion.Text
                );

            ClienteRepository.Instance.persist(cliente)
               .flush();


            if (this.cliente != null)
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
            this.txtIdentificacion.Clear();
            this.txtDireccion.Clear();
            this.dateTimefechaIngreso.Value = DateTime.Now;
            this.cmbEstado.Text = Models.Model.ClienteRepository.Activo;


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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimefechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
