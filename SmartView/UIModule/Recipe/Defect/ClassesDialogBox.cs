namespace SmartView.UIModule.Recipe.Defect.ClassesDialogBoxClasses
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
    public partial class ClassesDialogBox
    {

        /// <summary>
        /// AssignOutput - Use 'AssignOutputParams' to pass parameters into this method.
        /// </summary>
        public void AssignOutput()
        {
            #region Variable Declarations
            WinClient uIClassesView1BasicClient = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow4.UIClassesView1BasicClient;
            WinList uIItemList = this.UISmartViewRecipeManagWindow.UIClassNotificationLowWindow.UIItemWindow.UIItemList;
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UIClassNotificationLowWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIClassNotificationLowWindow.UIOKWindow.UIOKButton;
            WinClient uIClassesView1BasicClient1 = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow5.UIClassesView1BasicClient;
            WinList uIItemList1 = this.UISmartViewRecipeManagWindow.UIRowDensityNotificatiWindow.UIItemWindow.UIItemList;
            WinButton uIApplyButton1 = this.UISmartViewRecipeManagWindow.UIRowDensityNotificatiWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton1 = this.UISmartViewRecipeManagWindow.UIRowDensityNotificatiWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Classes - View 1: Basic' client
            Mouse.Click(uIClassesView1BasicClient, new Point(176, 24));

            // Select 'Output 1,Output 5' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.AssignOutputParams.UIItemListSelectedItemsAsString;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(41, 17));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(40, 13));

            // Click 'Classes - View 1: Basic' client
            Mouse.Click(uIClassesView1BasicClient1, new Point(194, 76));

            // Select 'Output 1,Output 3,Output 4' in 'Unknown Name' list box
            uIItemList1.SelectedItemsAsString = this.AssignOutputParams.UIItemListSelectedItemsAsString1;

            // Click 'Apply' button
            Mouse.Click(uIApplyButton1, new Point(40, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(32, 10));
        }

        public virtual AssignOutputParams AssignOutputParams
        {
            get
            {
                if ((this.mAssignOutputParams == null))
                {
                    this.mAssignOutputParams = new AssignOutputParams();
                }
                return this.mAssignOutputParams;
            }
        }

        private AssignOutputParams mAssignOutputParams;

        /// <summary>
        /// CloseCLassDialogBox
        /// </summary>
        public void CloseCLassDialogBox()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UICloseWindow.UICloseButton;
            #endregion

            // Double-Click 'Close' button
            Mouse.DoubleClick(uICloseButton, new Point(48, 14));
        }

        /// <summary>
        /// LoadClassPropertiesBySelectingDesiredClassFromList
        /// </summary>
        public void LoadClassPropertiesBySelectingDesiredClassFromList()
        {
            #region Variable Declarations
            WinClient uIClassesView1BasicClient = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow.UIClassesView1BasicClient;
            #endregion

            // Double-Click 'Classes - View 1: Basic' client
            Mouse.DoubleClick(uIClassesView1BasicClient, new Point(63, 44));
        }

        /// <summary>
        /// SelectClassFromClassDropDownInCPTab - Use 'SelectClassFromClassDropDownInCPTabParams' to pass parameters into this method.
        /// </summary>
        public void SelectClassFromClassDropDownInCPTab(String defectClass)
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow1.UIItemComboBox;
            #endregion

            // Select 'Low Density Bright' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = defectClass;
        }

        public void VerifyClassPropertiesTabLoadedSuccessfully( )
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow3.UIItemEdit;
            WinClient uIClassesView1BasicClient = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow.UIClassesView1BasicClient;
            #endregion

            Assert.AreEqual(true, uIItemComboBox.Exists);
            Assert.AreEqual(true, uIItemEdit.Exists);
            Assert.AreEqual(true, uIItemEdit1.Exists);
        //    Assert.AreEqual(false, uIClassesView1BasicClient.Exists);
        }

        public virtual SelectClassFromClassDropDownInCPTabParams SelectClassFromClassDropDownInCPTabParams
        {
            get
            {
                if ((this.mSelectClassFromClassDropDownInCPTabParams == null))
                {
                    this.mSelectClassFromClassDropDownInCPTabParams = new SelectClassFromClassDropDownInCPTabParams();
                }
                return this.mSelectClassFromClassDropDownInCPTabParams;
            }
        }

        private SelectClassFromClassDropDownInCPTabParams mSelectClassFromClassDropDownInCPTabParams;

        /// <summary>
        /// VerifyClassSeverityAndDesription - Use 'VerifyClassSeverityAndDesriptionExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyClassSeverityAndDesription(String severity, String description)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIClassesView1BasicWindow.UIItemWindow3.UIItemEdit;
            #endregion

            // Verify that 'Unknown Name' text box's property 'Text' equals '10'
            Assert.AreEqual(severity, uIItemEdit.Text);

            // Verify that 'Unknown Name' text box's property 'Text' equals 'Sparsely thresholded defect that is mostly bright'
            Assert.AreEqual(description, uIItemEdit1.Text);
        }

        public virtual VerifyClassSeverityAndDesriptionExpectedValues VerifyClassSeverityAndDesriptionExpectedValues
        {
            get
            {
                if ((this.mVerifyClassSeverityAndDesriptionExpectedValues == null))
                {
                    this.mVerifyClassSeverityAndDesriptionExpectedValues = new VerifyClassSeverityAndDesriptionExpectedValues();
                }
                return this.mVerifyClassSeverityAndDesriptionExpectedValues;
            }
        }

        private VerifyClassSeverityAndDesriptionExpectedValues mVerifyClassSeverityAndDesriptionExpectedValues;
    }
    /// <summary>
    /// Parameters to be passed into 'AssignOutput'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class AssignOutputParams
    {

        #region Fields
        /// <summary>
        /// Select 'Output 1,Output 5' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "Output 1,Output 5";

        /// <summary>
        /// Select 'Output 1,Output 3,Output 4' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString1 = "Output 1,Output 3,Output 4";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectClassFromClassDropDownInCPTab'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectClassFromClassDropDownInCPTabParams
    {

        #region Fields
        /// <summary>
        /// Select 'Low Density Bright' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Low Density Bright";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyClassSeverityAndDesription'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyClassSeverityAndDesriptionExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Unknown Name' text box's property 'Text' equals '10'
        /// </summary>
        public string UIItemEditText = "10";

        /// <summary>
        /// Verify that 'Unknown Name' text box's property 'Text' equals 'Sparsely thresholded defect that is mostly bright'
        /// </summary>
        public string UIItemEditText1 = "Sparsely thresholded defect that is mostly bright";
        #endregion
}
}
