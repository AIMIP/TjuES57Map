using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TjuES57Map.Draw;

namespace TjuES57Demo.Forms.Forms
{
    public partial class fr_DrawImageInfo : Form
    {
        public fr_DrawImageInfo()
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
        public void OpenImageWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            DrawPen = main.map1.DrawPlotting.DrawPen;
            InitImageData();
            this.Show();
        }

        /// <summary>
        /// 初始化绘制图片数据
        /// </summary>
        public void InitImageData()
        {
            try
            {
                int i = 0;
                dgv_DrawImageInfo.Rows.Clear();
                foreach (DictionaryEntry de in DrawPen.AllDrawImages)
                {
                    String key = de.Key.ToString();

                    ImageInfo value = (ImageInfo)de.Value;

                    dgv_DrawImageInfo.Rows.Add(1);
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImageXvHao"].Value = (i + 1).ToString();
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImageIndex"].Value = value.ImageIndex.ToString();
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImageLong"].Value = value.ImageLongitude.ToString();
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImageLat"].Value = value.ImageLatitude.ToString();
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImageTag"].Value = value.ImageTagInfo.ToString();
                    dgv_DrawImageInfo.Rows[i].Cells["COL_ImagePath"].Value = value.ImagePath.ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return;
            }
        }

        /// <summary>
        /// 添加图片数据至DGV
        /// </summary>
        public void AddImageDataToDgv()
        {
            int i = 0;
            dgv_DrawImageInfo.Rows.Clear();
            foreach (DictionaryEntry de in DrawPen.AllDrawImages)
            {
                String key = de.Key.ToString();
                ImageInfo value = (ImageInfo)de.Value;

                dgv_DrawImageInfo.Rows.Add(1);
                dgv_DrawImageInfo.Rows[i].Cells["COL_ImageXvHao"].Value = (i + 1).ToString();
                dgv_DrawImageInfo.Rows[i].Cells["COL_ImageIndex"].Value = value.ImageIndex.ToString();
                dgv_DrawImageInfo.Rows[i].Cells["COL_ImageLong"].Value = value.ImageLongitude.ToString();
                dgv_DrawImageInfo.Rows[i].Cells["COL_ImageLat"].Value = value.ImageLatitude.ToString();
                i++;
            }
        }

        /// <summary>
        /// 关闭绘制图片弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr_DrawImageInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
            main.CurOperaterType = "";
        }

        /// <summary>
        /// 手动添加绘制图片数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HandToAddImage_Click(object sender, EventArgs e)
        {
            txt_ImageIndex.Text = "";
            txt_ImageLong.Text = "";
            txt_ImageLat.Text = "";
            txt_ImagePath.Text = "";
            txt_ImageTag.Text = "";
            txt_ImageIndex.Enabled = true;
            txt_ImageLong.Enabled = true;
            txt_ImageLat.Enabled = true;
            txt_ImagePath.Enabled = true;
            txt_ImageTag.Enabled = true;
            btn_SelectImage.Enabled = true;
            btn_AddImageOK.Enabled = true;
            btn_AddImageOK.Text = "添加";
            btn_AddImageCencel.Enabled = true;
            dgv_DrawImageInfo.Enabled = false;
            btn_HandToAddImage.Enabled = false;
            btn_DeleteImage.Enabled = false;
            btn_EidtImage.Enabled = false;
            IsSelectRow = false;
            NowSelectRowIndex = -1;
            dgv_DrawImageInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }


        /// <summary>
        /// 点击确定添加贴图数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddImageOK_Click(object sender, EventArgs e)
        {
            if (btn_AddImageOK.Text == "添加")
            {
                for (int i = 0; i < dgv_DrawImageInfo.RowCount; i++)
                {
                    if (dgv_DrawImageInfo.Rows[i].Cells["COL_ImageIndex"].Value as string == txt_ImageIndex.Text)
                    {
                        MessageBox.Show("贴图ID不能重复！");
                        return;
                    }
                }
            }
            if (txt_ImageIndex.Text == "" || txt_ImageLong.Text == "" || txt_ImageLat.Text == "" || txt_ImageTag.Text == "" || txt_ImagePath.Text == "")
            {
                MessageBox.Show("请将贴图信息填写完整！");
                return;
            }
            if (btn_AddImageOK.Text == "添加")
            {
                dgv_DrawImageInfo.Rows.Add(1);
                int RowsID = dgv_DrawImageInfo.Rows.Count - 1;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImageXvHao"].Value = RowsID + 1;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImageIndex"].Value = txt_ImageIndex.Text;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImageLong"].Value = txt_ImageLong.Text;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImageLat"].Value = txt_ImageLat.Text;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImageTag"].Value = txt_ImageTag.Text;
                dgv_DrawImageInfo.Rows[RowsID].Cells["COL_ImagePath"].Value = txt_ImagePath.Text;


