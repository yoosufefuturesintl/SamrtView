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
    public class TestConsole:ConsoleTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestConsole()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
            console.CloseSystemWarningsWindow();
        }

        

       
        [TestMethod]
        [TestProperty("TestLinkExternalID", "55")]
        [TestProperty("TestLinkInternalID", "1371")]
        public void TestLaunchConsole()
        {
            TestCaseExternalID = "CGN-55";

            Applications.CloseAllApplication("Console"); 
            console.LaunchConsole();
            console.SelectArchitecture(Architecture);
            InspectionName = inspectionSetup.LoadAndStartInspection(Recipe);
            console.CloseSystemWarningsWindow();
            console.MaximizeConsoleWindow();

            TextWriter TW = new StreamWriter(ProjectPath + "\\Resources\\InspectionName.txt");
            TW.WriteLine(InspectionName);
            TW.Close();  
            
                   
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "55")]
        [TestProperty("TestLinkInternalID", "127")]
        public void TestCSSheetQualityViewer()
        {
            TestCaseExternalID = "CGN-55";
            sheetQualityViewer.LoadSheetQualityViewer();
            sheetQualityViewer.ClickStartStopSnapshotTimer();
            Thread.Sleep(65000);
            sheetQualityViewer.ClickStartStopSnapshotTimer();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "55")]
        [TestProperty("TestLinkInternalID", "127")]
        public void TestCSStopCurrentInspection() {
            TestCaseExternalID = "CGN-55";
            console.ClickStartOrStopButton();
            sheetQualityViewer.CloseSheetQualityViewer();
            defectRateViewer.CloseDefectRateViewer();
            //console.CloseConsole();
            //console.CloseSVConsole();
            Applications.CloseAllApplication("Console");            
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "55")]
        [TestProperty("TestLinkInternalID", "127")]
        public void TestCSDefectRateViewer() {
            TestCaseExternalID = "CGN-55";
            defectRateViewer.LoadDefectRateViewer();
            defectRateViewer.DisplayCrosswebInTable();
            Thread.Sleep(10000);
            defectRateViewer.DisplayDefectSeverityInformation();
            Thread.Sleep(10000);
            defectRateViewer.DisplayDownwebPlot();
            Thread.Sleep(10000);
            defectRateViewer.EnableQuery();
            Thread.Sleep(10000);
            defectRateViewer.DisplayCrosswebPlot();
            Thread.Sleep(10000);
            defectRateViewer.EnableQuery();
            Thread.Sleep(30000);
            //defectRateViewer.DisplayDefectCountInformation();

        }

        [TestCleanup]
        public void TestCleanUp()
        {
            console.CloseSystemWarningsWindow();

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
