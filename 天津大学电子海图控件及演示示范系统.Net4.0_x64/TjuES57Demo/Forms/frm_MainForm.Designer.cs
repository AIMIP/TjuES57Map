using System.Windows.Forms;

namespace TjuES57Demo.Forms
{
    partial class fr_MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("海图管理");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载海图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.saveScreenmap = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_基本显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_标准显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_全部显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_传统纸质符号 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_简单符号 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.显示文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChineseShow = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.IsShowDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.IsShowMeta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_符号化区域边界 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_简单区域边界 = new System.Windows.Forms.ToolStripMenuItem();
            this.安全等深线设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_5米 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_10米 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_20米 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_30米 = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_daybright = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_daywhite = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dayblack = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dusk = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_night = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.设置背景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图幅控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapListManager = new System.Windows.Forms.ToolStripMenuItem();
            this.图幅复位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.海图设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_显示经纬网 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_显示指北针 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_显示比例尺 = new System.Windows.Forms.ToolStripMenuItem();
            this.海图透明度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.海图边框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示海图边框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示海图名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置边框颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公里海里切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制点位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制折线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制多边形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测距ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测面积ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标注文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.导出标绘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入标绘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel1_screenPoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_curscale = new System.Windows.Forms.ToolStripStatusLabel();
            this.upleftX = new System.Windows.Forms.ToolStripStatusLabel();
            this.upleftY = new System.Windows.Forms.ToolStripStatusLabel();
            this.downrightX = new System.Windows.Forms.ToolStripStatusLabel();
            this.downrightY = new System.Windows.Forms.ToolStripStatusLabel();
            this.currendrawTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.MapLayersInfoTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.map1 = new TjuES57Map.TjuES57MapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.初始化图层显示状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.显示模式ToolStripMenuItem,
            this.安全等深线设置ToolStripMenuItem,
            this.颜色方案ToolStripMenuItem,
            this.图幅控制ToolStripMenuItem,
            this.海图设置SToolStripMenuItem,
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1233, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载海图ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.toolStripMenuItem13,
            this.saveScreenmap,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.文件ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.文件管理;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.文件ToolStripMenuItem.Text = "文件管理(&F)";
            // 
            // 加载海图ToolStripMenuItem
            // 
            this.加载海图ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.加载海图ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.加载海图ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.加载海图;
            this.加载海图ToolStripMenuItem.Name = "加载海图ToolStripMenuItem";
            this.加载海图ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.加载海图ToolStripMenuItem.Text = "加载海图";
            this.加载海图ToolStripMenuItem.Click += new System.EventHandler(this.OpenS57File_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.清空ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.清空ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.清除海图;
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.清空ToolStripMenuItem.Text = "清除海图";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuIte_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(155, 6);
            // 
            // saveScreenmap
            // 
            this.saveScreenmap.Font = new System.Drawing.Font("黑体", 15F);
            this.saveScreenmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.saveScreenmap.Image = global::TjuES57Demo.Properties.Resources.海图出图;
            this.saveScreenmap.Name = "saveScreenmap";
            this.saveScreenmap.Size = new System.Drawing.Size(158, 24);
            this.saveScreenmap.Text = "海图出图";
            this.saveScreenmap.Click += new System.EventHandler(this.saveScreenmap_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.退出ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.系统退出;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.退出ToolStripMenuItem.Text = "系统退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuIte_Click);
            // 
            // 显示模式ToolStripMenuItem
            // 
            this.显示模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_基本显示,
            this.menu_标准显示,
            this.menu_全部显示,
            this.toolStripMenuItem2,
            this.menu_传统纸质符号,
            this.menu_简单符号,
            this.toolStripMenuItem6,
            this.显示文本ToolStripMenuItem,
            this.toolStripMenuItem11,
            this.IsShowDepth,
            this.IsShowMeta,
            this.toolStripMenuItem4,
            this.menu_符号化区域边界,
            this.menu_简单区域边界});
            this.显示模式ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.显示模式ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.显示模式ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.参数设置;
            this.显示模式ToolStripMenuItem.Name = "显示模式ToolStripMenuItem";
            this.显示模式ToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.显示模式ToolStripMenuItem.Text = "参数设置(&M)";
            // 
            // menu_基本显示
            // 
            this.menu_基本显示.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_基本显示.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_基本显示.Image = global::TjuES57Demo.Properties.Resources.基本显示;
            this.menu_基本显示.Name = "menu_基本显示";
            this.menu_基本显示.Size = new System.Drawing.Size(218, 24);
            this.menu_基本显示.Text = "基本显示";
            this.menu_基本显示.Click += new System.EventHandler(this.基本显示ToolStripMenuIte_Click);
            // 
            // menu_标准显示
            // 
            this.menu_标准显示.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_标准显示.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_标准显示.Image = global::TjuES57Demo.Properties.Resources.标准显示;
            this.menu_标准显示.Name = "menu_标准显示";
            this.menu_标准显示.Size = new System.Drawing.Size(218, 24);
            this.menu_标准显示.Text = "标准显示";
            this.menu_标准显示.Click += new System.EventHandler(this.标准显示ToolStripMenuIte_Click);
            // 
            // menu_全部显示
            // 
            this.menu_全部显示.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_全部显示.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_全部显示.Image = global::TjuES57Demo.Properties.Resources.全部显示;
            this.menu_全部显示.Name = "menu_全部显示";
            this.menu_全部显示.Size = new System.Drawing.Size(218, 24);
            this.menu_全部显示.Text = "全部显示";
            this.menu_全部显示.Click += new System.EventHandler(this.全部显示ToolStripMenuIte_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // menu_传统纸质符号
            // 
            this.menu_传统纸质符号.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_传统纸质符号.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_传统纸质符号.Image = global::TjuES57Demo.Properties.Resources.传统纸质符号;
            this.menu_传统纸质符号.Name = "menu_传统纸质符号";
            this.menu_传统纸质符号.Size = new System.Drawing.Size(218, 24);
            this.menu_传统纸质符号.Text = "传统纸质符号";
            this.menu_传统纸质符号.Click += new System.EventHandler(this.menu_传统纸质符号_Click);
            // 
            // menu_简单符号
            // 
            this.menu_简单符号.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_简单符号.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_简单符号.Image = global::TjuES57Demo.Properties.Resources.简单符号;
            this.menu_简单符号.Name = "menu_简单符号";
            this.menu_简单符号.Size = new System.Drawing.Size(218, 24);
            this.menu_简单符号.Text = "简单符号";
            this.menu_简单符号.Click += new System.EventHandler(this.menu_简单符号_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(215, 6);
            // 
            // 显示文本ToolStripMenuItem
            // 
            this.显示文本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChineseShow,
            this.EnglishShow});
            this.显示文本ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.显示文本ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.显示文本ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.显示文本;
            this.显示文本ToolStripMenuItem.Name = "显示文本ToolStripMenuItem";
            this.显示文本ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.显示文本ToolStripMenuItem.Text = "显示文本";
            // 
            // ChineseShow
            // 
            this.ChineseShow.Font = new System.Drawing.Font("黑体", 15F);
            this.ChineseShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.ChineseShow.Image = global::TjuES57Demo.Properties.Resources.中文显示;
            this.ChineseShow.Name = "ChineseShow";
            this.ChineseShow.Size = new System.Drawing.Size(158, 24);
            this.ChineseShow.Text = "中文显示";
            this.ChineseShow.Click += new System.EventHandler(this.chineseTextShow_Click);
            // 
            // EnglishShow
            // 
            this.EnglishShow.Font = new System.Drawing.Font("黑体", 15F);
            this.EnglishShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.EnglishShow.Image = global::TjuES57Demo.Properties.Resources.英文显示;
            this.EnglishShow.Name = "EnglishShow";
            this.EnglishShow.Size = new System.Drawing.Size(158, 24);
            this.EnglishShow.Text = "英文显示";
            this.EnglishShow.Click += new System.EventHandler(this.englishTextShow_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(215, 6);
            // 
            // IsShowDepth
            // 
            this.IsShowDepth.Font = new System.Drawing.Font("黑体", 15F);
            this.IsShowDepth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.IsShowDepth.Image = global::TjuES57Demo.Properties.Resources.显示水深点;
            this.IsShowDepth.Name = "IsShowDepth";
            this.IsShowDepth.Size = new System.Drawing.Size(218, 24);
            this.IsShowDepth.Text = "显示水深点";
            this.IsShowDepth.Click += new System.EventHandler(this.IsShowDepth_Click);
            // 
            // IsShowMeta
            // 
            this.IsShowMeta.Font = new System.Drawing.Font("黑体", 15F);
            this.IsShowMeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.IsShowMeta.Image = global::TjuES57Demo.Properties.Resources.显示元物标;
            this.IsShowMeta.Name = "IsShowMeta";
            this.IsShowMeta.Size = new System.Drawing.Size(218, 24);
            this.IsShowMeta.Text = "显示元物标";
            this.IsShowMeta.Click += new System.EventHandler(this.显示元物标ToolStripMenuIte_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // menu_符号化区域边界
            // 
            this.menu_符号化区域边界.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_符号化区域边界.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_符号化区域边界.Image = global::TjuES57Demo.Properties.Resources.符号化区域边界;
            this.menu_符号化区域边界.Name = "menu_符号化区域边界";
            this.menu_符号化区域边界.Size = new System.Drawing.Size(218, 24);
            this.menu_符号化区域边界.Text = "符号化区域边界";
            this.menu_符号化区域边界.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // menu_简单区域边界
            // 
            this.menu_简单区域边界.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_简单区域边界.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_简单区域边界.Image = global::TjuES57Demo.Properties.Resources.简单区域边界;
            this.menu_简单区域边界.Name = "menu_简单区域边界";
            this.menu_简单区域边界.Size = new System.Drawing.Size(218, 24);
            this.menu_简单区域边界.Text = "简单区域边界";
            this.menu_简单区域边界.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // 安全等深线设置ToolStripMenuItem
            // 
            this.安全等深线设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_5米,
            this.menu_10米,
            this.menu_20米,
            this.menu_30米});
            this.安全等深线设置ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.安全等深线设置ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.安全等深线设置ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.等深线设置;
            this.安全等深线设置ToolStripMenuItem.Name = "安全等深线设置ToolStripMenuItem";
            this.安全等深线设置ToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.安全等深线设置ToolStripMenuItem.Text = "等深线设置(&S)";
            // 
            // menu_5米
            // 
            this.menu_5米.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_5米.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_5米.Image = global::TjuES57Demo.Properties.Resources._5米等深线;
            this.menu_5米.Name = "menu_5米";
            this.menu_5米.Size = new System.Drawing.Size(178, 24);
            this.menu_5米.Text = "5米等深线";
            this.menu_5米.Click += new System.EventHandler(this.等深线5米ToolStripMenuIte_Click);
            // 
            // menu_10米
            // 
            this.menu_10米.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_10米.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_10米.Image = global::TjuES57Demo.Properties.Resources._10米等深线;
            this.menu_10米.Name = "menu_10米";
            this.menu_10米.Size = new System.Drawing.Size(178, 24);
            this.menu_10米.Text = "10米等深线";
            this.menu_10米.Click += new System.EventHandler(this.等深线10米ToolStripMenuIte_Click);
            // 
            // menu_20米
            // 
            this.menu_20米.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_20米.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_20米.Image = global::TjuES57Demo.Properties.Resources._20米等深线;
            this.menu_20米.Name = "menu_20米";
            this.menu_20米.Size = new System.Drawing.Size(178, 24);
            this.menu_20米.Text = "20米等深线";
            this.menu_20米.Click += new System.EventHandler(this.等深线20米ToolStripMenuIte_Click);
            // 
            // menu_30米
            // 
            this.menu_30米.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_30米.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_30米.Image = global::TjuES57Demo.Properties.Resources._30米等深线;
            this.menu_30米.Name = "menu_30米";
            this.menu_30米.Size = new System.Drawing.Size(178, 24);
            this.menu_30米.Text = "30米等深线";
            this.menu_30米.Click += new System.EventHandler(this.等深线30米ToolStripMenuIte_Click);
            // 
            // 颜色方案ToolStripMenuItem
            // 
            this.颜色方案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_daybright,
            this.menu_daywhite,
            this.menu_dayblack,
            this.menu_dusk,
            this.menu_night,
            this.toolStripMenuItem5,
            this.设置背景色ToolStripMenuItem});
            this.颜色方案ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.颜色方案ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.颜色方案ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.颜色方案;
            this.颜色方案ToolStripMenuItem.Name = "颜色方案ToolStripMenuItem";
            this.颜色方案ToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.颜色方案ToolStripMenuItem.Text = "颜色方案(&C)";
            // 
            // menu_daybright
            // 
            this.menu_daybright.Font = new System.Drawing.Font("黑体", 14F);
            this.menu_daybright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_daybright.Image = global::TjuES57Demo.Properties.Resources.Color_晴朗白天;
            this.menu_daybright.Name = "menu_daybright";
            this.menu_daybright.Size = new System.Drawing.Size(198, 24);
            this.menu_daybright.Text = "晴朗白天模式";
            this.menu_daybright.Click += new System.EventHandler(this.DAY_BRIGHT_Click);
            // 
            // menu_daywhite
            // 
            this.menu_daywhite.Font = new System.Drawing.Font("黑体", 14F);
            this.menu_daywhite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_daywhite.Image = global::TjuES57Demo.Properties.Resources.Color_白天;
            this.menu_daywhite.Name = "menu_daywhite";
            this.menu_daywhite.Size = new System.Drawing.Size(198, 24);
            this.menu_daywhite.Text = "白天模式";
            this.menu_daywhite.Click += new System.EventHandler(this.DAY_WHITEBACK_Click);
            // 
            // menu_dayblack
            // 
            this.menu_dayblack.Font = new System.Drawing.Font("黑体", 14F);
            this.menu_dayblack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_dayblack.Image = global::TjuES57Demo.Properties.Resources.Color_阴天;
            this.menu_dayblack.Name = "menu_dayblack";
            this.menu_dayblack.Size = new System.Drawing.Size(198, 24);
            this.menu_dayblack.Text = "阴天模式";
            this.menu_dayblack.Click += new System.EventHandler(this.DAY_BLACKBACK_Click);
            // 
            // menu_dusk
            // 
            this.menu_dusk.Font = new System.Drawing.Font("黑体", 14F);
            this.menu_dusk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_dusk.Image = global::TjuES57Demo.Properties.Resources.Color_黄昏;
            this.menu_dusk.Name = "menu_dusk";
            this.menu_dusk.Size = new System.Drawing.Size(198, 24);
            this.menu_dusk.Text = "黄昏模式";
            this.menu_dusk.Click += new System.EventHandler(this.DUSK_Click);
            // 
            // menu_night
            // 
            this.menu_night.Font = new System.Drawing.Font("黑体", 14F);
            this.menu_night.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_night.Image = global::TjuES57Demo.Properties.Resources.Color_黑夜;
            this.menu_night.Name = "menu_night";
            this.menu_night.Size = new System.Drawing.Size(198, 24);
            this.menu_night.Text = "黑夜模式";
            this.menu_night.Click += new System.EventHandler(this.NIGHT_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(195, 6);
            // 
            // 设置背景色ToolStripMenuItem
            // 
            this.设置背景色ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.设置背景色ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.设置背景色ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.设置背景色;
            this.设置背景色ToolStripMenuItem.Name = "设置背景色ToolStripMenuItem";
            this.设置背景色ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.设置背景色ToolStripMenuItem.Text = "设置背景色";
            this.设置背景色ToolStripMenuItem.Click += new System.EventHandler(this.设置背景色ToolStripMenuIte_Click);
            // 
            // 图幅控制ToolStripMenuItem
            // 
            this.图幅控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MapListManager,
            this.图幅复位ToolStripMenuItem});
            this.图幅控制ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.图幅控制ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.图幅控制ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.图层管理;
            this.图幅控制ToolStripMenuItem.Name = "图幅控制ToolStripMenuItem";
            this.图幅控制ToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.图幅控制ToolStripMenuItem.Text = "图层管理(&T)";
            // 
            // MapListManager
            // 
            this.MapListManager.Font = new System.Drawing.Font("黑体", 15F);
            this.MapListManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.MapListManager.Image = global::TjuES57Demo.Properties.Resources.海图图层管理;
            this.MapListManager.Name = "MapListManager";
            this.MapListManager.Size = new System.Drawing.Size(198, 24);
            this.MapListManager.Text = "海图图层管理";
            this.MapListManager.Click += new System.EventHandler(this.MapListManager_Click_1);
            // 
            // 图幅复位ToolStripMenuItem
            // 
            this.图幅复位ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.图幅复位ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.图幅复位ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.图幅复位;
            this.图幅复位ToolStripMenuItem.Name = "图幅复位ToolStripMenuItem";
            this.图幅复位ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.图幅复位ToolStripMenuItem.Text = "图幅复位";
            this.图幅复位ToolStripMenuItem.Click += new System.EventHandler(this.图幅复位ToolStripMenuIte_Click);
            // 
            // 海图设置SToolStripMenuItem
            // 
            this.海图设置SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_显示经纬网,
            this.menu_显示指北针,
            this.menu_显示比例尺,
            this.海图透明度ToolStripMenuItem,
            this.海图边框ToolStripMenuItem,
            this.公里海里切换ToolStripMenuItem});
            this.海图设置SToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.海图设置SToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.海图设置SToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.海图设置;
            this.海图设置SToolStripMenuItem.Name = "海图设置SToolStripMenuItem";
            this.海图设置SToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.海图设置SToolStripMenuItem.Text = "海图设置(&S)";
            // 
            // menu_显示经纬网
            // 
            this.menu_显示经纬网.Checked = true;
            this.menu_显示经纬网.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_显示经纬网.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_显示经纬网.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_显示经纬网.Image = global::TjuES57Demo.Properties.Resources.显示经纬网;
            this.menu_显示经纬网.Name = "menu_显示经纬网";
            this.menu_显示经纬网.Size = new System.Drawing.Size(178, 24);
            this.menu_显示经纬网.Text = "显示经纬网";
            this.menu_显示经纬网.Click += new System.EventHandler(this.显示经纬网ToolStripMenuIte_Click);
            // 
            // menu_显示指北针
            // 
            this.menu_显示指北针.Checked = true;
            this.menu_显示指北针.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_显示指北针.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_显示指北针.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_显示指北针.Image = global::TjuES57Demo.Properties.Resources.显示指北针;
            this.menu_显示指北针.Name = "menu_显示指北针";
            this.menu_显示指北针.Size = new System.Drawing.Size(178, 24);
            this.menu_显示指北针.Text = "显示指北针";
            this.menu_显示指北针.Click += new System.EventHandler(this.显示指北针ToolStripMenuIte_Click);
            // 
            // menu_显示比例尺
            // 
            this.menu_显示比例尺.Checked = true;
            this.menu_显示比例尺.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_显示比例尺.Font = new System.Drawing.Font("黑体", 15F);
            this.menu_显示比例尺.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.menu_显示比例尺.Image = global::TjuES57Demo.Properties.Resources.显示比例尺;
            this.menu_显示比例尺.Name = "menu_显示比例尺";
            this.menu_显示比例尺.Size = new System.Drawing.Size(178, 24);
            this.menu_显示比例尺.Text = "显示比例尺";
            this.menu_显示比例尺.Click += new System.EventHandler(this.显示比例尺ToolStripMenuIte_Click);
            // 
            // 海图透明度ToolStripMenuItem
            // 
            this.海图透明度ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.海图透明度ToolStripMenuItem.Name = "海图透明度ToolStripMenuItem";
            this.海图透明度ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.海图透明度ToolStripMenuItem.Text = "设置海图透明度";
            this.海图透明度ToolStripMenuItem.Click += new System.EventHandler(this.海图透明度ToolStripMenuItem_Click);
            // 
            // 海图边框ToolStripMenuItem
            // 
            this.海图边框ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示海图边框ToolStripMenuItem,
            this.显示海图名称ToolStripMenuItem,
            this.设置边框颜色ToolStripMenuItem});
            this.海图边框ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.海图边框ToolStripMenuItem.Name = "海图边框ToolStripMenuItem";
            this.海图边框ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.海图边框ToolStripMenuItem.Text = "设置海图边框及名称";
            // 
            // 显示海图边框ToolStripMenuItem
            // 
            this.显示海图边框ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.显示海图边框ToolStripMenuItem.Name = "显示海图边框ToolStripMenuItem";
            this.显示海图边框ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.显示海图边框ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.显示海图边框ToolStripMenuItem.Text = "未绘制海图时隐藏边框";
            this.显示海图边框ToolStripMenuItem.Click += new System.EventHandler(this.显示海图边框ToolStripMenuItem_Click);
            // 
            // 显示海图名称ToolStripMenuItem
            // 
            this.显示海图名称ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.显示海图名称ToolStripMenuItem.Name = "显示海图名称ToolStripMenuItem";
            this.显示海图名称ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.显示海图名称ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.显示海图名称ToolStripMenuItem.Text = "未绘制海图时隐藏名称";
            this.显示海图名称ToolStripMenuItem.Click += new System.EventHandler(this.显示海图名称ToolStripMenuItem_Click);
            // 
            // 设置边框颜色ToolStripMenuItem
            // 
            this.设置边框颜色ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.设置边框颜色ToolStripMenuItem.Name = "设置边框颜色ToolStripMenuItem";
            this.设置边框颜色ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.设置边框颜色ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.设置边框颜色ToolStripMenuItem.Text = "设置海图边框及名称颜色";
            this.设置边框颜色ToolStripMenuItem.Click += new System.EventHandler(this.设置边框颜色ToolStripMenuItem_Click);
            // 
            // 公里海里切换ToolStripMenuItem
            // 
            this.公里海里切换ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.公里海里切换ToolStripMenuItem.Name = "公里海里切换ToolStripMenuItem";
            this.公里海里切换ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.公里海里切换ToolStripMenuItem.Text = "比例尺切换为海里";
            this.公里海里切换ToolStripMenuItem.Click += new System.EventHandler(this.公里海里切换ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绘制点位ToolStripMenuItem,
            this.绘制折线ToolStripMenuItem,
            this.绘制多边形ToolStripMenuItem,
            this.绘制图片ToolStripMenuItem,
            this.测距ToolStripMenuItem,
            this.测面积ToolStripMenuItem,
            this.标注文本ToolStripMenuItem,
            this.toolStripSeparator1,
            this.导出标绘ToolStripMenuItem,
            this.导入标绘ToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("黑体", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.toolStripMenuItem1.Image = global::TjuES57Demo.Properties.Resources.海图标绘;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 28);
            this.toolStripMenuItem1.Text = "海图标绘(&D)";
            // 
            // 绘制点位ToolStripMenuItem
            // 
            this.绘制点位ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.绘制点位ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.绘制点位ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.绘制点位;
            this.绘制点位ToolStripMenuItem.Name = "绘制点位ToolStripMenuItem";
            this.绘制点位ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.绘制点位ToolStripMenuItem.Text = "绘制点位";
            this.绘制点位ToolStripMenuItem.Click += new System.EventHandler(this.绘制点位ToolStripMenuIte_Click);
            // 
            // 绘制折线ToolStripMenuItem
            // 
            this.绘制折线ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.绘制折线ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.绘制折线ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.绘制折线;
            this.绘制折线ToolStripMenuItem.Name = "绘制折线ToolStripMenuItem";
            this.绘制折线ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.绘制折线ToolStripMenuItem.Text = "绘制折线";
            this.绘制折线ToolStripMenuItem.Click += new System.EventHandler(this.绘制折线ToolStripMenuIte_Click);
            // 
            // 绘制多边形ToolStripMenuItem
            // 
            this.绘制多边形ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.绘制多边形ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.绘制多边形ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.绘制多边形;
            this.绘制多边形ToolStripMenuItem.Name = "绘制多边形ToolStripMenuItem";
            this.绘制多边形ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.绘制多边形ToolStripMenuItem.Text = "绘制多边形";
            this.绘制多边形ToolStripMenuItem.Click += new System.EventHandler(this.绘制多边形ToolStripMenuIte_Click);
            // 
            // 绘制图片ToolStripMenuItem
            // 
            this.绘制图片ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.绘制图片ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.绘制图片ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.绘制图片;
            this.绘制图片ToolStripMenuItem.Name = "绘制图片ToolStripMenuItem";
            this.绘制图片ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.绘制图片ToolStripMenuItem.Text = "绘制图片";
            this.绘制图片ToolStripMenuItem.Click += new System.EventHandler(this.绘制图片ToolStripMenuIte_Click);
            // 
            // 测距ToolStripMenuItem
            // 
            this.测距ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.测距ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.测距ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.测距;
            this.测距ToolStripMenuItem.Name = "测距ToolStripMenuItem";
            this.测距ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.测距ToolStripMenuItem.Text = "测距";
            this.测距ToolStripMenuItem.Click += new System.EventHandler(this.测距ToolStripMenuIte_Click);
            // 
            // 测面积ToolStripMenuItem
            // 
            this.测面积ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.测面积ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.测面积ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.测面积;
            this.测面积ToolStripMenuItem.Name = "测面积ToolStripMenuItem";
            this.测面积ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.测面积ToolStripMenuItem.Text = "测面积";
            this.测面积ToolStripMenuItem.Click += new System.EventHandler(this.测面积ToolStripMenuIte_Click);
            // 
            // 标注文本ToolStripMenuItem
            // 
            this.标注文本ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.标注文本ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.显示文本;
            this.标注文本ToolStripMenuItem.Name = "标注文本ToolStripMenuItem";
            this.标注文本ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.标注文本ToolStripMenuItem.Text = "标注文本";
            this.标注文本ToolStripMenuItem.Click += new System.EventHandler(this.标注文本ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // 导出标绘ToolStripMenuItem
            // 
            this.导出标绘ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.导出标绘ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.系统退出;
            this.导出标绘ToolStripMenuItem.Name = "导出标绘ToolStripMenuItem";
            this.导出标绘ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.导出标绘ToolStripMenuItem.Text = "导出标绘";
            this.导出标绘ToolStripMenuItem.Click += new System.EventHandler(this.导出标绘ToolStripMenuItem_Click);
            // 
            // 导入标绘ToolStripMenuItem
            // 
            this.导入标绘ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.导入标绘ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.加载海图;
            this.导入标绘ToolStripMenuItem.Name = "导入标绘ToolStripMenuItem";
            this.导入标绘ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.导入标绘ToolStripMenuItem.Text = "导入标绘";
            this.导入标绘ToolStripMenuItem.Click += new System.EventHandler(this.导入标绘ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统帮助ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.帮助ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.说明;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 系统帮助ToolStripMenuItem
            // 
            this.系统帮助ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 15F);
            this.系统帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.系统帮助ToolStripMenuItem.Image = global::TjuES57Demo.Properties.Resources.系统帮助;
            this.系统帮助ToolStripMenuItem.Name = "系统帮助ToolStripMenuItem";
            this.系统帮助ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.系统帮助ToolStripMenuItem.Text = "海图控件激活";
            this.系统帮助ToolStripMenuItem.Click += new System.EventHandler(this.系统帮助ToolStripMenuIte_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel1_screenPoint,
            this.StatusLabel_curscale,
            this.upleftX,
            this.upleftY,
            this.downrightX,
            this.downrightY,
            this.currendrawTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1908, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabel1_screenPoint
            // 
            this.StripStatusLabel1_screenPoint.BackColor = System.Drawing.SystemColors.Control;
            this.StripStatusLabel1_screenPoint.Font = new System.Drawing.Font("黑体", 12F);
            this.StripStatusLabel1_screenPoint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StripStatusLabel1_screenPoint.Name = "StripStatusLabel1_screenPoint";
            this.StripStatusLabel1_screenPoint.Size = new System.Drawing.Size(160, 17);
            this.StripStatusLabel1_screenPoint.Text = "屏幕坐标:x=0；y=0；";
            // 
            // StatusLabel_curscale
            // 
            this.StatusLabel_curscale.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusLabel_curscale.Font = new System.Drawing.Font("黑体", 12F);
            this.StatusLabel_curscale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel_curscale.Name = "StatusLabel_curscale";
            this.StatusLabel_curscale.Size = new System.Drawing.Size(136, 17);
            this.StatusLabel_curscale.Text = "当前比例尺：None";
            // 
            // upleftX
            // 
            this.upleftX.BackColor = System.Drawing.SystemColors.Window;
            this.upleftX.Name = "upleftX";
            this.upleftX.Size = new System.Drawing.Size(0, 17);
            // 
            // upleftY
            // 
            this.upleftY.BackColor = System.Drawing.SystemColors.Window;
            this.upleftY.Name = "upleftY";
            this.upleftY.Size = new System.Drawing.Size(0, 17);
            // 
            // downrightX
            // 
            this.downrightX.BackColor = System.Drawing.SystemColors.Window;
            this.downrightX.Name = "downrightX";
            this.downrightX.Size = new System.Drawing.Size(0, 17);
            // 
            // downrightY
            // 
            this.downrightY.BackColor = System.Drawing.SystemColors.Window;
            this.downrightY.Name = "downrightY";
            this.downrightY.Size = new System.Drawing.Size(0, 17);
            // 
            // currendrawTime
            // 
            this.currendrawTime.Name = "currendrawTime";
            this.currendrawTime.Size = new System.Drawing.Size(0, 17);
            // 
            // MapLayersInfoTree
            // 
            this.MapLayersInfoTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapLayersInfoTree.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MapLayersInfoTree.ImageIndex = 0;
            this.MapLayersInfoTree.ImageList = this.imageList1;
            this.MapLayersInfoTree.Location = new System.Drawing.Point(1589, 60);
            this.MapLayersInfoTree.Name = "MapLayersInfoTree";
            treeNode2.Name = "节点0";
            treeNode2.Text = "海图管理";
            this.MapLayersInfoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.MapLayersInfoTree.SelectedImageIndex = 0;
            this.MapLayersInfoTree.Size = new System.Drawing.Size(319, 376);
            this.MapLayersInfoTree.TabIndex = 6;
            this.MapLayersInfoTree.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.MapManagerTree_BeforeCheck);
            this.MapLayersInfoTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.MapLayersInfoTree_BeforeCollapse);
            this.MapLayersInfoTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.MapLayersInfoTree_BeforeExpand);
            this.MapLayersInfoTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MapManagerTree_NodeMouseClick);
            this.MapLayersInfoTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapLayersInfoTree_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "海图管理.png");
            this.imageList1.Images.SetKeyName(1, "海图文件.png");
            this.imageList1.Images.SetKeyName(2, "未选择.png");
            this.imageList1.Images.SetKeyName(3, "选择.png");
            // 
            // map1
            // 
            this.map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map1.AreaBorderType = TjuES57Map.TjuES57MapControl.E_AreaBorderType.符号化区域边界;
            this.map1.BackGroundColor = System.Drawing.Color.Transparent;
            this.map1.ColorMode = TjuES57Map.TjuES57MapControl.E_ColorMode.晴朗白天;
            this.map1.CurScale = 1000D;
            this.map1.IsChineseShow = false;
            this.map1.IsFlushMap = false;
            this.map1.IsobathModel = TjuES57Map.TjuES57MapControl.E_IsobathModel.二十米等深线;
            this.map1.IsShowDepth = false;
            this.map1.IsShowLonLatLines = true;
            this.map1.IsShowMapBound = true;
            this.map1.IsShowMapName = true;
            this.map1.IsShowNorth = true;
            this.map1.IsShowScale = true;
            this.map1.IsShowTapInfo = true;
            this.map1.LayerShowMode = TjuES57Map.TjuES57MapControl.E_LayerShowMode.标准显示;
            this.map1.Location = new System.Drawing.Point(0, 43);
            this.map1.MapNameBoundColor = System.Drawing.Color.Blue;
            this.map1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.map1.Name = "map1";
            this.map1.PointModeType = TjuES57Map.TjuES57MapControl.E_PointModeType.简单符号;
            this.map1.ShowMetaData = false;
            this.map1.Size = new System.Drawing.Size(1580, 395);
            this.map1.TabIndex = 11;
            this.map1.AfterMouseClick += new TjuES57Map.TjuES57MapControl.AfterMouseClickHandle(this.map1_AfterMouseClick);
            this.map1.AfterMouseDoubleClick += new TjuES57Map.TjuES57MapControl.AfterMouseDoubleClickHandle(this.map1_AfterDoubleMouseClick);
            this.map1.AfterMouseMove += new TjuES57Map.TjuES57MapControl.AfterMouseMoveHandle(this.map1_AfterMouseMove);
            this.map1.AfterMapDraw += new TjuES57Map.TjuES57MapControl.AfterMapDrawHandle(this.map1_AfterMapDraw);
            this.map1.AfterENCLoad += new TjuES57Map.TjuES57MapControl.AfterENCLoadHandle(this.map1_AfterENCLoad);
            this.map1.AfterIdentify += new TjuES57Map.TjuES57MapControl.AfterIdentifyHandle(this.map1_AfterIdentify);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化图层显示状态ToolStripMenuItem,
            this.空间查询ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 48);
            // 
            // 初始化图层显示状态ToolStripMenuItem
            // 
            this.初始化图层显示状态ToolStripMenuItem.Name = "初始化图层显示状态ToolStripMenuItem";
            this.初始化图层显示状态ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.初始化图层显示状态ToolStripMenuItem.Text = "初始化图层显示状态";
            this.初始化图层显示状态ToolStripMenuItem.Click += new System.EventHandler(this.初始化图层显示状态ToolStripMenuItem_Click);
            // 
            // 空间查询ToolStripMenuItem
            // 
            this.空间查询ToolStripMenuItem.Name = "空间查询ToolStripMenuItem";
            this.空间查询ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.空间查询ToolStripMenuItem.Text = "空间查询";
            this.空间查询ToolStripMenuItem.Click += new System.EventHandler(this.空间查询ToolStripMenuItem_Click);
            // 
            // fr_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1908, 461);
            this.Controls.Add(this.MapLayersInfoTree);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.map1);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fr_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "天津大学电子海图控件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;

        public ToolStripMenuItem OpenFile { get; private set; }

        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 显示模式ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem menu_基本显示;

        private System.Windows.Forms.ToolStripMenuItem menu_标准显示;

        private System.Windows.Forms.ToolStripMenuItem menu_全部显示;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem menu_传统纸质符号;

        private System.Windows.Forms.ToolStripMenuItem menu_简单符号;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

        private System.Windows.Forms.ToolStripMenuItem IsShowMeta;

        private System.Windows.Forms.ToolStripMenuItem 颜色方案ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem menu_daybright;

        private System.Windows.Forms.ToolStripMenuItem menu_daywhite;

        private System.Windows.Forms.ToolStripMenuItem menu_dayblack;

        private System.Windows.Forms.ToolStripMenuItem menu_dusk;

        private System.Windows.Forms.ToolStripMenuItem menu_night;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;

        private System.Windows.Forms.ToolStripMenuItem 设置背景色ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 安全等深线设置ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem menu_5米;

        private System.Windows.Forms.ToolStripMenuItem menu_10米;

        private System.Windows.Forms.ToolStripMenuItem menu_20米;

        private System.Windows.Forms.ToolStripMenuItem menu_30米;

        private System.Windows.Forms.ToolStripMenuItem 图幅控制ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton 粘贴PToolStripButton;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;

        private System.Windows.Forms.OpenFileDialog openFileDlg;

        private System.Windows.Forms.ToolStripMenuItem 系统帮助ToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton 打印PToolStripButton;

        private System.Windows.Forms.ToolStripButton 剪切UToolStripButton;

        private System.Windows.Forms.ToolStripMenuItem 显示文本ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem ChineseShow;

        private System.Windows.Forms.ToolStripMenuItem EnglishShow;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_curscale;

        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel1_screenPoint;

        private System.Windows.Forms.ToolStripStatusLabel upleftX;

        private System.Windows.Forms.ToolStripStatusLabel upleftY;

        private System.Windows.Forms.ToolStripStatusLabel downrightX;

        private System.Windows.Forms.ToolStripStatusLabel downrightY;

        private System.Windows.Forms.ToolStripMenuItem menu_符号化区域边界;

        private System.Windows.Forms.ToolStripMenuItem menu_简单区域边界;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;

        //public ToolStripMenuItem IsShowDepth { get; private set; }

        private System.Windows.Forms.ToolStripStatusLabel currendrawTime;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;

        private System.Windows.Forms.ToolStripMenuItem saveScreenmap;

        private System.Windows.Forms.ToolStripMenuItem MapListManager;

        private System.Windows.Forms.ToolStripMenuItem 图幅复位ToolStripMenuItem;
        private ToolStripMenuItem 海图设置SToolStripMenuItem;
        //public System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.TreeView MapLayersInfoTree;

        private System.Windows.Forms.ImageList imageList1;
        
        private System.Windows.Forms.ToolStripMenuItem 绘制点位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制折线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制多边形ToolStripMenuItem;
        private ToolStripMenuItem 绘制图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测距ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测面积ToolStripMenuItem;
        //private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menu_显示经纬网;
        private System.Windows.Forms.ToolStripMenuItem menu_显示指北针;
        private System.Windows.Forms.ToolStripMenuItem menu_显示比例尺;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion

        private ToolStripMenuItem 加载海图ToolStripMenuItem;
        public TjuES57Map.TjuES57MapControl map1;
        private ToolStripMenuItem IsShowDepth;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 初始化图层显示状态ToolStripMenuItem;
        private ToolStripMenuItem 空间查询ToolStripMenuItem;
        private ToolStripMenuItem 标注文本ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 导出标绘ToolStripMenuItem;
        private ToolStripMenuItem 导入标绘ToolStripMenuItem;
        private ToolStripMenuItem 海图透明度ToolStripMenuItem;
        private ToolStripMenuItem 海图边框ToolStripMenuItem;
        private ToolStripMenuItem 显示海图边框ToolStripMenuItem;
        private ToolStripMenuItem 显示海图名称ToolStripMenuItem;
        private ToolStripMenuItem 设置边框颜色ToolStripMenuItem;
        private ToolStripMenuItem 公里海里切换ToolStripMenuItem;
    }
}