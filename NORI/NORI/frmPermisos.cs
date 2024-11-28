using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
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
    public partial class frmPermisos : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gcPermisos;

        private GridView gvPermisos;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnID;

        private GridColumn gridColumnActivo;

        private GridColumn gridColumnObjeto;

        private RepositoryItemLookUpEdit cbObjetos;

        private GridColumn gridColumnAgregar;

        private GridColumn gridColumnActualizar;

        private GridColumn gridColumnEliminar;

        private GridColumn gridColumnFecha;

        private GridColumn gridColumnAutorizacion;

        private GridColumn gridColumnUsuarioAutorizacionID;

        private GridColumn gridColumnCancelar;

        private GridColumn gridColumnApp;

        private GridColumn gridColumnCancelarCFDI;

        public frmPermisos()
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
            list.Add(new
            {
                id = 0,
                usuario = "-- Ningún usuario --"
            });
            ((RepositoryItemLookUpEditBase)cbUsuarios).DataSource = list.OrderBy(x => x.id).ToList();
            ((RepositoryItemLookUpEditBase)cbUsuarios).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUsuarios).DisplayMember = "usuario";
            Dictionary<string, string> objetos = new Dictionary<string, string>();
            objetos.Add("AR", "Artículos");
            Documento.Clase.Clases().ForEach(delegate (Documento.Clase x)
            {
                objetos.Add(x.clase, x.nombre);
            });
            ((RepositoryItemLookUpEditBase)cbObjetos).DataSource = objetos;
            ((RepositoryItemLookUpEditBase)cbObjetos).ValueMember = "Key";
            ((RepositoryItemLookUpEditBase)cbObjetos).DisplayMember = "Value";
        }

        private void Cargar()
        {
            gcPermisos.DataSource = Utilidades.EjecutarQuery("SELECT * FROM permisos");
            gcPermisos.RefreshDataSource();
        }

        private void gcPermisos_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0055: Invalid comparison between Unknown and I4
            //IL_0184: Unknown result type (might be due to invalid IL or missing references)
            //IL_018a: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvPermisos).GetDataRow(((ColumnView)gvPermisos).GetSelectedRows()[0]);
                ((BaseView)gvPermisos).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Permiso permiso = Permiso.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    permiso.usuario_id = (int)dataRow["usuario_id"];
                    permiso.objeto = (string)dataRow["objeto"];
                    permiso.agregar = (bool)dataRow["agregar"];
                    permiso.actualizar = (bool)dataRow["actualizar"];
                    permiso.cancelar = (bool)dataRow["cancelar"];
                    permiso.cancelar_cfdi = (bool)dataRow["cancelar_cfdi"];
                    permiso.eliminar = (bool)dataRow["eliminar"];
                    permiso.autorizacion = (bool)dataRow["autorizacion"];
                    permiso.usuario_autorizacion_id = (int)dataRow["usuario_autorizacion_id"];
                    permiso.app = (bool)dataRow["app"];
                    permiso.activo = (bool)dataRow["activo"];
                    if (permiso.id != 0)
                    {
                        permiso.Actualizar();
                    }
                    else
                    {
                        permiso.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && permiso.id != 0)
                {
                    permiso.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvPermisos_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "agregar", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "actualizar", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "cancelar", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "cancelar_cfdi", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "eliminar", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "autorizacion", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "usuario_autorizacion_id", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "app", (object)1);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "activo", (object)1);
        }

    
}
}
