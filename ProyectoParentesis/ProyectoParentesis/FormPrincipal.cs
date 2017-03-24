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
    }
}
