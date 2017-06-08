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

namespace ProyectoParentesis.FRespaldos
{
    public partial class FrmRespaldo : Form
    {
        public FrmRespaldo()
        {
            InitializeComponent();
        }

        private void btnGenerarRespaldo_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "BD_Parentess";
            this.saveFileDialog1.ShowDialog();
            string s = null;
            s = this.saveFileDialog1.FileName;
            UsuarioRepository.Instance.Conexion.EjecutarComando("Backup database BD_Parentess to disk='" + s + ".bak'");
            MessageBox.Show("Ya se guardo la base de datos");
        }
    }
}
