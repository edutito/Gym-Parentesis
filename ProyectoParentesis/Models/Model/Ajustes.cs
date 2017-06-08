using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;
using System.Data.SqlClient;

namespace Models.Model
{
    public class Ajustes : BaseModel
    {

      
        public int Cantidad { get; set; }
        public String Motivo { get; set; }
        public String Tipo_Ajuste { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public DateTime Fecha { get; set; }

        public Ajustes llenar(
            int Cantidad,
            String Motivo,
            String Tipo_Ajuste,
            int Id_Usuario,
            int Id_Producto,
            DateTime Fecha
         )
        {
            this.Motivo = Motivo;
            this.Cantidad = Cantidad;
            this.Tipo_Ajuste = Tipo_Ajuste;
            this.Id_Usuario = Id_Usuario;
            this.Id_Producto = Id_Producto;
            this.Fecha = DateTime.Now;

            return this;

        }

        public Producto getProducto()
        {
            if (this.Id_Producto != null)
            {
                List<Producto> list = ProductoRepository.Instance.getData(new Producto() { Id = (int)this.Id_Producto }, false);
                return list.First();
            }
            else return null;
        }

       

    }

    public class AjustesRepository : Repository
    {
        private AjustesRepository()
            : base()
        {
            this.orderBy = " Fecha_Creacion DESC";
        }

        public const string Salida ="Negativa";
        public const string Entrada = "Aumento";
     
        private static AjustesRepository instance;

        public static AjustesRepository Instance
        {
            get
            {
                return instance ?? (instance = new AjustesRepository());
            }
        }



        public List<Ajustes> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Ajustes>();
        }

        public List<Ajustes> getData(Ajustes Ajus, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(Ajus, like), true).DataTableToList<Ajustes>();
        }

        public void crear(Ajustes ajus)
        {
            Producto producto = ajus.getProducto();
            producto.Cantidad += ajus.Cantidad;
            ProductoRepository.Instance.persist(producto).flush();
            this.persist(ajus).flush();
        }

        


    }
}
