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
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NoriSAPB1SDK;
using NoriSDK;

namespace NORI
{
    public partial class frmListaPartidas : RibbonForm
    {
        private List<Documento.Clase> clases = new List<Documento.Clase>();

        private List<Vendedor> vendedores = new List<Vendedor>();

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

        private LookUpEdit cbVendedores;

        private LookUpEdit cbClases;

        private DateEdit deHasta;

        private DateEdit deDesde;

        private LookUpEdit cbSocios;

        private ContextMenuStrip contextMenu;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripMenuItem toolStripMenuItem2;

        private LookUpEdit cbEstados;

        private SimpleButton btnImprimir;

        private SimpleButton btnCargar;

        private SimpleButton btnEntregar;

        private SimpleButton btnAbrir;

        private SimpleButton btnFacturar;

        private CheckEdit cbWeb;

        public frmListaPartidas()
        {
            InitializeComponent();
            this.MetodoDinamico();
            deDesde.EditValue = DateTime.Now;
            deHasta.EditValue = DateTime.Now;
            CargarListas();
            if (Program.Nori.Empresa.rfc == "DDI061212TX1")
            {
                ((Control)btnImprimir).Visible = false;
                ((Control)btnFacturar).Visible = false;
                ((Control)btnEntregar).Visible = false;
            }
        }

        private void CargarListas()
        {
            try
            {
                clases = Documento.Clase.Clases();
                Vendedor vendedor = new Vendedor();
                vendedor.nombre = "Todos";
                vendedores.Add(vendedor);
                vendedores.AddRange((from x in Vendedor.Vendedores()
                                     where x.activo == true
                                     select x).ToList());
                cbVendedores.Properties.DataSource = vendedores;
                cbVendedores.Properties.ValueMember = "id";
                cbVendedores.Properties.DisplayMember = "nombre";
                cbClases.Properties.DataSource = clases;
                cbClases.Properties.ValueMember = "clase";
                cbClases.Properties.DisplayMember = "nombre";
                List<Documento.Estado> list = Documento.Estado.Estados();
                list.Add(new Documento.Estado
                {
                    estado = '*',
                    nombre = "Todos"
                });
                cbEstados.Properties.DataSource = list;
                cbEstados.Properties.ValueMember = "estado";
                cbEstados.Properties.DisplayMember = "nombre";
                var list2 = (from x in Socio.Socios()
                             where x.activo == true
                             select new { x.id, x.codigo, x.nombre }).ToList();
                list2.Add(new
                {
                    id = 0,
                    codigo = "NA",
                    nombre = "Todos"
                });
                cbSocios.Properties.DataSource = list2;
                cbSocios.Properties.ValueMember = "id";
                cbSocios.Properties.DisplayMember = "nombre";
                cbClases.EditValue = "PE";
                cbEstados.EditValue = 'A';
                cbVendedores.EditValue = 0;
                cbSocios.EditValue = 0;
            }
            catch
            {
            }
        }

