using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSDK;

namespace NORI
{
    public partial class frmUsuarios : RibbonForm
    {
        private Usuario usuario = new Usuario();

        private IContainer components = null;

        private DataLayoutControl dataLayoutControl1;

        private RibbonControl mainRibbonControl;

        private BackstageViewControl backstageViewControl1;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BarButtonItem bbiNuevo;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private RibbonPageGroup searchRibbonPageGroup;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LabelControl lblFechaActualizacion;

        private TextEdit txtNombre;

        private LabelControl lblUltimaActualizacion;

        private TextEdit txtUsuario;

        private LabelControl lblUsuario;

        private CheckEdit cbActivo;

        private LabelControl lblNombre;

        private LabelControl lblID;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtCorreo;

        private LabelControl lblCorreo;

        private TextEdit txtContraseña;

        private LabelControl lblContraseña;

        private LabelControl lblListaPrecios;

        private CheckButton cbMostrarContraseña;

        private SimpleButton btnHuellaDigital;

        private LookUpEdit cbRoles;

        private LookUpEdit cbAlmacenes;

        private HyperlinkLabelControl lblAlmacenes;

        private LookUpEdit cbSocios;

        private HyperlinkLabelControl lblSocios;

        private LookUpEdit cbVendedores;

        private HyperlinkLabelControl lblVendedores;

        private LookUpEdit cbEstados;

        private HyperlinkLabelControl lblEstado;

        private CheckEdit cbSuscribirAutorizaciones;

        private SimpleButton btnLiberarSesion;

        private TextEdit txtNormaReparto;

        private LabelControl lblNormaReparto;

        private LookUpEdit cbClasesExpedicion;

        private HyperlinkLabelControl lblClaseExpedicion;

        private BarButtonItem bbiCorreosElectronicos;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup HerramientasRibbonPageGroup;

        private TextEdit txtEscritorio;

        private LabelControl lblEscritorio;

        private BarButtonItem bbiPermisos;

        private LookUpEdit cbSucursales;

        private LabelControl lblSucursal;

        private TextEdit txtDispositivo;

        private LabelControl lblDispositivo;

        private LookUpEdit cbUbicaciones;

        private HyperlinkLabelControl lblUbicaciones;

        private TextEdit txtCodigo;

        private LabelControl lblCodigo;

        private BarButtonItem bbiConceptosAutorizaciones;

        private CheckEdit cbSeleccionarSucursal;

        private LookUpEdit cbListaPrecios;

        private HyperlinkLabelControl lblListaPrecioMinimo;

        public frmUsuarios(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                usuario = Usuario.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).DataSource = Usuario.Rol.Roles();
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).ValueMember = "rol";
            ((RepositoryItemLookUpEditBase)cbRoles.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbRoles).EditValue = Usuario.Rol.ObtenerPredeterminado();
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DataSource = (from x in Almacen.Almacenes()
                                                                                 where x.activo == true
                                                                                 select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DataSource = (from x in Vendedor.Vendedores()
                                                                                  where x.activo == true
                                                                                  select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DataSource = (from x in Socio.Socios()
                                                                              where x.activo == true
                                                                              select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DataSource = (from x in Estado.Estados()
                                                                               select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbClasesExpedicion.Properties).DataSource = (from x in ClaseExpedicion.ClasesExpedicion()
                                                                                        select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbClasesExpedicion.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbClasesExpedicion.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbSucursales.Properties).DataSource = (from x in Sucursal.Sucursales()
                                                                                  select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSucursales.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSucursales.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DataSource = (from x in ListaPrecio.ListasPrecios()
                                                                                    select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = usuario.id.ToString();
            ((Control)(object)txtUsuario).Text = usuario.usuario;
            ((Control)(object)txtCodigo).Text = usuario.codigo.ToString();
            ((BaseEdit)cbRoles).EditValue = usuario.rol;
            ((BaseEdit)cbAlmacenes).EditValue = usuario.almacen_id;
            ((RepositoryItemLookUpEditBase)cbUbicaciones.Properties).DataSource = (from x in Almacen.Ubicacion.Ubicaciones()
                                                                                   where x.almacen_id == usuario.almacen_id && x.activo == true
                                                                                   select new { x.id, x.codigo, x.ubicacion }).ToList();
            ((RepositoryItemLookUpEditBase)cbUbicaciones.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUbicaciones.Properties).DisplayMember = "ubicacion";
            ((BaseEdit)cbUbicaciones).EditValue = usuario.ubicacion_id;
            ((BaseEdit)cbSocios).EditValue = usuario.socio_id;
            ((BaseEdit)cbEstados).EditValue = usuario.estado_id;
            ((BaseEdit)cbVendedores).EditValue = usuario.vendedor_id;
            ((BaseEdit)cbListaPrecios).EditValue = usuario.lista_precio_minimo_id;
            ((BaseEdit)cbClasesExpedicion).EditValue = usuario.clase_expedicion_id;
            ((BaseEdit)cbSucursales).EditValue = usuario.sucursal_id;
            ((Control)(object)txtNombre).Text = usuario.nombre;
            ((Control)(object)txtCorreo).Text = usuario.correo;
            ((Control)(object)txtContraseña).Text = usuario.ObtenerContraseña();
            ((Control)(object)txtEscritorio).Text = usuario.escritorio;
            ((Control)(object)txtDispositivo).Text = usuario.dispositivo;
            ((Control)(object)txtNormaReparto).Text = usuario.norma_reparto;
            cbSuscribirAutorizaciones.Checked = usuario.suscribir_autorizaciones;
            cbSeleccionarSucursal.Checked = usuario.seleccionar_sucursal;
            cbActivo.Checked = usuario.activo;
            ((Control)(object)lblFechaActualizacion).Text = usuario.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtUsuario).Enabled = true;
                ((Control)(object)txtUsuario).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtUsuario).Enabled = true;
                ((Control)(object)txtUsuario).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtUsuario).Enabled = false;
            }
        }

