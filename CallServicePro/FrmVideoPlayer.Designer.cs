﻿namespace CallServicePro
{
    partial class FrmVideoPlayer
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideoPlayer));
            this.dtTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblRoomName = new DevExpress.XtraEditors.LabelControl();
            this.lblRootNameBG = new System.Windows.Forms.PictureBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblScrollPlay = new DevExpress.XtraEditors.LabelControl();
            this.spTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CallPatientBox = new DevExpress.XtraEditors.GroupControl();
            this.lblCallInfo = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblWaitCountPatient = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblNextPatient = new DevExpress.XtraEditors.LabelControl();
            this.CurrentPatientBox = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrentInfo = new DevExpress.XtraEditors.LabelControl();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.callPatientTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblRootNameBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CallPatientBox)).BeginInit();
            this.CallPatientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPatientBox)).BeginInit();
            this.CurrentPatientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTimer
            // 
            this.dtTimer.Enabled = true;
            this.dtTimer.Interval = 1000;
            this.dtTimer.Tick += new System.EventHandler(this.dtTimer_Tick);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Appearance.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseTextOptions = true;
            this.lblDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDate.Location = new System.Drawing.Point(728, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(400, 45);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "日期";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseTextOptions = true;
            this.lblTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTime.Location = new System.Drawing.Point(728, 46);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(400, 45);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "时间";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.lblTime);
            this.panelControl1.Controls.Add(this.lblDate);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1128, 120);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.lblRoomName);
            this.groupControl1.Controls.Add(this.lblRootNameBG);
            this.groupControl1.Location = new System.Drawing.Point(400, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 99);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Appearance.Font = new System.Drawing.Font("Tahoma", 35F);
            this.lblRoomName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblRoomName.Appearance.Options.UseBackColor = true;
            this.lblRoomName.Appearance.Options.UseFont = true;
            this.lblRoomName.Appearance.Options.UseForeColor = true;
            this.lblRoomName.Appearance.Options.UseTextOptions = true;
            this.lblRoomName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRoomName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRoomName.Location = new System.Drawing.Point(31, 12);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(261, 60);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "放疗科加速器";
            // 
            // lblRootNameBG
            // 
            this.lblRootNameBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRootNameBG.Image = global::CallServicePro.Properties.Resources.title;
            this.lblRootNameBG.Location = new System.Drawing.Point(0, 0);
            this.lblRootNameBG.Name = "lblRootNameBG";
            this.lblRootNameBG.Size = new System.Drawing.Size(322, 99);
            this.lblRootNameBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblRootNameBG.TabIndex = 2;
            this.lblRootNameBG.TabStop = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::CallServicePro.Properties.Resources.logo;
            this.pictureEdit1.Location = new System.Drawing.Point(3, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(329, 79);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblScrollPlay);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 695);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1128, 45);
            this.panelControl2.TabIndex = 2;
            // 
            // lblScrollPlay
            // 
            this.lblScrollPlay.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblScrollPlay.Appearance.Options.UseFont = true;
            this.lblScrollPlay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblScrollPlay.Location = new System.Drawing.Point(431, 9);
            this.lblScrollPlay.Name = "lblScrollPlay";
            this.lblScrollPlay.Size = new System.Drawing.Size(308, 27);
            this.lblScrollPlay.TabIndex = 0;
            this.lblScrollPlay.Text = "北京大学人民医院放疗科欢迎您";
            // 
            // spTimer
            // 
            this.spTimer.Enabled = true;
            this.spTimer.Interval = 10;
            this.spTimer.Tick += new System.EventHandler(this.spTimer_Tick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 120);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.CallPatientBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.CurrentPatientBox);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.wmPlayer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1128, 575);
            this.splitContainerControl1.SplitterPosition = 420;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // CallPatientBox
            // 
            this.CallPatientBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CallPatientBox.Controls.Add(this.lblCallInfo);
            this.CallPatientBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CallPatientBox.Location = new System.Drawing.Point(0, 429);
            this.CallPatientBox.Name = "CallPatientBox";
            this.CallPatientBox.Size = new System.Drawing.Size(420, 146);
            this.CallPatientBox.TabIndex = 2;
            this.CallPatientBox.Text = "groupControl2";
            // 
            // lblCallInfo
            // 
            this.lblCallInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblCallInfo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCallInfo.Appearance.Options.UseFont = true;
            this.lblCallInfo.Appearance.Options.UseForeColor = true;
            this.lblCallInfo.Appearance.Options.UseTextOptions = true;
            this.lblCallInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCallInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblCallInfo.Location = new System.Drawing.Point(0, 46);
            this.lblCallInfo.Name = "lblCallInfo";
            this.lblCallInfo.Size = new System.Drawing.Size(414, 39);
            this.lblCallInfo.TabIndex = 0;
            this.lblCallInfo.Text = "请某某某到加速器一室治疗";
            // 
            // groupControl4
            // 
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.lblWaitCountPatient);
            this.groupControl4.Location = new System.Drawing.Point(12, 288);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(398, 135);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "groupControl2";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(3, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 49);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "等待人数:";
            // 
            // lblWaitCountPatient
            // 
            this.lblWaitCountPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaitCountPatient.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.lblWaitCountPatient.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblWaitCountPatient.Appearance.Options.UseFont = true;
            this.lblWaitCountPatient.Appearance.Options.UseForeColor = true;
            this.lblWaitCountPatient.Appearance.Options.UseTextOptions = true;
            this.lblWaitCountPatient.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWaitCountPatient.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWaitCountPatient.Location = new System.Drawing.Point(203, 66);
            this.lblWaitCountPatient.Name = "lblWaitCountPatient";
            this.lblWaitCountPatient.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblWaitCountPatient.Size = new System.Drawing.Size(172, 50);
            this.lblWaitCountPatient.TabIndex = 1;
            this.lblWaitCountPatient.Text = "1";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.lblNextPatient);
            this.groupControl3.Location = new System.Drawing.Point(12, 147);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(398, 135);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl2";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(3, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(134, 49);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "准备病人:";
            // 
            // lblNextPatient
            // 
            this.lblNextPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextPatient.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.lblNextPatient.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblNextPatient.Appearance.Options.UseFont = true;
            this.lblNextPatient.Appearance.Options.UseForeColor = true;
            this.lblNextPatient.Appearance.Options.UseTextOptions = true;
            this.lblNextPatient.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNextPatient.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNextPatient.Location = new System.Drawing.Point(203, 70);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblNextPatient.Size = new System.Drawing.Size(172, 50);
            this.lblNextPatient.TabIndex = 1;
            this.lblNextPatient.Text = "某某某";
            // 
            // CurrentPatientBox
            // 
            this.CurrentPatientBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CurrentPatientBox.Controls.Add(this.labelControl2);
            this.CurrentPatientBox.Controls.Add(this.lblCurrentInfo);
            this.CurrentPatientBox.Location = new System.Drawing.Point(12, 6);
            this.CurrentPatientBox.Name = "CurrentPatientBox";
            this.CurrentPatientBox.Size = new System.Drawing.Size(398, 135);
            this.CurrentPatientBox.TabIndex = 2;
            this.CurrentPatientBox.Text = "groupControl2";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(6, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(131, 49);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "当前治疗:";
            // 
            // lblCurrentInfo
            // 
            this.lblCurrentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.lblCurrentInfo.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCurrentInfo.Appearance.Options.UseFont = true;
            this.lblCurrentInfo.Appearance.Options.UseForeColor = true;
            this.lblCurrentInfo.Appearance.Options.UseTextOptions = true;
            this.lblCurrentInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCurrentInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCurrentInfo.Location = new System.Drawing.Point(203, 73);
            this.lblCurrentInfo.Name = "lblCurrentInfo";
            this.lblCurrentInfo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblCurrentInfo.Size = new System.Drawing.Size(172, 50);
            this.lblCurrentInfo.TabIndex = 1;
            this.lblCurrentInfo.Text = "某某某";
            // 
            // wmPlayer
            // 
            this.wmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(0, 0);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(696, 575);
            this.wmPlayer.TabIndex = 0;
            // 
            // callPatientTimer
            // 
            this.callPatientTimer.Tick += new System.EventHandler(this.callPatientTimer_Tick);
            // 
            // FrmVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 740);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVideoPlayer";
            this.Text = "FrmVideoPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVideoPlayer_FormClosing);
            this.Load += new System.EventHandler(this.FrmVideoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblRootNameBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CallPatientBox)).EndInit();
            this.CallPatientBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPatientBox)).EndInit();
            this.CurrentPatientBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer dtTimer;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblScrollPlay;
        private System.Windows.Forms.Timer spTimer;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblRoomName;
        private System.Windows.Forms.PictureBox lblRootNameBG;
        private DevExpress.XtraEditors.GroupControl CurrentPatientBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblCurrentInfo;
        private DevExpress.XtraEditors.GroupControl CallPatientBox;
        private DevExpress.XtraEditors.LabelControl lblCallInfo;
        private System.Windows.Forms.Timer callPatientTimer;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblNextPatient;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblWaitCountPatient;
    }
}