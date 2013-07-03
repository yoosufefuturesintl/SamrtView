using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVPQA.UIModule.PQA.WebViewer.WebViewerClasses;
using SVPQA.UIModule.PQA.DataSelector.SmartViewDataSelectorClasses;
using SVPQA.UIModule.PQA.Report.InspectionSummaryReportClasses;
using SVPQA.UIModule.PQA.DefectSummary.DefectSummaryClasses;
using SVPQA.UIModule.PQA.TrendViewer.TrendViewerClasses;
using SVPQA.UIModule.PQA.TrendViewer.TrendWizardClasses;
using SVPQA.UIModule.PQA.WebViewer.WebViewerToolsClasses;
using SVPQA.UIModule.PQA.WebViewer.GoToWindowClasses;
using SVReview.UIModule.Review.ReviewClasses;
using SVReview.UIModule.Review.LaneViewer.LaneViewerClasses;
using SVReview.UIModule.Review.DataSourceFile.DataSourceFileClasses;
using SVReview.UIModule.Review.LaneViewer.DisplayOptionsClasses;
using SVReview.UIModule.Review.LaneViewer.LVLiveModeSettingsClasses;
using System.Configuration;
using System.IO;
using SmartView.Library;
using SmartView.Test.Library.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SmartView.Test.Library.Application
{
    public class ReviewTestBase
    {
        public Review Review = new Review();
        public LaneViewer LaneViewer = new LaneViewer();
        public DataSourceFile DataSourceFile = new DataSourceFile();
        public DisplayOptions LaneViewerDisplayOptions = new DisplayOptions();
        public LVLiveModeSettings LVLiveModeSettings = new LVLiveModeSettings();
        
        public static int TestCaseInternalID = 55;
        public static String TestCaseExternalID = "CGN-";
        public static String ErrorMessage = "No Erros";
      
        public static String TestCaseIDFile = ConfigurationSettings.AppSettings["TestCaseIDFile"];
        public TestLinkUtil TCResultReport;
       

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
