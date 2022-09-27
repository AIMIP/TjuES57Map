namespace TjuES57Demo.Forms.Forms
{
    partial class fr_DrawImageInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DrawImageInfo));
            this.dgv_DrawImageInfo = new System.Windows.Forms.DataGridView();
            this.COL_ImageXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ImageIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ImageLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ImageLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ImageTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_EidtImage = new System.Windows.Forms.Button();
            this.btn_DeleteImage = new System.Windows.Forms.Button();
            this.btn_HandToAddImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ImageTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ImagePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ImageLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ImageLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddImageCencel = new System.Windows.Forms.Button();
            this.btn_AddImageOK = new System.Windows.Forms.Button();
            this.txt_ImageIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawImageInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DrawImageInfo
            // 
            this.dgv_DrawImageInfo.AllowUserToAddRows = false;
            this.dgv_DrawImageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawImageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_ImageXvHao,
            this.COL_ImageIndex,
            this.COL_ImageLong,
            this.COL_ImageLat,
            this.COL_ImageTag,
            this.COL_ImagePath});
            this.dgv_DrawImageInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawImageInfo.Name = "dgv_DrawImageInfo";
            this.dgv_DrawImageInfo.ReadOnly = true;
            this.dgv_DrawImageInfo.RowHeadersVisible = false;
            this.dgv_DrawImageInfo.RowTemplate.Height = 23;
            this.dgv_DrawImageInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawImageInfo.Size = new System.Drawing.Size(708, 327);
            this.dgv_DrawImageInfo.TabIndex = 0;
            this.dgv_DrawImageInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawImageInfo_CellClick);
            // 
            // COL_ImageXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_ImageXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_ImageXvHao.HeaderText = "序号";
            this.COL_ImageXvHao.Name = "COL_ImageXvHao";
            this.COL_ImageXvHao.ReadOnly = true;
            this.COL_ImageXvHao.Width = 60;
            // 
            // COL_ImageIndex
            // 
            this.COL_ImageIndex.HeaderText = "图标ID";
            this.COL_ImageIndex.Name = "COL_ImageIndex";
            this.COL_ImageIndex.ReadOnly = true;
            // 
            // COL_ImageLong
            // 
            this.COL_ImageLong.HeaderText = "经度";
            this.COL_ImageLong.Name = "COL_ImageLong";
            this.COL_ImageLong.ReadOnly = true;
            this.COL_ImageLong.Width = 120;
            // 
            // COL_ImageLat
            // 
            this.COL_ImageLat.HeaderText = "纬度";
            this.COL_ImageLat.Name = "COL_ImageLat";
            this.COL_ImageLat.ReadOnly = true;
            this.COL_ImageLat.Width = 120;
            // 
            // COL_ImageTag
            // 
            this.COL_ImageTag.HeaderText = "贴图备注";
            this.COL_ImageTag.Name = "COL_ImageTag";
            this.COL_ImageTag.ReadOnly = true;
            // 
            // COL_ImagePath
            // 
            this.COL_ImagePath.HeaderText = "图标路径";
            this.COL_ImagePath.Name = "COL_ImagePath";
            this.COL_ImagePath.ReadOnly = true;
            this.COL_ImagePath.Width = 200;
            // 
            // btn_EidtImage
            // 
            this.btn_EidtImage.Location = new System.Drawing.Point(174, 7);
            this.btn_EidtImage.Name = "btn_EidtImage";
            this.btn_EidtImage.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtImage.TabIndex = 3;
            this.btn_EidtImage.Text = "修改贴图";
            this.btn_EidtImage.UseVisualStyleBackColor = true;
            this.btn_EidtImage.Click += new System.EventHandler(this.btn_EidtImage_Click);
            // 
            // btn_DeleteImage
            // 
            this.btn_DeleteImage.Location = new System.Drawing.Point(93, 7);
            this.btn_DeleteImage.Name = "btn_DeleteImage";
            this.btn_DeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteImage.TabIndex = 4;
            this.btn_DeleteImage.Text = "删除贴图";
            this.btn_DeleteImage.UseVisualStyleBackColor = true;
            this.btn_DeleteImage.Click += new System.EventHandler(this.btn_DeleteImage_Click);
            // 
            // btn_HandToAddImage
            // 
            this.btn_HandToAddImage.Location = new System.Drawing.Point(12, 7);
            this.btn_HandToAddImage.Name = "btn_HandToAddImage";
            this.btn_HandToAddImage.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddImage.TabIndex = 5;
            this.btn_HandToAddImage.Text = "添加贴图";
            this.btn_HandToAddImage.UseVisualStyleBackColor = true;
            this.btn_HandToAddImage.Click += new System.EventHandler(this.btn_HandToAddImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txt_ImageTag);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_SelectImage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_ImagePath);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_ImageLat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ImageLong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_AddImageCencel);
            this.panel1.Controls.Add(this.btn_AddImageOK);
            this.panel1.Controls.Add(this.txt_ImageIndex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(707, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 327);
            this.panel1.TabIndex = 2;
            // 
            // txt_ImageTag
            // 
            this.txt_ImageTag.Enabled = false;
            this.txt_ImageTag.Location = new System.Drawing.Point(119, 182);
            this.txt_ImageTag.Name = "txt_ImageTag";
            this.txt_ImageTag.Size = new System.Drawing.Size(157, 21);
            this.txt_ImageTag.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "贴图纬度：";
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.Enabled = false;
            this.btn_SelectImage.Location = new System.Drawing.Point(281, 230);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(69, 23);
            this.btn_SelectImage.TabIndex = 6;
            this.btn_SelectImage.Text = "选取图片";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "点位信息";
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Enabled = false;
            this.txt_ImagePath.Location = new System.Drawing.Point(119, 230);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Size = new System.Drawing.Size(157, 21);
            this.txt_ImagePath.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "贴图路径：";
            // 
            // txt_ImageLat
            // 
            this.txt_ImageLat.Enabled = false;
            this.txt_ImageLat.Location = new System.Drawing.Point(119, 134);
            this.txt_ImageLat.Name = "txt_ImageLat";
            this.txt_ImageLat.Size = new System.Drawing.Size(157, 21);
            this.txt_ImageLat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "贴图备注：";
            // 
            // txt_ImageLong
            // 
            this.txt_ImageLong.Enabled = false;
            this.txt_ImageLong.Location = new System.Drawing.Point(119, 86);
            this.txt_ImageLong.Name = "txt_ImageLong";
            this.txt_ImageLong.Size = new System.Drawing.Size(157, 21);
            this.txt_ImageLong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "贴图经度：";
            // 
            // btn_AddImageCencel
            // 
            this.btn_AddImageCencel.Enabled = false;
            this.btn_AddImageCencel.Location = new System.Drawing.Point(191, 272);
            this.btn_AddImageCencel.Name = "btn_AddImageCencel";
            this.btn_AddImageCencel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddImageCencel.TabIndex = 8;
            this.btn_AddImageCencel.Text = "取消";
            this.btn_AddImageCencel.UseVisualStyleBackColor = true;
            this.btn_AddImageCencel.Click += new System.EventHandler(this.btn_AddImageCencel_Click);
            // 
            // btn_AddImageOK
            // 
            this.btn_AddImageOK.Enabled = false;
            this.btn_AddImageOK.Location = new System.Drawing.Point(92, 272);
            this.btn_AddImageOK.Name = "btn_AddImageOK";
            this.btn_AddImageOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AddImageOK.TabIndex = 7;
            this.btn_AddImageOK.Text = "确定";
            this.btn_AddImageOK.UseVisualStyleBackColor = true;
            this.btn_AddImageOK.Click += new System.EventHandler(this.btn_AddImageOK_Click);
            // 
            // txt_ImageIndex
            // 
            this.txt_ImageIndex.Enabled = false;
            this.txt_ImageIndex.Location = new System.Drawing.Point(119, 38);
            this.txt_ImageIndex.Name = "txt_ImageIndex";
            this.txt_ImageIndex.Size = new System.Drawing.Size(157, 21);
            this.txt_ImageIndex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "贴图ID：";
            // 
            // fr_DrawImageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HandToAddImage);
            this.Controls.Add(this.btn_DeleteImage);
            this.Controls.Add(this.btn_EidtImage);
            this.Controls.Add(this.dgv_DrawImageInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_DrawImageInfo";
            this.Text = "绘制图片";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawImageInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawImageInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox txt_ImageTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ImagePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ImageLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ImageLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddImageCencel;
        private System.Windows.Forms.Button btn_AddImageOK;
        private System.Windows.Forms.TextBox txt_ImageIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HandToAddImage;
        private System.Windows.Forms.Button btn_DeleteImage;
        private System.Windows.Forms.Button btn_EidtImage;
        public System.Windows.Forms.DataGridView dgv_DrawImageInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImageXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImageIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImageLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImageLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImageTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ImagePath;
    }
}