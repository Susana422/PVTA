using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NORI.Restaurante
{
    public partial class frmComanda : RibbonForm
    {
        private Documento documento = new Documento();

        private Socio socio = new Socio();

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

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private BarButtonItem bbiImprimir;

        private SplitContainerControl splitContainerControlComanda;

        private LayoutControlItem layoutControlItem1;

        private SplitContainerControl splitContainerControlArticulos;

        private TableLayoutPanel tlp;

        private PictureBox pictureBox1;

        private TextEdit txtArticulo;

        private LookUpEdit cbVendedores;

        private LabelControl lblVendedores;

        private SplitContainerControl splitContainerControlPartidas;

        private Label lblTotal;

        private Label lblTotal_;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnSKU;

        private GridColumn gridColumnArticulo;

        private GridColumn gridColumnCodigoBarras;

        private GridColumn gridColumnPrecio;

        private GridColumn gridColumnPrecioNeto;

        private GridColumn gridColumnPorcentajeDescuento;

        private GridColumn gridColumnDescuento;

        private GridColumn gridColumnSubTotal;

        private GridColumn gridColumnTotal;

        private RepositoryItemLookUpEdit cbMonedas;

        private SimpleButton btnAtras;

        public frmComanda(int id = 0)
        {
            InitializeComponent();
            this.MetodoDinamico();
            if (id != 0)
            {
            }
            Permisos();
            Inicializar();
            CargarGruposArticulos();
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

        private void CargarGruposArticulos()
        {
            tlp.Controls.Clear();
            tlp.RowStyles.Clear();
            int num = 0;
            int num2 = 0;
            tlp.AutoScroll = false;
            var list = (from x in GrupoArticulo.GruposArticulos()
                        where x.activo == true
                        select new { x.id, x.nombre }).ToList();
            tlp.SuspendLayout();
            foreach (var item in list)
            {
                Button button = new Button();
                button.Name = item.id.ToString();
                button.Text = item.nombre;
                button.Width = 250;
                button.Height = 50;
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Click += botonGrupoArticulo_Click;
                tlp.Controls.Add(button, num2, num);
                num++;
                if (num == 3)
                {
                    num = 0;
                    num2++;
                }
            }
            tlp.AutoScroll = true;
            tlp.ResumeLayout();
        }

        protected void botonGrupoArticulo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CargarArticulos(int.Parse(button.Name));
        }

        private void CargarArticulos(int grupo_articulo_id)
        {
            tlp.Controls.Clear();
            tlp.RowStyles.Clear();
            int num = 0;
            int num2 = 0;
            tlp.AutoScroll = false;
            var list = (from x in Articulo.Articulos()
                        where x.grupo_articulo_id == grupo_articulo_id && x.activo == true
                        select new { x.id, x.sku, x.nombre, x.imagen }).ToList();
            tlp.SuspendLayout();
            foreach (var item in list)
            {
                Button button = new Button();
                button.Name = item.id.ToString();
                button.Text = item.nombre;
                button.Tag = item.sku;
                button.Width = 250;
                button.Height = 50;
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Click += botonArticulo_Click;
                tlp.Controls.Add(button, num2, num);
                num++;
                if (num == 3)
                {
                    num = 0;
                    num2++;
                }
            }
            tlp.AutoScroll = true;
            tlp.ResumeLayout();
        }

        protected void botonArticulo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            AgregarPartida((string)button.Tag);
        }

        private void Inicializar()
        {
            try
            {
                documento = new Documento();
                EstablecerSocio(Socio.Obtener(Program.Nori.UsuarioAutenticado.socio_id));
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Cargar()
        {
            CargarListas();
            if (documento.socio_id == 0)
            {
                MessageBox.Show("No esta definido el socio de negocio predeterminado");
            }
            else
            {
                socio = Socio.Obtener(Program.Nori.UsuarioAutenticado.socio_id);
            }
            Calcular();
        }

        private void CargarListas()
        {
            object parametros = new
            {
                fields = "id, nombre"
            };
            object objeto = new
            {
                activo = 1
            };
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DataSource = Utilidades.Busqueda("vendedores", objeto, parametros);
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).ValueMember = "id";
            ((RepositoryItemLookUpEditBase)cbVendedores.Properties).DisplayMember = "nombre";
            ((BaseEdit)cbVendedores).EditValue = Program.Nori.UsuarioAutenticado.vendedor_id;
        }

        private void Calcular()
        {
            gcPartidas.DataSource = documento.partidas;
            gcPartidas.RefreshDataSource();
            documento.CalcularTotal();
            lblTotal.Text = documento.total.ToString("C");
        }

        private void EstablecerSocio(Socio socio)
        {
            try
            {
                if (socio.tipo == 'C')
                {
                    if (socio.activo)
                    {
                        if (socio.lista_precio_id != Program.Nori.Configuracion.lista_precio_id)
                        {
                            Autorizacion autorizacion = new Autorizacion();
                            autorizacion.codigo = "CALIP";
                            autorizacion.referencia = $"Cambio de lista de precio diferente a la predeterminada al socio {socio.codigo}";
                            autorizacion.comentario = Interaction.InputBox("Comentario cambio de lista (Opcional)");
                            autorizacion.Agregar();
                            if (!autorizacion.autorizado)
                            {
                                frmSolicitarAutorizacion frmSolicitarAutorizacion = new frmSolicitarAutorizacion(autorizacion);
                                ((Form)(object)frmSolicitarAutorizacion).ShowDialog();
                                autorizacion.autorizado = ((Form)(object)frmSolicitarAutorizacion).DialogResult == DialogResult.OK;
                            }
                            if (!autorizacion.autorizado)
                            {
                                socio.lista_precio_id = Program.Nori.Configuracion.lista_precio_id;
                            }
                        }
                        if (!documento.EstablecerSocio(socio))
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                            return;
                        }
                        Calcular();
                        ((Control)(object)txtArticulo).Text = string.Empty;
                        ((Control)(object)txtArticulo).Focus();
                    }
                    else
                    {
                        MessageBox.Show("El socio esta inactivo");
                    }
                }
                else
                {
                    MessageBox.Show("El socio seleccionado no es del tipo cliente");
                }
            }
            catch
            {
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && ((Control)(object)txtArticulo).Text.Length > 0)
            {
                AgregarPartida(((Control)(object)txtArticulo).Text);
            }
        }

        private void AgregarPartida(string q)
        {
            do
            {
                if (documento.AgregarPartida(q))
                {
                    ((Control)(object)txtArticulo).Text = string.Empty;
                    Calcular();
                    break;
                }
            }
            while (MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry);
            ((Control)(object)txtArticulo).Text = string.Empty;
            ((Control)(object)txtArticulo).Focus();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            CargarGruposArticulos();
        }


    }
}
