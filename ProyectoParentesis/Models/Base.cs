using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime Fecha_Creacion { get; set; }

        public DateTime Fecha_Actualizacion { get; set; }


        public BaseModel()
        {
            this.Id = -1;
        }

    }
}