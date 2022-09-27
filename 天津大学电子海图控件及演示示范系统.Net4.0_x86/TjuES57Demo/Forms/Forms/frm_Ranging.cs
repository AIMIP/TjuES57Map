using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TjuES57Map.Draw;
using TjuES57Map.Library;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_Ranging : Form
    {
        public fr_Ranging()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
        public int NowSelectLinePointRowIndex = -1;
        public static ES57MapTools mapTools = new ES57MapTools();
        public static bool IsOpenThisFrm = false;

        /// <summary>
        /// 绘制图形类实例化
        /// </summary>
        public DrawData DrawPen;

        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void OpenRangingWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitRangingData();
            this.Show();
        }

        /// <summary>
        /// 初始化绘制测距数据
        /// </summary>
        public void InitRangingData()
        {
            try
            {
                dgv_DrawRangingInfo.ReadOnly = true;
                dgv_DrawRangingInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawRanging)
                {
                    String key = de.Key.ToString();
                    RangingInfo value = (RangingInfo)de.Value;
                    int Number = 1;
                    double ZongJuLi = 0;
                    int count = dgv_DrawRangingInfo.RowCount;
                    for (int i = 0; i < value.RangingPointsInfo.Count; i++)
                    {
                        dgv_DrawRangingInfo.Rows.Add(1);
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingLineXvHao"].Value = value.LineID.ToString();
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointXvHao"].Value = (Number).ToString();
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointLong"].Value = value.RangingPointsInfo[i].X.ToString();
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointLat"].Value = value.RangingPointsInfo[i].Y.ToString();
                        if (Number == 1)
                        {
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_Angle"].Value = "0";
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLiKiloMetre"].Value = "0";
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLinauticalMile"].Value = "0";
                        }
                        else
                        {
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_Angle"].Value = Math.Round(mapTools.GetBearing(new PointF(value.RangingPointsInfo[i - 1].X, value.RangingPointsInfo[i - 1].Y), new PointF(value.RangingPointsInfo[i].X, value.RangingPointsInfo[i].Y)), 4).ToString();
                            double JuLi = mapTools.GetDistance((double)value.RangingPointsInfo[i - 1].X, (double)value.RangingPointsInfo[i - 1].Y, (double)value.RangingPointsInfo[i].X, (double)value.RangingPointsInfo[i].Y) / 1000;
                            JuLi = Math.Round(JuLi, 4);
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLiKiloMetre"].Value = JuLi.ToString();
                            double HaiLi = Math.Round(JuLi / 1.852, 4);
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLinauticalMile"].Value = HaiLi.ToString();
                            ZongJuLi += JuLi;
                            dgv_DrawRangingInfo.Rows[count + i].Cells["COL_AllJuLi"].Value = ZongJuLi.ToString();
                        }
                        Number++;
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return;
            }
        }

        public void BeforeRangingbyClick()
        {
            txt_RangingID.Enabled = false;
            txt_RangingLong.Enabled = false;
            txt_RangingLat.Enabled = false;
            btn_RangingOK.Enabled = false;
            btn_RangingCancle.Enabled = false;

            dgv_DrawRangingInfo.Enabled = false;
            btn_OpenRanging.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteRanging.Enabled = false;
            btn_EidtPoint.Enabled = false;
        }

        /// <summary>
        /// 添加测距数据至DGV
        /// </summary>
        public void AddRanginDataToDgv()
        {
            dgv_DrawRangingInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawRanging)
            {
                String key = de.Key.ToString();
                RangingInfo value = (RangingInfo)de.Value;
                int Number = 1;
                double ZongJuLi = 0;
                int count = dgv_DrawRangingInfo.RowCount;
                for (int i = 0; i < value.RangingPointsInfo.Count; i++)
                {
                    dgv_DrawRangingInfo.Rows.Add(1);
                    dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingLineXvHao"].Value = value.LineID.ToString();
                    dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointXvHao"].Value = (Number).ToString();
                    dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointLong"].Value = value.RangingPointsInfo[i].X.ToString();
                    dgv_DrawRangingInfo.Rows[count + i].Cells["COL_RangingPointLat"].Value = value.RangingPointsInfo[i].Y.ToString();
                    if (Number == 1)
                    {
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_Angle"].Value = "0";
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLiKiloMetre"].Value = "0";
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLinauticalMile"].Value = "0";
                    }
                    else
                    {
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_Angle"].Value = Math.Round(mapTools.GetBearing(new PointF(value.RangingPointsInfo[i - 1].X, value.RangingPointsInfo[i - 1].Y), new PointF(value.RangingPointsInfo[i].X, value.RangingPointsInfo[i].Y)), 4).ToString();
                        double JuLi = mapTools.GetDistance((double)value.RangingPointsInfo[i - 1].X, (double)value.RangingPointsInfo[i - 1].Y, (double)value.RangingPointsInfo[i].X, (double)value.RangingPointsInfo[i].Y) / 1000;
                        JuLi = Math.Round(JuLi, 4);
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLiKiloMetre"].Value = JuLi.ToString();
                        double HaiLi = Math.Round(JuLi / 1.852, 4);
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_JuLinauticalMile"].Value = HaiLi.ToString();
                        ZongJuLi += JuLi;
                        dgv_DrawRangingInfo.Rows[count + i].Cells["COL_AllJuLi"].Value = ZongJuLi.ToString();
                    }
                    Number++;
                }
            }
            dgv_DrawRangingInfo.Enabled = true;
            btn_OpenRanging.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeleteRanging.Enabled = true;
            btn_EidtPoint.Enabled = true;
            this.ControlBox = true;
            dgv_DrawRangingInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.frmDrawLineInfo.Enabled = true;
            main.fr_DrawPointInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.frmArea.Enabled = true;
            main.fr_Text.Enabled = true;
        }

        /// <summary>
        /// 关闭绘制测距弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawRanging_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 点击点选添加测距按钮进行点选添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DianXuanRanging_Click(object sender, EventArgs e)
        {
            BeforeRangingbyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选测距";
            main.frmDrawLineInfo.Enabled = false;
            main.fr_DrawPointInfo.Enabled = false;
            main.fr_DrawImageInfo.Enabled = false;
            main.frmDrawPolygonInfo.Enabled = false;
            main.frmArea.Enabled = false;
            main.fr_Text.Enabled = false;
            main.Activate();
        }

        /// <summary>
        /// 点击删除按钮删除测距信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteRanging_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string rangingID = dgv_DrawRangingInfo.Rows[NowSelectRowIndex].Cells["COL_RangingLineXvHao"].Value.ToString();
                DrawPen.AllDrawRanging.Remove(rangingID);
                int rowcount = dgv_DrawRangingInfo.RowCount;
                for (int i = rowcount - 1; i >= 0; i--)
                {
                    if (dgv_DrawRangingInfo.Rows[i].Cells["COL_RangingLineXvHao"].Value.ToString() == rangingID)
                    {
                        dgv_DrawRangingInfo.Rows.RemoveAt(i);
                    }
                }

                txt_RangingID.Text = "";
                txt_RangingLong.Text = "";
                txt_RangingLat.Text = "";
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;

                IsSelectRow = false;
                NowSelectRowIndex = -1;
                dgv_DrawRangingInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 手动添加测距点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddPoint_Click(object sender, EventArgs e)
        {
            txt_RangingID.Text = "";
            txt_RangingLong.Text = "";
            txt_RangingLat.Text = "";
            txt_RangingID.Enabled = true;
            txt_RangingLong.Enabled = true;
            txt_RangingLat.Enabled = true;
            btn_RangingOK.Enabled = true;
            btn_RangingOK.Text = "添加";
            btn_RangingCancle.Enabled = true;
            dgv_DrawRangingInfo.Enabled = false;
            btn_OpenRanging.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteRanging.Enabled = false;
            btn_EidtPoint.Enabled = false;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            dgv_DrawRangingInfo.ClearSelection();
        }

        /// <summary>
        /// 保存测距点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RangingOK_Click(object sender, EventArgs e)
        {
            if (txt_RangingID.Text == "" || txt_RangingLong.Text == "" || txt_RangingLat.Text == "")
            {
                MessageBox.Show("请将折测距点信息填写完整！");
                return;
            }
            if (btn_RangingOK.Text == "添加")
            {
                PointF fs = new PointF(float.Parse(txt_RangingLong.Text), float.Parse(txt_RangingLat.Text));
                main.map1.DrawPlotting.AddRangingObject(txt_RangingID.Text, fs);
            }
            else if (btn_RangingOK.Text == "修改")
            {
                PointF fs = new PointF(float.Parse(txt_RangingLong.Text), float.Parse(txt_RangingLat.Text));
                main.map1.DrawPlotting.EditRangingObject(txt_RangingID.Text, fs, Convert.ToInt32(dgv_DrawRangingInfo.Rows[NowSelectRowIndex].Cells["COL_RangingPointXvHao"].Value) - 1);
            }
            AddRanginDataToDgv();

            txt_RangingID.Enabled = false;
            txt_RangingLong.Enabled = false;
            txt_RangingLat.Enabled = false;
            btn_RangingOK.Text = "确定";
            btn_RangingOK.Enabled = false;
            btn_RangingCancle.Enabled = false;

            //刷新海图绘制状态
            main.map1.IsFlushMap = true;
        }

        /// <summary>
        /// 点击表格内某个表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawRangingInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;

            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingLineXvHao"].Value != null)
            {
                txt_RangingID.Text = dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingLineXvHao"].Value.ToString();
            }

            if (dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingPointLong"].Value != null)
            {
                txt_RangingLong.Text = dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingPointLong"].Value.ToString();
            }

            if (dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingPointLat"].Value != null)
            {
                txt_RangingLat.Text = dgv_DrawRangingInfo.Rows[e.RowIndex].Cells["COL_RangingPointLat"].Value.ToString();
            }
        }

        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RangingCancle_Click(object sender, EventArgs e)
        {
            txt_RangingID.Enabled = false;
            txt_RangingLong.Enabled = false;
            txt_RangingLat.Enabled = false;
            btn_RangingOK.Text = "确定";
            btn_RangingOK.Enabled = false;
            btn_RangingCancle.Enabled = false;
            dgv_DrawRangingInfo.Enabled = true;
            btn_OpenRanging.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeleteRanging.Enabled = true;
            btn_EidtPoint.Enabled = true;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            dgv_DrawRangingInfo.ClearSelection();
        }

        /// <summary>
        /// 修改选中测距点
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
            txt_RangingID.Enabled = false;
            txt_RangingLong.Enabled = true;
            txt_RangingLat.Enabled = true;
            btn_RangingOK.Enabled = true;
            btn_RangingOK.Text = "修改";
            btn_RangingCancle.Enabled = true;
            dgv_DrawRangingInfo.Enabled = false;
            btn_OpenRanging.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteRanging.Enabled = false;
            btn_EidtPoint.Enabled = false;
            IsSelectRow = false;
            dgv_DrawRangingInfo.ClearSelection();
        }
    }
}
