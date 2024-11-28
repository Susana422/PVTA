using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTab;
using NoriSDK;


namespace NORI
{
    public partial class frmEtiquetas : RibbonForm
    {
        private Etiqueta etiqueta = new Etiqueta();

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

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPage1;

        private SimpleButton btnImprimir;

        private LookUpEdit cbUsuarios;

        private HyperlinkLabelControl lblUsuario;

        private PictureBox pictureBox1;

        private TextEdit txtArticulo;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnID;

        private GridColumn gridColumnArticuloID;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnSKU;

        private GridColumn gridColumnNombre;

        private RepositoryItemLookUpEdit cbGenero;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private CheckEdit cbImpreso;

        private LookUpEdit cbTipos;

        private HyperlinkLabelControl lblTipo;

        private LookUpEdit cbAlmacenes;

        private HyperlinkLabelControl lblAlmacenes;

        private XtraTabPage xtraTabPage2;

        private LayoutControlItem layoutControlItem2;

        private LabelControl lblHasta;

        private LabelControl lblDesde;

        private SimpleButton btnImportar;

        private DateEdit deHasta;

        private DateEdit deDesde;

        private LabelControl lblID;

        private LabelControl lblOpciones;

        private RadioGroup rgOpciones;

        private GridColumn gridColumnUnidadMedida;

        private RepositoryItemLookUpEdit cbUnidadesMedida;

        public frmEtiquetas(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                etiqueta = Etiqueta.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DataSource = from x in UnidadMedida.UnidadesMedida()
                                                                          where x.activo == true
                                                                          select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DataSource = (from x in Almacen.Almacenes()
                                                                                 where x.activo == true
                                                                                 select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).DataSource = (from x in Etiqueta.Tipo.Tipos()
                                                                             where x.activo == true
                                                                             select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).DataSource = (from x in Usuario.Usuarios()
                                                                                where x.activo == true
                                                                                select new { x.id, x.usuario, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).DisplayMember = "nombre";
        }

        private void Permisos()
        {
            char rol = Program.Nori.UsuarioAutenticado.rol;
            char c = rol;
            if (c == 'C')
            {
                mainRibbonPageGroup.Visible = false;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = etiqueta.id.ToString();
            ((BaseEdit)cbAlmacenes).EditValue = etiqueta.almacen_id;
            ((BaseEdit)cbTipos).EditValue = etiqueta.tipo_etiqueta_id;
            ((BaseEdit)cbUsuarios).EditValue = etiqueta.usuario_creacion_id;
            cbImpreso.Checked = etiqueta.impreso;
            ((Control)(object)lblFechaActualizacion).Text = etiqueta.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbAlmacenes).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)cbAlmacenes).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
            CargarPartidas();
        }

