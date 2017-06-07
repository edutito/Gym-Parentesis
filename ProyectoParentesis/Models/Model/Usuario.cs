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

        public Usuario llenar(
         String Contrasena,
         String Nombre_Usuario,
         String Nombre,
         String Apellido,
         String Estado)
        {
            this.Contrasena = Contrasena;
            this.Nombre_Usuario = Nombre_Usuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Estado = Estado;


            return this;

        }


        public override string ToString()
        {
            return this.Nombre + " " + Apellido;

        }

        public List<Usuario_Permisos> getUsuariosPermisos()
        {
            return Usuario_PermisosRepository.Instance.getData(new Usuario_Permisos()
            {
                Usuario_id = this.Id
            });
        }


    }

    public class UsuarioRepository : Repository
    {
        public const String Activo = "Activo";
        public const String NoActivo = "Inactivo";

        private UsuarioRepository()
            : base()
        {
            this.orderBy = "Nombre ASC";
        }

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
