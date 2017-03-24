using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;

namespace Models.Model
{
   public class Entrada_Producto : BaseModel
    {
        public String Nombre { get; set; }
        public int producto_id { get; set; }
        public int Cantidad { get; set; }
        public int Producto_id { get; set; }





    }

   public class Entrada_ProductoRepository : Repository {

       public List<Entrada_Producto> getData()
       {
           return this.Conexion.getData(this.table).DataTableToList<Entrada_Producto>();
       }
       private static Entrada_ProductoRepository instance;
        public static Entrada_ProductoRepository Instance
        {
            get
            {
                return instance ?? (instance = new Entrada_ProductoRepository());
            }
        }

   }

   
}
