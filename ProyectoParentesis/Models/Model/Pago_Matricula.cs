﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
     public class Pago_Matricula : BaseModel
    {
        public String Nombre_Cliente { get; set; }
        public String Apellido { get; set; }
        public int? Monto  { get; set; }
        public int? Cliente_id { get; set; }

        public Pago_Matricula llenar(
        String Nombre_Cliente,
        String Apellido,
        int Monto,
        int Cliente_id 
        )
        {

            this.Nombre_Cliente = Nombre_Cliente;
            this.Apellido = Apellido;
            this.Monto = Monto;
            this.Cliente_id = Cliente_id;

            return this;
        }
        public Pago_Matricula()
        {
            this.Monto = null;
            this.Cliente_id = null;

        }

        public Cliente getCliente() {
            return ClienteRepository.Instance.getData(new Cliente() {Id = (int)this.Cliente_id }).First();
        }


    }

     public class Pago_MatriculaRepository : Repository {    

        private Pago_MatriculaRepository(): base() {
            this.orderBy = "Fecha_Creacion DESC";
        }

        public List<Pago_Matricula> getData()
         {
             return this.Conexion.getData(this.table).DataTableToList<Pago_Matricula>();
         } 
         
        private static Pago_MatriculaRepository instance;
        public static Pago_MatriculaRepository Instance
        {
            get
            {
                return instance ?? (instance = new Pago_MatriculaRepository());
            }
        }

        public List<Pago_Matricula> getData(Pago_Matricula pago_matricula, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(pago_matricula, like), true).DataTableToList<Pago_Matricula>();
        }


     }

      
}
