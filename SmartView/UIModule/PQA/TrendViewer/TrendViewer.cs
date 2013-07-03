namespace SmartView.UIModule.PQA.TrendViewer.TrendViewerClasses
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
    public partial class TrendViewer
    {

        /// <summary>
        /// GenerateTrendViewer
        /// </summary>
        public void GenerateTrendViewer()
        {
            #region Variable Declarations
            WinButton uITrendViewerButton = this.UISmartViewProductionQWindow.UIToolbarMainWindow.UITrendViewerButton;
            #endregion

            // Click 'Trend Viewer' button
            Mouse.Click(uITrendViewerButton, new Point(13, 23));
        }

        /// <summary>
        /// ChangeToSharedSelection
        /// </summary>
        public void ChangeToSharedSelection()
        {
            #region Variable Declarations
            WinTitleBar uITrendViewerTitleBar = this.UISmartViewProductionQWindow.UITrendViewerWindow.UITrendViewerTitleBar;
            WinMenuItem uIItemMenuItem = this.UIItemWindow.UIContextMenu.UIItemMenuItem;
            WinButton uIItemButton = this.UISmartViewProductionQWindow.UITrendViewerWindow.UIToolbarWindow.UIItemButton;
            #endregion

            // Click 'Trend Viewer' title bar
            Mouse.Click(uITrendViewerTitleBar, new Point(466, 11));

            // Click 'Unknown Name' menu item
            Mouse.Click(uIItemMenuItem, new Point(30, 8));

            // Click button numbered 4 in 'toolbar' window
            Mouse.Click(uIItemButton, new Point(15, 13));
        }
        public void ClickRunButtonInTrendViewerToolBar()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UISmartViewProductionQWindow.UITrendViewerWindow.UIToolbarWindow.UIItemButton;
            #endregion

            // Click button numbered 4 in 'toolbar' window
            Mouse.Click(uIItemButton, new Point(15, 13));
        }

        /// <summary>
        /// VerifyLegendIsShownInTrendViewer - Use 'VerifyLegendIsShownInTrendViewerExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyLegendIsShownInTrendViewer(bool isLegendShown)
        {
            #region Variable Declarations
            WinList uIListboxList = this.UISmartViewProductionQWindow.UITrendViewerWindow.UIListboxWindow.UIListboxList;
            #endregion

            // Verify that 'listbox' list box's property 'Exists' equals 'True'
            Assert.AreEqual(isLegendShown, uIListboxList.Exists);
        }

        public virtual VerifyLegendIsShownInTrendViewerExpectedValues VerifyLegendIsShownInTrendViewerExpectedValues
        {
            get
            {
                if ((this.mVerifyLegendIsShownInTrendViewerExpectedValues == null))
                {
                    this.mVerifyLegendIsShownInTrendViewerExpectedValues = new VerifyLegendIsShownInTrendViewerExpectedValues();
                }
                return this.mVerifyLegendIsShownInTrendViewerExpectedValues;
            }
        }

        private VerifyLegendIsShownInTrendViewerExpectedValues mVerifyLegendIsShownInTrendViewerExpectedValues;

        /// <summary>
        /// CloseTrendViewer
        /// </summary>
        public void CloseTrendViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewProductionQWindow.UITrendViewerWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(16, 9));
}
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyLegendIsShownInTrendViewer'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyLegendIsShownInTrendViewerExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'listbox' list box's property 'Exists' equals 'True'
        /// </summary>
        public bool UIListboxListExists = true;
        #endregion
}
}
