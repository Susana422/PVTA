using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using SDK;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{
    public partial class frmSeleccionarSucursal : RibbonForm
    {
        private IContainer components = null;

        private TabFormDefaultManager tabFormDefaultManager1;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private Panel panel1;

        private LayoutControlItem layoutControlItem1;

        private LabelControl lblUsuario;

        private LabelControl lblAcceder;

        private Button btnAceptar;

        private DefaultLookAndFeel defaultLookAndFeel1;

        private HyperlinkLabelControl lblConexion;

        private LookUpEdit cbAlmacenes;

        public frmSeleccionarSucursal()
        {
            InitializeComponent();
            this.MetodoDinamico();
            Cargar();
            ((BaseEdit)cbAlmacenes).EditValue = Program.dtm.UsuarioAutenticado.almacen_id;
        }

        private void Cargar()
        {
            try
            {
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DataSource = (from x in Almacen.Almacenes()
                                                                                     where x.activo == true && x.transito == false
                                                                                     select new { x.id, x.codigo, x.nombre }).ToList();
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).ValueMember = "id";
                ((RepositoryItemLookUpEditBase)cbAlmacenes.Properties).DisplayMember = "nombre";
            }
            catch
            {
            }
        }

        private void frmSeleccionarSucural_Load(object sender, EventArgs e)
        {
            ((Form)this).Activate();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.dtm.UsuarioAutenticado.almacen_id = (int)((BaseEdit)cbAlmacenes).EditValue;
            ((Control)this).Hide();
        }
    }

}
