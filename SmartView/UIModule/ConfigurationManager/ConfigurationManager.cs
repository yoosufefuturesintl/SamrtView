namespace SmartView.UIModule.ConfigurationManager.ConfigurationManagerClasses
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
    public partial class ConfigurationManager
    {

        /// <summary>
        /// AssignCameraToView
        /// </summary>
        public void AssignCameraToView()
        {
            #region Variable Declarations
            WinMenuBar uIApplicationMenuBar = this.UISmartViewConfiguratiWindow.UIApplicationMenuBar;
            WinClient uICameraStatusandAssigClient = this.UISmartViewConfiguratiWindow.UICameraStatusandAssigWindow.UIItemWindow.UICameraStatusandAssigClient;
            WinTreeItem uICamera1cam1TreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UICamera1cam1TreeItem;
            #endregion

            FocusConfigurationManager();

            // Click 'Application' menu bar
            Mouse.Click( new Point(164, 37));

            // Click 'Camera Status and Assignment' client
            Mouse.Click(uICameraStatusandAssigClient, new Point(143, 28));

            // Move 'Camera Status and Assignment' client from (102, 23) to 'Line' -> 'Station' -> 'View 1' -> 'Camera 1 (cam1)' tree item (58, 11)
            uICamera1cam1TreeItem.EnsureClickable(new Point(58, 11));
            Mouse.StartDragging(uICameraStatusandAssigClient, new Point(102, 23));
            Mouse.StopDragging(uICamera1cam1TreeItem, new Point(58, 11));
        }



        /// <summary>
        /// CreateStandardSingleViewArchitecture - Use 'CreateStandardSingleViewArchitectureParams' to pass parameters into this method.
        /// </summary>
        public void CreateStandardSingleViewArchitecture(String name)
        {
            #region Variable Declarations
            WinMenuBar uIApplicationMenuBar = this.UISmartViewConfiguratiWindow.UIApplicationMenuBar;
            WinEdit uIItemEdit = this.UINewArchitectureWindow.UIItemWindow.UIItemEdit;
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow1.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow2.UIItemTree.UILineTreeItem.UIStationTreeItem;
            WinButton uIOKButton = this.UINewArchitectureWindow.UIOKWindow.UIOKButton;
            #endregion

            FocusConfigurationManager();
            // Click 'Application' menu bar
            Mouse.Click(new Point(33, 44));

            // Click 'Unknown Name' text box
            Mouse.Click(uIItemEdit, new Point(37, 2));

            // Move 'Unknown Name' group from (38, 29) to 'Line' -> 'Station' tree item (14, 4)
            uIStationTreeItem.EnsureClickable(new Point(14, 4));
            Mouse.StartDragging(uIItemGroup, new Point(38, 29));
            Mouse.StopDragging(uIStationTreeItem, new Point(14, 4));

            // Type 'automation' in 'Unknown Name' text box
            uIItemEdit.Text = name;

            // Double-Click 'OK' button
            Mouse.Click(uIOKButton, new Point(47, 13));

            AssignCameraToView();
        }

        public virtual CreateStandardSingleViewArchitectureParams CreateStandardSingleViewArchitectureParams
        {
            get
            {
                if ((this.mCreateStandardSingleViewArchitectureParams == null))
                {
                    this.mCreateStandardSingleViewArchitectureParams = new CreateStandardSingleViewArchitectureParams();
                }
                return this.mCreateStandardSingleViewArchitectureParams;
            }
        }

        private CreateStandardSingleViewArchitectureParams mCreateStandardSingleViewArchitectureParams;

        /// <summary>
        /// LaunchConfigurationManager - Use 'LaunchConfigurationManagerParams' to pass parameters into this method.
        /// </summary>
        public void LaunchConfigurationManager()
        {

            // Launch '%SmartViewDir%\ConfigurationManager.exe'
            ApplicationUnderTest configurationManagerApplication = ApplicationUnderTest.Launch(this.LaunchConfigurationManagerParams.ExePath, this.LaunchConfigurationManagerParams.AlternateExePath);
        }

        public virtual LaunchConfigurationManagerParams LaunchConfigurationManagerParams
        {
            get
            {
                if ((this.mLaunchConfigurationManagerParams == null))
                {
                    this.mLaunchConfigurationManagerParams = new LaunchConfigurationManagerParams();
                }
                return this.mLaunchConfigurationManagerParams;
            }
        }

        private LaunchConfigurationManagerParams mLaunchConfigurationManagerParams;

        /// <summary>
        /// FocusConfigurationManager
        /// </summary>
        public void FocusConfigurationManager()
        {
            #region Variable Declarations
            WinTreeItem uIEncoderTreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIEncoderTreeItem;
            WinTree uIItemTree = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree;
            WinClient uIWorkspaceClient = this.UISmartViewConfiguratiWindow.UIItemWindow1.UIWorkspaceClient;
            #endregion

            // Click 'Line' -> 'Station' -> 'Encoder' tree item
            Mouse.Click(uIEncoderTreeItem, new Point(135, 14));

            // Click 'Unknown Name' tree
            Mouse.Click(uIItemTree, new Point(229, 435));

            // Click 'Workspace' client
            Mouse.Click(uIWorkspaceClient, new Point(411, 465));
}

        /// <summary>
        /// CloseConfigurationManager
        /// </summary>
        public void CloseConfigurationManager()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConfiguratiWindow.UISmartViewConfiguratiTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(22, 13));
}
    }
    /// <summary>
    /// Parameters to be passed into 'CreateStandardSingleViewArchitecture'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CreateStandardSingleViewArchitectureParams
    {

        #region Fields
        /// <summary>
        /// Type 'automation' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "automation";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchConfigurationManager'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LaunchConfigurationManagerParams
    {

        #region Fields
        /// <summary>
        /// Launch '%SmartViewDir%\ConfigurationManager.exe'
        /// </summary>
        public string ExePath = "D:\\SmartView\\ConfigurationManager.exe";

        /// <summary>
        /// Launch '%SmartViewDir%\ConfigurationManager.exe'
        /// </summary>
        public string AlternateExePath = "%SmartViewDir%\\ConfigurationManager.exe";
        #endregion
}
}
