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
        public int? Cantidad { get; set; }
        public int? Producto_id { get; set; }


   
       public Entrada_Producto llenar(      
      
            int Cantidad,
            int Producto_id
        )
        {
            this.Producto_id = Producto_id;
            this.Cantidad = Cantidad;
            return this;
        }

       public Entrada_Producto(): base()
        {
            this.Cantidad = null;
            this.Producto_id = null;
        }
        

       

        public Producto getProducto()
        {
            if (this.Producto_id != null)
            {
                List<Producto> list = ProductoRepository.Instance.getData(new Producto() { Id = (int)this.Producto_id }, false);
                return list.First();
            }
            else return null;
        }

    }

   public class Entrada_ProductoRepository : Repository {

        
        public List<Entrada_Producto> getData()
        {
           return this.Conexion.getData(this.table).DataTableToList<Entrada_Producto>();
        }
        
        private Entrada_ProductoRepository(): base() {
            this.orderBy = "Fecha_Creacion DESC";
        }

        private static Entrada_ProductoRepository instance;
        public static Entrada_ProductoRepository Instance
        {
            get
            {
                return instance ?? (instance = new Entrada_ProductoRepository());
            }
        }


        public void crear(Entrada_Producto entrada)
        {
            Producto producto = entrada.getProducto();
            producto.Cantidad += entrada.Cantidad;
            ProductoRepository.Instance.persist(producto).flush();
            this.persist(entrada).flush();
        }


        public List<Entrada_Producto> getData(Entrada_Producto producto, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(producto, like), true).DataTableToList<Entrada_Producto>();
        }

  


   }


   
}
