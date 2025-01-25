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
using NetsuiteLibrary.SuiteTalk_Helpers;
using Padding = System.Windows.Forms.Padding;


namespace DTM
{
    partial class frmAltaRapidaSocioEventual
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
            this.cbRegimenFiscal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRegimenFiscal = new DevExpress.XtraEditors.LabelControl();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.lblCP = new DevExpress.XtraEditors.LabelControl();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
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
            this.mainRibbonControl.Size = new System.Drawing.Size(613, 79);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(613, 238);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(605, 230);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbRegimenFiscal);
            this.panelControl1.Controls.Add(this.lblRegimenFiscal);
            this.panelControl1.Controls.Add(this.cbUsoPrincipal);
            this.panelControl1.Controls.Add(this.lblUsoPrincipal);
            this.panelControl1.Controls.Add(this.lblCP);
            this.panelControl1.Controls.Add(this.txtCP);
            this.panelControl1.Controls.Add(this.lblCorreo);
            this.panelControl1.Controls.Add(this.txtCorreo);
            this.panelControl1.Controls.Add(this.lblRFC);
            this.panelControl1.Controls.Add(this.txtRFC);
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(603, 228);
            this.panelControl1.TabIndex = 4;
            // 
            // cbRegimenFiscal
            // 
            this.cbRegimenFiscal.Location = new System.Drawing.Point(132, 143);
            this.cbRegimenFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRegimenFiscal.MenuManager = this.mainRibbonControl;
            this.cbRegimenFiscal.Name = "cbRegimenFiscal";
            this.cbRegimenFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRegimenFiscal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("clave", "Clave", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRegimenFiscal.Size = new System.Drawing.Size(255, 24);
            this.cbRegimenFiscal.TabIndex = 111;
            this.cbRegimenFiscal.TabStop = false;
            // 
            // lblRegimenFiscal
            // 
            this.lblRegimenFiscal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblRegimenFiscal.Appearance.Options.UseFont = true;
            this.lblRegimenFiscal.Location = new System.Drawing.Point(12, 147);
            this.lblRegimenFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRegimenFiscal.Name = "lblRegimenFiscal";
            this.lblRegimenFiscal.Size = new System.Drawing.Size(82, 13);
            this.lblRegimenFiscal.TabIndex = 108;
            this.lblRegimenFiscal.Text = "Régimen fiscal";
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(356, 77);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUsoPrincipal.MenuManager = this.mainRibbonControl;
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(210, 24);
            this.cbUsoPrincipal.TabIndex = 104;
            this.cbUsoPrincipal.TabStop = false;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsoPrincipal.Appearance.Options.UseFont = true;
            this.lblUsoPrincipal.Location = new System.Drawing.Point(280, 81);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(72, 13);
            this.lblUsoPrincipal.TabIndex = 103;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // lblCP
            // 
            this.lblCP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCP.Appearance.Options.UseFont = true;
            this.lblCP.Location = new System.Drawing.Point(12, 81);
            this.lblCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(20, 13);
            this.lblCP.TabIndex = 101;
            this.lblCP.Text = "C.P.";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(132, 77);
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
            // lblCorreo
            // 
            this.lblCorreo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Appearance.Options.UseFont = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 115);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 80;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(132, 111);
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
            // lblRFC
            // 
            this.lblRFC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRFC.Appearance.Options.UseFont = true;
            this.lblRFC.Location = new System.Drawing.Point(12, 13);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(21, 13);
            this.lblRFC.TabIndex = 77;
            this.lblRFC.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(132, 9);
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
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Properties.NullValuePrompt = "Nombre del socio";
            this.txtNombre.Size = new System.Drawing.Size(434, 24);
            this.txtNombre.TabIndex = 3;
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
            this.dataLayoutControl1.Size = new System.Drawing.Size(613, 238);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // frmAltaRapidaSocioEventual
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(613, 317);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaRapidaSocioEventual";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta rápida de socio eventual";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegimenFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}