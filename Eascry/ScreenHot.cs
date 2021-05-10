using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Eascry
{
    class ScreenHot
    {
        //保存屏幕信息的结构，包含矩形起点终点和截屏区域的宽高
        public struct ScreenRange
        {
            private Point startPoint;
            private Point endPoint;
            private Size rangeSize;

            public Point StartPoint { get => startPoint; set => startPoint = value; }
            public Point EndPoint { get => endPoint; set => endPoint = value; }
            public Size RangeSize { get => rangeSize; set => rangeSize = value; }
        };

        //保存方式
        public enum SaveWays
        {
            文件,
            剪贴板,
            不保存
        }

        private string imgSavePath;  //图片保存地址
        private string base64SavePath;  //Base64保存地址
        private SaveWays imgSvaeWay;
        private SaveWays base64SaveWay;
        private SaveWays imgNameWay;
        private string waterMark;  //水印
        private SaveWays waterMaskSaveWay;
        private Color waterMaskColor;
        private bool isSuccess;  //是否成功读取用户的配置
        private double screenScale;  //屏幕缩放
        private bool getImgNow;  //是否是即拍即得模式
        private bool prtscr;  //是否启用快捷键
        private bool oCR;  //是否快速OCR
        //API设置
        private string tID;
        private string tSK;
        private string oID;
        private string oSK;

        public ScreenRange Ranges;  //截图区域

        public string ImgSavePath { get => imgSavePath; set => imgSavePath = value; }
        public string Base64SavePath { get => base64SavePath; set => base64SavePath = value; }
        internal SaveWays ImgSvaeWay { get => imgSvaeWay; set => imgSvaeWay = value; }
        internal SaveWays Base64SaveWay { get => base64SaveWay; set => base64SaveWay = value; }
        public string WaterMark { get => waterMark; set => waterMark = value; }
        internal SaveWays WaterMaskSaveWay { get => waterMaskSaveWay; set => waterMaskSaveWay = value; }
        public Color WaterMaskColor { get => waterMaskColor; set => waterMaskColor = value; }
        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        public double ScreenScale { get => screenScale; set => screenScale = value; }
        internal SaveWays ImgNameWay { get => imgNameWay; set => imgNameWay = value; }
        public bool GetImgNow { get => getImgNow; set => getImgNow = value; }
        public bool Prtscr { get => prtscr; set => prtscr = value; }
        public bool OCR { get => oCR; set => oCR = value; }
        public string TID { get => tID; set => tID = value; }
        public string TSK { get => tSK; set => tSK = value; }
        public string OID { get => oID; set => oID = value; }
        public string OSK { get => oSK; set => oSK = value; }

        //构造函数
        public ScreenHot()
        {
            try
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\Users.set"))
                {
                    MessageBox.Show("当前目录不存在Users.set，无法读取用户配置，请在设置中重新设置用户配置", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsSuccess = false;
                }
                else
                {
                    ReadSetFile();

                    IsSuccess = true;
                }     
            }
            catch
            {
                MessageBox.Show("读取用户配置失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //SavePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\screenImages";  //获取桌面路径

                //if (!Directory.Exists(SavePath))
                //{
                //    Directory.CreateDirectory(SavePath);
                //    FileAndFolderSetting.AddSecurityControllToFolder(SavePath);
                //}
            }
        }

        public void ReadSetFile()
        {
            //读取用户保存设置
            using (FileStream userRead = new FileStream(Environment.CurrentDirectory + "\\Users.set", FileMode.Open, FileAccess.Read))
            {
                string[] strs;
                StreamReader ur = new StreamReader(userRead);

                //读取第一行
                strs = ur.ReadLine().Split('◆');
                if (strs[1] == "File")
                {
                    ImgSvaeWay = SaveWays.文件;
                    ImgSavePath = strs[2];
                }
                else if (strs[1] == "Panel")
                {
                    ImgSvaeWay = SaveWays.剪贴板;
                    ImgSavePath = null;
                }
                else
                {
                    ImgSvaeWay = SaveWays.不保存;
                    ImgSavePath = null;
                }
                //读取第二行
                strs = ur.ReadLine().Split('◆');
                if (strs[1] == "File")
                {
                    Base64SaveWay = SaveWays.文件;
                    Base64SavePath = strs[2];
                }
                else if (strs[1] == "Panel")
                {
                    Base64SaveWay = SaveWays.剪贴板;
                    Base64SavePath = null;
                }
                else
                {
                    Base64SaveWay = SaveWays.不保存;
                    Base64SavePath = null;
                }
                //读取第三行
                strs = ur.ReadLine().Split('◆');
                Ranges.StartPoint = new Point(int.Parse(strs[0]), int.Parse(strs[1]));
                Ranges.RangeSize = new Size(int.Parse(strs[2]), int.Parse(strs[3]));
                Ranges.EndPoint = new Point((Ranges.StartPoint.X + Ranges.RangeSize.Width), (Ranges.StartPoint.Y + Ranges.RangeSize.Height));
                //读取第四行
                strs = ur.ReadLine().Split('◆');
                WaterMark = strs[0];
                switch (strs[1])
                {
                    case "黑色":
                        WaterMaskColor = Color.Black;
                        break;
                    case "白色":
                        WaterMaskColor = Color.White;
                        break;
                    case "灰色":
                        WaterMaskColor = Color.Gray;
                        break;
                    case "红色":
                        WaterMaskColor = Color.Red;
                        break;
                    case "黄色":
                        WaterMaskColor = Color.Yellow;
                        break;
                    case "蓝色":
                        WaterMaskColor = Color.Blue;
                        break;
                    case "绿色":
                        WaterMaskColor = Color.Green;
                        break;
                    default:
                        break;
                }
                if (strs[2] == "Out")
                {
                    WaterMaskSaveWay = SaveWays.不保存;
                }
                else
                {
                    WaterMaskSaveWay = ImgSvaeWay;
                }
                //读取第五行
                strs = ur.ReadLine().Split('◆');
                ScreenScale = double.Parse(strs[1]);
                //读取第六行
                strs = ur.ReadLine().Split('◆');
                if (strs[1] == "In")
                {
                    ImgNameWay = SaveWays.剪贴板;
                }
                //读取第七行
                strs = ur.ReadLine().Split('◆');
                if (strs[1] == "In")
                {
                    Prtscr = true;
                }
                else
                {
                    Prtscr = false;
                }
                if (strs[2] == "一劳永逸")
                {
                    GetImgNow = false;
                }
                else if (strs[2] == "即拍即得")
                {
                    GetImgNow = true;
                }
                //读取第八行
                strs = ur.ReadLine().Split('◆');
                if (strs[1] == "In")
                {
                    OCR = true;
                }
                else
                {
                    OCR = false;
                }
                //读取第九行
                strs = ur.ReadLine().Split('◆');
                TID = strs[0];
                TSK = strs[1];
                //读取第十行
                strs = ur.ReadLine().Split('◆');
                OID = strs[0];
                OSK = strs[1];
            }
        }
    }
}
