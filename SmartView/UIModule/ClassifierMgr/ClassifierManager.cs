namespace SmartView.UIModule.ClassifierMgr.ClassifierManagerClasses
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
}
