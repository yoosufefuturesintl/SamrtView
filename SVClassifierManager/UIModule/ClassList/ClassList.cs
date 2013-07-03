namespace SVClassifierManager.UIModule.ClassList.ClassListClasses
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
    using System.IO;


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

        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1(String classifier)
        {
            #region Variable Declarations
            WinClient uIPanelClient = this.UISmartLearnClassifierWindow1.UIPanelWindow.UIPanelClient;
            #endregion

            uIPanelClient.WindowTitles.Add("SmartLearn Classifier Manager - [" + classifier + "]");
            // Click 'panel' client
            Mouse.Click(uIPanelClient, new Point(432, 81));

            // Double-Click 'panel' client
            Mouse.DoubleClick(uIPanelClient, new Point(215, 102));

            // Click 'panel' client
            Mouse.Click(uIPanelClient, new Point(643, 248));

            UITestControlCollection collection = uIPanelClient.GetChildren();
            TextWriter TW = new StreamWriter("D:\\QA\\Cla.txt");
            TW.WriteLine(collection.Count);
            TW.Close();
            //for (int i = 0; i < collection.Count; i++)
            //{
            //}
        }

        /// <summary>
        /// ClassDataBaseImport - Use 'ClassDataBaseImportParams' to pass parameters into this method.
        /// </summary>
        public void ClassDataBaseImportDoNotImport()
        {
            #region Variable Declarations
            WinRadioButton uIDonotimportRadioButton = this.UISmartLearnClassifierWindow1.UIDonotimportWindow.UIDonotimportRadioButton;
            #endregion

            // Select 'Do not import' radio button
            uIDonotimportRadioButton.Selected = this.ClassDataBaseImportParams.UIDonotimportRadioButtonSelected;

        }

        public void VerifyClassDataBaseImportDoNotImport(bool IsEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIDonotimportRadioButton = this.UISmartLearnClassifierWindow1.UIDonotimportWindow.UIDonotimportRadioButton;
            #endregion

            Assert.AreEqual(IsEnabled, uIDonotimportRadioButton.Selected);
        }

        public void ClassDataBaseImportDefectOnly()
        {
            #region Variable Declarations
            WinRadioButton uIDefectonlyRadioButton = this.UISmartLearnClassifierWindow1.UIDefectonlyWindow1.UIDefectonlyRadioButton;
            #endregion

            // Select 'Defect only' radio button
            uIDefectonlyRadioButton.Selected = this.ClassDataBaseImportParams.UIDefectonlyRadioButtonSelected;
        }

        public void VerifyClassDataBaseImportDefectOnly(bool isEnabled)
        {
            #region Variable Declarations
            WinRadioButton uIDefectonlyRadioButton = this.UISmartLearnClassifierWindow1.UIDefectonlyWindow1.UIDefectonlyRadioButton;
            #endregion

            Assert.AreEqual(isEnabled, uIDefectonlyRadioButton.Selected);

        }

        public void ClassDBImportDefectAndGray()
        {
            WinRadioButton uIDefectandgrayRadioButton1 = this.UISmartLearnClassifierWindow1.UIDefectandgrayWindow1.UIDefectandgrayRadioButton;

            // Select 'Defect and gray' radio button
            uIDefectandgrayRadioButton1.Selected = this.ClassDataBaseImportParams.UIDefectandgrayRadioButtonSelected1;
        }

        public void VerifyDefectAndGrayClassDBImport(bool isEnabled)
        {
            WinRadioButton uIDefectandgrayRadioButton1 = this.UISmartLearnClassifierWindow1.UIDefectandgrayWindow1.UIDefectandgrayRadioButton;

            Assert.AreEqual(isEnabled, uIDefectandgrayRadioButton1.Selected);
        }

        public virtual ClassDataBaseImportParams ClassDataBaseImportParams
        {
            get
            {
                if ((this.mClassDataBaseImportParams == null))
                {
                    this.mClassDataBaseImportParams = new ClassDataBaseImportParams();
                }
                return this.mClassDataBaseImportParams;
            }
        }

        private ClassDataBaseImportParams mClassDataBaseImportParams;

        /// <summary>
        /// ClassNotification - Use 'ClassNotificationParams' to pass parameters into this method.
        /// </summary>
        public void ClassNotification()
        {
            #region Variable Declarations
            WinEdit uITxtNotificationSeverEdit = this.UISmartLearnClassifierWindow1.UITxtNotificationSeverWindow.UITxtNotificationSeverEdit;
            WinEdit uITxtNotificationDefecEdit = this.UISmartLearnClassifierWindow1.UITxtNotificationDefecWindow.UITxtNotificationDefecEdit;
            WinEdit uITxtNotificationDensiEdit = this.UISmartLearnClassifierWindow1.UITxtNotificationDensiWindow.UITxtNotificationDensiEdit;
            WinEdit uITxtNotificationCumulEdit = this.UISmartLearnClassifierWindow1.UITxtNotificationCumulWindow.UITxtNotificationCumulEdit;
            WinCheckBox uINotifyateachreportinCheckBox = this.UISmartLearnClassifierWindow1.UINotifyateachreportinWindow.UINotifyateachreportinCheckBox;
            #endregion

            // Type '15' in 'txtNotificationSeverity' text box
            uITxtNotificationSeverEdit.Text = this.ClassNotificationParams.UITxtNotificationSeverEditText;

            // Type '5555' in 'txtNotificationDefectRate' text box
            uITxtNotificationDefecEdit.Text = this.ClassNotificationParams.UITxtNotificationDefecEditText;

            // Type '65' in 'txtNotificationDensity' text box
            uITxtNotificationDensiEdit.Text = this.ClassNotificationParams.UITxtNotificationDensiEditText;

            // Type '8888' in 'txtNotificationCumulative' text box
            uITxtNotificationCumulEdit.Text = this.ClassNotificationParams.UITxtNotificationCumulEditText;

            // Select 'Notify at each reporting distance' check box
            uINotifyateachreportinCheckBox.Checked = this.ClassNotificationParams.UINotifyateachreportinCheckBoxChecked;
        }

        public virtual ClassNotificationParams ClassNotificationParams
        {
            get
            {
                if ((this.mClassNotificationParams == null))
                {
                    this.mClassNotificationParams = new ClassNotificationParams();
                }
                return this.mClassNotificationParams;
            }
        }

        private ClassNotificationParams mClassNotificationParams;

        /// <summary>
        /// ClassSaveAction - Use 'ClassSaveActionParams' to pass parameters into this method.
        /// </summary>
        public void ClassSaveActionDefectOnly()
        {
            #region Variable Declarations

            WinRadioButton uIDefectonlyRadioButton = this.UISmartLearnClassifierWindow1.UIDefectonlyWindow.UIDefectonlyRadioButton;
            #endregion

            // Select 'Defect only' radio button
            uIDefectonlyRadioButton.Selected = this.ClassSaveActionParams.UIDefectonlyRadioButtonSelected;

        }

        public void VerifyDefectOnlyClassSaveAction(bool isEnabled)
        {
            #region Variable Declarations

            WinRadioButton uIDefectonlyRadioButton = this.UISmartLearnClassifierWindow1.UIDefectonlyWindow.UIDefectonlyRadioButton;
            #endregion

            Assert.AreEqual(isEnabled, uIDefectonlyRadioButton.Selected);

        }


        public void ClassSaveActionIsDefectAndGray(bool isEnabled, String context, bool useDefectBounding)
        {

            WinRadioButton uIDefectandgrayRadioButton = this.UISmartLearnClassifierWindow1.UIDefectandgrayWindow.UIDefectandgrayRadioButton;
            WinComboBox uIListSaveGrayComboBox = this.UISmartLearnClassifierWindow1.UIListSaveGrayWindow.UIListSaveGrayComboBox;
            WinCheckBox uIUsedefectsboundingboCheckBox = this.UISmartLearnClassifierWindow1.UIUsedefectsboundingboWindow.UIUsedefectsboundingboCheckBox;

            // Select 'Defect and gray' radio button
            uIDefectandgrayRadioButton.Selected = isEnabled;

            // Select 'Full context' in 'listSaveGray' combo box
            uIListSaveGrayComboBox.SelectedItem = context;

            if (context.Equals("Full context"))
            {
                // Select 'Use defect's bounding box' check box
                uIUsedefectsboundingboCheckBox.Checked = useDefectBounding;
            }

        }

        public void VerifyDefectAndGrayClassSaveAction(bool isEnabled, String context, bool useDefectBounding)
        {

            WinRadioButton uIDefectandgrayRadioButton = this.UISmartLearnClassifierWindow1.UIDefectandgrayWindow.UIDefectandgrayRadioButton;
            WinComboBox uIListSaveGrayComboBox = this.UISmartLearnClassifierWindow1.UIListSaveGrayWindow.UIListSaveGrayComboBox;
            WinCheckBox uIUsedefectsboundingboCheckBox = this.UISmartLearnClassifierWindow1.UIUsedefectsboundingboWindow.UIUsedefectsboundingboCheckBox;

            // Select 'Defect and gray' radio button
            Assert.AreEqual(isEnabled, uIDefectandgrayRadioButton.Selected);

            if (isEnabled)
            {
                // Select 'Full context' in 'listSaveGray' combo box
                Assert.AreEqual(context, uIListSaveGrayComboBox.SelectedItem);

                // Select 'Use defect's bounding box' check box
                Assert.AreEqual(useDefectBounding, uIUsedefectsboundingboCheckBox.Checked);
            }
        }

        public void ClassSaveActionIsFilter()
        {
            WinRadioButton uIFiltercountonlyRadioButton = this.UISmartLearnClassifierWindow1.UIFiltercountonlyWindow.UIFiltercountonlyRadioButton;
            uIFiltercountonlyRadioButton.Selected = this.ClassSaveActionParams.UIFiltercountonlyRadioButtonSelected;
        }

        public void VerifyFilterClassSaveAction(bool isEnabled)
        {
            WinRadioButton uIFiltercountonlyRadioButton = this.UISmartLearnClassifierWindow1.UIFiltercountonlyWindow.UIFiltercountonlyRadioButton;
            Assert.AreEqual(isEnabled, uIFiltercountonlyRadioButton.Selected);
        }



        public void ClassSaveActionIsDiscard()
        {
            WinRadioButton uIDiscarddonotsaveRadioButton = this.UISmartLearnClassifierWindow1.UIDiscarddonotsaveWindow.UIDiscarddonotsaveRadioButton;
            uIDiscarddonotsaveRadioButton.Selected = this.ClassSaveActionParams.UIDiscarddonotsaveRadioButtonSelected;
        }

        public void VerifyDiscardClassSaveAction(bool isEnabled)
        {
            WinRadioButton uIDiscarddonotsaveRadioButton = this.UISmartLearnClassifierWindow1.UIDiscarddonotsaveWindow.UIDiscarddonotsaveRadioButton;
            Assert.AreEqual(isEnabled, uIDiscarddonotsaveRadioButton.Selected);
        }

        public virtual ClassSaveActionParams ClassSaveActionParams
        {
            get
            {
                if ((this.mClassSaveActionParams == null))
                {
                    this.mClassSaveActionParams = new ClassSaveActionParams();
                }
                return this.mClassSaveActionParams;
            }
        }

        private ClassSaveActionParams mClassSaveActionParams;

        /// <summary>
        /// ClassSpecialProcessing - Use 'ClassSpecialProcessingParams' to pass parameters into this method.
        /// </summary>
        public void ClassSpecialProcessingBreakOngoingDefect(bool isEnabled, bool isReclassfyEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIBreakongoingdefectCheckBox = this.UISmartLearnClassifierWindow1.UIBreakongoingdefectWindow.UIBreakongoingdefectCheckBox;
            WinCheckBox uIReclassifywithoutongCheckBox = this.UISmartLearnClassifierWindow1.UIReclassifywithoutongWindow.UIReclassifywithoutongCheckBox;
            #endregion

            // Select 'Break ongoing defect' check box
            uIBreakongoingdefectCheckBox.Checked = isEnabled;

            if (isEnabled)
            {
                // Select 'Reclassify without ongoing feature' check box
                uIReclassifywithoutongCheckBox.Checked = isReclassfyEnabled;
            }
        }

        public void VerifyClassSpecialProcessingBreakOngoingDefect(bool isEnabled, bool isReclassfyEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIBreakongoingdefectCheckBox = this.UISmartLearnClassifierWindow1.UIBreakongoingdefectWindow.UIBreakongoingdefectCheckBox;
            WinCheckBox uIReclassifywithoutongCheckBox = this.UISmartLearnClassifierWindow1.UIReclassifywithoutongWindow.UIReclassifywithoutongCheckBox;
            #endregion

            // Select 'Break ongoing defect' check box
            Assert.AreEqual(isEnabled, uIBreakongoingdefectCheckBox.Checked);
            if (isEnabled)
            {
                // Select 'Reclassify without ongoing feature' check box
                Assert.AreEqual(isReclassfyEnabled, uIReclassifywithoutongCheckBox.Checked);

            }
        }

        public void ClassSpecialProcessingPreventCamToCamMerging(bool isEnabled)
        {
            WinCheckBox uIPreventcamtocammergiCheckBox = this.UISmartLearnClassifierWindow1.UIPreventcamtocammergiWindow.UIPreventcamtocammergiCheckBox;

            // Select 'Prevent cam-to-cam merging' check box
            uIPreventcamtocammergiCheckBox.Checked = isEnabled;
        }

        public void VerifyClassSpecialProcessingPreventCamToCamMerging(bool isEnabled)
        {
            WinCheckBox uIPreventcamtocammergiCheckBox = this.UISmartLearnClassifierWindow1.UIPreventcamtocammergiWindow.UIPreventcamtocammergiCheckBox;

            // Select 'Prevent cam-to-cam merging' check box
            Assert.AreEqual(isEnabled, uIPreventcamtocammergiCheckBox.Checked);

        }

        public void ClassSpecialProcessingViewToViewCorrelation(bool isEnabled)
        {
            WinCheckBox uIViewtoviewcorrelatioCheckBox = this.UISmartLearnClassifierWindow1.UIViewtoviewcorrelatioWindow.UIViewtoviewcorrelatioCheckBox;

            // Select 'View-to-view correlation' check box
            uIViewtoviewcorrelatioCheckBox.Checked = isEnabled;
        }

        public void VerifyClassSpecialProcessingViewToViewCorrelation(bool isEnabled)
        {
            WinCheckBox uIViewtoviewcorrelatioCheckBox = this.UISmartLearnClassifierWindow1.UIViewtoviewcorrelatioWindow.UIViewtoviewcorrelatioCheckBox;

            // Select 'View-to-view correlation' check box
            Assert.AreEqual(isEnabled, uIViewtoviewcorrelatioCheckBox.Checked);
        }

        public void ClassSpecialProcessingExtendedConnectivity(bool isEnabled)
        {

            WinCheckBox uIExtendedconnectivityCheckBox = this.UISmartLearnClassifierWindow1.UIExtendedconnectivityWindow.UIExtendedconnectivityCheckBox;

            // Select 'Extended connectivity' check box
            uIExtendedconnectivityCheckBox.Checked = isEnabled;
        }

        public void VerifyClassSpecialProcessingExtendedConnectivity(bool isEnabled)
        {

            WinCheckBox uIExtendedconnectivityCheckBox = this.UISmartLearnClassifierWindow1.UIExtendedconnectivityWindow.UIExtendedconnectivityCheckBox;

            // Select 'Extended connectivity' check box
            Assert.AreEqual(isEnabled, uIExtendedconnectivityCheckBox.Checked);
        }

        public virtual ClassSpecialProcessingParams ClassSpecialProcessingParams
        {
            get
            {
                if ((this.mClassSpecialProcessingParams == null))
                {
                    this.mClassSpecialProcessingParams = new ClassSpecialProcessingParams();
                }
                return this.mClassSpecialProcessingParams;
            }
        }

        private ClassSpecialProcessingParams mClassSpecialProcessingParams;

        /// <summary>
        /// CreateNewClass - Use 'CreateNewClassParams' to pass parameters into this method.
        /// </summary>
        public void CreateNewClass(String className, String description, String symbol)
        {
            #region Variable Declarations
            WinButton uIBtnAddClassButton = this.UISmartLearnClassifierWindow1.UIBtnAddClassWindow.UIBtnAddClassButton;
            WinEdit uITxtNameEdit = this.UISmartLearnClassifierWindow1.UITxtNameWindow.UITxtNameEdit;
            WinEdit uITxtDescriptionEdit = this.UISmartLearnClassifierWindow1.UITxtDescriptionWindow.UITxtDescriptionEdit;
            WinEdit uITxtSymbolEdit = this.UISmartLearnClassifierWindow1.UIItemWindow.UITxtSymbolEdit;
            WinButton uIColorButton = this.UISmartLearnClassifierWindow1.UIColorWindow.UIColorButton;
            WinText uIBasiccolorsText = this.UIColorWindow.UIItemWindow.UIBasiccolorsText;
            WinButton uIOKButton = this.UIColorWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'btnAddClass' button
            Mouse.Click(uIBtnAddClassButton, new Point(14, 19));

            // Type 'TestNewClass' in 'txtName' text box
            uITxtNameEdit.Text = className;

            // Type 'Description' in 'txtDescription' text box
            uITxtDescriptionEdit.Text = description;

            // Type 'w' in 'txtSymbol' text box
            uITxtSymbolEdit.Text = symbol;

            // Click 'Color...' button
            Mouse.Click(uIColorButton, new Point(52, 13));

            // Click 'Basic colors:' label
            Mouse.Click(uIBasiccolorsText, new Point(197, 58));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(41, 12));
        }

        public virtual CreateNewClassParams CreateNewClassParams
        {
            get
            {
                if ((this.mCreateNewClassParams == null))
                {
                    this.mCreateNewClassParams = new CreateNewClassParams();
                }
                return this.mCreateNewClassParams;
            }
        }

        private CreateNewClassParams mCreateNewClassParams;
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
    /// <summary>
    /// Parameters to be passed into 'ClassDataBaseImport'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ClassDataBaseImportParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect and gray' radio button
        /// </summary>
        public bool UIDefectandgrayRadioButtonSelected = true;

        /// <summary>
        /// Select 'Full context' in 'listSaveGray' combo box
        /// </summary>
        public string UIListSaveGrayComboBoxSelectedItem = "Full context";

        /// <summary>
        /// Select 'Use defect's bounding box' check box
        /// </summary>
        public bool UIUsedefectsboundingboCheckBoxChecked = true;

        /// <summary>
        /// Select 'Do not import' radio button
        /// </summary>
        public bool UIDonotimportRadioButtonSelected = true;

        /// <summary>
        /// Select 'Defect only' radio button
        /// </summary>
        public bool UIDefectonlyRadioButtonSelected = true;

        /// <summary>
        /// Select 'Defect and gray' radio button
        /// </summary>
        public bool UIDefectandgrayRadioButtonSelected1 = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ClassNotification'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ClassNotificationParams
    {

        #region Fields
        /// <summary>
        /// Type '15' in 'txtNotificationSeverity' text box
        /// </summary>
        public string UITxtNotificationSeverEditText = "15";

        /// <summary>
        /// Type '5555' in 'txtNotificationDefectRate' text box
        /// </summary>
        public string UITxtNotificationDefecEditText = "5555";

        /// <summary>
        /// Type '65' in 'txtNotificationDensity' text box
        /// </summary>
        public string UITxtNotificationDensiEditText = "65";

        /// <summary>
        /// Type '8888' in 'txtNotificationCumulative' text box
        /// </summary>
        public string UITxtNotificationCumulEditText = "8888";

        /// <summary>
        /// Select 'Notify at each reporting distance' check box
        /// </summary>
        public bool UINotifyateachreportinCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ClassSaveAction'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ClassSaveActionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect only' radio button
        /// </summary>
        public bool UIDefectonlyRadioButtonSelected = true;

        /// <summary>
        /// Select 'Filter (count only)' radio button
        /// </summary>
        public bool UIFiltercountonlyRadioButtonSelected = true;

        /// <summary>
        /// Select 'Discard (do not save)' radio button
        /// </summary>
        public bool UIDiscarddonotsaveRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ClassSpecialProcessing'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ClassSpecialProcessingParams
    {

        #region Fields
        /// <summary>
        /// Select 'Break ongoing defect' check box
        /// </summary>
        public bool UIBreakongoingdefectCheckBoxChecked = true;

        /// <summary>
        /// Select 'Reclassify without ongoing feature' check box
        /// </summary>
        public bool UIReclassifywithoutongCheckBoxChecked = true;

        /// <summary>
        /// Select 'Prevent cam-to-cam merging' check box
        /// </summary>
        public bool UIPreventcamtocammergiCheckBoxChecked = true;

        /// <summary>
        /// Select 'View-to-view correlation' check box
        /// </summary>
        public bool UIViewtoviewcorrelatioCheckBoxChecked = true;

        /// <summary>
        /// Select 'Extended connectivity' check box
        /// </summary>
        public bool UIExtendedconnectivityCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'CreateNewClass'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CreateNewClassParams
    {

        #region Fields
        /// <summary>
        /// Type 'TestNewClass' in 'txtName' text box
        /// </summary>
        public string UITxtNameEditText = "TestNewClass";

        /// <summary>
        /// Type 'Description' in 'txtDescription' text box
        /// </summary>
        public string UITxtDescriptionEditText = "Description";

        /// <summary>
        /// Type 'w' in 'txtSymbol' text box
        /// </summary>
        public string UITxtSymbolEditText = "w";
        #endregion
    }
}
