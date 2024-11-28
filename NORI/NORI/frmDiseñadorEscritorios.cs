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


namespace NORI
{
    public partial class frmDiseñadorEscritorios : Form
    {
        private IContainer components = null;

        private DashboardDesigner dashboardDesigner1;

        private RibbonControl ribbonControl1;

        private DashboardBackstageViewControl dashboardBackstageViewControl1;

        private DashboardBarAndDockingController dashboardBarAndDockingController1;

        private BackstageViewClientControl backstageViewClientControl1;

        private RecentDashboardsControl recentDashboardsControl1;

        private DashboardBackstageRecentTab dashboardBackstageRecentTab1;

        private DashboardBackstageNewButton dashboardBackstageNewButton1;

        private DashboardBackstageOpenButton dashboardBackstageOpenButton1;

        private DashboardBackstageSaveButton dashboardBackstageSaveButton1;

        private DashboardBackstageSaveAsButton dashboardBackstageSaveAsButton1;

        private FileNewBarItem fileNewBarItem1;

        private FileOpenBarItem fileOpenBarItem1;

        private FileSaveBarItem fileSaveBarItem1;

        private FileSaveAsBarItem fileSaveAsBarItem1;

        private QuickAccessUndoBarItem quickAccessUndoBarItem1;

        private QuickAccessRedoBarItem quickAccessRedoBarItem1;

        private UndoBarItem undoBarItem1;

        private RedoBarItem redoBarItem1;

        private NewDataSourceBarItem newDataSourceBarItem1;

        private EditSqlConnectionBarItem editSqlConnectionBarItem1;

        private EditOlapConnectionBarItem editOlapConnectionBarItem1;

        private EditObjectDataSourceBarItem editObjectDataSourceBarItem1;

        private EditExcelDataSourceBarItem editExcelDataSourceBarItem1;

        private EditEFDataSourceBarItem editEFDataSourceBarItem1;

        private EditExtractOptionsBarItem editExtractOptionsBarItem1;

        private RenameDataSourceBarItem renameDataSourceBarItem1;

        private DeleteDataSourceBarItem deleteDataSourceBarItem1;

        private ServerModeBarItem serverModeBarItem1;

        private UpateDataExtractBarItem upateDataExtractBarItem1;

        private AddCalculatedFieldBarItem addCalculatedFieldBarItem1;

        private AddQueryBarItem addQueryBarItem1;

        private EditQueryBarItem editQueryBarItem1;

        private RenameQueryBarItem renameQueryBarItem1;

        private EditQueryFilterBarItem editQueryFilterBarItem1;

        private DeleteQueryBarItem deleteQueryBarItem1;

        private EditExtractSourceConnectionBarItem editExtractSourceConnectionBarItem1;

        private EditExtractSourceBarItem editExtractSourceBarItem1;

        private EditExtractSourceQueryBarItem editExtractSourceQueryBarItem1;

        private EditDataSourceFilterBarItem editDataSourceFilterBarItem1;

        private ClearDataSourceFilterBarItem clearDataSourceFilterBarItem1;

        private InsertPivotBarItem insertPivotBarItem1;

        private InsertGridBarItem insertGridBarItem1;

        private InsertChartBarItem insertChartBarItem1;

        private InsertScatterChartBarItem insertScatterChartBarItem1;

        private InsertPiesBarItem insertPiesBarItem1;

        private InsertGaugesBarItem insertGaugesBarItem1;

        private InsertCardsBarItem insertCardsBarItem1;

        private InsertChoroplethMapBarItem insertChoroplethMapBarItem1;

        private InsertGeoPointMapBarSubItem insertGeoPointMapBarSubItem1;

        private InsertGeoPointMapBarItem insertGeoPointMapBarItem1;

        private InsertBubbleMapBarItem insertBubbleMapBarItem1;

        private InsertPieMapBarItem insertPieMapBarItem1;

        private InsertRangeFilterBarItem insertRangeFilterBarItem1;

        private InsertFilterElementSubItem insertFilterElementSubItem1;

        private InsertComboBoxBarItem insertComboBoxBarItem1;

        private InsertListBoxBarItem insertListBoxBarItem1;

        private InsertTreeViewBarItem insertTreeViewBarItem1;

        private InsertImagesBarSubItem insertImagesBarSubItem1;

        private InsertImageBarItem insertImageBarItem1;

        private InsertBoundImageBarItem insertBoundImageBarItem1;

        private InsertTextBoxBarItem insertTextBoxBarItem1;

        private InsertGroupBarItem insertGroupBarItem1;

        private DuplicateItemBarItem duplicateItemBarItem1;

        private DeleteItemBarItem deleteItemBarItem1;

        private ConvertDashboardItemTypeBarItem convertDashboardItemTypeBarItem1;

        private ConvertToPivotBarItem convertToPivotBarItem1;

        private ConvertToGridBarItem convertToGridBarItem1;

        private ConvertToChartBarItem convertToChartBarItem1;

        private ConvertToScatterChartBarItem convertToScatterChartBarItem1;

        private ConvertToPieBarItem convertToPieBarItem1;

        private ConvertToGaugeBarItem convertToGaugeBarItem1;

        private ConvertToCardBarItem convertToCardBarItem1;

        private ConvertToChoroplethMapBarItem convertToChoroplethMapBarItem1;

