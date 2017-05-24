namespace ProyectoParentesis.FProductos
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.DGMostrarProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 97);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(305, 20);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 20);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Busqueda de Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(482, 109);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(192, 30);
            this.btnMostrarProductos.TabIndex = 22;
            this.btnMostrarProductos.Text = "Mostrar Productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Location = new System.Drawing.Point(482, 39);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(192, 34);
            this.btnIngresarProducto.TabIndex = 21;
            this.btnIngresarProducto.Text = "Ingresar Nuevo Producto";
            this.btnIngresarProducto.UseVisualStyleBackColor = true;
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // DGMostrarProductos
            // 
            this.DGMostrarProductos.AllowUserToAddRows = false;
            this.DGMostrarProductos.AllowUserToDeleteRows = false;
            this.DGMostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarProductos.Location = new System.Drawing.Point(0, 166);
            this.DGMostrarProductos.Name = "DGMostrarProductos";
            this.DGMostrarProductos.ReadOnly = true;
            this.DGMostrarProductos.Size = new System.Drawing.Size(846, 229);
            this.DGMostrarProductos.TabIndex = 20;
            this.DGMostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMostrarProductos_CellContentClick);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 395);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.btnIngresarProducto);
            this.Controls.Add(this.DGMostrarProductos);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnIngresarProducto;
        private System.Windows.Forms.DataGridView DGMostrarProductos;
    }
}