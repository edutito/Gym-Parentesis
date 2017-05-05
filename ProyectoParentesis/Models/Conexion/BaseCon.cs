using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Models.Conexion
{
    public abstract  class BaseCon
    {
        public String conString = "Server=localhost; Database=BD_Parentess; Integrated Security=True";
        public SqlConnection con;
        public SqlCommand lComando;

        public BaseCon()
        {
            this.con = new SqlConnection(this.conString);
        }

        public String ConString
        {
            get { return conString; }
            set { conString = value; }
        }


        public void OpenConexion()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();

            }
        }

        public void CloseConexion()
        {
            if (this.con.State == ConnectionState.Open)
            {
                this.con.Close();
            }
        }

        public int EjecutarComando(String command, List<SqlParameter> paramters = null)
        {           
            this.preparetelComand(command, paramters);

            return this.EjecutarComandoNonQuery();            
        }

        public int EjecutarComandoNonQuery()
        {
            try
            {
                this.OpenConexion();
                return Convert.ToInt32(this.lComando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw;
                return -1;
            }
            finally
            {
                this.CloseConexion();
            }
        }

        


        public SqlDataReader getDataReader(String command, List<SqlParameter> paramters = null)
        {
            try
            {
                this.OpenConexion();
                this.preparetelComand(command, paramters);

                return this.lComando.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw;
                return null;
            }
            finally
            {
                // this.CloseConexion();
            }

        }
        
        public void preparetelComand(String command, List<SqlParameter> paramters = null)
        {

            this.lComando = new SqlCommand(command, this.con);
            if (paramters == null) return;
            foreach (SqlParameter paramter in paramters)            
            this.lComando.Parameters.Add(paramter);            
        }

        public DataTable executeDataTable(){
            try
            {
                this.OpenConexion();                
                              
                DataTable dt = new DataTable();
                dt.Load(this.lComando.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                throw;                
            }
            finally
            {
                this.CloseConexion();
            }
        }

        public DataTable getDataTable(String table)
        {
            this.OpenConexion();
            this.lComando = new SqlCommand("SELECT * FROM " + table, con);
            return this.executeDataTable();
        }    

        public DataTable getDataTable(String sql, Boolean full)
        {
            this.OpenConexion();
            this.lComando = new SqlCommand(sql, con);
            return this.executeDataTable();

        }  
    }
}
