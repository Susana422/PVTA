using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;
using NoriSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmArticulos : RibbonForm
    {
        private Articulo articulo = new Articulo();

        private Articulo.Precio precio = new Articulo.Precio();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private RibbonPageGroup searchRibbonPageGroup;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BackstageViewControl backstageViewControl1;

        private BarButtonItem bbiNuevo;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageGeneral;

        private LabelControl lblPrecio;

        private TextEdit txtPrecio;

        private TextEdit txtCodigoBarras;

        private GroupBox gbSeguimento;

        private RadioButton rbSeries;

        private RadioButton rbNormal;

        private CheckEdit cbCanjeable;

        private CheckEdit cbCompra;

        private CheckEdit cbVenta;

        private CheckEdit cbAlmacenable;

        private LabelControl lblDescripcion;

        private TextEdit txtDescripcion;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblSKU;

        private TextEdit txtSKU;

        private XtraTabPage xtraTabPageDatosInventario;

        private LayoutControlGroup layoutControlGroup1;

        private LayoutControlItem layoutControlItem1;

        private DataLayoutControl dataLayoutControl1;

        private LabelControl lblStock;

        private TextEdit txtStock;

        private PictureBox pbImagen;

        private LabelControl lblDiasGarantia;

        private TextEdit txtDiasGarantia;

        private LabelControl lblUltimaActualizacion;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblID;

        private SimpleButton btnImagen;

        private CheckEdit cbActivo;

        private HyperlinkLabelControl lblGrupoArticulos;

        private GridControl gcInventario;

        private GridView gvInventario;

        private GridColumn id;

        private GridColumn articulo_id;

        private GridColumn codigo;

        private GridColumn nombre;

        private GridColumn activo;

        private GridColumn stock;

        private GridColumn comprometido;

        private GridColumn pedido;

        private GridColumn fecha_llegada;

        private GridColumn disponible;

        private GridColumn stock_minimo;

        private GridColumn stock_maximo;

        private GridColumn ubicacion;

        private LookUpEdit cbGruposArticulos;

        private HyperlinkLabelControl lblListaPrecios;

        private LookUpEdit cbListasPrecios;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private LookUpEdit cbFabricantes;

        private HyperlinkLabelControl lblFabricantes;

        private XtraTabPage xtraTabPageUbicaciones;

        private GridControl gcUbicaciones;

        private GridView gvUbicaciones;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private GridColumn gridColumn3;

        private GridColumn gridColumn4;

        private RepositoryItemLookUpEdit cbAlmacenes;

        private GridColumn gridColumn5;

        private LabelControl lblMultiplicador;

        private TextEdit txtMultiplicador;

        private HyperlinkLabelControl lblCodigoBarras;

        private LabelControl lblIDAdicional;

        private TextEdit txtIDAdicional;

        private LookUpEdit cbAlmacen;

        private HyperlinkLabelControl lblAlmacen;

        private XtraTabPage xtraTabPageDatosCompras;

        private XtraTabPage xtraTabPageDatosVentas;

        private LookUpEdit cbTiposEmpaques;

        private HyperlinkLabelControl lblTiposEmpaques;

        private CheckEdit cbPesable;

        private LabelControl lblClaveUnidad;

        private TextEdit txtClaveUnidad;

        private LabelControl lblPeso;

        private TextEdit txtPeso;

        private CheckEdit cbIEPS;

        private CheckEdit cbSujetoImpuesto;

        private CheckEdit cbSujetoRetencion;

        private LabelControl lblSkuFabricante;

        private TextEdit txtSKUFabricante;

        private LookUpEdit cbImpuestosCompras;

        private HyperlinkLabelControl lblImpuestoCompra;

        private LookUpEdit cbImpuestosVentas;

        private HyperlinkLabelControl lblImpuestoVenta;

        private RadioButton rbLotes;

        private LabelControl lblCodigoClasificacion;

        private LabelControl lblCantidadPaquete;

        private TextEdit txtCantidadPaquete;

        private TextEdit txtCodigoClasificacion;

        private TextEdit txtAjusteMaximo;

        private LabelControl lblRangoAjuste;

        private TextEdit txtAjusteMinimo;

        private LookUpEdit cbProveedores;

        private HyperlinkLabelControl lblProveedor;

        private SimpleButton btnAgregarAlInventario;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        private XtraTabPage xtraTabPagePropiedades;

        private CheckedListBoxControl cbPropiedades;

        private LabelControl lblPedidoMinimo;

        private TextEdit txtPedidoMinimo;

        private GridColumn punto_reorden;

        private LookUpEdit cbUnidadesMedidaVenta;

        private CheckEdit cbAPI;

        private CheckedComboBoxEdit cbRutas;

        private HyperlinkLabelControl lblRuta;

        private LabelControl lblNombreAPI;

        private TextEdit txtNombreAPI;

        private LabelControl lblCantidadCompra;

        private TextEdit txtCantidadCompra;

        private LabelControl lblCantidadVenta;

        private TextEdit txtCantidadVenta;

        private LookUpEdit cbUnidadesMedidaCompra;

        private LookUpEdit cbUnidadesMedidaInventario;

        private LabelControl lblUnidadMedida;

        private HyperlinkLabelControl lblUnidadMedidaCompra;

        private HyperlinkLabelControl lblUnidadMedidaVenta;

        private LabelControl lblGrupos;

        private CheckedComboBoxEdit cbGrupos;

        private CheckEdit cbEntregaAutomatica;

        private CheckEdit cbExcluirSincronizacion;

        private BarButtonItem barButtonItemDescuentos;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroup1;

        private CheckEdit cbWeb;

        private SimpleButton btnVisualizarImagen;

        private SimpleButton btnAnexarImagen;

        private ListBoxControl lbImagenes;

        private XtraTabPage xtraTabPageWeb;

        private LabelControl labelControl1;

        private LabelControl labelControl4;

        private RichEditControl txtAplicacionesWeb;

        private LabelControl labelControl3;

        private RichEditControl txtCaracteristicasWeb;

        private LabelControl labelControl2;

        private RichEditControl txtInformacionAdicionalWeb;

        private TextEdit txtPalabrasClave;

        private LabelControl labelControl5;

        private RichEditControl txtDescripcionWeb;

        private BarButtonItem bbiParametrizacionesFormulario;

        private BarButtonItem bbiPartidasAbiertas;

        private PopupMenu popupMenu1;

        private BarButtonItem bbiPaquetes;

        private GridControl gcArticulosSociosCFDI;

        private GridView gvArticulosSociosCFDI;

        private GridColumn gridColumnId;

        private GridColumn gridColumnSocio;

        private RepositoryItemGridLookUpEdit cbSocios2;

        private GridView repositoryItemGridLookUpEdit1View;

        private RepositoryItemLookUpEdit cbSocios;

        private GridColumn gridColumnImpuesto;

        private RepositoryItemLookUpEdit cbImpuestos;

        private GridColumn gridColumnClaveUnidad;

        private GridColumn gridColumnCodigoClasificacion;

        private LabelControl labelControl6;

        public frmArticulos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                articulo = Articulo.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarListas();
            Permisos();
            EventoControl.SuscribirEventos((Form)(object)this);
        }

        private void Permisos()
        {
            ((BarItem)bbiParametrizacionesFormulario).Enabled = false;
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'A':
                    ((BarItem)bbiParametrizacionesFormulario).Enabled = true;
                    break;
                case 'C':
                    ((Control)(object)lblGrupoArticulos).Enabled = false;
                    ((Control)(object)lblListaPrecios).Enabled = false;
                    ((Control)(object)lblMonedas).Enabled = false;
                    ((Control)(object)lblFabricantes).Enabled = false;
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    ((Control)(object)lblGrupoArticulos).Enabled = false;
                    ((Control)(object)lblListaPrecios).Enabled = false;
                    ((Control)(object)lblMonedas).Enabled = false;
                    ((Control)(object)lblFabricantes).Enabled = false;
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'S':
                    ((Control)(object)lblListaPrecios).Enabled = false;
                    ((Control)(object)lblMonedas).Enabled = false;
                    ((Control)(object)lblFabricantes).Enabled = false;
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
            if (!ParametrizacionFormulario.Parametrizaciones().Any((ParametrizacionFormulario x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id || ((int?)x.rol == (int?)Program.Nori.UsuarioAutenticado.rol && x.formulario == ((Control)(object)this).Name)))
            {
                return;
            }
            List<ParametrizacionFormulario> list = ParametrizacionFormulario.Obtener(((Control)this).Name, "AR");
            foreach (ParametrizacionFormulario item in list)
            {
                Control control = ((Control)this).Controls.Find(item.control, searchAllChildren: true).FirstOrDefault();
                if (control != null)
                {
                    control.Enabled = !item.desactivado;
                    control.Visible = !item.oculto;
                }
                  
                else
                {
                    try
                    {
                        SetButtonVisibility(this.mainRibbonControl, item.control, item.oculto, item.desactivado);
                        ((ColumnView)gvInventario).Columns.ColumnByName(item.control).Visible = !item.oculto;
                        ((ColumnView)gvInventario).Columns.ColumnByName(item.control).OptionsColumn.AllowEdit = !item.desactivado;
                    }
                    catch (Exception ex)
                    {
                    }

                }
            }
        }
        public void SetButtonVisibility(RibbonControl ribbon, string buttonName, bool oculto, bool desactivado)
        {
            // Buscar el BarButtonItem por su nombre en los items del RibbonControl
            foreach (var item in ribbon.Items)
            {
                // Verificar si el item es un BarButtonItem
                if (item is DevExpress.XtraBars.BarButtonItem buttonItem && buttonItem.Name == buttonName)
                {
                    // Cambiar la visibilidad del botón
                    buttonItem.Visibility = oculto ? BarItemVisibility.Never : BarItemVisibility.Always;

                    // Cambiar el estado de habilitación
                    buttonItem.Enabled = !desactivado;  // Si 'desactivado' es true, deshabilita el botón
                    break;  // Detener la búsqueda después de encontrar el botón
                }
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
                articulo = new Articulo();
                Cargar();
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            if (articulo.id != 0)
            {
                gcInventario.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM DatosInventario WHERE articulo_id = {articulo.id}");
                gcUbicaciones.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM ubicaciones_articulos WHERE articulo_id = {articulo.id}");
                gcArticulosSociosCFDI.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM articulos_socios_cfdi WHERE articulo_id = {articulo.id}");
                dtgrvArticulosAlternativos.DataSource = Utilidades.EjecutarQuery($"SELECT alt_articulo FROM articulos_alternativos WHERE articulo = '{articulo.sku}'");
            }
            ((Control)(object)lblID).Text = articulo.id.ToString();
            ((BaseEdit)cbGruposArticulos).EditValue = articulo.grupo_articulo_id;
            ((BaseEdit)cbFabricantes).EditValue = articulo.fabricante_id;
            ((BaseEdit)cbAlmacen).EditValue = articulo.almacen_id;
            ((BaseEdit)cbTiposEmpaques).EditValue = articulo.tipo_empaque_id;
            cbAlmacenable.Checked = articulo.almacenable;
            cbVenta.Checked = articulo.venta;
            cbCompra.Checked = articulo.compra;
            cbCanjeable.Checked = articulo.canjeable;
            switch (articulo.seguimiento)
            {
                case 'N':
                    rbNormal.Checked = true;
                    break;
                case 'S':
                    rbSeries.Checked = true;
                    break;
                case 'L':
                    rbLotes.Checked = true;
                    break;
            }
            ((Control)(object)txtDiasGarantia).Text = articulo.dias_garantia.ToString();
            ((Control)(object)txtSKU).Text = articulo.sku;
            ((BaseEdit)cbProveedores).EditValue = articulo.socio_id;
            ((Control)(object)txtSKUFabricante).Text = articulo.sku_fabricante;
            ((Control)(object)txtIDAdicional).Text = articulo.id_adicional;
            ((Control)(object)txtNombre).Text = articulo.nombre;
            ((Control)(object)txtDescripcion).Text = articulo.descripcion;
            ((Control)(object)txtNombreAPI).Text = articulo.nombre_api;
            pbImagen.LoadImage(articulo.imagen);
            ((Control)(object)txtCodigoBarras).Text = articulo.codigo_barras;
            ((Control)(object)txtClaveUnidad).Text = articulo.clave_unidad;
            ((BaseEdit)cbUnidadesMedidaInventario).EditValue = articulo.unidad_medida_id;
            ((BaseEdit)cbUnidadesMedidaCompra).EditValue = articulo.unidad_medida_compra_id;
            ((BaseEdit)cbUnidadesMedidaVenta).EditValue = articulo.unidad_medida_venta_id;
            ((Control)(object)txtCodigoClasificacion).Text = articulo.codigo_clasificacion;
            ((Control)(object)txtStock).Text = articulo.Stock().ToString();
            ((Control)(object)txtPeso).Text = articulo.peso.ToString();
            ((Control)(object)txtCantidadCompra).Text = articulo.cantidad_compra.ToString();
            ((Control)(object)txtCantidadVenta).Text = articulo.cantidad_venta.ToString();
            ((Control)(object)txtCantidadPaquete).Text = articulo.cantidad_paquete.ToString();
            cbPesable.Checked = articulo.pesable;
            cbEntregaAutomatica.Checked = articulo.entrega_automatica;
            ((Control)(object)txtAjusteMaximo).Text = articulo.ajuste_maximo.ToString();
            ((Control)(object)txtAjusteMinimo).Text = articulo.ajuste_minimo.ToString();
            ((Control)(object)txtPedidoMinimo).Text = articulo.pedido_minimo.ToString();
            cbSujetoRetencion.Checked = articulo.sujeto_retencion;
            cbSujetoImpuesto.Checked = articulo.sujeto_impuesto;
            cbIEPS.Checked = articulo.ieps;
            ((BaseEdit)cbImpuestosCompras).EditValue = articulo.impuesto_compra_id;
            ((BaseEdit)cbImpuestosVentas).EditValue = articulo.impuesto_venta_id;
            ((Control)(object)txtComentario).Text = articulo.comentario;
            cbAPI.Checked = articulo.api;
            cbActivo.Checked = articulo.activo;
            cbWeb.Checked = articulo.web;
            cbExcluirSincronizacion.Checked = articulo.excluir_sincronizacion;
            ((Control)(object)lblFechaActualizacion).Text = articulo.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtSKU).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((BaseEdit)cbGruposArticulos).EditValue = null;
                ((BaseEdit)cbFabricantes).EditValue = null;
                ((Control)(object)txtSKU).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
            XtraTabPage obj = xtraTabPageDatosInventario;
            bool pageVisible = (xtraTabPageUbicaciones.PageVisible = ((articulo.id != 0 && cbAlmacenable.Checked) ? true : false));
            obj.PageVisible = pageVisible;
            CargarPrecio();
            CargarPropiedades();
            CargarRutas();
            CargarGrupos();
            CargarImagenes();
            CargarWeb();

        }



        private void CargarPrecio()
        {
            if (((BaseEdit)cbListasPrecios).EditValue != null && ((BaseEdit)cbMonedas).EditValue != null)
            {
                precio = Articulo.Precio.Obtener(articulo.id, (int)((BaseEdit)cbListasPrecios).EditValue, articulo.unidad_medida_id);
                ((BaseEdit)cbMonedas).EditValue = precio.moneda_id;
                ((Control)(object)txtPrecio).Text = precio.precio.ToString();
                ((Control)(object)txtMultiplicador).Text = precio.multiplicador_puntos.ToString();
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
                RepositoryItemLookUpEdit properties = cbUnidadesMedidaInventario.Properties;
                RepositoryItemLookUpEdit properties2 = cbUnidadesMedidaCompra.Properties;
                object obj = (((RepositoryItemLookUpEditBase)cbUnidadesMedidaVenta.Properties).DataSource = Utilidades.Busqueda("unidades_medida", objeto, parametros));
                object dataSource = (((RepositoryItemLookUpEditBase)properties2).DataSource = obj);
                ((RepositoryItemLookUpEditBase)properties).DataSource = dataSource;
                RepositoryItemLookUpEdit properties3 = cbUnidadesMedidaInventario.Properties;
                RepositoryItemLookUpEdit properties4 = cbUnidadesMedidaCompra.Properties;
                string text2 = (((RepositoryItemLookUpEditBase)cbUnidadesMedidaVenta.Properties).ValueMember = "id");
                string valueMember = (((RepositoryItemLookUpEditBase)properties4).ValueMember = text2);
                ((RepositoryItemLookUpEditBase)properties3).ValueMember = valueMember;
                RepositoryItemLookUpEdit properties5 = cbUnidadesMedidaInventario.Properties;
                RepositoryItemLookUpEdit properties6 = cbUnidadesMedidaCompra.Properties;
                text2 = (((RepositoryItemLookUpEditBase)cbUnidadesMedidaVenta.Properties).DisplayMember = "nombre");
                valueMember = (((RepositoryItemLookUpEditBase)properties6).DisplayMember = text2);
                ((RepositoryItemLookUpEditBase)properties5).DisplayMember = valueMember;
                ((RepositoryItemLookUpEditBase)cbProveedores.Properties).DataSource = (from x in Socio.Socios()
                                                                                       where x.tipo == 'P' && x.activo == true
                                                                                       select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbProveedores.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbProveedores.Properties).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)cbSocios).DataSource = (from x in Socio.Socios()
                                                                       where x.tipo == 'C' && x.activo == true
                                                                       select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbSocios).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbSocios).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).DataSource = Utilidades.Busqueda("fabricantes", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DataSource = Utilidades.Busqueda("monedas", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbMonedas.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbMonedas).EditValue = Program.Nori.Configuracion.moneda_id;
                RepositoryItemLookUpEdit properties7 = cbAlmacen.Properties;
                dataSource = (((RepositoryItemLookUpEditBase)cbAlmacenes).DataSource = Utilidades.Busqueda("almacenes", objeto, parametros));
                ((RepositoryItemLookUpEditBase)properties7).DataSource = dataSource;
                RepositoryItemLookUpEdit properties8 = cbAlmacen.Properties;
                valueMember = (((RepositoryItemLookUpEditBase)cbAlmacenes).ValueMember = "id");
                ((RepositoryItemLookUpEditBase)properties8).ValueMember = valueMember;
                RepositoryItemLookUpEdit properties9 = cbAlmacen.Properties;
                valueMember = (((RepositoryItemLookUpEditBase)cbAlmacenes).DisplayMember = "nombre");
                ((RepositoryItemLookUpEditBase)properties9).DisplayMember = valueMember;
                ((RepositoryItemLookUpEditBase)cbImpuestosCompras.Properties).DataSource = Utilidades.Busqueda("impuestos", new
                {
                    compra = 1
                }, parametros);
                ((RepositoryItemLookUpEditBase)cbImpuestosVentas.Properties).DataSource = Utilidades.Busqueda("impuestos", new
                {
                    venta = 1
                }, parametros);
                ((RepositoryItemLookUpEditBase)cbImpuestos).DataSource = Utilidades.Busqueda("impuestos", new
                {
                    venta = 1
                }, parametros);
                RepositoryItemLookUpEdit properties10 = cbImpuestosCompras.Properties;
                RepositoryItemLookUpEdit properties11 = cbImpuestosVentas.Properties;
                text2 = (((RepositoryItemLookUpEditBase)cbImpuestos).ValueMember = "id");
                valueMember = (((RepositoryItemLookUpEditBase)properties11).ValueMember = text2);
                ((RepositoryItemLookUpEditBase)properties10).ValueMember = valueMember;
                RepositoryItemLookUpEdit properties12 = cbImpuestosCompras.Properties;
                RepositoryItemLookUpEdit properties13 = cbImpuestosVentas.Properties;
                text2 = (((RepositoryItemLookUpEditBase)cbImpuestos).DisplayMember = "nombre");
                valueMember = (((RepositoryItemLookUpEditBase)properties13).DisplayMember = text2);
                ((RepositoryItemLookUpEditBase)properties12).DisplayMember = valueMember;
                parametros = new
                {
                    fields = "id, nombre"
                };
                ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).DataSource = Utilidades.Busqueda("listas_precios", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbListasPrecios).EditValue = Program.Nori.Configuracion.lista_precio_id;
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques.Properties).DataSource = Utilidades.Busqueda("tipos_empaques", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques.Properties).DisplayMember = "nombre";
                cbRutas.Properties.DataSource = Utilidades.Busqueda("rutas", objeto, parametros);
                cbRutas.Properties.ValueMember = "id";
                cbRutas.Properties.DisplayMember = "nombre";
                cbGrupos.Properties.DataSource = ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DataSource;
                cbGrupos.Properties.ValueMember = "id";
                cbGrupos.Properties.DisplayMember = "nombre";
                for (int i = 0; i < 32; i++)
                {
                    ((ListBoxItemCollection)((BaseCheckedListBoxControl)cbPropiedades).Items).Add((object)$"Propiedad {i + 1}");
                }
            }
            catch
            {
            }
        }

        private void CargarPropiedades()
        {
            try
            {
                ((BaseCheckedListBoxControl)cbPropiedades).Items[0].CheckState = (articulo.propiedad_1 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[1].CheckState = (articulo.propiedad_2 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[2].CheckState = (articulo.propiedad_3 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[3].CheckState = (articulo.propiedad_4 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[4].CheckState = (articulo.propiedad_5 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[5].CheckState = (articulo.propiedad_6 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[6].CheckState = (articulo.propiedad_7 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[7].CheckState = (articulo.propiedad_8 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[8].CheckState = (articulo.propiedad_9 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[9].CheckState = (articulo.propiedad_10 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[10].CheckState = (articulo.propiedad_11 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[11].CheckState = (articulo.propiedad_12 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[12].CheckState = (articulo.propiedad_13 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[13].CheckState = (articulo.propiedad_14 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[14].CheckState = (articulo.propiedad_15 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[15].CheckState = (articulo.propiedad_16 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[16].CheckState = (articulo.propiedad_17 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[17].CheckState = (articulo.propiedad_18 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[18].CheckState = (articulo.propiedad_19 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[19].CheckState = (articulo.propiedad_20 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[20].CheckState = (articulo.propiedad_21 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[21].CheckState = (articulo.propiedad_22 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[22].CheckState = (articulo.propiedad_23 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[23].CheckState = (articulo.propiedad_24 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[24].CheckState = (articulo.propiedad_25 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[25].CheckState = (articulo.propiedad_26 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[26].CheckState = (articulo.propiedad_27 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[27].CheckState = (articulo.propiedad_28 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[28].CheckState = (articulo.propiedad_29 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[29].CheckState = (articulo.propiedad_30 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[30].CheckState = (articulo.propiedad_31 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[31].CheckState = (articulo.propiedad_32 ? CheckState.Checked : CheckState.Unchecked);
            }
            catch
            {
            }
        }

        private void CargarRutas()
        {
            try
            {
                List<Articulo.Ruta> source = articulo.Rutas();
                cbRutas.SetEditValue((object)string.Join(",", source.Select((Articulo.Ruta x) => x.ruta_id).ToList()));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void CargarGrupos()
        {
            try
            {
                List<Articulo.Grupo> source = articulo.Grupos();
                cbGrupos.SetEditValue((object)string.Join(",", source.Select((Articulo.Grupo x) => x.grupo_articulo_id).ToList()));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void Llenar()
        {
            articulo.grupo_articulo_id = ((!((BaseEdit)cbGruposArticulos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposArticulos).EditValue) : 0);
            articulo.socio_id = ((!((BaseEdit)cbProveedores).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbProveedores).EditValue) : 0);
            articulo.fabricante_id = ((!((BaseEdit)cbFabricantes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbFabricantes).EditValue) : 0);
            articulo.almacen_id = ((!((BaseEdit)cbAlmacen).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbAlmacen).EditValue) : 0);
            articulo.tipo_empaque_id = ((!((BaseEdit)cbTiposEmpaques).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbTiposEmpaques).EditValue) : 0);
            articulo.unidad_medida_id = ((!((BaseEdit)cbUnidadesMedidaInventario).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUnidadesMedidaInventario).EditValue) : 0);
            articulo.unidad_medida_compra_id = ((!((BaseEdit)cbUnidadesMedidaCompra).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUnidadesMedidaCompra).EditValue) : 0);
            articulo.unidad_medida_venta_id = ((!((BaseEdit)cbUnidadesMedidaVenta).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUnidadesMedidaVenta).EditValue) : 0);
            articulo.almacenable = cbAlmacenable.Checked;
            articulo.venta = cbVenta.Checked;
            articulo.compra = cbCompra.Checked;
            articulo.canjeable = cbCanjeable.Checked;
            if (rbNormal.Checked)
            {
                articulo.seguimiento = 'N';
            }
            else if (rbSeries.Checked)
            {
                articulo.seguimiento = 'S';
            }
            else if (rbLotes.Checked)
            {
                articulo.seguimiento = 'L';
            }
            articulo.dias_garantia = short.Parse(((Control)(object)txtDiasGarantia).Text);
            articulo.sku = ((Control)(object)txtSKU).Text;
            articulo.sku_fabricante = ((Control)(object)txtSKUFabricante).Text;
            articulo.id_adicional = ((Control)(object)txtIDAdicional).Text;
            articulo.nombre = ((Control)(object)txtNombre).Text;
            articulo.descripcion = ((Control)(object)txtDescripcion).Text;
            articulo.nombre_api = ((Control)(object)txtNombreAPI).Text;
            articulo.codigo_barras = ((Control)(object)txtCodigoBarras).Text;
            articulo.clave_unidad = ((Control)(object)txtClaveUnidad).Text;
            articulo.codigo_clasificacion = ((Control)(object)txtCodigoClasificacion).Text;
            articulo.peso = decimal.Parse(((BaseEdit)txtPeso).EditValue.ToString());
            articulo.cantidad_compra = decimal.Parse(((BaseEdit)txtCantidadCompra).EditValue.ToString());
            articulo.cantidad_venta = decimal.Parse(((BaseEdit)txtCantidadVenta).EditValue.ToString());
            articulo.cantidad_paquete = decimal.Parse(((BaseEdit)txtCantidadPaquete).EditValue.ToString());
            articulo.pesable = cbPesable.Checked;
            articulo.entrega_automatica = cbEntregaAutomatica.Checked;
            articulo.ajuste_maximo = decimal.Parse(((BaseEdit)txtAjusteMaximo).EditValue.ToString());
            articulo.ajuste_minimo = decimal.Parse(((BaseEdit)txtAjusteMinimo).EditValue.ToString());
            articulo.pedido_minimo = decimal.Parse(((BaseEdit)txtPedidoMinimo).EditValue.ToString());
            articulo.sujeto_retencion = cbSujetoRetencion.Checked;
            articulo.sujeto_impuesto = cbSujetoImpuesto.Checked;
            articulo.ieps = cbIEPS.Checked;
            articulo.impuesto_compra_id = ((!((BaseEdit)cbImpuestosCompras).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbImpuestosCompras).EditValue) : 0);
            articulo.impuesto_venta_id = ((!((BaseEdit)cbImpuestosVentas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbImpuestosVentas).EditValue) : 0);
            articulo.comentario = ((Control)(object)txtComentario).Text;
            articulo.api = cbAPI.Checked;
            articulo.web = cbWeb.Checked;
            articulo.activo = cbActivo.Checked;
            articulo.excluir_sincronizacion = cbExcluirSincronizacion.Checked;
            try
            {
                articulo.propiedad_1 = ((BaseCheckedListBoxControl)cbPropiedades).Items[0].CheckState == CheckState.Checked;
                articulo.propiedad_2 = ((BaseCheckedListBoxControl)cbPropiedades).Items[1].CheckState == CheckState.Checked;
                articulo.propiedad_3 = ((BaseCheckedListBoxControl)cbPropiedades).Items[2].CheckState == CheckState.Checked;
                articulo.propiedad_4 = ((BaseCheckedListBoxControl)cbPropiedades).Items[3].CheckState == CheckState.Checked;
                articulo.propiedad_5 = ((BaseCheckedListBoxControl)cbPropiedades).Items[4].CheckState == CheckState.Checked;
                articulo.propiedad_6 = ((BaseCheckedListBoxControl)cbPropiedades).Items[5].CheckState == CheckState.Checked;
                articulo.propiedad_7 = ((BaseCheckedListBoxControl)cbPropiedades).Items[6].CheckState == CheckState.Checked;
                articulo.propiedad_8 = ((BaseCheckedListBoxControl)cbPropiedades).Items[7].CheckState == CheckState.Checked;
                articulo.propiedad_9 = ((BaseCheckedListBoxControl)cbPropiedades).Items[8].CheckState == CheckState.Checked;
                articulo.propiedad_10 = ((BaseCheckedListBoxControl)cbPropiedades).Items[9].CheckState == CheckState.Checked;
                articulo.propiedad_11 = ((BaseCheckedListBoxControl)cbPropiedades).Items[10].CheckState == CheckState.Checked;
                articulo.propiedad_12 = ((BaseCheckedListBoxControl)cbPropiedades).Items[11].CheckState == CheckState.Checked;
                articulo.propiedad_13 = ((BaseCheckedListBoxControl)cbPropiedades).Items[12].CheckState == CheckState.Checked;
                articulo.propiedad_14 = ((BaseCheckedListBoxControl)cbPropiedades).Items[13].CheckState == CheckState.Checked;
                articulo.propiedad_15 = ((BaseCheckedListBoxControl)cbPropiedades).Items[14].CheckState == CheckState.Checked;
                articulo.propiedad_16 = ((BaseCheckedListBoxControl)cbPropiedades).Items[15].CheckState == CheckState.Checked;
                articulo.propiedad_17 = ((BaseCheckedListBoxControl)cbPropiedades).Items[16].CheckState == CheckState.Checked;
                articulo.propiedad_18 = ((BaseCheckedListBoxControl)cbPropiedades).Items[17].CheckState == CheckState.Checked;
                articulo.propiedad_19 = ((BaseCheckedListBoxControl)cbPropiedades).Items[18].CheckState == CheckState.Checked;
                articulo.propiedad_20 = ((BaseCheckedListBoxControl)cbPropiedades).Items[19].CheckState == CheckState.Checked;
                articulo.propiedad_21 = ((BaseCheckedListBoxControl)cbPropiedades).Items[20].CheckState == CheckState.Checked;
                articulo.propiedad_22 = ((BaseCheckedListBoxControl)cbPropiedades).Items[21].CheckState == CheckState.Checked;
                articulo.propiedad_23 = ((BaseCheckedListBoxControl)cbPropiedades).Items[22].CheckState == CheckState.Checked;
                articulo.propiedad_24 = ((BaseCheckedListBoxControl)cbPropiedades).Items[23].CheckState == CheckState.Checked;
                articulo.propiedad_25 = ((BaseCheckedListBoxControl)cbPropiedades).Items[24].CheckState == CheckState.Checked;
                articulo.propiedad_26 = ((BaseCheckedListBoxControl)cbPropiedades).Items[25].CheckState == CheckState.Checked;
                articulo.propiedad_27 = ((BaseCheckedListBoxControl)cbPropiedades).Items[26].CheckState == CheckState.Checked;
                articulo.propiedad_28 = ((BaseCheckedListBoxControl)cbPropiedades).Items[27].CheckState == CheckState.Checked;
                articulo.propiedad_29 = ((BaseCheckedListBoxControl)cbPropiedades).Items[28].CheckState == CheckState.Checked;
                articulo.propiedad_30 = ((BaseCheckedListBoxControl)cbPropiedades).Items[29].CheckState == CheckState.Checked;
                articulo.propiedad_31 = ((BaseCheckedListBoxControl)cbPropiedades).Items[30].CheckState == CheckState.Checked;
                articulo.propiedad_32 = ((BaseCheckedListBoxControl)cbPropiedades).Items[31].CheckState == CheckState.Checked;
            }
            catch
            {
            }
        }

        private void LlenarPrecio()
        {
            try
            {
                precio.articulo_id = articulo.id;
                precio.lista_precio_id = (int)((BaseEdit)cbListasPrecios).EditValue;
                precio.moneda_id = (int)((BaseEdit)cbMonedas).EditValue;
                precio.precio = decimal.Parse(((BaseEdit)txtPrecio).EditValue.ToString());
                precio.multiplicador_puntos = decimal.Parse(((BaseEdit)txtMultiplicador).EditValue.ToString());
            }
            catch
            {
            }
        }

        private void LlenarRutas()
        {
            try
            {
                if (articulo.id == 0)
                {
                    return;
                }
                List<object> checkedValues = cbRutas.Properties.Items.GetCheckedValues();
                List<int> list = new List<int>();
                foreach (object item in checkedValues)
                {
                    Articulo.Ruta ruta = new Articulo.Ruta();
                    ruta.articulo_id = articulo.id;
                    ruta.ruta_id = (int)item;
                    list.Add(ruta.ruta_id);
                    ruta.Agregar();
                }
                Utilidades.EjecutarQuery(string.Format("delete from articulos_rutas where articulo_id = {0} and ruta_id not in ({1})", articulo.id, string.Join(",", list)));
            }
            catch
            {
            }
        }

        private void LlenarGrupos()
        {
            try
            {
                if (articulo.id == 0)
                {
                    return;
                }
                List<object> checkedValues = cbGrupos.Properties.Items.GetCheckedValues();
                List<int> list = new List<int>();
                foreach (object item in checkedValues)
                {
                    Articulo.Grupo grupo = new Articulo.Grupo();
                    grupo.articulo_id = articulo.id;
                    grupo.grupo_articulo_id = (int)item;
                    list.Add(grupo.grupo_articulo_id);
                    grupo.Agregar();
                }
                Utilidades.EjecutarQuery(string.Format("delete from articulos_grupos where articulo_id = {0} and grupo_articulo_id not in ({1})", articulo.id, string.Join(",", list)));
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
                    if (articulo.id != 0)
                    {
                        articulo.Actualizar();
                    }
                    else
                    {
                        articulo.Agregar();
                    }
                    LlenarPrecio();
                    if (precio.id != 0)
                    {
                        precio.Actualizar();
                    }
                    else
                    {
                        precio.Agregar();
                    }
                    LlenarRutas();
                    LlenarGrupos();
                    LlenarWeb();
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void CargarWeb()
        {
            Articulo.Web web = Articulo.Web.Obtener(articulo.id);
            txtDescripcionWeb.HtmlText = web.descripcion;
            txtInformacionAdicionalWeb.HtmlText = web.informacion_adicional;
            txtCaracteristicasWeb.HtmlText = web.caracteristicas;
            txtAplicacionesWeb.HtmlText = web.aplicaciones;
            ((Control)(object)txtPalabrasClave).Text = web.palabras_clave;
        }

        private void LlenarWeb()
        {
            try
            {
                Articulo.Web web = Articulo.Web.Obtener(articulo.id);
                web.articulo_id = articulo.id;
                web.descripcion = txtDescripcionWeb.HtmlText;
                web.informacion_adicional = txtInformacionAdicionalWeb.HtmlText;
                web.caracteristicas = txtCaracteristicasWeb.HtmlText;
                web.aplicaciones = txtAplicacionesWeb.HtmlText;
                web.palabras_clave = ((Control)(object)txtPalabrasClave).Text;
                if (web.id != 0)
                {
                    web.Actualizar();
                }
                else
                {
                    web.Agregar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar la información web del artículo");
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                articulo = (from x in Articulo.Articulos()
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
                articulo = (from x in Articulo.Articulos()
                            where x.id < articulo.id
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
                articulo = (from x in Articulo.Articulos()
                            where x.id > articulo.id
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
                articulo = (from x in Articulo.Articulos()
                            orderby x.id descending
                            select x).First();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Buscar();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            articulo = new Articulo();
            Cargar(nuevo: true);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = Program.Nori.Configuracion.directorio_imagenes + "\\" + openFileDialog.SafeFileName;
                File.Copy(openFileDialog.FileName, text, overwrite: true);
                pbImagen.Image = new Bitmap(text);
                articulo.imagen = openFileDialog.SafeFileName;
            }
        }

        private void lblGrupoArticulos_Click(object sender, EventArgs e)
        {
            frmGruposArticulos frmGruposArticulos2 = new frmGruposArticulos((!((BaseEdit)cbGruposArticulos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposArticulos).EditValue) : 0);
            ((Form)(object)frmGruposArticulos2).ShowDialog();
            CargarListas();
        }

        private void Buscar()
        {
            try
            {
                if (articulo.id != 0)
                {
                    articulo = new Articulo();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id AS ID, sku AS SKU, nombre AS Nombre, codigo_barras AS 'Codigo Barras', activo AS Activo",
                    like = true
                };
                object objeto = new
                {
                    sku = ((Control)(object)txtSKU).Text,
                    nombre = ((Control)(object)txtNombre).Text,
                    descripcion = ((Control)(object)txtDescripcion).Text,
                    codigo_barras = ((Control)(object)txtCodigoBarras).Text,
                    sku_fabricante = ((Control)(object)txtSKUFabricante).Text,
                    grupo_articulo_id = (((BaseEdit)cbGruposArticulos).EditValue.IsNullOrEmpty() ? null : ((BaseEdit)cbGruposArticulos).EditValue)
                };
                DataTable dataTable = Utilidades.Busqueda("articulos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        articulo = Articulo.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        articulo = Articulo.Obtener(frmResultadosBusqueda2.id);
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

        private void txtSKU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && articulo.id == 0)
            {
                Buscar();
            }
        }

        private void cbListasPrecios_EditValueChanged(object sender, EventArgs e)
        {
            CargarPrecio();
        }

        private void cbMonedas_EditValueChanged(object sender, EventArgs e)
        {
            ((Control)(object)txtPrecio).Text = TipoCambio.Convertir(precio.moneda_id, (int)((BaseEdit)cbMonedas).EditValue, 'V', precio.precio).ToString();
        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas frmMonedas2 = new frmMonedas((!((BaseEdit)cbMonedas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMonedas).EditValue) : 0);
            ((Form)(object)frmMonedas2).ShowDialog();
            CargarListas();
        }

        private void lblListaPrecios_Click(object sender, EventArgs e)
        {
            frmListasPrecios frmListasPrecios2 = new frmListasPrecios((!((BaseEdit)cbListasPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListasPrecios).EditValue) : 0);
            ((Form)(object)frmListasPrecios2).ShowDialog();
            CargarListas();
        }

        private void lblFabricantes_Click(object sender, EventArgs e)
        {
            frmFabricantes frmFabricantes2 = new frmFabricantes((!((BaseEdit)cbFabricantes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbFabricantes).EditValue) : 0);
            ((Form)(object)frmFabricantes2).ShowDialog();
            CargarListas();
        }

        private void cbAlmacenable_CheckedChanged(object sender, EventArgs e)
        {
            XtraTabPage obj = xtraTabPageDatosInventario;
            bool pageVisible = (xtraTabPageUbicaciones.PageVisible = ((articulo.id != 0 && cbAlmacenable.Checked) ? true : false));
            obj.PageVisible = pageVisible;
        }

        private void gcUbicaciones_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_005c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0063: Invalid comparison between Unknown and I4
            //IL_0143: Unknown result type (might be due to invalid IL or missing references)
            //IL_0149: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvUbicaciones).GetDataRow(((ColumnView)gvUbicaciones).GetSelectedRows()[0]);
                ((BaseView)gvUbicaciones).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Articulo.Ubicacion ubicacion = new Articulo.Ubicacion();
                if (result != 0)
                {
                    ubicacion = Articulo.Ubicacion.Obtener(result);
                }
                if ((int)e.Button.ButtonType == 10)
                {
                    int almacen_id = (int)dataRow["almacen_id"];
                    string text = (string)dataRow["ubicacion"];
                    bool flag = dataRow["activo"].IsNullOrEmpty() || (bool)dataRow["activo"];
                    ubicacion.articulo_id = articulo.id;
                    ubicacion.almacen_id = almacen_id;
                    ubicacion.ubicacion = text;
                    ubicacion.activo = flag;
                    if (ubicacion.id != 0)
                    {
                        if (!ubicacion.Actualizar())
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                        }
                    }
                    else if (!ubicacion.Agregar())
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && ubicacion.id != 0)
                {
                    ubicacion.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gcInventario_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_002d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0034: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvInventario).GetDataRow(((ColumnView)gvInventario).GetSelectedRows()[0]);
                ((BaseView)gvInventario).CloseEditor();
                if ((int)e.Button.ButtonType != 10)
                {
                    return;
                }
                int num = (int)dataRow["articulo_id"];
                int almacen_id = (int)dataRow["almacen_id"];
                Articulo.Inventario inventario = Articulo.Inventario.Obtener(num, almacen_id);
                if (inventario.id != 0)
                {
                    inventario.activo = (bool)dataRow["activo"];
                    inventario.stock_minimo = decimal.Parse(dataRow["stock_minimo"].ToString());
                    inventario.stock_maximo = decimal.Parse(dataRow["stock_maximo"].ToString());
                    inventario.punto_reorden = decimal.Parse(dataRow["punto_reorden"].ToString());
                    inventario.ubicacion = dataRow["ubicacion"].ToString();
                    if (!inventario.Actualizar())
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void lblCodigoBarras_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = Utilidades.EjecutarQuery($"select codigos_barras.id, codigos_barras.codigo, codigos_barras.nombre comentario, unidades_medida.nombre udm from codigos_barras left join unidades_medida on codigos_barras.unidad_medida_id = unidades_medida.id where articulo_id = {articulo.id}");
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    ((Control)(object)frmResultadosBusqueda2).Text = $"Códigos de barras del artículo {articulo.sku}";
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                }
            }
            catch
            {
            }
        }

        private void lblTiposEmpaques_Click(object sender, EventArgs e)
        {
            frmTiposEmpaques frmTiposEmpaques2 = new frmTiposEmpaques();
            ((Form)(object)frmTiposEmpaques2).ShowDialog();
        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios2 = new frmSocios((!((BaseEdit)cbProveedores).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbProveedores).EditValue) : 0);
            ((Form)(object)frmSocios2).ShowDialog();
        }

        private void btnAgregarAlInventario_Click(object sender, EventArgs e)
        {
            try
            {
                int num = ((!((BaseEdit)cbAlmacen).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbAlmacen).EditValue) : 0);
                if (num == 0 || articulo.id == 0)
                {
                    return;
                }
                Articulo.Inventario inventario = Articulo.Inventario.Obtener(articulo.id, num);
                if (inventario.id == 0)
                {
                    inventario.articulo_id = articulo.id;
                    inventario.almacen_id = num;
                    if (inventario.Agregar())
                    {
                        MessageBox.Show("Se agregó la información correctamente.");
                    }
                    else
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                    }
                }
                else
                {
                    MessageBox.Show("El inventario de este artículo ya incluye este almacén.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void lblTipoRuta_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas2 = new frmRutas();
            ((Form)(object)frmRutas2).ShowDialog();
            CargarListas();
        }

        private void lblUnidadMedidaCompra_Click(object sender, EventArgs e)
        {
            frmUnidadesMedida frmUnidadesMedida2 = new frmUnidadesMedida((!((BaseEdit)cbUnidadesMedidaCompra).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUnidadesMedidaCompra).EditValue) : 0);
            ((Form)(object)frmUnidadesMedida2).ShowDialog();
        }

        private void lblUnidadMedidaVenta_Click(object sender, EventArgs e)
        {
            frmUnidadesMedida frmUnidadesMedida2 = new frmUnidadesMedida((!((BaseEdit)cbUnidadesMedidaVenta).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUnidadesMedidaVenta).EditValue) : 0);
            ((Form)(object)frmUnidadesMedida2).ShowDialog();
        }

        private void barButtonItemDescuentos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDescuentos frmDescuentos2 = new frmDescuentos();
            ((Control)(object)frmDescuentos2).Show();
        }

        private void btnAnexarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destFileName = Program.Nori.Configuracion.directorio_imagenes + "\\" + openFileDialog.SafeFileName;
                Articulo.Imagen imagen = new Articulo.Imagen();
                imagen.archivo = openFileDialog.SafeFileName;
                File.Copy(openFileDialog.FileName, destFileName, overwrite: true);
                if (articulo.id != 0)
                {
                    imagen.articulo_id = articulo.id;
                    imagen.Agregar();
                }
                CargarImagenes();
            }
        }

        private void CargarImagenes()
        {
            try
            {
                ((CollectionBase)(object)lbImagenes.Items).Clear();
                List<Articulo.Imagen> list = (from x in Articulo.Imagen.Imagenes()
                                              where x.articulo_id == articulo.id
                                              select x).ToList();
                foreach (Articulo.Imagen item in list)
                {
                    lbImagenes.Items.Add((object)$"{item.archivo}");
                }
            }
            catch
            {
            }
        }

        private void btnVisualizarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = Program.Nori.Configuracion.directorio_imagenes + "\\" + ((BaseListBoxControl)lbImagenes).SelectedValue.ToString();
                Funciones.AbrirArchivo(archivo);
            }
            catch
            {
            }
        }

        private void bbiParametrizacionesFormulario_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFormArt frmFormArt = new frmFormArt();
            //frmParametrizacionesFormulario frmParametrizacionesFormulario2 = new frmParametrizacionesFormulario(((Control)this).Name, "AR");
            ((Form)(object)frmFormArt).ShowDialog();
            Permisos();
        }

        private void bbiPartidasAbiertas_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscarDocumentos();
        }

        private void BuscarDocumentos()
        {
            DataTable dataTable = Utilidades.EjecutarQuery($"select documentos.id, clase, numero_documento, numero_documento_externo, fecha_documento, documentos.total from partidas join documentos on documentos.id = partidas.documento_id where documentos.estado = 'A' and clase in ('PE', 'OC') and cantidad_pendiente > 0 and articulo_id = {articulo.id} order by documentos.id desc");
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows.Count == 1)
                {
                    frmDocumentos frmDocumentos2 = new frmDocumentos(dataTable.Rows[0]["clase"].ToString(), int.Parse(dataTable.Rows[0]["id"].ToString()));
                    ((Control)(object)frmDocumentos2).Show();
                    return;
                }
                frmResultadosBusqueda f = new frmResultadosBusqueda(dataTable);
                DialogResult dialogResult = ((Form)(object)f).ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var anon = (from x in Documento.Documentos()
                                where x.id == f.id
                                select new { x.clase, x.id }).First();
                    frmDocumentos frmDocumentos3 = new frmDocumentos(anon.clase, anon.id);
                    ((Control)(object)frmDocumentos3).Show();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", ((Control)(object)this).Text);
            }
        }

        private void bbiPaquetes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPaquetes frmPaquetes2 = new frmPaquetes();
            ((Control)(object)frmPaquetes2).Show();
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0055: Invalid comparison between Unknown and I4
            //IL_00f5: Unknown result type (might be due to invalid IL or missing references)
            //IL_00fb: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvArticulosSociosCFDI).GetDataRow(((ColumnView)gvArticulosSociosCFDI).GetSelectedRows()[0]);
                ((BaseView)gvArticulosSociosCFDI).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                ArticuloSocioCFDI articuloSocioCFDI = ArticuloSocioCFDI.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    articuloSocioCFDI.articulo_id = articulo.id;
                    articuloSocioCFDI.socio_id = (int)dataRow["socio_id"];
                    articuloSocioCFDI.impuesto_id = (int)dataRow["impuesto_id"];
                    articuloSocioCFDI.codigo_clasificacion = dataRow["codigo_clasificacion"].ToString();
                    articuloSocioCFDI.clave_unidad = dataRow["clave_unidad"].ToString();
                    if (articuloSocioCFDI.id != 0)
                    {
                        articuloSocioCFDI.Actualizar();
                    }
                    else
                    {
                        articuloSocioCFDI.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && articuloSocioCFDI.id != 0)
                {
                    articuloSocioCFDI.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pbImagen_DoubleClick(object sender, EventArgs e)
        {
            frmResaltarImagen formZoom = new frmResaltarImagen(pbImagen.Image);

            // Mostrar el formulario de zoom
            formZoom.Show();
        }
    }

}
