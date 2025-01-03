using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NORI.PuntoVenta
{
    public partial class frmCanjes : RibbonForm
    {
        private Autorizacion autorizacion = new Autorizacion();

        private List<MetodoPago.Tipo> tipos_metodos_pago = (from x in MetodoPago.Tipo.Tipos()
                                                            where x.canjeable == true
                                                            select x).ToList();

        private decimal importe = default(decimal);

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private Button btnCancelar;

        private Button btnAceptar;

        private TextEdit txtCantidad;

        private LabelControl lblCantidad;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        private LookUpEdit cbEgreso;

        private LookUpEdit cbIngreso;

        private LabelControl lblConceptoIngreso;

        private LabelControl lblConceptoEgreso;

        private Label lblImporte;

        private Label lblImporte_;

        public frmCanjes()
        {
            InitializeComponent();
            this.MetodoDinamico();
            autorizacion.codigo = "CANJE";
            if (tipos_metodos_pago.Count == 0)
            {
                MessageBox.Show("Aún no hay tipos de métodos de pago canjeables");
                ((Form)this).Close();
            }
            CargarListas();
        }

        public void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbIngreso.Properties).DataSource = tipos_metodos_pago;
            ((RepositoryItemLookUpEditBase)cbIngreso.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbIngreso.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbEgreso.Properties).DataSource = tipos_metodos_pago;
            ((RepositoryItemLookUpEditBase)cbEgreso.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbEgreso.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbEgreso).EditValue = (from x in MetodoPago.MetodosPago()
                                              where x.id == Program.Nori.Configuracion.metodo_pago_id
                                              select x).First().tipo_metodo_pago_id;
        }

        public void Calcular()
        {
            try
            {
                if (((Control)(object)txtCantidad).Text.Length > 0)
                {
                    importe = TipoCambio.Convertir(tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == (int)((BaseEdit)cbIngreso).EditValue).First().moneda_id, tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == (int)((BaseEdit)cbEgreso).EditValue).First().moneda_id, 'C', decimal.Parse(((BaseEdit)txtCantidad).EditValue.ToString()));
                    lblImporte.Text = importe.ToString("c2");
                }
            }
            catch
            {
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)((BaseEdit)cbIngreso).EditValue != (int)((BaseEdit)cbEgreso).EditValue)
                {
                    if (MessageBox.Show($"¿Estas seguro(a) de realizar este canje?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    autorizacion.referencia = $"Canje del usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre}";
                    autorizacion.comentario = Interaction.InputBox("Comentario canje (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                    }
                    if (autorizacion.autorizado)
                    {
                        Flujo flujo = new Flujo();
                        flujo.codigo = "INCAN";
                        flujo.autorizacion_id = autorizacion.id;
                        flujo.tipo_metodo_pago_id = (int)((BaseEdit)cbIngreso).EditValue;
                        flujo.importe = decimal.Parse(((BaseEdit)txtCantidad).EditValue.ToString());
                        flujo.tipo_cambio = importe / flujo.importe;
                        flujo.comentario = ((Control)(object)txtComentario).Text;
                        if (flujo.Agregar())
                        {
                            Funciones.ImprimirInformePredeterminado("IE", flujo.id);
                        }
                        flujo = new Flujo();
                        flujo.codigo = "RECAN";
                        flujo.autorizacion_id = autorizacion.id;
                        flujo.tipo_metodo_pago_id = (int)((BaseEdit)cbEgreso).EditValue;
                        flujo.importe = importe;
                        flujo.comentario = ((Control)(object)txtComentario).Text;
                        if (flujo.Agregar())
                        {
                            Funciones.ImprimirInformePredeterminado("IE", flujo.id);
                        }
                        ((Form)this).DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No se autorizó la operación");
                    }
                }
                else
                {
                    MessageBox.Show("No es posible realizar un canje de dos conceptos iguales");
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

        private void cbIngreso_EditValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }


    }

}
