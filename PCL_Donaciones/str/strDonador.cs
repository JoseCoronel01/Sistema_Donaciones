using System;

namespace PCL_Donaciones.str
{
    public class strDonador
    {
        public int Id { get; set; }
        public string TipoDonador { get; set; }
        public string Matricula { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string Nombre { get; set; }
        public string Curp { get; set; }
        public string RFC { get; set; }
        public DateTime? FechaNac { get; set; }
        public DateTime FechaReg { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TelefonoCel { get; set; }
        public string TelefonoOfi { get; set; }
        public string Correo { get; set; }
        public string CorreoAlt { get; set; }
        public string Sexo { get; set; }
        public string Ocupacion { get; set; }
        public double? Importe { get; set; }
        public string Perfil { get; set; }
        public eEstatus Estatus { get; set; }
        public enum eEstatus
        {
            SINESTATUS=0,ACTIVO=1,INACTIVO=2,BAJA=3
        }
        public override string ToString()
        {
            return this.Matricula + " " + this.ApellidoPat + " " + this.ApellidoMat + " " + this.Nombre;
        }
    }
}