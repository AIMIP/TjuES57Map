using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TjuES57Demo.Forms
{
    public partial class fr_Help : Form
    {
        public static bool IsOpenThisFrm = false;
        private fr_MainForm main;
        private string actinfo = null;

        public fr_Help()
        {
            InitializeComponent();
        }

        public void OpenHelpWindow(fr_MainForm mainForm)
        {
            main = mainForm;
            LogActInfo();
            this.Show();
        }

        private void LogActInfo()
        {
            actinfo = main.map1.ES57Para.ActInfo;
            bool isactivated = main.map1.ES57Para.IsActivated;
            if (isactivated)
            {
                label3.Text = "已应用密钥。";
            }
            else
            {
                label3.Text = "控件尚未激活。";
            }
            label4.Text = actinfo;

            if (actinfo.Contains("机器码"))
            {
                button1.Show();
            }
            else
            {
                button1.Hide();
            }
        }

        private void fr_Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpenThisFrm = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(actinfo.Substring(actinfo.IndexOf("机器码:")));
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\MachineCode.txt", false, Encoding.Default);
            streamWriter.WriteLine(actinfo.Substring(actinfo.IndexOf("机器码:")));
            streamWriter.Close();
            bool flag = false;
            try
            {
                FileStream fs = File.OpenWrite(Application.StartupPath + "\\MachineCode.txt");
                fs.Close();
            }
            catch (Exception ex)
            {
                flag = true;
            }
            if (!flag)
            {
                System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath + "\\MachineCode.txt");
                MessageBox.Show("机器码已复制到剪贴板");
            }
        }
    }
}
