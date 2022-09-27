namespace TjuES57Demo.Forms.Forms
{
    partial class frm_Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Text));
            this.btn_DianXuanText = new System.Windows.Forms.Button();
            this.btn_HandToAddText = new System.Windows.Forms.Button();
            this.btn_DeleteText = new System.Windows.Forms.Button();
            this.btn_EditText = new System.Windows.Forms.Button();
            this.dgv_DrawTextInfo = new System.Windows.Forms.DataGridView();
            this.COL_TextXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextFont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TextRot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TextID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddTextCancel = new System.Windows.Forms.Button();
            this.btn_AddTextOK = new System.Windows.Forms.Button();
            this.txt_TextRot = new System.Windows.Forms.TextBox();
            this.txt_TextColor = new System.Windows.Forms.TextBox();
            this.txt_TextSize = new System.Windows.Forms.TextBox();
            this.txt_TextFont = new System.Windows.Forms.TextBox();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.txt_TextLat = new System.Windows.Forms.TextBox();
            this.txt_TextLong = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawTextInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DianXuanText
            // 
            this.btn_DianXuanText.Location = new System.Drawing.Point(12, 7);
            this.btn_DianXuanText.Name = "btn_DianXuanText";
            this.btn_DianXuanText.Size = new System.Drawing.Size(75, 23);
            this.btn_DianXuanText.TabIndex = 0;
            this.btn_DianXuanText.Text = "点选添加";
            this.btn_DianXuanText.UseVisualStyleBackColor = true;
            this.btn_DianXuanText.Click += new System.EventHandler(this.btn_DianXuanText_Click);
            // 
            // btn_HandToAddText
            // 
            this.btn_HandToAddText.Location = new System.Drawing.Point(93, 7);
            this.btn_HandToAddText.Name = "btn_HandToAddText";
            this.btn_HandToAddText.Size = new System.Drawing.Size(75, 23);
            this.btn_HandToAddText.TabIndex = 1;
            this.btn_HandToAddText.Text = "手动添加";
            this.btn_HandToAddText.UseVisualStyleBackColor = true;
            this.btn_HandToAddText.Click += new System.EventHandler(this.btn_HandToAddText_Click);
            // 
            // btn_DeleteText
            // 
            this.btn_DeleteText.Location = new System.Drawing.Point(174, 7);
            this.btn_DeleteText.Name = "btn_DeleteText";
            this.btn_DeleteText.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteText.TabIndex = 2;
            this.btn_DeleteText.Text = "删除文本";
            this.btn_DeleteText.UseVisualStyleBackColor = true;
            this.btn_DeleteText.Click += new System.EventHandler(this.btn_DeleteText_Click);
            // 
            // btn_EditText
            // 
            this.btn_EditText.Location = new System.Drawing.Point(255, 7);
            this.btn_EditText.Name = "btn_EditText";
            this.btn_EditText.Size = new System.Drawing.Size(75, 23);
            this.btn_EditText.TabIndex = 3;
            this.btn_EditText.Text = "修改文本";
            this.btn_EditText.UseVisualStyleBackColor = true;
            this.btn_EditText.Click += new System.EventHandler(this.btn_EditText_Click);
            // 
            // dgv_DrawTextInfo
            // 
            this.dgv_DrawTextInfo.AllowUserToAddRows = false;
            this.dgv_DrawTextInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawTextInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_TextXvHao,
            this.COL_TextID,
            this.COL_TextLong,
            this.COL_TextLat,
            this.COL_TextInfo,
            this.COL_TextFont,
            this.COL_TextSize,
            this.COL_TextColor,
            this.COL_TextRot});
            this.dgv_DrawTextInfo.Location = new System.Drawing.Point(-1, 36);
            this.dgv_DrawTextInfo.Name = "dgv_DrawTextInfo";
            this.dgv_DrawTextInfo.ReadOnly = true;
            this.dgv_DrawTextInfo.RowHeadersVisible = false;
            this.dgv_DrawTextInfo.RowTemplate.Height = 23;
            this.dgv_DrawTextInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DrawTextInfo.Size = new System.Drawing.Size(763, 347);
            this.dgv_DrawTextInfo.TabIndex = 0;
            this.dgv_DrawTextInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DrawTextInfo_CellClick);
            // 
            // COL_TextXvHao
            // 
            this.COL_TextXvHao.HeaderText = "序号";
            this.COL_TextXvHao.Name = "COL_TextXvHao";
            this.COL_TextXvHao.ReadOnly = true;
            this.COL_TextXvHao.Width = 60;
            // 
            // COL_TextID
            // 
            this.COL_TextID.HeaderText = "文本ID";
            this.COL_TextID.Name = "COL_TextID";
            this.COL_TextID.ReadOnly = true;
            // 
            // COL_TextLong
            // 
            this.COL_TextLong.HeaderText = "经度";
            this.COL_TextLong.Name = "COL_TextLong";
            this.COL_TextLong.ReadOnly = true;
            // 
            // COL_TextLat
            // 
            this.COL_TextLat.HeaderText = "纬度";
            this.COL_TextLat.Name = "COL_TextLat";
            this.COL_TextLat.ReadOnly = true;
            // 
            // COL_TextInfo
            // 
            this.COL_TextInfo.HeaderText = "内容";
            this.COL_TextInfo.Name = "COL_TextInfo";
            this.COL_TextInfo.ReadOnly = true;
            // 
            // COL_TextFont
            // 
            this.COL_TextFont.HeaderText = "字体";
            this.COL_TextFont.Name = "COL_TextFont";
            this.COL_TextFont.ReadOnly = true;
            this.COL_TextFont.Width = 60;
            // 
            // COL_TextSize
            // 
            this.COL_TextSize.HeaderText = "字号";
            this.COL_TextSize.Name = "COL_TextSize";
            this.COL_TextSize.ReadOnly = true;
            this.COL_TextSize.Width = 60;
            // 
            // COL_TextColor
            // 
            this.COL_TextColor.HeaderText = "颜色";
            this.COL_TextColor.Name = "COL_TextColor";
            this.COL_TextColor.ReadOnly = true;
            // 
            // COL_TextRot
            // 
            this.COL_TextRot.HeaderText = "旋转角度";
            this.COL_TextRot.Name = "COL_TextRot";
            this.COL_TextRot.ReadOnly = true;
            this.COL_TextRot.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "标注信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文本ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "标注经度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "标注纬度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "标注内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "标注字体：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "标注字号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "标注颜色：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "旋转角度：";
            // 
            // txt_TextID
            // 
            this.txt_TextID.Enabled = false;
            this.txt_TextID.Location = new System.Drawing.Point(130, 56);
            this.txt_TextID.Name = "txt_TextID";
            this.txt_TextID.Size = new System.Drawing.Size(126, 21);
            this.txt_TextID.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_AddTextCancel);
            this.panel1.Controls.Add(this.btn_AddTextOK);
            this.panel1.Controls.Add(this.txt_TextRot);
            this.panel1.Controls.Add(this.txt_TextColor);
            this.panel1.Controls.Add(this.txt_TextSize);
            this.panel1.Controls.Add(this.txt_TextFont);
            this.panel1.Controls.Add(this.txt_Text);
            this.panel1.Controls.Add(this.txt_TextLat);
            this.panel1.Controls.Add(this.txt_TextLong);
            this.panel1.Controls.Add(this.txt_TextID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(762, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 347);
            this.panel1.TabIndex = 5;
            // 
            // btn_AddTextCancel
            // 
            this.btn_AddTextCancel.Enabled = false;
            this.btn_AddTextCancel.Location = new System.Drawing.Point(168, 296);
            this.btn_AddTextCancel.Name = "btn_AddTextCancel";
            this.btn_AddTextCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTextCancel.TabIndex = 18;
            this.btn_AddTextCancel.Text = "取消";
            this.btn_AddTextCancel.UseVisualStyleBackColor = true;
            this.btn_AddTextCancel.Click += new System.EventHandler(this.btn_AddTextCancel_Click);
            // 
            // btn_AddTextOK
            // 
            this.btn_AddTextOK.Enabled = false;
            this.btn_AddTextOK.Location = new System.Drawing.Point(69, 296);
            this.btn_AddTextOK.Name = "btn_AddTextOK";
            this.btn_AddTextOK.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTextOK.TabIndex = 17;
            this.btn_AddTextOK.Text = "确定";
            this.btn_AddTextOK.UseVisualStyleBackColor = true;
            this.btn_AddTextOK.Click += new System.EventHandler(this.btn_AddTextOK_Click);
            // 
            // txt_TextRot
            // 
            this.txt_TextRot.Enabled = false;
            this.txt_TextRot.Location = new System.Drawing.Point(130, 245);
            this.txt_TextRot.Name = "txt_TextRot";
            this.txt_TextRot.Size = new System.Drawing.Size(126, 21);
            this.txt_TextRot.TabIndex = 16;
            // 
            // txt_TextColor
            // 
            this.txt_TextColor.Enabled = false;
            this.txt_TextColor.Location = new System.Drawing.Point(130, 218);
            this.txt_TextColor.Name = "txt_TextColor";
            this.txt_TextColor.ReadOnly = true;
            this.txt_TextColor.Size = new System.Drawing.Size(126, 21);
            this.txt_TextColor.TabIndex = 15;
            this.txt_TextColor.Click += new System.EventHandler(this.txt_TextColor_Click);
            // 
            // txt_TextSize
            // 
            this.txt_TextSize.Enabled = false;
            this.txt_TextSize.Location = new System.Drawing.Point(130, 191);
            this.txt_TextSize.Name = "txt_TextSize";
            this.txt_TextSize.Size = new System.Drawing.Size(126, 21);
            this.txt_TextSize.TabIndex = 14;
            // 
            // txt_TextFont
            // 
            this.txt_TextFont.Enabled = false;
            this.txt_TextFont.Location = new System.Drawing.Point(130, 164);
            this.txt_TextFont.Name = "txt_TextFont";
            this.txt_TextFont.ReadOnly = true;
            this.txt_TextFont.Size = new System.Drawing.Size(126, 21);
            this.txt_TextFont.TabIndex = 13;
            this.txt_TextFont.Click += new System.EventHandler(this.txt_TextFont_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.Enabled = false;
            this.txt_Text.Location = new System.Drawing.Point(130, 137);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(126, 21);
            this.txt_Text.TabIndex = 12;
            // 
            // txt_TextLat
            // 
            this.txt_TextLat.Enabled = false;
            this.txt_TextLat.Location = new System.Drawing.Point(130, 110);
            this.txt_TextLat.Name = "txt_TextLat";
            this.txt_TextLat.Size = new System.Drawing.Size(126, 21);
            this.txt_TextLat.TabIndex = 11;
            // 
            // txt_TextLong
            // 
            this.txt_TextLong.Enabled = false;
            this.txt_TextLong.Location = new System.Drawing.Point(130, 83);
            this.txt_TextLong.Name = "txt_TextLong";
            this.txt_TextLong.Size = new System.Drawing.Size(126, 21);
            this.txt_TextLong.TabIndex = 10;
            // 
            // frm_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_DrawTextInfo);
            this.Controls.Add(this.btn_EditText);
            this.Controls.Add(this.btn_DeleteText);
            this.Controls.Add(this.btn_HandToAddText);
            this.Controls.Add(this.btn_DianXuanText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Text";
            this.Text = "标注文本";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Text_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawTextInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DianXuanText;
        private System.Windows.Forms.Button btn_HandToAddText;
        private System.Windows.Forms.Button btn_DeleteText;
        private System.Windows.Forms.Button btn_EditText;
        public System.Windows.Forms.DataGridView dgv_DrawTextInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TextID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TextRot;
        private System.Windows.Forms.TextBox txt_TextColor;
        private System.Windows.Forms.TextBox txt_TextSize;
        private System.Windows.Forms.TextBox txt_TextFont;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.TextBox txt_TextLat;
        private System.Windows.Forms.TextBox txt_TextLong;
        private System.Windows.Forms.Button btn_AddTextCancel;
        private System.Windows.Forms.Button btn_AddTextOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextFont;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TextRot;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}