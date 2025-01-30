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
using SDK;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace DTM
{
    partial class btnBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnBuscar));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator9 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.lbMensajeC = new DevExpress.XtraEditors.LabelControl();
            this.lbFact = new DevExpress.XtraEditors.LabelControl();
            this.lbCredito = new DevExpress.XtraEditors.LabelControl();
            this.txtFactVencidas = new DevExpress.XtraEditors.TextEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRecargar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiNuevoSocio = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopiar = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemMapaRelaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiEnviar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiCerrar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiPagar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiAjustarColumnas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDuplicar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelacionManualCFDI = new DevExpress.XtraBars.BarButtonItem();
            this.bbiParametrizaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtCreditoDisponible = new DevExpress.XtraEditors.TextEdit();
            this.btnStat = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargaArticulos = new DevExpress.XtraEditors.SimpleButton();
            this.btnDescuentosEspeciales = new DevExpress.XtraEditors.SimpleButton();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaVigencia = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaVigencia = new DevExpress.XtraEditors.LabelControl();
            this.lblEnviado = new System.Windows.Forms.Label();
            this.lblAlmacenDestino = new DevExpress.XtraEditors.LabelControl();
            this.lblAlmacenOrigen = new DevExpress.XtraEditors.LabelControl();
            this.lblClase = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbAlmacenDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.cbAlmacenOrigen = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUtilidad = new DevExpress.XtraEditors.LabelControl();
            this.deFechaVencimiento = new DevExpress.XtraEditors.DateEdit();
            this.deFechaContabilizacion = new DevExpress.XtraEditors.DateEdit();
            this.txtNumeroDocumentoExterno = new DevExpress.XtraEditors.TextEdit();
            this.lblArticulos = new DevExpress.XtraEditors.LabelControl();
            this.lblPartidas = new DevExpress.XtraEditors.LabelControl();
            this.lblReferencia = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoSN = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblImpreso = new System.Windows.Forms.Label();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.cbMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtFechaCreacion = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaCreacion = new DevExpress.XtraEditors.LabelControl();
            this.cbSeries = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNumeroDocumento = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaDocumento = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaVencimiento = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaContabilizacion = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.cbVendedores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVendedores = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblImporteAplicado = new DevExpress.XtraEditors.LabelControl();
            this.txtImporteAplicado = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblImpuesto = new DevExpress.XtraEditors.LabelControl();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoSN = new DevExpress.XtraEditors.TextEdit();
            this.lblSocio = new DevExpress.XtraEditors.LabelControl();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumnPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUnidadesMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCantidadEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTiposEmpaques = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCantidadPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidadPaquete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrecioPieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnListaPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbListasPrecios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPorcentajeDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrecioNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAlmacenes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUbicaciones = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnAlmacenDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUbicacionDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescuentoEspecial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNumeroPedimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAlmacenesDestino = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPageLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditarDireccionOrigen = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarDireccionOrigen = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccionOrigen = new DevExpress.XtraEditors.MemoEdit();
            this.cbDireccionesOrigen = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionOrigen = new DevExpress.XtraEditors.LabelControl();
            this.btnEditarDireccionFacturacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarDireccionEnvio = new DevExpress.XtraEditors.SimpleButton();
            this.lblDistancia = new DevExpress.XtraEditors.LabelControl();
            this.txtDistancia = new DevExpress.XtraEditors.TextEdit();
            this.cbRemolques = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRemolque = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.bcID = new DevExpress.XtraEditors.BarCodeControl();
            this.cbRutas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRuta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.gcSeguimiento = new DevExpress.XtraEditors.GroupControl();
            this.cbEstadoSeguimiento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSeguimiento = new DevExpress.XtraEditors.CheckEdit();
            this.cbCausalidades = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCausalidades = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbSupervisores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSupervisores = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbForaneo = new DevExpress.XtraEditors.CheckEdit();
            this.cbVehiculos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehiculo = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbChoferes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblChofer = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnSolicitarEtiquetas = new DevExpress.XtraEditors.SimpleButton();
            this.lblActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblSincronizacion = new System.Windows.Forms.Label();
            this.cbPersonasContacto = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPersonasContacto = new DevExpress.XtraEditors.LabelControl();
            this.cbClasesExpedicion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblClaseExpedicion = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblCreacion = new DevExpress.XtraEditors.LabelControl();
            this.btnDireccionFacturacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarDireccionEnvio = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccionEnvio = new DevExpress.XtraEditors.MemoEdit();
            this.txtDireccionFacturacion = new DevExpress.XtraEditors.MemoEdit();
            this.cbDireccionesEnvio = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionEnvio = new DevExpress.XtraEditors.LabelControl();
            this.cbDireccionesFacturacion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionFacturacion = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageFinanzas = new DevExpress.XtraTab.XtraTabPage();
            this.cbProyectos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblProyectos = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbCanales = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCanal = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lbReferencias = new DevExpress.XtraEditors.ListBoxControl();
            this.btnReferencias = new DevExpress.XtraEditors.SimpleButton();
            this.lblOrdenCompra = new DevExpress.XtraEditors.LabelControl();
            this.txtOrdenCompra = new DevExpress.XtraEditors.TextEdit();
            this.lblCuentaPago = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaPago = new DevExpress.XtraEditors.TextEdit();
            this.cbMetodosPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMetodosPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbCondicionesPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCondicionesPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.xtraTabPageDocumentoElectronico = new DevExpress.XtraTab.XtraTabPage();
            this.cbGlobal = new DevExpress.XtraEditors.CheckEdit();
            this.btnGenerarSustitucion = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarDE = new DevExpress.XtraEditors.SimpleButton();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarRFCGenerico = new DevExpress.XtraEditors.SimpleButton();
            this.lblCancelacionMasiva = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblUUIDErrorCancelacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUUIDPorCancelar = new DevExpress.XtraEditors.LabelControl();
            this.txtUUIDErrorCancelacion = new System.Windows.Forms.RichTextBox();
            this.txtUUIDPorCancelar = new System.Windows.Forms.RichTextBox();
            this.btnCancelacionMasiva = new System.Windows.Forms.Button();
            this.btnEstadoCFDI = new DevExpress.XtraEditors.SimpleButton();
            this.lblImportarFolioFiscal = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSelloCFD = new DevExpress.XtraEditors.MemoEdit();
            this.lblSelloCFD = new DevExpress.XtraEditors.LabelControl();
            this.txtCadenaOriginal = new DevExpress.XtraEditors.MemoEdit();
            this.lblCadenaOriginal = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioFiscal = new DevExpress.XtraEditors.LabelControl();
            this.txtFolioFiscal = new DevExpress.XtraEditors.TextEdit();
            this.cbGenerarDocumentoElectronico = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPageAnexos = new DevExpress.XtraTab.XtraTabPage();
            this.btnVisualizarAnexo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnexos = new DevExpress.XtraEditors.SimpleButton();
            this.lbAnexos = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbRoles = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbDocumentos = new DevExpress.XtraEditors.LookUpEdit();
            this.Formulario = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarCartaPorte = new DevExpress.XtraEditors.SimpleButton();
            this.chckCartaPorte = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaSalida = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaLlegada = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtHoraSalida = new DevExpress.XtraEditors.DateEdit();
            this.dtHoraLlegada = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactVencidas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditoDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVigencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCreacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenesDestino)).BeginInit();
            this.xtraTabPageLogistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRemolques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeguimiento)).BeginInit();
            this.gcSeguimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoSeguimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeguimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCausalidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupervisores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbForaneo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVehiculos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChoferes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPersonasContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClasesExpedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesFacturacion.Properties)).BeginInit();
            this.xtraTabPageFinanzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProyectos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCanales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbReferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).BeginInit();
            this.xtraTabPageDocumentoElectronico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGlobal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelloCFD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarDocumentoElectronico.Properties)).BeginInit();
            this.xtraTabPageAnexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckCartaPorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraSalida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraLlegada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraLlegada.Properties.CalendarTimeProperties)).BeginInit();
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.mainRibbonControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 760);
            this.panelControl1.TabIndex = 12;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 62);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(967, 696);
            this.layoutControl1.TabIndex = 61;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(943, 672);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageLogistica,
            this.xtraTabPageFinanzas,
            this.xtraTabPageDocumentoElectronico,
            this.xtraTabPageAnexos});
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.lbMensajeC);
            this.xtraTabPageGeneral.Controls.Add(this.lbFact);
            this.xtraTabPageGeneral.Controls.Add(this.lbCredito);
            this.xtraTabPageGeneral.Controls.Add(this.txtFactVencidas);
            this.xtraTabPageGeneral.Controls.Add(this.txtCreditoDisponible);
            this.xtraTabPageGeneral.Controls.Add(this.btnStat);
            this.xtraTabPageGeneral.Controls.Add(this.labelControl2);
            this.xtraTabPageGeneral.Controls.Add(this.btnCargaArticulos);
            this.xtraTabPageGeneral.Controls.Add(this.btnDescuentosEspeciales);
            this.xtraTabPageGeneral.Controls.Add(this.txtArticulo);
            this.xtraTabPageGeneral.Controls.Add(this.txtFechaVigencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaVigencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblEnviado);
            this.xtraTabPageGeneral.Controls.Add(this.lblAlmacenDestino);
            this.xtraTabPageGeneral.Controls.Add(this.lblAlmacenOrigen);
            this.xtraTabPageGeneral.Controls.Add(this.lblClase);
            this.xtraTabPageGeneral.Controls.Add(this.cbAlmacenDestino);
            this.xtraTabPageGeneral.Controls.Add(this.cbAlmacenOrigen);
            this.xtraTabPageGeneral.Controls.Add(this.lblUtilidad);
            this.xtraTabPageGeneral.Controls.Add(this.deFechaVencimiento);
            this.xtraTabPageGeneral.Controls.Add(this.deFechaContabilizacion);
            this.xtraTabPageGeneral.Controls.Add(this.txtNumeroDocumentoExterno);
            this.xtraTabPageGeneral.Controls.Add(this.lblArticulos);
            this.xtraTabPageGeneral.Controls.Add(this.lblPartidas);
            this.xtraTabPageGeneral.Controls.Add(this.lblReferencia);
            this.xtraTabPageGeneral.Controls.Add(this.txtReferencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblCodigoSN);
            this.xtraTabPageGeneral.Controls.Add(this.lblID);
            this.xtraTabPageGeneral.Controls.Add(this.lblImpreso);
            this.xtraTabPageGeneral.Controls.Add(this.lblCancelado);
            this.xtraTabPageGeneral.Controls.Add(this.txtTipoCambio);
            this.xtraTabPageGeneral.Controls.Add(this.separatorControl1);
            this.xtraTabPageGeneral.Controls.Add(this.cbMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.lblMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.txtFechaCreacion);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaCreacion);
            this.xtraTabPageGeneral.Controls.Add(this.cbSeries);
            this.xtraTabPageGeneral.Controls.Add(this.lblNumeroDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.txtNumeroDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.txtFechaDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaVencimiento);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaContabilizacion);
            this.xtraTabPageGeneral.Controls.Add(this.txtComentario);
            this.xtraTabPageGeneral.Controls.Add(this.lblComentario);
            this.xtraTabPageGeneral.Controls.Add(this.cbVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.lblVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.lblImporteAplicado);
            this.xtraTabPageGeneral.Controls.Add(this.txtImporteAplicado);
            this.xtraTabPageGeneral.Controls.Add(this.lblTotal);
            this.xtraTabPageGeneral.Controls.Add(this.txtTotal);
            this.xtraTabPageGeneral.Controls.Add(this.lblImpuesto);
            this.xtraTabPageGeneral.Controls.Add(this.txtImpuesto);
            this.xtraTabPageGeneral.Controls.Add(this.lblSubTotal);
            this.xtraTabPageGeneral.Controls.Add(this.txtSubTotal);
            this.xtraTabPageGeneral.Controls.Add(this.txtCodigoSN);
            this.xtraTabPageGeneral.Controls.Add(this.lblSocio);
            this.xtraTabPageGeneral.Controls.Add(this.gcPartidas);
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // lbMensajeC
            // 
            this.lbMensajeC.Appearance.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeC.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMensajeC.Appearance.Options.UseFont = true;
            this.lbMensajeC.Appearance.Options.UseForeColor = true;
            this.lbMensajeC.Location = new System.Drawing.Point(42, 244);
            this.lbMensajeC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbMensajeC.Name = "lbMensajeC";
            this.lbMensajeC.Size = new System.Drawing.Size(492, 18);
            this.lbMensajeC.TabIndex = 174;
            this.lbMensajeC.Text = "La Venta debera ser de Contado tiene Facturas pendientes por Pagar";
            this.lbMensajeC.Visible = false;
            // 
            // lbFact
            // 
            this.lbFact.Location = new System.Drawing.Point(18, 221);
            this.lbFact.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbFact.Name = "lbFact";
            this.lbFact.Size = new System.Drawing.Size(109, 17);
            this.lbFact.TabIndex = 173;
            this.lbFact.Text = "Facturas Vencidas";
            this.lbFact.Visible = false;
            // 
            // lbCredito
            // 
            this.lbCredito.Location = new System.Drawing.Point(18, 187);
            this.lbCredito.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbCredito.Name = "lbCredito";
            this.lbCredito.Size = new System.Drawing.Size(111, 17);
            this.lbCredito.TabIndex = 172;
            this.lbCredito.Text = "Credito Disponible";
            this.lbCredito.Visible = false;
            // 
            // txtFactVencidas
            // 
            this.txtFactVencidas.Enabled = false;
            this.txtFactVencidas.Location = new System.Drawing.Point(149, 214);
            this.txtFactVencidas.MenuManager = this.mainRibbonControl;
            this.txtFactVencidas.Name = "txtFactVencidas";
            this.txtFactVencidas.Size = new System.Drawing.Size(223, 24);
            this.txtFactVencidas.TabIndex = 171;
            this.txtFactVencidas.Visible = false;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRecargar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.bbiImprimir,
            this.bbiNuevoSocio,
            this.bbiCopiar,
            this.barButtonItemMapaRelaciones,
            this.bbiPDF,
            this.bbiEnviar,
            this.bbiCancelar,
            this.bbiCerrar,
            this.bbiPagar,
            this.bbiXLSX,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.barHeaderItem3,
            this.bbiAjustarColumnas,
            this.bbiDuplicar,
            this.bbiCancelacionManualCFDI,
            this.bbiParametrizaciones,
            this.bbiAbrir});
            this.mainRibbonControl.Location = new System.Drawing.Point(2, 2);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mainRibbonControl.MaxItemId = 25;
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
            // bbiRecargar
            // 
            this.bbiRecargar.Caption = "Recargar";
            this.bbiRecargar.Id = 1;
            this.bbiRecargar.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRecargar.Name = "bbiRecargar";
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
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "AddItem";
            this.bbiNuevo.Name = "bbiNuevo";
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 4;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // bbiNuevoSocio
            // 
            this.bbiNuevoSocio.Caption = "Nuevo socio";
            this.bbiNuevoSocio.Id = 5;
            this.bbiNuevoSocio.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevoSocio.Name = "bbiNuevoSocio";
            // 
            // bbiCopiar
            // 
            this.bbiCopiar.Caption = "Copiar";
            this.bbiCopiar.Id = 7;
            this.bbiCopiar.ImageOptions.ImageUri.Uri = "Replace";
            this.bbiCopiar.Name = "bbiCopiar";
            // 
            // barButtonItemMapaRelaciones
            // 
            this.barButtonItemMapaRelaciones.Caption = "Mapa de relaciones";
            this.barButtonItemMapaRelaciones.Id = 8;
            this.barButtonItemMapaRelaciones.ImageOptions.ImageUri.Uri = "SendToBack";
            this.barButtonItemMapaRelaciones.Name = "barButtonItemMapaRelaciones";
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 10;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.Name = "bbiPDF";
            // 
            // bbiEnviar
            // 
            this.bbiEnviar.Caption = "Enviar";
            this.bbiEnviar.Id = 11;
            this.bbiEnviar.ImageOptions.ImageUri.Uri = "Mail";
            this.bbiEnviar.Name = "bbiEnviar";
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 12;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiCerrar
            // 
            this.bbiCerrar.Caption = "Cerrar";
            this.bbiCerrar.Id = 13;
            this.bbiCerrar.ImageOptions.ImageUri.Uri = "Close";
            this.bbiCerrar.Name = "bbiCerrar";
            this.bbiCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPagar
            // 
            this.bbiPagar.Caption = "Pagar";
            this.bbiPagar.Id = 14;
            this.bbiPagar.ImageOptions.ImageUri.Uri = "Currency";
            this.bbiPagar.Name = "bbiPagar";
            // 
            // bbiXLSX
            // 
            this.bbiXLSX.Caption = "XLSX";
            this.bbiXLSX.Id = 15;
            this.bbiXLSX.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.bbiXLSX.Name = "bbiXLSX";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Exportar";
            this.barHeaderItem1.Id = 16;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "Acciones";
            this.barHeaderItem2.Id = 17;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "Más";
            this.barHeaderItem3.Id = 18;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // bbiAjustarColumnas
            // 
            this.bbiAjustarColumnas.Caption = "Ajustar columnas";
            this.bbiAjustarColumnas.Id = 19;
            this.bbiAjustarColumnas.ImageOptions.ImageUri.Uri = "SnapToCells";
            this.bbiAjustarColumnas.Name = "bbiAjustarColumnas";
            // 
            // bbiDuplicar
            // 
            this.bbiDuplicar.Caption = "Duplicar";
            this.bbiDuplicar.Id = 20;
            this.bbiDuplicar.ImageOptions.ImageUri.Uri = "Redo";
            this.bbiDuplicar.Name = "bbiDuplicar";
            // 
            // bbiCancelacionManualCFDI
            // 
            this.bbiCancelacionManualCFDI.Caption = "Cancelación manual CFDI";
            this.bbiCancelacionManualCFDI.Id = 21;
            this.bbiCancelacionManualCFDI.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelacionManualCFDI.Name = "bbiCancelacionManualCFDI";
            // 
            // bbiParametrizaciones
            // 
            this.bbiParametrizaciones.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizaciones.Id = 22;
            this.bbiParametrizaciones.Name = "bbiParametrizaciones";
            // 
            // bbiAbrir
            // 
            this.bbiAbrir.Caption = "Abrir";
            this.bbiAbrir.Id = 23;
            this.bbiAbrir.Name = "bbiAbrir";
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiPagar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiPDF);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiImprimir);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiCopiar);
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
            this.ribbonPageGroupHerramientas});
            this.ribbonPageHerramientas.Name = "ribbonPageHerramientas";
            this.ribbonPageHerramientas.Text = "HERRAMIENTAS";
            // 
            // ribbonPageGroupHerramientas
            // 
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiNuevoSocio);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.barButtonItemMapaRelaciones);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiAjustarColumnas);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiParametrizaciones);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // txtCreditoDisponible
            // 
            this.txtCreditoDisponible.Enabled = false;
            this.txtCreditoDisponible.Location = new System.Drawing.Point(150, 184);
            this.txtCreditoDisponible.MenuManager = this.mainRibbonControl;
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtCreditoDisponible.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(222, 24);
            this.txtCreditoDisponible.TabIndex = 170;
            this.txtCreditoDisponible.Visible = false;
            // 
            // btnStat
            // 
            this.btnStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStat.Location = new System.Drawing.Point(896, 8);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(28, 29);
            this.btnStat.TabIndex = 169;
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(609, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(162, 17);
            this.labelControl2.TabIndex = 168;
            this.labelControl2.Text = "N° de Documento en SAP";
            // 
            // btnCargaArticulos
            // 
            this.btnCargaArticulos.Location = new System.Drawing.Point(382, 201);
            this.btnCargaArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargaArticulos.Name = "btnCargaArticulos";
            this.btnCargaArticulos.Size = new System.Drawing.Size(236, 31);
            this.btnCargaArticulos.TabIndex = 166;
            this.btnCargaArticulos.Text = "Subir Articulos con Excel";
            // 
            // btnDescuentosEspeciales
            // 
            this.btnDescuentosEspeciales.Location = new System.Drawing.Point(379, 152);
            this.btnDescuentosEspeciales.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuentosEspeciales.Name = "btnDescuentosEspeciales";
            this.btnDescuentosEspeciales.Size = new System.Drawing.Size(239, 31);
            this.btnDescuentosEspeciales.TabIndex = 165;
            this.btnDescuentosEspeciales.Text = "Aplicar descuentos especiales";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticulo.Location = new System.Drawing.Point(16, 285);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(907, 24);
            this.txtArticulo.TabIndex = 1;
            // 
            // txtFechaVigencia
            // 
            this.txtFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaVigencia.Location = new System.Drawing.Point(837, 180);
            this.txtFechaVigencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFechaVigencia.Name = "txtFechaVigencia";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.EditFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.ReadOnly = true;
            this.txtFechaVigencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaVigencia.Size = new System.Drawing.Size(86, 24);
            this.txtFechaVigencia.TabIndex = 164;
            this.txtFechaVigencia.TabStop = false;
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVigencia.Location = new System.Drawing.Point(723, 187);
            this.lblFechaVigencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(90, 17);
            this.lblFechaVigencia.TabIndex = 163;
            this.lblFechaVigencia.Text = "Fecha vigencia";
            // 
            // lblEnviado
            // 
            this.lblEnviado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnviado.AutoSize = true;
            this.lblEnviado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEnviado.ForeColor = System.Drawing.Color.Orange;
            this.lblEnviado.Location = new System.Drawing.Point(526, 24);
            this.lblEnviado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(51, 13);
            this.lblEnviado.TabIndex = 161;
            this.lblEnviado.Text = "Enviado";
            this.lblEnviado.Visible = false;
            // 
            // lblAlmacenDestino
            // 
            this.lblAlmacenDestino.Location = new System.Drawing.Point(486, 85);
            this.lblAlmacenDestino.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblAlmacenDestino.Name = "lblAlmacenDestino";
            this.lblAlmacenDestino.Size = new System.Drawing.Size(102, 17);
            this.lblAlmacenDestino.TabIndex = 160;
            this.lblAlmacenDestino.Text = "Almacén destino";
            // 
            // lblAlmacenOrigen
            // 
            this.lblAlmacenOrigen.Location = new System.Drawing.Point(490, 54);
            this.lblAlmacenOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblAlmacenOrigen.Name = "lblAlmacenOrigen";
            this.lblAlmacenOrigen.Size = new System.Drawing.Size(98, 17);
            this.lblAlmacenOrigen.TabIndex = 159;
            this.lblAlmacenOrigen.Text = "Almacén origen";
            // 
            // lblClase
            // 
            this.lblClase.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Appearance.Options.UseFont = true;
            this.lblClase.Location = new System.Drawing.Point(326, 14);
            this.lblClase.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(51, 23);
            this.lblClase.TabIndex = 158;
            this.lblClase.Text = "Clase";
            // 
            // cbAlmacenDestino
            // 
            this.cbAlmacenDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenDestino.Location = new System.Drawing.Point(598, 81);
            this.cbAlmacenDestino.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAlmacenDestino.MenuManager = this.mainRibbonControl;
            this.cbAlmacenDestino.Name = "cbAlmacenDestino";
            this.cbAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenDestino.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenDestino.Properties.NullText = "[Almacén destino]";
            this.cbAlmacenDestino.Size = new System.Drawing.Size(49, 24);
            this.cbAlmacenDestino.TabIndex = 157;
            this.cbAlmacenDestino.Visible = false;
            // 
            // cbAlmacenOrigen
            // 
            this.cbAlmacenOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenOrigen.Location = new System.Drawing.Point(598, 51);
            this.cbAlmacenOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAlmacenOrigen.MenuManager = this.mainRibbonControl;
            this.cbAlmacenOrigen.Name = "cbAlmacenOrigen";
            this.cbAlmacenOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenOrigen.Properties.NullText = "[Almacén origen]";
            this.cbAlmacenOrigen.Size = new System.Drawing.Size(49, 24);
            this.cbAlmacenOrigen.TabIndex = 156;
            this.cbAlmacenOrigen.Visible = false;
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUtilidad.Location = new System.Drawing.Point(426, 554);
            this.lblUtilidad.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(48, 17);
            this.lblUtilidad.TabIndex = 154;
            this.lblUtilidad.Text = "Utilidad";
            // 
            // deFechaVencimiento
            // 
            this.deFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaVencimiento.EditValue = null;
            this.deFechaVencimiento.Location = new System.Drawing.Point(837, 116);
            this.deFechaVencimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deFechaVencimiento.MenuManager = this.mainRibbonControl;
            this.deFechaVencimiento.Name = "deFechaVencimiento";
            this.deFechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Size = new System.Drawing.Size(87, 24);
            this.deFechaVencimiento.TabIndex = 153;
            // 
            // deFechaContabilizacion
            // 
            this.deFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaContabilizacion.EditValue = null;
            this.deFechaContabilizacion.Location = new System.Drawing.Point(837, 81);
            this.deFechaContabilizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deFechaContabilizacion.MenuManager = this.mainRibbonControl;
            this.deFechaContabilizacion.Name = "deFechaContabilizacion";
            this.deFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Size = new System.Drawing.Size(86, 24);
            this.deFechaContabilizacion.TabIndex = 150;
            // 
            // txtNumeroDocumentoExterno
            // 
            this.txtNumeroDocumentoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumentoExterno.Enabled = false;
            this.txtNumeroDocumentoExterno.Location = new System.Drawing.Point(782, 12);
            this.txtNumeroDocumentoExterno.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNumeroDocumentoExterno.Name = "txtNumeroDocumentoExterno";
            this.txtNumeroDocumentoExterno.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumentoExterno.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumeroDocumentoExterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumentoExterno.Size = new System.Drawing.Size(106, 24);
            this.txtNumeroDocumentoExterno.TabIndex = 124;
            this.txtNumeroDocumentoExterno.TabStop = false;
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArticulos.Location = new System.Drawing.Point(426, 577);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(65, 17);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Artículos 0";
            // 
            // lblPartidas
            // 
            this.lblPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPartidas.Location = new System.Drawing.Point(426, 600);
            this.lblPartidas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(63, 17);
            this.lblPartidas.TabIndex = 0;
            this.lblPartidas.Text = "Partidas 0";
            // 
            // lblReferencia
            // 
            this.lblReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReferencia.Location = new System.Drawing.Point(15, 495);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(64, 17);
            this.lblReferencia.TabIndex = 121;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReferencia.Location = new System.Drawing.Point(150, 492);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.MaxLength = 100;
            this.txtReferencia.Size = new System.Drawing.Size(264, 24);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.TabStop = false;
            // 
            // lblCodigoSN
            // 
            this.lblCodigoSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoSN.Location = new System.Drawing.Point(15, 20);
            this.lblCodigoSN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCodigoSN.Name = "lblCodigoSN";
            this.lblCodigoSN.Size = new System.Drawing.Size(66, 17);
            this.lblCodigoSN.TabIndex = 118;
            this.lblCodigoSN.Text = "Código SN";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(271, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 117;
            this.lblID.Text = "0";
            // 
            // lblImpreso
            // 
            this.lblImpreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpreso.AutoSize = true;
            this.lblImpreso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImpreso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblImpreso.Location = new System.Drawing.Point(446, 23);
            this.lblImpreso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblImpreso.Name = "lblImpreso";
            this.lblImpreso.Size = new System.Drawing.Size(55, 13);
            this.lblImpreso.TabIndex = 116;
            this.lblImpreso.Text = "Impreso";
            this.lblImpreso.Visible = false;
            // 
            // lblCancelado
            // 
            this.lblCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelado.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCancelado.Location = new System.Drawing.Point(352, 23);
            this.lblCancelado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(65, 13);
            this.lblCancelado.TabIndex = 115;
            this.lblCancelado.Text = "Cancelado";
            this.lblCancelado.Visible = false;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(379, 119);
            this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(128, 24);
            this.txtTipoCambio.TabIndex = 0;
            this.txtTipoCambio.TabStop = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(18, 263);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(11);
            this.separatorControl1.Size = new System.Drawing.Size(906, 25);
            this.separatorControl1.TabIndex = 112;
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(150, 119);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(223, 24);
            this.cbMonedas.TabIndex = 0;
            this.cbMonedas.TabStop = false;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(15, 120);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 111;
            this.lblMonedas.Text = "Moneda";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(151, 85);
            this.txtFechaCreacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.EditFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(113, 24);
            this.txtFechaCreacion.TabIndex = 106;
            this.txtFechaCreacion.TabStop = false;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.Location = new System.Drawing.Point(15, 88);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(92, 17);
            this.lblFechaCreacion.TabIndex = 105;
            this.lblFechaCreacion.Text = "Fecha creación";
            // 
            // cbSeries
            // 
            this.cbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeries.Location = new System.Drawing.Point(709, 47);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSeries.MenuManager = this.mainRibbonControl;
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSeries.Size = new System.Drawing.Size(104, 24);
            this.cbSeries.TabIndex = 0;
            this.cbSeries.TabStop = false;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(681, 54);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDocumento.TabIndex = 103;
            this.lblNumeroDocumento.Text = "N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(837, 47);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(86, 24);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.TabStop = false;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDocumento.Location = new System.Drawing.Point(837, 148);
            this.txtFechaDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.EditFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.ReadOnly = true;
            this.txtFechaDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaDocumento.Size = new System.Drawing.Size(87, 24);
            this.txtFechaDocumento.TabIndex = 99;
            this.txtFechaDocumento.TabStop = false;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDocumento.Location = new System.Drawing.Point(701, 164);
            this.lblFechaDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(112, 17);
            this.lblFechaDocumento.TabIndex = 93;
            this.lblFechaDocumento.Text = "Fecha documento";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(698, 126);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 17);
            this.lblFechaVencimiento.TabIndex = 91;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(681, 85);
            this.lblFechaContabilizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(132, 17);
            this.lblFechaContabilizacion.TabIndex = 89;
            this.lblFechaContabilizacion.Text = "Fecha contabilización";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentario.Location = new System.Drawing.Point(150, 526);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(264, 93);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.Location = new System.Drawing.Point(15, 529);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(74, 17);
            this.lblComentario.TabIndex = 84;
            this.lblComentario.Text = "Comentario";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVendedores.Location = new System.Drawing.Point(150, 458);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(264, 24);
            this.cbVendedores.TabIndex = 0;
            this.cbVendedores.TabStop = false;
            // 
            // lblVendedores
            // 
            this.lblVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedores.Location = new System.Drawing.Point(15, 461);
            this.lblVendedores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(60, 17);
            this.lblVendedores.TabIndex = 82;
            this.lblVendedores.Text = "Vendedor";
            // 
            // lblImporteAplicado
            // 
            this.lblImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteAplicado.Location = new System.Drawing.Point(603, 559);
            this.lblImporteAplicado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblImporteAplicado.Name = "lblImporteAplicado";
            this.lblImporteAplicado.Size = new System.Drawing.Size(105, 17);
            this.lblImporteAplicado.TabIndex = 80;
            this.lblImporteAplicado.Text = "Importe aplicado";
            // 
            // txtImporteAplicado
            // 
            this.txtImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteAplicado.Location = new System.Drawing.Point(742, 552);
            this.txtImporteAplicado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtImporteAplicado.MenuManager = this.mainRibbonControl;
            this.txtImporteAplicado.Name = "txtImporteAplicado";
            this.txtImporteAplicado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImporteAplicado.Properties.DisplayFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.EditFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.ReadOnly = true;
            this.txtImporteAplicado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImporteAplicado.Size = new System.Drawing.Size(181, 24);
            this.txtImporteAplicado.TabIndex = 0;
            this.txtImporteAplicado.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(603, 527);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 17);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = "Total del documento";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(742, 526);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTotal.MenuManager = this.mainRibbonControl;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.EditFormat.FormatString = "c2";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(181, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpuesto.Location = new System.Drawing.Point(605, 484);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(56, 17);
            this.lblImpuesto.TabIndex = 74;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.Location = new System.Drawing.Point(742, 485);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtImpuesto.MenuManager = this.mainRibbonControl;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImpuesto.Properties.DisplayFormat.FormatString = "c2";
            this.txtImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.EditFormat.FormatString = "c2";
            this.txtImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.ReadOnly = true;
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(181, 24);
            this.txtImpuesto.TabIndex = 0;
            this.txtImpuesto.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.Location = new System.Drawing.Point(605, 461);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(55, 17);
            this.lblSubTotal.TabIndex = 72;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Location = new System.Drawing.Point(742, 455);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSubTotal.MenuManager = this.mainRibbonControl;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSubTotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubTotal.Properties.EditFormat.FormatString = "c2";
            this.txtSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubTotal.Properties.MaskSettings.Set("mask", "c2");
            this.txtSubTotal.Properties.ReadOnly = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(181, 24);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TabStop = false;
            // 
            // txtCodigoSN
            // 
            this.txtCodigoSN.Location = new System.Drawing.Point(151, 17);
            this.txtCodigoSN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoSN.Name = "txtCodigoSN";
            this.txtCodigoSN.Size = new System.Drawing.Size(112, 24);
            this.txtCodigoSN.TabIndex = 0;
            // 
            // lblSocio
            // 
            this.lblSocio.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSocio.Appearance.Options.UseFont = true;
            this.lblSocio.Location = new System.Drawing.Point(15, 54);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(216, 13);
            this.lblSocio.TabIndex = 20;
            this.lblSocio.Text = "Por favor ingrese un socio de negocios";
            // 
            // gcPartidas
            // 
            this.gcPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcPartidas.Location = new System.Drawing.Point(18, 315);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAlmacenes,
            this.cbTiposEmpaques,
            this.cbListasPrecios,
            this.cbUbicaciones,
            this.repositoryItemCalcEdit1,
            this.cbUnidadesMedida,
            this.cbAlmacenesDestino});
            this.gcPartidas.Size = new System.Drawing.Size(908, 122);
            this.gcPartidas.TabIndex = 1;
            this.gcPartidas.TabStop = false;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartidas});
            // 
            // gvPartidas
            // 
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnNo,
            this.gridColumnCantidad,
            this.gridColumnPeso,
            this.gridColumnStock,
            this.gridColumnDiferencia,
            this.gridColumnUnidadMedida,
            this.gridColumnCantidadEmpaque,
            this.gridColumnTipoEmpaque,
            this.gridColumnCantidadPendiente,
            this.gridColumnCantidadPaquete,
            this.gridColumnSKU,
            this.gridColumnArticulo,
            this.gridColumnCodigoBarras,
            this.gridColumnPrecioPieza,
            this.gridColumnListaPrecio,
            this.gridColumnPrecio,
            this.gridColumnImpuesto,
            this.gridColumnPorcentajeDescuento,
            this.gridColumnDescuento,
            this.gridColumnPrecioNeto,
            this.gridColumnSubTotal,
            this.gridColumnTotal,
            this.gridColumnAlmacen,
            this.gridColumnUbicacion,
            this.gridColumnAlmacenDestino,
            this.gridColumnUbicacionDestino,
            this.gridColumnComentario,
            this.gridColumnDescuentoEspecial,
            this.gridColumnNumeroPedimento});
            this.gvPartidas.DetailHeight = 458;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsCustomization.AllowSort = false;
            this.gvPartidas.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvPartidas.OptionsView.ShowGroupPanel = false;
            this.gvPartidas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridColumnNo
            // 
            this.gridColumnNo.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNo.Caption = "#";
            this.gridColumnNo.FieldName = "gridColumnNo";
            this.gridColumnNo.MaxWidth = 40;
            this.gridColumnNo.MinWidth = 26;
            this.gridColumnNo.Name = "gridColumnNo";
            this.gridColumnNo.OptionsColumn.AllowEdit = false;
            this.gridColumnNo.OptionsColumn.ReadOnly = true;
            this.gridColumnNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnNo.Visible = true;
            this.gridColumnNo.VisibleIndex = 0;
            this.gridColumnNo.Width = 26;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnCantidad.AppearanceCell.Options.UseFont = true;
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumnCantidad.DisplayFormat.FormatString = "n3";
            this.gridColumnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MaxWidth = 174;
            this.gridColumnCantidad.MinWidth = 40;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 1;
            this.gridColumnCantidad.Width = 80;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gridColumnPeso
            // 
            this.gridColumnPeso.Caption = "Peso";
            this.gridColumnPeso.DisplayFormat.FormatString = "n2";
            this.gridColumnPeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPeso.FieldName = "peso";
            this.gridColumnPeso.MinWidth = 26;
            this.gridColumnPeso.Name = "gridColumnPeso";
            this.gridColumnPeso.Visible = true;
            this.gridColumnPeso.VisibleIndex = 2;
            this.gridColumnPeso.Width = 29;
            // 
            // gridColumnStock
            // 
            this.gridColumnStock.Caption = "Stock";
            this.gridColumnStock.DisplayFormat.FormatString = "n3";
            this.gridColumnStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnStock.FieldName = "stock";
            this.gridColumnStock.MinWidth = 26;
            this.gridColumnStock.Name = "gridColumnStock";
            this.gridColumnStock.OptionsColumn.AllowEdit = false;
            this.gridColumnStock.Visible = true;
            this.gridColumnStock.VisibleIndex = 3;
            this.gridColumnStock.Width = 26;
            // 
            // gridColumnDiferencia
            // 
            this.gridColumnDiferencia.Caption = "Diferencia";
            this.gridColumnDiferencia.DisplayFormat.FormatString = "n3";
            this.gridColumnDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDiferencia.FieldName = "diferencia";
            this.gridColumnDiferencia.MinWidth = 26;
            this.gridColumnDiferencia.Name = "gridColumnDiferencia";
            this.gridColumnDiferencia.OptionsColumn.AllowEdit = false;
            this.gridColumnDiferencia.Width = 38;
            // 
            // gridColumnUnidadMedida
            // 
            this.gridColumnUnidadMedida.Caption = "UdM";
            this.gridColumnUnidadMedida.ColumnEdit = this.cbUnidadesMedida;
            this.gridColumnUnidadMedida.FieldName = "unidad_medida_id";
            this.gridColumnUnidadMedida.MinWidth = 26;
            this.gridColumnUnidadMedida.Name = "gridColumnUnidadMedida";
            this.gridColumnUnidadMedida.Visible = true;
            this.gridColumnUnidadMedida.VisibleIndex = 4;
            this.gridColumnUnidadMedida.Width = 26;
            // 
            // cbUnidadesMedida
            // 
            this.cbUnidadesMedida.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbUnidadesMedida.AutoHeight = false;
            this.cbUnidadesMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            // 
            // gridColumnCantidadEmpaque
            // 
            this.gridColumnCantidadEmpaque.Caption = "C/E";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatString = "n2";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadEmpaque.FieldName = "cantidad_empaque";
            this.gridColumnCantidadEmpaque.MinWidth = 26;
            this.gridColumnCantidadEmpaque.Name = "gridColumnCantidadEmpaque";
            this.gridColumnCantidadEmpaque.Width = 40;
            // 
            // gridColumnTipoEmpaque
            // 
            this.gridColumnTipoEmpaque.Caption = "Tipo empaque";
            this.gridColumnTipoEmpaque.ColumnEdit = this.cbTiposEmpaques;
            this.gridColumnTipoEmpaque.FieldName = "tipo_empaque_id";
            this.gridColumnTipoEmpaque.MinWidth = 26;
            this.gridColumnTipoEmpaque.Name = "gridColumnTipoEmpaque";
            this.gridColumnTipoEmpaque.Width = 99;
            // 
            // cbTiposEmpaques
            // 
            this.cbTiposEmpaques.AutoHeight = false;
            this.cbTiposEmpaques.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposEmpaques.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTiposEmpaques.Name = "cbTiposEmpaques";
            // 
            // gridColumnCantidadPendiente
            // 
            this.gridColumnCantidadPendiente.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumnCantidadPendiente.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnCantidadPendiente.Caption = "Pendiente";
            this.gridColumnCantidadPendiente.DisplayFormat.FormatString = "n3";
            this.gridColumnCantidadPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadPendiente.FieldName = "cantidad_pendiente";
            this.gridColumnCantidadPendiente.MaxWidth = 174;
            this.gridColumnCantidadPendiente.MinWidth = 40;
            this.gridColumnCantidadPendiente.Name = "gridColumnCantidadPendiente";
            this.gridColumnCantidadPendiente.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPendiente.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidadPendiente.Width = 80;
            // 
            // gridColumnCantidadPaquete
            // 
            this.gridColumnCantidadPaquete.Caption = "Cant/Paq";
            this.gridColumnCantidadPaquete.DisplayFormat.FormatString = "n2";
            this.gridColumnCantidadPaquete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadPaquete.FieldName = "cantidad_paquete";
            this.gridColumnCantidadPaquete.MaxWidth = 80;
            this.gridColumnCantidadPaquete.MinWidth = 47;
            this.gridColumnCantidadPaquete.Name = "gridColumnCantidadPaquete";
            this.gridColumnCantidadPaquete.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPaquete.Visible = true;
            this.gridColumnCantidadPaquete.VisibleIndex = 5;
            this.gridColumnCantidadPaquete.Width = 47;
            // 
            // gridColumnSKU
            // 
            this.gridColumnSKU.Caption = "SKU";
            this.gridColumnSKU.FieldName = "sku";
            this.gridColumnSKU.MaxWidth = 134;
            this.gridColumnSKU.MinWidth = 26;
            this.gridColumnSKU.Name = "gridColumnSKU";
            this.gridColumnSKU.OptionsColumn.AllowEdit = false;
            this.gridColumnSKU.Visible = true;
            this.gridColumnSKU.VisibleIndex = 6;
            this.gridColumnSKU.Width = 26;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.FieldName = "nombre";
            this.gridColumnArticulo.MinWidth = 134;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 7;
            this.gridColumnArticulo.Width = 138;
            // 
            // gridColumnCodigoBarras
            // 
            this.gridColumnCodigoBarras.Caption = "Código de barras";
            this.gridColumnCodigoBarras.FieldName = "codigo_barras";
            this.gridColumnCodigoBarras.MaxWidth = 113;
            this.gridColumnCodigoBarras.MinWidth = 66;
            this.gridColumnCodigoBarras.Name = "gridColumnCodigoBarras";
            this.gridColumnCodigoBarras.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigoBarras.Visible = true;
            this.gridColumnCodigoBarras.VisibleIndex = 8;
            this.gridColumnCodigoBarras.Width = 70;
            // 
            // gridColumnPrecioPieza
            // 
            this.gridColumnPrecioPieza.Caption = "P/Pza";
            this.gridColumnPrecioPieza.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecioPieza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecioPieza.FieldName = "gridColumnPrecioPieza";
            this.gridColumnPrecioPieza.MaxWidth = 160;
            this.gridColumnPrecioPieza.MinWidth = 26;
            this.gridColumnPrecioPieza.Name = "gridColumnPrecioPieza";
            this.gridColumnPrecioPieza.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecioPieza.UnboundExpression = "(precio_pieza * tipo_cambio)  + (impuesto / cantidad_paquete)";
            this.gridColumnPrecioPieza.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecioPieza.Visible = true;
            this.gridColumnPrecioPieza.VisibleIndex = 9;
            this.gridColumnPrecioPieza.Width = 26;
            // 
            // gridColumnListaPrecio
            // 
            this.gridColumnListaPrecio.Caption = "Lista de precio";
            this.gridColumnListaPrecio.ColumnEdit = this.cbListasPrecios;
            this.gridColumnListaPrecio.FieldName = "lista_precio_id";
            this.gridColumnListaPrecio.MaxWidth = 80;
            this.gridColumnListaPrecio.MinWidth = 26;
            this.gridColumnListaPrecio.Name = "gridColumnListaPrecio";
            this.gridColumnListaPrecio.Visible = true;
            this.gridColumnListaPrecio.VisibleIndex = 10;
            this.gridColumnListaPrecio.Width = 34;
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.AutoHeight = false;
            this.cbListasPrecios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Name = "cbListasPrecios";
            // 
            // gridColumnPrecio
            // 
            this.gridColumnPrecio.Caption = "Precio";
            this.gridColumnPrecio.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumnPrecio.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecio.FieldName = "gridColumnPrecio";
            this.gridColumnPrecio.MaxWidth = 160;
            this.gridColumnPrecio.MinWidth = 26;
            this.gridColumnPrecio.Name = "gridColumnPrecio";
            this.gridColumnPrecio.UnboundExpression = "precio * tipo_cambio";
            this.gridColumnPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecio.Visible = true;
            this.gridColumnPrecio.VisibleIndex = 11;
            this.gridColumnPrecio.Width = 27;
            // 
            // gridColumnImpuesto
            // 
            this.gridColumnImpuesto.Caption = "Impuesto";
            this.gridColumnImpuesto.DisplayFormat.FormatString = "C";
            this.gridColumnImpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImpuesto.FieldName = "impuesto";
            this.gridColumnImpuesto.MinWidth = 26;
            this.gridColumnImpuesto.Name = "gridColumnImpuesto";
            this.gridColumnImpuesto.OptionsColumn.AllowEdit = false;
            this.gridColumnImpuesto.Visible = true;
            this.gridColumnImpuesto.VisibleIndex = 12;
            this.gridColumnImpuesto.Width = 26;
            // 
            // gridColumnPorcentajeDescuento
            // 
            this.gridColumnPorcentajeDescuento.Caption = "% Dscto";
            this.gridColumnPorcentajeDescuento.DisplayFormat.FormatString = "0.##";
            this.gridColumnPorcentajeDescuento.FieldName = "porcentaje_descuento";
            this.gridColumnPorcentajeDescuento.MaxWidth = 66;
            this.gridColumnPorcentajeDescuento.MinWidth = 26;
            this.gridColumnPorcentajeDescuento.Name = "gridColumnPorcentajeDescuento";
            this.gridColumnPorcentajeDescuento.OptionsColumn.FixedWidth = true;
            this.gridColumnPorcentajeDescuento.Visible = true;
            this.gridColumnPorcentajeDescuento.VisibleIndex = 13;
            this.gridColumnPorcentajeDescuento.Width = 66;
            // 
            // gridColumnDescuento
            // 
            this.gridColumnDescuento.Caption = "Descuento";
            this.gridColumnDescuento.DisplayFormat.FormatString = "C";
            this.gridColumnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDescuento.FieldName = "descuento";
            this.gridColumnDescuento.MaxWidth = 160;
            this.gridColumnDescuento.MinWidth = 26;
            this.gridColumnDescuento.Name = "gridColumnDescuento";
            this.gridColumnDescuento.OptionsColumn.AllowEdit = false;
            this.gridColumnDescuento.Visible = true;
            this.gridColumnDescuento.VisibleIndex = 14;
            this.gridColumnDescuento.Width = 26;
            // 
            // gridColumnPrecioNeto
            // 
            this.gridColumnPrecioNeto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnPrecioNeto.AppearanceCell.Options.UseFont = true;
            this.gridColumnPrecioNeto.Caption = "P. Neto";
            this.gridColumnPrecioNeto.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecioNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecioNeto.FieldName = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.MaxWidth = 160;
            this.gridColumnPrecioNeto.MinWidth = 26;
            this.gridColumnPrecioNeto.Name = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecioNeto.UnboundExpression = "((precio * tipo_cambio) + impuesto) - descuento";
            this.gridColumnPrecioNeto.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecioNeto.Visible = true;
            this.gridColumnPrecioNeto.VisibleIndex = 15;
            this.gridColumnPrecioNeto.Width = 26;
            // 
            // gridColumnSubTotal
            // 
            this.gridColumnSubTotal.Caption = "SubTotal";
            this.gridColumnSubTotal.DisplayFormat.FormatString = "C";
            this.gridColumnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSubTotal.FieldName = "subtotal";
            this.gridColumnSubTotal.MaxWidth = 134;
            this.gridColumnSubTotal.MinWidth = 26;
            this.gridColumnSubTotal.Name = "gridColumnSubTotal";
            this.gridColumnSubTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnSubTotal.Visible = true;
            this.gridColumnSubTotal.VisibleIndex = 16;
            this.gridColumnSubTotal.Width = 27;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnTotal.AppearanceCell.Options.UseFont = true;
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatString = "c2";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "total";
            this.gridColumnTotal.MinWidth = 59;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 17;
            this.gridColumnTotal.Width = 63;
            // 
            // gridColumnAlmacen
            // 
            this.gridColumnAlmacen.Caption = "Almacén";
            this.gridColumnAlmacen.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacen.FieldName = "almacen_id";
            this.gridColumnAlmacen.MinWidth = 26;
            this.gridColumnAlmacen.Name = "gridColumnAlmacen";
            this.gridColumnAlmacen.Visible = true;
            this.gridColumnAlmacen.VisibleIndex = 18;
            this.gridColumnAlmacen.Width = 27;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.AutoHeight = false;
            this.cbAlmacenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Name = "cbAlmacenes";
            // 
            // gridColumnUbicacion
            // 
            this.gridColumnUbicacion.Caption = "Ubicación";
            this.gridColumnUbicacion.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacion.FieldName = "ubicacion_id";
            this.gridColumnUbicacion.MinWidth = 26;
            this.gridColumnUbicacion.Name = "gridColumnUbicacion";
            this.gridColumnUbicacion.Visible = true;
            this.gridColumnUbicacion.VisibleIndex = 19;
            this.gridColumnUbicacion.Width = 54;
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.AutoHeight = false;
            this.cbUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUbicaciones.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ubicacion", "Ubicación", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUbicaciones.Name = "cbUbicaciones";
            // 
            // gridColumnAlmacenDestino
            // 
            this.gridColumnAlmacenDestino.Caption = "Almacén destino";
            this.gridColumnAlmacenDestino.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacenDestino.FieldName = "almacen_destino_id";
            this.gridColumnAlmacenDestino.MinWidth = 26;
            this.gridColumnAlmacenDestino.Name = "gridColumnAlmacenDestino";
            this.gridColumnAlmacenDestino.Visible = true;
            this.gridColumnAlmacenDestino.VisibleIndex = 20;
            this.gridColumnAlmacenDestino.Width = 44;
            // 
            // gridColumnUbicacionDestino
            // 
            this.gridColumnUbicacionDestino.Caption = "Ubicación destino";
            this.gridColumnUbicacionDestino.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacionDestino.FieldName = "ubicacion_destino_id";
            this.gridColumnUbicacionDestino.MinWidth = 26;
            this.gridColumnUbicacionDestino.Name = "gridColumnUbicacionDestino";
            this.gridColumnUbicacionDestino.Visible = true;
            this.gridColumnUbicacionDestino.VisibleIndex = 21;
            this.gridColumnUbicacionDestino.Width = 44;
            // 
            // gridColumnComentario
            // 
            this.gridColumnComentario.Caption = "Comentario";
            this.gridColumnComentario.FieldName = "comentario";
            this.gridColumnComentario.MinWidth = 26;
            this.gridColumnComentario.Name = "gridColumnComentario";
            this.gridColumnComentario.Visible = true;
            this.gridColumnComentario.VisibleIndex = 22;
            this.gridColumnComentario.Width = 35;
            // 
            // gridColumnDescuentoEspecial
            // 
            this.gridColumnDescuentoEspecial.Caption = "DE";
            this.gridColumnDescuentoEspecial.FieldName = "descuento_especial_id";
            this.gridColumnDescuentoEspecial.MaxWidth = 26;
            this.gridColumnDescuentoEspecial.MinWidth = 17;
            this.gridColumnDescuentoEspecial.Name = "gridColumnDescuentoEspecial";
            this.gridColumnDescuentoEspecial.Visible = true;
            this.gridColumnDescuentoEspecial.VisibleIndex = 23;
            this.gridColumnDescuentoEspecial.Width = 26;
            // 
            // gridColumnNumeroPedimento
            // 
            this.gridColumnNumeroPedimento.Caption = "N° Pedimento";
            this.gridColumnNumeroPedimento.FieldName = "numero_pedimento";
            this.gridColumnNumeroPedimento.MaxWidth = 113;
            this.gridColumnNumeroPedimento.MinWidth = 26;
            this.gridColumnNumeroPedimento.Name = "gridColumnNumeroPedimento";
            this.gridColumnNumeroPedimento.Width = 113;
            // 
            // cbAlmacenesDestino
            // 
            this.cbAlmacenesDestino.AutoHeight = false;
            this.cbAlmacenesDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenesDestino.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenesDestino.Name = "cbAlmacenesDestino";
            // 
            // xtraTabPageLogistica
            // 
            this.xtraTabPageLogistica.Controls.Add(this.dtHoraLlegada);
            this.xtraTabPageLogistica.Controls.Add(this.dtHoraSalida);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl6);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl5);
            this.xtraTabPageLogistica.Controls.Add(this.dtFechaLlegada);
            this.xtraTabPageLogistica.Controls.Add(this.dtFechaSalida);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl4);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl3);
            this.xtraTabPageLogistica.Controls.Add(this.chckCartaPorte);
            this.xtraTabPageLogistica.Controls.Add(this.btnGenerarCartaPorte);
            this.xtraTabPageLogistica.Controls.Add(this.btnEditarDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.btnAgregarDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.txtDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.cbDireccionesOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.lblDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.btnEditarDireccionFacturacion);
            this.xtraTabPageLogistica.Controls.Add(this.btnEditarDireccionEnvio);
            this.xtraTabPageLogistica.Controls.Add(this.lblDistancia);
            this.xtraTabPageLogistica.Controls.Add(this.txtDistancia);
            this.xtraTabPageLogistica.Controls.Add(this.cbRemolques);
            this.xtraTabPageLogistica.Controls.Add(this.lblRemolque);
            this.xtraTabPageLogistica.Controls.Add(this.bcID);
            this.xtraTabPageLogistica.Controls.Add(this.cbRutas);
            this.xtraTabPageLogistica.Controls.Add(this.lblRuta);
            this.xtraTabPageLogistica.Controls.Add(this.gcSeguimiento);
            this.xtraTabPageLogistica.Controls.Add(this.cbCausalidades);
            this.xtraTabPageLogistica.Controls.Add(this.lblCausalidades);
            this.xtraTabPageLogistica.Controls.Add(this.cbSupervisores);
            this.xtraTabPageLogistica.Controls.Add(this.lblSupervisores);
            this.xtraTabPageLogistica.Controls.Add(this.cbForaneo);
            this.xtraTabPageLogistica.Controls.Add(this.cbVehiculos);
            this.xtraTabPageLogistica.Controls.Add(this.lblVehiculo);
            this.xtraTabPageLogistica.Controls.Add(this.cbChoferes);
            this.xtraTabPageLogistica.Controls.Add(this.lblChofer);
            this.xtraTabPageLogistica.Controls.Add(this.btnSolicitarEtiquetas);
            this.xtraTabPageLogistica.Controls.Add(this.lblActualizacion);
            this.xtraTabPageLogistica.Controls.Add(this.lblSincronizacion);
            this.xtraTabPageLogistica.Controls.Add(this.cbPersonasContacto);
            this.xtraTabPageLogistica.Controls.Add(this.lblPersonasContacto);
            this.xtraTabPageLogistica.Controls.Add(this.cbClasesExpedicion);
            this.xtraTabPageLogistica.Controls.Add(this.lblClaseExpedicion);
            this.xtraTabPageLogistica.Controls.Add(this.lblCreacion);
            this.xtraTabPageLogistica.Controls.Add(this.btnDireccionFacturacion);
            this.xtraTabPageLogistica.Controls.Add(this.btnAgregarDireccionEnvio);
            this.xtraTabPageLogistica.Controls.Add(this.txtDireccionEnvio);
            this.xtraTabPageLogistica.Controls.Add(this.txtDireccionFacturacion);
            this.xtraTabPageLogistica.Controls.Add(this.cbDireccionesEnvio);
            this.xtraTabPageLogistica.Controls.Add(this.lblDireccionEnvio);
            this.xtraTabPageLogistica.Controls.Add(this.cbDireccionesFacturacion);
            this.xtraTabPageLogistica.Controls.Add(this.lblDireccionFacturacion);
            this.xtraTabPageLogistica.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageLogistica.Name = "xtraTabPageLogistica";
            this.xtraTabPageLogistica.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageLogistica.Text = "Logística";
            // 
            // btnEditarDireccionOrigen
            // 
            this.btnEditarDireccionOrigen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionOrigen.Location = new System.Drawing.Point(450, 389);
            this.btnEditarDireccionOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditarDireccionOrigen.Name = "btnEditarDireccionOrigen";
            this.btnEditarDireccionOrigen.Size = new System.Drawing.Size(32, 26);
            this.btnEditarDireccionOrigen.TabIndex = 173;
            this.btnEditarDireccionOrigen.TabStop = false;
            // 
            // btnAgregarDireccionOrigen
            // 
            this.btnAgregarDireccionOrigen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionOrigen.Location = new System.Drawing.Point(450, 354);
            this.btnAgregarDireccionOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarDireccionOrigen.Name = "btnAgregarDireccionOrigen";
            this.btnAgregarDireccionOrigen.Size = new System.Drawing.Size(32, 26);
            this.btnAgregarDireccionOrigen.TabIndex = 169;
            this.btnAgregarDireccionOrigen.TabStop = false;
            // 
            // txtDireccionOrigen
            // 
            this.txtDireccionOrigen.Location = new System.Drawing.Point(151, 388);
            this.txtDireccionOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccionOrigen.MenuManager = this.mainRibbonControl;
            this.txtDireccionOrigen.Name = "txtDireccionOrigen";
            this.txtDireccionOrigen.Properties.ReadOnly = true;
            this.txtDireccionOrigen.Size = new System.Drawing.Size(291, 86);
            this.txtDireccionOrigen.TabIndex = 170;
            this.txtDireccionOrigen.TabStop = false;
            // 
            // cbDireccionesOrigen
            // 
            this.cbDireccionesOrigen.Location = new System.Drawing.Point(151, 354);
            this.cbDireccionesOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbDireccionesOrigen.MenuManager = this.mainRibbonControl;
            this.cbDireccionesOrigen.Name = "cbDireccionesOrigen";
            this.cbDireccionesOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesOrigen.Size = new System.Drawing.Size(291, 24);
            this.cbDireccionesOrigen.TabIndex = 171;
            // 
            // lblDireccionOrigen
            // 
            this.lblDireccionOrigen.Location = new System.Drawing.Point(15, 357);
            this.lblDireccionOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDireccionOrigen.Name = "lblDireccionOrigen";
            this.lblDireccionOrigen.Size = new System.Drawing.Size(99, 17);
            this.lblDireccionOrigen.TabIndex = 172;
            this.lblDireccionOrigen.Text = "Dirección origen";
            // 
            // btnEditarDireccionFacturacion
            // 
            this.btnEditarDireccionFacturacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionFacturacion.Location = new System.Drawing.Point(450, 52);
            this.btnEditarDireccionFacturacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditarDireccionFacturacion.Name = "btnEditarDireccionFacturacion";
            this.btnEditarDireccionFacturacion.Size = new System.Drawing.Size(32, 26);
            this.btnEditarDireccionFacturacion.TabIndex = 168;
            this.btnEditarDireccionFacturacion.TabStop = false;
            // 
            // btnEditarDireccionEnvio
            // 
            this.btnEditarDireccionEnvio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionEnvio.Location = new System.Drawing.Point(450, 220);
            this.btnEditarDireccionEnvio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditarDireccionEnvio.Name = "btnEditarDireccionEnvio";
            this.btnEditarDireccionEnvio.Size = new System.Drawing.Size(32, 26);
            this.btnEditarDireccionEnvio.TabIndex = 167;
            this.btnEditarDireccionEnvio.TabStop = false;
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(17, 485);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(91, 17);
            this.lblDistancia.TabIndex = 166;
            this.lblDistancia.Text = "Distancia (Km)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(151, 482);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Properties.MaxLength = 18;
            this.txtDistancia.Size = new System.Drawing.Size(291, 24);
            this.txtDistancia.TabIndex = 165;
            // 
            // cbRemolques
            // 
            this.cbRemolques.Location = new System.Drawing.Point(678, 179);
            this.cbRemolques.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbRemolques.MenuManager = this.mainRibbonControl;
            this.cbRemolques.Name = "cbRemolques";
            this.cbRemolques.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRemolques.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRemolques.Size = new System.Drawing.Size(230, 24);
            this.cbRemolques.TabIndex = 163;
            // 
            // lblRemolque
            // 
            this.lblRemolque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemolque.Location = new System.Drawing.Point(546, 186);
            this.lblRemolque.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblRemolque.Name = "lblRemolque";
            this.lblRemolque.Size = new System.Drawing.Size(63, 17);
            this.lblRemolque.TabIndex = 164;
            this.lblRemolque.Text = "Remolque";
            // 
            // bcID
            // 
            this.bcID.AutoModule = true;
            this.bcID.Location = new System.Drawing.Point(669, 557);
            this.bcID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bcID.Name = "bcID";
            this.bcID.Padding = new System.Windows.Forms.Padding(14, 2, 14, 0);
            this.bcID.Size = new System.Drawing.Size(239, 59);
            this.bcID.Symbology = code128Generator9;
            this.bcID.TabIndex = 147;
            // 
            // cbRutas
            // 
            this.cbRutas.Location = new System.Drawing.Point(678, 213);
            this.cbRutas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbRutas.MenuManager = this.mainRibbonControl;
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRutas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRutas.Size = new System.Drawing.Size(230, 24);
            this.cbRutas.TabIndex = 145;
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(544, 220);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 17);
            this.lblRuta.TabIndex = 146;
            this.lblRuta.Text = "Ruta";
            // 
            // gcSeguimiento
            // 
            this.gcSeguimiento.Controls.Add(this.cbEstadoSeguimiento);
            this.gcSeguimiento.Controls.Add(this.cbSeguimiento);
            this.gcSeguimiento.Location = new System.Drawing.Point(513, 469);
            this.gcSeguimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gcSeguimiento.Name = "gcSeguimiento";
            this.gcSeguimiento.Size = new System.Drawing.Size(395, 82);
            this.gcSeguimiento.TabIndex = 144;
            this.gcSeguimiento.Text = "Seguimiento";
            // 
            // cbEstadoSeguimiento
            // 
            this.cbEstadoSeguimiento.Location = new System.Drawing.Point(130, 37);
            this.cbEstadoSeguimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbEstadoSeguimiento.MenuManager = this.mainRibbonControl;
            this.cbEstadoSeguimiento.Name = "cbEstadoSeguimiento";
            this.cbEstadoSeguimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstadoSeguimiento.Properties.Items.AddRange(new object[] {
            "Recibido",
            "Pagado",
            "Preparado",
            "Enviado",
            "Entregado",
            "Cancelado"});
            this.cbEstadoSeguimiento.Size = new System.Drawing.Size(258, 24);
            this.cbEstadoSeguimiento.TabIndex = 145;
            // 
            // cbSeguimiento
            // 
            this.cbSeguimiento.Location = new System.Drawing.Point(17, 40);
            this.cbSeguimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSeguimiento.MenuManager = this.mainRibbonControl;
            this.cbSeguimiento.Name = "cbSeguimiento";
            this.cbSeguimiento.Properties.Caption = "Seguimiento";
            this.cbSeguimiento.Size = new System.Drawing.Size(120, 21);
            this.cbSeguimiento.TabIndex = 0;
            // 
            // cbCausalidades
            // 
            this.cbCausalidades.Location = new System.Drawing.Point(678, 303);
            this.cbCausalidades.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCausalidades.MenuManager = this.mainRibbonControl;
            this.cbCausalidades.Name = "cbCausalidades";
            this.cbCausalidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCausalidades.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCausalidades.Size = new System.Drawing.Size(230, 24);
            this.cbCausalidades.TabIndex = 10;
            // 
            // lblCausalidades
            // 
            this.lblCausalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCausalidades.Location = new System.Drawing.Point(542, 310);
            this.lblCausalidades.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCausalidades.Name = "lblCausalidades";
            this.lblCausalidades.Size = new System.Drawing.Size(67, 17);
            this.lblCausalidades.TabIndex = 143;
            this.lblCausalidades.Text = "Causalidad";
            // 
            // cbSupervisores
            // 
            this.cbSupervisores.Location = new System.Drawing.Point(678, 256);
            this.cbSupervisores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSupervisores.MenuManager = this.mainRibbonControl;
            this.cbSupervisores.Name = "cbSupervisores";
            this.cbSupervisores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSupervisores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSupervisores.Size = new System.Drawing.Size(230, 24);
            this.cbSupervisores.TabIndex = 9;
            // 
            // lblSupervisores
            // 
            this.lblSupervisores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupervisores.Location = new System.Drawing.Point(544, 263);
            this.lblSupervisores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSupervisores.Name = "lblSupervisores";
            this.lblSupervisores.Size = new System.Drawing.Size(61, 17);
            this.lblSupervisores.TabIndex = 140;
            this.lblSupervisores.Text = "Supervisor";
            // 
            // cbForaneo
            // 
            this.cbForaneo.Location = new System.Drawing.Point(981, 152);
            this.cbForaneo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbForaneo.MenuManager = this.mainRibbonControl;
            this.cbForaneo.Name = "cbForaneo";
            this.cbForaneo.Properties.Caption = "Foráneo";
            this.cbForaneo.Size = new System.Drawing.Size(80, 21);
            this.cbForaneo.TabIndex = 8;
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.Location = new System.Drawing.Point(678, 145);
            this.cbVehiculos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbVehiculos.MenuManager = this.mainRibbonControl;
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVehiculos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVehiculos.Size = new System.Drawing.Size(230, 24);
            this.cbVehiculos.TabIndex = 6;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVehiculo.Location = new System.Drawing.Point(546, 151);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(52, 17);
            this.lblVehiculo.TabIndex = 135;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // cbChoferes
            // 
            this.cbChoferes.Location = new System.Drawing.Point(678, 111);
            this.cbChoferes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbChoferes.MenuManager = this.mainRibbonControl;
            this.cbChoferes.Name = "cbChoferes";
            this.cbChoferes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChoferes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbChoferes.Size = new System.Drawing.Size(230, 24);
            this.cbChoferes.TabIndex = 5;
            // 
            // lblChofer
            // 
            this.lblChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChofer.Location = new System.Drawing.Point(546, 118);
            this.lblChofer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(41, 17);
            this.lblChofer.TabIndex = 133;
            this.lblChofer.Text = "Chofer";
            // 
            // btnSolicitarEtiquetas
            // 
            this.btnSolicitarEtiquetas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSolicitarEtiquetas.Location = new System.Drawing.Point(785, 345);
            this.btnSolicitarEtiquetas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSolicitarEtiquetas.Name = "btnSolicitarEtiquetas";
            this.btnSolicitarEtiquetas.Size = new System.Drawing.Size(123, 26);
            this.btnSolicitarEtiquetas.TabIndex = 10;
            this.btnSolicitarEtiquetas.Text = "Solicitar etiquetas";
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActualizacion.Location = new System.Drawing.Point(15, 532);
            this.lblActualizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(82, 17);
            this.lblActualizacion.TabIndex = 130;
            this.lblActualizacion.Text = "Actualización";
            // 
            // lblSincronizacion
            // 
            this.lblSincronizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSincronizacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSincronizacion.Location = new System.Drawing.Point(795, 619);
            this.lblSincronizacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSincronizacion.Name = "lblSincronizacion";
            this.lblSincronizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSincronizacion.Size = new System.Drawing.Size(109, 18);
            this.lblSincronizacion.TabIndex = 129;
            this.lblSincronizacion.Text = "Sincronización";
            // 
            // cbPersonasContacto
            // 
            this.cbPersonasContacto.Location = new System.Drawing.Point(151, 513);
            this.cbPersonasContacto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbPersonasContacto.MenuManager = this.mainRibbonControl;
            this.cbPersonasContacto.Name = "cbPersonasContacto";
            this.cbPersonasContacto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPersonasContacto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPersonasContacto.Size = new System.Drawing.Size(291, 24);
            this.cbPersonasContacto.TabIndex = 3;
            // 
            // lblPersonasContacto
            // 
            this.lblPersonasContacto.Location = new System.Drawing.Point(15, 518);
            this.lblPersonasContacto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPersonasContacto.Name = "lblPersonasContacto";
            this.lblPersonasContacto.Size = new System.Drawing.Size(126, 17);
            this.lblPersonasContacto.TabIndex = 128;
            this.lblPersonasContacto.Text = "Persona de contacto";
            // 
            // cbClasesExpedicion
            // 
            this.cbClasesExpedicion.Location = new System.Drawing.Point(678, 78);
            this.cbClasesExpedicion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbClasesExpedicion.MenuManager = this.mainRibbonControl;
            this.cbClasesExpedicion.Name = "cbClasesExpedicion";
            this.cbClasesExpedicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClasesExpedicion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbClasesExpedicion.Size = new System.Drawing.Size(230, 24);
            this.cbClasesExpedicion.TabIndex = 4;
            // 
            // lblClaseExpedicion
            // 
            this.lblClaseExpedicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClaseExpedicion.Location = new System.Drawing.Point(542, 85);
            this.lblClaseExpedicion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblClaseExpedicion.Name = "lblClaseExpedicion";
            this.lblClaseExpedicion.Size = new System.Drawing.Size(100, 17);
            this.lblClaseExpedicion.TabIndex = 126;
            this.lblClaseExpedicion.Text = "Clase expedición";
            // 
            // lblCreacion
            // 
            this.lblCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreacion.Location = new System.Drawing.Point(16, 507);
            this.lblCreacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(54, 17);
            this.lblCreacion.TabIndex = 124;
            this.lblCreacion.Text = "Creación";
            // 
            // btnDireccionFacturacion
            // 
            this.btnDireccionFacturacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDireccionFacturacion.Location = new System.Drawing.Point(450, 17);
            this.btnDireccionFacturacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDireccionFacturacion.Name = "btnDireccionFacturacion";
            this.btnDireccionFacturacion.Size = new System.Drawing.Size(32, 26);
            this.btnDireccionFacturacion.TabIndex = 0;
            this.btnDireccionFacturacion.TabStop = false;
            // 
            // btnAgregarDireccionEnvio
            // 
            this.btnAgregarDireccionEnvio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionEnvio.Location = new System.Drawing.Point(450, 185);
            this.btnAgregarDireccionEnvio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarDireccionEnvio.Name = "btnAgregarDireccionEnvio";
            this.btnAgregarDireccionEnvio.Size = new System.Drawing.Size(32, 26);
            this.btnAgregarDireccionEnvio.TabIndex = 0;
            this.btnAgregarDireccionEnvio.TabStop = false;
            // 
            // txtDireccionEnvio
            // 
            this.txtDireccionEnvio.Location = new System.Drawing.Point(151, 219);
            this.txtDireccionEnvio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccionEnvio.MenuManager = this.mainRibbonControl;
            this.txtDireccionEnvio.Name = "txtDireccionEnvio";
            this.txtDireccionEnvio.Properties.ReadOnly = true;
            this.txtDireccionEnvio.Size = new System.Drawing.Size(291, 126);
            this.txtDireccionEnvio.TabIndex = 0;
            this.txtDireccionEnvio.TabStop = false;
            // 
            // txtDireccionFacturacion
            // 
            this.txtDireccionFacturacion.Location = new System.Drawing.Point(151, 51);
            this.txtDireccionFacturacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccionFacturacion.MenuManager = this.mainRibbonControl;
            this.txtDireccionFacturacion.Name = "txtDireccionFacturacion";
            this.txtDireccionFacturacion.Properties.ReadOnly = true;
            this.txtDireccionFacturacion.Size = new System.Drawing.Size(291, 126);
            this.txtDireccionFacturacion.TabIndex = 0;
            this.txtDireccionFacturacion.TabStop = false;
            // 
            // cbDireccionesEnvio
            // 
            this.cbDireccionesEnvio.Location = new System.Drawing.Point(151, 185);
            this.cbDireccionesEnvio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbDireccionesEnvio.MenuManager = this.mainRibbonControl;
            this.cbDireccionesEnvio.Name = "cbDireccionesEnvio";
            this.cbDireccionesEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesEnvio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesEnvio.Size = new System.Drawing.Size(291, 24);
            this.cbDireccionesEnvio.TabIndex = 1;
            // 
            // lblDireccionEnvio
            // 
            this.lblDireccionEnvio.Location = new System.Drawing.Point(15, 188);
            this.lblDireccionEnvio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDireccionEnvio.Name = "lblDireccionEnvio";
            this.lblDireccionEnvio.Size = new System.Drawing.Size(92, 17);
            this.lblDireccionEnvio.TabIndex = 78;
            this.lblDireccionEnvio.Text = "Dirección envío";
            // 
            // cbDireccionesFacturacion
            // 
            this.cbDireccionesFacturacion.Location = new System.Drawing.Point(151, 17);
            this.cbDireccionesFacturacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbDireccionesFacturacion.MenuManager = this.mainRibbonControl;
            this.cbDireccionesFacturacion.Name = "cbDireccionesFacturacion";
            this.cbDireccionesFacturacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesFacturacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesFacturacion.Size = new System.Drawing.Size(291, 24);
            this.cbDireccionesFacturacion.TabIndex = 0;
            // 
            // lblDireccionFacturacion
            // 
            this.lblDireccionFacturacion.Location = new System.Drawing.Point(15, 20);
            this.lblDireccionFacturacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDireccionFacturacion.Name = "lblDireccionFacturacion";
            this.lblDireccionFacturacion.Size = new System.Drawing.Size(129, 17);
            this.lblDireccionFacturacion.TabIndex = 77;
            this.lblDireccionFacturacion.Text = "Dirección facturación";
            // 
            // xtraTabPageFinanzas
            // 
            this.xtraTabPageFinanzas.Controls.Add(this.cbProyectos);
            this.xtraTabPageFinanzas.Controls.Add(this.lblProyectos);
            this.xtraTabPageFinanzas.Controls.Add(this.cbCanales);
            this.xtraTabPageFinanzas.Controls.Add(this.lblCanal);
            this.xtraTabPageFinanzas.Controls.Add(this.lbReferencias);
            this.xtraTabPageFinanzas.Controls.Add(this.btnReferencias);
            this.xtraTabPageFinanzas.Controls.Add(this.lblOrdenCompra);
            this.xtraTabPageFinanzas.Controls.Add(this.txtOrdenCompra);
            this.xtraTabPageFinanzas.Controls.Add(this.lblCuentaPago);
            this.xtraTabPageFinanzas.Controls.Add(this.txtCuentaPago);
            this.xtraTabPageFinanzas.Controls.Add(this.cbMetodosPago);
            this.xtraTabPageFinanzas.Controls.Add(this.lblMetodosPago);
            this.xtraTabPageFinanzas.Controls.Add(this.cbCondicionesPago);
            this.xtraTabPageFinanzas.Controls.Add(this.lblCondicionesPago);
            this.xtraTabPageFinanzas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageFinanzas.Name = "xtraTabPageFinanzas";
            this.xtraTabPageFinanzas.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageFinanzas.Text = "Finanzas";
            // 
            // cbProyectos
            // 
            this.cbProyectos.Location = new System.Drawing.Point(151, 84);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbProyectos.MenuManager = this.mainRibbonControl;
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProyectos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbProyectos.Size = new System.Drawing.Size(291, 24);
            this.cbProyectos.TabIndex = 146;
            // 
            // lblProyectos
            // 
            this.lblProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProyectos.Location = new System.Drawing.Point(15, 86);
            this.lblProyectos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(55, 17);
            this.lblProyectos.TabIndex = 147;
            this.lblProyectos.Text = "Proyecto";
            // 
            // cbCanales
            // 
            this.cbCanales.Location = new System.Drawing.Point(151, 116);
            this.cbCanales.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCanales.MenuManager = this.mainRibbonControl;
            this.cbCanales.Name = "cbCanales";
            this.cbCanales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCanales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCanales.Size = new System.Drawing.Size(291, 24);
            this.cbCanales.TabIndex = 143;
            // 
            // lblCanal
            // 
            this.lblCanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCanal.Location = new System.Drawing.Point(15, 117);
            this.lblCanal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(36, 17);
            this.lblCanal.TabIndex = 144;
            this.lblCanal.Text = "Canal";
            // 
            // lbReferencias
            // 
            this.lbReferencias.Location = new System.Drawing.Point(151, 255);
            this.lbReferencias.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbReferencias.Name = "lbReferencias";
            this.lbReferencias.Size = new System.Drawing.Size(291, 145);
            this.lbReferencias.TabIndex = 88;
            // 
            // btnReferencias
            // 
            this.btnReferencias.Location = new System.Drawing.Point(151, 218);
            this.btnReferencias.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReferencias.Name = "btnReferencias";
            this.btnReferencias.Size = new System.Drawing.Size(291, 31);
            this.btnReferencias.TabIndex = 0;
            this.btnReferencias.TabStop = false;
            this.btnReferencias.Text = "Referencias";
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.Location = new System.Drawing.Point(17, 187);
            this.lblOrdenCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(110, 17);
            this.lblOrdenCompra.TabIndex = 86;
            this.lblOrdenCompra.Text = "Orden de compra";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(151, 184);
            this.txtOrdenCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.MaxLength = 15;
            this.txtOrdenCompra.Size = new System.Drawing.Size(291, 24);
            this.txtOrdenCompra.TabIndex = 4;
            // 
            // lblCuentaPago
            // 
            this.lblCuentaPago.Location = new System.Drawing.Point(17, 153);
            this.lblCuentaPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCuentaPago.Name = "lblCuentaPago";
            this.lblCuentaPago.Size = new System.Drawing.Size(100, 17);
            this.lblCuentaPago.TabIndex = 84;
            this.lblCuentaPago.Text = "Cuenta de pago";
            // 
            // txtCuentaPago
            // 
            this.txtCuentaPago.Location = new System.Drawing.Point(151, 150);
            this.txtCuentaPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCuentaPago.Name = "txtCuentaPago";
            this.txtCuentaPago.Properties.MaxLength = 18;
            this.txtCuentaPago.Size = new System.Drawing.Size(291, 24);
            this.txtCuentaPago.TabIndex = 3;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(151, 51);
            this.cbMetodosPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbMetodosPago.MenuManager = this.mainRibbonControl;
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Size = new System.Drawing.Size(291, 24);
            this.cbMetodosPago.TabIndex = 1;
            // 
            // lblMetodosPago
            // 
            this.lblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodosPago.Location = new System.Drawing.Point(15, 54);
            this.lblMetodosPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(103, 17);
            this.lblMetodosPago.TabIndex = 82;
            this.lblMetodosPago.Text = "Método de pago";
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(151, 17);
            this.cbCondicionesPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCondicionesPago.MenuManager = this.mainRibbonControl;
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Size = new System.Drawing.Size(291, 24);
            this.cbCondicionesPago.TabIndex = 0;
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCondicionesPago.Location = new System.Drawing.Point(15, 20);
            this.lblCondicionesPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(127, 17);
            this.lblCondicionesPago.TabIndex = 81;
            this.lblCondicionesPago.Text = "Condiciones de pago";
            // 
            // xtraTabPageDocumentoElectronico
            // 
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbGlobal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerarSustitucion);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnEliminarDE);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblRFC);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerarRFCGenerico);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblCancelacionMasiva);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblUUIDErrorCancelacion);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblUUIDPorCancelar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtUUIDErrorCancelacion);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtUUIDPorCancelar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnCancelacionMasiva);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnEstadoCFDI);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblImportarFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnCancelar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbUsoPrincipal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblUsoPrincipal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnActualizar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtSelloCFD);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblSelloCFD);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbGenerarDocumentoElectronico);
            this.xtraTabPageDocumentoElectronico.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageDocumentoElectronico.Name = "xtraTabPageDocumentoElectronico";
            this.xtraTabPageDocumentoElectronico.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageDocumentoElectronico.Text = "Documento electrónico";
            // 
            // cbGlobal
            // 
            this.cbGlobal.Location = new System.Drawing.Point(642, 54);
            this.cbGlobal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbGlobal.MenuManager = this.mainRibbonControl;
            this.cbGlobal.Name = "cbGlobal";
            this.cbGlobal.Properties.Caption = "Factura global";
            this.cbGlobal.Size = new System.Drawing.Size(175, 21);
            this.cbGlobal.TabIndex = 109;
            // 
            // btnGenerarSustitucion
            // 
            this.btnGenerarSustitucion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarSustitucion.Location = new System.Drawing.Point(15, 597);
            this.btnGenerarSustitucion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGenerarSustitucion.Name = "btnGenerarSustitucion";
            this.btnGenerarSustitucion.Size = new System.Drawing.Size(358, 31);
            this.btnGenerarSustitucion.TabIndex = 108;
            this.btnGenerarSustitucion.TabStop = false;
            this.btnGenerarSustitucion.Text = "Generar sustitución";
            // 
            // btnEliminarDE
            // 
            this.btnEliminarDE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEliminarDE.Location = new System.Drawing.Point(438, 597);
            this.btnEliminarDE.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarDE.Name = "btnEliminarDE";
            this.btnEliminarDE.Size = new System.Drawing.Size(182, 31);
            this.btnEliminarDE.TabIndex = 107;
            this.btnEliminarDE.TabStop = false;
            this.btnEliminarDE.Text = "Elimar registro";
            // 
            // lblRFC
            // 
            this.lblRFC.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblRFC.Appearance.Options.UseForeColor = true;
            this.lblRFC.Location = new System.Drawing.Point(399, 26);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(26, 17);
            this.lblRFC.TabIndex = 106;
            this.lblRFC.Text = "RFC";
            // 
            // btnGenerarRFCGenerico
            // 
            this.btnGenerarRFCGenerico.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarRFCGenerico.Location = new System.Drawing.Point(167, 519);
            this.btnGenerarRFCGenerico.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGenerarRFCGenerico.Name = "btnGenerarRFCGenerico";
            this.btnGenerarRFCGenerico.Size = new System.Drawing.Size(206, 31);
            this.btnGenerarRFCGenerico.TabIndex = 105;
            this.btnGenerarRFCGenerico.TabStop = false;
            this.btnGenerarRFCGenerico.Text = "Generar con RFC genérico";
            // 
            // lblCancelacionMasiva
            // 
            this.lblCancelacionMasiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelacionMasiva.Location = new System.Drawing.Point(495, 558);
            this.lblCancelacionMasiva.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCancelacionMasiva.Name = "lblCancelacionMasiva";
            this.lblCancelacionMasiva.Size = new System.Drawing.Size(120, 17);
            this.lblCancelacionMasiva.TabIndex = 104;
            this.lblCancelacionMasiva.Text = "Cancelación masiva";
            // 
            // lblUUIDErrorCancelacion
            // 
            this.lblUUIDErrorCancelacion.Location = new System.Drawing.Point(642, 363);
            this.lblUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUUIDErrorCancelacion.Name = "lblUUIDErrorCancelacion";
            this.lblUUIDErrorCancelacion.Size = new System.Drawing.Size(167, 17);
            this.lblUUIDErrorCancelacion.TabIndex = 103;
            this.lblUUIDErrorCancelacion.Text = "UUIDs con error al cancelar";
            this.lblUUIDErrorCancelacion.Visible = false;
            // 
            // lblUUIDPorCancelar
            // 
            this.lblUUIDPorCancelar.Location = new System.Drawing.Point(642, 127);
            this.lblUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUUIDPorCancelar.Name = "lblUUIDPorCancelar";
            this.lblUUIDPorCancelar.Size = new System.Drawing.Size(117, 17);
            this.lblUUIDPorCancelar.TabIndex = 102;
            this.lblUUIDPorCancelar.Text = "UUIDs por cancelar";
            this.lblUUIDPorCancelar.Visible = false;
            // 
            // txtUUIDErrorCancelacion
            // 
            this.txtUUIDErrorCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDErrorCancelacion.Location = new System.Drawing.Point(642, 388);
            this.txtUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUUIDErrorCancelacion.Name = "txtUUIDErrorCancelacion";
            this.txtUUIDErrorCancelacion.Size = new System.Drawing.Size(271, 123);
            this.txtUUIDErrorCancelacion.TabIndex = 101;
            this.txtUUIDErrorCancelacion.Text = "";
            this.txtUUIDErrorCancelacion.Visible = false;
            // 
            // txtUUIDPorCancelar
            // 
            this.txtUUIDPorCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDPorCancelar.Location = new System.Drawing.Point(642, 153);
            this.txtUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUUIDPorCancelar.Name = "txtUUIDPorCancelar";
            this.txtUUIDPorCancelar.Size = new System.Drawing.Size(280, 199);
            this.txtUUIDPorCancelar.TabIndex = 100;
            this.txtUUIDPorCancelar.Text = "";
            this.txtUUIDPorCancelar.Visible = false;
            // 
            // btnCancelacionMasiva
            // 
            this.btnCancelacionMasiva.Location = new System.Drawing.Point(739, 517);
            this.btnCancelacionMasiva.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelacionMasiva.Name = "btnCancelacionMasiva";
            this.btnCancelacionMasiva.Size = new System.Drawing.Size(174, 31);
            this.btnCancelacionMasiva.TabIndex = 99;
            this.btnCancelacionMasiva.Text = "Cancelación masiva";
            this.btnCancelacionMasiva.UseVisualStyleBackColor = true;
            this.btnCancelacionMasiva.Visible = false;
            // 
            // btnEstadoCFDI
            // 
            this.btnEstadoCFDI.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEstadoCFDI.Location = new System.Drawing.Point(438, 519);
            this.btnEstadoCFDI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEstadoCFDI.Name = "btnEstadoCFDI";
            this.btnEstadoCFDI.Size = new System.Drawing.Size(49, 31);
            this.btnEstadoCFDI.TabIndex = 0;
            this.btnEstadoCFDI.TabStop = false;
            // 
            // lblImportarFolioFiscal
            // 
            this.lblImportarFolioFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImportarFolioFiscal.Location = new System.Drawing.Point(15, 558);
            this.lblImportarFolioFiscal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblImportarFolioFiscal.Name = "lblImportarFolioFiscal";
            this.lblImportarFolioFiscal.Size = new System.Drawing.Size(117, 17);
            this.lblImportarFolioFiscal.TabIndex = 97;
            this.lblImportarFolioFiscal.Text = "Importar folio fiscal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancelar.Location = new System.Drawing.Point(495, 519);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(149, 54);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(471, 24);
            this.cbUsoPrincipal.TabIndex = 1;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(15, 59);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(78, 17);
            this.lblUsoPrincipal.TabIndex = 96;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnActualizar.Location = new System.Drawing.Point(379, 519);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(49, 31);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerar.Location = new System.Drawing.Point(15, 519);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(144, 31);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "Generar";
            // 
            // txtSelloCFD
            // 
            this.txtSelloCFD.Enabled = false;
            this.txtSelloCFD.Location = new System.Drawing.Point(15, 385);
            this.txtSelloCFD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSelloCFD.MenuManager = this.mainRibbonControl;
            this.txtSelloCFD.Name = "txtSelloCFD";
            this.txtSelloCFD.Size = new System.Drawing.Size(603, 126);
            this.txtSelloCFD.TabIndex = 3;
            // 
            // lblSelloCFD
            // 
            this.lblSelloCFD.Location = new System.Drawing.Point(15, 360);
            this.lblSelloCFD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSelloCFD.Name = "lblSelloCFD";
            this.lblSelloCFD.Size = new System.Drawing.Size(59, 17);
            this.lblSelloCFD.TabIndex = 94;
            this.lblSelloCFD.Text = "Sello CFD";
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Enabled = false;
            this.txtCadenaOriginal.Location = new System.Drawing.Point(15, 152);
            this.txtCadenaOriginal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCadenaOriginal.MenuManager = this.mainRibbonControl;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(603, 202);
            this.txtCadenaOriginal.TabIndex = 2;
            // 
            // lblCadenaOriginal
            // 
            this.lblCadenaOriginal.Location = new System.Drawing.Point(15, 127);
            this.lblCadenaOriginal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCadenaOriginal.Name = "lblCadenaOriginal";
            this.lblCadenaOriginal.Size = new System.Drawing.Size(98, 17);
            this.lblCadenaOriginal.TabIndex = 92;
            this.lblCadenaOriginal.Text = "Cadena original";
            // 
            // lblFolioFiscal
            // 
            this.lblFolioFiscal.Location = new System.Drawing.Point(15, 93);
            this.lblFolioFiscal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblFolioFiscal.Name = "lblFolioFiscal";
            this.lblFolioFiscal.Size = new System.Drawing.Size(62, 17);
            this.lblFolioFiscal.TabIndex = 90;
            this.lblFolioFiscal.Text = "Folio fiscal";
            // 
            // txtFolioFiscal
            // 
            this.txtFolioFiscal.Location = new System.Drawing.Point(149, 88);
            this.txtFolioFiscal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFolioFiscal.Name = "txtFolioFiscal";
            this.txtFolioFiscal.Properties.ReadOnly = true;
            this.txtFolioFiscal.Size = new System.Drawing.Size(471, 24);
            this.txtFolioFiscal.TabIndex = 1;
            // 
            // cbGenerarDocumentoElectronico
            // 
            this.cbGenerarDocumentoElectronico.Location = new System.Drawing.Point(149, 23);
            this.cbGenerarDocumentoElectronico.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbGenerarDocumentoElectronico.MenuManager = this.mainRibbonControl;
            this.cbGenerarDocumentoElectronico.Name = "cbGenerarDocumentoElectronico";
            this.cbGenerarDocumentoElectronico.Properties.Caption = "Generar documento electrónico";
            this.cbGenerarDocumentoElectronico.Size = new System.Drawing.Size(242, 21);
            this.cbGenerarDocumentoElectronico.TabIndex = 0;
            // 
            // xtraTabPageAnexos
            // 
            this.xtraTabPageAnexos.Controls.Add(this.btnVisualizarAnexo);
            this.xtraTabPageAnexos.Controls.Add(this.btnAnexos);
            this.xtraTabPageAnexos.Controls.Add(this.lbAnexos);
            this.xtraTabPageAnexos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.xtraTabPageAnexos.Name = "xtraTabPageAnexos";
            this.xtraTabPageAnexos.Size = new System.Drawing.Size(937, 642);
            this.xtraTabPageAnexos.Text = "Anexos";
            // 
            // btnVisualizarAnexo
            // 
            this.btnVisualizarAnexo.Location = new System.Drawing.Point(343, 280);
            this.btnVisualizarAnexo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnVisualizarAnexo.Name = "btnVisualizarAnexo";
            this.btnVisualizarAnexo.Size = new System.Drawing.Size(129, 31);
            this.btnVisualizarAnexo.TabIndex = 91;
            this.btnVisualizarAnexo.TabStop = false;
            this.btnVisualizarAnexo.Text = "Visualizar";
            // 
            // btnAnexos
            // 
            this.btnAnexos.Location = new System.Drawing.Point(480, 280);
            this.btnAnexos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnexos.Name = "btnAnexos";
            this.btnAnexos.Size = new System.Drawing.Size(129, 31);
            this.btnAnexos.TabIndex = 90;
            this.btnAnexos.TabStop = false;
            this.btnAnexos.Text = "Anexos";
            // 
            // lbAnexos
            // 
            this.lbAnexos.Location = new System.Drawing.Point(15, 20);
            this.lbAnexos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbAnexos.Name = "lbAnexos";
            this.lbAnexos.Size = new System.Drawing.Size(594, 252);
            this.lbAnexos.TabIndex = 89;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
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
            // cbRoles
            // 
            this.cbRoles.Location = new System.Drawing.Point(1073, 65);
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
            this.labelControl1.Location = new System.Drawing.Point(1043, 72);
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
            // cbDocumentos
            // 
            this.cbDocumentos.Location = new System.Drawing.Point(1073, 113);
            this.cbDocumentos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbDocumentos.Name = "cbDocumentos";
            this.cbDocumentos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDocumentos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDocumentos.Properties.NullText = "";
            this.cbDocumentos.Size = new System.Drawing.Size(342, 24);
            this.cbDocumentos.TabIndex = 91;
            // 
            // Formulario
            // 
            this.Formulario.Location = new System.Drawing.Point(994, 116);
            this.Formulario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(69, 17);
            this.Formulario.TabIndex = 92;
            this.Formulario.Text = "Formulario";
            // 
            // btnGenerarCartaPorte
            // 
            this.btnGenerarCartaPorte.Location = new System.Drawing.Point(778, 20);
            this.btnGenerarCartaPorte.Name = "btnGenerarCartaPorte";
            this.btnGenerarCartaPorte.Size = new System.Drawing.Size(130, 34);
            this.btnGenerarCartaPorte.TabIndex = 175;
            this.btnGenerarCartaPorte.Text = "Generar ";
            // 
            // chckCartaPorte
            // 
            this.chckCartaPorte.Location = new System.Drawing.Point(599, 33);
            this.chckCartaPorte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.chckCartaPorte.MenuManager = this.mainRibbonControl;
            this.chckCartaPorte.Name = "chckCartaPorte";
            this.chckCartaPorte.Properties.Caption = "Generar Carta Porte";
            this.chckCartaPorte.Size = new System.Drawing.Size(162, 21);
            this.chckCartaPorte.TabIndex = 176;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(542, 377);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 17);
            this.labelControl3.TabIndex = 178;
            this.labelControl3.Text = "Fecha de Salida";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(540, 414);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 17);
            this.labelControl4.TabIndex = 179;
            this.labelControl4.Text = "Fecha de Llegada";
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.EditValue = null;
            this.dtFechaSalida.Location = new System.Drawing.Point(657, 374);
            this.dtFechaSalida.MenuManager = this.mainRibbonControl;
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSalida.Size = new System.Drawing.Size(104, 24);
            this.dtFechaSalida.TabIndex = 180;
            // 
            // dtFechaLlegada
            // 
            this.dtFechaLlegada.EditValue = null;
            this.dtFechaLlegada.Location = new System.Drawing.Point(657, 411);
            this.dtFechaLlegada.MenuManager = this.mainRibbonControl;
            this.dtFechaLlegada.Name = "dtFechaLlegada";
            this.dtFechaLlegada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaLlegada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaLlegada.Size = new System.Drawing.Size(104, 24);
            this.dtFechaLlegada.TabIndex = 181;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(785, 381);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 17);
            this.labelControl5.TabIndex = 182;
            this.labelControl5.Text = "Hora";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(785, 418);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 17);
            this.labelControl6.TabIndex = 183;
            this.labelControl6.Text = "Hora";
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.EditValue = null;
            this.dtHoraSalida.Location = new System.Drawing.Point(826, 378);
            this.dtHoraSalida.MenuManager = this.mainRibbonControl;
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHoraSalida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHoraSalida.Size = new System.Drawing.Size(82, 24);
            this.dtHoraSalida.TabIndex = 184;
            // 
            // dtHoraLlegada
            // 
            this.dtHoraLlegada.EditValue = null;
            this.dtHoraLlegada.Location = new System.Drawing.Point(826, 415);
            this.dtHoraLlegada.MenuManager = this.mainRibbonControl;
            this.dtHoraLlegada.Name = "dtHoraLlegada";
            this.dtHoraLlegada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHoraLlegada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHoraLlegada.Size = new System.Drawing.Size(82, 24);
            this.dtHoraLlegada.TabIndex = 185;
            // 
            // btnBuscar
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 820);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.cbDocumentos);
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
            this.Name = "btnBuscar";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrizaciones del Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactVencidas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditoDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVigencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCreacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenesDestino)).EndInit();
            this.xtraTabPageLogistica.ResumeLayout(false);
            this.xtraTabPageLogistica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRemolques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeguimiento)).EndInit();
            this.gcSeguimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoSeguimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeguimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCausalidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupervisores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbForaneo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVehiculos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChoferes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPersonasContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClasesExpedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesFacturacion.Properties)).EndInit();
            this.xtraTabPageFinanzas.ResumeLayout(false);
            this.xtraTabPageFinanzas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProyectos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCanales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbReferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).EndInit();
            this.xtraTabPageDocumentoElectronico.ResumeLayout(false);
            this.xtraTabPageDocumentoElectronico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGlobal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelloCFD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarDocumentoElectronico.Properties)).EndInit();
            this.xtraTabPageAnexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckCartaPorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraSalida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraLlegada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraLlegada.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DefaultLookAndFeel defaultLookAndFeel1;
        private PanelControl panelControl1;
        private LookUpEdit cbRoles;
        private SimpleButton btnGuardar;
        private LabelControl labelControl1;
        private LayoutControl layoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneral;
        private RibbonControl mainRibbonControl;
        private BarButtonItem bbiGuardar;
        private BarButtonItem bbiGuardarCerrar;
        private BarButtonItem bbiGuardarNuevo;
        private BarButtonItem bbiEliminar;
        private BarButtonItem bbiRecargar;
        private BarButtonItem bbiBuscar;
        private BarButtonItem bbiPrimero;
        private BarButtonItem bbiAnterior;
        private BarButtonItem bbiUltimo;
        private BarButtonItem bbiSiguiente;
        private BarButtonItem bbiNuevo;
        private BarSubItem bbiImprimir;
        private BarButtonItem bbiNuevoSocio;
        private BarSubItem bbiCopiar;
        private BarButtonItem barButtonItemMapaRelaciones;
        private BarSubItem bbiPDF;
        private BarButtonItem bbiEnviar;
        private BarStaticItem bbiCancelar;
        private BarStaticItem bbiCerrar;
        private BarButtonItem bbiPagar;
        private BarButtonItem bbiXLSX;
        private BarHeaderItem barHeaderItem1;
        private BarHeaderItem barHeaderItem2;
        private BarHeaderItem barHeaderItem3;
        private BarButtonItem bbiAjustarColumnas;
        private BarButtonItem bbiDuplicar;
        private BarButtonItem bbiCancelacionManualCFDI;
        private BarButtonItem bbiParametrizaciones;
        private BarButtonItem bbiAbrir;
        private RibbonPage mainRibbonPage;
        private RibbonPageGroup mainRibbonPageGroup;
        private RibbonPageGroup searchRibbonPageGroup;
        private RibbonPage ribbonPageHerramientas;
        private RibbonPageGroup ribbonPageGroupHerramientas;
        private LabelControl lbMensajeC;
        private LabelControl lbFact;
        private LabelControl lbCredito;
        private TextEdit txtFactVencidas;
        private TextEdit txtCreditoDisponible;
        private Button btnStat;
        private LabelControl labelControl2;
        private SimpleButton btnCargaArticulos;
        private SimpleButton btnDescuentosEspeciales;
        private TextEdit txtArticulo;
        private TextEdit txtFechaVigencia;
        private LabelControl lblFechaVigencia;
        private Label lblEnviado;
        private LabelControl lblAlmacenDestino;
        private LabelControl lblAlmacenOrigen;
        private HyperlinkLabelControl lblClase;
        private LookUpEdit cbAlmacenDestino;
        private LookUpEdit cbAlmacenOrigen;
        private LabelControl lblUtilidad;
        private DateEdit deFechaVencimiento;
        private DateEdit deFechaContabilizacion;
        private TextEdit txtNumeroDocumentoExterno;
        private LabelControl lblArticulos;
        private LabelControl lblPartidas;
        private LabelControl lblReferencia;
        private TextEdit txtReferencia;
        private HyperlinkLabelControl lblCodigoSN;
        private LabelControl lblID;
        private Label lblImpreso;
        private Label lblCancelado;
        private TextEdit txtTipoCambio;
        private SeparatorControl separatorControl1;
        private LookUpEdit cbMonedas;
        private HyperlinkLabelControl lblMonedas;
        private TextEdit txtFechaCreacion;
        private LabelControl lblFechaCreacion;
        private LookUpEdit cbSeries;
        private LabelControl lblNumeroDocumento;
        private TextEdit txtNumeroDocumento;
        private TextEdit txtFechaDocumento;
        private LabelControl lblFechaDocumento;
        private LabelControl lblFechaVencimiento;
        private LabelControl lblFechaContabilizacion;
        private MemoEdit txtComentario;
        private LabelControl lblComentario;
        private LookUpEdit cbVendedores;
        private HyperlinkLabelControl lblVendedores;
        private LabelControl lblImporteAplicado;
        private TextEdit txtImporteAplicado;
        private LabelControl lblTotal;
        private TextEdit txtTotal;
        private LabelControl lblImpuesto;
        private TextEdit txtImpuesto;
        private LabelControl lblSubTotal;
        private TextEdit txtSubTotal;
        private TextEdit txtCodigoSN;
        private LabelControl lblSocio;
        private DevExpress.XtraGrid.GridControl gcPartidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartidas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidad;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPeso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnidadMedida;
        private RepositoryItemLookUpEdit cbUnidadesMedida;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoEmpaque;
        private RepositoryItemLookUpEdit cbTiposEmpaques;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadPaquete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSKU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecioPieza;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnListaPrecio;
        private RepositoryItemLookUpEdit cbListasPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPorcentajeDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecioNeto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAlmacen;
        private RepositoryItemLookUpEdit cbAlmacenes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUbicacion;
        private RepositoryItemLookUpEdit cbUbicaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAlmacenDestino;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUbicacionDestino;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComentario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescuentoEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumeroPedimento;
        private RepositoryItemLookUpEdit cbAlmacenesDestino;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLogistica;
        private SimpleButton btnEditarDireccionOrigen;
        private SimpleButton btnAgregarDireccionOrigen;
        private MemoEdit txtDireccionOrigen;
        private LookUpEdit cbDireccionesOrigen;
        private LabelControl lblDireccionOrigen;
        private SimpleButton btnEditarDireccionFacturacion;
        private SimpleButton btnEditarDireccionEnvio;
        private LabelControl lblDistancia;
        private TextEdit txtDistancia;
        private LookUpEdit cbRemolques;
        private HyperlinkLabelControl lblRemolque;
        private BarCodeControl bcID;
        private LookUpEdit cbRutas;
        private HyperlinkLabelControl lblRuta;
        private GroupControl gcSeguimiento;
        private ComboBoxEdit cbEstadoSeguimiento;
        private CheckEdit cbSeguimiento;
        private LookUpEdit cbCausalidades;
        private HyperlinkLabelControl lblCausalidades;
        private LookUpEdit cbSupervisores;
        private HyperlinkLabelControl lblSupervisores;
        private CheckEdit cbForaneo;
        private LookUpEdit cbVehiculos;
        private HyperlinkLabelControl lblVehiculo;
        private LookUpEdit cbChoferes;
        private HyperlinkLabelControl lblChofer;
        private SimpleButton btnSolicitarEtiquetas;
        private LabelControl lblActualizacion;
        private Label lblSincronizacion;
        private LookUpEdit cbPersonasContacto;
        private LabelControl lblPersonasContacto;
        private LookUpEdit cbClasesExpedicion;
        private HyperlinkLabelControl lblClaseExpedicion;
        private LabelControl lblCreacion;
        private SimpleButton btnDireccionFacturacion;
        private SimpleButton btnAgregarDireccionEnvio;
        private MemoEdit txtDireccionEnvio;
        private MemoEdit txtDireccionFacturacion;
        private LookUpEdit cbDireccionesEnvio;
        private LabelControl lblDireccionEnvio;
        private LookUpEdit cbDireccionesFacturacion;
        private LabelControl lblDireccionFacturacion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFinanzas;
        private LookUpEdit cbProyectos;
        private HyperlinkLabelControl lblProyectos;
        private LookUpEdit cbCanales;
        private HyperlinkLabelControl lblCanal;
        private ListBoxControl lbReferencias;
        private SimpleButton btnReferencias;
        private LabelControl lblOrdenCompra;
        private TextEdit txtOrdenCompra;
        private LabelControl lblCuentaPago;
        private TextEdit txtCuentaPago;
        private LookUpEdit cbMetodosPago;
        private HyperlinkLabelControl lblMetodosPago;
        private LookUpEdit cbCondicionesPago;
        private HyperlinkLabelControl lblCondicionesPago;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentoElectronico;
        private CheckEdit cbGlobal;
        private SimpleButton btnGenerarSustitucion;
        private SimpleButton btnEliminarDE;
        private LabelControl lblRFC;
        private SimpleButton btnGenerarRFCGenerico;
        private HyperlinkLabelControl lblCancelacionMasiva;
        private LabelControl lblUUIDErrorCancelacion;
        private LabelControl lblUUIDPorCancelar;
        private RichTextBox txtUUIDErrorCancelacion;
        private RichTextBox txtUUIDPorCancelar;
        private Button btnCancelacionMasiva;
        private SimpleButton btnEstadoCFDI;
        private HyperlinkLabelControl lblImportarFolioFiscal;
        private SimpleButton btnCancelar;
        private LookUpEdit cbUsoPrincipal;
        private LabelControl lblUsoPrincipal;
        private SimpleButton btnActualizar;
        private SimpleButton btnGenerar;
        private MemoEdit txtSelloCFD;
        private LabelControl lblSelloCFD;
        private MemoEdit txtCadenaOriginal;
        private LabelControl lblCadenaOriginal;
        private LabelControl lblFolioFiscal;
        private TextEdit txtFolioFiscal;
        private CheckEdit cbGenerarDocumentoElectronico;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAnexos;
        private SimpleButton btnVisualizarAnexo;
        private SimpleButton btnAnexos;
        private ListBoxControl lbAnexos;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private PanelControl panelControl2;
        private DataGridView dataGridView1;
        private SimpleButton simpleButton1;
        private LookUpEdit cbDocumentos;
        private LabelControl Formulario;
        private SimpleButton btnGenerarCartaPorte;
        private CheckEdit chckCartaPorte;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private DateEdit dtFechaSalida;
        private DateEdit dtFechaLlegada;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private DateEdit dtHoraSalida;
        private DateEdit dtHoraLlegada;
    }
}