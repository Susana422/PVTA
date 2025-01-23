using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using SDK;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DTM.PuntoVenta
{
    public partial class frmIngresos : RibbonForm
    {
        private Flujo flujo = new Flujo();

        private Autorizacion autorizacion = new Autorizacion();

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtCantidad;

        private LabelControl lblCantidad;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        public frmIngresos(string codigo)
        {
            InitializeComponent();
            this.MetodoDinamico();
            Flujo.ConceptoFlujo conceptoFlujo = Flujo.ConceptoFlujo.Obtener(codigo);
            ((Control)(object)this).Text = conceptoFlujo.nombre;
            flujo.codigo = conceptoFlujo.codigo;
            autorizacion.codigo = conceptoFlujo.codigo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"¿Estas seguro(a) de realizar un ingreso por la cantidad de {((Control)(object)txtCantidad).Text}?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                string text = "Apertura";
                if (autorizacion.codigo == "INDEP")
                {
                    text = "Depósito";
                }
                autorizacion.referencia = $"{text} de caja al usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre} por la cantidad de {((Control)(object)txtCantidad).Text}";
                autorizacion.comentario = Interaction.InputBox("Comentario ingreso (Opcional)");
                autorizacion.Agregar();
                if (!autorizacion.autorizado)
                {
                    frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                    ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                    autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                }
                if (autorizacion.autorizado)
                {
                    flujo.autorizacion_id = autorizacion.id;
                    flujo.importe = decimal.Parse(((BaseEdit)txtCantidad).EditValue.ToString());
                    flujo.comentario = ((Control)(object)txtComentario).Text;
                    if (flujo.Agregar())
                    {
                        Funciones.ImprimirInformePredeterminado("IE", flujo.id);
                        ((Form)this).DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, verifica la información y trata nuevamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

    }
}
