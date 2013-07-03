namespace SVClassifierManager.UIModule.ClassifierManagerClasses
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
    public partial class ClassifierManager
    {

        /// <summary>
        /// CreateNewClassifier - Use 'CreateNewClassifierParams' to pass parameters into this method.
        /// </summary>
        public void CreateNewClassifier(String viewType, String classifierType, String engine, bool isUseDefaultParameters)
        {
            #region Variable Declarations
            WinMenuItem uINewCtrlNMenuItem = this.UISmartLearnClassifierWindow.UIMainFormMenuBar.UIFileMenuItem.UINewCtrlNMenuItem;
            WinRadioButton uISynchronizedRadioButton = this.UINewClassifierWindow.UISynchronizedWindow.UISynchronizedRadioButton;
            WinRadioButton uIMarkreaderRadioButton = this.UINewClassifierWindow.UIMarkreaderWindow.UIMarkreaderRadioButton;
            WinRadioButton uIStandardRadioButton = this.UINewClassifierWindow.UIStandardWindow.UIStandardRadioButton;
            WinRadioButton uISmartLearnmultistepRadioButton = this.UINewClassifierWindow.UISmartLearnmultistepWindow.UISmartLearnmultistepRadioButton;
            WinList uIListEnginesList = this.UINewClassifierWindow.UIListEnginesWindow.UIListEnginesList;
            WinCheckBox uIUsedefaultparametersCheckBox = this.UINewClassifierWindow.UIUsedefaultparametersWindow.UIUsedefaultparametersCheckBox;
            WinRadioButton uISmartViewstandardRadioButton = this.UINewClassifierWindow.UISmartViewstandardWindow.UISmartViewstandardRadioButton;
            WinButton uIOKButton = this.UINewClassifierWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'File' -> 'New...	Ctrl+N' menu item
            Mouse.Click(uINewCtrlNMenuItem, new Point(37, 11));

            if (viewType.Equals("Synchronized"))
            {
                // Select 'Synchronized' radio button
                uISynchronizedRadioButton.Selected = this.CreateNewClassifierParams.UISynchronizedRadioButtonSelected;
            }

            if (viewType.Equals("Mark reader"))
            {
                // Select 'Mark reader' radio button
                uIMarkreaderRadioButton.Selected = this.CreateNewClassifierParams.UIMarkreaderRadioButtonSelected;
            }

            if (viewType.Equals("Standard"))
            {
                // Select 'Standard' radio but//on
                uIStandardRadioButton.Selected = this.CreateNewClassifierParams.UIStandardRadioButtonSelected;
            }

            if (classifierType.Equals("SmartLearn"))
            {
                // Select 'SmartLearn (multi-step)' radio button
                uISmartLearnmultistepRadioButton.Selected = this.CreateNewClassifierParams.UISmartLearnmultistepRadioButtonSelected;

                // Select 'Decision tree' in 'listEngines' list box
                uIListEnginesList.SelectedItemsAsString = engine;

                if (isUseDefaultParameters)
                {
                    // Select 'Use default parameters' check box
                    uIUsedefaultparametersCheckBox.Checked = this.CreateNewClassifierParams.UIUsedefaultparametersCheckBoxChecked;
                }
            }

            if (classifierType.Equals("SmartView"))
            {
                // Select 'SmartView (standard)' radio button
                uISmartViewstandardRadioButton.Selected = this.CreateNewClassifierParams.UISmartViewstandardRadioButtonSelected;
            }

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(24, 15));
        }

        public virtual CreateNewClassifierParams CreateNewClassifierParams
        {
            get
            {
                if ((this.mCreateNewClassifierParams == null))
                {
                    this.mCreateNewClassifierParams = new CreateNewClassifierParams();
                }
                return this.mCreateNewClassifierParams;
            }
        }

        private CreateNewClassifierParams mCreateNewClassifierParams;

        /// <summary>
        /// LaunchClassifierManager - Use 'LaunchClassifierManagerParams' to pass parameters into this method.
        /// </summary>
        public void LaunchClassifierManager()
        {

            // Launch '%SmartViewDir%\ClassifierManager.exe'
            ApplicationUnderTest classifierManagerApplication = ApplicationUnderTest.Launch(this.LaunchClassifierManagerParams.ExePath, this.LaunchClassifierManagerParams.AlternateExePath);
        }

        public virtual LaunchClassifierManagerParams LaunchClassifierManagerParams
        {
            get
            {
                if ((this.mLaunchClassifierManagerParams == null))
                {
                    this.mLaunchClassifierManagerParams = new LaunchClassifierManagerParams();
                }
                return this.mLaunchClassifierManagerParams;
            }
        }

        private LaunchClassifierManagerParams mLaunchClassifierManagerParams;

        /// <summary>
        /// CloseClassifierManager
        /// </summary>
        public void CloseClassifierManager(String classifier)
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UISmartLearnClassifierWindow1.UISmartLearnClassifierTitleBar.UICloseButton;
            #endregion
            uICloseButton.WindowTitles.Add("SmartLearn Classifier Manager - [" + classifier + "]");
            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(19, 13));
        }

        /// <summary>
        /// DeleteClassfier - Use 'DeleteClassfierParams' to pass parameters into this method.
        /// </summary>
        public void DeleteClassfier(String classifierName)
        {
            #region Variable Declarations
            WinMenuItem uIDeleteMenuItem = this.UISmartLearnClassifierWindow.UIMainFormMenuBar.UIFileMenuItem.UIDeleteMenuItem;
            WinEdit uITextNameEdit = this.UIDeleteClassifierWindow.UITextNameWindow.UITextNameEdit;
            WinButton uIDeleteButton = this.UIDeleteClassifierWindow.UIDeleteWindow.UIDeleteButton;
            WinButton uIYesButton = this.UIDeleteClassifierWindow1.UIYesWindow.UIYesButton;
            #endregion

            // Click 'File' -> 'Delete...' menu item
            Mouse.Click(uIDeleteMenuItem, new Point(52, 14));

            // Type 'Automation' in 'textName' text box
            uITextNameEdit.Text = classifierName;

            // Click 'Delete' button
            Mouse.Click(uIDeleteButton, new Point(34, 15));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(22, 13));
        }

        public virtual DeleteClassfierParams DeleteClassfierParams
        {
            get
            {
                if ((this.mDeleteClassfierParams == null))
                {
                    this.mDeleteClassfierParams = new DeleteClassfierParams();
                }
                return this.mDeleteClassfierParams;
            }
        }

        private DeleteClassfierParams mDeleteClassfierParams;

        /// <summary>
        /// SaveClassifier - Use 'SaveClassifierParams' to pass parameters into this method.
        /// </summary>
        public void SaveClassifier(String name)
        {
            #region Variable Declarations
            WinMenuItem uISaveAsMenuItem = this.UISmartLearnClassifierWindow.UIMainFormMenuBar.UIFileMenuItem.UISaveAsMenuItem;
            WinEdit uITextNameEdit = this.UISaveClassifierWindow.UITextNameWindow.UITextNameEdit;
            WinButton uISaveButton = this.UISaveClassifierWindow.UISaveWindow.UISaveButton;
            #endregion

            // Click 'File' -> 'Save As...' menu item
            Mouse.Click(uISaveAsMenuItem, new Point(69, 12));

            // Type 'Automation' in 'textName' text box
            uITextNameEdit.Text = name;

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(45, 20));
        }

        public virtual SaveClassifierParams SaveClassifierParams
        {
            get
            {
                if ((this.mSaveClassifierParams == null))
                {
                    this.mSaveClassifierParams = new SaveClassifierParams();
                }
                return this.mSaveClassifierParams;
            }
        }

        private SaveClassifierParams mSaveClassifierParams;

        /// <summary>
        /// ClickOpenButtonInOpenClassifierWindow
        /// </summary>
        public void ClickOpenButtonInOpenClassifierWindow()
        {
            #region Variable Declarations
            WinButton uIOpenButton = this.UIOpenClassifierWindow.UIOpenWindow.UIOpenButton;
            #endregion

            // Click 'Open' button
            Mouse.Click(uIOpenButton, new Point(33, 6));
        }

        /// <summary>
        /// LoadOpenClassifierWindw
        /// </summary>
        public void LoadOpenClassifierWindw(String classifierName)
        {
            #region Variable Declarations
            WinMenuItem uIOpenCtrlOMenuItem = this.UISmartLearnClassifierWindow2.UIMainFormMenuBar.UIFileMenuItem.UIOpenCtrlOMenuItem;
            #endregion

            uIOpenCtrlOMenuItem.WindowTitles.Add("SmartLearn Classifier Manager - [" + classifierName + "]");

            // Click 'File' -> 'Open...	Ctrl+O' menu item
            Mouse.Click(uIOpenCtrlOMenuItem, new Point(31, 4));
        }

        /// <summary>
        /// VerifyClassifierListedInClassifierListOnOpenClassifierWindow - Use 'VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyClassifierListedInClassifierListOnOpenClassifierWindow(String classifierName)
        {
            #region Variable Declarations
            WinListItem uIATM7156ListItem = this.UIOpenClassifierWindow.UIListFilesWindow.UIATM7156ListItem;
            WinList uIListFilesList = this.UIOpenClassifierWindow.UIListFilesWindow.UIListFilesList;
            #endregion

            int noOfClassifiers = uIListFilesList.GetChildren().Count;

            for (int index = 0; index < noOfClassifiers; index++)
            {
                String name = uIListFilesList.GetChildren()[index].Name;

                if (name.Equals(classifierName))
                {
                    break;
                }

                if (index == noOfClassifiers - 2)
                {
                    Assert.Fail("Created classifier is not available in Open Classifier list. Classifier name is : " + classifierName);
                }


            }
            // Verify that 'ATM7156' list item's property 'Exists' equals 'True'
            //   Assert.AreEqual(this.VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues.UIATM7156ListItemExists, uIATM7156ListItem.Exists);

            // Verify that 'listFiles' list box's property 'Exists' equals 'True'
            // Assert.AreEqual(this.VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues.UIListFilesListExists, uIListFilesList.Exists);
        }

        public virtual VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues
        {
            get
            {
                if ((this.mVerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues == null))
                {
                    this.mVerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues = new VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues();
                }
                return this.mVerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues;
            }
        }

        private VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues mVerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues;

        /// <summary>
        /// VerifyClassifierTitleAndStatusBar - Use 'VerifyClassifierTitleAndStatusBarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyClassifierTitleAndStatusBar(String classifier, String viewType)
        {
            #region Variable Declarations
            WinTitleBar uISmartLearnClassifierTitleBar = this.UISmartLearnClassifierWindow2.UISmartLearnClassifierTitleBar;
            WinText uIViewtypeStandardText = this.UISmartLearnClassifierWindow2.UIStatusBarWindow.UIViewtypeStandardText;
            #endregion

            uISmartLearnClassifierTitleBar.WindowTitles.Add("SmartLearn Classifier Manager - [" + classifier + "]");
            uIViewtypeStandardText.SearchProperties[WinText.PropertyNames.Name] = "View type: " + viewType;
            uIViewtypeStandardText.WindowTitles.Add("SmartLearn Classifier Manager - [" + classifier + "]");
            // Verify that 'SmartLearn Classifier Manager - [ATM0002]' title bar's property 'DisplayText' equals 'SmartLearn Classifier Manager - [ATM0002]'
            Assert.AreEqual("SmartLearn Classifier Manager - [" + classifier + "]", uISmartLearnClassifierTitleBar.DisplayText);

            // Verify that 'View type: Standard' label's property 'DisplayText' equals 'View type: Standard'
            Assert.AreEqual(this.VerifyClassifierTitleAndStatusBarExpectedValues.UIViewtypeStandardTextDisplayText + viewType, uIViewtypeStandardText.DisplayText);
        }

        public virtual VerifyClassifierTitleAndStatusBarExpectedValues VerifyClassifierTitleAndStatusBarExpectedValues
        {
            get
            {
                if ((this.mVerifyClassifierTitleAndStatusBarExpectedValues == null))
                {
                    this.mVerifyClassifierTitleAndStatusBarExpectedValues = new VerifyClassifierTitleAndStatusBarExpectedValues();
                }
                return this.mVerifyClassifierTitleAndStatusBarExpectedValues;
            }
        }

        private VerifyClassifierTitleAndStatusBarExpectedValues mVerifyClassifierTitleAndStatusBarExpectedValues;
    }
    /// <summary>
    /// Parameters to be passed into 'CreateNewClassifier'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CreateNewClassifierParams
    {

        #region Fields
        /// <summary>
        /// Select 'Synchronized' radio button
        /// </summary>
        public bool UISynchronizedRadioButtonSelected = true;

        /// <summary>
        /// Select 'Mark reader' radio button
        /// </summary>
        public bool UIMarkreaderRadioButtonSelected = true;

        /// <summary>
        /// Select 'Standard' radio button
        /// </summary>
        public bool UIStandardRadioButtonSelected = true;

        /// <summary>
        /// Select 'SmartLearn (multi-step)' radio button
        /// </summary>
        public bool UISmartLearnmultistepRadioButtonSelected = true;

        /// <summary>
        /// Select 'Decision tree' in 'listEngines' list box
        /// </summary>
        public string UIListEnginesListSelectedItemsAsString = "Decision tree";

        /// <summary>
        /// Select 'Use default parameters' check box
        /// </summary>
        public bool UIUsedefaultparametersCheckBoxChecked = true;

        /// <summary>
        /// Select 'SmartView (standard)' radio button
        /// </summary>
        public bool UISmartViewstandardRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchClassifierManager'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LaunchClassifierManagerParams
    {

        #region Fields
        /// <summary>
        /// Launch '%SmartViewDir%\ClassifierManager.exe'
        /// </summary>
        public string ExePath = "D:\\SmartView\\ClassifierManager.exe";

        /// <summary>
        /// Launch '%SmartViewDir%\ClassifierManager.exe'
        /// </summary>
        public string AlternateExePath = "%SmartViewDir%\\ClassifierManager.exe";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DeleteClassfier'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DeleteClassfierParams
    {

        #region Fields
        /// <summary>
        /// Type 'Automation' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "Automation";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SaveClassifier'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SaveClassifierParams
    {

        #region Fields
        /// <summary>
        /// Type 'Automation' in 'textName' text box
        /// </summary>
        public string UITextNameEditText = "Automation";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyClassifierListedInClassifierListOnOpenClassifierWindow'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyClassifierListedInClassifierListOnOpenClassifierWindowExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'ATM7156' list item's property 'Exists' equals 'True'
        /// </summary>
        public bool UIATM7156ListItemExists = true;

        /// <summary>
        /// Verify that 'listFiles' list box's property 'Exists' equals 'True'
        /// </summary>
        public bool UIListFilesListExists = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyClassifierTitleAndStatusBar'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyClassifierTitleAndStatusBarExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'SmartLearn Classifier Manager - [ATM0002]' title bar's property 'DisplayText' equals 'SmartLearn Classifier Manager - [ATM0002]'
        /// </summary>
        public string UISmartLearnClassifierTitleBarDisplayText = "SmartLearn Classifier Manager - [ATM0002]";

        /// <summary>
        /// Verify that 'View type: Standard' label's property 'DisplayText' equals 'View type: Standard'
        /// </summary>
        public string UIViewtypeStandardTextDisplayText = "View type: ";
        #endregion
    }
}
