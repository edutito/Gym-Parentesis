namespace ProyectoParentesis.FProductos.Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.DGMostrarEntradaProductos = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarEntradaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Busqueda de Entradas de Productos";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(482, 101);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(211, 30);
            this.btnMostrarProductos.TabIndex = 30;
            this.btnMostrarProductos.Text = "Mostrar las Entradas de  Productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Location = new System.Drawing.Point(482, 38);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(211, 34);
            this.btnIngresarProducto.TabIndex = 29;
            this.btnIngresarProducto.Text = "Ingresar Nueva Entrada de  Producto";
            this.btnIngresarProducto.UseVisualStyleBackColor = true;
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // DGMostrarEntradaProductos
            // 
            this.DGMostrarEntradaProductos.AllowUserToAddRows = false;
            this.DGMostrarEntradaProductos.AllowUserToDeleteRows = false;
            this.DGMostrarEntradaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarEntradaProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarEntradaProductos.Location = new System.Drawing.Point(0, 147);
            this.DGMostrarEntradaProductos.Name = "DGMostrarEntradaProductos";
            this.DGMostrarEntradaProductos.ReadOnly = true;
            this.DGMostrarEntradaProductos.Size = new System.Drawing.Size(864, 229);
            this.DGMostrarEntradaProductos.TabIndex = 28;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(134, 69);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(272, 21);
            this.cmbClientes.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Producto";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 376);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.btnIngresarProducto);
            this.Controls.Add(this.DGMostrarEntradaProductos);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarEntradaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnIngresarProducto;
        private System.Windows.Forms.DataGridView DGMostrarEntradaProductos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label7;
    }
}