using DevExpress.XtraEditors;
using System;

namespace DTM
{
    partial class frmArticulosSolicitados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.memoComentario = new DevExpress.XtraEditors.PanelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.txtArt = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRecargar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiNuevoSocio = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopiar = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemMapaRelaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiEnviar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiCerrar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiPagar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiAjustarColumnas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDuplicar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelacionManualCFDI = new DevExpress.XtraBars.BarButtonItem();
            this.bbiParametrizaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sku = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario)).BeginInit();
            this.memoComentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1308, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 673);
            this.dataGridView1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(7);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(783, 609);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(783, 609);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(783, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 609);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlBottom.Size = new System.Drawing.Size(783, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlTop.Size = new System.Drawing.Size(783, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.memoComentario);
            this.layoutControl2.Controls.Add(this.textEdit4);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 57);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(783, 552);
            this.layoutControl2.TabIndex = 61;
            this.layoutControl2.Text = "layoutControl1";
            // 
            // memoComentario
            // 
            this.memoComentario.Controls.Add(this.spinEdit1);
            this.memoComentario.Controls.Add(this.labelControl5);
            this.memoComentario.Controls.Add(this.labelControl4);
            this.memoComentario.Controls.Add(this.txtDescripcion);
            this.memoComentario.Controls.Add(this.labelControl2);
            this.memoComentario.Controls.Add(this.labelControl1);
            this.memoComentario.Controls.Add(this.memoEdit1);
            this.memoComentario.Controls.Add(this.simpleButton1);
            this.memoComentario.Controls.Add(this.txtArticulo);
            this.memoComentario.Controls.Add(this.gridControl1);
            this.memoComentario.Location = new System.Drawing.Point(12, 12);
            this.memoComentario.Name = "memoComentario";
            this.memoComentario.Size = new System.Drawing.Size(759, 528);
            this.memoComentario.TabIndex = 4;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(628, 28);
            this.spinEdit1.MenuManager = this.txtArt;
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 24);
            this.spinEdit1.TabIndex = 12;
            // 
            // txtArt
            // 
            this.txtArt.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.txtArt.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(53, 52, 53, 52);
            this.txtArt.ExpandCollapseItem.Id = 0;
            this.txtArt.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtArt.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRecargar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.bbiImprimir,
            this.bbiNuevoSocio,
            this.bbiCopiar,
            this.barButtonItemMapaRelaciones,
            this.bbiPDF,
            this.bbiEnviar,
            this.bbiCancelar,
            this.bbiCerrar,
            this.bbiPagar,
            this.bbiXLSX,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.barHeaderItem3,
            this.bbiAjustarColumnas,
            this.bbiDuplicar,
            this.bbiCancelacionManualCFDI,
            this.bbiParametrizaciones,
            this.bbiAbrir,
            this.barButtonItem1});
            this.txtArt.Location = new System.Drawing.Point(0, 0);
            this.txtArt.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtArt.MaxItemId = 26;
            this.txtArt.Name = "txtArt";
            this.txtArt.OptionsMenuMinWidth = 587;
            this.txtArt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.txtArt.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.txtArt.Size = new System.Drawing.Size(783, 57);
            this.txtArt.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            // 
            // bbiGuardarCerrar
            // 
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
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
            // bbiRecargar
            // 
            this.bbiRecargar.Caption = "Recargar";
            this.bbiRecargar.Id = 1;
            this.bbiRecargar.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRecargar.Name = "bbiRecargar";
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
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "AddItem";
            this.bbiNuevo.Name = "bbiNuevo";
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 4;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // bbiNuevoSocio
            // 
            this.bbiNuevoSocio.Caption = "Nuevo socio";
            this.bbiNuevoSocio.Id = 5;
            this.bbiNuevoSocio.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevoSocio.Name = "bbiNuevoSocio";
            // 
            // bbiCopiar
            // 
            this.bbiCopiar.Caption = "Copiar";
            this.bbiCopiar.Id = 7;
            this.bbiCopiar.ImageOptions.ImageUri.Uri = "Replace";
            this.bbiCopiar.Name = "bbiCopiar";
            // 
            // barButtonItemMapaRelaciones
            // 
            this.barButtonItemMapaRelaciones.Caption = "Mapa de relaciones";
            this.barButtonItemMapaRelaciones.Id = 8;
            this.barButtonItemMapaRelaciones.ImageOptions.ImageUri.Uri = "SendToBack";
            this.barButtonItemMapaRelaciones.Name = "barButtonItemMapaRelaciones";
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 10;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.Name = "bbiPDF";
            // 
            // bbiEnviar
            // 
            this.bbiEnviar.Caption = "Enviar";
            this.bbiEnviar.Id = 11;
            this.bbiEnviar.ImageOptions.ImageUri.Uri = "Mail";
            this.bbiEnviar.Name = "bbiEnviar";
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 12;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiCerrar
            // 
            this.bbiCerrar.Caption = "Cerrar";
            this.bbiCerrar.Id = 13;
            this.bbiCerrar.ImageOptions.ImageUri.Uri = "Close";
            this.bbiCerrar.Name = "bbiCerrar";
            this.bbiCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPagar
            // 
            this.bbiPagar.Caption = "Pagar";
            this.bbiPagar.Id = 14;
            this.bbiPagar.ImageOptions.ImageUri.Uri = "Currency";
            this.bbiPagar.Name = "bbiPagar";
            // 
            // bbiXLSX
            // 
            this.bbiXLSX.Caption = "XLSX";
            this.bbiXLSX.Id = 15;
            this.bbiXLSX.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.bbiXLSX.Name = "bbiXLSX";
            this.bbiXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXLSX_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Exportar";
            this.barHeaderItem1.Id = 16;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "Acciones";
            this.barHeaderItem2.Id = 17;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "Más";
            this.barHeaderItem3.Id = 18;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // bbiAjustarColumnas
            // 
            this.bbiAjustarColumnas.Caption = "Ajustar columnas";
            this.bbiAjustarColumnas.Id = 19;
            this.bbiAjustarColumnas.ImageOptions.ImageUri.Uri = "SnapToCells";
            this.bbiAjustarColumnas.Name = "bbiAjustarColumnas";
            // 
            // bbiDuplicar
            // 
            this.bbiDuplicar.Caption = "Duplicar";
            this.bbiDuplicar.Id = 20;
            this.bbiDuplicar.ImageOptions.ImageUri.Uri = "Redo";
            this.bbiDuplicar.Name = "bbiDuplicar";
            // 
            // bbiCancelacionManualCFDI
            // 
            this.bbiCancelacionManualCFDI.Caption = "Cancelación manual CFDI";
            this.bbiCancelacionManualCFDI.Id = 21;
            this.bbiCancelacionManualCFDI.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelacionManualCFDI.Name = "bbiCancelacionManualCFDI";
            // 
            // bbiParametrizaciones
            // 
            this.bbiParametrizaciones.Caption = "Parametrizaciones de formulario";
            this.bbiParametrizaciones.Id = 22;
            this.bbiParametrizaciones.Name = "bbiParametrizaciones";
            // 
            // bbiAbrir
            // 
            this.bbiAbrir.Caption = "Abrir";
            this.bbiAbrir.Id = 23;
            this.bbiAbrir.Name = "bbiAbrir";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(544, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 17);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Cantidad";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(231, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(305, 32);
            this.txtDescripcion.MenuManager = this.txtArt;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(233, 24);
            this.txtDescripcion.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Comentarios";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Articulo";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(103, 62);
            this.memoEdit1.MenuManager = this.txtArt;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(625, 120);
            this.memoEdit1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(579, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 42);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Agregar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(103, 28);
            this.txtArticulo.MenuManager = this.txtArt;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(109, 24);
            this.txtArticulo.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(21, 243);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.txtArt;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(707, 265);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sku,
            this.descripcion,
            this.cantidad,
            this.comentarios,
            this.fecha});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // sku
            // 
            this.sku.FieldName = "sku";
            this.sku.Name = "sku";
            this.sku.Visible = true;
            this.sku.VisibleIndex = 0;
            // 
            // descripcion
            // 
            this.descripcion.FieldName = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 1;
            // 
            // cantidad
            // 
            this.cantidad.FieldName = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Visible = true;
            this.cantidad.VisibleIndex = 2;
            // 
            // comentarios
            // 
            this.comentarios.FieldName = "comentarios";
            this.comentarios.Name = "comentarios";
            this.comentarios.Visible = true;
            this.comentarios.VisibleIndex = 3;
            // 
            // fecha
            // 
            this.fecha.FieldName = "fecha_creacion";
            this.fecha.Name = "fecha";
            this.fecha.Visible = true;
            this.fecha.VisibleIndex = 4;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(136, 516);
            this.textEdit4.MenuManager = this.txtArt;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(782, 24);
            this.textEdit4.StyleController = this.layoutControl2;
            this.textEdit4.TabIndex = 12;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(783, 552);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.memoComentario;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(763, 532);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.bbiXLSX);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.txtArt;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 25;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmArticulosSolicitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 609);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArticulosSolicitados";
            this.Ribbon = this.txtArt;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Negadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario)).EndInit();
            this.memoComentario.ResumeLayout(false);
            this.memoComentario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraBars.Ribbon.RibbonControl txtArt;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarCerrar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarNuevo;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private DevExpress.XtraBars.BarButtonItem bbiRecargar;
        private DevExpress.XtraBars.BarButtonItem bbiBuscar;
        private DevExpress.XtraBars.BarButtonItem bbiPrimero;
        private DevExpress.XtraBars.BarButtonItem bbiAnterior;
        private DevExpress.XtraBars.BarButtonItem bbiUltimo;
        private DevExpress.XtraBars.BarButtonItem bbiSiguiente;
        private DevExpress.XtraBars.BarButtonItem bbiNuevo;
        private DevExpress.XtraBars.BarSubItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoSocio;
        private DevExpress.XtraBars.BarSubItem bbiCopiar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMapaRelaciones;
        private DevExpress.XtraBars.BarSubItem bbiPDF;
        private DevExpress.XtraBars.BarButtonItem bbiEnviar;
        private DevExpress.XtraBars.BarStaticItem bbiCancelar;
        private DevExpress.XtraBars.BarStaticItem bbiCerrar;
        private DevExpress.XtraBars.BarButtonItem bbiPagar;
        private DevExpress.XtraBars.BarButtonItem bbiXLSX;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.BarButtonItem bbiAjustarColumnas;
        private DevExpress.XtraBars.BarButtonItem bbiDuplicar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelacionManualCFDI;
        private DevExpress.XtraBars.BarButtonItem bbiParametrizaciones;
        private DevExpress.XtraBars.BarButtonItem bbiAbrir;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.PanelControl memoComentario;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private SimpleButton simpleButton1;
        private TextEdit txtArticulo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private MemoEdit memoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn sku;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn comentarios;
        private SpinEdit spinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn fecha;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}