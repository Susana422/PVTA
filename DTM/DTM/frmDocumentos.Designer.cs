using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using SDK;
using Padding = System.Windows.Forms.Padding;

namespace DTM
{
    partial class frmDocumentos
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentos));
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXML = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenuDocumentos = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCodigoSN = new System.Windows.Forms.TextBox();
            this.picturesku = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlVolumen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlMonto = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDescuentoDir = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
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
            this.lblSocio = new DevExpress.XtraEditors.LabelControl();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Option = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumnPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStock = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumnListaPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbListasPrecios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPorcentajeDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrecioNeto = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumndisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAlmacenesDestino = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.btnEstatusCartaPorte = new System.Windows.Forms.Button();
            this.dtHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaSalida = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaLlegada = new DevExpress.XtraEditors.DateEdit();
            this.btnGenerarCartaPorte = new DevExpress.XtraEditors.SimpleButton();
            this.chckCartaPorte = new DevExpress.XtraEditors.CheckEdit();
            this.btnAgregarDireccionOrigen = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccionOrigen = new DevExpress.XtraEditors.MemoEdit();
            this.cbDireccionesOrigen = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionOrigen = new DevExpress.XtraEditors.LabelControl();
            this.lblDistancia = new DevExpress.XtraEditors.LabelControl();
            this.txtDistancia = new DevExpress.XtraEditors.TextEdit();
            this.cbRutas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRuta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbVehiculos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehiculo = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbChoferes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblChofer = new DevExpress.XtraEditors.HyperlinkLabelControl();
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
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSelloCFD = new DevExpress.XtraEditors.MemoEdit();
            this.lblSelloCFD = new DevExpress.XtraEditors.LabelControl();
            this.txtCadenaOriginal = new DevExpress.XtraEditors.MemoEdit();
            this.lblCadenaOriginal = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioFiscal = new DevExpress.XtraEditors.LabelControl();
            this.txtFolioFiscal = new DevExpress.XtraEditors.TextEdit();
            this.cbGenerarDocumentoElectronico = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenesDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPageLogistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckCartaPorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(50, 49, 50, 49);
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
            this.bbiAbrir,
            this.barButtonItem1,
            this.bbiXML,
            this.barButtonItem2});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.mainRibbonControl.MaxItemId = 28;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 550;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1505, 108);
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
            this.bbiRecargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRecargar_ItemClick);
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
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "AddItem";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
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
            this.bbiNuevoSocio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoSocio_ItemClick);
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
            this.barButtonItemMapaRelaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMapaRelaciones_ItemClick);
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
            this.bbiEnviar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEnviar.ImageOptions.Image")));
            this.bbiEnviar.ImageOptions.ImageUri.Uri = "Mail";
            this.bbiEnviar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEnviar.ImageOptions.LargeImage")));
            this.bbiEnviar.Name = "bbiEnviar";
            this.bbiEnviar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEnviar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 12;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiCerrar
            // 
            this.bbiCerrar.Caption = "Cerrar";
            this.bbiCerrar.Id = 13;
            this.bbiCerrar.ImageOptions.ImageUri.Uri = "Close";
            this.bbiCerrar.Name = "bbiCerrar";
            this.bbiCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCerrar_ItemClick);
            // 
            // bbiPagar
            // 
            this.bbiPagar.Caption = "Pagar";
            this.bbiPagar.Id = 14;
            this.bbiPagar.ImageOptions.ImageUri.Uri = "Currency";
            this.bbiPagar.Name = "bbiPagar";
            this.bbiPagar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPagar_ItemClick);
            // 
            // bbiXLSX
            // 
            this.bbiXLSX.Caption = "XLSX";
            this.bbiXLSX.Id = 15;
            this.bbiXLSX.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.bbiXLSX.Name = "bbiXLSX";
            this.bbiXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXLSX_ItemClick);
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
            this.bbiAjustarColumnas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAjustarColumnas_ItemClick);
            // 
            // bbiDuplicar
            // 
            this.bbiDuplicar.Caption = "Duplicar";
            this.bbiDuplicar.Id = 20;
            this.bbiDuplicar.ImageOptions.ImageUri.Uri = "Redo";
            this.bbiDuplicar.Name = "bbiDuplicar";
            this.bbiDuplicar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDuplicar_ItemClick);
            // 
            // bbiCancelacionManualCFDI
            // 
            this.bbiCancelacionManualCFDI.Caption = "Cancelación manual CFDI";
            this.bbiCancelacionManualCFDI.Id = 21;
            this.bbiCancelacionManualCFDI.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelacionManualCFDI.Name = "bbiCancelacionManualCFDI";
            this.bbiCancelacionManualCFDI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelacionManualCFDI_ItemClick);
            // 
            // bbiParametrizaciones
            // 
            this.bbiParametrizaciones.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizaciones.Id = 22;
            this.bbiParametrizaciones.Name = "bbiParametrizaciones";
            this.bbiParametrizaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiParametrizaciones_ItemClick);
            // 
            // bbiAbrir
            // 
            this.bbiAbrir.Caption = "Abrir";
            this.bbiAbrir.Id = 23;
            this.bbiAbrir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAbrir.ImageOptions.Image")));
            this.bbiAbrir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAbrir.ImageOptions.LargeImage")));
            this.bbiAbrir.Name = "bbiAbrir";
            this.bbiAbrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Abrir y Copiar NC ";
            this.barButtonItem1.Id = 25;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // bbiXML
            // 
            this.bbiXML.Caption = "XML";
            this.bbiXML.Id = 26;
            this.bbiXML.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXML.ImageOptions.Image")));
            this.bbiXML.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiXML.ImageOptions.LargeImage")));
            this.bbiXML.Name = "bbiXML";
            this.bbiXML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXML_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ver Carta Porte";
            this.barButtonItem2.Id = 27;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiXML);
            this.mainRibbonPageGroup.ItemLinks.Add(this.barButtonItem2);
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
            // popupMenuDocumentos
            // 
            this.popupMenuDocumentos.ItemLinks.Add(this.barHeaderItem1);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiXLSX);
            this.popupMenuDocumentos.ItemLinks.Add(this.barHeaderItem2);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiDuplicar);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiEnviar);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiRecargar);
            this.popupMenuDocumentos.ItemLinks.Add(this.barHeaderItem3);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiAbrir);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiCerrar);
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiCancelar);
            this.popupMenuDocumentos.Name = "popupMenuDocumentos";
            this.popupMenuDocumentos.Ribbon = this.mainRibbonControl;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 108);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1505, 957);
            this.layoutControl1.TabIndex = 59;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(1481, 933);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageLogistica,
            this.xtraTabPageFinanzas,
            this.xtraTabPageDocumentoElectronico});
            this.xtraTabControl1.Visible = false;
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.AutoScroll = true;
            this.xtraTabPageGeneral.Controls.Add(this.button1);
            this.xtraTabPageGeneral.Controls.Add(this.listBox2);
            this.xtraTabPageGeneral.Controls.Add(this.labelControl7);
            this.xtraTabPageGeneral.Controls.Add(this.listBox1);
            this.xtraTabPageGeneral.Controls.Add(this.txtCodigoSN);
            this.xtraTabPageGeneral.Controls.Add(this.picturesku);
            this.xtraTabPageGeneral.Controls.Add(this.panelControl1);
            this.xtraTabPageGeneral.Controls.Add(this.pictureBox1);
            this.xtraTabPageGeneral.Controls.Add(this.listBoxControl1);
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
            this.xtraTabPageGeneral.Controls.Add(this.lblSocio);
            this.xtraTabPageGeneral.Controls.Add(this.gcPartidas);
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(1473, 896);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 187;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(74, 394);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1144, 214);
            this.listBox2.TabIndex = 186;
            this.listBox2.Visible = false;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(22, 336);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 21);
            this.labelControl7.TabIndex = 185;
            this.labelControl7.Text = "Articulo";
            this.labelControl7.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(186, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(446, 166);
            this.listBox1.TabIndex = 184;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // txtCodigoSN
            // 
            this.txtCodigoSN.Location = new System.Drawing.Point(186, 14);
            this.txtCodigoSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoSN.Name = "txtCodigoSN";
            this.txtCodigoSN.Size = new System.Drawing.Size(446, 28);
            this.txtCodigoSN.TabIndex = 183;
            this.txtCodigoSN.TextChanged += new System.EventHandler(this.txtCodigoSN_TextChanged);
            this.txtCodigoSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoSN_KeyDown);
            this.txtCodigoSN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoSN_KeyUp);
            this.txtCodigoSN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCodigoSN_PreviewKeyDown);
            // 
            // picturesku
            // 
            this.picturesku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturesku.Location = new System.Drawing.Point(1233, 231);
            this.picturesku.Margin = new System.Windows.Forms.Padding(4);
            this.picturesku.Name = "picturesku";
            this.picturesku.Size = new System.Drawing.Size(216, 31);
            this.picturesku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesku.TabIndex = 182;
            this.picturesku.TabStop = false;
            this.picturesku.DoubleClick += new System.EventHandler(this.picturesku_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.accordionControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(1228, 270);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(215, 454);
            this.panelControl1.TabIndex = 181;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlVolumen,
            this.accordionControlMonto,
            this.accordionControlDescuentoDir,
            this.accordionControlElement4});
            this.accordionControl1.Location = new System.Drawing.Point(5, 51);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(204, 385);
            this.accordionControl1.TabIndex = 179;
            // 
            // accordionControlVolumen
            // 
            this.accordionControlVolumen.Appearance.Default.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlVolumen.Appearance.Default.Options.UseFont = true;
            this.accordionControlVolumen.Expanded = true;
            this.accordionControlVolumen.Name = "accordionControlVolumen";
            this.accordionControlVolumen.Text = "X VOLUMEN";
            // 
            // accordionControlMonto
            // 
            this.accordionControlMonto.Appearance.Default.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlMonto.Appearance.Default.Options.UseFont = true;
            this.accordionControlMonto.Expanded = true;
            this.accordionControlMonto.Name = "accordionControlMonto";
            this.accordionControlMonto.Text = "X MONTO";
            // 
            // accordionControlDescuentoDir
            // 
            this.accordionControlDescuentoDir.Appearance.Default.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlDescuentoDir.Appearance.Default.Options.UseFont = true;
            this.accordionControlDescuentoDir.Expanded = true;
            this.accordionControlDescuentoDir.Name = "accordionControlDescuentoDir";
            this.accordionControlDescuentoDir.Text = "X DTO DIRECTO";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Appearance.Default.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement4.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "X POLITICA DE VENTA";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 27);
            this.labelControl2.TabIndex = 180;
            this.labelControl2.Text = "PROMOCIONES";
            this.labelControl2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(890, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControl1.Location = new System.Drawing.Point(715, 70);
            this.listBoxControl1.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(168, 220);
            this.listBoxControl1.TabIndex = 177;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // lbMensajeC
            // 
            this.lbMensajeC.Appearance.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeC.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMensajeC.Appearance.Options.UseFont = true;
            this.lbMensajeC.Appearance.Options.UseForeColor = true;
            this.lbMensajeC.Location = new System.Drawing.Point(41, 275);
            this.lbMensajeC.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lbMensajeC.Name = "lbMensajeC";
            this.lbMensajeC.Size = new System.Drawing.Size(602, 23);
            this.lbMensajeC.TabIndex = 174;
            this.lbMensajeC.Text = "La Venta debera ser de Contado tiene Facturas pendientes por Pagar";
            this.lbMensajeC.Visible = false;
            // 
            // lbFact
            // 
            this.lbFact.Location = new System.Drawing.Point(41, 245);
            this.lbFact.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lbFact.Name = "lbFact";
            this.lbFact.Size = new System.Drawing.Size(145, 21);
            this.lbFact.TabIndex = 173;
            this.lbFact.Text = "Facturas Vencidas";
            this.lbFact.Visible = false;
            // 
            // lbCredito
            // 
            this.lbCredito.Location = new System.Drawing.Point(41, 191);
            this.lbCredito.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lbCredito.Name = "lbCredito";
            this.lbCredito.Size = new System.Drawing.Size(145, 21);
            this.lbCredito.TabIndex = 172;
            this.lbCredito.Text = "Credito Disponible";
            this.lbCredito.Visible = false;
            // 
            // txtFactVencidas
            // 
            this.txtFactVencidas.Enabled = false;
            this.txtFactVencidas.Location = new System.Drawing.Point(192, 236);
            this.txtFactVencidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactVencidas.MenuManager = this.mainRibbonControl;
            this.txtFactVencidas.Name = "txtFactVencidas";
            this.txtFactVencidas.Size = new System.Drawing.Size(279, 28);
            this.txtFactVencidas.TabIndex = 171;
            this.txtFactVencidas.Visible = false;
            // 
            // txtCreditoDisponible
            // 
            this.txtCreditoDisponible.Enabled = false;
            this.txtCreditoDisponible.Location = new System.Drawing.Point(190, 183);
            this.txtCreditoDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditoDisponible.MenuManager = this.mainRibbonControl;
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtCreditoDisponible.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(278, 28);
            this.txtCreditoDisponible.TabIndex = 170;
            this.txtCreditoDisponible.Visible = false;
            // 
            // btnStat
            // 
            this.btnStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStat.Location = new System.Drawing.Point(1411, 2);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(35, 36);
            this.btnStat.TabIndex = 169;
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.MouseHover += new System.EventHandler(this.btnStat_MouseHover);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(1054, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(207, 21);
            this.labelControl1.TabIndex = 168;
            this.labelControl1.Text = "N° de Documento en SAP";
            // 
            // btnCargaArticulos
            // 
            this.btnCargaArticulos.Location = new System.Drawing.Point(478, 231);
            this.btnCargaArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargaArticulos.Name = "btnCargaArticulos";
            this.btnCargaArticulos.Size = new System.Drawing.Size(231, 38);
            this.btnCargaArticulos.TabIndex = 166;
            this.btnCargaArticulos.Text = "Subir Articulos con Excel";
            this.btnCargaArticulos.Click += new System.EventHandler(this.btnCargaArticulos_Click);
            // 
            // btnDescuentosEspeciales
            // 
            this.btnDescuentosEspeciales.Location = new System.Drawing.Point(474, 178);
            this.btnDescuentosEspeciales.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuentosEspeciales.Name = "btnDescuentosEspeciales";
            this.btnDescuentosEspeciales.Size = new System.Drawing.Size(235, 38);
            this.btnDescuentosEspeciales.TabIndex = 165;
            this.btnDescuentosEspeciales.Text = "Aplicar descuentos especiales";
            this.btnDescuentosEspeciales.Click += new System.EventHandler(this.btnDescuentosEspeciales_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticulo.Location = new System.Drawing.Point(74, 367);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(1144, 28);
            this.txtArticulo.TabIndex = 1;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            this.txtArticulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyUp);
            this.txtArticulo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtArticulo_PreviewKeyDown);
            // 
            // txtFechaVigencia
            // 
            this.txtFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaVigencia.Location = new System.Drawing.Point(1269, 188);
            this.txtFechaVigencia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFechaVigencia.Name = "txtFechaVigencia";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.EditFormat.FormatString = "d";
            this.txtFechaVigencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaVigencia.Properties.ReadOnly = true;
            this.txtFechaVigencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaVigencia.Size = new System.Drawing.Size(178, 28);
            this.txtFechaVigencia.TabIndex = 164;
            this.txtFechaVigencia.TabStop = false;
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVigencia.Location = new System.Drawing.Point(1141, 195);
            this.lblFechaVigencia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(120, 21);
            this.lblFechaVigencia.TabIndex = 163;
            this.lblFechaVigencia.Text = "Fecha vigencia";
            // 
            // lblWeb
            // 
            this.lblWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeb.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWeb.Location = new System.Drawing.Point(729, 151);
            this.lblWeb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(39, 17);
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
            this.lblEnviado.Location = new System.Drawing.Point(974, 30);
            this.lblEnviado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(63, 17);
            this.lblEnviado.TabIndex = 161;
            this.lblEnviado.Text = "Enviado";
            this.lblEnviado.Visible = false;
            // 
            // lblAlmacenDestino
            // 
            this.lblAlmacenDestino.Location = new System.Drawing.Point(682, 111);
            this.lblAlmacenDestino.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblAlmacenDestino.Name = "lblAlmacenDestino";
            this.lblAlmacenDestino.Size = new System.Drawing.Size(133, 21);
            this.lblAlmacenDestino.TabIndex = 160;
            this.lblAlmacenDestino.Text = "Almacén destino";
            // 
            // lblAlmacenOrigen
            // 
            this.lblAlmacenOrigen.Location = new System.Drawing.Point(691, 73);
            this.lblAlmacenOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblAlmacenOrigen.Name = "lblAlmacenOrigen";
            this.lblAlmacenOrigen.Size = new System.Drawing.Size(125, 21);
            this.lblAlmacenOrigen.TabIndex = 159;
            this.lblAlmacenOrigen.Text = "Almacén origen";
            // 
            // lblClase
            // 
            this.lblClase.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Appearance.Options.UseFont = true;
            this.lblClase.Location = new System.Drawing.Point(722, 6);
            this.lblClase.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(53, 24);
            this.lblClase.TabIndex = 158;
            this.lblClase.Text = "Clase";
            // 
            // cbAlmacenDestino
            // 
            this.cbAlmacenDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenDestino.Location = new System.Drawing.Point(825, 101);
            this.cbAlmacenDestino.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbAlmacenDestino.MenuManager = this.mainRibbonControl;
            this.cbAlmacenDestino.Name = "cbAlmacenDestino";
            this.cbAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenDestino.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenDestino.Properties.NullText = "[Almacén destino]";
            this.cbAlmacenDestino.Size = new System.Drawing.Size(234, 28);
            this.cbAlmacenDestino.TabIndex = 157;
            this.cbAlmacenDestino.Visible = false;
            // 
            // cbAlmacenOrigen
            // 
            this.cbAlmacenOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenOrigen.Location = new System.Drawing.Point(825, 63);
            this.cbAlmacenOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbAlmacenOrigen.MenuManager = this.mainRibbonControl;
            this.cbAlmacenOrigen.Name = "cbAlmacenOrigen";
            this.cbAlmacenOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenOrigen.Properties.NullText = "[Almacén origen]";
            this.cbAlmacenOrigen.Size = new System.Drawing.Size(234, 28);
            this.cbAlmacenOrigen.TabIndex = 156;
            this.cbAlmacenOrigen.Visible = false;
            // 
            // deFechaVencimiento
            // 
            this.deFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaVencimiento.EditValue = null;
            this.deFechaVencimiento.Location = new System.Drawing.Point(1269, 115);
            this.deFechaVencimiento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.deFechaVencimiento.MenuManager = this.mainRibbonControl;
            this.deFechaVencimiento.Name = "deFechaVencimiento";
            this.deFechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVencimiento.Size = new System.Drawing.Size(178, 28);
            this.deFechaVencimiento.TabIndex = 153;
            // 
            // deFechaContabilizacion
            // 
            this.deFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFechaContabilizacion.EditValue = null;
            this.deFechaContabilizacion.Location = new System.Drawing.Point(1269, 79);
            this.deFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.deFechaContabilizacion.MenuManager = this.mainRibbonControl;
            this.deFechaContabilizacion.Name = "deFechaContabilizacion";
            this.deFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaContabilizacion.Size = new System.Drawing.Size(178, 28);
            this.deFechaContabilizacion.TabIndex = 150;
            // 
            // txtNumeroDocumentoExterno
            // 
            this.txtNumeroDocumentoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumentoExterno.Enabled = false;
            this.txtNumeroDocumentoExterno.Location = new System.Drawing.Point(1269, 7);
            this.txtNumeroDocumentoExterno.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNumeroDocumentoExterno.Name = "txtNumeroDocumentoExterno";
            this.txtNumeroDocumentoExterno.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDocumentoExterno.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumeroDocumentoExterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumentoExterno.Size = new System.Drawing.Size(132, 28);
            this.txtNumeroDocumentoExterno.TabIndex = 124;
            this.txtNumeroDocumentoExterno.TabStop = false;
            this.txtNumeroDocumentoExterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumentoExterno_KeyDown);
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArticulos.Location = new System.Drawing.Point(532, 829);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(84, 21);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Artículos 0";
            // 
            // lblPartidas
            // 
            this.lblPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPartidas.Location = new System.Drawing.Point(532, 862);
            this.lblPartidas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(84, 21);
            this.lblPartidas.TabIndex = 0;
            this.lblPartidas.Text = "Partidas 0";
            // 
            // lblReferencia
            // 
            this.lblReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReferencia.Location = new System.Drawing.Point(36, 775);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(83, 21);
            this.lblReferencia.TabIndex = 121;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReferencia.Location = new System.Drawing.Point(186, 771);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.MaxLength = 100;
            this.txtReferencia.Size = new System.Drawing.Size(330, 28);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.TabStop = false;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            // 
            // lblCodigoSN
            // 
            this.lblCodigoSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCodigoSN.Location = new System.Drawing.Point(55, 14);
            this.lblCodigoSN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCodigoSN.Name = "lblCodigoSN";
            this.lblCodigoSN.Size = new System.Drawing.Size(84, 21);
            this.lblCodigoSN.TabIndex = 118;
            this.lblCodigoSN.Text = "Código SN";
            this.lblCodigoSN.Click += new System.EventHandler(this.lblCodigoSN_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(671, 14);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(11, 21);
            this.lblID.TabIndex = 117;
            this.lblID.Text = "0";
            // 
            // lblImpreso
            // 
            this.lblImpreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpreso.AutoSize = true;
            this.lblImpreso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImpreso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblImpreso.Location = new System.Drawing.Point(892, 30);
            this.lblImpreso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImpreso.Name = "lblImpreso";
            this.lblImpreso.Size = new System.Drawing.Size(67, 17);
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
            this.lblCancelado.Location = new System.Drawing.Point(799, 30);
            this.lblCancelado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(79, 17);
            this.lblCancelado.TabIndex = 115;
            this.lblCancelado.Text = "Cancelado";
            this.lblCancelado.Visible = false;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(474, 107);
            this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(160, 28);
            this.txtTipoCambio.TabIndex = 0;
            this.txtTipoCambio.TabStop = false;
            this.txtTipoCambio.EditValueChanged += new System.EventHandler(this.txtTipoCambio_EditValueChanged);
            this.txtTipoCambio.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTipoCambio_EditValueChanging);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(20, 298);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(14);
            this.separatorControl1.Size = new System.Drawing.Size(1198, 31);
            this.separatorControl1.TabIndex = 112;
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(186, 107);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(279, 28);
            this.cbMonedas.TabIndex = 0;
            this.cbMonedas.TabStop = false;
            this.cbMonedas.EditValueChanged += new System.EventHandler(this.cbMonedas_EditValueChanged);
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(74, 111);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(66, 21);
            this.lblMonedas.TabIndex = 111;
            this.lblMonedas.Text = "Moneda";
            this.lblMonedas.Click += new System.EventHandler(this.lblMonedas_Click);
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(189, 67);
            this.txtFechaCreacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.EditFormat.FormatString = "d";
            this.txtFechaCreacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaCreacion.Properties.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(141, 28);
            this.txtFechaCreacion.TabIndex = 106;
            this.txtFechaCreacion.TabStop = false;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.Location = new System.Drawing.Point(22, 75);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(119, 21);
            this.lblFechaCreacion.TabIndex = 105;
            this.lblFechaCreacion.Text = "Fecha creación";
            // 
            // cbSeries
            // 
            this.cbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeries.Location = new System.Drawing.Point(1131, 43);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbSeries.MenuManager = this.mainRibbonControl;
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSeries.Size = new System.Drawing.Size(130, 28);
            this.cbSeries.TabIndex = 0;
            this.cbSeries.TabStop = false;
            this.cbSeries.EditValueChanged += new System.EventHandler(this.cbSeries_EditValueChanged);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(1088, 50);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(21, 21);
            this.lblNumeroDocumento.TabIndex = 103;
            this.lblNumeroDocumento.Text = "N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(1269, 43);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(178, 28);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.TabStop = false;
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDocumento.Location = new System.Drawing.Point(1269, 151);
            this.txtFechaDocumento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.EditFormat.FormatString = "d";
            this.txtFechaDocumento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFechaDocumento.Properties.ReadOnly = true;
            this.txtFechaDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFechaDocumento.Size = new System.Drawing.Size(178, 28);
            this.txtFechaDocumento.TabIndex = 99;
            this.txtFechaDocumento.TabStop = false;
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDocumento.Location = new System.Drawing.Point(1113, 158);
            this.lblFechaDocumento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(144, 21);
            this.lblFechaDocumento.TabIndex = 93;
            this.lblFechaDocumento.Text = "Fecha documento";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(1110, 122);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(151, 21);
            this.lblFechaVencimiento.TabIndex = 91;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            this.lblFechaVencimiento.DoubleClick += new System.EventHandler(this.lblFechaVencimiento_DoubleClick);
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(1088, 86);
            this.lblFechaContabilizacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(173, 21);
            this.lblFechaContabilizacion.TabIndex = 89;
            this.lblFechaContabilizacion.Text = "Fecha contabilización";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentario.Location = new System.Drawing.Point(186, 808);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(330, 74);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.Location = new System.Drawing.Point(24, 810);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(94, 21);
            this.lblComentario.TabIndex = 84;
            this.lblComentario.Text = "Comentario";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVendedores.Location = new System.Drawing.Point(186, 732);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(330, 28);
            this.cbVendedores.TabIndex = 0;
            this.cbVendedores.TabStop = false;
            this.cbVendedores.EditValueChanged += new System.EventHandler(this.cbVendedores_EditValueChanged);
            // 
            // lblVendedores
            // 
            this.lblVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedores.Location = new System.Drawing.Point(41, 740);
            this.lblVendedores.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(78, 21);
            this.lblVendedores.TabIndex = 82;
            this.lblVendedores.Text = "Vendedor";
            // 
            // lblImporteAplicado
            // 
            this.lblImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteAplicado.Location = new System.Drawing.Point(1072, 862);
            this.lblImporteAplicado.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblImporteAplicado.Name = "lblImporteAplicado";
            this.lblImporteAplicado.Size = new System.Drawing.Size(138, 21);
            this.lblImporteAplicado.TabIndex = 80;
            this.lblImporteAplicado.Text = "Importe aplicado";
            // 
            // txtImporteAplicado
            // 
            this.txtImporteAplicado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteAplicado.Location = new System.Drawing.Point(1218, 858);
            this.txtImporteAplicado.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtImporteAplicado.MenuManager = this.mainRibbonControl;
            this.txtImporteAplicado.Name = "txtImporteAplicado";
            this.txtImporteAplicado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImporteAplicado.Properties.DisplayFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.EditFormat.FormatString = "c2";
            this.txtImporteAplicado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporteAplicado.Properties.ReadOnly = true;
            this.txtImporteAplicado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImporteAplicado.Size = new System.Drawing.Size(226, 28);
            this.txtImporteAplicado.TabIndex = 0;
            this.txtImporteAplicado.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(1042, 829);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 21);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = "Total del documento";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(1216, 826);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
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
            this.txtTotal.Size = new System.Drawing.Size(226, 24);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpuesto.Location = new System.Drawing.Point(1134, 794);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(73, 21);
            this.lblImpuesto.TabIndex = 74;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.Location = new System.Drawing.Point(1216, 785);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtImpuesto.MenuManager = this.mainRibbonControl;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtImpuesto.Properties.DisplayFormat.FormatString = "c2";
            this.txtImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.EditFormat.FormatString = "c2";
            this.txtImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.ReadOnly = true;
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(226, 28);
            this.txtImpuesto.TabIndex = 0;
            this.txtImpuesto.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.Location = new System.Drawing.Point(1134, 752);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(72, 21);
            this.lblSubTotal.TabIndex = 72;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Location = new System.Drawing.Point(1216, 740);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSubTotal.MenuManager = this.mainRibbonControl;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSubTotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubTotal.Properties.EditFormat.FormatString = "c2";
            this.txtSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubTotal.Properties.Mask.EditMask = "c2";
            this.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubTotal.Properties.ReadOnly = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(226, 28);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TabStop = false;
            // 
            // lblSocio
            // 
            this.lblSocio.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSocio.Appearance.Options.UseFont = true;
            this.lblSocio.Location = new System.Drawing.Point(22, 43);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(265, 17);
            this.lblSocio.TabIndex = 20;
            this.lblSocio.Text = "Por favor ingrese un socio de negocios";
            // 
            // gcPartidas
            // 
            this.gcPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gcPartidas.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcPartidas.Location = new System.Drawing.Point(20, 404);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAlmacenes,
            this.cbTiposEmpaques,
            this.cbListasPrecios,
            this.cbUbicaciones,
            this.repositoryItemCalcEdit1,
            this.cbUnidadesMedida,
            this.cbAlmacenesDestino});
            this.gcPartidas.Size = new System.Drawing.Size(1202, 320);
            this.gcPartidas.TabIndex = 1;
            this.gcPartidas.TabStop = false;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartidas,
            this.gridView2});
            this.gcPartidas.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gcPartidas_FocusedViewChanged);
            this.gcPartidas.Click += new System.EventHandler(this.gcPartidas_Click);
            this.gcPartidas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcPartidas_MouseDoubleClick);
            this.gcPartidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcPartidas_MouseDown);
            // 
            // gvPartidas
            // 
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Option,
            this.gridColumnNo,
            this.gridColumnCantidad,
            this.gridColumnPeso,
            this.gridColumnStock,
            this.gridColumnUnidadMedida,
            this.gridColumnCantidadEmpaque,
            this.gridColumnTipoEmpaque,
            this.gridColumnCantidadPendiente,
            this.gridColumnCantidadPaquete,
            this.gridColumnSKU,
            this.gridColumnArticulo,
            this.gridColumnCodigoBarras,
            this.gridColumnListaPrecio,
            this.gridColumnPrecio,
            this.gridColumnSubTotal,
            this.gridColumnImpuesto,
            this.gridColumnPorcentajeDescuento,
            this.gridColumnDescuento,
            this.gridColumnPrecioNeto,
            this.gridColumnTotal,
            this.gridColumnAlmacen,
            this.gridColumnUbicacion,
            this.gridColumnAlmacenDestino,
            this.gridColumnUbicacionDestino,
            this.gridColumnComentario,
            this.gridColumnDescuentoEspecial,
            this.gridColumnNumeroPedimento,
            this.gridColumndisponible});
            this.gvPartidas.DetailHeight = 566;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsCustomization.AllowSort = false;
            this.gvPartidas.OptionsEditForm.PopupEditFormWidth = 1332;
            this.gvPartidas.OptionsPrint.AutoWidth = false;
            this.gvPartidas.OptionsView.RowAutoHeight = true;
            this.gvPartidas.OptionsView.ShowGroupPanel = false;
            this.gvPartidas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvPartidas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvPartidas_RowStyle);
            this.gvPartidas.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvPartidas_ShowingEditor);
            this.gvPartidas.ShownEditor += new System.EventHandler(this.gvPartidas_ShownEditor);
            this.gvPartidas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPartidas_CellValueChanged);
            this.gvPartidas.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvPartidas_CustomUnboundColumnData);
            this.gvPartidas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPartidas_KeyDown);
            // 
            // Option
            // 
            this.Option.Caption = "Opcion";
            this.Option.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Option.ImageOptions.Image")));
            this.Option.MinWidth = 25;
            this.Option.Name = "Option";
            this.Option.Visible = true;
            this.Option.VisibleIndex = 0;
            this.Option.Width = 71;
            // 
            // gridColumnNo
            // 
            this.gridColumnNo.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNo.Caption = "#";
            this.gridColumnNo.FieldName = "gridColumnNo";
            this.gridColumnNo.MaxWidth = 50;
            this.gridColumnNo.MinWidth = 32;
            this.gridColumnNo.Name = "gridColumnNo";
            this.gridColumnNo.OptionsColumn.AllowEdit = false;
            this.gridColumnNo.OptionsColumn.ReadOnly = true;
            this.gridColumnNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnNo.Visible = true;
            this.gridColumnNo.VisibleIndex = 1;
            this.gridColumnNo.Width = 32;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.AppearanceCell.Options.UseFont = true;
            this.gridColumnCantidad.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MaxWidth = 217;
            this.gridColumnCantidad.MinWidth = 50;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 2;
            this.gridColumnCantidad.Width = 100;
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
            this.gridColumnPeso.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPeso.Caption = "Peso";
            this.gridColumnPeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPeso.FieldName = "peso";
            this.gridColumnPeso.MinWidth = 32;
            this.gridColumnPeso.Name = "gridColumnPeso";
            this.gridColumnPeso.OptionsColumn.FixedWidth = true;
            this.gridColumnPeso.Visible = true;
            this.gridColumnPeso.VisibleIndex = 3;
            this.gridColumnPeso.Width = 74;
            // 
            // gridColumnStock
            // 
            this.gridColumnStock.AppearanceHeader.Options.UseFont = true;
            this.gridColumnStock.Caption = "Stock";
            this.gridColumnStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnStock.FieldName = "stock";
            this.gridColumnStock.MinWidth = 32;
            this.gridColumnStock.Name = "gridColumnStock";
            this.gridColumnStock.OptionsColumn.AllowEdit = false;
            this.gridColumnStock.Visible = true;
            this.gridColumnStock.VisibleIndex = 4;
            this.gridColumnStock.Width = 66;
            // 
            // gridColumnUnidadMedida
            // 
            this.gridColumnUnidadMedida.Caption = "UdM";
            this.gridColumnUnidadMedida.ColumnEdit = this.cbUnidadesMedida;
            this.gridColumnUnidadMedida.FieldName = "unidad_medida_id";
            this.gridColumnUnidadMedida.MinWidth = 32;
            this.gridColumnUnidadMedida.Name = "gridColumnUnidadMedida";
            this.gridColumnUnidadMedida.Width = 32;
            // 
            // cbUnidadesMedida
            // 
            this.cbUnidadesMedida.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbUnidadesMedida.AutoHeight = false;
            this.cbUnidadesMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            // 
            // gridColumnCantidadEmpaque
            // 
            this.gridColumnCantidadEmpaque.Caption = "C/E";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadEmpaque.FieldName = "cantidad_empaque";
            this.gridColumnCantidadEmpaque.MinWidth = 32;
            this.gridColumnCantidadEmpaque.Name = "gridColumnCantidadEmpaque";
            this.gridColumnCantidadEmpaque.Width = 50;
            // 
            // gridColumnTipoEmpaque
            // 
            this.gridColumnTipoEmpaque.Caption = "Tipo empaque";
            this.gridColumnTipoEmpaque.ColumnEdit = this.cbTiposEmpaques;
            this.gridColumnTipoEmpaque.FieldName = "tipo_empaque_id";
            this.gridColumnTipoEmpaque.MinWidth = 32;
            this.gridColumnTipoEmpaque.Name = "gridColumnTipoEmpaque";
            this.gridColumnTipoEmpaque.Width = 124;
            // 
            // cbTiposEmpaques
            // 
            this.cbTiposEmpaques.AutoHeight = false;
            this.cbTiposEmpaques.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposEmpaques.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTiposEmpaques.Name = "cbTiposEmpaques";
            // 
            // gridColumnCantidadPendiente
            // 
            this.gridColumnCantidadPendiente.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumnCantidadPendiente.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnCantidadPendiente.Caption = "Pendiente";
            this.gridColumnCantidadPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadPendiente.FieldName = "cantidad_pendiente";
            this.gridColumnCantidadPendiente.MaxWidth = 217;
            this.gridColumnCantidadPendiente.MinWidth = 50;
            this.gridColumnCantidadPendiente.Name = "gridColumnCantidadPendiente";
            this.gridColumnCantidadPendiente.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPendiente.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidadPendiente.Width = 100;
            // 
            // gridColumnCantidadPaquete
            // 
            this.gridColumnCantidadPaquete.Caption = "Cant/Paq";
            this.gridColumnCantidadPaquete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadPaquete.FieldName = "cantidad_paquete";
            this.gridColumnCantidadPaquete.MaxWidth = 100;
            this.gridColumnCantidadPaquete.MinWidth = 59;
            this.gridColumnCantidadPaquete.Name = "gridColumnCantidadPaquete";
            this.gridColumnCantidadPaquete.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPaquete.Width = 59;
            // 
            // gridColumnSKU
            // 
            this.gridColumnSKU.AppearanceHeader.Options.UseFont = true;
            this.gridColumnSKU.Caption = "SKU";
            this.gridColumnSKU.FieldName = "sku";
            this.gridColumnSKU.MaxWidth = 167;
            this.gridColumnSKU.MinWidth = 32;
            this.gridColumnSKU.Name = "gridColumnSKU";
            this.gridColumnSKU.OptionsColumn.AllowEdit = false;
            this.gridColumnSKU.Visible = true;
            this.gridColumnSKU.VisibleIndex = 6;
            this.gridColumnSKU.Width = 32;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.AppearanceHeader.Options.UseFont = true;
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.FieldName = "nombre";
            this.gridColumnArticulo.MinWidth = 167;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 7;
            this.gridColumnArticulo.Width = 167;
            // 
            // gridColumnCodigoBarras
            // 
            this.gridColumnCodigoBarras.AppearanceCell.Options.UseFont = true;
            this.gridColumnCodigoBarras.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCodigoBarras.Caption = "Código de barras";
            this.gridColumnCodigoBarras.FieldName = "codigo_barras";
            this.gridColumnCodigoBarras.MaxWidth = 156;
            this.gridColumnCodigoBarras.MinWidth = 82;
            this.gridColumnCodigoBarras.Name = "gridColumnCodigoBarras";
            this.gridColumnCodigoBarras.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigoBarras.OptionsColumn.FixedWidth = true;
            this.gridColumnCodigoBarras.Visible = true;
            this.gridColumnCodigoBarras.VisibleIndex = 8;
            this.gridColumnCodigoBarras.Width = 156;
            // 
            // gridColumnListaPrecio
            // 
            this.gridColumnListaPrecio.AppearanceHeader.Options.UseFont = true;
            this.gridColumnListaPrecio.Caption = "Lista de precio";
            this.gridColumnListaPrecio.ColumnEdit = this.cbListasPrecios;
            this.gridColumnListaPrecio.FieldName = "lista_precio_id";
            this.gridColumnListaPrecio.MaxWidth = 100;
            this.gridColumnListaPrecio.MinWidth = 32;
            this.gridColumnListaPrecio.Name = "gridColumnListaPrecio";
            this.gridColumnListaPrecio.Visible = true;
            this.gridColumnListaPrecio.VisibleIndex = 9;
            this.gridColumnListaPrecio.Width = 32;
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.AutoHeight = false;
            this.cbListasPrecios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Name = "cbListasPrecios";
            // 
            // gridColumnPrecio
            // 
            this.gridColumnPrecio.Caption = "Precio";
            this.gridColumnPrecio.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumnPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecio.FieldName = "gridColumnPrecio";
            this.gridColumnPrecio.MaxWidth = 200;
            this.gridColumnPrecio.MinWidth = 32;
            this.gridColumnPrecio.Name = "gridColumnPrecio";
            this.gridColumnPrecio.UnboundExpression = "precio * tipo_cambio";
            this.gridColumnPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecio.Width = 34;
            // 
            // gridColumnSubTotal
            // 
            this.gridColumnSubTotal.AppearanceHeader.Options.UseFont = true;
            this.gridColumnSubTotal.Caption = "SubTotal";
            this.gridColumnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSubTotal.FieldName = "subtotal";
            this.gridColumnSubTotal.MaxWidth = 167;
            this.gridColumnSubTotal.MinWidth = 32;
            this.gridColumnSubTotal.Name = "gridColumnSubTotal";
            this.gridColumnSubTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnSubTotal.Visible = true;
            this.gridColumnSubTotal.VisibleIndex = 12;
            this.gridColumnSubTotal.Width = 32;
            // 
            // gridColumnImpuesto
            // 
            this.gridColumnImpuesto.AppearanceHeader.Options.UseFont = true;
            this.gridColumnImpuesto.Caption = "Impuesto";
            this.gridColumnImpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImpuesto.FieldName = "impuesto";
            this.gridColumnImpuesto.MinWidth = 32;
            this.gridColumnImpuesto.Name = "gridColumnImpuesto";
            this.gridColumnImpuesto.OptionsColumn.AllowEdit = false;
            this.gridColumnImpuesto.Visible = true;
            this.gridColumnImpuesto.VisibleIndex = 13;
            this.gridColumnImpuesto.Width = 32;
            // 
            // gridColumnPorcentajeDescuento
            // 
            this.gridColumnPorcentajeDescuento.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPorcentajeDescuento.Caption = "% Dscto";
            this.gridColumnPorcentajeDescuento.DisplayFormat.FormatString = "0.##";
            this.gridColumnPorcentajeDescuento.FieldName = "porcentaje_descuento";
            this.gridColumnPorcentajeDescuento.MaxWidth = 82;
            this.gridColumnPorcentajeDescuento.MinWidth = 32;
            this.gridColumnPorcentajeDescuento.Name = "gridColumnPorcentajeDescuento";
            this.gridColumnPorcentajeDescuento.OptionsColumn.FixedWidth = true;
            this.gridColumnPorcentajeDescuento.Visible = true;
            this.gridColumnPorcentajeDescuento.VisibleIndex = 10;
            this.gridColumnPorcentajeDescuento.Width = 82;
            // 
            // gridColumnDescuento
            // 
            this.gridColumnDescuento.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDescuento.Caption = "Descuento";
            this.gridColumnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDescuento.FieldName = "descuento";
            this.gridColumnDescuento.MaxWidth = 200;
            this.gridColumnDescuento.MinWidth = 32;
            this.gridColumnDescuento.Name = "gridColumnDescuento";
            this.gridColumnDescuento.OptionsColumn.AllowEdit = false;
            this.gridColumnDescuento.Visible = true;
            this.gridColumnDescuento.VisibleIndex = 11;
            this.gridColumnDescuento.Width = 32;
            // 
            // gridColumnPrecioNeto
            // 
            this.gridColumnPrecioNeto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnPrecioNeto.AppearanceCell.Options.UseFont = true;
            this.gridColumnPrecioNeto.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPrecioNeto.Caption = "P. Neto";
            this.gridColumnPrecioNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecioNeto.FieldName = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.MaxWidth = 200;
            this.gridColumnPrecioNeto.MinWidth = 32;
            this.gridColumnPrecioNeto.Name = "gridColumnPrecioNeto";
            this.gridColumnPrecioNeto.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecioNeto.UnboundExpression = "((precio * tipo_cambio) + impuesto) - descuento";
            this.gridColumnPrecioNeto.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecioNeto.Width = 32;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnTotal.AppearanceCell.Options.UseFont = true;
            this.gridColumnTotal.AppearanceHeader.Options.UseFont = true;
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "total";
            this.gridColumnTotal.MinWidth = 74;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 14;
            this.gridColumnTotal.Width = 74;
            // 
            // gridColumnAlmacen
            // 
            this.gridColumnAlmacen.AppearanceHeader.Options.UseFont = true;
            this.gridColumnAlmacen.Caption = "Almacén";
            this.gridColumnAlmacen.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacen.FieldName = "almacen_id";
            this.gridColumnAlmacen.MinWidth = 32;
            this.gridColumnAlmacen.Name = "gridColumnAlmacen";
            this.gridColumnAlmacen.Visible = true;
            this.gridColumnAlmacen.VisibleIndex = 15;
            this.gridColumnAlmacen.Width = 32;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.AutoHeight = false;
            this.cbAlmacenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Name = "cbAlmacenes";
            // 
            // gridColumnUbicacion
            // 
            this.gridColumnUbicacion.AppearanceHeader.Options.UseFont = true;
            this.gridColumnUbicacion.Caption = "Ubicación";
            this.gridColumnUbicacion.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacion.FieldName = "ubicacion_id";
            this.gridColumnUbicacion.MinWidth = 32;
            this.gridColumnUbicacion.Name = "gridColumnUbicacion";
            this.gridColumnUbicacion.Visible = true;
            this.gridColumnUbicacion.VisibleIndex = 16;
            this.gridColumnUbicacion.Width = 32;
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.AutoHeight = false;
            this.cbUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUbicaciones.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ubicacion", "Ubicación", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUbicaciones.Name = "cbUbicaciones";
            // 
            // gridColumnAlmacenDestino
            // 
            this.gridColumnAlmacenDestino.AppearanceHeader.Options.UseFont = true;
            this.gridColumnAlmacenDestino.Caption = "Almacén destino";
            this.gridColumnAlmacenDestino.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacenDestino.FieldName = "almacen_destino_id";
            this.gridColumnAlmacenDestino.MinWidth = 32;
            this.gridColumnAlmacenDestino.Name = "gridColumnAlmacenDestino";
            this.gridColumnAlmacenDestino.Visible = true;
            this.gridColumnAlmacenDestino.VisibleIndex = 17;
            this.gridColumnAlmacenDestino.Width = 32;
            // 
            // gridColumnUbicacionDestino
            // 
            this.gridColumnUbicacionDestino.AppearanceHeader.Options.UseFont = true;
            this.gridColumnUbicacionDestino.Caption = "Ubicación destino";
            this.gridColumnUbicacionDestino.ColumnEdit = this.cbUbicaciones;
            this.gridColumnUbicacionDestino.FieldName = "ubicacion_destino_id";
            this.gridColumnUbicacionDestino.MinWidth = 32;
            this.gridColumnUbicacionDestino.Name = "gridColumnUbicacionDestino";
            this.gridColumnUbicacionDestino.Visible = true;
            this.gridColumnUbicacionDestino.VisibleIndex = 18;
            this.gridColumnUbicacionDestino.Width = 32;
            // 
            // gridColumnComentario
            // 
            this.gridColumnComentario.Caption = "Comentario";
            this.gridColumnComentario.FieldName = "comentario";
            this.gridColumnComentario.MinWidth = 32;
            this.gridColumnComentario.Name = "gridColumnComentario";
            this.gridColumnComentario.Width = 44;
            // 
            // gridColumnDescuentoEspecial
            // 
            this.gridColumnDescuentoEspecial.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDescuentoEspecial.Caption = "DE";
            this.gridColumnDescuentoEspecial.FieldName = "descuento_especial_id";
            this.gridColumnDescuentoEspecial.MaxWidth = 32;
            this.gridColumnDescuentoEspecial.MinWidth = 21;
            this.gridColumnDescuentoEspecial.Name = "gridColumnDescuentoEspecial";
            this.gridColumnDescuentoEspecial.Visible = true;
            this.gridColumnDescuentoEspecial.VisibleIndex = 19;
            this.gridColumnDescuentoEspecial.Width = 21;
            // 
            // gridColumnNumeroPedimento
            // 
            this.gridColumnNumeroPedimento.Caption = "N° Pedimento";
            this.gridColumnNumeroPedimento.FieldName = "numero_pedimento";
            this.gridColumnNumeroPedimento.MaxWidth = 141;
            this.gridColumnNumeroPedimento.MinWidth = 32;
            this.gridColumnNumeroPedimento.Name = "gridColumnNumeroPedimento";
            this.gridColumnNumeroPedimento.Width = 141;
            // 
            // gridColumndisponible
            // 
            this.gridColumndisponible.AppearanceHeader.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumndisponible.AppearanceHeader.Options.UseFont = true;
            this.gridColumndisponible.Caption = "Disponible";
            this.gridColumndisponible.DisplayFormat.FormatString = "N0";
            this.gridColumndisponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumndisponible.FieldName = "disponible";
            this.gridColumndisponible.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumndisponible.MinWidth = 25;
            this.gridColumndisponible.Name = "gridColumndisponible";
            this.gridColumndisponible.Visible = true;
            this.gridColumndisponible.VisibleIndex = 5;
            this.gridColumndisponible.Width = 91;
            // 
            // cbAlmacenesDestino
            // 
            this.cbAlmacenesDestino.AutoHeight = false;
            this.cbAlmacenesDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenesDestino.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenesDestino.Name = "cbAlmacenesDestino";
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 432;
            this.gridView2.GridControl = this.gcPartidas;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 1000;
            // 
            // xtraTabPageLogistica
            // 
            this.xtraTabPageLogistica.Controls.Add(this.btnEstatusCartaPorte);
            this.xtraTabPageLogistica.Controls.Add(this.dtHoraLlegada);
            this.xtraTabPageLogistica.Controls.Add(this.dtHoraSalida);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl6);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl5);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl4);
            this.xtraTabPageLogistica.Controls.Add(this.labelControl3);
            this.xtraTabPageLogistica.Controls.Add(this.dtFechaSalida);
            this.xtraTabPageLogistica.Controls.Add(this.dtFechaLlegada);
            this.xtraTabPageLogistica.Controls.Add(this.btnGenerarCartaPorte);
            this.xtraTabPageLogistica.Controls.Add(this.chckCartaPorte);
            this.xtraTabPageLogistica.Controls.Add(this.btnAgregarDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.txtDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.cbDireccionesOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.lblDireccionOrigen);
            this.xtraTabPageLogistica.Controls.Add(this.lblDistancia);
            this.xtraTabPageLogistica.Controls.Add(this.txtDistancia);
            this.xtraTabPageLogistica.Controls.Add(this.cbRutas);
            this.xtraTabPageLogistica.Controls.Add(this.lblRuta);
            this.xtraTabPageLogistica.Controls.Add(this.cbVehiculos);
            this.xtraTabPageLogistica.Controls.Add(this.lblVehiculo);
            this.xtraTabPageLogistica.Controls.Add(this.cbChoferes);
            this.xtraTabPageLogistica.Controls.Add(this.lblChofer);
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
            this.xtraTabPageLogistica.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.xtraTabPageLogistica.Name = "xtraTabPageLogistica";
            this.xtraTabPageLogistica.Size = new System.Drawing.Size(1473, 896);
            this.xtraTabPageLogistica.Text = "Logística";
            // 
            // btnEstatusCartaPorte
            // 
            this.btnEstatusCartaPorte.BackColor = System.Drawing.Color.Transparent;
            this.btnEstatusCartaPorte.Location = new System.Drawing.Point(1219, 17);
            this.btnEstatusCartaPorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstatusCartaPorte.Name = "btnEstatusCartaPorte";
            this.btnEstatusCartaPorte.Size = new System.Drawing.Size(44, 36);
            this.btnEstatusCartaPorte.TabIndex = 183;
            this.btnEstatusCartaPorte.UseVisualStyleBackColor = false;
            // 
            // dtHoraLlegada
            // 
            this.dtHoraLlegada.CustomFormat = "HH:mm:ss";
            this.dtHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraLlegada.Location = new System.Drawing.Point(1129, 320);
            this.dtHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtHoraLlegada.Name = "dtHoraLlegada";
            this.dtHoraLlegada.ShowUpDown = true;
            this.dtHoraLlegada.Size = new System.Drawing.Size(134, 28);
            this.dtHoraLlegada.TabIndex = 182;
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.CustomFormat = "HH:mm:ss";
            this.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraSalida.Location = new System.Drawing.Point(1129, 269);
            this.dtHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.ShowUpDown = true;
            this.dtHoraSalida.Size = new System.Drawing.Size(134, 28);
            this.dtHoraSalida.TabIndex = 181;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(1061, 332);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 21);
            this.labelControl6.TabIndex = 180;
            this.labelControl6.Text = "Hora";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(1061, 278);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 21);
            this.labelControl5.TabIndex = 179;
            this.labelControl5.Text = "Hora";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(682, 332);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(144, 21);
            this.labelControl4.TabIndex = 178;
            this.labelControl4.Text = "Fecha de Llegada";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(682, 280);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 21);
            this.labelControl3.TabIndex = 177;
            this.labelControl3.Text = "Fecha de Salida";
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.EditValue = null;
            this.dtFechaSalida.Location = new System.Drawing.Point(848, 269);
            this.dtFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaSalida.MenuManager = this.mainRibbonControl;
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSalida.Size = new System.Drawing.Size(206, 28);
            this.dtFechaSalida.TabIndex = 176;
            // 
            // dtFechaLlegada
            // 
            this.dtFechaLlegada.EditValue = null;
            this.dtFechaLlegada.Location = new System.Drawing.Point(848, 324);
            this.dtFechaLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaLlegada.MenuManager = this.mainRibbonControl;
            this.dtFechaLlegada.Name = "dtFechaLlegada";
            this.dtFechaLlegada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaLlegada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaLlegada.Size = new System.Drawing.Size(206, 28);
            this.dtFechaLlegada.TabIndex = 175;
            // 
            // btnGenerarCartaPorte
            // 
            this.btnGenerarCartaPorte.Location = new System.Drawing.Point(1049, 10);
            this.btnGenerarCartaPorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarCartaPorte.Name = "btnGenerarCartaPorte";
            this.btnGenerarCartaPorte.Size = new System.Drawing.Size(162, 42);
            this.btnGenerarCartaPorte.TabIndex = 174;
            this.btnGenerarCartaPorte.Text = "Generar ";
            this.btnGenerarCartaPorte.Click += new System.EventHandler(this.btnGenerarCartaPorte_Click);
            // 
            // chckCartaPorte
            // 
            this.chckCartaPorte.Location = new System.Drawing.Point(836, 20);
            this.chckCartaPorte.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.chckCartaPorte.MenuManager = this.mainRibbonControl;
            this.chckCartaPorte.Name = "chckCartaPorte";
            this.chckCartaPorte.Properties.Caption = "Generar Carta Porte";
            this.chckCartaPorte.Size = new System.Drawing.Size(202, 25);
            this.chckCartaPorte.TabIndex = 173;
            this.chckCartaPorte.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // btnAgregarDireccionOrigen
            // 
            this.btnAgregarDireccionOrigen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionOrigen.Location = new System.Drawing.Point(562, 437);
            this.btnAgregarDireccionOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAgregarDireccionOrigen.Name = "btnAgregarDireccionOrigen";
            this.btnAgregarDireccionOrigen.Size = new System.Drawing.Size(102, 32);
            this.btnAgregarDireccionOrigen.TabIndex = 169;
            this.btnAgregarDireccionOrigen.TabStop = false;
            this.btnAgregarDireccionOrigen.Text = "Agregar";
            this.btnAgregarDireccionOrigen.Click += new System.EventHandler(this.btnAgregarDireccionOrigen_Click);
            // 
            // txtDireccionOrigen
            // 
            this.txtDireccionOrigen.Location = new System.Drawing.Point(189, 479);
            this.txtDireccionOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDireccionOrigen.MenuManager = this.mainRibbonControl;
            this.txtDireccionOrigen.Name = "txtDireccionOrigen";
            this.txtDireccionOrigen.Properties.ReadOnly = true;
            this.txtDireccionOrigen.Size = new System.Drawing.Size(364, 106);
            this.txtDireccionOrigen.TabIndex = 170;
            this.txtDireccionOrigen.TabStop = false;
            // 
            // cbDireccionesOrigen
            // 
            this.cbDireccionesOrigen.Location = new System.Drawing.Point(189, 437);
            this.cbDireccionesOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbDireccionesOrigen.MenuManager = this.mainRibbonControl;
            this.cbDireccionesOrigen.Name = "cbDireccionesOrigen";
            this.cbDireccionesOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesOrigen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesOrigen.Properties.NullText = "";
            this.cbDireccionesOrigen.Size = new System.Drawing.Size(364, 28);
            this.cbDireccionesOrigen.TabIndex = 171;
            this.cbDireccionesOrigen.EditValueChanged += new System.EventHandler(this.cbDireccionesFacturacion_EditValueChanged);
            // 
            // lblDireccionOrigen
            // 
            this.lblDireccionOrigen.Location = new System.Drawing.Point(19, 441);
            this.lblDireccionOrigen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblDireccionOrigen.Name = "lblDireccionOrigen";
            this.lblDireccionOrigen.Size = new System.Drawing.Size(126, 21);
            this.lblDireccionOrigen.TabIndex = 172;
            this.lblDireccionOrigen.Text = "Dirección origen";
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(21, 599);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(120, 21);
            this.lblDistancia.TabIndex = 166;
            this.lblDistancia.Text = "Distancia (Km)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Enabled = false;
            this.txtDistancia.Location = new System.Drawing.Point(189, 595);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Properties.MaxLength = 18;
            this.txtDistancia.Size = new System.Drawing.Size(364, 28);
            this.txtDistancia.TabIndex = 165;
            // 
            // cbRutas
            // 
            this.cbRutas.Enabled = false;
            this.cbRutas.Location = new System.Drawing.Point(848, 224);
            this.cbRutas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbRutas.MenuManager = this.mainRibbonControl;
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRutas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRutas.Properties.NullText = "";
            this.cbRutas.Size = new System.Drawing.Size(416, 28);
            this.cbRutas.TabIndex = 145;
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(682, 232);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(39, 21);
            this.lblRuta.TabIndex = 146;
            this.lblRuta.Text = "Ruta";
            this.lblRuta.Click += new System.EventHandler(this.lblRuta_Click);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.Location = new System.Drawing.Point(848, 167);
            this.cbVehiculos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbVehiculos.MenuManager = this.mainRibbonControl;
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVehiculos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVehiculos.Properties.NullText = "";
            this.cbVehiculos.Size = new System.Drawing.Size(416, 28);
            this.cbVehiculos.TabIndex = 6;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVehiculo.Location = new System.Drawing.Point(682, 175);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(67, 21);
            this.lblVehiculo.TabIndex = 135;
            this.lblVehiculo.Text = "Vehículo";
            this.lblVehiculo.Click += new System.EventHandler(this.lblVehiculo_Click);
            // 
            // cbChoferes
            // 
            this.cbChoferes.Location = new System.Drawing.Point(848, 117);
            this.cbChoferes.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbChoferes.MenuManager = this.mainRibbonControl;
            this.cbChoferes.Name = "cbChoferes";
            this.cbChoferes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChoferes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbChoferes.Properties.NullText = "";
            this.cbChoferes.Size = new System.Drawing.Size(416, 28);
            this.cbChoferes.TabIndex = 5;
            // 
            // lblChofer
            // 
            this.lblChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChofer.Location = new System.Drawing.Point(682, 126);
            this.lblChofer.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(52, 21);
            this.lblChofer.TabIndex = 133;
            this.lblChofer.Text = "Chofer";
            this.lblChofer.Click += new System.EventHandler(this.lblChofer_Click);
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActualizacion.Location = new System.Drawing.Point(19, 747);
            this.lblActualizacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(108, 21);
            this.lblActualizacion.TabIndex = 130;
            this.lblActualizacion.Text = "Actualización";
            // 
            // lblSincronizacion
            // 
            this.lblSincronizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSincronizacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSincronizacion.Location = new System.Drawing.Point(289, 747);
            this.lblSincronizacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSincronizacion.Name = "lblSincronizacion";
            this.lblSincronizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSincronizacion.Size = new System.Drawing.Size(1080, 21);
            this.lblSincronizacion.TabIndex = 129;
            this.lblSincronizacion.Text = "Sincronización";
            // 
            // cbPersonasContacto
            // 
            this.cbPersonasContacto.Location = new System.Drawing.Point(189, 634);
            this.cbPersonasContacto.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbPersonasContacto.MenuManager = this.mainRibbonControl;
            this.cbPersonasContacto.Name = "cbPersonasContacto";
            this.cbPersonasContacto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPersonasContacto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPersonasContacto.Properties.NullText = "";
            this.cbPersonasContacto.Size = new System.Drawing.Size(364, 28);
            this.cbPersonasContacto.TabIndex = 3;
            // 
            // lblPersonasContacto
            // 
            this.lblPersonasContacto.Location = new System.Drawing.Point(19, 640);
            this.lblPersonasContacto.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblPersonasContacto.Name = "lblPersonasContacto";
            this.lblPersonasContacto.Size = new System.Drawing.Size(165, 21);
            this.lblPersonasContacto.TabIndex = 128;
            this.lblPersonasContacto.Text = "Persona de contacto";
            // 
            // cbClasesExpedicion
            // 
            this.cbClasesExpedicion.Location = new System.Drawing.Point(848, 62);
            this.cbClasesExpedicion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbClasesExpedicion.MenuManager = this.mainRibbonControl;
            this.cbClasesExpedicion.Name = "cbClasesExpedicion";
            this.cbClasesExpedicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClasesExpedicion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbClasesExpedicion.Properties.NullText = "";
            this.cbClasesExpedicion.Size = new System.Drawing.Size(416, 28);
            this.cbClasesExpedicion.TabIndex = 4;
            // 
            // lblClaseExpedicion
            // 
            this.lblClaseExpedicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClaseExpedicion.Location = new System.Drawing.Point(682, 62);
            this.lblClaseExpedicion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblClaseExpedicion.Name = "lblClaseExpedicion";
            this.lblClaseExpedicion.Size = new System.Drawing.Size(130, 21);
            this.lblClaseExpedicion.TabIndex = 126;
            this.lblClaseExpedicion.Text = "Clase expedición";
            // 
            // lblCreacion
            // 
            this.lblCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreacion.Location = new System.Drawing.Point(20, 716);
            this.lblCreacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(69, 21);
            this.lblCreacion.TabIndex = 124;
            this.lblCreacion.Text = "Creación";
            // 
            // btnDireccionFacturacion
            // 
            this.btnDireccionFacturacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDireccionFacturacion.Location = new System.Drawing.Point(562, 21);
            this.btnDireccionFacturacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDireccionFacturacion.Name = "btnDireccionFacturacion";
            this.btnDireccionFacturacion.Size = new System.Drawing.Size(91, 32);
            this.btnDireccionFacturacion.TabIndex = 0;
            this.btnDireccionFacturacion.TabStop = false;
            this.btnDireccionFacturacion.Text = "Agregar";
            this.btnDireccionFacturacion.Click += new System.EventHandler(this.btnDireccionFacturacion_Click);
            // 
            // btnAgregarDireccionEnvio
            // 
            this.btnAgregarDireccionEnvio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarDireccionEnvio.Location = new System.Drawing.Point(562, 229);
            this.btnAgregarDireccionEnvio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAgregarDireccionEnvio.Name = "btnAgregarDireccionEnvio";
            this.btnAgregarDireccionEnvio.Size = new System.Drawing.Size(91, 32);
            this.btnAgregarDireccionEnvio.TabIndex = 0;
            this.btnAgregarDireccionEnvio.TabStop = false;
            this.btnAgregarDireccionEnvio.Text = "Agregar";
            this.btnAgregarDireccionEnvio.Click += new System.EventHandler(this.btnAgregarDireccionEnvio_Click);
            // 
            // txtDireccionEnvio
            // 
            this.txtDireccionEnvio.Location = new System.Drawing.Point(189, 271);
            this.txtDireccionEnvio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDireccionEnvio.MenuManager = this.mainRibbonControl;
            this.txtDireccionEnvio.Name = "txtDireccionEnvio";
            this.txtDireccionEnvio.Properties.ReadOnly = true;
            this.txtDireccionEnvio.Size = new System.Drawing.Size(364, 156);
            this.txtDireccionEnvio.TabIndex = 0;
            this.txtDireccionEnvio.TabStop = false;
            // 
            // txtDireccionFacturacion
            // 
            this.txtDireccionFacturacion.Location = new System.Drawing.Point(189, 63);
            this.txtDireccionFacturacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDireccionFacturacion.MenuManager = this.mainRibbonControl;
            this.txtDireccionFacturacion.Name = "txtDireccionFacturacion";
            this.txtDireccionFacturacion.Properties.ReadOnly = true;
            this.txtDireccionFacturacion.Size = new System.Drawing.Size(364, 156);
            this.txtDireccionFacturacion.TabIndex = 0;
            this.txtDireccionFacturacion.TabStop = false;
            // 
            // cbDireccionesEnvio
            // 
            this.cbDireccionesEnvio.Location = new System.Drawing.Point(189, 229);
            this.cbDireccionesEnvio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbDireccionesEnvio.MenuManager = this.mainRibbonControl;
            this.cbDireccionesEnvio.Name = "cbDireccionesEnvio";
            this.cbDireccionesEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesEnvio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesEnvio.Properties.NullText = "";
            this.cbDireccionesEnvio.Size = new System.Drawing.Size(364, 28);
            this.cbDireccionesEnvio.TabIndex = 1;
            this.cbDireccionesEnvio.EditValueChanged += new System.EventHandler(this.cbDireccionesFacturacion_EditValueChanged);
            // 
            // lblDireccionEnvio
            // 
            this.lblDireccionEnvio.Location = new System.Drawing.Point(19, 232);
            this.lblDireccionEnvio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblDireccionEnvio.Name = "lblDireccionEnvio";
            this.lblDireccionEnvio.Size = new System.Drawing.Size(121, 21);
            this.lblDireccionEnvio.TabIndex = 78;
            this.lblDireccionEnvio.Text = "Dirección envío";
            // 
            // cbDireccionesFacturacion
            // 
            this.cbDireccionesFacturacion.Location = new System.Drawing.Point(189, 21);
            this.cbDireccionesFacturacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbDireccionesFacturacion.MenuManager = this.mainRibbonControl;
            this.cbDireccionesFacturacion.Name = "cbDireccionesFacturacion";
            this.cbDireccionesFacturacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesFacturacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesFacturacion.Properties.NullText = "";
            this.cbDireccionesFacturacion.Size = new System.Drawing.Size(364, 28);
            this.cbDireccionesFacturacion.TabIndex = 0;
            this.cbDireccionesFacturacion.EditValueChanged += new System.EventHandler(this.cbDireccionesFacturacion_EditValueChanged);
            // 
            // lblDireccionFacturacion
            // 
            this.lblDireccionFacturacion.Location = new System.Drawing.Point(19, 25);
            this.lblDireccionFacturacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblDireccionFacturacion.Name = "lblDireccionFacturacion";
            this.lblDireccionFacturacion.Size = new System.Drawing.Size(168, 21);
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
            this.xtraTabPageFinanzas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.xtraTabPageFinanzas.Name = "xtraTabPageFinanzas";
            this.xtraTabPageFinanzas.Size = new System.Drawing.Size(1473, 896);
            this.xtraTabPageFinanzas.Text = "Finanzas";
            // 
            // cbProyectos
            // 
            this.cbProyectos.Location = new System.Drawing.Point(189, 104);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbProyectos.MenuManager = this.mainRibbonControl;
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProyectos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbProyectos.Properties.NullText = "";
            this.cbProyectos.Size = new System.Drawing.Size(364, 28);
            this.cbProyectos.TabIndex = 146;
            // 
            // lblProyectos
            // 
            this.lblProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProyectos.Location = new System.Drawing.Point(19, 106);
            this.lblProyectos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(71, 21);
            this.lblProyectos.TabIndex = 147;
            this.lblProyectos.Text = "Proyecto";
            // 
            // cbCanales
            // 
            this.cbCanales.Location = new System.Drawing.Point(189, 143);
            this.cbCanales.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbCanales.MenuManager = this.mainRibbonControl;
            this.cbCanales.Name = "cbCanales";
            this.cbCanales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCanales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCanales.Properties.NullText = "";
            this.cbCanales.Size = new System.Drawing.Size(364, 28);
            this.cbCanales.TabIndex = 143;
            // 
            // lblCanal
            // 
            this.lblCanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCanal.Location = new System.Drawing.Point(19, 145);
            this.lblCanal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(47, 21);
            this.lblCanal.TabIndex = 144;
            this.lblCanal.Text = "Canal";
            this.lblCanal.Click += new System.EventHandler(this.lblCanal_Click);
            // 
            // lbReferencias
            // 
            this.lbReferencias.Location = new System.Drawing.Point(189, 315);
            this.lbReferencias.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lbReferencias.Name = "lbReferencias";
            this.lbReferencias.Size = new System.Drawing.Size(364, 179);
            this.lbReferencias.TabIndex = 88;
            this.lbReferencias.Visible = false;
            this.lbReferencias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbReferencias_KeyDown);
            // 
            // btnReferencias
            // 
            this.btnReferencias.Location = new System.Drawing.Point(189, 269);
            this.btnReferencias.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnReferencias.Name = "btnReferencias";
            this.btnReferencias.Size = new System.Drawing.Size(364, 38);
            this.btnReferencias.TabIndex = 0;
            this.btnReferencias.TabStop = false;
            this.btnReferencias.Text = "Referencias";
            this.btnReferencias.Click += new System.EventHandler(this.btnReferencias_Click);
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.Location = new System.Drawing.Point(21, 231);
            this.lblOrdenCompra.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(142, 21);
            this.lblOrdenCompra.TabIndex = 86;
            this.lblOrdenCompra.Text = "Orden de compra";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(189, 227);
            this.txtOrdenCompra.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.MaxLength = 15;
            this.txtOrdenCompra.Size = new System.Drawing.Size(364, 28);
            this.txtOrdenCompra.TabIndex = 4;
            // 
            // lblCuentaPago
            // 
            this.lblCuentaPago.Location = new System.Drawing.Point(21, 189);
            this.lblCuentaPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCuentaPago.Name = "lblCuentaPago";
            this.lblCuentaPago.Size = new System.Drawing.Size(130, 21);
            this.lblCuentaPago.TabIndex = 84;
            this.lblCuentaPago.Text = "Cuenta de pago";
            // 
            // txtCuentaPago
            // 
            this.txtCuentaPago.Location = new System.Drawing.Point(189, 185);
            this.txtCuentaPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCuentaPago.Name = "txtCuentaPago";
            this.txtCuentaPago.Properties.MaxLength = 18;
            this.txtCuentaPago.Size = new System.Drawing.Size(364, 28);
            this.txtCuentaPago.TabIndex = 3;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(189, 63);
            this.cbMetodosPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbMetodosPago.MenuManager = this.mainRibbonControl;
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Properties.NullText = "";
            this.cbMetodosPago.Size = new System.Drawing.Size(364, 28);
            this.cbMetodosPago.TabIndex = 1;
            // 
            // lblMetodosPago
            // 
            this.lblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodosPago.Location = new System.Drawing.Point(19, 67);
            this.lblMetodosPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(134, 21);
            this.lblMetodosPago.TabIndex = 82;
            this.lblMetodosPago.Text = "Método de pago";
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(189, 21);
            this.cbCondicionesPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbCondicionesPago.MenuManager = this.mainRibbonControl;
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Properties.NullText = "";
            this.cbCondicionesPago.Size = new System.Drawing.Size(364, 28);
            this.cbCondicionesPago.TabIndex = 0;
            this.cbCondicionesPago.EditValueChanged += new System.EventHandler(this.cbCondicionesPago_EditValueChanged);
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCondicionesPago.Location = new System.Drawing.Point(19, 25);
            this.lblCondicionesPago.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(165, 21);
            this.lblCondicionesPago.TabIndex = 81;
            this.lblCondicionesPago.Text = "Condiciones de pago";
            // 
            // xtraTabPageDocumentoElectronico
            // 
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbGlobal);
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
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnCancelar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbUsoPrincipal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblUsoPrincipal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.btnGenerar);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtSelloCFD);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblSelloCFD);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblCadenaOriginal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.lblFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.txtFolioFiscal);
            this.xtraTabPageDocumentoElectronico.Controls.Add(this.cbGenerarDocumentoElectronico);
            this.xtraTabPageDocumentoElectronico.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.xtraTabPageDocumentoElectronico.Name = "xtraTabPageDocumentoElectronico";
            this.xtraTabPageDocumentoElectronico.Size = new System.Drawing.Size(1473, 896);
            this.xtraTabPageDocumentoElectronico.Text = "Documento electrónico";
            // 
            // cbGlobal
            // 
            this.cbGlobal.Location = new System.Drawing.Point(802, 67);
            this.cbGlobal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbGlobal.MenuManager = this.mainRibbonControl;
            this.cbGlobal.Name = "cbGlobal";
            this.cbGlobal.Properties.Caption = "Factura global";
            this.cbGlobal.Size = new System.Drawing.Size(219, 25);
            this.cbGlobal.TabIndex = 109;
            this.cbGlobal.Visible = false;
            // 
            // btnEliminarDE
            // 
            this.btnEliminarDE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEliminarDE.Location = new System.Drawing.Point(548, 737);
            this.btnEliminarDE.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnEliminarDE.Name = "btnEliminarDE";
            this.btnEliminarDE.Size = new System.Drawing.Size(228, 38);
            this.btnEliminarDE.TabIndex = 107;
            this.btnEliminarDE.TabStop = false;
            this.btnEliminarDE.Text = "Elimar registro";
            this.btnEliminarDE.Click += new System.EventHandler(this.btnEliminarDE_Click);
            // 
            // lblRFC
            // 
            this.lblRFC.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblRFC.Appearance.Options.UseForeColor = true;
            this.lblRFC.Location = new System.Drawing.Point(499, 32);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(32, 21);
            this.lblRFC.TabIndex = 106;
            this.lblRFC.Text = "RFC";
            // 
            // btnGenerarRFCGenerico
            // 
            this.btnGenerarRFCGenerico.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerarRFCGenerico.Location = new System.Drawing.Point(159, 641);
            this.btnGenerarRFCGenerico.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGenerarRFCGenerico.Name = "btnGenerarRFCGenerico";
            this.btnGenerarRFCGenerico.Size = new System.Drawing.Size(279, 38);
            this.btnGenerarRFCGenerico.TabIndex = 105;
            this.btnGenerarRFCGenerico.TabStop = false;
            this.btnGenerarRFCGenerico.Text = "Generar con RFC genérico";
            this.btnGenerarRFCGenerico.Click += new System.EventHandler(this.btnGenerarRFCGenerico_Click);
            // 
            // lblCancelacionMasiva
            // 
            this.lblCancelacionMasiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelacionMasiva.Location = new System.Drawing.Point(619, 689);
            this.lblCancelacionMasiva.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCancelacionMasiva.Name = "lblCancelacionMasiva";
            this.lblCancelacionMasiva.Size = new System.Drawing.Size(160, 21);
            this.lblCancelacionMasiva.TabIndex = 104;
            this.lblCancelacionMasiva.Text = "Cancelación masiva";
            this.lblCancelacionMasiva.Visible = false;
            this.lblCancelacionMasiva.Click += new System.EventHandler(this.lblCancelacionMasiva_Click);
            // 
            // lblUUIDErrorCancelacion
            // 
            this.lblUUIDErrorCancelacion.Location = new System.Drawing.Point(802, 448);
            this.lblUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblUUIDErrorCancelacion.Name = "lblUUIDErrorCancelacion";
            this.lblUUIDErrorCancelacion.Size = new System.Drawing.Size(216, 21);
            this.lblUUIDErrorCancelacion.TabIndex = 103;
            this.lblUUIDErrorCancelacion.Text = "UUIDs con error al cancelar";
            this.lblUUIDErrorCancelacion.Visible = false;
            // 
            // lblUUIDPorCancelar
            // 
            this.lblUUIDPorCancelar.Location = new System.Drawing.Point(802, 157);
            this.lblUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblUUIDPorCancelar.Name = "lblUUIDPorCancelar";
            this.lblUUIDPorCancelar.Size = new System.Drawing.Size(153, 21);
            this.lblUUIDPorCancelar.TabIndex = 102;
            this.lblUUIDPorCancelar.Text = "UUIDs por cancelar";
            this.lblUUIDPorCancelar.Visible = false;
            // 
            // txtUUIDErrorCancelacion
            // 
            this.txtUUIDErrorCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDErrorCancelacion.Location = new System.Drawing.Point(802, 479);
            this.txtUUIDErrorCancelacion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtUUIDErrorCancelacion.Name = "txtUUIDErrorCancelacion";
            this.txtUUIDErrorCancelacion.Size = new System.Drawing.Size(545, 151);
            this.txtUUIDErrorCancelacion.TabIndex = 101;
            this.txtUUIDErrorCancelacion.Text = "";
            this.txtUUIDErrorCancelacion.Visible = false;
            // 
            // txtUUIDPorCancelar
            // 
            this.txtUUIDPorCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUUIDPorCancelar.Location = new System.Drawing.Point(802, 189);
            this.txtUUIDPorCancelar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtUUIDPorCancelar.Name = "txtUUIDPorCancelar";
            this.txtUUIDPorCancelar.Size = new System.Drawing.Size(545, 245);
            this.txtUUIDPorCancelar.TabIndex = 100;
            this.txtUUIDPorCancelar.Text = "";
            this.txtUUIDPorCancelar.Visible = false;
            // 
            // btnCancelacionMasiva
            // 
            this.btnCancelacionMasiva.Location = new System.Drawing.Point(1134, 641);
            this.btnCancelacionMasiva.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancelacionMasiva.Name = "btnCancelacionMasiva";
            this.btnCancelacionMasiva.Size = new System.Drawing.Size(218, 38);
            this.btnCancelacionMasiva.TabIndex = 99;
            this.btnCancelacionMasiva.Text = "Cancelación masiva";
            this.btnCancelacionMasiva.UseVisualStyleBackColor = true;
            this.btnCancelacionMasiva.Visible = false;
            this.btnCancelacionMasiva.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEstadoCFDI
            // 
            this.btnEstadoCFDI.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEstadoCFDI.Location = new System.Drawing.Point(450, 641);
            this.btnEstadoCFDI.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnEstadoCFDI.Name = "btnEstadoCFDI";
            this.btnEstadoCFDI.Size = new System.Drawing.Size(159, 38);
            this.btnEstadoCFDI.TabIndex = 0;
            this.btnEstadoCFDI.TabStop = false;
            this.btnEstadoCFDI.Text = "Estado CFDI";
            this.btnEstadoCFDI.Click += new System.EventHandler(this.btnEstadoCFDI_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancelar.Location = new System.Drawing.Point(619, 641);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(186, 67);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Properties.NullText = "";
            this.cbUsoPrincipal.Size = new System.Drawing.Size(589, 28);
            this.cbUsoPrincipal.TabIndex = 1;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(19, 73);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(103, 21);
            this.lblUsoPrincipal.TabIndex = 96;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // btnGenerar
            // 
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenerar.Location = new System.Drawing.Point(19, 641);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 38);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnCFDI_Click);
            // 
            // txtSelloCFD
            // 
            this.txtSelloCFD.Enabled = false;
            this.txtSelloCFD.Location = new System.Drawing.Point(19, 476);
            this.txtSelloCFD.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSelloCFD.MenuManager = this.mainRibbonControl;
            this.txtSelloCFD.Name = "txtSelloCFD";
            this.txtSelloCFD.Size = new System.Drawing.Size(754, 156);
            this.txtSelloCFD.TabIndex = 3;
            // 
            // lblSelloCFD
            // 
            this.lblSelloCFD.Location = new System.Drawing.Point(19, 445);
            this.lblSelloCFD.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblSelloCFD.Name = "lblSelloCFD";
            this.lblSelloCFD.Size = new System.Drawing.Size(75, 21);
            this.lblSelloCFD.TabIndex = 94;
            this.lblSelloCFD.Text = "Sello CFD";
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Enabled = false;
            this.txtCadenaOriginal.Location = new System.Drawing.Point(19, 188);
            this.txtCadenaOriginal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCadenaOriginal.MenuManager = this.mainRibbonControl;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(754, 250);
            this.txtCadenaOriginal.TabIndex = 2;
            // 
            // lblCadenaOriginal
            // 
            this.lblCadenaOriginal.Location = new System.Drawing.Point(19, 157);
            this.lblCadenaOriginal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblCadenaOriginal.Name = "lblCadenaOriginal";
            this.lblCadenaOriginal.Size = new System.Drawing.Size(127, 21);
            this.lblCadenaOriginal.TabIndex = 92;
            this.lblCadenaOriginal.Text = "Cadena original";
            // 
            // lblFolioFiscal
            // 
            this.lblFolioFiscal.Location = new System.Drawing.Point(19, 115);
            this.lblFolioFiscal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblFolioFiscal.Name = "lblFolioFiscal";
            this.lblFolioFiscal.Size = new System.Drawing.Size(82, 21);
            this.lblFolioFiscal.TabIndex = 90;
            this.lblFolioFiscal.Text = "Folio fiscal";
            // 
            // txtFolioFiscal
            // 
            this.txtFolioFiscal.Location = new System.Drawing.Point(186, 109);
            this.txtFolioFiscal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFolioFiscal.Name = "txtFolioFiscal";
            this.txtFolioFiscal.Properties.ReadOnly = true;
            this.txtFolioFiscal.Size = new System.Drawing.Size(589, 28);
            this.txtFolioFiscal.TabIndex = 1;
            // 
            // cbGenerarDocumentoElectronico
            // 
            this.cbGenerarDocumentoElectronico.Location = new System.Drawing.Point(186, 28);
            this.cbGenerarDocumentoElectronico.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbGenerarDocumentoElectronico.MenuManager = this.mainRibbonControl;
            this.cbGenerarDocumentoElectronico.Name = "cbGenerarDocumentoElectronico";
            this.cbGenerarDocumentoElectronico.Properties.Caption = "Generar documento electrónico";
            this.cbGenerarDocumentoElectronico.Size = new System.Drawing.Size(302, 25);
            this.cbGenerarDocumentoElectronico.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1505, 957);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1485, 937);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 1065);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmDocumentos.IconOptions.Image")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmDocumentos";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDocumentos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenesDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPageLogistica.ResumeLayout(false);
            this.xtraTabPageLogistica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaLlegada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckCartaPorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SimpleButton btnCargaArticulos;
        private OpenFileDialog openFileDialog1;
        private LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private ToolTip toolTip1;
        private Button btnStat;
        private LabelControl lbFact;
        private LabelControl lbCredito;
        private TextEdit txtFactVencidas;
        private TextEdit txtCreditoDisponible;
        private LabelControl lbMensajeC;
        private BarButtonItem barButtonItem1;
        private ListBoxControl listBoxControl1;
        private PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlVolumen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlMonto;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDescuentoDir;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private LabelControl labelControl2;
        private PanelControl panelControl1;
        private PictureBox picturesku;
        private BarButtonItem bbiXML;
        private CheckEdit chckCartaPorte;
        private SimpleButton btnGenerarCartaPorte;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private DateEdit dtFechaSalida;
        private DateEdit dtFechaLlegada;
        private GridControl gcPartidas;
        private GridView gvPartidas;
        private GridColumn gridColumnNo;
        private GridColumn gridColumnCantidad;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private GridColumn gridColumnPeso;
        private GridColumn gridColumnStock;
        private GridColumn gridColumnUnidadMedida;
        private RepositoryItemLookUpEdit cbUnidadesMedida;
        private GridColumn gridColumnCantidadEmpaque;
        private GridColumn gridColumnTipoEmpaque;
        private RepositoryItemLookUpEdit cbTiposEmpaques;
        private GridColumn gridColumnCantidadPendiente;
        private GridColumn gridColumnCantidadPaquete;
        private GridColumn gridColumnSKU;
        private GridColumn gridColumnArticulo;
        private GridColumn gridColumnCodigoBarras;
        private GridColumn gridColumnListaPrecio;
        private RepositoryItemLookUpEdit cbListasPrecios;
        private GridColumn gridColumnPrecio;
        private GridColumn gridColumnSubTotal;
        private GridColumn gridColumnImpuesto;
        private GridColumn gridColumnPorcentajeDescuento;
        private GridColumn gridColumnDescuento;
        private GridColumn gridColumnPrecioNeto;
        private GridColumn gridColumnTotal;
        private GridColumn gridColumnAlmacen;
        private RepositoryItemLookUpEdit cbAlmacenes;
        private GridColumn gridColumnUbicacion;
        private RepositoryItemLookUpEdit cbUbicaciones;
        private GridColumn gridColumnAlmacenDestino;
        private GridColumn gridColumnUbicacionDestino;
        private GridColumn gridColumnComentario;
        private GridColumn gridColumnDescuentoEspecial;
        private GridColumn gridColumnNumeroPedimento;
        private RepositoryItemLookUpEdit cbAlmacenesDestino;
        private GridView gridView2;
        private BarButtonItem barButtonItem2;
        private DateTimePicker dtHoraSalida;
        private DateTimePicker dtHoraLlegada;
        private Button btnEstatusCartaPorte;
        private TextBox txtCodigoSN;
        private ListBox listBox1;
        private LabelControl labelControl7;
        private ListBox listBox2;
        private Button button1;
        private GridColumn Option;
        private GridColumn gridColumndisponible;
    }
}