        private ConvertToBoundImageBarItem convertToBoundImageBarItem1;

        private ConvertGeoPointMapBaseBarItem convertGeoPointMapBaseBarItem1;

        private ConvertToGeoPointMapBarItem convertToGeoPointMapBarItem1;

        private ConvertToBubbleMapBarItem convertToBubbleMapBarItem1;

        private ConvertToPieMapBarItem convertToPieMapBarItem1;

        private ConvertToRangeFilterBarItem convertToRangeFilterBarItem1;

        private ConvertToFilterElementsBaseBarItem convertToFilterElementsBaseBarItem1;

        private ConvertToComboBoxBarItem convertToComboBoxBarItem1;

        private ConvertToListBoxBarItem convertToListBoxBarItem1;

        private ConvertToTreeViewBarItem convertToTreeViewBarItem1;

        private RemoveDataItemsBarItem removeDataItemsBarItem1;

        private TransposeItemBarItem transposeItemBarItem1;

        private EditRulesBarItem editRulesBarItem1;

        private DeleteGroupBarItem deleteGroupBarItem1;

        private DashboardTitleBarItem dashboardTitleBarItem1;

        private SetCurrencyCultureBarItem setCurrencyCultureBarItem1;

        private DashboardColorSchemeBarItem dashboardColorSchemeBarItem1;

        private DashboardParametersBarItem dashboardParametersBarItem1;

        private DashboardAutomaticUpdatesBarItem dashboardAutomaticUpdatesBarItem1;

        private UpdateDataBarItem updateDataBarItem1;

        private DashboardSkinsBarItem dashboardSkinsBarItem1;

        private EditFilterBarItem editFilterBarItem1;

        private ClearFilterBarItem clearFilterBarItem1;

        private MasterFilterBarItem masterFilterBarItem1;

        private MultipleValuesMasterFilterBarItem multipleValuesMasterFilterBarItem1;

        private DrillDownBarItem drillDownBarItem1;

        private GroupMasterFilterBarItem groupMasterFilterBarItem1;

        private GroupIgnoreMasterFilterBarItem groupIgnoreMasterFilterBarItem1;

        private IgnoreMasterFiltersBarItem ignoreMasterFiltersBarItem1;

        private CrossDataSourceFilteringBarItem crossDataSourceFilteringBarItem1;

        private ChartTargetDimensionsArgumentsBarItem chartTargetDimensionsArgumentsBarItem1;

        private ChartTargetDimensionsSeriesBarItem chartTargetDimensionsSeriesBarItem1;

        private ChartTargetDimensionsPointsBarItem chartTargetDimensionsPointsBarItem1;

        private PieTargetDimensionsArgumentsBarItem pieTargetDimensionsArgumentsBarItem1;

        private PieTargetDimensionsSeriesBarItem pieTargetDimensionsSeriesBarItem1;

        private PieTargetDimensionsPointsBarItem pieTargetDimensionsPointsBarItem1;

        private GeoPointMapClusterizationBarItem geoPointMapClusterizationBarItem1;

        private ShowItemCaptionBarItem showItemCaptionBarItem1;

        private EditItemNamesBarItem editItemNamesBarItem1;

        private ContentAutoArrangeBarItem contentAutoArrangeBarItem1;

        private ContentArrangeInColumnsBarItem contentArrangeInColumnsBarItem1;

        private ContentArrangeInRowsBarItem contentArrangeInRowsBarItem1;

        private ContentArrangementCountBarItem contentArrangementCountBarItem1;

        private RepositoryItemSpinEdit repositoryItemSpinEdit1;

        private GridHorizontalLinesBarItem gridHorizontalLinesBarItem1;

        private GridVerticalLinesBarItem gridVerticalLinesBarItem1;

        private GridBandedRowsBarItem gridBandedRowsBarItem1;

        private GridMergeCellsBarItem gridMergeCellsBarItem1;

        private GridColumnHeadersBarItem gridColumnHeadersBarItem1;

        private GridWordWrapBarItem gridWordWrapBarItem1;

        private GridAutoFitToContentsColumnWidthModeBarItem gridAutoFitToContentsColumnWidthModeBarItem1;

        private GridAutoFitToGridColumnWidthModeBarItem gridAutoFitToGridColumnWidthModeBarItem1;

        private ManualGridColumnWidthModeBarItem manualGridColumnWidthModeBarItem1;

        private ChartRotateBarItem chartRotateBarItem1;

        private ChartXAxisSettingsBarItem chartXAxisSettingsBarItem1;

        private ChartYAxisSettingsBarItem chartYAxisSettingsBarItem1;

        private ScatterChartRotateBarItem scatterChartRotateBarItem1;

        private ScatterChartXAxisSettingsBarItem scatterChartXAxisSettingsBarItem1;

        private ScatterChartYAxisSettingsBarItem scatterChartYAxisSettingsBarItem1;

        private ScatterChartPointLabelOptionsBarItem scatterChartPointLabelOptionsBarItem1;

        private ChartShowLegendBarItem chartShowLegendBarItem1;

        private GalleryChartLegendPositionItem galleryChartLegendPositionItem1;

        private ScatterChartShowLegendBarItem scatterChartShowLegendBarItem1;

        private GalleryScatterChartLegendPositionItem galleryScatterChartLegendPositionItem1;

        private GalleryChartSeriesTypeItem galleryChartSeriesTypeItem1;

