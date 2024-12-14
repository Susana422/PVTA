using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using NoriSDK;

namespace NORI
{
    public partial class frmPagos : RibbonForm
    {
        private Pago pago = new Pago();

        private Socio socio = new Socio();

        internal List<MetodoPago.Tipo> tipos_metodos_pago;

        internal decimal importe_aplicado = default(decimal);

        internal decimal saldo_pendiente = default(decimal);

        private const string clase = "PR";

        internal bool solo_ppd = true;

        internal bool solo_pue = true;

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiCancelar;

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

        private BarSubItem bbiImprimir;

        private BarSubItem bbiPDF;

        private PopupMenu popupMenuPagos;

        private BarButtonItem bbiPagosFinanciados;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private BarButtonItem bbiMapaRelaciones;

        private BarHeaderItem barHeaderItem1;

        private BarHeaderItem barHeaderItem2;

        private BarButtonItem bbiEnviar;

        private BarButtonItem bbiNuevoMetodoPago;

        private PanelControl panelControl1;

        private TextEdit txtFechaDocumento;

        private LabelControl lblFechaDocumento;

        private Label lblCancelado;

        private TextEdit txtTipoCambio;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private DateEdit deFechaContabilizacion;

        private LabelControl lblSocio;

        private LabelControl lblReferencia;

        private TextEdit txtReferencia;

        private LookUpEdit cbSeries;

        private LabelControl lblNumeroDocumento;

        private TextEdit txtNumeroDocumento;

        private TextEdit txtFechaVencimiento;

        private LabelControl lblFechaVencimiento;

        private LabelControl lblFechaContabilizacion;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageContenido;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnPartidaID;

        private GridColumn gridColumnPagoID;

        private GridColumn gridColumnDocumentoID;

        private GridColumn gridColumnNumeroDocumento;

        private GridColumn gridColumnTipoDocumento;

        private GridColumn gridColumnMetodoPagoSAT;

        private GridColumn gridColumnFecha;

        private GridColumn gridColumnFechaVencimiento;

        private GridColumn gridColumnMoneda;

        private GridColumn gridColumnMonedaID;

        private GridColumn gridColumnTipoCambio;

        private GridColumn gridColumnTotal;

        private GridColumn gridColumnImporteAplicado;

        private GridColumn gridColumnSaldo;

        private GridColumn gridColumnImporte;

        private RepositoryItemLookUpEdit cbGenero;

        private XtraTabPage xtraTabPageMediosPago;

        private GridControl gcPagos;

        private GridView gvPagos;

        private GridColumn gridColumnID;

        private GridColumn gridColumnMetodoPago;

        private RepositoryItemLookUpEdit cbMetodosPago;

        private GridColumn gridColumnTC;

        private GridColumn gridColumnReferencia;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private XtraTabPage xtraTabPageDocumentoElectronico;

        private ListBoxControl lbReferencias;

        private SimpleButton btnReferencias;

        private HyperlinkLabelControl lblImportarFolioFiscal;

        private SimpleButton btnCancelar;

        private SimpleButton btnGenerar;

        private SimpleButton btnGenerarSustitucion;

        private HyperlinkLabelControl lblCodigoSN;

        private TextEdit txtCodigoSN;

        private LabelControl lblID;

        private LayoutControlItem layoutControlItem1;

        private TextEdit txtNumeroDocumentoExterno;

        private LabelControl lblImporteAplicado;

        private TextEdit txtImporteAplicado;

        private LabelControl lblSaldoPendiente;

        private TextEdit txtSaldoPendiente;

        private LabelControl lblIdentificadorExterno;

        private LabelControl lblTotal;

        private TextEdit txtTotal;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        private CheckEdit cbPagoACuenta;

        private LookUpEdit cbMetodoPago;

        private HyperlinkLabelControl lblMetodosPago;

        private MemoEdit txtCadenaOriginal;

        private LabelControl lblCadenaOriginal;

        private LabelControl lblFolioFiscal;

        private TextEdit txtFolioFiscal;

        private BarButtonItem bbiParametrizacionesFormulario;

        private GridColumn gridColumnFolioFiscal;

        public frmPagos(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                pago = Pago.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            CargarInformes();
            Permisos();
        }

