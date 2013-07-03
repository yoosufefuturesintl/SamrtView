namespace SmartView.UIModule.Recipe.Aliases.AliasesClasses
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


    public partial class UIMap
    {
    }
    public partial class Aliases
    {

        /// <summary>
        /// AddAliases - Use 'AddAliasesParams' to pass parameters into this method.
        /// </summary>
        public void AddAliases(String aliasesName, String Recipe)
        {
            #region Variable Declarations
            WinButton uIAddButton = this.UIRecipeAliasestestWindow.UIAddWindow.UIAddButton;
            WinEdit uIItemEdit = this.UIRecipeAliasestestWindow.UINewAliasWindow.UIItemEdit;
            #endregion

            // Click 'Add' button
            Mouse.Click(uIAddButton, new Point(47, 12));

            // Type 'TestAliases' in 'Unknown Name' text box
            uIItemEdit.Text = aliasesName;
            SelectAliasesWindow(Recipe);
        }

        public void VerifyAliasesNameInAliasesList(String aliasesName)
        {
            #region Variable Declarations
            WinButton uIAddButton = this.UIRecipeAliasestestWindow.UIAddWindow.UIAddButton;
            WinEdit uIItemEdit = this.UIRecipeAliasestestWindow.UINewAliasWindow.UIItemEdit;
            #endregion

            Assert.AreEqual(aliasesName, uIItemEdit.Text);            
        }

        public void VerifyIsAliasesAvailableInAliasesList(bool isAvailable)
        {
            #region Variable Declarations
            WinButton uIAddButton = this.UIRecipeAliasestestWindow.UIAddWindow.UIAddButton;
            WinEdit uIItemEdit = this.UIRecipeAliasestestWindow.UINewAliasWindow.UIItemEdit;
            #endregion

            Assert.AreEqual(isAvailable, uIItemEdit.Exists);
        }

        public virtual AddAliasesParams AddAliasesParams
        {
            get
            {
                if ((this.mAddAliasesParams == null))
                {
                    this.mAddAliasesParams = new AddAliasesParams();
                }
                return this.mAddAliasesParams;
            }
        }

        private AddAliasesParams mAddAliasesParams;

        /// <summary>
        /// ClickOkBurttonInAliasesDuplicateNameErrorMessage
        /// </summary>
        public void ClickOkBurttonInAliasesDuplicateNameErrorMessage()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(72, 17));
        }

        /// <summary>
        /// CloseAliasesWindow
        /// </summary>
        public void CloseAliasesWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIRecipeAliasestestWindow.UICloseWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(45, 12));
        }

        /// <summary>
        /// DeleteAliases
        /// </summary>
        public void DeleteAliases(String aliasesName, String recipeName)
        {
            #region Variable Declarations
            WinTreeItem uITestAliasesTreeItem = this.UIRecipeAliasestestWindow.UIItemWindow.UIItemTree.UITestAliasesTreeItem;
            WinButton uIDeleteButton = this.UIRecipeAliasestestWindow.UIDeleteWindow.UIDeleteButton;
            WinButton uIYesButton = this.UIConfirmDeleteWindow.UIYesWindow.UIYesButton;
            uITestAliasesTreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = aliasesName;
            uITestAliasesTreeItem.WindowTitles.Add("Recipe Aliases - " + recipeName);
            #endregion

            // Click 'TestAliases' tree item
            Mouse.Click(uITestAliasesTreeItem, new Point(21, 9));

            // Click 'Delete' button
            Mouse.Click(uIDeleteButton, new Point(28, 15));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(46, 12));
        }

        /// <summary>
        /// VerifyAliasesDuplicateNameErrorMessage - Use 'VerifyAliasesDuplicateNameErrorMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyAliasesDuplicateNameErrorMessage()
        {
            #region Variable Declarations
            WinText uIDuplicatenameenteredText = this.UISmartViewWindow.UIDuplicatenameenteredWindow.UIDuplicatenameenteredText;
            WinButton uIOKButton = this.UISmartViewWindow.UIOKWindow.UIOKButton;
            #endregion

            // Verify that 'Duplicate name entered; please correct.' label's property 'DisplayText' equals 'Duplicate name entered; please correct.'
           // Assert.AreEqual(this.VerifyAliasesDuplicateNameErrorMessageExpectedValues.UIDuplicatenameenteredTextDisplayText, uIDuplicatenameenteredText.DisplayText);

            // Verify that 'OK' button's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyAliasesDuplicateNameErrorMessageExpectedValues.UIOKButtonExists, uIOKButton.Exists);
        }

        public virtual VerifyAliasesDuplicateNameErrorMessageExpectedValues VerifyAliasesDuplicateNameErrorMessageExpectedValues
        {
            get
            {
                if ((this.mVerifyAliasesDuplicateNameErrorMessageExpectedValues == null))
                {
                    this.mVerifyAliasesDuplicateNameErrorMessageExpectedValues = new VerifyAliasesDuplicateNameErrorMessageExpectedValues();
                }
                return this.mVerifyAliasesDuplicateNameErrorMessageExpectedValues;
            }
        }

        private VerifyAliasesDuplicateNameErrorMessageExpectedValues mVerifyAliasesDuplicateNameErrorMessageExpectedValues;

        /// <summary>
        /// SelectAliasesWindow
        /// </summary>
        public void SelectAliasesWindow(String Recipe)
        {
            #region Variable Declarations
            WinTitleBar uIRecipeAliasestestTitleBar = this.UIRecipeAliasestestWindow.UIRecipeAliasestestTitleBar;
            uIRecipeAliasestestTitleBar.WindowTitles.Add("Recipe Aliases - "+Recipe);
            #endregion

            // Click 'Recipe Aliases - test' title bar
            Mouse.Click(uIRecipeAliasestestTitleBar, new Point(53, 7));
}
    }
    /// <summary>
    /// Parameters to be passed into 'AddAliases'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AddAliasesParams
    {

        #region Fields
        /// <summary>
        /// Type 'TestAliases' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "TestAliases";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyAliasesDuplicateNameErrorMessage'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyAliasesDuplicateNameErrorMessageExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Duplicate name entered; please correct.' label's property 'DisplayText' equals 'Duplicate name entered; please correct.'
        /// </summary>
        public string UIDuplicatenameenteredTextDisplayText = "Duplicate name entered; please correct.";

        /// <summary>
        /// Verify that 'OK' button's property 'Exists' equals 'True'
        /// </summary>
        public bool UIOKButtonExists = true;
        #endregion
}
}
