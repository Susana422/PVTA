using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NetsuiteLibrary;
using NoriSDK;

namespace NORI
{
    public partial class frmConfiguracion : RibbonForm
    {
        private Configuracion configuracion = Configuracion.Obtener();

        private Configuracion.SAP sap = Configuracion.SAP.Obtener();

        private Configuracion.NetSuite netsuite = Configuracion.NetSuite.Obtener();

        private IContainer components = null;

        private DataLayoutControl dataLayoutControl1;

        private RibbonControl mainRibbonControl;

        private BackstageViewControl backstageViewControl1;

        private BarButtonItem bbiGuardar;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private TabPane tabPane1;

        private TabNavigationPage tabNavigationPageGeneral;

        private TabNavigationPage tabNavigationPageDirectorios;

        private TabNavigationPage tabNavigationPageSAP;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private TextEdit txtDirectorioHuellas;

        private LabelControl lblDirectorioHuellas;

        private TextEdit txtDirectorioXML;

        private LabelControl lblDirectorioXML;

        private TextEdit txtDirectorioImagenes;

        private LabelControl lblDirectorioImagenes;

        private TextEdit txtDirectorioDocumentos;

        private LabelControl lblDirectorioDocumentos;

        private CheckEdit cbSAP;

        private LabelControl lblSAP;

        private GroupBox gbSAP;

        private TextEdit txtServidor;

        private LabelControl lblServidor;

        private LabelControl lblTipoServidorBD;

        private ComboBoxEdit cbTipoServidorBD;

        private TextEdit txtBD;

        private LabelControl lblBD;

        private TextEdit txtContraseñaBD;

        private LabelControl lblContraseñaBD;

        private TextEdit txtServidorLicencias;

        private LabelControl lblServidorLicencias;

        private TextEdit txtContraseña;

        private LabelControl lblContraseña;

        private TextEdit txtUsuario;

        private LabelControl lblUsuario;

        private CheckEdit cbConfiable;

        private TextEdit txtUsuarioBD;

        private LabelControl lblUsuarioBD;

        private TabNavigationPage tabNavigationPagePredeterminados;

        private HyperlinkLabelControl lblFabricantes;

        private LookUpEdit cbFabricantes;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private LookUpEdit cbListasPrecios;

        private HyperlinkLabelControl lblListaPrecios;

        private LookUpEdit cbGruposArticulos;

        private HyperlinkLabelControl lblGrupoArticulos;

        private LookUpEdit cbMetodosPago;

        private HyperlinkLabelControl lblMetodoPago;

        private LookUpEdit cbCondicionesPago;

        private HyperlinkLabelControl lblCondicionesPago;

        private LookUpEdit cbZonas;

        private HyperlinkLabelControl lblZonas;

        private LookUpEdit cbDepartamentos;

        private HyperlinkLabelControl lblDepartamentos;

        private LookUpEdit cbImpuestos;

        private HyperlinkLabelControl lblImpuesto;

        private CheckEdit cbFormularioPanel;

        private CheckEdit cbVentaArticuloPrecioCero;

        private TextEdit txtDirectorioInformes;

        private LabelControl lblDirectorioInformes;

        private LabelControl labelControl1;

        private LookUpEdit cbTiposMetodosPago;

        private LabelControl lblHoraSicronizacionGeneral;

        private TimeEdit teHoraSincronizacionGenerales;

        private CheckEdit cbGenerarDocumentoElectronicoAutomaticamente;

        private TabNavigationPage tabNavigationPageTimbrado;

        private SimpleButton btnCertificados;

        private CheckEdit cbTimbradoModoPrueba;

        private TextEdit txtTimbradoContraseña;

        private TextEdit txtTimbradoUsuario;

        private LookUpEdit cbCertificados;

        private HyperlinkLabelControl lblCertificado;

        private LabelControl lblTimbradoContraseña;

        private LabelControl lblTimbradoUsuario;

        private HyperlinkLabelControl lblSucursales;

        private GroupControl gcOpciones;

