using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using NetsuiteLibrary;
using NetsuiteLibrary.SuiteTalk_Helpers;
using NORI.Reportes;
using NoriCFDI;
using NoriSAPB1SDK;
using NoriSDK;

namespace NORI
{
    public partial class frmPrincipal : RibbonForm
    {
        private IContainer components = null;

        private DockPanel dockPanelMenuPrincipal;

        private ControlContainer dockPanel1_Container;

        private AccordionControl accordionControl1;

        private AccordionControlElement accordionControlElementInventario;

        private DockManager dockManager1;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private AccordionControlElement accordionControlElementArticulos;

        private TabbedView tabbedView1;

        private DocumentManager documentManager1;

        private AccordionControlElement accordionControlElement2;

        private AccordionControlElement accordionControlElement3;

        private AccordionControlElement accordionControlElement4;

        private AccordionControlElement accordionControlElementGestion;

        private AccordionControlElement accordionControlElementDefiniciones;

        private AccordionControlElement accordionControlElementFinanzas;

        private AccordionControlElement accordionControlElementMonedas;

        private BarButtonItem bbiSalir;

        private LabelControl lblEmpresa;

        private AccordionControlElement accordionControlElementUsuario;

        private AccordionControlElement accordionControlElementCerrarSesion;

        private AccordionControlElement accordionControlElementBloquear;

        private AccordionControlElement accordionControlElementGeneral;

        private AccordionControlElement accordionControlElementUsuarios;

        private AccordionControlElement accordionControlElementTipoCambio;

        private AccordionControlElement accordionControlElementVentas;

        private AccordionControlElement accordionControlElementCotizaciones;

        private AccordionControlElement accordionControlElementPedidos;

        private AccordionControlElement accordionControlElementFacturas;

        private AccordionControlElement accordionControlElementDevoluciones;

        private AccordionControlElement accordionControlElementSocios;

        private AccordionControlElement accordionControlElementGestionInventario;

        private AccordionControlElement accordionControlElementGruposArticulos;

        private AccordionControlElement accordionControlElementAlmacenes;

        private AccordionControlElement accordionControlElementInventarioListasPrecios;

        private AccordionControlElement accordionControlElementListasPrecios;

        private AccordionControlElement accordionControlElementFabricantes;

        private AccordionControlElement accordionControlElementDepartamentos;

        private AccordionControlElement accordionControlElementVendedores;

        private BarHeaderItem barHeaderItemEstacion;

        private AccordionControlElement accordionControlElementEstaciones;

        private AccordionControlElement accordionControlElementZonas;

        private AccordionControlElement accordionControlElementGestionSociosNegocios;

        private AccordionControlElement accordionControlElementGruposSocios;

        private AccordionControlElement accordionControlElementCondicionesPago;

        private AccordionControlElement accordionControlElementConfiguracion;

        private AccordionControlElement accordionControlElementEmpresa;

        private AccordionControlElement accordionControlElementImpuestos;

        private AccordionControlElement accordionControlElementPaises;

        private AccordionControlElement accordionControlElementEstados;

        private AccordionControlElement accordionControlElementMetodosPago;

        private BarButtonItem bbiEventosControles;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private BarButtonItem bbiDiseñadorInformes;

        private BarButtonItem bbiConsultasPersonalizadas;

        private AccordionControlElement accordionControlElementTiposMetodosPagos;

        private BarButtonItem bbiSincronizacion;

        private AccordionControlElement accordionControlElementSeries;

        private BackgroundWorker bwAutorizaciones;

        private Timer timerAutorizaciones;

        private AccordionControlElement accordionControlElementNotasCredito;

        private AccordionControlElement accordionControlElementNotasDebito;

        private AccordionControlElement accordionControlElementGestionInformes;

        private AccordionControlElement accordionControlElementInformes;

        private AccordionControlElement accordionControKioscoFacturacion;

        private AccordionControlElement accordionControlElement1;

        private BarButtonItem bbiEntradasAbiertas;

        private BarEditItem barEditItemAutorizaciones;

        private RepositoryItemToggleSwitch repositoryItemToggleSwitch1;

