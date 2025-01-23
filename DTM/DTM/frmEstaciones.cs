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
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmEstaciones : RibbonForm
    {
        private Estacion estacion = new Estacion();

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

        private CheckEdit cbLectorHuella;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LabelControl lblImpresoraDocumentos;

        private LabelControl lblImpresoraTickets;

        private LookUpEdit cbImpresoraDocumentos;

        private LookUpEdit cbImpresoraTickets;

        private LookUpEdit cbBasculas;

        private CheckEdit cbBascula;

        private HyperlinkLabelControl lblBasculas;

        private CheckEdit cbImpresion;

        private CheckEdit cbEnvioCorreoAutomatico;

        public frmEstaciones(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                estacion = Estacion.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarImpresoras();
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
            ((Control)(object)lblID).Text = estacion.id.ToString();
            ((Control)(object)txtCodigo).Text = estacion.codigo;
            ((Control)(object)txtNombre).Text = estacion.nombre;
            ((BaseEdit)cbImpresoraTickets).EditValue = estacion.impresora_tickets;
            ((BaseEdit)cbImpresoraDocumentos).EditValue = estacion.impresora_documentos;
            cbLectorHuella.Checked = estacion.lector_huella;
            cbBascula.Checked = estacion.bascula;
            ((BaseEdit)cbBasculas).EditValue = estacion.bascula_id;
            cbImpresion.Checked = estacion.impresion;
            cbEnvioCorreoAutomatico.Checked = estacion.envio_correo_automatico;
            cbActivo.Checked = estacion.activo;
            ((Control)(object)lblFechaActualizacion).Text = estacion.fecha_actualizacion.ToShortDateString();
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

        private void CargarImpresoras()
        {
            List<string> list = new List<string>();
            foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
            {
                list.Add(installedPrinter.ToString());
            }
            ((RepositoryItemLookUpEditBase)cbImpresoraTickets.Properties).DataSource = list;
            ((RepositoryItemLookUpEditBase)cbImpresoraDocumentos.Properties).DataSource = list;
        }

        private void CargarListas()
        {
            ((RepositoryItemLookUpEditBase)cbBasculas.Properties).DataSource = (from x in Bascula.Basculas()
                                                                                where x.activo == true
                                                                                select new { x.id, x.puerto, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbBasculas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbBasculas.Properties).DisplayMember = "nombre";
        }

        private void Llenar()
        {
            estacion.codigo = ((Control)(object)txtCodigo).Text;
            estacion.nombre = ((Control)(object)txtNombre).Text;
            estacion.impresora_tickets = ((BaseEdit)cbImpresoraTickets).EditValue.ToString();
            estacion.impresora_documentos = ((BaseEdit)cbImpresoraDocumentos).EditValue.ToString();
            estacion.lector_huella = cbLectorHuella.Checked;
            estacion.bascula = cbBascula.Checked;
            estacion.bascula_id = ((!((BaseEdit)cbBasculas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbBasculas).EditValue) : 0);
            estacion.impresion = cbImpresion.Checked;
            estacion.envio_correo_automatico = cbEnvioCorreoAutomatico.Checked;
            estacion.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (estacion.id != 0)
                    {
                        return estacion.Actualizar();
                    }
                    return estacion.Agregar();
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
                estacion = new Estacion();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                estacion = (from x in Estacion.Estaciones()
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
                estacion = (from x in Estacion.Estaciones()
                            where x.id < estacion.id
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
                estacion = (from x in Estacion.Estaciones()
                            where x.id > estacion.id
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
                estacion = (from x in Estacion.Estaciones()
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
                if (estacion.id != 0)
                {
                    estacion = new Estacion();
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
                DataTable dataTable = Utilidades.Busqueda("estaciones", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        estacion = Estacion.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        estacion = Estacion.Obtener(frmResultadosBusqueda2.id);
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
            estacion = new Estacion();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && estacion.id == 0)
            {
                Buscar();
            }
        }

        private void lblBasculas_Click(object sender, EventArgs e)
        {
            frmBasculas frmBasculas2 = new frmBasculas();
            ((Form)(object)frmBasculas2).ShowDialog();
        }

        private void frmEstaciones_Load(object sender, EventArgs e)
        {
        }


    }

}
