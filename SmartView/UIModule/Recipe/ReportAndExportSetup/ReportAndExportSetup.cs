namespace SmartViewPQA.UIModule.Recipe.ReportAndExportSetup.ReportAndExportSetupClasses
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
    public partial class ReportAndExportSetup
    {

        /// <summary>
        /// LoadReportAndExportWindow
        /// </summary>
        public void LoadReportAndExportWindow()
        {
            #region Variable Declarations
            WinMenuBar uIApplicationMenuBar = this.UISmartViewRecipeManagWindow.UIApplicationMenuBar;
            #endregion

            // Click 'Application' menu bar
            Mouse.Click(uIApplicationMenuBar, new Point(357, 51));
}
}
}
