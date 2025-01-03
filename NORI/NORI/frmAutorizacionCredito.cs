using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace NORI
{
    public partial class frmAutorizacionCredito : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private PanelControl panelControl1;

        private Button btnCancelar;

        private Button btnAceptar;

        private PictureBox pbImagen;

        private Button btnAutorizar;

        public Socio socio { private get; set; }

        public frmAutorizacionCredito()
        {
            InitializeComponent();
            this.MetodoDinamico();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            Autorizacion autorizacion = new Autorizacion();
            autorizacion.codigo = "VEACR";
            autorizacion.referencia = $"Venta a crédito con firma no autorizada al socio {socio.codigo}";
            autorizacion.comentario = Interaction.InputBox("Comentario venta a crédito (Opcional)");
            autorizacion.Agregar();
            if (!autorizacion.autorizado)
            {
                frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
            }
            if (autorizacion.autorizado)
            {
                ((Form)this).DialogResult = DialogResult.OK;
                return;
            }
            ((Form)this).DialogResult = DialogResult.Cancel;
            MessageBox.Show("No se autorizó este movimiento.");
        }

        private void frmAutorizacionCredito_Load(object sender, EventArgs e)
        {
            pbImagen.LoadImage(socio.imagen);
        }
    }
}
