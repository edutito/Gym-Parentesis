using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;

namespace Models.Model
{
    public class Usuario_Permisos : BaseModel
    {

        public int? Permiso_id { get; set; }
        public int? Usuario_id { get; set; }


        public Usuario getUsuario()
        {
            if (this.Usuario_id != null)
                return UsuarioRepository.Instance.getData(new Usuario() { Id = ((int)this.Usuario_id) }).First();
            else return null;
        }

        public Permisos getPermiso()
        {
            if (this.Permiso_id != null)
            {
                Permisos p = new Permisos() { Id = (int)this.Permiso_id };
                return PermisosRepository.Instance.getData(p).First();
            }
            else return null;
        }

        public Usuario_Permisos ():base() {
            this.Usuario_id = null;
            this.Permiso_id = null;
        }

    }

   

    public class Usuario_PermisosRepository : Repository {

        public List<Usuario_Permisos> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Usuario_Permisos>();
        }

        private static Usuario_PermisosRepository instance;
        public static Usuario_PermisosRepository Instance
        {
            get
            {
                return instance ?? (instance = new Usuario_PermisosRepository());
            }
        }
      


        public List<Usuario_Permisos> getData(Usuario_Permisos usuario, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(usuario, like), true).DataTableToList<Usuario_Permisos>();
        }


        public void delete(Usuario_Permisos per)
        {
            String cmd = "DELETE " + this.table + " WHERE Usuario_id =" + per.Usuario_id;
            this.Conexion.EjecutarComando(cmd);
        }


    }

      
}
