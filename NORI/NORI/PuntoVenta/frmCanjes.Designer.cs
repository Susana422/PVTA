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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;



namespace NORI.PuntoVenta
{
    partial class frmCanjes
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
            //IL_0049: Unknown result type (might be due to invalid IL or missing references)
            //IL_0053: Expected O, but got Unknown
            //IL_0054: Unknown result type (might be due to invalid IL or missing references)
            //IL_005e: Expected O, but got Unknown
            //IL_005f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0069: Expected O, but got Unknown
            //IL_006a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0074: Expected O, but got Unknown
            //IL_0075: Unknown result type (might be due to invalid IL or missing references)
            //IL_007f: Expected O, but got Unknown
            //IL_0080: Unknown result type (might be due to invalid IL or missing references)
            //IL_008a: Expected O, but got Unknown
            //IL_008b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0095: Expected O, but got Unknown
            //IL_0096: Unknown result type (might be due to invalid IL or missing references)
            //IL_00a0: Expected O, but got Unknown
            //IL_00b7: Unknown result type (might be due to invalid IL or missing references)
            //IL_00c1: Expected O, but got Unknown
            //IL_00c2: Unknown result type (might be due to invalid IL or missing references)
            //IL_00cc: Expected O, but got Unknown
            //IL_0628: Unknown result type (might be due to invalid IL or missing references)
            //IL_062e: Expected O, but got Unknown
            //IL_0660: Unknown result type (might be due to invalid IL or missing references)
            //IL_0666: Expected O, but got Unknown
            //IL_0672: Unknown result type (might be due to invalid IL or missing references)
            //IL_0678: Expected O, but got Unknown
            //IL_070d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0713: Expected O, but got Unknown
            //IL_0745: Unknown result type (might be due to invalid IL or missing references)
            //IL_074b: Expected O, but got Unknown
            //IL_0757: Unknown result type (might be due to invalid IL or missing references)
            //IL_075d: Expected O, but got Unknown
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCanjes));
            ribbonControl1 = new RibbonControl();
            layoutControl1 = new LayoutControl();
            panel1 = new Panel();
            lblImporte = new Label();
            lblImporte_ = new Label();
            lblConceptoEgreso = new LabelControl();
            lblConceptoIngreso = new LabelControl();
            cbEgreso = new LookUpEdit();
            cbIngreso = new LookUpEdit();
            txtComentario = new MemoEdit();
            lblComentario = new LabelControl();
            txtCantidad = new TextEdit();
            lblCantidad = new LabelControl();
            btnCancelar = new Button();
            btnAceptar = new Button();
            layoutControlGroup1 = new LayoutControlGroup();
            layoutControlItem1 = new LayoutControlItem();
            ((ISupportInitialize)ribbonControl1).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            ((Control)(object)layoutControl1).SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)cbEgreso.Properties).BeginInit();
            ((ISupportInitialize)cbIngreso.Properties).BeginInit();
            ((ISupportInitialize)txtComentario.Properties).BeginInit();
            ((ISupportInitialize)txtCantidad.Properties).BeginInit();
            ((ISupportInitialize)layoutControlGroup1).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((BarItem)ribbonControl1.ExpandCollapseItem).Id = 0;
            ((BarItems)ribbonControl1.Items).AddRange((BarItem[])(object)new BarItem[1] { (BarItem)ribbonControl1.ExpandCollapseItem });
            ((Control)(object)ribbonControl1).Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 1;
            ((Control)(object)ribbonControl1).Name = "ribbonControl1";
            ribbonControl1.RibbonStyle = (RibbonControlStyle.OfficeUniversal);
            ribbonControl1.ShowApplicationButton = (DefaultBoolean.False);
            ((Control)(object)ribbonControl1).Size = new Size(402, 54);
            ((Control)(object)layoutControl1).Controls.Add(panel1);
            ((Control)(object)layoutControl1).Dock = DockStyle.Fill;
            ((Control)(object)layoutControl1).Location = new Point(0, 54);
            ((Control)(object)layoutControl1).Name = "layoutControl1";
            layoutControl1.Root = layoutControlGroup1;
            ((Control)(object)layoutControl1).Size = new Size(402, 252);
            ((Control)(object)layoutControl1).TabIndex = 1;
            ((Control)(object)layoutControl1).Text = "layoutControl1";
            panel1.Controls.Add(lblImporte);
            panel1.Controls.Add(lblImporte_);
            panel1.Controls.Add((Control)(object)lblConceptoEgreso);
            panel1.Controls.Add((Control)(object)lblConceptoIngreso);
            panel1.Controls.Add((Control)(object)cbEgreso);
            panel1.Controls.Add((Control)(object)cbIngreso);
            panel1.Controls.Add((Control)(object)txtComentario);
            panel1.Controls.Add((Control)(object)lblComentario);
            panel1.Controls.Add((Control)(object)txtCantidad);
            panel1.Controls.Add((Control)(object)lblCantidad);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 228);
            panel1.TabIndex = 0;
            lblImporte.AutoEllipsis = true;
            lblImporte.Font = new Font("Tahoma", 14f, FontStyle.Bold);
            lblImporte.ForeColor = Color.MidnightBlue;
            lblImporte.Location = new Point(215, 158);
            lblImporte.Name = "lblImporte";
            lblImporte.RightToLeft = RightToLeft.Yes;
            lblImporte.Size = new Size(153, 25);
            lblImporte.TabIndex = 69;
            lblImporte.Text = "0.00";
            lblImporte_.AutoSize = true;
            lblImporte_.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            lblImporte_.Location = new Point(154, 158);
            lblImporte_.Name = "lblImporte_";
            lblImporte_.Size = new Size(54, 13);
            lblImporte_.TabIndex = 68;
            lblImporte_.Text = "Importe";
            ((Control)(object)lblConceptoEgreso).Location = new Point(12, 68);
            ((Control)(object)lblConceptoEgreso).Name = "lblConceptoEgreso";
            ((Control)(object)lblConceptoEgreso).Size = new Size(82, 13);
            ((Control)(object)lblConceptoEgreso).TabIndex = 64;
            ((Control)(object)lblConceptoEgreso).Text = "Concepto egreso";
            ((Control)(object)lblConceptoIngreso).Location = new Point(12, 16);
            ((Control)(object)lblConceptoIngreso).Name = "lblConceptoIngreso";
            ((Control)(object)lblConceptoIngreso).Size = new Size(84, 13);
            ((Control)(object)lblConceptoIngreso).TabIndex = 63;
            ((Control)(object)lblConceptoIngreso).Text = "Concepto ingreso";
            ((Control)(object)cbEgreso).Location = new Point(114, 65);
            ((BaseEdit)cbEgreso).MenuManager = (IDXMenuManager)(object)ribbonControl1;
            ((Control)(object)cbEgreso).Name = "cbEgreso";
            ((RepositoryItemButtonEdit)cbEgreso.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbEgreso.Properties.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("id", "ID", 20, (FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("nombre", "Nombre")
            });
            ((Control)(object)cbEgreso).Size = new Size(250, 20);
            ((Control)(object)cbEgreso).TabIndex = 2;
            ((BaseEdit)cbEgreso).EditValueChanged += cbIngreso_EditValueChanged;
            ((Control)(object)cbIngreso).Location = new Point(114, 13);
            ((BaseEdit)cbIngreso).MenuManager = (IDXMenuManager)(object)ribbonControl1;
            ((Control)(object)cbIngreso).Name = "cbIngreso";
            ((RepositoryItemButtonEdit)cbIngreso.Properties).Buttons.AddRange((EditorButton[])(object)new EditorButton[1]
            {
            new EditorButton((ButtonPredefines.Combo))
            });
            cbIngreso.Properties.Columns.AddRange((LookUpColumnInfo[])(object)new LookUpColumnInfo[2]
            {
            new LookUpColumnInfo("id", "ID", 20, (FormatType.None), "", false, (HorzAlignment.Default)),
            new LookUpColumnInfo("nombre", "Nombre")
            });
            ((Control)(object)cbIngreso).Size = new Size(250, 20);
            ((Control)(object)cbIngreso).TabIndex = 0;
            ((BaseEdit)cbIngreso).EditValueChanged += cbIngreso_EditValueChanged;
            ((Control)(object)txtComentario).Location = new Point(114, 91);
            ((BaseEdit)txtComentario).MenuManager = (IDXMenuManager)(object)ribbonControl1;
            ((Control)(object)txtComentario).Name = "txtComentario";
            ((Control)(object)txtComentario).Size = new Size(250, 54);
            ((Control)(object)txtComentario).TabIndex = 3;
            ((Control)(object)lblComentario).Location = new Point(12, 94);
            ((Control)(object)lblComentario).Name = "lblComentario";
            ((Control)(object)lblComentario).Size = new Size(55, 13);
            ((Control)(object)lblComentario).TabIndex = 2;
            ((Control)(object)lblComentario).Text = "Comentario";
            ((BaseEdit)txtCantidad).EditValue = "1";
            ((Control)(object)txtCantidad).Location = new Point(114, 39);
            ((Control)(object)txtCantidad).Name = "txtCantidad";
            ((RepositoryItem)txtCantidad.Properties).Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            ((RepositoryItem)txtCantidad.Properties).Appearance.Options.UseFont = true;
            ((RepositoryItem)txtCantidad.Properties).DisplayFormat.FormatString = "c2";
            txtCantidad.Properties.Mask.EditMask = "c2";
            txtCantidad.Properties.Mask.MaskType = (MaskType.Numeric);
            txtCantidad.Properties.MaxLength = 100;
            ((Control)(object)txtCantidad).Size = new Size(250, 20);
            ((Control)(object)txtCantidad).TabIndex = 1;
            ((Control)(object)txtCantidad).TextChanged += txtCantidad_TextChanged;
            ((Control)(object)lblCantidad).Location = new Point(12, 42);
            ((Control)(object)lblCantidad).Name = "lblCantidad";
            ((Control)(object)lblCantidad).Size = new Size(43, 13);
            ((Control)(object)lblCantidad).TabIndex = 60;
            ((Control)(object)lblCantidad).Text = "Cantidad";
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancelar.Location = new Point(12, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 27);
            btnCancelar.TabIndex = 0;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnAceptar.BackColor = Color.FromArgb(248, 152, 33);
            btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(247, 135, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(256, 189);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 27);
            btnAceptar.TabIndex = 0;
            btnAceptar.TabStop = false;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            ((LayoutGroup)layoutControlGroup1).EnableIndentsWithoutBorders = (DefaultBoolean.True);
            ((LayoutGroup)layoutControlGroup1).GroupBordersVisible = false;
            ((BaseItemCollection)layoutControlGroup1.Items).AddRange((BaseLayoutItem[])(object)new BaseLayoutItem[1] { (BaseLayoutItem)layoutControlItem1 });
            ((BaseLayoutItem)layoutControlGroup1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlGroup1).Name = "layoutControlGroup1";
            ((BaseLayoutItem)layoutControlGroup1).Size = new Size(402, 252);
            ((BaseLayoutItem)layoutControlGroup1).TextVisible = false;
            layoutControlItem1.Control = panel1;
            ((BaseLayoutItem)layoutControlItem1).Location = new Point(0, 0);
            ((BaseLayoutItem)layoutControlItem1).Name = "layoutControlItem1";
            ((BaseLayoutItem)layoutControlItem1).Size = new Size(382, 232);
            ((BaseLayoutItem)layoutControlItem1).TextSize = new Size(0, 0);
            ((BaseLayoutItem)layoutControlItem1).TextVisible = false;
            ((Form)this).AcceptButton = btnAceptar;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).CancelButton = btnCancelar;
            ((Form)this).ClientSize = new Size(402, 306);
            ((Control)this).Controls.Add((Control)(object)layoutControl1);
            ((Control)this).Controls.Add((Control)(object)ribbonControl1);
            ((Form)this).FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Form)this).KeyPreview = true;
            ((Control)this).Name = "frmCanjes";
            ((RibbonForm)this).Ribbon = ribbonControl1;
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Canje";
            ((ISupportInitialize)ribbonControl1).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            ((Control)(object)layoutControl1).ResumeLayout(performLayout: false);
            panel1.ResumeLayout(performLayout: false);
            panel1.PerformLayout();
            ((ISupportInitialize)cbEgreso.Properties).EndInit();
            ((ISupportInitialize)cbIngreso.Properties).EndInit();
            ((ISupportInitialize)txtComentario.Properties).EndInit();
            ((ISupportInitialize)txtCantidad.Properties).EndInit();
            ((ISupportInitialize)layoutControlGroup1).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }

    }
}