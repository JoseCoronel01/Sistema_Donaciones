using PCL_Donaciones.BusinessRules;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI_Donaciones
{
    public partial class frmReportes : Form
    {
        public frmReportes(string nombreReporte = null, int? idDonador = null)
        {
            InitializeComponent();

            DataSet ds = null;

            if (nombreReporte == "Donadores")
            {
                strBRdonadores strBr = new strBRdonadores();

                ds = strBr.GetDonadores(nombreReporte);
            }
            else if (nombreReporte == "Donaciones")
            {
                strBRdonaciones strBr = new strBRdonaciones();

                ds = strBr.GetDonaciones(nombreReporte);
            }
            else if (nombreReporte == "HistorialPorDonador")
            {
                strBRdonaciones str = new strBRdonaciones();

                ds = str.GetHistrialDeDonaciones(nombreReporte, idDonador);
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}