using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;
using System.Windows.Forms;

namespace NORI.Reportes
{
    public partial class frmrepNC : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static string SERVER = Settings.Settings.Default.SERVIDOR;
        public static string BD = Settings.Settings.Default.BD;
        public static string USERSQL = Settings.Settings.Default.USERBD;
        public static string PASSSQL = Settings.Settings.Default.PASSBD;


        public frmrepNC()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Settings.Settings.Default.rutaReportes.ToString() + "NOTAS DE CRED.rpt";
                string fechaInicio = txtFechaInicio.Text;
                string fechaFin = txtFechaFin.Text;
                this.Hide();
                string AttachPDF = addFileTemp();
                if (AttachPDF != "")
                {
                    ReportDocument cryReportDocument = new ReportDocument();
                    cryReportDocument.Load(ruta);
                    cryReportDocument.SetDatabaseLogon(USERSQL, PASSSQL, SERVER, BD);
                    cryReportDocument.SetParameterValue("@FechaInicio", fechaInicio);
                    cryReportDocument.SetParameterValue("@FechaFin", fechaFin);
                    cryReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, AttachPDF);
                    cryReportDocument.Dispose();
                    this.Hide();
                    frmVisualizadorReportes frmVisual = new frmVisualizadorReportes(AttachPDF);
                    frmVisual.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible abrir este archivo");
            }

        }
        public string addFileTemp()
        {
            string ruta = string.Empty;
            try
            {
                string tempDirectory = Path.GetTempPath();
                string tempFilePath = GetUniqueTempFilePath(tempDirectory, "archivo_temp", ".pdf");
                ruta = tempFilePath;
                CreateEmptyPdf(tempFilePath);
            }
            catch (Exception ex)
            {
                ruta = string.Empty;
            }
            return ruta;
        }
        public static string GetUniqueTempFilePath(string directory, string prefix, string extension)
        {
            string tempFileName = Path.Combine(directory, prefix + "_" + Guid.NewGuid().ToString() + extension);
            if (File.Exists(tempFileName))
            {
                return GetUniqueTempFilePath(directory, prefix, extension);
            }
            return tempFileName;
        }
        public static void CreateEmptyPdf(string filePath)
        {
            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
            document.AddPage();
            document.Save(filePath);
        }
    }
}