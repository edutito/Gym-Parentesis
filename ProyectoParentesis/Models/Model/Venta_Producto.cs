using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
    public class Venta_Producto : BaseModel
    {

        public String Nombre_persona { get; set; }
        public int Monto { get; set; }
        public int Id_Usuario { get; set; }

      
    }

    public class Venta_ProductoRepository : Repository {

        public List<Venta_Producto> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Venta_Producto>();
        }
        public List<Venta_Producto> getData(Venta_Producto cliente, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(cliente, like), true).DataTableToList<Venta_Producto>();
        }

        private static Venta_ProductoRepository instance;
        public static Venta_ProductoRepository Instance
        {
            get
            {
                return instance ?? (instance = new Venta_ProductoRepository());
            }
        }

        public Venta_Producto save(Venta_Producto venta_producto)
        {
            this.persist(venta_producto).flush();
            venta_producto.Id = this.getMaxIdentificador() -1 ;
            return this.getData(venta_producto).First();
        }
    }
}
