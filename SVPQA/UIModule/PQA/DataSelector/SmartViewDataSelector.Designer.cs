﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SVPQA.UIModule.PQA.DataSelector.SmartViewDataSelectorClasses
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
    public partial class SmartViewDataSelector
    {
        
        #region Properties
        public UISmartViewDataSelectoWindow UISmartViewDataSelectoWindow
        {
            get
            {
                if ((this.mUISmartViewDataSelectoWindow == null))
                {
                    this.mUISmartViewDataSelectoWindow = new UISmartViewDataSelectoWindow();
                }
                return this.mUISmartViewDataSelectoWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UISelectDatabaseWindow UISelectDatabaseWindow
        {
            get
            {
                if ((this.mUISelectDatabaseWindow == null))
                {
                    this.mUISelectDatabaseWindow = new UISelectDatabaseWindow();
                }
                return this.mUISelectDatabaseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISmartViewDataSelectoWindow mUISmartViewDataSelectoWindow;
        
        private UIItemWindow1 mUIItemWindow;
        
        private UISelectDatabaseWindow mUISelectDatabaseWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISmartViewDataSelectoWindow : WinWindow
    {
        
        public UISmartViewDataSelectoWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SmartView Data Selector";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIStartdateWindow UIStartdateWindow
        {
            get
            {
                if ((this.mUIStartdateWindow == null))
                {
                    this.mUIStartdateWindow = new UIStartdateWindow(this);
                }
                return this.mUIStartdateWindow;
            }
        }
        
        public UILastWindow UILastWindow
        {
            get
            {
                if ((this.mUILastWindow == null))
                {
                    this.mUILastWindow = new UILastWindow(this);
                }
                return this.mUILastWindow;
            }
        }
        
        public UICmbLastWindow UICmbLastWindow
        {
            get
            {
                if ((this.mUICmbLastWindow == null))
                {
                    this.mUICmbLastWindow = new UICmbLastWindow(this);
                }
                return this.mUICmbLastWindow;
            }
        }
        
        public UISearchWindow UISearchWindow
        {
            get
            {
                if ((this.mUISearchWindow == null))
                {
                    this.mUISearchWindow = new UISearchWindow(this);
                }
                return this.mUISearchWindow;
            }
        }
        
        public UIMaxrecordsWindow UIMaxrecordsWindow
        {
            get
            {
                if ((this.mUIMaxrecordsWindow == null))
                {
                    this.mUIMaxrecordsWindow = new UIMaxrecordsWindow(this);
                }
                return this.mUIMaxrecordsWindow;
            }
        }
        
        public UIItem100Window UIItem100Window
        {
            get
            {
                if ((this.mUIItem100Window == null))
                {
                    this.mUIItem100Window = new UIItem100Window(this);
                }
                return this.mUIItem100Window;
            }
        }
        
        public UIListvwDataWindow UIListvwDataWindow
        {
            get
            {
                if ((this.mUIListvwDataWindow == null))
                {
                    this.mUIListvwDataWindow = new UIListvwDataWindow(this);
                }
                return this.mUIListvwDataWindow;
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
        
        public UIRecipeWindow UIRecipeWindow
        {
            get
            {
                if ((this.mUIRecipeWindow == null))
                {
                    this.mUIRecipeWindow = new UIRecipeWindow(this);
                }
                return this.mUIRecipeWindow;
            }
        }
        
        public UIListRecipeWindow UIListRecipeWindow
        {
            get
            {
                if ((this.mUIListRecipeWindow == null))
                {
                    this.mUIListRecipeWindow = new UIListRecipeWindow(this);
                }
                return this.mUIListRecipeWindow;
            }
        }
        
        public UIPanelListWindow UIPanelListWindow
        {
            get
            {
                if ((this.mUIPanelListWindow == null))
                {
                    this.mUIPanelListWindow = new UIPanelListWindow(this);
                }
                return this.mUIPanelListWindow;
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
        
        public UIInspectionWindow UIInspectionWindow
        {
            get
            {
                if ((this.mUIInspectionWindow == null))
                {
                    this.mUIInspectionWindow = new UIInspectionWindow(this);
                }
                return this.mUIInspectionWindow;
            }
        }
        
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
        
        public UIBtnSelectDatabaseWindow UIBtnSelectDatabaseWindow
        {
            get
            {
                if ((this.mUIBtnSelectDatabaseWindow == null))
                {
                    this.mUIBtnSelectDatabaseWindow = new UIBtnSelectDatabaseWindow(this);
                }
                return this.mUIBtnSelectDatabaseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIStartdateWindow mUIStartdateWindow;
        
        private UILastWindow mUILastWindow;
        
        private UICmbLastWindow mUICmbLastWindow;
        
        private UISearchWindow mUISearchWindow;
        
        private UIMaxrecordsWindow mUIMaxrecordsWindow;
        
        private UIItem100Window mUIItem100Window;
        
        private UIListvwDataWindow mUIListvwDataWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIRecipeWindow mUIRecipeWindow;
        
        private UIListRecipeWindow mUIListRecipeWindow;
        
        private UIPanelListWindow mUIPanelListWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UIInspectionWindow mUIInspectionWindow;
        
        private UITextNameWindow mUITextNameWindow;
        
        private UIBtnSelectDatabaseWindow mUIBtnSelectDatabaseWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIStartdateWindow : WinWindow
    {
        
        public UIStartdateWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "groupStartDate";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIStartdateClient UIStartdateClient
        {
            get
            {
                if ((this.mUIStartdateClient == null))
                {
                    this.mUIStartdateClient = new UIStartdateClient(this);
                }
                return this.mUIStartdateClient;
            }
        }
        #endregion
        
        #region Fields
        private UIStartdateClient mUIStartdateClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIStartdateClient : WinClient
    {
        
        public UIStartdateClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Start date";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIStartdateCheckBox
        {
            get
            {
                if ((this.mUIStartdateCheckBox == null))
                {
                    this.mUIStartdateCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIStartdateCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Start date";
                    this.mUIStartdateCheckBox.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIStartdateCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIStartdateCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UILastWindow : WinWindow
    {
        
        public UILastWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "radioLast";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UILastRadioButton
        {
            get
            {
                if ((this.mUILastRadioButton == null))
                {
                    this.mUILastRadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUILastRadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "Last:";
                    this.mUILastRadioButton.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUILastRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUILastRadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UICmbLastWindow : WinWindow
    {
        
        public UICmbLastWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbLast";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinComboBox UICmbLastComboBox
        {
            get
            {
                if ((this.mUICmbLastComboBox == null))
                {
                    this.mUICmbLastComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUICmbLastComboBox.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUICmbLastComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUICmbLastComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISearchWindow : WinWindow
    {
        
        public UISearchWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnSearch";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties[WinButton.PropertyNames.Name] = "Search";
                    this.mUISearchButton.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIMaxrecordsWindow : WinWindow
    {
        
        public UIMaxrecordsWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "groupMaxRecords";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIMaxrecordsClient UIMaxrecordsClient
        {
            get
            {
                if ((this.mUIMaxrecordsClient == null))
                {
                    this.mUIMaxrecordsClient = new UIMaxrecordsClient(this);
                }
                return this.mUIMaxrecordsClient;
            }
        }
        #endregion
        
        #region Fields
        private UIMaxrecordsClient mUIMaxrecordsClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIMaxrecordsClient : WinClient
    {
        
        public UIMaxrecordsClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Max records:";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIMaxrecordsCheckBox
        {
            get
            {
                if ((this.mUIMaxrecordsCheckBox == null))
                {
                    this.mUIMaxrecordsCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIMaxrecordsCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Max records:";
                    this.mUIMaxrecordsCheckBox.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIMaxrecordsCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIMaxrecordsCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItem100Window : WinWindow
    {
        
        public UIItem100Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtMaxRecords";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtMaxRecordsEdit
        {
            get
            {
                if ((this.mUITxtMaxRecordsEdit == null))
                {
                    this.mUITxtMaxRecordsEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtMaxRecordsEdit.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUITxtMaxRecordsEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtMaxRecordsEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIListvwDataWindow : WinWindow
    {
        
        public UIListvwDataWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "listvwData";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinListItem UITest11ListItem
        {
            get
            {
                if ((this.mUITest11ListItem == null))
                {
                    this.mUITest11ListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUITest11ListItem.SearchProperties[WinListItem.PropertyNames.Name] = "test-11";
                    this.mUITest11ListItem.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUITest11ListItem;
            }
        }
        
        public WinList UIListvwDataList
        {
            get
            {
                if ((this.mUIListvwDataList == null))
                {
                    this.mUIListvwDataList = new WinList(this);
                    #region Search Criteria
                    this.mUIListvwDataList.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIListvwDataList;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUITest11ListItem;
        
        private WinList mUIListvwDataList;
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
            this.WindowTitles.Add("SmartView Data Selector");
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
                    this.mUIOKButton.WindowTitles.Add("SmartView Data Selector");
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
    public class UIRecipeWindow : WinWindow
    {
        
        public UIRecipeWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "groupRecipe";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIRecipeClient UIRecipeClient
        {
            get
            {
                if ((this.mUIRecipeClient == null))
                {
                    this.mUIRecipeClient = new UIRecipeClient(this);
                }
                return this.mUIRecipeClient;
            }
        }
        #endregion
        
        #region Fields
        private UIRecipeClient mUIRecipeClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIRecipeClient : WinClient
    {
        
        public UIRecipeClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Recipe";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIRecipeCheckBox
        {
            get
            {
                if ((this.mUIRecipeCheckBox == null))
                {
                    this.mUIRecipeCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIRecipeCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Recipe";
                    this.mUIRecipeCheckBox.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIRecipeCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIRecipeCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIListRecipeWindow : WinWindow
    {
        
        public UIListRecipeWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "listRecipe";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinListItem UIItem1tListItem
        {
            get
            {
                if ((this.mUIItem1tListItem == null))
                {
                    this.mUIItem1tListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUIItem1tListItem.SearchProperties[WinListItem.PropertyNames.Name] = "1t";
                    this.mUIItem1tListItem.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIItem1tListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIItem1tListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIPanelListWindow : WinWindow
    {
        
        public UIPanelListWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "panelList";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinWindow UIListvwDataWindow
        {
            get
            {
                if ((this.mUIListvwDataWindow == null))
                {
                    this.mUIListvwDataWindow = new WinWindow(this);
                    #region Search Criteria
                    this.mUIListvwDataWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.SysListView32", PropertyExpressionOperator.Contains));
                    this.mUIListvwDataWindow.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIListvwDataWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUIListvwDataWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SysHeader32";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIItemList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new UIItemList(this);
                }
                return this.mUIItemList;
            }
        }
        #endregion
        
        #region Fields
        private UIItemList mUIItemList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemList : WinList
    {
        
        public UIItemList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinColumnHeader UINameColumnHeader
        {
            get
            {
                if ((this.mUINameColumnHeader == null))
                {
                    this.mUINameColumnHeader = new WinColumnHeader(this);
                    #region Search Criteria
                    this.mUINameColumnHeader.SearchProperties[WinControl.PropertyNames.Name] = "Name";
                    this.mUINameColumnHeader.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUINameColumnHeader;
            }
        }
        #endregion
        
        #region Fields
        private WinColumnHeader mUINameColumnHeader;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIInspectionWindow : WinWindow
    {
        
        public UIInspectionWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "groupInspection";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public UIInspectionClient UIInspectionClient
        {
            get
            {
                if ((this.mUIInspectionClient == null))
                {
                    this.mUIInspectionClient = new UIInspectionClient(this);
                }
                return this.mUIInspectionClient;
            }
        }
        #endregion
        
        #region Fields
        private UIInspectionClient mUIInspectionClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIInspectionClient : WinClient
    {
        
        public UIInspectionClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Inspection";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIInspectionCheckBox
        {
            get
            {
                if ((this.mUIInspectionCheckBox == null))
                {
                    this.mUIInspectionCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIInspectionCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Inspection";
                    this.mUIInspectionCheckBox.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUIInspectionCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIInspectionCheckBox;
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
            this.WindowTitles.Add("SmartView Data Selector");
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
                    this.mUITextNameEdit.WindowTitles.Add("SmartView Data Selector");
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
    public class UIBtnSelectDatabaseWindow : WinWindow
    {
        
        public UIBtnSelectDatabaseWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnSelectDatabase";
            this.WindowTitles.Add("SmartView Data Selector");
            #endregion
        }
        
        #region Properties
        public WinButton UICOGNEXDBButton
        {
            get
            {
                if ((this.mUICOGNEXDBButton == null))
                {
                    this.mUICOGNEXDBButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICOGNEXDBButton.SearchProperties[WinButton.PropertyNames.Name] = "COGNEXDB";
                    this.mUICOGNEXDBButton.WindowTitles.Add("SmartView Data Selector");
                    #endregion
                }
                return this.mUICOGNEXDBButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICOGNEXDBButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1()
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
        public WinMenuItem UISetallMenuItem
        {
            get
            {
                if ((this.mUISetallMenuItem == null))
                {
                    this.mUISetallMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISetallMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Set all";
                    #endregion
                }
                return this.mUISetallMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUISetallMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UISelectDatabaseWindow : WinWindow
    {
        
        public UISelectDatabaseWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Select Database";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Select Database");
            #endregion
        }
        
        #region Properties
        public UICboxServerWindow UICboxServerWindow
        {
            get
            {
                if ((this.mUICboxServerWindow == null))
                {
                    this.mUICboxServerWindow = new UICboxServerWindow(this);
                }
                return this.mUICboxServerWindow;
            }
        }
        
        public UICboxDatabaseWindow UICboxDatabaseWindow
        {
            get
            {
                if ((this.mUICboxDatabaseWindow == null))
                {
                    this.mUICboxDatabaseWindow = new UICboxDatabaseWindow(this);
                }
                return this.mUICboxDatabaseWindow;
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
        private UICboxServerWindow mUICboxServerWindow;
        
        private UICboxDatabaseWindow mUICboxDatabaseWindow;
        
        private UIOKWindow1 mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UICboxServerWindow : WinWindow
    {
        
        public UICboxServerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cboxServer";
            this.WindowTitles.Add("Select Database");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIServerComboBox
        {
            get
            {
                if ((this.mUIServerComboBox == null))
                {
                    this.mUIServerComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIServerComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Server:";
                    this.mUIServerComboBox.WindowTitles.Add("Select Database");
                    #endregion
                }
                return this.mUIServerComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIServerComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UICboxDatabaseWindow : WinWindow
    {
        
        public UICboxDatabaseWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cboxDatabase";
            this.WindowTitles.Add("Select Database");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIDatabaseComboBox
        {
            get
            {
                if ((this.mUIDatabaseComboBox == null))
                {
                    this.mUIDatabaseComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIDatabaseComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Database:";
                    this.mUIDatabaseComboBox.WindowTitles.Add("Select Database");
                    #endregion
                }
                return this.mUIDatabaseComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIDatabaseComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIOKWindow1 : WinWindow
    {
        
        public UIOKWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonOK";
            this.WindowTitles.Add("Select Database");
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
                    this.mUIOKButton.WindowTitles.Add("Select Database");
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
