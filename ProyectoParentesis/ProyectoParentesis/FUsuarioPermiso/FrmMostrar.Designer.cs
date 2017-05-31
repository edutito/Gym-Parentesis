namespace ProyectoParentesis.FUsuarioPermiso
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
            this.cmbBuscarUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnIngresarUsuarioYPermiso = new System.Windows.Forms.Button();
            this.DGMostrarUsuariosYPermisos = new System.Windows.Forms.DataGridView();
            this.cmbBuscarPermiso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarUsuariosYPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscarUsuario
            // 
            this.cmbBuscarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarUsuario.FormattingEnabled = true;
            this.cmbBuscarUsuario.Location = new System.Drawing.Point(136, 45);
            this.cmbBuscarUsuario.Name = "cmbBuscarUsuario";
            this.cmbBuscarUsuario.Size = new System.Drawing.Size(272, 21);
            this.cmbBuscarUsuario.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Busqueda de Usuarios y Permisos";
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(482, 100);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(211, 30);
            this.btnMostrarUsuarios.TabIndex = 39;
            this.btnMostrarUsuarios.Text = "Mostrar Usuarios y Permisos";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnIngresarUsuarioYPermiso
            // 
            this.btnIngresarUsuarioYPermiso.Location = new System.Drawing.Point(482, 37);
            this.btnIngresarUsuarioYPermiso.Name = "btnIngresarUsuarioYPermiso";
            this.btnIngresarUsuarioYPermiso.Size = new System.Drawing.Size(211, 34);
            this.btnIngresarUsuarioYPermiso.TabIndex = 38;
            this.btnIngresarUsuarioYPermiso.Text = "Ingresar Nuevo Usuario ";
            this.btnIngresarUsuarioYPermiso.UseVisualStyleBackColor = true;
            this.btnIngresarUsuarioYPermiso.Click += new System.EventHandler(this.btnIngresarUsuarioYPermiso_Click);
            // 
            // DGMostrarUsuariosYPermisos
            // 
            this.DGMostrarUsuariosYPermisos.AllowUserToAddRows = false;
            this.DGMostrarUsuariosYPermisos.AllowUserToDeleteRows = false;
            this.DGMostrarUsuariosYPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarUsuariosYPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarUsuariosYPermisos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarUsuariosYPermisos.Location = new System.Drawing.Point(0, 150);
            this.DGMostrarUsuariosYPermisos.Name = "DGMostrarUsuariosYPermisos";
            this.DGMostrarUsuariosYPermisos.ReadOnly = true;
            this.DGMostrarUsuariosYPermisos.Size = new System.Drawing.Size(817, 229);
            this.DGMostrarUsuariosYPermisos.TabIndex = 37;
            // 
            // cmbBuscarPermiso
            // 
            this.cmbBuscarPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPermiso.FormattingEnabled = true;
            this.cmbBuscarPermiso.Location = new System.Drawing.Point(136, 91);
            this.cmbBuscarPermiso.Name = "cmbBuscarPermiso";
            this.cmbBuscarPermiso.Size = new System.Drawing.Size(272, 21);
            this.cmbBuscarPermiso.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Permiso";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 379);
            this.Controls.Add(this.cmbBuscarPermiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscarUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.btnIngresarUsuarioYPermiso);
            this.Controls.Add(this.DGMostrarUsuariosYPermisos);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarUsuariosYPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscarUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnIngresarUsuarioYPermiso;
        private System.Windows.Forms.DataGridView DGMostrarUsuariosYPermisos;
        private System.Windows.Forms.ComboBox cmbBuscarPermiso;
        private System.Windows.Forms.Label label2;
    }
}