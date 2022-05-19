using System.Data;
using xml = PCL_Donaciones.Reportes.DataSet;
using PCL_Donaciones.dao;

namespace PCL_Donaciones.BusinessRules
{
    public class strBRdonadores
    {
        public DataSet GetDonadores(string nombreReporte)
        {
            string query = "Select D.Id," +
                            "TD.Nombre as DesTipoDonador," +
                            "D.Matricula,D.ApellidoPat,D.ApellidoMat,D.Nombre,D.Curp,D.RFC,D.FechaNac,D.FechaReg," +
                            "D.Direccion,D.Telefono,D.TelefonoCel,D.TelefonoOfi,D.Correo,D.CorreoAlt," +
                            "(CASE WHEN D.Sexo = 'H' THEN 'HOMBRE' " +
                            "WHEN D.Sexo = 'M' THEN 'MUJER' END) as DesSexo, " +
                            "D.Ocupacion," +
                            "D.Importe,D.Perfil, " +
                            "(CASE WHEN D.Estatus = 1 THEN 'ACTIVO' " +
                            "WHEN D.Estatus = 2 THEN 'INACTIVO' " +
                            "WHEN D.Estatus = 3 THEN 'BAJA' END) as DesEstatus " +
                            "from Donadores D " +
                            "Inner join TipoDonador TD on TD.Clave = D.TipoDonador " +
                            "order by D.ApellidoPat,D.ApellidoMat,D.Nombre asc";

            DataTable data = daoDatosEmpresa.GetAllData();
            
            DataSet ds = xml.CreaXML.GeneraDataSet(query, nombreReporte, data);

            return ds;
        }
    }
}