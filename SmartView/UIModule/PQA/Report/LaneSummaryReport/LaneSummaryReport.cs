namespace SmartView.UIModule.PQA.Report.LaneSummaryReport.LaneSummaryReportClasses
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
}
