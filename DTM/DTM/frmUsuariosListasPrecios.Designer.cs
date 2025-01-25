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


namespace DTM
{
    partial class frmUsuariosListasPrecios
    {


        protected override void Dispose(bool disposing)
        {
            try
            {
                components.Dispose();
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
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnListaPrecioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbListasPrecios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 472);
            this.panel1.TabIndex = 0;
            // 
            // gc
            // 
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gc_EmbeddedNavigator_ButtonClick);
            this.gc.Location = new System.Drawing.Point(2, 2);
            this.gc.MainView = this.gv;
            this.gc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc.Name = "gc";
            this.gc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios,
            this.cbListasPrecios});
            this.gc.Size = new System.Drawing.Size(677, 468);
            this.gc.TabIndex = 0;
            this.gc.UseEmbeddedNavigator = true;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnUsuarioID,
            this.gridColumnListaPrecioID,
            this.gridColumnFecha});
            this.gv.DetailHeight = 458;
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gv.OptionsEditForm.PopupEditFormWidth = 933;
            this.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsuarios.Name = "cbUsuarios";
            // 
            // gridColumnListaPrecioID
            // 
            this.gridColumnListaPrecioID.Caption = "Lista precio";
            this.gridColumnListaPrecioID.ColumnEdit = this.cbListasPrecios;
            this.gridColumnListaPrecioID.FieldName = "lista_precio_id";
            this.gridColumnListaPrecioID.MinWidth = 23;
            this.gridColumnListaPrecioID.Name = "gridColumnListaPrecioID";
            this.gridColumnListaPrecioID.Visible = true;
            this.gridColumnListaPrecioID.VisibleIndex = 1;
            this.gridColumnListaPrecioID.Width = 87;
            // 
            // cbListasPrecios
            // 
            this.cbListasPrecios.AutoHeight = false;
            this.cbListasPrecios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListasPrecios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbListasPrecios.Name = "cbListasPrecios";
            // 
            // gridColumnFecha
            // 
            this.gridColumnFecha.Caption = "Fecha";
            this.gridColumnFecha.FieldName = "fecha_actualizacion";
            this.gridColumnFecha.MinWidth = 23;
            this.gridColumnFecha.Name = "gridColumnFecha";
            this.gridColumnFecha.Visible = true;
            this.gridColumnFecha.VisibleIndex = 2;
            this.gridColumnFecha.Width = 87;
            // 
            // frmUsuariosListasPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuariosListasPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios - Listas precios";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListasPrecios)).EndInit();
            this.ResumeLayout(false);

        }
    }
}