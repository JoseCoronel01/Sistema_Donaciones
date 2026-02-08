using PCL_Donaciones.BusinessRules;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UI_Donaciones
{
    public partial class frmReportes2 : Form
    {
        public frmReportes2(string nombreReporte = null, int? idDonador = null)
        {
            InitializeComponent();

            DataSet ds = null;

            if (nombreReporte == "Donadores")
            {
                strBRdonadores strBr = new strBRdonadores();
                ds = strBr.GetDonadores(nombreReporte);
                if (ds != null)
                    GenerateDonadoresPDF(ds);
            }
            else if (nombreReporte == "Donaciones")
            {
                strBRdonaciones strBr = new strBRdonaciones();
                ds = strBr.GetDonaciones(nombreReporte);
                if (ds != null)
                    GenerateDonacionesPDF(ds);
            }
            else if (nombreReporte == "HistorialPorDonador")
            {
                strBRdonaciones str = new strBRdonaciones();
                ds = str.GetHistrialDeDonaciones(nombreReporte, idDonador);
                if (ds != null)
                    GenerateHistorialPDF(ds, idDonador);
            }
        }

        private void GenerateDonadoresPDF(DataSet ds)
        {
            try
            {
                string fileName = $"Reporte_Donadores_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.A1, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Add title
                    document.Add(new Paragraph("Reporte de Donadores"));
                    document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                    document.Add(new Paragraph(" ")); // Empty line

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        PdfPTable table = new PdfPTable(ds.Tables[0].Columns.Count);
                        table.WidthPercentage = 100;

                        //foreach (DataColumn column in ds.Tables[0].Columns)
                        //{
                        //    table.AddCell(new Phrase(column.ColumnName));
                        //}

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            foreach (object item in row.ItemArray)
                            {
                                table.AddCell(new Phrase(item?.ToString() ?? ""));
                            }
                        }

                        document.Add(table);
                    }

                    document.Close();
                }
                MessageBox.Show($"Reporte generado exitosamente: {fileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenPDF(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateDonacionesPDF(DataSet ds)
        {
            try
            {
                string fileName = $"Reporte_Donaciones_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    document.Add(new Paragraph("Reporte de Donaciones"));
                    document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                    document.Add(new Paragraph(" "));

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        PdfPTable table = new PdfPTable(ds.Tables[0].Columns.Count);
                        table.WidthPercentage = 100;

                        //foreach (DataColumn column in ds.Tables[0].Columns)
                        //{
                        //    table.AddCell(new Phrase(column.ColumnName));
                        //}

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            foreach (object item in row.ItemArray)
                            {
                                table.AddCell(new Phrase(item?.ToString() ?? ""));
                            }
                        }

                        document.Add(table);
                    }

                    document.Close();
                }
                MessageBox.Show($"Reporte generado exitosamente: {fileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenPDF(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateHistorialPDF(DataSet ds, int? idDonador)
        {
            try
            {
                string fileName = $"Historial_Donador_{idDonador}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    document.Add(new Paragraph($"Historial de Donaciones - Donador ID: {idDonador}"));
                    document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                    document.Add(new Paragraph(" "));

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        PdfPTable table = new PdfPTable(ds.Tables[0].Columns.Count);
                        table.WidthPercentage = 100;

                        //foreach (DataColumn column in ds.Tables[0].Columns)
                        //{
                        //    table.AddCell(new Phrase(column.ColumnName));
                        //}

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            foreach (object item in row.ItemArray)
                            {
                                table.AddCell(new Phrase(item?.ToString() ?? ""));
                            }
                        }

                        document.Add(table);
                    }

                    document.Close();
                }
                MessageBox.Show($"Reporte generado exitosamente: {fileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenPDF(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReportes2_Load(object sender, EventArgs e)
        {

        }

        private void OpenPDF(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}