        private PieLabelsDataLabelsBarItem pieLabelsDataLabelsBarItem1;

        private PieLabelsDataLabelsNoneBarItem pieLabelsDataLabelsNoneBarItem1;

        private PieLabelsDataLabelArgumentBarItem pieLabelsDataLabelArgumentBarItem1;

        private PieLabelsDataLabelsValueBarItem pieLabelsDataLabelsValueBarItem1;

        private PieLabelsDataLabelsArgumentAndValueBarItem pieLabelsDataLabelsArgumentAndValueBarItem1;

        private PieLabelsDataLabelsPercentBarItem pieLabelsDataLabelsPercentBarItem1;

        private PieLabelsDataLabelsValueAndPercentBarItem pieLabelsDataLabelsValueAndPercentBarItem1;

        private PieLabelsDataLabelsArgumentAndPercentBarItem pieLabelsDataLabelsArgumentAndPercentBarItem1;

        private PieLabelsDataLabelsArgumentValueAndPercentBarItem pieLabelsDataLabelsArgumentValueAndPercentBarItem1;

        private PieTooltipsBarItem pieTooltipsBarItem1;

        private PieLabelsTooltipsNoneBarItem pieLabelsTooltipsNoneBarItem1;

        private PieLabelsTooltipsArgumentBarItem pieLabelsTooltipsArgumentBarItem1;

        private PieLabelsTooltipsValueBarItem pieLabelsTooltipsValueBarItem1;

        private PieLabelsTooltipsArgumentAndValueBarItem pieLabelsTooltipsArgumentAndValueBarItem1;

        private PieLabelsTooltipsPercentBarItem pieLabelsTooltipsPercentBarItem1;

        private PieLabelsTooltipsValueAndPercentBarItem pieLabelsTooltipsValueAndPercentBarItem1;

        private PieLabelsTooltipsArgumentAndPercentBarItem pieLabelsTooltipsArgumentAndPercentBarItem1;

        private PieLabelsTooltipsArgumentValueAndPercentBarItem pieLabelsTooltipsArgumentValueAndPercentBarItem1;

        private PieStylePieBarItem pieStylePieBarItem1;

        private PieStyleDonutBarItem pieStyleDonutBarItem1;

        private PieShowCaptionsBarItem pieShowCaptionsBarItem1;

        private GaugeStyleFullCircularBarItem gaugeStyleFullCircularBarItem1;

        private GaugeStyleHalfCircularBarItem gaugeStyleHalfCircularBarItem1;

        private GaugeStyleLeftQuarterCircularBarItem gaugeStyleLeftQuarterCircularBarItem1;

        private GaugeStyleRightQuarterCircularBarItem gaugeStyleRightQuarterCircularBarItem1;

        private GaugeStyleThreeForthCircularBarItem gaugeStyleThreeForthCircularBarItem1;

        private GaugeStyleLinearHorizontalBarItem gaugeStyleLinearHorizontalBarItem1;

        private GaugeStyleLinearVerticalBarItem gaugeStyleLinearVerticalBarItem1;

        private GaugeShowCaptionsBarItem gaugeShowCaptionsBarItem1;

        private ImageLoadBarItem imageLoadBarItem1;

        private ImageImportBarItem imageImportBarItem1;

        private ImageSizeModeClipBarItem imageSizeModeClipBarItem1;

        private ImageSizeModeStretchBarItem imageSizeModeStretchBarItem1;

        private ImageSizeModeSqueezeBarItem imageSizeModeSqueezeBarItem1;

        private ImageSizeModeZoomBarItem imageSizeModeZoomBarItem1;

        private ImageAlignmentTopLeftBarItem imageAlignmentTopLeftBarItem1;

        private ImageAlignmentCenterLeftBarItem imageAlignmentCenterLeftBarItem1;

        private ImageAlignmentBottomLeftBarItem imageAlignmentBottomLeftBarItem1;

        private ImageAlignmentTopCenterBarItem imageAlignmentTopCenterBarItem1;

        private ImageAlignmentCenterCenterBarItem imageAlignmentCenterCenterBarItem1;

        private ImageAlignmentBottomCenterBarItem imageAlignmentBottomCenterBarItem1;

        private ImageAlignmentTopRightBarItem imageAlignmentTopRightBarItem1;

        private ImageAlignmentCenterRightBarItem imageAlignmentCenterRightBarItem1;

        private ImageAlignmentBottomRightBarItem imageAlignmentBottomRightBarItem1;

        private TextBoxEditTextBarItem textBoxEditTextBarItem1;

        private TextBoxInsertFieldBarItem textBoxInsertFieldBarItem1;

        private RangeFilterLineSeriesTypeBarItem rangeFilterLineSeriesTypeBarItem1;

        private RangeFilterStackedLineSeriesTypeBarItem rangeFilterStackedLineSeriesTypeBarItem1;

        private RangeFilterFullStackedLineSeriesTypeBarItem rangeFilterFullStackedLineSeriesTypeBarItem1;

        private RangeFilterAreaSeriesTypeBarItem rangeFilterAreaSeriesTypeBarItem1;

        private RangeFilterStackedAreaSeriesTypeBarItem rangeFilterStackedAreaSeriesTypeBarItem1;

        private RangeFilterFullStackedAreaSeriesTypeBarItem rangeFilterFullStackedAreaSeriesTypeBarItem1;

