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


namespace DTM
{
    partial class frmCondicionesPago
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
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPagoRequerido = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeInteresMoratorio = new DevExpress.XtraEditors.TextEdit();
            this.cbFinanciado = new DevExpress.XtraEditors.CheckEdit();
            this.lblPlazos = new DevExpress.XtraEditors.LabelControl();
            this.txtPlazos = new DevExpress.XtraEditors.TextEdit();
            this.lblDiasExtra = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasExtra = new DevExpress.XtraEditors.TextEdit();
            this.lblLimiteMaximo = new DevExpress.XtraEditors.LabelControl();
            this.txtLimiteMaximo = new DevExpress.XtraEditors.TextEdit();
            this.lblDiasTolerancia = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasTolerancia = new DevExpress.XtraEditors.TextEdit();
            this.lblPorcentajeInteres = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeInteres = new DevExpress.XtraEditors.TextEdit();
            this.lblPorcentajeDescuentoTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentajeDescuentoTotal = new DevExpress.XtraEditors.TextEdit();
            this.cbListaPrecios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblListaPrecios = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagoRequerido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteresMoratorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinanciado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteMaximo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTolerancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuentoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
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
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 440;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(763, 106);
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
            this.lblID.Location = new System.Drawing.Point(456, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(16, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(561, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(16, 21);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 17);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(152, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.MaxLength = 5;
            this.txtCodigo.Size = new System.Drawing.Size(291, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(16, 333);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(120, 21);
            this.cbActivo.TabIndex = 11;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(639, 337);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(456, 337);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPagoRequerido);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtPorcentajeInteresMoratorio);
            this.panel1.Controls.Add(this.cbFinanciado);
            this.panel1.Controls.Add(this.lblPlazos);
            this.panel1.Controls.Add(this.txtPlazos);
            this.panel1.Controls.Add(this.lblDiasExtra);
            this.panel1.Controls.Add(this.txtDiasExtra);
            this.panel1.Controls.Add(this.lblLimiteMaximo);
            this.panel1.Controls.Add(this.txtLimiteMaximo);
            this.panel1.Controls.Add(this.lblDiasTolerancia);
            this.panel1.Controls.Add(this.txtDiasTolerancia);
            this.panel1.Controls.Add(this.lblPorcentajeInteres);
            this.panel1.Controls.Add(this.txtPorcentajeInteres);
            this.panel1.Controls.Add(this.lblPorcentajeDescuentoTotal);
            this.panel1.Controls.Add(this.txtPorcentajeDescuentoTotal);
            this.panel1.Controls.Add(this.cbListaPrecios);
            this.panel1.Controls.Add(this.lblListaPrecios);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 374);
            this.panel1.TabIndex = 53;
            // 
            // cbPagoRequerido
            // 
            this.cbPagoRequerido.Location = new System.Drawing.Point(453, 290);
            this.cbPagoRequerido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbPagoRequerido.MenuManager = this.mainRibbonControl;
            this.cbPagoRequerido.Name = "cbPagoRequerido";
            this.cbPagoRequerido.Properties.Caption = "Pago requerido";
            this.cbPagoRequerido.Size = new System.Drawing.Size(159, 21);
            this.cbPagoRequerido.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(245, 157);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 17);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "% Interes moratorio";
            // 
            // txtPorcentajeInteresMoratorio
            // 
            this.txtPorcentajeInteresMoratorio.Location = new System.Drawing.Point(379, 153);
            this.txtPorcentajeInteresMoratorio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPorcentajeInteresMoratorio.MenuManager = this.mainRibbonControl;
            this.txtPorcentajeInteresMoratorio.Name = "txtPorcentajeInteresMoratorio";
            this.txtPorcentajeInteresMoratorio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeInteresMoratorio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeInteresMoratorio.Properties.Mask.EditMask = "p2";
            this.txtPorcentajeInteresMoratorio.Size = new System.Drawing.Size(64, 26);
            this.txtPorcentajeInteresMoratorio.TabIndex = 65;
            // 
            // cbFinanciado
            // 
            this.cbFinanciado.Location = new System.Drawing.Point(286, 289);
            this.cbFinanciado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFinanciado.MenuManager = this.mainRibbonControl;
            this.cbFinanciado.Name = "cbFinanciado";
            this.cbFinanciado.Properties.Caption = "Financiado";
            this.cbFinanciado.Size = new System.Drawing.Size(159, 21);
            this.cbFinanciado.TabIndex = 9;
            // 
            // lblPlazos
            // 
            this.lblPlazos.Location = new System.Drawing.Point(16, 293);
            this.lblPlazos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPlazos.Name = "lblPlazos";
            this.lblPlazos.Size = new System.Drawing.Size(38, 17);
            this.lblPlazos.TabIndex = 0;
            this.lblPlazos.Text = "Plazos";
            // 
            // txtPlazos
            // 
            this.txtPlazos.Location = new System.Drawing.Point(152, 289);
            this.txtPlazos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPlazos.MenuManager = this.mainRibbonControl;
            this.txtPlazos.Name = "txtPlazos";
            this.txtPlazos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPlazos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPlazos.Properties.Mask.EditMask = "n0";
            this.txtPlazos.Properties.MaxLength = 5;
            this.txtPlazos.Size = new System.Drawing.Size(126, 26);
            this.txtPlazos.TabIndex = 8;
            // 
            // lblDiasExtra
            // 
            this.lblDiasExtra.Location = new System.Drawing.Point(16, 191);
            this.lblDiasExtra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDiasExtra.Name = "lblDiasExtra";
            this.lblDiasExtra.Size = new System.Drawing.Size(61, 17);
            this.lblDiasExtra.TabIndex = 64;
            this.lblDiasExtra.Text = "Días extra";
            // 
            // txtDiasExtra
            // 
            this.txtDiasExtra.Location = new System.Drawing.Point(152, 187);
            this.txtDiasExtra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiasExtra.MenuManager = this.mainRibbonControl;
            this.txtDiasExtra.Name = "txtDiasExtra";
            this.txtDiasExtra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasExtra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasExtra.Properties.Mask.EditMask = "n0";
            this.txtDiasExtra.Properties.MaxLength = 5;
            this.txtDiasExtra.Size = new System.Drawing.Size(291, 26);
            this.txtDiasExtra.TabIndex = 5;
            // 
            // lblLimiteMaximo
            // 
            this.lblLimiteMaximo.Location = new System.Drawing.Point(16, 259);
            this.lblLimiteMaximo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblLimiteMaximo.Name = "lblLimiteMaximo";
            this.lblLimiteMaximo.Size = new System.Drawing.Size(95, 17);
            this.lblLimiteMaximo.TabIndex = 62;
            this.lblLimiteMaximo.Text = "Límite máximo";
            // 
            // txtLimiteMaximo
            // 
            this.txtLimiteMaximo.Location = new System.Drawing.Point(152, 255);
            this.txtLimiteMaximo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLimiteMaximo.MenuManager = this.mainRibbonControl;
            this.txtLimiteMaximo.Name = "txtLimiteMaximo";
            this.txtLimiteMaximo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLimiteMaximo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLimiteMaximo.Properties.Mask.EditMask = "n4";
            this.txtLimiteMaximo.Size = new System.Drawing.Size(291, 26);
            this.txtLimiteMaximo.TabIndex = 7;
            // 
            // lblDiasTolerancia
            // 
            this.lblDiasTolerancia.Location = new System.Drawing.Point(16, 225);
            this.lblDiasTolerancia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDiasTolerancia.Name = "lblDiasTolerancia";
            this.lblDiasTolerancia.Size = new System.Drawing.Size(109, 17);
            this.lblDiasTolerancia.TabIndex = 60;
            this.lblDiasTolerancia.Text = "Días de tolerancia";
            // 
            // txtDiasTolerancia
            // 
            this.txtDiasTolerancia.Location = new System.Drawing.Point(152, 221);
            this.txtDiasTolerancia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiasTolerancia.MenuManager = this.mainRibbonControl;
            this.txtDiasTolerancia.Name = "txtDiasTolerancia";
            this.txtDiasTolerancia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasTolerancia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiasTolerancia.Properties.Mask.EditMask = "n0";
            this.txtDiasTolerancia.Properties.MaxLength = 5;
            this.txtDiasTolerancia.Size = new System.Drawing.Size(291, 26);
            this.txtDiasTolerancia.TabIndex = 6;
            // 
            // lblPorcentajeInteres
            // 
            this.lblPorcentajeInteres.Location = new System.Drawing.Point(16, 157);
            this.lblPorcentajeInteres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPorcentajeInteres.Name = "lblPorcentajeInteres";
            this.lblPorcentajeInteres.Size = new System.Drawing.Size(54, 17);
            this.lblPorcentajeInteres.TabIndex = 58;
            this.lblPorcentajeInteres.Text = "% Interes";
            // 
            // txtPorcentajeInteres
            // 
            this.txtPorcentajeInteres.Location = new System.Drawing.Point(152, 153);
            this.txtPorcentajeInteres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPorcentajeInteres.MenuManager = this.mainRibbonControl;
            this.txtPorcentajeInteres.Name = "txtPorcentajeInteres";
            this.txtPorcentajeInteres.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeInteres.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeInteres.Properties.Mask.EditMask = "p2";
            this.txtPorcentajeInteres.Size = new System.Drawing.Size(64, 26);
            this.txtPorcentajeInteres.TabIndex = 4;
            // 
            // lblPorcentajeDescuentoTotal
            // 
            this.lblPorcentajeDescuentoTotal.Location = new System.Drawing.Point(16, 123);
            this.lblPorcentajeDescuentoTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPorcentajeDescuentoTotal.Name = "lblPorcentajeDescuentoTotal";
            this.lblPorcentajeDescuentoTotal.Size = new System.Drawing.Size(111, 17);
            this.lblPorcentajeDescuentoTotal.TabIndex = 56;
            this.lblPorcentajeDescuentoTotal.Text = "% Descuento total";
            // 
            // txtPorcentajeDescuentoTotal
            // 
            this.txtPorcentajeDescuentoTotal.Location = new System.Drawing.Point(152, 119);
            this.txtPorcentajeDescuentoTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPorcentajeDescuentoTotal.MenuManager = this.mainRibbonControl;
            this.txtPorcentajeDescuentoTotal.Name = "txtPorcentajeDescuentoTotal";
            this.txtPorcentajeDescuentoTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeDescuentoTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcentajeDescuentoTotal.Properties.Mask.EditMask = "p2";
            this.txtPorcentajeDescuentoTotal.Size = new System.Drawing.Size(291, 26);
            this.txtPorcentajeDescuentoTotal.TabIndex = 3;
            // 
            // cbListaPrecios
            // 
            this.cbListaPrecios.Location = new System.Drawing.Point(152, 85);
            this.cbListaPrecios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbListaPrecios.MenuManager = this.mainRibbonControl;
            this.cbListaPrecios.Name = "cbListaPrecios";
            this.cbListaPrecios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaPrecios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListaPrecios.Size = new System.Drawing.Size(291, 26);
            this.cbListaPrecios.TabIndex = 2;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaPrecios.Location = new System.Drawing.Point(16, 86);
            this.lblListaPrecios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(92, 17);
            this.lblListaPrecios.TabIndex = 54;
            this.lblListaPrecios.Text = "Lista de precios";
            this.lblListaPrecios.Click += new System.EventHandler(this.lblListaPrecios_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 106);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(763, 394);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(763, 394);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 500);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmCondicionesPago";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condiciones de pago";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagoRequerido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteresMoratorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinanciado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteMaximo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTolerancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuentoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPrecios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}