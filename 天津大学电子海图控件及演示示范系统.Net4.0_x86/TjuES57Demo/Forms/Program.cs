using System;
using System.Windows.Forms;
using TjuES57Demo.Forms;

namespace TjuES57Demo
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new fr_MainForm());
		}
	}
}
