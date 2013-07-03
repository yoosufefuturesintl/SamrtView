namespace SmartView.UIModule.PQA.TrendViewer.TrendWizardClasses
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
}
