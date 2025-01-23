using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DTM
{

    public partial class frmAutenticar : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private Button btnAutenticar;

        private LabelControl lblDesbloquear;

        private LabelControl labelControl1;

        private TextEdit txtContraseña;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtUsuario;

        private LabelControl lblUsuario;

        public Usuario usuario { get; set; }

        public frmAutenticar()
        {
            InitializeComponent();
            this.MetodoDinamico();
            this.DoubleBuffered = true;
        }


        private void frmAutenticar_Load(object sender, EventArgs e)
        {
            ((Control)(object)txtUsuario).Text = usuario.usuario;
            ((Control)(object)txtContraseña).Focus();
            if (usuario.id != 0)
            {
                ((Control)(object)txtUsuario).Enabled = false;
            }
        }

        private void btnAutenticar_Click(object sender, MouseEventArgs e)
        {
            if (usuario.id == 0)
            {
                usuario = Usuario.Obtener(((Control)(object)txtUsuario).Text);
            }
            if (usuario.id != 0)
            {
                if (usuario.ObtenerContraseña() == ((Control)(object)txtContraseña).Text)
                {

                    ((Form)this).DialogResult = DialogResult.OK;
                    return;
                }
                ((Control)(object)txtContraseña).Text = string.Empty;
                ((Control)(object)txtContraseña).Focus();
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funciones.huella = true;
            Funciones.Desbloquear();
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            Usuario usuario2 = new Usuario();
            usuario2 = Usuario.Obtener(((Control)(object)txtUsuario).Text);
            if (usuario2.id != 0)
            {
                if (usuario.ObtenerContraseña() == ((Control)(object)txtContraseña).Text)
                {

                    ((Form)this).DialogResult = DialogResult.OK;
                    return;
                }
                ((Control)(object)txtContraseña).Text = string.Empty;
                ((Control)(object)txtContraseña).Focus();
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
            else{
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
