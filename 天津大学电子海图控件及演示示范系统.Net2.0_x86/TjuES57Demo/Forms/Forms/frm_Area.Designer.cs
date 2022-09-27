namespace TjuES57Demo.Forms.Forms
{
    partial class fr_Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Area));
            this.dgv_DrawAreaInfo = new System.Windows.Forms.DataGridView();
            this.COL_AreaLineXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AreaPointXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AreaPointLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AreaPointLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AreaKiloMetres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AreanauticalMile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_OpenArea = new System.Windows.Forms.Button();
            this.btn_DeleteArea = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AreaCancle = new System.Windows.Forms.Button();
            this.btn_AreaOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_AreaLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AreaLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AreaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HandToAddPoint = new System.Windows.Forms.Button();
            this.btn_EidtPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawAreaInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DrawAreaInfo
            // 
            this.dgv_DrawAreaInfo.AllowUserToAddRows = false;
            this.dgv_DrawAreaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawAreaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_AreaLineXvHao,
            this.COL_AreaPointXvHao,
            this.COL_AreaPointLong,
            this.COL_AreaPointLat,
            this.COL_AreaKiloMetres,
            this.COL_AreanauticalMile});
            this.dgv_DrawAreaInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawAreaInfo.Name = "dgv_DrawAreaInfo";
            this.dgv_DrawAreaInfo.RowHeadersVisible = false;
            this.dgv_DrawAreaInfo.RowTemplate.Height = 23;
            this.dgv_DrawAreaInfo.Size = new System.Drawing.Size(705, 361);
            this.dgv_DrawAreaInfo.TabIndex = 0;
            this.dgv_DrawAreaInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawAreaInfo_CellClick);
            // 
            // COL_AreaLineXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_AreaLineXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_AreaLineXvHao.HeaderText = "测面积ID";
            this.COL_AreaLineXvHao.Name = "COL_AreaLineXvHao";
            this.COL_AreaLineXvHao.Width = 120;
            // 
            // COL_AreaPointXvHao
            // 
            this.COL_AreaPointXvHao.HeaderText = "测面积点序号";
            this.COL_AreaPointXvHao.Name = "COL_AreaPointXvHao";
            // 
            // COL_AreaPointLong
            // 
            this.COL_AreaPointLong.HeaderText = "测面积点位经度";
            this.COL_AreaPointLong.Name = "COL_AreaPointLong";
            this.COL_AreaPointLong.Width = 120;
            // 
            // COL_AreaPointLat
            // 
            this.COL_AreaPointLat.HeaderText = "测面积点位纬度";
            this.COL_AreaPointLat.Name = "COL_AreaPointLat";
            this.COL_AreaPointLat.Width = 120;
            // 
            // COL_AreaKiloMetres
            // 
            this.COL_AreaKiloMetres.HeaderText = "面积(平方公里)";
            this.COL_AreaKiloMetres.Name = "COL_AreaKiloMetres";
            this.COL_AreaKiloMetres.Width = 120;
            // 
            // COL_AreanauticalMile
            // 
            this.COL_AreanauticalMile.HeaderText = "面积(平方海里)";
            this.COL_AreanauticalMile.Name = "COL_AreanauticalMile";
            this.COL_AreanauticalMile.Width = 120;
            // 
            // btn_OpenArea
            // 
            this.btn_OpenArea.Location = new System.Drawing.Point(12, 7);
            this.btn_OpenArea.Name = "btn_OpenArea";
            this.btn_OpenArea.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenArea.TabIndex = 1;
            this.btn_OpenArea.Text = "点选测面积";
            this.btn_OpenArea.UseVisualStyleBackColor = true;
            this.btn_OpenArea.Click += new System.EventHandler(this.btn_DianXuanLine_Click);
            // 
            // btn_DeleteArea
            // 
            this.btn_DeleteArea.Location = new System.Drawing.Point(255, 7);
            this.btn_DeleteArea.Name = "btn_DeleteArea";
            this.btn_DeleteArea.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteArea.TabIndex = 4;
            this.btn_DeleteArea.Text = "清除测面积";
            this.btn_DeleteArea.UseVisualStyleBackColor = true;
            this.btn_DeleteArea.Click += new System.EventHandler(this.btn_DeleteRanging_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_AreaCancle);
            this.panel1.Controls.Add(this.btn_AreaOK);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_AreaLat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_AreaLong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_AreaID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(704, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 361);
            this.panel1.TabIndex = 9;
            // 
            // btn_AreaCancle
            // 
            this.btn_AreaCancle.Enabled = false;
            this.btn_AreaCancle.Location = new System.Drawing.Point(176, 248);
            this.btn_AreaCancle.Name = "btn_AreaCancle";
            this.btn_AreaCancle.Size = new System.Drawing.Size(75, 23);
            this.btn_AreaCancle.TabIndex = 18;
            this.btn_AreaCancle.Text = "取消";
            this.btn_AreaCancle.UseVisualStyleBackColor = true;
            this.btn_AreaCancle.Click += new System.EventHandler(this.btn_AreaCancle_Click);
            // 
            // btn_AreaOK
            // 
            this.btn_AreaOK.Enabled = false;
            this.btn_AreaOK.Location = new System.Drawing.Point(77, 248);
            this.btn_AreaOK.Name = "btn_AreaOK";
            this.btn_AreaOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AreaOK.TabIndex = 17;
            this.btn_AreaOK.Text = "确定";
            this.btn_AreaOK.UseVisualStyleBackColor = true;
            this.btn_AreaOK.Click += new System.EventHandler(this.btn_AreaOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "测面积信息";
            // 
            // txt_AreaLat
            // 
            this.txt_AreaLat.Enabled = false;
            this.txt_AreaLat.Location = new System.Drawing.Point(140, 175);
            this.txt_AreaLat.Name = "txt_AreaLat";
            this.txt_AreaLat.Size = new System.Drawing.Size(126, 21);
            this.txt_AreaLat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "测面积点位纬度：";
            // 
            // txt_AreaLong
            // 
            this.txt_AreaLong.Enabled = false;
            this.txt_AreaLong.Location = new System.Drawing.Point(140, 132);
            this.txt_AreaLong.Name = "txt_AreaLong";
            this.txt_AreaLong.Size = new System.Drawing.Size(126, 21);
            this.txt_AreaLong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "测面积点位经度：";
            // 
            // txt_AreaID
            // 
            this.txt_AreaID.Enabled = false;
            this.txt_AreaID.Location = new System.Drawing.Point(140, 89);
            this.txt_AreaID.Name = "txt_AreaID";
            this.txt_AreaID.Size = new System.Drawing.Size(126, 21);
            this.txt_AreaID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "测面积ID：";
            // 
            // btn_HandToAddPoint
            // 
            this.btn_HandToAddPoint.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddPoint.Name = "btn_HandToAddPoint";
            this.btn_HandToAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddPoint.TabIndex = 10;
            this.btn_HandToAddPoint.Text = "手动添加";
            this.btn_HandToAddPoint.UseVisualStyleBackColor = true;
            this.btn_HandToAddPoint.Click += new System.EventHandler(this.btn_HandToAddPoint_Click);
            // 
            // btn_EidtPoint
            // 
            this.btn_EidtPoint.Location = new System.Drawing.Point(174, 7);
            this.btn_EidtPoint.Name = "btn_EidtPoint";
            this.btn_EidtPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtPoint.TabIndex = 11;
            this.btn_EidtPoint.Text = "修改测距点";
            this.btn_EidtPoint.UseVisualStyleBackColor = true;
            this.btn_EidtPoint.Click += new System.EventHandler(this.btn_EidtPoint_Click);
            // 
            // fr_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 397);
            this.Controls.Add(this.btn_EidtPoint);
            this.Controls.Add(this.btn_HandToAddPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DeleteArea);
            this.Controls.Add(this.btn_OpenArea);
            this.Controls.Add(this.dgv_DrawAreaInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_Area";
            this.Text = "测量面积";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawAreaInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawAreaInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_DrawAreaInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreaLineXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreaPointXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreaPointLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreaPointLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreaKiloMetres;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AreanauticalMile;
        private System.Windows.Forms.Button btn_DeleteArea;
        private System.Windows.Forms.Button btn_OpenArea;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AreaCancle;
        private System.Windows.Forms.Button btn_AreaOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_AreaLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AreaLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AreaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HandToAddPoint;
        private System.Windows.Forms.Button btn_EidtPoint;
    }
}