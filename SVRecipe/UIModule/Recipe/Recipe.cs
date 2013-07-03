namespace SVRecipe.UIModule.Recipe.RecipeClasses
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

    using System.Threading;

    public partial class UIMap
    {
    }
    public partial class Recipe
    {

        /// <summary>
        /// VerifyRecipeMangerLaunchedSuecessfully - Use 'VerifyRecipeMangerLaunchedSuecessfullyExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyRecipeMangerLaunchedSuecessfully(String architecture, String recipe)
        {
            #region Variable Declarations
            WinWindow uISmartViewRecipeManagWindow = this.UISmartViewRecipeManagWindow;
            WinComboBox uIItemComboBox = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemComboBox;
            WinTitleBar uISmartViewRecipeManagTitleBar = this.UISmartViewRecipeManagWindow.UISmartViewRecipeManagTitleBar;
            #endregion

            // Verify that 'SmartView Recipe Manager - test' window's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyRecipeMangerLaunchedSuecessfullyExpectedValues.UISmartViewRecipeManagWindowExists, uISmartViewRecipeManagWindow.Exists);

            // Verify that 'Unknown Name' combo box's property 'SelectedItem' equals '4 Camera'
            Assert.AreEqual(architecture, uIItemComboBox.SelectedItem);

            // Verify that 'SmartView Recipe Manager - test' title bar's property 'DisplayText' equals 'SmartView Recipe Manager - test'
            Assert.AreEqual(this.VerifyRecipeMangerLaunchedSuecessfullyExpectedValues.UISmartViewRecipeManagTitleBarDisplayText + recipe, uISmartViewRecipeManagTitleBar.DisplayText);
        }

        public virtual VerifyRecipeMangerLaunchedSuecessfullyExpectedValues VerifyRecipeMangerLaunchedSuecessfullyExpectedValues
        {
            get
            {
                if ((this.mVerifyRecipeMangerLaunchedSuecessfullyExpectedValues == null))
                {
                    this.mVerifyRecipeMangerLaunchedSuecessfullyExpectedValues = new VerifyRecipeMangerLaunchedSuecessfullyExpectedValues();
                }
                return this.mVerifyRecipeMangerLaunchedSuecessfullyExpectedValues;
            }
        }

        private VerifyRecipeMangerLaunchedSuecessfullyExpectedValues mVerifyRecipeMangerLaunchedSuecessfullyExpectedValues;

        /// <summary>
        /// ClickOpenButton
        /// </summary>
        public void ClickOpenButton()
        {
            #region Variable Declarations
            WinMenuBar uIApplicationMenuBar = this.UISmartViewRecipeManagWindow.UIApplicationMenuBar;
            #endregion

            // Click 'Application' menu bar
            Mouse.Click(uIApplicationMenuBar, new Point(64, 40));
        }

        /// <summary>
        /// CloseRecipeManagerApplication
        /// </summary>
        public void CloseRecipeManagerApplication()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewRecipeManagWindow.UISmartViewRecipeManagTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(16, 11));
        }

        /// <summary>
        /// LoadClassesDialogBox
        /// </summary>
        public void LoadClassesDialogBox(String classClassifier)
        {
            #region Variable Declarations
            WinTreeItem uIBasicTreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UIBasicTreeItem;
            uIBasicTreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = classClassifier;
            #endregion

            // Double-Click 'Line' -> 'Station' -> 'View 1' -> 'Basic' tree item
            Mouse.DoubleClick(uIBasicTreeItem, new Point(4, 8));
        }

        /// <summary>
        /// LoadRecipeAliasesWindow
        /// </summary>
        public void LoadRecipeAliasesWindow()
        {
            #region Variable Declarations
            //WinMenuBar uIApplicationMenuBar = this.UISmartViewRecipeManagWindow.UIApplicationMenuBar;
            WinMenuBar uIApplicationMenuBar = (WinMenuBar)this.UISmartViewRecipeManagWindow.GetChildren()[2];
            #endregion

            TextWriter tw = new StreamWriter("D:\\testapp.txt");
            for (int i = 0; i < this.UISmartViewRecipeManagWindow.GetChildren().Count; i++)
            {
                tw.WriteLine(this.UISmartViewRecipeManagWindow.GetChildren()[i].GetType().ToString());
                tw.WriteLine(this.UISmartViewRecipeManagWindow.GetChildren()[i].GetChildren().Count);
            }

            tw.WriteLine("=======================================" + uIApplicationMenuBar.GetChildren().Count);

            for (int i = 0; i < uIApplicationMenuBar.GetChildren().Count; i++)
            {
                tw.WriteLine("=======================================");
                tw.WriteLine(uIApplicationMenuBar.GetChildren()[i].GetType().ToString());
            }
            tw.Close();
            // Click 'Application' menu bar
            Thread.Sleep(10000);
            Mouse.Click(new Point(174, 38));
        }

        /// <summary>
        /// AssignClassifierToRecipe - Use 'AssignClassifierToRecipeParams' to pass parameters into this method.
        /// </summary>
        public void AssignClassifierToRecipe(String name)
        {
            #region Variable Declarations
            WinClient uIWorkspaceClient = this.UISmartViewRecipeManagWindow1.UIItemWindow.UIWorkspaceClient;
            WinTreeItem uIBasicTreeItem = this.UISmartViewRecipeManagWindow1.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UIBasicTreeItem;
            WinMenuItem uISelectClassifierMenuItem = this.UIItemWindow.UIContextMenu.UISelectClassifierMenuItem;
            WinList uIItemList = this.UISelectClassifierWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton = this.UISelectClassifierWindow.UIOKWindow.UIOKButton;
            #endregion
           uIBasicTreeItem. WindowTitles.Add("SmartView Recipe Manager - " + name);
            // Click 'Workspace' client
            //Mouse.Click(uIWorkspaceClient, new Point(501, 481));

            // Click 'Line' -> 'Station' -> 'View 1' -> 'Basic' tree item
            Mouse.Click(uIBasicTreeItem, new Point(12, 8));

            // Right-Click 'Line' -> 'Station' -> 'View 1' -> 'Basic' tree item
            Mouse.Click(uIBasicTreeItem, MouseButtons.Right, ModifierKeys.None, new Point(12, 8));

            // Click 'Select Classifier...' menu item
            Mouse.Click(uISelectClassifierMenuItem, new Point(36, 13));

            // Select 'Basic-Test' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = name;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(52, 17));
        }

        public virtual AssignClassifierToRecipeParams AssignClassifierToRecipeParams
        {
            get
            {
                if ((this.mAssignClassifierToRecipeParams == null))
                {
                    this.mAssignClassifierToRecipeParams = new AssignClassifierToRecipeParams();
                }
                return this.mAssignClassifierToRecipeParams;
            }
        }

        private AssignClassifierToRecipeParams mAssignClassifierToRecipeParams;
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyRecipeMangerLaunchedSuecessfully'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyRecipeMangerLaunchedSuecessfullyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'SmartView Recipe Manager - test' window's property 'Exists' equals 'True'
        /// </summary>
        public bool UISmartViewRecipeManagWindowExists = true;

        /// <summary>
        /// Verify that 'Unknown Name' combo box's property 'SelectedItem' equals '4 Camera'
        /// </summary>
        public string UIItemComboBoxSelectedItem = "4 Camera";

        /// <summary>
        /// Verify that 'SmartView Recipe Manager - test' title bar's property 'DisplayText' equals 'SmartView Recipe Manager - test'
        /// </summary>
        public string UISmartViewRecipeManagTitleBarDisplayText = "SmartView Recipe Manager - ";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'AssignClassifierToRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AssignClassifierToRecipeParams
    {

        #region Fields
        /// <summary>
        /// Select 'Basic-Test' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Basic-Test";
        #endregion
}
}
