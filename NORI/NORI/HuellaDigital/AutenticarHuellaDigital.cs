using DevExpress.XtraBars;
using NORI.HuellaDigital.Class;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI.HuellaDigital
{
    public partial class AutenticarHuellaDigital : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private AppData Data;
        private ConnectionStringSettingsCollection conexiones;
        public Usuario usuario { get; set; }
        public AutenticarHuellaDigital(AppData data)
        {
            InitializeComponent();
            Data = data;
            CargarConexiones();

        }
        private void CargarConexiones()
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            conexiones = ConfigurationManager.ConnectionStrings;
            Program.Nori.Conexion = new SqlConnectionStringBuilder(conexiones[0].ConnectionString);

        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funciones.huella = false;
            Funciones.Desbloquear();
            //frmHome frmHome = new frmHome();
            //frmHome.Show();
        }

        private void VerificationControl_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (!Program.Nori.Conectar())
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Application.ProductName);
                return;
            }
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();

            var huellas = NoriSDK.HuellaDigital.HuellaDigitales();
            foreach (var x in huellas)
            {
                if (x.usuario_id == usuario.id) 
                {
                    DPFP.Template template = DeserializeTemplate(x.huella);
                    ver.Verify(FeatureSet, template, ref res);
                    Data.IsFeatureSetMatched = res.Verified;
                    Data.FalseAcceptRate = res.FARAchieved;
                    if (res.Verified)
                    {
                        //searchUser(x.usuario_id);
                        Funciones.huella = true;
                        ((Form)this).DialogResult = DialogResult.OK;
                        break;
                    }
                    // success
                }



            }

            if (!res.Verified)
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                MessageBox.Show("La huella registrada no existe,intente nuevamente");
            }


            Data.Update();
        }
        public void searchUser(int id)
        {

            try
            {
                Usuario usuario = new Usuario();
                usuario = Usuario.Obtener(id);
                acceder(Program.Nori.Autenticar(usuario));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al buscar el usuario");
            }
        }
        public DPFP.Template DeserializeTemplate(string base64String)
        {
            byte[] templateBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(templateBytes))
            {
                DPFP.Template template = new DPFP.Template();
                template.DeSerialize(ms);

                return template;
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
                        //defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.FromArgb(Convert.ToInt32(Program.Nori.Configuracion.tema));
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
                        //frmSeleccionarSucursal frmSeleccionarSucural2 = new frmSeleccionarSucursal();
                        //((Form)(object)frmSeleccionarSucural2).ShowDialog();
                        Program.Nori.UsuarioAutenticado.almacen_id = 2;
                    }
                    frmPrincipal frmPrincipal2 = new frmPrincipal();
                    ((Control)(object)frmPrincipal2).Show();
                    //((Control)(object)txtUsuario).Text = string.Empty;
                    //((Control)(object)txtContraseña).Text = string.Empty;
                }
                ((Control)this).Hide();
            }
            else
            {
                //((Control)(object)txtContraseña).Text = string.Empty;
                //((Control)(object)txtContraseña).Focus();
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM").ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
        }
    }
}