        private void Permisos()
        {
            ((BarItem)bbiParametrizacionesFormulario).Enabled = false;
            char rol = Program.Nori.UsuarioAutenticado.rol;
            char c = rol;
            if (c == 'A')
            {
                ((BarItem)bbiParametrizacionesFormulario).Enabled = true;
            }
            if (!ParametrizacionFormulario.Parametrizaciones().Any((ParametrizacionFormulario x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id || ((int?)x.rol == (int?)Program.Nori.UsuarioAutenticado.rol && x.formulario == ((Control)(object)this).Name)))
            {
                return;
            }
            List<ParametrizacionFormulario> list = ParametrizacionFormulario.Obtener(((Control)this).Name, "PR");
            foreach (ParametrizacionFormulario item in list)
            {
                Control control = ((Control)this).Controls.Find(item.control, searchAllChildren: true).FirstOrDefault();
                if (control != null)
                {
                    control.Enabled = !item.desactivado;
                    control.Visible = !item.oculto;
                }
                else
                {
                    ((ColumnView)gvPartidas).Columns.ColumnByName(item.control).Visible = !item.oculto;
                    ((ColumnView)gvPartidas).Columns.ColumnByName(item.control).OptionsColumn.AllowEdit = !item.desactivado;
                }
            }
        }

        private void CargarInformes()
        {
            //IL_00fe: Unknown result type (might be due to invalid IL or missing references)
            //IL_0105: Expected O, but got Unknown
            //IL_0105: Unknown result type (might be due to invalid IL or missing references)
            //IL_010c: Expected O, but got Unknown
            //IL_016c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0176: Expected O, but got Unknown
            //IL_0180: Unknown result type (might be due to invalid IL or missing references)
            //IL_018a: Expected O, but got Unknown
            try
            {
                List<Informe> list = (from x in Informe.Informes()
                                      where x.activo == true && x.tipo == "PR"
                                      orderby x.nombre
                                      select x).ToList();
                foreach (Informe informe in list)
                {
                    BarButtonItem val = new BarButtonItem();
                    BarButtonItem val2 = new BarButtonItem();
                    ((BarItem)val).Name = informe.id.ToString();
                    ((BarItem)val2).Name = ((BarItem)val).Name + "PDF";
                    ((BarItem)val).Caption = informe.nombre;
                    ((BarItem)val2).Caption = ((BarItem)val).Caption;
                    ((BarItem)val).ItemClick += (ItemClickEventHandler)delegate
                    {
                        Funciones.ImprimirInforme(informe.id, pago.id, documento: true);
                    };
                    ((BarItem)val2).ItemClick += (ItemClickEventHandler)delegate
                    {
                        Process.Start(Funciones.PDFInforme(informe.id, pago.id));
                    };
                    ((BarLinkContainerItem)bbiImprimir).AddItem((BarItem)(object)val);
                    ((BarLinkContainerItem)bbiPDF).AddItem((BarItem)(object)val2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarListas()
        {
            List<int> usuario_series = (from x in Usuario.Serie.Series()
                                        where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                        select x.serie_id).ToList();
            ((RepositoryItemLookUpEditBase)cbSeries.Properties).DataSource = (((Program.Nori.Configuracion.seleccionar_sucursal || Program.Nori.UsuarioAutenticado.seleccionar_sucursal) && Program.Nori.UsuarioAutenticado.rol != 'A') ? (from x in Serie.Series()
                                                                                                                                                                                                                                           where x.clase == "PR" && x.almacen_id == Program.Nori.UsuarioAutenticado.almacen_id && x.activo == true
                                                                                                                                                                                                                                           select new { x.id, x.nombre }).ToList() : ((usuario_series.Count > 0) ? (from x in Serie.Series()
                                                                                                                                                                                                                                                                                                                    where x.clase == "PR" && x.activo == true && usuario_series.Contains(x.id)
                                                                                                                                                                                                                                                                                                                    select new { x.id, x.nombre }).ToList() : (from x in Serie.Series()
                                                                                                                                                                                                                                                                                                                                                               where x.clase == "PR" && x.activo == true
                                                                                                                                                                                                                                                                                                                                                               select new { x.id, x.nombre }).ToList()));
            ((RepositoryItemLookUpEditBase)cbSeries.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSeries.Properties).DisplayMember = "nombre";
            List<int> usuario_tipos_metodos_pago = (from x in Usuario.TipoMetodoPago.TiposMetodosPago()
                                                    where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                                    select x.tipo_metodo_pago_id).ToList();
            tipos_metodos_pago = ((usuario_tipos_metodos_pago.Count > 0) ? (from x in MetodoPago.Tipo.Tipos()
                                                                            where usuario_tipos_metodos_pago.Contains(x.id)
                                                                            select x).ToList() : (from x in MetodoPago.Tipo.Tipos()
                                                                                                  where x.activo == true
                                                                                                  select x).ToList());
            ((RepositoryItemLookUpEditBase)cbMetodosPago).DataSource = tipos_metodos_pago;
            ((RepositoryItemLookUpEditBase)cbMetodosPago).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMetodosPago).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMetodoPago.Properties).DataSource = (from x in MetodoPago.MetodosPago()
                                                                                  where x.activo == true && x.tipo == 'E'
                                                                                  select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbMetodoPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMetodoPago.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DataSource = (from x in Moneda.Monedas()
                                                                               where x.activo == true
                                                                               select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            lblCancelado.Visible = pago.cancelado;
            ((BaseEdit)cbSeries).EditValue = pago.serie_id;
            ((Control)(object)txtNumeroDocumento).Text = pago.numero_documento.ToString();
            ((Control)(object)txtNumeroDocumentoExterno).Visible = ((pago.identificador_externo != 0) ? true : false);
            ((Control)(object)txtNumeroDocumentoExterno).Text = pago.numero_documento_externo.ToString();
            ((BaseEdit)cbMonedas).EditValue = pago.moneda_id;
            if (pago.socio_id != 0)
            {
                socio = Socio.Obtener(pago.socio_id);
            }
            else
            {
                socio = Socio.Obtener(Program.Nori.UsuarioAutenticado.socio_id);
            }
            if (nuevo)
            {
                BarButtonItem obj = bbiNuevo;
                bool enabled = (((BarItem)bbiImprimir).Enabled = false);
                ((BarItem)obj).Enabled = enabled;
                BarButtonItem obj2 = bbiGuardar;
                BarButtonItem obj3 = bbiGuardarCerrar;
                bool flag3 = (((BarItem)bbiGuardarNuevo).Enabled = true);
                enabled = (((BarItem)obj3).Enabled = flag3);
                ((BarItem)obj2).Enabled = enabled;
                ((Control)(object)lblCodigoSN).Focus();
                pago.socio_id = socio.id;
                Serie serie = Serie.ObtenerPredeterminado("PR");
                pago.serie_id = serie.id;
                ((BaseEdit)cbSeries).EditValue = pago.serie_id;
                ((Control)(object)txtNumeroDocumento).Text = serie.siguiente.ToString();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                BarButtonItem obj4 = bbiGuardar;
                BarButtonItem obj5 = bbiGuardarCerrar;
                bool flag3 = (((BarItem)bbiGuardarNuevo).Enabled = false);
                bool enabled = (((BarItem)obj5).Enabled = flag3);
                ((BarItem)obj4).Enabled = enabled;
                ((Control)(object)lblCodigoSN).Focus();
            }
            else
            {
                BarButtonItem obj6 = bbiNuevo;
                BarButtonItem obj7 = bbiGuardar;
                BarButtonItem obj8 = bbiGuardarCerrar;
                BarButtonItem obj9 = bbiGuardarNuevo;
                bool flag8 = (((BarItem)bbiImprimir).Enabled = true);
                bool flag10 = (((BarItem)obj9).Enabled = flag8);
                bool flag3 = (((BarItem)obj8).Enabled = flag10);
                bool enabled = (((BarItem)obj7).Enabled = flag3);
                ((BarItem)obj6).Enabled = enabled;
            }
            ((Control)(object)lblID).Text = pago.id.ToString();
            ((Control)(object)lblIdentificadorExterno).Text = pago.identificador_externo.ToString();
            ((Control)(object)txtCodigoSN).Text = socio.codigo;
            ((Control)(object)lblSocio).Text = socio.nombre;
            deFechaContabilizacion.DateTime = pago.fecha_contabilizacion;
            ((Control)(object)txtFechaVencimiento).Text = pago.fecha_vencimiento.ToShortDateString();
            ((Control)(object)txtFechaDocumento).Text = pago.fecha_documento.ToShortDateString();
            ((Control)(object)txtReferencia).Text = pago.referencia;
            ((Control)(object)txtComentario).Text = pago.comentario;
            cbPagoACuenta.Checked = pago.cuenta;
            ((BaseEdit)cbMetodoPago).EditValue = pago.metodo_pago_id;
            ((Control)(object)txtTotal).Text = pago.total.ToString("c2");
            CargarPartidas();
            CargarDocumentoElectronico();
            CargarReferencias();
        }

        private void Llenar()
        {
            try
            {
                pago.metodo_pago_id = (int)((BaseEdit)cbMetodoPago).EditValue;
                if (pago.id != 0)
                {
                    return;
                }
                pago.partidas.RemoveAll((Pago.Partida x) => x.id == 0);
                pago.serie_id = (int)((BaseEdit)cbSeries).EditValue;
                Pago obj = pago;
                DateTime fecha_vencimiento = (pago.fecha_contabilizacion = deFechaContabilizacion.DateTime);
                obj.fecha_vencimiento = fecha_vencimiento;
                pago.referencia = ((Control)(object)txtReferencia).Text;
                pago.comentario = ((Control)(object)txtComentario).Text;
                pago.tipo_cambio = decimal.Parse(((BaseEdit)txtTipoCambio).EditValue.ToString());
                int[] selectedRows = ((ColumnView)gvPartidas).GetSelectedRows();
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    DataRow dataRow = ((ColumnView)gvPartidas).GetDataRow(selectedRows[i]);
                    Pago.Partida partida = new Pago.Partida();
                    partida.id = (int)dataRow["id"];
                    if (partida.id != 0)
                    {
                        partida = pago.partidas.Where((Pago.Partida x) => x.id == partida.id).First();
                    }
                    partida.documento_id = (int)dataRow["documento_id"];
                    partida.saldo = (decimal)dataRow["saldo"];
                    partida.fecha_vencimiento = (DateTime)dataRow["fecha_vencimiento"];
                    partida.tipo_cambio = (decimal)dataRow["tipo_cambio"];
                    partida.importe = (decimal)dataRow["importe"];
                    if (partida.id == 0)
                    {
                        pago.partidas.Add(partida);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private bool Guardar()
        {
            try
            {
                ((BaseView)gvPartidas).CloseEditor();
                ((BaseView)gvPagos).CloseEditor();
                if (Permiso())
                {
                    if ((solo_pue && !solo_ppd) || (solo_ppd && !solo_pue))
                    {
                        if (pago.flujo.Count() > 0)
                        {
                            if (Math.Round(saldo_pendiente, 2) != 0m && MessageBox.Show(string.Format("{0} del importe que se tiene que pagar no coincide con las operaciones existentes, ¿Desea contabilizar este importe como pago a cuenta?", saldo_pendiente.ToString("c2")), ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                pago.cuenta = true;
                            }
                            if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Llenar();
                                if (pago.id != 0)
                                {
                                    return pago.Actualizar();
                                }
                                return pago.Agregar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No has ingresado el método de pago");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No es posible guardar un pago con diferentes métodos de pago en sus documentos relacionados");
                    }
                }
                else
                {
                    MessageBox.Show("No fue posible autorizar este movimiento.");
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                pago = Pago.Obtener(pago.id);
                Cargar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
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
                pago = new Pago();
                Cargar(nuevo: true);
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pago = Pago.Obtener((from x in Pago.Pagos()
                                     where x.financiado == false
                                     orderby x.id
                                     select new { x.id }).First().id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                pago = Pago.Obtener((from x in Pago.Pagos()
                                     where x.id < pago.id && x.financiado == false
                                     orderby x.id descending
                                     select new { x.id }).First().id);
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
                pago = Pago.Obtener((from x in Pago.Pagos()
                                     where x.id > pago.id && x.financiado == false
                                     select new { x.id }).First().id);
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
                pago = Pago.Obtener((from x in Pago.Pagos()
                                     where x.financiado == false
                                     orderby x.id descending
                                     select new { x.id }).First().id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (pago.id != 0)
                {
                    pago = new Pago();
                    socio = new Socio();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                var source = from x in Pago.Pagos()
                             where ((x.id == int.Parse(((Control)(object)txtNumeroDocumento).Text) || x.socio_id == pago.socio_id || x.numero_documento == int.Parse(((Control)(object)txtNumeroDocumento).Text)) && x.financiado == false) || x.numero_documento_externo == ((Program.Nori.Configuracion.sap && int.Parse(((Control)(object)txtNumeroDocumentoExterno).Text) != 0) ? int.Parse(((Control)(object)txtNumeroDocumentoExterno).Text) : 1)
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 id = x.id,
                                 No = x.numero_documento,
                                 Total = x.total,
                                 Cancelado = x.cancelado,
                                 Fecha = x.fecha_documento,
                                 Referencia = x.referencia
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        pago = Pago.Obtener((int)dataTable.Rows[0]["id"]);
                        frmPagos frmPagos2 = new frmPagos();
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        pago = Pago.Obtener(frmResultadosBusqueda2.id);
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
            pago = new Pago();
            Cargar(nuevo: true);
        }

        private void CargarPartidas()
        {
            try
            {
                string query = $"SELECT T0.pago_id, T1.id documento_id, T1.numero_documento, T1.numero_documento_externo, T1.clase, T1.fecha_documento, T0.fecha_vencimiento, T0.saldo, T0.tipo_cambio, T1.total, T1.moneda_id, T2.nombre moneda, T1.importe_aplicado, (CASE WHEN (select codigo_sat from metodos_pago where id = T1.metodo_pago_id) = '99' THEN 'PPD' ELSE 'PUE' END) metodo_pago, T0.importe AS importe, T3.folio_fiscal FROM partidas_pagos T0 JOIN documentos T1 ON T0.documento_id = T1.id JOIN monedas T2 ON T1.moneda_id = T2.id LEFT JOIN documentos_electronicos T3 ON T3.documento_id = T1.id WHERE T0.pago_id = {pago.id}";
                if (pago.id == 0)
                {
                    query = string.Format("SELECT 0 id, 0 pago_id, documentos.id documento_id, numero_documento, numero_documento_externo, clase, fecha_documento, fecha_vencimiento, (total - importe_aplicado) saldo, (select top 1 venta from tipos_cambio where moneda_id = documentos.moneda_id and fecha <= '{0}' order by id desc) tipo_cambio, total, moneda_id, monedas.nombre moneda, (CASE WHEN (select codigo_sat from metodos_pago where id = documentos.metodo_pago_id) = '99' THEN 'PPD' ELSE 'PUE' END) metodo_pago, importe_aplicado, (CASE WHEN clase = 'NC' THEN ((total - importe_aplicado) * -1) ELSE (total - importe_aplicado) END) importe FROM documentos JOIN monedas ON documentos.moneda_id = monedas.id join metodos_pago ON documentos.metodo_pago_id = metodos_pago.id WHERE cancelado = 0 AND importe_aplicado < total - 0.01 AND clase IN ('FA', 'NC') AND socio_id = {1} AND (estado = 'A' OR reserva = 1)", deFechaContabilizacion.DateTime.ToString("yyyyMMdd"), pago.socio_id);
                }
                DataTable dataSource = Utilidades.EjecutarQuery(query);
                gcPartidas.DataSource = dataSource;
                gcPartidas.RefreshDataSource();
                if (pago.id != 0)
                {
                    ((ColumnView)gvPartidas).SelectAll();
                }
                Calcular();
                List<string> list = new List<string>(new string[2] { "FA", "NC" });
                deFechaContabilizacion.Properties.MaxValue = DateTime.Today;
            }
            catch
            {
            }
        }

        private void txtCodigoSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtCodigoSN).Text.Length > 0)
            {
                try
                {
                    socio = (from x in Socio.Socios()
                             where x.codigo == ((Control)(object)txtCodigoSN).Text
                             select x).First();
                    if (socio.activo)
                    {
                        EstablecerSocio();
                    }
                    else
                    {
                        MessageBox.Show("El socio esta inactivo.");
                    }
                }
                catch
                {
                    MessageBox.Show("No se encontraron resultados.");
                }
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                frmAltaRapidaSocio frmAltaRapidaSocio2 = new frmAltaRapidaSocio();
                ((Control)(object)frmAltaRapidaSocio2).Show();
            }
        }

        public void EstablecerSocio()
        {
            try
            {
                pago.socio_id = socio.id;
                ((Control)(object)txtCodigoSN).Text = socio.codigo;
                ((Control)(object)lblSocio).Text = socio.nombre;
                CargarPartidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtCodigoSN_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && ((Control)(object)txtCodigoSN).Text.Length > 0)
            {
                BuscarSocios(((Control)(object)txtCodigoSN).Text);
            }
        }

        private void BuscarSocios(string q)
        {
            string query = string.Format("SELECT id, codigo, nombre, rfc, (SELECT direccion FROM BloqueDireccion(direccion_facturacion_id)) AS direccion FROM socios WHERE codigo like '%{0}%' OR nombre LIKE '%{0}%' AND activo = 1", q.Replace(" ", "%"));
            DataTable dataTable = Utilidades.EjecutarQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows.Count == 1)
                {
                    socio = Socio.Obtener((int)dataTable.Rows[0]["id"]);
                }
                else
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        socio = Socio.Obtener(frmResultadosBusqueda2.id);
                    }
                }
                if (socio.activo)
                {
                    EstablecerSocio();
                }
                else
                {
                    MessageBox.Show("El socio esta inactivo.");
                }
            }
            else
            {
                MessageBox.Show($"No se encontraron resultados para {q}", ((Control)(object)this).Text);
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtNumeroDocumento).Text.Length > 0 && pago.id == 0)
            {
                Buscar();
            }
        }

        private void gvPagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (pago.flujo.Count > 0)
                {
                    pago.flujo.Remove(pago.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]]);
                }
                Calcular();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                Nuevo();
            }
            if (e.Alt && e.KeyCode == Keys.M)
            {
                ((ColumnView)gvPagos).FocusedColumn = ((ColumnView)gvPagos).Columns["tipo_metodo_pago_id"];
            }
            if (e.Alt && e.KeyCode == Keys.I)
            {
                ((ColumnView)gvPagos).FocusedColumn = ((ColumnView)gvPagos).Columns["importe"];
            }
        }

        private void Calcular()
        {
            try
            {
                gcPagos.DataSource = pago.flujo;
                gcPagos.RefreshDataSource();
                int[] selectedRows = ((ColumnView)gvPartidas).GetSelectedRows();
                ((Control)(object)btnGenerar).Enabled = (solo_ppd = true);
                solo_pue = true;
                saldo_pendiente = default(decimal);
                DateTime minValue = DateTime.Today;
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    DataRow dataRow = ((ColumnView)gvPartidas).GetDataRow(selectedRows[i]);
                    minValue = DateTime.Parse(dataRow["fecha_documento"].ToString());
                    saldo_pendiente += (decimal)dataRow["importe"] * (decimal)dataRow["tipo_cambio"];
                    if (dataRow["clase"].ToString().Equals("FA"))
                    {
                        if (dataRow["metodo_pago"].ToString().Equals("PUE"))
                        {
                            ((Control)(object)btnGenerar).Enabled = (solo_ppd = false);
                        }
                        else
                        {
                            solo_pue = false;
                        }
                    }
                }
                pago.Calcular();
                importe_aplicado = pago.total;
                saldo_pendiente = importe_aplicado - saldo_pendiente;
                ((Control)(object)txtSaldoPendiente).Text = saldo_pendiente.ToString("c2");
                ((Control)(object)txtImporteAplicado).Text = importe_aplicado.ToString("c2");
                ((Control)(object)txtTotal).Text = pago.total.ToString("c2");
                deFechaContabilizacion.Properties.MinValue = minValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvPagos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "tipo_metodo_pago_id")
                {
                    MetodoPago.Tipo tipo = tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == pago.flujo[e.RowHandle].tipo_metodo_pago_id).First();
                    if (tipo.referencia)
                    {
                        pago.flujo[e.RowHandle].referencia = Interaction.InputBox("Ingresar referencia", ((Control)(object)this).Text);
                    }
                    else
                    {
                        pago.flujo[e.RowHandle].referencia = string.Empty;
                    }
                    pago.flujo[e.RowHandle].EstablecerTipoCambio();
                    if (pago.moneda_id != tipo.moneda_id || (!tipo.cambio && !tipo.documento))
                    {
                        pago.flujo[e.RowHandle].importe = TipoCambio.Convertir(pago.moneda_id, tipo.moneda_id, 'C', pago.total);
                    }
                    ((ColumnView)gvPagos).FocusedColumn = ((ColumnView)gvPagos).Columns["importe"];
                }
                else if (e.Column.FieldName == "tipo_cambio")
                {
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "MOTCP";
                    autorizacion.referencia = $"Modificar tipo de cambio ({((Control)(object)cbMonedas).Text}) de {((BaseView)gvPartidas).ActiveEditor.OldEditValue} a {((BaseView)gvPartidas).ActiveEditor.EditValue} al socio {socio.codigo}";
                    autorizacion.comentario = Interaction.InputBox("Comentario modificar tipo de cambio (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        pago.partidas[e.RowHandle].tipo_cambio = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                    }
                }
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Nuevo()
        {
            try
            {
                pago.AgregarPago();
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((BaseView)gvPagos).Focus();
                ((ColumnView)gvPagos).MoveLast();
                ((ColumnView)gvPagos).FocusedColumn = ((pago.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].tipo_metodo_pago_id == 0) ? ((ColumnView)gvPagos).Columns["tipo_metodo_pago_id"] : ((ColumnView)gvPagos).Columns["importe"]);
            }
        }

        private void gvPartidas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calcular();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (solo_ppd)
                {
                    Funciones.TimbrarDocumento(pago);
                    CargarDocumentoElectronico();
                }
                else
                {
                    MessageBox.Show("Solo es posible timbrar pagos cuyos documentos relacionados tengan el método de pago PPD.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public async void CargarDocumentoElectronico()
        {
            try
            {
                if (pago.id != 0)
                {
                    DocumentoElectronico documento_electronico = await Task.Run(() => pago.DocumentoElectronico());
                    ((Control)(object)btnGenerar).Enabled = !documento_electronico.estado.Equals('A');
                    ((Control)(object)txtFolioFiscal).Text = documento_electronico.folio_fiscal;
                    ((BaseControl)txtFolioFiscal).ToolTip = documento_electronico.mensaje;
                    ((Control)(object)txtCadenaOriginal).Text = documento_electronico.cadena_original;
                    if (documento_electronico.estado.Equals('E'))
                    {
                        MessageBox.Show(documento_electronico.mensaje, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    ((Control)(object)btnGenerar).Enabled = false;
                    ((Control)(object)txtFolioFiscal).Text = string.Empty;
                    ((Control)(object)txtCadenaOriginal).Text = string.Empty;
                }
            }
            catch
            {
            }
        }

        private void gvPartidas_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "importe")
                {
                    if ((decimal)((ColumnView)gvPartidas).GetRowCellValue(e.RowHandle, "importe") > (decimal)((ColumnView)gvPartidas).GetRowCellValue(e.RowHandle, "saldo"))
                    {
                        ((ColumnView)gvPartidas).SetRowCellValue(e.RowHandle, "importe", (object)(decimal)((ColumnView)gvPartidas).GetRowCellValue(e.RowHandle, "saldo"));
                        MessageBox.Show("No es posible ingresar un importe mayor que el saldo del documento.");
                    }
                    Calcular();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvPartidas_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (((RowEventArgs)e).RowHandle >= 0 && DateTime.Today > Convert.ToDateTime(((ColumnView)gvPartidas).GetRowCellValue(((RowEventArgs)e).RowHandle, ((ColumnView)gvPartidas).Columns["fecha_vencimiento"])))
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.White;
                }
            }
            catch
            {
            }
        }

        private void cbMonedas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                pago.moneda_id = (int)((BaseEdit)cbMonedas).EditValue;
                ((BaseEdit)txtTipoCambio).EditValue = TipoCambio.Venta(pago.moneda_id);
                ((Control)(object)txtTipoCambio).Visible = ((Program.Nori.Configuracion.moneda_id != pago.moneda_id) ? true : false);
            }
            catch
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarDocumentoElectronico();
        }

