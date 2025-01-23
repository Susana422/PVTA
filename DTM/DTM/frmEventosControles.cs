using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmEventosControles : RibbonForm
    {
        private EventoControl evento_control = new EventoControl();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRefresh;

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

        private LabelControl lblControl;

        private LabelControl lblFormulario;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private ComboBoxEdit cbEventos;

        private LabelControl lblEvento;

        private LabelControl lblQuery;

        private MemoEdit txtQuery;

        private LookUpEdit cbFormularios;

        private LookUpEdit cbControles;

        private LookUpEdit cbControlDestino;

        private LabelControl lblControlDestino;

        private TextEdit txtControlDestino;

        private TextEdit txtControl;

        private TextEdit txtFormulario;

        public frmEventosControles(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarFormulariosAbiertos();
            if (id != 0)
            {
                evento_control = EventoControl.Obtener(id);
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

        private void CargarFormulariosAbiertos()
        {
            List<string> list = new List<string>();
            for (int num = Application.OpenForms.Count - 1; num >= 0; num--)
            {
                if (Application.OpenForms[num].Name.Length > 0)
                {
                    list.Add(Application.OpenForms[num].Name);
                }
            }
            ((RepositoryItemLookUpEditBase)cbFormularios.Properties).DataSource = list;
        }

        private void CargarControles()
        {
            List<string> list = new List<string>();
            Form root = Application.OpenForms[((Control)(object)cbFormularios).Text];
            foreach (Control item in root.ObtenerControles().OfType<Control>())
            {
                list.Add(item.Name);
            }
            if (list.Count > 0)
            {
                ((RepositoryItemLookUpEditBase)cbControles.Properties).DataSource = list;
                ((RepositoryItemLookUpEditBase)cbControlDestino.Properties).DataSource = list;
            }
            else
            {
                ((Control)(object)cbControles).Enabled = false;
                ((Control)(object)cbControlDestino).Enabled = false;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = evento_control.id.ToString();
            ((Control)(object)txtFormulario).Text = evento_control.formulario;
            ((Control)(object)txtControl).Text = evento_control.control;
            ((Control)(object)txtControlDestino).Text = evento_control.control_destino;
            ((BaseEdit)cbEventos).EditValue = evento_control.evento;
            ((Control)(object)txtQuery).Text = evento_control.query;
            cbActivo.Checked = evento_control.activo;
            ((Control)(object)lblFechaActualizacion).Text = evento_control.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbFormularios).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)cbFormularios).Focus();
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
            evento_control.formulario = ((Control)(object)txtFormulario).Text;
            evento_control.control = ((Control)(object)txtControl).Text;
            evento_control.control_destino = ((Control)(object)txtControlDestino).Text;
            evento_control.evento = ((BaseEdit)cbEventos).EditValue.ToString();
            evento_control.query = ((Control)(object)txtQuery).Text;
            evento_control.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (evento_control.id != 0)
                    {
                        return evento_control.Actualizar();
                    }
                    return evento_control.Agregar();
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
                evento_control = new EventoControl();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                evento_control = (from x in EventoControl.EventosControles()
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
                evento_control = (from x in EventoControl.EventosControles()
                                  where x.id < evento_control.id
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
                evento_control = (from x in EventoControl.EventosControles()
                                  where x.id > evento_control.id
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
                evento_control = (from x in EventoControl.EventosControles()
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
                if (evento_control.id != 0)
                {
                    evento_control = new EventoControl();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, formulario, control, evento, query",
                    like = true
                };
                object objeto = new { };
                DataTable dataTable = Utilidades.Busqueda("eventos_controles", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        evento_control = EventoControl.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        evento_control = EventoControl.Obtener(frmResultadosBusqueda2.id);
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
            evento_control = new EventoControl();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && evento_control.id == 0)
            {
                Buscar();
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarFormulariosAbiertos();
        }

        private void cbFormularios_TextChanged(object sender, EventArgs e)
        {
            CargarControles();
            ((Control)(object)txtFormulario).Text = ((Control)(object)cbFormularios).Text;
        }

        private void cbControles_TextChanged(object sender, EventArgs e)
        {
            ((Control)(object)txtControl).Text = ((Control)(object)cbControles).Text;
        }

        private void cbControlDestino_TextChanged(object sender, EventArgs e)
        {
            ((Control)(object)txtControlDestino).Text = ((Control)(object)cbControlDestino).Text;
        }


    }
}
