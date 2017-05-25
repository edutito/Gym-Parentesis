using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
     public class Instructor : BaseModel
    {

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String Estado { get; set; }
        public String Telefono { get; set; }


        public Instructor llenar(
            String Nombre,
            String Apellido,
            String Direccion,
            String Telefono,
            String Estado
            )
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Estado = Estado;

            return this;

        }

    }

    public class InstructorRepository : Repository
    {        
        public const String Activo = "Activo";
        public const String NoActivo = "Inactivo";

        public List<String> getEstados()
        {
            return new List<String> { Activo, NoActivo };
        }

        private InstructorRepository() : base()
        {
            this.orderBy = "Nombre ASC";
        }

        private static InstructorRepository instance;
        public static InstructorRepository Instance
        {
            get
            {
                return instance ?? (instance = new InstructorRepository());
            }
        }

        public List<Instructor> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Instructor>();
        }

        public List<Instructor> getData(Instructor cliente, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(cliente, like), true).DataTableToList<Instructor>();
        }

    }

}
