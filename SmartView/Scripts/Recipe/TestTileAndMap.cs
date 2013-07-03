﻿using System;
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
    public class TestTileAndMap:RecipeTestBase
    {
        String lodedInspectionNameInWebViewer = "";
        String lodedInspectionNameInDefectSummary = "";
        public TestTileAndMap()
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            Playback.PlaybackSettings.DelayBetweenActions = 3000;
            Playback.PlaybackSettings.SearchTimeout = 60000;
        }

 
        [TestMethod]
        public void TestRCPTMAddLaneBeforeExistingLane()
        {
            TestCaseID = "CGN-64";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.AddLanes("Before");            
            TileMap.ApplyTileMapSettings();  
        }

        [TestMethod]
        public void TestRCPTMAddLaneAftereExistingLane()
        {
            TestCaseID = "CGN-65";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.AddLanes("After");   
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMAddLaneAtTheEndOfTheTileMap()
        {
            TestCaseID = "CGN-66";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.AddLanes("Append");   
            TileMap.ApplyTileMapSettings();
        }
       
        [TestMethod]
        public void TestRCPTMDeleteSingleLane()
        {
            TestCaseID = "CGN-67";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DeleteSelectedLanes("Single");
            TileMap.ApplyTileMapSettings();
        }
               
        [TestMethod]
        public void TestRCPTMDeleteMultipleLane()
        {
            TestCaseID = "CGN-68";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DeleteSelectedLanes("Multiple");
            TileMap.ApplyTileMapSettings();
        }


        [TestMethod]
        public void TestRCPTMDefineLaneLayoutUsingLaneWidthOption()
        {
             TestCaseID = "CGN-56";   
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DefineLaneLayoutUsingLaneWidthOfOption(true, "600");
            TileMap.ApplyTileMapSettings();  

        }

        [TestMethod]
        public void TestRCPTMDefineLaneLayoutUsingNumberOfLanesOption()
        {
            TestCaseID = "CGN-57";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.DefineLaneLayoutUsingNumberOfLanesOption(true, "6");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMDefineRowHeight()
        {
            TestCaseID = "CGN-58";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetRowHeight("700");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMDefineRowSeverityThresholdAndAssignNotification()
        {
            TestCaseID = "CGN-59";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetRowSeverityThresholdAndAssignNotification("450");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMSetRowDefectDensityThresholdAndAssignOutput()
        {
            TestCaseID = "CGN-60";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetRowDefectDensityThresholdAndAssignOutput("99563");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMSetDensityCalculationArea()
        {
            TestCaseID = "CGN-61";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetDensityCalculationArea("15.2365");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMSetExcludeDefectWithSeverityIsLessThan()
        {
            TestCaseID = "CGN-62";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetExcludeDefectWithSeverityIsLessThan("6");
            TileMap.ApplyTileMapSettings();
        }

        [TestMethod]
        public void TestRCPTMSetSeverityThreshold()
        {
            TestCaseID = "CGN-63";
            TileMap.LoadTileMapDefinitionWindow("test", "view 1");
            TileMap.SetSeverityThreshold("600");
            TileMap.ApplyTileMapSettings();
        }

        

        [TestCleanup]
        public void TestCleanUp()
        {
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
