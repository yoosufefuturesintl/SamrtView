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
    public class TestClassifyingDefects:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestClassifyingDefects()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }
                

       [TestMethod]
        public void TestRCPClassesDBLoadClassPropertiesUsingClassList()
        {
            TestCaseID = "CGN-47";
            Recipe.LoadClassesDialogBox("Basic");            
            ClassesDialogBox.LoadClassPropertiesBySelectingDesiredClassFromList();
            ClassesDialogBox.VerifyClassPropertiesTabLoadedSuccessfully();
           
        }

        [TestMethod]
        public void TestRCPClassesDBDisplayClassPropertiesUsingDropDown()
        {
            TestCaseID = "CGN-48";
            ClassesDialogBox.SelectClassFromClassDropDownInCPTab("Low Density Bright");
            ClassesDialogBox.VerifyClassSeverityAndDesription("10", "Sparsely thresholded defect that is mostly bright");

            ClassesDialogBox.SelectClassFromClassDropDownInCPTab("Flood");
            ClassesDialogBox.VerifyClassSeverityAndDesription("100", "");
        }

        [TestMethod]
        public void TestRCPClassesDBAssignOutput()
        {
            TestCaseID = "CGN-49";
            ClassesDialogBox.AssignOutput();
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
