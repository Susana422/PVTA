using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmAlmacenes : RibbonForm
    {
        private Almacen almacen = new Almacen();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRestablecer;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BarButtonItem bbiNuevo;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private RibbonPageGroup searchRibbonPageGroup;

        private LabelControl lblID;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblCodigo;

        private TextEdit txtCodigo;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbImpresoras;

        private LabelControl lblImpresora;

        private TextEdit txtNumeroCuentaAjusteInventario;

        private LabelControl lblCuentaAjusteInventario;

        private CheckEdit cbUbicaciones;

        private LookUpEdit cbUbicacion;

        private HyperlinkLabelControl lblUbicacion;

        private BarButtonItem bbiUsuarios;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup herramientasRibbonPageGroup;

        private CheckEdit cbTransito;

        private LookUpEdit cbAlmacenes;

        private HyperlinkLabelControl lblAlmacenes;

        private SimpleButton btnImagen;

        private PictureBox pbImagen;

        public frmAlmacenes(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                almacen = Almacen.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarImpresoras();
            Permisos();
        }

        private void Permisos()
        {
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'C':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'S':
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
        }

        private void CargarUbicaciones()
        {
            try
            {
                cbUbicacion.Properties.DataSource = almacen.Ubicaciones();
                cbUbicacion.Properties.ValueMember = "id";
                cbUbicacion.Properties.DisplayMember = "ubicacion";
            }
            catch
            {
            }
        }

        private void CargarImpresoras()
        {
            List<string> list = new List<string>();
            list.Add(string.Empty);
            foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
            {
                list.Add(installedPrinter.ToString());
            }
            cbImpresoras.Properties.DataSource = list;
            cbAlmacenes.Properties.DataSource = (from x in Almacen.Almacenes()
                                                 where x.activo == true
                                                 select new { x.id, x.codigo, x.nombre }).ToList();
            cbAlmacenes.Properties.ValueMember = "id";
            cbAlmacenes.Properties.DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            lblID.Text = almacen.id.ToString();
            txtCodigo.Text = almacen.codigo;
            txtNombre.Text = almacen.nombre;
            cbImpresoras.EditValue = almacen.impresora;
            txtNumeroCuentaAjusteInventario.Text = almacen.numero_cuenta_ajuste_inventario;
            cbUbicaciones.Checked = almacen.ubicaciones;
            CargarUbicaciones();
            cbUbicacion.EditValue = almacen.ubicacion_id;
            cbTransito.Checked = almacen.transito;
            cbAlmacenes.EditValue = almacen.almacen_destino_id;
            cbActivo.Checked = almacen.activo;
            pbImagen.LoadImage(almacen.logotipo);
            lblFechaActualizacion.Text = almacen.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                bbiNuevo.Enabled = false;
                bbiGuardar.Enabled = true;
                bbiGuardarCerrar.Enabled = true;
                bbiGuardarNuevo.Enabled = true;
                txtCodigo.Focus();
            }
            else if (busqueda)
            {
                bbiNuevo.Enabled = true;
                bbiGuardar.Enabled = false;
                bbiGuardarCerrar.Enabled = false;
                bbiGuardarNuevo.Enabled = false;
                txtCodigo.Focus();
            }
            else
            {
                bbiNuevo.Enabled = true;
                bbiGuardar.Enabled = true;
                bbiGuardarCerrar.Enabled = true;
                bbiGuardarNuevo.Enabled = true;
            }
        }

        private void Llenar()
        {
            almacen.codigo = txtCodigo.Text;
            almacen.nombre = txtNombre.Text;
            almacen.ubicacion_id = ((!cbUbicacion.EditValue.IsNullOrEmpty()) ? ((int)cbUbicacion.EditValue) : 0);
            almacen.impresora = cbImpresoras.EditValue.ToString();
            almacen.numero_cuenta_ajuste_inventario = txtNumeroCuentaAjusteInventario.Text;
            almacen.ubicaciones = cbUbicaciones.Checked;
            almacen.transito = cbTransito.Checked;
            almacen.almacen_destino_id = ((!cbAlmacenes.EditValue.IsNullOrEmpty()) ? ((int)cbAlmacenes.EditValue) : 0);
            almacen.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (almacen.id != 0)
                    {
                        return almacen.Actualizar();
                    }
                    return almacen.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                return false;
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Cargar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
            }
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Close();
            }
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                almacen = new Almacen();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                almacen = (from x in Almacen.Almacenes()
                           orderby x.id
                           select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiAnterior_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                almacen = (from x in Almacen.Almacenes()
                           where x.id < almacen.id
                           orderby x.id descending
                           select x).First();
                Cargar();
            }
            catch
            {
                bbiUltimo.PerformClick();
            }
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                almacen = (from x in Almacen.Almacenes()
                           where x.id > almacen.id
                           select x).First();
                Cargar();
            }
            catch
            {
                bbiPrimero.PerformClick();
            }
        }

        private void bbiUltimo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                almacen = (from x in Almacen.Almacenes()
                           orderby x.id descending
                           select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (almacen.id != 0)
                {
                    almacen = new Almacen();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, codigo, nombre, activo",
                    like = true
                };
                object objeto = new
                {
                    codigo = txtCodigo.Text,
                    nombre = txtNombre.Text
                };
                DataTable dataTable = Utilidades.Busqueda("almacenes", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        almacen = Almacen.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        almacen = Almacen.Obtener(frmResultadosBusqueda2.id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", Text);
                }
            }
            catch
            {
            }
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            almacen = new Almacen();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && almacen.id == 0)
            {
                Buscar();
            }
        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicaciones frmUbicaciones2 = new frmUbicaciones((!cbUbicacion.EditValue.IsNullOrEmpty()) ? ((int)cbUbicacion.EditValue) : 0);
            frmUbicaciones2.ShowDialog();
        }

        private void bbiUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuariosAlmacenes frmUsuariosAlmacenes2 = new frmUsuariosAlmacenes();
            frmUsuariosAlmacenes2.ShowDialog();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Por favor seleccione una imagen.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = Program.Nori.Configuracion.directorio_imagenes + "\\" + openFileDialog.SafeFileName;
                File.Copy(openFileDialog.FileName, text, overwrite: true);
                pbImagen.Image = new Bitmap(text);
                almacen.logotipo = openFileDialog.SafeFileName;
            }
        }

        private void lblAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes frmAlmacen = new frmAlmacenes((!cbUbicacion.EditValue.IsNullOrEmpty()) ? ((int)cbUbicacion.EditValue) : 0);
            frmAlmacen.ShowDialog();
        }
    }

}
