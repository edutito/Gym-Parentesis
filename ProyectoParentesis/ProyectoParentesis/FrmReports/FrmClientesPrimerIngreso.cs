﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Model; 


namespace ProyectoParentesis.FrmReports
{
    public partial class FrmClientesPrimerIngreso : Form
    {
        public FrmClientesPrimerIngreso()
        {
            InitializeComponent();
            this.ColocarColumnas();
            this.LlenarData(
               ClienteRepository.Instance.getClientesPrimerIngreso()
                );

        }

        private void FrmClientesPrimerIngreso_Load(object sender, EventArgs e)
        {
            
        }

        private void ColocarColumnas()
        {

            this.DGClientesPrimerIngreso.Columns.Add("Nombre", "Nombre");
            this.DGClientesPrimerIngreso.Columns.Add("Apellido", "Apellidos");
            this.DGClientesPrimerIngreso.Columns.Add("Telefono", "Teléfono");
            this.DGClientesPrimerIngreso.Columns.Add("Direccion", "Direccíon");
            this.DGClientesPrimerIngreso.Columns.Add("Estado", "Estado");
            this.DGClientesPrimerIngreso.Columns.Add("Fecha_Ingreso", "Fecha de Ingreso");
            this.DGClientesPrimerIngreso.Columns.Add("DNI", "Identificacíon");
            this.DGClientesPrimerIngreso.Columns.Add("Id", "Id");

            this.DGClientesPrimerIngreso.Columns["Id"].Visible = false;


        }

        private void LlenarData(List<Cliente> Clientes)
        {

            //this.DGMostrarClientes.DataSource = Clientes;w
            this.DGClientesPrimerIngreso.Rows.Clear();

            foreach (Cliente cliente in Clientes)
            {
                DataGridViewRow row = new DataGridViewRow();

                this.DGClientesPrimerIngreso.Rows.Add(
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Estado,
                    cliente.Fecha_Ingreso,
                    cliente.DNI,
                    cliente.Id
                    );
            }

            this.AcomodarColumnas();
        }


        private void AcomodarColumnas()
        {


            int colCount = this.DGClientesPrimerIngreso.Columns.Count;
            colCount = colCount - 1; // =5
            for (int i = 0; i < colCount; i++)
            {
                this.DGClientesPrimerIngreso.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnGenerarClientesPrimerIngreso_Click(object sender, EventArgs e)
        {
            this.LlenarData(
               ClienteRepository.Instance.getClientesPrimerIngreso()
                );
        }

       

    }
  }

