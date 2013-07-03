namespace SmartView.UIModule.PQA.WebViewer.GoToWindowClasses
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
    public partial class GoToWindow
    {

        public void LoadGoToWindow() {
            WinWindow uIViewportWindow = this.UISmartViewProductionQWindow.UIWednesdayWindow.UIWednesdayClient.UIViewportWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;

            // Click 'viewport' window
            Mouse.Click(uIViewportWindow, new Point(66, 13));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(52, 158));
      
        }

        public void GoToDefect(String defectNo)
        {
            WinEdit uIItemEdit = this.UIGoToWindow.UIText1Window.UIItemEdit;
            WinButton uIGOButton = this.UIGoToWindow.UIGOWindow.UIGOButton;

            // Type '7676' in 'Unknown Name' text box
            uIItemEdit.Text = defectNo;

            // Click 'Go' button
            Mouse.Click(uIGOButton, new Point(32, 11));
        }

        public void GoToPosition(String crosswebPosition, String downwebPosition)
        {
            WinEdit uIItemEdit1 = this.UIGoToWindow.UIText2Window.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIGoToWindow.UIText3Window.UIItemEdit;
            WinButton uIGOButton1 = this.UIGoToWindow.UIGOWindow1.UIGOButton;


            // Type '78' in 'Unknown Name' text box
            uIItemEdit1.Text = crosswebPosition;

            // Type '988' in 'Unknown Name' text box
            uIItemEdit2.Text = downwebPosition;

            // Click 'Go' button
            Mouse.Click(uIGOButton1, new Point(23, 13));

        }

        public void CloseGoToWindow()
        {
            WinButton uICloseButton = this.UIGoToWindow.UIGoToTitleBar.UICloseButton;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(5, 7));
        }
        /// <summary>
        /// GoToWindow_1 - Use 'GoToWindow_1Params' to pass parameters into this method.
        /// </summary>
        public void GoToWindow_1()
        {
            #region Variable Declarations
            WinWindow uIViewportWindow = this.UISmartViewProductionQWindow.UIWednesdayWindow.UIWednesdayClient.UIViewportWindow;
            WinClient uIDesktopClient = this.UIItemWindow.UIItemWindow1.UIDesktopClient;
            WinEdit uIItemEdit = this.UIGoToWindow.UIText1Window.UIItemEdit;
            WinButton uIGOButton = this.UIGoToWindow.UIGOWindow.UIGOButton;
            WinEdit uIItemEdit1 = this.UIGoToWindow.UIText2Window.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIGoToWindow.UIText3Window.UIItemEdit;
            WinButton uIGOButton1 = this.UIGoToWindow.UIGOWindow1.UIGOButton;
            WinButton uICloseButton = this.UIGoToWindow.UIGoToTitleBar.UICloseButton;
            #endregion

            // Click 'viewport' window
            Mouse.Click(uIViewportWindow, new Point(66, 13));

            // Click 'Desktop' client
            Mouse.Click(uIDesktopClient, new Point(52, 158));

            // Type '7676' in 'Unknown Name' text box
            uIItemEdit.Text = this.GoToWindow_1Params.UIItemEditText;

            // Click 'Go' button
            Mouse.Click(uIGOButton, new Point(32, 11));

            // Type '78' in 'Unknown Name' text box
            uIItemEdit1.Text = this.GoToWindow_1Params.UIItemEditText1;

            // Type '988' in 'Unknown Name' text box
            uIItemEdit2.Text = this.GoToWindow_1Params.UIItemEditText2;

            // Click 'Go' button
            Mouse.Click(uIGOButton1, new Point(23, 13));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(5, 7));
        }

        public virtual GoToWindow_1Params GoToWindow_1Params
        {
            get
            {
                if ((this.mGoToWindow_1Params == null))
                {
                    this.mGoToWindow_1Params = new GoToWindow_1Params();
                }
                return this.mGoToWindow_1Params;
            }
        }

        private GoToWindow_1Params mGoToWindow_1Params;
    }
    /// <summary>
    /// Parameters to be passed into 'GoToWindow_1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class GoToWindow_1Params
    {

        #region Fields
        /// <summary>
        /// Type '7676' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "7676";

        /// <summary>
        /// Type '78' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "78";

        /// <summary>
        /// Type '988' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "988";
        #endregion
}
}
