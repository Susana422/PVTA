using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using NoriSDK;

namespace NORI.Kiosco
{
    public partial class frmSocio : XtraForm
    {
        public string codigo_socio;

        public Socio socio_busqueda = new Socio();

        private Documento documento = new Documento();

        private IContainer components = null;

        private TextEdit txtCodigo;

        private TextEdit txtNombre;

        private LabelControl labelControl1;

        private LabelControl labelControl2;

        private DefaultLookAndFeel defaultLookAndFeel1;

        private TextEdit txtRFC;

        private LabelControl labelControl3;

        private LabelControl lblInfo;

        private SimpleButton btnCerrar;

        private SimpleButton btnAceptar;

        private SimpleButton btnBuscar;

        private SimpleButton btnAlta;

        private Timer timer1;

        private Label lblError;

        public frmSocio()
        {
            InitializeComponent();
            this.MetodoDinamico();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            ((Control)(object)btnBuscar).Enabled = true;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            ((Control)(object)btnBuscar).Enabled = true;
        }

        private void EstablecerSocio(Socio socio)
        {
            try
            {
                if (!documento.EstablecerSocio(socio))
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                    return;
                }
                socio.CopyProperties(socio_busqueda);
                ((Control)(object)txtCodigo).Text = socio.codigo;
                ((Control)(object)txtNombre).Text = socio.nombre;
                ((Control)(object)txtRFC).Text = socio.rfc;
                ((Control)(object)btnAceptar).Enabled = true;
                ((Control)(object)btnAlta).Enabled = true;
            }
            catch
            {
            }
        }

        private void BuscarSocios(string q, bool rfc = false)
        {
            string empty = string.Empty;
            empty = ((!rfc) ? string.Format("SELECT id, codigo, nombre, rfc FROM socios WHERE codigo like '%{0}%' OR nombre LIKE '%{0}%' AND tipo = 'C' AND activo = 1", q.Replace(" ", "%")) : string.Format("SELECT id, codigo, nombre, rfc FROM socios WHERE rfc like '%{0}%' AND tipo = 'C' AND activo = 1", q.Replace(" ", "%")));
            DataTable dataTable = Utilidades.EjecutarQuery(empty);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows.Count == 1)
                {
                    socio_busqueda = Socio.Obtener((int)dataTable.Rows[0]["id"]);
                }
                else
                {
                    frmResultadosBusqueda frmResultadosBusqueda = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        socio_busqueda = Socio.Obtener(frmResultadosBusqueda.id);
                    }
                }
                if (!socio_busqueda.activo)
                {
                    lblError.Visible = true;
                    lblError.Text = "El socio esta inactivo, favor de acudir a cobranza.";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = $"No se encontraron resultados para los datos proporcionados.";
            }
        }

        private void BuscarSocio()
        {
            try
            {
                if (((Control)(object)txtCodigo).Text.Length > 0)
                {
                    EstablecerSocio((from x in Socio.Socios()
                                     where x.codigo == ((Control)(object)txtCodigo).Text
                                     select x).First());
                }
                else if (((Control)(object)txtNombre).Text.Length > 0)
                {
                    BuscarSocios(((Control)(object)txtNombre).Text);
                    EstablecerSocio((from x in Socio.Socios()
                                     where x.codigo == socio_busqueda.codigo
                                     select x).First());
                }
                else if (((Control)(object)txtRFC).Text.Length > 0)
                {
                    BuscarSocios(((Control)(object)txtRFC).Text, rfc: true);
                    EstablecerSocio((from x in Socio.Socios()
                                     where x.codigo == socio_busqueda.codigo
                                     select x).First());
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Favor de capturar un código o un nombre.";
                }
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "Socio no encontrado.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            AltaSocios(actualizar: true);
        }

        private void AltaSocios(bool actualizar = false)
        {
            Kiosco.frmAltaRapidaSocio frmAltaRapidaSocio2 = new Kiosco.frmAltaRapidaSocio();
            if (((Control)(object)btnAlta).Text == "Datos")
            {
                frmAltaRapidaSocio2.socio = socio_busqueda;
            }
            ((Form)(object)frmAltaRapidaSocio2).ShowDialog();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            Funciones.AbrirTecladoTactil();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (((Control)(object)txtCodigo).Text.Length > 0)
            {
                EstablecerSocio((from x in Socio.Socios()
                                 where x.codigo == ((Control)(object)txtCodigo).Text
                                 select x).First());
            }
            else if (((Control)(object)txtNombre).Text.Length > 0)
            {
                BuscarSocios(((Control)(object)txtNombre).Text);
                EstablecerSocio((from x in Socio.Socios()
                                 where x.codigo == socio_busqueda.codigo
                                 select x).First());
            }
            else if (((Control)(object)txtRFC).Text.Length > 0)
            {
                BuscarSocios(((Control)(object)txtRFC).Text, rfc: true);
                EstablecerSocio((from x in Socio.Socios()
                                 where x.codigo == socio_busqueda.codigo
                                 select x).First());
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Favor de capturar un codigo o un nombre";
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaSocios();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                BuscarSocio();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ((Form)this).Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            codigo_socio = ((Control)(object)txtCodigo).Text;
            ((Form)this).DialogResult = DialogResult.OK;
        }
    }
    }
