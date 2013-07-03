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


namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class LiveModePQATest:PQATestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public LiveModePQATest()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
              
         }



        [TestMethod]
        public void TestPQAWVLaunchWebViewerOnLiveMode()
        {
            TestCaseExternalID = "CGN-001";

            TextReader tr = new StreamReader(ProjectPath + "\\Resources\\InspectionName.txt");
            InspectionName = tr.ReadLine();

           // PQAWebViewer.LaunchPQA(PQAExePath, PQAAlternateExePath);
            PQAWebViewer.LaunchSmartViewDataSelectorWindow();
            PQASmartViewDataSelector.CheckStartDateCheckBox(false);
            PQASmartViewDataSelector.SearchByRecipeAndSelelectDefinedRecored(InspectionName);
            PQAWebViewer.DisplayWebViewer();
            PQAWebViewer.VerifyWebViewerIsExist();
           
            //lodedInspectionNameInWebViewer = webViewer.GetLoadedInspectionNameInWebViewer();
            // webViewer.CloseWebViewer();

        }

         [TestMethod]
        public void TestPQAWVShowDefectRatePlotOnLiveMode()
        {
            TestCaseExternalID = "CGN-002";
            PQAWebViewer.AddDefectRatePlot();
            PQAWebViewer.VerifyDefectRatePlotIsDisplayed();
        }


        [TestMethod]
         public void TestPQAWVDisplaySideLabelsOnLiveMode()
         {

            TestCaseExternalID = "CGN-003";
            PQAWebViewerTools.LoadDisplayOptionsWindow();
            PQAWebViewerTools.SelectSideLabelCheckBox(true);
            PQAWebViewerTools.CloseDisplayOptionsWindow();
            PQAWebViewerTools.DefineSideLabels(1);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            CleanUp(TestContext);
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
