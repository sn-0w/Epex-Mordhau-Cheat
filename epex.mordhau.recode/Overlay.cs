using System;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace epex.mordhau.recode
{
	// Token: 0x02000002 RID: 2
	public partial class Overlay : Form
	{
		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000004 RID: 4
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr hWnd, out Overlay.ballbox lpRect);

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x06000007 RID: 7 RVA: 0x000020F3 File Offset: 0x000002F3
		public Overlay()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A2C File Offset: 0x00000C2C
		private void Overlay_Load(object sender, EventArgs e)
		{
			int procIdFromName = this.m.GetProcIdFromName("Mordhau-Win64-Shipping");
			this.m.OpenProcess(procIdFromName);
			int windowLong = Overlay.GetWindowLong(base.Handle, -20);
			Overlay.SetWindowLong(base.Handle, -20, windowLong | 524288 | 32);
			Overlay.GetWindowRect(this.handle, out this.box);
			base.Size = new Size(this.box.right - this.box.left, this.box.bottom - this.box.top);
			base.Top = this.box.top;
			base.Left = this.box.left;
			Control.CheckForIllegalCrossThreadCalls = false;
			new Thread(new ThreadStart(this.ESP)).Start();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000212D File Offset: 0x0000032D
		private void ESP()
		{
			for (;;)
			{
				this.overlay_box.Refresh();
				Thread.Sleep(10);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002B08 File Offset: 0x00000D08
		public static bool WorldToScreen(Vector3 source, Vector3 target, Vector2 viewAngles, float fov, out Vector2 screenPos)
		{
			screenPos = default(Vector2);
			uint num = 2560U;
			uint num2 = 1440U;
			float num3 = num / num2 * fov;
			Vector2 vector;
			Overlay.CalcAngle(source, target, out vector);
			Vector2 vector2 = viewAngles - vector;
			float num4 = (float)Math.Tan((double)vector2.X * 0.017453292519943295);
			float num5 = (float)Math.Cos((double)(num3 / 2f) * 0.017453292519943295);
			float num6 = (float)Math.Sin((double)(num3 / 2f) * 0.017453292519943295);
			float num7 = num4 * num5 / num6 * (num / 2U);
			float num8 = num / 2U - num7;
			float num9 = (float)Math.Tan((double)vector2.Y * 0.017453292519943295);
			float num10 = (float)Math.Cos((double)(fov / 2f) * 0.017453292519943295);
			float num11 = (float)Math.Sin((double)(fov / 2f) * 0.017453292519943295);
			float num12 = num9 * num10 / num11 * (num2 / 2U);
			float num13 = num2 / 2U - num12;
			screenPos.X = num8;
			screenPos.Y = num13;
			return true;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002C24 File Offset: 0x00000E24
		private static bool CalcAngle(Vector3 source, Vector3 target, out Vector2 viewAngles)
		{
			Vector2 vector;
			vector.X = (float)((double)((float)Math.Atan2((double)(target.X - source.X), (double)(target.Y - source.Y))) / 3.1415926535897931 * 180.0);
			vector.Y = (float)(Math.Asin((double)((target.Z - source.Z) / Vector3.Distance(source, target))) * 180.0 / 3.1415926535897931);
			viewAngles = vector;
			return true;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002CB0 File Offset: 0x00000EB0
		private void overlay_box_Paint(object sender, PaintEventArgs e)
		{
			Font font = new Font("Segoe UI", 22f);
			SolidBrush solidBrush = new SolidBrush(Color.White);
			this.g = e.Graphics;
			string text = Offsets.PlayerArray + ",0,280";
			float num = this.m.ReadFloat(Offsets.IngameFov, "", true);
			string text2 = Offsets.PlayerArray + ",8,280";
			float num2 = this.m.ReadFloat(Offsets.cam_pitch, "", true);
			float num3 = this.m.ReadFloat(Offsets.cam_yaw, "", true);
			float num4 = this.m.ReadFloat(text2 + "," + Offsets.player_x, "", true);
			float num5 = this.m.ReadFloat(text2 + "," + Offsets.player_y, "", true);
			float num6 = this.m.ReadFloat(text2 + "," + Offsets.player_z, "", true);
			float num7 = this.m.ReadFloat(Offsets.cam_x, "", true);
			float num8 = this.m.ReadFloat(Offsets.cam_y, "", true);
			float num9 = this.m.ReadFloat(Offsets.cam_z, "", true);
			Vector2 vector;
			if (Overlay.WorldToScreen(new Vector3(num7, num8, num9), new Vector3(num4, num5, num6), new Vector2(num3 / 2f, -num2), num, out vector))
			{
				this.g.DrawString(string.Format("{0} | {1}", vector.X, vector.Y), font, solidBrush, 100f, 100f);
				this.g.DrawString(string.Format("Camera :{0} | {1} | {2}", num7, num8, num9), font, solidBrush, 100f, 200f);
				this.g.DrawString(string.Format("Enemy: {0} | {1} | {2}", num4, num5, num6), font, solidBrush, 100f, 300f);
				this.g.DrawString(string.Format("Cam/Y/X: {0} | {1} | Ingame yaw: {2}", num2, num3, this.m.ReadFloat(text + ",524", "", true)), font, solidBrush, 100f, 400f);
				this.g.FillEllipse(solidBrush, new RectangleF(new PointF(vector.X - 5f, vector.Y - 5f), new SizeF(20f, 20f)));
			}
		}

		// Token: 0x04000001 RID: 1
		private Mem m = new Mem();

		// Token: 0x04000002 RID: 2
		private Graphics g;

		// Token: 0x04000003 RID: 3
		private Pen defaultpen = new Pen(Color.Lavender);

		// Token: 0x04000004 RID: 4
		private Overlay.ballbox box;

		// Token: 0x04000005 RID: 5
		private IntPtr handle = Overlay.FindWindow("UnrealWindow", null);

		// Token: 0x02000003 RID: 3
		public struct ballbox
		{
			// Token: 0x04000008 RID: 8
			public int left;

			// Token: 0x04000009 RID: 9
			public int top;

			// Token: 0x0400000A RID: 10
			public int right;

			// Token: 0x0400000B RID: 11
			public int bottom;
		}
	}
}
