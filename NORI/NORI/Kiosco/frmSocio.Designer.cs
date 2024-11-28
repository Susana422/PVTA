using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace NORI.Kiosco
{
    partial class frmSocio
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
            //IL_001d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0027: Expected O, but got Unknown
            //IL_0028: Unknown result type (might be due to invalid IL or missing references)
            //IL_0032: Expected O, but got Unknown
            //IL_0033: Unknown result type (might be due to invalid IL or missing references)
            //IL_003d: Expected O, but got Unknown
            //IL_003e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0048: Expected O, but got Unknown
            //IL_004f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0059: Expected O, but got Unknown
            //IL_005a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0064: Expected O, but got Unknown
            //IL_0065: Unknown result type (might be due to invalid IL or missing references)
            //IL_006f: Expected O, but got Unknown
            //IL_0070: Unknown result type (might be due to invalid IL or missing references)
            //IL_007a: Expected O, but got Unknown
            //IL_007b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0085: Expected O, but got Unknown
            //IL_0086: Unknown result type (might be due to invalid IL or missing references)
            //IL_0090: Expected O, but got Unknown
            //IL_0091: Unknown result type (might be due to invalid IL or missing references)
            //IL_009b: Expected O, but got Unknown
            //IL_009c: Unknown result type (might be due to invalid IL or missing references)
            //IL_00a6: Expected O, but got Unknown
            components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSocio));
            txtCodigo = new TextEdit();
            txtNombre = new TextEdit();
            labelControl1 = new LabelControl();
            labelControl2 = new LabelControl();
            defaultLookAndFeel1 = new DefaultLookAndFeel(components);
            txtRFC = new TextEdit();
            labelControl3 = new LabelControl();
            lblInfo = new LabelControl();
            btnCerrar = new SimpleButton();
            btnAceptar = new SimpleButton();
            btnBuscar = new SimpleButton();
            btnAlta = new SimpleButton();
            timer1 = new Timer(components);
            lblError = new Label();
            ((ISupportInitialize)txtCodigo.Properties).BeginInit();
            ((ISupportInitialize)txtNombre.Properties).BeginInit();
            ((ISupportInitialize)txtRFC.Properties).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((Control)(object)txtCodigo).Location = new Point(158, 72);
            ((Control)(object)txtCodigo).Name = "txtCodigo";
            ((RepositoryItem)txtCodigo.Properties).Appearance.Font = new Font("Tahoma", 20f);
            ((RepositoryItem)txtCodigo.Properties).Appearance.Options.UseFont = true;
            ((Control)(object)txtCodigo).Size = new Size(175, 40);
            ((Control)(object)txtCodigo).TabIndex = 0;
            ((Control)(object)txtCodigo).TextChanged += textEdit1_TextChanged;
            ((Control)(object)txtCodigo).Enter += txtNombre_Enter;
            ((Control)(object)txtCodigo).KeyDown += txtNombre_KeyDown;
            ((Control)(object)txtNombre).Location = new Point(158, 128);
            ((Control)(object)txtNombre).Name = "txtNombre";
            ((RepositoryItem)txtNombre.Properties).Appearance.Font = new Font("Tahoma", 20f);
            ((RepositoryItem)txtNombre.Properties).Appearance.Options.UseFont = true;
            ((Control)(object)txtNombre).Size = new Size(427, 40);
            ((Control)(object)txtNombre).TabIndex = 1;
            ((BaseEdit)txtNombre).EditValueChanged += textEdit2_EditValueChanged;
            ((Control)(object)txtNombre).Enter += txtNombre_Enter;
            ((Control)(object)txtNombre).KeyDown += txtNombre_KeyDown;
            ((AppearanceObject)labelControl1.Appearance).Font = new Font("Tahoma", 20f);
            ((Control)(object)labelControl1).Location = new Point(12, 75);
            ((Control)(object)labelControl1).Name = "labelControl1";
            ((Control)(object)labelControl1).Size = new Size(123, 33);
            ((Control)(object)labelControl1).TabIndex = 2;
            ((Control)(object)labelControl1).Text = "Código SN";
            ((AppearanceObject)labelControl2.Appearance).Font = new Font("Tahoma", 20f);
            ((Control)(object)labelControl2).Location = new Point(40, 131);
            ((Control)(object)labelControl2).Name = "labelControl2";
            ((Control)(object)labelControl2).Size = new Size(95, 33);
            ((Control)(object)labelControl2).TabIndex = 3;
            ((Control)(object)labelControl2).Text = "Nombre";
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.Azure;
            defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            ((Control)(object)txtRFC).Location = new Point(158, 180);
            ((Control)(object)txtRFC).Name = "txtRFC";
            ((RepositoryItem)txtRFC.Properties).Appearance.Font = new Font("Tahoma", 20f);
            ((RepositoryItem)txtRFC.Properties).Appearance.Options.UseFont = true;
            txtRFC.Properties.CharacterCasing = CharacterCasing.Upper;
            ((Control)(object)txtRFC).Size = new Size(254, 40);
            ((Control)(object)txtRFC).TabIndex = 7;
            ((Control)(object)txtRFC).Enter += txtNombre_Enter;
            ((Control)(object)txtRFC).KeyDown += txtNombre_KeyDown;
            ((AppearanceObject)labelControl3.Appearance).Font = new Font("Tahoma", 20f);
            ((Control)(object)labelControl3).Location = new Point(64, 187);
            ((Control)(object)labelControl3).Name = "labelControl3";
            ((Control)(object)labelControl3).Size = new Size(71, 33);
            ((Control)(object)labelControl3).TabIndex = 8;
            ((Control)(object)labelControl3).Text = "R.F.C.";
            ((AppearanceObject)lblInfo.Appearance).Font = new Font("Tahoma", 20f);
            ((Control)(object)lblInfo).Location = new Point(12, 12);
            ((Control)(object)lblInfo).Name = "lblInfo";
            ((Control)(object)lblInfo).Size = new Size(571, 33);
            ((Control)(object)lblInfo).TabIndex = 10;
            ((Control)(object)lblInfo).Text = "Busqueda del socio por código, nombre o R.F.C.";
            ((BaseStyleControl)btnCerrar).Appearance.Font = new Font("Tahoma", 20f);
            ((BaseStyleControl)btnCerrar).Appearance.Options.UseFont = true;
            //btnCerrar.Image = (Image)componentResourceManager.GetObject("btnCerrar.Image");
            btnCerrar.ImageLocation = (ImageLocation.MiddleCenter);
            ((Control)(object)btnCerrar).Location = new Point(12, 236);
            ((Control)(object)btnCerrar).Name = "btnCerrar";
            ((Control)(object)btnCerrar).Size = new Size(60, 46);
            ((Control)(object)btnCerrar).TabIndex = 37;
            ((Control)(object)btnCerrar).Click += btnCerrar_Click;
            ((BaseStyleControl)btnAceptar).Appearance.Font = new Font("Tahoma", 20f);
            ((BaseStyleControl)btnAceptar).Appearance.Options.UseFont = true;
            //btnAceptar.Image = (Image)componentResourceManager.GetObject("btnAceptar.Image");
            btnAceptar.ImageToTextAlignment = (ImageAlignToText.RightCenter);
            ((Control)(object)btnAceptar).Location = new Point(158, 233);
            ((Control)(object)btnAceptar).Name = "btnAceptar";
            ((Control)(object)btnAceptar).Size = new Size(427, 46);
            ((Control)(object)btnAceptar).TabIndex = 38;
            ((Control)(object)btnAceptar).Text = "Aceptar";
            ((Control)(object)btnAceptar).Click += btnAceptar_Click;
            ((BaseStyleControl)btnBuscar).Appearance.Font = new Font("Tahoma", 20f);
            ((BaseStyleControl)btnBuscar).Appearance.Options.UseFont = true;
            //btnBuscar.Image = (Image)componentResourceManager.GetObject("btnBuscar.Image");
            btnBuscar.ImageToTextAlignment = (ImageAlignToText.RightCenter);
            ((Control)(object)btnBuscar).Location = new Point(602, 67);
            ((Control)(object)btnBuscar).Name = "btnBuscar";
            ((Control)(object)btnBuscar).Size = new Size(146, 46);
            ((Control)(object)btnBuscar).TabIndex = 39;
            ((Control)(object)btnBuscar).Text = "Buscar";
            ((Control)(object)btnBuscar).Click += btnBuscar_Click;
            ((BaseStyleControl)btnAlta).Appearance.Font = new Font("Tahoma", 20f);
            ((BaseStyleControl)btnAlta).Appearance.Options.UseFont = true;
            //btnAlta.Image = (Image)componentResourceManager.GetObject("btnAlta.Image");
            btnAlta.ImageToTextAlignment = (ImageAlignToText.RightCenter);
            ((Control)(object)btnAlta).Location = new Point(602, 233);
            ((Control)(object)btnAlta).Name = "btnAlta";
            ((Control)(object)btnAlta).Size = new Size(146, 46);
            ((Control)(object)btnAlta).TabIndex = 40;
            ((Control)(object)btnAlta).Text = "Nuevo";
            ((Control)(object)btnAlta).Click += btnAlta_Click;
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            lblError.AutoSize = true;
            lblError.Font = new Font("Tahoma", 20f);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(6, 285);
            lblError.Name = "lblError";
            lblError.Size = new Size(75, 33);
            lblError.TabIndex = 11;
            lblError.Text = "Error";
            lblError.Visible = false;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(760, 319);
            ((Form)this).ControlBox = false;
            ((Control)this).Controls.Add((Control)(object)btnAlta);
            ((Control)this).Controls.Add((Control)(object)btnBuscar);
            ((Control)this).Controls.Add((Control)(object)btnAceptar);
            ((Control)this).Controls.Add((Control)(object)btnCerrar);
            ((Control)this).Controls.Add(lblError);
            ((Control)this).Controls.Add((Control)(object)lblInfo);
            ((Control)this).Controls.Add((Control)(object)labelControl3);
            ((Control)this).Controls.Add((Control)(object)txtRFC);
            ((Control)this).Controls.Add((Control)(object)labelControl2);
            ((Control)this).Controls.Add((Control)(object)labelControl1);
            ((Control)this).Controls.Add((Control)(object)txtNombre);
            ((Control)this).Controls.Add((Control)(object)txtCodigo);
            ((XtraForm)this).FormBorderEffect = (FormBorderEffect.Shadow);
            ((Form)this).FormBorderStyle = FormBorderStyle.FixedSingle;
            //((XtraForm)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            ((Form)this).MaximizeBox = false;
            ((Form)this).MinimizeBox = false;
            ((Control)this).Name = "frmSocio";
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Socio";
            ((Form)this).Load += frmSocio_Load;
            ((ISupportInitialize)txtCodigo.Properties).EndInit();
            ((ISupportInitialize)txtNombre.Properties).EndInit();
            ((ISupportInitialize)txtRFC.Properties).EndInit();
            ((XtraForm)this).ResumeLayout(false);
            ((Control)this).PerformLayout();
        }
    }
}