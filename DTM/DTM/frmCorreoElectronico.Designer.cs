using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DTM
{
    partial class frmCorreoElectronico
    {
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

        private void InitializeComponent()
        {
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.cbCorreoElectronico = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCorreoElectronico = new DevExpress.XtraEditors.LabelControl();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblAnexos = new DevExpress.XtraEditors.LabelControl();
            this.lbAnexos = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txtDestinatario = new DevExpress.XtraEditors.TextEdit();
            this.lblDestinatario = new DevExpress.XtraEditors.LabelControl();
            this.lblDestinatarios = new DevExpress.XtraEditors.LabelControl();
            this.lbDestinatarios = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.txtMensaje = new DevExpress.XtraEditors.MemoEdit();
            this.txtAsunto = new DevExpress.XtraEditors.TextEdit();
            this.lblAsunto = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDestinatarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCorreoElectronico);
            this.panel1.Controls.Add(this.lblCorreoElectronico);
            this.panel1.Controls.Add(this.btnAnexo);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.lblAnexos);
            this.panel1.Controls.Add(this.lbAnexos);
            this.panel1.Controls.Add(this.txtDestinatario);
            this.panel1.Controls.Add(this.lblDestinatario);
            this.panel1.Controls.Add(this.lblDestinatarios);
            this.panel1.Controls.Add(this.lbDestinatarios);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.txtMensaje);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.lblAsunto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 573);
            this.panel1.TabIndex = 0;
            // 
            // cbCorreoElectronico
            // 
            this.cbCorreoElectronico.Location = new System.Drawing.Point(14, 38);
            this.cbCorreoElectronico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCorreoElectronico.Name = "cbCorreoElectronico";
            this.cbCorreoElectronico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCorreoElectronico.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Correo electrónico", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCorreoElectronico.Properties.NullText = "";
            this.cbCorreoElectronico.Size = new System.Drawing.Size(487, 24);
            this.cbCorreoElectronico.TabIndex = 57;
            this.cbCorreoElectronico.EditValueChanged += new System.EventHandler(this.cbCorreoElectronico_EditValueChanged);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.Location = new System.Drawing.Point(14, 13);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(21, 17);
            this.lblCorreoElectronico.TabIndex = 56;
            this.lblCorreoElectronico.Text = "De:";
            // 
            // btnAnexo
            // 
            this.btnAnexo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAnexo.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexo.ForeColor = System.Drawing.Color.White;
            this.btnAnexo.Location = new System.Drawing.Point(14, 508);
            this.btnAnexo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(126, 35);
            this.btnAnexo.TabIndex = 0;
            this.btnAnexo.Text = "Agregar anexo";
            this.btnAnexo.UseVisualStyleBackColor = false;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(152)))), ((int)(((byte)(33)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(857, 508);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(144, 35);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblAnexos
            // 
            this.lblAnexos.Location = new System.Drawing.Point(14, 399);
            this.lblAnexos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblAnexos.Name = "lblAnexos";
            this.lblAnexos.Size = new System.Drawing.Size(54, 17);
            this.lblAnexos.TabIndex = 54;
            this.lblAnexos.Text = "Adjuntos";
            // 
            // lbAnexos
            // 
            this.lbAnexos.Location = new System.Drawing.Point(14, 424);
            this.lbAnexos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbAnexos.Name = "lbAnexos";
            this.lbAnexos.Size = new System.Drawing.Size(987, 65);
            this.lbAnexos.TabIndex = 4;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(511, 38);
            this.txtDestinatario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Properties.MaxLength = 254;
            this.txtDestinatario.Size = new System.Drawing.Size(487, 24);
            this.txtDestinatario.TabIndex = 0;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.Location = new System.Drawing.Point(511, 13);
            this.lblDestinatario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(34, 17);
            this.lblDestinatario.TabIndex = 52;
            this.lblDestinatario.Text = "Para:";
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.Location = new System.Drawing.Point(14, 301);
            this.lblDestinatarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(81, 17);
            this.lblDestinatarios.TabIndex = 50;
            this.lblDestinatarios.Text = "Con Copia a:";
            // 
            // lbDestinatarios
            // 
            this.lbDestinatarios.Location = new System.Drawing.Point(14, 326);
            this.lbDestinatarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbDestinatarios.Name = "lbDestinatarios";
            this.lbDestinatarios.Size = new System.Drawing.Size(984, 65);
            this.lbDestinatarios.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(15, 127);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(49, 17);
            this.lblMensaje.TabIndex = 48;
            this.lblMensaje.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(14, 152);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(984, 141);
            this.txtMensaje.TabIndex = 2;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(15, 95);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Properties.MaxLength = 254;
            this.txtAsunto.Size = new System.Drawing.Size(983, 24);
            this.txtAsunto.TabIndex = 1;
            // 
            // lblAsunto
            // 
            this.lblAsunto.Location = new System.Drawing.Point(15, 70);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(43, 17);
            this.lblAsunto.TabIndex = 46;
            this.lblAsunto.Text = "Asunto";
            // 
            // frmCorreoElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 573);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmCorreoElectronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo electrónico";
            this.Load += new System.EventHandler(this.frmCorreoElectronico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDestinatarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}