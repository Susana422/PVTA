using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmSeries : RibbonForm
    {
        private Serie serie = new Serie();

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

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbClases;

        private LabelControl lblClase;

        private CheckEdit cbActivo;

        private TextEdit txtSiguiente;

        private LabelControl lblSiguiente;

        private TextEdit txtInicial;

        private LabelControl labelControl1;

        private TextEdit txtFinal;

        private LabelControl lblFinal;

        private CheckEdit cbPredeterminado;

        private BarButtonItem bbiUsuarios;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private CheckEdit cbPredeterminadoCancelacion;

        private CheckEdit cbFacturarAutomaticamente;

        private GroupControl gcFacturacion;

        private LookUpEdit cbSeriesFacturacion;

        private LabelControl lblSerieFacturacionAutomatica;

        private CheckEdit cbDigital;

        private LookUpEdit cbAlmacenes;

        private HyperlinkLabelControl lblAlmacenes;

        public frmSeries(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                serie = Serie.Obtener(id);
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

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = serie.id.ToString();
            ((Control)(object)txtCodigo).Text = serie.codigo.ToString();
            ((Control)(object)txtNombre).Text = serie.nombre;
            ((BaseEdit)cbClases).EditValue = serie.clase;
            ((Control)(object)txtInicial).Text = serie.inicial.ToString();
            ((Control)(object)txtSiguiente).Text = serie.siguiente.ToString();
            ((Control)(object)txtFinal).Text = serie.final.ToString();
            ((BaseEdit)cbAlmacenes).EditValue = serie.almacen_id;
            cbPredeterminado.Checked = serie.predeterminado;
            cbPredeterminadoCancelacion.Checked = serie.predeterminado_cancelacion;
            cbDigital.Checked = serie.digital;
            cbFacturarAutomaticamente.Checked = serie.facturar_automaticamente;
            if (cbFacturarAutomaticamente.Checked)
            {
                ((BaseEdit)cbSeriesFacturacion).EditValue = serie.serie_facturacion_id;
            }
            cbActivo.Checked = serie.activo;
            ((Control)(object)lblFechaActualizacion).Text = serie.fecha_actualizacion.ToShortDateString();
            ((Control)(object)gcFacturacion).Visible = ((serie.clase.Equals("EN") && serie.id != 0) ? true : false);
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtCodigo).Focus();
                ((Control)(object)txtCodigo).Enabled = true;
                ((Control)(object)txtInicial).Enabled = true;
                ((Control)(object)txtFinal).Enabled = true;
                return;
            }
            if (busqueda)
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
            ((Control)(object)txtCodigo).Enabled = false;
            ((Control)(object)txtInicial).Enabled = false;
            ((Control)(object)txtFinal).Enabled = false;
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbClases.Properties).DataSource = Documento.Clase.Clases();
            ((RepositoryItemLookUpEditBase)cbClases.Properties).ValueMember = "clase";
            ((RepositoryItemLookUpEditBase)cbClases.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbSeriesFacturacion.Properties).DataSource = (from x in Serie.Series()
                                                                                         where x.activo == true && x.clase == "FA"
                                                                                         select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSeriesFacturacion.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSeriesFacturacion.Properties).DisplayMember = "nombre";
            var list = (from x in Almacen.Almacenes()
                        where x.activo == true
                        select new { x.id, x.codigo, x.nombre }).ToList();
            list.Insert(0, new
            {
                id = 0,
                codigo = "NA",
                nombre = "-- Ningún almacén --"
            });
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DataSource = list;
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DisplayMember = "nombre";
        }

        private void Llenar()
        {
            try
            {
                serie.codigo = short.Parse(((Control)(object)txtCodigo).Text);
                serie.nombre = ((Control)(object)txtNombre).Text;
                serie.clase = ((BaseEdit)cbClases).EditValue.ToString();
                serie.inicial = int.Parse(((Control)(object)txtInicial).Text);
                serie.siguiente = int.Parse(((Control)(object)txtSiguiente).Text);
                serie.final = int.Parse(((Control)(object)txtFinal).Text);
                serie.almacen_id = ((!((BaseEdit)cbAlmacenes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbAlmacenes).EditValue) : 0);
                serie.predeterminado = cbPredeterminado.Checked;
                serie.predeterminado_cancelacion = cbPredeterminadoCancelacion.Checked;
                serie.digital = cbDigital.Checked;
                serie.facturar_automaticamente = cbFacturarAutomaticamente.Checked;
                if (cbFacturarAutomaticamente.Checked)
                {
                    serie.serie_facturacion_id = (int)((BaseEdit)cbSeriesFacturacion).EditValue;
                }
                serie.activo = cbActivo.Checked;
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
                    if (serie.id != 0)
                    {
                        return serie.Actualizar();
                    }
                    return serie.Agregar();
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
                serie = new Serie();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                serie = (from x in Serie.Series()
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
                serie = (from x in Serie.Series()
                         where x.id < serie.id
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
                serie = (from x in Serie.Series()
                         where x.id > serie.id
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
                serie = (from x in Serie.Series()
                         orderby x.id descending
                         select x).First();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (serie.id != 0)
                {
                    serie = new Serie();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, codigo, nombre",
                    like = true
                };
                object objeto = new
                {
                    codigo = ((Control)(object)txtCodigo).Text,
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("series", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        serie = Serie.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        serie = Serie.Obtener(frmResultadosBusqueda2.id);
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
            serie = new Serie();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && serie.id == 0)
            {
                Buscar();
            }
        }

        private void bbiUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuariosSeries frmUsuariosSeries2 = new frmUsuariosSeries();
            ((Control)(object)frmUsuariosSeries2).Show();
        }


    }
}
