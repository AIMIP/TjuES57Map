using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TjuES57Demo.Forms
{
    public partial class fr_TuCengManager : Form
    {
        private bool IsLoadFinish = false;
        private fr_MainForm parentForm;
        private string _name = "";
        public static bool IsOpenThisFrm = false;

        public fr_TuCengManager()
        {
            InitializeComponent();
        }

        public void OpenTuCengManager(fr_MainForm mainForm)
        {
            parentForm = mainForm;
            this.Show();
        }

        /// <summary>
        /// 加载图层管理弹窗数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapListManager_Load(object sender, EventArgs e)
        {
            dgv_TuCeng.EnableHeadersVisualStyles = false;
            dgv_TuCeng.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 10, FontStyle.Bold);
            dgv_TuCeng.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_TuCeng.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            IsLoadFinish = false;
            dgv_TuCeng.Rows.Clear();
            Hashtable hsExistLayerName = new Hashtable();
            //获取当前海图图层数据
            List<string> AllS57FileName = parentForm.map1.GetAllFileName();
            //遍历所有图层数据并向菜单栏中添加图层数据
            for (int i = 0; i < AllS57FileName.Count; i++)
            {
                Hashtable hsLayerInfo = parentForm.map1.GetAllLayer(AllS57FileName[i]);
                if (hsLayerInfo.Count <= 0) continue;
                foreach (DictionaryEntry item in hsLayerInfo)
                {
                    if (hsExistLayerName.ContainsKey(item.Key.ToString())) continue;
                    hsExistLayerName.Add(item.Key.ToString(), item.Value.ToString());
                    dgv_TuCeng.Rows.Add(1);
                    int RowsID = dgv_TuCeng.Rows.Count - 1;
                    dgv_TuCeng.Rows[RowsID].Cells["COL_ReallyName"].Value = item.Key.ToString();
                    dgv_TuCeng.Rows[RowsID].Cells["COL_IsShow"].Value = parentForm.map1.ES57Para.GetAllMapOneLayerShow(item.Key.ToString());
                    dgv_TuCeng.Rows[RowsID].Cells["COL_TuCeng"].Value = item.Value.ToString();
                }
            }
            IsLoadFinish = true;
        }

        /// <summary>
        /// 点击关闭按钮关闭弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sureexit_Click(object sender, EventArgs e)
        {
            IsOpenThisFrm = false;
            Close();
        }

        /// <summary>
        /// 点击全部显示按钮显示所有图层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AllShow_Click(object sender, EventArgs e)
        {
            int length = dgv_TuCeng.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                dgv_TuCeng.Rows[i].Cells["COL_IsShow"].Value = true;
            }
            //设置海图图层全部显示
            parentForm.map1.ES57Para.SetAllMapAllLayersShow(true);
            parentForm.IsLayerManager = true;
            parentForm.updateMapLayerInfo();
            //刷新海图绘制状态
            parentForm.map1.IsFlushMap = true;
        }

        /// <summary>
        /// 点击全部不显示按钮隐藏所有图层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AllNotShow_Click(object sender, EventArgs e)
        {
            int length = dgv_TuCeng.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                dgv_TuCeng.Rows[i].Cells["COL_IsShow"].Value = false;
            }
            //设置海图图层全部隐藏
            parentForm.map1.ES57Para.SetAllMapAllLayersShow(false);
            parentForm.IsLayerManager = true;
            parentForm.updateMapLayerInfo();
            //刷新海图绘制状态
            parentForm.map1.IsFlushMap = true;
        }

        /// <summary>
        /// 点击图层表格中某图层选项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_TuCeng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || !IsLoadFinish)
            {
                return;
            }
            _name = dgv_TuCeng.Rows[index].Cells["COL_ReallyName"].Value.ToString();
            string isShow = dgv_TuCeng.Rows[index].Cells["COL_IsShow"].Value.ToString();
            if (isShow == "true")
            {
                //设置指定海图图层显示
                parentForm.map1.ES57Para.SetAllMapOneLayerShow(_name, true);
                parentForm.IsLayerManager = true;
                parentForm.updateMapLayerInfo();
            }
            else if (isShow == "false")
            {
                //设置指定海图图层隐藏
                parentForm.map1.ES57Para.SetAllMapOneLayerShow(_name, false);
                parentForm.IsLayerManager = true;
                parentForm.updateMapLayerInfo();
            }
            //刷新海图绘制状态
            parentForm.map1.IsFlushMap = true;
        }

        /// <summary>
        /// 图层表格中某图层选项修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_TuCeng_CurCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_TuCeng.IsCurrentCellDirty)
            {
                dgv_TuCeng.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void fr_TuCengManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
        }
    }
}
