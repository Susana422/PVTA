using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmAltaRapidaArticulo : RibbonForm
    {
        private Articulo articulo = new Articulo();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private BarButtonItem bbiGuardarCerrar;

        private BackstageViewControl backstageViewControl1;

        private LayoutControlGroup layoutControlGroup1;

        private DataLayoutControl dataLayoutControl1;

        private LayoutControlItem layoutControlItem1;

        private PanelControl panelControl1;

        private LabelControl lblDescripcion;

        private TextEdit txtDescripcion;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblSKU;

        private TextEdit txtSKU;

        private LabelControl lblGruposArticulo;

        private LookUpEdit cbGruposArticulos;

        private LabelControl lblPrecio;

        private TextEdit txtPrecio;

        private SimpleButton btnGenerarSKU;

        public frmAltaRapidaArticulo()
        {
            InitializeComponent();
            this.MetodoDinamico();
            EventoControl.SuscribirEventos((Form)(object)this);
            CargarListas();
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Validar())
            {
                if (Guardar())
                {
                    ((Form)this).Close();
                }
                else
                {
                    MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                }
            }
            else
            {
                MessageBox.Show("La información del artículo no esta completa.");
            }
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DataSource = from x in GrupoArticulo.GruposArticulos()
                                                                                      select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DisplayMember = "nombre";
        }

        private bool Validar()
        {
            try
            {
                if (((Control)(object)txtSKU).Text.Length == 0 || ((Control)(object)txtNombre).Text.Length == 0 || ((Control)(object)txtNombre).Text.Length == 0 || ((Control)(object)txtPrecio).Text.Length == 0 || (int)((BaseEdit)cbGruposArticulos).EditValue == 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Llenar()
        {
            articulo.sku = ((Control)(object)txtSKU).Text;
            articulo.nombre = ((Control)(object)txtNombre).Text;
            articulo.descripcion = ((Control)(object)txtDescripcion).Text;
            articulo.codigo_barras = articulo.sku;
            articulo.grupo_articulo_id = (int)((BaseEdit)cbGruposArticulos).EditValue;
            Articulo obj = articulo;
            Articulo obj2 = articulo;
            bool flag2 = (articulo.almacenable = true);
            bool venta = (obj2.compra = flag2);
            obj.venta = venta;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (articulo.Agregar())
                    {
                        Articulo.Precio precio = new Articulo.Precio();
                        precio.articulo_id = articulo.id;
                        precio.precio = decimal.Parse(((BaseEdit)txtPrecio).EditValue.ToString());
                        precio.Agregar();
                        Articulo.Inventario inventario = Articulo.Inventario.Obtener(articulo.id, Program.dtm.UsuarioAutenticado.almacen_id);
                        if (inventario.id == 0)
                        {
                            inventario.articulo_id = articulo.id;
                            inventario.almacen_id = Program.dtm.UsuarioAutenticado.almacen_id;
                            if (inventario.Agregar())
                            {
                                MessageBox.Show("Se agregó la información correctamente.");
                            }
                            else
                            {
                                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("El inventario de este artículo ya incluye este almacén.");
                        }
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void btnGenerarSKU_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoArticulo grupoArticulo = GrupoArticulo.Obtener((int)((BaseEdit)cbGruposArticulos).EditValue);
                string text = string.Format("{0}{1}{2}{3}", grupoArticulo.codigo.ToString("D2"), DateTime.Today.Month.ToString("D2"), DateTime.Today.ToString("yy"), Funciones.DigitosAleatorios(6));
                ((Control)(object)txtSKU).Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }


    }

}