        private RangeFilterBarSeriesTypeBarItem rangeFilterBarSeriesTypeBarItem1;

        private RangeFilterStackedBarSeriesTypeBarItem rangeFilterStackedBarSeriesTypeBarItem1;

        private RangeFilterFullStackedBarSeriesTypeBarItem rangeFilterFullStackedBarSeriesTypeBarItem1;

        private PivotInitialStateBarItem pivotInitialStateBarItem1;

        private PivotAutoExpandColumnBarItem pivotAutoExpandColumnBarItem1;

        private PivotAutoExpandRowBarItem pivotAutoExpandRowBarItem1;

        private PivotShowTotalsBarItem pivotShowTotalsBarItem1;

        private PivotShowColumnTotalsBarItem pivotShowColumnTotalsBarItem1;

        private PivotShowRowTotalsBarItem pivotShowRowTotalsBarItem1;

        private PivotShowGrandTotalsBarItem pivotShowGrandTotalsBarItem1;

        private PivotShowColumnGrandTotalsBarItem pivotShowColumnGrandTotalsBarItem1;

        private PivotShowRowGrandTotalsBarItem pivotShowRowGrandTotalsBarItem1;

        private ComboBoxStandardTypeBarItem comboBoxStandardTypeBarItem1;

        private ComboBoxCheckedTypeBarItem comboBoxCheckedTypeBarItem1;

        private ListBoxCheckedTypeBarItem listBoxCheckedTypeBarItem1;

        private ListBoxRadioTypeBarItem listBoxRadioTypeBarItem1;

        private TreeViewAutoExpandBarItem treeViewAutoExpandBarItem1;

        private FilterElementShowAllValueBarItem filterElementShowAllValueBarItem1;

        private MapLoadBarItem mapLoadBarItem1;

        private MapImportBarItem mapImportBarItem1;

        private MapDefaultShapefileBarItem mapDefaultShapefileBarItem1;

        private MapWorldCountriesBarItem mapWorldCountriesBarItem1;

        private MapEuropeBarItem mapEuropeBarItem1;

        private MapAsiaBarItem mapAsiaBarItem1;

        private MapNorthAmericaBarItem mapNorthAmericaBarItem1;

        private MapSouthAmericaBarItem mapSouthAmericaBarItem1;

        private MapAfricaBarItem mapAfricaBarItem1;

        private MapUSABarItem mapUSABarItem1;

        private MapCanadaBarItem mapCanadaBarItem1;

        private MapLockNavigationBarItem mapLockNavigationBarItem1;

        private MapFullExtentBarItem mapFullExtentBarItem1;

        private ChoroplethMapShapeLabelsAttributeBarItem choroplethMapShapeLabelsAttributeBarItem1;

        private MapShapeTitleAttributeBarItem mapShapeTitleAttributeBarItem1;

        private MapShowLegendBarItem mapShowLegendBarItem1;

        private GalleryMapLegendPositionItem galleryMapLegendPositionItem1;

        private ChangeWeightedLegendTypeBarItem changeWeightedLegendTypeBarItem1;

        private WeightedLegendNoneBarItem weightedLegendNoneBarItem1;

        private WeightedLegendLinearBarItem weightedLegendLinearBarItem1;

        private WeightedLegendNestedBarItem weightedLegendNestedBarItem1;

        private GalleryWeightedLegendPositionItem galleryWeightedLegendPositionItem1;

        private PieMapIsWeightedBarItem pieMapIsWeightedBarItem1;

        private UseGlobalColorsBarItem useGlobalColorsBarItem1;

        private UseLocalColorsBarItem useLocalColorsBarItem1;

        private EditActualColorsBarItem editActualColorsBarItem1;

        private UndoItem undoItem1;

        private RedoItem redoItem1;

        private FileOpenItem fileOpenItem1;

        private PasteItem pasteItem1;

        private CutItem cutItem1;

        private CopyItem copyItem1;

        private PasteSpecialItem pasteSpecialItem1;

        private BarButtonGroup barButtonGroup1;

        private ChangeFontNameItem changeFontNameItem1;

        private RepositoryItemFontEdit repositoryItemFontEdit1;

        private ChangeFontSizeItem changeFontSizeItem1;

        private RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;

        private FontSizeIncreaseItem fontSizeIncreaseItem1;

        private FontSizeDecreaseItem fontSizeDecreaseItem1;

        private BarButtonGroup barButtonGroup2;

        private ToggleFontBoldItem toggleFontBoldItem1;

        private ToggleFontItalicItem toggleFontItalicItem1;

        private ToggleFontUnderlineItem toggleFontUnderlineItem1;

        private ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;

        private ToggleFontStrikeoutItem toggleFontStrikeoutItem1;

        private ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;

        private ToggleFontSuperscriptItem toggleFontSuperscriptItem1;

        private ToggleFontSubscriptItem toggleFontSubscriptItem1;

        private BarButtonGroup barButtonGroup3;

        private ChangeFontColorItem changeFontColorItem1;

        private ChangeFontBackColorItem changeFontBackColorItem1;

        private ChangeTextCaseItem changeTextCaseItem1;

        private MakeTextUpperCaseItem makeTextUpperCaseItem1;

        private MakeTextLowerCaseItem makeTextLowerCaseItem1;

        private CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;

        private ToggleTextCaseItem toggleTextCaseItem1;

