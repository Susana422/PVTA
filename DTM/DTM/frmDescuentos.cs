using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace DTM
{
    public partial class frmDescuentos : RibbonForm
    {
        private DescuentoEspecial descuento = new DescuentoEspecial();

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

        private LabelControl lblEID;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LabelControl lblTipoDescuento;

        private BarButtonItem bbiUsuarios;

        private LookUpEdit cbTipoDescuento;

        private SplitContainer splitContainer1;

        private LabelControl lblCondicionesPromocion;

        private CheckEdit cbVIP;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageListaPrecios;

        private XtraTabPage xtraTabPageSociosNegocios;

        private XtraTabPage xtraTabPageGruposArticulos;

        private XtraTabPage xtraTabPageAlmacenes;

        private CheckEdit cbAlmacenes;

        private CheckEdit cbArticulos;

        private CheckEdit cbGruposArticulos;

        private CheckEdit cbSocios;

        private CheckEdit cbListasPrecios;

        private PanelControl pcVolumen;

        private GridControl gcCondiciones;

        private GridView gvCondiciones;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnDescuento;

        private GridView gridView2;

        private GridColumn gridColumnMonto;

        private GridControl gcListasPrecios;

        private GridView gvListasPrecios;

        private GridColumn gridColumnListaPrecio;

        private GridControl gcSocios;

        private GridView gvSocios;

        private GridColumn gridColumnNombreSocio;

        private GridColumn gridColumnCodigoSocio;

        private GridControl gcGruposArticulos;

        private GridView gvGruposArticulos;

        private GridColumn gridColumnGrupoArticulo;

        private GridControl gcAlmacenes;

        private GridView gvAlmacenes;

        private GridColumn gridColumnAlmacen;

        private XtraTabPage xtraTabPageArticulos;

        private RadioGroup rgArticulos;

        private RadioGroup rgAlmacenes;

        private RadioGroup rgGruposArticulos;

        private RadioGroup rgSocios;

        private RadioGroup rgListasPrecios;

        private GridControl gcArticulos;

        private GridView gvArticulos;

        private GridColumn gridColumnSKU;

        private GridColumn gridColumnNombreArticulo;

        private SimpleButton btnOrden;

        private GridColumn gridColumnListaPrecioId;

        private GridColumn gridColumnSocioId;

        private GridColumn gridColumnGrupoArticuloId;

        private GridColumn gridColumnAlmacenId;

        private GridColumn gridColumnArticuloId;

        private CheckEdit cbAcumulable;

        private LookUpEdit cbListaPrecios;

        private HyperlinkLabelControl lblListaPrecios;

        private LabelControl lblPorcentajeDescuento;

        private TextEdit txtPorcentajeDescuento;

        private SimpleButton btnImportarArticulos;

        private PictureBox pictureBox1;

        private TextEdit txtArticulo;

        private SplitContainer splitContainer2;

        public frmDescuentos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                descuento = DescuentoEspecial.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
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

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbTipoDescuento.Properties).DataSource = DescuentoEspecial.TipoDescuento.Tipos();
            ((RepositoryItemLookUpEditBase)cbTipoDescuento.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTipoDescuento.Properties).DisplayMember = "nombre";
            gcListasPrecios.DataSource = Utilidades.EjecutarQuery($"SELECT id, nombre FROM listas_precios WHERE activo = 1");
            gcSocios.DataSource = Utilidades.EjecutarQuery($"SELECT id, codigo, nombre FROM socios WHERE activo = 1 and tipo = 'C'");
            gcGruposArticulos.DataSource = Utilidades.EjecutarQuery($"SELECT id, nombre FROM grupos_articulos WHERE activo = 1");
            gcAlmacenes.DataSource = Utilidades.EjecutarQuery($"SELECT id, nombre FROM almacenes WHERE activo = 1");
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DataSource = from x in ListaPrecio.ListasPrecios()
                                                                                   where x.activo == true
                                                                                   select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            descuento.ObtenerListas();
            ((Control)(object)lblID).Text = descuento.id.ToString();
            ((BaseEdit)cbTipoDescuento).EditValue = descuento.tipo;
            ((BaseEdit)cbListaPrecios).EditValue = descuento.lista_precio_id;
            ((Control)(object)txtPorcentajeDescuento).Text = descuento.porcentaje_descuento.ToString();
            ((Control)(object)txtNombre).Text = descuento.nombre;
            cbVIP.Checked = descuento.vip;
            cbAcumulable.Checked = descuento.acumulable;
            cbListasPrecios.Checked = descuento.listas_precios;
            ((BaseEdit)rgListasPrecios).EditValue = descuento.operador_listas_precios;
            cbSocios.Checked = descuento.socios;
            ((BaseEdit)rgSocios).EditValue = descuento.operador_socios;
            cbGruposArticulos.Checked = descuento.grupos_articulos;
            ((BaseEdit)rgGruposArticulos).EditValue = descuento.operador_grupos_articulos;
            cbAlmacenes.Checked = descuento.almacenes;
            ((BaseEdit)rgAlmacenes).EditValue = descuento.operador_almacenes;
            cbArticulos.Checked = descuento.articulos;
            ((BaseEdit)rgArticulos).EditValue = descuento.operador_articulos;
            cbActivo.Checked = descuento.activo;
            ((Control)(object)xtraTabControl1).Enabled = ((descuento.id != 0) ? true : false);
            BindingList<DescuentoEspecial.Condicion> bindingList = new BindingList<DescuentoEspecial.Condicion>(descuento.lista_condiciones);
            bindingList.AddingNew += gvCondiciones_AddingNewRow;
            gcCondiciones.DataSource = bindingList;
            gcCondiciones.RefreshDataSource();
            gcCondiciones.UseEmbeddedNavigator = true;
            gcArticulos.DataSource = Utilidades.EjecutarQuery($"SELECT id, sku, nombre FROM articulos WHERE activo = 1 and venta = 1 and id in (select articulo_id from descuentos_especiales_articulos where descuento_especial_id = {descuento.id})");
            gcArticulos.RefreshDataSource();
            CargarGrids();
            ((Control)(object)lblFechaActualizacion).Text = descuento.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
        }

        private void CargarGrids()
        {
            try
            {
                ((ColumnView)gvListasPrecios).ClearSelection();
                ((ColumnView)gvSocios).ClearSelection();
                ((ColumnView)gvGruposArticulos).ClearSelection();
                ((ColumnView)gvAlmacenes).ClearSelection();
                foreach (DescuentoEspecial.ListaPrecio lista_listas_precio in descuento.lista_listas_precios)
                {
                    int num = ((ColumnView)gvListasPrecios).LocateByValue("id", (object)lista_listas_precio.lista_precio_id, Array.Empty<OperationCompleted>());
                    ((ColumnView)gvListasPrecios).SelectRow(num);
                }
                foreach (DescuentoEspecial.Socio lista_socio in descuento.lista_socios)
                {
                    int num2 = ((ColumnView)gvSocios).LocateByValue("id", (object)lista_socio.socio_id, Array.Empty<OperationCompleted>());
                    ((ColumnView)gvSocios).SelectRow(num2);
                }
                foreach (DescuentoEspecial.GrupoArticulo lista_grupos_articulo in descuento.lista_grupos_articulos)
                {
                    int num3 = ((ColumnView)gvGruposArticulos).LocateByValue("id", (object)lista_grupos_articulo.grupo_articulo_id, Array.Empty<OperationCompleted>());
                    ((ColumnView)gvGruposArticulos).SelectRow(num3);
                }
                foreach (DescuentoEspecial.Almacen lista_almacene in descuento.lista_almacenes)
                {
                    int num4 = ((ColumnView)gvAlmacenes).LocateByValue("id", (object)lista_almacene.almacen_id, Array.Empty<OperationCompleted>());
                    ((ColumnView)gvAlmacenes).SelectRow(num4);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void Llenar()
        {
            descuento.nombre = ((Control)(object)txtNombre).Text;
            descuento.tipo = (char)((BaseEdit)cbTipoDescuento).EditValue;
            descuento.porcentaje_descuento = decimal.Parse(((BaseEdit)txtPorcentajeDescuento).EditValue.ToString());
            descuento.lista_precio_id = int.Parse(((BaseEdit)cbListaPrecios).EditValue.ToString());
            descuento.vip = cbVIP.Checked;
            descuento.acumulable = cbAcumulable.Checked;
            descuento.listas_precios = cbListasPrecios.Checked;
            descuento.operador_listas_precios = (char)((BaseEdit)rgListasPrecios).EditValue;
            descuento.socios = cbSocios.Checked;
            descuento.operador_socios = (char)((BaseEdit)rgSocios).EditValue;
            descuento.grupos_articulos = cbGruposArticulos.Checked;
            descuento.operador_grupos_articulos = (char)((BaseEdit)rgGruposArticulos).EditValue;
            descuento.articulos = cbArticulos.Checked;
            descuento.operador_articulos = (char)((BaseEdit)rgArticulos).EditValue;
            descuento.almacenes = cbAlmacenes.Checked;
            descuento.operador_almacenes = (char)((BaseEdit)rgAlmacenes).EditValue;
            descuento.activo = cbActivo.Checked;
            LlenarListasPrecios();
            LlenarSocios();
            LlenarGruposArticulos();
            LlenarArticulos();
            LlenarAlmacenes();
        }

        private void LlenarListasPrecios()
        {
            try
            {
                if (descuento.id == 0)
                {
                    return;
                }
                List<int> list = ((ColumnView)gvListasPrecios).GetSelectedRows().ToList();
                List<int> list2 = new List<int>();
                foreach (int item in list)
                {
                    int lista_precio_id = int.Parse(((ColumnView)gvListasPrecios).GetRowCellValue(item, "id").ToString());
                    list2.Add(lista_precio_id);
                    if (!descuento.lista_listas_precios.Any((DescuentoEspecial.ListaPrecio x) => x.lista_precio_id == lista_precio_id))
                    {
                        DescuentoEspecial.ListaPrecio listaPrecio = new DescuentoEspecial.ListaPrecio
                        {
                            descuento_especial_id = descuento.id,
                            lista_precio_id = lista_precio_id
                        };
                        listaPrecio.Agregar();
                    }
                }
                Utilidades.EjecutarQuery(string.Format("delete from descuentos_especiales_listas_precios where descuento_especial_id = {0} and lista_precio_id not in ({1})", descuento.id, string.Join(",", list2)));
            }
            catch
            {
            }
        }

        private void LlenarSocios()
        {
            try
            {
                if (descuento.id == 0)
                {
                    return;
                }
                List<int> list = ((ColumnView)gvSocios).GetSelectedRows().ToList();
                List<int> list2 = new List<int>();
                foreach (int item in list)
                {
                    int socio_id = int.Parse(((ColumnView)gvSocios).GetRowCellValue(item, "id").ToString());
                    list2.Add(socio_id);
                    if (!descuento.lista_socios.Any((DescuentoEspecial.Socio x) => x.socio_id == socio_id))
                    {
                        DescuentoEspecial.Socio socio = new DescuentoEspecial.Socio
                        {
                            descuento_especial_id = descuento.id,
                            socio_id = socio_id
                        };
                        socio.Agregar();
                    }
                }
                Utilidades.EjecutarQuery(string.Format("delete from descuentos_especiales_socios where descuento_especial_id = {0} and socio_id not in ({1})", descuento.id, string.Join(",", list2)));
            }
            catch
            {
            }
        }

        private void LlenarGruposArticulos()
        {
            try
            {
                if (descuento.id == 0)
                {
                    return;
                }
                List<int> list = ((ColumnView)gvGruposArticulos).GetSelectedRows().ToList();
                List<int> list2 = new List<int>();
                foreach (int item in list)
                {
                    int grupo_articulo_id = int.Parse(((ColumnView)gvGruposArticulos).GetRowCellValue(item, "id").ToString());
                    list2.Add(grupo_articulo_id);
                    if (!descuento.lista_grupos_articulos.Any((DescuentoEspecial.GrupoArticulo x) => x.grupo_articulo_id == grupo_articulo_id))
                    {
                        DescuentoEspecial.GrupoArticulo grupoArticulo = new DescuentoEspecial.GrupoArticulo
                        {
                            descuento_especial_id = descuento.id,
                            grupo_articulo_id = grupo_articulo_id
                        };
                        grupoArticulo.Agregar();
                    }
                }
                Utilidades.EjecutarQuery(string.Format("delete from descuentos_especiales_grupos_articulos where descuento_especial_id = {0} and grupo_articulo_id not in ({1})", descuento.id, string.Join(",", list2)));
            }
            catch
            {
            }
        }

        private void LlenarAlmacenes()
        {
            try
            {
                if (descuento.id == 0)
                {
                    return;
                }
                List<int> list = ((ColumnView)gvAlmacenes).GetSelectedRows().ToList();
                List<int> list2 = new List<int>();
                foreach (int item in list)
                {
                    int almacen_id = int.Parse(((ColumnView)gvAlmacenes).GetRowCellValue(item, "id").ToString());
                    list2.Add(almacen_id);
                    if (!descuento.lista_almacenes.Any((DescuentoEspecial.Almacen x) => x.almacen_id == almacen_id))
                    {
                        DescuentoEspecial.Almacen almacen = new DescuentoEspecial.Almacen
                        {
                            descuento_especial_id = descuento.id,
                            almacen_id = almacen_id
                        };
                        almacen.Agregar();
                    }
                }
                Utilidades.EjecutarQuery(string.Format("delete from descuentos_especiales_almacenes where descuento_especial_id = {0} and almacen_id not in ({1})", descuento.id, string.Join(",", list2)));
            }
            catch
            {
            }
        }

        private void LlenarArticulos()
        {
            try
            {
                if (descuento.id == 0)
                {
                    return;
                }
                List<int> list = new List<int>();
                int row = 0;
                while (true)
                {
                    if (row >= ((BaseView)gvArticulos).RowCount)
                    {
                        break;
                    }
                    int articulo_id = ((!((ColumnView)gvArticulos).GetRowCellValue(row, "id").IsNullOrEmpty()) ? int.Parse(((ColumnView)gvArticulos).GetRowCellValue(row, "id").ToString()) : 0);
                    if (articulo_id == 0)
                    {
                        var anon = (from x in Articulo.Articulos()
                                    where x.sku == ((ColumnView)gvArticulos).GetRowCellValue(row, "sku").ToString()
                                    select new { x.id, x.nombre }).FirstOrDefault();
                        if (!anon.IsNullOrEmpty())
                        {
                            articulo_id = anon.id;
                        }
                    }
                    list.Add(articulo_id);
                    if (!descuento.lista_articulos.Any((DescuentoEspecial.Articulo x) => x.articulo_id == articulo_id))
                    {
                        DescuentoEspecial.Articulo articulo = new DescuentoEspecial.Articulo
                        {
                            descuento_especial_id = descuento.id,
                            articulo_id = articulo_id
                        };
                        articulo.Agregar();
                    }
                    row++;
                }
                Utilidades.EjecutarQuery(string.Format("delete from descuentos_especiales_articulos where descuento_especial_id = {0} and articulo_id not in ({1})", descuento.id, string.Join(",", list)));
            }
            catch
            {
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (descuento.id != 0)
                    {
                        return descuento.Actualizar();
                    }
                    return descuento.Agregar();
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                descuento = new DescuentoEspecial();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                descuento = (from x in DescuentoEspecial.DescuentosEspeciales()
                             orderby x.id
                             select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                descuento = (from x in DescuentoEspecial.DescuentosEspeciales()
                             where x.id < descuento.id
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
                descuento = (from x in DescuentoEspecial.DescuentosEspeciales()
                             where x.id > descuento.id
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
                descuento = (from x in DescuentoEspecial.DescuentosEspeciales()
                             orderby x.id descending
                             select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (descuento.id != 0)
                {
                    descuento = new DescuentoEspecial();
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
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("descuentos_especiales", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        descuento = DescuentoEspecial.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        descuento = DescuentoEspecial.Obtener(frmResultadosBusqueda2.id);
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
            descuento = new DescuentoEspecial();
            Cargar(nuevo: true);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmOrdenDescuentosEspeciales frmOrdenDescuentosEspeciales2 = new frmOrdenDescuentosEspeciales();
            ((Form)(object)frmOrdenDescuentosEspeciales2).ShowDialog();
        }

        private void gvCondiciones_AddingNewRow(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DescuentoEspecial.Condicion();
        }

        private void cbListasPrecios_CheckedChanged(object sender, EventArgs e)
        {
            xtraTabPageListaPrecios.PageEnabled = cbListasPrecios.Checked;
            xtraTabPageSociosNegocios.PageEnabled = cbSocios.Checked;
            xtraTabPageGruposArticulos.PageEnabled = cbGruposArticulos.Checked;
            xtraTabPageArticulos.PageEnabled = cbArticulos.Checked;
            xtraTabPageAlmacenes.PageEnabled = cbAlmacenes.Checked;
        }

        private void cbTipoDescuento_EditValueChanged(object sender, EventArgs e)
        {
            if (!(((BaseEdit)cbTipoDescuento).EditValue is char c))
            {
                return;
            }
            switch (c)
            {
                case 'V':
                    ((Control)(object)gcCondiciones).Enabled = true;
                    ((Control)(object)cbListaPrecios).Enabled = false;
                    ((Control)(object)txtPorcentajeDescuento).Enabled = false;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnCantidad").First().Visible = true;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnMonto").First().Visible = false;
                    break;
                case 'K':
                    ((Control)(object)gcCondiciones).Enabled = true;
                    ((Control)(object)cbListaPrecios).Enabled = false;
                    ((Control)(object)txtPorcentajeDescuento).Enabled = false;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnCantidad").First().Visible = true;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnMonto").First().Visible = false;
                    break;
                case 'M':
                    ((Control)(object)gcCondiciones).Enabled = true;
                    ((Control)(object)cbListaPrecios).Enabled = false;
                    ((Control)(object)txtPorcentajeDescuento).Enabled = false;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnCantidad").First().Visible = false;
                    ((IEnumerable<GridColumn>)((ColumnView)gvCondiciones).Columns).Where((GridColumn x) => x.Name == "gridColumnMonto").First().Visible = true;
                    break;
                case 'D':
                    ((Control)(object)gcCondiciones).Enabled = false;
                    ((Control)(object)cbListaPrecios).Enabled = false;
                    ((Control)(object)txtPorcentajeDescuento).Enabled = true;
                    break;
                case 'P':
                    ((Control)(object)gcCondiciones).Enabled = false;
                    ((Control)(object)cbListaPrecios).Enabled = true;
                    ((Control)(object)txtPorcentajeDescuento).Enabled = false;
                    break;
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Tab || ((Control)(object)txtArticulo).Text.Length <= 0)
                {
                    return;
                }
                string text = ((Control)(object)txtArticulo).Text;
                decimal num = 1m;
                if (text.Contains("*"))
                {
                    num = decimal.Parse(text.Split('*')[0]);
                    text = text.Split('*')[1];
                }
                ConsultaPersonalizada consultaPersonalizada = ConsultaPersonalizada.Obtener("txtArticulo");
                consultaPersonalizada.query = "SELECT articulos.id, sku as sku_articulo, articulos.nombre FROM articulos WHERE (sku = '{q}' OR articulos.nombre LIKE '%{q}%' OR codigo_barras LIKE '%{q}%') AND venta = 1 AND articulos.activo = 1";
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{q}", text.Replace(" ", "%"));
                DataTable dataTable = consultaPersonalizada.Ejecutar();
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        int rowCount = ((BaseView)gvArticulos).RowCount;
                        ((ColumnView)gvArticulos).AddNewRow();
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "id", (object)dataTable.Rows[0][0].ToString());
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "sku", (object)dataTable.Rows[0][1].ToString());
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "nombre", (object)dataTable.Rows[0][2].ToString());
                        return;
                    }
                    frmResultadosBusquedaArticulos frmResultadosBusquedaArticulos2 = new frmResultadosBusquedaArticulos(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusquedaArticulos2).ShowDialog();
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    ((Control)(object)this).Cursor = Cursors.WaitCursor;
                    foreach (int fila in frmResultadosBusquedaArticulos2.filas)
                    {
                        ((ColumnView)gvArticulos).AddNewRow();
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "id", (object)dataTable.Rows[fila][0].ToString());
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "sku", (object)dataTable.Rows[fila][1].ToString());
                        ((ColumnView)gvArticulos).SetRowCellValue(-2147483647, "nombre", (object)dataTable.Rows[fila][2].ToString());
                    }
                    ((Control)(object)this).Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {text}", ((Control)(object)this).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                gcArticulos.RefreshDataSource();
                ((BaseView)gvArticulos).CloseEditor();
                ((Control)(object)txtArticulo).Focus();
            }
        }

        private void gvArticulos_ClipboardRowPasting(object sender, ClipboardRowPastingEventArgs e)
        {
            try
            {
                var obj = (from x in Articulo.Articulos()
                           where x.sku == e.Values["sku"].ToString()
                           select new { x.id, x.sku, x.nombre }).FirstOrDefault();
                if (obj.IsNullOrEmpty())
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void gcArticulos_Click(object sender, EventArgs e)
        {
        }


    }

}
