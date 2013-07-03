namespace SmartView.UIModule.Recipe.TileMap.TileMapClasses
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
    public partial class TileMap
    {

        /// <summary>
        /// ApplyTileMapSettings
        /// </summary>
        public void ApplyTileMapSettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UISmartViewRecipeManagWindow1.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(18, 17));

            if (uIOKButton1.Exists)
            {
            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(41, 12));
            }
        }

        /// <summary>
        /// ConfirmRowHeightWarnings
        /// </summary>
        public void ConfirmRowHeightWarnings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow1.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(40, 18));
        }

        /// <summary>
        /// DefineLaneLayoutUsingNumberLaneWidthOfOption - Use 'DefineLaneLayoutUsingNumberLaneWidthOfOptionParams' to pass parameters into this method.
        /// </summary>
        public void DefineLaneLayoutUsingLaneWidthOfOption(bool isUsed, String noOfLane)
        {
            #region Variable Declarations
            WinRadioButton uIUselanewidthofRadioButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIUselanewidthofWindow.UIUselanewidthofRadioButton;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem100Window.UIItemEdit;
            #endregion

            // Select 'Use lane width of:' radio button
            uIUselanewidthofRadioButton.Selected = isUsed;

            // Type '8008.000' in 'Unknown Name' text box
            uIItemEdit.Text = noOfLane;
        }

        public virtual DefineLaneLayoutUsingNumberLaneWidthOfOptionParams DefineLaneLayoutUsingNumberLaneWidthOfOptionParams
        {
            get
            {
                if ((this.mDefineLaneLayoutUsingNumberLaneWidthOfOptionParams == null))
                {
                    this.mDefineLaneLayoutUsingNumberLaneWidthOfOptionParams = new DefineLaneLayoutUsingNumberLaneWidthOfOptionParams();
                }
                return this.mDefineLaneLayoutUsingNumberLaneWidthOfOptionParams;
            }
        }

        private DefineLaneLayoutUsingNumberLaneWidthOfOptionParams mDefineLaneLayoutUsingNumberLaneWidthOfOptionParams;

        /// <summary>
        /// DefineLaneLayoutUsingNumberOfLanesOption - Use 'DefineLaneLayoutUsingNumberOfLanesOptionParams' to pass parameters into this method.
        /// </summary>
        public void DefineLaneLayoutUsingNumberOfLanesOption(bool isUsed, String noOfLanes)
        {
            #region Variable Declarations
            WinRadioButton uIUsenumberoflanesRadioButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIUsenumberoflanesWindow.UIUsenumberoflanesRadioButton;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem4Window.UIItemEdit;
            WinButton uIMoreButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow.UIItemSpinner.UIMoreButton;
            WinButton uILessButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow.UIItemSpinner.UILessButton;
            #endregion

            // Select 'Use number of lanes:' radio button
            uIUsenumberoflanesRadioButton.Selected = isUsed;

            // Type '9' in 'Unknown Name' text box
            uIItemEdit.Text = noOfLanes;

            // Click 'More' button
            //Mouse.Click(uIMoreButton, new Point(10, 4));

            // Click 'Less' button
            //Mouse.Click(uILessButton, new Point(9, 4));
        }

        public virtual DefineLaneLayoutUsingNumberOfLanesOptionParams DefineLaneLayoutUsingNumberOfLanesOptionParams
        {
            get
            {
                if ((this.mDefineLaneLayoutUsingNumberOfLanesOptionParams == null))
                {
                    this.mDefineLaneLayoutUsingNumberOfLanesOptionParams = new DefineLaneLayoutUsingNumberOfLanesOptionParams();
                }
                return this.mDefineLaneLayoutUsingNumberOfLanesOptionParams;
            }
        }

        private DefineLaneLayoutUsingNumberOfLanesOptionParams mDefineLaneLayoutUsingNumberOfLanesOptionParams;

        /// <summary>
        /// ExportTileMapDefinition - Use 'ExportTileMapDefinitionParams' to pass parameters into this method.
        /// </summary>
        public void ExportTileMapDefinition()
        {
            #region Variable Declarations
            WinButton uIExportButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIExportWindow.UIExportButton;
            WinEdit uITextEdit = this.UIItemWindow1.UITextWindow.UITextEdit;
            WinButton uIOKButton = this.UIItemWindow1.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UISmartViewRecipeManagWindow1.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Export...' button
            Mouse.Click(uIExportButton, new Point(39, 8));

            // Type 'TileMapDefinition' in 'text' text box
            uITextEdit.Text = this.ExportTileMapDefinitionParams.UITextEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(24, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(42, 10));
        }

        public virtual ExportTileMapDefinitionParams ExportTileMapDefinitionParams
        {
            get
            {
                if ((this.mExportTileMapDefinitionParams == null))
                {
                    this.mExportTileMapDefinitionParams = new ExportTileMapDefinitionParams();
                }
                return this.mExportTileMapDefinitionParams;
            }
        }

        private ExportTileMapDefinitionParams mExportTileMapDefinitionParams;

        /// <summary>
        /// ImportTileMapDefinition - Use 'ImportTileMapDefinitionParams' to pass parameters into this method.
        /// </summary>
        public void ImportTileMapDefinition()
        {
            #region Variable Declarations
            WinButton uIImportButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIImportWindow.UIImportButton;
            WinList uIListList = this.UIItemWindow1.UIListWindow.UIListList;
            WinButton uIOKButton = this.UIItemWindow1.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Import...' button
            Mouse.Click(uIImportButton, new Point(62, 7));

            // Select 'TileMapDefinition' in 'list' list box
            uIListList.SelectedItemsAsString = this.ImportTileMapDefinitionParams.UIListListSelectedItemsAsString;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(26, 10));
        }

        public virtual ImportTileMapDefinitionParams ImportTileMapDefinitionParams
        {
            get
            {
                if ((this.mImportTileMapDefinitionParams == null))
                {
                    this.mImportTileMapDefinitionParams = new ImportTileMapDefinitionParams();
                }
                return this.mImportTileMapDefinitionParams;
            }
        }

        private ImportTileMapDefinitionParams mImportTileMapDefinitionParams;

        /// <summary>
        /// LoadTileMapDefinitionWindow
        /// </summary>
        public void LoadTileMapDefinitionWindow(String recipe, String view)
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinWindow uIItemWindow = this.UIItemWindow;
            WinMenuItem uITileMapMenuItem = this.UIItemWindow.UIContextMenu.UITileMapMenuItem;

            uIView1TreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = view;
            uIView1TreeItem.WindowTitles.Add("SmartView Recipe Manager - " + recipe);
            #endregion


            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(22, 4));

            // Right-Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, MouseButtons.Right, ModifierKeys.None, new Point(0, 0));

            // Click 'Tile Map...' menu item
            Mouse.Click(uITileMapMenuItem, new Point(55, 9));
        }

        public void LoadThresholdsWindow(String recipe, String view)
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinWindow uIItemWindow = this.UIItemWindow;
            WinMenuItem uITileMapMenuItem = this.UIItemWindow.UIContextMenu.UITileMapMenuItem;

            uIView1TreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = view;
            uIView1TreeItem.WindowTitles.Add("SmartView Recipe Manager - " + recipe);
            uITileMapMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Thresholds...";
            #endregion


            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(22, 4));

            // Right-Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, MouseButtons.Right, ModifierKeys.None, new Point(0, 0));

            // Click 'Tile Map...' menu item
            Mouse.Click(uITileMapMenuItem, new Point(55, 9));
        }


        /// <summary>
        /// SetDensityCalculationArea - Use 'SetDensityCalculationAreaParams' to pass parameters into this method.
        /// </summary>
        public void SetDensityCalculationArea(String area)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem1000000Window.UIItemEdit;
            #endregion

            // Type '12.0000' in 'Unknown Name' text box
            uIItemEdit.Text = area;
        }

        public virtual SetDensityCalculationAreaParams SetDensityCalculationAreaParams
        {
            get
            {
                if ((this.mSetDensityCalculationAreaParams == null))
                {
                    this.mSetDensityCalculationAreaParams = new SetDensityCalculationAreaParams();
                }
                return this.mSetDensityCalculationAreaParams;
            }
        }

        private SetDensityCalculationAreaParams mSetDensityCalculationAreaParams;

        /// <summary>
        /// SetExcludeDefectWithSeverityIs - Use 'SetExcludeDefectWithSeverityIsParams' to pass parameters into this method.
        /// </summary>
        public void SetExcludeDefectWithSeverityIsLessThan(String severity)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem1Window.UIItemEdit;
            #endregion

            // Type '16' in 'Unknown Name' text box
            uIItemEdit.Text = severity;
        }

        public virtual SetExcludeDefectWithSeverityIsParams SetExcludeDefectWithSeverityIsParams
        {
            get
            {
                if ((this.mSetExcludeDefectWithSeverityIsParams == null))
                {
                    this.mSetExcludeDefectWithSeverityIsParams = new SetExcludeDefectWithSeverityIsParams();
                }
                return this.mSetExcludeDefectWithSeverityIsParams;
            }
        }

        private SetExcludeDefectWithSeverityIsParams mSetExcludeDefectWithSeverityIsParams;

        /// <summary>
        /// SetRowDefectDensityThresholdAndAssignOutput - Use 'SetRowDefectDensityThresholdAndAssignOutputParams' to pass parameters into this method.
        /// </summary>
        public void SetRowDefectDensityThresholdAndAssignOutput(String densityThreshold)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem0Window2.UIItemEdit;
            WinButton uINotificationButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UINotificationWindow1.UINotificationButton;
            WinList uIItemList = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIItemWindow.UIItemList;
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIOKWindow.UIOKButton;
            #endregion

            // Type '99939' in 'Unknown Name' text box
            uIItemEdit.Text = densityThreshold;

            // Click 'Notification...' button
            Mouse.Click(uINotificationButton, new Point(27, 8));

            // Select 'Output 4,Output 5' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.SetRowDefectDensityThresholdAndAssignOutputParams.UIItemListSelectedItemsAsString;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(39, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(35, 8));
        }

        public virtual SetRowDefectDensityThresholdAndAssignOutputParams SetRowDefectDensityThresholdAndAssignOutputParams
        {
            get
            {
                if ((this.mSetRowDefectDensityThresholdAndAssignOutputParams == null))
                {
                    this.mSetRowDefectDensityThresholdAndAssignOutputParams = new SetRowDefectDensityThresholdAndAssignOutputParams();
                }
                return this.mSetRowDefectDensityThresholdAndAssignOutputParams;
            }
        }

        private SetRowDefectDensityThresholdAndAssignOutputParams mSetRowDefectDensityThresholdAndAssignOutputParams;

        /// <summary>
        /// SetRowHeight - Use 'SetRowHeightParams' to pass parameters into this method.
        /// </summary>
        public void SetRowHeight(String rowHeight)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem0Window.UIItemEdit;
            #endregion

            // Type '28.00' in 'Unknown Name' text box
            uIItemEdit.Text = rowHeight;
        }

        public virtual SetRowHeightParams SetRowHeightParams
        {
            get
            {
                if ((this.mSetRowHeightParams == null))
                {
                    this.mSetRowHeightParams = new SetRowHeightParams();
                }
                return this.mSetRowHeightParams;
            }
        }

        private SetRowHeightParams mSetRowHeightParams;

        /// <summary>
        /// SetRowSeverityThresholdAndAssignNotification - Use 'SetRowSeverityThresholdAndAssignNotificationParams' to pass parameters into this method.
        /// </summary>
        public void SetRowSeverityThresholdAndAssignNotification(String rowSeverityThreshold)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem0Window1.UIItemEdit;
            WinButton uINotificationButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UINotificationWindow.UINotificationButton;
            WinList uIItemList = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIItemWindow.UIItemList;
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIRowSeverityNotificatWindow.UIOKWindow.UIOKButton;
            #endregion

            // Type '99929' in 'Unknown Name' text box
            uIItemEdit.Text = rowSeverityThreshold;

            // Click 'Notification...' button
            Mouse.Click(uINotificationButton, new Point(45, 10));

            // Select 'Output 1,Output 2' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.SetRowSeverityThresholdAndAssignNotificationParams.UIItemListSelectedItemsAsString;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(29, 15));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(48, 11));
        }

        public virtual SetRowSeverityThresholdAndAssignNotificationParams SetRowSeverityThresholdAndAssignNotificationParams
        {
            get
            {
                if ((this.mSetRowSeverityThresholdAndAssignNotificationParams == null))
                {
                    this.mSetRowSeverityThresholdAndAssignNotificationParams = new SetRowSeverityThresholdAndAssignNotificationParams();
                }
                return this.mSetRowSeverityThresholdAndAssignNotificationParams;
            }
        }

        private SetRowSeverityThresholdAndAssignNotificationParams mSetRowSeverityThresholdAndAssignNotificationParams;

        /// <summary>
        /// SetSeverityThreshold - Use 'SetSeverityThresholdParams' to pass parameters into this method.
        /// </summary>
        public void SetSeverityThreshold(String severityThreshold)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItem0Window3.UIItemEdit;
            #endregion

            // Type '886' in 'Unknown Name' text box
            uIItemEdit.Text = severityThreshold;
        }

        public virtual SetSeverityThresholdParams SetSeverityThresholdParams
        {
            get
            {
                if ((this.mSetSeverityThresholdParams == null))
                {
                    this.mSetSeverityThresholdParams = new SetSeverityThresholdParams();
                }
                return this.mSetSeverityThresholdParams;
            }
        }

        private SetSeverityThresholdParams mSetSeverityThresholdParams;

        /// <summary>
        /// SpecifyCustomLanes - Use 'SpecifyCustomLanesParams' to pass parameters into this method.
        /// </summary>
        public void SpecifyCustomLanes()
        {
            #region Variable Declarations
            WinRadioButton uISpecifycustomlanesRadioButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UISpecifycustomlanesWindow.UISpecifycustomlanesRadioButton;
            #endregion

            // Select 'Specify custom lanes' radio button
            uISpecifycustomlanesRadioButton.Selected = this.SpecifyCustomLanesParams.UISpecifycustomlanesRadioButtonSelected;
        }

        public virtual SpecifyCustomLanesParams SpecifyCustomLanesParams
        {
            get
            {
                if ((this.mSpecifyCustomLanesParams == null))
                {
                    this.mSpecifyCustomLanesParams = new SpecifyCustomLanesParams();
                }
                return this.mSpecifyCustomLanesParams;
            }
        }

        private SpecifyCustomLanesParams mSpecifyCustomLanesParams;

        /// <summary>
        /// AddLanes - Use 'AddLanesParams' to pass parameters into this method.
        /// </summary>
        public void AddLanes(String location)
        {
            #region Variable Declarations
            WinRadioButton uISpecifycustomlanesRadioButton = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UISpecifycustomlanesWindow.UISpecifycustomlanesRadioButton;
            WinClient uITileMapDefinitionStaClient = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow1.UITileMapDefinitionStaClient;
            WinClient uITileMapDefinitionStaClient1 = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow2.UITileMapDefinitionStaClient;
            WinMenuItem uIInsertBeforeSelectioMenuItem = this.UIItemWindow.UIContextMenu.UIInsertBeforeSelectioMenuItem;
            WinClient uITileMapDefinitionStaClient2 = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow3.UITileMapDefinitionStaClient;
            WinMenuItem uIInsertAfterSelectionMenuItem = this.UIItemWindow.UIContextMenu.UIInsertAfterSelectionMenuItem;
            WinClient uITileMapDefinitionStaClient3 = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow4.UITileMapDefinitionStaClient;
            WinMenuItem uIAppendtotheEndMenuItem = this.UIItemWindow.UIContextMenu.UIAppendtotheEndMenuItem;
            #endregion

            // Select 'Specify custom lanes' radio button
            uISpecifycustomlanesRadioButton.Selected = this.AddLanesParams.UISpecifycustomlanesRadioButtonSelected;

            // Click 'Tile Map Definition: Station, View 1' client
            Mouse.Click(uITileMapDefinitionStaClient, new Point(49, 25));

            // Right-Click 'Tile Map Definition: Station, View 1' client
            Mouse.Click(uITileMapDefinitionStaClient1, MouseButtons.Right, ModifierKeys.None, new Point(49, 25));

            if (location.Equals("Before"))
            {
                // Click 'Insert Before Selection' menu item
                Mouse.Click(uIInsertBeforeSelectioMenuItem, new Point(44, 12));
            }

            if (location.Equals("After"))
            {
                // Click 'Insert After Selection' menu item
                Mouse.Click(uIInsertAfterSelectionMenuItem, new Point(68, 10));
            }

            if (location.Equals("Append"))
            {
                /// Click 'Append to the End' menu item
                Mouse.Click(uIAppendtotheEndMenuItem, new Point(72, 13));
            }
            
        }

        public virtual AddLanesParams AddLanesParams
        {
            get
            {
                if ((this.mAddLanesParams == null))
                {
                    this.mAddLanesParams = new AddLanesParams();
                }
                return this.mAddLanesParams;
            }
        }

        private AddLanesParams mAddLanesParams;

        /// <summary>
        /// DeleteSelectedLanes
        /// </summary>
        public void DeleteSelectedLanes(String noOfLane)
        {
            #region Variable Declarations
            WinClient uITileMapDefinitionStaClient = this.UISmartViewRecipeManagWindow.UITileMapDefinitionStaWindow.UIItemWindow1.UITileMapDefinitionStaClient;
            WinMenuItem uIDeleteSelectedLanesMenuItem = this.UIItemWindow.UIContextMenu.UIDeleteSelectedLanesMenuItem;
            #endregion

            if (noOfLane.Equals("Multiple"))
            {
                // Click 'Tile Map Definition: Station, View 1' client while pressing Shift
                Mouse.Click(uITileMapDefinitionStaClient, MouseButtons.Left, ModifierKeys.Shift, new Point(57, 38));

                // Right-Click 'Tile Map Definition: Station, View 1' client
                Mouse.Click(uITileMapDefinitionStaClient, MouseButtons.Right, ModifierKeys.None, new Point(57, 39));

                // Click 'Delete Selected Lanes' menu item
                Mouse.Click(uIDeleteSelectedLanesMenuItem, new Point(50, 10));
            }

            if (noOfLane.Equals("Single"))
            {
                // Right-Click 'Tile Map Definition: Station, View 1' client
                Mouse.Click(uITileMapDefinitionStaClient, MouseButtons.Right, ModifierKeys.None, new Point(45, 24));

                // Click 'Delete Selected Lanes' menu item
                Mouse.Click(uIDeleteSelectedLanesMenuItem, new Point(47, 11));
            }
}
    }
    /// <summary>
    /// Parameters to be passed into 'DefineLaneLayoutUsingNumberLaneWidthOfOption'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineLaneLayoutUsingNumberLaneWidthOfOptionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Use lane width of:' radio button
        /// </summary>
        public bool UIUselanewidthofRadioButtonSelected = true;

        /// <summary>
        /// Type '8008.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "8008.000";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineLaneLayoutUsingNumberOfLanesOption'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineLaneLayoutUsingNumberOfLanesOptionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Use number of lanes:' radio button
        /// </summary>
        public bool UIUsenumberoflanesRadioButtonSelected = true;

        /// <summary>
        /// Type '9' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "9";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ExportTileMapDefinition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ExportTileMapDefinitionParams
    {

        #region Fields
        /// <summary>
        /// Type 'TileMapDefinition' in 'text' text box
        /// </summary>
        public string UITextEditText = "TileMapDefinition";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ImportTileMapDefinition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportTileMapDefinitionParams
    {

        #region Fields
        /// <summary>
        /// Select 'TileMapDefinition' in 'list' list box
        /// </summary>
        public string UIListListSelectedItemsAsString = "TileMapDefinition";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetDensityCalculationArea'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetDensityCalculationAreaParams
    {

        #region Fields
        /// <summary>
        /// Type '12.0000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "12.0000";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetExcludeDefectWithSeverityIs'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetExcludeDefectWithSeverityIsParams
    {

        #region Fields
        /// <summary>
        /// Type '16' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "16";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetRowDefectDensityThresholdAndAssignOutput'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetRowDefectDensityThresholdAndAssignOutputParams
    {

        #region Fields
        /// <summary>
        /// Type '99939' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "99939";

        /// <summary>
        /// Select 'Output 4,Output 5' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Output 4,Output 5";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetRowHeight'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetRowHeightParams
    {

        #region Fields
        /// <summary>
        /// Type '28.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "28.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetRowSeverityThresholdAndAssignNotification'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetRowSeverityThresholdAndAssignNotificationParams
    {

        #region Fields
        /// <summary>
        /// Type '99929' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "99929";

        /// <summary>
        /// Select 'Output 1,Output 2' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Output 1,Output 2";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetSeverityThreshold'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetSeverityThresholdParams
    {

        #region Fields
        /// <summary>
        /// Type '886' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "886";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SpecifyCustomLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SpecifyCustomLanesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Specify custom lanes' radio button
        /// </summary>
        public bool UISpecifycustomlanesRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'AddLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AddLanesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Specify custom lanes' radio button
        /// </summary>
        public bool UISpecifycustomlanesRadioButtonSelected = true;
        #endregion
}
}
