using System;
using System.Collections.Generic;
using System.Linq;
using PCL_Comun.Utilidades;
using PCL_Donaciones.str;

namespace PCL_Donaciones.BusinessRules
{
    public class strBuscador
    {
        public List<ElementoComboBox> Busqueda(List<strDonador> lista, string filtro)
        {
            List<ElementoComboBox> elem = new List<ElementoComboBox>();

            List<strDonador> lista1 = new List<strDonador>();

            if (lista != null)
            {
                lista1 = (from d in lista
                          where d.ApellidoPat.StartsWith(filtro) ||
                          d.ApellidoPat.Contains(filtro) ||
                          d.ApellidoPat.EndsWith(filtro) ||
                          d.ApellidoMat.StartsWith(filtro) ||
                          d.ApellidoMat.Contains(filtro) ||
                          d.ApellidoMat.EndsWith(filtro) ||
                          d.Nombre.StartsWith(filtro) ||
                          d.Nombre.Contains(filtro) ||
                          d.Nombre.EndsWith(filtro) ||
                          d.Matricula.StartsWith(filtro) ||
                          d.Matricula.Contains(filtro) ||
                          d.Matricula.EndsWith(filtro)
                          select d).ToList();
            }

            elem.Add(new ElementoComboBox() { value = 0, text = "==Seleccionar donador==" });

            foreach (var item in lista1)
                elem.Add(new ElementoComboBox() { value = item.Id, text = item.ToString() });

            return elem;
        }

        public List<strDonador> BusquedaStrDonador(List<strDonador> lista, string filtro)
        {
            List<strDonador> lista1 = new List<strDonador>();

            lista1 = (from d in lista
                      where d.ApellidoPat.StartsWith(filtro) ||
                      d.ApellidoPat.Contains(filtro) ||
                      d.ApellidoPat.EndsWith(filtro) ||
                      d.ApellidoMat.StartsWith(filtro) ||
                      d.ApellidoMat.Contains(filtro) ||
                      d.ApellidoMat.EndsWith(filtro) ||
                      d.Nombre.StartsWith(filtro) ||
                      d.Nombre.Contains(filtro) ||
                      d.Nombre.EndsWith(filtro) ||
                      d.Matricula.StartsWith(filtro) ||
                      d.Matricula.Contains(filtro) ||
                      d.Matricula.EndsWith(filtro)
                      select d).ToList();

            return lista1;
        }

        public List<strGridDonador> BusquedaStrDonador(List<strGridDonador> lista, string filtro)
        {
            List<strGridDonador> lista1 = new List<strGridDonador>();

            if (lista == null) return lista1;

            lista1 = (from d in lista
                      where d.Apellido_Paterno.StartsWith(filtro) ||
                      d.Apellido_Paterno.Contains(filtro) ||
                      d.Apellido_Paterno.EndsWith(filtro) ||
                      d.Apellido_Materno.StartsWith(filtro) ||
                      d.Apellido_Materno.Contains(filtro) ||
                      d.Apellido_Materno.EndsWith(filtro) ||
                      d.Nombre.StartsWith(filtro) ||
                      d.Nombre.Contains(filtro) ||
                      d.Nombre.EndsWith(filtro) ||
                      d.Matricula.StartsWith(filtro) ||
                      d.Matricula.Contains(filtro) ||
                      d.Matricula.EndsWith(filtro)
                      select d).ToList();

            return lista1;
        }
    }
}