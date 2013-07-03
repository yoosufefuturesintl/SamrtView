namespace SVReview.UIModule.Review.LaneViewer.DisplayOptionsClasses
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
    public partial class DisplayOptions
    {

        /// <summary>
        /// BackgroundColorNormalizerTarget - Use 'BackgroundColorNormalizerTargetParams' to pass parameters into this method.
        /// </summary>
        public void BackgroundColorNormalizerTarget()
        {
            #region Variable Declarations
            WinRadioButton uINormalizertargetRadioButton = this.UIDisplayOptionsWindow.UINormalizertargetWindow.UINormalizertargetRadioButton;
            #endregion

            // Select 'Normalizer target' radio button
            uINormalizertargetRadioButton.Selected = this.BackgroundColorNormalizerTargetParams.UINormalizertargetRadioButtonSelected;
        }

        public virtual BackgroundColorNormalizerTargetParams BackgroundColorNormalizerTargetParams
        {
            get
            {
                if ((this.mBackgroundColorNormalizerTargetParams == null))
                {
                    this.mBackgroundColorNormalizerTargetParams = new BackgroundColorNormalizerTargetParams();
                }
                return this.mBackgroundColorNormalizerTargetParams;
            }
        }

        private BackgroundColorNormalizerTargetParams mBackgroundColorNormalizerTargetParams;

        /// <summary>
        /// CloseDisplayOptionsWindow
        /// </summary>
        public void CloseDisplayOptionsWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIDisplayOptionsWindow.UIDisplayOptionsTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(6, 8));
        }

        /// <summary>
        /// CustomBackgroundColor - Use 'CustomBackgroundColorParams' to pass parameters into this method.
        /// </summary>
        public void CustomBackgroundColor(bool enableCustomBackGroundColor)
        {
            #region Variable Declarations
            WinRadioButton uICustomRadioButton = this.UIDisplayOptionsWindow.UICustomWindow.UICustomRadioButton;
            WinButton uIItemButton = this.UIDisplayOptionsWindow.UIItemWindow3.UIItemButton;
            WinText uIBasiccolorsText = this.UIColorWindow.UIItemWindow.UIBasiccolorsText;
            WinButton uIOKButton = this.UIColorWindow.UIOKWindow.UIOKButton;
            #endregion                      

            if (enableCustomBackGroundColor)
            {
                // Select 'Custom' radio button
                uICustomRadioButton.Selected = enableCustomBackGroundColor;
            
                // Click '...' button
                Mouse.Click(uIItemButton, new Point(10, 18));

                // Click 'Basic colors:' label
                Mouse.Click(uIBasiccolorsText, new Point(141, 32));

                // Click 'OK' button
                Mouse.Click(uIOKButton, new Point(26, 14));
            }

            if (!enableCustomBackGroundColor)
            {
                BackgroundColorNormalizerTarget();
            }
        }

        public virtual CustomBackgroundColorParams CustomBackgroundColorParams
        {
            get
            {
                if ((this.mCustomBackgroundColorParams == null))
                {
                    this.mCustomBackgroundColorParams = new CustomBackgroundColorParams();
                }
                return this.mCustomBackgroundColorParams;
            }
        }

        private CustomBackgroundColorParams mCustomBackgroundColorParams;

        /// <summary>
        /// FeatureColumns - Use 'FeatureColumnsParams' to pass parameters into this method.
        /// </summary>
        public void FeatureColumns()
        {
            #region Variable Declarations
            WinCheckBox uICheck1CheckBox = this.UIDisplayOptionsWindow.UICheck1Window.UICheck1CheckBox;
            #endregion

            // Select 'Check1' check box
            uICheck1CheckBox.Checked = this.FeatureColumnsParams.UICheck1CheckBoxChecked;
        }

        public virtual FeatureColumnsParams FeatureColumnsParams
        {
            get
            {
                if ((this.mFeatureColumnsParams == null))
                {
                    this.mFeatureColumnsParams = new FeatureColumnsParams();
                }
                return this.mFeatureColumnsParams;
            }
        }

        private FeatureColumnsParams mFeatureColumnsParams;

        /// <summary>
        /// InvertDownweb - Use 'InvertDownwebParams' to pass parameters into this method.
        /// </summary>
        public void InvertDownweb()
        {
            #region Variable Declarations
            WinCheckBox uIInvertdownwebCheckBox = this.UIDisplayOptionsWindow.UIInvertdownwebWindow.UIInvertdownwebCheckBox;
            #endregion

            // Select 'Invert downweb' check box
            uIInvertdownwebCheckBox.Checked = this.InvertDownwebParams.UIInvertdownwebCheckBoxChecked;
        }

        public virtual InvertDownwebParams InvertDownwebParams
        {
            get
            {
                if ((this.mInvertDownwebParams == null))
                {
                    this.mInvertDownwebParams = new InvertDownwebParams();
                }
                return this.mInvertDownwebParams;
            }
        }

        private InvertDownwebParams mInvertDownwebParams;

        /// <summary>
        /// LoadDisplayOptionsWindow
        /// </summary>
        public void LoadDisplayOptionsWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewReview4CameWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(63, 16));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(29, 20));
        }

        /// <summary>
        /// SelectFeatureColumns - Use 'SelectFeatureColumnsParams' to pass parameters into this method.
        /// </summary>
        public void SelectFeatureColumns()
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Select 'Downweb Center' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.SelectFeatureColumnsParams.UIItemComboBoxSelectedItem;
        }

        public virtual SelectFeatureColumnsParams SelectFeatureColumnsParams
        {
            get
            {
                if ((this.mSelectFeatureColumnsParams == null))
                {
                    this.mSelectFeatureColumnsParams = new SelectFeatureColumnsParams();
                }
                return this.mSelectFeatureColumnsParams;
            }
        }

        private SelectFeatureColumnsParams mSelectFeatureColumnsParams;

        /// <summary>
        /// SetCustomUnits - Use 'SetCustomUnitsParams' to pass parameters into this method.
        /// </summary>
        public void SetCustomUnits()
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow4.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDisplayOptionsWindow.UIItemWindow11.UIItemComboBox;
            WinComboBox uIItemComboBox2 = this.UIDisplayOptionsWindow.UIItemWindow21.UIItemComboBox;
            WinComboBox uIItemComboBox3 = this.UIDisplayOptionsWindow.UIItemWindow31.UIItemComboBox;
            #endregion

            // Select 'centimeters' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.SetCustomUnitsParams.UIItemComboBoxSelectedItem;

            // Select 'centimeters' in 'Unknown Name' combo box
            uIItemComboBox1.SelectedItem = this.SetCustomUnitsParams.UIItemComboBoxSelectedItem1;

            // Select 'meters' in 'Unknown Name' combo box
            uIItemComboBox2.SelectedItem = this.SetCustomUnitsParams.UIItemComboBoxSelectedItem2;

            // Select 'meters' in 'Unknown Name' combo box
            uIItemComboBox3.SelectedItem = this.SetCustomUnitsParams.UIItemComboBoxSelectedItem3;
        }

        public virtual SetCustomUnitsParams SetCustomUnitsParams
        {
            get
            {
                if ((this.mSetCustomUnitsParams == null))
                {
                    this.mSetCustomUnitsParams = new SetCustomUnitsParams();
                }
                return this.mSetCustomUnitsParams;
            }
        }

        private SetCustomUnitsParams mSetCustomUnitsParams;

        /// <summary>
        /// SetDecimalPoints - Use 'SetDecimalPointsParams' to pass parameters into this method.
        /// </summary>
        public void SetDecimalPoints()
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow1.UIItemComboBox;
            #endregion

            // Select '4' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.SetDecimalPointsParams.UIItemComboBoxSelectedItem;
        }

        public virtual SetDecimalPointsParams SetDecimalPointsParams
        {
            get
            {
                if ((this.mSetDecimalPointsParams == null))
                {
                    this.mSetDecimalPointsParams = new SetDecimalPointsParams();
                }
                return this.mSetDecimalPointsParams;
            }
        }

        private SetDecimalPointsParams mSetDecimalPointsParams;

        /// <summary>
        /// ShowLaneColumnsLabel - Use 'ShowLaneColumnsLabelParams' to pass parameters into this method.
        /// </summary>
        public void ShowLaneColumnsLabel(String label)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow2.UIItemComboBox;
            #endregion

            // Select 'Left limit' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = label;
        }

        public virtual ShowLaneColumnsLabelParams ShowLaneColumnsLabelParams
        {
            get
            {
                if ((this.mShowLaneColumnsLabelParams == null))
                {
                    this.mShowLaneColumnsLabelParams = new ShowLaneColumnsLabelParams();
                }
                return this.mShowLaneColumnsLabelParams;
            }
        }

        private ShowLaneColumnsLabelParams mShowLaneColumnsLabelParams;

        /// <summary>
        /// ShowLaneNavigations - Use 'ShowLaneNavigationsParams' to pass parameters into this method.
        /// </summary>
        public void ShowLaneNavigations()
        {
            #region Variable Declarations
            WinCheckBox uIShowlanesCheckBox = this.UIDisplayOptionsWindow.UIShowlanesWindow.UIShowlanesCheckBox;
            #endregion

            // Clear 'Show <> lanes' check box
            uIShowlanesCheckBox.Checked = this.ShowLaneNavigationsParams.UIShowlanesCheckBoxChecked;
        }

        public virtual ShowLaneNavigationsParams ShowLaneNavigationsParams
        {
            get
            {
                if ((this.mShowLaneNavigationsParams == null))
                {
                    this.mShowLaneNavigationsParams = new ShowLaneNavigationsParams();
                }
                return this.mShowLaneNavigationsParams;
            }
        }

        private ShowLaneNavigationsParams mShowLaneNavigationsParams;

        /// <summary>
        /// ShowLanesBasedOnQuery - Use 'ShowLanesBasedOnQueryParams' to pass parameters into this method.
        /// </summary>
        public void ShowLanesBasedOnQuery(bool isDisplayed)
        {
            #region Variable Declarations
            WinCheckBox uIShowHidelanesbasedonCheckBox = this.UIDisplayOptionsWindow.UIShowHidelanesbasedonWindow.UIShowHidelanesbasedonCheckBox;
            #endregion

            // Select 'Show/Hide lanes based on query' check box
            uIShowHidelanesbasedonCheckBox.Checked = isDisplayed;
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
        public void ShowMarkReaderViews(bool isDisplayed)
        {
            #region Variable Declarations
            WinCheckBox uIShowmarkreaderviewsCheckBox = this.UIDisplayOptionsWindow.UIShowmarkreaderviewsWindow.UIShowmarkreaderviewsCheckBox;
            #endregion

            // Select 'Show mark reader views' check box
            uIShowmarkreaderviewsCheckBox.Checked = isDisplayed;
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
        public void ShowSideLabels(bool isDisplayed)
        {
            #region Variable Declarations
            WinCheckBox uIShowCheckBox = this.UIDisplayOptionsWindow.UIShowWindow.UIShowCheckBox;
            #endregion

            // Select 'Show' check box
            uIShowCheckBox.Checked = isDisplayed;
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
        /// UseDefaultUnits - Use 'UseDefaultUnitsParams' to pass parameters into this method.
        /// </summary>
        public void UseDefaultUnits()
        {
            #region Variable Declarations
            WinCheckBox uIUsedefaultCheckBox = this.UIDisplayOptionsWindow.UIUsedefaultWindow.UIUsedefaultCheckBox;
            #endregion

            // Select 'Use default' check box
            uIUsedefaultCheckBox.Checked = this.UseDefaultUnitsParams.UIUsedefaultCheckBoxChecked;
        }

        public virtual UseDefaultUnitsParams UseDefaultUnitsParams
        {
            get
            {
                if ((this.mUseDefaultUnitsParams == null))
                {
                    this.mUseDefaultUnitsParams = new UseDefaultUnitsParams();
                }
                return this.mUseDefaultUnitsParams;
            }
        }

        private UseDefaultUnitsParams mUseDefaultUnitsParams;
    }
    /// <summary>
    /// Parameters to be passed into 'BackgroundColorNormalizerTarget'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class BackgroundColorNormalizerTargetParams
    {

        #region Fields
        /// <summary>
        /// Select 'Normalizer target' radio button
        /// </summary>
        public bool UINormalizertargetRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'CustomBackgroundColor'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CustomBackgroundColorParams
    {

        #region Fields
        /// <summary>
        /// Select 'Custom' radio button
        /// </summary>
        public bool UICustomRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'FeatureColumns'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class FeatureColumnsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Check1' check box
        /// </summary>
        public bool UICheck1CheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'InvertDownweb'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class InvertDownwebParams
    {

        #region Fields
        /// <summary>
        /// Select 'Invert downweb' check box
        /// </summary>
        public bool UIInvertdownwebCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectFeatureColumns'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectFeatureColumnsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Downweb Center' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Downweb Center";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetCustomUnits'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetCustomUnitsParams
    {

        #region Fields
        /// <summary>
        /// Select 'centimeters' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "centimeters";

        /// <summary>
        /// Select 'centimeters' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem1 = "centimeters";

        /// <summary>
        /// Select 'meters' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem2 = "meters";

        /// <summary>
        /// Select 'meters' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem3 = "meters";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetDecimalPoints'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetDecimalPointsParams
    {

        #region Fields
        /// <summary>
        /// Select '4' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "4";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowLaneColumnsLabel'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowLaneColumnsLabelParams
    {

        #region Fields
        /// <summary>
        /// Select 'Left limit' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Left limit";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowLaneNavigations'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowLaneNavigationsParams
    {

        #region Fields
        /// <summary>
        /// Clear 'Show <> lanes' check box
        /// </summary>
        public bool UIShowlanesCheckBoxChecked = false;
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
    /// <summary>
    /// Parameters to be passed into 'UseDefaultUnits'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UseDefaultUnitsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Use default' check box
        /// </summary>
        public bool UIUsedefaultCheckBoxChecked = true;
        #endregion
}
}
