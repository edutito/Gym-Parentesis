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
        public int Monto { get; set; }

        public Cliente getCliente()
        {
            return ClienteRepository.Instance.getData(new Cliente() { Id = this.Cliente_id }).First();
        }

        public Pago llenar(
            DateTime Fecha_Inicio,
            DateTime Fecha_Final,
            int Cliente_id,
            int Id_Usuario,
            int Monto
            )
        {
            this.Fecha_Inicio = Fecha_Inicio;
            this.Fecha_Final = Fecha_Final;
            this.Cliente_id = Cliente_id;
            this.Id_Usuario = Id_Usuario;
            this.Monto = Monto;

            return this;
        }
    }

    public class PagoRepository : Repository {

        public const int MONTO = 20000;
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

        public bool ClienteYaPagado(
            DateTime Fecha_Inicio,
            DateTime Fecha_Final,
            int Cliente_id)
        {
            String cmd = "SELECT "+
                         "COUNT(P.ID) " +
                         "FROM Pago AS P " +
                         "WHERE P.FECHA_INICIO >= {0} " +
                         "AND P.FECHA_FINAL <= {1} "+
                         "AND P.CLIENTE_ID = {2}";
            cmd = String.Format(cmd,
                this.parseDateToSql(Fecha_Inicio),
                this.parseDateToSql(Fecha_Final),
                Cliente_id.ToString()
                );

            return this.Conexion.EjecutarComando(cmd) > 0;
        }

    }

}
       
    