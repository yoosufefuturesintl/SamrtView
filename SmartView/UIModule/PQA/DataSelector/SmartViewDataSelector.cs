namespace SmartView.UIModule.PQA.DataSelector.SmartViewDataSelectorClasses
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
    using System.IO;


    public partial class UIMap
    {
    }
    public partial class SmartViewDataSelector
    {

        /// <summary>
        /// SearchInspectionDataByGivenLastPeriod - Use 'SearchInspectionDataByGivenLastPeriodParams' to pass parameters into this method.
        /// </summary>
        /// 
        public void CheckStartDateCheckBox(bool isChecked)
        {
            WinCheckBox uIStartdateCheckBox = this.UISmartViewDataSelectoWindow.UIStartdateWindow.UIStartdateClient.UIStartdateCheckBox;

            uIStartdateCheckBox.Checked = isChecked;
        }


        public void SearchInspectionDataByGivenLastPeriod(bool isSearchByStartDate)
        {
            #region Variable Declarations
            WinCheckBox uIStartdateCheckBox = this.UISmartViewDataSelectoWindow.UIStartdateWindow.UIStartdateClient.UIStartdateCheckBox;
            WinRadioButton uILastRadioButton = this.UISmartViewDataSelectoWindow.UILastWindow.UILastRadioButton;
            WinComboBox uICmbLastComboBox = this.UISmartViewDataSelectoWindow.UICmbLastWindow.UICmbLastComboBox;
            WinButton uISearchButton = this.UISmartViewDataSelectoWindow.UISearchWindow.UISearchButton;
            WinCheckBox uIMaxrecordsCheckBox = this.UISmartViewDataSelectoWindow.UIMaxrecordsWindow.UIMaxrecordsClient.UIMaxrecordsCheckBox;
            WinEdit uITxtMaxRecordsEdit = this.UISmartViewDataSelectoWindow.UIItem100Window.UITxtMaxRecordsEdit;
            WinListItem uITest11ListItem = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UITest11ListItem;
            WinButton uIOKButton = this.UISmartViewDataSelectoWindow.UIOKWindow.UIOKButton;
            #endregion

            
            // Select 'Start date' check box
            uIStartdateCheckBox.Checked = isSearchByStartDate;


            if (isSearchByStartDate)
            {

                // Click 'Last:' radio button
                Mouse.Click(uILastRadioButton, new Point(7, 13));

                // Select 'days' in 'cmbLast' combo box
                uICmbLastComboBox.SelectedItem = "weeks";

                if (uIMaxrecordsCheckBox.Checked)
                {
                    // Select 'Max records:' check box
                    uIMaxrecordsCheckBox.Checked = this.SearchInspectionDataByGivenLastPeriodParams.UIMaxrecordsCheckBoxChecked;
                }
            }

            // Type '1' in 'txtMaxRecords' text box
            // uITxtMaxRecordsEdit.Text = this.SearchInspectionDataByGivenLastPeriodParams.UITxtMaxRecordsEditText;

            // Click '&Search' button
            Mouse.Click(uISearchButton, new Point(67, 9));


            // Click 'test-11' list item
            Mouse.Click(uITest11ListItem, new Point(160, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(47, 11));
        }

        public virtual SearchInspectionDataByGivenLastPeriodParams SearchInspectionDataByGivenLastPeriodParams
        {
            get
            {
                if ((this.mSearchInspectionDataByGivenLastPeriodParams == null))
                {
                    this.mSearchInspectionDataByGivenLastPeriodParams = new SearchInspectionDataByGivenLastPeriodParams();
                }
                return this.mSearchInspectionDataByGivenLastPeriodParams;
            }
        }

        private SearchInspectionDataByGivenLastPeriodParams mSearchInspectionDataByGivenLastPeriodParams;

        /// <summary>
        /// ClickSearchButton
        /// </summary>
        public void ClickSearchButton()
        {
            #region Variable Declarations
            WinButton uISearchButton = this.UISmartViewDataSelectoWindow.UISearchWindow.UISearchButton;
            #endregion

            // Click '&Search' button
            Mouse.Click(uISearchButton, new Point(30, 13));
        }

        /// <summary>
        /// SearchByRecipe - Use 'SearchByRecipeParams' to pass parameters into this method.
        /// </summary>
        public void SearchByRecipeAndClickOk(String inspectionName)
        {
            #region Variable Declarations
            WinCheckBox uIRecipeCheckBox = this.UISmartViewDataSelectoWindow.UIRecipeWindow.UIRecipeClient.UIRecipeCheckBox;
            WinListItem uIItem1tListItem = this.UISmartViewDataSelectoWindow.UIListRecipeWindow.UIItem1tListItem;
            WinMenuItem uISetallMenuItem = this.UIItemWindow.UIContextMenu.UISetallMenuItem;
            WinButton uIOKButton = this.UISmartViewDataSelectoWindow.UIOKWindow.UIOKButton;
            #endregion

            // Select 'Recipe' check box
            if (!uIRecipeCheckBox.Checked)
            {

                uIRecipeCheckBox.Checked = this.SearchByRecipeParams.UIRecipeCheckBoxChecked;
            }


            // Right-Click '1t' list item
            //Mouse.Click(uIItem1tListItem, MouseButtons.Right, ModifierKeys.None, new Point(131, 5));

            // Click 'Set all' menu item
            //Mouse.Click(uISetallMenuItem, new Point(26, 10));

            DefineInspectionNameInSearchCriteria(inspectionName);

            ClickSearchButton();


            //SelectFirstRecordFromTheSearchList();

            Mouse.Click(uIOKButton);

        }

        /// <summary>
        /// SearchByRecipe - Use 'SearchByRecipeParams' to pass parameters into this method.
        /// </summary>
        public void SearchByInspectionName(String inspectionName)
        {
            #region Variable Declarations
            WinCheckBox uIRecipeCheckBox = this.UISmartViewDataSelectoWindow.UIRecipeWindow.UIRecipeClient.UIRecipeCheckBox;
            WinListItem uIItem1tListItem = this.UISmartViewDataSelectoWindow.UIListRecipeWindow.UIItem1tListItem;
            WinMenuItem uISetallMenuItem = this.UIItemWindow.UIContextMenu.UISetallMenuItem;
            WinButton uIOKButton = this.UISmartViewDataSelectoWindow.UIOKWindow.UIOKButton;
            #endregion

            // Select 'Recipe' check box
            if (!uIRecipeCheckBox.Checked)
            {

                uIRecipeCheckBox.Checked = this.SearchByRecipeParams.UIRecipeCheckBoxChecked;
            }


            // Right-Click '1t' list item
            Mouse.Click(uIItem1tListItem, MouseButtons.Right, ModifierKeys.None, new Point(131, 5));

            // Click 'Set all' menu item
            Mouse.Click(uISetallMenuItem, new Point(26, 10));

            DefineInspectionNameInSearchCriteria(inspectionName);

            ClickSearchButton();


            //SelectFirstRecordFromTheSearchList();

            Mouse.Click(uIOKButton);

        }

        public void SearchByRecipeAndSelelectDefinedRecored(String inspectionName)
        {
            #region Variable Declarations
            WinCheckBox uIRecipeCheckBox = this.UISmartViewDataSelectoWindow.UIRecipeWindow.UIRecipeClient.UIRecipeCheckBox;
            WinListItem uIItem1tListItem = this.UISmartViewDataSelectoWindow.UIListRecipeWindow.UIItem1tListItem;
            WinMenuItem uISetallMenuItem = this.UIItemWindow.UIContextMenu.UISetallMenuItem;
            WinButton uIOKButton = this.UISmartViewDataSelectoWindow.UIOKWindow.UIOKButton;
            #endregion

            // Select 'Recipe' check box
            if (!uIRecipeCheckBox.Checked)
            {

                uIRecipeCheckBox.Checked = this.SearchByRecipeParams.UIRecipeCheckBoxChecked;
            }


            // Right-Click '1t' list item
            Mouse.Click(uIItem1tListItem, MouseButtons.Right, ModifierKeys.None, new Point(131, 5));

            // Click 'Set all' menu item
            Mouse.Click(uISetallMenuItem, new Point(26, 10));

            DefineInspectionNameInSearchCriteria(inspectionName);

            ClickSearchButton();


            SortByName();
            
            //SelectFirstRecordFromTheSearchList();

            Mouse.Click(uIOKButton);

        }



        public virtual SearchByRecipeParams SearchByRecipeParams
        {
            get
            {
                if ((this.mSearchByRecipeParams == null))
                {
                    this.mSearchByRecipeParams = new SearchByRecipeParams();
                }
                return this.mSearchByRecipeParams;
            }
        }

        private SearchByRecipeParams mSearchByRecipeParams;

        /// <summary>
        /// SelectFirstRecordFromTheSearchList - Use 'SelectFirstRecordFromTheSearchListExpectedValues' to pass parameters into this method.
        /// </summary>
        public void SelectFirstRecordFromTheSearchList()
        {
            #region Variable Declarations
            WinWindow uIListvwDataWindow = this.UISmartViewDataSelectoWindow.UIPanelListWindow.UIListvwDataWindow;
            WinListItem uITest11ListItem = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UITest11ListItem;
            #endregion

            TextWriter TW = new StreamWriter("D:\\AAA.txt");
            WinList LIST = (WinList)uIListvwDataWindow.GetChildren()[1];
            //UITestControlCollection records = LIST.GetChildren();
            UITestControlCollection records = uIListvwDataWindow.GetChildren();

            for (int i = 0; i < records.Count; i++)
            {
                TW.WriteLine(i + "      " + records[i].ControlType);
            }
            TW.Close();

            Mouse.Click(records[0]);

        }

        public virtual SelectFirstRecordFromTheSearchListExpectedValues SelectFirstRecordFromTheSearchListExpectedValues
        {
            get
            {
                if ((this.mSelectFirstRecordFromTheSearchListExpectedValues == null))
                {
                    this.mSelectFirstRecordFromTheSearchListExpectedValues = new SelectFirstRecordFromTheSearchListExpectedValues();
                }
                return this.mSelectFirstRecordFromTheSearchListExpectedValues;
            }
        }

        private SelectFirstRecordFromTheSearchListExpectedValues mSelectFirstRecordFromTheSearchListExpectedValues;

        /// <summary>
        /// SelectItemInListUsingDownKey - Use 'SelectItemInListUsingDownKeyParams' to pass parameters into this method.
        /// </summary>
        public void SelectItemInListUsingDownKey()
        {
            #region Variable Declarations
            WinList uIListvwDataList = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UIListvwDataList;
            #endregion

            // Select 'SQATesting-1' in 'listvwData' list box
            uIListvwDataList.SelectedItemsAsString = this.SelectItemInListUsingDownKeyParams.UIListvwDataListSelectedItemsAsString;

            // Select 'Tuesday-13' in 'listvwData' list box
            uIListvwDataList.SelectedItemsAsString = this.SelectItemInListUsingDownKeyParams.UIListvwDataListSelectedItemsAsString1;
        }

        public virtual SelectItemInListUsingDownKeyParams SelectItemInListUsingDownKeyParams
        {
            get
            {
                if ((this.mSelectItemInListUsingDownKeyParams == null))
                {
                    this.mSelectItemInListUsingDownKeyParams = new SelectItemInListUsingDownKeyParams();
                }
                return this.mSelectItemInListUsingDownKeyParams;
            }
        }

        private SelectItemInListUsingDownKeyParams mSelectItemInListUsingDownKeyParams;

        /// <summary>
        /// SelectRecord - Use 'SelectRecordParams' to pass parameters into this method.
        /// </summary>
        public void SelectRecord()
        {
            #region Variable Declarations
            WinList uIListvwDataList = this.UISmartViewDataSelectoWindow.UIListvwDataWindow.UIListvwDataList;
            #endregion

            // Select '1-11' in 'listvwData' list box
            //uIListvwDataList.SelectedItemsAsString = this.SelectRecordParams.UIListvwDataListSelectedItemsAsString;
        }

        public virtual SelectRecordParams SelectRecordParams
        {
            get
            {
                if ((this.mSelectRecordParams == null))
                {
                    this.mSelectRecordParams = new SelectRecordParams();
                }
                return this.mSelectRecordParams;
            }
        }

        private SelectRecordParams mSelectRecordParams;

        /// <summary>
        /// SortByName
        /// </summary>
        public void SortByName()
        {
            #region Variable Declarations
            WinColumnHeader uINameColumnHeader = this.UISmartViewDataSelectoWindow.UIItemWindow.UIItemList.UINameColumnHeader;
            #endregion

            // Click 'Name' column header
            Mouse.Click(uINameColumnHeader, new Point(85, 10));
        }

        /// <summary>
        /// DefineInspectionNameInSearchCriteria - Use 'DefineInspectionNameInSearchCriteriaParams' to pass parameters into this method.
        /// </summary>
        public void DefineInspectionNameInSearchCriteria(String inspectionName)
        {
            #region Variable Declarations
            WinCheckBox uIInspectionCheckBox = this.UISmartViewDataSelectoWindow.UIInspectionWindow.UIInspectionClient.UIInspectionCheckBox;
            WinEdit uITextNameEdit = this.UISmartViewDataSelectoWindow.UITextNameWindow.UITextNameEdit;
            #endregion

            // Select 'Inspection' check box
            uIInspectionCheckBox.Checked = this.DefineInspectionNameInSearchCriteriaParams.UIInspectionCheckBoxChecked;

            // Type 'test*' in 'textName' text box
            uITextNameEdit.Text = inspectionName;
        }

        public virtual DefineInspectionNameInSearchCriteriaParams DefineInspectionNameInSearchCriteriaParams
        {
            get
            {
                if ((this.mDefineInspectionNameInSearchCriteriaParams == null))
                {
                    this.mDefineInspectionNameInSearchCriteriaParams = new DefineInspectionNameInSearchCriteriaParams();
                }
                return this.mDefineInspectionNameInSearchCriteriaParams;
            }
        }

        private DefineInspectionNameInSearchCriteriaParams mDefineInspectionNameInSearchCriteriaParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SearchInspectionDataByGivenLastPeriod'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SearchInspectionDataByGivenLastPeriodParams
    {

        #region Fields
        /// <summary>
        /// Select 'Start date' check box
        /// </summary>
        public bool UIStartdateCheckBoxChecked = true;

        /// <summary>
        /// Select 'days' in 'cmbLast' combo box
        /// </summary>
        public string UICmbLastComboBoxSelectedItem = "days";

        /// <summary>
        /// Select 'Max records:' check box
        /// </summary>
        public bool UIMaxrecordsCheckBoxChecked = true;

        /// <summary>
        /// Type '1' in 'txtMaxRecords' text box
        /// </summary>
        public string UITxtMaxRecordsEditText = "1";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SearchByRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SearchByRecipeParams
    {

        #region Fields
        /// <summary>
        /// Select 'Recipe' check box
        /// </summary>
        public bool UIRecipeCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectFirstRecordFromTheSearchList'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectFirstRecordFromTheSearchListExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'listvwData' window's property 'AlwaysOnTop' equals 'False'
        /// </summary>
        public bool UIListvwDataWindowAlwaysOnTop = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectItemInListUsingDownKey'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectItemInListUsingDownKeyParams
    {

        #region Fields
        /// <summary>
        /// Select 'SQATesting-1' in 'listvwData' list box
        /// </summary>
        public string UIListvwDataListSelectedItemsAsString = "SQATesting-1";

        /// <summary>
        /// Select 'Tuesday-13' in 'listvwData' list box
        /// </summary>
        public string UIListvwDataListSelectedItemsAsString1 = "Tuesday-13";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectRecord'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectRecordParams
    {

        #region Fields
        /// <summary>
        /// Select '1-11' in 'listvwData' list box
        /// </summary>
        public string UIListvwDataListSelectedItemsAsString = "1-11";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DefineInspectionNameInSearchCriteria'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineInspectionNameInSearchCriteriaParams
    {

        #region Fields
        /// <summary>
        /// Select 'Inspection' check box
        /// </summary>
        public bool UIInspectionCheckBoxChecked = true;

        /// <summary>
        /// Type 'test*' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "*171";
        #endregion
}
}
