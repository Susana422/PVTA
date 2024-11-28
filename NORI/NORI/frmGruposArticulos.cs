using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;




namespace NORI
{
    public partial class frmGruposArticulos : RibbonForm
    {
        private GrupoArticulo grupo_articulo = new GrupoArticulo();

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

        private LabelControl lblCuentaAjusteInventario;

        private TextEdit txtNumeroCuentaAjusteInventario;

        private LookUpEdit cbGruposArticulos;

        private LabelControl lblGrupoArticulos;

        private LabelControl lblOrden;

        private LabelControl lblColor;

        private NumericUpDown udOrden;

        private ColorPickEdit cpColor;

        private CheckEdit cbWeb;

        public frmGruposArticulos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            Permisos();
            if (id != 0)
            {
                grupo_articulo = GrupoArticulo.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
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

        private void CargarListas()
        {
            try
            {
                object parametros = new
                {
                    fields = "id, codigo, nombre"
                };
                object objeto = new
                {
                    activo = 1
                };
                ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DataSource = Utilidades.Busqueda("grupos_articulos", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            try
            {
                ((Control)(object)lblID).Text = grupo_articulo.id.ToString();
                ((Control)(object)txtCodigo).Text = grupo_articulo.codigo.ToString();
                ((Control)(object)txtNombre).Text = grupo_articulo.nombre;
                ((Control)(object)txtNumeroCuentaAjusteInventario).Text = grupo_articulo.numero_cuenta_ajuste_inventario;
                ((BaseEdit)cbGruposArticulos).EditValue = grupo_articulo.grupo_superior_id;
                udOrden.Value = grupo_articulo.orden;
                if (!grupo_articulo.color.IsNullOrEmpty())
                {
                    ((ColorEdit)cpColor).Color = Color.FromArgb(grupo_articulo.color.GetValueOrDefault());
                }
                cbWeb.Checked = grupo_articulo.web;
                cbActivo.Checked = grupo_articulo.activo;
                ((Control)(object)lblFechaActualizacion).Text = grupo_articulo.fecha_actualizacion.ToShortDateString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Llenar()
        {
            try
            {
                grupo_articulo.codigo = short.Parse(((Control)(object)txtCodigo).Text);
                grupo_articulo.nombre = ((Control)(object)txtNombre).Text;
                grupo_articulo.numero_cuenta_ajuste_inventario = ((Control)(object)txtNumeroCuentaAjusteInventario).Text;
                grupo_articulo.grupo_superior_id = ((!((BaseEdit)cbGruposArticulos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposArticulos).EditValue) : 0);
                if (!((ColorEdit)cpColor).Color.IsEmpty)
                {
                    grupo_articulo.color = ((ColorEdit)cpColor).Color.ToArgb();
                }
                grupo_articulo.orden = (int)udOrden.Value;
                grupo_articulo.web = cbWeb.Checked;
                grupo_articulo.activo = cbActivo.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (grupo_articulo.id != 0)
                    {
                        return grupo_articulo.Actualizar();
                    }
                    return grupo_articulo.Agregar();
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
                grupo_articulo = new GrupoArticulo();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                grupo_articulo = (from x in GrupoArticulo.GruposArticulos()
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
                grupo_articulo = (from x in GrupoArticulo.GruposArticulos()
                                  where x.id < grupo_articulo.id
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
                grupo_articulo = (from x in GrupoArticulo.GruposArticulos()
                                  where x.id > grupo_articulo.id
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
                grupo_articulo = (from x in GrupoArticulo.GruposArticulos()
                                  orderby x.id descending
                                  select x).First();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Buscar();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            grupo_articulo = new GrupoArticulo();
            Cargar(nuevo: true);
        }

        private void Buscar()
        {
            try
            {
                if (grupo_articulo.id != 0)
                {
                    grupo_articulo = new GrupoArticulo();
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
                DataTable dataTable = Utilidades.Busqueda("grupos_articulos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        grupo_articulo = GrupoArticulo.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        grupo_articulo = GrupoArticulo.Obtener(frmResultadosBusqueda2.id);
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

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && grupo_articulo.id == 0)
            {
                Buscar();
            }
        }
    }
}
