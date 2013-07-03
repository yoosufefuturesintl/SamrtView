namespace SmartView.UIModule.PQA.Report.InspectionSummaryReportClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;


    public partial class UIMap
    {
    }
    public partial class InspectionSummaryReport
    {

        /// <summary>
        /// DisplayInspectionSummaryReport - Use 'DisplayInspectionSummaryReportParams' to pass parameters into this method.
        /// </summary>
        public void DisplayInspectionSummaryReport()
        {
            #region Variable Declarations
            WinList uIListReportsList = this.UIReportBrowserWindow.UIListReportsWindow.UIListReportsList;
            WinButton uIPreviewButton = this.UIReportBrowserWindow.UIPreviewWindow.UIPreviewButton;
            #endregion

            LoadStandardReportTabInReportBrowser();
            // Select 'Inspection Summary' in 'listReports' list box
            uIListReportsList.SelectedItemsAsString = this.DisplayInspectionSummaryReportParams.UIListReportsListSelectedItemsAsString;

            // Click 'Preview' button
            Mouse.Click(uIPreviewButton, new Point(40, 16));
        }

        public virtual DisplayInspectionSummaryReportParams DisplayInspectionSummaryReportParams
        {
            get
            {
                if ((this.mDisplayInspectionSummaryReportParams == null))
                {
                    this.mDisplayInspectionSummaryReportParams = new DisplayInspectionSummaryReportParams();
                }
                return this.mDisplayInspectionSummaryReportParams;
            }
        }

        private DisplayInspectionSummaryReportParams mDisplayInspectionSummaryReportParams;

        /// <summary>
        /// LoadTheReportSelectionWindow
        /// </summary>
        public void LoadTheReportSelectionWindow()
        {
            #region Variable Declarations
            WinButton uIReportsButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UIReportsButton;
            #endregion

            // Click 'Reports' button
            Mouse.Click(uIReportsButton, new Point(23, 20));
        }

        /// <summary>
        /// MaximizedInspectionSummaryWindow
        /// </summary>
        public void MaximizedInspectionSummaryWindow()
        {
            #region Variable Declarations
            WinTitleBar uIInspectionSummaryTitleBar = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIInspectionSummaryTitleBar;
            #endregion

            // Double-Click 'Inspection Summary' title bar
            Mouse.DoubleClick(uIInspectionSummaryTitleBar, new Point(389, 7));
        }

        /// <summary>
        /// VerifyInspectionSummaryReportLoadedProperly - Use 'VerifyInspectionSummaryReportLoadedProperlyExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyInspectionSummaryReportLoadedProperly()
        {
            #region Variable Declarations
            WinClient uIPanelReportClient = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIPanelReportWindow.UIPanelReportClient;
            WinEdit uITextValueEdit = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIItem0Window.UITextValueEdit;
            WinWindow uIToolBarPreviewWindow = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIPanelPreviewWindow.UIToolBarPreviewWindow;
            #endregion

            // Verify that 'panelReport' client's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyInspectionSummaryReportLoadedProperlyExpectedValues.UIPanelReportClientExists, uIPanelReportClient.Exists);

            // Verify that 'textValue' text box's property 'Text' equals '1'
            //Assert.AreEqual(this.VerifyInspectionSummaryReportLoadedProperlyExpectedValues.UITextValueEditText, uITextValueEdit.Text);

            // Verify that 'toolBarPreview' window's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyInspectionSummaryReportLoadedProperlyExpectedValues.UIToolBarPreviewWindowExists, uIToolBarPreviewWindow.Exists);
        }

        public virtual VerifyInspectionSummaryReportLoadedProperlyExpectedValues VerifyInspectionSummaryReportLoadedProperlyExpectedValues
        {
            get
            {
                if ((this.mVerifyInspectionSummaryReportLoadedProperlyExpectedValues == null))
                {
                    this.mVerifyInspectionSummaryReportLoadedProperlyExpectedValues = new VerifyInspectionSummaryReportLoadedProperlyExpectedValues();
                }
                return this.mVerifyInspectionSummaryReportLoadedProperlyExpectedValues;
            }
        }

        private VerifyInspectionSummaryReportLoadedProperlyExpectedValues mVerifyInspectionSummaryReportLoadedProperlyExpectedValues;

        /// <summary>
        /// CloseInspectionSummaryReportWindow
        /// </summary>
        public void CloseInspectionSummaryReportWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(16, 7));
        }

        /// <summary>
        /// ExportInspectionSummaryToExcel - Use 'ExportInspectionSummaryToExcelParams' to pass parameters into this method.
        /// </summary>
        public void ExportInspectionSummaryToExcel(String filePath)
        {
            #region Variable Declarations
            WinTitleBar uIInspectionSummaryTitleBar = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIInspectionSummaryTitleBar;
            WinButton uIExcelWorkbookButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIExcelWorkbookButton;
            WinListItem uICapturedImageListItem = this.UIExportreportWindow.UIFolderViewList.UICapturedImageListItem;
            WinComboBox uIFilenameComboBox = this.UIExportreportWindow.UIItemWindow.UIFilenameComboBox;
            WinButton uISaveButton = this.UIExportreportWindow.UISaveWindow.UISaveButton;
            WinButton uICancelButton = this.UIOpenwithWindow.UICancelWindow.UICancelButton;
            #endregion

            // Click 'Inspection Summary' title bar
            Mouse.Click(uIInspectionSummaryTitleBar, new Point(519, 3));

            // Click 'Excel Workbook' button
            Mouse.Click(uIExcelWorkbookButton, new Point(10, 11));

            // Double-Click 'CapturedImage' list item
            // Mouse.DoubleClick(uICapturedImageListItem, new Point(76, 10));

            // Select 'TestInspection' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = filePath;

            // Click '&Save' button
            Mouse.Click(uISaveButton, new Point(49, 12));

            if (uICancelButton.Exists)
            {
                // Click 'Cancel' button
                Mouse.Click(uICancelButton, new Point(24, 15));
            }

        }

        public virtual ExportInspectionSummaryToExcelParams ExportInspectionSummaryToExcelParams
        {
            get
            {
                if ((this.mExportInspectionSummaryToExcelParams == null))
                {
                    this.mExportInspectionSummaryToExcelParams = new ExportInspectionSummaryToExcelParams();
                }
                return this.mExportInspectionSummaryToExcelParams;
            }
        }

        private ExportInspectionSummaryToExcelParams mExportInspectionSummaryToExcelParams;

        /// <summary>
        /// SaveDataFilter - Use 'SaveDataFilterParams' to pass parameters into this method.
        /// </summary>
        public void CreateDataFilter(String dataFilter)
        {
            #region Variable Declarations
            WinTitleBar uIInspectionSummaryTitleBar = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIInspectionSummaryTitleBar;
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinCheckBox uIDefectclassesCheckBox = this.UIInspectionSummaryWindow.UIDefectclassesWindow.UIDefectclassesClient.UIDefectclassesCheckBox;
            WinRadioButton uISeverityRadioButton = this.UIInspectionSummaryWindow.UISeverityWindow.UISeverityRadioButton;
            WinEdit uITxtClassesSeverityEdit = this.UIInspectionSummaryWindow.UIItem0Window.UITxtClassesSeverityEdit;
            WinButton uIPreviewButton = this.UIInspectionSummaryWindow.UIPreviewWindow.UIPreviewButton;
            WinButton uIBtnSaveButton = this.UIInspectionSummaryWindow.UIBtnSaveWindow.UIBtnSaveButton;
            WinEdit uITextEdit = this.UISaveWindow.UITextWindow.UITextEdit;
            WinButton uIOKButton = this.UISaveWindow.UIOKWindow.UIOKButton;
            WinButton uIFinishButton = this.UIInspectionSummaryWindow.UIFinishWindow.UIFinishButton;
            #endregion

            // Click 'Inspection Summary' title bar
            Mouse.Click(uIInspectionSummaryTitleBar, new Point(554, 9));

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(11, 16));

            // Select 'Defect classes' check box
            uIDefectclassesCheckBox.Checked = this.SaveDataFilterParams.UIDefectclassesCheckBoxChecked;

            // Select 'Severity' radio button
            uISeverityRadioButton.Selected = this.SaveDataFilterParams.UISeverityRadioButtonSelected;

            // Type '2' in 'txtClassesSeverity' text box
            uITxtClassesSeverityEdit.Text = this.SaveDataFilterParams.UITxtClassesSeverityEditText;

            // Click 'Preview' button
            Mouse.Click(uIPreviewButton, new Point(34, 16));

            // Click 'btnSave' button
            Mouse.Click(uIBtnSaveButton, new Point(9, 13));

            // Type 'AtmSeverity' in 'text' text box
            uITextEdit.Text = dataFilter;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(29, 10));

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(29, 7));
        }

        public virtual SaveDataFilterParams SaveDataFilterParams
        {
            get
            {
                if ((this.mSaveDataFilterParams == null))
                {
                    this.mSaveDataFilterParams = new SaveDataFilterParams();
                }
                return this.mSaveDataFilterParams;
            }
        }

        private SaveDataFilterParams mSaveDataFilterParams;

        /// <summary>
        /// CloseWizardWindow
        /// </summary>
        public void CloseWizardWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIInspectionSummaryWindow.UIInspectionSummaryTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(16, 9));
        }

        /// <summary>
        /// LoadCustomReportTabInReportBrowser
        /// </summary>
        public void LoadCustomReportTabInReportBrowser()
        {
            #region Variable Declarations
            WinTabPage uICustomTabPage = this.UIReportBrowserWindow.UITabReportWindow.UICustomTabPage;
            #endregion

            // Click 'Custom' tab
            Mouse.Click(uICustomTabPage, new Point(20, 10));
        }

        /// <summary>
        /// LoadStandardReportTabInReportBrowser
        /// </summary>
        public void LoadStandardReportTabInReportBrowser()
        {
            #region Variable Declarations
            WinTabPage uIStandardTabPage = this.UIReportBrowserWindow.UITabReportWindow.UIStandardTabPage;
            #endregion

            // Click 'Standard' tab
            Mouse.Click(uIStandardTabPage, new Point(23, 8));
        }

        /// <summary>
        /// RevertReportWizardSettings - Use 'RevertReportWizardSettingsParams' to pass parameters into this method.
        /// </summary>
        public void RevertReportWizardSettings()
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinTabPage uIDataQueryTabPage = this.UIInspectionSummaryWindow.UITabWindow.UIDataQueryTabPage;
            WinButton uIBtnUndoButton = this.UIInspectionSummaryWindow.UIBtnUndoWindow.UIBtnUndoButton;
            WinRadioButton uIDataQueryDefectFilteRadioButton = this.UIRevertsettingsWindow.UIDataQueryDefectFilteWindow.UIDataQueryDefectFilteRadioButton;
            WinButton uIOKButton = this.UIRevertsettingsWindow.UIOKWindow.UIOKButton;
            WinButton uIFinishButton = this.UIInspectionSummaryWindow.UIFinishWindow.UIFinishButton;
            WinButton uIOKButton1 = this.UIRichTextParseErrorWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIPagerenderingcrashWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(11, 11));

            // Double-Click 'Data Query' tab
            Mouse.DoubleClick(uIDataQueryTabPage, new Point(49, 11));

            // Click 'btnUndo' button
            Mouse.Click(uIBtnUndoButton, new Point(6, 13));

            // Select 'Data Query, Defect Filters, Options, and Formattin...' radio button
            uIDataQueryDefectFilteRadioButton.Selected = this.RevertReportWizardSettingsParams.UIDataQueryDefectFilteRadioButtonSelected;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(33, 14));

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(33, 17));

            // Click 'OK' button
            //Mouse.Click(uIOKButton1, new Point(60, 13));

            // Click 'OK' button
            //Mouse.Click(uIOKButton2, new Point(31, 11));
        }

        public virtual RevertReportWizardSettingsParams RevertReportWizardSettingsParams
        {
            get
            {
                if ((this.mRevertReportWizardSettingsParams == null))
                {
                    this.mRevertReportWizardSettingsParams = new RevertReportWizardSettingsParams();
                }
                return this.mRevertReportWizardSettingsParams;
            }
        }

        private RevertReportWizardSettingsParams mRevertReportWizardSettingsParams;

        /// <summary>
        /// SaveCustomizedInspectionSummaryReport - Use 'SaveCustomizedInspectionSummaryReportParams' to pass parameters into this method.
        /// </summary>
        public void CreateCustomInspectionSummaryReport(String customeReportName)
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinTabPage uIReportOptionsTabPage = this.UIInspectionSummaryWindow.UITabWindow.UIReportOptionsTabPage;
            WinCheckBox uIDisplaynullcountsCheckBox = this.UIInspectionSummaryWindow.UIDisplaynullcountsWindow.UIDisplaynullcountsCheckBox;
            WinCheckBox uIShowcustomtextCheckBox = this.UIInspectionSummaryWindow.UIShowcustomtextWindow.UIShowcustomtextCheckBox;
            WinButton uIItemButton = this.UIInspectionSummaryWindow.UIItemWindow1.UIItemButton;
            WinClient uITestClient = this.UICustomTextWindow.UITextValueWindow.UITestClient;
            WinButton uIApplyButton = this.UICustomTextWindow.UIApplyWindow.UIApplyButton;
            WinTabPage uISectionFormattingTabPage = this.UIInspectionSummaryWindow.UITabWindow.UISectionFormattingTabPage;
            WinComboBox uIComboPageComboBox = this.UIInspectionSummaryWindow.UIComboPageWindow.UIComboPageComboBox;
            WinRadioButton uILineRadioButton = this.UIInspectionSummaryWindow.UILineWindow.UILineRadioButton;
            WinCheckBox uILegendCheckBox = this.UIInspectionSummaryWindow.UILegendWindow.UILegendCheckBox;
            WinCheckBox uILogarithmicscaleCheckBox = this.UIInspectionSummaryWindow.UILogarithmicscaleWindow.UILogarithmicscaleCheckBox;
            WinButton uISaveButton = this.UIInspectionSummaryWindow.UISaveWindow.UISaveButton;
            WinEdit uITextNameEdit = this.UISaveCustomReportWindow.UICustomInspectionSummWindow.UITextNameEdit;
            WinButton uISaveButton1 = this.UISaveCustomReportWindow.UISaveWindow.UISaveButton;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(13, 9));

            // Click 'Report Options' tab
            Mouse.Click(uIReportOptionsTabPage, new Point(36, 11));

            // Select 'Display null counts' check box
            uIDisplaynullcountsCheckBox.Checked = this.SaveCustomizedInspectionSummaryReportParams.UIDisplaynullcountsCheckBoxChecked;

            // Select 'Show custom text' check box
            //uIShowcustomtextCheckBox.Checked = this.SaveCustomizedInspectionSummaryReportParams.UIShowcustomtextCheckBoxChecked;

            // Click '...' button
            //Mouse.Click(uIItemButton, new Point(8, 13));

            // Click 'Test' client
            //.Click(uITestClient, new Point(157, 19));

            //Keyboard.SendKeys(uITestClient, "Test custome text" + customeReportName, ModifierKeys.None);

            // Type '{Space}at{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}Test{Space}automation{Space}custom{Space}test{Back}{Back}xt' in 'Test' client
            //Keyboard.SendKeys(uITestClient, this.SaveCustomizedInspectionSummaryReportParams.UITestClientSendKeys, ModifierKeys.None);

            // Click 'Apply' button
            //Mouse.Click(uIApplyButton, new Point(33, 13));

            // Click 'Section Formatting' tab
            Mouse.Click(uISectionFormattingTabPage, new Point(50, 11));

            // Select 'Graph' in 'comboPage' combo box
            uIComboPageComboBox.SelectedItem = this.SaveCustomizedInspectionSummaryReportParams.UIComboPageComboBoxSelectedItem;

            // Select 'Line' radio button
            uILineRadioButton.Selected = this.SaveCustomizedInspectionSummaryReportParams.UILineRadioButtonSelected;

            // Select 'Legend' check box
            uILegendCheckBox.Checked = this.SaveCustomizedInspectionSummaryReportParams.UILegendCheckBoxChecked;

            // Select 'Logarithmic scale' check box
            uILogarithmicscaleCheckBox.Checked = this.SaveCustomizedInspectionSummaryReportParams.UILogarithmicscaleCheckBoxChecked;

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(39, 11));

            // Type 'ATME' in 'textName' text box
            uITextNameEdit.Text = customeReportName;

            // Click 'Save' button
            Mouse.Click(uISaveButton1, new Point(24, 19));

            CloseWizardWindow();
        }

        public virtual SaveCustomizedInspectionSummaryReportParams SaveCustomizedInspectionSummaryReportParams
        {
            get
            {
                if ((this.mSaveCustomizedInspectionSummaryReportParams == null))
                {
                    this.mSaveCustomizedInspectionSummaryReportParams = new SaveCustomizedInspectionSummaryReportParams();
                }
                return this.mSaveCustomizedInspectionSummaryReportParams;
            }
        }

        private SaveCustomizedInspectionSummaryReportParams mSaveCustomizedInspectionSummaryReportParams;

        /// <summary>
        /// GenerateCustomeReport - Use 'GenerateCustomeReportParams' to pass parameters into this method.
        /// </summary>
        public void GenerateCustomeReport(String customReportName)
        {
            #region Variable Declarations
            WinList uIListSettingsList = this.UIReportBrowserWindow.UIListSettingsWindow.UIListSettingsList;
            WinButton uIPreviewButton = this.UIReportBrowserWindow.UIPreviewWindow.UIPreviewButton;
            #endregion

            // Select 'CustomReport703081726191377122711582161557558326421623107761898520309370271228' in 'listSettings' list box
            uIListSettingsList.SelectedItemsAsString = customReportName;

            // Click 'Preview' button
            Mouse.Click(uIPreviewButton, new Point(42, 10));
        }

        public virtual GenerateCustomeReportParams GenerateCustomeReportParams
        {
            get
            {
                if ((this.mGenerateCustomeReportParams == null))
                {
                    this.mGenerateCustomeReportParams = new GenerateCustomeReportParams();
                }
                return this.mGenerateCustomeReportParams;
            }
        }

        private GenerateCustomeReportParams mGenerateCustomeReportParams;

        /// <summary>
        /// CloseReportBrowserWindow
        /// </summary>
        public void CloseReportBrowserWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIReportBrowserWindow.UIReportBrowserTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(17, 11));
        }

        public void VerifyCustomReportIsAvailableInCustomReportListInReportBrowser(String customReportName)
        {
            WinList uIListSettingsList = this.UIReportBrowserWindow.UIListSettingsWindow.UIListSettingsList;

            UITestControlCollection customReportList = uIListSettingsList.Items;

            for (int listIndex = 0; listIndex < customReportList.Count; listIndex++)
            {
                String listItemDisplayText = customReportList[listIndex].Name;
                if (listItemDisplayText.Equals(customReportName))
                {
                    Assert.Fail(customReportName + " custom report is not deleted. Cutom report in list is " + listItemDisplayText);
                }
            }
        }

        /// <summary>
        /// DeleteCreatedCustomReport
        /// </summary>
        public void DeleteCustomReport(String customReportName)
        {
            #region Variable Declarations
            WinButton uIReportsButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UIReportsButton;
            WinTabPage uICustomTabPage = this.UIReportBrowserWindow.UITabReportWindow.UICustomTabPage;
            WinListItem cutomReport = this.UIReportBrowserWindow.UIListSettingsWindow.UICustomReport12581859ListItem;
            WinMenuItem uIDeleteMenuItem = this.UIItemWindow.UIContextMenu.UIDeleteMenuItem;
            WinButton uIYesButton = this.UIConfirmationWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIProductionQualityAdvWindow.UIOKWindow.UIOKButton;
            #endregion

            cutomReport.SearchProperties[WinListItem.PropertyNames.Name] = customReportName;
            cutomReport.WindowTitles.Add("Report Browser");
            // Click 'Reports' button
            Mouse.Click(uIReportsButton, new Point(7, 10));

            // Double-Click 'Custom' tab
            Mouse.DoubleClick(uICustomTabPage, new Point(16, 10));

            // Right-Click 'CustomReport12581859791698347552589521771166024185...' list item
            Mouse.Click(cutomReport, MouseButtons.Right, ModifierKeys.None, new Point(81, 7));

            // Click 'Delete' menu item
            Mouse.Click(uIDeleteMenuItem, new Point(35, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(42, 9));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(43, 13));
        }

        /// <summary>
        /// NavigateToGraphPage - Use 'NavigateToGraphPageParams' to pass parameters into this method.
        /// </summary>
        public void NavigateTo(String component)
        {
            #region Variable Declarations
            WinComboBox uIComboBookmarksComboBox = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIComboBookmarksWindow.UIComboBookmarksComboBox;
            #endregion


            if (uIComboBookmarksComboBox.Exists)
            {
                // Select '$Report.Control.Graph' in 'comboBookmarks' combo box
                uIComboBookmarksComboBox.SelectedItem = component;
            }

            
        }

        public virtual NavigateToGraphPageParams NavigateToGraphPageParams
        {
            get
            {
                if ((this.mNavigateToGraphPageParams == null))
                {
                    this.mNavigateToGraphPageParams = new NavigateToGraphPageParams();
                }
                return this.mNavigateToGraphPageParams;
            }
        }

        private NavigateToGraphPageParams mNavigateToGraphPageParams;

        /// <summary>
        /// PushpinCurrentReport
        /// </summary>
        public void PushpinCurrentReport()
        {
            #region Variable Declarations
            WinButton uIPinreportButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIPinreportButton;
            #endregion

            // Click 'Pin report' button
            Mouse.Click(uIPinreportButton, new Point(10, 13));
        }

        /// <summary>
        /// VerifyControlsStatusInReportToolbar
        /// </summary>
        public void VerifyControlsStatusInReportToolbar(bool isEnabled)
        {
            #region Variable Declarations
            WinButton uIPinreportButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIPinreportButton;
            WinButton uIRunreportButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIRunreportButton;
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinButton uIPageSetupButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIPageSetupButton;
            #endregion

            // Verify 'Pin report' button status
            Assert.AreEqual(isEnabled, uIPinreportButton.Enabled);
            Mouse.Click(uIPinreportButton, new Point(8, 9));

            // Verify 'Run report' button status
            Assert.AreEqual(isEnabled, uIRunreportButton.Enabled);

            // Verify 'Wizard' button status
            Assert.AreEqual(!isEnabled, uIWizardButton.Enabled);

            // Verify 'Page Setup...' button status
            Assert.AreEqual(isEnabled, uIPageSetupButton.Enabled);

        }

        /// <summary>
        /// LoadReportWizardWindow
        /// </summary>
        public void LoadReportWizardWindow()
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinTabPage uIDefectFiltersTabPage = this.UIInspectionSummaryWindow.UITabWindow.UIDefectFiltersTabPage;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(15, 13));

            // Click 'Defect Filters' tab
            Mouse.Click(uIDefectFiltersTabPage, new Point(14, 13));
        }

        /// <summary>
        /// LoadReportOptionsTabInReportWizardWindow
        /// </summary>
        public void LoadReportOptionsTabInReportWizardWindow()
        {
            #region Variable Declarations
            WinTabPage uIReportOptionsTabPage = this.UIInspectionSummaryWindow.UITabWindow.UIReportOptionsTabPage;
            #endregion

            // Click 'Report Options' tab
            Mouse.Click(uIReportOptionsTabPage, new Point(28, 13));
        }

        /// <summary>
        /// VerifyDefultSettingsOfTheReportOptionsTab - Use 'VerifyDefultSettingsOfTheReportOptionsTabExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyDefultSettingsOfTheReportOptionsTab()
        {
            #region Variable Declarations
            WinCheckBox uICustomunitsCheckBox = this.UIInspectionSummaryWindow.UICustomunitsWindow.UICustomunitsCheckBox;
            WinCheckBox uIShowheaderCheckBox = this.UIInspectionSummaryWindow.UIShowheaderWindow.UIShowheaderCheckBox;
            WinCheckBox uIShowgraphCheckBox = this.UIInspectionSummaryWindow.UIShowgraphWindow.UIShowgraphCheckBox;
            WinCheckBox uIGroupbyviewCheckBox = this.UIInspectionSummaryWindow.UIGroupbyviewWindow.UIGroupbyviewCheckBox;
            WinCheckBox uIShowclasslabelsCheckBox = this.UIInspectionSummaryWindow.UIShowclasslabelsWindow.UIShowclasslabelsCheckBox;
            WinEdit uITextLimitsEdit = this.UIInspectionSummaryWindow.UITextLimitsWindow.UITextLimitsEdit;
            #endregion

            // Verify that 'Custom units' check box's property 'Checked' equals 'False'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UICustomunitsCheckBoxChecked, uICustomunitsCheckBox.Checked);

            // Verify that 'Show header' check box's property 'Checked' equals 'True'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UIShowheaderCheckBoxChecked, uIShowheaderCheckBox.Checked);

            // Verify that 'Show graph' check box's property 'Checked' equals 'True'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UIShowgraphCheckBoxChecked, uIShowgraphCheckBox.Checked);

            // Verify that 'Group by view' check box's property 'Checked' equals 'True'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UIGroupbyviewCheckBoxChecked, uIGroupbyviewCheckBox.Checked);

            // Verify that 'Show class labels' check box's property 'Checked' equals 'True'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UIShowclasslabelsCheckBoxChecked, uIShowclasslabelsCheckBox.Checked);

            // Verify that 'textLimits' text box's property 'Text' equals '10'
            Assert.AreEqual(this.VerifyDefultSettingsOfTheReportOptionsTabExpectedValues.UITextLimitsEditText, uITextLimitsEdit.Text);
        }

        public virtual VerifyDefultSettingsOfTheReportOptionsTabExpectedValues VerifyDefultSettingsOfTheReportOptionsTabExpectedValues
        {
            get
            {
                if ((this.mVerifyDefultSettingsOfTheReportOptionsTabExpectedValues == null))
                {
                    this.mVerifyDefultSettingsOfTheReportOptionsTabExpectedValues = new VerifyDefultSettingsOfTheReportOptionsTabExpectedValues();
                }
                return this.mVerifyDefultSettingsOfTheReportOptionsTabExpectedValues;
            }
        }

        private VerifyDefultSettingsOfTheReportOptionsTabExpectedValues mVerifyDefultSettingsOfTheReportOptionsTabExpectedValues;

        /// <summary>
        /// CloseReportWizardWindow
        /// </summary>
        public void CloseReportWizardWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIInspectionSummaryWindow.UIInspectionSummaryTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(13, 10));
}

        /// <summary>
        /// CloseInspectionSummarryReprot
        /// </summary>
        public void CloseInspectionSummarryReport()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UIInspectionSummaryWindow.UICloseButton;
            #endregion

            for (; uICloseButton.Exists; )
            {
                // Click 'Close' button
                Mouse.Click(uICloseButton, new Point(15, 12));
            }
          
}

        /// <summary>
        /// CloseExcelFile
        /// </summary>
        public void CloseExcelFile(String excelFileName)
        {
            #region Variable Declarations
            WinButton uIMicrosoftExcel959692Button = this.UIRunningapplicationsWindow.UIRunningapplicationsToolBar.UIMicrosoftExcel959692Button;
            WinMenuItem uIClosewindowMenuItem = this.UIJumpListWindow.UIItemWindow.UIJumpListClient.UIClosewindowMenuItem;
            #endregion
            uIMicrosoftExcel959692Button.SearchProperties[WinButton.PropertyNames.Name] = "Microsoft Excel - "+excelFileName+".xls  [Compatibility Mode]";
            uIMicrosoftExcel959692Button.WindowTitles.Add("Running applications");

            // Right-Click 'Microsoft Excel - 959692.xls  [Compatibility Mode]' button
            Mouse.Click(uIMicrosoftExcel959692Button, MouseButtons.Right, ModifierKeys.None, new Point(30, 14));

            // Click 'Close window' menu item
            Mouse.Click(uIClosewindowMenuItem, new Point(96, 15));
}
    }
    /// <summary>
    /// Parameters to be passed into 'DisplayInspectionSummaryReport'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplayInspectionSummaryReportParams
    {

        #region Fields
        /// <summary>
        /// Select 'Inspection Summary' in 'listReports' list box
        /// </summary>
        public string UIListReportsListSelectedItemsAsString = "Inspection Summary";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyInspectionSummaryReportLoadedProperly'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyInspectionSummaryReportLoadedProperlyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'panelReport' client's property 'Exists' equals 'True'
        /// </summary>
        public bool UIPanelReportClientExists = true;

        /// <summary>
        /// Verify that 'textValue' text box's property 'Text' equals '1'
        /// </summary>
        public string UITextValueEditText = "1";

        /// <summary>
        /// Verify that 'toolBarPreview' window's property 'Exists' equals 'True'
        /// </summary>
        public bool UIToolBarPreviewWindowExists = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ExportInspectionSummaryToExcel'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ExportInspectionSummaryToExcelParams
    {

        #region Fields
        /// <summary>
        /// Select 'TestInspection' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "TestInspection";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SaveDataFilter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SaveDataFilterParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect classes' check box
        /// </summary>
        public bool UIDefectclassesCheckBoxChecked = true;

        /// <summary>
        /// Select 'Severity' radio button
        /// </summary>
        public bool UISeverityRadioButtonSelected = true;

        /// <summary>
        /// Type '2' in 'txtClassesSeverity' text box
        /// </summary>
        public string UITxtClassesSeverityEditText = "2";

        /// <summary>
        /// Type 'Automation' in 'text' text box
        /// </summary>
        public string UITextEditText = "Automation";

        /// <summary>
        /// Type 'AtmSeverity' in 'text' text box
        /// </summary>
        public string UITextEditText1 = "AtmSeverity";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'RevertReportWizardSettings'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class RevertReportWizardSettingsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Data Query, Defect Filters, Options, and Formattin...' radio button
        /// </summary>
        public bool UIDataQueryDefectFilteRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SaveCustomizedInspectionSummaryReport'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SaveCustomizedInspectionSummaryReportParams
    {

        #region Fields
        /// <summary>
        /// Select 'Display null counts' check box
        /// </summary>
        public bool UIDisplaynullcountsCheckBoxChecked = true;

        /// <summary>
        /// Select 'Show custom text' check box
        /// </summary>
        public bool UIShowcustomtextCheckBoxChecked = true;

        /// <summary>
        /// Type '{Space}at{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}Test{Space}automation{Space}custom{Space}test{Back}{Back}xt' in 'Test' client
        /// </summary>
        public string UITestClientSendKeys = "{Space}at{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" +
            "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}Test{Space}automation{Spac" +
            "e}custom{Space}test{Back}{Back}xt";

        /// <summary>
        /// Select 'Graph' in 'comboPage' combo box
        /// </summary>
        public string UIComboPageComboBoxSelectedItem = "Graph";

        /// <summary>
        /// Select 'Line' radio button
        /// </summary>
        public bool UILineRadioButtonSelected = true;

        /// <summary>
        /// Select 'Legend' check box
        /// </summary>
        public bool UILegendCheckBoxChecked = true;

        /// <summary>
        /// Select 'Logarithmic scale' check box
        /// </summary>
        public bool UILogarithmicscaleCheckBoxChecked = true;

        /// <summary>
        /// Type 'ATME' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "ATME";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'GenerateCustomeReport'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GenerateCustomeReportParams
    {

        #region Fields
        /// <summary>
        /// Select 'CustomReport703081726191377122711582161557558326421623107761898520309370271228' in 'listSettings' list box
        /// </summary>
        public string UIListSettingsListSelectedItemsAsString = "CustomReport703081726191377122711582161557558326421623107761898520309370271228";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'NavigateToGraphPage'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class NavigateToGraphPageParams
    {

        #region Fields
        /// <summary>
        /// Select '$Report.Control.Graph' in 'comboBookmarks' combo box
        /// </summary>
        public string UIComboBookmarksComboBoxSelectedItem = "$Report.Control.Graph";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyDefultSettingsOfTheReportOptionsTab'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyDefultSettingsOfTheReportOptionsTabExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Custom units' check box's property 'Checked' equals 'False'
        /// </summary>
        public bool UICustomunitsCheckBoxChecked = false;

        /// <summary>
        /// Verify that 'Show header' check box's property 'Checked' equals 'True'
        /// </summary>
        public bool UIShowheaderCheckBoxChecked = true;

        /// <summary>
        /// Verify that 'Show graph' check box's property 'Checked' equals 'True'
        /// </summary>
        public bool UIShowgraphCheckBoxChecked = true;

        /// <summary>
        /// Verify that 'Group by view' check box's property 'Checked' equals 'True'
        /// </summary>
        public bool UIGroupbyviewCheckBoxChecked = true;

        /// <summary>
        /// Verify that 'Show class labels' check box's property 'Checked' equals 'True'
        /// </summary>
        public bool UIShowclasslabelsCheckBoxChecked = false;

        /// <summary>
        /// Verify that 'textLimits' text box's property 'Text' equals '10'
        /// </summary>
        public string UITextLimitsEditText = "10";
        #endregion
}
}
