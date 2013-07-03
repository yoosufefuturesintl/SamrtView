namespace SmartView.UIModule.PQA.WebViewer.WebViewerClasses
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
    public partial class WebViewer
    {

        /// <summary>
        /// LaunchPQA - Use 'LaunchPQAParams' to pass parameters into this method.
        /// </summary>
        public void LaunchPQA(String PQAExePath, String PQAAlternateExePath)
        {
            #region Variable Declarations
            WinButton uISelectDataButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UISelectDataButton;
            WinButton uISearchButton = this.UISmartViewDataSelectoWindow.UISearchWindow.UISearchButton;
            WinListItem uISv60_15_51ListItem = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UISv60_15_51ListItem;
            #endregion

            Playback.PlaybackSettings.DelayBetweenActions = 1000;
            Playback.PlaybackSettings.SearchTimeout = 60000;

            // Launch '%SmartViewDir%\PQA.exe'
            ApplicationUnderTest pQAApplication = ApplicationUnderTest.Launch(PQAExePath, PQAAlternateExePath);

            //// Click 'Select Data' button
            //Mouse.Click(uISelectDataButton, new Point(22, 22));

            //// Click '&Search' button
            //Mouse.Click(uISearchButton, new Point(28, 9));

            //// Double-Click 'Sv60_15_5-1' list item
            //Mouse.DoubleClick(uISv60_15_51ListItem, new Point(214, 11));
        }

        public void LaunchSmartViewDataSelectorWindow()
        {
            WinButton uISelectDataButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UISelectDataButton;
            // Click 'Select Data' button
            Mouse.Click(uISelectDataButton, new Point(22, 22));
        }

        public virtual LaunchPQAParams LaunchPQAParams
        {
            get
            {
                if ((this.mLaunchPQAParams == null))
                {
                    this.mLaunchPQAParams = new LaunchPQAParams();
                }
                return this.mLaunchPQAParams;
            }
        }

        private LaunchPQAParams mLaunchPQAParams;

        /// <summary>
        /// AddDefectRatePlot - Use 'AddDefectRatePlotParams' to pass parameters into this method.
        /// </summary>
        public void AddDefectRatePlot()
        {
            #region Variable Declarations
            WinWindow uIViewportWindow = this.UISmartViewProductionQWindow.UISv60_15_51Window.UISv60_15_51Client.UIViewportWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            WinCheckBox uIShowplotCheckBox = this.UIDefectRateOptionsWindow.UIShowplotWindow.UIShowplotCheckBox;
            WinButton uIApplyButton = this.UIDefectRateOptionsWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UIDefectRateOptionsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'viewport' window
            Mouse.Click(uIViewportWindow, new Point(66, 11));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(38, 97));

            // Select 'Show plot' check box
            uIShowplotCheckBox.Checked = this.AddDefectRatePlotParams.UIShowplotCheckBoxChecked;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(34, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(53, 10));
        }

        public virtual AddDefectRatePlotParams AddDefectRatePlotParams
        {
            get
            {
                if ((this.mAddDefectRatePlotParams == null))
                {
                    this.mAddDefectRatePlotParams = new AddDefectRatePlotParams();
                }
                return this.mAddDefectRatePlotParams;
            }
        }

        private AddDefectRatePlotParams mAddDefectRatePlotParams;

        /// <summary>
        /// VerifyDefectRatePlotIsDisplayed - Use 'VerifyDefectRatePlotIsDisplayedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyDefectRatePlotIsDisplayed()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewProductionQWindow.UISv60_15_51Window.UIItemWindow1.UIViewportClient.UIItemWindow;
            #endregion

            // Verify that 'Unknown Name' window's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyDefectRatePlotIsDisplayedExpectedValues.UIItemWindowExists, uIItemWindow.Exists);
        }

        public virtual VerifyDefectRatePlotIsDisplayedExpectedValues VerifyDefectRatePlotIsDisplayedExpectedValues
        {
            get
            {
                if ((this.mVerifyDefectRatePlotIsDisplayedExpectedValues == null))
                {
                    this.mVerifyDefectRatePlotIsDisplayedExpectedValues = new VerifyDefectRatePlotIsDisplayedExpectedValues();
                }
                return this.mVerifyDefectRatePlotIsDisplayedExpectedValues;
            }
        }

        private VerifyDefectRatePlotIsDisplayedExpectedValues mVerifyDefectRatePlotIsDisplayedExpectedValues;

        /// <summary>
        /// VerifyWebViewerIsExist - Use 'VerifyWebViewerIsExistExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyWebViewerIsExist()
        {
            #region Variable Declarations
            WinClient uIViewportClient = this.UISmartViewProductionQWindow.UISv60_15_51Window.UIItemWindow.UIViewportClient;
            #endregion

            // Verify that 'viewport' client's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyWebViewerIsExistExpectedValues.UIViewportClientExists, uIViewportClient.Exists);
        }

        public virtual VerifyWebViewerIsExistExpectedValues VerifyWebViewerIsExistExpectedValues
        {
            get
            {
                if ((this.mVerifyWebViewerIsExistExpectedValues == null))
                {
                    this.mVerifyWebViewerIsExistExpectedValues = new VerifyWebViewerIsExistExpectedValues();
                }
                return this.mVerifyWebViewerIsExistExpectedValues;
            }
        }

        private VerifyWebViewerIsExistExpectedValues mVerifyWebViewerIsExistExpectedValues;

        /// <summary>
        /// DisplayWebViewer
        /// </summary>
        public void DisplayWebViewer()
        {
            #region Variable Declarations
            WinButton uIWebViewerButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UIWebViewerButton;
            #endregion

            // Click 'Web Viewer' button
            Mouse.Click(uIWebViewerButton, new Point(27, 22));
        }

        /// <summary>
        /// CloseWebViewer - Use 'CloseWebViewerExpectedValues' to pass parameters into this method.
        /// </summary>
        public void CloseWebViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UISv60_15_51Window.UICloseButton;
            #endregion

            // Verify that 'Close' button's property 'Name' equals 'Close'
            //Assert.AreEqual(this.CloseWebViewerExpectedValues.UICloseButtonName, uICloseButton.Name);
            Mouse.Click(uICloseButton);
        }

        public virtual CloseWebViewerExpectedValues CloseWebViewerExpectedValues
        {
            get
            {
                if ((this.mCloseWebViewerExpectedValues == null))
                {
                    this.mCloseWebViewerExpectedValues = new CloseWebViewerExpectedValues();
                }
                return this.mCloseWebViewerExpectedValues;
            }
        }

        private CloseWebViewerExpectedValues mCloseWebViewerExpectedValues;

        /// <summary>
        /// VerifyLoadedInspectionNameInWebViewer - Use 'VerifyLoadedInspectionNameInWebViewerExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyLoadedInspectionNameInWebViewer()
        {
            #region Variable Declarations
            WinTitleBar uITest12TitleBar = this.UISmartViewProductionQWindow.UISv60_15_51Window.UITest12TitleBar;
            #endregion

            // Verify that 'test-12' title bar's property 'DisplayText' equals 'test-12'
            Assert.AreEqual(this.VerifyLoadedInspectionNameInWebViewerExpectedValues.UITest12TitleBarDisplayText, uITest12TitleBar.DisplayText);
        }

        public virtual VerifyLoadedInspectionNameInWebViewerExpectedValues VerifyLoadedInspectionNameInWebViewerExpectedValues
        {
            get
            {
                if ((this.mVerifyLoadedInspectionNameInWebViewerExpectedValues == null))
                {
                    this.mVerifyLoadedInspectionNameInWebViewerExpectedValues = new VerifyLoadedInspectionNameInWebViewerExpectedValues();
                }
                return this.mVerifyLoadedInspectionNameInWebViewerExpectedValues;
            }
        }

        private VerifyLoadedInspectionNameInWebViewerExpectedValues mVerifyLoadedInspectionNameInWebViewerExpectedValues;

        /// <summary>
        /// CloseSmartViewPQA
        /// </summary>
        public void CloseSmartViewPQA()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UISmartViewProductionQTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(20, 7));
}
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchPQA'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LaunchPQAParams
    {

        #region Fields
        /// <summary>
        /// Launch '%SmartViewDir%\PQA.exe'
        /// </summary>
        public string ExePath = "D:\\SmartView\\PQA.exe";

        /// <summary>
        /// Launch '%SmartViewDir%\PQA.exe'
        /// </summary>
        public string AlternateExePath = "%SmartViewDir%\\PQA.exe";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'AddDefectRatePlot'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AddDefectRatePlotParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show plot' check box
        /// </summary>
        public bool UIShowplotCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyDefectRatePlotIsDisplayed'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyDefectRatePlotIsDisplayedExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Unknown Name' window's property 'Exists' equals 'True'
        /// </summary>
        public bool UIItemWindowExists = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyWebViewerIsExist'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyWebViewerIsExistExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'viewport' client's property 'Exists' equals 'True'
        /// </summary>
        public bool UIViewportClientExists = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'CloseWebViewer'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CloseWebViewerExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Close' button's property 'Name' equals 'Close'
        /// </summary>
        public string UICloseButtonName = "Close";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyLoadedInspectionNameInWebViewer'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyLoadedInspectionNameInWebViewerExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'test-12' title bar's property 'DisplayText' equals 'test-12'
        /// </summary>
        public string UITest12TitleBarDisplayText = "test-12";
        #endregion
}
}
