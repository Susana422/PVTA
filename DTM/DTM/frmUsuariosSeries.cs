using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmUsuariosSeries : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gc;

        private GridView gv;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnID;

        private RepositoryItemLookUpEdit cbSeries;

        private GridColumn gridColumnFecha;

        private GridColumn gridColumnSerieID;

        public frmUsuariosSeries()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            Cargar();
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbUsuarios).DataSource = (from x in Usuario.Usuarios()
                                                                     where x.activo == true
                                                                     select new { x.id, x.usuario }).ToList();
            ((RepositoryItemLookUpEditBase)cbUsuarios).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUsuarios).DisplayMember = "usuario";
            ((RepositoryItemLookUpEditBase)cbSeries).DataSource = (from x in Serie.Series()
                                                                   select new { x.id, x.codigo, x.clase, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSeries).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSeries).DisplayMember = "nombre";
        }

        private void Cargar()
        {
            gc.DataSource = Utilidades.EjecutarQuery("SELECT * FROM usuarios_series");
            gc.RefreshDataSource();
        }

        private void gc_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0055: Invalid comparison between Unknown and I4
            //IL_00b2: Unknown result type (might be due to invalid IL or missing references)
            //IL_00b8: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gv).GetDataRow(((ColumnView)gv).GetSelectedRows()[0]);
                ((BaseView)gv).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Usuario.Serie serie = Usuario.Serie.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    serie.usuario_id = (int)dataRow["usuario_id"];
                    serie.serie_id = (int)dataRow["serie_id"];
                    if (serie.id != 0)
                    {
                        serie.Actualizar();
                    }
                    else
                    {
                        serie.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && serie.id != 0)
                {
                    serie.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }

}
