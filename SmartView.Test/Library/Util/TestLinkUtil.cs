using System;
using System.Configuration;
using Meyn.TestLink;
using System.Collections.Generic;
using System.IO;
using SmartView.Test.Library.Config;

namespace SmartView.Test.Library.Util
{
    public class TestLinkUtil
    {
        private TestLink testLink;

        private static int _testPlanId;
        private static int _buildVersion;
        public static String TestLinkUrl;
        public static String TestLinkApiKey;


        public TestLinkUtil()
        {
             _testPlanId =  Int32.Parse(AppConfig.GetValue("TestLinkTestPlanId"));
            _buildVersion = Int32.Parse(AppConfig.GetValue("TestLinkBuildId"));
            TestLinkUrl = AppConfig.GetValue("TestLinkUrl");
            TestLinkApiKey = AppConfig.GetValue("TestLinkApiKey");
            testLink = new TestLink(TestLinkApiKey, TestLinkUrl, true);


        }

        public TestLinkUtil(String apiKey, String url, bool log, int testPlanId, int buildVersion)
        {
            testLink = new TestLink(apiKey, url, log);

            _testPlanId = testPlanId;
            _buildVersion = buildVersion;
        }

        public TestLinkUtil(String apiKey, String url, bool log, int testPlanId)
        {
            testLink = new TestLink(apiKey, url, log);
            _testPlanId = testPlanId;
        }

        public void ReportTestStatus(int testCaseId, String status, String message)
        {
            if (status.Equals("Passed"))
            {
                ReportTestPass(testCaseId, message);
            }
            if (status.Equals("Failed"))
            {
                ReportTestFail(testCaseId, message);
            }
            if (status.Equals("Blocked"))
            {
                ReportTestBlocked(testCaseId);
            }
        }

        public void ReportTestStatus(String externalTestCaseId, String status, String message)
        {
            if (status.Equals("Passed"))
            {
                ReportTestPass(externalTestCaseId, message);
            }
            if (status.Equals("Failed"))
            {
                ReportTestFail(externalTestCaseId, message);
            }
            if (status.Equals("Blocked"))
            {
                ReportTestBlocked(externalTestCaseId);
            }
        }

        public void ReportTestStatus(String externalTestCaseId, String status, String message, String testCaseIdFilePath)
        {
           
            var tr = new StreamReader(testCaseIdFilePath);

            String line;

            String[] ids = new String[2];

            int internalId;

            while ((line = tr.ReadLine()) != null)
            {
                ids = line.Split('|');
                
                if (ids[0].Equals(externalTestCaseId))
                {
                    internalId = Int32.Parse(ids[1]);
                    ReportTestStatus(internalId, status, message);
                    break;
                }
            }
            

            tr.Close();
        }
        public void ReportTestStatus(String testCaseExternalId, int testCaseInternalID, String status, String message, bool isByExternalID)
        {
            if (isByExternalID)
            {
                ReportTestStatus(testCaseExternalId, status, message);
            }

            if (!isByExternalID)
            {

                ReportTestStatus(testCaseInternalID, status, message);
            }
        }

        public void ReportTestStatus(int testCaseId, String status)
        {
            if (status.Equals("Passed"))
            {
                ReportTestPass(testCaseId, "Test case is passed");
            }
            if (status.Equals("Failed"))
            {
                ReportTestFail(testCaseId, "Test case is passed");
            }
            if (status.Equals("Blocked"))
            {
                ReportTestBlocked(testCaseId);
            }
        }

        public void ReportTestPass(int testCaseId, String message)
        {
            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, _buildVersion, 0);

            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, 0, 0);
            }

        }

        public int GetInternalTestCaseID(String testCaseExternalId)
        {
            int testCaseId = 0;

            for (int index = 0; index < testLink.GetTestCasesForTestPlan(_testPlanId).Count; index++)
            {
                String externalID = testLink.GetTestCasesForTestPlan(_testPlanId)[index].external_id;

                if (externalID.Equals(testCaseExternalId))
                {
                    testCaseId = testLink.GetTestCasesForTestPlan(_testPlanId)[index].tc_id;
                }
            }

            return testCaseId;
        }

        public void WriteInternalAndExternalTestCaseID(String filePath)
        {

            TextWriter tw = new StreamWriter(filePath);
            List<Meyn.TestLink.TestCaseFromTestPlan> testList = testLink.GetTestCasesForTestPlan(2);
           

            int testCaseCount = testList.Count;
            for (int index = 0; index < testCaseCount; index++)
            {
                tw.WriteLine(testList[index].external_id + "|" + testList[index].tc_id);

            }
            tw.Close();
        }



        public void ReportTestPass(String testCaseExternalId, String message)
        {

            int testCaseId = GetInternalTestCaseID(testCaseExternalId);


            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, _buildVersion, 0);

            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, 0, 0);
            }

        }

        public void ReportTestFail(int testCaseId, String message)
        {
            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Fail, 0, "test", false, true, message, _buildVersion, 0);
            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, 0, 0);

            }

        }

        public void ReportTestFail(String testCaseExternalId, String message)
        {
            int testCaseId = GetInternalTestCaseID(testCaseExternalId);

            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Fail, 0, "test", false, true, message, _buildVersion, 0);
            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, message, 0, 0);

            }

        }




        public void ReportTestBlocked(int testCaseId)
        {
            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, "Test Case is Blocked", _buildVersion, 0);
            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, "Test Case is Blocked", 0, 0);
            }

        }

        public void ReportTestBlocked(String testCaseExternalId)
        {

            int testCaseId = GetInternalTestCaseID(testCaseExternalId);

            if (_buildVersion != 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, "Test Case is Blocked", _buildVersion, 0);
            }

            if (_buildVersion == 0)
            {
                testLink.ReportTCResult(testCaseId, _testPlanId, TestCaseResultStatus.Pass, 0, "test", false, true, "Test Case is Blocked", 0, 0);
            }

        }

        public String GetTestCaseTitle(int testCaseId)
        {
            return testLink.GetTestCase(testCaseId).name;
        }

        public String GetTestCaseSteps(int testCaseId)
        {
            String testSteps = "Test steps to recreate the bug \n=======================";


            for (int index = 0; index < testLink.GetTestCase(testCaseId).steps.Count; index++)
            {
                testSteps = testSteps + "\n" + testLink.GetTestCase(testCaseId).steps[index].actions.Replace("<p>", "").Replace("</p>", "");
            }

            return testSteps;
        }

    }
}
