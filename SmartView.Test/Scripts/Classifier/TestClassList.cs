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
using SmartView.Library;
using System.IO;
using System.Threading;
using SmartView.Test.Library.Application;
using SmartView.Test.Library.Data;



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestClassList : ClassifierTestBase
    {


        public TestClassList()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;

        }

        [TestMethod]
        public void TestCreateNewClass()
        {
            ClassList.LoadClassListTab();
            ClassList.CreateNewClass(className + RandomNumber, "Test automation description", "w");
        }

        [TestMethod]
        public void TestSaveActionDefectAndGrayAndFullContext()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsDefectAndGray(true, "Full context", false);
            ClassList.VerifyDefectAndGrayClassSaveAction(true, "Full context", false);
        }


        [TestMethod]
        public void TestSaveActionDefectAndGrayAndUseDefectBoundingBox()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsDefectAndGray(true, "Full context", true);
            ClassList.VerifyDefectAndGrayClassSaveAction(true, "Full context", true);
        }

        public void TestSaveActionDefectAndGrayAndLimitedContext()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsDefectAndGray(true, "Limited context", false);
            ClassList.VerifyDefectAndGrayClassSaveAction(true, "Limited context", false);
        }

        [TestMethod]
        public void TestSaveActionDefectAndGrayAndCompressed()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsDefectAndGray(true, "Compressed", false);
            ClassList.VerifyDefectAndGrayClassSaveAction(true, "Compressed", false);
        }

        [TestMethod]
        public void TestSaveActionDefectOnly()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionDefectOnly();
            ClassList.VerifyDefectOnlyClassSaveAction(true);
        }

        [TestMethod]
        public void TestSaveActionDiscard()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsDiscard();
            ClassList.VerifyDiscardClassSaveAction(true);
        }

        [TestMethod]
        public void TestSaveActionFilter()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassSaveActionIsFilter();
            ClassList.VerifyFilterClassSaveAction(true);
        }


        [TestMethod]
        public void TestDataBaseImportDefectAndGray()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassDBImportDefectAndGray();
            ClassList.VerifyDefectAndGrayClassDBImport(true);
        }

        [TestMethod]
        public void TestDataBaseImportDefectOnly()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassDataBaseImportDefectOnly();
            ClassList.VerifyClassDataBaseImportDefectOnly(true);
        }

        [TestMethod]
        public void TestDataBaseImportDoNotImport()
        {
            ClassList.LoadClassListTab();
            ClassList.ClassDataBaseImportDoNotImport();
            ClassList.VerifyClassDataBaseImportDoNotImport(true);
        }

        [TestMethod]
        public void TestSpecialProcessingReportAnalysis()
        {
            ClassList.LoadClassListTab();

        }

        [TestMethod]
        public void TestClassSpecialProcessingExtendedConnectivity()
        {
            ClassList.LoadClassListTab();

            ClassList.ClassSpecialProcessingExtendedConnectivity(true);
            ClassList.VerifyClassSpecialProcessingExtendedConnectivity(true);

            ClassList.ClassSpecialProcessingExtendedConnectivity(false);
            ClassList.VerifyClassSpecialProcessingExtendedConnectivity(false);
        }

        [TestMethod]
        public void TestClassSpecialProcessingViewToViewCorrelation()
        {
            ClassList.LoadClassListTab();

            //ClassList.ClassSpecialProcessingViewToViewCorrelation(true);
            //ClassList.VerifyClassSpecialProcessingViewToViewCorrelation(true);

            //ClassList.ClassSpecialProcessingViewToViewCorrelation(false);
            // ClassList.VerifyClassSpecialProcessingViewToViewCorrelation(false);
        }

        [TestMethod]
        public void TestClassSpecialProcessingPreventCamToCamMerging()
        {
            ClassList.LoadClassListTab();

            ClassList.ClassSpecialProcessingPreventCamToCamMerging(true);
            ClassList.VerifyClassSpecialProcessingPreventCamToCamMerging(true);

            ClassList.ClassSpecialProcessingPreventCamToCamMerging(false);
            ClassList.VerifyClassSpecialProcessingPreventCamToCamMerging(false);
        }

        [TestMethod]
        public void TestClassSpecialProcessingBreakOngoingDefect()
        {
            ClassList.LoadClassListTab();

            ClassList.ClassSpecialProcessingBreakOngoingDefect(true, true);
            ClassList.VerifyClassSpecialProcessingBreakOngoingDefect(true, true);

            ClassList.ClassSpecialProcessingBreakOngoingDefect(true, false);
            ClassList.VerifyClassSpecialProcessingBreakOngoingDefect(true, false);

            ClassList.ClassSpecialProcessingBreakOngoingDefect(false, false);
            ClassList.VerifyClassSpecialProcessingBreakOngoingDefect(false, false);

            ClassList.ClassSpecialProcessingBreakOngoingDefect(false, true);
            ClassList.VerifyClassSpecialProcessingBreakOngoingDefect(false, true);
        }


        [TestMethod]
        public void TestCreateNewClassWithExistingClassName()
        {
            ClassList.LoadClassListTab();
            ClassList.CreateNewClass(className + RandomNumber, "Test automation description", "w");
        }






        [TestCleanup]
        public void TestCleanUp()
        {
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
