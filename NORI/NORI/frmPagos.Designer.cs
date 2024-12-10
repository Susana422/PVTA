using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
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
using Microsoft.VisualBasic;
using NoriSDK;
using Padding = System.Windows.Forms.Padding;


namespace NORI
{
    partial class frmPagos
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                components.Dispose();
                if (disposing && components != null)
                {
                    components.Dispose();
                }
                // Dispose(disposing);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiPagosFinanciados = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMapaRelaciones = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEnviar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevoMetodoPago = new DevExpress.XtraBars.BarButtonItem();
            this.bbiParametrizacionesFormulario = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenuPagos = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNumeroDocumentoExterno = new DevExpress.XtraEditors.TextEdit();
            this.lblImporteAplicado = new DevExpress.XtraEditors.LabelControl();
            this.txtImporteAplicado = new DevExpress.XtraEditors.TextEdit();
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
            this.lbReferencias = new DevExpress.XtraEditors.ListBoxControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lbReferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiCancelar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.bbiImprimir,
            this.bbiPDF,
            this.bbiPagosFinanciados,
            this.bbiMapaRelaciones,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.bbiEnviar,
            this.bbiNuevoMetodoPago,
            this.bbiParametrizacionesFormulario});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(6);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1198, 101);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiGuardarCerrar
            // 
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            this.bbiGuardarCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarCerrar_ItemClick);
            // 
            // bbiGuardarNuevo
            // 
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            this.bbiGuardarNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarNuevo_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 6;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiBuscar
            // 
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageOptions.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBuscar_ItemClick);
            // 
            // bbiPrimero
            // 
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageOptions.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiPrimero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrimero_ItemClick);
            // 
            // bbiAnterior
            // 
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageOptions.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAnterior_ItemClick);
            // 
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiUltimo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUltimo_ItemClick);
            // 
            // bbiSiguiente
            // 
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiSiguiente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSiguiente_ItemClick);
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
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
            this.bbiPagosFinanciados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPagosFinanciados_ItemClick);
            // 
            // bbiMapaRelaciones
            // 
            this.bbiMapaRelaciones.Caption = "Mapa de relaciones";
            this.bbiMapaRelaciones.Id = 8;
            this.bbiMapaRelaciones.ImageOptions.ImageUri.Uri = "BringToFront";
            this.bbiMapaRelaciones.Name = "bbiMapaRelaciones";
            this.bbiMapaRelaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMapaRelaciones_ItemClick);
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
            this.bbiEnviar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEnviar_ItemClick);
            // 
            // bbiNuevoMetodoPago
            // 
            this.bbiNuevoMetodoPago.Caption = "Nuevo método de pago";
            this.bbiNuevoMetodoPago.Id = 1;
            this.bbiNuevoMetodoPago.ImageOptions.ImageUri.Uri = "AddNewDataSource";
            this.bbiNuevoMetodoPago.Name = "bbiNuevoMetodoPago";
            this.bbiNuevoMetodoPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoMetodoPago_ItemClick);
            // 
            // bbiParametrizacionesFormulario
            // 
            this.bbiParametrizacionesFormulario.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizacionesFormulario.Id = 2;
            this.bbiParametrizacionesFormulario.Name = "bbiParametrizacionesFormulario";
            this.bbiParametrizacionesFormulario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiParametrizaciones_ItemClick);
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiPDF);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiImprimir);
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
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiMapaRelaciones);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiPagosFinanciados);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiParametrizacionesFormulario);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // popupMenuPagos
            // 
            this.popupMenuPagos.ItemLinks.Add(this.barHeaderItem2);
            this.popupMenuPagos.ItemLinks.Add(this.bbiNuevoMetodoPago);
            this.popupMenuPagos.ItemLinks.Add(this.bbiEnviar);
            this.popupMenuPagos.ItemLinks.Add(this.barHeaderItem1);
            this.popupMenuPagos.ItemLinks.Add(this.bbiCancelar);
            this.popupMenuPagos.Name = "popupMenuPagos";
            this.popupMenuPagos.Ribbon = this.mainRibbonControl;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 101);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1198, 798);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNumeroDocumentoExterno);
            this.panelControl1.Controls.Add(this.lblImporteAplicado);
            this.panelControl1.Controls.Add(this.txtImporteAplicado);
            this.panelControl1.Controls.Add(this.lblSaldoPendiente);
            this.panelControl1.Controls.Add(this.txtSaldoPendiente);
            this.panelControl1.Controls.Add(this.lblIdentificadorExterno);
            this.panelControl1.Controls.Add(this.lblTotal);
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.txtComentario);
            this.panelControl1.Controls.Add(this.lblComentario);
            this.panelControl1.Controls.Add(this.cbPagoACuenta);
            this.panelControl1.Controls.Add(this.txtFechaDocumento);
            this.panelControl1.Controls.Add(this.lblFechaDocumento);
            this.panelControl1.Controls.Add(this.lblCancelado);
            this.panelControl1.Controls.Add(this.txtTipoCambio);
            this.panelControl1.Controls.Add(this.cbMonedas);
            this.panelControl1.Controls.Add(this.lblMonedas);
            this.panelControl1.Controls.Add(this.deFechaContabilizacion);
            this.panelControl1.Controls.Add(this.lblSocio);
            this.panelControl1.Controls.Add(this.lblReferencia);
            this.panelControl1.Controls.Add(this.txtReferencia);
            this.panelControl1.Controls.Add(this.cbSeries);
            this.panelControl1.Controls.Add(this.lblNumeroDocumento);
            this.panelControl1.Controls.Add(this.txtNumeroDocumento);
            this.panelControl1.Controls.Add(this.txtFechaVencimiento);
            this.panelControl1.Controls.Add(this.lblFechaVencimiento);
            this.panelControl1.Controls.Add(this.lblFechaContabilizacion);
            this.panelControl1.Controls.Add(this.lblCodigoSN);
            this.panelControl1.Controls.Add(this.txtCodigoSN);
            this.panelControl1.Controls.Add(this.lblID);
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1174, 774);
            this.panelControl1.TabIndex = 4;
            // 
            // txtNumeroDocumentoExterno
            // 
            this.txtNumeroDocumentoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumeroDocumentoExterno.Location = new System.Drawing.Point(17, 707);
            this.txtNumeroDocumentoExterno.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumeroDocumentoExterno.Name = "txtNumeroDocumentoExterno";
            this.txtNumeroDocumentoExterno.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumentoExterno.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumeroDocumentoExterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumentoExterno.Size = new System.Drawing.Size(119, 24);
            this.txtNumeroDocumentoExterno.TabIndex = 199;
            this.txtNumeroDocumentoExterno.TabStop = false;
            this.txtNumeroDocumentoExterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumentoExterno_KeyDown);
            // 
            // lblImporteAplicado
            // 
            this.lblImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteAplicado.Location = new System.Drawing.Point(805, 663);
            this.lblImporteAplicado.Margin = new System.Windows.Forms.Padding(6);
            this.lblImporteAplicado.Name = "lblImporteAplicado";
            this.lblImporteAplicado.Size = new System.Drawing.Size(90, 15);
            this.lblImporteAplicado.TabIndex = 198;
            this.lblImporteAplicado.Text = "Importe aplicado";
            // 
            // txtImporteAplicado
            // 
            this.txtImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteAplicado.Location = new System.Drawing.Point(952, 659);
            this.txtImporteAplicado.Margin = new System.Windows.Forms.Padding(6);
            this.txtImporteAplicado.MenuManager = this.mainRibbonControl;
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
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoPendiente.Location = new System.Drawing.Point(812, 702);
            this.lblSaldoPendiente.Margin = new System.Windows.Forms.Padding(6);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(85, 15);
            this.lblSaldoPendiente.TabIndex = 196;
            this.lblSaldoPendiente.Text = "Saldo pendiente";
            // 
            // txtSaldoPendiente
            // 
            this.txtSaldoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoPendiente.Location = new System.Drawing.Point(952, 698);
            this.txtSaldoPendiente.Margin = new System.Windows.Forms.Padding(6);
            this.txtSaldoPendiente.MenuManager = this.mainRibbonControl;
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
            this.lblIdentificadorExterno.Location = new System.Drawing.Point(17, 742);
            this.lblIdentificadorExterno.Margin = new System.Windows.Forms.Padding(6);
            this.lblIdentificadorExterno.Name = "lblIdentificadorExterno";
            this.lblIdentificadorExterno.Size = new System.Drawing.Size(6, 15);
            this.lblIdentificadorExterno.TabIndex = 194;
            this.lblIdentificadorExterno.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(889, 747);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 15);
            this.lblTotal.TabIndex = 193;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(952, 738);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotal.MenuManager = this.mainRibbonControl;
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
            this.txtComentario.Location = new System.Drawing.Point(148, 661);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(6);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(326, 103);
            this.txtComentario.TabIndex = 190;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.Location = new System.Drawing.Point(17, 662);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(6);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 15);
            this.lblComentario.TabIndex = 191;
            this.lblComentario.Text = "Comentario";
            // 
            // cbPagoACuenta
            // 
            this.cbPagoACuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPagoACuenta.Enabled = false;
            this.cbPagoACuenta.Location = new System.Drawing.Point(952, 623);
            this.cbPagoACuenta.Margin = new System.Windows.Forms.Padding(6);
            this.cbPagoACuenta.MenuManager = this.mainRibbonControl;
            this.cbPagoACuenta.Name = "cbPagoACuenta";
            this.cbPagoACuenta.Properties.Caption = "Pago a cuenta";
            this.cbPagoACuenta.Size = new System.Drawing.Size(214, 20);
            this.cbPagoACuenta.TabIndex = 189;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDocumento.Location = new System.Drawing.Point(1007, 131);
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
            this.lblFechaDocumento.Location = new System.Drawing.Point(871, 135);
            this.lblFechaDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(96, 15);
            this.lblFechaDocumento.TabIndex = 187;
            this.lblFechaDocumento.Text = "Fecha documento";
            // 
            // lblCancelado
            // 
            this.lblCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelado.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCancelado.Location = new System.Drawing.Point(714, 23);
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
            this.cbMonedas.MenuManager = this.mainRibbonControl;
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
            this.cbMonedas.EditValueChanged += new System.EventHandler(this.cbMonedas_EditValueChanged);
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(16, 142);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(6);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(44, 15);
            this.lblMonedas.TabIndex = 184;
            this.lblMonedas.Text = "Moneda";
            this.lblMonedas.Click += new System.EventHandler(this.lblMonedas_Click);
            // 
            // deFechaContabilizacion
            // 
            this.deFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaContabilizacion.EditValue = null;
            this.deFechaContabilizacion.Location = new System.Drawing.Point(1007, 57);
            this.deFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6);
            this.deFechaContabilizacion.MenuManager = this.mainRibbonControl;
            this.deFechaContabilizacion.Name = "deFechaContabilizacion";
            this.deFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Size = new System.Drawing.Size(158, 24);
            this.deFechaContabilizacion.TabIndex = 181;
            this.deFechaContabilizacion.EditValueChanged += new System.EventHandler(this.deFechaContabilizacion_EditValueChanged);
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
            this.lblReferencia.Size = new System.Drawing.Size(55, 15);
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
            this.cbSeries.Location = new System.Drawing.Point(864, 19);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(6);
            this.cbSeries.MenuManager = this.mainRibbonControl;
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbSeries.Size = new System.Drawing.Size(131, 24);
            this.cbSeries.TabIndex = 162;
            this.cbSeries.TabStop = false;
            this.cbSeries.EditValueChanged += new System.EventHandler(this.cbSeries_EditValueChanged);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(833, 23);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(14, 15);
            this.lblNumeroDocumento.TabIndex = 167;
            this.lblNumeroDocumento.Text = "N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(1007, 19);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(158, 24);
            this.txtNumeroDocumento.TabIndex = 163;
            this.txtNumeroDocumento.TabStop = false;
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(1006, 93);
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
            this.lblFechaVencimiento.Location = new System.Drawing.Point(864, 97);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(100, 15);
            this.lblFechaVencimiento.TabIndex = 165;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(847, 61);
            this.lblFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(114, 15);
            this.lblFechaContabilizacion.TabIndex = 164;
            this.lblFechaContabilizacion.Text = "Fecha contabilización";
            // 
            // lblCodigoSN
            // 
            this.lblCodigoSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoSN.Location = new System.Drawing.Point(16, 20);
            this.lblCodigoSN.Margin = new System.Windows.Forms.Padding(6);
            this.lblCodigoSN.Name = "lblCodigoSN";
            this.lblCodigoSN.Size = new System.Drawing.Size(57, 15);
            this.lblCodigoSN.TabIndex = 160;
            this.lblCodigoSN.Text = "Código SN";
            this.lblCodigoSN.Click += new System.EventHandler(this.lblCodigoSN_Click);
            // 
            // txtCodigoSN
            // 
            this.txtCodigoSN.Location = new System.Drawing.Point(170, 19);
            this.txtCodigoSN.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoSN.Name = "txtCodigoSN";
            this.txtCodigoSN.Size = new System.Drawing.Size(126, 24);
            this.txtCodigoSN.TabIndex = 159;
            this.txtCodigoSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoSN_KeyDown);
            this.txtCodigoSN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCodigoSN_PreviewKeyDown);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Location = new System.Drawing.Point(311, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(6, 15);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(1158, 445);
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
            this.xtraTabPageContenido.Size = new System.Drawing.Size(1156, 420);
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
            this.gcPartidas.Size = new System.Drawing.Size(1156, 420);
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
            this.gvPartidas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvPartidas_RowStyle);
            this.gvPartidas.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvPartidas_SelectionChanged);
            this.gvPartidas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPartidas_CellValueChanged);
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
            this.xtraTabPageMediosPago.Size = new System.Drawing.Size(1156, 390);
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
            this.gcPagos.Size = new System.Drawing.Size(1156, 390);
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
            this.gvPagos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPagos_CellValueChanged);
            this.gvPagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPagos_KeyDown);
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
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lbReferencias);
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
            this.xtraTabPageDocumentoElectronico.Size = new System.Drawing.Size(1156, 390);
            this.xtraTabPageDocumentoElectronico.Text = "Documento electrónico";
            // 
            // lbReferencias
            // 
            this.lbReferencias.Location = new System.Drawing.Point(493, 97);
            this.lbReferencias.Margin = new System.Windows.Forms.Padding(6);
            this.lbReferencias.Name = "lbReferencias";
            this.lbReferencias.Size = new System.Drawing.Size(263, 110);
            this.lbReferencias.TabIndex = 112;
            this.lbReferencias.Visible = false;
            this.lbReferencias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbReferencias_KeyDown);
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
            this.btnReferencias.Click += new System.EventHandler(this.btnReferencias_Click);
            // 
            // lblImportarFolioFiscal
            // 
            this.lblImportarFolioFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImportarFolioFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImportarFolioFiscal.Location = new System.Drawing.Point(1011, 323);
            this.lblImportarFolioFiscal.Margin = new System.Windows.Forms.Padding(6);
            this.lblImportarFolioFiscal.Name = "lblImportarFolioFiscal";
            this.lblImportarFolioFiscal.Size = new System.Drawing.Size(103, 15);
            this.lblImportarFolioFiscal.TabIndex = 109;
            this.lblImportarFolioFiscal.Text = "Importar folio fiscal";
            this.lblImportarFolioFiscal.Click += new System.EventHandler(this.lblImportarFolioFiscal_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.Location = new System.Drawing.Point(132, 20);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(6);
            this.cbMetodoPago.MenuManager = this.mainRibbonControl;
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
            this.lblMetodosPago.Size = new System.Drawing.Size(88, 15);
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
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            this.btnGenerarSustitucion.Click += new System.EventHandler(this.btnGenerarSustitucion_Click);
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Enabled = false;
            this.txtCadenaOriginal.Location = new System.Drawing.Point(132, 96);
            this.txtCadenaOriginal.Margin = new System.Windows.Forms.Padding(6);
            this.txtCadenaOriginal.MenuManager = this.mainRibbonControl;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(349, 111);
            this.txtCadenaOriginal.TabIndex = 99;
            // 
            // lblCadenaOriginal
            // 
            this.lblCadenaOriginal.Location = new System.Drawing.Point(4, 65);
            this.lblCadenaOriginal.Margin = new System.Windows.Forms.Padding(6);
            this.lblCadenaOriginal.Name = "lblCadenaOriginal";
            this.lblCadenaOriginal.Size = new System.Drawing.Size(83, 15);
            this.lblCadenaOriginal.TabIndex = 101;
            this.lblCadenaOriginal.Text = "Cadena original";
            // 
            // lblFolioFiscal
            // 
            this.lblFolioFiscal.Location = new System.Drawing.Point(4, 43);
            this.lblFolioFiscal.Margin = new System.Windows.Forms.Padding(6);
            this.lblFolioFiscal.Name = "lblFolioFiscal";
            this.lblFolioFiscal.Size = new System.Drawing.Size(56, 15);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1198, 798);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1178, 778);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmPagos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1198, 899);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPagos";
            this.mainRibbonControl.SetPopupContextMenu(this, this.popupMenuPagos);
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumentoExterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteAplicado.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lbReferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadenaOriginal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}