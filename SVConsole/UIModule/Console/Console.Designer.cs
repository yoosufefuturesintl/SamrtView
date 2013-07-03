﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SVConsole.UIModule.Console.ConsoleClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Diagnostics;
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public partial class Console
    {
        
        /// <summary>
        /// CloseSmartViewConsole
        /// </summary>
        public void CloseSmartViewConsole(String app)
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewConsole4CamWindow.UISmartViewConsole4CamTitleBar.UICloseButton;
            WinButton uIYesButton = this.UISmartViewConsoleWindow.UIYesWindow.UIYesButton;
            #endregion
               
            Process[] appWindows = Process.GetProcessesByName(app);

            foreach (Process window in appWindows)
            {
                window.Kill();
            }
        
        }
        
        #region Properties
        public UIArchitectureSelectioWindow UIArchitectureSelectioWindow
        {
            get
            {
                if ((this.mUIArchitectureSelectioWindow == null))
                {
                    this.mUIArchitectureSelectioWindow = new UIArchitectureSelectioWindow();
                }
                return this.mUIArchitectureSelectioWindow;
            }
        }
        
        public UISmartViewConsole4CamWindow UISmartViewConsole4CamWindow
        {
            get
            {
                if ((this.mUISmartViewConsole4CamWindow == null))
                {
                    this.mUISmartViewConsole4CamWindow = new UISmartViewConsole4CamWindow();
                }
                return this.mUISmartViewConsole4CamWindow;
            }
        }
        
        public UISmartViewConsoleWindow UISmartViewConsoleWindow
        {
            get
            {
                if ((this.mUISmartViewConsoleWindow == null))
                {
                    this.mUISmartViewConsoleWindow = new UISmartViewConsoleWindow();
                }
                return this.mUISmartViewConsoleWindow;
            }
        }
        
        public UISystemWarningWindow UISystemWarningWindow
        {
            get
            {
                if ((this.mUISystemWarningWindow == null))
                {
                    this.mUISystemWarningWindow = new UISystemWarningWindow();
                }
                return this.mUISystemWarningWindow;
            }
        }
        
        public UIRunningapplicationsWindow UIRunningapplicationsWindow
        {
            get
            {
                if ((this.mUIRunningapplicationsWindow == null))
                {
                    this.mUIRunningapplicationsWindow = new UIRunningapplicationsWindow();
                }
                return this.mUIRunningapplicationsWindow;
            }
        }
        
        public UIItemWindow3 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow3();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIWindowsTaskManagerWindow UIWindowsTaskManagerWindow
        {
            get
            {
                if ((this.mUIWindowsTaskManagerWindow == null))
                {
                    this.mUIWindowsTaskManagerWindow = new UIWindowsTaskManagerWindow();
                }
                return this.mUIWindowsTaskManagerWindow;
            }
        }
        
        public UIWindowsTaskManagerWindow1 UIWindowsTaskManagerWindow1
        {
            get
            {
                if ((this.mUIWindowsTaskManagerWindow1 == null))
                {
                    this.mUIWindowsTaskManagerWindow1 = new UIWindowsTaskManagerWindow1();
                }
                return this.mUIWindowsTaskManagerWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIArchitectureSelectioWindow mUIArchitectureSelectioWindow;
        
        private UISmartViewConsole4CamWindow mUISmartViewConsole4CamWindow;
        
        private UISmartViewConsoleWindow mUISmartViewConsoleWindow;
        
        private UISystemWarningWindow mUISystemWarningWindow;
        
        private UIRunningapplicationsWindow mUIRunningapplicationsWindow;
        
        private UIItemWindow3 mUIItemWindow;
        
        private UIWindowsTaskManagerWindow mUIWindowsTaskManagerWindow;
        
        private UIWindowsTaskManagerWindow1 mUIWindowsTaskManagerWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIArchitectureSelectioWindow : WinWindow
    {
        
        public UIArchitectureSelectioWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Architecture Selection";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Architecture Selection");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UISelectWindow UISelectWindow
        {
            get
            {
                if ((this.mUISelectWindow == null))
                {
                    this.mUISelectWindow = new UISelectWindow(this);
                }
                return this.mUISelectWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UISelectWindow mUISelectWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Architecture Selection");
            #endregion
        }
        
        #region Properties
        public WinClient UICamerastatusClient
        {
            get
            {
                if ((this.mUICamerastatusClient == null))
                {
                    this.mUICamerastatusClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICamerastatusClient.WindowTitles.Add("Architecture Selection");
                    #endregion
                }
                return this.mUICamerastatusClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICamerastatusClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISelectWindow : WinWindow
    {
        
        public UISelectWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "14";
            this.WindowTitles.Add("Architecture Selection");
            #endregion
        }
        
        #region Properties
        public WinButton UISelectButton
        {
            get
            {
                if ((this.mUISelectButton == null))
                {
                    this.mUISelectButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISelectButton.SearchProperties[WinButton.PropertyNames.Name] = "Select";
                    this.mUISelectButton.WindowTitles.Add("Architecture Selection");
                    #endregion
                }
                return this.mUISelectButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISelectButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "8";
            this.WindowTitles.Add("Architecture Selection");
            #endregion
        }
        
        #region Properties
        public WinList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new WinList(this);
                    #region Search Criteria
                    this.mUIItemList.WindowTitles.Add("Architecture Selection");
                    #endregion
                }
                return this.mUIItemList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewConsole4CamWindow : WinWindow
    {
        
        public UISmartViewConsole4CamWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Console: 4 Camera, Station";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("SmartView Console: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public UISmartViewConsole4CamTitleBar UISmartViewConsole4CamTitleBar
        {
            get
            {
                if ((this.mUISmartViewConsole4CamTitleBar == null))
                {
                    this.mUISmartViewConsole4CamTitleBar = new UISmartViewConsole4CamTitleBar(this);
                }
                return this.mUISmartViewConsole4CamTitleBar;
            }
        }
        
        public UIItemWindow2 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow2(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartViewConsole4CamTitleBar mUISmartViewConsole4CamTitleBar;
        
        private UIItemWindow2 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewConsole4CamTitleBar : WinTitleBar
    {
        
        public UISmartViewConsole4CamTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("SmartView Console: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("SmartView Console: 4 Camera, Station");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "13";
            this.WindowTitles.Add("SmartView Console: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinClient UISmartViewConsole4CamClient
        {
            get
            {
                if ((this.mUISmartViewConsole4CamClient == null))
                {
                    this.mUISmartViewConsole4CamClient = new WinClient(this);
                    #region Search Criteria
                    this.mUISmartViewConsole4CamClient.WindowTitles.Add("SmartView Console: 4 Camera, Station");
                    #endregion
                }
                return this.mUISmartViewConsole4CamClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUISmartViewConsole4CamClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewConsoleWindow : WinWindow
    {
        
        public UISmartViewConsoleWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Console";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("SmartView Console");
            #endregion
        }
        
        #region Properties
        public UIYesWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow(this);
                }
                return this.mUIYesWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYesWindow mUIYesWindow;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIYesWindow : WinWindow
    {
        
        public UIYesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("SmartView Console");
            #endregion
        }
        
        #region Properties
        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("SmartView Console");
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIYesButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("SmartView Console");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("SmartView Console");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISystemWarningWindow : WinWindow
    {
        
        public UISystemWarningWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "System Warning";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("System Warning");
            #endregion
        }
        
        #region Properties
        public UISystemWarningTitleBar UISystemWarningTitleBar
        {
            get
            {
                if ((this.mUISystemWarningTitleBar == null))
                {
                    this.mUISystemWarningTitleBar = new UISystemWarningTitleBar(this);
                }
                return this.mUISystemWarningTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UISystemWarningTitleBar mUISystemWarningTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISystemWarningTitleBar : WinTitleBar
    {
        
        public UISystemWarningTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("System Warning");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("System Warning");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIRunningapplicationsWindow : WinWindow
    {
        
        public UIRunningapplicationsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Running applications";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSTaskSwWClass";
            this.WindowTitles.Add("Running applications");
            #endregion
        }
        
        #region Properties
        public UIRunningapplicationsClient UIRunningapplicationsClient
        {
            get
            {
                if ((this.mUIRunningapplicationsClient == null))
                {
                    this.mUIRunningapplicationsClient = new UIRunningapplicationsClient(this);
                }
                return this.mUIRunningapplicationsClient;
            }
        }
        #endregion
        
        #region Fields
        private UIRunningapplicationsClient mUIRunningapplicationsClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIRunningapplicationsClient : WinClient
    {
        
        public UIRunningapplicationsClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Running applications";
            this.WindowTitles.Add("Running applications");
            #endregion
        }
        
        #region Properties
        public WinToolBar UIRunningapplicationsToolBar
        {
            get
            {
                if ((this.mUIRunningapplicationsToolBar == null))
                {
                    this.mUIRunningapplicationsToolBar = new WinToolBar(this);
                    #region Search Criteria
                    this.mUIRunningapplicationsToolBar.SearchProperties[WinToolBar.PropertyNames.Name] = "Running applications";
                    this.mUIRunningapplicationsToolBar.WindowTitles.Add("Running applications");
                    #endregion
                }
                return this.mUIRunningapplicationsToolBar;
            }
        }
        #endregion
        
        #region Fields
        private WinToolBar mUIRunningapplicationsToolBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Context";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32768";
            #endregion
        }
        
        #region Properties
        public UIContextMenu UIContextMenu
        {
            get
            {
                if ((this.mUIContextMenu == null))
                {
                    this.mUIContextMenu = new UIContextMenu(this);
                }
                return this.mUIContextMenu;
            }
        }
        #endregion
        
        #region Fields
        private UIContextMenu mUIContextMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIContextMenu : WinMenu
    {
        
        public UIContextMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "Context";
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIStartTaskManagerMenuItem
        {
            get
            {
                if ((this.mUIStartTaskManagerMenuItem == null))
                {
                    this.mUIStartTaskManagerMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIStartTaskManagerMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Start Task Manager";
                    #endregion
                }
                return this.mUIStartTaskManagerMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIStartTaskManagerMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIWindowsTaskManagerWindow : WinWindow
    {
        
        public UIWindowsTaskManagerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Windows Task Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Windows Task Manager");
            #endregion
        }
        
        #region Properties
        public UIProcessesWindow UIProcessesWindow
        {
            get
            {
                if ((this.mUIProcessesWindow == null))
                {
                    this.mUIProcessesWindow = new UIProcessesWindow(this);
                }
                return this.mUIProcessesWindow;
            }
        }
        
        public UIEndProcessWindow UIEndProcessWindow
        {
            get
            {
                if ((this.mUIEndProcessWindow == null))
                {
                    this.mUIEndProcessWindow = new UIEndProcessWindow(this);
                }
                return this.mUIEndProcessWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIProcessesWindow mUIProcessesWindow;
        
        private UIEndProcessWindow mUIEndProcessWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIProcessesWindow : WinWindow
    {
        
        public UIProcessesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1009";
            this.WindowTitles.Add("Windows Task Manager");
            #endregion
        }
        
        #region Properties
        public WinList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new WinList(this);
                    #region Search Criteria
                    this.mUIItemList.WindowTitles.Add("Windows Task Manager");
                    #endregion
                }
                return this.mUIItemList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIEndProcessWindow : WinWindow
    {
        
        public UIEndProcessWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1010";
            this.WindowTitles.Add("Windows Task Manager");
            #endregion
        }
        
        #region Properties
        public WinButton UIEndProcessButton
        {
            get
            {
                if ((this.mUIEndProcessButton == null))
                {
                    this.mUIEndProcessButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEndProcessButton.SearchProperties[WinButton.PropertyNames.Name] = "End Process";
                    this.mUIEndProcessButton.WindowTitles.Add("Windows Task Manager");
                    #endregion
                }
                return this.mUIEndProcessButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEndProcessButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIWindowsTaskManagerWindow1 : WinWindow
    {
        
        public UIWindowsTaskManagerWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Windows Task Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.FilterProperties[WinWindow.PropertyNames.OrderOfInvocation] = "2";
            this.WindowTitles.Add("Windows Task Manager");
            #endregion
        }
        
        #region Properties
        public UIWindowsTaskManagerPane UIWindowsTaskManagerPane
        {
            get
            {
                if ((this.mUIWindowsTaskManagerPane == null))
                {
                    this.mUIWindowsTaskManagerPane = new UIWindowsTaskManagerPane(this);
                }
                return this.mUIWindowsTaskManagerPane;
            }
        }
        #endregion
        
        #region Fields
        private UIWindowsTaskManagerPane mUIWindowsTaskManagerPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIWindowsTaskManagerPane : WinPane
    {
        
        public UIWindowsTaskManagerPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Windows Task Manager";
            this.WindowTitles.Add("Windows Task Manager");
            #endregion
        }
        
        #region Properties
        public WinButton UIEndprocessButton
        {
            get
            {
                if ((this.mUIEndprocessButton == null))
                {
                    this.mUIEndprocessButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEndprocessButton.SearchProperties[WinButton.PropertyNames.Name] = "End process";
                    this.mUIEndprocessButton.WindowTitles.Add("Windows Task Manager");
                    #endregion
                }
                return this.mUIEndprocessButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEndprocessButton;
        #endregion
    }
}