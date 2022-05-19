using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoUsuariosSistema
    {
        public static int Insert(strUsuarioSistema str)
        {
            int save = 0;

            string query = "Insert into UsuariosSistema (Usuario,Password,Tipo) values (@Usuario,@Password,@Tipo) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Update(strUsuarioSistema str)
        {
            int save = 0;

            string query = "Update UsuariosSistema set Password=@Password,Tipo=@Tipo where Usuario=@Usuario ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Delete(string Usuario)
        {
            int save = 0;

            string query = "Delete from UsuariosSistema where Usuario=@Usuario ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Usuario", Usuario);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static strUsuarioSistema GetIn(string Usuario, string Password)
        {
            strUsuarioSistema obj = null;

            string query = "Select * from UsuariosSistema " +
                "where Usuario collate Latin1_General_CI_AS like '" + Usuario + "' " +
                "and Password collate Latin1_General_CI_AS like '" + Password + "' ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        public static List<strUsuarioSistema> GetAll()
        {
            List<strUsuarioSistema> lista = null;

            string query = "Select * from UsuariosSistema order by Usuario asc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            lista = LoadData(reader, lista);

            return lista;
        }

        public static strUsuarioSistema GetObject(string Usuario)
        {
            strUsuarioSistema obj = null;

            string query = "Select * from UsuariosSistema where Usuario=@Usuario ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Usuario", Usuario);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static strUsuarioSistema LoadObject(SqlDataReader reader, strUsuarioSistema obj)
        {
            if (reader != null && reader.Read())
            {
                if (obj == null) obj = new strUsuarioSistema();
                obj.Usuario = reader["Usuario"].ToString();
                obj.Password = reader["Password"].ToString();
                obj.Tipo = CargarTipo(reader["Tipo"].ToString());
            }
            return obj;
        }

        private static List<strUsuarioSistema> LoadData(SqlDataReader reader, List<strUsuarioSistema> lista)
        {
            while (reader != null && reader.Read())
            {
                if (lista == null) lista = new List<strUsuarioSistema>();
                lista.Add(new strUsuarioSistema()
                {
                    Usuario = reader["Usuario"].ToString(),
                    Password = reader["Password"].ToString(),
                    Tipo = CargarTipo(reader["Tipo"].ToString())
                });
            }
            return lista;
        }

        private static strUsuarioSistema.eTipo CargarTipo(string value)
        {
            switch (value)
            {
                case "1":
                    {
                        return strUsuarioSistema.eTipo.SUPERVISOR;
                    }
                case "2":
                    {
                        return strUsuarioSistema.eTipo.OPERADOR;
                    }
                default:
                    {
                        return strUsuarioSistema.eTipo.ANONYMUS;
                    }
            }
        }

        private static void AddParameters(SqlCommand cmd, strUsuarioSistema str)
        {
            cmd.Parameters.AddWithValue("@Usuario", str.Usuario);
            cmd.Parameters.AddWithValue("@Password", str.Password);
            cmd.Parameters.AddWithValue("@Tipo", str.Tipo);
        }
    }
}