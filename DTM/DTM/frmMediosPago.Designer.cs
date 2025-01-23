using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;




namespace DTM
{
    partial class frmMediosPago
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarFormaPago = new DevExpress.XtraEditors.SimpleButton();
            this.lblCondicionPago = new DevExpress.XtraEditors.LabelControl();
            this.cbCondicionesPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClaseDocumento = new System.Windows.Forms.Label();
            this.cbUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsoPrincipal = new DevExpress.XtraEditors.LabelControl();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblDiferencia_ = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblTotalAplicado = new System.Windows.Forms.Label();
            this.lblTotalAplicado_ = new System.Windows.Forms.Label();
            this.gcPagos = new DevExpress.XtraGrid.GridControl();
            this.gvPagos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMetodosPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblImpuesto_ = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotal_ = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal_ = new System.Windows.Forms.Label();
            this.lblDescuento_ = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ssGeneral = new System.Windows.Forms.StatusStrip();
            this.lblLimiteCredito = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCreditoDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.ssGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(798, 57);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 57);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(798, 579);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarFormaPago);
            this.panel1.Controls.Add(this.lblCondicionPago);
            this.panel1.Controls.Add(this.cbCondicionesPago);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblClaseDocumento);
            this.panel1.Controls.Add(this.cbUsoPrincipal);
            this.panel1.Controls.Add(this.lblUsoPrincipal);
            this.panel1.Controls.Add(this.lblDiferencia);
            this.panel1.Controls.Add(this.lblDiferencia_);
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Controls.Add(this.lblTotalAplicado);
            this.panel1.Controls.Add(this.lblTotalAplicado_);
            this.panel1.Controls.Add(this.gcPagos);
            this.panel1.Controls.Add(this.lblImpuesto);
            this.panel1.Controls.Add(this.lblImpuesto_);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.lblSubTotal_);
            this.panel1.Controls.Add(this.lblDescuento);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTotal_);
            this.panel1.Controls.Add(this.lblDescuento_);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 555);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregarFormaPago
            // 
            this.btnAgregarFormaPago.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregarFormaPago.Location = new System.Drawing.Point(1, 5);
            this.btnAgregarFormaPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarFormaPago.Name = "btnAgregarFormaPago";
            this.btnAgregarFormaPago.Size = new System.Drawing.Size(214, 30);
            this.btnAgregarFormaPago.TabIndex = 105;
            this.btnAgregarFormaPago.Text = "Agregar forma de pago";
            this.btnAgregarFormaPago.Click += new System.EventHandler(this.btnAgregarFormaPago_Click);
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.Location = new System.Drawing.Point(15, 441);
            this.lblCondicionPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(116, 17);
            this.lblCondicionPago.TabIndex = 104;
            this.lblCondicionPago.Text = "Condición de pago";
            // 
            // cbCondicionesPago
            // 
            this.cbCondicionesPago.Location = new System.Drawing.Point(15, 466);
            this.cbCondicionesPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCondicionesPago.Name = "cbCondicionesPago";
            this.cbCondicionesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCondicionesPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("dias_extra", "Días extra", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("plazos", "Plazos", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("porcentaje_interes", "% Interes", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCondicionesPago.Size = new System.Drawing.Size(256, 24);
            this.cbCondicionesPago.TabIndex = 103;
            this.cbCondicionesPago.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(405, 388);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombre.Size = new System.Drawing.Size(346, 55);
            this.lblNombre.TabIndex = 102;
            this.lblNombre.Text = "Nombre SN";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClaseDocumento
            // 
            this.lblClaseDocumento.AutoEllipsis = true;
            this.lblClaseDocumento.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblClaseDocumento.ForeColor = System.Drawing.Color.Silver;
            this.lblClaseDocumento.Location = new System.Drawing.Point(405, 347);
            this.lblClaseDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClaseDocumento.Name = "lblClaseDocumento";
            this.lblClaseDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClaseDocumento.Size = new System.Drawing.Size(346, 35);
            this.lblClaseDocumento.TabIndex = 101;
            this.lblClaseDocumento.Text = "Entrega";
            this.lblClaseDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUsoPrincipal
            // 
            this.cbUsoPrincipal.Location = new System.Drawing.Point(15, 407);
            this.cbUsoPrincipal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbUsoPrincipal.Name = "cbUsoPrincipal";
            this.cbUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uso", "Uso", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsoPrincipal.Size = new System.Drawing.Size(256, 24);
            this.cbUsoPrincipal.TabIndex = 0;
            this.cbUsoPrincipal.TabStop = false;
            // 
            // lblUsoPrincipal
            // 
            this.lblUsoPrincipal.Location = new System.Drawing.Point(15, 382);
            this.lblUsoPrincipal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblUsoPrincipal.Name = "lblUsoPrincipal";
            this.lblUsoPrincipal.Size = new System.Drawing.Size(78, 17);
            this.lblUsoPrincipal.TabIndex = 98;
            this.lblUsoPrincipal.Text = "Uso principal";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoEllipsis = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiferencia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiferencia.Location = new System.Drawing.Point(494, 314);
            this.lblDiferencia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDiferencia.Size = new System.Drawing.Size(263, 33);
            this.lblDiferencia.TabIndex = 22;
            this.lblDiferencia.Text = "0.00";
            // 
            // lblDiferencia_
            // 
            this.lblDiferencia_.AutoSize = true;
            this.lblDiferencia_.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDiferencia_.Location = new System.Drawing.Point(400, 314);
            this.lblDiferencia_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiferencia_.Name = "lblDiferencia_";
            this.lblDiferencia_.Size = new System.Drawing.Size(64, 13);
            this.lblDiferencia_.TabIndex = 21;
            this.lblDiferencia_.Text = "Diferencia";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(405, 280);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.separatorControl1.Size = new System.Drawing.Size(354, 30);
            this.separatorControl1.TabIndex = 20;
            // 
            // lblTotalAplicado
            // 
            this.lblTotalAplicado.AutoEllipsis = true;
            this.lblTotalAplicado.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAplicado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalAplicado.Location = new System.Drawing.Point(494, 243);
            this.lblTotalAplicado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalAplicado.Name = "lblTotalAplicado";
            this.lblTotalAplicado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalAplicado.Size = new System.Drawing.Size(263, 33);
            this.lblTotalAplicado.TabIndex = 19;
            this.lblTotalAplicado.Text = "0.00";
            // 
            // lblTotalAplicado_
            // 
            this.lblTotalAplicado_.AutoSize = true;
            this.lblTotalAplicado_.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalAplicado_.Location = new System.Drawing.Point(400, 243);
            this.lblTotalAplicado_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalAplicado_.Name = "lblTotalAplicado_";
            this.lblTotalAplicado_.Size = new System.Drawing.Size(55, 13);
            this.lblTotalAplicado_.TabIndex = 18;
            this.lblTotalAplicado_.Text = "Aplicado";
            // 
            // gcPagos
            // 
            this.gcPagos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.gcPagos.Location = new System.Drawing.Point(0, 39);
            this.gcPagos.MainView = this.gvPagos;
            this.gcPagos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPagos.MenuManager = this.ribbonControl1;
            this.gcPagos.Name = "gcPagos";
            this.gcPagos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbMetodosPago});
            this.gcPagos.Size = new System.Drawing.Size(766, 200);
            this.gcPagos.TabIndex = 1;
            this.gcPagos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPagos});
            // 
            // gvPagos
            // 
            this.gvPagos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnMetodoPago,
            this.gridColumnTC,
            this.gridColumnReferencia,
            this.gridColumnImporte,
            this.gridColumnTotal});
            this.gvPagos.DetailHeight = 458;
            this.gvPagos.GridControl = this.gcPagos;
            this.gvPagos.Name = "gvPagos";
            this.gvPagos.OptionsCustomization.AllowColumnMoving = false;
            this.gvPagos.OptionsCustomization.AllowFilter = false;
            this.gvPagos.OptionsCustomization.AllowSort = false;
            this.gvPagos.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvPagos.OptionsView.ShowGroupPanel = false;
            this.gvPagos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPagos_CellValueChanged);
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.MinWidth = 26;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 99;
            // 
            // gridColumnMetodoPago
            // 
            this.gridColumnMetodoPago.Caption = "Método de pago";
            this.gridColumnMetodoPago.ColumnEdit = this.cbMetodosPago;
            this.gridColumnMetodoPago.FieldName = "tipo_metodo_pago_id";
            this.gridColumnMetodoPago.MaxWidth = 160;
            this.gridColumnMetodoPago.MinWidth = 26;
            this.gridColumnMetodoPago.Name = "gridColumnMetodoPago";
            this.gridColumnMetodoPago.Visible = true;
            this.gridColumnMetodoPago.VisibleIndex = 0;
            this.gridColumnMetodoPago.Width = 160;
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.AutoHeight = false;
            this.cbMetodosPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodosPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbMetodosPago.Name = "cbMetodosPago";
            // 
            // gridColumnTC
            // 
            this.gridColumnTC.Caption = "TC";
            this.gridColumnTC.FieldName = "tipo_cambio";
            this.gridColumnTC.MaxWidth = 66;
            this.gridColumnTC.MinWidth = 26;
            this.gridColumnTC.Name = "gridColumnTC";
            this.gridColumnTC.OptionsColumn.AllowEdit = false;
            this.gridColumnTC.Visible = true;
            this.gridColumnTC.VisibleIndex = 1;
            this.gridColumnTC.Width = 63;
            // 
            // gridColumnReferencia
            // 
            this.gridColumnReferencia.Caption = "Referencia";
            this.gridColumnReferencia.FieldName = "referencia";
            this.gridColumnReferencia.MinWidth = 26;
            this.gridColumnReferencia.Name = "gridColumnReferencia";
            this.gridColumnReferencia.Visible = true;
            this.gridColumnReferencia.VisibleIndex = 2;
            this.gridColumnReferencia.Width = 134;
            // 
            // gridColumnImporte
            // 
            this.gridColumnImporte.Caption = "Importe";
            this.gridColumnImporte.DisplayFormat.FormatString = "C";
            this.gridColumnImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnImporte.FieldName = "importe";
            this.gridColumnImporte.MinWidth = 26;
            this.gridColumnImporte.Name = "gridColumnImporte";
            this.gridColumnImporte.Visible = true;
            this.gridColumnImporte.VisibleIndex = 3;
            this.gridColumnImporte.Width = 134;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatString = "C";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "gridColumnTotal";
            this.gridColumnTotal.MinWidth = 26;
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnTotal.UnboundExpression = "tipo_cambio * importe";
            this.gridColumnTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 4;
            this.gridColumnTotal.Width = 147;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoEllipsis = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblImpuesto.ForeColor = System.Drawing.Color.Gray;
            this.lblImpuesto.Location = new System.Drawing.Point(88, 307);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpuesto.Size = new System.Drawing.Size(187, 29);
            this.lblImpuesto.TabIndex = 16;
            this.lblImpuesto.Text = "0.00";
            // 
            // lblImpuesto_
            // 
            this.lblImpuesto_.AutoSize = true;
            this.lblImpuesto_.ForeColor = System.Drawing.Color.Gray;
            this.lblImpuesto_.Location = new System.Drawing.Point(10, 307);
            this.lblImpuesto_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblImpuesto_.Name = "lblImpuesto_";
            this.lblImpuesto_.Size = new System.Drawing.Size(64, 17);
            this.lblImpuesto_.TabIndex = 15;
            this.lblImpuesto_.Text = "Impuesto";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoEllipsis = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTotal.Location = new System.Drawing.Point(72, 243);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubTotal.Size = new System.Drawing.Size(203, 29);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "0.00";
            // 
            // lblSubTotal_
            // 
            this.lblSubTotal_.AutoSize = true;
            this.lblSubTotal_.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTotal_.Location = new System.Drawing.Point(10, 243);
            this.lblSubTotal_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTotal_.Name = "lblSubTotal_";
            this.lblSubTotal_.Size = new System.Drawing.Size(63, 17);
            this.lblSubTotal_.TabIndex = 13;
            this.lblSubTotal_.Text = "SubTotal";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoEllipsis = true;
            this.lblDescuento.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDescuento.ForeColor = System.Drawing.Color.Gray;
            this.lblDescuento.Location = new System.Drawing.Point(96, 275);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescuento.Size = new System.Drawing.Size(181, 29);
            this.lblDescuento.TabIndex = 10;
            this.lblDescuento.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(72, 341);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(203, 33);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0.00";
            // 
            // lblTotal_
            // 
            this.lblTotal_.AutoSize = true;
            this.lblTotal_.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal_.Location = new System.Drawing.Point(10, 347);
            this.lblTotal_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal_.Name = "lblTotal_";
            this.lblTotal_.Size = new System.Drawing.Size(36, 13);
            this.lblTotal_.TabIndex = 8;
            this.lblTotal_.Text = "Total";
            // 
            // lblDescuento_
            // 
            this.lblDescuento_.AutoSize = true;
            this.lblDescuento_.ForeColor = System.Drawing.Color.Gray;
            this.lblDescuento_.Location = new System.Drawing.Point(10, 275);
            this.lblDescuento_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescuento_.Name = "lblDescuento_";
            this.lblDescuento_.Size = new System.Drawing.Size(71, 17);
            this.lblDescuento_.TabIndex = 7;
            this.lblDescuento_.Text = "Descuento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(405, 456);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(152)))), ((int)(((byte)(33)))));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(601, 456);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 35);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(798, 579);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(776, 559);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ssGeneral
            // 
            this.ssGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLimiteCredito,
            this.toolStripStatusLabel1,
            this.lblCreditoDisponible});
            this.ssGeneral.Location = new System.Drawing.Point(0, 614);
            this.ssGeneral.Name = "ssGeneral";
            this.ssGeneral.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.ssGeneral.Size = new System.Drawing.Size(798, 22);
            this.ssGeneral.SizingGrip = false;
            this.ssGeneral.TabIndex = 0;
            this.ssGeneral.Text = "Nori";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(114, 17);
            this.lblLimiteCredito.Text = "Limite de crédito: $0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 17);
            // 
            // lblCreditoDisponible
            // 
            this.lblCreditoDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditoDisponible.Name = "lblCreditoDisponible";
            this.lblCreditoDisponible.Size = new System.Drawing.Size(122, 17);
            this.lblCreditoDisponible.Text = "Crédito disponible: $0";
            // 
            // frmMediosPago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(798, 636);
            this.Controls.Add(this.ssGeneral);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMediosPago";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medios de pago";
            this.Activated += new System.EventHandler(this.frmPagos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCondicionesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodosPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ssGeneral.ResumeLayout(false);
            this.ssGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}