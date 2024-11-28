using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using EventHandler = DPFP.Capture.EventHandler;

namespace NORI.HuellaDigital
{
    public partial class frmHuellaDigital : RibbonForm, DPFP.Capture.EventHandler
    {
        private Capture Capturer;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private Label StatusLine;

        private TextBox StatusText;

        private TextBox Prompt;

        private PictureBox Picture;

        public string huella_digital { get; set; } = string.Empty;


        public frmHuellaDigital()
        {
            InitializeComponent();
            this.MetodoDinamico();
        }

        protected virtual void Init()
        {
            //IL_0003: Unknown result type (might be due to invalid IL or missing references)
            //IL_000d: Expected O, but got Unknown
            try
            {
                Capturer = new Capture();
                if (Capturer != null)
                {
                    Capturer.EventHandler = (EventHandler)(object)this;
                }
                else
                {
                    SetPrompt("¡No se pudo inicializar la operación de captura!");
                }
            }
            catch
            {
                MessageBox.Show("¡No se pudo inicializar la operación de captura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        protected virtual void Process(Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected void Start()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Lector de huella digital, coloque su huella en el lector.");
                }
                catch
                {
                    SetPrompt("Imposible iniciar la captura.");
                }
            }
        }

        protected void Stop()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("No se pudo finalizar la captura.");
                }
            }
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            try
            {
                MakeReport("La muestra de la huella ha sido capturada.");
                SetPrompt("Coloque nuevamente el mismo dedo en el lector.");
                Process(Sample);
            }
            catch
            {
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            try
            {
                MakeReport("El dedo ha sido removido del lector.");
            }
            catch
            {
            }
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            try
            {
                MakeReport("El dedo ha sido colocado.");
            }
            catch
            {
            }
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            try
            {
                MakeReport("Lector de huella digital conectado.");
            }
            catch
            {
            }
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            try
            {
                MakeReport("Lector de huella digital desconectado.");
            }
            catch
            {
            }
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            //IL_0002: Unknown result type (might be due to invalid IL or missing references)
            //IL_0004: Invalid comparison between Unknown and I4
            try
            {
                if ((int)CaptureFeedback == 0)
                {
                    MakeReport("La calidad de la muestra es buena.");
                }
                else
                {
                    MakeReport("La calidad de la muestra es deficiente.");
                }
            }
            catch
            {
            }
        }

        protected Bitmap ConvertSampleToBitmap(Sample Sample)
        {
            //IL_0002: Unknown result type (might be due to invalid IL or missing references)
            //IL_0008: Expected O, but got Unknown
            try
            {
                SampleConversion val = new SampleConversion();
                Bitmap result = null;
                val.ConvertToPicture(Sample, ref result);
                return result;
            }
            catch
            {
                return null;
            }
        }

        protected FeatureSet ExtractFeatures(Sample Sample, DataPurpose Purpose)
        {
            //IL_0002: Unknown result type (might be due to invalid IL or missing references)
            //IL_0008: Expected O, but got Unknown
            //IL_0009: Unknown result type (might be due to invalid IL or missing references)
            //IL_000a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0010: Expected O, but got Unknown
            //IL_0012: Unknown result type (might be due to invalid IL or missing references)
            //IL_001d: Unknown result type (might be due to invalid IL or missing references)
            //IL_001f: Invalid comparison between Unknown and I4
            try
            {
                FeatureExtraction val = new FeatureExtraction();
                CaptureFeedback val2 = (CaptureFeedback)1;
                FeatureSet result = new FeatureSet();
                val.CreateFeatureSet(Sample, Purpose, ref val2, ref result);
                if ((int)val2 == 0)
                {
                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        protected void SetStatus(string status)
        {
            ((Control)this).Invoke((Action)delegate
            {
                StatusLine.Text = status;
            });
        }

        protected void SetPrompt(string prompt)
        {
            ((Control)this).Invoke((Action)delegate
            {
                Prompt.Text = prompt;
            });
        }

        protected void MakeReport(string message)
        {
            ((Control)this).Invoke((Action)delegate
            {
                StatusText.AppendText(message + "\r\n");
            });
        }

        private void DrawPicture(Bitmap bitmap)
        {
            ((Control)this).Invoke((Action)delegate
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);
            });
        }

        private void frmHuellaDigital_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void frmHuellaDigital_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

}
}
