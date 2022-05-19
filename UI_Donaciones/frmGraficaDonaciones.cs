using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Comun.Utilidades;
using PCL_Donaciones.BusinessRules;

namespace UI_Donaciones
{
    public partial class frmGraficaDonaciones : Form
    {
        public frmGraficaDonaciones()
        {
            InitializeComponent();
        }

        private void frmGraficaDonaciones_Load(object sender, EventArgs e)
        {
            gBoxFiltro.BackColor = Color.LightCyan;

            dtpDelaFecha.Focus();

            List<ElementoComboBox> elementos = new List<ElementoComboBox>();

            List<strTipoDonador> lista = daoTipoDonadores.GetAll();

            elementos.Add(new ElementoComboBox() { value = "-1", text = "TODOS" });

            foreach (var item in lista)
                elementos.Add(new ElementoComboBox() { value = item.Clave, text = item.Nombre });

            cbTipoDonador.DataSource = elementos;
        }

        private void cbTipoDonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos(cbTipoDonador.SelectedValue.ToString(), dtpDelaFecha.Value, dtpAlafecha.Value);
        }

        private void dtpDelaFecha_ValueChanged(object sender, EventArgs e)
        {
            MostrarDatos(cbTipoDonador.SelectedValue.ToString(), dtpDelaFecha.Value, dtpAlafecha.Value);
        }

        private void dtpAlafecha_ValueChanged(object sender, EventArgs e)
        {
            MostrarDatos(cbTipoDonador.SelectedValue.ToString(), dtpDelaFecha.Value, dtpAlafecha.Value);
        }

        private void MostrarDatos(string tipoDonador, DateTime delaFecha, DateTime alaFecha)
        {
            strBRdonaciones strBr = new strBRdonaciones();

            var dt = strBr.GetDonacionesPorFecha(tipoDonador, delaFecha, alaFecha);

            chartDonaciones.Series.Clear();
            chartDonaciones.Series.Add("Donaciones");

            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                var fecha = DateTime.Parse(row["Fecha"].ToString()).ToShortDateString();

                chartDonaciones.Series["Donaciones"].Points.AddXY(fecha, row["Monto"].ToString());

                chartDonaciones.Series["Donaciones"].ChartType = SeriesChartType.Candlestick;
            }

            chartDonaciones.DataSource = dt;
        }

        private void cbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos(cbTipoDonador.SelectedValue.ToString(), dtpDelaFecha.Value, dtpAlafecha.Value);

            chartDonaciones.Series["Donaciones"].ChartType = CambiarGrafico(cbTipoGrafico.Text);
        }

        private SeriesChartType CambiarGrafico(string text)
        {
            text = text.Trim();

            switch (text)
            {
                case "Line": { return SeriesChartType.Line; }
                case "FastLine": { return SeriesChartType.FastLine; }
                case "Area": { return SeriesChartType.Area; }
                case "Pie": { return SeriesChartType.Pie; }
                case "Spline": { return SeriesChartType.Spline; }
                case "Bar": { return SeriesChartType.Bar; }
                case "BoxPlot": { return SeriesChartType.BoxPlot; }
                case "Bubble": { return SeriesChartType.Bubble; }
                case "Candlestick": { return SeriesChartType.Candlestick; }
                case "Column": { return SeriesChartType.Column; }
                case "Doughnut": { return SeriesChartType.Doughnut; }
                case "ErrorBar": { return SeriesChartType.ErrorBar; }
                case "FastPoint": { return SeriesChartType.FastPoint; }
                case "Funnel": { return SeriesChartType.Funnel; }
                case "Kagi": { return SeriesChartType.Kagi; }
                case "Point": { return SeriesChartType.Point; }
                case "PointAndFigure": { return SeriesChartType.PointAndFigure; }
                case "Polar": { return SeriesChartType.Polar; }
                case "Pyramid": { return SeriesChartType.Pyramid; }
                case "Radar": { return SeriesChartType.Radar; }
                case "Range": { return SeriesChartType.Range; }
                case "RangeBar": { return SeriesChartType.RangeBar; }
                case "RangeColumn": { return SeriesChartType.RangeColumn; }
                case "Renko": { return SeriesChartType.Renko; }
                case "SplineArea": { return SeriesChartType.SplineArea; }
                case "SplineRange": { return SeriesChartType.SplineRange; }
                case "StackedArea": { return SeriesChartType.StackedArea; }
                case "StackedArea100": { return SeriesChartType.StackedArea100; }
                case "StackedBar": { return SeriesChartType.StackedBar; }
                case "StackedBar100": { return SeriesChartType.StackedBar100; }
                case "StackedColumn": { return SeriesChartType.StackedColumn; }
                case "StackedColumn100": { return SeriesChartType.StackedColumn100; }
                case "StepLine": { return SeriesChartType.StepLine; }
                case "Stock": { return SeriesChartType.Stock; }
                case "ThreeLineBreak": { return SeriesChartType.ThreeLineBreak; }
                default: { return SeriesChartType.Bar; }
            }
        }
    }
}