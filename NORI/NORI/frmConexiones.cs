using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace NORI
{
    public partial class frmConexiones : RibbonForm
    {
        private ConnectionStringSettingsCollection conexiones;

        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtUsuario;

        private LabelControl lblUsuario;

        private TextEdit txtContraseña;

        private LabelControl lblContraseña;

        private TextEdit txtBD;

        private LabelControl lblBD;

        private TextEdit txtServidor;

        private LabelControl lblServidor;

        private CheckEdit cbSeguridadIntegrada;

        private LookUpEdit cbConexiones;

        private HyperlinkLabelControl lblConexiones;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRestablecer;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BarButtonItem bbiNuevo;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private TextEdit txtNombre;

        private LabelControl lblNombre;

        public frmConexiones()
        {
            InitializeComponent();
            this.MetodoDinamico();
            Cargar();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Inicializar();
        }

        private void CargarConexiones()
        {
            conexiones =new ConnectionStringSettingsCollection();
            ConnectionStringSettings newConnection = new ConnectionStringSettings("LOCAL", "Data Source=DESKTOP-D5V63NE\\SQLEXPRESS;Initial Catalog=NORICUAITITLAN;Integrated Security=False;User ID=sa;Password=123", "System.Data.SqlClient");

            //// Agregarla a la colección
            conexiones.Add(newConnection);
            conexiones = ConfigurationManager.ConnectionStrings;
        }

        private void Cargar()
        {
            CargarConexiones();
            var conexionesLista = conexiones.Cast<ConnectionStringSettings>().ToList();
            var conexionesSinPrimerItem = conexionesLista.Skip(1).ToList();
            if (conexiones.Count != 0)
            {
                ((RepositoryItemLookUpEditBase)cbConexiones.Properties).DataSource = conexionesSinPrimerItem;
                ((RepositoryItemLookUpEditBase)cbConexiones.Properties).ValueMember = "Name";
                ((RepositoryItemLookUpEditBase)cbConexiones.Properties).DisplayMember = "Name";
                // ((BaseEdit)cbConexiones).EditValue = conexionesSinPrimerItem[0].Name;
                if (conexiones.Count > 0)
                {
                    cbConexiones.EditValue = conexiones[0].Name;  // Establece el primer valor
                }
            }
        }

        private void Inicializar()
        {
            ((RepositoryItemLookUpEditBase)cbConexiones.Properties).DataSource = null;
            ((Control)(object)txtNombre).Text = string.Empty;
            ((Control)(object)txtServidor).Text = string.Empty;
            ((Control)(object)txtBD).Text = string.Empty;
            ((Control)(object)txtUsuario).Text = string.Empty;
            ((Control)(object)txtContraseña).Text = string.Empty;
            cbSeguridadIntegrada.Checked = false;
        }

        private void cbConexiones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(conexiones[((BaseEdit)cbConexiones).EditValue.ToString()].ConnectionString);
                ((Control)(object)txtNombre).Text = ((BaseEdit)cbConexiones).EditValue.ToString();
                ((Control)(object)txtServidor).Text = sqlConnectionStringBuilder.DataSource;
                ((Control)(object)txtBD).Text = sqlConnectionStringBuilder.InitialCatalog;
                ((Control)(object)txtUsuario).Text = sqlConnectionStringBuilder.UserID;
                ((Control)(object)txtContraseña).Text = sqlConnectionStringBuilder.Password;
                cbSeguridadIntegrada.Checked = sqlConnectionStringBuilder.IntegratedSecurity;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Guardar()
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                ConnectionStringSettings connectionStringSettings = new ConnectionStringSettings();
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection connectionStringsSection = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
                sqlConnectionStringBuilder.DataSource = ((Control)(object)txtServidor).Text;
                sqlConnectionStringBuilder.InitialCatalog = ((Control)(object)txtBD).Text;
                sqlConnectionStringBuilder.UserID = ((Control)(object)txtUsuario).Text;
                sqlConnectionStringBuilder.Password = ((Control)(object)txtContraseña).Text;
                sqlConnectionStringBuilder.IntegratedSecurity = cbSeguridadIntegrada.Checked;
                connectionStringSettings.ConnectionString = sqlConnectionStringBuilder.ConnectionString;
                connectionStringSettings.Name = ((Control)(object)txtNombre).Text;
                connectionStringSettings.ProviderName = "System.Data.SqlClient";
                if (connectionStringsSection.ConnectionStrings[((Control)(object)txtNombre).Text] != null)
                {
                    connectionStringsSection.ConnectionStrings[((Control)(object)txtNombre).Text].ConnectionString = sqlConnectionStringBuilder.ConnectionString;
                }
                else
                {
                    connectionStringsSection.ConnectionStrings.Add(connectionStringSettings);
                }
                configuration.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
            ((Form)this).Close();
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
            Inicializar();
        }

    
    }

}
