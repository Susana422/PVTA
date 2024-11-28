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
    public partial class frmMapaRelacionesPagos : RibbonForm
    {
        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private RibbonStatusBar ribbonStatusBar1;

        private TreeView tv;

        public frmMapaRelacionesPagos(Pago pago)
        {
            InitializeComponent();
            this.MetodoDinamico();
            List<Pago.Partida> list = pago.ObtenerPartidas();
            TreeNode node = new TreeNode
            {
                Text = string.Format("{0} {1} Total: {2}", (from x in Documento.Clase.Clases()
                                                            where x.clase == "PR"
                                                            select x).First().nombre, pago.numero_documento, pago.total.ToString("c2")),
                Tag = pago.id,
                ForeColor = Color.GreenYellow
            };
            tv.Nodes.Add(node);
            if (list.Count > 0)
            {
                foreach (Pago.Partida partida in list)
                {
                    var documento_relacion = (from x in Documento.Documentos()
                                              where x.id == partida.documento_id
                                              select new { x.id, x.numero_documento, x.clase, x.estado, x.cancelado, x.total }).First();
                    TreeNode node2 = new TreeNode(string.Format("{0} {1} Total: {2} {3}", (from x in Documento.Clase.Clases()
                                                                                           where x.clase == documento_relacion.clase
                                                                                           select x).First().nombre, documento_relacion.numero_documento, documento_relacion.total.ToString("c2"), (from x in Documento.Estado.Estados()
                                                                                                                                                                                                    where x.estado == documento_relacion.estado
                                                                                                                                                                                                    select x).First().nombre))
                    {
                        ForeColor = (documento_relacion.cancelado ? Color.Firebrick : Color.DimGray),
                        Tag = documento_relacion.id
                    };
                    tv.Nodes[0].Nodes.Add(node2);
                }
            }
            tv.SelectedNode = null;
            tv.ExpandAll();
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

       
    }

}
