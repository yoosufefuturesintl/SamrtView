using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using SVRecipe.UIModule.Recipe.RecipeWizardClasses;
using SVRecipe.UIModule.Recipe.RecipeClasses;
using SVRecipe.UIModule.Recipe.Defect.ClassesDialogBoxClasses;
using SVRecipe.UIModule.Recipe.Defect.DefectParametersClasses;
using SVRecipe.UIModule.Recipe.Aliases.AliasesClasses;
using SVRecipe.UIModule.Recipe.TileMap.TileMapClasses;
using SVRecipe.UIModule.Recipe.Thresholds.ThresholdsClasses;
using SVRecipe.UIModule.Recipe.RepeatingDefectSetup.RepeatingDefectSetupClasses;
using SVRecipe.UIModule.Recipe.SheetQualityAnalysis.SheetQualityAnalysisClasses;
using SmartView.Library;
using SmartView.Test.Library.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SmartView.Test.Library.Application
{
    public class RecipeTestBase
    {
        
        public RecipeWizard RecipeWizard = new RecipeWizard();
        public Recipe Recipe = new Recipe();
        public ClassesDialogBox ClassesDialogBox = new ClassesDialogBox();
        public DefectParameters DefectParameters = new DefectParameters();
        public Aliases Aliases = new Aliases();
        public TileMap TileMap = new TileMap();
        public Thresholds Thresholds = new Thresholds();
        public RepeatingDefectSetup RepeatingDefectSetup = new RepeatingDefectSetup();
        public SheetQualityAnalysis SQA = new SheetQualityAnalysis();
        
        public static int TestCaseInternalID = 55;
        public static String TestCaseExternalID = "CGN-";
        public static String ErrorMessage = "No Erros";

        public static String TestCaseIDFile = ConfigurationSettings.AppSettings["TestCaseIDFile"];
        public TestLinkUtil TCResultReport;

        public static String RandomNumber = "";
        public static String CustomReportName = "";
        public static String AliasesName = "Als-";
        public static String RecipeName = ConfigurationSettings.AppSettings["Recipe"];

        public static String ProjectPath = ConfigurationSettings.AppSettings["ProjectPath"];
        public static String InspectionName = ConfigurationSettings.AppSettings["InspectionName"];



        public string RecipeExePath = ConfigurationSettings.AppSettings["RecipeExePath"];
        public string RecipeAlternateExePath = ConfigurationSettings.AppSettings["RecipeAlternateExePath"];

        public RecipeTestBase()
        {
            RandomNumber = GetRandomNumber();
            CustomReportName = "CustomReport" + RandomNumber;
            TCResultReport = new TestLinkUtil();
        }


        public String GetRandomNumber()
        {
            //Random ran = new Random();
            String randomNumber = "";
            TextReader tr = new StreamReader(ProjectPath + "\\Resources\\RandomNo.txt");
            randomNumber = tr.ReadLine();      
            // int n = ran.Next();
            // randomNumber = n.ToString().Substring(2, 6);
            return randomNumber;
        }

        public void CleanUp(TestContext testContextInstance)
        {

            String testStatus = testContextInstance.CurrentTestOutcome.ToString();

            // TestCaseExternalID = testContextInstance.Properties["TestLinkExternalID"].ToString();         

            //TestCaseInternalID = Int32.Parse(testContextInstance.Properties["TestLinkInternalID"].ToString());
            TestCaseExternalID = TestCaseExternalID.Split('-')[1];
            TCResultReport.ReportTestStatus(TestCaseExternalID, testStatus, ErrorMessage, TestCaseIDFile);
        }


    }
}
