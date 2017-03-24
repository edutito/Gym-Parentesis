using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;

namespace Models.Model
{
    public class Permisos : BaseModel
    {
        public String Nombre { get; set; }
       

    }

    public class PermisosRepository : Repository {

        public List<Permisos> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Permisos>();
        }
        private static PermisosRepository instance;
        public static PermisosRepository Instance
        {
            get
            {
                return instance ?? (instance = new PermisosRepository());
            }
        }
    }
}


