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
using NoriSDK;


namespace NORI
{
    partial class frmConceptosAutorizaciones
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
            this.gcConceptos = new DevExpress.XtraGrid.GridControl();
            this.gvConceptos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNivelAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcConceptos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 472);
            this.panel1.TabIndex = 0;
            // 
            // gcConceptos
            // 
            this.gcConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConceptos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcConceptos.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcCorreosElectronicos_EmbeddedNavigator_ButtonClick);
            this.gcConceptos.Location = new System.Drawing.Point(2, 2);
            this.gcConceptos.MainView = this.gvConceptos;
            this.gcConceptos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcConceptos.Name = "gcConceptos";
            this.gcConceptos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios});
            this.gcConceptos.Size = new System.Drawing.Size(677, 468);
            this.gcConceptos.TabIndex = 0;
            this.gcConceptos.UseEmbeddedNavigator = true;
            this.gcConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConceptos});
            // 
            // gvConceptos
            // 
            this.gvConceptos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodigo,
            this.gridColumnOperador,
            this.gridColumnNivelAcceso,
            this.gridColumnNombre,
            this.gridColumnUsuarioAutorizacion});
            this.gvConceptos.DetailHeight = 458;
            this.gvConceptos.GridControl = this.gcConceptos;
            this.gvConceptos.Name = "gvConceptos";
            this.gvConceptos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvConceptos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvConceptos.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // gridColumnCodigo
            // 
            this.gridColumnCodigo.Caption = "Código";
            this.gridColumnCodigo.FieldName = "codigo";
            this.gridColumnCodigo.MinWidth = 23;
            this.gridColumnCodigo.Name = "gridColumnCodigo";
            this.gridColumnCodigo.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigo.Visible = true;
            this.gridColumnCodigo.VisibleIndex = 0;
            this.gridColumnCodigo.Width = 87;
            // 
            // gridColumnOperador
            // 
            this.gridColumnOperador.Caption = "Operador";
            this.gridColumnOperador.FieldName = "operador";
            this.gridColumnOperador.MinWidth = 23;
            this.gridColumnOperador.Name = "gridColumnOperador";
            this.gridColumnOperador.Visible = true;
            this.gridColumnOperador.VisibleIndex = 1;
            this.gridColumnOperador.Width = 87;
            // 
            // gridColumnNivelAcceso
            // 
            this.gridColumnNivelAcceso.Caption = "Nivel de acceso";
            this.gridColumnNivelAcceso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnNivelAcceso.FieldName = "nivel_acceso";
            this.gridColumnNivelAcceso.MinWidth = 23;
            this.gridColumnNivelAcceso.Name = "gridColumnNivelAcceso";
            this.gridColumnNivelAcceso.Visible = true;
            this.gridColumnNivelAcceso.VisibleIndex = 2;
            this.gridColumnNivelAcceso.Width = 87;
            // 
            // gridColumnNombre
            // 
            this.gridColumnNombre.Caption = "Nombre";
            this.gridColumnNombre.FieldName = "nombre";
            this.gridColumnNombre.MinWidth = 23;
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.OptionsColumn.AllowEdit = false;
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 3;
            this.gridColumnNombre.Width = 87;
            // 
            // gridColumnUsuarioAutorizacion
            // 
            this.gridColumnUsuarioAutorizacion.Caption = "Usuario autorización";
            this.gridColumnUsuarioAutorizacion.ColumnEdit = this.cbUsuarios;
            this.gridColumnUsuarioAutorizacion.FieldName = "usuario_autorizacion_id";
            this.gridColumnUsuarioAutorizacion.MinWidth = 23;
            this.gridColumnUsuarioAutorizacion.Name = "gridColumnUsuarioAutorizacion";
            this.gridColumnUsuarioAutorizacion.Visible = true;
            this.gridColumnUsuarioAutorizacion.VisibleIndex = 4;
            this.gridColumnUsuarioAutorizacion.Width = 87;
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
            // frmConceptosAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConceptosAutorizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos autorizaciónes";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            this.ResumeLayout(false);

        }
    }
}