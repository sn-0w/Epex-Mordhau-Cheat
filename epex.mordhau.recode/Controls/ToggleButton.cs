using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace epex.mordhau.recode.Controls
{
	// Token: 0x0200000F RID: 15
	public class ToggleButton : CheckBox
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000289F File Offset: 0x00000A9F
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000028A7 File Offset: 0x00000AA7
		[Category("EpexCustom")]
		public Color OnBackColor
		{
			get
			{
				return this.onBackColor;
			}
			set
			{
				this.onBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000028B6 File Offset: 0x00000AB6
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000028BE File Offset: 0x00000ABE
		[Category("EpexCustom")]
		public Color OnToggleColor
		{
			get
			{
				return this.onToggleColor;
			}
			set
			{
				this.onToggleColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000028CD File Offset: 0x00000ACD
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000028D5 File Offset: 0x00000AD5
		[Category("EpexCustom")]
		public Color OffBackColor
		{
			get
			{
				return this.offBackColor;
			}
			set
			{
				this.offBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000028E4 File Offset: 0x00000AE4
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000028EC File Offset: 0x00000AEC
		[Category("EpexCustom")]
		public Color OffToggleColor
		{
			get
			{
				return this.offToggleColor;
			}
			set
			{
				this.offToggleColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000028FB File Offset: 0x00000AFB
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002391 File Offset: 0x00000591
		[Browsable(false)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public ToggleButton()
		{
			this.MinimumSize = new Size(49, 22);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E01C File Offset: 0x0000C21C
		private GraphicsPath GetFigurePath()
		{
			int num = base.Height - 1;
			Rectangle rectangle = new Rectangle(1, 0, num, num);
			Rectangle rectangle2 = new Rectangle(base.Width - num - 2, 0, num, num);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rectangle, 90f, 180f);
			graphicsPath.AddArc(rectangle2, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E084 File Offset: 0x0000C284
		private GraphicsPath GetBorderPath()
		{
			int num = base.Height - 2;
			Rectangle rectangle = new Rectangle(1, 0, num, num);
			Rectangle rectangle2 = new Rectangle(base.Width - num - 2, 0, num, num);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rectangle, 90f, 180f);
			graphicsPath.AddArc(rectangle2, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		protected override void OnPaint(PaintEventArgs pevent)
		{
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			pevent.Graphics.Clear(base.Parent.BackColor);
			Point point = new Point(base.Width - base.Height + 5, 5);
			Point point2 = new Point(6, 5);
			int num = base.Height - 12;
			Rectangle rectangle = new Rectangle(4, 5, num, num);
			if (base.Checked)
			{
				pevent.Graphics.FillPath(new SolidBrush(this.onBackColor), this.GetFigurePath());
				rectangle.Location = point;
				pevent.Graphics.FillEllipse(new SolidBrush(this.OnToggleColor), rectangle);
				return;
			}
			pevent.Graphics.DrawPath(new Pen(this.OffToggleColor, 2f), this.GetBorderPath());
			rectangle.Location = point2;
			pevent.Graphics.FillEllipse(new SolidBrush(this.OffToggleColor), rectangle);
		}

		// Token: 0x04000107 RID: 263
		private Color onBackColor = Color.FromArgb(118, 118, 118);

		// Token: 0x04000108 RID: 264
		private Color onToggleColor = Color.White;

		// Token: 0x04000109 RID: 265
		private Color offBackColor = Color.Black;

		// Token: 0x0400010A RID: 266
		private Color offToggleColor = Color.FromArgb(204, 204, 204);
	}
}
