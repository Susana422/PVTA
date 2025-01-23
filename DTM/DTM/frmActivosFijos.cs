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
    public partial class frmActivosFijos : RibbonForm
    {
        private ActivoFijo activo_fijo = new ActivoFijo();

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

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private BarButtonItem bbiUsuarios;

        private PanelControl panelControl1;

        private LabelControl lblFechaActualizacion;

        private TextEdit txtNombre;

        private LabelControl lblUltimaActualizacion;

        private TextEdit txtCodigo;

        private LabelControl lblCodigo;

        private CheckEdit cbActivo;

        private LabelControl lblNombre;

        private LabelControl lblID;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtSerie;

        private LabelControl lblSerie;

        private TextEdit txtModelo;

        private LabelControl lblModelo;

        private TextEdit txtMarca;

        private LabelControl lblMarca;

        private TextEdit txtDescripcion;

        private LabelControl lblDescripcion;

        private TextEdit txtComentario;

        private LabelControl lblComentario;

        private LabelControl lblFechaAdquisicion;

        private DateEdit deFechaAdquisicion;

        private LookUpEdit cbGruposArticulos;

        private HyperlinkLabelControl lblGrupoArticulos;

        private HyperlinkLabelControl lblFabricantes;

        private LookUpEdit cbFabricantes;

        private LookUpEdit cbPropietarios;

        private HyperlinkLabelControl lblPropietarios;

        private LookUpEdit cbSocios;

        private HyperlinkLabelControl lblSocios;

        public frmActivosFijos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                activo_fijo = ActivoFijo.Obtener(id);
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
            switch (Program.dtm.UsuarioAutenticado.rol)
            {
                case 'C':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'L':
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
                cbGruposArticulos.Properties.DataSource = (from x in GrupoArticulo.GruposArticulos()
                                                           where x.activo == true
                                                           select new { x.id, x.codigo, x.nombre }).ToList();
                cbGruposArticulos.Properties.ValueMember = "id";
                cbGruposArticulos.Properties.DisplayMember = "nombre";
                cbFabricantes.Properties.DataSource = (from x in Fabricante.Fabricantes()
                                                       where x.activo == true
                                                       select new { x.id, x.codigo, x.nombre }).ToList();
                cbFabricantes.Properties.ValueMember = "id";
                cbFabricantes.Properties.DisplayMember = "nombre";
                cbPropietarios.Properties.DataSource = (from x in Propietario.Propietarios()
                                                        where x.activo == true
                                                        select new { x.id, x.codigo, x.nombre }).ToList();
                cbPropietarios.Properties.ValueMember = "id";
                cbPropietarios.Properties.DisplayMember = "nombre";
                cbSocios.Properties.DataSource = (from x in Socio.Socios()
                                                  where x.activo == true
                                                  select new { x.id, x.codigo, x.nombre }).ToList();
                cbSocios.Properties.ValueMember = "id";
                cbSocios.Properties.DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            lblID.Text = activo_fijo.id.ToString();
            txtCodigo.Text = activo_fijo.codigo;
            txtNombre.Text = activo_fijo.nombre;
            cbGruposArticulos.EditValue = activo_fijo.grupo_articulo_id;
            cbFabricantes.EditValue = activo_fijo.fabricante_id;
            cbPropietarios.EditValue = activo_fijo.propietario_id;
            cbSocios.EditValue = activo_fijo.socio_id;
            txtSerie.Text = activo_fijo.serie;
            txtDescripcion.Text = activo_fijo.descripcion;
            txtMarca.Text = activo_fijo.marca;
            txtModelo.Text = activo_fijo.modelo;
            txtComentario.Text = activo_fijo.comentario;
            deFechaAdquisicion.DateTime = activo_fijo.fecha_adquisicion;
            cbActivo.Checked = activo_fijo.activo;
            lblFechaActualizacion.Text = activo_fijo.fecha_actualizacion.ToShortDateString();
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
            try
            {
                activo_fijo.codigo = txtCodigo.Text;
                activo_fijo.nombre = txtNombre.Text;
                activo_fijo.grupo_articulo_id = (int)cbGruposArticulos.EditValue;
                activo_fijo.fabricante_id = (int)cbFabricantes.EditValue;
                activo_fijo.propietario_id = (int)cbPropietarios.EditValue;
                activo_fijo.socio_id = (int)cbSocios.EditValue;
                activo_fijo.serie = txtSerie.Text;
                activo_fijo.descripcion = txtDescripcion.Text;
                activo_fijo.marca = txtMarca.Text;
                activo_fijo.modelo = txtModelo.Text;
                activo_fijo.comentario = txtComentario.Text;
                activo_fijo.fecha_adquisicion = deFechaAdquisicion.DateTime;
                activo_fijo.activo = cbActivo.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM").ToString().Replace("Nori", "DTM"));
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (activo_fijo.id != 0)
                    {
                        return activo_fijo.Actualizar();
                    }
                    return activo_fijo.Agregar();
                }
                return false;
            }
            catch
            {
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
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
                MessageBox.Show("Error al guardar: " + SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
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
                activo_fijo = new ActivoFijo();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                activo_fijo = (from x in ActivoFijo.ActivosFijos()
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
                activo_fijo = (from x in ActivoFijo.ActivosFijos()
                               where x.id < activo_fijo.id
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
                activo_fijo = (from x in ActivoFijo.ActivosFijos()
                               where x.id > activo_fijo.id
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
                activo_fijo = (from x in ActivoFijo.ActivosFijos()
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
                if (activo_fijo.id != 0)
                {
                    activo_fijo = new ActivoFijo();
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
                DataTable dataTable = Utilidades.Busqueda("activos_fijos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        activo_fijo = ActivoFijo.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        activo_fijo = ActivoFijo.Obtener(frmResultadosBusqueda2.id);
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
            activo_fijo = new ActivoFijo();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && activo_fijo.id == 0)
            {
                Buscar();
            }
        }

    }
}
