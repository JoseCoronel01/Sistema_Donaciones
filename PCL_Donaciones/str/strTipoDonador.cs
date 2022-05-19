namespace PCL_Donaciones.str
{
    public class strTipoDonador
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return this.Clave + " " + this.Nombre;
        }
    }
}