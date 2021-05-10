namespace Eascry
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSave = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.chOCR = new System.Windows.Forms.CheckBox();
            this.chImgName = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBase64File = new System.Windows.Forms.TextBox();
            this.btnBase64File = new System.Windows.Forms.Button();
            this.chBase64Panel = new System.Windows.Forms.CheckBox();
            this.chBase64File = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImgFile = new System.Windows.Forms.TextBox();
            this.btnImgFile = new System.Windows.Forms.Button();
            this.chImgPanel = new System.Windows.Forms.CheckBox();
            this.chImgFile = new System.Windows.Forms.CheckBox();
            this.tabRange = new System.Windows.Forms.TabPage();
            this.panScreen = new System.Windows.Forms.Panel();
            this.picRange = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.tabWaterMask = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.txtWaterMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chWaterMask = new System.Windows.Forms.CheckBox();
            this.tabMode = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.chPrtScr = new System.Windows.Forms.CheckBox();
            this.tabAPI = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复默认设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.txtTsk = new System.Windows.Forms.TextBox();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.txtOsk = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabSave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabRange.SuspendLayout();
            this.panScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRange)).BeginInit();
            this.tabWaterMask.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tabAPI.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabSave);
            this.tabControl1.Controls.Add(this.tabRange);
            this.tabControl1.Controls.Add(this.tabWaterMask);
            this.tabControl1.Controls.Add(this.tabMode);
            this.tabControl1.Controls.Add(this.tabAPI);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSave
            // 
            this.tabSave.Controls.Add(this.label6);
            this.tabSave.Controls.Add(this.chOCR);
            this.tabSave.Controls.Add(this.chImgName);
            this.tabSave.Controls.Add(this.groupBox2);
            this.tabSave.Controls.Add(this.groupBox1);
            this.tabSave.Location = new System.Drawing.Point(26, 4);
            this.tabSave.Margin = new System.Windows.Forms.Padding(4);
            this.tabSave.Name = "tabSave";
            this.tabSave.Padding = new System.Windows.Forms.Padding(4);
            this.tabSave.Size = new System.Drawing.Size(362, 318);
            this.tabSave.TabIndex = 0;
            this.tabSave.Text = "保存";
            this.tabSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "剪贴板应用";
            // 
            // chOCR
            // 
            this.chOCR.AutoSize = true;
            this.chOCR.Location = new System.Drawing.Point(251, 277);
            this.chOCR.Margin = new System.Windows.Forms.Padding(4);
            this.chOCR.Name = "chOCR";
            this.chOCR.Size = new System.Drawing.Size(83, 19);
            this.chOCR.TabIndex = 5;
            this.chOCR.Text = "快速OCR";
            this.chOCR.UseVisualStyleBackColor = true;
            this.chOCR.Click += new System.EventHandler(this.chOCR_Click);
            // 
            // chImgName
            // 
            this.chImgName.AutoSize = true;
            this.chImgName.Location = new System.Drawing.Point(128, 277);
            this.chImgName.Margin = new System.Windows.Forms.Padding(4);
            this.chImgName.Name = "chImgName";
            this.chImgName.Size = new System.Drawing.Size(104, 19);
            this.chImgName.TabIndex = 4;
            this.chImgName.Text = "保存文件名";
            this.chImgName.UseVisualStyleBackColor = true;
            this.chImgName.Click += new System.EventHandler(this.chImgName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBase64File);
            this.groupBox2.Controls.Add(this.btnBase64File);
            this.groupBox2.Controls.Add(this.chBase64Panel);
            this.groupBox2.Controls.Add(this.chBase64File);
            this.groupBox2.Location = new System.Drawing.Point(8, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(345, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "base64编码";
            // 
            // txtBase64File
            // 
            this.txtBase64File.Location = new System.Drawing.Point(158, 22);
            this.txtBase64File.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase64File.Name = "txtBase64File";
            this.txtBase64File.Size = new System.Drawing.Size(124, 25);
            this.txtBase64File.TabIndex = 5;
            this.txtBase64File.Visible = false;
            // 
            // btnBase64File
            // 
            this.btnBase64File.Location = new System.Drawing.Point(290, 22);
            this.btnBase64File.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase64File.Name = "btnBase64File";
            this.btnBase64File.Size = new System.Drawing.Size(36, 26);
            this.btnBase64File.TabIndex = 4;
            this.btnBase64File.Text = "…";
            this.btnBase64File.UseVisualStyleBackColor = true;
            this.btnBase64File.Visible = false;
            this.btnBase64File.Click += new System.EventHandler(this.btnBase64File_Click);
            // 
            // chBase64Panel
            // 
            this.chBase64Panel.AutoSize = true;
            this.chBase64Panel.Location = new System.Drawing.Point(8, 71);
            this.chBase64Panel.Margin = new System.Windows.Forms.Padding(4);
            this.chBase64Panel.Name = "chBase64Panel";
            this.chBase64Panel.Size = new System.Drawing.Size(119, 19);
            this.chBase64Panel.TabIndex = 3;
            this.chBase64Panel.Text = "保存到剪贴板";
            this.chBase64Panel.UseVisualStyleBackColor = true;
            this.chBase64Panel.Click += new System.EventHandler(this.chBase64Panel_Click);
            // 
            // chBase64File
            // 
            this.chBase64File.AutoSize = true;
            this.chBase64File.Location = new System.Drawing.Point(8, 25);
            this.chBase64File.Margin = new System.Windows.Forms.Padding(4);
            this.chBase64File.Name = "chBase64File";
            this.chBase64File.Size = new System.Drawing.Size(119, 19);
            this.chBase64File.TabIndex = 2;
            this.chBase64File.Text = "保存到文件夹";
            this.chBase64File.UseVisualStyleBackColor = true;
            this.chBase64File.Click += new System.EventHandler(this.chBase64File_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImgFile);
            this.groupBox1.Controls.Add(this.btnImgFile);
            this.groupBox1.Controls.Add(this.chImgPanel);
            this.groupBox1.Controls.Add(this.chImgFile);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(345, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像";
            // 
            // txtImgFile
            // 
            this.txtImgFile.Location = new System.Drawing.Point(158, 22);
            this.txtImgFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtImgFile.Name = "txtImgFile";
            this.txtImgFile.Size = new System.Drawing.Size(124, 25);
            this.txtImgFile.TabIndex = 3;
            this.txtImgFile.Visible = false;
            // 
            // btnImgFile
            // 
            this.btnImgFile.Location = new System.Drawing.Point(290, 22);
            this.btnImgFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnImgFile.Name = "btnImgFile";
            this.btnImgFile.Size = new System.Drawing.Size(36, 26);
            this.btnImgFile.TabIndex = 2;
            this.btnImgFile.Text = "…";
            this.btnImgFile.UseVisualStyleBackColor = true;
            this.btnImgFile.Visible = false;
            this.btnImgFile.Click += new System.EventHandler(this.btnImgFile_Click);
            // 
            // chImgPanel
            // 
            this.chImgPanel.AutoSize = true;
            this.chImgPanel.Location = new System.Drawing.Point(8, 71);
            this.chImgPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chImgPanel.Name = "chImgPanel";
            this.chImgPanel.Size = new System.Drawing.Size(119, 19);
            this.chImgPanel.TabIndex = 1;
            this.chImgPanel.Text = "保存到剪贴板";
            this.chImgPanel.UseVisualStyleBackColor = true;
            this.chImgPanel.Click += new System.EventHandler(this.chImgPanel_Click);
            // 
            // chImgFile
            // 
            this.chImgFile.AutoSize = true;
            this.chImgFile.Location = new System.Drawing.Point(8, 25);
            this.chImgFile.Margin = new System.Windows.Forms.Padding(4);
            this.chImgFile.Name = "chImgFile";
            this.chImgFile.Size = new System.Drawing.Size(119, 19);
            this.chImgFile.TabIndex = 0;
            this.chImgFile.Text = "保存到文件夹";
            this.chImgFile.UseVisualStyleBackColor = true;
            this.chImgFile.Click += new System.EventHandler(this.chImgFile_Click);
            // 
            // tabRange
            // 
            this.tabRange.Controls.Add(this.panScreen);
            this.tabRange.Controls.Add(this.label4);
            this.tabRange.Controls.Add(this.txtHeight);
            this.tabRange.Controls.Add(this.txtWidth);
            this.tabRange.Controls.Add(this.txtY);
            this.tabRange.Controls.Add(this.txtX);
            this.tabRange.Controls.Add(this.lblHeight);
            this.tabRange.Controls.Add(this.lblWidth);
            this.tabRange.Controls.Add(this.lblY);
            this.tabRange.Controls.Add(this.lblX);
            this.tabRange.Location = new System.Drawing.Point(26, 4);
            this.tabRange.Margin = new System.Windows.Forms.Padding(4);
            this.tabRange.Name = "tabRange";
            this.tabRange.Padding = new System.Windows.Forms.Padding(4);
            this.tabRange.Size = new System.Drawing.Size(362, 318);
            this.tabRange.TabIndex = 1;
            this.tabRange.Text = "范围";
            this.tabRange.UseVisualStyleBackColor = true;
            // 
            // panScreen
            // 
            this.panScreen.BackColor = System.Drawing.Color.Silver;
            this.panScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panScreen.Controls.Add(this.picRange);
            this.panScreen.Location = new System.Drawing.Point(8, 78);
            this.panScreen.Margin = new System.Windows.Forms.Padding(4);
            this.panScreen.Name = "panScreen";
            this.panScreen.Size = new System.Drawing.Size(344, 203);
            this.panScreen.TabIndex = 12;
            // 
            // picRange
            // 
            this.picRange.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRange.Location = new System.Drawing.Point(4, 4);
            this.picRange.Margin = new System.Windows.Forms.Padding(4);
            this.picRange.Name = "picRange";
            this.picRange.Size = new System.Drawing.Size(120, 70);
            this.picRange.TabIndex = 11;
            this.picRange.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "范围修改请在上一界面完成";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(249, 44);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(62, 25);
            this.txtHeight.TabIndex = 9;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(249, 15);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(62, 25);
            this.txtWidth.TabIndex = 8;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(65, 44);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(62, 25);
            this.txtY.TabIndex = 7;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(65, 15);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(62, 25);
            this.txtX.TabIndex = 6;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(190, 49);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeight.Size = new System.Drawing.Size(55, 15);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(198, 21);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(47, 15);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(44, 49);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 15);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(44, 21);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 15);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // tabWaterMask
            // 
            this.tabWaterMask.Controls.Add(this.label3);
            this.tabWaterMask.Controls.Add(this.cbbColor);
            this.tabWaterMask.Controls.Add(this.txtWaterMask);
            this.tabWaterMask.Controls.Add(this.label2);
            this.tabWaterMask.Controls.Add(this.label1);
            this.tabWaterMask.Controls.Add(this.chWaterMask);
            this.tabWaterMask.Location = new System.Drawing.Point(26, 4);
            this.tabWaterMask.Margin = new System.Windows.Forms.Padding(4);
            this.tabWaterMask.Name = "tabWaterMask";
            this.tabWaterMask.Size = new System.Drawing.Size(362, 318);
            this.tabWaterMask.TabIndex = 2;
            this.tabWaterMask.Text = "水印";
            this.tabWaterMask.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "请勿在水印名中包含 ◆";
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Items.AddRange(new object[] {
            "黑色",
            "白色",
            "灰色",
            "红色",
            "黄色",
            "蓝色",
            "绿色"});
            this.cbbColor.Location = new System.Drawing.Point(136, 136);
            this.cbbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(150, 23);
            this.cbbColor.TabIndex = 4;
            // 
            // txtWaterMask
            // 
            this.txtWaterMask.Location = new System.Drawing.Point(136, 88);
            this.txtWaterMask.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaterMask.Name = "txtWaterMask";
            this.txtWaterMask.Size = new System.Drawing.Size(150, 25);
            this.txtWaterMask.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "文字颜色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "水印文字";
            // 
            // chWaterMask
            // 
            this.chWaterMask.AutoSize = true;
            this.chWaterMask.Location = new System.Drawing.Point(198, 183);
            this.chWaterMask.Margin = new System.Windows.Forms.Padding(4);
            this.chWaterMask.Name = "chWaterMask";
            this.chWaterMask.Size = new System.Drawing.Size(89, 19);
            this.chWaterMask.TabIndex = 0;
            this.chWaterMask.Text = "添加水印";
            this.chWaterMask.UseVisualStyleBackColor = true;
            this.chWaterMask.Click += new System.EventHandler(this.chWaterMask_Click);
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.label5);
            this.tabMode.Controls.Add(this.cbbMode);
            this.tabMode.Controls.Add(this.chPrtScr);
            this.tabMode.Location = new System.Drawing.Point(26, 4);
            this.tabMode.Margin = new System.Windows.Forms.Padding(4);
            this.tabMode.Name = "tabMode";
            this.tabMode.Size = new System.Drawing.Size(362, 318);
            this.tabMode.TabIndex = 3;
            this.tabMode.Text = "模式";
            this.tabMode.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "截图模式";
            // 
            // cbbMode
            // 
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "即拍即得",
            "一劳永逸"});
            this.cbbMode.Location = new System.Drawing.Point(151, 106);
            this.cbbMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(150, 23);
            this.cbbMode.TabIndex = 3;
            // 
            // chPrtScr
            // 
            this.chPrtScr.AutoSize = true;
            this.chPrtScr.Location = new System.Drawing.Point(66, 187);
            this.chPrtScr.Margin = new System.Windows.Forms.Padding(4);
            this.chPrtScr.Name = "chPrtScr";
            this.chPrtScr.Size = new System.Drawing.Size(182, 19);
            this.chPrtScr.TabIndex = 2;
            this.chPrtScr.Text = "是否启用快捷键PrtScr";
            this.chPrtScr.UseVisualStyleBackColor = true;
            this.chPrtScr.Click += new System.EventHandler(this.chPrtScr_Click);
            // 
            // tabAPI
            // 
            this.tabAPI.Controls.Add(this.groupBox4);
            this.tabAPI.Controls.Add(this.groupBox3);
            this.tabAPI.Controls.Add(this.label8);
            this.tabAPI.Location = new System.Drawing.Point(26, 4);
            this.tabAPI.Name = "tabAPI";
            this.tabAPI.Size = new System.Drawing.Size(362, 318);
            this.tabAPI.TabIndex = 4;
            this.tabAPI.Text = "API设置";
            this.tabAPI.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOsk);
            this.groupBox4.Controls.Add(this.txtOid);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 173);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(345, 116);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "百度OCR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTsk);
            this.groupBox3.Controls.Add(this.txtTid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(345, 116);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "百度翻译";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Secret Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "APP ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取消ToolStripMenuItem,
            this.保存设置ToolStripMenuItem,
            this.恢复默认设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 326);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(392, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 取消ToolStripMenuItem
            // 
            this.取消ToolStripMenuItem.Name = "取消ToolStripMenuItem";
            this.取消ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.取消ToolStripMenuItem.Text = "取消";
            this.取消ToolStripMenuItem.Click += new System.EventHandler(this.取消ToolStripMenuItem_Click);
            // 
            // 保存设置ToolStripMenuItem
            // 
            this.保存设置ToolStripMenuItem.Name = "保存设置ToolStripMenuItem";
            this.保存设置ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.保存设置ToolStripMenuItem.Text = "保存设置";
            this.保存设置ToolStripMenuItem.Click += new System.EventHandler(this.保存设置ToolStripMenuItem_Click);
            // 
            // 恢复默认设置ToolStripMenuItem
            // 
            this.恢复默认设置ToolStripMenuItem.Name = "恢复默认设置ToolStripMenuItem";
            this.恢复默认设置ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.恢复默认设置ToolStripMenuItem.Text = "恢复默认设置";
            this.恢复默认设置ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认设置ToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Secret Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "API Key";
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(122, 30);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(197, 25);
            this.txtTid.TabIndex = 2;
            // 
            // txtTsk
            // 
            this.txtTsk.Location = new System.Drawing.Point(122, 78);
            this.txtTsk.Name = "txtTsk";
            this.txtTsk.Size = new System.Drawing.Size(197, 25);
            this.txtTsk.TabIndex = 3;
            // 
            // txtOid
            // 
            this.txtOid.Location = new System.Drawing.Point(122, 29);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(197, 25);
            this.txtOid.TabIndex = 4;
            // 
            // txtOsk
            // 
            this.txtOsk.Location = new System.Drawing.Point(122, 77);
            this.txtOsk.Name = "txtOsk";
            this.txtOsk.Size = new System.Drawing.Size(197, 25);
            this.txtOsk.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(392, 354);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabSave.ResumeLayout(false);
            this.tabSave.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabRange.ResumeLayout(false);
            this.tabRange.PerformLayout();
            this.panScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRange)).EndInit();
            this.tabWaterMask.ResumeLayout(false);
            this.tabWaterMask.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tabMode.PerformLayout();
            this.tabAPI.ResumeLayout(false);
            this.tabAPI.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chBase64Panel;
        private System.Windows.Forms.CheckBox chBase64File;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chImgPanel;
        private System.Windows.Forms.CheckBox chImgFile;
        private System.Windows.Forms.TabPage tabRange;
        private System.Windows.Forms.TabPage tabWaterMask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 取消ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认设置ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtImgFile;
        private System.Windows.Forms.Button btnImgFile;
        private System.Windows.Forms.TextBox txtBase64File;
        private System.Windows.Forms.Button btnBase64File;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.TextBox txtWaterMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chWaterMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panScreen;
        private System.Windows.Forms.CheckBox chImgName;
        private System.Windows.Forms.TabPage tabMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.CheckBox chPrtScr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chOCR;
        private System.Windows.Forms.TabPage tabAPI;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOsk;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.TextBox txtTsk;
        private System.Windows.Forms.TextBox txtTid;
    }
}