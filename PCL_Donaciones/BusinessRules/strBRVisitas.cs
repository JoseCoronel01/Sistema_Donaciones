using System;
using System.Collections.Generic;
using System.Data;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Comun.Utilidades;

namespace PCL_Donaciones.BusinessRules
{
    public class strBRVisitas
    {
        public List<ElementoComboBox> DonadoresPadre()
        {
            string query = "Select d.* from Donadores d " +
                "Inner join Relacion_Donadores r_d on d.Id = r_d.Donador_Padre ";

            List<strDonador> lista = AddDonadores(query);

            return ConvertToElementoComboBox(lista);
        }

        public List<ElementoComboBox> DonadoresHijos(int idDonador, string tipoDonador = null)
        {
            string query = "Select d.* from Donadores d " +
                "Inner join Relacion_Donadores r_d on d.Id = r_d.Donador_Hijo " +
                "where d.TipoDonador = '" + tipoDonador + "' and r_d.Donador_Padre = " + idDonador + "";

            List<strDonador> lista = AddDonadores(query);

            return ConvertToElementoComboBox(lista);
        }

        private List<ElementoComboBox> ConvertToElementoComboBox(List<strDonador> lista)
        {
            List<ElementoComboBox> elem = new List<ElementoComboBox>();

            elem.Add(new ElementoComboBox() { value = 0, text = "==Seleccionar donador==" });

            if (lista != null)
            {
                foreach (var item in lista)
                    elem.Add(new ElementoComboBox() { value = item.Id, text = item.ToString() });
            }

            return elem;
        }

        private List<strDonador> AddDonadores(string query)
        {
            List<strDonador> lista = null;

            daoGenerico generico = new daoGenerico();

            DataTable dt = generico.GetDataTable(query);

            if (dt == null) return lista;

            foreach (DataRow row in dt.Rows)
            {
                if (lista == null) lista = new List<strDonador>();
                lista.Add(new strDonador()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    TipoDonador = row["TipoDonador"].ToString(),
                    Matricula = row["Matricula"].ToString(),
                    ApellidoPat = row["ApellidoPat"].ToString(),
                    ApellidoMat = row["ApellidoMat"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Curp = row["Curp"].ToString(),
                    RFC = row["RFC"].ToString(),
                    FechaNac = (row["FechaNac"] != DBNull.Value) ? DateTime.Parse(row["FechaNac"].ToString()) : DateTime.MinValue,
                    FechaReg = DateTime.Parse(row["FechaReg"].ToString()),
                    Direccion = row["Direccion"].ToString(),
                    Telefono = row["Telefono"].ToString(),
                    TelefonoCel = row["TelefonoCel"].ToString(),
                    TelefonoOfi = row["TelefonoOfi"].ToString(),
                    Correo = row["Correo"].ToString(),
                    CorreoAlt = row["CorreoAlt"].ToString(),
                    Sexo = row["Sexo"].ToString(),
                    Ocupacion = row["Ocupacion"].ToString(),
                    Importe = (row["Importe"] != DBNull.Value) ? double.Parse(row["Importe"].ToString()) : 0,
                    Perfil = row["Perfil"].ToString(),
                    Estatus = daoDonadores.GetStatus(row["Estatus"].ToString())
                });
            }

            return lista;
        }
    }
}