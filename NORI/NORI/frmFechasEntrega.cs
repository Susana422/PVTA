using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace NORI
{
    public partial class frmFechasEntrega : RibbonForm
    {
        private FechaEntrega fecha_entrega = new FechaEntrega();

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

        private CheckEdit cbPaqueteria;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private BarButtonItem bbiUsuarios;

        private LookUpEdit cbDia1;

        private LabelControl lblDia1;

        private LookUpEdit cbDia3;

        private LabelControl lblDia3;

        private LookUpEdit cbDia2;

        private LabelControl lblDia2;

        private LookUpEdit cbRutas;

        private HyperlinkLabelControl lblRuta;

        public frmFechasEntrega(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                fecha_entrega = FechaEntrega.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarListas();
            Permisos();
        }

        private void CargarListas()
        {
            List<string> dataSource = new List<string> { "No aplica", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            ((RepositoryItemLookUpEditBase)cbDia1.Properties).DataSource = dataSource;
            ((RepositoryItemLookUpEditBase)cbDia2.Properties).DataSource = dataSource;
            ((RepositoryItemLookUpEditBase)cbDia3.Properties).DataSource = dataSource;
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).DataSource = (from x in Ruta.Rutas()
                                                                             where x.activo == true
                                                                             select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).DisplayMember = "nombre";
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
            ((Control)(object)lblID).Text = fecha_entrega.id.ToString();
            ((Control)(object)txtCodigo).Text = fecha_entrega.codigo;
            ((Control)(object)txtNombre).Text = fecha_entrega.nombre;
            cbDia1.ItemIndex = fecha_entrega.dia1;
            cbDia2.ItemIndex = fecha_entrega.dia2;
            cbDia3.ItemIndex = fecha_entrega.dia3;
            ((BaseEdit)cbRutas).EditValue = fecha_entrega.ruta_id;
            cbPaqueteria.Checked = fecha_entrega.paqueteria;
            ((Control)(object)lblFechaActualizacion).Text = fecha_entrega.fecha_actualizacion.ToShortDateString();
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
                fecha_entrega.codigo = ((Control)(object)txtCodigo).Text;
                fecha_entrega.nombre = ((Control)(object)txtNombre).Text;
                fecha_entrega.dia1 = cbDia1.ItemIndex;
                fecha_entrega.dia2 = cbDia2.ItemIndex;
                fecha_entrega.dia3 = cbDia3.ItemIndex;
                fecha_entrega.ruta_id = ((!((BaseEdit)cbRutas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbRutas).EditValue) : 0);
                fecha_entrega.paqueteria = cbPaqueteria.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (fecha_entrega.id != 0)
                    {
                        return fecha_entrega.Actualizar();
                    }
                    return fecha_entrega.Agregar();
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
                fecha_entrega = new FechaEntrega();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fecha_entrega = (from x in FechaEntrega.FechasEntrega()
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
                fecha_entrega = (from x in FechaEntrega.FechasEntrega()
                                 where x.id < fecha_entrega.id
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
                fecha_entrega = (from x in FechaEntrega.FechasEntrega()
                                 where x.id > fecha_entrega.id
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
                fecha_entrega = (from x in FechaEntrega.FechasEntrega()
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
                if (fecha_entrega.id != 0)
                {
                    fecha_entrega = new FechaEntrega();
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
                DataTable dataTable = Utilidades.Busqueda("fechas_entrega", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        fecha_entrega = FechaEntrega.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        fecha_entrega = FechaEntrega.Obtener(frmResultadosBusqueda2.id);
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
            fecha_entrega = new FechaEntrega();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && fecha_entrega.id == 0)
            {
                Buscar();
            }
        }

        private void lblRuta_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas2 = new frmRutas();
            ((Form)(object)frmRutas2).ShowDialog();
            CargarListas();
        }


    }

}