        private CheckEdit cbGenerarAjusteInventario;

        private TextEdit txtNumeroCuentaAjusteInventario;

        private TextEdit txtAPIURL;

        private LabelControl lblAPIURL;

        private TextEdit txtSAPAPIURL;

        private LabelControl lblSAPAPIURL;

        private ColorEdit ceTema;

        private LabelControl lblTema;

        private CheckEdit cbDocumentoBorrador;

        private CheckEdit cbFacturarEntregas;

        private CheckEdit cbVentaArticuloStockCero;

        private CheckEdit cbAgruparPartidas;

        private CheckEdit cbVendedorSegunUsuario;

        private CheckEdit cbInventarioSAP;

        private ComboBoxEdit cbPAC;

        private LabelControl lblPAC;

        private CheckEdit cbDocumentosModoNuevo;

        private CheckEdit cbVendedorSegunEstacion;

        private TextEdit txtDirectorioAnexos;

        private LabelControl lblDirectorioAnexos;

        private CheckEdit cbVentaArticuloMenorCosto;

        private Label lblDiaSemana;

        private ComboBoxEdit cbDiasSemana;

        private CheckEdit cbListaPrecioSegunUsuario;

        private CheckEdit cbPedimentos;

        private CheckEdit cbSeleccionarSucursal;

        private CheckEdit cbFacturaSinEntregas;

        private CheckEdit cbGenerarTimbradoSinDescuento;

        private LabelControl lblFuenteDatos;

        private TextEdit txtFuenteDatos;

        private TabNavigationPage tabNavigationPageNetSuite;

        private CheckEdit cbNetSuite;

        private GroupBox gbNetSuite;

        private LabelControl labelControl2;

        private TextEdit txtNetSuiteClienteLlave;

        private LabelControl labelControl5;

        private TextEdit txtNetSuiteTokenSecreto;

        private LabelControl labelControl7;

        private TextEdit txtNetSuiteClienteSecreto;

        private LabelControl labelControl8;

        private TextEdit txtNetSuiteTokenId;

        private LabelControl labelControl9;

        private LabelControl labelControl10;

        private TextEdit txtNetSuiteCuentaId;

        private LabelControl labelControl12;

        private LabelControl labelControl13;

        private TabNavigationPage tabNavigationPageWeb;

        private TextEdit txtNetSuiteApiURL;

        private LabelControl labelControl3;

        private SimpleButton btnProbarConexion;

        public frmConfiguracion()
        {
            InitializeComponent();
            this.MetodoDinamico();
            Cargar();
            CargarListas();
        }

