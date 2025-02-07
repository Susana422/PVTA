﻿using System;
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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using SAPB1SDK;
using SDK;

namespace DTM
{
    partial class frmSincronizacion
    {


        protected override void Dispose(bool disposing)
        {
            try
            {
                components.Dispose();
                if (disposing && components != null)
                {
                    components.Dispose();
                }
                // Dispose(disposing);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiRestablecerErrores = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAgregarBajada = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiAregarSubida = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuSincronizacion = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.gcSincronizacion = new DevExpress.XtraGrid.GridControl();
            this.gvSincronizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSincronizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiRestablecerErrores,
            this.bbiEliminar,
            this.bbiAgregarBajada,
            this.barHeaderItem1,
            this.bbiAregarSubida});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(814, 71);
            // 
            // bbiRestablecerErrores
            // 
            this.bbiRestablecerErrores.Caption = "Restablecer mensajes de error";
            this.bbiRestablecerErrores.Id = 1;
            this.bbiRestablecerErrores.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiRestablecerErrores.Name = "bbiRestablecerErrores";
            this.bbiRestablecerErrores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRestablecerErrores_ItemClick);
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar registro";
            this.bbiEliminar.Id = 2;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminar_ItemClick);
            // 
            // bbiAgregarBajada
            // 
            this.bbiAgregarBajada.Caption = "Agregar a bajada";
            this.bbiAgregarBajada.Id = 4;
            this.bbiAgregarBajada.ImageOptions.ImageUri.Uri = "AlignVerticalLeft";
            this.bbiAgregarBajada.Name = "bbiAgregarBajada";
            this.bbiAgregarBajada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAgregarBajada_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Acciones";
            this.barHeaderItem1.Id = 5;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bbiAregarSubida
            // 
            this.bbiAregarSubida.Caption = "Agregar a subida";
            this.bbiAregarSubida.Id = 6;
            this.bbiAregarSubida.ImageOptions.ImageUri.Uri = "AlignVerticalRight";
            this.bbiAregarSubida.Name = "bbiAregarSubida";
            this.bbiAregarSubida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAregarSubida_ItemClick);
            // 
            // popupMenuSincronizacion
            // 
            this.popupMenuSincronizacion.ItemLinks.Add(this.barHeaderItem1);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiAgregarBajada);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiAregarSubida);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiRestablecerErrores);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiEliminar);
            this.popupMenuSincronizacion.Name = "popupMenuSincronizacion";
            this.popupMenuSincronizacion.Ribbon = this.ribbonControl1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 71);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(814, 481);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Location = new System.Drawing.Point(14, 16);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(786, 449);
            this.panelControl1.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.lbLogs);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcSincronizacion);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(782, 445);
            this.splitContainerControl1.SplitterPosition = 372;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lbLogs
            // 
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 17;
            this.lbLogs.Location = new System.Drawing.Point(0, 0);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(372, 445);
            this.lbLogs.TabIndex = 2;
            // 
            // gcSincronizacion
            // 
            this.gcSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSincronizacion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSincronizacion.Location = new System.Drawing.Point(0, 0);
            this.gcSincronizacion.MainView = this.gvSincronizacion;
            this.gcSincronizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSincronizacion.MenuManager = this.ribbonControl1;
            this.gcSincronizacion.Name = "gcSincronizacion";
            this.gcSincronizacion.Size = new System.Drawing.Size(398, 445);
            this.gcSincronizacion.TabIndex = 1;
            this.gcSincronizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSincronizacion});
            // 
            // gvSincronizacion
            // 
            this.gvSincronizacion.DetailHeight = 458;
            this.gvSincronizacion.GridControl = this.gcSincronizacion;
            this.gvSincronizacion.Name = "gvSincronizacion";
            this.gvSincronizacion.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 481);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(790, 455);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSincronizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 552);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSincronizacion";
            this.ribbonControl1.SetPopupContextMenu(this, this.popupMenuSincronizacion);
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronización SAP Business One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSincronizacion_FormClosing);
            this.Load += new System.EventHandler(this.frmSincronizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSincronizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}