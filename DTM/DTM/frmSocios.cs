using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;
using DTM.Reportes;
using NetsuiteLibrary.SuiteTalk_Helpers;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmSocios : RibbonForm
    {
        private Socio socio = new Socio();

        private Socio.Direccion direccion = new Socio.Direccion();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private RibbonPageGroup searchRibbonPageGroup;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BackstageViewControl backstageViewControl1;

        private BarButtonItem bbiNuevo;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageGeneral;

        private LabelControl lblNombreComercial;

        private TextEdit txtNombreComercial;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblCodigo;

        private TextEdit txtCodigo;

        private LayoutControlGroup layoutControlGroup1;

        private LayoutControlItem layoutControlItem1;

        private DataLayoutControl dataLayoutControl1;

        private PictureBox pbImagen;

        private LabelControl lblUltimaActualizacion;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblID;

        private SimpleButton btnImagen;

        private CheckEdit cbActivo;

        private HyperlinkLabelControl lblGrupoSocios;

        private LookUpEdit cbGruposSocios;

        private LookUpEdit cbMonedas;

        private HyperlinkLabelControl lblMonedas;

        private LabelControl lblTipo;

        private LookUpEdit cbTipo;

        private XtraTabPage xtraTabPageCondicionesPago;

        private LookUpEdit cbCondicionesPago;

        private HyperlinkLabelControl lblCondicionesPago;

        private LabelControl lblLimiteCredito;

        private TextEdit txtLimiteCredito;

        private LabelControl lblRFC;

        private TextEdit txtRFC;

        private LabelControl lblTelefono;

        private TextEdit txtTelefono;

        private LabelControl lblTelefonoCelular;

        private TextEdit txtTelefonoCelular;

        private LabelControl lblCorreo;

        private TextEdit txtCorreo;

        private LabelControl lblTelefono2;

        private TextEdit txtTelefono2;

        private LabelControl lblSitioWeb;

        private TextEdit txtSitioWeb;

        private LabelControl lblCURP;

        private TextEdit txtCURP;

        private LabelControl lblCuenta;

        private TextEdit txtCuenta;

        private LabelControl lblPorcentajeInteresRetraso;

        private TextEdit txtPorcentajeInteresRetraso;

        private LookUpEdit cbListaPrecios;

        private HyperlinkLabelControl lblListaPrecios;

        private TextEdit txtBalance;

        private XtraTabPage xtraTabPageDirecciones;

        private XtraTabPage xtraTabPagePersonasContacto;

        private GridControl gcPersonasContacto;

        private GridView gvPersonasContacto;

        private GridColumn gridColumnID;

        private GridColumn gridColumn15;

        private RepositoryItemLookUpEdit cbGenero;

        private GridColumn gridColumn16;

        private GridColumn gridColumn18;

        private GridColumn gridColumn17;

        private GridColumn gridColumn19;

        private GridColumn gridColumn20;

        private GridColumn gridColumn21;

        private GridColumn gridColumn22;

        private GridColumn gridColumn24;

        private GridColumn gridColumn25;

        private GridColumn gridColumn28;

        private GridColumn gridColumn27;

        private LookUpEdit cbDireccionesFacturacion;

        private LabelControl lblDireccionFacturacion;

        private LookUpEdit cbDireccionesEnvio;

        private LabelControl lblDireccionEnvio;

        private LookUpEdit cbMetodosPago;

        private HyperlinkLabelControl lblMetodosPago;

        private LookUpEdit cbPersonasContacto;

        private LabelControl lblPersonasContacto;

        private LabelControl lblMultiplicador;

        private TextEdit txtMultiplicador;

        private CheckEdit cbOrdenCompra;

        private BarButtonItem bbiDocumentosVencidos;

        private RibbonPage ribbonPageHerramientas;

        private RibbonPageGroup ribbonPageGroupHerramientas;

        private BarButtonItem bbiMonedero;

        private LookUpEdit cbVendedores;

        private HyperlinkLabelControl lblVendedores;

        private LabelControl lblUsoPrincipal;

        private LabelControl lblCP;

        private TextEdit txtCP;

        private LabelControl lblCiudad;

        private TextEdit txtCiudad;

        private LabelControl lblEstado;

        private LookUpEdit cbEstados;

        private LabelControl lblPais;

        private LookUpEdit cbPaises;

        private LabelControl lblMunicipio;

        private TextEdit txtMunicipio;

        private LabelControl lblColonia;

        private TextEdit txtColonia;

        private LabelControl lblNumeroInterior;

        private TextEdit txtNumeroInterior;

        private LabelControl lblNumeroExterior;

        private TextEdit txtNumeroExterior;

        private LabelControl lblCalle;

        private TextEdit txtCalle;

        private LabelControl lblNombreDireccion;

        private TextEdit txtNombreDireccion;

        private SimpleButton btnNuevaDireccion;

        private LookUpEdit cbDirecciones;

        private LabelControl lblDireccion;

        private LabelControl lblTipoDireccion;

        private LookUpEdit cbTipoDireccion;

        private LookUpEdit cbImpuestos;

        private HyperlinkLabelControl lblImpuesto;

        private SimpleButton btnGuardarDireccion;

        private LabelControl lblDireccionID;

        private CheckEdit cbEventual;

        private BarSubItem bbiPDF;

        private BarSubItem bbiImprimir;

        private LookUpEdit cbSocios;

        private LookUpEdit cbUsoPrincipal;

        private LookUpEdit cbMonedero;

        private LabelControl lblMonedero;

        private HyperlinkLabelControl lblBalance;

        private XtraTabPage xtraTabPagePropiedades;

        private CheckedListBoxControl cbPropiedades;

        private CheckEdit cbAPI;

        private XtraTabPage xtraTabPageLogistica;

        private HyperlinkLabelControl lblRuta;

        private LookUpEdit cbRutas;

        private TextEdit txtOrdenRuta;

        private LookUpEdit cbPropietarios;

        private HyperlinkLabelControl lblPropietarios;

        private LookUpEdit cbRegimenFiscal;

        private LabelControl lblRegimenFiscal;

        private LabelControl lblDistancia;

        private TextEdit txtDistancia;

        private CheckEdit cbVIP;

    //    private LabelControl lblDiasExtra;

     //   private TextEdit txtDiasExtra;

        private BarButtonItem bbiParametrizacionesFormulario;
        public frmSocios(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                socio = Socio.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
            CargarInformes("SN");
            EventoControl.SuscribirEventos((Form)(object)this);
            gvPersonasContacto.InitNewRow += gvPersonasContacto_InitNewRow;
        }

        private void Permisos()
        {
            ((BarItem)bbiParametrizacionesFormulario).Enabled = false;
            switch (Program.dtm.UsuarioAutenticado.rol)
            {
                case 'A':
                    ((BarItem)bbiParametrizacionesFormulario).Enabled = true;
                    break;
                case 'C':
                    ((Control)(object)lblGrupoSocios).Enabled = false;
                    ((Control)(object)lblCondicionesPago).Enabled = false;
                    ((Control)(object)lblMonedas).Enabled = false;
                   // mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    ((Control)(object)txtLimiteCredito).Enabled = false;
                    ((Control)(object)cbCondicionesPago).Enabled = false;
                    break;
                case 'S':
                    ((Control)(object)txtLimiteCredito).Enabled = false;
                    ((Control)(object)cbCondicionesPago).Enabled = false;
                    break;
            }
            if (!ParametrizacionFormulario.Parametrizaciones().Any((ParametrizacionFormulario x) => x.usuario_id == Program.dtm.UsuarioAutenticado.id || ((int?)x.rol == (int?)Program.dtm.UsuarioAutenticado.rol && x.formulario == ((Control)(object)this).Name)))
            {
                return;
            }
            List<ParametrizacionFormulario> list = ParametrizacionFormulario.Obtener(((Control)this).Name, "SN");
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
                    try
                    {
                        SetButtonVisibility(this.mainRibbonControl, item.control, item.oculto, item.desactivado);
                        ((ColumnView)gvPersonasContacto).Columns.ColumnByName(item.control).Visible = !item.oculto;
                        ((ColumnView)gvPersonasContacto).Columns.ColumnByName(item.control).OptionsColumn.AllowEdit = !item.desactivado;
                    }
                    catch (Exception ex)
                    {

                    }
                   
                }
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
        private void CargarInformes(string clase)
        {
            //IL_0120: Unknown result type (might be due to invalid IL or missing references)
            //IL_0127: Expected O, but got Unknown
            //IL_0127: Unknown result type (might be due to invalid IL or missing references)
            //IL_012e: Expected O, but got Unknown
            //IL_0191: Unknown result type (might be due to invalid IL or missing references)
            //IL_019b: Expected O, but got Unknown
            //IL_01a6: Unknown result type (might be due to invalid IL or missing references)
            //IL_01b0: Expected O, but got Unknown
            try
            {
                List<Informe> list = (from x in Informe.Informes()
                                      where x.activo == true && x.tipo == clase
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
                        Funciones.ImprimirInforme(informe.id, socio.id, documento: true);
                    };
                    ((BarItem)val2).ItemClick += (ItemClickEventHandler)delegate
                    {
                        Process.Start(Funciones.PDFInforme(informe.id, socio.id));
                    };
                    ((BarLinkContainerItem)bbiImprimir).AddItem((BarItem)(object)val);
                    ((BarLinkContainerItem)bbiPDF).AddItem((BarItem)(object)val2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private bool validar() 
        {
            System.Collections.Generic.List<string> condicionesRegimenPersonasFisicas = new System.Collections.Generic.List<string> { "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "621", "622", "625", "626" };
            System.Collections.Generic.List<string> condicionesRegimenPersonasMorales = new System.Collections.Generic.List<string> { "601", "603", "620", "623", "624", "628", "629", "630" };
            if (condicionesRegimenPersonasFisicas.Contains(socio.regimen_fiscal))
            {
                // Validación para persona física: el RFC debe tener 13 caracteres
                if (((Control)(object)txtRFC).Text.Trim().Length != 13)
                {
                    MessageBox.Show("Un RFC de 13 caracteres es necesario para una persona física", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (condicionesRegimenPersonasMorales.Contains(socio.regimen_fiscal))
            {
                // Validación para persona moral: el RFC debe tener 12 caracteres
                if (((Control)(object)txtRFC).Text.Trim().Length != 12)
                {
                    MessageBox.Show("Un RFC de 12 caracteres es necesario para una persona moral", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validar()) 
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
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validar())
            {
                if (Guardar())
                {
                    ((Form)this).Close();
                }
            }
        }
        private void gvPersonasContacto_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            // Verifica si el valor de 'id' de la nueva fila ya existe
            var id = gvPersonasContacto.GetRowCellValue(e.RowHandle, "id").ToString();
            //if (IdYaExiste(id))
            //{
            //    MessageBox.Show("Este ID ya existe. No se puede agregar.");
            //    gvPersonasContacto.DeleteRow(e.RowHandle);  // Eliminar la fila vacía si es un duplicado
            //}
        }
        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validar())
            {
                if (Guardar())
                {
                    socio = new Socio();
                    Cargar();
                }
            }
        }
        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            try
            {
                ((Control)(object)lblID).Text = socio.id.ToString();
                ((BaseEdit)cbListaPrecios).EditValue = socio.lista_precio_id;
                ((BaseEdit)cbMonedas).EditValue = socio.moneda_id;
                ((BaseEdit)cbCondicionesPago).EditValue = socio.condicion_pago_id;
                ((BaseEdit)cbMetodosPago).EditValue = socio.metodo_pago_id;
                ((BaseEdit)cbGruposSocios).EditValue = socio.grupo_socio_id;
                ((Control)(object)txtCodigo).Text = socio.codigo;
                ((BaseEdit)cbTipo).EditValue = socio.tipo;
                ((Control)(object)txtNombre).Text = socio.nombre;
                ((Control)(object)txtNombreComercial).Text = socio.nombre_comercial;
                ((Control)(object)txtRFC).Text = socio.rfc;
                ((Control)(object)txtCURP).Text = socio.curp;
                ((Control)(object)txtTelefono).Text = socio.telefono;
                ((Control)(object)txtTelefono2).Text = socio.telefono2;
                ((Control)(object)txtTelefonoCelular).Text = socio.celular;
                ((Control)(object)txtCorreo).Text = socio.correo;
                ((Control)(object)txtSitioWeb).Text = socio.sitio_web;
                ((BaseEdit)cbVendedores).EditValue = socio.vendedor_id;
                ((BaseEdit)cbPropietarios).EditValue = socio.propietario_id;
                pbImagen.LoadImage(socio.imagen);
                ((Control)(object)txtBalance).Text = socio.Balance().ToString();
                ((Control)(object)txtPorcentajeInteresRetraso).Text = socio.porcentaje_interes_retraso.ToString();
               // ((Control)(object)txtPorcentajeDescuento).Text = socio.porcentaje_descuento.ToString();
                ((Control)(object)txtLimiteCredito).Text = socio.limite_credito.ToString();
                ((Control)(object)txtCuenta).Text = socio.cuenta;
                //((Control)(object)txtCuentaPago).Text = socio.cuenta_pago;
                cbOrdenCompra.Checked = socio.orden_compra;
                ((Control)(object)txtMultiplicador).Text = socio.multiplicador_puntos.ToString();
                ((BaseEdit)cbUsoPrincipal).EditValue = socio.uso_principal;
                ((BaseEdit)cbRegimenFiscal).EditValue = socio.regimen_fiscal;
                cbEventual.Checked = socio.eventual;
                ((BaseEdit)cbSocios).EditValue = socio.socio_eventual_id;
                ((BaseEdit)cbMonedero).EditValue = socio.monedero_id;
                //((BaseEdit)txtLatitud).EditValue = socio.latitud;
                //((BaseEdit)txtLongitud).EditValue = socio.longitud;
                //((BaseEdit)cbFrecuencia).EditValue = socio.frecuencia;
                ((BaseEdit)cbRutas).EditValue = socio.ruta_id;
                ((BaseEdit)txtOrdenRuta).EditValue = socio.orden_ruta;
                cbAPI.Checked = socio.api;
                cbVIP.Checked = socio.vip;
                if (socio.vip == true)
                {
                    txtDiasExtra.Enabled = true;
                    ((BaseEdit)txtDiasExtra).EditValue = socio.dias_extra_vigencia;
                }
              
                cbActivo.Checked = socio.activo;
                ((Control)(object)lblFechaActualizacion).Text = socio.fecha_actualizacion.ToShortDateString();
                //((Control)(object)cbListaPrecios).Enabled = socio.lista_precio_id >= 0;
                CargarDirecciones();
                CargarPersonasContacto();
                CargarPropiedades();
                bool enabled;
                if (nuevo)
                {
                    ((BarItem)bbiNuevo).Enabled = false;
                    BarSubItem obj = bbiPDF;
                    BarSubItem obj2 = bbiImprimir;
                    BarButtonItem obj3 = bbiGuardar;
                    BarButtonItem obj4 = bbiGuardarCerrar;
                    BarButtonItem obj5 = bbiGuardarNuevo;
                    bool flag2 = (((Control)(object)txtCodigo).Enabled = true);
                    bool flag4 = (((BarItem)obj5).Enabled = flag2);
                    bool flag6 = (((BarItem)obj4).Enabled = flag4);
                    bool flag8 = (((BarItem)obj3).Enabled = flag6);
                    enabled = (((BarItem)obj2).Enabled = flag8);
                    ((BarItem)obj).Enabled = enabled;
                    ((Control)(object)txtCodigo).Focus();
                }
                else if (busqueda)
                {
                    BarButtonItem obj6 = bbiNuevo;
                    enabled = (((Control)(object)txtCodigo).Enabled = true);
                    ((BarItem)obj6).Enabled = enabled;
                    BarSubItem obj7 = bbiPDF;
                    BarSubItem obj8 = bbiImprimir;
                    BarButtonItem obj9 = bbiGuardar;
                    BarButtonItem obj10 = bbiGuardarCerrar;
                    bool flag4 = (((BarItem)bbiGuardarNuevo).Enabled = false);
                    bool flag6 = (((BarItem)obj10).Enabled = flag4);
                    bool flag8 = (((BarItem)obj9).Enabled = flag6);
                    enabled = (((BarItem)obj8).Enabled = flag8);
                    ((BarItem)obj7).Enabled = enabled;
                    ((BaseEdit)cbGruposSocios).EditValue = null;
                    ((Control)(object)txtCodigo).Focus();
                }
                else
                {
                    BarSubItem obj11 = bbiPDF;
                    BarSubItem obj12 = bbiImprimir;
                    BarButtonItem obj13 = bbiNuevo;
                    BarButtonItem obj14 = bbiGuardar;
                    BarButtonItem obj15 = bbiGuardarCerrar;
                    bool flag2 = (((BarItem)bbiGuardarNuevo).Enabled = true);
                    bool flag4 = (((BarItem)obj15).Enabled = flag2);
                    bool flag6 = (((BarItem)obj14).Enabled = flag4);
                    bool flag8 = (((BarItem)obj13).Enabled = flag6);
                    enabled = (((BarItem)obj12).Enabled = flag8);
                    ((BarItem)obj11).Enabled = enabled;
                    ((Control)(object)txtCodigo).Enabled = false;
                }
                ((BaseEdit)txtCodigo).ReadOnly = !((Control)(object)txtCodigo).Enabled;
                XtraTabPage obj16 = xtraTabPagePersonasContacto;
                enabled = (xtraTabPageDirecciones.PageVisible = ((socio.id != 0) ? true : false));
                obj16.PageVisible = enabled;
            }
            catch
            {
            }
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
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).DataSource = Utilidades.Busqueda("grupos_socios", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DataSource = Utilidades.Busqueda("condiciones_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DataSource = Utilidades.Busqueda("metodos_pago", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMetodosPago.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DataSource = Utilidades.Busqueda("monedas", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedas.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbMonedas).EditValue = Program.dtm.Configuracion.moneda_id;
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DataSource = (from x in Vendedor.Vendedores()
                                                                                  where x.activo == true
                                                                                  select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbPropietarios.Properties).DataSource = (from x in Propietario.Propietarios()
                                                                                    where x.activo == true
                                                                                    select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbPropietarios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbPropietarios.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DataSource = Utilidades.Busqueda("paises", null, parametros);
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbPaises.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DataSource = Utilidades.Busqueda("estados", null, new
            {
                fields = "id, pais_id, codigo, nombre"
            });
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbEstados.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).DataSource = Utilidades.Busqueda("impuestos", null, parametros);
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbImpuestos.Properties).DisplayMember = "nombre";
            parametros = new
            {
                fields = "id, nombre"
            };
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DataSource = Utilidades.Busqueda("listas_precios", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbListaPrecios.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbListaPrecios).EditValue = Program.dtm.Configuracion.lista_precio_id;
            parametros = new
            {
                fields = "id, tipo, codigo, nombre"
            };
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).DataSource = Utilidades.Busqueda("grupos_socios", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).DataSource = Socio.Tipo.Tipos();
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTipo.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbTipo).EditValue = Socio.Tipo.ObtenerPredeterminado();
            ((RepositoryItemLookUpEditBase)cbTipoDireccion.Properties).DataSource = Socio.Direccion.Tipo.Tipos();
            ((RepositoryItemLookUpEditBase)cbTipoDireccion.Properties).ValueMember = "tipo";
            ((RepositoryItemLookUpEditBase)cbTipoDireccion.Properties).DisplayMember = "nombre";
            //((RepositoryItemLookUpEditBase)cbFrecuencia.Properties).DataSource = Socio.Frecuencia.Frequencias();
            //((RepositoryItemLookUpEditBase)cbFrecuencia.Properties).ValueMember = "frecuencia";
            //((RepositoryItemLookUpEditBase)cbFrecuencia.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbGenero).DataSource = Socio.PersonaContacto.Genero.Generos();
            ((RepositoryItemLookUpEditBase)cbGenero).ValueMember = "genero";
            ((RepositoryItemLookUpEditBase)cbGenero).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DataSource = (from x in Socio.Socios()
                                                                              where x.activo == true
                                                                              select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbSocios.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbMonedero.Properties).DataSource = (from x in Monedero.Monederos()
                                                                                where x.activo == true
                                                                                select new { x.id, x.folio }).ToList();
            ((RepositoryItemLookUpEditBase)cbMonedero.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbMonedero.Properties).DisplayMember = "folio";
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DataSource = Documento.UsoCFDI.UsosCFDI();
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).ValueMember = "uso";
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DataSource = Documento.RegimenFiscal.RegimenesFiscales();
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).ValueMember = "clave";
            ((RepositoryItemLookUpEditBase)cbRegimenFiscal.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).DataSource = (from x in Ruta.Rutas()
                                                                             where x.activo == true
                                                                             select new { x.id, x.codigo, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbRutas.Properties).DisplayMember = "nombre";
            for (int i = 0; i < 32; i++)
            {
                ((ListBoxItemCollection)((BaseCheckedListBoxControl)cbPropiedades).Items).Add((object)$"Propiedad {i + 1}");
            }
        }

        private void CargarPersonasContacto()
        {
            ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).DataSource = (from x in Socio.PersonaContacto.PersonasContacto()
                                                                                        where x.socio_id == socio.id
                                                                                        select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbPersonasContacto.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbPersonasContacto).EditValue = socio.persona_contacto_id;
            gcPersonasContacto.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM personas_contacto WHERE socio_id = {socio.id}");
        }

        private void CargarDirecciones()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)cbDireccionesFacturacion.Properties).DataSource = (from x in Socio.Direccion.Direcciones()
                                                                                                  where x.socio_id == socio.id && x.tipo == 'F'
                                                                                                  select new { x.id, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbDireccionesFacturacion.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbDireccionesFacturacion.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbDireccionesFacturacion).EditValue = socio.direccion_facturacion_id;
                ((RepositoryItemLookUpEditBase)cbDireccionesEnvio.Properties).DataSource = (from x in Socio.Direccion.Direcciones()
                                                                                            where x.socio_id == socio.id && x.tipo == 'E'
                                                                                            select new { x.id, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbDireccionesEnvio.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbDireccionesEnvio.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbDireccionesEnvio).EditValue = socio.direccion_envio_id;
                RepositoryItemLookUpEdit properties = cbDirecciones.Properties;
                object dataSource = (((RepositoryItemLookUpEditBase)cbDireccionesEnvio.Properties).DataSource = (from x in Socio.Direccion.Direcciones()
                                                                                                                 where x.socio_id == socio.id
                                                                                                                 select new { x.id, x.nombre }).ToList());
                ((RepositoryItemLookUpEditBase)properties).DataSource = dataSource;
                ((RepositoryItemLookUpEditBase)cbDirecciones.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbDirecciones.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbDirecciones).EditValue = socio.direccion_facturacion_id;
            }
            catch
            {
            }
        }

        private void CargarPropiedades()
        {
            try
            {
                ((BaseCheckedListBoxControl)cbPropiedades).Items[0].CheckState = (socio.propiedad_1 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[1].CheckState = (socio.propiedad_2 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[2].CheckState = (socio.propiedad_3 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[3].CheckState = (socio.propiedad_4 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[4].CheckState = (socio.propiedad_5 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[5].CheckState = (socio.propiedad_6 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[6].CheckState = (socio.propiedad_7 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[7].CheckState = (socio.propiedad_8 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[8].CheckState = (socio.propiedad_9 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[9].CheckState = (socio.propiedad_10 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[10].CheckState = (socio.propiedad_11 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[11].CheckState = (socio.propiedad_12 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[12].CheckState = (socio.propiedad_13 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[13].CheckState = (socio.propiedad_14 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[14].CheckState = (socio.propiedad_15 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[15].CheckState = (socio.propiedad_16 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[16].CheckState = (socio.propiedad_17 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[17].CheckState = (socio.propiedad_18 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[18].CheckState = (socio.propiedad_19 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[19].CheckState = (socio.propiedad_20 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[20].CheckState = (socio.propiedad_21 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[21].CheckState = (socio.propiedad_22 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[22].CheckState = (socio.propiedad_23 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[23].CheckState = (socio.propiedad_24 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[24].CheckState = (socio.propiedad_25 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[25].CheckState = (socio.propiedad_26 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[26].CheckState = (socio.propiedad_27 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[27].CheckState = (socio.propiedad_28 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[28].CheckState = (socio.propiedad_29 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[29].CheckState = (socio.propiedad_30 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[30].CheckState = (socio.propiedad_31 ? CheckState.Checked : CheckState.Unchecked);
                ((BaseCheckedListBoxControl)cbPropiedades).Items[31].CheckState = (socio.propiedad_32 ? CheckState.Checked : CheckState.Unchecked);
            }
            catch
            {
            }
        }

        private void CargarGruposSocios()
        {
            string text = ((BaseEdit)cbTipo).EditValue.ToString();
            if (text == "L")
            {
                text = "C";
            }
            (((RepositoryItemLookUpEditBase)cbGruposSocios.Properties).DataSource as DataTable).DefaultView.RowFilter = $"tipo = '{text}'";
        }

        private bool Llenar()
        {
            try
            {
                if (socio.lista_precio_id >= 0)
                {
                    socio.lista_precio_id = ((!((BaseEdit)cbListaPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListaPrecios).EditValue) : 0);
                }
                socio.moneda_id = ((!((BaseEdit)cbMonedas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMonedas).EditValue) : 0);
                socio.condicion_pago_id = ((!((BaseEdit)cbCondicionesPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbCondicionesPago).EditValue) : 0);
                socio.metodo_pago_id = ((!((BaseEdit)cbMetodosPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMetodosPago).EditValue) : 0);
                socio.grupo_socio_id = ((!((BaseEdit)cbGruposSocios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposSocios).EditValue) : 0);
                socio.direccion_facturacion_id = ((!((BaseEdit)cbDireccionesFacturacion).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbDireccionesFacturacion).EditValue) : 0);
                socio.direccion_envio_id = ((!((BaseEdit)cbDireccionesEnvio).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbDireccionesEnvio).EditValue) : 0);
                socio.vendedor_id = ((!((BaseEdit)cbVendedores).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbVendedores).EditValue) : 0);
                socio.propietario_id = ((!((BaseEdit)cbPropietarios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbPropietarios).EditValue) : 0);
                socio.codigo = ((Control)(object)txtCodigo).Text;
                socio.tipo = (char)((BaseEdit)cbTipo).EditValue;
                socio.nombre = ((Control)(object)txtNombre).Text;
                socio.nombre_comercial = ((Control)(object)txtNombreComercial).Text;
                socio.rfc = ((Control)(object)txtRFC).Text;
                socio.curp = ((Control)(object)txtCURP).Text;
                socio.telefono = ((Control)(object)txtTelefono).Text;
                socio.telefono2 = ((Control)(object)txtTelefono2).Text;
                socio.celular = ((Control)(object)txtTelefonoCelular).Text;
                socio.correo = ((Control)(object)txtCorreo).Text;
                socio.sitio_web = ((Control)(object)txtSitioWeb).Text;
                socio.porcentaje_interes_retraso = decimal.Parse(((BaseEdit)txtPorcentajeInteresRetraso).EditValue.ToString());
               // socio.porcentaje_descuento = decimal.Parse(((BaseEdit)txtPorcentajeDescuento).EditValue.ToString());
                socio.limite_credito = decimal.Parse(((BaseEdit)txtLimiteCredito).EditValue.ToString());
                socio.cuenta = ((Control)(object)txtCuenta).Text;
               // socio.cuenta_pago = ((Control)(object)txtCuentaPago).Text;
                socio.orden_compra = cbOrdenCompra.Checked;
                socio.multiplicador_puntos = decimal.Parse(((BaseEdit)txtMultiplicador).EditValue.ToString());
                socio.uso_principal = ((BaseEdit)cbUsoPrincipal).EditValue.ToString();
                socio.regimen_fiscal = ((BaseEdit)cbRegimenFiscal).EditValue.ToString();
                socio.eventual = cbEventual.Checked;
                socio.socio_eventual_id = ((!((BaseEdit)cbSocios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbSocios).EditValue) : 0);
                socio.monedero_id = ((!((BaseEdit)cbMonedero).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMonedero).EditValue) : 0);
                socio.api = cbAPI.Checked;
                socio.vip = cbVIP.Checked;
                socio.dias_extra_vigencia = int.Parse(((Control)(object)txtDiasExtra).Text);
                //socio.latitud = decimal.Parse(((Control)(object)txtLatitud).Text);
                //socio.longitud = decimal.Parse(((Control)(object)txtLongitud).Text);
                //socio.frecuencia = (char)((BaseEdit)cbFrecuencia).EditValue;
                socio.ruta_id = ((!((BaseEdit)cbRutas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbRutas).EditValue) : 0);
                socio.orden_ruta = int.Parse(((Control)(object)txtOrdenRuta).Text);
                socio.activo = cbActivo.Checked;
                try
                {
                    socio.propiedad_1 = ((BaseCheckedListBoxControl)cbPropiedades).Items[0].CheckState == CheckState.Checked;
                    socio.propiedad_2 = ((BaseCheckedListBoxControl)cbPropiedades).Items[1].CheckState == CheckState.Checked;
                    socio.propiedad_3 = ((BaseCheckedListBoxControl)cbPropiedades).Items[2].CheckState == CheckState.Checked;
                    socio.propiedad_4 = ((BaseCheckedListBoxControl)cbPropiedades).Items[3].CheckState == CheckState.Checked;
                    socio.propiedad_5 = ((BaseCheckedListBoxControl)cbPropiedades).Items[4].CheckState == CheckState.Checked;
                    socio.propiedad_6 = ((BaseCheckedListBoxControl)cbPropiedades).Items[5].CheckState == CheckState.Checked;
                    socio.propiedad_7 = ((BaseCheckedListBoxControl)cbPropiedades).Items[6].CheckState == CheckState.Checked;
                    socio.propiedad_8 = ((BaseCheckedListBoxControl)cbPropiedades).Items[7].CheckState == CheckState.Checked;
                    socio.propiedad_9 = ((BaseCheckedListBoxControl)cbPropiedades).Items[8].CheckState == CheckState.Checked;
                    socio.propiedad_10 = ((BaseCheckedListBoxControl)cbPropiedades).Items[9].CheckState == CheckState.Checked;
                    socio.propiedad_11 = ((BaseCheckedListBoxControl)cbPropiedades).Items[10].CheckState == CheckState.Checked;
                    socio.propiedad_12 = ((BaseCheckedListBoxControl)cbPropiedades).Items[11].CheckState == CheckState.Checked;
                    socio.propiedad_13 = ((BaseCheckedListBoxControl)cbPropiedades).Items[12].CheckState == CheckState.Checked;
                    socio.propiedad_14 = ((BaseCheckedListBoxControl)cbPropiedades).Items[13].CheckState == CheckState.Checked;
                    socio.propiedad_15 = ((BaseCheckedListBoxControl)cbPropiedades).Items[14].CheckState == CheckState.Checked;
                    socio.propiedad_16 = ((BaseCheckedListBoxControl)cbPropiedades).Items[15].CheckState == CheckState.Checked;
                    socio.propiedad_17 = ((BaseCheckedListBoxControl)cbPropiedades).Items[16].CheckState == CheckState.Checked;
                    socio.propiedad_18 = ((BaseCheckedListBoxControl)cbPropiedades).Items[17].CheckState == CheckState.Checked;
                    socio.propiedad_19 = ((BaseCheckedListBoxControl)cbPropiedades).Items[18].CheckState == CheckState.Checked;
                    socio.propiedad_20 = ((BaseCheckedListBoxControl)cbPropiedades).Items[19].CheckState == CheckState.Checked;
                    socio.propiedad_21 = ((BaseCheckedListBoxControl)cbPropiedades).Items[20].CheckState == CheckState.Checked;
                    socio.propiedad_22 = ((BaseCheckedListBoxControl)cbPropiedades).Items[21].CheckState == CheckState.Checked;
                    socio.propiedad_23 = ((BaseCheckedListBoxControl)cbPropiedades).Items[22].CheckState == CheckState.Checked;
                    socio.propiedad_24 = ((BaseCheckedListBoxControl)cbPropiedades).Items[23].CheckState == CheckState.Checked;
                    socio.propiedad_25 = ((BaseCheckedListBoxControl)cbPropiedades).Items[24].CheckState == CheckState.Checked;
                    socio.propiedad_26 = ((BaseCheckedListBoxControl)cbPropiedades).Items[25].CheckState == CheckState.Checked;
                    socio.propiedad_27 = ((BaseCheckedListBoxControl)cbPropiedades).Items[26].CheckState == CheckState.Checked;
                    socio.propiedad_28 = ((BaseCheckedListBoxControl)cbPropiedades).Items[27].CheckState == CheckState.Checked;
                    socio.propiedad_29 = ((BaseCheckedListBoxControl)cbPropiedades).Items[28].CheckState == CheckState.Checked;
                    socio.propiedad_30 = ((BaseCheckedListBoxControl)cbPropiedades).Items[29].CheckState == CheckState.Checked;
                    socio.propiedad_31 = ((BaseCheckedListBoxControl)cbPropiedades).Items[30].CheckState == CheckState.Checked;
                    socio.propiedad_32 = ((BaseCheckedListBoxControl)cbPropiedades).Items[31].CheckState == CheckState.Checked;
                }
                catch
                {
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (socio.id != 0)
                    {
                        bool flag = socio.Actualizar();
                        if (flag && Program.dtm.Configuracion.netsuite && socio.identificador_externo == 0)
                        {
                            CustomerHelper customerHelper = new CustomerHelper();
                            //customerHelper.CreateCustomer(socio);
                        }
                        else if (flag && Program.dtm.Configuracion.netsuite && socio.identificador_externo != 0)
                        {
                            CustomerHelper customerHelper2 = new CustomerHelper();
                            //customerHelper2.UpdateCustomer(socio);
                        }
                        return flag;
                    }
                    bool flag2 = socio.Agregar();
                    if (flag2 && Program.dtm.Configuracion.netsuite)
                    {
                        CustomerHelper customerHelper3 = new CustomerHelper();
                        //customerHelper3.CreateCustomer(socio);
                    }
                    return flag2;
                }
                return false;
            }
            catch
            {
                MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                socio = (from x in Socio.Socios()
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
                socio = (from x in Socio.Socios()
                         where x.id < socio.id
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
                socio = (from x in Socio.Socios()
                         where x.id > socio.id
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
                socio = (from x in Socio.Socios()
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

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            socio = new Socio();
            Cargar(nuevo: true);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = Program.dtm.Configuracion.directorio_imagenes + "\\" + openFileDialog.SafeFileName;
                File.Copy(openFileDialog.FileName, text, overwrite: true);
                pbImagen.Image = new Bitmap(text);
                socio.imagen = openFileDialog.FileName;
            }
        }

        private void Buscar()
        {
            try
            {
                txtCodigo.Enabled = true;
                txtNombre.Enabled = true;
                if (socio.id != 0)
                {
                    socio = new Socio();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, codigo, nombre, rfc, telefono, celular, activo",
                    like = true
                };
                object objeto = new
                {
                    codigo = ((Control)(object)txtCodigo).Text,
                    nombre = ((Control)(object)txtNombre).Text,
                    descripcion = ((Control)(object)txtNombreComercial).Text,
                    grupo_socio_id = (((BaseEdit)cbGruposSocios).EditValue.IsNullOrEmpty() ? null : ((BaseEdit)cbGruposSocios).EditValue)
                };
                DataTable dataTable = Utilidades.Busqueda("socios", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        socio = Socio.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        socio = Socio.Obtener(frmResultadosBusqueda2.id);
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

        private void txtSKU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && socio.id == 0)
            {
                Buscar();
            }
        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {
            frmMonedas frmMonedas2 = new frmMonedas((!((BaseEdit)cbMonedas).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbMonedas).EditValue) : 0);
            ((Form)(object)frmMonedas2).ShowDialog();
            CargarListas();
        }

        private void lblGrupoSocios_Click(object sender, EventArgs e)
        {
            frmGruposSocios frmGruposSocios2 = new frmGruposSocios((!((BaseEdit)cbGruposSocios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbGruposSocios).EditValue) : 0);
            ((Form)(object)frmGruposSocios2).ShowDialog();
            CargarListas();
        }

        private void lblListaPrecios_Click(object sender, EventArgs e)
        {
            frmListasPrecios frmListasPrecios2 = new frmListasPrecios((!((BaseEdit)cbListaPrecios).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbListaPrecios).EditValue) : 0);
            ((Form)(object)frmListasPrecios2).ShowDialog();
            CargarListas();
        }

        private void lblCondicionesPago_Click(object sender, EventArgs e)
        {
            frmCondicionesPago frmCondicionesPago2 = new frmCondicionesPago((!((BaseEdit)cbCondicionesPago).EditValue.IsNullOrEmpty()) ? ((int)((BaseEdit)cbCondicionesPago).EditValue) : 0);
            ((Form)(object)frmCondicionesPago2).ShowDialog();
            CargarListas();
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_0007: Unknown result type (might be due to invalid IL or missing references)
            //IL_000e: Invalid comparison between Unknown and I4
            if ((int)e.Button.ButtonType != 10 || socio.id == 0)
            {
                return;
            }
            try
            {
                DataRow dataRow = ((ColumnView)gvPersonasContacto).GetDataRow(((ColumnView)gvPersonasContacto).GetSelectedRows()[0]);
                ((BaseView)gvPersonasContacto).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Socio.PersonaContacto personaContacto = new Socio.PersonaContacto();
                if (result != 0)
                {
                    personaContacto = Socio.PersonaContacto.Obtener(result);
                }
                personaContacto.codigo = Socio.PersonaContacto.ObtenerSiguienteCodigoXCodigo();
                personaContacto.genero = char.Parse(dataRow["genero"].ToString());
                personaContacto.socio_id = socio.id;
                personaContacto.nombre = socio.codigo;
                personaContacto.nombre_persona = dataRow["nombre_persona"].ToString();
                personaContacto.titulo = dataRow["titulo"].ToString();
                personaContacto.posicion = dataRow["posicion"].ToString();
                personaContacto.direccion = dataRow["direccion"].ToString();
                personaContacto.telefono = dataRow["telefono"].ToString();
                personaContacto.celular = dataRow["celular"].ToString();
                personaContacto.correo = dataRow["correo"].ToString();
                personaContacto.observaciones = dataRow["observaciones"].ToString();
                personaContacto.activo = dataRow["activo"].IsNullOrEmpty() || (bool)dataRow["activo"];
                if (Program.dtm.Estacion.lector_huella)
                {
                    string text = (personaContacto.huella_digital.IsNullOrEmpty() ? "¿Desea agregar una huella digital?" : "¿Desea actualizar la huella digital existente?");
                    if (MessageBox.Show(text, ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //HuellaDigital.frmHuellaDigitalAgregar frmHuellaDigitalAgregar = new HuellaDigital.frmHuellaDigitalAgregar();
                        //DialogResult dialogResult = ((Form)(object)frmHuellaDigitalAgregar).ShowDialog();
                        //if (dialogResult == DialogResult.OK)
                        //{
                        //    personaContacto.huella_digital = frmHuellaDigitalAgregar.huella_digital;
                        //}
                    }
                }
                if (personaContacto.id != 0)
                {
                    if (!personaContacto.Actualizar())
                    {
                        MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                    }
                }
                else if (!personaContacto.Agregar())
                {
                    MessageBox.Show(SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                CargarPersonasContacto();
            }
        }

        private void cbTipo_EditValueChanged(object sender, EventArgs e)
        {
            CargarGruposSocios();
        }

        private void cbPaises_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                (((RepositoryItemLookUpEditBase)cbEstados.Properties).DataSource as DataTable).DefaultView.RowFilter = $"pais_id = '{(int)((BaseEdit)cbPaises).EditValue}'";
            }
            catch
            {
            }
        }

        private void bbiDocumentosVencidos_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (socio.DocumentosVencidos())
            {
                MessageBox.Show("Este socio tiene documentos vencidos.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Este socio NO tiene documentos vencidos.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bbiMonedero_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMonederos frmMonederos2 = new frmMonederos(socio.id);
            ((Control)(object)frmMonederos2).Show();
        }

        private void cbDirecciones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                direccion = Socio.Direccion.Obtener((int)((BaseEdit)cbDirecciones).EditValue);
                CargarDireccion();
            }
            catch
            {
            }
        }

        private void CargarDireccion(bool nueva = false)
        {
            try
            {
                if (nueva)
                {
                    ((BaseEdit)cbDirecciones).EditValue = 0;
                }
                ((Control)(object)lblDireccionID).Text = direccion.id.ToString();
                ((BaseEdit)cbTipoDireccion).EditValue = direccion.tipo;
                ((BaseEdit)cbImpuestos).EditValue = direccion.impuesto_id;
                ((Control)(object)txtNombreDireccion).Text = direccion.nombre;
                ((Control)(object)txtCalle).Text = direccion.calle;
                ((Control)(object)txtNumeroExterior).Text = direccion.numero_exterior;
                ((Control)(object)txtNumeroInterior).Text = direccion.numero_interior;
                ((Control)(object)txtCP).Text = direccion.cp;
                ((Control)(object)txtColonia).Text = direccion.colonia;
                ((Control)(object)txtCiudad).Text = direccion.ciudad;
                ((Control)(object)txtMunicipio).Text = direccion.municipio;
                ((BaseEdit)cbPaises).EditValue = direccion.pais_id;
                ((BaseEdit)cbEstados).EditValue = direccion.estado_id;
                ((Control)(object)txtDistancia).Text = direccion.distancia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private bool GuardarDireccion()
        {
            try
            {
                if (direccion.id == 0)
                {
                    direccion.socio_id = socio.id;
                    direccion.tipo = (char)((BaseEdit)cbTipoDireccion).EditValue;
                    direccion.impuesto_id = direccion.impuesto_id;
                }
                direccion.nombre = ((Control)(object)txtNombreDireccion).Text;
                direccion.calle = ((Control)(object)txtCalle).Text;
                direccion.numero_exterior = ((Control)(object)txtNumeroExterior).Text;
                direccion.numero_interior = ((Control)(object)txtNumeroInterior).Text;
                direccion.cp = ((Control)(object)txtCP).Text;
                direccion.colonia = ((Control)(object)txtColonia).Text;
                direccion.ciudad = ((Control)(object)txtCiudad).Text;
                direccion.municipio = ((Control)(object)txtMunicipio).Text;
                direccion.estado_id = (int)((BaseEdit)cbEstados).EditValue;
                direccion.pais_id = (int)((BaseEdit)cbPaises).EditValue;
                direccion.distancia = int.Parse(((Control)(object)txtDistancia).Text);
                return (direccion.id == 0) ? direccion.Agregar() : direccion.Actualizar();
            }
            catch
            {
                return false;
            }
        }

        private void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            CargarDireccion(nueva: true);
        }

        private void btnGuardarDireccion_Click(object sender, EventArgs e)
        {
            if (GuardarDireccion())
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + SDK.DTM.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
            CargarDirecciones();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = Utilidades.EjecutarQuery($"SELECT documentos.id documento_id, clase, fecha_documento, fecha_vencimiento, numero_documento, numero_documento_externo, (total - importe_aplicado) saldo, total, monedas.nombre moneda, importe_aplicado, (CASE WHEN clase = 'NC' THEN ((total - importe_aplicado) * -1) ELSE (total - importe_aplicado) END) importe FROM documentos JOIN monedas ON documentos.moneda_id = monedas.id WHERE cancelado = 0 AND importe_aplicado < total - 0.01 AND clase IN ('FA', 'ND', 'NC') AND socio_id = {socio.id} AND (estado = 'A' OR reserva = 1) Order By numero_documento_externo");
                if (dataTable.Rows.Count > 0)
                {
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    ((Control)(object)frmResultadosBusqueda2).Text = $"Balance del socio {socio.codigo}";
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                }
            }
            catch
            {
            }
        }

        private void lblPropietarios_Click(object sender, EventArgs e)
        {
            frmPropietarios frmPropietarios2 = new frmPropietarios();
            ((Form)(object)frmPropietarios2).ShowDialog();
            CargarListas();
        }

        private void lblRuta_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas2 = new frmRutas();
            ((Form)(object)frmRutas2).ShowDialog();
            CargarListas();
        }

        private void bbiParametrizacionesFormulario_ItemClick(object sender, ItemClickEventArgs e)
        {
           frmFormSocios frmFormSocios = new frmFormSocios();
            ((Form)(object)frmFormSocios).ShowDialog();
            Permisos();
        }

        private void lblMetodosPago_Click(object sender, EventArgs e)
        {
            frmMetodosPago frmPropietarios2 = new frmMetodosPago();
            ((Form)(object)frmPropietarios2).ShowDialog();
            CargarListas();
        }

        private void lblVendedores_Click(object sender, EventArgs e)
        {
            frmVendedores frmVendedores = new frmVendedores();
            ((Form)(object)frmVendedores).ShowDialog();
            CargarListas();
        }

        private void cbVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVIP.Checked)
            {
                txtDiasExtra.Enabled = true;
            }
            else 
            {
                txtDiasExtra.Enabled = false;
                txtDiasExtra.Text = "0";
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando información para el reporte...");
                string ruta = Settings.Settings.Default.rutaReportes.ToString() + "EstadodeCuentaXCliente.rpt";
                this.Hide();
                    string AttachPDF = addFileTemp();
                    if (AttachPDF != "")
                    {

                        ReportDocument cryReportDocument = new ReportDocument();
                        cryReportDocument.Load(ruta);
                        cryReportDocument.SetDatabaseLogon("sa", "SAPB1Admin", "DTMSAP", "DTM_PRODUCTIVA");
                        cryReportDocument.Refresh();
                        cryReportDocument.SetParameterValue("DocKey@", socio.codigo);
                        cryReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, AttachPDF);
                        cryReportDocument.Dispose();
                        this.Hide();
                        frmVisualizadorReportes frmVisual = new frmVisualizadorReportes(AttachPDF);
                        frmVisual.Show();
                        SplashScreenManager.CloseForm(false);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible abrir este archivo");
                SplashScreenManager.CloseForm(false);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
        public string addFileTemp()
        {
            string ruta = string.Empty;
            try
            {
                string tempDirectory = Path.GetTempPath();
                string tempFilePath = GetUniqueTempFilePath(tempDirectory, "archivo_temp", ".pdf");
                ruta = tempFilePath;
                CreateEmptyPdf(tempFilePath);
            }
            catch (Exception ex)
            {
                ruta = string.Empty;
            }
            return ruta;
        }
        public static string GetUniqueTempFilePath(string directory, string prefix, string extension)
        {
            string tempFileName = Path.Combine(directory, prefix + "_" + Guid.NewGuid().ToString() + extension);
            if (File.Exists(tempFileName))
            {
                return GetUniqueTempFilePath(directory, prefix, extension);
            }
            return tempFileName;
        }
        public static void CreateEmptyPdf(string filePath)
        {
            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
            document.AddPage();
            document.Save(filePath);
        }
    }

}
