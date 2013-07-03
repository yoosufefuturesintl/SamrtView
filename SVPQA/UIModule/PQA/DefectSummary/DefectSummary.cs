namespace SVPQA.UIModule.PQA.DefectSummary.DefectSummaryClasses
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
    public partial class DefectSummary
    {

        /// <summary>
        /// ClickLoadNextInspectionButton
        /// </summary>
        public void ClickLoadNextInspectionButton()
        {
            #region Variable Declarations
            WinButton uINextButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UINextButton;
            #endregion

            // Click 'Next' button
            Mouse.Click(uINextButton, new Point(16, 21));
        }

        /// <summary>
        /// LoadDefectSummary
        /// </summary>
        public void LoadDefectSummary()
        {
            #region Variable Declarations
            WinButton uIDefectSummaryButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UIDefectSummaryButton;
            #endregion

            // Click 'Defect Summary' button
            Mouse.Click(uIDefectSummaryButton, new Point(21, 31));
        }

        /// <summary>
        /// SelectIndividualInspectionForDefectSummary
        /// </summary>
        public void SelectIndividualInspectionForDefectSummary()
        {
            #region Variable Declarations
            WinTitleBar uITest11TitleBar = this.UISmartViewProductionQWindow.UITest11Window.UITest11TitleBar;
            WinMenuItem uIItemMenuItem = this.UIItemWindow.UIContextMenu.UIItemMenuItem;
            WinListItem uITest13ListItem = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UITest13ListItem;
            #endregion

            // Click 'test-11' title bar
            Mouse.Click(uITest11TitleBar, new Point(211, 6));

            // Click menu item numbered 2 in 'Context' menu item
           // Mouse.Click(uIItemMenuItem, new Point(27, 9));

            // Double-Click 'test-13' list item
            //Mouse.DoubleClick(uITest13ListItem, new Point(39, 10));
        }

        /// <summary>
        /// VerifyDefectSummaryIsLoadedSuccessfully - Use 'VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyDefectSummaryIsLoadedSuccessfully()
        {
            #region Variable Declarations
            WinClient uIClassSummaryClient = this.UISmartViewProductionQWindow.UITest11Window.UIItemWindow.UIClassSummaryClient;
            #endregion

            // Verify that 'classSummary' client's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues.UIClassSummaryClientExists, uIClassSummaryClient.Exists);
        }

        public virtual VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues
        {
            get
            {
                if ((this.mVerifyDefectSummaryIsLoadedSuccessfullyExpectedValues == null))
                {
                    this.mVerifyDefectSummaryIsLoadedSuccessfullyExpectedValues = new VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues();
                }
                return this.mVerifyDefectSummaryIsLoadedSuccessfullyExpectedValues;
            }
        }

        private VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues mVerifyDefectSummaryIsLoadedSuccessfullyExpectedValues;

        /// <summary>
        /// VerifyDisplayedInspectionNameInDefectSummary - Use 'VerifyDisplayedInspectionNameInDefectSummaryExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyDisplayedInspectionNameInDefectSummary(String inspectionName)
        {
            #region Variable Declarations
            WinTitleBar uITest11TitleBar = this.UISmartViewProductionQWindow.UITest11Window.UITest11TitleBar;
            #endregion

            // Verify that 'test-11' title bar's property 'DisplayText' equals 'test-13'
            Assert.AreEqual(inspectionName, uITest11TitleBar.DisplayText);
        }

        public String GetDisplayedInspectionNameInDefectSummary()
        {
            #region Variable Declarations
            WinTitleBar uITest11TitleBar = this.UISmartViewProductionQWindow.UITest11Window.UITest11TitleBar;
            #endregion

            // Verify that 'test-11' title bar's property 'DisplayText' equals 'test-13'
            return uITest11TitleBar.DisplayText;
        }

        public virtual VerifyDisplayedInspectionNameInDefectSummaryExpectedValues VerifyDisplayedInspectionNameInDefectSummaryExpectedValues
        {
            get
            {
                if ((this.mVerifyDisplayedInspectionNameInDefectSummaryExpectedValues == null))
                {
                    this.mVerifyDisplayedInspectionNameInDefectSummaryExpectedValues = new VerifyDisplayedInspectionNameInDefectSummaryExpectedValues();
                }
                return this.mVerifyDisplayedInspectionNameInDefectSummaryExpectedValues;
            }
        }

        private VerifyDisplayedInspectionNameInDefectSummaryExpectedValues mVerifyDisplayedInspectionNameInDefectSummaryExpectedValues;

        /// <summary>
        /// CloseDefectSummary
        /// </summary>
        public void CloseDefectSummary()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UITest11Window.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(16, 9));
}
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyDefectSummaryIsLoadedSuccessfully'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyDefectSummaryIsLoadedSuccessfullyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'classSummary' client's property 'Exists' equals 'True'
        /// </summary>
        public bool UIClassSummaryClientExists = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyDisplayedInspectionNameInDefectSummary'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyDisplayedInspectionNameInDefectSummaryExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'test-11' title bar's property 'DisplayText' equals 'test-13'
        /// </summary>
        public string UITest11TitleBarDisplayText = "test-13";
        #endregion
}
}
