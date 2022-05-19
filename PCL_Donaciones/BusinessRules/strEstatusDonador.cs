using System.Collections.Generic;
using PCL_Comun.Utilidades;
using PCL_Donaciones.str;

namespace PCL_Donaciones.BusinessRules
{
    public class strEstatusDonador
    {
        public List<ElementoComboBox> CargarEstatus()
        {
            List<ElementoComboBox> lista = new List<ElementoComboBox>();
            lista.Add(new ElementoComboBox() { value = strDonador.eEstatus.ACTIVO, text = "ACTIVO" });
            lista.Add(new ElementoComboBox() { value = strDonador.eEstatus.INACTIVO, text = "INACTIVO" });
            lista.Add(new ElementoComboBox() { value = strDonador.eEstatus.BAJA, text = "BAJA" });
            return lista;
        }
    }
}