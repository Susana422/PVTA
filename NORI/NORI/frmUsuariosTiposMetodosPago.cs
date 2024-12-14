using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NoriSDK;

namespace NORI
{
    public partial class frmUsuariosTiposMetodosPago : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gc;

        private GridView gv;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnID;

        private RepositoryItemLookUpEdit cbTiposMetodosPago;

        private GridColumn gridColumnFecha;

        private GridColumn gridColumnTipoMetodoPagoID;

        public frmUsuariosTiposMetodosPago()
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
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago).DataSource = (from x in MetodoPago.Tipo.Tipos()
                                                                             select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago).DisplayMember = "nombre";
        }

        private void Cargar()
        {
            gc.DataSource = Utilidades.EjecutarQuery("SELECT * FROM usuarios_tipos_metodos_pago");
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
                Usuario.TipoMetodoPago tipoMetodoPago = Usuario.TipoMetodoPago.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    tipoMetodoPago.usuario_id = (int)dataRow["usuario_id"];
                    tipoMetodoPago.tipo_metodo_pago_id = (int)dataRow["tipo_metodo_pago_id"];
                    if (tipoMetodoPago.id != 0)
                    {
                        tipoMetodoPago.Actualizar();
                    }
                    else
                    {
                        tipoMetodoPago.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && tipoMetodoPago.id != 0)
                {
                    tipoMetodoPago.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
    }
