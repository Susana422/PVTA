using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;

namespace NORI
{
    public partial class frmCondicionesPago : RibbonForm
    {
        private CondicionesPago condicion_pago = new CondicionesPago();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRestablecer;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BarButtonItem bbiNuevo;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private RibbonPageGroup searchRibbonPageGroup;

        private LabelControl lblID;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblCodigo;

        private TextEdit txtCodigo;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbListaPrecios;

        private HyperlinkLabelControl lblListaPrecios;

        private LabelControl lblPorcentajeDescuentoTotal;

        private TextEdit txtPorcentajeDescuentoTotal;

        private LabelControl lblPorcentajeInteres;

        private TextEdit txtPorcentajeInteres;

        private LabelControl lblDiasTolerancia;

        private TextEdit txtDiasTolerancia;

        private LabelControl lblLimiteMaximo;

        private TextEdit txtLimiteMaximo;

        private LabelControl lblDiasExtra;

        private TextEdit txtDiasExtra;

        private LabelControl lblPlazos;

        private TextEdit txtPlazos;

        private CheckEdit cbFinanciado;

        private LabelControl labelControl1;

        private TextEdit txtPorcentajeInteresMoratorio;

        private CheckEdit cbPagoRequerido;

        public frmCondicionesPago(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                condicion_pago = CondicionesPago.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarListas();
            Permisos();
        }

        private void Permisos()
        {
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'C':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'S':
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = condicion_pago.id.ToString();
            ((BaseEdit)cbListaPrecios).EditValue = condicion_pago.lista_precio_id;
            ((Control)(object)txtCodigo).Text = condicion_pago.codigo.ToString();
            ((Control)(object)txtNombre).Text = condicion_pago.nombre;
            ((Control)(object)txtPorcentajeDescuentoTotal).Text = condicion_pago.porcentaje_descuento_total.ToString();
            ((Control)(object)txtPorcentajeInteres).Text = condicion_pago.porcentaje_interes.ToString();
            ((Control)(object)txtPorcentajeInteresMoratorio).Text = condicion_pago.porcentaje_interes_moratorio.ToString();
            ((Control)(object)txtDiasExtra).Text = condicion_pago.dias_extra.ToString();
            ((Control)(object)txtPlazos).Text = condicion_pago.plazos.ToString();
            ((Control)(object)txtDiasTolerancia).Text = condicion_pago.dias_tolerancia.ToString();
            ((Control)(object)txtLimiteMaximo).Text = condicion_pago.limite_maximo.ToString();
            cbFinanciado.Checked = condicion_pago.financiado;
            cbPagoRequerido.Checked = condicion_pago.pago_requerido;
            cbActivo.Checked = condicion_pago.activo;
            ((Control)(object)lblFechaActualizacion).Text = condicion_pago.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtCodigo).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtCodigo).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
        }

        private void CargarListas()
        {
            object parametros = new
            {
                fields = "id, nombre"
            };
            object objeto = new
            {
                activo = 1
            };
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DataSource = Utilidades.Busqueda("listas_precios", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbListaPrecios).EditValue = Program.Nori.Configuracion.lista_precio_id;
        }

        private void Llenar()
        {
            condicion_pago.lista_precio_id = ((!((BaseEdit)cbListaPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListaPrecios).EditValue) : 0);
            condicion_pago.codigo = short.Parse(((Control)(object)txtCodigo).Text);
            condicion_pago.nombre = ((Control)(object)txtNombre).Text;
            condicion_pago.porcentaje_descuento_total = decimal.Parse(((Control)(object)txtPorcentajeDescuentoTotal).Text);
            condicion_pago.porcentaje_interes = decimal.Parse(((Control)(object)txtPorcentajeInteres).Text);
            condicion_pago.porcentaje_interes_moratorio = decimal.Parse(((Control)(object)txtPorcentajeInteresMoratorio).Text);
            condicion_pago.dias_extra = short.Parse(((Control)(object)txtDiasExtra).Text);
            condicion_pago.plazos = int.Parse(((Control)(object)txtPlazos).Text);
            condicion_pago.dias_tolerancia = short.Parse(((Control)(object)txtDiasTolerancia).Text);
            condicion_pago.limite_maximo = decimal.Parse(((Control)(object)txtLimiteMaximo).Text);
            condicion_pago.limite_comprometido = condicion_pago.limite_maximo;
            condicion_pago.financiado = cbFinanciado.Checked;
            condicion_pago.pago_requerido = cbPagoRequerido.Checked;
            condicion_pago.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (condicion_pago.id != 0)
                    {
                        return condicion_pago.Actualizar();
                    }
                    return condicion_pago.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
                return false;
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Cargar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
            }
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                ((Form)this).Close();
            }
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                condicion_pago = new CondicionesPago();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                condicion_pago = (from x in CondicionesPago.CondicionesPagos()
                                  orderby x.id
                                  select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiAnterior_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                condicion_pago = (from x in CondicionesPago.CondicionesPagos()
                                  where x.id < condicion_pago.id
                                  orderby x.id descending
                                  select x).First();
                Cargar();
            }
            catch
            {
                ((BarItem)bbiUltimo).PerformClick();
            }
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                condicion_pago = (from x in CondicionesPago.CondicionesPagos()
                                  where x.id > condicion_pago.id
                                  select x).First();
                Cargar();
            }
            catch
            {
                ((BarItem)bbiPrimero).PerformClick();
            }
        }

        private void bbiUltimo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                condicion_pago = (from x in CondicionesPago.CondicionesPagos()
                                  orderby x.id descending
                                  select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (condicion_pago.id != 0)
                {
                    condicion_pago = new CondicionesPago();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, codigo, nombre, activo",
                    like = true
                };
                object objeto = new
                {
                    codigo = ((Control)(object)txtCodigo).Text,
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("condiciones_pago", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        condicion_pago = CondicionesPago.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        condicion_pago = CondicionesPago.Obtener(frmResultadosBusqueda2.id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", ((Control)(object)this).Text);
                }
            }
            catch
            {
            }
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            condicion_pago = new CondicionesPago();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && condicion_pago.id == 0)
            {
                Buscar();
            }
        }

        private void lblListaPrecios_Click(object sender, EventArgs e)
        {
            frmListasPrecios frmListasPrecios2 = new frmListasPrecios((!((BaseEdit)cbListaPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListaPrecios).EditValue) : 0);
            ((Form)(object)frmListasPrecios2).ShowDialog();
            CargarListas();
        }
    }
    }