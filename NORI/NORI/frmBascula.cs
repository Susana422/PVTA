using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace NORI
{
    public partial class frmBascula : RibbonForm
    {
        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private LabelControl lblAcceder;

        private TextEdit txtPeso;

        private Timer timerObtenerPeso;

        public frmBascula()
        {
            InitializeComponent();
            this.MetodoDinamico();
            ((Control)(object)txtPeso).Text = "0.00";
            if (Program.Nori.Estacion.bascula && Program.Nori.Estacion.bascula_id != 0 && Program.Nori.Estacion.Bascula != null)
            {
                timerObtenerPeso.Enabled = true;
            }
            else
            {
                MessageBox.Show("No es posible inicializar la báscula o no esta configurada una.");
            }
        }

        private void timerObtenerPeso_Tick(object sender, EventArgs e)
        {
            try
            {
                ((Control)(object)txtPeso).Text = Program.Nori.Estacion.Bascula.ObtenerPeso().ToString("n4");
                if (Program.Nori.Estacion.Bascula.datos.Length == 0)
                {
                    timerObtenerPeso.Enabled = false;
                    MessageBox.Show("Se alcanzó el tiempo máximo de ejecución. Revise la conexión a la báscula y trate nuevamente.");
                    ((Form)this).Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        
    }
}
}
