namespace ProyectoParentesis.FrmReports
{
    partial class FrmClientesPrimerIngreso
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
            this.DGClientesPrimerIngreso = new System.Windows.Forms.DataGridView();
            this.btnGenerarClientesPrimerIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientesPrimerIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // DGClientesPrimerIngreso
            // 
            this.DGClientesPrimerIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientesPrimerIngreso.Location = new System.Drawing.Point(-7, 85);
            this.DGClientesPrimerIngreso.Name = "DGClientesPrimerIngreso";
            this.DGClientesPrimerIngreso.Size = new System.Drawing.Size(1027, 370);
            this.DGClientesPrimerIngreso.TabIndex = 0;
            // 
            // btnGenerarClientesPrimerIngreso
            // 
            this.btnGenerarClientesPrimerIngreso.Location = new System.Drawing.Point(24, 30);
            this.btnGenerarClientesPrimerIngreso.Name = "btnGenerarClientesPrimerIngreso";
            this.btnGenerarClientesPrimerIngreso.Size = new System.Drawing.Size(203, 32);
            this.btnGenerarClientesPrimerIngreso.TabIndex = 1;
            this.btnGenerarClientesPrimerIngreso.Text = "Generar Clientes Primer Ingreso";
            this.btnGenerarClientesPrimerIngreso.UseVisualStyleBackColor = true;
            this.btnGenerarClientesPrimerIngreso.Click += new System.EventHandler(this.btnGenerarClientesPrimerIngreso_Click);
            // 
            // FrmClientesPrimerIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 449);
            this.Controls.Add(this.btnGenerarClientesPrimerIngreso);
            this.Controls.Add(this.DGClientesPrimerIngreso);
            this.Name = "FrmClientesPrimerIngreso";
            this.Text = "FrmClientesPrimerIngreso";
            this.Load += new System.EventHandler(this.FrmClientesPrimerIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientesPrimerIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGClientesPrimerIngreso;
        private System.Windows.Forms.Button btnGenerarClientesPrimerIngreso;
    }
}