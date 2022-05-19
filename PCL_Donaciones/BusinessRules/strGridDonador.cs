using System;
using System.Collections.Generic;
using System.Linq;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;

namespace PCL_Donaciones.BusinessRules
{
    public class strGridDonador
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public double? Importe { get; set; }
        public DateTime? Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public eEstatus Estatus { get; set; }
        public enum eEstatus
        {
            SINESTATUS = 0, ACTIVO = 1, INACTIVO = 2, BAJA = 3
        }

        public List<strGridDonador> GetGridList()
        {
            List<strDonador> list = daoDonadores.GetAll();

            List<strGridDonador> lista = null;

            if (list == null) return lista;

            List<strDonador> list2 = list.
                Where(a => a.Estatus == strDonador.eEstatus.ACTIVO || a.Estatus == strDonador.eEstatus.INACTIVO).
                ToList();

            foreach (var item in list2)
            {
                if (lista == null) lista = new List<strGridDonador>();

                lista.Add(new strGridDonador()
                {
                    Id = item.Id,
                    Matricula = item.Matricula,
                    Apellido_Paterno = item.ApellidoPat,
                    Apellido_Materno = item.ApellidoMat,
                    Nombre = item.Nombre,
                    Curp = item.Curp,
                    Rfc = item.RFC,
                    Importe = item.Importe,
                    Fecha_Nacimiento = item.FechaNac,
                    Genero = item.Sexo,
                    Estatus = (strGridDonador.eEstatus)item.Estatus
                });
            }

            return lista;
        }
    }
}