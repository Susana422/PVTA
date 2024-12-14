using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
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
    public partial class frmTiposMetodosPago : RibbonForm
    {
        private MetodoPago.Tipo tipo_metodo_pago = new MetodoPago.Tipo();

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

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbMetodosPago;

        private HyperlinkLabelControl metdosPago;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private LabelControl lblTipoCambio;

        private CheckEdit cbReferencia;

        private LookUpEdit cbTiposCambio;

        private CheckEdit cbCanjeable;

        private CheckEdit cbDocumento;

        private CheckEdit cbCambio;

        private TextEdit txtCuentaContable;

        private LabelControl lblCuentaContable;

        private LookUpEdit cbClases;

        private LabelControl lblClase;

        private TextEdit txtCodigo;

        private LabelControl lblCodigo;

        private BarButtonItem bbiUsuarios;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        public frmTiposMetodosPago(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                tipo_metodo_pago = MetodoPago.Tipo.Obtener(id);
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
            ((Control)(object)lblID).Text = tipo_metodo_pago.id.ToString();
            ((BaseEdit)cbMetodosPago).EditValue = tipo_metodo_pago.metodo_pago_id;
            ((BaseEdit)cbMonedas).EditValue = tipo_metodo_pago.moneda_id;
            ((Control)(object)txtNombre).Text = tipo_metodo_pago.nombre;
            ((Control)(object)txtCuentaContable).Text = tipo_metodo_pago.cuenta_contable;
            ((Control)(object)txtCodigo).Text = tipo_metodo_pago.codigo;
            ((BaseEdit)cbTiposCambio).EditValue = tipo_metodo_pago.tipo_cambio;
            ((BaseEdit)cbClases).EditValue = tipo_metodo_pago.clase;
            cbReferencia.Checked = tipo_metodo_pago.referencia;
            cbCambio.Checked = tipo_metodo_pago.cambio;
            cbCanjeable.Checked = tipo_metodo_pago.canjeable;
            cbDocumento.Checked = tipo_metodo_pago.documento;
            cbActivo.Checked = tipo_metodo_pago.activo;
            ((Control)(object)lblFechaActualizacion).Text = tipo_metodo_pago.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbMetodosPago).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)cbMetodosPago).Focus();
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
                fields = "id, codigo, nombre"
            };
            object objeto = new
            {
                activo = 1
            };
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DataSource = Utilidades.Busqueda("metodos_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DataSource = Utilidades.Busqueda("monedas", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbTiposCambio.Properties).DataSource = MetodoPago.Tipo.TipoCambio.Tipos();
            ((RepositoryItemLookUpEditBase)cbTiposCambio.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTiposCambio.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbTiposCambio).EditValue = MetodoPago.Tipo.TipoCambio.ObtenerPredeterminado();
            ((RepositoryItemLookUpEditBase)cbClases.Properties).DataSource = MetodoPago.Tipo.Clase.Clases();
            ((RepositoryItemLookUpEditBase)cbClases.Properties).ValueMember = "clase";
            ((RepositoryItemLookUpEditBase)cbClases.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbClases).EditValue = MetodoPago.Tipo.Clase.ObtenerPredeterminado();
        }

        private void Llenar()
        {
            tipo_metodo_pago.metodo_pago_id = (int)((BaseEdit)cbMetodosPago).EditValue;
            tipo_metodo_pago.moneda_id = (int)((BaseEdit)cbMonedas).EditValue;
            tipo_metodo_pago.nombre = ((Control)(object)txtNombre).Text;
            tipo_metodo_pago.cuenta_contable = ((Control)(object)txtCuentaContable).Text;
            tipo_metodo_pago.codigo = ((Control)(object)txtCodigo).Text;
            tipo_metodo_pago.tipo_cambio = (char)((BaseEdit)cbTiposCambio).EditValue;
            tipo_metodo_pago.clase = (string)((BaseEdit)cbClases).EditValue;
            tipo_metodo_pago.referencia = cbReferencia.Checked;
            tipo_metodo_pago.cambio = cbCambio.Checked;
            tipo_metodo_pago.canjeable = cbCanjeable.Checked;
            tipo_metodo_pago.documento = cbDocumento.Checked;
            tipo_metodo_pago.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (tipo_metodo_pago.id != 0)
                    {
                        return tipo_metodo_pago.Actualizar();
                    }
                    return tipo_metodo_pago.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
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
                tipo_metodo_pago = new MetodoPago.Tipo();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                tipo_metodo_pago = (from x in MetodoPago.Tipo.Tipos()
                                    orderby x.id
                                    select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                tipo_metodo_pago = (from x in MetodoPago.Tipo.Tipos()
                                    where x.id < tipo_metodo_pago.id
                                    orderby x.id descending
                                    select x).First();
            }
            catch
            {
                ((BarItem)bbiUltimo).PerformClick();
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                tipo_metodo_pago = (from x in MetodoPago.Tipo.Tipos()
                                    where x.id > tipo_metodo_pago.id
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
                tipo_metodo_pago = (from x in MetodoPago.Tipo.Tipos()
                                    orderby x.id descending
                                    select x).First();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (tipo_metodo_pago.id != 0)
                {
                    tipo_metodo_pago = new MetodoPago.Tipo();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, nombre, activo",
                    like = true
                };
                object objeto = new
                {
                    metodo_pago_id = (((BaseEdit)cbMetodosPago).EditValue.IsNullOrEmpty() ? null : ((BaseEdit)cbMetodosPago).EditValue),
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("tipos_metodos_pago", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        tipo_metodo_pago = MetodoPago.Tipo.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        tipo_metodo_pago = MetodoPago.Tipo.Obtener(frmResultadosBusqueda2.id);
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
            tipo_metodo_pago = new MetodoPago.Tipo();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && tipo_metodo_pago.id == 0)
            {
                Buscar();
            }
        }

        private void bbiUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuariosTiposMetodosPago frmUsuariosTiposMetodosPago2 = new frmUsuariosTiposMetodosPago();
            ((Control)(object)frmUsuariosTiposMetodosPago2).Show();
        }

    }
}
    