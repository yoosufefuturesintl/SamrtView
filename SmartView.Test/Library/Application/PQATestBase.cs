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
using SVPQA.UIModule.PQA.Report.LaneSummaryReport.LaneSummaryReportClasses;
using SVPQA.UIModule.PQA.Report.ReportWizardReportOptionsClasses;
using SVPQA.UIModule.PQA.Report.ReportWizardSectionFormattingClasses;
using SmartView.Library;
using System.Configuration;
using System.IO;
using SmartView.Test.Library.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SmartView.Test.Library.Application
{
    public class PQATestBase
    {
        public WebViewer PQAWebViewer = new WebViewer();
        public WebViewerTools PQAWebViewerTools = new WebViewerTools();
        public SmartViewDataSelector PQASmartViewDataSelector = new SmartViewDataSelector();
        public InspectionSummaryReport PQAInspectionSummaryReport = new InspectionSummaryReport();
        public DefectSummary PQADefectSummary = new DefectSummary();
        public TrendViewer PQATrendViewer = new TrendViewer();
        public TrendWizard PQATrendWizard = new TrendWizard();
        public GoToWindow WebViewerGoToWindow = new GoToWindow();
        public LaneSummaryReport LaneSummaryReport = new LaneSummaryReport();
        public ReportWizardReportOptions ReportWizardReportOptions = new ReportWizardReportOptions();
        public ReportWizardSectionFormatting ReportWizardSectionFormatting = new ReportWizardSectionFormatting();

        public static int TestCaseInternalID = 55;
        public static String TestCaseExternalID = "CGN-";
        public static String ErrorMessage = "No Erros";

        public static String RandomNumber = "";
        public static String CustomReportName = "";
        public static String Recipe = ConfigurationSettings.AppSettings["Recipe"];
        public static String Architecture = ConfigurationSettings.AppSettings["Architecture"];

        public static String ProjectPath = ConfigurationSettings.AppSettings["ProjectPath"];
        public static String InspectionName = ConfigurationSettings.AppSettings["InspectionName"];
        public static String SharedInspectionName = ConfigurationSettings.AppSettings["SharedInspectionName"];


       
        public static String TestCaseIDFile = ConfigurationSettings.AppSettings["TestCaseIDFile"];
        public TestLinkUtil TCResultReport;



        public string PQAExePath = ConfigurationSettings.AppSettings["PQAExePath"];
        public string PQAAlternateExePath = ConfigurationSettings.AppSettings["PQAAlternateExePath"];

        public PQATestBase() {
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
