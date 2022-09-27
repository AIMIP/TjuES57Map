namespace TjuES57Demo.Forms.Forms
{
    partial class fr_Ranging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Ranging));
            this.dgv_DrawRangingInfo = new System.Windows.Forms.DataGridView();
            this.COL_RangingLineXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_RangingPointXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_RangingPointLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_RangingPointLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_JuLiKiloMetre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_JuLinauticalMile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AllJuLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_OpenRanging = new System.Windows.Forms.Button();
            this.btn_DeleteRanging = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btn_HandToAddPoint = new System.Windows.Forms.Button();
            this.btn_EidtPoint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RangingCancle = new System.Windows.Forms.Button();
            this.btn_RangingOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RangingLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RangingLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RangingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawRangingInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DrawRangingInfo
            // 
            this.dgv_DrawRangingInfo.AllowUserToAddRows = false;
            this.dgv_DrawRangingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawRangingInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_RangingLineXvHao,
            this.COL_RangingPointXvHao,
            this.COL_RangingPointLong,
            this.COL_RangingPointLat,
            this.COL_JuLiKiloMetre,
            this.COL_JuLinauticalMile,
            this.COL_AllJuLi});
            this.dgv_DrawRangingInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawRangingInfo.Name = "dgv_DrawRangingInfo";
            this.dgv_DrawRangingInfo.RowHeadersVisible = false;
            this.dgv_DrawRangingInfo.RowTemplate.Height = 23;
            this.dgv_DrawRangingInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawRangingInfo.Size = new System.Drawing.Size(828, 361);
            this.dgv_DrawRangingInfo.TabIndex = 0;
            this.dgv_DrawRangingInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawRangingInfo_CellClick);
            // 
            // COL_RangingLineXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_RangingLineXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_RangingLineXvHao.HeaderText = "测距线ID";
            this.COL_RangingLineXvHao.Name = "COL_RangingLineXvHao";
            this.COL_RangingLineXvHao.Width = 120;
            // 
            // COL_RangingPointXvHao
            // 
            this.COL_RangingPointXvHao.HeaderText = "测距点序号";
            this.COL_RangingPointXvHao.Name = "COL_RangingPointXvHao";
            // 
            // COL_RangingPointLong
            // 
            this.COL_RangingPointLong.HeaderText = "测距点位经度";
            this.COL_RangingPointLong.Name = "COL_RangingPointLong";
            this.COL_RangingPointLong.Width = 120;
            // 
            // COL_RangingPointLat
            // 
            this.COL_RangingPointLat.HeaderText = "测距点位纬度";
            this.COL_RangingPointLat.Name = "COL_RangingPointLat";
            this.COL_RangingPointLat.Width = 120;
            // 
            // COL_JuLiKiloMetre
            // 
            this.COL_JuLiKiloMetre.HeaderText = "距离（公里）";
            this.COL_JuLiKiloMetre.Name = "COL_JuLiKiloMetre";
            this.COL_JuLiKiloMetre.Width = 120;
            // 
            // COL_JuLinauticalMile
            // 
            this.COL_JuLinauticalMile.HeaderText = "距离（海里）";
            this.COL_JuLinauticalMile.Name = "COL_JuLinauticalMile";
            this.COL_JuLinauticalMile.Width = 120;
            // 
            // COL_AllJuLi
            // 
            this.COL_AllJuLi.HeaderText = "总距离（公里）";
            this.COL_AllJuLi.Name = "COL_AllJuLi";
            this.COL_AllJuLi.Width = 120;
            // 
            // btn_OpenRanging
            // 
            this.btn_OpenRanging.Location = new System.Drawing.Point(12, 7);
            this.btn_OpenRanging.Name = "btn_OpenRanging";
            this.btn_OpenRanging.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenRanging.TabIndex = 1;
            this.btn_OpenRanging.Text = "点选测距";
            this.btn_OpenRanging.UseVisualStyleBackColor = true;
            this.btn_OpenRanging.Click += new System.EventHandler(this.btn_DianXuanRanging_Click);
            // 
            // btn_DeleteRanging
            // 
            this.btn_DeleteRanging.Location = new System.Drawing.Point(255, 7);
            this.btn_DeleteRanging.Name = "btn_DeleteRanging";
            this.btn_DeleteRanging.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteRanging.TabIndex = 4;
            this.btn_DeleteRanging.Text = "清除测距";
            this.btn_DeleteRanging.UseVisualStyleBackColor = true;
            this.btn_DeleteRanging.Click += new System.EventHandler(this.btn_DeleteRanging_Click);
            // 
            // btn_HandToAddPoint
            // 
            this.btn_HandToAddPoint.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddPoint.Name = "btn_HandToAddPoint";
            this.btn_HandToAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddPoint.TabIndex = 6;
            this.btn_HandToAddPoint.Text = "手动添加";
            this.btn_HandToAddPoint.UseVisualStyleBackColor = true;
            this.btn_HandToAddPoint.Click += new System.EventHandler(this.btn_HandToAddPoint_Click);
            // 
            // btn_EidtPoint
            // 
            this.btn_EidtPoint.Location = new System.Drawing.Point(174, 7);
            this.btn_EidtPoint.Name = "btn_EidtPoint";
            this.btn_EidtPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtPoint.TabIndex = 7;
            this.btn_EidtPoint.Text = "修改测距点";
            this.btn_EidtPoint.UseVisualStyleBackColor = true;
            this.btn_EidtPoint.Click += new System.EventHandler(this.btn_EidtPoint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_RangingCancle);
            this.panel1.Controls.Add(this.btn_RangingOK);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_RangingLat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_RangingLong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_RangingID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(827, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 361);
            this.panel1.TabIndex = 8;
            // 
            // btn_RangingCancle
            // 
            this.btn_RangingCancle.Enabled = false;
            this.btn_RangingCancle.Location = new System.Drawing.Point(176, 248);
            this.btn_RangingCancle.Name = "btn_RangingCancle";
            this.btn_RangingCancle.Size = new System.Drawing.Size(75, 23);
            this.btn_RangingCancle.TabIndex = 18;
            this.btn_RangingCancle.Text = "取消";
            this.btn_RangingCancle.UseVisualStyleBackColor = true;
            this.btn_RangingCancle.Click += new System.EventHandler(this.btn_RangingCancle_Click);
            // 
            // btn_RangingOK
            // 
            this.btn_RangingOK.Enabled = false;
            this.btn_RangingOK.Location = new System.Drawing.Point(77, 248);
            this.btn_RangingOK.Name = "btn_RangingOK";
            this.btn_RangingOK.Size = new System.Drawing.Size(75, 23);
            this.btn_RangingOK.TabIndex = 17;
            this.btn_RangingOK.Text = "确定";
            this.btn_RangingOK.UseVisualStyleBackColor = true;
            this.btn_RangingOK.Click += new System.EventHandler(this.btn_RangingOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "测距线信息";
            // 
            // txt_RangingLat
            // 
            this.txt_RangingLat.Enabled = false;
            this.txt_RangingLat.Location = new System.Drawing.Point(140, 175);
            this.txt_RangingLat.Name = "txt_RangingLat";
            this.txt_RangingLat.Size = new System.Drawing.Size(126, 21);
            this.txt_RangingLat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "测距点位纬度：";
            // 
            // txt_RangingLong
            // 
            this.txt_RangingLong.Enabled = false;
            this.txt_RangingLong.Location = new System.Drawing.Point(140, 132);
            this.txt_RangingLong.Name = "txt_RangingLong";
            this.txt_RangingLong.Size = new System.Drawing.Size(126, 21);
            this.txt_RangingLong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "测距点位经度：";
            // 
            // txt_RangingID
            // 
            this.txt_RangingID.Enabled = false;
            this.txt_RangingID.Location = new System.Drawing.Point(140, 89);
            this.txt_RangingID.Name = "txt_RangingID";
            this.txt_RangingID.Size = new System.Drawing.Size(126, 21);
            this.txt_RangingID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "测距线ID：";
            // 
            // fr_Ranging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EidtPoint);
            this.Controls.Add(this.btn_HandToAddPoint);
            this.Controls.Add(this.btn_DeleteRanging);
            this.Controls.Add(this.btn_OpenRanging);
            this.Controls.Add(this.dgv_DrawRangingInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_Ranging";
            this.Text = "测量距离";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawRanging_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawRangingInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_DrawRangingInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_RangingLineXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_RangingPointXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_RangingPointLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_RangingPointLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_JuLiKiloMetre;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_JuLinauticalMile;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AllJuLi;
        private System.Windows.Forms.Button btn_DeleteRanging;
        private System.Windows.Forms.Button btn_OpenRanging;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btn_HandToAddPoint;
        private System.Windows.Forms.Button btn_EidtPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RangingLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RangingLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RangingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RangingCancle;
        private System.Windows.Forms.Button btn_RangingOK;
    }
}