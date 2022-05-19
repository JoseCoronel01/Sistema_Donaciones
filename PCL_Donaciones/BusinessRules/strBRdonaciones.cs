using System;
using System.Data;
using PCL_Donaciones.dao;
using xml = PCL_Donaciones.Reportes.DataSet;

namespace PCL_Donaciones.BusinessRules
{
    public class strBRdonaciones
    {
        public DataSet GetHistrialDeDonaciones(string nombreReporte, int? idDonador)
        {
            DataTable data = null;

            DataTable nombre = null;

            string query = "select dona.Fecha, dona.Monto from Donaciones dona " +
                "where dona.Donador = " + idDonador + " order by dona.Fecha desc";

            string query2 = "Select Matricula + ' ' + ApellidoPat + ' ' + ApellidoMat + ' ' + Nombre " +
                "as NombreCompleto from Donadores where Id = " + idDonador;

            daoGenerico dao = new daoGenerico();

            data = dao.GetDataTable(query);

            if (data == null) return null;

            data.TableName = "Donaciones";

            nombre = dao.GetDataTable(query2);

            nombre.TableName = "Donador";

            DataSet ds = new DataSet();

            ds.Tables.Add(data.Copy());

            ds.Tables.Add(nombre.Copy());

            xml.CreaXML.GeneraXSD(ds, nombreReporte);

            return ds;
        }

        public DataTable GetDonacionesPorFecha(string tipoDonador, DateTime delaFecha, DateTime alaFecha)
        {
            DataTable table = null;

            string query = "select do.Fecha, do.Monto " +
                           "from Donaciones do " +
                           "inner join Donadores d on d.Id = do.Donador " +
                           "inner join TipoDonador td on td.Clave = d.TipoDonador " +
                           "where CONVERT(date, do.Fecha) >= CONVERT(date, '" + delaFecha.ToString("yyyy/MM/dd") + "') " +
                           "and CONVERT(date, do.Fecha) <= CONVERT(date, '" + alaFecha.ToString("yyyy/MM/dd") + "') " +
                           " " + (tipoDonador != "-1" ? " and td.Clave = '" + tipoDonador + "' " : " ") +
                           "order by do.Fecha asc ";

            daoGenerico generico = new daoGenerico();

            table = generico.GetDataTable(query);

            return table;
        }

        public DataSet GetDonaciones(string nombreReporte)
        {
            DataSet ds = null;

            daoGenerico generico = new daoGenerico();

            string query = "select d.Id, d.Matricula, " +
                           "d.ApellidoPat + ' ' + d.ApellidoMat + ' ' + d.Nombre as NombreCompleto, " +
                           "td.Nombre as DesTipoDonador, SUM(dona.Monto) as Donacion " +
                           "from Donadores d " +
                           "inner join TipoDonador td on td.Clave = d.TipoDonador " +
                           "inner join Donaciones dona on dona.Donador = d.Id " +
                           "where d.TipoDonador = 'LID' " +
                           "group by d.Id, d.Matricula, d.ApellidoPat, d.ApellidoMat, d.Nombre, td.Nombre, dona.Monto " +
                           "order by d.ApellidoPat, d.ApellidoMat, d.Nombre ";

            DataTable dtXml = new DataTable();

            dtXml.Columns.Add("Id");

            dtXml.Columns.Add("Matricula");

            dtXml.Columns.Add("NombreCompleto");

            dtXml.Columns.Add("DesTipoDonador");

            dtXml.Columns.Add("Donacion");

            dtXml.Columns["Donacion"].DataType = typeof(double);

            #region 1er Nivel =Lider=

            DataTable dt = generico.GetDataTable(query);

            if (dt == null) return null;

            DataTable dtAux = dt.Copy();

            int index = 0;

            while (dtAux.Rows.Count > 0)
            {
                int id = int.Parse(dt.Rows[index]["Id"].ToString());

                DataTable arcangeles = ObtenerHijos(id);

                object[] arr1 = dt.Rows[index].ItemArray;

                dtXml.Rows.Add(arr1);

                #region 2do Nivel =ARCANGELES=

                DataTable dtAux2 = arcangeles.Copy();

                int index2 = 0;

                while (dtAux2.Rows.Count > 0)
                {
                    int id2 = int.Parse(arcangeles.Rows[index2]["Id"].ToString());

                    DataTable angeles = ObtenerHijos(id2);

                    object[] arr2 = arcangeles.Rows[index2].ItemArray;

                    dtXml.Rows.Add(arr2);

                    #region 3er Nivel =ANGELES=

                    if (angeles != null)
                    {
                        DataTable dtAux3 = angeles.Copy();

                        foreach (DataRow row in dtAux3.Rows)
                        {
                            object[] arr3 = row.ItemArray;

                            dtXml.Rows.Add(arr3);
                        }
                    }

                    #endregion

                    index2++;

                    dtAux2.Rows[0].Delete();
                    dtAux2.AcceptChanges();
                }

                #endregion

                index++;

                dtAux.Rows[0].Delete();
                dtAux.AcceptChanges();
            }

            #endregion

            ds = new DataSet();

            ds.Tables.Add(dtXml);

            xml.CreaXML.GeneraXSD(ds, nombreReporte);

            return ds;
        }

        private DataTable ObtenerHijos(int id)
        {
            daoGenerico generico = new daoGenerico();

            string query = "select d.Id, d.Matricula, " +
                           "d.ApellidoPat + ' ' + d.ApellidoMat + ' ' + d.Nombre as NombreCompleto, " +
                           "td.Nombre as DesTipoDonador, SUM(dona.Monto) as Donacion " +
                           "from Donadores d " +
                           "inner join Relacion_Donadores rel_d on rel_d.Donador_Hijo = d.Id " +
                           "inner join TipoDonador td on td.Clave = d.TipoDonador " +
                           "inner join Donaciones dona on dona.Donador = d.Id " +
                           "where rel_d.Donador_Padre = " + id + "" +
                           "group by d.Id, d.Matricula, d.ApellidoPat, d.ApellidoMat, d.Nombre, td.Nombre, dona.Monto " +
                           "order by d.ApellidoPat, d.ApellidoMat, d.Nombre ";

            return generico.GetDataTable(query);
        }
    }
}