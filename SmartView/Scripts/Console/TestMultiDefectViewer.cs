using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using SmartView.Library;
using System.IO;
using System.Threading;



namespace SmartView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestMultiDefectViewer:ConsoleTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestMultiDefectViewer()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            console.CloseSystemWarningsWindow();
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

        [TestMethod]
        public void TestCNLMDVLaunchMultiDefectViewer()
        {
            TestCaseID = "CGN-130";
            MultiDefectViewerDisplayOption.LoadMultiDefectViewer();
        }

        [TestMethod]
        public void TestCNLMDVCloseMultiDefectViewer()
        {
            TestCaseID = "CGN-131";
            MultiDefectViewerDisplayOption.CloseMultiDefectViewer();
        }

        // Display option test cases.
        // ==========================

        [TestMethod]
        public void TestCNLMDVLayout()
        {
            TestCaseID = "CGN-106";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineLayout("3","4");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowBothClassAndViewInHeaders()
        {
            TestCaseID = "CGN-107";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, true, true);
            MultiDefectViewerDisplayOption.ClickOk();
        }


        [TestMethod]
        public void TestCNLMDVShowClassInHeaders()
        {
            TestCaseID = "CGN-132";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, true, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVShowViewInHeaders()
        {
            TestCaseID = "CGN-133";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, false, true);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVShowHeaders()
        {
            TestCaseID = "CGN-134";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, false, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVHideHeaders()
        {
            TestCaseID = "CGN-135";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(false, false, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVShowDefectBoxes()
        {
            TestCaseID = "CGN-108";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectBoxes(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectBoxes(true);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVHideDefectBoxes()
        {
            TestCaseID = "CGN-136";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectBoxes(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectBoxes(false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        public void TestCNLMDVShowDefectLabels()
        {
            TestCaseID = "CGN-109";
            String[] labels = { "Class","Symbol","Severity","Defect No.","Box Top","Box Bottom"};
            for (int index = 0; index < labels.Length; index ++ )
            {
                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.ShowDefectLabels(true, labels[index]);
                MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.VerifyShowDefectLabels(true, labels[index]);
                MultiDefectViewerDisplayOption.ClickOk();
            }           
        }

        [TestMethod]
        public void TestCNLMDVHideDefectLabels()
        {
            TestCaseID = "CGN-137";
            
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectLabels(false, "");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectLabels(false, "");
            MultiDefectViewerDisplayOption.ClickOk();
            
        }

        [TestMethod]
        public void TestCNLMDVShowImage()
        {
            TestCaseID = "CGN-113";
            
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVHideImage()
        {
            TestCaseID = "CGN-112";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }


        [TestMethod]
        public void TestCNLMDVShowImageWithCrosswebAndDownwebLocator()
        {
            TestCaseID = "CGN-114";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowImageWithCrosswebLocator()
        {
            TestCaseID = "CGN-115";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowImageWithDownwebLocator()
        {
            TestCaseID = "CGN-116";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowDefectFaturesLeftTheDefectImage()
        {
            TestCaseID = "CGN-117";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(true, "left");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(true, "left");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowDefectFaturesAboveTheDefectImage()
        {
            TestCaseID = "CGN-138";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(true, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(true, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVHideDefectFatures()
        {
            TestCaseID = "CGN-139";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(false, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(false, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        public void TestCNLMDVShowPointerToolbar()
        {
            TestCaseID = "CGN-140";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowPointerToolbar(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowPointerToolbar(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();


        }

        [TestMethod]
        public void TestCNLMDVHidePointerToolbar()
        {
            TestCaseID = "CGN-141";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowPointerToolbar(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowPointerToolbar(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();


        }

        [TestMethod]
        public void TestCNLMDVDefineColorMap()
        {
            TestCaseID = "CGN-118";

            String[] colorMaps = { "Normal","Blue shade","Difference","Spectrum","Contour","Equalized"};
            for (int index = 0; index < colorMaps.Length; index++)
            {
                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.DefineGrayColormap(colorMaps[index], false);
                MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.VerifyGrayColormap(colorMaps[index], false);
                MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
            }            
        }

        [TestMethod]
        public void TestCNLMDVDefineColorMapWithInvert()
        {
            TestCaseID = "CGN-119";

            String[] colorMaps = { "Normal", "Blue shade", "Difference", "Spectrum", "Contour", "Equalized" };
            for (int index = 0; index < colorMaps.Length; index++)
            {
                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.DefineGrayColormap(colorMaps[index], true);
                MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

                MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
                MultiDefectViewerDisplayOption.VerifyGrayColormap(colorMaps[index], true);
                MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
            }
        }

        [TestMethod]
        public void TestCNLMDVEnableThresholdedPixelWithIntensityLevel()
        {
            TestCaseID = "CGN-121";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineGrayThresholdedPixel(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyGrayThresholdedPixel(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

        }

        [TestMethod]
        public void TestCNLMDVEnableThresholdedPixelWithGrayBins()
        {
            TestCaseID = "CGN-122";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineGrayThresholdedPixel(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyGrayThresholdedPixel(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

        }

        [TestMethod]
        public void TestCNLMDVDisableThresholdedPixel()
        {
            TestCaseID = "CGN-120";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineGrayThresholdedPixel(false, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyGrayThresholdedPixel(false, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

        }


        // Live mode settings test cases
        //========================================
              

        [TestMethod]
        public void TestCNLMDVEnableLiveModeStopScrollOnSelection()
        {
            TestCaseID = "CGN-123";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVDisableLiveModeStopScrollOnSelection()
        {
            TestCaseID = "CGN-142";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVEnableAutomaticallyResumeLiveMode()
        {
            TestCaseID = "CGN-125";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeResumeScrollAutomatically(true, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeResumeScrollAutomatically(true, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVDisableAutomaticallyResumeLiveMode()
        {
            TestCaseID = "CGN-143";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeResumeScrollAutomatically(false, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeResumeScrollAutomatically(false, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVLiveModeMinimumDisplayTime()
        {
            TestCaseID = "CGN-144";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DefineDefectMinimumDisplayTime("6");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VeroifyDefineDefectMinimumDisplayTime("6");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }


        [TestMethod]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithTime()
        {
            TestCaseID = "CGN-126";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "time", "4", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(10000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "time", "4", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

        }

        [TestMethod]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithLength()
        {
            TestCaseID = "CGN-145";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "length", "10", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(20000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "length", "10.00", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithDelayLoadingNextInspection()
        {
            TestCaseID = "CGN-146";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "length", "10", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(20000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "length", "10.00", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        public void TestCNLMDVLiveModeDisableDelayDefectDisplay()
        {
            TestCaseID = "CGN-147";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(false, "length", "10", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(false, "length", "10.00", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        //Define query test cases.

         [TestMethod]
        public void TestCNLMDVDefineQueryEnable()
        {
            TestCaseID = "CGN-149";
            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.EnableQueryDefinition(true);
            MultiDefectViewerTools.ApplyQuerySettings();

            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.VerifyEnableQueryDefinition(true);
            MultiDefectViewerTools.ApplyQuerySettings();
        }

         [TestMethod]
        public void TestCNLMDVDefineQueryDisable()
        {
            TestCaseID = "CGN-150";
            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.EnableQueryDefinition(false);
            MultiDefectViewerTools.ApplyQuerySettings();

            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.VerifyEnableQueryDefinition(false);
            MultiDefectViewerTools.ApplyQuerySettings();
        }

         [TestMethod]
         public void TestCNLMDVDefineQueryByAll()
         {
             TestCaseID = "CGN-150";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByAll(true);
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryByAll(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         public void TestCNLMDVDefineQueryBySeverity()
         {
             TestCaseID = "CGN-151";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryBySeverity(true,"5");
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryBySeverity(true, "5");
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         public void TestCNLMDVDefineQueryBySelectedClasses()
         {
             TestCaseID = "CGN-152";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryBySelectedClasses(true);
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryBySelectedClasses(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         public void TestCNLMDVDefineQueryByAllLanes()
         {
             TestCaseID = "CGN-153";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByLanes(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         public void TestCNLMDVDefineQueryBySelectedLanes()
         {
             TestCaseID = "CGN-154";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByLanes(false);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

        //Moving to a Specific Defect

        [TestMethod]
        public void TestCNLMDVMoveToDefectBySpecifingViewAndDefectNo()
        {
            
             TestCaseID = "CGN-127";
             MultiDefectViewerTools.LoadGoToWindow();
             MultiDefectViewerTools.NavigateByDefectNoAndView("View 1","15");
        }

        [TestMethod]
        public void TestCNLMDVMoveToDefectBySpecifingViewAndInvalidDefectNo()
        {

            TestCaseID = "CGN-128";
            MultiDefectViewerTools.LoadGoToWindow();
            MultiDefectViewerTools.NavigateByDefectNoAndView("View 1", "100025");
        }

        [TestMethod]
        public void TestCNLMDVMoveToDefectBySpecifingPosition()
        {

            TestCaseID = "CGN-129";
            MultiDefectViewerTools.LoadGoToWindow();
            MultiDefectViewerTools.NavigateByPosition("125");
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            //console.CloseSystemWarningsWindow();
            if (IsUpdateTestResult.Equals("true"))
            {
                String testStatus = testContextInstance.CurrentTestOutcome.ToString();
                TC.UpdateTCStatus(TestCaseID, testStatus, ErrorMessage);
            }
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        
    }
}
