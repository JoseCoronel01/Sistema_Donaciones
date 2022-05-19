using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoDonaciones
    {
        public static int Insert(strDonacion str)
        {
            int save = 0;

            string query = "Insert into Donaciones (Donador,Fecha,Monto) values (@Donador,@Fecha,@Monto) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static List<strDonacion> GetAll(int donador)
        {
            List<strDonacion> list = null;

            string query = "Select * from Donaciones where Donador=@Donador order by Fecha desc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Donador", donador);

            SqlDataReader reader = cmd.ExecuteReader();

            list = LoadList(reader, list);

            return list;
        }

        public static strDonacion GetObject(int donador, DateTime fecha)
        {
            strDonacion str = null;

            string query = "Select * from Donaciones where Donador = @Donador and Fecha = @Fecha ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Donador", donador);

            cmd.Parameters.AddWithValue("@Fecha", fecha);

            SqlDataReader reader = cmd.ExecuteReader();

            str = LoadObject(reader, str);

            return str;
        }

        private static strDonacion LoadObject(SqlDataReader reader, strDonacion str)
        {
            if (reader != null && reader.Read())
            {
                if (str == null) str = new strDonacion();
                str.Donador = int.Parse(reader["Donador"].ToString());
                str.Fecha = DateTime.Parse(reader["Fecha"].ToString());
                str.Monto = (reader["Monto"] != DBNull.Value) ? decimal.Parse(reader["Monto"].ToString()) : 0;
            }
            return str;
        }

        private static List<strDonacion> LoadList(SqlDataReader reader, List<strDonacion> list)
        {
            while (reader != null && reader.Read())
            {
                if (list == null) list = new List<strDonacion>();
                list.Add(new strDonacion()
                {
                    Donador = int.Parse(reader["Donador"].ToString()),
                    Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                    Monto = (reader["Monto"] != DBNull.Value) ? decimal.Parse(reader["Monto"].ToString()) : 0
                });
            }
            return list;
        }

        private static void AddParameters(SqlCommand cmd, strDonacion str)
        {
            cmd.Parameters.AddWithValue("@Donador", str.Donador);
            cmd.Parameters.AddWithValue("@Fecha", str.Fecha);
            cmd.Parameters.AddWithValue("@Monto", str.Monto);
        }
    }
}