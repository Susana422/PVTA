using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace NORI
{
    public partial class frmAcceder : RibbonForm
    {
        private ConnectionStringSettingsCollection conexiones;

        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private LabelControl lblUsuario;

        private LabelControl labelControl1;

        private TextEdit txtContraseña;

        private LabelControl lblAcceder;

        private Button btnAcceder;

        private TextEdit txtUsuario;

        private DefaultLookAndFeel defaultLookAndFeel1;

        private HyperlinkLabelControl lblConexion;

        private LookUpEdit cbConexiones;

        public frmAcceder()
        {
            InitializeComponent();
            this.MetodoDinamico();
            Cargar();
        }

        private void CargarConexiones()
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            conexiones = ConfigurationManager.ConnectionStrings;
        }

        private void Cargar()
        {
            try
            {
                CargarConexiones();
                if (conexiones.Count != 0)
                {
                    //var conexionesLista = conexiones.Cast<ConnectionStringSettings>().ToList();
                    //var conexionesSinPrimerItem = conexionesLista.Skip(1).ToList();
                    ((RepositoryItemLookUpEditBase)cbConexiones.Properties).DataSource = conexiones;
                    ((RepositoryItemLookUpEditBase)cbConexiones.Properties).ValueMember = "Name";
                    ((RepositoryItemLookUpEditBase)cbConexiones.Properties).DisplayMember = "Name";
                    //((BaseEdit)cbConexiones).EditValue = conexiones;
                    if (conexiones.Count > 0)
                    {
                        cbConexiones.EditValue = conexiones[0].Name;  // Establece el primer valor
                    }

                }
            }
            catch
            {
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (!Program.Nori.Conectar())
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, Application.ProductName);
                return;
            }
            Usuario usuario = new Usuario();
            usuario.usuario = ((Control)(object)txtUsuario).Text;
            usuario.contraseña = ((Control)(object)txtContraseña).Text;
            Program.Nori.Empresa.prueba = false;
            if (usuario.usuario.Length > 0 && usuario.contraseña.Length > 0)
            {
                acceder(Program.Nori.Autenticar(usuario));
            }
            else if (((Control)(object)txtUsuario).Text.Length > 0 && Program.Nori.Estacion.lector_huella)
            {
                acceder(Funciones.AccederConHuella(usuario));
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de usuario y contraseña.", ((Control)(object)this).Text);
            }
        }

        private void acceder(bool r)
        {
            if (r)
            {
                try
                {
                    if (Program.Nori.Configuracion.tema.Length > 0)
                    {
                        defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.FromArgb(Convert.ToInt32(Program.Nori.Configuracion.tema));
                    }
                }
                catch
                {
                }
                if (Program.Nori.UsuarioAutenticado.rol == 'X')
                {
                    frmSincronizacion frmSincronizacion2 = new frmSincronizacion();
                    ((Control)(object)frmSincronizacion2).Show();
                }
                else
                {
                    if (Program.Nori.Configuracion.seleccionar_sucursal || Program.Nori.UsuarioAutenticado.seleccionar_sucursal)
                    {
                        frmSeleccionarSucursal frmSeleccionarSucural2 = new frmSeleccionarSucursal();
                        ((Form)(object)frmSeleccionarSucural2).ShowDialog();
                    }
                    frmPrincipal frmPrincipal2 = new frmPrincipal();
                    ((Control)(object)frmPrincipal2).Show();
                    ((Control)(object)txtUsuario).Text = string.Empty;
                    ((Control)(object)txtContraseña).Text = string.Empty;
                }
                ((Control)this).Hide();
            }
            else
            {
                ((Control)(object)txtContraseña).Text = string.Empty;
                ((Control)(object)txtContraseña).Focus();
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!e.Control || e.KeyCode != Keys.S || ((Control)(object)txtUsuario).Text.Length <= 0)
                {
                    return;
                }
                Usuario usuario = (from x in Usuario.Usuarios()
                                   where x.usuario == ((Control)(object)txtUsuario).Text
                                   select x).First();
                if (usuario.rol == 'A')
                {
                    frmAutenticar frmAutenticar2 = new frmAutenticar();
                    frmAutenticar2.usuario = usuario;
                    ((Form)(object)frmAutenticar2).ShowDialog();
                    if (((Form)(object)frmAutenticar2).DialogResult == DialogResult.OK)
                    {
                        Program.Nori.EstablecerUsuario(frmAutenticar2.usuario);
                        acceder(r: true);
                    }
                }
            }
            catch
            {
            }
        }

        private void frmAcceder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.MatarProcesos();
        }

        private void lblConexion_Click(object sender, EventArgs e)
        {
            frmConexiones frmConexiones2 = new frmConexiones();
            ((Form)(object)frmConexiones2).ShowDialog();
            CargarConexiones();
        }

        private void cbConexiones_EditValueChanged(object sender, EventArgs e)
        {
            //string  xx = cbConexiones.EditValue.ToString();
            Program.Nori.Conexion = new SqlConnectionStringBuilder(conexiones[cbConexiones.EditValue.ToString()].ConnectionString);
        }

        private void frmAcceder_Load(object sender, EventArgs e)
        {
            ((Form)this).Activate();
        }

        
    
    }

}
