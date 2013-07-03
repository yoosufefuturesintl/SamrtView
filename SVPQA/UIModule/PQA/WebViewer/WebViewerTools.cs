namespace SVPQA.UIModule.PQA.WebViewer.WebViewerToolsClasses
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
    public partial class WebViewerTools
    {

        /// <summary>
        /// CloseDisplayOptionsWindow
        /// </summary>
        public void CloseDisplayOptionsWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIDisplayOptionsWindow.UIDisplayOptionsTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(4, 5));
        }

        /// <summary>
        /// DefineSideLabels - Use 'DefineSideLabelsParams' to pass parameters into this method.
        /// </summary>
        public void DefineSideLabels(int noOfViews)
        {
            #region Variable Declarations
            WinWindow uIViewportWindow = this.UISmartViewProductionQWindow.UICcm6015RC731Window.UICcm6015RC731Client.UIViewportWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            WinClient uISideLabelsClient = this.UISideLabelsWindow.UIItemWindow.UISideLabelsClient;
            WinEdit uIItemEdit = this.UISideLabelsWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton = this.UISideLabelsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'viewport' window
            Mouse.Click(uIViewportWindow, new Point(67, 13));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(46, 121));

            // Double-Click 'Side Labels' client
            Mouse.DoubleClick(uISideLabelsClient, new Point(112, 7));

            // Type 'V1-Left' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineSideLabelsParams.UIItemEditText;

            // Double-Click 'Side Labels' client
            Mouse.DoubleClick(uISideLabelsClient, new Point(209, 8));

            // Type 'V1-Right' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineSideLabelsParams.UIItemEditText1;



            if (noOfViews == 2)
            {
                // Double-Click 'Side Labels' client
                Mouse.DoubleClick(uISideLabelsClient, new Point(152, 23));

                // Type 'V2-Left' in 'Unknown Name' text box
                uIItemEdit.Text = this.DefineSideLabelsParams.UIItemEditText2;

                // Click 'Side Labels' client
                Mouse.Click(uISideLabelsClient, new Point(206, 20));

                // Click 'Side Labels' client
                Mouse.Click(uISideLabelsClient, new Point(206, 20));

                // Type 'V2-Right' in 'Unknown Name' text box
                uIItemEdit.Text = this.DefineSideLabelsParams.UIItemEditText3;

            }


            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(25, 15));
        }

        public virtual DefineSideLabelsParams DefineSideLabelsParams
        {
            get
            {
                if ((this.mDefineSideLabelsParams == null))
                {
                    this.mDefineSideLabelsParams = new DefineSideLabelsParams();
                }
                return this.mDefineSideLabelsParams;
            }
        }

        private DefineSideLabelsParams mDefineSideLabelsParams;

        /// <summary>
        /// LoadDisplayOptionsWindow
        /// </summary>
        public void LoadDisplayOptionsWindow()
        {
            #region Variable Declarations
            WinWindow uIViewportWindow = this.UISmartViewProductionQWindow.UICcm6015RC731Window.UICcm6015RC731Client.UIViewportWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            #endregion

            // Click 'viewport' window
            Mouse.Click(uIViewportWindow, new Point(64, 13));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(41, 14));
        }

        /// <summary>
        /// SelectSideLabelCheckBox - Use 'SelectSideLabelCheckBoxParams' to pass parameters into this method.
        /// </summary>
        public void SelectSideLabelCheckBox(bool isSelected)
        {
            #region Variable Declarations
            WinCheckBox uISidelabelsCheckBox = this.UIDisplayOptionsWindow.UISidelabelsWindow.UISidelabelsCheckBox;
            #endregion

            // Select 'Side labels' check box
            uISidelabelsCheckBox.Checked = isSelected;
        }

        public virtual SelectSideLabelCheckBoxParams SelectSideLabelCheckBoxParams
        {
            get
            {
                if ((this.mSelectSideLabelCheckBoxParams == null))
                {
                    this.mSelectSideLabelCheckBoxParams = new SelectSideLabelCheckBoxParams();
                }
                return this.mSelectSideLabelCheckBoxParams;
            }
        }

        private SelectSideLabelCheckBoxParams mSelectSideLabelCheckBoxParams;

        /// <summary>
        /// SideLabelView2Title
        /// </summary>
        public void SideLabelView2Title()
        {
            #region Variable Declarations
            WinClient uISideLabelsClient = this.UISideLabelsWindow.UIItemWindow.UISideLabelsClient;
            #endregion

            // Click 'Side Labels' client
            Mouse.Click(uISideLabelsClient, new Point(38, 24));
        }

        /// <summary>
        /// ShowDefectLabels - Use 'ShowDefectLabelsParams' to pass parameters into this method.
        /// </summary>
        public void ShowDefectLabels(bool isDisplayDefectLabels, String label)
        {
            #region Variable Declarations
            WinCheckBox uIDefectlabelsCheckBox = this.UIDisplayOptionsWindow.UIDefectlabelsWindow.UIDefectlabelsCheckBox;
            WinComboBox uIItemComboBox = this.UIDisplayOptionsWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Select 'Defect labels' check box
            uIDefectlabelsCheckBox.Checked = isDisplayDefectLabels;
            if(isDisplayDefectLabels){

                // Select 'Box Top' in 'Unknown Name' combo box
                uIItemComboBox.SelectedItem = label;
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
    }
    /// <summary>
    /// Parameters to be passed into 'DefineSideLabels'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineSideLabelsParams
    {

        #region Fields
        /// <summary>
        /// Type 'V1-Left' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "V1-Left";

        /// <summary>
        /// Type 'V1-Right' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "V1-Right";

        /// <summary>
        /// Type 'V2-Left' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "V2-Left";

        /// <summary>
        /// Type 'V2-Right' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText3 = "V2-Right";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectSideLabelCheckBox'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectSideLabelCheckBoxParams
    {

        #region Fields
        /// <summary>
        /// Select 'Side labels' check box
        /// </summary>
        public bool UISidelabelsCheckBoxChecked = true;
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
        /// Select 'Box Top' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Box Top";
        #endregion
}
}
