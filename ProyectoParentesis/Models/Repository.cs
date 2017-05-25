using Models.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Models
{
    public abstract class Repository
    {
        private readonly ConexionDB conexion;
        public String table;
        private String cmd;
        protected String orderBy;
        //private static String dateFormat = "yyyy-MM-dd HH:mm:ss.fff";
        private static String dateFormat = "s";
        private static String dateNull = "0001-01-01T00:00:00"; // 0001-01-01 00:00:00.000

        public ConexionDB Conexion
        {
            get { return this.conexion; }
        }

        protected Repository()
        {
            this.conexion = ConexionDB.Instance;
            this.table = this.GetType().Name.Replace("Repository","");
            this.orderBy = "";
        }

        public void delete(int idBaseObject)
        {
            String cmd = "DELETE " + this.table + " WHERE ID =" + idBaseObject;
            this.Conexion.EjecutarComando(cmd);
        }   


        protected  String prepareteUpdate(BaseModel baseObject) 
        {
            String cmd = "UPDATE " + this.table + " SET ";
            var properties = baseObject.GetType().GetProperties();
            String[] fields = new String[properties.Length -1 ];
            String value;
            PropertyInfo propertyInfo;
            DateTime date;
            int pos = 0;
            foreach (var prop in properties)
            {
                if (! String.Equals(prop.Name, "ID", StringComparison.OrdinalIgnoreCase))
                {
                    if ( String.Equals(prop.Name, "Fecha_Actualizacion", StringComparison.OrdinalIgnoreCase))
                    {
                        fields[pos] = prop.Name + " = " + "'" + (DateTime.Now).ToString(Repository.dateFormat) + "'";
                        pos++;
                        continue;
                    }
                    propertyInfo = baseObject.GetType().GetProperty(prop.Name);
                    if (propertyInfo.PropertyType == typeof(DateTime))
                    {
                        date = (DateTime)propertyInfo.GetValue(baseObject, null);
                        value = date.ToString(Repository.dateFormat);
                    }
                    else
                    {
                        value = propertyInfo.GetValue(baseObject, null).ToString();
                    }

                    fields[pos] = prop.Name + " = " + "'" + value + "'";
                    pos++;
                }
                
            }

            cmd += String.Join(",", fields) + " WHERE ID = " + baseObject.Id.ToString();

            return cmd;
        }

        protected  String prepareteInsert(BaseModel baseObject) 
        {
            String cmd = "INSERT INTO " + this.table + " ( ";
            var properties = baseObject.GetType().GetProperties();
            String[] fields = new String[properties.Length -1 ];
            String[] values = new String[properties.Length -1 ];
            String value;
            PropertyInfo propertyInfo;
            DateTime date;
            int pos = 0;
            foreach (var prop in properties)
            {
                if (! String.Equals(prop.Name, "ID", StringComparison.OrdinalIgnoreCase))
                {
                    fields[pos] = prop.Name;
                    pos++;
                }
                
            }
            pos = 0;
            cmd += String.Join(",", fields) + ") VALUES (";
            foreach (var prop in properties)
            {
                if (!String.Equals(prop.Name, "ID", StringComparison.OrdinalIgnoreCase))
                {
                    if (String.Equals(prop.Name, "Fecha_Creacion", StringComparison.OrdinalIgnoreCase) || String.Equals(prop.Name, "Fecha_Actualizacion", StringComparison.OrdinalIgnoreCase))
                    {
                        values[pos] = "'" + (DateTime.Now).ToString(Repository.dateFormat) + "'";
                        pos++;
                        continue;
                    }
                    propertyInfo =baseObject.GetType().GetProperty(prop.Name);
                    if (propertyInfo.PropertyType == typeof(DateTime))
                    {
                        date = (DateTime) propertyInfo.GetValue(baseObject, null);
                        value = date.ToString(Repository.dateFormat);
                    }
                    else
                    {
                        value = propertyInfo.GetValue(baseObject, null).ToString();
                        
                    }
                    values[pos] = "'" + value + "'";
                    pos++;
                }
            }

            cmd += String.Join(",", values) + "); ";

            return cmd;
        }

        public int getMaxIdentificador()
        {
            String cmd = "SELECT ISNULL(COUNT(Id), 0) + 1 as 'max' FROM "+ this.table;
            return this.Conexion.getNumber(cmd, "max");
        }

        public Repository persist(BaseModel model)
        {
            String cmd;
            if (model.Id == -1){
                cmd = this.prepareteInsert(model);
            }
            else
            {
               cmd  =this.prepareteUpdate(model);
            }

            this.addCmd(cmd);
            return this;
        }

        public Repository flush()// ejecutar comando en SQL
        {
            this.Conexion.EjecutarComando(this.cmd);
            this.cmd = "";
            return this;
        }

        private Repository addCmd(String cmd)
        {
            this.cmd += " " + cmd;
            return this;
        }


        public String getDataSearch(BaseModel model, bool like)
        {
            String cmd = "SELECT * FROM " + this.table + " ";
            var properties = model.GetType().GetProperties();
            List<String> values = new List<String>();
            PropertyInfo propertyInfo;
            DateTime date;
            bool first = true;
            String value;
            String col = "";
            foreach (var prop in properties)
            {

                propertyInfo = prop;
                if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    date = (DateTime)propertyInfo.GetValue(model, null);
                    value = date.ToString(Repository.dateFormat);
                }
                else
                {
                    if (propertyInfo.GetValue(model, null) != null)
                    {
                        value = propertyInfo.GetValue(model, null).ToString();
                    }
                    else
                    {
                        value = null;
                    }

                }
                if (!String.IsNullOrEmpty(value) && value != dateNull)
                {
                    if (value == "-1" && String.Equals(prop.Name, "ID", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    if (like)
                    {
                        col = (first ? "" : "and ") + prop.Name + " LIKE '%" + value + "%' ";
                    }
                    else
                    {
                        col = (first ? "" : "and ") + prop.Name + " = '" + value + "' ";
                    }

                    values.Add(col);
                    first = false;


                }
            }

            if (values.Count > 0)
            {
                cmd += "WHERE ";
            }           

            cmd += String.Join("", values);

            if (!String.IsNullOrEmpty(this.orderBy))
            {
                cmd += " order by " + this.orderBy;
            }
            return cmd;
        }

        
        public String parseDateToSql(DateTime date)
        {
            return "'" + date.ToString(Repository.dateFormat) + "'";
        }

        
    }


}
