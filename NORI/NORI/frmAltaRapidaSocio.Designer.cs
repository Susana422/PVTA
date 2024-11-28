using System;
using System.ComponentModel;
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
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Padding = System.Windows.Forms.Padding;

namespace NORI
{
    partial class frmAltaRapidaSocio
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
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbRegimenFiscal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRegimenFiscal = new DevExpress.XtraEditors.LabelControl();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.cbSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.cbEventual = new DevExpress.XtraEditors.CheckEdit();
            this.btnHuellaDigital = new DevExpress.XtraEditors.SimpleButton();
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
            this.lblNombreComercial = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardarCerrar});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 257;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(733, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Location = new System.Drawing.Point(48, 162);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.mainRibbonControl;
            this.backstageViewControl1.Size = new System.Drawing.Size(560, 196);
            this.backstageViewControl1.TabIndex = 2;
            this.backstageViewControl1.VisibleInDesignTime = true;
            // 
            // bbiGuardarCerrar
            // 
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            this.bbiGuardarCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarCerrar_ItemClick);
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(733, 655);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(725, 647);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbRegimenFiscal);
            this.panelControl1.Controls.Add(this.lblRegimenFiscal);
            this.panelControl1.Controls.Add(this.cbUsoPrincipal);
            this.panelControl1.Controls.Add(this.lblUsoPrincipal);
            this.panelControl1.Controls.Add(this.cbSocios);
            this.panelControl1.Controls.Add(this.cbEventual);
            this.panelControl1.Controls.Add(this.btnHuellaDigital);
            this.panelControl1.Controls.Add(this.lblCP);
            this.panelControl1.Controls.Add(this.txtCP);
            this.panelControl1.Controls.Add(this.lblCiudad);
            this.panelControl1.Controls.Add(this.txtCiudad);
            this.panelControl1.Controls.Add(this.lblEstado);
            this.panelControl1.Controls.Add(this.cbEstados);
            this.panelControl1.Controls.Add(this.lblPais);
            this.panelControl1.Controls.Add(this.cbPaises);
            this.panelControl1.Controls.Add(this.lblMunicipio);
            this.panelControl1.Controls.Add(this.txtMunicipio);
            this.panelControl1.Controls.Add(this.lblColonia);
            this.panelControl1.Controls.Add(this.txtColonia);
            this.panelControl1.Controls.Add(this.lblNumeroInterior);
            this.panelControl1.Controls.Add(this.txtNumeroInterior);
            this.panelControl1.Controls.Add(this.lblNumeroExterior);
            this.panelControl1.Controls.Add(this.txtNumeroExterior);
            this.panelControl1.Controls.Add(this.lblCalle);
            this.panelControl1.Controls.Add(this.txtCalle);
            this.panelControl1.Controls.Add(this.lblTelefono2);
            this.panelControl1.Controls.Add(this.txtTelefono2);
            this.panelControl1.Controls.Add(this.lblCorreo);
            this.panelControl1.Controls.Add(this.txtCorreo);
            this.panelControl1.Controls.Add(this.lblTelefonoCelular);
            this.panelControl1.Controls.Add(this.txtTelefonoCelular);
            this.panelControl1.Controls.Add(this.lblTelefono);
            this.panelControl1.Controls.Add(this.txtTelefono);
            this.panelControl1.Controls.Add(this.lblRFC);
            this.panelControl1.Controls.Add(this.txtRFC);
            this.panelControl1.Controls.Add(this.lblNombreComercial);
            this.panelControl1.Controls.Add(this.txtNombreComercial);
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Controls.Add(this.lblCodigo);
            this.panelControl1.Controls.Add(this.txtCodigo);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(723, 645);
            this.panelControl1.TabIndex = 4;
            // 
            // cbRegimenFiscal
            // 
            this.cbRegimenFiscal.Location = new System.Drawing.Point(403, 490);
            this.cbRegimenFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegimenFiscal.MenuManager = this.mainRibbonControl;
            this.cbRegimenFiscal.Name = "cbRegimenFiscal";
            this.cbRegimenFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRegimenFiscal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("clave", "Clave", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRegimenFiscal.Size = new System.Drawing.Size(285, 24);
            this.cbRegimenFiscal.TabIndex = 110;
            this.cbRegimenFiscal.TabStop = false;
            // 
            // lblRegimenFiscal
            // 
            this.lblRegimenFiscal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblRegimenFiscal.Appearance.Options.UseFont = true;
            this.lblRegimenFiscal.Location = new System.Drawing.Point(403, 461);
            this.lblRegimenFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRegimenFiscal.Name = "lblRegimenFiscal";
            this.lblRegimenFiscal.Size = new System.Drawing.Size(82, 13);
            this.lblRegimenFiscal.TabIndex = 106;
            this.lblRegimenFiscal.Text = "Régimen fiscal";
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(403, 422);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(285, 24);
            this.cbUsoPrincipal.TabIndex = 104;
            this.cbUsoPrincipal.TabStop = false;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsoPrincipal.Appearance.Options.UseFont = true;
            this.lblUsoPrincipal.Location = new System.Drawing.Point(403, 392);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(72, 13);
            this.lblUsoPrincipal.TabIndex = 103;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // cbSocios
            // 
            this.cbSocios.Location = new System.Drawing.Point(478, 50);
            this.cbSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSocios.MenuManager = this.mainRibbonControl;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Size = new System.Drawing.Size(210, 24);
            this.cbSocios.TabIndex = 102;
            this.cbSocios.Visible = false;
            // 
            // cbEventual
            // 
            this.cbEventual.Location = new System.Drawing.Point(399, 50);
            this.cbEventual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEventual.MenuManager = this.mainRibbonControl;
            this.cbEventual.Name = "cbEventual";
            this.cbEventual.Properties.Caption = "Eventual";
            this.cbEventual.Size = new System.Drawing.Size(72, 21);
            this.cbEventual.TabIndex = 2;
            // 
            // btnHuellaDigital
            // 
            this.btnHuellaDigital.Location = new System.Drawing.Point(399, 556);
            this.btnHuellaDigital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuellaDigital.Name = "btnHuellaDigital";
            this.btnHuellaDigital.Size = new System.Drawing.Size(289, 30);
            this.btnHuellaDigital.TabIndex = 18;
            this.btnHuellaDigital.Text = "Huella digital";
            // 
            // lblCP
            // 
            this.lblCP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCP.Appearance.Options.UseFont = true;
            this.lblCP.Location = new System.Drawing.Point(17, 290);
            this.lblCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(20, 13);
            this.lblCP.TabIndex = 101;
            this.lblCP.Text = "C.P.";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(137, 286);
            this.txtCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCP.MenuManager = this.mainRibbonControl;
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCP.Properties.Mask.EditMask = "00000";
            this.txtCP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCP.Properties.MaxLength = 5;
            this.txtCP.Size = new System.Drawing.Size(128, 24);
            this.txtCP.TabIndex = 9;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCiudad.Appearance.Options.UseFont = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 324);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(38, 13);
            this.lblCiudad.TabIndex = 99;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(137, 320);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiudad.MenuManager = this.mainRibbonControl;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCiudad.Properties.MaxLength = 100;
            this.txtCiudad.Size = new System.Drawing.Size(552, 24);
            this.txtCiudad.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Appearance.Options.UseFont = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 426);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(38, 13);
            this.lblEstado.TabIndex = 97;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstados
            // 
            this.cbEstados.Location = new System.Drawing.Point(137, 422);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstados.MenuManager = this.mainRibbonControl;
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbEstados.Size = new System.Drawing.Size(255, 24);
            this.cbEstados.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPais.Appearance.Options.UseFont = true;
            this.lblPais.Location = new System.Drawing.Point(17, 392);
            this.lblPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 13);
            this.lblPais.TabIndex = 95;
            this.lblPais.Text = "País";
            // 
            // cbPaises
            // 
            this.cbPaises.Location = new System.Drawing.Point(137, 388);
            this.cbPaises.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPaises.MenuManager = this.mainRibbonControl;
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaises.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPaises.Size = new System.Drawing.Size(255, 24);
            this.cbPaises.TabIndex = 12;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Location = new System.Drawing.Point(17, 358);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(58, 17);
            this.lblMunicipio.TabIndex = 92;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(137, 354);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMunicipio.MenuManager = this.mainRibbonControl;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMunicipio.Properties.MaxLength = 100;
            this.txtMunicipio.Size = new System.Drawing.Size(552, 24);
            this.txtMunicipio.TabIndex = 11;
            // 
            // lblColonia
            // 
            this.lblColonia.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblColonia.Appearance.Options.UseFont = true;
            this.lblColonia.Location = new System.Drawing.Point(17, 256);
            this.lblColonia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(41, 13);
            this.lblColonia.TabIndex = 90;
            this.lblColonia.Text = "Colonia";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(137, 252);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColonia.MenuManager = this.mainRibbonControl;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtColonia.Properties.MaxLength = 100;
            this.txtColonia.Size = new System.Drawing.Size(552, 24);
            this.txtColonia.TabIndex = 8;
            // 
            // lblNumeroInterior
            // 
            this.lblNumeroInterior.Location = new System.Drawing.Point(17, 222);
            this.lblNumeroInterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(66, 17);
            this.lblNumeroInterior.TabIndex = 88;
            this.lblNumeroInterior.Text = "No. Interior";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(137, 218);
            this.txtNumeroInterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroInterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroInterior.Properties.MaxLength = 100;
            this.txtNumeroInterior.Size = new System.Drawing.Size(128, 24);
            this.txtNumeroInterior.TabIndex = 7;
            // 
            // lblNumeroExterior
            // 
            this.lblNumeroExterior.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroExterior.Appearance.Options.UseFont = true;
            this.lblNumeroExterior.Location = new System.Drawing.Point(17, 188);
            this.lblNumeroExterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroExterior.Name = "lblNumeroExterior";
            this.lblNumeroExterior.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroExterior.TabIndex = 86;
            this.lblNumeroExterior.Text = "No. Exterior";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Location = new System.Drawing.Point(137, 184);
            this.txtNumeroExterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroExterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroExterior.Properties.MaxLength = 100;
            this.txtNumeroExterior.Size = new System.Drawing.Size(128, 24);
            this.txtNumeroExterior.TabIndex = 6;
            // 
            // lblCalle
            // 
            this.lblCalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCalle.Appearance.Options.UseFont = true;
            this.lblCalle.Location = new System.Drawing.Point(17, 154);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(27, 13);
            this.lblCalle.TabIndex = 84;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(137, 150);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalle.MenuManager = this.mainRibbonControl;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCalle.Properties.MaxLength = 100;
            this.txtCalle.Size = new System.Drawing.Size(552, 24);
            this.txtCalle.TabIndex = 5;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.Location = new System.Drawing.Point(17, 494);
            this.lblTelefono2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(61, 17);
            this.lblTelefono2.TabIndex = 81;
            this.lblTelefono2.Text = "Teléfono 2";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(137, 490);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono2.MenuManager = this.mainRibbonControl;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefono2.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtTelefono2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefono2.Properties.MaxLength = 20;
            this.txtTelefono2.Properties.NullValuePrompt = "Teléfono adicional";
            this.txtTelefono2.Size = new System.Drawing.Size(255, 24);
            this.txtTelefono2.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Appearance.Options.UseFont = true;
            this.lblCorreo.Location = new System.Drawing.Point(17, 562);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 80;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(137, 558);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.MenuManager = this.mainRibbonControl;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Properties.MaxLength = 100;
            this.txtCorreo.Properties.NullValuePrompt = "Dirección de correo electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(255, 24);
            this.txtCorreo.TabIndex = 17;
            // 
            // lblTelefonoCelular
            // 
            this.lblTelefonoCelular.Location = new System.Drawing.Point(17, 528);
            this.lblTelefonoCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTelefonoCelular.Name = "lblTelefonoCelular";
            this.lblTelefonoCelular.Size = new System.Drawing.Size(96, 17);
            this.lblTelefonoCelular.TabIndex = 79;
            this.lblTelefonoCelular.Text = "Teléfono celular";
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.Location = new System.Drawing.Point(137, 524);
            this.txtTelefonoCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoCelular.MenuManager = this.mainRibbonControl;
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefonoCelular.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtTelefonoCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefonoCelular.Properties.MaxLength = 50;
            this.txtTelefonoCelular.Properties.NullValuePrompt = "Teléfono celular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(255, 24);
            this.txtTelefonoCelular.TabIndex = 16;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Appearance.Options.UseFont = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 460);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 78;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 456);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.MenuManager = this.mainRibbonControl;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTelefono.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefono.Properties.MaxLength = 20;
            this.txtTelefono.Properties.NullValuePrompt = "Teléfono principal";
            this.txtTelefono.Size = new System.Drawing.Size(255, 24);
            this.txtTelefono.TabIndex = 14;
            // 
            // lblRFC
            // 
            this.lblRFC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRFC.Appearance.Options.UseFont = true;
            this.lblRFC.Location = new System.Drawing.Point(17, 52);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(21, 13);
            this.lblRFC.TabIndex = 77;
            this.lblRFC.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(137, 48);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRFC.MenuManager = this.mainRibbonControl;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 30;
            this.txtRFC.Properties.NullValuePrompt = "RFC";
            this.txtRFC.Size = new System.Drawing.Size(255, 24);
            this.txtRFC.TabIndex = 1;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.Location = new System.Drawing.Point(17, 120);
            this.lblNombreComercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(112, 17);
            this.lblNombreComercial.TabIndex = 70;
            this.lblNombreComercial.Text = "Nombre comercial";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(137, 116);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreComercial.MenuManager = this.mainRibbonControl;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombreComercial.Properties.MaxLength = 100;
            this.txtNombreComercial.Properties.NullValuePrompt = "Nombre comercial del socio";
            this.txtNombreComercial.Size = new System.Drawing.Size(552, 24);
            this.txtNombreComercial.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 86);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Properties.NullValuePrompt = "Nombre del socio";
            this.txtNombre.Size = new System.Drawing.Size(552, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 18);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 13);
            this.lblCodigo.TabIndex = 66;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 14);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCodigo.Properties.MaxLength = 15;
            this.txtCodigo.Properties.NullValuePrompt = "Identificador del socio";
            this.txtCodigo.Size = new System.Drawing.Size(255, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.panelControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 79);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(482, 356, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(733, 655);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // frmAltaRapidaSocio
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(733, 734);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaRapidaSocio";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta rápida de socio";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}