using System;
using System.Collections;
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
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;


namespace NORI.PuntoVenta
{
    partial class frmCortesCaja
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
            //IL_00ee: Unknown result type (might be due to invalid IL or missing references)
            //IL_00f8: Expected O, but got Unknown
            //IL_00f9: Unknown result type (might be due to invalid IL or missing references)
            //IL_0103: Expected O, but got Unknown
            //IL_0104: Unknown result type (might be due to invalid IL or missing references)
            //IL_010e: Expected O, but got Unknown
            //IL_0702: Unknown result type (might be due to invalid IL or missing references)
            //IL_0708: Expected O, but got Unknown
            //IL_072d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0733: Expected O, but got Unknown
            //IL_07fd: Unknown result type (might be due to invalid IL or missing references)
            //IL_0803: Expected O, but got Unknown
            //IL_0828: Unknown result type (might be due to invalid IL or missing references)
            //IL_082e: Expected O, but got Unknown
            //IL_08ac: Unknown result type (might be due to invalid IL or missing references)
            //IL_08b2: Expected O, but got Unknown
            //IL_08da: Unknown result type (might be due to invalid IL or missing references)
            //IL_08e0: Expected O, but got Unknown
            //IL_08ee: Unknown result type (might be due to invalid IL or missing references)
            //IL_08f4: Expected O, but got Unknown
            //IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0b82: Expected O, but got Unknown
            //IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
            //IL_0ba8: Expected O, but got Unknown
            //IL_0be1: Unknown result type (might be due to invalid IL or missing references)
            //IL_0be7: Expected O, but got Unknown
            //IL_0c14: Unknown result type (might be due to invalid IL or missing references)
            //IL_0c1a: Expected O, but got Unknown
            //IL_0c26: Unknown result type (might be due to invalid IL or missing references)
            //IL_0c2c: Expected O, but got Unknown
            //IL_0c38: Unknown result type (might be due to invalid IL or missing references)
            //IL_0c3e: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCortesCaja));
            tabFormDefaultManager1 = new TabFormDefaultManager();
            barDockControlTop = new BarDockControl();
            barDockControlBottom = new BarDockControl();
            barDockControlLeft = new BarDockControl();
            barDockControlRight = new BarDockControl();
            ribbonControl1 = new RibbonControl();
            ribbonPageGroup1 = new RibbonPageGroup();
            layoutControl1 = new LayoutControl();
            layoutControl2 = new LayoutControl();
            panel1 = new Panel();
            deHasta = new DateEdit();
            deDesde = new DateEdit();
            cbUsuarios = new LookUpEdit();
            layoutControlGroup2 = new LayoutControlGroup();
            layoutControlItem2 = new LayoutControlItem();
            gcFlujo = new GridControl();
            gvFlujo = new GridView();
            deFecha = new RepositoryItemDateEdit();
            cbMonedas = new RepositoryItemLookUpEdit();
            layoutControlGroup1 = new LayoutControlGroup();
            layoutControlItem1 = new LayoutControlItem();
            layoutControlItem3 = new LayoutControlItem();
            cbFlujo = new CheckEdit();
            ((ISupportInitialize)tabFormDefaultManager1).BeginInit();
            ((ISupportInitialize)ribbonControl1).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            ((Control)(object)layoutControl1).SuspendLayout();
            ((ISupportInitialize)layoutControl2).BeginInit();
            ((Control)(object)layoutControl2).SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)deHasta.Properties.CalendarTimeProperties).BeginInit();
            ((ISupportInitialize)deHasta.Properties).BeginInit();
            ((ISupportInitialize)deDesde.Properties.CalendarTimeProperties).BeginInit();
            ((ISupportInitialize)deDesde.Properties).BeginInit();
            ((ISupportInitialize)cbUsuarios.Properties).BeginInit();
            ((ISupportInitialize)layoutControlGroup2).BeginInit();
            ((ISupportInitialize)layoutControlItem2).BeginInit();
            ((ISupportInitialize)gcFlujo).BeginInit();
            ((ISupportInitialize)gvFlujo).BeginInit();
            ((ISupportInitialize)deFecha).BeginInit();
            ((ISupportInitialize)deFecha.CalendarTimeProperties).BeginInit();
            ((ISupportInitialize)cbMonedas).BeginInit();
            ((ISupportInitialize)layoutControlGroup1).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((ISupportInitialize)layoutControlItem3).BeginInit();
            ((ISupportInitialize)cbFlujo.Properties).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((BarManager)tabFormDefaultManager1).DockControls.Add(barDockControlTop);
            ((BarManager)tabFormDefaultManager1).DockControls.Add(barDockControlBottom);
            ((BarManager)tabFormDefaultManager1).DockControls.Add(barDockControlLeft);
            ((BarManager)tabFormDefaultManager1).DockControls.Add(barDockControlRight);
            ((BarManager)tabFormDefaultManager1).Form = (Control)(object)this;
            ((BarManager)tabFormDefaultManager1).MaxItemId = 0;
            ((Control)(object)barDockControlTop).CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Size = new Size(790, 0);
            ((Control)(object)barDockControlBottom).CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 595);
            barDockControlBottom.Size = new Size(790, 0);
            ((Control)(object)barDockControlLeft).CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Size = new Size(0, 595);
            ((Control)(object)barDockControlRight).CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(790, 0);
            barDockControlRight.Size = new Size(0, 595);
            ((BarItem)ribbonControl1.ExpandCollapseItem).Id = 0;
            ((BarItems)ribbonControl1.Items).AddRange((BarItem[])(object)new BarItem[1] { (BarItem)ribbonControl1.ExpandCollapseItem });
            ((Control)(object)ribbonControl1).Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 1;
            ((Control)(object)ribbonControl1).Name = "ribbonControl1";
            ribbonControl1.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            ribbonControl1.ShowApplicationButton = (DefaultBoolean.False);
            ((Control)(object)ribbonControl1).Size = new Size(790, 49);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            ((Control)(object)layoutControl1).Controls.Add((Control)(object)layoutControl2);
            ((Control)(object)layoutControl1).Controls.Add((Control)(object)gcFlujo);
            ((Control)(object)layoutControl1).Dock = DockStyle.Fill;
            ((Control)(object)layoutControl1).Location = new Point(0, 49);
            ((Control)(object)layoutControl1).Name = "layoutControl1";
            layoutControl1.Root = layoutControlGroup1;
            ((Control)(object)layoutControl1).Size = new Size(790, 546);
            ((Control)(object)layoutControl1).TabIndex = 6;
            ((Control)(object)layoutControl1).Text = "layoutControl1";
            ((Control)(object)layoutControl2).Controls.Add(panel1);
            ((Control)(object)layoutControl2).Location = new Point(12, 12);
            ((Control)(object)layoutControl2).Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup2;
            ((Control)(object)layoutControl2).Size = new Size(766, 44);
            ((Control)(object)layoutControl2).TabIndex = 0;
            ((Control)(object)layoutControl2).Text = "layoutControl2";
            panel1.Controls.Add((Control)(object)cbFlujo);
            panel1.Controls.Add((Control)(object)deHasta);
            panel1.Controls.Add((Control)(object)deDesde);
            panel1.Controls.Add((Control)(object)cbUsuarios);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 20);
            panel1.TabIndex = 4;
            ((Control)(object)deHasta).Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((BaseEdit)deHasta).EditValue = new DateTime(2018, 3, 11, 22, 51, 26, 265);
            ((Control)(object)deHasta).Location = new Point(654, 0);
            ((BaseEdit)deHasta).MenuManager = (IDXMenuManager)(object)tabFormDefaultManager1;
            ((Control)(object)deHasta).Name = "deHasta";
            ((RepositoryItemButtonEdit)deHasta.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((RepositoryItemButtonEdit)deHasta.Properties.CalendarTimeProperties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((Control)(object)deHasta).Size = new Size(85, 20);
            ((Control)(object)deHasta).TabIndex = 3;
            ((BaseEdit)deHasta).EditValueChanged += cbUsuarios_EditValueChanged;
            ((Control)(object)deDesde).Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((BaseEdit)deDesde).EditValue = new DateTime(2018, 3, 11, 22, 51, 2, 700);
            ((Control)(object)deDesde).Location = new Point(563, 0);
            ((BaseEdit)deDesde).MenuManager = (IDXMenuManager)(object)tabFormDefaultManager1;
            ((Control)(object)deDesde).Name = "deDesde";
            ((RepositoryItemButtonEdit)deDesde.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((RepositoryItemButtonEdit)deDesde.Properties.CalendarTimeProperties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((Control)(object)deDesde).Size = new Size(85, 20);
            ((Control)(object)deDesde).TabIndex = 2;
            ((BaseEdit)deDesde).EditValueChanged += cbUsuarios_EditValueChanged;
            ((Control)(object)cbUsuarios).Location = new Point(0, 0);
            ((Control)(object)cbUsuarios).Name = "cbUsuarios";
            ((RepositoryItemButtonEdit)cbUsuarios.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbUsuarios.Properties.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("usuario", "Usuario"),
            new LookUpColumnInfo("nombre", 40, "Nombre")
            });
            ((Control)(object)cbUsuarios).Size = new Size(207, 20);
            ((Control)(object)cbUsuarios).TabIndex = 0;
            ((BaseEdit)cbUsuarios).EditValueChanged += cbUsuarios_EditValueChanged;
            ((LayoutGroup)layoutControlGroup2).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup2).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup2.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[1] { (BaseLayoutItem)layoutControlItem2 });
            ((BaseLayoutItem)layoutControlGroup2).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup2).Name = "layoutControlGroup2";
            ((BaseLayoutItem)layoutControlGroup2).Size = new Size(766, 44);
            ((BaseLayoutItem)layoutControlGroup2).TextVisible = false;
            layoutControlItem2.Control = panel1;
            ((BaseLayoutItem)layoutControlItem2).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem2).Name = "layoutControlItem2";
            ((BaseLayoutItem)layoutControlItem2).Size = new Size(746, 24);
            ((BaseLayoutItem)layoutControlItem2).Text = "Filtros";
            ((BaseLayoutItem)layoutControlItem2).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem2).TextVisible = false;
            ((Control)(object)gcFlujo).Location = new Point(12, 60);
            gcFlujo.MainView = (BaseView)(object)gvFlujo;
            ((EditorContainer)gcFlujo).MenuManager = (IDXMenuManager)(object)tabFormDefaultManager1;
            ((Control)(object)gcFlujo).Name = "gcFlujo";
            ((EditorContainer)gcFlujo).RepositoryItems.AddRange((RepositoryItem[])(object)new RepositoryItem[2]
            {
            (RepositoryItem)deFecha,
            (RepositoryItem)cbMonedas
            });
            ((Control)(object)gcFlujo).Size = new Size(766, 474);
            ((Control)(object)gcFlujo).TabIndex = 4;
            gcFlujo.ViewCollection.AddRange((BaseView[])(object)new BaseView[1] { (BaseView)gvFlujo });
            ((BaseView)gvFlujo).BorderStyle = (BorderStyles.NoBorder);
            ((BaseView)gvFlujo).GridControl = gcFlujo;
            ((BaseView)gvFlujo).Name = "gvFlujo";
            gvFlujo.OptionsDetail.DetailMode = (DetailMode.Default);
            //((ColumnViewOptionsSelection)gvFlujo.OptionsSelection).MultiSelect = true;
            gvFlujo.OptionsSelection.MultiSelectMode = (GridMultiSelectMode.CheckBoxRowSelect);
            ((RepositoryItem)deFecha).AutoHeight = false;
            ((RepositoryItemButtonEdit)deFecha).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((RepositoryItemButtonEdit)deFecha.CalendarTimeProperties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            ((RepositoryItem)deFecha).Name = "deFecha";
            ((RepositoryItem)cbMonedas).AutoHeight = false;
            ((RepositoryItemButtonEdit)cbMonedas).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbMonedas.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[3]
            {
            new LookUpColumnInfo("id", "ID", 20, (FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("codigo", "Código"),
            new LookUpColumnInfo("nombre", "Nombre")
            });
            ((RepositoryItem)cbMonedas).Name = "cbMonedas";
            ((LayoutGroup)layoutControlGroup1).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup1).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup1.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[2]
            {
            (BaseLayoutItem)layoutControlItem1,
            (BaseLayoutItem)layoutControlItem3
            });
            ((BaseLayoutItem)layoutControlGroup1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup1).Name = "layoutControlGroup1";
            ((BaseLayoutItem)layoutControlGroup1).Size = new Size(790, 546);
            ((BaseLayoutItem)layoutControlGroup1).TextVisible = false;
            layoutControlItem1.Control = (Control)(object)gcFlujo;
            ((BaseLayoutItem)layoutControlItem1).Location = new Point(0, 48);
            ((BaseLayoutItem)layoutControlItem1).Name = "layoutControlItem1";
            ((BaseLayoutItem)layoutControlItem1).Size = new Size(770, 478);
            ((BaseLayoutItem)layoutControlItem1).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem1).TextVisible = false;
            ((BaseLayoutItem)layoutControlItem3).AllowHide = false;
            layoutControlItem3.Control = (Control)(object)layoutControl2;
            ((BaseLayoutItem)layoutControlItem3).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem3).Name = "layoutControlItem3";
            ((BaseLayoutItem)layoutControlItem3).Size = new Size(770, 48);
            ((BaseLayoutItem)layoutControlItem3).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem3).TextVisible = false;
            ((Control)(object)cbFlujo).Location = new Point(213, 1);
            ((BaseEdit)cbFlujo).MenuManager = (IDXMenuManager)(object)tabFormDefaultManager1;
            ((Control)(object)cbFlujo).Name = "cbFlujo";
            ((BaseRepositoryItemCheckEdit)cbFlujo.Properties).Caption = "Flujo";
            ((Control)(object)cbFlujo).Size = new Size(137, 19);
            ((Control)(object)cbFlujo).TabIndex = 1;
            cbFlujo.CheckedChanged += cbUsuarios_EditValueChanged;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(790, 595);
            ((Control)this).Controls.Add((Control)(object)layoutControl1);
            ((Control)this).Controls.Add((Control)(object)ribbonControl1);
            ((Control)this).Controls.Add((Control)(object)barDockControlLeft);
            ((Control)this).Controls.Add((Control)(object)barDockControlRight);
            ((Control)this).Controls.Add((Control)(object)barDockControlBottom);
            ((Control)this).Controls.Add((Control)(object)barDockControlTop);
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Form)this).KeyPreview = true;
            ((Control)this).Name = "frmCortesCaja";
            ((RibbonForm)this).Ribbon = ribbonControl1;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Cortes de caja";
            ((Control)this).KeyDown += frmCortesCaja_KeyDown;
            ((ISupportInitialize)tabFormDefaultManager1).EndInit();
            ((ISupportInitialize)ribbonControl1).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            ((Control)(object)layoutControl1).ResumeLayout(performLayout: false);
            ((ISupportInitialize)layoutControl2).EndInit();
            ((Control)(object)layoutControl2).ResumeLayout(performLayout: false);
            panel1.ResumeLayout(performLayout: false);
            ((ISupportInitialize)deHasta.Properties.CalendarTimeProperties).EndInit();
            ((ISupportInitialize)deHasta.Properties).EndInit();
            ((ISupportInitialize)deDesde.Properties.CalendarTimeProperties).EndInit();
            ((ISupportInitialize)deDesde.Properties).EndInit();
            ((ISupportInitialize)cbUsuarios.Properties).EndInit();
            ((ISupportInitialize)layoutControlGroup2).EndInit();
            ((ISupportInitialize)layoutControlItem2).EndInit();
            ((ISupportInitialize)gcFlujo).EndInit();
            ((ISupportInitialize)gvFlujo).EndInit();
            ((ISupportInitialize)deFecha.CalendarTimeProperties).EndInit();
            ((ISupportInitialize)deFecha).EndInit();
            ((ISupportInitialize)cbMonedas).EndInit();
            ((ISupportInitialize)layoutControlGroup1).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((ISupportInitialize)layoutControlItem3).EndInit();
            ((ISupportInitialize)cbFlujo.Properties).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}