namespace SmartView.UIModule.ClassifierMgr.ClassListClasses
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
    public partial class ClassList
    {

        /// <summary>
        /// ImportClassifier - Use 'ImportClassifierParams' to pass parameters into this method.
        /// </summary>
        public void ImportClassifier()
        {
            #region Variable Declarations
            WinButton uIBtnImportClassesButton = this.UISmartLearnClassifierWindow.UIBtnImportClassesWindow.UIBtnImportClassesButton;
            WinEdit uITextNameEdit = this.UIImportClassesWindow.UITextNameWindow.UITextNameEdit;
            WinButton uIOpenButton = this.UIImportClassesWindow.UIOpenWindow.UIOpenButton;
            WinButton uIOKButton = this.UIImportClassesWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.UIImportClassWindow.UIYesWindow.UIYesButton;
            #endregion

            // Click 'btnImportClasses' button
            Mouse.Click(uIBtnImportClassesButton, new Point(10, 7));

            // Type 'Basic' in 'textName' text box
            uITextNameEdit.Text = this.ImportClassifierParams.UITextNameEditText;

            // Click 'Open' button
            Mouse.Click(uIOpenButton, new Point(23, 5));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(17, 7));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(17, 7));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(17, 7));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(17, 7));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(17, 7));
        }

        public virtual ImportClassifierParams ImportClassifierParams
        {
            get
            {
                if ((this.mImportClassifierParams == null))
                {
                    this.mImportClassifierParams = new ImportClassifierParams();
                }
                return this.mImportClassifierParams;
            }
        }

        private ImportClassifierParams mImportClassifierParams;

        /// <summary>
        /// LoadClassListTab
        /// </summary>
        public void LoadClassListTab()
        {
            #region Variable Declarations
            WinTabPage uIClassListTabPage = this.UISmartLearnClassifierWindow.UITabsWindow.UIClassListTabPage;
            #endregion

            // Click 'Class List' tab
            Mouse.Click(uIClassListTabPage, new Point(75, 15));
}
    }
    /// <summary>
    /// Parameters to be passed into 'ImportClassifier'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportClassifierParams
    {

        #region Fields
        /// <summary>
        /// Type 'Basic' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "Basic";
        #endregion
}
}
