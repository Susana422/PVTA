using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Microsoft.VisualBasic;
using NoriSDK;


namespace NORI
{
    public partial class frmMediosPago : RibbonForm
    {
        internal Documento documento;

        internal Socio socio;

        internal List<MetodoPago.Tipo> tipos_metodos_pago;

        internal List<CondicionesPago> condiciones_pago;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private Button btnCancelar;

        private Button btnAceptar;

        private Label lblDescuento;

        private Label lblTotal;

        private Label lblTotal_;

        private Label lblDescuento_;

        private Label lblSubTotal;

        private Label lblImpuesto;

        private Label lblImpuesto_;

        private GridControl gcPagos;

        private GridView gvPagos;

        private GridColumn gridColumnID;

        private GridColumn gridColumnMetodoPago;

        private RepositoryItemLookUpEdit cbMetodosPago;

        private GridColumn gridColumnTC;

        private GridColumn gridColumnReferencia;

        private GridColumn gridColumnImporte;

        private GridColumn gridColumnTotal;

        private SeparatorControl separatorControl1;

        private Label lblTotalAplicado;

        private Label lblTotalAplicado_;

        private Label lblDiferencia;

        private Label lblDiferencia_;

        private Label lblSubTotal_;

        private StatusStrip ssGeneral;

        private ToolStripStatusLabel lblLimiteCredito;

        private ToolStripStatusLabel toolStripStatusLabel1;

        private ToolStripStatusLabel lblCreditoDisponible;

        private LookUpEdit cbUsoPrincipal;

        private LabelControl lblUsoPrincipal;

        private Label lblClaseDocumento;

        private Label lblNombre;

        private LabelControl lblCondicionPago;

        private LookUpEdit cbCondicionesPago;

        private SimpleButton btnAgregarFormaPago;

