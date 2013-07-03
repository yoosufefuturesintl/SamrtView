namespace SVPQA.UIModule.PQA.Report.ReportWizardReportOptionsClasses
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
    public partial class ReportWizardReportOptions
    {

        /// <summary>
        /// GroupByView - Use 'GroupByViewParams' to pass parameters into this method.
        /// </summary>
        public void GroupByView(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIGroupbyviewCheckBox = this.UILaneSummaryWindow.UIGroupbyviewWindow.UIGroupbyviewCheckBox;
            #endregion

            // Select 'Group by view' check box
            uIGroupbyviewCheckBox.Checked = isEnabled;
        }

        public virtual GroupByViewParams GroupByViewParams
        {
            get
            {
                if ((this.mGroupByViewParams == null))
                {
                    this.mGroupByViewParams = new GroupByViewParams();
                }
                return this.mGroupByViewParams;
            }
        }

        private GroupByViewParams mGroupByViewParams;

        /// <summary>
        /// LoadReportOptionsTab
        /// </summary>
        public void LoadReportOptionsTab()
        {
            #region Variable Declarations
            WinTabPage uIReportOptionsTabPage = this.UILaneSummaryWindow.UITabWindow.UIReportOptionsTabPage;
            #endregion

            // Click 'Report Options' tab
            Mouse.Click(uIReportOptionsTabPage, new Point(64, 8));
        }

        /// <summary>
        /// LoadReportWizard
        /// </summary>
        public void LoadReportWizard()
        {
            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            #endregion

            // Click 'Wizard' button
            Mouse.Click(uIWizardButton, new Point(14, 10));
        }

        public void WaitForReportWizardIconIsEnabled()
        {

            #region Variable Declarations
            WinButton uIWizardButton = this.UISmartViewProductionQWindow.UILaneSummaryWindow.UIToolBarPreviewWindow.UIWizardButton;
            #endregion
            uIWizardButton.WaitForControlEnabled();
        }



        /// <summary>
        /// LoadSectionFormatting
        /// </summary>
        public void LoadSectionFormatting()
        {
            #region Variable Declarations
            WinTabPage uISectionFormattingTabPage = this.UILaneSummaryWindow.UITabWindow.UISectionFormattingTabPage;
            #endregion

            // Click 'Section Formatting' tab
            Mouse.Click(uISectionFormattingTabPage, new Point(53, 12));
        }

        /// <summary>
        /// SelectSectionTFormat - Use 'SelectSectionTFormatParams' to pass parameters into this method.
        /// </summary>
        public void SelectSectionTFormat()
        {
            #region Variable Declarations
            WinComboBox uIComboPageComboBox = this.UILaneSummaryWindow.UIComboPageWindow.UIComboPageComboBox;
            #endregion

            // Select 'Table' in 'comboPage' combo box
            uIComboPageComboBox.SelectedItem = this.SelectSectionTFormatParams.UIComboPageComboBoxSelectedItem;
        }

        public virtual SelectSectionTFormatParams SelectSectionTFormatParams
        {
            get
            {
                if ((this.mSelectSectionTFormatParams == null))
                {
                    this.mSelectSectionTFormatParams = new SelectSectionTFormatParams();
                }
                return this.mSelectSectionTFormatParams;
            }
        }

        private SelectSectionTFormatParams mSelectSectionTFormatParams;

        /// <summary>
        /// ShowEmptyLanes - Use 'ShowEmptyLanesParams' to pass parameters into this method.
        /// </summary>
        public void ShowEmptyLanes(bool isShown )
        {
            #region Variable Declarations
            WinCheckBox uIShowemptylanesCheckBox = this.UILaneSummaryWindow.UIShowemptylanesWindow.UIShowemptylanesCheckBox;
            #endregion

            // Select 'Show empty lanes' check box
            uIShowemptylanesCheckBox.Checked = isShown;
        }

        public virtual ShowEmptyLanesParams ShowEmptyLanesParams
        {
            get
            {
                if ((this.mShowEmptyLanesParams == null))
                {
                    this.mShowEmptyLanesParams = new ShowEmptyLanesParams();
                }
                return this.mShowEmptyLanesParams;
            }
        }

        private ShowEmptyLanesParams mShowEmptyLanesParams;

        /// <summary>
        /// ShowGraph - Use 'ShowGraphParams' to pass parameters into this method.
        /// </summary>
        public void ShowGraph(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowgraphCheckBox = this.UILaneSummaryWindow.UIShowgraphWindow.UIShowgraphCheckBox;
            #endregion

            // Select 'Show graph' check box
            uIShowgraphCheckBox.Checked = isShown;
        }

        public virtual ShowGraphParams ShowGraphParams
        {
            get
            {
                if ((this.mShowGraphParams == null))
                {
                    this.mShowGraphParams = new ShowGraphParams();
                }
                return this.mShowGraphParams;
            }
        }

        private ShowGraphParams mShowGraphParams;

        /// <summary>
        /// ShowOutOfRangeLanes - Use 'ShowOutOfRangeLanesParams' to pass parameters into this method.
        /// </summary>
        public void ShowOutOfRangeLanes(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowoutofrangelanesCheckBox = this.UILaneSummaryWindow.UIShowoutofrangelanesWindow.UIShowoutofrangelanesCheckBox;
            #endregion

            // Select 'Show out-of-range lanes' check box
            uIShowoutofrangelanesCheckBox.Checked = isShown;
        }

        public virtual ShowOutOfRangeLanesParams ShowOutOfRangeLanesParams
        {
            get
            {
                if ((this.mShowOutOfRangeLanesParams == null))
                {
                    this.mShowOutOfRangeLanesParams = new ShowOutOfRangeLanesParams();
                }
                return this.mShowOutOfRangeLanesParams;
            }
        }

        private ShowOutOfRangeLanesParams mShowOutOfRangeLanesParams;

        /// <summary>
        /// ShowTable - Use 'ShowTableParams' to pass parameters into this method.
        /// </summary>
        public void ShowTable(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowtableCheckBox = this.UILaneSummaryWindow.UIShowtableWindow.UIShowtableCheckBox;
            #endregion

            // Clear 'Show table' check box
            uIShowtableCheckBox.Checked = isShown;

        }

        public virtual ShowTableParams ShowTableParams
        {
            get
            {
                if ((this.mShowTableParams == null))
                {
                    this.mShowTableParams = new ShowTableParams();
                }
                return this.mShowTableParams;
            }
        }

        private ShowTableParams mShowTableParams;

        /// <summary>
        /// ApplyWizardChanges
        /// </summary>
        public void ApplyWizardChanges()
        {
            #region Variable Declarations
            WinButton uIFinishButton = this.UILaneSummaryWindow.UIFinishWindow.UIFinishButton;
            #endregion

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(44, 11));
}
    }
    /// <summary>
    /// Parameters to be passed into 'GroupByView'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GroupByViewParams
    {

        #region Fields
        /// <summary>
        /// Select 'Group by view' check box
        /// </summary>
        public bool UIGroupbyviewCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectSectionTFormat'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectSectionTFormatParams
    {

        #region Fields
        /// <summary>
        /// Select 'Table' in 'comboPage' combo box
        /// </summary>
        public string UIComboPageComboBoxSelectedItem = "Table";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowEmptyLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowEmptyLanesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show empty lanes' check box
        /// </summary>
        public bool UIShowemptylanesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowGraph'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowGraphParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show graph' check box
        /// </summary>
        public bool UIShowgraphCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowOutOfRangeLanes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowOutOfRangeLanesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show out-of-range lanes' check box
        /// </summary>
        public bool UIShowoutofrangelanesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowTable'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowTableParams
    {

        #region Fields
        /// <summary>
        /// Clear 'Show table' check box
        /// </summary>
        public bool UIShowtableCheckBoxChecked = false;

        /// <summary>
        /// Select 'Show table' check box
        /// </summary>
        public bool UIShowtableCheckBoxChecked1 = true;
        #endregion
}
}
