using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartView.UIModule.PQA.WebViewer.WebViewerClasses;
using SmartView.UIModule.PQA.DataSelector.SmartViewDataSelectorClasses;
using SmartView.UIModule.PQA.Report.InspectionSummaryReportClasses;
using SmartView.UIModule.PQA.DefectSummary.DefectSummaryClasses;
using SmartView.UIModule.PQA.TrendViewer.TrendViewerClasses;
using SmartView.UIModule.PQA.TrendViewer.TrendWizardClasses;
using SmartView.UIModule.PQA.WebViewer.WebViewerToolsClasses;
using SmartView.UIModule.PQA.WebViewer.GoToWindowClasses;
using SmartView.UIModule.Review.ReviewClasses;
using SmartView.UIModule.Review.LaneViewer.LaneViewerClasses;
using SmartView.UIModule.Review.DataSourceFile.DataSourceFileClasses;
using SmartView.UIModule.Review.LaneViewer.DisplayOptionsClasses;
using SmartView.UIModule.Review.LaneViewer.LVLiveModeSettingsClasses;
using System.Configuration;
using System.IO;


namespace SmartView.Library
{
    public class ReviewTestBase
    {
        public Review Review = new Review();
        public LaneViewer LaneViewer = new LaneViewer();
        public DataSourceFile DataSourceFile = new DataSourceFile();
        public DisplayOptions LaneViewerDisplayOptions = new DisplayOptions();
        public LVLiveModeSettings LVLiveModeSettings = new LVLiveModeSettings();


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
        public static String Recipe = ConfigurationSettings.AppSettings["Recipe"];
        public static String Architecture = ConfigurationSettings.AppSettings["Architecture"];

        public static String ProjectPath = ConfigurationSettings.AppSettings["ProjectPath"];
        public static String InspectionName = ConfigurationSettings.AppSettings["InspectionName"];



        public string PQAExePath = ConfigurationSettings.AppSettings["PQAExePath"];
        public string PQAAlternateExePath = ConfigurationSettings.AppSettings["PQAAlternateExePath"];

        public ReviewTestBase()
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
