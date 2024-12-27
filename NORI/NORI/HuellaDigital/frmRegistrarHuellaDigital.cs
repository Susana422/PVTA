using DevExpress.XtraBars;
using NORI.HuellaDigital;
using NORI.HuellaDigital.Class;
using NORI.PuntoVenta;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmRegistrarHuellaDigital : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private List<String> ListEvents = new List<string>();
        private AppData Data;
        private Usuario usuario = new Usuario();
        private NoriSDK.HuellaDigital huellaDigital = new NoriSDK.HuellaDigital();
        public frmRegistrarHuellaDigital(AppData data,Usuario user)
        {
            InitializeComponent();
        
            usuario = user;
            Data = data;
            //ExchangeData(true);                                 
            Data.OnChange += delegate { ExchangeData(false); };
            cargarHuellaDigital(user);
        }

        public void cargarHuellaDigital(Usuario user) {
            try
            {
                ExchangeData(true);
                List<NoriSDK.HuellaDigital> huellas = NoriSDK.HuellaDigital.ObtenerUser(usuario.id);
                foreach (var x in huellas) 
                {
                    DPFP.Template template = DeserializeTemplate(x.huella);
                    // Ajusta el índice para manejar correctamente el mapeo de la mano
                    int rol = x.EnrolledFingersMask;

                    // Ajuste para invertir el mapeo de la mano (si es necesario)
                    // Si el dedo es de la mano derecha (0-4), lo asignamos a la mano izquierda (5-9)
                    if (rol >= 0 && rol <= 4)
                    {
                      
                        if (rol == 4) {
                            rol = 5 + rol;
                        }
                        else{
                            rol = 4 + rol; // Cambiar de mano derecha (0-4) a izquierda (5-9)
                        }
         
                    }
                    else if (rol >= 5 && rol <= 9)
                    {
                        rol = 9 - rol; // Cambiar de mano izquierda (5-9) a derecha (0-4)
                    }

                    Data.Templates[rol] = template;
                    Data.EnrolledFingersMask |= (1 << rol);
                }
                EnrollmentControl.EnrolledFingerMask = Data.EnrolledFingersMask;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible cargar su huella digital");
            }
        }
        private void ActualizarUI()
        {
            Control[] fingerUIElements = new Control[Data.MaxEnrollFingerCount]; 

            for (int i = 0; i < Data.MaxEnrollFingerCount; i++)
            {
                fingerUIElements[i] = this.Controls["FingerControl" + i];
            }
            for (int i = 0; i < Data.MaxEnrollFingerCount; i++)
            {
                try
                {
                    if ((EnrollmentControl.EnrolledFingerMask & (1 << i)) != 0)
                    {
                        if (fingerUIElements[i] != null)
                        {
                            fingerUIElements[i].BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (fingerUIElements[i] != null)
                        {
                            fingerUIElements[i].BackColor = Color.Gray;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el dedo {i}: {ex.Message}");
                }
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
        public void ExchangeData(bool read)
        {
            if (read)
            {
                Data.EnrolledFingersMask = EnrollmentControl.EnrolledFingerMask;
                Data.MaxEnrollFingerCount = EnrollmentControl.MaxEnrollFingerCount;
                Data.Update();
            }
            else
            {
                EnrollmentControl.EnrolledFingerMask = Data.EnrolledFingersMask;
                EnrollmentControl.MaxEnrollFingerCount = Data.MaxEnrollFingerCount;
            }
        }

        public void Exc() {
            Data.EnrolledFingersMask = 0;
            Data.MaxEnrollFingerCount = 10;
            Data.IsEventHandlerSucceeds = true;
            Data.Update();
        }

      
        public void EnrollmentControl_OnEnroll(Object Control, int Finger, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus Status)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                // Asigna la plantilla corregida
                Data.Templates[Finger - 1] = Template;
                ExchangeData(true);
                string templateBytes = SerializeTemplate(Template);
                huellaDigital = new NoriSDK.HuellaDigital();
                huellaDigital.usuario_id = usuario.id;
                huellaDigital.huella = templateBytes;
                huellaDigital.EnrolledFingersMask = Finger - 1;
                Guardar();
            }
            else
                Status = DPFP.Gui.EventHandlerStatus.Failure;   // force a "failure" status
        }
        public void Guardar() {
            if (huellaDigital.Agregar())
            {
                MessageBox.Show("La huella digital fue guardada correctamente");
            }
            else {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
            }
        }
        public void Eliminar(int id)
        {
            if (huellaDigital.Eliminar(id))
            {
                MessageBox.Show("La huella digital fue guardada correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
            }
        }

        public string SerializeTemplate(DPFP.Template template)
        {
            using (var ms = new MemoryStream())
            {
                template.Serialize(ms); 
                byte[] templateBytes = ms.ToArray(); 
                return Convert.ToBase64String(templateBytes); 
            }
        }
      
        public void EnrollmentControl_OnDelete(Object Control, int Finger, ref DPFP.Gui.EventHandlerStatus Status)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Data.Templates[Finger - 1] = null;
                ExchangeData(true);               

                ListEvents.Add(String.Format("OnDelete: finger {0}", Finger));
            }
            else
                Status = DPFP.Gui.EventHandlerStatus.Failure;
        }

        private void EnrollmentControl_OnCancelEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Add(String.Format("OnCancelEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnReaderConnect(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Add(String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnReaderDisconnect(object Control, string ReaderSerialNumber, int Finger)
        {
            try
            {
                if (Finger !=0) {
                    ListEvents.Add(String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger));
                }
                else {
                    MessageBox.Show("Verifique su lector de Huella Digital ya que se encuentra desconectado");
                }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique su lector de Huella Digital ya que se encuentra desconectado" +ex.Message);
            }
          
        }

        private void EnrollmentControl_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            string dedo = ObtenerNombreDedo(Finger);
            ListEvents.Add(String.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
        }
        private string ObtenerNombreDedo(int finger)
        {
            string[] nombresDedos = {
        "Meñique derecho", // 1
        "Anular derecho",  // 2
        "Medio derecho",   // 3
        "Índice derecho",  // 4
        "Pulgar derecho",  // 5
        "Pulgar izquierdo",// 6
        "Índice izquierdo",// 7
        "Medio izquierdo", // 8
        "Anular izquierdo",// 9
        "Meñique izquierdo"// 10
    };

            // Verifica que el índice sea válido
            if (finger > 0 && finger <= nombresDedos.Length)
                return nombresDedos[finger - 1]; // Ajusta el índice basado en la posición del array

            return "Índice desconocido";
        }

        private void EnrollmentControl_OnFingerRemove(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Add(String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnFingerTouch(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Add(String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnSampleQuality(object Control, string ReaderSerialNumber, int Finger, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            ListEvents.Add(String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback));
        }

        private void EnrollmentControl_OnComplete(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Add(String.Format("OnComplete: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            frmVerificarHuellaDigital frmVerificarHuellaDigital = new frmVerificarHuellaDigital(Data);
            ((Form)(object)frmVerificarHuellaDigital).ShowDialog();
        }
    }
}