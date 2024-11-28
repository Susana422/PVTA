using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DPFP;
using DPFP.Processing;
using static DPFP.Processing.Enrollment;




namespace NORI.HuellaDigital
{
    public class frmHuellaDigitalAgregar : frmHuellaDigital
    {
        public delegate void OnTemplateEventHandler(Template template);

        private Enrollment Enroller;

        private Template Template;

        protected override void Init()
        {
            //IL_0016: Unknown result type (might be due to invalid IL or missing references)
            //IL_0020: Expected O, but got Unknown
            try
            {
                base.Init();
                ((RibbonForm)this).Text = "Agregar huella digital";
                Enroller = new Enrollment();
                UpdateStatus();
            }
            catch
            {
            }
        }

        protected override void Process(Sample Sample)
        {
            //IL_0049: Unknown result type (might be due to invalid IL or missing references)
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_004f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0050: Unknown result type (might be due to invalid IL or missing references)
            //IL_0051: Unknown result type (might be due to invalid IL or missing references)
            //IL_0053: Invalid comparison between Unknown and I4
            //IL_0057: Unknown result type (might be due to invalid IL or missing references)
            //IL_0059: Invalid comparison between Unknown and I4
            try
            {
                base.Process(Sample);
                FeatureSet val = ExtractFeatures(Sample, (DataPurpose)2);
                if (val == null)
                {
                    return;
                }
                try
                {
                    MakeReport("Se creó el conjunto de características de huellas dactilares.");
                    Enroller.AddFeatures(val);
                }
                finally
                {
                    UpdateStatus();
                    Status templateStatus = Enroller.TemplateStatus;
                    Status val2 = templateStatus;
                    if ((int)val2 != 2)
                    {
                        if ((int)val2 == 3)
                        {
                            OnTemplate(Enroller.Template);
                            Stop();
                        }
                    }
                    else
                    {
                        Enroller.Clear();
                        Stop();
                        UpdateStatus();
                        OnTemplate(null);
                        Start();
                    }
                }
            }
            catch
            {
            }
        }

        private void UpdateStatus()
        {
            SetStatus($"Muestras requeridas: {Enroller.FeaturesNeeded}");
        }

        private void OnTemplate(Template template)
        {
            try
            {
                Template = template;
                if (Template != null)
                {
                    string text = DateTime.Now.Ticks + ".pft";
                    string path = Program.Nori.Configuracion.directorio_huellas + "\\" + text;
                    using (FileStream fileStream = File.Open(path, FileMode.Create, FileAccess.Write))
                    {
                        ((Data)Template).Serialize((Stream)fileStream);
                        base.huella_digital = text;
                    }
                    MessageBox.Show("Se guardó correctamente la muestra de la huella digital.");
                    ((Form)(object)this).DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("La muestra de la huella digital es invalida, por favor repita el proceso.");
                }
            }
            catch
            {
            }
        }
    }

}
