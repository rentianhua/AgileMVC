
//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// For more information see: 
// ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-09-010-ModelViewPresenter_MVP.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace HiiP.Framework.Settings
{
    partial class CodeTableDetailView
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private HiiP.Framework.Settings.CodeTableDetailViewPresenter _presenter = null;

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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ultraDateTimeEndTime = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.tICCODERowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDateTimeStartTime = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorSeq = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorRemark = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorDesc = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorCode = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelCategory = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorID = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraComboCategory = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ultraButtonCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonSave = new Infragistics.Win.Misc.UltraButton();
            this.validationProvider = new Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICCODERowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCategory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraGroupBox1.Appearance = appearance2;
            this.ultraGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(660, 485);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Code detail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ultraDateTimeEndTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ultraDateTimeStartTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditorSeq, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditorRemark, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditorDesc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditorCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabelCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ultraTextEditorID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ultraComboCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ultraLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ultraDateTimeEndTime
            // 
            this.ultraDateTimeEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraDateTimeEndTime.DataBindings.Add(new System.Windows.Forms.Binding("DateTime", this.tICCODERowBindingSource, "EFFECTIVE_END_DATE", true));
            this.ultraDateTimeEndTime.DateTime = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEndTime.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.ultraDateTimeEndTime.Location = new System.Drawing.Point(103, 119);
            this.ultraDateTimeEndTime.MaskInput = "{date} ";
            this.ultraDateTimeEndTime.Name = "ultraDateTimeEndTime";
            this.validationProvider.SetPerformValidation(this.ultraDateTimeEndTime, true);
            this.ultraDateTimeEndTime.Size = new System.Drawing.Size(145, 23);
            this.validationProvider.SetSourcePropertyName(this.ultraDateTimeEndTime, "EFFECTIVE_END_DATE");
            this.ultraDateTimeEndTime.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeEndTime.TabIndex = 9;
            this.validationProvider.SetValidatedProperty(this.ultraDateTimeEndTime, "DateTime");
            this.ultraDateTimeEndTime.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ultraDateTimeEndTime.Leave += new System.EventHandler(this.OnLeave);
            // 
            // tICCODERowBindingSource
            // 
            this.tICCODERowBindingSource.DataSource = typeof(NCS.IConnect.CodeTable.CodeTableDataSet.T_IC_CODERow);
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance7.TextHAlignAsString = "Right";
            this.ultraLabel8.Appearance = appearance7;
            this.ultraLabel8.AutoSize = true;
            this.ultraLabel8.Location = new System.Drawing.Point(33, 122);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(64, 16);
            this.ultraLabel8.TabIndex = 8;
            this.ultraLabel8.Text = "* End date";
            // 
            // ultraDateTimeStartTime
            // 
            this.ultraDateTimeStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraDateTimeStartTime.DataBindings.Add(new System.Windows.Forms.Binding("DateTime", this.tICCODERowBindingSource, "EFFECTIVE_START_DATE", true));
            this.ultraDateTimeStartTime.DateTime = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeStartTime.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.ultraDateTimeStartTime.Location = new System.Drawing.Point(103, 90);
            this.ultraDateTimeStartTime.MaskInput = "{date} ";
            this.ultraDateTimeStartTime.Name = "ultraDateTimeStartTime";
            this.validationProvider.SetPerformValidation(this.ultraDateTimeStartTime, true);
            this.ultraDateTimeStartTime.Size = new System.Drawing.Size(145, 23);
            this.validationProvider.SetSourcePropertyName(this.ultraDateTimeStartTime, "EFFECTIVE_START_DATE");
            this.ultraDateTimeStartTime.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraDateTimeStartTime.TabIndex = 7;
            this.validationProvider.SetValidatedProperty(this.ultraDateTimeStartTime, "DateTime");
            this.ultraDateTimeStartTime.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ultraDateTimeStartTime.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance6.TextHAlignAsString = "Right";
            this.ultraLabel7.Appearance = appearance6;
            this.ultraLabel7.AutoSize = true;
            this.ultraLabel7.Location = new System.Drawing.Point(28, 93);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(69, 16);
            this.ultraLabel7.TabIndex = 6;
            this.ultraLabel7.Text = "* Start date";
            // 
            // ultraTextEditorSeq
            // 
            this.ultraTextEditorSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraTextEditorSeq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICCODERowBindingSource, "CODE_SEQ", true));
            this.ultraTextEditorSeq.Location = new System.Drawing.Point(103, 270);
            this.ultraTextEditorSeq.Name = "ultraTextEditorSeq";
            this.validationProvider.SetPerformValidation(this.ultraTextEditorSeq, true);
            this.ultraTextEditorSeq.Size = new System.Drawing.Size(355, 23);
            this.validationProvider.SetSourcePropertyName(this.ultraTextEditorSeq, "CODE_SEQ");
            this.ultraTextEditorSeq.TabIndex = 13;
            this.ultraTextEditorSeq.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ultraLabel6.AutoSize = true;
            this.ultraLabel6.Location = new System.Drawing.Point(40, 273);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(57, 16);
            this.ultraLabel6.TabIndex = 12;
            this.ultraLabel6.Text = "Sequence";
            // 
            // ultraTextEditorRemark
            // 
            this.ultraTextEditorRemark.AcceptsReturn = true;
            this.ultraTextEditorRemark.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraTextEditorRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICCODERowBindingSource, "CODE_REMARKS", true));
            this.ultraTextEditorRemark.Location = new System.Drawing.Point(103, 299);
            this.ultraTextEditorRemark.Multiline = true;
            this.ultraTextEditorRemark.Name = "ultraTextEditorRemark";
            this.ultraTextEditorRemark.Size = new System.Drawing.Size(355, 116);
            this.ultraTextEditorRemark.TabIndex = 15;
            this.ultraTextEditorRemark.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.AutoSize = true;
            this.ultraLabel5.Location = new System.Drawing.Point(51, 299);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(46, 16);
            this.ultraLabel5.TabIndex = 14;
            this.ultraLabel5.Text = "Remark";
            // 
            // ultraTextEditorDesc
            // 
            this.ultraTextEditorDesc.AcceptsReturn = true;
            this.ultraTextEditorDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraTextEditorDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICCODERowBindingSource, "CODE_DESC", true));
            this.ultraTextEditorDesc.Location = new System.Drawing.Point(103, 148);
            this.ultraTextEditorDesc.Multiline = true;
            this.ultraTextEditorDesc.Name = "ultraTextEditorDesc";
            this.validationProvider.SetPerformValidation(this.ultraTextEditorDesc, true);
            this.ultraTextEditorDesc.Size = new System.Drawing.Size(355, 116);
            this.validationProvider.SetSourcePropertyName(this.ultraTextEditorDesc, "CODE_DESC");
            this.ultraTextEditorDesc.TabIndex = 11;
            this.ultraTextEditorDesc.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance8.TextHAlignAsString = "Right";
            this.ultraLabel4.Appearance = appearance8;
            this.ultraLabel4.AutoSize = true;
            this.ultraLabel4.Location = new System.Drawing.Point(21, 148);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(76, 16);
            this.ultraLabel4.TabIndex = 10;
            this.ultraLabel4.Text = "* Description";
            // 
            // ultraTextEditorCode
            // 
            this.ultraTextEditorCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraTextEditorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICCODERowBindingSource, "CODE", true));
            this.ultraTextEditorCode.Location = new System.Drawing.Point(103, 61);
            this.ultraTextEditorCode.Name = "ultraTextEditorCode";
            this.validationProvider.SetPerformValidation(this.ultraTextEditorCode, true);
            this.ultraTextEditorCode.ReadOnly = true;
            this.ultraTextEditorCode.Size = new System.Drawing.Size(355, 23);
            this.validationProvider.SetSourcePropertyName(this.ultraTextEditorCode, "CODE");
            this.ultraTextEditorCode.TabIndex = 5;
            this.ultraTextEditorCode.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance5.TextHAlignAsString = "Right";
            this.ultraLabel3.Appearance = appearance5;
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(54, 64);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(43, 16);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "* Code";
            // 
            // ultraLabelCategory
            // 
            this.ultraLabelCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance4.TextHAlignAsString = "Right";
            this.ultraLabelCategory.Appearance = appearance4;
            this.ultraLabelCategory.AutoSize = true;
            this.ultraLabelCategory.Location = new System.Drawing.Point(33, 35);
            this.ultraLabelCategory.Name = "ultraLabelCategory";
            this.ultraLabelCategory.Size = new System.Drawing.Size(64, 16);
            this.ultraLabelCategory.TabIndex = 2;
            this.ultraLabelCategory.Text = "* Category";
            // 
            // ultraTextEditorID
            // 
            this.ultraTextEditorID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraTextEditorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICCODERowBindingSource, "CODE_ID", true));
            this.ultraTextEditorID.Location = new System.Drawing.Point(103, 3);
            this.ultraTextEditorID.Name = "ultraTextEditorID";
            this.ultraTextEditorID.ReadOnly = true;
            this.ultraTextEditorID.Size = new System.Drawing.Size(355, 23);
            this.ultraTextEditorID.TabIndex = 1;
            this.ultraTextEditorID.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraComboCategory
            // 
            this.ultraComboCategory.AlwaysInEditMode = true;
            this.ultraComboCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ultraComboCategory.AutoComplete = true;
            this.ultraComboCategory.Location = new System.Drawing.Point(103, 32);
            this.ultraComboCategory.Name = "ultraComboCategory";
            this.validationProvider.SetPerformValidation(this.ultraComboCategory, true);
            this.ultraComboCategory.Size = new System.Drawing.Size(355, 23);
            this.validationProvider.SetSourcePropertyName(this.ultraComboCategory, "CODE_CATEGORY");
            this.ultraComboCategory.SyncWithCurrencyManager = false;
            this.ultraComboCategory.TabIndex = 3;
            this.ultraComboCategory.Leave += new System.EventHandler(this.OnLeave);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel1.Appearance = appearance3;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(80, 6);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(17, 16);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraButtonCancel);
            this.panel1.Controls.Add(this.ultraButtonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 40);
            this.panel1.TabIndex = 16;
            // 
            // ultraButtonCancel
            // 
            this.ultraButtonCancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonCancel.Location = new System.Drawing.Point(280, 3);
            this.ultraButtonCancel.Name = "ultraButtonCancel";
            this.ultraButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonCancel.TabIndex = 2;
            this.ultraButtonCancel.Text = "&Cancel";
            this.ultraButtonCancel.Click += new System.EventHandler(this.ultraButtonCancel_Click);
            // 
            // ultraButtonSave
            // 
            this.ultraButtonSave.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.ultraButtonSave.Location = new System.Drawing.Point(199, 3);
            this.ultraButtonSave.Name = "ultraButtonSave";
            this.ultraButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonSave.TabIndex = 1;
            this.ultraButtonSave.Text = "&Save";
            this.ultraButtonSave.Click += new System.EventHandler(this.ultraButtonSave_Click);
            // 
            // validationProvider
            // 
            this.validationProvider.ErrorProvider = this.errorProvider;
            this.validationProvider.RulesetName = "CodeTableValidate";
            this.validationProvider.SourceTypeName = "NCS.IConnect.CodeTable.CodeTableDataSet+T_IC_CODERow,NCS.IConnect.CodeTable";
            this.validationProvider.ValueConvert += new System.EventHandler<Microsoft.Practices.EnterpriseLibrary.Validation.Integration.ValueConvertEventArgs>(this.validationProvider_ValueConvert);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CodeTableDetailView
            // 
            this.AcceptButton = this.ultraButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ultraButtonCancel;
            this.CheckDirtyRequired = true;
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "CodeTableDetailView";
            this.Size = new System.Drawing.Size(660, 485);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICCODERowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton ultraButtonSave;
        private Infragistics.Win.Misc.UltraButton ultraButtonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEndTime;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeStartTime;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorSeq;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorRemark;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorDesc;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorCode;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabelCategory;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor ultraTextEditorID;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboCategory;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.BindingSource tICCODERowBindingSource;
        private Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider validationProvider;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;

    }
}
