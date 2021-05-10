using Newtonsoft.Json.Linq;
using System;
using System.Web;
using System.Speech.Synthesis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;

namespace Eascry
{
    public partial class Form1 : Form
    {
        //热键API
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        //获取屏幕DPI
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr ptr);
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDC(
        string lpszDriver, // driver name
        string lpszDevice, // device name
        string lpszOutput, // not used; should be NULL
        Int64 lpInitData // optional printer data
        );
        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(
        IntPtr hdc, // handle to DC
        int nIndex // index of capability
        );
        [DllImport("user32.dll")]
        internal static extern bool SetProcessDPIAware();
        const int LOGPIXELSX = 88;

        ScreenHot screenHot;
        double scale;  //屏幕缩放比例

        bool mouseDown = false;
        bool havePainted = false;
        bool windowCreate = true;
        bool transNow = false;  //是否在翻译

        Size size = new Size(0, 0);
        Point start, end;
        bool isSet = false;  //是否重新读取

        //百度翻译开放平台
        string appId = "";
        string secretKey = "";
        //百度OCR开放
        string API_KEY = "";
        string SECRET_KEY = "";


        public Form1()
        {
            InitializeComponent();

            //获取屏幕DPI
            SetProcessDPIAware();
            IntPtr screenDC = GetDC(IntPtr.Zero);
            int dpi_x = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSX);
            scale = dpi_x / 96.0;
            ReleaseDC(IntPtr.Zero, screenDC);

            picSelectionRange.Visible = false;
            screenHot = new ScreenHot();

            RegisterHotKey(this.Handle, 224, 0, Keys.PrintScreen);  //截屏

            if (screenHot.GetImgNow == false)
            {
                btnHot.Enabled = true;
            }
            else
            {
                btnHot.Enabled = false;
            }

            //API设置
            appId = screenHot.TID;
            secretKey = screenHot.TSK;
            API_KEY = screenHot.OID;
            SECRET_KEY = screenHot.OSK;

            //MessageBox.Show("缩放比例：" + scale.ToString());
            //this.Text += "-scale:" + scale;
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(screenHot.IsSuccess, scale);

