using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.Shared;
using PCL_Donaciones.BusinessRules;
using PCL_Donaciones.Reportes;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace UI_Donaciones
{
    public partial class frmReportes : Form
    {
        private static string servidor = ConfigurationManager.AppSettings["serv"];
        private static string baseDatos = ConfigurationManager.AppSettings["bd"];

        public frmReportes(string nombreReporte = null, int? idDonador = null)
        {
            InitializeComponent();

            DataSet ds = null;

            ConnectionInfo conexion = new ConnectionInfo
            {
                ServerName = servidor,
                DatabaseName = baseDatos,
                IntegratedSecurity = true
            };

            if (nombreReporte == "Donadores")
            {
                strBRdonadores strBr = new strBRdonadores();

                ds = strBr.GetDonadores(nombreReporte);

                crDonadores rep = new crDonadores();

                rep.SetDataSource(ds);

                foreach (Table tabla in rep.Database.Tables)
                {
                    TableLogOnInfo logonInfo = tabla.LogOnInfo;
                    logonInfo.ConnectionInfo = conexion;
                    tabla.ApplyLogOnInfo(logonInfo);
                }

                crystalReportViewer1.ReportSource = rep;
            }
            else if (nombreReporte == "Donaciones")
            {
                strBRdonaciones strBr = new strBRdonaciones();

                ds = strBr.GetDonaciones(nombreReporte);

                crDonaciones rep = new crDonaciones();

                rep.SetDataSource(ds);

                foreach (Table tabla in rep.Database.Tables)
                {
                    TableLogOnInfo logonInfo = tabla.LogOnInfo;
                    logonInfo.ConnectionInfo = conexion;
                    tabla.ApplyLogOnInfo(logonInfo);
                }

                crystalReportViewer1.ReportSource = rep;
            }
            else if (nombreReporte == "HistorialPorDonador")
            {
                strBRdonaciones str = new strBRdonaciones();

                ds = str.GetHistrialDeDonaciones(nombreReporte, idDonador);

                crHistorialDonacion rep = new crHistorialDonacion();

                if (ds == null) return;

                rep.SetDataSource(ds);

                foreach (Table tabla in rep.Database.Tables)
                {
                    TableLogOnInfo logonInfo = tabla.LogOnInfo;
                    logonInfo.ConnectionInfo = conexion;
                    tabla.ApplyLogOnInfo(logonInfo);
                }

                crystalReportViewer1.ReportSource = rep;
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}