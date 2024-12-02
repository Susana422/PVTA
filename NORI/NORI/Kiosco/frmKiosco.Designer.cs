using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;


namespace NORI.Kiosco
{
    partial class frmKiosco
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
            this.txtNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.btnFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.txtPIN = new DevExpress.XtraEditors.TextEdit();
            this.lblPIN = new DevExpress.XtraEditors.LabelControl();
            this.lblDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(36, 595);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.txtNumeroDocumento.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroDocumento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumeroDocumento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNumeroDocumento.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(556, 56);
            this.txtNumeroDocumento.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnFacturar.Appearance.Options.UseFont = true;
            this.btnFacturar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnFacturar.Location = new System.Drawing.Point(617, 693);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(274, 71);
            this.btnFacturar.TabIndex = 0;
            this.btnFacturar.TabStop = false;
            this.btnFacturar.Text = "Facturar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnLimpiar.Appearance.Options.UseFont = true;
            this.btnLimpiar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(36, 693);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 71);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.TabStop = false;
            // 
            // txtPIN
            // 
            this.txtPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPIN.Location = new System.Drawing.Point(617, 595);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.txtPIN.Properties.Appearance.Options.UseFont = true;
            this.txtPIN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPIN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPIN.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtPIN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPIN.Properties.MaxLength = 6;
            this.txtPIN.Size = new System.Drawing.Size(274, 56);
            this.txtPIN.TabIndex = 1;
            // 
            // lblPIN
            // 
            this.lblPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPIN.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblPIN.Appearance.Options.UseFont = true;
            this.lblPIN.Location = new System.Drawing.Point(729, 544);
            this.lblPIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(43, 33);
            this.lblPIN.TabIndex = 5;
            this.lblPIN.Text = "PIN";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDocumento.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblDocumento.Appearance.Options.UseFont = true;
            this.lblDocumento.Location = new System.Drawing.Point(36, 544);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(136, 33);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Documento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(933, 77);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "-";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Location = new System.Drawing.Point(36, 109);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(855, 428);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // frmKiosco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 785);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtNumeroDocumento);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKiosco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco de facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}