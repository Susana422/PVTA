using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DocumentFormat.OpenXml.Office2010.Excel;
using DTM.Parametrizacion;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;


namespace DTM
{
    public partial class frmFormArt : RibbonForm
    {
        private ConnectionStringSettingsCollection conexiones;

        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private BindingList<ParametroGrid> parametrizacionForm2 = new BindingList<ParametroGrid>();
        public frmFormArt()
        {
            InitializeComponent();
            this.MetodoDinamico();
            RegistrarEventosDeClic();
            RegistrarEventosDeClicMain();
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).DataSource = Usuario.Rol.Roles();
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).ValueMember = "rol";
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbRoles).EditValue = Usuario.Rol.ObtenerPredeterminado();
            // Configuración inicial del DataGridView
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Definir las columnas manualmente
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id", HeaderText = "ID", DataPropertyName = "id" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripción", DataPropertyName = "Descripcion" });
            this.dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Oculto", HeaderText = "Oculto", DataPropertyName = "Oculto" });
            this.dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Desactivado", HeaderText = "Desactivado", DataPropertyName = "Desactivado" });
            this.dataGridView1.Columns["id"].Visible = false;
        }

       

        private void RegistrarEventosDeClic()
        {
            foreach (Control control in this.xtraTabPageGeneral.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabPageDatosCompras.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabPageDatosVentas.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabControl1.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabPagePropiedades.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabPageWeb.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
            foreach (Control control in this.xtraTabPage1.Controls)
            {
                control.Click += new EventHandler(Control_Click);
            }
        }
        private void RegistrarEventosDeClicMain()
        {
            foreach (var item in this.mainRibbonControl.Items)
            {
                // Para BarButtonItem
                if (item is DevExpress.XtraBars.BarButtonItem buttonItem)
                {
                    buttonItem.ItemClick += ButtonItem_ItemClick;
                }
            }
        }

        private void ButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string valorColumna1 = e.Item.Name;
            string valorColumna2 = e.Item.Caption;
            bool checkBoxValor1 = false;
            bool checkBoxValor2 = false;
                ParametroGrid nuevaFila = new ParametroGrid
                {
                    id = 0,
                    Nombre = valorColumna1,
                    Descripcion = valorColumna2,
                    Oculto = false,
                    Desactivado = false
                };
                parametrizacionForm2.Add(nuevaFila);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = parametrizacionForm2;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.DataSource = bindingSource;
                bindingSource.ResetBindings(false);
       }
        
        private void Control_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl != null)
            {
                string valorColumna1 = clickedControl.Name;
                string valorColumna2 = clickedControl.Text;
                bool checkBoxValor1 = false;
                bool checkBoxValor2 = false;


                ParametroGrid nuevaFila = new ParametroGrid
                    {
                        id = 0,
                        Nombre = valorColumna1,
                        Descripcion = valorColumna2,
                        Oculto = false,
                        Desactivado = false
                    };
                parametrizacionForm2.Add(nuevaFila);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = parametrizacionForm2;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.DataSource = bindingSource;
                bindingSource.ResetBindings(false);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea guardar estos cambios?",
                                       "Confirmar Guardado",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow dataRow in dataGridView1.Rows)
                {
                    try
                    {
                        int id = Int32.Parse(dataRow.Cells["id"].Value.ToString());
                        ParametrizacionFormulario parametrizacionFormulario = ParametrizacionFormulario.Obtener(id);
                        parametrizacionFormulario.usuario_id = 0;
                        char.TryParse(cbRoles.EditValue.ToString(), out var result2);
                        parametrizacionFormulario.rol = result2;
                        parametrizacionFormulario.objeto = "AR";
                        parametrizacionFormulario.formulario = "frmArticulos";
                        parametrizacionFormulario.control = dataRow.Cells["Nombre"].Value?.ToString();
                        parametrizacionFormulario.nombre = dataRow.Cells["Descripcion"].Value?.ToString();
                        parametrizacionFormulario.oculto = Convert.ToBoolean(dataRow.Cells["Oculto"].Value);
                        parametrizacionFormulario.desactivado = Convert.ToBoolean(dataRow.Cells["Desactivado"].Value);
                        if (parametrizacionFormulario.id != 0)
                        {
                            parametrizacionFormulario.Actualizar();  // Si ya existe, actualiza
                        }
                        else
                        {
                            parametrizacionFormulario.Agregar();  // Si no existe, agrega
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error al intentar agregar la fila");
                    }

                }
                MessageBox.Show("Se guardaron los cambios correctamente");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            char.TryParse(cbRoles.EditValue.ToString(), out var result2);
            string formulario = "frmArticulos";
            List<ParametrizacionFormulario> parametrizacionForm = ParametrizacionFormulario.ObtenerRol("frmArticulos", "AR", result2);
            parametrizacionForm2 = new BindingList<ParametroGrid>(parametrizacionForm.Select(p => new ParametroGrid { id = p.id, Nombre = p.control, Descripcion = p.nombre, Oculto = p.oculto, Desactivado = p.desactivado }).ToList());
            dataGridView1.DataSource = parametrizacionForm2;
        }
    }

}
