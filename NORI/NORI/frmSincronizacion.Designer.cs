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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using NoriSAPB1SDK;
using NoriSDK;

namespace NORI
{
    partial class frmSincronizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSincronizacion));
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
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.popupMenuSincronizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
            ((System.Windows.Forms.Control)this.layoutControl1).SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
            ((System.Windows.Forms.Control)this.panelControl1).SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.splitContainerControl1).BeginInit();
            ((System.Windows.Forms.Control)this.splitContainerControl1).SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.gcSincronizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gvSincronizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
            base.SuspendLayout();
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[6]
            {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiRestablecerErrores,
            this.bbiEliminar,
            this.bbiAgregarBajada,
            this.barHeaderItem1,
            this.bbiAregarSubida
            });
            ((System.Windows.Forms.Control)this.ribbonControl1).Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            ((System.Windows.Forms.Control)this.ribbonControl1).Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ((System.Windows.Forms.Control)this.ribbonControl1).Size = new System.Drawing.Size(698, 49);
            this.bbiRestablecerErrores.Caption = "Restablecer mensajes de error";
            this.bbiRestablecerErrores.Id = 1;
            this.bbiRestablecerErrores.ImageUri.Uri = "Reset";
            this.bbiRestablecerErrores.Name = "bbiRestablecerErrores";
            this.bbiRestablecerErrores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiRestablecerErrores_ItemClick);
            this.bbiEliminar.Caption = "Eliminar registro";
            this.bbiEliminar.Id = 2;
            this.bbiEliminar.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiEliminar_ItemClick);
            this.bbiAgregarBajada.Caption = "Agregar a bajada";
            this.bbiAgregarBajada.Id = 4;
            this.bbiAgregarBajada.ImageUri.Uri = "AlignVerticalLeft";
            this.bbiAgregarBajada.Name = "bbiAgregarBajada";
            this.bbiAgregarBajada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiAgregarBajada_ItemClick);
            this.barHeaderItem1.Caption = "Acciones";
            this.barHeaderItem1.Id = 5;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.bbiAregarSubida.Caption = "Agregar a subida";
            this.bbiAregarSubida.Id = 6;
            this.bbiAregarSubida.ImageUri.Uri = "AlignVerticalRight";
            this.bbiAregarSubida.Name = "bbiAregarSubida";
            this.bbiAregarSubida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiAregarSubida_ItemClick);
            this.popupMenuSincronizacion.ItemLinks.Add(this.barHeaderItem1);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiAgregarBajada);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiAregarSubida);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiRestablecerErrores);
            this.popupMenuSincronizacion.ItemLinks.Add(this.bbiEliminar);
            this.popupMenuSincronizacion.Name = "popupMenuSincronizacion";
            this.popupMenuSincronizacion.Ribbon = this.ribbonControl1;
            ((System.Windows.Forms.Control)this.layoutControl1).Controls.Add(this.panelControl1);
            ((System.Windows.Forms.Control)this.layoutControl1).Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.Windows.Forms.Control)this.layoutControl1).Location = new System.Drawing.Point(0, 49);
            ((System.Windows.Forms.Control)this.layoutControl1).Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            ((System.Windows.Forms.Control)this.layoutControl1).Size = new System.Drawing.Size(698, 373);
            ((System.Windows.Forms.Control)this.layoutControl1).TabIndex = 1;
            ((System.Windows.Forms.Control)this.layoutControl1).Text = "layoutControl1";
            ((System.Windows.Forms.Control)this.panelControl1).Controls.Add(this.splitContainerControl1);
            ((System.Windows.Forms.Control)this.panelControl1).Location = new System.Drawing.Point(12, 12);
            ((System.Windows.Forms.Control)this.panelControl1).Name = "panelControl1";
            ((System.Windows.Forms.Control)this.panelControl1).Size = new System.Drawing.Size(674, 349);
            ((System.Windows.Forms.Control)this.panelControl1).TabIndex = 4;
            ((System.Windows.Forms.Control)this.splitContainerControl1).Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.Windows.Forms.Control)this.splitContainerControl1).Location = new System.Drawing.Point(2, 2);
            ((System.Windows.Forms.Control)this.splitContainerControl1).Name = "splitContainerControl1";
            ((System.Windows.Forms.Control)this.splitContainerControl1.Panel1).Controls.Add(this.lbLogs);
            ((System.Windows.Forms.Control)this.splitContainerControl1.Panel1).Text = "Panel1";
            ((System.Windows.Forms.Control)this.splitContainerControl1.Panel2).Controls.Add(this.gcSincronizacion);
            ((System.Windows.Forms.Control)this.splitContainerControl1.Panel2).Text = "Panel2";
            ((System.Windows.Forms.Control)this.splitContainerControl1).Size = new System.Drawing.Size(670, 345);
            this.splitContainerControl1.SplitterPosition = 319;
            ((System.Windows.Forms.Control)this.splitContainerControl1).TabIndex = 2;
            ((System.Windows.Forms.Control)this.splitContainerControl1).Text = "splitContainerControl1";
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.Location = new System.Drawing.Point(0, 0);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(319, 345);
            this.lbLogs.TabIndex = 2;
            ((System.Windows.Forms.Control)this.gcSincronizacion).Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.Windows.Forms.Control)this.gcSincronizacion).Location = new System.Drawing.Point(0, 0);
            this.gcSincronizacion.MainView = this.gvSincronizacion;
            this.gcSincronizacion.MenuManager = this.ribbonControl1;
            ((System.Windows.Forms.Control)this.gcSincronizacion).Name = "gcSincronizacion";
            ((System.Windows.Forms.Control)this.gcSincronizacion).Size = new System.Drawing.Size(346, 345);
            ((System.Windows.Forms.Control)this.gcSincronizacion).TabIndex = 1;
            this.gcSincronizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gvSincronizacion });
            this.gvSincronizacion.GridControl = this.gcSincronizacion;
            this.gvSincronizacion.Name = "gvSincronizacion";
            this.gvSincronizacion.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem1 });
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(698, 373);
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(678, 353);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(timer_Tick);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(698, 422);
            base.Controls.Add(this.layoutControl1);
            base.Controls.Add(this.ribbonControl1);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Name = "frmSincronizacion";
            this.ribbonControl1.SetPopupContextMenu(this, this.popupMenuSincronizacion);
            this.Ribbon = this.ribbonControl1;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.Windows.Forms.Control)this).Text = "Sincronización SAP Business One";
            base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmSincronizacion_FormClosing);
            base.Load += new System.EventHandler(frmSincronizacion_Load);
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.popupMenuSincronizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
            ((System.Windows.Forms.Control)this.layoutControl1).ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
            ((System.Windows.Forms.Control)this.panelControl1).ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainerControl1).EndInit();
            ((System.Windows.Forms.Control)this.splitContainerControl1).ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.gcSincronizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gvSincronizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}