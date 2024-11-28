using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using NoriSDK;
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
    public partial class frmVendedores : RibbonForm
    {
        private Vendedor vendedor = new Vendedor();

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

        private LabelControl lblPorcentajeComision;

        private TextEdit txtPorcentajeComision;

        private CheckEdit cbForaneo;

        private LookUpEdit cbZonas;

        private HyperlinkLabelControl lblZonas;

        private TextEdit txtCodigo;

        private LabelControl lblCodigo;

        private HyperlinkLabelControl lblRuta;

        private LookUpEdit cbRutas;

        public frmVendedores(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                vendedor = Vendedor.Obtener(id);
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
            ((Control)(object)lblID).Text = vendedor.id.ToString();
            ((BaseEdit)cbZonas).EditValue = vendedor.zona_id;
            ((BaseEdit)cbRutas).EditValue = vendedor.ruta_id;
            ((Control)(object)txtCodigo).Text = vendedor.codigo.ToString();
            ((Control)(object)txtNombre).Text = vendedor.nombre;
            ((Control)(object)txtPorcentajeComision).Text = vendedor.porcentaje_comision.ToString();
            cbForaneo.Checked = vendedor.foraneo;
            cbActivo.Checked = vendedor.activo;
            ((Control)(object)lblFechaActualizacion).Text = vendedor.fecha_actualizacion.ToShortDateString();
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

        private void CargarListas()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)cbRutas.Properties).DataSource = (from x in Ruta.Rutas()
                                                                                 where x.activo == true
                                                                                 select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbRutas.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbRutas.Properties).DisplayMember = "nombre";
                object parametros = new
                {
                    fields = "id, codigo, nombre"
                };
                object objeto = new
                {
                    activo = 1
                };
                ((RepositoryItemLookUpEditBase)cbZonas.Properties).DataSource = Utilidades.Busqueda("zonas", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbZonas.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbZonas.Properties).DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void Llenar()
        {
            vendedor.zona_id = (int)((BaseEdit)cbZonas).EditValue;
            vendedor.ruta_id = (int)((BaseEdit)cbRutas).EditValue;
            vendedor.codigo = short.Parse(((Control)(object)txtCodigo).Text);
            vendedor.nombre = ((Control)(object)txtNombre).Text;
            vendedor.porcentaje_comision = decimal.Parse(((Control)(object)txtPorcentajeComision).Text.ToString());
            vendedor.foraneo = cbForaneo.Checked;
            vendedor.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (vendedor.id != 0)
                    {
                        return vendedor.Actualizar();
                    }
                    return vendedor.Agregar();
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
                vendedor = new Vendedor();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                vendedor = (from x in Vendedor.Vendedores()
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
                vendedor = (from x in Vendedor.Vendedores()
                            where x.id < vendedor.id
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
                vendedor = (from x in Vendedor.Vendedores()
                            where x.id > vendedor.id
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
                vendedor = (from x in Vendedor.Vendedores()
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
                if (vendedor.id != 0)
                {
                    vendedor = new Vendedor();
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
                    codigo = int.Parse(((Control)(object)txtCodigo).Text),
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("vendedores", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        vendedor = Vendedor.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        vendedor = Vendedor.Obtener(frmResultadosBusqueda2.id);
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
            vendedor = new Vendedor();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && vendedor.id == 0)
            {
                Buscar();
            }
        
    }
}
}
