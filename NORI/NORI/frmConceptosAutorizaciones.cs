using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmConceptosAutorizaciones : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gcConceptos;

        private GridView gvConceptos;

        private GridColumn gridColumnCodigo;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnOperador;

        private GridColumn gridColumnNivelAcceso;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnUsuarioAutorizacion;

        public frmConceptosAutorizaciones()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            Cargar();
        }

        private void CargarListas()
        {
            var list = (from x in Usuario.Usuarios()
                        where x.activo == true
                        select new { x.id, x.usuario }).ToList();
            list.Insert(0, new
            {
                id = 0,
                usuario = "-- Cualquier usuario --"
            });
            ((RepositoryItemLookUpEditBase)cbUsuarios).DataSource = list;
            ((RepositoryItemLookUpEditBase)cbUsuarios).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUsuarios).DisplayMember = "usuario";
        }

        private void Cargar()
        {
            gcConceptos.DataSource = Utilidades.EjecutarQuery("SELECT * FROM conceptos_autorizaciones");
            gcConceptos.RefreshDataSource();
        }

        private void gcCorreosElectronicos_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_0043: Unknown result type (might be due to invalid IL or missing references)
            //IL_004a: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvConceptos).GetDataRow(((ColumnView)gvConceptos).GetSelectedRows()[0]);
                ((BaseView)gvConceptos).CloseEditor();
                Autorizacion.ConceptoAutorizacion conceptoAutorizacion = Autorizacion.ConceptoAutorizacion.Obtener(dataRow["codigo"].ToString());
                if ((int)e.Button.ButtonType == 10)
                {
                    conceptoAutorizacion.operador = dataRow["operador"].ToString();
                    conceptoAutorizacion.nivel_acceso = (byte)dataRow["nivel_acceso"];
                    conceptoAutorizacion.usuario_autorizacion_id = (int)dataRow["usuario_autorizacion_id"];
                    conceptoAutorizacion.Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }

}
