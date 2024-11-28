using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DPFP;
using DPFP.Processing;
using DPFP.Verification;
using static DPFP.Processing.Enrollment;
using static DPFP.Verification.Verification;


namespace NORI.HuellaDigital
{
    public partial class frmHuellaDigitalVerificar : frmHuellaDigital
    {
        private int enrolls = 1;

        private Template Template;

        private Verification Verificator;

        public void Verify(Template template)
        {
            Template = template;
            ((Form)(object)this).ShowDialog();
        }

        protected override void Init()
        {
            //IL_003d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0043: Expected O, but got Unknown
            //IL_0059: Unknown result type (might be due to invalid IL or missing references)
            //IL_0063: Expected O, but got Unknown
            try
            {
                base.Init();
                ((RibbonForm)this).Text = ((Control)(object)this).Text;
                using (FileStream fileStream = File.OpenRead(Program.Nori.Configuracion.directorio_huellas + "\\" + base.huella_digital))
                {
                    Template template = new Template((Stream)fileStream);
                    Template = template;
                }
                Verificator = new Verification();
                SetStatus("Coloque su huella dactilar en el lector.");
            }
            catch
            {
            }
        }

        protected override void Process(Sample Sample)
        {
            //IL_001c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0022: Expected O, but got Unknown
            try
            {
                base.Process(Sample);
                FeatureSet val = ExtractFeatures(Sample, (DataPurpose)1);
                if (val != null)
                {
                    Result val2 = new Result();
                    Verificator.Verify(val, Template, ref val2);
                    if (val2.Verified)
                    {
                        ((Form)(object)this).DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        SetStatus("Verificación(es) incorrecta(s) (" + enrolls + ")");
                    }
                    enrolls++;
                }
            }
            catch
            {
            }
        }
    }

}
