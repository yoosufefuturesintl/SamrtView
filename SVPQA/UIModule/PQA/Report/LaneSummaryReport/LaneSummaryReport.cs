namespace SVPQA.UIModule.PQA.Report.LaneSummaryReport.LaneSummaryReportClasses
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
    public partial class LaneSummaryReport
    {

        /// <summary>
        /// ClickReportButtonInPQAToolBar
        /// </summary>
        public void ClickReportButtonInPQAToolBar()
        {
            #region Variable Declarations
            WinButton uIReportsButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UIReportsButton;
            #endregion

            // Click 'Reports' button
            Mouse.Click(uIReportsButton, new Point(20, 19));
        }

        /// <summary>
        /// LoadLaneSummaryReport - Use 'LoadLaneSummaryReportParams' to pass parameters into this method.
        /// </summary>
        public void LoadLaneSummaryReport()
        {
            #region Variable Declarations
            WinList uIListReportsList = this.UIReportBrowserWindow.UIListReportsWindow.UIListReportsList;
            WinButton uIPreviewButton = this.UIReportBrowserWindow.UIPreviewWindow.UIPreviewButton;
            #endregion

            // Select 'Lane Summary' in 'listReports' list box
            uIListReportsList.SelectedItemsAsString = this.LoadLaneSummaryReportParams.UIListReportsListSelectedItemsAsString;

            // Click 'Preview' button
            Mouse.Click(uIPreviewButton, new Point(49, 17));
        }

        public virtual LoadLaneSummaryReportParams LoadLaneSummaryReportParams
        {
            get
            {
                if ((this.mLoadLaneSummaryReportParams == null))
                {
                    this.mLoadLaneSummaryReportParams = new LoadLaneSummaryReportParams();
                }
                return this.mLoadLaneSummaryReportParams;
            }
        }

        private LoadLaneSummaryReportParams mLoadLaneSummaryReportParams;

        /// <summary>
        /// LoadWizard
        /// </summary>
        public void LoadWizard()
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(9, 11));
        }

        /// <summary>
        /// WaitForRepotingOptionsAreEnabled - Use 'WaitForRepotingOptionsAreEnabledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void WaitForRepotingOptionsAreEnabled()
        {
            #region Variable Declarations
            WinButton uIRunreportButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIRunreportButton;
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            WinButton uIPageSetupButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIPageSetupButton;
            WinButton uIPrintButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIPrintButton;
            #endregion

            uIRunreportButton.WaitForControlEnabled();
            uIWizardButton.WaitForControlEnabled();

            uIPageSetupButton.WaitForControlEnabled();
            uIPrintButton.WaitForControlEnabled();

            // Verify that 'Run report' button's property 'Enabled' equals 'True'
            //Assert.AreEqual(this.WaitForRepotingOptionsAreEnabledExpectedValues.UIRunreportButtonEnabled, uIRunreportButton.Enabled);

            //// Verify that 'Wizard' button's property 'Enabled' equals 'True'
            //Assert.AreEqual(this.WaitForRepotingOptionsAreEnabledExpectedValues.UIWizardButtonEnabled, uIWizardButton.Enabled);

            //// Verify that 'Page Setup...' button's property 'Enabled' equals 'True'
            //Assert.AreEqual(this.WaitForRepotingOptionsAreEnabledExpectedValues.UIPageSetupButtonEnabled, uIPageSetupButton.Enabled);

            //// Verify that 'Print' button's property 'Enabled' equals 'True'
            //Assert.AreEqual(this.WaitForRepotingOptionsAreEnabledExpectedValues.UIPrintButtonEnabled, uIPrintButton.Enabled);
        }

        public virtual WaitForRepotingOptionsAreEnabledExpectedValues WaitForRepotingOptionsAreEnabledExpectedValues
        {
            get
            {
                if ((this.mWaitForRepotingOptionsAreEnabledExpectedValues == null))
                {
                    this.mWaitForRepotingOptionsAreEnabledExpectedValues = new WaitForRepotingOptionsAreEnabledExpectedValues();
                }
                return this.mWaitForRepotingOptionsAreEnabledExpectedValues;
            }
        }

        private WaitForRepotingOptionsAreEnabledExpectedValues mWaitForRepotingOptionsAreEnabledExpectedValues;
    }
    /// <summary>
    /// Parameters to be passed into 'LoadLaneSummaryReport'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LoadLaneSummaryReportParams
    {

        #region Fields
        /// <summary>
        /// Select 'Lane Summary' in 'listReports' list box
        /// </summary>
        public string UIListReportsListSelectedItemsAsString = "Lane Summary";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'WaitForRepotingOptionsAreEnabled'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class WaitForRepotingOptionsAreEnabledExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Run report' button's property 'Enabled' equals 'True'
        /// </summary>
        public bool UIRunreportButtonEnabled = true;

        /// <summary>
        /// Verify that 'Wizard' button's property 'Enabled' equals 'True'
        /// </summary>
        public bool UIWizardButtonEnabled = true;

        /// <summary>
        /// Verify that 'Page Setup...' button's property 'Enabled' equals 'True'
        /// </summary>
        public bool UIPageSetupButtonEnabled = true;

        /// <summary>
        /// Verify that 'Print' button's property 'Enabled' equals 'True'
        /// </summary>
        public bool UIPrintButtonEnabled = true;
        #endregion
}
}
