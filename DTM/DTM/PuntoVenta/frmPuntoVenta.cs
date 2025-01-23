using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NetsuiteLibrary.SuiteTalk_Helpers;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTM.PuntoVenta
{
    public partial class frmPuntoVenta : RibbonForm
    {
        private bool generar_reserva = false;

        private Documento documento = new Documento();

        private Socio socio = new Socio();

        private Moneda moneda = new Moneda();

        private List<UnidadMedida> unidades_medida = new List<UnidadMedida>();

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonPage ribbonPageArchivo;

        private RibbonPageGroup ribbonPageGroupArchivo;

        private RibbonStatusBar ribbonStatusBar1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private SplitContainerControl scPV;

        private LayoutControlItem layoutControlItem1;

        private SplitContainerControl splitContainerControl1;

        private LabelControl lblCodigoSN;

        private TextEdit txtCodigoSN;

        private LabelControl lblSocio;

        private BarStaticItem lblEstacion;

        private BarStaticItem lblUsuario;

        private SeparatorControl separatorControl1;

        private SplitContainerControl splitContainerControl2;

        private PictureBox pbImagen;

        private Label lblTotal_;

        private Label lblDescuento_;

        private Label lblTotal;

        private Label lblDescuento;

        private BarStaticItem lblPartidas;

        private BarEditItem lblVendedor;

        private RepositoryItemLookUpEdit cbVendedores;

        private RepositoryItemLookUpEdit cbVendedorAdicional;

        private BarButtonItem bbiNuevo;

        private BarButtonItem bbiImprimir;

        private BarButtonItem bbiGuardar;

        private BarButtonItem lblArticulos;

        private TextEdit txtArticulo;

        private BarStaticItem lblMoneda;

        private PictureBox pbLogo;

        private PictureBox pictureBox1;

        private Label lblDireccion;

        private LabelControl lblCondicionPago;

        private CheckBox cbFactura;

        private CheckBox cbReserva;

        private Splitter splitter1;

        private BarStaticItem lblCantidadEmpaque;

        private LookUpEdit cbPersonasContacto;

        private LabelControl lblPersonasContacto;

        private BarButtonItem bbiCortesCaja;

        private BarButtonItem bbiArqueo;

        private BarButtonItem bbiPagos;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private Label lblEstadoCredito;

        private SplitContainerControl splitContainerControl3;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnUnidadMedida;

        private RepositoryItemLookUpEdit cbUnidadesMedida;

        private GridColumn gridColumnCantidadEmpaque;

        private GridColumn gridColumnTipoEmpaque;

        private RepositoryItemLookUpEdit cbTiposEmpaques;

        private GridColumn gridColumnSKU;

        private GridColumn gridColumnArticulo;

        private GridColumn gridColumnCodigoBarras;

        private GridColumn gridColumnAlmacen;

        private RepositoryItemLookUpEdit cbAlmacenes;

        private GridColumn gridColumnPrecio;

        private GridColumn gridColumnPrecioNeto;

        private GridColumn gridColumnPorcentajeDescuento;

        private GridColumn gridColumnDescuento;

        private GridColumn gridColumnSubTotal;

        private GridColumn gridColumnTotal;

        private RepositoryItemLookUpEdit cbMonedas;

        private TableLayoutPanel tlp;

        private SimpleButton btnAtras;

        private LabelControl lblArticuloComentarios;

        private TextEdit txtTipoCambio;

        private LookUpEdit cbMoneda;

        private BarEditItem lblVendedorAdicional;

        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;

        public frmPuntoVenta()
        {
            InitializeComponent();
            this.MetodoDinamico();
            ((BarManager)ribbonControl1.Manager).UseAltKeyForMenu = false;
            gvPartidas.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvPartidas.OptionsSelection.EnableAppearanceFocusedRow = false;
            gvPartidas.OptionsSelection.EnableAppearanceHideSelection = false;
            if (Program.Nori.UsuarioAutenticado.rol.Equals('C'))
            {
                ((BarItem)bbiCortesCaja).Enabled = false;
            }
            ((BarItem)lblEstacion).Caption = Program.Nori.Estacion.nombre;
            ((BarItem)lblUsuario).Caption = Program.Nori.UsuarioAutenticado.nombre;
            pbLogo.LoadImage(Program.Nori.Empresa.logotipo);
            CargarListas();
            CargarGruposArticulos();
            Inicializar();
            Permisos();
        }

        public void Permisos()
        {
            if (!ParametrizacionFormulario.Parametrizaciones().Any((ParametrizacionFormulario x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id && x.formulario == ((Control)(object)this).Name))
            {
                return;
            }
            List<ParametrizacionFormulario> list = ParametrizacionFormulario.Obtener(((Control)this).Name, documento.clase);
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
                    ((ColumnView)gvPartidas).Columns.ColumnByName(item.control).ColumnEdit.ReadOnly = item.desactivado;
                }
            }
        }

        private void Cargar()
        {
            if (documento.socio_id == 0)
            {
                MessageBox.Show("No esta definido el socio de negocio predeterminado");
            }
            else
            {
                socio = Socio.Obtener(documento.socio_id);
            }
            ((Control)(object)txtCodigoSN).Text = socio.codigo;
            ((Control)(object)lblSocio).Text = socio.nombre;
            lblEstadoCredito.Text = string.Format("Límite de crédito: {0} | Disponible: {1}", socio.limite_credito.ToString("c2"), (socio.limite_credito - socio.Balance()).ToString("c2"));
            if (Serie.Series().Any((Serie x) => x.facturar_automaticamente == true))
            {
                cbFactura.Checked = true;
                documento.clase = "FA";
            }
            if (socio.DocumentosVencidos())
            {
                lblEstadoCredito.ForeColor = Color.Firebrick;
            }
            else
            {
                lblEstadoCredito.ForeColor = Color.DimGray;
            }
            lblVendedor.EditValue = documento.vendedor_id;
            ((BaseEdit)cbMoneda).EditValue = documento.moneda_id;
            if (documento.clase == "FA")
            {
                cbFactura.Checked = true;
                cbReserva.Checked = documento.reserva;
            }
            Calcular();
        }

        private void CargarListas()
        {
            try
            {
                object parametros = new
                {
                    fields = "id, nombre"
                };
                object objeto = new
                {
                    activo = 1
                };
                ((RepositoryItemLookUpEditBase)cbVendedores).DataSource = Utilidades.Busqueda("vendedores", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbVendedores).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbVendedores).DisplayMember = "nombre";
                lblVendedor.EditValue = Program.Nori.UsuarioAutenticado.vendedor_id;
                ((RepositoryItemLookUpEditBase)cbVendedorAdicional).DataSource = Utilidades.Busqueda("vendedores", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbVendedorAdicional).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbVendedorAdicional).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques).DataSource = Utilidades.Busqueda("tipos_empaques", objeto, parametros);
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbTiposEmpaques).DisplayMember = "nombre";
                unidades_medida = (from x in UnidadMedida.UnidadesMedida()
                                   where x.activo == true
                                   select x).ToList();
                ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DataSource = unidades_medida;
                ((RepositoryItemLookUpEditBase)cbUnidadesMedida).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)cbAlmacenes).DataSource = from x in Almacen.Almacenes()
                                                                         where x.activo == true
                                                                         select new { x.id, x.codigo, x.nombre };
                ((RepositoryItemLookUpEditBase)cbAlmacenes).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbAlmacenes).DisplayMember = "codigo";
                moneda = Moneda.Obtener(documento.moneda_id);
                ((BarItem)lblMoneda).Caption = moneda.nombre;
                ((RepositoryItemLookUpEditBase)cbMoneda.Properties).DataSource = (from x in Moneda.Monedas()
                                                                                  where x.activo == true
                                                                                  select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbMoneda.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbMoneda.Properties).DisplayMember = "nombre";
                pbImagen.Image = null;
                ((Control)(object)lblArticuloComentarios).Text = "";
            }
            catch
            {
            }
        }

        private void CargarPersonasContacto()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).DataSource = (from x in Socio.PersonaContacto.PersonasContacto()
                                                                                            where x.socio_id == documento.socio_id && x.activo == true
                                                                                            select new { x.id, x.nombre, x.nombre_persona }).ToList();
                ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).DisplayMember = "nombre_persona";
                ((BaseEdit)cbPersonasContacto).EditValue = documento.persona_contacto_id;
            }
            catch
            {
            }
        }

        private void BuscarSocios(string q)
        {
            try
            {
                string query = string.Format("SELECT id, codigo Código, nombre Nombre, rfc RFC, (SELECT direccion FROM BloqueDireccion(direccion_facturacion_id)) AS 'Dirección de facturación' FROM socios WHERE codigo like '%{0}%' OR nombre LIKE '%{0}%' AND tipo = 'C' AND activo = 1", q.Replace(" ", "%"));
                DataTable dataTable = Utilidades.EjecutarQuery(query);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        socio = Socio.Obtener((int)dataTable.Rows[0]["id"]);
                        if (socio.orden_compra)
                        {
                            OrdenCompra();
                        }
                    }
                    else
                    {
                        frmResultadosBusqueda frmResultadosBusqueda = new frmResultadosBusqueda(dataTable);
                        DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda).ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            socio = Socio.Obtener(frmResultadosBusqueda.id);
                        }
                        if (socio.orden_compra)
                        {
                            OrdenCompra();
                        }
                    }
                    ((Control)(object)this).Cursor = Cursors.WaitCursor;
                    EstablecerSocio(socio);
                    ((Control)(object)this).Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {q}", ((Control)(object)this).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private async void AgregarPartida(string q)
        {
            try
            {
                if (documento.AgregarPartida(q))
                {
                    ((Control)(object)txtArticulo).Text = string.Empty;
                    ((ColumnView)gvPartidas).MoveLast();
                    Documento.Partida partida = documento.partidas.Last();
                    if (Program.Nori.Configuracion.seleccion_manual_lotes && Articulo.Articulos().Any((Articulo x) => x.id == partida.articulo_id && x.seguimiento == 'L'))
                    {
                        frmSeleccionLotes f2 = new frmSeleccionLotes(partida);
                        f2.partida = partida;
                        ((Form)(object)f2).ShowDialog();
                        if (f2.lotes.Where((Lote x) => x.cantidad > 0m).Count() == 0)
                        {
                            documento.partidas.Remove(partida);
                        }
                    }
                    if (Paquete.Articulo.Articulos().Any((Paquete.Articulo x) => x.articulo_id == partida.articulo_id))
                    {
                        frmSeleccionPaquetes f = new frmSeleccionPaquetes(partida);
                        f.partida = partida;
                        ((Form)(object)f).ShowDialog();
                    }
                    Calcular();
                    await Task.Run(delegate
                    {
                        pbImagen.LoadImage(Articulo.ObtenerImagen(documento.partidas.Last().articulo_id));
                    });
                    ((Control)(object)lblArticuloComentarios).Text = Articulo.ObtenerComentario(documento.partidas.Last().articulo_id);
                }
                else
                {
                    BuscarArticulos(directo: true);
                }
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((Control)(object)txtArticulo).Text = string.Empty;
                ((Control)(object)txtArticulo).Focus();
            }
        }

        private void BuscarArticulos(bool directo = false)
        {
            string text = ((Control)(object)txtArticulo).Text;
            decimal cantidad = 1m;
            if (text.Contains("*"))
            {
                cantidad = decimal.Parse(text.Split('*')[0]);
                text = text.Split('*')[1];
            }
            Autorizacion autorizacion = new Autorizacion();
            autorizacion.codigo = "BSQDA";
            autorizacion.referencia = text;
            if (directo)
            {
                autorizacion.autorizado = true;
            }
            else
            {
                autorizacion.Agregar(documento);
            }
            if (!autorizacion.autorizado)
            {
                frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
            }
            if (!autorizacion.autorizado)
            {
                return;
            }
            ConsultaPersonalizada consultaPersonalizada = ConsultaPersonalizada.Obtener("txtArticulo");
            if (consultaPersonalizada.query.IsNullOrEmpty())
            {
                consultaPersonalizada.query = "SELECT articulos.id, sku as sku_articulo, articulos.nombre, (SELECT SUM(stock) FROM inventario WHERE articulo_id = articulos.id) stock, precios.precio, monedas.codigo as moneda FROM articulos JOIN precios ON precios.articulo_id = articulos.id JOIN monedas ON monedas.id = precios.moneda_id AND precios.lista_precio_id = {lista_precio_id} WHERE (sku = '{q}' OR articulos.nombre LIKE '%{q}%' OR codigo_barras LIKE '%{q}%') AND venta = 1 AND articulos.activo = 1 ORDER BY articulos.nombre";
            }
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{q}", text);
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{socio_id}", documento.socio_id.ToString());
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{lista_precio_id}", documento.lista_precio_id.ToString());
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{condicion_pago_id}", documento.condicion_pago_id.ToString());
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{metodo_pago_id}", documento.metodo_pago_id.ToString());
            consultaPersonalizada.query = consultaPersonalizada.query.Replace("{moneda_id}", documento.moneda_id.ToString());
            DataTable articulos = consultaPersonalizada.Ejecutar();
            if (articulos.Rows.Count > 0)
            {
                if (articulos.Rows.Count == 1)
                {
                    AgregarPartida($"{cantidad}*{articulos.Rows[0][1].ToString()}");
                    return;
                }
                frmResultadosBusquedaArticulos frmResultadosBusquedaArticulos = new frmResultadosBusquedaArticulos(articulos, seleccion_multiple: true);
                DialogResult dialogResult = ((Form)(object)frmResultadosBusquedaArticulos).ShowDialog();
                ((Control)(object)txtArticulo).Text = string.Empty;
                ((Control)(object)txtArticulo).Focus();
                if (dialogResult == DialogResult.OK)
                {
                    ((Control)(object)this).Cursor = Cursors.WaitCursor;
                    frmResultadosBusquedaArticulos.filas.ForEach(delegate (int x)
                    {
                        AgregarPartida($"{cantidad}*{articulos.Rows[x][1].ToString()}");
                    });
                    Calcular();
                    ((Control)(object)this).Cursor = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show($"No se encontraron resultados para {text}", ((Control)(object)this).Text);
            }
        }

        private void Calcular()
        {
            try
            {
                gcPartidas.DataSource = documento.partidas;
                gcPartidas.RefreshDataSource();
                documento.CalcularTotal();
                ((BarItem)lblPartidas).Caption = $"Partidas {documento.numero_partidas}";
                ((BarItem)lblArticulos).Caption = $"Artículos {documento.cantidad_partidas}";
                ((BarItem)lblCantidadEmpaque).Caption = $"Cantidad empaque {documento.cantidad_empaque}";
                lblDescuento.Text = documento.descuento.ToString("C");
                lblTotal.Text = documento.total.ToString("C");
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
                    EstablecerSocio(socio);
                }
                catch
                {
                    MessageBox.Show("No se encontraron resultados.");
                }
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                frmAltaRapidaSocio frmAltaRapidaSocio = new frmAltaRapidaSocio();
                if (((Form)(object)frmAltaRapidaSocio).ShowDialog() == DialogResult.OK)
                {
                    socio = Socio.Obtener((from x in Socio.Socios()
                                           orderby x.id descending
                                           select x.id).First());
                    EstablecerSocio(socio);
                }
            }
            if (!e.Control || e.KeyCode != Keys.E)
            {
                return;
            }
            frmAltaRapidaSocioEventual frmAltaRapidaSocioEventual = new frmAltaRapidaSocioEventual();
            if (((Form)(object)frmAltaRapidaSocioEventual).ShowDialog() == DialogResult.OK)
            {
                socio = Socio.Obtener((from x in Socio.Socios()
                                       orderby x.id descending
                                       select x.id).First());
                EstablecerSocio(socio);
            }
        }

        private void txtCodigoSN_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && ((Control)(object)txtCodigoSN).Text.Length > 0)
            {
                BuscarSocios(((Control)(object)txtCodigoSN).Text);
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtArticulo).Text.Length > 0)
            {
                AgregarPartida(((Control)(object)txtArticulo).Text);
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && ((Control)(object)txtArticulo).Text.Length > 0)
            {
                BuscarArticulos();
            }
        }

        private void frmPuntoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void ribbonControl1_ApplicationButtonClick(object sender, EventArgs e)
        {
            ((Form)this).FormClosing -= frmPuntoVenta_FormClosing;
            ((Form)this).Close();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            if (MessageBox.Show("¿Estas seguro(a) de inicializar un nuevo documento?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Inicializar();
            }
        }

        private void Inicializar()
        {
            try
            {
                if (NoriSDK.PuntoVenta.EstadoCaja().Equals('C'))
                {
                    if (MessageBox.Show("¿Deseas realizar una apertura de caja?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmIngresos frmIngresos2 = new frmIngresos("INACA");
                        ((Form)(object)frmIngresos2).ShowDialog();
                        Inicializar();
                    }
                    else
                    {
                        ((Control)(object)scPV).Enabled = false;
                    }
                }
                else
                {
                    ((Control)(object)scPV).Enabled = true;
                    ((Control)(object)txtCodigoSN).Enabled = true;
                    CheckBox checkBox = cbFactura;
                    bool @checked = (cbReserva.Checked = (generar_reserva ? true : false));
                    checkBox.Checked = @checked;
                    documento = new Documento();
                    EstablecerSocio(Socio.Obtener(Program.Nori.UsuarioAutenticado.socio_id));
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void EstablecerSocio(Socio socio)
        {
            try
            {
                if (socio.tipo == 'C')
                {
                    if (socio.activo)
                    {
                        if (socio.lista_precio_id != Program.Nori.Configuracion.lista_precio_id)
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            autorizacion.codigo = "CALIP";
                            autorizacion.referencia = $"Cambio de lista de precio diferente a la predeterminada al socio {socio.codigo}";
                            autorizacion.comentario = Interaction.InputBox("Comentario cambio de lista (Opcional)");
                            autorizacion.Agregar(documento);
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                                ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                                autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                            }
                            if (!autorizacion.autorizado)
                            {
                                socio.lista_precio_id = Program.Nori.Configuracion.lista_precio_id;
                            }
                        }
                        if (!documento.EstablecerSocio(socio))
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                            return;
                        }
                        Calcular();
                        ((Control)(object)txtCodigoSN).Text = socio.codigo;
                        ((Control)(object)lblSocio).Text = socio.nombre;
                        lblEstadoCredito.Text = string.Format("Límite de crédito: {0} | Disponible: {1}", socio.limite_credito.ToString("c2"), (socio.limite_credito - socio.Balance()).ToString("c2"));
                        lblVendedor.EditValue = documento.vendedor_id;
                        CargarPersonasContacto();
                        try
                        {
                            lblDireccion.Text = Socio.Direccion.Obtener(socio.direccion_facturacion_id).Bloque();
                        }
                        catch
                        {
                            lblDireccion.Text = string.Empty;
                            MessageBox.Show("El socio no tiene establecida la dirección de facturación.");
                            return;
                        }
                        try
                        {
                            ((Control)(object)lblCondicionPago).Text = (from x in CondicionesPago.CondicionesPagos()
                                                                        where x.id == socio.condicion_pago_id
                                                                        select new { x.nombre }).First().nombre;
                        }
                        catch
                        {
                            ((Control)(object)lblCondicionPago).Text = string.Empty;
                            MessageBox.Show("El socio no tiene establecida la condición de pago.");
                            return;
                        }
                        ((Control)(object)txtArticulo).Text = string.Empty;
                        ((Control)(object)txtArticulo).Focus();
                    }
                    else
                    {
                        MessageBox.Show("El socio esta inactivo");
                    }
                }
                else
                {
                    MessageBox.Show("El socio seleccionado no es del tipo cliente");
                }
            }
            catch
            {
            }
        }

        private static void Imprimir(Documento documento, short copias = 1)
        {
            try
            {
                if (Program.Nori.Estacion.impresion && MessageBox.Show("¿Desas imprimir el documento?", "Imprimir documento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (documento.impreso && documento.id != 0)
                    {
                        Autorizacion autorizacion = new Autorizacion();
                        autorizacion.codigo = "REIMP";
                        autorizacion.referencia = $"Re-impresión del documento {documento.id}";
                        autorizacion.comentario = Interaction.InputBox("Comentario re-impresión (Opcional)");
                        autorizacion.Agregar(documento);
                        if (!autorizacion.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                            ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                            autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                        }
                        if (autorizacion.autorizado)
                        {
                            Funciones.ImprimirInformePredeterminado(documento.clase, documento.id);
                        }
                        documento.Impreso();
                    }
                    else if (!documento.impreso && documento.id != 0)
                    {
                        Funciones.ImprimirInformePredeterminado(documento.clase, documento.id, copias);
                        documento.Impreso();
                        try
                        {
                            if (Program.Nori.Configuracion.tipo_metodo_pago_monedero_id != 0)
                            {
                                foreach (Flujo item in documento.flujo.Where((Flujo x) => x.tipo_metodo_pago_id == Program.Nori.Configuracion.tipo_metodo_pago_monedero_id).ToList())
                                {
                                    if (item.id != 0)
                                    {
                                        Funciones.ImprimirInformePredeterminado("IE", item.id);
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                if (Program.Nori.Estacion.envio_correo_automatico)
                {
                    string correo = null;
                    if (Program.Nori.UsuarioAutenticado.socio_id == documento.socio_id)
                    {
                        correo = Interaction.InputBox("Ingresa el correo(s) electrónico del cliente separados por ;", "Correo electrónico");
                    }
                    Funciones.EnviarDocumentoAsync(documento.id, correo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Documentos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void OrdenCompra()
        {
            try
            {
                string text = Interaction.InputBox("Ingresa el número de orden de compra.", "Orden de compra", documento.orden_compra);
                if ((text.Length <= 0) & socio.orden_compra)
                {
                    MessageBox.Show("La número de la orden de compra es obligatoria.");
                    OrdenCompra();
                }
                if (text.Length <= 15)
                {
                    documento.orden_compra = text;
                }
                else
                {
                    MessageBox.Show("El número de la orden de compra no puede exceder los 15 caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((Control)(object)txtArticulo).Text = string.Empty;
                ((Control)(object)txtArticulo).Focus();
            }
        }

        public void Comentario()
        {
            try
            {
                string text = Interaction.InputBox("Ingresa un comentario.", "Comentario", documento.comentario);
                if (text.Length <= 0 && documento.reserva)
                {
                    MessageBox.Show("El comentario es obligatorio.");
                    Comentario();
                }
                if (text.Length <= 254)
                {
                    documento.comentario = text;
                }
                else
                {
                    MessageBox.Show("El comentario no puede exceder los 254 caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Guardar()
        {
            try
            {
                if (documento.id == 0)
                {
                    if (documento.clase.Equals("DV") || documento.clase.Equals("NC"))
                    {
                        if (MessageBox.Show("¿Estas seguro(a) de guardar el documento?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                        {
                            return;
                        }
                        documento.persona_contacto_id = ((!((BaseEdit)cbPersonasContacto).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbPersonasContacto).EditValue) : 0);
                        documento.vendedor_id = (int)lblVendedor.EditValue;
                        try
                        {
                            documento.vendedor_adicional_id = (int)lblVendedorAdicional.EditValue;
                        }
                        catch
                        {
                        }
                        documento.generar_documento_electronico = documento.GenerarDocumentoElectronico();
                        if (documento.Agregar())
                        {
                            if (documento.generar_documento_electronico)
                            {
                                Funciones.TimbrarDocumento(documento);
                            }
                            Imprimir(documento, 1);
                            SincronizacionNetSuite();
                            Inicializar();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                        }
                        return;
                    }
                    if (documento.reserva)
                    {
                        Comentario();
                    }
                    frmMediosPago frmMediosPago = new frmMediosPago(documento, socio);
                    if (((Form)(object)frmMediosPago).ShowDialog() != DialogResult.OK || MessageBox.Show("¿Estas seguro(a) de guardar el documento?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    if (cbFactura.Checked)
                    {
                        documento.clase = "FA";
                        documento.reserva = cbReserva.Checked;
                    }
                    documento.persona_contacto_id = ((!((BaseEdit)cbPersonasContacto).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbPersonasContacto).EditValue) : 0);
                    documento.vendedor_id = (int)lblVendedor.EditValue;
                    documento.generar_documento_electronico = documento.GenerarDocumentoElectronico();
                    if (!VerificarExistencias())
                    {
                        return;
                    }
                    if (documento.flujo.Count > 0)
                    {
                        if (documento.Agregar())
                        {
                            if (documento.generar_documento_electronico)
                            {
                                Funciones.TimbrarDocumento(documento);
                            }
                            Imprimir(documento, 1);
                            Inicializar();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                        }
                        return;
                    }
                    frmAutorizacionCredito frmAutorizacionCredito = new frmAutorizacionCredito();
                    frmAutorizacionCredito.socio = socio;
                    ((Form)(object)frmAutorizacionCredito).ShowDialog();
                    if (((Form)(object)frmAutorizacionCredito).DialogResult == DialogResult.OK)
                    {
                        if (documento.Agregar())
                        {
                            if (documento.generar_documento_electronico)
                            {
                                Funciones.TimbrarDocumento(documento);
                            }
                            Imprimir(documento, 2);
                            Inicializar();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                        }
                    }
                    Inicializar();
                }
                else
                {
                    MessageBox.Show("Este documento ya ha sido guardado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private bool SincronizacionNetSuite()
        {
            try
            {
                if (Program.Nori.Configuracion.netsuite && documento.identificador_externo == 0)
                {
                    if (documento.clase.Equals("PE"))
                    {
                        SalesOrderHelper salesOrderHelper = new SalesOrderHelper();
                        if (!salesOrderHelper.CreateSalesOrder(documento))
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if (documento.clase.Equals("EN"))
                    {
                        CashSaleHelper cashSaleHelper = new CashSaleHelper();
                        cashSaleHelper.CreateCashSale(documento);
                    }
                    else if (documento.clase.Equals("FA"))
                    {
                        InvoiceHelper invoiceHelper = new InvoiceHelper();
                        if (invoiceHelper.CreateInvoice(documento))
                        {
                            if (documento.importe_aplicado >= documento.total)
                            {
                                MetodoPago.Tipo tipo = MetodoPago.Tipo.Obtener(documento.flujo.First().tipo_metodo_pago_id);
                                invoiceHelper.TransformToCustomerPayment(documento.identificador_externo.ToString(), tipo.cuenta_contable);
                            }
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if (documento.clase.Equals("NC"))
                    {
                        int num = (from x in Documento.Documentos()
                                   where x.id == documento.partidas.First().documento_base_id
                                   select x.identificador_externo).FirstOrDefault();
                        if (num.IsNullOrEmpty() && num != 0)
                        {
                            InvoiceHelper invoiceHelper2 = new InvoiceHelper();
                            invoiceHelper2.TransformToCreditMemo(num.ToString());
                        }
                        else
                        {
                            CreditMemoHelper creditMemoHelper = new CreditMemoHelper();
                            creditMemoHelper.CreateCreditMemo(documento);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al sincronizar con NSu", ex.Message.ToString().Replace("Nori", "DTM")));
                return false;
            }
        }

        private bool VerificarExistencias()
        {
            try
            {
                if ((documento.clase.Equals("EN") || documento.clase.Equals("FA") || documento.clase.Equals("TS") || (documento.clase.Equals("PE") && Program.Nori.Empresa.rfc.Equals("CVR981030480"))) && documento.id == 0 && !Program.Nori.Configuracion.venta_articulo_stock_cero)
                {
                    Funciones.Cargando("Verificando existencias", "Por favor espere...");
                    bool flag = false;
                    if (Program.Nori.Configuracion.inventario_sap)
                    {
                        foreach (Documento.Partida partida in documento.partidas)
                        {
                            if (partida.documento_id != 0 && documento.clase == "FA")
                            {
                                string text = (from x in Documento.Documentos()
                                               where x.id == partida.documento_id
                                               select x.clase).First();
                                if (text == "EN")
                                {
                                    flag = false;
                                }
                            }
                            else
                            {
                                flag = FuncionesSAP.StockNegativo(partida.cantidad, partida.sku, (from x in unidades_medida
                                                                                                  where x.id == partida.unidad_medida_id
                                                                                                  select x.codigo).First(), (from x in Almacen.Almacenes()
                                                                                                                             where x.id == partida.almacen_id
                                                                                                                             select x.codigo).First());
                            }
                            if (flag && !documento.reserva)
                            {
                                Funciones.DescartarCargando();
                                MessageBox.Show($"La cantidad recae en un inventario negativo ({partida.sku}).");
                                return false;
                            }
                        }
                    }
                    else
                    {
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.ObtenerStock();
                        });
                        switch (documento.clase)
                        {
                            case "PE":
                                flag = documento.partidas.Any((Documento.Partida x) => x.stock < x.cantidad);
                                break;
                            case "EN":
                                flag = documento.partidas.Any((Documento.Partida x) => x.stock < x.cantidad);
                                break;
                            case "FA":
                                flag = documento.partidas.Any((Documento.Partida x) => x.stock < x.cantidad && x.documento_id == 0);
                                break;
                            case "TS":
                                flag = documento.partidas.Any((Documento.Partida x) => x.stock < x.cantidad);
                                break;
                        }
                    }
                    if (flag && !documento.reserva)
                    {
                        Funciones.DescartarCargando();
                        var sku = (from x in documento.partidas
                                   where x.stock < x.cantidad
                                   select x.sku).FirstOrDefault();

                        if (sku != null)
                        {
                            MessageBox.Show("La cantidad recae en un inventario negativo (" + sku + ").");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna partida con inventario negativo.");
                        }
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                Funciones.DescartarCargando();
            }
        }

        private void Buscar()
        {
            try
            {
                var source = from x in Documento.Documentos()
                             where x.socio_id == documento.socio_id && x.clase == documento.clase && x.reserva == documento.reserva
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 id = x.id,
                                 No = x.numero_documento,
                                 Total = x.total,
                                 Aplicado = x.importe_aplicado,
                                 Saldo = x.total - x.importe_aplicado,
                                 Estado = x.estado,
                                 Fecha = x.fecha_documento,
                                 Vencimiento = x.fecha_vencimiento,
                                 COD = x.cod,
                                 Reserva = x.reserva
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        documento = Documento.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        documento = Documento.Obtener(frmResultadosBusqueda.id);
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

        private void BuscarReservas()
        {
            try
            {
                DataTable dataTable = Utilidades.EjecutarQuery("SELECT documentos.id, numero_documento 'Numero documento', socios.nombre Nombre, total Total, importe_aplicado 'Importe aplicado', (total - importe_aplicado) Saldo, fecha_documento Fecha, fecha_vencimiento Vencimiento, comentario Comentario FROM documentos JOIN socios on socios.id = documentos.socio_id WHERE estado = 'A' AND clase = 'FA' AND reserva = 1");
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda = new frmResultadosBusqueda(dataTable);
                    ((Control)(object)frmResultadosBusqueda).Text = "Búsqueda de facturas de reserva";
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        documento = Documento.Obtener(frmResultadosBusqueda.id);
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

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.A)
            {
                ((Control)(object)txtArticulo).Focus();
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                ((Control)(object)txtCodigoSN).Focus();
            }
            if (e.Alt && e.KeyCode == Keys.P)
            {
                ((BaseView)gvPartidas).Focus();
            }
            if (e.KeyCode == Keys.F3)
            {
                ((Control)(object)new frmDocumentos("EN")).Show();
            }
            if (e.KeyCode == Keys.F4)
            {
                ((Control)(object)new frmDocumentos("DV")).Show();
            }
            if (e.KeyCode == Keys.F5)
            {
                ((Control)(object)new frmDocumentos("FA")).Show();
            }
            if (e.KeyCode == Keys.F6)
            {
                ((Control)(object)new frmDocumentos("NC")).Show();
            }
            if (e.KeyCode == Keys.F8)
            {
                ((Control)(object)new frmDocumentos("AE")).Show();
            }
        }

        private void CopiarDe(bool todos = false)
        {
            try
            {
                var source = (todos ? (from x in Documento.Documentos()
                                       where x.fecha_documento == DateTime.Today && (x.clase == "PE" || (x.clase == "FA" && x.reserva == true)) && x.estado == 'A' && x.cancelado == false
                                       orderby x.fecha_creacion descending
                                       select new
                                       {
                                           ID = x.id,
                                           Clase = x.clase,
                                           No = x.numero_documento,
                                           CodigoSN = x.codigo_sn,
                                           Total = x.total,
                                           Aplicado = x.importe_aplicado,
                                           Estado = x.estado,
                                           Fecha = x.fecha_documento
                                       }) : (from x in Documento.Documentos()
                                             where x.socio_id == documento.socio_id && (x.clase == "PE" || (x.clase == "FA" && x.reserva == true)) && x.estado == 'A' && x.cancelado == false
                                             orderby x.fecha_creacion descending
                                             select new
                                             {
                                                 ID = x.id,
                                                 Clase = x.clase,
                                                 No = x.numero_documento,
                                                 CodigoSN = x.codigo_sn,
                                                 Total = x.total,
                                                 Aplicado = x.importe_aplicado,
                                                 Estado = x.estado,
                                                 Fecha = x.fecha_documento
                                             }));
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda f = new frmResultadosBusqueda(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = ((Form)(object)f).ShowDialog();
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    if (f.ids.Count > 1)
                    {
                        MessageBox.Show("Este documento fue creado a partir de múltiples documentos por lo que se omitira el encabezado y pie del documento y solo se copiaran las lineas de los documentos seleccionados");
                        List<Documento.Partida> list = (from x in Documento.Partida.Partidas()
                                                        where f.ids.Contains(x.documento_id) && x.cantidad_pendiente > 0m
                                                        select x).ToList();
                        decimal importe_aplicado = (from x in Documento.Documentos()
                                                    where f.ids.Contains(x.id)
                                                    select x).Sum((Documento x) => x.importe_aplicado);
                        var list2 = (from x in Documento.Documentos()
                                     where f.ids.Contains(x.id) && x.porcentaje_descuento > 0m
                                     select new { x.id, x.porcentaje_descuento }).ToList();
                        foreach (var descuento in list2)
                        {
                            list.Where((Documento.Partida x) => x.documento_id == descuento.id).ToList().ForEach(delegate (Documento.Partida x)
                            {
                                x.porcentaje_descuento += descuento.porcentaje_descuento;
                                x.CalcularTotal();
                            });
                        }
                        list.All(delegate (Documento.Partida x)
                        {
                            x.cantidad = x.cantidad_pendiente;
                            x.cantidad_pendiente = x.cantidad;
                            return true;
                        });
                        documento.partidas.Clear();
                        documento.partidas = list;
                        documento.importe_aplicado = importe_aplicado;
                        Documento obj = documento;
                        decimal descuento2 = (documento.porcentaje_descuento = default(decimal));
                        obj.descuento = descuento2;
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                        ((Control)(object)txtCodigoSN).Enabled = false;
                        Cargar();
                    }
                    else
                    {
                        documento.CopiarDe(Documento.Obtener(f.ids[0]), documento.clase);
                        Documento obj2 = documento;
                        decimal descuento2 = (documento.porcentaje_descuento = default(decimal));
                        obj2.descuento = descuento2;
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                        ((Control)(object)txtCodigoSN).Enabled = false;
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", ((Control)(object)this).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarMonedero()
        {
            try
            {
                if (documento.monedero_id == 0 || MessageBox.Show("El documento ya tiene asignado un monedero, ¿desea remplazarlo?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string folio_monedero = Interaction.InputBox("Ingresa el folio del monedero electrónico", "Monedero electrónico");
                    documento.monedero_id = (from x in Monedero.Monederos()
                                             where x.folio == folio_monedero
                                             select new { x.id }).First().id;
                }
            }
            catch
            {
                MessageBox.Show("No se encontraron resultados", "Monedero electrónico");
            }
        }

        private void frmPuntoVenta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.N)
                {
                    Nuevo();
                }
                if (e.Control && e.KeyCode == Keys.R)
                {
                    BuscarReservas();
                }
                if (e.Control && e.KeyCode == Keys.I)
                {
                    CopiarDe();
                }
                if (e.Control && e.KeyCode == Keys.T)
                {
                    CopiarDe(todos: true);
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    int id = int.Parse(Interaction.InputBox("Ingresa el ID del documento que deseas facturar", ((Control)(object)this).Text, "0"));
                    Documento documento = Documento.Obtener(id);
                    if (this.documento.clase.Equals("EN") || this.documento.clase.Equals("PE") || this.documento.clase.Equals("CO"))
                    {
                        if (this.documento.estado.Equals('A'))
                        {
                            this.documento.CopiarDe(documento, "FA", restablecer_identificadores: true, copiar_flujo: true);
                            Documento obj = this.documento;
                            decimal descuento = (this.documento.porcentaje_descuento = default(decimal));
                            obj.descuento = descuento;
                            this.documento.partidas.ForEach(delegate (Documento.Partida x)
                            {
                                x.CalcularTotal();
                                x.ObtenerStock();
                            });
                            Cargar();
                            cbFactura.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("El documento ya ha sido cerrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No es posible facturar esta clase de documento.");
                    }
                }
                if (e.Alt && e.KeyCode == Keys.D)
                {
                    try
                    {
                        int id2 = int.Parse(Interaction.InputBox("Ingresa el ID del documento que deseas devolver", ((Control)(object)this).Text, "0"));
                        Documento documento2 = Documento.Obtener(id2);
                        if (documento2.id != 0)
                        {
                            if (this.documento.clase.Equals("EN") || this.documento.clase.Equals("FA"))
                            {
                                if (this.documento.estado.Equals('A'))
                                {
                                    this.documento.CopiarDe(documento2, this.documento.clase.Equals("EN") ? "DV" : "NC");
                                    Documento obj2 = this.documento;
                                    decimal descuento = (this.documento.porcentaje_descuento = default(decimal));
                                    obj2.descuento = descuento;
                                    this.documento.partidas.ForEach(delegate (Documento.Partida x)
                                    {
                                        x.CalcularTotal();
                                        x.ObtenerStock();
                                    });
                                    Cargar();
                                }
                                else
                                {
                                    MessageBox.Show("El documento ya ha sido cerrado.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No es posible realizar la devolución de esta clase de documento.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No fue posible encontrar el documento que se desea devolver.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
                    }
                }
                if (e.Control && e.KeyCode == Keys.B)
                {
                    Buscar();
                }
                if (e.Control && e.KeyCode == Keys.O)
                {
                    int id3 = int.Parse(Interaction.InputBox("Ingresa el ID del documento", ((Control)(object)this).Text, "0"));
                    this.documento = Documento.Obtener(id3);
                    Cargar();
                }
                if (e.Alt && e.KeyCode == Keys.B)
                {
                    frmBascula frmBascula = new frmBascula();
                    ((Form)(object)frmBascula).ShowDialog();
                }
                if (e.Alt && e.KeyCode == Keys.O)
                {
                    OrdenCompra();
                }
                if (e.Shift && e.KeyCode == Keys.A)
                {
                    frmArqueo frmArqueo2 = new frmArqueo();
                    ((Form)(object)frmArqueo2).ShowDialog();
                    if (NoriSDK.PuntoVenta.EstadoCaja().Equals('C'))
                    {
                        ((Form)this).FormClosing -= frmPuntoVenta_FormClosing;
                        ((Form)this).Close();
                    }
                }
                if (e.Shift && e.KeyCode == Keys.D)
                {
                    frmIngresos frmIngresos2 = new frmIngresos("INDEP");
                    ((Form)(object)frmIngresos2).ShowDialog();
                }
                if (e.Shift && e.KeyCode == Keys.C)
                {
                    frmCanjes frmCanjes2 = new frmCanjes();
                    ((Form)(object)frmCanjes2).ShowDialog();
                }
                if (e.Shift && e.KeyCode == Keys.V)
                {
                    ((BarItemLinkReadOnlyCollection)((BarItem)lblVendedor).Links)[0].Focus();
                }
                if (e.Control && e.KeyCode == Keys.M)
                {
                    CargarMonedero();
                }
                if (e.Control && e.KeyCode == Keys.P)
                {
                    Imprimir(this.documento, 1);
                }
                if (e.Alt && e.KeyCode == Keys.C)
                {
                    Comentario();
                    ((Control)(object)txtArticulo).Focus();
                }
                if (e.Control && e.KeyCode == Keys.D && this.documento.total > 0m && this.documento.estado == 'A')
                {
                    frmDescuento frmDescuento = new frmDescuento();
                    frmDescuento.total = this.documento.total;
                    DialogResult dialogResult = ((Form)(object)frmDescuento).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        if (this.documento.descuento > 0m)
                        {
                            if (MessageBox.Show(string.Format("El documento actualmente tiene un descuento de {0} ¿desea acumularlo?", this.documento.descuento.ToString("c2")), ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.documento.descuento = this.documento.descuento + frmDescuento.descuento;
                                this.documento.porcentaje_descuento = this.documento.descuento / this.documento.total * 100m;
                            }
                            else
                            {
                                this.documento.descuento = frmDescuento.descuento;
                                this.documento.porcentaje_descuento = this.documento.descuento / this.documento.total * 100m;
                            }
                        }
                        else
                        {
                            this.documento.descuento = frmDescuento.descuento;
                            this.documento.porcentaje_descuento = this.documento.descuento / this.documento.total * 100m;
                        }
                    }
                    Calcular();
                }
                if (e.Control && e.KeyCode == Keys.S)
                {
                    Guardar();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    Guardar();
                }
            }
            catch
            {
            }
        }

        private void bbiImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Imprimir(documento, 1);
        }

        private void gvPartidas_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "total")
                {
                    if (Program.Nori.UsuarioAutenticado.lista_precio_minimo_id != 0)
                    {
                        Articulo.Precio precio = Articulo.Precio.Obtener(documento.partidas[e.RowHandle].articulo_id, Program.Nori.UsuarioAutenticado.lista_precio_minimo_id, documento.partidas[e.RowHandle].unidad_medida_id);
                        decimal num = (decimal)((BaseView)gvPartidas).ActiveEditor.EditValue;
                        decimal num2 = num / documento.partidas[e.RowHandle].cantidad - documento.partidas[e.RowHandle].impuesto;
                        if (num2 < precio.precio)
                        {
                            documento.partidas[e.RowHandle].total = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                            MessageBox.Show("No es posible vender por debajo del precio mínimo");
                            return;
                        }
                    }
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "MOTPP";
                    autorizacion.referencia = $"Modificación del total del artículo {documento.partidas[e.RowHandle].sku} de {((BaseView)gvPartidas).ActiveEditor.OldEditValue:c2} a {((BaseView)gvPartidas).ActiveEditor.EditValue:c2} al socio {socio.codigo}";
                    autorizacion.comentario = Interaction.InputBox("Comentario modificación del total (Opcional)");
                    autorizacion.Agregar(documento);
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        documento.partidas[e.RowHandle].total = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                    }
                    documento.partidas[e.RowHandle].ModificarTotal();
                }
                else if (e.Column.Name == "gridColumnPrecio")
                {
                    if (Program.Nori.UsuarioAutenticado.lista_precio_minimo_id != 0)
                    {
                        Articulo.Precio precio2 = Articulo.Precio.Obtener(documento.partidas[e.RowHandle].articulo_id, Program.Nori.UsuarioAutenticado.lista_precio_minimo_id, documento.partidas[e.RowHandle].unidad_medida_id);
                        decimal num3 = (decimal)((BaseView)gvPartidas).ActiveEditor.EditValue;
                        if (num3 < precio2.precio)
                        {
                            documento.partidas[e.RowHandle].total = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                            MessageBox.Show("No es posible vender por debajo del precio mínimo");
                            return;
                        }
                    }
                    Autorizacion autorizacion2 = new Autorizacion();
                    autorizacion2.codigo = "MOTPP";
                    autorizacion2.referencia = $"Modificación del precio del artículo {documento.partidas[e.RowHandle].sku} de {((BaseView)gvPartidas).ActiveEditor.OldEditValue:c2} a {((BaseView)gvPartidas).ActiveEditor.EditValue:c2} al socio {socio.codigo}";
                    autorizacion2.comentario = Interaction.InputBox("Comentario modificación de precio (Opcional)");
                    autorizacion2.Agregar(documento);
                    if (!autorizacion2.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion2);
                        ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                        autorizacion2.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion2.autorizado)
                    {
                        documento.partidas[e.RowHandle].precio = decimal.Parse(((BaseView)gvPartidas).ActiveEditor.OldEditValue.ToString()) * documento.tipo_cambio;
                    }
                    else
                    {
                        documento.partidas[e.RowHandle].precio = decimal.Parse(((BaseView)gvPartidas).ActiveEditor.EditValue.ToString()) * documento.tipo_cambio;
                    }
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
                else if (e.Column.Name == "gridColumnUnidadMedida")
                {
                    documento.partidas[e.RowHandle].ModificarUnidadMedida();
                }
                else if (e.Column.Name == "gridColumnAlmacen")
                {
                    if (documento.id == 0)
                    {
                        documento.partidas[e.RowHandle].ObtenerStock();
                    }
                    if (documento.id == 0 && MessageBox.Show("¿Establecer esta almacén para todas las partidas?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        documento.partidas.All(delegate (Documento.Partida x)
                        {
                            x.almacen_id = documento.partidas[e.RowHandle].almacen_id;
                            x.ObtenerStock();
                            return true;
                        });
                    }
                }
                else if (e.Column.FieldName == "porcentaje_descuento")
                {
                    Autorizacion autorizacion3 = new Autorizacion();
                    autorizacion3.codigo = "DSCPP";
                    autorizacion3.referencia = $"Descuento al artículo {documento.partidas[e.RowHandle].sku} de {((BaseView)gvPartidas).ActiveEditor.EditValue:p2}% al socio {socio.codigo}";
                    autorizacion3.comentario = Interaction.InputBox("Comentario descuento (Opcional)");
                    autorizacion3.Agregar(documento);
                    if (!autorizacion3.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion3 = new frmSolicitarAutorizacion(autorizacion3);
                        ((Form)(object)frmSolicitarAutorizacion3).ShowDialog();
                        autorizacion3.autorizado = ((Form)(object)frmSolicitarAutorizacion3).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion3.autorizado)
                    {
                        documento.partidas[e.RowHandle].porcentaje_descuento = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                    }
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
                else if (e.Column.FieldName == "cantidad")
                {
                    if (decimal.Parse(((BaseView)gvPartidas).ActiveEditor.OldEditValue.ToString()) > decimal.Parse(((BaseView)gvPartidas).ActiveEditor.EditValue.ToString()))
                    {
                        Autorizacion autorizacion4 = new Autorizacion();
                        autorizacion4.codigo = "MOCPP";
                        autorizacion4.referencia = $"Modificar cantidad al artículo {documento.partidas[e.RowHandle].sku} de {((BaseView)gvPartidas).ActiveEditor.OldEditValue} a {((BaseView)gvPartidas).ActiveEditor.EditValue}";
                        autorizacion4.comentario = Interaction.InputBox("Comentario modificar cantidad artículos (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                        autorizacion4.Agregar(documento);
                        if (!autorizacion4.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion4 = new frmSolicitarAutorizacion(autorizacion4);
                            ((Form)(object)frmSolicitarAutorizacion4).ShowDialog();
                            autorizacion4.autorizado = ((Form)(object)frmSolicitarAutorizacion4).DialogResult == DialogResult.OK;
                        }
                        if (!autorizacion4.autorizado)
                        {
                            documento.partidas[e.RowHandle].cantidad = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                        }
                    }
                    if (documento.partidas[e.RowHandle].id == 0 && documento.partidas[e.RowHandle].porcentaje_descuento == 0m)
                    {
                        documento.partidas[e.RowHandle].ObtenerDescuento(documento.socio_id);
                    }
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
                else
                {
                    if (!(e.Column.FieldName == "tipo_empaque_id") && !(e.Column.FieldName == "cantidad_empaque"))
                    {
                        return;
                    }
                    try
                    {
                        if (Articulo.Articulos().Any((Articulo x) => x.id == documento.partidas[e.RowHandle].articulo_id && x.pesable == true))
                        {
                            var anon = (from x in TipoEmpaque.TiposEmpaques()
                                        where x.id == documento.partidas[e.RowHandle].tipo_empaque_id && x.activo == true
                                        select new { x.id, x.peso }).First();
                            documento.partidas[e.RowHandle].tipo_empaque_id = anon.id;
                            documento.partidas[e.RowHandle].cantidad -= documento.partidas[e.RowHandle].cantidad_empaque * anon.peso;
                            documento.partidas[e.RowHandle].CalcularTotal();
                        }
                        return;
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Calcular();
                ((Control)(object)txtArticulo).Focus();
            }
        }

        private void gvPartidas_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (((RowEventArgs)e).RowHandle >= 0)
            {
                if (Convert.ToDouble(((ColumnView)gvPartidas).GetRowCellValue(((RowEventArgs)e).RowHandle, ((ColumnView)gvPartidas).Columns["porcentaje_descuento"])) > 0.0)
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                }
                e.Appearance.BackColor2 = Color.White;
            }
        }

        private void gvPartidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (documento.partidas.Count > 0)
                {
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "EPART";
                    autorizacion.referencia = $"Eliminar partida del artículo {documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].sku}";
                    autorizacion.comentario = Interaction.InputBox("Comentario eliminar partida (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                    autorizacion.Agregar(documento);
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                    }
                    if (autorizacion.autorizado)
                    {
                        documento.partidas.Remove(documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]]);
                    }
                }
                Calcular();
            }
            if (e.Alt && e.KeyCode == Keys.E)
            {
                DataTable resultados = Utilidades.EjecutarQuery($"SELECT codigo AS Almacén, nombre AS [Nombre del almacén], stock AS Stock, comprometido AS Compormetido, pedido AS Pedido, disponible AS Disponible, ubicacion AS Ubicacion FROM DatosInventario WHERE articulo_id = {documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].articulo_id} AND activo =  1");
                frmResultadosBusqueda frmResultadosBusqueda = new frmResultadosBusqueda(resultados);
                ((Control)(object)frmResultadosBusqueda).Text = "Existencias " + documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].sku;
                ((Form)(object)frmResultadosBusqueda).ShowDialog();
            }
            if (e.Shift && e.KeyCode == Keys.C)
            {
                MessageBox.Show((from x in Articulo.Articulos()
                                 where x.id == documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].articulo_id
                                 select x.comentario).First(), "Comentario del artículo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
                ((ColumnView)gvPartidas).FocusedColumn = ((ColumnView)gvPartidas).Columns["porcentaje_descuento"];
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                ((ColumnView)gvPartidas).FocusedColumn = ((ColumnView)gvPartidas).Columns["total"];
            }
            if (e.Alt && e.KeyCode == Keys.C)
            {
                documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].comentario = Interaction.InputBox("Agregar un comentario a esta linea", ((Control)(object)this).Text, documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].comentario);
            }
        }

        private void gvPartidas_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
            {
                try
                {
                    if (documento.partidas.Count > 0)
                    {
                        pbImagen.LoadImage(Articulo.ObtenerImagen(documento.partidas[e.FocusedRowHandle].articulo_id));
                        ((Control)(object)lblArticuloComentarios).Text = Articulo.ObtenerComentario(documento.partidas[e.FocusedRowHandle].articulo_id);
                    }
                }
                catch
                {
                }
            });
        }

        private void cbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFactura.Checked)
            {
                documento.clase = "FA";
                cbReserva.Visible = true;
                cbReserva.Checked = documento.reserva;
            }
            else
            {
                documento.clase = "EN";
                cbReserva.Visible = false;
                cbReserva.Checked = false;
                documento.reserva = false;
            }
            ((Control)(object)txtArticulo).Text = string.Empty;
            ((Control)(object)txtArticulo).Focus();
        }

        private void cbReserva_CheckedChanged(object sender, EventArgs e)
        {
            documento.reserva = cbReserva.Checked;
        }

        private void bbiCortesCaja_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCortesCaja frmCortesCaja2 = new frmCortesCaja();
            ((Control)(object)frmCortesCaja2).Show();
        }

        private void lblVendedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                documento.vendedor_id = (int)lblVendedor.EditValue;
            }
            catch
            {
            }
        }

        private void bbiArqueo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmArqueo frmArqueo2 = new frmArqueo();
            ((Form)(object)frmArqueo2).ShowDialog();
            if (NoriSDK.PuntoVenta.EstadoCaja().Equals('C'))
            {
                ((Form)this).FormClosing -= frmPuntoVenta_FormClosing;
                ((Form)this).Close();
            }
        }

        private void bbiPagos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPagos frmPagos = new frmPagos();
            ((Form)(object)frmPagos).ShowDialog();
        }

        private void gvPartidas_ShownEditor(object sender, EventArgs e)
        {
            //IL_0003: Unknown result type (might be due to invalid IL or missing references)
            //IL_0009: Expected O, but got Unknown
            //IL_0029: Unknown result type (might be due to invalid IL or missing references)
            //IL_002f: Expected O, but got Unknown
            try
            {
                ColumnView val = (ColumnView)sender;
                if (val.FocusedColumn.FieldName == "unidad_medida_id")
                {
                    LookUpEdit val2 = (LookUpEdit)((BaseView)val).ActiveEditor;
                    int articulo_id = Convert.ToInt32(val.GetFocusedRowCellValue("articulo_id"));
                    ((RepositoryItemLookUpEditBase)val2.Properties).DataSource = Articulo.UnidadesMedida(articulo_id);
                }
            }
            catch
            {
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            CargarGruposArticulos();
        }

        private void CargarGruposArticulos()
        {
            tlp.Controls.Clear();
            tlp.RowStyles.Clear();
            int num = 0;
            int num2 = 0;
            tlp.AutoScroll = false;
            var list = (from x in GrupoArticulo.GruposArticulos()
                        where x.activo == true && x.grupo_superior_id == 0
                        orderby x.orden
                        select new { x.id, x.nombre, x.color }).ToList();
            tlp.SuspendLayout();
            foreach (var item in list)
            {
                Button button = new Button();
                button.Name = item.id.ToString();
                button.Text = item.nombre;
                if (!item.color.IsNullOrEmpty())
                {
                    button.BackColor = Color.FromArgb(item.color.GetValueOrDefault());
                }
                button.Width = 250;
                button.Height = 50;
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Click += botonGrupoArticulo_Click;
                tlp.Controls.Add(button, num, num2);
                num++;
                if (num == 3)
                {
                    num = 0;
                    num2++;
                }
            }
            tlp.AutoScroll = true;
            tlp.ResumeLayout();
        }

        protected void botonGrupoArticulo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CargarGrupos(int.Parse(button.Name));
        }

        private async void CargarGrupos(int grupo_articulo_id)
        {
            tlp.Controls.Clear();
            tlp.RowStyles.Clear();
            int columna = 0;
            int fila = 0;
            tlp.AutoScroll = false;
            var grupos_articulos = (from x in GrupoArticulo.GruposArticulos()
                                    where x.activo == true && x.grupo_superior_id == grupo_articulo_id
                                    orderby x.orden
                                    select new { x.id, x.nombre, x.color }).ToList();
            tlp.SuspendLayout();
            foreach (var grupo_articulo in grupos_articulos)
            {
                Button boton = new Button
                {
                    Name = grupo_articulo.id.ToString(),
                    Text = grupo_articulo.nombre
                };
                if (!grupo_articulo.color.IsNullOrEmpty())
                {
                    boton.BackColor = Color.FromArgb(grupo_articulo.color.GetValueOrDefault());
                }
                boton.Width = 250;
                boton.Height = 50;
                boton.Font = new Font(boton.Font, FontStyle.Bold);
                boton.Click += botonGrupoArticulo_Click;
                tlp.Controls.Add(boton, columna, fila);
                columna++;
                if (columna == 3)
                {
                    columna = 0;
                    fila++;
                }
            }
            tlp.AutoScroll = true;
            tlp.ResumeLayout();
            CargarArticulos(grupo_articulo_id, columna, fila);
        }

        private async void CargarArticulos(int grupo_articulo_id, int columna, int fila)
        {
            tlp.AutoScroll = false;
            List<int> grupos_articulos = (from x in Articulo.Grupo.Grupos()
                                          where x.grupo_articulo_id == grupo_articulo_id
                                          select x.articulo_id).ToList();
            var articulos = (from x in Articulo.Articulos()
                             where grupos_articulos.Contains(x.id) && x.activo == true && x.venta == true
                             select new { x.id, x.sku, x.nombre, x.imagen }).ToList();
            tlp.SuspendLayout();
            foreach (var articulo in articulos)
            {
                Button boton = new Button();
                boton.Name = articulo.id.ToString();
                boton.Text = articulo.nombre;
                boton.Tag = articulo.sku;
                if (!articulo.imagen.IsNullOrEmpty())
                {
                    await Task.Run(delegate
                    {
                        boton.LoadImage(articulo.imagen);
                    });
                }
                boton.Width = 250;
                boton.Height = 50;
                boton.Font = new Font(boton.Font, FontStyle.Bold);
                boton.Click += botonArticulo_Click;
                tlp.Controls.Add(boton, columna, fila);
                columna++;
                if (columna == 3)
                {
                    columna = 0;
                    fila++;
                }
            }
            tlp.AutoScroll = true;
            tlp.ResumeLayout();
        }

        protected void botonArticulo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            AgregarPartida((string)button.Tag);
        }

        private void cbMoneda_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (documento.id == 0 || documento.clase.Equals("CO") || documento.clase.Equals("PE"))
                {
                    documento.moneda_id = (int)((BaseEdit)cbMoneda).EditValue;
                    ((BaseEdit)txtTipoCambio).EditValue = TipoCambio.Venta(documento.moneda_id);
                    ((Control)(object)txtTipoCambio).Visible = ((Program.Nori.Configuracion.moneda_id != documento.moneda_id) ? true : false);
                }
            }
            catch
            {
            }
        }

        private void txtTipoCambio_EditValueChanged(object sender, EventArgs e)
        {
            documento.tipo_cambio = decimal.Parse(((BaseEdit)txtTipoCambio).EditValue.ToString());
            Calcular();
        }

    }
}
