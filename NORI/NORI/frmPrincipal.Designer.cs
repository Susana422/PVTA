using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using NoriSDK;

namespace NORI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelMenuPrincipal = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementUsuario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCerrarSesion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementBloquear = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDefiniciones = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCierreDia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEmpresa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementConfiguracion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementUsuarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDepartamentos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementVendedores = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementZonas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSeries = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFinanzas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementImpuestos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMonedas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTipoCambio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestionSociosNegocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGruposSocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCondicionesPago = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTiposMetodosPagos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMetodosPago = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPaises = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEstados = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestionInventario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGruposArticulos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAlmacenes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFabricantes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementVentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCotizaciones = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPedidos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEntregaMercancia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFacturas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNotasCredito = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNotasDebito = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPagos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInventario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementArticulos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInformes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accoCorteCaja = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accFacturasDiarias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accPagosCredito = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accNC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accMonitor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItemEstacion = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEventosControles = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseñadorInformes = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConsultasPersonalizadas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSincronizacion = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEntradasAbiertas = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemAutorizaciones = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.bbiEtiquetas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransmitirRecibir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseñadorEscritorios = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSucursales = new DevExpress.XtraBars.BarListItem();
            this.bbiParametrizacion = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.bwAutorizaciones = new System.ComponentModel.BackgroundWorker();
            this.timerAutorizaciones = new System.Windows.Forms.Timer(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelMenuPrincipal.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMenuPrincipal});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            this.dockManager1.ClosingPanel += new DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(this.dockManager1_ClosingPanel);
            // 
            // dockPanelMenuPrincipal
            // 
            this.dockPanelMenuPrincipal.Controls.Add(this.dockPanel1_Container);
            this.dockPanelMenuPrincipal.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenuPrincipal.FloatSize = new System.Drawing.Size(218, 200);
            this.dockPanelMenuPrincipal.ID = new System.Guid("40a367a0-a383-4b5c-ab0b-4a5cc56ae345");
            this.dockPanelMenuPrincipal.Location = new System.Drawing.Point(0, 90);
            this.dockPanelMenuPrincipal.Name = "dockPanelMenuPrincipal";
            this.dockPanelMenuPrincipal.Options.ShowCloseButton = false;
            this.dockPanelMenuPrincipal.OriginalSize = new System.Drawing.Size(324, 200);
            this.dockPanelMenuPrincipal.Size = new System.Drawing.Size(324, 686);
            this.dockPanelMenuPrincipal.Text = "Menú principal";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.accordionControl1);
            this.dockPanel1_Container.Controls.Add(this.lblEmpresa);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 27);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(315, 655);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementUsuario,
            this.accordionControlElementGestion,
            this.accordionControlElementVentas,
            this.accordionControlElementSocios,
            this.accordionControlElementPagos,
            this.accordionControlElementInventario,
            this.accordionControlElementInformes,
            this.accordionControlElement5});
            this.accordionControl1.Location = new System.Drawing.Point(3, 29);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(273, 629);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionControlElementUsuario
            // 
            this.accordionControlElementUsuario.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCerrarSesion,
            this.accordionControlElementBloquear});
            this.accordionControlElementUsuario.Expanded = true;
            this.accordionControlElementUsuario.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElementUsuario.Name = "accordionControlElementUsuario";
            this.accordionControlElementUsuario.Text = "Usuario";
            // 
            // accordionControlElementCerrarSesion
            // 
            this.accordionControlElementCerrarSesion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCerrarSesion.ImageOptions.Image")));
            this.accordionControlElementCerrarSesion.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementCerrarSesion.Name = "accordionControlElementCerrarSesion";
            this.accordionControlElementCerrarSesion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCerrarSesion.Text = "Cerrar sesión";
            this.accordionControlElementCerrarSesion.Click += new System.EventHandler(this.accordionControlElementCerrarSesion_Click);
            // 
            // accordionControlElementBloquear
            // 
            this.accordionControlElementBloquear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementBloquear.ImageOptions.Image")));
            this.accordionControlElementBloquear.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementBloquear.Name = "accordionControlElementBloquear";
            this.accordionControlElementBloquear.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementBloquear.Text = "Bloquear";
            this.accordionControlElementBloquear.Click += new System.EventHandler(this.accordionControlElementBloquear_Click);
            // 
            // accordionControlElementGestion
            // 
            this.accordionControlElementGestion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementDefiniciones});
            this.accordionControlElementGestion.Expanded = true;
            this.accordionControlElementGestion.Name = "accordionControlElementGestion";
            this.accordionControlElementGestion.Text = "Gestión";
            // 
            // accordionControlElementDefiniciones
            // 
            this.accordionControlElementDefiniciones.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCierreDia,
            this.accordionControlElementGeneral,
            this.accordionControlElementFinanzas,
            this.accordionControlElementGestionSociosNegocios,
            this.accordionControlElementGestionInventario});
            this.accordionControlElementDefiniciones.Expanded = true;
            this.accordionControlElementDefiniciones.Name = "accordionControlElementDefiniciones";
            this.accordionControlElementDefiniciones.Text = "Definiciones";
            // 
            // accordionControlElementCierreDia
            // 
            this.accordionControlElementCierreDia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCierreDia.ImageOptions.Image")));
            this.accordionControlElementCierreDia.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementCierreDia.Name = "accordionControlElementCierreDia";
            this.accordionControlElementCierreDia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCierreDia.Text = "Cierre del día";
            this.accordionControlElementCierreDia.Click += new System.EventHandler(this.accordionControlElementCierreDia_Click);
            // 
            // accordionControlElementGeneral
            // 
            this.accordionControlElementGeneral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementEmpresa,
            this.accordionControlElementConfiguracion,
            this.accordionControlElementUsuarios,
            this.accordionControlElementDepartamentos,
            this.accordionControlElementVendedores,
            this.accordionControlElementZonas,
            this.accordionControlElementSeries});
            this.accordionControlElementGeneral.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElementGeneral.Name = "accordionControlElementGeneral";
            this.accordionControlElementGeneral.Text = "General";
            // 
            // accordionControlElementEmpresa
            // 
            this.accordionControlElementEmpresa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementEmpresa.ImageOptions.Image")));
            this.accordionControlElementEmpresa.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementEmpresa.Name = "accordionControlElementEmpresa";
            this.accordionControlElementEmpresa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEmpresa.Text = "Empresa";
            this.accordionControlElementEmpresa.Click += new System.EventHandler(this.accordionControlElementEmpresa_Click);
            // 
            // accordionControlElementConfiguracion
            // 
            this.accordionControlElementConfiguracion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementConfiguracion.ImageOptions.Image")));
            this.accordionControlElementConfiguracion.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementConfiguracion.Name = "accordionControlElementConfiguracion";
            this.accordionControlElementConfiguracion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementConfiguracion.Text = "Configuración";
            this.accordionControlElementConfiguracion.Click += new System.EventHandler(this.accordionControlElementConfiguracion_Click);
            // 
            // accordionControlElementUsuarios
            // 
            this.accordionControlElementUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementUsuarios.ImageOptions.Image")));
            this.accordionControlElementUsuarios.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElementUsuarios.Name = "accordionControlElementUsuarios";
            this.accordionControlElementUsuarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementUsuarios.Text = "Usuarios";
            this.accordionControlElementUsuarios.Click += new System.EventHandler(this.accordionControlElementUsuarios_Click);
            // 
            // accordionControlElementDepartamentos
            // 
            this.accordionControlElementDepartamentos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementDepartamentos.ImageOptions.Image")));
            this.accordionControlElementDepartamentos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementDepartamentos.Name = "accordionControlElementDepartamentos";
            this.accordionControlElementDepartamentos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDepartamentos.Text = "Departamentos";
            this.accordionControlElementDepartamentos.Click += new System.EventHandler(this.accordionControlElementDepartamentos_Click);
            // 
            // accordionControlElementVendedores
            // 
            this.accordionControlElementVendedores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementVendedores.ImageOptions.Image")));
            this.accordionControlElementVendedores.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementVendedores.Name = "accordionControlElementVendedores";
            this.accordionControlElementVendedores.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementVendedores.Text = "Vendedores";
            this.accordionControlElementVendedores.Click += new System.EventHandler(this.accordionControlElementVendedores_Click);
            // 
            // accordionControlElementZonas
            // 
            this.accordionControlElementZonas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementZonas.ImageOptions.Image")));
            this.accordionControlElementZonas.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementZonas.Name = "accordionControlElementZonas";
            this.accordionControlElementZonas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementZonas.Text = "Zonas";
            this.accordionControlElementZonas.Click += new System.EventHandler(this.accordionControlElementZonas_Click);
            // 
            // accordionControlElementSeries
            // 
            this.accordionControlElementSeries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementSeries.ImageOptions.Image")));
            this.accordionControlElementSeries.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementSeries.Name = "accordionControlElementSeries";
            this.accordionControlElementSeries.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSeries.Text = "Series de documentos";
            this.accordionControlElementSeries.Click += new System.EventHandler(this.accordionControlElementSeries_Click);
            // 
            // accordionControlElementFinanzas
            // 
            this.accordionControlElementFinanzas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementImpuestos,
            this.accordionControlElementMonedas,
            this.accordionControlElementTipoCambio});
            this.accordionControlElementFinanzas.Name = "accordionControlElementFinanzas";
            this.accordionControlElementFinanzas.Text = "Finanzas";
            // 
            // accordionControlElementImpuestos
            // 
            this.accordionControlElementImpuestos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementImpuestos.ImageOptions.Image")));
            this.accordionControlElementImpuestos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementImpuestos.Name = "accordionControlElementImpuestos";
            this.accordionControlElementImpuestos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementImpuestos.Text = "Impuestos";
            this.accordionControlElementImpuestos.Click += new System.EventHandler(this.accordionControlElementImpuestos_Click);
            // 
            // accordionControlElementMonedas
            // 
            this.accordionControlElementMonedas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementMonedas.ImageOptions.Image")));
            this.accordionControlElementMonedas.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementMonedas.Name = "accordionControlElementMonedas";
            this.accordionControlElementMonedas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMonedas.Text = "Monedas";
            this.accordionControlElementMonedas.Click += new System.EventHandler(this.accordionControlElementMonedas_Click);
            // 
            // accordionControlElementTipoCambio
            // 
            this.accordionControlElementTipoCambio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementTipoCambio.ImageOptions.Image")));
            this.accordionControlElementTipoCambio.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementTipoCambio.Name = "accordionControlElementTipoCambio";
            this.accordionControlElementTipoCambio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTipoCambio.Text = "Tipo de cambio";
            this.accordionControlElementTipoCambio.Click += new System.EventHandler(this.accordionControlElementTipoCambio_Click);
            // 
            // accordionControlElementGestionSociosNegocios
            // 
            this.accordionControlElementGestionSociosNegocios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementGruposSocios,
            this.accordionControlElementCondicionesPago,
            this.accordionControlElementTiposMetodosPagos,
            this.accordionControlElementMetodosPago,
            this.accordionControlElementPaises,
            this.accordionControlElementEstados});
            this.accordionControlElementGestionSociosNegocios.Name = "accordionControlElementGestionSociosNegocios";
            this.accordionControlElementGestionSociosNegocios.Text = "Socios de negocios";
            // 
            // accordionControlElementGruposSocios
            // 
            this.accordionControlElementGruposSocios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementGruposSocios.ImageOptions.Image")));
            this.accordionControlElementGruposSocios.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementGruposSocios.Name = "accordionControlElementGruposSocios";
            this.accordionControlElementGruposSocios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGruposSocios.Text = "Grupos de socios";
            this.accordionControlElementGruposSocios.Click += new System.EventHandler(this.accordionControlElementGruposSocios_Click);
            // 
            // accordionControlElementCondicionesPago
            // 
            this.accordionControlElementCondicionesPago.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCondicionesPago.ImageOptions.Image")));
            this.accordionControlElementCondicionesPago.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementCondicionesPago.Name = "accordionControlElementCondicionesPago";
            this.accordionControlElementCondicionesPago.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCondicionesPago.Text = "Condiciones de pago";
            this.accordionControlElementCondicionesPago.Click += new System.EventHandler(this.accordionControlElementCondicionesPago_Click);
            // 
            // accordionControlElementTiposMetodosPagos
            // 
            this.accordionControlElementTiposMetodosPagos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementTiposMetodosPagos.ImageOptions.Image")));
            this.accordionControlElementTiposMetodosPagos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementTiposMetodosPagos.Name = "accordionControlElementTiposMetodosPagos";
            this.accordionControlElementTiposMetodosPagos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTiposMetodosPagos.Text = "Tipos de métodos de pago";
            this.accordionControlElementTiposMetodosPagos.Click += new System.EventHandler(this.accordionControlElementTiposMetodosPagos_Click);
            // 
            // accordionControlElementMetodosPago
            // 
            this.accordionControlElementMetodosPago.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementMetodosPago.ImageOptions.Image")));
            this.accordionControlElementMetodosPago.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementMetodosPago.Name = "accordionControlElementMetodosPago";
            this.accordionControlElementMetodosPago.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMetodosPago.Text = "Métodos de pago";
            this.accordionControlElementMetodosPago.Click += new System.EventHandler(this.accordionControlElementMetodosPago_Click);
            // 
            // accordionControlElementPaises
            // 
            this.accordionControlElementPaises.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPaises.ImageOptions.Image")));
            this.accordionControlElementPaises.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementPaises.Name = "accordionControlElementPaises";
            this.accordionControlElementPaises.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPaises.Text = "Paises";
            this.accordionControlElementPaises.Click += new System.EventHandler(this.accordionControlElementPaises_Click);
            // 
            // accordionControlElementEstados
            // 
            this.accordionControlElementEstados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementEstados.ImageOptions.Image")));
            this.accordionControlElementEstados.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementEstados.Name = "accordionControlElementEstados";
            this.accordionControlElementEstados.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEstados.Text = "Estados";
            this.accordionControlElementEstados.Click += new System.EventHandler(this.accordionControlElementEstados_Click);
            // 
            // accordionControlElementGestionInventario
            // 
            this.accordionControlElementGestionInventario.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementGruposArticulos,
            this.accordionControlElementAlmacenes,
            this.accordionControlElementFabricantes});
            this.accordionControlElementGestionInventario.Name = "accordionControlElementGestionInventario";
            this.accordionControlElementGestionInventario.Text = "Inventario";
            // 
            // accordionControlElementGruposArticulos
            // 
            this.accordionControlElementGruposArticulos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementGruposArticulos.ImageOptions.Image")));
            this.accordionControlElementGruposArticulos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementGruposArticulos.Name = "accordionControlElementGruposArticulos";
            this.accordionControlElementGruposArticulos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGruposArticulos.Text = "Grupos de artículos";
            this.accordionControlElementGruposArticulos.Click += new System.EventHandler(this.accordionControlElementGruposArticulos_Click);
            // 
            // accordionControlElementAlmacenes
            // 
            this.accordionControlElementAlmacenes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementAlmacenes.ImageOptions.Image")));
            this.accordionControlElementAlmacenes.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementAlmacenes.Name = "accordionControlElementAlmacenes";
            this.accordionControlElementAlmacenes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAlmacenes.Text = "Almacenes";
            this.accordionControlElementAlmacenes.Click += new System.EventHandler(this.accordionControlElementAlmacenes_Click);
            // 
            // accordionControlElementFabricantes
            // 
            this.accordionControlElementFabricantes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementFabricantes.ImageOptions.Image")));
            this.accordionControlElementFabricantes.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementFabricantes.Name = "accordionControlElementFabricantes";
            this.accordionControlElementFabricantes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementFabricantes.Text = "Fabricantes";
            this.accordionControlElementFabricantes.Click += new System.EventHandler(this.accordionControlElementFabricantes_Click);
            // 
            // accordionControlElementVentas
            // 
            this.accordionControlElementVentas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCotizaciones,
            this.accordionControlElementPedidos,
            this.accordionControlElementEntregaMercancia,
            this.accordionControlElementFacturas,
            this.accordionControlElementNotasCredito,
            this.accordionControlElementNotasDebito});
            this.accordionControlElementVentas.Expanded = true;
            this.accordionControlElementVentas.Name = "accordionControlElementVentas";
            this.accordionControlElementVentas.Text = "Ventas";
            // 
            // accordionControlElementCotizaciones
            // 
            this.accordionControlElementCotizaciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCotizaciones.ImageOptions.Image")));
            this.accordionControlElementCotizaciones.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementCotizaciones.Name = "accordionControlElementCotizaciones";
            this.accordionControlElementCotizaciones.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCotizaciones.Text = "Cotizaciones";
            this.accordionControlElementCotizaciones.Click += new System.EventHandler(this.accordionControlElementCotizaciones_Click);
            // 
            // accordionControlElementPedidos
            // 
            this.accordionControlElementPedidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPedidos.ImageOptions.Image")));
            this.accordionControlElementPedidos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementPedidos.Name = "accordionControlElementPedidos";
            this.accordionControlElementPedidos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPedidos.Text = "Orden de Venta";
            this.accordionControlElementPedidos.Click += new System.EventHandler(this.accordionControlElementPedidos_Click);
            // 
            // accordionControlElementEntregaMercancia
            // 
            this.accordionControlElementEntregaMercancia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementEntregaMercancia.ImageOptions.Image")));
            this.accordionControlElementEntregaMercancia.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementEntregaMercancia.Name = "accordionControlElementEntregaMercancia";
            this.accordionControlElementEntregaMercancia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEntregaMercancia.Text = "Entrega de mercancía";
            this.accordionControlElementEntregaMercancia.Click += new System.EventHandler(this.accordionControlElementEntregaMercancia_Click);
            // 
            // accordionControlElementFacturas
            // 
            this.accordionControlElementFacturas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementFacturas.ImageOptions.Image")));
            this.accordionControlElementFacturas.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementFacturas.Name = "accordionControlElementFacturas";
            this.accordionControlElementFacturas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementFacturas.Text = "Facturas";
            this.accordionControlElementFacturas.Click += new System.EventHandler(this.accordionControlElementFacturas_Click);
            // 
            // accordionControlElementNotasCredito
            // 
            this.accordionControlElementNotasCredito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementNotasCredito.ImageOptions.Image")));
            this.accordionControlElementNotasCredito.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementNotasCredito.Name = "accordionControlElementNotasCredito";
            this.accordionControlElementNotasCredito.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNotasCredito.Text = "Notas de crédito";
            this.accordionControlElementNotasCredito.Click += new System.EventHandler(this.accordionControlElementNotasCredito_Click);
            // 
            // accordionControlElementNotasDebito
            // 
            this.accordionControlElementNotasDebito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementNotasDebito.ImageOptions.Image")));
            this.accordionControlElementNotasDebito.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementNotasDebito.Name = "accordionControlElementNotasDebito";
            this.accordionControlElementNotasDebito.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNotasDebito.Text = "Notas de débito";
            this.accordionControlElementNotasDebito.Click += new System.EventHandler(this.accordionControlElementNotasDebito_Click);
            // 
            // accordionControlElementSocios
            // 
            this.accordionControlElementSocios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementSocios.ImageOptions.Image")));
            this.accordionControlElementSocios.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementSocios.Name = "accordionControlElementSocios";
            this.accordionControlElementSocios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSocios.Text = "Socios de negocio";
            this.accordionControlElementSocios.Click += new System.EventHandler(this.accordionControlElementSocios_Click);
            // 
            // accordionControlElementPagos
            // 
            this.accordionControlElementPagos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPagos.ImageOptions.Image")));
            this.accordionControlElementPagos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementPagos.Name = "accordionControlElementPagos";
            this.accordionControlElementPagos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPagos.Text = "Pagos";
            this.accordionControlElementPagos.Click += new System.EventHandler(this.accordionControlElementPagos_Click);
            // 
            // accordionControlElementInventario
            // 
            this.accordionControlElementInventario.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementArticulos});
            this.accordionControlElementInventario.Expanded = true;
            this.accordionControlElementInventario.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElementInventario.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControlElementInventario.Name = "accordionControlElementInventario";
            this.accordionControlElementInventario.Text = "Inventario";
            // 
            // accordionControlElementArticulos
            // 
            this.accordionControlElementArticulos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementArticulos.ImageOptions.Image")));
            this.accordionControlElementArticulos.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElementArticulos.Name = "accordionControlElementArticulos";
            this.accordionControlElementArticulos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementArticulos.Text = "Artículos";
            this.accordionControlElementArticulos.Click += new System.EventHandler(this.accordionControlElementArticulos_Click);
            // 
            // accordionControlElementInformes
            // 
            this.accordionControlElementInformes.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accoCorteCaja,
            this.accFacturasDiarias,
            this.accPagosCredito,
            this.accNC,
            this.accordionControlElement10,
            this.accordionControlElement11,
            this.accordionControlElement12,
            this.accordionControlElement13});
            this.accordionControlElementInformes.Expanded = true;
            this.accordionControlElementInformes.Name = "accordionControlElementInformes";
            this.accordionControlElementInformes.Text = "Informes";
            // 
            // accoCorteCaja
            // 
            this.accoCorteCaja.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accoCorteCaja.ImageOptions.Image")));
            this.accoCorteCaja.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accoCorteCaja.Name = "accoCorteCaja";
            this.accoCorteCaja.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accoCorteCaja.Text = "Corte de Caja";
            this.accoCorteCaja.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // accFacturasDiarias
            // 
            this.accFacturasDiarias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accFacturasDiarias.ImageOptions.Image")));
            this.accFacturasDiarias.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accFacturasDiarias.Name = "accFacturasDiarias";
            this.accFacturasDiarias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accFacturasDiarias.Text = "Facturas Diarias";
            this.accFacturasDiarias.Click += new System.EventHandler(this.accFacturasDiarias_Click);
            // 
            // accPagosCredito
            // 
            this.accPagosCredito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accPagosCredito.ImageOptions.Image")));
            this.accPagosCredito.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accPagosCredito.Name = "accPagosCredito";
            this.accPagosCredito.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accPagosCredito.Text = "Pagos de Credito";
            this.accPagosCredito.Click += new System.EventHandler(this.accPagosCredito_Click);
            // 
            // accNC
            // 
            this.accNC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accNC.ImageOptions.Image")));
            this.accNC.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accNC.Name = "accNC";
            this.accNC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accNC.Text = "Notas de Credito";
            this.accNC.Click += new System.EventHandler(this.accNC_Click);
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement10.ImageOptions.Image")));
            this.accordionControlElement10.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Facturas Canceladas";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement11.ImageOptions.Image")));
            this.accordionControlElement11.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Partidas Abiertas";
            this.accordionControlElement11.Click += new System.EventHandler(this.accordionControlElement11_Click);
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement12.ImageOptions.Image")));
            this.accordionControlElement12.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Pago de Comisiones";
            this.accordionControlElement12.Click += new System.EventHandler(this.accordionControlElement12_Click);
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement13.ImageOptions.Image")));
            this.accordionControlElement13.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Reporte de Ventas";
            this.accordionControlElement13.Click += new System.EventHandler(this.accordionControlElement13_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accMonitor});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Extras";
            // 
            // accMonitor
            // 
            this.accMonitor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accMonitor.ImageOptions.Image")));
            this.accMonitor.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accMonitor.Name = "accMonitor";
            this.accMonitor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accMonitor.Text = "Monitor Electronico";
            this.accMonitor.Click += new System.EventHandler(this.accMonitor_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.Appearance.Options.UseFont = true;
            this.lblEmpresa.AutoEllipsis = true;
            this.lblEmpresa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmpresa.Location = new System.Drawing.Point(10, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(270, 23);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "CM internacional";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = "CERRAR SESIÓN";
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSalir,
            this.barHeaderItemEstacion,
            this.bbiEventosControles,
            this.bbiDiseñadorInformes,
            this.bbiConsultasPersonalizadas,
            this.bbiSincronizacion,
            this.bbiEntradasAbiertas,
            this.barEditItemAutorizaciones,
            this.bbiEtiquetas,
            this.bbiTransmitirRecibir,
            this.bbiDiseñadorEscritorios,
            this.bbiSucursales,
            this.bbiParametrizacion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 294;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHerramientas});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(1136, 90);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ApplicationButtonClick += new System.EventHandler(this.ribbonControl1_ApplicationButtonClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 5;
            this.bbiSalir.Name = "bbiSalir";
            // 
            // barHeaderItemEstacion
            // 
            this.barHeaderItemEstacion.Caption = "Estación";
            this.barHeaderItemEstacion.Description = "Estación de trabajo";
            this.barHeaderItemEstacion.Id = 8;
            this.barHeaderItemEstacion.Name = "barHeaderItemEstacion";
            // 
            // bbiEventosControles
            // 
            this.bbiEventosControles.Caption = "Eventos de controles";
            this.bbiEventosControles.Id = 9;
            this.bbiEventosControles.ImageOptions.ImageUri.Uri = "SendToBack";
            this.bbiEventosControles.Name = "bbiEventosControles";
            this.bbiEventosControles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEventosControles_ItemClick);
            // 
            // bbiDiseñadorInformes
            // 
            this.bbiDiseñadorInformes.Caption = "Diseñador de informes";
            this.bbiDiseñadorInformes.Id = 10;
            this.bbiDiseñadorInformes.ImageOptions.ImageUri.Uri = "Paste";
            this.bbiDiseñadorInformes.Name = "bbiDiseñadorInformes";
            this.bbiDiseñadorInformes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseñadorInformes_ItemClick);
            // 
            // bbiConsultasPersonalizadas
            // 
            this.bbiConsultasPersonalizadas.Caption = "Consultas personalizadas";
            this.bbiConsultasPersonalizadas.Id = 11;
            this.bbiConsultasPersonalizadas.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.bbiConsultasPersonalizadas.Name = "bbiConsultasPersonalizadas";
            this.bbiConsultasPersonalizadas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConsultasPersonalizadas_ItemClick);
            // 
            // bbiSincronizacion
            // 
            this.bbiSincronizacion.Caption = "Sincronización";
            this.bbiSincronizacion.Id = 12;
            this.bbiSincronizacion.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiSincronizacion.Name = "bbiSincronizacion";
            this.bbiSincronizacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSincronizacion_ItemClick);
            // 
            // bbiEntradasAbiertas
            // 
            this.bbiEntradasAbiertas.Caption = "Facturar entregas";
            this.bbiEntradasAbiertas.Id = 13;
            this.bbiEntradasAbiertas.ImageOptions.ImageUri.Uri = "Replace";
            this.bbiEntradasAbiertas.Name = "bbiEntradasAbiertas";
            this.bbiEntradasAbiertas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntradasAbiertas_ItemClick);
            // 
            // barEditItemAutorizaciones
            // 
            this.barEditItemAutorizaciones.Caption = "Suscribir autorizaciones";
            this.barEditItemAutorizaciones.Edit = this.repositoryItemToggleSwitch1;
            this.barEditItemAutorizaciones.EditHeight = 24;
            this.barEditItemAutorizaciones.EditWidth = 70;
            this.barEditItemAutorizaciones.Id = 14;
            this.barEditItemAutorizaciones.Name = "barEditItemAutorizaciones";
            this.barEditItemAutorizaciones.EditValueChanged += new System.EventHandler(this.barEditItemAutorizaciones_EditValueChanged);
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "No";
            this.repositoryItemToggleSwitch1.OnText = "Si";
            // 
            // bbiEtiquetas
            // 
            this.bbiEtiquetas.Caption = "Etiquetas";
            this.bbiEtiquetas.Id = 1;
            this.bbiEtiquetas.ImageOptions.ImageUri.Uri = "WrapText";
            this.bbiEtiquetas.Name = "bbiEtiquetas";
            this.bbiEtiquetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEtiquetas_ItemClick);
            // 
            // bbiTransmitirRecibir
            // 
            this.bbiTransmitirRecibir.Caption = "Transmitir / Recibir";
            this.bbiTransmitirRecibir.Id = 3;
            this.bbiTransmitirRecibir.ImageOptions.ImageUri.Uri = "Recurrence";
            this.bbiTransmitirRecibir.Name = "bbiTransmitirRecibir";
            this.bbiTransmitirRecibir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTransmitirRecibir_ItemClick);
            // 
            // bbiDiseñadorEscritorios
            // 
            this.bbiDiseñadorEscritorios.Caption = "Diseñador de escritorios";
            this.bbiDiseñadorEscritorios.Id = 4;
            this.bbiDiseñadorEscritorios.ImageOptions.ImageUri.Uri = "Chart";
            this.bbiDiseñadorEscritorios.Name = "bbiDiseñadorEscritorios";
            this.bbiDiseñadorEscritorios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseñadorEscritorios_ItemClick);
            // 
            // bbiSucursales
            // 
            this.bbiSucursales.Caption = "Sucursales";
            this.bbiSucursales.Id = 6;
            this.bbiSucursales.Name = "bbiSucursales";
            this.bbiSucursales.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.bbiSucursales_ListItemClick);
            // 
            // bbiParametrizacion
            // 
            this.bbiParametrizacion.Caption = "Parametrizaciones del Formulario";
            this.bbiParametrizacion.Id = 7;
            this.bbiParametrizacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiParametrizacion.ImageOptions.Image")));
            this.bbiParametrizacion.Name = "bbiParametrizacion";
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
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiConsultasPersonalizadas);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barHeaderItemEstacion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 776);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1136, 29);
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Inventario";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Artículos";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Almacenes";
            // 
            // timerAutorizaciones
            // 
            this.timerAutorizaciones.Enabled = true;
            this.timerAutorizaciones.Interval = 5000;
            this.timerAutorizaciones.Tick += new System.EventHandler(this.timerAutorizaciones_Tick);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element1";
            // 
            // frmPrincipal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 805);
            this.Controls.Add(this.dockPanelMenuPrincipal);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "CM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelMenuPrincipal.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private AccordionControlElement accoCorteCaja;
        private AccordionControlElement accFacturasDiarias;
        private AccordionControlElement accPagosCredito;
        private AccordionControlElement accNC;
        private AccordionControlElement accordionControlElement10;
        private AccordionControlElement accordionControlElement11;
        private AccordionControlElement accordionControlElement12;
        private AccordionControlElement accordionControlElement13;
        private AccordionControlElement accordionControlElement5;
        private AccordionControlElement accMonitor;
        private BarButtonItem bbiParametrizacion;
    }
}