using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace DTM
{
    public partial class frmExistenciasArt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmExistenciasArt(string articulo,string codigoSN,string almacen)
        {
            try
            {
                InitializeComponent();

                DataTable dataTable = new DataTable();
                DB dB = new DB();
                string query = "select distinct T1.id,T1.sku as 'Codigo',T1.nombre as 'Nombre',CONVERT(INT,T3.stock) as 'Stock',T1.comentario as 'Aplicacion',T2.nombre as 'Marca',t4.nombre as 'Familia'," +
                    "isnull((select TOP 1 FORMAT(T5.precio,'C','En-Us') from precios T5 inner join listas_precios T6 ON T5.lista_precio_id = T6.id inner join socios T7 on T6.id= T7.lista_precio_id where T7.codigo='" + codigoSN + "' AND T5.articulo_id =T1.id)," +
                    " (select  TOP 1 FORMAT(T5.precio,'C','En-Us') from precios T5 inner join listas_precios T6 ON T5.lista_precio_id = T6.id where T6.id='2' AND T5.articulo_id =T1.id)) AS 'precio' " +
                    " from articulos T1 left join fabricantes T2 ON T1.fabricante_id = T2.id left join inventario T3 ON T3.articulo_id = T1.id and t3.almacen_id='"+ almacen + "' left join grupos_articulos T4 ON T4.id = t1.grupo_articulo_id where" +
                    " T1.nombre like '%" + articulo + "%' or T1.sku like '%" + articulo + "%'";
                dataTable = dB.ExecuteQuery(query);
                dataGridViewResultado.DataSource = dataTable;
                if (dataTable.Rows.Count > 0) 
                {
                    string articuloP = dataTable.Rows[0]["Codigo"].ToString();
                    string id = dataTable.Rows[0]["id"].ToString();
                    articulosAlternativos(articuloP);
                    inventario(id);
                }

                foreach (DataGridViewColumn dgvc in dataGridViewInventario.Columns)
                {
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception)
            {

            }
         

        }
        private void inventario(string articuloP) 
        {
            try
            {
                DataTable dataTable = new DataTable();
                DB dB = new DB();
                string query = "select T2.codigo,T2.nombre,T2.activo,CONVERT(INT,T1.stock) as stock,CONVERT(INT,T1.comprometido) as comprometido,CONVERT(INT,T1.pedido) as pedido,CONVERT(INT,T1.disponible) as disponible,CONVERT(INT,T1.stock_minimo) as stock_minimo,CONVERT(INT,T1.stock_maximo) as stock_maximo,CONVERT(INT,T1.punto_reorden) as punto_reorden,T1.ubicacion from inventario T1 inner join almacenes T2 on T1.almacen_id = T2.id WHERE articulo_id ='" + articuloP+"'";
                dataTable = dB.ExecuteQuery(query);
                dataGridViewInventario.DataSource = dataTable;
            }
            catch (Exception)
            {

                
            }
        }
        private void articulosAlternativos(string articuloP) 
        {
            try
            {
                DB dB = new DB();
                listBox1.Items.Clear();

                string queryAlternativos = "select T2.sku AS 'codigo',T2.nombre from articulos_alternativos T1 left join articulos T2 on T1.articulo =T2.sku where T1.articulo = '" + articuloP + "'";
                DataTable dataTableAlt = new DataTable();
                dataTableAlt = dB.ExecuteQuery(queryAlternativos);
                foreach (DataRow row in dataTableAlt.Rows)
                {
                    string nombre = row["nombre"].ToString();
                    string codigo = row["codigo"].ToString();
                    string socioCompleto = $"{codigo} - {nombre}";
                    listBox1.Items.Add(socioCompleto);
                }
            }
            catch (Exception)
            {

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridViewResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewInventario.DataSource = null;
                listBox1.Items.Clear();
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando inventario");
                // Aguarda 2 segundos
                Thread.Sleep(1000);

                DataGridViewRow row = dataGridViewResultado.CurrentRow;
                string id = Convert.ToString(row.Cells[0].Value);
                string codigo = Convert.ToString(row.Cells[1].Value);
                string Nombrearticulo = Convert.ToString(row.Cells[2].Value);
                labelControl3.Text = Nombrearticulo;
                inventario(id);
                articulosAlternativos(codigo);
            }
            catch (Exception)
            {

            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }


        }
        public int rowIndex { get; set; }
        private void dataGridViewResultado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridViewResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataGridViewRow row = dataGridViewResultado.CurrentRow;
                string codigo = Convert.ToString(row.Cells[1].Value);
                frmDocumentos frmDocumentos = (frmDocumentos)Application.OpenForms["frmDocumentos"];
                frmDocumentos.Activate();
                frmDocumentos.ActualizarDatos(sender,codigo);  // Si necesitas actualizar los datos
                this.Hide();
                //frmDocumentos frmDocumentos = new frmDocumentos("",0,false,codigo);
                //KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Enter);
                //frmDocumentos.txtArticulo_KeyDown(sender, keyEventArgs);
                //frmDocumentos.ShowDialog();

            }
       }
    }
}