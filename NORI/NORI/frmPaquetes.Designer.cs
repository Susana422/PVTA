using System;
using System.Collections.Generic;
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


namespace NORI
{
    partial class frmPaquetes
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
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
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
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaximo = new DevExpress.XtraEditors.LabelControl();
            this.txtMaximo = new DevExpress.XtraEditors.TextEdit();
            this.lblMinimo = new DevExpress.XtraEditors.LabelControl();
            this.txtMinimo = new DevExpress.XtraEditors.TextEdit();
            this.gcLineas = new DevExpress.XtraGrid.GridControl();
            this.gvLineas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leArticulos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOpcional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lseArticulos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbConjunto = new DevExpress.XtraEditors.CheckEdit();
            this.cbProduccion = new DevExpress.XtraEditors.CheckEdit();
            this.lblArticulo = new DevExpress.XtraEditors.LabelControl();
            this.lblPorcion = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcion = new DevExpress.XtraEditors.TextEdit();
            this.cbArticulos = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lseArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConjunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
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
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(668, 79);
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
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(399, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(7, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(14, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(255, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(559, 435);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(399, 435);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaximo);
            this.panel1.Controls.Add(this.txtMaximo);
            this.panel1.Controls.Add(this.lblMinimo);
            this.panel1.Controls.Add(this.txtMinimo);
            this.panel1.Controls.Add(this.gcLineas);
            this.panel1.Controls.Add(this.cbConjunto);
            this.panel1.Controls.Add(this.cbProduccion);
            this.panel1.Controls.Add(this.lblArticulo);
            this.panel1.Controls.Add(this.lblPorcion);
            this.panel1.Controls.Add(this.txtPorcion);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.cbArticulos);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 460);
            this.panel1.TabIndex = 53;
            // 
            // lblMaximo
            // 
            this.lblMaximo.Location = new System.Drawing.Point(468, 90);
            this.lblMaximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(47, 17);
            this.lblMaximo.TabIndex = 64;
            this.lblMaximo.Text = "Máximo";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(523, 86);
            this.txtMaximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaximo.MenuManager = this.mainRibbonControl;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMaximo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMaximo.Properties.Mask.EditMask = "n";
            this.txtMaximo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaximo.Size = new System.Drawing.Size(102, 24);
            this.txtMaximo.TabIndex = 63;
            // 
            // lblMinimo
            // 
            this.lblMinimo.Location = new System.Drawing.Point(468, 58);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(43, 17);
            this.lblMinimo.TabIndex = 62;
            this.lblMinimo.Text = "Mínimo";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(523, 54);
            this.txtMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinimo.MenuManager = this.mainRibbonControl;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMinimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMinimo.Properties.Mask.EditMask = "n";
            this.txtMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMinimo.Size = new System.Drawing.Size(102, 24);
            this.txtMinimo.TabIndex = 61;
            // 
            // gcLineas
            // 
            this.gcLineas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcLineas.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcLineas_EmbeddedNavigator_ButtonClick);
            this.gcLineas.Location = new System.Drawing.Point(14, 119);
            this.gcLineas.MainView = this.gvLineas;
            this.gcLineas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLineas.MenuManager = this.mainRibbonControl;
            this.gcLineas.Name = "gcLineas";
            this.gcLineas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lseArticulos,
            this.leArticulos});
            this.gcLineas.Size = new System.Drawing.Size(610, 301);
            this.gcLineas.TabIndex = 60;
            this.gcLineas.UseEmbeddedNavigator = true;
            this.gcLineas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLineas});
            // 
            // gvLineas
            // 
            this.gvLineas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnArticulo,
            this.gridColumnNombre,
            this.gridColumnMinimo,
            this.gridColumnMaximo,
            this.gridColumnOpcional});
            this.gvLineas.DetailHeight = 458;
            this.gvLineas.GridControl = this.gcLineas;
            this.gvLineas.Name = "gvLineas";
            this.gvLineas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvLineas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvLineas.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvLineas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvLineas.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvLineas_InitNewRow);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 23;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Width = 131;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.ColumnEdit = this.leArticulos;
            this.gridColumnArticulo.FieldName = "articulo_id";
            this.gridColumnArticulo.MinWidth = 23;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 0;
            this.gridColumnArticulo.Width = 131;
            // 
            // leArticulos
            // 
            this.leArticulos.AutoHeight = false;
            this.leArticulos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leArticulos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sku", "SKU", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leArticulos.Name = "leArticulos";
            // 
            // gridColumnNombre
            // 
            this.gridColumnNombre.Caption = "Nombre";
            this.gridColumnNombre.FieldName = "nombre";
            this.gridColumnNombre.MinWidth = 23;
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 1;
            this.gridColumnNombre.Width = 87;
            // 
            // gridColumnMinimo
            // 
            this.gridColumnMinimo.Caption = "Mínimo";
            this.gridColumnMinimo.FieldName = "minimo";
            this.gridColumnMinimo.MinWidth = 23;
            this.gridColumnMinimo.Name = "gridColumnMinimo";
            this.gridColumnMinimo.Visible = true;
            this.gridColumnMinimo.VisibleIndex = 2;
            this.gridColumnMinimo.Width = 131;
            // 
            // gridColumnMaximo
            // 
            this.gridColumnMaximo.Caption = "Máximo";
            this.gridColumnMaximo.FieldName = "maximo";
            this.gridColumnMaximo.MinWidth = 23;
            this.gridColumnMaximo.Name = "gridColumnMaximo";
            this.gridColumnMaximo.Visible = true;
            this.gridColumnMaximo.VisibleIndex = 3;
            this.gridColumnMaximo.Width = 131;
            // 
            // gridColumnOpcional
            // 
            this.gridColumnOpcional.Caption = "Opcional";
            this.gridColumnOpcional.FieldName = "opcional";
            this.gridColumnOpcional.MinWidth = 23;
            this.gridColumnOpcional.Name = "gridColumnOpcional";
            this.gridColumnOpcional.Visible = true;
            this.gridColumnOpcional.VisibleIndex = 4;
            this.gridColumnOpcional.Width = 87;
            // 
            // lseArticulos
            // 
            this.lseArticulos.AutoHeight = false;
            this.lseArticulos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lseArticulos.Name = "lseArticulos";
            this.lseArticulos.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 458;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 933;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbConjunto
            // 
            this.cbConjunto.Location = new System.Drawing.Point(368, 86);
            this.cbConjunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConjunto.MenuManager = this.mainRibbonControl;
            this.cbConjunto.Name = "cbConjunto";
            this.cbConjunto.Properties.Caption = "Conjunto";
            this.cbConjunto.Size = new System.Drawing.Size(88, 21);
            this.cbConjunto.TabIndex = 5;
            // 
            // cbProduccion
            // 
            this.cbProduccion.Location = new System.Drawing.Point(273, 86);
            this.cbProduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProduccion.MenuManager = this.mainRibbonControl;
            this.cbProduccion.Name = "cbProduccion";
            this.cbProduccion.Properties.Caption = "Producción";
            this.cbProduccion.Size = new System.Drawing.Size(88, 21);
            this.cbProduccion.TabIndex = 4;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Location = new System.Drawing.Point(14, 21);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(47, 17);
            this.lblArticulo.TabIndex = 59;
            this.lblArticulo.Text = "Artículo";
            // 
            // lblPorcion
            // 
            this.lblPorcion.Location = new System.Drawing.Point(14, 89);
            this.lblPorcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPorcion.Name = "lblPorcion";
            this.lblPorcion.Size = new System.Drawing.Size(45, 17);
            this.lblPorcion.TabIndex = 55;
            this.lblPorcion.Text = "Porción";
            // 
            // txtPorcion
            // 
            this.txtPorcion.Location = new System.Drawing.Point(133, 86);
            this.txtPorcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorcion.MenuManager = this.mainRibbonControl;
            this.txtPorcion.Name = "txtPorcion";
            this.txtPorcion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcion.Properties.Mask.EditMask = "n3";
            this.txtPorcion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcion.Size = new System.Drawing.Size(133, 24);
            this.txtPorcion.TabIndex = 3;
            // 
            // cbArticulos
            // 
            this.cbArticulos.Location = new System.Drawing.Point(133, 18);
            this.cbArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbArticulos.MenuManager = this.mainRibbonControl;
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbArticulos.Properties.NullText = "[Vacío]";
            this.cbArticulos.Size = new System.Drawing.Size(255, 24);
            this.cbArticulos.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(668, 511);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(668, 511);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 590);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPaquetes";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paquetes";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lseArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConjunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}