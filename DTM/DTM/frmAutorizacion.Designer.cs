using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Padding = System.Windows.Forms.Padding;


namespace DTM
{
    partial class frmAutorizacion
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblVerCaptura = new System.Windows.Forms.LinkLabel();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.lblAutorizacion = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(656, 57);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 57);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(656, 321);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblVerCaptura);
            this.panelControl1.Controls.Add(this.lblComentario);
            this.panelControl1.Controls.Add(this.txtComentario);
            this.panelControl1.Controls.Add(this.btnDenegar);
            this.panelControl1.Controls.Add(this.lblReferencia);
            this.panelControl1.Controls.Add(this.btnAutorizar);
            this.panelControl1.Controls.Add(this.lblAutorizacion);
            this.panelControl1.Location = new System.Drawing.Point(13, 12);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(630, 297);
            this.panelControl1.TabIndex = 4;
            // 
            // lblVerCaptura
            // 
            this.lblVerCaptura.AutoSize = true;
            this.lblVerCaptura.Location = new System.Drawing.Point(19, 242);
            this.lblVerCaptura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerCaptura.Name = "lblVerCaptura";
            this.lblVerCaptura.Size = new System.Drawing.Size(81, 17);
            this.lblVerCaptura.TabIndex = 21;
            this.lblVerCaptura.TabStop = true;
            this.lblVerCaptura.Text = "Ver captura";
            // 
            // lblComentario
            // 
            this.lblComentario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblComentario.Location = new System.Drawing.Point(18, 106);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(584, 51);
            this.lblComentario.TabIndex = 20;
            this.lblComentario.Text = "Sin comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(23, 167);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComentario.MenuManager = this.ribbonControl1;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtComentario.Size = new System.Drawing.Size(579, 46);
            this.txtComentario.TabIndex = 1;
            // 
            // btnDenegar
            // 
            this.btnDenegar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDenegar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDenegar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenegar.ForeColor = System.Drawing.Color.White;
            this.btnDenegar.Location = new System.Drawing.Point(306, 225);
            this.btnDenegar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(144, 35);
            this.btnDenegar.TabIndex = 0;
            this.btnDenegar.TabStop = false;
            this.btnDenegar.Text = "Denegar";
            this.btnDenegar.UseVisualStyleBackColor = false;
            // 
            // lblReferencia
            // 
            this.lblReferencia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblReferencia.Location = new System.Drawing.Point(18, 42);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(584, 54);
            this.lblReferencia.TabIndex = 16;
            this.lblReferencia.Text = "Referencia";
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAutorizar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizar.ForeColor = System.Drawing.Color.White;
            this.btnAutorizar.Location = new System.Drawing.Point(458, 225);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(144, 35);
            this.btnAutorizar.TabIndex = 0;
            this.btnAutorizar.TabStop = false;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // lblAutorizacion
            // 
            this.lblAutorizacion.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizacion.Appearance.Options.UseFont = true;
            this.lblAutorizacion.Location = new System.Drawing.Point(23, 6);
            this.lblAutorizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAutorizacion.Name = "lblAutorizacion";
            this.lblAutorizacion.Size = new System.Drawing.Size(103, 19);
            this.lblAutorizacion.TabIndex = 10;
            this.lblAutorizacion.Text = "Autorización";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(656, 321);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(634, 301);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            // 
            // frmAutorizacion
            // 
            this.AcceptButton = this.btnAutorizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDenegar;
            this.ClientSize = new System.Drawing.Size(656, 378);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAutorizacion";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorización";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}