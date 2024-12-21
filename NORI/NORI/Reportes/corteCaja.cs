using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class corteCaja : Form
    {
        public corteCaja()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            string AttachPDF = "C:\\Users\\Programador\\Desktop\\archivo.pdf";
            ReportDocument cryReportDocument = new ReportDocument();
            cryReportDocument.Load("C:\\Users\\Programador\\Music\\REPORTES\\CORTE CAJA.rpt");
            cryReportDocument.SetDatabaseLogon("sa", "123", "DESKTOP-D5V63NE\\SQLEXPRESS", "NORICUAITITLAN");
            cryReportDocument.SetParameterValue("@FechaInicio", "2024-12-21");
            cryReportDocument.SetParameterValue("@FechaFin", "2024-12-21");
            cryReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, AttachPDF);
            cryReportDocument.Dispose();
            this.Hide();
            frmVisualizadorReportes frmVisual= new frmVisualizadorReportes(AttachPDF);
            frmVisual.Show();
        }
    }
}
