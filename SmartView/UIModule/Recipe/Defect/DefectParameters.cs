namespace SmartView.UIModule.Recipe.Defect.DefectParametersClasses
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
    using System.Threading;
    using System.IO;


    public partial class UIMap
    {

        /// <summary>
        /// ApplyDefectParameterChanges
        /// </summary>

    }
    /// <summary>
    /// Parameters to be passed into 'ExportDefectParameters'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ExportDefectParametersParams
    {

        #region Fields
        /// <summary>
        /// Select 'aa' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "aa";
        #endregion
    }
    public partial class DefectParameters
    {
        public void ApplyDefectParameterChanges()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(39, 15));
        }

        /// <summary>
        /// ExportDefectParameters - Use 'ExportDefectParametersParams' to pass parameters into this method.
        /// </summary>
        public void ExportDefectParameters()
        {
            #region Variable Declarations
            WinButton uIExportButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIExportWindow.UIExportButton;
            WinComboBox uIFilenameComboBox = this.UIExportDefectParameteWindow.UIDetailsPanePane.UIFilenameComboBox;
            WinButton uISaveButton = this.UIExportDefectParameteWindow.UISaveWindow.UISaveButton;
            #endregion

            // Click 'Export...' button
            Mouse.Click(uIExportButton, new Point(56, 16));

            // Select 'aa' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.ExportDefectParametersParams.UIFilenameComboBoxEditableItem;

            // Click '&Save' button
            Mouse.Click(uISaveButton, new Point(41, 11));
        }

        public virtual ExportDefectParametersParams ExportDefectParametersParams
        {
            get
            {
                if ((this.mExportDefectParametersParams == null))
                {
                    this.mExportDefectParametersParams = new ExportDefectParametersParams();
                }
                return this.mExportDefectParametersParams;
            }
        }

        private ExportDefectParametersParams mExportDefectParametersParams;

        /// <summary>
        /// ImportDefectParameters - Use 'ImportDefectParametersParams' to pass parameters into this method.
        /// </summary>
        public void ImportDefectParameters()
        {
            #region Variable Declarations
            WinButton uIImportButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIImportWindow.UIImportButton;
            WinComboBox uIFilenameComboBox = this.UIImportDefectParameteWindow.UIItemWindow.UIFilenameComboBox;
            WinButton uIOpenButton = this.UIImportDefectParameteWindow.UIOpenWindow.UIOpenButton;
            #endregion

            // Click 'Import...' button
            Mouse.Click(uIImportButton, new Point(34, 16));

            // Select 'aa.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.ImportDefectParametersParams.UIFilenameComboBoxEditableItem;

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(50, 21));
        }

        public virtual ImportDefectParametersParams ImportDefectParametersParams
        {
            get
            {
                if ((this.mImportDefectParametersParams == null))
                {
                    this.mImportDefectParametersParams = new ImportDefectParametersParams();
                }
                return this.mImportDefectParametersParams;
            }
        }

        private ImportDefectParametersParams mImportDefectParametersParams;

        /// <summary>
        /// LoadDefectParameters
        /// </summary>
        public void LoadDefectParameters()
        {
            #region Variable Declarations
            WinTreeItem uIView1TreeItem = this.UISmartViewRecipeManagWindow.UIItemWindow.UIItemTree.UILineTreeItem.UIStationTreeItem.UIView1TreeItem;
            WinMenuItem uIDefectParametersMenuItem = this.UIItemWindow.UIContextMenu.UIDefectParametersMenuItem;
            #endregion

            // Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, new Point(21, 11));

            // Right-Click 'Line' -> 'Station' -> 'View 1' tree item
            Mouse.Click(uIView1TreeItem, MouseButtons.Right, ModifierKeys.None, new Point(21, 11));

            // Click 'Defect Parameters...' menu item
            Mouse.Click(uIDefectParametersMenuItem, new Point(75, 14));
        }

        /// <summary>
        /// SetConnectivityMergeDistanceParameter - Use 'SetConnectivityMergeDistanceParameterParams' to pass parameters into this method.
        /// </summary>
        public void SetConnectivityMergeDistanceParameter(String crossweb, String downweb)
        {
            #region Variable Declarations
            WinGroup uIConnectivitymergedisGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIConnectivitymergedisWindow.UIConnectivitymergedisGroup;
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window.UIItemEdit;
            WinEdit uIItemEdit1 = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window1.UIItemEdit;
            #endregion

            WinEdit uiCrossweb = (WinEdit)uIConnectivitymergedisGroup.GetChildren()[1].GetChildren()[3];


            uiCrossweb.Text = crossweb;
            ConnectivityMergeDistanceDownwebField(downweb);

        }


        public void VerifyConnectivityMergeDistanceParameterValues(String crossweb, String downweb)
        {
            #region Variable Declarations
            WinGroup uIConnectivitymergedisGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIConnectivitymergedisWindow.UIConnectivitymergedisGroup;
            WinWindow uIItem00Window1 = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIConnectivitymergedisGroup.UIItem00Window;
            WinWindow uIItem00Window = new WinWindow(uIConnectivitymergedisGroup);

            #endregion

            WinEdit downwebField = (WinEdit)uIItem00Window.GetChildren()[3];
            WinEdit uiCrossweb = (WinEdit)uIConnectivitymergedisGroup.GetChildren()[1].GetChildren()[3];

            Assert.AreEqual(downweb, downwebField.Text);
            Assert.AreEqual(crossweb, uiCrossweb.Text);

        }

        public virtual SetConnectivityMergeDistanceParameterParams SetConnectivityMergeDistanceParameterParams
        {
            get
            {
                if ((this.mSetConnectivityMergeDistanceParameterParams == null))
                {
                    this.mSetConnectivityMergeDistanceParameterParams = new SetConnectivityMergeDistanceParameterParams();
                }
                return this.mSetConnectivityMergeDistanceParameterParams;
            }
        }

        private SetConnectivityMergeDistanceParameterParams mSetConnectivityMergeDistanceParameterParams;

        /// <summary>
        /// SetDefectNotificationSuppression - Use 'SetDefectNotificationSuppressionParams' to pass parameters into this method.
        /// </summary>
        public void SetDefectNotificationSuppression()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window3.UIItemEdit;
            #endregion

            // Type '122.00' in 'Unknown Name' text box
            uIItemEdit.Text = this.SetDefectNotificationSuppressionParams.UIItemEditText;
        }

        public virtual SetDefectNotificationSuppressionParams SetDefectNotificationSuppressionParams
        {
            get
            {
                if ((this.mSetDefectNotificationSuppressionParams == null))
                {
                    this.mSetDefectNotificationSuppressionParams = new SetDefectNotificationSuppressionParams();
                }
                return this.mSetDefectNotificationSuppressionParams;
            }
        }

        private SetDefectNotificationSuppressionParams mSetDefectNotificationSuppressionParams;

        /// <summary>
        /// SetExtendedConnectivityParameter - Use 'SetExtendedConnectivityParameterParams' to pass parameters into this method.
        /// </summary>
        public void SetExtendedConnectivityParameter(bool isEnable, String crosswebMergeDistance, String downwebMergeDistance)
        {
            #region Variable Declarations
            WinCheckBox uIEnableextendedconnecCheckBox = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIEnableextendedconnecWindow.UIEnableextendedconnecCheckBox;
            WinGroup uIExtendedconnectivityGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIExtendedconnectivityWindow.UIExtendedconnectivityGroup;
            //WinEdit uiCrosswebMergeDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window.UIItemEdit;
            // WinEdit uiDownwebMergeDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window1.UIItemEdit;
            WinWindow uiCrosswebMergeDistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window;
            WinWindow uiDownwebMergeDistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window1;

            WinEdit uiCrosswebMergeDistance = (WinEdit)uiCrosswebMergeDistanceWindow.GetChildren()[3];
            WinEdit uiDownwebMergeDistance = (WinEdit)uiDownwebMergeDistanceWindow.GetChildren()[3];
            #endregion

            // Select 'Enable extended connectivity for designated classe...' check box
            uIEnableextendedconnecCheckBox.Checked = isEnable;
            if (isEnable)
            {
                // Type '1100.00' in 'Unknown Name' text box
                uiCrosswebMergeDistance.Text = crosswebMergeDistance;

                // Type '100100.00' in 'Unknown Name' text box
                uiDownwebMergeDistance.Text = downwebMergeDistance;
            }
        }

        public void VerifyExtendedConnectivityParameter(bool isEnable, String crosswebMergeDistance, String downwebMergeDistance)
        {
            #region Variable Declarations
            WinCheckBox uIEnableextendedconnecCheckBox = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIEnableextendedconnecWindow.UIEnableextendedconnecCheckBox;
            WinGroup uIExtendedconnectivityGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIExtendedconnectivityWindow.UIExtendedconnectivityGroup;
            //WinEdit uiCrosswebMergeDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window.UIItemEdit;
            // WinEdit uiDownwebMergeDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window1.UIItemEdit;
            WinWindow uiCrosswebMergeDistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window;
            WinWindow uiDownwebMergeDistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window1;

            WinEdit uiCrosswebMergeDistance = (WinEdit)uiCrosswebMergeDistanceWindow.GetChildren()[3];
            WinEdit uiDownwebMergeDistance = (WinEdit)uiDownwebMergeDistanceWindow.GetChildren()[3];
            #endregion

            // Select 'Enable extended connectivity for designated classe...' check box         
            Assert.AreEqual(isEnable, uIEnableextendedconnecCheckBox.Checked);

            if (isEnable)
            {
                // Type '1100.00' in 'Unknown Name' text box
                Assert.AreEqual(crosswebMergeDistance, uiCrosswebMergeDistance.Text);

                // Type '100100.00' in 'Unknown Name' text box
                Assert.AreEqual(downwebMergeDistance, uiDownwebMergeDistance.Text);
            }

            if (!isEnable)
            {
                Assert.AreEqual(isEnable, uiCrosswebMergeDistance.Enabled);

                // Type '100100.00' in 'Unknown Name' text box
                Assert.AreEqual(isEnable, uiDownwebMergeDistance.Enabled);
            }

        }

        public virtual SetExtendedConnectivityParameterParams SetExtendedConnectivityParameterParams
        {
            get
            {
                if ((this.mSetExtendedConnectivityParameterParams == null))
                {
                    this.mSetExtendedConnectivityParameterParams = new SetExtendedConnectivityParameterParams();
                }
                return this.mSetExtendedConnectivityParameterParams;
            }
        }

        private SetExtendedConnectivityParameterParams mSetExtendedConnectivityParameterParams;

        /// <summary>
        /// SetFilteredDefectsParameter - Use 'SetFilteredDefectsParameterParams' to pass parameters into this method.
        /// </summary>



        public virtual SetFilteredDefectsParameterParams SetFilteredDefectsParameterParams
        {
            get
            {
                if ((this.mSetFilteredDefectsParameterParams == null))
                {
                    this.mSetFilteredDefectsParameterParams = new SetFilteredDefectsParameterParams();
                }
                return this.mSetFilteredDefectsParameterParams;
            }
        }

        private SetFilteredDefectsParameterParams mSetFilteredDefectsParameterParams;

        /// <summary>
        /// SetOngoingDefectsParameter - Use 'SetOngoingDefectsParameterParams' to pass parameters into this method.
        /// </summary>
        public void SetOngoingDefectsParameter(bool isEnable, String reportingDistance)
        {
            #region Variable Declarations
            WinCheckBox uIEnablegrayscalefilteCheckBox = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIEnablegrayscalefilteWindow.UIEnablegrayscalefilteCheckBox;
            WinWindow uiReportingDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window2;
            //WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window2.UIItemEdit;
            WinEdit uiReportingDistanceText = (WinEdit)uiReportingDistance.GetChildren()[3];
            #endregion

            // Select 'Enable grayscale filtering for ongoing defects' check box
            uIEnablegrayscalefilteCheckBox.Checked = isEnable;

            if (isEnable)
            {
                // Type '5126.00' in 'Unknown Name' text box
                uiReportingDistanceText.Text = reportingDistance;
            }

        }

        public void VerifyOngoingDefectsParameter(bool isEnable, String reportingDistance)
        {
            #region Variable Declarations
            WinCheckBox uIEnablegrayscalefilteCheckBox = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIEnablegrayscalefilteWindow.UIEnablegrayscalefilteCheckBox;
            WinWindow uiReportingDistance = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window2;
            //WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window2.UIItemEdit;
            WinEdit uiReportingDistanceText = (WinEdit)uiReportingDistance.GetChildren()[3];
            #endregion

            Assert.AreEqual(isEnable, uIEnablegrayscalefilteCheckBox.Checked);
            Assert.AreEqual(true, uiReportingDistanceText.Enabled);

            if (isEnable)
            {
                Assert.AreEqual(reportingDistance, uiReportingDistanceText.Text);
            }


        }

        public virtual SetOngoingDefectsParameterParams SetOngoingDefectsParameterParams
        {
            get
            {
                if ((this.mSetOngoingDefectsParameterParams == null))
                {
                    this.mSetOngoingDefectsParameterParams = new SetOngoingDefectsParameterParams();
                }
                return this.mSetOngoingDefectsParameterParams;
            }
        }

        private SetOngoingDefectsParameterParams mSetOngoingDefectsParameterParams;

        /// <summary>
        /// SetPixelParameter - Use 'SetPixelParameterParams' to pass parameters into this method.
        /// </summary>
        public void SetPixelParameter()
        {
            #region Variable Declarations
            WinRadioButton uIThresholdtypeRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIThresholdtypeWindow.UIThresholdtypeRadioButton;
            WinRadioButton uIGraylevelRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIGraylevelWindow.UIGraylevelRadioButton;
            #endregion

            // Select 'Threshold type' radio button
            uIThresholdtypeRadioButton.Selected = this.SetPixelParameterParams.UIThresholdtypeRadioButtonSelected;

            // Select 'Gray level' radio button
            uIGraylevelRadioButton.Selected = this.SetPixelParameterParams.UIGraylevelRadioButtonSelected;
        }

        public virtual SetPixelParameterParams SetPixelParameterParams
        {
            get
            {
                if ((this.mSetPixelParameterParams == null))
                {
                    this.mSetPixelParameterParams = new SetPixelParameterParams();
                }
                return this.mSetPixelParameterParams;
            }
        }

        private SetPixelParameterParams mSetPixelParameterParams;

        /// <summary>
        /// DPFrames - Use 'DPFramesExpectedValues' to pass parameters into this method.
        /// </summary>
        public void DPFrames()
        {
            #region Variable Declarations
            WinGroup uIConnectivitymergedisGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIConnectivitymergedisWindow.UIConnectivitymergedisGroup;
            WinGroup uIExtendedconnectivityGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIExtendedconnectivityWindow.UIExtendedconnectivityGroup;
            WinWindow uIOngoingdefectsWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIDefectParametersStatClient.UIOngoingdefectsWindow;
            WinWindow uIFiltereddefectsWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIDefectParametersStatClient.UIFiltereddefectsWindow;
            WinGroup uIDefectnotificationsuGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIDefectnotificationsuWindow.UIDefectnotificationsuGroup;
            WinGroup uIBrightdarkpixelsGroup = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow1.UIBrightdarkpixelsWindow.UIBrightdarkpixelsGroup;
            #endregion

            // Verify that 'Connectivity merge distance' group's property 'ControlType' equals 'Group'
            Assert.AreEqual(this.DPFramesExpectedValues.UIConnectivitymergedisGroupControlType, uIConnectivitymergedisGroup.ControlType.ToString());

            // Verify that 'Extended connectivity' group's property 'ControlType' equals 'Group'
            Assert.AreEqual(this.DPFramesExpectedValues.UIExtendedconnectivityGroupControlType, uIExtendedconnectivityGroup.ControlType.ToString());

            // Verify that 'Ongoing defects' window's property 'FriendlyName' equals 'Ongoing defects'
            Assert.AreEqual(this.DPFramesExpectedValues.UIOngoingdefectsWindowFriendlyName, uIOngoingdefectsWindow.FriendlyName);

            // Verify that 'Filtered defects' window's property 'ClassName' equals 'ThunderRT6Frame'
            Assert.AreEqual(this.DPFramesExpectedValues.UIFiltereddefectsWindowClassName, uIFiltereddefectsWindow.ClassName);

            // Verify that 'Defect notification suppression' group's property 'ControlType' equals 'Group'
            Assert.AreEqual(this.DPFramesExpectedValues.UIDefectnotificationsuGroupControlType, uIDefectnotificationsuGroup.ControlType.ToString());

            // Verify that 'Bright/dark pixels' group's property 'FriendlyName' equals 'Bright/dark pixels'
            Assert.AreEqual(this.DPFramesExpectedValues.UIBrightdarkpixelsGroupFriendlyName, uIBrightdarkpixelsGroup.FriendlyName);
        }

        public virtual DPFramesExpectedValues DPFramesExpectedValues
        {
            get
            {
                if ((this.mDPFramesExpectedValues == null))
                {
                    this.mDPFramesExpectedValues = new DPFramesExpectedValues();
                }
                return this.mDPFramesExpectedValues;
            }
        }

        private DPFramesExpectedValues mDPFramesExpectedValues;

        /// <summary>
        /// ConnectivityMergeDistanceDownwebField - Use 'ConnectivityMergeDistanceDownwebFieldExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ConnectivityMergeDistanceDownwebField(String downweb)
        {
            #region Variable Declarations
            WinWindow uIItem00Window = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIConnectivitymergedisGroup.UIItem00Window;
            #endregion

            TextWriter tw = new StreamWriter("D:\\TEST2.txt");
            for (int i = 0; i < uIItem00Window.GetChildren().Count; i++)
            {
                tw.WriteLine(uIItem00Window.GetChildren()[i].GetType());
            }
            tw.Close();
            WinEdit downwebField = (WinEdit)uIItem00Window.GetChildren()[3];

            downwebField.Text = downweb;
            // Verify that '0.0' window's property 'FriendlyName' equals '0.0'
            //Assert.AreEqual(this.ConnectivityMergeDistanceDownwebFieldExpectedValues.UIItem00WindowFriendlyName, uIItem00Window.FriendlyName);
        }

        public virtual ConnectivityMergeDistanceDownwebFieldExpectedValues ConnectivityMergeDistanceDownwebFieldExpectedValues
        {
            get
            {
                if ((this.mConnectivityMergeDistanceDownwebFieldExpectedValues == null))
                {
                    this.mConnectivityMergeDistanceDownwebFieldExpectedValues = new ConnectivityMergeDistanceDownwebFieldExpectedValues();
                }
                return this.mConnectivityMergeDistanceDownwebFieldExpectedValues;
            }
        }

        private ConnectivityMergeDistanceDownwebFieldExpectedValues mConnectivityMergeDistanceDownwebFieldExpectedValues;

        /// <summary>
        /// SetFilteredDefectParameter - Use 'SetFilteredDefectParameterParams' to pass parameters into this method.
        /// </summary>
        public void SetFilteredDefectParameter(String filterBy, String value)
        {
            #region Variable Declarations
            WinRadioButton uIBydistanceRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIBydistanceWindow.UIBydistanceRadioButton;
            WinWindow uiBydistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window2;
            WinRadioButton uIBytimeRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIBytimeWindow.UIBytimeRadioButton;
            WinWindow uiBytimeWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window11;
            WinEdit uiBydistanceTxt = (WinEdit)uiBydistanceWindow.GetChildren()[3];
            WinEdit uiBytimeTxt = (WinEdit)uiBytimeWindow.GetChildren()[3];
            #endregion

            if (filterBy.Equals("ByDistance"))
            {
                // Select 'By distance' radio button
                uIBydistanceRadioButton.Selected = this.SetFilteredDefectParameterParams.UIBydistanceRadioButtonSelected;

                // Type '34' in 'Unknown Name' text box
                uiBydistanceTxt.Text = value;
            }

            if (filterBy.Equals("ByTime"))
            {
                // Select 'By time' radio button
                uIBytimeRadioButton.Selected = this.SetFilteredDefectParameterParams.UIBytimeRadioButtonSelected;

                // Type '67' in 'Unknown Name' text box
                uiBytimeTxt.Text = value;
            }
        }

        public void VerifyFilteredDefectParameter(String filterBy, String value)
        {
            #region Variable Declarations
            WinRadioButton uIBydistanceRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIBydistanceWindow.UIBydistanceRadioButton;
            WinWindow uiBydistanceWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window2;
            WinRadioButton uIBytimeRadioButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIBytimeWindow.UIBytimeRadioButton;
            WinWindow uiBytimeWindow = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem0Window11;
            WinEdit uiBydistanceTxt = (WinEdit)uiBydistanceWindow.GetChildren()[3];
            WinEdit uiBytimeTxt = (WinEdit)uiBytimeWindow.GetChildren()[3];
            #endregion

            if (filterBy.Equals("ByDistance"))
            {
                Assert.AreEqual(true, uIBydistanceRadioButton.Selected);
                Assert.AreEqual(value, uiBydistanceTxt.Text);
            }

            if (filterBy.Equals("ByTime"))
            {
                Assert.AreEqual(true, uIBytimeRadioButton.Selected);
                Assert.AreEqual(value, uiBytimeTxt.Text);
            }
        }

        public virtual SetFilteredDefectParameterParams SetFilteredDefectParameterParams
        {
            get
            {
                if ((this.mSetFilteredDefectParameterParams == null))
                {
                    this.mSetFilteredDefectParameterParams = new SetFilteredDefectParameterParams();
                }
                return this.mSetFilteredDefectParameterParams;
            }
        }

        private SetFilteredDefectParameterParams mSetFilteredDefectParameterParams;

        /// <summary>
        /// DownwebField - Use 'DownwebFieldExpectedValues' to pass parameters into this method.
        /// </summary>
        public void DownwebField()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIItem00Window1.UIItemEdit;
            #endregion

            // Verify that 'Unknown Name' text box's property 'Text' equals '92.00'
            Assert.AreEqual(this.DownwebFieldExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public virtual DownwebFieldExpectedValues DownwebFieldExpectedValues
        {
            get
            {
                if ((this.mDownwebFieldExpectedValues == null))
                {
                    this.mDownwebFieldExpectedValues = new DownwebFieldExpectedValues();
                }
                return this.mDownwebFieldExpectedValues;
            }
        }

        private DownwebFieldExpectedValues mDownwebFieldExpectedValues;

        /// <summary>
        /// ImportDefectParametersFromFile - Use 'ImportDefectParametersFromFileParams' to pass parameters into this method.
        /// </summary>
        public void ImportDefectParametersFromFile(String filePath)
        {
            #region Variable Declarations
            WinButton uIImportButton = this.UISmartViewRecipeManagWindow.UIDefectParametersStatWindow.UIImportWindow.UIImportButton;
            WinComboBox uIFilenameComboBox = this.UIImportDefectParameteWindow.UIItemWindow.UIFilenameComboBox;
            WinButton uIOpenButton = this.UIImportDefectParameteWindow.UIOpenWindow.UIOpenButton;
            #endregion

            // Click 'Import...' button
            Mouse.Click(uIImportButton, new Point(54, 7));

            // Select 'd:\aa.txt' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = filePath;
            //Keyboard.SendKeys(uIFilenameComboBox, filePath);

            // Click '&Open' button
            //Mouse.Click(uIOpenButton, new Point(64, 16));
            LoadImportedFile();
        }

        public virtual ImportDefectParametersFromFileParams ImportDefectParametersFromFileParams
        {
            get
            {
                if ((this.mImportDefectParametersFromFileParams == null))
                {
                    this.mImportDefectParametersFromFileParams = new ImportDefectParametersFromFileParams();
                }
                return this.mImportDefectParametersFromFileParams;
            }
        }

        private ImportDefectParametersFromFileParams mImportDefectParametersFromFileParams;

        /// <summary>
        /// LoadImportedFile - Use 'LoadImportedFileParams' to pass parameters into this method.
        /// </summary>
        public void LoadImportedFile()
        {
            #region Variable Declarations
            WinEdit uIFilenameEdit = this.UIImportDefectParameteWindow.UIItemWindow1.UIFilenameEdit;
            WinEdit uIFilenameEdit1 = this.UIImportDefectParameteWindow.UIItemWindow2.UIFilenameEdit;
            #endregion

            // Click 'File name:' text box
            Mouse.Click(uIFilenameEdit, new Point(136, 10));

            // Type '{Enter}' in 'File name:' text box
            Keyboard.SendKeys(uIFilenameEdit1, this.LoadImportedFileParams.UIFilenameEditSendKeys, ModifierKeys.None);
        }

        public virtual LoadImportedFileParams LoadImportedFileParams
        {
            get
            {
                if ((this.mLoadImportedFileParams == null))
                {
                    this.mLoadImportedFileParams = new LoadImportedFileParams();
                }
                return this.mLoadImportedFileParams;
            }
        }

        private LoadImportedFileParams mLoadImportedFileParams;
    }
    /// <summary>
    /// Parameters to be passed into 'ImportDefectParameters'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportDefectParametersParams
    {

        #region Fields
        /// <summary>
        /// Select 'aa.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "aa.txt";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetConnectivityMergeDistanceParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetConnectivityMergeDistanceParameterParams
    {

        #region Fields
        /// <summary>
        /// Type 'ff' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditSendKeys = "ff";

        /// <summary>
        /// Type 'f' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditSendKeys1 = "f";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetDefectNotificationSuppression'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetDefectNotificationSuppressionParams
    {

        #region Fields
        /// <summary>
        /// Type '122.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "122.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetExtendedConnectivityParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetExtendedConnectivityParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'Enable extended connectivity for designated classe...' check box
        /// </summary>
        public bool UIEnableextendedconnecCheckBoxChecked = true;

        /// <summary>
        /// Type '1100.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "1100.00";

        /// <summary>
        /// Type '100100.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "100100.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetFilteredDefectsParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetFilteredDefectsParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'By time' radio button
        /// </summary>
        public bool UIBytimeRadioButtonSelected = true;

        /// <summary>
        /// Select 'By distance' radio button
        /// </summary>
        public bool UIBydistanceRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetOngoingDefectsParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetOngoingDefectsParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'Enable grayscale filtering for ongoing defects' check box
        /// </summary>
        public bool UIEnablegrayscalefilteCheckBoxChecked = true;

        /// <summary>
        /// Type '5126.00' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "5126.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetPixelParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetPixelParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'Threshold type' radio button
        /// </summary>
        public bool UIThresholdtypeRadioButtonSelected = true;

        /// <summary>
        /// Select 'Gray level' radio button
        /// </summary>
        public bool UIGraylevelRadioButtonSelected = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DPFrames'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DPFramesExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Connectivity merge distance' group's property 'ControlType' equals 'Group'
        /// </summary>
        public string UIConnectivitymergedisGroupControlType = "Group";

        /// <summary>
        /// Verify that 'Extended connectivity' group's property 'ControlType' equals 'Group'
        /// </summary>
        public string UIExtendedconnectivityGroupControlType = "Group";

        /// <summary>
        /// Verify that 'Ongoing defects' window's property 'FriendlyName' equals 'Ongoing defects'
        /// </summary>
        public string UIOngoingdefectsWindowFriendlyName = "Ongoing defects";

        /// <summary>
        /// Verify that 'Filtered defects' window's property 'ClassName' equals 'ThunderRT6Frame'
        /// </summary>
        public string UIFiltereddefectsWindowClassName = "ThunderRT6Frame";

        /// <summary>
        /// Verify that 'Defect notification suppression' group's property 'ControlType' equals 'Group'
        /// </summary>
        public string UIDefectnotificationsuGroupControlType = "Group";

        /// <summary>
        /// Verify that 'Bright/dark pixels' group's property 'FriendlyName' equals 'Bright/dark pixels'
        /// </summary>
        public string UIBrightdarkpixelsGroupFriendlyName = "Bright/dark pixels";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ConnectivityMergeDistanceDownwebField'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ConnectivityMergeDistanceDownwebFieldExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that '0.0' window's property 'FriendlyName' equals '0.0'
        /// </summary>
        public string UIItem00WindowFriendlyName = "0.0";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SetFilteredDefectParameter'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class SetFilteredDefectParameterParams
    {

        #region Fields
        /// <summary>
        /// Select 'By distance' radio button
        /// </summary>
        public bool UIBydistanceRadioButtonSelected = true;

        /// <summary>
        /// Type '34' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "34";

        /// <summary>
        /// Select 'By time' radio button
        /// </summary>
        public bool UIBytimeRadioButtonSelected = true;

        /// <summary>
        /// Type '67' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "67";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'DownwebField'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class DownwebFieldExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that 'Unknown Name' text box's property 'Text' equals '92.00'
        /// </summary>
        public string UIItemEditText = "92.00";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ImportDefectParametersFromFile'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class ImportDefectParametersFromFileParams
    {

        #region Fields
        /// <summary>
        /// Select 'd:\aa.txt' in 'File name:' combo box
        /// </summary>
        public string UIFilenameComboBoxEditableItem = "d:\\aa.txt";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LoadImportedFile'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class LoadImportedFileParams
    {

        #region Fields
        /// <summary>
        /// Type '{Enter}' in 'File name:' text box
        /// </summary>
        public string UIFilenameEditSendKeys = "{Enter}";
        #endregion
}
}
