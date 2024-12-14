using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public partial class frmMapaRelaciones : RibbonForm
    {
        private int documento_id = 0;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private TreeView tv;

        public frmMapaRelaciones(Documento documento)
        {
            InitializeComponent();
            this.MetodoDinamico();
            List<Pago.Partida> list = (from x in Pago.Partida.Partidas()
                                       where x.documento_id == documento.id
                                       select x).ToList();
            List<Documento.Referencia> list2 = (from x in Documento.Referencia.Referencias()
                                                where x.documento_id == documento.id
                                                select x).ToList();
            TreeNode node = new TreeNode
            {
                Text = string.Format("{0} {1} Total: {2} {3}", (from x in Documento.Clase.Clases()
                                                                where x.clase == documento.clase
                                                                select x).First().nombre, documento.numero_documento, documento.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                       where x.estado == documento.estado
                                                                                                                                                       select x).First().nombre),
                Tag = documento.id
            };
            documento_id = documento.id;
            tv.Nodes.Add(node);
            CargarRelacionesOrigen(documento.id, documento.fecha_creacion);
            CargarRelacionesDestino(documento.id, documento.fecha_creacion);
            if (list.Count > 0)
            {
                foreach (Pago.Partida item in list)
                {
                    TreeNode node2 = new TreeNode(string.Format("Pago {0} Importe: {1}", item.pago_id, item.importe.ToString("c2")))
                    {
                        ForeColor = Color.GreenYellow,
                        Tag = item.pago_id
                    };
                    tv.Nodes.Add(node2);
                }
            }
            if (list2.Count > 0)
            {
                foreach (Documento.Referencia referencia in list2)
                {
                    var documento_referencia = (from x in Documento.Documentos()
                                                where x.id == referencia.documento_referencia_id
                                                select new { x.id, x.numero_documento, x.clase, x.estado, x.total }).First();
                    TreeNode node3 = new TreeNode(string.Format("{0} {1} Total: {2} {3}", (from x in Documento.Clase.Clases()
                                                                                           where x.clase == documento_referencia.clase
                                                                                           select x).First().nombre, documento_referencia.numero_documento, documento_referencia.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                                                                        where x.estado == documento_referencia.estado
                                                                                                                                                                                                        select x).First().nombre))
                    {
                        ForeColor = Color.DodgerBlue,
                        Tag = documento_referencia.id
                    };
                    tv.Nodes.Add(node3);
                }
            }
            tv.SelectedNode = null;
            tv.ExpandAll();
        }

        private void CargarRelacionesOrigen(int documento_id, DateTime fecha_creacion)
        {
            List<Documento.Relacion> list = (from x in Documento.Relacion.RelacionDocumentos()
                                             where x.documento_origen_id == documento_id
                                             select x).ToList();
            if (list.Count <= 0)
            {
                return;
            }
            foreach (Documento.Relacion relacion in list)
            {
                var documento_relacion = (from x in Documento.Documentos()
                                          where x.id == relacion.documento_destino_id
                                          select new { x.id, x.numero_documento, x.clase, x.estado, x.cancelado, x.total, x.fecha_creacion }).First();
                TimeSpan timeSpan = documento_relacion.fecha_creacion - fecha_creacion;
                TreeNode treeNode = new TreeNode(string.Format("{0} {1} Total: {2} {3} | Tt: {4}", (from x in Documento.Clase.Clases()
                                                                                                    where x.clase == documento_relacion.clase
                                                                                                    select x).First().nombre, documento_relacion.numero_documento, documento_relacion.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                                                                             where x.estado == documento_relacion.estado
                                                                                                                                                                                                             select x).First().nombre, timeSpan.TotalMinutes.ToString("N2")));
                treeNode.ForeColor = (documento_relacion.cancelado ? Color.Firebrick : Color.DimGray);
                treeNode.Tag = documento_relacion.id;
                tv.Nodes[0].Nodes.Add(treeNode);
            }
        }

        private void CargarRelacionesDestino(int documento_id, DateTime fecha_creacion)
        {
            List<Documento.Relacion> list = (from x in Documento.Relacion.RelacionDocumentos()
                                             where x.documento_destino_id == documento_id
                                             select x).ToList();
            if (list.Count <= 0)
            {
                return;
            }
            foreach (Documento.Relacion relacion in list)
            {
                var documento_relacion = (from x in Documento.Documentos()
                                          where x.id == relacion.documento_origen_id
                                          select new { x.id, x.numero_documento, x.clase, x.estado, x.cancelado, x.total, x.fecha_creacion }).First();
                TimeSpan timeSpan = fecha_creacion - documento_relacion.fecha_creacion;
                TreeNode treeNode = new TreeNode(string.Format("{0} {1} Total: {2} {3} | Tt(m): {4}", (from x in Documento.Clase.Clases()
                                                                                                       where x.clase == documento_relacion.clase
                                                                                                       select x).First().nombre, documento_relacion.numero_documento, documento_relacion.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                                                                                where x.estado == documento_relacion.estado
                                                                                                                                                                                                                select x).First().nombre, timeSpan.TotalMinutes.ToString("N2")));
                treeNode.ForeColor = (documento_relacion.cancelado ? Color.Firebrick : Color.DimGray);
                treeNode.Tag = documento_relacion.id;
                tv.Nodes.Add(treeNode);
            }
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.ForeColor == Color.GreenYellow)
                {
                    frmPagos frmPagos2 = new frmPagos((int)e.Node.Tag);
                    ((Control)(object)frmPagos2).Show();
                    return;
                }
                var anon = (from x in Documento.Documentos()
                            where x.id == (int)e.Node.Tag
                            select new { x.id, x.clase }).First();
                frmDocumentos frmDocumentos2 = new frmDocumentos(anon.clase, anon.id);
                ((Control)(object)frmDocumentos2).Show();
            }
            catch
            {
            }
        }

        private void tv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Delete || (int)tv.SelectedNode.Tag == documento_id)
                {
                    return;
                }
                if (tv.SelectedNode.ForeColor == Color.Firebrick || tv.SelectedNode.ForeColor == Color.DimGray)
                {
                    Documento.Relacion relacion = Documento.Relacion.Obtener((int)tv.SelectedNode.Tag, documento_id);
                    if (relacion.id != 0 && MessageBox.Show("¿Desea eliminar esta relación?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (relacion.Eliminar())
                        {
                            tv.SelectedNode.Remove();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                        }
                    }
                }
                else
                {
                    if (!(tv.SelectedNode.ForeColor == Color.DodgerBlue))
                    {
                        return;
                    }
                    Documento.Referencia referencia = Documento.Referencia.Obtener(documento_id, (int)tv.SelectedNode.Tag);
                    if (referencia.id != 0 && MessageBox.Show("¿Desea eliminar esta referencia?", ((Control)(object)this).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (referencia.Eliminar())
                        {
                            tv.SelectedNode.Remove();
                        }
                        else
                        {
                            MessageBox.Show(NoriSDK.Nori.ObtenerUltimoError().Message.ToString().Replace("Nori","DTM"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori","DTM"));
            }
        }

     
    }

}
