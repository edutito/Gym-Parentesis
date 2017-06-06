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

            this.mostrarMonto();
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
            PagoRepository.Instance.persist(pago)
               .flush();

           
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


        private void mostrarMonto()
        {
            if (this.txtMesesPagos.Text.All(Char.IsDigit) && !String.IsNullOrEmpty(this.txtMesesPagos.Text))
            {
                int meses = (Int32.Parse(this.txtMesesPagos.Text));
                if (meses <= 12)
                {
                    this.txtMontoPagar.Text = String.Format("{0:n0}", meses * PagoRepository.MONTO);
                }else
                {
                    MessageBox.Show("Maximo a pagar 12 meses.");
                    this.txtMesesPagos.Text = "12";
                }
                
            }else
            {
                this.txtMontoPagar.Text = "0";
            }            
        }

        private void txtMesesPagos_KeyUp(object sender, KeyEventArgs e)
        {
            this.mostrarMonto();
        }

        private void txtMesesPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }                        
        }
    }
}
