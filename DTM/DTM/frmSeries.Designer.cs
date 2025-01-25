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
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;

namespace DTM
{
    partial class frmSeries
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
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAlmacenes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAlmacenes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbDigital = new DevExpress.XtraEditors.CheckEdit();
            this.gcFacturacion = new DevExpress.XtraEditors.GroupControl();
            this.lblSerieFacturacionAutomatica = new DevExpress.XtraEditors.LabelControl();
            this.cbSeriesFacturacion = new DevExpress.XtraEditors.LookUpEdit();
            this.cbFacturarAutomaticamente = new DevExpress.XtraEditors.CheckEdit();
            this.cbPredeterminadoCancelacion = new DevExpress.XtraEditors.CheckEdit();
            this.cbPredeterminado = new DevExpress.XtraEditors.CheckEdit();
            this.txtFinal = new DevExpress.XtraEditors.TextEdit();
            this.lblFinal = new DevExpress.XtraEditors.LabelControl();
            this.txtSiguiente = new DevExpress.XtraEditors.TextEdit();
            this.lblSiguiente = new DevExpress.XtraEditors.LabelControl();
            this.txtInicial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblClase = new DevExpress.XtraEditors.LabelControl();
            this.cbClases = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDigital.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFacturacion)).BeginInit();
            this.gcFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturarAutomaticamente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminadoCancelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiguiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClases.Properties)).BeginInit();
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
            this.bbiNuevo,
            this.bbiUsuarios});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainRibbonControl.MaxItemId = 3;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPageHerramientas});
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
            // bbiUsuarios
            // 
            this.bbiUsuarios.Caption = "Usuarios";
            this.bbiUsuarios.Id = 2;
            this.bbiUsuarios.ImageOptions.ImageUri.Uri = "ListBullets";
            this.bbiUsuarios.Name = "bbiUsuarios";
            this.bbiUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsuarios_ItemClick);
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
            this.ribbonPageGroupHerramientas});
            this.ribbonPageHerramientas.Name = "ribbonPageHerramientas";
            this.ribbonPageHerramientas.Text = "HERRAMIENTAS";
            // 
            // ribbonPageGroupHerramientas
            // 
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiUsuarios);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
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
            this.txtNombre.Location = new System.Drawing.Point(133, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 8;
            this.txtNombre.Size = new System.Drawing.Size(491, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(14, 21);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 17);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.EditFormat.FormatString = "n0";
            this.txtCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Properties.MaxLength = 5;
            this.txtCodigo.Size = new System.Drawing.Size(255, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(559, 301);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(399, 301);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAlmacenes);
            this.panel1.Controls.Add(this.lblAlmacenes);
            this.panel1.Controls.Add(this.cbDigital);
            this.panel1.Controls.Add(this.gcFacturacion);
            this.panel1.Controls.Add(this.cbPredeterminadoCancelacion);
            this.panel1.Controls.Add(this.cbPredeterminado);
            this.panel1.Controls.Add(this.txtFinal);
            this.panel1.Controls.Add(this.lblFinal);
            this.panel1.Controls.Add(this.txtSiguiente);
            this.panel1.Controls.Add(this.lblSiguiente);
            this.panel1.Controls.Add(this.txtInicial);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblClase);
            this.panel1.Controls.Add(this.cbClases);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 333);
            this.panel1.TabIndex = 53;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.Location = new System.Drawing.Point(133, 221);
            this.cbAlmacenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlmacenes.MenuManager = this.mainRibbonControl;
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Size = new System.Drawing.Size(226, 24);
            this.cbAlmacenes.TabIndex = 62;
            // 
            // lblAlmacenes
            // 
            this.lblAlmacenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlmacenes.Location = new System.Drawing.Point(14, 225);
            this.lblAlmacenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAlmacenes.Name = "lblAlmacenes";
            this.lblAlmacenes.Size = new System.Drawing.Size(54, 17);
            this.lblAlmacenes.TabIndex = 63;
            this.lblAlmacenes.Text = "Almacén";
            // 
            // cbDigital
            // 
            this.cbDigital.Location = new System.Drawing.Point(479, 255);
            this.cbDigital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDigital.MenuManager = this.mainRibbonControl;
            this.cbDigital.Name = "cbDigital";
            this.cbDigital.Properties.Caption = "Serie digital";
            this.cbDigital.Size = new System.Drawing.Size(140, 21);
            this.cbDigital.TabIndex = 8;
            // 
            // gcFacturacion
            // 
            this.gcFacturacion.Controls.Add(this.lblSerieFacturacionAutomatica);
            this.gcFacturacion.Controls.Add(this.cbSeriesFacturacion);
            this.gcFacturacion.Controls.Add(this.cbFacturarAutomaticamente);
            this.gcFacturacion.Location = new System.Drawing.Point(399, 85);
            this.gcFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcFacturacion.Name = "gcFacturacion";
            this.gcFacturacion.Size = new System.Drawing.Size(225, 131);
            this.gcFacturacion.TabIndex = 61;
            this.gcFacturacion.Text = "Facturar automáticamente";
            // 
            // lblSerieFacturacionAutomatica
            // 
            this.lblSerieFacturacionAutomatica.Location = new System.Drawing.Point(9, 72);
            this.lblSerieFacturacionAutomatica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSerieFacturacionAutomatica.Name = "lblSerieFacturacionAutomatica";
            this.lblSerieFacturacionAutomatica.Size = new System.Drawing.Size(177, 17);
            this.lblSerieFacturacionAutomatica.TabIndex = 62;
            this.lblSerieFacturacionAutomatica.Text = "Serie facturación automática";
            // 
            // cbSeriesFacturacion
            // 
            this.cbSeriesFacturacion.Location = new System.Drawing.Point(6, 97);
            this.cbSeriesFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSeriesFacturacion.MenuManager = this.mainRibbonControl;
            this.cbSeriesFacturacion.Name = "cbSeriesFacturacion";
            this.cbSeriesFacturacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeriesFacturacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbSeriesFacturacion.Size = new System.Drawing.Size(205, 24);
            this.cbSeriesFacturacion.TabIndex = 0;
            this.cbSeriesFacturacion.TabStop = false;
            // 
            // cbFacturarAutomaticamente
            // 
            this.cbFacturarAutomaticamente.Location = new System.Drawing.Point(9, 35);
            this.cbFacturarAutomaticamente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFacturarAutomaticamente.MenuManager = this.mainRibbonControl;
            this.cbFacturarAutomaticamente.Name = "cbFacturarAutomaticamente";
            this.cbFacturarAutomaticamente.Properties.Caption = "Facturar automáticamente";
            this.cbFacturarAutomaticamente.Size = new System.Drawing.Size(205, 21);
            this.cbFacturarAutomaticamente.TabIndex = 0;
            this.cbFacturarAutomaticamente.TabStop = false;
            // 
            // cbPredeterminadoCancelacion
            // 
            this.cbPredeterminadoCancelacion.Location = new System.Drawing.Point(280, 255);
            this.cbPredeterminadoCancelacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPredeterminadoCancelacion.MenuManager = this.mainRibbonControl;
            this.cbPredeterminadoCancelacion.Name = "cbPredeterminadoCancelacion";
            this.cbPredeterminadoCancelacion.Properties.Caption = "Predeterminado cancelación";
            this.cbPredeterminadoCancelacion.Size = new System.Drawing.Size(192, 21);
            this.cbPredeterminadoCancelacion.TabIndex = 7;
            // 
            // cbPredeterminado
            // 
            this.cbPredeterminado.Location = new System.Drawing.Point(133, 255);
            this.cbPredeterminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPredeterminado.MenuManager = this.mainRibbonControl;
            this.cbPredeterminado.Name = "cbPredeterminado";
            this.cbPredeterminado.Properties.Caption = "Predeterminado";
            this.cbPredeterminado.Size = new System.Drawing.Size(140, 21);
            this.cbPredeterminado.TabIndex = 6;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(133, 187);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinal.MenuManager = this.mainRibbonControl;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Properties.MaxLength = 11;
            this.txtFinal.Size = new System.Drawing.Size(255, 24);
            this.txtFinal.TabIndex = 5;
            // 
            // lblFinal
            // 
            this.lblFinal.Location = new System.Drawing.Point(14, 191);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(27, 17);
            this.lblFinal.TabIndex = 59;
            this.lblFinal.Text = "Final";
            // 
            // txtSiguiente
            // 
            this.txtSiguiente.Location = new System.Drawing.Point(133, 153);
            this.txtSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSiguiente.MenuManager = this.mainRibbonControl;
            this.txtSiguiente.Name = "txtSiguiente";
            this.txtSiguiente.Properties.MaxLength = 11;
            this.txtSiguiente.Size = new System.Drawing.Size(255, 24);
            this.txtSiguiente.TabIndex = 4;
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.Location = new System.Drawing.Point(14, 157);
            this.lblSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(56, 17);
            this.lblSiguiente.TabIndex = 57;
            this.lblSiguiente.Text = "Siguiente";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(133, 119);
            this.txtInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInicial.MenuManager = this.mainRibbonControl;
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Properties.MaxLength = 11;
            this.txtInicial.Size = new System.Drawing.Size(255, 24);
            this.txtInicial.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 123);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Inicial";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(14, 297);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(103, 21);
            this.cbActivo.TabIndex = 9;
            // 
            // lblClase
            // 
            this.lblClase.Location = new System.Drawing.Point(14, 89);
            this.lblClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 17);
            this.lblClase.TabIndex = 52;
            this.lblClase.Text = "Clase";
            // 
            // cbClases
            // 
            this.cbClases.Location = new System.Drawing.Point(133, 85);
            this.cbClases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClases.MenuManager = this.mainRibbonControl;
            this.cbClases.Name = "cbClases";
            this.cbClases.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClases.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbClases.Size = new System.Drawing.Size(255, 24);
            this.cbClases.TabIndex = 2;
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
            this.layoutControl1.Size = new System.Drawing.Size(668, 383);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(668, 383);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 462);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSeries";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDigital.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFacturacion)).EndInit();
            this.gcFacturacion.ResumeLayout(false);
            this.gcFacturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturarAutomaticamente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminadoCancelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiguiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClases.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}