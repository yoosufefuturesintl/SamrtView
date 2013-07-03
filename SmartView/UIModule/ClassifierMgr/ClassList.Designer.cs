﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SmartView.UIModule.ClassifierMgr.ClassListClasses
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
    public partial class ClassList
    {
        
        #region Properties
        public UISmartLearnClassifierWindow UISmartLearnClassifierWindow
        {
            get
            {
                if ((this.mUISmartLearnClassifierWindow == null))
                {
                    this.mUISmartLearnClassifierWindow = new UISmartLearnClassifierWindow();
                }
                return this.mUISmartLearnClassifierWindow;
            }
        }
        
        public UIImportClassesWindow UIImportClassesWindow
        {
            get
            {
                if ((this.mUIImportClassesWindow == null))
                {
                    this.mUIImportClassesWindow = new UIImportClassesWindow();
                }
                return this.mUIImportClassesWindow;
            }
        }
        
        public UIImportClassWindow UIImportClassWindow
        {
            get
            {
                if ((this.mUIImportClassWindow == null))
                {
                    this.mUIImportClassWindow = new UIImportClassWindow();
                }
                return this.mUIImportClassWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartLearnClassifierWindow mUISmartLearnClassifierWindow;
        
        private UIImportClassesWindow mUIImportClassesWindow;
        
        private UIImportClassWindow mUIImportClassWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartLearnClassifierWindow : WinWindow
    {
        
        public UISmartLearnClassifierWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartLearn Classifier Manager";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("SmartLearn Classifier Manager");
            #endregion
        }
        
        #region Properties
        public UIBtnImportClassesWindow UIBtnImportClassesWindow
        {
            get
            {
                if ((this.mUIBtnImportClassesWindow == null))
                {
                    this.mUIBtnImportClassesWindow = new UIBtnImportClassesWindow(this);
                }
                return this.mUIBtnImportClassesWindow;
            }
        }
        
        public UITabsWindow UITabsWindow
        {
            get
            {
                if ((this.mUITabsWindow == null))
                {
                    this.mUITabsWindow = new UITabsWindow(this);
                }
                return this.mUITabsWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBtnImportClassesWindow mUIBtnImportClassesWindow;
        
        private UITabsWindow mUITabsWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIBtnImportClassesWindow : WinWindow
    {
        
        public UIBtnImportClassesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnImportClasses";
            this.WindowTitles.Add("SmartLearn Classifier Manager");
            #endregion
        }
        
        #region Properties
        public WinButton UIBtnImportClassesButton
        {
            get
            {
                if ((this.mUIBtnImportClassesButton == null))
                {
                    this.mUIBtnImportClassesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIBtnImportClassesButton.WindowTitles.Add("SmartLearn Classifier Manager");
                    #endregion
                }
                return this.mUIBtnImportClassesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIBtnImportClassesButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UITabsWindow : WinWindow
    {
        
        public UITabsWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "tabs";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("SmartLearn Classifier Manager");
            #endregion
        }
        
        #region Properties
        public WinTabPage UIClassListTabPage
        {
            get
            {
                if ((this.mUIClassListTabPage == null))
                {
                    this.mUIClassListTabPage = new WinTabPage(this);
                    #region Search Criteria
                    this.mUIClassListTabPage.SearchProperties[WinTabPage.PropertyNames.Name] = "Class List";
                    this.mUIClassListTabPage.WindowTitles.Add("SmartLearn Classifier Manager");
                    #endregion
                }
                return this.mUIClassListTabPage;
            }
        }
        #endregion
        
        #region Fields
        private WinTabPage mUIClassListTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIImportClassesWindow : WinWindow
    {
        
        public UIImportClassesWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Import Classes";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Import Classes");
            #endregion
        }
        
        #region Properties
        public UITextNameWindow UITextNameWindow
        {
            get
            {
                if ((this.mUITextNameWindow == null))
                {
                    this.mUITextNameWindow = new UITextNameWindow(this);
                }
                return this.mUITextNameWindow;
            }
        }
        
        public UIOpenWindow UIOpenWindow
        {
            get
            {
                if ((this.mUIOpenWindow == null))
                {
                    this.mUIOpenWindow = new UIOpenWindow(this);
                }
                return this.mUIOpenWindow;
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
        private UITextNameWindow mUITextNameWindow;
        
        private UIOpenWindow mUIOpenWindow;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UITextNameWindow : WinWindow
    {
        
        public UITextNameWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textName";
            this.WindowTitles.Add("Import Classes");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextNameEdit
        {
            get
            {
                if ((this.mUITextNameEdit == null))
                {
                    this.mUITextNameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextNameEdit.WindowTitles.Add("Import Classes");
                    #endregion
                }
                return this.mUITextNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextNameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOpenWindow : WinWindow
    {
        
        public UIOpenWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOK";
            this.WindowTitles.Add("Import Classes");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Import Classes");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOK";
            this.WindowTitles.Add("Import Classes");
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
                    this.mUIOKButton.WindowTitles.Add("Import Classes");
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
    public class UIImportClassWindow : WinWindow
    {
        
        public UIImportClassWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Import Class";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Import Class");
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
        #endregion
        
        #region Fields
        private UIYesWindow mUIYesWindow;
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
            this.WindowTitles.Add("Import Class");
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
                    this.mUIYesButton.WindowTitles.Add("Import Class");
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
}
