using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using NoriSDK;


namespace NORI.Kiosco
{
    partial class frmAltaRapidaSocio
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
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMunicipio = new DevExpress.XtraEditors.TextEdit();
            this.luePais = new DevExpress.XtraEditors.LookUpEdit();
            this.lueEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.lueUsoPrincipal = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsoPrincipal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(315, 80);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtRFC.Properties.Appearance.Options.UseFont = true;
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Size = new System.Drawing.Size(346, 42);
            this.txtRFC.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(315, 140);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(601, 42);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(315, 381);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCalle.Properties.Appearance.Options.UseFont = true;
            this.txtCalle.Size = new System.Drawing.Size(601, 42);
            this.txtCalle.TabIndex = 7;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(315, 320);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtColonia.Properties.Appearance.Options.UseFont = true;
            this.txtColonia.Size = new System.Drawing.Size(601, 42);
            this.txtColonia.TabIndex = 6;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(705, 441);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCP.Properties.Appearance.Options.UseFont = true;
            this.txtCP.Size = new System.Drawing.Size(211, 42);
            this.txtCP.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 33);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "R.F.C.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 144);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 33);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Razón social";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 384);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 33);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Calle";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 324);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 33);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Colonia";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 264);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 33);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Ciudad";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(568, 445);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 33);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "C.P.";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(568, 264);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(111, 33);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Municipio";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(568, 209);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 33);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Estado";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(20, 204);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 33);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "País";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 445);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(194, 33);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Número exterior";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 505);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(216, 33);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "Correo electrónico";
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Location = new System.Drawing.Point(315, 441);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Size = new System.Drawing.Size(231, 42);
            this.txtNumero.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(315, 501);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Size = new System.Drawing.Size(601, 42);
            this.txtEmail.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnLimpiar.Appearance.Options.UseFont = true;
            this.btnLimpiar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(99, 642);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 60);
            this.btnLimpiar.TabIndex = 26;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.EditValue = "";
            this.txtMunicipio.Location = new System.Drawing.Point(705, 260);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtMunicipio.Properties.Appearance.Options.UseFont = true;
            this.txtMunicipio.Size = new System.Drawing.Size(211, 42);
            this.txtMunicipio.TabIndex = 5;
            // 
            // luePais
            // 
            this.luePais.Location = new System.Drawing.Point(315, 200);
            this.luePais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luePais.Name = "luePais";
            this.luePais.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.luePais.Properties.Appearance.Options.UseFont = true;
            this.luePais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePais.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luePais.Properties.NullText = "";
            this.luePais.Size = new System.Drawing.Size(231, 42);
            this.luePais.TabIndex = 2;
            // 
            // lueEstado
            // 
            this.lueEstado.Location = new System.Drawing.Point(705, 200);
            this.lueEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lueEstado.Name = "lueEstado";
            this.lueEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lueEstado.Properties.Appearance.Options.UseFont = true;
            this.lueEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueEstado.Properties.NullText = "";
            this.lueEstado.Size = new System.Drawing.Size(211, 42);
            this.lueEstado.TabIndex = 3;
            // 
            // txtCiudad
            // 
            this.txtCiudad.EditValue = "";
            this.txtCiudad.Location = new System.Drawing.Point(315, 260);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCiudad.Properties.Appearance.Options.UseFont = true;
            this.txtCiudad.Size = new System.Drawing.Size(231, 42);
            this.txtCiudad.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(315, 20);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(346, 42);
            this.txtCodigo.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(22, 24);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 33);
            this.labelControl7.TabIndex = 35;
            this.labelControl7.Text = "Código";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCerrar.Location = new System.Drawing.Point(22, 642);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 60);
            this.btnCerrar.TabIndex = 36;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAceptar.Location = new System.Drawing.Point(315, 642);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(601, 60);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            // 
            // lueUsoPrincipal
            // 
            this.lueUsoPrincipal.Location = new System.Drawing.Point(315, 561);
            this.lueUsoPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lueUsoPrincipal.Name = "lueUsoPrincipal";
            this.lueUsoPrincipal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lueUsoPrincipal.Properties.Appearance.Options.UseFont = true;
            this.lueUsoPrincipal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsoPrincipal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueUsoPrincipal.Properties.NullText = "";
            this.lueUsoPrincipal.Size = new System.Drawing.Size(601, 42);
            this.lueUsoPrincipal.TabIndex = 11;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(20, 565);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(152, 33);
            this.labelControl13.TabIndex = 39;
            this.labelControl13.Text = "Uso principal";
            // 
            // frmAltaRapidaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 717);
            this.ControlBox = false;
            this.Controls.Add(this.lueUsoPrincipal);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lueEstado);
            this.Controls.Add(this.luePais);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRFC);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaRapidaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de socio";
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsoPrincipal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}