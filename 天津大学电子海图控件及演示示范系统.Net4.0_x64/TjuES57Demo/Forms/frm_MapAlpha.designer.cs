namespace TjuES57Demo.Forms
{
    partial class frm_MapAlpha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MapAlpha));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MapAlpha = new System.Windows.Forms.TextBox();
            this.btn_mapAlphaOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "海图透明度：";
            // 
            // txt_MapAlpha
            // 
            this.txt_MapAlpha.Location = new System.Drawing.Point(132, 29);
            this.txt_MapAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MapAlpha.Name = "txt_MapAlpha";
            this.txt_MapAlpha.Size = new System.Drawing.Size(92, 21);
            this.txt_MapAlpha.TabIndex = 1;
            // 
            // btn_mapAlphaOK
            // 
            this.btn_mapAlphaOK.Location = new System.Drawing.Point(203, 101);
            this.btn_mapAlphaOK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mapAlphaOK.Name = "btn_mapAlphaOK";
            this.btn_mapAlphaOK.Size = new System.Drawing.Size(61, 23);
            this.btn_mapAlphaOK.TabIndex = 2;
            this.btn_mapAlphaOK.Text = "确定";
            this.btn_mapAlphaOK.UseVisualStyleBackColor = true;
            this.btn_mapAlphaOK.Click += new System.EventHandler(this.btn_mapAlphaOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入0到100的整数";
            // 
            // frm_MapAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_mapAlphaOK);
            this.Controls.Add(this.txt_MapAlpha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_MapAlpha";
            this.Text = "海图透明度设置";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MapAlpha_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MapAlpha;
        private System.Windows.Forms.Button btn_mapAlphaOK;
        private System.Windows.Forms.Label label2;
    }
}