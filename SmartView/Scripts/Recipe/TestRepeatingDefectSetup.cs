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
    public class TestRepeatingDefectSetup:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestRepeatingDefectSetup()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }
        
        [TestMethod]
        public void TestRCPRDSEnableRepeatingDefectDetection()
        {
            TestCaseID = "CGN-94";
            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.EnableRepeatingDefectDetection(true);
            RepeatingDefectSetup.ApplySettings();
            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.VerifyRepeatingDefectDetectionStatus(true);

            RepeatingDefectSetup.EnableRepeatingDefectDetection(false);
            RepeatingDefectSetup.ApplySettings();
            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.VerifyRepeatingDefectDetectionStatus(false);
            RepeatingDefectSetup.ApplySettings();
        }

        [TestMethod]
        public void TestRCPRDSSeriesDefinition()
        {
            TestCaseID = "CGN-93";
            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.EnableRepeatingDefectDetection(true);
            RepeatingDefectSetup.SetSeriesDefinition("255.00","113000.00","3","5");
            RepeatingDefectSetup.ApplySettings();

            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.VerifySeriesDefinitionParametes("255.000", "113000.000", "3", "5");
            RepeatingDefectSetup.ApplySettings();
        }

        [TestMethod]
        public void TestRCPRDSVariationWithinSeries()
        {
            TestCaseID = "CGN-95";
            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.EnableRepeatingDefectDetection(true);
            RepeatingDefectSetup.SetVariationWithinSeries("5.00", "8.00", "6", "11");
            RepeatingDefectSetup.ApplySettings();

            RepeatingDefectSetup.LoadRepeatingDefectSetup("test", "view 1");
            RepeatingDefectSetup.VerifyVariationWithinSeries("5.000", "8.000", "6.000", "11.");
            RepeatingDefectSetup.ApplySettings();
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
