namespace ProyectoParentesis.FCliente
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
            this.DGMostrarClientes = new System.Windows.Forms.DataGridView();
            this.btnIngresarNuevoCliente = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMostrarClientes
            // 
            this.DGMostrarClientes.AllowUserToAddRows = false;
            this.DGMostrarClientes.AllowUserToDeleteRows = false;
            this.DGMostrarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarClientes.Location = new System.Drawing.Point(0, 207);
            this.DGMostrarClientes.Name = "DGMostrarClientes";
            this.DGMostrarClientes.ReadOnly = true;
            this.DGMostrarClientes.Size = new System.Drawing.Size(1183, 301);
            this.DGMostrarClientes.TabIndex = 0;
            this.DGMostrarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMostrarClientes_CellContentClick);
            this.DGMostrarClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGMostrarClientes_CellMouseClick);
            this.DGMostrarClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGMostrarClientes_MouseClick);
            // 
            // btnIngresarNuevoCliente
            // 
            this.btnIngresarNuevoCliente.Location = new System.Drawing.Point(449, 45);
            this.btnIngresarNuevoCliente.Name = "btnIngresarNuevoCliente";
            this.btnIngresarNuevoCliente.Size = new System.Drawing.Size(156, 32);
            this.btnIngresarNuevoCliente.TabIndex = 1;
            this.btnIngresarNuevoCliente.Text = "Ingresar Nuevo Cliente";
            this.btnIngresarNuevoCliente.UseVisualStyleBackColor = true;
            this.btnIngresarNuevoCliente.Click += new System.EventHandler(this.btnIngresarNuevoCliente_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(449, 97);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(156, 32);
            this.btnMostrarClientes.TabIndex = 2;
            this.btnMostrarClientes.Text = "Mostrar Clientes";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busqueda de Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Identificación";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(305, 20);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(112, 161);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(305, 20);
            this.txtIdentificacion.TabIndex = 10;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 508);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnIngresarNuevoCliente);
            this.Controls.Add(this.DGMostrarClientes);
            this.Name = "FrmMostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGMostrarClientes;
        private System.Windows.Forms.Button btnIngresarNuevoCliente;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtIdentificacion;
    }
}