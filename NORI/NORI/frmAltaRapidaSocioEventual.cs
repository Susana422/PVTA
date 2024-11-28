using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
    public partial class frmAltaRapidaSocioEventual : RibbonForm
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

        private LabelControl lblCorreo;

        private TextEdit txtCorreo;

        private LabelControl lblRFC;

        private TextEdit txtRFC;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblCP;

        private TextEdit txtCP;

        private LookUpEdit cbUsoPrincipal;

        private LabelControl lblUsoPrincipal;

        private LabelControl lblRegimenFiscal;

        private LookUpEdit cbRegimenFiscal;

        public frmAltaRapidaSocioEventual()
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
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
                }
            }
            else
            {
                MessageBox.Show("La información del socio no esta completa.");
            }
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DataSource = Documento.UsoCFDI.UsosCFDI();
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).ValueMember = "uso";
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DataSource = Documento.RegimenFiscal.RegimenesFiscales();
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).ValueMember = "clave";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DisplayMember = "nombre";
        }

        private void Cargar()
        {
            ((Control)(object)txtNombre).Text = socio.nombre;
            ((Control)(object)txtRFC).Text = socio.rfc;
            ((Control)(object)txtCorreo).Text = socio.correo;
            ((BaseEdit)cbUsoPrincipal).EditValue = socio.uso_principal;
            ((BaseEdit)cbRegimenFiscal).EditValue = socio.regimen_fiscal;
            ((ContainerControl)this).ActiveControl = (Control)(object)txtRFC;
            ((Control)(object)txtRFC).Focus();
        }

        private bool Validar()
        {
            try
            {
                if (((Control)(object)txtRFC).Text.Length == 0 || ((Control)(object)txtNombre).Text.Length == 0 || ((Control)(object)txtCorreo).Text.Length == 0)
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
                if (socio.id == 0)
                {
                    Serie serie = Serie.ObtenerPredeterminado("SN");
                    if (serie.id != 0)
                    {
                        socio.codigo = serie.prefijo + serie.siguiente;
                        socio.serie_id = serie.id;
                    }
                    else
                    {
                        socio.codigo = ((Control)(object)txtRFC).Text;
                    }
                }
                socio.nombre = ((Control)(object)txtNombre).Text;
                socio.rfc = ((Control)(object)txtRFC).Text;
                socio.uso_principal = ((BaseEdit)cbUsoPrincipal).EditValue.ToString();
                socio.regimen_fiscal = ((BaseEdit)cbRegimenFiscal).EditValue.ToString();
                socio.vendedor_id = Program.Nori.UsuarioAutenticado.vendedor_id;
                socio.eventual = true;
                socio.socio_eventual_id = Program.Nori.UsuarioAutenticado.socio_id;
                socio.correo = ((Control)(object)txtCorreo).Text;
                direccion.nombre = "Facturación";
                direccion.calle = "";
                direccion.numero_exterior = "";
                direccion.cp = ((Control)(object)txtCP).Text;
                direccion.colonia = "";
                direccion.ciudad = "";
                direccion.municipio = "";
                direccion.estado_id = Program.Nori.UsuarioAutenticado.estado_id;
                Estado estado = Estado.Obtener(direccion.estado_id);
                direccion.pais_id = estado.pais_id;
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
                persona_contacto.nombre = socio.codigo;
                persona_contacto.nombre_persona = ((Control)(object)txtNombre).Text;
                persona_contacto.telefono = "";
                persona_contacto.celular = "";
                persona_contacto.correo = ((Control)(object)txtCorreo).Text;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes && Llenar() && socio.Agregar())
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
                    socio.Actualizar(agregar_sincronizacion: false);
                    if (Program.Nori.Configuracion.netsuite)
                    {
                        CustomerHelper customerHelper = new CustomerHelper();
                        customerHelper.CreateCustomer(socio);
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
                return false;
            }
        }


    }

}
