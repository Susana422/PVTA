using DevExpress.Utils.Behaviors;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SDK;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmOrdenDescuentosEspeciales : XtraForm
    {
        private IContainer components = null;

        private GridControl gcDescuentosEspeciales;

        private GridView gvDescuentosEspeciales;

        private GridColumn gridColumnId;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnTipo;

        private GridColumn gridColumnVIP;

        private GridColumn gridColumnAcumulable;

        private BehaviorManager behaviorManager1;

        private DragDropEvents dragDropEvents1;

        public frmOrdenDescuentosEspeciales()
        {
            InitializeComponent();
            gcDescuentosEspeciales.DataSource = Utilidades.EjecutarQuery("select * from descuentos_especiales where activo = 1 order by orden");
            HandleBehaviorDragDropEvents();
        }

        public void HandleBehaviorDragDropEvents()
        {
            ((ColumnViewOptionsBehavior)gvDescuentosEspeciales.OptionsBehavior).Editable = false;
        }

        private void Behavior_DragOver(object sender, DragOverEventArgs e)
        {
            //IL_000a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0024: Unknown result type (might be due to invalid IL or missing references)
            DragOverGridEventArgs dragOverGridEventArgs = DragOverGridEventArgs.GetDragOverGridEventArgs(e);
            ((DragOverEventArgsBase)e).InsertType = ((DragOverGridEventArgsBase)dragOverGridEventArgs).InsertType;
            e.InsertIndicatorLocation = dragOverGridEventArgs.InsertIndicatorLocation;
            ((DXDragEventArgs)e).Action = ((DragGridEventArgs)dragOverGridEventArgs).Action;
            Cursor.Current = ((DragGridEventArgs)dragOverGridEventArgs).Cursor;
            ((DragGridEventArgs)dragOverGridEventArgs).Handled = true;
        }

        private void Behavior_DragDrop(object sender, DragDropEventArgs e)
        {
            //IL_001a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0020: Invalid comparison between Unknown and I4
            //IL_00c9: Unknown result type (might be due to invalid IL or missing references)
            //IL_00ce: Unknown result type (might be due to invalid IL or missing references)
            //IL_00d0: Unknown result type (might be due to invalid IL or missing references)
            //IL_00d2: Unknown result type (might be due to invalid IL or missing references)
            //IL_00d4: Unknown result type (might be due to invalid IL or missing references)
            //IL_00d7: Invalid comparison between Unknown and I4
            //IL_00de: Unknown result type (might be due to invalid IL or missing references)
            //IL_00e1: Invalid comparison between Unknown and I4
            object target = ((DXDragEventArgs)e).Target;
            GridView val = (GridView)((target is GridView) ? target : null);
            object source = ((DXDragEventArgs)e).Source;
            GridView val2 = (GridView)((source is GridView) ? source : null);
            if ((int)((DXDragEventArgs)e).Action == 5 || val != val2)
            {
                return;
            }
            DataTable dataTable = ((BaseView)val2).GridControl.DataSource as DataTable;
            Point point = ((Control)(object)((BaseView)val).GridControl).PointToClient(Cursor.Position);
            GridHitInfo val3 = val.CalcHitInfo(point);
            int[] data = ((DXDragEventArgs)e).GetData<int[]>();
            int rowHandle = val3.RowHandle;
            int dataSourceRowIndex = ((ColumnView)val).GetDataSourceRowIndex(rowHandle);
            List<DataRow> list = new List<DataRow>();
            int[] array = data;
            foreach (int num in array)
            {
                int dataSourceRowIndex2 = ((ColumnView)val2).GetDataSourceRowIndex(num);
                DataRow item = dataTable.Rows[dataSourceRowIndex2];
                list.Add(item);
            }
            InsertType insertType = ((DragOverEventArgsBase)e).InsertType;
            InsertType val4 = insertType;
            int num2;
            if ((int)val4 != 2)
            {
                if ((int)val4 == 3)
                {
                    num2 = ((dataSourceRowIndex > data[data.Length - 1]) ? (dataSourceRowIndex - 1) : dataSourceRowIndex);
                    for (int num3 = list.Count - 1; num3 >= 0; num3--)
                    {
                        DataRow dataRow = list[num3];
                        DataRow dataRow2 = dataTable.NewRow();
                        dataRow2.ItemArray = dataRow.ItemArray;
                        dataTable.Rows.Remove(dataRow);
                        dataTable.Rows.InsertAt(dataRow2, num2);
                    }
                }
                else
                {
                    num2 = -1;
                }
            }
            else
            {
                num2 = ((dataSourceRowIndex < data[0]) ? (dataSourceRowIndex + 1) : dataSourceRowIndex);
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow3 = list[j];
                    DataRow dataRow4 = dataTable.NewRow();
                    dataRow4.ItemArray = dataRow3.ItemArray;
                    dataTable.Rows.Remove(dataRow3);
                    dataTable.Rows.InsertAt(dataRow4, num2);
                }
            }
            int rowHandle2 = ((ColumnView)val).GetRowHandle(num2);
            int num4 = int.Parse(((ColumnView)gvDescuentosEspeciales).GetRowCellValue(num2, "id").ToString());
            Utilidades.EjecutarQuery($"update descuentos_especiales set orden = {rowHandle2 + 1} where id = {num4}");
            ((ColumnView)val).FocusedRowHandle = rowHandle2;
            ((ColumnView)val).SelectRow(((ColumnView)val).FocusedRowHandle);
        }

    }
}
