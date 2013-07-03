using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using SVClassifierManager.UIModule.ClassifierManagerClasses;
using SmartView.Library;
using SVClassifierManager.UIModule.ClassList.ClassListClasses;
using SmartView.Test.Library.Util;


namespace SmartView.Test.Library.Application
{
    public class ClassifierTestBase
    {

        public ClassifierManager ClassifierManager = new ClassifierManager();
        public static String ClassifierName = "ATM0104";
        public String className = "AtmClass";

        public ClassList ClassList = new ClassList();

        
        public static int TestCaseInternalID = 55;
        public static String TestCaseExternalID = "CGN-";
        public static String ErrorMessage = "No Erros";


  
        public static bool isUpdateByExternalID = Boolean.Parse(ConfigurationSettings.AppSettings["isUpdateByExternalID"]);
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

        public ClassifierTestBase()
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


    }
}
