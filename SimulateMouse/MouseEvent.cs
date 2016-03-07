using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;
using mshtml;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace SimulateMouse
{
    public partial class MouseEvent : Form
    {
        public MouseEvent()
        {
            InitializeComponent();
        }

        //结构体布局 本机位置
        [StructLayout(LayoutKind.Sequential)]
        struct NativeRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        //将枚举作为位域处理
        [Flags]
        enum MouseEventFlag : uint //设置鼠标动作的键值
        {
            Move = 0x0001,               //发生移动
            LeftDown = 0x0002,           //鼠标按下左键
            LeftUp = 0x0004,             //鼠标松开左键
            RightDown = 0x0008,          //鼠标按下右键
            RightUp = 0x0010,            //鼠标松开右键
            MiddleDown = 0x0020,         //鼠标按下中键
            MiddleUp = 0x0040,           //鼠标松开中键
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,              //鼠标轮被移动
            VirtualDesk = 0x4000,        //虚拟桌面
            Absolute = 0x8000
        }

        private string code = string.Empty;
        private byte[] picData = null;
        public delegate void NaviToPage();
        public delegate void InputMessage(object info);

        const string MyPhoneNum = "15810230925";
        const string MyPassWord = "xhb198992566";
        Thread th1 = null;
        Thread th2 = null;
        #region MyRegion
        /*
        

        //设置鼠标位置
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        //设置鼠标按键和动作
        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy,
            uint data, UIntPtr extraInfo); //UIntPtr指针多句柄类型

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string strClass, string strWindow);

        //该函数获取一个窗口句柄,该窗口类名和窗口名与给定字符串匹配 hwnParent=Null从桌面窗口查找
        [DllImport("user32.dll")]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
            string strClass, string strWindow);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(HandleRef hwnd, out NativeRECT rect);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        //定义变量
        const int AnimationCount = 400;
        private Point endPosition;
        private int count;
        
         private void button1_Click(object sender, EventArgs e)
        {
            /*
            NativeRECT rect;
            //获取主窗体句柄
            IntPtr ptrTaskbar = FindWindow("WindowsForms10.Window.8.app.0.b7ab7b_r13_ad1", null);
            if (ptrTaskbar == IntPtr.Zero)
            {
                MessageBox.Show("No windows found!");
                return;
            }
            //获取窗体中"button1"按钮
            IntPtr ptrStartBtn = FindWindowEx(ptrTaskbar, IntPtr.Zero, null, "");
            if (ptrStartBtn == IntPtr.Zero)
            {
                MessageBox.Show("No button found!");
                return;
            }
            //获取窗体大小
            GetWindowRect(new HandleRef(this, ptrStartBtn), out rect);
            endPosition.X = (rect.left + rect.right) / 2;
            endPosition.Y = (rect.top + rect.bottom) / 2;
            //判断点击按钮
            if (checkBox1.Checked)
            {
                //选择"查看鼠标运行的轨迹"
                this.count = AnimationCount;
                movementTimer.Start();
            }
            else
            {
                SetCursorPos(endPosition.X, endPosition.Y);
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
                //模拟输入
                //SendKeys.Send("ss");
                keybd_event(96, 0, 0, 0);
                keybd_event(96, 0, 0, 0);
                keybd_event(96, 0, 0, 0);
                keybd_event(96, 0, 0, 0);
                keybd_event(96, 0, 0, 0);
                keybd_event(77, 0, 0, 0);
                keybd_event(108, 0, 0, 0);

                //SendMessage(ptrStartBtn, 0xD, str.Capacity, str);   
                textBox1.Text = String.Format("{0},{1}", MousePosition.X, MousePosition.Y);
            }
            
        }
        //Tick:定时器,每当经过多少时间发生函数
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            
            int stepx = (endPosition.X - MousePosition.X) / count;
            int stepy = (endPosition.Y - MousePosition.Y) / count;
            count--;
            if (count == 0)
            {
                movementTimer.Stop();
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
                keybd_event(96, 0, 0, 0);
                keybd_event(96, 0, 0, 0);
            }
            textBox1.Text = String.Format("{0},{1}", MousePosition.X, MousePosition.Y);
            mouse_event(MouseEventFlag.Move, stepx, stepy, 0, UIntPtr.Zero);
            
        }

        private void movementTimer_Tick_1(object sender, EventArgs e)
        {
            
            int stepx = (endPosition.X - MousePosition.X) / count;
            int stepy = (endPosition.Y - MousePosition.Y) / count;
            count--;
            if (count == 0)
            {
                movementTimer.Stop();
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            textBox1.Text = String.Format("{0},{1}", MousePosition.X, MousePosition.Y);
            mouse_event(MouseEventFlag.Move, stepx, stepy, 0, UIntPtr.Zero);
            
        }
        */
        #endregion


        private void startTask_Click(object sender, EventArgs e)
        {
            //用Timer实现异步输入


            #region OldCode
            //if (!webBrowser1.IsBusy)
            //{
            //HtmlElement mobile = webBrowser1.Document.All["mobile"];
            //HtmlElement pass = webBrowser1.Document.All["password"];
            //HtmlElement codes = webBrowser1.Document.All["checkCode"];
            //HtmlElement btn = webBrowser1.Document.All["loginButton"];
            //HtmlElement pass2 = webBrowser1.Document.All["password1"];

            //Thread.Sleep(2000);

            //mobile.SetAttribute("value", "15810230925");
            //Thread.Sleep(2000);
            //pass.SetAttribute("value", "xhb198992566");
            //Thread.Sleep(2000);
            //pass2.SetAttribute("value", "xhb198992566");
            //Thread.Sleep(2000);
            //codes.SetAttribute("value", this.code);
            //Thread.Sleep(2000);
            //btn.InvokeMember("click");
            //}
            #endregion
            this.Msg.Text = "验证码:" + code;
            //InputMobile(MyPhoneNum.ToString());
            //th1 = new Thread(new ParameterizedThreadStart(InputMobile));
            //th1.IsBackground = true;
            //th1.Start(MyPhoneNum);
            //Sleep(10);
            //th2 = new Thread(new ParameterizedThreadStart(InputPassword));
            //th2.IsBackground = true;
            InputMobile(MyPhoneNum);
            //InputPhoneTimer.Tick += new EventHandler(InputPhoneTimer_Tick);
            //InputPasswordTimer.Tick +=new EventHandler(InputPasswordTimer_Tick);
            //InputCodeTimer.Tick += new EventHandler(InputCodeTimer_Tick);
            
            //InputPassword(MyPassWord);


            //th2.Start(MyPassWord);
            //InputPassword(MyPassWord.ToString());
            //Sleep(1);
            //InputCode(this.code);
            //Sleep(5);
            //NavigateToPage();
            //Sleep(5);
            //Sign();



            //Thread th = new Thread(new ThreadStart(new NaviToPage(NavigateToPage)));
            //Thread th = new Thread(new ParameterizedThreadStart(new InputMessage(InputMobile)));
            //th.IsBackground = true;
            //th.Start(MyPhoneNum);
            //Thread.Sleep(5000);
            //this.webBrowser1.Navigate("http://data.10086.cn/nmp-pps/m/?s=2&p=10&c=98&j=l", "", null, "Content-Type: application/x-www-form-urlencoded");
        }

        


        /// <summary>
        /// 第一步：输入手机号
        /// </summary>
        private void InputMobile(object phoneNum)
        {
            if (webBrowser1.InvokeRequired)
            {
                this.BeginInvoke(new InputMessage(InputMobile), phoneNum);
            }
            else
            {
                IM(phoneNum);
            }
        }
        private void IM(object phoneNum)
        {
            HtmlElement mobile = webBrowser1.Document.All["mobile"];
            mobile.SetAttribute("value", phoneNum.ToString());
            this.InputPhoneTimer.Enabled = false;
            this.InputPasswordTimer.Enabled = true;
        }


        /// <summary>
        /// 第二步：输入密码
        /// </summary>
        /// <param name="password"></param>
        private void InputPassword(object password)
        {
            if (this.webBrowser1.InvokeRequired)
            {
                this.BeginInvoke(new InputMessage(InputPassword), password);
            }
            else
            {
                HtmlElement pass = webBrowser1.Document.All["password"];
                pass.SetAttribute("value", password.ToString());
            }
        }
        private void IP(object password)
        {
            HtmlElement pass = webBrowser1.Document.All["password"];
            pass.SetAttribute("value", password.ToString());
        }

        /// <summary>
        /// 第三步：输入验证码
        /// </summary>
        /// <param name="code"></param>
        private void InputCode(object code)
        {
            //if (this.webBrowser1.IsBusy)
            {
                HtmlElement codes = webBrowser1.Document.All["checkCode"];
                codes.SetAttribute("value", code.ToString());
            }
        }

        /// <summary>
        /// 第四步：提交信息
        /// </summary>
        private void Submit()
        {
            //Thread.Sleep(500);
            //if (!this.webBrowser1.IsBusy)
            {
                HtmlElement btn = webBrowser1.Document.All["loginButton"];
                btn.InvokeMember("click");
            }
            //Thread th = new Thread(new ThreadStart(new NaviToPage(NavigateToPage)));
            //th.Start();
            //NavigateToPage();
        }

        /// <summary>
        /// 第五步：登录并跳转
        /// </summary>
        private void NavigateToPage()
        {
            //Thread.Sleep(5000);
            this.webBrowser1.Navigate("http://data.10086.cn/nmp-pps/m/?s=2&p=10&c=98&j=l", "", null, "Content-Type: application/x-www-form-urlencoded");
        }

        /// <summary>
        /// 第六步：签到
        /// </summary>
        private void Sign()
        {
            HtmlElement sign = webBrowser1.Document.Images[3];
            sign.InvokeMember("click");
        }

        private void Sleep(int time)
        {
            Thread.Sleep(time * 1000);
        }

        private void MouseEvent_Load(object sender, EventArgs e)
        {

            this.webBrowser1.Url = new Uri("https://data.10086.cn/pc/login.do");//指定url地址为百度首页  
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            this.picData = GetPic();
            //sw.Stop();
            //Console.WriteLine("GetPic:" + sw.Elapsed);

            //Stopwatch sw2 = new Stopwatch();
            //sw.Start();
            code = GetCode(picData);
            //sw2.Stop();
            //Console.WriteLine("GetCode:" + sw2.Elapsed);
            ReadData reader = new ReadData();
            reader.Read();
        }

        /// <summary>
        /// 把byte传给Post并返回当前验证码
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string GetCode(byte[] data)
        {
            //throw new NotImplementedException();
            string user = this.txtAccount.Text;
            string pass = this.txtPass.Text;
            string typeid = this.txtType.Text;
            string softid = "1";
            string timeout = this.txtTimeout.Text;
            string softKey = this.txtSoftKey.Text;
            string result = string.Empty;

            //必要的参数
            var param = new Dictionary<object, object>
                        {
                            {"username",user},
                            {"password",pass},
                            {"typeid",typeid},
                            {"timeout",timeout},
                            {"softid",softid},
                            {"softkey",softKey}
                        };
            Stopwatch g = new Stopwatch();
            g.Start();
            //提交服务器
            string httpResult = RuoKuaiHttp.Post("http://api.ruokuai.com/create.xml", param, data);
            g.Stop();
            Console.WriteLine("Post:" + g.Elapsed);
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(httpResult);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            XmlNode idNode = xmlDoc.SelectSingleNode("Root/Id");
            XmlNode resultNode = xmlDoc.SelectSingleNode("Root/Result");
            XmlNode errorNode = xmlDoc.SelectSingleNode("Root/Error");
            string topidid = string.Empty;
            if (resultNode != null && idNode != null)
            {
                topidid = idNode.InnerText;
                result = resultNode.InnerText;
            }
            return result;
        }

        void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            //e.Handled = true; // 阻止其他地方继续处理 
            //string b = e.Description;
            //string c = e.Url.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }


        /// <summary>
        /// 获取站点返回的验证码图片
        /// </summary>
        /// <returns></returns>
        private byte[] GetPic()
        {
            WebBrowser wb = this.webBrowser2;
            Bitmap map;
            byte[] data = null;
            wb.Navigate("https://data.10086.cn/pc/checkCode/checkCode.do");
            //等待加载完毕
            while (wb.ReadyState < WebBrowserReadyState.Complete) Application.DoEvents();
            HtmlElement pic = wb.Document.Images[0];
            //遍历寻找验证图像所在元素
            foreach (HtmlElement f in wb.Document.Images)
            {
                if (f.GetAttribute("src").ToLower().EndsWith("checkcode.do"))
                {
                    //将元素绝对定位到页面左上角
                    f.Style = "position: absolute; z-index: 9999; top: 0px; left: 0px";
                    //抓图
                    Bitmap b = new Bitmap(f.ClientRectangle.Width, f.ClientRectangle.Height);
                    wb.DrawToBitmap(b, new Rectangle(new Point(), f.ClientRectangle.Size));

                    Stopwatch a = new Stopwatch();
                    a.Start();
                    data = Bitmap2Byte(b);
                    a.Stop();
                    Console.WriteLine("Bitmap2Byte(b):" + a.Elapsed);
                    pictureBox1.Image = b;
                    break;
                }
            }
            return data;
        }

        /// <summary>
        /// 将Bitmap转成Byte供Post调用
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public byte[] Bitmap2Byte(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] data = new byte[stream.Length];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(data, 0, Convert.ToInt32(stream.Length));
                return data;
            }
        }


        /// <summary>
        /// 将Bitmap转成Byte供Post调用
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="local"></param>
        /// <returns></returns>
        public byte[] Bitmap2Byte(Bitmap bitmap, bool local)
        {
            bitmap.Save("C:\\Pic.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            Image image = Image.FromFile("C:\\Pic.bmp");
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Bmp);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            byte[] buffer = new byte[ms.Length];
            ms.Read(buffer, 0, (int)ms.Length);//这里已经转成了字节
            return buffer;
        }

        private void MouseEvent_ClientSizeChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Height = this.ClientRectangle.Height;
        }

        private void InputPhoneTimer_Tick(object sender, EventArgs e)
        {
            //this.Msg.Text = i.ToString() + InputPhoneTimer.Enabled.ToString();
            InputPassword(MyPassWord);
            this.InputPhoneTimer.Enabled = false;
            this.InputPasswordTimer.Enabled = true;

            Console.Write(DateTime.Now.ToString());
            this.InputPasswordTimer.Start();
            Console.Write(DateTime.Now.ToString());

        }

        private void InputPasswordTimer_Tick(object sender, EventArgs e)
        {
            InputPassword(MyPassWord);
            this.InputPasswordTimer.Enabled = false;
            this.InputCodeTimer.Enabled = true;
            this.InputCodeTimer.Start();
        }

        private void InputCodeTimer_Tick(object sender, EventArgs e)
        {
            InputCode(this.code);
            this.InputCodeTimer.Enabled = false;
            //点击登录
            NavigateToPage();
            this.SignTimer.Enabled = true;
            this.SignTimer.Start();
        }

        private void SignTimer_Tick(object sender, EventArgs e)
        {
            Sign();
            this.SignTimer.Enabled = false;
        }
    }
}
