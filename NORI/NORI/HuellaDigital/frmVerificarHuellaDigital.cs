using DevExpress.XtraBars;
using NORI.HuellaDigital.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI.HuellaDigital
{
    public partial class frmVerificarHuellaDigital : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmVerificarHuellaDigital(AppData data)
        {
            InitializeComponent();
            Data = data;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        public void OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus Status)
        {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();

            // Compare feature set with all stored templates.
            foreach (DPFP.Template template in Data.Templates)
            {
                // Get template from storage.
                if (template != null)
                {
                    // Compare feature set with particular template.
                    ver.Verify(FeatureSet, template, ref res);
                    Data.IsFeatureSetMatched = res.Verified;
                    Data.FalseAcceptRate = res.FARAchieved;
                    if (res.Verified)
                        break; // success
                }
            }

            if (!res.Verified)
                Status = DPFP.Gui.EventHandlerStatus.Failure;

            Data.Update();
        }

        private AppData Data;
    }
}