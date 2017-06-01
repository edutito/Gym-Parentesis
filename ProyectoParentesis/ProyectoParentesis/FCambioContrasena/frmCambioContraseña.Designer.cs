namespace ProyectoParentesis.FCambioContrasena
{
    partial class frmCambioContraseña
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
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconfirmacionContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(143, 67);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(166, 20);
            this.txtNuevaContrasena.TabIndex = 7;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(143, 21);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.PasswordChar = '*';
            this.txtContraseñaActual.Size = new System.Drawing.Size(166, 20);
            this.txtContraseñaActual.TabIndex = 6;
            this.txtContraseñaActual.TextChanged += new System.EventHandler(this.txtContraseñaActual_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña Actual";
            // 
            // txtconfirmacionContraseña
            // 
            this.txtconfirmacionContraseña.Location = new System.Drawing.Point(143, 119);
            this.txtconfirmacionContraseña.Name = "txtconfirmacionContraseña";
            this.txtconfirmacionContraseña.PasswordChar = '*';
            this.txtconfirmacionContraseña.Size = new System.Drawing.Size(166, 20);
            this.txtconfirmacionContraseña.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmación Contraseña";
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.Location = new System.Drawing.Point(118, 191);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(92, 33);
            this.btnGuardarCambio.TabIndex = 10;
            this.btnGuardarCambio.Text = "Guardar Cambio";
            this.btnGuardarCambio.UseVisualStyleBackColor = true;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // frmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.btnGuardarCambio);
            this.Controls.Add(this.txtconfirmacionContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioContraseña";
            this.Text = "frmCambioContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconfirmacionContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarCambio;
    }
}