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
    partial class frmResultadosBusquedaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadosBusquedaArticulos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.gcResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gvResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pbImagen).BeginInit();
            base.SuspendLayout();
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[2]
            {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem
            });
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1185, 86);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 652);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1185, 36);
            this.panelControl1.Controls.Add(this.lblComentario);
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.pbImagen);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 86);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1185, 566);
            this.panelControl1.TabIndex = 2;
            this.gcResultados.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gcResultados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResultados.Location = new System.Drawing.Point(3, 3);
            this.gcResultados.MainView = this.gvResultados;
            this.gcResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResultados.MenuManager = this.ribbonControl1;
            this.gcResultados.Name = "gcResultados";
            this.gcResultados.Size = new System.Drawing.Size(852, 561);
            this.gcResultados.TabIndex = 2;
            this.gcResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gvResultados });
            this.gvResultados.ActiveFilterEnabled = false;
            this.gvResultados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.Row.Options.UseFont = true;
            this.gvResultados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvResultados.DetailHeight = 512;
            this.gvResultados.FixedLineWidth = 3;
            this.gvResultados.GridControl = this.gcResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.Editable = false;
            this.gvResultados.OptionsCustomization.AllowSort = false;
            this.gvResultados.OptionsView.ShowAutoFilterRow = true;
            this.gvResultados.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gvResultados_FocusedRowChanged);
            this.gvResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(gvResultados_KeyDown);
            this.gvResultados.DoubleClick += new System.EventHandler(gvResultados_DoubleClick);
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblNombre.Location = new System.Drawing.Point(864, 284);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(315, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del artículo";
            this.pbImagen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pbImagen.Location = new System.Drawing.Point(864, 4);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(315, 270);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            this.lblComentario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblComentario.Appearance.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblComentario.Appearance.Options.UseFont = true;
            this.lblComentario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblComentario.Location = new System.Drawing.Point(864, 339);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(315, 29);
            this.lblComentario.TabIndex = 5;
            this.lblComentario.Text = "Comentario";
            this.lblComentario.Click += new System.EventHandler(labelControl1_Click);
            base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 19f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(1185, 688);
            base.Controls.Add(this.panelControl1);
            base.Controls.Add(this.ribbonStatusBar1);
            base.Controls.Add(this.ribbonControl1);
            base.IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("frmResultadosBusquedaArticulos.IconOptions.Icon");
            base.KeyPreview = true;
            base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            base.Name = "frmResultadosBusquedaArticulos";
            this.Ribbon = this.ribbonControl1;
            base.ShowInTaskbar = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Resultados de busqueda";
            base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmResultadosBusquedaArticulos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.gcResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pbImagen).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}