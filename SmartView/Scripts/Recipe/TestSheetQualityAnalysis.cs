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
using System.Threading;



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestSheetQualityAnalysis:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestSheetQualityAnalysis()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }
        
        [TestMethod]
        public void TestRCPSQAEnableSheetQualityAnalysis()
        {
            TestCaseID = "CGN-96";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.EnableSheetQualityAnalysis(true);
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifySheetQualityAnalysisStatus(true);
            SQA.ApplySQASettings();            
        }

        [TestMethod]
        public void TestRCPSQADisableSheetQualityAnalysis()
        {
            TestCaseID = "CGN-98";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.EnableSheetQualityAnalysis(false);
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifySheetQualityAnalysisStatus(false);
            SQA.ApplySQASettings();
        }

        [TestMethod]
        public void TestRCPSQADifineImageParameters()
        {
            TestCaseID = "CGN-97";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.SQAImageParameters("2.35", "125.32", "102.65");
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifySQAImageParameters("2.35", "125.32", "102.65");
            SQA.ApplySQASettings();
        }



        [TestMethod]
        public void TestRCPSQAImageParametersEnableSampleQualificationRightEdge()
        {
            TestCaseID = "CGN-100";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.SQAImageParametersSampleQualificationRightEdge(true, "102");           
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifySQAImageParametersSampleQualificationRightEdge(true, "102.00");            
            SQA.ApplySQASettings();
        }

        [TestMethod]
        public void TestRCPSQAImageParametersDisableSampleQualificationRightEdge()
        {
            TestCaseID = "CGN-102";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.SQAImageParametersSampleQualificationRightEdge(false, "102");            
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifySQAImageParametersSampleQualificationRightEdge(false, "102");           
            SQA.ApplySQASettings();
        }

        [TestMethod]
        public void TestRCPSQAImageParametersEnableSampleQualificationLeftEdge()
        {
            TestCaseID = "CGN-99";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");            
            SQA.SQAImageParametersSampleQualificationLeftEdge(true, "45");
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");           
            SQA.VerifySQAImageParametersSampleQualificationLeftEdge(true, "45.00");
            SQA.ApplySQASettings();
        }

        [TestMethod]
        public void TestRCPSQAImageParametersDisableSampleQualificationLeftEdge()
        {
            TestCaseID = "CGN-101";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");            
            SQA.SQAImageParametersSampleQualificationLeftEdge(false, "45");
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");           
            SQA.VerifySQAImageParametersSampleQualificationLeftEdge(false, "45");
            SQA.ApplySQASettings();
        }


        [TestMethod]
        public void TestRCPSQACrosswebLocationCenteredInCamera()
        {
            TestCaseID = "CGN-103";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            //SQA.SetCamera("cam1");
            SQA.DefineCrosswebLocation("CenteredInCamera", "55.00");
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifyDefineCrosswebLocation("CenteredInCamera", "55.00");
            SQA.ApplySQASettings();
        }


        [TestMethod]
        public void TestRCPSQACrosswebLocationCenteredAt()
        {
            TestCaseID = "CGN-104";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.DefineCrosswebLocation("CenteredAt", "55.00");
            SQA.ApplySQASettings();

            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.VerifyDefineCrosswebLocation("CenteredAt", "55.00");
            SQA.ApplySQASettings();
        }


        [TestMethod]
        public void TestRCPSQAImageParametersDefineCameras()
        {
            TestCaseID = "CGN-105";
            SQA.LoadSheetQualityAnalysisWindow("test", "view 1");
            SQA.SetCamera("cam3");
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
