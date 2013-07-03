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
using SmartView.Test.Library.Application;
using System.IO;
using System.Threading;



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestLaneViewer:ConsoleTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestLaneViewer()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
           // console.CloseSystemWarningsWindow();
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "55")]
        [TestProperty("TestLinkInternalID", "127")]
        public void TestCNLLVLaunchLaneViewer()
        {           
            console.LoadLaneViewer();
        }

        // Display option test cases

        [TestMethod]
        [TestProperty("TestLinkExternalID", "70")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableFeatureColumns()
        {
            TestCaseExternalID = "CGN-70";            
            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.DefineFeatureColumns(true, "Top", true, "Defect Area", "3");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyFeatureColumns(true, "Top", true, "Defect Area", "3");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "71")]
        [TestProperty("TestLinkInternalID", "164")]
        public void TestCNLLVDisableFeatureColumns()
        {
            TestCaseExternalID = "CGN-71";
            
            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.DefineFeatureColumns(false, "Top", false, "Defect Area", "3");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyFeatureColumns(false, "Top", false, "Defect Area", "3");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

        }


        [TestMethod]
        [TestProperty("TestLinkExternalID", "72")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVLaneColumnsLabel()
        {
            TestCaseExternalID = "CGN-72";
           
            String [] labels = {"Lane number","Left limit","Right limit"};
            for (int index = 0; index < labels.Length; index++)
            {
                LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
                LaneViewerDisplayOption.DefineLaneColumnsLabel(labels[index]);
                LaneViewerDisplayOption.CloseDisplayOptionWindow();

                LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
                LaneViewerDisplayOption.VerifyLaneColumnsLabel(labels[index]);
                LaneViewerDisplayOption.CloseDisplayOptionWindow();
            }
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "73")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableIndicateMaterialThatFallsOutsideLaneBoundaries()
        {
            TestCaseExternalID = "CGN-73";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.DefineIndicateMaterialThatFallsOutsideLaneBoundaries(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyIndicateMaterialThatFallsOutsideLaneBoundaries(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
                       
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "74")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDisableIndicateMaterialThatFallsOutsideLaneBoundaries()
        {
            TestCaseExternalID = "CGN-74";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.DefineIndicateMaterialThatFallsOutsideLaneBoundaries(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyIndicateMaterialThatFallsOutsideLaneBoundaries(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "75")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVBackgroundColorGrayScale()
        {
            TestCaseExternalID = "CGN-75";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.SetBackgroundColor("Normalizer");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyBackgroundColor("Normalizer");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "76")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVBackgroundColorCustom()
        {
            TestCaseExternalID = "CGN-76";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.SetBackgroundColor("Custom");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyBackgroundColor("Custom");
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "77")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVShowMarkReaderViews()
        {
            TestCaseExternalID = "CGN-77";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.ShowMarkReaderViews(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyMarkReaderViews(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "78")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVHideMarkReaderViews()
        {
            TestCaseExternalID = "CGN-78";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.ShowMarkReaderViews(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifyMarkReaderViews(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "79")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVShowSideLabels()
        {
            TestCaseExternalID = "CGN-79";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.ShowSideLabels(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifySideLabels(true);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "80")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVHideSideLabels()
        {
            TestCaseExternalID = "CGN-80";

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.ShowSideLabels(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
           

            LaneViewerDisplayOption.LoadDisplayOptionDialogBox();
            LaneViewerDisplayOption.VerifySideLabels(false);
            LaneViewerDisplayOption.CloseDisplayOptionWindow();
        }

        //Live mode settings test cases

        [TestMethod]
        [TestProperty("TestLinkExternalID", "81")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableLiveModeStopScrollOnSelection()
        {
            TestCaseExternalID = "CGN-81";

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.StopScrollOnSelection(true);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.SelectDefectFromLaneViewer();
            Thread.Sleep(50000);
            LaneViewer.CloseDefectViewer();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyStopScrollOnSelection(true);
            LaneViewer.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "82")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDisableLiveModeStopScrollOnSelection()
        {
            TestCaseExternalID = "CGN-82";

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.StopScrollOnSelection(false);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyStopScrollOnSelection(false);
            LaneViewer.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "83")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableAutomaticallyResumeLiveMode()
        {
            TestCaseExternalID = "CGN-83";
            String seconds = "30";
            LaneViewer.LoadLiveModeSettings();
            LaneViewer.AutomaticallyResumeLiveMode(true, seconds);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyAutomaticallyResumeLiveMode(true, seconds);
            LaneViewer.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "84")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDisableAutomaticallyResumeLiveMode()
        {
            TestCaseExternalID = "CGN-84";
            String seconds = "30";
            LaneViewer.LoadLiveModeSettings();
            LaneViewer.AutomaticallyResumeLiveMode(false, seconds);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyAutomaticallyResumeLiveMode(false, seconds);
            LaneViewer.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "85")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableOngoingDefectsKeepVisible()
        {
            TestCaseExternalID = "CGN-85";
            String seconds = "30";
            LaneViewer.LoadLiveModeSettings();
            LaneViewer.OngoingDefectsKeepVisible(true, seconds);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyOngoingDefectsKeepVisible(true, seconds);
            LaneViewer.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "86")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDisableOngoingDefectsKeepVisible()
        {
            TestCaseExternalID = "CGN-86";
            String seconds = "30";
            LaneViewer.LoadLiveModeSettings();
            LaneViewer.OngoingDefectsKeepVisible(false, seconds);
            LaneViewer.ApplyLiveModeSettings();

            LaneViewer.LoadLiveModeSettings();
            LaneViewer.VerifyOngoingDefectsKeepVisible(false, seconds);
            LaneViewer.ApplyLiveModeSettings();
        }


        // Define query test cases

        [TestMethod]
        [TestProperty("TestLinkExternalID", "87")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVEnableApplyQuery()
        {
            TestCaseExternalID = "CGN-87";

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.EnableQuery(true);
            LaneViewer.CloseQueryDefinitionWindow();

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.VerifyEnableQuery(true);
            LaneViewer.CloseQueryDefinitionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "88")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDisableApplyQuery()
        {
            TestCaseExternalID = "CGN-88";

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.EnableQuery(false);
            LaneViewer.CloseQueryDefinitionWindow();

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.VerifyEnableQuery(false);
            LaneViewer.CloseQueryDefinitionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "89")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDefineQueryByAll()
        {
            TestCaseExternalID = "CGN-89";

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.DefineQueryAllDefects(true);
            LaneViewer.CloseQueryDefinitionWindow();

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.VerifyDefineQueryAllDefects(true);
            LaneViewer.CloseQueryDefinitionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "90")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDefineQueryBySeverity()
        {
            TestCaseExternalID = "CGN-90";

            String severity = "10";
            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.DefineQueryBySeverity(true, severity);
            LaneViewer.CloseQueryDefinitionWindow();

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.VerifyDefineQueryBySeverity(true, severity);
            LaneViewer.CloseQueryDefinitionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "91")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDefineQueryByOnlyRepeating()
        {
            TestCaseExternalID = "CGN-91";

            String severity = "10";
            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.DefineQueryOnlyRepeating(true);
            LaneViewer.CloseQueryDefinitionWindow();

            LaneViewer.LoadQueryDefinitionWindow();
            LaneViewer.VerifyDefineQueryOnlyRepeating(true);
            LaneViewer.CloseQueryDefinitionWindow();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "92")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLLVDefineQueryBySelectedClasses()
        {
            TestCaseExternalID = "CGN-92";

            String severity = "10";
            //LaneViewer.LoadQueryDefinitionWindow();
            //LaneViewer.DefineQuerySelectedClasses(true);
            //LaneViewer.CloseQueryDefinitionWindow();

            //LaneViewer.LoadQueryDefinitionWindow();
            //LaneViewer.VerifyDefineQuerySelectedClasses(true);
            //LaneViewer.CloseQueryDefinitionWindow();
        }



        [TestCleanup]
        public void TestCleanUp()
        {
            //console.CloseSystemWarningsWindow();
            CleanUp(testContextInstance);
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
