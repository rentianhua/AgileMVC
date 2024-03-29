
//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// For more information see: 
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.practices.scsf.2007may/SCSF/html/02-09-010-ModelViewPresenter_MVP.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace HiiP.Framework.Logging
{
    partial class PerformanceMonitoringView
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private PerformanceMonitoringViewPresenter _presenter = null;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_presenter != null)
                    _presenter.Dispose();

                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MODULE_ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FUNCTION_ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("COMPONENT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SECONDS_ELAPSED");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("START_DATE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("END_DATE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CATEGORY_NAME", 0);
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.GridViewPerformance = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.totalCount = new Infragistics.Win.Misc.UltraLabel();
            this.ButtonClose = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.TextBoxUserName = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.DateTimeStartDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.TextBoxFunctionId = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.DateTimeEndDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ComboxComponentName = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonClear = new Infragistics.Win.Misc.UltraButton();
            this.ButtonSearch = new Infragistics.Win.Misc.UltraButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.validationProvider1 = new Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider();
            this.validationProvider2 = new Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPerformance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFunctionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboxComponentName)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.GridViewPerformance);
            this.ultraGroupBox2.Controls.Add(this.panel1);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 115);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(978, 370);
            this.ultraGroupBox2.TabIndex = 1;
            this.ultraGroupBox2.Text = "Search result";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // GridViewPerformance
            // 
            appearance20.BackColor = System.Drawing.SystemColors.Window;
            appearance20.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.GridViewPerformance.DisplayLayout.Appearance = appearance20;
            this.GridViewPerformance.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "Module ID";
            ultraGridColumn1.Header.VisiblePosition = 2;
            ultraGridColumn1.Width = 268;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "Function ID";
            ultraGridColumn2.Header.VisiblePosition = 3;
            ultraGridColumn2.Width = 297;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "Component";
            ultraGridColumn3.Header.VisiblePosition = 4;
            ultraGridColumn3.Width = 179;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.Caption = "Response time";
            ultraGridColumn4.Header.VisiblePosition = 5;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Format = "";
            ultraGridColumn5.Header.Caption = "Start Time";
            ultraGridColumn5.Header.VisiblePosition = 0;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Format = "";
            ultraGridColumn6.Header.Caption = "End Time";
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7});
            this.GridViewPerformance.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.GridViewPerformance.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.GridViewPerformance.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance21.BorderColor = System.Drawing.SystemColors.Window;
            this.GridViewPerformance.DisplayLayout.GroupByBox.Appearance = appearance21;
            appearance22.ForeColor = System.Drawing.SystemColors.GrayText;
            this.GridViewPerformance.DisplayLayout.GroupByBox.BandLabelAppearance = appearance22;
            this.GridViewPerformance.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance23.BackColor2 = System.Drawing.SystemColors.Control;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance23.ForeColor = System.Drawing.SystemColors.GrayText;
            this.GridViewPerformance.DisplayLayout.GroupByBox.PromptAppearance = appearance23;
            this.GridViewPerformance.DisplayLayout.MaxColScrollRegions = 1;
            this.GridViewPerformance.DisplayLayout.MaxRowScrollRegions = 1;
            appearance24.BackColor = System.Drawing.SystemColors.Window;
            appearance24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridViewPerformance.DisplayLayout.Override.ActiveCellAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Highlight;
            appearance25.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridViewPerformance.DisplayLayout.Override.ActiveRowAppearance = appearance25;
            this.GridViewPerformance.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.GridViewPerformance.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.GridViewPerformance.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance26.BackColor = System.Drawing.SystemColors.Window;
            this.GridViewPerformance.DisplayLayout.Override.CardAreaAppearance = appearance26;
            appearance27.BorderColor = System.Drawing.Color.Silver;
            appearance27.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.GridViewPerformance.DisplayLayout.Override.CellAppearance = appearance27;
            this.GridViewPerformance.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.GridViewPerformance.DisplayLayout.Override.CellPadding = 0;
            appearance28.BackColor = System.Drawing.SystemColors.Control;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance28.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance28.BorderColor = System.Drawing.SystemColors.Window;
            this.GridViewPerformance.DisplayLayout.Override.GroupByRowAppearance = appearance28;
            appearance29.TextHAlignAsString = "Left";
            this.GridViewPerformance.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.GridViewPerformance.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.GridViewPerformance.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance30.BackColor = System.Drawing.SystemColors.Window;
            appearance30.BorderColor = System.Drawing.Color.Silver;
            this.GridViewPerformance.DisplayLayout.Override.RowAppearance = appearance30;
            this.GridViewPerformance.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GridViewPerformance.DisplayLayout.Override.TemplateAddRowAppearance = appearance31;
            this.GridViewPerformance.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.GridViewPerformance.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.GridViewPerformance.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.GridViewPerformance.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.GridViewPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPerformance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.GridViewPerformance.Location = new System.Drawing.Point(3, 39);
            this.GridViewPerformance.Name = "GridViewPerformance";
            this.GridViewPerformance.Size = new System.Drawing.Size(972, 328);
            this.GridViewPerformance.TabIndex = 2;
            this.GridViewPerformance.Text = "ultraGrid1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraLabel9);
            this.panel1.Controls.Add(this.totalCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 21);
            this.panel1.TabIndex = 3;
            // 
            // ultraLabel9
            // 
            appearance9.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel9.Appearance = appearance9;
            this.ultraLabel9.Location = new System.Drawing.Point(3, 3);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(93, 17);
            this.ultraLabel9.TabIndex = 0;
            this.ultraLabel9.Text = "Total record(s):";
            // 
            // totalCount
            // 
            appearance10.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.totalCount.Appearance = appearance10;
            this.totalCount.Location = new System.Drawing.Point(96, 4);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(73, 17);
            this.totalCount.TabIndex = 1;
            this.totalCount.Text = "0";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ButtonClose.Location = new System.Drawing.Point(888, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(87, 25);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "&Close";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(978, 115);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Search criteria";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxUserName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateTimeStartDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFunctionId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateTimeEndDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboxComponentName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 94);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance13.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.TextHAlignAsString = "Right";
            this.ultraLabel1.Appearance = appearance13;
            this.ultraLabel1.Location = new System.Drawing.Point(33, 3);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(84, 22);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "* Start time";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxUserName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.TextBoxUserName.Location = new System.Drawing.Point(765, 3);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.validationProvider2.SetPerformValidation(this.TextBoxUserName, true);
            this.TextBoxUserName.Size = new System.Drawing.Size(201, 23);
            this.validationProvider2.SetSourcePropertyName(this.TextBoxUserName, "UserName");
            this.TextBoxUserName.TabIndex = 5;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance16.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance16.TextHAlignAsString = "Right";
            this.ultraLabel2.Appearance = appearance16;
            this.ultraLabel2.Location = new System.Drawing.Point(33, 31);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(84, 22);
            this.ultraLabel2.TabIndex = 6;
            this.ultraLabel2.Text = "* End time";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance18.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance18.TextHAlignAsString = "Right";
            this.ultraLabel3.Appearance = appearance18;
            this.ultraLabel3.Location = new System.Drawing.Point(697, 3);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(62, 22);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "* User ID";
            // 
            // DateTimeStartDate
            // 
            this.DateTimeStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimeStartDate.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.DateTimeStartDate.Location = new System.Drawing.Point(123, 3);
            this.DateTimeStartDate.MaskInput = "{date} {longtime}";
            this.DateTimeStartDate.Name = "DateTimeStartDate";
            this.DateTimeStartDate.Nullable = false;
            this.validationProvider1.SetPerformValidation(this.DateTimeStartDate, true);
            this.DateTimeStartDate.Size = new System.Drawing.Size(176, 23);
            this.validationProvider1.SetSourcePropertyName(this.DateTimeStartDate, "StartTime");
            this.DateTimeStartDate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.DateTimeStartDate.TabIndex = 1;
            this.validationProvider1.SetValidatedProperty(this.DateTimeStartDate, "Value");
            // 
            // TextBoxFunctionId
            // 
            this.TextBoxFunctionId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxFunctionId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.TextBoxFunctionId.Location = new System.Drawing.Point(454, 3);
            this.TextBoxFunctionId.Name = "TextBoxFunctionId";
            this.TextBoxFunctionId.Size = new System.Drawing.Size(163, 23);
            this.TextBoxFunctionId.TabIndex = 3;
            // 
            // DateTimeEndDate
            // 
            this.DateTimeEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimeEndDate.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.DateTimeEndDate.Location = new System.Drawing.Point(123, 31);
            this.DateTimeEndDate.MaskInput = "{date} {longtime}";
            this.DateTimeEndDate.Name = "DateTimeEndDate";
            this.DateTimeEndDate.Nullable = false;
            this.validationProvider1.SetPerformValidation(this.DateTimeEndDate, true);
            this.DateTimeEndDate.Size = new System.Drawing.Size(176, 23);
            this.validationProvider1.SetSourcePropertyName(this.DateTimeEndDate, "EndTime");
            this.DateTimeEndDate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.DateTimeEndDate.TabIndex = 7;
            this.validationProvider1.SetValidatedProperty(this.DateTimeEndDate, "Value");
            // 
            // ComboxComponentName
            // 
            this.ComboxComponentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboxComponentName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.ComboxComponentName.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.ComboxComponentName.Location = new System.Drawing.Point(454, 31);
            this.ComboxComponentName.Name = "ComboxComponentName";
            this.ComboxComponentName.Size = new System.Drawing.Size(163, 23);
            this.ComboxComponentName.SyncWithCurrencyManager = false;
            this.ComboxComponentName.TabIndex = 9;
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance15.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance15.TextHAlignAsString = "Right";
            this.ultraLabel5.Appearance = appearance15;
            this.ultraLabel5.Location = new System.Drawing.Point(334, 3);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(114, 22);
            this.ultraLabel5.TabIndex = 2;
            this.ultraLabel5.Text = "Module/Function ID";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance19.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance19.TextHAlignAsString = "Right";
            this.ultraLabel6.Appearance = appearance19;
            this.ultraLabel6.Location = new System.Drawing.Point(334, 31);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(114, 22);
            this.ultraLabel6.TabIndex = 8;
            this.ultraLabel6.Text = "Component name";
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 6);
            this.flowLayoutPanel2.Controls.Add(this.ButtonClear);
            this.flowLayoutPanel2.Controls.Add(this.ButtonSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(966, 32);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // ButtonClear
            // 
            this.ButtonClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ButtonClear.Location = new System.Drawing.Point(876, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(87, 25);
            this.ButtonClear.TabIndex = 11;
            this.ButtonClear.Text = "&Reset";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ButtonSearch.Location = new System.Drawing.Point(783, 3);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(87, 25);
            this.ButtonSearch.TabIndex = 10;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // validationProvider1
            // 
            this.validationProvider1.ErrorProvider = this.errorProvider1;
            this.validationProvider1.RulesetName = "Date Time Compare Set";
            this.validationProvider1.SourceTypeName = "HiiP.Framework.Logging.Interface.ValidationEntity.DateTimeCompare,HiiP.Framework." +
                "Logging.Interface";
            // 
            // validationProvider2
            // 
            this.validationProvider2.ErrorProvider = this.errorProvider1;
            this.validationProvider2.RulesetName = "Common Info Rules";
            this.validationProvider2.SourceTypeName = "HiiP.Framework.Common.Validation.CommonInfoEntity,HiiP.Framework.Common";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 485);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(978, 28);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PerformanceMonitoringView
            // 
            this.AcceptButton = this.ButtonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.ButtonClose;
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Key = "Performance Monitoring View";
            this.Name = "PerformanceMonitoringView";
            this.Size = new System.Drawing.Size(978, 513);
            this.Load += new System.EventHandler(this.PerformanceMonitoringView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPerformance)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFunctionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboxComponentName)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton ButtonSearch;
        private Infragistics.Win.Misc.UltraButton ButtonClear;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ComboxComponentName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor DateTimeStartDate;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor DateTimeEndDate;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinGrid.UltraGrid GridViewPerformance;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor TextBoxFunctionId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider validationProvider1;
        private Infragistics.Win.Misc.UltraLabel totalCount;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraButton ButtonClose;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor TextBoxUserName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider validationProvider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;


    }
}

