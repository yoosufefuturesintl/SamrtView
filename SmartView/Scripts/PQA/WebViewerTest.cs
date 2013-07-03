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
    public class WebViewerTest:PQATestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public WebViewerTest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        [TestMethod]
        public void LanuchPQA() {
            TestCaseID = "CGN-001";
            PQAWebViewer.LaunchPQA(PQAExePath, PQAAlternateExePath);
        }

        [TestMethod]
        public void TestPQALaunchWebViewer()
        {
            TestCaseID = "CGN-1";           
            PQAWebViewer.LaunchSmartViewDataSelectorWindow();
            PQASmartViewDataSelector.CheckStartDateCheckBox(false);
            PQASmartViewDataSelector.SearchByRecipeAndClickOk(SharedInspectionName);
            PQAWebViewer.DisplayWebViewer();
            PQAWebViewer.VerifyWebViewerIsExist();
           
            //lodedInspectionNameInWebViewer = webViewer.GetLoadedInspectionNameInWebViewer();
            // webViewer.CloseWebViewer();

        }

         [TestMethod]
        public void TestPQAWVShowDefectRatePlot()
        {
            TestCaseID = "CGN-2";
            PQAWebViewer.AddDefectRatePlot();
            PQAWebViewer.VerifyDefectRatePlotIsDisplayed();
        }


        [TestMethod]
         public void TestPQAWVDisplaySideLabels()
         {

            TestCaseID = "CGN-3";
            PQAWebViewerTools.LoadDisplayOptionsWindow();
            PQAWebViewerTools.SelectSideLabelCheckBox(true);
            PQAWebViewerTools.CloseDisplayOptionsWindow();
            PQAWebViewerTools.DefineSideLabels(1);
        }

        [TestMethod]
        public void TestPQAWVShowDefectLabels()
        {
            TestCaseID = "CGN-4";
            String[] defectLabels = { "Defect No.", "Severity", "Box Top" };
            for (int index = 0; index < defectLabels.Length; index++)
            {
                PQAWebViewerTools.LoadDisplayOptionsWindow();
                PQAWebViewerTools.ShowDefectLabels(true, defectLabels[index]);
                PQAWebViewerTools.CloseDisplayOptionsWindow();
            }
        }

        [TestMethod]
        public void TestPQAWVHideDefectLabels()
        {
            TestCaseID = "CGN-5";
            PQAWebViewerTools.LoadDisplayOptionsWindow();
            PQAWebViewerTools.ShowDefectLabels(false, "");
            PQAWebViewerTools.CloseDisplayOptionsWindow();            
        }

        [TestMethod]
        public void TestPQAWVGoToSpecifiedDefect()
        {
            TestCaseID = "CGN-6";
            WebViewerGoToWindow.LoadGoToWindow();
            WebViewerGoToWindow.GoToDefect("7");
            WebViewerGoToWindow.CloseGoToWindow();
        }

        [TestMethod]
        public void TestPQAWVGoToSpecifiedPosition()
        {
            TestCaseID = "CGN-7";
            WebViewerGoToWindow.LoadGoToWindow();
            WebViewerGoToWindow.GoToPosition("66","44");
            WebViewerGoToWindow.CloseGoToWindow();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            if (IsUpdateTestResult.Equals("true"))
            {
                
                String testStatus = testContextInstance.CurrentTestOutcome.ToString();
                TC.UpdateTCStatus(TestCaseID, testStatus, ErrorMessage);
                
            }
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
