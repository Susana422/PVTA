using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace DTM
{
    public partial class frmAutorizarPago : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Usuario usr;
        public frmAutorizarPago()
        {
            InitializeComponent();
            string usuario = Autorizacion.autOrder();
            usr = Usuario.Obtener(usuario);
            if (usr != null)
            { 
                lbuser.Text = usr.nombre;
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            frmPagos frmDoc = this.Owner as frmPagos;
            if (frmDoc != null)
            {       
                if (usr != null) {
                    if (txtContraseña.Text ==null || txtContraseña.Text =="" ) 
                    {
                        MessageBox.Show("La contraseña es obligatoria para poder autorizar");
                        return;
                    }
                    if (usr.ObtenerContraseña() == ((Control)(object)txtContraseña).Text)
                    {
                        AutOrder autOrder = new AutOrder();
                        autOrder.usuario_creacion_id = usr.id;
                        autOrder.comentario = txtComentario.Text;
                        autOrder.documento = 0;
                        if (autOrder.Agregar())
                        {
                            frmDoc.Autorizar = true;
                        }
                       
                    }
                }
            }
            this.Hide();
        }

    }
}