using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmEntregaMercancia : RibbonForm
    {
        private Documento documento = new Documento();

        private Documento pedido = new Documento();

        private Socio socio = new Socio();

        private List<TipoEmpaque> tipos_empaques;

        private List<Documento.Partida> partidas_pedido = new List<Documento.Partida>();

        private List<UnidadMedida> unidades_medida = new List<UnidadMedida>();

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

        private GridView gridView1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPageGeneral;

        private LayoutControlItem layoutControlItem1;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnArticulo;

        private LookUpEdit cbVendedores;

        private HyperlinkLabelControl lblVendedores;

        private MemoEdit txtComentario;

        private LabelControl lblComentario;

        private BarSubItem bbiImprimir;

        private BarButtonItem bbiNuevoSocio;

        private GridColumn gridColumnAlmacen;

        private GridColumn gridColumnComentario;

        private TextEdit txtNumeroDocumento;

        private RepositoryItemLookUpEdit cbAlmacenes;

        private BarSubItem bbiCopiar;

        private BarButtonItem barButtonItemMapaRelaciones;

        private PictureBox pictureBox1;

        private TextEdit txtArticulo;

        private SeparatorControl separatorControl1;

        private BarSubItem bbiPDF;

        private BarButtonItem bbiCorreoPDF;

        private BarStaticItem bbiCancelar;

        private BarStaticItem bbiCerrar;

        private GridColumn gridColumnCodigoBarras;

        private LabelControl lblIdentificadorExterno;

        private BarButtonItem bbiPagar;

        private LabelControl lblReferencia;

        private TextEdit txtReferencia;

        private GridColumn gridColumnCantidadPaquete;

        private GridColumn gridColumnCantidadEmpaque;

        private GridColumn gridColumnTipoEmpaque;

        private RepositoryItemLookUpEdit cbTiposEmpaques;

        private LabelControl lblSocio;

        private LabelControl lblNumeroDocumento;

        private GridColumn gridColumnArticuloID;

        private LabelControl lblNoDocumento;

        private GridColumn gridColumnTipoTara;

        private GridColumn gridColumnUnidadMedida;

        private RepositoryItemLookUpEdit cbUnidadesMedida;

        private BarButtonItem bbiGuardarImprimir;

        private GridColumn gridColumnCantidadPendiente;

        public frmEntregaMercancia(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                txtNumeroDocumento.Text = id.ToString();
                Buscar();
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Inicializar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), Text);
            }
        }

        private void Inicializar()
        {
            documento = new Documento();
            Cargar();
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                pedido.Cerrar();
                Close();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), Text);
            }
        }

        private void Buscar()
        {
            try
            {
                pedido = Documento.ObtenerPorID("PE", int.Parse(txtNumeroDocumento.Text));
                if (pedido.id == 0)
                {
                    pedido = Documento.ObtenerPorID("FA", int.Parse(txtNumeroDocumento.Text));
                }
                if (pedido.id != 0 && pedido.estado.Equals('A'))
                {
                    documento.CopiarDe(pedido, "EN");
                    documento.partidas.ForEach(delegate (Documento.Partida x)
                    {
                        x.cantidad = 0m;
                    });
                    if (Program.Nori.UsuarioAutenticado.almacen_id != 0 && MessageBox.Show("¿Cargar solo partidas del almacén predeterminado para este usuario?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documento.partidas.RemoveAll((Documento.Partida x) => x.almacen_id != Program.Nori.UsuarioAutenticado.almacen_id);
                    }
                    Cargar();
                }
                else
                {
                    Inicializar();
                    MessageBox.Show("El documento solicitado no ha sido encontrado o ya ha sido cerrado.");
                }
            }
            catch
            {
            }
        }

        private void Cargar()
        {
            if (documento.socio_id != 0)
            {
                socio = Socio.Obtener(documento.socio_id);
            }
            lblIdentificadorExterno.Visible = ((documento.identificador_externo != 0) ? true : false);
            lblIdentificadorExterno.Text = documento.identificador_externo.ToString();
            lblNoDocumento.Text = documento.numero_documento.ToString();
            lblSocio.Text = socio.nombre;
            cbVendedores.EditValue = documento.vendedor_id;
            txtReferencia.Text = documento.referencia;
            txtComentario.Text = documento.comentario;
            partidas_pedido = documento.partidas;
            if (documento.partidas.Sum((Documento.Partida x) => x.documento_id) != 0)
            {
                txtArticulo.Focus();
            }
            else
            {
                txtNumeroDocumento.Focus();
            }
            Calcular();
        }

        private void CargarListas()
        {
            string clase = documento.clase;
            tipos_empaques = (from x in TipoEmpaque.TiposEmpaques()
                              where x.activo == true
                              select x).ToList();
            TipoEmpaque tipoEmpaque = new TipoEmpaque
            {
                id = 0,
                nombre = "-- Seleccionar --",
                peso = 0m
            };
            cbVendedores.Properties.DataSource = (from x in Vendedor.Vendedores()
                                                  select new { x.id, x.nombre }).ToList();
            cbVendedores.Properties.ValueMember = "id";
            cbVendedores.Properties.DisplayMember = "nombre";
            cbAlmacenes.DataSource = from x in Almacen.Almacenes()
                                     select new { x.id, x.codigo, x.nombre };
            cbAlmacenes.ValueMember = "id";
            cbAlmacenes.DisplayMember = "nombre";
            unidades_medida = (from x in UnidadMedida.UnidadesMedida()
                               where x.activo == true
                               select x).ToList();
            cbUnidadesMedida.DataSource = unidades_medida;
            cbUnidadesMedida.ValueMember = "id";
            cbUnidadesMedida.DisplayMember = "nombre";
            cbTiposEmpaques.DataSource = tipos_empaques;
            cbTiposEmpaques.ValueMember = "id";
            cbTiposEmpaques.DisplayMember = "nombre";
        }

        private void Calcular()
        {
            gcPartidas.DataSource = documento.partidas;
            gcPartidas.RefreshDataSource();
            documento.CalcularTotal();
        }

        private bool Llenar()
        {
            try
            {
                documento.vendedor_id = (int)cbVendedores.EditValue;
                documento.referencia = txtReferencia.Text;
                documento.comentario = txtComentario.Text;
                if (!documento.partidas.Any((Documento.Partida x) => x.cantidad > 0m))
                {
                    return false;
                }
                return VerificarExistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private bool VerificarExistencias()
        {
            try
            {
                if ((documento.clase.Equals("EN") || documento.clase.Equals("FA") || documento.clase.Equals("TS") || (documento.clase.Equals("PE") && (Program.Nori.Empresa.rfc.Equals("CVR981030480") || Program.Nori.Empresa.rfc.Equals("JAIJ640806EF5")))) && documento.id == 0 && !Program.Nori.Configuracion.venta_articulo_stock_cero)
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
                        // Obtener el SKU del primer artículo con inventario negativo
                        var skuNegativo = documento.partidas
                            .Where(x => x.stock < x.cantidad)
                            .Select(x => x.sku)
                            .FirstOrDefault();

                        // Verificar si se encontró un SKU negativo y mostrar el mensaje
                        if (skuNegativo != null)
                        {
                            MessageBox.Show($"La cantidad recae en un inventario negativo ({skuNegativo}).");
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron partidas con inventario negativo.");
                        }
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                Funciones.DescartarCargando();
            }
        }

        private bool Guardar(bool imprimir = false)
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Llenar())
                    {
                        if (documento.id != 0)
                        {
                            return documento.Actualizar(actualizar_partidas: true);
                        }
                        return documento.Agregar();
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM") + " | Error: " + ex.Message.ToString().Replace("Nori","DTM"), Text);
                return false;
            }
        }

        private void gvPartidas_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "tipo_empaque_id" || e.Column.FieldName == "cantidad_empaque")
                {
                    try
                    {
                        if (Articulo.Articulos().Any((Articulo x) => x.id == documento.partidas[e.RowHandle].articulo_id && x.pesable == true))
                        {
                            var anon = (from x in tipos_empaques
                                        where x.id == documento.partidas[e.RowHandle].tipo_empaque_id && x.activo
                                        select new { x.id, x.peso }).First();
                            documento.partidas[e.RowHandle].tipo_empaque_id = anon.id;
                            documento.partidas[e.RowHandle].cantidad -= documento.partidas[e.RowHandle].cantidad_empaque * anon.peso;
                            documento.partidas[e.RowHandle].CalcularTotal();
                        }
                    }
                    catch
                    {
                    }
                }
                if (e.Column.FieldName == "tipo_tara_id")
                {
                    try
                    {
                        if (Articulo.Articulos().Any((Articulo x) => x.id == documento.partidas[e.RowHandle].articulo_id && x.pesable == true))
                        {
                            var anon2 = (from x in tipos_empaques
                                         where x.id == documento.partidas[e.RowHandle].tipo_tara_id && x.activo
                                         select new { x.id, x.peso }).First();
                            documento.partidas[e.RowHandle].tipo_tara_id = anon2.id;
                            documento.partidas[e.RowHandle].cantidad -= anon2.peso;
                            documento.partidas[e.RowHandle].CalcularTotal();
                        }
                        return;
                    }
                    catch
                    {
                        return;
                    }
                }
                if (e.Column.FieldName == "cantidad")
                {
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "MOCPP";
                    autorizacion.referencia = $"Modificar cantidad al artículo {documento.partidas[e.RowHandle].sku} de {gvPartidas.ActiveEditor.OldEditValue} a {gvPartidas.ActiveEditor.EditValue}";
                    autorizacion.comentario = Interaction.InputBox("Comentario modificar cantidad (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        frmSolicitarAutorizacion2.ShowDialog();
                        autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        documento.partidas[e.RowHandle].cantidad = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                    }
                    if (documento.partidas[e.RowHandle].cantidad > documento.partidas[e.RowHandle].cantidad_pendiente && Articulo.Articulos().Any((Articulo x) => x.id == documento.partidas[e.RowHandle].articulo_id && x.pesable == false))
                    {
                        MessageBox.Show("No es posible entregar más de la cantidad solicitada si el artículo no es pesable.");
                        documento.partidas[e.RowHandle].cantidad = (decimal)gvPartidas.ActiveEditor.OldEditValue;
                    }
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
                else
                {
                    documento.partidas[e.RowHandle].CalcularTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Calcular();
                txtArticulo.Focus();
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
                    autorizacion.referencia = $"Eliminar partida del artículo {documento.partidas[gvPartidas.GetSelectedRows()[0]].sku}";
                    autorizacion.comentario = Interaction.InputBox("Comentario eliminar partida (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        frmSolicitarAutorizacion2.ShowDialog();
                        autorizacion.autorizado = frmSolicitarAutorizacion2.DialogResult == DialogResult.OK;
                    }
                    if (autorizacion.autorizado)
                    {
                        documento.partidas.Remove(documento.partidas[gvPartidas.GetSelectedRows()[0]]);
                    }
                }
                Calcular();
            }
            if (e.Alt && e.KeyCode == Keys.E)
            {
                DataTable resultados = Utilidades.EjecutarQuery($"SELECT codigo AS Almacén, nombre AS [Nombre del almacén], stock AS Stock, comprometido AS Compormetido, pedido AS Pedido, disponible AS Disponible FROM DatosInventario WHERE articulo_id = {documento.partidas[gvPartidas.GetSelectedRows()[0]].articulo_id} AND activo = 1");
                frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(resultados);
                frmResultadosBusqueda2.Text = "Existencias " + documento.partidas[gvPartidas.GetSelectedRows()[0]].sku;
                frmResultadosBusqueda2.ShowDialog();
            }
        }

        private void gvPartidas_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["cantidad"])) == 0.0)
                {
                    e.Appearance.BackColor = Color.Salmon;
                }
                else if (Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["cantidad_pendiente"])) - Convert.ToDouble(gvPartidas.GetRowCellValue(e.RowHandle, gvPartidas.Columns["cantidad"])) <= 0.0)
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                }
                else
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                e.Appearance.BackColor2 = Color.White;
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
                        continue;
                    }
                    gvPartidas.MoveFirst();
                    Documento.Partida partida = documento.partidas.OrderByDescending((Documento.Partida x) => x.fecha_lectura).First();
                    if (partida.documento_id == 0)
                    {
                        MessageBox.Show("El artículo no pertenece al documento original.");
                        documento.partidas.Remove(partida);
                        break;
                    }
                    gvPartidas.MoveBy(gvPartidas.LocateByValue("articulo_id", partida.articulo_id));
                    if (Articulo.Articulos().Any((Articulo x) => x.id == partida.articulo_id && x.pesable == true))
                    {
                        gvPartidas.FocusedColumn = gvPartidas.Columns["cantidad_empaque"];
                        gvPartidas.ShowEditor();
                    }
                    else
                    {
                        txtArticulo.Focus();
                    }
                    Calcular();
                    break;
                }
                while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                txtArticulo.Text = string.Empty;
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
                string query = "SELECT articulos.id, sku as sku_articulo, articulos.nombre, (SELECT TOP 1 inventario.stock FROM inventario WHERE inventario.articulo_id = articulo_id AND inventario.almacen_id = " + Program.Nori.UsuarioAutenticado.almacen_id + ") AS stock, (SELECT dbo.[PrecioNetoArticulo](articulo_id, " + documento.socio_id + ", " + documento.lista_precio_id + ")) AS precio, monedas.codigo as moneda FROM articulos JOIN precios ON precios.articulo_id = articulos.id JOIN monedas ON monedas.id = precios.moneda_id AND precios.lista_precio_id = " + Program.Nori.Configuracion.lista_precio_id + " WHERE (sku = '" + text + "' OR articulos.nombre LIKE '%" + text.Replace(" ", "%") + "%' OR codigo_barras LIKE '%" + text + "%') AND venta = 1 AND articulos.activo = 1";
                DataTable articulos = Utilidades.EjecutarQuery(query);
                if (articulos.Rows.Count > 0)
                {
                    if (articulos.Rows.Count == 1)
                    {
                        AgregarPartida(articulos.Rows[0][1].ToString());
                        return;
                    }
                    frmResultadosBusquedaArticulos frmResultadosBusquedaArticulos2 = new frmResultadosBusquedaArticulos(articulos, seleccion_multiple: true);
                    DialogResult dialogResult = frmResultadosBusquedaArticulos2.ShowDialog();
                    txtArticulo.Text = string.Empty;
                    txtArticulo.Focus();
                    if (dialogResult == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        frmResultadosBusquedaArticulos2.filas.ForEach(delegate (int x)
                        {
                            AgregarPartida(articulos.Rows[x][1].ToString());
                        });
                        Calcular();
                        Cursor = Cursors.Default;
                        txtArticulo.Text = string.Empty;
                        txtArticulo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {text}", Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtArticulo.Text.Length > 0)
            {
                AgregarPartida(txtArticulo.Text);
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtNumeroDocumento.Text.Length > 0)
            {
                Buscar();
            }
        }

        private void gvPartidas_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!documento.partidas[gvPartidas.GetSelectedRows()[0]].Modificable())
            {
                e.Cancel = true;
            }
        }

        private void bbiGuardarImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Funciones.ImprimirInformePredeterminado("EN", documento.id);
                Close();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"), Text);
            }
        }

        private void txtNumeroDocumento_EditValueChanged(object sender, EventArgs e)
        {
        }

    }

}
