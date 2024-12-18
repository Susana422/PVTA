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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.gcResultados = new DevExpress.XtraGrid.GridControl();
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 294;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1054, 57);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 587);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1054, 29);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblComentario);
            this.panelControl1.Controls.Add(this.gcResultados);
            this.panelControl1.Controls.Add(this.lblNombre);
            this.panelControl1.Controls.Add(this.pbImagen);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1054, 530);
            this.panelControl1.TabIndex = 2;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentario.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Appearance.Options.UseFont = true;
            this.lblComentario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblComentario.Location = new System.Drawing.Point(768, 303);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(280, 19);
            this.lblComentario.TabIndex = 5;
            this.lblComentario.Text = "Comentario";
            this.lblComentario.Visible = false;
            this.lblComentario.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // gcResultados
            // 
            this.gcResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcResultados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcResultados.Location = new System.Drawing.Point(2, 3);
            this.gcResultados.MainView = this.gvResultados;
            this.gcResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcResultados.MenuManager = this.ribbonControl1;
            this.gcResultados.Name = "gcResultados";
            this.gcResultados.Size = new System.Drawing.Size(758, 526);
            this.gcResultados.TabIndex = 2;
            this.gcResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResultados});
            // 
            // gvResultados
            // 
            this.gvResultados.ActiveFilterEnabled = false;
            this.gvResultados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.Row.Options.UseFont = true;
            this.gvResultados.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvResultados.DetailHeight = 458;
            this.gvResultados.FixedLineWidth = 3;
            this.gvResultados.GridControl = this.gcResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvResultados.OptionsBehavior.Editable = false;
            this.gvResultados.OptionsCustomization.AllowSort = false;
            this.gvResultados.OptionsEditForm.PopupEditFormWidth = 711;
            this.gvResultados.OptionsView.ShowAutoFilterRow = true;
            this.gvResultados.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvResultados_FocusedRowChanged);
            this.gvResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvResultados_KeyDown);
            this.gvResultados.DoubleClick += new System.EventHandler(this.gvResultados_DoubleClick);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblNombre.Location = new System.Drawing.Point(768, 254);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(280, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del artículo";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.Location = new System.Drawing.Point(768, 4);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(280, 242);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            this.pbImagen.DoubleClick += new System.EventHandler(this.pbImagen_DoubleClick);
            // 
            // frmResultadosBusquedaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 616);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmResultadosBusquedaArticulos";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Resultados de busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmResultadosBusquedaArticulos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private LabelControl lblComentario;
    }
}