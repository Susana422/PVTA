﻿using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmAutorizacion : RibbonForm
    {
        internal static Autorizacion autorizacion;

        internal static Autorizacion.ConceptoAutorizacion concepto_autorizacion;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private PanelControl panelControl1;

        private LayoutControlItem layoutControlItem1;

        private Button btnAutorizar;

        private LabelControl lblAutorizacion;

        private Label lblReferencia;

        private Button btnDenegar;

        private MemoEdit txtComentario;

        private Timer timer;

        private Label lblComentario;

        private LinkLabel lblVerCaptura;

        public frmAutorizacion(Autorizacion _)
        {
            InitializeComponent();
            this.MetodoDinamico();
            btnAutorizar.Focus();
            autorizacion = _;
            concepto_autorizacion = Autorizacion.ConceptoAutorizacion.Obtener(autorizacion.codigo);
            autorizacion.usuario_autorizacion_id = Program.dtm.UsuarioAutenticado.id;
            autorizacion.estacion_autorizacion_id = Program.dtm.Estacion.id;
            Usuario usuario = Usuario.Obtener(autorizacion.usuario_creacion_id);
            Estacion estacion = Estacion.Obtener(autorizacion.estacion_id);
            ((Control)(object)this).Text += $" - {usuario.nombre} | {estacion.nombre}";
            ((Control)(object)lblAutorizacion).Text = concepto_autorizacion.nombre;
            lblReferencia.Text = autorizacion.referencia;
            lblComentario.Text = autorizacion.comentario;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            Autorizacion obj = autorizacion;
            obj.comentario = obj.comentario + " | " + ((Control)(object)txtComentario).Text;
            if (autorizacion.comentario.Length > 254)
            {
                MessageBox.Show("El comentario no puede tener una longitud mayor a 254 caracteres.");
                return;
            }
            autorizacion.autorizado = Funciones.Autenticar();
            autorizacion.usuario_autorizacion_id = Program.dtm.UsuarioAutenticado.id;
            autorizacion.estacion_autorizacion_id = Program.dtm.Estacion.id;
            autorizacion.Actualizar();
            ((Form)this).Close();
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            Autorizacion obj = autorizacion;
            obj.comentario = obj.comentario + " " + ((Control)(object)txtComentario).Text;
            if (autorizacion.comentario.Length > 254)
            {
                MessageBox.Show("El comentario no puede tener una longitud mayor a 254 caracteres.");
                return;
            }
            autorizacion.autorizado = false;
            autorizacion.Actualizar();
            ((Form)this).Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                autorizacion.Verificar();
                if (!autorizacion.pendiente)
                {
                    ((Form)this).Close();
                }
            }
            catch
            {
            }
        }

        private void lblVerCaptura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string text = (from x in Autorizacion.Autorizaciones()
                               where x.id == autorizacion.id
                               select x.captura).FirstOrDefault();
                string arguments = Program.dtm.Configuracion.directorio_imagenes + "\\autorizaciones\\" + text;
                Process.Start("explorer.exe", arguments);
            }
            catch
            {
            }
        }

    }
}
