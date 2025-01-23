using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace DTM
{
    public partial class frmParametrizacionesFormulario : XtraForm
    {
        private IContainer components = null;

        private PanelControl panel1;

        private GridControl gcPermisos;

        private GridView gvPermisos;

        private GridColumn gridColumnUsuarioID;

        private RepositoryItemLookUpEdit cbUsuarios;

        private GridColumn gridColumnID;

        private GridColumn gridColumnDesactivado;

        private GridColumn gridColumnControl;

        private RepositoryItemLookUpEdit cbControles;

        private GridColumn gridColumnOculto;

        private GridColumn gridColumnRol;

        private RepositoryItemLookUpEdit cbRoles;

        private RepositoryItemLookUpEdit cbObjetos;

        private string formulario { get; set; }

        private string objeto { get; set; }

        public frmParametrizacionesFormulario(string f, string o)
        {
            InitializeComponent();
            this.MetodoDinamico();
            lookUpEdit2.Properties.DataSource = Usuario.Rol.Roles();
            lookUpEdit2.Properties.ValueMember = "rol";
            lookUpEdit2.Properties.DisplayMember = "nombre";
            lookUpEdit1.Properties.DataSource = CrearDataTableFormulario();
            lookUpEdit1.Properties.ValueMember = "form";      // Columna para el valor
            lookUpEdit1.Properties.DisplayMember = "nombre";  // Columna para el texto visible

            formulario = f;
            objeto = o;
        }

        private DataTable CrearDataTableControles()
        {
            // Crear un DataTable con columnas para almacenar el nombre, tipo y valor de los controles
            DataTable dt = new DataTable();
            dt.Columns.Add("ControlName", typeof(string));
            dt.Columns.Add("ControlType", typeof(string));
            dt.Columns.Add("ControlValue", typeof(string));

            return dt;
        }

        // Método para buscar un formulario por su nombre y recorrer sus controles
        private void BuscarFormularioYRecorrerControles()
        {
            System.Data.DataTable data = CrearDataTableControles();
            string nombreFormulario = lookUpEdit1.EditValue.ToString();
            Form otroForm = CrearFormularioPorNombre(nombreFormulario);
            // Buscar el formulario por su nombre en los formularios abiertos
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == nombreFormulario)
                {
                    RecorrerControlesRecursivamente(otroForm.Controls, data);
                    break;
                }
            }
        }
        private Form CrearFormularioPorNombre(string nombreFormulario)
        {
            switch (nombreFormulario)
            {
                case "frmAcceder":
                    return new frmAcceder();  // Aquí creas el formulario deseado
                case "frmDocumentos":
                    return new frmDocumentos("OC", 0);    // Otro formulario que tengas
                                                          // Agrega más casos según los formularios que tengas
                default:
                    return null;  // Si no existe el formulario, retornamos null
            }
        }
        private void RecorrerControlesRecursivamente(Control.ControlCollection controls, DataTable dt)
        {
            foreach (Control ctrl in controls)
            {
                // Guardamos el nombre, tipo y valor del control
                dt.Rows.Add(ctrl.Name, ctrl.GetType().ToString(), ObtenerValorDelControl(ctrl));

                // Si el control tiene hijos, llamamos recursivamente
                if (ctrl.HasChildren)
                {
                    RecorrerControlesRecursivamente(ctrl.Controls, dt);
                }
            }
        }

        // Función para obtener el valor del control, sin especificar tipo
        private string ObtenerValorDelControl(Control ctrl)
        {
            // Si el control tiene una propiedad 'Text', obtenemos el valor
            var textProperty = ctrl.GetType().GetProperty("Text");
            if (textProperty != null)
            {
                try
                {
                    var value = textProperty.GetValue(ctrl, null);
                    return value?.ToString() ?? string.Empty;
                }
                catch (Exception)
                {
                }

            }

            // Si el control tiene una propiedad 'Checked' (como en CheckBox)
            var checkedProperty = ctrl.GetType().GetProperty("Checked");
            if (checkedProperty != null)
            {
                var value = checkedProperty.GetValue(ctrl, null);
                return value?.ToString() ?? string.Empty;
            }

            // Si el control tiene una propiedad 'SelectedItem' (como en ComboBox)
            var selectedItemProperty = ctrl.GetType().GetProperty("SelectedItem");
            if (selectedItemProperty != null)
            {
                var value = selectedItemProperty.GetValue(ctrl, null);
                return value?.ToString() ?? string.Empty;
            }

            // Si el control tiene alguna propiedad que devuelva algún valor, devuélvelo
            return string.Empty; // Si no tiene ninguna propiedad relevante, devolver vacío
        }
        private DataTable CrearDataTableFormulario()
        {
            DataTable table = new DataTable();

            // Crear columnas
            table.Columns.Add("form", typeof(string));  // Columna para el valor
            table.Columns.Add("nombre", typeof(string));  // Columna para el nombre a mostrar

            // Poblar el DataTable con algunos datos
            table.Rows.Add("frmDocumentos", "Documentos");
            table.Rows.Add("frmArticulos", "Articulos");
            table.Rows.Add("frmPagos", "Pagos");
            table.Rows.Add("frmSocios", "Socios");
            return table;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BuscarFormularioYRecorrerControles();
        }
    }

}
