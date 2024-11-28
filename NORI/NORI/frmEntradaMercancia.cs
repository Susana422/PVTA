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
    public partial class frmEntradaMercancia : RibbonForm
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

        public frmEntradaMercancia(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
            if (id != 0)
            {
                ((Control)(object)txtNumeroDocumento).Text = id.ToString();
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
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
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
                ((Form)this).Close();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
            }
        }

        private void Buscar()
        {
            try
            {
                pedido = Documento.ObtenerPorID("OC", int.Parse(((Control)(object)txtNumeroDocumento).Text));
                if (pedido.id != 0 && pedido.estado.Equals('A'))
                {
                    documento.CopiarDe(pedido, "EM");
                    documento.partidas.ForEach(delegate (Documento.Partida x)
                    {
                        x.cantidad = 0m;
                    });
                    if (Program.Nori.UsuarioAutenticado.almacen_id != 0 && MessageBox.Show("¿Cargar solo partidas del almacén predeterminado para este usuario?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documento.partidas.RemoveAll((Documento.Partida x) => x.almacen_id != Program.Nori.UsuarioAutenticado.almacen_id);
                    }
                    Cargar();
                }
                else
                {
                    Inicializar();
                    MessageBox.Show("El pedido solicitado no ha sido encontrado o ya ha sido cerrado.");
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
            ((Control)(object)lblIdentificadorExterno).Visible = ((documento.identificador_externo != 0) ? true : false);
            ((Control)(object)lblIdentificadorExterno).Text = documento.identificador_externo.ToString();
            ((Control)(object)lblNoDocumento).Text = documento.numero_documento.ToString();
            ((Control)(object)lblSocio).Text = socio.nombre;
            ((BaseEdit)cbVendedores).EditValue = documento.vendedor_id;
            ((Control)(object)txtReferencia).Text = documento.referencia;
            ((Control)(object)txtComentario).Text = documento.comentario;
            partidas_pedido = documento.partidas;
            if (documento.partidas.Sum((Documento.Partida x) => x.documento_id) != 0)
            {
                ((Control)(object)txtArticulo).Focus();
            }
            else
            {
                ((Control)(object)txtNumeroDocumento).Focus();
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
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DataSource = (from x in Vendedor.Vendedores()
                                                                                  select new { x.id, x.nombre }).ToList();
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbAlmacenes).DataSource = from x in Almacen.Almacenes()
                                                                     select new { x.id, x.codigo, x.nombre };
            ((RepositoryItemLookUpEditBase)cbAlmacenes).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbAlmacenes).DisplayMember = "nombre";
            unidades_medida = (from x in UnidadMedida.UnidadesMedida()
                               where x.activo == true
                               select x).ToList();
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DataSource = unidades_medida;
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbUnidadesMedida).DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)cbTiposEmpaques).DataSource = tipos_empaques;
            ((RepositoryItemLookUpEditBase)cbTiposEmpaques).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbTiposEmpaques).DisplayMember = "nombre";
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
                documento.vendedor_id = (int)((BaseEdit)cbVendedores).EditValue;
                documento.referencia = ((Control)(object)txtReferencia).Text;
                documento.comentario = ((Control)(object)txtComentario).Text;
                if (!documento.partidas.Any((Documento.Partida x) => x.cantidad > 0m))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private bool Guardar(bool imprimir = false)
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message + " | Error: " + ex.Message, ((Control)(object)this).Text);
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
                    autorizacion.referencia = $"Modificar cantidad al artículo {documento.partidas[e.RowHandle].sku} de {((BaseView)gvPartidas).ActiveEditor.OldEditValue} a {((BaseView)gvPartidas).ActiveEditor.EditValue}";
                    autorizacion.comentario = Interaction.InputBox("Comentario modificar cantidad (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        documento.partidas[e.RowHandle].cantidad = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
                    }
                    if (documento.partidas[e.RowHandle].cantidad > documento.partidas[e.RowHandle].cantidad_pendiente && Articulo.Articulos().Any((Articulo x) => x.id == documento.partidas[e.RowHandle].articulo_id && x.pesable == false))
                    {
                        MessageBox.Show("No es posible entregar más de la cantidad solicitada si el artículo no es pesable.");
                        documento.partidas[e.RowHandle].cantidad = (decimal)((BaseView)gvPartidas).ActiveEditor.OldEditValue;
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
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Calcular();
                ((Control)(object)txtArticulo).Focus();
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
                    autorizacion.comentario = Interaction.InputBox("Comentario eliminar partida (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion2 = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion2).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion2).DialogResult == DialogResult.OK;
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
                DataTable resultados = Utilidades.EjecutarQuery($"SELECT codigo AS Almacén, nombre AS [Nombre del almacén], stock AS Stock, comprometido AS Compormetido, pedido AS Pedido, disponible AS Disponible FROM DatosInventario WHERE articulo_id = {documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].articulo_id} AND activo = 1");
                frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(resultados);
                ((Control)(object)frmResultadosBusqueda2).Text = "Existencias " + documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].sku;
                ((Form)(object)frmResultadosBusqueda2).ShowDialog();
            }
        }

        private void gvPartidas_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (((RowEventArgs)e).RowHandle >= 0)
            {
                if (Convert.ToDouble(((ColumnView)gvPartidas).GetRowCellValue(((RowEventArgs)e).RowHandle, ((ColumnView)gvPartidas).Columns["cantidad"])) == 0.0)
                {
                    e.Appearance.BackColor = Color.Salmon;
                }
                else if (Convert.ToDouble(((ColumnView)gvPartidas).GetRowCellValue(((RowEventArgs)e).RowHandle, ((ColumnView)gvPartidas).Columns["cantidad_pendiente"])) - Convert.ToDouble(((ColumnView)gvPartidas).GetRowCellValue(((RowEventArgs)e).RowHandle, ((ColumnView)gvPartidas).Columns["cantidad"])) <= 0.0)
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
                    ((ColumnView)gvPartidas).MoveFirst();
                    Documento.Partida partida = documento.partidas.OrderByDescending((Documento.Partida x) => x.fecha_lectura).First();
                    if (partida.documento_id == 0)
                    {
                        MessageBox.Show("El artículo no pertenece al documento original.");
                        documento.partidas.Remove(partida);
                        break;
                    }
                    ((ColumnView)gvPartidas).MoveBy(((ColumnView)gvPartidas).LocateByValue("articulo_id", (object)partida.articulo_id, Array.Empty<OperationCompleted>()));
                    if (Articulo.Articulos().Any((Articulo x) => x.id == partida.articulo_id && x.pesable == true))
                    {
                        ((ColumnView)gvPartidas).FocusedColumn = ((ColumnView)gvPartidas).Columns["cantidad_empaque"];
                        ((BaseView)gvPartidas).ShowEditor();
                    }
                    else
                    {
                        ((Control)(object)txtArticulo).Focus();
                    }
                    Calcular();
                    break;
                }
                while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                ((Control)(object)txtArticulo).Text = string.Empty;
            }
        }

        private void txtArticulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Tab || ((Control)(object)txtArticulo).Text.Length <= 0)
                {
                    return;
                }
                string text = ((Control)(object)txtArticulo).Text;
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
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusquedaArticulos2).ShowDialog();
                    ((Control)(object)txtArticulo).Text = string.Empty;
                    ((Control)(object)txtArticulo).Focus();
                    if (dialogResult == DialogResult.OK)
                    {
                        ((Control)(object)this).Cursor = Cursors.WaitCursor;
                        frmResultadosBusquedaArticulos2.filas.ForEach(delegate (int x)
                        {
                            AgregarPartida(articulos.Rows[x][1].ToString());
                        });
                        Calcular();
                        ((Control)(object)this).Cursor = Cursors.Default;
                        ((Control)(object)txtArticulo).Text = string.Empty;
                        ((Control)(object)txtArticulo).Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontraron resultados para {text}", ((Control)(object)this).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtArticulo).Text.Length > 0)
            {
                AgregarPartida(((Control)(object)txtArticulo).Text);
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtNumeroDocumento).Text.Length > 0)
            {
                Buscar();
            }
        }

        private void gvPartidas_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!documento.partidas[((ColumnView)gvPartidas).GetSelectedRows()[0]].Modificable())
            {
                e.Cancel = true;
            }
        }

        private void bbiGuardarImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Funciones.ImprimirInformePredeterminado("EN", documento.id);
                ((Form)this).Close();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message, ((Control)(object)this).Text);
            }
        }

      
    }

}
