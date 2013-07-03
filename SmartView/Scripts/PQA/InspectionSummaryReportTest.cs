using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using SmartView.Library;
using System.IO;


namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class InspectionSummaryReportTest:PQATestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public InspectionSummaryReportTest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        
        [TestMethod]
        public void TestPQAReportLaunchInspectionSummaryReport()
        {
            TestCaseID = "CGN-8";
            PQAInspectionSummaryReport.LoadTheReportSelectionWindow();
            PQAInspectionSummaryReport.DisplayInspectionSummaryReport();
            //inspectionSummaryReport.MaximizedInspectionSummaryWindow();
            PQAInspectionSummaryReport.VerifyInspectionSummaryReportLoadedProperly();
            //inspectionSummaryReport.CloseInspectionSummaryReportWindow();
        }      

        [TestMethod]
        public void TestPQAReportExportInspectionSummaryReportToExcel()
        {
            TestCaseID = "CGN-7";
            //PQAInspectionSummaryReport.ExportInspectionSummaryToExcel(ProjectPath +"\\TestData\\" + RandomNumber);
           // PQAInspectionSummaryReport.CloseExcelFile(RandomNumber);
        }

        [TestMethod]
        public void TestPQAReportCreateDataFilter()
        {
            TestCaseID = "CGN-9";
            PQAInspectionSummaryReport.CreateDataFilter("DataFilter" + RandomNumber);
        }

        [TestMethod]
        public void TestPQAReportCreateCustomInspectionSummaryReport()
        {
            TestCaseID = "CGN-27";
            PQAInspectionSummaryReport.CreateCustomInspectionSummaryReport(CustomReportName);
        }

        [TestMethod]
        public void TestPQAReportRevertWizardSettings()
        {
            TestCaseID = "CGN-10";
            PQAInspectionSummaryReport.RevertReportWizardSettings();
            PQAInspectionSummaryReport.LoadReportWizardWindow();
            PQAInspectionSummaryReport.LoadReportOptionsTabInReportWizardWindow();
            PQAInspectionSummaryReport.VerifyDefultSettingsOfTheReportOptionsTab();
            PQAInspectionSummaryReport.CloseReportWizardWindow();
        }

        [TestMethod]
        public void TestPQAReportGnereteCustomReport()
        {
            TestCaseID = "CGN-28";
            PQAInspectionSummaryReport.LoadTheReportSelectionWindow();
            PQAInspectionSummaryReport.LoadCustomReportTabInReportBrowser();
            PQAInspectionSummaryReport.GenerateCustomeReport(CustomReportName);
        }

        [TestMethod]
        public void TestPQAReportBookmarkDropDown()
        {
            TestCaseID = "CGN-007";
            PQAInspectionSummaryReport.NavigateTo("$Report.Control.Graph");
        }

        [TestMethod]
        public void TestPQAReportDeleteCreatedCustomReport()
        {
            TestCaseID = "CGN-29";
            PQAInspectionSummaryReport.DeleteCustomReport(CustomReportName);
            PQAInspectionSummaryReport.VerifyCustomReportIsAvailableInCustomReportListInReportBrowser(CustomReportName);
            PQAInspectionSummaryReport.CloseReportBrowserWindow();
        }

        [TestMethod]
        public void TestPQAReportInspectionSummaryReportPushpin()
        {
            TestCaseID = "CGN-11";
            PQAInspectionSummaryReport.PushpinCurrentReport();
            PQAInspectionSummaryReport.VerifyControlsStatusInReportToolbar(false);
        }

        [TestMethod]
        public void PQACloseReportWindow() {

            TestCaseID = "007";
            PQAInspectionSummaryReport.CloseInspectionSummarryReport();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            if(IsUpdateTestResult.Equals("true")){
                String testStatus = testContextInstance.CurrentTestOutcome.ToString();
                TC.UpdateTCStatus(TestCaseID, testStatus,ErrorMessage);
            }
        }

        [TestMethod]
        public void TestCloseReportAndPQA()
        {
            PQAInspectionSummaryReport.CloseInspectionSummarryReport();
            PQAWebViewer.CloseWebViewer();
            PQAWebViewer.CloseSmartViewPQA();
        }
       

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        
    }
}
