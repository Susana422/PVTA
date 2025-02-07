﻿using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace DTM
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

        private RibbonControl ribbonControl1;
        private PictureBox pictureBox1;

        public frmAcceder()
        {
            InitializeComponent();
            this.MetodoDinamico();
            Cargar();
            this.ribbonControl1.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.None;
            this.ribbonControl1.OptionsSearchMenu.UseCustomRibbonSearch = DevExpress.Utils.DefaultBoolean.False;
            cursorManita();
        }
        public void cursorManita()
        {
            btnAcceder.MouseEnter += (sender, e) => { this.Cursor = Cursors.Hand;};
            btnAcceder.MouseLeave += (sender, e) => { this.Cursor = Cursors.Default; };

            lbEnalceHuella.MouseEnter += (sender, e) => { this.Cursor = Cursors.Hand; };
            lbEnalceHuella.MouseLeave += (sender, e) => { this.Cursor = Cursors.Default; };
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
            if (!Program.dtm.Conectar())
            {
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Application.ProductName);
                return;
            }
            Usuario usuario = new Usuario();
            usuario.usuario = ((Control)(object)txtUsuario).Text;
            usuario.contraseña = ((Control)(object)txtContraseña).Text;
            Program.dtm.Empresa.prueba = false;
            if (usuario.usuario.Length > 0 && usuario.contraseña.Length > 0)
            {
                acceder(Program.dtm.Autenticar(usuario));
            }
            else if (((Control)(object)txtUsuario).Text.Length > 0 && Program.dtm.Estacion.lector_huella)
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
                    if (Program.dtm.Configuracion.tema.Length > 0)
                    {
                        //defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.FromArgb(Convert.ToInt32(Program.dtm.Configuracion.tema));
                    }
                }
                catch
                {
                }
                if (Program.dtm.UsuarioAutenticado.rol == 'X')
                {
                    frmSincronizacion frmSincronizacion2 = new frmSincronizacion();
                    ((Control)(object)frmSincronizacion2).Show();
                }
                else
                {
                    if (Program.dtm.Configuracion.seleccionar_sucursal || Program.dtm.UsuarioAutenticado.seleccionar_sucursal)
                    {
                        //frmSeleccionarSucursal frmSeleccionarSucural2 = new frmSeleccionarSucursal();
                        //((Form)(object)frmSeleccionarSucural2).ShowDialog();
                        Program.dtm.UsuarioAutenticado.almacen_id = 2;
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
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM").ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                        Program.dtm.EstablecerUsuario(frmAutenticar2.usuario);
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
            Program.dtm.Conexion = new SqlConnectionStringBuilder(conexiones[cbConexiones.EditValue.ToString()].ConnectionString);
        }

        private void frmAcceder_Load(object sender, EventArgs e)
        {
            ((Form)this).Activate();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
        }
    }

}
