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
    public class TestRecipe:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestRecipe()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        

       
        [TestMethod]
        public void TestRCPLaunchRecipe()
        {
            TestCaseID = "CGN-53";
            RecipeWizard.LaunchRecipe(RecipeExePath, RecipeAlternateExePath);
            RecipeWizard.SelectArchitectureInRecipeWizard("4 Camera");
            RecipeWizard.SelectExistingRecipe("test");           
            Recipe.VerifyRecipeMangerLaunchedSuecessfully("4 Camera","test");
           
        }

        [TestMethod]
        public void TestRCPCloseRecipeManager()
        {
            TestCaseID = "CGN-55";
            Recipe.CloseRecipeManagerApplication();
        }

       // [TestMethod]
        public void TestRCPClassesDBLoadClassPropertiesUsingClassList()
        {
            TestCaseID = "CGN-47";
            Recipe.LoadClassesDialogBox("Basic-Test");            
            ClassesDialogBox.LoadClassPropertiesBySelectingDesiredClassFromList();
            ClassesDialogBox.VerifyClassPropertiesTabLoadedSuccessfully();
           
        }

        //[TestMethod]
        public void TestRCPClassesDBDisplayClassPropertiesUsingDropDown()
        {
            TestCaseID = "CGN-48";
            ClassesDialogBox.SelectClassFromClassDropDownInCPTab("Low Density Bright");
            ClassesDialogBox.VerifyClassSeverityAndDesription("10", "Sparsely thresholded defect that is mostly bright");

            ClassesDialogBox.SelectClassFromClassDropDownInCPTab("Flood");
            ClassesDialogBox.VerifyClassSeverityAndDesription("100", "");
        }

        //[TestMethod]
        public void TestRCPClassesDBAssignOutput()
        {
            TestCaseID = "CGN-49";
            ClassesDialogBox.AssignOutput();
        }

        //[TestMethod]
        public void TestRCPDPConnectivityMergeDistanceMaximumValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetConnectivityMergeDistanceParameter("5666", "223652");            
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyConnectivityMergeDistanceParameterValues("255.00", "92.00");
            DefectParameters.ApplyDefectParameterChanges();

        }

        //[TestMethod]
        public void TestRCPDPConnectivityMergeDistanceDecimalValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();   
            DefectParameters.SetConnectivityMergeDistanceParameter("252.26", "90.32");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyConnectivityMergeDistanceParameterValues("252.26", "90.32");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPExtendedConnectivityMaximumValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(true, "2000","5005000");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(true, "100.00", "500000.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPExtendedConnectivityDecimalValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(true, "20.362", "1235.222");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(true, "20.36", "1235.22");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPDisableExtendedConnectivity()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetExtendedConnectivityParameter(false, "20.362", "1235.222");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyExtendedConnectivityParameter(false, "20.362", "1235.22");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPOngoinDefectMaximumValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(true, "102400");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(true, "1024.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPOngoinDefectDecimalValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(true, "596.367");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(true, "596.37");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPOngoinDefectDisable()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetOngoingDefectsParameter(false, "596.367");
            DefectParameters.ApplyDefectParameterChanges();
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyOngoingDefectsParameter(false, "596.37");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPFilteredDefectsByDistanceMaximumValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByDistance", "16000");
            DefectParameters.ApplyDefectParameterChanges();

            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByDistance", "10000.00");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPFilteredDefectsByDistanceDecimalValue()
        {
            TestCaseID = "CGN-54";
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByDistance", "234.68");
            DefectParameters.ApplyDefectParameterChanges();

            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByDistance", "234.68");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]        
        public void TestRCPDPFilteredDefectsByTimeMaximumValue()
        {
            TestCaseID = "CGN-54";
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

        //[TestMethod]
        public void TestRCPDPFilteredDefectsByTimeDecimalValue()
        {
            TestCaseID = "CGN-54";           
            DefectParameters.LoadDefectParameters();
            DefectParameters.SetFilteredDefectParameter("ByTime", "234");
            DefectParameters.ApplyDefectParameterChanges();
            
            DefectParameters.LoadDefectParameters();
            DefectParameters.VerifyFilteredDefectParameter("ByTime", "234");
            DefectParameters.ApplyDefectParameterChanges();
        }

        //[TestMethod]
        public void TestRCPDPImportMaximumValue()
        {
            TestCaseID = "CGN-42";    
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParameters();
        }

        //[TestMethod]
        public void TestRCPOpenExistingRecipe()
        {
            TestCaseID = "CGN-55";   
            //Recipe.aaa();
            RecipeWizard.ClickBackButton();
            RecipeWizard.SelectArchitectureInRecipeWizard("1Cam");
            RecipeWizard.SelectExistingRecipe("Basic1");
            Recipe.VerifyRecipeMangerLaunchedSuecessfully("1Cam", "Basic1");
        }

        //[TestMethod]
        public void TestRCPALSCreateAliases()
        {
            TestCaseID = "CGN-50";   
            AliasesName = AliasesName + RandomNumber.Substring(1,3);
            DefectParameters.LoadDefectParameters();
            Recipe.LoadRecipeAliasesWindow();
            Aliases.AddAliases(AliasesName, RecipeName);
            Aliases.VerifyAliasesNameInAliasesList(AliasesName);
            Aliases.CloseAliasesWindow();
        }

        //[TestMethod]
        public void TestRCPALSCDuplicateAliasesName()
        {
            TestCaseID = "CGN-55";   
           
            DefectParameters.LoadDefectParameters();
            Recipe.LoadRecipeAliasesWindow();
            Aliases.AddAliases(AliasesName, RecipeName);
            Aliases.VerifyAliasesDuplicateNameErrorMessage();
            Aliases.ClickOkBurttonInAliasesDuplicateNameErrorMessage();
            Aliases.CloseAliasesWindow();
        }

        //[TestMethod]
        public void TestRCPALSCDeleteAliases()
        {
             TestCaseID = "CGN-51";   
            DefectParameters.LoadDefectParameters();
            Recipe.LoadRecipeAliasesWindow();
            Aliases.DeleteAliases(AliasesName, RecipeName);
            Aliases.VerifyIsAliasesAvailableInAliasesList(false);
            Aliases.CloseAliasesWindow();
        }



        //[TestMethod]
        public void TestRCPDPImportParametersMaximumValue()
        {
             TestCaseID = "CGN-42";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\MaximumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();
            
        }

        //[TestMethod]
        public void TestRCPDPImportParametersMinimumValue()
        {
             TestCaseID = "CGN-43";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\MinimumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        //[TestMethod]
        public void TestRCPDPImportParametersNegativeValue()
        {
             TestCaseID = "CGN-44";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\NegativeValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        //[TestMethod]
        public void TestRCPDPImportParametersExceedMaximumValue()
        {
             TestCaseID = "CGN-42";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\ExceedMaximumValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        //[TestMethod]
        public void TestRCPDPImportParametersDecimalValue()
        {
             TestCaseID = "CGN-45";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\DecimalValue.txt");
            DefectParameters.ApplyDefectParameterChanges();

        }

        //[TestMethod]
        public void TestRCPTMDefineLaneLayoutUsingLaneWidthOption()
        {
             TestCaseID = "CGN-56";   
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DefineLaneLayoutUsingLaneWidthOfOption(true, "600");
            TileMap.ApplyTileMapSettings();           

        }

        //[TestMethod]
        public void TestRCPTMDefineLaneLayoutUsingNumberOfLanesOption()
        {
            TestCaseID = "CGN-56";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DefineLaneLayoutUsingNumberOfLanesOption(true, "6");
            TileMap.ApplyTileMapSettings();

        }

       

        //[TestMethod]
        public void TestRCPDPImportParametersValueWithAlphabaticCharacter()
        {
             TestCaseID = "CGN-46";   
            DefectParameters.LoadDefectParameters();
            DefectParameters.ImportDefectParametersFromFile(ProjectPath + "\\Resources\\Recipe\\DefectParameters\\Import\\ValueWithAlphabaticCharacter.txt");
            DefectParameters.ApplyDefectParameterChanges();

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
