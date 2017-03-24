﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
    public class Cliente : BaseModel
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String DNI { get; set; }

        public Cliente llenar(String Nombre,
            String Apellido,
            String Telefono,
            String Direccion,
            String Estado,
            DateTime Fecha_Ingreso,
            String DNI)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Estado = Estado;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.DNI = DNI;

            return this; 

        }

    }

    public class ClienteRepository : Repository
    {

        public const String Activo = "Activo";
        public const String NoActivo = "Inactivo";

        public List<String> getEstados()
        {
            return new List<String> { Activo, NoActivo };
        }

        private static ClienteRepository instance;
        public static ClienteRepository Instance
        {
            get
            {
                return instance ?? (instance = new ClienteRepository());
            }
        }

        public List<Cliente> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Cliente>();
        }

        public List<Cliente> getData(Cliente cliente, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(cliente, like), true).DataTableToList<Cliente>();
        }

    }




}