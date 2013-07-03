namespace SmartView.UIModule.Recipe.Thresholds.ThresholdsClasses
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
    public partial class Thresholds
    {

        /// <summary>
        /// ApplyThresholdsSettings
        /// </summary>
        public void ApplyThresholdsSettings()
        {
            #region Variable Declarations
            WinButton uIApplyButton = this.UISmartViewRecipeManagWindow.UIThresholdsStationVieWindow.UIApplyWindow.UIApplyButton;
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow1.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UISmartViewRecipeManagWindow.UIThresholdsStationVieWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Apply' button
            Mouse.Click(uIApplyButton, new Point(20, 17));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(59, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(31, 7));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(33, 12));
        }

        /// <summary>
        /// DefineLowerLevelThresholds - Use 'DefineLowerLevelThresholdsParams' to pass parameters into this method.
        /// </summary>
        public void DefineLowerLevelThresholds()
        {
            #region Variable Declarations
            WinCheckBox uIEnablelowerCheckBox = this.UISmartViewRecipeManagWindow.UIThresholdsStationVieWindow.UIEnablelowerWindow.UIEnablelowerCheckBox;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIThresholdsStationVieWindow.UIItem0Window.UIItemEdit;
            #endregion

            // Select 'Enable lower' check box
            uIEnablelowerCheckBox.Checked = this.DefineLowerLevelThresholdsParams.UIEnablelowerCheckBoxChecked;

            // Type '23' in 'Unknown Name' text box
            uIItemEdit.Text = this.DefineLowerLevelThresholdsParams.UIItemEditText;
        }

        public virtual DefineLowerLevelThresholdsParams DefineLowerLevelThresholdsParams
        {
            get
            {
                if ((this.mDefineLowerLevelThresholdsParams == null))
                {
                    this.mDefineLowerLevelThresholdsParams = new DefineLowerLevelThresholdsParams();
                }
                return this.mDefineLowerLevelThresholdsParams;
            }
        }

        private DefineLowerLevelThresholdsParams mDefineLowerLevelThresholdsParams;

        /// <summary>
        /// LoadThresholdsWindow
        /// </summary>
        public void LoadThresholdsWindow()
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinMenuItem uIThresholdsMenuItem = this.UIItemWindow.UIContextMenu.UIThresholdsMenuItem;
            #endregion

            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(10, 6));

            // Click 'Thresholds...' menu item
            Mouse.Click(uIThresholdsMenuItem, new Point(65, 13));
        }

        /// <summary>
        /// ImportThresholds - Use 'ImportThresholdsParams' to pass parameters into this method.
        /// </summary>
        public void ImportThresholds(String fileName)
        {
            #region Variable Declarations
            WinButton uIImportButton = this.UISmartViewRecipeManagWindow.UIThresholdsStationVieWindow.UIImportWindow.UIImportButton;
            WinComboBox uIFilenameComboBox = this.UIImportThresholdSettiWindow.UIItemWindow.UIFilenameComboBox;
            WinSplitButton uIOpenSplitButton = this.UIImportThresholdSettiWindow.UIOpenWindow.UIOpenSplitButton;
            #endregion

            // Click 'Import...' button
            Mouse.Click(uIImportButton, new Point(45, 15));

            // Select 'AlternateThresholds-AtEdges.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = fileName;

            // Click '&Open' split button
            Mouse.Click(uIOpenSplitButton, new Point(50, 11));
        }

        public virtual ImportThresholdsParams ImportThresholdsParams
        {
            get
            {
                if ((this.mImportThresholdsParams == null))
                {
                    this.mImportThresholdsParams = new ImportThresholdsParams();
                }
                return this.mImportThresholdsParams;
            }
        }

        private ImportThresholdsParams mImportThresholdsParams;
    }
    /// <summary>
    /// Parameters to be passed into 'DefineLowerLevelThresholds'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DefineLowerLevelThresholdsParams
    {

        #region Fields
        /// <summary>
        /// Select 'Enable lower' check box
        /// </summary>
        public bool UIEnablelowerCheckBoxChecked = true;

        /// <summary>
        /// Type '23' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "23";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ImportThresholds'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportThresholdsParams
    {

        #region Fields
        /// <summary>
        /// Select 'AlternateThresholds-AtEdges.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "AlternateThresholds-AtEdges.txt";
        #endregion
}
}
