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
using SmartView.Test.Library.Application;
using System.IO;
using System.Threading;
using SmartView.Test.TestData;


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
            //Playback.PlaybackSettings.DelayBetweenActions = 3000;
            //Playback.PlaybackSettings.SearchTimeout = 60000;
        }
        [TestMethod]
        public void LoadTestInspectionSummaryReport()
        {
            TestCaseExternalID = "CGN-8";
            Applications.CloseAllApplication("PQA");
            PQAWebViewer.LaunchPQA(PQAExePath, PQAAlternateExePath);

            PQAWebViewer.LaunchSmartViewDataSelectorWindow();
            //PQASmartViewDataSelector.ChangeDataBase(bool.Parse(MasterData.InPQAChangeDB), MasterData.PQADBServer, MasterData.PQADB);
            PQASmartViewDataSelector.CheckStartDateCheckBox(false);
            PQASmartViewDataSelector.SearchByRecipeAndClickOk(MasterData.PQAInspection);

            PQAInspectionSummaryReport.LoadTheReportSelectionWindow();
            PQAInspectionSummaryReport.DisplayInspectionSummaryReport();
            //inspectionSummaryReport.MaximizedInspectionSummaryWindow();
            PQAInspectionSummaryReport.VerifyInspectionSummaryReportLoadedProperly();
            PQAInspectionSummaryReport.VerifyInspectionSummaryToolBarControls();
            Thread.Sleep(10000);
            Applications.CloseAllApplication("PQA");      
        }
        
        [TestMethod]
        public void TestPQAReportLaunchInspectionSummaryReport()
        {
            TestCaseExternalID = "CGN-8";
            PQAInspectionSummaryReport.LoadTheReportSelectionWindow();
            PQAInspectionSummaryReport.DisplayInspectionSummaryReport();
            //inspectionSummaryReport.MaximizedInspectionSummaryWindow();
            PQAInspectionSummaryReport.VerifyInspectionSummaryReportLoadedProperly();
            //inspectionSummaryReport.CloseInspectionSummaryReportWindow();
        }      

        [TestMethod]
        public void TestPQAReportExportInspectionSummaryReportToExcel()
        {
            TestCaseExternalID = "CGN-7";
            //PQAInspectionSummaryReport.ExportInspectionSummaryToExcel(ProjectPath +"\\TestData\\" + RandomNumber);
           // PQAInspectionSummaryReport.CloseExcelFile(RandomNumber);
        }

        [TestMethod]
        public void TestPQAReportCreateDataFilter()
        {
            TestCaseExternalID = "CGN-9";
            PQAInspectionSummaryReport.CreateDataFilter("DataFilter" + RandomNumber);
        }

        [TestMethod]
        public void TestPQAReportCreateCustomInspectionSummaryReport()
        {
            TestCaseExternalID = "CGN-27";
            PQAInspectionSummaryReport.CreateCustomInspectionSummaryReport(CustomReportName);
        }

        [TestMethod]
        public void TestPQAReportRevertWizardSettings()
        {
            TestCaseExternalID = "CGN-10";
            PQAInspectionSummaryReport.RevertReportWizardSettings();
            PQAInspectionSummaryReport.LoadReportWizardWindow();
            PQAInspectionSummaryReport.LoadReportOptionsTabInReportWizardWindow();
            PQAInspectionSummaryReport.VerifyDefultSettingsOfTheReportOptionsTab();
            PQAInspectionSummaryReport.CloseReportWizardWindow();
        }

        [TestMethod]
        public void TestPQAReportGnereteCustomReport()
        {
            TestCaseExternalID = "CGN-28";
            PQAInspectionSummaryReport.LoadTheReportSelectionWindow();
            PQAInspectionSummaryReport.LoadCustomReportTabInReportBrowser();
            PQAInspectionSummaryReport.GenerateCustomeReport(CustomReportName);
        }

        [TestMethod]
        public void TestPQAReportBookmarkDropDown()
        {
            TestCaseExternalID = "CGN-007";
            PQAInspectionSummaryReport.NavigateTo("$Report.Control.Graph");
        }

        [TestMethod]
        public void TestPQAReportDeleteCreatedCustomReport()
        {
            TestCaseExternalID = "CGN-29";
            PQAInspectionSummaryReport.DeleteCustomReport(CustomReportName);
            PQAInspectionSummaryReport.VerifyCustomReportIsAvailableInCustomReportListInReportBrowser(CustomReportName);
            PQAInspectionSummaryReport.CloseReportBrowserWindow();
        }

        [TestMethod]
        public void TestPQAReportInspectionSummaryReportPushpin()
        {
            TestCaseExternalID = "CGN-11";
            PQAInspectionSummaryReport.PushpinCurrentReport();
            PQAInspectionSummaryReport.VerifyControlsStatusInReportToolbar(false);
        }

        [TestMethod]
        public void PQACloseReportWindow() {

            TestCaseExternalID = "007";
            PQAInspectionSummaryReport.CloseInspectionSummarryReport();
        }

       

        [TestMethod]
        public void TestCloseReportAndPQA()
        {
            PQAInspectionSummaryReport.CloseInspectionSummarryReport();
            PQAWebViewer.CloseWebViewer();
            PQAWebViewer.CloseSmartViewPQA();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            //CleanUp(TestContext);
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
