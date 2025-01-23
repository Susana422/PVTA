using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmMonederos : RibbonForm
    {
        private Monedero monedero = new Monedero();

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

        private LabelControl lblFolio;

        private TextEdit txtFolio;

        private CheckEdit cbActivo;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LookUpEdit cbSocios;

        private HyperlinkLabelControl lblSocios;

        private TextEdit txtSaldo;

        private LabelControl labelControl1;

        private CheckEdit cbPredeterminado;

        private BarButtonItem bbiMovimientos;

        private SimpleButton btnRecargar;

        public frmMonederos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                try
                {
                    monedero = (from x in Monedero.Monederos()
                                where x.socio_id == id && x.predeterminado == true
                                select x).First();
                    Cargar();
                }
                catch
                {
                }
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DataSource = (from x in Socio.Socios()
                                                                              where x.activo == true && x.tipo == 'C'
                                                                              select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbSocios).EditValue = id;
        }

        private void Permisos()
        {
            char rol = Program.dtm.UsuarioAutenticado.rol;
            char c = rol;
            if (c == 'C')
            {
                mainRibbonPageGroup.Visible = false;
            }
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = monedero.id.ToString();
            ((BaseEdit)cbSocios).EditValue = monedero.socio_id;
            ((Control)(object)txtFolio).Text = monedero.folio.ToString();
            ((Control)(object)txtSaldo).Text = monedero.saldo.ToString();
            cbPredeterminado.Checked = monedero.predeterminado;
            cbActivo.Checked = monedero.activo;
            ((Control)(object)lblFechaActualizacion).Text = monedero.fecha_actualizacion.ToShortDateString();
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)cbSocios).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtFolio).Focus();
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
            monedero.socio_id = (int)((BaseEdit)cbSocios).EditValue;
            monedero.folio = ((BaseEdit)txtFolio).EditValue.ToString();
            monedero.predeterminado = cbPredeterminado.Checked;
            monedero.activo = cbActivo.Checked;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (monedero.id != 0)
                    {
                        return monedero.Actualizar();
                    }
                    return monedero.Agregar();
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
                monedero = new Monedero();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                monedero = (from x in Monedero.Monederos()
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
                monedero = (from x in Monedero.Monederos()
                            where x.id < monedero.id
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
                monedero = (from x in Monedero.Monederos()
                            where x.id > monedero.id
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
                monedero = (from x in Monedero.Monederos()
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
                if (monedero.id != 0)
                {
                    monedero = new Monedero();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, folio, predeterminado, activo",
                    like = true
                };
                object objeto = new
                {
                    socio_id = (((BaseEdit)cbSocios).EditValue.IsNullOrEmpty() ? null : ((BaseEdit)cbSocios).EditValue),
                    folio = ((Control)(object)txtFolio).Text
                };
                DataTable dataTable = Utilidades.Busqueda("monederos", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        monedero = Monedero.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        monedero = Monedero.Obtener(frmResultadosBusqueda2.id);
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
            monedero = new Monedero();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && monedero.id == 0)
            {
                Buscar();
            }
        }

        private void bbiMovimientos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(Utilidades.EjecutarQuery($"select partidas_monedero.id ID, documentos.id 'Documento ID', documentos.clase Clase, partidas.nombre Nombre, partidas_monedero.importe Importe, partidas_monedero.fecha_creacion Fecha from partidas_monedero left join partidas on partidas_monedero.partida_id = partidas.id left join documentos on partidas_monedero.documento_id = documentos.id where partidas_monedero.monedero_id = {monedero.id} order by partidas_monedero.id desc"));
            ((Form)(object)frmResultadosBusqueda2).ShowDialog();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Ingresa el importe a recargar", "0");
            Monedero.Partida partida = new Monedero.Partida
            {
                monedero_id = monedero.id,
                documento_id = 0,
                partida_id = 0,
                importe = decimal.Parse(s)
            };
            if (partida.Agregar())
            {
                Cargar();
                MessageBox.Show("Recarga realizada correctamente.", "");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar.");
            }
        }


    }

}
