namespace SmartView.UIModule.Console.SVConsoleClasses
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
    public partial class SVConsole
    {

        /// <summary>
        /// LaunchConsole - Use 'LaunchConsoleParams' to pass parameters into this method.
        /// </summary>
        public void LaunchConsole()
        {

            // Launch '%SmartViewDir%\Console.exe'
            ApplicationUnderTest consoleApplication = ApplicationUnderTest.Launch(this.LaunchConsoleParams.ExePath, this.LaunchConsoleParams.AlternateExePath);
            ConfirmOnlyOneConsoleCanRunMessage();
        }

        public virtual LaunchConsoleParams LaunchConsoleParams
        {
            get
            {
                if ((this.mLaunchConsoleParams == null))
                {
                    this.mLaunchConsoleParams = new LaunchConsoleParams();
                }
                return this.mLaunchConsoleParams;
            }
        }

        private LaunchConsoleParams mLaunchConsoleParams;

        /// <summary>
        /// SelectCamera
        /// </summary>
        public void SelectArchitecture(String architecture)
        {
            #region Variable Declarations
            WinClient uICamerastatusClient = this.UIArchitectureSelectioWindow.UIItemWindow.UICamerastatusClient;
            WinButton uISelectButton = this.UIArchitectureSelectioWindow.UISelectWindow.UISelectButton;
            #endregion

            SelectArchitectureFromArchitectureSelectionWindow(architecture);
            // Click 'Camera status' client
            Mouse.Click(uICamerastatusClient, new Point(44, 69));

            // Click 'Select' button
            Mouse.Click(uISelectButton, new Point(49, 9));
        }

        /// <summary>
        /// ClickStartOrStopButton
        /// </summary>
        public void ClickStartOrStopButton()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            #endregion

            // Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(64, 374));
        }

        /// <summary>
        /// GetInspectionName - Use 'GetInspectionNameExpectedValues' to pass parameters into this method.
        /// </summary>
        public void GetInspectionName()
        {
            #region Variable Declarations
            WinClient uISmartViewConsole4CamClient = this.UISmartViewConsole4CamWindow.UIItemWindow.UISmartViewConsole4CamClient;
            #endregion

            // Verify that 'SmartView Console: 4 Camera, Station' client's property 'ControlId' equals '0'
            Assert.AreEqual(this.GetInspectionNameExpectedValues.UISmartViewConsole4CamClientControlId, uISmartViewConsole4CamClient.ControlId);
        }

        public virtual GetInspectionNameExpectedValues GetInspectionNameExpectedValues
        {
            get
            {
                if ((this.mGetInspectionNameExpectedValues == null))
                {
                    this.mGetInspectionNameExpectedValues = new GetInspectionNameExpectedValues();
                }
                return this.mGetInspectionNameExpectedValues;
            }
        }

        private GetInspectionNameExpectedValues mGetInspectionNameExpectedValues;

        /// <summary>
        /// ConfirmOnlyOneConsoleCanRunMessage
        /// </summary>
        public void ConfirmOnlyOneConsoleCanRunMessage()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewConsoleWindow.UIOKWindow.UIOKButton;
            #endregion

            if (uIOKButton.Exists)
            {
                // Click 'OK' button
                Mouse.Click(uIOKButton, new Point(55, 14));
            }

        }

        /// <summary>
        /// SelectArchitectureFromArchitectureSelectionWindow - Use 'SelectArchitectureFromArchitectureSelectionWindowParams' to pass parameters into this method.
        /// </summary>
        public void SelectArchitectureFromArchitectureSelectionWindow(String architecture)
        {
            #region Variable Declarations
            WinList uIItemList = this.UIArchitectureSelectioWindow.UIItemWindow1.UIItemList;
            #endregion

            // Select '4 Camera' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = architecture;
        }

        public virtual SelectArchitectureFromArchitectureSelectionWindowParams SelectArchitectureFromArchitectureSelectionWindowParams
        {
            get
            {
                if ((this.mSelectArchitectureFromArchitectureSelectionWindowParams == null))
                {
                    this.mSelectArchitectureFromArchitectureSelectionWindowParams = new SelectArchitectureFromArchitectureSelectionWindowParams();
                }
                return this.mSelectArchitectureFromArchitectureSelectionWindowParams;
            }
        }

        private SelectArchitectureFromArchitectureSelectionWindowParams mSelectArchitectureFromArchitectureSelectionWindowParams;

        /// <summary>
        /// LoadLaneViewer
        /// </summary>
        public void LoadLaneViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            #endregion

            // Click 'SmartView Console: 4 Camera, Station' window
            Mouse.Click(uISmartViewConsole4CamWindow, new Point(31, 160));
        }

        /// <summary>
        /// CloseSystemWarningsWindow
        /// </summary>
        public void CloseSystemWarningsWindow()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISystemWarningWindow.UISystemWarningTitleBar.UICloseButton;
            #endregion

            if (uICloseButton.Exists)
            {
                // Click 'Close' button
                Mouse.Click(uICloseButton, new Point(6, 8));
            }
        }

        /// <summary>
        /// MaximizeConsoleWindow - Use 'MaximizeConsoleWindowParams' to pass parameters into this method.
        /// </summary>
        public void MaximizeConsoleWindow()
        {
            #region Variable Declarations
            WinWindow uISmartViewConsole4CamWindow = this.UISmartViewConsole4CamWindow;
            #endregion

            if (!uISmartViewConsole4CamWindow.Maximized)
            {
                // Maximize window 'SmartView Console: 4 Camera, Station'.
                uISmartViewConsole4CamWindow.Maximized = this.MaximizeConsoleWindowParams.UISmartViewConsole4CamWindowMaximized;
            }
        }

        public virtual MaximizeConsoleWindowParams MaximizeConsoleWindowParams
        {
            get
            {
                if ((this.mMaximizeConsoleWindowParams == null))
                {
                    this.mMaximizeConsoleWindowParams = new MaximizeConsoleWindowParams();
                }
                return this.mMaximizeConsoleWindowParams;
            }
        }

        private MaximizeConsoleWindowParams mMaximizeConsoleWindowParams;
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchConsole'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LaunchConsoleParams
    {

        #region Fields
        /// <summary>
        /// Launch '%SmartViewDir%\Console.exe'
        /// </summary>
        public string ExePath = "D:\\SmartView\\Console.exe";

        /// <summary>
        /// Launch '%SmartViewDir%\Console.exe'
        /// </summary>
        public string AlternateExePath = "%SmartViewDir%\\Console.exe";
        #endregion
    }
    public partial class SVConsole
    {

        /// <summary>
        /// CloseConsole
        /// </summary>
        public void CloseConsole()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole4CamWindow.UISmartViewConsole4CamTitleBar.UICloseButton;
            WinButton uIYesButton = this.UISmartViewConsoleWindow.UIYesWindow.UIYesButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(17, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(53, 16));
        }
    }
    /// <summary>
    /// Parameters to be passed into 'GetInspectionName'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GetInspectionNameExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'SmartView Console: 4 Camera, Station' client's property 'ControlId' equals '0'
        /// </summary>
        public int UISmartViewConsole4CamClientControlId = 0;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectArchitectureFromArchitectureSelectionWindow'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectArchitectureFromArchitectureSelectionWindowParams
    {

        #region Fields
        /// <summary>
        /// Select '4 Camera' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "4 Camera";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MaximizeConsoleWindow'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class MaximizeConsoleWindowParams
    {

        #region Fields
        /// <summary>
        /// Maximize window 'SmartView Console: 4 Camera, Station'.
        /// </summary>
        public bool UISmartViewConsole4CamWindowMaximized = true;
        #endregion
}
}
