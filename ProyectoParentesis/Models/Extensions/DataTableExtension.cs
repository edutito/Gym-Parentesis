using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models.Extensions
{
    public static class DataTableExtension
    {
        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in 
                        obj.GetType().GetProperties())
                    {
                        try
                        {
                            String name = prop.Name == "Id" ? "id" : prop.Name;
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            Type t = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                            var value = row[name];
                            object safeValue = (value == null) ? null : Convert.ChangeType(value, t);
                            propertyInfo.SetValue(obj, safeValue, null);                            
                        }
                        catch
                        {                            
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

    }
}
