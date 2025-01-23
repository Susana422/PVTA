using System;
using System.Drawing;
using System.Windows.Forms;

namespace DTM
{
    public static class Extensiones
    {
        public static void SetImage(this Control ctrl, Image img)
        {
            try
            {
                if (img == null)
                {
                    return;
                }
                Size size = ctrl.Size;
                if (img.Size != size)
                {
                    float ratio = Math.Max((float)size.Height / (float)img.Height, (float)size.Width / (float)img.Width);
                    if (ratio > 1f)
                    {
                        Func<float, int> func = (float f) => (int)Math.Ceiling(f * ratio);
                        img = new Bitmap(img, func(img.Width), func(img.Height));
                    }
                    img = ScaleImage(img, size.Width / 2, size.Height / 2);
                }
                ctrl.BackgroundImageLayout = ImageLayout.Center;
                ctrl.BackgroundImage = img;
            }
            catch
            {
            }
        }

        public static async void LoadImage(this PictureBox pb, string ruta)
        {
            try
            {
                pb.Image = await Funciones.CargarImagen(ruta);
            }
            catch
            {
            }
        }

        public static async void LoadImage(this Button btn, string ruta)
        {
            try
            {
                btn.BackgroundImage = await Funciones.CargarImagen(ruta);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (btn.BackgroundImage != null)
                {
                    ToolTip tt = new ToolTip();
                    tt.SetToolTip(btn, btn.Text);
                    btn.Text = string.Empty;
                }
            }
            catch
            {
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            double val = (double)maxWidth / (double)image.Width;
            double val2 = (double)maxHeight / (double)image.Height;
            double num = Math.Min(val, val2);
            int width = (int)((double)image.Width * num);
            int height = (int)((double)image.Height * num);
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return bitmap;
        }
    }
}
