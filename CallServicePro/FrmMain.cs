using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallServicePro
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        FrmVideoPlayer frmVideo;
        public FrmMain()
        {
            InitializeComponent();
            btnStopService.Enabled = false;
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            btnStartService.Enabled = false;
            btnStopService.Enabled = true;
            frmVideo = new FrmVideoPlayer();
            frmVideo.Show();
            ShowMsg("叫号服务已启动");
           
        }

        

        void ShowMsg(String str)
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            txtLog.AppendText(year+ "\\"+ mouth + "\\" + day + " " + hour + ":" + minute + ":" + second + "  "+str + "\r\n");
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            frmVideo.Close();
            ShowMsg("叫号服务已停止");
            btnStartService.Enabled = true;
            btnStopService.Enabled = false;
        }
    }
}
