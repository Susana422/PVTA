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
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmInformes : RibbonForm
    {
        private Informe informe = new Informe();

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

        private LabelControl lblTipo;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbTipos;

        private TextEdit txtDescripcion;

        private LabelControl lblDescripcion;

        private TextEdit txtInforme;

        private LabelControl lblInforme;

        private SimpleButton btnInforme;

        private LookUpEdit cbTiposInforme;

        private LabelControl lblTipoInforme;

        private CheckEdit cbPredeterminado;

        private SimpleButton btnEditarInforme;

        private CheckEdit cbAlmacen;

        private TextEdit txtCopias;

        private LabelControl lblCopias;

        private LookUpEdit cbInformeSecuencia;

        private LabelControl lblInformeSecuencia;

        private CheckEdit cbPredeterminadoCorreoElectronico;

        private HyperlinkLabelControl lblQuitarSecuencia;

        private LookUpEdit cbImpresoras;

        private LabelControl lblImpresora;

        public frmInformes(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                informe = Informe.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarImpresoras();
            Permisos();
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).DataSource = Informe.Tipo.Tipos();
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTipos.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbTiposInforme.Properties).DataSource = Informe.TipoInforme.TipoInformes();
            ((RepositoryItemLookUpEditBase)cbTiposInforme.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTiposInforme.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbInformeSecuencia.Properties).DataSource = from x in Informe.Informes()
                                                                                       where x.activo == true
                                                                                       select new { x.id, x.tipo, x.nombre };
            ((RepositoryItemLookUpEditBase)cbInformeSecuencia.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbInformeSecuencia.Properties).DisplayMember = "nombre";
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

        private void CargarImpresoras()
        {
            List<string> list = new List<string>();
            list.Add(string.Empty);
            foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
            {
                list.Add(installedPrinter.ToString());
            }
            ((RepositoryItemLookUpEditBase)cbImpresoras.Properties).DataSource = list;
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = informe.id.ToString();
            ((BaseEdit)cbTipos).EditValue = informe.tipo;
            ((Control)(object)txtNombre).Text = informe.nombre;
            ((Control)(object)txtDescripcion).Text = informe.descripcion;
            ((Control)(object)txtInforme).Text = informe.informe;
            ((BaseEdit)cbTiposInforme).EditValue = informe.tipo_informe;
            ((BaseEdit)cbInformeSecuencia).EditValue = informe.informe_sequencia_id;
            ((Control)(object)txtCopias).Text = informe.copias.ToString();
            ((BaseEdit)cbImpresoras).EditValue = informe.impresora;
            cbPredeterminado.Checked = informe.predeterminado;
            cbPredeterminadoCorreoElectronico.Checked = informe.predeterminado_correo_electronico;
            cbAlmacen.Checked = informe.almacen;
            cbActivo.Checked = informe.activo;
            ((Control)(object)lblFechaActualizacion).Text = informe.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((BarItem)bbiEliminar).Enabled = false;
                ((Control)(object)btnEditarInforme).Enabled = false;
                ((Control)(object)cbTipos).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((BarItem)bbiEliminar).Enabled = false;
                ((Control)(object)btnEditarInforme).Enabled = false;
                ((Control)(object)cbTipos).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((BarItem)bbiEliminar).Enabled = true;
                ((Control)(object)btnEditarInforme).Enabled = true;
            }
        }

        private void Llenar()
        {
            informe.tipo = ((BaseEdit)cbTipos).EditValue.ToString();
            informe.nombre = ((Control)(object)txtNombre).Text;
            informe.descripcion = ((Control)(object)txtDescripcion).Text;
            informe.informe = ((Control)(object)txtInforme).Text;
            informe.tipo_informe = (char)((BaseEdit)cbTiposInforme).EditValue;
            informe.informe_sequencia_id = ((!((BaseEdit)cbInformeSecuencia).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbInformeSecuencia).EditValue) : 0);
            informe.copias = int.Parse(((Control)(object)txtCopias).Text);
            informe.impresora = ((BaseEdit)cbImpresoras).EditValue.ToString();
            informe.almacen = cbAlmacen.Checked;
            informe.predeterminado = cbPredeterminado.Checked;
            informe.predeterminado_correo_electronico = cbPredeterminadoCorreoElectronico.Checked;
            informe.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (informe.id != 0)
                    {
                        return informe.Actualizar();
                    }
                    return informe.Agregar();
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
                informe = new Informe();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                informe = (from x in Informe.Informes()
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
                informe = (from x in Informe.Informes()
                           where x.id < informe.id
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
                informe = (from x in Informe.Informes()
                           where x.id > informe.id
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
                informe = (from x in Informe.Informes()
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
                if (informe.id != 0)
                {
                    informe = new Informe();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, nombre, descripcion, informe, tipo, activo",
                    like = true
                };
                object objeto = new
                {
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("informes", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        informe = Informe.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        informe = Informe.Obtener(frmResultadosBusqueda2.id);
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
            informe = new Informe();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && informe.id == 0)
            {
                Buscar();
            }
        }

        private void btnEditarInforme_Click(object sender, EventArgs e)
        {
            if (((Control)(object)txtInforme).Text.Length > 0)
            {
                frmDiseñadorInformes frmDiseñadorInformes2 = new frmDiseñadorInformes();
                frmDiseñadorInformes2.AbrirInforme(Path.Combine(Program.Nori.Configuracion.directorio_informes, ((Control)(object)txtInforme).Text));
                ((Control)(object)frmDiseñadorInformes2).Show();
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Program.Nori.Configuracion.directorio_informes;
            openFileDialog.Filter = "Archivos de informe (*.repx) | *.repx";
            openFileDialog.Title = "Por favor seleccione un informe.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ((Control)(object)txtInforme).Text = openFileDialog.SafeFileName;
            }
        }

        private void bbiEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de eliminar este elemento?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes && informe.id != 0)
                {
                    if (informe.Eliminar())
                    {
                        ((BarItem)bbiUltimo).PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
        }

        private void lblQuitarSecuencia_Click(object sender, EventArgs e)
        {
            ((BaseEdit)cbInformeSecuencia).EditValue = 0;
        }


    }
}
