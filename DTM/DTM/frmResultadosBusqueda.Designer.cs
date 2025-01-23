using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SDK;

namespace DTM
{
    partial class frmResultadosBusqueda
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1053, 57);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 493);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1053, 29);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1053, 436);
            this.panelControl1.TabIndex = 2;
            // 
            // gcResultados
            // 
            this.gcResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcResultados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResultados.Location = new System.Drawing.Point(2, 2);
            this.gcResultados.MainView = this.gvResultados;
            this.gcResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResultados.MenuManager = this.ribbonControl1;
            this.gcResultados.Name = "gcResultados";
            this.gcResultados.Size = new System.Drawing.Size(1049, 432);
            this.gcResultados.TabIndex = 0;
            this.gcResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResultados});
            // 
            // gvResultados
            // 
            this.gvResultados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.Row.Options.UseFont = true;
            this.gvResultados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvResultados.DetailHeight = 458;
            this.gvResultados.GridControl = this.gcResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.Editable = false;
            this.gvResultados.OptionsCustomization.AllowSort = false;
            this.gvResultados.OptionsEditForm.PopupEditFormWidth = 1067;
            this.gvResultados.OptionsView.ShowGroupPanel = false;
            this.gvResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvResultados_KeyDown);
            this.gvResultados.DoubleClick += new System.EventHandler(this.gvResultados_DoubleClick);
            // 
            // frmResultadosBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 522);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmResultadosBusqueda";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Resultados de busqueda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmResultadosBusqueda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}