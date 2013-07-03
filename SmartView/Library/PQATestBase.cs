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
using SmartView.UIModule.PQA.Report.LaneSummaryReport.LaneSummaryReportClasses;
using SmartView.UIModule.PQA.Report.ReportWizardReportOptionsClasses;
using SmartView.UIModule.PQA.Report.ReportWizardSectionFormattingClasses;
using System.Configuration;
using System.IO;


namespace SmartView.Library
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
        public static String SharedInspectionName = ConfigurationSettings.AppSettings["SharedInspectionName"];



        public string PQAExePath = ConfigurationSettings.AppSettings["PQAExePath"];
        public string PQAAlternateExePath = ConfigurationSettings.AppSettings["PQAAlternateExePath"];

        public PQATestBase() {
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
