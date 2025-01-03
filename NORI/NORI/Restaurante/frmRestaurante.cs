using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Microsoft.VisualBasic;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NORI.Restaurante
{
    public partial class frmRestaurante : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbon;

        private RibbonPage ribbonPageMesas;

        private RibbonPageGroup ribbonPageGroupMesasArchivo;

        private BarButtonItem bbiNuevo;

        private BarButtonItem bbiGuardar;

        private RibbonStatusBar ribbonStatusBar;

        private Panel panelMesas;

        private BarStaticItem lblEstacion;

        private BarStaticItem lblUsuario;

        public frmRestaurante()
        {
            InitializeComponent();
            this.MetodoDinamico();
            CargarAsync();
            ((BarItem)lblEstacion).Caption = Program.Nori.Estacion.nombre;
            ((BarItem)lblUsuario).Caption = Program.Nori.UsuarioAutenticado.nombre;
            CargarMesas();
            frmComanda frmComanda2 = new frmComanda();
            ((Control)(object)frmComanda2).Show();
        }

        private async void CargarAsync()
        {
            try
            {
                Control ctrl = panelMesas;
                ctrl.SetImage(await Funciones.CargarImagen(Program.Nori.Empresa.logotipo));
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), ((Control)(object)this).Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CargarMesas()
        {
            List<Mesa> list = Mesa.ObtenerPorComedor(0);
            panelMesas.Controls.Clear();
            foreach (Mesa item in list)
            {
                Button button = new Button();
                button.Name = item.id.ToString();
                button.Text = item.nombre;
                button.Width = item.ancho;
                button.Height = item.alto;
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Location = new Point(item.x, item.y);
                // ControlMoverOrResizer.Init(button);
                panelMesas.Controls.Add(button);
            }
        }

        private void GuardarMesas()
        {
            List<Mesa> list = Mesa.ObtenerPorComedor(0);
            foreach (Mesa item in list)
            {
                Control control = panelMesas.Controls.Find(item.id.ToString(), searchAllChildren: true)[0];
                item.ancho = control.Width;
                item.alto = control.Height;
                item.x = control.Location.X;
                item.y = control.Location.Y;
                item.Actualizar();
            }
        }

        private void bbiNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.codigo = Interaction.InputBox("Ingresa el código de la mesa", "Mesas", mesa.codigo);
            mesa.nombre = Interaction.InputBox("Ingresa el nombre de la mesa", "Mesas", mesa.nombre);
            mesa.Agregar();
            CargarMesas();
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuardarMesas();
        }

    }
}
