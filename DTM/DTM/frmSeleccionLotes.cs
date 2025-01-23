using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace DTM
{
    public partial class frmSeleccionLotes : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private PanelControl panelControl1;

        private GridControl gcResultados;

        private GridView gvResultados;

        private LabelControl lblCantidadSeleccionada;

        private LabelControl lblCantidadRequerida;

        private LabelControl lblArticulo;

        private GridColumn gridColumnId;

        private GridColumn gridColumnLote;

        private GridColumn gridColumnDisponible;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnFechaCaducidad;

        public List<Lote> lotes { get; internal set; }

        public Documento.Partida partida { get; set; }

        public frmSeleccionLotes(Documento.Partida _partida, bool seleccion_multiple = false)
        {
            InitializeComponent();
            this.MetodoDinamico();
            try
            {
                partida = _partida;
                if (seleccion_multiple)
                {
                    ((ColumnViewOptionsSelection)gvResultados.OptionsSelection).MultiSelect = true;
                    gvResultados.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)0;
                }
                ((Control)(object)lblArticulo).Text = partida.nombre;
                ((Control)(object)lblCantidadRequerida).Text = $"Cantidad requerida: {partida.cantidad}";
                lotes = (from x in Lote.Lotes()
                         where x.articulo_id == partida.articulo_id && x.almacen_id == partida.almacen_id && x.disponible > 0m
                         select x).ToList();
                lotes.ForEach(delegate (Lote x)
                {
                    x.cantidad = 0m;
                });
                gcResultados.DataSource = lotes;
                if (((ColumnView)gvResultados).Columns[0].FieldName != "Id")
                {
                    ((ColumnView)gvResultados).Columns[0].Visible = false;
                }
                gvResultados.BestFitColumns();
            }
            catch
            {
            }
        }

        private void Cerrar()
        {
            try
            {
                ((Form)this).DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvResultados_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                decimal num = lotes.Sum((Lote x) => x.cantidad);
                ((Control)(object)lblCantidadSeleccionada).Text = $"Cantidad seleccionada: {num}";
                if (num == partida.cantidad)
                {
                    MessageBox.Show("Se completó la selección de lotes");
                    Cerrar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error por favor intente más tarde");
            }
        }

    }
}