        private void CancelarDocumentoElectronico()
        {
            DocumentoElectronico documentoElectronico = pago.DocumentoElectronico();
            if (documentoElectronico.estado.Equals('A') && documentoElectronico.folio_fiscal.Length > 0 && MessageBox.Show("¿Deseas cancelar el CFDI?", "Cancelar CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && Permiso(cancelacion: true, cfdi: true))
            {
                Funciones.CancelarTimbreDocumentoElectronico(documentoElectronico);
                CargarDocumentoElectronico();
            }
        }

        private void deFechaContabilizacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (pago.id == 0)
                {
                    int dataRowCount = ((BaseView)gvPartidas).DataRowCount;
                    for (int i = 0; i < dataRowCount; i++)
                    {
                        DataRow dataRow = ((ColumnView)gvPartidas).GetDataRow(i);
                        string query = string.Format("select top 1 venta from tipos_cambio where moneda_id = {0} and fecha <= '{1}' order by id desc", dataRow["moneda_id"], deFechaContabilizacion.DateTime.ToString("yyyyMMdd"));
                        decimal num = Utilidades.EjecutarDecimal(query);
                        dataRow["tipo_cambio"] = num;
                    }
                    gcPagos.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void lblImportarFolioFiscal_Click(object sender, EventArgs e)
        {
            ImportarFolioFiscal();
        }

        private void ImportarFolioFiscal()
        {
            try
            {
                if (pago.id == 0 || !Program.Nori.UsuarioAutenticado.rol.Equals('A'))
                {
                    return;
                }
                DocumentoElectronico documentoElectronico = pago.DocumentoElectronico();
                if (documentoElectronico.estado != 'A' && documentoElectronico.folio_fiscal.Length == 0)
                {
                    string folio_fiscal = Interaction.InputBox("Ingresa el folio fiscal (UUID)", "Importar folio fiscal");
                    documentoElectronico.pago_id = pago.id;
                    documentoElectronico.estado = 'A';
                    documentoElectronico.folio_fiscal = folio_fiscal;
                    if ((documentoElectronico.id == 0) ? documentoElectronico.Agregar() : documentoElectronico.Actualizar())
                    {
                        MessageBox.Show("Se importó el folio fiscal correctamente");
                    }
                    else
                    {
                        MessageBox.Show($"Error al importar folio fiscal: {NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM")}", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
            finally
            {
                CargarDocumentoElectronico();
            }
        }

        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cancelar este pago?", "Cancelar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (!pago.cancelado)
            {
                if (Permiso())
                {
                    pago.comentario = Interaction.InputBox("Ingresa un comentario sobre la cancelación", "Cancelación pago", pago.comentario);
                    if (pago.Cancelar(agregar_sincronizacion: true))
                    {
                        RecargarPago();
                        CancelarDocumentoElectronico();
                    }
                    else
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                    }
                }
            }
            else
            {
                MessageBox.Show("Este pago ya ha sido cancelado.");
            }
        }

        public bool Permiso(bool cancelacion = false, bool cfdi = false)
        {
            try
            {
                Permiso permiso = NoriSDK.Permiso.Obtener(Program.Nori.UsuarioAutenticado.id, "PR", autorizacion: true);
                if (permiso.id != 0 && ((!permiso.agregar && pago.id == 0) || (!permiso.actualizar && pago.id != 0)))
                {
                    Autorizacion autorizacion = new Autorizacion();
                    string text = (cancelacion ? "Cancelación" : ((pago.id != 0) ? "Actualización" : "Creación"));
                    autorizacion.codigo = (cfdi ? "CCFDI" : "CRUDO");
                    autorizacion.usuario_autorizacion_id = permiso.usuario_autorizacion_id;
                    autorizacion.referencia = string.Format("{0} del pago {1} al cliente {2} por {3}", text, "PR", socio.nombre, pago.total.ToString("c2"));
                    autorizacion.comentario = Interaction.InputBox("CRUD (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                    }
                    return autorizacion.autorizado;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void RecargarPago()
        {
            if (pago.id != 0)
            {
                pago = Pago.Obtener(pago.id);
                Cargar();
            }
            else
            {
                ((BarItem)bbiNuevo).PerformClick();
            }
        }

        private void bbiPagosFinanciados_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPagosFinanciados frmPagosFinanciados2 = new frmPagosFinanciados();
            ((Control)(object)frmPagosFinanciados2).Show();
        }

        private void lblCodigoSN_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios2 = new frmSocios(socio.id);
            ((Form)(object)frmSocios2).ShowDialog();
        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas frmMonedas2 = new frmMonedas(pago.moneda_id);
            ((Form)(object)frmMonedas2).ShowDialog();
        }

        private void bbiMapaRelaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMapaRelacionesPagos frmMapaRelacionesPagos2 = new frmMapaRelacionesPagos(pago);
            ((Control)(object)frmMapaRelacionesPagos2).Show();
        }

        private void txtNumeroDocumentoExterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtNumeroDocumento).Text.Length > 0 && pago.id == 0)
            {
                Buscar();
            }
        }

        private void bbiEnviar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (pago.id == 0)
                {
                    return;
                }
                int id = (from x in Informe.Informes()
                          where x.tipo == "PR" && x.activo == true && x.predeterminado_correo_electronico == true
                          select x.id).First();
                frmCorreoElectronico frmCorreoElectronico2 = new frmCorreoElectronico();
                frmCorreoElectronico2.socio = socio;
                frmCorreoElectronico2.anexos.Add(Funciones.PDFInforme(id, pago.id));
                try
                {
                    DocumentoElectronico documentoElectronico = pago.DocumentoElectronico();
                    if (documentoElectronico.id != 0 && documentoElectronico.estado.Equals('A'))
                    {
                        frmCorreoElectronico2.anexos.Add($"{Program.Nori.Configuracion.directorio_xml}\\{documentoElectronico.folio_fiscal}.xml");
                    }
                }
                catch
                {
                }
                ((Form)(object)frmCorreoElectronico2).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiNuevoMetodoPago_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nuevo();
        }

