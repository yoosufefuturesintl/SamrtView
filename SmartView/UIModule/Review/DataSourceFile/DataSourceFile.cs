namespace SmartView.UIModule.Review.DataSourceFile.DataSourceFileClasses
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
    using System.Threading;
    using System.Configuration;


    public partial class UIMap
    {
    }
    public partial class DataSourceFile
    {

        /// <summary>
        /// CheckSearchOnOpenCheckBox - Use 'CheckSearchOnOpenCheckBoxParams' to pass parameters into this method.
        /// </summary>
        public void CheckSearchOnOpenCheckBox()
        {
            #region Variable Declarations
            WinCheckBox uISearchonopenCheckBox = this.UISelectSourceFileSvsqWindow.UISearchonopenWindow.UISearchonopenCheckBox;
            #endregion

            // Select 'Search on open' check box
            uISearchonopenCheckBox.Checked = this.CheckSearchOnOpenCheckBoxParams.UISearchonopenCheckBoxChecked;
        }

        public virtual CheckSearchOnOpenCheckBoxParams CheckSearchOnOpenCheckBoxParams
        {
            get
            {
                if ((this.mCheckSearchOnOpenCheckBoxParams == null))
                {
                    this.mCheckSearchOnOpenCheckBoxParams = new CheckSearchOnOpenCheckBoxParams();
                }
                return this.mCheckSearchOnOpenCheckBoxParams;
            }
        }

        private CheckSearchOnOpenCheckBoxParams mCheckSearchOnOpenCheckBoxParams;

        /// <summary>
        /// ClickBrowseButtonInSelectSourceWindow
        /// </summary>
        public void ClickBrowseButtonInSelectSourceWindow()
        {
            #region Variable Declarations
            WinButton uIBrowseButton = this.UISelectServerWindow.UIBrowseWindow.UIBrowseButton;
            #endregion

            // Click 'Browse...' button
            Mouse.Click(uIBrowseButton, new Point(40, 10));
        }

        /// <summary>
        /// ClickCancelButton
        /// </summary>
        public void ClickCancelButton()
        {
            #region Variable Declarations
            WinButton uICancelButton = this.UISelectSourceFileSvsqWindow.UICancelWindow.UICancelButton;
            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(50, 13));
        }

        /// <summary>
        /// ClickNameColumnHeader
        /// </summary>
        public void ClickNameColumnHeader()
        {
            #region Variable Declarations
            WinClient uISelectSourceFileSvsqClient = this.UISelectSourceFileSvsqWindow.UIItemWindow4.UISelectSourceFileSvsqClient;
            #endregion

            // Click 'Select Source File - Svsqa-wes7' client
            Mouse.Click(uISelectSourceFileSvsqClient, new Point(68, 11));
        }

        /// <summary>
        /// ClickOkButtonInSelectSourceWindow
        /// </summary>
        public void ClickOkButtonInSelectSourceWindow()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISelectServerWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(42, 14));
        }

        /// <summary>
        /// ClickOpenButton
        /// </summary>
        public void ClickOpenButton()
        {
            #region Variable Declarations
            WinWindow uIItemWindow1 = this.UISelectSourceFileSvsqWindow.UIItemWindow3.UIItemWindow1;
            WinButton uIOpenButton = this.UISelectSourceFileSvsqWindow.UIOpenWindow.UIOpenButton;
            uIOpenButton.WindowTitles.Add("Select Source File - " + ConfigurationSettings.AppSettings["PC_Name"]);
            #endregion

            // Click 'Unknown Name' window
           // Mouse.Click(uIItemWindow1, new Point(50, 25));

            // Click 'Open' button
            Mouse.Click(uIOpenButton, new Point(49, 16));
        }

        /// <summary>
        /// ClickSearchButton
        /// </summary>
        public void ClickSearchButton()
        {
            #region Variable Declarations
            WinButton uISearchButton = this.UISelectSourceFileSvsqWindow.UISearchWindow.UISearchButton;
            #endregion

            // Click 'Search' button
            Mouse.Click(uISearchButton, new Point(57, 9));
        }

        /// <summary>
        /// ClickServerButton
        /// </summary>
        public void ClickServerButton()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UISelectSourceFileSvsqWindow.UIItemWindow2.UIItemButton;
            #endregion

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(9, 13));
        }

        /// <summary>
        /// DefineQuery - Use 'DefineQueryParams' to pass parameters into this method.
        /// </summary>
        public void DefineQuery()
        {
            #region Variable Declarations
            WinClient uIQueryClient = this.UISelectSourceFileSvsqWindow.UIItemWindow.UIQueryClient;
            WinEdit uIItemEdit = this.UISelectSourceFileSvsqWindow.UIItemWindow1.UIItemEdit;
            #endregion

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(69, 8));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(69, 21));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(71, 40));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(72, 55));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(72, 74));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(67, 84));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(67, 104));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(67, 71));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(67, 85));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(93, 9));

            // Type 'name' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText;

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(85, 23));

            // Type 'Architecture' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText1;

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(121, 34));

            // Type 'Station' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText2;

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(109, 55));

            // Type 'Recipe' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText3;

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(69, 73));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(143, 72));

            // Type '2012/09/04' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText4;

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(72, 87));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(157, 89));

            // Double-Click 'Query' client
            Mouse.DoubleClick(uIQueryClient, new Point(104, 90));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(71, 102));

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(99, 102));

            // Type 'm' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText5;

            // Type 'onth' in 'Unknown Name' text box
            Keyboard.SendKeys(uIItemEdit, this.DefineQueryParams.UIItemEditSendKeys, ModifierKeys.None);
        }

        public void DefineInsepcetionNameInSearchCriteria()
        {

            #region Variable Declarations
            WinClient uIQueryClient = this.UISelectSourceFileSvsqWindow.UIItemWindow.UIQueryClient;
            WinEdit uIItemEdit = this.UISelectSourceFileSvsqWindow.UIItemWindow1.UIItemEdit;
            #endregion

            // Click 'Query' client
            Mouse.Click(uIQueryClient, new Point(69, 8));

            // Type 'name' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineQueryParams.UIItemEditText;
        }

        public virtual DefineQueryParams DefineQueryParams
        {
            get
            {
                if ((this.mDefineQueryParams == null))
                {
                    this.mDefineQueryParams = new DefineQueryParams();
                }
                return this.mDefineQueryParams;
            }
        }

        private DefineQueryParams mDefineQueryParams;

        /// <summary>
        /// LoadSelectSourceFileWindow
        /// </summary>
        public void LoadSelectSourceFileWindow()
        {
            #region Variable Declarations
            WinWindow uISmartViewReview2CameWindow = this.UISmartViewReview2CameWindow;
            #endregion
           Thread.Sleep(10000);
            // Click 'SmartView Review: 2 Camera View, Station' window
            Mouse.Click(uISmartViewReview2CameWindow, new Point(19, 730));
            LoadSelectSourceDialogBox();
        }

        /// <summary>
        /// SelectPCFromSVDataStoredDropDown - Use 'SelectPCFromSVDataStoredDropDownParams' to pass parameters into this method.
        /// </summary>
        public void SelectPCFromSVDataStoredDropDown()
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UISelectServerWindow.UIItemWindow.UIItemComboBox;
            #endregion

            // Select 'SVSQA-WES7' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.SelectPCFromSVDataStoredDropDownParams.UIItemComboBoxSelectedItem;
        }

        public virtual SelectPCFromSVDataStoredDropDownParams SelectPCFromSVDataStoredDropDownParams
        {
            get
            {
                if ((this.mSelectPCFromSVDataStoredDropDownParams == null))
                {
                    this.mSelectPCFromSVDataStoredDropDownParams = new SelectPCFromSVDataStoredDropDownParams();
                }
                return this.mSelectPCFromSVDataStoredDropDownParams;
            }
        }

        private SelectPCFromSVDataStoredDropDownParams mSelectPCFromSVDataStoredDropDownParams;

        /// <summary>
        /// LoadSelectSourceDialogBox
        /// </summary>
        public void LoadSelectSourceDialogBox()
        {
            #region Variable Declarations
            WinWindow uISmartViewReviewWindow = this.UISmartViewReviewWindow;
            #endregion

            // Click 'SmartView Review' window
            Mouse.Click(uISmartViewReviewWindow, new Point(34, 713));
}
    }
    /// <summary>
    /// Parameters to be passed into 'CheckSearchOnOpenCheckBox'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CheckSearchOnOpenCheckBoxParams
    {

        #region Fields
        /// <summary>
        /// Select 'Search on open' check box
        /// </summary>
        public bool UISearchonopenCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineQuery'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineQueryParams
    {

        #region Fields
        /// <summary>
        /// Type 'name' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "name";

        /// <summary>
        /// Type 'Architecture' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "Architecture";

        /// <summary>
        /// Type 'Station' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "Station";

        /// <summary>
        /// Type 'Recipe' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText3 = "Recipe";

        /// <summary>
        /// Type '2012/09/04' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText4 = "2012/09/04";

        /// <summary>
        /// Type 'm' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText5 = "m";

        /// <summary>
        /// Type 'onth' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditSendKeys = "onth";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectPCFromSVDataStoredDropDown'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectPCFromSVDataStoredDropDownParams
    {

        #region Fields
        /// <summary>
        /// Select 'SVSQA-WES7' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "SVSQA-WES7";
        #endregion
}
}
