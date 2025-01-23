using System;
using System.Collections.Generic;
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
using SDK;


namespace DTM
{
    partial class frmEventosControles
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
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
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
            this.lblControl = new DevExpress.XtraEditors.LabelControl();
            this.lblFormulario = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtControlDestino = new DevExpress.XtraEditors.TextEdit();
            this.txtControl = new DevExpress.XtraEditors.TextEdit();
            this.txtFormulario = new DevExpress.XtraEditors.TextEdit();
            this.cbControlDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.lblControlDestino = new DevExpress.XtraEditors.LabelControl();
            this.cbControles = new DevExpress.XtraEditors.LookUpEdit();
            this.cbFormularios = new DevExpress.XtraEditors.LookUpEdit();
            this.txtQuery = new DevExpress.XtraEditors.MemoEdit();
            this.lblQuery = new DevExpress.XtraEditors.LabelControl();
            this.cbEventos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEvento = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControlDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormularios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventos.Properties)).BeginInit();
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
            this.bbiRefresh,
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
            this.mainRibbonControl.OptionsMenuMinWidth = 440;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(764, 106);
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
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Actualizar";
            this.bbiRefresh.Id = 1;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiRefresh);
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
            this.lblID.Location = new System.Drawing.Point(639, 327);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(9, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblControl
            // 
            this.lblControl.Location = new System.Drawing.Point(16, 55);
            this.lblControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(89, 17);
            this.lblControl.TabIndex = 46;
            this.lblControl.Text = "Control origen";
            // 
            // lblFormulario
            // 
            this.lblFormulario.Location = new System.Drawing.Point(16, 21);
            this.lblFormulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(69, 17);
            this.lblFormulario.TabIndex = 44;
            this.lblFormulario.Text = "Formulario";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(16, 352);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(160, 21);
            this.cbActivo.TabIndex = 5;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(639, 356);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(65, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(456, 356);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(128, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtControlDestino);
            this.panel1.Controls.Add(this.txtControl);
            this.panel1.Controls.Add(this.txtFormulario);
            this.panel1.Controls.Add(this.cbControlDestino);
            this.panel1.Controls.Add(this.lblControlDestino);
            this.panel1.Controls.Add(this.cbControles);
            this.panel1.Controls.Add(this.cbFormularios);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.lblQuery);
            this.panel1.Controls.Add(this.cbEventos);
            this.panel1.Controls.Add(this.lblEvento);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.lblFormulario);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblControl);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 394);
            this.panel1.TabIndex = 53;
            // 
            // txtControlDestino
            // 
            this.txtControlDestino.Location = new System.Drawing.Point(456, 85);
            this.txtControlDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtControlDestino.MenuManager = this.mainRibbonControl;
            this.txtControlDestino.Name = "txtControlDestino";
            this.txtControlDestino.Properties.MaxLength = 20;
            this.txtControlDestino.Size = new System.Drawing.Size(257, 26);
            this.txtControlDestino.TabIndex = 2;
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(456, 51);
            this.txtControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtControl.MenuManager = this.mainRibbonControl;
            this.txtControl.Name = "txtControl";
            this.txtControl.Properties.MaxLength = 50;
            this.txtControl.Size = new System.Drawing.Size(257, 26);
            this.txtControl.TabIndex = 1;
            // 
            // txtFormulario
            // 
            this.txtFormulario.Location = new System.Drawing.Point(456, 17);
            this.txtFormulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFormulario.MenuManager = this.mainRibbonControl;
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Properties.MaxLength = 50;
            this.txtFormulario.Size = new System.Drawing.Size(257, 26);
            this.txtFormulario.TabIndex = 0;
            // 
            // cbControlDestino
            // 
            this.cbControlDestino.Location = new System.Drawing.Point(152, 85);
            this.cbControlDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbControlDestino.MenuManager = this.mainRibbonControl;
            this.cbControlDestino.Name = "cbControlDestino";
            this.cbControlDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControlDestino.Size = new System.Drawing.Size(292, 26);
            this.cbControlDestino.TabIndex = 3;
            this.cbControlDestino.TabStop = false;
            this.cbControlDestino.TextChanged += new System.EventHandler(this.cbControlDestino_TextChanged);
            // 
            // lblControlDestino
            // 
            this.lblControlDestino.Location = new System.Drawing.Point(16, 89);
            this.lblControlDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblControlDestino.Name = "lblControlDestino";
            this.lblControlDestino.Size = new System.Drawing.Size(93, 17);
            this.lblControlDestino.TabIndex = 60;
            this.lblControlDestino.Text = "Control destino";
            // 
            // cbControles
            // 
            this.cbControles.Location = new System.Drawing.Point(152, 51);
            this.cbControles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbControles.MenuManager = this.mainRibbonControl;
            this.cbControles.Name = "cbControles";
            this.cbControles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControles.Size = new System.Drawing.Size(292, 26);
            this.cbControles.TabIndex = 1;
            this.cbControles.TabStop = false;
            this.cbControles.TextChanged += new System.EventHandler(this.cbControles_TextChanged);
            // 
            // cbFormularios
            // 
            this.cbFormularios.Location = new System.Drawing.Point(152, 17);
            this.cbFormularios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFormularios.MenuManager = this.mainRibbonControl;
            this.cbFormularios.Name = "cbFormularios";
            this.cbFormularios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormularios.Size = new System.Drawing.Size(292, 26);
            this.cbFormularios.TabIndex = 0;
            this.cbFormularios.TabStop = false;
            this.cbFormularios.TextChanged += new System.EventHandler(this.cbFormularios_TextChanged);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(152, 154);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.MenuManager = this.mainRibbonControl;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(561, 165);
            this.txtQuery.TabIndex = 4;
            // 
            // lblQuery
            // 
            this.lblQuery.Location = new System.Drawing.Point(16, 154);
            this.lblQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(53, 17);
            this.lblQuery.TabIndex = 56;
            this.lblQuery.Text = "Consulta";
            // 
            // cbEventos
            // 
            this.cbEventos.Location = new System.Drawing.Point(152, 119);
            this.cbEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEventos.MenuManager = this.mainRibbonControl;
            this.cbEventos.Name = "cbEventos";
            this.cbEventos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEventos.Properties.Items.AddRange(new object[] {
            "Click",
            "DoubleClick",
            "TextChanged",
            "Enter",
            "GetFocus",
            "LostFocus",
            "EditValueChanged"});
            this.cbEventos.Size = new System.Drawing.Size(292, 26);
            this.cbEventos.TabIndex = 3;
            // 
            // lblEvento
            // 
            this.lblEvento.Location = new System.Drawing.Point(16, 123);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(42, 17);
            this.lblEvento.TabIndex = 53;
            this.lblEvento.Text = "Evento";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 106);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(764, 417);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(764, 417);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmEventosControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 523);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEventosControles";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos de controles";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControlDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormularios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEventos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}