        private BarButtonItem bbiEtiquetas;

        private AccordionControlElement accordionControlElementRestaurante;

        private AccordionControlElement accordionControlElementRestauranteMesas;

        private AccordionControlElement accordionControlElementCompras;

        private AccordionControlElement accordionControlElementEntradasMercancias;

        private AccordionControlElement accordionControlElementExtras;

        private AccordionControlElement accordionControlElementPagos;

        private AccordionControlElement accordionControlElementOrdenCompra;

        private AccordionControlElement accordionControlElementEntregaMercancia;

        private BarButtonItem bbiTransmitirRecibir;

        private AccordionControlElement accordionControlElementOperacionesStock;

        private AccordionControlElement accordionControlElementSolicitudTraslado;

        private AccordionControlElement accordionControlElementTransferenciaStock;

        private AccordionControlElement accordionControlElementCotizacionCompra;

        private BarButtonItem bbiDiseñadorEscritorios;

        private AccordionControlElement accordionControlElementDevolucionMercancias;

        private AccordionControlElement accordionControlElementCierreDia;

        private AccordionControlElement accordionControlElementAjusteEntrada;

        private AccordionControlElement accordionControlElementAjusteSalida;

        private BarListItem bbiSucursales;

        private AccordionControlElement accordionControlElementAnticiposClientes;

        private AccordionControlElement accordionControlElementActivosFijos;

        private AccordionControlElement accordionControlElementInventarioFisico;

        private AccordionControlElement accordionControlElementEntradaMercancias;

        private AccordionControlElement accordionControlElementListaPedidosWeb;

