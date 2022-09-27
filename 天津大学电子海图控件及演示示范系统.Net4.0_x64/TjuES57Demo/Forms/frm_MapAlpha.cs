using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TjuES57Demo.Forms
{
    public partial class frm_MapAlpha : Form
    {

        public frm_MapAlpha()
        {
            InitializeComponent();
        }
        //wzcalphastart
        private fr_MainForm main;
        public static bool IsOpenThisFrm = false;

        public void OpenAlphaWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            txt_MapAlpha.Text = (main.map1.ES57Para.S57mapAlpha*100).ToString();
            this.Show();
        }
        //wzcalphaend

        private void btn_mapAlphaOK_Click(object sender, EventArgs e)
        {
            //wzcalphastart
            main.map1.ES57Para.S57mapAlpha = int.Parse(txt_MapAlpha.Text) / 100.0;
            if (main.map1.ES57Para.S57mapAlpha > 1) main.map1.ES57Para.S57mapAlpha = 1;
            if (main.map1.ES57Para.S57mapAlpha < 0) main.map1.ES57Para.S57mapAlpha = 0;
            main.map1.IsFlushMap = true;
            //wzcalphaend
        }

        private void frm_MapAlpha_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
        }
    }
}
