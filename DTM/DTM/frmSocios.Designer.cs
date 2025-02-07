﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
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
using DevExpress.XtraTab;
using SDK;
using Padding = System.Windows.Forms.Padding;


namespace DTM
{
    partial class frmSocios
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
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
            this.bbiDocumentosVencidos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMonedero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiParametrizacionesFormulario = new DevExpress.XtraBars.BarButtonItem();
            this.Actualizar = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.txtDiasExtra = new DevExpress.XtraEditors.TextEdit();
            this.lblDiasExtra = new DevExpress.XtraEditors.LabelControl();
            this.cbVIP = new DevExpress.XtraEditors.CheckEdit();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblRuta = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbRutas = new DevExpress.XtraEditors.LookUpEdit();
            this.txtOrdenRuta = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPagePropiedades = new DevExpress.XtraTab.XtraTabPage();
            this.cbPropiedades = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).BeginInit();
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
            this.xtraTabPagePropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 27, 26, 27);
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
            this.bbiDocumentosVencidos,
            this.bbiMonedero,
            this.bbiPDF,
            this.bbiImprimir,
            this.bbiParametrizacionesFormulario,
            this.barButtonItem1,
            this.Actualizar});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 294;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1158, 90);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(55, 162);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.mainRibbonControl;
            this.backstageViewControl1.Size = new System.Drawing.Size(640, 196);
            this.backstageViewControl1.TabIndex = 2;
            this.backstageViewControl1.VisibleInDesignTime = true;
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
            // bbiDocumentosVencidos
            // 
            this.bbiDocumentosVencidos.Caption = "Documentos vencidos";
            this.bbiDocumentosVencidos.Id = 1;
            this.bbiDocumentosVencidos.ImageOptions.ImageUri.Uri = "SwitchTimeScalesTo";
            this.bbiDocumentosVencidos.Name = "bbiDocumentosVencidos";
            this.bbiDocumentosVencidos.VisibleInSearchMenu = false;
            this.bbiDocumentosVencidos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDocumentosVencidos_ItemClick);
            // 
            // bbiMonedero
            // 
            this.bbiMonedero.Caption = "Monedero electrónico";
            this.bbiMonedero.Id = 2;
            this.bbiMonedero.ImageOptions.ImageUri.Uri = "Summary";
            this.bbiMonedero.Name = "bbiMonedero";
            this.bbiMonedero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMonedero_ItemClick);
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 4;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bbiPDF.Name = "bbiPDF";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Estado de Cuenta";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 5;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // bbiParametrizacionesFormulario
            // 
            this.bbiParametrizacionesFormulario.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizacionesFormulario.Id = 7;
            this.bbiParametrizacionesFormulario.Name = "bbiParametrizacionesFormulario";
            this.bbiParametrizacionesFormulario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiParametrizacionesFormulario_ItemClick);
            // 
            // Actualizar
            // 
            this.Actualizar.Caption = "Actualizar";
            this.Actualizar.Id = 9;
            this.Actualizar.ImageOptions.Image = global::componentResourceManager.Resources.convert_16x16;
            this.Actualizar.ImageOptions.LargeImage = global::componentResourceManager.Resources.convert_32x32;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Actualizar_ItemClick);
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
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiParametrizacionesFormulario);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.Actualizar);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(1134, 701);
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
            this.xtraTabPageGeneral.Controls.Add(this.txtDiasExtra);
            this.xtraTabPageGeneral.Controls.Add(this.lblDiasExtra);
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
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(1128, 671);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // txtDiasExtra
            // 
            this.txtDiasExtra.EditValue = "0";
            this.txtDiasExtra.Location = new System.Drawing.Point(555, 531);
            this.txtDiasExtra.MenuManager = this.mainRibbonControl;
            this.txtDiasExtra.Name = "txtDiasExtra";
            this.txtDiasExtra.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDiasExtra.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDiasExtra.Properties.MaskSettings.Set("mask", "d");
            this.txtDiasExtra.Properties.NullValuePrompt = "CURP";
            this.txtDiasExtra.Size = new System.Drawing.Size(234, 24);
            this.txtDiasExtra.TabIndex = 99;
            // 
            // lblDiasExtra
            // 
            this.lblDiasExtra.Location = new System.Drawing.Point(412, 534);
            this.lblDiasExtra.Name = "lblDiasExtra";
            this.lblDiasExtra.Size = new System.Drawing.Size(137, 17);
            this.lblDiasExtra.TabIndex = 98;
            this.lblDiasExtra.Text = "Dias Extra de Vigencia";
            // 
            // cbVIP
            // 
            this.cbVIP.Location = new System.Drawing.Point(334, 567);
            this.cbVIP.MenuManager = this.mainRibbonControl;
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Properties.Caption = "VIP";
            this.cbVIP.Size = new System.Drawing.Size(115, 21);
            this.cbVIP.TabIndex = 97;
            this.cbVIP.CheckedChanged += new System.EventHandler(this.cbVIP_CheckedChanged);
            // 
            // cbRegimenFiscal
            // 
            this.cbRegimenFiscal.Location = new System.Drawing.Point(555, 390);
            this.cbRegimenFiscal.MenuManager = this.mainRibbonControl;
            this.cbRegimenFiscal.Name = "cbRegimenFiscal";
            this.cbRegimenFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRegimenFiscal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("clave", "Clave", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRegimenFiscal.Size = new System.Drawing.Size(232, 24);
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
            this.cbPropietarios.MenuManager = this.mainRibbonControl;
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
            this.lblPropietarios.Click += new System.EventHandler(this.lblPropietarios_Click);
            // 
            // cbAPI
            // 
            this.cbAPI.Location = new System.Drawing.Point(158, 568);
            this.cbAPI.MenuManager = this.mainRibbonControl;
            this.cbAPI.Name = "cbAPI";
            this.cbAPI.Properties.Caption = "API";
            this.cbAPI.Size = new System.Drawing.Size(115, 21);
            this.cbAPI.TabIndex = 92;
            this.cbAPI.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalance.Location = new System.Drawing.Point(462, 159);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 17);
            this.lblBalance.TabIndex = 91;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // cbMonedero
            // 
            this.cbMonedero.Location = new System.Drawing.Point(555, 494);
            this.cbMonedero.MenuManager = this.mainRibbonControl;
            this.cbMonedero.Name = "cbMonedero";
            this.cbMonedero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedero.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("folio", "Folio", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedero.Size = new System.Drawing.Size(232, 24);
            this.cbMonedero.TabIndex = 89;
            this.cbMonedero.TabStop = false;
            this.cbMonedero.Visible = false;
            // 
            // lblMonedero
            // 
            this.lblMonedero.Location = new System.Drawing.Point(486, 497);
            this.lblMonedero.Name = "lblMonedero";
            this.lblMonedero.Size = new System.Drawing.Size(63, 17);
            this.lblMonedero.TabIndex = 90;
            this.lblMonedero.Text = "Monedero";
            this.lblMonedero.Visible = false;
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(555, 358);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(232, 24);
            this.cbUsoPrincipal.TabIndex = 88;
            this.cbUsoPrincipal.TabStop = false;
            // 
            // cbSocios
            // 
            this.cbSocios.Location = new System.Drawing.Point(555, 460);
            this.cbSocios.MenuManager = this.mainRibbonControl;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Size = new System.Drawing.Size(232, 24);
            this.cbSocios.TabIndex = 87;
            this.cbSocios.Visible = false;
            // 
            // cbEventual
            // 
            this.cbEventual.Location = new System.Drawing.Point(555, 428);
            this.cbEventual.MenuManager = this.mainRibbonControl;
            this.cbEventual.Name = "cbEventual";
            this.cbEventual.Properties.Caption = "Eventual";
            this.cbEventual.Size = new System.Drawing.Size(88, 21);
            this.cbEventual.TabIndex = 18;
            this.cbEventual.Visible = false;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(471, 365);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(78, 17);
            this.lblUsoPrincipal.TabIndex = 86;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Location = new System.Drawing.Point(158, 392);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
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
            this.lblVendedores.Click += new System.EventHandler(this.lblVendedores_Click);
            // 
            // cbOrdenCompra
            // 
            this.cbOrdenCompra.Location = new System.Drawing.Point(555, 327);
            this.cbOrdenCompra.MenuManager = this.mainRibbonControl;
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
            this.lblMultiplicador.Visible = false;
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(555, 290);
            this.txtMultiplicador.MenuManager = this.mainRibbonControl;
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMultiplicador.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMultiplicador.Properties.MaskSettings.Set("mask", "n");
            this.txtMultiplicador.Properties.NullValuePrompt = "CURP";
            this.txtMultiplicador.Size = new System.Drawing.Size(232, 24);
            this.txtMultiplicador.TabIndex = 15;
            this.txtMultiplicador.Visible = false;
            // 
            // cbPersonasContacto
            // 
            this.cbPersonasContacto.Location = new System.Drawing.Point(158, 188);
            this.cbPersonasContacto.MenuManager = this.mainRibbonControl;
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
            this.cbDireccionesEnvio.MenuManager = this.mainRibbonControl;
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
            this.cbDireccionesFacturacion.MenuManager = this.mainRibbonControl;
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
            this.txtBalance.MenuManager = this.mainRibbonControl;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBalance.Properties.NullValuePrompt = "CURP";
            this.txtBalance.Size = new System.Drawing.Size(240, 24);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Location = new System.Drawing.Point(497, 261);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(45, 17);
            this.lblCuenta.TabIndex = 68;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(555, 256);
            this.txtCuenta.MenuManager = this.mainRibbonControl;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCuenta.Properties.MaxLength = 30;
            this.txtCuenta.Size = new System.Drawing.Size(232, 24);
            this.txtCuenta.TabIndex = 14;
            // 
            // lblCURP
            // 
            this.lblCURP.Location = new System.Drawing.Point(505, 225);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(37, 17);
            this.lblCURP.TabIndex = 66;
            this.lblCURP.Text = "CURP";
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(555, 222);
            this.txtCURP.MenuManager = this.mainRibbonControl;
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCURP.Properties.MaxLength = 18;
            this.txtCURP.Properties.NullValuePrompt = "CURP";
            this.txtCURP.Size = new System.Drawing.Size(232, 24);
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
            this.txtSitioWeb.MenuManager = this.mainRibbonControl;
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
            this.txtTelefono2.MenuManager = this.mainRibbonControl;
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
            this.txtCorreo.MenuManager = this.mainRibbonControl;
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
            this.txtTelefonoCelular.MenuManager = this.mainRibbonControl;
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
            this.txtTelefono.MenuManager = this.mainRibbonControl;
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
            this.txtRFC.MenuManager = this.mainRibbonControl;
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
            this.cbTipo.MenuManager = this.mainRibbonControl;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipo.Size = new System.Drawing.Size(240, 24);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.EditValueChanged += new System.EventHandler(this.cbTipo_EditValueChanged);
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
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(240, 24);
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
            this.lblMonedas.Click += new System.EventHandler(this.lblMonedas_Click);
            // 
            // cbGruposSocios
            // 
            this.cbGruposSocios.Location = new System.Drawing.Point(158, 120);
            this.cbGruposSocios.MenuManager = this.mainRibbonControl;
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
            this.lblGrupoSocios.Click += new System.EventHandler(this.lblGrupoSocios_Click);
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(22, 568);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(112, 21);
            this.cbActivo.TabIndex = 19;
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.Location = new System.Drawing.Point(850, 275);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(258, 35);
            this.btnImagen.TabIndex = 0;
            this.btnImagen.TabStop = false;
            this.btnImagen.Text = "Seleccionar imagen";
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Location = new System.Drawing.Point(1033, 551);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "0";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacion.Location = new System.Drawing.Point(1033, 576);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 41;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(850, 576);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 40;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(850, 14);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(258, 255);
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
            this.txtNombreComercial.MenuManager = this.mainRibbonControl;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreComercial.Properties.MaxLength = 100;
            this.txtNombreComercial.Properties.NullValuePrompt = "Nombre comercial del socio";
            this.txtNombreComercial.Size = new System.Drawing.Size(631, 24);
            this.txtNombreComercial.TabIndex = 3;
            this.txtNombreComercial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSKU_KeyDown);
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
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 254;
            this.txtNombre.Properties.NullValuePrompt = "Nombre del socio";
            this.txtNombre.Size = new System.Drawing.Size(631, 24);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSKU_KeyDown);
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
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCodigo.Properties.MaxLength = 15;
            this.txtCodigo.Properties.NullValuePrompt = "Identificador del socio";
            this.txtCodigo.Size = new System.Drawing.Size(291, 24);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSKU_KeyDown);
            // 
            // xtraTabPageCondicionesPago
            // 
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
            this.xtraTabPageCondicionesPago.Size = new System.Drawing.Size(1128, 671);
            this.xtraTabPageCondicionesPago.Text = "Condiciones de pago";
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(158, 188);
            this.cbMetodosPago.MenuManager = this.mainRibbonControl;
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
            this.lblMetodosPago.Click += new System.EventHandler(this.lblMetodosPago_Click);
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
            this.txtPorcentajeInteresRetraso.MenuManager = this.mainRibbonControl;
            this.txtPorcentajeInteresRetraso.Name = "txtPorcentajeInteresRetraso";
            this.txtPorcentajeInteresRetraso.Properties.DisplayFormat.FormatString = "P2";
            this.txtPorcentajeInteresRetraso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeInteresRetraso.Properties.EditFormat.FormatString = "P2";
            this.txtPorcentajeInteresRetraso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeInteresRetraso.Properties.Mask.EditMask = "P2";
            this.txtPorcentajeInteresRetraso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentajeInteresRetraso.Size = new System.Drawing.Size(291, 24);
            this.txtPorcentajeInteresRetraso.TabIndex = 1;
            // 
            // cbListaPrecios
            // 
            this.cbListaPrecios.Location = new System.Drawing.Point(158, 86);
            this.cbListaPrecios.MenuManager = this.mainRibbonControl;
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
            this.lblListaPrecios.Click += new System.EventHandler(this.lblListaPrecios_Click);
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(158, 18);
            this.cbCondicionesPago.MenuManager = this.mainRibbonControl;
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
            this.lblCondicionesPago.Click += new System.EventHandler(this.lblCondicionesPago_Click);
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
            this.txtLimiteCredito.MenuManager = this.mainRibbonControl;
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Properties.DisplayFormat.FormatString = "c2";
            this.txtLimiteCredito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimiteCredito.Properties.EditFormat.FormatString = "c2";
            this.txtLimiteCredito.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimiteCredito.Properties.Mask.EditMask = "c2";
            this.txtLimiteCredito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiteCredito.Size = new System.Drawing.Size(291, 24);
            this.txtLimiteCredito.TabIndex = 4;
            // 
            // xtraTabPagePersonasContacto
            // 
            this.xtraTabPagePersonasContacto.Controls.Add(this.gcPersonasContacto);
            this.xtraTabPagePersonasContacto.Name = "xtraTabPagePersonasContacto";
            this.xtraTabPagePersonasContacto.Size = new System.Drawing.Size(1128, 671);
            this.xtraTabPagePersonasContacto.Text = "Personas de contacto";
            // 
            // gcPersonasContacto
            // 
            this.gcPersonasContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPersonasContacto.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl1_EmbeddedNavigator_ButtonClick);
            gridLevelNode2.RelationName = "Level1";
            this.gcPersonasContacto.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcPersonasContacto.Location = new System.Drawing.Point(0, 0);
            this.gcPersonasContacto.MainView = this.gvPersonasContacto;
            this.gcPersonasContacto.Name = "gcPersonasContacto";
            this.gcPersonasContacto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbGenero});
            this.gcPersonasContacto.Size = new System.Drawing.Size(1128, 671);
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
            this.gvPersonasContacto.OptionsView.ShowGroupPanel = false;
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
            this.xtraTabPageDirecciones.Size = new System.Drawing.Size(1128, 671);
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
            this.txtDistancia.MenuManager = this.mainRibbonControl;
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
            this.btnGuardarDireccion.Click += new System.EventHandler(this.btnGuardarDireccion_Click);
            // 
            // cbImpuestos
            // 
            this.cbImpuestos.Location = new System.Drawing.Point(158, 86);
            this.cbImpuestos.MenuManager = this.mainRibbonControl;
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
            this.cbTipoDireccion.MenuManager = this.mainRibbonControl;
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
            this.btnNuevaDireccion.Click += new System.EventHandler(this.btnNuevaDireccion_Click);
            // 
            // cbDirecciones
            // 
            this.cbDirecciones.Location = new System.Drawing.Point(158, 18);
            this.cbDirecciones.MenuManager = this.mainRibbonControl;
            this.cbDirecciones.Name = "cbDirecciones";
            this.cbDirecciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDirecciones.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 18, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDirecciones.Size = new System.Drawing.Size(291, 24);
            this.cbDirecciones.TabIndex = 0;
            this.cbDirecciones.EditValueChanged += new System.EventHandler(this.cbDirecciones_EditValueChanged);
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
            this.txtCP.MenuManager = this.mainRibbonControl;
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCP.Properties.Mask.EditMask = "00000";
            this.txtCP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
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
            this.txtCiudad.MenuManager = this.mainRibbonControl;
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
            this.cbEstados.MenuManager = this.mainRibbonControl;
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
            this.cbPaises.MenuManager = this.mainRibbonControl;
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaises.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 18, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPaises.Size = new System.Drawing.Size(146, 24);
            this.cbPaises.TabIndex = 11;
            this.cbPaises.EditValueChanged += new System.EventHandler(this.cbPaises_EditValueChanged);
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
            this.txtMunicipio.MenuManager = this.mainRibbonControl;
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
            this.txtColonia.MenuManager = this.mainRibbonControl;
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
            this.txtNumeroInterior.MenuManager = this.mainRibbonControl;
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
            this.txtNumeroExterior.MenuManager = this.mainRibbonControl;
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
            this.txtCalle.MenuManager = this.mainRibbonControl;
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
            this.txtNombreDireccion.MenuManager = this.mainRibbonControl;
            this.txtNombreDireccion.Name = "txtNombreDireccion";
            this.txtNombreDireccion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreDireccion.Properties.MaxLength = 100;
            this.txtNombreDireccion.Properties.NullValuePrompt = "Nombre de la dirección Ej. Trabajo";
            this.txtNombreDireccion.Size = new System.Drawing.Size(446, 24);
            this.txtNombreDireccion.TabIndex = 3;
            // 
            // xtraTabPageLogistica
            // 
            this.xtraTabPageLogistica.Controls.Add(this.labelControl1);
            this.xtraTabPageLogistica.Controls.Add(this.lblRuta);
            this.xtraTabPageLogistica.Controls.Add(this.cbRutas);
            this.xtraTabPageLogistica.Controls.Add(this.txtOrdenRuta);
            this.xtraTabPageLogistica.Name = "xtraTabPageLogistica";
            this.xtraTabPageLogistica.Size = new System.Drawing.Size(1128, 671);
            this.xtraTabPageLogistica.Text = "Logística";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(339, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 17);
            this.labelControl1.TabIndex = 149;
            this.labelControl1.Text = "Distancia en KM";
            // 
            // lblRuta
            // 
            this.lblRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuta.Location = new System.Drawing.Point(52, 27);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 17);
            this.lblRuta.TabIndex = 148;
            this.lblRuta.Text = "Ruta";
            this.lblRuta.Click += new System.EventHandler(this.lblRuta_Click);
            // 
            // cbRutas
            // 
            this.cbRutas.Location = new System.Drawing.Point(108, 20);
            this.cbRutas.MenuManager = this.mainRibbonControl;
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
            this.txtOrdenRuta.Location = new System.Drawing.Point(456, 20);
            this.txtOrdenRuta.MenuManager = this.mainRibbonControl;
            this.txtOrdenRuta.Name = "txtOrdenRuta";
            this.txtOrdenRuta.Size = new System.Drawing.Size(77, 24);
            this.txtOrdenRuta.TabIndex = 101;
            // 
            // xtraTabPagePropiedades
            // 
            this.xtraTabPagePropiedades.Controls.Add(this.cbPropiedades);
            this.xtraTabPagePropiedades.Name = "xtraTabPagePropiedades";
            this.xtraTabPagePropiedades.Size = new System.Drawing.Size(1128, 671);
            this.xtraTabPagePropiedades.Text = "Propiedades";
            // 
            // cbPropiedades
            // 
            this.cbPropiedades.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPropiedades.Location = new System.Drawing.Point(0, 0);
            this.cbPropiedades.Name = "cbPropiedades";
            this.cbPropiedades.Size = new System.Drawing.Size(1128, 671);
            this.cbPropiedades.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1158, 725);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1138, 705);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.xtraTabControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 90);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1158, 725);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // frmSocios
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1158, 815);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Name = "frmSocios";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).EndInit();
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
            this.xtraTabPagePropiedades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextEdit txtDiasExtra;
        private LabelControl lblDiasExtra;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private LabelControl labelControl1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem Actualizar;
    }
}