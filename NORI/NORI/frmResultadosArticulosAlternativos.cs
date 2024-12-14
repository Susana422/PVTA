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
using NoriSDK;

namespace NORI
{
    public partial class frmResultadosArticulosAlternativos : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private PanelControl panelControl1;

        private GridControl gcResultados;

        private GridView gvResultados;

        private LabelControl lblNombre;

        private PictureBox pbImagen;

        private LabelControl lblComentario;

        public int id { get; internal set; }

        public int fila { get; internal set; }

        public List<int> ids { get; internal set; }

        public List<int> filas { get; internal set; }

        public frmResultadosArticulosAlternativos(object resultados, bool seleccion_multiple = false)
        {
            try
            {
                InitializeComponent();
                this.MetodoDinamico();
                ids = new List<int>();
                filas = new List<int>();
                if (seleccion_multiple)
                {
                    ((ColumnViewOptionsSelection)gvResultados.OptionsSelection).MultiSelect = true;
                    gvResultados.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)0;
                }
                gcResultados.DataSource = resultados;
                ((ColumnView)gvResultados).Columns[0].Visible = false;
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
                        int dataSourceRowIndex = ((ColumnView)gvResultados).GetDataSourceRowIndex(num);
                        ids.Add(dataSourceRowIndex);
                        filas.Add(dataSourceRowIndex);
                    }
                }
                else
                {
                    DataRow dataRow = ((ColumnView)gvResultados).GetDataRow(((ColumnView)gvResultados).GetSelectedRows()[0]);
                    fila = ((ColumnView)gvResultados).GetSelectedRows()[0];
                    id = (int)dataRow[0];
                }
                ((Form)this).DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void gvResultados_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                ((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
                {
                    try
                    {
                        if (((BaseView)gvResultados).RowCount > 0)
                        {
                            DataRow dataRow = ((ColumnView)gvResultados).GetDataRow(((ColumnView)gvResultados).GetSelectedRows()[0]);
                            int num = int.Parse(dataRow[0].ToString());
                            pbImagen.LoadImage(Articulo.ObtenerImagen(id));
                            ((Control)(object)lblComentario).Text = Articulo.ObtenerComentario(id);
                            ((Control)(object)lblNombre).Text = dataRow["nombre"].ToString();
                        }
                    }
                    catch
                    {
                    }
                });
            }
            catch
            {
            }
        }

        private void frmResultadosBusquedaArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ((Form)this).Close();
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

       
    }

}
