﻿using DevExpress.LookAndFeel;
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
    partial class frmFormSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormSocios));
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
            this.bbiPaquetes = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.cbVIP = new DevExpress.XtraEditors.CheckEdit();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDocumentosVencidos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMonedero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cbRegimenFiscal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRegimenFiscal = new DevExpress.XtraEditors.LabelControl();
            this.cbPropietarios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPropietarios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbAPI = new DevExpress.XtraEditors.CheckEdit();
            this.lblBalance = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbMonedero = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedero = new DevExpress.XtraEditors.LabelControl();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.cbSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.cbEventual = new DevExpress.XtraEditors.CheckEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.cbVendedores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVendedores = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbOrdenCompra = new DevExpress.XtraEditors.CheckEdit();
            this.lblMultiplicador = new DevExpress.XtraEditors.LabelControl();
            this.txtMultiplicador = new DevExpress.XtraEditors.TextEdit();
            this.cbPersonasContacto = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPersonasContacto = new DevExpress.XtraEditors.LabelControl();
            this.cbDireccionesEnvio = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionEnvio = new DevExpress.XtraEditors.LabelControl();
            this.cbDireccionesFacturacion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccionFacturacion = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.lblCuenta = new DevExpress.XtraEditors.LabelControl();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.lblCURP = new DevExpress.XtraEditors.LabelControl();
            this.txtCURP = new DevExpress.XtraEditors.TextEdit();
            this.lblSitioWeb = new DevExpress.XtraEditors.LabelControl();
            this.txtSitioWeb = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono2 = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefonoCelular = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefonoCelular = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.cbTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.cbMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbGruposSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblGrupoSocios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.btnImagen = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblNombreComercial = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageCondicionesPago = new DevExpress.XtraTab.XtraTabPage();
            this.lblDiasExtra = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasExtra = new DevExpress.XtraEditors.TextEdit();
            this.lblCuentaPago = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaPago = new DevExpress.XtraEditors.TextEdit();
            this.lblPorcentajeDescuento = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeDescuento = new DevExpress.XtraEditors.TextEdit();
            this.cbMetodosPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMetodosPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblPorcentajeInteresRetraso = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeInteresRetraso = new DevExpress.XtraEditors.TextEdit();
            this.cbListaPrecios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblListaPrecios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbCondicionesPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCondicionesPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblLimiteCredito = new DevExpress.XtraEditors.LabelControl();
            this.txtLimiteCredito = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPagePersonasContacto = new DevExpress.XtraTab.XtraTabPage();
            this.gcPersonasContacto = new DevExpress.XtraGrid.GridControl();
            this.gvPersonasContacto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbGenero = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageDirecciones = new DevExpress.XtraTab.XtraTabPage();
            this.lblDistancia = new DevExpress.XtraEditors.LabelControl();
            this.txtDistancia = new DevExpress.XtraEditors.TextEdit();
            this.lblDireccionID = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarDireccion = new DevExpress.XtraEditors.SimpleButton();
            this.cbImpuestos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblImpuesto = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblTipoDireccion = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoDireccion = new DevExpress.XtraEditors.LookUpEdit();
            this.btnNuevaDireccion = new DevExpress.XtraEditors.SimpleButton();
            this.cbDirecciones = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.lblCP = new DevExpress.XtraEditors.LabelControl();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.lblCiudad = new DevExpress.XtraEditors.LabelControl();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.cbEstados = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPais = new DevExpress.XtraEditors.LabelControl();
            this.cbPaises = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMunicipio = new DevExpress.XtraEditors.LabelControl();
            this.txtMunicipio = new DevExpress.XtraEditors.TextEdit();
            this.lblColonia = new DevExpress.XtraEditors.LabelControl();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroInterior = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroInterior = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroExterior = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroExterior = new DevExpress.XtraEditors.TextEdit();
            this.lblCalle = new DevExpress.XtraEditors.LabelControl();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.lblNombreDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreDireccion = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.lblRuta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbRutas = new DevExpress.XtraEditors.LookUpEdit();
            this.txtOrdenRuta = new DevExpress.XtraEditors.TextEdit();
            this.lblLatitud = new DevExpress.XtraEditors.LabelControl();
            this.cbFrecuencia = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLongitud = new DevExpress.XtraEditors.LabelControl();
            this.lblFrecuencia = new DevExpress.XtraEditors.LabelControl();
            this.txtLatitud = new DevExpress.XtraEditors.TextEdit();
            this.txtLongitud = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPagePropiedades = new DevExpress.XtraTab.XtraTabPage();
            this.cbPropiedades = new DevExpress.XtraEditors.CheckedListBoxControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropietarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrdenCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplicador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPersonasContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCURP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.xtraTabPageCondicionesPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteresRetraso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCredito.Properties)).BeginInit();
            this.xtraTabPagePersonasContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonasContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonasContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenero)).BeginInit();
            this.xtraTabPageDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDirecciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDireccion.Properties)).BeginInit();
            this.xtraTabPageLogistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFrecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLatitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongitud.Properties)).BeginInit();
            this.xtraTabPagePropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).BeginInit();
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
            this.bbiEliminar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.barButtonItemDescuentos,
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
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Controls.Add(this.backstageViewControl1);
            this.panelControl1.Controls.Add(this.ribbonControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 92);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(961, 711);
            this.panelControl1.TabIndex = 96;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.xtraTabControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 62);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(957, 647);
            this.dataLayoutControl1.TabIndex = 4;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(933, 623);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageCondicionesPago,
            this.xtraTabPagePersonasContacto,
            this.xtraTabPageDirecciones,
            this.xtraTabPageLogistica,
            this.xtraTabPagePropiedades});
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.cbVIP);
            this.xtraTabPageGeneral.Controls.Add(this.cbRegimenFiscal);
            this.xtraTabPageGeneral.Controls.Add(this.lblRegimenFiscal);
            this.xtraTabPageGeneral.Controls.Add(this.cbPropietarios);
            this.xtraTabPageGeneral.Controls.Add(this.lblPropietarios);
            this.xtraTabPageGeneral.Controls.Add(this.cbAPI);
            this.xtraTabPageGeneral.Controls.Add(this.lblBalance);
            this.xtraTabPageGeneral.Controls.Add(this.cbMonedero);
            this.xtraTabPageGeneral.Controls.Add(this.lblMonedero);
            this.xtraTabPageGeneral.Controls.Add(this.cbUsoPrincipal);
            this.xtraTabPageGeneral.Controls.Add(this.cbSocios);
            this.xtraTabPageGeneral.Controls.Add(this.cbEventual);
            this.xtraTabPageGeneral.Controls.Add(this.lblUsoPrincipal);
            this.xtraTabPageGeneral.Controls.Add(this.cbVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.lblVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.cbOrdenCompra);
            this.xtraTabPageGeneral.Controls.Add(this.lblMultiplicador);
            this.xtraTabPageGeneral.Controls.Add(this.txtMultiplicador);
            this.xtraTabPageGeneral.Controls.Add(this.cbPersonasContacto);
            this.xtraTabPageGeneral.Controls.Add(this.lblPersonasContacto);
            this.xtraTabPageGeneral.Controls.Add(this.cbDireccionesEnvio);
            this.xtraTabPageGeneral.Controls.Add(this.lblDireccionEnvio);
            this.xtraTabPageGeneral.Controls.Add(this.cbDireccionesFacturacion);
            this.xtraTabPageGeneral.Controls.Add(this.lblDireccionFacturacion);
            this.xtraTabPageGeneral.Controls.Add(this.txtBalance);
            this.xtraTabPageGeneral.Controls.Add(this.lblCuenta);
            this.xtraTabPageGeneral.Controls.Add(this.txtCuenta);
            this.xtraTabPageGeneral.Controls.Add(this.lblCURP);
            this.xtraTabPageGeneral.Controls.Add(this.txtCURP);
            this.xtraTabPageGeneral.Controls.Add(this.lblSitioWeb);
            this.xtraTabPageGeneral.Controls.Add(this.txtSitioWeb);
            this.xtraTabPageGeneral.Controls.Add(this.lblTelefono2);
            this.xtraTabPageGeneral.Controls.Add(this.txtTelefono2);
            this.xtraTabPageGeneral.Controls.Add(this.lblCorreo);
            this.xtraTabPageGeneral.Controls.Add(this.txtCorreo);
            this.xtraTabPageGeneral.Controls.Add(this.lblTelefonoCelular);
            this.xtraTabPageGeneral.Controls.Add(this.txtTelefonoCelular);
            this.xtraTabPageGeneral.Controls.Add(this.lblTelefono);
            this.xtraTabPageGeneral.Controls.Add(this.txtTelefono);
            this.xtraTabPageGeneral.Controls.Add(this.lblRFC);
            this.xtraTabPageGeneral.Controls.Add(this.txtRFC);
            this.xtraTabPageGeneral.Controls.Add(this.cbTipo);
            this.xtraTabPageGeneral.Controls.Add(this.lblTipo);
            this.xtraTabPageGeneral.Controls.Add(this.cbMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.lblMonedas);
            this.xtraTabPageGeneral.Controls.Add(this.cbGruposSocios);
            this.xtraTabPageGeneral.Controls.Add(this.lblGrupoSocios);
            this.xtraTabPageGeneral.Controls.Add(this.cbActivo);
            this.xtraTabPageGeneral.Controls.Add(this.btnImagen);
            this.xtraTabPageGeneral.Controls.Add(this.lblID);
            this.xtraTabPageGeneral.Controls.Add(this.lblFechaActualizacion);
            this.xtraTabPageGeneral.Controls.Add(this.lblUltimaActualizacion);
            this.xtraTabPageGeneral.Controls.Add(this.pbImagen);
            this.xtraTabPageGeneral.Controls.Add(this.lblNombreComercial);
            this.xtraTabPageGeneral.Controls.Add(this.txtNombreComercial);
            this.xtraTabPageGeneral.Controls.Add(this.lblNombre);
            this.xtraTabPageGeneral.Controls.Add(this.txtNombre);
            this.xtraTabPageGeneral.Controls.Add(this.lblCodigo);
            this.xtraTabPageGeneral.Controls.Add(this.txtCodigo);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // cbVIP
            // 
            this.cbVIP.Location = new System.Drawing.Point(334, 567);
            this.cbVIP.MenuManager = this.ribbonControl2;
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Properties.Caption = "VIP";
            this.cbVIP.Size = new System.Drawing.Size(115, 21);
            this.cbVIP.TabIndex = 97;
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl2.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl2.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.bbiNuevo,
            this.bbiDocumentosVencidos,
            this.bbiMonedero,
            this.bbiPDF,
            this.bbiImprimir,
            this.barButtonItem11});
            this.ribbonControl2.Location = new System.Drawing.Point(2, 2);
            this.ribbonControl2.MaxItemId = 8;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.OptionsMenuMinWidth = 294;
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(957, 60);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(55, 162);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl2;
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
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Eliminar";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.ImageUri.Uri = "Delete";
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Buscar";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "Find";
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Primero";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.ImageUri.Uri = "First";
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Anterior";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.ImageUri.Uri = "Prev";
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Último";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.ImageUri.Uri = "Last";
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Siguiente";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barButtonItem9.ImageOptions.ImageUri.Uri = "Next";
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            // 
            // bbiDocumentosVencidos
            // 
            this.bbiDocumentosVencidos.Caption = "Documentos vencidos";
            this.bbiDocumentosVencidos.Id = 1;
            this.bbiDocumentosVencidos.ImageOptions.ImageUri.Uri = "SwitchTimeScalesTo";
            this.bbiDocumentosVencidos.Name = "bbiDocumentosVencidos";
            // 
            // bbiMonedero
            // 
            this.bbiMonedero.Caption = "Monedero electrónico";
            this.bbiMonedero.Id = 2;
            this.bbiMonedero.ImageOptions.ImageUri.Uri = "Summary";
            this.bbiMonedero.Name = "bbiMonedero";
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 4;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.Name = "bbiPDF";
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 5;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Parametrizaciones de formulario";
            this.barButtonItem11.Id = 7;
            this.barButtonItem11.Name = "barButtonItem11";
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
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiNuevo);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiGuardarCerrar);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiGuardarNuevo);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPDF);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Opciones";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
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
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiDocumentosVencidos);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // cbRegimenFiscal
            // 
            this.cbRegimenFiscal.Location = new System.Drawing.Point(547, 390);
            this.cbRegimenFiscal.MenuManager = this.ribbonControl2;
            this.cbRegimenFiscal.Name = "cbRegimenFiscal";
            this.cbRegimenFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRegimenFiscal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("clave", "Clave", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRegimenFiscal.Size = new System.Drawing.Size(240, 24);
            this.cbRegimenFiscal.TabIndex = 96;
            this.cbRegimenFiscal.TabStop = false;
            // 
            // lblRegimenFiscal
            // 
            this.lblRegimenFiscal.Location = new System.Drawing.Point(462, 393);
            this.lblRegimenFiscal.Name = "lblRegimenFiscal";
            this.lblRegimenFiscal.Size = new System.Drawing.Size(87, 17);
            this.lblRegimenFiscal.TabIndex = 95;
            this.lblRegimenFiscal.Text = "Régimen fiscal";
            // 
            // cbPropietarios
            // 
            this.cbPropietarios.Location = new System.Drawing.Point(158, 426);
            this.cbPropietarios.MenuManager = this.ribbonControl2;
            this.cbPropietarios.Name = "cbPropietarios";
            this.cbPropietarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPropietarios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPropietarios.Size = new System.Drawing.Size(291, 24);
            this.cbPropietarios.TabIndex = 13;
            // 
            // lblPropietarios
            // 
            this.lblPropietarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPropietarios.Location = new System.Drawing.Point(22, 432);
            this.lblPropietarios.Name = "lblPropietarios";
            this.lblPropietarios.Size = new System.Drawing.Size(69, 17);
            this.lblPropietarios.TabIndex = 94;
            this.lblPropietarios.Text = "Propietario";
            // 
            // cbAPI
            // 
            this.cbAPI.Location = new System.Drawing.Point(158, 568);
            this.cbAPI.MenuManager = this.ribbonControl2;
            this.cbAPI.Name = "cbAPI";
            this.cbAPI.Properties.Caption = "API";
            this.cbAPI.Size = new System.Drawing.Size(115, 21);
            this.cbAPI.TabIndex = 92;
            // 
            // lblBalance
            // 
            this.lblBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalance.Location = new System.Drawing.Point(462, 159);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 17);
            this.lblBalance.TabIndex = 91;
            this.lblBalance.Text = "Balance";
            // 
            // cbMonedero
            // 
            this.cbMonedero.Location = new System.Drawing.Point(547, 494);
            this.cbMonedero.MenuManager = this.ribbonControl2;
            this.cbMonedero.Name = "cbMonedero";
            this.cbMonedero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedero.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("folio", "Folio", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedero.Size = new System.Drawing.Size(240, 24);
            this.cbMonedero.TabIndex = 89;
            this.cbMonedero.TabStop = false;
            // 
            // lblMonedero
            // 
            this.lblMonedero.Location = new System.Drawing.Point(462, 500);
            this.lblMonedero.Name = "lblMonedero";
            this.lblMonedero.Size = new System.Drawing.Size(63, 17);
            this.lblMonedero.TabIndex = 90;
            this.lblMonedero.Text = "Monedero";
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(547, 358);
            this.cbUsoPrincipal.MenuManager = this.ribbonControl2;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(240, 24);
            this.cbUsoPrincipal.TabIndex = 88;
            this.cbUsoPrincipal.TabStop = false;
            // 
            // cbSocios
            // 
            this.cbSocios.Location = new System.Drawing.Point(547, 460);
            this.cbSocios.MenuManager = this.ribbonControl2;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Size = new System.Drawing.Size(240, 24);
            this.cbSocios.TabIndex = 87;
            // 
            // cbEventual
            // 
            this.cbEventual.Location = new System.Drawing.Point(547, 426);
            this.cbEventual.MenuManager = this.ribbonControl2;
            this.cbEventual.Name = "cbEventual";
            this.cbEventual.Properties.Caption = "Eventual";
            this.cbEventual.Size = new System.Drawing.Size(88, 21);
            this.cbEventual.TabIndex = 18;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(462, 363);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(78, 17);
            this.lblUsoPrincipal.TabIndex = 86;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Location = new System.Drawing.Point(158, 392);
            this.cbVendedores.MenuManager = this.ribbonControl2;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(291, 24);
            this.cbVendedores.TabIndex = 12;
            // 
            // lblVendedores
            // 
            this.lblVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedores.Location = new System.Drawing.Point(22, 398);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(60, 17);
            this.lblVendedores.TabIndex = 84;
            this.lblVendedores.Text = "Vendedor";
            // 
            // cbOrdenCompra
            // 
            this.cbOrdenCompra.Location = new System.Drawing.Point(547, 325);
            this.cbOrdenCompra.MenuManager = this.ribbonControl2;
            this.cbOrdenCompra.Name = "cbOrdenCompra";
            this.cbOrdenCompra.Properties.Caption = "Solicitar orden de compra";
            this.cbOrdenCompra.Size = new System.Drawing.Size(240, 21);
            this.cbOrdenCompra.TabIndex = 16;
            // 
            // lblMultiplicador
            // 
            this.lblMultiplicador.Location = new System.Drawing.Point(462, 295);
            this.lblMultiplicador.Name = "lblMultiplicador";
            this.lblMultiplicador.Size = new System.Drawing.Size(80, 17);
            this.lblMultiplicador.TabIndex = 78;
            this.lblMultiplicador.Text = "Multiplicador";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(547, 290);
            this.txtMultiplicador.MenuManager = this.ribbonControl2;
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMultiplicador.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMultiplicador.Properties.MaskSettings.Set("mask", "n");
            this.txtMultiplicador.Properties.NullValuePrompt = "CURP";
            this.txtMultiplicador.Size = new System.Drawing.Size(183, 24);
            this.txtMultiplicador.TabIndex = 15;
            // 
            // cbPersonasContacto
            // 
            this.cbPersonasContacto.Location = new System.Drawing.Point(158, 188);
            this.cbPersonasContacto.MenuManager = this.ribbonControl2;
            this.cbPersonasContacto.Name = "cbPersonasContacto";
            this.cbPersonasContacto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPersonasContacto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPersonasContacto.Size = new System.Drawing.Size(291, 24);
            this.cbPersonasContacto.TabIndex = 0;
            this.cbPersonasContacto.TabStop = false;
            // 
            // lblPersonasContacto
            // 
            this.lblPersonasContacto.Location = new System.Drawing.Point(22, 193);
            this.lblPersonasContacto.Name = "lblPersonasContacto";
            this.lblPersonasContacto.Size = new System.Drawing.Size(126, 17);
            this.lblPersonasContacto.TabIndex = 76;
            this.lblPersonasContacto.Text = "Persona de contacto";
            // 
            // cbDireccionesEnvio
            // 
            this.cbDireccionesEnvio.Location = new System.Drawing.Point(158, 494);
            this.cbDireccionesEnvio.MenuManager = this.ribbonControl2;
            this.cbDireccionesEnvio.Name = "cbDireccionesEnvio";
            this.cbDireccionesEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesEnvio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesEnvio.Size = new System.Drawing.Size(291, 24);
            this.cbDireccionesEnvio.TabIndex = 0;
            this.cbDireccionesEnvio.TabStop = false;
            // 
            // lblDireccionEnvio
            // 
            this.lblDireccionEnvio.Location = new System.Drawing.Point(22, 499);
            this.lblDireccionEnvio.Name = "lblDireccionEnvio";
            this.lblDireccionEnvio.Size = new System.Drawing.Size(33, 17);
            this.lblDireccionEnvio.TabIndex = 74;
            this.lblDireccionEnvio.Text = "Envío";
            // 
            // cbDireccionesFacturacion
            // 
            this.cbDireccionesFacturacion.Location = new System.Drawing.Point(158, 460);
            this.cbDireccionesFacturacion.MenuManager = this.ribbonControl2;
            this.cbDireccionesFacturacion.Name = "cbDireccionesFacturacion";
            this.cbDireccionesFacturacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDireccionesFacturacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDireccionesFacturacion.Size = new System.Drawing.Size(291, 24);
            this.cbDireccionesFacturacion.TabIndex = 0;
            this.cbDireccionesFacturacion.TabStop = false;
            // 
            // lblDireccionFacturacion
            // 
            this.lblDireccionFacturacion.Location = new System.Drawing.Point(22, 465);
            this.lblDireccionFacturacion.Name = "lblDireccionFacturacion";
            this.lblDireccionFacturacion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccionFacturacion.TabIndex = 72;
            this.lblDireccionFacturacion.Text = "Facturación";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(547, 154);
            this.txtBalance.MenuManager = this.ribbonControl2;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBalance.Properties.NullValuePrompt = "CURP";
            this.txtBalance.Size = new System.Drawing.Size(183, 24);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Location = new System.Drawing.Point(462, 261);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(45, 17);
            this.lblCuenta.TabIndex = 68;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(547, 256);
            this.txtCuenta.MenuManager = this.ribbonControl2;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCuenta.Properties.MaxLength = 30;
            this.txtCuenta.Size = new System.Drawing.Size(183, 24);
            this.txtCuenta.TabIndex = 14;
            // 
            // lblCURP
            // 
            this.lblCURP.Location = new System.Drawing.Point(462, 227);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(37, 17);
            this.lblCURP.TabIndex = 66;
            this.lblCURP.Text = "CURP";
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(547, 222);
            this.txtCURP.MenuManager = this.ribbonControl2;
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCURP.Properties.MaxLength = 18;
            this.txtCURP.Properties.NullValuePrompt = "CURP";
            this.txtCURP.Size = new System.Drawing.Size(183, 24);
            this.txtCURP.TabIndex = 13;
            // 
            // lblSitioWeb
            // 
            this.lblSitioWeb.Location = new System.Drawing.Point(22, 363);
            this.lblSitioWeb.Name = "lblSitioWeb";
            this.lblSitioWeb.Size = new System.Drawing.Size(55, 17);
            this.lblSitioWeb.TabIndex = 64;
            this.lblSitioWeb.Text = "Sitio web";
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Location = new System.Drawing.Point(158, 358);
            this.txtSitioWeb.MenuManager = this.ribbonControl2;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSitioWeb.Properties.MaxLength = 100;
            this.txtSitioWeb.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtSitioWeb.Size = new System.Drawing.Size(291, 24);
            this.txtSitioWeb.TabIndex = 11;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.Location = new System.Drawing.Point(22, 261);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono2.TabIndex = 62;
            this.lblTelefono2.Text = "Teléfono 2";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(158, 256);
            this.txtTelefono2.MenuManager = this.ribbonControl2;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefono2.Properties.MaxLength = 20;
            this.txtTelefono2.Properties.NullValuePrompt = "Teléfono adicional";
            this.txtTelefono2.Size = new System.Drawing.Size(291, 24);
            this.txtTelefono2.TabIndex = 8;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(22, 329);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(42, 17);
            this.lblCorreo.TabIndex = 60;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(158, 324);
            this.txtCorreo.MenuManager = this.ribbonControl2;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Properties.MaxLength = 100;
            this.txtCorreo.Properties.NullValuePrompt = "Dirección de correo electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(291, 24);
            this.txtCorreo.TabIndex = 10;
            // 
            // lblTelefonoCelular
            // 
            this.lblTelefonoCelular.Location = new System.Drawing.Point(22, 295);
            this.lblTelefonoCelular.Name = "lblTelefonoCelular";
            this.lblTelefonoCelular.Size = new System.Drawing.Size(97, 17);
            this.lblTelefonoCelular.TabIndex = 58;
            this.lblTelefonoCelular.Text = "Teléfono celular";
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.Location = new System.Drawing.Point(158, 290);
            this.txtTelefonoCelular.MenuManager = this.ribbonControl2;
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefonoCelular.Properties.MaxLength = 50;
            this.txtTelefonoCelular.Properties.NullValuePrompt = "Teléfono celular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(291, 24);
            this.txtTelefonoCelular.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(22, 227);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(53, 17);
            this.lblTelefono.TabIndex = 56;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 222);
            this.txtTelefono.MenuManager = this.ribbonControl2;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefono.Properties.MaxLength = 20;
            this.txtTelefono.Properties.NullValuePrompt = "Teléfono principal";
            this.txtTelefono.Size = new System.Drawing.Size(291, 24);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblRFC
            // 
            this.lblRFC.Location = new System.Drawing.Point(22, 159);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(26, 17);
            this.lblRFC.TabIndex = 54;
            this.lblRFC.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(158, 154);
            this.txtRFC.MenuManager = this.ribbonControl2;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 30;
            this.txtRFC.Properties.NullValuePrompt = "RFC";
            this.txtRFC.Size = new System.Drawing.Size(291, 24);
            this.txtRFC.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(547, 17);
            this.cbTipo.MenuManager = this.ribbonControl2;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipo.Size = new System.Drawing.Size(183, 24);
            this.cbTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(462, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(27, 17);
            this.lblTipo.TabIndex = 51;
            this.lblTipo.Text = "Tipo";
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(547, 120);
            this.cbMonedas.MenuManager = this.ribbonControl2;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(183, 24);
            this.cbMonedas.TabIndex = 5;
            this.cbMonedas.TabStop = false;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(462, 125);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 48;
            this.lblMonedas.Text = "Moneda";
            // 
            // cbGruposSocios
            // 
            this.cbGruposSocios.Location = new System.Drawing.Point(158, 120);
            this.cbGruposSocios.MenuManager = this.ribbonControl2;
            this.cbGruposSocios.Name = "cbGruposSocios";
            this.cbGruposSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGruposSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbGruposSocios.Size = new System.Drawing.Size(291, 24);
            this.cbGruposSocios.TabIndex = 4;
            // 
            // lblGrupoSocios
            // 
            this.lblGrupoSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGrupoSocios.Location = new System.Drawing.Point(22, 125);
            this.lblGrupoSocios.Name = "lblGrupoSocios";
            this.lblGrupoSocios.Size = new System.Drawing.Size(95, 17);
            this.lblGrupoSocios.TabIndex = 45;
            this.lblGrupoSocios.Text = "Grupo de socios";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(22, 568);
            this.cbActivo.MenuManager = this.ribbonControl2;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(112, 21);
            this.cbActivo.TabIndex = 19;
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.Location = new System.Drawing.Point(774, 275);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(133, 35);
            this.btnImagen.TabIndex = 0;
            this.btnImagen.TabStop = false;
            this.btnImagen.Text = "Seleccionar imagen";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Location = new System.Drawing.Point(832, 551);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "0";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacion.Location = new System.Drawing.Point(832, 576);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 41;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(649, 576);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 40;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(774, 14);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(133, 255);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 39;
            this.pbImagen.TabStop = false;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.Location = new System.Drawing.Point(22, 91);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(115, 17);
            this.lblNombreComercial.TabIndex = 5;
            this.lblNombreComercial.Text = "Nombre comercial";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(158, 86);
            this.txtNombreComercial.MenuManager = this.ribbonControl2;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreComercial.Properties.MaxLength = 100;
            this.txtNombreComercial.Properties.NullValuePrompt = "Nombre comercial del socio";
            this.txtNombreComercial.Size = new System.Drawing.Size(572, 24);
            this.txtNombreComercial.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(22, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 52);
            this.txtNombre.MenuManager = this.ribbonControl2;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 254;
            this.txtNombre.Properties.NullValuePrompt = "Nombre del socio";
            this.txtNombre.Size = new System.Drawing.Size(572, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(22, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(158, 18);
            this.txtCodigo.MenuManager = this.ribbonControl2;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCodigo.Properties.MaxLength = 15;
            this.txtCodigo.Properties.NullValuePrompt = "Identificador del socio";
            this.txtCodigo.Size = new System.Drawing.Size(291, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // xtraTabPageCondicionesPago
            // 
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblDiasExtra);
            this.xtraTabPageCondicionesPago.Controls.Add(this.txtDiasExtra);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblCuentaPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.txtCuentaPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblPorcentajeDescuento);
            this.xtraTabPageCondicionesPago.Controls.Add(this.txtPorcentajeDescuento);
            this.xtraTabPageCondicionesPago.Controls.Add(this.cbMetodosPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblMetodosPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblPorcentajeInteresRetraso);
            this.xtraTabPageCondicionesPago.Controls.Add(this.txtPorcentajeInteresRetraso);
            this.xtraTabPageCondicionesPago.Controls.Add(this.cbListaPrecios);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblListaPrecios);
            this.xtraTabPageCondicionesPago.Controls.Add(this.cbCondicionesPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblCondicionesPago);
            this.xtraTabPageCondicionesPago.Controls.Add(this.lblLimiteCredito);
            this.xtraTabPageCondicionesPago.Controls.Add(this.txtLimiteCredito);
            this.xtraTabPageCondicionesPago.Name = "xtraTabPageCondicionesPago";
            this.xtraTabPageCondicionesPago.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPageCondicionesPago.Text = "Condiciones de pago";
            // 
            // lblDiasExtra
            // 
            this.lblDiasExtra.Location = new System.Drawing.Point(22, 258);
            this.lblDiasExtra.Name = "lblDiasExtra";
            this.lblDiasExtra.Size = new System.Drawing.Size(61, 17);
            this.lblDiasExtra.TabIndex = 82;
            this.lblDiasExtra.Text = "Dias extra";
            // 
            // txtDiasExtra
            // 
            this.txtDiasExtra.Location = new System.Drawing.Point(158, 254);
            this.txtDiasExtra.MenuManager = this.ribbonControl2;
            this.txtDiasExtra.Name = "txtDiasExtra";
            this.txtDiasExtra.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDiasExtra.Properties.MaxLength = 18;
            this.txtDiasExtra.Size = new System.Drawing.Size(94, 24);
            this.txtDiasExtra.TabIndex = 81;
            // 
            // lblCuentaPago
            // 
            this.lblCuentaPago.Location = new System.Drawing.Point(22, 227);
            this.lblCuentaPago.Name = "lblCuentaPago";
            this.lblCuentaPago.Size = new System.Drawing.Size(100, 17);
            this.lblCuentaPago.TabIndex = 80;
            this.lblCuentaPago.Text = "Cuenta de pago";
            // 
            // txtCuentaPago
            // 
            this.txtCuentaPago.Location = new System.Drawing.Point(158, 222);
            this.txtCuentaPago.MenuManager = this.ribbonControl2;
            this.txtCuentaPago.Name = "txtCuentaPago";
            this.txtCuentaPago.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCuentaPago.Properties.MaxLength = 18;
            this.txtCuentaPago.Size = new System.Drawing.Size(291, 24);
            this.txtCuentaPago.TabIndex = 6;
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(23, 125);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(78, 17);
            this.lblPorcentajeDescuento.TabIndex = 0;
            this.lblPorcentajeDescuento.Text = "% Descuento";
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(158, 120);
            this.txtPorcentajeDescuento.MenuManager = this.ribbonControl2;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Properties.DisplayFormat.FormatString = "P2";
            this.txtPorcentajeDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeDescuento.Properties.EditFormat.FormatString = "P2";
            this.txtPorcentajeDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeDescuento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentajeDescuento.Properties.MaskSettings.Set("mask", "P2");
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(291, 24);
            this.txtPorcentajeDescuento.TabIndex = 3;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(158, 188);
            this.cbMetodosPago.MenuManager = this.ribbonControl2;
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Size = new System.Drawing.Size(291, 24);
            this.cbMetodosPago.TabIndex = 5;
            // 
            // lblMetodosPago
            // 
            this.lblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodosPago.Location = new System.Drawing.Point(22, 193);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(103, 17);
            this.lblMetodosPago.TabIndex = 78;
            this.lblMetodosPago.Text = "Método de pago";
            // 
            // lblPorcentajeInteresRetraso
            // 
            this.lblPorcentajeInteresRetraso.Location = new System.Drawing.Point(23, 57);
            this.lblPorcentajeInteresRetraso.Name = "lblPorcentajeInteresRetraso";
            this.lblPorcentajeInteresRetraso.Size = new System.Drawing.Size(100, 17);
            this.lblPorcentajeInteresRetraso.TabIndex = 54;
            this.lblPorcentajeInteresRetraso.Text = "% Interes retraso";
            // 
            // txtPorcentajeInteresRetraso
            // 
            this.txtPorcentajeInteresRetraso.Location = new System.Drawing.Point(158, 52);
            this.txtPorcentajeInteresRetraso.MenuManager = this.ribbonControl2;
            this.txtPorcentajeInteresRetraso.Name = "txtPorcentajeInteresRetraso";
            this.txtPorcentajeInteresRetraso.Properties.DisplayFormat.FormatString = "P2";
            this.txtPorcentajeInteresRetraso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeInteresRetraso.Properties.EditFormat.FormatString = "P2";
            this.txtPorcentajeInteresRetraso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeInteresRetraso.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentajeInteresRetraso.Properties.MaskSettings.Set("mask", "P2");
            this.txtPorcentajeInteresRetraso.Size = new System.Drawing.Size(291, 24);
            this.txtPorcentajeInteresRetraso.TabIndex = 1;
            // 
            // cbListaPrecios
            // 
            this.cbListaPrecios.Location = new System.Drawing.Point(158, 86);
            this.cbListaPrecios.MenuManager = this.ribbonControl2;
            this.cbListaPrecios.Name = "cbListaPrecios";
            this.cbListaPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListaPrecios.Size = new System.Drawing.Size(291, 24);
            this.cbListaPrecios.TabIndex = 2;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaPrecios.Location = new System.Drawing.Point(23, 87);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(92, 17);
            this.lblListaPrecios.TabIndex = 52;
            this.lblListaPrecios.Text = "Lista de precios";
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(158, 18);
            this.cbCondicionesPago.MenuManager = this.ribbonControl2;
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Size = new System.Drawing.Size(291, 24);
            this.cbCondicionesPago.TabIndex = 0;
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCondicionesPago.Location = new System.Drawing.Point(22, 23);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(127, 17);
            this.lblCondicionesPago.TabIndex = 50;
            this.lblCondicionesPago.Text = "Condiciones de pago";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.Location = new System.Drawing.Point(23, 159);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(104, 17);
            this.lblLimiteCredito.TabIndex = 49;
            this.lblLimiteCredito.Text = "Límite de crédito";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(158, 154);
            this.txtLimiteCredito.MenuManager = this.ribbonControl2;
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Properties.DisplayFormat.FormatString = "c2";
            this.txtLimiteCredito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimiteCredito.Properties.EditFormat.FormatString = "c2";
            this.txtLimiteCredito.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimiteCredito.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtLimiteCredito.Properties.MaskSettings.Set("mask", "c2");
            this.txtLimiteCredito.Size = new System.Drawing.Size(291, 24);
            this.txtLimiteCredito.TabIndex = 4;
            // 
            // xtraTabPagePersonasContacto
            // 
            this.xtraTabPagePersonasContacto.Controls.Add(this.gcPersonasContacto);
            this.xtraTabPagePersonasContacto.Name = "xtraTabPagePersonasContacto";
            this.xtraTabPagePersonasContacto.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPagePersonasContacto.Text = "Personas de contacto";
            // 
            // gcPersonasContacto
            // 
            this.gcPersonasContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPersonasContacto.Location = new System.Drawing.Point(0, 0);
            this.gcPersonasContacto.MainView = this.gvPersonasContacto;
            this.gcPersonasContacto.Name = "gcPersonasContacto";
            this.gcPersonasContacto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbGenero});
            this.gcPersonasContacto.Size = new System.Drawing.Size(927, 593);
            this.gcPersonasContacto.TabIndex = 7;
            this.gcPersonasContacto.UseEmbeddedNavigator = true;
            this.gcPersonasContacto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonasContacto});
            // 
            // gvPersonasContacto
            // 
            this.gvPersonasContacto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPersonasContacto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn18,
            this.gridColumn17,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn28,
            this.gridColumn27});
            this.gvPersonasContacto.DetailHeight = 458;
            this.gvPersonasContacto.FixedLineWidth = 3;
            this.gvPersonasContacto.GridControl = this.gcPersonasContacto;
            this.gvPersonasContacto.Name = "gvPersonasContacto";
            this.gvPersonasContacto.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPersonasContacto.OptionsEditForm.PopupEditFormWidth = 711;
            this.gvPersonasContacto.OptionsNavigation.AutoFocusNewRow = true;
            this.gvPersonasContacto.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.MinWidth = 26;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 99;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Genero";
            this.gridColumn15.ColumnEdit = this.cbGenero;
            this.gridColumn15.FieldName = "genero";
            this.gridColumn15.MaxWidth = 106;
            this.gridColumn15.MinWidth = 26;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            this.gridColumn15.Width = 106;
            // 
            // cbGenero
            // 
            this.cbGenero.AutoHeight = false;
            this.cbGenero.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGenero.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("genero", "Genero", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbGenero.Name = "cbGenero";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Socio ID";
            this.gridColumn16.FieldName = "socio_id";
            this.gridColumn16.MinWidth = 26;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Width = 99;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Título";
            this.gridColumn18.FieldName = "titulo";
            this.gridColumn18.MaxWidth = 54;
            this.gridColumn18.MinWidth = 26;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 54;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Nombre";
            this.gridColumn17.FieldName = "nombre_persona";
            this.gridColumn17.MaxWidth = 200;
            this.gridColumn17.MinWidth = 26;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 2;
            this.gridColumn17.Width = 134;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Posición";
            this.gridColumn19.FieldName = "posicion";
            this.gridColumn19.MaxWidth = 80;
            this.gridColumn19.MinWidth = 26;
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 72;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Dirección";
            this.gridColumn20.FieldName = "direccion";
            this.gridColumn20.MinWidth = 26;
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 4;
            this.gridColumn20.Width = 129;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Teléfono";
            this.gridColumn21.FieldName = "telefono";
            this.gridColumn21.MaxWidth = 66;
            this.gridColumn21.MinWidth = 26;
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 5;
            this.gridColumn21.Width = 59;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Celular";
            this.gridColumn22.FieldName = "celular";
            this.gridColumn22.MaxWidth = 66;
            this.gridColumn22.MinWidth = 26;
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 6;
            this.gridColumn22.Width = 59;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Correo";
            this.gridColumn24.FieldName = "correo";
            this.gridColumn24.MaxWidth = 134;
            this.gridColumn24.MinWidth = 26;
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 7;
            this.gridColumn24.Width = 120;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Observaciones";
            this.gridColumn25.FieldName = "observaciones";
            this.gridColumn25.MaxWidth = 266;
            this.gridColumn25.MinWidth = 26;
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 8;
            this.gridColumn25.Width = 174;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Huella digital";
            this.gridColumn28.FieldName = "huella_digital";
            this.gridColumn28.MaxWidth = 106;
            this.gridColumn28.MinWidth = 26;
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 9;
            this.gridColumn28.Width = 97;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Activo";
            this.gridColumn27.FieldName = "activo";
            this.gridColumn27.MaxWidth = 59;
            this.gridColumn27.MinWidth = 26;
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 10;
            this.gridColumn27.Width = 57;
            // 
            // xtraTabPageDirecciones
            // 
            this.xtraTabPageDirecciones.Controls.Add(this.lblDistancia);
            this.xtraTabPageDirecciones.Controls.Add(this.txtDistancia);
            this.xtraTabPageDirecciones.Controls.Add(this.lblDireccionID);
            this.xtraTabPageDirecciones.Controls.Add(this.btnGuardarDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.cbImpuestos);
            this.xtraTabPageDirecciones.Controls.Add(this.lblImpuesto);
            this.xtraTabPageDirecciones.Controls.Add(this.lblTipoDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.cbTipoDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.btnNuevaDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.cbDirecciones);
            this.xtraTabPageDirecciones.Controls.Add(this.lblDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.lblCP);
            this.xtraTabPageDirecciones.Controls.Add(this.txtCP);
            this.xtraTabPageDirecciones.Controls.Add(this.lblCiudad);
            this.xtraTabPageDirecciones.Controls.Add(this.txtCiudad);
            this.xtraTabPageDirecciones.Controls.Add(this.lblEstado);
            this.xtraTabPageDirecciones.Controls.Add(this.cbEstados);
            this.xtraTabPageDirecciones.Controls.Add(this.lblPais);
            this.xtraTabPageDirecciones.Controls.Add(this.cbPaises);
            this.xtraTabPageDirecciones.Controls.Add(this.lblMunicipio);
            this.xtraTabPageDirecciones.Controls.Add(this.txtMunicipio);
            this.xtraTabPageDirecciones.Controls.Add(this.lblColonia);
            this.xtraTabPageDirecciones.Controls.Add(this.txtColonia);
            this.xtraTabPageDirecciones.Controls.Add(this.lblNumeroInterior);
            this.xtraTabPageDirecciones.Controls.Add(this.txtNumeroInterior);
            this.xtraTabPageDirecciones.Controls.Add(this.lblNumeroExterior);
            this.xtraTabPageDirecciones.Controls.Add(this.txtNumeroExterior);
            this.xtraTabPageDirecciones.Controls.Add(this.lblCalle);
            this.xtraTabPageDirecciones.Controls.Add(this.txtCalle);
            this.xtraTabPageDirecciones.Controls.Add(this.lblNombreDireccion);
            this.xtraTabPageDirecciones.Controls.Add(this.txtNombreDireccion);
            this.xtraTabPageDirecciones.Name = "xtraTabPageDirecciones";
            this.xtraTabPageDirecciones.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPageDirecciones.Text = "Direcciones";
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(23, 360);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(55, 17);
            this.lblDistancia.TabIndex = 132;
            this.lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(158, 356);
            this.txtDistancia.MenuManager = this.ribbonControl2;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDistancia.Properties.MaxLength = 100;
            this.txtDistancia.Size = new System.Drawing.Size(146, 24);
            this.txtDistancia.TabIndex = 131;
            // 
            // lblDireccionID
            // 
            this.lblDireccionID.Location = new System.Drawing.Point(457, 57);
            this.lblDireccionID.Name = "lblDireccionID";
            this.lblDireccionID.Size = new System.Drawing.Size(9, 17);
            this.lblDireccionID.TabIndex = 130;
            this.lblDireccionID.Text = "0";
            // 
            // btnGuardarDireccion
            // 
            this.btnGuardarDireccion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuardarDireccion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardarDireccion.Location = new System.Drawing.Point(546, 18);
            this.btnGuardarDireccion.Name = "btnGuardarDireccion";
            this.btnGuardarDireccion.Size = new System.Drawing.Size(106, 26);
            this.btnGuardarDireccion.TabIndex = 129;
            this.btnGuardarDireccion.TabStop = false;
            this.btnGuardarDireccion.Text = "Guardar";
            // 
            // cbImpuestos
            // 
            this.cbImpuestos.Location = new System.Drawing.Point(158, 86);
            this.cbImpuestos.MenuManager = this.ribbonControl2;
            this.cbImpuestos.Name = "cbImpuestos";
            this.cbImpuestos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpuestos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbImpuestos.Size = new System.Drawing.Size(291, 24);
            this.cbImpuestos.TabIndex = 2;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImpuesto.Location = new System.Drawing.Point(22, 91);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(56, 17);
            this.lblImpuesto.TabIndex = 128;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblTipoDireccion
            // 
            this.lblTipoDireccion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoDireccion.Appearance.Options.UseFont = true;
            this.lblTipoDireccion.Location = new System.Drawing.Point(22, 57);
            this.lblTipoDireccion.Name = "lblTipoDireccion";
            this.lblTipoDireccion.Size = new System.Drawing.Size(24, 13);
            this.lblTipoDireccion.TabIndex = 126;
            this.lblTipoDireccion.Text = "Tipo";
            // 
            // cbTipoDireccion
            // 
            this.cbTipoDireccion.Location = new System.Drawing.Point(158, 52);
            this.cbTipoDireccion.MenuManager = this.ribbonControl2;
            this.cbTipoDireccion.Name = "cbTipoDireccion";
            this.cbTipoDireccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDireccion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipoDireccion.Size = new System.Drawing.Size(291, 24);
            this.cbTipoDireccion.TabIndex = 1;
            // 
            // btnNuevaDireccion
            // 
            this.btnNuevaDireccion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNuevaDireccion.Location = new System.Drawing.Point(457, 18);
            this.btnNuevaDireccion.Name = "btnNuevaDireccion";
            this.btnNuevaDireccion.Size = new System.Drawing.Size(70, 26);
            this.btnNuevaDireccion.TabIndex = 122;
            this.btnNuevaDireccion.TabStop = false;
            this.btnNuevaDireccion.Text = "Nueva";
            // 
            // cbDirecciones
            // 
            this.cbDirecciones.Location = new System.Drawing.Point(158, 18);
            this.cbDirecciones.MenuManager = this.ribbonControl2;
            this.cbDirecciones.Name = "cbDirecciones";
            this.cbDirecciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDirecciones.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDirecciones.Size = new System.Drawing.Size(291, 24);
            this.cbDirecciones.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(22, 23);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(56, 17);
            this.lblDireccion.TabIndex = 124;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCP
            // 
            this.lblCP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCP.Appearance.Options.UseFont = true;
            this.lblCP.Location = new System.Drawing.Point(22, 227);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(20, 13);
            this.lblCP.TabIndex = 121;
            this.lblCP.Text = "C.P.";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(158, 222);
            this.txtCP.MenuManager = this.ribbonControl2;
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCP.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtCP.Properties.MaskSettings.Set("mask", "00000");
            this.txtCP.Properties.MaxLength = 5;
            this.txtCP.Size = new System.Drawing.Size(146, 24);
            this.txtCP.TabIndex = 7;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCiudad.Appearance.Options.UseFont = true;
            this.lblCiudad.Location = new System.Drawing.Point(22, 261);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(38, 13);
            this.lblCiudad.TabIndex = 120;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(158, 256);
            this.txtCiudad.MenuManager = this.ribbonControl2;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCiudad.Properties.MaxLength = 100;
            this.txtCiudad.Size = new System.Drawing.Size(446, 24);
            this.txtCiudad.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Appearance.Options.UseFont = true;
            this.lblEstado.Location = new System.Drawing.Point(322, 329);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(38, 13);
            this.lblEstado.TabIndex = 119;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstados
            // 
            this.cbEstados.Location = new System.Drawing.Point(457, 324);
            this.cbEstados.MenuManager = this.ribbonControl2;
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbEstados.Size = new System.Drawing.Size(146, 24);
            this.cbEstados.TabIndex = 12;
            // 
            // lblPais
            // 
            this.lblPais.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPais.Appearance.Options.UseFont = true;
            this.lblPais.Location = new System.Drawing.Point(22, 329);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 13);
            this.lblPais.TabIndex = 118;
            this.lblPais.Text = "País";
            // 
            // cbPaises
            // 
            this.cbPaises.Location = new System.Drawing.Point(158, 324);
            this.cbPaises.MenuManager = this.ribbonControl2;
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaises.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPaises.Size = new System.Drawing.Size(146, 24);
            this.cbPaises.TabIndex = 11;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Location = new System.Drawing.Point(22, 295);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(59, 17);
            this.lblMunicipio.TabIndex = 117;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(158, 290);
            this.txtMunicipio.MenuManager = this.ribbonControl2;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMunicipio.Properties.MaxLength = 100;
            this.txtMunicipio.Size = new System.Drawing.Size(446, 24);
            this.txtMunicipio.TabIndex = 10;
            // 
            // lblColonia
            // 
            this.lblColonia.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblColonia.Appearance.Options.UseFont = true;
            this.lblColonia.Location = new System.Drawing.Point(322, 227);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(41, 13);
            this.lblColonia.TabIndex = 116;
            this.lblColonia.Text = "Colonia";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(457, 222);
            this.txtColonia.MenuManager = this.ribbonControl2;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtColonia.Properties.MaxLength = 100;
            this.txtColonia.Size = new System.Drawing.Size(146, 24);
            this.txtColonia.TabIndex = 8;
            // 
            // lblNumeroInterior
            // 
            this.lblNumeroInterior.Location = new System.Drawing.Point(322, 193);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(70, 17);
            this.lblNumeroInterior.TabIndex = 115;
            this.lblNumeroInterior.Text = "No. Interior";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(457, 188);
            this.txtNumeroInterior.MenuManager = this.ribbonControl2;
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroInterior.Properties.MaxLength = 100;
            this.txtNumeroInterior.Size = new System.Drawing.Size(146, 24);
            this.txtNumeroInterior.TabIndex = 6;
            // 
            // lblNumeroExterior
            // 
            this.lblNumeroExterior.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroExterior.Appearance.Options.UseFont = true;
            this.lblNumeroExterior.Location = new System.Drawing.Point(22, 193);
            this.lblNumeroExterior.Name = "lblNumeroExterior";
            this.lblNumeroExterior.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroExterior.TabIndex = 114;
            this.lblNumeroExterior.Text = "No. Exterior";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Location = new System.Drawing.Point(158, 188);
            this.txtNumeroExterior.MenuManager = this.ribbonControl2;
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroExterior.Properties.MaxLength = 100;
            this.txtNumeroExterior.Size = new System.Drawing.Size(146, 24);
            this.txtNumeroExterior.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCalle.Appearance.Options.UseFont = true;
            this.lblCalle.Location = new System.Drawing.Point(22, 159);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(27, 13);
            this.lblCalle.TabIndex = 113;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(158, 154);
            this.txtCalle.MenuManager = this.ribbonControl2;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCalle.Properties.MaxLength = 100;
            this.txtCalle.Size = new System.Drawing.Size(446, 24);
            this.txtCalle.TabIndex = 4;
            // 
            // lblNombreDireccion
            // 
            this.lblNombreDireccion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreDireccion.Appearance.Options.UseFont = true;
            this.lblNombreDireccion.Location = new System.Drawing.Point(22, 125);
            this.lblNombreDireccion.Name = "lblNombreDireccion";
            this.lblNombreDireccion.Size = new System.Drawing.Size(44, 13);
            this.lblNombreDireccion.TabIndex = 112;
            this.lblNombreDireccion.Text = "Nombre";
            // 
            // txtNombreDireccion
            // 
            this.txtNombreDireccion.Location = new System.Drawing.Point(158, 120);
            this.txtNombreDireccion.MenuManager = this.ribbonControl2;
            this.txtNombreDireccion.Name = "txtNombreDireccion";
            this.txtNombreDireccion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreDireccion.Properties.MaxLength = 100;
            this.txtNombreDireccion.Properties.NullValuePrompt = "Nombre de la dirección Ej. Trabajo";
            this.txtNombreDireccion.Size = new System.Drawing.Size(446, 24);
            this.txtNombreDireccion.TabIndex = 3;
            // 
            // xtraTabPageLogistica
            // 
            this.xtraTabPageLogistica.Controls.Add(this.lblRuta);
            this.xtraTabPageLogistica.Controls.Add(this.cbRutas);
            this.xtraTabPageLogistica.Controls.Add(this.txtOrdenRuta);
            this.xtraTabPageLogistica.Controls.Add(this.lblLatitud);
            this.xtraTabPageLogistica.Controls.Add(this.cbFrecuencia);
            this.xtraTabPageLogistica.Controls.Add(this.lblLongitud);
            this.xtraTabPageLogistica.Controls.Add(this.lblFrecuencia);
            this.xtraTabPageLogistica.Controls.Add(this.txtLatitud);
            this.xtraTabPageLogistica.Controls.Add(this.txtLongitud);
            this.xtraTabPageLogistica.Name = "xtraTabPageLogistica";
            this.xtraTabPageLogistica.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPageLogistica.Text = "Logística";
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(22, 125);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 17);
            this.lblRuta.TabIndex = 148;
            this.lblRuta.Text = "Ruta";
            // 
            // cbRutas
            // 
            this.cbRutas.Location = new System.Drawing.Point(98, 120);
            this.cbRutas.MenuManager = this.ribbonControl2;
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRutas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRutas.Size = new System.Drawing.Size(174, 24);
            this.cbRutas.TabIndex = 147;
            // 
            // txtOrdenRuta
            // 
            this.txtOrdenRuta.Location = new System.Drawing.Point(281, 120);
            this.txtOrdenRuta.MenuManager = this.ribbonControl2;
            this.txtOrdenRuta.Name = "txtOrdenRuta";
            this.txtOrdenRuta.Size = new System.Drawing.Size(77, 24);
            this.txtOrdenRuta.TabIndex = 101;
            // 
            // lblLatitud
            // 
            this.lblLatitud.Location = new System.Drawing.Point(22, 23);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(45, 17);
            this.lblLatitud.TabIndex = 94;
            this.lblLatitud.Text = "Latitud";
            // 
            // cbFrecuencia
            // 
            this.cbFrecuencia.Location = new System.Drawing.Point(98, 86);
            this.cbFrecuencia.MenuManager = this.ribbonControl2;
            this.cbFrecuencia.Name = "cbFrecuencia";
            this.cbFrecuencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFrecuencia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("frecuencia", "Frecuencia", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbFrecuencia.Size = new System.Drawing.Size(258, 24);
            this.cbFrecuencia.TabIndex = 94;
            // 
            // lblLongitud
            // 
            this.lblLongitud.Location = new System.Drawing.Point(22, 57);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(56, 17);
            this.lblLongitud.TabIndex = 95;
            this.lblLongitud.Text = "Longitud";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.Location = new System.Drawing.Point(22, 91);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(66, 17);
            this.lblFrecuencia.TabIndex = 98;
            this.lblFrecuencia.Text = "Frecuencia";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(98, 18);
            this.txtLatitud.MenuManager = this.ribbonControl2;
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(258, 24);
            this.txtLatitud.TabIndex = 96;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(98, 52);
            this.txtLongitud.MenuManager = this.ribbonControl2;
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(258, 24);
            this.txtLongitud.TabIndex = 97;
            // 
            // xtraTabPagePropiedades
            // 
            this.xtraTabPagePropiedades.Controls.Add(this.cbPropiedades);
            this.xtraTabPagePropiedades.Name = "xtraTabPagePropiedades";
            this.xtraTabPagePropiedades.Size = new System.Drawing.Size(927, 593);
            this.xtraTabPagePropiedades.Text = "Propiedades";
            // 
            // cbPropiedades
            // 
            this.cbPropiedades.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPropiedades.Location = new System.Drawing.Point(0, 0);
            this.cbPropiedades.Name = "cbPropiedades";
            this.cbPropiedades.Size = new System.Drawing.Size(927, 593);
            this.cbPropiedades.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(957, 647);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(937, 627);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmFormSocios
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
            this.Name = "frmFormSocios";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropietarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrdenCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplicador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPersonasContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDireccionesFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCURP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.xtraTabPageCondicionesPago.ResumeLayout(false);
            this.xtraTabPageCondicionesPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteresRetraso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCredito.Properties)).EndInit();
            this.xtraTabPagePersonasContacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonasContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonasContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenero)).EndInit();
            this.xtraTabPageDirecciones.ResumeLayout(false);
            this.xtraTabPageDirecciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDirecciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDireccion.Properties)).EndInit();
            this.xtraTabPageLogistica.ResumeLayout(false);
            this.xtraTabPageLogistica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRutas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFrecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLatitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongitud.Properties)).EndInit();
            this.xtraTabPagePropiedades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).EndInit();
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
        private PanelControl panelControl1;
        private RibbonPage ribbonPageHerramientas;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemDescuentos;
        private BarButtonItem bbiPaquetes;
        private RibbonPage mainRibbonPage;
        private RibbonPageGroup mainRibbonPageGroup;
     
        private RibbonPageGroup searchRibbonPageGroup;
        private BarButtonItem bbiBuscar;
        private BarButtonItem bbiPrimero;
        private BarButtonItem bbiAnterior;
        private BarButtonItem bbiSiguiente;
        private BarButtonItem bbiUltimo;
        private BarButtonItem bbiEliminar;
        private BarButtonItem bbiPartidasAbiertas;
        private RibbonControl mainRibbonControl;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneral;
        private CheckEdit cbVIP;
        private RibbonControl ribbonControl2;
        private BackstageViewControl backstageViewControl1;
        private BarButtonItem bbiGuardar;
        private BarButtonItem bbiGuardarCerrar;
        private BarButtonItem bbiGuardarNuevo;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarButtonItem bbiNuevo;
        private BarButtonItem bbiDocumentosVencidos;
        private BarButtonItem bbiMonedero;
        private BarSubItem bbiPDF;
        private BarSubItem bbiImprimir;
        private BarButtonItem barButtonItem11;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup2;
        private RibbonPageGroup ribbonPageGroup3;
        private RibbonPage ribbonPage2;
        private RibbonPageGroup ribbonPageGroupHerramientas;
        private LookUpEdit cbRegimenFiscal;
        private LabelControl lblRegimenFiscal;
        private LookUpEdit cbPropietarios;
        private HyperlinkLabelControl lblPropietarios;
        private CheckEdit cbAPI;
        private HyperlinkLabelControl lblBalance;
        private LookUpEdit cbMonedero;
        private LabelControl lblMonedero;
        private LookUpEdit cbUsoPrincipal;
        private LookUpEdit cbSocios;
        private CheckEdit cbEventual;
        private LabelControl lblUsoPrincipal;
        private LookUpEdit cbVendedores;
        private HyperlinkLabelControl lblVendedores;
        private CheckEdit cbOrdenCompra;
        private LabelControl lblMultiplicador;
        private TextEdit txtMultiplicador;
        private LookUpEdit cbPersonasContacto;
        private LabelControl lblPersonasContacto;
        private LookUpEdit cbDireccionesEnvio;
        private LabelControl lblDireccionEnvio;
        private LookUpEdit cbDireccionesFacturacion;
        private LabelControl lblDireccionFacturacion;
        private TextEdit txtBalance;
        private LabelControl lblCuenta;
        private TextEdit txtCuenta;
        private LabelControl lblCURP;
        private TextEdit txtCURP;
        private LabelControl lblSitioWeb;
        private TextEdit txtSitioWeb;
        private LabelControl lblTelefono2;
        private TextEdit txtTelefono2;
        private LabelControl lblCorreo;
        private TextEdit txtCorreo;
        private LabelControl lblTelefonoCelular;
        private TextEdit txtTelefonoCelular;
        private LabelControl lblTelefono;
        private TextEdit txtTelefono;
        private LabelControl lblRFC;
        private TextEdit txtRFC;
        private LookUpEdit cbTipo;
        private LabelControl lblTipo;
        private LookUpEdit cbMonedas;
        private HyperlinkLabelControl lblMonedas;
        private LookUpEdit cbGruposSocios;
        private HyperlinkLabelControl lblGrupoSocios;
        private CheckEdit cbActivo;
        private SimpleButton btnImagen;
        private LabelControl lblID;
        private LabelControl lblFechaActualizacion;
        private LabelControl lblUltimaActualizacion;
        private PictureBox pbImagen;
        private LabelControl lblNombreComercial;
        private TextEdit txtNombreComercial;
        private LabelControl lblNombre;
        private TextEdit txtNombre;
        private LabelControl lblCodigo;
        private TextEdit txtCodigo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCondicionesPago;
        private LabelControl lblDiasExtra;
        private TextEdit txtDiasExtra;
        private LabelControl lblCuentaPago;
        private TextEdit txtCuentaPago;
        private LabelControl lblPorcentajeDescuento;
        private TextEdit txtPorcentajeDescuento;
        private LookUpEdit cbMetodosPago;
        private HyperlinkLabelControl lblMetodosPago;
        private LabelControl lblPorcentajeInteresRetraso;
        private TextEdit txtPorcentajeInteresRetraso;
        private LookUpEdit cbListaPrecios;
        private HyperlinkLabelControl lblListaPrecios;
        private LookUpEdit cbCondicionesPago;
        private HyperlinkLabelControl lblCondicionesPago;
        private LabelControl lblLimiteCredito;
        private TextEdit txtLimiteCredito;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePersonasContacto;
        private DevExpress.XtraGrid.GridControl gcPersonasContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonasContacto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private RepositoryItemLookUpEdit cbGenero;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDirecciones;
        private LabelControl lblDistancia;
        private TextEdit txtDistancia;
        private LabelControl lblDireccionID;
        private SimpleButton btnGuardarDireccion;
        private LookUpEdit cbImpuestos;
        private HyperlinkLabelControl lblImpuesto;
        private LabelControl lblTipoDireccion;
        private LookUpEdit cbTipoDireccion;
        private SimpleButton btnNuevaDireccion;
        private LookUpEdit cbDirecciones;
        private LabelControl lblDireccion;
        private LabelControl lblCP;
        private TextEdit txtCP;
        private LabelControl lblCiudad;
        private TextEdit txtCiudad;
        private LabelControl lblEstado;
        private LookUpEdit cbEstados;
        private LabelControl lblPais;
        private LookUpEdit cbPaises;
        private LabelControl lblMunicipio;
        private TextEdit txtMunicipio;
        private LabelControl lblColonia;
        private TextEdit txtColonia;
        private LabelControl lblNumeroInterior;
        private TextEdit txtNumeroInterior;
        private LabelControl lblNumeroExterior;
        private TextEdit txtNumeroExterior;
        private LabelControl lblCalle;
        private TextEdit txtCalle;
        private LabelControl lblNombreDireccion;
        private TextEdit txtNombreDireccion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLogistica;
        private HyperlinkLabelControl lblRuta;
        private LookUpEdit cbRutas;
        private TextEdit txtOrdenRuta;
        private LabelControl lblLatitud;
        private LookUpEdit cbFrecuencia;
        private LabelControl lblLongitud;
        private LabelControl lblFrecuencia;
        private TextEdit txtLatitud;
        private TextEdit txtLongitud;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePropiedades;
        private CheckedListBoxControl cbPropiedades;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
    }
}