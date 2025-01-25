using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
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
using Padding = System.Windows.Forms.Padding;


namespace DTM
{
    partial class frmListaPedidosWeb
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
            this.components = new System.ComponentModel.Container();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbrir = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.cbEstados = new DevExpress.XtraEditors.LookUpEdit();
            this.deHasta = new DevExpress.XtraEditors.DateEdit();
            this.deDesde = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcDocumentos = new DevExpress.XtraGrid.GridControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDocumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNumeroDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCondicionPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImpreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAnonimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leEstadosSeguimiento = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.deFecha = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cbMonedas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cbSeguimiento = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cbEstadoSeguimiento = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leEstadosSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1185, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 870);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1185, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 870);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1185, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 870);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1185, 50);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.gcDocumentos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1185, 820);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.panel1);
            this.layoutControl2.Location = new System.Drawing.Point(6, 6);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1173, 122);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnEntregar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.cbEstados);
            this.panel1.Controls.Add(this.deHasta);
            this.panel1.Controls.Add(this.deDesde);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 110);
            this.panel1.TabIndex = 4;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(242, 38);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(112, 34);
            this.btnPDF.TabIndex = 14;
            this.btnPDF.Text = "PDF";
            // 
            // btnEntregar
            // 
            this.btnEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntregar.Location = new System.Drawing.Point(1045, 38);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(112, 34);
            this.btnEntregar.TabIndex = 13;
            this.btnEntregar.Text = "Entregar";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Location = new System.Drawing.Point(923, 38);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(112, 34);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(122, 38);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(112, 34);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(0, 38);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 34);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            // 
            // cbEstados
            // 
            this.cbEstados.Location = new System.Drawing.Point(0, 0);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("estado", "Estado", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbEstados.Size = new System.Drawing.Size(128, 24);
            this.cbEstados.TabIndex = 9;
            // 
            // deHasta
            // 
            this.deHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deHasta.EditValue = new System.DateTime(2018, 3, 11, 22, 51, 26, 265);
            this.deHasta.Location = new System.Drawing.Point(1029, 0);
            this.deHasta.Margin = new System.Windows.Forms.Padding(4);
            this.deHasta.MenuManager = this.tabFormDefaultManager1;
            this.deHasta.Name = "deHasta";
            this.deHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deHasta.Size = new System.Drawing.Size(128, 24);
            this.deHasta.TabIndex = 7;
            // 
            // deDesde
            // 
            this.deDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deDesde.EditValue = new System.DateTime(2018, 3, 11, 22, 51, 2, 700);
            this.deDesde.Location = new System.Drawing.Point(892, 0);
            this.deDesde.Margin = new System.Windows.Forms.Padding(4);
            this.deDesde.MenuManager = this.tabFormDefaultManager1;
            this.deDesde.Name = "deDesde";
            this.deDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDesde.Size = new System.Drawing.Size(128, 24);
            this.deDesde.TabIndex = 6;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1173, 122);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1163, 112);
            this.layoutControlItem2.Text = "Filtros";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gcDocumentos
            // 
            this.gcDocumentos.ContextMenuStrip = this.contextMenu;
            this.gcDocumentos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcDocumentos.Location = new System.Drawing.Point(6, 130);
            this.gcDocumentos.MainView = this.gvDocumentos;
            this.gcDocumentos.Margin = new System.Windows.Forms.Padding(4);
            this.gcDocumentos.MenuManager = this.tabFormDefaultManager1;
            this.gcDocumentos.Name = "gcDocumentos";
            this.gcDocumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deFecha,
            this.cbMonedas,
            this.cbSeguimiento,
            this.cbEstadoSeguimiento,
            this.leEstadosSeguimiento});
            this.gcDocumentos.Size = new System.Drawing.Size(1173, 684);
            this.gcDocumentos.TabIndex = 4;
            this.gcDocumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentos});
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(148, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "Exportar XSLX";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem2.Text = "Exportar PDF";
            // 
            // gvDocumentos
            // 
            this.gvDocumentos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvDocumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnNumeroDocumento,
            this.gridColumnFechaDocumento,
            this.gridColumnFechaVencimiento,
            this.gridColumnCodigoSN,
            this.gridColumnNombre,
            this.gridColumnTotal,
            this.gridColumnCondicionPago,
            this.gridColumnMetodoPago,
            this.gridColumnReferencia,
            this.gridColumnComentario,
            this.gridColumnImpreso,
            this.gridColumnAnonimo,
            this.gridColumnEstado});
            this.gvDocumentos.DetailHeight = 512;
            this.gvDocumentos.FixedLineWidth = 3;
            this.gvDocumentos.GridControl = this.gcDocumentos;
            this.gvDocumentos.Name = "gvDocumentos";
            this.gvDocumentos.OptionsSelection.MultiSelect = true;
            this.gvDocumentos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDocumentos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDocumentos_CellValueChanged);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "ID";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 30;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 1;
            this.gridColumnId.Width = 112;
            // 
            // gridColumnNumeroDocumento
            // 
            this.gridColumnNumeroDocumento.Caption = "N° Documento";
            this.gridColumnNumeroDocumento.FieldName = "numero_documento";
            this.gridColumnNumeroDocumento.MinWidth = 30;
            this.gridColumnNumeroDocumento.Name = "gridColumnNumeroDocumento";
            this.gridColumnNumeroDocumento.Visible = true;
            this.gridColumnNumeroDocumento.VisibleIndex = 2;
            this.gridColumnNumeroDocumento.Width = 112;
            // 
            // gridColumnFechaDocumento
            // 
            this.gridColumnFechaDocumento.Caption = "Fecha";
            this.gridColumnFechaDocumento.FieldName = "fecha_documento";
            this.gridColumnFechaDocumento.MinWidth = 30;
            this.gridColumnFechaDocumento.Name = "gridColumnFechaDocumento";
            this.gridColumnFechaDocumento.Visible = true;
            this.gridColumnFechaDocumento.VisibleIndex = 3;
            this.gridColumnFechaDocumento.Width = 112;
            // 
            // gridColumnFechaVencimiento
            // 
            this.gridColumnFechaVencimiento.Caption = "Fecha entrega";
            this.gridColumnFechaVencimiento.FieldName = "fecha_vencimiento";
            this.gridColumnFechaVencimiento.MinWidth = 30;
            this.gridColumnFechaVencimiento.Name = "gridColumnFechaVencimiento";
            this.gridColumnFechaVencimiento.Visible = true;
            this.gridColumnFechaVencimiento.VisibleIndex = 4;
            this.gridColumnFechaVencimiento.Width = 112;
            // 
            // gridColumnCodigoSN
            // 
            this.gridColumnCodigoSN.Caption = "Codigo SN";
            this.gridColumnCodigoSN.FieldName = "codigo";
            this.gridColumnCodigoSN.MinWidth = 30;
            this.gridColumnCodigoSN.Name = "gridColumnCodigoSN";
            this.gridColumnCodigoSN.Visible = true;
            this.gridColumnCodigoSN.VisibleIndex = 5;
            this.gridColumnCodigoSN.Width = 112;
            // 
            // gridColumnNombre
            // 
            this.gridColumnNombre.Caption = "Nombre del cliente";
            this.gridColumnNombre.FieldName = "nombre";
            this.gridColumnNombre.MinWidth = 30;
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 6;
            this.gridColumnNombre.Width = 112;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.FieldName = "total";
            this.gridColumnTotal.MinWidth = 30;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 7;
            this.gridColumnTotal.Width = 112;
            // 
            // gridColumnCondicionPago
            // 
            this.gridColumnCondicionPago.Caption = "Condicion pago";
            this.gridColumnCondicionPago.FieldName = "condicion_pago";
            this.gridColumnCondicionPago.MinWidth = 30;
            this.gridColumnCondicionPago.Name = "gridColumnCondicionPago";
            this.gridColumnCondicionPago.Visible = true;
            this.gridColumnCondicionPago.VisibleIndex = 8;
            this.gridColumnCondicionPago.Width = 112;
            // 
            // gridColumnMetodoPago
            // 
            this.gridColumnMetodoPago.Caption = "Metodo pago";
            this.gridColumnMetodoPago.FieldName = "metodo_pago";
            this.gridColumnMetodoPago.MinWidth = 30;
            this.gridColumnMetodoPago.Name = "gridColumnMetodoPago";
            this.gridColumnMetodoPago.Visible = true;
            this.gridColumnMetodoPago.VisibleIndex = 9;
            this.gridColumnMetodoPago.Width = 112;
            // 
            // gridColumnReferencia
            // 
            this.gridColumnReferencia.Caption = "Referencia";
            this.gridColumnReferencia.FieldName = "referencia";
            this.gridColumnReferencia.MinWidth = 30;
            this.gridColumnReferencia.Name = "gridColumnReferencia";
            this.gridColumnReferencia.Visible = true;
            this.gridColumnReferencia.VisibleIndex = 10;
            this.gridColumnReferencia.Width = 112;
            // 
            // gridColumnComentario
            // 
            this.gridColumnComentario.Caption = "Comentario";
            this.gridColumnComentario.FieldName = "comentario";
            this.gridColumnComentario.MinWidth = 30;
            this.gridColumnComentario.Name = "gridColumnComentario";
            this.gridColumnComentario.Visible = true;
            this.gridColumnComentario.VisibleIndex = 11;
            this.gridColumnComentario.Width = 112;
            // 
            // gridColumnImpreso
            // 
            this.gridColumnImpreso.Caption = "Impreso";
            this.gridColumnImpreso.FieldName = "impreso";
            this.gridColumnImpreso.MinWidth = 30;
            this.gridColumnImpreso.Name = "gridColumnImpreso";
            this.gridColumnImpreso.Visible = true;
            this.gridColumnImpreso.VisibleIndex = 12;
            this.gridColumnImpreso.Width = 112;
            // 
            // gridColumnAnonimo
            // 
            this.gridColumnAnonimo.Caption = "Anonimo";
            this.gridColumnAnonimo.FieldName = "anonimo";
            this.gridColumnAnonimo.MinWidth = 30;
            this.gridColumnAnonimo.Name = "gridColumnAnonimo";
            this.gridColumnAnonimo.Visible = true;
            this.gridColumnAnonimo.VisibleIndex = 13;
            this.gridColumnAnonimo.Width = 112;
            // 
            // gridColumnEstado
            // 
            this.gridColumnEstado.Caption = "Estado";
            this.gridColumnEstado.ColumnEdit = this.leEstadosSeguimiento;
            this.gridColumnEstado.FieldName = "estado_seguimiento";
            this.gridColumnEstado.MinWidth = 30;
            this.gridColumnEstado.Name = "gridColumnEstado";
            this.gridColumnEstado.Visible = true;
            this.gridColumnEstado.VisibleIndex = 14;
            this.gridColumnEstado.Width = 112;
            // 
            // leEstadosSeguimiento
            // 
            this.leEstadosSeguimiento.AutoHeight = false;
            this.leEstadosSeguimiento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leEstadosSeguimiento.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("estado", "Estado")});
            this.leEstadosSeguimiento.Name = "leEstadosSeguimiento";
            // 
            // deFecha
            // 
            this.deFecha.AutoHeight = false;
            this.deFecha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Name = "deFecha";
            // 
            // cbMonedas
            // 
            this.cbMonedas.AutoHeight = false;
            this.cbMonedas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonedas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.cbMonedas.Name = "cbMonedas";
            // 
            // cbSeguimiento
            // 
            this.cbSeguimiento.AutoHeight = false;
            this.cbSeguimiento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeguimiento.Name = "cbSeguimiento";
            // 
            // cbEstadoSeguimiento
            // 
            this.cbEstadoSeguimiento.AutoHeight = false;
            this.cbEstadoSeguimiento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstadoSeguimiento.Items.AddRange(new object[] {
            "Recibido",
            "Pagado",
            "Preparado",
            "Enviado",
            "Entregado",
            "Cancelado"});
            this.cbEstadoSeguimiento.Name = "cbEstadoSeguimiento";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1185, 820);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDocumentos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1175, 686);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHide = false;
            this.layoutControlItem3.Control = this.layoutControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1175, 124);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmListaPedidosWeb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1185, 870);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaPedidosWeb";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de pedidos web";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leEstadosSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}