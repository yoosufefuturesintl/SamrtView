namespace SmartView.UIModule.Console.DefectRateViewer.DefectRateViewerClasses
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
    public partial class DefectRateViewer
    {

        /// <summary>
        /// CloseDefectRateViewer
        /// </summary>
        public void CloseDefectRateViewer()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(11, 12));
        }

        /// <summary>
        /// DisplayCrosswebInTable
        /// </summary>
        public void DisplayCrosswebInTable()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(276, 40));
        }

        /// <summary>
        /// DisplayCrosswebPlot
        /// </summary>
        public void DisplayCrosswebPlot()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(256, 37));
        }

        /// <summary>
        /// DisplayDefectSeverityInformation - Use 'DisplayDefectSeverityInformationParams' to pass parameters into this method.
        /// </summary>
        public void DisplayDefectSeverityInformation()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            WinComboBox uIItemComboBox = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(139, 16));

            // Select 'Severity' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.DisplayDefectSeverityInformationParams.UIItemComboBoxSelectedItem;
        }

        public virtual DisplayDefectSeverityInformationParams DisplayDefectSeverityInformationParams
        {
            get
            {
                if ((this.mDisplayDefectSeverityInformationParams == null))
                {
                    this.mDisplayDefectSeverityInformationParams = new DisplayDefectSeverityInformationParams();
                }
                return this.mDisplayDefectSeverityInformationParams;
            }
        }

        private DisplayDefectSeverityInformationParams mDisplayDefectSeverityInformationParams;

        /// <summary>
        /// DisplayDownwebPlot
        /// </summary>
        public void DisplayDownwebPlot()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(234, 39));
        }

        /// <summary>
        /// EnableQuery
        /// </summary>
        public void EnableQuery()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            #endregion

            // Click 'Unknown Name' window
            Mouse.Click(uIItemWindow, new Point(45, 14));
        }

        /// <summary>
        /// LoadDefectRateViewer
        /// </summary>
        public void LoadDefectRateViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole2CamWindow = this.UISmartViewConsole2CamWindow;
            #endregion

            // Click 'SmartView Console: 2 Camera View, Station' window
            Mouse.Click(uISmartViewConsole2CamWindow, new Point(35, 357));
        }

        /// <summary>
        /// DisplayDefectCountInformation - Use 'DisplayDefectCountInformationParams' to pass parameters into this method.
        /// </summary>
        public void DisplayDefectCountInformation()
        {
            #region Variable Declarations
            WinWindow uIItemWindow = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIDefectRateViewerClient.UIItemWindow;
            WinComboBox uIItemComboBox = this.UISmartViewConsole2CamWindow.UIDefectRateViewerWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Click 'Unknown Name' window
           // Mouse.Click(uIItemWindow, new Point(136, 11));

            // Select 'Defect count' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.DisplayDefectCountInformationParams.UIItemComboBoxSelectedItem;
        }

        public virtual DisplayDefectCountInformationParams DisplayDefectCountInformationParams
        {
            get
            {
                if ((this.mDisplayDefectCountInformationParams == null))
                {
                    this.mDisplayDefectCountInformationParams = new DisplayDefectCountInformationParams();
                }
                return this.mDisplayDefectCountInformationParams;
            }
        }

        private DisplayDefectCountInformationParams mDisplayDefectCountInformationParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DisplayDefectSeverityInformation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplayDefectSeverityInformationParams
    {

        #region Fields
        /// <summary>
        /// Select 'Severity' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Severity";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DisplayDefectCountInformation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DisplayDefectCountInformationParams
    {

        #region Fields
        /// <summary>
        /// Select 'Defect count' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Defect count";
        #endregion
}
}