        public frmPrincipal()
        {
            //IL_05a7: Unknown result type (might be due to invalid IL or missing references)
            //IL_05ae: Expected O, but got Unknown
            //IL_0629: Unknown result type (might be due to invalid IL or missing references)
            //IL_0630: Expected O, but got Unknown
            InitializeComponent();
            this.MetodoDinamico();
            barEditItemAutorizaciones.EditValue = Program.Nori.UsuarioAutenticado.suscribir_autorizaciones;
            ((AccordionControlElementBase)accordionControlElementUsuario).Text = Program.Nori.UsuarioAutenticado.nombre;
            ((BarItem)barHeaderItemEstacion).Caption = Program.Nori.Estacion.nombre + " | Conectado a: " + Program.Nori.Conexion.DataSource;
            ((Control)(object)this).Text = "DTM Solutions";//Program.Nori.Empresa.nombre_fiscal;
            ((Control)(object)lblEmpresa).Text = Program.Nori.Empresa.nombre_comercial;
            if (Program.Nori.Empresa.prueba)
            {
                ((Control)(object)this).Text += " - MODO DE PRUEBA";
                ((Control)(object)lblEmpresa).Text += " - MODO DE PRUEBA";
                Program.Nori.Configuracion.timbrado_modo_prueba = true;
            }
            if (Program.Nori.UsuarioAutenticado.usuario == "admin")
            {
                ((AccordionControlElementBase)accordionControlElementRestaurante).Visible = true;
            }
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'C':
                    ((AccordionControlElementBase)accordionControlElementGestion).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementGestionInventario).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementInventario).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementCompras).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementCotizaciones).Visible = false;
                    //((AccordionControlElementBase)accordionControlElementEntregas).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementPedidos).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementFacturas).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementDevoluciones).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementNotasCredito).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementNotasDebito).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementSocios).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementExtras).Visible = false;
                    ribbonPageHerramientas.Visible = false;
                    break;
                case 'V':
                    ((AccordionControlElementBase)accordionControlElementGestion).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementInventarioListasPrecios).Visible = false;
                    ribbonPageGroupHerramientas.Visible = false;
                    ((AccordionControlElementBase)accordionControlElementCompras).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementExtras).Visible = false;
                    if (Program.Nori.UsuarioAutenticado.VendedorForaneo())
                    {
                        //((AccordionControlElementBase)accordionControlElementEntregas).Visible = false;
                        ((AccordionControlElementBase)accordionControlElementEntregaMercancia).Visible = false;
                        ((AccordionControlElementBase)accordionControlElementFacturas).Visible = false;
                        ((AccordionControlElementBase)accordionControlElementDevoluciones).Visible = false;
                        ((AccordionControlElementBase)accordionControlElementNotasCredito).Visible = false;
                        ((AccordionControlElementBase)accordionControlElementNotasDebito).Visible = false;
                        //((AccordionControlElementBase)accordionControlElementPuntoVenta).Visible = false;
                    }
                    break;
                case 'L':
                    ((AccordionControlElementBase)accordionControlElementGestion).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementInventarioListasPrecios).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementPagos).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementMonedas).Visible = false;
                    ribbonPageGroupHerramientas.Visible = false;
                    ((AccordionControlElementBase)accordionControlElementCompras).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementExtras).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementFacturas).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementNotasCredito).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementNotasDebito).Visible = false;
                   // ((AccordionControlElementBase)accordionControlElementPuntoVenta).Visible = false;
                    break;
                case 'S':
                    ((AccordionControlElementBase)accordionControlElementGestionInventario).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementInventarioListasPrecios).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementGeneral).Visible = false;
                    ((AccordionControlElementBase)accordionControlElementMonedas).Visible = false;
                    ribbonPageGroupHerramientas.Visible = false;
                    ((AccordionControlElementBase)accordionControlElementExtras).Visible = false;
                    break;
            }
            if (Program.Nori.Empresa.rfc == "DDI061212TX1")
            {
                ((AccordionControlElementBase)accordionControlElementCompras).Visible = false;
            }
            try
            {
                List<Informe> source = (from x in Informe.Informes()
                                        where x.activo == true && (x.tipo == "US" || x.tipo == "SI")
                                        orderby x.nombre
                                        select x).ToList();
                foreach (Informe.Tipo tipo in from x in Informe.Tipo.Tipos()
                                              where x.tipo == "US" || x.tipo == "SI"
                                              select x)
                {
                    if (!Program.Nori.UsuarioAutenticado.rol.Equals('A') && tipo.tipo == "SI")
                    {
                        continue;
                    }
                    AccordionControlElement val = new AccordionControlElement();
                    val.Style = (ElementStyle)0;
                    ((AccordionControlElementBase)val).Text = tipo.nombre;
                    ((Collection<AccordionControlElement>)(object)accordionControlElementInformes.Elements).Add(val);
                    foreach (Informe informe in source.Where((Informe x) => x.tipo == tipo.tipo))
                    {
                        AccordionControlElement val2 = new AccordionControlElement();
                        val2.Style = (ElementStyle)1;
                        ((AccordionControlElementBase)val2).Name = informe.informe;
                        ((AccordionControlElementBase)val2).Text = informe.nombre;
                        ((AccordionControlElementBase)val2).Click += delegate
                        {
                            Funciones.PrevisualizarInforme(informe.informe);
                        };
                        ((Collection<AccordionControlElement>)(object)val.Elements).Add(val2);
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Sucursal item in (from x in Sucursal.Sucursales()
                                           where x.activo == true
                                           select x).ToList())
                {
                    bbiSucursales.Strings.Add(item.codigo);
                    Program.sucursales.Add(item);
                }
            }
            catch
            {
            }
            CargarAsync();
        }

        private async void CargarModuloFacturacion()
        {
            try
            {
                Program.CFDI = await Task.Run(() => new CFDI());
                if (Program.Nori.Configuracion.certificado_id == 0)
                {
                    return;
                }
                Certificado certificado = Certificado.Obtener(Program.Nori.Configuracion.certificado_id);
                if (certificado.id != 0)
                {
                    if (File.Exists(certificado.cer) && File.Exists(certificado.key))
                    {
                        Program.CFDI.certificado.cer = certificado.cer;
                        Program.CFDI.certificado.key = certificado.key;
                        Program.CFDI.certificado.contraseña = certificado.contraseña;
                        Program.CFDI.certificado.pfx = certificado.pfx;
                        Program.CFDI.certificado.contraseña_pfx = certificado.contraseña_pfx;
                        if (!(await Task.Run(() => Program.CFDI.Inicializar())))
                        {
                            MessageBox.Show("Imposible cargar el módulo de facturación electrónica.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron cargar los archivos del certificado.");
                    }
                }
                Program.CFDI.usuario = Program.Nori.Configuracion.timbrado_usuario;
                Program.CFDI.contraseña = Program.Nori.Configuracion.timbrado_contraseña;
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private async void CargarAsync()
        {
            try
            {
                Control ctrl = (Control)(object)this;
                this.Controls.Add(pictureBox1);
                pictureBox1.BringToFront();
                //ctrl.SetImage(await Funciones.CargarImagen(Program.Nori.Empresa.logotipo));
                if (Program.Nori.Configuracion.sap)
                {
                    Program.NoriSAP = new NoriSAPSQL(Configuracion.SAP.Obtener());
                }
                CargarModuloFacturacion();
                if (Program.Nori.Estacion.bascula && Program.Nori.Estacion.bascula_id != 0 && Program.Nori.Estacion.ObtenerBascula() && !Program.Nori.Estacion.Bascula.Inicializar())
                {
                    Program.Nori.Estacion.Bascula = null;
                    MessageBox.Show("Error al inicializar la báscula: " + NoriSDK.Nori.ObtenerUltimoError());
                }
                Funciones.NoriDynamic();
                if (Program.Nori.UsuarioAutenticado.escritorio.Length > 0)
                {
                    frmEscritorio escritorio = new frmEscritorio(Program.Nori.UsuarioAutenticado.escritorio);
                    AbrirFormulario((Form)(object)escritorio, dialog: false);
                }
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void accordionControlElementCerrarSesion_Click(object sender, EventArgs e)
        {
            Funciones.CerrarSesion();
        }

        private void accordionControlElementGruposArticulos_Click(object sender, EventArgs e)
        {
            frmGruposArticulos form = new frmGruposArticulos();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes form = new frmAlmacenes();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios form = new frmUsuarios();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos form = new frmArticulos();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementBloquear_Click(object sender, EventArgs e)
        {
            Funciones.cred = true;
            Funciones.Desbloquear();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Nori.UsuarioAutenticado.Desconectar();
        }

        private void accordionControlElementMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas form = new frmMonedas();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementListasPrecios_Click(object sender, EventArgs e)
        {
            frmListasPrecios form = new frmListasPrecios();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementFabricantes_Click(object sender, EventArgs e)
        {
            frmFabricantes form = new frmFabricantes();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementDepartamentos_Click(object sender, EventArgs e)
        {
            frmDepartamentos form = new frmDepartamentos();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementEstaciones_Click(object sender, EventArgs e)
        {
            frmEstaciones form = new frmEstaciones();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementVendedores_Click(object sender, EventArgs e)
        {
            frmVendedores form = new frmVendedores();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementZonas_Click(object sender, EventArgs e)
        {
            frmZonas form = new frmZonas();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementTipoCambio_Click(object sender, EventArgs e)
        {
            frmTiposCambio form = new frmTiposCambio();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementGruposSocios_Click(object sender, EventArgs e)
        {
            frmGruposSocios form = new frmGruposSocios();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementSocios_Click(object sender, EventArgs e)
        {
            frmSocios form = new frmSocios();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementCondicionesPago_Click(object sender, EventArgs e)
        {
            frmCondicionesPago form = new frmCondicionesPago();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion form = new frmConfiguracion();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementPuntoVenta_Click(object sender, EventArgs e)
        {
            PuntoVenta.frmPuntoVenta frmPuntoVenta = new PuntoVenta.frmPuntoVenta();
            if (Program.Nori.UsuarioAutenticado.rol == 'A')
            {
                ((Form)(object)frmPuntoVenta).MaximizeBox = true;
                ((Form)(object)frmPuntoVenta).MinimizeBox = true;
                ((Form)(object)frmPuntoVenta).ControlBox = true;
                ((Form)(object)frmPuntoVenta).FormBorderStyle = FormBorderStyle.Sizable;
                ((Control)(object)frmPuntoVenta).Show();
            }
            else
            {
                ((Form)(object)frmPuntoVenta).FormBorderStyle = FormBorderStyle.None;
                ((Form)(object)frmPuntoVenta).ShowDialog();
            }
        }

        private void accordionControlElementEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementPaises_Click(object sender, EventArgs e)
        {
            frmPaises form = new frmPaises();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementEstados_Click(object sender, EventArgs e)
        {
            frmEstados form = new frmEstados();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementImpuestos_Click(object sender, EventArgs e)
        {
            frmImpuestos form = new frmImpuestos();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControlElementMetodosPago_Click(object sender, EventArgs e)
        {
            frmMetodosPago form = new frmMetodosPago();
            AbrirFormulario((Form)(object)form);
        }

        private void bbiEventosControles_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEventosControles form = new frmEventosControles();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void bbiDiseñadorInformes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDiseñadorInformes frmDiseñadorInformes2 = new frmDiseñadorInformes();
            ((Control)(object)frmDiseñadorInformes2).Show();
        }

        private void ribbonControl1_ApplicationButtonClick(object sender, EventArgs e)
        {
            Funciones.CerrarSesion();
        }

        private void dockManager1_ClosingPanel(object sender, DockPanelCancelEventArgs e)
        {
            dockManager1.RemovePanel(((DockPanelEventArgs)e).Panel);
        }

        private void AbrirFormulario(Form form, bool dialog = true)
        {
            bool flag = Program.Nori.Configuracion.formulario_panel;
            if (form.Name.Equals("frmEscritorio"))
            {
                flag = true;
            }
            if (flag)
            {
                Size size = default(Size);
                size = form.Size;
                size.Width += 50;
                size.Height += 50;
                form.TopLevel = false;
                form.Visible = true;
                form.ControlBox = false;
                form.ShowInTaskbar = false;
                form.FormBorderStyle = FormBorderStyle.None;
                DockPanel val = dockManager1.AddPanel((DockingStyle)0);
                (((Control)(object)val).Parent as Form).StartPosition = FormStartPosition.CenterScreen;
                ((Control)(object)val).Controls.Add(form);
                ((Control)(object)val).Text = form.Text;
                val.FloatSize = size;
                val.Size = size;
                if (!dialog)
                {
                    val.DockedAsTabbedDocument = true;
                }
                form.Dock = DockStyle.Fill;
            }
            if (!dialog)
            {
                pictureBox1.Visible = false;
                form.Show();
            }
            else if (!flag)
            {
                form.ShowDialog();
            }
        }

        private void bbiConsultasPersonalizadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConsultasPersonalizadas form = new frmConsultasPersonalizadas();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementTiposMetodosPagos_Click(object sender, EventArgs e)
        {
            frmTiposMetodosPago form = new frmTiposMetodosPago();
            AbrirFormulario((Form)(object)form);
        }

        private void bbiSincronizacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.Nori.UsuarioAutenticado.rol == 'A' && Program.Nori.Configuracion.sap)
            {
                timerAutorizaciones.Enabled = false;
                frmSincronizacion frmSincronizacion2 = new frmSincronizacion();
                ((Control)(object)frmSincronizacion2).Show();
            }
            else if (Program.Nori.UsuarioAutenticado.rol == 'A' && Program.Nori.Configuracion.netsuite)
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando...");
                NetsuiteLibrary.Sincronizacion sincronizacion = new NetsuiteLibrary.Sincronizacion();
                sincronizacion.configuracion = Program.Nori.Configuracion;
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando documentos ↑...");
                List<int> list = (from x in Documento.Documentos()
                                  where x.identificador_externo == 0 && x.cancelado == false && (x.clase == "PE" || x.clase == "FA")
                                  select x.id).ToList();
                foreach (int item in list)
                {
                    try
                    {
                        Documento documento = Documento.Obtener(item);
                        SplashScreenManager.Default.SetWaitFormDescription($"Sincronizando documentos ↑ {documento.clase}-{documento.id}");
                        if (documento.clase.Equals("PE"))
                        {
                            SalesOrderHelper salesOrderHelper = new SalesOrderHelper();
                            salesOrderHelper.CreateSalesOrder(documento);
                        }
                        else if (documento.clase.Equals("FA"))
                        {
                            InvoiceHelper invoiceHelper = new InvoiceHelper();
                            if (invoiceHelper.CreateInvoice(documento) && documento.importe_aplicado >= documento.total)
                            {
                                MetodoPago.Tipo tipo = MetodoPago.Tipo.Obtener(documento.flujo.First().tipo_metodo_pago_id);
                                invoiceHelper.TransformToCustomerPayment(documento.identificador_externo.ToString(), tipo.cuenta_contable);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando articulos ↓...");
                sincronizacion.Articulos();
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando socios ↓...");
                sincronizacion.Socios();
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando articulos ↓...");
                sincronizacion.Articulos();
                Funciones.DescartarCargando();
                SplashScreenManager.CloseForm(false);
            }
            else
            {
                MessageBox.Show("Solo los adminstradores pueden iniciar la sincronización.");
            }
        }

        private void accordionControlElementSeries_Click(object sender, EventArgs e)
        {
            frmSeries form = new frmSeries();
            AbrirFormulario((Form)(object)form);
        }

        private async void timerAutorizaciones_Tick(object sender, EventArgs e)
        {
            try
            {
                Autorizacion autorizacion = await Task.Run(() => Autorizacion.ObtenerAutorizacionPendiente());
                if (autorizacion.id != 0)
                {
                    timerAutorizaciones.Stop();
                    frmAutorizacion f = new frmAutorizacion(autorizacion);
                    ((Form)(object)f).ShowDialog();
                    timerAutorizaciones.Start();
                }
                Application.DoEvents();
            }
            catch
            {
            }
        }

        private void accordionControlElementCotizaciones_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("CO");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementPedidos_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("PE");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementEntregas_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("EN");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementFacturas_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("FA");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementDevoluciones_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("DV");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementNotasCredito_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("NC");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementNotasDebito_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("ND");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementInformes_Click(object sender, EventArgs e)
        {
            frmInformes form = new frmInformes();
            AbrirFormulario((Form)(object)form);
        }

        private void accordionControKioscoFacturacion_Click(object sender, EventArgs e)
        {
            Kiosco.frmKiosco frmKiosco = new Kiosco.frmKiosco();
            ((Form)(object)frmKiosco).ShowDialog();
        }

        private void bbiEntradasAbiertas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.Nori.UsuarioAutenticado.rol.Equals('A'))
            {
                Funciones.FacturarEntregas();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.CerrarSesion();
        }

        private void barEditItemAutorizaciones_EditValueChanged(object sender, EventArgs e)
        {
            if ((bool)barEditItemAutorizaciones.EditValue)
            {
                timerAutorizaciones.Start();
            }
            else
            {
                timerAutorizaciones.Stop();
            }
        }

        private void bbiEtiquetas_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEtiquetas frmEtiquetas2 = new frmEtiquetas();
            ((Control)(object)frmEtiquetas2).Show();
        }

        private void accordionControlElementRestauranteMesas_Click(object sender, EventArgs e)
        {
            Restaurante.frmRestaurante frmRestaurante = new Restaurante.frmRestaurante();
            ((Control)(object)frmRestaurante).Show();
        }

        private void accordionControlElementEntradasMercancias_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("EM");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementPagos_Click(object sender, EventArgs e)
        {
            frmPagos form = new frmPagos();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementOrdenCompra_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("OC");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementEntregaMercancia_Click(object sender, EventArgs e)
        {
            frmEntregaMercancia form = new frmEntregaMercancia();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void bbiTransmitirRecibir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.Nori.UsuarioAutenticado.VendedorForaneo())
            {
                ((BarItem)bbiTransmitirRecibir).Enabled = false;
                Funciones.TransmitirRecibir();
                ((BarItem)bbiTransmitirRecibir).Enabled = true;
            }
            else
            {
                MessageBox.Show("Este usuario no esta enlazado a un vendedor foraneo.");
            }
        }

        private void accordionControlElementSolicitudTraslado_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("ST");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementTransferenciaStock_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("TS");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementCotizacionCompra_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("CC");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void bbiDiseñadorEscritorios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDiseñadorEscritorios frmDiseñadorEscritorios2 = new frmDiseñadorEscritorios();
            ((Control)(object)frmDiseñadorEscritorios2).Show();
        }

        private void accordionControlElementDevolucionMercancias_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("DM");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementCierreDia_Click(object sender, EventArgs e)
        {
            frmCierreDia frmCierreDia2 = new frmCierreDia();
            ((Form)(object)frmCierreDia2).ShowDialog();
        }

        private void accordionControlElementAjusteEntrada_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("AE");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementAjusteSalida_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("AS");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void bbiSucursales_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            try
            {
                if (Funciones.ConectarSucursal(bbiSucursales.Strings[e.Index]))
                {
                    ((BarItem)barHeaderItemEstacion).Caption = Program.Nori.Estacion.nombre + " | Conectado a: " + Program.Nori.Conexion.DataSource + " (" + bbiSucursales.Strings[e.Index] + ")";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void frmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    ((Control)(object)new frmDocumentos("CO")).Show();
                }
                if (e.KeyCode == Keys.F2)
                {
                    ((Control)(object)new frmDocumentos("PE")).Show();
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
                if (e.KeyCode == Keys.F7)
                {
                    ((Control)(object)new frmDocumentos("TS")).Show();
                }
                if (e.KeyCode == Keys.F8)
                {
                    ((Control)(object)new frmDocumentos("AE")).Show();
                }
            }
            catch
            {
            }
        }

        private void accordionControlElementAnticiposClientes_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("AC");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementActivosFijos_Click(object sender, EventArgs e)
        {
            frmActivosFijos form = new frmActivosFijos();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementInventarioFisico_Click(object sender, EventArgs e)
        {
            frmDocumentos form = new frmDocumentos("IF");
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementListaPartidas_Click(object sender, EventArgs e)
        {
            frmListaPartidas frmListaPartidas2 = new frmListaPartidas();
            ((Control)(object)frmListaPartidas2).Show();
        }

        private void accordionControlElementEntradaMercancias_Click(object sender, EventArgs e)
        {
            frmEntradaMercancia form = new frmEntradaMercancia();
            AbrirFormulario((Form)(object)form, dialog: false);
        }

        private void accordionControlElementListaPedidosWeb_Click(object sender, EventArgs e)
        {
            frmListaPedidosWeb frmListaPedidosWeb2 = new frmListaPedidosWeb();
            ((Control)(object)frmListaPedidosWeb2).Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            
            frmrepCorteCaja frmrepCorteCaja = new frmrepCorteCaja();
            ((Control)(object)frmrepCorteCaja).Show();
        }

        private void accFacturasDiarias_Click(object sender, EventArgs e)
        {
            frmrepFacturasDiarias frmrepFacturasDiarias = new frmrepFacturasDiarias();
            ((Control)(object)frmrepFacturasDiarias).Show();
        }

        private void accPagosCredito_Click(object sender, EventArgs e)
        {
            frmrepPagosCredito frmrepPagosCredito = new frmrepPagosCredito();
            ((Control)(object)frmrepPagosCredito).Show();
        }

        private void accNC_Click(object sender, EventArgs e)
        {
            frmrepNC frmrepNC= new frmrepNC();
            ((Control)(object)frmrepNC).Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            frmrepFacCanceladas frmrepFacCanceladas= new frmrepFacCanceladas();
            ((Control)(object)frmrepFacCanceladas).Show();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            frmrepPartidasAbiertas frmrepPartidasAbiertas= new frmrepPartidasAbiertas();
            ((Control)(object)frmrepPartidasAbiertas).Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            frmrepPagoComision frmrepPagoComision = new frmrepPagoComision();
            ((Control)(object)frmrepPagoComision).Show();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            frmrepVentas frmrepVentas= new frmrepVentas();
            ((Control)(object)frmrepVentas).Show();
        }

        private void accMonitor_Click(object sender, EventArgs e)
        {
            frmMonitorElectronico frmMonitorElectronico = new frmMonitorElectronico();
            ((Control)(object)frmMonitorElectronico).Show();
        }
    }
}
