using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmSucursales : RibbonForm
    {
        private Sucursal sucursal = new Sucursal();

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

        private TextEdit txtUsuario;

        private LabelControl lblUsuario;

        private TextEdit txtContraseña;

        private LabelControl lblContraseña;

        private TextEdit txtBD;

        private LabelControl lblBD;

        private TextEdit txtServidor;

        private LabelControl lblServidor;

        private CheckEdit cbSoloSubida;

        private Button btnConectar;

        private CheckEdit cbDocumentosBajada;

        private NumericUpDown udHorario;

        private LabelControl lblHorario;

        public frmSucursales(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                sucursal = Sucursal.Obtener(id);
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
                case 'S':
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = sucursal.id.ToString();
            ((Control)(object)txtCodigo).Text = sucursal.codigo;
            ((Control)(object)txtNombre).Text = sucursal.nombre;
            ((Control)(object)txtServidor).Text = sucursal.servidor;
            ((Control)(object)txtBD).Text = sucursal.bd;
            ((Control)(object)txtUsuario).Text = sucursal.usuario;
            ((Control)(object)txtContraseña).Text = sucursal.contraseña;
            udHorario.Value = sucursal.horario;
            cbSoloSubida.Checked = sucursal.solo_subida;
            cbDocumentosBajada.Checked = sucursal.documentos_bajada;
            cbActivo.Checked = sucursal.activo;
            ((Control)(object)lblFechaActualizacion).Text = sucursal.fecha_actualizacion.ToShortDateString();
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
            try
            {
                sucursal.codigo = ((Control)(object)txtCodigo).Text;
                sucursal.nombre = ((Control)(object)txtNombre).Text;
                sucursal.servidor = ((Control)(object)txtServidor).Text;
                sucursal.bd = ((Control)(object)txtBD).Text;
                sucursal.usuario = ((Control)(object)txtUsuario).Text;
                sucursal.contraseña = ((Control)(object)txtContraseña).Text;
                sucursal.horario = (int)udHorario.Value;
                sucursal.solo_subida = cbSoloSubida.Checked;
                sucursal.documentos_bajada = cbDocumentosBajada.Checked;
                sucursal.activo = cbActivo.Checked;
            }
            catch
            {
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (sucursal.id != 0)
                    {
                        return sucursal.Actualizar();
                    }
                    return sucursal.Agregar();
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
                sucursal = new Sucursal();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                sucursal = (from x in Sucursal.Sucursales()
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
                sucursal = (from x in Sucursal.Sucursales()
                            where x.id < sucursal.id
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
                sucursal = (from x in Sucursal.Sucursales()
                            where x.id > sucursal.id
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
                sucursal = (from x in Sucursal.Sucursales()
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
                if (sucursal.id != 0)
                {
                    sucursal = new Sucursal();
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
                DataTable dataTable = Utilidades.Busqueda("sucursales", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        sucursal = Sucursal.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        sucursal = Sucursal.Obtener(frmResultadosBusqueda2.id);
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
            sucursal = new Sucursal();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && sucursal.id == 0)
            {
                Buscar();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar una conexión con esta sucursal? (La conexión actual sera finalizada)", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conectar();
            }
        }

        private void Conectar()
        {
            SqlConnectionStringBuilder conexion = Program.Nori.Conexion;
            Program.Nori.Conexion.DataSource = sucursal.servidor;
            Program.Nori.Conexion.InitialCatalog = sucursal.bd;
            if (sucursal.contraseña.IsNullOrEmpty())
            {
                Program.Nori.Conexion.IntegratedSecurity = false;
            }
            Program.Nori.Conexion.UserID = sucursal.usuario;
            Program.Nori.Conexion.Password = sucursal.contraseña;
            Program.Nori.Conexion.ConnectTimeout = 30;
            if (Program.Nori.Conectar())
            {
                MessageBox.Show("Conexión realizada correctamente");
                return;
            }
            Program.Nori.Conexion = conexion;
            Program.Nori.Conectar();
            MessageBox.Show($"No fue posible establecer una conexión con la sucursal {sucursal.nombre}");

        }
    }
}
