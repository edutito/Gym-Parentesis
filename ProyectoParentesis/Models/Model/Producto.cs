using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;
using System.Data.SqlClient;

namespace Models.Model
{
   public class Producto : BaseModel

    {
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public int? Cantidad { get; set; }
        public int? Precio { get; set; }        
        public String Estado { get; set; }

        public Producto llenar(
         String Nombre,
         String Codigo,         
         int Precio,
         String Estado
            )
        {
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.Cantidad = 0;
            this.Precio = Precio;
            this.Estado = Estado;        
            return this;

        }

        public override String ToString()
        {
            return this.Nombre;
        }

        public Producto()
        {
            this.Cantidad = null;
            this.Precio = null;
        }
    }

   public class ProductoRepository : Repository {
        public const String Activo = "En Existencia";
        public const String NoActivo = "Agotado";        

        private ProductoRepository(): base() {
            this.orderBy = "Nombre ASC";
        }

        public List<String> getEstados()
       {
           return new List<String> { Activo, NoActivo };
       }
   

       public List<Producto> getData()
       {
           return this.Conexion.getData(this.table).DataTableToList<Producto>();
       }

       public List<Producto> getData(Producto producto, bool like = false)
       {
           return this.Conexion.getDataTable(this.getDataSearch(producto, like), true).DataTableToList<Producto>();
       }

       private static ProductoRepository instance;
       public static ProductoRepository Instance
       {
           get
           {
               return instance ?? (instance = new ProductoRepository());
           }
       }

       public SqlDataReader getProductosMasVendidos(){
        String sql = "SELECT Top 30 P.Nombre, " +
                                  "P.Precio, " +
                                  "P.Codigo, " +
                                  "P.Cantidad, " +
                                  "Sum(D.cantidad) AS cantidad_vendida " +
                    "FROM Producto AS P " +
                    "INNER JOIN Venta_Producto_Detalle AS D ON P.id = D.producto_id " +
                    "GROUP BY D.producto_id , " +
                             "P.id, " +
                             "P.Codigo, " +
                             "P.Nombre, " +
                             "P.Precio, " +
                             "P.Cantidad " +
                    "ORDER BY cantidad_vendida DESC ";

          return this.Conexion.getDataReader(sql);
       }

       public SqlDataReader getProductosMasEntrada(){
          String sql = "SELECT Top 30 P.Nombre, "+
                                    "P.Precio, "+
                                    "P.Codigo, "+
                                    "P.Cantidad, "+
                                    "Sum(D.Cantidad) AS cantidad_entrada "+
                      "FROM Producto AS P "+
                      "INNER JOIN Entrada_Producto AS D ON P.id = D.Producto_id "+
                      "GROUP BY D.producto_id , "+
                      "         P.id, "+
                      "         P.Codigo, "+
                      "         P.Nombre, "+
                      "         P.Precio, "+
                      "         P.Cantidad "+
                      "ORDER BY cantidad_entrada DESC ";
          return this.Conexion.getDataReader(sql);
       }

   }
}