        private void Cargar()
        {
            if (configuracion.netsuite)
            {
                ((NavigationPageBase)tabNavigationPageSAP).PageVisible = false;
            }
            else if (configuracion.sap)
            {
                ((NavigationPageBase)tabNavigationPageNetSuite).PageVisible = false;
            }
            cbFormularioPanel.Checked = configuracion.formulario_panel;
            cbVentaArticuloPrecioCero.Checked = configuracion.venta_articulo_precio_cero;
            cbVentaArticuloMenorCosto.Checked = configuracion.venta_precio_menor_costo;
            cbVentaArticuloStockCero.Checked = configuracion.venta_articulo_stock_cero;
            cbDocumentoBorrador.Checked = configuracion.documento_borrador;
            cbAgruparPartidas.Checked = configuracion.agrupar_partidas;
            cbVendedorSegunUsuario.Checked = configuracion.vendedor_segun_usuario;
            cbListaPrecioSegunUsuario.Checked = configuracion.lista_precio_segun_usuario;
            cbGenerarDocumentoElectronicoAutomaticamente.Checked = configuracion.generar_documento_electronico_automaticamente;
            cbFacturaSinEntregas.Checked = configuracion.factura_sin_entregas;
            cbVendedorSegunEstacion.Checked = configuracion.vendedor_segun_estacion;
            cbDocumentosModoNuevo.Checked = configuracion.documentos_modo_nuevo;
            cbSeleccionarSucursal.Checked = configuracion.seleccionar_sucursal;
            ((BaseEdit)cbTiposMetodosPago).EditValue = configuracion.tipo_metodo_pago_monedero_id;
            ((Control)(object)txtAPIURL).Text = configuracion.api_url;
            try
            {
                ceTema.Color = Color.FromArgb(Convert.ToInt32(configuracion.tema));
            }
            catch
            {
            }
            cbPAC.SelectedIndex = configuracion.pac;
            ((BaseEdit)txtTimbradoUsuario).EditValue = configuracion.timbrado_usuario;
            ((BaseEdit)txtTimbradoContraseña).EditValue = configuracion.timbrado_contraseña;
            cbTimbradoModoPrueba.Checked = configuracion.timbrado_modo_prueba;
            cbPedimentos.Checked = configuracion.pedimentos;
            cbGenerarTimbradoSinDescuento.Checked = configuracion.generar_timbrado_sin_descuento;
            ((Control)(object)txtDirectorioInformes).Text = configuracion.directorio_informes;
            ((Control)(object)txtDirectorioDocumentos).Text = configuracion.directorio_documentos;
            ((Control)(object)txtDirectorioImagenes).Text = configuracion.directorio_imagenes;
            ((Control)(object)txtDirectorioXML).Text = configuracion.directorio_xml;
            ((Control)(object)txtDirectorioHuellas).Text = configuracion.directorio_huellas;
            ((Control)(object)txtDirectorioAnexos).Text = configuracion.directorio_anexos;
            cbDiasSemana.SelectedIndex = configuracion.dia_semana;
            GroupBox groupBox = gbSAP;
            bool visible = (cbSAP.Checked = configuracion.sap);
            groupBox.Visible = visible;
            ((Control)(object)cbSAP).Enabled = !cbSAP.Checked;
            cbInventarioSAP.Checked = configuracion.inventario_sap;
            ((Control)(object)txtServidor).Text = sap.servidor;
            ((Control)(object)txtFuenteDatos).Text = sap.fuente_datos;
            ((Control)(object)txtServidorLicencias).Text = sap.servidor_licencias;
            cbTipoServidorBD.SelectedIndex = sap.tipo_servidor_bd - 1;
            ((Control)(object)txtBD).Text = sap.bd;
            ((Control)(object)txtUsuarioBD).Text = sap.usuario_bd;
            ((Control)(object)txtContraseñaBD).Text = sap.contraseña_bd;
            ((Control)(object)txtUsuario).Text = sap.usuario;
            ((Control)(object)txtContraseña).Text = sap.contraseña;
            cbConfiable.Checked = sap.confiable;
            cbGenerarAjusteInventario.Checked = sap.generar_ajuste_inventario;
            ((Control)(object)txtNumeroCuentaAjusteInventario).Text = sap.numero_cuenta_ajuste_inventario;
            cbFacturarEntregas.Checked = sap.facturar_entregas;
            ((Control)(object)txtSAPAPIURL).Text = sap.api_url;
            GroupBox groupBox2 = gbNetSuite;
            visible = (cbNetSuite.Checked = configuracion.netsuite);
            groupBox2.Visible = visible;
            ((Control)(object)cbNetSuite).Enabled = !cbNetSuite.Checked;
            ((Control)(object)txtNetSuiteCuentaId).Text = netsuite.cuenta_id;
            ((Control)(object)txtNetSuiteClienteLlave).Text = netsuite.cliente_llave;
            ((Control)(object)txtNetSuiteClienteSecreto).Text = netsuite.cliente_secreto;
            ((Control)(object)txtNetSuiteTokenId).Text = netsuite.token_id;
            ((Control)(object)txtNetSuiteTokenSecreto).Text = netsuite.token_secreto;
            ((Control)(object)txtNetSuiteApiURL).Text = netsuite.api_url;
            teHoraSincronizacionGenerales.Time = new DateTime(sap.hora_sincronizacion_general.Ticks);
        }

