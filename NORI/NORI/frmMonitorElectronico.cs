using System;
using System.Data;

namespace NORI
{
    public partial class frmMonitorElectronico : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMonitorElectronico()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            gvMonitor.DataSource = dataTable;
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}