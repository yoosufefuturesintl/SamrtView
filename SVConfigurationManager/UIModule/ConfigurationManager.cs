namespace SVConfigurationManager.UIModule.ConfigurationManagerClasses
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
        public void LoadCameraStatusWindow()
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
                                    
        }



        /// <summary>
        /// CreateStandardSingleViewArchitecture - Use 'CreateStandardSingleViewArchitectureParams' to pass parameters into this method.
        /// </summary>
        public void LoadNewArchitectureWindow()
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
           // Mouse.Click(uIItemEdit, new Point(37, 2));          

            // Type 'automation' in 'Unknown Name' text box
           // uIItemEdit.Text = name;
                        
            // Double-Click 'OK' button
           // Mouse.Click(uIOKButton, new Point(47, 13));

            //AssignCameraToView();
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

        /// <summary>
        /// camass
        /// </summary>
        

        /// <summary>
        /// AssignCameraToSingleView
        /// </summary>
        public void AssignCameraToSingleView()
        {
            #region Variable Declarations
            WinClient uICameraStatusandAssigClient = this.UISmartViewConfiguratiWindow.UICameraStatusandAssigWindow.UIItemWindow.UICameraStatusandAssigClient;
            WinTreeItem uICamera1cam1TreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UICamera1cam1TreeItem;
            WinTreeItem uICamera2cam2TreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UICamera2cam2TreeItem;
            WinTreeItem uICamera3cam3TreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UICamera3cam3TreeItem;
            WinTreeItem uICamera4cam4TreeItem = this.UISmartViewConfiguratiWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem.UICamera4cam4TreeItem;
            #endregion

            // Move 'Camera Status and Assignment' client from (151, 26) to 'Line' -> 'Station' -> 'View 1' -> 'Camera 1 (cam1)' tree item (78, 12)
            uICamera1cam1TreeItem.EnsureClickable(new Point(78, 12));
            Mouse.StartDragging(uICameraStatusandAssigClient, new Point(151, 26));
            Mouse.StopDragging(uICamera1cam1TreeItem, new Point(78, 12));

        /*    // Move 'Camera Status and Assignment' client from (110, 42) to 'Line' -> 'Station' -> 'View 1' -> 'Camera 2 (cam2)' tree item (74, 8)
            uICamera2cam2TreeItem.EnsureClickable(new Point(74, 8));
            Mouse.StartDragging(uICameraStatusandAssigClient, new Point(110, 42));
            Mouse.StopDragging(uICamera2cam2TreeItem, new Point(74, 8));

            // Move 'Camera Status and Assignment' client from (47, 54) to 'Line' -> 'Station' -> 'View 1' -> 'Camera 3 (cam3)' tree item (61, 6)
            uICamera3cam3TreeItem.EnsureClickable(new Point(61, 6));
            Mouse.StartDragging(uICameraStatusandAssigClient, new Point(47, 54));
            Mouse.StopDragging(uICamera3cam3TreeItem, new Point(61, 6));

            // Click 'Camera Status and Assignment' client
            Mouse.Click(uICameraStatusandAssigClient, new Point(15, 69));

            // Move 'Camera Status and Assignment' client from (34, 69) to 'Line' -> 'Station' -> 'View 1' -> 'Camera 4 (cam4)' tree item (52, 6)
            uICamera4cam4TreeItem.EnsureClickable(new Point(52, 6));
            Mouse.StartDragging(uICameraStatusandAssigClient, new Point(34, 69));
            Mouse.StopDragging(uICamera4cam4TreeItem, new Point(52, 6));*/
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
