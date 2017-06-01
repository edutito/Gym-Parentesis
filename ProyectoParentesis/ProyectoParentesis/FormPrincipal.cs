using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParentesis.FCliente;


namespace ProyectoParentesis
{
    public partial class Formu_Principal : Form
    {
        public Formu_Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frm = new FrmMostrar();
            frm.Show();
        }

        private void Formu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void intructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInstructor.FrmMostrar frm = new FInstructor.FrmMostrar();
            frm.Show();

        }

        private void generarClientesPrimerIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReports.FrmClientesPrimerIngreso frm = new FrmReports.FrmClientesPrimerIngreso()  ;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUsuario.FrmMostrar frm = new FUsuario.FrmMostrar();
            frm.Show();
        }

        private void registroPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistroPago.FrmMostrar frm = new FRegistroPago.FrmMostrar();
            frm.Show();
        }

        private void pagosMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPagosMatricula.FrmMostrar frm = new FPagosMatricula.FrmMostrar();
            frm.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductos.FrmMostrar frm = new FProductos.FrmMostrar();
            frm.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductos.Entrada.FrmMostrar frm = new FProductos.Entrada.FrmMostrar();
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductos.Venta.FrmInsertar frm = new FProductos.Venta.FrmInsertar();
            frm.Show();

        }

        private void clientensMorososToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmReports.FrmClienteMoroso frm = new FrmReports.FrmClienteMoroso();
            frm.Show();

        }

        private void generarClientesActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReports.FrmClientesActivos frm = new FrmReports.FrmClientesActivos();
            frm.Show();
        }

        private void productosMayorVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReports.FrmProductoMasVendido frm = new FrmReports.FrmProductoMasVendido();
            frm.Show();
        }

        private void productosMayorEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReports.FrmProductoEntrada frm = new FrmReports.FrmProductoEntrada();
            frm.Show();
        }

        private void perrmisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUsuarioPermiso.FrmMostrar frm = new FUsuarioPermiso.FrmMostrar();
            frm.Show();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCambioContrasena.frmCambioContraseña frm = new FCambioContrasena.frmCambioContraseña();
            frm.Show();
        }


        }
    }

