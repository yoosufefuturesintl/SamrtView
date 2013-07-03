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
    public class TestClassifier : ClassifierTestBase
    {


        public TestClassifier()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;

        }

        [TestMethod]
        public void TestLaunchClassiferManager()
        {
            ClassifierManager.LaunchClassifierManager();
        }

        [TestMethod]
        public void TestCloseClassiferManager()
        {
            ClassifierManager.CloseClassifierManager(ClassifierName);
        }

        [TestMethod]
        public void TestClassifierCreateViewTypeIsSynchAndClassifierTypeIsSmartView()
        {
            ClassifierName = ClassifierName + "" + RandomNumber;
            ClassifierManager.CreateNewClassifier("Synchronized", "SmartView", "", false);
            ClassifierManager.SaveClassifier(ClassifierName);
            ClassList.RecordedMethod1(ClassifierName);
            ClassifierManager.VerifyClassifierTitleAndStatusBar(ClassifierName, "Synchronized");
            //  ClassifierManager.LoadOpenClassifierWindw(ClassifierName);
            //  ClassifierManager.VerifyClassifierListedInClassifierListOnOpenClassifierWindow(ClassifierName);
            //  ClassifierManager.ClickOpenButtonInOpenClassifierWindow();


        }

        [TestMethod]
        public void TestClassifierCreateViewTypeIsStdAndClassifierTypeIsSmartView()
        {
            ClassifierName = ClassifierName + "Sync" + RandomNumber;
            ClassifierManager.CreateNewClassifier("Standard", "SmartView", "", false);
            ClassifierManager.SaveClassifier(ClassifierName);
            ClassifierManager.VerifyClassifierTitleAndStatusBar(ClassifierName, "Standard");


        }

        [TestMethod]
        public void TestClassifierCreateViewTypeIsMarkReaderAndClassifierTypeIsSmartView()
        {
            ClassifierName = ClassifierName + "Sync" + RandomNumber;
            ClassifierManager.CreateNewClassifier("Mark reader", "non", "", false);
            ClassifierManager.SaveClassifier(ClassifierName);
            ClassifierManager.VerifyClassifierTitleAndStatusBar(ClassifierName, "Mark reader");


        }





        [TestCleanup]
        public void TestCleanUp()
        {

            String testStatus = testContextInstance.CurrentTestOutcome.ToString();
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
