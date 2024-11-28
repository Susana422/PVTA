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
    public partial class frmParametrizacionesFormulario : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gcPermisos;

        private GridView gvPermisos;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnID;

        private GridColumn gridColumnDesactivado;

        private GridColumn gridColumnControl;

        private RepositoryItemLookUpEdit cbControles;

        private GridColumn gridColumnOculto;

        private GridColumn gridColumnRol;

        private RepositoryItemLookUpEdit cbRoles;

        private RepositoryItemLookUpEdit cbObjetos;

        private string formulario { get; set; }

        private string objeto { get; set; }

        public frmParametrizacionesFormulario(string f, string o)
        {
            InitializeComponent();
            this.MetodoDinamico();
            formulario = f;
            objeto = o;
            CargarListas();
            Cargar();
        }

        private void CargarListas()
        {
            //IL_0276: Unknown result type (might be due to invalid IL or missing references)
            //IL_027d: Expected O, but got Unknown
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
            ((RepositoryItemLookUpEditBase)cbRoles).DataSource = Usuario.Rol.Roles();
            ((RepositoryItemLookUpEditBase)cbRoles).ValueMember = "rol";
            ((RepositoryItemLookUpEditBase)cbRoles).DisplayMember = "nombre";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Form form = Application.OpenForms[formulario];
            foreach (Control item in form.ObtenerControles().OfType<Control>())
            {
                dictionary.Add(item.Name, (item.Text.Length == 0) ? item.Name : item.Text);
            }
            try
            {
                string key = ((form.Name == "frmDocumentos") ? "gcPartidas" : ((form.Name == "frmSocios") ? "gcPersonasContacto" : "gcInventario"));
                GridControl root = (GridControl)form.Controls.Find(key, searchAllChildren: true).First();
                foreach (GridColumn item2 in root.ObtenerColumnas().OfType<GridColumn>())
                {
                    dictionary.Add(item2.Name, item2.Caption);
                }
            }
            catch
            {
            }
            ((RepositoryItemLookUpEditBase)cbControles).DataSource = dictionary;
            ((RepositoryItemLookUpEditBase)cbControles).ValueMember = "Key";
            ((RepositoryItemLookUpEditBase)cbControles).DisplayMember = "Value";
        }

        private void Cargar()
        {
            gcPermisos.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM parametrizaciones_formulario where formulario = '{formulario}' and objeto = '{objeto}'");
            gcPermisos.RefreshDataSource();
        }

        private void gcPermisos_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0053: Invalid comparison between Unknown and I4
            //IL_0121: Unknown result type (might be due to invalid IL or missing references)
            //IL_0127: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvPermisos).GetDataRow(((ColumnView)gvPermisos).GetSelectedRows()[0]);
                ((BaseView)gvPermisos).CloseEditor();
                int.TryParse(dataRow["id"].ToString(), out var result);
                ParametrizacionFormulario parametrizacionFormulario = ParametrizacionFormulario.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    parametrizacionFormulario.usuario_id = (int)dataRow["usuario_id"];
                    char.TryParse((string)dataRow["rol"], out var result2);
                    parametrizacionFormulario.rol = result2;
                    parametrizacionFormulario.objeto = objeto;
                    parametrizacionFormulario.formulario = formulario;
                    parametrizacionFormulario.control = (string)dataRow["control"];
                    parametrizacionFormulario.oculto = (bool)dataRow["oculto"];
                    parametrizacionFormulario.desactivado = (bool)dataRow["desactivado"];
                    if (parametrizacionFormulario.id != 0)
                    {
                        parametrizacionFormulario.Actualizar();
                    }
                    else
                    {
                        parametrizacionFormulario.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && parametrizacionFormulario.id != 0)
                {
                    parametrizacionFormulario.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvPermisos_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "oculto", (object)0);
            ((ColumnView)gvPermisos).SetRowCellValue(e.RowHandle, "desactivado", (object)1);
        }

    }

}
