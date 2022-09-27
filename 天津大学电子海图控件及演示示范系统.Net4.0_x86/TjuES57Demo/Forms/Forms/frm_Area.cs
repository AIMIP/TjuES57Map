using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TjuES57Map.Draw;
using TjuES57Map.Library;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_Area : Form
    {
        public fr_Area()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
        public int NowSelectLinePointRowIndex = -1;
        public static ES57MapTools matTools = new ES57MapTools();
        public static bool IsOpenThisFrm = false;

        /// <summary>
        /// 绘制图形类实例化
        /// </summary>
        public DrawData DrawPen;

        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void OpenAreaWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitAreaData();
            this.Show();
        }

        /// <summary>
        /// 初始化绘制区域数据
        /// </summary>
        public void InitAreaData()
        {
            try
            {
                dgv_DrawAreaInfo.ReadOnly = true;
                dgv_DrawAreaInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawArea)
                {
                    String key = de.Key.ToString();
                    AreaInfo value = (AreaInfo)de.Value;
                    int Number = 1;
                    int count = dgv_DrawAreaInfo.RowCount;
                    for (int i = 0; i < value.AreaPointsInfo.Count; i++)
                    {
                        dgv_DrawAreaInfo.Rows.Add(1);
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaLineXvHao"].Value = value.AreaID.ToString();
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointXvHao"].Value = (Number).ToString();
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointLong"].Value = value.AreaPointsInfo[i].X.ToString();
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointLat"].Value = value.AreaPointsInfo[i].Y.ToString();
                        if (Number <= 2)
                        {
                            dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaKiloMetres"].Value = "0";
                            dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreanauticalMile"].Value = "0";
                        }
                        else
                        {
                            double MianJi = matTools.calculateArea(value.AreaPointsInfo);
                            MianJi = Math.Round(MianJi / 1000000, 2);
                            dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaKiloMetres"].Value = MianJi.ToString();
                            double HaiLi = Math.Round(MianJi / 3.429904, 2);
                            dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreanauticalMile"].Value = HaiLi.ToString();
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

        public void BeforeAreabyClick()
        {
            txt_AreaID.Enabled = false;
            txt_AreaLong.Enabled = false;
            txt_AreaLat.Enabled = false;
            btn_AreaOK.Enabled = false;
            btn_AreaCancle.Enabled = false;

            dgv_DrawAreaInfo.Enabled = false;
            btn_OpenArea.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteArea.Enabled = false;
            btn_EidtPoint.Enabled = false;
        }

        /// <summary>
        /// 添加新区域测量数据至DGV
        /// </summary>
        public void AddAreaDataToDgv()
        {
            dgv_DrawAreaInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawArea)
            {
                String key = de.Key.ToString();
                AreaInfo value = (AreaInfo)de.Value;
                int Number = 1;
                int count = dgv_DrawAreaInfo.RowCount;
                for (int i = 0; i < value.AreaPointsInfo.Count; i++)
                {
                    dgv_DrawAreaInfo.Rows.Add(1);
                    dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaLineXvHao"].Value = value.AreaID.ToString();
                    dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointXvHao"].Value = (Number).ToString();
                    dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointLong"].Value = value.AreaPointsInfo[i].X.ToString();
                    dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaPointLat"].Value = value.AreaPointsInfo[i].Y.ToString();
                    if (Number <= 2)
                    {
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaKiloMetres"].Value = "0";
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreanauticalMile"].Value = "0";
                    }
                    else
                    {
                        double MianJi = matTools.calculateArea(value.AreaPointsInfo);
                        MianJi = Math.Round(MianJi / 1000000, 2);
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreaKiloMetres"].Value = MianJi.ToString();
                        double HaiLi = Math.Round(MianJi / 3.429904, 2);
                        dgv_DrawAreaInfo.Rows[count + i].Cells["COL_AreanauticalMile"].Value = HaiLi.ToString();
                    }
                    Number++;
                }
            }
            dgv_DrawAreaInfo.Enabled = true;
            btn_OpenArea.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeleteArea.Enabled = true;
            btn_EidtPoint.Enabled = true;
            this.ControlBox = true;
            dgv_DrawAreaInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.fr_Text.Enabled = true;
            main.frmDrawLineInfo.Enabled = true;
            main.fr_DrawPointInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.frmRanging.Enabled = true;
        }

        /// <summary>
        /// 关闭测量区域面积弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawAreaInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 点击点选测面积按钮进行点选添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DianXuanLine_Click(object sender, EventArgs e)
        {
            BeforeAreabyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选测面积";
            main.frmDrawLineInfo.Enabled = false;
            main.fr_DrawPointInfo.Enabled = false;
            main.fr_DrawImageInfo.Enabled = false;
            main.frmDrawPolygonInfo.Enabled = false;
            main.frmRanging.Enabled = false;
            main.fr_Text.Enabled = false;
            main.Activate();
        }

        /// <summary>
        /// 清除当前测量区域面积数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteRanging_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string AreaID = dgv_DrawAreaInfo.Rows[NowSelectRowIndex].Cells["COL_AreaLineXvHao"].Value.ToString();
                DrawPen.AllDrawArea.Remove(AreaID);
                int rowcount = dgv_DrawAreaInfo.RowCount;
                for (int i = rowcount - 1; i >= 0; i--)
                {
                    if (dgv_DrawAreaInfo.Rows[i].Cells["COL_AreaLineXvHao"].Value.ToString() == AreaID)
                    {
                        dgv_DrawAreaInfo.Rows.RemoveAt(i);
                    }
                }

                txt_AreaID.Text = "";
                txt_AreaLong.Text = "";
                txt_AreaLat.Text = "";
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;

                IsSelectRow = false;
                NowSelectRowIndex = -1;
                dgv_DrawAreaInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 手动添加测面积点位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddPoint_Click(object sender, EventArgs e)
        {
            txt_AreaID.Text = "";
            txt_AreaLong.Text = "";
            txt_AreaLat.Text = "";
            txt_AreaID.Enabled = true;
            txt_AreaLong.Enabled = true;
            txt_AreaLat.Enabled = true;
            btn_AreaOK.Enabled = true;
            btn_AreaOK.Text = "添加";
            btn_AreaCancle.Enabled = true;
            dgv_DrawAreaInfo.Enabled = false;
            btn_OpenArea.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteArea.Enabled = false;
            btn_EidtPoint.Enabled = false;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            dgv_DrawAreaInfo.ClearSelection();
        }


        /// <summary>
        /// 修改选中测面积点
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
            txt_AreaID.Enabled = false;
            txt_AreaLong.Enabled = true;
            txt_AreaLat.Enabled = true;
            btn_AreaOK.Enabled = true;
            btn_AreaOK.Text = "修改";
            btn_AreaCancle.Enabled = true;
            dgv_DrawAreaInfo.Enabled = false;
            btn_OpenArea.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeleteArea.Enabled = false;
            btn_EidtPoint.Enabled = false;
            IsSelectRow = false;
            dgv_DrawAreaInfo.ClearSelection();
        }


        /// <summary>
        /// 点击表格内某个表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawAreaInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;

            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaLineXvHao"].Value != null)
            {
                txt_AreaID.Text = dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaLineXvHao"].Value.ToString();
            }

            if (dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaPointLong"].Value != null)
            {
                txt_AreaLong.Text = dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaPointLong"].Value.ToString();
            }

            if (dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaPointLat"].Value != null)
            {
                txt_AreaLat.Text = dgv_DrawAreaInfo.Rows[e.RowIndex].Cells["COL_AreaPointLat"].Value.ToString();
            }
        }


        /// <summary>
        /// 保存测面积点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AreaOK_Click(object sender, EventArgs e)
        {
            if (txt_AreaID.Text == "" || txt_AreaLong.Text == "" || txt_AreaLat.Text == "")
            {
                MessageBox.Show("请将折测距点信息填写完整！");
                return;
            }
            if (btn_AreaOK.Text == "添加")
            {
                PointF fs = new PointF(float.Parse(txt_AreaLong.Text), float.Parse(txt_AreaLat.Text));
                main.map1.DrawPlotting.AddAreaObject(txt_AreaID.Text, fs);
            }
            else if (btn_AreaOK.Text == "修改")
            {
                PointF fs = new PointF(float.Parse(txt_AreaLong.Text), float.Parse(txt_AreaLat.Text));
                main.map1.DrawPlotting.EditAreaObject(txt_AreaID.Text, fs, NowSelectRowIndex);
            }
            AddAreaDataToDgv();

            txt_AreaID.Enabled = false;
            txt_AreaLong.Enabled = false;
            txt_AreaLat.Enabled = false;
            btn_AreaOK.Text = "确定";
            btn_AreaOK.Enabled = false;
            btn_AreaCancle.Enabled = false;

            //刷新海图绘制状态
            main.map1.IsFlushMap = true;
        }

        private void btn_AreaCancle_Click(object sender, EventArgs e)
        {
            txt_AreaID.Enabled = false;
            txt_AreaLong.Enabled = false;
            txt_AreaLat.Enabled = false;
            btn_AreaOK.Text = "确定";
            btn_AreaOK.Enabled = false;
            btn_AreaCancle.Enabled = false;
            dgv_DrawAreaInfo.Enabled = true;
            btn_OpenArea.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeleteArea.Enabled = true;
            btn_EidtPoint.Enabled = true;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            dgv_DrawAreaInfo.ClearSelection();
        }
    }
}