        private void btnGenerarSustitucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (pago.DocumentoElectronico().id != 0)
                {
                    if (MessageBox.Show("¿Deseas sustituir el CFDI?: Esta opción crea un nuevo CFDI y agrega como relación de sustitución el CFDI actual.", "Sustituir CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DocumentoElectronico documentoElectronico = pago.DocumentoElectronico();
                        if (!documentoElectronico.folio_fiscal.IsNullOrEmpty())
                        {
                            documentoElectronico.estado = 'S';
                            documentoElectronico.Actualizar();
                            Funciones.TimbrarDocumento(pago, documentoElectronico.id);
                            CargarDocumentoElectronico();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El documento no es electrónico o no se ha establecido la generación electrónica.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            try
            {
                var source = from x in Pago.Pagos()
                             where x.socio_id == pago.socio_id
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 ID = x.id,
                                 No = x.numero_documento,
                                 NoSAP = x.numero_documento_externo,
                                 Fecha = x.fecha_documento,
                                 Total = x.total,
                                 Cancelado = x.cancelado
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    {
                        foreach (int pago_id in frmResultadosBusqueda2.ids)
                        {
                            Pago.Referencia referencia = new Pago.Referencia();
                            referencia.pago_id = pago.id;
                            referencia.pago_referencia_id = pago_id;
                            if (!pago.referencias.Any((Pago.Referencia x) => x.pago_referencia_id == pago_id))
                            {
                                pago.referencias.Add(referencia);
                                CargarReferencias();
                            }
                        }
                        return;
                    }
                }
                MessageBox.Show("No se encontraron resultados", ((Control)(object)this).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarReferencias()
        {
            try
            {
                ((Control)(object)lbReferencias).Visible = true;
                ((CollectionBase)(object)lbReferencias.Items).Clear();
                foreach (Pago.Referencia referencia in pago.referencias)
                {
                    var anon = (from x in Pago.Pagos()
                                where x.id == referencia.pago_referencia_id
                                select new { x.id, x.numero_documento, x.total }).First();
                    lbReferencias.Items.Add((object)string.Format("Pago {0} Total: {1}", anon.numero_documento, anon.total.ToString("c2")));
                }
            }
            catch
            {
            }
        }

        private void lbReferencias_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete && pago.id == 0 && MessageBox.Show("¿Desea eliminar esta referencia?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    pago.referencias.RemoveAt(((BaseListBoxControl)lbReferencias).SelectedIndex);
                    CargarReferencias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void cbSeries_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (pago.id == 0)
                {
                    ((Control)(object)txtNumeroDocumento).Text = (from x in Serie.Series()
                                                                  where x.id == (int)((BaseEdit)cbSeries).EditValue
                                                                  select x.siguiente).First().ToString();
                }
            }
            catch
            {
            }
        }

        private void bbiParametrizaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmParametrizacionesFormulario frmParametrizacionesFormulario2 = new frmParametrizacionesFormulario(((Control)this).Name, "AR");
            ((Form)(object)frmParametrizacionesFormulario2).ShowDialog();
            Permisos();
        }

       
    }
}
