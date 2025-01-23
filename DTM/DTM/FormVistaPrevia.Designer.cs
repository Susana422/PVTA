namespace DTM
{
    partial class frmVPram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.cbAnticipo = new DevExpress.XtraEditors.CheckEdit();
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
            this.cbCOD = new DevExpress.XtraEditors.CheckEdit();
            this.lbMensajeC = new DevExpress.XtraEditors.LabelControl();
            this.lbFact = new DevExpress.XtraEditors.LabelControl();
            this.lbCredito = new DevExpress.XtraEditors.LabelControl();
            this.txtFactVencidas = new DevExpress.XtraEditors.TextEdit();
            this.txtCreditoDisponible = new DevExpress.XtraEditors.TextEdit();
            this.btnStat = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargaArticulos = new DevExpress.XtraEditors.SimpleButton();
            this.btnDescuentosEspeciales = new DevExpress.XtraEditors.SimpleButton();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaVigencia = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaVigencia = new DevExpress.XtraEditors.LabelControl();
            this.lblWeb = new System.Windows.Forms.Label();
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
            this.cbReserva = new DevExpress.XtraEditors.CheckEdit();
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
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnticipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCOD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactVencidas.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbReserva.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1308, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 673);
            this.dataGridView1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(7);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1424, 798);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1424, 798);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 798);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1424, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 798);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 798);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlBottom.Size = new System.Drawing.Size(1424, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlTop.Size = new System.Drawing.Size(1424, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.xtraTabControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 90);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1424, 708);
            this.layoutControl2.TabIndex = 61;
            this.layoutControl2.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(1400, 684);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageLogistica,
            this.xtraTabPageFinanzas,
            this.xtraTabPageDocumentoElectronico,
            this.xtraTabPageAnexos});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.cbAnticipo);
            this.xtraTabPageGeneral.Controls.Add(this.cbCOD);
            this.xtraTabPageGeneral.Controls.Add(this.lbMensajeC);
            this.xtraTabPageGeneral.Controls.Add(this.lbFact);
            this.xtraTabPageGeneral.Controls.Add(this.lbCredito);
            this.xtraTabPageGeneral.Controls.Add(this.txtFactVencidas);
            this.xtraTabPageGeneral.Controls.Add(this.txtCreditoDisponible);
            this.xtraTabPageGeneral.Controls.Add(this.btnStat);
            this.xtraTabPageGeneral.Controls.Add(this.labelControl1);
            this.xtraTabPageGeneral.Controls.Add(this.btnCargaArticulos);
            this.xtraTabPageGeneral.Controls.Add(this.btnDescuentosEspeciales);
            this.xtraTabPageGeneral.Controls.Add(this.txtArticulo);
            this.xtraTabPageGeneral.Controls.Add(this.txtFechaVigencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaVigencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblWeb);
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
            this.xtraTabPageGeneral.Controls.Add(this.cbReserva);
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
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(1394, 654);
            this.xtraTabPageGeneral.Text = "General";
            this.xtraTabPageGeneral.Click += new System.EventHandler(this.xtraTabPageGeneral_Click);
            this.xtraTabPageGeneral.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xtraTabPageGeneral_MouseClick);
            this.xtraTabPageGeneral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xtraTabPageGeneral_MouseDown);
            // 
            // cbAnticipo
            // 
            this.cbAnticipo.Location = new System.Drawing.Point(555, 110);
            this.cbAnticipo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbAnticipo.MenuManager = this.mainRibbonControl;
            this.cbAnticipo.Name = "cbAnticipo";
            this.cbAnticipo.Properties.Caption = "Anticipo";
            this.cbAnticipo.Size = new System.Drawing.Size(135, 21);
            this.cbAnticipo.TabIndex = 176;
            this.cbAnticipo.TabStop = false;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(53, 52, 53, 52);
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
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.mainRibbonControl.MaxItemId = 25;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 587;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1424, 90);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.mainRibbonControl.Click += new System.EventHandler(this.mainRibbonControl_Click);
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
            // cbCOD
            // 
            this.cbCOD.Location = new System.Drawing.Point(471, 110);
            this.cbCOD.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbCOD.MenuManager = this.mainRibbonControl;
            this.cbCOD.Name = "cbCOD";
            this.cbCOD.Properties.Caption = "COD";
            this.cbCOD.Size = new System.Drawing.Size(135, 21);
            this.cbCOD.TabIndex = 175;
            this.cbCOD.TabStop = false;
            // 
            // lbMensajeC
            // 
            this.lbMensajeC.Appearance.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeC.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMensajeC.Appearance.Options.UseFont = true;
            this.lbMensajeC.Appearance.Options.UseForeColor = true;
            this.lbMensajeC.Location = new System.Drawing.Point(56, 319);
            this.lbMensajeC.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lbMensajeC.Name = "lbMensajeC";
            this.lbMensajeC.Size = new System.Drawing.Size(492, 18);
            this.lbMensajeC.TabIndex = 174;
            this.lbMensajeC.Text = "La Venta debera ser de Contado tiene Facturas pendientes por Pagar";
            this.lbMensajeC.Visible = false;
            // 
            // lbFact
            // 
            this.lbFact.Location = new System.Drawing.Point(24, 289);
            this.lbFact.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lbFact.Name = "lbFact";
            this.lbFact.Size = new System.Drawing.Size(109, 17);
            this.lbFact.TabIndex = 173;
            this.lbFact.Text = "Facturas Vencidas";
            this.lbFact.Visible = false;
            // 
            // lbCredito
            // 
            this.lbCredito.Location = new System.Drawing.Point(24, 245);
            this.lbCredito.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lbCredito.Name = "lbCredito";
            this.lbCredito.Size = new System.Drawing.Size(111, 17);
            this.lbCredito.TabIndex = 172;
            this.lbCredito.Text = "Credito Disponible";
            this.lbCredito.Visible = false;
            // 
            // txtFactVencidas
            // 
            this.txtFactVencidas.Enabled = false;
            this.txtFactVencidas.Location = new System.Drawing.Point(199, 280);
            this.txtFactVencidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactVencidas.MenuManager = this.mainRibbonControl;
            this.txtFactVencidas.Name = "txtFactVencidas";
            this.txtFactVencidas.Size = new System.Drawing.Size(297, 24);
            this.txtFactVencidas.TabIndex = 171;
            this.txtFactVencidas.Visible = false;
            // 
            // txtCreditoDisponible
            // 
            this.txtCreditoDisponible.Enabled = false;
            this.txtCreditoDisponible.Location = new System.Drawing.Point(200, 241);
            this.txtCreditoDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditoDisponible.MenuManager = this.mainRibbonControl;
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtCreditoDisponible.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(296, 24);
            this.txtCreditoDisponible.TabIndex = 170;
            this.txtCreditoDisponible.Visible = false;
            // 
            // btnStat
            // 
            this.btnStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStat.Location = new System.Drawing.Point(1329, 10);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(37, 38);
            this.btnStat.TabIndex = 169;
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(947, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 17);
            this.labelControl1.TabIndex = 168;
            this.labelControl1.Text = "N° de Documento en SAP";
            // 
            // btnCargaArticulos
            // 
            this.btnCargaArticulos.Location = new System.Drawing.Point(509, 263);
            this.btnCargaArticulos.Name = "btnCargaArticulos";
            this.btnCargaArticulos.Size = new System.Drawing.Size(315, 41);
            this.btnCargaArticulos.TabIndex = 166;
            this.btnCargaArticulos.Text = "Subir Articulos con Excel";
            // 
            // btnDescuentosEspeciales
            // 
            this.btnDescuentosEspeciales.Location = new System.Drawing.Point(505, 199);
            this.btnDescuentosEspeciales.Name = "btnDescuentosEspeciales";
            this.btnDescuentosEspeciales.Size = new System.Drawing.Size(319, 41);
            this.btnDescuentosEspeciales.TabIndex = 165;
            this.btnDescuentosEspeciales.Text = "Aplicar descuentos especiales";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticulo.Location = new System.Drawing.Point(21, 373);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(1344, 24);
            this.txtArticulo.TabIndex = 1;
            // 
            // txtFechaVigencia
            // 
            this.txtFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaVigencia.Location = new System.Drawing.Point(1176, 235);
            this.txtFechaVigencia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtFechaVigencia.Name = "txtFechaVigencia";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.EditFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.ReadOnly = true;
            this.txtFechaVigencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaVigencia.Size = new System.Drawing.Size(189, 24);
            this.txtFechaVigencia.TabIndex = 164;
            this.txtFechaVigencia.TabStop = false;
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVigencia.Location = new System.Drawing.Point(1021, 245);
            this.lblFechaVigencia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(90, 17);
            this.lblFechaVigencia.TabIndex = 163;
            this.lblFechaVigencia.Text = "Fecha vigencia";
            // 
            // lblWeb
            // 
            this.lblWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeb.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWeb.Location = new System.Drawing.Point(604, 160);
            this.lblWeb.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(32, 13);
            this.lblWeb.TabIndex = 162;
            this.lblWeb.Text = "Web";
            this.lblWeb.Visible = false;
            // 
            // lblEnviado
            // 
            this.lblEnviado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnviado.AutoSize = true;
            this.lblEnviado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEnviado.ForeColor = System.Drawing.Color.Orange;
            this.lblEnviado.Location = new System.Drawing.Point(836, 31);
            this.lblEnviado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(51, 13);
            this.lblEnviado.TabIndex = 161;
            this.lblEnviado.Text = "Enviado";
            this.lblEnviado.Visible = false;
            // 
            // lblAlmacenDestino
            // 
            this.lblAlmacenDestino.Location = new System.Drawing.Point(652, 118);
            this.lblAlmacenDestino.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblAlmacenDestino.Name = "lblAlmacenDestino";
            this.lblAlmacenDestino.Size = new System.Drawing.Size(102, 17);
            this.lblAlmacenDestino.TabIndex = 160;
            this.lblAlmacenDestino.Text = "Almacén destino";
            // 
            // lblAlmacenOrigen
            // 
            this.lblAlmacenOrigen.Location = new System.Drawing.Point(653, 71);
            this.lblAlmacenOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblAlmacenOrigen.Name = "lblAlmacenOrigen";
            this.lblAlmacenOrigen.Size = new System.Drawing.Size(98, 17);
            this.lblAlmacenOrigen.TabIndex = 159;
            this.lblAlmacenOrigen.Text = "Almacén origen";
            // 
            // lblClase
            // 
            this.lblClase.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Appearance.Options.UseFont = true;
            this.lblClase.Location = new System.Drawing.Point(435, 18);
            this.lblClase.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(51, 23);
            this.lblClase.TabIndex = 158;
            this.lblClase.Text = "Clase";
            // 
            // cbAlmacenDestino
            // 
            this.cbAlmacenDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenDestino.Location = new System.Drawing.Point(707, 107);
            this.cbAlmacenDestino.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbAlmacenDestino.MenuManager = this.mainRibbonControl;
            this.cbAlmacenDestino.Name = "cbAlmacenDestino";
            this.cbAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenDestino.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenDestino.Properties.NullText = "[Almacén destino]";
            this.cbAlmacenDestino.Size = new System.Drawing.Size(249, 24);
            this.cbAlmacenDestino.TabIndex = 157;
            this.cbAlmacenDestino.Visible = false;
            // 
            // cbAlmacenOrigen
            // 
            this.cbAlmacenOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenOrigen.Location = new System.Drawing.Point(707, 67);
            this.cbAlmacenOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbAlmacenOrigen.MenuManager = this.mainRibbonControl;
            this.cbAlmacenOrigen.Name = "cbAlmacenOrigen";
            this.cbAlmacenOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenOrigen.Properties.NullText = "[Almacén origen]";
            this.cbAlmacenOrigen.Size = new System.Drawing.Size(249, 24);
            this.cbAlmacenOrigen.TabIndex = 156;
            this.cbAlmacenOrigen.Visible = false;
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUtilidad.Location = new System.Drawing.Point(568, 523);
            this.lblUtilidad.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(48, 17);
            this.lblUtilidad.TabIndex = 154;
            this.lblUtilidad.Text = "Utilidad";
            // 
            // deFechaVencimiento
            // 
            this.deFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaVencimiento.EditValue = null;
            this.deFechaVencimiento.Location = new System.Drawing.Point(1177, 152);
            this.deFechaVencimiento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.deFechaVencimiento.MenuManager = this.mainRibbonControl;
            this.deFechaVencimiento.Name = "deFechaVencimiento";
            this.deFechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Size = new System.Drawing.Size(189, 24);
            this.deFechaVencimiento.TabIndex = 153;
            // 
            // deFechaContabilizacion
            // 
            this.deFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaContabilizacion.EditValue = null;
            this.deFechaContabilizacion.Location = new System.Drawing.Point(1176, 106);
            this.deFechaContabilizacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.deFechaContabilizacion.MenuManager = this.mainRibbonControl;
            this.deFechaContabilizacion.Name = "deFechaContabilizacion";
            this.deFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Size = new System.Drawing.Size(189, 24);
            this.deFechaContabilizacion.TabIndex = 150;
            // 
            // txtNumeroDocumentoExterno
            // 
            this.txtNumeroDocumentoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumentoExterno.Enabled = false;
            this.txtNumeroDocumentoExterno.Location = new System.Drawing.Point(1177, 16);
            this.txtNumeroDocumentoExterno.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtNumeroDocumentoExterno.Name = "txtNumeroDocumentoExterno";
            this.txtNumeroDocumentoExterno.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumentoExterno.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumeroDocumentoExterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumentoExterno.Size = new System.Drawing.Size(141, 24);
            this.txtNumeroDocumentoExterno.TabIndex = 124;
            this.txtNumeroDocumentoExterno.TabStop = false;
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArticulos.Location = new System.Drawing.Point(568, 553);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(65, 17);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Artículos 0";
            // 
            // lblPartidas
            // 
            this.lblPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPartidas.Location = new System.Drawing.Point(568, 583);
            this.lblPartidas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(63, 17);
            this.lblPartidas.TabIndex = 0;
            this.lblPartidas.Text = "Partidas 0";
            // 
            // lblReferencia
            // 
            this.lblReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReferencia.Location = new System.Drawing.Point(20, 445);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(64, 17);
            this.lblReferencia.TabIndex = 121;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReferencia.Location = new System.Drawing.Point(200, 441);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.MaxLength = 100;
            this.txtReferencia.Size = new System.Drawing.Size(352, 24);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.TabStop = false;
            // 
            // cbReserva
            // 
            this.cbReserva.Location = new System.Drawing.Point(361, 110);
            this.cbReserva.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbReserva.MenuManager = this.mainRibbonControl;
            this.cbReserva.Name = "cbReserva";
            this.cbReserva.Properties.Caption = "Reserva";
            this.cbReserva.Size = new System.Drawing.Size(96, 21);
            this.cbReserva.TabIndex = 0;
            this.cbReserva.TabStop = false;
            // 
            // lblCodigoSN
            // 
            this.lblCodigoSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoSN.Location = new System.Drawing.Point(20, 26);
            this.lblCodigoSN.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCodigoSN.Name = "lblCodigoSN";
            this.lblCodigoSN.Size = new System.Drawing.Size(66, 17);
            this.lblCodigoSN.TabIndex = 118;
            this.lblCodigoSN.Text = "Código SN";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(361, 26);
            this.lblID.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.lblImpreso.Location = new System.Drawing.Point(729, 30);
            this.lblImpreso.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            this.lblCancelado.Location = new System.Drawing.Point(604, 30);
            this.lblCancelado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(65, 13);
            this.lblCancelado.TabIndex = 115;
            this.lblCancelado.Text = "Cancelado";
            this.lblCancelado.Visible = false;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(505, 156);
            this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(171, 24);
            this.txtTipoCambio.TabIndex = 0;
            this.txtTipoCambio.TabStop = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(24, 344);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.separatorControl1.Size = new System.Drawing.Size(1343, 33);
            this.separatorControl1.TabIndex = 112;
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(200, 156);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(297, 24);
            this.cbMonedas.TabIndex = 0;
            this.cbMonedas.TabStop = false;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(20, 157);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 111;
            this.lblMonedas.Text = "Moneda";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(201, 111);
            this.txtFechaCreacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.EditFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(151, 24);
            this.txtFechaCreacion.TabIndex = 106;
            this.txtFechaCreacion.TabStop = false;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.Location = new System.Drawing.Point(20, 115);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(92, 17);
            this.lblFechaCreacion.TabIndex = 105;
            this.lblFechaCreacion.Text = "Fecha creación";
            // 
            // cbSeries
            // 
            this.cbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeries.Location = new System.Drawing.Point(1024, 61);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbSeries.MenuManager = this.mainRibbonControl;
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSeries.Size = new System.Drawing.Size(139, 24);
            this.cbSeries.TabIndex = 0;
            this.cbSeries.TabStop = false;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(987, 71);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDocumento.TabIndex = 103;
            this.lblNumeroDocumento.Text = "N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(1176, 61);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(189, 24);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.TabStop = false;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDocumento.Location = new System.Drawing.Point(1177, 194);
            this.txtFechaDocumento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.EditFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.ReadOnly = true;
            this.txtFechaDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaDocumento.Size = new System.Drawing.Size(189, 24);
            this.txtFechaDocumento.TabIndex = 99;
            this.txtFechaDocumento.TabStop = false;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDocumento.Location = new System.Drawing.Point(996, 207);
            this.lblFechaDocumento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(112, 17);
            this.lblFechaDocumento.TabIndex = 93;
            this.lblFechaDocumento.Text = "Fecha documento";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(992, 161);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 17);
            this.lblFechaVencimiento.TabIndex = 91;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(987, 114);
            this.lblFechaContabilizacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(132, 17);
            this.lblFechaContabilizacion.TabIndex = 89;
            this.lblFechaContabilizacion.Text = "Fecha contabilización";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentario.Location = new System.Drawing.Point(200, 486);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(352, 122);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.Location = new System.Drawing.Point(20, 490);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(74, 17);
            this.lblComentario.TabIndex = 84;
            this.lblComentario.Text = "Comentario";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVendedores.Location = new System.Drawing.Point(200, 397);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(352, 24);
            this.cbVendedores.TabIndex = 0;
            this.cbVendedores.TabStop = false;
            // 
            // lblVendedores
            // 
            this.lblVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedores.Location = new System.Drawing.Point(20, 401);
            this.lblVendedores.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(60, 17);
            this.lblVendedores.TabIndex = 82;
            this.lblVendedores.Text = "Vendedor";
            // 
            // lblImporteAplicado
            // 
            this.lblImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteAplicado.Location = new System.Drawing.Point(939, 529);
            this.lblImporteAplicado.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblImporteAplicado.Name = "lblImporteAplicado";
            this.lblImporteAplicado.Size = new System.Drawing.Size(105, 17);
            this.lblImporteAplicado.TabIndex = 80;
            this.lblImporteAplicado.Text = "Importe aplicado";
            // 
            // txtImporteAplicado
            // 
            this.txtImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteAplicado.Location = new System.Drawing.Point(1124, 520);
            this.txtImporteAplicado.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtImporteAplicado.MenuManager = this.mainRibbonControl;
            this.txtImporteAplicado.Name = "txtImporteAplicado";
            this.txtImporteAplicado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImporteAplicado.Properties.DisplayFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.EditFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.ReadOnly = true;
            this.txtImporteAplicado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImporteAplicado.Size = new System.Drawing.Size(241, 24);
            this.txtImporteAplicado.TabIndex = 0;
            this.txtImporteAplicado.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(939, 487);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 17);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = "Total del documento";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(1124, 486);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.txtTotal.Size = new System.Drawing.Size(241, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpuesto.Location = new System.Drawing.Point(941, 431);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(56, 17);
            this.lblImpuesto.TabIndex = 74;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.Location = new System.Drawing.Point(1124, 432);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtImpuesto.MenuManager = this.mainRibbonControl;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImpuesto.Properties.DisplayFormat.FormatString = "c2";
            this.txtImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.EditFormat.FormatString = "c2";
            this.txtImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.ReadOnly = true;
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(241, 24);
            this.txtImpuesto.TabIndex = 0;
            this.txtImpuesto.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.Location = new System.Drawing.Point(941, 401);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(55, 17);
            this.lblSubTotal.TabIndex = 72;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Location = new System.Drawing.Point(1124, 393);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.txtSubTotal.Size = new System.Drawing.Size(241, 24);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TabStop = false;
            // 
            // txtCodigoSN
            // 
            this.txtCodigoSN.Location = new System.Drawing.Point(201, 22);
            this.txtCodigoSN.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCodigoSN.Name = "txtCodigoSN";
            this.txtCodigoSN.Size = new System.Drawing.Size(149, 24);
            this.txtCodigoSN.TabIndex = 0;
            // 
            // lblSocio
            // 
            this.lblSocio.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSocio.Appearance.Options.UseFont = true;
            this.lblSocio.Location = new System.Drawing.Point(20, 71);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.gcPartidas.Location = new System.Drawing.Point(21, 425);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAlmacenes,
            this.cbTiposEmpaques,
            this.cbListasPrecios,
            this.cbUbicaciones,
            this.repositoryItemCalcEdit1,
            this.cbUnidadesMedida,
            this.cbAlmacenesDestino});
            this.gcPartidas.Size = new System.Drawing.Size(1345, 0);
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
            this.gvPartidas.DetailHeight = 599;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsCustomization.AllowSort = false;
            this.gvPartidas.OptionsEditForm.PopupEditFormWidth = 1421;
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
            this.gridColumnNo.MaxWidth = 53;
            this.gridColumnNo.MinWidth = 35;
            this.gridColumnNo.Name = "gridColumnNo";
            this.gridColumnNo.OptionsColumn.AllowEdit = false;
            this.gridColumnNo.OptionsColumn.ReadOnly = true;
            this.gridColumnNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnNo.Visible = true;
            this.gridColumnNo.VisibleIndex = 0;
            this.gridColumnNo.Width = 35;
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
            this.gridColumnCantidad.MaxWidth = 232;
            this.gridColumnCantidad.MinWidth = 53;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 1;
            this.gridColumnCantidad.Width = 107;
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
            this.gridColumnPeso.MinWidth = 35;
            this.gridColumnPeso.Name = "gridColumnPeso";
            this.gridColumnPeso.Visible = true;
            this.gridColumnPeso.VisibleIndex = 2;
            this.gridColumnPeso.Width = 39;
            // 
            // gridColumnStock
            // 
            this.gridColumnStock.Caption = "Stock";
            this.gridColumnStock.DisplayFormat.FormatString = "n3";
            this.gridColumnStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnStock.FieldName = "stock";
            this.gridColumnStock.MinWidth = 35;
            this.gridColumnStock.Name = "gridColumnStock";
            this.gridColumnStock.OptionsColumn.AllowEdit = false;
            this.gridColumnStock.Visible = true;
            this.gridColumnStock.VisibleIndex = 3;
            this.gridColumnStock.Width = 35;
            // 
            // gridColumnDiferencia
            // 
            this.gridColumnDiferencia.Caption = "Diferencia";
            this.gridColumnDiferencia.DisplayFormat.FormatString = "n3";
            this.gridColumnDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDiferencia.FieldName = "diferencia";
            this.gridColumnDiferencia.MinWidth = 35;
            this.gridColumnDiferencia.Name = "gridColumnDiferencia";
            this.gridColumnDiferencia.OptionsColumn.AllowEdit = false;
            this.gridColumnDiferencia.Width = 51;
            // 
            // gridColumnUnidadMedida
            // 
            this.gridColumnUnidadMedida.Caption = "UdM";
            this.gridColumnUnidadMedida.ColumnEdit = this.cbUnidadesMedida;
            this.gridColumnUnidadMedida.FieldName = "unidad_medida_id";
            this.gridColumnUnidadMedida.MinWidth = 35;
            this.gridColumnUnidadMedida.Name = "gridColumnUnidadMedida";
            this.gridColumnUnidadMedida.Visible = true;
            this.gridColumnUnidadMedida.VisibleIndex = 4;
            this.gridColumnUnidadMedida.Width = 35;
            // 
            // cbUnidadesMedida
            // 
            this.cbUnidadesMedida.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbUnidadesMedida.AutoHeight = false;
            this.cbUnidadesMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            // 
            // gridColumnCantidadEmpaque
            // 
            this.gridColumnCantidadEmpaque.Caption = "C/E";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatString = "n2";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadEmpaque.FieldName = "cantidad_empaque";
            this.gridColumnCantidadEmpaque.MinWidth = 35;
            this.gridColumnCantidadEmpaque.Name = "gridColumnCantidadEmpaque";
            this.gridColumnCantidadEmpaque.Width = 53;
            // 
            // gridColumnTipoEmpaque
            // 
            this.gridColumnTipoEmpaque.Caption = "Tipo empaque";
            this.gridColumnTipoEmpaque.ColumnEdit = this.cbTiposEmpaques;
            this.gridColumnTipoEmpaque.FieldName = "tipo_empaque_id";
            this.gridColumnTipoEmpaque.MinWidth = 35;
            this.gridColumnTipoEmpaque.Name = "gridColumnTipoEmpaque";
            this.gridColumnTipoEmpaque.Width = 132;
            // 
            // cbTiposEmpaques
            // 
            this.cbTiposEmpaques.AutoHeight = false;
            this.cbTiposEmpaques.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposEmpaques.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
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
            this.gridColumnCantidadPendiente.MaxWidth = 232;
            this.gridColumnCantidadPendiente.MinWidth = 53;
            this.gridColumnCantidadPendiente.Name = "gridColumnCantidadPendiente";
            this.gridColumnCantidadPendiente.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPendiente.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidadPendiente.Width = 107;
            // 
            // gridColumnCantidadPaquete
            // 
            this.gridColumnCantidadPaquete.Caption = "Cant/Paq";
            this.gridColumnCantidadPaquete.DisplayFormat.FormatString = "n2";
            this.gridColumnCantidadPaquete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadPaquete.FieldName = "cantidad_paquete";
            this.gridColumnCantidadPaquete.MaxWidth = 107;
            this.gridColumnCantidadPaquete.MinWidth = 63;
            this.gridColumnCantidadPaquete.Name = "gridColumnCantidadPaquete";
            this.gridColumnCantidadPaquete.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPaquete.Visible = true;
            this.gridColumnCantidadPaquete.VisibleIndex = 5;
            this.gridColumnCantidadPaquete.Width = 63;
            // 
            // gridColumnSKU
            // 
            this.gridColumnSKU.Caption = "SKU";
            this.gridColumnSKU.FieldName = "sku";
            this.gridColumnSKU.MaxWidth = 179;
            this.gridColumnSKU.MinWidth = 35;
            this.gridColumnSKU.Name = "gridColumnSKU";
            this.gridColumnSKU.OptionsColumn.AllowEdit = false;
            this.gridColumnSKU.Visible = true;
            this.gridColumnSKU.VisibleIndex = 6;
            this.gridColumnSKU.Width = 35;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.FieldName = "nombre";
            this.gridColumnArticulo.MinWidth = 179;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 7;
            this.gridColumnArticulo.Width = 184;
            // 
            // gridColumnCodigoBarras
            // 
            this.gridColumnCodigoBarras.Caption = "Código de barras";
            this.gridColumnCodigoBarras.FieldName = "codigo_barras";
            this.gridColumnCodigoBarras.MaxWidth = 151;
            this.gridColumnCodigoBarras.MinWidth = 88;
            this.gridColumnCodigoBarras.Name = "gridColumnCodigoBarras";
            this.gridColumnCodigoBarras.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigoBarras.Visible = true;
            this.gridColumnCodigoBarras.VisibleIndex = 8;
            this.gridColumnCodigoBarras.Width = 93;
            // 
            // gridColumnPrecioPieza
            // 
            this.gridColumnPrecioPieza.Caption = "P/Pza";
            this.gridColumnPrecioPieza.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecioPieza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecioPieza.FieldName = "gridColumnPrecioPieza";
            this.gridColumnPrecioPieza.MaxWidth = 213;
            this.gridColumnPrecioPieza.MinWidth = 35;
            this.gridColumnPrecioPieza.Name = "gridColumnPrecioPieza";
            this.gridColumnPrecioPieza.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecioPieza.UnboundExpression = "(precio_pieza * tipo_cambio)  + (impuesto / cantidad_paquete)";
            this.gridColumnPrecioPieza.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecioPieza.Visible = true;
            this.gridColumnPrecioPieza.VisibleIndex = 9;
            this.gridColumnPrecioPieza.Width = 35;
            // 
            // gridColumnListaPrecio
            // 
            this.gridColumnListaPrecio.Caption = "Lista de precio";
            this.gridColumnListaPrecio.ColumnEdit = this.cbListasPrecios;
            this.gridColumnListaPrecio.FieldName = "lista_precio_id";
            this.gridColumnListaPrecio.MaxWidth = 107;
            this.gridColumnListaPrecio.MinWidth = 35;
            this.gridColumnListaPrecio.Name = "gridColumnListaPrecio";
            this.gridColumnListaPrecio.Visible = true;
            this.gridColumnListaPrecio.VisibleIndex = 10;
            this.gridColumnListaPrecio.Width = 45;
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.AutoHeight = false;
            this.cbListasPrecios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Name = "cbListasPrecios";
            // 
            // gridColumnPrecio
            // 
            this.gridColumnPrecio.Caption = "Precio";
            this.gridColumnPrecio.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumnPrecio.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecio.FieldName = "gridColumnPrecio";
            this.gridColumnPrecio.MaxWidth = 213;
            this.gridColumnPrecio.MinWidth = 35;
            this.gridColumnPrecio.Name = "gridColumnPrecio";
            this.gridColumnPrecio.UnboundExpression = "precio * tipo_cambio";
            this.gridColumnPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecio.Visible = true;
            this.gridColumnPrecio.VisibleIndex = 11;
            this.gridColumnPrecio.Width = 36;
            // 
            // gridColumnImpuesto
            // 
            this.gridColumnImpuesto.Caption = "Impuesto";
            this.gridColumnImpuesto.DisplayFormat.FormatString = "C";
            this.gridColumnImpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImpuesto.FieldName = "impuesto";
            this.gridColumnImpuesto.MinWidth = 35;
            this.gridColumnImpuesto.Name = "gridColumnImpuesto";
            this.gridColumnImpuesto.OptionsColumn.AllowEdit = false;
            this.gridColumnImpuesto.Visible = true;
            this.gridColumnImpuesto.VisibleIndex = 12;
            this.gridColumnImpuesto.Width = 35;
            // 
            // gridColumnPorcentajeDescuento
            // 
            this.gridColumnPorcentajeDescuento.Caption = "% Dscto";
            this.gridColumnPorcentajeDescuento.DisplayFormat.FormatString = "0.##";
            this.gridColumnPorcentajeDescuento.FieldName = "porcentaje_descuento";
            this.gridColumnPorcentajeDescuento.MaxWidth = 88;
            this.gridColumnPorcentajeDescuento.MinWidth = 35;
            this.gridColumnPorcentajeDescuento.Name = "gridColumnPorcentajeDescuento";
            this.gridColumnPorcentajeDescuento.OptionsColumn.FixedWidth = true;
            this.gridColumnPorcentajeDescuento.Visible = true;
            this.gridColumnPorcentajeDescuento.VisibleIndex = 13;
            this.gridColumnPorcentajeDescuento.Width = 88;
            // 
            // gridColumnDescuento
            // 
            this.gridColumnDescuento.Caption = "Descuento";
            this.gridColumnDescuento.DisplayFormat.FormatString = "C";
            this.gridColumnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDescuento.FieldName = "descuento";
            this.gridColumnDescuento.MaxWidth = 213;
            this.gridColumnDescuento.MinWidth = 35;
            this.gridColumnDescuento.Name = "gridColumnDescuento";
            this.gridColumnDescuento.OptionsColumn.AllowEdit = false;
            this.gridColumnDescuento.Visible = true;
            this.gridColumnDescuento.VisibleIndex = 14;
            this.gridColumnDescuento.Width = 35;
            // 
            // gridColumnPrecioNeto
            // 
            this.gridColumnPrecioNeto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnPrecioNeto.AppearanceCell.Options.UseFont = true;
            this.gridColumnPrecioNeto.Caption = "P. Neto";
            this.gridColumnPrecioNeto.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecioNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecioNeto.FieldName = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.MaxWidth = 213;
            this.gridColumnPrecioNeto.MinWidth = 35;
            this.gridColumnPrecioNeto.Name = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecioNeto.UnboundExpression = "((precio * tipo_cambio) + impuesto) - descuento";
            this.gridColumnPrecioNeto.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecioNeto.Visible = true;
            this.gridColumnPrecioNeto.VisibleIndex = 15;
            this.gridColumnPrecioNeto.Width = 35;
            // 
            // gridColumnSubTotal
            // 
            this.gridColumnSubTotal.Caption = "SubTotal";
            this.gridColumnSubTotal.DisplayFormat.FormatString = "C";
            this.gridColumnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSubTotal.FieldName = "subtotal";
            this.gridColumnSubTotal.MaxWidth = 179;
            this.gridColumnSubTotal.MinWidth = 35;
            this.gridColumnSubTotal.Name = "gridColumnSubTotal";
            this.gridColumnSubTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnSubTotal.Visible = true;
            this.gridColumnSubTotal.VisibleIndex = 16;
            this.gridColumnSubTotal.Width = 36;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnTotal.AppearanceCell.Options.UseFont = true;
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatString = "c2";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "total";
            this.gridColumnTotal.MinWidth = 79;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 17;
            this.gridColumnTotal.Width = 84;
            // 
            // gridColumnAlmacen
            // 
            this.gridColumnAlmacen.Caption = "Almacén";
            this.gridColumnAlmacen.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacen.FieldName = "almacen_id";
            this.gridColumnAlmacen.MinWidth = 35;
            this.gridColumnAlmacen.Name = "gridColumnAlmacen";
            this.gridColumnAlmacen.Visible = true;
            this.gridColumnAlmacen.VisibleIndex = 18;
            this.gridColumnAlmacen.Width = 36;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.AutoHeight = false;
            this.cbAlmacenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 107, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Name = "cbAlmacenes";
            // 
            // gridColumnUbicacion
            // 
            this.gridColumnUbicacion.Caption = "Ubicación";
            this.gridColumnUbicacion.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacion.FieldName = "ubicacion_id";
            this.gridColumnUbicacion.MinWidth = 35;
            this.gridColumnUbicacion.Name = "gridColumnUbicacion";
            this.gridColumnUbicacion.Visible = true;
            this.gridColumnUbicacion.VisibleIndex = 19;
            this.gridColumnUbicacion.Width = 72;
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.AutoHeight = false;
            this.cbUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUbicaciones.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ubicacion", "Ubicación", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUbicaciones.Name = "cbUbicaciones";
            // 
            // gridColumnAlmacenDestino
            // 
            this.gridColumnAlmacenDestino.Caption = "Almacén destino";
            this.gridColumnAlmacenDestino.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacenDestino.FieldName = "almacen_destino_id";
            this.gridColumnAlmacenDestino.MinWidth = 35;
            this.gridColumnAlmacenDestino.Name = "gridColumnAlmacenDestino";
            this.gridColumnAlmacenDestino.Visible = true;
            this.gridColumnAlmacenDestino.VisibleIndex = 20;
            this.gridColumnAlmacenDestino.Width = 59;
            // 
            // gridColumnUbicacionDestino
            // 
            this.gridColumnUbicacionDestino.Caption = "Ubicación destino";
            this.gridColumnUbicacionDestino.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacionDestino.FieldName = "ubicacion_destino_id";
            this.gridColumnUbicacionDestino.MinWidth = 35;
            this.gridColumnUbicacionDestino.Name = "gridColumnUbicacionDestino";
            this.gridColumnUbicacionDestino.Visible = true;
            this.gridColumnUbicacionDestino.VisibleIndex = 21;
            this.gridColumnUbicacionDestino.Width = 59;
            // 
            // gridColumnComentario
            // 
            this.gridColumnComentario.Caption = "Comentario";
            this.gridColumnComentario.FieldName = "comentario";
            this.gridColumnComentario.MinWidth = 35;
            this.gridColumnComentario.Name = "gridColumnComentario";
            this.gridColumnComentario.Visible = true;
            this.gridColumnComentario.VisibleIndex = 22;
            this.gridColumnComentario.Width = 47;
            // 
            // gridColumnDescuentoEspecial
            // 
            this.gridColumnDescuentoEspecial.Caption = "DE";
            this.gridColumnDescuentoEspecial.FieldName = "descuento_especial_id";
            this.gridColumnDescuentoEspecial.MaxWidth = 35;
            this.gridColumnDescuentoEspecial.MinWidth = 23;
            this.gridColumnDescuentoEspecial.Name = "gridColumnDescuentoEspecial";
            this.gridColumnDescuentoEspecial.Visible = true;
            this.gridColumnDescuentoEspecial.VisibleIndex = 23;
            this.gridColumnDescuentoEspecial.Width = 35;
            // 
            // gridColumnNumeroPedimento
            // 
            this.gridColumnNumeroPedimento.Caption = "N° Pedimento";
            this.gridColumnNumeroPedimento.FieldName = "numero_pedimento";
            this.gridColumnNumeroPedimento.MaxWidth = 151;
            this.gridColumnNumeroPedimento.MinWidth = 35;
            this.gridColumnNumeroPedimento.Name = "gridColumnNumeroPedimento";
            this.gridColumnNumeroPedimento.Width = 151;
            // 
            // cbAlmacenesDestino
            // 
            this.cbAlmacenesDestino.AutoHeight = false;
            this.cbAlmacenesDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenesDestino.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 107, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenesDestino.Name = "cbAlmacenesDestino";
            // 
            // xtraTabPageLogistica
            // 
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
            this.xtraTabPageLogistica.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabPageLogistica.Name = "xtraTabPageLogistica";
            this.xtraTabPageLogistica.Size = new System.Drawing.Size(1394, 654);
            this.xtraTabPageLogistica.Text = "Logística";
            this.xtraTabPageLogistica.Click += new System.EventHandler(this.xtraTabPageLogistica_Click);
            // 
            // btnEditarDireccionOrigen
            // 
            this.btnEditarDireccionOrigen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionOrigen.Location = new System.Drawing.Point(600, 509);
            this.btnEditarDireccionOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnEditarDireccionOrigen.Name = "btnEditarDireccionOrigen";
            this.btnEditarDireccionOrigen.Size = new System.Drawing.Size(43, 34);
            this.btnEditarDireccionOrigen.TabIndex = 173;
            this.btnEditarDireccionOrigen.TabStop = false;
            // 
            // btnAgregarDireccionOrigen
            // 
            this.btnAgregarDireccionOrigen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionOrigen.Location = new System.Drawing.Point(600, 463);
            this.btnAgregarDireccionOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnAgregarDireccionOrigen.Name = "btnAgregarDireccionOrigen";
            this.btnAgregarDireccionOrigen.Size = new System.Drawing.Size(43, 34);
            this.btnAgregarDireccionOrigen.TabIndex = 169;
            this.btnAgregarDireccionOrigen.TabStop = false;
            // 
            // txtDireccionOrigen
            // 
            this.txtDireccionOrigen.Location = new System.Drawing.Point(201, 507);
            this.txtDireccionOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtDireccionOrigen.MenuManager = this.mainRibbonControl;
            this.txtDireccionOrigen.Name = "txtDireccionOrigen";
            this.txtDireccionOrigen.Properties.ReadOnly = true;
            this.txtDireccionOrigen.Size = new System.Drawing.Size(388, 112);
            this.txtDireccionOrigen.TabIndex = 170;
            this.txtDireccionOrigen.TabStop = false;
            // 
            // cbDireccionesOrigen
            // 
            this.cbDireccionesOrigen.Location = new System.Drawing.Point(201, 463);
            this.cbDireccionesOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbDireccionesOrigen.MenuManager = this.mainRibbonControl;
            this.cbDireccionesOrigen.Name = "cbDireccionesOrigen";
            this.cbDireccionesOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesOrigen.Size = new System.Drawing.Size(388, 24);
            this.cbDireccionesOrigen.TabIndex = 171;
            // 
            // lblDireccionOrigen
            // 
            this.lblDireccionOrigen.Location = new System.Drawing.Point(20, 467);
            this.lblDireccionOrigen.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblDireccionOrigen.Name = "lblDireccionOrigen";
            this.lblDireccionOrigen.Size = new System.Drawing.Size(99, 17);
            this.lblDireccionOrigen.TabIndex = 172;
            this.lblDireccionOrigen.Text = "Dirección origen";
            // 
            // btnEditarDireccionFacturacion
            // 
            this.btnEditarDireccionFacturacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionFacturacion.Location = new System.Drawing.Point(600, 68);
            this.btnEditarDireccionFacturacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnEditarDireccionFacturacion.Name = "btnEditarDireccionFacturacion";
            this.btnEditarDireccionFacturacion.Size = new System.Drawing.Size(43, 34);
            this.btnEditarDireccionFacturacion.TabIndex = 168;
            this.btnEditarDireccionFacturacion.TabStop = false;
            // 
            // btnEditarDireccionEnvio
            // 
            this.btnEditarDireccionEnvio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarDireccionEnvio.Location = new System.Drawing.Point(600, 288);
            this.btnEditarDireccionEnvio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnEditarDireccionEnvio.Name = "btnEditarDireccionEnvio";
            this.btnEditarDireccionEnvio.Size = new System.Drawing.Size(43, 34);
            this.btnEditarDireccionEnvio.TabIndex = 167;
            this.btnEditarDireccionEnvio.TabStop = false;
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(23, 634);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(91, 17);
            this.lblDistancia.TabIndex = 166;
            this.lblDistancia.Text = "Distancia (Km)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(201, 630);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Properties.MaxLength = 18;
            this.txtDistancia.Size = new System.Drawing.Size(388, 24);
            this.txtDistancia.TabIndex = 165;
            // 
            // cbRemolques
            // 
            this.cbRemolques.Location = new System.Drawing.Point(904, 153);
            this.cbRemolques.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbRemolques.MenuManager = this.mainRibbonControl;
            this.cbRemolques.Name = "cbRemolques";
            this.cbRemolques.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRemolques.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRemolques.Size = new System.Drawing.Size(388, 24);
            this.cbRemolques.TabIndex = 163;
            // 
            // lblRemolque
            // 
            this.lblRemolque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemolque.Location = new System.Drawing.Point(723, 154);
            this.lblRemolque.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblRemolque.Name = "lblRemolque";
            this.lblRemolque.Size = new System.Drawing.Size(63, 17);
            this.lblRemolque.TabIndex = 164;
            this.lblRemolque.Text = "Remolque";
            // 
            // bcID
            // 
            this.bcID.AutoModule = true;
            this.bcID.Location = new System.Drawing.Point(904, 509);
            this.bcID.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.bcID.Name = "bcID";
            this.bcID.Padding = new System.Windows.Forms.Padding(19, 3, 19, 0);
            this.bcID.Size = new System.Drawing.Size(388, 102);
            this.bcID.Symbology = code128Generator1;
            this.bcID.TabIndex = 147;
            // 
            // cbRutas
            // 
            this.cbRutas.Location = new System.Drawing.Point(904, 199);
            this.cbRutas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbRutas.MenuManager = this.mainRibbonControl;
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRutas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRutas.Size = new System.Drawing.Size(388, 24);
            this.cbRutas.TabIndex = 145;
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(723, 199);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 17);
            this.lblRuta.TabIndex = 146;
            this.lblRuta.Text = "Ruta";
            // 
            // gcSeguimiento
            // 
            this.gcSeguimiento.Controls.Add(this.cbEstadoSeguimiento);
            this.gcSeguimiento.Controls.Add(this.cbSeguimiento);
            this.gcSeguimiento.Location = new System.Drawing.Point(723, 387);
            this.gcSeguimiento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.gcSeguimiento.Name = "gcSeguimiento";
            this.gcSeguimiento.Size = new System.Drawing.Size(569, 107);
            this.gcSeguimiento.TabIndex = 144;
            this.gcSeguimiento.Text = "Seguimiento";
            // 
            // cbEstadoSeguimiento
            // 
            this.cbEstadoSeguimiento.Location = new System.Drawing.Point(193, 52);
            this.cbEstadoSeguimiento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.cbEstadoSeguimiento.Size = new System.Drawing.Size(344, 24);
            this.cbEstadoSeguimiento.TabIndex = 145;
            // 
            // cbSeguimiento
            // 
            this.cbSeguimiento.Location = new System.Drawing.Point(23, 52);
            this.cbSeguimiento.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbSeguimiento.MenuManager = this.mainRibbonControl;
            this.cbSeguimiento.Name = "cbSeguimiento";
            this.cbSeguimiento.Properties.Caption = "Seguimiento";
            this.cbSeguimiento.Size = new System.Drawing.Size(160, 21);
            this.cbSeguimiento.TabIndex = 0;
            // 
            // cbCausalidades
            // 
            this.cbCausalidades.Location = new System.Drawing.Point(904, 286);
            this.cbCausalidades.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbCausalidades.MenuManager = this.mainRibbonControl;
            this.cbCausalidades.Name = "cbCausalidades";
            this.cbCausalidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCausalidades.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCausalidades.Size = new System.Drawing.Size(388, 24);
            this.cbCausalidades.TabIndex = 10;
            // 
            // lblCausalidades
            // 
            this.lblCausalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCausalidades.Location = new System.Drawing.Point(723, 288);
            this.lblCausalidades.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCausalidades.Name = "lblCausalidades";
            this.lblCausalidades.Size = new System.Drawing.Size(67, 17);
            this.lblCausalidades.TabIndex = 143;
            this.lblCausalidades.Text = "Causalidad";
            // 
            // cbSupervisores
            // 
            this.cbSupervisores.Location = new System.Drawing.Point(904, 242);
            this.cbSupervisores.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbSupervisores.MenuManager = this.mainRibbonControl;
            this.cbSupervisores.Name = "cbSupervisores";
            this.cbSupervisores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSupervisores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSupervisores.Size = new System.Drawing.Size(388, 24);
            this.cbSupervisores.TabIndex = 9;
            // 
            // lblSupervisores
            // 
            this.lblSupervisores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupervisores.Location = new System.Drawing.Point(723, 243);
            this.lblSupervisores.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblSupervisores.Name = "lblSupervisores";
            this.lblSupervisores.Size = new System.Drawing.Size(61, 17);
            this.lblSupervisores.TabIndex = 140;
            this.lblSupervisores.Text = "Supervisor";
            // 
            // cbForaneo
            // 
            this.cbForaneo.Location = new System.Drawing.Point(1308, 199);
            this.cbForaneo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbForaneo.MenuManager = this.mainRibbonControl;
            this.cbForaneo.Name = "cbForaneo";
            this.cbForaneo.Properties.Caption = "Foráneo";
            this.cbForaneo.Size = new System.Drawing.Size(107, 21);
            this.cbForaneo.TabIndex = 8;
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.Location = new System.Drawing.Point(904, 110);
            this.cbVehiculos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbVehiculos.MenuManager = this.mainRibbonControl;
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVehiculos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVehiculos.Size = new System.Drawing.Size(388, 24);
            this.cbVehiculos.TabIndex = 6;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVehiculo.Location = new System.Drawing.Point(723, 111);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(52, 17);
            this.lblVehiculo.TabIndex = 135;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // cbChoferes
            // 
            this.cbChoferes.Location = new System.Drawing.Point(904, 65);
            this.cbChoferes.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbChoferes.MenuManager = this.mainRibbonControl;
            this.cbChoferes.Name = "cbChoferes";
            this.cbChoferes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChoferes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbChoferes.Size = new System.Drawing.Size(388, 24);
            this.cbChoferes.TabIndex = 5;
            // 
            // lblChofer
            // 
            this.lblChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChofer.Location = new System.Drawing.Point(723, 67);
            this.lblChofer.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(41, 17);
            this.lblChofer.TabIndex = 133;
            this.lblChofer.Text = "Chofer";
            // 
            // btnSolicitarEtiquetas
            // 
            this.btnSolicitarEtiquetas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSolicitarEtiquetas.Location = new System.Drawing.Point(1079, 331);
            this.btnSolicitarEtiquetas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnSolicitarEtiquetas.Name = "btnSolicitarEtiquetas";
            this.btnSolicitarEtiquetas.Size = new System.Drawing.Size(213, 34);
            this.btnSolicitarEtiquetas.TabIndex = 10;
            this.btnSolicitarEtiquetas.Text = "Solicitar etiquetas";
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActualizacion.Location = new System.Drawing.Point(20, 791);
            this.lblActualizacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(82, 17);
            this.lblActualizacion.TabIndex = 130;
            this.lblActualizacion.Text = "Actualización";
            // 
            // lblSincronizacion
            // 
            this.lblSincronizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSincronizacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSincronizacion.Location = new System.Drawing.Point(308, 791);
            this.lblSincronizacion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSincronizacion.Name = "lblSincronizacion";
            this.lblSincronizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSincronizacion.Size = new System.Drawing.Size(1152, 22);
            this.lblSincronizacion.TabIndex = 129;
            this.lblSincronizacion.Text = "Sincronización";
            // 
            // cbPersonasContacto
            // 
            this.cbPersonasContacto.Location = new System.Drawing.Point(201, 671);
            this.cbPersonasContacto.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbPersonasContacto.MenuManager = this.mainRibbonControl;
            this.cbPersonasContacto.Name = "cbPersonasContacto";
            this.cbPersonasContacto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPersonasContacto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPersonasContacto.Size = new System.Drawing.Size(388, 24);
            this.cbPersonasContacto.TabIndex = 3;
            // 
            // lblPersonasContacto
            // 
            this.lblPersonasContacto.Location = new System.Drawing.Point(20, 677);
            this.lblPersonasContacto.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblPersonasContacto.Name = "lblPersonasContacto";
            this.lblPersonasContacto.Size = new System.Drawing.Size(126, 17);
            this.lblPersonasContacto.TabIndex = 128;
            this.lblPersonasContacto.Text = "Persona de contacto";
            // 
            // cbClasesExpedicion
            // 
            this.cbClasesExpedicion.Location = new System.Drawing.Point(904, 21);
            this.cbClasesExpedicion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbClasesExpedicion.MenuManager = this.mainRibbonControl;
            this.cbClasesExpedicion.Name = "cbClasesExpedicion";
            this.cbClasesExpedicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClasesExpedicion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbClasesExpedicion.Size = new System.Drawing.Size(388, 24);
            this.cbClasesExpedicion.TabIndex = 4;
            // 
            // lblClaseExpedicion
            // 
            this.lblClaseExpedicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClaseExpedicion.Location = new System.Drawing.Point(723, 22);
            this.lblClaseExpedicion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblClaseExpedicion.Name = "lblClaseExpedicion";
            this.lblClaseExpedicion.Size = new System.Drawing.Size(100, 17);
            this.lblClaseExpedicion.TabIndex = 126;
            this.lblClaseExpedicion.Text = "Clase expedición";
            // 
            // lblCreacion
            // 
            this.lblCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreacion.Location = new System.Drawing.Point(21, 758);
            this.lblCreacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(54, 17);
            this.lblCreacion.TabIndex = 124;
            this.lblCreacion.Text = "Creación";
            // 
            // btnDireccionFacturacion
            // 
            this.btnDireccionFacturacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDireccionFacturacion.Location = new System.Drawing.Point(600, 22);
            this.btnDireccionFacturacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnDireccionFacturacion.Name = "btnDireccionFacturacion";
            this.btnDireccionFacturacion.Size = new System.Drawing.Size(43, 34);
            this.btnDireccionFacturacion.TabIndex = 0;
            this.btnDireccionFacturacion.TabStop = false;
            // 
            // btnAgregarDireccionEnvio
            // 
            this.btnAgregarDireccionEnvio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionEnvio.Location = new System.Drawing.Point(600, 242);
            this.btnAgregarDireccionEnvio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnAgregarDireccionEnvio.Name = "btnAgregarDireccionEnvio";
            this.btnAgregarDireccionEnvio.Size = new System.Drawing.Size(43, 34);
            this.btnAgregarDireccionEnvio.TabIndex = 0;
            this.btnAgregarDireccionEnvio.TabStop = false;
            // 
            // txtDireccionEnvio
            // 
            this.txtDireccionEnvio.Location = new System.Drawing.Point(201, 286);
            this.txtDireccionEnvio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtDireccionEnvio.MenuManager = this.mainRibbonControl;
            this.txtDireccionEnvio.Name = "txtDireccionEnvio";
            this.txtDireccionEnvio.Properties.ReadOnly = true;
            this.txtDireccionEnvio.Size = new System.Drawing.Size(388, 165);
            this.txtDireccionEnvio.TabIndex = 0;
            this.txtDireccionEnvio.TabStop = false;
            // 
            // txtDireccionFacturacion
            // 
            this.txtDireccionFacturacion.Location = new System.Drawing.Point(201, 67);
            this.txtDireccionFacturacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtDireccionFacturacion.MenuManager = this.mainRibbonControl;
            this.txtDireccionFacturacion.Name = "txtDireccionFacturacion";
            this.txtDireccionFacturacion.Properties.ReadOnly = true;
            this.txtDireccionFacturacion.Size = new System.Drawing.Size(388, 165);
            this.txtDireccionFacturacion.TabIndex = 0;
            this.txtDireccionFacturacion.TabStop = false;
            // 
            // cbDireccionesEnvio
            // 
            this.cbDireccionesEnvio.Location = new System.Drawing.Point(201, 242);
            this.cbDireccionesEnvio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbDireccionesEnvio.MenuManager = this.mainRibbonControl;
            this.cbDireccionesEnvio.Name = "cbDireccionesEnvio";
            this.cbDireccionesEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesEnvio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesEnvio.Size = new System.Drawing.Size(388, 24);
            this.cbDireccionesEnvio.TabIndex = 1;
            // 
            // lblDireccionEnvio
            // 
            this.lblDireccionEnvio.Location = new System.Drawing.Point(20, 246);
            this.lblDireccionEnvio.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblDireccionEnvio.Name = "lblDireccionEnvio";
            this.lblDireccionEnvio.Size = new System.Drawing.Size(92, 17);
            this.lblDireccionEnvio.TabIndex = 78;
            this.lblDireccionEnvio.Text = "Dirección envío";
            // 
            // cbDireccionesFacturacion
            // 
            this.cbDireccionesFacturacion.Location = new System.Drawing.Point(201, 22);
            this.cbDireccionesFacturacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbDireccionesFacturacion.MenuManager = this.mainRibbonControl;
            this.cbDireccionesFacturacion.Name = "cbDireccionesFacturacion";
            this.cbDireccionesFacturacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesFacturacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesFacturacion.Size = new System.Drawing.Size(388, 24);
            this.cbDireccionesFacturacion.TabIndex = 0;
            // 
            // lblDireccionFacturacion
            // 
            this.lblDireccionFacturacion.Location = new System.Drawing.Point(20, 26);
            this.lblDireccionFacturacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.xtraTabPageFinanzas.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabPageFinanzas.Name = "xtraTabPageFinanzas";
            this.xtraTabPageFinanzas.Size = new System.Drawing.Size(1394, 654);
            this.xtraTabPageFinanzas.Text = "Finanzas";
            // 
            // cbProyectos
            // 
            this.cbProyectos.Location = new System.Drawing.Point(201, 110);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbProyectos.MenuManager = this.mainRibbonControl;
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProyectos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbProyectos.Size = new System.Drawing.Size(388, 24);
            this.cbProyectos.TabIndex = 146;
            // 
            // lblProyectos
            // 
            this.lblProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProyectos.Location = new System.Drawing.Point(20, 112);
            this.lblProyectos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(55, 17);
            this.lblProyectos.TabIndex = 147;
            this.lblProyectos.Text = "Proyecto";
            // 
            // cbCanales
            // 
            this.cbCanales.Location = new System.Drawing.Point(201, 152);
            this.cbCanales.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbCanales.MenuManager = this.mainRibbonControl;
            this.cbCanales.Name = "cbCanales";
            this.cbCanales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCanales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCanales.Size = new System.Drawing.Size(388, 24);
            this.cbCanales.TabIndex = 143;
            // 
            // lblCanal
            // 
            this.lblCanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCanal.Location = new System.Drawing.Point(20, 153);
            this.lblCanal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(36, 17);
            this.lblCanal.TabIndex = 144;
            this.lblCanal.Text = "Canal";
            // 
            // lbReferencias
            // 
            this.lbReferencias.Location = new System.Drawing.Point(201, 333);
            this.lbReferencias.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lbReferencias.Name = "lbReferencias";
            this.lbReferencias.Size = new System.Drawing.Size(388, 190);
            this.lbReferencias.TabIndex = 88;
            this.lbReferencias.Visible = false;
            // 
            // btnReferencias
            // 
            this.btnReferencias.Location = new System.Drawing.Point(201, 285);
            this.btnReferencias.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnReferencias.Name = "btnReferencias";
            this.btnReferencias.Size = new System.Drawing.Size(388, 41);
            this.btnReferencias.TabIndex = 0;
            this.btnReferencias.TabStop = false;
            this.btnReferencias.Text = "Referencias";
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.Location = new System.Drawing.Point(23, 245);
            this.lblOrdenCompra.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(110, 17);
            this.lblOrdenCompra.TabIndex = 86;
            this.lblOrdenCompra.Text = "Orden de compra";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(201, 241);
            this.txtOrdenCompra.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.MaxLength = 15;
            this.txtOrdenCompra.Size = new System.Drawing.Size(388, 24);
            this.txtOrdenCompra.TabIndex = 4;
            // 
            // lblCuentaPago
            // 
            this.lblCuentaPago.Location = new System.Drawing.Point(23, 200);
            this.lblCuentaPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCuentaPago.Name = "lblCuentaPago";
            this.lblCuentaPago.Size = new System.Drawing.Size(100, 17);
            this.lblCuentaPago.TabIndex = 84;
            this.lblCuentaPago.Text = "Cuenta de pago";
            // 
            // txtCuentaPago
            // 
            this.txtCuentaPago.Location = new System.Drawing.Point(201, 196);
            this.txtCuentaPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCuentaPago.Name = "txtCuentaPago";
            this.txtCuentaPago.Properties.MaxLength = 18;
            this.txtCuentaPago.Size = new System.Drawing.Size(388, 24);
            this.txtCuentaPago.TabIndex = 3;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(201, 67);
            this.cbMetodosPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbMetodosPago.MenuManager = this.mainRibbonControl;
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Size = new System.Drawing.Size(388, 24);
            this.cbMetodosPago.TabIndex = 1;
            // 
            // lblMetodosPago
            // 
            this.lblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodosPago.Location = new System.Drawing.Point(20, 71);
            this.lblMetodosPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(103, 17);
            this.lblMetodosPago.TabIndex = 82;
            this.lblMetodosPago.Text = "Método de pago";
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(201, 22);
            this.cbCondicionesPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbCondicionesPago.MenuManager = this.mainRibbonControl;
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Size = new System.Drawing.Size(388, 24);
            this.cbCondicionesPago.TabIndex = 0;
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCondicionesPago.Location = new System.Drawing.Point(20, 26);
            this.lblCondicionesPago.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
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
            this.xtraTabPageDocumentoElectronico.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabPageDocumentoElectronico.Name = "xtraTabPageDocumentoElectronico";
            this.xtraTabPageDocumentoElectronico.Size = new System.Drawing.Size(1394, 654);
            this.xtraTabPageDocumentoElectronico.Text = "Documento electrónico";
            // 
            // cbGlobal
            // 
            this.cbGlobal.Location = new System.Drawing.Point(856, 71);
            this.cbGlobal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbGlobal.MenuManager = this.mainRibbonControl;
            this.cbGlobal.Name = "cbGlobal";
            this.cbGlobal.Properties.Caption = "Factura global";
            this.cbGlobal.Size = new System.Drawing.Size(233, 21);
            this.cbGlobal.TabIndex = 109;
            // 
            // btnGenerarSustitucion
            // 
            this.btnGenerarSustitucion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarSustitucion.Location = new System.Drawing.Point(20, 781);
            this.btnGenerarSustitucion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnGenerarSustitucion.Name = "btnGenerarSustitucion";
            this.btnGenerarSustitucion.Size = new System.Drawing.Size(477, 41);
            this.btnGenerarSustitucion.TabIndex = 108;
            this.btnGenerarSustitucion.TabStop = false;
            this.btnGenerarSustitucion.Text = "Generar sustitución";
            // 
            // btnEliminarDE
            // 
            this.btnEliminarDE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEliminarDE.Location = new System.Drawing.Point(584, 781);
            this.btnEliminarDE.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnEliminarDE.Name = "btnEliminarDE";
            this.btnEliminarDE.Size = new System.Drawing.Size(243, 41);
            this.btnEliminarDE.TabIndex = 107;
            this.btnEliminarDE.TabStop = false;
            this.btnEliminarDE.Text = "Elimar registro";
            // 
            // lblRFC
            // 
            this.lblRFC.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblRFC.Appearance.Options.UseForeColor = true;
            this.lblRFC.Location = new System.Drawing.Point(532, 34);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(26, 17);
            this.lblRFC.TabIndex = 106;
            this.lblRFC.Text = "RFC";
            // 
            // btnGenerarRFCGenerico
            // 
            this.btnGenerarRFCGenerico.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarRFCGenerico.Location = new System.Drawing.Point(223, 679);
            this.btnGenerarRFCGenerico.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnGenerarRFCGenerico.Name = "btnGenerarRFCGenerico";
            this.btnGenerarRFCGenerico.Size = new System.Drawing.Size(275, 41);
            this.btnGenerarRFCGenerico.TabIndex = 105;
            this.btnGenerarRFCGenerico.TabStop = false;
            this.btnGenerarRFCGenerico.Text = "Generar con RFC genérico";
            // 
            // lblCancelacionMasiva
            // 
            this.lblCancelacionMasiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelacionMasiva.Location = new System.Drawing.Point(660, 730);
            this.lblCancelacionMasiva.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCancelacionMasiva.Name = "lblCancelacionMasiva";
            this.lblCancelacionMasiva.Size = new System.Drawing.Size(120, 17);
            this.lblCancelacionMasiva.TabIndex = 104;
            this.lblCancelacionMasiva.Text = "Cancelación masiva";
            // 
            // lblUUIDErrorCancelacion
            // 
            this.lblUUIDErrorCancelacion.Location = new System.Drawing.Point(856, 475);
            this.lblUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblUUIDErrorCancelacion.Name = "lblUUIDErrorCancelacion";
            this.lblUUIDErrorCancelacion.Size = new System.Drawing.Size(167, 17);
            this.lblUUIDErrorCancelacion.TabIndex = 103;
            this.lblUUIDErrorCancelacion.Text = "UUIDs con error al cancelar";
            this.lblUUIDErrorCancelacion.Visible = false;
            // 
            // lblUUIDPorCancelar
            // 
            this.lblUUIDPorCancelar.Location = new System.Drawing.Point(856, 166);
            this.lblUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblUUIDPorCancelar.Name = "lblUUIDPorCancelar";
            this.lblUUIDPorCancelar.Size = new System.Drawing.Size(117, 17);
            this.lblUUIDPorCancelar.TabIndex = 102;
            this.lblUUIDPorCancelar.Text = "UUIDs por cancelar";
            this.lblUUIDPorCancelar.Visible = false;
            // 
            // txtUUIDErrorCancelacion
            // 
            this.txtUUIDErrorCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDErrorCancelacion.Location = new System.Drawing.Point(856, 507);
            this.txtUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtUUIDErrorCancelacion.Name = "txtUUIDErrorCancelacion";
            this.txtUUIDErrorCancelacion.Size = new System.Drawing.Size(581, 160);
            this.txtUUIDErrorCancelacion.TabIndex = 101;
            this.txtUUIDErrorCancelacion.Text = "";
            this.txtUUIDErrorCancelacion.Visible = false;
            // 
            // txtUUIDPorCancelar
            // 
            this.txtUUIDPorCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDPorCancelar.Location = new System.Drawing.Point(856, 200);
            this.txtUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtUUIDPorCancelar.Name = "txtUUIDPorCancelar";
            this.txtUUIDPorCancelar.Size = new System.Drawing.Size(581, 259);
            this.txtUUIDPorCancelar.TabIndex = 100;
            this.txtUUIDPorCancelar.Text = "";
            this.txtUUIDPorCancelar.Visible = false;
            // 
            // btnCancelacionMasiva
            // 
            this.btnCancelacionMasiva.Location = new System.Drawing.Point(1209, 679);
            this.btnCancelacionMasiva.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnCancelacionMasiva.Name = "btnCancelacionMasiva";
            this.btnCancelacionMasiva.Size = new System.Drawing.Size(232, 41);
            this.btnCancelacionMasiva.TabIndex = 99;
            this.btnCancelacionMasiva.Text = "Cancelación masiva";
            this.btnCancelacionMasiva.UseVisualStyleBackColor = true;
            this.btnCancelacionMasiva.Visible = false;
            // 
            // btnEstadoCFDI
            // 
            this.btnEstadoCFDI.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEstadoCFDI.Location = new System.Drawing.Point(584, 679);
            this.btnEstadoCFDI.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnEstadoCFDI.Name = "btnEstadoCFDI";
            this.btnEstadoCFDI.Size = new System.Drawing.Size(65, 41);
            this.btnEstadoCFDI.TabIndex = 0;
            this.btnEstadoCFDI.TabStop = false;
            // 
            // lblImportarFolioFiscal
            // 
            this.lblImportarFolioFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImportarFolioFiscal.Location = new System.Drawing.Point(20, 730);
            this.lblImportarFolioFiscal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblImportarFolioFiscal.Name = "lblImportarFolioFiscal";
            this.lblImportarFolioFiscal.Size = new System.Drawing.Size(117, 17);
            this.lblImportarFolioFiscal.TabIndex = 97;
            this.lblImportarFolioFiscal.Text = "Importar folio fiscal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancelar.Location = new System.Drawing.Point(660, 679);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 41);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(199, 71);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(628, 24);
            this.cbUsoPrincipal.TabIndex = 1;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(20, 77);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(78, 17);
            this.lblUsoPrincipal.TabIndex = 96;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnActualizar.Location = new System.Drawing.Point(505, 679);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 41);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerar.Location = new System.Drawing.Point(20, 679);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(192, 41);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "Generar";
            // 
            // txtSelloCFD
            // 
            this.txtSelloCFD.Enabled = false;
            this.txtSelloCFD.Location = new System.Drawing.Point(20, 503);
            this.txtSelloCFD.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtSelloCFD.MenuManager = this.mainRibbonControl;
            this.txtSelloCFD.Name = "txtSelloCFD";
            this.txtSelloCFD.Size = new System.Drawing.Size(804, 165);
            this.txtSelloCFD.TabIndex = 3;
            // 
            // lblSelloCFD
            // 
            this.lblSelloCFD.Location = new System.Drawing.Point(20, 471);
            this.lblSelloCFD.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblSelloCFD.Name = "lblSelloCFD";
            this.lblSelloCFD.Size = new System.Drawing.Size(59, 17);
            this.lblSelloCFD.TabIndex = 94;
            this.lblSelloCFD.Text = "Sello CFD";
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Enabled = false;
            this.txtCadenaOriginal.Location = new System.Drawing.Point(20, 199);
            this.txtCadenaOriginal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCadenaOriginal.MenuManager = this.mainRibbonControl;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(804, 264);
            this.txtCadenaOriginal.TabIndex = 2;
            // 
            // lblCadenaOriginal
            // 
            this.lblCadenaOriginal.Location = new System.Drawing.Point(20, 166);
            this.lblCadenaOriginal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblCadenaOriginal.Name = "lblCadenaOriginal";
            this.lblCadenaOriginal.Size = new System.Drawing.Size(98, 17);
            this.lblCadenaOriginal.TabIndex = 92;
            this.lblCadenaOriginal.Text = "Cadena original";
            // 
            // lblFolioFiscal
            // 
            this.lblFolioFiscal.Location = new System.Drawing.Point(20, 122);
            this.lblFolioFiscal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblFolioFiscal.Name = "lblFolioFiscal";
            this.lblFolioFiscal.Size = new System.Drawing.Size(62, 17);
            this.lblFolioFiscal.TabIndex = 90;
            this.lblFolioFiscal.Text = "Folio fiscal";
            // 
            // txtFolioFiscal
            // 
            this.txtFolioFiscal.Location = new System.Drawing.Point(199, 115);
            this.txtFolioFiscal.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtFolioFiscal.Name = "txtFolioFiscal";
            this.txtFolioFiscal.Properties.ReadOnly = true;
            this.txtFolioFiscal.Size = new System.Drawing.Size(628, 24);
            this.txtFolioFiscal.TabIndex = 1;
            // 
            // cbGenerarDocumentoElectronico
            // 
            this.cbGenerarDocumentoElectronico.Location = new System.Drawing.Point(199, 30);
            this.cbGenerarDocumentoElectronico.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.cbGenerarDocumentoElectronico.MenuManager = this.mainRibbonControl;
            this.cbGenerarDocumentoElectronico.Name = "cbGenerarDocumentoElectronico";
            this.cbGenerarDocumentoElectronico.Properties.Caption = "Generar documento electrónico";
            this.cbGenerarDocumentoElectronico.Size = new System.Drawing.Size(323, 21);
            this.cbGenerarDocumentoElectronico.TabIndex = 0;
            // 
            // xtraTabPageAnexos
            // 
            this.xtraTabPageAnexos.Controls.Add(this.btnVisualizarAnexo);
            this.xtraTabPageAnexos.Controls.Add(this.btnAnexos);
            this.xtraTabPageAnexos.Controls.Add(this.lbAnexos);
            this.xtraTabPageAnexos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.xtraTabPageAnexos.Name = "xtraTabPageAnexos";
            this.xtraTabPageAnexos.Size = new System.Drawing.Size(1394, 654);
            this.xtraTabPageAnexos.Text = "Anexos";
            // 
            // btnVisualizarAnexo
            // 
            this.btnVisualizarAnexo.Location = new System.Drawing.Point(457, 366);
            this.btnVisualizarAnexo.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnVisualizarAnexo.Name = "btnVisualizarAnexo";
            this.btnVisualizarAnexo.Size = new System.Drawing.Size(172, 41);
            this.btnVisualizarAnexo.TabIndex = 91;
            this.btnVisualizarAnexo.TabStop = false;
            this.btnVisualizarAnexo.Text = "Visualizar";
            // 
            // btnAnexos
            // 
            this.btnAnexos.Location = new System.Drawing.Point(640, 366);
            this.btnAnexos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnAnexos.Name = "btnAnexos";
            this.btnAnexos.Size = new System.Drawing.Size(172, 41);
            this.btnAnexos.TabIndex = 90;
            this.btnAnexos.TabStop = false;
            this.btnAnexos.Text = "Anexos";
            // 
            // lbAnexos
            // 
            this.lbAnexos.Location = new System.Drawing.Point(20, 26);
            this.lbAnexos.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lbAnexos.Name = "lbAnexos";
            this.lbAnexos.Size = new System.Drawing.Size(792, 330);
            this.lbAnexos.TabIndex = 89;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1424, 708);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1404, 688);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Click += new System.EventHandler(this.layoutControlItem1_Click_1);
            // 
            // frmVPram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 798);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.mainRibbonControl);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVPram";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.FormVistaPrevia_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnticipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCOD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactVencidas.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbReserva.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneral;
        private DevExpress.XtraEditors.CheckEdit cbAnticipo;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarCerrar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarNuevo;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private DevExpress.XtraBars.BarButtonItem bbiRecargar;
        private DevExpress.XtraBars.BarButtonItem bbiBuscar;
        private DevExpress.XtraBars.BarButtonItem bbiPrimero;
        private DevExpress.XtraBars.BarButtonItem bbiAnterior;
        private DevExpress.XtraBars.BarButtonItem bbiUltimo;
        private DevExpress.XtraBars.BarButtonItem bbiSiguiente;
        private DevExpress.XtraBars.BarButtonItem bbiNuevo;
        private DevExpress.XtraBars.BarSubItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoSocio;
        private DevExpress.XtraBars.BarSubItem bbiCopiar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMapaRelaciones;
        private DevExpress.XtraBars.BarSubItem bbiPDF;
        private DevExpress.XtraBars.BarButtonItem bbiEnviar;
        private DevExpress.XtraBars.BarStaticItem bbiCancelar;
        private DevExpress.XtraBars.BarStaticItem bbiCerrar;
        private DevExpress.XtraBars.BarButtonItem bbiPagar;
        private DevExpress.XtraBars.BarButtonItem bbiXLSX;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.BarButtonItem bbiAjustarColumnas;
        private DevExpress.XtraBars.BarButtonItem bbiDuplicar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelacionManualCFDI;
        private DevExpress.XtraBars.BarButtonItem bbiParametrizaciones;
        private DevExpress.XtraBars.BarButtonItem bbiAbrir;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup searchRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHerramientas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHerramientas;
        private DevExpress.XtraEditors.CheckEdit cbCOD;
        private DevExpress.XtraEditors.LabelControl lbMensajeC;
        private DevExpress.XtraEditors.LabelControl lbFact;
        private DevExpress.XtraEditors.LabelControl lbCredito;
        private DevExpress.XtraEditors.TextEdit txtFactVencidas;
        private DevExpress.XtraEditors.TextEdit txtCreditoDisponible;
        private System.Windows.Forms.Button btnStat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCargaArticulos;
        private DevExpress.XtraEditors.SimpleButton btnDescuentosEspeciales;
        private DevExpress.XtraEditors.TextEdit txtArticulo;
        private DevExpress.XtraEditors.TextEdit txtFechaVigencia;
        private DevExpress.XtraEditors.LabelControl lblFechaVigencia;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblEnviado;
        private DevExpress.XtraEditors.LabelControl lblAlmacenDestino;
        private DevExpress.XtraEditors.LabelControl lblAlmacenOrigen;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblClase;
        private DevExpress.XtraEditors.LookUpEdit cbAlmacenDestino;
        private DevExpress.XtraEditors.LookUpEdit cbAlmacenOrigen;
        private DevExpress.XtraEditors.LabelControl lblUtilidad;
        private DevExpress.XtraEditors.DateEdit deFechaVencimiento;
        private DevExpress.XtraEditors.DateEdit deFechaContabilizacion;
        private DevExpress.XtraEditors.TextEdit txtNumeroDocumentoExterno;
        private DevExpress.XtraEditors.LabelControl lblArticulos;
        private DevExpress.XtraEditors.LabelControl lblPartidas;
        private DevExpress.XtraEditors.LabelControl lblReferencia;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private DevExpress.XtraEditors.CheckEdit cbReserva;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblCodigoSN;
        private DevExpress.XtraEditors.LabelControl lblID;
        private System.Windows.Forms.Label lblImpreso;
        private System.Windows.Forms.Label lblCancelado;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LookUpEdit cbMonedas;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblMonedas;
        private DevExpress.XtraEditors.TextEdit txtFechaCreacion;
        private DevExpress.XtraEditors.LabelControl lblFechaCreacion;
        private DevExpress.XtraEditors.LookUpEdit cbSeries;
        private DevExpress.XtraEditors.LabelControl lblNumeroDocumento;
        private DevExpress.XtraEditors.TextEdit txtNumeroDocumento;
        private DevExpress.XtraEditors.TextEdit txtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl lblFechaDocumento;
        private DevExpress.XtraEditors.LabelControl lblFechaVencimiento;
        private DevExpress.XtraEditors.LabelControl lblFechaContabilizacion;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private DevExpress.XtraEditors.LabelControl lblComentario;
        private DevExpress.XtraEditors.LookUpEdit cbVendedores;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblVendedores;
        private DevExpress.XtraEditors.LabelControl lblImporteAplicado;
        private DevExpress.XtraEditors.TextEdit txtImporteAplicado;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl lblImpuesto;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtCodigoSN;
        private DevExpress.XtraEditors.LabelControl lblSocio;
        private DevExpress.XtraGrid.GridControl gcPartidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartidas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPeso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbUnidadesMedida;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoEmpaque;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbTiposEmpaques;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadPaquete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSKU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecioPieza;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnListaPrecio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbListasPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPorcentajeDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecioNeto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAlmacen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbAlmacenes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUbicacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbUbicaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAlmacenDestino;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUbicacionDestino;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComentario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescuentoEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumeroPedimento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbAlmacenesDestino;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLogistica;
        private DevExpress.XtraEditors.SimpleButton btnEditarDireccionOrigen;
        private DevExpress.XtraEditors.SimpleButton btnAgregarDireccionOrigen;
        private DevExpress.XtraEditors.MemoEdit txtDireccionOrigen;
        private DevExpress.XtraEditors.LookUpEdit cbDireccionesOrigen;
        private DevExpress.XtraEditors.LabelControl lblDireccionOrigen;
        private DevExpress.XtraEditors.SimpleButton btnEditarDireccionFacturacion;
        private DevExpress.XtraEditors.SimpleButton btnEditarDireccionEnvio;
        private DevExpress.XtraEditors.LabelControl lblDistancia;
        private DevExpress.XtraEditors.TextEdit txtDistancia;
        private DevExpress.XtraEditors.LookUpEdit cbRemolques;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblRemolque;
        private DevExpress.XtraEditors.BarCodeControl bcID;
        private DevExpress.XtraEditors.LookUpEdit cbRutas;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblRuta;
        private DevExpress.XtraEditors.GroupControl gcSeguimiento;
        private DevExpress.XtraEditors.ComboBoxEdit cbEstadoSeguimiento;
        private DevExpress.XtraEditors.CheckEdit cbSeguimiento;
        private DevExpress.XtraEditors.LookUpEdit cbCausalidades;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblCausalidades;
        private DevExpress.XtraEditors.LookUpEdit cbSupervisores;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblSupervisores;
        private DevExpress.XtraEditors.CheckEdit cbForaneo;
        private DevExpress.XtraEditors.LookUpEdit cbVehiculos;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblVehiculo;
        private DevExpress.XtraEditors.LookUpEdit cbChoferes;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblChofer;
        private DevExpress.XtraEditors.SimpleButton btnSolicitarEtiquetas;
        private DevExpress.XtraEditors.LabelControl lblActualizacion;
        private System.Windows.Forms.Label lblSincronizacion;
        private DevExpress.XtraEditors.LookUpEdit cbPersonasContacto;
        private DevExpress.XtraEditors.LabelControl lblPersonasContacto;
        private DevExpress.XtraEditors.LookUpEdit cbClasesExpedicion;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblClaseExpedicion;
        private DevExpress.XtraEditors.LabelControl lblCreacion;
        private DevExpress.XtraEditors.SimpleButton btnDireccionFacturacion;
        private DevExpress.XtraEditors.SimpleButton btnAgregarDireccionEnvio;
        private DevExpress.XtraEditors.MemoEdit txtDireccionEnvio;
        private DevExpress.XtraEditors.MemoEdit txtDireccionFacturacion;
        private DevExpress.XtraEditors.LookUpEdit cbDireccionesEnvio;
        private DevExpress.XtraEditors.LabelControl lblDireccionEnvio;
        private DevExpress.XtraEditors.LookUpEdit cbDireccionesFacturacion;
        private DevExpress.XtraEditors.LabelControl lblDireccionFacturacion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFinanzas;
        private DevExpress.XtraEditors.LookUpEdit cbProyectos;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblProyectos;
        private DevExpress.XtraEditors.LookUpEdit cbCanales;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblCanal;
        private DevExpress.XtraEditors.ListBoxControl lbReferencias;
        private DevExpress.XtraEditors.SimpleButton btnReferencias;
        private DevExpress.XtraEditors.LabelControl lblOrdenCompra;
        private DevExpress.XtraEditors.TextEdit txtOrdenCompra;
        private DevExpress.XtraEditors.LabelControl lblCuentaPago;
        private DevExpress.XtraEditors.TextEdit txtCuentaPago;
        private DevExpress.XtraEditors.LookUpEdit cbMetodosPago;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblMetodosPago;
        private DevExpress.XtraEditors.LookUpEdit cbCondicionesPago;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblCondicionesPago;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentoElectronico;
        private DevExpress.XtraEditors.CheckEdit cbGlobal;
        private DevExpress.XtraEditors.SimpleButton btnGenerarSustitucion;
        private DevExpress.XtraEditors.SimpleButton btnEliminarDE;
        private DevExpress.XtraEditors.LabelControl lblRFC;
        private DevExpress.XtraEditors.SimpleButton btnGenerarRFCGenerico;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblCancelacionMasiva;
        private DevExpress.XtraEditors.LabelControl lblUUIDErrorCancelacion;
        private DevExpress.XtraEditors.LabelControl lblUUIDPorCancelar;
        private System.Windows.Forms.RichTextBox txtUUIDErrorCancelacion;
        private System.Windows.Forms.RichTextBox txtUUIDPorCancelar;
        private System.Windows.Forms.Button btnCancelacionMasiva;
        private DevExpress.XtraEditors.SimpleButton btnEstadoCFDI;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblImportarFolioFiscal;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LookUpEdit cbUsoPrincipal;
        private DevExpress.XtraEditors.LabelControl lblUsoPrincipal;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.MemoEdit txtSelloCFD;
        private DevExpress.XtraEditors.LabelControl lblSelloCFD;
        private DevExpress.XtraEditors.MemoEdit txtCadenaOriginal;
        private DevExpress.XtraEditors.LabelControl lblCadenaOriginal;
        private DevExpress.XtraEditors.LabelControl lblFolioFiscal;
        private DevExpress.XtraEditors.TextEdit txtFolioFiscal;
        private DevExpress.XtraEditors.CheckEdit cbGenerarDocumentoElectronico;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAnexos;
        private DevExpress.XtraEditors.SimpleButton btnVisualizarAnexo;
        private DevExpress.XtraEditors.SimpleButton btnAnexos;
        private DevExpress.XtraEditors.ListBoxControl lbAnexos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}