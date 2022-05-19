using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoVisitas
    {
        public static int Insert(strVisita str)
        {
            int save = 0;

            string query = "Insert into Visitas (Donador,Donador_Vistante,Fecha,Motivo,Observaciones) values (@Donador,@Donador_Vistante,@Fecha,@Motivo,@Observaciones) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Update(strVisita str)
        {
            int save = 0;

            string query = "Update Visitas set Donador_Vistante=@Donador_Vistante, Motivo=@Motivo, " +
                "Observaciones=@Observaciones where Donador=@Donador and Fecha=@Fecha ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Delete(int Donador, DateTime Fecha)
        {
            int save = 0;

            string query = "Delete from Visitas where Donador=@Donador and Fecha=@Fecha ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Donador", Donador);

            cmd.Parameters.AddWithValue("@Fecha", Fecha);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static List<strVisita> GetAll()
        {
            List<strVisita> lista = null;

            string query = "Select * from Visitas order by Fecha desc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            lista = LoadData(reader, lista);

            return lista;
        }

        public static strVisita GetObject(int Donador, DateTime Fecha)
        {
            strVisita obj = null;

            string query = "Select * from Visitas where Donador=@Donador and Fecha=@Fecha ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Donador", Donador);

            cmd.Parameters.AddWithValue("@Fecha", Fecha);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static strVisita LoadObject(SqlDataReader reader, strVisita obj)
        {
            if (reader != null && reader.Read())
            {
                if (obj == null) obj = new strVisita();
                obj.Donador = int.Parse(reader["Donador"].ToString());
                obj.Donador_Vistante = (reader["Donador_Vistante"] != DBNull.Value) ? int.Parse(reader["Donador_Vistante"].ToString()) : 0;
                obj.Fecha = DateTime.Parse(reader["Fecha"].ToString());
                obj.Motivo = reader["Motivo"].ToString();
                obj.Observaciones = reader["Observaciones"].ToString();
            }
            return obj;
        }

        private static List<strVisita> LoadData(SqlDataReader reader, List<strVisita> lista)
        {
            while (reader != null && reader.Read())
            {
                if (lista == null) lista = new List<strVisita>();
                lista.Add(new strVisita()
                {
                    Donador = int.Parse(reader["Donador"].ToString()),
                    Donador_Vistante = (reader["Donador_Vistante"] != DBNull.Value) ? int.Parse(reader["Donador_Vistante"].ToString()) : 0,
                    Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                    Motivo = reader["Motivo"].ToString(),
                    Observaciones = reader["Observaciones"].ToString()
                });
            }
            return lista;
        }

        private static void AddParameters(SqlCommand cmd, strVisita str)
        {
            cmd.Parameters.AddWithValue("@Donador", str.Donador);
            cmd.Parameters.AddWithValue("@Donador_Vistante", str.Donador_Vistante);
            cmd.Parameters.AddWithValue("@Fecha", str.Fecha);
            cmd.Parameters.AddWithValue("@Motivo", str.Motivo);
            cmd.Parameters.AddWithValue("@Observaciones", str.Observaciones);
        }
    }
}