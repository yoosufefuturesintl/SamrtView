namespace SmartView.UIModule.Console.MultiDefectViewer.MDVToolsClasses
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
    public partial class MDVTools
    {

        /// <summary>
        /// DisplaySelectedFeatures_1 - Use 'DisplaySelectedFeatures_1Params' to pass parameters into this method.
        /// </summary>
        public void DisplaySelectedFeatures_1()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UIFeatureSelectionWindow.UIItemWindow1.UIItemButton;
            WinList uIItemList = this.UIFeatureSelectionWindow.UIItemWindow.UIItemList;
            WinButton uIItemButton1 = this.UIFeatureSelectionWindow.UIItemWindow2.UIItemButton;
            WinListItem uIDownwebCenterListItem = this.UIFeatureSelectionWindow.UIItemWindow.UIDownwebCenterListItem;
            WinMenuItem uISetAllMenuItem = this.UIItemWindow1.UIContextMenu.UISetAllMenuItem;
            WinButton uIOKButton = this.UIFeatureSelectionWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(12, 13));

            // Select 'Defect No.,Class,Bottom,Right,Left' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.DisplaySelectedFeatures_1Params.UIItemListSelectedItemsAsString;

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton1, new Point(11, 15));

            // Right-Click 'Downweb Center' list item
            Mouse.Click(uIDownwebCenterListItem, MouseButtons.Right, ModifierKeys.None, new Point(59, 6));

            // Click 'Set All' menu item
            Mouse.Click(uISetAllMenuItem, new Point(39, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(29, 9));
        }

        public virtual DisplaySelectedFeatures_1Params DisplaySelectedFeatures_1Params
        {
            get
            {
                if ((this.mDisplaySelectedFeatures_1Params == null))
                {
                    this.mDisplaySelectedFeatures_1Params = new DisplaySelectedFeatures_1Params();
                }
                return this.mDisplaySelectedFeatures_1Params;
            }
        }

        private DisplaySelectedFeatures_1Params mDisplaySelectedFeatures_1Params;

        /// <summary>
        /// ApplyLiveModeSettings
        /// </summary>
        public void ApplyLiveModeSettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UILiveModeSettingsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 11));
        }

        /// <summary>
        /// ApplyQuerySettings
        /// </summary>
        public void ApplyQuerySettings()
        {
            #region Variable Declarations
            WinButton uIApplyButton = this.UIQueryDefinitionWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UIQueryDefinitionWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(41, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(32, 9));
        }

        /// <summary>
        /// DefineDefectMinimumDisplayTime - Use 'DefineDefectMinimumDisplayTimeParams' to pass parameters into this method.
        /// </summary>
        public void DefineDefectMinimumDisplayTime(String duration)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window1.UIItemEdit;
            #endregion

            // Type '3' in 'Unknown Name' text box
            uIItemEdit.Text = duration;
        }

        public void VeroifyDefineDefectMinimumDisplayTime(String duration)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window1.UIItemEdit;
            #endregion

            // Type '3' in 'Unknown Name' text box
            Assert.AreEqual(duration, uIItemEdit.Text);
        }

        public virtual DefineDefectMinimumDisplayTimeParams DefineDefectMinimumDisplayTimeParams
        {
            get
            {
                if ((this.mDefineDefectMinimumDisplayTimeParams == null))
                {
                    this.mDefineDefectMinimumDisplayTimeParams = new DefineDefectMinimumDisplayTimeParams();
                }
                return this.mDefineDefectMinimumDisplayTimeParams;
            }
        }

        private DefineDefectMinimumDisplayTimeParams mDefineDefectMinimumDisplayTimeParams;

        /// <summary>
        /// DefineQueryByAll - Use 'DefineQueryByAllParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryByAll(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIAllRadioButton = this.UIQueryDefinitionWindow.UIAllWindow.UIAllRadioButton;
            #endregion

            // Select 'All' radio button
            uIAllRadioButton.Selected = isEnabled;
        }

        public void VerifyDefineQueryByAll(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIAllRadioButton = this.UIQueryDefinitionWindow.UIAllWindow.UIAllRadioButton;
            #endregion

            // Select 'All' radio button
            Assert.AreEqual(isEnabled, uIAllRadioButton.Selected);
        }

        public virtual DefineQueryByAllParams DefineQueryByAllParams
        {
            get
            {
                if ((this.mDefineQueryByAllParams == null))
                {
                    this.mDefineQueryByAllParams = new DefineQueryByAllParams();
                }
                return this.mDefineQueryByAllParams;
            }
        }

        private DefineQueryByAllParams mDefineQueryByAllParams;

        /// <summary>
        /// DefineQueryByLanes - Use 'DefineQueryByLanesParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryByLanes(bool allLanes)
        {
            #region Variable Declarations
            WinListItem uIItem1ListItem = this.UIQueryDefinitionWindow.UIItemWindow2.UIItem1ListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow2.UIItemList;
            WinListItem uIItem4ListItem = this.UIQueryDefinitionWindow.UIItemWindow2.UIItem4ListItem;
            WinMenuItem uISetAllMenuItem = this.UIItemWindow1.UIContextMenu.UISetAllMenuItem;
            #endregion

            if (!allLanes)
            {
                // Right-Click '1' list item
                Mouse.Click(uIItem1ListItem, MouseButtons.Right, ModifierKeys.None, new Point(19, 10));

                // Click 'Clear All' menu item
                Mouse.Click(uIClearAllMenuItem, new Point(23, 11));

                // Select '1,2,3' in 'Unknown Name' list box
                uIItemList.SelectedItemsAsString = this.DefineQueryByLanesParams.UIItemListSelectedItemsAsString;
            }

            if (allLanes)
            {
                // Right-Click '4' list item
                Mouse.Click(uIItem4ListItem, MouseButtons.Right, ModifierKeys.None, new Point(12, 8));

                // Click 'Set All' menu item
                Mouse.Click(uISetAllMenuItem, new Point(34, 8));
            }
        }





        public virtual DefineQueryByLanesParams DefineQueryByLanesParams
        {
            get
            {
                if ((this.mDefineQueryByLanesParams == null))
                {
                    this.mDefineQueryByLanesParams = new DefineQueryByLanesParams();
                }
                return this.mDefineQueryByLanesParams;
            }
        }

        private DefineQueryByLanesParams mDefineQueryByLanesParams;

        /// <summary>
        /// DefineQueryBySelectedClasses - Use 'DefineQueryBySelectedClassesParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryBySelectedClasses(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uISelectedclassesRadioButton = this.UIQueryDefinitionWindow.UISelectedclassesWindow.UISelectedclassesRadioButton;
            WinListItem uIDiscreteExtremeBrighListItem = this.UIQueryDefinitionWindow.UIItemWindow1.UIDiscreteExtremeBrighListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow1.UIItemList;
            #endregion

            
            // Select 'Selected classes' radio button
            uISelectedclassesRadioButton.Selected = isEnabled;

            if (isEnabled)
            {
                // Right-Click 'Discrete Extreme Bright' list item
                Mouse.Click(uIDiscreteExtremeBrighListItem, MouseButtons.Right, ModifierKeys.None, new Point(35, 12));

                // Click 'Clear All' menu item
                Mouse.Click(uIClearAllMenuItem, new Point(42, 11));

                // Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Bright+Dark,Discrete Dark,Low Density Bright' in 'Unknown Name' list box
                uIItemList.SelectedItemsAsString = this.DefineQueryBySelectedClassesParams.UIItemListSelectedItemsAsString;
            }
        }

        public void VerifyDefineQueryBySelectedClasses(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uISelectedclassesRadioButton = this.UIQueryDefinitionWindow.UISelectedclassesWindow.UISelectedclassesRadioButton;
            WinListItem uIDiscreteExtremeBrighListItem = this.UIQueryDefinitionWindow.UIItemWindow1.UIDiscreteExtremeBrighListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow1.UIItemList;
            #endregion


            // Select 'Selected classes' radio button
            Assert.AreEqual(isEnabled, uISelectedclassesRadioButton.Selected);

            if (isEnabled)
            {
                // Right-Click 'Discrete Extreme Bright' list item
                //Mouse.Click(uIDiscreteExtremeBrighListItem, MouseButtons.Right, ModifierKeys.None, new Point(35, 12));

                // Click 'Clear All' menu item
                //Mouse.Click(uIClearAllMenuItem, new Point(42, 11));

                // Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Bright+Dark,Discrete Dark,Low Density Bright' in 'Unknown Name' list box
                //uIItemList.SelectedItemsAsString = this.DefineQueryBySelectedClassesParams.UIItemListSelectedItemsAsString;
            }
        }

        public virtual DefineQueryBySelectedClassesParams DefineQueryBySelectedClassesParams
        {
            get
            {
                if ((this.mDefineQueryBySelectedClassesParams == null))
                {
                    this.mDefineQueryBySelectedClassesParams = new DefineQueryBySelectedClassesParams();
                }
                return this.mDefineQueryBySelectedClassesParams;
            }
        }

        private DefineQueryBySelectedClassesParams mDefineQueryBySelectedClassesParams;

        /// <summary>
        /// DefineQueryBySeverity - Use 'DefineQueryBySeverityParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryBySeverity(bool isEnabled, String severity)
        {
            #region Variable Declarations
            WinRadioButton uISeverityRadioButton = this.UIQueryDefinitionWindow.UISeverityWindow.UISeverityRadioButton;
            WinEdit uIItemEdit = this.UIQueryDefinitionWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Severity >=' radio button
            uISeverityRadioButton.Selected = isEnabled;

            if (isEnabled)
            {
                // Type '11' in 'Unknown Name' text box
                uIItemEdit.Text = severity;
            }
        }

        public void VerifyDefineQueryBySeverity(bool isEnabled, String severity)
        {
            #region Variable Declarations
            WinRadioButton uISeverityRadioButton = this.UIQueryDefinitionWindow.UISeverityWindow.UISeverityRadioButton;
            WinEdit uIItemEdit = this.UIQueryDefinitionWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Severity >=' radio button
            Assert.AreEqual(isEnabled, uISeverityRadioButton.Selected);

            if (isEnabled)
            {
                // Type '11' in 'Unknown Name' text box
                Assert.AreEqual(severity, uIItemEdit.Text);
            }
        }

        public virtual DefineQueryBySeverityParams DefineQueryBySeverityParams
        {
            get
            {
                if ((this.mDefineQueryBySeverityParams == null))
                {
                    this.mDefineQueryBySeverityParams = new DefineQueryBySeverityParams();
                }
                return this.mDefineQueryBySeverityParams;
            }
        }

        private DefineQueryBySeverityParams mDefineQueryBySeverityParams;

        /// <summary>
        /// DefineQueryByView
        /// </summary>
        public void DefineQueryByView()
        {
            #region Variable Declarations
            WinListItem uIView1ListItem = this.UIQueryDefinitionWindow.UIItemWindow.UIView1ListItem;
            #endregion

            // Click 'View 1' list item
            Mouse.Click(uIView1ListItem, new Point(11, 6));
        }

        /// <summary>
        /// DelayDefectDisplay - Use 'DelayDefectDisplayParams' to pass parameters into this method.
        /// </summary>
        public void DelayDefectDisplay(bool isEnabled, String type, String value, bool isDelayLoadingNextInspection)
        {
            #region Variable Declarations
            WinCheckBox uIDelaydefectdisplayCheckBox = this.UILiveModeSettingsWindow.UIDelaydefectdisplayWindow.UIDelaydefectdisplayCheckBox;
            WinRadioButton uIOption1RadioButton = this.UILiveModeSettingsWindow.UIOption1Window.UIOption1RadioButton;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window2.UIItemEdit;
            WinRadioButton uIOption1RadioButton1 = this.UILiveModeSettingsWindow.UIOption1Window1.UIOption1RadioButton;
            WinEdit uIItemEdit1 = this.UILiveModeSettingsWindow.UIText1Window3.UIItemEdit;
            WinCheckBox uIDelayloadingnextinspCheckBox = this.UILiveModeSettingsWindow.UIDelayloadingnextinspWindow.UIDelayloadingnextinspCheckBox;
            #endregion

            // Select 'Delay defect display' check box
            uIDelaydefectdisplayCheckBox.Checked = isEnabled;

            if (isEnabled)
            {

                if (type.Equals("time"))
                {
                    // Select 'Option1' radio button
                    uIOption1RadioButton.Selected = this.DelayDefectDisplayParams.UIOption1RadioButtonSelected;

                    // Type '14' in 'Unknown Name' text box
                    uIItemEdit.Text = value;
                }

                if (type.Equals("length"))
                {
                    // Select 'Option1' radio button
                    uIOption1RadioButton1.Selected = this.DelayDefectDisplayParams.UIOption1RadioButtonSelected1;

                    // Type '13.56' in 'Unknown Name' text box
                    uIItemEdit1.Text = value;
                }

                // Select 'Delay loading next inspection' check box
                uIDelayloadingnextinspCheckBox.Checked = isDelayLoadingNextInspection;
            }
        }

        public void VerifyDelayDefectDisplay(bool isEnabled, String type, String value, bool isDelayLoadingNextInspection)
        {
            #region Variable Declarations
            WinCheckBox uIDelaydefectdisplayCheckBox = this.UILiveModeSettingsWindow.UIDelaydefectdisplayWindow.UIDelaydefectdisplayCheckBox;
            WinRadioButton uIOption1RadioButton = this.UILiveModeSettingsWindow.UIOption1Window.UIOption1RadioButton;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window2.UIItemEdit;
            WinRadioButton uIOption1RadioButton1 = this.UILiveModeSettingsWindow.UIOption1Window1.UIOption1RadioButton;
            WinEdit uIItemEdit1 = this.UILiveModeSettingsWindow.UIText1Window3.UIItemEdit;
            WinCheckBox uIDelayloadingnextinspCheckBox = this.UILiveModeSettingsWindow.UIDelayloadingnextinspWindow.UIDelayloadingnextinspCheckBox;
            #endregion

            // Select 'Delay defect display' check box
            Assert.AreEqual(isEnabled, uIDelaydefectdisplayCheckBox.Checked);

            if (isEnabled)
            {

                if (type.Equals("time"))
                {
                    // Select 'Option1' radio button
                    Assert.AreEqual(this.DelayDefectDisplayParams.UIOption1RadioButtonSelected, uIOption1RadioButton.Selected);

                    // Type '14' in 'Unknown Name' text box
                    Assert.AreEqual(value, uIItemEdit.Text);
                }

                if (type.Equals("length"))
                {
                    // Select 'Option1' radio button
                    Assert.AreEqual(this.DelayDefectDisplayParams.UIOption1RadioButtonSelected1, uIOption1RadioButton1.Selected);

                    // Type '13.56' in 'Unknown Name' text box
                    Assert.AreEqual(value, uIItemEdit1.Text);
                }

                // Select 'Delay loading next inspection' check box
                Assert.AreEqual(isDelayLoadingNextInspection, uIDelayloadingnextinspCheckBox.Checked);
            }
        }

        public virtual DelayDefectDisplayParams DelayDefectDisplayParams
        {
            get
            {
                if ((this.mDelayDefectDisplayParams == null))
                {
                    this.mDelayDefectDisplayParams = new DelayDefectDisplayParams();
                }
                return this.mDelayDefectDisplayParams;
            }
        }

        private DelayDefectDisplayParams mDelayDefectDisplayParams;

        /// <summary>
        /// DisplaySelectedFeatures - Use 'DisplaySelectedFeaturesParams' to pass parameters into this method.
        /// </summary>
        public void DisplaySelectedFeatures()
        {
            #region Variable Declarations
            WinListItem uIDefectNoListItem = this.UIFeatureSelectionWindow.UIItemWindow.UIDefectNoListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIFeatureSelectionWindow.UIItemWindow.UIItemList;
            #endregion

            // Right-Click 'Defect No.' list item
            Mouse.Click(uIDefectNoListItem, MouseButtons.Right, ModifierKeys.None, new Point(65, 11));

            // Click 'Clear All' menu item
            Mouse.Click(uIClearAllMenuItem, new Point(30, 15));

            // Select 'Defect No.,Class,Left,Right' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.DisplaySelectedFeaturesParams.UIItemListSelectedItemsAsString;
        }

        public virtual DisplaySelectedFeaturesParams DisplaySelectedFeaturesParams
        {
            get
            {
                if ((this.mDisplaySelectedFeaturesParams == null))
                {
                    this.mDisplaySelectedFeaturesParams = new DisplaySelectedFeaturesParams();
                }
                return this.mDisplaySelectedFeaturesParams;
            }
        }

        private DisplaySelectedFeaturesParams mDisplaySelectedFeaturesParams;

        /// <summary>
        /// EnableQueryDefinition - Use 'EnableQueryDefinitionParams' to pass parameters into this method.
        /// </summary>
        public void EnableQueryDefinition(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIApplyqueryCheckBox = this.UIQueryDefinitionWindow.UIApplyqueryWindow.UIApplyqueryCheckBox;
            #endregion
            // Select 'Apply query' check box
            uIApplyqueryCheckBox.Checked = isEnabled;

        }

        public void VerifyEnableQueryDefinition(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIApplyqueryCheckBox = this.UIQueryDefinitionWindow.UIApplyqueryWindow.UIApplyqueryCheckBox;
            #endregion
            // Select 'Apply query' check box
            Assert.AreEqual(isEnabled, uIApplyqueryCheckBox.Checked);

        }

        public virtual EnableQueryDefinitionParams EnableQueryDefinitionParams
        {
            get
            {
                if ((this.mEnableQueryDefinitionParams == null))
                {
                    this.mEnableQueryDefinitionParams = new EnableQueryDefinitionParams();
                }
                return this.mEnableQueryDefinitionParams;
            }
        }

        private EnableQueryDefinitionParams mEnableQueryDefinitionParams;

        /// <summary>
        /// LiveModeResumeScrollAutomatically - Use 'LiveModeResumeScrollAutomaticallyParams' to pass parameters into this method.
        /// </summary>
        public void LiveModeResumeScrollAutomatically(bool isEnabled, String duration)
        {
            #region Variable Declarations
            WinCheckBox uIAutomaticallyresumelCheckBox = this.UILiveModeSettingsWindow.UIAutomaticallyresumelWindow.UIAutomaticallyresumelCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Automatically resume live mode' check box
            uIAutomaticallyresumelCheckBox.Checked = isEnabled;

            if (isEnabled)
            {
                // Type '45' in 'Unknown Name' text box
                uIItemEdit.Text = duration;
            }
        }

        public void VerifyLiveModeResumeScrollAutomatically(bool isEnabled, String duration)
        {
            #region Variable Declarations
            WinCheckBox uIAutomaticallyresumelCheckBox = this.UILiveModeSettingsWindow.UIAutomaticallyresumelWindow.UIAutomaticallyresumelCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Automatically resume live mode' check box
            Assert.AreEqual(isEnabled, uIAutomaticallyresumelCheckBox.Checked);

            if (isEnabled)
            {
                // Type '45' in 'Unknown Name' text box
                Assert.AreEqual(duration, uIItemEdit.Text);
            }
        }



        public virtual LiveModeResumeScrollAutomaticallyParams LiveModeResumeScrollAutomaticallyParams
        {
            get
            {
                if ((this.mLiveModeResumeScrollAutomaticallyParams == null))
                {
                    this.mLiveModeResumeScrollAutomaticallyParams = new LiveModeResumeScrollAutomaticallyParams();
                }
                return this.mLiveModeResumeScrollAutomaticallyParams;
            }
        }

        private LiveModeResumeScrollAutomaticallyParams mLiveModeResumeScrollAutomaticallyParams;

        /// <summary>
        /// LiveModeStopScrollOnSelection - Use 'LiveModeStopScrollOnSelectionParams' to pass parameters into this method.
        /// </summary>
        public void LiveModeStopScrollOnSelection(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIStoponselectionCheckBox = this.UILiveModeSettingsWindow.UIStoponselectionWindow.UIStoponselectionCheckBox;
            #endregion

            // Select 'Stop on selection' check box
            uIStoponselectionCheckBox.Checked = isEnabled;
        }

        public void VerifyLiveModeStopScrollOnSelection(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIStoponselectionCheckBox = this.UILiveModeSettingsWindow.UIStoponselectionWindow.UIStoponselectionCheckBox;
            #endregion

            // Select 'Stop on selection' check box
            Assert.AreEqual(isEnabled, uIStoponselectionCheckBox.Checked);
        }

        public virtual LiveModeStopScrollOnSelectionParams LiveModeStopScrollOnSelectionParams
        {
            get
            {
                if ((this.mLiveModeStopScrollOnSelectionParams == null))
                {
                    this.mLiveModeStopScrollOnSelectionParams = new LiveModeStopScrollOnSelectionParams();
                }
                return this.mLiveModeStopScrollOnSelectionParams;
            }
        }

        private LiveModeStopScrollOnSelectionParams mLiveModeStopScrollOnSelectionParams;

        /// <summary>
        /// LoadGoToWindow
        /// </summary>
        public void LoadGoToWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(67, 11));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(47, 105));
        }

        /// <summary>
        /// LoadLiveModeSettingsWindow
        /// </summary>
        public void LoadLiveModeSettingsWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(64, 16));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(75, 37));
        }

        /// <summary>
        /// LoadQueryDefinitionWindow
        /// </summary>
        public void LoadQueryDefinitionWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(67, 11));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(40, 56));
        }

        /// <summary>
        /// LoadSelectFeaturesWindow
        /// </summary>
        public void LoadSelectFeaturesWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(66, 19));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(37, 77));
        }

        /// <summary>
        /// MoveSelectedFeatureUp
        /// </summary>
        public void MoveSelectedFeatureUp()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UIFeatureSelectionWindow.UIItemWindow1.UIItemButton;
            #endregion

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(12, 13));
        }

        /// <summary>
        /// MoveSelectedFetureDown - Use 'MoveSelectedFetureDownParams' to pass parameters into this method.
        /// </summary>
        public void MoveSelectedFetureDown()
        {
            #region Variable Declarations
            WinList uIItemList = this.UIFeatureSelectionWindow.UIItemWindow.UIItemList;
            WinButton uIItemButton = this.UIFeatureSelectionWindow.UIItemWindow2.UIItemButton;
            #endregion

            // Select 'Defect No.,Class,Bottom,Right,Left' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MoveSelectedFetureDownParams.UIItemListSelectedItemsAsString;

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(11, 15));
        }

        public virtual MoveSelectedFetureDownParams MoveSelectedFetureDownParams
        {
            get
            {
                if ((this.mMoveSelectedFetureDownParams == null))
                {
                    this.mMoveSelectedFetureDownParams = new MoveSelectedFetureDownParams();
                }
                return this.mMoveSelectedFetureDownParams;
            }
        }

        private MoveSelectedFetureDownParams mMoveSelectedFetureDownParams;

        /// <summary>
        /// NavigateByDefectNoAndView - Use 'NavigateByDefectNoAndViewParams' to pass parameters into this method.
        /// </summary>
        public void NavigateByDefectNoAndView(String view, String defectNo)
        {
            #region Variable Declarations
            WinListItem uIView1ListItem = this.UIGoToWindow.UIItemWindow.UIView1ListItem;
            WinEdit uIItemEdit = this.UIGoToWindow.UIText1Window.UIItemEdit;
            WinButton uIGOButton = this.UIGoToWindow.UIGOWindow.UIGOButton;
            uIView1ListItem.SearchProperties[WinListItem.PropertyNames.Name] = view;
            #endregion

            // Click 'View 1' list item
            Mouse.Click(uIView1ListItem, new Point(29, 5));

            // Type '63' in 'Unknown Name' text box
            uIItemEdit.Text = defectNo;

            // Click 'Go' button
            Mouse.Click(uIGOButton, new Point(28, 7));
        }

        public virtual NavigateByDefectNoAndViewParams NavigateByDefectNoAndViewParams
        {
            get
            {
                if ((this.mNavigateByDefectNoAndViewParams == null))
                {
                    this.mNavigateByDefectNoAndViewParams = new NavigateByDefectNoAndViewParams();
                }
                return this.mNavigateByDefectNoAndViewParams;
            }
        }

        private NavigateByDefectNoAndViewParams mNavigateByDefectNoAndViewParams;

        /// <summary>
        /// NavigateByPosition - Use 'NavigateByPositionParams' to pass parameters into this method.
        /// </summary>
        public void NavigateByPosition(String position)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIGoToWindow.UIText1Window1.UIItemEdit;
            WinButton uIGOButton = this.UIGoToWindow.UIGOWindow1.UIGOButton;
            #endregion

            // Type '10' in 'Unknown Name' text box
            uIItemEdit.Text = position;

            // Click 'Go' button
            Mouse.Click(uIGOButton, new Point(39, 13));
        }

        public virtual NavigateByPositionParams NavigateByPositionParams
        {
            get
            {
                if ((this.mNavigateByPositionParams == null))
                {
                    this.mNavigateByPositionParams = new NavigateByPositionParams();
                }
                return this.mNavigateByPositionParams;
            }
        }

        private NavigateByPositionParams mNavigateByPositionParams;

        /// <summary>
        /// SaveFeaturesSettings
        /// </summary>
        public void SaveFeaturesSettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIFeatureSelectionWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(29, 9));
}

        /// <summary>
        /// SelecteAllFeatures
        /// </summary>
        public void SelecteAllFeatures()
        {
            #region Variable Declarations
            WinListItem uIDownwebCenterListItem = this.UIFeatureSelectionWindow.UIItemWindow.UIDownwebCenterListItem;
            WinMenuItem uISetAllMenuItem = this.UIItemWindow1.UIContextMenu.UISetAllMenuItem;
            #endregion

            // Right-Click 'Downweb Center' list item
            Mouse.Click(uIDownwebCenterListItem, MouseButtons.Right, ModifierKeys.None, new Point(59, 6));

            // Click 'Set All' menu item
            Mouse.Click(uISetAllMenuItem, new Point(39, 8));
}
    }
    /// <summary>
    /// Parameters to be passed into 'DisplaySelectedFeatures_1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplaySelectedFeatures_1Params
    {

        #region Fields
        /// <summary>
        /// Select 'Defect No.,Class,Bottom,Right,Left' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Defect No.,Class,Bottom,Right,Left";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineDefectMinimumDisplayTime'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineDefectMinimumDisplayTimeParams
    {

        #region Fields
        /// <summary>
        /// Type '3' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "3";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryByAll'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryByAllParams
    {

        #region Fields
        /// <summary>
        /// Select 'All' radio button
        /// </summary>
        public bool UIAllRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryByLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryByLanesParams
    {

        #region Fields
        /// <summary>
        /// Select '1,2,3' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "1,2,3";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryBySelectedClasses'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryBySelectedClassesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Selected classes' radio button
        /// </summary>
        public bool UISelectedclassesRadioButtonSelected = true;

        /// <summary>
        /// Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Bright+Dark,Discrete Dark,Low Density Bright' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Discrete Extreme Bright,Discrete Bright,Discrete Extreme Bright+Dark,Discrete Dar" +
            "k,Low Density Bright";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryBySeverity'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryBySeverityParams
    {

        #region Fields
        /// <summary>
        /// Select 'Severity >=' radio button
        /// </summary>
        public bool UISeverityRadioButtonSelected = true;

        /// <summary>
        /// Type '11' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "11";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DelayDefectDisplay'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DelayDefectDisplayParams
    {

        #region Fields
        /// <summary>
        /// Select 'Delay defect display' check box
        /// </summary>
        public bool UIDelaydefectdisplayCheckBoxChecked = true;

        /// <summary>
        /// Select 'Option1' radio button
        /// </summary>
        public bool UIOption1RadioButtonSelected = true;

        /// <summary>
        /// Type '14' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "14";

        /// <summary>
        /// Select 'Option1' radio button
        /// </summary>
        public bool UIOption1RadioButtonSelected1 = true;

        /// <summary>
        /// Type '13.56' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "13.56";

        /// <summary>
        /// Select 'Delay loading next inspection' check box
        /// </summary>
        public bool UIDelayloadingnextinspCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DisplaySelectedFeatures'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplaySelectedFeaturesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect No.,Class,Left,Right' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Defect No.,Class,Left,Right";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnableQueryDefinition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnableQueryDefinitionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Apply query' check box
        /// </summary>
        public bool UIApplyqueryCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LiveModeResumeScrollAutomatically'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LiveModeResumeScrollAutomaticallyParams
    {

        #region Fields
        /// <summary>
        /// Select 'Automatically resume live mode' check box
        /// </summary>
        public bool UIAutomaticallyresumelCheckBoxChecked = true;

        /// <summary>
        /// Type '45' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "45";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LiveModeStopScrollOnSelection'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LiveModeStopScrollOnSelectionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Stop on selection' check box
        /// </summary>
        public bool UIStoponselectionCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MoveSelectedFetureDown'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class MoveSelectedFetureDownParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect No.,Class,Bottom,Right,Left' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Defect No.,Class,Bottom,Right,Left";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'NavigateByDefectNoAndView'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class NavigateByDefectNoAndViewParams
    {

        #region Fields
        /// <summary>
        /// Type '63' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "63";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'NavigateByPosition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class NavigateByPositionParams
    {

        #region Fields
        /// <summary>
        /// Type '10' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "10";
        #endregion
}
}
