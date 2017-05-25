namespace ProyectoParentesis.FRegistroPago
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.txtMesesPagos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 34);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(460, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 34);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(460, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 31);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(109, 24);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(277, 21);
            this.cmbClientes.TabIndex = 35;
            // 
            // txtMesesPagos
            // 
            this.txtMesesPagos.Location = new System.Drawing.Point(109, 61);
            this.txtMesesPagos.Name = "txtMesesPagos";
            this.txtMesesPagos.Size = new System.Drawing.Size(277, 20);
            this.txtMesesPagos.TabIndex = 39;
            this.txtMesesPagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesesPagos_KeyPress);
            this.txtMesesPagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMesesPagos_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Meses a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Monto a Pagar";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(109, 117);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.ReadOnly = true;
            this.txtMontoPagar.Size = new System.Drawing.Size(277, 20);
            this.txtMontoPagar.TabIndex = 41;
            // 
            // FrmInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 309);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesesPagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Name = "FrmInsertar";
            this.Text = "FrmInsertar";
            this.Load += new System.EventHandler(this.FrmInsertar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.TextBox txtMesesPagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoPagar;
    }
}