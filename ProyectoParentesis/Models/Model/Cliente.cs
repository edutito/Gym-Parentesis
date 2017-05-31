using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Extensions;
using System.Data.SqlClient;

namespace Models.Model
{
    public class Cliente : BaseModel
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String DNI { get; set; }

        public Cliente llenar(String Nombre,
            String Apellido,
            String Telefono,
            String Direccion,
            String Estado,
            DateTime Fecha_Ingreso,
            String DNI)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Estado = Estado;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.DNI = DNI;

            return this;

        }

        public override String ToString()
        {
            return this.getFullName();
        }

        public String getFullName()
        {
            return this.Nombre + " " + this.Apellido;
        }

    }

    public class ClienteRepository : Repository
    {

        public const String Activo = "Activo";
        public const String NoActivo = "Inactivo";

        public List<String> getEstados()
        {
            return new List<String> { Activo, NoActivo };
        }

        private ClienteRepository() : base()
        {
            this.orderBy = "Nombre ASC";
        }

        private static ClienteRepository instance;
        public static ClienteRepository Instance
        {
            get
            {
                return instance ?? (instance = new ClienteRepository());
            }
        }

        public List<Cliente> getClientesPrimerIngreso()
        {
            String Sql = "SELECT " +
                            "C.*" +
                          " FROM CLIENTE AS C" +
                          " WHERE 1 = (SELECT  COUNT (P.id) FROM Pago AS P  WHERE P.Cliente_id = C.id )";

            return this.Conexion.getDataTable(Sql, true).DataTableToList<Cliente>(); ;
        }

        public System.Data.DataTable getClientesPrimerIngresoDT()
        {
            String Sql = " SELECT C.Nombre, C.Apellido, C.Fecha_Ingreso, C.DNI, P.Monto, C.id" +
                            " FROM Cliente AS C" +
                            " inner join pago as P on C.id = P.Cliente_id" +
                            "  Group by C.id, C.Nombre, C.Apellido, C.Fecha_Ingreso, C.dni,  P.Monto" +
                            " having count(P.id) = 1";

            return this.Conexion.getDataTable(Sql, true);
        }

        public SqlDataReader getClientesMorosos()
        {
            String Sql = " SELECT C.Nombre as Nombre," +
                           " C.Apellido as Apellido," +
                           " C.Fecha_Ingreso AS Fecha_Ingreso_cliente," +
                           " (DAY(P.Fecha_Inicio) - DAY(PT.Fecha_Inicio)) AS days ," +
                           " PT.Fecha_Inicio AS fecha_inicio," +
                           " P.Fecha_Inicio AS fecha_siguiente_pago," +
                           " C.DNI as DNI" +
                    " FROM Cliente AS C" +
                    " INNER JOIN Pago AS P ON C.id = P.Cliente_id" +
                    " INNER JOIN Pago AS PT ON (PT.id != P.id" +
                                              " AND DAY(P.Fecha_Inicio) > DAY(PT.Fecha_Inicio)" +
                                              " AND C.id = PT.Cliente_id)" +
                    " WHERE C.Estado = 'Activo'";

            return this.Conexion.getDataReader(Sql);
        }

        public SqlDataReader getClientesActivosDataReader()
        {
            String sql = " SELECT C.Nombre AS Nombre," +
                            " C.Apellido AS Apellido," +
                            " C.Fecha_Ingreso AS Fecha_Ingreso," +
                            " C.DNI AS DNI" +
                             " FROM Cliente AS C" +
                             " WHERE C.Estado = 'Activo'";
            return this.Conexion.getDataReader(sql);
        }

        public List<Cliente> getClientesActivos()
        {
            Cliente cliente = new Cliente()
            {
                Estado = ClienteRepository.Activo
            };
            return this.getData(cliente);
        }

        public List<Cliente> getData()
        {
            return this.Conexion.getData(this.table).DataTableToList<Cliente>();
        }

        public List<Cliente> getData(Cliente cliente, bool like = false)
        {
            return this.Conexion.getDataTable(this.getDataSearch(cliente, like), true).DataTableToList<Cliente>();
        }

    }




}
