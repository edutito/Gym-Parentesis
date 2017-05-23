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

namespace ProyectoParentesis.FRegistroPago
{
    public partial class FrmInsertar : Form
    {
        private Pago pago;
        private FrmMostrar frmMostrar;
        private void FrmInsertar_Load(object sender, EventArgs e)
        {
            this.limpiardatos();
            this.populate();            
            if (pago != null)
            {
                this.pago = pago;
                this.llenarData();
                this.btnLimpiar.Visible = false;
            }
            this.frmMostrar = frmMostrar;
        }

        private void llenarData()
        {
            this.cmbClientes.SelectedItem = this.pago.getCliente();
        }

        private void limpiardatos()
        {
            this.populate();
        }

        public FrmInsertar(Pago pago = null, FrmMostrar frmMostrar = null)
        {
            InitializeComponent();           
            this.populate();
        }

        private void populate()
        {
            this.cmbClientes.Items.Clear();
            foreach (Cliente cliente in ClienteRepository.Instance.getClientesActivos())
            {
                this.cmbClientes.Items.Add(cliente);
            }
            DateTime date = DateTime.Now;
            this.txtMesesPagos.Text = "1";
            
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
            Pago pago ;
            if (this.pago != null)
            {
                pago = this.pago;
            }else
            {
                pago = new Pago();
            }

            PagoRepository.Instance.MesesAPagar(
                DateTime.Now,
                Int32.Parse(this.txtMesesPagos.Text),
                ((Cliente)this.cmbClientes.SelectedItem),
                Contenedor.Contenedor.getUsuario(),
                PagoRepository.MONTO
                );
           
            if (this.pago != null)
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

        private bool validar()
        {
           
            if (this.cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un cliente.");
                return false;
            }
            if (!Contenedor.Contenedor.getValidacion().ValidarSoloNumero(this.txtMesesPagos.Text, "CAMPO Solo permite numeros"))
            {
                return false;
            }
            

            if (this.pago == null && !Contenedor.Contenedor.getValidacion().ClienteYaPago(
                DateTime.Now,
                DateTime.Now.AddMonths(Int32.Parse(this.txtMesesPagos.Text)),
                ((Cliente)this.cmbClientes.SelectedItem).Id, 
                "Cliente ya pago en ese rango de fechas")
                )
            {
                return false;
            }

            return true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
