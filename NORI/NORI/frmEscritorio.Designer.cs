using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DashboardWin;
using DevExpress.XtraEditors;

namespace NORI
{
    partial class frmEscritorio
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
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.webView24 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView24)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(915, 734);
            this.dashboardViewer1.TabIndex = 0;
            // 
            // webView24
            // 
            this.webView24.AllowExternalDrop = true;
            this.webView24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView24.CreationProperties = null;
            this.webView24.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView24.Location = new System.Drawing.Point(0, 0);
            this.webView24.Name = "webView24";
            this.webView24.Size = new System.Drawing.Size(915, 744);
            this.webView24.TabIndex = 1;
            this.webView24.ZoomFactor = 1D;
            // 
            // frmEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 734);
            this.Controls.Add(this.webView24);
            this.Controls.Add(this.dashboardViewer1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio";
            
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView24)).EndInit();
            this.ResumeLayout(false);

        }
        private Microsoft.Web.WebView2.WinForms.WebView2 webView24;
    }
}