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
    public partial class frmMetodosPago : RibbonForm
    {
        private MetodoPago metodo_pago = new MetodoPago();

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

        private LookUpEdit cbTiposMetodosPago;

        private HyperlinkLabelControl lblTiposMetodosPago;

        private RadioGroup rgOpciones;

        private TextEdit txtCodigoSAT;

        private LabelControl lblCodigoSAT;

        public frmMetodosPago(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                metodo_pago = MetodoPago.Obtener(id);
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
            if (metodo_pago.id != 0)
            {
                object parametros = new
                {
                    fields = "id, nombre"
                };
                object objeto = new
                {
                    metodo_pago_id = metodo_pago.id,
                    activo = 1
                };
                ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).DataSource = Utilidades.Busqueda("tipos_metodos_pago", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbTiposMetodosPago).EditValue = metodo_pago.tipo_metodo_pago_id;
            }
            ((Control)(object)lblID).Text = metodo_pago.id.ToString();
            ((Control)(object)txtCodigo).Text = metodo_pago.codigo;
            ((Control)(object)txtCodigoSAT).Text = metodo_pago.codigo_sat;
            ((Control)(object)txtNombre).Text = metodo_pago.nombre;
            rgOpciones.SelectedIndex = ((!metodo_pago.tipo.Equals('E')) ? 1 : 0);
            cbActivo.Checked = metodo_pago.activo;
            ((Control)(object)lblFechaActualizacion).Text = metodo_pago.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbTiposMetodosPago).Enabled = false;
                ((Control)(object)txtCodigo).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)cbTiposMetodosPago).Enabled = false;
                ((Control)(object)txtCodigo).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbTiposMetodosPago).Enabled = true;
            }
        }

        private void Llenar()
        {
            metodo_pago.codigo = ((Control)(object)txtCodigo).Text;
            metodo_pago.codigo_sat = ((Control)(object)txtCodigoSAT).Text;
            metodo_pago.nombre = ((Control)(object)txtNombre).Text;
            metodo_pago.tipo_metodo_pago_id = ((!((BaseEdit)cbTiposMetodosPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbTiposMetodosPago).EditValue) : 0);
            metodo_pago.tipo = ((rgOpciones.SelectedIndex == 0) ? 'E' : 'S');
            metodo_pago.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (metodo_pago.id != 0)
                    {
                        return metodo_pago.Actualizar();
                    }
                    return metodo_pago.Agregar();
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
                metodo_pago = new MetodoPago();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                metodo_pago = (from x in MetodoPago.MetodosPago()
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
                metodo_pago = (from x in MetodoPago.MetodosPago()
                               where x.id < metodo_pago.id
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
                metodo_pago = (from x in MetodoPago.MetodosPago()
                               where x.id > metodo_pago.id
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
                metodo_pago = (from x in MetodoPago.MetodosPago()
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
                if (metodo_pago.id != 0)
                {
                    metodo_pago = new MetodoPago();
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
                DataTable dataTable = Utilidades.Busqueda("metodos_pago", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        metodo_pago = MetodoPago.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        metodo_pago = MetodoPago.Obtener(frmResultadosBusqueda2.id);
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
            metodo_pago = new MetodoPago();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && metodo_pago.id == 0)
            {
                Buscar();
            }
        }

        private void lblTiposMetodosPago_Click(object sender, EventArgs e)
        {
            frmTiposMetodosPago frmTiposMetodosPago2 = new frmTiposMetodosPago();
            ((Form)(object)frmTiposMetodosPago2).ShowDialog();
        }
    }

}
