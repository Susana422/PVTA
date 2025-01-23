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
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmPaquetes : RibbonForm
    {
        private Paquete paquete = new Paquete();

        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

        private BarButtonItem bbiGuardarCerrar;

        private BarButtonItem bbiGuardarNuevo;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiRestablecer;

        private BarButtonItem bbiBuscar;

        private BarButtonItem bbiPrimero;

        private BarButtonItem bbiAnterior;

        private BarButtonItem bbiUltimo;

        private BarButtonItem bbiSiguiente;

        private BarButtonItem bbiNuevo;

        private RibbonPage mainRibbonPage;

        private RibbonPageGroup mainRibbonPageGroup;

        private RibbonPageGroup searchRibbonPageGroup;

        private LabelControl lblID;

        private LabelControl lblNombre;

        private TextEdit txtNombre;

        private LabelControl lblFechaActualizacion;

        private LabelControl lblUltimaActualizacion;

        private Panel panel1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private LabelControl lblPorcion;

        private TextEdit txtPorcion;

        private LabelControl lblArticulo;

        private CheckEdit cbConjunto;

        private CheckEdit cbProduccion;

        private GridControl gcLineas;

        private GridView gvLineas;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnOpcional;

        private GridColumn gridColumnMinimo;

        private GridColumn gridColumnMaximo;

        private LabelControl lblMaximo;

        private TextEdit txtMaximo;

        private LabelControl lblMinimo;

        private TextEdit txtMinimo;

        private GridColumn gridColumnId;

        private GridColumn gridColumnArticulo;

        private RepositoryItemGridLookUpEdit lseArticulos;

        private GridView repositoryItemGridLookUpEdit1View;

        private RepositoryItemLookUpEdit leArticulos;

        private CheckedComboBoxEdit cbArticulos;

        public frmPaquetes(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
                paquete = Paquete.Obtener(id);
                Cargar();
            }
            else
            {
                Cargar(nuevo: false, busqueda: true);
            }
            Permisos();
            CargarListas();
        }

        private void Permisos()
        {
            switch (Program.Nori.UsuarioAutenticado.rol)
            {
                case 'C':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'V':
                    mainRibbonPageGroup.Visible = false;
                    break;
                case 'S':
                    mainRibbonPageGroup.Visible = false;
                    break;
            }
        }

        private void CargarListas()
        {
            var dataSource = (from x in Articulo.Articulos()
                              where x.activo == true
                              select new { x.id, x.sku, x.nombre } into x
                              orderby x.nombre
                              select x).ToList();
            cbArticulos.Properties.DataSource = dataSource;
            cbArticulos.Properties.ValueMember = "id";
            cbArticulos.Properties.DisplayMember = "nombre";
            ((RepositoryItemLookUpEditBase)leArticulos).DataSource = dataSource;
            ((RepositoryItemLookUpEditBase)leArticulos).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)leArticulos).DisplayMember = "nombre";
        }

        private void Cargar(bool nuevo = false, bool busqueda = false)
        {
            ((Control)(object)lblID).Text = paquete.id.ToString();
            ((Control)(object)txtNombre).Text = paquete.nombre;
            cbProduccion.Checked = paquete.produccion;
            cbConjunto.Checked = paquete.conjunto;
            ((Control)(object)txtPorcion).Text = paquete.porcion.ToString();
            ((Control)(object)txtMinimo).Text = paquete.minimo.ToString();
            ((Control)(object)txtMaximo).Text = paquete.maximo.ToString();
            ((Control)(object)lblFechaActualizacion).Text = paquete.fecha_actualizacion.ToShortDateString();
            CargarArticulos();
            gcLineas.DataSource = Utilidades.EjecutarQuery($"SELECT * FROM paquetes_opciones WHERE paquete_id = {paquete.id}");
            gcLineas.RefreshDataSource();
            ((Control)(object)gcLineas).Enabled = paquete.id != 0;
            if (nuevo)
            {
                ((BarItem)bbiNuevo).Enabled = false;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
                ((Control)(object)txtNombre).Focus();
            }
            else if (busqueda)
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = false;
                ((BarItem)bbiGuardarCerrar).Enabled = false;
                ((BarItem)bbiGuardarNuevo).Enabled = false;
                ((Control)(object)txtNombre).Focus();
            }
            else
            {
                ((BarItem)bbiNuevo).Enabled = true;
                ((BarItem)bbiGuardar).Enabled = true;
                ((BarItem)bbiGuardarCerrar).Enabled = true;
                ((BarItem)bbiGuardarNuevo).Enabled = true;
            }
        }

        private void CargarArticulos()
        {
            try
            {
                List<Paquete.Articulo> source = paquete.Articulos();
                cbArticulos.SetEditValue((object)string.Join(",", source.Select((Paquete.Articulo x) => x.articulo_id).ToList()));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void Llenar()
        {
            paquete.nombre = ((Control)(object)txtNombre).Text;
            paquete.produccion = cbProduccion.Checked;
            paquete.conjunto = cbConjunto.Checked;
            paquete.porcion = decimal.Parse(((Control)(object)txtPorcion).Text);
            paquete.minimo = int.Parse(((Control)(object)txtMinimo).Text);
            paquete.maximo = int.Parse(((Control)(object)txtMaximo).Text);
        }

        private void LlenarArticulos()
        {
            try
            {
                if (paquete.id == 0)
                {
                    return;
                }
                List<object> checkedValues = cbArticulos.Properties.Items.GetCheckedValues();
                List<int> list = new List<int>();
                foreach (object item in checkedValues)
                {
                    Paquete.Articulo articulo = new Paquete.Articulo
                    {
                        paquete_id = paquete.id,
                        articulo_id = (int)item
                    };
                    list.Add(articulo.articulo_id);
                    articulo.Agregar();
                }
                Utilidades.EjecutarQuery(string.Format("delete from paquetes_articulos where paquete_id = {0} and articulo_id not in ({1})", paquete.id, string.Join(",", list)));
            }
            catch
            {
            }
        }

        private bool Guardar()
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Llenar();
                    if (paquete.id != 0)
                    {
                        LlenarArticulos();
                        return paquete.Actualizar();
                    }
                    return paquete.Agregar();
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
                return false;
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                Cargar();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text);
            }
        }

        private void bbiGuardarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                ((Form)this).Close();
            }
        }

        private void bbiGuardarNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Guardar())
            {
                paquete = new Paquete();
                Cargar();
            }
        }

        private void bbiPrimero_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                paquete = (from x in Paquete.Paquetes()
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
                paquete = (from x in Paquete.Paquetes()
                           where x.id < paquete.id
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
                paquete = (from x in Paquete.Paquetes()
                           where x.id > paquete.id
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
                paquete = (from x in Paquete.Paquetes()
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

        private void Buscar()
        {
            try
            {
                if (paquete.id != 0)
                {
                    paquete = new Paquete();
                    Cargar(nuevo: false, busqueda: true);
                    return;
                }
                object parametros = new
                {
                    fields = "id, nombre",
                    like = true
                };
                object objeto = new
                {
                    nombre = ((Control)(object)txtNombre).Text
                };
                DataTable dataTable = Utilidades.Busqueda("paquetes", objeto, parametros);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        paquete = Paquete.Obtener((int)dataTable.Rows[0]["id"]);
                        Cargar();
                        return;
                    }
                    frmResultadosBusqueda frmResultadosBusqueda2 = new frmResultadosBusqueda(dataTable);
                    DialogResult dialogResult = ((Form)(object)frmResultadosBusqueda2).ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        paquete = Paquete.Obtener(frmResultadosBusqueda2.id);
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

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            paquete = new Paquete();
            Cargar(nuevo: true);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && paquete.id == 0)
            {
                Buscar();
            }
        }

        private void gcLineas_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0055: Invalid comparison between Unknown and I4
            //IL_010c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0112: Invalid comparison between Unknown and I4
            try
            {
                DataRow dataRow = ((ColumnView)gvLineas).GetDataRow(((ColumnView)gvLineas).GetSelectedRows()[0]);
                ((BaseView)gvLineas).CloseEditor();
                int result = 0;
                int.TryParse(dataRow["id"].ToString(), out result);
                Paquete.Opcion opcion = Paquete.Opcion.Obtener(result);
                if ((int)e.Button.ButtonType == 10)
                {
                    opcion.paquete_id = paquete.id;
                    opcion.articulo_id = (int)dataRow["articulo_id"];
                    opcion.nombre = dataRow["nombre"].ToString();
                    opcion.minimo = (int)dataRow["minimo"];
                    opcion.maximo = (int)dataRow["maximo"];
                    opcion.opcional = (bool)dataRow["opcional"];
                    if (opcion.id != 0)
                    {
                        opcion.Actualizar();
                    }
                    else
                    {
                        opcion.Agregar();
                    }
                }
                else if ((int)e.Button.ButtonType == 8 && opcion.id != 0)
                {
                    opcion.Eliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gvLineas_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ((ColumnView)gvLineas).SetRowCellValue(e.RowHandle, "opcional", (object)1);
        }

    }
}
