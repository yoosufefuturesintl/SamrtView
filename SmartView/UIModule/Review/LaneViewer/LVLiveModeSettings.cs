namespace SmartView.UIModule.Review.LaneViewer.LVLiveModeSettingsClasses
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
    public partial class LVLiveModeSettings
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
            Mouse.Click(uIOKButton, new Point(18, 16));
        }

        /// <summary>
        /// AutomaticallyResumeLiveMode - Use 'AutomaticallyResumeLiveModeParams' to pass parameters into this method.
        /// </summary>
        public void AutomaticallyResumeLiveMode()
        {
            #region Variable Declarations
            WinCheckBox uIAutomaticallyresumelCheckBox = this.UILiveModeSettingsWindow.UIAutomaticallyresumelWindow.UIAutomaticallyresumelCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window.UIItemEdit;
            #endregion

            // Select 'Automatically resume live mode' check box
            uIAutomaticallyresumelCheckBox.Checked = this.AutomaticallyResumeLiveModeParams.UIAutomaticallyresumelCheckBoxChecked;

            // Type '50' in 'Unknown Name' text box
            uIItemEdit.Text = this.AutomaticallyResumeLiveModeParams.UIItemEditText;
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
        /// LoadLiveModeSettingWindow
        /// </summary>
        public void LoadLiveModeSettingWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewReview4CameWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(64, 12));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(50, 37));
        }

        /// <summary>
        /// OngoingDefectsKeepVisible - Use 'OngoingDefectsKeepVisibleParams' to pass parameters into this method.
        /// </summary>
        public void OngoingDefectsKeepVisible()
        {
            #region Variable Declarations
            WinCheckBox uIKeepvisibleCheckBox = this.UILiveModeSettingsWindow.UIKeepvisibleWindow.UIKeepvisibleCheckBox;
            WinEdit uIItemEdit = this.UILiveModeSettingsWindow.UIText1Window1.UIItemEdit;
            #endregion

            // Select 'Keep visible' check box
            uIKeepvisibleCheckBox.Checked = this.OngoingDefectsKeepVisibleParams.UIKeepvisibleCheckBoxChecked;

            // Type '20' in 'Unknown Name' text box
            uIItemEdit.Text = this.OngoingDefectsKeepVisibleParams.UIItemEditText;
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
        /// StopOnSelection - Use 'StopOnSelectionParams' to pass parameters into this method.
        /// </summary>
        public void StopOnSelection(bool isStopOnSelectionEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIStoponselectionCheckBox = this.UILiveModeSettingsWindow.UIStoponselectionWindow.UIStoponselectionCheckBox;
            #endregion

            // Select 'Stop on selection' check box
            uIStoponselectionCheckBox.Checked = isStopOnSelectionEnabled;
        }

        public virtual StopOnSelectionParams StopOnSelectionParams
        {
            get
            {
                if ((this.mStopOnSelectionParams == null))
                {
                    this.mStopOnSelectionParams = new StopOnSelectionParams();
                }
                return this.mStopOnSelectionParams;
            }
        }

        private StopOnSelectionParams mStopOnSelectionParams;
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
        /// Type '50' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "50";
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
        /// Type '20' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "20";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'StopOnSelection'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class StopOnSelectionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Stop on selection' check box
        /// </summary>
        public bool UIStoponselectionCheckBoxChecked = true;
        #endregion
}
}
