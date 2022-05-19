using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PCL_Donaciones.str;

namespace PCL_Donaciones.dao
{
    public class daoDonadores
    {
        public static int Insert(strDonador str)
        {
            int save = 0;

            string query = "Insert into Donadores " +
                "(Id,TipoDonador,Matricula,ApellidoPat,ApellidoMat,Nombre,Curp,RFC,FechaNac,FechaReg," +
                "Direccion,Telefono,TelefonoCel,TelefonoOfi,Correo,CorreoAlt,Sexo,Ocupacion,Importe," +
                "Perfil,Estatus) values " +
                "(@Id,@TipoDonador,@Matricula,@ApellidoPat,@ApellidoMat,@Nombre,@Curp,@RFC,@FechaNac,@FechaReg," +
                "@Direccion,@Telefono,@TelefonoCel,@TelefonoOfi,@Correo,@CorreoAlt,@Sexo," +
                "@Ocupacion,@Importe,@Perfil,@Estatus) ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str, 0);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int Update(strDonador str)
        {
            int save = 0;

            string query = "Update Donadores set " +
                "TipoDonador=@TipoDonador,Matricula=@Matricula,ApellidoPat=@ApellidoPat,ApellidoMat=@ApellidoMat," +
                "Nombre=@Nombre,Curp=@Curp,RFC=@RFC,FechaNac=@FechaNac," +
                "Direccion=@Direccion,Telefono=@Telefono,TelefonoCel=@TelefonoCel,TelefonoOfi=@TelefonoOfi," +
                "Correo=@Correo,CorreoAlt=@CorreoAlt,Sexo=@Sexo,Ocupacion=@Ocupacion,Importe=@Importe," +
                "Perfil=@Perfil,Estatus=@Estatus where Id=@Id ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, str, 1);

            save = cmd.ExecuteNonQuery();

            return save;
        }

        public static int CreateId()
        {
            int id = 0;

            string query = "Select top 1 Id from Donadores order by Id desc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());

                id = id + 1;
            }
            else
                id = 1;

            return id;
        }

        public static List<strDonador> GetAll()
        {
            List<strDonador> list = null;

            string query = "Select * from Donadores order by ApellidoPat,ApellidoMat,Nombre asc ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            SqlDataReader reader = cmd.ExecuteReader();

            list = LoadList(reader, list);

            return list;
        }

