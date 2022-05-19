using System.Data.SqlClient;
using System.Data;

namespace PCL_Donaciones.dao
{
    public class daoGenerico
    {
        public DataTable GetDataTable(string query = null)
        {
            SqlConnection cxn = daoConexion.GetSql("db");

            SqlDataAdapter adapter = new SqlDataAdapter(query, cxn);

            DataSet ds = new DataSet("Consulta");

            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0];
                }
            }

            return null;
        }
    }
}