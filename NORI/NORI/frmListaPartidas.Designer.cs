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
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSDK;
using Padding = System.Windows.Forms.Padding;

namespace NORI
{
    partial class frmListaPartidas
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NORI.frmListaPartidas));
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
            this.btnFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbrir = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.cbEstados = new DevExpress.XtraEditors.LookUpEdit();
            this.cbSocios = new DevExpress.XtraEditors.LookUpEdit();
            this.deHasta = new DevExpress.XtraEditors.DateEdit();
            this.deDesde = new DevExpress.XtraEditors.DateEdit();
            this.cbClases = new DevExpress.XtraEditors.LookUpEdit();
            this.cbVendedores = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcDocumentos = new DevExpress.XtraGrid.GridControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDocumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deFecha = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cbMonedas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbWeb = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)this.tabFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
            ((System.Windows.Forms.Control)this.layoutControl1).SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl2).BeginInit();
            ((System.Windows.Forms.Control)this.layoutControl2).SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.cbEstados.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbSocios.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbClases.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbVendedores.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gcDocumentos).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.gvDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deFecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deFecha.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbMonedas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbWeb.Properties).BeginInit();
            base.SuspendLayout();
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            ((System.Windows.Forms.Control)this.barDockControlTop).CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            ((System.Windows.Forms.Control)this.barDockControlTop).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1185, 0);
            ((System.Windows.Forms.Control)this.barDockControlBottom).CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 870);
            this.barDockControlBottom.Manager = null;
            ((System.Windows.Forms.Control)this.barDockControlBottom).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1185, 0);
            ((System.Windows.Forms.Control)this.barDockControlLeft).CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            ((System.Windows.Forms.Control)this.barDockControlLeft).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 870);
            ((System.Windows.Forms.Control)this.barDockControlRight).CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1185, 0);
            this.barDockControlRight.Manager = null;
            ((System.Windows.Forms.Control)this.barDockControlRight).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 870);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[2]
            {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem
            });
            ((System.Windows.Forms.Control)this.ribbonControl1).Location = new System.Drawing.Point(0, 0);
            ((System.Windows.Forms.Control)this.ribbonControl1).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 1;
            ((System.Windows.Forms.Control)this.ribbonControl1).Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ((System.Windows.Forms.Control)this.ribbonControl1).Size = new System.Drawing.Size(1185, 86);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            ((System.Windows.Forms.Control)this.layoutControl1).Controls.Add(this.layoutControl2);
            ((System.Windows.Forms.Control)this.layoutControl1).Controls.Add(this.gcDocumentos);
            ((System.Windows.Forms.Control)this.layoutControl1).Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.Windows.Forms.Control)this.layoutControl1).Location = new System.Drawing.Point(0, 86);
            ((System.Windows.Forms.Control)this.layoutControl1).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.layoutControl1).Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            ((System.Windows.Forms.Control)this.layoutControl1).Size = new System.Drawing.Size(1185, 784);
            ((System.Windows.Forms.Control)this.layoutControl1).TabIndex = 6;
            ((System.Windows.Forms.Control)this.layoutControl1).Text = "layoutControl1";
            ((System.Windows.Forms.Control)this.layoutControl2).Controls.Add(this.panel1);
            ((System.Windows.Forms.Control)this.layoutControl2).Location = new System.Drawing.Point(18, 18);
            ((System.Windows.Forms.Control)this.layoutControl2).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.layoutControl2).Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            ((System.Windows.Forms.Control)this.layoutControl2).Size = new System.Drawing.Size(1149, 109);
            ((System.Windows.Forms.Control)this.layoutControl2).TabIndex = 0;
            ((System.Windows.Forms.Control)this.layoutControl2).Text = "layoutControl2";
            this.panel1.Controls.Add(this.cbWeb);
            this.panel1.Controls.Add(this.btnFacturar);
            this.panel1.Controls.Add(this.btnEntregar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.cbEstados);
            this.panel1.Controls.Add(this.cbSocios);
            this.panel1.Controls.Add(this.deHasta);
            this.panel1.Controls.Add(this.deDesde);
            this.panel1.Controls.Add(this.cbClases);
            this.panel1.Controls.Add(this.cbVendedores);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 73);
            this.panel1.TabIndex = 4;
            ((System.Windows.Forms.Control)this.btnFacturar).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ((System.Windows.Forms.Control)this.btnFacturar).Location = new System.Drawing.Point(997, 36);
            ((System.Windows.Forms.Control)this.btnFacturar).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.btnFacturar).Name = "btnFacturar";
            ((System.Windows.Forms.Control)this.btnFacturar).Size = new System.Drawing.Size(112, 34);
            ((System.Windows.Forms.Control)this.btnFacturar).TabIndex = 14;
            ((System.Windows.Forms.Control)this.btnFacturar).Text = "Facturar";
            ((System.Windows.Forms.Control)this.btnFacturar).Click += new System.EventHandler(btnFacturar_Click);
            ((System.Windows.Forms.Control)this.btnEntregar).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ((System.Windows.Forms.Control)this.btnEntregar).Location = new System.Drawing.Point(876, 36);
            ((System.Windows.Forms.Control)this.btnEntregar).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.btnEntregar).Name = "btnEntregar";
            ((System.Windows.Forms.Control)this.btnEntregar).Size = new System.Drawing.Size(112, 34);
            ((System.Windows.Forms.Control)this.btnEntregar).TabIndex = 13;
            ((System.Windows.Forms.Control)this.btnEntregar).Text = "Entregar";
            ((System.Windows.Forms.Control)this.btnEntregar).Click += new System.EventHandler(btnEntregar_Click);
            ((System.Windows.Forms.Control)this.btnAbrir).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ((System.Windows.Forms.Control)this.btnAbrir).Location = new System.Drawing.Point(754, 36);
            ((System.Windows.Forms.Control)this.btnAbrir).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.btnAbrir).Name = "btnAbrir";
            ((System.Windows.Forms.Control)this.btnAbrir).Size = new System.Drawing.Size(112, 34);
            ((System.Windows.Forms.Control)this.btnAbrir).TabIndex = 12;
            ((System.Windows.Forms.Control)this.btnAbrir).Text = "Abrir";
            ((System.Windows.Forms.Control)this.btnAbrir).Click += new System.EventHandler(btnAbrir_Click);
            ((System.Windows.Forms.Control)this.btnImprimir).Location = new System.Drawing.Point(122, 38);
            ((System.Windows.Forms.Control)this.btnImprimir).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.btnImprimir).Name = "btnImprimir";
            ((System.Windows.Forms.Control)this.btnImprimir).Size = new System.Drawing.Size(112, 34);
            ((System.Windows.Forms.Control)this.btnImprimir).TabIndex = 11;
            ((System.Windows.Forms.Control)this.btnImprimir).Text = "Imprimir";
            ((System.Windows.Forms.Control)this.btnImprimir).Click += new System.EventHandler(btnImprimir_Click);
            ((System.Windows.Forms.Control)this.btnCargar).Location = new System.Drawing.Point(0, 38);
            ((System.Windows.Forms.Control)this.btnCargar).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.btnCargar).Name = "btnCargar";
            ((System.Windows.Forms.Control)this.btnCargar).Size = new System.Drawing.Size(112, 34);
            ((System.Windows.Forms.Control)this.btnCargar).TabIndex = 10;
            ((System.Windows.Forms.Control)this.btnCargar).Text = "Cargar";
            ((System.Windows.Forms.Control)this.btnCargar).Click += new System.EventHandler(btnCargar_Click);
            ((System.Windows.Forms.Control)this.cbEstados).Location = new System.Drawing.Point(176, 0);
            ((System.Windows.Forms.Control)this.cbEstados).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.cbEstados).Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbEstados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("estado", "Estado", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            ((System.Windows.Forms.Control)this.cbEstados).Size = new System.Drawing.Size(128, 28);
            ((System.Windows.Forms.Control)this.cbEstados).TabIndex = 9;
            this.cbEstados.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            ((System.Windows.Forms.Control)this.cbSocios).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ((System.Windows.Forms.Control)this.cbSocios).Location = new System.Drawing.Point(312, 0);
            ((System.Windows.Forms.Control)this.cbSocios).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.cbSocios).Name = "cbSocios";
            this.cbSocios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbSocios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[3]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            ((System.Windows.Forms.Control)this.cbSocios).Size = new System.Drawing.Size(294, 28);
            ((System.Windows.Forms.Control)this.cbSocios).TabIndex = 8;
            this.cbSocios.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            ((System.Windows.Forms.Control)this.deHasta).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.deHasta.EditValue = new System.DateTime(2018, 3, 11, 22, 51, 26, 265);
            ((System.Windows.Forms.Control)this.deHasta).Location = new System.Drawing.Point(981, 0);
            ((System.Windows.Forms.Control)this.deHasta).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deHasta.MenuManager = this.tabFormDefaultManager1;
            ((System.Windows.Forms.Control)this.deHasta).Name = "deHasta";
            this.deHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            ((System.Windows.Forms.Control)this.deHasta).Size = new System.Drawing.Size(128, 28);
            ((System.Windows.Forms.Control)this.deHasta).TabIndex = 7;
            this.deHasta.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            ((System.Windows.Forms.Control)this.deDesde).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.deDesde.EditValue = new System.DateTime(2018, 3, 11, 22, 51, 2, 700);
            ((System.Windows.Forms.Control)this.deDesde).Location = new System.Drawing.Point(844, 0);
            ((System.Windows.Forms.Control)this.deDesde).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deDesde.MenuManager = this.tabFormDefaultManager1;
            ((System.Windows.Forms.Control)this.deDesde).Name = "deDesde";
            this.deDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            ((System.Windows.Forms.Control)this.deDesde).Size = new System.Drawing.Size(128, 28);
            ((System.Windows.Forms.Control)this.deDesde).TabIndex = 6;
            this.deDesde.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            ((System.Windows.Forms.Control)this.cbClases).Location = new System.Drawing.Point(0, 0);
            ((System.Windows.Forms.Control)this.cbClases).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.cbClases).Name = "cbClases";
            this.cbClases.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbClases.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            ((System.Windows.Forms.Control)this.cbClases).Size = new System.Drawing.Size(166, 28);
            ((System.Windows.Forms.Control)this.cbClases).TabIndex = 5;
            this.cbClases.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            ((System.Windows.Forms.Control)this.cbVendedores).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ((System.Windows.Forms.Control)this.cbVendedores).Location = new System.Drawing.Point(615, 0);
            ((System.Windows.Forms.Control)this.cbVendedores).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ((System.Windows.Forms.Control)this.cbVendedores).Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            ((System.Windows.Forms.Control)this.cbVendedores).Size = new System.Drawing.Size(220, 28);
            ((System.Windows.Forms.Control)this.cbVendedores).TabIndex = 4;
            this.cbVendedores.EditValueChanged += new System.EventHandler(cbClases_EditValueChanged);
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem2 });
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1149, 109);
            this.layoutControlGroup2.TextVisible = false;
            this.layoutControlItem2.Control = this.panel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1119, 79);
            this.layoutControlItem2.Text = "Filtros";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            ((System.Windows.Forms.Control)this.gcDocumentos).ContextMenuStrip = this.contextMenu;
            ((System.Windows.Forms.Control)this.gcDocumentos.EmbeddedNavigator).Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            ((System.Windows.Forms.Control)this.gcDocumentos).Location = new System.Drawing.Point(18, 133);
            this.gcDocumentos.MainView = this.gvDocumentos;
            ((System.Windows.Forms.Control)this.gcDocumentos).Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDocumentos.MenuManager = this.tabFormDefaultManager1;
            ((System.Windows.Forms.Control)this.gcDocumentos).Name = "gcDocumentos";
            this.gcDocumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[2] { this.deFecha, this.cbMonedas });
            ((System.Windows.Forms.Control)this.gcDocumentos).Size = new System.Drawing.Size(1149, 633);
            ((System.Windows.Forms.Control)this.gcDocumentos).TabIndex = 4;
            this.gcDocumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gvDocumentos });
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem1, this.toolStripMenuItem2 });
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(196, 68);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 32);
            this.toolStripMenuItem1.Text = "Exportar XSLX";
            this.toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 32);
            this.toolStripMenuItem2.Text = "Exportar PDF";
            this.toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
            this.gvDocumentos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvDocumentos.DetailHeight = 512;
            this.gvDocumentos.FixedLineWidth = 3;
            this.gvDocumentos.GridControl = this.gcDocumentos;
            this.gvDocumentos.Name = "gvDocumentos";
            this.gvDocumentos.OptionsSelection.MultiSelect = true;
            this.gvDocumentos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.deFecha.AutoHeight = false;
            this.deFecha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deFecha.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deFecha.Name = "deFecha";
            this.cbMonedas.AutoHeight = false;
            this.cbMonedas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbMonedas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[3]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbMonedas.Name = "cbMonedas";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlItem1, this.layoutControlItem3 });
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1185, 784);
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlItem1.Control = this.gcDocumentos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 115);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1155, 639);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem3.AllowHide = false;
            this.layoutControlItem3.Control = this.layoutControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1155, 115);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            ((System.Windows.Forms.Control)this.cbWeb).Location = new System.Drawing.Point(241, 41);
            this.cbWeb.MenuManager = this.tabFormDefaultManager1;
            ((System.Windows.Forms.Control)this.cbWeb).Name = "cbWeb";
            this.cbWeb.Properties.Caption = "Web";
            ((System.Windows.Forms.Control)this.cbWeb).Size = new System.Drawing.Size(112, 29);
            ((System.Windows.Forms.Control)this.cbWeb).TabIndex = 15;
            this.cbWeb.EditValueChanged += new System.EventHandler(cbWeb_EditValueChanged);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            base.ClientSize = new System.Drawing.Size(1185, 870);
            base.Controls.Add(this.layoutControl1);
            base.Controls.Add(this.ribbonControl1);
            base.Controls.Add(this.barDockControlLeft);
            base.Controls.Add(this.barDockControlRight);
            base.Controls.Add(this.barDockControlBottom);
            base.Controls.Add(this.barDockControlTop);
            base.KeyPreview = true;
            base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            base.Name = "frmListaPartidas";
            this.Ribbon = this.ribbonControl1;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.Windows.Forms.Control)this).Text = "Lista de partidas";
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmListaPartidasAbiertas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)this.tabFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
            ((System.Windows.Forms.Control)this.layoutControl1).ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.layoutControl2).EndInit();
            ((System.Windows.Forms.Control)this.layoutControl2).ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.cbEstados.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbSocios.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbClases.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbVendedores.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gcDocumentos).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.gvDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deFecha.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deFecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbMonedas).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbWeb.Properties).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}