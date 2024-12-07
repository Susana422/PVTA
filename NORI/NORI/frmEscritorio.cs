using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DashboardWin;
using DevExpress.XtraEditors;


namespace NORI
{
    public partial class frmEscritorio : XtraForm
    {
        private IContainer components = null;

        private DashboardViewer dashboardViewer1;

        public frmEscritorio(string escritorio)
        {
            try
            {
         
                InitializeComponent();
                //SetIE11Mode();
                InitializeWebView2();
                this.MetodoDinamico();
                this.ControlBox = false;  // Desactiva todos los botones de la ventana (minimizar, maximizar, cerrar)
                this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Cambia a un estilo fijo sin redimensionar
                //dashboardViewer1.LoadDashboard(escritorio);
                //webBrowser1.ScriptErrorsSuppressed = true;
                //// Cargar la página web
                //webBrowser1.Url = new Uri("https://analytics.zoho.com/open-view/2997752000000059897");
                //webBrowser1.Visible = true;
            }
            catch (Exception ex)
            {

             
            }
         
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Evitar el cierre del formulario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Esto previene que la ventana se cierre cuando el usuario intenta cerrarla
            }

            base.OnFormClosing(e);
        }
        private async void InitializeWebView2()
        {
            // Inicializar WebView2

            await webView24.EnsureCoreWebView2Async(null);

            // Cargar la página de Zoho Analytics
            webView24.Source = new Uri("https://analytics.zoho.com/open-view/2997752000000059897?ZOHO_CRITERIA=%22FACTURACION%22.%22idvendedor%22=15");
        }

        private void SetIE11Mode()
        {
            // Set the registry key to force the WebBrowser control to use IE 11.
            string browserRegKey = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            string exeName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

            // Set to IE 11 (11000)
            Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\" + browserRegKey, exeName, 11000);
        }



    }
}
