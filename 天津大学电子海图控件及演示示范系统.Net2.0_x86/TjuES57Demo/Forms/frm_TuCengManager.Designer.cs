namespace TjuES57Demo.Forms
{
    partial class fr_TuCengManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_TuCengManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TuCeng = new System.Windows.Forms.DataGridView();
            this.btn_AllNotShow = new System.Windows.Forms.Button();
            this.btn_AllShow = new System.Windows.Forms.Button();
            this.sureexit = new System.Windows.Forms.Button();
            this.COL_TuCeng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_IsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COL_ReallyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuCeng)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_TuCeng);
            this.groupBox1.Controls.Add(this.btn_AllNotShow);
            this.groupBox1.Controls.Add(this.btn_AllShow);
            this.groupBox1.Controls.Add(this.sureexit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图层列表";
            // 
            // dgv_TuCeng
            // 
            this.dgv_TuCeng.AllowUserToAddRows = false;
            this.dgv_TuCeng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TuCeng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TuCeng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_TuCeng,
            this.COL_IsShow,
            this.COL_ReallyName});
            this.dgv_TuCeng.Location = new System.Drawing.Point(3, 17);
            this.dgv_TuCeng.Name = "dgv_TuCeng";
            this.dgv_TuCeng.RowHeadersVisible = false;
            this.dgv_TuCeng.RowTemplate.Height = 23;
            this.dgv_TuCeng.Size = new System.Drawing.Size(260, 305);
            this.dgv_TuCeng.TabIndex = 4;
            this.dgv_TuCeng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TuCeng_CellContentClick);
            this.dgv_TuCeng.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_TuCeng_CurCellDirtyStateChanged);
            // 
            // btn_AllNotShow
            // 
            this.btn_AllNotShow.BackgroundImage = global::TjuES57Demo.Properties.Resources.全部不显示;
            this.btn_AllNotShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AllNotShow.Location = new System.Drawing.Point(274, 192);
            this.btn_AllNotShow.Name = "btn_AllNotShow";
            this.btn_AllNotShow.Size = new System.Drawing.Size(109, 51);
            this.btn_AllNotShow.TabIndex = 3;
            this.btn_AllNotShow.UseVisualStyleBackColor = true;
            this.btn_AllNotShow.Click += new System.EventHandler(this.btn_AllNotShow_Click);
            // 
            // btn_AllShow
            // 
            this.btn_AllShow.BackgroundImage = global::TjuES57Demo.Properties.Resources.全显示;
            this.btn_AllShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AllShow.Location = new System.Drawing.Point(274, 121);
            this.btn_AllShow.Name = "btn_AllShow";
            this.btn_AllShow.Size = new System.Drawing.Size(109, 51);
            this.btn_AllShow.TabIndex = 3;
            this.btn_AllShow.UseVisualStyleBackColor = true;
            this.btn_AllShow.Click += new System.EventHandler(this.btn_AllShow_Click);
            // 
            // sureexit
            // 
            this.sureexit.BackgroundImage = global::TjuES57Demo.Properties.Resources.确定;
            this.sureexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sureexit.Location = new System.Drawing.Point(274, 271);
            this.sureexit.Name = "sureexit";
            this.sureexit.Size = new System.Drawing.Size(109, 51);
            this.sureexit.TabIndex = 2;
            this.sureexit.UseVisualStyleBackColor = true;
            this.sureexit.Click += new System.EventHandler(this.sureexit_Click);
            // 
            // COL_TuCeng
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.COL_TuCeng.DefaultCellStyle = dataGridViewCellStyle1;
            this.COL_TuCeng.HeaderText = "图层名称";
            this.COL_TuCeng.Name = "COL_TuCeng";
            this.COL_TuCeng.ReadOnly = true;
            this.COL_TuCeng.Width = 150;
            // 
            // COL_IsShow
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = false;
            this.COL_IsShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.COL_IsShow.FalseValue = "false";
            this.COL_IsShow.HeaderText = "是否显示";
            this.COL_IsShow.Name = "COL_IsShow";
            this.COL_IsShow.TrueValue = "true";
            this.COL_IsShow.Width = 90;
            // 
            // COL_ReallyName
            // 
            this.COL_ReallyName.HeaderText = "实际名称";
            this.COL_ReallyName.Name = "COL_ReallyName";
            this.COL_ReallyName.Visible = false;
            // 
            // fr_TuCengManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 366);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_TuCengManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图层管理";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_TuCengManager_FormClosing);
            this.Load += new System.EventHandler(this.MapListManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuCeng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TuCeng;
        private System.Windows.Forms.Button btn_AllNotShow;
        private System.Windows.Forms.Button btn_AllShow;
        private System.Windows.Forms.Button sureexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TuCeng;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COL_IsShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ReallyName;
    }
}