        private ClearFormattingItem clearFormattingItem1;

        private BarButtonGroup barButtonGroup4;

        private ToggleBulletedListItem toggleBulletedListItem1;

        private ToggleNumberingListItem toggleNumberingListItem1;

        private ToggleMultiLevelListItem toggleMultiLevelListItem1;

        private BarButtonGroup barButtonGroup5;

        private DecreaseIndentItem decreaseIndentItem1;

        private IncreaseIndentItem increaseIndentItem1;

        private ToggleShowWhitespaceItem toggleShowWhitespaceItem1;

        private BarButtonGroup barButtonGroup6;

        private ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;

        private ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;

        private ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;

        private ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;

        private BarButtonGroup barButtonGroup7;

        private ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;

        private SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;

        private SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;

        private SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;

        private ShowLineSpacingFormItem showLineSpacingFormItem1;

        private AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;

        private RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;

        private AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;

        private RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;

        private ChangeParagraphBackColorItem changeParagraphBackColorItem1;

        private GalleryChangeStyleItem galleryChangeStyleItem1;

        private FindItem findItem1;

        private ReplaceItem replaceItem1;

        private InsertTableItem insertTableItem1;

        private InsertPictureItem insertPictureItem1;

        private InsertFloatingPictureItem insertFloatingPictureItem1;

        private InsertBookmarkItem insertBookmarkItem1;

        private InsertHyperlinkItem insertHyperlinkItem1;

        private InsertSymbolItem insertSymbolItem1;

        private ChangePageColorItem changePageColorItem1;

        private ToggleFirstRowItem toggleFirstRowItem1;

        private ToggleLastRowItem toggleLastRowItem1;

        private ToggleBandedRowsItem toggleBandedRowsItem1;

        private ToggleFirstColumnItem toggleFirstColumnItem1;

        private ToggleLastColumnItem toggleLastColumnItem1;

        private ToggleBandedColumnsItem toggleBandedColumnsItem1;

        private GalleryChangeTableStyleItem galleryChangeTableStyleItem1;

        private ChangeTableBorderLineStyleItem changeTableBorderLineStyleItem1;

        private RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;

        private ChangeTableBorderLineWeightItem changeTableBorderLineWeightItem1;

        private RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;

        private ChangeTableBorderColorItem changeTableBorderColorItem1;

        private ChangeTableBordersItem changeTableBordersItem1;

        private ToggleTableCellsBottomBorderItem toggleTableCellsBottomBorderItem1;

        private ToggleTableCellsTopBorderItem toggleTableCellsTopBorderItem1;

        private ToggleTableCellsLeftBorderItem toggleTableCellsLeftBorderItem1;

        private ToggleTableCellsRightBorderItem toggleTableCellsRightBorderItem1;

        private ResetTableCellsAllBordersItem resetTableCellsAllBordersItem1;

        private ToggleTableCellsAllBordersItem toggleTableCellsAllBordersItem1;

        private ToggleTableCellsOutsideBorderItem toggleTableCellsOutsideBorderItem1;

        private ToggleTableCellsInsideBorderItem toggleTableCellsInsideBorderItem1;

        private ToggleTableCellsInsideHorizontalBorderItem toggleTableCellsInsideHorizontalBorderItem1;

        private ToggleTableCellsInsideVerticalBorderItem toggleTableCellsInsideVerticalBorderItem1;

        private ToggleShowTableGridLinesItem toggleShowTableGridLinesItem1;

        private ChangeTableCellsShadingItem changeTableCellsShadingItem1;

        private SelectTableElementsItem selectTableElementsItem1;

        private SelectTableCellItem selectTableCellItem1;

        private SelectTableColumnItem selectTableColumnItem1;

        private SelectTableRowItem selectTableRowItem1;

        private SelectTableItem selectTableItem1;

        private ShowTablePropertiesFormItem showTablePropertiesFormItem1;

        private DeleteTableElementsItem deleteTableElementsItem1;

        private ShowDeleteTableCellsFormItem showDeleteTableCellsFormItem1;

        private DeleteTableColumnsItem deleteTableColumnsItem1;

        private DeleteTableRowsItem deleteTableRowsItem1;

        private DeleteTableItem deleteTableItem1;

        private InsertTableRowAboveItem insertTableRowAboveItem1;

        private InsertTableRowBelowItem insertTableRowBelowItem1;

        private InsertTableColumnToLeftItem insertTableColumnToLeftItem1;

        private InsertTableColumnToRightItem insertTableColumnToRightItem1;

        private MergeTableCellsItem mergeTableCellsItem1;

        private ShowSplitTableCellsForm showSplitTableCellsForm1;

        private SplitTableItem splitTableItem1;

        private ToggleTableAutoFitItem toggleTableAutoFitItem1;

        private ToggleTableAutoFitContentsItem toggleTableAutoFitContentsItem1;

        private ToggleTableAutoFitWindowItem toggleTableAutoFitWindowItem1;

        private ToggleTableFixedColumnWidthItem toggleTableFixedColumnWidthItem1;

        private ToggleTableCellsTopLeftAlignmentItem toggleTableCellsTopLeftAlignmentItem1;

        private ToggleTableCellsMiddleLeftAlignmentItem toggleTableCellsMiddleLeftAlignmentItem1;

        private ToggleTableCellsBottomLeftAlignmentItem toggleTableCellsBottomLeftAlignmentItem1;

