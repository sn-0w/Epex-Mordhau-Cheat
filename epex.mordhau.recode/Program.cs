using System;
using System.Windows.Forms;

namespace epex.mordhau.recode
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000025D3 File Offset: 0x000007D3
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Menu());
		}
	}
}
