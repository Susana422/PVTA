using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Padding = System.Windows.Forms.Padding;


namespace DTM
{
    partial class frmConfiguracion
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        this.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabNavigationPageNetSuite = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cbNetSuite = new DevExpress.XtraEditors.CheckEdit();
            this.gbNetSuite = new System.Windows.Forms.GroupBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteCuentaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteTokenId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteClienteSecreto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteTokenSecreto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteClienteLlave = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetSuiteApiURL = new DevExpress.XtraEditors.TextEdit();
            this.btnProbarConexion = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPageSAP = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbSAP = new DevExpress.XtraEditors.CheckEdit();
            this.lblSAP = new DevExpress.XtraEditors.LabelControl();
            this.gbSAP = new System.Windows.Forms.GroupBox();
            this.lblServidor = new DevExpress.XtraEditors.LabelControl();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.lblTipoServidorBD = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoServidorBD = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBD = new DevExpress.XtraEditors.LabelControl();
            this.txtBD = new DevExpress.XtraEditors.TextEdit();
            this.lblContraseñaBD = new DevExpress.XtraEditors.LabelControl();
            this.txtContraseñaBD = new DevExpress.XtraEditors.TextEdit();
            this.lblServidorLicencias = new DevExpress.XtraEditors.LabelControl();
            this.txtServidorLicencias = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblContraseña = new DevExpress.XtraEditors.LabelControl();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.cbConfiable = new DevExpress.XtraEditors.CheckEdit();
            this.lblUsuarioBD = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuarioBD = new DevExpress.XtraEditors.TextEdit();
            this.gcOpciones = new DevExpress.XtraEditors.GroupControl();
            this.cbGenerarAjusteInventario = new DevExpress.XtraEditors.CheckEdit();
            this.lblHoraSicronizacionGeneral = new DevExpress.XtraEditors.LabelControl();
            this.teHoraSincronizacionGenerales = new DevExpress.XtraEditors.TimeEdit();
            this.txtNumeroCuentaAjusteInventario = new DevExpress.XtraEditors.TextEdit();
            this.lblSAPAPIURL = new DevExpress.XtraEditors.LabelControl();
            this.txtSAPAPIURL = new DevExpress.XtraEditors.TextEdit();
            this.cbFacturarEntregas = new DevExpress.XtraEditors.CheckEdit();
            this.cbInventarioSAP = new DevExpress.XtraEditors.CheckEdit();
            this.txtFuenteDatos = new DevExpress.XtraEditors.TextEdit();
            this.lblFuenteDatos = new DevExpress.XtraEditors.LabelControl();
            this.lblSucursales = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.tabNavigationPageTimbrado = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtTimbradoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtTimbradoContraseña = new DevExpress.XtraEditors.TextEdit();
            this.cbGenerarTimbradoSinDescuento = new DevExpress.XtraEditors.CheckEdit();
            this.cbTimbradoModoPrueba = new DevExpress.XtraEditors.CheckEdit();
            this.btnCertificados = new DevExpress.XtraEditors.SimpleButton();
            this.lblCertificado = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbCertificados = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTimbradoContraseña = new DevExpress.XtraEditors.LabelControl();
            this.lblTimbradoUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblPAC = new DevExpress.XtraEditors.LabelControl();
            this.cbPAC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbPedimentos = new DevExpress.XtraEditors.CheckEdit();
            this.tabNavigationPageDirectorios = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblDirectorioDocumentos = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectorioDocumentos = new DevExpress.XtraEditors.TextEdit();
            this.lblDirectorioImagenes = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectorioImagenes = new DevExpress.XtraEditors.TextEdit();
            this.lblDirectorioXML = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectorioXML = new DevExpress.XtraEditors.TextEdit();
            this.lblDirectorioInformes = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectorioInformes = new DevExpress.XtraEditors.TextEdit();
            this.lblDirectorioAnexos = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectorioAnexos = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPagePredeterminados = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblGrupoArticulos = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbGruposArticulos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblListaPrecios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbListasPrecios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMonedas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.cbFabricantes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFabricantes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblMetodoPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbMetodosPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCondicionesPago = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbCondicionesPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblZonas = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbZonas = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDepartamentos = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbDepartamentos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblImpuesto = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbImpuestos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.cbDiasSemana = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabNavigationPageGeneral = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.cbFormularioPanel = new DevExpress.XtraEditors.CheckEdit();
            this.cbVentaArticuloPrecioCero = new DevExpress.XtraEditors.CheckEdit();
            this.cbGenerarDocumentoElectronicoAutomaticamente = new DevExpress.XtraEditors.CheckEdit();
            this.cbDocumentoBorrador = new DevExpress.XtraEditors.CheckEdit();
            this.cbVentaArticuloStockCero = new DevExpress.XtraEditors.CheckEdit();
            this.cbAgruparPartidas = new DevExpress.XtraEditors.CheckEdit();
            this.cbVendedorSegunUsuario = new DevExpress.XtraEditors.CheckEdit();
            this.cbVendedorSegunEstacion = new DevExpress.XtraEditors.CheckEdit();
            this.cbDocumentosModoNuevo = new DevExpress.XtraEditors.CheckEdit();
            this.cbVentaArticuloMenorCosto = new DevExpress.XtraEditors.CheckEdit();
            this.cbListaPrecioSegunUsuario = new DevExpress.XtraEditors.CheckEdit();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.tabNavigationPageNetSuite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNetSuite.Properties)).BeginInit();
            this.gbNetSuite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteCuentaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteTokenId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteClienteSecreto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteTokenSecreto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteClienteLlave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteApiURL.Properties)).BeginInit();
            this.tabNavigationPageSAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSAP.Properties)).BeginInit();
            this.gbSAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoServidorBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseñaBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidorLicencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConfiable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOpciones)).BeginInit();
            this.gcOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarAjusteInventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHoraSincronizacionGenerales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuentaAjusteInventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSAPAPIURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturarEntregas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInventarioSAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuenteDatos.Properties)).BeginInit();
            this.tabNavigationPageTimbrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimbradoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimbradoContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarTimbradoSinDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimbradoModoPrueba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCertificados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPedimentos.Properties)).BeginInit();
            this.tabNavigationPageDirectorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioDocumentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioImagenes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioXML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioInformes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioAnexos.Properties)).BeginInit();
            this.tabNavigationPagePredeterminados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbZonas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiasSemana.Properties)).BeginInit();
            this.tabNavigationPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormularioPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloPrecioCero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarDocumentoElectronicoAutomaticamente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentoBorrador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloStockCero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgruparPartidas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedorSegunUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedorSegunEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentosModoNuevo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloMenorCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecioSegunUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.panel1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 90);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(774, 553);
            this.dataLayoutControl1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabPane1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 529);
            this.panel1.TabIndex = 54;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mainRibbonControl.MaxItemId = 1;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 440;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(774, 90);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(55, 162);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Opciones";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(774, 553);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(754, 533);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tabNavigationPageNetSuite
            // 
            this.tabNavigationPageNetSuite.Caption = "NetSuite";
            this.tabNavigationPageNetSuite.Controls.Add(this.gbNetSuite);
            this.tabNavigationPageNetSuite.Controls.Add(this.cbNetSuite);
            this.tabNavigationPageNetSuite.Controls.Add(this.labelControl13);
            this.tabNavigationPageNetSuite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNavigationPageNetSuite.Name = "tabNavigationPageNetSuite";
            this.tabNavigationPageNetSuite.Size = new System.Drawing.Size(750, 504);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(5, 35);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(613, 17);
            this.labelControl13.TabIndex = 7;
            this.labelControl13.Text = "Esta opción sobre escribe funciones nativas del sistema, y se inhabilita la creac" +
    "ión de múltiples objetos. \r\n";
            // 
            // cbNetSuite
            // 
            this.cbNetSuite.Location = new System.Drawing.Point(5, 4);
            this.cbNetSuite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbNetSuite.MenuManager = this.mainRibbonControl;
            this.cbNetSuite.Name = "cbNetSuite";
            this.cbNetSuite.Properties.Caption = "Habilitar sincronización con NetSuite (Irreversible)";
            this.cbNetSuite.Size = new System.Drawing.Size(421, 21);
            this.cbNetSuite.TabIndex = 1;
            // 
            // gbNetSuite
            // 
            this.gbNetSuite.Controls.Add(this.btnProbarConexion);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteApiURL);
            this.gbNetSuite.Controls.Add(this.labelControl3);
            this.gbNetSuite.Controls.Add(this.labelControl2);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteClienteLlave);
            this.gbNetSuite.Controls.Add(this.labelControl5);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteTokenSecreto);
            this.gbNetSuite.Controls.Add(this.labelControl7);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteClienteSecreto);
            this.gbNetSuite.Controls.Add(this.labelControl8);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteTokenId);
            this.gbNetSuite.Controls.Add(this.labelControl9);
            this.gbNetSuite.Controls.Add(this.labelControl10);
            this.gbNetSuite.Controls.Add(this.txtNetSuiteCuentaId);
            this.gbNetSuite.Controls.Add(this.labelControl12);
            this.gbNetSuite.Location = new System.Drawing.Point(0, 72);
            this.gbNetSuite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbNetSuite.Name = "gbNetSuite";
            this.gbNetSuite.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbNetSuite.Size = new System.Drawing.Size(703, 383);
            this.gbNetSuite.TabIndex = 8;
            this.gbNetSuite.TabStop = false;
            this.gbNetSuite.Text = "Configuración Oracle NetSuite ";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(16, 30);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 17);
            this.labelControl12.TabIndex = 63;
            this.labelControl12.Text = "Cuenta";
            // 
            // txtNetSuiteCuentaId
            // 
            this.txtNetSuiteCuentaId.Location = new System.Drawing.Point(152, 26);
            this.txtNetSuiteCuentaId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteCuentaId.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteCuentaId.Name = "txtNetSuiteCuentaId";
            this.txtNetSuiteCuentaId.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteCuentaId.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(0, 0);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(0, 17);
            this.labelControl10.TabIndex = 88;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 131);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 17);
            this.labelControl9.TabIndex = 70;
            this.labelControl9.Text = "Token";
            // 
            // txtNetSuiteTokenId
            // 
            this.txtNetSuiteTokenId.Location = new System.Drawing.Point(152, 126);
            this.txtNetSuiteTokenId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteTokenId.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteTokenId.Name = "txtNetSuiteTokenId";
            this.txtNetSuiteTokenId.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteTokenId.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 98);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 17);
            this.labelControl8.TabIndex = 72;
            this.labelControl8.Text = "Secreto cliente";
            // 
            // txtNetSuiteClienteSecreto
            // 
            this.txtNetSuiteClienteSecreto.Location = new System.Drawing.Point(152, 94);
            this.txtNetSuiteClienteSecreto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteClienteSecreto.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteClienteSecreto.Name = "txtNetSuiteClienteSecreto";
            this.txtNetSuiteClienteSecreto.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteClienteSecreto.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 165);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 17);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "Secreto token";
            // 
            // txtNetSuiteTokenSecreto
            // 
            this.txtNetSuiteTokenSecreto.Location = new System.Drawing.Point(152, 160);
            this.txtNetSuiteTokenSecreto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteTokenSecreto.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteTokenSecreto.Name = "txtNetSuiteTokenSecreto";
            this.txtNetSuiteTokenSecreto.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteTokenSecreto.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(0, 0);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 17);
            this.labelControl5.TabIndex = 86;
            // 
            // txtNetSuiteClienteLlave
            // 
            this.txtNetSuiteClienteLlave.Location = new System.Drawing.Point(152, 60);
            this.txtNetSuiteClienteLlave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteClienteLlave.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteClienteLlave.Name = "txtNetSuiteClienteLlave";
            this.txtNetSuiteClienteLlave.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteClienteLlave.TabIndex = 83;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 84;
            this.labelControl2.Text = "Llave de cliente";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 199);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 17);
            this.labelControl3.TabIndex = 90;
            this.labelControl3.Text = "Api URL";
            // 
            // txtNetSuiteApiURL
            // 
            this.txtNetSuiteApiURL.Location = new System.Drawing.Point(152, 194);
            this.txtNetSuiteApiURL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetSuiteApiURL.MenuManager = this.mainRibbonControl;
            this.txtNetSuiteApiURL.Name = "txtNetSuiteApiURL";
            this.txtNetSuiteApiURL.Size = new System.Drawing.Size(510, 24);
            this.txtNetSuiteApiURL.TabIndex = 89;
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(512, 228);
            this.btnProbarConexion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(150, 30);
            this.btnProbarConexion.TabIndex = 91;
            this.btnProbarConexion.Text = "Probar conexión";
            // 
            // tabNavigationPageSAP
            // 
            this.tabNavigationPageSAP.Caption = "SAP Business One";
            this.tabNavigationPageSAP.Controls.Add(this.lblSucursales);
            this.tabNavigationPageSAP.Controls.Add(this.gbSAP);
            this.tabNavigationPageSAP.Controls.Add(this.lblSAP);
            this.tabNavigationPageSAP.Controls.Add(this.cbSAP);
            this.tabNavigationPageSAP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabNavigationPageSAP.Name = "tabNavigationPageSAP";
            this.tabNavigationPageSAP.Size = new System.Drawing.Size(750, 504);
            // 
            // cbSAP
            // 
            this.cbSAP.Location = new System.Drawing.Point(5, 4);
            this.cbSAP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbSAP.MenuManager = this.mainRibbonControl;
            this.cbSAP.Name = "cbSAP";
            this.cbSAP.Properties.Caption = "Habilitar sincronización con SAP Business One (Irreversible)";
            this.cbSAP.Size = new System.Drawing.Size(421, 21);
            this.cbSAP.TabIndex = 0;
            // 
            // lblSAP
            // 
            this.lblSAP.Location = new System.Drawing.Point(5, 37);
            this.lblSAP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblSAP.Name = "lblSAP";
            this.lblSAP.Size = new System.Drawing.Size(613, 17);
            this.lblSAP.TabIndex = 1;
            this.lblSAP.Text = "Esta opción sobre escribe funciones nativas del sistema, y se inhabilita la creac" +
    "ión de múltiples objetos. \r\n";
            // 
            // gbSAP
            // 
            this.gbSAP.Controls.Add(this.lblFuenteDatos);
            this.gbSAP.Controls.Add(this.txtFuenteDatos);
            this.gbSAP.Controls.Add(this.gcOpciones);
            this.gbSAP.Controls.Add(this.txtUsuarioBD);
            this.gbSAP.Controls.Add(this.lblUsuarioBD);
            this.gbSAP.Controls.Add(this.cbConfiable);
            this.gbSAP.Controls.Add(this.txtContraseña);
            this.gbSAP.Controls.Add(this.lblContraseña);
            this.gbSAP.Controls.Add(this.txtUsuario);
            this.gbSAP.Controls.Add(this.lblUsuario);
            this.gbSAP.Controls.Add(this.txtServidorLicencias);
            this.gbSAP.Controls.Add(this.lblServidorLicencias);
            this.gbSAP.Controls.Add(this.txtContraseñaBD);
            this.gbSAP.Controls.Add(this.lblContraseñaBD);
            this.gbSAP.Controls.Add(this.txtBD);
            this.gbSAP.Controls.Add(this.lblBD);
            this.gbSAP.Controls.Add(this.cbTipoServidorBD);
            this.gbSAP.Controls.Add(this.lblTipoServidorBD);
            this.gbSAP.Controls.Add(this.txtServidor);
            this.gbSAP.Controls.Add(this.lblServidor);
            this.gbSAP.Location = new System.Drawing.Point(0, 75);
            this.gbSAP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbSAP.Name = "gbSAP";
            this.gbSAP.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbSAP.Size = new System.Drawing.Size(703, 383);
            this.gbSAP.TabIndex = 2;
            this.gbSAP.TabStop = false;
            this.gbSAP.Text = "Configuración SAP Business One";
            // 
            // lblServidor
            // 
            this.lblServidor.Location = new System.Drawing.Point(16, 30);
            this.lblServidor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 17);
            this.lblServidor.TabIndex = 63;
            this.lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(152, 26);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtServidor.MenuManager = this.mainRibbonControl;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(241, 24);
            this.txtServidor.TabIndex = 1;
            // 
            // lblTipoServidorBD
            // 
            this.lblTipoServidorBD.Location = new System.Drawing.Point(16, 132);
            this.lblTipoServidorBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblTipoServidorBD.Name = "lblTipoServidorBD";
            this.lblTipoServidorBD.Size = new System.Drawing.Size(100, 17);
            this.lblTipoServidorBD.TabIndex = 65;
            this.lblTipoServidorBD.Text = "Tipo servidor BD";
            // 
            // cbTipoServidorBD
            // 
            this.cbTipoServidorBD.Location = new System.Drawing.Point(152, 128);
            this.cbTipoServidorBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTipoServidorBD.MenuManager = this.mainRibbonControl;
            this.cbTipoServidorBD.Name = "cbTipoServidorBD";
            this.cbTipoServidorBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoServidorBD.Properties.Items.AddRange(new object[] {
            "MSSQL",
            "DB2",
            "SYBASE",
            "MSSQL 2005",
            "MAXDB",
            "MSSQL 2008",
            "MSSQL 2012",
            "MSSQL 2014",
            "HANADB",
            "MSSQL 2016",
            "MSSQL 2017",
            "MSSQL 2019"});
            this.cbTipoServidorBD.Size = new System.Drawing.Size(241, 24);
            this.cbTipoServidorBD.TabIndex = 3;
            // 
            // lblBD
            // 
            this.lblBD.Location = new System.Drawing.Point(16, 166);
            this.lblBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(84, 17);
            this.lblBD.TabIndex = 68;
            this.lblBD.Text = "Base de datos";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(152, 162);
            this.txtBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBD.MenuManager = this.mainRibbonControl;
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(241, 24);
            this.txtBD.TabIndex = 4;
            // 
            // lblContraseñaBD
            // 
            this.lblContraseñaBD.Location = new System.Drawing.Point(16, 234);
            this.lblContraseñaBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblContraseñaBD.Name = "lblContraseñaBD";
            this.lblContraseñaBD.Size = new System.Drawing.Size(93, 17);
            this.lblContraseñaBD.TabIndex = 70;
            this.lblContraseñaBD.Text = "Contraseña BD";
            // 
            // txtContraseñaBD
            // 
            this.txtContraseñaBD.Location = new System.Drawing.Point(152, 230);
            this.txtContraseñaBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtContraseñaBD.MenuManager = this.mainRibbonControl;
            this.txtContraseñaBD.Name = "txtContraseñaBD";
            this.txtContraseñaBD.Size = new System.Drawing.Size(241, 24);
            this.txtContraseñaBD.TabIndex = 6;
            // 
            // lblServidorLicencias
            // 
            this.lblServidorLicencias.Location = new System.Drawing.Point(16, 98);
            this.lblServidorLicencias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblServidorLicencias.Name = "lblServidorLicencias";
            this.lblServidorLicencias.Size = new System.Drawing.Size(120, 17);
            this.lblServidorLicencias.TabIndex = 72;
            this.lblServidorLicencias.Text = "Servidor de licencias";
            // 
            // txtServidorLicencias
            // 
            this.txtServidorLicencias.Location = new System.Drawing.Point(152, 94);
            this.txtServidorLicencias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtServidorLicencias.MenuManager = this.mainRibbonControl;
            this.txtServidorLicencias.Name = "txtServidorLicencias";
            this.txtServidorLicencias.Size = new System.Drawing.Size(241, 24);
            this.txtServidorLicencias.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(16, 268);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 17);
            this.lblUsuario.TabIndex = 74;
            this.lblUsuario.Text = "Usuario SAP BO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 264);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsuario.MenuManager = this.mainRibbonControl;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 24);
            this.txtUsuario.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Location = new System.Drawing.Point(16, 302);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 17);
            this.lblContraseña.TabIndex = 76;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(152, 298);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtContraseña.MenuManager = this.mainRibbonControl;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(241, 24);
            this.txtContraseña.TabIndex = 8;
            // 
            // cbConfiable
            // 
            this.cbConfiable.Location = new System.Drawing.Point(152, 332);
            this.cbConfiable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbConfiable.MenuManager = this.mainRibbonControl;
            this.cbConfiable.Name = "cbConfiable";
            this.cbConfiable.Properties.Caption = "Uso confiado";
            this.cbConfiable.Size = new System.Drawing.Size(135, 21);
            this.cbConfiable.TabIndex = 9;
            // 
            // lblUsuarioBD
            // 
            this.lblUsuarioBD.Location = new System.Drawing.Point(16, 200);
            this.lblUsuarioBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblUsuarioBD.Name = "lblUsuarioBD";
            this.lblUsuarioBD.Size = new System.Drawing.Size(69, 17);
            this.lblUsuarioBD.TabIndex = 79;
            this.lblUsuarioBD.Text = "Usuario BD";
            // 
            // txtUsuarioBD
            // 
            this.txtUsuarioBD.Location = new System.Drawing.Point(152, 196);
            this.txtUsuarioBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsuarioBD.MenuManager = this.mainRibbonControl;
            this.txtUsuarioBD.Name = "txtUsuarioBD";
            this.txtUsuarioBD.Size = new System.Drawing.Size(241, 24);
            this.txtUsuarioBD.TabIndex = 5;
            // 
            // gcOpciones
            // 
            this.gcOpciones.Controls.Add(this.cbInventarioSAP);
            this.gcOpciones.Controls.Add(this.cbFacturarEntregas);
            this.gcOpciones.Controls.Add(this.txtSAPAPIURL);
            this.gcOpciones.Controls.Add(this.lblSAPAPIURL);
            this.gcOpciones.Controls.Add(this.txtNumeroCuentaAjusteInventario);
            this.gcOpciones.Controls.Add(this.teHoraSincronizacionGenerales);
            this.gcOpciones.Controls.Add(this.lblHoraSicronizacionGeneral);
            this.gcOpciones.Controls.Add(this.cbGenerarAjusteInventario);
            this.gcOpciones.Location = new System.Drawing.Point(405, 25);
            this.gcOpciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcOpciones.Name = "gcOpciones";
            this.gcOpciones.Size = new System.Drawing.Size(290, 298);
            this.gcOpciones.TabIndex = 82;
            this.gcOpciones.Text = "Opciones";
            this.gcOpciones.Visible = false;
            // 
            // cbGenerarAjusteInventario
            // 
            this.cbGenerarAjusteInventario.Location = new System.Drawing.Point(15, 37);
            this.cbGenerarAjusteInventario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbGenerarAjusteInventario.MenuManager = this.mainRibbonControl;
            this.cbGenerarAjusteInventario.Name = "cbGenerarAjusteInventario";
            this.cbGenerarAjusteInventario.Properties.Caption = "Generar ajuste inventario";
            this.cbGenerarAjusteInventario.Size = new System.Drawing.Size(264, 21);
            this.cbGenerarAjusteInventario.TabIndex = 10;
            // 
            // lblHoraSicronizacionGeneral
            // 
            this.lblHoraSicronizacionGeneral.Location = new System.Drawing.Point(110, 242);
            this.lblHoraSicronizacionGeneral.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblHoraSicronizacionGeneral.Name = "lblHoraSicronizacionGeneral";
            this.lblHoraSicronizacionGeneral.Size = new System.Drawing.Size(159, 17);
            this.lblHoraSicronizacionGeneral.TabIndex = 81;
            this.lblHoraSicronizacionGeneral.Text = "Sincronizar generales a las";
            // 
            // teHoraSincronizacionGenerales
            // 
            this.teHoraSincronizacionGenerales.EditValue = new System.DateTime(2017, 4, 6, 0, 0, 0, 0);
            this.teHoraSincronizacionGenerales.Location = new System.Drawing.Point(110, 265);
            this.teHoraSincronizacionGenerales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.teHoraSincronizacionGenerales.MenuManager = this.mainRibbonControl;
            this.teHoraSincronizacionGenerales.Name = "teHoraSincronizacionGenerales";
            this.teHoraSincronizacionGenerales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teHoraSincronizacionGenerales.Size = new System.Drawing.Size(169, 24);
            this.teHoraSincronizacionGenerales.TabIndex = 10;
            // 
            // txtNumeroCuentaAjusteInventario
            // 
            this.txtNumeroCuentaAjusteInventario.Location = new System.Drawing.Point(15, 69);
            this.txtNumeroCuentaAjusteInventario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumeroCuentaAjusteInventario.MenuManager = this.mainRibbonControl;
            this.txtNumeroCuentaAjusteInventario.Name = "txtNumeroCuentaAjusteInventario";
            this.txtNumeroCuentaAjusteInventario.Properties.MaxLength = 15;
            this.txtNumeroCuentaAjusteInventario.Properties.NullValuePrompt = "Cuenta ajustes de inventario";
            this.txtNumeroCuentaAjusteInventario.Size = new System.Drawing.Size(264, 24);
            this.txtNumeroCuentaAjusteInventario.TabIndex = 11;
            // 
            // lblSAPAPIURL
            // 
            this.lblSAPAPIURL.Location = new System.Drawing.Point(15, 107);
            this.lblSAPAPIURL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblSAPAPIURL.Name = "lblSAPAPIURL";
            this.lblSAPAPIURL.Size = new System.Drawing.Size(53, 17);
            this.lblSAPAPIURL.TabIndex = 83;
            this.lblSAPAPIURL.Text = "API URL";
            // 
            // txtSAPAPIURL
            // 
            this.txtSAPAPIURL.Location = new System.Drawing.Point(15, 132);
            this.txtSAPAPIURL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSAPAPIURL.MenuManager = this.mainRibbonControl;
            this.txtSAPAPIURL.Name = "txtSAPAPIURL";
            this.txtSAPAPIURL.Properties.MaxLength = 254;
            this.txtSAPAPIURL.Size = new System.Drawing.Size(264, 24);
            this.txtSAPAPIURL.TabIndex = 12;
            // 
            // cbFacturarEntregas
            // 
            this.cbFacturarEntregas.Location = new System.Drawing.Point(15, 166);
            this.cbFacturarEntregas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFacturarEntregas.MenuManager = this.mainRibbonControl;
            this.cbFacturarEntregas.Name = "cbFacturarEntregas";
            this.cbFacturarEntregas.Properties.Caption = "Facturar entregas";
            this.cbFacturarEntregas.Size = new System.Drawing.Size(264, 21);
            this.cbFacturarEntregas.TabIndex = 84;
            // 
            // cbInventarioSAP
            // 
            this.cbInventarioSAP.Location = new System.Drawing.Point(15, 199);
            this.cbInventarioSAP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbInventarioSAP.MenuManager = this.mainRibbonControl;
            this.cbInventarioSAP.Name = "cbInventarioSAP";
            this.cbInventarioSAP.Properties.Caption = "Inventario en vivo SAP B1";
            this.cbInventarioSAP.Size = new System.Drawing.Size(200, 21);
            this.cbInventarioSAP.TabIndex = 3;
            // 
            // txtFuenteDatos
            // 
            this.txtFuenteDatos.Location = new System.Drawing.Point(152, 60);
            this.txtFuenteDatos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFuenteDatos.MenuManager = this.mainRibbonControl;
            this.txtFuenteDatos.Name = "txtFuenteDatos";
            this.txtFuenteDatos.Size = new System.Drawing.Size(241, 24);
            this.txtFuenteDatos.TabIndex = 83;
            // 
            // lblFuenteDatos
            // 
            this.lblFuenteDatos.Location = new System.Drawing.Point(16, 65);
            this.lblFuenteDatos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblFuenteDatos.Name = "lblFuenteDatos";
            this.lblFuenteDatos.Size = new System.Drawing.Size(99, 17);
            this.lblFuenteDatos.TabIndex = 84;
            this.lblFuenteDatos.Text = "Fuente de datos";
            // 
            // lblSucursales
            // 
            this.lblSucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSucursales.Location = new System.Drawing.Point(615, 8);
            this.lblSucursales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(60, 17);
            this.lblSucursales.TabIndex = 0;
            this.lblSucursales.Text = "Sucursales";
            this.lblSucursales.Click += new System.EventHandler(this.lblSucursales_Click_1);
            // 
            // tabNavigationPageTimbrado
            // 
            this.tabNavigationPageTimbrado.Caption = "Timbrado";
            this.tabNavigationPageTimbrado.Controls.Add(this.cbPedimentos);
            this.tabNavigationPageTimbrado.Controls.Add(this.cbPAC);
            this.tabNavigationPageTimbrado.Controls.Add(this.lblPAC);
            this.tabNavigationPageTimbrado.Controls.Add(this.lblTimbradoUsuario);
            this.tabNavigationPageTimbrado.Controls.Add(this.lblTimbradoContraseña);
            this.tabNavigationPageTimbrado.Controls.Add(this.cbCertificados);
            this.tabNavigationPageTimbrado.Controls.Add(this.lblCertificado);
            this.tabNavigationPageTimbrado.Controls.Add(this.btnCertificados);
            this.tabNavigationPageTimbrado.Controls.Add(this.cbTimbradoModoPrueba);
            this.tabNavigationPageTimbrado.Controls.Add(this.cbGenerarTimbradoSinDescuento);
            this.tabNavigationPageTimbrado.Controls.Add(this.txtTimbradoContraseña);
            this.tabNavigationPageTimbrado.Controls.Add(this.txtTimbradoUsuario);
            this.tabNavigationPageTimbrado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabNavigationPageTimbrado.Name = "tabNavigationPageTimbrado";
            this.tabNavigationPageTimbrado.Size = new System.Drawing.Size(750, 504);
            // 
            // txtTimbradoUsuario
            // 
            this.txtTimbradoUsuario.Location = new System.Drawing.Point(142, 75);
            this.txtTimbradoUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimbradoUsuario.MenuManager = this.mainRibbonControl;
            this.txtTimbradoUsuario.Name = "txtTimbradoUsuario";
            this.txtTimbradoUsuario.Properties.NullValuePrompt = "Usuario servicio de timbrado";
            this.txtTimbradoUsuario.Size = new System.Drawing.Size(322, 24);
            this.txtTimbradoUsuario.TabIndex = 2;
            // 
            // txtTimbradoContraseña
            // 
            this.txtTimbradoContraseña.Location = new System.Drawing.Point(142, 109);
            this.txtTimbradoContraseña.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimbradoContraseña.MenuManager = this.mainRibbonControl;
            this.txtTimbradoContraseña.Name = "txtTimbradoContraseña";
            this.txtTimbradoContraseña.Properties.NullValuePrompt = "Contraseña servicio de timbrado";
            this.txtTimbradoContraseña.Properties.PasswordChar = '*';
            this.txtTimbradoContraseña.Size = new System.Drawing.Size(322, 24);
            this.txtTimbradoContraseña.TabIndex = 3;
            // 
            // cbGenerarTimbradoSinDescuento
            // 
            this.cbGenerarTimbradoSinDescuento.Location = new System.Drawing.Point(142, 169);
            this.cbGenerarTimbradoSinDescuento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbGenerarTimbradoSinDescuento.MenuManager = this.mainRibbonControl;
            this.cbGenerarTimbradoSinDescuento.Name = "cbGenerarTimbradoSinDescuento";
            this.cbGenerarTimbradoSinDescuento.Properties.Caption = "Timbrar sin descuentos";
            this.cbGenerarTimbradoSinDescuento.Size = new System.Drawing.Size(322, 21);
            this.cbGenerarTimbradoSinDescuento.TabIndex = 5;
            // 
            // cbTimbradoModoPrueba
            // 
            this.cbTimbradoModoPrueba.Location = new System.Drawing.Point(142, 143);
            this.cbTimbradoModoPrueba.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTimbradoModoPrueba.MenuManager = this.mainRibbonControl;
            this.cbTimbradoModoPrueba.Name = "cbTimbradoModoPrueba";
            this.cbTimbradoModoPrueba.Properties.Caption = "Timbrar en modo de prueba";
            this.cbTimbradoModoPrueba.Size = new System.Drawing.Size(322, 21);
            this.cbTimbradoModoPrueba.TabIndex = 4;
            // 
            // btnCertificados
            // 
            this.btnCertificados.Location = new System.Drawing.Point(273, 245);
            this.btnCertificados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCertificados.Name = "btnCertificados";
            this.btnCertificados.Size = new System.Drawing.Size(191, 30);
            this.btnCertificados.TabIndex = 5;
            this.btnCertificados.TabStop = false;
            this.btnCertificados.Text = "Administrar certificados";
            // 
            // lblCertificado
            // 
            this.lblCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCertificado.Location = new System.Drawing.Point(6, 10);
            this.lblCertificado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(128, 17);
            this.lblCertificado.TabIndex = 79;
            this.lblCertificado.Text = "Certificado timbrado";
            this.lblCertificado.Click += new System.EventHandler(this.lblCertificado_Click);
            // 
            // cbCertificados
            // 
            this.cbCertificados.Location = new System.Drawing.Point(142, 7);
            this.cbCertificados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCertificados.MenuManager = this.mainRibbonControl;
            this.cbCertificados.Name = "cbCertificados";
            this.cbCertificados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCertificados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCertificados.Size = new System.Drawing.Size(322, 24);
            this.cbCertificados.TabIndex = 0;
            // 
            // lblTimbradoContraseña
            // 
            this.lblTimbradoContraseña.Location = new System.Drawing.Point(6, 112);
            this.lblTimbradoContraseña.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblTimbradoContraseña.Name = "lblTimbradoContraseña";
            this.lblTimbradoContraseña.Size = new System.Drawing.Size(70, 17);
            this.lblTimbradoContraseña.TabIndex = 80;
            this.lblTimbradoContraseña.Text = "Contraseña";
            // 
            // lblTimbradoUsuario
            // 
            this.lblTimbradoUsuario.Location = new System.Drawing.Point(6, 78);
            this.lblTimbradoUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblTimbradoUsuario.Name = "lblTimbradoUsuario";
            this.lblTimbradoUsuario.Size = new System.Drawing.Size(46, 17);
            this.lblTimbradoUsuario.TabIndex = 81;
            this.lblTimbradoUsuario.Text = "Usuario";
            // 
            // lblPAC
            // 
            this.lblPAC.Location = new System.Drawing.Point(6, 44);
            this.lblPAC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPAC.Name = "lblPAC";
            this.lblPAC.Size = new System.Drawing.Size(28, 17);
            this.lblPAC.TabIndex = 83;
            this.lblPAC.Text = "PAC";
            // 
            // cbPAC
            // 
            this.cbPAC.EditValue = "Edicom";
            this.cbPAC.Location = new System.Drawing.Point(142, 41);
            this.cbPAC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbPAC.MenuManager = this.mainRibbonControl;
            this.cbPAC.Name = "cbPAC";
            this.cbPAC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPAC.Properties.Items.AddRange(new object[] {
            "Edicom",
            "Solución Factible",
            "ISI"});
            this.cbPAC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPAC.Size = new System.Drawing.Size(322, 24);
            this.cbPAC.TabIndex = 1;
            // 
            // cbPedimentos
            // 
            this.cbPedimentos.Location = new System.Drawing.Point(142, 213);
            this.cbPedimentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbPedimentos.MenuManager = this.mainRibbonControl;
            this.cbPedimentos.Name = "cbPedimentos";
            this.cbPedimentos.Properties.Caption = "Pedimentos";
            this.cbPedimentos.Size = new System.Drawing.Size(322, 21);
            this.cbPedimentos.TabIndex = 84;
            // 
            // tabNavigationPageDirectorios
            // 
            this.tabNavigationPageDirectorios.Caption = "Directorios";
            this.tabNavigationPageDirectorios.Controls.Add(this.txtDirectorioAnexos);
            this.tabNavigationPageDirectorios.Controls.Add(this.lblDirectorioAnexos);
            this.tabNavigationPageDirectorios.Controls.Add(this.txtDirectorioInformes);
            this.tabNavigationPageDirectorios.Controls.Add(this.lblDirectorioInformes);
            this.tabNavigationPageDirectorios.Controls.Add(this.txtDirectorioXML);
            this.tabNavigationPageDirectorios.Controls.Add(this.lblDirectorioXML);
            this.tabNavigationPageDirectorios.Controls.Add(this.txtDirectorioImagenes);
            this.tabNavigationPageDirectorios.Controls.Add(this.lblDirectorioImagenes);
            this.tabNavigationPageDirectorios.Controls.Add(this.txtDirectorioDocumentos);
            this.tabNavigationPageDirectorios.Controls.Add(this.lblDirectorioDocumentos);
            this.tabNavigationPageDirectorios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabNavigationPageDirectorios.Name = "tabNavigationPageDirectorios";
            this.tabNavigationPageDirectorios.Size = new System.Drawing.Size(750, 504);
            // 
            // lblDirectorioDocumentos
            // 
            this.lblDirectorioDocumentos.Location = new System.Drawing.Point(6, 44);
            this.lblDirectorioDocumentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDirectorioDocumentos.Name = "lblDirectorioDocumentos";
            this.lblDirectorioDocumentos.Size = new System.Drawing.Size(103, 17);
            this.lblDirectorioDocumentos.TabIndex = 61;
            this.lblDirectorioDocumentos.Text = "Directorio doctos";
            // 
            // txtDirectorioDocumentos
            // 
            this.txtDirectorioDocumentos.Location = new System.Drawing.Point(142, 41);
            this.txtDirectorioDocumentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDirectorioDocumentos.MenuManager = this.mainRibbonControl;
            this.txtDirectorioDocumentos.Name = "txtDirectorioDocumentos";
            this.txtDirectorioDocumentos.Properties.MaxLength = 254;
            this.txtDirectorioDocumentos.Size = new System.Drawing.Size(561, 24);
            this.txtDirectorioDocumentos.TabIndex = 1;
            // 
            // lblDirectorioImagenes
            // 
            this.lblDirectorioImagenes.Location = new System.Drawing.Point(6, 78);
            this.lblDirectorioImagenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDirectorioImagenes.Name = "lblDirectorioImagenes";
            this.lblDirectorioImagenes.Size = new System.Drawing.Size(122, 17);
            this.lblDirectorioImagenes.TabIndex = 65;
            this.lblDirectorioImagenes.Text = "Directorio imágenes";
            // 
            // txtDirectorioImagenes
            // 
            this.txtDirectorioImagenes.Location = new System.Drawing.Point(142, 75);
            this.txtDirectorioImagenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDirectorioImagenes.MenuManager = this.mainRibbonControl;
            this.txtDirectorioImagenes.Name = "txtDirectorioImagenes";
            this.txtDirectorioImagenes.Properties.MaxLength = 254;
            this.txtDirectorioImagenes.Size = new System.Drawing.Size(561, 24);
            this.txtDirectorioImagenes.TabIndex = 2;
            // 
            // lblDirectorioXML
            // 
            this.lblDirectorioXML.Location = new System.Drawing.Point(6, 112);
            this.lblDirectorioXML.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDirectorioXML.Name = "lblDirectorioXML";
            this.lblDirectorioXML.Size = new System.Drawing.Size(93, 17);
            this.lblDirectorioXML.TabIndex = 67;
            this.lblDirectorioXML.Text = "Directorio XML";
            // 
            // txtDirectorioXML
            // 
            this.txtDirectorioXML.Location = new System.Drawing.Point(142, 109);
            this.txtDirectorioXML.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDirectorioXML.MenuManager = this.mainRibbonControl;
            this.txtDirectorioXML.Name = "txtDirectorioXML";
            this.txtDirectorioXML.Properties.MaxLength = 254;
            this.txtDirectorioXML.Size = new System.Drawing.Size(561, 24);
            this.txtDirectorioXML.TabIndex = 3;
            // 
            // lblDirectorioInformes
            // 
            this.lblDirectorioInformes.Location = new System.Drawing.Point(6, 10);
            this.lblDirectorioInformes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDirectorioInformes.Name = "lblDirectorioInformes";
            this.lblDirectorioInformes.Size = new System.Drawing.Size(116, 17);
            this.lblDirectorioInformes.TabIndex = 73;
            this.lblDirectorioInformes.Text = "Directorio informes";
            // 
            // txtDirectorioInformes
            // 
            this.txtDirectorioInformes.Location = new System.Drawing.Point(142, 7);
            this.txtDirectorioInformes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDirectorioInformes.MenuManager = this.mainRibbonControl;
            this.txtDirectorioInformes.Name = "txtDirectorioInformes";
            this.txtDirectorioInformes.Properties.MaxLength = 254;
            this.txtDirectorioInformes.Size = new System.Drawing.Size(561, 24);
            this.txtDirectorioInformes.TabIndex = 0;
            // 
            // lblDirectorioAnexos
            // 
            this.lblDirectorioAnexos.Location = new System.Drawing.Point(3, 147);
            this.lblDirectorioAnexos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDirectorioAnexos.Name = "lblDirectorioAnexos";
            this.lblDirectorioAnexos.Size = new System.Drawing.Size(106, 17);
            this.lblDirectorioAnexos.TabIndex = 75;
            this.lblDirectorioAnexos.Text = "Directorio anexos";
            // 
            // txtDirectorioAnexos
            // 
            this.txtDirectorioAnexos.Location = new System.Drawing.Point(142, 144);
            this.txtDirectorioAnexos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDirectorioAnexos.MenuManager = this.mainRibbonControl;
            this.txtDirectorioAnexos.Name = "txtDirectorioAnexos";
            this.txtDirectorioAnexos.Properties.MaxLength = 254;
            this.txtDirectorioAnexos.Size = new System.Drawing.Size(561, 24);
            this.txtDirectorioAnexos.TabIndex = 74;
            // 
            // tabNavigationPagePredeterminados
            // 
            this.tabNavigationPagePredeterminados.Caption = "Predeterminados";
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbDiasSemana);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblDiaSemana);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbImpuestos);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblImpuesto);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbDepartamentos);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblDepartamentos);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbZonas);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblZonas);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbCondicionesPago);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblCondicionesPago);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbMetodosPago);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblMetodoPago);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblFabricantes);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbFabricantes);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbMonedas);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblMonedas);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbListasPrecios);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblListaPrecios);
            this.tabNavigationPagePredeterminados.Controls.Add(this.cbGruposArticulos);
            this.tabNavigationPagePredeterminados.Controls.Add(this.lblGrupoArticulos);
            this.tabNavigationPagePredeterminados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabNavigationPagePredeterminados.Name = "tabNavigationPagePredeterminados";
            this.tabNavigationPagePredeterminados.Size = new System.Drawing.Size(750, 504);
            // 
            // lblGrupoArticulos
            // 
            this.lblGrupoArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGrupoArticulos.Location = new System.Drawing.Point(6, 114);
            this.lblGrupoArticulos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblGrupoArticulos.Name = "lblGrupoArticulos";
            this.lblGrupoArticulos.Size = new System.Drawing.Size(112, 17);
            this.lblGrupoArticulos.TabIndex = 54;
            this.lblGrupoArticulos.Text = "Grupo de artículos";
            this.lblGrupoArticulos.Click += new System.EventHandler(this.lblGrupoArticulos_Click);
            // 
            // cbGruposArticulos
            // 
            this.cbGruposArticulos.Location = new System.Drawing.Point(142, 110);
            this.cbGruposArticulos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbGruposArticulos.MenuManager = this.mainRibbonControl;
            this.cbGruposArticulos.Name = "cbGruposArticulos";
            this.cbGruposArticulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGruposArticulos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbGruposArticulos.Size = new System.Drawing.Size(561, 24);
            this.cbGruposArticulos.TabIndex = 3;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaPrecios.Location = new System.Drawing.Point(6, 182);
            this.lblListaPrecios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(92, 17);
            this.lblListaPrecios.TabIndex = 55;
            this.lblListaPrecios.Text = "Lista de precios";
            this.lblListaPrecios.Click += new System.EventHandler(this.lblListaPrecios_Click);
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.Location = new System.Drawing.Point(142, 178);
            this.cbListasPrecios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbListasPrecios.MenuManager = this.mainRibbonControl;
            this.cbListasPrecios.Name = "cbListasPrecios";
            this.cbListasPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Size = new System.Drawing.Size(561, 24);
            this.cbListasPrecios.TabIndex = 5;
            // 
            // lblMonedas
            // 
            this.lblMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonedas.Location = new System.Drawing.Point(6, 250);
            this.lblMonedas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblMonedas.Name = "lblMonedas";
            this.lblMonedas.Size = new System.Drawing.Size(51, 17);
            this.lblMonedas.TabIndex = 56;
            this.lblMonedas.Text = "Moneda";
            this.lblMonedas.Click += new System.EventHandler(this.lblMonedas_Click);
            // 
            // cbMonedas
            // 
            this.cbMonedas.Location = new System.Drawing.Point(142, 246);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMonedas.MenuManager = this.mainRibbonControl;
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Size = new System.Drawing.Size(561, 24);
            this.cbMonedas.TabIndex = 7;
            // 
            // cbFabricantes
            // 
            this.cbFabricantes.Location = new System.Drawing.Point(142, 76);
            this.cbFabricantes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFabricantes.MenuManager = this.mainRibbonControl;
            this.cbFabricantes.Name = "cbFabricantes";
            this.cbFabricantes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFabricantes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbFabricantes.Size = new System.Drawing.Size(561, 24);
            this.cbFabricantes.TabIndex = 2;
            // 
            // lblFabricantes
            // 
            this.lblFabricantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFabricantes.Location = new System.Drawing.Point(6, 80);
            this.lblFabricantes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblFabricantes.Name = "lblFabricantes";
            this.lblFabricantes.Size = new System.Drawing.Size(66, 17);
            this.lblFabricantes.TabIndex = 57;
            this.lblFabricantes.Text = "Fabricante";
            this.lblFabricantes.Click += new System.EventHandler(this.lblFabricantes_Click);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetodoPago.Location = new System.Drawing.Point(6, 216);
            this.lblMetodoPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(103, 17);
            this.lblMetodoPago.TabIndex = 61;
            this.lblMetodoPago.Text = "Método de pago";
            this.lblMetodoPago.Click += new System.EventHandler(this.lblMetodoPago_Click);
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Location = new System.Drawing.Point(142, 212);
            this.cbMetodosPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMetodosPago.MenuManager = this.mainRibbonControl;
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Size = new System.Drawing.Size(561, 24);
            this.cbMetodosPago.TabIndex = 6;
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCondicionesPago.Location = new System.Drawing.Point(6, 12);
            this.lblCondicionesPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(127, 17);
            this.lblCondicionesPago.TabIndex = 63;
            this.lblCondicionesPago.Text = "Condiciones de pago";
            this.lblCondicionesPago.Click += new System.EventHandler(this.lblCondicionesPago_Click);
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(142, 8);
            this.cbCondicionesPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCondicionesPago.MenuManager = this.mainRibbonControl;
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Size = new System.Drawing.Size(561, 24);
            this.cbCondicionesPago.TabIndex = 0;
            // 
            // lblZonas
            // 
            this.lblZonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblZonas.Location = new System.Drawing.Point(6, 281);
            this.lblZonas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblZonas.Name = "lblZonas";
            this.lblZonas.Size = new System.Drawing.Size(32, 17);
            this.lblZonas.TabIndex = 69;
            this.lblZonas.Text = "Zona";
            this.lblZonas.Click += new System.EventHandler(this.lblZonas_Click);
            // 
            // cbZonas
            // 
            this.cbZonas.Location = new System.Drawing.Point(142, 280);
            this.cbZonas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbZonas.MenuManager = this.mainRibbonControl;
            this.cbZonas.Name = "cbZonas";
            this.cbZonas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbZonas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbZonas.Size = new System.Drawing.Size(561, 24);
            this.cbZonas.TabIndex = 8;
            // 
            // lblDepartamentos
            // 
            this.lblDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDepartamentos.Location = new System.Drawing.Point(6, 46);
            this.lblDepartamentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDepartamentos.Name = "lblDepartamentos";
            this.lblDepartamentos.Size = new System.Drawing.Size(92, 17);
            this.lblDepartamentos.TabIndex = 71;
            this.lblDepartamentos.Text = "Departamento";
            this.lblDepartamentos.Click += new System.EventHandler(this.lblDepartamentos_Click);
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.Location = new System.Drawing.Point(142, 42);
            this.cbDepartamentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbDepartamentos.MenuManager = this.mainRibbonControl;
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDepartamentos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbDepartamentos.Size = new System.Drawing.Size(561, 24);
            this.cbDepartamentos.TabIndex = 1;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImpuesto.Location = new System.Drawing.Point(6, 148);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(56, 17);
            this.lblImpuesto.TabIndex = 75;
            this.lblImpuesto.Text = "Impuesto";
            this.lblImpuesto.Click += new System.EventHandler(this.lblImpuesto_Click);
            // 
            // cbImpuestos
            // 
            this.cbImpuestos.Location = new System.Drawing.Point(142, 144);
            this.cbImpuestos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbImpuestos.MenuManager = this.mainRibbonControl;
            this.cbImpuestos.Name = "cbImpuestos";
            this.cbImpuestos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpuestos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbImpuestos.Size = new System.Drawing.Size(561, 24);
            this.cbImpuestos.TabIndex = 4;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(5, 318);
            this.lblDiaSemana.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(81, 17);
            this.lblDiaSemana.TabIndex = 76;
            this.lblDiaSemana.Text = "Día semana";
            // 
            // cbDiasSemana
            // 
            this.cbDiasSemana.Location = new System.Drawing.Point(142, 314);
            this.cbDiasSemana.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbDiasSemana.MenuManager = this.mainRibbonControl;
            this.cbDiasSemana.Name = "cbDiasSemana";
            this.cbDiasSemana.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDiasSemana.Properties.Items.AddRange(new object[] {
            "Domingo",
            "Lunes",
            "Martes",
            "Míercoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cbDiasSemana.Size = new System.Drawing.Size(134, 24);
            this.cbDiasSemana.TabIndex = 78;
            // 
            // tabNavigationPageGeneral
            // 
            this.tabNavigationPageGeneral.Caption = "General";
            this.tabNavigationPageGeneral.Controls.Add(this.cbListaPrecioSegunUsuario);
            this.tabNavigationPageGeneral.Controls.Add(this.cbVentaArticuloMenorCosto);
            this.tabNavigationPageGeneral.Controls.Add(this.cbDocumentosModoNuevo);
            this.tabNavigationPageGeneral.Controls.Add(this.cbVendedorSegunEstacion);
            this.tabNavigationPageGeneral.Controls.Add(this.cbVendedorSegunUsuario);
            this.tabNavigationPageGeneral.Controls.Add(this.cbAgruparPartidas);
            this.tabNavigationPageGeneral.Controls.Add(this.cbVentaArticuloStockCero);
            this.tabNavigationPageGeneral.Controls.Add(this.cbDocumentoBorrador);
            this.tabNavigationPageGeneral.Controls.Add(this.cbGenerarDocumentoElectronicoAutomaticamente);
            this.tabNavigationPageGeneral.Controls.Add(this.cbVentaArticuloPrecioCero);
            this.tabNavigationPageGeneral.Controls.Add(this.cbFormularioPanel);
            this.tabNavigationPageGeneral.Controls.Add(this.lblFechaActualizacion);
            this.tabNavigationPageGeneral.Controls.Add(this.lblUltimaActualizacion);
            this.tabNavigationPageGeneral.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabNavigationPageGeneral.Name = "tabNavigationPageGeneral";
            this.tabNavigationPageGeneral.Size = new System.Drawing.Size(750, 504);
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(442, 417);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 64;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(625, 417);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 65;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // cbFormularioPanel
            // 
            this.cbFormularioPanel.Location = new System.Drawing.Point(5, 4);
            this.cbFormularioPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFormularioPanel.MenuManager = this.mainRibbonControl;
            this.cbFormularioPanel.Name = "cbFormularioPanel";
            this.cbFormularioPanel.Properties.Caption = "Abrir formularios del menu principal como páneles";
            this.cbFormularioPanel.Size = new System.Drawing.Size(346, 21);
            this.cbFormularioPanel.TabIndex = 0;
            // 
            // cbVentaArticuloPrecioCero
            // 
            this.cbVentaArticuloPrecioCero.Location = new System.Drawing.Point(5, 37);
            this.cbVentaArticuloPrecioCero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVentaArticuloPrecioCero.MenuManager = this.mainRibbonControl;
            this.cbVentaArticuloPrecioCero.Name = "cbVentaArticuloPrecioCero";
            this.cbVentaArticuloPrecioCero.Properties.Caption = "Permitir venta de artículos con precio <= 0";
            this.cbVentaArticuloPrecioCero.Size = new System.Drawing.Size(346, 21);
            this.cbVentaArticuloPrecioCero.TabIndex = 1;
            // 
            // cbGenerarDocumentoElectronicoAutomaticamente
            // 
            this.cbGenerarDocumentoElectronicoAutomaticamente.Location = new System.Drawing.Point(5, 292);
            this.cbGenerarDocumentoElectronicoAutomaticamente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbGenerarDocumentoElectronicoAutomaticamente.MenuManager = this.mainRibbonControl;
            this.cbGenerarDocumentoElectronicoAutomaticamente.Name = "cbGenerarDocumentoElectronicoAutomaticamente";
            this.cbGenerarDocumentoElectronicoAutomaticamente.Properties.Caption = "Generar documento electrónico automáticamente";
            this.cbGenerarDocumentoElectronicoAutomaticamente.Size = new System.Drawing.Size(346, 21);
            this.cbGenerarDocumentoElectronicoAutomaticamente.TabIndex = 5;
            // 
            // cbDocumentoBorrador
            // 
            this.cbDocumentoBorrador.Location = new System.Drawing.Point(5, 136);
            this.cbDocumentoBorrador.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbDocumentoBorrador.MenuManager = this.mainRibbonControl;
            this.cbDocumentoBorrador.Name = "cbDocumentoBorrador";
            this.cbDocumentoBorrador.Properties.Caption = "Permitir guardar documento como borrador";
            this.cbDocumentoBorrador.Size = new System.Drawing.Size(346, 21);
            this.cbDocumentoBorrador.TabIndex = 2;
            // 
            // cbVentaArticuloStockCero
            // 
            this.cbVentaArticuloStockCero.Location = new System.Drawing.Point(5, 103);
            this.cbVentaArticuloStockCero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVentaArticuloStockCero.MenuManager = this.mainRibbonControl;
            this.cbVentaArticuloStockCero.Name = "cbVentaArticuloStockCero";
            this.cbVentaArticuloStockCero.Properties.Caption = "Permitir venta de artículos con stock <= 0";
            this.cbVentaArticuloStockCero.Size = new System.Drawing.Size(346, 21);
            this.cbVentaArticuloStockCero.TabIndex = 77;
            // 
            // cbAgruparPartidas
            // 
            this.cbAgruparPartidas.Location = new System.Drawing.Point(5, 169);
            this.cbAgruparPartidas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbAgruparPartidas.MenuManager = this.mainRibbonControl;
            this.cbAgruparPartidas.Name = "cbAgruparPartidas";
            this.cbAgruparPartidas.Properties.Caption = "Permitir agrupación de partidas del mismo artículo";
            this.cbAgruparPartidas.Size = new System.Drawing.Size(346, 21);
            this.cbAgruparPartidas.TabIndex = 3;
            // 
            // cbVendedorSegunUsuario
            // 
            this.cbVendedorSegunUsuario.Location = new System.Drawing.Point(5, 201);
            this.cbVendedorSegunUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVendedorSegunUsuario.MenuManager = this.mainRibbonControl;
            this.cbVendedorSegunUsuario.Name = "cbVendedorSegunUsuario";
            this.cbVendedorSegunUsuario.Properties.Caption = "Asignar a los documentos el vendedor según el usuario";
            this.cbVendedorSegunUsuario.Size = new System.Drawing.Size(385, 21);
            this.cbVendedorSegunUsuario.TabIndex = 4;
            // 
            // cbVendedorSegunEstacion
            // 
            this.cbVendedorSegunEstacion.Location = new System.Drawing.Point(5, 231);
            this.cbVendedorSegunEstacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVendedorSegunEstacion.MenuManager = this.mainRibbonControl;
            this.cbVendedorSegunEstacion.Name = "cbVendedorSegunEstacion";
            this.cbVendedorSegunEstacion.Properties.Caption = "Asignar a los documentos el vendedor según el último utilizado en la estación";
            this.cbVendedorSegunEstacion.Size = new System.Drawing.Size(527, 21);
            this.cbVendedorSegunEstacion.TabIndex = 78;
            // 
            // cbDocumentosModoNuevo
            // 
            this.cbDocumentosModoNuevo.Location = new System.Drawing.Point(5, 262);
            this.cbDocumentosModoNuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbDocumentosModoNuevo.MenuManager = this.mainRibbonControl;
            this.cbDocumentosModoNuevo.Name = "cbDocumentosModoNuevo";
            this.cbDocumentosModoNuevo.Properties.Caption = "Empezar la ventana de documentos como nuevo (creación)";
            this.cbDocumentosModoNuevo.Size = new System.Drawing.Size(426, 21);
            this.cbDocumentosModoNuevo.TabIndex = 79;
            // 
            // cbVentaArticuloMenorCosto
            // 
            this.cbVentaArticuloMenorCosto.Location = new System.Drawing.Point(5, 71);
            this.cbVentaArticuloMenorCosto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVentaArticuloMenorCosto.MenuManager = this.mainRibbonControl;
            this.cbVentaArticuloMenorCosto.Name = "cbVentaArticuloMenorCosto";
            this.cbVentaArticuloMenorCosto.Properties.Caption = "Permitir venta de artículos con precio menor al costo";
            this.cbVentaArticuloMenorCosto.Size = new System.Drawing.Size(383, 21);
            this.cbVentaArticuloMenorCosto.TabIndex = 80;
            // 
            // cbListaPrecioSegunUsuario
            // 
            this.cbListaPrecioSegunUsuario.Location = new System.Drawing.Point(400, 6);
            this.cbListaPrecioSegunUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbListaPrecioSegunUsuario.MenuManager = this.mainRibbonControl;
            this.cbListaPrecioSegunUsuario.Name = "cbListaPrecioSegunUsuario";
            this.cbListaPrecioSegunUsuario.Properties.Caption = "Asignar lista precio a socio según el usuario";
            this.cbListaPrecioSegunUsuario.Size = new System.Drawing.Size(305, 21);
            this.cbListaPrecioSegunUsuario.TabIndex = 81;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPageGeneral);
            this.tabPane1.Controls.Add(this.tabNavigationPageDirectorios);
            this.tabPane1.Controls.Add(this.tabNavigationPageSAP);
            this.tabPane1.Controls.Add(this.tabNavigationPagePredeterminados);
            this.tabPane1.Controls.Add(this.tabNavigationPageTimbrado);
            this.tabPane1.Controls.Add(this.tabNavigationPageNetSuite);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageGeneral,
            this.tabNavigationPagePredeterminados,
            this.tabNavigationPageDirectorios,
            this.tabNavigationPageTimbrado,
            this.tabNavigationPageSAP,
            this.tabNavigationPageNetSuite});
            this.tabPane1.RegularSize = new System.Drawing.Size(750, 529);
            this.tabPane1.SelectedPage = this.tabNavigationPageGeneral;
            this.tabPane1.Size = new System.Drawing.Size(750, 529);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // frmConfiguracion
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 643);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmConfiguracion";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.tabNavigationPageNetSuite.ResumeLayout(false);
            this.tabNavigationPageNetSuite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNetSuite.Properties)).EndInit();
            this.gbNetSuite.ResumeLayout(false);
            this.gbNetSuite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteCuentaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteTokenId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteClienteSecreto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteTokenSecreto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteClienteLlave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSuiteApiURL.Properties)).EndInit();
            this.tabNavigationPageSAP.ResumeLayout(false);
            this.tabNavigationPageSAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSAP.Properties)).EndInit();
            this.gbSAP.ResumeLayout(false);
            this.gbSAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoServidorBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseñaBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidorLicencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConfiable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOpciones)).EndInit();
            this.gcOpciones.ResumeLayout(false);
            this.gcOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarAjusteInventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHoraSincronizacionGenerales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuentaAjusteInventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSAPAPIURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturarEntregas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInventarioSAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuenteDatos.Properties)).EndInit();
            this.tabNavigationPageTimbrado.ResumeLayout(false);
            this.tabNavigationPageTimbrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimbradoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimbradoContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarTimbradoSinDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimbradoModoPrueba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCertificados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPedimentos.Properties)).EndInit();
            this.tabNavigationPageDirectorios.ResumeLayout(false);
            this.tabNavigationPageDirectorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioDocumentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioImagenes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioXML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioInformes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorioAnexos.Properties)).EndInit();
            this.tabNavigationPagePredeterminados.ResumeLayout(false);
            this.tabNavigationPagePredeterminados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbZonas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiasSemana.Properties)).EndInit();
            this.tabNavigationPageGeneral.ResumeLayout(false);
            this.tabNavigationPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormularioPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloPrecioCero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerarDocumentoElectronicoAutomaticamente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentoBorrador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloStockCero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgruparPartidas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedorSegunUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedorSegunEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocumentosModoNuevo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVentaArticuloMenorCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecioSegunUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TabPane tabPane1;
        private TabNavigationPage tabNavigationPageGeneral;
        private CheckEdit cbListaPrecioSegunUsuario;
        private CheckEdit cbVentaArticuloMenorCosto;
        private CheckEdit cbDocumentosModoNuevo;
        private CheckEdit cbVendedorSegunEstacion;
        private CheckEdit cbVendedorSegunUsuario;
        private CheckEdit cbAgruparPartidas;
        private CheckEdit cbVentaArticuloStockCero;
        private CheckEdit cbDocumentoBorrador;
        private CheckEdit cbGenerarDocumentoElectronicoAutomaticamente;
        private CheckEdit cbVentaArticuloPrecioCero;
        private CheckEdit cbFormularioPanel;
        private LabelControl lblFechaActualizacion;
        private LabelControl lblUltimaActualizacion;
        private TabNavigationPage tabNavigationPageDirectorios;
        private TextEdit txtDirectorioAnexos;
        private LabelControl lblDirectorioAnexos;
        private TextEdit txtDirectorioInformes;
        private LabelControl lblDirectorioInformes;
        private TextEdit txtDirectorioXML;
        private LabelControl lblDirectorioXML;
        private TextEdit txtDirectorioImagenes;
        private LabelControl lblDirectorioImagenes;
        private TextEdit txtDirectorioDocumentos;
        private LabelControl lblDirectorioDocumentos;
        private TabNavigationPage tabNavigationPageSAP;
        private HyperlinkLabelControl lblSucursales;
        private GroupBox gbSAP;
        private LabelControl lblFuenteDatos;
        private TextEdit txtFuenteDatos;
        private GroupControl gcOpciones;
        private CheckEdit cbInventarioSAP;
        private CheckEdit cbFacturarEntregas;
        private TextEdit txtSAPAPIURL;
        private LabelControl lblSAPAPIURL;
        private TextEdit txtNumeroCuentaAjusteInventario;
        private TimeEdit teHoraSincronizacionGenerales;
        private LabelControl lblHoraSicronizacionGeneral;
        private CheckEdit cbGenerarAjusteInventario;
        private TextEdit txtUsuarioBD;
        private LabelControl lblUsuarioBD;
        private CheckEdit cbConfiable;
        private TextEdit txtContraseña;
        private LabelControl lblContraseña;
        private TextEdit txtUsuario;
        private LabelControl lblUsuario;
        private TextEdit txtServidorLicencias;
        private LabelControl lblServidorLicencias;
        private TextEdit txtContraseñaBD;
        private LabelControl lblContraseñaBD;
        private TextEdit txtBD;
        private LabelControl lblBD;
        private ComboBoxEdit cbTipoServidorBD;
        private LabelControl lblTipoServidorBD;
        private TextEdit txtServidor;
        private LabelControl lblServidor;
        private LabelControl lblSAP;
        private CheckEdit cbSAP;
        private TabNavigationPage tabNavigationPagePredeterminados;
        private ComboBoxEdit cbDiasSemana;
        private Label lblDiaSemana;
        private LookUpEdit cbImpuestos;
        private HyperlinkLabelControl lblImpuesto;
        private LookUpEdit cbDepartamentos;
        private HyperlinkLabelControl lblDepartamentos;
        private LookUpEdit cbZonas;
        private HyperlinkLabelControl lblZonas;
        private LookUpEdit cbCondicionesPago;
        private HyperlinkLabelControl lblCondicionesPago;
        private LookUpEdit cbMetodosPago;
        private HyperlinkLabelControl lblMetodoPago;
        private HyperlinkLabelControl lblFabricantes;
        private LookUpEdit cbFabricantes;
        private LookUpEdit cbMonedas;
        private HyperlinkLabelControl lblMonedas;
        private LookUpEdit cbListasPrecios;
        private HyperlinkLabelControl lblListaPrecios;
        private LookUpEdit cbGruposArticulos;
        private HyperlinkLabelControl lblGrupoArticulos;
        private TabNavigationPage tabNavigationPageTimbrado;
        private CheckEdit cbPedimentos;
        private ComboBoxEdit cbPAC;
        private LabelControl lblPAC;
        private LabelControl lblTimbradoUsuario;
        private LabelControl lblTimbradoContraseña;
        private LookUpEdit cbCertificados;
        private HyperlinkLabelControl lblCertificado;
        private SimpleButton btnCertificados;
        private CheckEdit cbTimbradoModoPrueba;
        private CheckEdit cbGenerarTimbradoSinDescuento;
        private TextEdit txtTimbradoContraseña;
        private TextEdit txtTimbradoUsuario;
        private TabNavigationPage tabNavigationPageNetSuite;
        private GroupBox gbNetSuite;
        private SimpleButton btnProbarConexion;
        private TextEdit txtNetSuiteApiURL;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private TextEdit txtNetSuiteClienteLlave;
        private LabelControl labelControl5;
        private TextEdit txtNetSuiteTokenSecreto;
        private LabelControl labelControl7;
        private TextEdit txtNetSuiteClienteSecreto;
        private LabelControl labelControl8;
        private TextEdit txtNetSuiteTokenId;
        private LabelControl labelControl9;
        private LabelControl labelControl10;
        private TextEdit txtNetSuiteCuentaId;
        private LabelControl labelControl12;
        private CheckEdit cbNetSuite;
        private LabelControl labelControl13;
    }
}