using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TjuES57Demo.Forms
{
    public partial class frm_chaxun : Form
    {
        public frm_chaxun()
        {
            InitializeComponent();
        }

        private fr_MainForm main;
        public Boolean IsSelectRow = false;
        public int NowSelectRowIndex = -1;
        public static bool IsOpenThisFrm = false;

        /// <summary>
        /// 打开此弹窗并进行初始化
        /// </summary>
        /// <param name="mainForm"></param>
        public void OpenIdentifyWindow()
        {
            this.Show();
            InitIdentifyData();
        }

        public void InitIdentifyData()
        {
            if (main.map1.ES57Para.IsHighlight) btn_highlight.Text = "取消高亮";
            else btn_highlight.Text = "高亮";
            dgv_LayerInfo.Rows.Clear();
            dgv_BasicInfo.Rows.Clear();
            dgv_Attribute.Rows.Clear();
            main.map1.GetIdentifiedRecInfoAndHighlight(-1);
            List<string> layerName = (List<string>)main.map1.hsIdentifiedRec["LayerInfo"];
            Hashtable hsBasicInfo = (Hashtable)main.map1.hsIdentifiedRec["BasicInfo"];
            Hashtable hsAttribute = (Hashtable)main.map1.hsIdentifiedRec["Attribute"];
            int i = 0;
            foreach (string item in layerName)
            {
                dgv_LayerInfo.Rows.Add(1);
                dgv_LayerInfo.Rows[i].Cells["COL_ObjectXvHao"].Value = (i + 1).ToString();
                dgv_LayerInfo.Rows[i].Cells["COL_ObjectName"].Value = main.map1.GetLayerChiName(item);
                i++;
            }
            dgv_LayerInfo.ClearSelection();
            dgv_LayerInfo.Rows[main.map1.CurRecInd].Selected = true;
            dgv_BasicInfo.Rows.Add(4);
            dgv_BasicInfo.Rows[0].Cells["COL1"].Value = "海图代码:";
            dgv_BasicInfo.Rows[0].Cells["COL2"].Value = hsBasicInfo["CurMap"];
            dgv_BasicInfo.Rows[1].Cells["COL1"].Value = "物标缩写:";
            dgv_BasicInfo.Rows[1].Cells["COL2"].Value = hsBasicInfo["Acro"];
            dgv_BasicInfo.Rows[2].Cells["COL1"].Value = "物标类型:";
            dgv_BasicInfo.Rows[2].Cells["COL2"].Value = hsBasicInfo["Category"];
            dgv_BasicInfo.Rows[3].Cells["COL1"].Value = "中心坐标:";
            dgv_BasicInfo.Rows[3].Cells["COL2"].Value = hsBasicInfo["PositionX"].ToString() + ", " + hsBasicInfo["PositionY"].ToString();
            dgv_BasicInfo.ClearSelection();
            i = 0;
            foreach (DictionaryEntry de in hsAttribute)
            {
                dgv_Attribute.Rows.Add(1);
                dgv_Attribute.Rows[i].Cells["COL_Attr"].Value = de.Key.ToString();
                dgv_Attribute.Rows[i].Cells["COL_AttrValue"].Value = de.Value.ToString();
                i++;
            }
            dgv_Attribute.ClearSelection();
        }

        private void frm_chaxun_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.map1.ES57Para.IsHighlight = false;
            main.map1.IsFlushMap = true;
        }

        public void SetHighlight(fr_MainForm mainform)
        {
            main = mainform;
            main.map1.ES57Para.IsHighlight = true;
        }

        private void dgv_LayerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            main.map1.GetIdentifiedRecInfoAndHighlight(NowSelectRowIndex);
            Hashtable hsBasicInfo = (Hashtable)main.map1.hsIdentifiedRec["BasicInfo"];
            Hashtable hsAttribute = (Hashtable)main.map1.hsIdentifiedRec["Attribute"];
            dgv_BasicInfo.Rows.Clear();
            dgv_Attribute.Rows.Clear();
            dgv_BasicInfo.Rows.Add(4);
            dgv_BasicInfo.Rows[0].Cells["COL1"].Value = "海图代码:";
            dgv_BasicInfo.Rows[0].Cells["COL2"].Value = hsBasicInfo["CurMap"];
            dgv_BasicInfo.Rows[1].Cells["COL1"].Value = "物标缩写:";
            dgv_BasicInfo.Rows[1].Cells["COL2"].Value = hsBasicInfo["Acro"];
            dgv_BasicInfo.Rows[2].Cells["COL1"].Value = "物标类型:";
            dgv_BasicInfo.Rows[2].Cells["COL2"].Value = hsBasicInfo["Category"];
            dgv_BasicInfo.Rows[3].Cells["COL1"].Value = "中心坐标:";
            dgv_BasicInfo.Rows[3].Cells["COL2"].Value = hsBasicInfo["PositionX"].ToString() + ", " + hsBasicInfo["PositionY"].ToString();
            dgv_BasicInfo.ClearSelection();
            int i = 0;
            foreach (DictionaryEntry de in hsAttribute)
            {
                dgv_Attribute.Rows.Add(1);
                dgv_Attribute.Rows[i].Cells["COL_Attr"].Value = de.Key.ToString();
                dgv_Attribute.Rows[i].Cells["COL_AttrValue"].Value = de.Value.ToString();
                i++;
            }
            dgv_Attribute.ClearSelection();
        }

        private void btn_highlight_Click(object sender, EventArgs e)
        {
            main.map1.ES57Para.IsHighlight = !main.map1.ES57Para.IsHighlight;
            if (main.map1.ES57Para.IsHighlight) btn_highlight.Text = "取消高亮";
            else btn_highlight.Text = "高亮";
            main.map1.IsFlushMap = true;
        }
    }
}
