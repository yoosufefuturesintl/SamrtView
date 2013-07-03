namespace SmartView.UIModule.Recipe.RecipeWizardClasses
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

        /// <summary>
        /// LaunchRecipe - Use 'LaunchRecipeParams' to pass parameters into this method.
        /// </summary>
        public void LaunchRecipe()
        {

            // Launch '%SmartViewDir%\RecipeManager.exe'
            ApplicationUnderTest recipeManagerApplication = ApplicationUnderTest.Launch(this.LaunchRecipeParams.ExePath, this.LaunchRecipeParams.AlternateExePath);
        }

        public virtual LaunchRecipeParams LaunchRecipeParams
        {
            get
            {
                if ((this.mLaunchRecipeParams == null))
                {
                    this.mLaunchRecipeParams = new LaunchRecipeParams();
                }
                return this.mLaunchRecipeParams;
            }
        }

        private LaunchRecipeParams mLaunchRecipeParams;
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LaunchRecipeParams
    {

        #region Fields
        /// <summary>
        /// Launch '%SmartViewDir%\RecipeManager.exe'
        /// </summary>
        public string ExePath = "D:\\SmartView\\RecipeManager.exe";

        /// <summary>
        /// Launch '%SmartViewDir%\RecipeManager.exe'
        /// </summary>
        public string AlternateExePath = "%SmartViewDir%\\RecipeManager.exe";
        #endregion
    }
    public partial class RecipeWizard
    {

        public void LaunchRecipe(String exePath, String alternateExePath)
        {

            // Launch '%SmartViewDir%\RecipeManager.exe'
            ApplicationUnderTest recipeManagerApplication = ApplicationUnderTest.Launch(exePath, alternateExePath);
        }


        /// <summary>
        /// SelectArchitectureInRecipeWizard - Use 'SelectArchitectureInRecipeWizardParams' to pass parameters into this method.
        /// </summary>
        public void SelectArchitectureInRecipeWizard(String architecture)
        {
            #region Variable Declarations
            WinList uIItemList = this.UIRecipeWizardWindow.UIItemWindow.UIItemList;
            #endregion

            // Select '2 Views' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = architecture;
        }

        public virtual SelectArchitectureInRecipeWizardParams SelectArchitectureInRecipeWizardParams
        {
            get
            {
                if ((this.mSelectArchitectureInRecipeWizardParams == null))
                {
                    this.mSelectArchitectureInRecipeWizardParams = new SelectArchitectureInRecipeWizardParams();
                }
                return this.mSelectArchitectureInRecipeWizardParams;
            }
        }

        private SelectArchitectureInRecipeWizardParams mSelectArchitectureInRecipeWizardParams;

        /// <summary>
        /// SelectExistingRecipe - Use 'SelectExistingRecipeParams' to pass parameters into this method.
        /// </summary>
        public void SelectExistingRecipe(String recipe)
        {
            #region Variable Declarations
            WinButton uINextButton = this.UIRecipeWizardWindow.UINextWindow.UINextButton;
            WinRadioButton uISelectexistingrecipeRadioButton = this.UIRecipeWizardWindow.UISelectexistingrecipeWindow.UISelectexistingrecipeRadioButton;
            WinList uIItemList = this.UIRecipeWizardWindow.UIItemWindow1.UIItemList;
            WinButton uIFinishButton = this.UIRecipeWizardWindow.UIFinishWindow.UIFinishButton;
            #endregion

            // Click 'Next >>' button
            Mouse.Click(uINextButton, new Point(41, 10));

            // Select 'Select existing recipe' radio button
            uISelectexistingrecipeRadioButton.Selected = this.SelectExistingRecipeParams.UISelectexistingrecipeRadioButtonSelected;

            // Select 'M3' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = recipe;

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(48, 12));
        }

        public virtual SelectExistingRecipeParams SelectExistingRecipeParams
        {
            get
            {
                if ((this.mSelectExistingRecipeParams == null))
                {
                    this.mSelectExistingRecipeParams = new SelectExistingRecipeParams();
                }
                return this.mSelectExistingRecipeParams;
            }
        }

        private SelectExistingRecipeParams mSelectExistingRecipeParams;

        /// <summary>
        /// ClickBackButton
        /// </summary>
        public void ClickBackButton()
        {
            #region Variable Declarations
            WinButton uIBackButton = this.UIRecipeWizard4CameraLWindow.UIBackWindow.UIBackButton;
            #endregion

            // Click '<< Back' button
            Mouse.Click(uIBackButton, new Point(54, 9));
        }

        /// <summary>
        /// CreateNewRecipe - Use 'CreateNewRecipeParams' to pass parameters into this method.
        /// </summary>
        public void CreateNewRecipe(String name)
        {
            #region Variable Declarations
            WinRadioButton uICreateanewrecipeRadioButton = this.UIRecipeWizardATM71415Window.UICreateanewrecipeWindow.UICreateanewrecipeRadioButton;
            WinEdit uIItemEdit = this.UIRecipeWizardATM71415Window.UIItemWindow.UIItemEdit;
            WinButton uIFinishButton = this.UIRecipeWizardATM71415Window.UIFinishWindow.UIFinishButton;
            WinButton uINextButton = this.UIRecipeWizardWindow.UINextWindow.UINextButton;
            #endregion
          

            // Click 'Next >>' button
            Mouse.Click(uINextButton, new Point(41, 10));


            // Select 'Create a new recipe' radio button
            uICreateanewrecipeRadioButton.Selected = this.CreateNewRecipeParams.UICreateanewrecipeRadioButtonSelected;

            // Type 'TestCreate' in 'Unknown Name' text box
            uIItemEdit.Text = name;

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(44, 6));
        }

        public virtual CreateNewRecipeParams CreateNewRecipeParams
        {
            get
            {
                if ((this.mCreateNewRecipeParams == null))
                {
                    this.mCreateNewRecipeParams = new CreateNewRecipeParams();
                }
                return this.mCreateNewRecipeParams;
            }
        }

        private CreateNewRecipeParams mCreateNewRecipeParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SelectArchitectureInRecipeWizard'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectArchitectureInRecipeWizardParams
    {

        #region Fields
        /// <summary>
        /// Select '2 Views' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "2 Views";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SelectExistingRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SelectExistingRecipeParams
    {

        #region Fields
        /// <summary>
        /// Select 'Select existing recipe' radio button
        /// </summary>
        public bool UISelectexistingrecipeRadioButtonSelected = true;

        /// <summary>
        /// Select 'M3' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "M3";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'CreateNewRecipe'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class CreateNewRecipeParams
    {

        #region Fields
        /// <summary>
        /// Select 'Create a new recipe' radio button
        /// </summary>
        public bool UICreateanewrecipeRadioButtonSelected = true;

        /// <summary>
        /// Type 'TestCreate' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "TestCreate";
        #endregion
}
}
