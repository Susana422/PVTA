using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;



namespace NORI.PuntoVenta
{
    public partial class frmArqueo : RibbonForm
    {
        private class Acumulado
        {
            public int tipo_metodo_pago_id { get; set; }

            public string concepto { get; set; }

            public decimal total { get; set; }
        }

        private List<MetodoPago.Tipo> tipos = new List<MetodoPago.Tipo>();

        private List<Arqueo> arqueos = new List<Arqueo>();

        private List<Acumulado> acumulados = new List<Acumulado>();

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private Button btnCancelar;

        private Button btnRECCA;

        private LookUpEdit cbConceptos;

        private LabelControl lblConceptos;

        private TextEdit txtCantidad;

        private LabelControl lblCantidad;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private GridColumn gridColumn3;

        private GridControl gcAcumulados;

        private GridView gvAcumulados;

        private GridColumn gridColumn5;

        private GridColumn gridColumn6;

        private Button btnRERET;
        public frmArqueo()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarListas();
        }

        private void CargarListas()
        {
            object obj = new
            {
                fields = "id, nombre",
                order_by = "nombre"
            };
            object obj2 = new
            {
                activo = 1
            };
            tipos = MetodoPago.Tipo.Tipos().ToList();
            cbConceptos.Properties.DataSource = tipos;
            cbConceptos.Properties.ValueMember = "id";
            cbConceptos.Properties.DisplayMember = "nombre";
            //cbConceptos.ItemIndex = 0;
            cbConceptos.Refresh();
            cbConceptos.EditValue = 0;
            foreach (MetodoPago.Tipo tipo in tipos)
            {
                Acumulado acumulado = new Acumulado();
                acumulado.tipo_metodo_pago_id = tipo.id;
                acumulado.concepto = tipo.nombre;
                acumulado.total = 0m;
                acumulados.Add(acumulado);
            }
            gcAcumulados.DataSource = acumulados;
           gcPartidas.DataSource = arqueos;
        }

        private void Calcular()
        {
            try
            {
                GridControl gridControl = gcPartidas;
                IEnumerable<Arqueo> dataSource = null;
                try
                {
                    if (!tipos.Where((MetodoPago.Tipo x) => x.id == (int)cbConceptos.EditValue).First().cambio)
                    {
                        dataSource = arqueos.Where((Arqueo  x) => x.tipo_metodo_pago_id == (int)cbConceptos.EditValue);
                    }
                    else
                    {
                        IEnumerable<Arqueo> enumerable = from x in arqueos
                                                         where x.tipo_metodo_pago_id == (int)cbConceptos.EditValue
                                                         orderby x.factor descending
                                                         select x;
                        dataSource = enumerable;
                    }
                }
                catch (Exception)
                {
                }
                if (dataSource != null)
                {
                    gridControl.DataSource = dataSource;
                }
   
                gcPartidas.RefreshDataSource();
                foreach (MetodoPago.Tipo tipo in tipos)
                {
                    if (acumulados.Count > 0)
                    {
                        acumulados.Where((Acumulado x) => x.tipo_metodo_pago_id == tipo.id).First().total = arqueos.Where((Arqueo x) => x.tipo_metodo_pago_id == tipo.id).Sum((Arqueo x) => x.producto) * tipo.ObtenerTipoCambio();
                    }
              
                }
                gcAcumulados.DataSource = acumulados;
                gcAcumulados.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AgregarArqueo(Arqueo arqueo)
        {
            arqueo.tipo_metodo_pago_id = (int)cbConceptos.EditValue;
            if (arqueos.Any((Arqueo x) => x.tipo_metodo_pago_id == arqueo.tipo_metodo_pago_id && x.factor == arqueo.factor))
            {
                Arqueo arqueo2 = arqueos.Where((Arqueo x) => x.tipo_metodo_pago_id == arqueo.tipo_metodo_pago_id && x.factor == arqueo.factor).First();
                arqueo2.cantidad += arqueo.cantidad;
                arqueo2.Calcular();
            }
            else
            {
                arqueos.Add(arqueo);
            }
            txtCantidad.Text = string.Empty;
            txtCantidad.Focus();
            Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && txtCantidad.Text.Length > 0 && (int)cbConceptos.EditValue != 0)
                {
                    Arqueo arqueo = new Arqueo();
                    if (arqueo.Validar(txtCantidad.Text))
                    {
                        AgregarArqueo(arqueo);
                    }
                    else
                    {
                        MessageBox.Show("El formato de entrada no es válido.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un concepto primero.");
            }
        }

        private void cbConceptos_EditValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void gvPartidas_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                arqueos[e.RowHandle].Calcular();
                Calcular();
            }
            catch
            {
            }
        }

