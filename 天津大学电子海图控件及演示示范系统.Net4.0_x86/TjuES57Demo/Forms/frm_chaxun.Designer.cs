namespace TjuES57Demo.Forms
{
    partial class frm_chaxun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chaxun));
            this.dgv_LayerInfo = new System.Windows.Forms.DataGridView();
            this.COL_ObjectXvHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BasicInfo = new System.Windows.Forms.DataGridView();
            this.COL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Attribute = new System.Windows.Forms.DataGridView();
            this.COL_Attr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_AttrValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_highlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LayerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BasicInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attribute)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LayerInfo
            // 
            this.dgv_LayerInfo.AllowUserToAddRows = false;
            this.dgv_LayerInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LayerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LayerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LayerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_ObjectXvHao,
            this.COL_ObjectName});
            this.dgv_LayerInfo.Location = new System.Drawing.Point(12, 12);
            this.dgv_LayerInfo.Name = "dgv_LayerInfo";
            this.dgv_LayerInfo.ReadOnly = true;
            this.dgv_LayerInfo.RowHeadersVisible = false;
            this.dgv_LayerInfo.RowTemplate.Height = 23;
            this.dgv_LayerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LayerInfo.Size = new System.Drawing.Size(153, 304);
            this.dgv_LayerInfo.TabIndex = 0;
            this.dgv_LayerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LayerInfo_CellClick);
            // 
            // COL_ObjectXvHao
            // 
            this.COL_ObjectXvHao.HeaderText = "";
            this.COL_ObjectXvHao.Name = "COL_ObjectXvHao";
            this.COL_ObjectXvHao.ReadOnly = true;
            this.COL_ObjectXvHao.Width = 20;
            // 
            // COL_ObjectName
            // 
            this.COL_ObjectName.HeaderText = "物标";
            this.COL_ObjectName.Name = "COL_ObjectName";
            this.COL_ObjectName.ReadOnly = true;
            this.COL_ObjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COL_ObjectName.Width = 130;
            // 
            // dgv_BasicInfo
            // 
            this.dgv_BasicInfo.AllowUserToAddRows = false;
            this.dgv_BasicInfo.AllowUserToDeleteRows = false;
            this.dgv_BasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BasicInfo.ColumnHeadersVisible = false;
            this.dgv_BasicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL1,
            this.COL2});
            this.dgv_BasicInfo.Enabled = false;
            this.dgv_BasicInfo.Location = new System.Drawing.Point(171, 12);
            this.dgv_BasicInfo.Name = "dgv_BasicInfo";
            this.dgv_BasicInfo.ReadOnly = true;
            this.dgv_BasicInfo.RowHeadersVisible = false;
            this.dgv_BasicInfo.RowTemplate.Height = 23;
            this.dgv_BasicInfo.Size = new System.Drawing.Size(303, 95);
            this.dgv_BasicInfo.TabIndex = 1;
            // 
            // COL1
            // 
            this.COL1.HeaderText = "Column1";
            this.COL1.Name = "COL1";
            this.COL1.ReadOnly = true;
            // 
            // COL2
            // 
            this.COL2.HeaderText = "Column2";
            this.COL2.Name = "COL2";
            this.COL2.ReadOnly = true;
            this.COL2.Width = 200;
            // 
            // dgv_Attribute
            // 
            this.dgv_Attribute.AllowUserToAddRows = false;
            this.dgv_Attribute.AllowUserToDeleteRows = false;
            this.dgv_Attribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Attribute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_Attr,
            this.COL_AttrValue});
            this.dgv_Attribute.Enabled = false;
            this.dgv_Attribute.Location = new System.Drawing.Point(171, 113);
            this.dgv_Attribute.Name = "dgv_Attribute";
            this.dgv_Attribute.ReadOnly = true;
            this.dgv_Attribute.RowHeadersVisible = false;
            this.dgv_Attribute.RowTemplate.Height = 23;
            this.dgv_Attribute.Size = new System.Drawing.Size(303, 174);
            this.dgv_Attribute.TabIndex = 2;
            // 
            // COL_Attr
            // 
            this.COL_Attr.HeaderText = "属性名";
            this.COL_Attr.Name = "COL_Attr";
            this.COL_Attr.ReadOnly = true;
            // 
            // COL_AttrValue
            // 
            this.COL_AttrValue.HeaderText = "属性值";
            this.COL_AttrValue.Name = "COL_AttrValue";
            this.COL_AttrValue.ReadOnly = true;
            this.COL_AttrValue.Width = 200;
            // 
            // btn_highlight
            // 
            this.btn_highlight.Location = new System.Drawing.Point(399, 293);
            this.btn_highlight.Name = "btn_highlight";
            this.btn_highlight.Size = new System.Drawing.Size(75, 23);
            this.btn_highlight.TabIndex = 3;
            this.btn_highlight.Text = "高亮";
            this.btn_highlight.UseVisualStyleBackColor = true;
            this.btn_highlight.Click += new System.EventHandler(this.btn_highlight_Click);
            // 
            // frm_chaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 328);
            this.Controls.Add(this.btn_highlight);
            this.Controls.Add(this.dgv_Attribute);
            this.Controls.Add(this.dgv_BasicInfo);
            this.Controls.Add(this.dgv_LayerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_chaxun";
            this.Text = "空间查询";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_chaxun_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LayerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BasicInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attribute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_LayerInfo;
        private System.Windows.Forms.DataGridView dgv_BasicInfo;
        private System.Windows.Forms.DataGridView dgv_Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ObjectXvHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Attr;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_AttrValue;
        private System.Windows.Forms.Button btn_highlight;
    }
}