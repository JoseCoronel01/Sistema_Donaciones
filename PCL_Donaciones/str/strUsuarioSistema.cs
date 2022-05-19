namespace PCL_Donaciones.str
{
    public class strUsuarioSistema
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public eTipo Tipo { get; set; }
        public enum eTipo
        {
            ANONYMUS=0,SUPERVISOR = 1,OPERADOR=2
        }
    }
}