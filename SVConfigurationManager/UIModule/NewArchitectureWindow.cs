namespace SVConfigurationManager.UIModule.NewArchitectureWindowClasses
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
    public partial class NewArchitectureWindow
    {

        /// <summary>
        /// AssignCameraTemplateToView
        /// </summary>
        public void AssignCameraTemplateToView(int noOfCameraTemplate)
        {
            #region Variable Declarations
            WinMenuBar uIApplicationMenuBar = this.UISmartViewConfiguratiWindow.UIApplicationMenuBar;
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem;
            WinTreeItem uIView1TreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            #endregion


            // Click 'Application' menu bar
            Mouse.Click(uIApplicationMenuBar, new Point(34, 51));

            // Move 'Unknown Name' group from (26, 30) to 'Line' -> 'Station' tree item (23, 14)
            uIStationTreeItem.EnsureClickable(new Point(23, 14));
            Mouse.StartDragging(uIItemGroup, new Point(26, 30));
            Mouse.StopDragging(uIStationTreeItem, new Point(23, 14));

            // Move 'Unknown Name' group from (264, 23) to 'Line' -> 'Station' -> 'View 1' tree item (18, 5)
            uIView1TreeItem.EnsureClickable(new Point(18, 5));
            Mouse.StartDragging(uIItemGroup, new Point(264, 23));
            Mouse.StopDragging(uIView1TreeItem, new Point(18, 5));

            // Move 'Unknown Name' group from (267, 22) to 'Line' -> 'Station' -> 'View 1' tree item (9, 5)
            uIView1TreeItem.EnsureClickable(new Point(9, 5));
            Mouse.StartDragging(uIItemGroup, new Point(267, 22));
            Mouse.StopDragging(uIView1TreeItem, new Point(9, 5));

            // Move 'Unknown Name' group from (258, 23) to 'Line' -> 'Station' -> 'View 1' tree item (11, 14)
            uIView1TreeItem.EnsureClickable(new Point(11, 14));
            Mouse.StartDragging(uIItemGroup, new Point(258, 23));
            Mouse.StopDragging(uIView1TreeItem, new Point(11, 14));
        }

        /// <summary>
        /// AssignMarkReaderView
        /// </summary>
        public void AssignMarkReaderView()
        {
            #region Variable Declarations
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem;
            #endregion

            // Move 'Unknown Name' group from (128, 22) to 'Line' -> 'Station' tree item (14, 3)
            uIStationTreeItem.EnsureClickable(new Point(14, 3));
            Mouse.StartDragging(uIItemGroup, new Point(128, 22));
            Mouse.StopDragging(uIStationTreeItem, new Point(14, 3));

            // Click 'Line' -> 'Station' tree item
            Mouse.Click(uIStationTreeItem, new Point(14, 3));

            // Move 'Unknown Name' group from (120, 29) to 'Line' -> 'Station' tree item (13, 8)
            uIStationTreeItem.EnsureClickable(new Point(13, 8));
            Mouse.StartDragging(uIItemGroup, new Point(120, 29));
            Mouse.StopDragging(uIStationTreeItem, new Point(13, 8));
        }

        /// <summary>
        /// AssignStandardView
        /// </summary>
        public void CreateArchitecture(String name, String viewType, int noOfView)
        {
            if (viewType.Equals("standard"))
            {
                AssignStandardView(noOfView);
            }
            if (viewType.Equals("sync"))
            {
                AssignSyncronizeViewPair(noOfView);
            }
            EnterArchitectureName(name);
            ClickOk();
        }
        public void AssignStandardView(int noOfView)
        {
            #region Variable Declarations
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem;
            #endregion

            for (int i = 0; i < noOfView; i++)
            {
                // Move 'Unknown Name' group from (34, 26) to 'Line' -> 'Station' tree item (7, 7)
                uIStationTreeItem.EnsureClickable(new Point(7, 7));
                Mouse.StartDragging(uIItemGroup, new Point(34, 26));
                Mouse.StopDragging(uIStationTreeItem, new Point(7, 7));
            }

            //// Move 'Unknown Name' group from (41, 19) to 'Line' -> 'Station' tree item (13, 7)
            //uIStationTreeItem.EnsureClickable(new Point(13, 7));
            //Mouse.StartDragging(uIItemGroup, new Point(41, 19));
            //Mouse.StopDragging(uIStationTreeItem, new Point(13, 7));

            //// Move 'Unknown Name' group from (33, 19) to 'Line' -> 'Station' tree item (21, 8)
            //uIStationTreeItem.EnsureClickable(new Point(21, 8));
            //Mouse.StartDragging(uIItemGroup, new Point(33, 19));
            //Mouse.StopDragging(uIStationTreeItem, new Point(21, 8));
        }

        /// <summary>
        /// AssignSyncronizeViewPair
        /// </summary>
        public void AssignSyncronizeViewPair(int noOfView)
        {
            #region Variable Declarations
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem;
            #endregion

            for (int index = 0; index < noOfView; index++)
            {
                // Move 'Unknown Name' group from (75, 27) to 'Line' -> 'Station' tree item (12, 4)
                uIStationTreeItem.EnsureClickable(new Point(12, 4));
                Mouse.StartDragging(uIItemGroup, new Point(75, 27));
                Mouse.StopDragging(uIStationTreeItem, new Point(12, 4));
            }

            //// Click 'Line' -> 'Station' tree item
            //Mouse.Click(uIStationTreeItem, new Point(12, 4));

            //// Move 'Unknown Name' group from (72, 26) to 'Line' -> 'Station' tree item (6, 0)
            //uIStationTreeItem.EnsureClickable(new Point(6, 0));
            //Mouse.StartDragging(uIItemGroup, new Point(72, 26));
            //Mouse.StopDragging(uIStationTreeItem, new Point(6, 0));
        }

        /// <summary>
        /// MarkReadingViewPair
        /// </summary>
        public void MarkReadingViewPair()
        {
            #region Variable Declarations
            WinGroup uIItemGroup = this.UINewArchitectureWindow.UIItemWindow.UIItemGroup;
            WinTreeItem uIStationTreeItem = this.UINewArchitectureWindow.UIItemWindow1.UIItemTree.UILineTreeItem.UIStationTreeItem;
            #endregion

            // Move 'Unknown Name' group from (171, 25) to 'Line' -> 'Station' tree item (9, 3)
            uIStationTreeItem.EnsureClickable(new Point(9, 3));
            Mouse.StartDragging(uIItemGroup, new Point(171, 25));
            Mouse.StopDragging(uIStationTreeItem, new Point(9, 3));

            // Move 'Unknown Name' group from (165, 23) to 'Line' -> 'Station' tree item (23, 10)
            uIStationTreeItem.EnsureClickable(new Point(23, 10));
            Mouse.StartDragging(uIItemGroup, new Point(165, 23));
            Mouse.StopDragging(uIStationTreeItem, new Point(23, 10));
        }

        /// <summary>
        /// ClickOk
        /// </summary>
        public void ClickOk()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UINewArchitectureWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(44, 16));
        }

        /// <summary>
        /// EnterArchitectureName - Use 'EnterArchitectureNameParams' to pass parameters into this method.
        /// </summary>
        public void EnterArchitectureName(String name)
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UINewArchitectureWindow.UIItemWindow2.UIItemEdit;
            #endregion

            // Type 'dd' in 'Unknown Name' text box
            uIItemEdit.Text = name;
        }

        public virtual EnterArchitectureNameParams EnterArchitectureNameParams
        {
            get
            {
                if ((this.mEnterArchitectureNameParams == null))
                {
                    this.mEnterArchitectureNameParams = new EnterArchitectureNameParams();
                }
                return this.mEnterArchitectureNameParams;
            }
        }

        private EnterArchitectureNameParams mEnterArchitectureNameParams;
    }
    /// <summary>
    /// Parameters to be passed into 'EnterArchitectureName'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class EnterArchitectureNameParams
    {

        #region Fields
        /// <summary>
        /// Type 'dd' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "dd";
        #endregion
}
}
