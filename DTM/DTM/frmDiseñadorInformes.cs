using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace DTM
{
    public partial class frmDiseñadorInformes : Form
    {
        private IContainer components = null;

        private XRDesignMdiController reportDesigner1;

        private XRDesignRibbonController xrDesignRibbonController1;

        private RibbonControl ribbonControl1;

        private ApplicationMenu applicationMenu1;

        private CommandBarItem commandBarItem31;

        private CommandBarItem commandBarItem34;

        private CommandBarItem commandBarItem32;

        private CommandBarItem commandBarItem33;

        private CommandBarItem commandBarItem52;

        private CommandBarItem commandBarItem53;

        private CommandBarItem commandBarItem1;

        private CommandBarItem commandBarItem2;

        private CommandBarItem commandBarItem3;

        private CommandBarItem commandBarItem4;

        private CommandBarItem commandBarItem5;

        private CommandBarItem commandBarItem6;

        private CommandBarItem commandBarItem7;

        private CommandBarItem commandBarItem8;

        private CommandBarItem commandBarItem9;

        private CommandBarItem commandBarItem10;

        private CommandBarItem commandBarItem11;

        private CommandBarItem commandBarItem12;

        private CommandBarItem commandBarItem13;

        private CommandBarItem commandBarItem14;

        private CommandBarItem commandBarItem15;

        private CommandBarItem commandBarItem16;

        private CommandBarItem commandBarItem17;

        private CommandBarItem commandBarItem18;

        private CommandBarItem commandBarItem19;

        private CommandBarItem commandBarItem20;

        private CommandBarItem commandBarItem21;

        private CommandBarItem commandBarItem22;

        private CommandBarItem commandBarItem23;

        private CommandBarItem commandBarItem24;

        private CommandBarItem commandBarItem25;

        private CommandBarItem commandBarItem26;

        private CommandColorBarItem commandColorBarItem1;

        private CommandColorBarItem commandColorBarItem2;

        private CommandBarItem commandBarItem27;

        private CommandBarItem commandBarItem28;

        private CommandBarItem commandBarItem29;

        private CommandBarItem commandBarItem30;

        private CommandBarItem commandBarItem35;

        private CommandBarItem commandBarItem36;

        private CommandBarItem commandBarItem37;

        private CommandBarItem commandBarItem38;

        private CommandBarItem commandBarItem39;

        private CommandBarItem commandBarItem40;

        private CommandBarItem commandBarItem41;

        private CommandBarItem commandBarItem42;

        private CommandBarItem commandBarItem43;

        private CommandBarItem commandBarItem44;

        private CommandBarItem commandBarItem45;

        private CommandBarItem commandBarItem46;

        private BarEditItem barEditItem1;

        private RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;

        private BarEditItem barEditItem2;

        private DesignRepositoryItemComboBox designRepositoryItemComboBox1;

        private BarDockPanelsListItem barDockPanelsListItem1;

        private ScriptsCommandBarItem scriptsCommandBarItem1;

        private CommandBarItem commandBarItem47;

        private CommandBarItem commandBarItem48;

        private CommandBarItem commandBarItem49;

        private CommandBarItem commandBarItem50;

        private CommandBarItem commandBarItem51;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup1;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup2;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup3;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup4;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup5;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup6;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup7;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup8;

        private XRDesignBarButtonGroup xrDesignBarButtonGroup9;

        private PrintPreviewBarItem printPreviewBarItem1;

        private PrintPreviewBarItem printPreviewBarItem2;

        private PrintPreviewBarItem printPreviewBarItem3;

        private PrintPreviewBarItem printPreviewBarItem4;

        private PrintPreviewBarItem printPreviewBarItem5;

        private PrintPreviewBarItem printPreviewBarItem6;

        private PrintPreviewBarItem printPreviewBarItem7;

        private PrintPreviewBarItem printPreviewBarItem8;

        private PrintPreviewBarItem printPreviewBarItem9;

        private PrintPreviewBarItem printPreviewBarItem10;

        private PrintPreviewBarItem printPreviewBarItem11;

        private PrintPreviewBarItem printPreviewBarItem12;

        private PrintPreviewBarItem printPreviewBarItem13;

        private PrintPreviewBarItem printPreviewBarItem14;

        private PrintPreviewBarItem printPreviewBarItem15;

        private PrintPreviewBarItem printPreviewBarItem16;

        private PrintPreviewBarItem printPreviewBarItem17;

        private PrintPreviewBarItem printPreviewBarItem18;

        private PrintPreviewBarItem printPreviewBarItem19;

        private PrintPreviewBarItem printPreviewBarItem20;

        private PrintPreviewBarItem printPreviewBarItem21;

        private PrintPreviewBarItem printPreviewBarItem22;

        private PrintPreviewBarItem printPreviewBarItem23;

        private PrintPreviewBarItem printPreviewBarItem24;

        private PrintPreviewBarItem printPreviewBarItem25;

        private PrintPreviewBarItem printPreviewBarItem26;

        private PrintPreviewBarItem printPreviewBarItem27;

        private PrintPreviewBarItem printPreviewBarItem28;

        private PrintPreviewBarItem printPreviewBarItem29;

        private PrintPreviewBarItem printPreviewBarItem30;

        private PrintPreviewBarItem printPreviewBarItem31;

        private PrintPreviewBarItem printPreviewBarItem32;

        private PrintPreviewBarItem printPreviewBarItem33;

        private PrintPreviewBarItem printPreviewBarItem34;

        private PrintPreviewBarItem printPreviewBarItem35;

        private PrintPreviewBarItem printPreviewBarItem36;

        private PrintPreviewBarItem printPreviewBarItem37;

        private PrintPreviewBarItem printPreviewBarItem38;

        private PrintPreviewBarItem printPreviewBarItem39;

        private PrintPreviewBarItem printPreviewBarItem40;

        private PrintPreviewBarItem printPreviewBarItem41;

        private PrintPreviewBarItem printPreviewBarItem42;

        private PrintPreviewBarItem printPreviewBarItem43;

        private PrintPreviewBarItem printPreviewBarItem44;

        private PrintPreviewBarItem printPreviewBarItem45;

        private PrintPreviewBarItem printPreviewBarItem46;

        private PrintPreviewBarItem printPreviewBarItem47;

        private PrintPreviewBarItem printPreviewBarItem48;

        private PrintPreviewStaticItem printPreviewStaticItem1;

        private BarStaticItem barStaticItem1;

        private ProgressBarEditItem progressBarEditItem1;

        private RepositoryItemProgressBar repositoryItemProgressBar1;

        private PrintPreviewBarItem printPreviewBarItem49;

        private BarButtonItem barButtonItem1;

        private PrintPreviewStaticItem printPreviewStaticItem2;

        private ZoomTrackBarEditItem zoomTrackBarEditItem1;

        private RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;

        private XRToolboxPageCategory xrToolboxPageCategory1;

        private XRToolboxRibbonPage ribbonPage2;

        private XRDesignRibbonPage ribbonPage1;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup1;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup2;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup3;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup4;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup5;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup6;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup7;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup8;

        private PrintPreviewRibbonPage ribbonPage4;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup1;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup2;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup3;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup4;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup5;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup6;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup7;

        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup8;

        private XRHtmlRibbonPage ribbonPage3;

        private XRDesignRibbonPageGroup xrDesignRibbonPageGroup9;

        private RibbonStatusBar ribbonStatusBar1;

        private XRDesignDockManager xrDesignDockManager1;

        private DockPanel panelContainer3;

        private ErrorListDockPanel errorListDockPanel1;

        private DesignControlContainer errorListDockPanel1_Container;

        private GroupAndSortDockPanel groupAndSortDockPanel1;

        private DesignControlContainer groupAndSortDockPanel1_Container;

        private ToolBoxDockPanel toolBoxDockPanel1;

        private DesignControlContainer toolBoxDockPanel1_Container;

        private DockPanel panelContainer1;

        private DockPanel panelContainer2;

        private FieldListDockPanel fieldListDockPanel1;

        private DesignControlContainer fieldListDockPanel1_Container;

        private ReportExplorerDockPanel reportExplorerDockPanel1;

        private DesignControlContainer reportExplorerDockPanel1_Container;

        private PropertyGridDockPanel propertyGridDockPanel1;

        private DesignControlContainer propertyGridDockPanel1_Container;

        public frmDiseñadorInformes()
        {
            InitializeComponent();
            this.MetodoDinamico();
            try
            {
                Settings.Settings.Default.RootDirectory = Program.Nori.Configuracion.directorio_informes;
            }
            catch
            {
            }
        }

        public void AbrirInforme(string informe)
        {
            try
            {
                reportDesigner1.OpenReport(informe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
