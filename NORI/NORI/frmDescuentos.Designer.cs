using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Export;
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
using DevExpress.XtraTab;

namespace NORI
{
    partial class frmDescuentos
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
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblEID = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPorcentajeDescuento = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeDescuento = new DevExpress.XtraEditors.TextEdit();
            this.cbListaPrecios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblListaPrecios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbAcumulable = new DevExpress.XtraEditors.CheckEdit();
            this.btnOrden = new DevExpress.XtraEditors.SimpleButton();
            this.rgArticulos = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.rgAlmacenes = new DevExpress.XtraEditors.RadioGroup();
            this.rgGruposArticulos = new DevExpress.XtraEditors.RadioGroup();
            this.rgSocios = new DevExpress.XtraEditors.RadioGroup();
            this.rgListasPrecios = new DevExpress.XtraEditors.RadioGroup();
            this.cbAlmacenes = new DevExpress.XtraEditors.CheckEdit();
            this.cbArticulos = new DevExpress.XtraEditors.CheckEdit();
            this.cbGruposArticulos = new DevExpress.XtraEditors.CheckEdit();
            this.cbSocios = new DevExpress.XtraEditors.CheckEdit();
            this.cbListasPrecios = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pcVolumen = new DevExpress.XtraEditors.PanelControl();
            this.gcCondiciones = new DevExpress.XtraGrid.GridControl();
            this.gvCondiciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageListaPrecios = new DevExpress.XtraTab.XtraTabPage();
            this.gcListasPrecios = new DevExpress.XtraGrid.GridControl();
            this.gvListasPrecios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnListaPrecioId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnListaPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageSociosNegocios = new DevExpress.XtraTab.XtraTabPage();
            this.gcSocios = new DevExpress.XtraGrid.GridControl();
            this.gvSocios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSocioId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageGruposArticulos = new DevExpress.XtraTab.XtraTabPage();
            this.gcGruposArticulos = new DevExpress.XtraGrid.GridControl();
            this.gvGruposArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnGrupoArticuloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGrupoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageAlmacenes = new DevExpress.XtraTab.XtraTabPage();
            this.gcAlmacenes = new DevExpress.XtraGrid.GridControl();
            this.gvAlmacenes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnAlmacenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageArticulos = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gcArticulos = new DevExpress.XtraGrid.GridControl();
            this.gvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnArticuloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImportarArticulos = new DevExpress.XtraEditors.SimpleButton();
            this.lblCondicionesPromocion = new DevExpress.XtraEditors.LabelControl();
            this.cbVIP = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipoDescuento = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTipoDescuento = new DevExpress.XtraEditors.LabelControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAcumulable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAlmacenes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgGruposArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgListasPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcVolumen)).BeginInit();
            this.pcVolumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCondiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCondiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageListaPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListasPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListasPrecios)).BeginInit();
            this.xtraTabPageSociosNegocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).BeginInit();
            this.xtraTabPageGruposArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGruposArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGruposArticulos)).BeginInit();
            this.xtraTabPageAlmacenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAlmacenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlmacenes)).BeginInit();
            this.xtraTabPageArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 27, 23, 27);
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
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 257;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(932, 79);
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
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(133, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(7, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(14, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(324, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblEID
            // 
            this.lblEID.Location = new System.Drawing.Point(14, 21);
            this.lblEID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(12, 17);
            this.lblEID.TabIndex = 44;
            this.lblEID.Text = "ID";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(14, 624);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(106, 21);
            this.cbActivo.TabIndex = 6;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(842, 630);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(683, 630);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPorcentajeDescuento);
            this.panel1.Controls.Add(this.txtPorcentajeDescuento);
            this.panel1.Controls.Add(this.cbListaPrecios);
            this.panel1.Controls.Add(this.lblListaPrecios);
            this.panel1.Controls.Add(this.cbAcumulable);
            this.panel1.Controls.Add(this.btnOrden);
            this.panel1.Controls.Add(this.rgArticulos);
            this.panel1.Controls.Add(this.rgAlmacenes);
            this.panel1.Controls.Add(this.rgGruposArticulos);
            this.panel1.Controls.Add(this.rgSocios);
            this.panel1.Controls.Add(this.rgListasPrecios);
            this.panel1.Controls.Add(this.cbAlmacenes);
            this.panel1.Controls.Add(this.cbArticulos);
            this.panel1.Controls.Add(this.cbGruposArticulos);
            this.panel1.Controls.Add(this.cbSocios);
            this.panel1.Controls.Add(this.cbListasPrecios);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.lblCondicionesPromocion);
            this.panel1.Controls.Add(this.cbVIP);
            this.panel1.Controls.Add(this.cbTipoDescuento);
            this.panel1.Controls.Add(this.lblTipoDescuento);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.lblEID);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 654);
            this.panel1.TabIndex = 53;
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(296, 122);
            this.lblPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(77, 17);
            this.lblPorcentajeDescuento.TabIndex = 75;
            this.lblPorcentajeDescuento.Text = "% Descuento";
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(413, 118);
            this.txtPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPorcentajeDescuento.MenuManager = this.mainRibbonControl;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Properties.DisplayFormat.FormatString = "P2";
            this.txtPorcentajeDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeDescuento.Properties.EditFormat.FormatString = "P2";
            this.txtPorcentajeDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPorcentajeDescuento.Properties.Mask.EditMask = "P2";
            this.txtPorcentajeDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(140, 24);
            this.txtPorcentajeDescuento.TabIndex = 76;
            // 
            // cbListaPrecios
            // 
            this.cbListaPrecios.Location = new System.Drawing.Point(133, 118);
            this.cbListaPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListaPrecios.MenuManager = this.mainRibbonControl;
            this.cbListaPrecios.Name = "cbListaPrecios";
            this.cbListaPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListaPrecios.Size = new System.Drawing.Size(156, 24);
            this.cbListaPrecios.TabIndex = 73;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Location = new System.Drawing.Point(16, 119);
            this.lblListaPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(93, 17);
            this.lblListaPrecios.TabIndex = 74;
            this.lblListaPrecios.Text = "Lista de precios";
            // 
            // cbAcumulable
            // 
            this.cbAcumulable.Location = new System.Drawing.Point(352, 84);
            this.cbAcumulable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAcumulable.MenuManager = this.mainRibbonControl;
            this.cbAcumulable.Name = "cbAcumulable";
            this.cbAcumulable.Properties.Caption = "Acumulable";
            this.cbAcumulable.Size = new System.Drawing.Size(106, 21);
            this.cbAcumulable.TabIndex = 72;
            // 
            // btnOrden
            // 
            this.btnOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrden.Location = new System.Drawing.Point(763, 113);
            this.btnOrden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(143, 28);
            this.btnOrden.TabIndex = 71;
            this.btnOrden.Text = "Orden de descuentos";
            // 
            // rgArticulos
            // 
            this.rgArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgArticulos.Location = new System.Drawing.Point(694, 42);
            this.rgArticulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rgArticulos.MenuManager = this.mainRibbonControl;
            this.rgArticulos.Name = "rgArticulos";
            this.rgArticulos.Properties.ColumnIndent = 0;
            this.rgArticulos.Properties.Columns = 4;
            this.rgArticulos.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgArticulos.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('Y', "Y"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "O")});
            this.rgArticulos.Size = new System.Drawing.Size(78, 31);
            this.rgArticulos.StyleController = this.layoutControl1;
            this.rgArticulos.TabIndex = 70;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(932, 715);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(932, 715);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // rgAlmacenes
            // 
            this.rgAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgAlmacenes.Location = new System.Drawing.Point(694, 11);
            this.rgAlmacenes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rgAlmacenes.MenuManager = this.mainRibbonControl;
            this.rgAlmacenes.Name = "rgAlmacenes";
            this.rgAlmacenes.Properties.ColumnIndent = 0;
            this.rgAlmacenes.Properties.Columns = 4;
            this.rgAlmacenes.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgAlmacenes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('Y', "Y"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "O")});
            this.rgAlmacenes.Size = new System.Drawing.Size(78, 31);
            this.rgAlmacenes.StyleController = this.layoutControl1;
            this.rgAlmacenes.TabIndex = 69;
            // 
            // rgGruposArticulos
            // 
            this.rgGruposArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgGruposArticulos.Location = new System.Drawing.Point(474, 74);
            this.rgGruposArticulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rgGruposArticulos.MenuManager = this.mainRibbonControl;
            this.rgGruposArticulos.Name = "rgGruposArticulos";
            this.rgGruposArticulos.Properties.ColumnIndent = 0;
            this.rgGruposArticulos.Properties.Columns = 4;
            this.rgGruposArticulos.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgGruposArticulos.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('Y', "Y"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "O")});
            this.rgGruposArticulos.Size = new System.Drawing.Size(78, 31);
            this.rgGruposArticulos.StyleController = this.layoutControl1;
            this.rgGruposArticulos.TabIndex = 68;
            // 
            // rgSocios
            // 
            this.rgSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgSocios.Location = new System.Drawing.Point(474, 42);
            this.rgSocios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rgSocios.MenuManager = this.mainRibbonControl;
            this.rgSocios.Name = "rgSocios";
            this.rgSocios.Properties.ColumnIndent = 0;
            this.rgSocios.Properties.Columns = 4;
            this.rgSocios.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgSocios.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('Y', "Y"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "O")});
            this.rgSocios.Size = new System.Drawing.Size(78, 31);
            this.rgSocios.StyleController = this.layoutControl1;
            this.rgSocios.TabIndex = 67;
            // 
            // rgListasPrecios
            // 
            this.rgListasPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgListasPrecios.Location = new System.Drawing.Point(474, 11);
            this.rgListasPrecios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rgListasPrecios.MenuManager = this.mainRibbonControl;
            this.rgListasPrecios.Name = "rgListasPrecios";
            this.rgListasPrecios.Properties.ColumnIndent = 0;
            this.rgListasPrecios.Properties.Columns = 4;
            this.rgListasPrecios.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgListasPrecios.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('Y', "Y"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "O")});
            this.rgListasPrecios.Size = new System.Drawing.Size(78, 31);
            this.rgListasPrecios.StyleController = this.layoutControl1;
            this.rgListasPrecios.TabIndex = 66;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenes.Location = new System.Drawing.Point(777, 16);
            this.cbAlmacenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlmacenes.MenuManager = this.mainRibbonControl;
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Properties.Caption = "Almacenes";
            this.cbAlmacenes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbAlmacenes.Size = new System.Drawing.Size(129, 21);
            this.cbAlmacenes.TabIndex = 65;
            // 
            // cbArticulos
            // 
            this.cbArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArticulos.Location = new System.Drawing.Point(777, 45);
            this.cbArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbArticulos.MenuManager = this.mainRibbonControl;
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Properties.Caption = "Artículos";
            this.cbArticulos.Size = new System.Drawing.Size(129, 21);
            this.cbArticulos.TabIndex = 64;
            // 
            // cbGruposArticulos
            // 
            this.cbGruposArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGruposArticulos.Location = new System.Drawing.Point(558, 77);
            this.cbGruposArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGruposArticulos.MenuManager = this.mainRibbonControl;
            this.cbGruposArticulos.Name = "cbGruposArticulos";
            this.cbGruposArticulos.Properties.Caption = "Grupos de artículos";
            this.cbGruposArticulos.Size = new System.Drawing.Size(140, 21);
            this.cbGruposArticulos.TabIndex = 63;
            // 
            // cbSocios
            // 
            this.cbSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSocios.Location = new System.Drawing.Point(558, 46);
            this.cbSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSocios.MenuManager = this.mainRibbonControl;
            this.cbSocios.Name = "cbSocios";
            this.cbSocios.Properties.Caption = "Socios de negocios";
            this.cbSocios.Size = new System.Drawing.Size(140, 21);
            this.cbSocios.TabIndex = 62;
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListasPrecios.Location = new System.Drawing.Point(558, 13);
            this.cbListasPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListasPrecios.MenuManager = this.mainRibbonControl;
            this.cbListasPrecios.Name = "cbListasPrecios";
            this.cbListasPrecios.Properties.Caption = "Listas de precios";
            this.cbListasPrecios.Size = new System.Drawing.Size(140, 21);
            this.cbListasPrecios.TabIndex = 61;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 178);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pcVolumen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(893, 420);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 60;
            // 
            // pcVolumen
            // 
            this.pcVolumen.Controls.Add(this.gcCondiciones);
            this.pcVolumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcVolumen.Location = new System.Drawing.Point(0, 0);
            this.pcVolumen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pcVolumen.Name = "pcVolumen";
            this.pcVolumen.Size = new System.Drawing.Size(296, 420);
            this.pcVolumen.TabIndex = 66;
            // 
            // gcCondiciones
            // 
            this.gcCondiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCondiciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcCondiciones.Location = new System.Drawing.Point(2, 2);
            this.gcCondiciones.MainView = this.gvCondiciones;
            this.gcCondiciones.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcCondiciones.MenuManager = this.mainRibbonControl;
            this.gcCondiciones.Name = "gcCondiciones";
            this.gcCondiciones.Size = new System.Drawing.Size(292, 416);
            this.gcCondiciones.TabIndex = 70;
            this.gcCondiciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCondiciones});
            // 
            // gvCondiciones
            // 
            this.gvCondiciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCantidad,
            this.gridColumnMonto,
            this.gridColumnDescuento});
            this.gvCondiciones.DetailHeight = 279;
            this.gvCondiciones.FixedLineWidth = 1;
            this.gvCondiciones.GridControl = this.gcCondiciones;
            this.gvCondiciones.Name = "gvCondiciones";
            this.gvCondiciones.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCondiciones.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCondiciones.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gvCondiciones.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gvCondiciones.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvCondiciones.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MinWidth = 18;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 0;
            this.gridColumnCantidad.Width = 68;
            // 
            // gridColumnMonto
            // 
            this.gridColumnMonto.Caption = "Monto";
            this.gridColumnMonto.DisplayFormat.FormatString = "n2";
            this.gridColumnMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnMonto.FieldName = "monto";
            this.gridColumnMonto.MinWidth = 18;
            this.gridColumnMonto.Name = "gridColumnMonto";
            this.gridColumnMonto.Visible = true;
            this.gridColumnMonto.VisibleIndex = 1;
            this.gridColumnMonto.Width = 68;
            // 
            // gridColumnDescuento
            // 
            this.gridColumnDescuento.Caption = "% Descuento";
            this.gridColumnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDescuento.FieldName = "porcentaje_descuento";
            this.gridColumnDescuento.MinWidth = 18;
            this.gridColumnDescuento.Name = "gridColumnDescuento";
            this.gridColumnDescuento.Visible = true;
            this.gridColumnDescuento.VisibleIndex = 2;
            this.gridColumnDescuento.Width = 68;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageListaPrecios;
            this.xtraTabControl1.Size = new System.Drawing.Size(594, 420);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageListaPrecios,
            this.xtraTabPageSociosNegocios,
            this.xtraTabPageGruposArticulos,
            this.xtraTabPageAlmacenes,
            this.xtraTabPageArticulos});
            // 
            // xtraTabPageListaPrecios
            // 
            this.xtraTabPageListaPrecios.Controls.Add(this.gcListasPrecios);
            this.xtraTabPageListaPrecios.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPageListaPrecios.Name = "xtraTabPageListaPrecios";
            this.xtraTabPageListaPrecios.PageEnabled = false;
            this.xtraTabPageListaPrecios.Size = new System.Drawing.Size(592, 395);
            this.xtraTabPageListaPrecios.Text = "Listas de precios";
            // 
            // gcListasPrecios
            // 
            this.gcListasPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListasPrecios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcListasPrecios.Location = new System.Drawing.Point(0, 0);
            this.gcListasPrecios.MainView = this.gvListasPrecios;
            this.gcListasPrecios.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcListasPrecios.MenuManager = this.mainRibbonControl;
            this.gcListasPrecios.Name = "gcListasPrecios";
            this.gcListasPrecios.Size = new System.Drawing.Size(592, 395);
            this.gcListasPrecios.TabIndex = 71;
            this.gcListasPrecios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListasPrecios});
            // 
            // gvListasPrecios
            // 
            this.gvListasPrecios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnListaPrecioId,
            this.gridColumnListaPrecio});
            this.gvListasPrecios.DetailHeight = 279;
            this.gvListasPrecios.FixedLineWidth = 1;
            this.gvListasPrecios.GridControl = this.gcListasPrecios;
            this.gvListasPrecios.Name = "gvListasPrecios";
            this.gvListasPrecios.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvListasPrecios.OptionsSelection.MultiSelect = true;
            this.gvListasPrecios.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnListaPrecioId
            // 
            this.gridColumnListaPrecioId.Caption = "Id";
            this.gridColumnListaPrecioId.FieldName = "id";
            this.gridColumnListaPrecioId.MinWidth = 18;
            this.gridColumnListaPrecioId.Name = "gridColumnListaPrecioId";
            this.gridColumnListaPrecioId.Width = 68;
            // 
            // gridColumnListaPrecio
            // 
            this.gridColumnListaPrecio.Caption = "Lista de precios";
            this.gridColumnListaPrecio.FieldName = "nombre";
            this.gridColumnListaPrecio.MinWidth = 18;
            this.gridColumnListaPrecio.Name = "gridColumnListaPrecio";
            this.gridColumnListaPrecio.Visible = true;
            this.gridColumnListaPrecio.VisibleIndex = 1;
            this.gridColumnListaPrecio.Width = 68;
            // 
            // xtraTabPageSociosNegocios
            // 
            this.xtraTabPageSociosNegocios.Controls.Add(this.gcSocios);
            this.xtraTabPageSociosNegocios.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPageSociosNegocios.Name = "xtraTabPageSociosNegocios";
            this.xtraTabPageSociosNegocios.PageEnabled = false;
            this.xtraTabPageSociosNegocios.Size = new System.Drawing.Size(459, 351);
            this.xtraTabPageSociosNegocios.Text = "Socios de negocios";
            // 
            // gcSocios
            // 
            this.gcSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSocios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcSocios.Location = new System.Drawing.Point(0, 0);
            this.gcSocios.MainView = this.gvSocios;
            this.gcSocios.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcSocios.MenuManager = this.mainRibbonControl;
            this.gcSocios.Name = "gcSocios";
            this.gcSocios.Size = new System.Drawing.Size(459, 351);
            this.gcSocios.TabIndex = 72;
            this.gcSocios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSocios});
            // 
            // gvSocios
            // 
            this.gvSocios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSocioId,
            this.gridColumnCodigoSocio,
            this.gridColumnNombreSocio});
            this.gvSocios.DetailHeight = 279;
            this.gvSocios.FixedLineWidth = 1;
            this.gvSocios.GridControl = this.gcSocios;
            this.gvSocios.Name = "gvSocios";
            this.gvSocios.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvSocios.OptionsSelection.MultiSelect = true;
            this.gvSocios.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnSocioId
            // 
            this.gridColumnSocioId.Caption = "Id";
            this.gridColumnSocioId.FieldName = "id";
            this.gridColumnSocioId.MinWidth = 18;
            this.gridColumnSocioId.Name = "gridColumnSocioId";
            this.gridColumnSocioId.Width = 68;
            // 
            // gridColumnCodigoSocio
            // 
            this.gridColumnCodigoSocio.Caption = "Código SN";
            this.gridColumnCodigoSocio.FieldName = "codigo";
            this.gridColumnCodigoSocio.MinWidth = 18;
            this.gridColumnCodigoSocio.Name = "gridColumnCodigoSocio";
            this.gridColumnCodigoSocio.Visible = true;
            this.gridColumnCodigoSocio.VisibleIndex = 1;
            this.gridColumnCodigoSocio.Width = 68;
            // 
            // gridColumnNombreSocio
            // 
            this.gridColumnNombreSocio.Caption = "Socio de negocios";
            this.gridColumnNombreSocio.FieldName = "nombre";
            this.gridColumnNombreSocio.MinWidth = 18;
            this.gridColumnNombreSocio.Name = "gridColumnNombreSocio";
            this.gridColumnNombreSocio.Visible = true;
            this.gridColumnNombreSocio.VisibleIndex = 2;
            this.gridColumnNombreSocio.Width = 68;
            // 
            // xtraTabPageGruposArticulos
            // 
            this.xtraTabPageGruposArticulos.Controls.Add(this.gcGruposArticulos);
            this.xtraTabPageGruposArticulos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPageGruposArticulos.Name = "xtraTabPageGruposArticulos";
            this.xtraTabPageGruposArticulos.PageEnabled = false;
            this.xtraTabPageGruposArticulos.Size = new System.Drawing.Size(459, 351);
            this.xtraTabPageGruposArticulos.Text = "Grupos de artículos";
            // 
            // gcGruposArticulos
            // 
            this.gcGruposArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGruposArticulos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcGruposArticulos.Location = new System.Drawing.Point(0, 0);
            this.gcGruposArticulos.MainView = this.gvGruposArticulos;
            this.gcGruposArticulos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcGruposArticulos.MenuManager = this.mainRibbonControl;
            this.gcGruposArticulos.Name = "gcGruposArticulos";
            this.gcGruposArticulos.Size = new System.Drawing.Size(459, 351);
            this.gcGruposArticulos.TabIndex = 73;
            this.gcGruposArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGruposArticulos});
            // 
            // gvGruposArticulos
            // 
            this.gvGruposArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnGrupoArticuloId,
            this.gridColumnGrupoArticulo});
            this.gvGruposArticulos.DetailHeight = 279;
            this.gvGruposArticulos.FixedLineWidth = 1;
            this.gvGruposArticulos.GridControl = this.gcGruposArticulos;
            this.gvGruposArticulos.Name = "gvGruposArticulos";
            this.gvGruposArticulos.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvGruposArticulos.OptionsSelection.MultiSelect = true;
            this.gvGruposArticulos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnGrupoArticuloId
            // 
            this.gridColumnGrupoArticuloId.Caption = "Id";
            this.gridColumnGrupoArticuloId.FieldName = "id";
            this.gridColumnGrupoArticuloId.MinWidth = 18;
            this.gridColumnGrupoArticuloId.Name = "gridColumnGrupoArticuloId";
            this.gridColumnGrupoArticuloId.Width = 68;
            // 
            // gridColumnGrupoArticulo
            // 
            this.gridColumnGrupoArticulo.Caption = "Grupo de artículos";
            this.gridColumnGrupoArticulo.FieldName = "nombre";
            this.gridColumnGrupoArticulo.MinWidth = 18;
            this.gridColumnGrupoArticulo.Name = "gridColumnGrupoArticulo";
            this.gridColumnGrupoArticulo.Visible = true;
            this.gridColumnGrupoArticulo.VisibleIndex = 1;
            this.gridColumnGrupoArticulo.Width = 68;
            // 
            // xtraTabPageAlmacenes
            // 
            this.xtraTabPageAlmacenes.Controls.Add(this.gcAlmacenes);
            this.xtraTabPageAlmacenes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPageAlmacenes.Name = "xtraTabPageAlmacenes";
            this.xtraTabPageAlmacenes.PageEnabled = false;
            this.xtraTabPageAlmacenes.Size = new System.Drawing.Size(459, 351);
            this.xtraTabPageAlmacenes.Text = "Almacenes";
            // 
            // gcAlmacenes
            // 
            this.gcAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAlmacenes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcAlmacenes.Location = new System.Drawing.Point(0, 0);
            this.gcAlmacenes.MainView = this.gvAlmacenes;
            this.gcAlmacenes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcAlmacenes.MenuManager = this.mainRibbonControl;
            this.gcAlmacenes.Name = "gcAlmacenes";
            this.gcAlmacenes.Size = new System.Drawing.Size(459, 351);
            this.gcAlmacenes.TabIndex = 74;
            this.gcAlmacenes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlmacenes});
            // 
            // gvAlmacenes
            // 
            this.gvAlmacenes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnAlmacenId,
            this.gridColumnAlmacen});
            this.gvAlmacenes.DetailHeight = 279;
            this.gvAlmacenes.FixedLineWidth = 1;
            this.gvAlmacenes.GridControl = this.gcAlmacenes;
            this.gvAlmacenes.Name = "gvAlmacenes";
            this.gvAlmacenes.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvAlmacenes.OptionsSelection.MultiSelect = true;
            this.gvAlmacenes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnAlmacenId
            // 
            this.gridColumnAlmacenId.Caption = "Id";
            this.gridColumnAlmacenId.FieldName = "id";
            this.gridColumnAlmacenId.MinWidth = 18;
            this.gridColumnAlmacenId.Name = "gridColumnAlmacenId";
            this.gridColumnAlmacenId.Width = 68;
            // 
            // gridColumnAlmacen
            // 
            this.gridColumnAlmacen.Caption = "Almacén";
            this.gridColumnAlmacen.FieldName = "nombre";
            this.gridColumnAlmacen.MinWidth = 18;
            this.gridColumnAlmacen.Name = "gridColumnAlmacen";
            this.gridColumnAlmacen.Visible = true;
            this.gridColumnAlmacen.VisibleIndex = 1;
            this.gridColumnAlmacen.Width = 68;
            // 
            // xtraTabPageArticulos
            // 
            this.xtraTabPageArticulos.Controls.Add(this.splitContainer2);
            this.xtraTabPageArticulos.Controls.Add(this.btnImportarArticulos);
            this.xtraTabPageArticulos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xtraTabPageArticulos.Name = "xtraTabPageArticulos";
            this.xtraTabPageArticulos.PageEnabled = false;
            this.xtraTabPageArticulos.Size = new System.Drawing.Size(459, 351);
            this.xtraTabPageArticulos.Text = "Artículos";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtArticulo);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1MinSize = 40;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gcArticulos);
            this.splitContainer2.Size = new System.Drawing.Size(459, 351);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 111;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(25, 4);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(426, 24);
            this.txtArticulo.TabIndex = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // gcArticulos
            // 
            this.gcArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcArticulos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcArticulos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcArticulos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcArticulos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcArticulos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcArticulos.Location = new System.Drawing.Point(0, 0);
            this.gcArticulos.MainView = this.gvArticulos;
            this.gcArticulos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcArticulos.MenuManager = this.mainRibbonControl;
            this.gcArticulos.Name = "gcArticulos";
            this.gcArticulos.Size = new System.Drawing.Size(459, 307);
            this.gcArticulos.TabIndex = 73;
            this.gcArticulos.UseEmbeddedNavigator = true;
            this.gcArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulos});
            // 
            // gvArticulos
            // 
            this.gvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnArticuloId,
            this.gridColumnSKU,
            this.gridColumnNombreArticulo});
            this.gvArticulos.DetailHeight = 279;
            this.gvArticulos.FixedLineWidth = 1;
            this.gvArticulos.GridControl = this.gcArticulos;
            this.gvArticulos.Name = "gvArticulos";
            this.gvArticulos.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append;
            this.gvArticulos.OptionsEditForm.PopupEditFormWidth = 484;
            this.gvArticulos.ClipboardRowPasting += new DevExpress.XtraGrid.Views.Grid.ClipboardRowPastingEventHandler(this.gvArticulos_ClipboardRowPasting);
            // 
            // gridColumnArticuloId
            // 
            this.gridColumnArticuloId.Caption = "Id";
            this.gridColumnArticuloId.FieldName = "id";
            this.gridColumnArticuloId.MinWidth = 18;
            this.gridColumnArticuloId.Name = "gridColumnArticuloId";
            this.gridColumnArticuloId.Width = 68;
            // 
            // gridColumnSKU
            // 
            this.gridColumnSKU.Caption = "SKU";
            this.gridColumnSKU.FieldName = "sku";
            this.gridColumnSKU.MinWidth = 18;
            this.gridColumnSKU.Name = "gridColumnSKU";
            this.gridColumnSKU.Visible = true;
            this.gridColumnSKU.VisibleIndex = 0;
            this.gridColumnSKU.Width = 68;
            // 
            // gridColumnNombreArticulo
            // 
            this.gridColumnNombreArticulo.Caption = "Artículo";
            this.gridColumnNombreArticulo.FieldName = "nombre";
            this.gridColumnNombreArticulo.MinWidth = 18;
            this.gridColumnNombreArticulo.Name = "gridColumnNombreArticulo";
            this.gridColumnNombreArticulo.Visible = true;
            this.gridColumnNombreArticulo.VisibleIndex = 1;
            this.gridColumnNombreArticulo.Width = 68;
            // 
            // btnImportarArticulos
            // 
            this.btnImportarArticulos.Location = new System.Drawing.Point(583, 7);
            this.btnImportarArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportarArticulos.Name = "btnImportarArticulos";
            this.btnImportarArticulos.Size = new System.Drawing.Size(102, 40);
            this.btnImportarArticulos.TabIndex = 74;
            this.btnImportarArticulos.Text = "Importar";
            // 
            // lblCondicionesPromocion
            // 
            this.lblCondicionesPromocion.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCondicionesPromocion.Appearance.Options.UseFont = true;
            this.lblCondicionesPromocion.Location = new System.Drawing.Point(12, 154);
            this.lblCondicionesPromocion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCondicionesPromocion.Name = "lblCondicionesPromocion";
            this.lblCondicionesPromocion.Size = new System.Drawing.Size(147, 13);
            this.lblCondicionesPromocion.TabIndex = 59;
            this.lblCondicionesPromocion.Text = "Condiciones de promoción";
            // 
            // cbVIP
            // 
            this.cbVIP.Location = new System.Drawing.Point(296, 84);
            this.cbVIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVIP.MenuManager = this.mainRibbonControl;
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Properties.Caption = "VIP";
            this.cbVIP.Size = new System.Drawing.Size(50, 21);
            this.cbVIP.TabIndex = 58;
            // 
            // cbTipoDescuento
            // 
            this.cbTipoDescuento.Location = new System.Drawing.Point(133, 85);
            this.cbTipoDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoDescuento.MenuManager = this.mainRibbonControl;
            this.cbTipoDescuento.Name = "cbTipoDescuento";
            this.cbTipoDescuento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDescuento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipoDescuento.Size = new System.Drawing.Size(156, 24);
            this.cbTipoDescuento.TabIndex = 57;
            // 
            // lblTipoDescuento
            // 
            this.lblTipoDescuento.Location = new System.Drawing.Point(14, 89);
            this.lblTipoDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTipoDescuento.Name = "lblTipoDescuento";
            this.lblTipoDescuento.Size = new System.Drawing.Size(110, 17);
            this.lblTipoDescuento.TabIndex = 56;
            this.lblTipoDescuento.Text = "Tipo de descuento";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // frmDescuentos
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(932, 794);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDescuentos";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAcumulable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAlmacenes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgGruposArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgListasPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGruposArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSocios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcVolumen)).EndInit();
            this.pcVolumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCondiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCondiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageListaPrecios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListasPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListasPrecios)).EndInit();
            this.xtraTabPageSociosNegocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).EndInit();
            this.xtraTabPageGruposArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGruposArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGruposArticulos)).EndInit();
            this.xtraTabPageAlmacenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAlmacenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlmacenes)).EndInit();
            this.xtraTabPageArticulos.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

}