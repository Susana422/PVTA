using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NORI.PuntoVenta
{
    public partial class frmCortesCaja : RibbonForm
    {
        private List<Usuario> usuarios = new List<Usuario>();

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

        private GridControl gcFlujo;

        private GridView gvFlujo;

        private LayoutControlItem layoutControlItem1;

        private RepositoryItemDateEdit deFecha;

        private RepositoryItemLookUpEdit cbMonedas;

        private LayoutControl layoutControl2;

        private LayoutControlGroup layoutControlGroup2;

        private LayoutControlItem layoutControlItem3;

        private Panel panel1;

        private LayoutControlItem layoutControlItem2;

        private LookUpEdit cbUsuarios;

        private DateEdit deHasta;

        private DateEdit deDesde;

        private CheckEdit cbFlujo;

        public frmCortesCaja()
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
                Usuario usuario = new Usuario();
                usuario.usuario = "Todos";
                usuario.nombre = "Todos";
                usuarios.Add(usuario);
                usuarios.AddRange((from x in Usuario.Usuarios()
                                   where x.activo == true
                                   select x).ToList());
                ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).DataSource = usuarios;
                ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbUsuarios.Properties).DisplayMember = "nombre";
                ((BaseEdit)cbUsuarios).EditValue = 0;
            }
            catch
            {
            }
        }

        private void CargarFlujo()
        {
            try
            {
                string arg = (((int)((BaseEdit)cbUsuarios).EditValue == 0) ? string.Empty : $"AND flujo.usuario_creacion_id = {(int)((BaseEdit)cbUsuarios).EditValue}");
                string query = (cbFlujo.Checked ? string.Format("select flujo.id ID, conceptos_flujo.nombre Concepto, flujo.codigo Código, estaciones.nombre Estación, tipos_metodos_pago.nombre 'Método de pago', flujo.tipo_cambio 'Tipo de cambio', flujo.importe Importe, flujo.referencia Referencia, flujo.comentario Comentario, autorizaciones.comentario 'Comentario autorización', usuarios.usuario, flujo.fecha_creacion 'Fecha creación', flujo.fecha_actualizacion 'Fecha actualización' from flujo left join tipos_metodos_pago on flujo.tipo_metodo_pago_id = tipos_metodos_pago.id inner join estaciones on flujo.estacion_id = estaciones.id left join autorizaciones on flujo.autorizacion_id = autorizaciones.id inner join conceptos_flujo on flujo.codigo = conceptos_flujo.codigo left join usuarios on flujo.usuario_creacion_id = usuarios.id WHERE flujo.fecha_creacion BETWEEN '{0}' AND '{1}' {2}", ((DateTime)((BaseEdit)deDesde).EditValue).ToString("yyyyMMdd"), ((DateTime)((BaseEdit)deHasta).EditValue).ToString("yyyyMMdd"), arg) : string.Format("select flujo.id ID, estaciones.nombre Estación, flujo.tipo_cambio 'Tipo de cambio', flujo.importe Importe, flujo.comentario Comentario, autorizaciones.comentario 'Comentario autorización', usuarios.usuario, flujo.fecha_creacion 'Fecha creación', flujo.fecha_actualizacion 'Fecha actualización' from flujo inner join estaciones on flujo.estacion_id = estaciones.id inner join autorizaciones on flujo.autorizacion_id = autorizaciones.id left join usuarios on flujo.usuario_creacion_id = usuarios.id WHERE flujo.codigo = 'RECCA' or flujo.codigo = 'INACA' AND  CONVERT(DATE,flujo.fecha_creacion, 103)  BETWEEN CONVERT(DATE,'{0}', 103)  AND CONVERT(DATE,'{1}',103) {2}", ((DateTime)((BaseEdit)deDesde).EditValue).ToString("dd/MM/yyyy"), ((DateTime)((BaseEdit)deHasta).EditValue).ToString("dd/MM/yyyy"), arg));
                ((CollectionBase)(object)((ColumnView)gvFlujo).Columns).Clear();
                gcFlujo.DataSource = Utilidades.EjecutarQuery(query);
            }
            catch
            {
            }
        }

        private void ImprimirSeleccionados()
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro(a) que deseas imprimir los elementos seleccionados?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                List<DataRow> list = new List<DataRow>();
                for (int i = 0; i < ((ColumnView)gvFlujo).SelectedRowsCount; i++)
                {
                    if (((ColumnView)gvFlujo).GetSelectedRows()[i] >= 0)
                    {
                        list.Add(((ColumnView)gvFlujo).GetDataRow(((ColumnView)gvFlujo).GetSelectedRows()[i]));
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    DataRow dataRow = list[j];
                    if (cbFlujo.Checked)
                    {
                        Funciones.ImprimirInformePredeterminado("IE", (int)dataRow["ID"]);
                        continue;
                    }
                    if (MessageBox.Show("¿Desea imprimir el corte Corte Z?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Funciones.ImprimirInformePredeterminado("CZ", (int)dataRow["ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frmCortesCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                ImprimirSeleccionados();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                CargarFlujo();
            }
        }

        private void cbUsuarios_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarFlujo();
            }
            catch
            {
            }
        }
    }

}
