using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
   public class Producto : BaseModel

    {
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        
        public String Estado { get; set; }


    }

   public class ProductoRepository : Repository
   {

       public List<Producto> getData()
       {
           return this.Conexion.getData(this.table).DataTableToList<Producto>();
       }

       private static ProductoRepository instance;
       public static ProductoRepository Instance
       {
           get
           {
               return instance ?? (instance = new ProductoRepository());
           }
       }

   }
}
