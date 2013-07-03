namespace SVRecipe.UIModule.Recipe.RepeatingDefectSetup.RepeatingDefectSetupClasses
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
    public partial class RepeatingDefectSetup
    {

        /// <summary>
        /// ApplySettings
        /// </summary>
        public void ApplySettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(31, 14));
        }

        /// <summary>
        /// AssignNotificationOutput - Use 'AssignNotificationOutputParams' to pass parameters into this method.
        /// </summary>
        public void AssignNotificationOutput()
        {
            #region Variable Declarations
            WinButton uINotificationButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UINotificationWindow.UINotificationButton;
            WinList uIItemList = this.UISmartViewRecipeManagWindow.UIRepeatingDefectNotifWindow.UIItemWindow.UIItemList;
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectNotifWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectNotifWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Notification...' button
            Mouse.Click(uINotificationButton, new Point(56, 9));

            // Select 'Output 1,Output 2,Output 3,Output 4,Output 7,Output 11' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.AssignNotificationOutputParams.UIItemListSelectedItemsAsString;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(34, 13));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(63, 14));
        }

        public virtual AssignNotificationOutputParams AssignNotificationOutputParams
        {
            get
            {
                if ((this.mAssignNotificationOutputParams == null))
                {
                    this.mAssignNotificationOutputParams = new AssignNotificationOutputParams();
                }
                return this.mAssignNotificationOutputParams;
            }
        }

        private AssignNotificationOutputParams mAssignNotificationOutputParams;

        /// <summary>
        /// DefineRepeatSource - Use 'DefineRepeatSourceParams' to pass parameters into this method.
        /// </summary>
        public void DefineRepeatSource()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow5.UIItemButton;
            WinButton uIFilemenuButton = this.UIDefineRepeatSourcesWindow.UIToolbarWindow.UIFilemenuButton;
            WinMenuItem uINewMenuItem = this.UIItemWindow.UIContextMenu.UINewMenuItem;
            WinClient uIPanelClient = this.UIDefineRepeatSourcesWindow.UIPanelWindow.UIPanelClient;
            WinClient uIFocusSinkClient = this.UIDefineRepeatSourcesWindow.UIFocusSinkWindow.UIFocusSinkClient;
            WinEdit uIItemEdit = this.UIDefineRepeatSourcesWindow.UIEnternewsourcenameWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIDefineRepeatSourcesWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIDefineRepeatSourcesWindow.UIItemWindow1.UIItemEdit;
            WinButton uISaveButton = this.UIDefineRepeatSourcesWindow.UIToolbarWindow.UISaveButton;
            WinEdit uITextEdit = this.UISaveWindow.UITextWindow.UITextEdit;
            WinButton uIOKButton = this.UISaveWindow.UIOKWindow.UIOKButton;
            WinButton uICloseButton = this.UIDefineRepeatSourcesWindow.UIDefineRepeatSourcesTitleBar.UICloseButton;
            #endregion

            // Click '...' button
            Mouse.Click(uIItemButton, new Point(16, 14));

            // Click 'File menu' button
            Mouse.Click(uIFilemenuButton, new Point(9, 12));

            // Click 'New' menu item
            Mouse.Click(uINewMenuItem, new Point(25, 6));

            // Click 'panel' client
            Mouse.Click(uIPanelClient, new Point(78, 28));

            // Type 't' in 'focusSink' client
            Keyboard.SendKeys(uIFocusSinkClient, this.DefineRepeatSourceParams.UIFocusSinkClientSendKeys, ModifierKeys.None);

            // Double-Click 'panel' client
            Mouse.DoubleClick(uIPanelClient, new Point(78, 28));

            // Type 'Test123' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineRepeatSourceParams.UIItemEditText;

            // Click 'panel' client
            Mouse.Click(uIPanelClient, new Point(195, 22));

            // Double-Click 'panel' client
            Mouse.DoubleClick(uIPanelClient, new Point(195, 22));

            // Type '10' in 'Unknown Name' text box
            uIItemEdit1.Text = this.DefineRepeatSourceParams.UIItemEditText1;

            // Double-Click 'panel' client
            Mouse.DoubleClick(uIPanelClient, new Point(302, 20));

            // Type '12' in 'Unknown Name' text box
            uIItemEdit2.Text = this.DefineRepeatSourceParams.UIItemEditText2;

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(6, 12));

            // Type 'Test123' in 'text' text box
            uITextEdit.Text = this.DefineRepeatSourceParams.UITextEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(50, 11));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(22, 6));
        }

        public virtual DefineRepeatSourceParams DefineRepeatSourceParams
        {
            get
            {
                if ((this.mDefineRepeatSourceParams == null))
                {
                    this.mDefineRepeatSourceParams = new DefineRepeatSourceParams();
                }
                return this.mDefineRepeatSourceParams;
            }
        }

        private DefineRepeatSourceParams mDefineRepeatSourceParams;

        /// <summary>
        /// EnableRepeatingDefectDetection - Use 'EnableRepeatingDefectDetectionParams' to pass parameters into this method.
        /// </summary>
        public void EnableRepeatingDefectDetection(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIEnableCheckBox = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIEnableWindow.UIEnableCheckBox;
            #endregion

            // Select 'Enable' check box
            uIEnableCheckBox.Checked = isEnabled;
        }

        public void VerifyRepeatingDefectDetectionStatus(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIEnableCheckBox = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIEnableWindow.UIEnableCheckBox;
            #endregion

            // Select 'Enable' check box
            uIEnableCheckBox.Checked = isEnabled;
            Assert.AreEqual(isEnabled, uIEnableCheckBox.Checked);
        }

        public virtual EnableRepeatingDefectDetectionParams EnableRepeatingDefectDetectionParams
        {
            get
            {
                if ((this.mEnableRepeatingDefectDetectionParams == null))
                {
                    this.mEnableRepeatingDefectDetectionParams = new EnableRepeatingDefectDetectionParams();
                }
                return this.mEnableRepeatingDefectDetectionParams;
            }
        }

        private EnableRepeatingDefectDetectionParams mEnableRepeatingDefectDetectionParams;

        /// <summary>
        /// ExportRepeatingDefectSetupParameter - Use 'ExportRepeatingDefectSetupParameterParams' to pass parameters into this method.
        /// </summary>
        public void ExportRepeatingDefectSetupParameter()
        {
            #region Variable Declarations
            WinButton uIExportButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIExportWindow.UIExportButton;
            WinComboBox uIFilenameComboBox = this.UIExportRepeatingDefecWindow.UIDetailsPanePane.UIFilenameComboBox;
            WinButton uISaveButton = this.UIExportRepeatingDefecWindow.UISaveWindow.UISaveButton;
            #endregion

            // Click 'Export...' button
            Mouse.Click(uIExportButton, new Point(34, 12));

            // Select 'test.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.ExportRepeatingDefectSetupParameterParams.UIFilenameComboBoxEditableItem;

            // Click '&Save' button
            Mouse.Click(uISaveButton, new Point(32, 17));
        }

        public virtual ExportRepeatingDefectSetupParameterParams ExportRepeatingDefectSetupParameterParams
        {
            get
            {
                if ((this.mExportRepeatingDefectSetupParameterParams == null))
                {
                    this.mExportRepeatingDefectSetupParameterParams = new ExportRepeatingDefectSetupParameterParams();
                }
                return this.mExportRepeatingDefectSetupParameterParams;
            }
        }

        private ExportRepeatingDefectSetupParameterParams mExportRepeatingDefectSetupParameterParams;

        /// <summary>
        /// ImportRepeatingDefectDetectionSetupParameters - Use 'ImportRepeatingDefectDetectionSetupParametersParams' to pass parameters into this method.
        /// </summary>
        public void ImportRepeatingDefectDetectionSetupParameters()
        {
            #region Variable Declarations
            WinButton uIImportButton = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIImportWindow.UIImportButton;
            WinComboBox uIFilenameComboBox = this.UIImportRepeatingDefecWindow.UIItemWindow.UIFilenameComboBox;
            WinButton uIOpenButton = this.UIImportRepeatingDefecWindow.UIOpenWindow.UIOpenButton;
            #endregion

            // Click 'Import...' button
            Mouse.Click(uIImportButton, new Point(27, 15));

            // Select 'test.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.ImportRepeatingDefectDetectionSetupParametersParams.UIFilenameComboBoxEditableItem;

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(39, 16));
        }

        public virtual ImportRepeatingDefectDetectionSetupParametersParams ImportRepeatingDefectDetectionSetupParametersParams
        {
            get
            {
                if ((this.mImportRepeatingDefectDetectionSetupParametersParams == null))
                {
                    this.mImportRepeatingDefectDetectionSetupParametersParams = new ImportRepeatingDefectDetectionSetupParametersParams();
                }
                return this.mImportRepeatingDefectDetectionSetupParametersParams;
            }
        }

        private ImportRepeatingDefectDetectionSetupParametersParams mImportRepeatingDefectDetectionSetupParametersParams;

        /// <summary>
        /// LoadRepeatingDefectSetup
        /// </summary>
        public void LoadRepeatingDefectSetup(String recipe, String view)
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinMenuItem uIRepeatingDefectSetupMenuItem = this.UIItemWindow.UIContextMenu.UIRepeatingDefectSetupMenuItem;
            uIView1TreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = view;
            uIView1TreeItem.WindowTitles.Add("SmartView Recipe Manager - " + recipe);

            #endregion

            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(21, 8));

            // Click 'Repeating Defect Setup...' menu item
            Mouse.Click(uIRepeatingDefectSetupMenuItem, new Point(85, 15));
        }

        /// <summary>
        /// SetSeriesDefinition - Use 'SetSeriesDefinitionParams' to pass parameters into this method.
        /// </summary>
        public void SetSeriesDefinition(String minPeriod, String maxPeriod, String qualifyingCount, String skipsAllowedInSeries)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow3.UIItemEdit;
            #endregion

            // Type '251.000' in 'Unknown Name' text box
            uIItemEdit.Text = minPeriod;

            // Type '120001.000' in 'Unknown Name' text box
            uIItemEdit1.Text = maxPeriod;

            // Type '4' in 'Unknown Name' text box
            uIItemEdit2.Text = qualifyingCount;

            // Type '2' in 'Unknown Name' text box
            uIItemEdit3.Text = skipsAllowedInSeries;
        }

        public void VerifySeriesDefinitionParametes(String minPeriod, String maxPeriod, String qualifyingCount, String skipsAllowedInSeries)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow3.UIItemEdit;
            #endregion

            // Type '251.000' in 'Unknown Name' text box
            Assert.AreEqual(minPeriod,uIItemEdit.Text);

            // Type '120001.000' in 'Unknown Name' text box
             Assert.AreEqual(maxPeriod,uIItemEdit1.Text);
            
            // Type '4' in 'Unknown Name' text box
            Assert.AreEqual(qualifyingCount, uIItemEdit2.Text);            

            // Type '2' in 'Unknown Name' text box
            Assert.AreEqual(skipsAllowedInSeries, uIItemEdit3.Text);
            
        }
        public virtual SetSeriesDefinitionParams SetSeriesDefinitionParams
        {
            get
            {
                if ((this.mSetSeriesDefinitionParams == null))
                {
                    this.mSetSeriesDefinitionParams = new SetSeriesDefinitionParams();
                }
                return this.mSetSeriesDefinitionParams;
            }
        }

        private SetSeriesDefinitionParams mSetSeriesDefinitionParams;

        /// <summary>
        /// SetVariationWithinSeries - Use 'SetVariationWithinSeriesParams' to pass parameters into this method.
        /// </summary>
        public void SetVariationWithinSeries(String widthVariation, String heightVariation, String crosswebWander, String periodVariation)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow11.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow21.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow31.UIItemEdit;
            #endregion

            // Type '5.000' in 'Unknown Name' text box
            uIItemEdit.Text = widthVariation;

            // Type '7.000' in 'Unknown Name' text box
            uIItemEdit1.Text = heightVariation;

            // Type '5.000' in 'Unknown Name' text box
            uIItemEdit2.Text = crosswebWander;

            // Type '11.' in 'Unknown Name' text box
            uIItemEdit3.Text = periodVariation;
        }

        public void VerifyVariationWithinSeries(String widthVariation, String heightVariation, String crosswebWander, String periodVariation)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow11.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow21.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UIRepeatingDefectSetupWindow.UIItemWindow31.UIItemEdit;
            #endregion

            // Type '5.000' in 'Unknown Name' text box
            Assert.AreEqual(widthVariation,uIItemEdit.Text);

            // Type '7.000' in 'Unknown Name' text box
            Assert.AreEqual(heightVariation,uIItemEdit1.Text);

            // Type '5.000' in 'Unknown Name' text box
            Assert.AreEqual(crosswebWander,uIItemEdit2.Text);

            // Type '11.' in 'Unknown Name' text box
            Assert.AreEqual(periodVariation,uIItemEdit3.Text);
        }

        public virtual SetVariationWithinSeriesParams SetVariationWithinSeriesParams
        {
            get
            {
                if ((this.mSetVariationWithinSeriesParams == null))
                {
                    this.mSetVariationWithinSeriesParams = new SetVariationWithinSeriesParams();
                }
                return this.mSetVariationWithinSeriesParams;
            }
        }

        private SetVariationWithinSeriesParams mSetVariationWithinSeriesParams;
    }
    /// <summary>
    /// Parameters to be passed into 'AssignNotificationOutput'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AssignNotificationOutputParams
    {

        #region Fields
        /// <summary>
        /// Select 'Output 1,Output 2,Output 3,Output 4,Output 7,Output 11' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Output 1,Output 2,Output 3,Output 4,Output 7,Output 11";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineRepeatSource'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineRepeatSourceParams
    {

        #region Fields
        /// <summary>
        /// Type 't' in 'focusSink' client
        /// </summary>
        public string UIFocusSinkClientSendKeys = "t";

        /// <summary>
        /// Type 'Test123' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "Test123";

        /// <summary>
        /// Type '10' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "10";

        /// <summary>
        /// Type '12' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "12";

        /// <summary>
        /// Type 'Test123' in 'text' text box
        /// </summary>
        public string UITextEditText = "Test123";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnableRepeatingDefectDetection'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnableRepeatingDefectDetectionParams
    {

        #region Fields
        /// <summary>
        /// Select 'Enable' check box
        /// </summary>
        public bool UIEnableCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ExportRepeatingDefectSetupParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ExportRepeatingDefectSetupParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'test.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "test.txt";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ImportRepeatingDefectDetectionSetupParameters'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportRepeatingDefectDetectionSetupParametersParams
    {

        #region Fields
        /// <summary>
        /// Select 'test.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "test.txt";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetSeriesDefinition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetSeriesDefinitionParams
    {

        #region Fields
        /// <summary>
        /// Type '251.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "251.000";

        /// <summary>
        /// Type '120001.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "120001.000";

        /// <summary>
        /// Type '4' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "4";

        /// <summary>
        /// Type '2' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText3 = "2";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetVariationWithinSeries'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetVariationWithinSeriesParams
    {

        #region Fields
        /// <summary>
        /// Type '5.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "5.000";

        /// <summary>
        /// Type '7.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "7.000";

        /// <summary>
        /// Type '5.000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "5.000";

        /// <summary>
        /// Type '11.' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText3 = "11.";
        #endregion
}
}
