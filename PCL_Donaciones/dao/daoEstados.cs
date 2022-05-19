using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoEstados
    {
        public static List<strEstado> GetAll()
        {
            List<strEstado> list = null;

            string query = "Select * from Estados order by Clave asc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            list = LoadData(reader, list);

            return list;
        }

        private static List<strEstado> LoadData(SqlDataReader reader, List<strEstado> list)
        {
            while (reader != null && reader.Read())
            {
                if (list == null) list = new List<strEstado>();
                list.Add(new strEstado()
                {
                    Clave = reader["Clave"].ToString(),
                    Estado = reader["Estado"].ToString()
                });
            }
            return list;
        }
    }
}