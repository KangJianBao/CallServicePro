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
            this.btnStartService = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearLog = new DevExpress.XtraEditors.SimpleButton();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnStopService = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(12, 12);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(86, 33);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "启动服务";
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(196, 12);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(86, 33);
            this.btnClearLog.TabIndex = 0;
            this.btnClearLog.Text = "清空日志";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 51);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(463, 250);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(104, 12);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(86, 33);
            this.btnStopService.TabIndex = 4;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 323);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnStartService);
            this.Name = "FrmMain";
            this.Text = "叫号服务端";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStartService;
        private DevExpress.XtraEditors.SimpleButton btnClearLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnStopService;
    }
}