        private void CargarListas()
        {
            object parametros = new
            {
                fields = "id, codigo, nombre"
            };
            object objeto = new
            {
                activo = 1
            };
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DataSource = Utilidades.Busqueda("condiciones_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbCondicionesPago).EditValue = configuracion.condicion_pago_id;
            ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).DataSource = Utilidades.Busqueda("fabricantes", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbFabricantes.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbFabricantes).EditValue = configuracion.fabricante_id;
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DataSource = Utilidades.Busqueda("metodos_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbMetodosPago).EditValue = configuracion.metodo_pago_id;
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DataSource = Utilidades.Busqueda("grupos_articulos", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbGruposArticulos.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbGruposArticulos).EditValue = configuracion.grupo_articulo_id;
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).DataSource = Utilidades.Busqueda("impuestos", null, parametros);
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbImpuestos).EditValue = configuracion.impuesto_id;
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DataSource = Utilidades.Busqueda("monedas", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbMonedas).EditValue = configuracion.moneda_id;
            ((RepositoryItemLookUpEditBase)cbZonas.Properties).DataSource = Utilidades.Busqueda("zonas", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbZonas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbZonas.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbZonas).EditValue = configuracion.zona_id;
            parametros = new
            {
                fields = "id, nombre"
            };
            ((RepositoryItemLookUpEditBase)cbCertificados.Properties).DataSource = Utilidades.Busqueda("certificados", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbCertificados.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbCertificados.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbCertificados).EditValue = configuracion.certificado_id;
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).DataSource = Utilidades.Busqueda("tipos_metodos_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbTiposMetodosPago.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbTiposMetodosPago).EditValue = configuracion.tipo_metodo_pago_monedero_id;
            ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).DataSource = Utilidades.Busqueda("listas_precios", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbListasPrecios.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbListasPrecios).EditValue = configuracion.lista_precio_id;
            ((RepositoryItemLookUpEditBase)cbDepartamentos.Properties).DataSource = Utilidades.Busqueda("departamentos", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbDepartamentos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbDepartamentos.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbDepartamentos).EditValue = configuracion.departamento_id;
        }

        private void Llenar()
        {
            configuracion.formulario_panel = cbFormularioPanel.Checked;
            configuracion.venta_articulo_precio_cero = cbVentaArticuloPrecioCero.Checked;
            configuracion.venta_precio_menor_costo = cbVentaArticuloMenorCosto.Checked;
            configuracion.venta_articulo_stock_cero = cbVentaArticuloStockCero.Checked;
            configuracion.documento_borrador = cbDocumentoBorrador.Checked;
            configuracion.agrupar_partidas = cbAgruparPartidas.Checked;
            configuracion.vendedor_segun_usuario = cbVendedorSegunUsuario.Checked;
            configuracion.lista_precio_segun_usuario = cbListaPrecioSegunUsuario.Checked;
            configuracion.vendedor_segun_estacion = cbVendedorSegunEstacion.Checked;
            configuracion.documentos_modo_nuevo = cbDocumentosModoNuevo.Checked;
            configuracion.generar_documento_electronico_automaticamente = cbGenerarDocumentoElectronicoAutomaticamente.Checked;
            configuracion.factura_sin_entregas = cbFacturaSinEntregas.Checked;
            configuracion.seleccionar_sucursal = cbSeleccionarSucursal.Checked;
            configuracion.tipo_metodo_pago_monedero_id = ((!((BaseEdit)cbTiposMetodosPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbTiposMetodosPago).EditValue) : 0);
            configuracion.api_url = ((Control)(object)txtAPIURL).Text;
            configuracion.tema = ceTema.Color.ToArgb().ToString();
            configuracion.certificado_id = ((!((BaseEdit)cbCertificados).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbCertificados).EditValue) : 0);
            configuracion.pedimentos = cbPedimentos.Checked;
            if (configuracion.certificado_id != 0)
            {
                configuracion.pac = cbPAC.SelectedIndex;
                configuracion.timbrado_usuario = ((BaseEdit)txtTimbradoUsuario).EditValue.ToString();
                configuracion.timbrado_contraseña = ((BaseEdit)txtTimbradoContraseña).EditValue.ToString();
                configuracion.timbrado_modo_prueba = cbTimbradoModoPrueba.Checked;
                configuracion.generar_timbrado_sin_descuento = cbGenerarTimbradoSinDescuento.Checked;
            }
            configuracion.directorio_informes = ((Control)(object)txtDirectorioInformes).Text;
            configuracion.directorio_documentos = ((Control)(object)txtDirectorioDocumentos).Text;
            configuracion.directorio_imagenes = ((Control)(object)txtDirectorioImagenes).Text;
            configuracion.directorio_xml = ((Control)(object)txtDirectorioXML).Text;
            configuracion.directorio_huellas = ((Control)(object)txtDirectorioHuellas).Text;
            configuracion.directorio_anexos = ((Control)(object)txtDirectorioAnexos).Text;
            configuracion.dia_semana = cbDiasSemana.SelectedIndex;
            configuracion.sap = cbSAP.Checked;
            configuracion.netsuite = cbNetSuite.Checked;
            configuracion.inventario_sap = cbInventarioSAP.Checked;
            configuracion.condicion_pago_id = ((!((BaseEdit)cbCondicionesPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbCondicionesPago).EditValue) : 0);
            configuracion.departamento_id = ((!((BaseEdit)cbDepartamentos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbDepartamentos).EditValue) : 0);
            configuracion.fabricante_id = ((!((BaseEdit)cbFabricantes).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbFabricantes).EditValue) : 0);
            configuracion.grupo_articulo_id = ((!((BaseEdit)cbGruposArticulos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposArticulos).EditValue) : 0);
            configuracion.impuesto_id = ((!((BaseEdit)cbImpuestos).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbImpuestos).EditValue) : 0);
            configuracion.metodo_pago_id = ((!((BaseEdit)cbMetodosPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMetodosPago).EditValue) : 0);
            configuracion.lista_precio_id = ((!((BaseEdit)cbListasPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListasPrecios).EditValue) : 0);
            configuracion.moneda_id = ((!((BaseEdit)cbMonedas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMonedas).EditValue) : 0);
            configuracion.zona_id = ((!((BaseEdit)cbZonas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbZonas).EditValue) : 0);
            sap.servidor = ((Control)(object)txtServidor).Text;
            sap.fuente_datos = ((Control)(object)txtFuenteDatos).Text;
            sap.servidor_licencias = ((Control)(object)txtServidorLicencias).Text;
            sap.tipo_servidor_bd = cbTipoServidorBD.SelectedIndex + 1;
            sap.bd = ((Control)(object)txtBD).Text;
            sap.usuario_bd = ((Control)(object)txtUsuarioBD).Text;
            sap.contraseña_bd = ((Control)(object)txtContraseñaBD).Text;
            sap.usuario = ((Control)(object)txtUsuario).Text;
            sap.contraseña = ((Control)(object)txtContraseña).Text;
            sap.confiable = cbConfiable.Checked;
            sap.generar_ajuste_inventario = cbGenerarAjusteInventario.Checked;
            sap.numero_cuenta_ajuste_inventario = ((Control)(object)txtNumeroCuentaAjusteInventario).Text;
            sap.facturar_entregas = cbFacturarEntregas.Checked;
            sap.api_url = ((Control)(object)txtSAPAPIURL).Text;
            sap.hora_sincronizacion_general = teHoraSincronizacionGenerales.Time.TimeOfDay;
            netsuite.cuenta_id = ((Control)(object)txtNetSuiteCuentaId).Text;
            netsuite.cliente_llave = ((Control)(object)txtNetSuiteClienteLlave).Text;
            netsuite.cliente_secreto = ((Control)(object)txtNetSuiteClienteSecreto).Text;
            netsuite.token_id = ((Control)(object)txtNetSuiteTokenId).Text;
            netsuite.token_secreto = ((Control)(object)txtNetSuiteTokenSecreto).Text;
            netsuite.api_url = ((Control)(object)txtNetSuiteApiURL).Text;
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (configuracion.id != 0)
                    {
                        configuracion.Actualizar();
                    }
                    if (sap.id != 0)
                    {
                        sap.Actualizar();
                    }
                    if (netsuite.id != 0)
                    {
                        netsuite.Actualizar();
                    }
                    MessageBox.Show("Es necesario reiniciar el programa para que los cambios surtan efecto.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
                return false;
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void cbSAP_CheckedChanged(object sender, EventArgs e)
        {
            gbSAP.Visible = cbSAP.Checked;
        }

        private void txtDirectorioDocumentos_DoubleClick(object sender, EventArgs e)
        {
            //IL_002a: Unknown result type (might be due to invalid IL or missing references)
            //IL_0030: Expected O, but got Unknown
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                TextEdit val = (TextEdit)sender;
                ((Control)(object)val).Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            frmCertificados frmCertificados2 = new frmCertificados();
            ((Form)(object)frmCertificados2).ShowDialog();
        }

        private void lblSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales frmSucursales2 = new frmSucursales();
            ((Form)(object)frmSucursales2).ShowDialog();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            Funciones.Cargando("NetSuite", "Sincronizando por favor espere...");
            NetsuiteLibrary.Sincronizacion sincronizacion = new NetsuiteLibrary.Sincronizacion();
            sincronizacion.configuracion = configuracion;
            sincronizacion.Articulos();
            sincronizacion.Socios();
            Funciones.DescartarCargando();
        }

        private void lblCondicionesPago_Click(object sender, EventArgs e)
        {
            frmCondicionesPago frmCondicionesPago2 = new frmCondicionesPago();
            ((Form)(object)frmCondicionesPago2).ShowDialog();
        }

        private void lblDepartamentos_Click(object sender, EventArgs e)
        {
            frmDepartamentos frmDepartamentos2 = new frmDepartamentos();
            ((Form)(object)frmDepartamentos2).ShowDialog();
        }

        private void lblFabricantes_Click(object sender, EventArgs e)
        {
            frmFabricantes frmFabricantes2 = new frmFabricantes();
            ((Form)(object)frmFabricantes2).ShowDialog();
        }

        private void lblImpuesto_Click(object sender, EventArgs e)
        {
            frmImpuestos frmImpuestos2 = new frmImpuestos();
            ((Form)(object)frmImpuestos2).ShowDialog();
        }

        private void lblListaPrecios_Click(object sender, EventArgs e)
        {
            frmListasPrecios frmListasPrecios2 = new frmListasPrecios();
            ((Form)(object)frmListasPrecios2).ShowDialog();
        }

        private void lblMetodoPago_Click(object sender, EventArgs e)
        {
            frmMetodosPago frmMetodosPago2 = new frmMetodosPago();
            ((Form)(object)frmMetodosPago2).ShowDialog();
        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas frmMonedas2 = new frmMonedas();
            ((Form)(object)frmMonedas2).ShowDialog();
        }

        private void lblZonas_Click(object sender, EventArgs e)
        {
            frmZonas frmZonas2 = new frmZonas();
            ((Form)(object)frmZonas2).ShowDialog();
        }

        private void lblGrupoArticulos_Click(object sender, EventArgs e)
        {
            frmGruposArticulos frmGruposArticulos2= new frmGruposArticulos();
            ((Form)(object)frmGruposArticulos2).ShowDialog();
        }

        private void lblCertificado_Click(object sender, EventArgs e)
        {
            frmCertificados frmCertificados2= new frmCertificados();
            ((Form)(object)frmCertificados2).ShowDialog();
        }

        private void lblSucursales_Click_1(object sender, EventArgs e)
        {
            frmSucursales frmSucursales2= new frmSucursales();
            ((Form)(object)frmSucursales2).ShowDialog();
        }
    }

}
