using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
   public class Usuario : BaseModel
    {
        public String Contrasena { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Estado { get; set; }

    }

   public class UsuarioRepository : Repository {
       public const String Activo = "Activo";
       public const String NoActivo = "Inactivo";

       public List<String> getEstados()
       {
           return new List<String> { Activo, NoActivo };
       }


       private static UsuarioRepository instance;
       public static UsuarioRepository Instance
       {
           get
           {
               return instance ?? (instance = new UsuarioRepository());
           }
       }

       public List<Usuario> getData()
       {
           return this.Conexion.getData(this.table).DataTableToList<Usuario>();
       }

       public List<Usuario> getData(Usuario usuario, bool like = false)
       {
           return this.Conexion.getDataTable(this.getDataSearch(usuario, like), true).DataTableToList<Usuario>();
       }



   }
}
