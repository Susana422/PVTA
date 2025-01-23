using System;
using System.Windows.Forms;

namespace DTM.Reportes
{
    public partial class frmVisualizadorReportes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmVisualizadorReportes(string filePath)
        {
            InitializeComponent();
            LoadPdf(filePath);
        }
        private void LoadPdf(string filePath)
        {
            try
            {
                string file = filePath;
                pdfViewer1.LoadDocument(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el PDF: " + ex.Message);
            }
        }
    }
}