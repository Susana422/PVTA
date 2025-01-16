using DevExpress.XtraLayout;
using NetsuiteLibrary.SuiteTalk;
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
    public partial class frmVPram : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DataTable dtControles;  // DataTable para almacenar los detalles de los controles clickeados

        public frmVPram()
        {
            InitializeComponent();
            InicializarDataTable();
            RegistrarEventosDeClic();
            this.Click += new EventHandler(FormVistaPrevia_Click);
            // Eliminamos esta línea, ya no necesitamos asignar el evento al panel
            // this.panel1.Click += new EventHandler(FormVistaPrevia_Click);
            // Habilitamos el panel para que los clics sean capturados
            this.Click += new EventHandler(FormVistaPrevia_Click);
            this.MouseDown += new MouseEventHandler(FormVistaPrevia_MouseDown);
        }
        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Se hizo clic en el panel");
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Se hizo clic en el panel (MouseDown)");
        }

        private void InicializarDataTable()
        {
            // Crear un DataTable con columnas para almacenar los detalles de los controles
            dtControles = new DataTable();
            dtControles.Columns.Add("ControlName", typeof(string));
            dtControles.Columns.Add("ControlType", typeof(string));
            dtControles.Columns.Add("ControlValue", typeof(string));
        }
        private void FormVistaPrevia_MouseDown(object sender, MouseEventArgs e)
        {
            
                MessageBox.Show("Se hizo clic en el panel desde el formulario (MouseDown)");
            
        }

        private string ObtenerValorDelControl(Control control)
        {
            // Intentar obtener el texto si el control tiene una propiedad Text
            var textProperty = control.GetType().GetProperty("Text");
            if (textProperty != null)
            {
                try
                {
                    return textProperty.GetValue(control, null)?.ToString() ?? "No tiene texto";
                }
                catch (Exception)
                {
                    return "Error al obtener el texto";
                }
            }

            // Intentar obtener el valor Checked si es un CheckBox
            var checkedProperty = control.GetType().GetProperty("Checked");
            if (checkedProperty != null)
            {
                return checkedProperty.GetValue(control, null)?.ToString() ?? "No tiene valor Checked";
            }

            return "Valor desconocido";
        }

        private void FormVistaPrevia_Click(object sender, EventArgs e)
        {
            // Obtener el control que disparó el evento
            var clickedControl = sender as Control;

            if (clickedControl != null)
            {
                // Mostrar el nombre del control que fue clickeado
                MessageBox.Show("El nombre del control es: " + clickedControl.Name);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void layoutControlItem1_Click(object sender, EventArgs e)
        {

        }

        private void mainRibbonControl_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPageGeneral_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPageGeneral_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener la página activa del XtraTabControl
            var activeTabPage = xtraTabControl1.SelectedTabPage;

            // Verificar si hay controles dentro de esa página
            if (activeTabPage != null)
            {
                foreach (Control control in activeTabPage.Controls)
                {
                    // Verificar si el clic está dentro de las coordenadas del control
                    if (control.Bounds.Contains(e.X, e.Y))
                    {
                        // Mostrar el nombre del control al que se hizo clic
                        MessageBox.Show("Hiciste clic en el control: " + control.Name);
                    }
                }
            }
        }

        private void layoutControlItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void RegistrarEventosDeClic()
        {
            foreach (Control control in this.xtraTabPageGeneral.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl != null)
            {
                MessageBox.Show("Se hizo clic en el control: " + clickedControl.Name);
            }
        }
        private void xtraTabPageLogistica_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPageGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            // Obtén el control que está bajo el puntero del mouse
            Control controlClicked = this.xtraTabPageGeneral.GetChildAtPoint(e.Location);

            if (controlClicked != null)
            {
                // Muestra el nombre del control
                MessageBox.Show("Se hizo clic en el control: " + controlClicked.Name);
            }
        }
    }
}
