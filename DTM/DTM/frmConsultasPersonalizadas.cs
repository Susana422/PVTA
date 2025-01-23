using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmConsultasPersonalizadas : RibbonForm
    {
        private ConsultaPersonalizada consulta_personalizada = new ConsultaPersonalizada();

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

        private GridView gridView1;

        private LayoutControl layoutControl1;

        private Panel panel1;

        private SimpleButton btnEjecutar;

        private LabelControl lblQuery;

        private MemoEdit txtQuery;

        private SeparatorControl separatorControl1;

        private LabelControl lblFechaActualizacion;

        private TextEdit txtNombre;

        private LabelControl lblUltimaActualizacion;

        private CheckEdit cbActivo;

        private LabelControl lblNombre;

        private LabelControl lblID;

        private LayoutControlGroup layoutControlGroup1;

        private LayoutControlItem layoutControlItem1;

        private SimpleButton btnXSLX;

        private SimpleButton btnPDF;

        private GridControl gcResultados;

        private GridView gvResultados;

        private TextEdit txtContexto;

        private LabelControl lblContexto;

        public frmConsultasPersonalizadas(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                consulta_personalizada = ConsultaPersonalizada.Obtener(id);
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

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = consulta_personalizada.id.ToString();
            ((Control)(object)txtNombre).Text = consulta_personalizada.nombre;
            ((Control)(object)txtContexto).Text = consulta_personalizada.contexto;
            ((Control)(object)txtQuery).Text = consulta_personalizada.query;
            cbActivo.Checked = consulta_personalizada.activo;
            ((Control)(object)lblFechaActualizacion).Text = consulta_personalizada.fecha_actualizacion.ToShortDateString();
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

        private void Llenar()
        {
            consulta_personalizada.nombre = ((Control)(object)txtNombre).Text;
            consulta_personalizada.contexto = ((Control)(object)txtContexto).Text;
            consulta_personalizada.query = ((Control)(object)txtQuery).Text;
            consulta_personalizada.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (consulta_personalizada.id != 0)
                    {
                        return consulta_personalizada.Actualizar();
                    }
                    return consulta_personalizada.Agregar();
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
                consulta_personalizada = new ConsultaPersonalizada();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                consulta_personalizada = (from x in ConsultaPersonalizada.ConsultasPersonalizadas()
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
                consulta_personalizada = (from x in ConsultaPersonalizada.ConsultasPersonalizadas()
                                          where x.id < consulta_personalizada.id
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
                consulta_personalizada = (from x in ConsultaPersonalizada.ConsultasPersonalizadas()
                                          where x.id > consulta_personalizada.id
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
                consulta_personalizada = (from x in ConsultaPersonalizada.ConsultasPersonalizadas()
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
                if (consulta_personalizada.id != 0)
                {
                    consulta_personalizada = new ConsultaPersonalizada();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, nombre, activo",
                    like = true
                };
                object objeto = new
                {
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("consultas_personalizadas", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        consulta_personalizada = ConsultaPersonalizada.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        consulta_personalizada = ConsultaPersonalizada.Obtener(frmResultadosBusqueda2.id);
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
            consulta_personalizada = new ConsultaPersonalizada();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && consulta_personalizada.id == 0)
            {
                Buscar();
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            consulta_personalizada.query = ((Control)(object)txtQuery).Text;
            gcResultados.DataSource = consulta_personalizada.Ejecutar();
            gcResultados.RefreshDataSource();
            ((CollectionBase)(object)((ColumnView)gvResultados).Columns).Clear();
            ((BaseView)gvResultados).PopulateColumns();
        }

        private void btnXSLX_Click(object sender, EventArgs e)
        {
            try
            {
                string text = $"{Program.dtm.Configuracion.directorio_documentos}\\{consulta_personalizada.id}.xlsx";
                gcResultados.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string text = $"{Program.dtm.Configuracion.directorio_documentos}\\{consulta_personalizada.id}.pdf";
                gcResultados.ExportToPdf(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


    }

}
