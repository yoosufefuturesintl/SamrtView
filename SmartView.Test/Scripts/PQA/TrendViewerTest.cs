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
    public class TrendViewerTest:PQATestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TrendViewerTest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

    

        [TestMethod]
        public void TestPQATVLaunchTrendViewer()
        {
            TestCaseExternalID = "CGN-31";
            PQATrendViewer.GenerateTrendViewer();
            PQATrendViewer.ChangeToSharedSelection();
        }

        [TestMethod]
        public void TestPQATVChangeTrendPlotTypeToBar()
        {
            TestCaseExternalID = "CGN-32";
            PQATrendWizard.LoardTrendWizard();
            PQATrendWizard.DisplayBarPlotInTrendViewer();
            PQATrendWizard.ClickFinishButton();
            PQATrendViewer.ClickRunButtonInTrendViewerToolBar();

        }
        [TestMethod]
        public void TestPQATVShowLegend()
        {
            TestCaseExternalID = "CGN-33";
            PQATrendWizard.SelectShowLegendCheckBox();
            PQATrendViewer.VerifyLegendIsShownInTrendViewer(true);
        }

        [TestMethod]
        public void LoadTestTrendViewer()
        {
            TestCaseExternalID = "CGN-8";
            Applications.CloseAllApplication("PQA");
            PQAWebViewer.LaunchPQA(PQAExePath, PQAAlternateExePath);

            PQATrendViewer.GenerateTrendViewer();
            //PQATrendWizard.DefineQueryByLastDuration();
            PQATrendWizard.DefineQuery(MasterData.PQAInspection);           

            Thread.Sleep(5000);
            PQATrendViewer.WaitForEnableRunButtonInTrendViewerToolBar();
         
            Thread.Sleep(10000);            
            Applications.CloseAllApplication("PQA");
           
        }

        [TestCleanup]
        public void TestCleanUp()
        {
           // CleanUp(TestContext);
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
