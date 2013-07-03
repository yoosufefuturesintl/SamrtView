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



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestDefectParameters:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestDefectParameters()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        [TestMethod]
        public void TestRCPDPConnectivityMergeDistanceMaximumValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetConnectivityMergeDistanceParameter("5666", "223652");            
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyConnectivityMergeDistanceParameterValues("255.00", "92.00");
            DefectParameters.ApplyDefectParameterChanges();

        }

        [TestMethod]
        public void TestRCPDPConnectivityMergeDistanceDecimalValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();   
            DefectParameters.SetConnectivityMergeDistanceParameter("252.26", "90.32");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyConnectivityMergeDistanceParameterValues("252.26", "90.32");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPExtendedConnectivityMaximumValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(true, "2000","5005000");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(true, "100.00", "500000.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPExtendedConnectivityDecimalValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(true, "20.362", "1235.222");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(true, "20.36", "1235.22");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPDisableExtendedConnectivity()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(false, "20.362", "1235.222");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(false, "20.362", "1235.22");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPOngoinDefectMaximumValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(true, "102400");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(true, "1024.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPOngoinDefectDecimalValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(true, "596.367");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(true, "596.37");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPOngoinDefectDisable()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(false, "596.367");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(false, "596.37");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPFilteredDefectsByDistanceMaximumValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByDistance", "16000");
            DefectParameters.ApplyDefectParameterChanges();

            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByDistance", "10000.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPFilteredDefectsByDistanceDecimalValue()
        {
            TestCaseExternalID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByDistance", "234.68");
            DefectParameters.ApplyDefectParameterChanges();

            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByDistance", "234.68");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]        
        public void TestRCPDPFilteredDefectsByTimeMaximumValue()
        {
            TestCaseExternalID = "CGN-54";
            try
            {
                DefectParameters.LoadDefectParameters();
                DefectParameters.SetFilteredDefectParameter("ByTime", "60030");
                DefectParameters.ApplyDefectParameterChanges();
            }
            catch (Exception e)
            {
                
                Assert.AreEqual(true, e.Message.Contains("SetProperty of Text with value \"60030\""));
            }           
        }

        [TestMethod]
        public void TestRCPDPFilteredDefectsByTimeDecimalValue()
        {
            TestCaseExternalID = "CGN-54";           
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByTime", "234");
            DefectParameters.ApplyDefectParameterChanges();
            
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByTime", "234");
            DefectParameters.ApplyDefectParameterChanges();
        }

        [TestMethod]
        public void TestRCPDPImportParametersMaximumValue()
        {
            TestCaseExternalID = "CGN-42";
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\MaximumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        [TestMethod]
        public void TestRCPDPImportParametersMinimumValue()
        {
            TestCaseExternalID = "CGN-43";
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\MinimumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        [TestMethod]
        public void TestRCPDPImportParametersNegativeValue()
        {
            TestCaseExternalID = "CGN-44";
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\NegativeValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        [TestMethod]
        public void TestRCPDPImportParametersExceedMaximumValue()
        {
            TestCaseExternalID = "CGN-42";
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\ExceedMaximumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        [TestMethod]
        public void TestRCPDPImportParametersDecimalValue()
        {
            TestCaseExternalID = "CGN-45";
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\DecimalValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

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
