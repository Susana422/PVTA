using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSDK;

namespace NORI
{
    partial class frmActivosFijos
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
            this.bbiUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSocios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbPropietarios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPropietarios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblFabricantes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbFabricantes = new DevExpress.XtraEditors.LookUpEdit();
            this.cbGruposArticulos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblGrupoArticulos = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblFechaAdquisicion = new DevExpress.XtraEditors.LabelControl();
            this.deFechaAdquisicion = new DevExpress.XtraEditors.DateEdit();
            this.txtComentario = new DevExpress.XtraEditors.TextEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.lblSerie = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.lblModelo = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropietarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAdquisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAdquisicion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35);
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
            this.bbiNuevo,
            this.bbiUsuarios});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(657, 78);
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
            // bbiUsuarios
            // 
            this.bbiUsuarios.Caption = "Usuarios";
            this.bbiUsuarios.Id = 2;
            this.bbiUsuarios.ImageOptions.ImageUri.Uri = "ListBullets";
            this.bbiUsuarios.Name = "bbiUsuarios";
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 78);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(657, 447);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbSocios);
            this.panelControl1.Controls.Add(this.lblSocios);
            this.panelControl1.Controls.Add(this.cbPropietarios);
            this.panelControl1.Controls.Add(this.lblPropietarios);
            this.panelControl1.Controls.Add(this.lblFabricantes);
            this.panelControl1.Controls.Add(this.cbFabricantes);
            this.panelControl1.Controls.Add(this.cbGruposArticulos);
            this.panelControl1.Controls.Add(this.lblGrupoArticulos);
            this.panelControl1.Controls.Add(this.lblFechaAdquisicion);
            this.panelControl1.Controls.Add(this.deFechaAdquisicion);
            this.panelControl1.Controls.Add(this.txtComentario);
            this.panelControl1.Controls.Add(this.lblComentario);
            this.panelControl1.Controls.Add(this.txtSerie);
            this.panelControl1.Controls.Add(this.lblSerie);
            this.panelControl1.Controls.Add(this.txtModelo);
            this.panelControl1.Controls.Add(this.lblModelo);
            this.panelControl1.Controls.Add(this.txtMarca);
            this.panelControl1.Controls.Add(this.lblMarca);
            this.panelControl1.Controls.Add(this.txtDescripcion);
            this.panelControl1.Controls.Add(this.lblDescripcion);
            this.panelControl1.Controls.Add(this.lblFechaActualizacion);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Controls.Add(this.lblUltimaActualizacion);
            this.panelControl1.Controls.Add(this.txtCodigo);
            this.panelControl1.Controls.Add(this.lblCodigo);
            this.panelControl1.Controls.Add(this.cbActivo);
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.lblID);
            this.panelControl1.Location = new System.Drawing.Point(7, 7);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(643, 433);
            this.panelControl1.TabIndex = 4;
            // 
            // cbSocios
            // 
            this.cbSocios.Location = new System.Drawing.Point(125, 160);
            this.cbSocios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSocios.MenuManager = this.mainRibbonControl;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSocios.Size = new System.Drawing.Size(255, 22);
            this.cbSocios.TabIndex = 97;
            // 
            // lblSocios
            // 
            this.lblSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSocios.Location = new System.Drawing.Point(6, 162);
            this.lblSocios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(29, 15);
            this.lblSocios.TabIndex = 98;
            this.lblSocios.Text = "Socio";
            // 
            // cbPropietarios
            // 
            this.cbPropietarios.Location = new System.Drawing.Point(125, 130);
            this.cbPropietarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPropietarios.MenuManager = this.mainRibbonControl;
            this.cbPropietarios.Name = "cbPropietarios";
            this.cbPropietarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPropietarios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbPropietarios.Size = new System.Drawing.Size(255, 22);
            this.cbPropietarios.TabIndex = 95;
            // 
            // lblPropietarios
            // 
            this.lblPropietarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPropietarios.Location = new System.Drawing.Point(6, 135);
            this.lblPropietarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPropietarios.Name = "lblPropietarios";
            this.lblPropietarios.Size = new System.Drawing.Size(58, 15);
            this.lblPropietarios.TabIndex = 96;
            this.lblPropietarios.Text = "Propietario";
            // 
            // lblFabricantes
            // 
            this.lblFabricantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFabricantes.Location = new System.Drawing.Point(6, 104);
            this.lblFabricantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblFabricantes.Name = "lblFabricantes";
            this.lblFabricantes.Size = new System.Drawing.Size(55, 15);
            this.lblFabricantes.TabIndex = 75;
            this.lblFabricantes.Text = "Fabricante";
            // 
            // cbFabricantes
            // 
            this.cbFabricantes.Location = new System.Drawing.Point(125, 100);
            this.cbFabricantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFabricantes.MenuManager = this.mainRibbonControl;
            this.cbFabricantes.Name = "cbFabricantes";
            this.cbFabricantes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFabricantes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbFabricantes.Size = new System.Drawing.Size(255, 22);
            this.cbFabricantes.TabIndex = 74;
            // 
            // cbGruposArticulos
            // 
            this.cbGruposArticulos.Location = new System.Drawing.Point(125, 70);
            this.cbGruposArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGruposArticulos.MenuManager = this.mainRibbonControl;
            this.cbGruposArticulos.Name = "cbGruposArticulos";
            this.cbGruposArticulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGruposArticulos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbGruposArticulos.Size = new System.Drawing.Size(255, 22);
            this.cbGruposArticulos.TabIndex = 72;
            // 
            // lblGrupoArticulos
            // 
            this.lblGrupoArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGrupoArticulos.Location = new System.Drawing.Point(6, 74);
            this.lblGrupoArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGrupoArticulos.Name = "lblGrupoArticulos";
            this.lblGrupoArticulos.Size = new System.Drawing.Size(97, 15);
            this.lblGrupoArticulos.TabIndex = 73;
            this.lblGrupoArticulos.Text = "Grupo de artículos";
            // 
            // lblFechaAdquisicion
            // 
            this.lblFechaAdquisicion.Location = new System.Drawing.Point(6, 344);
            this.lblFechaAdquisicion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblFechaAdquisicion.Name = "lblFechaAdquisicion";
            this.lblFechaAdquisicion.Size = new System.Drawing.Size(95, 15);
            this.lblFechaAdquisicion.TabIndex = 71;
            this.lblFechaAdquisicion.Text = "Fecha adquisición";
            // 
            // deFechaAdquisicion
            // 
            this.deFechaAdquisicion.EditValue = null;
            this.deFechaAdquisicion.Location = new System.Drawing.Point(125, 340);
            this.deFechaAdquisicion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deFechaAdquisicion.MenuManager = this.mainRibbonControl;
            this.deFechaAdquisicion.Name = "deFechaAdquisicion";
            this.deFechaAdquisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaAdquisicion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaAdquisicion.Size = new System.Drawing.Size(255, 22);
            this.deFechaAdquisicion.TabIndex = 70;
            // 
            // txtComentario
            // 
            this.txtComentario.AllowDrop = true;
            this.txtComentario.Location = new System.Drawing.Point(125, 310);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.MaxLength = 100;
            this.txtComentario.Size = new System.Drawing.Size(491, 22);
            this.txtComentario.TabIndex = 68;
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(6, 314);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 15);
            this.lblComentario.TabIndex = 69;
            this.lblComentario.Text = "Comentario";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(125, 190);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSerie.MenuManager = this.mainRibbonControl;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.MaxLength = 100;
            this.txtSerie.Size = new System.Drawing.Size(491, 22);
            this.txtSerie.TabIndex = 66;
            // 
            // lblSerie
            // 
            this.lblSerie.Location = new System.Drawing.Point(6, 194);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(25, 15);
            this.lblSerie.TabIndex = 67;
            this.lblSerie.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(125, 280);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModelo.MenuManager = this.mainRibbonControl;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.MaxLength = 100;
            this.txtModelo.Size = new System.Drawing.Size(255, 22);
            this.txtModelo.TabIndex = 64;
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(6, 284);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(41, 15);
            this.lblModelo.TabIndex = 65;
            this.lblModelo.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(125, 250);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMarca.MenuManager = this.mainRibbonControl;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.MaxLength = 100;
            this.txtMarca.Size = new System.Drawing.Size(255, 22);
            this.txtMarca.TabIndex = 62;
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(6, 254);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(33, 15);
            this.lblMarca.TabIndex = 63;
            this.lblMarca.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(125, 220);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.MenuManager = this.mainRibbonControl;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(491, 22);
            this.txtDescripcion.TabIndex = 60;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(6, 224);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(62, 15);
            this.lblDescripcion.TabIndex = 61;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(551, 382);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(58, 15);
            this.lblFechaActualizacion.TabIndex = 59;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(491, 22);
            this.txtNombre.TabIndex = 53;
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(391, 382);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(109, 15);
            this.lblUltimaActualizacion.TabIndex = 58;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 10);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 20;
            this.txtCodigo.Size = new System.Drawing.Size(255, 22);
            this.txtCodigo.TabIndex = 52;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(6, 14);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 15);
            this.lblCodigo.TabIndex = 55;
            this.lblCodigo.Text = "Código";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(6, 378);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(140, 19);
            this.cbActivo.TabIndex = 54;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 15);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(391, 14);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(6, 15);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "0";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(657, 447);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(645, 435);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 525);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmActivosFijos";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos fijos";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPropietarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFabricantes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAdquisicion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAdquisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}