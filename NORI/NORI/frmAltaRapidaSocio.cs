using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NetsuiteLibrary.SuiteTalk_Helpers;
using NoriSDK;

namespace NORI
{
    public partial class frmAltaRapidaSocio : RibbonForm
    {
        private Socio socio = new Socio();

        private Socio.Direccion direccion = new Socio.Direccion();

        private Socio.PersonaContacto persona_contacto = new Socio.PersonaContacto();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private BarButtonItem bbiGuardarCerrar;

        private BackstageViewControl backstageViewControl1;

        private LayoutControlGroup layoutControlGroup1;

        private DataLayoutControl dataLayoutControl1;

        private LayoutControlItem layoutControlItem1;

        private PanelControl panelControl1;

        private LabelControl lblTelefono2;

        private TextEdit txtTelefono2;

        private LabelControl lblCorreo;

        private TextEdit txtCorreo;

        private LabelControl lblTelefonoCelular;

        private TextEdit txtTelefonoCelular;

        private LabelControl lblTelefono;

        private TextEdit txtTelefono;

        private LabelControl lblRFC;

        private TextEdit txtRFC;

        private LabelControl lblNombreComercial;

        private TextEdit txtNombreComercial;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblCodigo;

        private TextEdit txtCodigo;

        private LabelControl lblCalle;

        private TextEdit txtCalle;

        private LabelControl lblNumeroInterior;

        private TextEdit txtNumeroInterior;

        private LabelControl lblNumeroExterior;

        private TextEdit txtNumeroExterior;

        private LabelControl lblColonia;

        private TextEdit txtColonia;

        private LabelControl lblMunicipio;

        private TextEdit txtMunicipio;

        private LabelControl lblPais;

        private LookUpEdit cbPaises;

        private LabelControl lblEstado;

        private LookUpEdit cbEstados;

        private LabelControl lblCiudad;

        private TextEdit txtCiudad;

        private LabelControl lblCP;

        private TextEdit txtCP;

        private SimpleButton btnHuellaDigital;

        private CheckEdit cbEventual;

        private LookUpEdit cbSocios;

        private LookUpEdit cbUsoPrincipal;

        private LabelControl lblUsoPrincipal;

        private LabelControl lblRegimenFiscal;

        private LookUpEdit cbRegimenFiscal;

