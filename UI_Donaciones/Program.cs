using System;
using System.Windows.Forms;
using PCL_Comun.Utilidades;

namespace UI_Donaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Util.GuardaVariableConfiguracion("db", @"Data Source=JOSE-CORONEL\SQLEXPRESS;Initial Catalog=Donaciones;Integrated Security=True;");

            //Util.GuardaVariableConfiguracion("db", @"Server=tcp:coronel.database.windows.net,1433;Initial Catalog=Donaciones;Persist Security Info=False;User ID=Administrador;Password=Qwerty123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            Application.Run(new Form1());
        }
    }
}