using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace DTM
{
    public partial class frmDireccion : RibbonForm
    {
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

        private LabelControl lblNombre;

        private TextEdit txtNombre;

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

        private TextEdit txtCP;

        private LabelControl lblCP;

        private LabelControl lblReferencias;

        private TextEdit txtReferencias;

        private LabelControl lblEntreCalles;

        private TextEdit txtEntreCalles;

        private LabelControl lblDistancia;

        private TextEdit txtDistancia;

        public Socio.Direccion direccion { get; set; }

        public frmDireccion()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
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

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DataSource = from x in Pais.Paises()
                                                                             select new { x.id, x.nombre };
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbPaises).EditValue = 1;
        }

        private void Cargar()
        {
            ((Control)(object)txtNombre).Text = direccion.nombre;
            ((Control)(object)txtCalle).Text = direccion.calle;
            ((Control)(object)txtNumeroExterior).Text = direccion.numero_exterior;
            ((Control)(object)txtNumeroInterior).Text = direccion.numero_interior;
            ((Control)(object)txtCP).Text = direccion.cp;
            ((Control)(object)txtDistancia).Text = direccion.distancia.ToString();
            ((Control)(object)txtColonia).Text = direccion.colonia;
            ((Control)(object)txtCiudad).Text = direccion.ciudad;
            ((Control)(object)txtMunicipio).Text = direccion.municipio;
            ((Control)(object)txtEntreCalles).Text = direccion.entre_calles;
            ((Control)(object)txtReferencias).Text = direccion.referencias;
            ((BaseEdit)cbPaises).EditValue = direccion.pais_id;
            ((BaseEdit)cbEstados).EditValue = direccion.estado_id;
        }

        private void Llenar()
        {
            try
            {
                direccion.nombre = ((Control)(object)txtNombre).Text;
                direccion.calle = ((Control)(object)txtCalle).Text;
                direccion.numero_exterior = ((Control)(object)txtNumeroExterior).Text;
                direccion.numero_interior = ((Control)(object)txtNumeroInterior).Text;
                direccion.entre_calles = ((Control)(object)txtEntreCalles).Text;
                direccion.referencias = ((Control)(object)txtReferencias).Text;
                direccion.cp = ((Control)(object)txtCP).Text;
                direccion.distancia = int.Parse(((Control)(object)txtDistancia).Text);
                direccion.colonia = ((Control)(object)txtColonia).Text;
                direccion.ciudad = ((Control)(object)txtCiudad).Text;
                direccion.municipio = ((Control)(object)txtMunicipio).Text;
                direccion.estado_id = (int)((BaseEdit)cbEstados).EditValue;
                direccion.pais_id = (int)((BaseEdit)cbPaises).EditValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (direccion.id != 0)
                    {
                        return direccion.Actualizar();
                    }
                    return direccion.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
            ((BaseEdit)cbEstados).EditValue = 1;
        }

        private void frmDireccion_Load(object sender, EventArgs e)
        {
            Cargar();
        }


    }
}
