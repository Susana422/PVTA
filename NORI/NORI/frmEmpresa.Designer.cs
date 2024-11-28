using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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

namespace NORI
{
    partial class frmEmpresa
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageGeneral = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtLugarExpedicion = new DevExpress.XtraEditors.TextEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblLugarExpedicion = new DevExpress.XtraEditors.LabelControl();
            this.lblSitioWeb = new DevExpress.XtraEditors.LabelControl();
            this.txtSitioWeb = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono2 = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.txtRegimenFiscal = new DevExpress.XtraEditors.TextEdit();
            this.lblRegimenFiscal = new DevExpress.XtraEditors.LabelControl();
            this.cbTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.btnImagen = new DevExpress.XtraEditors.SimpleButton();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.txtEslogan = new DevExpress.XtraEditors.TextEdit();
            this.lblEslogan = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            this.lblNombreComercial = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreFiscal = new DevExpress.XtraEditors.TextEdit();
            this.lblNombreFiscal = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPageDireccion = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblPais = new DevExpress.XtraEditors.LabelControl();
            this.txtPais = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.lblMunicipio = new DevExpress.XtraEditors.LabelControl();
            this.txtMunicipio = new DevExpress.XtraEditors.TextEdit();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.lblCP = new DevExpress.XtraEditors.LabelControl();
            this.lblCiudad = new DevExpress.XtraEditors.LabelControl();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.lblColonia = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroInterior = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroInterior = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroExterior = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroExterior = new DevExpress.XtraEditors.LabelControl();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.lblCalle = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugarExpedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegimenFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEslogan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreFiscal.Properties)).BeginInit();
            this.tabNavigationPageDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
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
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(719, 543);
            this.dataLayoutControl1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabPane1);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 527);
            this.panel1.TabIndex = 54;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPageGeneral);
            this.tabPane1.Controls.Add(this.tabNavigationPageDireccion);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageGeneral,
            this.tabNavigationPageDireccion});
            this.tabPane1.RegularSize = new System.Drawing.Size(705, 527);
            this.tabPane1.SelectedPage = this.tabNavigationPageGeneral;
            this.tabPane1.Size = new System.Drawing.Size(705, 527);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPageGeneral
            // 
            this.tabNavigationPageGeneral.Caption = "General";
            this.tabNavigationPageGeneral.Controls.Add(this.txtLugarExpedicion);
            this.tabNavigationPageGeneral.Controls.Add(this.lblLugarExpedicion);
            this.tabNavigationPageGeneral.Controls.Add(this.lblSitioWeb);
            this.tabNavigationPageGeneral.Controls.Add(this.txtSitioWeb);
            this.tabNavigationPageGeneral.Controls.Add(this.lblCorreo);
            this.tabNavigationPageGeneral.Controls.Add(this.txtCorreo);
            this.tabNavigationPageGeneral.Controls.Add(this.txtTelefono2);
            this.tabNavigationPageGeneral.Controls.Add(this.lblTelefono2);
            this.tabNavigationPageGeneral.Controls.Add(this.txtTelefono);
            this.tabNavigationPageGeneral.Controls.Add(this.lblTelefono);
            this.tabNavigationPageGeneral.Controls.Add(this.txtRegimenFiscal);
            this.tabNavigationPageGeneral.Controls.Add(this.lblRegimenFiscal);
            this.tabNavigationPageGeneral.Controls.Add(this.cbTipo);
            this.tabNavigationPageGeneral.Controls.Add(this.lblTipo);
            this.tabNavigationPageGeneral.Controls.Add(this.btnImagen);
            this.tabNavigationPageGeneral.Controls.Add(this.pbImagen);
            this.tabNavigationPageGeneral.Controls.Add(this.txtRFC);
            this.tabNavigationPageGeneral.Controls.Add(this.lblRFC);
            this.tabNavigationPageGeneral.Controls.Add(this.txtEslogan);
            this.tabNavigationPageGeneral.Controls.Add(this.lblEslogan);
            this.tabNavigationPageGeneral.Controls.Add(this.txtNombreComercial);
            this.tabNavigationPageGeneral.Controls.Add(this.lblNombreComercial);
            this.tabNavigationPageGeneral.Controls.Add(this.txtNombreFiscal);
            this.tabNavigationPageGeneral.Controls.Add(this.lblNombreFiscal);
            this.tabNavigationPageGeneral.Controls.Add(this.lblFechaActualizacion);
            this.tabNavigationPageGeneral.Controls.Add(this.lblUltimaActualizacion);
            this.tabNavigationPageGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPageGeneral.Name = "tabNavigationPageGeneral";
            this.tabNavigationPageGeneral.Size = new System.Drawing.Size(705, 503);
            // 
            // txtLugarExpedicion
            // 
            this.txtLugarExpedicion.Location = new System.Drawing.Point(122, 205);
            this.txtLugarExpedicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLugarExpedicion.MenuManager = this.mainRibbonControl;
            this.txtLugarExpedicion.Name = "txtLugarExpedicion";
            this.txtLugarExpedicion.Size = new System.Drawing.Size(140, 24);
            this.txtLugarExpedicion.TabIndex = 104;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainRibbonControl.MaxItemId = 1;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(719, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(48, 162);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // lblLugarExpedicion
            // 
            this.lblLugarExpedicion.Location = new System.Drawing.Point(4, 211);
            this.lblLugarExpedicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblLugarExpedicion.Name = "lblLugarExpedicion";
            this.lblLugarExpedicion.Size = new System.Drawing.Size(103, 17);
            this.lblLugarExpedicion.TabIndex = 105;
            this.lblLugarExpedicion.Text = "Lugar expedición";
            // 
            // lblSitioWeb
            // 
            this.lblSitioWeb.Location = new System.Drawing.Point(4, 344);
            this.lblSitioWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSitioWeb.Name = "lblSitioWeb";
            this.lblSitioWeb.Size = new System.Drawing.Size(55, 17);
            this.lblSitioWeb.TabIndex = 87;
            this.lblSitioWeb.Text = "Sitio web";
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Location = new System.Drawing.Point(122, 340);
            this.txtSitioWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSitioWeb.MenuManager = this.mainRibbonControl;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSitioWeb.Properties.MaxLength = 254;
            this.txtSitioWeb.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtSitioWeb.Size = new System.Drawing.Size(304, 24);
            this.txtSitioWeb.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(4, 310);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 17);
            this.lblCorreo.TabIndex = 86;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(122, 306);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.MenuManager = this.mainRibbonControl;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCorreo.Properties.MaxLength = 100;
            this.txtCorreo.Properties.NullValuePrompt = "Dirección de correo electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(304, 24);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(122, 272);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono2.MenuManager = this.mainRibbonControl;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Properties.MaxLength = 20;
            this.txtTelefono2.Size = new System.Drawing.Size(304, 24);
            this.txtTelefono2.TabIndex = 7;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.Location = new System.Drawing.Point(4, 276);
            this.lblTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(61, 17);
            this.lblTelefono2.TabIndex = 83;
            this.lblTelefono2.Text = "Teléfono 2";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 238);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MenuManager = this.mainRibbonControl;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.MaxLength = 20;
            this.txtTelefono.Size = new System.Drawing.Size(304, 24);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(4, 242);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(51, 17);
            this.lblTelefono.TabIndex = 81;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtRegimenFiscal
            // 
            this.txtRegimenFiscal.Location = new System.Drawing.Point(122, 174);
            this.txtRegimenFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegimenFiscal.MenuManager = this.mainRibbonControl;
            this.txtRegimenFiscal.Name = "txtRegimenFiscal";
            this.txtRegimenFiscal.Properties.MaxLength = 254;
            this.txtRegimenFiscal.Size = new System.Drawing.Size(304, 24);
            this.txtRegimenFiscal.TabIndex = 5;
            // 
            // lblRegimenFiscal
            // 
            this.lblRegimenFiscal.Location = new System.Drawing.Point(4, 178);
            this.lblRegimenFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblRegimenFiscal.Name = "lblRegimenFiscal";
            this.lblRegimenFiscal.Size = new System.Drawing.Size(86, 17);
            this.lblRegimenFiscal.TabIndex = 79;
            this.lblRegimenFiscal.Text = "Régimen fiscal";
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(121, 38);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipo.MenuManager = this.mainRibbonControl;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipo.Size = new System.Drawing.Size(304, 24);
            this.cbTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(0, 42);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 17);
            this.lblTipo.TabIndex = 77;
            this.lblTipo.Text = "Tipo persona";
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.Location = new System.Drawing.Point(434, 194);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(230, 35);
            this.btnImagen.TabIndex = 10;
            this.btnImagen.Text = "Seleccionar imagen";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(434, 4);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(230, 182);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 75;
            this.pbImagen.TabStop = false;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(121, 4);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRFC.MenuManager = this.mainRibbonControl;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.MaxLength = 30;
            this.txtRFC.Size = new System.Drawing.Size(304, 24);
            this.txtRFC.TabIndex = 0;
            // 
            // lblRFC
            // 
            this.lblRFC.Location = new System.Drawing.Point(2, 8);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(22, 17);
            this.lblRFC.TabIndex = 73;
            this.lblRFC.Text = "RFC";
            // 
            // txtEslogan
            // 
            this.txtEslogan.Location = new System.Drawing.Point(122, 140);
            this.txtEslogan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEslogan.MenuManager = this.mainRibbonControl;
            this.txtEslogan.Name = "txtEslogan";
            this.txtEslogan.Properties.MaxLength = 254;
            this.txtEslogan.Size = new System.Drawing.Size(304, 24);
            this.txtEslogan.TabIndex = 4;
            // 
            // lblEslogan
            // 
            this.lblEslogan.Location = new System.Drawing.Point(4, 144);
            this.lblEslogan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(45, 17);
            this.lblEslogan.TabIndex = 71;
            this.lblEslogan.Text = "Eslogan";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(122, 106);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreComercial.MenuManager = this.mainRibbonControl;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.MaxLength = 100;
            this.txtNombreComercial.Size = new System.Drawing.Size(304, 24);
            this.txtNombreComercial.TabIndex = 3;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.Location = new System.Drawing.Point(4, 110);
            this.lblNombreComercial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(112, 17);
            this.lblNombreComercial.TabIndex = 69;
            this.lblNombreComercial.Text = "Nombre comercial";
            // 
            // txtNombreFiscal
            // 
            this.txtNombreFiscal.Location = new System.Drawing.Point(122, 72);
            this.txtNombreFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreFiscal.MenuManager = this.mainRibbonControl;
            this.txtNombreFiscal.Name = "txtNombreFiscal";
            this.txtNombreFiscal.Properties.MaxLength = 150;
            this.txtNombreFiscal.Size = new System.Drawing.Size(304, 24);
            this.txtNombreFiscal.TabIndex = 2;
            // 
            // lblNombreFiscal
            // 
            this.lblNombreFiscal.Location = new System.Drawing.Point(4, 76);
            this.lblNombreFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombreFiscal.Name = "lblNombreFiscal";
            this.lblNombreFiscal.Size = new System.Drawing.Size(82, 17);
            this.lblNombreFiscal.TabIndex = 67;
            this.lblNombreFiscal.Text = "Nombre fiscal";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(598, 408);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 65;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(439, 408);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 64;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // tabNavigationPageDireccion
            // 
            this.tabNavigationPageDireccion.Caption = "Dirección";
            this.tabNavigationPageDireccion.Controls.Add(this.lblPais);
            this.tabNavigationPageDireccion.Controls.Add(this.txtPais);
            this.tabNavigationPageDireccion.Controls.Add(this.lblEstado);
            this.tabNavigationPageDireccion.Controls.Add(this.txtEstado);
            this.tabNavigationPageDireccion.Controls.Add(this.lblMunicipio);
            this.tabNavigationPageDireccion.Controls.Add(this.txtMunicipio);
            this.tabNavigationPageDireccion.Controls.Add(this.txtCP);
            this.tabNavigationPageDireccion.Controls.Add(this.lblCP);
            this.tabNavigationPageDireccion.Controls.Add(this.lblCiudad);
            this.tabNavigationPageDireccion.Controls.Add(this.txtCiudad);
            this.tabNavigationPageDireccion.Controls.Add(this.txtColonia);
            this.tabNavigationPageDireccion.Controls.Add(this.lblColonia);
            this.tabNavigationPageDireccion.Controls.Add(this.txtNumeroInterior);
            this.tabNavigationPageDireccion.Controls.Add(this.lblNumeroInterior);
            this.tabNavigationPageDireccion.Controls.Add(this.txtNumeroExterior);
            this.tabNavigationPageDireccion.Controls.Add(this.lblNumeroExterior);
            this.tabNavigationPageDireccion.Controls.Add(this.txtCalle);
            this.tabNavigationPageDireccion.Controls.Add(this.lblCalle);
            this.tabNavigationPageDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNavigationPageDireccion.Name = "tabNavigationPageDireccion";
            this.tabNavigationPageDireccion.Size = new System.Drawing.Size(691, 435);
            // 
            // lblPais
            // 
            this.lblPais.Location = new System.Drawing.Point(2, 280);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 17);
            this.lblPais.TabIndex = 109;
            this.lblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(121, 276);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPais.MenuManager = this.mainRibbonControl;
            this.txtPais.Name = "txtPais";
            this.txtPais.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPais.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtPais.Size = new System.Drawing.Size(491, 24);
            this.txtPais.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(2, 246);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 17);
            this.lblEstado.TabIndex = 107;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(121, 242);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.MenuManager = this.mainRibbonControl;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtEstado.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtEstado.Size = new System.Drawing.Size(491, 24);
            this.txtEstado.TabIndex = 7;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Location = new System.Drawing.Point(2, 212);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(58, 17);
            this.lblMunicipio.TabIndex = 105;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(121, 208);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMunicipio.MenuManager = this.mainRibbonControl;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMunicipio.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtMunicipio.Size = new System.Drawing.Size(491, 24);
            this.txtMunicipio.TabIndex = 6;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(121, 140);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCP.MenuManager = this.mainRibbonControl;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(140, 24);
            this.txtCP.TabIndex = 4;
            // 
            // lblCP
            // 
            this.lblCP.Location = new System.Drawing.Point(2, 144);
            this.lblCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(84, 17);
            this.lblCP.TabIndex = 103;
            this.lblCP.Text = "Código postal";
            // 
            // lblCiudad
            // 
            this.lblCiudad.Location = new System.Drawing.Point(2, 178);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 17);
            this.lblCiudad.TabIndex = 101;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(121, 174);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiudad.MenuManager = this.mainRibbonControl;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCiudad.Properties.NullValuePrompt = "Dirección del sitio web";
            this.txtCiudad.Size = new System.Drawing.Size(491, 24);
            this.txtCiudad.TabIndex = 5;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(121, 106);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColonia.MenuManager = this.mainRibbonControl;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(491, 24);
            this.txtColonia.TabIndex = 3;
            // 
            // lblColonia
            // 
            this.lblColonia.Location = new System.Drawing.Point(2, 110);
            this.lblColonia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(46, 17);
            this.lblColonia.TabIndex = 95;
            this.lblColonia.Text = "Colonia";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(121, 72);
            this.txtNumeroInterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroInterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Size = new System.Drawing.Size(140, 24);
            this.txtNumeroInterior.TabIndex = 2;
            // 
            // lblNumeroInterior
            // 
            this.lblNumeroInterior.Location = new System.Drawing.Point(2, 76);
            this.lblNumeroInterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(63, 17);
            this.lblNumeroInterior.TabIndex = 93;
            this.lblNumeroInterior.Text = "No Interior";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Location = new System.Drawing.Point(121, 38);
            this.txtNumeroExterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroExterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Size = new System.Drawing.Size(140, 24);
            this.txtNumeroExterior.TabIndex = 1;
            // 
            // lblNumeroExterior
            // 
            this.lblNumeroExterior.Location = new System.Drawing.Point(2, 42);
            this.lblNumeroExterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNumeroExterior.Name = "lblNumeroExterior";
            this.lblNumeroExterior.Size = new System.Drawing.Size(65, 17);
            this.lblNumeroExterior.TabIndex = 91;
            this.lblNumeroExterior.Text = "No Exterior";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(121, 4);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalle.MenuManager = this.mainRibbonControl;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(491, 24);
            this.txtCalle.TabIndex = 0;
            // 
            // lblCalle
            // 
            this.lblCalle.Location = new System.Drawing.Point(2, 8);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(31, 17);
            this.lblCalle.TabIndex = 89;
            this.lblCalle.Text = "Calle";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(719, 543);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(707, 529);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmEmpresa
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 622);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEmpresa";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPageGeneral.ResumeLayout(false);
            this.tabNavigationPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugarExpedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegimenFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEslogan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreFiscal.Properties)).EndInit();
            this.tabNavigationPageDireccion.ResumeLayout(false);
            this.tabNavigationPageDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}