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
using NoriSDK;

namespace NORI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadosBusqueda));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.gcResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gvResultados).BeginInit();
            base.SuspendLayout();
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[1] { this.ribbonControl1.ExpandCollapseItem });
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(790, 49);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 368);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(790, 31);
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 319);
            this.panelControl1.TabIndex = 2;
            this.gcResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcResultados.Location = new System.Drawing.Point(2, 2);
            this.gcResultados.MainView = this.gvResultados;
            this.gcResultados.MenuManager = this.ribbonControl1;
            this.gcResultados.Name = "gcResultados";
            this.gcResultados.Size = new System.Drawing.Size(786, 315);
            this.gcResultados.TabIndex = 0;
            this.gcResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gvResultados });
            this.gvResultados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.Row.Options.UseFont = true;
            this.gvResultados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvResultados.GridControl = this.gcResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.Editable = false;
            this.gvResultados.OptionsCustomization.AllowSort = false;
            this.gvResultados.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvResultados.OptionsView.ShowGroupPanel = false;
            this.gvResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(gvResultados_KeyDown);
            this.gvResultados.DoubleClick += new System.EventHandler(gvResultados_DoubleClick);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(790, 399);
            base.Controls.Add(this.panelControl1);
            base.Controls.Add(this.ribbonStatusBar1);
            base.Controls.Add(this.ribbonControl1);
            base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.KeyPreview = true;
            base.Name = "frmResultadosBusqueda";
            this.Ribbon = this.ribbonControl1;
            base.ShowInTaskbar = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Resultados de busqueda";
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmResultadosBusqueda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.gcResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gvResultados).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}