namespace SVRecipe.UIModule.Recipe.SheetQualityAnalysis.SheetQualityAnalysisClasses
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
    public partial class SheetQualityAnalysis
    {

        /// <summary>
        /// ApplyAnalysisMethod
        /// </summary>
        public void ApplyAnalysisMethod()
        {
            #region Variable Declarations
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIApplyWindow.UIApplyButton;
            #endregion

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(30, 7));
        }

        /// <summary>
        /// ApplySQASettings
        /// </summary>
        public void ApplySQASettings()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(55, 5));
        }

        /// <summary>
        /// DefineAnalysisMethodsStatistical - Use 'DefineAnalysisMethodsStatisticalParams' to pass parameters into this method.
        /// </summary>
        public void DefineAnalysisMethodsStatistical()
        {
            #region Variable Declarations
            WinList uIItemList = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItemWindow1.UIItemList;
            #endregion

            // Select 'Statistical,Textural' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.DefineAnalysisMethodsStatisticalParams.UIItemListSelectedItemsAsString;
        }

        public virtual DefineAnalysisMethodsStatisticalParams DefineAnalysisMethodsStatisticalParams
        {
            get
            {
                if ((this.mDefineAnalysisMethodsStatisticalParams == null))
                {
                    this.mDefineAnalysisMethodsStatisticalParams = new DefineAnalysisMethodsStatisticalParams();
                }
                return this.mDefineAnalysisMethodsStatisticalParams;
            }
        }

        private DefineAnalysisMethodsStatisticalParams mDefineAnalysisMethodsStatisticalParams;

        /// <summary>
        /// DefineAnalysisTextural - Use 'DefineAnalysisTexturalParams' to pass parameters into this method.
        /// </summary>
        public void DefineAnalysisTextural()
        {
            #region Variable Declarations
            WinClient uIAnalysismethodsClient = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItemWindow11.UIAnalysismethodsClient;
            WinClient uIAnalysismethodsClient1 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItemWindow12.UIAnalysismethodsClient;
            WinComboBox uIFilenameComboBox = this.UISQAConfigurationWindow.UIItemWindow.UIFilenameComboBox;
            WinSplitButton uIOpenSplitButton = this.UISQAConfigurationWindow.UIOpenWindow.UIOpenSplitButton;
            #endregion

            // Click 'Analysis methods' client
            Mouse.Click(uIAnalysismethodsClient, new Point(116, 28));

            // Double-Click 'Analysis methods' client
            Mouse.DoubleClick(uIAnalysismethodsClient1, new Point(116, 28));

            // Select 'maximumvalue.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.DefineAnalysisTexturalParams.UIFilenameComboBoxEditableItem;

            // Click '&Open' split button
            Mouse.Click(uIOpenSplitButton, new Point(43, 14));
        }

        public virtual DefineAnalysisTexturalParams DefineAnalysisTexturalParams
        {
            get
            {
                if ((this.mDefineAnalysisTexturalParams == null))
                {
                    this.mDefineAnalysisTexturalParams = new DefineAnalysisTexturalParams();
                }
                return this.mDefineAnalysisTexturalParams;
            }
        }

        private DefineAnalysisTexturalParams mDefineAnalysisTexturalParams;

        /// <summary>
        /// DefineCrosswebLocation - Use 'DefineCrosswebLocationParams' to pass parameters into this method.
        /// </summary>
        public void DefineCrosswebLocation(String locaitonType, String centerValue)
        {
            #region Variable Declarations
            WinRadioButton uICenteredatRadioButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UICenteredatWindow.UICenteredatRadioButton;
            WinRadioButton uICenteredincameraRadioButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UICenteredincameraWindow.UICenteredincameraRadioButton;
            #endregion

            if (locaitonType.Equals("CenteredInCamera"))
            {
                // Select 'Centered at' radio button
                uICenteredatRadioButton.Selected = this.DefineCrosswebLocationParams.UICenteredatRadioButtonSelected;
            }

            if (locaitonType.Equals("CenteredAt"))
            {
                // Select 'Centered in camera' radio button
                uICenteredincameraRadioButton.Selected = this.DefineCrosswebLocationParams.UICenteredincameraRadioButtonSelected;
            }
        }

        public void VerifyDefineCrosswebLocation(String locaitonType, String centerValue)
        {
            #region Variable Declarations
            WinRadioButton uICenteredatRadioButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UICenteredatWindow.UICenteredatRadioButton;
            WinRadioButton uICenteredincameraRadioButton = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UICenteredincameraWindow.UICenteredincameraRadioButton;
            #endregion

            if (locaitonType.Equals("CenteredInCamera"))
            {
                // Select 'Centered at' radio button
                Assert.AreEqual(this.DefineCrosswebLocationParams.UICenteredatRadioButtonSelected, uICenteredatRadioButton.Selected);
            }

            if (locaitonType.Equals("CenteredAt"))
            {
                // Select 'Centered in camera' radio button
                Assert.AreEqual(this.DefineCrosswebLocationParams.UICenteredincameraRadioButtonSelected, uICenteredincameraRadioButton.Selected);
            }
        }

        public virtual DefineCrosswebLocationParams DefineCrosswebLocationParams
        {
            get
            {
                if ((this.mDefineCrosswebLocationParams == null))
                {
                    this.mDefineCrosswebLocationParams = new DefineCrosswebLocationParams();
                }
                return this.mDefineCrosswebLocationParams;
            }
        }

        private DefineCrosswebLocationParams mDefineCrosswebLocationParams;

        /// <summary>
        /// EnableSheetQualityAnalysis - Use 'EnableSheetQualityAnalysisParams' to pass parameters into this method.
        /// </summary>
        public void EnableSheetQualityAnalysis(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIEnablesheetqualityanCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIEnablesheetqualityanWindow.UIEnablesheetqualityanCheckBox;
            #endregion

            // Select 'Enable sheet quality analysis' check box
            uIEnablesheetqualityanCheckBox.Checked = isEnabled;
        }

        public void VerifySheetQualityAnalysisStatus(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIEnablesheetqualityanCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIEnablesheetqualityanWindow.UIEnablesheetqualityanCheckBox;
            #endregion

            // Select 'Enable sheet quality analysis' check box
            Assert.AreEqual(isEnabled, uIEnablesheetqualityanCheckBox.Checked);
        }

        public virtual EnableSheetQualityAnalysisParams EnableSheetQualityAnalysisParams
        {
            get
            {
                if ((this.mEnableSheetQualityAnalysisParams == null))
                {
                    this.mEnableSheetQualityAnalysisParams = new EnableSheetQualityAnalysisParams();
                }
                return this.mEnableSheetQualityAnalysisParams;
            }
        }

        private EnableSheetQualityAnalysisParams mEnableSheetQualityAnalysisParams;

        /// <summary>
        /// LoadSheetQualityAnalysisWindow
        /// </summary>
        public void LoadSheetQualityAnalysisWindow(String recipe, String view)
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinMenuItem uISheetQualityAnalysisMenuItem = this.UIItemWindow.UIContextMenu.UISheetQualityAnalysisMenuItem;
            uIView1TreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = view;
            uIView1TreeItem.WindowTitles.Add("SmartView Recipe Manager - " + recipe);
            #endregion

            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(19, 4));

            // Click 'Sheet Quality Analysis...' menu item
            Mouse.Click(uISheetQualityAnalysisMenuItem, new Point(70, 11));
        }

        /// <summary>
        /// SetCamera
        /// </summary>
        public void SetCamera(String cameras)
        {
            #region Variable Declarations
            WinClient uIImageparametersClient = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItemWindow.UIImageparametersClient;
            #endregion

            if (cameras.Equals("cam1"))
            {
                // Click 'Image parameters' client
                Mouse.Click(uIImageparametersClient, new Point(10, 31));
            }

            if (cameras.Equals("cam2"))
            {
                // Click 'Image parameters' client
                Mouse.Click(uIImageparametersClient, new Point(10, 40));
            }

            if (cameras.Equals("cam3"))
            {
                // Click 'Image parameters' client
                Mouse.Click(uIImageparametersClient, new Point(10, 56));
            }

            if (cameras.Equals("cam4"))
            {
                // Click 'Image parameters' client
                Mouse.Click(uIImageparametersClient, new Point(10, 83));
            }
        }

        /// <summary>
        /// SQAImageParameters - Use 'SQAImageParametersParams' to pass parameters into this method.
        /// </summary>
        public void SQAImageParameters(String sampleIntreval, String imageWidth, String imageHeight)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window.UIItemEdit;
            WinWindow uIItem0Window = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIImageparametersGroup.UIItem0Window;
            WinGroup uIImageparametersGroup = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIImageparametersWindow.UIImageparametersGroup;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window3.UIItemEdit;
            #endregion

            
            // Type '10' in 'Unknown Name' text box
            uIItemEdit.Text = sampleIntreval.Split('.')[0];                        

            // Type '20' in 'Unknown Name' text box
            uIItemEdit1.Text = sampleIntreval.Split('.')[1]; ;

            // Type '101.00' in 'Unknown Name' text box
            uIItemEdit2.Text = imageWidth;

            // Type '110.00' in 'Unknown Name' text box
            uIItemEdit3.Text = imageHeight;
        }

        public void VerifySQAImageParameters(String sampleIntreval, String imageWidth, String imageHeight)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window.UIItemEdit;
            WinWindow uIItem0Window = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIImageparametersGroup.UIItem0Window;
            WinGroup uIImageparametersGroup = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIImageparametersWindow.UIImageparametersGroup;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window3.UIItemEdit;
            #endregion


            // Type '10' in 'Unknown Name' text box
            Assert.AreEqual( sampleIntreval.Split('.')[0],uIItemEdit.Text);

            // Type '20' in 'Unknown Name' text box
            Assert.AreEqual(sampleIntreval.Split('.')[1], uIItemEdit1.Text);

            // Type '101.00' in 'Unknown Name' text box
            Assert.AreEqual(imageWidth, uIItemEdit2.Text);

            // Type '110.00' in 'Unknown Name' text box
            Assert.AreEqual(imageHeight, uIItemEdit3.Text);
        }

        public virtual SQAImageParametersParams SQAImageParametersParams
        {
            get
            {
                if ((this.mSQAImageParametersParams == null))
                {
                    this.mSQAImageParametersParams = new SQAImageParametersParams();
                }
                return this.mSQAImageParametersParams;
            }
        }

        private SQAImageParametersParams mSQAImageParametersParams;

        /// <summary>
        /// SQAImageParametersSampleQualification - Use 'SQAImageParametersSampleQualificationParams' to pass parameters into this method.
        /// </summary>
        public void SQAImageParametersSampleQualificationRightEdge(bool isEnabled, String distance)
        {
            #region Variable Declarations           
            WinCheckBox uIMinimumdistancefromrCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIMinimumdistancefromrWindow.UIMinimumdistancefromrCheckBox;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window5.UIItemEdit;
            #endregion

            // Select 'Minimum distance from right edge:' check box
            uIMinimumdistancefromrCheckBox.Checked = isEnabled;

            if (isEnabled)
            {
                // Type '10.00' in 'Unknown Name' text box
                uIItemEdit1.Text = distance;
            }
        }

        public void VerifySQAImageParametersSampleQualificationRightEdge(bool isEnabled, String distance)
        {
            #region Variable Declarations
            WinCheckBox uIMinimumdistancefromrCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIMinimumdistancefromrWindow.UIMinimumdistancefromrCheckBox;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window5.UIItemEdit;
            #endregion

            // Select 'Minimum distance from right edge:' check box
            Assert.AreEqual(isEnabled,uIMinimumdistancefromrCheckBox.Checked);
             

            if (isEnabled)
            {
                // Type '10.00' in 'Unknown Name' text box
                Assert.AreEqual(distance, uIItemEdit1.Text);
            }
        }


        public void SQAImageParametersSampleQualificationLeftEdge(bool isEnabled, String distance)
        {
            #region Variable Declarations
            WinCheckBox uIMinimumdistancefromlCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIMinimumdistancefromlWindow.UIMinimumdistancefromlCheckBox;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window4.UIItemEdit;
            #endregion

            // Select 'Minimum distance from left edge:' check box
            uIMinimumdistancefromlCheckBox.Checked = isEnabled;

            if (isEnabled)
            {
                // Type '10.00' in 'Unknown Name' text box
                uIItemEdit.Text = distance;
            }
        }

        public void VerifySQAImageParametersSampleQualificationLeftEdge(bool isEnabled, String distance)
        {
            #region Variable Declarations
            WinCheckBox uIMinimumdistancefromlCheckBox = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIMinimumdistancefromlWindow.UIMinimumdistancefromlCheckBox;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UISheetQualityAnalysisWindow.UIItem0Window4.UIItemEdit;
            #endregion

            // Select 'Minimum distance from left edge:' check box
            Assert.AreEqual(isEnabled, uIMinimumdistancefromlCheckBox.Checked);


            if (isEnabled)
            {
                // Type '10.00' in 'Unknown Name' text box
                Assert.AreEqual(distance, uIItemEdit.Text);
            }
        }

        public virtual SQAImageParametersSampleQualificationParams SQAImageParametersSampleQualificationParams
        {
            get
            {
                if ((this.mSQAImageParametersSampleQualificationParams == null))
                {
                    this.mSQAImageParametersSampleQualificationParams = new SQAImageParametersSampleQualificationParams();
                }
                return this.mSQAImageParametersSampleQualificationParams;
            }
        }

        private SQAImageParametersSampleQualificationParams mSQAImageParametersSampleQualificationParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DefineAnalysisMethodsStatistical'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineAnalysisMethodsStatisticalParams
    {

        #region Fields
        /// <summary>
        /// Select 'Statistical,Textural' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Statistical,Textural";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineAnalysisTextural'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineAnalysisTexturalParams
    {

        #region Fields
        /// <summary>
        /// Select 'maximumvalue.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "maximumvalue.txt";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineCrosswebLocation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineCrosswebLocationParams
    {

        #region Fields
        /// <summary>
        /// Select 'Centered at' radio button
        /// </summary>
        public bool UICenteredatRadioButtonSelected = true;

        /// <summary>
        /// Select 'Centered in camera' radio button
        /// </summary>
        public bool UICenteredincameraRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnableSheetQualityAnalysis'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnableSheetQualityAnalysisParams
    {

        #region Fields
        /// <summary>
        /// Select 'Enable sheet quality analysis' check box
        /// </summary>
        public bool UIEnablesheetqualityanCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SQAImageParameters'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SQAImageParametersParams
    {

        #region Fields
        /// <summary>
        /// Type '10' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "10";

        /// <summary>
        /// Type '{Delete}' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditSendKeys = "{Delete}";

        /// <summary>
        /// Type '20' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "20";

        /// <summary>
        /// Type '101.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "101.00";

        /// <summary>
        /// Type '110.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText3 = "110.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SQAImageParametersSampleQualification'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SQAImageParametersSampleQualificationParams
    {

        #region Fields
        /// <summary>
        /// Select 'Minimum distance from left edge:' check box
        /// </summary>
        public bool UIMinimumdistancefromlCheckBoxChecked = true;

        /// <summary>
        /// Type '10.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "10.00";

        /// <summary>
        /// Select 'Minimum distance from right edge:' check box
        /// </summary>
        public bool UIMinimumdistancefromrCheckBoxChecked = true;

        /// <summary>
        /// Type '10.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "10.00";
        #endregion
}
}
