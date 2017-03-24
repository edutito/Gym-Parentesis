using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
    public class Venta_Producto_Detalle : BaseModel

    {
        public String Nombre { get; set; }
        public int Venta_Producto_id { get; set; }
        public int Cantidad { get; set; }
        public int producto_id { get; set; }

    }

    public class Venta_Producto_DetalleRepository : Repository {

        public List<Venta_Producto_Detalle> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Venta_Producto_Detalle>();
        }

        private static Venta_Producto_DetalleRepository instance;
        public static Venta_Producto_DetalleRepository Instance
        {
            get
            {
                return instance ?? (instance = new Venta_Producto_DetalleRepository());
            }
        }

    }
}
