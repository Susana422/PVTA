using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;



namespace NORI.Restaurante
{
    partial class frmRestaurante
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
            //IL_0028: Unknown result type (might be due to invalid IL or missing references)
            //IL_0032: Expected O, but got Unknown
            //IL_0033: Unknown result type (might be due to invalid IL or missing references)
            //IL_003d: Expected O, but got Unknown
            //IL_003e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0048: Expected O, but got Unknown
            //IL_0049: Unknown result type (might be due to invalid IL or missing references)
            //IL_0053: Expected O, but got Unknown
            //IL_0054: Unknown result type (might be due to invalid IL or missing references)
            //IL_005e: Expected O, but got Unknown
            //IL_005f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0069: Expected O, but got Unknown
            //IL_01cd: Unknown result type (might be due to invalid IL or missing references)
            //IL_01d7: Expected O, but got Unknown
            //IL_022a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0234: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmRestaurante));
            ribbon = new RibbonControl();
            bbiNuevo = new BarButtonItem();
            bbiGuardar = new BarButtonItem();
            lblEstacion = new BarStaticItem();
            lblUsuario = new BarStaticItem();
            ribbonPageMesas = new RibbonPage();
            ribbonPageGroupMesasArchivo = new RibbonPageGroup();
            ribbonStatusBar = new RibbonStatusBar();
            panelMesas = new Panel();
            ((ISupportInitialize)ribbon).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ribbon.ApplicationButtonText = "SALIR";
            ((BarItem)ribbon.ExpandCollapseItem).Id = 0;
            ((BarItems)ribbon.Items).AddRange((BarItem[])(object)new BarItem[5]
            {
            (BarItem)ribbon.ExpandCollapseItem,
            (BarItem)bbiNuevo,
            (BarItem)bbiGuardar,
            (BarItem)lblEstacion,
            (BarItem)lblUsuario
            });
            ((Control)(object)ribbon).Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ((Control)(object)ribbon).Name = "ribbon";
            ribbon.Pages.AddRange((RibbonPage[])(object)new RibbonPage[1] { ribbonPageMesas });
            ribbon.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            ((Control)(object)ribbon).Size = new Size(829, 83);
            ribbon.StatusBar = ribbonStatusBar;
            ((BarItem)bbiNuevo).Caption = "Nuevo";
            ((BarItem)bbiNuevo).Id = 1;
            ((BarItem)bbiNuevo).ImageUri.Uri = "Add";
            ((BarItem)bbiNuevo).Name = "bbiNuevo";
            ((BarItem)bbiNuevo).ItemClick += new ItemClickEventHandler(bbiNuevo_ItemClick);
            ((BarItem)bbiGuardar).Caption = "Guardar";
            ((BarItem)bbiGuardar).Id = 2;
            ((BarItem)bbiGuardar).ImageUri.Uri = "Save";
            ((BarItem)bbiGuardar).Name = "bbiGuardar";
            ((BarItem)bbiGuardar).ItemClick += new ItemClickEventHandler(bbiGuardar_ItemClick);
            ((BarItem)lblEstacion).Caption = "Estación";
            ((BarItem)lblEstacion).Id = 3;
            ((BarItem)lblEstacion).Name = "lblEstacion";
            lblEstacion.TextAlignment = StringAlignment.Near;
            ((BarItem)lblUsuario).Caption = "Usuario";
            ((BarItem)lblUsuario).Id = 4;
            ((BarItem)lblUsuario).Name = "lblUsuario";
            lblUsuario.TextAlignment = StringAlignment.Near;
            ribbonPageMesas.Groups.AddRange((RibbonPageGroup[])(object)new RibbonPageGroup[1] { ribbonPageGroupMesasArchivo });
            ribbonPageMesas.Name = "ribbonPageMesas";
            ribbonPageMesas.Text = "MESAS";
            ((BarItemLinkCollection)ribbonPageGroupMesasArchivo.ItemLinks).Add((BarItem)(object)bbiNuevo);
            ((BarItemLinkCollection)ribbonPageGroupMesasArchivo.ItemLinks).Add((BarItem)(object)bbiGuardar);
            ribbonPageGroupMesasArchivo.Name = "ribbonPageGroupMesasArchivo";
            ribbonPageGroupMesasArchivo.Text = "Archivo";
            ribbonStatusBar.ItemLinks.Add((BarItem)(object)lblEstacion);
            ribbonStatusBar.ItemLinks.Add((BarItem)(object)lblUsuario, true);
            ((Control)(object)ribbonStatusBar).Location = new Point(0, 504);
            ((Control)(object)ribbonStatusBar).Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ((Control)(object)ribbonStatusBar).Size = new Size(829, 21);
            panelMesas.Dock = DockStyle.Fill;
            panelMesas.Location = new Point(0, 83);
            panelMesas.Name = "panelMesas";
            panelMesas.Size = new Size(829, 421);
            panelMesas.TabIndex = 2;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(829, 525);
            ((Control)this).Controls.Add(panelMesas);
            ((Control)this).Controls.Add((Control)(object)ribbonStatusBar);
            ((Control)this).Controls.Add((Control)(object)ribbon);
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Control)this).Name = "frmRestaurante";
            ((RibbonForm)this).Ribbon = ribbon;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((RibbonForm)this).StatusBar = ribbonStatusBar;
            ((Control)(object)this).Text = "Restaurante";
            ((Form)this).WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)ribbon).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}