using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmSeleccionPaquetes : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl mainRibbonControl;

        private BarButtonItem bbiGuardar;

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

        private SplitContainerControl splitContainerControlComanda;

        private LayoutControlItem layoutControlItem1;

        private SplitContainerControl splitContainerControlArticulos;

        private TableLayoutPanel tlo;

        private SplitContainerControl splitContainerControlPartidas;

        private GridControl gcPartidas;

        private GridView gvPartidas;

        private GridColumn gridColumnCantidad;

        private GridColumn gridColumnNombre;

        private GridColumn gridColumnPrecio;

        private RepositoryItemLookUpEdit cbMonedas;

        private TableLayoutPanel tlp;

        private Label lblArticulo;

        private Label label1;

        private ToggleSwitch ts;

        public List<Paquete.Opcion> opciones { get; internal set; }

        public List<Paquete> paquetes { get; internal set; }

        public Documento.Partida partida { get; set; }

        public frmSeleccionPaquetes(Documento.Partida _partida)
        {
            InitializeComponent();
            partida = _partida;
            this.MetodoDinamico();
            Permisos();
            Inicializar();
            CargarPaquetes();
        }

        private void Permisos()
        {
            ((Form)this).ControlBox = false;
        }

        private void CargarPaquetes()
        {
            tlp.Controls.Clear();
            tlp.RowStyles.Clear();
            int num = 0;
            int num2 = 0;
            tlp.AutoScroll = false;
            tlp.SuspendLayout();
            foreach (Paquete paquete in paquetes)
            {
                Button button = new Button
                {
                    Name = paquete.id.ToString(),
                    Text = $"{paquete.nombre} Min. {paquete.minimo} / Max. {paquete.maximo}",
                    Width = 250,
                    Height = 50
                };
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Click += botonPaquete_Click;
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

        protected void botonPaquete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CargarOpciones(int.Parse(button.Name));
        }

        private async void CargarOpciones(int paquete_id)
        {
            tlo.Controls.Clear();
            tlo.RowStyles.Clear();
            int columna = 0;
            int fila = 0;
            tlo.AutoScroll = false;
            tlo.SuspendLayout();
            foreach (Paquete.Opcion opcion in opciones.Where((Paquete.Opcion x) => x.paquete_id == paquete_id).ToList())
            {
                Button boton = new Button
                {
                    Name = opcion.id.ToString(),
                    Text = string.Format("{0} Min. {1} / Max. {2} ({3})", opcion.nombre, opcion.minimo, opcion.maximo, opcion.opcional ? "Opcional" : "Obligatorio"),
                    Tag = opcion.articulo_id,
                    Width = 250,
                    Height = 50
                };
                string imagen = (from x in Articulo.Articulos()
                                 where x.id == opcion.articulo_id
                                 select x.imagen).FirstOrDefault();
                if (!imagen.IsNullOrEmpty())
                {
                    await Task.Run(delegate
                    {
                        boton.LoadImage(imagen);
                    });
                }
                boton.Font = new Font(boton.Font, FontStyle.Bold);
                boton.Click += botonOpcion_Click;
                tlo.Controls.Add(boton, fila, columna);
                columna++;
                if (columna == 3)
                {
                    columna = 0;
                    fila++;
                }
            }
            tlo.AutoScroll = true;
            tlo.ResumeLayout();
        }

        protected void botonOpcion_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (ts.IsOn)
            {
                AgregarOpcion(int.Parse(button.Name));
            }
            else
            {
                QuitarOpcion(int.Parse(button.Name));
            }
        }

        public void AgregarOpcion(int opcion_id)
        {
            Paquete.Opcion opcion = opciones.Where((Paquete.Opcion x) => x.id == opcion_id).FirstOrDefault();
            if (opcion.cantidad + 1 > opcion.maximo)
            {
                MessageBox.Show("No es posible agregar más que la cantidad máxima.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                opcion.cantidad++;
            }
            Calcular();
        }

        public void QuitarOpcion(int opcion_id)
        {
            Paquete.Opcion opcion = opciones.Where((Paquete.Opcion x) => x.id == opcion_id).FirstOrDefault();
            if (opcion.cantidad - 1 < opcion.minimo)
            {
                MessageBox.Show("No es posible quitar más que la cantidad mínima.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                opcion.cantidad--;
            }
            Calcular();
        }

        private void Inicializar()
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Cargar()
        {
            lblArticulo.Text = partida.nombre;
            CargarListas();
            Calcular();
        }

        private void CargarListas()
        {
            List<int> paquetes_ids = (from x in Paquete.Articulo.Articulos()
                                      where x.articulo_id == partida.articulo_id
                                      select x.paquete_id).ToList();
            paquetes = (from x in Paquete.Paquetes()
                        where paquetes_ids.Contains(x.id)
                        select x).ToList();
            opciones = (from x in Paquete.Opcion.Opciones()
                        where paquetes_ids.Contains(x.paquete_id)
                        select x).ToList();
            opciones.ForEach(delegate (Paquete.Opcion x)
            {
                x.cantidad = x.minimo;
            });
        }

        private void Calcular()
        {
            gcPartidas.DataSource = opciones;
            gcPartidas.RefreshDataSource();
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool flag = true;
            foreach (Paquete paquete in paquetes)
            {
                if (opciones.Where((Paquete.Opcion x) => x.paquete_id == paquete.id).Sum((Paquete.Opcion x) => x.cantidad) < paquete.minimo)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                MessageBox.Show("Se completó la selección de opciones.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((Form)this).Close();
            }
            else
            {
                MessageBox.Show("Aún no se completó la selección de opciones.", ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

    }
}
