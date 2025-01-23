using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using SDK;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DTM.Reportes
{
    public partial class frmrepCorteCaja : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static string SERVER = Settings.Settings.Default.SERVIDOR;
        public static string BD = Settings.Settings.Default.BD;
        public static string USERSQL = Settings.Settings.Default.USERBD;
        public static string PASSSQL = Settings.Settings.Default.PASSBD;


        public frmrepCorteCaja()
        {
            InitializeComponent();
            txtFechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaFin.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando información para el reporte...");
                string ruta = Settings.Settings.Default.rutaReportes.ToString() + "CORTE CAJA.rpt";
                string fechaInicio = DateTime.Parse(txtFechaInicio.Text).ToString("yyyy-MM-dd");
                string fechaFin = DateTime.Parse(txtFechaFin.Text).ToString("yyyy-MM-dd");
                this.Hide();
                if (verificarResultados(fechaInicio, fechaFin).Rows.Count > 0)
                {

                    string AttachPDF = addFileTemp();
                    if (AttachPDF != "")
                    {
                        //ReportDocument reportDocument = new ReportDocument();
                        //reportDocument.Load(ruta);

                        //// Accediendo a parámetros del informe
                        //ParameterFieldDefinitions parameterFieldDefinitions = reportDocument.DataDefinition.ParameterFields;
                        //ParameterFieldDefinition parameterFieldDefinition = parameterFieldDefinitions["@FechaInicio"]; // Verifica que "MiParametro" exista en tu informe

                        //ParameterValues parameterValues = parameterFieldDefinition.CurrentValues;
                        //parameterValues.Clear();
                        //parameterValues.Add(new ParameterDiscreteValue() { Value = "ValorParametro" });


                        // Asignar el parámetro al informe
                        //parameterFieldDefinition.ApplyCurrentValues(parameterValues);


                        ReportDocument cryReportDocument = new ReportDocument();
                        cryReportDocument.Load(ruta);
                        cryReportDocument.SetDatabaseLogon(USERSQL, PASSSQL, SERVER, BD);
                        cryReportDocument.Refresh();
                        cryReportDocument.SetParameterValue("@FechaInicio", fechaInicio);
                        cryReportDocument.SetParameterValue("@FechaFin", fechaFin);
                        cryReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, AttachPDF);
                        cryReportDocument.Dispose();
                        this.Hide();
                        frmVisualizadorReportes frmVisual = new frmVisualizadorReportes(AttachPDF);
                        frmVisual.Show();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible abrir este archivo");
            }
            finally 
            {
                SplashScreenManager.CloseForm(false);
            }

        }
        public DataTable verificarResultados(string fechaInicio,string fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                DB dB = new DB();
                string query = "EXEC [dbo].[SP_CORTECAJA] '"+ fechaInicio + "','"+ fechaFin + "'";
                dt = dB.ExecuteQuery(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro ningun resultado,favor de verificar nuevamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrrido un error al verificar el reporte");
                return dt;
            }
            return dt;
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