using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TjuES57Map.Draw;

namespace TjuES57Demo.Forms.Forms
{
    public partial class frm_Text : Form
    {
        public frm_Text()
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
        public void OpenTextWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitTextData();
            this.Show();
        }

        /// <summary>
        /// 初始化标注文本数据
        /// </summary>
        public void InitTextData()
        {
            try
            {
                int i = 0;
                dgv_DrawTextInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawTexts)
                {
                    String key = de.Key.ToString();
                    TextInfo value = (TextInfo)de.Value;
                    dgv_DrawTextInfo.Rows.Add(1);
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextXvHao"].Value = (i + 1).ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextID"].Value = value.TextID.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextLong"].Value = value.TextLongitude.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextLat"].Value = value.TextLatitude.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextInfo"].Value = value.Text_Info.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextFont"].Value = value.TextFont.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextColor"].Value = ColorTranslator.ToHtml(value.TextColor);
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextSize"].Value = value.TextSize.ToString();
                    dgv_DrawTextInfo.Rows[i].Cells["COL_TextRot"].Value = value.TextRot.ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return;
            }
        }

        private void btn_DianXuanText_Click(object sender, EventArgs e)
        {
            BeforeAddTextbyClick();
            this.ControlBox = false;
            main.CurOperaterType = "点选标注文本";
            main.fr_DrawPointInfo.Enabled = false;
            main.frmDrawLineInfo.Enabled = false;
            main.frmDrawPolygonInfo.Enabled = false;
            main.fr_DrawImageInfo.Enabled = false;
            main.frmRanging.Enabled = false;
            main.frmArea.Enabled = false;
            main.Activate();
        }

        public void BeforeAddTextbyClick()
        {
            txt_TextID.Enabled = false;
            txt_TextLong.Enabled = false;
            txt_TextLat.Enabled = false;
            txt_Text.Enabled = false;
            txt_TextColor.Enabled = false;
            txt_TextSize.Enabled = false;
            txt_TextFont.Enabled = false;
            txt_TextRot.Enabled = false;
            btn_AddTextOK.Enabled = false;
            btn_AddTextCancel.Enabled = false;

            dgv_DrawTextInfo.Enabled = false;
            btn_DianXuanText.Enabled = false;
            btn_HandToAddText.Enabled = false;
            btn_DeleteText.Enabled = false;
            btn_EditText.Enabled = false;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 添加文本数据至DGV
        /// </summary>
        public void AddTextDataToDgv()
        {
            int i = 0;
            dgv_DrawTextInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawTexts)
            {
                String key = de.Key.ToString();
                TextInfo value = (TextInfo)de.Value;

                dgv_DrawTextInfo.Rows.Add(1);
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextXvHao"].Value = (i + 1).ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextID"].Value = value.TextID.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextLong"].Value = value.TextLongitude.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextLat"].Value = value.TextLatitude.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextInfo"].Value = value.Text_Info.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextFont"].Value = value.TextFont.Name;
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextColor"].Value = ColorTranslator.ToHtml(value.TextColor);
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextSize"].Value = value.TextSize.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextRot"].Value = value.TextRot.ToString();
                i++;
            }
            dgv_DrawTextInfo.Enabled = true;
            btn_DianXuanText.Enabled = true;
            btn_HandToAddText.Enabled = true;
            btn_DeleteText.Enabled = true;
            btn_EditText.Enabled = true;
            this.ControlBox = true;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.fr_DrawPointInfo.Enabled = true;
            main.frmDrawLineInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
        }

        /// <summary>
        /// 添加文本数据至DGV(没添加就右键取消)
        /// </summary>
        public void AddNoTextDataToDgv()
        {
            int i = 0;
            dgv_DrawTextInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawTexts)
            {
                String key = de.Key.ToString();
                TextInfo value = (TextInfo)de.Value;

                dgv_DrawTextInfo.Rows.Add(1);
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextXvHao"].Value = (i + 1).ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextID"].Value = value.TextID.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextLong"].Value = value.TextLongitude.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextLat"].Value = value.TextLatitude.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextInfo"].Value = value.Text_Info.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextFont"].Value = value.TextFont.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextColor"].Value = ColorTranslator.ToHtml(value.TextColor);
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextSize"].Value = value.TextSize.ToString();
                dgv_DrawTextInfo.Rows[i].Cells["COL_TextRot"].Value = value.TextRot.ToString();
                i++;
            }
            dgv_DrawTextInfo.Enabled = true;
            btn_DianXuanText.Enabled = true;
            btn_HandToAddText.Enabled = true;
            btn_DeleteText.Enabled = true;
            btn_EditText.Enabled = true;
            this.ControlBox = true;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            main.fr_DrawPointInfo.Enabled = true;
            main.frmDrawLineInfo.Enabled = true;
            main.frmDrawPolygonInfo.Enabled = true;
            main.fr_DrawImageInfo.Enabled = true;
            main.frmRanging.Enabled = true;
            main.frmArea.Enabled = true;
        }

        private void frm_Text_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        private void btn_HandToAddText_Click(object sender, EventArgs e)
        {
            txt_TextID.Text = "";
            txt_TextLong.Text = "";
            txt_TextLat.Text = "";
            txt_Text.Text = "";
            txt_TextFont.Text = "";
            txt_TextSize.Text = "";
            txt_TextColor.Text = "";
            txt_TextRot.Text = "";
            txt_TextID.Enabled = true;
            txt_TextLong.Enabled = true;
            txt_TextLat.Enabled = true;
            txt_Text.Enabled = true;
            txt_TextFont.Enabled = true;
            txt_TextSize.Enabled = false;
            txt_TextColor.Enabled = true;
            txt_TextRot.Enabled = true;

            btn_AddTextOK.Enabled = true;
            btn_AddTextOK.Text = "添加";
            btn_AddTextCancel.Enabled = true;

            dgv_DrawTextInfo.Enabled = false;
            btn_DianXuanText.Enabled = false;
            btn_HandToAddText.Enabled = false;
            btn_DeleteText.Enabled = false;
            btn_EditText.Enabled = false;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        private void btn_AddTextCancel_Click(object sender, EventArgs e)
        {
            txt_TextID.Enabled = false;
            txt_TextLong.Enabled = false;
            txt_TextLat.Enabled = false;
            txt_Text.Enabled = false;
            txt_TextFont.Enabled = false;
            txt_TextSize.Enabled = false;
            txt_TextColor.Enabled = false;
            txt_TextRot.Enabled = false;

            btn_AddTextOK.Enabled = false;
            btn_AddTextOK.Text = "确定";
            btn_AddTextCancel.Enabled = false;

            dgv_DrawTextInfo.Enabled = true;
            btn_DianXuanText.Enabled = true;
            btn_HandToAddText.Enabled = true;
            btn_DeleteText.Enabled = true;
            btn_EditText.Enabled = true;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        private void btn_AddTextOK_Click(object sender, EventArgs e)
        {
            if (btn_AddTextOK.Text == "添加")
            {
                for (int i = 0; i < dgv_DrawTextInfo.RowCount; i++)
                {
                    if (dgv_DrawTextInfo.Rows[i].Cells["COL_TextID"].Value as string == txt_TextID.Text)
                    {
                        MessageBox.Show("文本标注ID不能重复！");
                        return;
                    }
                }
            }
            if (txt_TextID.Text == "" || txt_TextLong.Text == "" || txt_TextLat.Text == "" || txt_Text.Text == "" || txt_TextFont.Text == "" || txt_TextSize.Text == "" || txt_TextColor.Text == "" || txt_TextRot.Text == "")
            {
                MessageBox.Show("请将文本标注信息填写完整！");
                return;
            }
            if(float.Parse(txt_TextRot.Text) >= 180 || float.Parse(txt_TextRot.Text) <= -180)
            {
                MessageBox.Show("旋转角度应为-180°~180°！");
                return;
            }
            if (btn_AddTextOK.Text == "添加")
            {
                dgv_DrawTextInfo.Rows.Add(1);
                int RowsID = dgv_DrawTextInfo.Rows.Count - 1;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextXvHao"].Value = RowsID + 1;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextID"].Value = txt_TextID.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextLong"].Value = txt_TextLong.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextLat"].Value = txt_TextLat.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextInfo"].Value = txt_Text.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextFont"].Value = txt_TextFont.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextSize"].Value = txt_TextSize.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextColor"].Value = txt_TextColor.Text;
                dgv_DrawTextInfo.Rows[RowsID].Cells["COL_TextRot"].Value = txt_TextRot.Text;

                txt_TextID.Enabled = false;
                txt_TextLong.Enabled = false;
                txt_TextLat.Enabled = false;
                txt_Text.Enabled = false;
                txt_TextFont.Enabled = false;
                txt_TextColor.Enabled = false;
                txt_TextSize.Enabled = false;
                txt_TextRot.Enabled = false;
                btn_AddTextOK.Enabled = false;
                btn_AddTextOK.Text = "确定";
                btn_AddTextCancel.Enabled = false;
                //将添加后的数据进行保存更新
                main.map1.DrawPlotting.AddTextObject(txt_TextID.Text, double.Parse(txt_TextLat.Text), double.Parse(txt_TextLong.Text), txt_Text.Text, new Font(txt_TextFont.Text, float.Parse(txt_TextSize.Text), FontStyle.Bold), ColorTranslator.FromHtml(txt_TextColor.Text), (int)float.Parse(txt_TextSize.Text), float.Parse(txt_TextRot.Text));
            }
            else if (btn_AddTextOK.Text == "修改")
            {
                txt_TextID.Enabled = false;
                txt_TextLong.Enabled = false;
                txt_TextLat.Enabled = false;
                txt_Text.Enabled = false;
                txt_TextColor.Enabled = false;
                txt_TextSize.Enabled = false;
                txt_TextFont.Enabled = false;
                txt_TextRot.Enabled = false;
                btn_AddTextOK.Enabled = false;
                btn_AddTextOK.Text = "确定";
                btn_AddTextCancel.Enabled = false;

                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextID"].Value = txt_TextID.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextLong"].Value = txt_TextLong.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextLat"].Value = txt_TextLat.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextInfo"].Value = txt_Text.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextColor"].Value = txt_TextColor.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextSize"].Value = txt_TextSize.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextFont"].Value = txt_TextFont.Text;
                dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextRot"].Value = txt_TextRot.Text;

                //将修改后的数据进行保存更新
                main.map1.DrawPlotting.EditTextObject(txt_TextID.Text, double.Parse(txt_TextLat.Text), double.Parse(txt_TextLong.Text), txt_Text.Text, new Font(txt_TextFont.Text, float.Parse(txt_TextSize.Text), FontStyle.Bold), ColorTranslator.FromHtml(txt_TextColor.Text), (int)float.Parse(txt_TextSize.Text), float.Parse(txt_TextRot.Text));

            }
            //刷新海图绘制状态
            main.map1.IsFlushMap = true;
            dgv_DrawTextInfo.Enabled = true;
            btn_DianXuanText.Enabled = true;
            btn_HandToAddText.Enabled = true;
            btn_DeleteText.Enabled = true;
            btn_EditText.Enabled = true;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        private void txt_TextColor_Click(object sender, EventArgs e)
        {
            //允许使用该对话框的自定义颜色  
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            //初始化当前文本框中的字体颜色，  
            colorDialog1.Color = System.Drawing.Color.White;

            //当用户在ColorDialog对话框中点击"确定"按钮  
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_TextColor.Text = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void txt_TextFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowHelp = true;
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_TextFont.Text = fontDialog1.Font.Name;
                txt_TextSize.Text = fontDialog1.Font.Size.ToString();
            }
        }

        private void btn_EditText_Click(object sender, EventArgs e)
        {
            if (!IsSelectRow || NowSelectRowIndex < 0)
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
            txt_TextID.Enabled = false;
            txt_TextLong.Enabled = true;
            txt_TextLat.Enabled = true;
            txt_Text.Enabled = true;
            txt_TextFont.Enabled = true;
            txt_TextSize.Enabled = false;
            txt_TextColor.Enabled = true;
            txt_TextRot.Enabled = true;
            btn_AddTextOK.Enabled = true;
            btn_AddTextOK.Text = "修改";
            btn_AddTextCancel.Enabled = true;

            dgv_DrawTextInfo.Enabled = false;
            btn_DianXuanText.Enabled = false;
            btn_HandToAddText.Enabled = false;
            btn_DeleteText.Enabled = false;
            btn_EditText.Enabled = false;
            dgv_DrawTextInfo.ClearSelection();
            IsSelectRow = false;
        }

        private void btn_DeleteText_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string TextID = dgv_DrawTextInfo.Rows[NowSelectRowIndex].Cells["COL_TextID"].Value.ToString();
                //将删除后的数据进行保存更新
                main.map1.DrawPlotting.DeleteTextObject(TextID);
                dgv_DrawTextInfo.Rows.RemoveAt(NowSelectRowIndex);
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;
                IsSelectRow = false;
                NowSelectRowIndex = -1;
                
                txt_TextID.Text = "";
                txt_TextLong.Text = "";
                txt_TextLat.Text = "";
                txt_Text.Text = "";
                txt_TextColor.Text = "";
                txt_TextSize.Text = "";
                txt_TextFont.Text = "";
                txt_TextRot.Text = "";
                dgv_DrawTextInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        private void dgv_DrawTextInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextID"].Value != null)
            {
                txt_TextID.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextID"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextLong"].Value != null)
            {
                txt_TextLong.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextLong"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextLat"].Value != null)
            {
                txt_TextLat.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextLat"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextInfo"].Value != null)
            {
                txt_Text.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextInfo"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextColor"].Value != null)
            {
                txt_TextColor.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextColor"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextSize"].Value != null)
            {
                txt_TextSize.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextSize"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextFont"].Value != null)
            {
                txt_TextFont.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextFont"].Value.ToString();
            }
            if (dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextRot"].Value != null)
            {
                txt_TextRot.Text = dgv_DrawTextInfo.Rows[e.RowIndex].Cells["COL_TextRot"].Value.ToString();
            }
        }
    }
}
