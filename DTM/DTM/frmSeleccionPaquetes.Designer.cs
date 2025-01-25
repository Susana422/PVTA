using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;


namespace DTM
{
    partial class frmSeleccionPaquetes
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
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRestablecer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.splitContainerControlComanda = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControlArticulos = new DevExpress.XtraEditors.SplitContainerControl();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.tlo = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerControlPartidas = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMonedas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ts = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda.Panel1)).BeginInit();
            this.splitContainerControlComanda.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda.Panel2)).BeginInit();
            this.splitContainerControlComanda.Panel2.SuspendLayout();
            this.splitContainerControlComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos.Panel1)).BeginInit();
            this.splitContainerControlArticulos.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos.Panel2)).BeginInit();
            this.splitContainerControlArticulos.Panel2.SuspendLayout();
            this.splitContainerControlArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas.Panel1)).BeginInit();
            this.splitContainerControlPartidas.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas.Panel2)).BeginInit();
            this.splitContainerControlPartidas.Panel2.SuspendLayout();
            this.splitContainerControlPartidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRestablecer,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(931, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiGuardarNuevo
            // 
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            // 
            // bbiRestablecer
            // 
            this.bbiRestablecer.Id = 1;
            this.bbiRestablecer.Name = "bbiRestablecer";
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
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
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
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.splitContainerControlComanda);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(931, 704);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // splitContainerControlComanda
            // 
            this.splitContainerControlComanda.Location = new System.Drawing.Point(7, 8);
            this.splitContainerControlComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControlComanda.Name = "splitContainerControlComanda";
            // 
            // splitContainerControlComanda.Panel1
            // 
            this.splitContainerControlComanda.Panel1.Controls.Add(this.splitContainerControlArticulos);
            this.splitContainerControlComanda.Panel1.Text = "Panel1";
            // 
            // splitContainerControlComanda.Panel2
            // 
            this.splitContainerControlComanda.Panel2.Controls.Add(this.splitContainerControlPartidas);
            this.splitContainerControlComanda.Panel2.Text = "Panel2";
            this.splitContainerControlComanda.Size = new System.Drawing.Size(917, 688);
            this.splitContainerControlComanda.SplitterPosition = 435;
            this.splitContainerControlComanda.TabIndex = 4;
            this.splitContainerControlComanda.Text = "splitContainerControl1";
            // 
            // splitContainerControlArticulos
            // 
            this.splitContainerControlArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlArticulos.Horizontal = false;
            this.splitContainerControlArticulos.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControlArticulos.Name = "splitContainerControlArticulos";
            // 
            // splitContainerControlArticulos.Panel1
            // 
            this.splitContainerControlArticulos.Panel1.Controls.Add(this.tlp);
            this.splitContainerControlArticulos.Panel1.Text = "Panel1";
            // 
            // splitContainerControlArticulos.Panel2
            // 
            this.splitContainerControlArticulos.Panel2.AutoScroll = true;
            this.splitContainerControlArticulos.Panel2.Controls.Add(this.tlo);
            this.splitContainerControlArticulos.Panel2.Text = "Panel2";
            this.splitContainerControlArticulos.Size = new System.Drawing.Size(435, 688);
            this.splitContainerControlArticulos.SplitterPosition = 122;
            this.splitContainerControlArticulos.TabIndex = 0;
            this.splitContainerControlArticulos.Text = "splitContainerControl2";
            // 
            // tlp
            // 
            this.tlp.AutoScroll = true;
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(435, 122);
            this.tlp.TabIndex = 2;
            // 
            // tlo
            // 
            this.tlo.AutoScroll = true;
            this.tlo.ColumnCount = 3;
            this.tlo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlo.Location = new System.Drawing.Point(0, 0);
            this.tlo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlo.Name = "tlo";
            this.tlo.RowCount = 1;
            this.tlo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlo.Size = new System.Drawing.Size(435, 556);
            this.tlo.TabIndex = 1;
            // 
            // splitContainerControlPartidas
            // 
            this.splitContainerControlPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlPartidas.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControlPartidas.Horizontal = false;
            this.splitContainerControlPartidas.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControlPartidas.Name = "splitContainerControlPartidas";
            // 
            // splitContainerControlPartidas.Panel1
            // 
            this.splitContainerControlPartidas.Panel1.Controls.Add(this.gcPartidas);
            this.splitContainerControlPartidas.Panel1.Text = "Panel1";
            // 
            // splitContainerControlPartidas.Panel2
            // 
            this.splitContainerControlPartidas.Panel2.Controls.Add(this.ts);
            this.splitContainerControlPartidas.Panel2.Controls.Add(this.lblArticulo);
            this.splitContainerControlPartidas.Panel2.Controls.Add(this.label1);
            this.splitContainerControlPartidas.Panel2.MinSize = 55;
            this.splitContainerControlPartidas.Panel2.Text = "Panel2";
            this.splitContainerControlPartidas.Size = new System.Drawing.Size(472, 688);
            this.splitContainerControlPartidas.SplitterPosition = 72;
            this.splitContainerControlPartidas.TabIndex = 0;
            this.splitContainerControlPartidas.Text = "splitContainerControl1";
            // 
            // gcPartidas
            // 
            this.gcPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPartidas.Location = new System.Drawing.Point(0, 0);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbMonedas});
            this.gcPartidas.Size = new System.Drawing.Size(472, 606);
            this.gcPartidas.TabIndex = 3;
            this.gcPartidas.TabStop = false;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartidas});
            // 
            // gvPartidas
            // 
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCantidad,
            this.gridColumnNombre,
            this.gridColumnPrecio});
            this.gvPartidas.DetailHeight = 458;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvPartidas.OptionsView.ShowFooter = true;
            this.gvPartidas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.Caption = "Cant";
            this.gridColumnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MaxWidth = 47;
            this.gridColumnCantidad.MinWidth = 47;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 0;
            this.gridColumnCantidad.Width = 47;
            // 
            // gridColumnNombre
            // 
            this.gridColumnNombre.Caption = "Opción";
            this.gridColumnNombre.FieldName = "nombre";
            this.gridColumnNombre.MinWidth = 117;
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.OptionsColumn.AllowEdit = false;
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 1;
            this.gridColumnNombre.Width = 140;
            // 
            // gridColumnPrecio
            // 
            this.gridColumnPrecio.Caption = "Precio";
            this.gridColumnPrecio.DisplayFormat.FormatString = "c2";
            this.gridColumnPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecio.FieldName = "gridColumnPrecio";
            this.gridColumnPrecio.MinWidth = 70;
            this.gridColumnPrecio.Name = "gridColumnPrecio";
            this.gridColumnPrecio.OptionsColumn.AllowEdit = false;
            this.gridColumnPrecio.UnboundExpression = "precio * tipo_cambio";
            this.gridColumnPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPrecio.Width = 70;
            // 
            // cbMonedas
            // 
            this.cbMonedas.AutoHeight = false;
            this.cbMonedas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMonedas.Name = "cbMonedas";
            // 
            // ts
            // 
            this.ts.EditValue = true;
            this.ts.Location = new System.Drawing.Point(342, 0);
            this.ts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ts.MenuManager = this.mainRibbonControl;
            this.ts.Name = "ts";
            this.ts.Properties.OffText = "Quitar";
            this.ts.Properties.OnText = "Agregar";
            this.ts.Size = new System.Drawing.Size(111, 21);
            this.ts.TabIndex = 2;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblArticulo.Location = new System.Drawing.Point(4, 34);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(51, 13);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Artículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones seleccionadas";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(931, 704);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.splitContainerControlComanda;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(919, 690);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmSeleccionPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 783);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSeleccionPaquetes";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar opcionales";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda.Panel1)).EndInit();
            this.splitContainerControlComanda.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda.Panel2)).EndInit();
            this.splitContainerControlComanda.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlComanda)).EndInit();
            this.splitContainerControlComanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos.Panel1)).EndInit();
            this.splitContainerControlArticulos.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos.Panel2)).EndInit();
            this.splitContainerControlArticulos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlArticulos)).EndInit();
            this.splitContainerControlArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas.Panel1)).EndInit();
            this.splitContainerControlPartidas.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas.Panel2)).EndInit();
            this.splitContainerControlPartidas.Panel2.ResumeLayout(false);
            this.splitContainerControlPartidas.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlPartidas)).EndInit();
            this.splitContainerControlPartidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}