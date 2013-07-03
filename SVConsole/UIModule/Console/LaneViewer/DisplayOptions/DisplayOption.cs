namespace SVConsole.UIModule.Console.LaneViewer.DisplayOptions.DisplayOptionClasses
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


    public partial class DisplayOption
    {

        /// <summary>
        /// DefineFeatureColumns - Use 'DefineFeatureColumnsParams' to pass parameters into this method.
        /// </summary>
        public void DefineFeatureColumns(bool isFeatureColumn1Enabled, String informationColumn1, bool isFeatureColumn2Enabled, String informationColumn2, String decimalDigit)
        {
            #region Variable Declarations
            WinCheckBox uICheck1CheckBox = this.UIDisplayOptionsWindow.UICheck1Window.UICheck1CheckBox;
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow.UIItemComboBox;
            WinCheckBox uICheck1CheckBox1 = this.UIDisplayOptionsWindow.UICheck1Window1.UICheck1CheckBox;
            WinComboBox uIItemComboBox1 = this.UIDisplayOptionsWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox2 = this.UIDisplayOptionsWindow.UIItemWindow2.UIItemComboBox;
            #endregion

            // Clear 'Check1' check box
            uICheck1CheckBox.Checked = isFeatureColumn1Enabled;
            if (isFeatureColumn1Enabled)
            {
                // Select 'Right' in 'Unknown Name' combo box
                uIItemComboBox.SelectedItem = informationColumn1;
            }

            // Select 'Check1' check box
            uICheck1CheckBox1.Checked = isFeatureColumn2Enabled;

            if (isFeatureColumn2Enabled)
            {
                // Select 'Left' in 'Unknown Name' combo box
                uIItemComboBox1.SelectedItem = informationColumn2;
            }

            // Select '4' in 'Unknown Name' combo box
            uIItemComboBox2.SelectedItem = decimalDigit;
        }

        public void VerifyFeatureColumns(bool isFeatureColumn1Enabled, String informationColumn1, bool isFeatureColumn2Enabled, String informationColumn2, String decimalDigit)
        {
            #region Variable Declarations
            WinCheckBox uICheck1CheckBox = this.UIDisplayOptionsWindow.UICheck1Window.UICheck1CheckBox;
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow.UIItemComboBox;
            WinCheckBox uICheck1CheckBox1 = this.UIDisplayOptionsWindow.UICheck1Window1.UICheck1CheckBox;
            WinComboBox uIItemComboBox1 = this.UIDisplayOptionsWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox2 = this.UIDisplayOptionsWindow.UIItemWindow2.UIItemComboBox;
            #endregion

            // Clear 'Check1' check box
            Assert.AreEqual(isFeatureColumn1Enabled, uICheck1CheckBox.Checked);
            if (isFeatureColumn1Enabled)
            {
                // Select 'Right' in 'Unknown Name' combo box
                Assert.AreEqual(informationColumn1, uIItemComboBox.SelectedItem);
            }

            // Select 'Check1' check box
            Assert.AreEqual(isFeatureColumn2Enabled, uICheck1CheckBox1.Checked);

            if (isFeatureColumn2Enabled)
            {
                // Select 'Left' in 'Unknown Name' combo box
                Assert.AreEqual(informationColumn2, uIItemComboBox1.SelectedItem);
            }

            // Select '4' in 'Unknown Name' combo box
            Assert.AreEqual(decimalDigit, uIItemComboBox2.SelectedItem);
        }

        public virtual DefineFeatureColumnsParams DefineFeatureColumnsParams
        {
            get
            {
                if ((this.mDefineFeatureColumnsParams == null))
                {
                    this.mDefineFeatureColumnsParams = new DefineFeatureColumnsParams();
                }
                return this.mDefineFeatureColumnsParams;
            }
        }

        private DefineFeatureColumnsParams mDefineFeatureColumnsParams;

        /// <summary>
        /// DefineLaneColumnsLabel - Use 'DefineLaneColumnsLabelParams' to pass parameters into this method.
        /// </summary>
        public void DefineLaneColumnsLabel(String label)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow3.UIItemComboBox;
            #endregion

            // Select 'Left limit' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = label;
        }

        public void VerifyLaneColumnsLabel(String label)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow3.UIItemComboBox;
            #endregion

            // Select 'Left limit' in 'Unknown Name' combo box
            Assert.AreEqual(label, uIItemComboBox.SelectedItem);
        }

        public virtual DefineLaneColumnsLabelParams DefineLaneColumnsLabelParams
        {
            get
            {
                if ((this.mDefineLaneColumnsLabelParams == null))
                {
                    this.mDefineLaneColumnsLabelParams = new DefineLaneColumnsLabelParams();
                }
                return this.mDefineLaneColumnsLabelParams;
            }
        }

        private DefineLaneColumnsLabelParams mDefineLaneColumnsLabelParams;

        /// <summary>
        /// EnableIndicateMaterialThatFallsOutsideLaneBoundaries - Use 'EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams' to pass parameters into this method.
        /// </summary>
        public void DefineIndicateMaterialThatFallsOutsideLaneBoundaries(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIShowlanesCheckBox = this.UIDisplayOptionsWindow.UIShowlanesWindow.UIShowlanesCheckBox;
            #endregion

            // Select 'Show <> lanes' check box
            uIShowlanesCheckBox.Checked = isEnabled;
        }

        public void VerifyIndicateMaterialThatFallsOutsideLaneBoundaries(bool isEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIShowlanesCheckBox = this.UIDisplayOptionsWindow.UIShowlanesWindow.UIShowlanesCheckBox;
            #endregion

            // Select 'Show <> lanes' check box
            Assert.AreEqual(isEnabled, uIShowlanesCheckBox.Checked);
        }

        public virtual EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams
        {
            get
            {
                if ((this.mEnableIndicateMaterialThatFallsOutsideLaneBoundariesParams == null))
                {
                    this.mEnableIndicateMaterialThatFallsOutsideLaneBoundariesParams = new EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams();
                }
                return this.mEnableIndicateMaterialThatFallsOutsideLaneBoundariesParams;
            }
        }

        private EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams mEnableIndicateMaterialThatFallsOutsideLaneBoundariesParams;

        /// <summary>
        /// LoadDisplayOptionWindow
        /// </summary>
        public void LoadDisplayOptionWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(64, 14));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(34, 17));
        }

        /// <summary>
        /// LoadLaneViewer
        /// </summary>
        public void LoadLaneViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            #endregion

            // Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(26, 152));
        }

        /// <summary>
        /// SetBackgroundColor - Use 'SetBackgroundColorParams' to pass parameters into this method.
        /// </summary>
        public void SetBackgroundColor(String colorType)
        {
            #region Variable Declarations
            WinRadioButton uICustomRadioButton = this.UIDisplayOptionsWindow.UICustomWindow.UICustomRadioButton;
            WinRadioButton uINormalizertargetRadioButton = this.UIDisplayOptionsWindow.UINormalizertargetWindow.UINormalizertargetRadioButton;
            #endregion

            if (colorType.Equals("Custom"))
            {
                // Select 'Custom' radio button
                uICustomRadioButton.Selected = this.SetBackgroundColorParams.UICustomRadioButtonSelected;
            }

            if (colorType.Equals("Normalizer"))
            {
                // Select 'Normalizer target' radio button
                uINormalizertargetRadioButton.Selected = this.SetBackgroundColorParams.UINormalizertargetRadioButtonSelected;
            }
        }

        public void VerifyBackgroundColor(String colorType)
        {
            #region Variable Declarations
            WinRadioButton uICustomRadioButton = this.UIDisplayOptionsWindow.UICustomWindow.UICustomRadioButton;
            WinRadioButton uINormalizertargetRadioButton = this.UIDisplayOptionsWindow.UINormalizertargetWindow.UINormalizertargetRadioButton;
            #endregion

            if (colorType.Equals("Custom"))
            {
                // Select 'Custom' radio button
                Assert.AreEqual(true, uICustomRadioButton.Selected);
            }

            if (colorType.Equals("Normalizer"))
            {
                // Select 'Normalizer target' radio button
                Assert.AreEqual(true, uINormalizertargetRadioButton.Selected);
            }
        }

        public virtual SetBackgroundColorParams SetBackgroundColorParams
        {
            get
            {
                if ((this.mSetBackgroundColorParams == null))
                {
                    this.mSetBackgroundColorParams = new SetBackgroundColorParams();
                }
                return this.mSetBackgroundColorParams;
            }
        }

        private SetBackgroundColorParams mSetBackgroundColorParams;

        /// <summary>
        /// ShowLanesBasedOnQuery - Use 'ShowLanesBasedOnQueryParams' to pass parameters into this method.
        /// </summary>
        public void ShowLanesBasedOnQuery()
        {
            #region Variable Declarations
            WinCheckBox uIShowHidelanesbasedonCheckBox = this.UIDisplayOptionsWindow.UIShowHidelanesbasedonWindow.UIShowHidelanesbasedonCheckBox;
            #endregion

            // Select 'Show/Hide lanes based on query' check box
            uIShowHidelanesbasedonCheckBox.Checked = this.ShowLanesBasedOnQueryParams.UIShowHidelanesbasedonCheckBoxChecked;
        }

        public virtual ShowLanesBasedOnQueryParams ShowLanesBasedOnQueryParams
        {
            get
            {
                if ((this.mShowLanesBasedOnQueryParams == null))
                {
                    this.mShowLanesBasedOnQueryParams = new ShowLanesBasedOnQueryParams();
                }
                return this.mShowLanesBasedOnQueryParams;
            }
        }

        private ShowLanesBasedOnQueryParams mShowLanesBasedOnQueryParams;

        /// <summary>
        /// ShowMarkReaderViews - Use 'ShowMarkReaderViewsParams' to pass parameters into this method.
        /// </summary>
        public void ShowMarkReaderViews(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowmarkreaderviewsCheckBox = this.UIDisplayOptionsWindow.UIShowmarkreaderviewsWindow.UIShowmarkreaderviewsCheckBox;
            #endregion

            // Select 'Show mark reader views' check box
            uIShowmarkreaderviewsCheckBox.Checked = isShown;
        }

        public void VerifyMarkReaderViews(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowmarkreaderviewsCheckBox = this.UIDisplayOptionsWindow.UIShowmarkreaderviewsWindow.UIShowmarkreaderviewsCheckBox;
            #endregion

            // Select 'Show mark reader views' check box
            Assert.AreEqual(isShown, uIShowmarkreaderviewsCheckBox.Checked);
        }

        public virtual ShowMarkReaderViewsParams ShowMarkReaderViewsParams
        {
            get
            {
                if ((this.mShowMarkReaderViewsParams == null))
                {
                    this.mShowMarkReaderViewsParams = new ShowMarkReaderViewsParams();
                }
                return this.mShowMarkReaderViewsParams;
            }
        }

        private ShowMarkReaderViewsParams mShowMarkReaderViewsParams;

        /// <summary>
        /// ShowSideLabels - Use 'ShowSideLabelsParams' to pass parameters into this method.
        /// </summary>
        public void ShowSideLabels(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowCheckBox = this.UIDisplayOptionsWindow.UIShowWindow.UIShowCheckBox;
            #endregion

            // Select 'Show' check box
            uIShowCheckBox.Checked = isShown;
        }

        public void VerifySideLabels(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIShowCheckBox = this.UIDisplayOptionsWindow.UIShowWindow.UIShowCheckBox;
            #endregion

            // Select 'Show' check box
            Assert.AreEqual(isShown, uIShowCheckBox.Checked);
        }

        public void CloseDisplayOptionWindow()
        {
            new DisplayOption().CloseDisplayOptionDialogBox();
        }

        public virtual ShowSideLabelsParams ShowSideLabelsParams
        {
            get
            {
                if ((this.mShowSideLabelsParams == null))
                {
                    this.mShowSideLabelsParams = new ShowSideLabelsParams();
                }
                return this.mShowSideLabelsParams;
            }
        }

        private ShowSideLabelsParams mShowSideLabelsParams;

        /// <summary>
        /// LoadDisplayOptionDialogBox
        /// </summary>
        public void LoadDisplayOptionDialogBox()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(58, 9));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(26, 11));
}
    }
    /// <summary>
    /// Parameters to be passed into 'DefineFeatureColumns'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineFeatureColumnsParams
    {

        #region Fields
        /// <summary>
        /// Clear 'Check1' check box
        /// </summary>
        public bool UICheck1CheckBoxChecked = false;

        /// <summary>
        /// Select 'Right' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Right";

        /// <summary>
        /// Select 'Check1' check box
        /// </summary>
        public bool UICheck1CheckBoxChecked1 = true;

        /// <summary>
        /// Select 'Left' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem1 = "Left";

        /// <summary>
        /// Select '4' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem2 = "4";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineLaneColumnsLabel'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineLaneColumnsLabelParams
    {

        #region Fields
        /// <summary>
        /// Select 'Left limit' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Left limit";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnableIndicateMaterialThatFallsOutsideLaneBoundaries'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnableIndicateMaterialThatFallsOutsideLaneBoundariesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show <> lanes' check box
        /// </summary>
        public bool UIShowlanesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetBackgroundColor'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetBackgroundColorParams
    {

        #region Fields
        /// <summary>
        /// Select 'Custom' radio button
        /// </summary>
        public bool UICustomRadioButtonSelected = true;

        /// <summary>
        /// Select 'Normalizer target' radio button
        /// </summary>
        public bool UINormalizertargetRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowLanesBasedOnQuery'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowLanesBasedOnQueryParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show/Hide lanes based on query' check box
        /// </summary>
        public bool UIShowHidelanesbasedonCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowMarkReaderViews'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowMarkReaderViewsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show mark reader views' check box
        /// </summary>
        public bool UIShowmarkreaderviewsCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowSideLabels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowSideLabelsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Show' check box
        /// </summary>
        public bool UIShowCheckBoxChecked = true;
        #endregion
    }
    public partial class DisplayOption
    {

        /// <summary>
        /// CloseDisplayOptionDialogBox
        /// </summary>
        public void CloseDisplayOptionDialogBox()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIDisplayOptionsWindow.UIDisplayOptionsTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(5, 8));
}
}
}
