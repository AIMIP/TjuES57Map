using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TjuES57Map.Draw;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_DrawPolygonInfo : Form
    {
        public fr_DrawPolygonInfo()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
        public int NowSelectPolygonPointRowIndex = -1;
        public static bool IsOpenThisFrm = false;

        /// <summary>
        /// 绘制图形类实例化
        /// </summary>
        public DrawData DrawPen;

        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void OpenPointWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitPolygonData();
            this.Show();
        }

        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void InitPolygonData()
        {
            try
            {
                int i = 0;
                dgv_DrawPolygonInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawPolygons)
                {
                    String key = de.Key.ToString();
                    PolygonInfo value = (PolygonInfo)de.Value;

                    dgv_DrawPolygonInfo.Rows.Add(1);
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonXvHao"].Value = (i + 1).ToString();
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonID"].Value = value.PolygonID.ToString();
                    string ss = "";
                    for (int j = 0; j < value.PolygonPointsInfo.Count; j++)
                    {
                        ss += value.PolygonPointsInfo[j].X + "," + value.PolygonPointsInfo[j].Y + ";";
                    }
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonPointsInfo"].Value = ss;
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonBorderColor"].Value = ColorTranslator.ToHtml(value.PolygonBorderColor);
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonFillColor"].Value = ColorTranslator.ToHtml(value.PolygonFillColor);
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonBorderWidth"].Value = value.PolygonBorderWidth.ToString();
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextInfo"].Value = value.PolygonTextInfo.ToString();
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextColor"].Value = ColorTranslator.ToHtml(value.PolygonTextColor);
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextSize"].Value = value.PolygonTextFontSize.ToString();
                    if (value.IsShowPolygonNumber)
                    {
                        dgv_DrawPolygonInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "true";
                    }
                    else
                    {
                        dgv_DrawPolygonInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "false";
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return;
            }
        }

        public void BeforeAddPolygonbyClick()
        {
            txt_PolygonID.Enabled = false;
            txt_PolygonBorderColor.Enabled = false;
            txt_PolygonFillColor.Enabled = false;
            txt_PolygonBorderWidth.Enabled = false;
            txt_PolygonText.Enabled = false;
            txt_PolygonTextColor.Enabled = false;
            txt_PolygonTextSize.Enabled = false;
            chk_ShowPolygonNumber.Enabled = false;
            btn_AddPolygonOK.Enabled = false;
            btn_AddPolygonCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            dgv_PolygonPointsInfo.Enabled = false;

            dgv_DrawPolygonInfo.Enabled = false;
            btn_DianXuanPolygon.Enabled = false;
            btn_HandToAddPolygon.Enabled = false;
            btn_DeletePolygon.Enabled = false;
            btn_EidtPolygon.Enabled = false;
        }

        /// <summary>
        /// 添加多边形数据至DGV
        /// </summary>
        public void AddPolygonDataToDgv()
        {
            int i = 0;
            dgv_DrawPolygonInfo.Rows.Clear();
            string errorPolygonID = "";
            foreach (DictionaryEntry de in DrawPen.AllDrawPolygons)
            {
                String key = de.Key.ToString();
                PolygonInfo value = (PolygonInfo)de.Value;
                if (value.PolygonPointsInfo.Count < 3)
                {
                    this.SendToBack();
                    MessageBox.Show("请至少添加3个点位！");
                    errorPolygonID = value.PolygonID;
                    continue;
                }
                dgv_DrawPolygonInfo.Rows.Add(1);
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonXvHao"].Value = (i + 1).ToString();
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonID"].Value = value.PolygonID.ToString();
                string ss = "";
                for (int j = 0; j < value.PolygonPointsInfo.Count; j++)
                {
                    ss += value.PolygonPointsInfo[j].X + "," + value.PolygonPointsInfo[j].Y + ";";
                }
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonPointsInfo"].Value = ss;
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonBorderColor"].Value = ColorTranslator.ToHtml(value.PolygonBorderColor);
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonFillColor"].Value = ColorTranslator.ToHtml(value.PolygonFillColor);
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonBorderWidth"].Value = value.PolygonBorderWidth.ToString();
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextInfo"].Value = value.PolygonTextInfo.ToString();
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextColor"].Value = ColorTranslator.ToHtml(value.PolygonTextColor);
                dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonTextSize"].Value = value.PolygonTextFontSize.ToString();
                if (value.IsShowPolygonNumber)
                {
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawPolygonInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "false";
                }
                i++;
            }
            DrawPen.AllDrawPolygons.Remove(errorPolygonID);
            dgv_DrawPolygonInfo.Enabled = true;
            btn_DianXuanPolygon.Enabled = true;
            btn_HandToAddPolygon.Enabled = true;
            btn_DeletePolygon.Enabled = true;
            btn_EidtPolygon.Enabled = true;
            this.ControlBox = true;
            dgv_DrawPolygonInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.fr_DrawPointInfo.Enabled = true;
            main.frmDrawLineInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
            main.fr_Text.Enabled = true;
        }

        /// <summary>
        /// 关闭绘制多边形弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawPointInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 手动添加绘制多边形数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddPolygon_Click(object sender, EventArgs e)
        {
            txt_PolygonID.Text = "";
            txt_PolygonBorderColor.Text = "";
            txt_PolygonFillColor.Text = "";
            txt_PolygonBorderWidth.Text = "";
            txt_PolygonText.Text = "";
            txt_PolygonTextColor.Text = "";
            txt_PolygonTextSize.Text = "";
            chk_ShowPolygonNumber.Checked = true;
            txt_PolygonID.Enabled = true;
            txt_PolygonBorderColor.Enabled = true;
            txt_PolygonFillColor.Enabled = true;
            txt_PolygonBorderWidth.Enabled = true;
            txt_PolygonText.Enabled = true;
            txt_PolygonTextColor.Enabled = true;
            txt_PolygonTextSize.Enabled = true;
            chk_ShowPolygonNumber.Enabled = true;
            btn_AddPolygonOK.Enabled = true;
            btn_AddPolygonOK.Text = "添加";
            btn_AddPolygonCencel.Enabled = true;
            dgv_PolygonPointsInfo.Rows.Clear();
            btn_DeletePoint.Enabled = true;
            dgv_PolygonPointsInfo.Enabled = true;
            dgv_DrawPolygonInfo.Enabled = false;
            btn_DianXuanPolygon.Enabled = false;
            btn_HandToAddPolygon.Enabled = false;
            btn_DeletePolygon.Enabled = false;
            btn_EidtPolygon.Enabled = false;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击确定添加多边形数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPolygonOK_Click(object sender, EventArgs e)
        {
            if (btn_AddPolygonOK.Text == "添加")
            {
                for (int i = 0; i < dgv_DrawPolygonInfo.RowCount; i++)
                {
                    if (dgv_DrawPolygonInfo.Rows[i].Cells["COL_PolygonID"].Value as string == txt_PolygonID.Text)
                    {
                        MessageBox.Show("多边形ID不能重复！");
                        return;
                    }
                }
            }
            if (txt_PolygonID.Text == "" || txt_PolygonBorderColor.Text == "" || txt_PolygonFillColor.Text == "" || txt_PolygonBorderWidth.Text == "" || txt_PolygonText.Text == "" || txt_PolygonTextColor.Text == "" || txt_PolygonTextSize.Text == "")
            {
                MessageBox.Show("请将多边形信息填写完整！");
                return;
            }
            if (btn_AddPolygonOK.Text == "添加")
            {
                if (dgv_PolygonPointsInfo.RowCount < 4)
                {
                    MessageBox.Show("多边形点位数量需要大于3，请继续添加");
                    return;
                }

                List<PointF> pointFs = new List<PointF>();

                string info = "";
                for (int i = 0; i < dgv_PolygonPointsInfo.RowCount - 1; i++)
                {
                    if (dgv_PolygonPointsInfo.Rows[i].Cells["COL_LinePointLon"].Value == null || dgv_PolygonPointsInfo.Rows[i].Cells["COL_LinePointLat"].Value == null)
                    {
                        MessageBox.Show("请将点位信息填写完整！");
                        return;
                    }
                    info += dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLon"].Value.ToString() + "," + dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLat"].Value.ToString() + ";";

                    PointF point = new PointF(float.Parse(dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLon"].Value.ToString()), float.Parse(dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLat"].Value.ToString()));
                    pointFs.Add(point);
                }

                dgv_DrawPolygonInfo.Rows.Add(1);
                int RowsID = dgv_DrawPolygonInfo.Rows.Count - 1;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonXvHao"].Value = RowsID + 1;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonID"].Value = txt_PolygonID.Text;

                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonBorderColor"].Value = txt_PolygonBorderColor.Text;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonFillColor"].Value = txt_PolygonFillColor.Text;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonBorderWidth"].Value = txt_PolygonBorderWidth.Text;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonTextInfo"].Value = txt_PolygonText.Text;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonTextColor"].Value = txt_PolygonTextColor.Text;
                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonTextSize"].Value = txt_PolygonTextSize.Text;

                if (chk_ShowPolygonNumber.Checked)
                {
                    dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_IsShowNumber"].Value = "false";
                }

                dgv_DrawPolygonInfo.Rows[RowsID].Cells["COL_PolygonPointsInfo"].Value = info;
                //将添加后的数据进行保存更新
                main.map1.DrawPlotting.AddPolygonObject(txt_PolygonID.Text, pointFs, ColorTranslator.FromHtml(txt_PolygonBorderColor.Text), ColorTranslator.FromHtml(txt_PolygonFillColor.Text), int.Parse(txt_PolygonBorderWidth.Text), txt_PolygonText.Text, ColorTranslator.FromHtml(txt_PolygonTextColor.Text), int.Parse(txt_PolygonTextSize.Text), chk_ShowPolygonNumber.Checked);
            }
            else if (btn_AddPolygonOK.Text == "修改")
            {
                if (dgv_PolygonPointsInfo.RowCount < 4)
                {
                    MessageBox.Show("多边形点位数量需要大于3，请继续添加");
                    return;
                }

                List<PointF> pointFs = new List<PointF>();

                string info = "";
                for (int i = 0; i < dgv_PolygonPointsInfo.RowCount - 1; i++)
                {
                    if (dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLon"].Value == null || dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLat"].Value == null)
                    {
                        MessageBox.Show("请将点位信息填写完整！");
                        return;
                    }
                    info += dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLon"].Value.ToString() + "," + dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLat"].Value.ToString() + ";";

                    PointF point = new PointF(float.Parse(dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLon"].Value.ToString()), float.Parse(dgv_PolygonPointsInfo.Rows[i].Cells["COL_PolygonPointLat"].Value.ToString()));
                    pointFs.Add(point);
                }

                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonID"].Value = txt_PolygonID.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonBorderColor"].Value = txt_PolygonBorderColor.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonFillColor"].Value = txt_PolygonFillColor.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonBorderWidth"].Value = txt_PolygonBorderWidth.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonTextInfo"].Value = txt_PolygonText.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonTextColor"].Value = txt_PolygonTextColor.Text;
                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonTextSize"].Value = txt_PolygonTextSize.Text;

                if (chk_ShowPolygonNumber.Checked)
                {
                    dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_IsShowNumber"].Value = "false";
                }

                dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonPointsInfo"].Value = info;
                //将修改后的数据进行保存更新
                main.map1.DrawPlotting.EidtPolygonObject(txt_PolygonID.Text, pointFs, ColorTranslator.FromHtml(txt_PolygonBorderColor.Text), ColorTranslator.FromHtml(txt_PolygonFillColor.Text), int.Parse(txt_PolygonBorderWidth.Text), txt_PolygonText.Text, ColorTranslator.FromHtml(txt_PolygonTextColor.Text), int.Parse(txt_PolygonTextSize.Text), chk_ShowPolygonNumber.Checked);
            }
            //刷新海图绘制状态
            main.map1.IsFlushMap = true;

            txt_PolygonID.Enabled = false;
            txt_PolygonBorderColor.Enabled = false;
            txt_PolygonFillColor.Enabled = false;
            txt_PolygonBorderWidth.Enabled = false;
            txt_PolygonText.Enabled = false;
            txt_PolygonTextColor.Enabled = false;
            txt_PolygonTextSize.Enabled = false;
            btn_AddPolygonOK.Enabled = false;
            btn_AddPolygonOK.Text = "确定";
            btn_AddPolygonCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            chk_ShowPolygonNumber.Enabled = false;
            dgv_PolygonPointsInfo.Enabled = false;
            dgv_DrawPolygonInfo.Enabled = true;
            btn_DianXuanPolygon.Enabled = true;
            btn_HandToAddPolygon.Enabled = true;
            btn_DeletePolygon.Enabled = true;
            btn_EidtPolygon.Enabled = true;
            dgv_DrawPolygonInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击删除按钮删除多边形信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletePolygon_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string PolygonID = dgv_DrawPolygonInfo.Rows[NowSelectRowIndex].Cells["COL_PolygonID"].Value.ToString();
                //将删除后的数据进行保存更新
                main.map1.DrawPlotting.DeletePolygonObject(PolygonID);
                dgv_DrawPolygonInfo.Rows.RemoveAt(NowSelectRowIndex);
                IsSelectRow = false;
                NowSelectRowIndex = -1;

                txt_PolygonID.Text = "";
                txt_PolygonBorderColor.Text = "";
                txt_PolygonFillColor.Text = "";
                txt_PolygonBorderWidth.Text = "";
                txt_PolygonText.Text = "";
                txt_PolygonTextColor.Text = "";
                txt_PolygonTextSize.Text = "";
                dgv_PolygonPointsInfo.Rows.Clear();
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;
                dgv_DrawPolygonInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 点击修改按钮修改多边形信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EidtPoint_Click(object sender, EventArgs e)
        {
            if (!IsSelectRow || NowSelectRowIndex < 0)
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }

            txt_PolygonID.Enabled = false;
            txt_PolygonBorderColor.Enabled = true;
            txt_PolygonFillColor.Enabled = true;
            txt_PolygonBorderWidth.Enabled = true;
            txt_PolygonText.Enabled = true;
            txt_PolygonTextColor.Enabled = true;
            txt_PolygonTextSize.Enabled = true;
            btn_AddPolygonOK.Enabled = true;
            btn_AddPolygonOK.Text = "修改";
            btn_AddPolygonCencel.Enabled = true;
            btn_DeletePoint.Enabled = true;
            chk_ShowPolygonNumber.Enabled = true;
            dgv_PolygonPointsInfo.Enabled = true;
            dgv_DrawPolygonInfo.Enabled = false;
            btn_DianXuanPolygon.Enabled = false;
            btn_HandToAddPolygon.Enabled = false;
            btn_DeletePolygon.Enabled = false;
            btn_EidtPolygon.Enabled = false;
            dgv_DrawPolygonInfo.ClearSelection();
            IsSelectRow = false;

        }

        /// <summary>
        /// 点击取消按钮取消添加或修改多边形信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPolygonCencel_Click(object sender, EventArgs e)
        {
            txt_PolygonID.Enabled = false;
            txt_PolygonBorderColor.Enabled = false;
            txt_PolygonFillColor.Enabled = false;
            txt_PolygonBorderWidth.Enabled = false;
            txt_PolygonText.Enabled = false;
            txt_PolygonTextColor.Enabled = false;
            txt_PolygonTextSize.Enabled = false;
            btn_AddPolygonOK.Enabled = false;
            btn_AddPolygonOK.Text = "确定";
            btn_AddPolygonCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            chk_ShowPolygonNumber.Enabled = false;
            dgv_PolygonPointsInfo.Enabled = false;
            dgv_DrawPolygonInfo.Enabled = true;
            btn_DianXuanPolygon.Enabled = true;
            btn_HandToAddPolygon.Enabled = true;
            btn_DeletePolygon.Enabled = true;
            btn_EidtPolygon.Enabled = true;
            dgv_DrawPolygonInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击点选添加多边形按钮进行点选添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DianXuanPolygon_Click(object sender, EventArgs e)
        {
            BeforeAddPolygonbyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选绘制多边形";
            main.frmDrawLineInfo.Enabled = false;
            main.fr_DrawPointInfo.Enabled = false;
            main.fr_DrawImageInfo.Enabled = false;
            main.frmRanging.Enabled = false;
            main.frmArea.Enabled = false;
            main.fr_Text.Enabled = false;
            main.Activate();
        }

        /// <summary>
        /// 点击颜色设置文本框弹出颜色设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PolygonColor_Click(object sender, EventArgs e)
        {
            //允许使用该对话框的自定义颜色  
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            //初始化当前文本框中的字体颜色，  
            colorDialog.Color = System.Drawing.Color.White;

            //当用户在ColorDialog对话框中点击"确定"按钮  
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_PolygonBorderColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }

        /// <summary>
        /// 点击删除点位按钮删除当前选中多边形的点位数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletePointInfo_Click(object sender, EventArgs e)
        {
            if (NowSelectPolygonPointRowIndex < 0)
            {
                return;
            }
            if (NowSelectPolygonPointRowIndex >= dgv_PolygonPointsInfo.Rows.Count - 1)
            {
                return;
            }
            dgv_PolygonPointsInfo.Rows.RemoveAt(NowSelectPolygonPointRowIndex);
            NowSelectPolygonPointRowIndex = -1;
        }

        /// <summary>
        /// 点击颜色设置文本框弹出颜色设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PolygonTextColor_Click(object sender, EventArgs e)
        {
            //允许使用该对话框的自定义颜色  
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            //初始化当前文本框中的字体颜色，  
            colorDialog.Color = System.Drawing.Color.White;

            //当用户在ColorDialog对话框中点击"确定"按钮  
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_PolygonTextColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }

        /// <summary>
        /// 点击颜色设置文本框弹出颜色设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PolygonFillColor_MouseClick(object sender, MouseEventArgs e)
        {
            //允许使用该对话框的自定义颜色  
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            //初始化当前文本框中的字体颜色，  
            colorDialog.Color = System.Drawing.Color.White;

            //当用户在ColorDialog对话框中点击"确定"按钮  
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_PolygonFillColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }

        /// <summary>
        /// 点击多边形数据DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawPolygonInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonID"].Value != null)
            {
                txt_PolygonID.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonID"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonBorderColor"].Value != null)
            {
                txt_PolygonBorderColor.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonBorderColor"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonFillColor"].Value != null)
            {
                txt_PolygonFillColor.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonFillColor"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonBorderWidth"].Value != null)
            {
                txt_PolygonBorderWidth.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonBorderWidth"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextInfo"].Value != null)
            {
                txt_PolygonText.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextInfo"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextColor"].Value != null)
            {
                txt_PolygonTextColor.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextColor"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextSize"].Value != null)
            {
                txt_PolygonTextSize.Text = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonTextSize"].Value.ToString();
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value != null)
            {
                if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value.ToString() == "true")
                {
                    chk_ShowPolygonNumber.Checked = true;
                }
                else if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value.ToString() == "false")
                {
                    chk_ShowPolygonNumber.Checked = false;
                }
            }

            if (dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonPointsInfo"].Value != null)
            {
                string[] arrinfo = dgv_DrawPolygonInfo.Rows[e.RowIndex].Cells["COL_PolygonPointsInfo"].Value.ToString().Split(';');
                dgv_PolygonPointsInfo.Rows.Clear();
                for (int j = 0; j < arrinfo.Length; j++)
                {
                    string[] point = arrinfo[j].Split(',');
                    if (point.Length > 1)
                    {
                        dgv_PolygonPointsInfo.Rows.Add(1);
                        dgv_PolygonPointsInfo.Rows[j].Cells["COL_PolygonPointXvHao"].Value = (j + 1).ToString();
                        dgv_PolygonPointsInfo.Rows[j].Cells["COL_PolygonPointLon"].Value = point[0];
                        dgv_PolygonPointsInfo.Rows[j].Cells["COL_PolygonPointLat"].Value = point[1];

                    }
                }
            }
        }

        /// <summary>
        /// 点击多边形点位数据DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_PolygonPointsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NowSelectPolygonPointRowIndex = e.RowIndex;
        }
    }
}
