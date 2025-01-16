using DevExpress.XtraBars;
using DevExpress.XtraLayout;
using NetsuiteLibrary.SuiteTalk;
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
    public partial class frmArticulosSolicitados : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DataTable dtControles;  // DataTable para almacenar los detalles de los controles clickeados

        public frmArticulosSolicitados()
        {
            InitializeComponent();
            cargar(); 
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
        }
   
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text =="" || txtDescripcion.Text =="") {
                MessageBox.Show("El articulo /Descripcion son campos obligatorios");
            }
            ArticuloSolicitado articuloSolicitado = new ArticuloSolicitado();
            articuloSolicitado.socio_id = 0;
            articuloSolicitado.sku = txtArticulo.Text;
            articuloSolicitado.descripcion = txtDescripcion.Text;
            articuloSolicitado.cantidad = int.Parse(spinEdit1.Text);
            articuloSolicitado.comentarios = memoComentario.Text;
            if (articuloSolicitado.Agregar())
            {
                MessageBox.Show("Dato registrado correctamente");
            }
            else {
                MessageBox.Show("No fue posible ingresar tu informacion, verificar nuevamente");
            }
        }
        public void cargar() {
            var articulos = ArticuloSolicitado.ArticulosSolicitados().ToList();
            gridControl1.DataSource = articulos;
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        private void bbiXLSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string text = $"{Program.Nori.Configuracion.directorio_documentos}\\ventasnegadas.xlsx";
                gridControl1.ExportToXlsx(text);
                Funciones.AbrirArchivo(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
