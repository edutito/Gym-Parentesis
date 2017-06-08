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


namespace ProyectoParentesis.FAjustes
{
    public partial class FrmInsertar : Form
    {
        public FrmInsertar()
        {
            InitializeComponent();
            this.populate();
        }
        private void populate()
        {
            this.cmbProductos.Items.Clear();
            foreach (Producto producto in ProductoRepository.Instance.getData())
            {
                this.cmbProductos.Items.Add(producto);
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
            Ajustes ajust = new Ajustes();

            String Tipo;
            if (Int32.Parse( this.txtCantidad.Text) < 0)
            {
                Tipo = AjustesRepository.Entrada;

            }else {

                Tipo = AjustesRepository.Salida;

                  }

            ajust = ajust.llenar(
                    Int32.Parse( this.txtCantidad.Text),
                    this.txtMotivo.Text,
                    Tipo,
                    Contenedor.Contenedor.getUsuario().Id,
                    ((Producto)this.cmbProductos.SelectedItem).Id,
                    DateTime.Now
               
                );

            AjustesRepository.Instance.crear(ajust);
            MessageBox.Show("Informacion Guardada");
            this.limpiardatos();
        }

        private void limpiardatos()
        {
            this.populate();
            this.txtCantidad.Text = 0.ToString();
            this.txtMotivo.Text = "";
        }

        private bool validar()
        {

            if (this.cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un Producto.");
                return false;
            }

         

            return true;
        }

    }
}
