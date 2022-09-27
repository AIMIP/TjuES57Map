using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TjuES57Demo.Forms.Forms;
using TjuES57Map;
using TjuES57Map.Library;

namespace TjuES57Demo.Forms
{
    public partial class fr_MainForm : Form
    {
        /// <summary>
        /// 记录当前海图绘制操作类型
        /// </summary>
        private string _curOperaterType = "";

        private TreeNode rightClickNode = new TreeNode();

        /// <summary>
        /// 当前海图操作类型
        /// </summary>
        public string CurOperaterType
        {
            get
            {
                return _curOperaterType;
            }
            set
            {
                _curOperaterType = value;
                switch (_curOperaterType)
                {
                    case "点选绘制点位":
                        map1.DrawPlotting.DrawPen.CurOperationType = "绘制点位";
                        break;
                    case "点选绘制折线":
                        map1.DrawPlotting.DrawPen.CurOperationType = "绘制折线";
                        break;
                    case "点选绘制多边形":
                        map1.DrawPlotting.DrawPen.CurOperationType = "绘制多边形";
                        break;
                    case "点选测距":
                        map1.DrawPlotting.DrawPen.CurOperationType = "测距";
                        break;
                    case "点选测面积":
                        map1.DrawPlotting.DrawPen.CurOperationType = "测面积";
                        break;
                    case "点选标注文本":
                        map1.DrawPlotting.DrawPen.CurOperationType = "标注文本";
                        break;
                    case "点选查询":
                        map1.DrawPlotting.DrawPen.CurOperationType = "查询";
                        break;
                    default:
                        map1.DrawPlotting.DrawPen.CurOperationType = "";
                        break;
                }
            }
        }

        string curShowMapFile = "";

        bool IsExpCol = false;

        public bool IsLayerManager = false;

        fr_TuCengManager LayerManager = new fr_TuCengManager();

        fr_Help frhelp = new fr_Help();

        /// <summary>
        /// 实例化点位绘制弹窗
        /// </summary>
        public fr_DrawPointInfo fr_DrawPointInfo = new fr_DrawPointInfo();

        /// <summary>
        /// 实例化折线绘制弹窗
        /// </summary>
        public fr_DrawLineInfo frmDrawLineInfo = new fr_DrawLineInfo();

        /// <summary>
        /// 实例化多边形绘制弹窗
        /// </summary>
        public fr_DrawPolygonInfo frmDrawPolygonInfo = new fr_DrawPolygonInfo();

        /// <summary>
        /// 实例化测距绘制弹窗
        /// </summary>
        public fr_Ranging frmRanging = new fr_Ranging();

        /// <summary>
        /// 实例化测面积绘制弹窗
        /// </summary>
        public fr_Area frmArea = new fr_Area();

        /// <summary>
        /// 实例化图片绘制弹窗
        /// </summary>
        public fr_DrawImageInfo fr_DrawImageInfo = new fr_DrawImageInfo();

        /// <summary>
        /// 实例化点位绘制弹窗
        /// </summary>
        public frm_Text fr_Text = new frm_Text();

        /// <summary>
        /// 实例化查询弹窗
        /// </summary>
        public frm_chaxun fr_Identify = new frm_chaxun();

        public frm_MapAlpha fr_MapAlpha = new frm_MapAlpha();

        /// <summary>
        /// 
        /// </summary>
        public fr_MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 主页面加载函数
        /// </summary>
        private void MainFor_Load(object sender, EventArgs e)
        {
            string[] S57MapFiles = new string[1];
            //读取海图文件
            StatusLabel_curscale.Text += "  海图加载中，请耐心等待...";
            map1.LoadMap(S57MapFiles);
            //设置当前海图显示模式
            SetState();
            //更新菜单栏信息
            updateMapLayerInfo();
        }


        /// <summary>
        /// 退出当前程序
        /// </summary>
        private void 退出ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否退出当前程序？", "消息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }


        /// <summary>
        /// 打开加载海图弹窗
        /// </summary>
        private void OpenS57File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "S57海图(*.000)|*.000";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Length > 0)
                {
                    StatusLabel_curscale.Text += "  海图加载中，请耐心等待...";
                    //读取海图文件
                    map1.LoadMap(openFileDialog.FileNames);
                    //更新菜单栏信息
                    updateMapLayerInfo();
                }
            }
        }

        /// <summary>
        /// 更新当前菜单栏中的图层信息
        /// </summary>
        public void updateMapLayerInfo()
        {

            //获取当前海图图层数据
            if (IsLayerManager)
            {
                for (int i = 0; i < MapLayersInfoTree.Nodes[0].Nodes.Count; i++)
                {
                    for (int j = 0; j < map1.ES57Para.ES57MapList.Count; j++)
                    {
                        if (MapLayersInfoTree.Nodes[0].Nodes[i].Text == map1.ES57Para.ES57MapList[j].Name)
                        {
                            Hashtable hsLayerInfo = map1.GetAllLayer(map1.ES57Para.ES57MapList[j].Name);
                            for (int k = 0; k < MapLayersInfoTree.Nodes[0].Nodes[i].Nodes.Count; k++)
                            {
                                foreach (DictionaryEntry item in hsLayerInfo)
                                {
                                    if (MapLayersInfoTree.Nodes[0].Nodes[i].Nodes[k].Text == item.Value.ToString())
                                    {
                                        bool ischecked = map1.ES57Para.GetAllMapOneLayerShow(item.Key.ToString());
                                        MapLayersInfoTree.Nodes[0].Nodes[i].Nodes[k].Checked = ischecked;
                                        MapLayersInfoTree.Nodes[0].Nodes[i].Nodes[k].ImageIndex = ischecked ? 3 : 2;
                                        MapLayersInfoTree.Nodes[0].Nodes[i].Nodes[k].SelectedImageIndex = ischecked ? 3 : 2;
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
                IsLayerManager = false;
                return;
            }
            MapLayersInfoTree.Nodes[0].Nodes.Clear();
            MapLayersInfoTree.Nodes[0].Checked = true;
            List<string> AllS57FileName = map1.GetAllFileName();
            //遍历所有图层数据并向菜单栏中添加图层数据
            for (int i = 0; i < AllS57FileName.Count; i++)
            {
                for (int j = 0; j < map1.ES57Para.ES57MapList.Count; j++)
                {
                    if (AllS57FileName[i] == map1.ES57Para.ES57MapList[j].Name)
                    {
                        if (map1.ES57Para.ES57MapList[j].IsOn || !map1.ES57Para.IsActivated)
                        {
                            Hashtable hsLayerInfo = map1.GetAllLayer(AllS57FileName[i]);
                            if (hsLayerInfo.Count <= 0) continue;
                            string showInfo = AllS57FileName[i];
                            TreeNode treeNode = new TreeNode(showInfo);
                            treeNode.Checked = true;
                            treeNode.ImageIndex = 1;
                            foreach (DictionaryEntry item in hsLayerInfo)
                            {
                                if (item.Key.ToString() == "DSID" || item.Key.ToString().Substring(0, 2) == "C_") continue;
                                TreeNode treeNode2 = new TreeNode(item.Value.ToString());
                                treeNode2.Name = item.Key.ToString();
                                treeNode2.Checked = map1.ES57Para.GetOneMapOneLayerShow(AllS57FileName[i], item.Key.ToString());
                                if (treeNode2.Name == "Text") treeNode2.Checked = true;
                                treeNode2.ImageIndex = treeNode2.Checked ? 3 : 2;
                                treeNode.Nodes.Add(treeNode2);
                            }
                            MapLayersInfoTree.Nodes[0].Nodes.Add(treeNode);
                        }
                        break;
                    }
                }
            }
            MapLayersInfoTree.Nodes[0].Expand();
            IsExpCol = false;
        }


        /// <summary>
        /// 清除当前加载的海图数据
        /// </summary>
        private void 清空ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            //清除所有海图
            map1.ClearAllMap();
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            //更新当前菜单栏中的图层信息
            updateMapLayerInfo();
        }

        /// <summary>
        /// 设置当前海图显示模式
        /// </summary>
        private void SetState()
        {
            //设置当前语言显示模式
            ChineseShow.Checked = false;
            EnglishShow.Checked = false;
            if (map1.IsChineseShow)
            {
                ChineseShow.Checked = true;
            }
            else
            {
                EnglishShow.Checked = true;
            }

            //设置当前海图图层显示模式
            menu_基本显示.Checked = false;
            menu_全部显示.Checked = false;
            menu_标准显示.Checked = false;
            switch (map1.LayerShowMode.ToString())
            {
                case "基本显示":
                    menu_基本显示.Checked = true;
                    break;
                case "标准显示":
                    menu_标准显示.Checked = true;
                    break;
                case "全部显示":
                    menu_全部显示.Checked = true;
                    break;
            }

            //设置当前海图显示区域符号类型
            menu_符号化区域边界.Checked = false;
            menu_简单区域边界.Checked = false;
            switch (map1.AreaBorderType.ToString())
            {
                case "符号化区域边界":
                    menu_符号化区域边界.Checked = true;
                    break;
                case "简单区域边界":
                    menu_简单区域边界.Checked = true;
                    break;
            }

            //设置当前海图显示点位符号类型
            menu_传统纸质符号.Checked = false;
            menu_简单符号.Checked = false;
            switch (map1.PointModeType.ToString())
            {
                case "简单符号":
                    menu_简单符号.Checked = true;
                    break;
                case "传统纸质符号":
                    menu_传统纸质符号.Checked = true;
                    break;
            }

            //设置当前海图显示颜色
            menu_daybright.Checked = false;
            menu_daywhite.Checked = false;
            menu_dayblack.Checked = false;
            menu_dusk.Checked = false;
            menu_night.Checked = false;
            switch (map1.ColorMode.ToString())
            {
                case "晴朗白天":
                    menu_daybright.Checked = true;
                    break;
                case "白天":
                    menu_daywhite.Checked = true;
                    break;
                case "阴天":
                    menu_dayblack.Checked = true;
                    break;
                case "黄昏":
                    menu_dusk.Checked = true;
                    break;
                case "黑夜":
                    menu_night.Checked = true;
                    break;
            }

            //设置当前海图等深线
            menu_5米.Checked = false;
            menu_10米.Checked = false;
            menu_20米.Checked = false;
            menu_30米.Checked = false;
            switch (map1.IsobathModel.ToString())
            {
                case "五米等深线":
                    menu_5米.Checked = true;
                    break;
                case "十米等深线":
                    menu_10米.Checked = true;
                    break;
                case "二十米等深线":
                    menu_20米.Checked = true;
                    break;
                case "三十米等深线":
                    menu_30米.Checked = true;
                    break;
            }


            //设置当前海图是否绘制经纬网
            if (map1.IsShowLonLatLines)
            {
                menu_显示经纬网.Checked = true;
            }
            else
            {
                menu_显示经纬网.Checked = false;
            }

            //设置当前海图是否绘制指北针
            if (map1.IsShowNorth)
            {
                menu_显示指北针.Checked = true;
            }
            else
            {
                menu_显示指北针.Checked = false;
            }

            //设置当前海图是否绘制比例尺
            if (map1.IsShowScale)
            {
                menu_显示比例尺.Checked = true;
            }
            else
            {
                menu_显示比例尺.Checked = false;
            }


            //设置当前海图是否显示水深点
            if (map1.IsShowDepth)
            {
                IsShowDepth.Checked = true;
            }
            else
            {
                IsShowDepth.Checked = false;
            }

            //设置当前海图是否显示元物标
            if (map1.ShowMetaData)
            {
                IsShowMeta.Checked = true;
            }
            else
            {
                IsShowMeta.Checked = false;
            }
        }

        /// <summary>
        /// 打开设置背景色弹窗
        /// </summary>
        private void 设置背景色ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = map1.BackGroundColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                map1.BackGroundColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// 设置显示元物标
        /// </summary>
        private void 显示元物标ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (!map1.ShowMetaData)
            {
                map1.ShowMetaData = true;
                IsShowMeta.Checked = true;
                if (map1.LayerShowMode.ToString() != "全部显示")
                {
                    map1.LayerShowMode = TjuES57MapControl.E_LayerShowMode.全部显示;
                    MessageBox.Show("已自动切换至图层全部显示模式！");
                }
            }
            else
            {
                map1.ShowMetaData = false;
                IsShowMeta.Checked = false;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 设置海图为晴朗白天显示模式
        /// </summary>
        private void DAY_BRIGHT_Click(object sender, EventArgs e)
        {
            if (map1.ColorMode.ToString() != "晴朗白天")
            {
                map1.ColorMode = TjuES57MapControl.E_ColorMode.晴朗白天;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 设置海图为白天显示模式
        /// </summary>
        private void DAY_WHITEBACK_Click(object sender, EventArgs e)
        {
            if (map1.ColorMode.ToString() != "白天")
            {
                map1.ColorMode = TjuES57MapControl.E_ColorMode.白天;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 设置海图为阴天显示模式
        /// </summary>
        private void DAY_BLACKBACK_Click(object sender, EventArgs e)
        {
            if (map1.ColorMode.ToString() != "阴天")
            {
                map1.ColorMode = TjuES57MapControl.E_ColorMode.阴天;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 设置海图为黄昏显示模式
        /// </summary>
        private void DUSK_Click(object sender, EventArgs e)
        {
            if (map1.ColorMode.ToString() != "黄昏")
            {
                map1.ColorMode = TjuES57MapControl.E_ColorMode.黄昏;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 设置海图为黑夜显示模式
        /// </summary>
        private void NIGHT_Click(object sender, EventArgs e)
        {
            if (map1.ColorMode.ToString() != "黑夜")
            {
                map1.ColorMode = TjuES57MapControl.E_ColorMode.黑夜;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 5米等深线点击事件
        /// </summary>
        private void 等深线5米ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.IsobathModel.ToString() != "五米等深线")
            {
                map1.IsobathModel = TjuES57MapControl.E_IsobathModel.五米等深线;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 10米等深线点击事件
        /// </summary>
        private void 等深线10米ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.IsobathModel.ToString() != "十米等深线")
            {
                map1.IsobathModel = TjuES57MapControl.E_IsobathModel.十米等深线;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 20米等深线点击事件
        /// </summary>
        private void 等深线20米ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.IsobathModel.ToString() != "二十米等深线")
            {
                map1.IsobathModel = TjuES57MapControl.E_IsobathModel.二十米等深线;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 30米等深线点击事件
        /// </summary>
        private void 等深线30米ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.IsobathModel.ToString() != "三十米等深线")
            {
                map1.IsobathModel = TjuES57MapControl.E_IsobathModel.三十米等深线;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }
        

        /// <summary>
        /// 系统帮助点击事件
        /// </summary>
        private void 系统帮助ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (!fr_Help.IsOpenThisFrm)
            {
                fr_Help frhelp = new fr_Help();
                frhelp.OpenHelpWindow(this);
                fr_Help.IsOpenThisFrm = true;
            }
            else
            {
                frhelp.Activate();
            }
        }

        /// <summary>
        /// 中文显示点击事件
        /// </summary>
        private void chineseTextShow_Click(object sender, EventArgs e)
        {
            //设置海图标绘语言为中文
            if (!ChineseShow.Checked || !map1.IsChineseShow)
            {
                ChineseShow.Checked = true;
                EnglishShow.Checked = false;
                map1.IsChineseShow = true;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            SetState();
        }

        /// <summary>
        /// 英文显示点击事件
        /// </summary>
        private void englishTextShow_Click(object sender, EventArgs e)
        {
            //设置海图标绘语言为英文
            if (!EnglishShow.Checked || map1.IsChineseShow)
            {
                ChineseShow.Checked = false;
                EnglishShow.Checked = true;
                map1.IsChineseShow = false;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            SetState();
        }

        /// <summary>
        /// 基本显示点击事件
        /// </summary>
        private void 基本显示ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.LayerShowMode.ToString() != "基本显示")
            {
                map1.LayerShowMode = TjuES57MapControl.E_LayerShowMode.基本显示;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 标准显示点击事件
        /// </summary>
        private void 标准显示ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.LayerShowMode.ToString() != "标准显示")
            {
                map1.LayerShowMode = TjuES57MapControl.E_LayerShowMode.标准显示;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 全部显示点击事件
        /// </summary>
        private void 全部显示ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (map1.LayerShowMode.ToString() != "全部显示")
            {
                map1.LayerShowMode = TjuES57MapControl.E_LayerShowMode.全部显示;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }


        /// <summary>
        /// 简单符号显示
        /// </summary>
        private void menu_简单符号_Click(object sender, EventArgs e)
        {
            if (map1.PointModeType.ToString() != "简单符号")
            {
                map1.PointModeType = TjuES57MapControl.E_PointModeType.简单符号;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 传统纸质符号显示
        /// </summary>
        private void menu_传统纸质符号_Click(object sender, EventArgs e)
        {
            if (map1.PointModeType.ToString() != "传统纸质符号")
            {
                map1.PointModeType = TjuES57MapControl.E_PointModeType.传统纸质符号;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 符号化区域边界显示
        /// </summary>
        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (map1.AreaBorderType.ToString() != "符号化区域边界")
            {
                map1.AreaBorderType = TjuES57MapControl.E_AreaBorderType.符号化区域边界;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 简单区域边界显示
        /// </summary>
        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (map1.AreaBorderType.ToString() != "简单区域边界")
            {
                map1.AreaBorderType = TjuES57MapControl.E_AreaBorderType.简单区域边界;
                //刷新海图绘制状态
                map1.IsFlushMap = true;
            }
            //设置当前海图显示模式
            SetState();
        }

        /// <summary>
        /// 海图出图
        /// </summary>
        private void saveScreenmap_Click(object sender, EventArgs e)
        {
            //获取当前海图截图
            Image curPic = map1.GetCurImage();
            if (curPic == null)
            {
                MessageBox.Show("当前没有可用的海图！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Png 图片|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                curPic.Save(saveFileDialog.FileName + ".png", ImageFormat.Png);
                MessageBox.Show("海图已成功导出！");
            }
        }

        /// <summary>
        /// 海图图层管理
        /// </summary>
        private void MapListManager_Click_1(object sender, EventArgs e)
        {
            if (!fr_TuCengManager.IsOpenThisFrm)
            {
                LayerManager = new fr_TuCengManager();
                LayerManager.OpenTuCengManager(this);
                fr_TuCengManager.IsOpenThisFrm = true;
            }
            else
            {
                LayerManager.Activate();
            }
        }

        /// <summary>
        /// 图幅复位
        /// </summary>
        private void 图幅复位ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            //重新海图显示参数
            map1.ES57Para.ResetMapParas();
            //刷新海图绘制状态
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 显示绘制点位弹窗
        /// </summary>
        private void 绘制点位ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_DrawPointInfo.IsOpenThisFrm)
            {
                fr_DrawPointInfo = new fr_DrawPointInfo();
                fr_DrawPointInfo.OpenPointWindow(this);
                fr_DrawPointInfo.IsOpenThisFrm = true;
            }
            else
            {
                fr_DrawPointInfo.Activate();
            }
        }

        /// <summary>
        /// 显示标注文本弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 标注文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!frm_Text.IsOpenThisFrm)
            {
                fr_Text = new frm_Text();
                fr_Text.OpenTextWindow(this);
                frm_Text.IsOpenThisFrm = true;
            }
            else
            {
                fr_Text.Activate();
            }
        }

        /// <summary>
        /// 显示绘制折线弹窗
        /// </summary>
        private void 绘制折线ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_DrawLineInfo.IsOpenThisFrm)
            {
                frmDrawLineInfo = new fr_DrawLineInfo();
                frmDrawLineInfo.OpenLineWindow(this);
                fr_DrawLineInfo.IsOpenThisFrm = true;
            }
            else
            {
                frmDrawLineInfo.Activate();
            }
        }

        private void 导出标绘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plt 用户标绘|*.plt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                map1.DrawPlotting.ExportPlotting(saveFileDialog.FileName);
            }
        }

        private void 导入标绘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "用户标绘(*.plt)|*.plt";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Length > 0)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        map1.DrawPlotting.ImportPlotting(openFileDialog.FileNames[i]);
                    }
                }
            }
            if (fr_DrawPointInfo.IsOpenThisFrm)
            {
                fr_DrawPointInfo.InitPointData();
            }
            if (fr_DrawLineInfo.IsOpenThisFrm)
            {
                frmDrawLineInfo.InitLinesData();
            }
            if (fr_DrawPolygonInfo.IsOpenThisFrm)
            {
                frmDrawPolygonInfo.InitPolygonData();
            }
            if (fr_DrawImageInfo.IsOpenThisFrm)
            {
                fr_DrawImageInfo.InitImageData();
            }
            if (fr_Ranging.IsOpenThisFrm)
            {
                frmRanging.InitRangingData();
            }
            if (fr_Area.IsOpenThisFrm)
            {
                frmArea.InitAreaData();
            }
            if (frm_Text.IsOpenThisFrm)
            {
                fr_Text.InitTextData();
            }
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 经纬网显示设置
        /// </summary>
        private void 显示经纬网ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (menu_显示经纬网.Checked)
            {
                menu_显示经纬网.Checked = false;
                //设置为隐藏经纬网
                map1.IsShowLonLatLines = false;
            }
            else
            {
                menu_显示经纬网.Checked = true;
                //设置为显示经纬网
                map1.IsShowLonLatLines = true;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 指北针显示设置
        /// </summary>
        private void 显示指北针ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (menu_显示指北针.Checked)
            {
                menu_显示指北针.Checked = false;
                //设置为隐藏指北针
                map1.IsShowNorth = false;
            }
            else
            {
                menu_显示指北针.Checked = true;
                //设置为显示指北针
                map1.IsShowNorth = true;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 比例尺显示设置
        /// </summary>
        private void 显示比例尺ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (menu_显示比例尺.Checked)
            {
                menu_显示比例尺.Checked = false;
                //设置为隐藏比例尺
                map1.IsShowScale = false;
            }
            else
            {
                menu_显示比例尺.Checked = true;
                //设置为显示比例尺
                map1.IsShowScale = true;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 显示绘制多边形弹窗
        /// </summary>
        private void 绘制多边形ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_DrawPolygonInfo.IsOpenThisFrm)
            {
                frmDrawPolygonInfo = new fr_DrawPolygonInfo();
                frmDrawPolygonInfo.OpenPointWindow(this);
                fr_DrawPolygonInfo.IsOpenThisFrm = true;
            }
            else
            {
                frmDrawPolygonInfo.Activate();
            }
        }

        /// <summary>
        /// 显示绘制测距弹窗
        /// </summary>
        private void 测距ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_Ranging.IsOpenThisFrm)
            {
                frmRanging = new fr_Ranging();
                frmRanging.OpenRangingWindow(this);
                fr_Ranging.IsOpenThisFrm = true;
            }
            else
            {
                frmRanging.Activate();
            }
        }

        /// <summary>
        /// 显示绘制测面积弹窗
        /// </summary>
        private void 测面积ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_Area.IsOpenThisFrm)
            {
                frmArea = new fr_Area();
                frmArea.OpenAreaWindow(this);
                fr_Area.IsOpenThisFrm = true;
            }
            else
            {
                frmArea.Activate();
            }
        }

        /// <summary>
        /// 显示绘制图片弹窗
        /// </summary>
        private void 绘制图片ToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (CurOperaterType != "") return;
            if (!fr_DrawImageInfo.IsOpenThisFrm)
            {
                fr_DrawImageInfo = new fr_DrawImageInfo();
                fr_DrawImageInfo.OpenImageWindow(this);
                fr_DrawImageInfo.IsOpenThisFrm = true;
            }
            else
            {
                fr_DrawImageInfo.Activate();
            }
        }

        /// <summary>
        /// 点击初始化图层显示状态后显示对应文件的所有图层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 初始化图层显示状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.Equals(初始化图层显示状态ToolStripMenuItem))
            {
                for (int i = 0; i < rightClickNode.Nodes.Count; i++)
                {
                    rightClickNode.Nodes[i].Checked = true;
                    rightClickNode.Nodes[i].ImageIndex = 3;
                    rightClickNode.Nodes[i].SelectedImageIndex = 3;
                }
                map1.ES57Para.SetOneMapAllLayersShow(rightClickNode.Text, true);
                //刷新海图绘制状态
                map1.IsFlushMap = true;
                return;
            }
        }

        private void 空间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurOperaterType = "点选查询";
        }

        /// <summary>
        /// 右键点击海图管理中某个菜单节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapManagerTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Level == 1 && !fr_TuCengManager.IsOpenThisFrm)//lzjtest_tcm
                {
                    rightClickNode = e.Node;
                    初始化图层显示状态ToolStripMenuItem.Visible = true;
                    空间查询ToolStripMenuItem.Visible = false;
                    contextMenuStrip1.Show(this.PointToScreen(new Point(e.X + e.Node.TreeView.Bounds.X, e.Y + e.Node.TreeView.Bounds.Y)));
                }
            }
            else
            {
                //判断当前点击节点层级
                if (e.Node.Level == 0)
                {
                    e.Node.ImageIndex = 0;
                    e.Node.SelectedImageIndex = 0;
                }
                else if (e.Node.Level == 1)
                {
                    if (!IsExpCol)
                    {
                        e.Node.Checked = true;
                        e.Node.ImageIndex = 1;
                        e.Node.SelectedImageIndex = 1;

                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            if (e.Node.Nodes[i].Checked)
                            {
                                e.Node.Nodes[i].ImageIndex = 3;
                                e.Node.Nodes[i].SelectedImageIndex = 3;
                            }
                            else
                            {
                                e.Node.Nodes[i].ImageIndex = 2;
                                e.Node.Nodes[i].SelectedImageIndex = 2;
                            }
                        }
                        curShowMapFile = e.Node.Text;
                        //显示当前海图文件的海图
                        map1.ResetToMapFile(curShowMapFile);
                    }
                    else
                    {
                        e.Node.ImageIndex = 1;
                        e.Node.SelectedImageIndex = 1;
                    }
                }
                else if (e.Node.Level == 2)
                {
                    if (!fr_TuCengManager.IsOpenThisFrm)
                    {
                        if (e.Node.Checked)
                        {
                            e.Node.Checked = false;
                            e.Node.ImageIndex = 2;
                            e.Node.SelectedImageIndex = 2;
                        }
                        else
                        {
                            e.Node.Checked = true;
                            e.Node.ImageIndex = 3;
                            e.Node.SelectedImageIndex = 3;
                        }

                        if (e.Node.Checked)
                        {
                            e.Node.ImageIndex = 3;
                            //显示当前指定名称绘制图层要素
                            map1.ES57Para.SetOneMapOneLayerShow(e.Node.Parent.Text, e.Node.Name, true);
                        }
                        else
                        {
                            e.Node.ImageIndex = 2;
                            //显示当前指定名称绘制图层要素
                            map1.ES57Para.SetOneMapOneLayerShow(e.Node.Parent.Text, e.Node.Name, false);
                        }
                    }
                    else
                    {
                        if (e.Node.Checked)
                        {
                            e.Node.ImageIndex = 3;
                            e.Node.SelectedImageIndex = 3;
                        }
                        else
                        {
                            e.Node.ImageIndex = 2;
                            e.Node.SelectedImageIndex = 2;
                        }
                    }
                }
            }
            IsExpCol = false;
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            return;
        }

        /// <summary>
        /// 勾选图层时控制海图中是否显示该要素
        /// </summary>
        private void MapManagerTree_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Action != TreeViewAction.Unknown)
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        private void map1_AfterMouseMove(MouseEventArgs e)
        {
            double Longitude = 0;
            double Latitude = 0;
            //根据图上坐标获取经纬度数据
            if (map1.GetLatLongByScreenPos(e.Location, out Latitude, out Longitude))
            {
                StripStatusLabel1_screenPoint.Text = "经度:" + Longitude.ToString("f5").PadLeft(10) + ",纬度:" + Latitude.ToString("f5").PadLeft(9) +
                    " || " + "屏幕坐标:x=" + e.X.ToString().PadLeft(4) + "; y=" + e.Y.ToString().PadLeft(4) + ";";
            }
        }


        /// <summary>
        /// 鼠标点击后事件
        /// </summary>
        /// <param name="e"></param>
        private void map1_AfterMouseClick(MouseEventArgs e)
        {
            //鼠标右键点击
            if (e.Button == MouseButtons.Right)
            {
                //判断当前海图操作类型
                switch (_curOperaterType)
                {
                    case "点选标注文本":
                        //将添加的点位数据添加至表格中
                        if (fr_Text != null)
                        {
                            fr_Text.AddNoTextDataToDgv();
                        }
                        break;
                    case "点选绘制点位":
                        //将添加的点位数据添加至表格中
                        if (fr_DrawPointInfo != null)
                        {
                            fr_DrawPointInfo.AddNoPointDataToDgv();
                        }
                        break;
                    case "点选绘制折线":
                        ////将折线数据添加至表格中
                        if (frmDrawLineInfo != null)
                        {
                            frmDrawLineInfo.AddLineDataToDgv();
                        }
                        break;
                    case "点选绘制多边形":
                        //将多边形数据添加至表格中
                        if (frmDrawPolygonInfo != null)
                        {
                            frmDrawPolygonInfo.AddPolygonDataToDgv();
                        }
                        break;
                    case "点选测距":
                        //将测距数据添加至表格中
                        if (frmRanging != null)
                        {
                            frmRanging.AddRanginDataToDgv();
                        }
                        break;
                    case "点选测面积":
                        //将测面积数据添加至表格中
                        if (frmArea != null)
                        {
                            frmArea.AddAreaDataToDgv();
                        }
                        break;
                    case "":
                        初始化图层显示状态ToolStripMenuItem.Visible = false;
                        空间查询ToolStripMenuItem.Visible = true;
                        contextMenuStrip1.Show(this.PointToScreen(new Point(e.X, e.Y + map1.Top)));
                        break;
                }
                CurOperaterType = "";
            }
            map1.IsFlushMap = true;
        }

        /// <summary>
        /// 鼠标双击后事件
        /// </summary>
        /// <param name="e"></param>
        private void map1_AfterDoubleMouseClick(MouseEventArgs e)
        {
            //鼠标左键双击
            if (e.Button == MouseButtons.Left)
            {
                switch (_curOperaterType)
                {
                    case "点选绘制点位":
                        //将添加的点位数据添加至表格中
                        if (fr_DrawPointInfo != null)
                        {
                            fr_DrawPointInfo.AddPointDataToDgv();
                        }
                        CurOperaterType = "";
                        break;
                    case "点选标注文本":
                        //将添加的文本标注添加至表格中
                        if (fr_Text != null)
                        {
                            fr_Text.AddTextDataToDgv();
                        }
                        CurOperaterType = "";
                        break;
                }
            }
        }

        /// <summary>
        /// 绘制后事件
        /// </summary>
        /// <param name="g"></param>
        private void map1_AfterMapDraw(Graphics g)
        {
            //显示当前海图绘制比例尺信息
            StatusLabel_curscale.Text = "当前比例尺：1:" + (int)map1.CurScale;
        }

        /// <summary>
        /// 动态加载ENC后事件
        /// </summary>
        private void map1_AfterENCLoad()
        {
            updateMapLayerInfo();
        }

        private void map1_AfterIdentify(ES57V2d scrPoint) //lzjchaxun //lzjfabu2
        {
            if (scrPoint != null)
            {
                if (!frm_chaxun.IsOpenThisFrm)
                {
                    fr_Identify = new frm_chaxun();
                    frm_chaxun.IsOpenThisFrm = true;
                    fr_Identify.SetHighlight(this);
                }
                fr_Identify.StartPosition = FormStartPosition.Manual;
                fr_Identify.Location = new Point((int)scrPoint.X, (int)scrPoint.Y + map1.Top);
                fr_Identify.OpenIdentifyWindow();
            }
            CurOperaterType = "";
        }

        /// <summary>
        /// 设置是否显示水深点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsShowDepth_Click(object sender, EventArgs e)
        {
            //设置显示水深点状态
            if (!map1.IsShowDepth)
            {
                map1.IsShowDepth = true;
                IsShowDepth.Checked = true;
                if (map1.LayerShowMode.ToString() != "全部显示")
                {
                    map1.LayerShowMode = TjuES57MapControl.E_LayerShowMode.全部显示;
                    MessageBox.Show("已自动切换至图层全部显示模式！");
                }
            }
            else
            {
                map1.IsShowDepth = false;
                IsShowDepth.Checked = false;
            }
            //刷新海图绘制状态
            map1.IsFlushMap = true;
            //设置当前海图显示模式
            SetState();
        }
        
        int nodeClicks = 0;
        TreeViewHitTestInfo hitInfo = null;

        private void MapLayersInfoTree_MouseDown(object sender, MouseEventArgs e)
        {
            hitInfo = MapLayersInfoTree.HitTest(e.Location);
            nodeClicks = e.Clicks;
        }

        private void MapLayersInfoTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (nodeClicks > 1 && hitInfo.Location == TreeViewHitTestLocations.Label)
            {
                e.Cancel = true;
            }
            else
            {
                IsExpCol = true;
            }
        }

        private void MapLayersInfoTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (nodeClicks > 1 && hitInfo.Location == TreeViewHitTestLocations.Label)
            {
                e.Cancel = true;
            }
            else
            {
                IsExpCol = true;
            }
        }

        private void 公里海里切换ToolStripMenuItem_Click(object sender, EventArgs e)//lzjshujia
        {
            map1.DrawPlotting.IsScaleSI = !map1.DrawPlotting.IsScaleSI;
            //wzcscalestart
            if (!map1.DrawPlotting.IsScaleSI)
            {
                this.公里海里切换ToolStripMenuItem.Text = "比例尺切换为公里";
            }
            else
            {
                this.公里海里切换ToolStripMenuItem.Text = "比例尺切换为海里";
            }
            //wzcscaleend

            map1.IsFlushMap = true;
        }

        private void 显示海图边框ToolStripMenuItem_Click(object sender, EventArgs e)//lzjshujia
        {
            map1.IsShowMapBound = !map1.IsShowMapBound;
            map1.IsFlushMap = true;
            if (map1.IsShowMapBound)//lzjfabu2
            {
                显示海图边框ToolStripMenuItem.Text = "未绘制海图时隐藏边框";
            }
            else
            {
                显示海图边框ToolStripMenuItem.Text = "未绘制海图时显示边框";
            }
        }

        private void 显示海图名称ToolStripMenuItem_Click(object sender, EventArgs e)//lzjshujia
        {
            map1.IsShowMapName = !map1.IsShowMapName;
            map1.IsFlushMap = true;
            if (map1.IsShowMapName)//lzjfabu2
            {
                显示海图名称ToolStripMenuItem.Text = "未绘制海图时隐藏名称";
            }
            else
            {
                显示海图名称ToolStripMenuItem.Text = "未绘制海图时显示名称";
            }
        }

        private void 设置边框颜色ToolStripMenuItem_Click(object sender, EventArgs e)//lzjshujia
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = map1.MapNameBoundColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                map1.MapNameBoundColor = colorDialog.Color;
            }
            map1.IsFlushMap = true;
        }

        private void 海图透明度ToolStripMenuItem_Click(object sender, EventArgs e)//wzcalpha
        {
            if (!frm_MapAlpha.IsOpenThisFrm)
            {
                fr_MapAlpha = new frm_MapAlpha();
                fr_MapAlpha.OpenAlphaWindow(this);
                frm_MapAlpha.IsOpenThisFrm = true;

            }
            else
            {
                fr_MapAlpha.Activate();
            }
        }
    }
}
