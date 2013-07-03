using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Configuration;

namespace SmartView.Library
{
    public class ExcelTCDoc
    {

        static String TestCaseIDColumn = "";
        static String TestCaseDocPath = "";
        static String TestCaseStatusColumn = "";

        public ExcelTCDoc(String testCaseDocPath, String testCaseIDColumn, String testCaseStatusColumn)
        {

            TestCaseDocPath = testCaseDocPath;
            TestCaseIDColumn = testCaseIDColumn;
            TestCaseStatusColumn = testCaseStatusColumn;

        }

        public ExcelTCDoc()
        {          

        }

        public static char GettheLetter(char currentLetter)
        {
            if (currentLetter == 'Z')
            {
                return 'A';
            }
            else
            {
                return ++currentLetter;
            }
        }

        public void UpdateTCStatus(String testCaseID, String status, int workSheetIndex)
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            int incre = 1;
            char letter = 'A';


            object misValue = System.Reflection.Missing.Value;
            myExcelApp = new Excel.Application();
            myExcelApp.Visible = true;
            myExcelWorkbooks = myExcelApp.Workbooks;
            myExcelWorkbook = myExcelWorkbooks.Open(TestCaseDocPath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);


            String testCaseIDInExcelSheet = "";
            Excel.Worksheet myExcelWorksheet = myExcelWorkbook.Worksheets[workSheetIndex];

            for (int row = 1; true; row++)
            {

                testCaseIDInExcelSheet = myExcelWorksheet.get_Range(TestCaseIDColumn + row.ToString(), misValue).Formula.ToString();
                if (testCaseIDInExcelSheet.Equals(testCaseID))
                {
                    myExcelWorksheet.get_Range(TestCaseStatusColumn + row.ToString(), misValue).Formula = status;
                    
                    break;
                }
            }
            myExcelWorkbook.Save();
            myExcelWorkbook.Close();
            myExcelWorkbooks.Close();
            myExcelApp.Quit();


        }

        public void UpdateTCStatus(String testCaseID, String status, int workSheetIndex, String errorMessage)
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            int incre = 1;
            char letter = 'A';


            object misValue = System.Reflection.Missing.Value;
            myExcelApp = new Excel.Application();
            myExcelApp.Visible = true;
            myExcelWorkbooks = myExcelApp.Workbooks;
            myExcelWorkbook = myExcelWorkbooks.Open(TestCaseDocPath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);


            String testCaseIDInExcelSheet = "";
            Excel.Worksheet myExcelWorksheet = myExcelWorkbook.Worksheets[workSheetIndex];

            for (int row = 1; true; row++)
            {

                testCaseIDInExcelSheet = myExcelWorksheet.get_Range(TestCaseIDColumn + row.ToString(), misValue).Formula.ToString();
                if (testCaseIDInExcelSheet.Equals(testCaseID))
                {
                    myExcelWorksheet.get_Range(TestCaseStatusColumn + row.ToString(), misValue).Formula = status;
                    myExcelWorksheet.get_Range("H" + row.ToString(), misValue).Formula = errorMessage;

                   
                    break;
                }
            }
            myExcelWorkbook.Save();
            myExcelWorkbook.Close();
            myExcelWorkbooks.Close();
            myExcelApp.Quit();


        }

        public void UpdateTCStatus(String testCaseID, String status, String module, String errorMessage)
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            int incre = 1;
            char letter = 'A';

            int workSheetIndex = GetWorkSheetInex(module);
            object misValue = System.Reflection.Missing.Value;
            myExcelApp = new Excel.Application();
            myExcelApp.Visible = true;
            myExcelWorkbooks = myExcelApp.Workbooks;
            myExcelWorkbook = myExcelWorkbooks.Open(TestCaseDocPath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);


            String testCaseIDInExcelSheet = "";
            Excel.Worksheet myExcelWorksheet = myExcelWorkbook.Worksheets[workSheetIndex];

            for (int row = 1; true; row++)
            {

                testCaseIDInExcelSheet = myExcelWorksheet.get_Range(TestCaseIDColumn + row.ToString(), misValue).Formula.ToString();
                if (testCaseIDInExcelSheet.Equals(testCaseID))
                {
                    myExcelWorksheet.get_Range(TestCaseStatusColumn + row.ToString(), misValue).Formula = status;
                    myExcelWorksheet.get_Range("H" + row.ToString(), misValue).Formula = errorMessage;

                   
                    break;
                }
            }
            myExcelWorkbook.Save();
            myExcelWorkbook.Close();
            myExcelWorkbooks.Close();
            myExcelApp.Quit();


        }

        public void UpdateTCStatus(String testCaseID, String status, String errorMessage)
        {
            String testResultTxtFielName = ConfigurationSettings.AppSettings["TestResultTxtFile"];

            FileStream fileStream = new FileStream(testResultTxtFielName, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(testCaseID + "," + status + "," + errorMessage);
            streamWriter.Close();
            fileStream.Close(); 

            //File.WriteAllText(testResultTxtFielName, testCaseID + "," + status + "," + errorMessage);


        }




        public int GetWorkSheetInex(String module)
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            int incre = 1;
            char letter = 'A';
            int workSheetIndex = 1;

            object misValue = System.Reflection.Missing.Value;
            myExcelApp = new Excel.Application();
            myExcelApp.Visible = true;
            myExcelWorkbooks = myExcelApp.Workbooks;
            myExcelWorkbook = myExcelWorkbooks.Open(TestCaseDocPath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);


            for (int row = 1; workSheetIndex < myExcelWorkbook.Worksheets.Count + 1; workSheetIndex++)
            {
                Excel.Worksheet myExcelWorksheet = myExcelWorkbook.Worksheets[workSheetIndex];
                String moduleName = myExcelWorksheet.get_Range("A1", misValue).Formula.ToString();
                if (moduleName.Equals(module))
                {

                   
                    break;
                }
            }
            myExcelWorkbook.Save();
            myExcelWorkbook.Close();
            myExcelWorkbooks.Close();
            myExcelApp.Quit();

            return workSheetIndex;
        }
    }
}
