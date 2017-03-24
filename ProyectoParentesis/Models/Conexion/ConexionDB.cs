using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Models.Conexion
{
    public class ConexionDB : BaseCon
    {
        
        private static ConexionDB instance;
        

        private ConexionDB() : base(){}        

        // creo la instancia
        public static ConexionDB Instance
        {
            get { return instance ?? (instance = new ConexionDB()); }
        }

            

      
          
        public DataTable getData(String table)
        {            
            return this.getDataTable(table);
        }

        public int getNumber(String cmd, String column)
        {
            
            this.preparetelComand(cmd);
            this.OpenConexion();
            SqlDataReader reader = this.lComando.ExecuteReader(CommandBehavior.SingleRow);
            int data = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data = Convert.ToInt32(reader[column]);
                }
            }
            this.CloseConexion();
            return data;
        }




        
}
}