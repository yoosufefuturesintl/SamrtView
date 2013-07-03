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
    public class ReviewLaneViewerTest:ReviewTestBase
    {
       
        public ReviewLaneViewerTest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }



        [TestMethod]
        public void TestLaunchReview()
        {
            TestCaseID = "CGN-34";
            Review.LaunchReview();

        }

        [TestMethod]
        public void TestRVLaunchLaneViewer()
        {
            TestCaseID = "CGN-35";
            LaneViewer.LaunchLaneViewer();
            //LaneViewer.MaximizeLaneViewer();
            LaneViewer.VerifyLaneViewerLaunchedSuccessfully();

        }

        [TestMethod]
        public void TestRVLVLoadInspectionDataIntoLaneViewer()
        {
            TestCaseID = "CGN-36";
            DataSourceFile.LoadSelectSourceFileWindow();
            DataSourceFile.ClickOpenButton();
        }

        [TestMethod]
        public void TestRVLVCustomBackgroundColor()
        {
            TestCaseID = "CGN-37";
            LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
            LaneViewerDisplayOptions.CustomBackgroundColor(true);
            LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
            //LaneViewer.MaximizeLaneViewer();
            LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
            LaneViewerDisplayOptions.CustomBackgroundColor(false);
            LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
        }

         [TestMethod]
        public void TestRVLVShowSideLabels()
        {
            TestCaseID = "CGN-38";
            LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
            LaneViewerDisplayOptions.ShowSideLabels(true);          
            LaneViewerDisplayOptions.CloseDisplayOptionsWindow();

            LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
            LaneViewerDisplayOptions.ShowSideLabels(false);
            LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
        }

         [TestMethod]
         public void TestRVLVShowMarkReaderView()
         {
             TestCaseID = "CGN-39";
             LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
             LaneViewerDisplayOptions.ShowMarkReaderViews(true);
             LaneViewerDisplayOptions.CloseDisplayOptionsWindow();

             LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
             LaneViewerDisplayOptions.ShowMarkReaderViews(false);
             LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
         }

         [TestMethod]
         public void TestRVLVShowLanesBasedOnQuery()
         {
             TestCaseID = "CGN-40";
             LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
             LaneViewerDisplayOptions.ShowLanesBasedOnQuery(true);
             LaneViewerDisplayOptions.CloseDisplayOptionsWindow();

             LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
             LaneViewerDisplayOptions.ShowLanesBasedOnQuery(false);
             LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
         }

         [TestMethod]
         public void TestRVLVLaneLabels()
         {
             TestCaseID = "CGN-41";
             String[] laneLabels = { "Left limit", "Right limit", "Lane number" };
             for (int laneIndex = 0; laneIndex < laneLabels.Length; laneIndex ++)
             {
                 LaneViewerDisplayOptions.LoadDisplayOptionsWindow();
                 LaneViewerDisplayOptions.ShowLaneColumnsLabel(laneLabels[laneIndex]);
                 LaneViewerDisplayOptions.CloseDisplayOptionsWindow();
             }
         }

         [TestMethod]
         public void TestRVLVStopOnSelection()
         {
             TestCaseID = "CGN-52";
             LVLiveModeSettings.LoadLiveModeSettingWindow();
             LVLiveModeSettings.StopOnSelection(true);
             LVLiveModeSettings.ApplyLiveModeSettings();
             LaneViewer.ClickOnViewerPort();
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
