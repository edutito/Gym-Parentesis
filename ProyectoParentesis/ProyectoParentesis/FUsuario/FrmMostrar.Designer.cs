namespace ProyectoParentesis.FUsuario
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnIngresarNuevoUsuario = new System.Windows.Forms.Button();
            this.DGMostrarUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarUsuarios)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Busqueda de Usuarios";
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(511, 102);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(156, 34);
            this.btnMostrarUsuarios.TabIndex = 13;
            this.btnMostrarUsuarios.Text = "Mostrar Usuarios";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // btnIngresarNuevoUsuario
            // 
            this.btnIngresarNuevoUsuario.Location = new System.Drawing.Point(511, 44);
            this.btnIngresarNuevoUsuario.Name = "btnIngresarNuevoUsuario";
            this.btnIngresarNuevoUsuario.Size = new System.Drawing.Size(156, 28);
            this.btnIngresarNuevoUsuario.TabIndex = 12;
            this.btnIngresarNuevoUsuario.Text = "Ingresar Nuevo Usuario";
            this.btnIngresarNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnIngresarNuevoUsuario.Click += new System.EventHandler(this.btnIngresarNuevoUsuario_Click);
            // 
            // DGMostrarUsuarios
            // 
            this.DGMostrarUsuarios.AllowUserToAddRows = false;
            this.DGMostrarUsuarios.AllowUserToDeleteRows = false;
            this.DGMostrarUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMostrarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMostrarUsuarios.Location = new System.Drawing.Point(0, 160);
            this.DGMostrarUsuarios.Name = "DGMostrarUsuarios";
            this.DGMostrarUsuarios.ReadOnly = true;
            this.DGMostrarUsuarios.Size = new System.Drawing.Size(857, 291);
            this.DGMostrarUsuarios.TabIndex = 11;
            this.DGMostrarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMostrarUsuarios_CellContentClick);
            this.DGMostrarUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGMostrarUsuarios_CellMouseClick);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 451);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.btnIngresarNuevoUsuario);
            this.Controls.Add(this.DGMostrarUsuarios);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnIngresarNuevoUsuario;
        private System.Windows.Forms.DataGridView DGMostrarUsuarios;
    }
}