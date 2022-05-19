using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoTipoDonadores
    {
        public static List<strTipoDonador> GetAll()
        {
            List<strTipoDonador> list = null;

            string query = "Select * from TipoDonador ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            list = LoadList(reader, list);

            return list;
        }

        public static strTipoDonador GetObject(string clave)
        {
            strTipoDonador obj = null;

            string query = "Select * from TipoDonador where Clave = @Clave ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Clave", clave);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static strTipoDonador LoadObject(SqlDataReader reader, strTipoDonador obj)
        {
            if (reader != null && reader.Read())
            {
                if (obj == null) obj = new strTipoDonador();
                obj.Clave = reader["Clave"].ToString();
                obj.Nombre = reader["Nombre"].ToString();
                obj.Descripcion = reader["Descripcion"].ToString();
            }
            return obj;
        }

        private static List<strTipoDonador> LoadList(SqlDataReader reader, List<strTipoDonador> list)
        {
            while (reader != null && reader.Read())
            {
                if (list == null) list = new List<strTipoDonador>();
                list.Add(new strTipoDonador()
                {
                    Clave = reader["Clave"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Descripcion = reader["Descripcion"].ToString()
                });
            }
            return list;
        }
    }
}