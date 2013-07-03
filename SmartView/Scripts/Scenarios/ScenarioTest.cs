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
using SmartView.UIModule.ConfigurationManager.ConfigurationManagerClasses;
using SmartView.UIModule.ClassifierMgr.ClassListClasses;
using SmartView.UIModule.ClassifierMgr.ClassifierManagerClasses;
using SmartView.UIModule.Recipe.RecipeWizardClasses;
using SmartView.UIModule.Recipe.RecipeClasses;



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ScenarioTest:ConsoleTestBase
    {
        ConfigurationManager ConfigMang = new ConfigurationManager();
        ClassifierManager ClassifierMng = new ClassifierManager();
        ClassList ClassfierClassList = new ClassList();
        RecipeTestBase RecipeBase = new RecipeTestBase();
             
        public ScenarioTest()
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
        public void TestInspectWithStandardVSingleView()
        {
            ConfigMang.LaunchConfigurationManager();
            ////ConfigMang.
            ConfigMang.CreateStandardSingleViewArchitecture("ATM" + RandomNumber);
            ConfigMang.CloseConfigurationManager();

            ClassifierMng.LaunchClassifierManager();
            ClassifierMng.CreateNewClassifier("Standard", "SmartView", "", false);
            ClassfierClassList.LoadClassListTab();
            ClassfierClassList.ImportClassifier();
            ClassifierMng.SaveClassifier("ATM" + RandomNumber);
           // ClassifierMng.CloseClassifierManager();

            RecipeBase.RecipeWizard.LaunchRecipe(RecipeBase.RecipeExePath, RecipeBase.RecipeAlternateExePath);
            RecipeBase.RecipeWizard.SelectArchitectureInRecipeWizard("ATM" + RandomNumber);
            RecipeBase.RecipeWizard.CreateNewRecipe("ATM" + RandomNumber);
            RecipeBase.Recipe.AssignClassifierToRecipe("ATM" + RandomNumber);

            console.LaunchConsole();
            console.SelectArchitecture("ATM" + RandomNumber);
            //inspectionSetup.SetRollInInspectionSetup("ATM" + RandomNumber);
            inspectionSetup.SetRollAndLoadAndStartInspection("ATM" + RandomNumber);
            console.CloseSystemWarningsWindow();
            console.MaximizeConsoleWindow();           

        }

        [TestMethod]
        public void TestInspectWithStandardVSingleViewAndClassifierTypeIsSmartLean()
        {
            ConfigMang.LaunchConfigurationManager();
            ////ConfigMang.
            ConfigMang.CreateStandardSingleViewArchitecture("ATM" + RandomNumber);
            ConfigMang.CloseConfigurationManager();

            ClassifierMng.LaunchClassifierManager();
            ClassifierMng.CreateNewClassifier("Standard", "SmartLearn", "SVM", false);
            ClassfierClassList.LoadClassListTab();
            ClassfierClassList.ImportClassifier();
            ClassifierMng.SaveClassifier("ATM" + RandomNumber);
            // ClassifierMng.CloseClassifierManager();

            RecipeBase.RecipeWizard.LaunchRecipe(RecipeBase.RecipeExePath, RecipeBase.RecipeAlternateExePath);
            RecipeBase.RecipeWizard.SelectArchitectureInRecipeWizard("ATM" + RandomNumber);
            RecipeBase.RecipeWizard.CreateNewRecipe("ATM" + RandomNumber);
            RecipeBase.Recipe.AssignClassifierToRecipe("ATM" + RandomNumber);

            console.LaunchConsole();
            console.SelectArchitecture("ATM" + RandomNumber);
            //inspectionSetup.SetRollInInspectionSetup("ATM" + RandomNumber);
            inspectionSetup.SetRollAndLoadAndStartInspection("ATM" + RandomNumber);
            console.CloseSystemWarningsWindow();
            console.MaximizeConsoleWindow();

        }
       
        
        [TestCleanup]
        public void TestCleanUp()
        {
            console.CloseSystemWarningsWindow();
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
