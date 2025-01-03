using DevExpress.DashboardWin;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace NORI
{
    public partial class frmEscritorio : XtraForm
    {
        private IContainer components = null;

        private DashboardViewer dashboardViewer1;

        public frmEscritorio(string escritorio)
        {
            InitializeComponent();
            InitializeWebView2();
            this.MetodoDinamico();
            //dashboardViewer1.LoadDashboard(escritorio);
        }
        private async void InitializeWebView2()
        {
            // Inicializar WebView2

            await webView21.EnsureCoreWebView2Async(null);

            // Cargar la página de Zoho Analytics
            webView21.Source = new Uri("https://analytics.zoho.com/open-view/2997752000000059897?ZOHO_CRITERIA=%22FACTURACION%22.%22idvendedor%22=15");
        }



    }
}
