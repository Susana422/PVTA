using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmSolicitarAutorizacion : RibbonForm
    {
        internal static Autorizacion autorizacion;

        internal static Autorizacion.ConceptoAutorizacion concepto_autorizacion;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private PanelControl panelControl1;

        private LayoutControlItem layoutControlItem1;

        private Button btnAceptar;

        private LabelControl lblAutorizacion;

        private Button btnCancelar;

        private Label lblComentario;

        private Label lblReferencia;

        private Timer timer;

        private HyperlinkLabelControl lblAutorizar;

        public frmSolicitarAutorizacion(Autorizacion _)
        {
            autorizacion = _;
            concepto_autorizacion = Autorizacion.ConceptoAutorizacion.Obtener(autorizacion.codigo);
            try
            {
                Bitmap bitmap = new Bitmap(int.Parse(SystemParameters.VirtualScreenWidth.ToString()), int.Parse(SystemParameters.VirtualScreenHeight.ToString()));
                System.Drawing.Size blockRegionSize = new System.Drawing.Size(bitmap.Width, bitmap.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(0, 0, 0, 0, blockRegionSize);
                string text = "autorizacion_" + autorizacion.id + ".png";
                string filename = string.Format(Program.Nori.Configuracion.directorio_imagenes + "\\autorizaciones\\" + text);
                bitmap.Save(filename);
                autorizacion.captura = text;
                autorizacion.ActualizarCaptura();
            }
            catch
            {
            }
            InitializeComponent();
            this.MetodoDinamico();
            ((Control)(object)lblAutorizacion).Text = concepto_autorizacion.nombre;
            lblReferencia.Text = autorizacion.referencia;
            lblComentario.Text = autorizacion.comentario;
            if (autorizacion.autorizado)
            {
                timer.Enabled = false;
                btnAceptar.BackColor = Color.ForestGreen;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!autorizacion.pendiente)
            {
                if (autorizacion.autorizado)
                {
                    ((Form)this).DialogResult = DialogResult.OK;
                }
                else
                {
                    ((Form)this).DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            autorizacion.Actualizar();
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                autorizacion.Verificar();
                if (!autorizacion.pendiente)
                {
                    lblComentario.Text = autorizacion.comentario;
                    btnAceptar.BackColor = (autorizacion.autorizado ? Color.ForestGreen : Color.Firebrick);
                    timer.Stop();
                }
                btnAceptar.Focus();
            }
            catch
            {
            }
        }

        private void lblAutorizar_Click(object sender, EventArgs e)
        {
            frmAutenticar frmAutenticar2 = new frmAutenticar();
            frmAutenticar2.usuario = new Usuario();
            ((Form)(object)frmAutenticar2).ShowDialog();
            if (Autorizacion.Autorizado(frmAutenticar2.usuario, autorizacion.codigo))
            {
                if (((Form)(object)frmAutenticar2).DialogResult == DialogResult.OK && frmAutenticar2.usuario.id != 0)
                {
                    autorizacion.autorizado = true;
                    autorizacion.usuario_autorizacion_id = frmAutenticar2.usuario.id;
                    autorizacion.estacion_autorizacion_id = Program.Nori.Estacion.id;
                    autorizacion.Actualizar();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El usuario especificado no tiene privilegios para autorizar esta acción");
            }
        }


    }

}
