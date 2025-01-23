using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmListaPedidosWeb : RibbonForm
    {
        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private RibbonPageGroup ribbonPageGroup1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private GridControl gcDocumentos;

        private GridView gvDocumentos;

        private LayoutControlItem layoutControlItem1;

        private RepositoryItemDateEdit deFecha;

        private RepositoryItemLookUpEdit cbMonedas;

        private LayoutControl layoutControl2;

        private LayoutControlGroup layoutControlGroup2;

        private LayoutControlItem layoutControlItem3;

        private Panel panel1;

        private LayoutControlItem layoutControlItem2;

        private DateEdit deHasta;

        private DateEdit deDesde;

        private ContextMenuStrip contextMenu;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripMenuItem toolStripMenuItem2;

        private LookUpEdit cbEstados;

        private SimpleButton btnImprimir;

        private SimpleButton btnCargar;

        private SimpleButton btnEntregar;

        private SimpleButton btnAbrir;

        private GridColumn gridColumnId;

        private GridColumn gridColumnNumeroDocumento;

        private GridColumn gridColumnFechaDocumento;

        private GridColumn gridColumnFechaVencimiento;

        private GridColumn gridColumnCodigoSN;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnTotal;

        private GridColumn gridColumnCondicionPago;

        private GridColumn gridColumnMetodoPago;

        private GridColumn gridColumnReferencia;

        private GridColumn gridColumnComentario;

        private GridColumn gridColumnImpreso;

        private GridColumn gridColumnAnonimo;

        private GridColumn gridColumnEstado;

        private RepositoryItemLookUpEdit cbSeguimiento;

        private RepositoryItemComboBox cbEstadoSeguimiento;

        private SimpleButton btnPDF;

        private RepositoryItemLookUpEdit leEstadosSeguimiento;

        public frmListaPedidosWeb()
        {
            InitializeComponent();
            this.MetodoDinamico();
            ((BaseEdit)deDesde).EditValue = DateTime.Now;
            ((BaseEdit)deHasta).EditValue = DateTime.Now;
            CargarListas();
        }

        private void CargarListas()
        {
            try
            {
                List<Documento.Estado> list = Documento.Estado.Estados();
                list.Add(new Documento.Estado
                {
                    estado = '*',
                    nombre = "Todos"
                });
                ((RepositoryItemLookUpEditBase)cbEstados.Properties).DataSource = list;
                ((RepositoryItemLookUpEditBase)cbEstados.Properties).ValueMember = "estado";
                ((RepositoryItemLookUpEditBase)cbEstados.Properties).DisplayMember = "nombre";
                ((RepositoryItemLookUpEditBase)leEstadosSeguimiento).DataSource = Utilidades.EjecutarQuery("select id, estado from estados_seguimiento");
                ((RepositoryItemLookUpEditBase)leEstadosSeguimiento).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)leEstadosSeguimiento).DisplayMember = "estado";
            }
            catch
            {
            }
        }

        private void CargarDocumentos()
        {
            try
            {
                string empty = string.Empty;
                char c = (char)((BaseEdit)cbEstados).EditValue;
                char c2 = c;
                string query = string.Format(arg2: (c2 != '*') ? $"AND documentos.estado = '{((BaseEdit)cbEstados).EditValue}'" : string.Empty, format: "SELECT documentos.id, numero_documento, fecha_documento, socios.codigo, socios.nombre, total, condiciones_pago.nombre condicion_pago, metodos_pago.codigo metodo_pago, referencia, comentario, impreso, documentos.anonimo, documentos.fecha_vencimiento, estado_seguimiento FROM documentos INNER JOIN socios ON documentos.socio_id = socios.id LEFT JOIN vendedores ON documentos.vendedor_id = vendedores.id LEFT JOIN condiciones_pago ON condiciones_pago.id = documentos.condicion_pago_id LEFT JOIN metodos_pago ON metodos_pago.id = documentos.metodo_pago_id  LEFT JOIN series ON series.id = documentos.serie_id WHERE documentos.clase = 'PE' AND documentos.web = 1 AND fecha_documento BETWEEN '{0}' AND '{1}' {2}", arg0: ((DateTime)((BaseEdit)deDesde).EditValue).ToString("yyyyMMdd"), arg1: ((DateTime)((BaseEdit)deHasta).EditValue).ToString("yyyyMMdd"));
                gcDocumentos.DataSource = Utilidades.EjecutarQuery(query);
            }
            catch
            {
            }
        }

        private void ImprimirSeleccionados()
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro(a) que deseas imprimir los documentos seleccionados?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                Informe informe = (from x in Informe.Informes()
                                   where x.tipo == "PE" && x.activo == true && x.predeterminado == true
                                   select x).First();
                for (int i = 0; i < ((ColumnView)gvDocumentos).SelectedRowsCount; i++)
                {
                    if (((ColumnView)gvDocumentos).GetSelectedRows()[i] >= 0)
                    {
                        list.Add(((ColumnView)gvDocumentos).GetDataRow(((ColumnView)gvDocumentos).GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    Funciones.ImprimirInforme(informe.id, (int)dataRow["id"], documento: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void PDFSeleccionados()
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro(a) que deseas abrir el PDF de los documentos seleccionados?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                Informe informe = (from x in Informe.Informes()
                                   where x.tipo == "PE" && x.activo == true && x.predeterminado == true
                                   select x).First();
                for (int i = 0; i < ((ColumnView)gvDocumentos).SelectedRowsCount; i++)
                {
                    if (((ColumnView)gvDocumentos).GetSelectedRows()[i] >= 0)
                    {
                        list.Add(((ColumnView)gvDocumentos).GetDataRow(((ColumnView)gvDocumentos).GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    Process.Start(Funciones.PDFInforme(informe.id, (int)dataRow["id"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AbrirSeleccionados()
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro(a) que deseas abrir los documentos seleccionados?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                for (int i = 0; i < ((ColumnView)gvDocumentos).SelectedRowsCount; i++)
                {
                    if (((ColumnView)gvDocumentos).GetSelectedRows()[i] >= 0)
                    {
                        list.Add(((ColumnView)gvDocumentos).GetDataRow(((ColumnView)gvDocumentos).GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    frmDocumentos frmDocumentos2 = new frmDocumentos("PE", (int)dataRow["id"]);
                    ((Form)(object)frmDocumentos2).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void EntregarSeleccionados()
        {
            try
            {
                List<DataRow> list = new List<DataRow>();
                for (int i = 0; i < ((ColumnView)gvDocumentos).SelectedRowsCount; i++)
                {
                    if (((ColumnView)gvDocumentos).GetSelectedRows()[i] >= 0)
                    {
                        list.Add(((ColumnView)gvDocumentos).GetDataRow(((ColumnView)gvDocumentos).GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    frmDocumentos frmDocumentos2 = new frmDocumentos("EN");
                    Documento documento = Documento.Obtener((int)dataRow["id"]);
                    frmDocumentos2.documento.CopiarDe(documento, "EN");
                    if (frmDocumentos2.documento.clase.Equals("EN") && MessageBox.Show("¿Desea realizar una entrega de mercancías diferencial?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.cantidad = 0m;
                        });
                        if (Program.dtm.UsuarioAutenticado.almacen_id != 0 && MessageBox.Show("¿Cargar solo partidas del almacén predeterminado para este usuario?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            frmDocumentos2.documento.partidas.RemoveAll((Documento.Partida x) => x.almacen_id != Program.dtm.UsuarioAutenticado.almacen_id);
                        }
                    }
                    try
                    {
                        frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.CalcularTotal();
                            x.ObtenerStock();
                        });
                    }
                    catch
                    {
                    }
                    frmDocumentos2.Cargar(nuevo: true);
                    ((Control)(object)frmDocumentos2).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cbClases_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDocumentos();
            }
            catch
            {
            }
        }

        private void frmListaPedidosWebAbiertas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                ImprimirSeleccionados();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                CargarDocumentos();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                EntregarSeleccionados();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                AbrirSeleccionados();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.Format("{0}\\{1}.xlsx", Program.dtm.Configuracion.directorio_documentos, "ListaPartidasAbiertas");
                gcDocumentos.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.Format("{0}\\{1}.pdf", Program.dtm.Configuracion.directorio_documentos, "ListaPartidasAbiertas");
                gcDocumentos.ExportToPdf(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDocumentos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirSeleccionados();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirSeleccionados();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            EntregarSeleccionados();
        }

        private void cbWeb_EditValueChanged(object sender, EventArgs e)
        {
            CargarDocumentos();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDFSeleccionados();
        }

        private void gvDocumentos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "estado_seguimiento")
                {
                    DataRow dataRow = ((ColumnView)gvDocumentos).GetDataRow(e.RowHandle);
                    ((BaseView)gvDocumentos).CloseEditor();
                    int result = 0;
                    int num = int.Parse(dataRow["estado_seguimiento"].ToString());
                    int.TryParse(dataRow["id"].ToString(), out result);
                    if (num == 6 && MessageBox.Show("¿Estas seguro(a) que deseas cancelar el pedido?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Documento documento = Documento.Obtener(result);
                        documento.Cancelar((documento.identificador_externo != 0) ? true : false);
                    }
                    Utilidades.EjecutarQuery($"update documentos set estado_seguimiento = {num} where id = {result}");
                    LlamarWebhook(result, num);
                    MessageBox.Show("Se actualizó el registro correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar " + ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private static async Task LlamarWebhook(int documento_id, int estado_seguimiento_id)
        {
            string url = $"https://blancfloreria.com.mx/webhook?documento_id={documento_id}&estado_seguimiento_id={estado_seguimiento_id}";
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Respuesta del servidor:");
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"La petición falló con el código de estado: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                HttpRequestException e = ex;
                Console.WriteLine("Error al realizar la petición: " + e.Message);
            }
        }


    }

}
