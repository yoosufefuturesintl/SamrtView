namespace SVConsole.UIModule.Console.LaneViewer.LaneViewerClasses
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
    public partial class LaneViewer
    {

        /// <summary>
        /// ApplyLiveModeSettings
        /// </summary>
        public void ApplyLiveModeSettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UILiveModeSettingsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(23, 12));
        }

        /// <summary>
        /// AutomaticallyResumeLiveMode - Use 'AutomaticallyResumeLiveModeParams' to pass parameters into this method.
        /// </summary>
        public void AutomaticallyResumeLiveMode(bool isEnabled, String time)
        {
            #region Variable Declarations
            WinCheckBox uIAutomaticallyresumelCheckBox = this.UILiveModeSettingsWindow.UIAutomaticallyresumelWindow.UIAutomaticallyresumelCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Automatically resume live mode' check box
            uIAutomaticallyresumelCheckBox.Checked = isEnabled;

            if (isEnabled)
            {
                // Type '20' in 'Unknown Name' text box
                uIItemEdit.Text = time;
            }
        }

        public void VerifyAutomaticallyResumeLiveMode(bool isEnabled, String time)
        {
            #region Variable Declarations
            WinCheckBox uIAutomaticallyresumelCheckBox = this.UILiveModeSettingsWindow.UIAutomaticallyresumelWindow.UIAutomaticallyresumelCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Automatically resume live mode' check box
            Assert.AreEqual(isEnabled, uIAutomaticallyresumelCheckBox.Checked);

            // Type '20' in 'Unknown Name' text box
            Assert.AreEqual(time,uIItemEdit.Text);
        }


        public virtual AutomaticallyResumeLiveModeParams AutomaticallyResumeLiveModeParams
        {
            get
            {
                if ((this.mAutomaticallyResumeLiveModeParams == null))
                {
                    this.mAutomaticallyResumeLiveModeParams = new AutomaticallyResumeLiveModeParams();
                }
                return this.mAutomaticallyResumeLiveModeParams;
            }
        }

        private AutomaticallyResumeLiveModeParams mAutomaticallyResumeLiveModeParams;

        /// <summary>
        /// CloseQueryDefinitionWindow
        /// </summary>
        public void CloseQueryDefinitionWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIQueryDefinitionWindow.UIQueryDefinitionTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(9, 5));
        }

        /// <summary>
        /// DefineCustomSideLabels - Use 'DefineCustomSideLabelsParams' to pass parameters into this method.
        /// </summary>
        public void DefineCustomSideLabels()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISideLabelsWindow.UIItemWindow.UIItemEdit;
            WinClient uISideLabelsClient = this.UISideLabelsWindow.UIItemWindow1.UISideLabelsClient;
            WinButton uIOKButton = this.UISideLabelsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Type 'TestLeftSidLabes' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineCustomSideLabelsParams.UIItemEditText;

            // Double-Click 'Side Labels' client
            Mouse.DoubleClick(uISideLabelsClient, new Point(300, 5));

            // Type 'TestRightSideLabels' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineCustomSideLabelsParams.UIItemEditText1;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 10));
        }

        public virtual DefineCustomSideLabelsParams DefineCustomSideLabelsParams
        {
            get
            {
                if ((this.mDefineCustomSideLabelsParams == null))
                {
                    this.mDefineCustomSideLabelsParams = new DefineCustomSideLabelsParams();
                }
                return this.mDefineCustomSideLabelsParams;
            }
        }

        private DefineCustomSideLabelsParams mDefineCustomSideLabelsParams;

        /// <summary>
        /// DefineQueryAllDefects - Use 'DefineQueryAllDefectsParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryAllDefects(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIAllRadioButton = this.UIQueryDefinitionWindow.UIAllWindow.UIAllRadioButton;
            #endregion

            // Select 'All' radio button
            uIAllRadioButton.Selected = isEnabled;
        }

        public void VerifyDefineQueryAllDefects(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIAllRadioButton = this.UIQueryDefinitionWindow.UIAllWindow.UIAllRadioButton;
            #endregion

            // Select 'All' radio button
            Assert.AreEqual(isEnabled, uIAllRadioButton.Selected);
        }

        public virtual DefineQueryAllDefectsParams DefineQueryAllDefectsParams
        {
            get
            {
                if ((this.mDefineQueryAllDefectsParams == null))
                {
                    this.mDefineQueryAllDefectsParams = new DefineQueryAllDefectsParams();
                }
                return this.mDefineQueryAllDefectsParams;
            }
        }

        private DefineQueryAllDefectsParams mDefineQueryAllDefectsParams;

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
                // Type '6' in 'Unknown Name' text box
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
                // Type '6' in 'Unknown Name' text box
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
        /// DefineQueryLanes - Use 'DefineQueryLanesParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryLanes()
        {
            #region Variable Declarations
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow1.UIItemList;
            WinButton uIRetryButton = this.UISmartViewConsoleWindow.UIRetryWindow.UIRetryButton;
            WinList uIItemList1 = this.UIQueryDefinitionWindow.UIItemWindow2.UIItemList;
            WinListItem uIItem1ListItem = this.UIQueryDefinitionWindow.UIItemWindow3.UIItem1ListItem;
            WinListItem uIItem1ListItem1 = this.UIQueryDefinitionWindow.UIItemWindow4.UIItem1ListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            #endregion

            // Select '2,3,4,5,6,7,8,9' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.DefineQueryLanesParams.UIItemListSelectedItemsAsString;

            // Click '&Retry' button
            Mouse.Click(uIRetryButton, new Point(53, 14));

            // Select '3,4,5,6,7,8,9' in 'Unknown Name' list box
            uIItemList1.SelectedItemsAsString = this.DefineQueryLanesParams.UIItemListSelectedItemsAsString1;

            // Right-Click '1' list item
            Mouse.Click(uIItem1ListItem, MouseButtons.Right, ModifierKeys.None, new Point(12, 8));

            // Click '&Retry' button
            Mouse.Click(uIRetryButton, new Point(54, 13));

            // Right-Click '1' list item
            Mouse.Click(uIItem1ListItem1, MouseButtons.Right, ModifierKeys.None, new Point(19, 7));

            // Click 'Clear All' menu item
            Mouse.Click(uIClearAllMenuItem, new Point(37, 17));
        }

        public virtual DefineQueryLanesParams DefineQueryLanesParams
        {
            get
            {
                if ((this.mDefineQueryLanesParams == null))
                {
                    this.mDefineQueryLanesParams = new DefineQueryLanesParams();
                }
                return this.mDefineQueryLanesParams;
            }
        }

        private DefineQueryLanesParams mDefineQueryLanesParams;

        /// <summary>
        /// DefineQueryOnlyRepeating - Use 'DefineQueryOnlyRepeatingParams' to pass parameters into this method.
        /// </summary>
        public void DefineQueryOnlyRepeating(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIOnlyrepeatingRadioButton = this.UIQueryDefinitionWindow.UIOnlyrepeatingWindow.UIOnlyrepeatingRadioButton;
            #endregion

            // Select 'Only repeating' radio button
            uIOnlyrepeatingRadioButton.Selected = isEnabled;
        }

        public void VerifyDefineQueryOnlyRepeating(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIOnlyrepeatingRadioButton = this.UIQueryDefinitionWindow.UIOnlyrepeatingWindow.UIOnlyrepeatingRadioButton;
            #endregion

            // Select 'Only repeating' radio button
            Assert.AreEqual(isEnabled, uIOnlyrepeatingRadioButton.Selected);
        }

        public virtual DefineQueryOnlyRepeatingParams DefineQueryOnlyRepeatingParams
        {
            get
            {
                if ((this.mDefineQueryOnlyRepeatingParams == null))
                {
                    this.mDefineQueryOnlyRepeatingParams = new DefineQueryOnlyRepeatingParams();
                }
                return this.mDefineQueryOnlyRepeatingParams;
            }
        }

        private DefineQueryOnlyRepeatingParams mDefineQueryOnlyRepeatingParams;

        /// <summary>
        /// DefineQuerySelectedClasses - Use 'DefineQuerySelectedClassesParams' to pass parameters into this method.
        /// </summary>
        public void DefineQuerySelectedClasses(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uISelectedclassesRadioButton = this.UIQueryDefinitionWindow.UISelectedclassesWindow.UISelectedclassesRadioButton;
            WinListItem uIDiscreteExtremeBrighListItem = this.UIQueryDefinitionWindow.UIItemWindow.UIDiscreteExtremeBrighListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow.UIItemList;
            #endregion

            // Select 'Selected classes' radio button
            uISelectedclassesRadioButton.Selected = isEnabled;

            if (isEnabled)
            {
                // Right-Click 'Discrete Extreme Bright' list item
                Mouse.Click(uIDiscreteExtremeBrighListItem, MouseButtons.Right, ModifierKeys.None, new Point(53, 14));

                // Click 'Clear All' menu item
                Mouse.Click(uIClearAllMenuItem, new Point(34, 11));

                // Select 'Discrete Extreme Bright' in 'Unknown Name' list box
              // uIItemList.SelectedItemsAsString = this.DefineQuerySelectedClassesParams.UIItemListSelectedItemsAsString;

                // Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Dark,Low Density Bright' in 'Unknown Name' list box
                uIItemList.SelectedItemsAsString = this.DefineQuerySelectedClassesParams.UIItemListSelectedItemsAsString1;
            }
        }

        public void VerifyDefineQuerySelectedClasses(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uISelectedclassesRadioButton = this.UIQueryDefinitionWindow.UISelectedclassesWindow.UISelectedclassesRadioButton;
            WinListItem uIDiscreteExtremeBrighListItem = this.UIQueryDefinitionWindow.UIItemWindow.UIDiscreteExtremeBrighListItem;
            WinMenuItem uIClearAllMenuItem = this.UIItemWindow1.UIContextMenu.UIClearAllMenuItem;
            WinList uIItemList = this.UIQueryDefinitionWindow.UIItemWindow.UIItemList;
            #endregion

            // Select 'Selected classes' radio button
            Assert.AreEqual(isEnabled, uISelectedclassesRadioButton.Selected);

            if (isEnabled)
            {
                // Select 'Discrete Extreme Bright' in 'Unknown Name' list box
                //uIItemList.SelectedItemsAsString = this.DefineQuerySelectedClassesParams.UIItemListSelectedItemsAsString;

                // Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Dark,Low Density Bright' in 'Unknown Name' list box
                uIItemList.SelectedItemsAsString = this.DefineQuerySelectedClassesParams.UIItemListSelectedItemsAsString1;
            }
        }

        public virtual DefineQuerySelectedClassesParams DefineQuerySelectedClassesParams
        {
            get
            {
                if ((this.mDefineQuerySelectedClassesParams == null))
                {
                    this.mDefineQuerySelectedClassesParams = new DefineQuerySelectedClassesParams();
                }
                return this.mDefineQuerySelectedClassesParams;
            }
        }

        private DefineQuerySelectedClassesParams mDefineQuerySelectedClassesParams;

        /// <summary>
        /// EnableQuery - Use 'EnableQueryParams' to pass parameters into this method.
        /// </summary>
        public void EnableQuery(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIApplyqueryCheckBox = this.UIQueryDefinitionWindow.UIApplyqueryWindow.UIApplyqueryCheckBox;
            #endregion

            // Select 'Apply query' check box
            uIApplyqueryCheckBox.Checked = isEnabled;
        }

        public void VerifyEnableQuery(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIApplyqueryCheckBox = this.UIQueryDefinitionWindow.UIApplyqueryWindow.UIApplyqueryCheckBox;
            #endregion

            // Select 'Apply query' check box
            Assert.AreEqual(isEnabled, uIApplyqueryCheckBox.Checked);            
        }


        public virtual EnableQueryParams EnableQueryParams
        {
            get
            {
                if ((this.mEnableQueryParams == null))
                {
                    this.mEnableQueryParams = new EnableQueryParams();
                }
                return this.mEnableQueryParams;
            }
        }

        private EnableQueryParams mEnableQueryParams;

        /// <summary>
        /// LoadLiveModeSettings
        /// </summary>
        public void LoadLiveModeSettings()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(66, 11));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(40, 34));
        }

        /// <summary>
        /// LoadQueryDefinitionWindow
        /// </summary>
        public void LoadQueryDefinitionWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(66, 10));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(36, 81));
        }

        /// <summary>
        /// OngoingDefectsKeepVisible - Use 'OngoingDefectsKeepVisibleParams' to pass parameters into this method.
        /// </summary>
        public void OngoingDefectsKeepVisible(bool isEnable, String time)
        {
            #region Variable Declarations
            WinCheckBox uIKeepvisibleCheckBox = this.UILiveModeSettingsWindow.UIKeepvisibleWindow.UIKeepvisibleCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window1.UIItemEdit;
            #endregion

            // Select 'Keep visible' check box
            uIKeepvisibleCheckBox.Checked = isEnable;

            if (isEnable)
            {
                // Type '6' in 'Unknown Name' text box
                uIItemEdit.Text = time;
            }
        }

        public void VerifyOngoingDefectsKeepVisible(bool isEnable, String time)
        {
            #region Variable Declarations
            WinCheckBox uIKeepvisibleCheckBox = this.UILiveModeSettingsWindow.UIKeepvisibleWindow.UIKeepvisibleCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window1.UIItemEdit;
            #endregion

            // Select 'Keep visible' check box
            Assert.AreEqual(isEnable,  uIKeepvisibleCheckBox.Checked);

            if (isEnable)
            {
                // Type '6' in 'Unknown Name' text box
                Assert.AreEqual(time, uIItemEdit.Text);
            }
        }

        public virtual OngoingDefectsKeepVisibleParams OngoingDefectsKeepVisibleParams
        {
            get
            {
                if ((this.mOngoingDefectsKeepVisibleParams == null))
                {
                    this.mOngoingDefectsKeepVisibleParams = new OngoingDefectsKeepVisibleParams();
                }
                return this.mOngoingDefectsKeepVisibleParams;
            }
        }

        private OngoingDefectsKeepVisibleParams mOngoingDefectsKeepVisibleParams;

        /// <summary>
        /// StopScrollOnSelection - Use 'StopScrollOnSelectionParams' to pass parameters into this method.
        /// </summary>
        public void StopScrollOnSelection(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIStoponselectionCheckBox = this.UILiveModeSettingsWindow.UIStoponselectionWindow.UIStoponselectionCheckBox;
            #endregion

            // Select 'Stop on selection' check box
            uIStoponselectionCheckBox.Checked = isEnabled;
        }

        public void VerifyStopScrollOnSelection(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIStoponselectionCheckBox = this.UILiveModeSettingsWindow.UIStoponselectionWindow.UIStoponselectionCheckBox;
            #endregion

            // Select 'Stop on selection' check box
            Assert.AreEqual(isEnabled, uIStoponselectionCheckBox.Checked);
        }

        public virtual StopScrollOnSelectionParams StopScrollOnSelectionParams
        {
            get
            {
                if ((this.mStopScrollOnSelectionParams == null))
                {
                    this.mStopScrollOnSelectionParams = new StopScrollOnSelectionParams();
                }
                return this.mStopScrollOnSelectionParams;
            }
        }

        private StopScrollOnSelectionParams mStopScrollOnSelectionParams;

        /// <summary>
        /// UseDefaultSideLabels - Use 'UseDefaultSideLabelsParams' to pass parameters into this method.
        /// </summary>
        public void UseDefaultSideLabels()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            WinCheckBox uIUsedefaultCheckBox = this.UISideLabelsWindow.UIUsedefaultWindow.UIUsedefaultCheckBox;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(63, 10));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(54, 61));

            // Select 'Use default' check box
            uIUsedefaultCheckBox.Checked = this.UseDefaultSideLabelsParams.UIUsedefaultCheckBoxChecked;
        }

        public virtual UseDefaultSideLabelsParams UseDefaultSideLabelsParams
        {
            get
            {
                if ((this.mUseDefaultSideLabelsParams == null))
                {
                    this.mUseDefaultSideLabelsParams = new UseDefaultSideLabelsParams();
                }
                return this.mUseDefaultSideLabelsParams;
            }
        }

        private UseDefaultSideLabelsParams mUseDefaultSideLabelsParams;

        /// <summary>
        /// VerifySideLabelsDisplayed - Use 'VerifySideLabelsDisplayedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifySideLabelsDisplayed()
        {
            #region Variable Declarations
            WinClient uILaneViewerClient = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UIItemWindow.UILaneViewerClient;
            #endregion

            // Verify that 'Lane Viewer' client's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifySideLabelsDisplayedExpectedValues.UILaneViewerClientExists, uILaneViewerClient.Exists);
        }

        public virtual VerifySideLabelsDisplayedExpectedValues VerifySideLabelsDisplayedExpectedValues
        {
            get
            {
                if ((this.mVerifySideLabelsDisplayedExpectedValues == null))
                {
                    this.mVerifySideLabelsDisplayedExpectedValues = new VerifySideLabelsDisplayedExpectedValues();
                }
                return this.mVerifySideLabelsDisplayedExpectedValues;
            }
        }

        private VerifySideLabelsDisplayedExpectedValues mVerifySideLabelsDisplayedExpectedValues;

        /// <summary>
        /// CloseDefectViewer
        /// </summary>
        public void CloseDefectViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole4CamWindow.UIDefectViewerView1Window.UICloseButton;
            #endregion

            if (uICloseButton.Exists)
            {
                // Click 'Close' button
                Mouse.Click(uICloseButton, new Point(14, 9));
            }       
        }

        /// <summary>
        /// SelectDefectFromLaneViewer
        /// </summary>
        public void SelectDefectFromLaneViewer()
        {
            #region Variable Declarations
            WinClient uILaneViewerClient = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UIItemWindow1.UILaneViewerClient;
            #endregion

            // Click 'Lane Viewer' client
            Mouse.Click(uILaneViewerClient, new Point(238, 109));
}
    }
    /// <summary>
    /// Parameters to be passed into 'AutomaticallyResumeLiveMode'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AutomaticallyResumeLiveModeParams
    {

        #region Fields
        /// <summary>
        /// Select 'Automatically resume live mode' check box
        /// </summary>
        public bool UIAutomaticallyresumelCheckBoxChecked = true;

        /// <summary>
        /// Type '20' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "20";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineCustomSideLabels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineCustomSideLabelsParams
    {

        #region Fields
        /// <summary>
        /// Type 'TestLeftSidLabes' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "TestLeftSidLabes";

        /// <summary>
        /// Type 'TestRightSideLabels' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "TestRightSideLabels";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryAllDefects'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryAllDefectsParams
    {

        #region Fields
        /// <summary>
        /// Select 'All' radio button
        /// </summary>
        public bool UIAllRadioButtonSelected = true;
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
        /// Type '6' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "6";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryLanesParams
    {

        #region Fields
        /// <summary>
        /// Select '2,3,4,5,6,7,8,9' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "2,3,4,5,6,7,8,9";

        /// <summary>
        /// Select '3,4,5,6,7,8,9' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString1 = "3,4,5,6,7,8,9";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQueryOnlyRepeating'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryOnlyRepeatingParams
    {

        #region Fields
        /// <summary>
        /// Select 'Only repeating' radio button
        /// </summary>
        public bool UIOnlyrepeatingRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQuerySelectedClasses'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQuerySelectedClassesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Selected classes' radio button
        /// </summary>
        public bool UISelectedclassesRadioButtonSelected = true;

        /// <summary>
        /// Select 'Discrete Extreme Bright' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Discrete Extreme Bright";

        /// <summary>
        /// Select 'Discrete Extreme Bright,Discrete Bright,Discrete Extreme Dark,Low Density Bright' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString1 = "Discrete Extreme Bright,Discrete Bright,Discrete Extreme Dark,Low Density Bright";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnableQuery'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnableQueryParams
    {

        #region Fields
        /// <summary>
        /// Select 'Apply query' check box
        /// </summary>
        public bool UIApplyqueryCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'OngoingDefectsKeepVisible'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class OngoingDefectsKeepVisibleParams
    {

        #region Fields
        /// <summary>
        /// Select 'Keep visible' check box
        /// </summary>
        public bool UIKeepvisibleCheckBoxChecked = true;

        /// <summary>
        /// Type '6' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "6";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'StopScrollOnSelection'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class StopScrollOnSelectionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Stop on selection' check box
        /// </summary>
        public bool UIStoponselectionCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'UseDefaultSideLabels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UseDefaultSideLabelsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Use default' check box
        /// </summary>
        public bool UIUsedefaultCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifySideLabelsDisplayed'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifySideLabelsDisplayedExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Lane Viewer' client's property 'Exists' equals 'True'
        /// </summary>
        public bool UILaneViewerClientExists = true;
        #endregion
}
}
