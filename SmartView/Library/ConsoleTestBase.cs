using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using SmartView.UIModule.Console.SVConsoleClasses;
using SmartView.UIModule.Console.InspectionSetup.InspectionSetupClasses;
using SmartView.UIModule.Console.SheetQualityViewer.SheetQualityViewerClasses;
using SmartView.UIModule.Console.DefectRateViewer.DefectRateViewerClasses;
using SmartView.UIModule.Console.LaneViewer.DisplayOptions.DisplayOptionClasses;
using SmartView.UIModule.Console.LaneViewer.LaneViewerClasses;
using SmartView.UIModule.Console.MultiDefectViewer.MultiDefectViewerDisplayOptionClasses;
using SmartView.UIModule.Console.MultiDefectViewer.MDVToolsClasses;

namespace SmartView.Library
{
    public class ConsoleTestBase
    {
        public SVConsole console = new SVConsole();
        public InspectionSetup inspectionSetup = new InspectionSetup();
        public SheetQualityViewer sheetQualityViewer = new SheetQualityViewer();
        public DefectRateViewer defectRateViewer = new DefectRateViewer();
        public DisplayOption LaneViewerDisplayOption = new DisplayOption();
        public LaneViewer LaneViewer = new LaneViewer();
        public MultiDefectViewerDisplayOption MultiDefectViewerDisplayOption = new MultiDefectViewerDisplayOption();
        public MDVTools MultiDefectViewerTools = new MDVTools();
             

        public static String TestCasePath = ConfigurationSettings.AppSettings["TestCasePath"];
        public static String TCIDColumn = ConfigurationSettings.AppSettings["TCIDColumn"];
        public static String TCStatusColumn = ConfigurationSettings.AppSettings["TCStatusColumn"];
        public static String TCErrorMessageColumn = ConfigurationSettings.AppSettings["TCErrorMessageColumn"];
        public static String IsUpdateTestResult = ConfigurationSettings.AppSettings["IsUpdateTestResult"];
        public static String TestCaseID = "CGN-";
        public static String ErrorMessage = "No Erros";

        public static ExcelTCDoc TC = new ExcelTCDoc(TestCasePath, TCIDColumn, TCStatusColumn);

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
