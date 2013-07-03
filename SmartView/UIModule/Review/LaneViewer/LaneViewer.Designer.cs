﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SmartView.UIModule.Review.LaneViewer.LaneViewerClasses
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
    public partial class LaneViewer
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
        #endregion
        
        #region Fields
        private UISmartViewReview4CameWindow mUISmartViewReview4CameWindow;
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
        
        public UILaneViewerWindow1 UILaneViewerWindow1
        {
            get
            {
                if ((this.mUILaneViewerWindow1 == null))
                {
                    this.mUILaneViewerWindow1 = new UILaneViewerWindow1(this);
                }
                return this.mUILaneViewerWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UILaneViewerWindow mUILaneViewerWindow;
        
        private UILaneViewerWindow1 mUILaneViewerWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UILaneViewerWindow : WinWindow
    {
        
        public UILaneViewerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32768";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UILaneViewerTitleBar
        {
            get
            {
                if ((this.mUILaneViewerTitleBar == null))
                {
                    this.mUILaneViewerTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUILaneViewerTitleBar.WindowTitles.Add("SmartView Review: 4 Camera, Station");
                    #endregion
                }
                return this.mUILaneViewerTitleBar;
            }
        }
        
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
        private WinTitleBar mUILaneViewerTitleBar;
        
        private UIItemWindow mUIItemWindow;
        
        private UILaneViewerClient mUILaneViewerClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSFlexGridWndClass";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinClient UILaneViewerClient
        {
            get
            {
                if ((this.mUILaneViewerClient == null))
                {
                    this.mUILaneViewerClient = new WinClient(this);
                    #region Search Criteria
                    this.mUILaneViewerClient.WindowTitles.Add("SmartView Review: 4 Camera, Station");
                    #endregion
                }
                return this.mUILaneViewerClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUILaneViewerClient;
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
    public class UILaneViewerWindow1 : WinWindow
    {
        
        public UILaneViewerWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow1 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSFlexGridWndClass";
            this.WindowTitles.Add("SmartView Review: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public WinClient UILaneViewerClient
        {
            get
            {
                if ((this.mUILaneViewerClient == null))
                {
                    this.mUILaneViewerClient = new WinClient(this);
                    #region Search Criteria
                    this.mUILaneViewerClient.WindowTitles.Add("SmartView Review: 4 Camera, Station");
                    #endregion
                }
                return this.mUILaneViewerClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUILaneViewerClient;
        #endregion
    }
}