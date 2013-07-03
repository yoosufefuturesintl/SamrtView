namespace SmartView.UIModule.Console.MultiDefectViewer.MultiDefectViewerDisplayOptionClasses
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
    public partial class MultiDefectViewerDisplayOption
    {

        /// <summary>
        /// ApplyDisplaySettings
        /// </summary>
        public void ApplyDisplaySettings()
        {
            #region Variable Declarations
            WinButton uIApplyButton = this.UIDisplayOptionsWindow.UIApplyWindow.UIApplyButton;
            #endregion

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(26, 20));
        }

        public void ApplyAndCloseDisplaySettings()
        {
            #region Variable Declarations
            WinButton uIApplyButton = this.UIDisplayOptionsWindow.UIApplyWindow.UIApplyButton;
            #endregion

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(26, 20)); 
            ClickOk();
        }
        /// <summary>
        /// ClickOk
        /// </summary>
        public void ClickOk()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIDisplayOptionsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(29, 5));
        }

        /// <summary>
        /// CloseMultiDefectViewer
        /// </summary>
        public void CloseMultiDefectViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(14, 5));
        }

        /// <summary>
        /// DefineGrayColormap - Use 'DefineGrayColormapParams' to pass parameters into this method.
        /// </summary>
        public void DefineGrayColormap(String colorMap, bool isInverted)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow4.UIItemComboBox;
            WinCheckBox uIInvertCheckBox = this.UIDisplayOptionsWindow.UIInvertWindow.UIInvertCheckBox;
            #endregion

            // Select 'Blue shade' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = colorMap;

            // Select 'Invert' check box
            uIInvertCheckBox.Checked = isInverted;
        }

        public void VerifyGrayColormap(String colorMap, bool isInverted)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow4.UIItemComboBox;
            WinCheckBox uIInvertCheckBox = this.UIDisplayOptionsWindow.UIInvertWindow.UIInvertCheckBox;
            #endregion

            // Select 'Blue shade' in 'Unknown Name' combo box
            Assert.AreEqual(colorMap, uIItemComboBox.SelectedItem);

            // Select 'Invert' check box
            Assert.AreEqual(isInverted, uIInvertCheckBox.Checked);
        }

        public virtual DefineGrayColormapParams DefineGrayColormapParams
        {
            get
            {
                if ((this.mDefineGrayColormapParams == null))
                {
                    this.mDefineGrayColormapParams = new DefineGrayColormapParams();
                }
                return this.mDefineGrayColormapParams;
            }
        }

        private DefineGrayColormapParams mDefineGrayColormapParams;

        /// <summary>
        /// DefineGrayThresholdedPixel - Use 'DefineGrayThresholdedPixelParams' to pass parameters into this method.
        /// </summary>
        public void DefineGrayThresholdedPixel(bool isThresholdedPixelsEnabled, bool isItensityLevelEnabled, bool isGrayBinsEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIThresholdedpixelsCheckBox = this.UIDisplayOptionsWindow.UIThresholdedpixelsWindow.UIThresholdedpixelsCheckBox;
            WinCheckBox uIIntensitylevelsCheckBox = this.UIDisplayOptionsWindow.UIIntensitylevelsWindow.UIIntensitylevelsCheckBox;
            WinCheckBox uIGraybinsCheckBox = this.UIDisplayOptionsWindow.UIGraybinsWindow.UIGraybinsCheckBox;
            #endregion

            // Select 'Thresholded pixels' check box
            uIThresholdedpixelsCheckBox.Checked = isThresholdedPixelsEnabled;

            if (isThresholdedPixelsEnabled)
            {
                // Select 'Intensity levels' check box
                uIIntensitylevelsCheckBox.Checked = isItensityLevelEnabled;

                // Select 'Gray bins' check box
                uIGraybinsCheckBox.Checked = isGrayBinsEnabled;
            }
        }

        public void VerifyGrayThresholdedPixel(bool isThresholdedPixelsEnabled, bool isItensityLevelEnabled, bool isGrayBinsEnabled)
        {
            #region Variable Declarations
            WinCheckBox uIThresholdedpixelsCheckBox = this.UIDisplayOptionsWindow.UIThresholdedpixelsWindow.UIThresholdedpixelsCheckBox;
            WinCheckBox uIIntensitylevelsCheckBox = this.UIDisplayOptionsWindow.UIIntensitylevelsWindow.UIIntensitylevelsCheckBox;
            WinCheckBox uIGraybinsCheckBox = this.UIDisplayOptionsWindow.UIGraybinsWindow.UIGraybinsCheckBox;
            #endregion

            // Select 'Thresholded pixels' check box
            Assert.AreEqual(isThresholdedPixelsEnabled, uIThresholdedpixelsCheckBox.Checked);

            if (isThresholdedPixelsEnabled)
            {
                // Select 'Intensity levels' check box
                Assert.AreEqual(isItensityLevelEnabled, uIIntensitylevelsCheckBox.Checked);

                // Select 'Gray bins' check box
                Assert.AreEqual(isGrayBinsEnabled, uIGraybinsCheckBox.Checked);
            }
        }

        public virtual DefineGrayThresholdedPixelParams DefineGrayThresholdedPixelParams
        {
            get
            {
                if ((this.mDefineGrayThresholdedPixelParams == null))
                {
                    this.mDefineGrayThresholdedPixelParams = new DefineGrayThresholdedPixelParams();
                }
                return this.mDefineGrayThresholdedPixelParams;
            }
        }

        private DefineGrayThresholdedPixelParams mDefineGrayThresholdedPixelParams;

        /// <summary>
        /// DefineLayout - Use 'DefineLayoutParams' to pass parameters into this method.
        /// </summary>
        public void DefineLayout(String noOfRows, String noOfColumns)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDisplayOptionsWindow.UIItemWindow1.UIItemComboBox;
            #endregion

            // Select '2' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = noOfRows;

            // Select '3' in 'Unknown Name' combo box
            uIItemComboBox1.SelectedItem = noOfColumns;
        }

        public virtual DefineLayoutParams DefineLayoutParams
        {
            get
            {
                if ((this.mDefineLayoutParams == null))
                {
                    this.mDefineLayoutParams = new DefineLayoutParams();
                }
                return this.mDefineLayoutParams;
            }
        }

        private DefineLayoutParams mDefineLayoutParams;

        /// <summary>
        /// GraySubviewThresholdedPixels - Use 'GraySubviewThresholdedPixelsExpectedValues' to pass parameters into this method.
        /// </summary>
        public void GraySubviewThresholdedPixels()
        {
            #region Variable Declarations
            WinCheckBox uISubviewthresholdedpiCheckBox = this.UIDisplayOptionsWindow.UISubviewthresholdedpiWindow.UISubviewthresholdedpiCheckBox;
            #endregion

            // Verify that 'Subview thresholded pixels' check box's property 'Exists' equals 'True'
            Assert.AreEqual(this.GraySubviewThresholdedPixelsExpectedValues.UISubviewthresholdedpiCheckBoxExists, uISubviewthresholdedpiCheckBox.Exists);

            // Verify that 'Subview thresholded pixels' check box's property 'Checked' equals 'False'
            Assert.AreEqual(this.GraySubviewThresholdedPixelsExpectedValues.UISubviewthresholdedpiCheckBoxChecked, uISubviewthresholdedpiCheckBox.Checked);
        }

        public virtual GraySubviewThresholdedPixelsExpectedValues GraySubviewThresholdedPixelsExpectedValues
        {
            get
            {
                if ((this.mGraySubviewThresholdedPixelsExpectedValues == null))
                {
                    this.mGraySubviewThresholdedPixelsExpectedValues = new GraySubviewThresholdedPixelsExpectedValues();
                }
                return this.mGraySubviewThresholdedPixelsExpectedValues;
            }
        }

        private GraySubviewThresholdedPixelsExpectedValues mGraySubviewThresholdedPixelsExpectedValues;

        /// <summary>
        /// LoadDisplayOptionsWindow
        /// </summary>
        public void LoadDisplayOptionsWindow()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerClient.UIItemWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(66, 14));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(36, 12));

            // Click 'Unknown Name' window
           // Mouse.Click(uIItemWindow, new Point(64, 10));

            // Click 'Desktop' client
            //Mouse.Click(uIDesktopClient, new Point(37, 13));
        }

        /// <summary>
        /// LoadMultiDefectViewer
        /// </summary>
        public void LoadMultiDefectViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            WinTitleBar uIMultiDefectViewerTitleBar = this.UISmartViewConsole4CamWindow.UIMultiDefectViewerWindow.UIMultiDefectViewerTitleBar;
            #endregion

            // Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(29, 580));

            // Double-Click 'Multi-Defect Viewer' title bar
            Mouse.DoubleClick(uIMultiDefectViewerTitleBar, new Point(397, 7));
        }

        /// <summary>
        /// ShowDefectBoxes - Use 'ShowDefectBoxesParams' to pass parameters into this method.
        /// </summary>
        public void ShowDefectBoxes(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIDefectboxesCheckBox = this.UIDisplayOptionsWindow.UIDefectboxesWindow.UIDefectboxesCheckBox;
            #endregion

            // Select 'Defect boxes' check box
            uIDefectboxesCheckBox.Checked = isShown;
        }

        public void VerifyShowDefectBoxes(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIDefectboxesCheckBox = this.UIDisplayOptionsWindow.UIDefectboxesWindow.UIDefectboxesCheckBox;
            #endregion

            // Select 'Defect boxes' check box
            Assert.AreEqual(isShown, uIDefectboxesCheckBox.Checked);
        }

        public virtual ShowDefectBoxesParams ShowDefectBoxesParams
        {
            get
            {
                if ((this.mShowDefectBoxesParams == null))
                {
                    this.mShowDefectBoxesParams = new ShowDefectBoxesParams();
                }
                return this.mShowDefectBoxesParams;
            }
        }

        private ShowDefectBoxesParams mShowDefectBoxesParams;

        /// <summary>
        /// ShowDefectLabels - Use 'ShowDefectLabelsParams' to pass parameters into this method.
        /// </summary>
        public void ShowDefectLabels(bool isShown, String label)
        {
            #region Variable Declarations
            WinCheckBox uIDefectlabelsCheckBox = this.UIDisplayOptionsWindow.UIDefectlabelsWindow.UIDefectlabelsCheckBox;
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow2.UIItemComboBox;
            #endregion

            // Select 'Defect labels' check box
            uIDefectlabelsCheckBox.Checked = isShown;

            if (isShown)
            {
                // Select 'Defect No.' in 'Unknown Name' combo box
                uIItemComboBox.SelectedItem = label;
            }
        }

        public void VerifyShowDefectLabels(bool isShown, String label)
        {
            #region Variable Declarations
            WinCheckBox uIDefectlabelsCheckBox = this.UIDisplayOptionsWindow.UIDefectlabelsWindow.UIDefectlabelsCheckBox;
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow2.UIItemComboBox;
            #endregion

            // Select 'Defect labels' check box
            Assert.AreEqual(isShown, uIDefectlabelsCheckBox.Checked);

            if (isShown)
            {
                // Select 'Defect No.' in 'Unknown Name' combo box
                Assert.AreEqual(label, uIItemComboBox.SelectedItem);
            }
        }

        public virtual ShowDefectLabelsParams ShowDefectLabelsParams
        {
            get
            {
                if ((this.mShowDefectLabelsParams == null))
                {
                    this.mShowDefectLabelsParams = new ShowDefectLabelsParams();
                }
                return this.mShowDefectLabelsParams;
            }
        }

        private ShowDefectLabelsParams mShowDefectLabelsParams;

        /// <summary>
        /// ShowFeatures - Use 'ShowFeaturesParams' to pass parameters into this method.
        /// </summary>
        public void ShowFeatures(bool isFeaturesShown, String location)
        {
            #region Variable Declarations
            WinCheckBox uIFeaturesCheckBox = this.UIDisplayOptionsWindow.UIFeaturesWindow.UIFeaturesCheckBox;
            WinButton uIItemButton = this.UIDisplayOptionsWindow.UIItemWindow11.UIItemButton;
            WinButton uIItemButton1 = this.UIDisplayOptionsWindow.UIItemWindow3.UIItemButton;
            #endregion

            // Select 'Features' check box
            uIFeaturesCheckBox.Checked = isFeaturesShown;

            if (isFeaturesShown)
            {
                if (location.Equals("left"))
                {
                    // Click 'Unknown Name' button
                    Mouse.Click(uIItemButton, new Point(19, 8));
                }

                if (location.Equals("top"))
                {
                    // Click 'Unknown Name' button
                    Mouse.Click(uIItemButton1, new Point(25, 10));
                }
            }
        }

        public void VerifyShowFeatures(bool isFeaturesShown, String location)
        {
            #region Variable Declarations
            WinCheckBox uIFeaturesCheckBox = this.UIDisplayOptionsWindow.UIFeaturesWindow.UIFeaturesCheckBox;
            WinButton uIItemButton = this.UIDisplayOptionsWindow.UIItemWindow11.UIItemButton;
            WinButton uIItemButton1 = this.UIDisplayOptionsWindow.UIItemWindow3.UIItemButton;
            #endregion

            // Select 'Features' check box
            Assert.AreEqual(isFeaturesShown, uIFeaturesCheckBox.Checked);

            if (isFeaturesShown)
            {
                if (location.Equals("left"))
                {
                    // Click 'Unknown Name' button
                    Mouse.Click(uIItemButton, new Point(19, 8));
                }

                if (location.Equals("top"))
                {
                    // Click 'Unknown Name' button
                    Mouse.Click(uIItemButton1, new Point(25, 10));
                }
            }
        }

        public virtual ShowFeaturesParams ShowFeaturesParams
        {
            get
            {
                if ((this.mShowFeaturesParams == null))
                {
                    this.mShowFeaturesParams = new ShowFeaturesParams();
                }
                return this.mShowFeaturesParams;
            }
        }

        private ShowFeaturesParams mShowFeaturesParams;

        /// <summary>
        /// ShowHeader - Use 'ShowHeaderParams' to pass parameters into this method.
        /// </summary>
        public void ShowHeader(bool isShown, bool isClassShown, bool isViewShown)
        {
            #region Variable Declarations
            WinCheckBox uIHeaderCheckBox = this.UIDisplayOptionsWindow.UIHeaderWindow.UIHeaderCheckBox;
            WinCheckBox uIClassCheckBox = this.UIDisplayOptionsWindow.UIClassWindow.UIClassCheckBox;
            WinCheckBox uIViewCheckBox = this.UIDisplayOptionsWindow.UIViewWindow.UIViewCheckBox;
            #endregion

            // Select 'Header' check box
            uIHeaderCheckBox.Checked = isShown;

            if (isShown)
            {
                // Select 'Class' check box
                uIClassCheckBox.Checked = isClassShown;

                // Select 'View' check box
                uIViewCheckBox.Checked = isViewShown;
            }
        }

        public void VerifyShowHeader(bool isShown, bool isClassShown, bool isViewShown)
        {
            #region Variable Declarations
            WinCheckBox uIHeaderCheckBox = this.UIDisplayOptionsWindow.UIHeaderWindow.UIHeaderCheckBox;
            WinCheckBox uIClassCheckBox = this.UIDisplayOptionsWindow.UIClassWindow.UIClassCheckBox;
            WinCheckBox uIViewCheckBox = this.UIDisplayOptionsWindow.UIViewWindow.UIViewCheckBox;
            #endregion

            // Select 'Header' check box
            Assert.AreEqual(isShown, uIHeaderCheckBox.Checked);

            if (isShown)
            {
                // Select 'Class' check box
                Assert.AreEqual(isClassShown, uIClassCheckBox.Checked);

                // Select 'View' check box
                Assert.AreEqual(isViewShown,  uIViewCheckBox.Checked);
            }
        }
        public virtual ShowHeaderParams ShowHeaderParams
        {
            get
            {
                if ((this.mShowHeaderParams == null))
                {
                    this.mShowHeaderParams = new ShowHeaderParams();
                }
                return this.mShowHeaderParams;
            }
        }

        private ShowHeaderParams mShowHeaderParams;

        /// <summary>
        /// ShowImage - Use 'ShowImageParams' to pass parameters into this method.
        /// </summary>
        public void ShowImage(bool isImageShown, bool isCrosswebLocatorShown, bool isDownwebLocatorShown)
        {
            #region Variable Declaratns
            WinCheckBox uIImageCheckBox = this.UIDisplayOptionsWindow.UIImageWindow.UIImageCheckBox;
            WinCheckBox uICrossweblocatorCheckBox = this.UIDisplayOptionsWindow.UICrossweblocatorWindow.UICrossweblocatorCheckBox;
            WinCheckBox uIDownweblocatorCheckBox = this.UIDisplayOptionsWindow.UIDownweblocatorWindow.UIDownweblocatorCheckBox;
            #endregion

            // Select 'Image' check box
            uIImageCheckBox.Checked = isImageShown;

            if (isImageShown)
            {
                // Select 'Crossweb locator' check box
                uICrossweblocatorCheckBox.Checked = isCrosswebLocatorShown;

                // Select 'Downweb locator' check box
                uIDownweblocatorCheckBox.Checked = isDownwebLocatorShown;
            }
        }

        public void VerifyShowImage(bool isImageShown, bool isCrosswebLocatorShown, bool isDownwebLocatorShown)
        {
            #region Variable Declaratns
            WinCheckBox uIImageCheckBox = this.UIDisplayOptionsWindow.UIImageWindow.UIImageCheckBox;
            WinCheckBox uICrossweblocatorCheckBox = this.UIDisplayOptionsWindow.UICrossweblocatorWindow.UICrossweblocatorCheckBox;
            WinCheckBox uIDownweblocatorCheckBox = this.UIDisplayOptionsWindow.UIDownweblocatorWindow.UIDownweblocatorCheckBox;
            #endregion

            // Select 'Image' check box
            Assert.AreEqual(isImageShown, uIImageCheckBox.Checked);

            if (isImageShown)
            {
                // Select 'Crossweb locator' check box
                Assert.AreEqual(isCrosswebLocatorShown,uICrossweblocatorCheckBox.Checked );

                // Select 'Downweb locator' check box
                Assert.AreEqual(isDownwebLocatorShown,uIDownweblocatorCheckBox.Checked ) ;
            }
        }
        public virtual ShowImageParams ShowImageParams
        {
            get
            {
                if ((this.mShowImageParams == null))
                {
                    this.mShowImageParams = new ShowImageParams();
                }
                return this.mShowImageParams;
            }
        }

        private ShowImageParams mShowImageParams;

        /// <summary>
        /// ShowPointerToolbar - Use 'ShowPointerToolbarParams' to pass parameters into this method.
        /// </summary>
        public void ShowPointerToolbar(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIPointertoolbarCheckBox = this.UIDisplayOptionsWindow.UIPointertoolbarWindow.UIPointertoolbarCheckBox;
            #endregion

            // Select 'Pointer toolbar' check box
            uIPointertoolbarCheckBox.Checked = isShown;
        }

        public void VerifyShowPointerToolbar(bool isShown)
        {
            #region Variable Declarations
            WinCheckBox uIPointertoolbarCheckBox = this.UIDisplayOptionsWindow.UIPointertoolbarWindow.UIPointertoolbarCheckBox;
            #endregion

            // Select 'Pointer toolbar' check box
            Assert.AreEqual(isShown, uIPointertoolbarCheckBox.Checked);
        }

        public virtual ShowPointerToolbarParams ShowPointerToolbarParams
        {
            get
            {
                if ((this.mShowPointerToolbarParams == null))
                {
                    this.mShowPointerToolbarParams = new ShowPointerToolbarParams();
                }
                return this.mShowPointerToolbarParams;
            }
        }

        private ShowPointerToolbarParams mShowPointerToolbarParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DefineGrayColormap'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineGrayColormapParams
    {

        #region Fields
        /// <summary>
        /// Select 'Blue shade' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Blue shade";

        /// <summary>
        /// Select 'Invert' check box
        /// </summary>
        public bool UIInvertCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineGrayThresholdedPixel'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineGrayThresholdedPixelParams
    {

        #region Fields
        /// <summary>
        /// Select 'Thresholded pixels' check box
        /// </summary>
        public bool UIThresholdedpixelsCheckBoxChecked = true;

        /// <summary>
        /// Select 'Intensity levels' check box
        /// </summary>
        public bool UIIntensitylevelsCheckBoxChecked = true;

        /// <summary>
        /// Select 'Gray bins' check box
        /// </summary>
        public bool UIGraybinsCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineLayout'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineLayoutParams
    {

        #region Fields
        /// <summary>
        /// Select '2' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "2";

        /// <summary>
        /// Select '3' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem1 = "3";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'GraySubviewThresholdedPixels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GraySubviewThresholdedPixelsExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Subview thresholded pixels' check box's property 'Exists' equals 'True'
        /// </summary>
        public bool UISubviewthresholdedpiCheckBoxExists = true;

        /// <summary>
        /// Verify that 'Subview thresholded pixels' check box's property 'Checked' equals 'False'
        /// </summary>
        public bool UISubviewthresholdedpiCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowDefectBoxes'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowDefectBoxesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect boxes' check box
        /// </summary>
        public bool UIDefectboxesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowDefectLabels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowDefectLabelsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect labels' check box
        /// </summary>
        public bool UIDefectlabelsCheckBoxChecked = true;

        /// <summary>
        /// Select 'Defect No.' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Defect No.";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowFeatures'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowFeaturesParams
    {

        #region Fields
        /// <summary>
        /// Select 'Features' check box
        /// </summary>
        public bool UIFeaturesCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowHeader'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowHeaderParams
    {

        #region Fields
        /// <summary>
        /// Select 'Header' check box
        /// </summary>
        public bool UIHeaderCheckBoxChecked = true;

        /// <summary>
        /// Select 'Class' check box
        /// </summary>
        public bool UIClassCheckBoxChecked = true;

        /// <summary>
        /// Select 'View' check box
        /// </summary>
        public bool UIViewCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowImage'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowImageParams
    {

        #region Fields
        /// <summary>
        /// Select 'Image' check box
        /// </summary>
        public bool UIImageCheckBoxChecked = true;

        /// <summary>
        /// Select 'Crossweb locator' check box
        /// </summary>
        public bool UICrossweblocatorCheckBoxChecked = true;

        /// <summary>
        /// Select 'Downweb locator' check box
        /// </summary>
        public bool UIDownweblocatorCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ShowPointerToolbar'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ShowPointerToolbarParams
    {

        #region Fields
        /// <summary>
        /// Select 'Pointer toolbar' check box
        /// </summary>
        public bool UIPointertoolbarCheckBoxChecked = true;
        #endregion
}
}
