namespace TjuES57Demo.Forms.Forms
{
    partial class fr_DrawPointInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DrawPointInfo));
            this.dgv_DrawPointInfo = new System.Windows.Forms.DataGridView();
            this.COL_PointXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PointID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PointLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PointLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PointTextInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PointTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DianXuanPoint = new System.Windows.Forms.Button();
            this.btn_EidtPoint = new System.Windows.Forms.Button();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.btn_HandToAddPoint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PointTextColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PointTextSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PointText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PointLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PointLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddPointCencel = new System.Windows.Forms.Button();
            this.btn_AddPointOK = new System.Windows.Forms.Button();
            this.txt_PointID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawPointInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DrawPointInfo
            // 
            this.dgv_DrawPointInfo.AllowUserToAddRows = false;
            this.dgv_DrawPointInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawPointInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_PointXvHao,
            this.COL_PointID,
            this.COL_PointLong,
            this.COL_PointLat,
            this.COL_PointTextInfo,
            this.COL_TextSize,
            this.COL_PointTextColor});
            this.dgv_DrawPointInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawPointInfo.Name = "dgv_DrawPointInfo";
            this.dgv_DrawPointInfo.ReadOnly = true;
            this.dgv_DrawPointInfo.RowHeadersVisible = false;
            this.dgv_DrawPointInfo.RowTemplate.Height = 23;
            this.dgv_DrawPointInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawPointInfo.Size = new System.Drawing.Size(686, 327);
            this.dgv_DrawPointInfo.TabIndex = 0;
            this.dgv_DrawPointInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawPointInfo_CellClick);
            // 
            // COL_PointXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_PointXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_PointXvHao.HeaderText = "序号";
            this.COL_PointXvHao.Name = "COL_PointXvHao";
            this.COL_PointXvHao.ReadOnly = true;
            this.COL_PointXvHao.Width = 60;
            // 
            // COL_PointID
            // 
            this.COL_PointID.HeaderText = "点位ID";
            this.COL_PointID.Name = "COL_PointID";
            this.COL_PointID.ReadOnly = true;
            // 
            // COL_PointLong
            // 
            this.COL_PointLong.HeaderText = "经度";
            this.COL_PointLong.Name = "COL_PointLong";
            this.COL_PointLong.ReadOnly = true;
            this.COL_PointLong.Width = 120;
            // 
            // COL_PointLat
            // 
            this.COL_PointLat.HeaderText = "纬度";
            this.COL_PointLat.Name = "COL_PointLat";
            this.COL_PointLat.ReadOnly = true;
            this.COL_PointLat.Width = 120;
            // 
            // COL_PointTextInfo
            // 
            this.COL_PointTextInfo.HeaderText = "文字标注";
            this.COL_PointTextInfo.Name = "COL_PointTextInfo";
            this.COL_PointTextInfo.ReadOnly = true;
            this.COL_PointTextInfo.Width = 120;
            // 
            // COL_TextSize
            // 
            this.COL_TextSize.HeaderText = "标注字号";
            this.COL_TextSize.Name = "COL_TextSize";
            this.COL_TextSize.ReadOnly = true;
            this.COL_TextSize.Width = 80;
            // 
            // COL_PointTextColor
            // 
            this.COL_PointTextColor.HeaderText = "标注颜色";
            this.COL_PointTextColor.Name = "COL_PointTextColor";
            this.COL_PointTextColor.ReadOnly = true;
            this.COL_PointTextColor.Width = 80;
            // 
            // btn_DianXuanPoint
            // 
            this.btn_DianXuanPoint.Location = new System.Drawing.Point(12, 7);
            this.btn_DianXuanPoint.Name = "btn_DianXuanPoint";
            this.btn_DianXuanPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_DianXuanPoint.TabIndex = 1;
            this.btn_DianXuanPoint.Text = "点选添加";
            this.btn_DianXuanPoint.UseVisualStyleBackColor = true;
            this.btn_DianXuanPoint.Click += new System.EventHandler(this.btn_DianXuanPoint_Click);
            // 
            // btn_EidtPoint
            // 
            this.btn_EidtPoint.Location = new System.Drawing.Point(255, 7);
            this.btn_EidtPoint.Name = "btn_EidtPoint";
            this.btn_EidtPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtPoint.TabIndex = 3;
            this.btn_EidtPoint.Text = "修改点位";
            this.btn_EidtPoint.UseVisualStyleBackColor = true;
            this.btn_EidtPoint.Click += new System.EventHandler(this.btn_EidtPoint_Click);
            // 
            // btn_DeletePoint
            // 
            this.btn_DeletePoint.Location = new System.Drawing.Point(174, 7);
            this.btn_DeletePoint.Name = "btn_DeletePoint";
            this.btn_DeletePoint.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePoint.TabIndex = 4;
            this.btn_DeletePoint.Text = "删除点位";
            this.btn_DeletePoint.UseVisualStyleBackColor = true;
            this.btn_DeletePoint.Click += new System.EventHandler(this.btn_DeletePoint_Click);
            // 
            // btn_HandToAddPoint
            // 
            this.btn_HandToAddPoint.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddPoint.Name = "btn_HandToAddPoint";
            this.btn_HandToAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddPoint.TabIndex = 5;
            this.btn_HandToAddPoint.Text = "手动添加";
            this.btn_HandToAddPoint.UseVisualStyleBackColor = true;
            this.btn_HandToAddPoint.Click += new System.EventHandler(this.btn_HandToAddPoint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_PointTextColor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_PointTextSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_PointText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_PointLat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_PointLong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_AddPointCencel);
            this.panel1.Controls.Add(this.btn_AddPointOK);
            this.panel1.Controls.Add(this.txt_PointID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(685, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 327);
            this.panel1.TabIndex = 2;
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
            // txt_PointTextColor
            // 
            this.txt_PointTextColor.Enabled = false;
            this.txt_PointTextColor.Location = new System.Drawing.Point(130, 216);
            this.txt_PointTextColor.Name = "txt_PointTextColor";
            this.txt_PointTextColor.Size = new System.Drawing.Size(126, 21);
            this.txt_PointTextColor.TabIndex = 11;
            this.txt_PointTextColor.Click += new System.EventHandler(this.txt_PointTextColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "标注颜色：";
            // 
            // txt_PointTextSize
            // 
            this.txt_PointTextSize.Enabled = false;
            this.txt_PointTextSize.Location = new System.Drawing.Point(130, 184);
            this.txt_PointTextSize.Name = "txt_PointTextSize";
            this.txt_PointTextSize.Size = new System.Drawing.Size(126, 21);
            this.txt_PointTextSize.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "标注字号：";
            // 
            // txt_PointText
            // 
            this.txt_PointText.Enabled = false;
            this.txt_PointText.Location = new System.Drawing.Point(130, 152);
            this.txt_PointText.Name = "txt_PointText";
            this.txt_PointText.Size = new System.Drawing.Size(126, 21);
            this.txt_PointText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "点位标注：";
            // 
            // txt_PointLat
            // 
            this.txt_PointLat.Enabled = false;
            this.txt_PointLat.Location = new System.Drawing.Point(130, 120);
            this.txt_PointLat.Name = "txt_PointLat";
            this.txt_PointLat.Size = new System.Drawing.Size(126, 21);
            this.txt_PointLat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "点位纬度：";
            // 
            // txt_PointLong
            // 
            this.txt_PointLong.Enabled = false;
            this.txt_PointLong.Location = new System.Drawing.Point(130, 88);
            this.txt_PointLong.Name = "txt_PointLong";
            this.txt_PointLong.Size = new System.Drawing.Size(126, 21);
            this.txt_PointLong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "点位经度：";
            // 
            // btn_AddPointCencel
            // 
            this.btn_AddPointCencel.Enabled = false;
            this.btn_AddPointCencel.Location = new System.Drawing.Point(168, 272);
            this.btn_AddPointCencel.Name = "btn_AddPointCencel";
            this.btn_AddPointCencel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPointCencel.TabIndex = 15;
            this.btn_AddPointCencel.Text = "取消";
            this.btn_AddPointCencel.UseVisualStyleBackColor = true;
            this.btn_AddPointCencel.Click += new System.EventHandler(this.btn_AddPointCencel_Click);
            // 
            // btn_AddPointOK
            // 
            this.btn_AddPointOK.Enabled = false;
            this.btn_AddPointOK.Location = new System.Drawing.Point(69, 272);
            this.btn_AddPointOK.Name = "btn_AddPointOK";
            this.btn_AddPointOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPointOK.TabIndex = 14;
            this.btn_AddPointOK.Text = "确定";
            this.btn_AddPointOK.UseVisualStyleBackColor = true;
            this.btn_AddPointOK.Click += new System.EventHandler(this.btn_AddPointOK_Click);
            // 
            // txt_PointID
            // 
            this.txt_PointID.Enabled = false;
            this.txt_PointID.Location = new System.Drawing.Point(130, 56);
            this.txt_PointID.Name = "txt_PointID";
            this.txt_PointID.Size = new System.Drawing.Size(126, 21);
            this.txt_PointID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "点位ID：";
            // 
            // fr_DrawPointInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HandToAddPoint);
            this.Controls.Add(this.btn_DeletePoint);
            this.Controls.Add(this.btn_EidtPoint);
            this.Controls.Add(this.btn_DianXuanPoint);
            this.Controls.Add(this.dgv_DrawPointInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_DrawPointInfo";
            this.Text = "绘制点位";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawPointInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawPointInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_PointTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PointTextSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PointText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PointLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PointLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddPointCencel;
        private System.Windows.Forms.Button btn_AddPointOK;
        private System.Windows.Forms.TextBox txt_PointID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HandToAddPoint;
        private System.Windows.Forms.Button btn_DeletePoint;
        private System.Windows.Forms.Button btn_EidtPoint;
        private System.Windows.Forms.Button btn_DianXuanPoint;
        public System.Windows.Forms.DataGridView dgv_DrawPointInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointTextInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PointTextColor;
    }
}