using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmEmpresa : RibbonForm
    {
        private Empresa empresa = new Empresa();

        private IContainer components = null;

        private DataLayoutControl dataLayoutControl1;

        private RibbonControl mainRibbonControl;

        private BackstageViewControl backstageViewControl1;

        private BarButtonItem bbiGuardar;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private TabPane tabPane1;

        private TabNavigationPage tabNavigationPageGeneral;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private TextEdit txtNombreFiscal;

        private LabelControl lblNombreFiscal;

        private TextEdit txtNombreComercial;

        private LabelControl lblNombreComercial;

        private TextEdit txtEslogan;

        private LabelControl lblEslogan;

        private TextEdit txtRFC;

        private LabelControl lblRFC;

        private SimpleButton btnImagen;

        private PictureBox pbImagen;

        private LookUpEdit cbTipo;

        private LabelControl lblTipo;

        private TextEdit txtTelefono;

        private LabelControl lblTelefono;

        private TextEdit txtRegimenFiscal;

        private LabelControl lblRegimenFiscal;

        private TextEdit txtTelefono2;

        private LabelControl lblTelefono2;

        private LabelControl lblSitioWeb;

        private TextEdit txtSitioWeb;

        private LabelControl lblCorreo;

        private TextEdit txtCorreo;

        private TabNavigationPage tabNavigationPageDireccion;

        private LabelControl lblCiudad;

        private TextEdit txtCiudad;

        private TextEdit txtColonia;

        private LabelControl lblColonia;

        private TextEdit txtNumeroInterior;

        private LabelControl lblNumeroInterior;

        private TextEdit txtNumeroExterior;

        private LabelControl lblNumeroExterior;

        private TextEdit txtCalle;

        private LabelControl lblCalle;

        private TextEdit txtCP;

        private LabelControl lblCP;

        private LabelControl lblPais;

        private TextEdit txtPais;

        private LabelControl lblEstado;

        private TextEdit txtEstado;

        private LabelControl lblMunicipio;

        private TextEdit txtMunicipio;

        private TextEdit txtLugarExpedicion;

        private LabelControl lblLugarExpedicion;

        public frmEmpresa()
        {
            InitializeComponent();
            this.MetodoDinamico();
            empresa = Empresa.Obtener();
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).DataSource = Empresa.TipoPersona.Tipos();
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbTipo).EditValue = Empresa.TipoPersona.ObtenerPredeterminado();
            Cargar();
        }

        private void Cargar()
        {
            ((Control)(object)txtNombreFiscal).Text = empresa.nombre_fiscal;
            ((Control)(object)txtNombreComercial).Text = empresa.nombre_comercial;
            ((Control)(object)txtEslogan).Text = empresa.eslogan;
            ((Control)(object)txtRFC).Text = empresa.rfc;
            ((Control)(object)txtRegimenFiscal).Text = empresa.regimen_fiscal;
            ((BaseEdit)cbTipo).EditValue = empresa.tipo_persona;
            ((Control)(object)txtLugarExpedicion).Text = empresa.lugar_expedicion;
            ((Control)(object)txtTelefono).Text = empresa.telefono;
            ((Control)(object)txtTelefono2).Text = empresa.telefono2;
            ((Control)(object)txtCorreo).Text = empresa.correo;
            ((Control)(object)txtSitioWeb).Text = empresa.sitio_web;
            ((Control)(object)txtCalle).Text = empresa.calle;
            ((Control)(object)txtColonia).Text = empresa.colonia;
            ((Control)(object)txtNumeroExterior).Text = empresa.numero_exterior;
            ((Control)(object)txtNumeroInterior).Text = empresa.numero_interior;
            ((Control)(object)txtCP).Text = empresa.cp;
            ((Control)(object)txtCiudad).Text = empresa.ciudad;
            ((Control)(object)txtMunicipio).Text = empresa.municipio;
            ((Control)(object)txtEstado).Text = empresa.estado;
            ((Control)(object)txtPais).Text = empresa.pais;
            pbImagen.LoadImage(empresa.logotipo);
            ((Control)(object)lblFechaActualizacion).Text = empresa.fecha_actualizacion.ToShortDateString();
        }

        private void Llenar()
        {
            empresa.nombre_fiscal = ((Control)(object)txtNombreFiscal).Text;
            empresa.nombre_comercial = ((Control)(object)txtNombreComercial).Text;
            empresa.eslogan = ((Control)(object)txtEslogan).Text;
            empresa.rfc = ((Control)(object)txtRFC).Text;
            empresa.regimen_fiscal = ((Control)(object)txtRegimenFiscal).Text;
            empresa.tipo_persona = (char)((BaseEdit)cbTipo).EditValue;
            empresa.lugar_expedicion = ((Control)(object)txtLugarExpedicion).Text;
            empresa.telefono = ((Control)(object)txtTelefono).Text;
            empresa.telefono2 = ((Control)(object)txtTelefono2).Text;
            empresa.correo = ((Control)(object)txtCorreo).Text;
            empresa.sitio_web = ((Control)(object)txtSitioWeb).Text;
            empresa.calle = ((Control)(object)txtCalle).Text;
            empresa.colonia = ((Control)(object)txtColonia).Text;
            empresa.numero_exterior = ((Control)(object)txtNumeroExterior).Text;
            empresa.numero_interior = ((Control)(object)txtNumeroInterior).Text;
            empresa.cp = ((Control)(object)txtCP).Text;
            empresa.ciudad = ((Control)(object)txtCiudad).Text;
            empresa.municipio = ((Control)(object)txtMunicipio).Text;
            empresa.estado = ((Control)(object)txtEstado).Text;
            empresa.pais = ((Control)(object)txtPais).Text;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (empresa.id != 0)
                    {
                        return empresa.Actualizar();
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

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Por favor seleccione una imagen.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = Program.Nori.Configuracion.directorio_imagenes + "\\" + openFileDialog.SafeFileName;
                File.Copy(openFileDialog.FileName, text, overwrite: true);
                pbImagen.Image = new Bitmap(text);
                empresa.logotipo = openFileDialog.SafeFileName;
            }
        }


    }

}
