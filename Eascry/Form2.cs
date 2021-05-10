using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Eascry
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        double Scrscale;

        public Form2(bool isSuccess, double scale)
        {
            InitializeComponent();

            Scrscale = scale;

            if (!isSuccess)
            {
                InitSavePanel();
                InitAllScreen();
                InitWaterMask();
                InitMode();
                PanitRange();

                //判断设置文件是否存在，不存在就先新建
                FileAndFolderSetting.AddSet(Environment.CurrentDirectory + "\\Users.set");

                using (FileStream userWrite = new FileStream(Environment.CurrentDirectory + "\\Users.set", FileMode.Open, FileAccess.Write))
                {
                    StreamWriter stw = new StreamWriter(userWrite, Encoding.GetEncoding("utf-8"));

                    WriteSetInfomation(stw);
                    stw.Close();
                }
            }
            else
            {
                try
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
                            chImgFile.Checked = true;
                            chImgFile.CheckState = CheckState.Checked;
                            chImgPanel.Checked = false;
                            chImgPanel.CheckState = CheckState.Unchecked;
                            txtImgFile.Text = strs[2];
                            txtImgFile.Visible = true;
                            btnImgFile.Visible = true;
                        }
                        else if (strs[1] == "Panel")
                        {
                            chImgFile.Checked = false;
                            chImgFile.CheckState = CheckState.Unchecked;
                            chImgPanel.Checked = true;
                            chImgPanel.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chImgFile.Checked = false;
                            chImgFile.CheckState = CheckState.Unchecked;
                            chImgPanel.Checked = false;
                            chImgPanel.CheckState = CheckState.Unchecked;
                            txtImgFile.Text = "";
                        }
                        //读取第二行
                        strs = ur.ReadLine().Split('◆');
                        if (strs[1] == "File")
                        {
                            chBase64File.Checked = true;
                            chBase64File.CheckState = CheckState.Checked;
                            chBase64Panel.Checked = false;
                            chBase64Panel.CheckState = CheckState.Unchecked;
                            txtBase64File.Text = strs[2];
                            txtBase64File.Visible = true;
                            btnBase64File.Visible = true;
                        }
                        else if (strs[1] == "Panel")
                        {
                            chBase64File.Checked = false;
                            chBase64File.CheckState = CheckState.Unchecked;
                            chBase64Panel.Checked = true;
                            chBase64Panel.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chBase64File.Checked = false;
                            chBase64File.CheckState = CheckState.Unchecked;
                            chBase64Panel.Checked = false;
                            chBase64Panel.CheckState = CheckState.Unchecked;
                            txtBase64File.Text = "";
                        }
                        //读取第三行
                        strs = ur.ReadLine().Split('◆');
                        txtX.Text = strs[0];
                        txtY.Text = strs[1];
                        txtWidth.Text = strs[2];
                        txtHeight.Text = strs[3];
                        //读取第四行
                        strs = ur.ReadLine().Split('◆');
                        txtWaterMask.Text = strs[0];
                        cbbColor.Text = strs[1];
                        if (strs[2] == "Out")
                        {
                            chWaterMask.Checked = false;
                            chWaterMask.CheckState = CheckState.Unchecked;
                        }
                        else
                        {
                            chWaterMask.Checked = true;
                            chWaterMask.CheckState = CheckState.Checked;
                        }
                        //读取第五行
                        strs = ur.ReadLine().Split('◆');
                        //读取第六行
                        strs = ur.ReadLine().Split('◆');
                        if (strs[1] == "In")
                        {
                            chImgName.Checked = true;
                            chImgName.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chImgName.Checked = false;
                            chImgName.CheckState = CheckState.Unchecked;
                        }
                        //读取第七行
                        strs = ur.ReadLine().Split('◆');
                        if (strs[1] == "In")
                        {
                            chPrtScr.Checked = true;
                            chPrtScr.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chPrtScr.Checked = false;
                            chPrtScr.CheckState = CheckState.Unchecked;
                        }
                        cbbMode.Text = strs[2];
                        //读取第八行
                        strs = ur.ReadLine().Split('◆');
                        if (strs[1] == "In")
                        {
                            chOCR.Checked = true;
                            chOCR.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chOCR.Checked = false;
                            chOCR.CheckState = CheckState.Unchecked;
                        }
                        //读取第九行
                        strs = ur.ReadLine().Split('◆');
                        txtTid.Text = strs[0];
                        txtTsk.Text = strs[1];
                        //读取第十行
                        strs = ur.ReadLine().Split('◆');
                        txtOid.Text = strs[0];
                        txtOsk.Text = strs[1];
                    }

                    PanitRange();
                }
                catch
                {

                }
            }
        }

        #region 保存设置区
        //checkBox调转设置
        private void chImgFile_Click(object sender, EventArgs e)
        {
            SaveChecked(chImgFile, chImgPanel, txtImgFile, btnImgFile);
        }

        private void chImgPanel_Click(object sender, EventArgs e)
        {
            SaveChecked(chImgPanel, chImgFile, chBase64Panel, chImgName, chOCR, txtImgFile, btnImgFile);
        }

        private void chBase64File_Click(object sender, EventArgs e)
        {
            SaveChecked(chBase64File, chBase64Panel, txtBase64File, btnBase64File);
        }

        private void chBase64Panel_Click(object sender, EventArgs e)
        {
            SaveChecked(chBase64Panel, chBase64File, chImgPanel, chImgName, chOCR, txtBase64File, btnBase64File);
        }

        private void chImgName_Click(object sender, EventArgs e)
        {
            if (chImgName.Checked == true)
            {
                chImgPanel.Checked = false;
                chImgPanel.CheckState = CheckState.Unchecked;
                chBase64Panel.Checked = false;
                chBase64Panel.CheckState = CheckState.Unchecked;
                chOCR.Checked = false;
                chOCR.CheckState = CheckState.Unchecked;

                chImgName.Checked = true;
                chImgName.CheckState = CheckState.Checked;
            }
            else
            {
                chImgName.Checked = false;
                chImgName.CheckState = CheckState.Unchecked;
            }
        }

        private void chOCR_Click(object sender, EventArgs e)
        {
            if (chOCR.Checked == true)
            {
                chImgPanel.Checked = false;
                chImgPanel.CheckState = CheckState.Unchecked;
                chBase64Panel.Checked = false;
                chBase64Panel.CheckState = CheckState.Unchecked;
                chImgName.Checked = false;
                chImgName.CheckState = CheckState.Unchecked;

                chOCR.Checked = true;
                chOCR.CheckState = CheckState.Checked;
            }
            else
            {
                chOCR.Checked = false;
                chOCR.CheckState = CheckState.Unchecked;
            }
        }

        //调转设置方法
        private void SaveChecked(CheckBox inCh, CheckBox otherCh, TextBox inText, Button inButton)
        {
            if (inCh.Checked == true)
            {
                inText.Visible = true;
                inButton.Visible = true;

                otherCh.Checked = false;
                otherCh.CheckState = CheckState.Unchecked;
                inCh.Checked = true;
                inCh.CheckState = CheckState.Checked;
            }
            else
            {
                inText.Visible = false;
                inButton.Visible = false;

                inCh.Checked = false;
                inCh.CheckState = CheckState.Unchecked;
            }
        }

        private void SaveChecked(CheckBox inCh, CheckBox otherCh, CheckBox outCh, CheckBox name, CheckBox ocr, TextBox otherText, Button otherButton)
        {
            if (inCh.Checked == true)
            {
                otherCh.Checked = false;
                otherCh.CheckState = CheckState.Unchecked;
                outCh.Checked = false;
                outCh.CheckState = CheckState.Unchecked;
                name.Checked = false;
                name.CheckState = CheckState.Unchecked;
                ocr.Checked = false;
                ocr.CheckState = CheckState.Unchecked;
                inCh.Checked = true;
                inCh.CheckState = CheckState.Checked;  

                otherText.Visible = false;
                otherButton.Visible = false;
            }
            else
            {
                inCh.Checked = false;
                inCh.CheckState = CheckState.Unchecked;
            }
        }

        //保存路径按钮操作
        private void btnImgFile_Click(object sender, EventArgs e)
        {
            SaveFilePathGet("图片", txtImgFile);
        }

        private void btnBase64File_Click(object sender, EventArgs e)
        {
            SaveFilePathGet("Base64编码", txtBase64File);
        }

        private void SaveFilePathGet(string type, TextBox pathtxtBox)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.Description = "请选择保存" + type + "的文件夹";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathtxtBox.Text = dialog.SelectedPath;
            }
        }

        //初始化保存区
        private void InitSavePanel()
        {
            chBase64Panel.Checked = true;
            chBase64Panel.CheckState = CheckState.Checked;
            chImgFile.Checked = true;
            chImgFile.CheckState = CheckState.Checked;
            txtImgFile.Visible = true;
            btnImgFile.Visible = true;
            txtImgFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            chImgPanel.Checked = false;
            chImgPanel.CheckState = CheckState.Unchecked;
            chBase64File.Checked = false;
            chBase64File.CheckState = CheckState.Unchecked;
            txtBase64File.Visible = false;
            btnBase64File.Visible = false;
            txtBase64File.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            chImgName.Checked = false;
            chImgName.CheckState = CheckState.Unchecked;
            chOCR.Checked = false;
            chOCR.CheckState = CheckState.Unchecked;
        }
        #endregion

        #region 范围选择区
        Point start = new Point();
        Point end = new Point();
        int width = 0, height = 0;

        //初始化全屏幕
        private void InitAllScreen()
        {
            ScreenHotting.GetFullScreen(ref start, ref end, ref width, ref height, Scrscale, this);

            txtX.Text = start.X.ToString();
            txtY.Text = start.Y.ToString();
            txtWidth.Text = width.ToString();
            txtHeight.Text = height.ToString();

            PanitRange();
        }

        private void PanitRange()
        {
            ScreenHotting.GetFullScreen(ref start, ref end, ref width, ref height, Scrscale, this);

            int Sx = int.Parse(txtX.Text);
            int Sy = int.Parse(txtY.Text);
            int Sw = int.Parse(txtWidth.Text);
            int Sh = int.Parse(txtHeight.Text);

            int exSw = (int)((double)Sw / width * panScreen.Width);
            int exSh = (int)((double)Sh / height * panScreen.Height);
            int exSx = (int)((double)Sx / width * panScreen.Width);
            int exSy = (int)((double)Sy / height * panScreen.Height);

            picRange.Location = new Point(exSx, exSy);
            picRange.Width = exSw;
            picRange.Height = exSh;
        }
        #endregion

        #region 水印设置区
        private void chWaterMask_Click(object sender, EventArgs e)
        {
            if (chWaterMask.Checked == true)
            {
                chWaterMask.Checked = true;
                chWaterMask.CheckState = CheckState.Checked;
            }
            else
            {
                chWaterMask.Checked = false;
                chWaterMask.CheckState = CheckState.Unchecked;  
            }
        }

        private void InitWaterMask()
        {
            chWaterMask.Checked = true;
            chWaterMask.CheckState = CheckState.Unchecked;
            txtWaterMask.Text = "Geoyee@yeah.net";
            cbbColor.Text = "灰色";
        }
        #endregion

        #region 模式选择区
        private void chPrtScr_Click(object sender, EventArgs e)
        {
            if (chPrtScr.Checked == true)
            {
                chPrtScr.Checked = true;
                chPrtScr.CheckState = CheckState.Checked;
            }
            else
            {
                chPrtScr.Checked = false;
                chPrtScr.CheckState = CheckState.Unchecked;
            }
        }

        private void InitMode()
        {
            chPrtScr.Checked = true;
            chPrtScr.CheckState = CheckState.Checked;
            cbbMode.Text = "一劳永逸";
        }
        #endregion

        #region API设置区
        private void InitAPI()
        {
            txtTid.Text = "";
            txtTsk.Text = "";
            txtOid.Text = "";
            txtOsk.Text = "";
        }
        #endregion

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtWaterMask.Text.Contains("◆"))
            {
                txtWaterMask.Text = "";
                MessageBox.Show("请勿输入带 ◆ 的水印文字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (FileStream userWrite = new FileStream(Environment.CurrentDirectory + "\\Users.set", FileMode.Truncate, FileAccess.Write))
                {
                    StreamWriter stw = new StreamWriter(userWrite, Encoding.GetEncoding("utf-8"));

                    WriteSetInfomation(stw);
                    stw.Close();
                }

                this.Close();
            } 
        }

        private void 恢复默认设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitSavePanel();
            InitAllScreen();
            InitWaterMask();
            InitMode();
            InitAPI();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
        }


        private void WriteSetInfomation(StreamWriter stw)
        {
            //写图保存方式
            if (chImgFile.Checked == true && chImgPanel.Checked == false)
            {
                stw.WriteLine("Image◆" + "File◆" + txtImgFile.Text);
            }
            else if (chImgFile.Checked == false && chImgPanel.Checked == true)
            {
                stw.WriteLine("Image◆" + "Panel");
            }
            else
            {
                stw.WriteLine("Image◆" + "Null");
            }
            //写Base64编码保存方式
            if (chBase64File.Checked == true && chBase64Panel.Checked == false)
            {
                stw.WriteLine("Base64◆" + "File◆" + txtBase64File.Text);
            }
            else if (chBase64File.Checked == false && chBase64Panel.Checked == true)
            {
                stw.WriteLine("Base64◆" + "Panel");
            }
            else
            {
                stw.WriteLine("Base64◆" + "Null");
            }
            //写截图范围
            stw.WriteLine(txtX.Text + "◆" + txtY.Text + "◆" + txtWidth.Text + "◆" + txtHeight.Text);
            //写水印设置
            if (chWaterMask.Checked == true)
            {
                stw.WriteLine(txtWaterMask.Text + "◆" + cbbColor.Text + "◆" + "In");
            }
            else
            {
                stw.WriteLine(txtWaterMask.Text + "◆" + cbbColor.Text + "◆" + "Out");
            }
            //写屏幕缩放
            stw.WriteLine("Scale◆" + Scrscale.ToString());
            //写是否保存文件名到剪贴板
            if (chImgName.Checked == true)
            {
                stw.WriteLine("Name◆In");
            }
            else
            {
                stw.WriteLine("Name◆Out");
            }
            //写模式
            if (chPrtScr.Checked == true)
            {
                stw.WriteLine("PrtScr◆In◆" + cbbMode.Text);
            }
            else
            {
                stw.WriteLine("PrtScr◆Out◆" + cbbMode.Text);
            }
            //写是否OCR到剪贴板
            if (chOCR.Checked == true)
            {
                stw.WriteLine("OCR◆In");
            }
            else
            {
                stw.WriteLine("OCR◆Out");
            }
            //写API设置
            stw.WriteLine(txtTid.Text + "◆" + txtTsk.Text);
            stw.WriteLine(txtOid.Text + "◆" + txtOsk.Text);
        }
    }
}