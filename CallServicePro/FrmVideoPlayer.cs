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
using System.Threading;
using System.Speech.Synthesis;
using System.Speech;

namespace CallServicePro
{
    public partial class FrmVideoPlayer : DevExpress.XtraEditors.XtraForm
    {
        private string serverIP= ConfigurationManager.AppSettings["ServerIP"];
        private string serverPort = ConfigurationManager.AppSettings["ServerPort"];
        private string serverListen = ConfigurationManager.AppSettings["ServerListen"];
        private bool isAnimation = Convert.ToBoolean(ConfigurationManager.AppSettings["IsAnimation"]);
        private string roomName = ConfigurationManager.AppSettings["RoomName"];

        //声明一个用于监听连接的Socket
        private Socket socketWatch;
        //声明一个用于通信发送信息的Socket
        private Socket socketSend;

        
        
        //向主窗体发送日志信息委托变量 
        public ShowMsgDelegate msgDelegate;
        public FrmVideoPlayer()
        {
            InitializeComponent();
           
            //初始化日期时间数据
            InitDateTime();
           
            //给Split左侧Pancel1设置背景颜色
            splitContainerControl1.Panel1.BackColor = Color.FromArgb(0, 71, 182);
            //科室名称
            lblRoomName.Text = roomName;
            lblRoomName.BackColor = Color.Transparent;
            lblRoomName.Parent = lblRootNameBG;
            if (isAnimation) { callPatientTimer.Enabled = true; };

            
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
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(serverIP);
            IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(serverPort));
            //【第二步】绑定监听端口
            socketWatch.Bind(port);
            //【第三步】Listen
            socketWatch.Listen(Convert.ToInt32(serverListen));

            Thread th = new Thread(SocketAccept);
            th.IsBackground = true;
            th.Start(socketWatch);
            msgDelegate("叫号服务已启动，等待客户端连接");
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
                try
                {
                    socketSend = socket.Accept();

                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch (Exception)
                {

                    
                }
                
            }
        }
        /// <summary>
        /// 服务器端不停的接收客户端发来的消息
        /// 接收协议： 
        ///         0 叫号信息
        ///         1 当前病人
        ///         2 准备病人
        ///         3 等待人数
        /// </summary>
        /// <param name="o"></param>
        private void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                //实际接收到的有效字节数
                int r = socketSend.Receive(buffer);
                if (r == 0) break;
                string str = Encoding.UTF8.GetString(buffer, 0, r);
                msgDelegate(socketSend.RemoteEndPoint.ToString() + ":" + str);
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
            //上下滚动
            lblCallInfo.Top += 1;
            if (lblCallInfo.Bottom > CallPatientBox.Height)
            {
                lblCallInfo.Top = 0;
            }

        }
       
        /// <summary>
        /// 扩展屏显示
        /// </summary>
        private void ShowExpansionScreen()
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
        }

        private void FrmVideoPlayer_Load(object sender, EventArgs e)
        {
            //初始化Socket
            InitSocket();
            wmPlayer.stretchToFit = true;
            string path = @"‪C:\Users\Administrator\Desktop\1.avi";
            wmPlayer.openPlayer(path);

        }

        
        /// <summary>
        /// 语音叫号
        /// </summary>
        /// <param name="text">朗读的文本</param>
        /// <param name="speechnum">朗读次数</param>
        /// <param name="rate">语速 取值范围:[-10,10]</param>
        /// <param name="volume">音量 取值范围：[0,100]</param>
        public static void CallPaitent(string text, int speechnum = 2, int rate = 0, int volume = 100)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer
            {
                Rate = rate,
                Volume = volume,
            };
            for (int i = 1; i <= speechnum; i++)
            {
                speech.Speak(text);
            }

        }

        private void FrmVideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(socketWatch != null)
            {
                socketWatch.Close();
            }
            if(socketSend != null)
            {
                socketSend.Close();
            }
        }
    }
}