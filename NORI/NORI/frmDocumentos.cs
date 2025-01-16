using DevExpress.DashboardWin.Forms.Export.Groups;
using DevExpress.Utils.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;
using Microsoft.VisualBasic;
using NetsuiteLibrary.SuiteTalk_Helpers;
using NORI.Excel;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using static NoriSDK.Documento;
using DataTable = System.Data.DataTable;
using Task = System.Threading.Tasks.Task;


namespace NORI
{
    public partial class frmDocumentos : RibbonForm
    {
        private List<Documento.Estado> estados_documento = Documento.Estado.Estados();

        private List<Documento.Clase> clases = Documento.Clase.Clases();

        private List<UnidadMedida> unidades_medida = new List<UnidadMedida>();

        private List<string> copiar_de = new List<string>();

        private List<string> copiar_a = new List<string>();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRecargar;

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

        private LayoutControlGroup layoutControlGroup1;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageGeneral;

        private XtraTabPage xtraTabPageLogistica;

        private LayoutControlItem layoutControlItem1;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnSKU;

        private GridColumn gridColumnArticulo;

        private GridColumn gridColumnPrecio;

        private GridColumn gridColumnPorcentajeDescuento;

        private GridColumn gridColumnDescuento;

        private GridColumn gridColumnSubTotal;

        private TextEdit txtCodigoSN;

        private LabelControl lblSocio;

        private XtraTabPage xtraTabPageFinanzas;

        private XtraTabPage xtraTabPageDocumentoElectronico;

        private LabelControl lblSubTotal;

        private TextEdit txtSubTotal;

        private LabelControl lblImpuesto;

        private TextEdit txtImpuesto;

        private LabelControl lblTotal;

        private TextEdit txtTotal;

        private LabelControl lblImporteAplicado;

        private TextEdit txtImporteAplicado;

        private LookUpEdit cbVendedores;

        private HyperlinkLabelControl lblVendedores;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        private LabelControl lblFechaVencimiento;

        private LabelControl lblFechaContabilizacion;

        private LabelControl lblFechaDocumento;

        private TextEdit txtFechaDocumento;

        private BarSubItem bbiImprimir;

        private BarButtonItem bbiNuevoSocio;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private GridColumn gridColumnAlmacen;

        private LookUpEdit cbDireccionesEnvio;

        private LabelControl lblDireccionEnvio;

        private LookUpEdit cbDireccionesFacturacion;

        private LabelControl lblDireccionFacturacion;

        private MemoEdit txtDireccionEnvio;

        private MemoEdit txtDireccionFacturacion;

        private GridColumn gridColumnComentario;

        private LookUpEdit cbMetodosPago;

        private HyperlinkLabelControl lblMetodosPago;

        private LookUpEdit cbCondicionesPago;

        private HyperlinkLabelControl lblCondicionesPago;

        private LabelControl lblOrdenCompra;

        private TextEdit txtOrdenCompra;

        private CheckEdit cbGenerarDocumentoElectronico;

        private LabelControl lblFolioFiscal;

        private TextEdit txtFolioFiscal;

        private LabelControl lblCadenaOriginal;

        private MemoEdit txtCadenaOriginal;

        private MemoEdit txtSelloCFD;

        private LabelControl lblSelloCFD;

        private LabelControl lblNumeroDocumento;

        private TextEdit txtNumeroDocumento;

        private LookUpEdit cbSeries;

        private TextEdit txtFechaCreacion;

        private LabelControl lblFechaCreacion;

        private RepositoryItemLookUpEdit cbAlmacenes;

        private BarSubItem bbiCopiar;

        private GridColumn gridColumnTotal;

        private BarButtonItem barButtonItemMapaRelaciones;

        private TextEdit txtArticulo;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private GridColumn gridColumnImpuesto;

        private GridColumn gridColumnPrecioNeto;

        private SeparatorControl separatorControl1;

        private TextEdit txtTipoCambio;

        private SimpleButton btnDireccionFacturacion;

        private SimpleButton btnAgregarDireccionEnvio;

        private BarSubItem bbiPDF;

        private BarButtonItem bbiEnviar;

        private SimpleButton btnGenerar;

        private SimpleButton btnActualizar;

        private Label lblImpreso;

        private Label lblCancelado;

        private BarStaticItem bbiCancelar;

        private BarStaticItem bbiCerrar;

        private PopupMenu popupMenuDocumentos;

        private LabelControl lblID;

        private GridColumn gridColumnCantidadPendiente;

        private HyperlinkLabelControl lblCodigoSN;

        private GridColumn gridColumnCodigoBarras;

        private BarButtonItem bbiPagar;

        private LabelControl lblCuentaPago;

        private TextEdit txtCuentaPago;

        private LabelControl lblReferencia;

        private TextEdit txtReferencia;

        private GridColumn gridColumnPrecioPieza;

        private GridColumn gridColumnCantidadPaquete;

        private GridColumn gridColumnCantidadEmpaque;

        private GridColumn gridColumnTipoEmpaque;

        private RepositoryItemLookUpEdit cbTiposEmpaques;

        private LabelControl lblPartidas;

        private LabelControl lblArticulos;

        private BarButtonItem bbiXLSX;

        private BarHeaderItem barHeaderItem1;

        private BarHeaderItem barHeaderItem2;

        private BarHeaderItem barHeaderItem3;

        private LabelControl lblCreacion;

        private GridColumn gridColumnStock;

        private LookUpEdit cbClasesExpedicion;

        private HyperlinkLabelControl lblClaseExpedicion;

        private GridColumn gridColumnAlmacenDestino;

        private LookUpEdit cbUsoPrincipal;

        private LabelControl lblUsoPrincipal;

        private LookUpEdit cbPersonasContacto;

        private LabelControl lblPersonasContacto;

        private SimpleButton btnReferencias;

        private SimpleButton btnCancelar;

        private GridColumn gridColumnNo;

        private GridColumn gridColumnListaPrecio;

        private RepositoryItemLookUpEdit cbListasPrecios;

        private BarButtonItem bbiAjustarColumnas;

        private TextEdit txtNumeroDocumentoExterno;

        private Label lblSincronizacion;

        private GridColumn gridColumnUnidadMedida;

        private LabelControl lblActualizacion;

        private HyperlinkLabelControl lblImportarFolioFiscal;

        private SimpleButton btnSolicitarEtiquetas;

        private DateEdit deFechaContabilizacion;

        private ListBoxControl lbReferencias;

        private BarButtonItem bbiDuplicar;

        private LookUpEdit cbVehiculos;

        private HyperlinkLabelControl lblVehiculo;

        private LookUpEdit cbChoferes;

        private HyperlinkLabelControl lblChofer;

        private CheckEdit cbForaneo;

        private LookUpEdit cbSupervisores;

        private HyperlinkLabelControl lblSupervisores;

        private LookUpEdit cbCanales;

        private HyperlinkLabelControl lblCanal;

        private SimpleButton btnEstadoCFDI;

        private GridColumn gridColumnUbicacion;

        private GridColumn gridColumnUbicacionDestino;

        private RepositoryItemLookUpEdit cbUbicaciones;

        private BarButtonItem bbiCancelacionManualCFDI;

        private Button btnCancelacionMasiva;

        private DateEdit deFechaVencimiento;

        private RepositoryItemCalcEdit repositoryItemCalcEdit1;

        private LabelControl lblUtilidad;

        private LookUpEdit cbCausalidades;

        private HyperlinkLabelControl lblCausalidades;

        private XtraTabPage xtraTabPageAnexos;

        private SimpleButton btnAnexos;

        private ListBoxControl lbAnexos;

        private SimpleButton btnVisualizarAnexo;

        private LabelControl lblUUIDErrorCancelacion;

        private LabelControl lblUUIDPorCancelar;

        private RichTextBox txtUUIDErrorCancelacion;

        private RichTextBox txtUUIDPorCancelar;

        private HyperlinkLabelControl lblCancelacionMasiva;

        private RepositoryItemLookUpEdit cbUnidadesMedida;

        private LookUpEdit cbAlmacenDestino;

        private LookUpEdit cbAlmacenOrigen;

        private GroupControl gcSeguimiento;

        private ComboBoxEdit cbEstadoSeguimiento;

        private CheckEdit cbSeguimiento;

        private LookUpEdit cbRutas;

        private HyperlinkLabelControl lblRuta;

        private SimpleButton btnGenerarRFCGenerico;

        private GridColumn gridColumnDiferencia;

        private LabelControl lblRFC;

        private RepositoryItemLookUpEdit cbAlmacenesDestino;

        private GridColumn gridColumnNumeroPedimento;

        private HyperlinkLabelControl lblClase;

        private SimpleButton btnGenerarSustitucion;

        private SimpleButton btnEliminarDE;

        private CheckEdit cbGlobal;

        private LabelControl lblAlmacenDestino;

        private LabelControl lblAlmacenOrigen;

        private LookUpEdit cbRemolques;

        private HyperlinkLabelControl lblRemolque;

        private LabelControl lblDistancia;

        private TextEdit txtDistancia;

        private SimpleButton btnEditarDireccionEnvio;

        private SimpleButton btnEditarDireccionFacturacion;

        private SimpleButton btnEditarDireccionOrigen;

        private SimpleButton btnAgregarDireccionOrigen;

        private MemoEdit txtDireccionOrigen;

        private LookUpEdit cbDireccionesOrigen;

        private LabelControl lblDireccionOrigen;

        private LookUpEdit cbProyectos;

        private HyperlinkLabelControl lblProyectos;

        private Label lblEnviado;

        private BarButtonItem bbiParametrizaciones;

        private Label lblWeb;

        private TextEdit txtFechaVigencia;

        private LabelControl lblFechaVigencia;

        private GridColumn gridColumnDescuentoEspecial;

        private BarButtonItem bbiAbrir;

        private SimpleButton btnDescuentosEspeciales;

        private GridColumn gridColumnPeso;

        public Documento documento { get; set; } = new Documento();


        public Socio socio { get; set; } = new Socio();
        private string mensaje = string.Empty;
        public bool Autorizar { get; set; } = false;

        public frmDocumentos(string clase, int id = 0, bool autol = false)
        {
            InitializeComponent();
            this.MetodoDinamico();
            this.Autorizar = autol;
            openFileDialog1.Filter = "Excel Worksheets|*.xls";
            EventoControl.SuscribirEventos(this);
            documento.clase = clase;
            documento.tipo = (from x in Documento.Clase.Clases()
                              where x.clase == clase
                              select x).First().tipo;
            xtraTabPageDocumentoElectronico.PageVisible = documento.EsDocumentoElectronico();
            if (!documento.clase.Equals("FA") && !documento.clase.Equals("NC") && !documento.clase.Equals("EN") && !documento.clase.Equals("DV") && !documento.clase.Equals("EM"))
            {
                bbiCancelar.Visibility = BarItemVisibility.Never;
                txtFactVencidas.Visible = false;
                txtCreditoDisponible.Visible = false;
                lbMensajeC.Visible = false;
            }
            if (documento.clase.Equals("EN"))
            {
                bbiCerrar.Visibility = BarItemVisibility.Never;
                bbiCancelar.Visibility = BarItemVisibility.Always;
                txtFactVencidas.Visible = false;
                txtCreditoDisponible.Visible = false;
                lbCredito.Visible = false;
                lbFact.Visible = false;
                lbMensajeC.Visible = false;
            }
            if (documento.clase.Equals("PE"))
            {
                bbiCancelar.Visibility = ((!Program.Nori.Configuracion.netsuite) ? BarItemVisibility.Never : BarItemVisibility.Always);
                bbiCerrar.Visibility = BarItemVisibility.Always;
                txtFactVencidas.Visible = true;
                txtCreditoDisponible.Visible = true;
                lbCredito.Visible = true;
                lbFact.Visible = true;
                lbMensajeC.Visible = false;
            }
            if (documento.tipo.Equals('I') || documento.clase.Equals("PE") || documento.clase.Equals("CC") || documento.clase.Equals("EM"))
            {
                lblFechaVencimiento.Text = "Fecha entrega";
            }
            else
            {
                lblFechaVencimiento.Text = "Fecha vencimiento";
            }
            CargarListas();
            if (id != 0)
            {
                documento = Documento.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(Program.Nori.Configuracion.documentos_modo_nuevo, !Program.Nori.Configuracion.documentos_modo_nuevo);
            }
            CargarInformes(clase);
            if (documento.clase.Equals("AE") || documento.clase.Equals("AS") || documento.clase.Equals("IF"))
            {
                lblCodigoSN.Visible = (txtCodigoSN.Visible = (lblSocio.Visible = (lblFechaCreacion.Visible = (txtFechaCreacion.Visible = (lblMonedas.Visible = (cbMonedas.Visible = (lblVendedores.Visible = (cbVendedores.Visible))))))));
            }
            if (documento.clase.Equals("IF"))
            {
                gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnDiferencia").First().Visible = true;
                gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnDiferencia").First().VisibleIndex = 3;
            }
            if (Program.Nori.Configuracion.pedimentos)
            {
                gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnNumeroPedimento").First().Visible = true;
            }
            if (Program.Nori.Configuracion.documentos_modo_nuevo)
            {
                txtArticulo.Focus();
            }
            Permisos();
            gvPartidas.ValidatingEditor += GvPartidas_ValidatingEditor;
        }

