using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using SmartView.UIModule.Recipe.RecipeWizardClasses;
using SmartView.UIModule.Recipe.RecipeClasses;
using SmartView.UIModule.Recipe.Defect.ClassesDialogBoxClasses;
using SmartView.UIModule.Recipe.Defect.DefectParametersClasses;
using SmartView.UIModule.Recipe.Aliases.AliasesClasses;
using SmartView.UIModule.Recipe.TileMap.TileMapClasses;
using SmartView.UIModule.Recipe.Thresholds.ThresholdsClasses;
using SmartView.UIModule.Recipe.RepeatingDefectSetup.RepeatingDefectSetupClasses;
using SmartView.UIModule.Recipe.SheetQualityAnalysis.SheetQualityAnalysisClasses;


namespace SmartView.Library
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

        public static String TestCasePath = ConfigurationSettings.AppSettings["TestCasePath"];
        public static String TCIDColumn = ConfigurationSettings.AppSettings["TCIDColumn"];
        public static String TCStatusColumn = ConfigurationSettings.AppSettings["TCStatusColumn"];
        public static String TCErrorMessageColumn = ConfigurationSettings.AppSettings["TCErrorMessageColumn"];
        public static String IsUpdateTestResult = ConfigurationSettings.AppSettings["IsUpdateTestResult"];
        public static String TestCaseID = "CGN-";
        public static String ErrorMessage = "No Erros";

        public static ExcelTCDoc TC = new ExcelTCDoc();

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


    }
}
