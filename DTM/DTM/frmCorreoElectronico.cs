using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmCorreoElectronico : XtraForm
    {
        public List<Usuario.CorreoElectronico> correos_electronicos = new List<Usuario.CorreoElectronico>();

        public Usuario.CorreoElectronico correo_electronico = new Usuario.CorreoElectronico();

        private IContainer components = null;

        private PanelControl panel1;

        private TextEdit txtAsunto;

        private LabelControl lblAsunto;

        private LabelControl lblMensaje;

        private MemoEdit txtMensaje;

        private CheckedListBoxControl lbDestinatarios;

        private LabelControl lblDestinatarios;

        private TextEdit txtDestinatario;

        private LabelControl lblDestinatario;

        private LabelControl lblAnexos;

        private CheckedListBoxControl lbAnexos;

        private Button btnEnviar;

        private Button btnAnexo;

        private LabelControl lblCorreoElectronico;

        private LookUpEdit cbCorreoElectronico;

        public Socio socio { get; set; } = new Socio();


        public List<string> anexos { get; set; } = new List<string>();


        public int documento_id { get; set; }

        public frmCorreoElectronico()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
        }

        private void CargarListas()
        {
            try
            {
                correos_electronicos = (from x in Usuario.CorreoElectronico.CorreosElectronicos()
                                        where x.usuario_id == Program.dtm.UsuarioAutenticado.id && x.activo == true
                                        select x).ToList();
                ((RepositoryItemLookUpEditBase)cbCorreoElectronico.Properties).DataSource = correos_electronicos;
                ((RepositoryItemLookUpEditBase)cbCorreoElectronico.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbCorreoElectronico.Properties).DisplayMember = "usuario";
                ((BaseEdit)cbCorreoElectronico).EditValue = correos_electronicos.First().id;
            }
            catch
            {
            }
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ((ListBoxItemCollection)((BaseCheckedListBoxControl)lbAnexos).Items).Add((object)openFileDialog.FileName);
            }
        }

        public bool EnviarCorreo()
        {
            try
            {
                string[] array = ((Control)(object)txtDestinatario).Text.Replace(" ", string.Empty).Split(';');
                SmtpClient smtpClient = new SmtpClient();
                MailMessage mailMessage = new MailMessage(correo_electronico.usuario, array[0], ((Control)(object)txtAsunto).Text, ((Control)(object)txtMensaje).Text);
                smtpClient.Port = correo_electronico.puerto;
                smtpClient.Host = correo_electronico.servidor;
                smtpClient.EnableSsl = correo_electronico.ssl;
                smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(correo_electronico.usuario, correo_electronico.contraseña);
                if (correo_electronico.remitente.Length > 0)
                {
                    mailMessage.From = new MailAddress(correo_electronico.usuario, correo_electronico.remitente);
                }
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string[] array2 = array;
                foreach (string addresses in array2)
                {
                    mailMessage.CC.Add(addresses);
                }
                foreach (string item in (from x in (IEnumerable<CheckedListBoxItem>)((BaseCheckedListBoxControl)lbDestinatarios).Items
                                         where x.CheckState == CheckState.Checked
                                         select ((ListBoxItem)x).Value).ToList())
                {
                    mailMessage.CC.Add(item);
                }
                foreach (string item2 in (from x in (IEnumerable<CheckedListBoxItem>)((BaseCheckedListBoxControl)lbAnexos).Items
                                          where x.CheckState == CheckState.Checked
                                          select ((ListBoxItem)x).Value).ToList())
                {
                    mailMessage.Attachments.Add(new Attachment(item2));
                }
                smtpClient.Send(mailMessage);
                if (documento_id != 0)
                {
                    Documento documento = Documento.Obtener(documento_id);
                    documento.Enviado();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void frmCorreoElectronico_Load(object sender, EventArgs e)
        {
            ((Control)(object)txtDestinatario).Text = socio.correo;
            foreach (Socio.PersonaContacto item in socio.PersonasContacto())
            {
                ((ListBoxItemCollection)((BaseCheckedListBoxControl)lbDestinatarios).Items).Add((object)item.correo);
            }
            foreach (string anexo in anexos)
            {
                ((ListBoxItemCollection)((BaseCheckedListBoxControl)lbAnexos).Items).Add((object)anexo);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (EnviarCorreo())
            {
                MessageBox.Show("Mensaje enviado");
                ((Form)this).Close();
            }
        }

        private void cbCorreoElectronico_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                correo_electronico = correos_electronicos.Where((Usuario.CorreoElectronico x) => x.id == (int)((BaseEdit)cbCorreoElectronico).EditValue).First();
                CargarCorreoElectronico();
            }
            catch
            {
            }
        }

        private void CargarCorreoElectronico()
        {
            ((Control)(object)txtAsunto).Text = correo_electronico.asunto;
            ((Control)(object)txtMensaje).Text = correo_electronico.mensaje;
        }


    }

}
