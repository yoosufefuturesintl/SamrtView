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
using SVConfigurationManager.UIModule.ConfigurationManagerClasses;
using SVClassifierManager.UIModule.ClassList.ClassListClasses;
using SVClassifierManager.UIModule.ClassifierManagerClasses;
using SVRecipe.UIModule.Recipe.RecipeWizardClasses;
using SVRecipe.UIModule.Recipe.RecipeClasses;
using SVConfigurationManager.UIModule.NewArchitectureWindowClasses;
using SmartView.Test.Library.Data;



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
        NewArchitectureWindow ConfMangNewArchitectureWindow = new NewArchitectureWindow();
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
        public void DBTest()
        {
            TextWriter Tw = new StreamWriter("D:\\QA\\DB.txt");
            DBUtil dbUtil = new DBUtil();
            Tw.WriteLine( dbUtil.getData("SELECT Name FROM v_Inspection where InspectionID = '24'"));
            Tw.Close();

        }

        [TestMethod, Description("User story 1")]
        public void TestInspectWithStandardVSingleView()
        {
            String name = "ATM" + RandomNumber;
            ConfigMang.LaunchConfigurationManager();
            ConfigMang.LoadNewArchitectureWindow();
            ConfMangNewArchitectureWindow.CreateArchitecture(name,"standard",1);
            ConfigMang.LoadCameraStatusWindow();
            ConfigMang.AssignCameraToSingleView();
            ConfigMang.CloseConfigurationManager();

            ClassifierMng.LaunchClassifierManager();
            ClassifierMng.CreateNewClassifier("Standard", "SmartView", "", false);
            ClassfierClassList.LoadClassListTab();
            ClassfierClassList.ImportClassifier();
            ClassifierMng.SaveClassifier(name);
            ClassifierMng.CloseClassifierManager(name);

            RecipeBase.RecipeWizard.LaunchRecipe(RecipeBase.RecipeExePath, RecipeBase.RecipeAlternateExePath);
            RecipeBase.RecipeWizard.SelectArchitectureInRecipeWizard(name);
            RecipeBase.RecipeWizard.CreateNewRecipe(name);
            RecipeBase.Recipe.AssignClassifierToRecipe(name);

            console.LaunchConsole();
            console.SelectArchitecture(name);
            //inspectionSetup.SetRollInInspectionSetup(name);
            inspectionSetup.SetRollAndLoadAndStartInspection(name);
            console.CloseSystemWarningsWindow();
            console.MaximizeConsoleWindow();           

        }


        [TestMethod]
        public void TestSyncView()
        {
            String name = "ATM" + RandomNumber;
              ConfigMang.LaunchConfigurationManager();
            ConfigMang.LoadNewArchitectureWindow();
            ConfMangNewArchitectureWindow.CreateArchitecture(name,"sync",1);
            ConfigMang.LoadCameraStatusWindow();
            ConfigMang.AssignCameraToSingleView();
            ConfigMang.CloseConfigurationManager();

            ClassifierMng.LaunchClassifierManager();
            ClassifierMng.CreateNewClassifier("Standard", "SmartLearn", "SVM", false);
            ClassfierClassList.LoadClassListTab();
            ClassfierClassList.ImportClassifier();
            ClassifierMng.SaveClassifier(name);
            // ClassifierMng.CloseClassifierManager();

            RecipeBase.RecipeWizard.LaunchRecipe(RecipeBase.RecipeExePath, RecipeBase.RecipeAlternateExePath);
            RecipeBase.RecipeWizard.SelectArchitectureInRecipeWizard(name);
            RecipeBase.RecipeWizard.CreateNewRecipe(name);
            RecipeBase.Recipe.AssignClassifierToRecipe(name);

            console.LaunchConsole();
            console.SelectArchitecture(name);
            //inspectionSetup.SetRollInInspectionSetup(name);
            inspectionSetup.SetRollAndLoadAndStartInspection(name);
            console.CloseSystemWarningsWindow();
            console.MaximizeConsoleWindow();

        }
       
        
        [TestCleanup]
        public void TestCleanUp()
        {
            console.CloseSystemWarningsWindow();
            
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
