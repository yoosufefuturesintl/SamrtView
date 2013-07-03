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
    public class LaneSummaryReportTest:PQATestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public LaneSummaryReportTest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        [TestMethod]
        public void LoadTestLauncLaneSummaryReport()
        {
            TestCaseExternalID = "CGN-13";
            Applications.CloseAllApplication("PQA");
            PQAWebViewer.LaunchPQA(PQAExePath, PQAAlternateExePath);

            PQAWebViewer.LaunchSmartViewDataSelectorWindow();
           // PQASmartViewDataSelector.ChangeDataBase(bool.Parse(MasterData.InPQAChangeDB), MasterData.PQADBServer, MasterData.PQADB);
            PQASmartViewDataSelector.CheckStartDateCheckBox(false);
            PQASmartViewDataSelector.SearchByRecipeAndClickOk(MasterData.PQAInspection);

            LaneSummaryReport.ClickReportButtonInPQAToolBar();
            PQAInspectionSummaryReport.LoadStandardReportTabInReportBrowser();
            LaneSummaryReport.LoadLaneSummaryReport();
            //inspectionSummaryReport.MaximizedInspectionSummaryWindow();
            ReportWizardReportOptions.WaitForReportWizardIconIsEnabled();
            LaneSummaryReport.WaitForRepotingOptionsAreEnabled();
            Thread.Sleep(10000);

            
            Applications.CloseAllApplication("PQA");
        }

        [TestMethod]
        public void TestPQAReportLauncLaneSummaryReport()
        {
            TestCaseExternalID = "CGN-13";
            LaneSummaryReport.ClickReportButtonInPQAToolBar();
            PQAInspectionSummaryReport.LoadStandardReportTabInReportBrowser();
            LaneSummaryReport.LoadLaneSummaryReport();
            //PQASmartViewDataSelector.SearchByInspectionName(SharedInspectionName);
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryShowTable()
        {
            TestCaseExternalID = "CGN-15";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowTable(true);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryHideTable()
        {
            TestCaseExternalID = "CGN-14";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowTable(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryShowGraph() {
            TestCaseExternalID = "CGN-17";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowGraph(true);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryHideGraph()
        {
            TestCaseExternalID = "CGN-16";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowGraph(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }


        [TestMethod]
        public void TestPQAReportLaneSummaryShowEmptyLane()
        {
            TestCaseExternalID = "CGN-19";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowEmptyLanes(true);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryHideEmptyLane()
        {
            TestCaseExternalID = "CGN-18";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowEmptyLanes(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryShowOutOfRangeLanes()
        {
            TestCaseExternalID = "CGN-20";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowOutOfRangeLanes(true);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryHideOutOfRangeLanes()
        {
            TestCaseExternalID = "CGN-21";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.ShowOutOfRangeLanes(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryGroupByView()
        {
            TestCaseExternalID = "CGN-22";
            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.GroupByView(true);
            ReportWizardReportOptions.ApplyWizardChanges();

            ReportWizardReportOptions.LoadReportWizard();
            ReportWizardReportOptions.LoadReportOptionsTab();
            ReportWizardReportOptions.GroupByView(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryHighlightRows()
        {
            TestCaseExternalID = "CGN-23";
            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.HighlightRows(true);
            ReportWizardReportOptions.ApplyWizardChanges();

            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.HighlightRows(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryColumnHeaderRotation()
        {
            TestCaseExternalID = "CGN-24";
            String[] orientations = { "Vertical", "Automatic", "Horizontal"};
            for (int index = 0; index < orientations.Length; index++)
            {
                ReportWizardSectionFormatting.LoadReportWizard();
                ReportWizardSectionFormatting.LoadSectionFormattingTab();
                ReportWizardSectionFormatting.SelectSectionToFormat();
                ReportWizardSectionFormatting.DefineColumnHeaderRotation(orientations[index]);
                ReportWizardReportOptions.ApplyWizardChanges();
            }
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryDisplayTotals()
        {
            TestCaseExternalID = "CGN-25";
            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.DisplayTotals(true);
            ReportWizardReportOptions.ApplyWizardChanges();

            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.DisplayTotals(false);
            ReportWizardReportOptions.ApplyWizardChanges();
        }

        [TestMethod]
        public void TestPQAReportLaneSummaryFlipRowsAndColumns()
        {
            TestCaseExternalID = "CGN-26";
            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.FlipRowsAndColumns(true);
            ReportWizardReportOptions.ApplyWizardChanges();

            ReportWizardSectionFormatting.LoadReportWizard();
            ReportWizardSectionFormatting.LoadSectionFormattingTab();
            ReportWizardSectionFormatting.SelectSectionToFormat();
            ReportWizardSectionFormatting.FlipRowsAndColumns(false);
            ReportWizardReportOptions.ApplyWizardChanges();
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
