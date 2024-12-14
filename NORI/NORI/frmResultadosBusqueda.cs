using DevExpress.Utils.Menu;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmResultadosBusqueda : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private PanelControl panelControl1;

        private GridControl gcResultados;

        private GridView gvResultados;

        public int id { get; internal set; }

        public int fila { get; internal set; }

        public List<int> ids { get; internal set; }

        public List<int> filas { get; internal set; }

        public frmResultadosBusqueda(object resultados, bool seleccion_multiple = false)
        {
            InitializeComponent();
            this.MetodoDinamico();
            try
            {
                ids = new List<int>();
                filas = new List<int>();
                if (seleccion_multiple)
                {
                    ((ColumnViewOptionsSelection)gvResultados.OptionsSelection).MultiSelect = true;
                    gvResultados.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)0;
                }
                gcResultados.DataSource = resultados;
                if (((ColumnView)gvResultados).Columns[0].FieldName != "ID")
                {
                    ((ColumnView)gvResultados).Columns[0].Visible = false;
                }
                gvResultados.BestFitColumns();
            }
            catch
            {
            }
        }

        private void gvResultados_DoubleClick(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void gvResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Cerrar();
            }
        }

        private void Cerrar()
        {
            try
            {
                if (((ColumnView)gvResultados).IsMultiSelect)
                {
                    int[] selectedRows = ((ColumnView)gvResultados).GetSelectedRows();
                    foreach (int num in selectedRows)
                    {
                        DataRow dataRow = ((ColumnView)gvResultados).GetDataRow(num);
                        ids.Add((int)dataRow[0]);
                        filas.Add(num);
                    }
                }
                else
                {
                    DataRow dataRow2 = ((ColumnView)gvResultados).GetDataRow(((ColumnView)gvResultados).GetSelectedRows()[0]);
                    fila = ((ColumnView)gvResultados).GetSelectedRows()[0];
                    id = int.Parse(dataRow2[0].ToString());
                }
                ((Form)this).DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frmResultadosBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ((Form)this).Close();
            }
        }
    }

}
