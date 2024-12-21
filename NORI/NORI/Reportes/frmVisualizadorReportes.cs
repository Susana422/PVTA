using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI.Reportes
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