namespace TjuES57Demo.Forms.Forms
{
    partial class fr_DrawLineInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DrawLineInfo));
            this.dgv_DrawLineInfo = new System.Windows.Forms.DataGridView();
            this.COL_LineXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LinePointsInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineTextInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineTextSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LineTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_IsShowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DianXuanLine = new System.Windows.Forms.Button();
            this.btn_EidtLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.btn_HandToAddLine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.chk_ShowLineNumber = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_LinePointsInfo = new System.Windows.Forms.DataGridView();
            this.COL_LinePointXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LinePointLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_LinePointLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_LineTextColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LineTextSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LineText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LineWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LineColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddLineCencel = new System.Windows.Forms.Button();
            this.btn_AddLineOK = new System.Windows.Forms.Button();
            this.txt_LineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawLineInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LinePointsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DrawLineInfo
            // 
            this.dgv_DrawLineInfo.AllowUserToAddRows = false;
            this.dgv_DrawLineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawLineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_LineXvHao,
            this.COL_LineID,
            this.COL_LinePointsInfo,
            this.COL_LineColor,
            this.COL_LineWidth,
            this.COL_LineTextInfo,
            this.COL_LineTextSize,
            this.COL_LineTextColor,
            this.COL_IsShowNumber});
            this.dgv_DrawLineInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawLineInfo.Name = "dgv_DrawLineInfo";
            this.dgv_DrawLineInfo.ReadOnly = true;
            this.dgv_DrawLineInfo.RowHeadersVisible = false;
            this.dgv_DrawLineInfo.RowTemplate.Height = 23;
            this.dgv_DrawLineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawLineInfo.Size = new System.Drawing.Size(909, 465);
            this.dgv_DrawLineInfo.TabIndex = 0;
            this.dgv_DrawLineInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawLineInfo_CellClick);
            // 
            // COL_LineXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_LineXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_LineXvHao.HeaderText = "序号";
            this.COL_LineXvHao.Name = "COL_LineXvHao";
            this.COL_LineXvHao.ReadOnly = true;
            this.COL_LineXvHao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LineXvHao.Width = 60;
            // 
            // COL_LineID
            // 
            this.COL_LineID.HeaderText = "折线ID";
            this.COL_LineID.Name = "COL_LineID";
            this.COL_LineID.ReadOnly = true;
            this.COL_LineID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // COL_LinePointsInfo
            // 
            this.COL_LinePointsInfo.HeaderText = "折线点位";
            this.COL_LinePointsInfo.Name = "COL_LinePointsInfo";
            this.COL_LinePointsInfo.ReadOnly = true;
            this.COL_LinePointsInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LinePointsInfo.Width = 240;
            // 
            // COL_LineColor
            // 
            this.COL_LineColor.HeaderText = "折线颜色";
            this.COL_LineColor.Name = "COL_LineColor";
            this.COL_LineColor.ReadOnly = true;
            this.COL_LineColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LineColor.Width = 80;
            // 
            // COL_LineWidth
            // 
            this.COL_LineWidth.HeaderText = "折线宽度";
            this.COL_LineWidth.Name = "COL_LineWidth";
            this.COL_LineWidth.ReadOnly = true;
            this.COL_LineWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LineWidth.Width = 80;
            // 
            // COL_LineTextInfo
            // 
            this.COL_LineTextInfo.HeaderText = "文字标注";
            this.COL_LineTextInfo.Name = "COL_LineTextInfo";
            this.COL_LineTextInfo.ReadOnly = true;
            this.COL_LineTextInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // COL_LineTextSize
            // 
            this.COL_LineTextSize.HeaderText = "标注字号";
            this.COL_LineTextSize.Name = "COL_LineTextSize";
            this.COL_LineTextSize.ReadOnly = true;
            this.COL_LineTextSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LineTextSize.Width = 80;
            // 
            // COL_LineTextColor
            // 
            this.COL_LineTextColor.HeaderText = "标注颜色";
            this.COL_LineTextColor.Name = "COL_LineTextColor";
            this.COL_LineTextColor.ReadOnly = true;
            this.COL_LineTextColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_LineTextColor.Width = 80;
            // 
            // COL_IsShowNumber
            // 
            this.COL_IsShowNumber.HeaderText = "显示序号";
            this.COL_IsShowNumber.Name = "COL_IsShowNumber";
            this.COL_IsShowNumber.ReadOnly = true;
            this.COL_IsShowNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COL_IsShowNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_IsShowNumber.Width = 80;
            // 
            // btn_DianXuanLine
            // 
            this.btn_DianXuanLine.Location = new System.Drawing.Point(12, 7);
            this.btn_DianXuanLine.Name = "btn_DianXuanLine";
            this.btn_DianXuanLine.Size = new System.Drawing.Size(75, 23);
            this.btn_DianXuanLine.TabIndex = 1;
            this.btn_DianXuanLine.Text = "点选添加";
            this.btn_DianXuanLine.UseVisualStyleBackColor = true;
            this.btn_DianXuanLine.Click += new System.EventHandler(this.btn_DianXuanLine_Click);
            // 
            // btn_EidtLine
            // 
            this.btn_EidtLine.Location = new System.Drawing.Point(255, 7);
            this.btn_EidtLine.Name = "btn_EidtLine";
            this.btn_EidtLine.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtLine.TabIndex = 3;
            this.btn_EidtLine.Text = "修改折线";
            this.btn_EidtLine.UseVisualStyleBackColor = true;
            this.btn_EidtLine.Click += new System.EventHandler(this.btn_EidtPoint_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(174, 7);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteLine.TabIndex = 4;
            this.btn_DeleteLine.Text = "删除折线";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // btn_HandToAddLine
            // 
            this.btn_HandToAddLine.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddLine.Name = "btn_HandToAddLine";
            this.btn_HandToAddLine.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddLine.TabIndex = 5;
            this.btn_HandToAddLine.Text = "手动添加";
            this.btn_HandToAddLine.UseVisualStyleBackColor = true;
            this.btn_HandToAddLine.Click += new System.EventHandler(this.btn_HandToAddLine_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_DeletePoint);
            this.panel1.Controls.Add(this.chk_ShowLineNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgv_LinePointsInfo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_LineTextColor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_LineTextSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_LineText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_LineWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_LineColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_AddLineCencel);
            this.panel1.Controls.Add(this.btn_AddLineOK);
            this.panel1.Controls.Add(this.txt_LineID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(908, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 465);
            this.panel1.TabIndex = 2;
            // 
            // btn_DeletePoint
            // 
            this.btn_DeletePoint.Enabled = false;
            this.btn_DeletePoint.Location = new System.Drawing.Point(265, 239);
            this.btn_DeletePoint.Name = "btn_DeletePoint";
            this.btn_DeletePoint.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePoint.TabIndex = 21;
            this.btn_DeletePoint.Text = "删除点位";
            this.btn_DeletePoint.UseVisualStyleBackColor = true;
            this.btn_DeletePoint.Click += new System.EventHandler(this.btn_DeletePointInfo_Click);
            // 
            // chk_ShowLineNumber
            // 
            this.chk_ShowLineNumber.AutoSize = true;
            this.chk_ShowLineNumber.Enabled = false;
            this.chk_ShowLineNumber.Location = new System.Drawing.Point(150, 214);
            this.chk_ShowLineNumber.Name = "chk_ShowLineNumber";
            this.chk_ShowLineNumber.Size = new System.Drawing.Size(120, 16);
            this.chk_ShowLineNumber.TabIndex = 20;
            this.chk_ShowLineNumber.Text = "是否显示折线序号";
            this.chk_ShowLineNumber.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "显示线序：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "折线点位：";
            // 
            // dgv_LinePointsInfo
            // 
            this.dgv_LinePointsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LinePointsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_LinePointXvHao,
            this.COL_LinePointLon,
            this.COL_LinePointLat});
            this.dgv_LinePointsInfo.Enabled = false;
            this.dgv_LinePointsInfo.Location = new System.Drawing.Point(15, 265);
            this.dgv_LinePointsInfo.Name = "dgv_LinePointsInfo";
            this.dgv_LinePointsInfo.RowHeadersVisible = false;
            this.dgv_LinePointsInfo.RowTemplate.Height = 23;
            this.dgv_LinePointsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LinePointsInfo.Size = new System.Drawing.Size(322, 152);
            this.dgv_LinePointsInfo.TabIndex = 17;
            this.dgv_LinePointsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LinePointsInfo_CellClick);
            // 
            // COL_LinePointXvHao
            // 
            this.COL_LinePointXvHao.HeaderText = "序号";
            this.COL_LinePointXvHao.Name = "COL_LinePointXvHao";
            this.COL_LinePointXvHao.Width = 70;
            // 
            // COL_LinePointLon
            // 
            this.COL_LinePointLon.HeaderText = "经度";
            this.COL_LinePointLon.Name = "COL_LinePointLon";
            this.COL_LinePointLon.Width = 120;
            // 
            // COL_LinePointLat
            // 
            this.COL_LinePointLat.HeaderText = "纬度";
            this.COL_LinePointLat.Name = "COL_LinePointLat";
            this.COL_LinePointLat.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "折线信息";
            // 
            // txt_LineTextColor
            // 
            this.txt_LineTextColor.Enabled = false;
            this.txt_LineTextColor.Location = new System.Drawing.Point(147, 180);
            this.txt_LineTextColor.Name = "txt_LineTextColor";
            this.txt_LineTextColor.Size = new System.Drawing.Size(126, 21);
            this.txt_LineTextColor.TabIndex = 11;
            this.txt_LineTextColor.Click += new System.EventHandler(this.txt_LineTextColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "标注颜色：";
            // 
            // txt_LineTextSize
            // 
            this.txt_LineTextSize.Enabled = false;
            this.txt_LineTextSize.Location = new System.Drawing.Point(147, 150);
            this.txt_LineTextSize.Name = "txt_LineTextSize";
            this.txt_LineTextSize.Size = new System.Drawing.Size(126, 21);
            this.txt_LineTextSize.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "标注字号：";
            // 
            // txt_LineText
            // 
            this.txt_LineText.Enabled = false;
            this.txt_LineText.Location = new System.Drawing.Point(147, 120);
            this.txt_LineText.Name = "txt_LineText";
            this.txt_LineText.Size = new System.Drawing.Size(126, 21);
            this.txt_LineText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "文字标注：";
            // 
            // txt_LineWidth
            // 
            this.txt_LineWidth.Enabled = false;
            this.txt_LineWidth.Location = new System.Drawing.Point(147, 90);
            this.txt_LineWidth.Name = "txt_LineWidth";
            this.txt_LineWidth.Size = new System.Drawing.Size(126, 21);
            this.txt_LineWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "折线宽度：";
            // 
            // txt_LineColor
            // 
            this.txt_LineColor.Enabled = false;
            this.txt_LineColor.Location = new System.Drawing.Point(147, 60);
            this.txt_LineColor.Name = "txt_LineColor";
            this.txt_LineColor.Size = new System.Drawing.Size(126, 21);
            this.txt_LineColor.TabIndex = 3;
            this.txt_LineColor.Click += new System.EventHandler(this.txt_LineColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "折线颜色：";
            // 
            // btn_AddLineCencel
            // 
            this.btn_AddLineCencel.Enabled = false;
            this.btn_AddLineCencel.Location = new System.Drawing.Point(187, 429);
            this.btn_AddLineCencel.Name = "btn_AddLineCencel";
            this.btn_AddLineCencel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddLineCencel.TabIndex = 15;
            this.btn_AddLineCencel.Text = "取消";
            this.btn_AddLineCencel.UseVisualStyleBackColor = true;
            this.btn_AddLineCencel.Click += new System.EventHandler(this.btn_AddLineCencel_Click);
            // 
            // btn_AddLineOK
            // 
            this.btn_AddLineOK.Enabled = false;
            this.btn_AddLineOK.Location = new System.Drawing.Point(88, 429);
            this.btn_AddLineOK.Name = "btn_AddLineOK";
            this.btn_AddLineOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AddLineOK.TabIndex = 14;
            this.btn_AddLineOK.Text = "确定";
            this.btn_AddLineOK.UseVisualStyleBackColor = true;
            this.btn_AddLineOK.Click += new System.EventHandler(this.btn_AddLineOK_Click);
            // 
            // txt_LineID
            // 
            this.txt_LineID.Enabled = false;
            this.txt_LineID.Location = new System.Drawing.Point(147, 30);
            this.txt_LineID.Name = "txt_LineID";
            this.txt_LineID.Size = new System.Drawing.Size(126, 21);
            this.txt_LineID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "折线ID：";
            // 
            // fr_DrawLineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HandToAddLine);
            this.Controls.Add(this.btn_DeleteLine);
            this.Controls.Add(this.btn_EidtLine);
            this.Controls.Add(this.btn_DianXuanLine);
            this.Controls.Add(this.dgv_DrawLineInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_DrawLineInfo";
            this.Text = "绘制折线";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawLineInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawLineInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LinePointsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LinePointLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LinePointLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LinePointXvHao;
        private System.Windows.Forms.Button btn_DeletePoint;
        private System.Windows.Forms.CheckBox chk_ShowLineNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_LinePointsInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_LineTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LineTextSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LineText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LineColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddLineCencel;
        private System.Windows.Forms.Button btn_AddLineOK;
        private System.Windows.Forms.TextBox txt_LineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HandToAddLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.Button btn_EidtLine;
        public System.Windows.Forms.DataGridView dgv_DrawLineInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LinePointsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineTextInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineTextSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_LineTextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IsShowNumber;
        private System.Windows.Forms.Button btn_DianXuanLine;
    }
}