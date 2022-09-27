namespace TjuES57Demo.Forms.Forms
{
    partial class fr_DrawPolygonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DrawPolygonInfo));
            this.dgv_DrawPolygonInfo = new System.Windows.Forms.DataGridView();
            this.COL_PolygonXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonPointsInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonBorderColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonFillColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonBorderWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonTextInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonTextSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_IsShowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DianXuanPolygon = new System.Windows.Forms.Button();
            this.btn_EidtPolygon = new System.Windows.Forms.Button();
            this.btn_DeletePolygon = new System.Windows.Forms.Button();
            this.btn_HandToAddPolygon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_PolygonFillColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.chk_ShowPolygonNumber = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_PolygonPointsInfo = new System.Windows.Forms.DataGridView();
            this.COL_PolygonPointXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonPointLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_PolygonPointLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PolygonTextColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PolygonTextSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PolygonText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PolygonBorderWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PolygonBorderColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddPolygonCencel = new System.Windows.Forms.Button();
            this.btn_AddPolygonOK = new System.Windows.Forms.Button();
            this.txt_PolygonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawPolygonInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PolygonPointsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DrawPolygonInfo
            // 
            this.dgv_DrawPolygonInfo.AllowUserToAddRows = false;
            this.dgv_DrawPolygonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawPolygonInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_PolygonXvHao,
            this.COL_PolygonID,
            this.COL_PolygonPointsInfo,
            this.COL_PolygonBorderColor,
            this.COL_PolygonFillColor,
            this.COL_PolygonBorderWidth,
            this.COL_PolygonTextInfo,
            this.COL_PolygonTextSize,
            this.COL_PolygonTextColor,
            this.COL_IsShowNumber});
            this.dgv_DrawPolygonInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawPolygonInfo.Name = "dgv_DrawPolygonInfo";
            this.dgv_DrawPolygonInfo.ReadOnly = true;
            this.dgv_DrawPolygonInfo.RowHeadersVisible = false;
            this.dgv_DrawPolygonInfo.RowTemplate.Height = 23;
            this.dgv_DrawPolygonInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawPolygonInfo.Size = new System.Drawing.Size(1007, 492);
            this.dgv_DrawPolygonInfo.TabIndex = 0;
            this.dgv_DrawPolygonInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawPolygonInfo_CellClick);
            // 
            // COL_PolygonXvHao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_PolygonXvHao.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_PolygonXvHao.HeaderText = "序号";
            this.COL_PolygonXvHao.Name = "COL_PolygonXvHao";
            this.COL_PolygonXvHao.ReadOnly = true;
            this.COL_PolygonXvHao.Width = 60;
            // 
            // COL_PolygonID
            // 
            this.COL_PolygonID.HeaderText = "多边形ID";
            this.COL_PolygonID.Name = "COL_PolygonID";
            this.COL_PolygonID.ReadOnly = true;
            // 
            // COL_PolygonPointsInfo
            // 
            this.COL_PolygonPointsInfo.HeaderText = "点位信息";
            this.COL_PolygonPointsInfo.Name = "COL_PolygonPointsInfo";
            this.COL_PolygonPointsInfo.ReadOnly = true;
            this.COL_PolygonPointsInfo.Width = 240;
            // 
            // COL_PolygonBorderColor
            // 
            this.COL_PolygonBorderColor.HeaderText = "边框颜色";
            this.COL_PolygonBorderColor.Name = "COL_PolygonBorderColor";
            this.COL_PolygonBorderColor.ReadOnly = true;
            this.COL_PolygonBorderColor.Width = 80;
            // 
            // COL_PolygonFillColor
            // 
            this.COL_PolygonFillColor.HeaderText = "填充颜色";
            this.COL_PolygonFillColor.Name = "COL_PolygonFillColor";
            this.COL_PolygonFillColor.ReadOnly = true;
            // 
            // COL_PolygonBorderWidth
            // 
            this.COL_PolygonBorderWidth.HeaderText = "边框宽度";
            this.COL_PolygonBorderWidth.Name = "COL_PolygonBorderWidth";
            this.COL_PolygonBorderWidth.ReadOnly = true;
            this.COL_PolygonBorderWidth.Width = 80;
            // 
            // COL_PolygonTextInfo
            // 
            this.COL_PolygonTextInfo.HeaderText = "文字标注";
            this.COL_PolygonTextInfo.Name = "COL_PolygonTextInfo";
            this.COL_PolygonTextInfo.ReadOnly = true;
            // 
            // COL_PolygonTextSize
            // 
            this.COL_PolygonTextSize.HeaderText = "标注字号";
            this.COL_PolygonTextSize.Name = "COL_PolygonTextSize";
            this.COL_PolygonTextSize.ReadOnly = true;
            this.COL_PolygonTextSize.Width = 80;
            // 
            // COL_PolygonTextColor
            // 
            this.COL_PolygonTextColor.HeaderText = "标注颜色";
            this.COL_PolygonTextColor.Name = "COL_PolygonTextColor";
            this.COL_PolygonTextColor.ReadOnly = true;
            this.COL_PolygonTextColor.Width = 80;
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
            // btn_DianXuanPolygon
            // 
            this.btn_DianXuanPolygon.Location = new System.Drawing.Point(12, 7);
            this.btn_DianXuanPolygon.Name = "btn_DianXuanPolygon";
            this.btn_DianXuanPolygon.Size = new System.Drawing.Size(75, 23);
            this.btn_DianXuanPolygon.TabIndex = 1;
            this.btn_DianXuanPolygon.Text = "点选添加";
            this.btn_DianXuanPolygon.UseVisualStyleBackColor = true;
            this.btn_DianXuanPolygon.Click += new System.EventHandler(this.btn_DianXuanPolygon_Click);
            // 
            // btn_EidtPolygon
            // 
            this.btn_EidtPolygon.Location = new System.Drawing.Point(255, 7);
            this.btn_EidtPolygon.Name = "btn_EidtPolygon";
            this.btn_EidtPolygon.Size = new System.Drawing.Size(75, 23);
            this.btn_EidtPolygon.TabIndex = 3;
            this.btn_EidtPolygon.Text = "修改多边形";
            this.btn_EidtPolygon.UseVisualStyleBackColor = true;
            this.btn_EidtPolygon.Click += new System.EventHandler(this.btn_EidtPoint_Click);
            // 
            // btn_DeletePolygon
            // 
            this.btn_DeletePolygon.Location = new System.Drawing.Point(174, 7);
            this.btn_DeletePolygon.Name = "btn_DeletePolygon";
            this.btn_DeletePolygon.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePolygon.TabIndex = 4;
            this.btn_DeletePolygon.Text = "删除多边形";
            this.btn_DeletePolygon.UseVisualStyleBackColor = true;
            this.btn_DeletePolygon.Click += new System.EventHandler(this.btn_DeletePolygon_Click);
            // 
            // btn_HandToAddPolygon
            // 
            this.btn_HandToAddPolygon.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddPolygon.Name = "btn_HandToAddPolygon";
            this.btn_HandToAddPolygon.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddPolygon.TabIndex = 5;
            this.btn_HandToAddPolygon.Text = "手动添加";
            this.btn_HandToAddPolygon.UseVisualStyleBackColor = true;
            this.btn_HandToAddPolygon.Click += new System.EventHandler(this.btn_HandToAddPolygon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txt_PolygonFillColor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_DeletePoint);
            this.panel1.Controls.Add(this.chk_ShowPolygonNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgv_PolygonPointsInfo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_PolygonTextColor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_PolygonTextSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_PolygonText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_PolygonBorderWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_PolygonBorderColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_AddPolygonCencel);
            this.panel1.Controls.Add(this.btn_AddPolygonOK);
            this.panel1.Controls.Add(this.txt_PolygonID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1005, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 492);
            this.panel1.TabIndex = 2;
            // 
            // txt_PolygonFillColor
            // 
            this.txt_PolygonFillColor.Enabled = false;
            this.txt_PolygonFillColor.Location = new System.Drawing.Point(141, 90);
            this.txt_PolygonFillColor.Name = "txt_PolygonFillColor";
            this.txt_PolygonFillColor.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonFillColor.TabIndex = 22;
            this.txt_PolygonFillColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_PolygonFillColor_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "填充颜色：";
            // 
            // btn_DeletePoint
            // 
            this.btn_DeletePoint.Enabled = false;
            this.btn_DeletePoint.Location = new System.Drawing.Point(265, 268);
            this.btn_DeletePoint.Name = "btn_DeletePoint";
            this.btn_DeletePoint.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePoint.TabIndex = 21;
            this.btn_DeletePoint.Text = "删除点位";
            this.btn_DeletePoint.UseVisualStyleBackColor = true;
            this.btn_DeletePoint.Click += new System.EventHandler(this.btn_DeletePointInfo_Click);
            // 
            // chk_ShowPolygonNumber
            // 
            this.chk_ShowPolygonNumber.AutoSize = true;
            this.chk_ShowPolygonNumber.Enabled = false;
            this.chk_ShowPolygonNumber.Location = new System.Drawing.Point(144, 242);
            this.chk_ShowPolygonNumber.Name = "chk_ShowPolygonNumber";
            this.chk_ShowPolygonNumber.Size = new System.Drawing.Size(132, 16);
            this.chk_ShowPolygonNumber.TabIndex = 20;
            this.chk_ShowPolygonNumber.Text = "是否显示多边形序号";
            this.chk_ShowPolygonNumber.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "显示线序：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "多边形点位：";
            // 
            // dgv_PolygonPointsInfo
            // 
            this.dgv_PolygonPointsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PolygonPointsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_PolygonPointXvHao,
            this.COL_PolygonPointLon,
            this.COL_PolygonPointLat});
            this.dgv_PolygonPointsInfo.Enabled = false;
            this.dgv_PolygonPointsInfo.Location = new System.Drawing.Point(10, 294);
            this.dgv_PolygonPointsInfo.Name = "dgv_PolygonPointsInfo";
            this.dgv_PolygonPointsInfo.RowHeadersVisible = false;
            this.dgv_PolygonPointsInfo.RowTemplate.Height = 23;
            this.dgv_PolygonPointsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PolygonPointsInfo.Size = new System.Drawing.Size(331, 152);
            this.dgv_PolygonPointsInfo.TabIndex = 17;
            this.dgv_PolygonPointsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PolygonPointsInfo_CellClick);
            // 
            // COL_PolygonPointXvHao
            // 
            this.COL_PolygonPointXvHao.HeaderText = "序号";
            this.COL_PolygonPointXvHao.Name = "COL_PolygonPointXvHao";
            this.COL_PolygonPointXvHao.Width = 70;
            // 
            // COL_PolygonPointLon
            // 
            this.COL_PolygonPointLon.HeaderText = "经度";
            this.COL_PolygonPointLon.Name = "COL_PolygonPointLon";
            this.COL_PolygonPointLon.Width = 125;
            // 
            // COL_PolygonPointLat
            // 
            this.COL_PolygonPointLat.HeaderText = "纬度";
            this.COL_PolygonPointLat.Name = "COL_PolygonPointLat";
            this.COL_PolygonPointLat.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "多边形信息";
            // 
            // txt_PolygonTextColor
            // 
            this.txt_PolygonTextColor.Enabled = false;
            this.txt_PolygonTextColor.Location = new System.Drawing.Point(141, 210);
            this.txt_PolygonTextColor.Name = "txt_PolygonTextColor";
            this.txt_PolygonTextColor.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonTextColor.TabIndex = 11;
            this.txt_PolygonTextColor.Click += new System.EventHandler(this.txt_PolygonTextColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "标注颜色：";
            // 
            // txt_PolygonTextSize
            // 
            this.txt_PolygonTextSize.Enabled = false;
            this.txt_PolygonTextSize.Location = new System.Drawing.Point(141, 180);
            this.txt_PolygonTextSize.Name = "txt_PolygonTextSize";
            this.txt_PolygonTextSize.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonTextSize.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "标注字号：";
            // 
            // txt_PolygonText
            // 
            this.txt_PolygonText.Enabled = false;
            this.txt_PolygonText.Location = new System.Drawing.Point(141, 150);
            this.txt_PolygonText.Name = "txt_PolygonText";
            this.txt_PolygonText.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "文字标注：";
            // 
            // txt_PolygonBorderWidth
            // 
            this.txt_PolygonBorderWidth.Enabled = false;
            this.txt_PolygonBorderWidth.Location = new System.Drawing.Point(141, 120);
            this.txt_PolygonBorderWidth.Name = "txt_PolygonBorderWidth";
            this.txt_PolygonBorderWidth.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonBorderWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "边框宽度：";
            // 
            // txt_PolygonBorderColor
            // 
            this.txt_PolygonBorderColor.Enabled = false;
            this.txt_PolygonBorderColor.Location = new System.Drawing.Point(141, 60);
            this.txt_PolygonBorderColor.Name = "txt_PolygonBorderColor";
            this.txt_PolygonBorderColor.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonBorderColor.TabIndex = 3;
            this.txt_PolygonBorderColor.Click += new System.EventHandler(this.txt_PolygonColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "边框颜色：";
            // 
            // btn_AddPolygonCencel
            // 
            this.btn_AddPolygonCencel.Enabled = false;
            this.btn_AddPolygonCencel.Location = new System.Drawing.Point(187, 458);
            this.btn_AddPolygonCencel.Name = "btn_AddPolygonCencel";
            this.btn_AddPolygonCencel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPolygonCencel.TabIndex = 15;
            this.btn_AddPolygonCencel.Text = "取消";
            this.btn_AddPolygonCencel.UseVisualStyleBackColor = true;
            this.btn_AddPolygonCencel.Click += new System.EventHandler(this.btn_AddPolygonCencel_Click);
            // 
            // btn_AddPolygonOK
            // 
            this.btn_AddPolygonOK.Enabled = false;
            this.btn_AddPolygonOK.Location = new System.Drawing.Point(88, 458);
            this.btn_AddPolygonOK.Name = "btn_AddPolygonOK";
            this.btn_AddPolygonOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPolygonOK.TabIndex = 14;
            this.btn_AddPolygonOK.Text = "确定";
            this.btn_AddPolygonOK.UseVisualStyleBackColor = true;
            this.btn_AddPolygonOK.Click += new System.EventHandler(this.btn_AddPolygonOK_Click);
            // 
            // txt_PolygonID
            // 
            this.txt_PolygonID.Enabled = false;
            this.txt_PolygonID.Location = new System.Drawing.Point(141, 30);
            this.txt_PolygonID.Name = "txt_PolygonID";
            this.txt_PolygonID.Size = new System.Drawing.Size(126, 21);
            this.txt_PolygonID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "多边形ID：";
            // 
            // fr_DrawPolygonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HandToAddPolygon);
            this.Controls.Add(this.btn_DeletePolygon);
            this.Controls.Add(this.btn_EidtPolygon);
            this.Controls.Add(this.btn_DianXuanPolygon);
            this.Controls.Add(this.dgv_DrawPolygonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_DrawPolygonInfo";
            this.Text = "绘制多边形";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_DrawPointInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawPolygonInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PolygonPointsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonPointLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonPointLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonPointXvHao;
        private System.Windows.Forms.TextBox txt_PolygonFillColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_DeletePoint;
        private System.Windows.Forms.CheckBox chk_ShowPolygonNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_PolygonPointsInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PolygonTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PolygonTextSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PolygonText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PolygonBorderWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PolygonBorderColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddPolygonCencel;
        private System.Windows.Forms.Button btn_AddPolygonOK;
        private System.Windows.Forms.TextBox txt_PolygonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HandToAddPolygon;
        private System.Windows.Forms.Button btn_DeletePolygon;
        private System.Windows.Forms.Button btn_EidtPolygon;
        private System.Windows.Forms.Button btn_DianXuanPolygon;
        public System.Windows.Forms.DataGridView dgv_DrawPolygonInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonPointsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonBorderColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonFillColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonBorderWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonTextInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonTextSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_PolygonTextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IsShowNumber;
    }
}