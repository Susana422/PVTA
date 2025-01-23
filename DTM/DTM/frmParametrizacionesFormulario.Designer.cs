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

namespace DTM
{
    partial class frmParametrizacionesFormulario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrizacionesFormulario));
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            this.xrDesignBarManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
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
            this.standardReportDesigner1 = new DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner();
            this.reportDesigner1 = new DevExpress.XtraReports.UserDesigner.XRDesignMdiController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDesigner1)).BeginInit();
            this.SuspendLayout();
            // 
            // xrDesignBarManager1
            // 
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlTop);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlBottom);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlLeft);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlRight);
            this.xrDesignBarManager1.FontNameBox = this.recentlyUsedItemsComboBox1;
            this.xrDesignBarManager1.FontNameEdit = null;
            this.xrDesignBarManager1.FontSizeBox = this.designRepositoryItemComboBox1;
            this.xrDesignBarManager1.FontSizeEdit = null;
            this.xrDesignBarManager1.Form = this;
            this.xrDesignBarManager1.FormattingToolbar = null;
            this.xrDesignBarManager1.HintStaticItem = null;
            this.xrDesignBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignBarManager1.ImageStream")));
            this.xrDesignBarManager1.LayoutToolbar = null;
            this.xrDesignBarManager1.MaxItemId = 76;
            this.xrDesignBarManager1.Toolbar = null;
            this.xrDesignBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            this.xrDesignBarManager1.Updates.AddRange(new string[] {
            "Toolbox"});
            this.xrDesignBarManager1.ZoomItem = null;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.xrDesignBarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1060, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 685);
            this.barDockControlBottom.Manager = this.xrDesignBarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1060, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.xrDesignBarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 685);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1060, 0);
            this.barDockControlRight.Manager = this.xrDesignBarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 685);
            // 
            // recentlyUsedItemsComboBox1
            // 
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = true;
            this.recentlyUsedItemsComboBox1.AutoHeight = false;
            this.recentlyUsedItemsComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1";
            // 
            // designRepositoryItemComboBox1
            // 
            this.designRepositoryItemComboBox1.AutoHeight = false;
            this.designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.gcPermisos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 685);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(866, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(180, 46);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Buscar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(765, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Formulario";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(456, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Roles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(680, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 46);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(456, 54);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Size = new System.Drawing.Size(281, 24);
            this.lookUpEdit2.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(765, 54);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new System.Drawing.Size(281, 24);
            this.lookUpEdit1.TabIndex = 1;
            // 
            // gcPermisos
            // 
            this.gcPermisos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPermisos.Location = new System.Drawing.Point(14, 149);
            this.gcPermisos.MainView = this.gvPermisos;
            this.gcPermisos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPermisos.Name = "gcPermisos";
            this.gcPermisos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbUsuarios,
            this.cbControles,
            this.cbRoles,
            this.cbObjetos});
            this.gcPermisos.Size = new System.Drawing.Size(1032, 523);
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
            this.gvPermisos.OptionsEditForm.PopupEditFormWidth = 1066;
            this.gvPermisos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.MinWidth = 26;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 99;
            // 
            // gridColumnUsuarioID
            // 
            this.gridColumnUsuarioID.Caption = "Usuario";
            this.gridColumnUsuarioID.ColumnEdit = this.cbUsuarios;
            this.gridColumnUsuarioID.FieldName = "usuario_id";
            this.gridColumnUsuarioID.MinWidth = 26;
            this.gridColumnUsuarioID.Name = "gridColumnUsuarioID";
            this.gridColumnUsuarioID.Visible = true;
            this.gridColumnUsuarioID.VisibleIndex = 0;
            this.gridColumnUsuarioID.Width = 64;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.AutoHeight = false;
            this.cbUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUsuarios.Name = "cbUsuarios";
            // 
            // gridColumnRol
            // 
            this.gridColumnRol.Caption = "Rol";
            this.gridColumnRol.ColumnEdit = this.cbRoles;
            this.gridColumnRol.FieldName = "rol";
            this.gridColumnRol.MinWidth = 26;
            this.gridColumnRol.Name = "gridColumnRol";
            this.gridColumnRol.Visible = true;
            this.gridColumnRol.VisibleIndex = 1;
            this.gridColumnRol.Width = 66;
            // 
            // cbRoles
            // 
            this.cbRoles.AutoHeight = false;
            this.cbRoles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbRoles.Name = "cbRoles";
            // 
            // gridColumnControl
            // 
            this.gridColumnControl.Caption = "Control";
            this.gridColumnControl.ColumnEdit = this.cbControles;
            this.gridColumnControl.FieldName = "control";
            this.gridColumnControl.MinWidth = 26;
            this.gridColumnControl.Name = "gridColumnControl";
            this.gridColumnControl.Visible = true;
            this.gridColumnControl.VisibleIndex = 2;
            this.gridColumnControl.Width = 64;
            // 
            // cbControles
            // 
            this.cbControles.AutoHeight = false;
            this.cbControles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControles.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Control", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nombre", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbControles.Name = "cbControles";
            // 
            // gridColumnOculto
            // 
            this.gridColumnOculto.Caption = "Oculto";
            this.gridColumnOculto.FieldName = "oculto";
            this.gridColumnOculto.MinWidth = 26;
            this.gridColumnOculto.Name = "gridColumnOculto";
            this.gridColumnOculto.Visible = true;
            this.gridColumnOculto.VisibleIndex = 3;
            this.gridColumnOculto.Width = 99;
            // 
            // gridColumnDesactivado
            // 
            this.gridColumnDesactivado.Caption = "Desactivado";
            this.gridColumnDesactivado.FieldName = "desactivado";
            this.gridColumnDesactivado.MinWidth = 26;
            this.gridColumnDesactivado.Name = "gridColumnDesactivado";
            this.gridColumnDesactivado.Visible = true;
            this.gridColumnDesactivado.VisibleIndex = 4;
            this.gridColumnDesactivado.Width = 63;
            // 
            // cbObjetos
            // 
            this.cbObjetos.AutoHeight = false;
            this.cbObjetos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbObjetos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbObjetos.Name = "cbObjetos";
            // 
            // reportDesigner1
            // 
            this.reportDesigner1.ContainerControl = null;
            xrDesignPanelListener1.DesignControl = this.xrDesignBarManager1;
            this.reportDesigner1.DesignPanelListeners.AddRange(new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener[] {
            xrDesignPanelListener1});
            this.reportDesigner1.Form = this;
            // 
            // frmParametrizacionesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmParametrizacionesFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrizaciónes de formulario";
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbObjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDesigner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SimpleButton btnGuardar;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner standardReportDesigner1;
        private DevExpress.XtraReports.UserDesigner.XRDesignMdiController reportDesigner1;
        private DevExpress.XtraReports.UserDesigner.XRDesignBarManager xrDesignBarManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private LookUpEdit lookUpEdit2;
        private LookUpEdit lookUpEdit1;
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private SimpleButton simpleButton1;
    }
}