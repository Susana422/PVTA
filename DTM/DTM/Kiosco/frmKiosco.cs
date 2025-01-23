using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using SDK;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DTM.Kiosco
{
    public partial class frmKiosco : RibbonForm
    {
        private Documento documento = new Documento();

        private IContainer components = null;

        private TextEdit txtNumeroDocumento;

        private SimpleButton btnFacturar;

        private SimpleButton btnLimpiar;

        private TextEdit txtPIN;

        private LabelControl lblPIN;

        private LabelControl lblDocumento;

        private LabelControl lblTitulo;

        private PictureBox pbLogo;

        public frmKiosco()
        {
            InitializeComponent();
            this.MetodoDinamico();
            ((Control)(object)lblTitulo).Text = Program.Nori.Empresa.nombre_comercial;
            ((Control)(object)txtNumeroDocumento).Focus();
            CargarImagenFondo();
        }

        private async void CargarImagenFondo()
        {
            Control ctrl = pbLogo;
            ctrl.SetImage(await Funciones.CargarImagen(Program.Nori.Empresa.logotipo));
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
            {
                ((Control)(object)txtPIN).Focus();
            }
        }

        private void BuscarDocumento(string NumeroDocumento, string PIN)
        {
            try
            {
                documento = Documento.Obtener(int.Parse(NumeroDocumento));
                Documento factura = new Documento();
                if (documento.id == 0)
                {
                    MessageBox.Show("Documento no encontrado.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ((Control)(object)txtNumeroDocumento).Focus();
                }
                else if (PIN != documento.pin.ToString())
                {
                    MessageBox.Show("El PIN no coincide con el del documento", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ((Control)(object)txtPIN).Text = string.Empty;
                    ((Control)(object)txtPIN).Focus();
                }
                else if (documento.clase == "EN" && documento.estado != 'C')
                {
                    if (!documento.cancelado)
                    {
                        factura.CopiarDe(documento, "FA");
                        if (factura.socio_id == (from x in Usuario.Usuarios()
                                                 where x.id == documento.usuario_creacion_id
                                                 select x.socio_id).First())
                        {
                            frmSocio frmSocio2 = new frmSocio();
                            ((Form)(object)frmSocio2).ShowDialog();
                            if (((Form)(object)frmSocio2).DialogResult != DialogResult.OK)
                            {
                                MessageBox.Show("No se generó la factura ya que no se ha establecido un socio válido", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                return;
                            }
                            Socio socio = Socio.Obtener(frmSocio2.codigo_socio);
                            factura.EstablecerSocio(socio);
                        }
                        if (factura.socio_id != documento.socio_id)
                        {
                            factura.partidas.All(delegate (Documento.Partida x)
                            {
                                x.documento_id = 0;
                                return true;
                            });
                        }
                        factura.generar_documento_electronico = factura.GenerarDocumentoElectronico();
                        if (factura.Agregar())
                        {
                            if (factura.socio_id == documento.socio_id)
                            {
                                documento.Cerrar();
                            }
                            else
                            {
                                documento.Cancelar(agregar_sincronizacion: true);
                            }
                            if (factura.DocumentoElectronico().id == 0)
                            {
                                if (!factura.generar_documento_electronico)
                                {
                                    MessageBox.Show("El documento aún no se ha timbrado por favor intente más tarde.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    return;
                                }
                                if (!Funciones.TimbrarDocumento(factura))
                                {
                                    string text = "Error desconocido.";
                                    try
                                    {
                                        text = (from x in DocumentoElectronico.DocumentosElectronicos()
                                                where x.documento_id == factura.id
                                                select new { x.mensaje }).First().mensaje;
                                    }
                                    catch
                                    {
                                    }
                                    MessageBox.Show("Ocurrió un error al timbrar la factura: " + text, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                            }
                            Funciones.ImprimirInformePredeterminado(factura.clase, factura.id);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al tratar de hacer la factura: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta remisión no se puede facturar ya que se encuentra cancelada.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    Funciones.ImprimirInformePredeterminado(documento.clase, documento.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((BaseButton)btnLimpiar).PerformClick();
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            BuscarDocumento(((Control)(object)txtNumeroDocumento).Text, ((Control)(object)txtPIN).Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ((Control)(object)txtNumeroDocumento).Text = string.Empty;
            ((Control)(object)txtPIN).Text = string.Empty;
            ((Control)(object)txtNumeroDocumento).Focus();
        }

        private void txtPIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                BuscarDocumento(((Control)(object)txtNumeroDocumento).Text, ((Control)(object)txtPIN).Text);
            }
            if (e.KeyCode == Keys.Tab)
            {
                ((Control)(object)btnFacturar).Focus();
            }
        }

        private void txtNumeroDocumento_Enter(object sender, EventArgs e)
        {
            Funciones.AbrirTecladoTactil();
        }
    }
}
