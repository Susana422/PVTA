using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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


namespace DTM
{
    partial class frmDireccion
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
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblDistancia = new DevExpress.XtraEditors.LabelControl();
            this.txtDistancia = new DevExpress.XtraEditors.TextEdit();
            this.lblReferencias = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencias = new DevExpress.XtraEditors.TextEdit();
            this.lblEntreCalles = new DevExpress.XtraEditors.LabelControl();
            this.txtEntreCalles = new DevExpress.XtraEditors.TextEdit();
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
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntreCalles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(733, 414);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(725, 406);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblDistancia);
            this.panelControl1.Controls.Add(this.txtDistancia);
            this.panelControl1.Controls.Add(this.lblReferencias);
            this.panelControl1.Controls.Add(this.txtReferencias);
            this.panelControl1.Controls.Add(this.lblEntreCalles);
            this.panelControl1.Controls.Add(this.txtEntreCalles);
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
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(723, 404);
            this.panelControl1.TabIndex = 4;
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(272, 182);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(86, 17);
            this.lblDistancia.TabIndex = 107;
            this.lblDistancia.Text = "Distancia (KM)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(390, 177);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistancia.MenuManager = this.mainRibbonControl;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDistancia.Properties.MaxLength = 100;
            this.txtDistancia.Size = new System.Drawing.Size(128, 24);
            this.txtDistancia.TabIndex = 106;
            // 
            // lblReferencias
            // 
            this.lblReferencias.Location = new System.Drawing.Point(272, 115);
            this.lblReferencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblReferencias.Name = "lblReferencias";
            this.lblReferencias.Size = new System.Drawing.Size(70, 17);
            this.lblReferencias.TabIndex = 105;
            this.lblReferencias.Text = "Referencias";
            // 
            // txtReferencias
            // 
            this.txtReferencias.Location = new System.Drawing.Point(390, 111);
            this.txtReferencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReferencias.MenuManager = this.mainRibbonControl;
            this.txtReferencias.Name = "txtReferencias";
            this.txtReferencias.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtReferencias.Properties.MaxLength = 100;
            this.txtReferencias.Size = new System.Drawing.Size(297, 24);
            this.txtReferencias.TabIndex = 5;
            // 
            // lblEntreCalles
            // 
            this.lblEntreCalles.Location = new System.Drawing.Point(272, 81);
            this.lblEntreCalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEntreCalles.Name = "lblEntreCalles";
            this.lblEntreCalles.Size = new System.Drawing.Size(68, 17);
            this.lblEntreCalles.TabIndex = 103;
            this.lblEntreCalles.Text = "Entre calles";
            // 
            // txtEntreCalles
            // 
            this.txtEntreCalles.Location = new System.Drawing.Point(390, 77);
            this.txtEntreCalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEntreCalles.MenuManager = this.mainRibbonControl;
            this.txtEntreCalles.Name = "txtEntreCalles";
            this.txtEntreCalles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtEntreCalles.Properties.MaxLength = 100;
            this.txtEntreCalles.Size = new System.Drawing.Size(297, 24);
            this.txtEntreCalles.TabIndex = 3;
            // 
            // lblCP
            // 
            this.lblCP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCP.Appearance.Options.UseFont = true;
            this.lblCP.Location = new System.Drawing.Point(17, 183);
            this.lblCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(20, 13);
            this.lblCP.TabIndex = 101;
            this.lblCP.Text = "C.P.";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(137, 179);
            this.txtCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCP.MenuManager = this.mainRibbonControl;
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCP.Properties.Mask.EditMask = "00000";
            this.txtCP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCP.Properties.MaxLength = 5;
            this.txtCP.Size = new System.Drawing.Size(128, 24);
            this.txtCP.TabIndex = 7;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCiudad.Appearance.Options.UseFont = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 149);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(38, 13);
            this.lblCiudad.TabIndex = 99;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(137, 145);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiudad.MenuManager = this.mainRibbonControl;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCiudad.Properties.MaxLength = 100;
            this.txtCiudad.Size = new System.Drawing.Size(552, 24);
            this.txtCiudad.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Appearance.Options.UseFont = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 319);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(38, 13);
            this.lblEstado.TabIndex = 97;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstados
            // 
            this.cbEstados.Location = new System.Drawing.Point(137, 315);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstados.MenuManager = this.mainRibbonControl;
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbEstados.Size = new System.Drawing.Size(255, 24);
            this.cbEstados.TabIndex = 11;
            // 
            // lblPais
            // 
            this.lblPais.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPais.Appearance.Options.UseFont = true;
            this.lblPais.Location = new System.Drawing.Point(17, 285);
            this.lblPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 13);
            this.lblPais.TabIndex = 95;
            this.lblPais.Text = "País";
            // 
            // cbPaises
            // 
            this.cbPaises.Location = new System.Drawing.Point(137, 281);
            this.cbPaises.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPaises.MenuManager = this.mainRibbonControl;
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaises.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPaises.Size = new System.Drawing.Size(255, 24);
            this.cbPaises.TabIndex = 10;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Location = new System.Drawing.Point(17, 251);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(58, 17);
            this.lblMunicipio.TabIndex = 92;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(137, 247);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMunicipio.MenuManager = this.mainRibbonControl;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMunicipio.Properties.MaxLength = 100;
            this.txtMunicipio.Size = new System.Drawing.Size(552, 24);
            this.txtMunicipio.TabIndex = 9;
            // 
            // lblColonia
            // 
            this.lblColonia.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblColonia.Appearance.Options.UseFont = true;
            this.lblColonia.Location = new System.Drawing.Point(17, 217);
            this.lblColonia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(41, 13);
            this.lblColonia.TabIndex = 90;
            this.lblColonia.Text = "Colonia";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(137, 213);
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
            this.lblNumeroInterior.Location = new System.Drawing.Point(17, 115);
            this.lblNumeroInterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(66, 17);
            this.lblNumeroInterior.TabIndex = 88;
            this.lblNumeroInterior.Text = "No. Interior";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(137, 111);
            this.txtNumeroInterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroInterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroInterior.Properties.MaxLength = 100;
            this.txtNumeroInterior.Size = new System.Drawing.Size(128, 24);
            this.txtNumeroInterior.TabIndex = 4;
            // 
            // lblNumeroExterior
            // 
            this.lblNumeroExterior.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroExterior.Appearance.Options.UseFont = true;
            this.lblNumeroExterior.Location = new System.Drawing.Point(17, 81);
            this.lblNumeroExterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroExterior.Name = "lblNumeroExterior";
            this.lblNumeroExterior.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroExterior.TabIndex = 86;
            this.lblNumeroExterior.Text = "No. Exterior";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Location = new System.Drawing.Point(137, 77);
            this.txtNumeroExterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroExterior.MenuManager = this.mainRibbonControl;
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumeroExterior.Properties.MaxLength = 100;
            this.txtNumeroExterior.Size = new System.Drawing.Size(128, 24);
            this.txtNumeroExterior.TabIndex = 2;
            // 
            // lblCalle
            // 
            this.lblCalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCalle.Appearance.Options.UseFont = true;
            this.lblCalle.Location = new System.Drawing.Point(17, 47);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(27, 13);
            this.lblCalle.TabIndex = 84;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(137, 43);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalle.MenuManager = this.mainRibbonControl;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCalle.Properties.MaxLength = 100;
            this.txtCalle.Size = new System.Drawing.Size(552, 24);
            this.txtCalle.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 13);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 9);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Properties.NullValuePrompt = "Nombre de la dirección Ej. Trabajo";
            this.txtNombre.Size = new System.Drawing.Size(552, 24);
            this.txtNombre.TabIndex = 0;
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
            this.dataLayoutControl1.Size = new System.Drawing.Size(733, 414);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // frmDireccion
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(733, 493);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDireccion";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dirección";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntreCalles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaises.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}