        private void GvPartidas_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            // Verificar si estamos en la columna "Monto"
            if (gvPartidas.FocusedColumn.FieldName == "cantidad")
            {
                // Convertir el valor del editor a decimal
                decimal newValue;
                if (decimal.TryParse(e.Value.ToString(), out newValue))
                {

                    // Verificar si el valor es negativo
                    if (newValue < 0)
                    {
                        // Cancelar la edición si el valor es negativo
                        e.Valid = false;

                        // Mostrar mensaje de error
                        MessageBox.Show("El valor no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (newValue != Math.Floor(newValue))
                    {
                        MessageBox.Show("No se permite coloca piezas en decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si el valor no es válido, cancelar la edición
                    e.Valid = false;
                    MessageBox.Show("El valor ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Item1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Opción 1 seleccionada");
        }

        private void Item2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Opción 2 seleccionada");
        }
        private void CargarInformes(string clase)
        {
            try
            {
                List<Informe> list = (from x in Informe.Informes()
                                      where x.activo == true && x.tipo == clase
                                      orderby x.nombre
                                      select x).ToList();
                foreach (Informe informe in list)
                {
                    BarButtonItem barButtonItem = new BarButtonItem();
                    BarButtonItem barButtonItem2 = new BarButtonItem();
                    barButtonItem.Name = informe.id.ToString();
                    barButtonItem2.Name = barButtonItem.Name + "PDF";
                    barButtonItem.Caption = informe.nombre;
                    barButtonItem2.Caption = barButtonItem.Caption;
                    barButtonItem.ItemClick += delegate
                    {
                        Funciones.ImprimirInforme(informe.id, documento.id, documento: true);
                    };
                    barButtonItem2.ItemClick += delegate
                    {
                        Process.Start(Funciones.PDFInforme(informe.id, documento.id));
                    };
                    bbiImprimir.AddItem(barButtonItem);
                    bbiPDF.AddItem(barButtonItem2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarCopiar()
        {
            try
            {
                if (documento.id == 0)
                {
                    bbiCopiar.Caption = "Copiar de";
                }
                else
                {
                    bbiCopiar.Caption = "Copiar a";
                }
                bbiCopiar.ItemLinks.Clear();
                List<string> list = new List<string>();
                list = ((documento.id == 0) ? copiar_de : copiar_a);
                foreach (string cd in list)
                {
                    Documento.Clase clase = (cd.Equals("FR") ? new Documento.Clase
                    {
                        tipo = 'V',
                        clase = "FA",
                        nombre = "Factura de reserva"
                    } : clases.Where((Documento.Clase x) => x.clase == cd).First());
                    BarButtonItem barButtonItem = new BarButtonItem();
                    barButtonItem.Caption = clase.nombre;
                    barButtonItem.ItemClick += delegate
                    {
                        CopiarDocumento(clase);
                    };
                    if (!documento.estado.Equals('C') || !documento.clase.Equals("FA") || !clase.clase.Equals("EN"))
                    {
                        bbiCopiar.AddItem(barButtonItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CopiarDocumento(Documento.Clase clase, bool ts = false)
        {
            if (documento.id != 0)
            {
                if (clase.clase.Equals("EN") && documento.clase.Equals("FA") && !documento.reserva)
                {
                    MessageBox.Show("No es posible copiar una factura a entrega si la factura no es de reserva.");
                    return;
                }
                frmDocumentos frmDocumentos2 = new frmDocumentos(clase.clase);
                frmDocumentos2.documento.CopiarDe(documento, clase.clase);
                if (clase.nombre.Equals("Factura de reserva"))
                {
                    frmDocumentos2.documento.reserva = true;
                }
                if (documento.estado.Equals('C') && documento.clase.Equals("FA"))
                {
                    frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                    {
                        x.documento_id = 0;
                    });
                    Documento.Referencia referencia = new Documento.Referencia();
                    referencia.documento_referencia_id = documento.id;
                    frmDocumentos2.documento.referencias.Add(referencia);
                }
                try
                {
                    if (ts)
                    {
                        frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.almacen_id = x.almacen_destino_id;
                            x.almacen_destino_id = Program.Nori.UsuarioAutenticado.almacen_id;
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                    }
                    else
                    {
                        frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                    }
                }
                catch
                {
                }
                frmDocumentos2.Cargar(nuevo: true);
                frmDocumentos2.Show();
                Close();
                return;
            }
            try
            {
                var source = from x in Documento.Documentos()
                             where x.socio_id == documento.socio_id && x.clase == clase.clase && x.tipo == clase.tipo && x.estado == 'A' && x.cancelado == false
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 ID = x.id,
                                 No = x.numero_documento,
                                 Total = x.total,
                                 Aplicado = x.importe_aplicado,
                                 Estado = x.estado,
                                 Fecha = x.fecha_documento
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda f = new frmResultadosBusqueda(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = f.ShowDialog();
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
                        List<Flujo> flujos = (from x in Flujo.Flujos()
                                              where f.ids.Contains(x.documento_id)
                                              select x).ToList();
                        documento.AgregarFlujos(flujos);
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
                        Documento obj2 = documento;
                        decimal descuento2 = (documento.porcentaje_descuento = default(decimal));
                        obj2.descuento = descuento2;
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                        documento.vendedor_id = (from x in Documento.Documentos()
                                                 where x.id == f.ids.First()
                                                 select x.vendedor_id).First();
                        Cargar(nuevo: true);
                    }
                    else
                    {
                        documento.CopiarDe(Documento.Obtener(f.ids[0]), documento.clase);
                        Documento obj3 = documento;
                        decimal descuento2 = (documento.porcentaje_descuento = default(decimal));
                        obj3.descuento = descuento2;
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                        Cargar(nuevo: true);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            int fact = 0;
            try
            {
                fact = Int32.Parse(txtFactVencidas.Text);
            }
            catch (Exception ex)
            {
            }

            if (fact > 2 && documento.clase == "PE")
            {
                documento.condicion_pago_id = 19;
                if (Guardar())
                {
                    RecargarDocumento();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                }


            }
            else {
                if (Guardar())
                {
                    RecargarDocumento();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                }
            }

        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            int fact = Int32.Parse(txtFactVencidas.Text);
            if (fact > 2 && documento.clase == "PE")
            {
                documento.condicion_pago_id = 19;
                if (Guardar())
                {
                    Close();
                }
            }
            else
            {
                if (Guardar())
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                }
            }
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            int fact = Int32.Parse(txtFactVencidas.Text);
            if (fact > 2 && documento.clase == "PE")
            {
                documento.condicion_pago_id = 19;
                if (Guardar())
                {
                    Nuevo();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                }
            }
            else {
                if (Guardar())
                {
                    Nuevo();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text);
                }
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                documento = Documento.Obtener((from x in Documento.Documentos()
                                               where x.clase == documento.clase && x.serie_id == ObtenerSerieID()
                                               orderby x.numero_documento
                                               select new { x.id }).First().id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
            Permisos();
        }

        private void bbiAnterior_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                documento = Documento.Obtener((from x in Documento.Documentos()
                                               where x.clase == documento.clase && x.numero_documento < documento.numero_documento && x.serie_id == ObtenerSerieID()
                                               orderby x.numero_documento descending
                                               select new { x.id }).First().id);
            }
            catch
            {
                bbiUltimo.PerformClick();
            }
            finally
            {
                Cargar();
            }
            Permisos();
        }

        private void bbiSiguiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                documento = Documento.Obtener((from x in Documento.Documentos()
                                               where x.clase == documento.clase && x.numero_documento > documento.numero_documento && x.serie_id == ObtenerSerieID()
                                               orderby x.numero_documento
                                               select new { x.id }).First().id);
            }
            catch (Exception ex)
            {
                bbiPrimero.PerformClick();
            }
            finally
            {
                Cargar();
            }
            Permisos();
        }

        private void bbiUltimo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                documento = Documento.Obtener((from x in Documento.Documentos()
                                               where x.clase == documento.clase && x.serie_id == ObtenerSerieID()
                                               orderby x.numero_documento descending
                                               select new { x.id }).First().id);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Cargar();
            }
            Permisos();
        }

        private int ObtenerSerieID()
        {
            try
            {
                int zse = (cbSeries.EditValue.IsNullOrEmpty() || (int)cbSeries.EditValue == 0) ? (from x in Serie.Series()
                                                                                                  where x.clase == documento.clase && x.predeterminado == true
                                                                                                  select new { x.id }).First().id : ((int)cbSeries.EditValue);
                return zse;
            }
            catch
            {
                return 0;
            }
        }

        private void bbiBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Buscar();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nuevo();
        }

        private void Permisos()
        {
            try
            {
                bbiParametrizaciones.Enabled = false;
                switch (Program.Nori.UsuarioAutenticado.rol)
                {
                    case 'A':
                        bbiParametrizaciones.Enabled = true;
                        break;
                    case 'C':
                        //searchRibbonPageGroup.Visible = false;
                        break;
                }
                //if (!ParametrizacionFormulario.Parametrizaciones().Any((ParametrizacionFormulario x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id || ((int?)x.rol == (int?)Program.Nori.UsuarioAutenticado.rol && x.formulario == Name && x.objeto == documento.clase)))
                //{
                //    return;
                //}
                List<ParametrizacionFormulario> list = ParametrizacionFormulario.Obtener(base.Name, documento.clase);
                foreach (ParametrizacionFormulario item in list)
                {
                    try
                    {
                        Control control = base.Controls.Find(item.control, searchAllChildren: true).FirstOrDefault();
                        if (control != null)
                        {
                            control.Visible = !item.oculto;
                            if (!item.oculto)
                            {
                                control.Enabled = !item.desactivado;
                            }
                        }


                        else
                        {
                            try
                            {
                                SetButtonVisibility(this.mainRibbonControl, item.control, item.oculto, item.desactivado);
                                gvPartidas.Columns.ColumnByFieldName(item.control).Visible = !item.oculto;
                                if (!item.oculto)
                                {
                                    gvPartidas.Columns.ColumnByFieldName(item.control).OptionsColumn.AllowEdit = !item.desactivado;
                                }
                            }
                            catch (Exception ex)
                            {
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al parametrizar el control: " + item.control);
                        MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
                    }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }
        public void SetButtonVisibility(RibbonControl ribbon, string buttonName, bool oculto, bool desactivado)
        {
            // Buscar el BarButtonItem por su nombre en los items del RibbonControl
            foreach (var item in ribbon.Items)
            {
                // Verificar si el item es un BarButtonItem
                if (item is DevExpress.XtraBars.BarButtonItem buttonItem && buttonItem.Name == buttonName)
                {
                    // Cambiar la visibilidad del botón
                    buttonItem.Visibility = oculto ? BarItemVisibility.Never : BarItemVisibility.Always;

                    // Cambiar el estado de habilitación
                    buttonItem.Enabled = !desactivado;  // Si 'desactivado' es true, deshabilita el botón
                    break;  // Detener la búsqueda después de encontrar el botón
                }
            }
        }
        private void Buscar()
        {
            try
            {
                if (documento.id != 0)
                {
                    string clase = documento.clase;
                    documento = new Documento();
                    documento.clase = clase;
                    socio = new Socio();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                var source = from x in Documento.Documentos()
                             where (x.referencia == txtReferencia.Text && x.referencia != "") || (x.id == int.Parse(txtNumeroDocumento.Text) && x.clase == documento.clase) || (x.socio_id == ((documento.socio_id == 0) ? (-1) : documento.socio_id) && x.clase == documento.clase) || (x.numero_documento == int.Parse(txtNumeroDocumento.Text) && x.clase == documento.clase) || (x.numero_documento_externo == ((Program.Nori.Configuracion.sap && int.Parse(txtNumeroDocumentoExterno.Text) != 0) ? int.Parse(txtNumeroDocumentoExterno.Text) : 1) && x.clase == documento.clase)
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 ID = x.id,
                                 Clase = documento.clase,
                                 No = x.numero_documento,
                                 NoSAP = x.numero_documento_externo,
                                 Total = x.total,
                                 Aplicado = x.importe_aplicado,
                                 Estado = x.estado,
                                 Fecha = x.fecha_documento
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        if (dataTable.Rows[0]["clase"].ToString() == documento.clase)
                        {
                            documento = Documento.Obtener((int)dataTable.Rows[0]["id"]);
                            Cargar();
                        }
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        documento = Documento.Obtener(frmResultadosBusqueda2.id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", Text);
                }
            }
            catch
            {
            }
        }

        private void Nuevo()
        {
            string clase = documento.clase;
            documento = new Documento(clase);
            Cargar(nuevo: true);
        }

        internal void Cargar(bool nuevo = false, bool busqueda = false)
        {
            try
            {
                cbSeries.EditValue = documento.serie_id;
                txtNumeroDocumento.Text = documento.numero_documento.ToString();
                txtNumeroDocumentoExterno.Text = documento.numero_documento_externo.ToString();
                //btnStat.BackColor = ((documento.identificador_externo != 0) ? Color.Lime : Color.Red);
                //btnStat.ForeColor = ((documento.identificador_externo != 0) ? Color.Lime : Color.Red);
                if (documento.numero_documento != 0)
                {
                    //mensaje = "";
                    System.Data.DataTable dataTable = Documento.estatusDocumento(documento.id);
                    if (dataTable.Rows.Count > 0)
                    {
                        if (dataTable.Rows[0]["color"].ToString() == "amarillo")
                        {
                            btnStat.BackColor = Color.Yellow;
                            btnStat.ForeColor = Color.Yellow;
                            mensaje = string.Empty;
                        }
                        if (dataTable.Rows[0]["color"].ToString() == "verde")
                        {
                            btnStat.BackColor = Color.Lime;
                            btnStat.ForeColor = Color.Lime;
                            mensaje = string.Empty;
                        }
                        if (dataTable.Rows[0]["color"].ToString() == "rojo")
                        {
                            btnStat.BackColor = Color.Red;
                            btnStat.ForeColor = Color.Red;
                            mensaje = dataTable.Rows[0]["error"].ToString();
                        }
                    }

                }
                else
                {
                    btnStat.BackColor = Color.White;
                    btnStat.ForeColor = Color.White;
                    mensaje = string.Empty;
                }
                lbReferencias.Visible = false;
                if (documento.socio_id != 0)
                {
                    socio = Socio.Obtener(documento.socio_id);
                }
                bool enabled;
                if (documento.estado.Equals('C'))
                {
                    LookUpEdit lookUpEdit = cbMonedas;
                    TextEdit textEdit = txtCodigoSN;
                    TextEdit textEdit2 = txtTipoCambio;
                    TextEdit textEdit3 = txtArticulo;
                    BarSubItem barSubItem = bbiCopiar;
                    BarButtonItem barButtonItem = bbiGuardar;
                    BarButtonItem barButtonItem2 = bbiGuardarNuevo;
                    BarButtonItem barButtonItem3 = bbiGuardarCerrar;
                    BarButtonItem barButtonItem4 = bbiPagar;
                    bool flag2 = (gvPartidas.OptionsBehavior.Editable = false);
                    bool flag4 = (barButtonItem4.Enabled = flag2);
                    bool flag6 = (barButtonItem3.Enabled = flag4);
                    bool flag8 = (barButtonItem2.Enabled = flag6);
                    bool flag10 = (barButtonItem.Enabled = flag8);
                    bool flag12 = (barSubItem.Enabled = flag10);
                    bool flag14 = (textEdit3.Enabled = flag12);
                    bool flag16 = (textEdit2.Enabled = flag14);
                    enabled = (textEdit.Enabled = flag16);
                    lookUpEdit.Enabled = enabled;
                }
                else
                {
                    LookUpEdit lookUpEdit2 = cbMonedas;
                    TextEdit textEdit4 = txtCodigoSN;
                    TextEdit textEdit5 = txtTipoCambio;
                    TextEdit textEdit6 = txtArticulo;
                    BarSubItem barSubItem2 = bbiCopiar;
                    BarButtonItem barButtonItem5 = bbiGuardar;
                    BarButtonItem barButtonItem6 = bbiGuardarNuevo;
                    BarButtonItem barButtonItem7 = bbiGuardarCerrar;
                    BarButtonItem barButtonItem8 = bbiPagar;
                    bool flag2 = (gvPartidas.OptionsBehavior.Editable = true);
                    bool flag4 = (barButtonItem8.Enabled = flag2);
                    bool flag6 = (barButtonItem7.Enabled = flag4);
                    bool flag8 = (barButtonItem6.Enabled = flag6);
                    bool flag10 = (barButtonItem5.Enabled = flag8);
                    bool flag12 = (barSubItem2.Enabled = flag10);
                    bool flag14 = (textEdit6.Enabled = flag12);
                    bool flag16 = (textEdit5.Enabled = flag14);
                    enabled = (textEdit4.Enabled = flag16);
                    lookUpEdit2.Enabled = enabled;
                }
                if (bbiCopiar.Enabled)
                {
                    CargarCopiar();
                }
                if (nuevo)
                {
                    BarButtonItem barButtonItem9 = bbiNuevo;
                    BarSubItem barSubItem3 = bbiPDF;
                    bool flag16 = (bbiImprimir.Enabled = false);
                    enabled = (barSubItem3.Enabled = flag16);
                    barButtonItem9.Enabled = enabled;
                    CheckEdit checkEdit = cbAnticipo;
                    CheckEdit checkEdit2 = cbReserva;
                    TextEdit textEdit7 = txtArticulo;
                    BarButtonItem barButtonItem10 = bbiGuardar;
                    BarButtonItem barButtonItem11 = bbiGuardarCerrar;
                    BarButtonItem barButtonItem12 = bbiGuardarNuevo;
                    bool flag8 = (bbiPagar.Enabled = true);
                    bool flag10 = (barButtonItem12.Enabled = flag8);
                    bool flag12 = (barButtonItem11.Enabled = flag10);
                    bool flag14 = (barButtonItem10.Enabled = flag12);
                    flag16 = (textEdit7.Enabled = flag14);
                    enabled = (checkEdit2.Enabled = flag16);
                    checkEdit.Enabled = enabled;
                    if (documento.socio_id == 0 && !documento.tipo.Equals('C'))
                    {
                        socio = Socio.Obtener(Program.Nori.UsuarioAutenticado.socio_id);
                        EstablecerSocio();
                    }
                    else if (documento.id == 0 && documento.socio_id != 0)
                    {
                        EstablecerSocio();
                    }
                    Serie serie = Serie.ObtenerPredeterminado(documento.clase);
                    documento.serie_id = serie.id;
                    cbSeries.EditValue = documento.serie_id;
                    txtNumeroDocumento.Text = serie.siguiente.ToString();
                }
                else
                {
                    CheckEdit checkEdit3 = cbAnticipo;
                    enabled = (cbReserva.Enabled = false);
                    checkEdit3.Enabled = enabled;
                    if (busqueda)
                    {
                        TextEdit textEdit8 = txtArticulo;
                        BarButtonItem barButtonItem13 = bbiGuardar;
                        BarButtonItem barButtonItem14 = bbiGuardarCerrar;
                        BarButtonItem barButtonItem15 = bbiGuardarNuevo;
                        BarButtonItem barButtonItem16 = bbiPagar;
                        BarSubItem barSubItem4 = bbiCopiar;
                        BarSubItem barSubItem5 = bbiPDF;
                        bool flag6 = (bbiImprimir.Enabled = false);
                        bool flag8 = (barSubItem5.Enabled = flag6);
                        bool flag10 = (barSubItem4.Enabled = flag8);
                        bool flag12 = (barButtonItem16.Enabled = flag10);
                        bool flag14 = (barButtonItem15.Enabled = flag12);
                        bool flag16 = (barButtonItem14.Enabled = flag14);
                        enabled = (barButtonItem13.Enabled = flag16);
                        textEdit8.Enabled = enabled;
                        TextEdit textEdit9 = txtCodigoSN;
                        TextEdit textEdit10 = txtNumeroDocumentoExterno;
                        flag16 = (bbiNuevo.Enabled = true);
                        enabled = (textEdit10.Visible = flag16);
                        textEdit9.Enabled = enabled;
                    }
                    else
                    {
                        BarButtonItem barButtonItem17 = bbiNuevo;
                        BarButtonItem barButtonItem18 = bbiGuardar;
                        BarButtonItem barButtonItem19 = bbiGuardarCerrar;
                        BarButtonItem barButtonItem20 = bbiGuardarNuevo;
                        BarButtonItem barButtonItem21 = bbiPagar;
                        BarSubItem barSubItem6 = bbiPDF;
                        bool flag8 = (bbiImprimir.Enabled = true);
                        bool flag10 = (barSubItem6.Enabled = flag8);
                        bool flag12 = (barButtonItem21.Enabled = flag10);
                        bool flag14 = (barButtonItem20.Enabled = flag12);
                        bool flag16 = (barButtonItem19.Enabled = flag14);
                        enabled = (barButtonItem18.Enabled = flag16);
                        barButtonItem17.Enabled = enabled;
                        txtCodigoSN.Enabled = false;
                    }
                }
                Text = clases.Where((Documento.Clase x) => x.clase == documento.clase).First().nombre;
                lblClase.Text = Text;
                bbiAbrir.Visibility = ((!documento.clase.Equals("FA") || !documento.estado.Equals('C')) ? BarItemVisibility.Never : BarItemVisibility.Always);
                if (documento.numero_documento != 0)
                {
                    Text += $" ({documento.numero_documento}) ";
                }
                Text += $" - {estados_documento.Where((Documento.Estado x) => x.estado == documento.estado).First().nombre}";
                DateEdit dateEdit = deFechaVencimiento;
                enabled = (deFechaContabilizacion.Enabled = documento.id == 0);
                dateEdit.Enabled = enabled;
                //lblIdentificadorExterno.Visible = ((documento.identificador_externo != 0) ? true : false);
                if (documento.clase.Equals("PE"))
                {
                    cbCOD.Visible = true;
                }
                else
                {
                    cbCOD.Visible = false;
                }
                if (documento.clase.Equals("FA"))
                {
                    CheckEdit checkEdit4 = cbAnticipo;
                    enabled = (cbReserva.Visible = true);
                    checkEdit4.Visible = enabled;
                }
                else
                {
                    CheckEdit checkEdit5 = cbAnticipo;
                    enabled = (cbReserva.Visible = false);
                    checkEdit5.Visible = enabled;
                }
                BarCodeControl barCodeControl = bcID;
                string text2 = (lblID.Text = documento.id.ToString());
                barCodeControl.Text = text2;
                //lblIdentificadorExterno.Text = documento.identificador_externo.ToString();
                lblCancelado.Visible = documento.cancelado;
                lblImpreso.Visible = documento.impreso;
                lblEnviado.Visible = documento.enviado;
                cbCOD.Checked = documento.cod;
                cbReserva.Checked = documento.reserva;
                cbAnticipo.Checked = documento.anticipo;
                txtCodigoSN.Text = socio.codigo;
                lblSocio.Text = socio.nombre;
                lblID.Text = socio.id.ToString();
                lblRFC.Text = socio.rfc;
                txtFechaCreacion.Text = documento.fecha_creacion.ToShortDateString();
                cbMonedas.EditValue = documento.moneda_id;
                deFechaContabilizacion.DateTime = documento.fecha_contabilizacion;
                deFechaVencimiento.DateTime = documento.fecha_vencimiento;
                txtFechaDocumento.Text = documento.fecha_documento.ToShortDateString();
                cbVendedores.EditValue = documento.vendedor_id;
                txtReferencia.Text = documento.referencia;
                txtComentario.Text = documento.comentario;
                if (documento.socio_id != 0 || documento.id != 0)
                {
                    CargarDirecciones();
                    CargarPersonasContacto();
                }
                txtDistancia.Text = documento.distancia.ToString();
                cbClasesExpedicion.EditValue = documento.clase_expedicion_id;
                cbChoferes.EditValue = documento.chofer_id;
                cbVehiculos.EditValue = documento.vehiculo_id;
                cbRemolques.EditValue = documento.remolque_id;
                cbRutas.EditValue = documento.ruta_id;
                cbForaneo.Checked = documento.foraneo;
                cbSupervisores.EditValue = documento.supervisor_id;
                cbCausalidades.EditValue = documento.causalidad_id;
                lblWeb.Visible = documento.web;
                cbSeguimiento.Checked = documento.seguimiento;
                cbEstadoSeguimiento.SelectedIndex = documento.estado_seguimiento;
                cbCondicionesPago.EditValue = documento.condicion_pago_id;
                cbMetodosPago.EditValue = documento.metodo_pago_id;
                cbProyectos.EditValue = documento.proyecto_id;
                cbCanales.EditValue = documento.canal_id;
                txtCuentaPago.Text = documento.cuenta_pago;
                txtOrdenCompra.Text = documento.orden_compra;
                txtTipoCambio.Text = documento.tipo_cambio.ToString();
                cbGenerarDocumentoElectronico.Checked = (nuevo ? documento.GenerarDocumentoElectronico() : documento.generar_documento_electronico);
                if (documento.clase.Equals("EN") && Program.Nori.Empresa.rfc.Equals("JAIJ640806EF5"))
                {
                    cbGenerarDocumentoElectronico.Enabled = false;
                }
                cbGlobal.Checked = documento.global;
                cbUsoPrincipal.EditValue = documento.uso_principal;
                CargarDocumentoElectronico();
                CargarReferencias();
                CargarAnexos();
                cbAlmacenOrigen.EditValue = documento.almacen_id;
                cbAlmacenDestino.EditValue = documento.almacen_destino_id;
                //cbMonederos.EditValue = documento.monedero_id;
                if (documento.usuario_creacion_id != 0)
                {
                    var usuarioCreacion = (from x in Usuario.Usuarios()
                                           where x.id == documento.usuario_creacion_id
                                           select x.usuario).FirstOrDefault();

                    lblCreacion.Text = $"Creación: {documento.fecha_creacion.ToString()} ({usuarioCreacion})";


                    var usuarioActualizacion = (from x in Usuario.Usuarios()
                                                where x.id == documento.usuario_actualizacion_id
                                                select x.usuario).FirstOrDefault();

                    lblActualizacion.Text = $"Actualización: {documento.fecha_actualizacion.ToString()} ({usuarioActualizacion})";
                }
                if (documento.id == 0 || documento.clase.Equals("CO") || documento.clase.Equals("PE") || documento.clase.Equals("CC") || documento.clase.Equals("OC") || documento.clase.Equals("ST"))
                {
                    gvPartidas.OptionsBehavior.Editable = true;
                }
                else
                {
                    gvPartidas.OptionsBehavior.Editable = false;
                }
                Calcular();
            }
            catch
            {
            }
            finally
            {
                if (nuevo)
                {
                    txtArticulo.Focus();
                }
                else if (busqueda)
                {
                    txtCodigoSN.Focus();
                }
            }
        }

        public async void CargarDocumentoElectronico()
        {
            try
            {
                LabelControl labelControl = lblAlmacenOrigen;
                LabelControl labelControl2 = lblAlmacenDestino;
                LookUpEdit lookUpEdit = cbAlmacenOrigen;
                LookUpEdit lookUpEdit2 = cbAlmacenDestino;
                bool flag2 = (gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnAlmacenDestino").First().Visible = documento.tipo.Equals('I'));
                bool flag4 = (lookUpEdit2.Visible = flag2);
                bool flag6 = (lookUpEdit.Visible = flag4);
                bool visible = (labelControl2.Visible = flag6);
                labelControl.Visible = visible;
                gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnUbicacion").First().Visible = Almacen.Almacenes().Any((Almacen x) => x.ubicaciones == true);
                if (gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnUbicacion").First().Visible && documento.clase.Equals("TS"))
                {
                    gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnUbicacionDestino").First().Visible = true;
                }
                else
                {
                    gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnUbicacionDestino").First().Visible = false;
                }
                if (documento.id != 0)
                {
                    GridColumn gridColumn = gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnStock").First();
                    GridColumn gridColumn2 = gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnPrecioPieza").First();
                    flag6 = (gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnListaPrecio").First().Visible = false);
                    visible = (gridColumn2.Visible = flag6);
                    gridColumn.Visible = visible;
                    Sincronizacion sincronizacion = Sincronizacion.Obtener("documentos", documento.id);
                    lblSincronizacion.Text = ((sincronizacion.id == 0) ? string.Empty : sincronizacion.error);
                    if (documento.EsDocumentoElectronico())
                    {
                        DocumentoElectronico documento_electronico = await Task.Run(() => documento.DocumentoElectronico());
                        SimpleButton simpleButton = btnGenerar;
                        visible = (btnGenerarRFCGenerico.Enabled = !documento_electronico.estado.Equals('A'));
                        simpleButton.Enabled = visible;
                        if ((documento.clase.Equals("EN") || documento.clase.Equals("TS")) && Program.Nori.Empresa.rfc.Equals("JAIJ640806EF5"))
                        {
                            CheckEdit checkEdit = cbGenerarDocumentoElectronico;
                            SimpleButton simpleButton2 = btnGenerar;
                            flag6 = (btnGenerarRFCGenerico.Enabled = false);
                            visible = (simpleButton2.Enabled = flag6);
                            checkEdit.Enabled = visible;
                        }
                        txtFolioFiscal.Text = documento_electronico.folio_fiscal;
                        txtFolioFiscal.ToolTip = documento_electronico.mensaje;
                        txtCadenaOriginal.Text = documento_electronico.cadena_original;
                        txtSelloCFD.Text = documento_electronico.sello_CFD;
                        if (documento_electronico.estado.Equals('E') && documento.generar_documento_electronico)
                        {
                            MessageBox.Show("Error no fue posible timbrar la factura: " + documento_electronico.mensaje, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        return;
                    }
                }
                else
                {
                    GridColumn gridColumn3 = gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnStock").First();
                    GridColumn gridColumn4 = gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnPrecioPieza").First();
                    flag6 = (gvPartidas.Columns.Where((GridColumn x) => x.Name == "gridColumnListaPrecio").First().Visible = true);
                    visible = (gridColumn4.Visible = flag6);
                    gridColumn3.Visible = visible;
                }
                SimpleButton simpleButton3 = btnGenerar;
                visible = (btnGenerarRFCGenerico.Enabled = false);
                simpleButton3.Enabled = visible;
                txtFolioFiscal.Text = string.Empty;
                txtCadenaOriginal.Text = string.Empty;
                txtSelloCFD.Text = string.Empty;
            }
            catch
            {
            }
        }

        private async void CargarDirecciones()
        {
            try
            {
                if (documento.socio_id == 0)
                {
                    return;
                }
                RepositoryItemLookUpEdit properties = cbDireccionesFacturacion.Properties;
                properties.DataSource = await Task.Run(() => (from x in Socio.Direccion.Direcciones()
                                                              where x.socio_id == documento.socio_id && x.tipo == 'F'
                                                              select new { x.id, x.nombre }).ToList());
                cbDireccionesFacturacion.Properties.ValueMember = "id";
                cbDireccionesFacturacion.Properties.DisplayMember = "nombre";
                RepositoryItemLookUpEdit properties2 = cbDireccionesOrigen.Properties;
                properties2.DataSource = await Task.Run(() => (from x in Socio.Direccion.Direcciones()
                                                               where x.socio_id == Program.Nori.UsuarioAutenticado.socio_id && x.tipo == 'E'
                                                               select new { x.id, x.nombre }).ToList());
                cbDireccionesOrigen.Properties.ValueMember = "id";
                cbDireccionesOrigen.Properties.DisplayMember = "nombre";
                var direcciones_envio = await Task.Run(() => (from x in Socio.Direccion.Direcciones()
                                                              where x.socio_id == documento.socio_id && x.tipo == 'E'
                                                              select new { x.id, x.nombre }).ToList());
                if (documento.direccion_envio_id != 0 && !direcciones_envio.Any(x => x.id == documento.direccion_envio_id))
                {
                    direcciones_envio.Add(new
                    {
                        id = documento.direccion_envio_id,
                        nombre = "Dirección del documento"
                    });
                }
                cbDireccionesEnvio.Properties.DataSource = direcciones_envio;
                cbDireccionesEnvio.Properties.ValueMember = "id";
                cbDireccionesEnvio.Properties.DisplayMember = "nombre";
                cbDireccionesFacturacion.EditValue = documento.direccion_facturacion_id;
                cbDireccionesEnvio.EditValue = documento.direccion_envio_id;
                cbDireccionesOrigen.EditValue = documento.direccion_origen_id;
                BloqueDirecciones();
            }
            catch
            {
            }
        }

        private async void CargarPersonasContacto()
        {
            try
            {
                if (documento.socio_id == 0)
                {
                    return;
                }
                RepositoryItemLookUpEdit properties = cbPersonasContacto.Properties;
                properties.DataSource = await Task.Run(() => (from x in Socio.PersonaContacto.PersonasContacto()
                                                              where x.socio_id == socio.id
                                                              select new { x.id, x.nombre }).ToList());
                cbPersonasContacto.Properties.ValueMember = "id";
                cbPersonasContacto.Properties.DisplayMember = "nombre";
                cbPersonasContacto.EditValue = documento.persona_contacto_id;
            }
            catch
            {
            }
        }

        private void CargarMonedero()
        {
            try
            {
                if (documento.monedero_id == 0 || MessageBox.Show("El documento ya tiene asignado un monedero, ¿desea remplazarlo?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string folio_monedero = Interaction.InputBox("Ingresa el folio del monedero electrónico", "Monedero electrónico");
                    documento.monedero_id = (from x in Monedero.Monederos()
                                             where x.folio == folio_monedero
                                             select new { x.id }).First().id;
                    //cbMonederos.EditValue = documento.monedero_id;
                }
            }
            catch
            {
                MessageBox.Show("No se encontraron resultados", "Monedero electrónico");
            }
        }

        private async void BloqueDirecciones()
        {
            try
            {
                MemoEdit memoEdit = txtDireccionFacturacion;
                memoEdit.Text = await Task.Run(() => Socio.Direccion.Obtener((int)cbDireccionesFacturacion.EditValue).Bloque());
                MemoEdit memoEdit2 = txtDireccionEnvio;
                memoEdit2.Text = await Task.Run(() => Socio.Direccion.Obtener((int)cbDireccionesEnvio.EditValue).Bloque());
                MemoEdit memoEdit3 = txtDireccionOrigen;
                memoEdit3.Text = await Task.Run(() => Socio.Direccion.Obtener((int)cbDireccionesOrigen.EditValue).Bloque());
                txtDistancia.Text = (from x in Socio.Direccion.Direcciones()
                                     where x.id == (int)cbDireccionesEnvio.EditValue
                                     select x.distancia).FirstOrDefault().ToString();
            }
            catch
            {
            }
        }

        private void CargarListas()
        {
            try
            {
                string clase = documento.clase;
                List<int> usuario_series = (from x in Usuario.Serie.Series()
                                            where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                            select x.serie_id).ToList();
                cbSeries.Properties.DataSource = (((Program.Nori.Configuracion.seleccionar_sucursal || Program.Nori.UsuarioAutenticado.seleccionar_sucursal) && Program.Nori.UsuarioAutenticado.rol != 'A') ? (from x in Serie.Series()
                                                                                                                                                                                                               where x.clase == clase && x.almacen_id == Program.Nori.UsuarioAutenticado.almacen_id && x.activo == true
                                                                                                                                                                                                               select new { x.id, x.nombre }).ToList() : ((usuario_series.Count > 0) ? (from x in Serie.Series()
                                                                                                                                                                                                                                                                                        where x.clase == clase && x.activo == true && usuario_series.Contains(x.id)
                                                                                                                                                                                                                                                                                        select new { x.id, x.nombre }).ToList() : (from x in Serie.Series()
                                                                                                                                                                                                                                                                                                                                   where x.clase == clase && x.activo == true
                                                                                                                                                                                                                                                                                                                                   select new { x.id, x.nombre }).ToList()));
                cbSeries.Properties.ValueMember = "id";
                cbSeries.Properties.DisplayMember = "nombre";
                cbVendedores.Properties.DataSource = (from x in Vendedor.Vendedores()
                                                      where x.activo == true
                                                      select new { x.id, x.nombre }).ToList();
                cbVendedores.Properties.ValueMember = "id";
                cbVendedores.Properties.DisplayMember = "nombre";
                cbMonedas.Properties.DataSource = (from x in Moneda.Monedas()
                                                   where x.activo == true
                                                   select new { x.id, x.codigo, x.nombre }).ToList();
                cbMonedas.Properties.ValueMember = "id";
                cbMonedas.Properties.DisplayMember = "nombre";
                List<int> usuarios_almacenes = (from x in Usuario.Almacen.Almacenes()
                                                where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                                select x.almacen_id).ToList();
                var list = (from x in Almacen.Almacenes()
                            where x.activo == true
                            select new { x.id, x.codigo, x.nombre }).ToList();
                RepositoryItemLookUpEdit properties = cbAlmacenOrigen.Properties;
                object dataSource = (cbAlmacenes.DataSource = ((usuarios_almacenes.Count > 0) ? (from x in list
                                                                                                 where usuarios_almacenes.Contains(x.id)
                                                                                                 select new { x.id, x.codigo, x.nombre }).ToList() : list));
                properties.DataSource = dataSource;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = cbAlmacenesDestino;
                dataSource = (cbAlmacenDestino.Properties.DataSource = list);
                repositoryItemLookUpEdit.DataSource = dataSource;
                RepositoryItemLookUpEdit properties2 = cbAlmacenOrigen.Properties;
                RepositoryItemLookUpEdit properties3 = cbAlmacenDestino.Properties;
                string text2 = (cbAlmacenes.ValueMember = "id");
                string valueMember = (properties3.ValueMember = text2);
                properties2.ValueMember = valueMember;
                RepositoryItemLookUpEdit properties4 = cbAlmacenOrigen.Properties;
                RepositoryItemLookUpEdit properties5 = cbAlmacenDestino.Properties;
                text2 = (cbAlmacenes.DisplayMember = "codigo");
                valueMember = (properties5.DisplayMember = text2);
                properties4.DisplayMember = valueMember;
                unidades_medida = (from x in UnidadMedida.UnidadesMedida()
                                   where x.activo == true
                                   select x).ToList();
                cbUnidadesMedida.DataSource = unidades_medida;
                cbUnidadesMedida.ValueMember = "id";
                cbUnidadesMedida.DisplayMember = "nombre";
                cbUbicaciones.DataSource = from x in Almacen.Ubicacion.Ubicaciones()
                                           where x.activo == true
                                           select new { x.id, x.codigo, x.ubicacion };
                cbUbicaciones.ValueMember = "id";
                cbUbicaciones.DisplayMember = "ubicacion";
                List<int> usuarios_listas_precios = (from x in Usuario.ListaPrecio.ListasPrecios()
                                                     where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                                     select x.lista_precio_id).ToList();
                cbListasPrecios.DataSource = ((usuarios_listas_precios.Count > 0) ? (from x in ListaPrecio.ListasPrecios()
                                                                                     where usuarios_listas_precios.Contains(x.id)
                                                                                     select new { x.id, x.nombre }) : (from x in ListaPrecio.ListasPrecios()
                                                                                                                       where x.activo == true
                                                                                                                       select new { x.id, x.nombre }));
                cbListasPrecios.ValueMember = "id";
                cbListasPrecios.DisplayMember = "nombre";
                cbTiposEmpaques.DataSource = (from x in TipoEmpaque.TiposEmpaques()
                                              where x.activo == true
                                              select new { x.id, x.nombre }).ToList();
                cbTiposEmpaques.ValueMember = "id";
                cbTiposEmpaques.DisplayMember = "nombre";
                cbCondicionesPago.Properties.DataSource = (from x in CondicionesPago.CondicionesPagos()
                                                           where x.activo == true
                                                           select new { x.id, x.nombre }).ToList();
                cbCondicionesPago.Properties.ValueMember = "id";
                cbCondicionesPago.Properties.DisplayMember = "nombre";
                cbMetodosPago.Properties.DataSource = (from x in MetodoPago.MetodosPago()
                                                       where x.activo == true && x.tipo == (documento.tipo.Equals('V') ? 69 : 83)
                                                       select new { x.id, x.nombre }).ToList();
                cbMetodosPago.Properties.ValueMember = "id";
                cbMetodosPago.Properties.DisplayMember = "nombre";
                cbProyectos.Properties.DataSource = (from x in Proyecto.Proyectos()
                                                     where x.activo == true
                                                     select new { x.id, x.nombre }).ToList();
                cbProyectos.Properties.ValueMember = "id";
                cbProyectos.Properties.DisplayMember = "nombre";
                cbClasesExpedicion.Properties.DataSource = (from x in ClaseExpedicion.ClasesExpedicion()
                                                            where x.activo == true
                                                            select new { x.id, x.codigo, x.nombre }).ToList();
                cbClasesExpedicion.Properties.ValueMember = "id";
                cbClasesExpedicion.Properties.DisplayMember = "nombre";
                cbChoferes.Properties.DataSource = (from x in Chofer.Choferes()
                                                    where x.activo == true
                                                    select new { x.id, x.codigo, x.nombre }).ToList();
                cbChoferes.Properties.ValueMember = "id";
                cbChoferes.Properties.DisplayMember = "nombre";
                cbVehiculos.Properties.DataSource = (from x in Vehiculo.Vehiculos()
                                                     where x.activo == true
                                                     select new { x.id, x.codigo, x.nombre }).ToList();
                cbVehiculos.Properties.ValueMember = "id";
                cbVehiculos.Properties.DisplayMember = "nombre";
                cbRemolques.Properties.DataSource = (from x in Remolque.Remolques()
                                                     where x.activo == true
                                                     select new { x.id, x.codigo, x.nombre }).ToList();
                cbRemolques.Properties.ValueMember = "id";
                cbRemolques.Properties.DisplayMember = "nombre";
                cbSupervisores.Properties.DataSource = (from x in Supervisor.Supervisores()
                                                        where x.activo == true
                                                        select new { x.id, x.codigo, x.nombre }).ToList();
                cbSupervisores.Properties.ValueMember = "id";
                cbSupervisores.Properties.DisplayMember = "nombre";
                cbCausalidades.Properties.DataSource = (from x in Causalidad.Causalidades()
                                                        where x.activo == true
                                                        select new { x.id, x.codigo, x.nombre }).ToList();
                cbCausalidades.Properties.ValueMember = "id";
                cbCausalidades.Properties.DisplayMember = "nombre";
                cbCanales.Properties.DataSource = (from x in Canal.Canales()
                                                   where x.activo == true
                                                   select new { x.id, x.codigo, x.nombre }).ToList();
                cbCanales.Properties.ValueMember = "id";
                cbCanales.Properties.DisplayMember = "nombre";
                cbRutas.Properties.DataSource = (from x in Ruta.Rutas()
                                                 where x.activo == true
                                                 select new { x.id, x.codigo, x.nombre }).ToList();
                cbRutas.Properties.ValueMember = "id";
                cbRutas.Properties.DisplayMember = "nombre";
                //cbMonederos.Properties.DataSource = Utilidades.EjecutarQuery("select monederos.id, socios.codigo, monederos.folio from monederos join socios on monederos.socio_id = socios.id where monederos.activo = 1");
                //cbMonederos.Properties.ValueMember = "id";
                //cbMonederos.Properties.DisplayMember = "folio";
                cbUsoPrincipal.Properties.DataSource = Documento.UsoCFDI.UsosCFDI();
                cbUsoPrincipal.Properties.ValueMember = "uso";
                cbUsoPrincipal.Properties.DisplayMember = "nombre";
                copiar_de = clases.Where((Documento.Clase x) => x.clase == documento.clase).First().CopiarDe();
                copiar_a = clases.Where((Documento.Clase x) => x.clase == documento.clase).First().CopiarA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la listas: " + ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void CalcularExcel()
        {
            try
            {
                gcPartidas.DataSource = documento.partidas;
                gcPartidas.RefreshDataSource();
                //documento.CalcularTotal(true);
                documento.CalcularTotal();
                txtTipoCambio.Text = documento.tipo_cambio.ToString("n4");
                txtSubTotal.Text = documento.subtotal.ToString("c2");
                //txtPorcentajeDescuento.Text = documento.porcentaje_descuento.ToString("n2");
                //txtDescuento.Text = documento.descuento.ToString("c2");
                txtImpuesto.Text = documento.impuesto.ToString("c2");
                txtTotal.Text = documento.total.ToString("c2");
                txtImporteAplicado.Text = documento.importe_aplicado.ToString("c2");
                try
                {
                    btnDescuentosEspeciales.Visible = true;
                    lblPartidas.Text = $"Partidas {documento.numero_partidas}";
                    lblArticulos.Text = $"Artículos {documento.cantidad_partidas}";
                    decimal num = Math.Round((documento.partidas.Sum((Documento.Partida x) => x.precio * x.tipo_cambio) - documento.partidas.Sum((Documento.Partida x) => x.costo)) / documento.partidas.Sum((Documento.Partida x) => x.costo) * 100m, 2);
                    lblUtilidad.Text = $"Utilidad {num}%";
                }
                catch
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }
        private void Calcular()
        {
            try
            {

                gcPartidas.DataSource = documento.partidas;
                gcPartidas.RefreshDataSource();
                documento.CalcularTotal();
                txtTipoCambio.Text = documento.tipo_cambio.ToString("n4");
                txtSubTotal.Text = documento.subtotal.ToString("c2");
                //txtPorcentajeDescuento.Text = documento.porcentaje_descuento.ToString("n2");
                //txtDescuento.Text = documento.descuento.ToString("c2");
                txtImpuesto.Text = documento.impuesto.ToString("c2");
                txtTotal.Text = documento.total.ToString("c2");
                txtImporteAplicado.Text = documento.importe_aplicado.ToString("c2");
                try
                {
                    btnDescuentosEspeciales.Visible = true;
                    lblPartidas.Text = $"Partidas {documento.numero_partidas}";
                    lblArticulos.Text = $"Artículos {documento.cantidad_partidas}";
                    decimal num = Math.Round((documento.partidas.Sum((Documento.Partida x) => x.precio * x.tipo_cambio) - documento.partidas.Sum((Documento.Partida x) => x.costo)) / documento.partidas.Sum((Documento.Partida x) => x.costo) * 100m, 2);
                    lblUtilidad.Text = $"Utilidad {num}%";
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void BuscarSocios(string q)
        {
            try
            {
                string query = string.Format("SELECT id, codigo Codigo, nombre Nombre, rfc RFC, (SELECT direccion FROM BloqueDireccion(direccion_facturacion_id)) AS 'Dirección de facturación' FROM socios WHERE (codigo like '%{0}%' OR nombre LIKE '%{0}%' OR rfc LIKE '%{0}%') AND tipo = '{1}' AND activo = 1", q.Replace(" ", "%"), documento.tipo.Equals('C') ? "P" : "C");
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
                        DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
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
                    MessageBox.Show($"No se encontraron resultados para {q}", Text);
                }
            }
            catch
            {
            }
        }

        public void EstablecerSocio()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (documento.EstablecerSocio(socio))
                {
                    txtCodigoSN.Text = socio.codigo;
                    DataTable data = documento.limiteCredito(socio.codigo);
                    if (data.Rows.Count > 0)
                    {
                        if (Convert.ToDecimal(data.Rows[0]["fact_vencidas"]) > 2 && documento.clase == "PE")
                        {
                            lbMensajeC.Visible = true;
                            lbMensajeC.Text = "La Venta debera ser de Contado tiene Facturas pendientes por Pagar";
                        }
                        if (Convert.ToDecimal(data.Rows[0]["credito disponible"]) < 0)
                        {
                            lbMensajeC.Visible = true;
                            lbMensajeC.Text = "La Venta debera ser de Contado sobrepasa el limite de credito";
                        }
                        txtCreditoDisponible.Text = Convert.ToDecimal(data.Rows[0]["credito disponible"]).ToString("0.##");
                        txtFactVencidas.Text = Convert.ToDecimal(data.Rows[0]["fact_vencidas"]).ToString("0.##");
                    }
                    lblSocio.Text = socio.nombre;
                    lblID.Text = socio.id.ToString();
                    lblRFC.Text = socio.rfc;
                    cbVendedores.EditValue = documento.vendedor_id;
                    cbMetodosPago.EditValue = documento.metodo_pago_id;
                    txtCuentaPago.Text = documento.cuenta_pago;
                    cbCondicionesPago.EditValue = documento.condicion_pago_id;
                    //cbMonederos.EditValue = documento.monedero_id;
                    cbUsoPrincipal.EditValue = documento.uso_principal;
                    if (documento.clase.Equals("CO") || documento.clase.Equals("PE"))
                    {
                        documento.fecha_vigencia = (socio.vip ? DateTime.Now.AddDays(socio.dias_extra_vigencia) : DateTime.Now);
                        txtFechaVigencia.Text = documento.fecha_vigencia.GetValueOrDefault().ToShortDateString();
                    }
                    CargarDirecciones();
                    CargarPersonasContacto();
                    Calcular();
                    //if (socio.id != Program.Nori.UsuarioAutenticado.socio_id && (documento.clase.Equals("FA") || documento.clase.Equals("EN")) && socio.Balance() > socio.limite_credito && MessageBox.Show($"{socio.codigo} - {socio.nombre} Límite de crédito excedido en {(socio.limite_credito - socio.Balance()) * -1m:c2}. ¿Desea Continuar?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    //{
                    //    Close();
                    //}
                    if (Program.Nori.Empresa.rfc.Equals("SFE191219K23") || Program.Nori.Empresa.rfc.Equals("QFS970203EJ6"))
                    {
                        CondicionesPago condicionesPago = CondicionesPago.Obtener(socio.condicion_pago_id);
                        cbCondicionesPago.Properties.DataSource = ((condicionesPago.dias_extra > 0) ? (from x in CondicionesPago.CondicionesPagos()
                                                                                                       where x.activo == true
                                                                                                       select new { x.id, x.nombre }).ToList() : (from x in CondicionesPago.CondicionesPagos()
                                                                                                                                                  where x.activo == true && x.id == socio.condicion_pago_id
                                                                                                                                                  select new { x.id, x.nombre }).ToList());
                        cbCondicionesPago.Properties.ValueMember = "id";
                        cbCondicionesPago.Properties.DisplayMember = "nombre";
                    }
                    if (socio.orden_compra && (documento.clase.Equals("FA") || documento.clase.Equals("EN") || documento.clase.Equals("PE")))
                    {
                        OrdenCompra();
                    }
                    txtArticulo.Text = string.Empty;
                    txtArticulo.Focus();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                    MessageBox.Show("El número de la orden de compra no pu ede exceder los 15 caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                txtOrdenCompra.Text = documento.orden_compra;
                txtArticulo.Focus();
            }
        }

        private bool Llenar()
        {
            try
            {
                documento.cod = cbCOD.Checked;
                documento.reserva = cbReserva.Checked;
                documento.anticipo = cbAnticipo.Checked;
                Documento obj = documento;
                DateTime fecha_documento = (documento.fecha_contabilizacion = deFechaContabilizacion.DateTime);
                obj.fecha_documento = fecha_documento;
                documento.fecha_vencimiento = deFechaVencimiento.DateTime;
                documento.serie_id = (int)cbSeries.EditValue;
                documento.condicion_pago_id = (int)cbCondicionesPago.EditValue;
                documento.moneda_id = (int)cbMonedas.EditValue;
                documento.tipo_cambio = decimal.Parse(txtTipoCambio.EditValue.ToString());
                documento.metodo_pago_id = (int)cbMetodosPago.EditValue;
                documento.proyecto_id = ((!cbProyectos.EditValue.IsNullOrEmpty()) ? ((int)cbProyectos.EditValue) : 0);
                documento.cuenta_pago = txtCuentaPago.Text;
                documento.vendedor_id = (int)cbVendedores.EditValue;
                //documento.monedero_id = ((!cbMonederos.EditValue.IsNullOrEmpty()) ? ((int)cbMonederos.EditValue) : 0);
                documento.direccion_facturacion_id = (int)cbDireccionesFacturacion.EditValue;
                documento.direccion_envio_id = (int)cbDireccionesEnvio.EditValue;
                documento.direccion_origen_id = ((!cbDireccionesOrigen.EditValue.IsNullOrEmpty()) ? ((int)cbDireccionesOrigen.EditValue) : 0);
                documento.distancia = int.Parse(txtDistancia.Text);
                documento.persona_contacto_id = ((!cbPersonasContacto.EditValue.IsNullOrEmpty()) ? ((int)cbPersonasContacto.EditValue) : 0);
                documento.clase_expedicion_id = ((!cbClasesExpedicion.EditValue.IsNullOrEmpty()) ? ((int)cbClasesExpedicion.EditValue) : 0);
                documento.chofer_id = ((!cbChoferes.EditValue.IsNullOrEmpty()) ? ((int)cbChoferes.EditValue) : 0);
                documento.vehiculo_id = ((!cbVehiculos.EditValue.IsNullOrEmpty()) ? ((int)cbVehiculos.EditValue) : 0);
                documento.remolque_id = ((!cbRemolques.EditValue.IsNullOrEmpty()) ? ((int)cbRemolques.EditValue) : 0);
                documento.ruta_id = ((!cbRutas.EditValue.IsNullOrEmpty()) ? ((int)cbRutas.EditValue) : 0);
                documento.foraneo = cbForaneo.Checked;
                documento.supervisor_id = ((!cbSupervisores.EditValue.IsNullOrEmpty()) ? ((int)cbSupervisores.EditValue) : 0);
                documento.causalidad_id = ((!cbCausalidades.EditValue.IsNullOrEmpty()) ? ((int)cbCausalidades.EditValue) : 0);
                documento.seguimiento = cbSeguimiento.Checked;
                documento.estado_seguimiento = cbEstadoSeguimiento.SelectedIndex;
                documento.canal_id = ((!cbCanales.EditValue.IsNullOrEmpty()) ? ((int)cbCanales.EditValue) : 0);
                documento.orden_compra = txtOrdenCompra.Text;
                documento.referencia = txtReferencia.Text;
                documento.comentario = txtComentario.Text;
                documento.generar_documento_electronico = cbGenerarDocumentoElectronico.Checked;
                documento.global = cbGlobal.Checked;
                documento.uso_principal = (cbUsoPrincipal.EditValue.IsNullOrEmpty() ? Documento.UsoCFDI.ObtenerPredeterminado() : cbUsoPrincipal.EditValue.ToString());
                documento.almacen_id = ((!cbAlmacenOrigen.EditValue.IsNullOrEmpty()) ? ((int)cbAlmacenOrigen.EditValue) : 0);
                documento.almacen_destino_id = ((!cbAlmacenDestino.EditValue.IsNullOrEmpty()) ? ((int)cbAlmacenDestino.EditValue) : 0);
                if (!VerificarExistencias())
                {
                    return false;
                }
                if (Usuario.Almacen.Almacenes().Any((Usuario.Almacen x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id))
                {
                    List<int> almacenes = (from x in Usuario.Almacen.Almacenes()
                                           where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                           select x.almacen_id).ToList();
                    if (documento.partidas.Any((Documento.Partida x) => !almacenes.Contains(x.almacen_id)))
                    {
                        MessageBox.Show("No puedes utilizar uno o más almacenes de los establecidos en las partidas.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                try
                {
                    int almacen_id = (from x in Serie.Series()
                                      where x.id == documento.serie_id
                                      select x.almacen_id).First();
                    if (almacen_id != 0 && documento.partidas.Any((Documento.Partida x) => x.almacen_id != almacen_id))
                    {
                        var codigoAlmacen = (from x in Almacen.Almacenes()
                                             where x.id == almacen_id
                                             select x.codigo).FirstOrDefault();

                        MessageBox.Show($"Solo es posible utilizar el almacén {codigoAlmacen} con esta serie.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                catch
                {
                }
                try
                {
                    if (Usuario.Serie.Series().Any((Usuario.Serie x) => x.usuario_id == Program.Nori.UsuarioAutenticado.id))
                    {
                        List<int> list = (from x in Usuario.Serie.Series()
                                          where x.usuario_id == Program.Nori.UsuarioAutenticado.id
                                          select x.serie_id).ToList();
                        if (!list.Contains(documento.serie_id))
                        {
                            MessageBox.Show("No tienes autorización para utilizar esta serie.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
                catch
                {
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private bool VerificarExistencias()
        {
            try
            {
                if (documento.clase.Equals("EN") || documento.clase.Equals("FA") || documento.clase.Equals("TS") || documento.clase.Equals("PE"))
                {
                    if (!Program.Nori.Configuracion.venta_articulo_stock_cero)
                    {
                        Funciones.Cargando("Verificando existencias", "Por favor espere...");
                        List<Documento.Partida> list = ((documento.id == 0) ? documento.partidas : documento.partidas);
                        bool flag = false;
                        if (Program.Nori.Configuracion.inventario_sap)
                        {
                            foreach (Documento.Partida partida in list)
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
                            list.ForEach(delegate (Documento.Partida x)
                            {
                                x.ObtenerStock();
                            });
                            switch (documento.clase)
                            {
                                case "PE":
                                    flag = documento.partidas.Any((Documento.Partida x) => x.disponible < x.cantidad);
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
                        if (flag && !documento.reserva && documento.clase.Equals("PE"))
                        {
                            Funciones.DescartarCargando();
                            var skuDisponible = (from x in documento.partidas
                                                 where x.disponible < x.cantidad
                                                 select x.sku).FirstOrDefault();

                            MessageBox.Show($"La cantidad recae en un disponible negativo ({skuDisponible}).");
                            return false;
                        }
                        if (flag && !documento.reserva && documento.partidas.Any((Documento.Partida x) => x.documento_id == 0))
                        {
                            Funciones.DescartarCargando();
                            var sku = (from x in documento.partidas
                                       where x.stock < x.cantidad
                                       select x.sku).FirstOrDefault();

                            MessageBox.Show($"La cantidad recae en un inventario negativo ({sku}).");
                            return false;
                        }
                    }
                    try
                    {
                        if (!Program.Nori.Configuracion.venta_precio_menor_costo && documento.tipo.Equals('V') && documento.partidas.Any((Documento.Partida x) => (x.precio * x.tipo_cambio - x.costo) / x.costo * 100m < 2.5m))
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            autorizacion.codigo = "VEPDU";
                            var skuArticulo = (from x in documento.partidas
                                               where (x.subtotal / x.cantidad - x.costo) < 2.5m
                                               select x.sku).FirstOrDefault();

                            autorizacion.referencia = $"Intento de venta de un artículo con una utilidad menor del 2.5% ({skuArticulo}).";
                            autorizacion.comentario = Interaction.InputBox("Comentario venta artóculo utilidad menor (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                            autorizacion.Agregar(documento);
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                                frmSolicitarAutorizacion2.ShowDialog();
                                autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                                if (!autorizacion.autorizado)
                                {
                                    var skuArticulo1 = (from x in documento.partidas
                                                        where (x.subtotal / x.cantidad - x.costo) < 2.5m
                                                        select x.sku).FirstOrDefault();

                                    MessageBox.Show($"No es posible vender un artículo con una utilidad menor del 2.5% ({skuArticulo1}).");
                                    return false;
                                }
                            }
                            return true;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                Funciones.DescartarCargando();
            }
        }

        private bool Guardar()
        {
            try
            {
                gvPartidas.CloseEditor();
                txtArticulo.Focus();
                if (MessageBox.Show("¿Desea guardar los cambios?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Llenar())
                    {
                        if (CondicionesPago.CondicionesPagos().Any((CondicionesPago x) => x.id == this.documento.condicion_pago_id && x.pago_requerido == true) && this.documento.id == 0 && this.documento.clase.Equals("FA"))
                        {
                            GuardarPOS();
                            return true;
                        }
                        if (this.documento.identificador_externo == 0 && this.documento.estado != 'C' && Program.Nori.Configuracion.documento_borrador)
                        {
                            if (MessageBox.Show("¿Desea guardar como borrador?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                this.documento.estado = 'B';
                            }
                            else
                            {
                                this.documento.estado = 'A';
                            }
                        }

                        if (this.documento.clase.Equals("FA") && this.documento.partidas.Any((Documento.Partida x) => x.documento_id == 0))
                        {
                            MessageBox.Show("No es posible guardar una factura sin documento base.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (this.documento.clase.Equals("FA") && !Program.Nori.Configuracion.factura_sin_entregas && this.documento.partidas.Any((Documento.Partida x) => x.id == 0))
                        {
                            MessageBox.Show("No es posible guardar una factura sin documento base.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        CondicionesPago condicionesPago = CondicionesPago.Obtener(this.documento.condicion_pago_id);
                        if (condicionesPago.dias_extra > 0 && socio.DocumentosVencidos() && (this.documento.clase.Equals("PE") || this.documento.clase.Equals("FA")))
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            autorizacion.codigo = "VECDV";
                            autorizacion.referencia = $"Venta documento vencidos socio {socio.codigo}";
                            autorizacion.comentario = Interaction.InputBox("Comentario venta documentos vencidos (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                            autorizacion.Agregar(this.documento);
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                                frmSolicitarAutorizacion2.ShowDialog();
                                autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                            }
                            if (!autorizacion.autorizado)
                            {
                                return false;
                            }
                        }
                        if (this.documento.id != 0)
                        {
                            SincronizacionNetSuite();
                            return this.documento.Actualizar(actualizar_partidas: true);
                        }

                        if (this.documento.Agregar())
                        {
                            if (this.documento.generar_documento_electronico)
                            {
                                Funciones.TimbrarDocumento(this.documento);
                            }
                            if (this.documento.tipo.Equals('I'))
                            {
                                Funciones.EnviarLogisticaAsync(this.documento.id);
                            }
                            SincronizacionNetSuite();
                            if (this.documento.clase.Equals("IF") && MessageBox.Show("¿Desea realizar los ajustes de inventario correspondientes automáticamente?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Documento documento = new Documento("AE");
                                documento.CopiarDe(this.documento, "AE");
                                documento.partidas = this.documento.partidas.Where((Documento.Partida x) => x.diferencia > 0m).ToList();
                                documento.partidas.ForEach(delegate (Documento.Partida x)
                                {
                                    x.cantidad = x.diferencia;
                                });
                                documento.Agregar();
                                Documento documento2 = new Documento("AS");
                                documento2.CopiarDe(this.documento, "AS");
                                documento2.partidas = this.documento.partidas.Where((Documento.Partida x) => x.diferencia < 0m).ToList();
                                documento2.partidas.ForEach(delegate (Documento.Partida x)
                                {
                                    x.cantidad = x.diferencia * -1m;
                                });
                                documento2.Agregar();
                                MessageBox.Show("Operación realizada correctamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return false;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("No fue posible autorizar este movimiento.");

                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM") + " | Error: " + ex.Message.ToString().Replace("Nori", "DTM"), Text);
                return false;
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
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                MessageBox.Show(string.Format("Ocurrió un error al sincronizar con NetSuite", ex.Message.ToString().Replace("Nori", "DTM")));
                return false;
            }
        }

        private bool Autorizacion()
        {
            try
            {
                CondicionesPago condicionesPago = CondicionesPago.Obtener(documento.condicion_pago_id);
                if (condicionesPago.dias_extra > 0 && (documento.clase.Equals("FA") || documento.clase.Equals("EN") || documento.clase.Equals("PE")))
                {
                    decimal num = ((documento.partidas.Where((Documento.Partida x) => x.documento_id != 0).Count() == 0) ? 0m : (from x in Documento.Documentos()
                                                                                                                                 where (from y in documento.partidas
                                                                                                                                        where y.documento_id != 0
                                                                                                                                        select y.documento_id).ToList().Contains(x.id)
                                                                                                                                 select x).Sum((Documento x) => x.importe_aplicado));
                    if (documento.total > num || documento.anticipo)
                    {
                        decimal num2 = socio.limite_credito - socio.Balance();
                        bool flag = socio.DocumentosVencidos();
                        int num3 = (from x in CondicionesPago.CondicionesPagos()
                                    where x.id == documento.condicion_pago_id
                                    select x.dias_extra).First();
                        if ((documento.total > num2 || flag) && num3 > 0 && documento.socio_id != Program.Nori.UsuarioAutenticado.socio_id)
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            string text = (flag ? "(Documentos vencidos)" : "");
                            if (documento.anticipo)
                            {
                                text += " - Anticipo -";
                            }
                            string text2 = (from x in Documento.Clase.Clases()
                                            where x.clase == documento.clase
                                            select x.nombre).First();
                            if (documento.reserva)
                            {
                                text2 += " (Reserva)";
                            }
                            if (documento.anticipo)
                            {
                                text2 += " (Anticipo)";
                            }
                            autorizacion.codigo = "VEACR";
                            autorizacion.referencia = $"{text2} a crédito por {documento.total:c2} al socio {socio.nombre} ({socio.codigo}), Límite de crédito excedido en {(socio.limite_credito - socio.Balance()) * -1m:c2} {text}";
                            autorizacion.comentario = Interaction.InputBox("Comentario venta a crédito (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                            autorizacion.Agregar(documento);
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                                frmSolicitarAutorizacion2.ShowDialog();
                                autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                            }
                            return autorizacion.autorizado;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Permiso(bool cancelacion = false, bool cfdi = false)
        {
            try
            {
                Permiso permiso = NoriSDK.Permiso.Obtener(Program.Nori.UsuarioAutenticado.id, documento.clase, autorizacion: true);
                if (permiso.id != 0)
                {
                    if (permiso.cancelar && cancelacion)
                    {
                        return true;
                    }
                    if ((!permiso.agregar && documento.id == 0) || (!permiso.actualizar && documento.id != 0) || (!permiso.cancelar && cancelacion))
                    {
                        if (permiso.autorizacion)
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            string text = (cancelacion ? "Cancelación" : ((documento.id != 0) ? "Actualización" : "Creación"));
                            autorizacion.codigo = (cfdi ? "CCFDI" : "CRUDO");
                            autorizacion.usuario_autorizacion_id = permiso.usuario_autorizacion_id;
                            autorizacion.referencia = string.Format("{0} del documento {1} al cliente {2} por {3}", text, documento.clase, socio.nombre, documento.total.ToString("c2"));
                            autorizacion.comentario = Interaction.InputBox("CRUD (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                            autorizacion.Agregar();
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                                frmSolicitarAutorizacion2.ShowDialog();
                                autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                            }
                            return autorizacion.autorizado;
                        }
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GuardarPOS()
        {
            try
            {
                gvPartidas.CloseEditor();
                txtArticulo.Focus();
                if (documento.estado.Equals('A') && (documento.clase.Equals("FA") || documento.clase.Equals("EN")))
                {
                    if (NoriSDK.PuntoVenta.EstadoCaja().Equals('C'))
                    {
                        if (MessageBox.Show("¿Deseas realizar una apertura de caja?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            frmIngresos frmIngresos = new frmIngresos("INACA");
                            frmIngresos.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Para poder realizar este movimiento es necesario realizar una apertura de caja.");
                        }
                        return;
                    }
                    frmMediosPago frmMediosPago2 = new frmMediosPago(documento, socio);
                    if (frmMediosPago2.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (documento.id == 0)
                    {
                        if (MessageBox.Show("¿Estas seguro(a) de guardar el documento?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                        {
                            return;
                        }
                        cbMetodosPago.EditValue = documento.metodo_pago_id;
                        cbUsoPrincipal.EditValue = documento.uso_principal;
                        if (!Llenar())
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
                                RecargarDocumento();
                            }
                            else
                            {
                                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                            }
                            return;
                        }
                        frmAutorizacionCredito frmAutorizacionCredito2 = new frmAutorizacionCredito();
                        frmAutorizacionCredito2.socio = socio;
                        frmAutorizacionCredito2.ShowDialog();
                        if (frmAutorizacionCredito2.DialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        if (documento.Agregar())
                        {
                            if (documento.generar_documento_electronico)
                            {
                                Funciones.TimbrarDocumento(documento);
                            }
                            Imprimir(documento, 2);
                            RecargarDocumento();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                        }
                    }
                    else if (documento.flujo.Count > 0)
                    {
                        if (documento.AgregarPagoFactura(documento))
                        {
                            RecargarDocumento();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible agregar el pago.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este documento ya ha sido cerrado o no puede ser pagado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private static void Imprimir(Documento documento, short copias = 1)
        {
            try
            {
                if (documento.id == 0)
                {
                    return;
                }
                Funciones.ImprimirInformePredeterminado(documento.clase, documento.id, copias);
                documento.Impreso();
                try
                {
                    if (Program.Nori.Configuracion.tipo_metodo_pago_monedero_id == 0)
                    {
                        return;
                    }
                    foreach (Flujo item in documento.flujo.Where((Flujo x) => x.tipo_metodo_pago_id == Program.Nori.Configuracion.tipo_metodo_pago_monedero_id).ToList())
                    {
                        if (item.id != 0)
                        {
                            Funciones.ImprimirInformePredeterminado("IE", item.id);
                        }
                    }
                }
                catch
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Documentos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiNuevoSocio_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAltaRapidaSocio frmAltaRapidaSocio2 = new frmAltaRapidaSocio();
            if (frmAltaRapidaSocio2.ShowDialog() == DialogResult.OK)
            {
                socio = Socio.Obtener((from x in Socio.Socios()
                                       orderby x.id descending
                                       select x.id).First());
                EstablecerSocio();
            }
        }

        private void txtCodigoSN_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && txtCodigoSN.Text.Length > 0)
                {
                    try
                    {
                        socio = (from x in Socio.Socios()
                                 where x.codigo == txtCodigoSN.Text
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
                    frmAltaRapidaSocio2.Show();
                }
                if (e.Control && e.KeyCode == Keys.M)
                {
                    CargarMonedero();
                }
            }
            catch
            {
            }
        }

        private void barButtonItemMapaRelaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMapaRelaciones frmMapaRelaciones2 = new frmMapaRelaciones(documento);
            frmMapaRelaciones2.Show();
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
                        decimal num = (decimal)gvPartidas.ActiveEditor.EditValue;
                        decimal num2 = num / documento.partidas[e.RowHandle].cantidad - documento.partidas[e.RowHandle].impuesto;
                        if (num2 < precio.precio)
                        {
                            documento.partidas[e.RowHandle].total = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                            MessageBox.Show("No es posible vender por debajo del precio mínimo");
                            return;
                        }
                    }
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "MOTPP";
                    autorizacion.referencia = $"Modificación del total del artículo {documento.partidas[e.RowHandle].sku} de {gvPartidas.ActiveEditor.OldEditValue:c2} a {gvPartidas.ActiveEditor.EditValue:c2} al socio {socio.codigo}";
                    autorizacion.comentario = Interaction.InputBox("Comentario modifiación de total (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                    autorizacion.Agregar(documento);
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        frmSolicitarAutorizacion2.ShowDialog();
                        autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        documento.partidas[e.RowHandle].total = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                    }
                    documento.partidas[e.RowHandle].ModificarTotal();
                    return;
                }
                if (e.Column.FieldName == "porcentaje_descuento")
                {
                    Autorizacion autorizacion2 = new Autorizacion();
                    autorizacion2.codigo = "DSCPP";
                    autorizacion2.referencia = $"Descuento al artículo {documento.partidas[e.RowHandle].sku} de {gvPartidas.ActiveEditor.EditValue:p2} al socio {socio.codigo}";
                    autorizacion2.comentario = Interaction.InputBox("Comentario descuento artículo (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                    autorizacion2.Agregar(documento);
                    if (!autorizacion2.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion3 = new frmSolicitarAutorizacion(autorizacion2);
                        frmSolicitarAutorizacion3.ShowDialog();
                        autorizacion2.autorizado = frmSolicitarAutorizacion3.DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion2.autorizado)
                    {
                        documento.partidas[e.RowHandle].porcentaje_descuento = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                    }
                    documento.partidas[e.RowHandle].CalcularTotal();
                    return;
                }
                if (e.Column.FieldName == "cantidad")
                {
                    //if (documento.id != 0 || documento.partidas.Any((Documento.Partida x) => x.documento_id != 0))
                    //{
                    //    documento.partidas[e.RowHandle].CalcularCantidadPendiente(documento.id);
                    //}
                    //if (documento.partidas[e.RowHandle].id == 0)
                    //{
                    //    documento.partidas[e.RowHandle].ObtenerDescuento(documento.socio_id);
                    //}
                    documento.partidas[e.RowHandle].CalcularTotal();
                    return;
                }
                if (e.Column.FieldName == "tipo_empaque_id" || e.Column.FieldName == "cantidad_empaque")
                {
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
                if (e.Column.Name == "gridColumnPrecio")
                {
                    if (Program.Nori.UsuarioAutenticado.lista_precio_minimo_id != 0)
                    {
                        Articulo.Precio precio2 = Articulo.Precio.Obtener(documento.partidas[e.RowHandle].articulo_id, Program.Nori.UsuarioAutenticado.lista_precio_minimo_id, documento.partidas[e.RowHandle].unidad_medida_id);
                        decimal num3 = (decimal)gvPartidas.ActiveEditor.EditValue;
                        if (num3 < precio2.precio)
                        {
                            documento.partidas[e.RowHandle].total = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                            MessageBox.Show("No es posible vender por debajo del precio mínimo");
                            return;
                        }
                    }
                    if (Articulo.Articulos().Any((Articulo x) => x.almacenable == true && x.id == documento.partidas[e.RowHandle].articulo_id))
                    {
                        Autorizacion autorizacion3 = new Autorizacion();
                        autorizacion3.codigo = "MOTPP";
                        autorizacion3.referencia = $"Modificación de precio al artículo {documento.partidas[e.RowHandle].sku} de {gvPartidas.ActiveEditor.OldEditValue:c2} a {gvPartidas.ActiveEditor.EditValue:c2} al socio {socio.codigo}";
                        autorizacion3.comentario = Interaction.InputBox("Comentario modificación de precio (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                        autorizacion3.Agregar(documento);
                        if (!autorizacion3.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion4 = new frmSolicitarAutorizacion(autorizacion3);
                            frmSolicitarAutorizacion4.ShowDialog();
                            autorizacion3.autorizado = frmSolicitarAutorizacion4.DialogResult == DialogResult.OK;
                        }
                        if (!autorizacion3.autorizado)
                        {
                            documento.partidas[e.RowHandle].precio = decimal.Parse(gvPartidas.ActiveEditor.OldEditValue.ToString()) * documento.tipo_cambio;
                        }
                        else
                        {
                            documento.partidas[e.RowHandle].precio = decimal.Parse(gvPartidas.ActiveEditor.EditValue.ToString()) * documento.tipo_cambio;
                        }
                    }
                    else
                    {
                        documento.partidas[e.RowHandle].precio = decimal.Parse(gvPartidas.ActiveEditor.EditValue.ToString()) * documento.tipo_cambio;
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
                    if (documento.id == 0 && MessageBox.Show("¿Establecer esta almacén para todas las partidas?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        documento.partidas.All(delegate (Documento.Partida x)
                        {
                            x.almacen_id = documento.partidas[e.RowHandle].almacen_id;
                            x.ObtenerStock();
                            return true;
                        });
                    }
                }
                else if (e.Column.Name == "gridColumnAlmacenDestino")
                {
                    if (documento.id == 0)
                    {
                        documento.partidas[e.RowHandle].ObtenerStock();
                    }
                    if (documento.id == 0 && MessageBox.Show("¿Establecer esta almacén de destino para todas las partidas?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        documento.partidas.All(delegate (Documento.Partida x)
                        {
                            x.almacen_destino_id = documento.partidas[e.RowHandle].almacen_destino_id;
                            return true;
                        });
                    }
                }
                else if (e.Column.Name == "gridColumnUbicacion")
                {
                    if (documento.id == 0 && MessageBox.Show("¿Establecer esta ubicación para todas las partidas?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        documento.partidas.All(delegate (Documento.Partida x)
                        {
                            x.ubicacion_id = documento.partidas[e.RowHandle].ubicacion_id;
                            x.ObtenerStock();
                            return true;
                        });
                    }
                }
                else if (e.Column.Name == "gridColumnUbicacionDestino")
                {
                    if (documento.id == 0 && MessageBox.Show("¿Establecer esta ubicación de destino para todas las partidas?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        documento.partidas.All(delegate (Documento.Partida x)
                        {
                            x.ubicacion_destino_id = documento.partidas[e.RowHandle].ubicacion_destino_id;
                            return true;
                        });
                    }
                }
                else if (e.Column.Name == "gridColumnListaPrecio")
                {
                    if (documento.id == 0)
                    {
                        if (MessageBox.Show("¿Establecer esta lista de precios para todas las partidas?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            documento.lista_precio_id = documento.partidas[e.RowHandle].lista_precio_id;
                            documento.RecalcularTotalPartidas();
                        }
                        else
                        {
                            documento.partidas[e.RowHandle].ObtenerPrecio(documento.socio_id);
                        }
                    }
                }
                else
                {
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                CalcularExcel();
            }
        }

        private void gvPartidas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (documento.partidas.Count > 0)
                    {
                        documento.partidas.Remove(documento.partidas[gvPartidas.GetSelectedRows()[0]]);
                    }
                    Calcular();
                }
                if (e.Alt && e.KeyCode == Keys.E)
                {
                    DataTable resultados = (Program.Nori.Configuracion.inventario_sap ? FuncionesSAP.ObtenerExistencias(documento.partidas[gvPartidas.GetSelectedRows()[0]].sku) : Utilidades.EjecutarQuery($"SELECT codigo AS Almacén, nombre AS [Nombre del almacén], stock AS Stock, comprometido AS Compormetido, pedido AS Pedido, disponible AS Disponible, ubicacion AS Ubicacion FROM DatosInventario WHERE articulo_id = {documento.partidas[gvPartidas.GetSelectedRows()[0]].articulo_id} AND activo = 1"));
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(resultados);
                    frmResultadosBusqueda2.Text = "Existencias " + documento.partidas[gvPartidas.GetSelectedRows()[0]].sku;
                    frmResultadosBusqueda2.ShowDialog();
                }
                if (e.Alt && e.KeyCode == Keys.U)
                {
                    decimal num = documento.partidas[gvPartidas.GetSelectedRows()[0]].precio * documento.partidas[gvPartidas.GetSelectedRows()[0]].tipo_cambio;
                    decimal costo = documento.partidas[gvPartidas.GetSelectedRows()[0]].costo;
                    decimal num2 = Math.Round((num - costo) / costo * 100m, 2);
                    MessageBox.Show($"La utilidad es: {num2}%", string.Format("Utilidad bruta del artículo ", documento.partidas[gvPartidas.GetSelectedRows()[0]].sku), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (e.Alt && e.KeyCode == Keys.P)
                {
                    DataTable resultados2 = Utilidades.EjecutarQuery($"select top 30 sku SKU, nombre Artículo, precio Precio, precio + partidas.impuesto 'Precio neto', fecha_documento Fecha from partidas join documentos on partidas.documento_id = documentos.id where documentos.socio_id = {documento.socio_id} and partidas.articulo_id = {documento.partidas[gvPartidas.GetSelectedRows()[0]].articulo_id} order by partidas.id desc");
                    frmResultadosBusqueda frmResultadosBusqueda3 = new frmResultadosBusqueda(resultados2);
                    frmResultadosBusqueda3.Text = "Últimos precios " + documento.partidas[gvPartidas.GetSelectedRows()[0]].sku;
                    frmResultadosBusqueda3.ShowDialog();
                }
                if (e.Control && e.KeyCode == Keys.A)
                {
                    frmArticulos frmArticulos2 = new frmArticulos(documento.partidas[gvPartidas.GetSelectedRows()[0]].articulo_id);
                    frmArticulos2.Show();
                }
                if (e.Shift && e.KeyCode == Keys.C)
                {
                    MessageBox.Show((from x in Articulo.Articulos()
                                     where x.id == documento.partidas[gvPartidas.GetSelectedRows()[0]].articulo_id
                                     select x.comentario).First(), "Comentario del artículo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (e.Shift && e.KeyCode == Keys.A)
                {
                    frmAltaRapidaArticulo frmAltaRapidaArticulo2 = new frmAltaRapidaArticulo();
                    frmAltaRapidaArticulo2.Show();
                }
                if (e.Alt && e.KeyCode == Keys.D)
                {
                    gvPartidas.FocusedColumn = gvPartidas.Columns["porcentaje_descuento"];
                }
                if (e.Alt && e.KeyCode == Keys.T)
                {
                    gvPartidas.FocusedColumn = gvPartidas.Columns["total"];
                }
                if (e.KeyCode == Keys.Return)
                {
                    if (gvPartidas.FocusedColumn.Caption.Equals("Cantidad"))
                    {
                        gvPartidas.FocusedColumn = gvPartidas.Columns["comentario"];
                        gvPartidas.ShowEditor();
                    }
                    else if (gvPartidas.FocusedColumn.Caption.Equals("Comentario"))
                    {
                        gvPartidas.FocusedColumn = null;
                        txtArticulo.Focus();
                    }
                }
            }
            catch
            {
            }
        }

        private void gvPartidas_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    if (Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["cantidad_pendiente"])) == 0.0 && documento.id != 0)
                    {
                        e.Appearance.BackColor = Color.WhiteSmoke;
                    }
                    else if (Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["porcentaje_descuento"])) > 0.0)
                    {
                        e.Appearance.BackColor = Color.GreenYellow;
                    }

                    if ((Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["stock"])) - Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["cantidad"]))) <= 0)
                    {
                        e.Appearance.BackColor = Color.Red;
                    }

                    e.Appearance.BackColor2 = Color.White;
                }
            }
            catch
            {
            }
        }
        private void TriggerCellValueChanged(int rowHandle, string columnName, object newValue)
        {
            // Crea el evento CellValueChanged con el RowHandle, columna y nuevo valor
            var e = new DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs(rowHandle, gvPartidas.Columns[columnName], newValue);

            // Llamar al manejador de evento manualmente
            gvPartidas_CellValueChanged(gvPartidas, e);
        }
        private void AgregarärtidaExcelA(string q, string cantidad)
        {
            try
            {
                bool data = documento.AgregarPartidaExcel(q, 0, Decimal.Parse(cantidad));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al entrar aqui: " + ex.Message.ToString().Replace("Nori", "DTM"));
            }
            finally
            {
                if (documento.partidas.Count > 0)
                {
                    gvPartidas.FocusedColumn = gvPartidas.Columns["cantidad"];
                    gvPartidas.ShowEditor();
                }
                txtArticulo.Enabled = true;
            }
        }
        private async void AgregarPartidaExcel(string q, string cantidad)
        {
            try
            {
                do
                {
                    if (!(await Task.Run(() => documento.AgregarPartidaExcel(q, 0, Decimal.Parse(cantidad)))))
                    {
                        continue;
                    }
                    txtArticulo.Text = string.Empty;
                    try
                    {
                        gvPartidas.MoveFirst();
                        Documento.Partida partida = documento.partidas.Last();
                        partida.cantidad = Decimal.Parse(cantidad);
                        if (Program.Nori.Configuracion.seleccion_manual_lotes && Articulo.Articulos().Any((Articulo x) => x.id == partida.articulo_id && x.seguimiento == 'L'))
                        {
                            frmSeleccionLotes f = new frmSeleccionLotes(partida);
                            f.partida = partida;
                            f.ShowDialog();
                            if (f.lotes.Where((Lote x) => x.cantidad > 0m).Count() == 0)
                            {
                                documento.partidas.Remove(partida);
                            }
                        }
                        if (Program.Nori.Configuracion.agrupar_partidas)
                        {
                            gvPartidas.MoveBy(gvPartidas.LocateByValue("articulo_id", partida.articulo_id));

                        }
                        else
                        {
                            gvPartidas.MoveLast();
                        }
                        if ((documento.clase.Equals("PE") || documento.clase.Equals("EN") || documento.clase.Equals("FA") || documento.clase.Equals("TS")) && !partida.VerificarExistencia() && Program.Nori.Configuracion.venta_articulo_stock_cero && MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM") + " ¿Desea continuar agregando este artículo?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            documento.partidas.Remove(partida);
                        }
                    }
                    catch
                    {
                    }
                    CalcularExcel();
                    break;
                }
                while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                txtArticulo.Text = string.Empty;
                if (documento.partidas.Count > 0)
                {
                    gvPartidas.FocusedColumn = gvPartidas.Columns["cantidad"];
                    gvPartidas.ShowEditor();
                }
                txtArticulo.Enabled = true;
            }
        }
        private void buscarArticulosAlternativos(string q)
        {
            try
            {
                string text = q;
                decimal cantidad = 1m;
                if (text.Contains("*"))
                {
                    cantidad = decimal.Parse(text.Split('*')[0]);
                    text = text.Split('*')[1];
                }
                ConsultaPersonalizada consultaPersonalizada = ConsultaPersonalizada.Obtener("txtArticulo");
                consultaPersonalizada.query = "SELECT articulos.id, sku as sku_articulo, articulos.nombre, (SELECT SUM(stock) FROM inventario WHERE articulo_id = articulos.id) stock, precios.precio, monedas.codigo as moneda FROM articulos JOIN precios ON precios.articulo_id = articulos.id JOIN monedas ON monedas.id = precios.moneda_id WHERE articulos.sku IN (SELECT alt_articulo FROM articulos_alternativos where articulo='{q}') AND precios.lista_precio_id = {lista_precio_id} AND venta = 1 AND articulos.activo = 1";

                //consultaPersonalizada.query = consultaPersonalizada.query.Replace("{q}", text.Replace(" ", "%"));
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{q}", text);
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{socio_id}", documento.socio_id.ToString());
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{lista_precio_id}", documento.lista_precio_id.ToString());
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{condicion_pago_id}", documento.condicion_pago_id.ToString());
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{metodo_pago_id}", documento.metodo_pago_id.ToString());
                consultaPersonalizada.query = consultaPersonalizada.query.Replace("{moneda_id}", documento.moneda_id.ToString());
                DataTable articulos = consultaPersonalizada.Ejecutar();
                if (articulos.Rows.Count > 0)
                {

                    frmResultadosArticulosAlternativos frmResultadosBusquedaArticulosAlt = new frmResultadosArticulosAlternativos(articulos, seleccion_multiple: true);
                    DialogResult dialogResult = frmResultadosBusquedaArticulosAlt.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        frmResultadosBusquedaArticulosAlt.filas.ForEach(delegate (int x)
                        {
                            AgregarPartida($"{cantidad}*{articulos.Rows[x][1].ToString()}");
                        });
                        Calcular();
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {text}", Text);
                }
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private async void AgregarPartida(string q)
        {
            try
            {
                do
                {
                    if (!(await Task.Run(() => documento.AgregarPartida(q))))
                    {
                        if (NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM") == "El artículo no se puede vender.")
                        {
                            DialogResult result = MessageBox.Show("El artículo que buscas no está disponible, pero te ofrecemos algunas alternativas.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                buscarArticulosAlternativos(q);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                    txtArticulo.Text = string.Empty;
                    try
                    {
                        gvPartidas.MoveFirst();
                        Documento.Partida partida = documento.partidas.Last();
                        if (Program.Nori.Configuracion.seleccion_manual_lotes && Articulo.Articulos().Any((Articulo x) => x.id == partida.articulo_id && x.seguimiento == 'L'))
                        {
                            frmSeleccionLotes f = new frmSeleccionLotes(partida);
                            f.partida = partida;
                            f.ShowDialog();
                            if (f.lotes.Where((Lote x) => x.cantidad > 0m).Count() == 0)
                            {
                                documento.partidas.Remove(partida);
                            }
                        }
                        if (Program.Nori.Configuracion.agrupar_partidas)
                        {
                            gvPartidas.MoveBy(gvPartidas.LocateByValue("articulo_id", partida.articulo_id));
                        }
                        else
                        {
                            gvPartidas.MoveLast();
                        }
                        if ((documento.clase.Equals("PE") || documento.clase.Equals("EN") || documento.clase.Equals("FA") || documento.clase.Equals("TS")) && !partida.VerificarExistencia() && Program.Nori.Configuracion.venta_articulo_stock_cero && MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM") + " ¿Desea continuar agregando este artículo?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            documento.partidas.Remove(partida);
                        }
                    }
                    catch
                    {
                    }
                    Calcular();
                    break;
                }
                while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                txtArticulo.Text = string.Empty;
                if (documento.partidas.Count > 0)
                {
                    gvPartidas.FocusedColumn = gvPartidas.Columns["cantidad"];
                    gvPartidas.ShowEditor();
                }
                txtArticulo.Enabled = true;
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Tab || txtArticulo.Text.Length <= 0)
                {
                    return;
                }
                string text = txtArticulo.Text;
                decimal cantidad = 1m;
                if (text.Contains("*"))
                {
                    cantidad = decimal.Parse(text.Split('*')[0]);
                    text = text.Split('*')[1];
                }
                ConsultaPersonalizada consultaPersonalizada = ConsultaPersonalizada.Obtener("txtArticulo");
                if (consultaPersonalizada.query.IsNullOrEmpty())
                {
                    consultaPersonalizada.query = "SELECT articulos.id, sku as sku_articulo, articulos.nombre, (SELECT SUM(stock) FROM inventario WHERE articulo_id = articulos.id) stock, precios.precio, monedas.codigo as moneda FROM articulos JOIN precios ON precios.articulo_id = articulos.id JOIN monedas ON monedas.id = precios.moneda_id AND precios.lista_precio_id = {lista_precio_id} WHERE (sku = '{q}' OR articulos.nombre LIKE '%{q}%' OR codigo_barras LIKE '%{q}%') AND venta = 1 AND articulos.activo = 1";
                }
                //consultaPersonalizada.query = consultaPersonalizada.query.Replace("{q}", text.Replace(" ", "%"));
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
                    frmResultadosBusquedaArticulos frmResultadosBusquedaArticulos2 = new frmResultadosBusquedaArticulos(articulos, seleccion_multiple: true);
                    DialogResult dialogResult = frmResultadosBusquedaArticulos2.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        frmResultadosBusquedaArticulos2.filas.ForEach(delegate (int x)
                        {
                            AgregarPartida($"{cantidad}*{articulos.Rows[x][1].ToString()}");
                        });
                        Calcular();
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {text}", Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && txtArticulo.Text.Length > 0)
                {
                    txtArticulo.Enabled = false;
                    AgregarPartida(txtArticulo.Text);
                }
            }
            catch
            {
            }
        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {
            if (!(documento.total > 0m) || documento.estado != 'A')
            {
                return;
            }
            frmDescuento frmDescuento2 = new frmDescuento();
            frmDescuento2.total = documento.total;
            DialogResult dialogResult = frmDescuento2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (documento.descuento > 0m)
                {
                    if (MessageBox.Show(string.Format("El documento actualmente tiene un descuento de {0} ¿desea acumularlo?", documento.descuento.ToString("c2")), Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documento.descuento += frmDescuento2.descuento;
                        documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                    }
                    else
                    {
                        documento.descuento = frmDescuento2.descuento;
                        documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                    }
                }
                else
                {
                    documento.descuento = frmDescuento2.descuento;
                    documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                }
            }
            Calcular();
        }

        private void cbDireccionesFacturacion_EditValueChanged(object sender, EventArgs e)
        {
            BloqueDirecciones();
        }

        private void txtTipoCambio_EditValueChanged(object sender, EventArgs e)
        {
            documento.tipo_cambio = decimal.Parse(txtTipoCambio.EditValue.ToString());
            Calcular();
        }

        private void txtCodigoSN_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Tab && txtCodigoSN.Text.Length > 0)
                {
                    BuscarSocios(txtCodigoSN.Text);
                }
            }
            catch
            {
            }
        }

        private void btnDireccionFacturacion_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = new Socio.Direccion();
                direccion.socio_id = documento.socio_id;
                direccion.tipo = 'F';
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                if (frmDireccion2.direccion.id != 0)
                {
                    documento.direccion_facturacion_id = frmDireccion2.direccion.id;
                }
                CargarDirecciones();
            }
        }

        private void btnAgregarDireccionEnvio_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = new Socio.Direccion();
                direccion.tipo = 'E';
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                if (frmDireccion2.direccion.id != 0)
                {
                    documento.direccion_envio_id = frmDireccion2.direccion.id;
                }
                CargarDirecciones();
            }
        }

        private void btnCFDI_Click(object sender, EventArgs e)
        {
            try
            {
                if (documento.EsDocumentoElectronico() && documento.generar_documento_electronico)
                {
                    Funciones.TimbrarDocumento(documento);
                    CargarDocumentoElectronico();
                }
                else
                {
                    MessageBox.Show("El documento no es electrónico o no se ha establecido la generación electrónica.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDocumentoElectronico();
        }

        private void bbiRecargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            RecargarDocumento();
        }

        private void RecargarDocumento()
        {
            if (documento.id != 0)
            {
                documento = Documento.Obtener(documento.id);
                Cargar();
            }
            else
            {
                bbiNuevo.PerformClick();
            }
        }

        private void bbiCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar este documento?", "Cerrar documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (documento.estado.Equals('A'))
            {
                if (documento.Cerrar(manualmente_cerrado: true))
                {
                    RecargarDocumento();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
            }
            else
            {
                MessageBox.Show("Este documento ya ha sido cerrado.");
            }
        }

        public void CancelarAnt()
        {
            if (documento.EsDocumentoElectronico())
            {
                //DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                //if (Program.Nori.Configuracion.forzar_cancelacion_cfdi && documentoElectronico.folio_fiscal.Length > 0 && documentoElectronico.estado_cancelacion != "Cancelado" && MessageBox.Show("¿El documento aún no ha sido cancelado ante la autoridad, aún así desea cancelarlo?", "Cancelar CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                //{
                //    MessageBox.Show("Para cancelar este documento primero cancela el documento electrónico asociado y revisa que el estado de la cancelación sea 'Cancelado'", "Cancelar documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                if (MessageBox.Show("¿Estas seguro de cancelar este documento?", "Cancelar documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }
            if (!documento.cancelado)
            {
                if (!Permiso(cancelacion: true))
                {
                    return;
                }
                documento.comentario = Interaction.InputBox("Ingresa un comentario sobre la cancelación", "Cancelación documento", documento.comentario);
                if (documento.Cancelar(agregar_sincronizacion: true))
                {
                    if (Program.Nori.Configuracion.netsuite)
                    {
                        if (documento.clase.Equals("FA"))
                        {
                            InvoiceHelper invoiceHelper = new InvoiceHelper();
                            invoiceHelper.DeleteInvoice(documento.identificador_externo.ToString());
                        }
                        else if (documento.clase.Equals("EN"))
                        {
                            CashSaleHelper cashSaleHelper = new CashSaleHelper();
                            cashSaleHelper.DeleteCashSale(documento.identificador_externo.ToString());
                        }
                        else if (documento.clase.Equals("PE"))
                        {
                            SalesOrderHelper salesOrderHelper = new SalesOrderHelper();
                            salesOrderHelper.DeleteSalesOrder(documento.identificador_externo.ToString());
                        }
                    }
                    RecargarDocumento();
                    CancelarDocumentoElectronico();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
            }
            else
            {
                MessageBox.Show("Este documento ya ha sido cancelado.");
            }
        }
        public void CancelarAnterior()
        {
            if (documento.EsDocumentoElectronico())
            {
                DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                if (Program.Nori.Configuracion.forzar_cancelacion_cfdi && documentoElectronico.folio_fiscal.Length > 0 && documentoElectronico.estado_cancelacion != "Cancelado" && MessageBox.Show("¿El documento aún no ha sido cancelado ante la autoridad, aún así desea cancelarlo?", "Cancelar CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    MessageBox.Show("Para cancelar este documento primero cancela el documento electrónico asociado y revisa que el estado de la cancelación sea 'Cancelado'", "Cancelar documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (MessageBox.Show("¿Estas seguro de cancelar este documento?", "Cancelar documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (!documento.cancelado)
            {
                if (!Permiso(cancelacion: true))
                {
                    return;
                }
                documento.comentario = Interaction.InputBox("Ingresa un comentario sobre la cancelación", "Cancelación documento", documento.comentario);
                if (documento.Cancelar(agregar_sincronizacion: true))
                {
                    if (Program.Nori.Configuracion.netsuite)
                    {
                        if (documento.clase.Equals("FA"))
                        {
                            InvoiceHelper invoiceHelper = new InvoiceHelper();
                            invoiceHelper.DeleteInvoice(documento.identificador_externo.ToString());
                        }
                        else if (documento.clase.Equals("EN"))
                        {
                            CashSaleHelper cashSaleHelper = new CashSaleHelper();
                            cashSaleHelper.DeleteCashSale(documento.identificador_externo.ToString());
                        }
                        else if (documento.clase.Equals("PE"))
                        {
                            SalesOrderHelper salesOrderHelper = new SalesOrderHelper();
                            salesOrderHelper.DeleteSalesOrder(documento.identificador_externo.ToString());
                        }
                    }
                    RecargarDocumento();
                    CancelarDocumentoElectronico();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
            }
            else
            {
                MessageBox.Show("Este documento ya ha sido cancelado.");
            }
        }
        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (documento.clase.Equals("FA") || documento.clase.Equals("NC"))
            {
                frmAutorizarVentaVencida frmAutorizarVentaVencida = new frmAutorizarVentaVencida();
                frmAutorizarVentaVencida.Owner = this;
                frmAutorizarVentaVencida.ShowDialog();
                if (Autorizar == true)
                {
                    CancelarAnt();
                }
            }
            else
            {
                CancelarAnterior();
            }
        }

        private void CancelarDocumentoElectronico()
        {
            if (!documento.EsDocumentoElectronico())
            {
                return;
            }
            DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
            if (!documentoElectronico.estado.Equals('A') || documentoElectronico.folio_fiscal.Length <= 0)
            {
                return;
            }
            if (MessageBox.Show("¿Estas seguro de cancelar este CFDI?", "Cancelar CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!documento.cancelado && Permiso(cancelacion: true, cfdi: true))
                {
                    string text = Interaction.InputBox("Motivo cancelación (01 - Comprobantes emitidos con errores con relación, 02 - Comprobantes emitidos con errores sin relación, 03 - No se llevó a cabo la operación, 04 - Operación nominativa relacionada en una factura global)", "Cancelar CFDI", "02");
                    string folio_fiscal_sustitucion = (text.Equals("01") ? Interaction.InputBox("UUID Sustitución de comprobantes emitidos con errores con relación", "DTM SOLUTIONS POS", "", -1, -1) : "");
                    documentoElectronico.motivo = text;
                    documentoElectronico.folio_fiscal_sustitucion = folio_fiscal_sustitucion;
                    documentoElectronico.Actualizar();
                    Funciones.CancelarTimbreDocumentoElectronico(documentoElectronico);
                    CargarDocumentoElectronico();
                }
            }
            else
            {
                MessageBox.Show("Este documento ya ha sido cancelado.");
            }
        }

        private void EliminarDocumentoElectronico()
        {
            if (documento.EsDocumentoElectronico())
            {
                DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                if (MessageBox.Show("¿Deseas eliminar el CFDI?: Esta opción NO cancela el CFDI ante el SAT, solo quita el registro de la base de datos.", "Eliminar CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    documentoElectronico.Eliminar();
                    CargarDocumentoElectronico();
                }
            }
        }

        private void lblCodigoSN_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios2 = new frmSocios(socio.id);
            frmSocios2.ShowDialog();
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && (txtNumeroDocumento.Text.Length > 0 || txtReferencia.Text.Length > 0) && documento.id == 0)
            {
                Buscar();
            }
        }

        private void bbiPagar_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuardarPOS();
        }

        private void gvPartidas_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!documento.partidas[gvPartidas.GetSelectedRows()[0]].Modificable())
            {
                e.Cancel = true;
            }
        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas frmMonedas2 = new frmMonedas((int)cbMonedas.EditValue);
            frmMonedas2.ShowDialog();
        }

        private void cbMonedas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (documento.id == 0 || documento.clase.Equals("CO") || documento.clase.Equals("PE"))
                {
                    documento.moneda_id = (int)cbMonedas.EditValue;
                    txtTipoCambio.EditValue = TipoCambio.Venta(documento.moneda_id);
                    txtTipoCambio.Visible = ((Program.Nori.Configuracion.moneda_id != documento.moneda_id) ? true : false);
                }
            }
            catch
            {
            }
        }

        private void bbiXLSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string text = $"{Program.Nori.Configuracion.directorio_documentos}\\{documento.id}.xlsx";
                gcPartidas.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bbiEnviar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (documento.id == 0)
                {
                    return;
                }
                int id = (from x in Informe.Informes()
                          where x.tipo == documento.clase && x.activo == true && x.predeterminado_correo_electronico == true
                          select x.id).First();
                frmCorreoElectronico frmCorreoElectronico2 = new frmCorreoElectronico();
                frmCorreoElectronico2.socio = socio;
                frmCorreoElectronico2.documento_id = documento.id;
                frmCorreoElectronico2.anexos.Add(Funciones.PDFInforme(id, documento.id));
                try
                {
                    if (documento.EsDocumentoElectronico())
                    {
                        DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                        if (documentoElectronico.id != 0 && documentoElectronico.estado.Equals('A'))
                        {
                            frmCorreoElectronico2.anexos.Add($"{Program.Nori.Configuracion.directorio_xml}\\{documentoElectronico.folio_fiscal}.xml");
                        }
                    }
                }
                catch
                {
                }
                //frmCorreoElectronico2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnGenerarPuntos_Click(object sender, EventArgs e)
        {
            if (documento.GenerarPuntos())
            {
                MessageBox.Show("Se generarón los puntos correctamente");
            }
            else
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            try
            {
                var source = from x in Documento.Documentos()
                             where x.socio_id == documento.socio_id && (x.clase == "AN" || x.clase == "FA" || x.clase == "NC" || x.clase == "ND")
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 ID = x.id,
                                 Clase = x.clase,
                                 No = x.numero_documento,
                                 NoSAP = x.numero_documento_externo,
                                 Fecha = x.fecha_documento,
                                 Total = x.total,
                                 Aplicado = x.importe_aplicado,
                                 Estado = x.estado,
                                 Reserva = x.reserva,
                                 Anticipo = x.anticipo,
                                 Cancelado = x.cancelado
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    {
                        foreach (int documento_id in frmResultadosBusqueda2.ids)
                        {
                            Documento.Referencia referencia = new Documento.Referencia();
                            referencia.documento_id = documento.id;
                            referencia.documento_referencia_id = documento_id;
                            if (!documento.referencias.Any((Documento.Referencia x) => x.documento_referencia_id == documento_id))
                            {
                                documento.referencias.Add(referencia);
                                CargarReferencias();
                            }
                        }
                        return;
                    }
                }
                MessageBox.Show("No se encontraron resultados", Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarReferencias()
        {
            try
            {
                lbReferencias.Visible = true;
                lbReferencias.Items.Clear();
                foreach (Documento.Referencia referencia in documento.referencias)
                {
                    var documento_referencia = (from x in Documento.Documentos()
                                                where x.id == referencia.documento_referencia_id
                                                select new { x.id, x.numero_documento, x.clase, x.estado, x.total }).First();
                    lbReferencias.Items.Add(string.Format("{0} {1} Total: {2} {3}", (from x in Documento.Clase.Clases()
                                                                                     where x.clase == documento_referencia.clase
                                                                                     select x).First().nombre, documento_referencia.numero_documento, documento_referencia.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                                                                  where x.estado == documento_referencia.estado
                                                                                                                                                                                                  select x).First().nombre));
                }
            }
            catch
            {
            }
        }

        private void CargarAnexos()
        {
            try
            {
                lbAnexos.Items.Clear();
                foreach (Documento.Anexo anexo in documento.anexos)
                {
                    lbAnexos.Items.Add($"{anexo.anexo} - {anexo.fecha_creacion.ToShortDateString()}");
                }
            }
            catch
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarDocumentoElectronico();
        }

        private void gvPartidas_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.Name == "gridColumnNo" && e.IsGetData)
            {
                e.Value = e.ListSourceRowIndex + 1;
            }
        }

        private void bbiAjustarColumnas_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvPartidas.BestFitColumns();
        }

        private void txtNumeroDocumentoExterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtNumeroDocumento.Text.Length > 0 && documento.id == 0)
            {
                Buscar();
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
                if (!documento.EsDocumentoElectronico() || documento.id == 0 || !Program.Nori.UsuarioAutenticado.rol.Equals('A'))
                {
                    return;
                }
                DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                if (documentoElectronico.estado != 'A' && documentoElectronico.folio_fiscal.Length == 0)
                {
                    string folio_fiscal = Interaction.InputBox("Ingresa el folio fiscal (UUID)", "Importar folio fiscal");
                    documentoElectronico.documento_id = documento.id;
                    documentoElectronico.estado = 'A';
                    documentoElectronico.folio_fiscal = folio_fiscal;
                    if ((documentoElectronico.id == 0) ? documentoElectronico.Agregar() : documentoElectronico.Actualizar())
                    {
                        MessageBox.Show("Se importó el folio fiscal correctamente");
                    }
                    else
                    {
                        MessageBox.Show($"Error al importar folio fiscal: {NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM")}", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
            finally
            {
                CargarDocumentoElectronico();
            }
        }

        private void btnSolicitarEtiquetas_Click(object sender, EventArgs e)
        {
            try
            {
                Etiqueta etiqueta = new Etiqueta();
                etiqueta.almacen_id = Program.Nori.UsuarioAutenticado.almacen_id;
                foreach (Documento.Partida partida2 in documento.partidas)
                {
                    Etiqueta.Partida partida = new Etiqueta.Partida();
                    partida.cantidad = Convert.ToInt32(partida2.cantidad);
                    partida.articulo_id = partida2.articulo_id;
                    etiqueta.partidas.Add(partida);
                }
                if (etiqueta.Agregar())
                {
                    MessageBox.Show("Solicitud creada correctamente.");
                    frmEtiquetas frmEtiquetas2 = new frmEtiquetas(etiqueta.id);
                    frmEtiquetas2.Show();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void bbiDuplicar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                List<Documento.Partida> partidas = documento.partidas;
                partidas.All(delegate (Documento.Partida x)
                {
                    x.documento_id = 0;
                    x.id = 0;
                    return true;
                });
                string clase = documento.clase;
                documento = new Documento();
                documento.clase = clase;
                documento.partidas = partidas;
                Cargar(nuevo: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void lblChofer_Click(object sender, EventArgs e)
        {
            frmChoferes frmChoferes2 = new frmChoferes(documento.chofer_id);
            frmChoferes2.ShowDialog();
            CargarListas();
        }

        private void lblVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculos frmVehiculos2 = new frmVehiculos(documento.vehiculo_id);
            frmVehiculos2.ShowDialog();
            CargarListas();
        }

        private void btnEstadoCFDI_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Funciones.ObtenerEstado(documento.DocumentoElectronico()), "Estado CFDI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
            }
        }

        private void bbiCancelacionManualCFDI_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string uuid = Interaction.InputBox("UUID", "DTM SOLUTIONS POS", "", -1, -1);
                string rfc_receptor = Interaction.InputBox("RFC Receptor", "DTM SOLUTIONS POS", "", -1, -1);
                double total = double.Parse(Interaction.InputBox("Total", "DTM SOLUTIONS POS", "", -1, -1));
                string text = Interaction.InputBox("Motivo cancelación (01, 02, 03, 04)", "02");
                string sustitucion = (text.Equals("01") ? Interaction.InputBox("UUID Sustitución", "DTM SOLUTIONS POS", "", -1, -1) : "");
                MessageBox.Show(Funciones.CancelarCFDi(uuid, rfc_receptor, total, text, sustitucion));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = txtUUIDPorCancelar.Lines;
            foreach (string text in lines)
            {
                try
                {
                    string[] array = text.Split(',');
                    string uuid = array[0];
                    string rfc_receptor = array[1];
                    double total = double.Parse(array[2]);
                    string motivo = array[3];
                    string sustitucion = array[4];
                    string text2 = Funciones.CancelarCFDi(uuid, rfc_receptor, total, motivo, sustitucion);
                    if (text2.Contains("Error"))
                    {
                        txtUUIDErrorCancelacion.AppendText("\r\n" + text);
                    }
                }
                catch
                {
                    txtUUIDErrorCancelacion.AppendText("\r\n" + text);
                }
            }
        }

        private void lblCanal_Click(object sender, EventArgs e)
        {
            frmCanales frmCanales2 = new frmCanales((int)cbCanales.EditValue);
            frmCanales2.ShowDialog();
        }

        private void lblSupervisores_Click(object sender, EventArgs e)
        {
            frmSupervisores frmSupervisores2 = new frmSupervisores((int)cbSupervisores.EditValue);
            frmSupervisores2.ShowDialog();
        }

        private void cbSeries_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (documento.id != 0)
                {
                    return;
                }
                int almacen_id = (from x in Serie.Series()
                                  where x.id == (int)cbSeries.EditValue
                                  select x.almacen_id).First();
                txtNumeroDocumento.Text = (from x in Serie.Series()
                                           where x.id == (int)cbSeries.EditValue
                                           select x.siguiente).First().ToString();
                if (almacen_id != 0)
                {
                    documento.partidas.All(delegate (Documento.Partida x)
                    {
                        x.almacen_id = almacen_id;
                        x.ObtenerStock();
                        return true;
                    });
                }
            }
            catch
            {
            }
        }

        private void frmDocumentos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.N)
                {
                    Nuevo();
                }
                if (e.Control && e.KeyCode == Keys.B)
                {
                    Buscar();
                }
                if (e.Alt && e.KeyCode == Keys.B)
                {
                    frmBascula frmBascula2 = new frmBascula();
                    frmBascula2.ShowDialog();
                }
                if (e.Alt && e.KeyCode == Keys.O)
                {
                    OrdenCompra();
                }
                if (e.Shift && e.KeyCode == Keys.V)
                {
                    cbVendedores.Focus();
                }
                if (e.Alt && e.KeyCode == Keys.V)
                {
                    VerificarExistencias();
                }
                if (e.Control && e.KeyCode == Keys.M)
                {
                    CargarMonedero();
                }
                if (e.Control && e.KeyCode == Keys.P)
                {
                    Imprimir(documento, 1);
                }
                if (e.Alt && e.KeyCode == Keys.C)
                {
                    txtComentario.Focus();
                }
                if (e.Control && e.KeyCode == Keys.D && documento.total > 0m && documento.estado == 'A')
                {
                    frmDescuento frmDescuento2 = new frmDescuento();
                    frmDescuento2.total = documento.total;
                    DialogResult dialogResult = frmDescuento2.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        if (documento.descuento > 0m)
                        {
                            if (MessageBox.Show(string.Format("El documento actualmente tiene un descuento de {0} ¿desea acumularlo?", documento.descuento.ToString("c2")), Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                documento.descuento += frmDescuento2.descuento;
                                documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                            }
                            else
                            {
                                documento.descuento = frmDescuento2.descuento;
                                documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                            }
                        }
                        else
                        {
                            documento.descuento = frmDescuento2.descuento;
                            documento.porcentaje_descuento = documento.descuento / documento.total * 100m;
                        }
                    }
                    Calcular();
                }
                if (e.Control && e.KeyCode == Keys.S)
                {
                    Guardar();
                }
                //if (e.Alt && e.KeyCode == Keys.S)
                //{
                //    ArticuloSolicitado articuloSolicitado = new ArticuloSolicitado();
                //    articuloSolicitado.socio_id = documento.socio_id;
                //    articuloSolicitado.sku = Interaction.InputBox("Ingrese el código del artículo solicitado", "DTM SOLUTIONS POS", "", -1, -1);
                //    articuloSolicitado.descripcion = Interaction.InputBox("Ingresa la descripción del artículo solicitado", "DTM SOLUTIONS POS", "", -1, -1);
                //    articuloSolicitado.cantidad = int.Parse(Interaction.InputBox("Ingresa la cantidad solicitada", "1"));
                //    articuloSolicitado.comentarios = Interaction.InputBox("Comentario sobre artículo solicitado (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                //    articuloSolicitado.Agregar();
                //}
                if (e.KeyCode == Keys.F1)
                {
                    new frmDocumentos("CO").Show();
                }
                if (e.KeyCode == Keys.F2)
                {
                    new frmDocumentos("PE").Show();
                }
              
                if (e.KeyCode == Keys.F5)
                {
                    new frmDocumentos("FA").Show();
                }
                if (e.KeyCode == Keys.F6)
                {
                    new frmDocumentos("NC").Show();
                }
                //if (e.KeyCode == Keys.F7)
                //{
                //    new frmDocumentos("TS").Show();
                //}
                //if (e.KeyCode == Keys.F8)
                //{
                //    new frmDocumentos("AE").Show();
                //}
            }
            catch
            {
            }
        }

        private void lblCausalidades_Click(object sender, EventArgs e)
        {
            frmCausalidades frmCausalidades2 = new frmCausalidades((int)cbCausalidades.EditValue);
            frmCausalidades2.ShowDialog();
        }

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destFileName = Program.Nori.Configuracion.directorio_anexos + "\\" + openFileDialog.SafeFileName;
                Documento.Anexo anexo = new Documento.Anexo();
                anexo.anexo = openFileDialog.SafeFileName;
                System.IO.File.Copy(openFileDialog.FileName, destFileName, overwrite: true);
                documento.anexos.Add(anexo);
                CargarAnexos();
            }
        }

        private void btnVisualizarAnexo_Click(object sender, EventArgs e)
        {
            try
            {
                var anexoSinFecha = lbAnexos.SelectedValue.ToString().Split('-')[0].Trim();
                string archivo = Program.Nori.Configuracion.directorio_anexos + "\\" + anexoSinFecha;
                Funciones.AbrirArchivo(archivo);
            }
            catch
            {
            }
        }

        private void lblCancelacionMasiva_Click(object sender, EventArgs e)
        {
            LabelControl labelControl = lblUUIDPorCancelar;
            RichTextBox richTextBox = txtUUIDPorCancelar;
            LabelControl labelControl2 = lblUUIDErrorCancelacion;
            RichTextBox richTextBox2 = txtUUIDErrorCancelacion;
            bool flag2 = (btnCancelacionMasiva.Visible = true);
            bool flag4 = (richTextBox2.Visible = flag2);
            bool flag6 = (labelControl2.Visible = flag4);
            bool visible = (richTextBox.Visible = flag6);
            labelControl.Visible = visible;
        }

        private void gvPartidas_ShownEditor(object sender, EventArgs e)
        {
            try
            {
                ColumnView columnView = (ColumnView)sender;
                if (columnView.FocusedColumn.FieldName == "unidad_medida_id")
                {
                    LookUpEdit lookUpEdit = (LookUpEdit)columnView.ActiveEditor;
                    int articulo_id2 = Convert.ToInt32(columnView.GetFocusedRowCellValue("articulo_id"));
                    lookUpEdit.Properties.DataSource = Articulo.UnidadesMedida(articulo_id2);
                }
                else if (columnView.FocusedColumn.FieldName == "ubicacion_id")
                {
                    LookUpEdit lookUpEdit2 = (LookUpEdit)columnView.ActiveEditor;
                    int articulo_id = Convert.ToInt32(columnView.GetFocusedRowCellValue("articulo_id"));
                    int almacen_id = Convert.ToInt32(columnView.GetFocusedRowCellValue("almacen_id"));
                    List<int> ubicaciones = (from x in Articulo.Inventario.Ubicacion.Ubicaciones()
                                             where x.almacen_id == almacen_id && x.articulo_id == articulo_id
                                             select x.ubicacion_id).ToList();
                    lookUpEdit2.Properties.DataSource = from x in Almacen.Ubicacion.Ubicaciones()
                                                        where ubicaciones.Contains(x.id)
                                                        select new { x.id, x.codigo, x.ubicacion };
                }
            }
            catch
            {
            }
        }

        private void cbEstadoSeguimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (documento.seguimiento)
                {
                    string id = documento.id.ToString();
                    string numero_documento = documento.numero_documento.ToString();
                    string total = documento.total.ToString("c2");
                    string selectedText = cbEstadoSeguimiento.SelectedText;
                    string nombre = socio.nombre;
                    string rfc = socio.rfc;
                    string direccion_envio = txtDireccionEnvio.Text;
                    string correo = socio.correo;
                    Funciones.EnviarSeguimientoAsync(id, numero_documento, total, selectedText, nombre, rfc, direccion_envio, correo);
                    MessageBox.Show("Se actualizó y notificó el seguimiento correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void lblRuta_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas2 = new frmRutas((int)cbRutas.EditValue);
            frmRutas2.ShowDialog();
        }

        private void btnGenerarRFCGenerico_Click(object sender, EventArgs e)
        {
            try
            {
                if (documento.EsDocumentoElectronico() && documento.generar_documento_electronico)
                {
                    Funciones.TimbrarDocumento(documento, "XAXX010101000");
                    CargarDocumentoElectronico();
                }
                else
                {
                    MessageBox.Show("El documento no es electrónico o no se ha establecido la generación electrónica.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAnticipos_Click(object sender, EventArgs e)
        {
            try
            {
                var source = from x in Documento.Documentos()
                             where x.socio_id == documento.socio_id && x.anticipo == true && x.cancelado == false && x.importe_aplicado_anticipo < x.total && (x.clase == "AN" || x.clase == "FA")
                             orderby x.fecha_creacion descending
                             select new
                             {
                                 ID = x.id,
                                 Clase = x.clase,
                                 No = x.numero_documento,
                                 NoSAP = x.numero_documento_externo,
                                 Fecha = x.fecha_documento,
                                 Total = x.total,
                                 Aplicado = x.importe_aplicado_anticipo,
                                 Saldo = x.total - x.importe_aplicado_anticipo
                             };
                DataTable dataTable = source.ToList().ToDataTable();
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable, seleccion_multiple: true);
                    DialogResult dialogResult = frmResultadosBusqueda2.ShowDialog();
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    {
                        foreach (int documento_id in frmResultadosBusqueda2.ids)
                        {
                            Documento.Referencia referencia = new Documento.Referencia();
                            referencia.documento_id = documento.id;
                            referencia.documento_referencia_id = documento_id;
                            if (!documento.referencias.Any((Documento.Referencia x) => x.documento_referencia_id == documento_id))
                            {
                                documento.referencias.Add(referencia);
                                CargarReferencias();
                            }
                        }
                        return;
                    }
                }
                MessageBox.Show("No se encontraron resultados", Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnEliminarDE_Click(object sender, EventArgs e)
        {
            EliminarDocumentoElectronico();
        }

        private void btnGenerarSustitucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (documento.EsDocumentoElectronico() && documento.generar_documento_electronico)
                {
                    if (MessageBox.Show("¿Deseas sustituir el CFDI?: Esta opción crea un nuevo CFDI y agrega como relación de sustitución el CFDI actual.", "Sustituir CFDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DocumentoElectronico documentoElectronico = documento.DocumentoElectronico();
                        if (!documentoElectronico.folio_fiscal.IsNullOrEmpty())
                        {
                            documentoElectronico.estado = 'S';
                            documentoElectronico.Actualizar();
                            Funciones.TimbrarDocumento(documento, null, documentoElectronico.id);
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
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnGenerarTransferenciaStock_Click(object sender, EventArgs e)
        {
            Documento.Clase clase = new Documento.Clase();
            clase.tipo = 'I';
            clase.clase = "TS";
            clase.nombre = "Transferencia de stock";
            CopiarDocumento(clase, ts: true);
        }

        private void lbReferencias_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete && documento.id == 0 && MessageBox.Show("¿Desea eliminar esta referencia?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    documento.referencias.RemoveAt(lbReferencias.SelectedIndex);
                    CargarReferencias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void cbCondicionesPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (socio.condicion_pago_id == int.Parse(cbCondicionesPago.EditValue.ToString()))
                {
                    cbMetodosPago.EditValue = socio.metodo_pago_id;
                }
            }
            catch (Exception)
            {
            }
        }

        private void lblRemolque_Click(object sender, EventArgs e)
        {
            frmRemolques frmRemolques2 = new frmRemolques(documento.remolque_id);
            frmRemolques2.ShowDialog();
            CargarListas();
        }

        private void btnEditarDireccionEnvio_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = Socio.Direccion.Obtener(documento.direccion_envio_id);
                direccion.tipo = 'E';
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                CargarDirecciones();
            }
        }

        private void btnEditarDireccionFacturacion_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = Socio.Direccion.Obtener(documento.direccion_facturacion_id);
                direccion.tipo = 'F';
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                CargarDirecciones();
            }
        }

        private void btnAgregarDireccionOrigen_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = new Socio.Direccion();
                direccion.tipo = 'E';
                direccion.socio_id = Program.Nori.UsuarioAutenticado.socio_id;
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                if (frmDireccion2.direccion.id != 0)
                {
                    documento.direccion_origen_id = frmDireccion2.direccion.id;
                }
                CargarDirecciones();
            }
        }

        private void btnEditarDireccionOrigen_Click(object sender, EventArgs e)
        {
            if (documento.socio_id != 0)
            {
                Socio.Direccion direccion = Socio.Direccion.Obtener(documento.direccion_origen_id);
                frmDireccion frmDireccion2 = new frmDireccion();
                frmDireccion2.direccion = direccion;
                frmDireccion2.ShowDialog();
                CargarDirecciones();
            }
        }

        private void txtTipoCambio_EditValueChanging(object sender, ChangingEventArgs e)
        {
        }

        private void lblFechaVencimiento_DoubleClick(object sender, EventArgs e)
        {
            frmFechasEntrega frmFechasEntrega2 = new frmFechasEntrega();
            frmFechasEntrega2.Show();
        }

        private void bbiParametrizaciones_ItemClick(object sender, ItemClickEventArgs e)
        {

            btnBuscar frmForm = new btnBuscar();
            frmForm.ShowDialog();
            //frmParametrizacionesFormulario frmParametrizacionesFormulario2 = new frmParametrizacionesFormulario(base.Name, documento.clase);
            //frmParametrizacionesFormulario2.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            documento.Abrir(manualmente_abierto: true);
            RecargarDocumento();
        }

        private void btnDescuentosEspeciales_Click(object sender, EventArgs e)
        {
            GridView gridView = gcPartidas.MainView as GridView;
            int rowCount = gridView.DataRowCount;
            if (rowCount != 0)
            {
                Funciones.Cargando("Obteniendo descuentos especiales", "Por favor espere...");
                documento.ObtenerDescuentosEspeciales(documento.socio_id, documento.lista_precio_id, forzar: true);
                CalcularExcel();
                Funciones.DescartarCargando();
            }
            else
            {
                MessageBox.Show("No es posible agregar un descuento, no hay ninguna fila");
            }

        }

        private void btnCargaArticulos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "Excel Worksheets|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                    SplashScreenManager.Default.SetWaitFormDescription("Sincronizando Excel...");

                    DataExcel dataExcel = new DataExcel();
                    DataTable dt = dataExcel.LeerExcelEnDataTable(file);

                    int contador = 0;

                    foreach (DataRow fila in dt.Rows)
                    {
                        string articulo = fila["Articulo"].ToString();
                        string cantidad = fila["Cantidad"].ToString();


                        //// Asegurarte de que las actualizaciones del GridControl se hagan en el hilo principal
                        //this.Invoke(new Action(() =>
                        //{
                        AgregarärtidaExcelA(articulo, cantidad);
                        //    gcPartidas.EndUpdate();
                        //}));

                        contador++;
                    }
                    CalcularExcel();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible leer tu archivo excel");
                }
                finally
                {
                    SplashScreenManager.CloseForm(false);
                }

            }
        }

        private void gcPartidas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                GridView gridView = gcPartidas.MainView as GridView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    GridHitInfo hitInfo = gridView.CalcHitInfo(e.Location);

                    // Verificar si el clic fue sobre una celda (no en el encabezado de la columna)
                    if (hitInfo.InRowCell)
                    {
                        // Obtener el nombre de la columna donde se hizo doble clic
                        string columnName = hitInfo.Column.FieldName;

                        // Verificar si la columna clickeada es la que deseas, por ejemplo "s"
                        if (columnName == "sku")
                        {

                            // Obtener la fila seleccionada
                            int selectedRowHandle = gridView.FocusedRowHandle;

                            // Obtener los valores de las celdas en la fila seleccionada
                            var cellValue = gridView.GetRowCellValue(selectedRowHandle, gridView.Columns["sku"]).ToString();

                            if (cellValue == null || cellValue.Length <= 0)
                            {
                                return;
                            }
                            buscarArticulosAlternativos(cellValue);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnStat_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.BackColor == Color.Red)
                {
                    ToolTip info = new ToolTip
                    {
                        AutomaticDelay = 500,
                        InitialDelay = 300,
                        ReshowDelay = 100
                    };
                    info.SetToolTip(btnStat, mensaje);
                }
            }
        }

        private void lbAnexos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Obtener el índice del ítem seleccionado
                int selectedIndex = lbAnexos.SelectedIndex;

                // Verificamos que haya un ítem seleccionado
                if (selectedIndex >= 0)
                {
                    // Eliminamos el ítem seleccionado
                    lbAnexos.Items.RemoveAt(selectedIndex);
                    documento.anexos.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un ítem para eliminar.");
                }
            }
        }

        private void gcPartidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.popupMenuDocumentos.ShowPopup(Control.MousePosition);
            }
        }
    
    }

}
