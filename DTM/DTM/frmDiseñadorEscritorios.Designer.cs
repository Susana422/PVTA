using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DashboardWin;
using DevExpress.DashboardWin.Bars;
using DevExpress.DashboardWin.Native;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraRichEdit.Design;
using DevExpress.XtraRichEdit.Forms.Design;
using DevExpress.XtraRichEdit.UI;


namespace DTM
{
    partial class frmDiseñadorEscritorios
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
                // Dispose(disposing);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                base.Dispose(disposing);
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiseñadorEscritorios));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem10 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem11 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem12 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem13 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem14 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem15 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem16 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem17 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem18 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem19 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem20 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem21 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem22 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem23 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem24 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem25 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem26 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem27 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem28 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem29 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem30 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem31 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem32 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem33 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem34 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem35 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem36 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem37 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem38 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem39 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem40 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem41 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem42 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem43 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem44 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem45 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem46 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem47 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem48 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem49 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem50 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup5 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup6 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup7 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup8 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup9 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup10 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup11 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup12 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup13 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem2 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem3 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup14 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem4 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem5 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem6 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem7 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem8 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem9 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup15 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem10 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem11 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem12 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem13 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem14 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem15 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem16 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup16 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem17 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem18 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup17 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem19 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup18 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem20 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem21 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem chartSeriesTypeGalleryItem22 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup19 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup20 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup21 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup22 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup23 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            this.ribbonControl1 = null;
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();

            this.dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
            this.dashboardBackstageViewControl1 = new DevExpress.DashboardWin.Bars.DashboardBackstageViewControl();
            this.dashboardBackstageNewButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageNewButton();
            this.dashboardBackstageOpenButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageOpenButton();
            this.dashboardBackstageSaveButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageSaveButton();
            this.dashboardBackstageSaveAsButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageSaveAsButton();
            this.dashboardBackstageRecentTab1 = new DevExpress.DashboardWin.Bars.DashboardBackstageRecentTab();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.recentDashboardsControl1 = new DevExpress.DashboardWin.Bars.RecentDashboardsControl();
            this.dashboardBarController1 = new DevExpress.DashboardWin.Bars.DashboardBarController();
            this.fileRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FileRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.DashboardWin.Bars.HomeRibbonPage();
            this.fileNewBarItem1 = new DevExpress.DashboardWin.Bars.FileNewBarItem();
            this.fileOpenBarItem1 = new DevExpress.DashboardWin.Bars.FileOpenBarItem();
            this.fileSaveBarItem1 = new DevExpress.DashboardWin.Bars.FileSaveBarItem();
            this.fileSaveAsBarItem1 = new DevExpress.DashboardWin.Bars.FileSaveAsBarItem();
            this.quickAccessHistoryRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.QuickAccessHistoryRibbonPageGroup();
            this.quickAccessUndoBarItem1 = new DevExpress.DashboardWin.Bars.QuickAccessUndoBarItem();
            this.quickAccessRedoBarItem1 = new DevExpress.DashboardWin.Bars.QuickAccessRedoBarItem();
            this.historyRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.HistoryRibbonPageGroup();
            this.undoBarItem1 = new DevExpress.DashboardWin.Bars.UndoBarItem();
            this.redoBarItem1 = new DevExpress.DashboardWin.Bars.RedoBarItem();
            this.dataSourceRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DataSourceRibbonPageGroup();
            this.dataSourceRibbonPage1 = new DevExpress.DashboardWin.Bars.DataSourceRibbonPage();
            this.newDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.NewDataSourceBarItem();
            this.editSqlConnectionBarItem1 = new DevExpress.DashboardWin.Bars.EditSqlConnectionBarItem();
            this.editOlapConnectionBarItem1 = new DevExpress.DashboardWin.Bars.EditOlapConnectionBarItem();
            this.editObjectDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.EditObjectDataSourceBarItem();
            this.editExcelDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.EditExcelDataSourceBarItem();
            this.editEFDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.EditEFDataSourceBarItem();
            this.editExtractOptionsBarItem1 = new DevExpress.DashboardWin.Bars.EditExtractOptionsBarItem();
            this.renameDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.RenameDataSourceBarItem();
            this.deleteDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.DeleteDataSourceBarItem();
            this.serverModeBarItem1 = new DevExpress.DashboardWin.Bars.ServerModeBarItem();
            this.upateDataExtractBarItem1 = new DevExpress.DashboardWin.Bars.UpateDataExtractBarItem();
            this.addCalculatedFieldBarItem1 = new DevExpress.DashboardWin.Bars.AddCalculatedFieldBarItem();
            this.sqlDataSourceQueryRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.SqlDataSourceQueryRibbonPageGroup();
            this.addQueryBarItem1 = new DevExpress.DashboardWin.Bars.AddQueryBarItem();
            this.editQueryBarItem1 = new DevExpress.DashboardWin.Bars.EditQueryBarItem();
            this.renameQueryBarItem1 = new DevExpress.DashboardWin.Bars.RenameQueryBarItem();
            this.editQueryFilterBarItem1 = new DevExpress.DashboardWin.Bars.EditQueryFilterBarItem();
            this.deleteQueryBarItem1 = new DevExpress.DashboardWin.Bars.DeleteQueryBarItem();
            this.extractSourceRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ExtractSourceRibbonPageGroup();
            this.editExtractSourceConnectionBarItem1 = new DevExpress.DashboardWin.Bars.EditExtractSourceConnectionBarItem();
            this.editExtractSourceBarItem1 = new DevExpress.DashboardWin.Bars.EditExtractSourceBarItem();
            this.editExtractSourceQueryBarItem1 = new DevExpress.DashboardWin.Bars.EditExtractSourceQueryBarItem();
            this.dataSourceFilteringRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DataSourceFilteringRibbonPageGroup();
            this.editDataSourceFilterBarItem1 = new DevExpress.DashboardWin.Bars.EditDataSourceFilterBarItem();
            this.clearDataSourceFilterBarItem1 = new DevExpress.DashboardWin.Bars.ClearDataSourceFilterBarItem();
            this.insertRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.InsertRibbonPageGroup();
            this.insertPivotBarItem1 = new DevExpress.DashboardWin.Bars.InsertPivotBarItem();
            this.insertGridBarItem1 = new DevExpress.DashboardWin.Bars.InsertGridBarItem();
            this.insertChartBarItem1 = new DevExpress.DashboardWin.Bars.InsertChartBarItem();
            this.insertScatterChartBarItem1 = new DevExpress.DashboardWin.Bars.InsertScatterChartBarItem();
            this.insertPiesBarItem1 = new DevExpress.DashboardWin.Bars.InsertPiesBarItem();
            this.insertGaugesBarItem1 = new DevExpress.DashboardWin.Bars.InsertGaugesBarItem();
            this.insertCardsBarItem1 = new DevExpress.DashboardWin.Bars.InsertCardsBarItem();
            this.insertChoroplethMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertChoroplethMapBarItem();
            this.insertGeoPointMapBarSubItem1 = new DevExpress.DashboardWin.Bars.InsertGeoPointMapBarSubItem();
            this.insertGeoPointMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertGeoPointMapBarItem();
            this.insertBubbleMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertBubbleMapBarItem();
            this.insertPieMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertPieMapBarItem();
            this.insertRangeFilterBarItem1 = new DevExpress.DashboardWin.Bars.InsertRangeFilterBarItem();
            this.insertFilterElementSubItem1 = new DevExpress.DashboardWin.Bars.InsertFilterElementSubItem();
            this.insertComboBoxBarItem1 = new DevExpress.DashboardWin.Bars.InsertComboBoxBarItem();
            this.insertListBoxBarItem1 = new DevExpress.DashboardWin.Bars.InsertListBoxBarItem();
            this.insertTreeViewBarItem1 = new DevExpress.DashboardWin.Bars.InsertTreeViewBarItem();
            this.insertImagesBarSubItem1 = new DevExpress.DashboardWin.Bars.InsertImagesBarSubItem();
            this.insertImageBarItem1 = new DevExpress.DashboardWin.Bars.InsertImageBarItem();
            this.insertBoundImageBarItem1 = new DevExpress.DashboardWin.Bars.InsertBoundImageBarItem();
            this.insertTextBoxBarItem1 = new DevExpress.DashboardWin.Bars.InsertTextBoxBarItem();
            this.insertGroupBarItem1 = new DevExpress.DashboardWin.Bars.InsertGroupBarItem();
            this.itemOperationRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ItemOperationRibbonPageGroup();
            this.duplicateItemBarItem1 = new DevExpress.DashboardWin.Bars.DuplicateItemBarItem();
            this.deleteItemBarItem1 = new DevExpress.DashboardWin.Bars.DeleteItemBarItem();
            this.convertDashboardItemTypeBarItem1 = new DevExpress.DashboardWin.Bars.ConvertDashboardItemTypeBarItem();
            this.convertToPivotBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToPivotBarItem();
            this.convertToGridBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToGridBarItem();
            this.convertToChartBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToChartBarItem();
            this.convertToScatterChartBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToScatterChartBarItem();
            this.convertToPieBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToPieBarItem();
            this.convertToGaugeBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToGaugeBarItem();
            this.convertToCardBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToCardBarItem();
            this.convertToChoroplethMapBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToChoroplethMapBarItem();
            this.convertToBoundImageBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToBoundImageBarItem();
            this.convertGeoPointMapBaseBarItem1 = new DevExpress.DashboardWin.Bars.ConvertGeoPointMapBaseBarItem();
            this.convertToGeoPointMapBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToGeoPointMapBarItem();
            this.convertToBubbleMapBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToBubbleMapBarItem();
            this.convertToPieMapBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToPieMapBarItem();
            this.convertToRangeFilterBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToRangeFilterBarItem();
            this.convertToFilterElementsBaseBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToFilterElementsBaseBarItem();
            this.convertToComboBoxBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToComboBoxBarItem();
            this.convertToListBoxBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToListBoxBarItem();
            this.convertToTreeViewBarItem1 = new DevExpress.DashboardWin.Bars.ConvertToTreeViewBarItem();
            this.removeDataItemsBarItem1 = new DevExpress.DashboardWin.Bars.RemoveDataItemsBarItem();
            this.transposeItemBarItem1 = new DevExpress.DashboardWin.Bars.TransposeItemBarItem();
            this.editRulesBarItem1 = new DevExpress.DashboardWin.Bars.EditRulesBarItem();
            this.groupOperationRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GroupOperationRibbonPageGroup();
            this.deleteGroupBarItem1 = new DevExpress.DashboardWin.Bars.DeleteGroupBarItem();
            this.dashboardDesignRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DashboardDesignRibbonPageGroup();
            this.dashboardTitleBarItem1 = new DevExpress.DashboardWin.Bars.DashboardTitleBarItem();
            this.setCurrencyCultureBarItem1 = new DevExpress.DashboardWin.Bars.SetCurrencyCultureBarItem();
            this.dashboardColorSchemeBarItem1 = new DevExpress.DashboardWin.Bars.DashboardColorSchemeBarItem();
            this.dashboardParametersBarItem1 = new DevExpress.DashboardWin.Bars.DashboardParametersBarItem();
            this.dashboardAutomaticUpdatesBarItem1 = new DevExpress.DashboardWin.Bars.DashboardAutomaticUpdatesBarItem();
            this.updateDataBarItem1 = new DevExpress.DashboardWin.Bars.UpdateDataBarItem();
            this.skinsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.SkinsRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.DashboardWin.Bars.ViewRibbonPage();
            this.dashboardSkinsBarItem1 = new DevExpress.DashboardWin.Bars.DashboardSkinsBarItem();
            this.filteringRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage1 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.pivotToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.PivotToolsRibbonPageCategory();
            this.editFilterBarItem1 = new DevExpress.DashboardWin.Bars.EditFilterBarItem();
            this.clearFilterBarItem1 = new DevExpress.DashboardWin.Bars.ClearFilterBarItem();
            this.filteringRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage2 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.gridToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GridToolsRibbonPageCategory();
            this.filteringRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage3 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.chartToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ChartToolsRibbonPageCategory();
            this.filteringRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage4 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.scatterChartToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ScatterChartToolsRibbonPageCategory();
            this.filteringRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage5 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.piesToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.PiesToolsRibbonPageCategory();
            this.filteringRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage6 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.gaugesToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GaugesToolsRibbonPageCategory();
            this.filteringRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage7 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.cardsToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.CardsToolsRibbonPageCategory();
            this.filteringRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage8 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.rangeFilterToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.RangeFilterToolsRibbonPageCategory();
            this.filteringRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage9 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.choroplethMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ChoroplethMapToolsRibbonPageCategory();
            this.filteringRibbonPageGroup10 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage10 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.geoPointMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GeoPointMapToolsRibbonPageCategory();
            this.filteringRibbonPageGroup11 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage11 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.bubbleMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.BubbleMapToolsRibbonPageCategory();
            this.filteringRibbonPageGroup12 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage12 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.pieMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.PieMapToolsRibbonPageCategory();
            this.filteringRibbonPageGroup13 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage13 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.filterElementToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.FilterElementToolsRibbonPageCategory();
            this.filteringRibbonPageGroup14 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage14 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.boundImageToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.BoundImageToolsRibbonPageCategory();
            this.filteringRibbonPageGroup15 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
            this.dataRibbonPage15 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.textBoxToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.TextBoxToolsRibbonPageCategory();
            this.masterFilterRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterBarItem1 = new DevExpress.DashboardWin.Bars.MasterFilterBarItem();
            this.multipleValuesMasterFilterBarItem1 = new DevExpress.DashboardWin.Bars.MultipleValuesMasterFilterBarItem();
            this.drillDownBarItem1 = new DevExpress.DashboardWin.Bars.DrillDownBarItem();
            this.masterFilterRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup10 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.masterFilterRibbonPageGroup11 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
            this.dataRibbonPage16 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
            this.groupToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GroupToolsRibbonPageCategory();
            this.groupMasterFilterBarItem1 = new DevExpress.DashboardWin.Bars.GroupMasterFilterBarItem();
            this.groupIgnoreMasterFilterBarItem1 = new DevExpress.DashboardWin.Bars.GroupIgnoreMasterFilterBarItem();
            this.interactivitySettingsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.ignoreMasterFiltersBarItem1 = new DevExpress.DashboardWin.Bars.IgnoreMasterFiltersBarItem();
            this.interactivitySettingsRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.crossDataSourceFilteringBarItem1 = new DevExpress.DashboardWin.Bars.CrossDataSourceFilteringBarItem();
            this.interactivitySettingsRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup10 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup11 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup12 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup13 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup14 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.interactivitySettingsRibbonPageGroup15 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
            this.targetDimensionsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup();
            this.chartTargetDimensionsArgumentsBarItem1 = new DevExpress.DashboardWin.Bars.ChartTargetDimensionsArgumentsBarItem();
            this.chartTargetDimensionsSeriesBarItem1 = new DevExpress.DashboardWin.Bars.ChartTargetDimensionsSeriesBarItem();
            this.chartTargetDimensionsPointsBarItem1 = new DevExpress.DashboardWin.Bars.ChartTargetDimensionsPointsBarItem();
            this.targetDimensionsRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup();
            this.pieTargetDimensionsArgumentsBarItem1 = new DevExpress.DashboardWin.Bars.PieTargetDimensionsArgumentsBarItem();
            this.pieTargetDimensionsSeriesBarItem1 = new DevExpress.DashboardWin.Bars.PieTargetDimensionsSeriesBarItem();
            this.pieTargetDimensionsPointsBarItem1 = new DevExpress.DashboardWin.Bars.PieTargetDimensionsPointsBarItem();
            this.geoPointMapClusterizationRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GeoPointMapClusterizationRibbonPageGroup();
            this.geoPointMapClusterizationBarItem1 = new DevExpress.DashboardWin.Bars.GeoPointMapClusterizationBarItem();
            this.geoPointMapClusterizationRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.GeoPointMapClusterizationRibbonPageGroup();
            this.geoPointMapClusterizationRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.GeoPointMapClusterizationRibbonPageGroup();
            this.commonItemDesignRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage1 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.showItemCaptionBarItem1 = new DevExpress.DashboardWin.Bars.ShowItemCaptionBarItem();
            this.editItemNamesBarItem1 = new DevExpress.DashboardWin.Bars.EditItemNamesBarItem();
            this.commonItemDesignRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage2 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage3 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage4 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage5 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage6 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage7 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.imageToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ImageToolsRibbonPageCategory();
            this.commonItemDesignRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage8 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage9 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup10 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage10 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup11 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage11 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup12 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage12 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup13 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage13 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup14 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage14 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup15 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage15 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup16 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage16 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.commonItemDesignRibbonPageGroup17 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
            this.dashboardItemDesignRibbonPage17 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
            this.contentArrangementRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
            this.contentAutoArrangeBarItem1 = new DevExpress.DashboardWin.Bars.ContentAutoArrangeBarItem();
            this.contentArrangeInColumnsBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangeInColumnsBarItem();
            this.contentArrangeInRowsBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangeInRowsBarItem();
            this.contentArrangementCountBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangementCountBarItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.contentArrangementRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
            this.contentArrangementRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
            this.gridStyleRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GridStyleRibbonPageGroup();
            this.gridHorizontalLinesBarItem1 = new DevExpress.DashboardWin.Bars.GridHorizontalLinesBarItem();
            this.gridVerticalLinesBarItem1 = new DevExpress.DashboardWin.Bars.GridVerticalLinesBarItem();
            this.gridBandedRowsBarItem1 = new DevExpress.DashboardWin.Bars.GridBandedRowsBarItem();
            this.gridLayoutRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GridLayoutRibbonPageGroup();
            this.gridMergeCellsBarItem1 = new DevExpress.DashboardWin.Bars.GridMergeCellsBarItem();
            this.gridColumnHeadersBarItem1 = new DevExpress.DashboardWin.Bars.GridColumnHeadersBarItem();
            this.gridWordWrapBarItem1 = new DevExpress.DashboardWin.Bars.GridWordWrapBarItem();
            this.gridColumnWidthModeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GridColumnWidthModeRibbonPageGroup();
            this.gridAutoFitToContentsColumnWidthModeBarItem1 = new DevExpress.DashboardWin.Bars.GridAutoFitToContentsColumnWidthModeBarItem();
            this.gridAutoFitToGridColumnWidthModeBarItem1 = new DevExpress.DashboardWin.Bars.GridAutoFitToGridColumnWidthModeBarItem();
            this.manualGridColumnWidthModeBarItem1 = new DevExpress.DashboardWin.Bars.ManualGridColumnWidthModeBarItem();
            this.chartLayoutPageGroup1 = new DevExpress.DashboardWin.Bars.ChartLayoutPageGroup();
            this.chartRotateBarItem1 = new DevExpress.DashboardWin.Bars.ChartRotateBarItem();
            this.chartXAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ChartXAxisSettingsBarItem();
            this.chartYAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ChartYAxisSettingsBarItem();
            this.scatterChartLayoutPageGroup1 = new DevExpress.DashboardWin.Bars.ScatterChartLayoutPageGroup();
            this.scatterChartRotateBarItem1 = new DevExpress.DashboardWin.Bars.ScatterChartRotateBarItem();
            this.scatterChartXAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ScatterChartXAxisSettingsBarItem();
            this.scatterChartYAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ScatterChartYAxisSettingsBarItem();
            this.scatterChartPointLabelPageGroup1 = new DevExpress.DashboardWin.Bars.ScatterChartPointLabelPageGroup();
            this.scatterChartPointLabelOptionsBarItem1 = new DevExpress.DashboardWin.Bars.ScatterChartPointLabelOptionsBarItem();
            this.chartLegendPositionPageGroup1 = new DevExpress.DashboardWin.Bars.ChartLegendPositionPageGroup();
            this.chartShowLegendBarItem1 = new DevExpress.DashboardWin.Bars.ChartShowLegendBarItem();
            this.galleryChartLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryChartLegendPositionItem();
            this.scatterChartLegendPositionPageGroup1 = new DevExpress.DashboardWin.Bars.ScatterChartLegendPositionPageGroup();
            this.scatterChartShowLegendBarItem1 = new DevExpress.DashboardWin.Bars.ScatterChartShowLegendBarItem();
            this.galleryScatterChartLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryScatterChartLegendPositionItem();
            this.chartStylePageGroup1 = new DevExpress.DashboardWin.Bars.ChartStylePageGroup();
            this.galleryChartSeriesTypeItem1 = new DevExpress.DashboardWin.Bars.GalleryChartSeriesTypeItem();
            this.pieLabelsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PieLabelsRibbonPageGroup();
            this.pieLabelsDataLabelsBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsBarItem();
            this.pieLabelsDataLabelsNoneBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsNoneBarItem();
            this.pieLabelsDataLabelArgumentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelArgumentBarItem();
            this.pieLabelsDataLabelsValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueBarItem();
            this.pieLabelsDataLabelsArgumentAndValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndValueBarItem();
            this.pieLabelsDataLabelsPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsPercentBarItem();
            this.pieLabelsDataLabelsValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueAndPercentBarItem();
            this.pieLabelsDataLabelsArgumentAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndPercentBarItem();
            this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentValueAndPercentBarItem();
            this.pieTooltipsBarItem1 = new DevExpress.DashboardWin.Bars.PieTooltipsBarItem();
            this.pieLabelsTooltipsNoneBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsNoneBarItem();
            this.pieLabelsTooltipsArgumentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentBarItem();
            this.pieLabelsTooltipsValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueBarItem();
            this.pieLabelsTooltipsArgumentAndValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndValueBarItem();
            this.pieLabelsTooltipsPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsPercentBarItem();
            this.pieLabelsTooltipsValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueAndPercentBarItem();
            this.pieLabelsTooltipsArgumentAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndPercentBarItem();
            this.pieLabelsTooltipsArgumentValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentValueAndPercentBarItem();
            this.pieStyleRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PieStyleRibbonPageGroup();
            this.pieStylePieBarItem1 = new DevExpress.DashboardWin.Bars.PieStylePieBarItem();
            this.pieStyleDonutBarItem1 = new DevExpress.DashboardWin.Bars.PieStyleDonutBarItem();
            this.pieShowCaptionsBarItem1 = new DevExpress.DashboardWin.Bars.PieShowCaptionsBarItem();
            this.gaugeStyleRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GaugeStyleRibbonPageGroup();
            this.gaugeStyleFullCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleFullCircularBarItem();
            this.gaugeStyleHalfCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleHalfCircularBarItem();
            this.gaugeStyleLeftQuarterCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLeftQuarterCircularBarItem();
            this.gaugeStyleRightQuarterCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleRightQuarterCircularBarItem();
            this.gaugeStyleThreeForthCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleThreeForthCircularBarItem();
            this.gaugeStyleLinearHorizontalBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLinearHorizontalBarItem();
            this.gaugeStyleLinearVerticalBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLinearVerticalBarItem();
            this.gaugesLabelsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GaugesLabelsRibbonPageGroup();
            this.gaugeShowCaptionsBarItem1 = new DevExpress.DashboardWin.Bars.GaugeShowCaptionsBarItem();
            this.imageOpenRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageOpenRibbonPageGroup();
            this.imageLoadBarItem1 = new DevExpress.DashboardWin.Bars.ImageLoadBarItem();
            this.imageImportBarItem1 = new DevExpress.DashboardWin.Bars.ImageImportBarItem();
            this.imageSizeModeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageSizeModeRibbonPageGroup();
            this.imageSizeModeClipBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeClipBarItem();
            this.imageSizeModeStretchBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeStretchBarItem();
            this.imageSizeModeSqueezeBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeSqueezeBarItem();
            this.imageSizeModeZoomBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeZoomBarItem();
            this.imageSizeModeRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.ImageSizeModeRibbonPageGroup();
            this.imageAlignmentRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageAlignmentRibbonPageGroup();
            this.imageAlignmentTopLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopLeftBarItem();
            this.imageAlignmentCenterLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterLeftBarItem();
            this.imageAlignmentBottomLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomLeftBarItem();
            this.imageAlignmentTopCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopCenterBarItem();
            this.imageAlignmentCenterCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterCenterBarItem();
            this.imageAlignmentBottomCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomCenterBarItem();
            this.imageAlignmentTopRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopRightBarItem();
            this.imageAlignmentCenterRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterRightBarItem();
            this.imageAlignmentBottomRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomRightBarItem();
            this.imageAlignmentRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.ImageAlignmentRibbonPageGroup();
            this.textBoxEditingRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.TextBoxEditingRibbonPageGroup();
            this.textBoxEditTextBarItem1 = new DevExpress.DashboardWin.Bars.TextBoxEditTextBarItem();
            this.textBoxInsertFieldBarItem1 = new DevExpress.DashboardWin.Bars.TextBoxInsertFieldBarItem();
            this.rangeFilterSeriesTypeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.RangeFilterSeriesTypeRibbonPageGroup();
            this.rangeFilterLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterLineSeriesTypeBarItem();
            this.rangeFilterStackedLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterStackedLineSeriesTypeBarItem();
            this.rangeFilterFullStackedLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterFullStackedLineSeriesTypeBarItem();
            this.rangeFilterAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterAreaSeriesTypeBarItem();
            this.rangeFilterStackedAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterStackedAreaSeriesTypeBarItem();
            this.rangeFilterFullStackedAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterFullStackedAreaSeriesTypeBarItem();
            this.rangeFilterBarSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterBarSeriesTypeBarItem();
            this.rangeFilterStackedBarSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterStackedBarSeriesTypeBarItem();
            this.rangeFilterFullStackedBarSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterFullStackedBarSeriesTypeBarItem();
            this.pivotLayoutRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PivotLayoutRibbonPageGroup();
            this.pivotInitialStateBarItem1 = new DevExpress.DashboardWin.Bars.PivotInitialStateBarItem();
            this.pivotAutoExpandColumnBarItem1 = new DevExpress.DashboardWin.Bars.PivotAutoExpandColumnBarItem();
            this.pivotAutoExpandRowBarItem1 = new DevExpress.DashboardWin.Bars.PivotAutoExpandRowBarItem();
            this.pivotShowTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowTotalsBarItem();
            this.pivotShowColumnTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowColumnTotalsBarItem();
            this.pivotShowRowTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowRowTotalsBarItem();
            this.pivotShowGrandTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowGrandTotalsBarItem();
            this.pivotShowColumnGrandTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowColumnGrandTotalsBarItem();
            this.pivotShowRowGrandTotalsBarItem1 = new DevExpress.DashboardWin.Bars.PivotShowRowGrandTotalsBarItem();
            this.filterElementTypeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FilterElementTypeRibbonPageGroup();
            this.comboBoxStandardTypeBarItem1 = new DevExpress.DashboardWin.Bars.ComboBoxStandardTypeBarItem();
            this.comboBoxCheckedTypeBarItem1 = new DevExpress.DashboardWin.Bars.ComboBoxCheckedTypeBarItem();
            this.listBoxCheckedTypeBarItem1 = new DevExpress.DashboardWin.Bars.ListBoxCheckedTypeBarItem();
            this.listBoxRadioTypeBarItem1 = new DevExpress.DashboardWin.Bars.ListBoxRadioTypeBarItem();
            this.treeViewLayoutRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.TreeViewLayoutRibbonPageGroup();
            this.treeViewAutoExpandBarItem1 = new DevExpress.DashboardWin.Bars.TreeViewAutoExpandBarItem();
            this.filterElementItemOptionsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FilterElementItemOptionsRibbonPageGroup();
            this.filterElementShowAllValueBarItem1 = new DevExpress.DashboardWin.Bars.FilterElementShowAllValueBarItem();
            this.mapShapefileRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
            this.mapLoadBarItem1 = new DevExpress.DashboardWin.Bars.MapLoadBarItem();
            this.mapImportBarItem1 = new DevExpress.DashboardWin.Bars.MapImportBarItem();
            this.mapDefaultShapefileBarItem1 = new DevExpress.DashboardWin.Bars.MapDefaultShapefileBarItem();
            this.mapWorldCountriesBarItem1 = new DevExpress.DashboardWin.Bars.MapWorldCountriesBarItem();
            this.mapEuropeBarItem1 = new DevExpress.DashboardWin.Bars.MapEuropeBarItem();
            this.mapAsiaBarItem1 = new DevExpress.DashboardWin.Bars.MapAsiaBarItem();
            this.mapNorthAmericaBarItem1 = new DevExpress.DashboardWin.Bars.MapNorthAmericaBarItem();
            this.mapSouthAmericaBarItem1 = new DevExpress.DashboardWin.Bars.MapSouthAmericaBarItem();
            this.mapAfricaBarItem1 = new DevExpress.DashboardWin.Bars.MapAfricaBarItem();
            this.mapUSABarItem1 = new DevExpress.DashboardWin.Bars.MapUSABarItem();
            this.mapCanadaBarItem1 = new DevExpress.DashboardWin.Bars.MapCanadaBarItem();
            this.mapShapefileRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
            this.mapShapefileRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
            this.mapShapefileRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
            this.mapNavigationPageGroup1 = new DevExpress.DashboardWin.Bars.MapNavigationPageGroup();
            this.mapLockNavigationBarItem1 = new DevExpress.DashboardWin.Bars.MapLockNavigationBarItem();
            this.mapFullExtentBarItem1 = new DevExpress.DashboardWin.Bars.MapFullExtentBarItem();
            this.mapNavigationPageGroup2 = new DevExpress.DashboardWin.Bars.MapNavigationPageGroup();
            this.mapNavigationPageGroup3 = new DevExpress.DashboardWin.Bars.MapNavigationPageGroup();
            this.mapNavigationPageGroup4 = new DevExpress.DashboardWin.Bars.MapNavigationPageGroup();
            this.mapShapeLabelsAttributePageGroup1 = new DevExpress.DashboardWin.Bars.MapShapeLabelsAttributePageGroup();
            this.choroplethMapShapeLabelsAttributeBarItem1 = new DevExpress.DashboardWin.Bars.ChoroplethMapShapeLabelsAttributeBarItem();
            this.mapShapeLabelsAttributePageGroup2 = new DevExpress.DashboardWin.Bars.MapShapeLabelsAttributePageGroup();
            this.mapShapeTitleAttributeBarItem1 = new DevExpress.DashboardWin.Bars.MapShapeTitleAttributeBarItem();
            this.mapShapeLabelsAttributePageGroup3 = new DevExpress.DashboardWin.Bars.MapShapeLabelsAttributePageGroup();
            this.mapShapeLabelsAttributePageGroup4 = new DevExpress.DashboardWin.Bars.MapShapeLabelsAttributePageGroup();
            this.mapLegendPositionPageGroup1 = new DevExpress.DashboardWin.Bars.MapLegendPositionPageGroup();
            this.mapShowLegendBarItem1 = new DevExpress.DashboardWin.Bars.MapShowLegendBarItem();
            this.galleryMapLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryMapLegendPositionItem();
            this.mapLegendPositionPageGroup2 = new DevExpress.DashboardWin.Bars.MapLegendPositionPageGroup();
            this.mapLegendPositionPageGroup3 = new DevExpress.DashboardWin.Bars.MapLegendPositionPageGroup();
            this.weightedLegendPageGroup1 = new DevExpress.DashboardWin.Bars.WeightedLegendPageGroup();
            this.changeWeightedLegendTypeBarItem1 = new DevExpress.DashboardWin.Bars.ChangeWeightedLegendTypeBarItem();
            this.weightedLegendNoneBarItem1 = new DevExpress.DashboardWin.Bars.WeightedLegendNoneBarItem();
            this.weightedLegendLinearBarItem1 = new DevExpress.DashboardWin.Bars.WeightedLegendLinearBarItem();
            this.weightedLegendNestedBarItem1 = new DevExpress.DashboardWin.Bars.WeightedLegendNestedBarItem();
            this.galleryWeightedLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryWeightedLegendPositionItem();
            this.weightedLegendPageGroup2 = new DevExpress.DashboardWin.Bars.WeightedLegendPageGroup();
            this.pieMapOptionsPageGroup1 = new DevExpress.DashboardWin.Bars.PieMapOptionsPageGroup();
            this.pieMapIsWeightedBarItem1 = new DevExpress.DashboardWin.Bars.PieMapIsWeightedBarItem();
            this.coloringOptionsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ColoringOptionsRibbonPageGroup();
            this.useGlobalColorsBarItem1 = new DevExpress.DashboardWin.Bars.UseGlobalColorsBarItem();
            this.useLocalColorsBarItem1 = new DevExpress.DashboardWin.Bars.UseLocalColorsBarItem();
            this.editActualColorsBarItem1 = new DevExpress.DashboardWin.Bars.EditActualColorsBarItem();
            this.coloringOptionsRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.ColoringOptionsRibbonPageGroup();
            this.coloringOptionsRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.ColoringOptionsRibbonPageGroup();
            this.coloringOptionsRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.ColoringOptionsRibbonPageGroup();
            this.coloringOptionsRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.ColoringOptionsRibbonPageGroup();
            this.textBoxEditorBarController1 = new DevExpress.DashboardWin.Bars.TextBoxEditorBarController();
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.textBoxEditorRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.TextBoxEditorRibbonPageCategory();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup();
            this.homeRibbonPage2 = new DevExpress.XtraRichEdit.UI.HomeRibbonPage();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup();
            this.galleryChangeStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem();
            this.editingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            this.linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.pageBackgroundRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage();
            this.changePageColorItem1 = new DevExpress.XtraRichEdit.UI.ChangePageColorItem();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup();
            this.tableDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableDesignRibbonPage();
            this.toggleFirstRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstRowItem();
            this.toggleLastRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastRowItem();
            this.toggleBandedRowsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem();
            this.toggleFirstColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem();
            this.toggleLastColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastColumnItem();
            this.toggleBandedColumnsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup();
            this.galleryChangeTableStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem();
            this.tableDrawBordersRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup();
            this.changeTableBorderLineStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem();
            this.changeTableBorderLineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem();
            this.changeTableBorderColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem();
            this.changeTableBordersItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBordersItem();
            this.toggleTableCellsBottomBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem();
            this.toggleTableCellsTopBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem();
            this.toggleTableCellsLeftBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem();
            this.toggleTableCellsRightBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem();
            this.resetTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem();
            this.toggleTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem();
            this.toggleTableCellsOutsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem();
            this.toggleTableCellsInsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem();
            this.toggleTableCellsInsideHorizontalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem();
            this.toggleTableCellsInsideVerticalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem();
            this.toggleShowTableGridLinesItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem();
            this.changeTableCellsShadingItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem();
            this.repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.tableTableRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup();
            this.tableLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage();
            this.selectTableElementsItem1 = new DevExpress.XtraRichEdit.UI.SelectTableElementsItem();
            this.selectTableCellItem1 = new DevExpress.XtraRichEdit.UI.SelectTableCellItem();
            this.selectTableColumnItem1 = new DevExpress.XtraRichEdit.UI.SelectTableColumnItem();
            this.selectTableRowItem1 = new DevExpress.XtraRichEdit.UI.SelectTableRowItem();
            this.selectTableItem1 = new DevExpress.XtraRichEdit.UI.SelectTableItem();
            this.showTablePropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem();
            this.tableRowsAndColumnsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup();
            this.deleteTableElementsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableElementsItem();
            this.showDeleteTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem();
            this.deleteTableColumnsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem();
            this.deleteTableRowsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableRowsItem();
            this.deleteTableItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableItem();
            this.insertTableRowAboveItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem();
            this.insertTableRowBelowItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem();
            this.insertTableColumnToLeftItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem();
            this.insertTableColumnToRightItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem();
            this.tableMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup();
            this.mergeTableCellsItem1 = new DevExpress.XtraRichEdit.UI.MergeTableCellsItem();
            this.showSplitTableCellsForm1 = new DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm();
            this.splitTableItem1 = new DevExpress.XtraRichEdit.UI.SplitTableItem();
            this.tableCellSizeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup();
            this.toggleTableAutoFitItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem();
            this.toggleTableAutoFitContentsItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem();
            this.toggleTableAutoFitWindowItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem();
            this.toggleTableFixedColumnWidthItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem();
            this.tableAlignmentRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup();
            this.toggleTableCellsTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem();
            this.toggleTableCellsMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem();
            this.toggleTableCellsBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem();
            this.toggleTableCellsTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem();
            this.toggleTableCellsMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem();
            this.toggleTableCellsBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem();
            this.toggleTableCellsTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem();
            this.toggleTableCellsMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem();
            this.toggleTableCellsBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem();
            this.showTableOptionsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem();
            this.floatingPictureToolsShapeStylesPageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup();
            this.floatingPictureToolsFormatPage1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage();
            this.changeFloatingObjectFillColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem();
            this.changeFloatingObjectOutlineColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem();
            this.changeFloatingObjectOutlineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem();
            this.repositoryItemFloatingObjectOutlineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            this.floatingPictureToolsArrangePageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup();
            this.changeFloatingObjectTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem();
            this.setFloatingObjectSquareTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem();
            this.setFloatingObjectTightTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem();
            this.setFloatingObjectThroughTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem();
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem();
            this.setFloatingObjectBehindTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem();
            this.setFloatingObjectInFrontOfTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem();
            this.changeFloatingObjectAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem();
            this.setFloatingObjectTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem();
            this.setFloatingObjectTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem();
            this.setFloatingObjectTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem();
            this.setFloatingObjectMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem();
            this.setFloatingObjectMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem();
            this.setFloatingObjectMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem();
            this.setFloatingObjectBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem();
            this.setFloatingObjectBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem();
            this.setFloatingObjectBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem();
            this.floatingObjectBringForwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem();
            this.floatingObjectBringForwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem();
            this.floatingObjectBringToFrontItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem();
            this.floatingObjectBringInFrontOfTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem();
            this.floatingObjectSendBackwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem();
            this.floatingObjectSendBackwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem();
            this.floatingObjectSendToBackItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem();
            this.floatingObjectSendBehindTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem();
            this.dashboardPopupMenu1 = new DevExpress.DashboardWin.DashboardPopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardBarAndDockingController1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardBackstageViewControl1).BeginInit();
            this.dashboardBackstageViewControl1.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dashboardBarController1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.textBoxEditorBarController1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemFontEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemRichEditFontSizeEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemBorderLineStyle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemBorderLineWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemFloatingObjectOutlineWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardPopupMenu1).BeginInit();
            base.SuspendLayout();
            this.dashboardDesigner1.DataSourceWizardSettings.QueryBuilderDiagramView = false;
            this.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner1.Location = new System.Drawing.Point(0, 141);
            this.dashboardDesigner1.MenuManager = this.ribbonControl1;
            this.dashboardDesigner1.Name = "dashboardDesigner1";
            this.dashboardDesigner1.PopupMenu = this.dashboardPopupMenu1;
            this.dashboardDesigner1.Size = new System.Drawing.Size(784, 420);
            this.dashboardDesigner1.TabIndex = 0;
            //this.ribbonControl1.ApplicationButtonDropDownControl = this.dashboardBackstageViewControl1;
            this.ribbonControl1.Controller = this.dashboardBarAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[371]
            {
            this.ribbonControl1.ExpandCollapseItem,
            this.fileNewBarItem1,
            this.fileOpenBarItem1,
            this.fileSaveBarItem1,
            this.fileSaveAsBarItem1,
            this.quickAccessUndoBarItem1,
            this.quickAccessRedoBarItem1,
            this.undoBarItem1,
            this.redoBarItem1,
            this.newDataSourceBarItem1,
            this.editSqlConnectionBarItem1,
            this.editOlapConnectionBarItem1,
            this.editObjectDataSourceBarItem1,
            this.editExcelDataSourceBarItem1,
            this.editEFDataSourceBarItem1,
            this.editExtractOptionsBarItem1,
            this.renameDataSourceBarItem1,
            this.deleteDataSourceBarItem1,
            this.serverModeBarItem1,
            this.upateDataExtractBarItem1,
            this.addCalculatedFieldBarItem1,
            this.addQueryBarItem1,
            this.editQueryBarItem1,
            this.renameQueryBarItem1,
            this.editQueryFilterBarItem1,
            this.deleteQueryBarItem1,
            this.editExtractSourceConnectionBarItem1,
            this.editExtractSourceBarItem1,
            this.editExtractSourceQueryBarItem1,
            this.editDataSourceFilterBarItem1,
            this.clearDataSourceFilterBarItem1,
            this.insertPivotBarItem1,
            this.insertGridBarItem1,
            this.insertChartBarItem1,
            this.insertScatterChartBarItem1,
            this.insertPiesBarItem1,
            this.insertGaugesBarItem1,
            this.insertCardsBarItem1,
            this.insertChoroplethMapBarItem1,
            this.insertGeoPointMapBarSubItem1,
            this.insertGeoPointMapBarItem1,
            this.insertBubbleMapBarItem1,
            this.insertPieMapBarItem1,
            this.insertRangeFilterBarItem1,
            this.insertFilterElementSubItem1,
            this.insertComboBoxBarItem1,
            this.insertListBoxBarItem1,
            this.insertTreeViewBarItem1,
            this.insertImagesBarSubItem1,
            this.insertImageBarItem1,
            this.insertBoundImageBarItem1,
            this.insertTextBoxBarItem1,
            this.insertGroupBarItem1,
            this.duplicateItemBarItem1,
            this.deleteItemBarItem1,
            this.convertDashboardItemTypeBarItem1,
            this.convertToPivotBarItem1,
            this.convertToGridBarItem1,
            this.convertToChartBarItem1,
            this.convertToScatterChartBarItem1,
            this.convertToPieBarItem1,
            this.convertToGaugeBarItem1,
            this.convertToCardBarItem1,
            this.convertToChoroplethMapBarItem1,
            this.convertToBoundImageBarItem1,
            this.convertToGeoPointMapBarItem1,
            this.convertToBubbleMapBarItem1,
            this.convertToPieMapBarItem1,
            this.convertGeoPointMapBaseBarItem1,
            this.convertToRangeFilterBarItem1,
            this.convertToComboBoxBarItem1,
            this.convertToListBoxBarItem1,
            this.convertToTreeViewBarItem1,
            this.convertToFilterElementsBaseBarItem1,
            this.removeDataItemsBarItem1,
            this.transposeItemBarItem1,
            this.editRulesBarItem1,
            this.deleteGroupBarItem1,
            this.dashboardTitleBarItem1,
            this.setCurrencyCultureBarItem1,
            this.dashboardColorSchemeBarItem1,
            this.dashboardParametersBarItem1,
            this.dashboardAutomaticUpdatesBarItem1,
            this.updateDataBarItem1,
            this.dashboardSkinsBarItem1,
            this.editFilterBarItem1,
            this.clearFilterBarItem1,
            this.masterFilterBarItem1,
            this.multipleValuesMasterFilterBarItem1,
            this.drillDownBarItem1,
            this.groupMasterFilterBarItem1,
            this.groupIgnoreMasterFilterBarItem1,
            this.ignoreMasterFiltersBarItem1,
            this.crossDataSourceFilteringBarItem1,
            this.chartTargetDimensionsArgumentsBarItem1,
            this.chartTargetDimensionsSeriesBarItem1,
            this.chartTargetDimensionsPointsBarItem1,
            this.pieTargetDimensionsArgumentsBarItem1,
            this.pieTargetDimensionsSeriesBarItem1,
            this.pieTargetDimensionsPointsBarItem1,
            this.geoPointMapClusterizationBarItem1,
            this.showItemCaptionBarItem1,
            this.editItemNamesBarItem1,
            this.contentAutoArrangeBarItem1,
            this.contentArrangeInColumnsBarItem1,
            this.contentArrangeInRowsBarItem1,
            this.contentArrangementCountBarItem1,
            this.gridHorizontalLinesBarItem1,
            this.gridVerticalLinesBarItem1,
            this.gridBandedRowsBarItem1,
            this.gridMergeCellsBarItem1,
            this.gridColumnHeadersBarItem1,
            this.gridWordWrapBarItem1,
            this.gridAutoFitToContentsColumnWidthModeBarItem1,
            this.gridAutoFitToGridColumnWidthModeBarItem1,
            this.manualGridColumnWidthModeBarItem1,
            this.chartRotateBarItem1,
            this.chartXAxisSettingsBarItem1,
            this.chartYAxisSettingsBarItem1,
            this.scatterChartRotateBarItem1,
            this.scatterChartXAxisSettingsBarItem1,
            this.scatterChartYAxisSettingsBarItem1,
            this.scatterChartPointLabelOptionsBarItem1,
            this.chartShowLegendBarItem1,
            this.galleryChartLegendPositionItem1,
            this.scatterChartShowLegendBarItem1,
            this.galleryScatterChartLegendPositionItem1,
            this.galleryChartSeriesTypeItem1,
            this.pieLabelsDataLabelsBarItem1,
            this.pieLabelsDataLabelsNoneBarItem1,
            this.pieLabelsDataLabelArgumentBarItem1,
            this.pieLabelsDataLabelsValueBarItem1,
            this.pieLabelsDataLabelsArgumentAndValueBarItem1,
            this.pieLabelsDataLabelsPercentBarItem1,
            this.pieLabelsDataLabelsValueAndPercentBarItem1,
            this.pieLabelsDataLabelsArgumentAndPercentBarItem1,
            this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1,
            this.pieTooltipsBarItem1,
            this.pieLabelsTooltipsNoneBarItem1,
            this.pieLabelsTooltipsArgumentBarItem1,
            this.pieLabelsTooltipsValueBarItem1,
            this.pieLabelsTooltipsArgumentAndValueBarItem1,
            this.pieLabelsTooltipsPercentBarItem1,
            this.pieLabelsTooltipsValueAndPercentBarItem1,
            this.pieLabelsTooltipsArgumentAndPercentBarItem1,
            this.pieLabelsTooltipsArgumentValueAndPercentBarItem1,
            this.pieStylePieBarItem1,
            this.pieStyleDonutBarItem1,
            this.pieShowCaptionsBarItem1,
            this.gaugeStyleFullCircularBarItem1,
            this.gaugeStyleHalfCircularBarItem1,
            this.gaugeStyleLeftQuarterCircularBarItem1,
            this.gaugeStyleRightQuarterCircularBarItem1,
            this.gaugeStyleThreeForthCircularBarItem1,
            this.gaugeStyleLinearHorizontalBarItem1,
            this.gaugeStyleLinearVerticalBarItem1,
            this.gaugeShowCaptionsBarItem1,
            this.imageLoadBarItem1,
            this.imageImportBarItem1,
            this.imageSizeModeClipBarItem1,
            this.imageSizeModeStretchBarItem1,
            this.imageSizeModeSqueezeBarItem1,
            this.imageSizeModeZoomBarItem1,
            this.imageAlignmentTopLeftBarItem1,
            this.imageAlignmentCenterLeftBarItem1,
            this.imageAlignmentBottomLeftBarItem1,
            this.imageAlignmentTopCenterBarItem1,
            this.imageAlignmentCenterCenterBarItem1,
            this.imageAlignmentBottomCenterBarItem1,
            this.imageAlignmentTopRightBarItem1,
            this.imageAlignmentCenterRightBarItem1,
            this.imageAlignmentBottomRightBarItem1,
            this.textBoxEditTextBarItem1,
            this.textBoxInsertFieldBarItem1,
            this.rangeFilterLineSeriesTypeBarItem1,
            this.rangeFilterStackedLineSeriesTypeBarItem1,
            this.rangeFilterFullStackedLineSeriesTypeBarItem1,
            this.rangeFilterAreaSeriesTypeBarItem1,
            this.rangeFilterStackedAreaSeriesTypeBarItem1,
            this.rangeFilterFullStackedAreaSeriesTypeBarItem1,
            this.rangeFilterBarSeriesTypeBarItem1,
            this.rangeFilterStackedBarSeriesTypeBarItem1,
            this.rangeFilterFullStackedBarSeriesTypeBarItem1,
            this.pivotInitialStateBarItem1,
            this.pivotAutoExpandColumnBarItem1,
            this.pivotAutoExpandRowBarItem1,
            this.pivotShowTotalsBarItem1,
            this.pivotShowColumnTotalsBarItem1,
            this.pivotShowRowTotalsBarItem1,
            this.pivotShowGrandTotalsBarItem1,
            this.pivotShowColumnGrandTotalsBarItem1,
            this.pivotShowRowGrandTotalsBarItem1,
            this.comboBoxStandardTypeBarItem1,
            this.comboBoxCheckedTypeBarItem1,
            this.listBoxCheckedTypeBarItem1,
            this.listBoxRadioTypeBarItem1,
            this.treeViewAutoExpandBarItem1,
            this.filterElementShowAllValueBarItem1,
            this.mapLoadBarItem1,
            this.mapImportBarItem1,
            this.mapDefaultShapefileBarItem1,
            this.mapWorldCountriesBarItem1,
            this.mapEuropeBarItem1,
            this.mapAsiaBarItem1,
            this.mapNorthAmericaBarItem1,
            this.mapSouthAmericaBarItem1,
            this.mapAfricaBarItem1,
            this.mapUSABarItem1,
            this.mapCanadaBarItem1,
            this.mapLockNavigationBarItem1,
            this.mapFullExtentBarItem1,
            this.choroplethMapShapeLabelsAttributeBarItem1,
            this.mapShapeTitleAttributeBarItem1,
            this.mapShowLegendBarItem1,
            this.galleryMapLegendPositionItem1,
            this.changeWeightedLegendTypeBarItem1,
            this.weightedLegendNoneBarItem1,
            this.weightedLegendLinearBarItem1,
            this.weightedLegendNestedBarItem1,
            this.galleryWeightedLegendPositionItem1,
            this.pieMapIsWeightedBarItem1,
            this.useGlobalColorsBarItem1,
            this.useLocalColorsBarItem1,
            this.editActualColorsBarItem1,
            this.undoItem1,
            this.redoItem1,
            this.fileOpenItem1,
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.barButtonGroup2,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.barButtonGroup3,
            this.changeFontColorItem1,
            this.changeFontBackColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.capitalizeEachWordCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.barButtonGroup4,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.barButtonGroup5,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.barButtonGroup6,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleShowWhitespaceItem1,
            this.barButtonGroup7,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.galleryChangeStyleItem1,
            this.findItem1,
            this.replaceItem1,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertFloatingPictureItem1,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.insertSymbolItem1,
            this.changePageColorItem1,
            this.toggleFirstRowItem1,
            this.toggleLastRowItem1,
            this.toggleBandedRowsItem1,
            this.toggleFirstColumnItem1,
            this.toggleLastColumnItem1,
            this.toggleBandedColumnsItem1,
            this.galleryChangeTableStyleItem1,
            this.changeTableBorderLineStyleItem1,
            this.changeTableBorderLineWeightItem1,
            this.changeTableBorderColorItem1,
            this.changeTableBordersItem1,
            this.toggleTableCellsBottomBorderItem1,
            this.toggleTableCellsTopBorderItem1,
            this.toggleTableCellsLeftBorderItem1,
            this.toggleTableCellsRightBorderItem1,
            this.resetTableCellsAllBordersItem1,
            this.toggleTableCellsAllBordersItem1,
            this.toggleTableCellsOutsideBorderItem1,
            this.toggleTableCellsInsideBorderItem1,
            this.toggleTableCellsInsideHorizontalBorderItem1,
            this.toggleTableCellsInsideVerticalBorderItem1,
            this.toggleShowTableGridLinesItem1,
            this.changeTableCellsShadingItem1,
            this.selectTableElementsItem1,
            this.selectTableCellItem1,
            this.selectTableColumnItem1,
            this.selectTableRowItem1,
            this.selectTableItem1,
            this.showTablePropertiesFormItem1,
            this.deleteTableElementsItem1,
            this.showDeleteTableCellsFormItem1,
            this.deleteTableColumnsItem1,
            this.deleteTableRowsItem1,
            this.deleteTableItem1,
            this.insertTableRowAboveItem1,
            this.insertTableRowBelowItem1,
            this.insertTableColumnToLeftItem1,
            this.insertTableColumnToRightItem1,
            this.mergeTableCellsItem1,
            this.showSplitTableCellsForm1,
            this.splitTableItem1,
            this.toggleTableAutoFitItem1,
            this.toggleTableAutoFitContentsItem1,
            this.toggleTableAutoFitWindowItem1,
            this.toggleTableFixedColumnWidthItem1,
            this.toggleTableCellsTopLeftAlignmentItem1,
            this.toggleTableCellsMiddleLeftAlignmentItem1,
            this.toggleTableCellsBottomLeftAlignmentItem1,
            this.toggleTableCellsTopCenterAlignmentItem1,
            this.toggleTableCellsMiddleCenterAlignmentItem1,
            this.toggleTableCellsBottomCenterAlignmentItem1,
            this.toggleTableCellsTopRightAlignmentItem1,
            this.toggleTableCellsMiddleRightAlignmentItem1,
            this.toggleTableCellsBottomRightAlignmentItem1,
            this.showTableOptionsFormItem1,
            this.changeFloatingObjectFillColorItem1,
            this.changeFloatingObjectOutlineColorItem1,
            this.changeFloatingObjectOutlineWeightItem1,
            this.changeFloatingObjectTextWrapTypeItem1,
            this.setFloatingObjectSquareTextWrapTypeItem1,
            this.setFloatingObjectTightTextWrapTypeItem1,
            this.setFloatingObjectThroughTextWrapTypeItem1,
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1,
            this.setFloatingObjectBehindTextWrapTypeItem1,
            this.setFloatingObjectInFrontOfTextWrapTypeItem1,
            this.changeFloatingObjectAlignmentItem1,
            this.setFloatingObjectTopLeftAlignmentItem1,
            this.setFloatingObjectTopCenterAlignmentItem1,
            this.setFloatingObjectTopRightAlignmentItem1,
            this.setFloatingObjectMiddleLeftAlignmentItem1,
            this.setFloatingObjectMiddleCenterAlignmentItem1,
            this.setFloatingObjectMiddleRightAlignmentItem1,
            this.setFloatingObjectBottomLeftAlignmentItem1,
            this.setFloatingObjectBottomCenterAlignmentItem1,
            this.setFloatingObjectBottomRightAlignmentItem1,
            this.floatingObjectBringForwardSubItem1,
            this.floatingObjectBringForwardItem1,
            this.floatingObjectBringToFrontItem1,
            this.floatingObjectBringInFrontOfTextItem1,
            this.floatingObjectSendBackwardSubItem1,
            this.floatingObjectSendBackwardItem1,
            this.floatingObjectSendToBackItem1,
            this.floatingObjectSendBehindTextItem1
            });
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 371;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[18]
            {
            this.pivotToolsRibbonPageCategory1, this.gridToolsRibbonPageCategory1, this.chartToolsRibbonPageCategory1, this.scatterChartToolsRibbonPageCategory1, this.piesToolsRibbonPageCategory1, this.gaugesToolsRibbonPageCategory1, this.cardsToolsRibbonPageCategory1, this.rangeFilterToolsRibbonPageCategory1, this.choroplethMapToolsRibbonPageCategory1, this.geoPointMapToolsRibbonPageCategory1,
            this.bubbleMapToolsRibbonPageCategory1, this.pieMapToolsRibbonPageCategory1, this.filterElementToolsRibbonPageCategory1, this.boundImageToolsRibbonPageCategory1, this.textBoxToolsRibbonPageCategory1, this.groupToolsRibbonPageCategory1, this.imageToolsRibbonPageCategory1, this.textBoxEditorRibbonPageCategory1
            });
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[3] { this.homeRibbonPage1, this.dataSourceRibbonPage1, this.viewRibbonPage1 });
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.fileSaveBarItem1);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.quickAccessUndoBarItem1);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.quickAccessRedoBarItem1);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.updateDataBarItem1);
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[6] { this.repositoryItemSpinEdit1, this.repositoryItemFontEdit1, this.repositoryItemRichEditFontSizeEdit1, this.repositoryItemBorderLineStyle1, this.repositoryItemBorderLineWeight1, this.repositoryItemFloatingObjectOutlineWeight1 });
            //this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(784, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            this.dashboardBarAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.dashboardBarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            this.dashboardBackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.dashboardBackstageViewControl1.Controller = this.dashboardBarAndDockingController1;
            this.dashboardBackstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.dashboardBackstageViewControl1.DashboardRecentTab = this.dashboardBackstageRecentTab1;
            this.dashboardBackstageViewControl1.Items.Add(this.dashboardBackstageNewButton1);
            this.dashboardBackstageViewControl1.Items.Add(this.dashboardBackstageOpenButton1);
            this.dashboardBackstageViewControl1.Items.Add(this.dashboardBackstageSaveButton1);
            this.dashboardBackstageViewControl1.Items.Add(this.dashboardBackstageSaveAsButton1);
            this.dashboardBackstageViewControl1.Items.Add(this.dashboardBackstageRecentTab1);
            this.dashboardBackstageViewControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardBackstageViewControl1.Name = "dashboardBackstageViewControl1";
            //this.dashboardBackstageViewControl1.OwnerControl = this.ribbonControl1;
            this.dashboardBackstageViewControl1.SelectedTab = this.dashboardBackstageRecentTab1;
            this.dashboardBackstageViewControl1.SelectedTabIndex = 4;
            this.dashboardBackstageViewControl1.Size = new System.Drawing.Size(240, 150);
            this.dashboardBackstageViewControl1.TabIndex = 2;
            //this.dashboardBackstageNewButton1.Glyph = (System.Drawing.Image)resources.GetObject("dashboardBackstageNewButton1.Glyph");
            this.dashboardBackstageNewButton1.Name = "dashboardBackstageNewButton1";
            this.dashboardBackstageNewButton1.ServiceProvider = this.dashboardDesigner1;
            //this.dashboardBackstageOpenButton1.Glyph = (System.Drawing.Image)resources.GetObject("dashboardBackstageOpenButton1.Glyph");
            this.dashboardBackstageOpenButton1.Name = "dashboardBackstageOpenButton1";
            this.dashboardBackstageOpenButton1.ServiceProvider = this.dashboardDesigner1;
           // this.dashboardBackstageSaveButton1.Glyph = (System.Drawing.Image)resources.GetObject("dashboardBackstageSaveButton1.Glyph");
            this.dashboardBackstageSaveButton1.Name = "dashboardBackstageSaveButton1";
            this.dashboardBackstageSaveButton1.ServiceProvider = this.dashboardDesigner1;
           // this.dashboardBackstageSaveAsButton1.Glyph = (System.Drawing.Image)resources.GetObject("dashboardBackstageSaveAsButton1.Glyph");
            this.dashboardBackstageSaveAsButton1.Name = "dashboardBackstageSaveAsButton1";
            this.dashboardBackstageSaveAsButton1.ServiceProvider = this.dashboardDesigner1;
            this.dashboardBackstageRecentTab1.ContentControl = this.backstageViewClientControl1;
            this.dashboardBackstageRecentTab1.Name = "dashboardBackstageRecentTab1";
            this.dashboardBackstageRecentTab1.RecentDashboardsControl = this.recentDashboardsControl1;
            this.dashboardBackstageRecentTab1.Selected = true;
            this.backstageViewClientControl1.Controls.Add(this.recentDashboardsControl1);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(0, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(150, 150);
            this.backstageViewClientControl1.TabIndex = 1;
            this.recentDashboardsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentDashboardsControl1.ForeColor = System.Drawing.Color.Transparent;
            this.recentDashboardsControl1.Location = new System.Drawing.Point(0, 0);
            this.recentDashboardsControl1.Name = "recentDashboardsControl1";
            this.recentDashboardsControl1.ServiceProvider = this.dashboardDesigner1;
            this.recentDashboardsControl1.Size = new System.Drawing.Size(150, 150);
            this.recentDashboardsControl1.TabIndex = 0;
            this.dashboardBarController1.BarItems.Add(this.fileNewBarItem1);
            this.dashboardBarController1.BarItems.Add(this.fileOpenBarItem1);
            this.dashboardBarController1.BarItems.Add(this.fileSaveBarItem1);
            this.dashboardBarController1.BarItems.Add(this.fileSaveAsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.quickAccessUndoBarItem1);
            this.dashboardBarController1.BarItems.Add(this.quickAccessRedoBarItem1);
            this.dashboardBarController1.BarItems.Add(this.undoBarItem1);
            this.dashboardBarController1.BarItems.Add(this.redoBarItem1);
            this.dashboardBarController1.BarItems.Add(this.newDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editSqlConnectionBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editOlapConnectionBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editObjectDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editExcelDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editEFDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editExtractOptionsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.renameDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.deleteDataSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.serverModeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.upateDataExtractBarItem1);
            this.dashboardBarController1.BarItems.Add(this.addCalculatedFieldBarItem1);
            this.dashboardBarController1.BarItems.Add(this.addQueryBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editQueryBarItem1);
            this.dashboardBarController1.BarItems.Add(this.renameQueryBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editQueryFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.deleteQueryBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editExtractSourceConnectionBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editExtractSourceBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editExtractSourceQueryBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editDataSourceFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.clearDataSourceFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertPivotBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertGridBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertChartBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertScatterChartBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertPiesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertGaugesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertCardsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertChoroplethMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertGeoPointMapBarSubItem1);
            this.dashboardBarController1.BarItems.Add(this.insertGeoPointMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertBubbleMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertPieMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertRangeFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertFilterElementSubItem1);
            this.dashboardBarController1.BarItems.Add(this.insertComboBoxBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertListBoxBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertTreeViewBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertImagesBarSubItem1);
            this.dashboardBarController1.BarItems.Add(this.insertImageBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertBoundImageBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertTextBoxBarItem1);
            this.dashboardBarController1.BarItems.Add(this.insertGroupBarItem1);
            this.dashboardBarController1.BarItems.Add(this.duplicateItemBarItem1);
            this.dashboardBarController1.BarItems.Add(this.deleteItemBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertDashboardItemTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToPivotBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToGridBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToChartBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToScatterChartBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToPieBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToGaugeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToCardBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToChoroplethMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToBoundImageBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertGeoPointMapBaseBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToGeoPointMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToBubbleMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToPieMapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToRangeFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToFilterElementsBaseBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToComboBoxBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToListBoxBarItem1);
            this.dashboardBarController1.BarItems.Add(this.convertToTreeViewBarItem1);
            this.dashboardBarController1.BarItems.Add(this.removeDataItemsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.transposeItemBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editRulesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.deleteGroupBarItem1);
            this.dashboardBarController1.BarItems.Add(this.dashboardTitleBarItem1);
            this.dashboardBarController1.BarItems.Add(this.setCurrencyCultureBarItem1);
            this.dashboardBarController1.BarItems.Add(this.dashboardColorSchemeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.dashboardParametersBarItem1);
            this.dashboardBarController1.BarItems.Add(this.dashboardAutomaticUpdatesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.updateDataBarItem1);
            this.dashboardBarController1.BarItems.Add(this.dashboardSkinsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.clearFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.masterFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.multipleValuesMasterFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.drillDownBarItem1);
            this.dashboardBarController1.BarItems.Add(this.groupMasterFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.groupIgnoreMasterFilterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.ignoreMasterFiltersBarItem1);
            this.dashboardBarController1.BarItems.Add(this.crossDataSourceFilteringBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartTargetDimensionsArgumentsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartTargetDimensionsSeriesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartTargetDimensionsPointsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieTargetDimensionsArgumentsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieTargetDimensionsSeriesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieTargetDimensionsPointsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.geoPointMapClusterizationBarItem1);
            this.dashboardBarController1.BarItems.Add(this.showItemCaptionBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editItemNamesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.contentAutoArrangeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.contentArrangeInColumnsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.contentArrangeInRowsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.contentArrangementCountBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridHorizontalLinesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridVerticalLinesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridBandedRowsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridMergeCellsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridColumnHeadersBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridWordWrapBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridAutoFitToContentsColumnWidthModeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gridAutoFitToGridColumnWidthModeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.manualGridColumnWidthModeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartRotateBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartXAxisSettingsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartYAxisSettingsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.scatterChartRotateBarItem1);
            this.dashboardBarController1.BarItems.Add(this.scatterChartXAxisSettingsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.scatterChartYAxisSettingsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.scatterChartPointLabelOptionsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.chartShowLegendBarItem1);
            this.dashboardBarController1.BarItems.Add(this.galleryChartLegendPositionItem1);
            this.dashboardBarController1.BarItems.Add(this.scatterChartShowLegendBarItem1);
            this.dashboardBarController1.BarItems.Add(this.galleryScatterChartLegendPositionItem1);
            this.dashboardBarController1.BarItems.Add(this.galleryChartSeriesTypeItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsNoneBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelArgumentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsValueBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsArgumentAndValueBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsValueAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsArgumentAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieTooltipsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsNoneBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsArgumentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsValueBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsArgumentAndValueBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsValueAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsArgumentAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieLabelsTooltipsArgumentValueAndPercentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieStylePieBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieStyleDonutBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pieShowCaptionsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleFullCircularBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleHalfCircularBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleLeftQuarterCircularBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleRightQuarterCircularBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleThreeForthCircularBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleLinearHorizontalBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeStyleLinearVerticalBarItem1);
            this.dashboardBarController1.BarItems.Add(this.gaugeShowCaptionsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageLoadBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageImportBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageSizeModeClipBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageSizeModeStretchBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageSizeModeSqueezeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageSizeModeZoomBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentTopLeftBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentCenterLeftBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentBottomLeftBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentTopCenterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentCenterCenterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentBottomCenterBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentTopRightBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentCenterRightBarItem1);
            this.dashboardBarController1.BarItems.Add(this.imageAlignmentBottomRightBarItem1);
            this.dashboardBarController1.BarItems.Add(this.textBoxEditTextBarItem1);
            this.dashboardBarController1.BarItems.Add(this.textBoxInsertFieldBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterLineSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterStackedLineSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterFullStackedLineSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterAreaSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterStackedAreaSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterFullStackedAreaSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterBarSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterStackedBarSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.rangeFilterFullStackedBarSeriesTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotInitialStateBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotAutoExpandColumnBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotAutoExpandRowBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowColumnTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowRowTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowGrandTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowColumnGrandTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.pivotShowRowGrandTotalsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.comboBoxStandardTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.comboBoxCheckedTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.listBoxCheckedTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.listBoxRadioTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.treeViewAutoExpandBarItem1);
            this.dashboardBarController1.BarItems.Add(this.filterElementShowAllValueBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapLoadBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapImportBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapDefaultShapefileBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapWorldCountriesBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapEuropeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapAsiaBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapNorthAmericaBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapSouthAmericaBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapAfricaBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapUSABarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapCanadaBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapLockNavigationBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapFullExtentBarItem1);
            this.dashboardBarController1.BarItems.Add(this.choroplethMapShapeLabelsAttributeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapShapeTitleAttributeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.mapShowLegendBarItem1);
            this.dashboardBarController1.BarItems.Add(this.galleryMapLegendPositionItem1);
            this.dashboardBarController1.BarItems.Add(this.changeWeightedLegendTypeBarItem1);
            this.dashboardBarController1.BarItems.Add(this.weightedLegendNoneBarItem1);
            this.dashboardBarController1.BarItems.Add(this.weightedLegendLinearBarItem1);
            this.dashboardBarController1.BarItems.Add(this.weightedLegendNestedBarItem1);
            this.dashboardBarController1.BarItems.Add(this.galleryWeightedLegendPositionItem1);
            this.dashboardBarController1.BarItems.Add(this.pieMapIsWeightedBarItem1);
            this.dashboardBarController1.BarItems.Add(this.useGlobalColorsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.useLocalColorsBarItem1);
            this.dashboardBarController1.BarItems.Add(this.editActualColorsBarItem1);
            this.dashboardBarController1.Control = this.dashboardDesigner1;
            this.fileRibbonPageGroup1.ItemLinks.Add(this.fileNewBarItem1);
            this.fileRibbonPageGroup1.ItemLinks.Add(this.fileOpenBarItem1);
            this.fileRibbonPageGroup1.ItemLinks.Add(this.fileSaveBarItem1);
            this.fileRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsBarItem1);
            this.fileRibbonPageGroup1.Name = "fileRibbonPageGroup1";
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[7] { this.fileRibbonPageGroup1, this.quickAccessHistoryRibbonPageGroup1, this.historyRibbonPageGroup1, this.insertRibbonPageGroup1, this.itemOperationRibbonPageGroup1, this.groupOperationRibbonPageGroup1, this.dashboardDesignRibbonPageGroup1 });
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            this.fileNewBarItem1.Id = 1;
            this.fileNewBarItem1.Name = "fileNewBarItem1";
            this.fileOpenBarItem1.Id = 2;
            this.fileOpenBarItem1.Name = "fileOpenBarItem1";
            this.fileSaveBarItem1.Id = 3;
            this.fileSaveBarItem1.Name = "fileSaveBarItem1";
            this.fileSaveAsBarItem1.Id = 4;
            this.fileSaveAsBarItem1.Name = "fileSaveAsBarItem1";
            this.quickAccessHistoryRibbonPageGroup1.ItemLinks.Add(this.quickAccessUndoBarItem1);
            this.quickAccessHistoryRibbonPageGroup1.ItemLinks.Add(this.quickAccessRedoBarItem1);
            this.quickAccessHistoryRibbonPageGroup1.Name = "quickAccessHistoryRibbonPageGroup1";
            this.quickAccessHistoryRibbonPageGroup1.Visible = false;
            this.quickAccessUndoBarItem1.Id = 5;
            this.quickAccessUndoBarItem1.Name = "quickAccessUndoBarItem1";
            this.quickAccessRedoBarItem1.Id = 6;
            this.quickAccessRedoBarItem1.Name = "quickAccessRedoBarItem1";
            this.historyRibbonPageGroup1.ItemLinks.Add(this.undoBarItem1);
            this.historyRibbonPageGroup1.ItemLinks.Add(this.redoBarItem1);
            this.historyRibbonPageGroup1.Name = "historyRibbonPageGroup1";
            this.undoBarItem1.Id = 7;
            this.undoBarItem1.Name = "undoBarItem1";
            this.redoBarItem1.Id = 8;
            this.redoBarItem1.Name = "redoBarItem1";
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.newDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editSqlConnectionBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editOlapConnectionBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editObjectDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editExcelDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editEFDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.editExtractOptionsBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.renameDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.deleteDataSourceBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.serverModeBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.upateDataExtractBarItem1);
            this.dataSourceRibbonPageGroup1.ItemLinks.Add(this.addCalculatedFieldBarItem1);
            this.dataSourceRibbonPageGroup1.Name = "dataSourceRibbonPageGroup1";
            this.dataSourceRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.dataSourceRibbonPageGroup1, this.sqlDataSourceQueryRibbonPageGroup1, this.extractSourceRibbonPageGroup1, this.dataSourceFilteringRibbonPageGroup1 });
            this.dataSourceRibbonPage1.Name = "dataSourceRibbonPage1";
            this.newDataSourceBarItem1.Id = 9;
            this.newDataSourceBarItem1.Name = "newDataSourceBarItem1";
            this.editSqlConnectionBarItem1.Id = 10;
            this.editSqlConnectionBarItem1.Name = "editSqlConnectionBarItem1";
            this.editOlapConnectionBarItem1.Id = 11;
            this.editOlapConnectionBarItem1.Name = "editOlapConnectionBarItem1";
            this.editObjectDataSourceBarItem1.Id = 12;
            this.editObjectDataSourceBarItem1.Name = "editObjectDataSourceBarItem1";
            this.editExcelDataSourceBarItem1.Id = 13;
            this.editExcelDataSourceBarItem1.Name = "editExcelDataSourceBarItem1";
            this.editEFDataSourceBarItem1.Id = 14;
            this.editEFDataSourceBarItem1.Name = "editEFDataSourceBarItem1";
            this.editExtractOptionsBarItem1.Id = 15;
            this.editExtractOptionsBarItem1.Name = "editExtractOptionsBarItem1";
            this.renameDataSourceBarItem1.Id = 16;
            this.renameDataSourceBarItem1.Name = "renameDataSourceBarItem1";
            this.deleteDataSourceBarItem1.Id = 17;
            this.deleteDataSourceBarItem1.Name = "deleteDataSourceBarItem1";
            this.serverModeBarItem1.Id = 18;
            this.serverModeBarItem1.Name = "serverModeBarItem1";
            this.upateDataExtractBarItem1.Id = 19;
            this.upateDataExtractBarItem1.Name = "upateDataExtractBarItem1";
            this.addCalculatedFieldBarItem1.Id = 20;
            this.addCalculatedFieldBarItem1.Name = "addCalculatedFieldBarItem1";
            this.sqlDataSourceQueryRibbonPageGroup1.ItemLinks.Add(this.addQueryBarItem1);
            this.sqlDataSourceQueryRibbonPageGroup1.ItemLinks.Add(this.editQueryBarItem1);
            this.sqlDataSourceQueryRibbonPageGroup1.ItemLinks.Add(this.renameQueryBarItem1);
            this.sqlDataSourceQueryRibbonPageGroup1.ItemLinks.Add(this.editQueryFilterBarItem1);
            this.sqlDataSourceQueryRibbonPageGroup1.ItemLinks.Add(this.deleteQueryBarItem1);
            this.sqlDataSourceQueryRibbonPageGroup1.Name = "sqlDataSourceQueryRibbonPageGroup1";
            this.sqlDataSourceQueryRibbonPageGroup1.Visible = false;
            this.addQueryBarItem1.Id = 21;
            this.addQueryBarItem1.Name = "addQueryBarItem1";
            this.editQueryBarItem1.Id = 22;
            this.editQueryBarItem1.Name = "editQueryBarItem1";
            this.renameQueryBarItem1.Id = 23;
            this.renameQueryBarItem1.Name = "renameQueryBarItem1";
            this.editQueryFilterBarItem1.Id = 24;
            this.editQueryFilterBarItem1.Name = "editQueryFilterBarItem1";
            this.deleteQueryBarItem1.Id = 25;
            this.deleteQueryBarItem1.Name = "deleteQueryBarItem1";
            this.extractSourceRibbonPageGroup1.ItemLinks.Add(this.editExtractSourceConnectionBarItem1);
            this.extractSourceRibbonPageGroup1.ItemLinks.Add(this.editExtractSourceBarItem1);
            this.extractSourceRibbonPageGroup1.ItemLinks.Add(this.editExtractSourceQueryBarItem1);
            this.extractSourceRibbonPageGroup1.Name = "extractSourceRibbonPageGroup1";
            this.extractSourceRibbonPageGroup1.Visible = false;
            this.editExtractSourceConnectionBarItem1.Id = 26;
            this.editExtractSourceConnectionBarItem1.Name = "editExtractSourceConnectionBarItem1";
            this.editExtractSourceBarItem1.Id = 27;
            this.editExtractSourceBarItem1.Name = "editExtractSourceBarItem1";
            this.editExtractSourceQueryBarItem1.Id = 28;
            this.editExtractSourceQueryBarItem1.Name = "editExtractSourceQueryBarItem1";
            this.dataSourceFilteringRibbonPageGroup1.ItemLinks.Add(this.editDataSourceFilterBarItem1);
            this.dataSourceFilteringRibbonPageGroup1.ItemLinks.Add(this.clearDataSourceFilterBarItem1);
            this.dataSourceFilteringRibbonPageGroup1.Name = "dataSourceFilteringRibbonPageGroup1";
            this.dataSourceFilteringRibbonPageGroup1.Visible = false;
            this.editDataSourceFilterBarItem1.Id = 29;
            this.editDataSourceFilterBarItem1.Name = "editDataSourceFilterBarItem1";
            this.clearDataSourceFilterBarItem1.Id = 30;
            this.clearDataSourceFilterBarItem1.Name = "clearDataSourceFilterBarItem1";
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertPivotBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertGridBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertChartBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertScatterChartBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertPiesBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertGaugesBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertCardsBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertChoroplethMapBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertGeoPointMapBarSubItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertRangeFilterBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertFilterElementSubItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertImagesBarSubItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertTextBoxBarItem1);
            this.insertRibbonPageGroup1.ItemLinks.Add(this.insertGroupBarItem1);
            this.insertRibbonPageGroup1.Name = "insertRibbonPageGroup1";
            this.insertPivotBarItem1.Id = 31;
            this.insertPivotBarItem1.Name = "insertPivotBarItem1";
            this.insertGridBarItem1.Id = 32;
            this.insertGridBarItem1.Name = "insertGridBarItem1";
            this.insertChartBarItem1.Id = 33;
            this.insertChartBarItem1.Name = "insertChartBarItem1";
            this.insertScatterChartBarItem1.Id = 34;
            this.insertScatterChartBarItem1.Name = "insertScatterChartBarItem1";
            this.insertPiesBarItem1.Id = 35;
            this.insertPiesBarItem1.Name = "insertPiesBarItem1";
            this.insertGaugesBarItem1.Id = 36;
            this.insertGaugesBarItem1.Name = "insertGaugesBarItem1";
            this.insertCardsBarItem1.Id = 37;
            this.insertCardsBarItem1.Name = "insertCardsBarItem1";
            this.insertChoroplethMapBarItem1.Id = 38;
            this.insertChoroplethMapBarItem1.Name = "insertChoroplethMapBarItem1";
            this.insertGeoPointMapBarSubItem1.Id = 39;
            this.insertGeoPointMapBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertGeoPointMapBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertBubbleMapBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertPieMapBarItem1)
            });
            this.insertGeoPointMapBarSubItem1.Name = "insertGeoPointMapBarSubItem1";
            this.insertGeoPointMapBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.insertGeoPointMapBarItem1.Id = 40;
            this.insertGeoPointMapBarItem1.Name = "insertGeoPointMapBarItem1";
            this.insertBubbleMapBarItem1.Id = 41;
            this.insertBubbleMapBarItem1.Name = "insertBubbleMapBarItem1";
            this.insertPieMapBarItem1.Id = 42;
            this.insertPieMapBarItem1.Name = "insertPieMapBarItem1";
            this.insertRangeFilterBarItem1.Id = 43;
            this.insertRangeFilterBarItem1.Name = "insertRangeFilterBarItem1";
            this.insertFilterElementSubItem1.Id = 44;
            this.insertFilterElementSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertComboBoxBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertListBoxBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTreeViewBarItem1)
            });
            this.insertFilterElementSubItem1.Name = "insertFilterElementSubItem1";
            this.insertFilterElementSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.insertComboBoxBarItem1.Id = 45;
            this.insertComboBoxBarItem1.Name = "insertComboBoxBarItem1";
            this.insertListBoxBarItem1.Id = 46;
            this.insertListBoxBarItem1.Name = "insertListBoxBarItem1";
            this.insertTreeViewBarItem1.Id = 47;
            this.insertTreeViewBarItem1.Name = "insertTreeViewBarItem1";
            this.insertImagesBarSubItem1.Id = 48;
            this.insertImagesBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertImageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertBoundImageBarItem1)
            });
            this.insertImagesBarSubItem1.Name = "insertImagesBarSubItem1";
            this.insertImagesBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.insertImageBarItem1.Id = 49;
            this.insertImageBarItem1.Name = "insertImageBarItem1";
            this.insertBoundImageBarItem1.Id = 50;
            this.insertBoundImageBarItem1.Name = "insertBoundImageBarItem1";
            this.insertTextBoxBarItem1.Id = 51;
            this.insertTextBoxBarItem1.Name = "insertTextBoxBarItem1";
            this.insertGroupBarItem1.Id = 52;
            this.insertGroupBarItem1.Name = "insertGroupBarItem1";
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.duplicateItemBarItem1);
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.deleteItemBarItem1);
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.convertDashboardItemTypeBarItem1);
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.removeDataItemsBarItem1);
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.transposeItemBarItem1);
            this.itemOperationRibbonPageGroup1.ItemLinks.Add(this.editRulesBarItem1);
            this.itemOperationRibbonPageGroup1.Name = "itemOperationRibbonPageGroup1";
            this.itemOperationRibbonPageGroup1.Visible = false;
            this.duplicateItemBarItem1.Id = 53;
            this.duplicateItemBarItem1.Name = "duplicateItemBarItem1";
            this.deleteItemBarItem1.Id = 54;
            this.deleteItemBarItem1.Name = "deleteItemBarItem1";
            this.convertDashboardItemTypeBarItem1.Id = 55;
            this.convertDashboardItemTypeBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[12]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToPivotBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToGridBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToChartBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToScatterChartBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToPieBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToGaugeBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToCardBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToChoroplethMapBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToBoundImageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertGeoPointMapBaseBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToRangeFilterBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToFilterElementsBaseBarItem1)
            });
            this.convertDashboardItemTypeBarItem1.Name = "convertDashboardItemTypeBarItem1";
            this.convertToPivotBarItem1.Id = 56;
            this.convertToPivotBarItem1.Name = "convertToPivotBarItem1";
            this.convertToGridBarItem1.Id = 57;
            this.convertToGridBarItem1.Name = "convertToGridBarItem1";
            this.convertToChartBarItem1.Id = 58;
            this.convertToChartBarItem1.Name = "convertToChartBarItem1";
            this.convertToScatterChartBarItem1.Id = 59;
            this.convertToScatterChartBarItem1.Name = "convertToScatterChartBarItem1";
            this.convertToPieBarItem1.Id = 60;
            this.convertToPieBarItem1.Name = "convertToPieBarItem1";
            this.convertToGaugeBarItem1.Id = 61;
            this.convertToGaugeBarItem1.Name = "convertToGaugeBarItem1";
            this.convertToCardBarItem1.Id = 62;
            this.convertToCardBarItem1.Name = "convertToCardBarItem1";
            this.convertToChoroplethMapBarItem1.Id = 63;
            this.convertToChoroplethMapBarItem1.Name = "convertToChoroplethMapBarItem1";
            this.convertToBoundImageBarItem1.Id = 64;
            this.convertToBoundImageBarItem1.Name = "convertToBoundImageBarItem1";
            this.convertGeoPointMapBaseBarItem1.Id = 68;
            this.convertGeoPointMapBaseBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToGeoPointMapBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToBubbleMapBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToPieMapBarItem1)
            });
            this.convertGeoPointMapBaseBarItem1.Name = "convertGeoPointMapBaseBarItem1";
            this.convertToGeoPointMapBarItem1.Id = 65;
            this.convertToGeoPointMapBarItem1.Name = "convertToGeoPointMapBarItem1";
            this.convertToBubbleMapBarItem1.Id = 66;
            this.convertToBubbleMapBarItem1.Name = "convertToBubbleMapBarItem1";
            this.convertToPieMapBarItem1.Id = 67;
            this.convertToPieMapBarItem1.Name = "convertToPieMapBarItem1";
            this.convertToRangeFilterBarItem1.Id = 69;
            this.convertToRangeFilterBarItem1.Name = "convertToRangeFilterBarItem1";
            this.convertToFilterElementsBaseBarItem1.Id = 73;
            this.convertToFilterElementsBaseBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToComboBoxBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToListBoxBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.convertToTreeViewBarItem1)
            });
            this.convertToFilterElementsBaseBarItem1.Name = "convertToFilterElementsBaseBarItem1";
            this.convertToComboBoxBarItem1.Id = 70;
            this.convertToComboBoxBarItem1.Name = "convertToComboBoxBarItem1";
            this.convertToListBoxBarItem1.Id = 71;
            this.convertToListBoxBarItem1.Name = "convertToListBoxBarItem1";
            this.convertToTreeViewBarItem1.Id = 72;
            this.convertToTreeViewBarItem1.Name = "convertToTreeViewBarItem1";
            this.removeDataItemsBarItem1.Id = 74;
            this.removeDataItemsBarItem1.Name = "removeDataItemsBarItem1";
            this.transposeItemBarItem1.Id = 75;
            this.transposeItemBarItem1.Name = "transposeItemBarItem1";
            this.editRulesBarItem1.Id = 76;
            this.editRulesBarItem1.Name = "editRulesBarItem1";
            this.groupOperationRibbonPageGroup1.ItemLinks.Add(this.deleteGroupBarItem1);
            this.groupOperationRibbonPageGroup1.Name = "groupOperationRibbonPageGroup1";
            this.groupOperationRibbonPageGroup1.Visible = false;
            this.deleteGroupBarItem1.Id = 77;
            this.deleteGroupBarItem1.Name = "deleteGroupBarItem1";
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.dashboardTitleBarItem1);
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.setCurrencyCultureBarItem1);
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.dashboardColorSchemeBarItem1);
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.dashboardParametersBarItem1);
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.dashboardAutomaticUpdatesBarItem1);
            this.dashboardDesignRibbonPageGroup1.ItemLinks.Add(this.updateDataBarItem1);
            this.dashboardDesignRibbonPageGroup1.Name = "dashboardDesignRibbonPageGroup1";
            this.dashboardTitleBarItem1.Id = 78;
            this.dashboardTitleBarItem1.Name = "dashboardTitleBarItem1";
            this.setCurrencyCultureBarItem1.Id = 79;
            this.setCurrencyCultureBarItem1.Name = "setCurrencyCultureBarItem1";
            this.dashboardColorSchemeBarItem1.Id = 80;
            this.dashboardColorSchemeBarItem1.Name = "dashboardColorSchemeBarItem1";
            this.dashboardParametersBarItem1.Id = 81;
            this.dashboardParametersBarItem1.Name = "dashboardParametersBarItem1";
            this.dashboardAutomaticUpdatesBarItem1.Id = 82;
            this.dashboardAutomaticUpdatesBarItem1.Name = "dashboardAutomaticUpdatesBarItem1";
            this.updateDataBarItem1.Id = 83;
            this.updateDataBarItem1.Name = "updateDataBarItem1";
            this.skinsRibbonPageGroup1.ItemLinks.Add(this.dashboardSkinsBarItem1);
            this.skinsRibbonPageGroup1.Name = "skinsRibbonPageGroup1";
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.skinsRibbonPageGroup1 });
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            this.dashboardSkinsBarItem1.Gallery.AllowHoverImages = true;
            this.dashboardSkinsBarItem1.Gallery.ColumnCount = 4;
            this.dashboardSkinsBarItem1.Gallery.FixedHoverImageSize = false;
            galleryItemGroup.Caption = "Temas Estándar";
            galleryItem.Caption = "DevExpress Style";
            galleryItem.Checked = true;
            galleryItem.Hint = "DevExpress Style";
            //galleryItem.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem1.HoverImage");
            //galleryItem.Image = (System.Drawing.Image)resources.GetObject("galleryItem1.Image");
            galleryItem.Tag = "DevExpress Style";
            galleryItem2.Caption = "DevExpress Dark Style";
            galleryItem2.Hint = "DevExpress Dark Style";
            //galleryItem2.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem2.HoverImage");
            //galleryItem2.Image = (System.Drawing.Image)resources.GetObject("galleryItem2.Image");
            galleryItem2.Tag = "DevExpress Dark Style";
            galleryItem3.Caption = "Office 2016 Colorful";
            galleryItem3.Hint = "Office 2016 Colorful";
            //galleryItem3.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem3.HoverImage");
            //galleryItem3.Image = (System.Drawing.Image)resources.GetObject("galleryItem3.Image");
            galleryItem3.Tag = "Office 2016 Colorful";
            galleryItem4.Caption = "Office 2016 Dark";
            galleryItem4.Hint = "Office 2016 Dark";
            //galleryItem4.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem4.HoverImage");
            //galleryItem4.Image = (System.Drawing.Image)resources.GetObject("galleryItem4.Image");
            galleryItem4.Tag = "Office 2016 Dark";
            galleryItem5.Caption = "Office 2013";
            galleryItem5.Hint = "Office 2013";
            //galleryItem5.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem5.HoverImage");
            //galleryItem5.Image = (System.Drawing.Image)resources.GetObject("galleryItem5.Image");
            galleryItem5.Tag = "Office 2013";
            galleryItem6.Caption = "Office 2013 Dark Gray";
            galleryItem6.Hint = "Office 2013 Dark Gray";
            //galleryItem6.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem6.HoverImage");
            //galleryItem6.Image = (System.Drawing.Image)resources.GetObject("galleryItem6.Image");
            galleryItem6.Tag = "Office 2013 Dark Gray";
            galleryItem7.Caption = "Office 2013 Light Gray";
            galleryItem7.Hint = "Office 2013 Light Gray";
            //galleryItem7.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem7.HoverImage");
            //galleryItem7.Image = (System.Drawing.Image)resources.GetObject("galleryItem7.Image");
            galleryItem7.Tag = "Office 2013 Light Gray";
            galleryItem8.Caption = "Office 2010 Blue";
            galleryItem8.Hint = "Office 2010 Blue";
            //galleryItem8.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem8.HoverImage");
            //galleryItem8.Image = (System.Drawing.Image)resources.GetObject("galleryItem8.Image");
            galleryItem8.Tag = "Office 2010 Blue";
            galleryItem9.Caption = "Office 2010 Black";
            galleryItem9.Hint = "Office 2010 Black";
            //galleryItem9.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem9.HoverImage");
            //galleryItem9.Image = (System.Drawing.Image)resources.GetObject("galleryItem9.Image");
            galleryItem9.Tag = "Office 2010 Black";
            galleryItem10.Caption = "Office 2010 Silver";
            galleryItem10.Hint = "Office 2010 Silver";
            //galleryItem10.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem10.HoverImage");
           // galleryItem10.Image = (System.Drawing.Image)resources.GetObject("galleryItem10.Image");
            galleryItem10.Tag = "Office 2010 Silver";
            galleryItem11.Caption = "Visual Studio 2013 Blue";
            galleryItem11.Hint = "Visual Studio 2013 Blue";
            //galleryItem11.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem11.HoverImage");
            //galleryItem11.Image = (System.Drawing.Image)resources.GetObject("galleryItem11.Image");
            galleryItem11.Tag = "Visual Studio 2013 Blue";
            galleryItem12.Caption = "Visual Studio 2013 Dark";
            galleryItem12.Hint = "Visual Studio 2013 Dark";
            //galleryItem12.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem12.HoverImage");
            //galleryItem12.Image = (System.Drawing.Image)resources.GetObject("galleryItem12.Image");
            galleryItem12.Tag = "Visual Studio 2013 Dark";
            galleryItem13.Caption = "Visual Studio 2013 Light";
            galleryItem13.Hint = "Visual Studio 2013 Light";
            //galleryItem13.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem13.HoverImage");
            //galleryItem13.Image = (System.Drawing.Image)resources.GetObject("galleryItem13.Image");
            galleryItem13.Tag = "Visual Studio 2013 Light";
            galleryItem14.Caption = "Seven Classic";
            galleryItem14.Hint = "Seven Classic";
            //galleryItem14.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem14.HoverImage");
            //galleryItem14.Image = (System.Drawing.Image)resources.GetObject("galleryItem14.Image");
            galleryItem14.Tag = "Seven Classic";
            galleryItem15.Caption = "VS2010";
            galleryItem15.Hint = "VS2010";
            //galleryItem15.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem15.HoverImage");
            //galleryItem15.Image = (System.Drawing.Image)resources.GetObject("galleryItem15.Image");
            galleryItem15.Tag = "VS2010";
            galleryItemGroup.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[15]
            {
            galleryItem, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10,
            galleryItem11, galleryItem12, galleryItem13, galleryItem14, galleryItem15
            });
            galleryItemGroup2.Caption = "Temas Adicionales";
            galleryItem16.Caption = "Black";
            galleryItem16.Hint = "Black";
            //galleryItem16.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem16.HoverImage");
            //galleryItem16.Image = (System.Drawing.Image)resources.GetObject("galleryItem16.Image");
            galleryItem16.Tag = "Black";
            galleryItem17.Caption = "Blue";
            galleryItem17.Hint = "Blue";
            //galleryItem17.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem17.HoverImage");
            //galleryItem17.Image = (System.Drawing.Image)resources.GetObject("galleryItem17.Image");
            galleryItem17.Tag = "Blue";
            galleryItem18.Caption = "Caramel";
            galleryItem18.Hint = "Caramel";
            //galleryItem18.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem18.HoverImage");
            //galleryItem18.Image = (System.Drawing.Image)resources.GetObject("galleryItem18.Image");
            galleryItem18.Tag = "Caramel";
            galleryItem19.Caption = "Coffee";
            galleryItem19.Hint = "Coffee";
            //galleryItem19.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem19.HoverImage");
            //galleryItem19.Image = (System.Drawing.Image)resources.GetObject("galleryItem19.Image");
            galleryItem19.Tag = "Coffee";
            galleryItem20.Caption = "Dark Side";
            galleryItem20.Hint = "Dark Side";
            //galleryItem20.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem20.HoverImage");
            //galleryItem20.Image = (System.Drawing.Image)resources.GetObject("galleryItem20.Image");
            galleryItem20.Tag = "Dark Side";
            galleryItem21.Caption = "Darkroom";
            galleryItem21.Hint = "Darkroom";
            //galleryItem21.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem21.HoverImage");
            //galleryItem21.Image = (System.Drawing.Image)resources.GetObject("galleryItem21.Image");
            galleryItem21.Tag = "Darkroom";
            galleryItem22.Caption = "Foggy";
            galleryItem22.Hint = "Foggy";
            //galleryItem22.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem22.HoverImage");
            //galleryItem22.Image = (System.Drawing.Image)resources.GetObject("galleryItem22.Image");
            galleryItem22.Tag = "Foggy";
            galleryItem23.Caption = "Glass Oceans";
            galleryItem23.Hint = "Glass Oceans";
            //galleryItem23.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem23.HoverImage");
            //galleryItem23.Image = (System.Drawing.Image)resources.GetObject("galleryItem23.Image");
            galleryItem23.Tag = "Glass Oceans";
            galleryItem24.Caption = "High Contrast";
            galleryItem24.Hint = "High Contrast";
            //galleryItem24.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem24.HoverImage");
            //galleryItem24.Image = (System.Drawing.Image)resources.GetObject("galleryItem24.Image");
            galleryItem24.Tag = "High Contrast";
            galleryItem25.Caption = "iMaginary";
            galleryItem25.Hint = "iMaginary";
            //galleryItem25.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem25.HoverImage");
            //galleryItem25.Image = (System.Drawing.Image)resources.GetObject("galleryItem25.Image");
            galleryItem25.Tag = "iMaginary";
            galleryItem26.Caption = "Lilian";
            galleryItem26.Hint = "Lilian";
            //galleryItem26.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem26.HoverImage");
            //galleryItem26.Image = (System.Drawing.Image)resources.GetObject("galleryItem26.Image");
            galleryItem26.Tag = "Lilian";
            galleryItem27.Caption = "Liquid Sky";
            galleryItem27.Hint = "Liquid Sky";
            //galleryItem27.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem27.HoverImage");
            //galleryItem27.Image = (System.Drawing.Image)resources.GetObject("galleryItem27.Image");
            galleryItem27.Tag = "Liquid Sky";
            galleryItem28.Caption = "London Liquid Sky";
            galleryItem28.Hint = "London Liquid Sky";
            //galleryItem28.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem28.HoverImage");
            //galleryItem28.Image = (System.Drawing.Image)resources.GetObject("galleryItem28.Image");
            galleryItem28.Tag = "London Liquid Sky";
            galleryItem29.Caption = "Metropolis";
            galleryItem29.Hint = "Metropolis";
            //galleryItem29.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem29.HoverImage");
            //galleryItem29.Image = (System.Drawing.Image)resources.GetObject("galleryItem29.Image");
            galleryItem29.Tag = "Metropolis";
            galleryItem30.Caption = "Metropolis Dark";
            galleryItem30.Hint = "Metropolis Dark";
            //galleryItem30.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem30.HoverImage");
            //galleryItem30.Image = (System.Drawing.Image)resources.GetObject("galleryItem30.Image");
            galleryItem30.Tag = "Metropolis Dark";
            galleryItem31.Caption = "Money Twins";
            galleryItem31.Hint = "Money Twins";
            //galleryItem31.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem31.HoverImage");
            //galleryItem31.Image = (System.Drawing.Image)resources.GetObject("galleryItem31.Image");
            galleryItem31.Tag = "Money Twins";
            galleryItem32.Caption = "Office 2007 Black";
            galleryItem32.Hint = "Office 2007 Black";
            //galleryItem32.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem32.HoverImage");
            //galleryItem32.Image = (System.Drawing.Image)resources.GetObject("galleryItem32.Image");
            galleryItem32.Tag = "Office 2007 Black";
            galleryItem33.Caption = "Office 2007 Blue";
            galleryItem33.Hint = "Office 2007 Blue";
            //galleryItem33.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem33.HoverImage");
            //galleryItem33.Image = (System.Drawing.Image)resources.GetObject("galleryItem33.Image");
            galleryItem33.Tag = "Office 2007 Blue";
            galleryItem34.Caption = "Office 2007 Green";
            galleryItem34.Hint = "Office 2007 Green";
            //galleryItem34.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem34.HoverImage");
            //galleryItem34.Image = (System.Drawing.Image)resources.GetObject("galleryItem34.Image");
            galleryItem34.Tag = "Office 2007 Green";
            galleryItem35.Caption = "Office 2007 Pink";
            galleryItem35.Hint = "Office 2007 Pink";
            //galleryItem35.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem35.HoverImage");
            //galleryItem35.Image = (System.Drawing.Image)resources.GetObject("galleryItem35.Image");
            galleryItem35.Tag = "Office 2007 Pink";
            galleryItem36.Caption = "Office 2007 Silver";
            galleryItem36.Hint = "Office 2007 Silver";
            //galleryItem36.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem36.HoverImage");
            //galleryItem36.Image = (System.Drawing.Image)resources.GetObject("galleryItem36.Image");
            galleryItem36.Tag = "Office 2007 Silver";
            galleryItem37.Caption = "Seven";
            galleryItem37.Hint = "Seven";
            //galleryItem37.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem37.HoverImage");
            //galleryItem37.Image = (System.Drawing.Image)resources.GetObject("galleryItem37.Image");
            galleryItem37.Tag = "Seven";
            galleryItem38.Caption = "Sharp";
            galleryItem38.Hint = "Sharp";
            //galleryItem38.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem38.HoverImage");
            //galleryItem38.Image = (System.Drawing.Image)resources.GetObject("galleryItem38.Image");
            galleryItem38.Tag = "Sharp";
            galleryItem39.Caption = "Sharp Plus";
            galleryItem39.Hint = "Sharp Plus";
            //galleryItem39.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem39.HoverImage");
            //galleryItem39.Image = (System.Drawing.Image)resources.GetObject("galleryItem39.Image");
            galleryItem39.Tag = "Sharp Plus";
            galleryItem40.Caption = "Stardust";
            galleryItem40.Hint = "Stardust";
            //galleryItem40.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem40.HoverImage");
            //galleryItem40.Image = (System.Drawing.Image)resources.GetObject("galleryItem40.Image");
            galleryItem40.Tag = "Stardust";
            galleryItem41.Caption = "The Asphalt World";
            galleryItem41.Hint = "The Asphalt World";
            //galleryItem41.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem41.HoverImage");
            //galleryItem41.Image = (System.Drawing.Image)resources.GetObject("galleryItem41.Image");
            galleryItem41.Tag = "The Asphalt World";
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[26]
            {
            galleryItem16, galleryItem17, galleryItem18, galleryItem19, galleryItem20, galleryItem21, galleryItem22, galleryItem23, galleryItem24, galleryItem25,
            galleryItem26, galleryItem27, galleryItem28, galleryItem29, galleryItem30, galleryItem31, galleryItem32, galleryItem33, galleryItem34, galleryItem35,
            galleryItem36, galleryItem37, galleryItem38, galleryItem39, galleryItem40, galleryItem41
            });
            galleryItemGroup3.Caption = "Temas Estándar";
            galleryItem42.Caption = "Pumpkin";
            galleryItem42.Hint = "Pumpkin";
            //galleryItem42.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem42.HoverImage");
            //galleryItem42.Image = (System.Drawing.Image)resources.GetObject("galleryItem42.Image");
            galleryItem42.Tag = "Pumpkin";
            galleryItem43.Caption = "Springtime";
            galleryItem43.Hint = "Springtime";
            //galleryItem43.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem43.HoverImage");
            //galleryItem43.Image = (System.Drawing.Image)resources.GetObject("galleryItem43.Image");
            galleryItem43.Tag = "Springtime";
            galleryItem44.Caption = "Summer";
            galleryItem44.Hint = "Summer";
            //galleryItem44.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem44.HoverImage");
            //galleryItem44.Image = (System.Drawing.Image)resources.GetObject("galleryItem44.Image");
            galleryItem44.Tag = "Summer 2008";
            galleryItem45.Caption = "Valentine";
            galleryItem45.Hint = "Valentine";
            //galleryItem45.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem45.HoverImage");
            //galleryItem45.Image = (System.Drawing.Image)resources.GetObject("galleryItem45.Image");
            galleryItem45.Tag = "Valentine";
            galleryItem46.Caption = "Xmas (Blue)";
            galleryItem46.Hint = "Xmas (Blue)";
            //galleryItem46.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem46.HoverImage");
            //galleryItem46.Image = (System.Drawing.Image)resources.GetObject("galleryItem46.Image");
            galleryItem46.Tag = "Xmas 2008 Blue";
            galleryItem47.Caption = "McSkin";
            galleryItem47.Hint = "McSkin";
           // galleryItem47.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem47.HoverImage");
           // galleryItem47.Image = (System.Drawing.Image)resources.GetObject("galleryItem47.Image");
            galleryItem47.Tag = "McSkin";
            galleryItem48.Caption = "Blueprint";
            galleryItem48.Hint = "Blueprint";
           // galleryItem48.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem48.HoverImage");
            //galleryItem48.Image = (System.Drawing.Image)resources.GetObject("galleryItem48.Image");
            galleryItem48.Tag = "Blueprint";
            galleryItem49.Caption = "Whiteprint";
            galleryItem49.Hint = "Whiteprint";
            //galleryItem49.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem49.HoverImage");
           // galleryItem49.Image = (System.Drawing.Image)resources.GetObject("galleryItem49.Image");
            galleryItem49.Tag = "Whiteprint";
            galleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[8] { galleryItem42, galleryItem43, galleryItem44, galleryItem45, galleryItem46, galleryItem47, galleryItem48, galleryItem49 });
            galleryItemGroup4.Caption = "Temas Personalizados";
            galleryItem50.Caption = "DevExpress Design";
            galleryItem50.Hint = "DevExpress Design";
            //galleryItem50.HoverImage = (System.Drawing.Image)resources.GetObject("galleryItem50.HoverImage");
            //galleryItem50.Image = (System.Drawing.Image)resources.GetObject("galleryItem50.Image");
            galleryItem50.Tag = "DevExpress Design";
            galleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[1] { galleryItem50 });
            this.dashboardSkinsBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[4] { galleryItemGroup, galleryItemGroup2, galleryItemGroup3, galleryItemGroup4 });
            this.dashboardSkinsBarItem1.Gallery.ImageSize = new System.Drawing.Size(32, 16);
            this.dashboardSkinsBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.dashboardSkinsBarItem1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze;
            this.dashboardSkinsBarItem1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            //this.dashboardSkinsBarItem1.Glyph = (System.Drawing.Image)resources.GetObject("dashboardSkinsBarItem1.Glyph");
            this.dashboardSkinsBarItem1.Id = 84;
            this.dashboardSkinsBarItem1.Name = "dashboardSkinsBarItem1";
            this.filteringRibbonPageGroup1.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup1.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup1.Name = "filteringRibbonPageGroup1";
            this.dataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup1, this.interactivitySettingsRibbonPageGroup1, this.pivotLayoutRibbonPageGroup1 });
            this.dataRibbonPage1.Name = "dataRibbonPage1";
            this.dataRibbonPage1.Visible = false;
            this.pivotToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.pivotToolsRibbonPageCategory1.Name = "pivotToolsRibbonPageCategory1";
            this.pivotToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage1, this.dashboardItemDesignRibbonPage11 });
            this.pivotToolsRibbonPageCategory1.Visible = false;
            this.editFilterBarItem1.Id = 85;
            this.editFilterBarItem1.Name = "editFilterBarItem1";
            this.clearFilterBarItem1.Id = 86;
            this.clearFilterBarItem1.Name = "clearFilterBarItem1";
            this.filteringRibbonPageGroup2.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup2.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup2.Name = "filteringRibbonPageGroup2";
            this.dataRibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup2, this.masterFilterRibbonPageGroup1, this.interactivitySettingsRibbonPageGroup2 });
            this.dataRibbonPage2.Name = "dataRibbonPage2";
            this.dataRibbonPage2.Visible = false;
            this.gridToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.gridToolsRibbonPageCategory1.Name = "gridToolsRibbonPageCategory1";
            this.gridToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage2, this.dashboardItemDesignRibbonPage1 });
            this.gridToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup3.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup3.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup3.Name = "filteringRibbonPageGroup3";
            this.dataRibbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.filteringRibbonPageGroup3, this.masterFilterRibbonPageGroup2, this.interactivitySettingsRibbonPageGroup3, this.targetDimensionsRibbonPageGroup1 });
            this.dataRibbonPage3.Name = "dataRibbonPage3";
            this.dataRibbonPage3.Visible = false;
            this.chartToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1";
            this.chartToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage3, this.dashboardItemDesignRibbonPage2 });
            this.chartToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup4.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup4.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup4.Name = "filteringRibbonPageGroup4";
            this.dataRibbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup4, this.masterFilterRibbonPageGroup3, this.interactivitySettingsRibbonPageGroup4 });
            this.dataRibbonPage4.Name = "dataRibbonPage4";
            this.dataRibbonPage4.Visible = false;
            this.scatterChartToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.scatterChartToolsRibbonPageCategory1.Name = "scatterChartToolsRibbonPageCategory1";
            this.scatterChartToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage4, this.dashboardItemDesignRibbonPage3 });
            this.scatterChartToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup5.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup5.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup5.Name = "filteringRibbonPageGroup5";
            this.dataRibbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.filteringRibbonPageGroup5, this.masterFilterRibbonPageGroup4, this.interactivitySettingsRibbonPageGroup5, this.targetDimensionsRibbonPageGroup2 });
            this.dataRibbonPage5.Name = "dataRibbonPage5";
            this.dataRibbonPage5.Visible = false;
            this.piesToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.piesToolsRibbonPageCategory1.Name = "piesToolsRibbonPageCategory1";
            this.piesToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage5, this.dashboardItemDesignRibbonPage4 });
            this.piesToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup6.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup6.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup6.Name = "filteringRibbonPageGroup6";
            this.dataRibbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup6, this.masterFilterRibbonPageGroup5, this.interactivitySettingsRibbonPageGroup6 });
            this.dataRibbonPage6.Name = "dataRibbonPage6";
            this.dataRibbonPage6.Visible = false;
            this.gaugesToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.gaugesToolsRibbonPageCategory1.Name = "gaugesToolsRibbonPageCategory1";
            this.gaugesToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage6, this.dashboardItemDesignRibbonPage5 });
            this.gaugesToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup7.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup7.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup7.Name = "filteringRibbonPageGroup7";
            this.dataRibbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup7, this.masterFilterRibbonPageGroup6, this.interactivitySettingsRibbonPageGroup7 });
            this.dataRibbonPage7.Name = "dataRibbonPage7";
            this.dataRibbonPage7.Visible = false;
            this.cardsToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.cardsToolsRibbonPageCategory1.Name = "cardsToolsRibbonPageCategory1";
            this.cardsToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage7, this.dashboardItemDesignRibbonPage6 });
            this.cardsToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup8.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup8.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup8.Name = "filteringRibbonPageGroup8";
            this.dataRibbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.filteringRibbonPageGroup8, this.interactivitySettingsRibbonPageGroup8 });
            this.dataRibbonPage8.Name = "dataRibbonPage8";
            this.dataRibbonPage8.Visible = false;
            this.rangeFilterToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.rangeFilterToolsRibbonPageCategory1.Name = "rangeFilterToolsRibbonPageCategory1";
            this.rangeFilterToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage8, this.dashboardItemDesignRibbonPage10 });
            this.rangeFilterToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup9.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup9.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup9.Name = "filteringRibbonPageGroup9";
            this.dataRibbonPage9.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.filteringRibbonPageGroup9, this.masterFilterRibbonPageGroup7, this.interactivitySettingsRibbonPageGroup9 });
            this.dataRibbonPage9.Name = "dataRibbonPage9";
            this.dataRibbonPage9.Visible = false;
            this.choroplethMapToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.choroplethMapToolsRibbonPageCategory1.Name = "choroplethMapToolsRibbonPageCategory1";
            this.choroplethMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage9, this.dashboardItemDesignRibbonPage12 });
            this.choroplethMapToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup10.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup10.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup10.Name = "filteringRibbonPageGroup10";
            this.dataRibbonPage10.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.filteringRibbonPageGroup10, this.masterFilterRibbonPageGroup8, this.interactivitySettingsRibbonPageGroup10, this.geoPointMapClusterizationRibbonPageGroup1 });
            this.dataRibbonPage10.Name = "dataRibbonPage10";
            this.dataRibbonPage10.Visible = false;
            this.geoPointMapToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.geoPointMapToolsRibbonPageCategory1.Name = "geoPointMapToolsRibbonPageCategory1";
            this.geoPointMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage10, this.dashboardItemDesignRibbonPage13 });
            this.geoPointMapToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup11.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup11.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup11.Name = "filteringRibbonPageGroup11";
            this.dataRibbonPage11.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.filteringRibbonPageGroup11, this.masterFilterRibbonPageGroup9, this.interactivitySettingsRibbonPageGroup11, this.geoPointMapClusterizationRibbonPageGroup2 });
            this.dataRibbonPage11.Name = "dataRibbonPage11";
            this.dataRibbonPage11.Visible = false;
            this.bubbleMapToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.bubbleMapToolsRibbonPageCategory1.Name = "bubbleMapToolsRibbonPageCategory1";
            this.bubbleMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage11, this.dashboardItemDesignRibbonPage14 });
            this.bubbleMapToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup12.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup12.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup12.Name = "filteringRibbonPageGroup12";
            this.dataRibbonPage12.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.filteringRibbonPageGroup12, this.masterFilterRibbonPageGroup10, this.interactivitySettingsRibbonPageGroup12, this.geoPointMapClusterizationRibbonPageGroup3 });
            this.dataRibbonPage12.Name = "dataRibbonPage12";
            this.dataRibbonPage12.Visible = false;
            this.pieMapToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.pieMapToolsRibbonPageCategory1.Name = "pieMapToolsRibbonPageCategory1";
            this.pieMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage12, this.dashboardItemDesignRibbonPage15 });
            this.pieMapToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup13.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup13.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup13.Name = "filteringRibbonPageGroup13";
            this.dataRibbonPage13.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.filteringRibbonPageGroup13, this.interactivitySettingsRibbonPageGroup13 });
            this.dataRibbonPage13.Name = "dataRibbonPage13";
            this.dataRibbonPage13.Visible = false;
            this.filterElementToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.filterElementToolsRibbonPageCategory1.Name = "filterElementToolsRibbonPageCategory1";
            this.filterElementToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage13, this.dashboardItemDesignRibbonPage17 });
            this.filterElementToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup14.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup14.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup14.Name = "filteringRibbonPageGroup14";
            this.dataRibbonPage14.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.filteringRibbonPageGroup14, this.interactivitySettingsRibbonPageGroup14 });
            this.dataRibbonPage14.Name = "dataRibbonPage14";
            this.dataRibbonPage14.Visible = false;
            this.boundImageToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.boundImageToolsRibbonPageCategory1.Name = "boundImageToolsRibbonPageCategory1";
            this.boundImageToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage14, this.dashboardItemDesignRibbonPage8 });
            this.boundImageToolsRibbonPageCategory1.Visible = false;
            this.filteringRibbonPageGroup15.ItemLinks.Add(this.editFilterBarItem1);
            this.filteringRibbonPageGroup15.ItemLinks.Add(this.clearFilterBarItem1);
            this.filteringRibbonPageGroup15.Name = "filteringRibbonPageGroup15";
            this.dataRibbonPage15.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.filteringRibbonPageGroup15, this.interactivitySettingsRibbonPageGroup15 });
            this.dataRibbonPage15.Name = "dataRibbonPage15";
            this.dataRibbonPage15.Visible = false;
            this.textBoxToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.textBoxToolsRibbonPageCategory1.Name = "textBoxToolsRibbonPageCategory1";
            this.textBoxToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage15, this.dashboardItemDesignRibbonPage9 });
            this.textBoxToolsRibbonPageCategory1.Visible = false;
            this.masterFilterRibbonPageGroup1.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup1.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup1.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup1.Name = "masterFilterRibbonPageGroup1";
            this.masterFilterBarItem1.Id = 87;
            this.masterFilterBarItem1.Name = "masterFilterBarItem1";
            this.multipleValuesMasterFilterBarItem1.Id = 88;
            this.multipleValuesMasterFilterBarItem1.Name = "multipleValuesMasterFilterBarItem1";
            this.drillDownBarItem1.Id = 89;
            this.drillDownBarItem1.Name = "drillDownBarItem1";
            this.masterFilterRibbonPageGroup2.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup2.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup2.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup2.Name = "masterFilterRibbonPageGroup2";
            this.masterFilterRibbonPageGroup3.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup3.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup3.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup3.Name = "masterFilterRibbonPageGroup3";
            this.masterFilterRibbonPageGroup4.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup4.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup4.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup4.Name = "masterFilterRibbonPageGroup4";
            this.masterFilterRibbonPageGroup5.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup5.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup5.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup5.Name = "masterFilterRibbonPageGroup5";
            this.masterFilterRibbonPageGroup6.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup6.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup6.ItemLinks.Add(this.drillDownBarItem1);
            this.masterFilterRibbonPageGroup6.Name = "masterFilterRibbonPageGroup6";
            this.masterFilterRibbonPageGroup7.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup7.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup7.Name = "masterFilterRibbonPageGroup7";
            this.masterFilterRibbonPageGroup8.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup8.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup8.Name = "masterFilterRibbonPageGroup8";
            this.masterFilterRibbonPageGroup9.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup9.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup9.Name = "masterFilterRibbonPageGroup9";
            this.masterFilterRibbonPageGroup10.ItemLinks.Add(this.masterFilterBarItem1);
            this.masterFilterRibbonPageGroup10.ItemLinks.Add(this.multipleValuesMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup10.Name = "masterFilterRibbonPageGroup10";
            this.masterFilterRibbonPageGroup11.ItemLinks.Add(this.groupMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup11.ItemLinks.Add(this.groupIgnoreMasterFilterBarItem1);
            this.masterFilterRibbonPageGroup11.Name = "masterFilterRibbonPageGroup11";
            this.dataRibbonPage16.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.masterFilterRibbonPageGroup11 });
            this.dataRibbonPage16.Name = "dataRibbonPage16";
            this.dataRibbonPage16.Visible = false;
            this.groupToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.groupToolsRibbonPageCategory1.Name = "groupToolsRibbonPageCategory1";
            this.groupToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[2] { this.dataRibbonPage16, this.dashboardItemDesignRibbonPage16 });
            this.groupToolsRibbonPageCategory1.Visible = false;
            this.groupMasterFilterBarItem1.Id = 90;
            this.groupMasterFilterBarItem1.Name = "groupMasterFilterBarItem1";
            this.groupIgnoreMasterFilterBarItem1.Id = 91;
            this.groupIgnoreMasterFilterBarItem1.Name = "groupIgnoreMasterFilterBarItem1";
            this.interactivitySettingsRibbonPageGroup1.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup1.Name = "interactivitySettingsRibbonPageGroup1";
            this.ignoreMasterFiltersBarItem1.Id = 92;
            this.ignoreMasterFiltersBarItem1.Name = "ignoreMasterFiltersBarItem1";
            this.interactivitySettingsRibbonPageGroup2.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup2.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup2.Name = "interactivitySettingsRibbonPageGroup2";
            this.crossDataSourceFilteringBarItem1.Id = 93;
            this.crossDataSourceFilteringBarItem1.Name = "crossDataSourceFilteringBarItem1";
            this.interactivitySettingsRibbonPageGroup3.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup3.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup3.Name = "interactivitySettingsRibbonPageGroup3";
            this.interactivitySettingsRibbonPageGroup4.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup4.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup4.Name = "interactivitySettingsRibbonPageGroup4";
            this.interactivitySettingsRibbonPageGroup5.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup5.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup5.Name = "interactivitySettingsRibbonPageGroup5";
            this.interactivitySettingsRibbonPageGroup6.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup6.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup6.Name = "interactivitySettingsRibbonPageGroup6";
            this.interactivitySettingsRibbonPageGroup7.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup7.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup7.Name = "interactivitySettingsRibbonPageGroup7";
            this.interactivitySettingsRibbonPageGroup8.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup8.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup8.Name = "interactivitySettingsRibbonPageGroup8";
            this.interactivitySettingsRibbonPageGroup9.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup9.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup9.Name = "interactivitySettingsRibbonPageGroup9";
            this.interactivitySettingsRibbonPageGroup10.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup10.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup10.Name = "interactivitySettingsRibbonPageGroup10";
            this.interactivitySettingsRibbonPageGroup11.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup11.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup11.Name = "interactivitySettingsRibbonPageGroup11";
            this.interactivitySettingsRibbonPageGroup12.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup12.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup12.Name = "interactivitySettingsRibbonPageGroup12";
            this.interactivitySettingsRibbonPageGroup13.ItemLinks.Add(this.crossDataSourceFilteringBarItem1);
            this.interactivitySettingsRibbonPageGroup13.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup13.Name = "interactivitySettingsRibbonPageGroup13";
            this.interactivitySettingsRibbonPageGroup14.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup14.Name = "interactivitySettingsRibbonPageGroup14";
            this.interactivitySettingsRibbonPageGroup15.ItemLinks.Add(this.ignoreMasterFiltersBarItem1);
            this.interactivitySettingsRibbonPageGroup15.Name = "interactivitySettingsRibbonPageGroup15";
            this.targetDimensionsRibbonPageGroup1.ItemLinks.Add(this.chartTargetDimensionsArgumentsBarItem1);
            this.targetDimensionsRibbonPageGroup1.ItemLinks.Add(this.chartTargetDimensionsSeriesBarItem1);
            this.targetDimensionsRibbonPageGroup1.ItemLinks.Add(this.chartTargetDimensionsPointsBarItem1);
            this.targetDimensionsRibbonPageGroup1.Name = "targetDimensionsRibbonPageGroup1";
            this.chartTargetDimensionsArgumentsBarItem1.Id = 94;
            this.chartTargetDimensionsArgumentsBarItem1.Name = "chartTargetDimensionsArgumentsBarItem1";
            this.chartTargetDimensionsSeriesBarItem1.Id = 95;
            this.chartTargetDimensionsSeriesBarItem1.Name = "chartTargetDimensionsSeriesBarItem1";
            this.chartTargetDimensionsPointsBarItem1.Id = 96;
            this.chartTargetDimensionsPointsBarItem1.Name = "chartTargetDimensionsPointsBarItem1";
            this.targetDimensionsRibbonPageGroup2.ItemLinks.Add(this.pieTargetDimensionsArgumentsBarItem1);
            this.targetDimensionsRibbonPageGroup2.ItemLinks.Add(this.pieTargetDimensionsSeriesBarItem1);
            this.targetDimensionsRibbonPageGroup2.ItemLinks.Add(this.pieTargetDimensionsPointsBarItem1);
            this.targetDimensionsRibbonPageGroup2.Name = "targetDimensionsRibbonPageGroup2";
            this.pieTargetDimensionsArgumentsBarItem1.Id = 97;
            this.pieTargetDimensionsArgumentsBarItem1.Name = "pieTargetDimensionsArgumentsBarItem1";
            this.pieTargetDimensionsSeriesBarItem1.Id = 98;
            this.pieTargetDimensionsSeriesBarItem1.Name = "pieTargetDimensionsSeriesBarItem1";
            this.pieTargetDimensionsPointsBarItem1.Id = 99;
            this.pieTargetDimensionsPointsBarItem1.Name = "pieTargetDimensionsPointsBarItem1";
            this.geoPointMapClusterizationRibbonPageGroup1.ItemLinks.Add(this.geoPointMapClusterizationBarItem1);
            this.geoPointMapClusterizationRibbonPageGroup1.Name = "geoPointMapClusterizationRibbonPageGroup1";
            this.geoPointMapClusterizationBarItem1.Id = 100;
            this.geoPointMapClusterizationBarItem1.Name = "geoPointMapClusterizationBarItem1";
            this.geoPointMapClusterizationRibbonPageGroup2.ItemLinks.Add(this.geoPointMapClusterizationBarItem1);
            this.geoPointMapClusterizationRibbonPageGroup2.Name = "geoPointMapClusterizationRibbonPageGroup2";
            this.geoPointMapClusterizationRibbonPageGroup3.ItemLinks.Add(this.geoPointMapClusterizationBarItem1);
            this.geoPointMapClusterizationRibbonPageGroup3.Name = "geoPointMapClusterizationRibbonPageGroup3";
            this.commonItemDesignRibbonPageGroup1.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup1.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup1.Name = "commonItemDesignRibbonPageGroup1";
            this.dashboardItemDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.commonItemDesignRibbonPageGroup1, this.gridStyleRibbonPageGroup1, this.gridLayoutRibbonPageGroup1, this.gridColumnWidthModeRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage1.Name = "dashboardItemDesignRibbonPage1";
            this.dashboardItemDesignRibbonPage1.Visible = false;
            this.showItemCaptionBarItem1.Id = 101;
            this.showItemCaptionBarItem1.Name = "showItemCaptionBarItem1";
            this.editItemNamesBarItem1.Id = 102;
            this.editItemNamesBarItem1.Name = "editItemNamesBarItem1";
            this.commonItemDesignRibbonPageGroup2.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup2.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup2.Name = "commonItemDesignRibbonPageGroup2";
            this.dashboardItemDesignRibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.commonItemDesignRibbonPageGroup2, this.chartLayoutPageGroup1, this.chartLegendPositionPageGroup1, this.chartStylePageGroup1, this.coloringOptionsRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage2.Name = "dashboardItemDesignRibbonPage2";
            this.dashboardItemDesignRibbonPage2.Visible = false;
            this.commonItemDesignRibbonPageGroup3.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup3.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup3.Name = "commonItemDesignRibbonPageGroup3";
            this.dashboardItemDesignRibbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.commonItemDesignRibbonPageGroup3, this.scatterChartLayoutPageGroup1, this.scatterChartPointLabelPageGroup1, this.scatterChartLegendPositionPageGroup1, this.coloringOptionsRibbonPageGroup2 });
            this.dashboardItemDesignRibbonPage3.Name = "dashboardItemDesignRibbonPage3";
            this.dashboardItemDesignRibbonPage3.Visible = false;
            this.commonItemDesignRibbonPageGroup4.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup4.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup4.Name = "commonItemDesignRibbonPageGroup4";
            this.dashboardItemDesignRibbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.commonItemDesignRibbonPageGroup4, this.contentArrangementRibbonPageGroup1, this.pieLabelsRibbonPageGroup1, this.pieStyleRibbonPageGroup1, this.coloringOptionsRibbonPageGroup3 });
            this.dashboardItemDesignRibbonPage4.Name = "dashboardItemDesignRibbonPage4";
            this.dashboardItemDesignRibbonPage4.Visible = false;
            this.commonItemDesignRibbonPageGroup5.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup5.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup5.Name = "commonItemDesignRibbonPageGroup5";
            this.dashboardItemDesignRibbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.commonItemDesignRibbonPageGroup5, this.contentArrangementRibbonPageGroup2, this.gaugeStyleRibbonPageGroup1, this.gaugesLabelsRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage5.Name = "dashboardItemDesignRibbonPage5";
            this.dashboardItemDesignRibbonPage5.Visible = false;
            this.commonItemDesignRibbonPageGroup6.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup6.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup6.Name = "commonItemDesignRibbonPageGroup6";
            this.dashboardItemDesignRibbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.commonItemDesignRibbonPageGroup6, this.contentArrangementRibbonPageGroup3 });
            this.dashboardItemDesignRibbonPage6.Name = "dashboardItemDesignRibbonPage6";
            this.dashboardItemDesignRibbonPage6.Visible = false;
            this.commonItemDesignRibbonPageGroup7.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup7.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup7.Name = "commonItemDesignRibbonPageGroup7";
            this.dashboardItemDesignRibbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.commonItemDesignRibbonPageGroup7, this.imageOpenRibbonPageGroup1, this.imageSizeModeRibbonPageGroup1, this.imageAlignmentRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage7.Name = "dashboardItemDesignRibbonPage7";
            this.dashboardItemDesignRibbonPage7.Visible = false;
            this.imageToolsRibbonPageCategory1.Control = this.dashboardDesigner1;
            this.imageToolsRibbonPageCategory1.Name = "imageToolsRibbonPageCategory1";
            this.imageToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[1] { this.dashboardItemDesignRibbonPage7 });
            this.imageToolsRibbonPageCategory1.Visible = false;
            this.commonItemDesignRibbonPageGroup8.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup8.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup8.Name = "commonItemDesignRibbonPageGroup8";
            this.dashboardItemDesignRibbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.commonItemDesignRibbonPageGroup8, this.imageSizeModeRibbonPageGroup2, this.imageAlignmentRibbonPageGroup2 });
            this.dashboardItemDesignRibbonPage8.Name = "dashboardItemDesignRibbonPage8";
            this.dashboardItemDesignRibbonPage8.Visible = false;
            this.commonItemDesignRibbonPageGroup9.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup9.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup9.Name = "commonItemDesignRibbonPageGroup9";
            this.dashboardItemDesignRibbonPage9.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.commonItemDesignRibbonPageGroup9, this.textBoxEditingRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage9.Name = "dashboardItemDesignRibbonPage9";
            this.dashboardItemDesignRibbonPage9.Visible = false;
            this.commonItemDesignRibbonPageGroup10.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup10.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup10.Name = "commonItemDesignRibbonPageGroup10";
            this.dashboardItemDesignRibbonPage10.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.commonItemDesignRibbonPageGroup10, this.rangeFilterSeriesTypeRibbonPageGroup1, this.coloringOptionsRibbonPageGroup4 });
            this.dashboardItemDesignRibbonPage10.Name = "dashboardItemDesignRibbonPage10";
            this.dashboardItemDesignRibbonPage10.Visible = false;
            this.commonItemDesignRibbonPageGroup11.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup11.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup11.Name = "commonItemDesignRibbonPageGroup11";
            this.dashboardItemDesignRibbonPage11.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.commonItemDesignRibbonPageGroup11 });
            this.dashboardItemDesignRibbonPage11.Name = "dashboardItemDesignRibbonPage11";
            this.dashboardItemDesignRibbonPage11.Visible = false;
            this.commonItemDesignRibbonPageGroup12.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup12.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup12.Name = "commonItemDesignRibbonPageGroup12";
            this.dashboardItemDesignRibbonPage12.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.commonItemDesignRibbonPageGroup12, this.mapShapefileRibbonPageGroup1, this.mapNavigationPageGroup1, this.mapShapeLabelsAttributePageGroup1, this.mapLegendPositionPageGroup1 });
            this.dashboardItemDesignRibbonPage12.Name = "dashboardItemDesignRibbonPage12";
            this.dashboardItemDesignRibbonPage12.Visible = false;
            this.commonItemDesignRibbonPageGroup13.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup13.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup13.Name = "commonItemDesignRibbonPageGroup13";
            this.dashboardItemDesignRibbonPage13.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.commonItemDesignRibbonPageGroup13, this.mapShapefileRibbonPageGroup2, this.mapNavigationPageGroup2, this.mapShapeLabelsAttributePageGroup2 });
            this.dashboardItemDesignRibbonPage13.Name = "dashboardItemDesignRibbonPage13";
            this.dashboardItemDesignRibbonPage13.Visible = false;
            this.commonItemDesignRibbonPageGroup14.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup14.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup14.Name = "commonItemDesignRibbonPageGroup14";
            this.dashboardItemDesignRibbonPage14.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[6] { this.commonItemDesignRibbonPageGroup14, this.mapShapefileRibbonPageGroup3, this.mapNavigationPageGroup3, this.mapShapeLabelsAttributePageGroup3, this.mapLegendPositionPageGroup2, this.weightedLegendPageGroup1 });
            this.dashboardItemDesignRibbonPage14.Name = "dashboardItemDesignRibbonPage14";
            this.dashboardItemDesignRibbonPage14.Visible = false;
            this.commonItemDesignRibbonPageGroup15.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup15.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup15.Name = "commonItemDesignRibbonPageGroup15";
            this.dashboardItemDesignRibbonPage15.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[8] { this.commonItemDesignRibbonPageGroup15, this.mapShapefileRibbonPageGroup4, this.mapNavigationPageGroup4, this.mapShapeLabelsAttributePageGroup4, this.mapLegendPositionPageGroup3, this.weightedLegendPageGroup2, this.pieMapOptionsPageGroup1, this.coloringOptionsRibbonPageGroup5 });
            this.dashboardItemDesignRibbonPage15.Name = "dashboardItemDesignRibbonPage15";
            this.dashboardItemDesignRibbonPage15.Visible = false;
            this.commonItemDesignRibbonPageGroup16.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup16.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup16.Name = "commonItemDesignRibbonPageGroup16";
            this.dashboardItemDesignRibbonPage16.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.commonItemDesignRibbonPageGroup16 });
            this.dashboardItemDesignRibbonPage16.Name = "dashboardItemDesignRibbonPage16";
            this.dashboardItemDesignRibbonPage16.Visible = false;
            this.commonItemDesignRibbonPageGroup17.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.commonItemDesignRibbonPageGroup17.ItemLinks.Add(this.editItemNamesBarItem1);
            this.commonItemDesignRibbonPageGroup17.Name = "commonItemDesignRibbonPageGroup17";
            this.dashboardItemDesignRibbonPage17.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.commonItemDesignRibbonPageGroup17, this.filterElementTypeRibbonPageGroup1, this.treeViewLayoutRibbonPageGroup1, this.filterElementItemOptionsRibbonPageGroup1 });
            this.dashboardItemDesignRibbonPage17.Name = "dashboardItemDesignRibbonPage17";
            this.dashboardItemDesignRibbonPage17.Visible = false;
            this.contentArrangementRibbonPageGroup1.ItemLinks.Add(this.contentAutoArrangeBarItem1);
            this.contentArrangementRibbonPageGroup1.ItemLinks.Add(this.contentArrangeInColumnsBarItem1);
            this.contentArrangementRibbonPageGroup1.ItemLinks.Add(this.contentArrangeInRowsBarItem1);
            this.contentArrangementRibbonPageGroup1.ItemLinks.Add(this.contentArrangementCountBarItem1);
            this.contentArrangementRibbonPageGroup1.Name = "contentArrangementRibbonPageGroup1";
            this.contentAutoArrangeBarItem1.Id = 103;
            this.contentAutoArrangeBarItem1.Name = "contentAutoArrangeBarItem1";
            this.contentArrangeInColumnsBarItem1.Id = 104;
            this.contentArrangeInColumnsBarItem1.Name = "contentArrangeInColumnsBarItem1";
            this.contentArrangeInRowsBarItem1.Id = 105;
            this.contentArrangeInRowsBarItem1.Name = "contentArrangeInRowsBarItem1";
            this.contentArrangementCountBarItem1.Edit = this.repositoryItemSpinEdit1;
            this.contentArrangementCountBarItem1.Id = 106;
            this.contentArrangementCountBarItem1.Name = "contentArrangementCountBarItem1";
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[4] { 10000, 0, 0, 0 });
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.contentArrangementRibbonPageGroup2.ItemLinks.Add(this.contentAutoArrangeBarItem1);
            this.contentArrangementRibbonPageGroup2.ItemLinks.Add(this.contentArrangeInColumnsBarItem1);
            this.contentArrangementRibbonPageGroup2.ItemLinks.Add(this.contentArrangeInRowsBarItem1);
            this.contentArrangementRibbonPageGroup2.ItemLinks.Add(this.contentArrangementCountBarItem1);
            this.contentArrangementRibbonPageGroup2.Name = "contentArrangementRibbonPageGroup2";
            this.contentArrangementRibbonPageGroup3.ItemLinks.Add(this.contentAutoArrangeBarItem1);
            this.contentArrangementRibbonPageGroup3.ItemLinks.Add(this.contentArrangeInColumnsBarItem1);
            this.contentArrangementRibbonPageGroup3.ItemLinks.Add(this.contentArrangeInRowsBarItem1);
            this.contentArrangementRibbonPageGroup3.ItemLinks.Add(this.contentArrangementCountBarItem1);
            this.contentArrangementRibbonPageGroup3.Name = "contentArrangementRibbonPageGroup3";
            this.gridStyleRibbonPageGroup1.ItemLinks.Add(this.gridHorizontalLinesBarItem1);
            this.gridStyleRibbonPageGroup1.ItemLinks.Add(this.gridVerticalLinesBarItem1);
            this.gridStyleRibbonPageGroup1.ItemLinks.Add(this.gridBandedRowsBarItem1);
            this.gridStyleRibbonPageGroup1.Name = "gridStyleRibbonPageGroup1";
            this.gridHorizontalLinesBarItem1.Id = 107;
            this.gridHorizontalLinesBarItem1.Name = "gridHorizontalLinesBarItem1";
            this.gridVerticalLinesBarItem1.Id = 108;
            this.gridVerticalLinesBarItem1.Name = "gridVerticalLinesBarItem1";
            this.gridBandedRowsBarItem1.Id = 109;
            this.gridBandedRowsBarItem1.Name = "gridBandedRowsBarItem1";
            this.gridLayoutRibbonPageGroup1.ItemLinks.Add(this.gridMergeCellsBarItem1);
            this.gridLayoutRibbonPageGroup1.ItemLinks.Add(this.gridColumnHeadersBarItem1);
            this.gridLayoutRibbonPageGroup1.ItemLinks.Add(this.gridWordWrapBarItem1);
            this.gridLayoutRibbonPageGroup1.Name = "gridLayoutRibbonPageGroup1";
            this.gridMergeCellsBarItem1.Id = 110;
            this.gridMergeCellsBarItem1.Name = "gridMergeCellsBarItem1";
            this.gridColumnHeadersBarItem1.Id = 111;
            this.gridColumnHeadersBarItem1.Name = "gridColumnHeadersBarItem1";
            this.gridWordWrapBarItem1.Id = 112;
            this.gridWordWrapBarItem1.Name = "gridWordWrapBarItem1";
            this.gridColumnWidthModeRibbonPageGroup1.ItemLinks.Add(this.gridAutoFitToContentsColumnWidthModeBarItem1);
            this.gridColumnWidthModeRibbonPageGroup1.ItemLinks.Add(this.gridAutoFitToGridColumnWidthModeBarItem1);
            this.gridColumnWidthModeRibbonPageGroup1.ItemLinks.Add(this.manualGridColumnWidthModeBarItem1);
            this.gridColumnWidthModeRibbonPageGroup1.Name = "gridColumnWidthModeRibbonPageGroup1";
            this.gridAutoFitToContentsColumnWidthModeBarItem1.Id = 113;
            this.gridAutoFitToContentsColumnWidthModeBarItem1.Name = "gridAutoFitToContentsColumnWidthModeBarItem1";
            this.gridAutoFitToGridColumnWidthModeBarItem1.Id = 114;
            this.gridAutoFitToGridColumnWidthModeBarItem1.Name = "gridAutoFitToGridColumnWidthModeBarItem1";
            this.manualGridColumnWidthModeBarItem1.Id = 115;
            this.manualGridColumnWidthModeBarItem1.Name = "manualGridColumnWidthModeBarItem1";
            this.chartLayoutPageGroup1.ItemLinks.Add(this.chartRotateBarItem1);
            this.chartLayoutPageGroup1.ItemLinks.Add(this.chartXAxisSettingsBarItem1);
            this.chartLayoutPageGroup1.ItemLinks.Add(this.chartYAxisSettingsBarItem1);
            this.chartLayoutPageGroup1.Name = "chartLayoutPageGroup1";
            this.chartRotateBarItem1.Id = 116;
            this.chartRotateBarItem1.Name = "chartRotateBarItem1";
            this.chartXAxisSettingsBarItem1.Id = 117;
            this.chartXAxisSettingsBarItem1.Name = "chartXAxisSettingsBarItem1";
            this.chartYAxisSettingsBarItem1.Id = 118;
            this.chartYAxisSettingsBarItem1.Name = "chartYAxisSettingsBarItem1";
            this.scatterChartLayoutPageGroup1.ItemLinks.Add(this.scatterChartRotateBarItem1);
            this.scatterChartLayoutPageGroup1.ItemLinks.Add(this.scatterChartXAxisSettingsBarItem1);
            this.scatterChartLayoutPageGroup1.ItemLinks.Add(this.scatterChartYAxisSettingsBarItem1);
            this.scatterChartLayoutPageGroup1.Name = "scatterChartLayoutPageGroup1";
            this.scatterChartRotateBarItem1.Id = 119;
            this.scatterChartRotateBarItem1.Name = "scatterChartRotateBarItem1";
            this.scatterChartXAxisSettingsBarItem1.Id = 120;
            this.scatterChartXAxisSettingsBarItem1.Name = "scatterChartXAxisSettingsBarItem1";
            this.scatterChartYAxisSettingsBarItem1.Id = 121;
            this.scatterChartYAxisSettingsBarItem1.Name = "scatterChartYAxisSettingsBarItem1";
            this.scatterChartPointLabelPageGroup1.ItemLinks.Add(this.scatterChartPointLabelOptionsBarItem1);
            this.scatterChartPointLabelPageGroup1.Name = "scatterChartPointLabelPageGroup1";
            this.scatterChartPointLabelOptionsBarItem1.Id = 122;
            this.scatterChartPointLabelOptionsBarItem1.Name = "scatterChartPointLabelOptionsBarItem1";
            this.chartLegendPositionPageGroup1.ItemLinks.Add(this.chartShowLegendBarItem1);
            this.chartLegendPositionPageGroup1.ItemLinks.Add(this.galleryChartLegendPositionItem1);
            this.chartLegendPositionPageGroup1.Name = "chartLegendPositionPageGroup1";
            this.chartShowLegendBarItem1.Id = 123;
            this.chartShowLegendBarItem1.Name = "chartShowLegendBarItem1";
            this.galleryChartLegendPositionItem1.Gallery.ColumnCount = 3;
            galleryItemGroup5.Caption = "Interior Horizontal";
            galleryItemGroup6.Caption = "Interior Vertical";
            galleryItemGroup7.Caption = "Fuera Horizontal";
            galleryItemGroup8.Caption = "Fuera Vertical";
            this.galleryChartLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[4] { galleryItemGroup5, galleryItemGroup6, galleryItemGroup7, galleryItemGroup8 });
            this.galleryChartLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryChartLegendPositionItem1.Gallery.RowCount = 8;
            this.galleryChartLegendPositionItem1.Id = 124;
            this.galleryChartLegendPositionItem1.Name = "galleryChartLegendPositionItem1";
            this.scatterChartLegendPositionPageGroup1.ItemLinks.Add(this.scatterChartShowLegendBarItem1);
            this.scatterChartLegendPositionPageGroup1.ItemLinks.Add(this.galleryScatterChartLegendPositionItem1);
            this.scatterChartLegendPositionPageGroup1.Name = "scatterChartLegendPositionPageGroup1";
            this.scatterChartShowLegendBarItem1.Id = 125;
            this.scatterChartShowLegendBarItem1.Name = "scatterChartShowLegendBarItem1";
            this.galleryScatterChartLegendPositionItem1.Gallery.ColumnCount = 3;
            galleryItemGroup9.Caption = "Interior Horizontal";
            galleryItemGroup10.Caption = "Interior Vertical";
            galleryItemGroup11.Caption = "Fuera Horizontal";
            galleryItemGroup12.Caption = "Fuera Vertical";
            this.galleryScatterChartLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[4] { galleryItemGroup9, galleryItemGroup10, galleryItemGroup11, galleryItemGroup12 });
            this.galleryScatterChartLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryScatterChartLegendPositionItem1.Gallery.RowCount = 8;
            this.galleryScatterChartLegendPositionItem1.Id = 126;
            this.galleryScatterChartLegendPositionItem1.Name = "galleryScatterChartLegendPositionItem1";
            this.chartStylePageGroup1.ItemLinks.Add(this.galleryChartSeriesTypeItem1);
            this.chartStylePageGroup1.Name = "chartStylePageGroup1";
            galleryItemGroup13.Caption = "Barras";
            chartSeriesTypeGalleryItem.Hint = "Barras";
            //chartSeriesTypeGalleryItem.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem1.Image");
            chartSeriesTypeGalleryItem.SeriesTypeCaption = "Barras";
            chartSeriesTypeGalleryItem2.Hint = "Barras Apiladas";
           // chartSeriesTypeGalleryItem2.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem2.Image");
            chartSeriesTypeGalleryItem2.SeriesTypeCaption = "Barras Apiladas";
            chartSeriesTypeGalleryItem3.Hint = "Barras Apiladas Completas";
            //chartSeriesTypeGalleryItem3.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem3.Image");
            chartSeriesTypeGalleryItem3.SeriesTypeCaption = "Barras Apiladas Completas";
            galleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { chartSeriesTypeGalleryItem, chartSeriesTypeGalleryItem2, chartSeriesTypeGalleryItem3 });
            galleryItemGroup14.Caption = "Punto / Línea";
            chartSeriesTypeGalleryItem4.Hint = "Puntos";
            //chartSeriesTypeGalleryItem4.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem4.Image");
            chartSeriesTypeGalleryItem4.SeriesTypeCaption = "Puntos";
            chartSeriesTypeGalleryItem5.Hint = "Línea";
            //chartSeriesTypeGalleryItem5.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem5.Image");
            chartSeriesTypeGalleryItem5.SeriesTypeCaption = "Línea";
            chartSeriesTypeGalleryItem6.Hint = "Líneas Apiladas";
            //chartSeriesTypeGalleryItem6.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem6.Image");
            chartSeriesTypeGalleryItem6.SeriesTypeCaption = "Líneas Apiladas";
            chartSeriesTypeGalleryItem7.Hint = "Líneas Apiladas Completas";
            //chartSeriesTypeGalleryItem7.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem7.Image");
            chartSeriesTypeGalleryItem7.SeriesTypeCaption = "Líneas Apiladas Completas";
            chartSeriesTypeGalleryItem8.Hint = "Línea Escalonada";
            //chartSeriesTypeGalleryItem8.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem8.Image");
            chartSeriesTypeGalleryItem8.SeriesTypeCaption = "Línea Escalonada";
            chartSeriesTypeGalleryItem9.Hint = "Contorno";
           // chartSeriesTypeGalleryItem9.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem9.Image");
            chartSeriesTypeGalleryItem9.SeriesTypeCaption = "Contorno";
            galleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[6] { chartSeriesTypeGalleryItem4, chartSeriesTypeGalleryItem5, chartSeriesTypeGalleryItem6, chartSeriesTypeGalleryItem7, chartSeriesTypeGalleryItem8, chartSeriesTypeGalleryItem9 });
            galleryItemGroup15.Caption = "Área";
            chartSeriesTypeGalleryItem10.Hint = "Área";
            //chartSeriesTypeGalleryItem10.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem10.Image");
            chartSeriesTypeGalleryItem10.SeriesTypeCaption = "Área";
            chartSeriesTypeGalleryItem11.Hint = "Área de Contorno";
            //chartSeriesTypeGalleryItem11.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem11.Image");
            chartSeriesTypeGalleryItem11.SeriesTypeCaption = "Área de Contorno";
            chartSeriesTypeGalleryItem12.Hint = "Áreas Apiladas Completas";
            //chartSeriesTypeGalleryItem12.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem12.Image");
            chartSeriesTypeGalleryItem12.SeriesTypeCaption = "Áreas Apiladas Completas";
            chartSeriesTypeGalleryItem13.Hint = "Área de Escalón";
            //chartSeriesTypeGalleryItem13.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem13.Image");
            chartSeriesTypeGalleryItem13.SeriesTypeCaption = "Área de Escalón";
            chartSeriesTypeGalleryItem14.Hint = "Contorno Área";
            //chartSeriesTypeGalleryItem14.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem14.Image");
            chartSeriesTypeGalleryItem14.SeriesTypeCaption = "Contorno Área";
            chartSeriesTypeGalleryItem15.Hint = "Área de Contorno Apilado";
            //chartSeriesTypeGalleryItem15.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem15.Image");
            chartSeriesTypeGalleryItem15.SeriesTypeCaption = "Área de Contorno Apilado";
            chartSeriesTypeGalleryItem16.Hint = "Área de Contorno Apilado Completo";
            //chartSeriesTypeGalleryItem16.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem16.Image");
            chartSeriesTypeGalleryItem16.SeriesTypeCaption = "Área de Contorno Apilado Completo";
            galleryItemGroup15.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[7] { chartSeriesTypeGalleryItem10, chartSeriesTypeGalleryItem11, chartSeriesTypeGalleryItem12, chartSeriesTypeGalleryItem13, chartSeriesTypeGalleryItem14, chartSeriesTypeGalleryItem15, chartSeriesTypeGalleryItem16 });
            galleryItemGroup16.Caption = "Rango";
            chartSeriesTypeGalleryItem17.Hint = "Barras de Rango Uno a Lado de Otro";
            //chartSeriesTypeGalleryItem17.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem17.Image");
            chartSeriesTypeGalleryItem17.SeriesTypeCaption = "Barras de Rango Uno a Lado de Otro";
            chartSeriesTypeGalleryItem18.Hint = "Área de Rango";
            //chartSeriesTypeGalleryItem18.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem18.Image");
            chartSeriesTypeGalleryItem18.SeriesTypeCaption = "Área de Rango";
            galleryItemGroup16.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { chartSeriesTypeGalleryItem17, chartSeriesTypeGalleryItem18 });
            galleryItemGroup17.Caption = "Burbuja";
            chartSeriesTypeGalleryItem19.Hint = "Burbuja";
            //chartSeriesTypeGalleryItem19.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem19.Image");
            chartSeriesTypeGalleryItem19.SeriesTypeCaption = "Burbuja";
            galleryItemGroup17.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[1] { chartSeriesTypeGalleryItem19 });
            galleryItemGroup18.Caption = "Financiero";
            chartSeriesTypeGalleryItem20.Hint = "Alto-Bajo-Cerrar";
            //chartSeriesTypeGalleryItem20.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem20.Image");
            chartSeriesTypeGalleryItem20.SeriesTypeCaption = "Alto-Bajo-Cerrar";
            chartSeriesTypeGalleryItem21.Hint = "Abrir-Alto-Bajo-Cerrar (Vela)";
            //chartSeriesTypeGalleryItem21.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem21.Image");
            chartSeriesTypeGalleryItem21.SeriesTypeCaption = "Abrir-Alto-Bajo-Cerrar (Vela)";
            chartSeriesTypeGalleryItem22.Hint = "Abrir-Alto-Bajo-Cerrar (Stock)";
            //chartSeriesTypeGalleryItem22.Image = (System.Drawing.Image)resources.GetObject("chartSeriesTypeGalleryItem22.Image");
            chartSeriesTypeGalleryItem22.SeriesTypeCaption = "Abrir-Alto-Bajo-Cerrar (Stock)";
            galleryItemGroup18.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { chartSeriesTypeGalleryItem20, chartSeriesTypeGalleryItem21, chartSeriesTypeGalleryItem22 });
            this.galleryChartSeriesTypeItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[6] { galleryItemGroup13, galleryItemGroup14, galleryItemGroup15, galleryItemGroup16, galleryItemGroup17, galleryItemGroup18 });
            this.galleryChartSeriesTypeItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryChartSeriesTypeItem1.Gallery.RowCount = 8;
            this.galleryChartSeriesTypeItem1.Id = 127;
            this.galleryChartSeriesTypeItem1.Name = "galleryChartSeriesTypeItem1";
            this.pieLabelsRibbonPageGroup1.ItemLinks.Add(this.pieLabelsDataLabelsBarItem1);
            this.pieLabelsRibbonPageGroup1.ItemLinks.Add(this.pieTooltipsBarItem1);
            this.pieLabelsRibbonPageGroup1.ItemLinks.Add(this.pieShowCaptionsBarItem1);
            this.pieLabelsRibbonPageGroup1.Name = "pieLabelsRibbonPageGroup1";
            this.pieLabelsDataLabelsBarItem1.Id = 128;
            this.pieLabelsDataLabelsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsNoneBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelArgumentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsValueBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsArgumentAndValueBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsValueAndPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsArgumentAndPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1)
            });
            this.pieLabelsDataLabelsBarItem1.Name = "pieLabelsDataLabelsBarItem1";
            this.pieLabelsDataLabelsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.pieLabelsDataLabelsNoneBarItem1.Id = 129;
            this.pieLabelsDataLabelsNoneBarItem1.Name = "pieLabelsDataLabelsNoneBarItem1";
            this.pieLabelsDataLabelArgumentBarItem1.Id = 130;
            this.pieLabelsDataLabelArgumentBarItem1.Name = "pieLabelsDataLabelArgumentBarItem1";
            this.pieLabelsDataLabelsValueBarItem1.Id = 131;
            this.pieLabelsDataLabelsValueBarItem1.Name = "pieLabelsDataLabelsValueBarItem1";
            this.pieLabelsDataLabelsArgumentAndValueBarItem1.Id = 132;
            this.pieLabelsDataLabelsArgumentAndValueBarItem1.Name = "pieLabelsDataLabelsArgumentAndValueBarItem1";
            this.pieLabelsDataLabelsPercentBarItem1.Id = 133;
            this.pieLabelsDataLabelsPercentBarItem1.Name = "pieLabelsDataLabelsPercentBarItem1";
            this.pieLabelsDataLabelsValueAndPercentBarItem1.Id = 134;
            this.pieLabelsDataLabelsValueAndPercentBarItem1.Name = "pieLabelsDataLabelsValueAndPercentBarItem1";
            this.pieLabelsDataLabelsArgumentAndPercentBarItem1.Id = 135;
            this.pieLabelsDataLabelsArgumentAndPercentBarItem1.Name = "pieLabelsDataLabelsArgumentAndPercentBarItem1";
            this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1.Id = 136;
            this.pieLabelsDataLabelsArgumentValueAndPercentBarItem1.Name = "pieLabelsDataLabelsArgumentValueAndPercentBarItem1";
            this.pieTooltipsBarItem1.Id = 137;
            this.pieTooltipsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsNoneBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsArgumentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsValueBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsArgumentAndValueBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsValueAndPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsArgumentAndPercentBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pieLabelsTooltipsArgumentValueAndPercentBarItem1)
            });
            this.pieTooltipsBarItem1.Name = "pieTooltipsBarItem1";
            this.pieTooltipsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.pieLabelsTooltipsNoneBarItem1.Id = 138;
            this.pieLabelsTooltipsNoneBarItem1.Name = "pieLabelsTooltipsNoneBarItem1";
            this.pieLabelsTooltipsArgumentBarItem1.Id = 139;
            this.pieLabelsTooltipsArgumentBarItem1.Name = "pieLabelsTooltipsArgumentBarItem1";
            this.pieLabelsTooltipsValueBarItem1.Id = 140;
            this.pieLabelsTooltipsValueBarItem1.Name = "pieLabelsTooltipsValueBarItem1";
            this.pieLabelsTooltipsArgumentAndValueBarItem1.Id = 141;
            this.pieLabelsTooltipsArgumentAndValueBarItem1.Name = "pieLabelsTooltipsArgumentAndValueBarItem1";
            this.pieLabelsTooltipsPercentBarItem1.Id = 142;
            this.pieLabelsTooltipsPercentBarItem1.Name = "pieLabelsTooltipsPercentBarItem1";
            this.pieLabelsTooltipsValueAndPercentBarItem1.Id = 143;
            this.pieLabelsTooltipsValueAndPercentBarItem1.Name = "pieLabelsTooltipsValueAndPercentBarItem1";
            this.pieLabelsTooltipsArgumentAndPercentBarItem1.Id = 144;
            this.pieLabelsTooltipsArgumentAndPercentBarItem1.Name = "pieLabelsTooltipsArgumentAndPercentBarItem1";
            this.pieLabelsTooltipsArgumentValueAndPercentBarItem1.Id = 145;
            this.pieLabelsTooltipsArgumentValueAndPercentBarItem1.Name = "pieLabelsTooltipsArgumentValueAndPercentBarItem1";
            this.pieStyleRibbonPageGroup1.ItemLinks.Add(this.pieStylePieBarItem1);
            this.pieStyleRibbonPageGroup1.ItemLinks.Add(this.pieStyleDonutBarItem1);
            this.pieStyleRibbonPageGroup1.Name = "pieStyleRibbonPageGroup1";
            this.pieStylePieBarItem1.Id = 146;
            this.pieStylePieBarItem1.Name = "pieStylePieBarItem1";
            this.pieStyleDonutBarItem1.Id = 147;
            this.pieStyleDonutBarItem1.Name = "pieStyleDonutBarItem1";
            this.pieShowCaptionsBarItem1.Id = 148;
            this.pieShowCaptionsBarItem1.Name = "pieShowCaptionsBarItem1";
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleFullCircularBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleHalfCircularBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleLeftQuarterCircularBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleRightQuarterCircularBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleThreeForthCircularBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleLinearHorizontalBarItem1);
            this.gaugeStyleRibbonPageGroup1.ItemLinks.Add(this.gaugeStyleLinearVerticalBarItem1);
            this.gaugeStyleRibbonPageGroup1.Name = "gaugeStyleRibbonPageGroup1";
            this.gaugeStyleFullCircularBarItem1.Id = 149;
            this.gaugeStyleFullCircularBarItem1.Name = "gaugeStyleFullCircularBarItem1";
            this.gaugeStyleHalfCircularBarItem1.Id = 150;
            this.gaugeStyleHalfCircularBarItem1.Name = "gaugeStyleHalfCircularBarItem1";
            this.gaugeStyleLeftQuarterCircularBarItem1.Id = 151;
            this.gaugeStyleLeftQuarterCircularBarItem1.Name = "gaugeStyleLeftQuarterCircularBarItem1";
            this.gaugeStyleRightQuarterCircularBarItem1.Id = 152;
            this.gaugeStyleRightQuarterCircularBarItem1.Name = "gaugeStyleRightQuarterCircularBarItem1";
            this.gaugeStyleThreeForthCircularBarItem1.Id = 153;
            this.gaugeStyleThreeForthCircularBarItem1.Name = "gaugeStyleThreeForthCircularBarItem1";
            this.gaugeStyleLinearHorizontalBarItem1.Id = 154;
            this.gaugeStyleLinearHorizontalBarItem1.Name = "gaugeStyleLinearHorizontalBarItem1";
            this.gaugeStyleLinearVerticalBarItem1.Id = 155;
            this.gaugeStyleLinearVerticalBarItem1.Name = "gaugeStyleLinearVerticalBarItem1";
            this.gaugesLabelsRibbonPageGroup1.ItemLinks.Add(this.gaugeShowCaptionsBarItem1);
            this.gaugesLabelsRibbonPageGroup1.Name = "gaugesLabelsRibbonPageGroup1";
            this.gaugeShowCaptionsBarItem1.Id = 156;
            this.gaugeShowCaptionsBarItem1.Name = "gaugeShowCaptionsBarItem1";
            this.imageOpenRibbonPageGroup1.ItemLinks.Add(this.imageLoadBarItem1);
            this.imageOpenRibbonPageGroup1.ItemLinks.Add(this.imageImportBarItem1);
            this.imageOpenRibbonPageGroup1.Name = "imageOpenRibbonPageGroup1";
            this.imageLoadBarItem1.Id = 157;
            this.imageLoadBarItem1.Name = "imageLoadBarItem1";
            this.imageImportBarItem1.Id = 158;
            this.imageImportBarItem1.Name = "imageImportBarItem1";
            this.imageSizeModeRibbonPageGroup1.ItemLinks.Add(this.imageSizeModeClipBarItem1);
            this.imageSizeModeRibbonPageGroup1.ItemLinks.Add(this.imageSizeModeStretchBarItem1);
            this.imageSizeModeRibbonPageGroup1.ItemLinks.Add(this.imageSizeModeSqueezeBarItem1);
            this.imageSizeModeRibbonPageGroup1.ItemLinks.Add(this.imageSizeModeZoomBarItem1);
            this.imageSizeModeRibbonPageGroup1.Name = "imageSizeModeRibbonPageGroup1";
            this.imageSizeModeClipBarItem1.Id = 159;
            this.imageSizeModeClipBarItem1.Name = "imageSizeModeClipBarItem1";
            this.imageSizeModeStretchBarItem1.Id = 160;
            this.imageSizeModeStretchBarItem1.Name = "imageSizeModeStretchBarItem1";
            this.imageSizeModeSqueezeBarItem1.Id = 161;
            this.imageSizeModeSqueezeBarItem1.Name = "imageSizeModeSqueezeBarItem1";
            this.imageSizeModeZoomBarItem1.Id = 162;
            this.imageSizeModeZoomBarItem1.Name = "imageSizeModeZoomBarItem1";
            this.imageSizeModeRibbonPageGroup2.ItemLinks.Add(this.imageSizeModeClipBarItem1);
            this.imageSizeModeRibbonPageGroup2.ItemLinks.Add(this.imageSizeModeStretchBarItem1);
            this.imageSizeModeRibbonPageGroup2.ItemLinks.Add(this.imageSizeModeSqueezeBarItem1);
            this.imageSizeModeRibbonPageGroup2.ItemLinks.Add(this.imageSizeModeZoomBarItem1);
            this.imageSizeModeRibbonPageGroup2.Name = "imageSizeModeRibbonPageGroup2";
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentTopLeftBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentCenterLeftBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentBottomLeftBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentTopCenterBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentCenterCenterBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentBottomCenterBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentTopRightBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentCenterRightBarItem1);
            this.imageAlignmentRibbonPageGroup1.ItemLinks.Add(this.imageAlignmentBottomRightBarItem1);
            this.imageAlignmentRibbonPageGroup1.Name = "imageAlignmentRibbonPageGroup1";
            this.imageAlignmentTopLeftBarItem1.Id = 163;
            this.imageAlignmentTopLeftBarItem1.Name = "imageAlignmentTopLeftBarItem1";
            this.imageAlignmentTopLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentCenterLeftBarItem1.Id = 164;
            this.imageAlignmentCenterLeftBarItem1.Name = "imageAlignmentCenterLeftBarItem1";
            this.imageAlignmentCenterLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentBottomLeftBarItem1.Id = 165;
            this.imageAlignmentBottomLeftBarItem1.Name = "imageAlignmentBottomLeftBarItem1";
            this.imageAlignmentBottomLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentTopCenterBarItem1.Id = 166;
            this.imageAlignmentTopCenterBarItem1.Name = "imageAlignmentTopCenterBarItem1";
            this.imageAlignmentTopCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentCenterCenterBarItem1.Id = 167;
            this.imageAlignmentCenterCenterBarItem1.Name = "imageAlignmentCenterCenterBarItem1";
            this.imageAlignmentCenterCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentBottomCenterBarItem1.Id = 168;
            this.imageAlignmentBottomCenterBarItem1.Name = "imageAlignmentBottomCenterBarItem1";
            this.imageAlignmentBottomCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentTopRightBarItem1.Id = 169;
            this.imageAlignmentTopRightBarItem1.Name = "imageAlignmentTopRightBarItem1";
            this.imageAlignmentTopRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentCenterRightBarItem1.Id = 170;
            this.imageAlignmentCenterRightBarItem1.Name = "imageAlignmentCenterRightBarItem1";
            this.imageAlignmentCenterRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentBottomRightBarItem1.Id = 171;
            this.imageAlignmentBottomRightBarItem1.Name = "imageAlignmentBottomRightBarItem1";
            this.imageAlignmentBottomRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentTopLeftBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentCenterLeftBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentBottomLeftBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentTopCenterBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentCenterCenterBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentBottomCenterBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentTopRightBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentCenterRightBarItem1);
            this.imageAlignmentRibbonPageGroup2.ItemLinks.Add(this.imageAlignmentBottomRightBarItem1);
            this.imageAlignmentRibbonPageGroup2.Name = "imageAlignmentRibbonPageGroup2";
            this.textBoxEditingRibbonPageGroup1.ItemLinks.Add(this.textBoxEditTextBarItem1);
            this.textBoxEditingRibbonPageGroup1.ItemLinks.Add(this.textBoxInsertFieldBarItem1);
            this.textBoxEditingRibbonPageGroup1.Name = "textBoxEditingRibbonPageGroup1";
            this.textBoxEditTextBarItem1.Id = 172;
            this.textBoxEditTextBarItem1.Name = "textBoxEditTextBarItem1";
            this.textBoxInsertFieldBarItem1.Id = 173;
            this.textBoxInsertFieldBarItem1.Name = "textBoxInsertFieldBarItem1";
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterLineSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterStackedLineSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterFullStackedLineSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterAreaSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterStackedAreaSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterFullStackedAreaSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterBarSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterStackedBarSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.rangeFilterFullStackedBarSeriesTypeBarItem1);
            this.rangeFilterSeriesTypeRibbonPageGroup1.Name = "rangeFilterSeriesTypeRibbonPageGroup1";
            this.rangeFilterLineSeriesTypeBarItem1.Id = 174;
            this.rangeFilterLineSeriesTypeBarItem1.Name = "rangeFilterLineSeriesTypeBarItem1";
            this.rangeFilterStackedLineSeriesTypeBarItem1.Id = 175;
            this.rangeFilterStackedLineSeriesTypeBarItem1.Name = "rangeFilterStackedLineSeriesTypeBarItem1";
            this.rangeFilterFullStackedLineSeriesTypeBarItem1.Id = 176;
            this.rangeFilterFullStackedLineSeriesTypeBarItem1.Name = "rangeFilterFullStackedLineSeriesTypeBarItem1";
            this.rangeFilterAreaSeriesTypeBarItem1.Id = 177;
            this.rangeFilterAreaSeriesTypeBarItem1.Name = "rangeFilterAreaSeriesTypeBarItem1";
            this.rangeFilterStackedAreaSeriesTypeBarItem1.Id = 178;
            this.rangeFilterStackedAreaSeriesTypeBarItem1.Name = "rangeFilterStackedAreaSeriesTypeBarItem1";
            this.rangeFilterFullStackedAreaSeriesTypeBarItem1.Id = 179;
            this.rangeFilterFullStackedAreaSeriesTypeBarItem1.Name = "rangeFilterFullStackedAreaSeriesTypeBarItem1";
            this.rangeFilterBarSeriesTypeBarItem1.Id = 180;
            this.rangeFilterBarSeriesTypeBarItem1.Name = "rangeFilterBarSeriesTypeBarItem1";
            this.rangeFilterStackedBarSeriesTypeBarItem1.Id = 181;
            this.rangeFilterStackedBarSeriesTypeBarItem1.Name = "rangeFilterStackedBarSeriesTypeBarItem1";
            this.rangeFilterFullStackedBarSeriesTypeBarItem1.Id = 182;
            this.rangeFilterFullStackedBarSeriesTypeBarItem1.Name = "rangeFilterFullStackedBarSeriesTypeBarItem1";
            this.pivotLayoutRibbonPageGroup1.ItemLinks.Add(this.pivotInitialStateBarItem1);
            this.pivotLayoutRibbonPageGroup1.ItemLinks.Add(this.pivotShowTotalsBarItem1);
            this.pivotLayoutRibbonPageGroup1.ItemLinks.Add(this.pivotShowGrandTotalsBarItem1);
            this.pivotLayoutRibbonPageGroup1.Name = "pivotLayoutRibbonPageGroup1";
            this.pivotInitialStateBarItem1.Id = 183;
            this.pivotInitialStateBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotAutoExpandColumnBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotAutoExpandRowBarItem1)
            });
            this.pivotInitialStateBarItem1.Name = "pivotInitialStateBarItem1";
            this.pivotInitialStateBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.pivotAutoExpandColumnBarItem1.Id = 184;
            this.pivotAutoExpandColumnBarItem1.Name = "pivotAutoExpandColumnBarItem1";
            this.pivotAutoExpandRowBarItem1.Id = 185;
            this.pivotAutoExpandRowBarItem1.Name = "pivotAutoExpandRowBarItem1";
            this.pivotShowTotalsBarItem1.Id = 186;
            this.pivotShowTotalsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotShowColumnTotalsBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotShowRowTotalsBarItem1)
            });
            this.pivotShowTotalsBarItem1.Name = "pivotShowTotalsBarItem1";
            this.pivotShowTotalsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.pivotShowColumnTotalsBarItem1.Id = 187;
            this.pivotShowColumnTotalsBarItem1.Name = "pivotShowColumnTotalsBarItem1";
            this.pivotShowRowTotalsBarItem1.Id = 188;
            this.pivotShowRowTotalsBarItem1.Name = "pivotShowRowTotalsBarItem1";
            this.pivotShowGrandTotalsBarItem1.Id = 189;
            this.pivotShowGrandTotalsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotShowColumnGrandTotalsBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pivotShowRowGrandTotalsBarItem1)
            });
            this.pivotShowGrandTotalsBarItem1.Name = "pivotShowGrandTotalsBarItem1";
            this.pivotShowGrandTotalsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.pivotShowColumnGrandTotalsBarItem1.Id = 190;
            this.pivotShowColumnGrandTotalsBarItem1.Name = "pivotShowColumnGrandTotalsBarItem1";
            this.pivotShowRowGrandTotalsBarItem1.Id = 191;
            this.pivotShowRowGrandTotalsBarItem1.Name = "pivotShowRowGrandTotalsBarItem1";
            this.filterElementTypeRibbonPageGroup1.ItemLinks.Add(this.comboBoxStandardTypeBarItem1);
            this.filterElementTypeRibbonPageGroup1.ItemLinks.Add(this.comboBoxCheckedTypeBarItem1);
            this.filterElementTypeRibbonPageGroup1.ItemLinks.Add(this.listBoxCheckedTypeBarItem1);
            this.filterElementTypeRibbonPageGroup1.ItemLinks.Add(this.listBoxRadioTypeBarItem1);
            this.filterElementTypeRibbonPageGroup1.Name = "filterElementTypeRibbonPageGroup1";
            this.filterElementTypeRibbonPageGroup1.Visible = false;
            this.comboBoxStandardTypeBarItem1.Id = 192;
            this.comboBoxStandardTypeBarItem1.Name = "comboBoxStandardTypeBarItem1";
            this.comboBoxCheckedTypeBarItem1.Id = 193;
            this.comboBoxCheckedTypeBarItem1.Name = "comboBoxCheckedTypeBarItem1";
            this.listBoxCheckedTypeBarItem1.Id = 194;
            this.listBoxCheckedTypeBarItem1.Name = "listBoxCheckedTypeBarItem1";
            this.listBoxRadioTypeBarItem1.Id = 195;
            this.listBoxRadioTypeBarItem1.Name = "listBoxRadioTypeBarItem1";
            this.treeViewLayoutRibbonPageGroup1.ItemLinks.Add(this.treeViewAutoExpandBarItem1);
            this.treeViewLayoutRibbonPageGroup1.Name = "treeViewLayoutRibbonPageGroup1";
            this.treeViewLayoutRibbonPageGroup1.Visible = false;
            this.treeViewAutoExpandBarItem1.Id = 196;
            this.treeViewAutoExpandBarItem1.Name = "treeViewAutoExpandBarItem1";
            this.filterElementItemOptionsRibbonPageGroup1.ItemLinks.Add(this.filterElementShowAllValueBarItem1);
            this.filterElementItemOptionsRibbonPageGroup1.Name = "filterElementItemOptionsRibbonPageGroup1";
            this.filterElementItemOptionsRibbonPageGroup1.Visible = false;
            this.filterElementShowAllValueBarItem1.Id = 197;
            this.filterElementShowAllValueBarItem1.Name = "filterElementShowAllValueBarItem1";
            this.mapShapefileRibbonPageGroup1.ItemLinks.Add(this.mapLoadBarItem1);
            this.mapShapefileRibbonPageGroup1.ItemLinks.Add(this.mapImportBarItem1);
            this.mapShapefileRibbonPageGroup1.ItemLinks.Add(this.mapDefaultShapefileBarItem1);
            this.mapShapefileRibbonPageGroup1.Name = "mapShapefileRibbonPageGroup1";
            this.mapLoadBarItem1.Id = 198;
            this.mapLoadBarItem1.Name = "mapLoadBarItem1";
            this.mapImportBarItem1.Id = 199;
            this.mapImportBarItem1.Name = "mapImportBarItem1";
            this.mapDefaultShapefileBarItem1.Id = 200;
            this.mapDefaultShapefileBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.mapWorldCountriesBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapEuropeBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapAsiaBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapNorthAmericaBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapSouthAmericaBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapAfricaBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapUSABarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mapCanadaBarItem1)
            });
            this.mapDefaultShapefileBarItem1.Name = "mapDefaultShapefileBarItem1";
            this.mapDefaultShapefileBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.mapWorldCountriesBarItem1.Id = 201;
            this.mapWorldCountriesBarItem1.Name = "mapWorldCountriesBarItem1";
            this.mapEuropeBarItem1.Id = 202;
            this.mapEuropeBarItem1.Name = "mapEuropeBarItem1";
            this.mapAsiaBarItem1.Id = 203;
            this.mapAsiaBarItem1.Name = "mapAsiaBarItem1";
            this.mapNorthAmericaBarItem1.Id = 204;
            this.mapNorthAmericaBarItem1.Name = "mapNorthAmericaBarItem1";
            this.mapSouthAmericaBarItem1.Id = 205;
            this.mapSouthAmericaBarItem1.Name = "mapSouthAmericaBarItem1";
            this.mapAfricaBarItem1.Id = 206;
            this.mapAfricaBarItem1.Name = "mapAfricaBarItem1";
            this.mapUSABarItem1.Id = 207;
            this.mapUSABarItem1.Name = "mapUSABarItem1";
            this.mapCanadaBarItem1.Id = 208;
            this.mapCanadaBarItem1.Name = "mapCanadaBarItem1";
            this.mapShapefileRibbonPageGroup2.ItemLinks.Add(this.mapLoadBarItem1);
            this.mapShapefileRibbonPageGroup2.ItemLinks.Add(this.mapImportBarItem1);
            this.mapShapefileRibbonPageGroup2.ItemLinks.Add(this.mapDefaultShapefileBarItem1);
            this.mapShapefileRibbonPageGroup2.Name = "mapShapefileRibbonPageGroup2";
            this.mapShapefileRibbonPageGroup3.ItemLinks.Add(this.mapLoadBarItem1);
            this.mapShapefileRibbonPageGroup3.ItemLinks.Add(this.mapImportBarItem1);
            this.mapShapefileRibbonPageGroup3.ItemLinks.Add(this.mapDefaultShapefileBarItem1);
            this.mapShapefileRibbonPageGroup3.Name = "mapShapefileRibbonPageGroup3";
            this.mapShapefileRibbonPageGroup4.ItemLinks.Add(this.mapLoadBarItem1);
            this.mapShapefileRibbonPageGroup4.ItemLinks.Add(this.mapImportBarItem1);
            this.mapShapefileRibbonPageGroup4.ItemLinks.Add(this.mapDefaultShapefileBarItem1);
            this.mapShapefileRibbonPageGroup4.Name = "mapShapefileRibbonPageGroup4";
            this.mapNavigationPageGroup1.ItemLinks.Add(this.mapLockNavigationBarItem1);
            this.mapNavigationPageGroup1.ItemLinks.Add(this.mapFullExtentBarItem1);
            this.mapNavigationPageGroup1.Name = "mapNavigationPageGroup1";
            this.mapLockNavigationBarItem1.Id = 209;
            this.mapLockNavigationBarItem1.Name = "mapLockNavigationBarItem1";
            this.mapFullExtentBarItem1.Id = 210;
            this.mapFullExtentBarItem1.Name = "mapFullExtentBarItem1";
            this.mapNavigationPageGroup2.ItemLinks.Add(this.mapLockNavigationBarItem1);
            this.mapNavigationPageGroup2.ItemLinks.Add(this.mapFullExtentBarItem1);
            this.mapNavigationPageGroup2.Name = "mapNavigationPageGroup2";
            this.mapNavigationPageGroup3.ItemLinks.Add(this.mapLockNavigationBarItem1);
            this.mapNavigationPageGroup3.ItemLinks.Add(this.mapFullExtentBarItem1);
            this.mapNavigationPageGroup3.Name = "mapNavigationPageGroup3";
            this.mapNavigationPageGroup4.ItemLinks.Add(this.mapLockNavigationBarItem1);
            this.mapNavigationPageGroup4.ItemLinks.Add(this.mapFullExtentBarItem1);
            this.mapNavigationPageGroup4.Name = "mapNavigationPageGroup4";
            this.mapShapeLabelsAttributePageGroup1.ItemLinks.Add(this.choroplethMapShapeLabelsAttributeBarItem1);
            this.mapShapeLabelsAttributePageGroup1.Name = "mapShapeLabelsAttributePageGroup1";
            this.choroplethMapShapeLabelsAttributeBarItem1.Id = 211;
            this.choroplethMapShapeLabelsAttributeBarItem1.Name = "choroplethMapShapeLabelsAttributeBarItem1";
            this.mapShapeLabelsAttributePageGroup2.ItemLinks.Add(this.mapShapeTitleAttributeBarItem1);
            this.mapShapeLabelsAttributePageGroup2.Name = "mapShapeLabelsAttributePageGroup2";
            this.mapShapeTitleAttributeBarItem1.Id = 212;
            this.mapShapeTitleAttributeBarItem1.Name = "mapShapeTitleAttributeBarItem1";
            this.mapShapeLabelsAttributePageGroup3.ItemLinks.Add(this.mapShapeTitleAttributeBarItem1);
            this.mapShapeLabelsAttributePageGroup3.Name = "mapShapeLabelsAttributePageGroup3";
            this.mapShapeLabelsAttributePageGroup4.ItemLinks.Add(this.mapShapeTitleAttributeBarItem1);
            this.mapShapeLabelsAttributePageGroup4.Name = "mapShapeLabelsAttributePageGroup4";
            this.mapLegendPositionPageGroup1.ItemLinks.Add(this.mapShowLegendBarItem1);
            this.mapLegendPositionPageGroup1.ItemLinks.Add(this.galleryMapLegendPositionItem1);
            this.mapLegendPositionPageGroup1.Name = "mapLegendPositionPageGroup1";
            this.mapShowLegendBarItem1.Id = 213;
            this.mapShowLegendBarItem1.Name = "mapShowLegendBarItem1";
            this.galleryMapLegendPositionItem1.Gallery.ColumnCount = 3;
            galleryItemGroup19.Caption = "Vertical";
            galleryItemGroup20.Caption = "Horizontal";
            this.galleryMapLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { galleryItemGroup19, galleryItemGroup20 });
            this.galleryMapLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryMapLegendPositionItem1.Gallery.RowCount = 4;
            this.galleryMapLegendPositionItem1.Id = 214;
            this.galleryMapLegendPositionItem1.Name = "galleryMapLegendPositionItem1";
            this.mapLegendPositionPageGroup2.ItemLinks.Add(this.mapShowLegendBarItem1);
            this.mapLegendPositionPageGroup2.ItemLinks.Add(this.galleryMapLegendPositionItem1);
            this.mapLegendPositionPageGroup2.Name = "mapLegendPositionPageGroup2";
            this.mapLegendPositionPageGroup3.ItemLinks.Add(this.mapShowLegendBarItem1);
            this.mapLegendPositionPageGroup3.ItemLinks.Add(this.galleryMapLegendPositionItem1);
            this.mapLegendPositionPageGroup3.Name = "mapLegendPositionPageGroup3";
            this.weightedLegendPageGroup1.ItemLinks.Add(this.changeWeightedLegendTypeBarItem1);
            this.weightedLegendPageGroup1.ItemLinks.Add(this.galleryWeightedLegendPositionItem1);
            this.weightedLegendPageGroup1.Name = "weightedLegendPageGroup1";
            this.changeWeightedLegendTypeBarItem1.Id = 215;
            this.changeWeightedLegendTypeBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.weightedLegendNoneBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.weightedLegendLinearBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.weightedLegendNestedBarItem1)
            });
            this.changeWeightedLegendTypeBarItem1.Name = "changeWeightedLegendTypeBarItem1";
            this.changeWeightedLegendTypeBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.weightedLegendNoneBarItem1.Id = 216;
            this.weightedLegendNoneBarItem1.Name = "weightedLegendNoneBarItem1";
            this.weightedLegendLinearBarItem1.Id = 217;
            this.weightedLegendLinearBarItem1.Name = "weightedLegendLinearBarItem1";
            this.weightedLegendNestedBarItem1.Id = 218;
            this.weightedLegendNestedBarItem1.Name = "weightedLegendNestedBarItem1";
            this.galleryWeightedLegendPositionItem1.Gallery.ColumnCount = 3;
            galleryItemGroup21.Caption = "Posición";
            this.galleryWeightedLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { galleryItemGroup21 });
            this.galleryWeightedLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryWeightedLegendPositionItem1.Gallery.RowCount = 2;
            this.galleryWeightedLegendPositionItem1.Id = 219;
            this.galleryWeightedLegendPositionItem1.Name = "galleryWeightedLegendPositionItem1";
            this.weightedLegendPageGroup2.ItemLinks.Add(this.changeWeightedLegendTypeBarItem1);
            this.weightedLegendPageGroup2.ItemLinks.Add(this.galleryWeightedLegendPositionItem1);
            this.weightedLegendPageGroup2.Name = "weightedLegendPageGroup2";
            this.pieMapOptionsPageGroup1.ItemLinks.Add(this.pieMapIsWeightedBarItem1);
            this.pieMapOptionsPageGroup1.Name = "pieMapOptionsPageGroup1";
            this.pieMapIsWeightedBarItem1.Id = 220;
            this.pieMapIsWeightedBarItem1.Name = "pieMapIsWeightedBarItem1";
            this.coloringOptionsRibbonPageGroup1.ItemLinks.Add(this.useGlobalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup1.ItemLinks.Add(this.useLocalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup1.ItemLinks.Add(this.editActualColorsBarItem1);
            this.coloringOptionsRibbonPageGroup1.Name = "coloringOptionsRibbonPageGroup1";
            this.useGlobalColorsBarItem1.Id = 221;
            this.useGlobalColorsBarItem1.Name = "useGlobalColorsBarItem1";
            this.useLocalColorsBarItem1.Id = 222;
            this.useLocalColorsBarItem1.Name = "useLocalColorsBarItem1";
            this.editActualColorsBarItem1.Id = 223;
            this.editActualColorsBarItem1.Name = "editActualColorsBarItem1";
            this.coloringOptionsRibbonPageGroup2.ItemLinks.Add(this.useGlobalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup2.ItemLinks.Add(this.useLocalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup2.ItemLinks.Add(this.editActualColorsBarItem1);
            this.coloringOptionsRibbonPageGroup2.Name = "coloringOptionsRibbonPageGroup2";
            this.coloringOptionsRibbonPageGroup3.ItemLinks.Add(this.useGlobalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup3.ItemLinks.Add(this.useLocalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup3.ItemLinks.Add(this.editActualColorsBarItem1);
            this.coloringOptionsRibbonPageGroup3.Name = "coloringOptionsRibbonPageGroup3";
            this.coloringOptionsRibbonPageGroup4.ItemLinks.Add(this.useGlobalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup4.ItemLinks.Add(this.useLocalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup4.ItemLinks.Add(this.editActualColorsBarItem1);
            this.coloringOptionsRibbonPageGroup4.Name = "coloringOptionsRibbonPageGroup4";
            this.coloringOptionsRibbonPageGroup5.ItemLinks.Add(this.useGlobalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup5.ItemLinks.Add(this.useLocalColorsBarItem1);
            this.coloringOptionsRibbonPageGroup5.ItemLinks.Add(this.editActualColorsBarItem1);
            this.coloringOptionsRibbonPageGroup5.Name = "coloringOptionsRibbonPageGroup5";
            this.textBoxEditorBarController1.BarItems.Add(this.undoItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.redoItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.fileOpenItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.pasteItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.cutItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.copyItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.pasteSpecialItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFontNameItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFontColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFontBackColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTextCaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.makeTextUpperCaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.makeTextLowerCaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.capitalizeEachWordCaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTextCaseItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.clearFormattingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.increaseIndentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.showLineSpacingFormItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeParagraphBackColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.findItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.replaceItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertTableItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertPictureItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertFloatingPictureItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertSymbolItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changePageColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFirstRowItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleLastRowItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleBandedRowsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleFirstColumnItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleLastColumnItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleBandedColumnsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.galleryChangeTableStyleItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTableBorderLineStyleItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTableBorderLineWeightItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTableBorderColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTableBordersItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsBottomBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsTopBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsLeftBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsRightBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.resetTableCellsAllBordersItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsAllBordersItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsOutsideBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsInsideBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsInsideHorizontalBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsInsideVerticalBorderItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleShowTableGridLinesItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeTableCellsShadingItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.selectTableElementsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.selectTableCellItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.selectTableColumnItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.selectTableRowItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.selectTableItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.showTablePropertiesFormItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.deleteTableElementsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.showDeleteTableCellsFormItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.deleteTableColumnsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.deleteTableRowsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.deleteTableItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertTableRowAboveItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertTableRowBelowItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertTableColumnToLeftItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.insertTableColumnToRightItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.mergeTableCellsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.showSplitTableCellsForm1);
            this.textBoxEditorBarController1.BarItems.Add(this.splitTableItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableAutoFitItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableAutoFitContentsItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableAutoFitWindowItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableFixedColumnWidthItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.showTableOptionsFormItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFloatingObjectFillColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFloatingObjectOutlineColorItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectSquareTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectTightTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectThroughTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectTopAndBottomTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectBehindTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectInFrontOfTextWrapTypeItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.changeFloatingObjectAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectTopLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectTopCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectTopRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectMiddleLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectMiddleCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectMiddleRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectBottomLeftAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectBottomCenterAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.setFloatingObjectBottomRightAlignmentItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectBringForwardSubItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectBringForwardItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectBringToFrontItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectBringInFrontOfTextItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectSendBackwardSubItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectSendBackwardItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectSendToBackItem1);
            this.textBoxEditorBarController1.BarItems.Add(this.floatingObjectSendBehindTextItem1);
            this.textBoxEditorBarController1.Designer = this.dashboardDesigner1;
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.commonRibbonPageGroup1 });
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            this.fileRibbonPage1.Visible = false;
            this.textBoxEditorRibbonPageCategory1.Control = null;
            this.textBoxEditorRibbonPageCategory1.Name = "textBoxEditorRibbonPageCategory1";
            this.textBoxEditorRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[7] { this.fileRibbonPage1, this.homeRibbonPage2, this.insertRibbonPage1, this.pageLayoutRibbonPage1, this.tableDesignRibbonPage1, this.tableLayoutRibbonPage1, this.floatingPictureToolsFormatPage1 });
            this.undoItem1.Enabled = false;
            this.undoItem1.Id = 231;
            this.undoItem1.Name = "undoItem1";
            this.redoItem1.Enabled = false;
            this.redoItem1.Id = 232;
            this.redoItem1.Name = "redoItem1";
            this.fileOpenItem1.Enabled = false;
            this.fileOpenItem1.Id = 233;
            this.fileOpenItem1.Name = "fileOpenItem1";
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.cutItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.copyItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteSpecialItem1);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            this.homeRibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.clipboardRibbonPageGroup1, this.fontRibbonPageGroup1, this.paragraphRibbonPageGroup1, this.stylesRibbonPageGroup1, this.editingRibbonPageGroup1 });
            this.homeRibbonPage2.Name = "homeRibbonPage2";
            reduceOperation.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation.Group = this.stylesRibbonPageGroup1;
            reduceOperation.ItemLinkIndex = 0;
            reduceOperation.ItemLinksCount = 0;
            reduceOperation.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage2.ReduceOperations.Add(reduceOperation);
            this.homeRibbonPage2.Visible = false;
            this.pasteItem1.Enabled = false;
            this.pasteItem1.Id = 234;
            this.pasteItem1.Name = "pasteItem1";
            this.cutItem1.Enabled = false;
            this.cutItem1.Id = 235;
            this.cutItem1.Name = "cutItem1";
            this.copyItem1.Enabled = false;
            this.copyItem1.Id = 236;
            this.copyItem1.Name = "copyItem1";
            this.pasteSpecialItem1.Enabled = false;
            this.pasteSpecialItem1.Id = 237;
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.changeTextCaseItem1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.clearFormattingItem1);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Enabled = false;
            this.changeFontNameItem1.Id = 238;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Enabled = false;
            this.changeFontSizeItem1.Id = 239;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            this.fontSizeIncreaseItem1.Enabled = false;
            this.fontSizeIncreaseItem1.Id = 240;
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            this.fontSizeDecreaseItem1.Enabled = false;
            this.fontSizeDecreaseItem1.Id = 241;
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            this.toggleFontBoldItem1.Enabled = false;
            this.toggleFontBoldItem1.Id = 242;
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            this.toggleFontItalicItem1.Enabled = false;
            this.toggleFontItalicItem1.Id = 243;
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            this.toggleFontUnderlineItem1.Enabled = false;
            this.toggleFontUnderlineItem1.Id = 244;
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            this.toggleFontDoubleUnderlineItem1.Enabled = false;
            this.toggleFontDoubleUnderlineItem1.Id = 245;
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            this.toggleFontStrikeoutItem1.Enabled = false;
            this.toggleFontStrikeoutItem1.Id = 246;
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            this.toggleFontDoubleStrikeoutItem1.Enabled = false;
            this.toggleFontDoubleStrikeoutItem1.Id = 247;
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            this.toggleFontSuperscriptItem1.Enabled = false;
            this.toggleFontSuperscriptItem1.Id = 248;
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            this.toggleFontSubscriptItem1.Enabled = false;
            this.toggleFontSubscriptItem1.Id = 249;
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            this.changeFontColorItem1.Enabled = false;
            this.changeFontColorItem1.Id = 250;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            this.changeFontBackColorItem1.Enabled = false;
            this.changeFontBackColorItem1.Id = 251;
            this.changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            this.changeTextCaseItem1.Enabled = false;
            this.changeTextCaseItem1.Id = 252;
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)
            });
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            this.makeTextUpperCaseItem1.Enabled = false;
            this.makeTextUpperCaseItem1.Id = 253;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            this.makeTextLowerCaseItem1.Enabled = false;
            this.makeTextLowerCaseItem1.Id = 254;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            this.capitalizeEachWordCaseItem1.Enabled = false;
            this.capitalizeEachWordCaseItem1.Id = 255;
            this.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            this.toggleTextCaseItem1.Enabled = false;
            this.toggleTextCaseItem1.Id = 256;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            this.clearFormattingItem1.Enabled = false;
            this.clearFormattingItem1.Id = 257;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            this.barButtonGroup1.Id = 224;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeIncreaseItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeDecreaseItem1);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemRichEditFontSizeEdit1.Control = null;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            this.barButtonGroup2.Id = 225;
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontBoldItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontItalicItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSuperscriptItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSubscriptItem1);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            this.barButtonGroup3.Id = 226;
            this.barButtonGroup3.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup3.ItemLinks.Add(this.changeFontBackColorItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            this.toggleBulletedListItem1.Enabled = false;
            this.toggleBulletedListItem1.Id = 258;
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            this.toggleNumberingListItem1.Enabled = false;
            this.toggleNumberingListItem1.Id = 259;
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            this.toggleMultiLevelListItem1.Enabled = false;
            this.toggleMultiLevelListItem1.Id = 260;
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            this.decreaseIndentItem1.Enabled = false;
            this.decreaseIndentItem1.Id = 261;
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            this.increaseIndentItem1.Enabled = false;
            this.increaseIndentItem1.Id = 262;
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            this.toggleParagraphAlignmentLeftItem1.Enabled = false;
            this.toggleParagraphAlignmentLeftItem1.Id = 263;
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            this.toggleParagraphAlignmentCenterItem1.Enabled = false;
            this.toggleParagraphAlignmentCenterItem1.Id = 264;
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            this.toggleParagraphAlignmentRightItem1.Enabled = false;
            this.toggleParagraphAlignmentRightItem1.Id = 265;
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            this.toggleParagraphAlignmentJustifyItem1.Enabled = false;
            this.toggleParagraphAlignmentJustifyItem1.Id = 266;
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            this.toggleShowWhitespaceItem1.Enabled = false;
            this.toggleShowWhitespaceItem1.Id = 267;
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            this.changeParagraphLineSpacingItem1.Enabled = false;
            this.changeParagraphLineSpacingItem1.Id = 268;
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)
            });
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            this.setSingleParagraphSpacingItem1.Enabled = false;
            this.setSingleParagraphSpacingItem1.Id = 269;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            this.setSesquialteralParagraphSpacingItem1.Enabled = false;
            this.setSesquialteralParagraphSpacingItem1.Id = 270;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            this.setDoubleParagraphSpacingItem1.Enabled = false;
            this.setDoubleParagraphSpacingItem1.Id = 271;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            this.showLineSpacingFormItem1.Enabled = false;
            this.showLineSpacingFormItem1.Id = 272;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            this.addSpacingBeforeParagraphItem1.Enabled = false;
            this.addSpacingBeforeParagraphItem1.Id = 273;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            this.removeSpacingBeforeParagraphItem1.Enabled = false;
            this.removeSpacingBeforeParagraphItem1.Id = 274;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            this.addSpacingAfterParagraphItem1.Enabled = false;
            this.addSpacingAfterParagraphItem1.Id = 275;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            this.removeSpacingAfterParagraphItem1.Enabled = false;
            this.removeSpacingAfterParagraphItem1.Id = 276;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            this.changeParagraphBackColorItem1.Enabled = false;
            this.changeParagraphBackColorItem1.Id = 277;
            this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            this.barButtonGroup4.Id = 227;
            this.barButtonGroup4.ItemLinks.Add(this.toggleBulletedListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleNumberingListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleMultiLevelListItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            this.barButtonGroup5.Id = 228;
            this.barButtonGroup5.ItemLinks.Add(this.decreaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.increaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.toggleShowWhitespaceItem1);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            this.barButtonGroup6.Id = 229;
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentLeftItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentCenterItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentRightItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            this.barButtonGroup7.Id = 230;
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphLineSpacingItem1);
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphBackColorItem1);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            //this.stylesRibbonPageGroup1.Glyph = (System.Drawing.Image)resources.GetObject("stylesRibbonPageGroup1.Glyph");
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            this.galleryChangeStyleItem1.Enabled = false;
            this.galleryChangeStyleItem1.Gallery.ColumnCount = 10;
            this.galleryChangeStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { galleryItemGroup22 });
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Id = 278;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            this.editingRibbonPageGroup1.ItemLinks.Add(this.findItem1);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.replaceItem1);
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            this.findItem1.Enabled = false;
            this.findItem1.Id = 279;
            this.findItem1.Name = "findItem1";
            this.replaceItem1.Enabled = false;
            this.replaceItem1.Id = 280;
            this.replaceItem1.Name = "replaceItem1";
            this.tablesRibbonPageGroup1.AllowTextClipping = false;
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.insertTableItem1);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.tablesRibbonPageGroup1, this.illustrationsRibbonPageGroup1, this.linksRibbonPageGroup1, this.symbolsRibbonPageGroup1 });
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            this.insertRibbonPage1.Visible = false;
            this.insertTableItem1.Enabled = false;
            this.insertTableItem1.Id = 281;
            this.insertTableItem1.Name = "insertTableItem1";
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertPictureItem1);
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertFloatingPictureItem1);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            this.insertPictureItem1.Enabled = false;
            this.insertPictureItem1.Id = 282;
            this.insertPictureItem1.Name = "insertPictureItem1";
            this.insertFloatingPictureItem1.Enabled = false;
            this.insertFloatingPictureItem1.Id = 283;
            this.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertBookmarkItem1);
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertHyperlinkItem1);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            this.insertBookmarkItem1.Enabled = false;
            this.insertBookmarkItem1.Id = 284;
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            this.insertHyperlinkItem1.Enabled = false;
            this.insertHyperlinkItem1.Id = 285;
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            this.symbolsRibbonPageGroup1.AllowTextClipping = false;
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.insertSymbolItem1);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            this.insertSymbolItem1.Enabled = false;
            this.insertSymbolItem1.Id = 286;
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            this.pageBackgroundRibbonPageGroup1.AllowTextClipping = false;
            this.pageBackgroundRibbonPageGroup1.ItemLinks.Add(this.changePageColorItem1);
            this.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1";
            this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[1] { this.pageBackgroundRibbonPageGroup1 });
            this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            this.pageLayoutRibbonPage1.Visible = false;
            this.changePageColorItem1.Enabled = false;
            this.changePageColorItem1.Id = 287;
            this.changePageColorItem1.Name = "changePageColorItem1";
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedRowsItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedColumnsItem1);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            this.tableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.tableStyleOptionsRibbonPageGroup1, this.tableStylesRibbonPageGroup1, this.tableDrawBordersRibbonPageGroup1 });
            this.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1";
            this.tableDesignRibbonPage1.Visible = false;
            this.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstRowItem1.Enabled = false;
            this.toggleFirstRowItem1.Id = 288;
            this.toggleFirstRowItem1.Name = "toggleFirstRowItem1";
            this.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastRowItem1.Enabled = false;
            this.toggleLastRowItem1.Id = 289;
            this.toggleLastRowItem1.Name = "toggleLastRowItem1";
            this.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedRowsItem1.Enabled = false;
            this.toggleBandedRowsItem1.Id = 290;
            this.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1";
            this.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstColumnItem1.Enabled = false;
            this.toggleFirstColumnItem1.Id = 291;
            this.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1";
            this.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastColumnItem1.Enabled = false;
            this.toggleLastColumnItem1.Id = 292;
            this.toggleLastColumnItem1.Name = "toggleLastColumnItem1";
            this.toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedColumnsItem1.Enabled = false;
            this.toggleBandedColumnsItem1.Id = 293;
            this.toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1";
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeTableStyleItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            this.galleryChangeTableStyleItem1.CurrentItem = null;
            this.galleryChangeTableStyleItem1.DeleteItemLink = null;
            this.galleryChangeTableStyleItem1.Enabled = false;
            this.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3;
            this.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { galleryItemGroup23 });
            this.galleryChangeTableStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeTableStyleItem1.Id = 294;
            this.galleryChangeTableStyleItem1.ModifyItemLink = null;
            this.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1";
            this.galleryChangeTableStyleItem1.NewItemLink = null;
            this.galleryChangeTableStyleItem1.PopupGallery = null;
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineStyleItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineWeightItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderColorItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBordersItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableCellsShadingItem1);
            this.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1";
            this.changeTableBorderLineStyleItem1.Edit = this.repositoryItemBorderLineStyle1;
            this.changeTableBorderLineStyleItem1.EditWidth = 130;
            this.changeTableBorderLineStyleItem1.Enabled = false;
            this.changeTableBorderLineStyleItem1.Id = 295;
            this.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1";
            this.changeTableBorderLineWeightItem1.Edit = this.repositoryItemBorderLineWeight1;
            this.changeTableBorderLineWeightItem1.EditWidth = 130;
            this.changeTableBorderLineWeightItem1.Enabled = false;
            this.changeTableBorderLineWeightItem1.Id = 296;
            this.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1";
            this.changeTableBorderColorItem1.Enabled = false;
            this.changeTableBorderColorItem1.Id = 297;
            this.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1";
            this.changeTableBordersItem1.Enabled = false;
            this.changeTableBordersItem1.Id = 298;
            this.changeTableBordersItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[11]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsBottomBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsTopBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsLeftBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsRightBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.resetTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsOutsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideHorizontalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideVerticalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowTableGridLinesItem1)
            });
            this.changeTableBordersItem1.Name = "changeTableBordersItem1";
            this.toggleTableCellsBottomBorderItem1.Enabled = false;
            this.toggleTableCellsBottomBorderItem1.Id = 299;
            this.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1";
            this.toggleTableCellsTopBorderItem1.Enabled = false;
            this.toggleTableCellsTopBorderItem1.Id = 300;
            this.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1";
            this.toggleTableCellsLeftBorderItem1.Enabled = false;
            this.toggleTableCellsLeftBorderItem1.Id = 301;
            this.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1";
            this.toggleTableCellsRightBorderItem1.Enabled = false;
            this.toggleTableCellsRightBorderItem1.Id = 302;
            this.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1";
            this.resetTableCellsAllBordersItem1.Enabled = false;
            this.resetTableCellsAllBordersItem1.Id = 303;
            this.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1";
            this.toggleTableCellsAllBordersItem1.Enabled = false;
            this.toggleTableCellsAllBordersItem1.Id = 304;
            this.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1";
            this.toggleTableCellsOutsideBorderItem1.Enabled = false;
            this.toggleTableCellsOutsideBorderItem1.Id = 305;
            this.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1";
            this.toggleTableCellsInsideBorderItem1.Enabled = false;
            this.toggleTableCellsInsideBorderItem1.Id = 306;
            this.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1";
            this.toggleTableCellsInsideHorizontalBorderItem1.Enabled = false;
            this.toggleTableCellsInsideHorizontalBorderItem1.Id = 307;
            this.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1";
            this.toggleTableCellsInsideVerticalBorderItem1.Enabled = false;
            this.toggleTableCellsInsideVerticalBorderItem1.Id = 308;
            this.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1";
            this.toggleShowTableGridLinesItem1.Enabled = false;
            this.toggleShowTableGridLinesItem1.Id = 309;
            this.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1";
            this.changeTableCellsShadingItem1.Enabled = false;
            this.changeTableCellsShadingItem1.Id = 310;
            this.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1";
            this.repositoryItemBorderLineStyle1.AutoHeight = false;
            this.repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemBorderLineStyle1.Control = null;
            this.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            this.repositoryItemBorderLineWeight1.AutoHeight = false;
            this.repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemBorderLineWeight1.Control = null;
            this.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.selectTableElementsItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.toggleShowTableGridLinesItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.showTablePropertiesFormItem1);
            this.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1";
            this.tableLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.tableTableRibbonPageGroup1, this.tableRowsAndColumnsRibbonPageGroup1, this.tableMergeRibbonPageGroup1, this.tableCellSizeRibbonPageGroup1, this.tableAlignmentRibbonPageGroup1 });
            this.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1";
            this.tableLayoutRibbonPage1.Visible = false;
            this.selectTableElementsItem1.Enabled = false;
            this.selectTableElementsItem1.Id = 311;
            this.selectTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableCellItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableRowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableItem1)
            });
            this.selectTableElementsItem1.Name = "selectTableElementsItem1";
            this.selectTableCellItem1.Enabled = false;
            this.selectTableCellItem1.Id = 312;
            this.selectTableCellItem1.Name = "selectTableCellItem1";
            this.selectTableColumnItem1.Enabled = false;
            this.selectTableColumnItem1.Id = 313;
            this.selectTableColumnItem1.Name = "selectTableColumnItem1";
            this.selectTableRowItem1.Enabled = false;
            this.selectTableRowItem1.Id = 314;
            this.selectTableRowItem1.Name = "selectTableRowItem1";
            this.selectTableItem1.Enabled = false;
            this.selectTableItem1.Id = 315;
            this.selectTableItem1.Name = "selectTableItem1";
            this.showTablePropertiesFormItem1.Enabled = false;
            this.showTablePropertiesFormItem1.Id = 316;
            this.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1";
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.deleteTableElementsItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowAboveItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowBelowItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToLeftItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToRightItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1";
            this.deleteTableElementsItem1.Enabled = false;
            this.deleteTableElementsItem1.Id = 317;
            this.deleteTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.showDeleteTableCellsFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableRowsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableItem1)
            });
            this.deleteTableElementsItem1.Name = "deleteTableElementsItem1";
            this.showDeleteTableCellsFormItem1.Enabled = false;
            this.showDeleteTableCellsFormItem1.Id = 318;
            this.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1";
            this.deleteTableColumnsItem1.Enabled = false;
            this.deleteTableColumnsItem1.Id = 319;
            this.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1";
            this.deleteTableRowsItem1.Enabled = false;
            this.deleteTableRowsItem1.Id = 320;
            this.deleteTableRowsItem1.Name = "deleteTableRowsItem1";
            this.deleteTableItem1.Enabled = false;
            this.deleteTableItem1.Id = 321;
            this.deleteTableItem1.Name = "deleteTableItem1";
            this.insertTableRowAboveItem1.Enabled = false;
            this.insertTableRowAboveItem1.Id = 322;
            this.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1";
            this.insertTableRowBelowItem1.Enabled = false;
            this.insertTableRowBelowItem1.Id = 323;
            this.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1";
            this.insertTableColumnToLeftItem1.Enabled = false;
            this.insertTableColumnToLeftItem1.Id = 324;
            this.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1";
            this.insertTableColumnToRightItem1.Enabled = false;
            this.insertTableColumnToRightItem1.Id = 325;
            this.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1";
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.mergeTableCellsItem1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.showSplitTableCellsForm1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.splitTableItem1);
            this.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1";
            this.mergeTableCellsItem1.Enabled = false;
            this.mergeTableCellsItem1.Id = 326;
            this.mergeTableCellsItem1.Name = "mergeTableCellsItem1";
            this.showSplitTableCellsForm1.Enabled = false;
            this.showSplitTableCellsForm1.Id = 327;
            this.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1";
            this.splitTableItem1.Enabled = false;
            this.splitTableItem1.Id = 328;
            this.splitTableItem1.Name = "splitTableItem1";
            this.tableCellSizeRibbonPageGroup1.AllowTextClipping = false;
            this.tableCellSizeRibbonPageGroup1.ItemLinks.Add(this.toggleTableAutoFitItem1);
            this.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1";
            this.toggleTableAutoFitItem1.Enabled = false;
            this.toggleTableAutoFitItem1.Id = 329;
            this.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitContentsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitWindowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableFixedColumnWidthItem1)
            });
            this.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1";
            this.toggleTableAutoFitContentsItem1.Enabled = false;
            this.toggleTableAutoFitContentsItem1.Id = 330;
            this.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1";
            this.toggleTableAutoFitWindowItem1.Enabled = false;
            this.toggleTableAutoFitWindowItem1.Id = 331;
            this.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1";
            this.toggleTableFixedColumnWidthItem1.Enabled = false;
            this.toggleTableFixedColumnWidthItem1.Id = 332;
            this.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1";
            //this.tableAlignmentRibbonPageGroup1.Glyph = (System.Drawing.Image)resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph");
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.showTableOptionsFormItem1);
            this.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1";
            this.toggleTableCellsTopLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopLeftAlignmentItem1.Id = 333;
            this.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1";
            this.toggleTableCellsMiddleLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleLeftAlignmentItem1.Id = 334;
            this.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1";
            this.toggleTableCellsBottomLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomLeftAlignmentItem1.Id = 335;
            this.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1";
            this.toggleTableCellsTopCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopCenterAlignmentItem1.Id = 336;
            this.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1";
            this.toggleTableCellsMiddleCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleCenterAlignmentItem1.Id = 337;
            this.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1";
            this.toggleTableCellsBottomCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomCenterAlignmentItem1.Id = 338;
            this.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1";
            this.toggleTableCellsTopRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopRightAlignmentItem1.Id = 339;
            this.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1";
            this.toggleTableCellsMiddleRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleRightAlignmentItem1.Id = 340;
            this.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1";
            this.toggleTableCellsBottomRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomRightAlignmentItem1.Id = 341;
            this.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1";
            this.showTableOptionsFormItem1.Enabled = false;
            this.showTableOptionsFormItem1.Id = 342;
            this.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1";
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectFillColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1";
            this.floatingPictureToolsFormatPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.floatingPictureToolsShapeStylesPageGroup1, this.floatingPictureToolsArrangePageGroup1 });
            this.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1";
            this.floatingPictureToolsFormatPage1.Visible = false;
            this.changeFloatingObjectFillColorItem1.Enabled = false;
            this.changeFloatingObjectFillColorItem1.Id = 343;
            this.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1";
            this.changeFloatingObjectOutlineColorItem1.Enabled = false;
            this.changeFloatingObjectOutlineColorItem1.Id = 344;
            this.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1";
            this.changeFloatingObjectOutlineWeightItem1.Edit = this.repositoryItemFloatingObjectOutlineWeight1;
            this.changeFloatingObjectOutlineWeightItem1.Enabled = false;
            this.changeFloatingObjectOutlineWeightItem1.Id = 345;
            this.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1";
            this.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = false;
            this.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.repositoryItemFloatingObjectOutlineWeight1.Control = null;
            this.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1";
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectAlignmentItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectBringForwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectSendBackwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1";
            this.changeFloatingObjectTextWrapTypeItem1.Enabled = false;
            this.changeFloatingObjectTextWrapTypeItem1.Id = 346;
            this.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectSquareTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTightTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectThroughTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopAndBottomTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBehindTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectInFrontOfTextWrapTypeItem1)
            });
            this.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1";
            this.setFloatingObjectSquareTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectSquareTextWrapTypeItem1.Id = 347;
            this.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1";
            this.setFloatingObjectTightTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectTightTextWrapTypeItem1.Id = 348;
            this.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1";
            this.setFloatingObjectThroughTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectThroughTextWrapTypeItem1.Id = 349;
            this.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1";
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 350;
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1";
            this.setFloatingObjectBehindTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectBehindTextWrapTypeItem1.Id = 351;
            this.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1";
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Enabled = false;
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 352;
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1";
            this.changeFloatingObjectAlignmentItem1.Enabled = false;
            this.changeFloatingObjectAlignmentItem1.Id = 353;
            this.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[9]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomRightAlignmentItem1)
            });
            this.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1";
            this.setFloatingObjectTopLeftAlignmentItem1.Enabled = false;
            this.setFloatingObjectTopLeftAlignmentItem1.Id = 354;
            this.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1";
            this.setFloatingObjectTopCenterAlignmentItem1.Enabled = false;
            this.setFloatingObjectTopCenterAlignmentItem1.Id = 355;
            this.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1";
            this.setFloatingObjectTopRightAlignmentItem1.Enabled = false;
            this.setFloatingObjectTopRightAlignmentItem1.Id = 356;
            this.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1";
            this.setFloatingObjectMiddleLeftAlignmentItem1.Enabled = false;
            this.setFloatingObjectMiddleLeftAlignmentItem1.Id = 357;
            this.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1";
            this.setFloatingObjectMiddleCenterAlignmentItem1.Enabled = false;
            this.setFloatingObjectMiddleCenterAlignmentItem1.Id = 358;
            this.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1";
            this.setFloatingObjectMiddleRightAlignmentItem1.Enabled = false;
            this.setFloatingObjectMiddleRightAlignmentItem1.Id = 359;
            this.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1";
            this.setFloatingObjectBottomLeftAlignmentItem1.Enabled = false;
            this.setFloatingObjectBottomLeftAlignmentItem1.Id = 360;
            this.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1";
            this.setFloatingObjectBottomCenterAlignmentItem1.Enabled = false;
            this.setFloatingObjectBottomCenterAlignmentItem1.Id = 361;
            this.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1";
            this.setFloatingObjectBottomRightAlignmentItem1.Enabled = false;
            this.setFloatingObjectBottomRightAlignmentItem1.Id = 362;
            this.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1";
            this.floatingObjectBringForwardSubItem1.Enabled = false;
            this.floatingObjectBringForwardSubItem1.Id = 363;
            this.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringForwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringToFrontItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringInFrontOfTextItem1)
            });
            this.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1";
            this.floatingObjectBringForwardItem1.Enabled = false;
            this.floatingObjectBringForwardItem1.Id = 364;
            this.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1";
            this.floatingObjectBringToFrontItem1.Enabled = false;
            this.floatingObjectBringToFrontItem1.Id = 365;
            this.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1";
            this.floatingObjectBringInFrontOfTextItem1.Enabled = false;
            this.floatingObjectBringInFrontOfTextItem1.Id = 366;
            this.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1";
            this.floatingObjectSendBackwardSubItem1.Enabled = false;
            this.floatingObjectSendBackwardSubItem1.Id = 367;
            this.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
            {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBackwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendToBackItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBehindTextItem1)
            });
            this.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1";
            this.floatingObjectSendBackwardItem1.Enabled = false;
            this.floatingObjectSendBackwardItem1.Id = 368;
            this.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1";
            this.floatingObjectSendToBackItem1.Enabled = false;
            this.floatingObjectSendToBackItem1.Id = 369;
            this.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1";
            this.floatingObjectSendBehindTextItem1.Enabled = false;
            this.floatingObjectSendBehindTextItem1.Id = 370;
            this.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1";
            this.dashboardPopupMenu1.ItemLinks.Add(this.showItemCaptionBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.duplicateItemBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.deleteItemBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.convertDashboardItemTypeBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.removeDataItemsBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.transposeItemBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.editRulesBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.editItemNamesBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.deleteGroupBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.editFilterBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.clearFilterBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.updateDataBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.mapLoadBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.mapImportBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.mapDefaultShapefileBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.mapFullExtentBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.imageLoadBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.imageImportBarItem1);
            this.dashboardPopupMenu1.ItemLinks.Add(this.textBoxEditTextBarItem1, true);
            this.dashboardPopupMenu1.ItemLinks.Add(this.textBoxInsertFieldBarItem1);
            this.dashboardPopupMenu1.Name = "dashboardPopupMenu1";
            this.dashboardPopupMenu1.Ribbon = this.ribbonControl1;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(784, 561);
            base.Controls.Add(this.dashboardDesigner1);
            base.Controls.Add(this.ribbonControl1);
            base.Controls.Add(this.dashboardBackstageViewControl1);
           // base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.Name = "frmDiseñadorEscritorios";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseñador de escritorios";
            base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardBarAndDockingController1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardBackstageViewControl1).EndInit();
            this.dashboardBackstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dashboardBarController1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.textBoxEditorBarController1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemFontEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemRichEditFontSizeEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemBorderLineStyle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemBorderLineWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemFloatingObjectOutlineWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dashboardPopupMenu1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}