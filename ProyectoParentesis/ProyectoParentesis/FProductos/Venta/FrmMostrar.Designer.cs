﻿namespace ProyectoParentesis.FProductos.Venta
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
            this.cmbEntradaProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarVentaProductos = new System.Windows.Forms.Button();
            this.btnIngresarVentaProducto = new System.Windows.Forms.Button();
            this.DGMostrarEntradaProductos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarEntradaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEntradaProductos
            // 
            this.cmbEntradaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntradaProductos.FormattingEnabled = true;
            this.cmbEntradaProductos.Location = new System.Drawing.Point(133, 46);
            this.cmbEntradaProductos.Name = "cmbEntradaProductos";
            this.cmbEntradaProductos.Size = new System.Drawing.Size(272, 21);
            this.cmbEntradaProductos.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Busqueda de Venta  de Productos";
            // 
            // btnMostrarVentaProductos
            // 
            this.btnMostrarVentaProductos.Location = new System.Drawing.Point(646, 109);
            this.btnMostrarVentaProductos.Name = "btnMostrarVentaProductos";
            this.btnMostrarVentaProductos.Size = new System.Drawing.Size(211, 30);
            this.btnMostrarVentaProductos.TabIndex = 39;
            this.btnMostrarVentaProductos.Text = "Mostrar las Ventas de  Productos";
            this.btnMostrarVentaProductos.UseVisualStyleBackColor = true;
            // 
            // btnIngresarVentaProducto
            // 
            this.btnIngresarVentaProducto.Location = new System.Drawing.Point(646, 46);
            this.btnIngresarVentaProducto.Name = "btnIngresarVentaProducto";
            this.btnIngresarVentaProducto.Size = new System.Drawing.Size(211, 34);
            this.btnIngresarVentaProducto.TabIndex = 38;
            this.btnIngresarVentaProducto.Text = "Ingresar Nueva Venta de  Producto";
            this.btnIngresarVentaProducto.UseVisualStyleBackColor = true;
            this.btnIngresarVentaProducto.Click += new System.EventHandler(this.btnIngresarVentaProducto_Click);
            // 
            // DGMostrarEntradaProductos
            // 
            this.DGMostrarEntradaProductos.AllowUserToAddRows = false;
            this.DGMostrarEntradaProductos.AllowUserToDeleteRows = false;
            this.DGMostrarEntradaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarEntradaProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarEntradaProductos.Location = new System.Drawing.Point(0, 196);
            this.DGMostrarEntradaProductos.Name = "DGMostrarEntradaProductos";
            this.DGMostrarEntradaProductos.ReadOnly = true;
            this.DGMostrarEntradaProductos.Size = new System.Drawing.Size(869, 229);
            this.DGMostrarEntradaProductos.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Producto";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 425);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEntradaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarVentaProductos);
            this.Controls.Add(this.btnIngresarVentaProducto);
            this.Controls.Add(this.DGMostrarEntradaProductos);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarEntradaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEntradaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarVentaProductos;
        private System.Windows.Forms.Button btnIngresarVentaProducto;
        private System.Windows.Forms.DataGridView DGMostrarEntradaProductos;
        private System.Windows.Forms.Label label7;
    }
}