            form2.Show();
            form2.form1 = this;
            this.Enabled = false;
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            ScreenHotting.ReadyToCaptrue(this, toolStrip1, picP);
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            base.Visible = false;
            Thread.Sleep(200);
            Hotting();
            Thread.Sleep(200);
            base.Visible = true;
        }

        //翻译
        private void btnTrans_Click(object sender, EventArgs e)
        {
            //GetVoiceFromStringByBaiduAI("我可以进行语音播放了");
            transNow = true;
            ScreenHotting.ReadyToCaptrue(this, toolStrip1, picP);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                windowCreate = true;
            }
        }

        //每六秒清理一次残留托盘图标
        private void timer1_Tick(object sender, EventArgs e)
        {
            TaskBarUtil.RefreshNotificationArea();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            screenHot.Ranges.StartPoint = e.Location;
            mouseDown = true;
            picSelectionRange.Location = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                picSelectionRange.Visible = true;

                end = e.Location;
                size.Width = Math.Abs(end.X - screenHot.Ranges.StartPoint.X);
                size.Height = Math.Abs(end.Y - screenHot.Ranges.StartPoint.Y);
                start.X = (screenHot.Ranges.StartPoint.X > end.X) ? end.X : screenHot.Ranges.StartPoint.X;
                start.Y = (screenHot.Ranges.StartPoint.Y > end.Y) ? end.Y : screenHot.Ranges.StartPoint.Y;

                if (size.Width != 0 && size.Height != 0)
                {
                    //ControlPaint.DrawReversibleFrame(new Rectangle(start, size), Color.Transparent, FrameStyle.Dashed);
                    picSelectionRange.Location = start;
                    picSelectionRange.Width = size.Width;
                    picSelectionRange.Height = size.Height;
                    havePainted = true;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (havePainted)
            {
                havePainted = false;
                screenHot.Ranges.StartPoint = new Point((int)(start.X /** screenHot.ScreenScale*/), (int)(start.Y /** screenHot.ScreenScale*/));
                screenHot.Ranges.RangeSize = new Size((int)(size.Width /** screenHot.ScreenScale*/), (int)(size.Height /** screenHot.ScreenScale*/));
                screenHot.Ranges.EndPoint = new Point(screenHot.Ranges.StartPoint.X + screenHot.Ranges.RangeSize.Width, screenHot.Ranges.StartPoint.Y + screenHot.Ranges.RangeSize.Height);

                picSelectionRange.Visible = false;
                this.Opacity = 0.0;
                picP.Visible = false;

                if (!transNow)
                {
                    if (!screenHot.GetImgNow)
                    {
                        ReWriteRange(screenHot.Ranges.StartPoint.X.ToString(), screenHot.Ranges.StartPoint.Y.ToString(), screenHot.Ranges.RangeSize.Width.ToString(), screenHot.Ranges.RangeSize.Height.ToString());
                    }
                    else
                    {
                        Thread.Sleep(200);
                        Hotting();
                    }
                }
                else  //如果是翻译
                {
                    string strCN = HottingUsedInTranslate();
                    PlayVoiceFromString(strCN);

                    transNow = false;
                }
            }

            //this.Opacity = 1.0;
            Thread.Sleep(200);

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            toolStrip1.Visible = true;
            this.Opacity = 1;
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否最小化到托盘", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = true;

                if (windowCreate == true)
                {
                    base.Visible = false;
                    windowCreate = false;
                    this.Hide();
                    base.OnActivated(e);
                }
            }
            else
            {
                UnregisterHotKey(this.Handle, 224);
                
                DeleteFolder(Environment.CurrentDirectory + "\\temporarypreservation");

                //this.Close();  //关闭窗体
                notifyIcon1.Dispose();  //销毁托盘图标
                this.Dispose();  //释放资源  
                Application.Exit();  //关闭应用程序窗体   
            }
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {

            if (this.Enabled == false)
            {
                isSet = true;
            }
            if (this.Enabled == true && isSet == true)
            {
                screenHot.ReadSetFile();  

                if (screenHot.GetImgNow == false)
                {
                    btnHot.Enabled = true;
                }
                else
                {
                    btnHot.Enabled = false;
                }

                isSet = false;
            }
        }

        //截图
        private void Hotting()
        {
            //**********截图到图片**********
            string timeName = DateTime.Now.ToFileTimeUtc().ToString();
            Bitmap bit = new Bitmap(screenHot.Ranges.RangeSize.Width, screenHot.Ranges.RangeSize.Height);
            Graphics g = Graphics.FromImage(bit);

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;  //高质量

            g.CopyFromScreen(screenHot.Ranges.StartPoint, new Point(0, 0), bit.Size, CopyPixelOperation.SourceCopy);
            bit.Save(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + ".jpg");

            if (screenHot.ImgSvaeWay == ScreenHot.SaveWays.剪贴板 && screenHot.WaterMaskSaveWay == ScreenHot.SaveWays.不保存)
            {
                Clipboard.Clear();
                CopyImage(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + ".jpg");
            }
            else if (screenHot.ImgSvaeWay == ScreenHot.SaveWays.文件 && screenHot.WaterMaskSaveWay == ScreenHot.SaveWays.不保存)
            {
                bit.Save(screenHot.ImgSavePath + "\\" + timeName + ".jpg");
            }

            bit.Dispose();
            g.Dispose();

            //加水印
            if (screenHot.WaterMaskSaveWay != ScreenHot.SaveWays.不保存)
            {
                Image image = Image.FromFile(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + ".jpg");
                Bitmap bitmap = new Bitmap(image, image.Width, image.Height);
                Graphics fg = Graphics.FromImage(bitmap);

                int fontSize = 20;
                int halfFontPix = 20;
                float rectWidth = (Encoding.Default.GetBytes(screenHot.WaterMark).Length + 3) * halfFontPix;
                float rectHeight = fontSize + 2 * halfFontPix;
                float rectX = screenHot.Ranges.EndPoint.X - screenHot.Ranges.StartPoint.X - rectWidth;
                float rectY = screenHot.Ranges.EndPoint.Y - screenHot.Ranges.StartPoint.Y - rectHeight;
                RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
                Font font = new Font("微软雅黑", fontSize, FontStyle.Bold);
                Brush whiteBrush = new SolidBrush(screenHot.WaterMaskColor);

                fg.DrawString(screenHot.WaterMark, font, whiteBrush, textArea);
                bitmap.Save(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + "_mark.jpg");

                if (screenHot.WaterMaskSaveWay == ScreenHot.SaveWays.文件)
                {
                    bitmap.Save(screenHot.ImgSavePath + "\\" + timeName + "_mark.jpg");
                }
                else if (screenHot.WaterMaskSaveWay == ScreenHot.SaveWays.剪贴板)
                {
                    Clipboard.Clear();
                    CopyImage(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + "_mark.jpg");
                }

                bitmap.Dispose();
                image.Dispose();
                fg.Dispose();
            }

            //base64编码
            string base64Code;

            if (screenHot.WaterMaskSaveWay != ScreenHot.SaveWays.不保存)
            {
                base64Code = ImageToBase64(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + "_mark.jpg");
            }
            else
            {
                base64Code = ImageToBase64(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + ".jpg");
            }

            if (screenHot.Base64SaveWay == ScreenHot.SaveWays.文件)
            {
                FileAndFolderSetting.CreateBase64File(base64Code, screenHot.Base64SavePath +"\\" + timeName + "_base64.txt");
            }
            else if (screenHot.Base64SaveWay == ScreenHot.SaveWays.剪贴板)
            {
                Clipboard.Clear();
                Clipboard.SetText(base64Code);
            }

            //文件名
            if (screenHot.ImgNameWay == ScreenHot.SaveWays.剪贴板)
            {
                Clipboard.Clear();
                if (screenHot.WaterMaskSaveWay != ScreenHot.SaveWays.文件)
                {
                    Clipboard.SetText(timeName + ".jpg");
                }
                else
                {
                    Clipboard.SetText(timeName + "_mark.jpg");
                }
            }

            //OCR
            if (screenHot.OCR)
            {
                Clipboard.Clear();
                Clipboard.SetText(GetWordFromImageByBaiduAI(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + ".jpg"));               
            }
        }

        //翻译截图
        private string HottingUsedInTranslate()
        {
            //截图
            string timeName = DateTime.Now.ToFileTimeUtc().ToString();
            Bitmap bit = new Bitmap(screenHot.Ranges.RangeSize.Width, screenHot.Ranges.RangeSize.Height);
            Graphics g = Graphics.FromImage(bit);

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;  //高质量
            g.CopyFromScreen(screenHot.Ranges.StartPoint, new Point(0, 0), bit.Size, CopyPixelOperation.SourceCopy);
            bit.Save(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + "_trans.jpg");

            bit.Dispose();
            g.Dispose();

            //OCR
            string strEN = GetWordFromImageByBaiduAI(Environment.CurrentDirectory + "\\temporarypreservation\\" + timeName + "_trans.jpg");
            string strCN;

            if (strEN == "CWarning")
            {
                strCN = "抱歉，我无法翻译您选中的内容";
            }
            else if (strEN == "COver")
            {
                strCN = "抱歉，您的OCR每日限额已经用完";
            }
            else if (strEN == "CError")
            {
                strCN = "抱歉，出现了未知的错误";
            }
            else
            {
                //翻译
                strCN = TranslateENToCNByBaidu(strEN);
            }

            return strCN;
        }

        //清空文件夹
        public void DeleteFolder(string path)
        {
            try
            {
                foreach (string d in Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(d))
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        File.Delete(d);//直接删除其中的文件  
                    }
                    else
                    {
                        DirectoryInfo d1 = new DirectoryInfo(d);
                        if (d1.GetFiles().Length != 0)
                        {
                            DeleteFolder(d1.FullName);////递归删除子文件夹
                        }
                        Directory.Delete(d);
                    }
                }
            }
            catch
            {

            } 
        }

        //重写范围
        private void ReWriteRange(string X, string Y, string Width, string Height)
        {
            string[] array = File.ReadAllLines(Environment.CurrentDirectory + "\\Users.set");
            array[2] = X + "◆" + Y + "◆" + Width + "◆" + Height;  // 这里一个数组元素就是一行内容

            File.WriteAllLines(Environment.CurrentDirectory + "\\Users.set", array);
        }

        //图片保存到剪切板
        private void CopyImage(string file)
        {
            Image img = Image.FromFile(file);
            Clipboard.Clear();
            Clipboard.SetImage(img);
        }

        //image转base64编码
        private string ImageToBase64(string fileFullName)
        {
            try
            {
                Bitmap bmp = new Bitmap(fileFullName);
                MemoryStream ms = new MemoryStream();

                bmp.Save(ms, ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();

                return "data:image/jpg;base64," + Convert.ToBase64String(arr);
            }
            catch
            {
                return null;
            }

        }

        //百度AI的OCR识别
        private string GetWordFromImageByBaiduAI(string imgPath)
        {
            var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
            string result;

            try
            {
                result = "";
                JObject OCRresult = client.AccurateBasic(File.ReadAllBytes(imgPath));  //高精度500次/天

                try
                {
                    //JSON解析
                    var txts = (from obj in (JArray)OCRresult.Root["words_result"] select (string)obj["words"]);
                    foreach (var r in txts)
                        result = result + r;

                    if (result != "")
                    {
                        return result;
                    }
                    else
                    {
                        MessageBox.Show("未识别到文字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return "CWarning";
                    }
                }
                catch
                {
                    var code = int.Parse(OCRresult.Value<string>("error_code"));

                    if (code == 17)
                    {
                        result = "";
                        OCRresult = client.GeneralBasic(File.ReadAllBytes(imgPath));  //普通识别50000次/天

                        try
                        {
                            //JSON解析
                            var txts = (from obj in (JArray)OCRresult.Root["words_result"] select (string)obj["words"]);
                            foreach (var r in txts)
                                result = result + r;

                            if (result != "")
                            {
                                return result;
                            }
                            else
                            {
                                MessageBox.Show("未识别到文字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return "CWarning";
                            }
                        }
                        catch
                        {
                            var code2 = int.Parse(OCRresult.Value<string>("error_code"));

                            if (code2 == 17)
                            {
                                MessageBox.Show("每日限量已使用完", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return "COver";
                            }
                            else
                            {
                                MessageBox.Show("快速OCR出错", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return "CError";
                            }
                        }   
                    }
                    else
                    {
                        MessageBox.Show("快速OCR出错", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "CError";
                    }
                }
            }
            catch
            {
                MessageBox.Show("快速OCR出错", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            } 
        }

        //百度翻译API
        private string TranslateENToCNByBaidu(string strEN)
        {
            //目标文字
            string strCN = "";
            //源语言
            string from = "en";
            //目标语言
            string to = "zh";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            string sign = EncryptString(appId + strEN + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(strEN);
            url += "&from=" + from;
            url += "&to=" + to;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 6000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            strCN = Analytical(retString);

            //MessageBox.Show(strCN);
            return strCN;
        }

        //计算MD5值
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            //将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            //调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            //将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                //将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            //返回加密的字符串
            return sb.ToString();
        }

        //解析dst
        public string Analytical(string JsonCode)
        {
            JObject ResultParent = JObject.Parse(JsonCode);
            String trans_result = ResultParent["trans_result"].ToString();
            JObject ResultChild = JObject.Parse(trans_result.Replace("[", " ").Replace("]", " "));
            //翻译后的目标结果
            String target = ResultChild["dst"].ToString();
            return target;
        }

        //语音播放
        private void PlayVoiceFromString(string str)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            speech.Rate = 0;  //语速为正常语速
            //speech.SelectVoice("Microsoft Lili");  //设置播音员（中文）
            speech.Volume = 100;  //音量为最大音量
            speech.Speak(str);  //语音阅读方法
        }

        //热键控制
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:  //这个是window消息定义的注册的热键消息 
                    if (m.WParam.ToString().Equals("224"))
                    {
                        if (!screenHot.GetImgNow)
                        {
                            Hotting();
                        }
                        else
                        {
                            ScreenHotting.ReadyToCaptrue(this, toolStrip1, picP);
                        }
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
