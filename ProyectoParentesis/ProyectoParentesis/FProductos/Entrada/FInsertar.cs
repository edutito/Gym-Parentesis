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

namespace ProyectoParentesis.FProductos.Entrada
{
    public partial class FInsertar : Form
    {
        public FInsertar()
        {
            InitializeComponent();
            this.populate();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.Salvar();
            }
        }

        private void limpiardatos()
        {
            this.populate();
            this.txtCantidad.Text = 0.ToString();
        }

        private void populate()
        {
            this.cmbProductos.Items.Clear();
            foreach (Producto producto in ProductoRepository.Instance.getData())
            {
                this.cmbProductos.Items.Add(producto);
            }            
        }

        private bool validar()
        {

            if (this.cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Producto.");
                return false;
            }

            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtCantidad.Text, "Cantidad Solo permite numeros"))
            {
                return false;
            }            

            return true;
        }

        private void Salvar()
        {
            Entrada_Producto entrada = new Entrada_Producto();
            entrada = entrada.llenar(
                Int32.Parse(this.txtCantidad.Text),
                ((Producto)this.cmbProductos.SelectedItem).Id
                );          
            
            Entrada_ProductoRepository.Instance.crear(entrada);
            MessageBox.Show("Informacion Guardada");
            this.limpiardatos();                   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiardatos();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
