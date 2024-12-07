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
            InitializeComponent();
            this.MetodoDinamico();
            dashboardViewer1.LoadDashboard(escritorio);
        }

        
    }
}
