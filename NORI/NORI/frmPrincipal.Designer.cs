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
            this.accordionControlElementEstaciones = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDepartamentos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementVendedores = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementZonas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSeries = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestionInformes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFinanzas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementImpuestos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMonedas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTipoCambio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementActivosFijos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestionSociosNegocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGruposSocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCondicionesPago = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMetodosPago = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTiposMetodosPagos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPaises = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEstados = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGestionInventario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGruposArticulos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAlmacenes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFabricantes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCompras = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCotizacionCompra = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementOrdenCompra = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEntradaMercancias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEntradasMercancias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDevolucionMercancias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementVentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCotizaciones = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPedidos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEntregas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEntregaMercancia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDevoluciones = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAnticiposClientes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementFacturas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNotasCredito = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNotasDebito = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSocios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPagos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInventario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementArticulos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInventarioListasPrecios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementListasPrecios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementOperacionesStock = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAjusteEntrada = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAjusteSalida = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSolicitudTraslado = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTransferenciaStock = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInventarioFisico = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInformes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementListaPartidas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementExtras = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementListaPedidosWeb = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementRestaurante = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementRestauranteMesas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControKioscoFacturacion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelMenuPrincipal.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(315, 656);
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
            this.accordionControlElementCompras,
            this.accordionControlElementVentas,
            this.accordionControlElementSocios,
            this.accordionControlElementPagos,
            this.accordionControlElementInventario,
            this.accordionControlElementInformes,
            this.accordionControlElementExtras});
            this.accordionControl1.Location = new System.Drawing.Point(3, 29);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(273, 630);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionControlElementUsuario
            // 
            this.accordionControlElementUsuario.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCerrarSesion,
            this.accordionControlElementBloquear});
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
            this.accordionControlElementCerrarSesion.Name = "accordionControlElementCerrarSesion";
            this.accordionControlElementCerrarSesion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCerrarSesion.Text = "Cerrar sesión";
            this.accordionControlElementCerrarSesion.Click += new System.EventHandler(this.accordionControlElementCerrarSesion_Click);
            // 
            // accordionControlElementBloquear
            // 
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
            this.accordionControlElementEstaciones,
            this.accordionControlElementDepartamentos,
            this.accordionControlElementVendedores,
            this.accordionControlElementZonas,
            this.accordionControlElementSeries,
            this.accordionControlElementGestionInformes});
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
            this.accordionControlElementEmpresa.Name = "accordionControlElementEmpresa";
            this.accordionControlElementEmpresa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEmpresa.Text = "Empresa";
            this.accordionControlElementEmpresa.Click += new System.EventHandler(this.accordionControlElementEmpresa_Click);
            // 
            // accordionControlElementConfiguracion
            // 
            this.accordionControlElementConfiguracion.Name = "accordionControlElementConfiguracion";
            this.accordionControlElementConfiguracion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementConfiguracion.Text = "Configuración";
            this.accordionControlElementConfiguracion.Click += new System.EventHandler(this.accordionControlElementConfiguracion_Click);
            // 
            // accordionControlElementUsuarios
            // 
            this.accordionControlElementUsuarios.Name = "accordionControlElementUsuarios";
            this.accordionControlElementUsuarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementUsuarios.Text = "Usuarios";
            this.accordionControlElementUsuarios.Click += new System.EventHandler(this.accordionControlElementUsuarios_Click);
            // 
            // accordionControlElementEstaciones
            // 
            this.accordionControlElementEstaciones.Name = "accordionControlElementEstaciones";
            this.accordionControlElementEstaciones.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEstaciones.Text = "Estaciones de trabajo";
            this.accordionControlElementEstaciones.Click += new System.EventHandler(this.accordionControlElementEstaciones_Click);
            // 
            // accordionControlElementDepartamentos
            // 
            this.accordionControlElementDepartamentos.Name = "accordionControlElementDepartamentos";
            this.accordionControlElementDepartamentos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDepartamentos.Text = "Departamentos";
            this.accordionControlElementDepartamentos.Click += new System.EventHandler(this.accordionControlElementDepartamentos_Click);
            // 
            // accordionControlElementVendedores
            // 
            this.accordionControlElementVendedores.Name = "accordionControlElementVendedores";
            this.accordionControlElementVendedores.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementVendedores.Text = "Vendedores";
            this.accordionControlElementVendedores.Click += new System.EventHandler(this.accordionControlElementVendedores_Click);
            // 
            // accordionControlElementZonas
            // 
            this.accordionControlElementZonas.Name = "accordionControlElementZonas";
            this.accordionControlElementZonas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementZonas.Text = "Zonas";
            this.accordionControlElementZonas.Click += new System.EventHandler(this.accordionControlElementZonas_Click);
            // 
            // accordionControlElementSeries
            // 
            this.accordionControlElementSeries.Name = "accordionControlElementSeries";
            this.accordionControlElementSeries.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSeries.Text = "Series de documentos";
            this.accordionControlElementSeries.Click += new System.EventHandler(this.accordionControlElementSeries_Click);
            // 
            // accordionControlElementGestionInformes
            // 
            this.accordionControlElementGestionInformes.Name = "accordionControlElementGestionInformes";
            this.accordionControlElementGestionInformes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGestionInformes.Text = "Informes";
            this.accordionControlElementGestionInformes.Click += new System.EventHandler(this.accordionControlElementInformes_Click);
            // 
            // accordionControlElementFinanzas
            // 
            this.accordionControlElementFinanzas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementImpuestos,
            this.accordionControlElementMonedas,
            this.accordionControlElementTipoCambio,
            this.accordionControlElementActivosFijos});
            this.accordionControlElementFinanzas.Name = "accordionControlElementFinanzas";
            this.accordionControlElementFinanzas.Text = "Finanzas";
            // 
            // accordionControlElementImpuestos
            // 
            this.accordionControlElementImpuestos.Name = "accordionControlElementImpuestos";
            this.accordionControlElementImpuestos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementImpuestos.Text = "Impuestos";
            this.accordionControlElementImpuestos.Click += new System.EventHandler(this.accordionControlElementImpuestos_Click);
            // 
            // accordionControlElementMonedas
            // 
            this.accordionControlElementMonedas.Name = "accordionControlElementMonedas";
            this.accordionControlElementMonedas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMonedas.Text = "Monedas";
            this.accordionControlElementMonedas.Click += new System.EventHandler(this.accordionControlElementMonedas_Click);
            // 
            // accordionControlElementTipoCambio
            // 
            this.accordionControlElementTipoCambio.Name = "accordionControlElementTipoCambio";
            this.accordionControlElementTipoCambio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTipoCambio.Text = "Tipo de cambio";
            this.accordionControlElementTipoCambio.Click += new System.EventHandler(this.accordionControlElementTipoCambio_Click);
            // 
            // accordionControlElementActivosFijos
            // 
            this.accordionControlElementActivosFijos.Name = "accordionControlElementActivosFijos";
            this.accordionControlElementActivosFijos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementActivosFijos.Text = "Activos fijos";
            this.accordionControlElementActivosFijos.Click += new System.EventHandler(this.accordionControlElementActivosFijos_Click);
            // 
            // accordionControlElementGestionSociosNegocios
            // 
            this.accordionControlElementGestionSociosNegocios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementGruposSocios,
            this.accordionControlElementCondicionesPago,
            this.accordionControlElementMetodosPago,
            this.accordionControlElementTiposMetodosPagos,
            this.accordionControlElementPaises,
            this.accordionControlElementEstados});
            this.accordionControlElementGestionSociosNegocios.Name = "accordionControlElementGestionSociosNegocios";
            this.accordionControlElementGestionSociosNegocios.Text = "Socios de negocios";
            // 
            // accordionControlElementGruposSocios
            // 
            this.accordionControlElementGruposSocios.Name = "accordionControlElementGruposSocios";
            this.accordionControlElementGruposSocios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGruposSocios.Text = "Grupos de socios";
            this.accordionControlElementGruposSocios.Click += new System.EventHandler(this.accordionControlElementGruposSocios_Click);
            // 
            // accordionControlElementCondicionesPago
            // 
            this.accordionControlElementCondicionesPago.Name = "accordionControlElementCondicionesPago";
            this.accordionControlElementCondicionesPago.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCondicionesPago.Text = "Condiciones de pago";
            this.accordionControlElementCondicionesPago.Click += new System.EventHandler(this.accordionControlElementCondicionesPago_Click);
            // 
            // accordionControlElementMetodosPago
            // 
            this.accordionControlElementMetodosPago.Name = "accordionControlElementMetodosPago";
            this.accordionControlElementMetodosPago.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMetodosPago.Text = "Métodos de pago";
            this.accordionControlElementMetodosPago.Click += new System.EventHandler(this.accordionControlElementMetodosPago_Click);
            // 
            // accordionControlElementTiposMetodosPagos
            // 
            this.accordionControlElementTiposMetodosPagos.Name = "accordionControlElementTiposMetodosPagos";
            this.accordionControlElementTiposMetodosPagos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTiposMetodosPagos.Text = "Tipos de métodos de pago";
            this.accordionControlElementTiposMetodosPagos.Click += new System.EventHandler(this.accordionControlElementTiposMetodosPagos_Click);
            // 
            // accordionControlElementPaises
            // 
            this.accordionControlElementPaises.Name = "accordionControlElementPaises";
            this.accordionControlElementPaises.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPaises.Text = "Paises";
            this.accordionControlElementPaises.Click += new System.EventHandler(this.accordionControlElementPaises_Click);
            // 
            // accordionControlElementEstados
            // 
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
            this.accordionControlElementGruposArticulos.Name = "accordionControlElementGruposArticulos";
            this.accordionControlElementGruposArticulos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGruposArticulos.Text = "Grupos de artículos";
            this.accordionControlElementGruposArticulos.Click += new System.EventHandler(this.accordionControlElementGruposArticulos_Click);
            // 
            // accordionControlElementAlmacenes
            // 
            this.accordionControlElementAlmacenes.Name = "accordionControlElementAlmacenes";
            this.accordionControlElementAlmacenes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAlmacenes.Text = "Almacenes";
            this.accordionControlElementAlmacenes.Click += new System.EventHandler(this.accordionControlElementAlmacenes_Click);
            // 
            // accordionControlElementFabricantes
            // 
            this.accordionControlElementFabricantes.Name = "accordionControlElementFabricantes";
            this.accordionControlElementFabricantes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementFabricantes.Text = "Fabricantes";
            this.accordionControlElementFabricantes.Click += new System.EventHandler(this.accordionControlElementFabricantes_Click);
            // 
            // accordionControlElementCompras
            // 
            this.accordionControlElementCompras.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCotizacionCompra,
            this.accordionControlElementOrdenCompra,
            this.accordionControlElementEntradaMercancias,
            this.accordionControlElementEntradasMercancias,
            this.accordionControlElementDevolucionMercancias});
            this.accordionControlElementCompras.Name = "accordionControlElementCompras";
            this.accordionControlElementCompras.Text = "Compras";
            // 
            // accordionControlElementCotizacionCompra
            // 
            this.accordionControlElementCotizacionCompra.Name = "accordionControlElementCotizacionCompra";
            this.accordionControlElementCotizacionCompra.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCotizacionCompra.Text = "Cotización";
            this.accordionControlElementCotizacionCompra.Click += new System.EventHandler(this.accordionControlElementCotizacionCompra_Click);
            // 
            // accordionControlElementOrdenCompra
            // 
            this.accordionControlElementOrdenCompra.Name = "accordionControlElementOrdenCompra";
            this.accordionControlElementOrdenCompra.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementOrdenCompra.Text = "Orden de compra";
            this.accordionControlElementOrdenCompra.Click += new System.EventHandler(this.accordionControlElementOrdenCompra_Click);
            // 
            // accordionControlElementEntradaMercancias
            // 
            this.accordionControlElementEntradaMercancias.Name = "accordionControlElementEntradaMercancias";
            this.accordionControlElementEntradaMercancias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEntradaMercancias.Text = "Entrada mercancía";
            this.accordionControlElementEntradaMercancias.Click += new System.EventHandler(this.accordionControlElementEntradaMercancias_Click);
            // 
            // accordionControlElementEntradasMercancias
            // 
            this.accordionControlElementEntradasMercancias.Name = "accordionControlElementEntradasMercancias";
            this.accordionControlElementEntradasMercancias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEntradasMercancias.Text = "Entradas de mercancías";
            this.accordionControlElementEntradasMercancias.Click += new System.EventHandler(this.accordionControlElementEntradasMercancias_Click);
            // 
            // accordionControlElementDevolucionMercancias
            // 
            this.accordionControlElementDevolucionMercancias.Name = "accordionControlElementDevolucionMercancias";
            this.accordionControlElementDevolucionMercancias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDevolucionMercancias.Text = "Devoluciónes de mercancías";
            this.accordionControlElementDevolucionMercancias.Click += new System.EventHandler(this.accordionControlElementDevolucionMercancias_Click);
            // 
            // accordionControlElementVentas
            // 
            this.accordionControlElementVentas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCotizaciones,
            this.accordionControlElementPedidos,
            this.accordionControlElementEntregas,
            this.accordionControlElementEntregaMercancia,
            this.accordionControlElementDevoluciones,
            this.accordionControlElementAnticiposClientes,
            this.accordionControlElementFacturas,
            this.accordionControlElementNotasCredito,
            this.accordionControlElementNotasDebito});
            this.accordionControlElementVentas.Name = "accordionControlElementVentas";
            this.accordionControlElementVentas.Text = "Ventas";
            // 
            // accordionControlElementCotizaciones
            // 
            this.accordionControlElementCotizaciones.Name = "accordionControlElementCotizaciones";
            this.accordionControlElementCotizaciones.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCotizaciones.Text = "Cotizaciones";
            this.accordionControlElementCotizaciones.Click += new System.EventHandler(this.accordionControlElementCotizaciones_Click);
            // 
            // accordionControlElementPedidos
            // 
            this.accordionControlElementPedidos.Name = "accordionControlElementPedidos";
            this.accordionControlElementPedidos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPedidos.Text = "Pedidos";
            this.accordionControlElementPedidos.Click += new System.EventHandler(this.accordionControlElementPedidos_Click);
            // 
            // accordionControlElementEntregas
            // 
            this.accordionControlElementEntregas.Name = "accordionControlElementEntregas";
            this.accordionControlElementEntregas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEntregas.Text = "Entregas";
            this.accordionControlElementEntregas.Click += new System.EventHandler(this.accordionControlElementEntregas_Click);
            // 
            // accordionControlElementEntregaMercancia
            // 
            this.accordionControlElementEntregaMercancia.Name = "accordionControlElementEntregaMercancia";
            this.accordionControlElementEntregaMercancia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEntregaMercancia.Text = "Entrega de mercancía";
            this.accordionControlElementEntregaMercancia.Click += new System.EventHandler(this.accordionControlElementEntregaMercancia_Click);
            // 
            // accordionControlElementDevoluciones
            // 
            this.accordionControlElementDevoluciones.Name = "accordionControlElementDevoluciones";
            this.accordionControlElementDevoluciones.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDevoluciones.Text = "Devoluciones";
            this.accordionControlElementDevoluciones.Click += new System.EventHandler(this.accordionControlElementDevoluciones_Click);
            // 
            // accordionControlElementAnticiposClientes
            // 
            this.accordionControlElementAnticiposClientes.Name = "accordionControlElementAnticiposClientes";
            this.accordionControlElementAnticiposClientes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAnticiposClientes.Text = "Anticipos";
            this.accordionControlElementAnticiposClientes.Click += new System.EventHandler(this.accordionControlElementAnticiposClientes_Click);
            // 
            // accordionControlElementFacturas
            // 
            this.accordionControlElementFacturas.Name = "accordionControlElementFacturas";
            this.accordionControlElementFacturas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementFacturas.Text = "Facturas";
            this.accordionControlElementFacturas.Click += new System.EventHandler(this.accordionControlElementFacturas_Click);
            // 
            // accordionControlElementNotasCredito
            // 
            this.accordionControlElementNotasCredito.Name = "accordionControlElementNotasCredito";
            this.accordionControlElementNotasCredito.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNotasCredito.Text = "Notas de crédito";
            this.accordionControlElementNotasCredito.Click += new System.EventHandler(this.accordionControlElementNotasCredito_Click);
            // 
            // accordionControlElementNotasDebito
            // 
            this.accordionControlElementNotasDebito.Name = "accordionControlElementNotasDebito";
            this.accordionControlElementNotasDebito.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNotasDebito.Text = "Notas de débito";
            this.accordionControlElementNotasDebito.Click += new System.EventHandler(this.accordionControlElementNotasDebito_Click);
            // 
            // accordionControlElementSocios
            // 
            this.accordionControlElementSocios.Name = "accordionControlElementSocios";
            this.accordionControlElementSocios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSocios.Text = "Socios de negocio";
            this.accordionControlElementSocios.Click += new System.EventHandler(this.accordionControlElementSocios_Click);
            // 
            // accordionControlElementPagos
            // 
            this.accordionControlElementPagos.Name = "accordionControlElementPagos";
            this.accordionControlElementPagos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPagos.Text = "Pagos";
            this.accordionControlElementPagos.Click += new System.EventHandler(this.accordionControlElementPagos_Click);
            // 
            // accordionControlElementInventario
            // 
            this.accordionControlElementInventario.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementArticulos,
            this.accordionControlElementInventarioListasPrecios,
            this.accordionControlElementOperacionesStock});
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
            this.accordionControlElementArticulos.Name = "accordionControlElementArticulos";
            this.accordionControlElementArticulos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementArticulos.Text = "Artículos";
            this.accordionControlElementArticulos.Click += new System.EventHandler(this.accordionControlElementArticulos_Click);
            // 
            // accordionControlElementInventarioListasPrecios
            // 
            this.accordionControlElementInventarioListasPrecios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementListasPrecios});
            this.accordionControlElementInventarioListasPrecios.Name = "accordionControlElementInventarioListasPrecios";
            this.accordionControlElementInventarioListasPrecios.Text = "Listas de precios";
            // 
            // accordionControlElementListasPrecios
            // 
            this.accordionControlElementListasPrecios.Name = "accordionControlElementListasPrecios";
            this.accordionControlElementListasPrecios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementListasPrecios.Text = "Listas de precios";
            this.accordionControlElementListasPrecios.Click += new System.EventHandler(this.accordionControlElementListasPrecios_Click);
            // 
            // accordionControlElementOperacionesStock
            // 
            this.accordionControlElementOperacionesStock.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementAjusteEntrada,
            this.accordionControlElementAjusteSalida,
            this.accordionControlElementSolicitudTraslado,
            this.accordionControlElementTransferenciaStock,
            this.accordionControlElementInventarioFisico});
            this.accordionControlElementOperacionesStock.Expanded = true;
            this.accordionControlElementOperacionesStock.Name = "accordionControlElementOperacionesStock";
            this.accordionControlElementOperacionesStock.Text = "Operaciones de stock";
            // 
            // accordionControlElementAjusteEntrada
            // 
            this.accordionControlElementAjusteEntrada.Name = "accordionControlElementAjusteEntrada";
            this.accordionControlElementAjusteEntrada.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAjusteEntrada.Text = "Ajuste de entrada";
            this.accordionControlElementAjusteEntrada.Click += new System.EventHandler(this.accordionControlElementAjusteEntrada_Click);
            // 
            // accordionControlElementAjusteSalida
            // 
            this.accordionControlElementAjusteSalida.Name = "accordionControlElementAjusteSalida";
            this.accordionControlElementAjusteSalida.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAjusteSalida.Text = "Ajuste de salida";
            this.accordionControlElementAjusteSalida.Click += new System.EventHandler(this.accordionControlElementAjusteSalida_Click);
            // 
            // accordionControlElementSolicitudTraslado
            // 
            this.accordionControlElementSolicitudTraslado.Name = "accordionControlElementSolicitudTraslado";
            this.accordionControlElementSolicitudTraslado.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSolicitudTraslado.Text = "Solicitud de traslado";
            this.accordionControlElementSolicitudTraslado.Click += new System.EventHandler(this.accordionControlElementSolicitudTraslado_Click);
            // 
            // accordionControlElementTransferenciaStock
            // 
            this.accordionControlElementTransferenciaStock.Name = "accordionControlElementTransferenciaStock";
            this.accordionControlElementTransferenciaStock.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTransferenciaStock.Text = "Transferencia de stock";
            this.accordionControlElementTransferenciaStock.Click += new System.EventHandler(this.accordionControlElementTransferenciaStock_Click);
            // 
            // accordionControlElementInventarioFisico
            // 
            this.accordionControlElementInventarioFisico.Name = "accordionControlElementInventarioFisico";
            this.accordionControlElementInventarioFisico.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementInventarioFisico.Text = "Inventario físico";
            this.accordionControlElementInventarioFisico.Click += new System.EventHandler(this.accordionControlElementInventarioFisico_Click);
            // 
            // accordionControlElementInformes
            // 
            this.accordionControlElementInformes.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementListaPartidas});
            this.accordionControlElementInformes.Expanded = true;
            this.accordionControlElementInformes.Name = "accordionControlElementInformes";
            this.accordionControlElementInformes.Text = "Informes";
            // 
            // accordionControlElementListaPartidas
            // 
            this.accordionControlElementListaPartidas.Name = "accordionControlElementListaPartidas";
            this.accordionControlElementListaPartidas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementListaPartidas.Text = "Lista partidas";
            this.accordionControlElementListaPartidas.Visible = false;
            this.accordionControlElementListaPartidas.Click += new System.EventHandler(this.accordionControlElementListaPartidas_Click);
            // 
            // accordionControlElementExtras
            // 
            this.accordionControlElementExtras.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementListaPedidosWeb,
            this.accordionControlElementRestaurante,
            this.accordionControKioscoFacturacion});
            this.accordionControlElementExtras.Expanded = true;
            this.accordionControlElementExtras.Name = "accordionControlElementExtras";
            this.accordionControlElementExtras.Text = "Extras";
            this.accordionControlElementExtras.Visible = false;
            // 
            // accordionControlElementListaPedidosWeb
            // 
            this.accordionControlElementListaPedidosWeb.Name = "accordionControlElementListaPedidosWeb";
            this.accordionControlElementListaPedidosWeb.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementListaPedidosWeb.Text = "Lista de pedidos web";
            this.accordionControlElementListaPedidosWeb.Click += new System.EventHandler(this.accordionControlElementListaPedidosWeb_Click);
            // 
            // accordionControlElementRestaurante
            // 
            this.accordionControlElementRestaurante.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementRestauranteMesas});
            this.accordionControlElementRestaurante.Name = "accordionControlElementRestaurante";
            this.accordionControlElementRestaurante.Text = "Restaurante";
            this.accordionControlElementRestaurante.Visible = false;
            // 
            // accordionControlElementRestauranteMesas
            // 
            this.accordionControlElementRestauranteMesas.Name = "accordionControlElementRestauranteMesas";
            this.accordionControlElementRestauranteMesas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementRestauranteMesas.Text = "Mesas";
            this.accordionControlElementRestauranteMesas.Click += new System.EventHandler(this.accordionControlElementRestauranteMesas_Click);
            // 
            // accordionControKioscoFacturacion
            // 
            this.accordionControKioscoFacturacion.Name = "accordionControKioscoFacturacion";
            this.accordionControKioscoFacturacion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControKioscoFacturacion.Text = "Kiosco";
            this.accordionControKioscoFacturacion.Click += new System.EventHandler(this.accordionControKioscoFacturacion_Click);
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
            this.bbiSucursales});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
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
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiDiseñadorInformes);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barHeaderItemEstacion);
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItemAutorizaciones);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::componentResourceManager.Resources.logodiesel;
            this.pictureBox1.Location = new System.Drawing.Point(837, 609);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 141);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 805);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dockPanelMenuPrincipal);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Nori";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
    }
}