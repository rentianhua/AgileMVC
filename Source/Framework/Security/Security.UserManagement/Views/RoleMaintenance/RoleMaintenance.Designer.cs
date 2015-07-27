
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
    partial class RoleMaintenance
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private RoleMaintenancePresenter _presenter = null;

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
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Role Name");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.btn_search = new Infragistics.Win.Misc.UltraButton();
            this.btn_reset = new Infragistics.Win.Misc.UltraButton();
            this.txt_description = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel45 = new Infragistics.Win.Misc.UltraLabel();
            this.txt_rolename = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel46 = new Infragistics.Win.Misc.UltraLabel();
            this.closeButton = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ug_rolelist = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.lbl_rolecount = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rolename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ug_rolelist)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox1.Controls.Add(this.btn_search);
            this.ultraGroupBox1.Controls.Add(this.btn_reset);
            this.ultraGroupBox1.Controls.Add(this.txt_description);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel45);
            this.ultraGroupBox1.Controls.Add(this.txt_rolename);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel46);
            this.ultraGroupBox1.Location = new System.Drawing.Point(8, 9);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(917, 71);
            this.ultraGroupBox1.TabIndex = 8;
            this.ultraGroupBox1.Text = "Search criteria";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // btn_search
            // 
            this.btn_search.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btn_search.Location = new System.Drawing.Point(552, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 25);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "&Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btn_reset.Location = new System.Drawing.Point(646, 30);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 25);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "&Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_description
            // 
            this.txt_description.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txt_description.Location = new System.Drawing.Point(358, 30);
            this.txt_description.MaxLength = 128;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(187, 23);
            this.txt_description.TabIndex = 2;
            // 
            // ultraLabel45
            // 
            appearance12.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance12.TextHAlignAsString = "Right";
            this.ultraLabel45.Appearance = appearance12;
            this.ultraLabel45.Location = new System.Drawing.Point(272, 34);
            this.ultraLabel45.Name = "ultraLabel45";
            this.ultraLabel45.Size = new System.Drawing.Size(85, 25);
            this.ultraLabel45.TabIndex = 26;
            this.ultraLabel45.Text = "Description";
            // 
            // txt_rolename
            // 
            this.txt_rolename.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txt_rolename.Location = new System.Drawing.Point(78, 30);
            this.txt_rolename.MaxLength = 128;
            this.txt_rolename.Name = "txt_rolename";
            this.txt_rolename.Size = new System.Drawing.Size(187, 23);
            this.txt_rolename.TabIndex = 1;
            // 
            // ultraLabel46
            // 
            appearance17.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance17.TextHAlignAsString = "Right";
            this.ultraLabel46.Appearance = appearance17;
            this.ultraLabel46.Location = new System.Drawing.Point(0, 34);
            this.ultraLabel46.Name = "ultraLabel46";
            this.ultraLabel46.Size = new System.Drawing.Size(75, 25);
            this.ultraLabel46.TabIndex = 24;
            this.ultraLabel46.Text = "Role name";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.closeButton.Location = new System.Drawing.Point(838, 611);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 25);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "&Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox2.Controls.Add(this.ug_rolelist);
            this.ultraGroupBox2.Controls.Add(this.lbl_rolecount);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox2.Location = new System.Drawing.Point(8, 86);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(917, 518);
            this.ultraGroupBox2.TabIndex = 9;
            this.ultraGroupBox2.Text = "Search result";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ug_rolelist
            // 
            this.ug_rolelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ug_rolelist.DisplayLayout.Appearance = appearance16;
            this.ug_rolelist.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "Role name";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 208;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 259;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 91;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.ug_rolelist.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ug_rolelist.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ug_rolelist.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance18.BorderColor = System.Drawing.SystemColors.Window;
            this.ug_rolelist.DisplayLayout.GroupByBox.Appearance = appearance18;
            appearance19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ug_rolelist.DisplayLayout.GroupByBox.BandLabelAppearance = appearance19;
            this.ug_rolelist.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance20.BackColor2 = System.Drawing.SystemColors.Control;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ug_rolelist.DisplayLayout.GroupByBox.PromptAppearance = appearance20;
            this.ug_rolelist.DisplayLayout.MaxColScrollRegions = 1;
            this.ug_rolelist.DisplayLayout.MaxRowScrollRegions = 1;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            appearance21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ug_rolelist.DisplayLayout.Override.ActiveCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.Highlight;
            appearance22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ug_rolelist.DisplayLayout.Override.ActiveRowAppearance = appearance22;
            this.ug_rolelist.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ug_rolelist.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ug_rolelist.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ug_rolelist.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ug_rolelist.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ug_rolelist.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            this.ug_rolelist.DisplayLayout.Override.CardAreaAppearance = appearance23;
            appearance24.BorderColor = System.Drawing.Color.Silver;
            appearance24.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ug_rolelist.DisplayLayout.Override.CellAppearance = appearance24;
            this.ug_rolelist.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ug_rolelist.DisplayLayout.Override.CellPadding = 0;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance25.BorderColor = System.Drawing.SystemColors.Window;
            this.ug_rolelist.DisplayLayout.Override.GroupByRowAppearance = appearance25;
            appearance26.TextHAlignAsString = "Left";
            this.ug_rolelist.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ug_rolelist.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ug_rolelist.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance27.BackColor = System.Drawing.SystemColors.Window;
            appearance27.BorderColor = System.Drawing.Color.Silver;
            this.ug_rolelist.DisplayLayout.Override.RowAppearance = appearance27;
            this.ug_rolelist.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ug_rolelist.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed;
            this.ug_rolelist.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ug_rolelist.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            appearance28.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ug_rolelist.DisplayLayout.Override.TemplateAddRowAppearance = appearance28;
            this.ug_rolelist.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ug_rolelist.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ug_rolelist.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ug_rolelist.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ug_rolelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ug_rolelist.Location = new System.Drawing.Point(14, 51);
            this.ug_rolelist.Name = "ug_rolelist";
            this.ug_rolelist.Size = new System.Drawing.Size(887, 449);
            this.ug_rolelist.TabIndex = 5;
            this.ug_rolelist.Text = "ultraGrid7";
            this.ug_rolelist.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.ug_rolelist_DoubleClickCell);
            this.ug_rolelist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ug_rolelist_KeyDown);
            // 
            // lbl_rolecount
            // 
            appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.lbl_rolecount.Appearance = appearance1;
            this.lbl_rolecount.Location = new System.Drawing.Point(112, 29);
            this.lbl_rolecount.Name = "lbl_rolecount";
            this.lbl_rolecount.Size = new System.Drawing.Size(75, 25);
            this.lbl_rolecount.TabIndex = 30;
            this.lbl_rolecount.Text = "0";
            // 
            // ultraLabel1
            // 
            appearance10.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel1.Appearance = appearance10;
            this.ultraLabel1.Location = new System.Drawing.Point(14, 28);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(101, 25);
            this.ultraLabel1.TabIndex = 30;
            this.ultraLabel1.Text = "Total record(s):";
            // 
            // RoleMaintenance
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.closeButton;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Key = "SearchRole";
            this.Name = "RoleMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rolename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ug_rolelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton btn_search;
        private Infragistics.Win.Misc.UltraButton btn_reset;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor txt_description;
        private Infragistics.Win.Misc.UltraLabel ultraLabel45;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor txt_rolename;
        private Infragistics.Win.Misc.UltraLabel ultraLabel46;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ug_rolelist;
        private Infragistics.Win.Misc.UltraLabel lbl_rolecount;
        private Infragistics.Win.Misc.UltraButton closeButton;
    }
}

