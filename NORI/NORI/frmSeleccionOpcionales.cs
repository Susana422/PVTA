using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using NoriSDK;
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
    public partial class frmSeleccionOpcionales : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private PanelControl panelControl1;

        private GridControl gcResultados;

        private GridView gvResultados;

        private LabelControl lblMinimo;

        private LabelControl lblMaximo;

        private LabelControl lblArticulo;

        private GridColumn gridColumnId;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnArticulo;

        private GridColumn gridColumnArticuloId;

        private RepositoryItemLookUpEdit cbArticulos;

        private GridColumn gridColumnMinimo;

        private GridColumn gridColumnMaximo;

        private GridColumn gridColumnOpcional;

        private LabelControl lblSeleccionados;

        public List<Paquete.Opcion> opciones { get; internal set; }

        public Paquete paquete { get; set; }

        public Documento.Partida partida { get; set; }

        public frmSeleccionOpcionales(Documento.Partida _partida, Paquete _paquete, bool seleccion_multiple = false)
        {
            InitializeComponent();
            this.MetodoDinamico();
            try
            {
                partida = _partida;
                paquete = _paquete;
                paquete.ObtenerOpciones();
                if (seleccion_multiple)
                {
                    ((ColumnViewOptionsSelection)gvResultados.OptionsSelection).MultiSelect = true;
                    gvResultados.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)0;
                }
                ((Control)(object)lblArticulo).Text = partida.nombre;
                ((Control)(object)lblMaximo).Text = $"Máximo: {paquete.maximo}";
                ((Control)(object)lblMinimo).Text = $"Máximo: {paquete.minimo}";
                opciones = paquete.opciones;
                opciones.ForEach(delegate (Paquete.Opcion x)
                {
                    x.cantidad = 0;
                });
                gcResultados.DataSource = opciones;
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
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvResultados_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                int num = opciones.Sum((Paquete.Opcion x) => x.cantidad);
                ((Control)(object)lblSeleccionados).Text = $"Cantidad seleccionada: {num}";
                if ((decimal)num == partida.cantidad)
                {
                    MessageBox.Show("Se completó la selección de opciones");
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
