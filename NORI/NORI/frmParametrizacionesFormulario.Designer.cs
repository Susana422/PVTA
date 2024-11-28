using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
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
    partial class frmParametrizacionesFormulario
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
            this.gcPermisos = new DevExpress.XtraGrid.GridControl();
            this.gvPermisos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbRoles = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbControles = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnOculto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesactivado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbObjetos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcPermisos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 472);
            this.panel1.TabIndex = 0;
            // 
            // gcPermisos
            // 
            this.gcPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPermisos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPermisos.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcPermisos_EmbeddedNavigator_ButtonClick);
            this.gcPermisos.Location = new System.Drawing.Point(2, 2);
            this.gcPermisos.MainView = this.gvPermisos;
            this.gcPermisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPermisos.Name = "gcPermisos";
            this.gcPermisos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios,
            this.cbControles,
            this.cbRoles,
            this.cbObjetos});
            this.gcPermisos.Size = new System.Drawing.Size(677, 468);
            this.gcPermisos.TabIndex = 0;
            this.gcPermisos.UseEmbeddedNavigator = true;
            this.gcPermisos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPermisos});
            // 
            // gvPermisos
            // 
            this.gvPermisos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnUsuarioID,
            this.gridColumnRol,
            this.gridColumnControl,
            this.gridColumnOculto,
            this.gridColumnDesactivado});
            this.gvPermisos.DetailHeight = 458;
            this.gvPermisos.GridControl = this.gcPermisos;
            this.gvPermisos.Name = "gvPermisos";
            this.gvPermisos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPermisos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPermisos.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvPermisos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvPermisos.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvPermisos_InitNewRow);
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
            this.gridColumnUsuarioID.Width = 56;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.AutoHeight = false;
            this.cbUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsuarios.Name = "cbUsuarios";
            // 
            // gridColumnRol
            // 
            this.gridColumnRol.Caption = "Rol";
            this.gridColumnRol.ColumnEdit = this.cbRoles;
            this.gridColumnRol.FieldName = "rol";
            this.gridColumnRol.MinWidth = 23;
            this.gridColumnRol.Name = "gridColumnRol";
            this.gridColumnRol.Visible = true;
            this.gridColumnRol.VisibleIndex = 1;
            this.gridColumnRol.Width = 58;
            // 
            // cbRoles
            // 
            this.cbRoles.AutoHeight = false;
            this.cbRoles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRoles.Name = "cbRoles";
            // 
            // gridColumnControl
            // 
            this.gridColumnControl.Caption = "Control";
            this.gridColumnControl.ColumnEdit = this.cbControles;
            this.gridColumnControl.FieldName = "control";
            this.gridColumnControl.MinWidth = 23;
            this.gridColumnControl.Name = "gridColumnControl";
            this.gridColumnControl.Visible = true;
            this.gridColumnControl.VisibleIndex = 2;
            this.gridColumnControl.Width = 56;
            // 
            // cbControles
            // 
            this.cbControles.AutoHeight = false;
            this.cbControles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControles.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Control", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbControles.Name = "cbControles";
            // 
            // gridColumnOculto
            // 
            this.gridColumnOculto.Caption = "Oculto";
            this.gridColumnOculto.FieldName = "oculto";
            this.gridColumnOculto.MinWidth = 23;
            this.gridColumnOculto.Name = "gridColumnOculto";
            this.gridColumnOculto.Visible = true;
            this.gridColumnOculto.VisibleIndex = 3;
            this.gridColumnOculto.Width = 87;
            // 
            // gridColumnDesactivado
            // 
            this.gridColumnDesactivado.Caption = "Desactivado";
            this.gridColumnDesactivado.FieldName = "desactivado";
            this.gridColumnDesactivado.MinWidth = 23;
            this.gridColumnDesactivado.Name = "gridColumnDesactivado";
            this.gridColumnDesactivado.Visible = true;
            this.gridColumnDesactivado.VisibleIndex = 4;
            this.gridColumnDesactivado.Width = 55;
            // 
            // cbObjetos
            // 
            this.cbObjetos.AutoHeight = false;
            this.cbObjetos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbObjetos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbObjetos.Name = "cbObjetos";
            // 
            // frmParametrizacionesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmParametrizacionesFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrizaciónes de formulario";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}