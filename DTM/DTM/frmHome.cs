using DTM.HuellaDigital.Class;
using System;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
            cursorManita();
          
        }
        public void cursorManita() 
        {
            pictureBox2.MouseEnter += (sender, e) => {
                this.Cursor = Cursors.Hand;
            };

            pictureBox2.MouseLeave += (sender, e) => {
                this.Cursor = Cursors.Default;  // Restablecer al cursor por defecto
            };
            pictureBox3.MouseEnter += (sender, e) => {
                this.Cursor = Cursors.Hand;
            };

            pictureBox3.MouseLeave += (sender, e) => {
                this.Cursor = Cursors.Default;  // Restablecer al cursor por defecto
            };
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