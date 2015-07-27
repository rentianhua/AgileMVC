
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

namespace HiiP.Framework.Security.SessionManagement
{
    partial class FilterSessionView
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private FilterSessionPresenter _presenter;

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
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.dt_lastactivetime_end = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.dt_lastactivetime_start = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.txt_host = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.dt_logintime_end = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.dt_logintime_start = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txt_ipAddress = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.txt_userName = new HiiP.Framework.Common.Client.ExtendedUltraTextEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btn_cancel = new Infragistics.Win.Misc.UltraButton();
            this.btn_ok = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lastactivetime_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lastactivetime_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_host)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_logintime_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_logintime_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ipAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox3);
            this.ultraGroupBox1.Controls.Add(this.txt_host);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel5);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Controls.Add(this.txt_ipAddress);
            this.ultraGroupBox1.Controls.Add(this.txt_userName);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel4);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox1.Location = new System.Drawing.Point(16, 15);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(271, 331);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.dt_lastactivetime_end);
            this.ultraGroupBox3.Controls.Add(this.ultraLabel6);
            this.ultraGroupBox3.Controls.Add(this.dt_lastactivetime_start);
            this.ultraGroupBox3.Controls.Add(this.ultraLabel7);
            this.ultraGroupBox3.Location = new System.Drawing.Point(12, 216);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(241, 101);
            this.ultraGroupBox3.TabIndex = 21;
            this.ultraGroupBox3.Text = "Last Active Time";
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // dt_lastactivetime_end
            // 
            this.dt_lastactivetime_end.DateTime = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_lastactivetime_end.FormatString = "dd/MM/yyyy hh:mm";
            this.dt_lastactivetime_end.Location = new System.Drawing.Point(77, 60);
            this.dt_lastactivetime_end.Name = "dt_lastactivetime_end";
            this.dt_lastactivetime_end.Size = new System.Drawing.Size(156, 23);
            this.dt_lastactivetime_end.TabIndex = 19;
            this.dt_lastactivetime_end.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // ultraLabel6
            // 
            appearance7.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel6.Appearance = appearance7;
            this.ultraLabel6.Location = new System.Drawing.Point(14, 64);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel6.Size = new System.Drawing.Size(36, 18);
            this.ultraLabel6.TabIndex = 18;
            this.ultraLabel6.Text = "End";
            // 
            // dt_lastactivetime_start
            // 
            this.dt_lastactivetime_start.FormatString = "dd/MM/yyyy hh:mm";
            this.dt_lastactivetime_start.Location = new System.Drawing.Point(78, 31);
            this.dt_lastactivetime_start.Name = "dt_lastactivetime_start";
            this.dt_lastactivetime_start.Size = new System.Drawing.Size(156, 23);
            this.dt_lastactivetime_start.TabIndex = 17;
            this.dt_lastactivetime_start.Value = null;
            // 
            // ultraLabel7
            // 
            appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel7.Appearance = appearance1;
            this.ultraLabel7.Location = new System.Drawing.Point(14, 36);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel7.Size = new System.Drawing.Size(35, 18);
            this.ultraLabel7.TabIndex = 16;
            this.ultraLabel7.Text = "Start";
            // 
            // txt_host
            // 
            this.txt_host.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txt_host.Location = new System.Drawing.Point(90, 80);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(163, 23);
            this.txt_host.TabIndex = 20;
            // 
            // ultraLabel5
            // 
            appearance3.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel5.Appearance = appearance3;
            this.ultraLabel5.Location = new System.Drawing.Point(12, 83);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(41, 18);
            this.ultraLabel5.TabIndex = 19;
            this.ultraLabel5.Text = "Host";
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.dt_logintime_end);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel3);
            this.ultraGroupBox2.Controls.Add(this.dt_logintime_start);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel2);
            this.ultraGroupBox2.Location = new System.Drawing.Point(12, 109);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(241, 101);
            this.ultraGroupBox2.TabIndex = 18;
            this.ultraGroupBox2.Text = "Login Time";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // dt_logintime_end
            // 
            this.dt_logintime_end.DateTime = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_logintime_end.FormatString = "dd/MM/yyyy hh:mm";
            this.dt_logintime_end.Location = new System.Drawing.Point(77, 60);
            this.dt_logintime_end.Name = "dt_logintime_end";
            this.dt_logintime_end.Size = new System.Drawing.Size(156, 23);
            this.dt_logintime_end.TabIndex = 19;
            this.dt_logintime_end.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // ultraLabel3
            // 
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel3.Appearance = appearance5;
            this.ultraLabel3.Location = new System.Drawing.Point(14, 64);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel3.Size = new System.Drawing.Size(36, 18);
            this.ultraLabel3.TabIndex = 18;
            this.ultraLabel3.Text = "End";
            // 
            // dt_logintime_start
            // 
            this.dt_logintime_start.FormatString = "dd/MM/yyyy hh:mm";
            this.dt_logintime_start.Location = new System.Drawing.Point(78, 31);
            this.dt_logintime_start.Name = "dt_logintime_start";
            this.dt_logintime_start.Size = new System.Drawing.Size(156, 23);
            this.dt_logintime_start.TabIndex = 17;
            this.dt_logintime_start.Value = null;
            // 
            // ultraLabel2
            // 
            appearance6.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel2.Appearance = appearance6;
            this.ultraLabel2.Location = new System.Drawing.Point(14, 36);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel2.Size = new System.Drawing.Size(35, 18);
            this.ultraLabel2.TabIndex = 16;
            this.ultraLabel2.Text = "Start";
            // 
            // txt_ipAddress
            // 
            this.txt_ipAddress.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txt_ipAddress.Location = new System.Drawing.Point(90, 51);
            this.txt_ipAddress.Name = "txt_ipAddress";
            this.txt_ipAddress.Size = new System.Drawing.Size(163, 23);
            this.txt_ipAddress.TabIndex = 16;
            // 
            // txt_userName
            // 
            this.txt_userName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txt_userName.Location = new System.Drawing.Point(90, 19);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(163, 23);
            this.txt_userName.TabIndex = 15;
            // 
            // ultraLabel4
            // 
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel4.Appearance = appearance2;
            this.ultraLabel4.Location = new System.Drawing.Point(12, 55);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(73, 18);
            this.ultraLabel4.TabIndex = 13;
            this.ultraLabel4.Text = "IP Address";
            // 
            // ultraLabel1
            // 
            appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraLabel1.Appearance = appearance4;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 24);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel1.Size = new System.Drawing.Size(73, 18);
            this.ultraLabel1.TabIndex = 12;
            this.ultraLabel1.Text = "User Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btn_cancel.Location = new System.Drawing.Point(199, 352);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 25);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btn_ok.Location = new System.Drawing.Point(105, 352);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 25);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FilterSessionView
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.CancelButton = this.btn_cancel;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "FilterSessionView";
            this.Size = new System.Drawing.Size(306, 391);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ultraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lastactivetime_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lastactivetime_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_host)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_logintime_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_logintime_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ipAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton btn_cancel;
        private Infragistics.Win.Misc.UltraButton btn_ok;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor txt_ipAddress;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor txt_userName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dt_logintime_end;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dt_logintime_start;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private HiiP.Framework.Common.Client.ExtendedUltraTextEditor txt_host;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dt_lastactivetime_end;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dt_lastactivetime_start;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
    }
}
