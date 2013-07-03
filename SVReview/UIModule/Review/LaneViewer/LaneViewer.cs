namespace SVReview.UIModule.Review.LaneViewer.LaneViewerClasses
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
    public partial class LaneViewer
    {

        /// <summary>
        /// LaunchLaneViewer
        /// </summary>
        public void LaunchLaneViewer()
        {
            #region Variable Declarations
            WinWindow uISmartViewReview4CameWindow = this.UISmartViewReview4CameWindow;
            #endregion

            // Click 'SmartView Review: 4 Camera, Station' window
            Mouse.Click(uISmartViewReview4CameWindow, new Point(28, 149));
           
        }

        /// <summary>
        /// MaximizeLaneViewer
        /// </summary>
        public void MaximizeLaneViewer()
        {
            #region Variable Declarations
            WinTitleBar uILaneViewerTitleBar = this.UISmartViewReview4CameWindow.UILaneViewerWindow.UILaneViewerTitleBar;
            #endregion

            // Double-Click 'Lane Viewer' title bar
            Mouse.DoubleClick(uILaneViewerTitleBar, new Point(70, 10));
        }

        /// <summary>
        /// VerifyLaneViewerLaunchedSuccessfully - Use 'VerifyLaneViewerLaunchedSuccessfullyExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyLaneViewerLaunchedSuccessfully()
        {
            #region Variable Declarations
            WinClient uILaneViewerClient = this.UISmartViewReview4CameWindow.UILaneViewerWindow.UIItemWindow.UILaneViewerClient;
            WinWindow uIItemWindow = this.UISmartViewReview4CameWindow.UILaneViewerWindow.UILaneViewerClient.UIItemWindow;
            #endregion

            // Verify that 'Lane Viewer' client's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyLaneViewerLaunchedSuccessfullyExpectedValues.UILaneViewerClientExists, uILaneViewerClient.Exists);

            // Verify that 'Unknown Name' window's property 'Exists' equals 'True'
            Assert.AreEqual(this.VerifyLaneViewerLaunchedSuccessfullyExpectedValues.UIItemWindowExists, uIItemWindow.Exists);
        }

        public virtual VerifyLaneViewerLaunchedSuccessfullyExpectedValues VerifyLaneViewerLaunchedSuccessfullyExpectedValues
        {
            get
            {
                if ((this.mVerifyLaneViewerLaunchedSuccessfullyExpectedValues == null))
                {
                    this.mVerifyLaneViewerLaunchedSuccessfullyExpectedValues = new VerifyLaneViewerLaunchedSuccessfullyExpectedValues();
                }
                return this.mVerifyLaneViewerLaunchedSuccessfullyExpectedValues;
            }
        }

        private VerifyLaneViewerLaunchedSuccessfullyExpectedValues mVerifyLaneViewerLaunchedSuccessfullyExpectedValues;

        /// <summary>
        /// ClickOnViewerPort
        /// </summary>
        public void ClickOnViewerPort()
        {
            #region Variable Declarations
            WinClient uILaneViewerClient = this.UISmartViewReview4CameWindow.UILaneViewerWindow1.UIItemWindow.UILaneViewerClient;
            #endregion

            // Click 'Lane Viewer' client
            Mouse.Click(uILaneViewerClient, new Point(195, 227));
}
    }
    /// <summary>
    /// Parameters to be passed into 'VerifyLaneViewerLaunchedSuccessfully'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class VerifyLaneViewerLaunchedSuccessfullyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Lane Viewer' client's property 'Exists' equals 'True'
        /// </summary>
        public bool UILaneViewerClientExists = true;

        /// <summary>
        /// Verify that 'Unknown Name' window's property 'Exists' equals 'True'
        /// </summary>
        public bool UIItemWindowExists = true;
        #endregion
}
}
