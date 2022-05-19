using System.Collections.Generic;
using PCL_Donaciones.str;
using PCL_Comun.Utilidades;

namespace PCL_Donaciones.BusinessRules
{
    public class strBRUsuarioSistema
    {
        public static List<ElementoComboBox> TiposUsuario()
        {
            return new List<ElementoComboBox>()
            {
                CrearTipoUsuario(strUsuarioSistema.eTipo.SUPERVISOR, "SUPERVISOR"),
                CrearTipoUsuario(strUsuarioSistema.eTipo.OPERADOR, "OPERADOR")
            };
        }

        private static ElementoComboBox CrearTipoUsuario(strUsuarioSistema.eTipo value, string text)
        {
            return new ElementoComboBox() { value = value, text = text };
        }
    }
}