namespace SVConsole.UIModule.Console.SheetQualityViewer.SheetQualityViewerClasses
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
    public partial class SheetQualityViewer
    {

        /// <summary>
        /// ClickStartStopSnapshotTimer
        /// </summary>
        public void ClickStartStopSnapshotTimer()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UISheetQualityViewerWindow.UISheetQualityViewerClient.UIItemWindow;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(191, 17));
}

        /// <summary>
        /// LoadSheetQualityViewer
        /// </summary>
        public void LoadSheetQualityViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            #endregion

            // Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(30, 452));
}

        /// <summary>
        /// CloseSheetQualityViewer
        /// </summary>
        public void CloseSheetQualityViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole2CamWindow.UISheetQualityViewerViWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(20, 9));
}
}
}