        private void CargarDocumentos()
        {
            try
            {
                string text = ((Program.Nori.Configuracion.seleccionar_sucursal && Program.Nori.UsuarioAutenticado.rol != 'A') ? $"AND documentos.serie_id in (select id from series where almacen_id = {Program.Nori.UsuarioAutenticado.almacen_id})" : string.Empty);
                string text2 = (cbWeb.Checked ? "AND documentos.web = 1" : string.Empty);
                var xx= cbVendedores.EditValue;
                string text3 = string.Empty;
                if (cbVendedores.EditValue != null) {
                   text3 = (((int)cbVendedores.EditValue == 0) ? string.Empty : $"AND documentos.vendedor_id = {(int)cbVendedores.EditValue}");
                }

                string text4 = string.Empty;
                try
                {
                    if (cbSocios.EditValue != null) {
                        text4 = (((int)cbSocios.EditValue == 0) ? string.Empty : string.Format("AND (documentos.socio_id = {0} OR socios.socio_eventual_id = {0})", (int)cbSocios.EditValue));
                    }
                   
                }
                catch
                {
                }
                string empty = string.Empty;
                char c = 'A';
                if (cbEstados.EditValue != null) {
                    c = (char)cbEstados.EditValue;
                }
                char c2 = c;
                empty = ((c2 != '*') ? $"AND documentos.estado = '{cbEstados.EditValue}'" : string.Empty);
                string query = string.Format("SELECT documentos.id ID, series.nombre Serie, numero_documento 'N° Documento', fecha_documento Fecha, cast(documentos.fecha_creacion as time) Hora, socios.codigo 'Codigo SN', socios.nombre Nombre, total Total, (select sum(peso) from partidas where partidas.documento_id = documentos.id) as Peso ,condiciones_pago.nombre CondicionPago, metodos_pago.codigo MetodoPago, vendedores.nombre Vendedor, referencia Referencia, impreso Impreso, documentos.foraneo Foraneo, documentos.fecha_actualizacion 'Fecha actualización' FROM documentos INNER JOIN socios ON documentos.socio_id = socios.id LEFT JOIN vendedores ON documentos.vendedor_id = vendedores.id LEFT JOIN condiciones_pago ON condiciones_pago.id = documentos.condicion_pago_id LEFT JOIN metodos_pago ON metodos_pago.id = documentos.metodo_pago_id  LEFT JOIN series ON series.id = documentos.serie_id WHERE documentos.clase = '{0}' AND fecha_documento BETWEEN '{1}' AND '{2}' {3} {4} {5} {6} {7}", cbClases.EditValue, ((DateTime)deDesde.EditValue).ToString("yyyyMMdd"), ((DateTime)deHasta.EditValue).ToString("yyyyMMdd"), empty, text3, text4, text2, text);
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
                if (MessageBox.Show("¿Estas seguro(a) que deseas imprimir los documentos seleccionados?", ((Control)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                Informe informe = (from x in Informe.Informes()
                                   where x.tipo == (string)((BaseEdit)cbClases).EditValue && x.activo == true && x.predeterminado == true
                                   select x).First();
                for (int i = 0; i < gvDocumentos.SelectedRowsCount; i++)
                {
                    if (gvDocumentos.GetSelectedRows()[i] >= 0)
                    {
                        list.Add(gvDocumentos.GetDataRow(gvDocumentos.GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    Funciones.ImprimirInforme(informe.id, (int)dataRow["ID"], documento: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AbrirSeleccionados()
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro(a) que deseas abrir los documentos seleccionados?", ((Control)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                for (int i = 0; i < gvDocumentos.SelectedRowsCount; i++)
                {
                    if (gvDocumentos.GetSelectedRows()[i] >= 0)
                    {
                        list.Add(gvDocumentos.GetDataRow(gvDocumentos.GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    frmDocumentos frmDocumentos2 = new frmDocumentos((string)cbClases.EditValue, (int)dataRow["ID"]);
                    ((Form)frmDocumentos2).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void EntregarSeleccionados()
        {
            try
            {
                if (!cbClases.EditValue.Equals("PE"))
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                for (int i = 0; i < gvDocumentos.SelectedRowsCount; i++)
                {
                    if (gvDocumentos.GetSelectedRows()[i] >= 0)
                    {
                        list.Add(gvDocumentos.GetDataRow(gvDocumentos.GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    frmDocumentos frmDocumentos2 = new frmDocumentos("EN");
                    Documento documento = Documento.Obtener((int)dataRow["ID"]);
                    frmDocumentos2.documento.CopiarDe(documento, "EN");
                    if (frmDocumentos2.documento.clase.Equals("EN") && MessageBox.Show("¿Desea realizar una entrega de mercancías diferencial?", ((Control)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        frmDocumentos2.documento.partidas.ForEach(delegate (Documento.Partida x)
                        {
                            x.cantidad = 0m;
                        });
                        if (Program.Nori.UsuarioAutenticado.almacen_id != 0 && MessageBox.Show("¿Cargar solo partidas del almacén predeterminado para este usuario?", ((Control)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            frmDocumentos2.documento.partidas.RemoveAll((Documento.Partida x) => x.almacen_id != Program.Nori.UsuarioAutenticado.almacen_id);
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
                    ((Control)frmDocumentos2).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void FacturarSeleccionados()
        {
            try
            {
                if (!cbClases.EditValue.Equals("EN") || cbSocios.EditValue.Equals("0") || MessageBox.Show("¿Estas seguro(a) que deseas facturar los documentos seleccionados?", ((Control)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                List<int> ids = new List<int>();
                for (int i = 0; i < gvDocumentos.SelectedRowsCount; i++)
                {
                    if (gvDocumentos.GetSelectedRows()[i] >= 0)
                    {
                        list.Add(gvDocumentos.GetDataRow(gvDocumentos.GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    ids.Add((int)dataRow["ID"]);
                }
                Documento documento = new Documento();
                List<Documento.Partida> partidas = (from x in Documento.Partida.Partidas()
                                                    where ids.Contains(x.documento_id) && x.cantidad_pendiente > 0m
                                                    select x).ToList();
                decimal importe_aplicado = (from x in Documento.Documentos()
                                            where ids.Contains(x.id)
                                            select x).Sum((Documento x) => x.importe_aplicado);
                var list2 = (from x in Documento.Documentos()
                             where ids.Contains(x.id) && x.porcentaje_descuento > 0m
                             select new { x.id, x.porcentaje_descuento }).ToList();
                List<Flujo> list3 = (from x in Flujo.Flujos()
                                     where ids.Contains(x.documento_id)
                                     select x).ToList();
                foreach (var descuento in list2)
                {
                    partidas.Where((Documento.Partida x) => x.documento_id == descuento.id).ToList().ForEach(delegate (Documento.Partida x)
                    {
                        x.porcentaje_descuento += descuento.porcentaje_descuento;
                        x.CalcularTotal();
                    });
                }
                partidas.All(delegate (Documento.Partida x)
                {
                    x.cantidad = x.cantidad_pendiente;
                    x.cantidad_pendiente = x.cantidad;
                    x.CalcularTotal();
                    return true;
                });
                documento.clase = "FA";
                int socio_id = (from x in Documento.Documentos()
                                where x.id == ids.First()
                                select x.socio_id).First();
                int num = (from x in Socio.Socios()
                           where x.id == socio_id
                           select x.socio_eventual_id).First();
                documento.socio_id = ((num != 0) ? num : socio_id);
                if (documento.socio_id == Program.Nori.UsuarioAutenticado.socio_id)
                {
                    documento.comentario = "Factura global del día: " + DateTime.Today.ToShortDateString();
                }
                try
                {
                    documento.vendedor_id = (from x in Documento.Documentos()
                                             where x.id == partidas.First().documento_id
                                             select x.vendedor_id).First();
                }
                catch
                {
                }
                documento.partidas.Clear();
                documento.partidas = partidas;
                documento.importe_aplicado = importe_aplicado;
                documento.CalcularTotal();
                frmDocumentos frmDocumentos2 = new frmDocumentos("FA");
                frmDocumentos2.documento.CopiarDe(documento, "FA");
                Documento documento2 = frmDocumentos2.documento;
                decimal num3 = (frmDocumentos2.documento.porcentaje_descuento = default(decimal));
                decimal descuento2 = num3;
                documento2.descuento = descuento2;
                frmDocumentos2.documento.CalcularTotal();
                frmDocumentos2.Cargar(nuevo: true);
                ((Form)frmDocumentos2).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void frmListaPartidasAbiertas_KeyDown(object sender, KeyEventArgs e)
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
            if (e.Control && e.KeyCode == Keys.F)
            {
                FacturarSeleccionados();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.Format("{0}\\{1}.xlsx", Program.Nori.Configuracion.directorio_documentos, "ListaPartidasAbiertas");
                gcDocumentos.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.Format("{0}\\{1}.pdf", Program.Nori.Configuracion.directorio_documentos, "ListaPartidasAbiertas");
                gcDocumentos.ExportToPdf(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FacturarSeleccionados();
        }

        private void cbWeb_EditValueChanged(object sender, EventArgs e)
        {
            CargarDocumentos();
        }


    }

}
