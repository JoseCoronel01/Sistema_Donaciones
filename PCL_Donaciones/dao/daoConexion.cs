using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PCL_Comun.Utilidades;

namespace PCL_Donaciones.dao
{
    public class daoConexion
    {
        private static SqlConnection cxn = null;

        public static bool TestSql()
        {
            bool IsConnected = false;

            if (cxn != null)
            {
                if (cxn.State == ConnectionState.Open) cxn.Close();

                cxn.Open();

                IsConnected = true;
            }
            else
            {
                SqlConnection cn = GetSql("db");

                if (cn == null)
                    IsConnected = false;
            }

            return IsConnected;
        }

        public static SqlConnection GetSql(string db)
        {
            try
            {
                if (ConfigurationManager.AppSettings.Count > 0 && cxn == null)
                {
                    string sCxn = ConfigurationManager.AppSettings[db].ToString();

                    //string sCxn2 = Util.DesEncripta(sCxn);

                    cxn = new SqlConnection(sCxn);

                    cxn.Open();
                }
                else
                {
                    if (cxn != null)
                    {
                        if (cxn.State == ConnectionState.Open) cxn.Close();

                        cxn.Open();
                    }
                }
            }
            catch
            {
                throw new Exception("Error de conexión a la base de datos, Reporte al departamento de sistemas.");
            }
            finally { }

            return cxn;
        }
    }
}