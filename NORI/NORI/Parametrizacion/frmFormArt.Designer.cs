using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace NORI
{
    partial class frmFormArt
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormArt));
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.cbRoles = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAnexos = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.lbReferencias = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.btnVisualizarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnexarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.lbImagenes = new DevExpress.XtraEditors.ListBoxControl();
            this.cbWeb = new DevExpress.XtraEditors.CheckEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDescuentos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiParametrizacionesFormulario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPartidasAbiertas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPaquetes = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cbExcluirSincronizacion = new DevExpress.XtraEditors.CheckEdit();
            this.cbUnidadesMedidaInventario = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUnidadMedida = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreAPI = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreAPI = new DevExpress.XtraEditors.TextEdit();
            this.cbAPI = new DevExpress.XtraEditors.CheckEdit();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarAlInventario = new DevExpress.XtraEditors.SimpleButton();
            this.cbIEPS = new DevExpress.XtraEditors.CheckEdit();
            this.cbSujetoImpuesto = new DevExpress.XtraEditors.CheckEdit();
            this.cbSujetoRetencion = new DevExpress.XtraEditors.CheckEdit();
            this.cbAlmacen = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAlmacen = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblIDAdicional = new DevExpress.XtraEditors.LabelControl();
            this.txtIDAdicional = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoBarras = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblMultiplicador = new DevExpress.XtraEditors.LabelControl();
            this.txtMultiplicador = new DevExpress.XtraEditors.TextEdit();
            this.lblFabricantes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbFabricantes = new DevExpress.XtraEditors.LookUpEdit();
            this.cbMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbListasPrecios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblListaPrecios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbGruposArticulos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblGrupoArticulos = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.btnImagen = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecio = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoBarras = new DevExpress.XtraEditors.TextEdit();
            this.gbSeguimento = new System.Windows.Forms.GroupBox();
            this.rbLotes = new System.Windows.Forms.RadioButton();
            this.lblDiasGarantia = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasGarantia = new DevExpress.XtraEditors.TextEdit();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.cbCanjeable = new DevExpress.XtraEditors.CheckEdit();
            this.cbCompra = new DevExpress.XtraEditors.CheckEdit();
            this.cbVenta = new DevExpress.XtraEditors.CheckEdit();
            this.cbAlmacenable = new DevExpress.XtraEditors.CheckEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblSKU = new DevExpress.XtraEditors.LabelControl();
            this.txtSKU = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageDatosCompras = new DevExpress.XtraTab.XtraTabPage();
            this.lblUnidadMedidaCompra = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblCantidadCompra = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadCompra = new DevExpress.XtraEditors.TextEdit();
            this.lblPedidoMinimo = new DevExpress.XtraEditors.LabelControl();
            this.txtPedidoMinimo = new DevExpress.XtraEditors.TextEdit();
            this.cbProveedores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblProveedor = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbImpuestosCompras = new DevExpress.XtraEditors.LookUpEdit();
            this.lblImpuestoCompra = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblSkuFabricante = new DevExpress.XtraEditors.LabelControl();
            this.txtSKUFabricante = new DevExpress.XtraEditors.TextEdit();
            this.cbUnidadesMedidaCompra = new DevExpress.XtraEditors.LookUpEdit();
            this.xtraTabPageDatosVentas = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcArticulosSociosCFDI = new DevExpress.XtraGrid.GridControl();
            this.gvArticulosSociosCFDI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbSocios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbImpuestos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnClaveUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbSocios2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbEntregaAutomatica = new DevExpress.XtraEditors.CheckEdit();
            this.lblGrupos = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupos = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lblCantidadVenta = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadVenta = new DevExpress.XtraEditors.TextEdit();
            this.cbRutas = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lblRuta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbUnidadesMedidaVenta = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAjusteMaximo = new DevExpress.XtraEditors.TextEdit();
            this.lblRangoAjuste = new DevExpress.XtraEditors.LabelControl();
            this.txtAjusteMinimo = new DevExpress.XtraEditors.TextEdit();
            this.lblCantidadPaquete = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadPaquete = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoClasificacion = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoClasificacion = new DevExpress.XtraEditors.TextEdit();
            this.cbImpuestosVentas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblImpuestoVenta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbTiposEmpaques = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTiposEmpaques = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbPesable = new DevExpress.XtraEditors.CheckEdit();
            this.lblClaveUnidad = new DevExpress.XtraEditors.LabelControl();
            this.txtClaveUnidad = new DevExpress.XtraEditors.TextEdit();
            this.lblPeso = new DevExpress.XtraEditors.LabelControl();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.lblUnidadMedidaVenta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.xtraTabPageDatosInventario = new DevExpress.XtraTab.XtraTabPage();
            this.gcInventario = new DevExpress.XtraGrid.GridControl();
            this.gvInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.articulo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comprometido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock_maximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.punto_reorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPagePropiedades = new DevExpress.XtraTab.XtraTabPage();
            this.cbPropiedades = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.xtraTabPageUbicaciones = new DevExpress.XtraTab.XtraTabPage();
            this.gcUbicaciones = new DevExpress.XtraGrid.GridControl();
            this.gvUbicaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAlmacenes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageWeb = new DevExpress.XtraTab.XtraTabPage();
            this.txtDescripcionWeb = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtPalabrasClave = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAplicacionesWeb = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaracteristicasWeb = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInformacionAdicionalWeb = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dtgrvArticulosAlternativos = new System.Windows.Forms.DataGridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcluirSincronizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaInventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreAPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIEPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSujetoImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSujetoRetencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDAdicional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplicador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).BeginInit();
            this.gbSeguimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasGarantia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCanjeable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKU.Properties)).BeginInit();
            this.xtraTabPageDatosCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedidoMinimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestosCompras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKUFabricante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaCompra.Properties)).BeginInit();
            this.xtraTabPageDatosVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticulosSociosCFDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulosSociosCFDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEntregaAutomatica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAjusteMaximo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAjusteMinimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPaquete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoClasificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestosVentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPesable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            this.xtraTabPageDatosInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).BeginInit();
            this.xtraTabPagePropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).BeginInit();
            this.xtraTabPageUbicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).BeginInit();
            this.xtraTabPageWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalabrasClave.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvArticulosAlternativos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1469, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 820);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1469, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 820);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1469, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 820);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.Gray;
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonControl1.EmptyAreaImageOptions.Image")));
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.None;
            this.ribbonControl1.OptionsSearchMenu.UseCustomRibbonSearch = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office365;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1469, 57);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // cbRoles
            // 
            this.cbRoles.Location = new System.Drawing.Point(1073, 103);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRoles.Properties.NullText = "";
            this.cbRoles.Size = new System.Drawing.Size(342, 24);
            this.cbRoles.TabIndex = 74;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(1033, 110);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 17);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Rol";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1275, 159);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 43);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Location = new System.Drawing.Point(999, 216);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(458, 592);
            this.panelControl2.TabIndex = 84;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(453, 582);
            this.dataGridView1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1118, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 43);
            this.simpleButton1.TabIndex = 90;
            this.simpleButton1.Text = "Buscar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(59, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 98;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Controls.Add(this.backstageViewControl1);
            this.panelControl1.Controls.Add(this.mainRibbonControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 760);
            this.panelControl1.TabIndex = 12;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.xtraTabControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 62);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(967, 696);
            this.dataLayoutControl1.TabIndex = 4;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(943, 672);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageDatosCompras,
            this.xtraTabPageDatosVentas,
            this.xtraTabPageDatosInventario,
            this.xtraTabPagePropiedades,
            this.xtraTabPageUbicaciones,
            this.xtraTabPageWeb,
            this.xtraTabPage1});
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.btnVisualizarImagen);
            this.xtraTabPageGeneral.Controls.Add(this.btnAnexarImagen);
            this.xtraTabPageGeneral.Controls.Add(this.lbImagenes);
            this.xtraTabPageGeneral.Controls.Add(this.cbWeb);
            this.xtraTabPageGeneral.Controls.Add(this.cbExcluirSincronizacion);
            this.xtraTabPageGeneral.Controls.Add(this.cbUnidadesMedidaInventario);
            this.xtraTabPageGeneral.Controls.Add(this.lblUnidadMedida);
            this.xtraTabPageGeneral.Controls.Add(this.lblNombreAPI);
            this.xtraTabPageGeneral.Controls.Add(this.txtNombreAPI);
            this.xtraTabPageGeneral.Controls.Add(this.cbAPI);
            this.xtraTabPageGeneral.Controls.Add(this.txtComentario);
            this.xtraTabPageGeneral.Controls.Add(this.lblComentario);
            this.xtraTabPageGeneral.Controls.Add(this.btnAgregarAlInventario);
            this.xtraTabPageGeneral.Controls.Add(this.cbIEPS);
            this.xtraTabPageGeneral.Controls.Add(this.cbSujetoImpuesto);
            this.xtraTabPageGeneral.Controls.Add(this.cbSujetoRetencion);
            this.xtraTabPageGeneral.Controls.Add(this.cbAlmacen);
            this.xtraTabPageGeneral.Controls.Add(this.lblAlmacen);
            this.xtraTabPageGeneral.Controls.Add(this.lblIDAdicional);
            this.xtraTabPageGeneral.Controls.Add(this.txtIDAdicional);
            this.xtraTabPageGeneral.Controls.Add(this.lblCodigoBarras);
            this.xtraTabPageGeneral.Controls.Add(this.lblMultiplicador);
            this.xtraTabPageGeneral.Controls.Add(this.txtMultiplicador);
            this.xtraTabPageGeneral.Controls.Add(this.lblFabricantes);
            this.xtraTabPageGeneral.Controls.Add(this.cbFabricantes);
            this.xtraTabPageGeneral.Controls.Add(this.cbMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.lblMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.cbListasPrecios);
            this.xtraTabPageGeneral.Controls.Add(this.lblListaPrecios);
            this.xtraTabPageGeneral.Controls.Add(this.cbGruposArticulos);
            this.xtraTabPageGeneral.Controls.Add(this.lblGrupoArticulos);
            this.xtraTabPageGeneral.Controls.Add(this.cbActivo);
            this.xtraTabPageGeneral.Controls.Add(this.btnImagen);
            this.xtraTabPageGeneral.Controls.Add(this.lblID);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaActualizacion);
            this.xtraTabPageGeneral.Controls.Add(this.lblUltimaActualizacion);
            this.xtraTabPageGeneral.Controls.Add(this.pbImagen);
            this.xtraTabPageGeneral.Controls.Add(this.lblStock);
            this.xtraTabPageGeneral.Controls.Add(this.txtStock);
            this.xtraTabPageGeneral.Controls.Add(this.lblPrecio);
            this.xtraTabPageGeneral.Controls.Add(this.txtPrecio);
            this.xtraTabPageGeneral.Controls.Add(this.txtCodigoBarras);
            this.xtraTabPageGeneral.Controls.Add(this.gbSeguimento);
            this.xtraTabPageGeneral.Controls.Add(this.cbCanjeable);
            this.xtraTabPageGeneral.Controls.Add(this.cbCompra);
            this.xtraTabPageGeneral.Controls.Add(this.cbVenta);
            this.xtraTabPageGeneral.Controls.Add(this.cbAlmacenable);
            this.xtraTabPageGeneral.Controls.Add(this.lblDescripcion);
            this.xtraTabPageGeneral.Controls.Add(this.txtDescripcion);
            this.xtraTabPageGeneral.Controls.Add(this.lblNombre);
            this.xtraTabPageGeneral.Controls.Add(this.txtNombre);
            this.xtraTabPageGeneral.Controls.Add(this.lblSKU);
            this.xtraTabPageGeneral.Controls.Add(this.txtSKU);
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // btnVisualizarImagen
            // 
            this.btnVisualizarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarImagen.Location = new System.Drawing.Point(654, 537);
            this.btnVisualizarImagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnVisualizarImagen.Name = "btnVisualizarImagen";
            this.btnVisualizarImagen.Size = new System.Drawing.Size(95, 31);
            this.btnVisualizarImagen.TabIndex = 144;
            this.btnVisualizarImagen.TabStop = false;
            this.btnVisualizarImagen.Text = "Visualizar";
            // 
            // btnAnexarImagen
            // 
            this.btnAnexarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnexarImagen.Location = new System.Drawing.Point(757, 537);
            this.btnAnexarImagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnexarImagen.Name = "btnAnexarImagen";
            this.btnAnexarImagen.Size = new System.Drawing.Size(155, 31);
            this.btnAnexarImagen.TabIndex = 143;
            this.btnAnexarImagen.TabStop = false;
            this.btnAnexarImagen.Text = "Adjuntar imagen";
            // 
            // lbImagenes
            // 
            this.lbImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImagenes.Location = new System.Drawing.Point(654, 456);
            this.lbImagenes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbImagenes.Name = "lbImagenes";
            this.lbImagenes.Size = new System.Drawing.Size(257, 76);
            this.lbImagenes.TabIndex = 142;
            // 
            // cbWeb
            // 
            this.cbWeb.Location = new System.Drawing.Point(479, 571);
            this.cbWeb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbWeb.MenuManager = this.mainRibbonControl;
            this.cbWeb.Name = "cbWeb";
            this.cbWeb.Properties.Caption = "Web";
            this.cbWeb.Size = new System.Drawing.Size(160, 21);
            this.cbWeb.TabIndex = 141;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.barButtonItemDescuentos,
            this.bbiParametrizacionesFormulario,
            this.bbiPartidasAbiertas,
            this.bbiPaquetes});
            this.mainRibbonControl.Location = new System.Drawing.Point(2, 2);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mainRibbonControl.MaxItemId = 60;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 440;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(967, 60);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(55, 162);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.mainRibbonControl;
            this.backstageViewControl1.Size = new System.Drawing.Size(640, 196);
            this.backstageViewControl1.TabIndex = 5;
            this.backstageViewControl1.VisibleInDesignTime = true;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            // 
            // bbiGuardarCerrar
            // 
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            // 
            // bbiGuardarNuevo
            // 
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            // 
            // bbiBuscar
            // 
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageOptions.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiPrimero
            // 
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageOptions.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiAnterior
            // 
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageOptions.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiSiguiente
            // 
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            // 
            // barButtonItemDescuentos
            // 
            this.barButtonItemDescuentos.Caption = "Descuentos";
            this.barButtonItemDescuentos.Id = 1;
            this.barButtonItemDescuentos.Name = "barButtonItemDescuentos";
            // 
            // bbiParametrizacionesFormulario
            // 
            this.bbiParametrizacionesFormulario.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizacionesFormulario.Id = 57;
            this.bbiParametrizacionesFormulario.Name = "bbiParametrizacionesFormulario";
            // 
            // bbiPartidasAbiertas
            // 
            this.bbiPartidasAbiertas.Caption = "Partidas abiertas";
            this.bbiPartidasAbiertas.Id = 58;
            this.bbiPartidasAbiertas.Name = "bbiPartidasAbiertas";
            // 
            // bbiPaquetes
            // 
            this.bbiPaquetes.Caption = "Paquetes";
            this.bbiPaquetes.Id = 59;
            this.bbiPaquetes.Name = "bbiPaquetes";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.searchRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarNuevo);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Opciones";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.AllowTextClipping = false;
            this.searchRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiBuscar);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiPrimero);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiAnterior);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiSiguiente);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiUltimo);
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Navegación";
            // 
            // ribbonPageHerramientas
            // 
            this.ribbonPageHerramientas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageHerramientas.Name = "ribbonPageHerramientas";
            this.ribbonPageHerramientas.Text = "HERRAMIENTAS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDescuentos);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiParametrizacionesFormulario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiPaquetes);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // cbExcluirSincronizacion
            // 
            this.cbExcluirSincronizacion.Location = new System.Drawing.Point(280, 571);
            this.cbExcluirSincronizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbExcluirSincronizacion.MenuManager = this.mainRibbonControl;
            this.cbExcluirSincronizacion.Name = "cbExcluirSincronizacion";
            this.cbExcluirSincronizacion.Properties.Caption = "Excluir sincronización";
            this.cbExcluirSincronizacion.Size = new System.Drawing.Size(169, 21);
            this.cbExcluirSincronizacion.TabIndex = 67;
            this.cbExcluirSincronizacion.TabStop = false;
            // 
            // cbUnidadesMedidaInventario
            // 
            this.cbUnidadesMedidaInventario.Location = new System.Drawing.Point(547, 290);
            this.cbUnidadesMedidaInventario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbUnidadesMedidaInventario.MenuManager = this.mainRibbonControl;
            this.cbUnidadesMedidaInventario.Name = "cbUnidadesMedidaInventario";
            this.cbUnidadesMedidaInventario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedidaInventario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedidaInventario.Size = new System.Drawing.Size(187, 24);
            this.cbUnidadesMedidaInventario.TabIndex = 139;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Location = new System.Drawing.Point(462, 295);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(30, 17);
            this.lblUnidadMedida.TabIndex = 140;
            this.lblUnidadMedida.Text = "UdM";
            // 
            // lblNombreAPI
            // 
            this.lblNombreAPI.Location = new System.Drawing.Point(21, 125);
            this.lblNombreAPI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblNombreAPI.Name = "lblNombreAPI";
            this.lblNombreAPI.Size = new System.Drawing.Size(78, 17);
            this.lblNombreAPI.TabIndex = 68;
            this.lblNombreAPI.Text = "Nombre API";
            // 
            // txtNombreAPI
            // 
            this.txtNombreAPI.Location = new System.Drawing.Point(155, 120);
            this.txtNombreAPI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombreAPI.MenuManager = this.mainRibbonControl;
            this.txtNombreAPI.Name = "txtNombreAPI";
            this.txtNombreAPI.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreAPI.Properties.MaxLength = 254;
            this.txtNombreAPI.Properties.NullValuePrompt = "Nombre del artículo";
            this.txtNombreAPI.Size = new System.Drawing.Size(294, 24);
            this.txtNombreAPI.TabIndex = 67;
            // 
            // cbAPI
            // 
            this.cbAPI.Location = new System.Drawing.Point(158, 571);
            this.cbAPI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAPI.MenuManager = this.mainRibbonControl;
            this.cbAPI.Name = "cbAPI";
            this.cbAPI.Properties.Caption = "API";
            this.cbAPI.Size = new System.Drawing.Size(117, 21);
            this.cbAPI.TabIndex = 66;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(158, 399);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(291, 161);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(22, 400);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(74, 17);
            this.lblComentario.TabIndex = 65;
            this.lblComentario.Text = "Comentario";
            // 
            // btnAgregarAlInventario
            // 
            this.btnAgregarAlInventario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarAlInventario.Location = new System.Drawing.Point(691, 256);
            this.btnAgregarAlInventario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarAlInventario.Name = "btnAgregarAlInventario";
            this.btnAgregarAlInventario.Size = new System.Drawing.Size(43, 31);
            this.btnAgregarAlInventario.TabIndex = 64;
            // 
            // cbIEPS
            // 
            this.cbIEPS.Location = new System.Drawing.Point(326, 298);
            this.cbIEPS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbIEPS.MenuManager = this.mainRibbonControl;
            this.cbIEPS.Name = "cbIEPS";
            this.cbIEPS.Properties.Caption = "IEPS";
            this.cbIEPS.Size = new System.Drawing.Size(123, 21);
            this.cbIEPS.TabIndex = 8;
            // 
            // cbSujetoImpuesto
            // 
            this.cbSujetoImpuesto.Location = new System.Drawing.Point(158, 298);
            this.cbSujetoImpuesto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSujetoImpuesto.MenuManager = this.mainRibbonControl;
            this.cbSujetoImpuesto.Name = "cbSujetoImpuesto";
            this.cbSujetoImpuesto.Properties.Caption = "Sujeto a impuesto";
            this.cbSujetoImpuesto.Size = new System.Drawing.Size(160, 21);
            this.cbSujetoImpuesto.TabIndex = 7;
            // 
            // cbSujetoRetencion
            // 
            this.cbSujetoRetencion.Location = new System.Drawing.Point(158, 261);
            this.cbSujetoRetencion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSujetoRetencion.MenuManager = this.mainRibbonControl;
            this.cbSujetoRetencion.Name = "cbSujetoRetencion";
            this.cbSujetoRetencion.Properties.Caption = "Sujeto a retención";
            this.cbSujetoRetencion.Size = new System.Drawing.Size(160, 21);
            this.cbSujetoRetencion.TabIndex = 6;
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.Location = new System.Drawing.Point(547, 256);
            this.cbAlmacen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAlmacen.MenuManager = this.mainRibbonControl;
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacen.Size = new System.Drawing.Size(131, 24);
            this.cbAlmacen.TabIndex = 11;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlmacen.Location = new System.Drawing.Point(462, 261);
            this.lblAlmacen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(55, 17);
            this.lblAlmacen.TabIndex = 63;
            this.lblAlmacen.Text = "Almacén";
            // 
            // lblIDAdicional
            // 
            this.lblIDAdicional.Location = new System.Drawing.Point(22, 368);
            this.lblIDAdicional.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblIDAdicional.Name = "lblIDAdicional";
            this.lblIDAdicional.Size = new System.Drawing.Size(74, 17);
            this.lblIDAdicional.TabIndex = 56;
            this.lblIDAdicional.Text = "ID Adicional";
            // 
            // txtIDAdicional
            // 
            this.txtIDAdicional.Location = new System.Drawing.Point(158, 365);
            this.txtIDAdicional.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIDAdicional.MenuManager = this.mainRibbonControl;
            this.txtIDAdicional.Name = "txtIDAdicional";
            this.txtIDAdicional.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtIDAdicional.Properties.MaxLength = 16;
            this.txtIDAdicional.Properties.NullValuePrompt = "Identificador adicional";
            this.txtIDAdicional.Size = new System.Drawing.Size(291, 24);
            this.txtIDAdicional.TabIndex = 10;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoBarras.Location = new System.Drawing.Point(22, 160);
            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(105, 17);
            this.lblCodigoBarras.TabIndex = 54;
            this.lblCodigoBarras.Text = "Código de barras";
            // 
            // lblMultiplicador
            // 
            this.lblMultiplicador.Location = new System.Drawing.Point(462, 193);
            this.lblMultiplicador.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMultiplicador.Name = "lblMultiplicador";
            this.lblMultiplicador.Size = new System.Drawing.Size(78, 17);
            this.lblMultiplicador.TabIndex = 53;
            this.lblMultiplicador.Text = "Monedero %";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(547, 188);
            this.txtMultiplicador.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMultiplicador.MenuManager = this.mainRibbonControl;
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMultiplicador.Properties.MaskSettings.Set("mask", "n");
            this.txtMultiplicador.Size = new System.Drawing.Size(187, 24);
            this.txtMultiplicador.TabIndex = 0;
            this.txtMultiplicador.TabStop = false;
            // 
            // lblFabricantes
            // 
            this.lblFabricantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFabricantes.Location = new System.Drawing.Point(22, 334);
            this.lblFabricantes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFabricantes.Name = "lblFabricantes";
            this.lblFabricantes.Size = new System.Drawing.Size(66, 17);
            this.lblFabricantes.TabIndex = 49;
            this.lblFabricantes.Text = "Fabricante";
            // 
            // cbFabricantes
            // 
            this.cbFabricantes.Location = new System.Drawing.Point(158, 331);
            this.cbFabricantes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbFabricantes.MenuManager = this.mainRibbonControl;
            this.cbFabricantes.Name = "cbFabricantes";
            this.cbFabricantes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFabricantes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbFabricantes.Size = new System.Drawing.Size(291, 24);
            this.cbFabricantes.TabIndex = 9;
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(547, 120);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(187, 24);
            this.cbMonedas.TabIndex = 0;
            this.cbMonedas.TabStop = false;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(462, 125);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 48;
            this.lblMonedas.Text = "Moneda";
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.Location = new System.Drawing.Point(158, 223);
            this.cbListasPrecios.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbListasPrecios.MenuManager = this.mainRibbonControl;
            this.cbListasPrecios.Name = "cbListasPrecios";
            this.cbListasPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Size = new System.Drawing.Size(291, 24);
            this.cbListasPrecios.TabIndex = 5;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaPrecios.Location = new System.Drawing.Point(22, 228);
            this.lblListaPrecios.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(92, 17);
            this.lblListaPrecios.TabIndex = 46;
            this.lblListaPrecios.Text = "Lista de precios";
            // 
            // cbGruposArticulos
            // 
            this.cbGruposArticulos.Location = new System.Drawing.Point(158, 189);
            this.cbGruposArticulos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbGruposArticulos.MenuManager = this.mainRibbonControl;
            this.cbGruposArticulos.Name = "cbGruposArticulos";
            this.cbGruposArticulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGruposArticulos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbGruposArticulos.Size = new System.Drawing.Size(291, 24);
            this.cbGruposArticulos.TabIndex = 4;
            // 
            // lblGrupoArticulos
            // 
            this.lblGrupoArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGrupoArticulos.Location = new System.Drawing.Point(22, 194);
            this.lblGrupoArticulos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblGrupoArticulos.Name = "lblGrupoArticulos";
            this.lblGrupoArticulos.Size = new System.Drawing.Size(112, 17);
            this.lblGrupoArticulos.TabIndex = 45;
            this.lblGrupoArticulos.Text = "Grupo de artículos";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(22, 568);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(117, 21);
            this.cbActivo.TabIndex = 18;
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.Location = new System.Drawing.Point(744, 257);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(167, 35);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "Seleccionar imagen";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(462, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "0";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacion.Location = new System.Drawing.Point(837, 576);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 41;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(654, 576);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 40;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(744, 14);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(167, 236);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 39;
            this.pbImagen.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(462, 227);
            this.lblStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 17);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Existencia";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(547, 222);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtStock.MenuManager = this.mainRibbonControl;
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtStock.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtStock.Properties.MaskSettings.Set("mask", "n4");
            this.txtStock.Size = new System.Drawing.Size(187, 24);
            this.txtStock.TabIndex = 0;
            this.txtStock.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(462, 159);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 17);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(547, 154);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPrecio.MenuManager = this.mainRibbonControl;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecio.Properties.MaskSettings.Set("mask", "c2");
            this.txtPrecio.Size = new System.Drawing.Size(187, 24);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.TabStop = false;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(158, 155);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoBarras.MenuManager = this.mainRibbonControl;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Properties.MaxLength = 254;
            this.txtCodigoBarras.Properties.NullValuePrompt = "Código de barras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(291, 24);
            this.txtCodigoBarras.TabIndex = 3;
            // 
            // gbSeguimento
            // 
            this.gbSeguimento.Controls.Add(this.rbLotes);
            this.gbSeguimento.Controls.Add(this.lblDiasGarantia);
            this.gbSeguimento.Controls.Add(this.txtDiasGarantia);
            this.gbSeguimento.Controls.Add(this.rbSeries);
            this.gbSeguimento.Controls.Add(this.rbNormal);
            this.gbSeguimento.Location = new System.Drawing.Point(462, 322);
            this.gbSeguimento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbSeguimento.Name = "gbSeguimento";
            this.gbSeguimento.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbSeguimento.Size = new System.Drawing.Size(182, 156);
            this.gbSeguimento.TabIndex = 12;
            this.gbSeguimento.TabStop = false;
            this.gbSeguimento.Text = "Seguimento de las unidades";
            // 
            // rbLotes
            // 
            this.rbLotes.AutoSize = true;
            this.rbLotes.Location = new System.Drawing.Point(17, 54);
            this.rbLotes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbLotes.Name = "rbLotes";
            this.rbLotes.Size = new System.Drawing.Size(58, 21);
            this.rbLotes.TabIndex = 30;
            this.rbLotes.Text = "Lotes";
            this.rbLotes.UseVisualStyleBackColor = true;
            // 
            // lblDiasGarantia
            // 
            this.lblDiasGarantia.Location = new System.Drawing.Point(17, 119);
            this.lblDiasGarantia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDiasGarantia.Name = "lblDiasGarantia";
            this.lblDiasGarantia.Size = new System.Drawing.Size(101, 17);
            this.lblDiasGarantia.TabIndex = 29;
            this.lblDiasGarantia.Text = "Días de garantía";
            // 
            // txtDiasGarantia
            // 
            this.txtDiasGarantia.Location = new System.Drawing.Point(143, 116);
            this.txtDiasGarantia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDiasGarantia.MenuManager = this.mainRibbonControl;
            this.txtDiasGarantia.Name = "txtDiasGarantia";
            this.txtDiasGarantia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDiasGarantia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasGarantia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasGarantia.Properties.MaskSettings.Set("mask", "n0");
            this.txtDiasGarantia.Properties.MaxLength = 5;
            this.txtDiasGarantia.Size = new System.Drawing.Size(29, 24);
            this.txtDiasGarantia.TabIndex = 0;
            this.txtDiasGarantia.TabStop = false;
            // 
            // rbSeries
            // 
            this.rbSeries.AutoSize = true;
            this.rbSeries.Location = new System.Drawing.Point(17, 85);
            this.rbSeries.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(131, 21);
            this.rbSeries.TabIndex = 0;
            this.rbSeries.Text = "Números de serie";
            this.rbSeries.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(17, 25);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(74, 21);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // cbCanjeable
            // 
            this.cbCanjeable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCanjeable.Location = new System.Drawing.Point(654, 422);
            this.cbCanjeable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCanjeable.MenuManager = this.mainRibbonControl;
            this.cbCanjeable.Name = "cbCanjeable";
            this.cbCanjeable.Properties.Caption = "Canjeable";
            this.cbCanjeable.Size = new System.Drawing.Size(160, 21);
            this.cbCanjeable.TabIndex = 18;
            // 
            // cbCompra
            // 
            this.cbCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompra.Location = new System.Drawing.Point(654, 385);
            this.cbCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCompra.MenuManager = this.mainRibbonControl;
            this.cbCompra.Name = "cbCompra";
            this.cbCompra.Properties.Caption = "Artículo de compra";
            this.cbCompra.Size = new System.Drawing.Size(160, 21);
            this.cbCompra.TabIndex = 15;
            // 
            // cbVenta
            // 
            this.cbVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVenta.Location = new System.Drawing.Point(654, 351);
            this.cbVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbVenta.MenuManager = this.mainRibbonControl;
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Properties.Caption = "Artículo de venta";
            this.cbVenta.Size = new System.Drawing.Size(160, 21);
            this.cbVenta.TabIndex = 14;
            // 
            // cbAlmacenable
            // 
            this.cbAlmacenable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenable.Location = new System.Drawing.Point(654, 317);
            this.cbAlmacenable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAlmacenable.MenuManager = this.mainRibbonControl;
            this.cbAlmacenable.Name = "cbAlmacenable";
            this.cbAlmacenable.Properties.Caption = "Artículo almacenable";
            this.cbAlmacenable.Size = new System.Drawing.Size(160, 21);
            this.cbAlmacenable.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(22, 91);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(68, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 86);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDescripcion.MenuManager = this.mainRibbonControl;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDescripcion.Properties.MaxLength = 254;
            this.txtDescripcion.Properties.NullValuePrompt = "Descripción del artículo";
            this.txtDescripcion.Size = new System.Drawing.Size(576, 24);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(22, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 254;
            this.txtNombre.Properties.NullValuePrompt = "Nombre del artículo";
            this.txtNombre.Size = new System.Drawing.Size(576, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblSKU
            // 
            this.lblSKU.Location = new System.Drawing.Point(22, 23);
            this.lblSKU.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(26, 17);
            this.lblSKU.TabIndex = 1;
            this.lblSKU.Text = "SKU";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(158, 18);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSKU.MenuManager = this.mainRibbonControl;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSKU.Properties.MaxLength = 20;
            this.txtSKU.Properties.NullValuePrompt = "Identificador del artículo";
            this.txtSKU.Size = new System.Drawing.Size(291, 24);
            this.txtSKU.TabIndex = 0;
            // 
            // xtraTabPageDatosCompras
            // 
            this.xtraTabPageDatosCompras.Controls.Add(this.lblUnidadMedidaCompra);
            this.xtraTabPageDatosCompras.Controls.Add(this.lblCantidadCompra);
            this.xtraTabPageDatosCompras.Controls.Add(this.txtCantidadCompra);
            this.xtraTabPageDatosCompras.Controls.Add(this.lblPedidoMinimo);
            this.xtraTabPageDatosCompras.Controls.Add(this.txtPedidoMinimo);
            this.xtraTabPageDatosCompras.Controls.Add(this.cbProveedores);
            this.xtraTabPageDatosCompras.Controls.Add(this.lblProveedor);
            this.xtraTabPageDatosCompras.Controls.Add(this.cbImpuestosCompras);
            this.xtraTabPageDatosCompras.Controls.Add(this.lblImpuestoCompra);
            this.xtraTabPageDatosCompras.Controls.Add(this.lblSkuFabricante);
            this.xtraTabPageDatosCompras.Controls.Add(this.txtSKUFabricante);
            this.xtraTabPageDatosCompras.Controls.Add(this.cbUnidadesMedidaCompra);
            this.xtraTabPageDatosCompras.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageDatosCompras.Name = "xtraTabPageDatosCompras";
            this.xtraTabPageDatosCompras.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageDatosCompras.Text = "Datos de compras";
            // 
            // lblUnidadMedidaCompra
            // 
            this.lblUnidadMedidaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnidadMedidaCompra.Location = new System.Drawing.Point(23, 19);
            this.lblUnidadMedidaCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUnidadMedidaCompra.Name = "lblUnidadMedidaCompra";
            this.lblUnidadMedidaCompra.Size = new System.Drawing.Size(115, 17);
            this.lblUnidadMedidaCompra.TabIndex = 139;
            this.lblUnidadMedidaCompra.Text = "Unidad de medida";
            // 
            // lblCantidadCompra
            // 
            this.lblCantidadCompra.Location = new System.Drawing.Point(22, 193);
            this.lblCantidadCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCantidadCompra.Name = "lblCantidadCompra";
            this.lblCantidadCompra.Size = new System.Drawing.Size(109, 17);
            this.lblCantidadCompra.TabIndex = 136;
            this.lblCantidadCompra.Text = "Cantidad compra";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(158, 188);
            this.txtCantidadCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCantidadCompra.MenuManager = this.mainRibbonControl;
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadCompra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadCompra.Properties.Mask.EditMask = "n4";
            this.txtCantidadCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadCompra.Properties.NullValuePrompt = "Peso del artículo";
            this.txtCantidadCompra.Size = new System.Drawing.Size(145, 24);
            this.txtCantidadCompra.TabIndex = 5;
            // 
            // lblPedidoMinimo
            // 
            this.lblPedidoMinimo.Location = new System.Drawing.Point(22, 159);
            this.lblPedidoMinimo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPedidoMinimo.Name = "lblPedidoMinimo";
            this.lblPedidoMinimo.Size = new System.Drawing.Size(95, 17);
            this.lblPedidoMinimo.TabIndex = 85;
            this.lblPedidoMinimo.Text = "Pedido mínimo";
            // 
            // txtPedidoMinimo
            // 
            this.txtPedidoMinimo.Location = new System.Drawing.Point(158, 154);
            this.txtPedidoMinimo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPedidoMinimo.MenuManager = this.mainRibbonControl;
            this.txtPedidoMinimo.Name = "txtPedidoMinimo";
            this.txtPedidoMinimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPedidoMinimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPedidoMinimo.Properties.Mask.EditMask = "n4";
            this.txtPedidoMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPedidoMinimo.Properties.NullValuePrompt = "Peso del artículo";
            this.txtPedidoMinimo.Size = new System.Drawing.Size(145, 24);
            this.txtPedidoMinimo.TabIndex = 4;
            // 
            // cbProveedores
            // 
            this.cbProveedores.Location = new System.Drawing.Point(158, 52);
            this.cbProveedores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbProveedores.MenuManager = this.mainRibbonControl;
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProveedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbProveedores.Size = new System.Drawing.Size(291, 24);
            this.cbProveedores.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProveedor.Location = new System.Drawing.Point(23, 53);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(63, 17);
            this.lblProveedor.TabIndex = 77;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbImpuestosCompras
            // 
            this.cbImpuestosCompras.Location = new System.Drawing.Point(158, 120);
            this.cbImpuestosCompras.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbImpuestosCompras.MenuManager = this.mainRibbonControl;
            this.cbImpuestosCompras.Name = "cbImpuestosCompras";
            this.cbImpuestosCompras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpuestosCompras.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbImpuestosCompras.Size = new System.Drawing.Size(291, 24);
            this.cbImpuestosCompras.TabIndex = 3;
            // 
            // lblImpuestoCompra
            // 
            this.lblImpuestoCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImpuestoCompra.Location = new System.Drawing.Point(22, 121);
            this.lblImpuestoCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblImpuestoCompra.Name = "lblImpuestoCompra";
            this.lblImpuestoCompra.Size = new System.Drawing.Size(108, 17);
            this.lblImpuestoCompra.TabIndex = 65;
            this.lblImpuestoCompra.Text = "Impuesto compra";
            // 
            // lblSkuFabricante
            // 
            this.lblSkuFabricante.Location = new System.Drawing.Point(22, 91);
            this.lblSkuFabricante.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSkuFabricante.Name = "lblSkuFabricante";
            this.lblSkuFabricante.Size = new System.Drawing.Size(30, 17);
            this.lblSkuFabricante.TabIndex = 38;
            this.lblSkuFabricante.Text = "SKU ";
            // 
            // txtSKUFabricante
            // 
            this.txtSKUFabricante.Location = new System.Drawing.Point(158, 86);
            this.txtSKUFabricante.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSKUFabricante.MenuManager = this.mainRibbonControl;
            this.txtSKUFabricante.Name = "txtSKUFabricante";
            this.txtSKUFabricante.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtSKUFabricante.Properties.MaxLength = 40;
            this.txtSKUFabricante.Properties.NullValuePrompt = "Identificador del fabricante";
            this.txtSKUFabricante.Size = new System.Drawing.Size(291, 24);
            this.txtSKUFabricante.TabIndex = 2;
            // 
            // cbUnidadesMedidaCompra
            // 
            this.cbUnidadesMedidaCompra.Location = new System.Drawing.Point(158, 18);
            this.cbUnidadesMedidaCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbUnidadesMedidaCompra.MenuManager = this.mainRibbonControl;
            this.cbUnidadesMedidaCompra.Name = "cbUnidadesMedidaCompra";
            this.cbUnidadesMedidaCompra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedidaCompra.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedidaCompra.Size = new System.Drawing.Size(291, 24);
            this.cbUnidadesMedidaCompra.TabIndex = 0;
            // 
            // xtraTabPageDatosVentas
            // 
            this.xtraTabPageDatosVentas.Controls.Add(this.labelControl6);
            this.xtraTabPageDatosVentas.Controls.Add(this.gcArticulosSociosCFDI);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbEntregaAutomatica);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblGrupos);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbGrupos);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblCantidadVenta);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtCantidadVenta);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbRutas);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblRuta);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbUnidadesMedidaVenta);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtAjusteMaximo);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblRangoAjuste);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtAjusteMinimo);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblCantidadPaquete);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtCantidadPaquete);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblCodigoClasificacion);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtCodigoClasificacion);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbImpuestosVentas);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblImpuestoVenta);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbTiposEmpaques);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblTiposEmpaques);
            this.xtraTabPageDatosVentas.Controls.Add(this.cbPesable);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblClaveUnidad);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtClaveUnidad);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblPeso);
            this.xtraTabPageDatosVentas.Controls.Add(this.txtPeso);
            this.xtraTabPageDatosVentas.Controls.Add(this.lblUnidadMedidaVenta);
            this.xtraTabPageDatosVentas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageDatosVentas.Name = "xtraTabPageDatosVentas";
            this.xtraTabPageDatosVentas.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageDatosVentas.Text = "Datos de ventas";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 392);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 17);
            this.labelControl6.TabIndex = 147;
            this.labelControl6.Text = "Socios / CFDi";
            // 
            // gcArticulosSociosCFDI
            // 
            this.gcArticulosSociosCFDI.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcArticulosSociosCFDI.Location = new System.Drawing.Point(158, 392);
            this.gcArticulosSociosCFDI.MainView = this.gvArticulosSociosCFDI;
            this.gcArticulosSociosCFDI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcArticulosSociosCFDI.MenuManager = this.mainRibbonControl;
            this.gcArticulosSociosCFDI.Name = "gcArticulosSociosCFDI";
            this.gcArticulosSociosCFDI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbSocios2,
            this.cbSocios,
            this.cbImpuestos});
            this.gcArticulosSociosCFDI.Size = new System.Drawing.Size(681, 215);
            this.gcArticulosSociosCFDI.TabIndex = 146;
            this.gcArticulosSociosCFDI.UseEmbeddedNavigator = true;
            this.gcArticulosSociosCFDI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulosSociosCFDI});
            // 
            // gvArticulosSociosCFDI
            // 
            this.gvArticulosSociosCFDI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnSocio,
            this.gridColumnImpuesto,
            this.gridColumnClaveUnidad,
            this.gridColumnCodigoClasificacion});
            this.gvArticulosSociosCFDI.DetailHeight = 458;
            this.gvArticulosSociosCFDI.GridControl = this.gcArticulosSociosCFDI;
            this.gvArticulosSociosCFDI.Name = "gvArticulosSociosCFDI";
            this.gvArticulosSociosCFDI.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvArticulosSociosCFDI.OptionsNavigation.AutoFocusNewRow = true;
            this.gvArticulosSociosCFDI.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 26;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Width = 99;
            // 
            // gridColumnSocio
            // 
            this.gridColumnSocio.Caption = "Socio";
            this.gridColumnSocio.ColumnEdit = this.cbSocios;
            this.gridColumnSocio.FieldName = "socio_id";
            this.gridColumnSocio.MinWidth = 26;
            this.gridColumnSocio.Name = "gridColumnSocio";
            this.gridColumnSocio.Visible = true;
            this.gridColumnSocio.VisibleIndex = 0;
            this.gridColumnSocio.Width = 99;
            // 
            // cbSocios
            // 
            this.cbSocios.AutoHeight = false;
            this.cbSocios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código SN", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Name = "cbSocios";
            // 
            // gridColumnImpuesto
            // 
            this.gridColumnImpuesto.Caption = "Impuesto";
            this.gridColumnImpuesto.ColumnEdit = this.cbImpuestos;
            this.gridColumnImpuesto.FieldName = "impuesto_id";
            this.gridColumnImpuesto.MinWidth = 26;
            this.gridColumnImpuesto.Name = "gridColumnImpuesto";
            this.gridColumnImpuesto.Visible = true;
            this.gridColumnImpuesto.VisibleIndex = 1;
            this.gridColumnImpuesto.Width = 99;
            // 
            // cbImpuestos
            // 
            this.cbImpuestos.AutoHeight = false;
            this.cbImpuestos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpuestos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbImpuestos.Name = "cbImpuestos";
            // 
            // gridColumnClaveUnidad
            // 
            this.gridColumnClaveUnidad.Caption = "Clave de unidad";
            this.gridColumnClaveUnidad.FieldName = "clave_unidad";
            this.gridColumnClaveUnidad.MinWidth = 26;
            this.gridColumnClaveUnidad.Name = "gridColumnClaveUnidad";
            this.gridColumnClaveUnidad.Visible = true;
            this.gridColumnClaveUnidad.VisibleIndex = 3;
            this.gridColumnClaveUnidad.Width = 99;
            // 
            // gridColumnCodigoClasificacion
            // 
            this.gridColumnCodigoClasificacion.Caption = "Código de clasificación";
            this.gridColumnCodigoClasificacion.FieldName = "codigo_clasificacion";
            this.gridColumnCodigoClasificacion.MinWidth = 26;
            this.gridColumnCodigoClasificacion.Name = "gridColumnCodigoClasificacion";
            this.gridColumnCodigoClasificacion.Visible = true;
            this.gridColumnCodigoClasificacion.VisibleIndex = 2;
            this.gridColumnCodigoClasificacion.Width = 99;
            // 
            // cbSocios2
            // 
            this.cbSocios2.AutoHeight = false;
            this.cbSocios2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios2.Name = "cbSocios2";
            this.cbSocios2.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 458;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1066;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbEntregaAutomatica
            // 
            this.cbEntregaAutomatica.Location = new System.Drawing.Point(315, 120);
            this.cbEntregaAutomatica.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbEntregaAutomatica.MenuManager = this.mainRibbonControl;
            this.cbEntregaAutomatica.Name = "cbEntregaAutomatica";
            this.cbEntregaAutomatica.Properties.Caption = "Entrega automatica";
            this.cbEntregaAutomatica.Size = new System.Drawing.Size(153, 21);
            this.cbEntregaAutomatica.TabIndex = 145;
            // 
            // lblGrupos
            // 
            this.lblGrupos.Location = new System.Drawing.Point(18, 363);
            this.lblGrupos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(116, 17);
            this.lblGrupos.TabIndex = 144;
            this.lblGrupos.Text = "Grupos de artículos";
            // 
            // cbGrupos
            // 
            this.cbGrupos.Location = new System.Drawing.Point(159, 358);
            this.cbGrupos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbGrupos.MenuManager = this.mainRibbonControl;
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupos.Size = new System.Drawing.Size(298, 24);
            this.cbGrupos.TabIndex = 143;
            // 
            // lblCantidadVenta
            // 
            this.lblCantidadVenta.Location = new System.Drawing.Point(22, 125);
            this.lblCantidadVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCantidadVenta.Name = "lblCantidadVenta";
            this.lblCantidadVenta.Size = new System.Drawing.Size(95, 17);
            this.lblCantidadVenta.TabIndex = 134;
            this.lblCantidadVenta.Text = "Cantidad venta";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(158, 120);
            this.txtCantidadVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCantidadVenta.MenuManager = this.mainRibbonControl;
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadVenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadVenta.Properties.Mask.EditMask = "n4";
            this.txtCantidadVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadVenta.Properties.NullValuePrompt = "Peso del artículo";
            this.txtCantidadVenta.Size = new System.Drawing.Size(145, 24);
            this.txtCantidadVenta.TabIndex = 133;
            // 
            // cbRutas
            // 
            this.cbRutas.Location = new System.Drawing.Point(158, 324);
            this.cbRutas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbRutas.MenuManager = this.mainRibbonControl;
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRutas.Size = new System.Drawing.Size(298, 24);
            this.cbRutas.TabIndex = 132;
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(22, 325);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(34, 17);
            this.lblRuta.TabIndex = 131;
            this.lblRuta.Text = "Rutas";
            // 
            // cbUnidadesMedidaVenta
            // 
            this.cbUnidadesMedidaVenta.Location = new System.Drawing.Point(158, 18);
            this.cbUnidadesMedidaVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbUnidadesMedidaVenta.MenuManager = this.mainRibbonControl;
            this.cbUnidadesMedidaVenta.Name = "cbUnidadesMedidaVenta";
            this.cbUnidadesMedidaVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedidaVenta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedidaVenta.Size = new System.Drawing.Size(298, 24);
            this.cbUnidadesMedidaVenta.TabIndex = 0;
            // 
            // txtAjusteMaximo
            // 
            this.txtAjusteMaximo.Location = new System.Drawing.Point(311, 290);
            this.txtAjusteMaximo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAjusteMaximo.MenuManager = this.mainRibbonControl;
            this.txtAjusteMaximo.Name = "txtAjusteMaximo";
            this.txtAjusteMaximo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAjusteMaximo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAjusteMaximo.Properties.Mask.EditMask = "n4";
            this.txtAjusteMaximo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAjusteMaximo.Properties.NullValuePrompt = "Peso del artículo";
            this.txtAjusteMaximo.Size = new System.Drawing.Size(145, 24);
            this.txtAjusteMaximo.TabIndex = 9;
            // 
            // lblRangoAjuste
            // 
            this.lblRangoAjuste.Location = new System.Drawing.Point(22, 295);
            this.lblRangoAjuste.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblRangoAjuste.Name = "lblRangoAjuste";
            this.lblRangoAjuste.Size = new System.Drawing.Size(80, 17);
            this.lblRangoAjuste.TabIndex = 81;
            this.lblRangoAjuste.Text = "Rango ajuste";
            // 
            // txtAjusteMinimo
            // 
            this.txtAjusteMinimo.Location = new System.Drawing.Point(158, 290);
            this.txtAjusteMinimo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAjusteMinimo.MenuManager = this.mainRibbonControl;
            this.txtAjusteMinimo.Name = "txtAjusteMinimo";
            this.txtAjusteMinimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAjusteMinimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAjusteMinimo.Properties.Mask.EditMask = "n4";
            this.txtAjusteMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAjusteMinimo.Properties.NullValuePrompt = "Peso del artículo";
            this.txtAjusteMinimo.Size = new System.Drawing.Size(145, 24);
            this.txtAjusteMinimo.TabIndex = 8;
            // 
            // lblCantidadPaquete
            // 
            this.lblCantidadPaquete.Location = new System.Drawing.Point(22, 159);
            this.lblCantidadPaquete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCantidadPaquete.Name = "lblCantidadPaquete";
            this.lblCantidadPaquete.Size = new System.Drawing.Size(120, 17);
            this.lblCantidadPaquete.TabIndex = 79;
            this.lblCantidadPaquete.Text = "Cantidad / paquete";
            // 
            // txtCantidadPaquete
            // 
            this.txtCantidadPaquete.Location = new System.Drawing.Point(158, 154);
            this.txtCantidadPaquete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCantidadPaquete.MenuManager = this.mainRibbonControl;
            this.txtCantidadPaquete.Name = "txtCantidadPaquete";
            this.txtCantidadPaquete.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadPaquete.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidadPaquete.Properties.Mask.EditMask = "n4";
            this.txtCantidadPaquete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadPaquete.Properties.NullValuePrompt = "Peso del artículo";
            this.txtCantidadPaquete.Size = new System.Drawing.Size(145, 24);
            this.txtCantidadPaquete.TabIndex = 4;
            // 
            // lblCodigoClasificacion
            // 
            this.lblCodigoClasificacion.Location = new System.Drawing.Point(22, 261);
            this.lblCodigoClasificacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCodigoClasificacion.Name = "lblCodigoClasificacion";
            this.lblCodigoClasificacion.Size = new System.Drawing.Size(118, 17);
            this.lblCodigoClasificacion.TabIndex = 0;
            this.lblCodigoClasificacion.Text = "Código clasificación";
            // 
            // txtCodigoClasificacion
            // 
            this.txtCodigoClasificacion.Location = new System.Drawing.Point(158, 256);
            this.txtCodigoClasificacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoClasificacion.MenuManager = this.mainRibbonControl;
            this.txtCodigoClasificacion.Name = "txtCodigoClasificacion";
            this.txtCodigoClasificacion.Properties.MaxLength = 8;
            this.txtCodigoClasificacion.Properties.NullValuePrompt = "Código de clasificación";
            this.txtCodigoClasificacion.Size = new System.Drawing.Size(298, 24);
            this.txtCodigoClasificacion.TabIndex = 7;
            // 
            // cbImpuestosVentas
            // 
            this.cbImpuestosVentas.Location = new System.Drawing.Point(158, 222);
            this.cbImpuestosVentas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbImpuestosVentas.MenuManager = this.mainRibbonControl;
            this.cbImpuestosVentas.Name = "cbImpuestosVentas";
            this.cbImpuestosVentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpuestosVentas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbImpuestosVentas.Size = new System.Drawing.Size(298, 24);
            this.cbImpuestosVentas.TabIndex = 6;
            // 
            // lblImpuestoVenta
            // 
            this.lblImpuestoVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImpuestoVenta.Location = new System.Drawing.Point(22, 223);
            this.lblImpuestoVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblImpuestoVenta.Name = "lblImpuestoVenta";
            this.lblImpuestoVenta.Size = new System.Drawing.Size(94, 17);
            this.lblImpuestoVenta.TabIndex = 77;
            this.lblImpuestoVenta.Text = "Impuesto venta";
            // 
            // cbTiposEmpaques
            // 
            this.cbTiposEmpaques.Location = new System.Drawing.Point(158, 188);
            this.cbTiposEmpaques.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbTiposEmpaques.MenuManager = this.mainRibbonControl;
            this.cbTiposEmpaques.Name = "cbTiposEmpaques";
            this.cbTiposEmpaques.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposEmpaques.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTiposEmpaques.Size = new System.Drawing.Size(298, 24);
            this.cbTiposEmpaques.TabIndex = 5;
            // 
            // lblTiposEmpaques
            // 
            this.lblTiposEmpaques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTiposEmpaques.Location = new System.Drawing.Point(22, 193);
            this.lblTiposEmpaques.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblTiposEmpaques.Name = "lblTiposEmpaques";
            this.lblTiposEmpaques.Size = new System.Drawing.Size(90, 17);
            this.lblTiposEmpaques.TabIndex = 75;
            this.lblTiposEmpaques.Text = "Tipo empaque";
            // 
            // cbPesable
            // 
            this.cbPesable.Location = new System.Drawing.Point(315, 86);
            this.cbPesable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbPesable.MenuManager = this.mainRibbonControl;
            this.cbPesable.Name = "cbPesable";
            this.cbPesable.Properties.Caption = "Pesar en báscula";
            this.cbPesable.Size = new System.Drawing.Size(139, 21);
            this.cbPesable.TabIndex = 3;
            // 
            // lblClaveUnidad
            // 
            this.lblClaveUnidad.Location = new System.Drawing.Point(22, 57);
            this.lblClaveUnidad.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblClaveUnidad.Name = "lblClaveUnidad";
            this.lblClaveUnidad.Size = new System.Drawing.Size(80, 17);
            this.lblClaveUnidad.TabIndex = 74;
            this.lblClaveUnidad.Text = "Clave unidad";
            // 
            // txtClaveUnidad
            // 
            this.txtClaveUnidad.Location = new System.Drawing.Point(158, 52);
            this.txtClaveUnidad.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtClaveUnidad.MenuManager = this.mainRibbonControl;
            this.txtClaveUnidad.Name = "txtClaveUnidad";
            this.txtClaveUnidad.Properties.MaxLength = 100;
            this.txtClaveUnidad.Properties.NullValuePrompt = "Clave unidad";
            this.txtClaveUnidad.Size = new System.Drawing.Size(298, 24);
            this.txtClaveUnidad.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.Location = new System.Drawing.Point(22, 91);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(28, 17);
            this.lblPeso.TabIndex = 72;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(158, 86);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPeso.MenuManager = this.mainRibbonControl;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPeso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPeso.Properties.Mask.EditMask = "n4";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeso.Properties.NullValuePrompt = "Peso del artículo";
            this.txtPeso.Size = new System.Drawing.Size(145, 24);
            this.txtPeso.TabIndex = 2;
            // 
            // lblUnidadMedidaVenta
            // 
            this.lblUnidadMedidaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnidadMedidaVenta.Location = new System.Drawing.Point(22, 23);
            this.lblUnidadMedidaVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUnidadMedidaVenta.Name = "lblUnidadMedidaVenta";
            this.lblUnidadMedidaVenta.Size = new System.Drawing.Size(115, 17);
            this.lblUnidadMedidaVenta.TabIndex = 140;
            this.lblUnidadMedidaVenta.Text = "Unidad de medida";
            // 
            // xtraTabPageDatosInventario
            // 
            this.xtraTabPageDatosInventario.Controls.Add(this.gcInventario);
            this.xtraTabPageDatosInventario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageDatosInventario.Name = "xtraTabPageDatosInventario";
            this.xtraTabPageDatosInventario.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageDatosInventario.Text = "Datos de inventario";
            // 
            // gcInventario
            // 
            this.gcInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInventario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcInventario.Location = new System.Drawing.Point(0, 0);
            this.gcInventario.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gcInventario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcInventario.MainView = this.gvInventario;
            this.gcInventario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcInventario.MenuManager = this.mainRibbonControl;
            this.gcInventario.Name = "gcInventario";
            this.gcInventario.ShowOnlyPredefinedDetails = true;
            this.gcInventario.Size = new System.Drawing.Size(937, 642);
            this.gcInventario.TabIndex = 0;
            this.gcInventario.UseEmbeddedNavigator = true;
            this.gcInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventario});
            // 
            // gvInventario
            // 
            this.gvInventario.ActiveFilterEnabled = false;
            this.gvInventario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.articulo_id,
            this.codigo,
            this.gridColumn2,
            this.activo,
            this.stock,
            this.comprometido,
            this.pedido,
            this.fecha_llegada,
            this.disponible,
            this.stock_minimo,
            this.stock_maximo,
            this.punto_reorden,
            this.ubicacion});
            this.gvInventario.DetailHeight = 458;
            this.gvInventario.GridControl = this.gcInventario;
            this.gvInventario.Name = "gvInventario";
            this.gvInventario.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInventario.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInventario.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvInventario.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvInventario.OptionsFilter.AllowFilterEditor = false;
            this.gvInventario.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gvInventario.OptionsFilter.AllowMRUFilterList = false;
            this.gvInventario.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gvInventario.OptionsView.ShowFooter = true;
            this.gvInventario.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.MinWidth = 26;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 99;
            // 
            // articulo_id
            // 
            this.articulo_id.Caption = "Artículo ID";
            this.articulo_id.FieldName = "articulo_id";
            this.articulo_id.MinWidth = 26;
            this.articulo_id.Name = "articulo_id";
            this.articulo_id.Width = 99;
            // 
            // codigo
            // 
            this.codigo.Caption = "Código del almacén";
            this.codigo.FieldName = "codigo";
            this.codigo.MinWidth = 26;
            this.codigo.Name = "codigo";
            this.codigo.OptionsColumn.AllowEdit = false;
            this.codigo.OptionsColumn.AllowFocus = false;
            this.codigo.OptionsColumn.ReadOnly = true;
            this.codigo.OptionsColumn.ShowInExpressionEditor = false;
            this.codigo.Visible = true;
            this.codigo.VisibleIndex = 0;
            this.codigo.Width = 99;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre del almacén";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.MinWidth = 26;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 99;
            // 
            // activo
            // 
            this.activo.Caption = "Activo";
            this.activo.FieldName = "activo";
            this.activo.MinWidth = 26;
            this.activo.Name = "activo";
            this.activo.Visible = true;
            this.activo.VisibleIndex = 2;
            this.activo.Width = 99;
            // 
            // stock
            // 
            this.stock.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stock.AppearanceCell.Options.UseBackColor = true;
            this.stock.Caption = "En stock";
            this.stock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stock.FieldName = "stock";
            this.stock.MinWidth = 26;
            this.stock.Name = "stock";
            this.stock.OptionsColumn.AllowEdit = false;
            this.stock.OptionsColumn.AllowFocus = false;
            this.stock.OptionsColumn.ReadOnly = true;
            this.stock.OptionsColumn.ShowInExpressionEditor = false;
            this.stock.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "stock", "SUMA={0:#.##}")});
            this.stock.Visible = true;
            this.stock.VisibleIndex = 3;
            this.stock.Width = 99;
            // 
            // comprometido
            // 
            this.comprometido.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comprometido.AppearanceCell.Options.UseBackColor = true;
            this.comprometido.Caption = "Comprometido";
            this.comprometido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.comprometido.FieldName = "comprometido";
            this.comprometido.MinWidth = 26;
            this.comprometido.Name = "comprometido";
            this.comprometido.OptionsColumn.AllowEdit = false;
            this.comprometido.OptionsColumn.AllowFocus = false;
            this.comprometido.OptionsColumn.ReadOnly = true;
            this.comprometido.OptionsColumn.ShowInExpressionEditor = false;
            this.comprometido.Visible = true;
            this.comprometido.VisibleIndex = 4;
            this.comprometido.Width = 99;
            // 
            // pedido
            // 
            this.pedido.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pedido.AppearanceCell.Options.UseBackColor = true;
            this.pedido.Caption = "Pedido";
            this.pedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pedido.FieldName = "pedido";
            this.pedido.MinWidth = 26;
            this.pedido.Name = "pedido";
            this.pedido.OptionsColumn.AllowEdit = false;
            this.pedido.OptionsColumn.AllowFocus = false;
            this.pedido.OptionsColumn.ReadOnly = true;
            this.pedido.OptionsColumn.ShowInExpressionEditor = false;
            this.pedido.Visible = true;
            this.pedido.VisibleIndex = 5;
            this.pedido.Width = 99;
            // 
            // fecha_llegada
            // 
            this.fecha_llegada.Caption = "Fecha llegada";
            this.fecha_llegada.FieldName = "fecha_llegada";
            this.fecha_llegada.MinWidth = 26;
            this.fecha_llegada.Name = "fecha_llegada";
            this.fecha_llegada.Width = 99;
            // 
            // disponible
            // 
            this.disponible.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.disponible.AppearanceCell.Options.UseBackColor = true;
            this.disponible.Caption = "Disponible";
            this.disponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.disponible.FieldName = "disponible";
            this.disponible.MinWidth = 26;
            this.disponible.Name = "disponible";
            this.disponible.OptionsColumn.AllowEdit = false;
            this.disponible.OptionsColumn.AllowFocus = false;
            this.disponible.OptionsColumn.ReadOnly = true;
            this.disponible.OptionsColumn.ShowInExpressionEditor = false;
            this.disponible.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disponible", "SUMA={0:#.##}")});
            this.disponible.Visible = true;
            this.disponible.VisibleIndex = 6;
            this.disponible.Width = 99;
            // 
            // stock_minimo
            // 
            this.stock_minimo.Caption = "Stock mínimo";
            this.stock_minimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stock_minimo.FieldName = "stock_minimo";
            this.stock_minimo.MinWidth = 26;
            this.stock_minimo.Name = "stock_minimo";
            this.stock_minimo.Visible = true;
            this.stock_minimo.VisibleIndex = 7;
            this.stock_minimo.Width = 99;
            // 
            // stock_maximo
            // 
            this.stock_maximo.Caption = "Stock Máximo";
            this.stock_maximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stock_maximo.FieldName = "stock_maximo";
            this.stock_maximo.MinWidth = 26;
            this.stock_maximo.Name = "stock_maximo";
            this.stock_maximo.Visible = true;
            this.stock_maximo.VisibleIndex = 8;
            this.stock_maximo.Width = 99;
            // 
            // punto_reorden
            // 
            this.punto_reorden.Caption = "Punto de reorden";
            this.punto_reorden.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.punto_reorden.FieldName = "punto_reorden";
            this.punto_reorden.MinWidth = 26;
            this.punto_reorden.Name = "punto_reorden";
            this.punto_reorden.Visible = true;
            this.punto_reorden.VisibleIndex = 9;
            this.punto_reorden.Width = 99;
            // 
            // ubicacion
            // 
            this.ubicacion.Caption = "Ubicación";
            this.ubicacion.FieldName = "ubicacion";
            this.ubicacion.MinWidth = 26;
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Visible = true;
            this.ubicacion.VisibleIndex = 10;
            this.ubicacion.Width = 99;
            // 
            // xtraTabPagePropiedades
            // 
            this.xtraTabPagePropiedades.Controls.Add(this.cbPropiedades);
            this.xtraTabPagePropiedades.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPagePropiedades.Name = "xtraTabPagePropiedades";
            this.xtraTabPagePropiedades.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPagePropiedades.Text = "Propiedades";
            // 
            // cbPropiedades
            // 
            this.cbPropiedades.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPropiedades.Location = new System.Drawing.Point(0, 0);
            this.cbPropiedades.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbPropiedades.Name = "cbPropiedades";
            this.cbPropiedades.Size = new System.Drawing.Size(937, 642);
            this.cbPropiedades.TabIndex = 1;
            // 
            // xtraTabPageUbicaciones
            // 
            this.xtraTabPageUbicaciones.Controls.Add(this.gcUbicaciones);
            this.xtraTabPageUbicaciones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageUbicaciones.Name = "xtraTabPageUbicaciones";
            this.xtraTabPageUbicaciones.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageUbicaciones.Text = "Ubicaciones";
            // 
            // gcUbicaciones
            // 
            this.gcUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUbicaciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcUbicaciones.Location = new System.Drawing.Point(0, 0);
            this.gcUbicaciones.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gcUbicaciones.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcUbicaciones.MainView = this.gvUbicaciones;
            this.gcUbicaciones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcUbicaciones.MenuManager = this.mainRibbonControl;
            this.gcUbicaciones.Name = "gcUbicaciones";
            this.gcUbicaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAlmacenes});
            this.gcUbicaciones.ShowOnlyPredefinedDetails = true;
            this.gcUbicaciones.Size = new System.Drawing.Size(937, 642);
            this.gcUbicaciones.TabIndex = 1;
            this.gcUbicaciones.UseEmbeddedNavigator = true;
            this.gcUbicaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUbicaciones});
            // 
            // gvUbicaciones
            // 
            this.gvUbicaciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvUbicaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvUbicaciones.DetailHeight = 458;
            this.gvUbicaciones.GridControl = this.gcUbicaciones;
            this.gvUbicaciones.Name = "gvUbicaciones";
            this.gvUbicaciones.NewItemRowText = "Nueva ubicación";
            this.gvUbicaciones.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvUbicaciones.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvUbicaciones.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvUbicaciones.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvUbicaciones.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gvUbicaciones.OptionsFilter.AllowMRUFilterList = false;
            this.gvUbicaciones.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gvUbicaciones.OptionsNavigation.AutoFocusNewRow = true;
            this.gvUbicaciones.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.MinWidth = 26;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 99;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Artículo ID";
            this.gridColumn4.FieldName = "articulo_id";
            this.gridColumn4.MinWidth = 26;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 99;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Almacén";
            this.gridColumn5.ColumnEdit = this.cbAlmacenes;
            this.gridColumn5.FieldName = "almacen_id";
            this.gridColumn5.MinWidth = 26;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 99;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.AutoHeight = false;
            this.cbAlmacenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Almacén ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Name = "cbAlmacenes";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ubicación";
            this.gridColumn6.FieldName = "ubicacion";
            this.gridColumn6.MinWidth = 26;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 99;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Activo";
            this.gridColumn7.FieldName = "activo";
            this.gridColumn7.MinWidth = 26;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 99;
            // 
            // xtraTabPageWeb
            // 
            this.xtraTabPageWeb.Controls.Add(this.txtDescripcionWeb);
            this.xtraTabPageWeb.Controls.Add(this.txtPalabrasClave);
            this.xtraTabPageWeb.Controls.Add(this.labelControl5);
            this.xtraTabPageWeb.Controls.Add(this.labelControl4);
            this.xtraTabPageWeb.Controls.Add(this.txtAplicacionesWeb);
            this.xtraTabPageWeb.Controls.Add(this.labelControl3);
            this.xtraTabPageWeb.Controls.Add(this.txtCaracteristicasWeb);
            this.xtraTabPageWeb.Controls.Add(this.labelControl2);
            this.xtraTabPageWeb.Controls.Add(this.txtInformacionAdicionalWeb);
            this.xtraTabPageWeb.Controls.Add(this.labelControl7);
            this.xtraTabPageWeb.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPageWeb.Name = "xtraTabPageWeb";
            this.xtraTabPageWeb.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageWeb.Text = "Web";
            // 
            // txtDescripcionWeb
            // 
            this.txtDescripcionWeb.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtDescripcionWeb.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtDescripcionWeb.Location = new System.Drawing.Point(15, 37);
            this.txtDescripcionWeb.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescripcionWeb.MenuManager = this.mainRibbonControl;
            this.txtDescripcionWeb.Name = "txtDescripcionWeb";
            this.txtDescripcionWeb.Options.ClipboardFormats.AllowHtml = true;
            this.txtDescripcionWeb.Options.ClipboardFormats.Html = DevExpress.XtraRichEdit.RichEditClipboardMode.Enabled;
            this.txtDescripcionWeb.Options.HorizontalRuler.ShowLeftIndent = false;
            this.txtDescripcionWeb.Options.HorizontalRuler.ShowRightIndent = false;
            this.txtDescripcionWeb.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtDescripcionWeb.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtDescripcionWeb.Size = new System.Drawing.Size(1063, 213);
            this.txtDescripcionWeb.TabIndex = 11;
            // 
            // txtPalabrasClave
            // 
            this.txtPalabrasClave.Location = new System.Drawing.Point(15, 674);
            this.txtPalabrasClave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPalabrasClave.MenuManager = this.mainRibbonControl;
            this.txtPalabrasClave.Name = "txtPalabrasClave";
            this.txtPalabrasClave.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPalabrasClave.Properties.MaxLength = 254;
            this.txtPalabrasClave.Properties.NullValuePrompt = "Palabras clave";
            this.txtPalabrasClave.Size = new System.Drawing.Size(1063, 24);
            this.txtPalabrasClave.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 649);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(193, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Palabras clave (separadas por ,)";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(561, 452);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Aplicaciones";
            // 
            // txtAplicacionesWeb
            // 
            this.txtAplicacionesWeb.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtAplicacionesWeb.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtAplicacionesWeb.Location = new System.Drawing.Point(561, 477);
            this.txtAplicacionesWeb.Margin = new System.Windows.Forms.Padding(0);
            this.txtAplicacionesWeb.MenuManager = this.mainRibbonControl;
            this.txtAplicacionesWeb.Name = "txtAplicacionesWeb";
            this.txtAplicacionesWeb.Options.ClipboardFormats.AllowHtml = true;
            this.txtAplicacionesWeb.Options.ClipboardFormats.Html = DevExpress.XtraRichEdit.RichEditClipboardMode.Enabled;
            this.txtAplicacionesWeb.Options.HorizontalRuler.ShowLeftIndent = false;
            this.txtAplicacionesWeb.Options.HorizontalRuler.ShowRightIndent = false;
            this.txtAplicacionesWeb.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtAplicacionesWeb.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtAplicacionesWeb.Size = new System.Drawing.Size(515, 161);
            this.txtAplicacionesWeb.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 452);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Caracteristicas";
            // 
            // txtCaracteristicasWeb
            // 
            this.txtCaracteristicasWeb.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtCaracteristicasWeb.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtCaracteristicasWeb.Location = new System.Drawing.Point(15, 477);
            this.txtCaracteristicasWeb.Margin = new System.Windows.Forms.Padding(0);
            this.txtCaracteristicasWeb.MenuManager = this.mainRibbonControl;
            this.txtCaracteristicasWeb.Name = "txtCaracteristicasWeb";
            this.txtCaracteristicasWeb.Options.ClipboardFormats.AllowHtml = true;
            this.txtCaracteristicasWeb.Options.ClipboardFormats.Html = DevExpress.XtraRichEdit.RichEditClipboardMode.Enabled;
            this.txtCaracteristicasWeb.Options.HorizontalRuler.ShowLeftIndent = false;
            this.txtCaracteristicasWeb.Options.HorizontalRuler.ShowRightIndent = false;
            this.txtCaracteristicasWeb.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtCaracteristicasWeb.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtCaracteristicasWeb.Size = new System.Drawing.Size(515, 161);
            this.txtCaracteristicasWeb.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 254);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Información adicional";
            // 
            // txtInformacionAdicionalWeb
            // 
            this.txtInformacionAdicionalWeb.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtInformacionAdicionalWeb.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtInformacionAdicionalWeb.Location = new System.Drawing.Point(15, 280);
            this.txtInformacionAdicionalWeb.Margin = new System.Windows.Forms.Padding(0);
            this.txtInformacionAdicionalWeb.MenuManager = this.mainRibbonControl;
            this.txtInformacionAdicionalWeb.Name = "txtInformacionAdicionalWeb";
            this.txtInformacionAdicionalWeb.Options.ClipboardFormats.AllowHtml = true;
            this.txtInformacionAdicionalWeb.Options.ClipboardFormats.Html = DevExpress.XtraRichEdit.RichEditClipboardMode.Enabled;
            this.txtInformacionAdicionalWeb.Options.HorizontalRuler.ShowLeftIndent = false;
            this.txtInformacionAdicionalWeb.Options.HorizontalRuler.ShowRightIndent = false;
            this.txtInformacionAdicionalWeb.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtInformacionAdicionalWeb.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtInformacionAdicionalWeb.Size = new System.Drawing.Size(1063, 161);
            this.txtInformacionAdicionalWeb.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 14);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 17);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Descripción";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.dtgrvArticulosAlternativos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPage1.Text = "Articulos Alternativos";
            // 
            // dtgrvArticulosAlternativos
            // 
            this.dtgrvArticulosAlternativos.AllowUserToAddRows = false;
            this.dtgrvArticulosAlternativos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrvArticulosAlternativos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvArticulosAlternativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvArticulosAlternativos.Enabled = false;
            this.dtgrvArticulosAlternativos.Location = new System.Drawing.Point(3, 19);
            this.dtgrvArticulosAlternativos.Name = "dtgrvArticulosAlternativos";
            this.dtgrvArticulosAlternativos.Size = new System.Drawing.Size(1078, 511);
            this.dtgrvArticulosAlternativos.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(967, 696);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(947, 676);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmFormArt
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 820);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmFormArt";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrizaciones del Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcluirSincronizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaInventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreAPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIEPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSujetoImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSujetoRetencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDAdicional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplicador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).EndInit();
            this.gbSeguimento.ResumeLayout(false);
            this.gbSeguimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasGarantia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCanjeable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKU.Properties)).EndInit();
            this.xtraTabPageDatosCompras.ResumeLayout(false);
            this.xtraTabPageDatosCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedidoMinimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestosCompras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKUFabricante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaCompra.Properties)).EndInit();
            this.xtraTabPageDatosVentas.ResumeLayout(false);
            this.xtraTabPageDatosVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticulosSociosCFDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulosSociosCFDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEntregaAutomatica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedidaVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAjusteMaximo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAjusteMinimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPaquete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestosVentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPesable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            this.xtraTabPageDatosInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).EndInit();
            this.xtraTabPagePropiedades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).EndInit();
            this.xtraTabPageUbicaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).EndInit();
            this.xtraTabPageWeb.ResumeLayout(false);
            this.xtraTabPageWeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalabrasClave.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvArticulosAlternativos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DefaultLookAndFeel defaultLookAndFeel1;
        private LookUpEdit cbRoles;
        private SimpleButton btnGuardar;
        private LabelControl labelControl1;
        private PanelControl panelControl2;
        private DataGridView dataGridView1;
        private SimpleButton simpleButton1;
        private PanelControl panelControl1;
        private Panel panel1;
        private DevExpress.Utils.Html.HtmlTemplateCollection lbAnexos;
        private DevExpress.Utils.Html.HtmlTemplateCollection lbReferencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneral;
        private SimpleButton btnVisualizarImagen;
        private SimpleButton btnAnexarImagen;
        private ListBoxControl lbImagenes;
        private CheckEdit cbWeb;
        private RibbonControl mainRibbonControl;
        private BackstageViewControl backstageViewControl1;
        private BarButtonItem bbiGuardar;
        private BarButtonItem bbiGuardarCerrar;
        private BarButtonItem bbiGuardarNuevo;
        private BarButtonItem bbiEliminar;
        private BarButtonItem bbiBuscar;
        private BarButtonItem bbiPrimero;
        private BarButtonItem bbiAnterior;
        private BarButtonItem bbiUltimo;
        private BarButtonItem bbiSiguiente;
        private BarButtonItem bbiNuevo;
        private BarButtonItem barButtonItemDescuentos;
        private BarButtonItem bbiParametrizacionesFormulario;
        private BarButtonItem bbiPartidasAbiertas;
        private BarButtonItem bbiPaquetes;
        private RibbonPage mainRibbonPage;
        private RibbonPageGroup mainRibbonPageGroup;
        private RibbonPageGroup searchRibbonPageGroup;
        private RibbonPage ribbonPageHerramientas;
        private RibbonPageGroup ribbonPageGroup1;
        private CheckEdit cbExcluirSincronizacion;
        private LookUpEdit cbUnidadesMedidaInventario;
        private LabelControl lblUnidadMedida;
        private LabelControl lblNombreAPI;
        private TextEdit txtNombreAPI;
        private CheckEdit cbAPI;
        private MemoEdit txtComentario;
        private LabelControl lblComentario;
        private SimpleButton btnAgregarAlInventario;
        private CheckEdit cbIEPS;
        private CheckEdit cbSujetoImpuesto;
        private CheckEdit cbSujetoRetencion;
        private LookUpEdit cbAlmacen;
        private HyperlinkLabelControl lblAlmacen;
        private LabelControl lblIDAdicional;
        private TextEdit txtIDAdicional;
        private HyperlinkLabelControl lblCodigoBarras;
        private LabelControl lblMultiplicador;
        private TextEdit txtMultiplicador;
        private HyperlinkLabelControl lblFabricantes;
        private LookUpEdit cbFabricantes;
        private LookUpEdit cbMonedas;
        private HyperlinkLabelControl lblMonedas;
        private LookUpEdit cbListasPrecios;
        private HyperlinkLabelControl lblListaPrecios;
        private LookUpEdit cbGruposArticulos;
        private HyperlinkLabelControl lblGrupoArticulos;
        private CheckEdit cbActivo;
        private SimpleButton btnImagen;
        private LabelControl lblID;
        private LabelControl lblFechaActualizacion;
        private LabelControl lblUltimaActualizacion;
        private PictureBox pbImagen;
        private LabelControl lblStock;
        private TextEdit txtStock;
        private LabelControl lblPrecio;
        private TextEdit txtPrecio;
        private TextEdit txtCodigoBarras;
        private GroupBox gbSeguimento;
        private RadioButton rbLotes;
        private LabelControl lblDiasGarantia;
        private TextEdit txtDiasGarantia;
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
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDatosCompras;
        private HyperlinkLabelControl lblUnidadMedidaCompra;
        private LabelControl lblCantidadCompra;
        private TextEdit txtCantidadCompra;
        private LabelControl lblPedidoMinimo;
        private TextEdit txtPedidoMinimo;
        private LookUpEdit cbProveedores;
        private HyperlinkLabelControl lblProveedor;
        private LookUpEdit cbImpuestosCompras;
        private HyperlinkLabelControl lblImpuestoCompra;
        private LabelControl lblSkuFabricante;
        private TextEdit txtSKUFabricante;
        private LookUpEdit cbUnidadesMedidaCompra;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDatosVentas;
        private LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gcArticulosSociosCFDI;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulosSociosCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSocio;
        private RepositoryItemLookUpEdit cbSocios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImpuesto;
        private RepositoryItemLookUpEdit cbImpuestos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnClaveUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoClasificacion;
        private RepositoryItemGridLookUpEdit cbSocios2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private CheckEdit cbEntregaAutomatica;
        private LabelControl lblGrupos;
        private CheckedComboBoxEdit cbGrupos;
        private LabelControl lblCantidadVenta;
        private TextEdit txtCantidadVenta;
        private CheckedComboBoxEdit cbRutas;
        private HyperlinkLabelControl lblRuta;
        private LookUpEdit cbUnidadesMedidaVenta;
        private TextEdit txtAjusteMaximo;
        private LabelControl lblRangoAjuste;
        private TextEdit txtAjusteMinimo;
        private LabelControl lblCantidadPaquete;
        private TextEdit txtCantidadPaquete;
        private LabelControl lblCodigoClasificacion;
        private TextEdit txtCodigoClasificacion;
        private LookUpEdit cbImpuestosVentas;
        private HyperlinkLabelControl lblImpuestoVenta;
        private LookUpEdit cbTiposEmpaques;
        private HyperlinkLabelControl lblTiposEmpaques;
        private CheckEdit cbPesable;
        private LabelControl lblClaveUnidad;
        private TextEdit txtClaveUnidad;
        private LabelControl lblPeso;
        private TextEdit txtPeso;
        private HyperlinkLabelControl lblUnidadMedidaVenta;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDatosInventario;
        private DevExpress.XtraGrid.GridControl gcInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn articulo_id;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn activo;
        private DevExpress.XtraGrid.Columns.GridColumn stock;
        private DevExpress.XtraGrid.Columns.GridColumn comprometido;
        private DevExpress.XtraGrid.Columns.GridColumn pedido;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_llegada;
        private DevExpress.XtraGrid.Columns.GridColumn disponible;
        private DevExpress.XtraGrid.Columns.GridColumn stock_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn stock_maximo;
        private DevExpress.XtraGrid.Columns.GridColumn punto_reorden;
        private DevExpress.XtraGrid.Columns.GridColumn ubicacion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePropiedades;
        private CheckedListBoxControl cbPropiedades;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUbicaciones;
        private DevExpress.XtraGrid.GridControl gcUbicaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUbicaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private RepositoryItemLookUpEdit cbAlmacenes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageWeb;
        private DevExpress.XtraRichEdit.RichEditControl txtDescripcionWeb;
        private TextEdit txtPalabrasClave;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private DevExpress.XtraRichEdit.RichEditControl txtAplicacionesWeb;
        private LabelControl labelControl3;
        private DevExpress.XtraRichEdit.RichEditControl txtCaracteristicasWeb;
        private LabelControl labelControl2;
        private DevExpress.XtraRichEdit.RichEditControl txtInformacionAdicionalWeb;
        private LabelControl labelControl7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DataGridView dtgrvArticulosAlternativos;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
    }
}