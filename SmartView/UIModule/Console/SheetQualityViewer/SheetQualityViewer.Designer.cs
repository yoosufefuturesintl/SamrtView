﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SmartView.UIModule.Console.SheetQualityViewer.SheetQualityViewerClasses
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
    public partial class SheetQualityViewer
    {
        
        #region Properties
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
        
        public UISmartViewConsole2CamWindow UISmartViewConsole2CamWindow
        {
            get
            {
                if ((this.mUISmartViewConsole2CamWindow == null))
                {
                    this.mUISmartViewConsole2CamWindow = new UISmartViewConsole2CamWindow();
                }
                return this.mUISmartViewConsole2CamWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartViewConsole4CamWindow mUISmartViewConsole4CamWindow;
        
        private UISmartViewConsole2CamWindow mUISmartViewConsole2CamWindow;
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
        public UISheetQualityViewerWindow UISheetQualityViewerWindow
        {
            get
            {
                if ((this.mUISheetQualityViewerWindow == null))
                {
                    this.mUISheetQualityViewerWindow = new UISheetQualityViewerWindow(this);
                }
                return this.mUISheetQualityViewerWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISheetQualityViewerWindow mUISheetQualityViewerWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISheetQualityViewerWindow : WinWindow
    {
        
        public UISheetQualityViewerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("SmartView Console: 4 Camera, Station");
            #endregion
        }
        
        #region Properties
        public UISheetQualityViewerClient UISheetQualityViewerClient
        {
            get
            {
                if ((this.mUISheetQualityViewerClient == null))
                {
                    this.mUISheetQualityViewerClient = new UISheetQualityViewerClient(this);
                }
                return this.mUISheetQualityViewerClient;
            }
        }
        #endregion
        
        #region Fields
        private UISheetQualityViewerClient mUISheetQualityViewerClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISheetQualityViewerClient : WinClient
    {
        
        public UISheetQualityViewerClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Sheet Quality Viewer";
            this.WindowTitles.Add("SmartView Console: 4 Camera, Station");
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
                    this.mUIItemWindow.WindowTitles.Add("SmartView Console: 4 Camera, Station");
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
    public class UISmartViewConsole2CamWindow : WinWindow
    {
        
        public UISmartViewConsole2CamWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Console: 2 Camera View, Station";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("SmartView Console: 2 Camera View, Station");
            #endregion
        }
        
        #region Properties
        public UISheetQualityViewerViWindow UISheetQualityViewerViWindow
        {
            get
            {
                if ((this.mUISheetQualityViewerViWindow == null))
                {
                    this.mUISheetQualityViewerViWindow = new UISheetQualityViewerViWindow(this);
                }
                return this.mUISheetQualityViewerViWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISheetQualityViewerViWindow mUISheetQualityViewerViWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISheetQualityViewerViWindow : WinWindow
    {
        
        public UISheetQualityViewerViWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("SmartView Console: 2 Camera View, Station");
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
                    this.mUICloseButton.WindowTitles.Add("SmartView Console: 2 Camera View, Station");
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
}
