namespace NORI.HuellaDigital
{
    partial class AutenticarHuellaDigital
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.VerificationControl = new DPFP.Gui.Verification.VerificationControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.None;
            this.ribbon.OptionsSearchMenu.UseCustomRibbonSearch = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office365;
            this.ribbon.Size = new System.Drawing.Size(400, 30);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 172);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(400, 29);
            // 
            // VerificationControl
            // 
            this.VerificationControl.Active = true;
            this.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificationControl.Location = new System.Drawing.Point(47, 64);
            this.VerificationControl.Margin = new System.Windows.Forms.Padding(5);
            this.VerificationControl.Name = "VerificationControl";
            this.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.VerificationControl.Size = new System.Drawing.Size(43, 53);
            this.VerificationControl.TabIndex = 9;
            this.VerificationControl.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.VerificationControl_OnComplete);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(113, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Para verificar su identidad, toque el lector de huellas digitales con el dedo reg" +
    "istrado.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(235, 132);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 29);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // AutenticarHuellaDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerificationControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutenticarHuellaDigital";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Huella Digital";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DPFP.Gui.Verification.VerificationControl VerificationControl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnRegresar;
    }
}