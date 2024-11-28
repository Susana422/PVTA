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

namespace NORI.PuntoVenta
{
    partial class frmArqueo
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
            //IL_00ee: Unknown result type (might be due to invalid IL or missing references)
            //IL_00f8: Expected O, but got Unknown
            //IL_00f9: Unknown result type (might be due to invalid IL or missing references)
            //IL_0103: Expected O, but got Unknown
            //IL_07e6: Unknown result type (might be due to invalid IL or missing references)
            //IL_07ec: Expected O, but got Unknown
            //IL_0945: Unknown result type (might be due to invalid IL or missing references)
            //IL_094f: Expected O, but got Unknown
            //IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
            //IL_0ae9: Expected O, but got Unknown
            //IL_0b49: Unknown result type (might be due to invalid IL or missing references)
            //IL_0b4f: Expected O, but got Unknown
            //IL_0b81: Unknown result type (might be due to invalid IL or missing references)
            //IL_0b87: Expected O, but got Unknown
            //IL_0b95: Unknown result type (might be due to invalid IL or missing references)
            //IL_0b9b: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmArqueo));
            ribbonControl1 = new RibbonControl();
            layoutControl1 = new LayoutControl();
            panel1 = new Panel();
            btnREACA = new Button();
            btnRERET = new Button();
            gcAcumulados = new GridControl();
            gvAcumulados = new GridView();
            gridColumn5 = new GridColumn();
            gridColumn6 = new GridColumn();
            gcPartidas = new GridControl();
            gvPartidas = new GridView();
            gridColumn1 = new GridColumn();
            gridColumn2 = new GridColumn();
            gridColumn3 = new GridColumn();
            cbConceptos = new LookUpEdit();
            lblConceptos = new LabelControl();
            txtCantidad = new TextEdit();
            lblCantidad = new LabelControl();
            btnCancelar = new Button();
            btnRECCA = new Button();
            layoutControlGroup1 = new LayoutControlGroup();
            layoutControlItem1 = new LayoutControlItem();
            ((ISupportInitialize)ribbonControl1).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            ((Control)(object)layoutControl1).SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)gcAcumulados).BeginInit();
            ((ISupportInitialize)gvAcumulados).BeginInit();
            ((ISupportInitialize)gcPartidas).BeginInit();
            ((ISupportInitialize)gvPartidas).BeginInit();
            ((ISupportInitialize)cbConceptos.Properties).BeginInit();
            ((ISupportInitialize)txtCantidad.Properties).BeginInit();
            ((ISupportInitialize)layoutControlGroup1).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((BarItem)ribbonControl1.ExpandCollapseItem).Id = 0;
            ((BarItems)ribbonControl1.Items).AddRange((BarItem[])(object)new BarItem[1] { (BarItem)ribbonControl1.ExpandCollapseItem });
            ((Control)(object)ribbonControl1).Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 1;
            ((Control)(object)ribbonControl1).Name = "ribbonControl1";
            ribbonControl1.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            ribbonControl1.ShowApplicationButton = (DefaultBoolean.False);
            ((Control)(object)ribbonControl1).Size = new Size(785, 49);
            ((Control)(object)layoutControl1).Controls.Add(panel1);
            ((Control)(object)layoutControl1).Dock = DockStyle.Fill;
            ((Control)(object)layoutControl1).Location = new Point(0, 49);
            ((Control)(object)layoutControl1).Name = "layoutControl1";
            layoutControl1.Root = layoutControlGroup1;
            ((Control)(object)layoutControl1).Size = new Size(785, 427);
            ((Control)(object)layoutControl1).TabIndex = 1;
            ((Control)(object)layoutControl1).Text = "layoutControl1";
            panel1.Controls.Add(btnREACA);
            panel1.Controls.Add(btnRERET);
            panel1.Controls.Add((Control)(object)gcAcumulados);
            panel1.Controls.Add((Control)(object)gcPartidas);
            panel1.Controls.Add((Control)(object)cbConceptos);
            panel1.Controls.Add((Control)(object)lblConceptos);
            panel1.Controls.Add((Control)(object)txtCantidad);
            panel1.Controls.Add((Control)(object)lblCantidad);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRECCA);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 403);
            panel1.TabIndex = 0;
            btnREACA.BackColor = Color.LightSlateGray;
            btnREACA.FlatAppearance.BorderColor = Color.SlateGray;
            btnREACA.FlatStyle = FlatStyle.Flat;
            btnREACA.ForeColor = Color.White;
            btnREACA.Location = new Point(516, 361);
            btnREACA.Name = "btnREACA";
            btnREACA.Size = new Size(117, 27);
            btnREACA.TabIndex = 67;
            btnREACA.Text = "Retiro fondo inicial";
            btnREACA.UseVisualStyleBackColor = false;
            btnREACA.Click += btnRetiroFondoInicial_Click;
            btnRERET.BackColor = Color.FromArgb(248, 152, 33);
            btnRERET.FlatAppearance.BorderColor = Color.FromArgb(247, 135, 0);
            btnRERET.FlatStyle = FlatStyle.Flat;
            btnRERET.ForeColor = Color.White;
            btnRERET.Location = new Point(402, 361);
            btnRERET.Name = "btnRERET";
            btnRERET.Size = new Size(108, 27);
            btnRERET.TabIndex = 65;
            btnRERET.Text = "Retiro";
            btnRERET.UseVisualStyleBackColor = false;
            btnRERET.Click += btnRERET_Click;
            ((Control)(object)gcAcumulados).Location = new Point(402, 13);
            gcAcumulados.MainView = (BaseView)(object)gvAcumulados;
            ((EditorContainer)gcAcumulados).MenuManager = (IDXMenuManager)(object)ribbonControl1;
            ((Control)(object)gcAcumulados).Name = "gcAcumulados";
            ((Control)(object)gcAcumulados).Size = new Size(345, 322);
            ((Control)(object)gcAcumulados).TabIndex = 64;
            gcAcumulados.ViewCollection.AddRange((BaseView[])(object)new BaseView[1] { (BaseView)gvAcumulados });
            ((ColumnView)gvAcumulados).Columns.AddRange((GridColumn[])(object)new GridColumn[2] { gridColumn5, gridColumn6 });
            ((BaseView)gvAcumulados).GridControl = gcAcumulados;
            ((BaseView)gvAcumulados).Name = "gvAcumulados";
            gvAcumulados.OptionsDetail.DetailMode = (DetailMode.Default);
            gvAcumulados.OptionsView.ShowFooter = true;
            gvAcumulados.OptionsView.ShowGroupPanel = false;
            gridColumn5.Caption = "Concepto";
            gridColumn5.FieldName = "concepto";
            gridColumn5.MaxWidth = 200;
            gridColumn5.MinWidth = 200;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.OptionsColumn.AllowEdit = false;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 0;
            gridColumn5.Width = 200;
            gridColumn6.Caption = "Total";
            gridColumn6.DisplayFormat.FormatString = "c2";
            gridColumn6.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumn6.FieldName = "total";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.OptionsColumn.AllowEdit = false;
            ((GridSummaryItemCollection)gridColumn6.Summary).AddRange((GridSummaryItem[])(object)new GridSummaryItem[1] { (GridSummaryItem)new GridColumnSummaryItem((SummaryItemType.Sum), "total", "TOTAL={0:c2}") });
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 1;
            gridColumn6.Width = 127;
            ((Control)(object)gcPartidas).Location = new Point(14, 65);
            gcPartidas.MainView = (BaseView)(object)gvPartidas;
            ((EditorContainer)gcPartidas).MenuManager = (IDXMenuManager)(object)ribbonControl1;
            ((Control)(object)gcPartidas).Name = "gcPartidas";
            ((Control)(object)gcPartidas).Size = new Size(375, 270);
            ((Control)(object)gcPartidas).TabIndex = 63;
            gcPartidas.ViewCollection.AddRange((BaseView[])(object)new BaseView[1] { (BaseView)gvPartidas });
            ((ColumnView)gvPartidas).Columns.AddRange((GridColumn[])(object)new GridColumn[3] { gridColumn1, gridColumn2, gridColumn3 });
            ((BaseView)gvPartidas).GridControl = gcPartidas;
            ((BaseView)gvPartidas).Name = "gvPartidas";
            gvPartidas.OptionsDetail.DetailMode = (DetailMode.Default);
            gvPartidas.OptionsView.ShowFooter = true;
            gvPartidas.OptionsView.ShowGroupPanel = false;
            ((ColumnView)gvPartidas).CellValueChanged += new CellValueChangedEventHandler(gvPartidas_CellValueChanged);
            ((BaseView)gvPartidas).KeyDown += gvPartidas_KeyDown;
            gridColumn1.Caption = "Cant";
            gridColumn1.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumn1.FieldName = "cantidad";
            gridColumn1.MaxWidth = 50;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 50;
            gridColumn2.Caption = "Factor";
            gridColumn2.DisplayFormat.FormatString = "c2";
            gridColumn2.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumn2.FieldName = "factor";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn3.Caption = "Producto";
            gridColumn3.DisplayFormat.FormatString = "c2";
            gridColumn3.DisplayFormat.FormatType = (FormatType.Numeric);
            gridColumn3.FieldName = "producto";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.AllowEdit = false;
            ((GridSummaryItemCollection)gridColumn3.Summary).AddRange((GridSummaryItem[])(object)new GridSummaryItem[1] { (GridSummaryItem)new GridColumnSummaryItem((SummaryItemType.Sum), "producto", "TOTAL={0:c2}") });
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            ((Control)(object)cbConceptos).Location = new Point(116, 13);
            ((Control)(object)cbConceptos).Name = "cbConceptos";
            ((RepositoryItemButtonEdit)cbConceptos.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbConceptos.Properties.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("id", "ID", 20, (FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("nombre", 60, "Concepto")
            });
            ((Control)(object)cbConceptos).Size = new Size(273, 20);
            ((Control)(object)cbConceptos).TabIndex = 0;
            ((BaseEdit)cbConceptos).EditValueChanged += cbConceptos_EditValueChanged;
            ((Control)(object)lblConceptos).Location = new Point(14, 16);
            ((Control)(object)lblConceptos).Name = "lblConceptos";
            ((Control)(object)lblConceptos).Size = new Size(46, 13);
            ((Control)(object)lblConceptos).TabIndex = 61;
            ((Control)(object)lblConceptos).Text = "Concepto";
            ((Control)(object)txtCantidad).Location = new Point(116, 39);
            ((Control)(object)txtCantidad).Name = "txtCantidad";
            txtCantidad.Properties.MaxLength = 20;
            ((Control)(object)txtCantidad).Size = new Size(273, 20);
            ((Control)(object)txtCantidad).TabIndex = 1;
            ((Control)(object)txtCantidad).KeyDown += txtImporte_KeyDown;
            ((Control)(object)lblCantidad).Location = new Point(14, 42);
            ((Control)(object)lblCantidad).Name = "lblCantidad";
            ((Control)(object)lblCantidad).Size = new Size(43, 13);
            ((Control)(object)lblCantidad).TabIndex = 60;
            ((Control)(object)lblCantidad).Text = "Cantidad";
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancelar.Location = new Point(14, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 27);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnRECCA.BackColor = Color.Firebrick;
            btnRECCA.FlatAppearance.BorderColor = Color.Brown;
            btnRECCA.FlatStyle = FlatStyle.Flat;
            btnRECCA.ForeColor = Color.White;
            btnRECCA.Location = new Point(639, 361);
            btnRECCA.Name = "btnRECCA";
            btnRECCA.Size = new Size(108, 27);
            btnRECCA.TabIndex = 2;
            btnRECCA.Text = "CORTE Z";
            btnRECCA.UseVisualStyleBackColor = false;
            btnRECCA.Click += btnRECCA_Click;
            ((LayoutGroup)layoutControlGroup1).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup1).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup1.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[1] { (BaseLayoutItem)layoutControlItem1 });
            ((BaseLayoutItem)layoutControlGroup1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup1).Name = "layoutControlGroup1";
            ((BaseLayoutItem)layoutControlGroup1).Size = new Size(785, 427);
            ((BaseLayoutItem)layoutControlGroup1).TextVisible = false;
            layoutControlItem1.Control = panel1;
            ((BaseLayoutItem)layoutControlItem1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem1).Name = "layoutControlItem1";
            ((BaseLayoutItem)layoutControlItem1).Size = new Size(765, 407);
            ((BaseLayoutItem)layoutControlItem1).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem1).TextVisible = false;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).CancelButton = btnCancelar;
            ((Form)this).ClientSize = new Size(785, 476);
            ((Control)this).Controls.Add((Control)(object)layoutControl1);
            ((Control)this).Controls.Add((Control)(object)ribbonControl1);
            ((Form)this).FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Control)this).Name = "frmArqueo";
            ((RibbonForm)this).Ribbon = ribbonControl1;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Arqueo";
            ((ISupportInitialize)ribbonControl1).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            ((Control)(object)layoutControl1).ResumeLayout(performLayout: false);
            panel1.ResumeLayout(performLayout: false);
            panel1.PerformLayout();
            ((ISupportInitialize)gcAcumulados).EndInit();
            ((ISupportInitialize)gvAcumulados).EndInit();
            ((ISupportInitialize)gcPartidas).EndInit();
            ((ISupportInitialize)gvPartidas).EndInit();
            ((ISupportInitialize)cbConceptos.Properties).EndInit();
            ((ISupportInitialize)txtCantidad.Properties).EndInit();
            ((ISupportInitialize)layoutControlGroup1).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}