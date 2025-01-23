using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Extensions;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SDK;

namespace DTM
{
    partial class frmOrdenDescuentosEspeciales
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
            //IL_000d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0017: Expected O, but got Unknown
            //IL_0018: Unknown result type (might be due to invalid IL or missing references)
            //IL_0022: Expected O, but got Unknown
            //IL_0023: Unknown result type (might be due to invalid IL or missing references)
            //IL_002d: Expected O, but got Unknown
            //IL_002e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0038: Expected O, but got Unknown
            //IL_0039: Unknown result type (might be due to invalid IL or missing references)
            //IL_0043: Expected O, but got Unknown
            //IL_0044: Unknown result type (might be due to invalid IL or missing references)
            //IL_004e: Expected O, but got Unknown
            //IL_004f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0059: Expected O, but got Unknown
            //IL_0060: Unknown result type (might be due to invalid IL or missing references)
            //IL_006a: Expected O, but got Unknown
            //IL_0071: Unknown result type (might be due to invalid IL or missing references)
            //IL_007b: Expected O, but got Unknown
            //IL_03e6: Unknown result type (might be due to invalid IL or missing references)
            //IL_03f0: Expected O, but got Unknown
            //IL_03fe: Unknown result type (might be due to invalid IL or missing references)
            //IL_0408: Expected O, but got Unknown
            components = new Container();
            gcDescuentosEspeciales = new GridControl();
            gvDescuentosEspeciales = new GridView();
            gridColumnId = new GridColumn();
            gridColumnNombre = new GridColumn();
            gridColumnTipo = new GridColumn();
            gridColumnVIP = new GridColumn();
            gridColumnAcumulable = new GridColumn();
            behaviorManager1 = new BehaviorManager(components);
            dragDropEvents1 = new DragDropEvents(components);
            ((ISupportInitialize)gcDescuentosEspeciales).BeginInit();
            ((ISupportInitialize)gvDescuentosEspeciales).BeginInit();
            ((ISupportInitialize)behaviorManager1).BeginInit();
            ((XtraForm)this).SuspendLayout();
            ((Control)(object)gcDescuentosEspeciales).Dock = DockStyle.Fill;
            ((Control)(object)gcDescuentosEspeciales).Location = new Point(0, 0);
            gcDescuentosEspeciales.MainView = (BaseView)(object)gvDescuentosEspeciales;
            ((Control)(object)gcDescuentosEspeciales).Name = "gcDescuentosEspeciales";
            ((Control)(object)gcDescuentosEspeciales).Size = new Size(966, 565);
            ((Control)(object)gcDescuentosEspeciales).TabIndex = 0;
            gcDescuentosEspeciales.ViewCollection.AddRange((BaseView[])(object)new BaseView[1] { (BaseView)gvDescuentosEspeciales });
            behaviorManager1.SetBehaviors((IComponent)gvDescuentosEspeciales, (Behavior[])(object)new Behavior[1] { (Behavior)DragDropBehavior.Create(typeof(ColumnViewDragDropSource), true, true, true, true, dragDropEvents1) });
            ((ColumnView)gvDescuentosEspeciales).Columns.AddRange((GridColumn[])(object)new GridColumn[5] { gridColumnId, gridColumnNombre, gridColumnTipo, gridColumnVIP, gridColumnAcumulable });
            ((BaseView)gvDescuentosEspeciales).GridControl = gcDescuentosEspeciales;
            ((BaseView)gvDescuentosEspeciales).Name = "gvDescuentosEspeciales";
            gridColumnId.Caption = "Id";
            gridColumnId.FieldName = "id";
            gridColumnId.MinWidth = 30;
            gridColumnId.Name = "gridColumnId";
            gridColumnId.Visible = true;
            gridColumnId.VisibleIndex = 0;
            gridColumnId.Width = 112;
            gridColumnNombre.Caption = "Nombre";
            gridColumnNombre.FieldName = "nombre";
            gridColumnNombre.MinWidth = 30;
            gridColumnNombre.Name = "gridColumnNombre";
            gridColumnNombre.Visible = true;
            gridColumnNombre.VisibleIndex = 1;
            gridColumnNombre.Width = 112;
            gridColumnTipo.Caption = "Tipo";
            gridColumnTipo.FieldName = "tipo";
            gridColumnTipo.MinWidth = 30;
            gridColumnTipo.Name = "gridColumnTipo";
            gridColumnTipo.Visible = true;
            gridColumnTipo.VisibleIndex = 2;
            gridColumnTipo.Width = 112;
            gridColumnVIP.Caption = "VIP";
            gridColumnVIP.FieldName = "vip";
            gridColumnVIP.MinWidth = 30;
            gridColumnVIP.Name = "gridColumnVIP";
            gridColumnVIP.Visible = true;
            gridColumnVIP.VisibleIndex = 3;
            gridColumnVIP.Width = 112;
            gridColumnAcumulable.Caption = "Acumulable";
            gridColumnAcumulable.FieldName = "acumulable";
            gridColumnAcumulable.MinWidth = 30;
            gridColumnAcumulable.Name = "gridColumnAcumulable";
            gridColumnAcumulable.Visible = true;
            gridColumnAcumulable.VisibleIndex = 4;
            gridColumnAcumulable.Width = 112;
            dragDropEvents1.DragOver += new DragOverEventHandler(Behavior_DragOver);
            dragDropEvents1.DragDrop += new DragDropEventHandler(Behavior_DragDrop);
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(9f, 19f);
            ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
            ((Form)this).ClientSize = new Size(966, 565);
            ((Control)this).Controls.Add((Control)(object)gcDescuentosEspeciales);
            ((XtraForm)this).IconOptions.ShowIcon = false;
            ((Control)this).Name = "frmOrdenDescuentosEspeciales";
            ((Form)this).StartPosition = FormStartPosition.CenterScreen;
            ((Control)(object)this).Text = "Jerarquía descuentos";
            ((ISupportInitialize)gcDescuentosEspeciales).EndInit();
            ((ISupportInitialize)gvDescuentosEspeciales).EndInit();
            ((ISupportInitialize)behaviorManager1).EndInit();
            ((XtraForm)this).ResumeLayout(false);
        }
    }
}