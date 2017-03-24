﻿namespace ProyectoParentesis
{
    partial class Formu_Principal
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.intructoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarClientesPrimerIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarClientesActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMayorVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMayorEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perrmisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimiento,
            this.administracionToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(782, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_Clientes,
            this.intructoresToolStripMenuItem});
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Size = new System.Drawing.Size(101, 20);
            this.Mantenimiento.Text = "Mantenimiento";
            this.Mantenimiento.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Item_Clientes
            // 
            this.Item_Clientes.Name = "Item_Clientes";
            this.Item_Clientes.Size = new System.Drawing.Size(152, 22);
            this.Item_Clientes.Text = "Clientes";
            this.Item_Clientes.Click += new System.EventHandler(this.fdToolStripMenuItem_Click);
            // 
            // intructoresToolStripMenuItem
            // 
            this.intructoresToolStripMenuItem.Name = "intructoresToolStripMenuItem";
            this.intructoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intructoresToolStripMenuItem.Text = "Instructores";
            this.intructoresToolStripMenuItem.Click += new System.EventHandler(this.intructoresToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagosMatriculaToolStripMenuItem,
            this.registroPagosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarClientesPrimerIngresoToolStripMenuItem,
            this.generarClientesActivosToolStripMenuItem,
            this.productosMayorVentaToolStripMenuItem,
            this.productosMayorEntradaToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perrmisosToolStripMenuItem,
            this.cambioContraseñaToolStripMenuItem,
            this.respaldosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pagosMatriculaToolStripMenuItem
            // 
            this.pagosMatriculaToolStripMenuItem.Name = "pagosMatriculaToolStripMenuItem";
            this.pagosMatriculaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pagosMatriculaToolStripMenuItem.Text = "Pagos Matricula";
            // 
            // registroPagosToolStripMenuItem
            // 
            this.registroPagosToolStripMenuItem.Name = "registroPagosToolStripMenuItem";
            this.registroPagosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.registroPagosToolStripMenuItem.Text = "Registro Pagos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // generarClientesPrimerIngresoToolStripMenuItem
            // 
            this.generarClientesPrimerIngresoToolStripMenuItem.Name = "generarClientesPrimerIngresoToolStripMenuItem";
            this.generarClientesPrimerIngresoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.generarClientesPrimerIngresoToolStripMenuItem.Text = "Generar Clientes Primer Ingreso";
            // 
            // generarClientesActivosToolStripMenuItem
            // 
            this.generarClientesActivosToolStripMenuItem.Name = "generarClientesActivosToolStripMenuItem";
            this.generarClientesActivosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.generarClientesActivosToolStripMenuItem.Text = "Generar Clientes Activos";
            // 
            // productosMayorVentaToolStripMenuItem
            // 
            this.productosMayorVentaToolStripMenuItem.Name = "productosMayorVentaToolStripMenuItem";
            this.productosMayorVentaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.productosMayorVentaToolStripMenuItem.Text = "Productos Mayor Venta";
            // 
            // productosMayorEntradaToolStripMenuItem
            // 
            this.productosMayorEntradaToolStripMenuItem.Name = "productosMayorEntradaToolStripMenuItem";
            this.productosMayorEntradaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.productosMayorEntradaToolStripMenuItem.Text = "Productos Mayor Entrada";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // perrmisosToolStripMenuItem
            // 
            this.perrmisosToolStripMenuItem.Name = "perrmisosToolStripMenuItem";
            this.perrmisosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.perrmisosToolStripMenuItem.Text = "Perrmisos";
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            this.cambioContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambioContraseñaToolStripMenuItem.Text = "Cambio Contraseña ";
            // 
            // respaldosToolStripMenuItem
            // 
            this.respaldosToolStripMenuItem.Name = "respaldosToolStripMenuItem";
            this.respaldosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.respaldosToolStripMenuItem.Text = "Respaldos";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // Formu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 314);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Formu_Principal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Formu_Principal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem Item_Clientes;
        private System.Windows.Forms.ToolStripMenuItem intructoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarClientesPrimerIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarClientesActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMayorVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMayorEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perrmisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
    }
}