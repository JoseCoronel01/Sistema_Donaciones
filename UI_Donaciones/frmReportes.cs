using System;
using System.Windows.Forms;
using System.Data;
using PCL_Donaciones.Reportes;
using PCL_Donaciones.BusinessRules;

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

                crDonadores rep = new crDonadores();

                rep.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rep;
            }
            else if (nombreReporte == "Donaciones")
            {
                strBRdonaciones strBr = new strBRdonaciones();

                ds = strBr.GetDonaciones(nombreReporte);

                crDonaciones rep = new crDonaciones();

                rep.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rep;
            }
            else if (nombreReporte == "HistorialPorDonador")
            {
                strBRdonaciones str = new strBRdonaciones();

                ds = str.GetHistrialDeDonaciones(nombreReporte, idDonador);

                crHistorialDonacion rep = new crHistorialDonacion();

                if (ds == null) return;

                rep.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rep;
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}