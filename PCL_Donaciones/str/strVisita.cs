using System;

namespace PCL_Donaciones.str
{
    public class strVisita
    {
        public int Donador { get; set; }
        public int? Donador_Vistante { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
    }
}