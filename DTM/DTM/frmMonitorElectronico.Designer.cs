using DevExpress.XtraBars;
using System;

namespace DTM
{
    partial class frmMonitorElectronico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gvMonitor = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.txtxFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbEstatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bbiXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuDocumentos = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiXLSX});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(1115, 30);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 683);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1115, 29);
            // 
            // gvMonitor
            // 
            this.gvMonitor.Location = new System.Drawing.Point(12, 191);
            this.gvMonitor.MainView = this.gridView1;
            this.gvMonitor.MenuManager = this.ribbon;
            this.gvMonitor.Name = "gvMonitor";
            this.gvMonitor.Size = new System.Drawing.Size(1091, 486);
            this.gvMonitor.TabIndex = 2;
            this.gvMonitor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvMonitor;
            this.gridView1.Name = "gridView1";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.EditValue = new System.DateTime(2024, 12, 23, 13, 26, 22, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(745, 85);
            this.txtFechaFin.MenuManager = this.ribbon;
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFin.Size = new System.Drawing.Size(358, 24);
            this.txtFechaFin.TabIndex = 3;
            // 
            // txtxFechaInicio
            // 
            this.txtxFechaInicio.EditValue = new System.DateTime(2024, 12, 23, 13, 26, 19, 0);
            this.txtxFechaInicio.Location = new System.Drawing.Point(420, 85);
            this.txtxFechaInicio.MenuManager = this.ribbon;
            this.txtxFechaInicio.Name = "txtxFechaInicio";
            this.txtxFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtxFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtxFechaInicio.Size = new System.Drawing.Size(298, 24);
            this.txtxFechaInicio.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(947, 138);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 31);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Buscar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(745, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Fecha Fin";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(420, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Fecha Inicio";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 17);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Estatus";
            // 
            // cbEstatus
            // 
            this.cbEstatus.Location = new System.Drawing.Point(40, 85);
            this.cbEstatus.MenuManager = this.ribbon;
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstatus.Properties.Items.AddRange(new object[] {
            "Todo",
            "Ok",
            "Error",
            "Pendiente"});
            this.cbEstatus.Size = new System.Drawing.Size(353, 24);
            this.cbEstatus.TabIndex = 12;
            // 
            // bbiXLSX
            // 
            this.bbiXLSX.Caption = "XLSX";
            this.bbiXLSX.Id = 15;
            this.bbiXLSX.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.bbiXLSX.Name = "bbiXLSX";
            this.bbiXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXLSX_ItemClick);
            // 
            // popupMenuDocumentos
            // 
            this.popupMenuDocumentos.ItemLinks.Add(this.bbiXLSX);
            this.popupMenuDocumentos.Name = "popupMenuDocumentos";
            this.popupMenuDocumentos.Ribbon = this.ribbon;
            // 
            // frmMonitorElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 712);
            this.Controls.Add(this.cbEstatus);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtxFechaInicio);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.gvMonitor);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.MaximizeBox = false;
            this.Name = "frmMonitorElectronico";
            this.ribbon.SetPopupContextMenu(this, this.popupMenuDocumentos);
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Monitor Electronico";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gvMonitor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit txtFechaFin;
        private DevExpress.XtraEditors.DateEdit txtxFechaInicio;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbEstatus;
        private DevExpress.XtraBars.PopupMenu popupMenuDocumentos;
        private BarButtonItem bbiXLSX;
    }
}