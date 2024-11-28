using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;

namespace NORI.HuellaDigital
{
    partial class frmHuellaDigital
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
            //IL_005f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0069: Expected O, but got Unknown
            //IL_006a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0074: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHuellaDigital));
            ribbonControl1 = new RibbonControl();
            layoutControl1 = new LayoutControl();
            panel1 = new Panel();
            StatusLine = new Label();
            StatusText = new TextBox();
            Prompt = new TextBox();
            Picture = new PictureBox();
            layoutControlGroup1 = new LayoutControlGroup();
            layoutControlItem1 = new LayoutControlItem();
            Label label = new Label();
            Label label2 = new Label();
            ((ISupportInitialize)ribbonControl1).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            ((Control)(object)layoutControl1).SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)Picture).BeginInit();
            ((ISupportInitialize)layoutControlGroup1).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((XtraForm)this).SuspendLayout();
            label.AutoSize = true;
            label.Location = new Point(208, 41);
            label.Name = "StatusLabel";
            label.Size = new Size(44, 13);
            label.TabIndex = 10;
            label.Text = "Estado:";
            label2.AutoSize = true;
            label2.Location = new Point(208, 4);
            label2.Name = "PromptLabel";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 8;
            label2.Text = "Salida:";
            ((BarItem)ribbonControl1.ExpandCollapseItem).Id = 0;
            ((BarItems)ribbonControl1.Items).AddRange((BarItem[])(object)new BarItem[1] { (BarItem)ribbonControl1.ExpandCollapseItem });
            ((Control)(object)ribbonControl1).Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 1;
            ((Control)(object)ribbonControl1).Name = "ribbonControl1";
            ribbonControl1.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            ribbonControl1.ShowApplicationButton = (DefaultBoolean.False);
            ((Control)(object)ribbonControl1).Size = new Size(571, 54);
            ((Control)(object)layoutControl1).Controls.Add(panel1);
            ((Control)(object)layoutControl1).Dock = DockStyle.Fill;
            ((Control)(object)layoutControl1).Location = new Point(0, 54);
            ((Control)(object)layoutControl1).Name = "layoutControl1";
            layoutControl1.Root = layoutControlGroup1;
            ((Control)(object)layoutControl1).Size = new Size(571, 287);
            ((Control)(object)layoutControl1).TabIndex = 1;
            ((Control)(object)layoutControl1).Text = "layoutControl1";
            panel1.Controls.Add(StatusLine);
            panel1.Controls.Add(StatusText);
            panel1.Controls.Add(label);
            panel1.Controls.Add(Prompt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Picture);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 263);
            panel1.TabIndex = 4;
            StatusLine.AutoSize = true;
            StatusLine.Location = new Point(11, 243);
            StatusLine.Name = "StatusLine";
            StatusLine.Size = new Size(11, 13);
            StatusLine.TabIndex = 12;
            StatusLine.Text = "-";
            StatusText.BackColor = SystemColors.Window;
            StatusText.BorderStyle = BorderStyle.None;
            StatusText.Location = new Point(211, 57);
            StatusText.Multiline = true;
            StatusText.Name = "StatusText";
            StatusText.ReadOnly = true;
            StatusText.ScrollBars = ScrollBars.Both;
            StatusText.Size = new Size(326, 199);
            StatusText.TabIndex = 11;
            Prompt.BorderStyle = BorderStyle.None;
            Prompt.Location = new Point(211, 23);
            Prompt.Name = "Prompt";
            Prompt.ReadOnly = true;
            Prompt.Size = new Size(326, 14);
            Prompt.TabIndex = 9;
            Picture.BackColor = SystemColors.Window;
            Picture.Location = new Point(14, 4);
            Picture.Name = "Picture";
            Picture.Size = new Size(181, 235);
            Picture.TabIndex = 7;
            Picture.TabStop = false;
            ((LayoutGroup)layoutControlGroup1).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup1).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup1.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[1] { (BaseLayoutItem)layoutControlItem1 });
            ((BaseLayoutItem)layoutControlGroup1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup1).Name = "layoutControlGroup1";
            ((BaseLayoutItem)layoutControlGroup1).Size = new Size(571, 287);
            ((BaseLayoutItem)layoutControlGroup1).TextVisible = false;
            layoutControlItem1.Control = panel1;
            ((BaseLayoutItem)layoutControlItem1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem1).Name = "layoutControlItem1";
            ((BaseLayoutItem)layoutControlItem1).Size = new Size(551, 267);
            ((BaseLayoutItem)layoutControlItem1).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem1).TextVisible = false;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(571, 341);
            ((Control)this).Controls.Add((Control)(object)layoutControl1);
            ((Control)this).Controls.Add((Control)(object)ribbonControl1);
            ((Form)this).FormBorderStyle = FormBorderStyle.FixedSingle;
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Form)this).MaximizeBox = false;
            ((Form)this).MinimizeBox = false;
            ((Control)this).Name = "frmHuellaDigital";
            ((RibbonForm)this).Ribbon = ribbonControl1;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Huella digital";
            ((Form)this).FormClosed += frmHuellaDigital_FormClosed;
            ((Form)this).Load += frmHuellaDigital_Load;
            ((ISupportInitialize)ribbonControl1).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            ((Control)(object)layoutControl1).ResumeLayout(performLayout: false);
            panel1.ResumeLayout(performLayout: false);
            panel1.PerformLayout();
            ((ISupportInitialize)Picture).EndInit();
            ((ISupportInitialize)layoutControlGroup1).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}