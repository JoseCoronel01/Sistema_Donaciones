using System;
using dataSet = System.Data;
using System.IO;
using System.Data.SqlClient;
using PCL_Donaciones.dao;
using System.Data;

namespace PCL_Donaciones.Reportes.DataSet
{
    public class CreaXML
    {
        public static dataSet.DataSet GeneraDataSet(string query = null, string fileName = null, dataSet.DataTable data = null)
        {
            SqlConnection cxn = daoConexion.GetSql("db");

            SqlDataAdapter adaptador = new SqlDataAdapter(query, cxn);

            dataSet.DataSet ds = new dataSet.DataSet(fileName);

            adaptador.Fill(ds);

            string pathWithFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 
                + @"\" + fileName + ".xsd";

            if (!File.Exists(pathWithFile))
            {
                ds.WriteXmlSchema(pathWithFile);
            }
            else
            {
                File.Delete(pathWithFile);
                ds.WriteXmlSchema(pathWithFile);
            }

            CrearDataSetEmpresa(data);

            return ds;
        }

        public static void GeneraXSD(dataSet.DataSet ds, string nombreReporte, dataSet.DataTable data = null)
        {
            string pathWithFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + @"\" + nombreReporte + ".xsd";

            if (!File.Exists(pathWithFile))
            {
                ds.WriteXmlSchema(pathWithFile);
            }
            else
            {
                File.Delete(pathWithFile);
                ds.WriteXmlSchema(pathWithFile);
            }

            CrearDataSetEmpresa(data);
        }

        private static void CrearDataSetEmpresa(DataTable data)
        {
            if (data != null)
            {
                string dsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Empresa.xsd";

                if (File.Exists(dsFile))
                    File.Delete(dsFile);

                dataSet.DataSet _ds = new dataSet.DataSet("Empresa");
                _ds.Tables.Add(data);
                _ds.WriteXmlSchema(dsFile);
            }
        }
    }
}