        public static strDonador GetObject(int id)
        {
            strDonador obj = null;

            string query = "Select * from Donadores where Id = @Id ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static strDonador LoadObject(SqlDataReader reader, strDonador obj)
        {
            if (reader != null && reader.Read())
            {
                if (obj == null) obj = new strDonador();
                obj.Id = int.Parse(reader["Id"].ToString());
                obj.TipoDonador = reader["TipoDonador"].ToString();
                obj.Matricula = reader["Matricula"].ToString();
                obj.ApellidoPat = reader["ApellidoPat"].ToString();
                obj.ApellidoMat = reader["ApellidoMat"].ToString();
                obj.Nombre = reader["Nombre"].ToString();
                obj.Curp = reader["Curp"].ToString();
                obj.RFC = reader["RFC"].ToString();
                obj.FechaNac = (reader["FechaNac"] != DBNull.Value) ? DateTime.Parse(reader["FechaNac"].ToString()) : DateTime.MinValue;
                obj.FechaReg = DateTime.Parse(reader["FechaReg"].ToString());
                obj.Direccion = reader["Direccion"].ToString();
                obj.Telefono = reader["Telefono"].ToString();
                obj.TelefonoCel = reader["TelefonoCel"].ToString();
                obj.TelefonoOfi = reader["TelefonoOfi"].ToString();
                obj.Correo = reader["Correo"].ToString();
                obj.CorreoAlt = reader["CorreoAlt"].ToString();
                obj.Sexo = reader["Sexo"].ToString();
                obj.Ocupacion = reader["Ocupacion"].ToString();
                obj.Importe = (reader["Importe"] != DBNull.Value) ? double.Parse(reader["Importe"].ToString()) : 0;
                obj.Perfil = reader["Perfil"].ToString();
                obj.Estatus = GetStatus(reader["Estatus"].ToString());
            }
            return obj;
        }

        public static strDonador GetObject(string curp)
        {
            strDonador obj = null;

            string query = "Select * from Donadores where Curp = @Curp ";

            SqlConnection cxn = daoConexion.GetSql("db");

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Curp", curp);

            SqlDataReader reader = cmd.ExecuteReader();

            obj = LoadObject(reader, obj);

            return obj;
        }

        private static List<strDonador> LoadList(SqlDataReader reader, List<strDonador> list)
        {
            while (reader != null && reader.Read())
            {
                if (list == null) list = new List<strDonador>();
                list.Add(new strDonador()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    TipoDonador = reader["TipoDonador"].ToString(),
                    Matricula = reader["Matricula"].ToString(),
                    ApellidoPat = reader["ApellidoPat"].ToString(),
                    ApellidoMat = reader["ApellidoMat"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Curp = reader["Curp"].ToString(),
                    RFC = reader["RFC"].ToString(),
                    FechaNac = (reader["FechaNac"] != DBNull.Value) ? DateTime.Parse(reader["FechaNac"].ToString()) : DateTime.MinValue,
                    FechaReg = DateTime.Parse(reader["FechaReg"].ToString()),
                    Direccion = reader["Direccion"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    TelefonoCel = reader["TelefonoCel"].ToString(),
                    TelefonoOfi = reader["TelefonoOfi"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    CorreoAlt = reader["CorreoAlt"].ToString(),
                    Sexo = reader["Sexo"].ToString(),
                    Ocupacion = reader["Ocupacion"].ToString(),
                    Importe = (reader["Importe"] != DBNull.Value) ? double.Parse(reader["Importe"].ToString()) : 0,
                    Perfil = reader["Perfil"].ToString(),
                    Estatus = GetStatus(reader["Estatus"].ToString())
                });
            }
            return list;
        }

        public static strDonador.eEstatus GetStatus(string value)
        {
            switch (value)
            {
                case "1":
                    {
                        return strDonador.eEstatus.ACTIVO;
                    }
                case "2":
                    {
                        return strDonador.eEstatus.INACTIVO;
                    }
                case "3":
                    {
                        return strDonador.eEstatus.BAJA;
                    }
                default:
                    {
                        return strDonador.eEstatus.SINESTATUS;
                    }
            }
        }

        private static void AddParameters(SqlCommand cmd, strDonador str, int tipo)
        {
            cmd.Parameters.AddWithValue("@Id", str.Id);
            cmd.Parameters.AddWithValue("@TipoDonador", str.TipoDonador);
            cmd.Parameters.AddWithValue("@Matricula", str.Matricula);
            cmd.Parameters.AddWithValue("@ApellidoPat", str.ApellidoPat);
            cmd.Parameters.AddWithValue("@ApellidoMat", str.ApellidoMat);
            cmd.Parameters.AddWithValue("@Nombre", str.Nombre);
            cmd.Parameters.AddWithValue("@Curp", str.Curp);
            cmd.Parameters.AddWithValue("@RFC", str.RFC);
            cmd.Parameters.AddWithValue("@FechaNac", str.FechaNac);
            cmd.Parameters.AddWithValue("@Direccion", str.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", str.Telefono);
            cmd.Parameters.AddWithValue("@TelefonoCel", str.TelefonoCel);
            cmd.Parameters.AddWithValue("@TelefonoOfi", str.TelefonoOfi);
            cmd.Parameters.AddWithValue("@Correo", str.Correo);
            cmd.Parameters.AddWithValue("@CorreoAlt", str.CorreoAlt);
            cmd.Parameters.AddWithValue("@Sexo", str.Sexo);
            cmd.Parameters.AddWithValue("@Ocupacion", str.Ocupacion);
            cmd.Parameters.AddWithValue("@Importe", str.Importe);
            cmd.Parameters.AddWithValue("@Perfil", str.Perfil);
            cmd.Parameters.AddWithValue("@Estatus", str.Estatus);

            if (tipo == 0)
            {
                cmd.Parameters.AddWithValue("@FechaReg", str.FechaReg);
            }
        }
    }
}