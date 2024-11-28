using System;
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

namespace NORI.Restaurante
{
    partial class frmComanda
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
            //IL_0012: Unknown result type (might be due to invalid IL or missing references)
            //IL_001c: Expected O, but got Unknown
            //IL_001d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0027: Expected O, but got Unknown
            //IL_0028: Unknown result type (might be due to invalid IL or missing references)
            //IL_0032: Expected O, but got Unknown
            //IL_0033: Unknown result type (might be due to invalid IL or missing references)
            //IL_003d: Expected O, but got Unknown
            //IL_003e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0048: Expected O, but got Unknown
            //IL_0049: Unknown result type (might be due to invalid IL or missing references)
            //IL_0053: Expected O, but got Unknown
            //IL_0054: Unknown result type (might be due to invalid IL or missing references)
            //IL_005e: Expected O, but got Unknown
            //IL_005f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0069: Expected O, but got Unknown
            //IL_006a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0074: Expected O, but got Unknown
            //IL_0075: Unknown result type (might be due to invalid IL or missing references)
            //IL_007f: Expected O, but got Unknown
            //IL_0080: Unknown result type (might be due to invalid IL or missing references)
            //IL_008a: Expected O, but got Unknown
            //IL_008b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0095: Expected O, but got Unknown
            //IL_0096: Unknown result type (might be due to invalid IL or missing references)
            //IL_00a0: Expected O, but got Unknown
            //IL_00a1: Unknown result type (might be due to invalid IL or missing references)
            //IL_00ab: Expected O, but got Unknown
            //IL_00ac: Unknown result type (might be due to invalid IL or missing references)
            //IL_00b6: Expected O, but got Unknown
            //IL_00b7: Unknown result type (might be due to invalid IL or missing references)
            //IL_00c1: Expected O, but got Unknown
            //IL_00c2: Unknown result type (might be due to invalid IL or missing references)
            //IL_00cc: Expected O, but got Unknown
            //IL_00cd: Unknown result type (might be due to invalid IL or missing references)
            //IL_00d7: Expected O, but got Unknown
            //IL_00d8: Unknown result type (might be due to invalid IL or missing references)
            //IL_00e2: Expected O, but got Unknown
            //IL_00e3: Unknown result type (might be due to invalid IL or missing references)
            //IL_00ed: Expected O, but got Unknown
            //IL_00f9: Unknown result type (might be due to invalid IL or missing references)
            //IL_0103: Expected O, but got Unknown
            //IL_010f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0119: Expected O, but got Unknown
            //IL_011a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0124: Expected O, but got Unknown
            //IL_0125: Unknown result type (might be due to invalid IL or missing references)
            //IL_012f: Expected O, but got Unknown
            //IL_0130: Unknown result type (might be due to invalid IL or missing references)
            //IL_013a: Expected O, but got Unknown
            //IL_013b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0145: Expected O, but got Unknown
            //IL_0146: Unknown result type (might be due to invalid IL or missing references)
            //IL_0150: Expected O, but got Unknown
            //IL_0151: Unknown result type (might be due to invalid IL or missing references)
            //IL_015b: Expected O, but got Unknown
            //IL_015c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0166: Expected O, but got Unknown
            //IL_0167: Unknown result type (might be due to invalid IL or missing references)
            //IL_0171: Expected O, but got Unknown
            //IL_0172: Unknown result type (might be due to invalid IL or missing references)
            //IL_017c: Expected O, but got Unknown
            //IL_017d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0187: Expected O, but got Unknown
            //IL_0188: Unknown result type (might be due to invalid IL or missing references)
            //IL_0192: Expected O, but got Unknown
            //IL_0193: Unknown result type (might be due to invalid IL or missing references)
            //IL_019d: Expected O, but got Unknown
            //IL_019e: Unknown result type (might be due to invalid IL or missing references)
            //IL_01a8: Expected O, but got Unknown
            //IL_01bf: Unknown result type (might be due to invalid IL or missing references)
            //IL_01c9: Expected O, but got Unknown
            //IL_01ca: Unknown result type (might be due to invalid IL or missing references)
            //IL_01d4: Expected O, but got Unknown
            //IL_01d5: Unknown result type (might be due to invalid IL or missing references)
            //IL_01df: Expected O, but got Unknown
            //IL_0bde: Unknown result type (might be due to invalid IL or missing references)
            //IL_0be4: Expected O, but got Unknown
            //IL_0c16: Unknown result type (might be due to invalid IL or missing references)
            //IL_0c1c: Expected O, but got Unknown
            //IL_0c28: Unknown result type (might be due to invalid IL or missing references)
            //IL_0c2e: Expected O, but got Unknown
            //IL_16b4: Unknown result type (might be due to invalid IL or missing references)
            //IL_16ba: Expected O, but got Unknown
            //IL_16e7: Unknown result type (might be due to invalid IL or missing references)
            //IL_16ed: Expected O, but got Unknown
            //IL_16f9: Unknown result type (might be due to invalid IL or missing references)
            //IL_16ff: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmComanda));
            mainRibbonControl = new RibbonControl();
            bbiGuardar = new BarButtonItem();
            bbiGuardarCerrar = new BarButtonItem();
            bbiGuardarNuevo = new BarButtonItem();
            bbiEliminar = new BarButtonItem();
            bbiRestablecer = new BarButtonItem();
            bbiBuscar = new BarButtonItem();
            bbiPrimero = new BarButtonItem();
            bbiAnterior = new BarButtonItem();
            bbiUltimo = new BarButtonItem();
            bbiSiguiente = new BarButtonItem();
            bbiNuevo = new BarButtonItem();
            bbiImprimir = new BarButtonItem();
            mainRibbonPage = new RibbonPage();
            mainRibbonPageGroup = new RibbonPageGroup();
            layoutControl1 = new LayoutControl();
            splitContainerControlComanda = new SplitContainerControl();
            splitContainerControlArticulos = new SplitContainerControl();
            lblVendedores = new LabelControl();
            cbVendedores = new LookUpEdit();
            pictureBox1 = new PictureBox();
            txtArticulo = new TextEdit();
            tlp = new TableLayoutPanel();
            splitContainerControlPartidas = new SplitContainerControl();
            gcPartidas = new GridControl();
            gvPartidas = new GridView();
            gridColumnCantidad = new GridColumn();
            gridColumnSKU = new GridColumn();
            gridColumnArticulo = new GridColumn();
            gridColumnCodigoBarras = new GridColumn();
            gridColumnPrecio = new GridColumn();
            gridColumnPrecioNeto = new GridColumn();
            gridColumnPorcentajeDescuento = new GridColumn();
            gridColumnDescuento = new GridColumn();
            gridColumnSubTotal = new GridColumn();
            gridColumnTotal = new GridColumn();
            cbMonedas = new RepositoryItemLookUpEdit();
            lblTotal = new Label();
            lblTotal_ = new Label();
            layoutControlGroup1 = new LayoutControlGroup();
            layoutControlItem1 = new LayoutControlItem();
            btnAtras = new SimpleButton();
            ((ISupportInitialize)mainRibbonControl).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            ((Control)(object)layoutControl1).SuspendLayout();
            ((ISupportInitialize)splitContainerControlComanda).BeginInit();
            ((Control)(object)splitContainerControlComanda).SuspendLayout();
            ((ISupportInitialize)splitContainerControlArticulos).BeginInit();
            ((Control)(object)splitContainerControlArticulos).SuspendLayout();
            ((ISupportInitialize)cbVendedores.Properties).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)txtArticulo.Properties).BeginInit();
            ((ISupportInitialize)splitContainerControlPartidas).BeginInit();
            ((Control)(object)splitContainerControlPartidas).SuspendLayout();
            ((ISupportInitialize)gcPartidas).BeginInit();
            ((ISupportInitialize)gvPartidas).BeginInit();
            ((ISupportInitialize)cbMonedas).BeginInit();
            ((ISupportInitialize)layoutControlGroup1).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((BarItem)mainRibbonControl.ExpandCollapseItem).Id = 0;
            ((BarItems)mainRibbonControl.Items).AddRange((BarItem[])(object)new BarItem[13]
            {
            (BarItem)mainRibbonControl.ExpandCollapseItem,
            (BarItem)bbiGuardar,
            (BarItem)bbiGuardarCerrar,
            (BarItem)bbiGuardarNuevo,
            (BarItem)bbiEliminar,
            (BarItem)bbiRestablecer,
            (BarItem)bbiBuscar,
            (BarItem)bbiPrimero,
            (BarItem)bbiAnterior,
            (BarItem)bbiUltimo,
            (BarItem)bbiSiguiente,
            (BarItem)bbiNuevo,
            (BarItem)bbiImprimir
            });
            ((Control)(object)mainRibbonControl).Location = new Point(0, 0);
            mainRibbonControl.MaxItemId = 3;
            ((Control)(object)mainRibbonControl).Name = "mainRibbonControl";
            mainRibbonControl.Pages.AddRange((RibbonPage[])(object)new RibbonPage[1] { mainRibbonPage });
            mainRibbonControl.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            mainRibbonControl.ShowApplicationButton = (DefaultBoolean.False);
            ((Control)(object)mainRibbonControl).Size = new Size(798, 83);
            mainRibbonControl.ToolbarLocation = (RibbonQuickAccessToolbarLocation.Hidden);
            ((BarItem)bbiGuardar).Caption = "Guardar";
            ((BarItem)bbiGuardar).Id = 2;
            ((BarItem)bbiGuardar).ImageUri.Uri = "Save";
            ((BarItem)bbiGuardar).Name = "bbiGuardar";
            ((BarItem)bbiGuardarCerrar).Caption = "Guardar y cerrar";
            ((BarItem)bbiGuardarCerrar).Id = 3;
            ((BarItem)bbiGuardarCerrar).ImageUri.Uri = "SaveAndClose";
            ((BarItem)bbiGuardarCerrar).Name = "bbiGuardarCerrar";
            ((BarItem)bbiGuardarCerrar).RibbonStyle = (RibbonItemStyles.Default);
            ((BarItem)bbiGuardarNuevo).Caption = "Guardar y nuevo";
            ((BarItem)bbiGuardarNuevo).Id = 4;
            ((BarItem)bbiGuardarNuevo).ImageUri.Uri = "SaveAndNew";
            ((BarItem)bbiGuardarNuevo).Name = "bbiGuardarNuevo";
            ((BarItem)bbiEliminar).Caption = "Eliminar";
            ((BarItem)bbiEliminar).Id = 6;
            ((BarItem)bbiEliminar).ImageUri.Uri = "Delete";
            ((BarItem)bbiEliminar).Name = "bbiEliminar";
            ((BarItem)bbiRestablecer).Id = 1;
            ((BarItem)bbiRestablecer).Name = "bbiRestablecer";
            ((BarItem)bbiBuscar).Caption = "Buscar";
            ((BarItem)bbiBuscar).Id = 4;
            ((BarItem)bbiBuscar).ImageUri.Uri = "Find";
            ((BarItem)bbiBuscar).Name = "bbiBuscar";
            ((BarItem)bbiBuscar).RibbonStyle = (RibbonItemStyles.SmallWithoutText);
            ((BarItem)bbiPrimero).Caption = "Primero";
            ((BarItem)bbiPrimero).Id = 5;
            ((BarItem)bbiPrimero).ImageUri.Uri = "First";
            ((BarItem)bbiPrimero).Name = "bbiPrimero";
            ((BarItem)bbiPrimero).RibbonStyle = (RibbonItemStyles.SmallWithoutText);
            ((BarItem)bbiAnterior).Caption = "Anterior";
            ((BarItem)bbiAnterior).Id = 6;
            ((BarItem)bbiAnterior).ImageUri.Uri = "Prev";
            ((BarItem)bbiAnterior).Name = "bbiAnterior";
            ((BarItem)bbiAnterior).RibbonStyle = (RibbonItemStyles.SmallWithoutText);
            ((BarItem)bbiUltimo).Caption = "Último";
            ((BarItem)bbiUltimo).Id = 7;
            ((BarItem)bbiUltimo).ImageUri.Uri = "Last";
            ((BarItem)bbiUltimo).Name = "bbiUltimo";
            ((BarItem)bbiUltimo).RibbonStyle = (RibbonItemStyles.SmallWithoutText);
            ((BarItem)bbiSiguiente).AllowGlyphSkinning = (DefaultBoolean.False);
            ((BarItem)bbiSiguiente).Caption = "Siguiente";
            ((BarItem)bbiSiguiente).Id = 8;
            ((BarItem)bbiSiguiente).ImageUri.Uri = "Next";
            ((BarItem)bbiSiguiente).Name = "bbiSiguiente";
            ((BarItem)bbiSiguiente).RibbonStyle = (RibbonItemStyles.SmallWithoutText);
            ((BarItem)bbiNuevo).Caption = "Nuevo";
            ((BarItem)bbiNuevo).Id = 1;
            ((BarItem)bbiNuevo).ImageUri.Uri = "Add";
            ((BarItem)bbiNuevo).Name = "bbiNuevo";
            ((BarItem)bbiNuevo).RibbonStyle = (RibbonItemStyles.Large);
            ((BarItem)bbiImprimir).Caption = "Imprimir";
            ((BarItem)bbiImprimir).Id = 2;
            ((BarItem)bbiImprimir).ImageUri.Uri = "Print";
            ((BarItem)bbiImprimir).Name = "bbiImprimir";
            mainRibbonPage.Groups.AddRange((RibbonPageGroup[])(object)new RibbonPageGroup[1] { mainRibbonPageGroup });
            mainRibbonPage.MergeOrder = 0;
            mainRibbonPage.Name = "mainRibbonPage";
            mainRibbonPage.Text = "ARCHIVO";
            mainRibbonPageGroup.AllowTextClipping = false;
            ((BarItemLinkCollection)mainRibbonPageGroup.ItemLinks).Add((BarItem)(object)bbiGuardar);
            ((BarItemLinkCollection)mainRibbonPageGroup.ItemLinks).Add((BarItem)(object)bbiGuardarCerrar);
            ((BarItemLinkCollection)mainRibbonPageGroup.ItemLinks).Add((BarItem)(object)bbiImprimir);
            mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            mainRibbonPageGroup.ShowCaptionButton = false;
            mainRibbonPageGroup.Text = "Opciones";
            ((Control)(object)layoutControl1).Controls.Add((Control)(object)splitContainerControlComanda);
            ((Control)(object)layoutControl1).Dock = DockStyle.Fill;
            ((Control)(object)layoutControl1).Location = new Point(0, 83);
            ((Control)(object)layoutControl1).Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(92, 301, 250, 350);
            layoutControl1.Root = layoutControlGroup1;
            ((Control)(object)layoutControl1).Size = new Size(798, 516);
            ((Control)(object)layoutControl1).TabIndex = 57;
            ((Control)(object)layoutControl1).Text = "layoutControl1";
            ((Control)(object)splitContainerControlComanda).Location = new Point(12, 12);
            ((Control)(object)splitContainerControlComanda).Name = "splitContainerControlComanda";
            ((Control)(object)splitContainerControlComanda.Panel1).Controls.Add((Control)(object)splitContainerControlArticulos);
            ((Control)(object)splitContainerControlComanda.Panel1).Text = "Panel1";
            ((Control)(object)splitContainerControlComanda.Panel2).Controls.Add((Control)(object)splitContainerControlPartidas);
            ((Control)(object)splitContainerControlComanda.Panel2).Text = "Panel2";
            ((Control)(object)splitContainerControlComanda).Size = new Size(774, 492);
            splitContainerControlComanda.SplitterPosition = 373;
            ((Control)(object)splitContainerControlComanda).TabIndex = 4;
            ((Control)(object)splitContainerControlComanda).Text = "splitContainerControl1";
            ((Control)(object)splitContainerControlArticulos).Dock = DockStyle.Fill;
            splitContainerControlArticulos.Horizontal = false;
            ((Control)(object)splitContainerControlArticulos).Location = new Point(0, 0);
            ((Control)(object)splitContainerControlArticulos).Name = "splitContainerControlArticulos";
            ((Control)(object)splitContainerControlArticulos.Panel1).Controls.Add((Control)(object)lblVendedores);
            ((Control)(object)splitContainerControlArticulos.Panel1).Controls.Add((Control)(object)cbVendedores);
            ((Control)(object)splitContainerControlArticulos.Panel1).Controls.Add(pictureBox1);
            ((Control)(object)splitContainerControlArticulos.Panel1).Controls.Add((Control)(object)txtArticulo);
            ((Control)(object)splitContainerControlArticulos.Panel1).Text = "Panel1";
            ((ScrollableControl)(object)splitContainerControlArticulos.Panel2).AutoScroll = true;
            ((Control)(object)splitContainerControlArticulos.Panel2).Controls.Add(tlp);
            ((Control)(object)splitContainerControlArticulos.Panel2).Text = "Panel2";
            ((Control)(object)splitContainerControlArticulos).Size = new Size(373, 492);
            splitContainerControlArticulos.SplitterPosition = 56;
            ((Control)(object)splitContainerControlArticulos).TabIndex = 0;
            ((Control)(object)splitContainerControlArticulos).Text = "splitContainerControl2";
            ((Control)(object)lblVendedores).Location = new Point(4, 35);
            ((Control)(object)lblVendedores).Name = "lblVendedores";
            ((Control)(object)lblVendedores).Size = new Size(35, 13);
            ((Control)(object)lblVendedores).TabIndex = 85;
            ((Control)(object)lblVendedores).Text = "Mesero";
            ((Control)(object)cbVendedores).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ((Control)(object)cbVendedores).Location = new Point(106, 32);
            ((BaseEdit)cbVendedores).MenuManager = (IDXMenuManager)(object)mainRibbonControl;
            ((Control)(object)cbVendedores).Name = "cbVendedores";
            ((RepositoryItemButtonEdit)cbVendedores.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbVendedores.Properties.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("id", "ID", 20,(FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("nombre", "Nombre")
            });
            ((Control)(object)cbVendedores).Size = new Size(262, 20);
            ((Control)(object)cbVendedores).TabIndex = 83;
            ((BaseEdit)cbVendedores).TabStop = false;
            pictureBox1.BackColor = Color.Transparent;
            //pictureBox1.Image = Resources.barcode;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            ((Control)(object)txtArticulo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ((Control)(object)txtArticulo).Location = new Point(34, 6);
            ((Control)(object)txtArticulo).Name = "txtArticulo";
            ((Control)(object)txtArticulo).Size = new Size(334, 20);
            ((Control)(object)txtArticulo).TabIndex = 19;
            ((Control)(object)txtArticulo).KeyDown += txtArticulo_KeyDown;
            tlp.AutoScroll = true;
            tlp.ColumnCount = 3;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            tlp.Dock = DockStyle.Fill;
            tlp.Location = new Point(0, 0);
            tlp.Name = "tlp";
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.Size = new Size(373, 424);
            tlp.TabIndex = 1;
            ((Control)(object)splitContainerControlPartidas).Dock = DockStyle.Fill;
            splitContainerControlPartidas.FixedPanel = (SplitFixedPanel.Panel2);
            splitContainerControlPartidas.Horizontal = false;
            ((Control)(object)splitContainerControlPartidas).Location = new Point(0, 0);
            ((Control)(object)splitContainerControlPartidas).Name = "splitContainerControlPartidas";
            ((Control)(object)splitContainerControlPartidas.Panel1).Controls.Add((Control)(object)gcPartidas);
            ((Control)(object)splitContainerControlPartidas.Panel1).Text = "Panel1";
            ((Control)(object)splitContainerControlPartidas.Panel2).Controls.Add((Control)(object)btnAtras);
            ((Control)(object)splitContainerControlPartidas.Panel2).Controls.Add(lblTotal);
            ((Control)(object)splitContainerControlPartidas.Panel2).Controls.Add(lblTotal_);
            splitContainerControlPartidas.Panel2.MinSize = 55;
            ((Control)(object)splitContainerControlPartidas.Panel2).Text = "Panel2";
            ((Control)(object)splitContainerControlPartidas).Size = new Size(389, 492);
            splitContainerControlPartidas.SplitterPosition = 55;
            ((Control)(object)splitContainerControlPartidas).TabIndex = 0;
            ((Control)(object)splitContainerControlPartidas).Text = "splitContainerControl1";
            ((Control)(object)gcPartidas).Dock = DockStyle.Fill;
            ((Control)(object)gcPartidas).Location = new Point(0, 0);
            gcPartidas.MainView = (BaseView)(object)gvPartidas;
            ((Control)(object)gcPartidas).Name = "gcPartidas";
            ((EditorContainer)gcPartidas).RepositoryItems.AddRange((RepositoryItem[])(object)new RepositoryItem[1] { (RepositoryItem)cbMonedas });
            ((Control)(object)gcPartidas).Size = new Size(389, 425);
            ((Control)(object)gcPartidas).TabIndex = 3;
            ((Control)(object)gcPartidas).TabStop = false;
            gcPartidas.ViewCollection.AddRange((BaseView[])(object)new BaseView[1] { (BaseView)gvPartidas });
            ((BaseView)gvPartidas).BorderStyle = (BorderStyles.NoBorder);
            ((ColumnView)gvPartidas).Columns.AddRange((GridColumn[])(object)new GridColumn[10] { gridColumnCantidad, gridColumnSKU, gridColumnArticulo, gridColumnCodigoBarras, gridColumnPrecio, gridColumnPrecioNeto, gridColumnPorcentajeDescuento, gridColumnDescuento, gridColumnSubTotal, gridColumnTotal });
            ((BaseView)gvPartidas).GridControl = gcPartidas;
            ((BaseView)gvPartidas).Name = "gvPartidas";
            gvPartidas.OptionsDetail.DetailMode = (DetailMode.Default);
            gvPartidas.OptionsView.ShowFooter = true;
            gvPartidas.OptionsView.ShowGroupPanel = false;
            gridColumnCantidad.Caption = "Cant";
            gridColumnCantidad.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnCantidad.FieldName = "cantidad";
            gridColumnCantidad.MaxWidth = 40;
            gridColumnCantidad.MinWidth = 40;
            gridColumnCantidad.Name = "gridColumnCantidad";
            gridColumnCantidad.OptionsColumn.FixedWidth = true;
            gridColumnCantidad.Visible = true;
            gridColumnCantidad.VisibleIndex = 0;
            gridColumnCantidad.Width = 40;
            gridColumnSKU.Caption = "SKU";
            gridColumnSKU.FieldName = "sku";
            gridColumnSKU.MaxWidth = 150;
            gridColumnSKU.MinWidth = 60;
            gridColumnSKU.Name = "gridColumnSKU";
            gridColumnSKU.OptionsColumn.AllowEdit = false;
            gridColumnSKU.Width = 63;
            gridColumnArticulo.Caption = "Artículo";
            gridColumnArticulo.FieldName = "nombre";
            gridColumnArticulo.MinWidth = 100;
            gridColumnArticulo.Name = "gridColumnArticulo";
            gridColumnArticulo.OptionsColumn.AllowEdit = false;
            gridColumnArticulo.Visible = true;
            gridColumnArticulo.VisibleIndex = 1;
            gridColumnArticulo.Width = 120;
            gridColumnCodigoBarras.Caption = "Código de barras";
            gridColumnCodigoBarras.FieldName = "codigo_barras";
            gridColumnCodigoBarras.MaxWidth = 120;
            gridColumnCodigoBarras.MinWidth = 80;
            gridColumnCodigoBarras.Name = "gridColumnCodigoBarras";
            gridColumnCodigoBarras.OptionsColumn.AllowEdit = false;
            gridColumnCodigoBarras.Width = 97;
            gridColumnPrecio.Caption = "Precio";
            gridColumnPrecio.DisplayFormat.FormatString = "c2";
            gridColumnPrecio.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnPrecio.FieldName = "gridColumnPrecio";
            gridColumnPrecio.MinWidth = 60;
            gridColumnPrecio.Name = "gridColumnPrecio";
            gridColumnPrecio.OptionsColumn.AllowEdit = false;
            gridColumnPrecio.UnboundExpression = "precio * tipo_cambio";
            gridColumnPrecio.UnboundType = (UnboundColumnType.Decimal);
            gridColumnPrecio.Width = 60;
            gridColumnPrecioNeto.Caption = "PU. Neto";
            gridColumnPrecioNeto.DisplayFormat.FormatString = "c2";
            gridColumnPrecioNeto.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnPrecioNeto.FieldName = "gridColumnPrecioNeto";
            gridColumnPrecioNeto.MinWidth = 60;
            gridColumnPrecioNeto.Name = "gridColumnPrecioNeto";
            gridColumnPrecioNeto.UnboundExpression = "(precio * tipo_cambio) + impuesto";
            gridColumnPrecioNeto.UnboundType = (UnboundColumnType.Decimal);
            gridColumnPrecioNeto.Visible = true;
            gridColumnPrecioNeto.VisibleIndex = 2;
            gridColumnPrecioNeto.Width = 60;
            gridColumnPorcentajeDescuento.Caption = "% Dscto";
            gridColumnPorcentajeDescuento.DisplayFormat.FormatString = "p2";
            gridColumnPorcentajeDescuento.FieldName = "porcentaje_descuento";
            gridColumnPorcentajeDescuento.MaxWidth = 50;
            gridColumnPorcentajeDescuento.Name = "gridColumnPorcentajeDescuento";
            gridColumnPorcentajeDescuento.OptionsColumn.FixedWidth = true;
            gridColumnPorcentajeDescuento.Width = 50;
            gridColumnDescuento.Caption = "Descuento";
            gridColumnDescuento.DisplayFormat.FormatString = "c2";
            gridColumnDescuento.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnDescuento.FieldName = "descuento";
            gridColumnDescuento.MaxWidth = 120;
            gridColumnDescuento.MinWidth = 60;
            gridColumnDescuento.Name = "gridColumnDescuento";
            gridColumnDescuento.OptionsColumn.AllowEdit = false;
            gridColumnDescuento.Width = 60;
            gridColumnSubTotal.Caption = "SubTotal";
            gridColumnSubTotal.DisplayFormat.FormatString = "c2";
            gridColumnSubTotal.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnSubTotal.FieldName = "subtotal";
            gridColumnSubTotal.MinWidth = 60;
            gridColumnSubTotal.Name = "gridColumnSubTotal";
            gridColumnSubTotal.OptionsColumn.AllowEdit = false;
            gridColumnSubTotal.Width = 60;
            gridColumnTotal.Caption = "Total";
            gridColumnTotal.DisplayFormat.FormatString = "c2";
            gridColumnTotal.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumnTotal.FieldName = "total";
            gridColumnTotal.MinWidth = 60;
            gridColumnTotal.Name = "gridColumnTotal";
            gridColumnTotal.Visible = true;
            gridColumnTotal.VisibleIndex = 3;
            gridColumnTotal.Width = 60;
            ((RepositoryItem)cbMonedas).AutoHeight = false;
            ((RepositoryItemButtonEdit)cbMonedas).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbMonedas.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("id", "ID", 20, (FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("codigo", "Código")
            });
            ((RepositoryItem)cbMonedas).Name = "cbMonedas";
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoEllipsis = true;
            lblTotal.Font = new Font("Tahoma", 22f, FontStyle.Bold);
            lblTotal.Location = new Point(231, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.Yes;
            lblTotal.Size = new Size(153, 36);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0.00";
            lblTotal_.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal_.AutoSize = true;
            lblTotal_.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            lblTotal_.Location = new Point(185, 12);
            lblTotal_.Name = "lblTotal_";
            lblTotal_.Size = new Size(36, 13);
            lblTotal_.TabIndex = 4;
            lblTotal_.Text = "Total";
            ((LayoutGroup)layoutControlGroup1).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup1).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup1.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[1] { (BaseLayoutItem)layoutControlItem1 });
            ((BaseLayoutItem)layoutControlGroup1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup1).Name = "Root";
            ((BaseLayoutItem)layoutControlGroup1).Size = new Size(798, 516);
            ((BaseLayoutItem)layoutControlGroup1).TextVisible = false;
            layoutControlItem1.Control = (Control)(object)splitContainerControlComanda;
            ((BaseLayoutItem)layoutControlItem1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem1).Name = "layoutControlItem1";
            ((BaseLayoutItem)layoutControlItem1).Size = new Size(778, 496);
            ((BaseLayoutItem)layoutControlItem1).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem1).TextVisible = false;
            //btnAtras.Image = (Image)componentResourceManager.GetObject("btnAtras.Image");
            btnAtras.ImageLocation = (ImageLocation.MiddleCenter);
            ((Control)(object)btnAtras).Location = new Point(2, 3);
            ((Control)(object)btnAtras).Name = "btnAtras";
            ((Control)(object)btnAtras).Size = new Size(80, 50);
            ((Control)(object)btnAtras).TabIndex = 6;
            ((Control)(object)btnAtras).Click += btnAtras_Click;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(798, 599);
            ((Control)this).Controls.Add((Control)(object)layoutControl1);
            ((Control)this).Controls.Add((Control)(object)mainRibbonControl);
            ((Form)this).FormBorderStyle = FormBorderStyle.FixedSingle;
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Control)this).Name = "frmComanda";
            ((RibbonForm)this).Ribbon = mainRibbonControl;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Comanda";
            ((ISupportInitialize)mainRibbonControl).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            ((Control)(object)layoutControl1).ResumeLayout(performLayout: false);
            ((ISupportInitialize)splitContainerControlComanda).EndInit();
            ((Control)(object)splitContainerControlComanda).ResumeLayout(performLayout: false);
            ((ISupportInitialize)splitContainerControlArticulos).EndInit();
            ((Control)(object)splitContainerControlArticulos).ResumeLayout(performLayout: false);
            ((ISupportInitialize)cbVendedores.Properties).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)txtArticulo.Properties).EndInit();
            ((ISupportInitialize)splitContainerControlPartidas).EndInit();
            ((Control)(object)splitContainerControlPartidas).ResumeLayout(performLayout: false);
            ((ISupportInitialize)gcPartidas).EndInit();
            ((ISupportInitialize)gvPartidas).EndInit();
            ((ISupportInitialize)cbMonedas).EndInit();
            ((ISupportInitialize)layoutControlGroup1).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}