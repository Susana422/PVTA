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
    partial class frmFormPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormPagos));
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
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemDescuentos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiParametrizacionesFormulario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPaquetes = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPartidasAbiertas = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtNumeroDocumentoExterno = new DevExpress.XtraEditors.TextEdit();
            this.lblImporteAplicado = new DevExpress.XtraEditors.LabelControl();
            this.txtImporteAplicado = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiPagosFinanciados = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMapaRelaciones = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEnviar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevoMetodoPago = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblSaldoPendiente = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoPendiente = new DevExpress.XtraEditors.TextEdit();
            this.lblIdentificadorExterno = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.cbPagoACuenta = new DevExpress.XtraEditors.CheckEdit();
            this.txtFechaDocumento = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.cbMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.deFechaContabilizacion = new DevExpress.XtraEditors.DateEdit();
            this.lblSocio = new DevExpress.XtraEditors.LabelControl();
            this.lblReferencia = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.cbSeries = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNumeroDocumento = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaVencimiento = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaVencimiento = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaContabilizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoSN = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtCodigoSN = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageContenido = new DevExpress.XtraTab.XtraTabPage();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPartidaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDocumentoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNumeroDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMetodoPagoSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFolioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMonedaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImporteAplicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbGenero = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPageMediosPago = new DevExpress.XtraTab.XtraTabPage();
            this.gcPagos = new DevExpress.XtraGrid.GridControl();
            this.gvPagos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMetodosPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageDocumentoElectronico = new DevExpress.XtraTab.XtraTabPage();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.btnReferencias = new DevExpress.XtraEditors.SimpleButton();
            this.lblImportarFolioFiscal = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cbMetodoPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMetodosPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerarSustitucion = new DevExpress.XtraEditors.SimpleButton();
            this.txtCadenaOriginal = new DevExpress.XtraEditors.MemoEdit();
            this.lblCadenaOriginal = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioFiscal = new DevExpress.XtraEditors.LabelControl();
            this.txtFolioFiscal = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoPendiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagoACuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenero)).BeginInit();
            this.xtraTabPageMediosPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago)).BeginInit();
            this.xtraTabPageDocumentoElectronico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).BeginInit();
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
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
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
            // bbiSiguiente
            // 
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            // 
            // bbiPartidasAbiertas
            // 
            this.bbiPartidasAbiertas.Caption = "Partidas abiertas";
            this.bbiPartidasAbiertas.Id = 58;
            this.bbiPartidasAbiertas.Name = "bbiPartidasAbiertas";
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
            this.mainRibbonControl.Size = new System.Drawing.Size(967, 0);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.ribbonControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 106);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(962, 702);
            this.panelControl1.TabIndex = 102;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 62);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(958, 638);
            this.layoutControl1.TabIndex = 59;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtNumeroDocumentoExterno);
            this.panelControl3.Controls.Add(this.lblImporteAplicado);
            this.panelControl3.Controls.Add(this.txtImporteAplicado);
            this.panelControl3.Controls.Add(this.lblSaldoPendiente);
            this.panelControl3.Controls.Add(this.txtSaldoPendiente);
            this.panelControl3.Controls.Add(this.lblIdentificadorExterno);
            this.panelControl3.Controls.Add(this.lblTotal);
            this.panelControl3.Controls.Add(this.txtTotal);
            this.panelControl3.Controls.Add(this.txtComentario);
            this.panelControl3.Controls.Add(this.lblComentario);
            this.panelControl3.Controls.Add(this.cbPagoACuenta);
            this.panelControl3.Controls.Add(this.txtFechaDocumento);
            this.panelControl3.Controls.Add(this.lblFechaDocumento);
            this.panelControl3.Controls.Add(this.lblCancelado);
            this.panelControl3.Controls.Add(this.txtTipoCambio);
            this.panelControl3.Controls.Add(this.cbMonedas);
            this.panelControl3.Controls.Add(this.lblMonedas);
            this.panelControl3.Controls.Add(this.deFechaContabilizacion);
            this.panelControl3.Controls.Add(this.lblSocio);
            this.panelControl3.Controls.Add(this.lblReferencia);
            this.panelControl3.Controls.Add(this.txtReferencia);
            this.panelControl3.Controls.Add(this.cbSeries);
            this.panelControl3.Controls.Add(this.lblNumeroDocumento);
            this.panelControl3.Controls.Add(this.txtNumeroDocumento);
            this.panelControl3.Controls.Add(this.txtFechaVencimiento);
            this.panelControl3.Controls.Add(this.lblFechaVencimiento);
            this.panelControl3.Controls.Add(this.lblFechaContabilizacion);
            this.panelControl3.Controls.Add(this.lblCodigoSN);
            this.panelControl3.Controls.Add(this.txtCodigoSN);
            this.panelControl3.Controls.Add(this.lblID);
            this.panelControl3.Controls.Add(this.xtraTabControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(934, 614);
            this.panelControl3.TabIndex = 4;
            // 
            // txtNumeroDocumentoExterno
            // 
            this.txtNumeroDocumentoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumeroDocumentoExterno.Location = new System.Drawing.Point(17, 547);
            this.txtNumeroDocumentoExterno.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumeroDocumentoExterno.Name = "txtNumeroDocumentoExterno";
            this.txtNumeroDocumentoExterno.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumentoExterno.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumeroDocumentoExterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumentoExterno.Size = new System.Drawing.Size(119, 24);
            this.txtNumeroDocumentoExterno.TabIndex = 199;
            this.txtNumeroDocumentoExterno.TabStop = false;
            // 
            // lblImporteAplicado
            // 
            this.lblImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteAplicado.Location = new System.Drawing.Point(565, 503);
            this.lblImporteAplicado.Margin = new System.Windows.Forms.Padding(6);
            this.lblImporteAplicado.Name = "lblImporteAplicado";
            this.lblImporteAplicado.Size = new System.Drawing.Size(105, 17);
            this.lblImporteAplicado.TabIndex = 198;
            this.lblImporteAplicado.Text = "Importe aplicado";
            // 
            // txtImporteAplicado
            // 
            this.txtImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteAplicado.Location = new System.Drawing.Point(712, 499);
            this.txtImporteAplicado.Margin = new System.Windows.Forms.Padding(6);
            this.txtImporteAplicado.MenuManager = this.ribbonControl2;
            this.txtImporteAplicado.Name = "txtImporteAplicado";
            this.txtImporteAplicado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImporteAplicado.Properties.DisplayFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.EditFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.ReadOnly = true;
            this.txtImporteAplicado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImporteAplicado.Size = new System.Drawing.Size(214, 24);
            this.txtImporteAplicado.TabIndex = 197;
            this.txtImporteAplicado.TabStop = false;
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.bbiCancelar,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.bbiImprimir,
            this.bbiPDF,
            this.bbiPagosFinanciados,
            this.bbiMapaRelaciones,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.bbiEnviar,
            this.bbiNuevoMetodoPago,
            this.barButtonItem10});
            this.ribbonControl2.Location = new System.Drawing.Point(2, 2);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl2.MaxItemId = 3;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(958, 60);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Guardar";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Save";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Guardar y cerrar";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Guardar y nuevo";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 6;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Buscar";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.ImageUri.Uri = "Find";
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Primero";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "First";
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Anterior";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.ImageUri.Uri = "Prev";
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Último";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.ImageUri.Uri = "Last";
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Siguiente";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barButtonItem8.ImageOptions.ImageUri.Uri = "Next";
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Nuevo";
            this.barButtonItem9.Id = 1;
            this.barButtonItem9.ImageOptions.ImageUri.Uri = "Add";
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 3;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 6;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.Name = "bbiPDF";
            // 
            // bbiPagosFinanciados
            // 
            this.bbiPagosFinanciados.Caption = "Pagos financiados";
            this.bbiPagosFinanciados.Id = 7;
            this.bbiPagosFinanciados.ImageOptions.ImageUri.Uri = "Currency";
            this.bbiPagosFinanciados.Name = "bbiPagosFinanciados";
            // 
            // bbiMapaRelaciones
            // 
            this.bbiMapaRelaciones.Caption = "Mapa de relaciones";
            this.bbiMapaRelaciones.Id = 8;
            this.bbiMapaRelaciones.ImageOptions.ImageUri.Uri = "BringToFront";
            this.bbiMapaRelaciones.Name = "bbiMapaRelaciones";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Más";
            this.barHeaderItem1.Id = 9;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "Acciones";
            this.barHeaderItem2.Id = 10;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // bbiEnviar
            // 
            this.bbiEnviar.Caption = "Enviar";
            this.bbiEnviar.Id = 11;
            this.bbiEnviar.ImageOptions.ImageUri.Uri = "Mail";
            this.bbiEnviar.Name = "bbiEnviar";
            // 
            // bbiNuevoMetodoPago
            // 
            this.bbiNuevoMetodoPago.Caption = "Nuevo método de pago";
            this.bbiNuevoMetodoPago.Id = 1;
            this.bbiNuevoMetodoPago.ImageOptions.ImageUri.Uri = "AddNewDataSource";
            this.bbiNuevoMetodoPago.Name = "bbiNuevoMetodoPago";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Parametrizaciones de formulario";
            this.barButtonItem10.Id = 2;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ARCHIVO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPDF);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Opciones";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Navegación";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHerramientas});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "HERRAMIENTAS";
            // 
            // ribbonPageGroupHerramientas
            // 
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiMapaRelaciones);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiPagosFinanciados);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoPendiente.Location = new System.Drawing.Point(572, 542);
            this.lblSaldoPendiente.Margin = new System.Windows.Forms.Padding(6);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(99, 17);
            this.lblSaldoPendiente.TabIndex = 196;
            this.lblSaldoPendiente.Text = "Saldo pendiente";
            // 
            // txtSaldoPendiente
            // 
            this.txtSaldoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoPendiente.Location = new System.Drawing.Point(712, 538);
            this.txtSaldoPendiente.Margin = new System.Windows.Forms.Padding(6);
            this.txtSaldoPendiente.MenuManager = this.ribbonControl2;
            this.txtSaldoPendiente.Name = "txtSaldoPendiente";
            this.txtSaldoPendiente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSaldoPendiente.Properties.DisplayFormat.FormatString = "c2";
            this.txtSaldoPendiente.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoPendiente.Properties.EditFormat.FormatString = "c2";
            this.txtSaldoPendiente.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoPendiente.Properties.ReadOnly = true;
            this.txtSaldoPendiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaldoPendiente.Size = new System.Drawing.Size(214, 24);
            this.txtSaldoPendiente.TabIndex = 195;
            this.txtSaldoPendiente.TabStop = false;
            // 
            // lblIdentificadorExterno
            // 
            this.lblIdentificadorExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdentificadorExterno.Location = new System.Drawing.Point(17, 582);
            this.lblIdentificadorExterno.Margin = new System.Windows.Forms.Padding(6);
            this.lblIdentificadorExterno.Name = "lblIdentificadorExterno";
            this.lblIdentificadorExterno.Size = new System.Drawing.Size(9, 17);
            this.lblIdentificadorExterno.TabIndex = 194;
            this.lblIdentificadorExterno.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(649, 587);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 17);
            this.lblTotal.TabIndex = 193;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(712, 578);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotal.MenuManager = this.ribbonControl2;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.EditFormat.FormatString = "c2";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(214, 24);
            this.txtTotal.TabIndex = 192;
            this.txtTotal.TabStop = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentario.Location = new System.Drawing.Point(148, 501);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(6);
            this.txtComentario.MenuManager = this.ribbonControl2;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(326, 103);
            this.txtComentario.TabIndex = 190;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.Location = new System.Drawing.Point(17, 502);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(6);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(74, 17);
            this.lblComentario.TabIndex = 191;
            this.lblComentario.Text = "Comentario";
            // 
            // cbPagoACuenta
            // 
            this.cbPagoACuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPagoACuenta.Enabled = false;
            this.cbPagoACuenta.Location = new System.Drawing.Point(712, 463);
            this.cbPagoACuenta.Margin = new System.Windows.Forms.Padding(6);
            this.cbPagoACuenta.MenuManager = this.ribbonControl2;
            this.cbPagoACuenta.Name = "cbPagoACuenta";
            this.cbPagoACuenta.Properties.Caption = "Pago a cuenta";
            this.cbPagoACuenta.Size = new System.Drawing.Size(214, 21);
            this.cbPagoACuenta.TabIndex = 189;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDocumento.Location = new System.Drawing.Point(767, 131);
            this.txtFechaDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.EditFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.ReadOnly = true;
            this.txtFechaDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaDocumento.Size = new System.Drawing.Size(158, 24);
            this.txtFechaDocumento.TabIndex = 188;
            this.txtFechaDocumento.TabStop = false;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDocumento.Location = new System.Drawing.Point(631, 135);
            this.lblFechaDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(112, 17);
            this.lblFechaDocumento.TabIndex = 187;
            this.lblFechaDocumento.Text = "Fecha documento";
            // 
            // lblCancelado
            // 
            this.lblCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelado.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCancelado.Location = new System.Drawing.Point(474, 23);
            this.lblCancelado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(65, 13);
            this.lblCancelado.TabIndex = 185;
            this.lblCancelado.Text = "Cancelado";
            this.lblCancelado.Visible = false;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(412, 133);
            this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(6);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(117, 24);
            this.txtTipoCambio.TabIndex = 182;
            this.txtTipoCambio.TabStop = false;
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(170, 133);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(6);
            this.cbMonedas.MenuManager = this.ribbonControl2;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbMonedas.Size = new System.Drawing.Size(230, 24);
            this.cbMonedas.TabIndex = 183;
            this.cbMonedas.TabStop = false;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(16, 142);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(6);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 184;
            this.lblMonedas.Text = "Moneda";
            // 
            // deFechaContabilizacion
            // 
            this.deFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaContabilizacion.EditValue = null;
            this.deFechaContabilizacion.Location = new System.Drawing.Point(767, 57);
            this.deFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6);
            this.deFechaContabilizacion.MenuManager = this.ribbonControl2;
            this.deFechaContabilizacion.Name = "deFechaContabilizacion";
            this.deFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Size = new System.Drawing.Size(158, 24);
            this.deFechaContabilizacion.TabIndex = 181;
            // 
            // lblSocio
            // 
            this.lblSocio.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSocio.Appearance.Options.UseFont = true;
            this.lblSocio.Location = new System.Drawing.Point(16, 61);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(6);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(216, 13);
            this.lblSocio.TabIndex = 176;
            this.lblSocio.Text = "Por favor ingrese un socio de negocios";
            // 
            // lblReferencia
            // 
            this.lblReferencia.Location = new System.Drawing.Point(16, 104);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(6);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(64, 17);
            this.lblReferencia.TabIndex = 174;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(170, 95);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(6);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.MaxLength = 18;
            this.txtReferencia.Size = new System.Drawing.Size(230, 24);
            this.txtReferencia.TabIndex = 173;
            // 
            // cbSeries
            // 
            this.cbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeries.Location = new System.Drawing.Point(624, 19);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(6);
            this.cbSeries.MenuManager = this.ribbonControl2;
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbSeries.Size = new System.Drawing.Size(131, 24);
            this.cbSeries.TabIndex = 162;
            this.cbSeries.TabStop = false;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(593, 23);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDocumento.TabIndex = 167;
            this.lblNumeroDocumento.Text = "N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(767, 19);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(158, 24);
            this.txtNumeroDocumento.TabIndex = 163;
            this.txtNumeroDocumento.TabStop = false;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(766, 93);
            this.txtFechaVencimiento.Margin = new System.Windows.Forms.Padding(6);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaVencimiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVencimiento.Properties.EditFormat.FormatString = "d";
            this.txtFechaVencimiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVencimiento.Properties.ReadOnly = true;
            this.txtFechaVencimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(158, 24);
            this.txtFechaVencimiento.TabIndex = 166;
            this.txtFechaVencimiento.TabStop = false;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(624, 97);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 17);
            this.lblFechaVencimiento.TabIndex = 165;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(607, 61);
            this.lblFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(132, 17);
            this.lblFechaContabilizacion.TabIndex = 164;
            this.lblFechaContabilizacion.Text = "Fecha contabilización";
            // 
            // lblCodigoSN
            // 
            this.lblCodigoSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoSN.Location = new System.Drawing.Point(16, 20);
            this.lblCodigoSN.Margin = new System.Windows.Forms.Padding(6);
            this.lblCodigoSN.Name = "lblCodigoSN";
            this.lblCodigoSN.Size = new System.Drawing.Size(66, 17);
            this.lblCodigoSN.TabIndex = 160;
            this.lblCodigoSN.Text = "Código SN";
            // 
            // txtCodigoSN
            // 
            this.txtCodigoSN.Location = new System.Drawing.Point(170, 19);
            this.txtCodigoSN.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoSN.Name = "txtCodigoSN";
            this.txtCodigoSN.Size = new System.Drawing.Size(126, 24);
            this.txtCodigoSN.TabIndex = 159;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Location = new System.Drawing.Point(311, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 158;
            this.lblID.Text = "0";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 173);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageContenido;
            this.xtraTabControl1.Size = new System.Drawing.Size(918, 285);
            this.xtraTabControl1.TabIndex = 161;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageContenido,
            this.xtraTabPageMediosPago,
            this.xtraTabPageDocumentoElectronico});
            // 
            // xtraTabPageContenido
            // 
            this.xtraTabPageContenido.Controls.Add(this.gcPartidas);
            this.xtraTabPageContenido.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPageContenido.Name = "xtraTabPageContenido";
            this.xtraTabPageContenido.Size = new System.Drawing.Size(912, 255);
            this.xtraTabPageContenido.Text = "Contenido";
            // 
            // gcPartidas
            // 
            this.gcPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcPartidas.Location = new System.Drawing.Point(0, 0);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(6);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbGenero});
            this.gcPartidas.Size = new System.Drawing.Size(912, 255);
            this.gcPartidas.TabIndex = 70;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartidas});
            // 
            // gvPartidas
            // 
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPartidaID,
            this.gridColumnPagoID,
            this.gridColumnDocumentoID,
            this.gridColumnNumeroDocumento,
            this.gridColumnTipoDocumento,
            this.gridColumnMetodoPagoSAT,
            this.gridColumnFolioFiscal,
            this.gridColumnFecha,
            this.gridColumnFechaVencimiento,
            this.gridColumnMoneda,
            this.gridColumnMonedaID,
            this.gridColumnTipoCambio,
            this.gridColumnTotal,
            this.gridColumnImporteAplicado,
            this.gridColumnSaldo,
            this.gridColumnImporte});
            this.gvPartidas.DetailHeight = 1093;
            this.gvPartidas.FixedLineWidth = 6;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsNavigation.AutoFocusNewRow = true;
            this.gvPartidas.OptionsSelection.MultiSelect = true;
            this.gvPartidas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnPartidaID
            // 
            this.gridColumnPartidaID.Caption = "Partida ID";
            this.gridColumnPartidaID.FieldName = "id";
            this.gridColumnPartidaID.MinWidth = 67;
            this.gridColumnPartidaID.Name = "gridColumnPartidaID";
            this.gridColumnPartidaID.Width = 252;
            // 
            // gridColumnPagoID
            // 
            this.gridColumnPagoID.Caption = "PagoID";
            this.gridColumnPagoID.FieldName = "pago_id";
            this.gridColumnPagoID.MinWidth = 67;
            this.gridColumnPagoID.Name = "gridColumnPagoID";
            this.gridColumnPagoID.Width = 252;
            // 
            // gridColumnDocumentoID
            // 
            this.gridColumnDocumentoID.Caption = "ID";
            this.gridColumnDocumentoID.FieldName = "documento_id";
            this.gridColumnDocumentoID.MinWidth = 67;
            this.gridColumnDocumentoID.Name = "gridColumnDocumentoID";
            this.gridColumnDocumentoID.OptionsColumn.AllowEdit = false;
            this.gridColumnDocumentoID.Visible = true;
            this.gridColumnDocumentoID.VisibleIndex = 1;
            this.gridColumnDocumentoID.Width = 85;
            // 
            // gridColumnNumeroDocumento
            // 
            this.gridColumnNumeroDocumento.Caption = "N° documento";
            this.gridColumnNumeroDocumento.FieldName = "numero_documento";
            this.gridColumnNumeroDocumento.MinWidth = 67;
            this.gridColumnNumeroDocumento.Name = "gridColumnNumeroDocumento";
            this.gridColumnNumeroDocumento.OptionsColumn.AllowEdit = false;
            this.gridColumnNumeroDocumento.Visible = true;
            this.gridColumnNumeroDocumento.VisibleIndex = 2;
            this.gridColumnNumeroDocumento.Width = 80;
            // 
            // gridColumnTipoDocumento
            // 
            this.gridColumnTipoDocumento.Caption = "Tipo";
            this.gridColumnTipoDocumento.FieldName = "clase";
            this.gridColumnTipoDocumento.MaxWidth = 135;
            this.gridColumnTipoDocumento.MinWidth = 67;
            this.gridColumnTipoDocumento.Name = "gridColumnTipoDocumento";
            this.gridColumnTipoDocumento.OptionsColumn.AllowEdit = false;
            this.gridColumnTipoDocumento.Visible = true;
            this.gridColumnTipoDocumento.VisibleIndex = 3;
            this.gridColumnTipoDocumento.Width = 67;
            // 
            // gridColumnMetodoPagoSAT
            // 
            this.gridColumnMetodoPagoSAT.Caption = "Método pago";
            this.gridColumnMetodoPagoSAT.FieldName = "metodo_pago";
            this.gridColumnMetodoPagoSAT.MaxWidth = 135;
            this.gridColumnMetodoPagoSAT.MinWidth = 67;
            this.gridColumnMetodoPagoSAT.Name = "gridColumnMetodoPagoSAT";
            this.gridColumnMetodoPagoSAT.OptionsColumn.AllowEdit = false;
            this.gridColumnMetodoPagoSAT.Visible = true;
            this.gridColumnMetodoPagoSAT.VisibleIndex = 4;
            this.gridColumnMetodoPagoSAT.Width = 67;
            // 
            // gridColumnFolioFiscal
            // 
            this.gridColumnFolioFiscal.Caption = "UUID";
            this.gridColumnFolioFiscal.FieldName = "folio_fiscal";
            this.gridColumnFolioFiscal.Name = "gridColumnFolioFiscal";
            this.gridColumnFolioFiscal.Visible = true;
            this.gridColumnFolioFiscal.VisibleIndex = 5;
            this.gridColumnFolioFiscal.Width = 120;
            // 
            // gridColumnFecha
            // 
            this.gridColumnFecha.Caption = "Fecha";
            this.gridColumnFecha.FieldName = "fecha_documento";
            this.gridColumnFecha.MinWidth = 67;
            this.gridColumnFecha.Name = "gridColumnFecha";
            this.gridColumnFecha.OptionsColumn.AllowEdit = false;
            this.gridColumnFecha.Visible = true;
            this.gridColumnFecha.VisibleIndex = 6;
            this.gridColumnFecha.Width = 67;
            // 
            // gridColumnFechaVencimiento
            // 
            this.gridColumnFechaVencimiento.Caption = "Vencimiento";
            this.gridColumnFechaVencimiento.FieldName = "fecha_vencimiento";
            this.gridColumnFechaVencimiento.MinWidth = 67;
            this.gridColumnFechaVencimiento.Name = "gridColumnFechaVencimiento";
            this.gridColumnFechaVencimiento.OptionsColumn.AllowEdit = false;
            this.gridColumnFechaVencimiento.Visible = true;
            this.gridColumnFechaVencimiento.VisibleIndex = 7;
            this.gridColumnFechaVencimiento.Width = 67;
            // 
            // gridColumnMoneda
            // 
            this.gridColumnMoneda.Caption = "Moneda";
            this.gridColumnMoneda.FieldName = "moneda";
            this.gridColumnMoneda.MinWidth = 67;
            this.gridColumnMoneda.Name = "gridColumnMoneda";
            this.gridColumnMoneda.OptionsColumn.AllowEdit = false;
            this.gridColumnMoneda.Visible = true;
            this.gridColumnMoneda.VisibleIndex = 8;
            this.gridColumnMoneda.Width = 67;
            // 
            // gridColumnMonedaID
            // 
            this.gridColumnMonedaID.Caption = "Moneda ID";
            this.gridColumnMonedaID.FieldName = "moneda_id";
            this.gridColumnMonedaID.MinWidth = 67;
            this.gridColumnMonedaID.Name = "gridColumnMonedaID";
            this.gridColumnMonedaID.Width = 252;
            // 
            // gridColumnTipoCambio
            // 
            this.gridColumnTipoCambio.Caption = "TC";
            this.gridColumnTipoCambio.FieldName = "tipo_cambio";
            this.gridColumnTipoCambio.MinWidth = 67;
            this.gridColumnTipoCambio.Name = "gridColumnTipoCambio";
            this.gridColumnTipoCambio.Visible = true;
            this.gridColumnTipoCambio.VisibleIndex = 9;
            this.gridColumnTipoCambio.Width = 67;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatString = "c2";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "total";
            this.gridColumnTotal.MinWidth = 67;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 10;
            this.gridColumnTotal.Width = 67;
            // 
            // gridColumnImporteAplicado
            // 
            this.gridColumnImporteAplicado.Caption = "Importe aplicado";
            this.gridColumnImporteAplicado.DisplayFormat.FormatString = "c2";
            this.gridColumnImporteAplicado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImporteAplicado.FieldName = "importe_aplicado";
            this.gridColumnImporteAplicado.MinWidth = 67;
            this.gridColumnImporteAplicado.Name = "gridColumnImporteAplicado";
            this.gridColumnImporteAplicado.OptionsColumn.AllowEdit = false;
            this.gridColumnImporteAplicado.Visible = true;
            this.gridColumnImporteAplicado.VisibleIndex = 11;
            this.gridColumnImporteAplicado.Width = 67;
            // 
            // gridColumnSaldo
            // 
            this.gridColumnSaldo.Caption = "Saldo";
            this.gridColumnSaldo.DisplayFormat.FormatString = "c2";
            this.gridColumnSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSaldo.FieldName = "saldo";
            this.gridColumnSaldo.MinWidth = 67;
            this.gridColumnSaldo.Name = "gridColumnSaldo";
            this.gridColumnSaldo.OptionsColumn.AllowEdit = false;
            this.gridColumnSaldo.Visible = true;
            this.gridColumnSaldo.VisibleIndex = 12;
            this.gridColumnSaldo.Width = 67;
            // 
            // gridColumnImporte
            // 
            this.gridColumnImporte.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumnImporte.AppearanceCell.BackColor2 = System.Drawing.Color.Moccasin;
            this.gridColumnImporte.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnImporte.Caption = "Importe a pagar";
            this.gridColumnImporte.DisplayFormat.FormatString = "c2";
            this.gridColumnImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImporte.FieldName = "importe";
            this.gridColumnImporte.MaxWidth = 270;
            this.gridColumnImporte.MinWidth = 270;
            this.gridColumnImporte.Name = "gridColumnImporte";
            this.gridColumnImporte.Visible = true;
            this.gridColumnImporte.VisibleIndex = 13;
            this.gridColumnImporte.Width = 270;
            // 
            // cbGenero
            // 
            this.cbGenero.AutoHeight = false;
            this.cbGenero.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGenero.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("genero", "Genero"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbGenero.Name = "cbGenero";
            // 
            // xtraTabPageMediosPago
            // 
            this.xtraTabPageMediosPago.Controls.Add(this.gcPagos);
            this.xtraTabPageMediosPago.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPageMediosPago.Name = "xtraTabPageMediosPago";
            this.xtraTabPageMediosPago.Size = new System.Drawing.Size(912, 255);
            this.xtraTabPageMediosPago.Text = "Medios de pago";
            // 
            // gcPagos
            // 
            this.gcPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPagos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcPagos.Location = new System.Drawing.Point(0, 0);
            this.gcPagos.MainView = this.gvPagos;
            this.gcPagos.Margin = new System.Windows.Forms.Padding(6);
            this.gcPagos.Name = "gcPagos";
            this.gcPagos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbMetodosPago});
            this.gcPagos.Size = new System.Drawing.Size(912, 255);
            this.gcPagos.TabIndex = 2;
            this.gcPagos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPagos});
            // 
            // gvPagos
            // 
            this.gvPagos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnMetodoPago,
            this.gridColumnTC,
            this.gridColumnReferencia,
            this.gridColumn1,
            this.gridColumn2});
            this.gvPagos.DetailHeight = 1093;
            this.gvPagos.FixedLineWidth = 6;
            this.gvPagos.GridControl = this.gcPagos;
            this.gvPagos.Name = "gvPagos";
            this.gvPagos.OptionsCustomization.AllowColumnMoving = false;
            this.gvPagos.OptionsCustomization.AllowFilter = false;
            this.gvPagos.OptionsCustomization.AllowSort = false;
            this.gvPagos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.MinWidth = 67;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 252;
            // 
            // gridColumnMetodoPago
            // 
            this.gridColumnMetodoPago.Caption = "Método de pago";
            this.gridColumnMetodoPago.ColumnEdit = this.cbMetodosPago;
            this.gridColumnMetodoPago.FieldName = "tipo_metodo_pago_id";
            this.gridColumnMetodoPago.MaxWidth = 405;
            this.gridColumnMetodoPago.MinWidth = 67;
            this.gridColumnMetodoPago.Name = "gridColumnMetodoPago";
            this.gridColumnMetodoPago.Visible = true;
            this.gridColumnMetodoPago.VisibleIndex = 0;
            this.gridColumnMetodoPago.Width = 405;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.AutoHeight = false;
            this.cbMetodosPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Name = "cbMetodosPago";
            // 
            // gridColumnTC
            // 
            this.gridColumnTC.Caption = "TC";
            this.gridColumnTC.FieldName = "tipo_cambio";
            this.gridColumnTC.MaxWidth = 168;
            this.gridColumnTC.MinWidth = 67;
            this.gridColumnTC.Name = "gridColumnTC";
            this.gridColumnTC.Visible = true;
            this.gridColumnTC.VisibleIndex = 1;
            this.gridColumnTC.Width = 157;
            // 
            // gridColumnReferencia
            // 
            this.gridColumnReferencia.Caption = "Referencia";
            this.gridColumnReferencia.FieldName = "referencia";
            this.gridColumnReferencia.MinWidth = 67;
            this.gridColumnReferencia.Name = "gridColumnReferencia";
            this.gridColumnReferencia.Visible = true;
            this.gridColumnReferencia.VisibleIndex = 2;
            this.gridColumnReferencia.Width = 337;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Importe";
            this.gridColumn1.DisplayFormat.FormatString = "C";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "importe";
            this.gridColumn1.MinWidth = 67;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 337;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Total";
            this.gridColumn2.DisplayFormat.FormatString = "C";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "gridColumnTotal";
            this.gridColumn2.MinWidth = 67;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundExpression = "tipo_cambio * importe";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 373;
            // 
            // xtraTabPageDocumentoElectronico
            // 
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.listBoxControl1);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnReferencias);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblImportarFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnCancelar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbMetodoPago);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblMetodosPago);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerarSustitucion);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPageDocumentoElectronico.Name = "xtraTabPageDocumentoElectronico";
            this.xtraTabPageDocumentoElectronico.Size = new System.Drawing.Size(912, 255);
            this.xtraTabPageDocumentoElectronico.Text = "Documento electrónico";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(493, 97);
            this.listBoxControl1.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(263, 110);
            this.listBoxControl1.TabIndex = 112;
            this.listBoxControl1.Visible = false;
            // 
            // btnReferencias
            // 
            this.btnReferencias.Location = new System.Drawing.Point(616, 219);
            this.btnReferencias.Margin = new System.Windows.Forms.Padding(6);
            this.btnReferencias.Name = "btnReferencias";
            this.btnReferencias.Size = new System.Drawing.Size(140, 40);
            this.btnReferencias.TabIndex = 111;
            this.btnReferencias.TabStop = false;
            this.btnReferencias.Text = "Referencias";
            // 
            // lblImportarFolioFiscal
            // 
            this.lblImportarFolioFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImportarFolioFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImportarFolioFiscal.Location = new System.Drawing.Point(1007, 359);
            this.lblImportarFolioFiscal.Margin = new System.Windows.Forms.Padding(6);
            this.lblImportarFolioFiscal.Name = "lblImportarFolioFiscal";
            this.lblImportarFolioFiscal.Size = new System.Drawing.Size(117, 17);
            this.lblImportarFolioFiscal.TabIndex = 109;
            this.lblImportarFolioFiscal.Text = "Importar folio fiscal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancelar.Location = new System.Drawing.Point(341, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.Location = new System.Drawing.Point(132, 20);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(6);
            this.cbMetodoPago.MenuManager = this.ribbonControl2;
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodoPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbMetodoPago.Size = new System.Drawing.Size(524, 24);
            this.cbMetodoPago.TabIndex = 105;
            // 
            // lblMetodosPago
            // 
            this.lblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodosPago.Location = new System.Drawing.Point(4, 16);
            this.lblMetodosPago.Margin = new System.Windows.Forms.Padding(6);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(103, 17);
            this.lblMetodosPago.TabIndex = 106;
            this.lblMetodosPago.Text = "Método de pago";
            // 
            // btnGenerar
            // 
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerar.Location = new System.Drawing.Point(663, 20);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 32);
            this.btnGenerar.TabIndex = 104;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "Generar";
            // 
            // btnGenerarSustitucion
            // 
            this.btnGenerarSustitucion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarSustitucion.Location = new System.Drawing.Point(132, 219);
            this.btnGenerarSustitucion.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerarSustitucion.Name = "btnGenerarSustitucion";
            this.btnGenerarSustitucion.Size = new System.Drawing.Size(180, 40);
            this.btnGenerarSustitucion.TabIndex = 105;
            this.btnGenerarSustitucion.TabStop = false;
            this.btnGenerarSustitucion.Text = "Generar sustitución";
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Enabled = false;
            this.txtCadenaOriginal.Location = new System.Drawing.Point(132, 96);
            this.txtCadenaOriginal.Margin = new System.Windows.Forms.Padding(6);
            this.txtCadenaOriginal.MenuManager = this.ribbonControl2;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(349, 111);
            this.txtCadenaOriginal.TabIndex = 99;
            // 
            // lblCadenaOriginal
            // 
            this.lblCadenaOriginal.Location = new System.Drawing.Point(4, 65);
            this.lblCadenaOriginal.Margin = new System.Windows.Forms.Padding(6);
            this.lblCadenaOriginal.Name = "lblCadenaOriginal";
            this.lblCadenaOriginal.Size = new System.Drawing.Size(98, 17);
            this.lblCadenaOriginal.TabIndex = 101;
            this.lblCadenaOriginal.Text = "Cadena original";
            // 
            // lblFolioFiscal
            // 
            this.lblFolioFiscal.Location = new System.Drawing.Point(4, 43);
            this.lblFolioFiscal.Margin = new System.Windows.Forms.Padding(6);
            this.lblFolioFiscal.Name = "lblFolioFiscal";
            this.lblFolioFiscal.Size = new System.Drawing.Size(62, 17);
            this.lblFolioFiscal.TabIndex = 100;
            this.lblFolioFiscal.Text = "Folio fiscal";
            // 
            // txtFolioFiscal
            // 
            this.txtFolioFiscal.Location = new System.Drawing.Point(132, 60);
            this.txtFolioFiscal.Margin = new System.Windows.Forms.Padding(6);
            this.txtFolioFiscal.Name = "txtFolioFiscal";
            this.txtFolioFiscal.Properties.ReadOnly = true;
            this.txtFolioFiscal.Size = new System.Drawing.Size(524, 24);
            this.txtFolioFiscal.TabIndex = 98;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(958, 638);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(938, 618);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmFormPagos
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 820);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbRoles);
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
            this.Name = "frmFormPagos";
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
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoPendiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagoACuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaContabilizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenero)).EndInit();
            this.xtraTabPageMediosPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago)).EndInit();
            this.xtraTabPageDocumentoElectronico.ResumeLayout(false);
            this.xtraTabPageDocumentoElectronico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).EndInit();
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
        private Panel panel1;
        private DevExpress.Utils.Html.HtmlTemplateCollection lbAnexos;
        private DevExpress.Utils.Html.HtmlTemplateCollection lbReferencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private RibbonPage ribbonPageHerramientas;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemDescuentos;
        private BarButtonItem bbiParametrizacionesFormulario;
        private BarButtonItem bbiPaquetes;
        private RibbonPage mainRibbonPage;
        private RibbonPageGroup mainRibbonPageGroup;
        private BarButtonItem bbiNuevo;
        private BarButtonItem bbiGuardar;
        private BarButtonItem bbiGuardarCerrar;
        private BarButtonItem bbiGuardarNuevo;
        private RibbonPageGroup searchRibbonPageGroup;
        private BarButtonItem bbiBuscar;
        private BarButtonItem bbiPrimero;
        private BarButtonItem bbiAnterior;
        private BarButtonItem bbiSiguiente;
        private BarButtonItem bbiUltimo;
        private BarButtonItem bbiEliminar;
        private BarButtonItem bbiPartidasAbiertas;
        private RibbonControl mainRibbonControl;
        private PanelControl panelControl1;
        private LayoutControl layoutControl1;
        private PanelControl panelControl3;
        private TextEdit txtNumeroDocumentoExterno;
        private LabelControl lblImporteAplicado;
        private TextEdit txtImporteAplicado;
        private RibbonControl ribbonControl2;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem bbiCancelar;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarSubItem bbiImprimir;
        private BarSubItem bbiPDF;
        private BarButtonItem bbiPagosFinanciados;
        private BarButtonItem bbiMapaRelaciones;
        private BarHeaderItem barHeaderItem1;
        private BarHeaderItem barHeaderItem2;
        private BarButtonItem bbiEnviar;
        private BarButtonItem bbiNuevoMetodoPago;
        private BarButtonItem barButtonItem10;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup2;
        private RibbonPageGroup ribbonPageGroup3;
        private RibbonPage ribbonPage2;
        private RibbonPageGroup ribbonPageGroupHerramientas;
        private LabelControl lblSaldoPendiente;
        private TextEdit txtSaldoPendiente;
        private LabelControl lblIdentificadorExterno;
        private LabelControl lblTotal;
        private TextEdit txtTotal;
        private MemoEdit txtComentario;
        private LabelControl lblComentario;
        private CheckEdit cbPagoACuenta;
        private TextEdit txtFechaDocumento;
        private LabelControl lblFechaDocumento;
        private Label lblCancelado;
        private TextEdit txtTipoCambio;
        private LookUpEdit cbMonedas;
        private HyperlinkLabelControl lblMonedas;
        private DateEdit deFechaContabilizacion;
        private LabelControl lblSocio;
        private LabelControl lblReferencia;
        private TextEdit txtReferencia;
        private LookUpEdit cbSeries;
        private LabelControl lblNumeroDocumento;
        private TextEdit txtNumeroDocumento;
        private TextEdit txtFechaVencimiento;
        private LabelControl lblFechaVencimiento;
        private LabelControl lblFechaContabilizacion;
        private HyperlinkLabelControl lblCodigoSN;
        private TextEdit txtCodigoSN;
        private LabelControl lblID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageContenido;
        private DevExpress.XtraGrid.GridControl gcPartidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartidas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartidaID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPagoID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDocumentoID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumeroDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMetodoPagoSAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFolioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMonedaID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImporteAplicado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImporte;
        private RepositoryItemLookUpEdit cbGenero;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMediosPago;
        private DevExpress.XtraGrid.GridControl gcPagos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPagos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMetodoPago;
        private RepositoryItemLookUpEdit cbMetodosPago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentoElectronico;
        private ListBoxControl listBoxControl1;
        private SimpleButton btnReferencias;
        private HyperlinkLabelControl lblImportarFolioFiscal;
        private SimpleButton btnCancelar;
        private LookUpEdit cbMetodoPago;
        private HyperlinkLabelControl lblMetodosPago;
        private SimpleButton btnGenerar;
        private SimpleButton btnGenerarSustitucion;
        private MemoEdit txtCadenaOriginal;
        private LabelControl lblCadenaOriginal;
        private LabelControl lblFolioFiscal;
        private TextEdit txtFolioFiscal;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
    }
}