        private void Llenar()
        {
            etiqueta.almacen_id = (int)((BaseEdit)cbAlmacenes).EditValue;
            etiqueta.tipo_etiqueta_id = (int)((BaseEdit)cbTipos).EditValue;
            etiqueta.usuario_creacion_id = (int)((BaseEdit)cbUsuarios).EditValue;
            etiqueta.impreso = cbImpreso.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (etiqueta.id != 0)
                    {
                        return etiqueta.Actualizar();
                    }
                    return etiqueta.Agregar();
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
                etiqueta = new Etiqueta();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                etiqueta = Etiqueta.Obtener((from x in Etiqueta.Etiquetas()
                                             orderby x.id
                                             select new { x.id }).First().id);
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
                etiqueta = Etiqueta.Obtener((from x in Etiqueta.Etiquetas()
                                             where x.id < etiqueta.id
                                             orderby x.id descending
                                             select new { x.id }).First().id);
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
                etiqueta = Etiqueta.Obtener((from x in Etiqueta.Etiquetas()
                                             where x.id > etiqueta.id
                                             select new { x.id }).First().id);
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
                etiqueta = Etiqueta.Obtener((from x in Etiqueta.Etiquetas()
                                             orderby x.id descending
                                             select new { x.id }).First().id);
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
                if (etiqueta.id != 0)
                {
                    etiqueta = new Etiqueta();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "*"
                };
                object objeto = new
                {
                    almacen_id = (int)((BaseEdit)cbAlmacenes).EditValue,
                    tipo_etiqueta_id = (int)((BaseEdit)cbTipos).EditValue,
                    impreso = (cbImpreso.Checked ? 1 : 0)
                };
                DataTable dataTable = Utilidades.Busqueda("etiquetas", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        etiqueta = Etiqueta.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        etiqueta = Etiqueta.Obtener(frmResultadosBusqueda2.id);
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
            etiqueta = new Etiqueta();
            Cargar(nuevo: true);
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtArticulo).Text.Length > 0)
            {
                AgregarPartida(((Control)(object)txtArticulo).Text);
            }
        }

        private async void AgregarPartida(string q)
        {
            do
            {
                if (await Task.Run(() => etiqueta.AgregarPartida(q)))
                {
                    ((Control)(object)txtArticulo).Text = string.Empty;
                    CargarPartidas();
                    break;
                }
            }
            while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            ((Control)(object)txtArticulo).Text = string.Empty;
            ((Control)(object)txtArticulo).Focus();
        }

        private void CargarPartidas()
        {
            gcPartidas.DataSource = etiqueta.partidas;
            gcPartidas.RefreshDataSource();
        }

        private void lblAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes frmAlmacenes2 = new frmAlmacenes((int)((BaseEdit)cbAlmacenes).EditValue);
            ((Form)(object)frmAlmacenes2).ShowDialog();
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {
            frmTiposEtiquetas frmTiposEtiquetas2 = new frmTiposEtiquetas((int)((BaseEdit)cbTipos).EditValue);
            ((Form)(object)frmTiposEtiquetas2).ShowDialog();
        }

        private void gvPartidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (etiqueta.partidas.Count > 0)
                {
                    etiqueta.partidas.Remove(etiqueta.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]]);
                }
                CargarPartidas();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (etiqueta.id != 0)
                {
                    Etiqueta.Tipo tipo = Etiqueta.Tipo.Obtener(etiqueta.tipo_etiqueta_id);
                    Funciones.ImprimirInforme(tipo.formato, etiqueta.id);
                }
                else
                {
                    MessageBox.Show("Es necesario guardar antes de imprimir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> list = ((rgOpciones.SelectedIndex == 0) ? (from x in Articulo.Articulos()
                                                                     where x.fecha_actualizacion >= deDesde.DateTime && x.fecha_actualizacion <= deHasta.DateTime
                                                                     select x.id).Distinct().ToList() : (from x in Articulo.Precio.Precios()
                                                                                                         where x.fecha_actualizacion >= deDesde.DateTime && x.fecha_actualizacion <= deHasta.DateTime
                                                                                                         select x.articulo_id).Distinct().ToList());
                if (list.Count > 0)
                {
                    if (MessageBox.Show($"¿Se encontraron {list.Count} artículos desea importarlos?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    foreach (int articulo_id in list)
                    {
                        string q = (from x in Articulo.Articulos()
                                    where x.id == articulo_id
                                    select x.sku).First();
                        etiqueta.AgregarPartida(q);
                    }
                    CargarPartidas();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros coincidentes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvPartidas_ShownEditor(object sender, EventArgs e)
        {
            //IL_0003: Unknown result type (might be due to invalid IL or missing references)
            //IL_0009: Expected O, but got Unknown
            //IL_0029: Unknown result type (might be due to invalid IL or missing references)
            //IL_002f: Expected O, but got Unknown
            try
            {
                ColumnView val = (ColumnView)sender;
                if (val.FocusedColumn.FieldName == "unidad_medida_id")
                {
                    LookUpEdit val2 = (LookUpEdit)((BaseView)val).ActiveEditor;
                    int articulo_id = Convert.ToInt32(val.GetFocusedRowCellValue("articulo_id"));
                    ((RepositoryItemLookUpEditBase)val2.Properties).DataSource = Articulo.UnidadesMedida(articulo_id);
                }
            }
            catch
            {
            }
        }

   
    }

}
