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
    public partial class frmCorreosElectronicos : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gcCorreosElectronicos;

        private GridView gvCorreosElectronicos;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnServidor;

        private GridColumn gridColumnPuerto;

        private GridColumn gridColumnSSL;

        private GridColumn gridColumnUsuario;

        private GridColumn gridColumnContraseña;

        private GridColumn gridColumnID;

        private GridColumn gridColumnActivo;

        private GridColumn gridColumnRemitente;

        private GridColumn gridColumnAsunto;

        private GridColumn gridColumnMensaje;

        public frmCorreosElectronicos()
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
        }

        private void Cargar()
        {
            gcCorreosElectronicos.DataSource = Utilidades.EjecutarQuery("SELECT * FROM correos_electronicos");
            gcCorreosElectronicos.RefreshDataSource();
        }

        private void gcCorreosElectronicos_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0055: Invalid comparison between Unknown and I4
            //IL_016d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0173: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvCorreosElectronicos).GetDataRow(((ColumnView)gvCorreosElectronicos).GetSelectedRows()[0]);
                ((BaseView)gvCorreosElectronicos).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Usuario.CorreoElectronico correoElectronico = Usuario.CorreoElectronico.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    correoElectronico.usuario_id = (int)dataRow["usuario_id"];
                    correoElectronico.servidor = dataRow["servidor"].ToString();
                    correoElectronico.puerto = (int)dataRow["puerto"];
                    correoElectronico.ssl = (bool)dataRow["ssl"];
                    correoElectronico.usuario = dataRow["usuario"].ToString();
                    correoElectronico.contraseña = dataRow["contraseña"].ToString();
                    correoElectronico.remitente = dataRow["remitente"].ToString();
                    correoElectronico.asunto = dataRow["asunto"].ToString();
                    correoElectronico.mensaje = dataRow["mensaje"].ToString();
                    correoElectronico.activo = (bool)dataRow["activo"];
                    if (correoElectronico.id != 0)
                    {
                        correoElectronico.Actualizar();
                    }
                    else
                    {
                        correoElectronico.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && correoElectronico.id != 0)
                {
                    correoElectronico.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


    }

}
