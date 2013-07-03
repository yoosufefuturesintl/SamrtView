namespace SmartView.UIModule.Review.ReviewClasses
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
    public partial class Review
    {

        /// <summary>
        /// LaunchReview - Use 'LaunchReviewParams' to pass parameters into this method.
        /// </summary>
        public void LaunchReview()
        {

            // Launch '%SmartViewDir%\Review.exe'
            ApplicationUnderTest reviewApplication = ApplicationUnderTest.Launch(this.LaunchReviewParams.ExePath, this.LaunchReviewParams.AlternateExePath);
            ConfirmAlreadyReviewRunningMessage();
        }

public virtual LaunchReviewParams LaunchReviewParams
{
    get
    {
        if ((this.mLaunchReviewParams == null))
        {
            this.mLaunchReviewParams = new LaunchReviewParams();
        }
        return this.mLaunchReviewParams;
    }
}


private LaunchReviewParams mLaunchReviewParams;


/// <summary>
/// ConfirmAlreadyReviewRunningMessage
/// </summary>
public void ConfirmAlreadyReviewRunningMessage()
{
    #region Variable Declarations
    WinButton uIYesButton = this.UISmartViewReviewWindow.UIYesWindow.UIYesButton;
    #endregion

    if (uIYesButton.Exists)
    {
        // Click '&Yes' button
        Mouse.Click(uIYesButton, new Point(34, 15));
    }
    
}
}
/// <summary>
/// Parameters to be passed into 'LaunchReview'
/// </summary>
[GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
public class LaunchReviewParams
{
    
    #region Fields
    /// <summary>
    /// Launch '%SmartViewDir%\Review.exe'
    /// </summary>
    public string ExePath = "D:\\SmartView\\Review.exe";
    
    /// <summary>
    /// Launch '%SmartViewDir%\Review.exe'
    /// </summary>
    public string AlternateExePath = "%SmartViewDir%\\Review.exe";
    #endregion
}
}
