using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Sockets;
using System.Net;
using System.Configuration;

namespace CallServicePro
{
    public partial class FrmVideoPlayer : DevExpress.XtraEditors.XtraForm
    {
        private string ServerIP= ConfigurationManager.AppSettings["ServerIP"];
        private string ServerPort = ConfigurationManager.AppSettings["ServerPort"];
        private string ServerListen = ConfigurationManager.AppSettings["ServerListen"];
        //声明一个用于连接通信的Socket
        private Socket socketSend;
        //向主窗体发送日志信息委托变量
        public ShowMsgDelegate MsgDelegate;
        public FrmVideoPlayer()
        {
            InitializeComponent();
           
            //初始化日期时间数据
            InitDateTime();

            //初始化Split
            splitContainerControl1.Panel1.BackColor = Color.FromArgb(0, 71, 182);
            lblRoomName.BackColor = Color.Transparent;
            lblRoomName.Parent = lblRootNameBG;
            

        }
        
        /// <summary>
        /// UI中初始化日期时间
        /// </summary>
        void InitDateTime()
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
          
            lblTime.Text = hour + ":" + minute + ":" + second;
            lblDate.Text = year + "-" + mouth + "-" + day;
        }

        /// <summary>
        /// 初始化Socket服务端
        /// </summary>
        void InitSocket()
        {
            //【第一步】创建一个监听的socket
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(ServerIP);
            IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(ServerPort));
            //【第二步】绑定监听端口
            socket.Bind(port);
            //【第三步】Listen
            socket.Listen(Convert.ToInt32(ServerListen));
        }

        
        

        /// <summary>
        /// 循环等待客户端的连接
        /// </summary>
        /// <param name="s">Socket对象</param>
        void SocketAccept(object s)
        {
            Socket socket = s as Socket;

            while (true)
            {
                socketSend = socket.Accept();
            }
        }

        /// <summary>
        /// 实时获取日期时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtTimer_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            //string a = 条件？true:false;
            lblTime.Text = hour + ":" + minute + ":" + second;
            lblDate.Text = year + "-" + mouth + "-" + day;
        }

        /// <summary>
        /// 状态栏滚动播放文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spTimer_Tick(object sender, EventArgs e)
        {
            lblScrollPlay.Left -= 1;
            if (lblScrollPlay.Right < 0)
            {
                lblScrollPlay.Left = this.Width;
            }

        }
        /// <summary>
        /// 滚动叫号文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void callPatientTimer_Tick(object sender, EventArgs e)
        {
            lblCallInfo.Top += 1;
            if (lblCallInfo.Bottom > CallPatientBox.Height)
            {
                lblCallInfo.Top = 0;
            }
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //g.DrawImage(new Bitmap(Properties.Resources.title), 0, 0);
        }

        private void FrmVideoPlayer_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}