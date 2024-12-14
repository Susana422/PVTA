using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class frmPagosFinanciados : RibbonForm
    {
        private Pago pago = new Pago();

        private Socio socio = new Socio();

        internal List<MetodoPago.Tipo> tipos_metodos_pago;

        internal decimal importe_aplicado = default(decimal);

        internal decimal saldo_pendiente = default(decimal);

        internal bool solo_vencidos = true;

        internal bool solo_no_vencidos = true;

        private const string clase = "PR";

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

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private HyperlinkLabelControl lblCodigoSN;

        private TextEdit txtCodigoSN;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageContenido;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnPagoID;

        private GridColumn gridColumnImporte;

        private RepositoryItemLookUpEdit cbGenero;

        private LabelControl lblTotal;

        private TextEdit txtTotal;

        private LabelControl lblSocio;

        private GridColumn gridColumnDocumentoID;

        private GridColumn gridColumnNumeroDocumento;

        private GridColumn gridColumnTipoDocumento;

        private GridColumn gridColumnTotal;

        private GridColumn gridColumnImporteAplicado;

        private LabelControl lblSaldoPendiente;

        private TextEdit txtSaldoPendiente;

        private XtraTabPage xtraTabPageMediosPago;

        private LabelControl lblImporteAplicado;

        private TextEdit txtImporteAplicado;

        private GridControl gcPagos;

        private GridView gvPagos;

        private GridColumn gridColumnID;

        private GridColumn gridColumnMetodoPago;

        private RepositoryItemLookUpEdit cbMetodosPago;

        private GridColumn gridColumnTC;

        private GridColumn gridColumnReferencia;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private BarSubItem bbiImprimir;

        private GridColumn gridColumnFecha;

        private GridColumn gridColumnFechaVencimiento;

        private GridColumn gridColumnMoneda;

        private GridColumn gridColumnTipoCambio;

        private GridColumn gridColumnSaldo;

        private BarSubItem bbiPDF;

        private GridColumn gridColumnMonedaID;

        private GridColumn gridColumnPartidaID;

        private GridColumn gridColumnIntereses;

        private Label lblDireccion;

        private Label lblEstadoCredito;

        private GridColumn gridColumnReserva;

        private GridColumn gridColumnComentario;

        private PopupMenu popupMenuPagos;

        public frmPagosFinanciados(int id = 0)
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
                Cargar(nuevo: true);
            }
        }

        private void CargarListas()
        {
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
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
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
                ((Control)(object)lblCodigoSN).Focus();
                pago.socio_id = socio.id;
                Serie serie = Serie.ObtenerPredeterminado("PR");
                pago.serie_id = serie.id;
            }
            else
            {
                ((Control)(object)lblCodigoSN).Focus();
            }
            ((Control)(object)txtCodigoSN).Text = socio.codigo;
            ((Control)(object)lblSocio).Text = socio.nombre;
            lblEstadoCredito.Text = string.Format("Límite de crédito: {0} | Disponible: {1}", socio.limite_credito.ToString("c2"), (socio.limite_credito - socio.Balance()).ToString("c2"));
            if (socio.DocumentosVencidos())
            {
                lblEstadoCredito.ForeColor = Color.Firebrick;
            }
            else
            {
                lblEstadoCredito.ForeColor = Color.DimGray;
            }
            ((Control)(object)txtTotal).Text = pago.total.ToString("c2");
            CargarPartidas();
        }

        private void Guardar()
        {
            try
            {
                if (NoriSDK.PuntoVenta.EstadoCaja().Equals('C'))
                {
                    if (MessageBox.Show("¿Deseas realizar una apertura de caja?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmIngresos frmIngresos = new frmIngresos("INACA");
                        ((Form)(object)frmIngresos).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Para poder realizar este movimiento es necesario realizar una apertura de caja.");
                    }
                }
                else if (Permiso())
                {
                    if (Math.Round(saldo_pendiente, 2) >= 0m)
                    {
                        if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                        {
                            return;
                        }
                        string text = Funciones.DigitosAleatorios(10);
                        int[] selectedRows = ((ColumnView)gvPartidas).GetSelectedRows();
                        foreach (Flujo flujo_pagare in this.pago.flujo.Where((Flujo x) => x.tipo_metodo_pago_id >= 9).ToList())
                        {
                            if (!solo_vencidos && !solo_no_vencidos)
                            {
                                MessageBox.Show("Para realizar una renovación seleccione únicamente documentos vencidos o no vencidos.");
                                return;
                            }
                            Documento documento = new Documento();
                            documento.clase = "FA";
                            documento.EstablecerSocio(socio);
                            documento.AgregarPartida((from x in MetodoPago.Tipo.Tipos()
                                                      where x.id == flujo_pagare.tipo_metodo_pago_id
                                                      select x.codigo).First(), flujo_pagare.importe);
                            switch (flujo_pagare.tipo_metodo_pago_id)
                            {
                                case 9:
                                    documento.condicion_pago_id = 11;
                                    break;
                                case 10:
                                    documento.condicion_pago_id = 12;
                                    break;
                                case 11:
                                    documento.condicion_pago_id = 13;
                                    break;
                            }
                            documento.referencia = text;
                            documento.CalcularTotal();
                            if (!documento.Agregar())
                            {
                                MessageBox.Show("No es posible agregar el pagaré de renovación: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                                return;
                            }
                            Funciones.ImprimirInformePredeterminado(documento.clase, documento.id);
                        }
                        for (int i = 0; i < selectedRows.Length; i++)
                        {
                            DataRow dataRow = ((ColumnView)gvPartidas).GetDataRow(selectedRows[i]);
                            Pago.Partida partida = Pago.Partida.Obtener((int)dataRow["id"]);
                            partida.documento_id = (int)dataRow["documento_id"];
                            partida.saldo = (decimal)dataRow["saldo"];
                            partida.fecha_vencimiento = (DateTime)dataRow["fecha_vencimiento"];
                            partida.tipo_cambio = (decimal)dataRow["tipo_cambio"];
                            partida.intereses = (decimal)dataRow["intereses"];
                            partida.importe = (decimal)dataRow["importe"];
                            Flujo flujo = new Flujo();
                            flujo.documento_id = partida.documento_id;
                            flujo.pago_id = (int)dataRow["pago_id"];
                            flujo.codigo = ((solo_vencidos || solo_no_vencidos) ? "INREN" : "INPAG");
                            flujo.referencia = text;
                            flujo.tipo_metodo_pago_id = 1;
                            flujo.importe = partida.importe;
                            if (partida.Actualizar())
                            {
                                if (flujo.Agregar())
                                {
                                    Pago pago = Pago.Obtener(flujo.pago_id);
                                    pago.Actualizar(agregar_sincronizacion: false, actualizar_listas: false);
                                }
                                continue;
                            }
                            MessageBox.Show("No es posible agregar el abono, revise la información y trate nuevamente.");
                            return;
                        }
                        Dictionary<string, object> dictionary = new Dictionary<string, object>();
                        dictionary.Add("referencia", text);
                        Funciones.ImprimirInforme(23, dictionary);
                        MessageBox.Show("Se guardó la información correctamente.");
                        ((Form)this).Close();
                    }
                    else
                    {
                        MessageBox.Show("Para continuar es necesario liquidar el total del importe a pagar.");
                    }
                }
                else
                {
                    MessageBox.Show("No fue posible autorizar este movimiento.");
                }
            }
            catch
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text);
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void CargarPartidas()
        {
            try
            {
                string query = $"SELECT *, (T1.saldo_tmp + T1.intereses) AS saldo, T1.importe_tmp + T1.intereses importe FROM (SELECT *, (CASE WHEN (T0.dias_atraso - T0.dias_tolerancia) > 0 THEN ( T0.saldo_tmp * (((T0.porcentaje_interes_retraso) * (T0.dias_atraso) + (T0.porcentaje_interes_moratorio))) / 100) ELSE T0.intereses_tmp END) intereses FROM (SELECT T0.id id, T0.pago_id, T1.id documento_id, T1.numero_documento, T1.clase, T1.reserva, T1.comentario, T1.fecha_documento, T0.fecha_vencimiento, DATEDIFF(DAY, T0.fecha_vencimiento, GETDATE()) dias_atraso, T3.dias_tolerancia, T4.porcentaje_interes_retraso, T3.porcentaje_interes_moratorio, (CASE WHEN (select financiado from pagos where id = T0.pago_id) = 1 THEN (T0.saldo + T0.intereses) - T0.importe ELSE T0.saldo END) saldo_tmp, T0.tipo_cambio, T1.total, t1.moneda_id, T2.nombre moneda, T1.importe_aplicado, T0.intereses as intereses_tmp, (CASE WHEN (select financiado from pagos where id = T0.pago_id) = 1 THEN (T0.saldo + T0.intereses) - T0.importe ELSE T0.importe END) AS importe_tmp FROM partidas_pagos T0 JOIN documentos T1 ON T0.documento_id = T1.id JOIN monedas T2 ON T1.moneda_id = T2.id JOIN condiciones_pago T3 ON T1.condicion_pago_id = T3.id JOIN socios T4 ON T1.socio_id = T4.id JOIN pagos T5 ON T0.pago_id = T5.id WHERE T5.socio_id = {socio.id} AND T5.financiado = 1) T0) T1 WHERE T1.importe_tmp > 0";
                DataTable dataSource = Utilidades.EjecutarQuery(query);
                gcPartidas.DataSource = dataSource;
                gcPartidas.RefreshDataSource();
                if (pago.id != 0)
                {
                    ((ColumnView)gvPartidas).SelectAll();
                }
                Calcular();
                List<string> list = new List<string>(new string[2] { "FA", "NC" });
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
                    EstablecerSocio();
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
                lblEstadoCredito.Text = string.Format("Límite de crédito: {0} | Disponible: {1}", socio.limite_credito.ToString("c2"), (socio.limite_credito - socio.Balance()).ToString("c2"));
                if (socio.DocumentosVencidos())
                {
                    lblEstadoCredito.ForeColor = Color.Firebrick;
                }
                else
                {
                    lblEstadoCredito.ForeColor = Color.DimGray;
                }
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
            string query = string.Format("SELECT id, codigo, nombre, rfc, (SELECT direccion FROM BloqueDireccion(direccion_facturacion_id)) AS direccion FROM socios WHERE codigo like '%{0}%' OR nombre LIKE '%{0}%'", q.Replace(" ", "%"));
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
            if (e.Control && e.KeyCode == Keys.B)
            {
                pago.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].importe = saldo_pendiente;
                ((BaseView)gvPagos).CloseEditor();
            }
        }

        private void Calcular()
        {
            try
            {
                gcPagos.DataSource = pago.flujo;
                gcPagos.RefreshDataSource();
                int[] selectedRows = ((ColumnView)gvPartidas).GetSelectedRows();
                saldo_pendiente = default(decimal);
                DateTime today = DateTime.Today;
                solo_vencidos = (solo_no_vencidos = true);
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    DataRow dataRow = ((ColumnView)gvPartidas).GetDataRow(selectedRows[i]);
                    today = DateTime.Parse(dataRow["fecha_documento"].ToString());
                    saldo_pendiente += (decimal)dataRow["importe"] * (decimal)dataRow["tipo_cambio"];
                    DateTime dateTime = DateTime.Parse(dataRow["fecha_vencimiento"].ToString());
                    if (dateTime > DateTime.Today)
                    {
                        solo_vencidos = false;
                    }
                    else
                    {
                        solo_no_vencidos = false;
                    }
                }
                pago.Calcular();
                importe_aplicado = pago.total;
                saldo_pendiente = importe_aplicado - saldo_pendiente;
                ((Control)(object)txtSaldoPendiente).Text = saldo_pendiente.ToString("c2");
                ((Control)(object)txtImporteAplicado).Text = importe_aplicado.ToString("c2");
                ((Control)(object)txtTotal).Text = pago.total.ToString("c2");
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
                        pago.flujo[e.RowHandle].importe = TipoCambio.Convertir(pago.moneda_id, tipo.moneda_id, 'C', saldo_pendiente * -1m);
                    }
                    ((ColumnView)gvPagos).FocusedColumn = ((ColumnView)gvPagos).Columns["importe"];
                }
                else if (e.Column.FieldName == "tipo_cambio")
                {
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "MOTCP";
                    autorizacion.referencia = $"Modificar tipo de cambio de {((BaseView)gvPartidas).ActiveEditor.OldEditValue} a {((BaseView)gvPartidas).ActiveEditor.EditValue} al socio {socio.codigo}";
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

        public bool Permiso(bool cancelacion = false)
        {
            try
            {
                Permiso permiso = NoriSDK.Permiso.Obtener(Program.Nori.UsuarioAutenticado.id, "PR", autorizacion: true);
                if (permiso.id != 0 && ((!permiso.agregar && pago.id == 0) || (!permiso.actualizar && pago.id != 0)))
                {
                    Autorizacion autorizacion = new Autorizacion();
                    string text = (cancelacion ? "Cancelación" : ((pago.id != 0) ? "Actualización" : "Creación"));
                    autorizacion.codigo = "CRUDO";
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

        private void lblCodigoSN_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios2 = new frmSocios(socio.id);
            ((Form)(object)frmSocios2).ShowDialog();
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nuevo();
        }

    }
}
