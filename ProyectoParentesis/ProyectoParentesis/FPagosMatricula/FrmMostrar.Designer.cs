namespace ProyectoParentesis.FPagosMatricula
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarPagosMatriculas = new System.Windows.Forms.Button();
            this.btnIngresarPagoMatricula = new System.Windows.Forms.Button();
            this.DGMostrarClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(112, 156);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(305, 20);
            this.txtIdentificacion.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(305, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Busqueda Pago Matricula";
            // 
            // btnMostrarPagosMatriculas
            // 
            this.btnMostrarPagosMatriculas.Location = new System.Drawing.Point(482, 111);
            this.btnMostrarPagosMatriculas.Name = "btnMostrarPagosMatriculas";
            this.btnMostrarPagosMatriculas.Size = new System.Drawing.Size(192, 30);
            this.btnMostrarPagosMatriculas.TabIndex = 13;
            this.btnMostrarPagosMatriculas.Text = "Mostrar Clientes con Matricula Paga";
            this.btnMostrarPagosMatriculas.UseVisualStyleBackColor = true;
            // 
            // btnIngresarPagoMatricula
            // 
            this.btnIngresarPagoMatricula.Location = new System.Drawing.Point(482, 41);
            this.btnIngresarPagoMatricula.Name = "btnIngresarPagoMatricula";
            this.btnIngresarPagoMatricula.Size = new System.Drawing.Size(192, 34);
            this.btnIngresarPagoMatricula.TabIndex = 12;
            this.btnIngresarPagoMatricula.Text = "Ingresar Nuevo Pago de Matricula";
            this.btnIngresarPagoMatricula.UseVisualStyleBackColor = true;
            // 
            // DGMostrarClientes
            // 
            this.DGMostrarClientes.AllowUserToAddRows = false;
            this.DGMostrarClientes.AllowUserToDeleteRows = false;
            this.DGMostrarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarClientes.Location = new System.Drawing.Point(0, 183);
            this.DGMostrarClientes.Name = "DGMostrarClientes";
            this.DGMostrarClientes.ReadOnly = true;
            this.DGMostrarClientes.Size = new System.Drawing.Size(868, 266);
            this.DGMostrarClientes.TabIndex = 11;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 449);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarPagosMatriculas);
            this.Controls.Add(this.btnIngresarPagoMatricula);
            this.Controls.Add(this.DGMostrarClientes);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarPagosMatriculas;
        private System.Windows.Forms.Button btnIngresarPagoMatricula;
        private System.Windows.Forms.DataGridView DGMostrarClientes;
    }
}