        private ToggleTableCellsTopCenterAlignmentItem toggleTableCellsTopCenterAlignmentItem1;

        private ToggleTableCellsMiddleCenterAlignmentItem toggleTableCellsMiddleCenterAlignmentItem1;

        private ToggleTableCellsBottomCenterAlignmentItem toggleTableCellsBottomCenterAlignmentItem1;

        private ToggleTableCellsTopRightAlignmentItem toggleTableCellsTopRightAlignmentItem1;

        private ToggleTableCellsMiddleRightAlignmentItem toggleTableCellsMiddleRightAlignmentItem1;

        private ToggleTableCellsBottomRightAlignmentItem toggleTableCellsBottomRightAlignmentItem1;

        private ShowTableOptionsFormItem showTableOptionsFormItem1;

        private ChangeFloatingObjectFillColorItem changeFloatingObjectFillColorItem1;

        private ChangeFloatingObjectOutlineColorItem changeFloatingObjectOutlineColorItem1;

        private ChangeFloatingObjectOutlineWeightItem changeFloatingObjectOutlineWeightItem1;

        private RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight1;

        private ChangeFloatingObjectTextWrapTypeItem changeFloatingObjectTextWrapTypeItem1;

        private SetFloatingObjectSquareTextWrapTypeItem setFloatingObjectSquareTextWrapTypeItem1;

        private SetFloatingObjectTightTextWrapTypeItem setFloatingObjectTightTextWrapTypeItem1;

        private SetFloatingObjectThroughTextWrapTypeItem setFloatingObjectThroughTextWrapTypeItem1;

        private SetFloatingObjectTopAndBottomTextWrapTypeItem setFloatingObjectTopAndBottomTextWrapTypeItem1;

        private SetFloatingObjectBehindTextWrapTypeItem setFloatingObjectBehindTextWrapTypeItem1;

        private SetFloatingObjectInFrontOfTextWrapTypeItem setFloatingObjectInFrontOfTextWrapTypeItem1;

        private ChangeFloatingObjectAlignmentItem changeFloatingObjectAlignmentItem1;

        private SetFloatingObjectTopLeftAlignmentItem setFloatingObjectTopLeftAlignmentItem1;

        private SetFloatingObjectTopCenterAlignmentItem setFloatingObjectTopCenterAlignmentItem1;

        private SetFloatingObjectTopRightAlignmentItem setFloatingObjectTopRightAlignmentItem1;

        private SetFloatingObjectMiddleLeftAlignmentItem setFloatingObjectMiddleLeftAlignmentItem1;

        private SetFloatingObjectMiddleCenterAlignmentItem setFloatingObjectMiddleCenterAlignmentItem1;

        private SetFloatingObjectMiddleRightAlignmentItem setFloatingObjectMiddleRightAlignmentItem1;

        private SetFloatingObjectBottomLeftAlignmentItem setFloatingObjectBottomLeftAlignmentItem1;

        private SetFloatingObjectBottomCenterAlignmentItem setFloatingObjectBottomCenterAlignmentItem1;

        private SetFloatingObjectBottomRightAlignmentItem setFloatingObjectBottomRightAlignmentItem1;

        private FloatingObjectBringForwardSubItem floatingObjectBringForwardSubItem1;

        private FloatingObjectBringForwardItem floatingObjectBringForwardItem1;

        private FloatingObjectBringToFrontItem floatingObjectBringToFrontItem1;

        private FloatingObjectBringInFrontOfTextItem floatingObjectBringInFrontOfTextItem1;

        private FloatingObjectSendBackwardSubItem floatingObjectSendBackwardSubItem1;

        private FloatingObjectSendBackwardItem floatingObjectSendBackwardItem1;

        private FloatingObjectSendToBackItem floatingObjectSendToBackItem1;

        private FloatingObjectSendBehindTextItem floatingObjectSendBehindTextItem1;

        private PivotToolsRibbonPageCategory pivotToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage1;

        private FilteringRibbonPageGroup filteringRibbonPageGroup1;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup1;

        private PivotLayoutRibbonPageGroup pivotLayoutRibbonPageGroup1;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage11;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup11;

        private GridToolsRibbonPageCategory gridToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage2;

        private FilteringRibbonPageGroup filteringRibbonPageGroup2;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup1;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup2;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage1;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup1;

        private GridStyleRibbonPageGroup gridStyleRibbonPageGroup1;

        private GridLayoutRibbonPageGroup gridLayoutRibbonPageGroup1;

        private GridColumnWidthModeRibbonPageGroup gridColumnWidthModeRibbonPageGroup1;

        private ChartToolsRibbonPageCategory chartToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage3;

        private FilteringRibbonPageGroup filteringRibbonPageGroup3;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup2;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup3;

        private TargetDimensionsRibbonPageGroup targetDimensionsRibbonPageGroup1;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage2;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup2;

        private ChartLayoutPageGroup chartLayoutPageGroup1;

        private ChartLegendPositionPageGroup chartLegendPositionPageGroup1;

        private ChartStylePageGroup chartStylePageGroup1;

        private ColoringOptionsRibbonPageGroup coloringOptionsRibbonPageGroup1;

        private ScatterChartToolsRibbonPageCategory scatterChartToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage4;

        private FilteringRibbonPageGroup filteringRibbonPageGroup4;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup3;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup4;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage3;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup3;

