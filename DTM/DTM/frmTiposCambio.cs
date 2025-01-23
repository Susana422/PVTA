using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmTiposCambio : RibbonForm
    {
        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private RibbonPageGroup ribbonPageGroup1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private GridControl gcTiposCambio;

        private GridView gvTiposCambio;

        private LayoutControlItem layoutControlItem1;

        private GridColumn id;

        private GridColumn fecha;

        private RepositoryItemDateEdit deFecha;

        private GridColumn compra;

        private GridColumn venta;

        private GridColumn moneda_id;

        private RepositoryItemLookUpEdit cbMonedas;

        private LayoutControl layoutControl2;

        private LayoutControlGroup layoutControlGroup2;

        private LayoutControlItem layoutControlItem3;

        private Panel panel1;

        private LayoutControlItem layoutControlItem2;

        private ComboBoxEdit cbMes;

        private ComboBoxEdit cbAño;

        public frmTiposCambio()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
        }

        private void CargarListas()
        {
            object parametros = new
            {
                fields = "id, codigo, nombre"
            };
            object objeto = new
            {
                activo = 1
            };
            ((RepositoryItemLookUpEditBase)cbMonedas).DataSource = Utilidades.Busqueda("monedas", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMonedas).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedas).DisplayMember = "nombre";
            deFecha.MinValue = DateTime.Now;
            try
            {
                TipoCambio tipoCambio = (from x in TipoCambio.TiposCambio()
                                         orderby x.id
                                         select x).First();
                TipoCambio tipoCambio2 = (from x in TipoCambio.TiposCambio()
                                          orderby x.id descending
                                          select x).First();
                for (int i = tipoCambio.fecha.Year - 1; i < tipoCambio2.fecha.Year - 1; i++)
                {
                    cbAño.Properties.Items.Add((object)(tipoCambio.fecha.Year + 1));
                }
                ((BaseEdit)cbAño).EditValue = DateTime.Now.Year;
                try
                {
                    cbMes.SelectedIndex = int.Parse(DateTime.Now.Month.ToString("00")) - 1;
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        private void gcTiposCambio_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_0007: Unknown result type (might be due to invalid IL or missing references)
            //IL_000e: Invalid comparison between Unknown and I4
            if ((int)e.Button.ButtonType != 10)
            {
                return;
            }
            try
            {
                DataRow dataRow = ((ColumnView)gvTiposCambio).GetDataRow(((ColumnView)gvTiposCambio).GetSelectedRows()[0]);
                ((BaseView)gvTiposCambio).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                int num = (int)dataRow["moneda_id"];
                DateTime dateTime = (DateTime)dataRow["fecha"];
                decimal num2 = decimal.Parse(dataRow["compra"].ToString());
                decimal num3 = decimal.Parse(dataRow["venta"].ToString());
                TipoCambio tipoCambio = new TipoCambio();
                if (result != 0)
                {
                    tipoCambio = TipoCambio.Obtener(result);
                }
                tipoCambio.moneda_id = num;
                tipoCambio.fecha = dateTime;
                tipoCambio.compra = num2;
                tipoCambio.venta = num3;
                if (tipoCambio.id != 0)
                {
                    tipoCambio.Actualizar();
                }
                else
                {
                    tipoCambio.Agregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = cbMes.SelectedIndex + 1;
            int year = int.Parse(((BaseEdit)cbAño).EditValue.ToString());
            string text = year + month.ToString("00") + "01";
            string text2 = year + month.ToString("00") + DateTime.DaysInMonth(year, month);
            gcTiposCambio.DataSource = Utilidades.EjecutarQuery("SELECT * FROM tipos_cambio WHERE fecha BETWEEN '" + text + "' AND '" + text2 + "'");
        }

        private void gvTiposCambio_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ((ColumnView)gvTiposCambio).SetRowCellValue(e.RowHandle, "fecha", (object)DateTime.Today);
            ((ColumnView)gvTiposCambio).SetRowCellValue(e.RowHandle, "moneda_id", (object)Program.Nori.Configuracion.moneda_id);
            ((ColumnView)gvTiposCambio).SetRowCellValue(e.RowHandle, "compra", (object)1);
            ((ColumnView)gvTiposCambio).SetRowCellValue(e.RowHandle, "venta", (object)1);
        }
    }
}
