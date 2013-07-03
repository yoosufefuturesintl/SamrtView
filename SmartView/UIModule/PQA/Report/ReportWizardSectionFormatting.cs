namespace SmartView.UIModule.PQA.Report.ReportWizardSectionFormattingClasses
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
    public partial class ReportWizardSectionFormatting
    {

        /// <summary>
        /// DefineColumnHeaderRotation - Use 'DefineColumnHeaderRotationParams' to pass parameters into this method.
        /// </summary>
        public void DefineColumnHeaderRotation(String orientation)
        {
            #region Variable Declarations
            WinComboBox uIColumnheaderrotationComboBox = this.UILaneSummaryWindow.UIComboOrientationWindow.UIColumnheaderrotationComboBox;
            #endregion

            // Select 'Vertical' in 'Column header rotation:' combo box
            uIColumnheaderrotationComboBox.SelectedItem = orientation;
        }

        public virtual DefineColumnHeaderRotationParams DefineColumnHeaderRotationParams
        {
            get
            {
                if ((this.mDefineColumnHeaderRotationParams == null))
                {
                    this.mDefineColumnHeaderRotationParams = new DefineColumnHeaderRotationParams();
                }
                return this.mDefineColumnHeaderRotationParams;
            }
        }

        private DefineColumnHeaderRotationParams mDefineColumnHeaderRotationParams;

        /// <summary>
        /// DisplayTotals - Use 'DisplayTotalsParams' to pass parameters into this method.
        /// </summary>
        public void DisplayTotals(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIDisplaytotalsCheckBox = this.UILaneSummaryWindow.UIDisplaytotalsWindow.UIDisplaytotalsCheckBox;
            #endregion

            // Select 'Display totals' check box
            uIDisplaytotalsCheckBox.Checked = isEnabled;
        }

        public virtual DisplayTotalsParams DisplayTotalsParams
        {
            get
            {
                if ((this.mDisplayTotalsParams == null))
                {
                    this.mDisplayTotalsParams = new DisplayTotalsParams();
                }
                return this.mDisplayTotalsParams;
            }
        }

        private DisplayTotalsParams mDisplayTotalsParams;

        /// <summary>
        /// FlipRowsAndColumns - Use 'FlipRowsAndColumnsParams' to pass parameters into this method.
        /// </summary>
        public void FlipRowsAndColumns(bool isFlipped)
        {
            #region Variable Declarations
            WinCheckBox uIFliprowsandcolumnsCheckBox = this.UILaneSummaryWindow.UIFliprowsandcolumnsWindow.UIFliprowsandcolumnsCheckBox;
            #endregion

            // Select 'Flip rows and columns' check box
            uIFliprowsandcolumnsCheckBox.Checked = isFlipped;
        }

        public virtual FlipRowsAndColumnsParams FlipRowsAndColumnsParams
        {
            get
            {
                if ((this.mFlipRowsAndColumnsParams == null))
                {
                    this.mFlipRowsAndColumnsParams = new FlipRowsAndColumnsParams();
                }
                return this.mFlipRowsAndColumnsParams;
            }
        }

        private FlipRowsAndColumnsParams mFlipRowsAndColumnsParams;

        /// <summary>
        /// HighlightRows - Use 'HighlightRowsParams' to pass parameters into this method.
        /// </summary>
        public void HighlightRows(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIHighlightrowsCheckBox = this.UILaneSummaryWindow.UIHighlightrowsWindow.UIHighlightrowsCheckBox;
            #endregion

            // Select 'Highlight rows' check box
            uIHighlightrowsCheckBox.Checked = isEnabled;
        }

        public virtual HighlightRowsParams HighlightRowsParams
        {
            get
            {
                if ((this.mHighlightRowsParams == null))
                {
                    this.mHighlightRowsParams = new HighlightRowsParams();
                }
                return this.mHighlightRowsParams;
            }
        }

        private HighlightRowsParams mHighlightRowsParams;

        /// <summary>
        /// LoadaReportWizard
        /// </summary>
        public void LoadReportWizard()
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(8, 12));
        }

        /// <summary>
        /// LoadSectionFormattingTab
        /// </summary>
        public void LoadSectionFormattingTab()
        {
            #region Variable Declarations
            WinTabPage uISectionFormattingTabPage = this.UILaneSummaryWindow.UITabWindow.UISectionFormattingTabPage;
            #endregion

            // Click 'Section Formatting' tab
            Mouse.Click(uISectionFormattingTabPage, new Point(41, 9));
        }

        /// <summary>
        /// SelectSectionToFormat - Use 'SelectSectionToFormatParams' to pass parameters into this method.
        /// </summary>
        public void SelectSectionToFormat()
        {
            #region Variable Declarations
            WinComboBox uIComboPageComboBox = this.UILaneSummaryWindow.UIComboPageWindow.UIComboPageComboBox;
            #endregion

            // Select 'Table' in 'comboPage' combo box
            uIComboPageComboBox.SelectedItem = this.SelectSectionToFormatParams.UIComboPageComboBoxSelectedItem;
        }

        public virtual SelectSectionToFormatParams SelectSectionToFormatParams
        {
            get
            {
                if ((this.mSelectSectionToFormatParams == null))
                {
                    this.mSelectSectionToFormatParams = new SelectSectionToFormatParams();
                }
                return this.mSelectSectionToFormatParams;
            }
        }

        private SelectSectionToFormatParams mSelectSectionToFormatParams;

        /// <summary>
        /// ShowZeroValues - Use 'ShowZeroValuesParams' to pass parameters into this method.
        /// </summary>
        public void ShowZeroValues()
        {
            #region Variable Declarations
            WinCheckBox uIShowzerovaluesCheckBox = this.UILaneSummaryWindow.UIShowzerovaluesWindow.UIShowzerovaluesCheckBox;
            #endregion

            // Select 'Show zero values' check box
            uIShowzerovaluesCheckBox.Checked = this.ShowZeroValuesParams.UIShowzerovaluesCheckBoxChecked;
        }

        public virtual ShowZeroValuesParams ShowZeroValuesParams
        {
            get
            {
                if ((this.mShowZeroValuesParams == null))
                {
                    this.mShowZeroValuesParams = new ShowZeroValuesParams();
                }
                return this.mShowZeroValuesParams;
            }
        }

        private ShowZeroValuesParams mShowZeroValuesParams;

        /// <summary>
        /// SelectionSubSection - Use 'SelectionSubSectionParams' to pass parameters into this method.
        /// </summary>
        public void SelectionSubSection()
        {
            #region Variable Declarations
            WinComboBox uIComboPageComboBox = this.UILaneSummaryWindow.UIComboPageWindow.UIComboPageComboBox;
            #endregion

            // Select 'Table' in 'comboPage' combo box
            uIComboPageComboBox.SelectedItem = this.SelectionSubSectionParams.UIComboPageComboBoxSelectedItem;
        }

        public virtual SelectionSubSectionParams SelectionSubSectionParams
        {
            get
            {
                if ((this.mSelectionSubSectionParams == null))
                {
                    this.mSelectionSubSectionParams = new SelectionSubSectionParams();
                }
                return this.mSelectionSubSectionParams;
            }
        }

        private SelectionSubSectionParams mSelectionSubSectionParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DefineColumnHeaderRotation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineColumnHeaderRotationParams
    {

        #region Fields
        /// <summary>
        /// Select 'Vertical' in 'Column header rotation:' combo box
        /// </summary>
        public string UIColumnheaderrotationComboBoxSelectedItem = "Vertical";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DisplayTotals'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplayTotalsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Display totals' check box
        /// </summary>
        public bool UIDisplaytotalsCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'FlipRowsAndColumns'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class FlipRowsAndColumnsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Flip rows and columns' check box
        /// </summary>
        public bool UIFliprowsandcolumnsCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'HighlightRows'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class HighlightRowsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Highlight rows' check box
        /// </summary>
        public bool UIHighlightrowsCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectSectionToFormat'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectSectionToFormatParams
    {

        #region Fields
        /// <summary>
        /// Select 'Table' in 'comboPage' combo box
        /// </summary>
        public string UIComboPageComboBoxSelectedItem = "Table";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowZeroValues'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowZeroValuesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show zero values' check box
        /// </summary>
        public bool UIShowzerovaluesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectionSubSection'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectionSubSectionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Table' in 'comboPage' combo box
        /// </summary>
        public string UIComboPageComboBoxSelectedItem = "Table";
        #endregion
}
}
