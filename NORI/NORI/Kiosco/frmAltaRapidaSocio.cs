using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NORI.Kiosco
{
    public partial class frmAltaRapidaSocio : XtraForm
    {
        public Socio socio = new Socio();

        private Socio.Direccion direccion = new Socio.Direccion();

        private Socio.PersonaContacto persona_contacto = new Socio.PersonaContacto();

        private IContainer components = null;

        private TextEdit txtRFC;

        private TextEdit txtNombre;

        private TextEdit txtCalle;

        private TextEdit txtColonia;

        private TextEdit txtCP;

        private LabelControl labelControl1;

        private LabelControl labelControl2;

        private LabelControl labelControl3;

        private LabelControl labelControl4;

        private LabelControl labelControl5;

        private LabelControl labelControl6;

        private LabelControl labelControl8;

        private LabelControl labelControl9;

        private LabelControl labelControl10;

        private LabelControl labelControl11;

        private LabelControl labelControl12;

        private TextEdit txtNumero;

        private TextEdit txtEmail;

        private SimpleButton btnLimpiar;

        private TextEdit txtMunicipio;

        private LookUpEdit luePais;

        private LookUpEdit lueEstado;

        private TextEdit txtCiudad;

        private TextEdit txtCodigo;

        private LabelControl labelControl7;

        private SimpleButton btnCerrar;

        private SimpleButton btnAceptar;

        private LookUpEdit lueUsoPrincipal;

        private LabelControl labelControl13;

        public frmAltaRapidaSocio()
        {
            InitializeComponent();
            this.MetodoDinamico();
            EventoControl.SuscribirEventos((Form)(object)this);
            CargarListas();
        }

        private void CargarListas()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)luePais.Properties).DataSource = from x in Pais.Paises()
                                                                                select new { x.id, x.nombre };
                ((RepositoryItemLookUpEditBase)luePais.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)luePais.Properties).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).DataSource = from x in Estado.Estados()
                                                                                  select new { x.id, x.nombre };
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)lueUsoPrincipal.Properties).DataSource = Documento.UsoCFDI.UsosCFDI();
                ((RepositoryItemLookUpEditBase)lueUsoPrincipal.Properties).ValueMember = "uso";
                ((RepositoryItemLookUpEditBase)lueUsoPrincipal.Properties).ValueMember = "nombre";
                ((Control)(object)txtCiudad).Text = Program.Nori.Empresa.ciudad;
                ((Control)(object)txtMunicipio).Text = Program.Nori.Empresa.municipio;
                try
                {
                    var anon = (from x in Estado.Estados()
                                where x.id == Program.Nori.UsuarioAutenticado.estado_id
                                select new { x.id, x.pais_id }).First();
                    ((BaseEdit)luePais).EditValue = anon.pais_id;
                    ((BaseEdit)lueEstado).EditValue = anon.id;
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        private void CargarSocio()
        {
            try
            {
                ((Control)(object)txtCodigo).Text = socio.codigo;
                ((Control)(object)txtRFC).Text = socio.rfc;
                ((Control)(object)txtNombre).Text = socio.nombre;
                Socio.Direccion direccion = Socio.Direccion.Obtener(socio.direccion_facturacion_id);
                ((BaseEdit)lueEstado).EditValue = direccion.pais_id;
                ((BaseEdit)lueEstado).EditValue = direccion.estado_id;
                ((BaseEdit)lueUsoPrincipal).EditValue = socio.uso_principal;
                ((Control)(object)txtCiudad).Text = direccion.ciudad;
                ((Control)(object)txtMunicipio).Text = direccion.municipio;
                ((Control)(object)txtColonia).Text = direccion.colonia;
                ((Control)(object)txtCalle).Text = direccion.calle;
                ((Control)(object)txtNumero).Text = direccion.numero_exterior;
                ((Control)(object)txtCP).Text = direccion.cp;
                ((Control)(object)txtEmail).Text = socio.correo;
            }
            catch
            {
            }
        }

        private void luePais_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).DataSource = from x in Estado.Estados()
                                                                                  where x.pais_id == (int)((BaseEdit)luePais).EditValue
                                                                                  select new { x.id, x.nombre };
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)lueEstado.Properties).DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void LimpiaCampos()
        {
            try
            {
                ((Control)(object)txtRFC).Text = string.Empty;
                ((Control)(object)txtNombre).Text = string.Empty;
                ((Control)(object)txtCiudad).Text = Program.Nori.Empresa.ciudad;
                ((Control)(object)txtMunicipio).Text = Program.Nori.Empresa.municipio;
                ((Control)(object)txtColonia).Text = string.Empty;
                ((Control)(object)txtCalle).Text = string.Empty;
                ((Control)(object)txtNumero).Text = string.Empty;
                ((Control)(object)txtCP).Text = string.Empty;
                ((Control)(object)txtEmail).Text = string.Empty;
            }
            catch
            {
            }
        }

        private bool Validar()
        {
            try
            {
                if (((Control)(object)txtCodigo).Text.Length == 0 || ((Control)(object)txtRFC).Text.Length == 0 || ((Control)(object)txtNombre).Text.Length == 0 || ((Control)(object)txtCalle).Text.Length == 0 || ((Control)(object)txtNumero).Text.Length == 0 || ((Control)(object)txtCiudad).Text.Length == 0 || ((Control)(object)txtCP).Text.Length == 0 || ((Control)(object)txtColonia).Text.Length == 0 || (int)((BaseEdit)luePais).EditValue == 0 || (int)((BaseEdit)lueEstado).EditValue == 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Llenar()
        {
            try
            {
                socio.grupo_socio_id = (from x in GrupoSocio.GruposSocios()
                                        where x.tipo == socio.tipo && x.activo == true
                                        select x).First().id;
                socio.codigo = ((Control)(object)txtCodigo).Text;
                socio.nombre = ((Control)(object)txtNombre).Text;
                socio.nombre_comercial = ((Control)(object)txtNombre).Text;
                socio.rfc = ((Control)(object)txtRFC).Text;
                socio.correo = ((Control)(object)txtEmail).Text;
                direccion.nombre = "Facturación";
                direccion.calle = ((Control)(object)txtCalle).Text;
                direccion.numero_exterior = ((Control)(object)txtNumero).Text;
                direccion.cp = ((Control)(object)txtCP).Text;
                direccion.colonia = ((Control)(object)txtColonia).Text;
                direccion.ciudad = ((Control)(object)txtCiudad).Text;
                direccion.municipio = ((Control)(object)txtMunicipio).Text;
                direccion.estado_id = (int)((BaseEdit)lueEstado).EditValue;
                direccion.pais_id = (int)((BaseEdit)luePais).EditValue;
                persona_contacto.codigo = (short)((from x in Socio.PersonaContacto.PersonasContacto()
                                                   select new { x.codigo } into x
                                                   orderby x.codigo descending
                                                   select x).First().codigo + 1);
                persona_contacto.nombre = socio.codigo;
                persona_contacto.nombre_persona = ((Control)(object)txtNombre).Text;
                persona_contacto.correo = ((Control)(object)txtEmail).Text;
                socio.uso_principal = ((BaseEdit)lueUsoPrincipal).EditValue.ToString();
                if (socio.id == 0)
                {
                    socio.eventual = true;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (socio.id != 0)
                    {
                        if (socio.Actualizar())
                        {
                            return true;
                        }
                        return false;
                    }
                    Llenar();
                    if (socio.Agregar())
                    {
                        direccion.socio_id = socio.id;
                        persona_contacto.socio_id = socio.id;
                        direccion.Agregar();
                        socio.direccion_facturacion_id = direccion.id;
                        direccion.nombre = "Envío";
                        direccion.tipo = 'E';
                        direccion.Agregar();
                        socio.direccion_envio_id = direccion.id;
                        persona_contacto.Agregar();
                        socio.persona_contacto_id = persona_contacto.id;
                        socio.Actualizar();
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaCampos();
        }

        private void frmAltaSocio_Load(object sender, EventArgs e)
        {
            if (socio.id != 0)
            {
                CargarSocio();
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            Funciones.AbrirTecladoTactil();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Guardar())
                {
                    ((Form)this).Close();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                }
            }
            else
            {
                MessageBox.Show("La información del socio no esta completa.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ((Form)this).Close();
        }


    }
}
