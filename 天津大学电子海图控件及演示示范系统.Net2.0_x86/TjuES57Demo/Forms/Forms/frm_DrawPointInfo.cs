using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TjuES57Map.Draw;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_DrawPointInfo : Form
    {
        public fr_DrawPointInfo()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
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
            InitPointData();
            this.Show();
        }

        /// <summary>
        /// 初始化绘制点位数据
        /// </summary>
        public void InitPointData()
        {
            try
            {
                int i = 0;
                dgv_DrawPointInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawPoints)
                {
                    String key = de.Key.ToString();
                    PointInfo value = (PointInfo)de.Value;
                    dgv_DrawPointInfo.Rows.Add(1);
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointXvHao"].Value = (i + 1).ToString();
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointID"].Value = value.PointID.ToString();
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointLong"].Value = value.PointLongitude.ToString();
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointLat"].Value = value.PointLatitude.ToString();
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextInfo"].Value = value.PointTextInfo.ToString();
                    dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextColor"].Value = ColorTranslator.ToHtml(value.PointTextColor);
                    dgv_DrawPointInfo.Rows[i].Cells["COL_TextSize"].Value = value.PointTextFontSize.ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return;
            }
        }

        public void BeforeAddPointbyClick()
        {
            txt_PointID.Enabled = false;
            txt_PointLong.Enabled = false;
            txt_PointLat.Enabled = false;
            txt_PointText.Enabled = false;
            txt_PointTextColor.Enabled = false;
            txt_PointTextSize.Enabled = false;
            btn_AddPointOK.Enabled = false;
            btn_AddPointCencel.Enabled = false;

            dgv_DrawPointInfo.Enabled = false;
            btn_DianXuanPoint.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeletePoint.Enabled = false;
            btn_EidtPoint.Enabled = false;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 添加点位数据至DGV
        /// </summary>
        public void AddPointDataToDgv()
        {
            int i = 0;
            dgv_DrawPointInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawPoints)
            {
                String key = de.Key.ToString();
                PointInfo value = (PointInfo)de.Value;

                dgv_DrawPointInfo.Rows.Add(1);
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointXvHao"].Value = (i + 1).ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointID"].Value = value.PointID.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointLong"].Value = value.PointLongitude.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointLat"].Value = value.PointLatitude.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextInfo"].Value = value.PointTextInfo.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextColor"].Value = ColorTranslator.ToHtml(value.PointTextColor);
                dgv_DrawPointInfo.Rows[i].Cells["COL_TextSize"].Value = value.PointTextFontSize.ToString();
                i++;
            }
            dgv_DrawPointInfo.Enabled = true;
            btn_DianXuanPoint.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeletePoint.Enabled = true;
            btn_EidtPoint.Enabled = true;
            this.ControlBox = true;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.frmDrawLineInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
            main.fr_Text.Enabled = true;
        }

        /// <summary>
        /// 添加点位数据至DGV(没添加就右键取消)
        /// </summary>
        public void AddNoPointDataToDgv()
        {
            int i = 0;
            dgv_DrawPointInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawPoints)
            {
                String key = de.Key.ToString();
                PointInfo value = (PointInfo)de.Value;

                dgv_DrawPointInfo.Rows.Add(1);
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointXvHao"].Value = (i + 1).ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointID"].Value = value.PointID.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointLong"].Value = value.PointLongitude.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointLat"].Value = value.PointLatitude.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextInfo"].Value = value.PointTextInfo.ToString();
                dgv_DrawPointInfo.Rows[i].Cells["COL_PointTextColor"].Value = ColorTranslator.ToHtml(value.PointTextColor);
                dgv_DrawPointInfo.Rows[i].Cells["COL_TextSize"].Value = value.PointTextFontSize.ToString();
                i++;
            }
            dgv_DrawPointInfo.Enabled = true;
            btn_DianXuanPoint.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeletePoint.Enabled = true;
            btn_EidtPoint.Enabled = true;
            this.ControlBox = true;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.frmDrawLineInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
            main.fr_Text.Enabled = true;
        }

        /// <summary>
        /// 关闭绘制点位弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawPointInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 手动添加绘制点位数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddPoint_Click(object sender, EventArgs e)
        {
            txt_PointID.Text = "";
            txt_PointLong.Text = "";
            txt_PointLat.Text = "";
            txt_PointText.Text = "";
            txt_PointTextColor.Text = "";
            txt_PointTextSize.Text = "";
            txt_PointID.Enabled = true;
            txt_PointLong.Enabled = true;
            txt_PointLat.Enabled = true;
            txt_PointText.Enabled = true;
            txt_PointTextColor.Enabled = true;
            txt_PointTextSize.Enabled = true;
            btn_AddPointOK.Enabled = true;
            btn_AddPointOK.Text = "添加";
            btn_AddPointCencel.Enabled = true;
            dgv_DrawPointInfo.Enabled = false;
            btn_DianXuanPoint.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeletePoint.Enabled = false;
            btn_EidtPoint.Enabled = false;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击点选添加点位按钮进行点选添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DianXuanPoint_Click(object sender, EventArgs e)
        {
            BeforeAddPointbyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选绘制点位";
            main.frmDrawLineInfo.Enabled = false;
            main.frmDrawPolygonInfo.Enabled = false;
            main.fr_DrawImageInfo.Enabled = false;
            main.frmRanging.Enabled = false;
            main.frmArea.Enabled = false;
            main.fr_Text.Enabled = false;
            main.Activate();
        }

        /// <summary>
        /// 点击确定添加点位数据(手动添加)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPointOK_Click(object sender, EventArgs e)
        {
            if (btn_AddPointOK.Text == "添加")
            {
                for (int i = 0; i < dgv_DrawPointInfo.RowCount; i++)
                {
                    if (dgv_DrawPointInfo.Rows[i].Cells["COL_PointID"].Value as string == txt_PointID.Text)
                    {
                        MessageBox.Show("点位ID不能重复！");
                        return;
                    }
                }
            }
            if (txt_PointID.Text == "" || txt_PointLong.Text == "" || txt_PointLat.Text == "" || txt_PointText.Text == "" || txt_PointTextColor.Text == "" || txt_PointTextSize.Text == "")
            {
                MessageBox.Show("请将点位信息填写完整！");
                return;
            }
            if (btn_AddPointOK.Text == "添加")
            {
                dgv_DrawPointInfo.Rows.Add(1);
                int RowsID = dgv_DrawPointInfo.Rows.Count - 1;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointXvHao"].Value = RowsID + 1;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointID"].Value = txt_PointID.Text;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointLong"].Value = txt_PointLong.Text;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointLat"].Value = txt_PointLat.Text;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointTextInfo"].Value = txt_PointText.Text;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_PointTextColor"].Value = txt_PointTextColor.Text;
                dgv_DrawPointInfo.Rows[RowsID].Cells["COL_TextSize"].Value = txt_PointTextSize.Text;

                txt_PointID.Enabled = false;
                txt_PointLong.Enabled = false;
                txt_PointLat.Enabled = false;
                txt_PointText.Enabled = false;
                txt_PointTextColor.Enabled = false;
                txt_PointTextSize.Enabled = false;
                btn_AddPointOK.Enabled = false;
                btn_AddPointOK.Text = "确定";
                btn_AddPointCencel.Enabled = false;
                //将添加后的数据进行保存更新
                main.map1.DrawPlotting.AddPointObject(txt_PointID.Text, double.Parse(txt_PointLat.Text), double.Parse(txt_PointLong.Text), txt_PointText.Text, ColorTranslator.FromHtml(txt_PointTextColor.Text), int.Parse(txt_PointTextSize.Text), @".\点位管理.png");
            }
            else if (btn_AddPointOK.Text == "修改")
            {
                txt_PointID.Enabled = false;
                txt_PointLong.Enabled = false;
                txt_PointLat.Enabled = false;
                txt_PointText.Enabled = false;
                txt_PointTextColor.Enabled = false;
                txt_PointTextSize.Enabled = false;
                btn_AddPointOK.Enabled = false;
                btn_AddPointOK.Text = "确定";
                btn_AddPointCencel.Enabled = false;

                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointID"].Value = txt_PointID.Text;
                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointLong"].Value = txt_PointLong.Text;
                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointLat"].Value = txt_PointLat.Text;
                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointTextInfo"].Value = txt_PointText.Text;
                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointTextColor"].Value = txt_PointTextColor.Text;
                dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_TextSize"].Value = txt_PointTextSize.Text;

                //将修改后的数据进行保存更新
                main.map1.DrawPlotting.EidtPointObject(txt_PointID.Text, double.Parse(txt_PointLong.Text), double.Parse(txt_PointLat.Text), txt_PointText.Text, ColorTranslator.FromHtml(txt_PointTextColor.Text), int.Parse(txt_PointTextSize.Text), @".\点位管理.png");

            }
            //刷新海图绘制状态
            main.map1.IsFlushMap = true;
            dgv_DrawPointInfo.Enabled = true;
            btn_DianXuanPoint.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeletePoint.Enabled = true;
            btn_EidtPoint.Enabled = true;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击删除按钮删除点位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string PointID = dgv_DrawPointInfo.Rows[NowSelectRowIndex].Cells["COL_PointID"].Value.ToString();
                //将删除后的数据进行保存更新
                main.map1.DrawPlotting.DeletePointObject(PointID);
                dgv_DrawPointInfo.Rows.RemoveAt(NowSelectRowIndex);
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;
                IsSelectRow = false;
                NowSelectRowIndex = -1;
                txt_PointID.Text = "";
                txt_PointLong.Text = "";
                txt_PointLat.Text = "";
                txt_PointText.Text = "";
                txt_PointTextColor.Text = "";
                txt_PointTextSize.Text = "";
                dgv_DrawPointInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 点击修改按钮修改点位信息
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
            txt_PointID.Enabled = false;
            txt_PointLong.Enabled = true;
            txt_PointLat.Enabled = true;
            txt_PointText.Enabled = true;
            txt_PointTextColor.Enabled = true;
            txt_PointTextSize.Enabled = true;
            btn_AddPointOK.Enabled = true;
            btn_AddPointOK.Text = "修改";
            btn_AddPointCencel.Enabled = true;
            dgv_DrawPointInfo.Enabled = false;
            btn_DianXuanPoint.Enabled = false;
            btn_HandToAddPoint.Enabled = false;
            btn_DeletePoint.Enabled = false;
            btn_EidtPoint.Enabled = false;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
        }

        /// <summary>
        /// 点击取消按钮取消添加或修改点位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPointCencel_Click(object sender, EventArgs e)
        {
            txt_PointID.Enabled = false;
            txt_PointLong.Enabled = false;
            txt_PointLat.Enabled = false;
            txt_PointText.Enabled = false;
            txt_PointTextColor.Enabled = false;
            txt_PointTextSize.Enabled = false;
            btn_AddPointOK.Enabled = false;
            btn_AddPointOK.Text = "确定";
            btn_AddPointCencel.Enabled = false;
            dgv_DrawPointInfo.Enabled = true;
            btn_DianXuanPoint.Enabled = true;
            btn_HandToAddPoint.Enabled = true;
            btn_DeletePoint.Enabled = true;
            btn_EidtPoint.Enabled = true;
            dgv_DrawPointInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击颜色设置文本框弹出颜色设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PointTextColor_Click(object sender, EventArgs e)
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
                txt_PointTextColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }


        /// <summary>
        /// 点击点位数据DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawPointInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointID"].Value != null)
            {
                txt_PointID.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointID"].Value.ToString();
            }

            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointLong"].Value != null)
            {
                txt_PointLong.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointLong"].Value.ToString();
            }

            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointLat"].Value != null)
            {
                txt_PointLat.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointLat"].Value.ToString();
            }

            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointTextInfo"].Value != null)
            {
                txt_PointText.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointTextInfo"].Value.ToString();
            }

            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointTextColor"].Value != null)
            {
                txt_PointTextColor.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_PointTextColor"].Value.ToString();
            }

            if (dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_TextSize"].Value != null)
            {
                txt_PointTextSize.Text = dgv_DrawPointInfo.Rows[e.RowIndex].Cells["COL_TextSize"].Value.ToString();
            }
        }
    }
}
