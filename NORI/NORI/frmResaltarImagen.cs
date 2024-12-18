using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NoriSDK.Articulo;

namespace NORI
{
    public partial class frmResaltarImagen : Form
    {
        private float zoomFactor = 1.2f;  // Factor de zoom (1.2 es un 20% de aumento)
        private float currentZoom = 1.0f; // Factor de zoom actual
        private PictureBox pictureBoxZoom;
        public frmResaltarImagen(Image image)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pictureBoxZoom = new PictureBox();
            pictureBoxZoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxZoom.Image = image;
           // pictureBoxZoom.Location = new Point(120, 10); // Ubicación en el formulario
            pictureBoxZoom.Size = new Size(image.Width, image.Height); // Tamaño inicial de la imagen

            // Agregar el PictureBox al formulario para que se muestre
            this.Controls.Add(pictureBoxZoom);

            // Centrar el PictureBox en el formulario
            CenterPictureBox();

            // Habilitar los eventos de ratón para el PictureBox y el formulario
            pictureBoxZoom.MouseDoubleClick += pictureBoxZoom_MouseDoubleClick;
            pictureBoxZoom.MouseClick += pictureBoxZoom_MouseClick;

            // Habilitar el evento MouseWheel para el formulario
            this.MouseWheel += new MouseEventHandler(Form_MouseWheel);
        }

        // Evento MouseWheel para hacer zoom utilizando la rueda del ratón
        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            // Detectamos si la rueda del ratón se mueve hacia arriba (zoom in) o hacia abajo (zoom out)
            if (e.Delta > 0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }

        // Función para hacer Zoom In
        private void ZoomIn()
        {
            currentZoom *= zoomFactor; // Aumentar el factor de zoom
            ApplyZoom();
        }

        // Función para hacer Zoom Out
        private void ZoomOut()
        {
            currentZoom /= zoomFactor; // Reducir el factor de zoom
            ApplyZoom();
        }

        // Aplicar el zoom ajustando el tamaño del PictureBox
        private void ApplyZoom()
        {
            // Calcula el nuevo tamaño basado en el factor de zoom
            int newWidth = (int)(pictureBoxZoom.Image.Width * currentZoom);
            int newHeight = (int)(pictureBoxZoom.Image.Height * currentZoom);

            // Establece el nuevo tamaño del PictureBox para que se ajuste a la imagen escalada
            pictureBoxZoom.Size = new Size(newWidth, newHeight);

            // Centrar el PictureBox después de ajustar su tamaño
            CenterPictureBox();
        }

        // Función para centrar el PictureBox en el formulario
        private void CenterPictureBox()
        {
            // Calcular las coordenadas para centrar el PictureBox
            int x = (this.ClientSize.Width - pictureBoxZoom.Width) / 2;
            int y = (this.ClientSize.Height - pictureBoxZoom.Height) / 2;

            // Establecer la ubicación del PictureBox
            pictureBoxZoom.Location = new Point(x, y);
        }

        // Evento MouseDoubleClick para hacer zoom in al hacer doble clic en el PictureBox
        private void pictureBoxZoom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ZoomIn();
        }

        // Evento MouseClick para hacer zoom out al hacer clic derecho en el PictureBox
        private void pictureBoxZoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ZoomOut();
            }
        }
    }
}
