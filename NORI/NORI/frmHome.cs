using DevExpress.XtraBars;
using NORI.HuellaDigital.Class;
using NORI.PuntoVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pcHuella_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data = new AppData();
            Data.OnChange += delegate { ExchangeData(false); };
            frmHuellaDigital frmHuellaDigital = new frmHuellaDigital(Data);
            ((Form)(object)frmHuellaDigital).Show();
        }

        private void pcCredenciales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcceder frmAcceder = new frmAcceder();
            frmAcceder.Show();
        }
        private void ExchangeData(bool read)
        {
        }
        private AppData Data;
    }
}