namespace ProyectoParentesis.FUsuarioPermiso
{
    partial class FrmInsertar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarUsuarioPermiso = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(118, 80);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(277, 21);
            this.cmbPermisos.TabIndex = 60;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(118, 31);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(277, 21);
            this.cmbUsuario.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 34);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(163, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 34);
            this.btnLimpiar.TabIndex = 57;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuarioPermiso
            // 
            this.btnGuardarUsuarioPermiso.Location = new System.Drawing.Point(28, 131);
            this.btnGuardarUsuarioPermiso.Name = "btnGuardarUsuarioPermiso";
            this.btnGuardarUsuarioPermiso.Size = new System.Drawing.Size(97, 31);
            this.btnGuardarUsuarioPermiso.TabIndex = 56;
            this.btnGuardarUsuarioPermiso.Text = "Guardar";
            this.btnGuardarUsuarioPermiso.UseVisualStyleBackColor = true;
            this.btnGuardarUsuarioPermiso.Click += new System.EventHandler(this.btnGuardarUsuarioPermiso_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Permisos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Usuario";
            // 
            // FrmInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 189);
            this.Controls.Add(this.cmbPermisos);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarUsuarioPermiso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertar";
            this.Text = "FrmInsertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarUsuarioPermiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;

    }
}