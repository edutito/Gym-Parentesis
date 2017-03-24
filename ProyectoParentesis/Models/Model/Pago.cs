using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;


namespace Models.Model
{
    public class Pago : BaseModel
    {

        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Final { get; set; }
        public int Cliente_id { get; set; }
        
        public int Id_Usuario { get; set; }


    }

    public class    PagoRepository : Repository {

        public List<Pago> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Pago>();
        }
               private static PagoRepository instance;
        public static PagoRepository Instance
        {
            get
            {
                return instance ?? (instance = new PagoRepository());
            }
        }

    }

}
       
    