using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoDatosEmpresa
    {
        public static int Insert(strDatoEmpresa str)
        {
            int save = 0;

            string query = "Insert into DatosEmpresa (Nombre,Direccion,RFC,Ciudad,CP,RutaDirectorio) values (@Nombre,@Direccion,@RFC,@Ciudad,@CP,@RutaDirectorio) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Update(strDatoEmpresa str)
        {
            int save = 0;

            string query = "Update DatosEmpresa set Nombre=@Nombre,Direccion=@Direccion,Ciudad=@Ciudad,CP=@CP,RutaDirectorio=@RutaDirectorio,RFC=@RFC ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Delete(string RFC)
        {
            int save = 0;

            string query = "Delete from DatosEmpresa where RFC=@RFC ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@RFC", RFC);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static DataTable GetAllData()
        {
            var empresas = GetAll();

            DataTable table = null;

            if (empresas == null) return table;

            for (int i = 0; i < empresas.Count; i++)
            {
                if (i == 0)
                {
                    table = new DataTable();
                    table.Columns.Add("Ciudad");
                    table.Columns.Add("CP");
                    table.Columns.Add("Direccion");
                    table.Columns.Add("Nombre");
                    table.Columns.Add("RFC");
                    table.Columns.Add("RutaDirectorio");
                }
                DataRow dr = table.NewRow();
                dr["Ciudad"] = empresas[i].Ciudad;
                dr["CP"] = empresas[i].CP;
                dr["Direccion"] = empresas[i].Direccion;
                dr["Nombre"] = empresas[i].Nombre;
                dr["RFC"] = empresas[i].RFC;
                dr["RutaDirectorio"] = empresas[i].RutaDirectorio;
                table.Rows.Add(dr);
            }

            return table;
        }

        public static List<strDatoEmpresa> GetAll()
        {
            List<strDatoEmpresa> lista = null;

            string query = "Select * from DatosEmpresa order by Nombre asc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            lista = LoadData(reader, lista);

            return lista;
        }

        public static strDatoEmpresa GetObject(string RFC)
        {
            strDatoEmpresa obj = null;

            string query = "Select * from DatosEmpresa where RFC=@RFC ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@RFC", RFC);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        public static strDatoEmpresa GetObject()
        {
            strDatoEmpresa obj = null;

            string query = "Select top 1 * from DatosEmpresa ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static strDatoEmpresa LoadObject(SqlDataReader reader, strDatoEmpresa obj)
        {
            if (reader != null && reader.Read())
            {
                if (obj == null) obj = new strDatoEmpresa();
                obj.Nombre = reader["Nombre"].ToString();
                obj.Direccion = reader["Direccion"].ToString();
                obj.RFC = reader["RFC"].ToString();
                obj.Ciudad = reader["Ciudad"].ToString();
                obj.CP = reader["CP"].ToString();
                obj.RutaDirectorio = reader["RutaDirectorio"].ToString();
            }
            return obj;
        }

        private static List<strDatoEmpresa> LoadData(SqlDataReader reader, List<strDatoEmpresa> lista)
        {
            while (reader != null && reader.Read())
            {
                if (lista == null) lista = new List<strDatoEmpresa>();
                lista.Add(new strDatoEmpresa()
                {
                    Nombre = reader["Nombre"].ToString(),
                    Direccion = reader["Direccion"].ToString(),
                    RFC = reader["RFC"].ToString(),
                    Ciudad = reader["Ciudad"].ToString(),
                    CP = reader["CP"].ToString(),
                    RutaDirectorio = reader["RutaDirectorio"].ToString()
                });
            }
            return lista;
        }

        private static void AddParameters(SqlCommand cmd, strDatoEmpresa str)
        {
            cmd.Parameters.AddWithValue("@Nombre", str.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", str.Direccion);
            cmd.Parameters.AddWithValue("@RFC", str.RFC);
            cmd.Parameters.AddWithValue("@Ciudad", str.Ciudad);
            cmd.Parameters.AddWithValue("@CP", str.CP);
            cmd.Parameters.AddWithValue("@RutaDirectorio", str.RutaDirectorio);
        }
    }
}