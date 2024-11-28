using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Padding = System.Windows.Forms.Padding;


namespace NORI
{
    partial class frmUsuarios
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
            this.cbListaPrecios = new DevExpress.XtraEditors.LookUpEdit();
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
            this.bbiCorreosElectronicos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPermisos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConceptosAutorizaciones = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HerramientasRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblListaPrecioMinimo = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbSeleccionarSucursal = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.cbUbicaciones = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUbicaciones = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtDispositivo = new DevExpress.XtraEditors.TextEdit();
            this.lblDispositivo = new DevExpress.XtraEditors.LabelControl();
            this.cbSucursales = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSucursal = new DevExpress.XtraEditors.LabelControl();
            this.txtEscritorio = new DevExpress.XtraEditors.TextEdit();
            this.lblEscritorio = new DevExpress.XtraEditors.LabelControl();
            this.cbClasesExpedicion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblClaseExpedicion = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtNormaReparto = new DevExpress.XtraEditors.TextEdit();
            this.lblNormaReparto = new DevExpress.XtraEditors.LabelControl();
            this.btnLiberarSesion = new DevExpress.XtraEditors.SimpleButton();
            this.cbSuscribirAutorizaciones = new DevExpress.XtraEditors.CheckEdit();
            this.cbEstados = new DevExpress.XtraEditors.LookUpEdit();
            this.lblEstado = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbVendedores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVendedores = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSocios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbAlmacenes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAlmacenes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbRoles = new DevExpress.XtraEditors.LookUpEdit();
            this.btnHuellaDigital = new DevExpress.XtraEditors.SimpleButton();
            this.cbMostrarContraseña = new DevExpress.XtraEditors.CheckButton();
            this.lblListaPrecios = new DevExpress.XtraEditors.LabelControl();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.lblContraseña = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeleccionarSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDispositivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSucursales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEscritorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClasesExpedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNormaReparto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSuscribirAutorizaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.panel1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 79);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(688, 563);
            this.dataLayoutControl1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbListaPrecios);
            this.panel1.Controls.Add(this.lblListaPrecioMinimo);
            this.panel1.Controls.Add(this.cbSeleccionarSucursal);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.cbUbicaciones);
            this.panel1.Controls.Add(this.lblUbicaciones);
            this.panel1.Controls.Add(this.txtDispositivo);
            this.panel1.Controls.Add(this.lblDispositivo);
            this.panel1.Controls.Add(this.cbSucursales);
            this.panel1.Controls.Add(this.lblSucursal);
            this.panel1.Controls.Add(this.txtEscritorio);
            this.panel1.Controls.Add(this.lblEscritorio);
            this.panel1.Controls.Add(this.cbClasesExpedicion);
            this.panel1.Controls.Add(this.lblClaseExpedicion);
            this.panel1.Controls.Add(this.txtNormaReparto);
            this.panel1.Controls.Add(this.lblNormaReparto);
            this.panel1.Controls.Add(this.btnLiberarSesion);
            this.panel1.Controls.Add(this.cbSuscribirAutorizaciones);
            this.panel1.Controls.Add(this.cbEstados);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cbVendedores);
            this.panel1.Controls.Add(this.lblVendedores);
            this.panel1.Controls.Add(this.cbSocios);
            this.panel1.Controls.Add(this.lblSocios);
            this.panel1.Controls.Add(this.cbAlmacenes);
            this.panel1.Controls.Add(this.lblAlmacenes);
            this.panel1.Controls.Add(this.cbRoles);
            this.panel1.Controls.Add(this.btnHuellaDigital);
            this.panel1.Controls.Add(this.cbMostrarContraseña);
            this.panel1.Controls.Add(this.lblListaPrecios);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.lblContraseña);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 553);
            this.panel1.TabIndex = 54;
            // 
            // cbListaPrecios
            // 
            this.cbListaPrecios.Location = new System.Drawing.Point(488, 153);
            this.cbListaPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListaPrecios.MenuManager = this.mainRibbonControl;
            this.cbListaPrecios.Name = "cbListaPrecios";
            this.cbListaPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListaPrecios.Size = new System.Drawing.Size(157, 24);
            this.cbListaPrecios.TabIndex = 93;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 27, 23, 27);
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
            this.bbiCorreosElectronicos,
            this.bbiPermisos,
            this.bbiConceptosAutorizaciones});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 4;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 257;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(688, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(48, 162);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.mainRibbonControl;
            this.backstageViewControl1.Size = new System.Drawing.Size(560, 196);
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
            // bbiCorreosElectronicos
            // 
            this.bbiCorreosElectronicos.Caption = "Correos electrónicos";
            this.bbiCorreosElectronicos.Id = 1;
            this.bbiCorreosElectronicos.ImageOptions.ImageUri.Uri = "Mail";
            this.bbiCorreosElectronicos.Name = "bbiCorreosElectronicos";
            this.bbiCorreosElectronicos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCorreosElectronicos_ItemClick);
            // 
            // bbiPermisos
            // 
            this.bbiPermisos.Caption = "Permisos";
            this.bbiPermisos.Id = 2;
            this.bbiPermisos.ImageOptions.ImageUri.Uri = "Customization";
            this.bbiPermisos.Name = "bbiPermisos";
            this.bbiPermisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPermisos_ItemClick);
            // 
            // bbiConceptosAutorizaciones
            // 
            this.bbiConceptosAutorizaciones.Caption = "Conceptos autorizaciónes";
            this.bbiConceptosAutorizaciones.Id = 3;
            this.bbiConceptosAutorizaciones.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.bbiConceptosAutorizaciones.Name = "bbiConceptosAutorizaciones";
            this.bbiConceptosAutorizaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConceptosAutorizaciones_ItemClick);
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
            this.HerramientasRibbonPageGroup});
            this.ribbonPageHerramientas.Name = "ribbonPageHerramientas";
            this.ribbonPageHerramientas.Text = "HERRAMIENTAS";
            // 
            // HerramientasRibbonPageGroup
            // 
            this.HerramientasRibbonPageGroup.ItemLinks.Add(this.bbiCorreosElectronicos);
            this.HerramientasRibbonPageGroup.ItemLinks.Add(this.bbiConceptosAutorizaciones);
            this.HerramientasRibbonPageGroup.ItemLinks.Add(this.bbiPermisos);
            this.HerramientasRibbonPageGroup.Name = "HerramientasRibbonPageGroup";
            this.HerramientasRibbonPageGroup.Text = "Correos electrónicos";
            // 
            // lblListaPrecioMinimo
            // 
            this.lblListaPrecioMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaPrecioMinimo.Location = new System.Drawing.Point(370, 157);
            this.lblListaPrecioMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblListaPrecioMinimo.Name = "lblListaPrecioMinimo";
            this.lblListaPrecioMinimo.Size = new System.Drawing.Size(115, 17);
            this.lblListaPrecioMinimo.TabIndex = 94;
            this.lblListaPrecioMinimo.Text = "Lista de precio min.";
            // 
            // cbSeleccionarSucursal
            // 
            this.cbSeleccionarSucursal.Location = new System.Drawing.Point(133, 426);
            this.cbSeleccionarSucursal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSeleccionarSucursal.MenuManager = this.mainRibbonControl;
            this.cbSeleccionarSucursal.Name = "cbSeleccionarSucursal";
            this.cbSeleccionarSucursal.Properties.Caption = "Seleccionar sucursal";
            this.cbSeleccionarSucursal.Size = new System.Drawing.Size(157, 21);
            this.cbSeleccionarSucursal.TabIndex = 92;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(488, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 20;
            this.txtCodigo.Size = new System.Drawing.Size(156, 24);
            this.txtCodigo.TabIndex = 90;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(370, 21);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 17);
            this.lblCodigo.TabIndex = 91;
            this.lblCodigo.Text = "Código";
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.Location = new System.Drawing.Point(488, 85);
            this.cbUbicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUbicaciones.MenuManager = this.mainRibbonControl;
            this.cbUbicaciones.Name = "cbUbicaciones";
            this.cbUbicaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUbicaciones.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ubicacion", "Ubicacion", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUbicaciones.Size = new System.Drawing.Size(156, 24);
            this.cbUbicaciones.TabIndex = 3;
            // 
            // lblUbicaciones
            // 
            this.lblUbicaciones.Location = new System.Drawing.Point(370, 89);
            this.lblUbicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUbicaciones.Name = "lblUbicaciones";
            this.lblUbicaciones.Size = new System.Drawing.Size(74, 17);
            this.lblUbicaciones.TabIndex = 89;
            this.lblUbicaciones.Text = "Ubicaciones";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Location = new System.Drawing.Point(488, 323);
            this.txtDispositivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDispositivo.MenuManager = this.mainRibbonControl;
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Properties.MaxLength = 155;
            this.txtDispositivo.Size = new System.Drawing.Size(156, 24);
            this.txtDispositivo.TabIndex = 12;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.Location = new System.Drawing.Point(366, 327);
            this.lblDispositivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(65, 17);
            this.lblDispositivo.TabIndex = 87;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // cbSucursales
            // 
            this.cbSucursales.Location = new System.Drawing.Point(488, 122);
            this.cbSucursales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSucursales.MenuManager = this.mainRibbonControl;
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSucursales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSucursales.Size = new System.Drawing.Size(156, 24);
            this.cbSucursales.TabIndex = 0;
            this.cbSucursales.TabStop = false;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Location = new System.Drawing.Point(370, 123);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(49, 17);
            this.lblSucursal.TabIndex = 86;
            this.lblSucursal.Text = "Sucursal";
            // 
            // txtEscritorio
            // 
            this.txtEscritorio.Location = new System.Drawing.Point(133, 323);
            this.txtEscritorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEscritorio.MenuManager = this.mainRibbonControl;
            this.txtEscritorio.Name = "txtEscritorio";
            this.txtEscritorio.Properties.MaxLength = 155;
            this.txtEscritorio.Size = new System.Drawing.Size(226, 24);
            this.txtEscritorio.TabIndex = 11;
            // 
            // lblEscritorio
            // 
            this.lblEscritorio.Location = new System.Drawing.Point(14, 327);
            this.lblEscritorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEscritorio.Name = "lblEscritorio";
            this.lblEscritorio.Size = new System.Drawing.Size(54, 17);
            this.lblEscritorio.TabIndex = 85;
            this.lblEscritorio.Text = "Escritorio";
            // 
            // cbClasesExpedicion
            // 
            this.cbClasesExpedicion.Location = new System.Drawing.Point(488, 187);
            this.cbClasesExpedicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClasesExpedicion.MenuManager = this.mainRibbonControl;
            this.cbClasesExpedicion.Name = "cbClasesExpedicion";
            this.cbClasesExpedicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClasesExpedicion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbClasesExpedicion.Size = new System.Drawing.Size(156, 24);
            this.cbClasesExpedicion.TabIndex = 7;
            // 
            // lblClaseExpedicion
            // 
            this.lblClaseExpedicion.Location = new System.Drawing.Point(370, 188);
            this.lblClaseExpedicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblClaseExpedicion.Name = "lblClaseExpedicion";
            this.lblClaseExpedicion.Size = new System.Drawing.Size(103, 17);
            this.lblClaseExpedicion.TabIndex = 83;
            this.lblClaseExpedicion.Text = "Clase expedición";
            // 
            // txtNormaReparto
            // 
            this.txtNormaReparto.Location = new System.Drawing.Point(488, 51);
            this.txtNormaReparto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNormaReparto.MenuManager = this.mainRibbonControl;
            this.txtNormaReparto.Name = "txtNormaReparto";
            this.txtNormaReparto.Properties.MaxLength = 16;
            this.txtNormaReparto.Size = new System.Drawing.Size(156, 24);
            this.txtNormaReparto.TabIndex = 3;
            // 
            // lblNormaReparto
            // 
            this.lblNormaReparto.Location = new System.Drawing.Point(370, 55);
            this.lblNormaReparto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNormaReparto.Name = "lblNormaReparto";
            this.lblNormaReparto.Size = new System.Drawing.Size(107, 17);
            this.lblNormaReparto.TabIndex = 81;
            this.lblNormaReparto.Text = "Norma de reparto";
            // 
            // btnLiberarSesion
            // 
            this.btnLiberarSesion.Location = new System.Drawing.Point(366, 357);
            this.btnLiberarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLiberarSesion.Name = "btnLiberarSesion";
            this.btnLiberarSesion.Size = new System.Drawing.Size(114, 30);
            this.btnLiberarSesion.TabIndex = 0;
            this.btnLiberarSesion.TabStop = false;
            this.btnLiberarSesion.Text = "Liberar sesión";
            // 
            // cbSuscribirAutorizaciones
            // 
            this.cbSuscribirAutorizaciones.Location = new System.Drawing.Point(133, 392);
            this.cbSuscribirAutorizaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSuscribirAutorizaciones.MenuManager = this.mainRibbonControl;
            this.cbSuscribirAutorizaciones.Name = "cbSuscribirAutorizaciones";
            this.cbSuscribirAutorizaciones.Properties.Caption = "Suscribir autorizaciones";
            this.cbSuscribirAutorizaciones.Size = new System.Drawing.Size(157, 21);
            this.cbSuscribirAutorizaciones.TabIndex = 14;
            // 
            // cbEstados
            // 
            this.cbEstados.Location = new System.Drawing.Point(133, 187);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstados.MenuManager = this.mainRibbonControl;
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbEstados.Size = new System.Drawing.Size(226, 24);
            this.cbEstados.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(16, 188);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 17);
            this.lblEstado.TabIndex = 79;
            this.lblEstado.Text = "Estado";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Location = new System.Drawing.Point(133, 119);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(226, 24);
            this.cbVendedores.TabIndex = 4;
            // 
            // lblVendedores
            // 
            this.lblVendedores.Location = new System.Drawing.Point(14, 120);
            this.lblVendedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(61, 17);
            this.lblVendedores.TabIndex = 77;
            this.lblVendedores.Text = "Vendedor";
            // 
            // cbSocios
            // 
            this.cbSocios.Location = new System.Drawing.Point(133, 153);
            this.cbSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSocios.MenuManager = this.mainRibbonControl;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Size = new System.Drawing.Size(226, 24);
            this.cbSocios.TabIndex = 5;
            // 
            // lblSocios
            // 
            this.lblSocios.Location = new System.Drawing.Point(16, 154);
            this.lblSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(34, 17);
            this.lblSocios.TabIndex = 75;
            this.lblSocios.Text = "Socio";
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.Location = new System.Drawing.Point(133, 85);
            this.cbAlmacenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlmacenes.MenuManager = this.mainRibbonControl;
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Size = new System.Drawing.Size(226, 24);
            this.cbAlmacenes.TabIndex = 2;
            // 
            // lblAlmacenes
            // 
            this.lblAlmacenes.Location = new System.Drawing.Point(14, 89);
            this.lblAlmacenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAlmacenes.Name = "lblAlmacenes";
            this.lblAlmacenes.Size = new System.Drawing.Size(54, 17);
            this.lblAlmacenes.TabIndex = 61;
            this.lblAlmacenes.Text = "Almacén";
            // 
            // cbRoles
            // 
            this.cbRoles.Location = new System.Drawing.Point(133, 51);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRoles.MenuManager = this.mainRibbonControl;
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Rol", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRoles.Size = new System.Drawing.Size(226, 24);
            this.cbRoles.TabIndex = 1;
            // 
            // btnHuellaDigital
            // 
            this.btnHuellaDigital.Location = new System.Drawing.Point(133, 357);
            this.btnHuellaDigital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuellaDigital.Name = "btnHuellaDigital";
            this.btnHuellaDigital.Size = new System.Drawing.Size(226, 30);
            this.btnHuellaDigital.TabIndex = 13;
            this.btnHuellaDigital.Text = "Huella digital";
            // 
            // cbMostrarContraseña
            // 
            this.cbMostrarContraseña.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cbMostrarContraseña.Location = new System.Drawing.Point(602, 289);
            this.cbMostrarContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMostrarContraseña.Name = "cbMostrarContraseña";
            this.cbMostrarContraseña.Size = new System.Drawing.Size(44, 26);
            this.cbMostrarContraseña.TabIndex = 0;
            this.cbMostrarContraseña.TabStop = false;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Location = new System.Drawing.Point(14, 55);
            this.lblListaPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(82, 17);
            this.lblListaPrecios.TabIndex = 57;
            this.lblListaPrecios.Text = "Rol de usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(133, 289);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.MenuManager = this.mainRibbonControl;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.MaxLength = 254;
            this.txtContraseña.Properties.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(460, 24);
            this.txtContraseña.TabIndex = 10;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Location = new System.Drawing.Point(14, 293);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(69, 17);
            this.lblContraseña.TabIndex = 55;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(133, 255);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.MenuManager = this.mainRibbonControl;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.MaxLength = 100;
            this.txtCorreo.Size = new System.Drawing.Size(512, 24);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(14, 259);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(114, 17);
            this.lblCorreo.TabIndex = 53;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaActualizacion.Location = new System.Drawing.Point(580, 518);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 221);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 155;
            this.txtNombre.Size = new System.Drawing.Size(512, 24);
            this.txtNombre.TabIndex = 8;
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(420, 518);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 17);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.MenuManager = this.mainRibbonControl;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.MaxLength = 20;
            this.txtUsuario.Size = new System.Drawing.Size(226, 24);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(14, 21);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 17);
            this.lblUsuario.TabIndex = 44;
            this.lblUsuario.Text = "Usuario";
            // 
            // cbActivo
            // 
            this.cbActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbActivo.Location = new System.Drawing.Point(14, 515);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(112, 21);
            this.cbActivo.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(14, 225);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(72, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(7, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(688, 563);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(680, 555);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmUsuarios
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 642);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeleccionarSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUbicaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDispositivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSucursales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEscritorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClasesExpedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNormaReparto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSuscribirAutorizaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}