        public frmAltaRapidaSocio()
        {
            InitializeComponent();
            this.MetodoDinamico();
            EventoControl.SuscribirEventos((Form)(object)this);
            CargarListas();
            Cargar();
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Validar())
            {
                if (Guardar())
                {
                    ((Form)this).DialogResult = DialogResult.OK;
                    ((Form)this).Close();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
                }
            }
            else
            {
                MessageBox.Show("La información del socio no esta completa.");
            }
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DataSource = from x in Pais.Paises()
                                                                             select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DisplayMember = "nombre";
            try
            {
                var anon = (from x in Estado.Estados()
                            where x.id == Program.Nori.UsuarioAutenticado.estado_id
                            select new { x.id, x.pais_id }).First();
                ((BaseEdit)cbPaises).EditValue = anon.pais_id;
                ((BaseEdit)cbEstados).EditValue = anon.id;
            }
            catch
            {
            }
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DataSource = (from x in Socio.Socios()
                                                                              where x.activo == true
                                                                              select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbSocios).EditValue = Program.Nori.UsuarioAutenticado.socio_id;
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DataSource = Documento.UsoCFDI.UsosCFDI();
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).ValueMember = "uso";
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DataSource = Documento.RegimenFiscal.RegimenesFiscales();
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).ValueMember = "clave";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DisplayMember = "nombre";
        }

        private void Cargar()
        {
            if (socio.id == 0)
            {
                Serie serie = Serie.ObtenerPredeterminado("SN");
                if (serie.id != 0)
                {
                    socio.codigo = serie.prefijo + serie.siguiente;
                    socio.serie_id = serie.id;
                    ((Control)(object)txtCodigo).Enabled = false;
                }
            }
            ((Control)(object)txtCodigo).Text = socio.codigo;
            ((Control)(object)txtNombre).Text = socio.nombre;
            ((Control)(object)txtNombreComercial).Text = socio.nombre_comercial;
            ((Control)(object)txtRFC).Text = socio.rfc;
            ((Control)(object)txtTelefono).Text = socio.telefono;
            ((Control)(object)txtTelefono2).Text = socio.telefono2;
            ((Control)(object)txtTelefonoCelular).Text = socio.celular;
            ((Control)(object)txtCorreo).Text = socio.correo;
            if (Program.Nori.UsuarioAutenticado.rol.Equals('C'))
            {
                socio.eventual = true;
            }
            cbEventual.Checked = socio.eventual;
            if (socio.socio_eventual_id != 0)
            {
                ((BaseEdit)cbSocios).EditValue = socio.socio_eventual_id;
            }
            ((BaseEdit)cbUsoPrincipal).EditValue = socio.uso_principal;
            ((BaseEdit)cbRegimenFiscal).EditValue = socio.regimen_fiscal;
            ((Control)(object)txtCodigo).Focus();
        }

        private bool Validar()
        {
            try
            {
                if (((Control)(object)txtCodigo).Text.Length == 0 || ((Control)(object)txtRFC).Text.Length == 0 || ((Control)(object)txtNombre).Text.Length == 0 || ((Control)(object)txtCalle).Text.Length == 0 || ((Control)(object)txtNumeroExterior).Text.Length == 0 || ((Control)(object)txtCiudad).Text.Length == 0 || ((Control)(object)txtCP).Text.Length == 0 || ((Control)(object)txtColonia).Text.Length == 0 || ((Control)(object)txtTelefono).Text.Length == 0 || ((Control)(object)txtCorreo).Text.Length == 0 || (int)((BaseEdit)cbPaises).EditValue == 0 || (int)((BaseEdit)cbEstados).EditValue == 0)
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
                socio.nombre_comercial = ((Control)(object)txtNombreComercial).Text;
                socio.rfc = ((Control)(object)txtRFC).Text;
                socio.uso_principal = ((BaseEdit)cbUsoPrincipal).EditValue.ToString();
                socio.regimen_fiscal = ((BaseEdit)cbRegimenFiscal).EditValue.ToString();
                socio.vendedor_id = Program.Nori.UsuarioAutenticado.vendedor_id;
                socio.eventual = cbEventual.Checked;
                try
                {
                    if (socio.eventual)
                    {
                        socio.socio_eventual_id = (int)((BaseEdit)cbSocios).EditValue;
                    }
                }
                catch
                {
                }
                socio.telefono = ((Control)(object)txtTelefono).Text;
                socio.telefono2 = ((Control)(object)txtTelefono2).Text;
                socio.celular = ((Control)(object)txtTelefonoCelular).Text;
                socio.correo = ((Control)(object)txtCorreo).Text;
                direccion.nombre = "Facturación";
                direccion.calle = ((Control)(object)txtCalle).Text;
                direccion.numero_exterior = ((Control)(object)txtNumeroExterior).Text;
                direccion.numero_interior = ((Control)(object)txtNumeroInterior).Text;
                direccion.cp = ((Control)(object)txtCP).Text;
                direccion.colonia = ((Control)(object)txtColonia).Text;
                direccion.ciudad = ((Control)(object)txtCiudad).Text;
                direccion.municipio = ((Control)(object)txtMunicipio).Text;
                direccion.estado_id = (int)((BaseEdit)cbEstados).EditValue;
                direccion.pais_id = (int)((BaseEdit)cbPaises).EditValue;
                try
                {
                    persona_contacto.codigo = (short)((from x in Socio.PersonaContacto.PersonasContacto()
                                                       select new { x.codigo } into x
                                                       orderby x.codigo descending
                                                       select x).First().codigo + 1);
                }
                catch
                {
                    persona_contacto.codigo = 1;
                }
                persona_contacto.nombre = ((Control)(object)txtCodigo).Text;
                persona_contacto.nombre_persona = ((Control)(object)txtNombre).Text;
                persona_contacto.telefono = ((Control)(object)txtTelefono).Text;
                persona_contacto.celular = ((Control)(object)txtTelefonoCelular).Text;
                persona_contacto.correo = ((Control)(object)txtCorreo).Text;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes && Llenar())
                {
                    bool flag = socio.id == 0;
                    if (socio.Agregar())
                    {
                        if (flag)
                        {
                            Serie serie = Serie.ObtenerPredeterminado("SN");
                            serie.EstablecerSiguiente();
                        }
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
                        socio.Actualizar(agregar_sincronizacion: false);
                        if (Program.Nori.Configuracion.netsuite)
                        {
                            CustomerHelper customerHelper = new CustomerHelper();
                            customerHelper.CreateCustomer(socio);
                        }
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void cbPaises_EditValueChanged(object sender, EventArgs e)
        {
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DataSource = from x in Estado.Estados()
                                                                              where x.pais_id == (int)((BaseEdit)cbPaises).EditValue
                                                                              select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DisplayMember = "nombre";
        }

        private void btnHuellaDigital_Click(object sender, EventArgs e)
        {
            if (Program.Nori.Estacion.lector_huella && MessageBox.Show("¿Desea agregar una huella digital?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NORI.HuellaDigital.frmHuellaDigitalAgregar frmHuellaDigitalAgregar = new NORI.HuellaDigital.frmHuellaDigitalAgregar();
                DialogResult dialogResult = ((Form)(object)frmHuellaDigitalAgregar).ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    persona_contacto.huella_digital = frmHuellaDigitalAgregar.huella_digital;
                }
            }
        }

        private void cbEventual_CheckedChanged(object sender, EventArgs e)
        {
            ((Control)(object)cbSocios).Visible = cbEventual.Checked;
        }

        private void frmAltaRapidaSocio_Load(object sender, EventArgs e)
        {
        }

   
    }

}
