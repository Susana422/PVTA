using System;
using System.Drawing;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmResaltarImagen : Form
    {
        private float zoomFactor = 1.2f;  // Factor de zoom (1.2 es un 20% de aumento)
        private float currentZoom = 1.0f; // Factor de zoom actual
        private PictureBox pictureBoxZoom;
        public frmResaltarImagen(Image image)
        {
            try
            {
                InitializeComponent();
                this.WindowState = FormWindowState.Maximized;
                pictureEdit1.Dock = DockStyle.Fill;
                pictureEdit1.Image = image;
                SetUpEditors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible maximizar esta iamgen");
            }

        }
        private void SetUpEditors()
        {
            try
            {

                pictureEdit1.Properties.ReadOnly = true;
                // pictureEdit1.Properties.ShowMenu = false;
                pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Never;
                pictureEdit1.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
                pictureEdit1.Properties.AllowScrollViaMouseDrag = true;
                pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
                pictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
                pictureEdit1.Properties.ShowScrollBars = true;
            }
            catch (Exception ex)
            {
            }


        }
    }
}
