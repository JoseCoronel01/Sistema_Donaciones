using System;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoRelacion_Donadores
    {
        public static int Insert(strRelacion_Donador str)
        {
            int save = 0;

            string query = "Insert into Relacion_Donadores (Donador_Padre,Donador_Hijo) "+
                "values (@Donador_Padre,@Donador_Hijo) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static strRelacion_Donador GetObject(int hijo, int? padre = null)
        {
            strRelacion_Donador str = null;

            string query = "Select * from Relacion_Donadores " +
                "where Donador_Padre = @Donador_Padre and Donador_Hijo = @Donador_Hijo ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, hijo, padre);

            SqlDataReader reader = cmd.ExecuteReader();

            str = LoadObject(reader, str);

            return str;
        }

        private static strRelacion_Donador LoadObject(SqlDataReader reader, strRelacion_Donador str)
        {
            if (reader != null && reader.Read())
            {
                if (str == null) str = new strRelacion_Donador();
                str.Donador_Padre = (reader["Donador_Padre"] != DBNull.Value) ? int.Parse(reader["Donador_Padre"].ToString()) : 0;
                str.Donador_Hijo = int.Parse(reader["Donador_Hijo"].ToString());
            }
            return str;
        }

        private static void AddParameters(SqlCommand cmd, int hijo, int? padre = null)
        {
            cmd.Parameters.AddWithValue("@Donador_Hijo", hijo);
            cmd.Parameters.AddWithValue("@Donador_Padre", padre);
        }

        private static void AddParameters(SqlCommand cmd, strRelacion_Donador str)
        {
            cmd.Parameters.AddWithValue("@Donador_Padre", str.Donador_Padre);
            cmd.Parameters.AddWithValue("@Donador_Hijo", str.Donador_Hijo);
        }
    }
}