        private ScatterChartLayoutPageGroup scatterChartLayoutPageGroup1;

        private ScatterChartPointLabelPageGroup scatterChartPointLabelPageGroup1;

        private ScatterChartLegendPositionPageGroup scatterChartLegendPositionPageGroup1;

        private ColoringOptionsRibbonPageGroup coloringOptionsRibbonPageGroup2;

        private PiesToolsRibbonPageCategory piesToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage5;

        private FilteringRibbonPageGroup filteringRibbonPageGroup5;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup4;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup5;

        private TargetDimensionsRibbonPageGroup targetDimensionsRibbonPageGroup2;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage4;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup4;

        private ContentArrangementRibbonPageGroup contentArrangementRibbonPageGroup1;

        private PieLabelsRibbonPageGroup pieLabelsRibbonPageGroup1;

        private PieStyleRibbonPageGroup pieStyleRibbonPageGroup1;

        private ColoringOptionsRibbonPageGroup coloringOptionsRibbonPageGroup3;

        private GaugesToolsRibbonPageCategory gaugesToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage6;

        private FilteringRibbonPageGroup filteringRibbonPageGroup6;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup5;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup6;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage5;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup5;

        private ContentArrangementRibbonPageGroup contentArrangementRibbonPageGroup2;

        private GaugeStyleRibbonPageGroup gaugeStyleRibbonPageGroup1;

        private GaugesLabelsRibbonPageGroup gaugesLabelsRibbonPageGroup1;

        private CardsToolsRibbonPageCategory cardsToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage7;

        private FilteringRibbonPageGroup filteringRibbonPageGroup7;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup6;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup7;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage6;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup6;

        private ContentArrangementRibbonPageGroup contentArrangementRibbonPageGroup3;

        private RangeFilterToolsRibbonPageCategory rangeFilterToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage8;

        private FilteringRibbonPageGroup filteringRibbonPageGroup8;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup8;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage10;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup10;

        private RangeFilterSeriesTypeRibbonPageGroup rangeFilterSeriesTypeRibbonPageGroup1;

        private ColoringOptionsRibbonPageGroup coloringOptionsRibbonPageGroup4;

        private ChoroplethMapToolsRibbonPageCategory choroplethMapToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage9;

        private FilteringRibbonPageGroup filteringRibbonPageGroup9;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup7;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup9;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage12;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup12;

        private MapShapefileRibbonPageGroup mapShapefileRibbonPageGroup1;

        private MapNavigationPageGroup mapNavigationPageGroup1;

        private MapShapeLabelsAttributePageGroup mapShapeLabelsAttributePageGroup1;

        private MapLegendPositionPageGroup mapLegendPositionPageGroup1;

        private GeoPointMapToolsRibbonPageCategory geoPointMapToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage10;

        private FilteringRibbonPageGroup filteringRibbonPageGroup10;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup8;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup10;

        private GeoPointMapClusterizationRibbonPageGroup geoPointMapClusterizationRibbonPageGroup1;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage13;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup13;

        private MapShapefileRibbonPageGroup mapShapefileRibbonPageGroup2;

        private MapNavigationPageGroup mapNavigationPageGroup2;

        private MapShapeLabelsAttributePageGroup mapShapeLabelsAttributePageGroup2;

        private BubbleMapToolsRibbonPageCategory bubbleMapToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage11;

        private FilteringRibbonPageGroup filteringRibbonPageGroup11;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup9;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup11;

        private GeoPointMapClusterizationRibbonPageGroup geoPointMapClusterizationRibbonPageGroup2;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage14;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup14;

        private MapShapefileRibbonPageGroup mapShapefileRibbonPageGroup3;

        private MapNavigationPageGroup mapNavigationPageGroup3;

        private MapShapeLabelsAttributePageGroup mapShapeLabelsAttributePageGroup3;

        private MapLegendPositionPageGroup mapLegendPositionPageGroup2;

        private WeightedLegendPageGroup weightedLegendPageGroup1;

        private PieMapToolsRibbonPageCategory pieMapToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage12;

        private FilteringRibbonPageGroup filteringRibbonPageGroup12;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup10;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup12;

        private GeoPointMapClusterizationRibbonPageGroup geoPointMapClusterizationRibbonPageGroup3;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage15;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup15;

        private MapShapefileRibbonPageGroup mapShapefileRibbonPageGroup4;

        private MapNavigationPageGroup mapNavigationPageGroup4;

        private MapShapeLabelsAttributePageGroup mapShapeLabelsAttributePageGroup4;

        private MapLegendPositionPageGroup mapLegendPositionPageGroup3;

        private WeightedLegendPageGroup weightedLegendPageGroup2;

        private PieMapOptionsPageGroup pieMapOptionsPageGroup1;

        private ColoringOptionsRibbonPageGroup coloringOptionsRibbonPageGroup5;

        private FilterElementToolsRibbonPageCategory filterElementToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage13;

        private FilteringRibbonPageGroup filteringRibbonPageGroup13;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup13;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage17;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup17;

        private FilterElementTypeRibbonPageGroup filterElementTypeRibbonPageGroup1;

        private TreeViewLayoutRibbonPageGroup treeViewLayoutRibbonPageGroup1;

        private FilterElementItemOptionsRibbonPageGroup filterElementItemOptionsRibbonPageGroup1;

