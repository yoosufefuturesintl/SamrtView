﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SVReview.UIModule.Review.LaneViewer.LVLiveModeSettingsClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public partial class LVLiveModeSettings
    {
        
        #region Properties
        public UISmartViewReview4CameWindow UISmartViewReview4CameWindow
        {
            get
            {
                if ((this.mUISmartViewReview4CameWindow == null))
                {
                    this.mUISmartViewReview4CameWindow = new UISmartViewReview4CameWindow();
                }
                return this.mUISmartViewReview4CameWindow;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UILiveModeSettingsWindow UILiveModeSettingsWindow
        {
            get
            {
                if ((this.mUILiveModeSettingsWindow == null))
                {
                    this.mUILiveModeSettingsWindow = new UILiveModeSettingsWindow();
                }
                return this.mUILiveModeSettingsWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartViewReview4CameWindow mUISmartViewReview4CameWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UILiveModeSettingsWindow mUILiveModeSettingsWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewReview4CameWindow : WinWindow
    {
        
        public UISmartViewReview4CameWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Review: 4 Camera, Station";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public UILaneViewerWindow UILaneViewerWindow
        {
            get
            {
                if ((this.mUILaneViewerWindow == null))
                {
                    this.mUILaneViewerWindow = new UILaneViewerWindow(this);
                }
                return this.mUILaneViewerWindow;
            }
        }
        #endregion
        
        #region Fields
        private UILaneViewerWindow mUILaneViewerWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UILaneViewerWindow : WinWindow
    {
        
        public UILaneViewerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public UILaneViewerClient UILaneViewerClient
        {
            get
            {
                if ((this.mUILaneViewerClient == null))
                {
                    this.mUILaneViewerClient = new UILaneViewerClient(this);
                }
                return this.mUILaneViewerClient;
            }
        }
        #endregion
        
        #region Fields
        private UILaneViewerClient mUILaneViewerClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UILaneViewerClient : WinClient
    {
        
        public UILaneViewerClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Lane Viewer";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new WinWindow(this);
                    #region Search Criteria
                    this.mUIItemWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6UserControlDC";
                    this.mUIItemWindow.WindowTitles.Add("SmartView Review: 4 Camera, Station");
                    #endregion
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
            #endregion
        }
        
        #region Properties
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
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DDFLT";
            #endregion
        }
        
        #region Properties
        public WinClient UIDesktopClient
        {
            get
            {
                if ((this.mUIDesktopClient == null))
                {
                    this.mUIDesktopClient = new WinClient(this);
                }
                return this.mUIDesktopClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIDesktopClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UILiveModeSettingsWindow : WinWindow
    {
        
        public UILiveModeSettingsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Live Mode Settings";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public UIStoponselectionWindow UIStoponselectionWindow
        {
            get
            {
                if ((this.mUIStoponselectionWindow == null))
                {
                    this.mUIStoponselectionWindow = new UIStoponselectionWindow(this);
                }
                return this.mUIStoponselectionWindow;
            }
        }
        
        public UIAutomaticallyresumelWindow UIAutomaticallyresumelWindow
        {
            get
            {
                if ((this.mUIAutomaticallyresumelWindow == null))
                {
                    this.mUIAutomaticallyresumelWindow = new UIAutomaticallyresumelWindow(this);
                }
                return this.mUIAutomaticallyresumelWindow;
            }
        }
        
        public UIText1Window UIText1Window
        {
            get
            {
                if ((this.mUIText1Window == null))
                {
                    this.mUIText1Window = new UIText1Window(this);
                }
                return this.mUIText1Window;
            }
        }
        
        public UIKeepvisibleWindow UIKeepvisibleWindow
        {
            get
            {
                if ((this.mUIKeepvisibleWindow == null))
                {
                    this.mUIKeepvisibleWindow = new UIKeepvisibleWindow(this);
                }
                return this.mUIKeepvisibleWindow;
            }
        }
        
        public UIText1Window1 UIText1Window1
        {
            get
            {
                if ((this.mUIText1Window1 == null))
                {
                    this.mUIText1Window1 = new UIText1Window1(this);
                }
                return this.mUIText1Window1;
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
        private UIStoponselectionWindow mUIStoponselectionWindow;
        
        private UIAutomaticallyresumelWindow mUIAutomaticallyresumelWindow;
        
        private UIText1Window mUIText1Window;
        
        private UIKeepvisibleWindow mUIKeepvisibleWindow;
        
        private UIText1Window1 mUIText1Window1;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIStoponselectionWindow : WinWindow
    {
        
        public UIStoponselectionWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIStoponselectionCheckBox
        {
            get
            {
                if ((this.mUIStoponselectionCheckBox == null))
                {
                    this.mUIStoponselectionCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIStoponselectionCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Stop on selection";
                    this.mUIStoponselectionCheckBox.WindowTitles.Add("Live Mode Settings");
                    #endregion
                }
                return this.mUIStoponselectionCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIStoponselectionCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIAutomaticallyresumelWindow : WinWindow
    {
        
        public UIAutomaticallyresumelWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIAutomaticallyresumelCheckBox
        {
            get
            {
                if ((this.mUIAutomaticallyresumelCheckBox == null))
                {
                    this.mUIAutomaticallyresumelCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIAutomaticallyresumelCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Automatically resume live mode";
                    this.mUIAutomaticallyresumelCheckBox.WindowTitles.Add("Live Mode Settings");
                    #endregion
                }
                return this.mUIAutomaticallyresumelCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIAutomaticallyresumelCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIText1Window : WinWindow
    {
        
        public UIText1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "7";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Live Mode Settings");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIKeepvisibleWindow : WinWindow
    {
        
        public UIKeepvisibleWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIKeepvisibleCheckBox
        {
            get
            {
                if ((this.mUIKeepvisibleCheckBox == null))
                {
                    this.mUIKeepvisibleCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIKeepvisibleCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Keep visible";
                    this.mUIKeepvisibleCheckBox.WindowTitles.Add("Live Mode Settings");
                    #endregion
                }
                return this.mUIKeepvisibleCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIKeepvisibleCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIText1Window1 : WinWindow
    {
        
        public UIText1Window1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "3";
            this.WindowTitles.Add("Live Mode Settings");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Live Mode Settings");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "10";
            this.WindowTitles.Add("Live Mode Settings");
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
                    this.mUIOKButton.WindowTitles.Add("Live Mode Settings");
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
}