        private void gvPartidas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (arqueos.Count > 0)
                    {
                        //Arqueo item = (Arqueo)gvPartidas.GetRow(gvPartidas.GetSelectedRows()[0]);
                        //gvPartidas.CloseEditor();
                        //arqueos.Remove(item);
                    }
                    Calcular();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnRERET_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiroFondoInicial_Click(object sender, EventArgs e)
        {
            try
            {
                if (NoriSDK.PuntoVenta.EstadoCaja().Equals('A'))
                {
                    //gvPartidas.CloseEditor();
                    Flujo flujo = NoriSDK.PuntoVenta.FondoInicial();
                    if (!NoriSDK.PuntoVenta.FondoInicialRetirado(flujo.id))
                    {
                        Autorizacion autorizacion = new Autorizacion();
                        autorizacion.codigo = "RERET";
                        autorizacion.referencia = $"Retiro del fondo inicial del usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre}";
                        autorizacion.comentario = Interaction.InputBox("Comentario retiro fondo inicial (Opcional)","","",-1,-1);
                        autorizacion.Agregar();
                        if (!autorizacion.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                            frmSolicitarAutorizacion.ShowDialog();
                            autorizacion.autorizado = frmSolicitarAutorizacion.DialogResult == DialogResult.OK;
                        }
                        if (autorizacion.autorizado)
                        {
                            Flujo flujo2 = new Flujo();
                            flujo2.codigo = "REACA";
                            flujo2.comentario = Interaction.InputBox("Ingrese un comentario acerca del retiro (Opcional)", "", "", -1, -1);
                            flujo2.autorizacion_id = autorizacion.id;
                            flujo2.tipo_cambio = flujo.tipo_cambio;
                            flujo2.importe = flujo.importe;
                            if (flujo2.Agregar())
                            {
                                Funciones.ImprimirInformePredeterminado("IE", flujo2.id);
                            }
                            else
                            {
                                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El fondo inicial ya ha sido retirado anteriormente");
                    }
                }
                else
                {
                    MessageBox.Show("La caja ya ha sido cerrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retirar el fondo inicial: " + ex.Message);
            }
        }

        private void btnRECCA_Click(object sender, EventArgs e)
        {

        }

        private void btnCorteZ_Click(object sender, EventArgs e)
        {
            decimal importe = acumulados.Sum((Acumulado x) => x.total);
            if (NoriSDK.PuntoVenta.EstadoCaja().Equals('A'))
            {
                if (MessageBox.Show("¿Estas seguro(a) de realizar el cierre de caja?", "Cierre de caja", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                Flujo flujo = new Flujo();
                flujo.codigo = "RECCA";
                flujo.comentario = Interaction.InputBox("Ingrese un comentario acerca del cierre de caja (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
                flujo.autorizacion_id = 0;
                flujo.importe = importe;
                if (flujo.Agregar())
                {
                    arqueos.All(delegate (Arqueo x)
                    {
                        x.flujo_id = flujo.id;
                        return true;
                    });
                    arqueos.ForEach(delegate (Arqueo x)
                    {
                        x.Agregar();
                    });
                    if (MessageBox.Show("¿Desea imprimir el corte Corte Z?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Funciones.ImprimirInformePredeterminado("CZ", flujo.id);
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message);
                }

            }
            else
            {
                MessageBox.Show("La caja ya ha sido cerrada");
            }
        }

        private void btnCorteX_Click(object sender, EventArgs e)
        {
            decimal importe = acumulados.Sum((Acumulado x) => x.total);
            Flujo flujo = new Flujo();
            flujo.codigo = "RECAX";
            flujo.comentario = Interaction.InputBox("Ingrese un comentario acerca del cierre de caja (Opcional)", "DTM SOLUTIONS POS", "", -1, -1);
            flujo.autorizacion_id = 0;
            flujo.importe = importe;
            if (flujo.Agregar())
            {
                if (MessageBox.Show("¿Desea imprimir el corte Corte X?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Funciones.ImprimirInformePredeterminado("CX", flujo.id);
                }
                Close();
            }
            else
            {
                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message);
            }
        }
    }
}
