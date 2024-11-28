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
    partial class frmPermisos
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
            this.gridColumnObjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbObjetos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnAgregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActualizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCancelar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCancelarCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioAutorizacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnApp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcPermisos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 472);
            this.panel1.TabIndex = 0;
            // 
            // gcPermisos
            // 
            this.gcPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPermisos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPermisos.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcPermisos_EmbeddedNavigator_ButtonClick);
            this.gcPermisos.Location = new System.Drawing.Point(2, 2);
            this.gcPermisos.MainView = this.gvPermisos;
            this.gcPermisos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPermisos.Name = "gcPermisos";
            this.gcPermisos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios,
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
            this.gridColumnObjeto,
            this.gridColumnAgregar,
            this.gridColumnActualizar,
            this.gridColumnCancelar,
            this.gridColumnCancelarCFDI,
            this.gridColumnEliminar,
            this.gridColumnAutorizacion,
            this.gridColumnUsuarioAutorizacionID,
            this.gridColumnApp,
            this.gridColumnActivo,
            this.gridColumnFecha});
            this.gvPermisos.DetailHeight = 458;
            this.gvPermisos.FixedLineWidth = 3;
            this.gvPermisos.GridControl = this.gcPermisos;
            this.gvPermisos.Name = "gvPermisos";
            this.gvPermisos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPermisos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPermisos.OptionsEditForm.PopupEditFormWidth = 622;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsuarios.Name = "cbUsuarios";
            // 
            // gridColumnObjeto
            // 
            this.gridColumnObjeto.Caption = "Objeto";
            this.gridColumnObjeto.ColumnEdit = this.cbObjetos;
            this.gridColumnObjeto.FieldName = "objeto";
            this.gridColumnObjeto.MinWidth = 23;
            this.gridColumnObjeto.Name = "gridColumnObjeto";
            this.gridColumnObjeto.Visible = true;
            this.gridColumnObjeto.VisibleIndex = 1;
            this.gridColumnObjeto.Width = 56;
            // 
            // cbObjetos
            // 
            this.cbObjetos.AutoHeight = false;
            this.cbObjetos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbObjetos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Objeto", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nombre", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbObjetos.Name = "cbObjetos";
            // 
            // gridColumnAgregar
            // 
            this.gridColumnAgregar.Caption = "Agregar";
            this.gridColumnAgregar.FieldName = "agregar";
            this.gridColumnAgregar.MinWidth = 23;
            this.gridColumnAgregar.Name = "gridColumnAgregar";
            this.gridColumnAgregar.Visible = true;
            this.gridColumnAgregar.VisibleIndex = 2;
            this.gridColumnAgregar.Width = 56;
            // 
            // gridColumnActualizar
            // 
            this.gridColumnActualizar.Caption = "Actualizar";
            this.gridColumnActualizar.FieldName = "actualizar";
            this.gridColumnActualizar.MinWidth = 23;
            this.gridColumnActualizar.Name = "gridColumnActualizar";
            this.gridColumnActualizar.Visible = true;
            this.gridColumnActualizar.VisibleIndex = 3;
            this.gridColumnActualizar.Width = 56;
            // 
            // gridColumnCancelar
            // 
            this.gridColumnCancelar.Caption = "Cancelar";
            this.gridColumnCancelar.FieldName = "cancelar";
            this.gridColumnCancelar.MinWidth = 23;
            this.gridColumnCancelar.Name = "gridColumnCancelar";
            this.gridColumnCancelar.Visible = true;
            this.gridColumnCancelar.VisibleIndex = 4;
            this.gridColumnCancelar.Width = 56;
            // 
            // gridColumnCancelarCFDI
            // 
            this.gridColumnCancelarCFDI.Caption = "Cancelar CFDI";
            this.gridColumnCancelarCFDI.FieldName = "cancelar_cfdi";
            this.gridColumnCancelarCFDI.MinWidth = 23;
            this.gridColumnCancelarCFDI.Name = "gridColumnCancelarCFDI";
            this.gridColumnCancelarCFDI.Visible = true;
            this.gridColumnCancelarCFDI.VisibleIndex = 5;
            this.gridColumnCancelarCFDI.Width = 87;
            // 
            // gridColumnEliminar
            // 
            this.gridColumnEliminar.Caption = "Eliminar";
            this.gridColumnEliminar.FieldName = "eliminar";
            this.gridColumnEliminar.MinWidth = 23;
            this.gridColumnEliminar.Name = "gridColumnEliminar";
            this.gridColumnEliminar.Visible = true;
            this.gridColumnEliminar.VisibleIndex = 6;
            this.gridColumnEliminar.Width = 56;
            // 
            // gridColumnAutorizacion
            // 
            this.gridColumnAutorizacion.Caption = "Autorización";
            this.gridColumnAutorizacion.FieldName = "autorizacion";
            this.gridColumnAutorizacion.MinWidth = 23;
            this.gridColumnAutorizacion.Name = "gridColumnAutorizacion";
            this.gridColumnAutorizacion.Visible = true;
            this.gridColumnAutorizacion.VisibleIndex = 7;
            this.gridColumnAutorizacion.Width = 56;
            // 
            // gridColumnUsuarioAutorizacionID
            // 
            this.gridColumnUsuarioAutorizacionID.Caption = "Usuario autorización";
            this.gridColumnUsuarioAutorizacionID.ColumnEdit = this.cbUsuarios;
            this.gridColumnUsuarioAutorizacionID.FieldName = "usuario_autorizacion_id";
            this.gridColumnUsuarioAutorizacionID.MinWidth = 23;
            this.gridColumnUsuarioAutorizacionID.Name = "gridColumnUsuarioAutorizacionID";
            this.gridColumnUsuarioAutorizacionID.Visible = true;
            this.gridColumnUsuarioAutorizacionID.VisibleIndex = 8;
            this.gridColumnUsuarioAutorizacionID.Width = 56;
            // 
            // gridColumnApp
            // 
            this.gridColumnApp.Caption = "App";
            this.gridColumnApp.FieldName = "app";
            this.gridColumnApp.MinWidth = 23;
            this.gridColumnApp.Name = "gridColumnApp";
            this.gridColumnApp.Visible = true;
            this.gridColumnApp.VisibleIndex = 9;
            this.gridColumnApp.Width = 87;
            // 
            // gridColumnActivo
            // 
            this.gridColumnActivo.Caption = "Activo";
            this.gridColumnActivo.FieldName = "activo";
            this.gridColumnActivo.MinWidth = 23;
            this.gridColumnActivo.Name = "gridColumnActivo";
            this.gridColumnActivo.Visible = true;
            this.gridColumnActivo.VisibleIndex = 10;
            this.gridColumnActivo.Width = 54;
            // 
            // gridColumnFecha
            // 
            this.gridColumnFecha.Caption = "Fecha";
            this.gridColumnFecha.FieldName = "fecha_actualizacion";
            this.gridColumnFecha.MinWidth = 23;
            this.gridColumnFecha.Name = "gridColumnFecha";
            this.gridColumnFecha.Visible = true;
            this.gridColumnFecha.VisibleIndex = 11;
            this.gridColumnFecha.Width = 61;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}