using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmImagen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmImagen()
        {
            InitializeComponent();

            // Crear el control PictureEdit

            // Establecer DockStyle para llenar el formulario
            pictureEdit1.Dock = DockStyle.Fill;

            // Agregar el PictureEdit al formulario
            this.Controls.Add(pictureEdit1);

            // Mostrar el diálogo para seleccionar el archivo de imagen
            OpenImageFileDialog();
        }

        private void OpenImageFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada
                LoadImage(openFileDialog.FileName);
            }
        }

        private void LoadImage(string filePath)
        {
            try
            {
                // Cargar la imagen en el PictureEdit
                pictureEdit1.Image = System.Drawing.Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }
    }
}