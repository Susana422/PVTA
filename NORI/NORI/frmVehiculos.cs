using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmVehiculos : RibbonForm
    {
        private Vehiculo vehiculo = new Vehiculo();

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

        private TextEdit txtModelo;

        private LabelControl lblModelo;

        private TextEdit txtConfiguracionVehicular;

        private LabelControl lblConfiguracionVehicular;

        private TextEdit txtNumeroPlacas;

        private LabelControl lblNumeroPlacas;

        private TextEdit txtNumeroPermisoSCT;

        private LabelControl lblNumeroPermisoSCT;

        private TextEdit txtPermisoSCT;

        private LabelControl lblPermisoSCT;

        private TextEdit txtAseguradora;

        private LabelControl lblAseguradora;

        private TextEdit txtNumeroPoliza;

        private LabelControl lblNumeroPoliza;

        private TextEdit txtPeso;

        private LabelControl lblPeso;

        public frmVehiculos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                vehiculo = Vehiculo.Obtener(id);
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
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'C':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = vehiculo.id.ToString();
            ((Control)(object)txtCodigo).Text = vehiculo.codigo;
            ((Control)(object)txtNombre).Text = vehiculo.nombre;
            ((Control)(object)txtModelo).Text = vehiculo.modelo.ToString();
            ((Control)(object)txtConfiguracionVehicular).Text = vehiculo.configuracion_vehicular;
            ((Control)(object)txtNumeroPlacas).Text = vehiculo.numero_placas;
            ((Control)(object)txtPermisoSCT).Text = vehiculo.permiso_sct;
            ((Control)(object)txtNumeroPermisoSCT).Text = vehiculo.numero_permiso_sct;
            ((Control)(object)txtNumeroPoliza).Text = vehiculo.numero_poliza;
            ((Control)(object)txtAseguradora).Text = vehiculo.aseguradora;
            ((Control)(object)txtPeso).Text = vehiculo.peso.ToString();
            cbActivo.Checked = vehiculo.activo;
            ((Control)(object)lblFechaActualizacion).Text = vehiculo.fecha_actualizacion.ToShortDateString();
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
            vehiculo.codigo = ((Control)(object)txtCodigo).Text;
            vehiculo.nombre = ((Control)(object)txtNombre).Text;
            vehiculo.modelo = int.Parse(((Control)(object)txtModelo).Text);
            vehiculo.configuracion_vehicular = ((Control)(object)txtConfiguracionVehicular).Text;
            vehiculo.numero_placas = ((Control)(object)txtNumeroPlacas).Text;
            vehiculo.permiso_sct = ((Control)(object)txtPermisoSCT).Text;
            vehiculo.numero_permiso_sct = ((Control)(object)txtNumeroPermisoSCT).Text;
            vehiculo.numero_poliza = ((Control)(object)txtNumeroPoliza).Text;
            vehiculo.aseguradora = ((Control)(object)txtAseguradora).Text;
            vehiculo.peso = decimal.Parse(((Control)(object)txtPeso).Text);
            vehiculo.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (vehiculo.id != 0)
                    {
                        return vehiculo.Actualizar();
                    }
                    return vehiculo.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
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
                vehiculo = new Vehiculo();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                vehiculo = (from x in Vehiculo.Vehiculos()
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
                vehiculo = (from x in Vehiculo.Vehiculos()
                            where x.id < vehiculo.id
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
                vehiculo = (from x in Vehiculo.Vehiculos()
                            where x.id > vehiculo.id
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
                vehiculo = (from x in Vehiculo.Vehiculos()
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
                if (vehiculo.id != 0)
                {
                    vehiculo = new Vehiculo();
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
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("vehiculos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        vehiculo = Vehiculo.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        vehiculo = Vehiculo.Obtener(frmResultadosBusqueda2.id);
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
            vehiculo = new Vehiculo();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && vehiculo.id == 0)
            {
                Buscar();
            }
        }

    }
}