        private void Llenar()
        {
            usuario.usuario = ((Control)(object)txtUsuario).Text;
            usuario.codigo = int.Parse(((Control)(object)txtCodigo).Text);
            usuario.rol = (char)((BaseEdit)cbRoles).EditValue;
            usuario.almacen_id = ((!((BaseEdit)cbAlmacenes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbAlmacenes).EditValue) : 0);
            usuario.ubicacion_id = ((!((BaseEdit)cbUbicaciones).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUbicaciones).EditValue) : 0);
            usuario.vendedor_id = ((!((BaseEdit)cbVendedores).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbVendedores).EditValue) : 0);
            usuario.lista_precio_minimo_id = ((!((BaseEdit)cbListaPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListaPrecios).EditValue) : 0);
            usuario.socio_id = ((!((BaseEdit)cbSocios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbSocios).EditValue) : 0);
            usuario.estado_id = ((!((BaseEdit)cbEstados).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbEstados).EditValue) : 0);
            usuario.clase_expedicion_id = ((!((BaseEdit)cbClasesExpedicion).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbClasesExpedicion).EditValue) : 0);
            usuario.sucursal_id = ((!((BaseEdit)cbSucursales).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbSucursales).EditValue) : 0);
            usuario.nombre = ((Control)(object)txtNombre).Text;
            usuario.correo = ((Control)(object)txtCorreo).Text;
            usuario.contraseña = ((Control)(object)txtContraseña).Text;
            usuario.escritorio = ((Control)(object)txtEscritorio).Text;
            usuario.dispositivo = ((Control)(object)txtDispositivo).Text;
            usuario.norma_reparto = ((Control)(object)txtNormaReparto).Text;
            usuario.suscribir_autorizaciones = cbSuscribirAutorizaciones.Checked;
            usuario.seleccionar_sucursal = cbSeleccionarSucursal.Checked;
            usuario.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes && ((Control)(object)txtContraseña).Text.Length > 0 && ((Control)(object)txtUsuario).Text.Length > 0)
                {
                    Llenar();
                    if (usuario.id != 0)
                    {
                        return usuario.Actualizar();
                    }
                    if (!Program.Nori.Empresa.prueba)
                    {
                        return usuario.Agregar();
                    }
                    MessageBox.Show("No es posible agregar más de un usuario en modo de prueba.");
                    return false;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
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
                usuario = new Usuario();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                usuario = (from x in Usuario.Usuarios()
                           orderby x.id
                           select x).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                usuario = (from x in Usuario.Usuarios()
                           where x.id < usuario.id
                           orderby x.id descending
                           select x).First();
            }
            catch
            {
                ((BarItem)bbiUltimo).PerformClick();
            }
            finally
            {
                Cargar();
            }
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                usuario = (from x in Usuario.Usuarios()
                           where x.id > usuario.id
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
                usuario = (from x in Usuario.Usuarios()
                           orderby x.id descending
                           select x).First();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (usuario.id != 0)
                {
                    usuario = new Usuario();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, usuario, nombre, rol, activo",
                    like = true
                };
                object objeto = new
                {
                    usuario = ((Control)(object)txtUsuario).Text,
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("usuarios", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        usuario = Usuario.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        usuario = Usuario.Obtener(frmResultadosBusqueda2.id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.", ((Control)(object)this).Text);
                }
            }
            catch
            {
            }
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            usuario = new Usuario();
            Cargar(nuevo: true);
        }

        private void cbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.Properties.PasswordChar = ((!cbMostrarContraseña.Checked) ? '*' : '\0');
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && usuario.id == 0)
            {
                Buscar();
            }
        }

        private void btnHuellaDigital_Click(object sender, EventArgs e)
        {
            if (Program.Nori.Estacion.lector_huella)
            {
                HuellaDigital.frmHuellaDigitalAgregar frmHuellaDigitalAgregar = new HuellaDigital.frmHuellaDigitalAgregar();
                DialogResult dialogResult = ((Form)(object)frmHuellaDigitalAgregar).ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    usuario.huella_digital = frmHuellaDigitalAgregar.huella_digital;
                }
            }
            else
            {
                MessageBox.Show("El lector de huella no esta habilitado para esta estación.");
            }
        }

        private void btnLiberarSesion_Click(object sender, EventArgs e)
        {
            if (usuario.id != 0 && usuario.LiberarSesion())
            {
                MessageBox.Show("Sesión liberada correctamente.");
            }
        }

        private void bbiCorreosElectronicos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCorreosElectronicos frmCorreosElectronicos2 = new frmCorreosElectronicos();
            ((Control)(object)frmCorreosElectronicos2).Show();
        }

        private void txtEscritorio_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML (*.xml) | *.xml";
            openFileDialog.Title = "Por favor seleccione un archivo.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Length > 260)
                {
                    MessageBox.Show("La ruta es mayor de 260 caracteres, por favor seleccione una ruta más corta");
                }
                else
                {
                    ((Control)(object)txtEscritorio).Text = openFileDialog.FileName;
                }
            }
        }

        private void bbiPermisos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPermisos frmPermisos2 = new frmPermisos();
            frmPermisos2.Show();
        }

        private void lblUbicaciones_Click(object sender, EventArgs e)
        {
            frmUbicaciones frmUbicaciones2 = new frmUbicaciones((!((BaseEdit)cbUbicaciones).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbUbicaciones).EditValue) : 0);
            ((Form)(object)frmUbicaciones2).ShowDialog();
        }

        private void bbiConceptosAutorizaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConceptosAutorizaciones frmConceptosAutorizaciones2 = new frmConceptosAutorizaciones();
            ((Control)(object)frmConceptosAutorizaciones2).Show();
        }

        private void lblAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes frmAlmacenes2 = new frmAlmacenes();
            ((Form)(object)frmAlmacenes2).ShowDialog();
        }

        private void lblVendedores_Click(object sender, EventArgs e)
        {
            frmVendedores frmVendedores2 = new frmVendedores();
            ((Form)(object)frmVendedores2).ShowDialog();
        }

        private void lblSocios_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios2 = new frmSocios();
            ((Form)(object)frmSocios2).ShowDialog();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            frmEstados frmEstados2 = new frmEstados();
            ((Form)(object)frmEstados2).ShowDialog();
        }

        private void lblUbicaciones_Click_1(object sender, EventArgs e)
        {
            frmUbicaciones frmUbicaciones2 = new frmUbicaciones();
            ((Form)(object)frmUbicaciones2).ShowDialog();
        }

        private void lblListaPrecioMinimo_Click(object sender, EventArgs e)
        {
            frmListasPrecios frmListasPrecios2 = new frmListasPrecios();
            ((Form)(object)frmListasPrecios2).ShowDialog();
        }
    }
}
