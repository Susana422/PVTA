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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;



namespace NORI
{
    partial class frmSeleccionOpcionales
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
            this.lblSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.lblMinimo = new DevExpress.XtraEditors.LabelControl();
            this.lblMaximo = new DevExpress.XtraEditors.LabelControl();
            this.lblArticulo = new DevExpress.XtraEditors.LabelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOpcional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticuloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbArticulos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos)).BeginInit();
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
            this.panelControl1.Controls.Add(this.lblSeleccionados);
            this.panelControl1.Controls.Add(this.lblMinimo);
            this.panelControl1.Controls.Add(this.lblMaximo);
            this.panelControl1.Controls.Add(this.lblArticulo);
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(922, 448);
            this.panelControl1.TabIndex = 2;
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.Location = new System.Drawing.Point(120, 71);
            this.lblSeleccionados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(89, 17);
            this.lblSeleccionados.TabIndex = 4;
            this.lblSeleccionados.Text = "Seleccionados";
            // 
            // lblMinimo
            // 
            this.lblMinimo.Location = new System.Drawing.Point(9, 71);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(43, 17);
            this.lblMinimo.TabIndex = 3;
            this.lblMinimo.Text = "Mínimo";
            // 
            // lblMaximo
            // 
            this.lblMaximo.Location = new System.Drawing.Point(9, 48);
            this.lblMaximo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(47, 17);
            this.lblMaximo.TabIndex = 2;
            this.lblMaximo.Text = "Máximo";
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
            this.gcResultados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbArticulos});
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
            this.gridColumnArticulo,
            this.gridColumnMinimo,
            this.gridColumnMaximo,
            this.gridColumnCantidad,
            this.gridColumnOpcional,
            this.gridColumnArticuloId});
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
            this.gridColumnId.Width = 23;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.FieldName = "articulo";
            this.gridColumnArticulo.MinWidth = 23;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 1;
            this.gridColumnArticulo.Width = 156;
            // 
            // gridColumnMinimo
            // 
            this.gridColumnMinimo.Caption = "Mínimo";
            this.gridColumnMinimo.FieldName = "minimo";
            this.gridColumnMinimo.MinWidth = 23;
            this.gridColumnMinimo.Name = "gridColumnMinimo";
            this.gridColumnMinimo.Visible = true;
            this.gridColumnMinimo.VisibleIndex = 2;
            this.gridColumnMinimo.Width = 47;
            // 
            // gridColumnMaximo
            // 
            this.gridColumnMaximo.Caption = "Máximo";
            this.gridColumnMaximo.FieldName = "maximo";
            this.gridColumnMaximo.MinWidth = 23;
            this.gridColumnMaximo.Name = "gridColumnMaximo";
            this.gridColumnMaximo.Visible = true;
            this.gridColumnMaximo.VisibleIndex = 3;
            this.gridColumnMaximo.Width = 55;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MinWidth = 23;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 4;
            this.gridColumnCantidad.Width = 156;
            // 
            // gridColumnOpcional
            // 
            this.gridColumnOpcional.Caption = "Opcional";
            this.gridColumnOpcional.FieldName = "opcional";
            this.gridColumnOpcional.MinWidth = 23;
            this.gridColumnOpcional.Name = "gridColumnOpcional";
            this.gridColumnOpcional.Visible = true;
            this.gridColumnOpcional.VisibleIndex = 5;
            this.gridColumnOpcional.Width = 78;
            // 
            // gridColumnArticuloId
            // 
            this.gridColumnArticuloId.Caption = "Artículo ID";
            this.gridColumnArticuloId.FieldName = "articulo_id";
            this.gridColumnArticuloId.MinWidth = 23;
            this.gridColumnArticuloId.Name = "gridColumnArticuloId";
            this.gridColumnArticuloId.Width = 87;
            // 
            // cbArticulos
            // 
            this.cbArticulos.AutoHeight = false;
            this.cbArticulos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbArticulos.Name = "cbArticulos";
            // 
            // frmSeleccionOpcionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 522);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSeleccionOpcionales";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Selección de opcionales";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}