using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	// Token: 0x02000010 RID: 16
	public class CheckBoxBtn : Button
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002903 File Offset: 0x00000B03
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000290B File Offset: 0x00000B0B
		[DefaultValue(false)]
		[Category("Darstellung")]
		public bool Checked
		{
			get
			{
				return this.isChecked;
			}
			set
			{
				this.isChecked = value;
				base.Invalidate();
			}
		}


		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000292B File Offset: 0x00000B2B
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002933 File Offset: 0x00000B33
		[Category("Darstellung")]
		[DefaultValue(0)]
		public int SymbolUnchecked
		{
			[CompilerGenerated]
			get
			{
				return this.SymbolUncheckedk__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.SymbolUncheckedk__BackingField = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000028FB File Offset: 0x00000AFB
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000293C File Offset: 0x00000B3C
		[ReadOnly(true)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002945 File Offset: 0x00000B45
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000294D File Offset: 0x00000B4D
		[DefaultValue(ContentAlignment.MiddleCenter)]
		public override ContentAlignment TextAlign
		{
			get
			{
				return base.TextAlign;
			}
			set
			{
				base.TextAlign = value;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000C5 RID: 197 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		// (remove) Token: 0x060000C6 RID: 198 RVA: 0x0000E20C File Offset: 0x0000C40C
		public event EventHandler CheckedChanged
		{
			[CompilerGenerated]
			add
			{

			}
			[CompilerGenerated]
			remove
			{
				
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002956 File Offset: 0x00000B56
		public CheckBoxBtn()
		{
			this.ForeColor = Color.White;
			base.FlatAppearance.MouseDownBackColor = Color.Black;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002984 File Offset: 0x00000B84
		protected override Size DefaultSize
		{
			get
			{
				return new Size(30, 30);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000298F File Offset: 0x00000B8F
		protected override void InitLayout()
		{
			base.InitLayout();
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 0;
			this.Font = new Font("Segoe MDL2 Assets", 16f);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000029BF File Offset: 0x00000BBF
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			this.isChecked = !this.isChecked;
			this.OnCheckedChanged(e);
			base.Invalidate();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000029E4 File Offset: 0x00000BE4
		protected virtual void OnCheckedChanged(EventArgs e)
		{
			
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000E244 File Offset: 0x0000C444
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			using (Pen pen = new Pen(Color.Gray, 2f))
			{
				pen.Alignment = PenAlignment.Inset;
				pevent.Graphics.DrawRectangle(pen, 0f, 0f, (float)base.Width - 0.5f, (float)base.Height - 0.5f);
			}
			this.UpdateBtnText();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (this.Checked)
			{
				base.FlatAppearance.MouseDownBackColor = Color.Gray;
				base.FlatAppearance.MouseOverBackColor = Color.Gray;
				this.BackColor = Color.Gray;
				return;
			}
			base.FlatAppearance.MouseDownBackColor = Color.Black;
			base.FlatAppearance.MouseOverBackColor = Color.Black;
			this.BackColor = Color.Black;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000029F8 File Offset: 0x00000BF8
		protected void UpdateBtnText()
		{
			this.Text = char.ConvertFromUtf32(this.SymbolUnchecked);
		}

		// Token: 0x0400010B RID: 267
		private bool isChecked;

		// Token: 0x0400010C RID: 268
		[CompilerGenerated]
		private int SymbolCheckedk__BackingField;

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private int SymbolUncheckedk__BackingField;


	}
}
