﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SVRecipe.UIModule.Recipe.Defect.ClassesDialogBoxClasses
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
    public partial class ClassesDialogBox
    {
        
        #region Properties
        public UISmartViewRecipeManagWindow UISmartViewRecipeManagWindow
        {
            get
            {
                if ((this.mUISmartViewRecipeManagWindow == null))
                {
                    this.mUISmartViewRecipeManagWindow = new UISmartViewRecipeManagWindow();
                }
                return this.mUISmartViewRecipeManagWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartViewRecipeManagWindow mUISmartViewRecipeManagWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewRecipeManagWindow : WinWindow
    {
        
        public UISmartViewRecipeManagWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Recipe Manager - test";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public UIClassesView1BasicWindow UIClassesView1BasicWindow
        {
            get
            {
                if ((this.mUIClassesView1BasicWindow == null))
                {
                    this.mUIClassesView1BasicWindow = new UIClassesView1BasicWindow(this);
                }
                return this.mUIClassesView1BasicWindow;
            }
        }
        
        public UIClassNotificationLowWindow UIClassNotificationLowWindow
        {
            get
            {
                if ((this.mUIClassNotificationLowWindow == null))
                {
                    this.mUIClassNotificationLowWindow = new UIClassNotificationLowWindow(this);
                }
                return this.mUIClassNotificationLowWindow;
            }
        }
        
        public UIRowDensityNotificatiWindow UIRowDensityNotificatiWindow
        {
            get
            {
                if ((this.mUIRowDensityNotificatiWindow == null))
                {
                    this.mUIRowDensityNotificatiWindow = new UIRowDensityNotificatiWindow(this);
                }
                return this.mUIRowDensityNotificatiWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIClassesView1BasicWindow mUIClassesView1BasicWindow;
        
        private UIClassNotificationLowWindow mUIClassNotificationLowWindow;
        
        private UIRowDensityNotificatiWindow mUIRowDensityNotificatiWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIClassesView1BasicWindow : WinWindow
    {
        
        public UIClassesView1BasicWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32768";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        
        public UIItemWindow4 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow4(this);
                }
                return this.mUIItemWindow4;
            }
        }
        
        public UIItemWindow5 UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow5(this);
                }
                return this.mUIItemWindow5;
            }
        }
        
        public UICloseWindow UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UICloseWindow(this);
                }
                return this.mUICloseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        
        private UIItemWindow4 mUIItemWindow4;
        
        private UIItemWindow5 mUIItemWindow5;
        
        private UICloseWindow mUICloseWindow;
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
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinClient UIClassesView1BasicClient
        {
            get
            {
                if ((this.mUIClassesView1BasicClient == null))
                {
                    this.mUIClassesView1BasicClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIClassesView1BasicClient.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIClassesView1BasicClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIClassesView1BasicClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIItemComboBox.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIItemComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIItemEdit.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIItemEdit.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIItemWindow4 : WinWindow
    {
        
        public UIItemWindow4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSFlexGridWndClass";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinClient UIClassesView1BasicClient
        {
            get
            {
                if ((this.mUIClassesView1BasicClient == null))
                {
                    this.mUIClassesView1BasicClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIClassesView1BasicClient.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIClassesView1BasicClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIClassesView1BasicClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow5 : WinWindow
    {
        
        public UIItemWindow5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSFlexGridWndClass";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinClient UIClassesView1BasicClient
        {
            get
            {
                if ((this.mUIClassesView1BasicClient == null))
                {
                    this.mUIClassesView1BasicClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIClassesView1BasicClient.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIClassesView1BasicClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIClassesView1BasicClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UICloseWindow : WinWindow
    {
        
        public UICloseWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUICloseButton.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIClassNotificationLowWindow : WinWindow
    {
        
        public UIClassNotificationLowWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public UIItemWindow6 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow6(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIApplyWindow UIApplyWindow
        {
            get
            {
                if ((this.mUIApplyWindow == null))
                {
                    this.mUIApplyWindow = new UIApplyWindow(this);
                }
                return this.mUIApplyWindow;
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
        private UIItemWindow6 mUIItemWindow;
        
        private UIApplyWindow mUIApplyWindow;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow6 : WinWindow
    {
        
        public UIItemWindow6(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIItemList.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIApplyWindow : WinWindow
    {
        
        public UIApplyWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinButton UIApplyButton
        {
            get
            {
                if ((this.mUIApplyButton == null))
                {
                    this.mUIApplyButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIApplyButton.SearchProperties[WinButton.PropertyNames.Name] = "Apply";
                    this.mUIApplyButton.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIApplyButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIApplyButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "4";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIOKButton.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIRowDensityNotificatiWindow : WinWindow
    {
        
        public UIRowDensityNotificatiWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public UIItemWindow7 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow7(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIApplyWindow1 UIApplyWindow
        {
            get
            {
                if ((this.mUIApplyWindow == null))
                {
                    this.mUIApplyWindow = new UIApplyWindow1(this);
                }
                return this.mUIApplyWindow;
            }
        }
        
        public UIOKWindow1 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow1(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow7 mUIItemWindow;
        
        private UIApplyWindow1 mUIApplyWindow;
        
        private UIOKWindow1 mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow7 : WinWindow
    {
        
        public UIItemWindow7(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIItemList.WindowTitles.Add("SmartView Recipe Manager - test");
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
    public class UIApplyWindow1 : WinWindow
    {
        
        public UIApplyWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
            #endregion
        }
        
        #region Properties
        public WinButton UIApplyButton
        {
            get
            {
                if ((this.mUIApplyButton == null))
                {
                    this.mUIApplyButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIApplyButton.SearchProperties[WinButton.PropertyNames.Name] = "Apply";
                    this.mUIApplyButton.WindowTitles.Add("SmartView Recipe Manager - test");
                    #endregion
                }
                return this.mUIApplyButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIApplyButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow1 : WinWindow
    {
        
        public UIOKWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "4";
            this.WindowTitles.Add("SmartView Recipe Manager - test");
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
                    this.mUIOKButton.WindowTitles.Add("SmartView Recipe Manager - test");
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