namespace SVPQA.UIModule.PQA.TrendViewer.TrendWizardClasses
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
    public partial class TrendWizard
    {

        /// <summary>
        /// CloseTrendWizardWindow
        /// </summary>
        public void CloseTrendWizardWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UITrendWizardWindow.UITrendWizardTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(9, 9));
        }

        /// <summary>
        /// DisplayBarPlotInTrendViewer - Use 'DisplayBarPlotInTrendViewerParams' to pass parameters into this method.
        /// </summary>
        public void DisplayBarPlotInTrendViewer()
        {
            #region Variable Declarations
            WinRadioButton uIBarplotRadioButton = this.UITrendWizardWindow.UIBarplotWindow.UIBarplotRadioButton;
            #endregion
            if (!uIBarplotRadioButton.Selected)
            {
                // Select 'Bar plot' radio button
                uIBarplotRadioButton.Selected = this.DisplayBarPlotInTrendViewerParams.UIBarplotRadioButtonSelected;
            }

        }

        public virtual DisplayBarPlotInTrendViewerParams DisplayBarPlotInTrendViewerParams
        {
            get
            {
                if ((this.mDisplayBarPlotInTrendViewerParams == null))
                {
                    this.mDisplayBarPlotInTrendViewerParams = new DisplayBarPlotInTrendViewerParams();
                }
                return this.mDisplayBarPlotInTrendViewerParams;
            }
        }

        private DisplayBarPlotInTrendViewerParams mDisplayBarPlotInTrendViewerParams;

        /// <summary>
        /// LoardTrendWizard
        /// </summary>
        public void LoardTrendWizard()
        {
            #region Variable Declarations
            WinButton uITrendWizardButton = this.UISmartViewProductionQWindow.UITrendViewerWindow.UIToolbarWindow.UITrendWizardButton;
            #endregion

            // Click 'Trend Wizard' button
            Mouse.Click(uITrendWizardButton, new Point(16, 11));
        }

        /// <summary>
        /// ClickFinishButton
        /// </summary>
        public void ClickFinishButton()
        {
            #region Variable Declarations
            WinButton uIFinishButton = this.UITrendWizardWindow.UIFinishWindow.UIFinishButton;
            #endregion

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(43, 13));
        }

        /// <summary>
        /// SelectShowLegendCheckBox - Use 'SelectShowLegendCheckBoxParams' to pass parameters into this method.
        /// </summary>
        public void SelectShowLegendCheckBox()
        {
            #region Variable Declarations
            WinCheckBox uIShowLegendCheckBox = this.UISmartViewProductionQWindow.UITrendViewerWindow.UIToolbarWindow.UIShowLegendCheckBox;
            #endregion

            // Clear 'Show Legend' check box
            uIShowLegendCheckBox.Checked = true;
        }

        public virtual SelectShowLegendCheckBoxParams SelectShowLegendCheckBoxParams
        {
            get
            {
                if ((this.mSelectShowLegendCheckBoxParams == null))
                {
                    this.mSelectShowLegendCheckBoxParams = new SelectShowLegendCheckBoxParams();
                }
                return this.mSelectShowLegendCheckBoxParams;
            }
        }

        private SelectShowLegendCheckBoxParams mSelectShowLegendCheckBoxParams;

        /// <summary>
        /// DefineQuery - Use 'DefineQueryParams' to pass parameters into this method.
        /// </summary>
        public void DefineQuery(String inspection)
        {
            #region Variable Declarations
            WinTitleBar uITrendViewerTitleBar = this.UISmartViewProductionQWindow.UITrendViewerWindow.UITrendViewerTitleBar;
            WinMenuItem uIItemMenuItem = this.UIItemWindow.UIContextMenu.UIItemMenuItem;
            WinButton uINextButton = this.UITrendWizardWindow.UINextWindow.UINextButton;
            WinCheckBox uIRecipeCheckBox = this.UITrendWizardWindow.UIRecipeClient.UIRecipeCheckBox;
            WinList uIListRecipeList = this.UITrendWizardWindow.UIListRecipeWindow.UIListRecipeList;
            WinCheckBox uIInspectionCheckBox = this.UITrendWizardWindow.UIInspectionClient.UIInspectionCheckBox;
            WinEdit uITextNameEdit = this.UITrendWizardWindow.UITextNameWindow.UITextNameEdit;
            WinButton uIFinishButton = this.UITrendWizardWindow.UIFinishWindow.UIFinishButton;
            #endregion

            // Click 'Trend Viewer' title bar
            Mouse.Click(uITrendViewerTitleBar, new Point(462, 8));

            // Click menu item numbered 3 in 'Context' menu item
            Mouse.Click(uIItemMenuItem, new Point(32, 8));

            // Click 'Next' button
            Mouse.Click(uINextButton, new Point(25, 5));

            // Select 'Recipe' check box
           // uIRecipeCheckBox.Checked = this.DefineQueryParams.UIRecipeCheckBoxChecked;

            // Select '' in 'listRecipe' list box
            //uIListRecipeList.SelectedItemsAsString = this.DefineQueryParams.UIListRecipeListSelectedItemsAsString;

            // Select 'Inspection' check box
            uIInspectionCheckBox.Checked = this.DefineQueryParams.UIInspectionCheckBoxChecked;

            // Type 'DB*' in 'textName' text box
            //trend-viewer-load-test-6
            uITextNameEdit.Text = inspection;

            // Click 'Next' button
            Mouse.Click(uINextButton, new Point(40, 6));

            // Click 'Next' button
            Mouse.Click(uINextButton, new Point(40, 6));

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(14, 9));
        }

        public virtual DefineQueryParams DefineQueryParams
        {
            get
            {
                if ((this.mDefineQueryParams == null))
                {
                    this.mDefineQueryParams = new DefineQueryParams();
                }
                return this.mDefineQueryParams;
            }
        }

        private DefineQueryParams mDefineQueryParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DisplayBarPlotInTrendViewer'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplayBarPlotInTrendViewerParams
    {

        #region Fields
        /// <summary>
        /// Select 'Bar plot' radio button
        /// </summary>
        public bool UIBarplotRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectShowLegendCheckBox'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectShowLegendCheckBoxParams
    {

        #region Fields
        /// <summary>
        /// Clear 'Show Legend' check box
        /// </summary>
        public bool UIShowLegendCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQuery'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryParams
    {

        #region Fields
        /// <summary>
        /// Select 'Recipe' check box
        /// </summary>
        public bool UIRecipeCheckBoxChecked = true;

        /// <summary>
        /// Select '' in 'listRecipe' list box
        /// </summary>
        public string UIListRecipeListSelectedItemsAsString = "test";

        /// <summary>
        /// Select 'Inspection' check box
        /// </summary>
        public bool UIInspectionCheckBoxChecked = true;

        /// <summary>
        /// Type 'DB*' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "DB*";
        #endregion
}
}
