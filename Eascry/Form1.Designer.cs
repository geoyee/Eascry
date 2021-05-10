namespace Eascry
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picSelectionRange = new System.Windows.Forms.PictureBox();
            this.btnSaveSetting = new System.Windows.Forms.ToolStripButton();
            this.btnRange = new System.Windows.Forms.ToolStripButton();
            this.btnHot = new System.Windows.Forms.ToolStripButton();
            this.btnTrans = new System.Windows.Forms.ToolStripButton();
            this.picP = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectionRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSetting,
            this.btnRange,
            this.btnHot,
            this.btnTrans});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(161, 61);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Eascry";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSelectionRange
            // 
            this.picSelectionRange.BackColor = System.Drawing.SystemColors.Highlight;
            this.picSelectionRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectionRange.Location = new System.Drawing.Point(0, 0);
            this.picSelectionRange.Name = "picSelectionRange";
            this.picSelectionRange.Size = new System.Drawing.Size(80, 61);
            this.picSelectionRange.TabIndex = 1;
            this.picSelectionRange.TabStop = false;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.AutoToolTip = false;
            this.btnSaveSetting.Image = global::Eascry.Properties.Resources.Pathset;
            this.btnSaveSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(40, 57);
            this.btnSaveSetting.Text = "设置";
            this.btnSaveSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // btnRange
            // 
            this.btnRange.AutoToolTip = false;
            this.btnRange.BackColor = System.Drawing.SystemColors.Control;
            this.btnRange.Image = global::Eascry.Properties.Resources.Look;
            this.btnRange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(40, 57);
            this.btnRange.Text = "区域";
            this.btnRange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnHot
            // 
            this.btnHot.AutoToolTip = false;
            this.btnHot.BackColor = System.Drawing.SystemColors.Control;
            this.btnHot.Image = global::Eascry.Properties.Resources.Rangeset;
            this.btnHot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(40, 57);
            this.btnHot.Text = "截图";
            this.btnHot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHot.Click += new System.EventHandler(this.btnHot_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.AutoToolTip = false;
            this.btnTrans.Image = global::Eascry.Properties.Resources.Translate;
            this.btnTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(40, 57);
            this.btnTrans.Text = "翻译";
            this.btnTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // picP
            // 
            this.picP.BackColor = System.Drawing.Color.Transparent;
            this.picP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picP.Location = new System.Drawing.Point(0, 0);
            this.picP.Name = "picP";
            this.picP.Size = new System.Drawing.Size(161, 61);
            this.picP.TabIndex = 2;
            this.picP.TabStop = false;
            this.picP.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(161, 61);
            this.Controls.Add(this.picP);
            this.Controls.Add(this.picSelectionRange);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eascry β4.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectionRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSaveSetting;
        private System.Windows.Forms.ToolStripButton btnHot;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton btnRange;
        private System.Windows.Forms.PictureBox picSelectionRange;
        private System.Windows.Forms.ToolStripButton btnTrans;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picP;
    }
}

