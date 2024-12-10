using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace NORI
{
    partial class frmCorreosElectronicos
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.gcCorreosElectronicos = new DevExpress.XtraGrid.GridControl();
            this.gvCorreosElectronicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnServidor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPuerto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnContraseña = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRemitente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCorreosElectronicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorreosElectronicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcCorreosElectronicos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 472);
            this.panel1.TabIndex = 0;
            // 
            // gcCorreosElectronicos
            // 
            this.gcCorreosElectronicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCorreosElectronicos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCorreosElectronicos.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcCorreosElectronicos_EmbeddedNavigator_ButtonClick);
            this.gcCorreosElectronicos.Location = new System.Drawing.Point(2, 2);
            this.gcCorreosElectronicos.MainView = this.gvCorreosElectronicos;
            this.gcCorreosElectronicos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCorreosElectronicos.Name = "gcCorreosElectronicos";
            this.gcCorreosElectronicos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios});
            this.gcCorreosElectronicos.Size = new System.Drawing.Size(677, 468);
            this.gcCorreosElectronicos.TabIndex = 0;
            this.gcCorreosElectronicos.UseEmbeddedNavigator = true;
            this.gcCorreosElectronicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCorreosElectronicos});
            // 
            // gvCorreosElectronicos
            // 
            this.gvCorreosElectronicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnUsuarioID,
            this.gridColumnServidor,
            this.gridColumnPuerto,
            this.gridColumnSSL,
            this.gridColumnUsuario,
            this.gridColumnContraseña,
            this.gridColumnRemitente,
            this.gridColumnAsunto,
            this.gridColumnMensaje,
            this.gridColumnActivo});
            this.gvCorreosElectronicos.DetailHeight = 458;
            this.gvCorreosElectronicos.FixedLineWidth = 3;
            this.gvCorreosElectronicos.GridControl = this.gcCorreosElectronicos;
            this.gvCorreosElectronicos.Name = "gvCorreosElectronicos";
            this.gvCorreosElectronicos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCorreosElectronicos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCorreosElectronicos.OptionsEditForm.PopupEditFormWidth = 622;
            this.gvCorreosElectronicos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.MinWidth = 23;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 87;
            // 
            // gridColumnUsuarioID
            // 
            this.gridColumnUsuarioID.Caption = "Usuario";
            this.gridColumnUsuarioID.ColumnEdit = this.cbUsuarios;
            this.gridColumnUsuarioID.FieldName = "usuario_id";
            this.gridColumnUsuarioID.MinWidth = 23;
            this.gridColumnUsuarioID.Name = "gridColumnUsuarioID";
            this.gridColumnUsuarioID.Visible = true;
            this.gridColumnUsuarioID.VisibleIndex = 0;
            this.gridColumnUsuarioID.Width = 87;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.AutoHeight = false;
            this.cbUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsuarios.Name = "cbUsuarios";
            // 
            // gridColumnServidor
            // 
            this.gridColumnServidor.Caption = "Servidor";
            this.gridColumnServidor.FieldName = "servidor";
            this.gridColumnServidor.MinWidth = 23;
            this.gridColumnServidor.Name = "gridColumnServidor";
            this.gridColumnServidor.Visible = true;
            this.gridColumnServidor.VisibleIndex = 1;
            this.gridColumnServidor.Width = 87;
            // 
            // gridColumnPuerto
            // 
            this.gridColumnPuerto.Caption = "Puerto";
            this.gridColumnPuerto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPuerto.FieldName = "puerto";
            this.gridColumnPuerto.MinWidth = 23;
            this.gridColumnPuerto.Name = "gridColumnPuerto";
            this.gridColumnPuerto.Visible = true;
            this.gridColumnPuerto.VisibleIndex = 2;
            this.gridColumnPuerto.Width = 87;
            // 
            // gridColumnSSL
            // 
            this.gridColumnSSL.Caption = "SSL";
            this.gridColumnSSL.FieldName = "ssl";
            this.gridColumnSSL.MinWidth = 23;
            this.gridColumnSSL.Name = "gridColumnSSL";
            this.gridColumnSSL.Visible = true;
            this.gridColumnSSL.VisibleIndex = 3;
            this.gridColumnSSL.Width = 87;
            // 
            // gridColumnUsuario
            // 
            this.gridColumnUsuario.Caption = "Correo electrónico";
            this.gridColumnUsuario.FieldName = "usuario";
            this.gridColumnUsuario.MinWidth = 23;
            this.gridColumnUsuario.Name = "gridColumnUsuario";
            this.gridColumnUsuario.Visible = true;
            this.gridColumnUsuario.VisibleIndex = 4;
            this.gridColumnUsuario.Width = 87;
            // 
            // gridColumnContraseña
            // 
            this.gridColumnContraseña.Caption = "Contraseña";
            this.gridColumnContraseña.FieldName = "contraseña";
            this.gridColumnContraseña.MinWidth = 23;
            this.gridColumnContraseña.Name = "gridColumnContraseña";
            this.gridColumnContraseña.Visible = true;
            this.gridColumnContraseña.VisibleIndex = 5;
            this.gridColumnContraseña.Width = 87;
            // 
            // gridColumnRemitente
            // 
            this.gridColumnRemitente.Caption = "Remitente";
            this.gridColumnRemitente.FieldName = "remitente";
            this.gridColumnRemitente.MinWidth = 23;
            this.gridColumnRemitente.Name = "gridColumnRemitente";
            this.gridColumnRemitente.Visible = true;
            this.gridColumnRemitente.VisibleIndex = 6;
            this.gridColumnRemitente.Width = 87;
            // 
            // gridColumnAsunto
            // 
            this.gridColumnAsunto.Caption = "Asunto";
            this.gridColumnAsunto.FieldName = "asunto";
            this.gridColumnAsunto.MinWidth = 23;
            this.gridColumnAsunto.Name = "gridColumnAsunto";
            this.gridColumnAsunto.Visible = true;
            this.gridColumnAsunto.VisibleIndex = 7;
            this.gridColumnAsunto.Width = 87;
            // 
            // gridColumnMensaje
            // 
            this.gridColumnMensaje.Caption = "Mensaje";
            this.gridColumnMensaje.FieldName = "mensaje";
            this.gridColumnMensaje.MinWidth = 23;
            this.gridColumnMensaje.Name = "gridColumnMensaje";
            this.gridColumnMensaje.Visible = true;
            this.gridColumnMensaje.VisibleIndex = 8;
            this.gridColumnMensaje.Width = 87;
            // 
            // gridColumnActivo
            // 
            this.gridColumnActivo.Caption = "Activo";
            this.gridColumnActivo.FieldName = "activo";
            this.gridColumnActivo.MinWidth = 23;
            this.gridColumnActivo.Name = "gridColumnActivo";
            this.gridColumnActivo.Visible = true;
            this.gridColumnActivo.VisibleIndex = 9;
            this.gridColumnActivo.Width = 87;
            // 
            // frmCorreosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCorreosElectronicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correos electrónicos";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCorreosElectronicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorreosElectronicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            this.ResumeLayout(false);

        }
    }
}