        public frmMediosPago(Documento documento, Socio socio)
        {
            InitializeComponent();
            this.MetodoDinamico();
            this.documento = documento;
            this.socio = socio;
            if (socio.eventual)
            {
                socio.limite_credito = 1m;
            }
            lblNombre.Text = socio.nombre;
            lblClaseDocumento.Text = (from x in Documento.Clase.Clases()
                                      where x.clase == documento.clase
                                      select x).First().nombre;
            CargarListas();
            lblLimiteCredito.Text = "Límite de crédito: " + socio.limite_credito.ToString("c2");
            lblCreditoDisponible.Text = "Crédito disponible: " + (socio.limite_credito - socio.Balance()).ToString("c2");
            ((Control)(object)cbCondicionesPago).Enabled = ((socio.limite_credito > 0m) ? true : false);
            if (documento.flujo.Count == 0)
            {
                Nuevo();
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
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DataSource = Documento.UsoCFDI.UsosCFDI();
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).ValueMember = "uso";
            ((RepositoryItemLookUpEditBase)cbUsoPrincipal.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbUsoPrincipal).EditValue = documento.uso_principal;
            condiciones_pago = (from x in CondicionesPago.CondicionesPagos()
                                where x.activo == true && x.financiado == true && (x.limite_maximo == 0m || documento.total >= x.limite_maximo)
                                select x).ToList();
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DataSource = condiciones_pago;
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbCondicionesPago.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbCondicionesPago).EditValue = documento.condicion_pago_id;
            Calcular();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                documento.uso_principal = ((BaseEdit)cbUsoPrincipal).EditValue.ToString();
                bool flag = false;
                try
                {
                    if (((Control)(object)cbCondicionesPago).Enabled)
                    {
                        documento.condicion_pago_id = (((BaseEdit)cbCondicionesPago).EditValue.IsNullOrEmpty() ? documento.condicion_pago_id : ((int)((BaseEdit)cbCondicionesPago).EditValue));
                        if (condiciones_pago.Where((CondicionesPago x) => x.id == documento.condicion_pago_id).First().financiado)
                        {
                            flag = true;
                            documento.clase = "FA";
                        }
                    }
                }
                catch
                {
                }
                if (Math.Round(documento.importe_aplicado, 2) >= Math.Round(documento.total, 2) || (documento.importe_aplicado > 0m && documento.reserva))
                {
                    try
                    {
                        Flujo flujo_metodo_pago = documento.flujo.OrderByDescending((Flujo x) => x.importe * x.tipo_cambio).First();
                        documento.metodo_pago_id = (from x in tipos_metodos_pago
                                                    where x.id == flujo_metodo_pago.tipo_metodo_pago_id
                                                    select x.metodo_pago_id).First();
                    }
                    catch
                    {
                    }
                    if (documento.importe_aplicado >= documento.total)
                    {
                        documento.importe_aplicado = documento.total;
                    }
                    ((Form)this).DialogResult = DialogResult.OK;
                }
                else
                {
                    if (!(socio.limite_credito > 0m) || documento.flujo.Count != 0 || documento.socio_id == Program.Nori.UsuarioAutenticado.socio_id)
                    {
                        return;
                    }
                    try
                    {
                        documento.metodo_pago_id = (from x in MetodoPago.MetodosPago()
                                                    where x.codigo == "99"
                                                    select x.id).First();
                    }
                    catch
                    {
                    }
                    if (MessageBox.Show("Este documento será guardado a crédito, ¿desea continuar?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    if (!flag && MessageBox.Show("¿Desea quitar los descuentos aplicados?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.porcentaje_descuento = 0m;
                        });
                        documento.RecalcularTotalPartidas(actualizar_precios: false);
                    }
                    decimal num = socio.limite_credito - socio.Balance();
                    bool flag2 = socio.DocumentosVencidos();
                    int num2 = (from x in CondicionesPago.CondicionesPagos()
                                where x.id == documento.condicion_pago_id
                                select x.dias_extra).First();
                    if ((documento.total > num || flag2) && num2 > 0)
                    {
                        Autorizacion autorizacion = new Autorizacion();
                        string text = (flag2 ? "(Documentos vencidos)" : "");
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
                        autorizacion.comentario = Interaction.InputBox("Comentario venta a crédito (Opcional)");
                        autorizacion.Agregar();
                        if (!autorizacion.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                            ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                            autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                        }
                        if (autorizacion.autorizado)
                        {
                            ((Form)this).DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No se autorizó este movimiento.");
                        }
                    }
                    else
                    {
                        ((Form)this).DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

        private void gvPagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (documento.flujo.Count > 0)
                {
                    documento.flujo.Remove(documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]]);
                }
                Calcular();
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
                documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].importe = documento.total;
                ((BaseView)gvPagos).CloseEditor();
            }
            if (e.KeyCode == Keys.Return)
            {
                documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].importe = documento.total;
                ((BaseView)gvPagos).CloseEditor();
            }
        }

        private void gvPagos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "tipo_metodo_pago_id")
                {
                    MetodoPago.Tipo tipo = tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == documento.flujo[e.RowHandle].tipo_metodo_pago_id).First();
                    if (tipo.referencia)
                    {
                        documento.flujo[e.RowHandle].referencia = Interaction.InputBox("Ingresar referencia", ((Control)(object)this).Text);
                    }
                    else
                    {
                        documento.flujo[e.RowHandle].referencia = string.Empty;
                    }
                    if (tipo.documento)
                    {
                        SolicitarDocumento();
                    }
                    documento.flujo[e.RowHandle].EstablecerTipoCambio();
                    if (documento.moneda_id != tipo.moneda_id || (!tipo.cambio && !tipo.documento))
                    {
                        documento.flujo[e.RowHandle].importe = TipoCambio.Convertir(documento.moneda_id, tipo.moneda_id, 'C', documento.total - documento.importe_aplicado);
                    }
                    if (Program.Nori.Configuracion.tipo_metodo_pago_monedero_id == documento.flujo[e.RowHandle].tipo_metodo_pago_id)
                    {
                        PagoMonedero();
                        documento.flujo.Remove(documento.flujo[e.RowHandle]);
                    }
                    ((ColumnView)gvPagos).FocusedColumn = ((ColumnView)gvPagos).Columns["importe"];
                }
                else if (e.Column.FieldName == "importe")
                {
                    decimal num = Math.Round(documento.total, 2) - Math.Round(documento.importe_aplicado, 2);
                    List<int> pagos_agregados = documento.flujo.Select((Flujo x) => x.tipo_metodo_pago_id).ToList();
                    decimal num2 = documento.flujo[e.RowHandle].tipo_cambio * documento.flujo[e.RowHandle].importe;
                    bool flag = tipos_metodos_pago.Any((MetodoPago.Tipo x) => pagos_agregados.Contains(x.id) && x.cambio);
                    if (!flag && !tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == documento.flujo[e.RowHandle].tipo_metodo_pago_id).First().cambio)
                    {
                        if (num2 > num)
                        {
                            documento.flujo[e.RowHandle].importe = 0m;
                            MessageBox.Show("No se puede ingresar un importe mayor que la diferencia restante");
                        }
                    }
                    else if (!tipos_metodos_pago.Where((MetodoPago.Tipo x) => x.id == documento.flujo[e.RowHandle].tipo_metodo_pago_id).First().cambio && num2 > num && !flag)
                    {
                        documento.flujo[e.RowHandle].importe = 0m;
                        MessageBox.Show("No se puede ingresar un importe mayor que la diferencia restante");
                    }
                }
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void SolicitarDocumento()
        {
            try
            {
                DateTime fecha = new DateTime(1753, 1, 1);
                if (socio.id == Program.Nori.UsuarioAutenticado.socio_id)
                {
                    fecha = DateTime.Today;
                }
                var list = (from x in Documento.Documentos()
                            where x.estado == 'A' && x.clase == "NC" && x.socio_id == socio.id && x.fecha_documento >= fecha
                            select new
                            {
                                id = x.id,
                                numero_documento = x.numero_documento,
                                total = x.total,
                                disponible = x.total - x.importe_aplicado,
                                fecha = x.fecha_documento
                            }).ToList();
                if (list.Count > 0)
                {
                    frmResultadosBusqueda f = new frmResultadosBusqueda(list.ToDataTable());
                    DialogResult dialogResult = ((Form)(object)f).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        var anon = list.Where(x => x.id == f.id).First();
                        decimal num = Math.Round(documento.total, 2) - Math.Round(documento.importe_aplicado, 2);
                        if (anon.disponible >= num)
                        {
                            documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].importe = num;
                        }
                        else
                        {
                            documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].importe = anon.disponible;
                        }
                        documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].referencia = anon.id.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Este socio no tiene notas de crédito disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Calcular()
        {
            gcPagos.DataSource = documento.flujo;
            gcPagos.RefreshDataSource();
            documento.CalcularTotal();
            lblSubTotal.Text = documento.subtotal.ToString("C");
            lblDescuento.Text = documento.descuento.ToString("C");
            lblImpuesto.Text = documento.impuesto.ToString("C");
            lblTotal.Text = documento.total.ToString("C");
            lblTotalAplicado.Text = documento.importe_aplicado.ToString("C");
            decimal num = Math.Round(documento.total, 2) - Math.Round(documento.importe_aplicado, 2);
            if ((double)num <= 0.0 || documento.reserva)
            {
                lblDiferencia_.Text = "Cambio";
                decimal num2 = num * -1m;
                lblDiferencia.Text = num2.ToString("C");
                btnAceptar.Enabled = true;
            }
            else
            {
                lblDiferencia_.Text = "Restante";
                lblDiferencia.Text = num.ToString("C");
                btnAceptar.Enabled = false;
            }
            if (socio.limite_credito > 0m)
            {
                btnAceptar.Enabled = true;
            }
            if (condiciones_pago.Count > 0)
            {
                if (documento.flujo.Count == 0 || documento.reserva)
                {
                    ((Control)(object)cbCondicionesPago).Enabled = true;
                }
                else
                {
                    ((Control)(object)cbCondicionesPago).Enabled = false;
                }
            }
            else
            {
                ((Control)(object)cbCondicionesPago).Enabled = false;
            }
        }

        private void Nuevo()
        {
            try
            {
                decimal num = Math.Round(documento.total, 2) - Math.Round(documento.importe_aplicado, 2);
                if (num > 0m)
                {
                    documento.AgregarPago();
                    Calcular();
                }
                else
                {
                    MessageBox.Show("No es posible agregar otro pago debido a que ya se ha liquidado el total del documento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((BaseView)gvPagos).Focus();
                ((ColumnView)gvPagos).MoveLast();
                ((ColumnView)gvPagos).FocusedColumn = ((documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].tipo_metodo_pago_id == 0) ? ((ColumnView)gvPagos).Columns["tipo_metodo_pago_id"] : ((ColumnView)gvPagos).Columns["importe"]);
            }
        }

        private void PagoMonedero()
        {
            try
            {
                if (Program.Nori.Configuracion.tipo_metodo_pago_monedero_id != 0)
                {
                    string text = Interaction.InputBox("Ingresa el folio del monedero electrónico", "Monedero electrónico");
                    Monedero monedero = Monedero.Obtener(text);
                    if (monedero.socio_id == documento.socio_id)
                    {
                        if (monedero.saldo > 0m)
                        {
                            decimal num = decimal.Parse(Interaction.InputBox(string.Format("Folio {0}\r\nSaldo disponible: {1}", text, monedero.saldo.ToString("c2")), "Importe", Math.Round(documento.total, 2).ToString()));
                            if (num <= Math.Round(monedero.saldo, 2))
                            {
                                if (num <= Math.Round(documento.total, 2))
                                {
                                    documento.AgregarPago(Program.Nori.Configuracion.tipo_metodo_pago_monedero_id, num, text.ToString());
                                    Calcular();
                                }
                                else
                                {
                                    MessageBox.Show("El importe no puede ser mayor al total del documento.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El importe no puede ser mayor que el saldo del monedero.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No cuenta con saldo suficiente para realizar esta operación.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El socio del monedero y el socio del documento son distintos.");
                    }
                }
                else
                {
                    MessageBox.Show("Aún no esta configurado el tipo de método de pago para monedero electrónico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frmPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.P)
            {
                ((BaseView)gvPagos).Focus();
            }
        }

        private void frmPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                Nuevo();
            }
            if (e.KeyCode == Keys.Insert)
            {
                Nuevo();
            }
            if (e.Control && e.KeyCode == Keys.M)
            {
                PagoMonedero();
            }
            if (e.Shift && e.KeyCode == Keys.C)
            {
                NORI.PuntoVenta.frmCanjes frmCanjes = new NORI.PuntoVenta.frmCanjes();
                ((Form)(object)frmCanjes).ShowDialog();
            }
        }

        private void gvPagos_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (tipos_metodos_pago.Any((MetodoPago.Tipo x) => x.id == documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].tipo_metodo_pago_id && x.documento) || (documento.flujo[((ColumnView)gvPagos).GetSelectedRows()[0]].tipo_metodo_pago_id == Program.Nori.Configuracion.tipo_metodo_pago_monedero_id && Program.Nori.Configuracion.tipo_metodo_pago_monedero_id != 0))
                {
                    e.Cancel = true;
                }
            }
            catch
            {
            }
        }

        private void frmPagos_Activated(object sender, EventArgs e)
        {
            ((BaseView)gvPagos).Focus();
        }

        private void btnAgregarFormaPago_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

     
    }

}