        private BoundImageToolsRibbonPageCategory boundImageToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage14;

        private FilteringRibbonPageGroup filteringRibbonPageGroup14;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup14;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage8;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup8;

        private ImageSizeModeRibbonPageGroup imageSizeModeRibbonPageGroup2;

        private ImageAlignmentRibbonPageGroup imageAlignmentRibbonPageGroup2;

        private TextBoxToolsRibbonPageCategory textBoxToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage15;

        private FilteringRibbonPageGroup filteringRibbonPageGroup15;

        private InteractivitySettingsRibbonPageGroup interactivitySettingsRibbonPageGroup15;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage9;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup9;

        private TextBoxEditingRibbonPageGroup textBoxEditingRibbonPageGroup1;

        private GroupToolsRibbonPageCategory groupToolsRibbonPageCategory1;

        private DataRibbonPage dataRibbonPage16;

        private MasterFilterRibbonPageGroup masterFilterRibbonPageGroup11;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage16;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup16;

        private ImageToolsRibbonPageCategory imageToolsRibbonPageCategory1;

        private DashboardItemDesignRibbonPage dashboardItemDesignRibbonPage7;

        private CommonItemDesignRibbonPageGroup commonItemDesignRibbonPageGroup7;

        private ImageOpenRibbonPageGroup imageOpenRibbonPageGroup1;

        private ImageSizeModeRibbonPageGroup imageSizeModeRibbonPageGroup1;

        private ImageAlignmentRibbonPageGroup imageAlignmentRibbonPageGroup1;

        private TextBoxEditorRibbonPageCategory textBoxEditorRibbonPageCategory1;

        private FileRibbonPage fileRibbonPage1;

        private CommonRibbonPageGroup commonRibbonPageGroup1;

        private DevExpress.XtraRichEdit.UI.HomeRibbonPage homeRibbonPage2;

        private ClipboardRibbonPageGroup clipboardRibbonPageGroup1;

        private FontRibbonPageGroup fontRibbonPageGroup1;

        private ParagraphRibbonPageGroup paragraphRibbonPageGroup1;

        private StylesRibbonPageGroup stylesRibbonPageGroup1;

        private EditingRibbonPageGroup editingRibbonPageGroup1;

        private InsertRibbonPage insertRibbonPage1;

        private TablesRibbonPageGroup tablesRibbonPageGroup1;

        private IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;

        private LinksRibbonPageGroup linksRibbonPageGroup1;

        private SymbolsRibbonPageGroup symbolsRibbonPageGroup1;

        private PageLayoutRibbonPage pageLayoutRibbonPage1;

        private PageBackgroundRibbonPageGroup pageBackgroundRibbonPageGroup1;

        private TableDesignRibbonPage tableDesignRibbonPage1;

        private TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;

        private TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;

        private TableDrawBordersRibbonPageGroup tableDrawBordersRibbonPageGroup1;

        private TableLayoutRibbonPage tableLayoutRibbonPage1;

        private TableTableRibbonPageGroup tableTableRibbonPageGroup1;

        private TableRowsAndColumnsRibbonPageGroup tableRowsAndColumnsRibbonPageGroup1;

        private TableMergeRibbonPageGroup tableMergeRibbonPageGroup1;

        private TableCellSizeRibbonPageGroup tableCellSizeRibbonPageGroup1;

        private TableAlignmentRibbonPageGroup tableAlignmentRibbonPageGroup1;

        private FloatingPictureToolsFormatPage floatingPictureToolsFormatPage1;

        private FloatingPictureToolsShapeStylesPageGroup floatingPictureToolsShapeStylesPageGroup1;

        private FloatingPictureToolsArrangePageGroup floatingPictureToolsArrangePageGroup1;

        private DevExpress.DashboardWin.Bars.HomeRibbonPage homeRibbonPage1;

        private FileRibbonPageGroup fileRibbonPageGroup1;

        private QuickAccessHistoryRibbonPageGroup quickAccessHistoryRibbonPageGroup1;

        private HistoryRibbonPageGroup historyRibbonPageGroup1;

        private InsertRibbonPageGroup insertRibbonPageGroup1;

        private ItemOperationRibbonPageGroup itemOperationRibbonPageGroup1;

        private GroupOperationRibbonPageGroup groupOperationRibbonPageGroup1;

        private DashboardDesignRibbonPageGroup dashboardDesignRibbonPageGroup1;

        private DataSourceRibbonPage dataSourceRibbonPage1;

        private DataSourceRibbonPageGroup dataSourceRibbonPageGroup1;

        private SqlDataSourceQueryRibbonPageGroup sqlDataSourceQueryRibbonPageGroup1;

        private ExtractSourceRibbonPageGroup extractSourceRibbonPageGroup1;

        private DataSourceFilteringRibbonPageGroup dataSourceFilteringRibbonPageGroup1;

        private DevExpress.DashboardWin.Bars.ViewRibbonPage viewRibbonPage1;

        private SkinsRibbonPageGroup skinsRibbonPageGroup1;

        private DashboardPopupMenu dashboardPopupMenu1;

        private DashboardBarController dashboardBarController1;

        private TextBoxEditorBarController textBoxEditorBarController1;

        public frmDiseñadorEscritorios()
        {
            InitializeComponent();
            this.MetodoDinamico();
        }


    }
}
