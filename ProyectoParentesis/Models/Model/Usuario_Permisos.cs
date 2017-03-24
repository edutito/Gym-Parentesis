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

        public int Permiso_id { get; set; }
        public int Usuario_id { get; set; }
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

    }
}
