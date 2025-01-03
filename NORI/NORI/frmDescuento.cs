using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Windows.Forms;



namespace NORI
{
    public partial class frmDescuento : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private Button btnCancelar;

        private Button btnAceptar;

        private LabelControl lblDescuento;

        private LabelControl lblTotal;

        private CheckEdit cbPorcentaje;

        private TextEdit txtDescuento;

        public decimal descuento { get; internal set; }

        public decimal total { internal get; set; }

        public frmDescuento()
        {
            InitializeComponent();
            this.MetodoDinamico();
            ((Control)(object)txtDescuento).Focus();
        }

        private void cbPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorcentaje.Checked && decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString()) > 100m)
            {
                ((BaseEdit)txtDescuento).EditValue = 100;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbPorcentaje.Checked && decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString()) > 100m)
            {
                ((BaseEdit)txtDescuento).EditValue = 100;
            }
            if (cbPorcentaje.Checked)
            {
                descuento = total / 100m * decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString());
            }
            else
            {
                descuento = decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString());
            }
            decimal num = (cbPorcentaje.Checked ? decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString()) : (total * 100m / decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString())));
            if (MessageBox.Show(string.Format("Se realizara un descuento de {0}% ({1}), ¿Desea continuar?", decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString()), descuento.ToString("c2")), ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Autorizacion autorizacion = new Autorizacion();
                autorizacion.codigo = "DSCTO";
                autorizacion.referencia = string.Format("Descuento global al documento de {0}% ({1}), Total del documento {2}", decimal.Parse(((BaseEdit)txtDescuento).EditValue.ToString()), descuento.ToString("c2"), total.ToString("c2"));
                autorizacion.comentario = Interaction.InputBox("Comentario descuento global (Opcional)");
                autorizacion.Agregar();
                if (!autorizacion.autorizado)
                {
                    frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                    ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                    autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                }
                if (!autorizacion.autorizado)
                {
                    ((Form)this).DialogResult = DialogResult.Cancel;
                }
                else
                {
                    ((Form)this).DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

        private void frmDescuento_Load(object sender, EventArgs e)
        {
            ((Control)(object)lblTotal).Text = string.Format("Total {0}", total.ToString("c2"));
        }

    }

}
