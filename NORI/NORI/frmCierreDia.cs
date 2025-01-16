using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmCierreDia : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BackstageViewControl backstageViewControl1;

        private LayoutControlGroup layoutControlGroup1;

        private DataLayoutControl dataLayoutControl1;

        private LayoutControlItem layoutControlItem1;

        private PanelControl panelControl1;

        private SimpleButton btnCierre;

        private LabelControl lblFechaInicial;

        private LabelControl lblFechaFinal;

        private DateEdit deFechaFinal;

        private DateEdit deFechaInicial;

        public frmCierreDia()
        {
            InitializeComponent();
            this.MetodoDinamico();
            EventoControl.SuscribirEventos((Form)(object)this);
            deFechaInicial.DateTime = DateTime.Today;
            deFechaFinal.DateTime = DateTime.Today;
        }

        private bool CajasAbiertas()
        {
            try
            {
                bool result = false;
                List<Usuario> list = Usuario.Usuarios().ToList();
                foreach (Usuario item in list)
                {
                    if (NoriSDK.PuntoVenta.EstadoCaja(item.id).Equals('A'))
                    {
                        result = true;
                        MessageBox.Show($"La caja del usuario {item.usuario} esta abierta, realice el corte de caja para continuar.");
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
                return true;
            }
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            try
            {
                if (CajasAbiertas())
                {
                    MessageBox.Show("No se puede realizar el cierre ya que existen cajas abiertas.");
                    return;
                }
                Informe informe = Informe.ObtenerPredeterminado("CD");
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("fecha_inicial", deFechaInicial.DateTime);
                dictionary.Add("fecha_final", deFechaFinal.DateTime);
                Funciones.ImprimirInforme2(informe.id, dictionary);
                MessageBox.Show("Se realizó el cierre correctamente.");
                ((Form)this).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

    }
}
