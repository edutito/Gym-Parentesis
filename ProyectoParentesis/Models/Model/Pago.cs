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
        public int? Cliente_id { get; set; }
        public int? Id_Usuario { get; set; }
        public int Monto { get; set; }

        public Cliente getCliente()
        {
            if (this.Cliente_id != null)
                return ClienteRepository.Instance.getData(new Cliente() { Id = (int) this.Cliente_id }).First();
            else return null;
        }

        public Pago(): base()
        {
            this.Cliente_id = null;
            this.Id_Usuario = null;
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
        public List<Pago> getData(Pago cliente, bool like = false)
        {
            String query = this.getDataSearch(cliente, like);
            query += "order by FECHA_INICIO";
            return this.Conexion.getDataTable(query, true).DataTableToList<Pago>();
        }

        public bool ClienteYaPagado(
            DateTime Fecha_Inicio,
            DateTime Fecha_Final,
            int Cliente_id)
        {
            String cmd = "SELECT "+
                         "COUNT(P.ID) " +
                         "FROM Pago AS P " +
                         "WHERE (P.FECHA_INICIO >= {0} AND P.FECHA_FINAL <= {1} ) " +
                         "AND P.CLIENTE_ID = {2} ";
            
            cmd = String.Format(cmd,
                this.parseDateToSql(Fecha_Inicio.Date),
                this.parseDateToSql(Fecha_Final.Date),
                Cliente_id.ToString()
                );

            return this.Conexion.EjecutarComando(cmd) > 0;
        }

        public void MesesAPagar(DateTime Fecha_Inicio,int Cantidad_Meses,Cliente cliente, Usuario usuario,int Monto)
        {
            Pago pago;
            for (int i = 1; i <= Cantidad_Meses; i++)
            {
                pago = new Pago();
                pago.Fecha_Inicio = Fecha_Inicio;
                Fecha_Inicio = Fecha_Inicio.AddMonths(1); // para convetilo en fecha final
                pago.Fecha_Final = Fecha_Inicio;

                pago.Monto= Monto;
                pago.Cliente_id = cliente.Id;
                pago.Id_Usuario = usuario.Id;

                this.persist(pago);

            }

            this.flush();
                       
        }

    }

}
       
    