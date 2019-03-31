namespace CallServicePro
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnClearLog = new DevExpress.XtraEditors.SimpleButton();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnStopService = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartService = new DevExpress.XtraEditors.SimpleButton();
            this.btnSet = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnClearLog
            // 
            this.btnClearLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.ImageOptions.Image")));
            this.btnClearLog.Location = new System.Drawing.Point(196, 12);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(86, 33);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 51);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(786, 368);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // btnStopService
            // 
            this.btnStopService.ImageOptions.Image = global::CallServicePro.Properties.Resources.red;
            this.btnStopService.Location = new System.Drawing.Point(104, 12);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(86, 33);
            this.btnStopService.TabIndex = 4;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.ImageOptions.Image = global::CallServicePro.Properties.Resources.green;
            this.btnStartService.Location = new System.Drawing.Point(12, 12);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(86, 33);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "启动服务";
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnSet
            // 
            this.btnSet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.ImageOptions.Image")));
            this.btnSet.Location = new System.Drawing.Point(712, 12);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(86, 32);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "设置";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 431);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnStartService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "叫号服务端";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStartService;
        private DevExpress.XtraEditors.SimpleButton btnClearLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnStopService;
        private DevExpress.XtraEditors.SimpleButton btnSet;
    }
}

