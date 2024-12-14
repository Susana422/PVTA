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

        private Button btnREACA;

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
            ((RepositoryItemLookUpEditBase)cbConceptos.Properties).DataSource = tipos;
            ((RepositoryItemLookUpEditBase)cbConceptos.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbConceptos.Properties).DisplayMember = "nombre";
            cbConceptos.ItemIndex = 0;
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
                GridControl obj = gcPartidas;
                IEnumerable<Arqueo> dataSource;
                if (!tipos.Where((MetodoPago.Tipo x) => x.id == (int)((BaseEdit)cbConceptos).EditValue).First().cambio)
                {
                    dataSource = arqueos.Where((Arqueo x) => x.tipo_metodo_pago_id == (int)((BaseEdit)cbConceptos).EditValue);
                }
                else
                {
                    IEnumerable<Arqueo> enumerable = from x in arqueos
                                                     where x.tipo_metodo_pago_id == (int)((BaseEdit)cbConceptos).EditValue
                                                     orderby x.factor descending
                                                     select x;
                    dataSource = enumerable;
                }
                obj.DataSource = dataSource;
                gcPartidas.RefreshDataSource();
                foreach (MetodoPago.Tipo tipo in tipos)
                {
                    acumulados.Where((Acumulado x) => x.tipo_metodo_pago_id == tipo.id).First().total = arqueos.Where((Arqueo x) => x.tipo_metodo_pago_id == tipo.id).Sum((Arqueo x) => x.producto) * tipo.ObtenerTipoCambio();
                }
                gcAcumulados.DataSource = acumulados;
                gcAcumulados.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AgregarArqueo(Arqueo arqueo)
        {
            arqueo.tipo_metodo_pago_id = (int)((BaseEdit)cbConceptos).EditValue;
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
            ((Control)(object)txtCantidad).Text = string.Empty;
            ((Control)(object)txtCantidad).Focus();
            Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this).DialogResult = DialogResult.Cancel;
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && ((Control)(object)txtCantidad).Text.Length > 0 && (int)((BaseEdit)cbConceptos).EditValue != 0)
                {
                    Arqueo arqueo = new Arqueo();
                    if (arqueo.Validar(((Control)(object)txtCantidad).Text))
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
                        Arqueo item = (Arqueo)((BaseView)gvPartidas).GetRow(((ColumnView)gvPartidas).GetSelectedRows()[0]);
                        ((BaseView)gvPartidas).CloseEditor();
                        arqueos.Remove(item);
                    }
                    Calcular();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnRERET_Click(object sender, EventArgs e)
        {
            ((BaseView)gvPartidas).CloseEditor();
            decimal num = acumulados.Sum((Acumulado x) => x.total);
            if (!(num > 0m) || MessageBox.Show($"¿Estas seguro(a) de realizar un retiro por la cantidad de {num:c2}?", "Retiro", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            Autorizacion autorizacion = new Autorizacion();
            autorizacion.codigo = "RERET";
            autorizacion.referencia = $"Retiro por la cantidad de {num} al usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre}";
            autorizacion.comentario = Interaction.InputBox("Comentario retiro (Opcional)");
            autorizacion.Agregar();
            if (!autorizacion.autorizado)
            {
                frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
            }
            if (!autorizacion.autorizado)
            {
                return;
            }
            Flujo flujo = new Flujo();
            flujo.codigo = "RERET";
            flujo.comentario = Interaction.InputBox("Ingrese un comentario acerca del retiro (Opcional)");
            flujo.autorizacion_id = autorizacion.id;
            flujo.importe = num;
            try
            {
                if (MessageBox.Show(string.Format("¿El retiro corresponde a una devolución de venta?", num), "Retiro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    flujo.documento_id = int.Parse(Interaction.InputBox("Ingrese el ID del documento"));
                    var anon = (from x in Documento.Documentos()
                                where x.id == flujo.documento_id
                                select new { x.clase, x.importe_aplicado, x.total }).First();
                    if (!anon.clase.Equals("FA") && !anon.clase.Equals("EN"))
                    {
                        MessageBox.Show("Solo es posible realizar devoluciones de entregas y facturas.");
                        return;
                    }
                    if (num > anon.total)
                    {
                        MessageBox.Show("No es posible devolver un importe mayor que el importe total del documento referenciado.");
                        return;
                    }
                    if (num > anon.importe_aplicado)
                    {
                        MessageBox.Show("No es posible devolver un importe mayor que el importe aplicado del documento referenciado.");
                        return;
                    }
                }
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
                    Funciones.ImprimirInformePredeterminado("IE", flujo.id);
                    if (MessageBox.Show("¿Deseas imprimir el arqueo de este retiro?", "Retiro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Funciones.ImprimirInformePredeterminado("AR", flujo.id);
                    }
                    ((Form)this).Close();
                }
                else
                {
                    MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void btnRetiroFondoInicial_Click(object sender, EventArgs e)
        {
            try
            {
                if (NoriSDK.PuntoVenta.EstadoCaja().Equals('A'))
                {
                    ((BaseView)gvPartidas).CloseEditor();
                    Flujo flujo = NoriSDK.PuntoVenta.FondoInicial();
                    if (!NoriSDK.PuntoVenta.FondoInicialRetirado(flujo.id))
                    {
                        Autorizacion autorizacion = new Autorizacion();
                        autorizacion.codigo = "RERET";
                        autorizacion.referencia = $"Retiro del fondo inicial del usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre}";
                        autorizacion.comentario = Interaction.InputBox("Comentario retiro fondo inicial (Opcional)");
                        autorizacion.Agregar();
                        if (!autorizacion.autorizado)
                        {
                            frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                            ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                            autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                        }
                        if (autorizacion.autorizado)
                        {
                            Flujo flujo2 = new Flujo();
                            flujo2.codigo = "REACA";
                            flujo2.comentario = Interaction.InputBox("Ingrese un comentario acerca del retiro (Opcional)");
                            flujo2.autorizacion_id = autorizacion.id;
                            flujo2.tipo_cambio = flujo.tipo_cambio;
                            flujo2.importe = flujo.importe;
                            if (flujo2.Agregar())
                            {
                                Funciones.ImprimirInformePredeterminado("IE", flujo2.id);
                            }
                            else
                            {
                                MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
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
                MessageBox.Show("Error al retirar el fondo inicial: " + ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

        private void btnRECCA_Click(object sender, EventArgs e)
        {
            try
            {
                ((BaseView)gvPartidas).CloseEditor();
                decimal importe = acumulados.Sum((Acumulado x) => x.total);
                if (NoriSDK.PuntoVenta.EstadoCaja().Equals('A'))
                {
                    if (MessageBox.Show("¿Estas seguro(a) de realizar el cierre de caja?", "Cierre de caja", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    Autorizacion autorizacion = new Autorizacion();
                    autorizacion.codigo = "RECCA";
                    autorizacion.referencia = $"Cierre de caja del usuario {Program.Nori.UsuarioAutenticado.usuario} en la estación {Program.Nori.Estacion.nombre}";
                    autorizacion.comentario = Interaction.InputBox("Comentario cierre de caja (Opcional)");
                    autorizacion.Agregar();
                    if (!autorizacion.autorizado)
                    {
                        frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                        ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                        autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                    }
                    if (!autorizacion.autorizado)
                    {
                        return;
                    }
                    Flujo flujo = new Flujo();
                    flujo.codigo = "RECCA";
                    flujo.comentario = Interaction.InputBox("Ingrese un comentario acerca del cierre de caja (Opcional)");
                    flujo.autorizacion_id = autorizacion.id;
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
                        if (MessageBox.Show("¿Desea imprimir el Egreso?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Funciones.ImprimirInformePredeterminado("IE", flujo.id);
                        }
                        if (MessageBox.Show("¿Desea imprimir el Arqueo?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Funciones.ImprimirInformePredeterminado("AR", flujo.id);
                        }
                        if (MessageBox.Show("¿Desea imprimir el corte Corte X?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Funciones.ImprimirInformePredeterminado("CX", flujo.id);
                        }
                        if (MessageBox.Show("¿Desea imprimir el corte Corte Z?", ((Control)(object)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Funciones.ImprimirInformePredeterminado("CZ", flujo.id);
                        }
                        ((Form)this).Close();
                    }
                    else
                    {
                        MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                    }
                }
                else
                {
                    MessageBox.Show("La caja ya ha sido cerrada");
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar el Corte Z");
            }
        }

    }
}
