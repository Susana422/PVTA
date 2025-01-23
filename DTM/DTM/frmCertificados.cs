using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmCertificados : RibbonForm
    {
        private Certificado certificado = new Certificado();

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

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private TextEdit txtCER;

        private LabelControl lblCER;

        private TextEdit txtKEY;

        private LabelControl lblKEY;

        private TextEdit txtContraseña;

        private LabelControl lblContraseña;

        private TextEdit txtContraseñaPFX;

        private LabelControl lblContraseñaPFX;

        private TextEdit txtPFX;

        private LabelControl lblPFX;

        public frmCertificados(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                certificado = Certificado.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
        }

        private void Permisos()
        {
            switch (Program.dtm.UsuarioAutenticado.rol)
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

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = certificado.id.ToString();
            ((Control)(object)txtNombre).Text = certificado.nombre;
            ((Control)(object)txtCER).Text = certificado.cer;
            ((Control)(object)txtKEY).Text = certificado.key;
            ((Control)(object)txtContraseña).Text = certificado.contraseña;
            ((Control)(object)txtPFX).Text = certificado.pfx;
            ((Control)(object)txtContraseñaPFX).Text = certificado.contraseña_pfx;
            cbActivo.Checked = certificado.activo;
            ((Control)(object)lblFechaActualizacion).Text = certificado.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtNombre).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtNombre).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
        }

        private void Llenar()
        {
            certificado.nombre = ((Control)(object)txtNombre).Text;
            certificado.cer = ((Control)(object)txtCER).Text;
            certificado.key = ((Control)(object)txtKEY).Text;
            certificado.contraseña = ((Control)(object)txtContraseña).Text;
            certificado.pfx = ((Control)(object)txtPFX).Text;
            certificado.contraseña_pfx = ((Control)(object)txtContraseñaPFX).Text;
            certificado.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (certificado.id != 0)
                    {
                        return certificado.Actualizar();
                    }
                    return certificado.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                ((Form)this).Close();
            }
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                certificado = new Certificado();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                certificado = (from x in Certificado.Certificados()
                               orderby x.id
                               select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                certificado = (from x in Certificado.Certificados()
                               where x.id < certificado.id
                               orderby x.id descending
                               select x).First();
                Cargar();
            }
            catch
            {
                ((BarItem)bbiUltimo).PerformClick();
            }
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                certificado = (from x in Certificado.Certificados()
                               where x.id > certificado.id
                               select x).First();
                Cargar();
            }
            catch
            {
                ((BarItem)bbiPrimero).PerformClick();
            }
        }

        private void bbiUltimo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                certificado = (from x in Certificado.Certificados()
                               orderby x.id descending
                               select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (certificado.id != 0)
                {
                    certificado = new Certificado();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, nombre, activo",
                    like = true
                };
                object objeto = new
                {
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("certificados", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        certificado = Certificado.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        certificado = Certificado.Obtener(frmResultadosBusqueda2.id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", ((Control)(object)this).Text);
                }
            }
            catch
            {
            }
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            certificado = new Certificado();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && certificado.id == 0)
            {
                Buscar();
            }
        }

        private void txtCER_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CER (*.cer) | *.cer";
            openFileDialog.Title = "Por favor seleccione un archivo.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Length > 254)
                {
                    MessageBox.Show("La ruta es mayor de 254 caracteres, por favor seleccione una ruta más corta");
                }
                else
                {
                    ((Control)(object)txtCER).Text = openFileDialog.FileName;
                }
            }
        }

        private void txtKEY_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "KEY (*.key) | *.key";
            openFileDialog.Title = "Por favor seleccione un archivo.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Length > 254)
                {
                    MessageBox.Show("La ruta es mayor de 254 caracteres, por favor seleccione una ruta más corta");
                }
                else
                {
                    ((Control)(object)txtKEY).Text = openFileDialog.FileName;
                }
            }
        }

        private void txtPFX_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PFX (*.pfx) | *.pfx";
            openFileDialog.Title = "Por favor seleccione un archivo.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Length > 254)
                {
                    MessageBox.Show("La ruta es mayor de 254 caracteres, por favor seleccione una ruta más corta");
                }
                else
                {
                    ((Control)(object)txtPFX).Text = openFileDialog.FileName;
                }
            }
        }

    }
}
