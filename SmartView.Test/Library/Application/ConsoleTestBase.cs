using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using SVConsole.UIModule.Console.ConsoleClasses;
using SVConsole.UIModule.Console.InspectionSetup.InspectionSetupClasses;
using SVConsole.UIModule.Console.SheetQualityViewer.SheetQualityViewerClasses;
using SVConsole.UIModule.Console.DefectRateViewer.DefectRateViewerClasses;
using SVConsole.UIModule.Console.LaneViewer.DisplayOptions.DisplayOptionClasses;
using SVConsole.UIModule.Console.LaneViewer.LaneViewerClasses;
using SVConsole.UIModule.Console.MultiDefectViewer.MultiDefectViewerDisplayOptionClasses;
using SVConsole.UIModule.Console.MultiDefectViewer.MDVToolsClasses;
using SmartView.Library;
using SmartView.Test.Library.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartView.Test.Library.Application
{

    public class ConsoleTestBase
    {
        public SVConsole.UIModule.Console.ConsoleClasses.Console console = new SVConsole.UIModule.Console.ConsoleClasses.Console();
        public InspectionSetup inspectionSetup = new InspectionSetup();
        public SheetQualityViewer sheetQualityViewer = new SheetQualityViewer();
        public DefectRateViewer defectRateViewer = new DefectRateViewer();
        public DisplayOption LaneViewerDisplayOption = new DisplayOption();
        public LaneViewer LaneViewer = new LaneViewer();
        public MultiDefectViewerDisplayOption MultiDefectViewerDisplayOption = new MultiDefectViewerDisplayOption();
        public MDVTools MultiDefectViewerTools = new MDVTools();
         

        public static String TestCaseExternalID = "";
        public static int TestCaseInternalID = 55;
        public static String ErrorMessage = "No Erros";

       
        public static String TestCaseIDFile = ConfigurationSettings.AppSettings["TestCaseIDFile"];
        public TestLinkUtil TCResultReport;
    

        public static String RandomNumber = "";
        public static String CustomReportName = "";

        public static String ProjectPath = ConfigurationSettings.AppSettings["ProjectPath"];
        public static String InspectionName = ConfigurationSettings.AppSettings["InspectionName"];
        public static String Recipe = ConfigurationSettings.AppSettings["Recipe"];
        public static String Architecture = ConfigurationSettings.AppSettings["Architecture"];



        public string PQAExePath = ConfigurationSettings.AppSettings["PQAExePath"];
        public string PQAAlternateExePath = ConfigurationSettings.AppSettings["PQAAlternateExePath"];

        public ConsoleTestBase()
        {
            //RandomNumber = GetRandomNumber();
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

        public void CleanUp(TestContext testContextInstance){

            String testStatus = testContextInstance.CurrentTestOutcome.ToString();           
           
           // TestCaseExternalID = testContextInstance.Properties["TestLinkExternalID"].ToString();         
            
            //TestCaseInternalID = Int32.Parse(testContextInstance.Properties["TestLinkInternalID"].ToString());
            TestCaseExternalID = TestCaseExternalID.Split('-')[1];
            TCResultReport.ReportTestStatus(TestCaseExternalID, testStatus, ErrorMessage, TestCaseIDFile);
        }


    }
}
