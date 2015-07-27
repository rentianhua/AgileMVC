
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

namespace HiiP.Framework.Security.UserManagement
{
    partial class DMSUserRoleAssignment
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private HiiP.Framework.Security.UserManagement.DMSUserRoleAssignmentPresenter _presenter = null;

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
                if (_ETHelper != null) _ETHelper.Dispose();
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ETTable", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UserName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IsSupervisor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TickFlag", 0);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance322 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance323 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance324 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ETTable", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UserName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IsSupervisor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TickFlag", 0);
            Infragistics.Win.Appearance appearance325 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance326 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance327 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance328 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance329 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance330 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance331 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance332 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance333 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance334 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance335 = new Infragistics.Win.Appearance();
            this.ultraToolTipManager = new Infragistics.Win.UltraWinToolTip.UltraToolTipManager(this.components);
            this.ultraGroupBox28 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridDMSAssigned = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraButtonDMSUnassign = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonDMSAssign = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox27 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonDMSReset = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonDMSSearch = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditorDMSDesc = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel72 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorDMSRole = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel73 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGridDMSAllRoles = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.cb_dmsprofiles = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.eTTableDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox28)).BeginInit();
            this.ultraGroupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDMSAssigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox27)).BeginInit();
            this.ultraGroupBox27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDMSDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDMSRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDMSAllRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dmsprofiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTTableDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraToolTipManager
            // 
            this.ultraToolTipManager.ContainingControl = this;
            // 
            // ultraGroupBox28
            // 
            this.ultraGroupBox28.Controls.Add(this.ultraGridDMSAssigned);
            this.ultraGroupBox28.Location = new System.Drawing.Point(436, 3);
            this.ultraGroupBox28.Name = "ultraGroupBox28";
            this.ultraGroupBox28.Size = new System.Drawing.Size(350, 445);
            this.ultraGroupBox28.TabIndex = 31;
            this.ultraGroupBox28.Text = "Assigned roles";
            this.ultraGroupBox28.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            this.ultraGroupBox28.Visible = false;
            // 
            // ultraGridDMSAssigned
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGridDMSAssigned.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "Role name";
            ultraGridColumn1.Header.VisiblePosition = 1;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Width = 190;
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.DataType = typeof(bool);
            ultraGridColumn6.Header.Caption = "";
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn6.NullText = "DEL";
            ultraGridColumn6.Width = 29;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraGridDMSAssigned.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGridDMSAssigned.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridDMSAssigned.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAssigned.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDMSAssigned.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGridDMSAssigned.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridDMSAssigned.DisplayLayout.GroupByBox.Hidden = true;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDMSAssigned.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGridDMSAssigned.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridDMSAssigned.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGridDMSAssigned.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridDMSAssigned.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGridDMSAssigned.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGridDMSAssigned.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None;
            this.ultraGridDMSAssigned.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.ultraGridDMSAssigned.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGridDMSAssigned.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAssigned.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGridDMSAssigned.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGridDMSAssigned.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGridDMSAssigned.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAssigned.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGridDMSAssigned.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGridDMSAssigned.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGridDMSAssigned.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGridDMSAssigned.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGridDMSAssigned.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridDMSAssigned.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGridDMSAssigned.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridDMSAssigned.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridDMSAssigned.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ultraGridDMSAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ultraGridDMSAssigned.Location = new System.Drawing.Point(3, 282);
            this.ultraGridDMSAssigned.Name = "ultraGridDMSAssigned";
            this.ultraGridDMSAssigned.Size = new System.Drawing.Size(344, 160);
            this.ultraGridDMSAssigned.TabIndex = 30;
            this.ultraGridDMSAssigned.Text = "ultraGrid11";
            // 
            // ultraButtonDMSUnassign
            // 
            this.ultraButtonDMSUnassign.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonDMSUnassign.Location = new System.Drawing.Point(357, 221);
            this.ultraButtonDMSUnassign.Name = "ultraButtonDMSUnassign";
            this.ultraButtonDMSUnassign.Size = new System.Drawing.Size(70, 25);
            this.ultraButtonDMSUnassign.TabIndex = 33;
            this.ultraButtonDMSUnassign.Text = "&Unassign";
            this.ultraButtonDMSUnassign.Visible = false;
            this.ultraButtonDMSUnassign.Click += new System.EventHandler(this.ultraButtonDMSUnassign_Click);
            // 
            // ultraButtonDMSAssign
            // 
            this.ultraButtonDMSAssign.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonDMSAssign.Location = new System.Drawing.Point(357, 179);
            this.ultraButtonDMSAssign.Name = "ultraButtonDMSAssign";
            this.ultraButtonDMSAssign.Size = new System.Drawing.Size(70, 25);
            this.ultraButtonDMSAssign.TabIndex = 32;
            this.ultraButtonDMSAssign.Text = "Ass&ign";
            this.ultraButtonDMSAssign.Visible = false;
            this.ultraButtonDMSAssign.Click += new System.EventHandler(this.ultraButtonDMSAssign_Click);
            // 
            // ultraGroupBox27
            // 
            this.ultraGroupBox27.Controls.Add(this.ultraButtonDMSReset);
            this.ultraGroupBox27.Controls.Add(this.ultraButtonDMSSearch);
            this.ultraGroupBox27.Controls.Add(this.ultraTextEditorDMSDesc);
            this.ultraGroupBox27.Controls.Add(this.ultraLabel72);
            this.ultraGroupBox27.Controls.Add(this.ultraTextEditorDMSRole);
            this.ultraGroupBox27.Controls.Add(this.ultraLabel73);
            this.ultraGroupBox27.Controls.Add(this.ultraGridDMSAllRoles);
            this.ultraGroupBox27.Location = new System.Drawing.Point(0, 169);
            this.ultraGroupBox27.Name = "ultraGroupBox27";
            this.ultraGroupBox27.Size = new System.Drawing.Size(351, 279);
            this.ultraGroupBox27.TabIndex = 30;
            this.ultraGroupBox27.Text = "Available roles";
            this.ultraGroupBox27.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            this.ultraGroupBox27.Visible = false;
            // 
            // ultraButtonDMSReset
            // 
            this.ultraButtonDMSReset.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonDMSReset.Location = new System.Drawing.Point(236, 93);
            this.ultraButtonDMSReset.Name = "ultraButtonDMSReset";
            this.ultraButtonDMSReset.Size = new System.Drawing.Size(87, 25);
            this.ultraButtonDMSReset.TabIndex = 25;
            this.ultraButtonDMSReset.Text = "Reset";
            this.ultraButtonDMSReset.Click += new System.EventHandler(this.ultraButtonDMSReset_Click);
            // 
            // ultraButtonDMSSearch
            // 
            this.ultraButtonDMSSearch.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonDMSSearch.Location = new System.Drawing.Point(138, 93);
            this.ultraButtonDMSSearch.Name = "ultraButtonDMSSearch";
            this.ultraButtonDMSSearch.Size = new System.Drawing.Size(87, 25);
            this.ultraButtonDMSSearch.TabIndex = 24;
            this.ultraButtonDMSSearch.Text = "Search";
            this.ultraButtonDMSSearch.Click += new System.EventHandler(this.ultraButtonDMSSearch_Click);
            // 
            // ultraTextEditorDMSDesc
            // 
            this.ultraTextEditorDMSDesc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.ultraTextEditorDMSDesc.Location = new System.Drawing.Point(106, 63);
            this.ultraTextEditorDMSDesc.Name = "ultraTextEditorDMSDesc";
            this.ultraTextEditorDMSDesc.Size = new System.Drawing.Size(217, 23);
            this.ultraTextEditorDMSDesc.TabIndex = 23;
            // 
            // ultraLabel72
            // 
            appearance322.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel72.Appearance = appearance322;
            this.ultraLabel72.AutoSize = true;
            this.ultraLabel72.Location = new System.Drawing.Point(19, 67);
            this.ultraLabel72.Name = "ultraLabel72";
            this.ultraLabel72.Size = new System.Drawing.Size(65, 16);
            this.ultraLabel72.TabIndex = 22;
            this.ultraLabel72.Text = "Description";
            // 
            // ultraTextEditorDMSRole
            // 
            this.ultraTextEditorDMSRole.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.ultraTextEditorDMSRole.Location = new System.Drawing.Point(106, 34);
            this.ultraTextEditorDMSRole.Name = "ultraTextEditorDMSRole";
            this.ultraTextEditorDMSRole.Size = new System.Drawing.Size(217, 23);
            this.ultraTextEditorDMSRole.TabIndex = 21;
            // 
            // ultraLabel73
            // 
            appearance323.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel73.Appearance = appearance323;
            this.ultraLabel73.AutoSize = true;
            this.ultraLabel73.Location = new System.Drawing.Point(19, 38);
            this.ultraLabel73.Name = "ultraLabel73";
            this.ultraLabel73.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel73.TabIndex = 20;
            this.ultraLabel73.Text = "Role name";
            // 
            // ultraGridDMSAllRoles
            // 
            appearance324.BackColor = System.Drawing.SystemColors.Window;
            appearance324.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGridDMSAllRoles.DisplayLayout.Appearance = appearance324;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.Caption = "Role name";
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 2;
            ultraGridColumn8.Width = 186;
            ultraGridColumn9.Header.VisiblePosition = 3;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 4;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 5;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.DataType = typeof(bool);
            ultraGridColumn12.Header.Caption = "";
            ultraGridColumn12.Header.VisiblePosition = 0;
            ultraGridColumn12.Width = 27;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            this.ultraGridDMSAllRoles.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGridDMSAllRoles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridDMSAllRoles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance325.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance325.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance325.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance325.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAllRoles.DisplayLayout.GroupByBox.Appearance = appearance325;
            appearance326.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDMSAllRoles.DisplayLayout.GroupByBox.BandLabelAppearance = appearance326;
            this.ultraGridDMSAllRoles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridDMSAllRoles.DisplayLayout.GroupByBox.Hidden = true;
            appearance327.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance327.BackColor2 = System.Drawing.SystemColors.Control;
            appearance327.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance327.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDMSAllRoles.DisplayLayout.GroupByBox.PromptAppearance = appearance327;
            this.ultraGridDMSAllRoles.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridDMSAllRoles.DisplayLayout.MaxRowScrollRegions = 1;
            appearance328.BackColor = System.Drawing.SystemColors.Window;
            appearance328.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.ActiveCellAppearance = appearance328;
            appearance329.BackColor = System.Drawing.SystemColors.Highlight;
            appearance329.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.ActiveRowAppearance = appearance329;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance330.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.CardAreaAppearance = appearance330;
            appearance331.BorderColor = System.Drawing.Color.Silver;
            appearance331.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.CellAppearance = appearance331;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.CellPadding = 0;
            appearance332.BackColor = System.Drawing.SystemColors.Control;
            appearance332.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance332.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance332.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance332.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.GroupByRowAppearance = appearance332;
            appearance333.TextHAlignAsString = "Left";
            this.ultraGridDMSAllRoles.DisplayLayout.Override.HeaderAppearance = appearance333;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance334.BackColor = System.Drawing.SystemColors.Window;
            appearance334.BorderColor = System.Drawing.Color.Silver;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.RowAppearance = appearance334;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance335.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridDMSAllRoles.DisplayLayout.Override.TemplateAddRowAppearance = appearance335;
            this.ultraGridDMSAllRoles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridDMSAllRoles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridDMSAllRoles.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ultraGridDMSAllRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ultraGridDMSAllRoles.Location = new System.Drawing.Point(6, 125);
            this.ultraGridDMSAllRoles.Name = "ultraGridDMSAllRoles";
            this.ultraGridDMSAllRoles.Size = new System.Drawing.Size(339, 317);
            this.ultraGridDMSAllRoles.TabIndex = 27;
            this.ultraGridDMSAllRoles.Text = "ultraGrid13";
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.cb_dmsprofiles);
            this.ultraGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(350, 87);
            this.ultraGroupBox1.TabIndex = 34;
            this.ultraGroupBox1.Text = "Assigned role";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // cb_dmsprofiles
            // 
            this.cb_dmsprofiles.DataSource = this.eTTableDataTableBindingSource;
            this.cb_dmsprofiles.DisplayMember = "Description";
            this.cb_dmsprofiles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cb_dmsprofiles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cb_dmsprofiles.Location = new System.Drawing.Point(29, 34);
            this.cb_dmsprofiles.Name = "cb_dmsprofiles";
            this.cb_dmsprofiles.Size = new System.Drawing.Size(310, 23);
            this.cb_dmsprofiles.SyncWithCurrencyManager = false;
            this.cb_dmsprofiles.TabIndex = 0;
            this.cb_dmsprofiles.ValueMember = "RoleName";
            // 
            // eTTableDataTableBindingSource
            // 
            this.eTTableDataTableBindingSource.DataSource = typeof(HiiP.Framework.Security.UserManagement.BusinessEntity.DataSetETRoles.ETTableDataTable);
            // 
            // DMSUserRoleAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.ultraGroupBox28);
            this.Controls.Add(this.ultraButtonDMSUnassign);
            this.Controls.Add(this.ultraButtonDMSAssign);
            this.Controls.Add(this.ultraGroupBox27);
            this.Name = "DMSUserRoleAssignment";
            this.Size = new System.Drawing.Size(789, 451);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox28)).EndInit();
            this.ultraGroupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDMSAssigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox27)).EndInit();
            this.ultraGroupBox27.ResumeLayout(false);
            this.ultraGroupBox27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDMSDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDMSRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDMSAllRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dmsprofiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTTableDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinToolTip.UltraToolTipManager ultraToolTipManager;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox28;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridDMSAssigned;
        private Infragistics.Win.Misc.UltraButton ultraButtonDMSUnassign;
        private Infragistics.Win.Misc.UltraButton ultraButtonDMSAssign;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox27;
        private Infragistics.Win.Misc.UltraButton ultraButtonDMSReset;
        private Infragistics.Win.Misc.UltraButton ultraButtonDMSSearch;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorDMSDesc;
        private Infragistics.Win.Misc.UltraLabel ultraLabel72;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorDMSRole;
        private Infragistics.Win.Misc.UltraLabel ultraLabel73;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridDMSAllRoles;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cb_dmsprofiles;
        private System.Windows.Forms.BindingSource eTTableDataTableBindingSource;
    }
}

