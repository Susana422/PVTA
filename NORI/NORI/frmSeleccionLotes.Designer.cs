using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NoriSDK;

namespace NORI
{
    partial class frmSeleccionLotes
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
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblCantidadSeleccionada = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadRequerida = new DevExpress.XtraEditors.LabelControl();
            this.lblArticulo = new DevExpress.XtraEditors.LabelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 257;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(922, 50);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 498);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 24);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblCantidadSeleccionada);
            this.panelControl1.Controls.Add(this.lblCantidadRequerida);
            this.panelControl1.Controls.Add(this.lblArticulo);
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(922, 448);
            this.panelControl1.TabIndex = 2;
            // 
            // lblCantidadSeleccionada
            // 
            this.lblCantidadSeleccionada.Location = new System.Drawing.Point(9, 71);
            this.lblCantidadSeleccionada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblCantidadSeleccionada.Name = "lblCantidadSeleccionada";
            this.lblCantidadSeleccionada.Size = new System.Drawing.Size(154, 17);
            this.lblCantidadSeleccionada.TabIndex = 3;
            this.lblCantidadSeleccionada.Text = "Cantidad seleccionada: 0";
            // 
            // lblCantidadRequerida
            // 
            this.lblCantidadRequerida.Location = new System.Drawing.Point(9, 48);
            this.lblCantidadRequerida.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblCantidadRequerida.Name = "lblCantidadRequerida";
            this.lblCantidadRequerida.Size = new System.Drawing.Size(120, 17);
            this.lblCantidadRequerida.TabIndex = 2;
            this.lblCantidadRequerida.Text = "Cantidad requerida:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblArticulo.Appearance.Options.UseFont = true;
            this.lblArticulo.Location = new System.Drawing.Point(9, 14);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(54, 21);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Artículo";
            // 
            // gcResultados
            // 
            this.gcResultados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcResultados.Location = new System.Drawing.Point(2, 94);
            this.gcResultados.MainView = this.gvResultados;
            this.gcResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcResultados.MenuManager = this.ribbonControl1;
            this.gcResultados.Name = "gcResultados";
            this.gcResultados.Size = new System.Drawing.Size(917, 320);
            this.gcResultados.TabIndex = 0;
            this.gcResultados.UseEmbeddedNavigator = true;
            this.gcResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResultados});
            // 
            // gvResultados
            // 
            this.gvResultados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.Row.Options.UseFont = true;
            this.gvResultados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvResultados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnLote,
            this.gridColumnDisponible,
            this.gridColumnCantidad,
            this.gridColumnFechaCaducidad});
            this.gvResultados.DetailHeight = 458;
            this.gvResultados.FixedLineWidth = 3;
            this.gvResultados.GridControl = this.gcResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsCustomization.AllowSort = false;
            this.gvResultados.OptionsEditForm.PopupEditFormWidth = 622;
            this.gvResultados.OptionsView.ShowGroupPanel = false;
            this.gvResultados.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvResultados_RowUpdated);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 23;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            this.gridColumnId.Width = 131;
            // 
            // gridColumnLote
            // 
            this.gridColumnLote.Caption = "Lote";
            this.gridColumnLote.FieldName = "lote";
            this.gridColumnLote.MinWidth = 23;
            this.gridColumnLote.Name = "gridColumnLote";
            this.gridColumnLote.Visible = true;
            this.gridColumnLote.VisibleIndex = 1;
            this.gridColumnLote.Width = 131;
            // 
            // gridColumnDisponible
            // 
            this.gridColumnDisponible.Caption = "Lotes disponibles";
            this.gridColumnDisponible.FieldName = "disponible";
            this.gridColumnDisponible.MinWidth = 23;
            this.gridColumnDisponible.Name = "gridColumnDisponible";
            this.gridColumnDisponible.Visible = true;
            this.gridColumnDisponible.VisibleIndex = 2;
            this.gridColumnDisponible.Width = 131;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MinWidth = 23;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 3;
            this.gridColumnCantidad.Width = 131;
            // 
            // gridColumnFechaCaducidad
            // 
            this.gridColumnFechaCaducidad.Caption = "Fecha de caducidad";
            this.gridColumnFechaCaducidad.FieldName = "fecha_caducidad";
            this.gridColumnFechaCaducidad.MinWidth = 23;
            this.gridColumnFechaCaducidad.Name = "gridColumnFechaCaducidad";
            this.gridColumnFechaCaducidad.Visible = true;
            this.gridColumnFechaCaducidad.VisibleIndex = 4;
            this.gridColumnFechaCaducidad.Width = 131;
            // 
            // frmSeleccionLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 522);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSeleccionLotes";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Selección de lotes";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}