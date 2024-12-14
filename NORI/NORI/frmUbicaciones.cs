using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;

namespace NORI
{
    public partial class frmUbicaciones : RibbonForm
    {
        private Almacen.Ubicacion ubicacion = new Almacen.Ubicacion();

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

        private LabelControl lblUbicacion;

        private TextEdit txtUbicacion;

        private LabelControl lblCodigo;

        private TextEdit txtCodigo;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbAlmacenes;

        private HyperlinkLabelControl lblAlmacenes;

        public frmUbicaciones(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                ubicacion = Almacen.Ubicacion.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarListas();
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

        private void CargarListas()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DataSource = (from x in Almacen.Almacenes()
                                                                                     where x.activo == true
                                                                                     select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = ubicacion.id.ToString();
            ((Control)(object)txtCodigo).Text = ubicacion.codigo.ToString();
            ((Control)(object)txtUbicacion).Text = ubicacion.ubicacion;
            ((BaseEdit)cbAlmacenes).EditValue = ubicacion.almacen_id;
            cbActivo.Checked = ubicacion.activo;
            ((Control)(object)lblFechaActualizacion).Text = ubicacion.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtCodigo).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtCodigo).Focus();
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
            ubicacion.codigo = int.Parse(((Control)(object)txtCodigo).Text);
            ubicacion.ubicacion = ((Control)(object)txtUbicacion).Text;
            ubicacion.almacen_id = ((!((BaseEdit)cbAlmacenes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbAlmacenes).EditValue) : 0);
            ubicacion.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (ubicacion.id != 0)
                    {
                        return ubicacion.Actualizar();
                    }
                    return ubicacion.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
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
                ubicacion = new Almacen.Ubicacion();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ubicacion = (from x in Almacen.Ubicacion.Ubicaciones()
                             orderby x.id
                             select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                ubicacion = (from x in Almacen.Ubicacion.Ubicaciones()
                             where x.id < ubicacion.id
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
                ubicacion = (from x in Almacen.Ubicacion.Ubicaciones()
                             where x.id > ubicacion.id
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
                ubicacion = (from x in Almacen.Ubicacion.Ubicaciones()
                             orderby x.id descending
                             select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (ubicacion.id != 0)
                {
                    ubicacion = new Almacen.Ubicacion();
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
                    codigo = ((Control)(object)txtCodigo).Text,
                    nombre = ((Control)(object)txtUbicacion).Text
                };
                DataTable dataTable = Utilidades.Busqueda("ubicaciones", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        ubicacion = Almacen.Ubicacion.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        ubicacion = Almacen.Ubicacion.Obtener(frmResultadosBusqueda2.id);
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
            ubicacion = new Almacen.Ubicacion();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ubicacion.id == 0)
            {
                Buscar();
            }
        }

  
    }

}
