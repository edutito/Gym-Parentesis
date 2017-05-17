namespace ProyectoParentesis.FRegistroPago
{
    partial class FrmMostrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnIngresarNuevoCliente = new System.Windows.Forms.Button();
            this.DGMostrarClientes = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Busqueda de Registro de Pago Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(639, 52);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(156, 32);
            this.btnMostrarClientes.TabIndex = 13;
            this.btnMostrarClientes.Text = "Mostrar Registros";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnIngresarNuevoCliente
            // 
            this.btnIngresarNuevoCliente.Location = new System.Drawing.Point(449, 50);
            this.btnIngresarNuevoCliente.Name = "btnIngresarNuevoCliente";
            this.btnIngresarNuevoCliente.Size = new System.Drawing.Size(156, 32);
            this.btnIngresarNuevoCliente.TabIndex = 12;
            this.btnIngresarNuevoCliente.Text = "Ingresar Nuevo Registro";
            this.btnIngresarNuevoCliente.UseVisualStyleBackColor = true;
            this.btnIngresarNuevoCliente.Click += new System.EventHandler(this.btnIngresarNuevoCliente_Click);
            // 
            // DGMostrarClientes
            // 
            this.DGMostrarClientes.AllowUserToAddRows = false;
            this.DGMostrarClientes.AllowUserToDeleteRows = false;
            this.DGMostrarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarClientes.Location = new System.Drawing.Point(0, 102);
            this.DGMostrarClientes.Name = "DGMostrarClientes";
            this.DGMostrarClientes.ReadOnly = true;
            this.DGMostrarClientes.Size = new System.Drawing.Size(910, 301);
            this.DGMostrarClientes.TabIndex = 11;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(76, 52);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(323, 21);
            this.cmbCliente.TabIndex = 16;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 403);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnIngresarNuevoCliente);
            this.Controls.Add(this.DGMostrarClientes);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnIngresarNuevoCliente;
        private System.Windows.Forms.DataGridView DGMostrarClientes;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}