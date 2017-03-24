using System;
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
        public int Monto { get; set; }
        public int Cliente_id { get; set; }
       
    


    }

     public class Pago_MatriculaRepository : Repository {

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
     }

      
}
