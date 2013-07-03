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
using SmartView.Test.Library.Application;
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
        [TestProperty("TestLinkExternalID", "130")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLaunchMultiDefectViewer()
        {
            TestCaseExternalID = "CGN-130";
            MultiDefectViewerDisplayOption.LoadMultiDefectViewer();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "131")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVCloseMultiDefectViewer()
        {
            TestCaseExternalID = "CGN-131";
            MultiDefectViewerDisplayOption.CloseMultiDefectViewer();
        }

        // Display option test cases.
        // ==========================

        [TestMethod]
        [TestProperty("TestLinkExternalID", "106")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLayout()
        {
            TestCaseExternalID = "CGN-106";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineLayout("3","4");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "107")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowBothClassAndViewInHeaders()
        {
            TestCaseExternalID = "CGN-107";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, true, true);
            MultiDefectViewerDisplayOption.ClickOk();
        }


        [TestMethod]
        [TestProperty("TestLinkExternalID", "132")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowClassInHeaders()
        {
            TestCaseExternalID = "CGN-132";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, true, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "133")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowViewInHeaders()
        {
            TestCaseExternalID = "CGN-133";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, false, true);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "134")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowHeaders()
        {
            TestCaseExternalID = "CGN-134";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(true, false, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "135")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHideHeaders()
        {
            TestCaseExternalID = "CGN-135";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowHeader(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowHeader(false, false, false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "108")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowDefectBoxes()
        {
            TestCaseExternalID = "CGN-108";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectBoxes(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectBoxes(true);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "136")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHideDefectBoxes()
        {
            TestCaseExternalID = "CGN-136";
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectBoxes(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectBoxes(false);
            MultiDefectViewerDisplayOption.ClickOk();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "109")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowDefectLabels()
        {
            TestCaseExternalID = "CGN-109";
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
        [TestProperty("TestLinkExternalID", "137")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHideDefectLabels()
        {
            TestCaseExternalID = "CGN-137";
            
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowDefectLabels(false, "");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowDefectLabels(false, "");
            MultiDefectViewerDisplayOption.ClickOk();
            
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "113")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowImage()
        {
            TestCaseExternalID = "CGN-113";
            
            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "112")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHideImage()
        {
            TestCaseExternalID = "CGN-112";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(false, false, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }


        [TestMethod]
        [TestProperty("TestLinkExternalID", "114")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowImageWithCrosswebAndDownwebLocator()
        {
            TestCaseExternalID = "CGN-114";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, true, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "115")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowImageWithCrosswebLocator()
        {
            TestCaseExternalID = "CGN-115";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "116")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowImageWithDownwebLocator()
        {
            TestCaseExternalID = "CGN-116";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowImage(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowImage(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "117")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowDefectFaturesLeftTheDefectImage()
        {
            TestCaseExternalID = "CGN-117";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(true, "left");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(true, "left");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "138")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowDefectFaturesAboveTheDefectImage()
        {
            TestCaseExternalID = "CGN-138";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(true, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(true, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "139")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHideDefectFatures()
        {
            TestCaseExternalID = "CGN-139";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowFeatures(false, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowFeatures(false, "top");
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "140")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVShowPointerToolbar()
        {
            TestCaseExternalID = "CGN-140";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowPointerToolbar(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowPointerToolbar(true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();


        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "141")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVHidePointerToolbar()
        {
            TestCaseExternalID = "CGN-141";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.ShowPointerToolbar(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyShowPointerToolbar(false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();


        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "118")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDefineColorMap()
        {
            TestCaseExternalID = "CGN-118";

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
        [TestProperty("TestLinkExternalID", "119")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDefineColorMapWithInvert()
        {
            TestCaseExternalID = "CGN-119";

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
        [TestProperty("TestLinkExternalID", "121")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVEnableThresholdedPixelWithIntensityLevel()
        {
            TestCaseExternalID = "CGN-121";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineGrayThresholdedPixel(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyGrayThresholdedPixel(true, true, false);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "122")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVEnableThresholdedPixelWithGrayBins()
        {
            TestCaseExternalID = "CGN-122";

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.DefineGrayThresholdedPixel(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

            MultiDefectViewerDisplayOption.LoadDisplayOptionsWindow();
            MultiDefectViewerDisplayOption.VerifyGrayThresholdedPixel(true, false, true);
            MultiDefectViewerDisplayOption.ApplyAndCloseDisplaySettings();

        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "120")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDisableThresholdedPixel()
        {
            TestCaseExternalID = "CGN-120";

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
        [TestProperty("TestLinkExternalID", "123")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVEnableLiveModeStopScrollOnSelection()
        {
            TestCaseExternalID = "CGN-123";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "142")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDisableLiveModeStopScrollOnSelection()
        {
            TestCaseExternalID = "CGN-142";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeStopScrollOnSelection(true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "125")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVEnableAutomaticallyResumeLiveMode()
        {
            TestCaseExternalID = "CGN-125";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeResumeScrollAutomatically(true, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeResumeScrollAutomatically(true, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "143")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDisableAutomaticallyResumeLiveMode()
        {
            TestCaseExternalID = "CGN-143";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.LiveModeResumeScrollAutomatically(false, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyLiveModeResumeScrollAutomatically(false, "45");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "144")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLiveModeMinimumDisplayTime()
        {
            TestCaseExternalID = "CGN-144";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DefineDefectMinimumDisplayTime("6");
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VeroifyDefineDefectMinimumDisplayTime("6");
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }


        [TestMethod]
        [TestProperty("TestLinkExternalID", "126")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithTime()
        {
            TestCaseExternalID = "CGN-126";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "time", "4", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(10000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "time", "4", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "145")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithLength()
        {
            TestCaseExternalID = "CGN-145";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "length", "10", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(20000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "length", "10.00", false);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "146")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLiveModeDelayDefectDisplayWithDelayLoadingNextInspection()
        {
            TestCaseExternalID = "CGN-146";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(true, "length", "10", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            Thread.Sleep(20000);

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(true, "length", "10.00", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "147")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVLiveModeDisableDelayDefectDisplay()
        {
            TestCaseExternalID = "CGN-147";
            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.DelayDefectDisplay(false, "length", "10", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();

            MultiDefectViewerTools.LoadLiveModeSettingsWindow();
            MultiDefectViewerTools.VerifyDelayDefectDisplay(false, "length", "10.00", true);
            MultiDefectViewerTools.ApplyLiveModeSettings();
        }

        //Define query test cases.

         [TestMethod]
        [TestProperty("TestLinkExternalID", "149")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDefineQueryEnable()
        {
            TestCaseExternalID = "CGN-149";
            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.EnableQueryDefinition(true);
            MultiDefectViewerTools.ApplyQuerySettings();

            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.VerifyEnableQueryDefinition(true);
            MultiDefectViewerTools.ApplyQuerySettings();
        }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "150")]
         [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVDefineQueryDisable()
        {
            TestCaseExternalID = "CGN-150";
            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.EnableQueryDefinition(false);
            MultiDefectViewerTools.ApplyQuerySettings();

            MultiDefectViewerTools.LoadQueryDefinitionWindow();
            MultiDefectViewerTools.VerifyEnableQueryDefinition(false);
            MultiDefectViewerTools.ApplyQuerySettings();
        }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "150")]
         [TestProperty("TestLinkInternalID", "162")]
         public void TestCNLMDVDefineQueryByAll()
         {
             TestCaseExternalID = "CGN-150";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByAll(true);
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryByAll(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "151")]
         [TestProperty("TestLinkInternalID", "162")]
         public void TestCNLMDVDefineQueryBySeverity()
         {
             TestCaseExternalID = "CGN-151";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryBySeverity(true,"5");
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryBySeverity(true, "5");
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "152")]
         [TestProperty("TestLinkInternalID", "162")]
         public void TestCNLMDVDefineQueryBySelectedClasses()
         {
             TestCaseExternalID = "CGN-152";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryBySelectedClasses(true);
             MultiDefectViewerTools.ApplyQuerySettings();

             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.VerifyDefineQueryBySelectedClasses(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "153")]
         [TestProperty("TestLinkInternalID", "162")]
         public void TestCNLMDVDefineQueryByAllLanes()
         {
             TestCaseExternalID = "CGN-153";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByLanes(true);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

         [TestMethod]
         [TestProperty("TestLinkExternalID", "154")]
         [TestProperty("TestLinkInternalID", "162")]
         public void TestCNLMDVDefineQueryBySelectedLanes()
         {
             TestCaseExternalID = "CGN-154";
             MultiDefectViewerTools.LoadQueryDefinitionWindow();
             MultiDefectViewerTools.DefineQueryByLanes(false);
             MultiDefectViewerTools.ApplyQuerySettings();
         }

        //Moving to a Specific Defect

        [TestMethod]
         [TestProperty("TestLinkExternalID", "127")]
         [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVMoveToDefectBySpecifingViewAndDefectNo()
        {
            
             TestCaseExternalID = "CGN-127";
             MultiDefectViewerTools.LoadGoToWindow();
             MultiDefectViewerTools.NavigateByDefectNoAndView("View 1","15");
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "128")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVMoveToDefectBySpecifingViewAndInvalidDefectNo()
        {

            TestCaseExternalID = "CGN-128";
            MultiDefectViewerTools.LoadGoToWindow();
            MultiDefectViewerTools.NavigateByDefectNoAndView("View 1", "100025");
        }

        [TestMethod]
        [TestProperty("TestLinkExternalID", "129")]
        [TestProperty("TestLinkInternalID", "162")]
        public void TestCNLMDVMoveToDefectBySpecifingPosition()
        {

            TestCaseExternalID = "CGN-129";
            MultiDefectViewerTools.LoadGoToWindow();
            MultiDefectViewerTools.NavigateByPosition("125");
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            //console.CloseSystemWarningsWindow();
            String testStatus = testContextInstance.CurrentTestOutcome.ToString();
            CleanUp(testContextInstance);
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
