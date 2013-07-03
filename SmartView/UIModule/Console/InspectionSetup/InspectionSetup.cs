namespace SmartView.UIModule.Console.InspectionSetup.InspectionSetupClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.IO;


    public partial class UIMap
    {
    }
    public partial class InspectionSetup
    {

        /// <summary>
        /// LoadAndStartInspection
        /// </summary>
        public String LoadAndStartInspection(String recipe)
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            WinEdit uIItemEdit = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText2Window.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText1Window.UIItemEdit;
            WinButton uILoadandStartButton = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UILoadandStartWindow.UILoadandStartButton;
            #endregion

            String inspectionName = "";
            // Double-Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(63, 238));
            SelectRecipe(recipe);
            inspectionName = GetInspectionName();

            // Click 'Load and Start' button
            Mouse.Click(uILoadandStartButton, new Point(74, 12));
            return inspectionName;
        }

        public void SetRollAndLoadAndStartInspection(String recipe)
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            WinEdit uIItemEdit = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText2Window.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText1Window.UIItemEdit;
            WinButton uILoadandStartButton = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UILoadandStartWindow.UILoadandStartButton;
            #endregion

            String inspectionName = "";
            // Double-Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(63, 238));
            SelectRecipe(recipe);
            SetRollAndNumber(recipe);
            inspectionName = GetInspectionName();

            // Click 'Load and Start' button
            Mouse.Click(uILoadandStartButton, new Point(74, 12));
            // return inspectionName;
        }

        /// <summary>
        /// GetInspectionName - Use 'GetInspectionNameExpectedValues' to pass parameters into this method.
        /// </summary>
        public String GetInspectionName()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText1Window.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText2Window.UIItemEdit;
            #endregion

            String inspectionName = uIItemEdit.Text + "-" + uIItemEdit1.Text;
            return inspectionName;


        }

        public void SetRollInInspectionSetup(String roll)
        {
            WinEdit uIItemEdit = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIText2Window.UIItemEdit;
            uIItemEdit.Text = "atm";
        }

        public virtual GetInspectionNameExpectedValues GetInspectionNameExpectedValues
        {
            get
            {
                if ((this.mGetInspectionNameExpectedValues == null))
                {
                    this.mGetInspectionNameExpectedValues = new GetInspectionNameExpectedValues();
                }
                return this.mGetInspectionNameExpectedValues;
            }
        }

        private GetInspectionNameExpectedValues mGetInspectionNameExpectedValues;

        /// <summary>
        /// SelectRecipe - Use 'SelectRecipeParams' to pass parameters into this method.
        /// </summary>
        public void SelectRecipe(String Recipe)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UISmartViewConsole4CamWindow.UIInspectionSetupWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Select 'test' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = Recipe;
        }

        public virtual SelectRecipeParams SelectRecipeParams
        {
            get
            {
                if ((this.mSelectRecipeParams == null))
                {
                    this.mSelectRecipeParams = new SelectRecipeParams();
                }
                return this.mSelectRecipeParams;
            }
        }

        private SelectRecipeParams mSelectRecipeParams;

        /// <summary>
        /// SetRollAndNumber - Use 'SetRollAndNumberParams' to pass parameters into this method.
        /// </summary>
        public void SetRollAndNumber(String architecture)
        {
            #region Variable Declarations
            //WinEdit uIItemEdit = this.UISmartViewConsoleATM7Window.UIInspectionSetupWindow.UIText1Window.UIItemEdit;
            UITestControlCollection COL = this.UISmartViewConsoleATM7Window.UIInspectionSetupWindow.UIText1Window.GetChildren();
            TextWriter TW = new StreamWriter("D:\\qa\\test.txt");
            for (int i = 0; i < COL.Count; i++)
            {
                TW.WriteLine(COL[i].GetType());
            }
            TW.Close();
            WinEdit uIItemEdit = (WinEdit)this.UISmartViewConsoleATM7Window.UIInspectionSetupWindow.UIText1Window.GetChildren()[3];
            WinEdit uIItemEdit1 = this.UISmartViewConsoleATM7Window.UIInspectionSetupWindow.UIText2Window.UIItemEdit;
            #endregion
            //uIItemEdit.WindowTitles.Add("SmartView Console: "+architecture+", Station");
            uIItemEdit1.WindowTitles.Add("SmartView Console: " + architecture + ", Station");
            // Type 'test' in 'Unknown Name' text box
            uIItemEdit.Text = "Automation";

            // Type '1' in 'Unknown Name' text box
            //uIItemEdit1.Text = this.SetRollAndNumberParams.UIItemEditText1;
        }

        public virtual SetRollAndNumberParams SetRollAndNumberParams
        {
            get
            {
                if ((this.mSetRollAndNumberParams == null))
                {
                    this.mSetRollAndNumberParams = new SetRollAndNumberParams();
                }
                return this.mSetRollAndNumberParams;
            }
        }

        private SetRollAndNumberParams mSetRollAndNumberParams;
    }
    /// <summary>
    /// Parameters to be passed into 'GetInspectionName'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GetInspectionNameExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Unknown Name' text box's property 'SelectionText' equals 'Sv60_15_6'
        /// </summary>
        public string UIItemEditSelectionText = "Sv60_15_6";

        /// <summary>
        /// Verify that 'Unknown Name' text box's property 'Text' equals '325'
        /// </summary>
        public string UIItemEditText = "325";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectRecipeParams
    {

        #region Fields
        /// <summary>
        /// Select 'test' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "test";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetRollAndNumber'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetRollAndNumberParams
    {

        #region Fields
        /// <summary>
        /// Type 'test' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "test";

        /// <summary>
        /// Type '1' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "1";
        #endregion
}
}