                txt_ImageIndex.Enabled = false;
                txt_ImageLong.Enabled = false;
                txt_ImageLat.Enabled = false;
                txt_ImagePath.Enabled = false;
                txt_ImageTag.Enabled = false;
                btn_AddImageOK.Enabled = false;
                btn_AddImageOK.Text = "确定";
                btn_AddImageCencel.Enabled = false;
                //将添加后的数据进行保存更新
                main.map1.DrawPlotting.AddImageObject(txt_ImageIndex.Text, double.Parse(txt_ImageLong.Text), double.Parse(txt_ImageLat.Text), txt_ImageTag.Text, txt_ImagePath.Text);
            }
            else if (btn_AddImageOK.Text == "修改")
            {
                txt_ImageIndex.Enabled = false;
                txt_ImageLong.Enabled = false;
                txt_ImageLat.Enabled = false;
                txt_ImagePath.Enabled = false;
                txt_ImageTag.Enabled = false;
                btn_AddImageOK.Enabled = false;
                btn_AddImageOK.Text = "确定";
                btn_AddImageCencel.Enabled = false;

                dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImageIndex"].Value = txt_ImageIndex.Text;
                dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImageLong"].Value = txt_ImageLong.Text;
                dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImageLat"].Value = txt_ImageLat.Text;
                dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImageTag"].Value = txt_ImageTag.Text;
                dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImagePath"].Value = txt_ImagePath.Text;
                //将修改后的数据进行保存更新
                main.map1.DrawPlotting.EidtImageObject(txt_ImageIndex.Text, double.Parse(txt_ImageLong.Text), double.Parse(txt_ImageLat.Text), txt_ImageTag.Text, txt_ImagePath.Text);

            }
            //刷新海图绘制状态
            main.map1.IsFlushMap = true;
            dgv_DrawImageInfo.Enabled = true;
            btn_HandToAddImage.Enabled = true;
            btn_DeleteImage.Enabled = true;
            btn_EidtImage.Enabled = true;
            btn_SelectImage.Enabled = false;
            dgv_DrawImageInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击删除按钮删除贴图信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteImage_Click(object sender, EventArgs e)
        {
            if (IsSelectRow && NowSelectRowIndex >= 0)
            {
                string ImageIndex = dgv_DrawImageInfo.Rows[NowSelectRowIndex].Cells["COL_ImageIndex"].Value.ToString();
                //将删除后的数据进行保存更新
                main.map1.DrawPlotting.DeleteImageObject(ImageIndex);
                dgv_DrawImageInfo.Rows.RemoveAt(NowSelectRowIndex);
                //刷新海图绘制状态
                main.map1.IsFlushMap = true;
                IsSelectRow = false;
                NowSelectRowIndex = -1;
                
                txt_ImageIndex.Text = "";
                txt_ImageLong.Text = "";
                txt_ImageLat.Text = "";
                txt_ImagePath.Text = "";
                txt_ImageTag.Text = "";
                dgv_DrawImageInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }
        }

        /// <summary>
        /// 点击修改按钮修改贴图信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EidtImage_Click(object sender, EventArgs e)
        {
            if (!IsSelectRow || NowSelectRowIndex < 0)
            {
                MessageBox.Show("当前没有选中任何行！");
                return;
            }

            txt_ImageIndex.Enabled = false;
            txt_ImageLong.Enabled = true;
            txt_ImageLat.Enabled = true;
            txt_ImagePath.Enabled = true;
            txt_ImageTag.Enabled = true;
            btn_AddImageOK.Enabled = true;
            btn_AddImageOK.Text = "修改";
            btn_AddImageCencel.Enabled = true;
            dgv_DrawImageInfo.Enabled = false;
            btn_HandToAddImage.Enabled = false;
            btn_DeleteImage.Enabled = false;
            btn_EidtImage.Enabled = false;
            btn_SelectImage.Enabled = true;
            dgv_DrawImageInfo.ClearSelection();
            IsSelectRow = false;
        }

        /// <summary>
        /// 点击取消按钮取消添加或修改贴图信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddImageCencel_Click(object sender, EventArgs e)
        {
            txt_ImageIndex.Enabled = false;
            txt_ImageLong.Enabled = false;
            txt_ImageLat.Enabled = false;
            txt_ImagePath.Enabled = false;
            txt_ImageTag.Enabled = false;
            btn_AddImageOK.Enabled = false;
            btn_AddImageOK.Text = "确定";
            btn_AddImageCencel.Enabled = false;
            dgv_DrawImageInfo.Enabled = true;
            btn_HandToAddImage.Enabled = true;
            btn_DeleteImage.Enabled = true;
            btn_EidtImage.Enabled = true;
            btn_SelectImage.Enabled = false;
            dgv_DrawImageInfo.ClearSelection();
            IsSelectRow = false;
            NowSelectRowIndex = -1;
        }

        /// <summary>
        /// 点击选择图片路径按钮进行图片选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            //打开文件目录
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            //可以选取多个文件
            op.Multiselect = false;
            if (op.ShowDialog() == DialogResult.OK)
            {
                for (int fi = 0; fi < op.FileNames.Length; fi++)
                {
                    //获取对话框中所有选定文件的文件名。
                    String DataFilePath = op.FileNames[fi].ToString();
                    txt_ImagePath.Text = DataFilePath;
                }
            }
        }

        /// <summary>
        /// 点击DGV中某表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DrawImageInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsSelectRow = true;
            NowSelectRowIndex = e.RowIndex;
            if (NowSelectRowIndex < 0)
            {
                return;
            }
            if (dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageIndex"].Value != null)
            {
                txt_ImageIndex.Text = dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageIndex"].Value.ToString();
            }

            if (dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageLong"].Value != null)
            {
                txt_ImageLong.Text = dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageLong"].Value.ToString();
            }

            if (dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageLat"].Value != null)
            {
                txt_ImageLat.Text = dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageLat"].Value.ToString();
            }

            if (dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageTag"].Value != null)
            {
                txt_ImageTag.Text = dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImageTag"].Value.ToString();
            }

            if (dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImagePath"].Value != null)
            {
                txt_ImagePath.Text = dgv_DrawImageInfo.Rows[e.RowIndex].Cells["COL_ImagePath"].Value.ToString();
            }
        }
    }
}
