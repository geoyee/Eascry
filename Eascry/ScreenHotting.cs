using System.Drawing;
using System.Windows.Forms;

namespace Eascry
{
    class ScreenHotting
    {
        //获取全屏
        public static void GetFullScreen(ref Point start, ref Point end, ref int width, ref int height, double scale, Form form)
        {
            start = new Point(0, 0);
            //获取主屏幕尺寸
            //width = (int)(Screen.PrimaryScreen.Bounds.Width * scale);
            //height = (int)(Screen.PrimaryScreen.Bounds.Height * scale);
            //获取所在屏幕尺寸*缩放比例
            //width = (int)(Screen.GetBounds(form).Width * scale);
            //height = (int)(Screen.GetBounds(form).Height * scale);
            //获取虚拟屏幕尺寸
            width = SystemInformation.VirtualScreen.Width;
            height = SystemInformation.VirtualScreen.Height;
            end = new Point(width, height);
        }

        //透明选择界面
        public static void ReadyToCaptrue(Form form, ToolStrip strip, PictureBox picture)
        {
            form.Opacity = 0.1;
            strip.Visible = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            //picture.Visible = true;
            FillScreen(picture);
        }

        //填充图片
        private static void FillScreen(PictureBox picture)
        {
            int width = SystemInformation.VirtualScreen.Width;
            int height = SystemInformation.VirtualScreen.Height;
            Bitmap bit = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bit);

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;  //高质量

            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bit.Size, CopyPixelOperation.SourceCopy);
            picture.Image = bit;
        }
    }
}
