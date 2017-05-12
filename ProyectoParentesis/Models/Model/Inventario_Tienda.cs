using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;
using Models;

namespace Models.Model
{
     public class Inventario_Tienda : BaseModel
    {
        public String Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public String Codigo { get; set; }
        
         
    }


     public class Inventario_TiendaRepository : Repository
     {
         private static Inventario_TiendaRepository instance;
         public static Inventario_TiendaRepository Instance
         {
             get
             {
                 return instance ?? (instance = new Inventario_TiendaRepository());
             }
         } 

         public List<Inventario_Tienda> getData()
         {
             return this.Conexion.getData(this.table).DataTableToList<Inventario_Tienda>();
         }

         public List<Inventario_Tienda> getData(Inventario_Tienda cliente, bool like = false)
         {
             return this.Conexion.getDataTable(this.getDataSearch(cliente, like), true).DataTableToList<Inventario_Tienda>();
         }

     }


}
