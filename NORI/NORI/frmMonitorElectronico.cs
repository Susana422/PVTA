using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using NoriSDK;
using System;
using System.Data;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmMonitorElectronico : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMonitorElectronico()
        {
            InitializeComponent();
            cbEstatus.SelectedIndex = 0;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando información...");
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error durante la buaqueda" + ex.Message);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
      
        }

        public void cargar()
        {
         
            string fechaInicio = DateTime.Parse(txtxFechaInicio.Text).ToString("yyyy-MM-dd"); 
            string fechaFin = DateTime.Parse(txtFechaFin.Text).ToString("yyyy-MM-dd");
            string estatus = cbEstatus.SelectedItem.ToString();
            DataTable dataTable = new DataTable();
            gvMonitor.DataSource =null;
            if (estatus =="Todo") 
            { 
                estatus=null;
            }
            dataTable = Sincronizacion.Manual.ObtenerMonitorElectronico(fechaInicio,fechaFin,estatus);
            if (dataTable.Rows.Count == 0) 
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show("No se encontro ningun resultados");
            }
            gvMonitor.DataSource = dataTable;   
        }
        private void bbiXLSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Random random = new Random();
                string numeroAleatorio = "Monitor_" +random.Next(1, 10000);
                string text = $"{Program.Nori.Configuracion.directorio_documentos}\\{numeroAleatorio}.xlsx";
                gvMonitor.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

    }
}