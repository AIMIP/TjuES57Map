using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TjuES57Map.Draw;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_DrawLineInfo : Form
    {
        public fr_DrawLineInfo()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
        public int NowSelectLinePointRowIndex = -1;
        public static bool IsOpenThisFrm = false;

        /// <summary>
        /// 绘制图形类实例化
        /// </summary>
        public DrawData DrawPen;


        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void OpenLineWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitLinesData();
            this.Show();
        }


        /// <summary>
        /// 初始化绘制折线数据
        /// </summary>
        public void InitLinesData()
        {
            try
            {
                int i = 0;
                dgv_DrawLineInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawLines)
                {
                    String key = de.Key.ToString();
                    LineInfo value = (LineInfo)de.Value;

                    dgv_DrawLineInfo.Rows.Add(1);
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineXvHao"].Value = (i + 1).ToString();
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineID"].Value = value.LineID.ToString();
                    string ss = "";
                    for (int j = 0; j < value.LinePointsInfo.Count; j++)
                    {
                        ss += value.LinePointsInfo[j].X + "," + value.LinePointsInfo[j].Y + ";";
                    }
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LinePointsInfo"].Value = ss;
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineColor"].Value = ColorTranslator.ToHtml(value.LineColor);
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineWidth"].Value = value.LineWidth.ToString();
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextInfo"].Value = value.LineTextInfo.ToString();
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextColor"].Value = ColorTranslator.ToHtml(value.LineTextColor);
                    dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextSize"].Value = value.LineTextFontSize.ToString();
                    if (value.IsShowLineNumber)
                    {
                        dgv_DrawLineInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "true";
                    }
                    else
                    {
                        dgv_DrawLineInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "false";
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

        public void BeforeAddLinebyClick()
        {
            txt_LineID.Enabled = false;
            txt_LineColor.Enabled = false;
            txt_LineWidth.Enabled = false;
            txt_LineText.Enabled = false;
            txt_LineTextColor.Enabled = false;
            txt_LineTextSize.Enabled = false;
            chk_ShowLineNumber.Enabled = false;
            btn_AddLineOK.Enabled = false;
            btn_AddLineCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            dgv_LinePointsInfo.Enabled = false;

            dgv_DrawLineInfo.Enabled = false;
            btn_DianXuanLine.Enabled = false;
            btn_HandToAddLine.Enabled = false;
            btn_DeleteLine.Enabled = false;
            btn_EidtLine.Enabled = false;
        }

        /// <summary>
        /// 添加折线数据至DGV 点选添加
        /// </summary>
        public void AddLineDataToDgv()
        {
            int i = 0;
            string errorLineID = "";
            dgv_DrawLineInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawLines)
            {
                String key = de.Key.ToString();
                LineInfo value = (LineInfo)de.Value;
                if (value.LinePointsInfo.Count < 2)
                {
                    this.SendToBack();
                    MessageBox.Show("请至少添加2个点位！");
                    errorLineID = value.LineID;
                    continue;
                }
                dgv_DrawLineInfo.Rows.Add(1);
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineXvHao"].Value = (i + 1).ToString();
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineID"].Value = value.LineID.ToString();
                string ss = "";
                for (int j = 0; j < value.LinePointsInfo.Count; j++)
                {
                    ss += value.LinePointsInfo[j].X + "," + value.LinePointsInfo[j].Y + ";";
                }
                dgv_DrawLineInfo.Rows[i].Cells["COL_LinePointsInfo"].Value = ss;
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineColor"].Value = ColorTranslator.ToHtml(value.LineColor);
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineWidth"].Value = value.LineWidth.ToString();
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextInfo"].Value = value.LineTextInfo.ToString();
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextColor"].Value = ColorTranslator.ToHtml(value.LineTextColor);
                dgv_DrawLineInfo.Rows[i].Cells["COL_LineTextSize"].Value = value.LineTextFontSize.ToString();
                if (value.IsShowLineNumber)
                {
                    dgv_DrawLineInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawLineInfo.Rows[i].Cells["COL_IsShowNumber"].Value = "false";
                }
                i++;
            }
            DrawPen.AllDrawLines.Remove(errorLineID);
            dgv_DrawLineInfo.Enabled = true;
            btn_DianXuanLine.Enabled = true;
            btn_HandToAddLine.Enabled = true;
            btn_DeleteLine.Enabled = true;
            btn_EidtLine.Enabled = true;
            this.ControlBox = true;
            dgv_DrawLineInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.fr_DrawPointInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
            main.fr_Text.Enabled = true;
        }

        /// <summary>
        /// 关闭绘制折线弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawLineInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 点击手动添加 绘制折线数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddLine_Click(object sender, EventArgs e)
        {
            txt_LineID.Text = "";
            txt_LineColor.Text = "";
            txt_LineWidth.Text = "";
            txt_LineText.Text = "";
            txt_LineTextColor.Text = "";
            txt_LineTextSize.Text = "";
            chk_ShowLineNumber.Checked = true;
            txt_LineID.Enabled = true;
            txt_LineColor.Enabled = true;
            txt_LineWidth.Enabled = true;
            txt_LineText.Enabled = true;
            txt_LineTextColor.Enabled = true;
            txt_LineTextSize.Enabled = true;
            chk_ShowLineNumber.Enabled = true;
            btn_AddLineOK.Enabled = true;
            btn_AddLineOK.Text = "添加";
            btn_AddLineCencel.Enabled = true;
            dgv_LinePointsInfo.Rows.Clear();
            btn_DeletePoint.Enabled = true;
            dgv_LinePointsInfo.Enabled = true;
            dgv_DrawLineInfo.Enabled = false;
            btn_DianXuanLine.Enabled = false;
            btn_HandToAddLine.Enabled = false;
            btn_DeleteLine.Enabled = false;
            btn_EidtLine.Enabled = false;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击确定添加折线数据(手动添加)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddLineOK_Click(object sender, EventArgs e)
        {
            if (btn_AddLineOK.Text == "添加")
            {
                for (int i = 0; i < dgv_DrawLineInfo.RowCount; i++)
                {
                    if (dgv_DrawLineInfo.Rows[i].Cells["COL_LineID"].Value as string == txt_LineID.Text)
                    {
                        MessageBox.Show("折线ID不能重复！");
                        return;
                    }
                }
            }
            if (txt_LineID.Text == "" || txt_LineColor.Text == "" || txt_LineWidth.Text == "" || txt_LineText.Text == "" || txt_LineTextColor.Text == "" || txt_LineTextSize.Text == "")
            {
                MessageBox.Show("请将折线信息填写完整！");
                return;
            }
            if (btn_AddLineOK.Text == "添加")
            {
                if (dgv_LinePointsInfo.RowCount < 3)
                {
                    MessageBox.Show("请至少添加2个点位！");
                    return;
                }

                List<PointF> pointFs = new List<PointF>();

                string info = "";
                for (int i = 0; i < dgv_LinePointsInfo.RowCount - 1; i++)
                {
                    if (dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value == null || dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value == null)
                    {
                        MessageBox.Show("请将点位信息填写完整！");
                        return;
                    }
                    info += dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value.ToString() + "," + dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value.ToString() + ";";

                    PointF point = new PointF(float.Parse(dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value.ToString()), float.Parse(dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value.ToString()));
                    pointFs.Add(point);
                }

                dgv_DrawLineInfo.Rows.Add(1);
                int RowsID = dgv_DrawLineInfo.Rows.Count - 1;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineXvHao"].Value = RowsID + 1;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineID"].Value = txt_LineID.Text;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineColor"].Value = txt_LineColor.Text;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineWidth"].Value = txt_LineWidth.Text;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineTextInfo"].Value = txt_LineText.Text;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineTextColor"].Value = txt_LineTextColor.Text;
                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LineTextSize"].Value = txt_LineTextSize.Text;

                if (chk_ShowLineNumber.Checked)
                {
                    dgv_DrawLineInfo.Rows[RowsID].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawLineInfo.Rows[RowsID].Cells["COL_IsShowNumber"].Value = "false";
                }

                dgv_DrawLineInfo.Rows[RowsID].Cells["COL_LinePointsInfo"].Value = info;
                //将添加后的数据进行保存更新
                main.map1.DrawPlotting.AddLineObject(txt_LineID.Text, pointFs, ColorTranslator.FromHtml(txt_LineColor.Text), int.Parse(txt_LineWidth.Text), txt_LineText.Text, ColorTranslator.FromHtml(txt_LineTextColor.Text), int.Parse(txt_LineTextSize.Text), chk_ShowLineNumber.Checked);

            }
            else if (btn_AddLineOK.Text == "修改")
            {
                if (dgv_LinePointsInfo.RowCount < 3)
                {
                    MessageBox.Show("请至少添加2个点位！");
                    return;
                }

                List<PointF> pointFs = new List<PointF>();

                string info = "";
                for (int i = 0; i < dgv_LinePointsInfo.RowCount - 1; i++)
                {
                    if (dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value == null || dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value == null)
                    {
                        MessageBox.Show("请将点位信息填写完整！");
                        return;
                    }
                    info += dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value.ToString() + "," + dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value.ToString() + ";";

                    PointF point = new PointF(float.Parse(dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLon"].Value.ToString()), float.Parse(dgv_LinePointsInfo.Rows[i].Cells["COL_LinePointLat"].Value.ToString()));
                    pointFs.Add(point);
                }

                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineID"].Value = txt_LineID.Text;
                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineColor"].Value = txt_LineColor.Text;
                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineWidth"].Value = txt_LineWidth.Text;
                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineTextInfo"].Value = txt_LineText.Text;
                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineTextColor"].Value = txt_LineTextColor.Text;
                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineTextSize"].Value = txt_LineTextSize.Text;

                if (chk_ShowLineNumber.Checked)
                {
                    dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_IsShowNumber"].Value = "true";
                }
                else
                {
                    dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_IsShowNumber"].Value = "false";
                }

                dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LinePointsInfo"].Value = info;
                //将修改后的数据进行保存更新
                main.map1.DrawPlotting.EidtLineObject(txt_LineID.Text, pointFs, ColorTranslator.FromHtml(txt_LineColor.Text), int.Parse(txt_LineWidth.Text), txt_LineText.Text, ColorTranslator.FromHtml(txt_LineTextColor.Text), int.Parse(txt_LineTextSize.Text), chk_ShowLineNumber.Checked);
            }
            //刷新海图绘制状态
            main.map1.IsFlushMap = true;

            txt_LineID.Enabled = false;
            txt_LineColor.Enabled = false;
            txt_LineWidth.Enabled = false;
            txt_LineText.Enabled = false;
            txt_LineTextColor.Enabled = false;
            txt_LineTextSize.Enabled = false;
            btn_AddLineOK.Enabled = false;
            btn_AddLineOK.Text = "确定";
            btn_AddLineCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            chk_ShowLineNumber.Enabled = false;
            dgv_LinePointsInfo.Enabled = false;
            dgv_DrawLineInfo.Enabled = true;
            btn_DianXuanLine.Enabled = true;
            btn_HandToAddLine.Enabled = true;
            btn_DeleteLine.Enabled = true;
            btn_EidtLine.Enabled = true;
            dgv_DrawLineInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击删除按钮删除折线信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string LineID = dgv_DrawLineInfo.Rows[NowSelectRowIndex].Cells["COL_LineID"].Value.ToString();
                //将删除后的数据进行保存更新
                main.map1.DrawPlotting.DeleteLineObject(LineID);
                dgv_DrawLineInfo.Rows.RemoveAt(NowSelectRowIndex);
                IsSelectRow = false;
                NowSelectRowIndex = -1;

                txt_LineID.Text = "";
                txt_LineColor.Text = "";
                txt_LineWidth.Text = "";
                txt_LineText.Text = "";
                txt_LineTextColor.Text = "";
                txt_LineTextSize.Text = "";
                dgv_LinePointsInfo.Rows.Clear();
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;
                dgv_DrawLineInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 点击修改按钮修改折线信息
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
            txt_LineID.Enabled = false;
            txt_LineColor.Enabled = true;
            txt_LineWidth.Enabled = true;
            txt_LineText.Enabled = true;
            txt_LineTextColor.Enabled = true;
            txt_LineTextSize.Enabled = true;
            btn_AddLineOK.Enabled = true;
            btn_AddLineOK.Text = "修改";
            btn_AddLineCencel.Enabled = true;
            btn_DeletePoint.Enabled = true;
            chk_ShowLineNumber.Enabled = true;
            dgv_LinePointsInfo.Enabled = true;
            dgv_DrawLineInfo.Enabled = false;
            btn_DianXuanLine.Enabled = false;
            btn_HandToAddLine.Enabled = false;
            btn_DeleteLine.Enabled = false;
            btn_EidtLine.Enabled = false;
            dgv_DrawLineInfo.ClearSelection();
            IsSelectRow = false;
        }

        /// <summary>
        /// 点击取消按钮取消添加或修改折线信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddLineCencel_Click(object sender, EventArgs e)
        {
            txt_LineID.Enabled = false;
            txt_LineColor.Enabled = false;
            txt_LineWidth.Enabled = false;
            txt_LineText.Enabled = false;
            txt_LineTextColor.Enabled = false;
            txt_LineTextSize.Enabled = false;
            btn_AddLineOK.Enabled = false;
            btn_AddLineOK.Text = "确定";
            btn_AddLineCencel.Enabled = false;
            btn_DeletePoint.Enabled = false;
            chk_ShowLineNumber.Enabled = false;
            dgv_LinePointsInfo.Enabled = false;
            dgv_DrawLineInfo.Enabled = true;
            btn_DianXuanLine.Enabled = true;
            btn_HandToAddLine.Enabled = true;
            btn_DeleteLine.Enabled = true;
            btn_EidtLine.Enabled = true;
            dgv_DrawLineInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击点选添加折线按钮进行点选添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DianXuanLine_Click(object sender, EventArgs e)
        {
            BeforeAddLinebyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选绘制折线";
            main.fr_DrawPointInfo.Enabled = false;
            main.frmDrawPolygonInfo.Enabled = false;
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
        private void txt_LineColor_Click(object sender, EventArgs e)
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
                txt_LineColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }

        /// <summary>
        /// 点击删除点位按钮删除当前选中折线的点位数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletePointInfo_Click(object sender, EventArgs e)
        {
            if (NowSelectLinePointRowIndex < 0)
            {
                return;
            }
            if (NowSelectLinePointRowIndex >= dgv_LinePointsInfo.Rows.Count - 1)
            {
                return;
            }
            dgv_LinePointsInfo.Rows.RemoveAt(NowSelectLinePointRowIndex);
            NowSelectLinePointRowIndex = -1;
        }

        /// <summary>
        /// 点击颜色设置文本框弹出颜色设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_LineTextColor_Click(object sender, EventArgs e)
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
                txt_LineTextColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }

        /// <summary>
        /// 点击折线数据DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawLineInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineID"].Value != null)
            {
                txt_LineID.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineID"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineColor"].Value != null)
            {
                txt_LineColor.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineColor"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineWidth"].Value != null)
            {
                txt_LineWidth.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineWidth"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextInfo"].Value != null)
            {
                txt_LineText.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextInfo"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextColor"].Value != null)
            {
                txt_LineTextColor.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextColor"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextSize"].Value != null)
            {
                txt_LineTextSize.Text = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LineTextSize"].Value.ToString();
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value != null)
            {
                if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value.ToString() == "true")
                {
                    chk_ShowLineNumber.Checked = true;
                }
                else if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_IsShowNumber"].Value.ToString() == "false")
                {
                    chk_ShowLineNumber.Checked = false;
                }
            }

            if (dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LinePointsInfo"].Value != null)
            {
                string[] arrinfo = dgv_DrawLineInfo.Rows[e.RowIndex].Cells["COL_LinePointsInfo"].Value.ToString().Split(';');
                dgv_LinePointsInfo.Rows.Clear();
                for (int j = 0; j < arrinfo.Length; j++)
                {
                    string[] point = arrinfo[j].Split(',');
                    if (point.Length > 1)
                    {
                        dgv_LinePointsInfo.Rows.Add(1);
                        dgv_LinePointsInfo.Rows[j].Cells["COL_LinePointXvHao"].Value = (j + 1).ToString();
                        dgv_LinePointsInfo.Rows[j].Cells["COL_LinePointLon"].Value = point[0];
                        dgv_LinePointsInfo.Rows[j].Cells["COL_LinePointLat"].Value = point[1];

                    }

                }
            }
        }

        /// <summary>
        /// 点击折线点位DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_LinePointsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NowSelectLinePointRowIndex = e.RowIndex;
        }
    }
}
