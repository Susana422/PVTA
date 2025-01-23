using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmImpuestos : RibbonForm
    {
        private Impuesto impuesto = new Impuesto();

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

        private LabelControl lblPorcentaje;

        private TextEdit txtPorcentaje;

        private LabelControl lblTipoImpuesto;

        private CheckEdit cbVenta;

        private CheckEdit cbCompra;

        private LookUpEdit cbTiposFactores;

        private CheckEdit cbActivo;

        private GridControl gcLineas;

        private GridView gvLineas;

        private GridColumn gridColumnCodigo;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnImpuesto;

        private GridColumn gridColumnPorcentaje;

        public frmImpuestos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                impuesto = Impuesto.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
            CargarListas();
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

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbTiposFactores.Properties).DataSource = Impuesto.TipoFactor.Tipos();
            ((RepositoryItemLookUpEditBase)cbTiposFactores.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTiposFactores.Properties).DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = impuesto.id.ToString();
            ((Control)(object)txtCodigo).Text = impuesto.codigo;
            ((BaseEdit)cbTiposFactores).EditValue = impuesto.tipo_factor;
            ((Control)(object)txtNombre).Text = impuesto.nombre;
            cbCompra.Checked = impuesto.compra;
            cbVenta.Checked = impuesto.venta;
            ((Control)(object)txtPorcentaje).Text = impuesto.porcentaje.ToString();
            cbActivo.Checked = impuesto.activo;
            ((Control)(object)lblFechaActualizacion).Text = impuesto.fecha_actualizacion.ToShortDateString();
            impuesto.ObtenerLineas();
            gcLineas.DataSource = impuesto.lineas;
            gcLineas.RefreshDataSource();
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
            impuesto.codigo = ((Control)(object)txtCodigo).Text;
            impuesto.tipo_factor = (char)((BaseEdit)cbTiposFactores).EditValue;
            impuesto.nombre = ((Control)(object)txtNombre).Text;
            impuesto.compra = cbCompra.Checked;
            impuesto.venta = cbVenta.Checked;
            impuesto.porcentaje = decimal.Parse(((Control)(object)txtPorcentaje).Text);
            impuesto.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (impuesto.id != 0)
                    {
                        return impuesto.Actualizar();
                    }
                    return impuesto.Agregar();
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
                impuesto = new Impuesto();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                impuesto = (from x in Impuesto.Impuestos()
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
                impuesto = (from x in Impuesto.Impuestos()
                            where x.id < impuesto.id
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
                impuesto = (from x in Impuesto.Impuestos()
                            where x.id > impuesto.id
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
                impuesto = (from x in Impuesto.Impuestos()
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
                if (impuesto.id != 0)
                {
                    impuesto = new Impuesto();
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
                DataTable dataTable = Utilidades.Busqueda("impuestos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        impuesto = Impuesto.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        impuesto = Impuesto.Obtener(frmResultadosBusqueda2.id);
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
            impuesto = new Impuesto();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && impuesto.id == 0)
            {
                Buscar();
            }
        }


    }

}
