using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace epex.mordhau.recode.Controls
{
	// Token: 0x0200000E RID: 14
	public class EpexBox : UserControl
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600007F RID: 127 RVA: 0x0000D884 File Offset: 0x0000BA84
		// (remove) Token: 0x06000080 RID: 128 RVA: 0x0000D8BC File Offset: 0x0000BABC
		public event EventHandler _TextChanged
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

		// Token: 0x06000081 RID: 129 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		public EpexBox()
		{
			this.InitializeComponent();
			this.textBox1.ForeColor = Color.FromArgb(237, 237, 237);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002660 File Offset: 0x00000860
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002668 File Offset: 0x00000868
		[Category("RJ Code Advance")]
		public Color BorderColor
		{
			get
			{
				return this.borderColor;
			}
			set
			{
				this.borderColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002677 File Offset: 0x00000877
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000267F File Offset: 0x0000087F
		[Category("RJ Code Advance")]
		public Color BorderFocusColor
		{
			get
			{
				return this.borderFocusColor;
			}
			set
			{
				this.borderFocusColor = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002690 File Offset: 0x00000890
		[Category("RJ Code Advance")]
		public int BorderSize
		{
			get
			{
				return this.borderSize;
			}
			set
			{
				if (value >= 1)
				{
					this.borderSize = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000026A3 File Offset: 0x000008A3
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000026AB File Offset: 0x000008AB
		[Category("RJ Code Advance")]
		public bool UnderlinedStyle
		{
			get
			{
				return this.underlinedStyle;
			}
			set
			{
				this.underlinedStyle = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000026BA File Offset: 0x000008BA
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000026C2 File Offset: 0x000008C2
		[Category("RJ Code Advance")]
		public bool PasswordChar
		{
			get
			{
				return this.isPasswordChar;
			}
			set
			{
				this.isPasswordChar = value;
				if (!this.isPlaceholder)
				{
					this.textBox1.UseSystemPasswordChar = value;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000026DF File Offset: 0x000008DF
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000026EC File Offset: 0x000008EC
		[Category("RJ Code Advance")]
		public bool Multiline
		{
			get
			{
				return this.textBox1.Multiline;
			}
			set
			{
				this.textBox1.Multiline = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000026FA File Offset: 0x000008FA
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002702 File Offset: 0x00000902
		[Category("RJ Code Advance")]
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
				this.textBox1.BackColor = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002717 File Offset: 0x00000917
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000271F File Offset: 0x0000091F
		[Category("RJ Code Advance")]
		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor = value;
				this.textBox1.ForeColor = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002734 File Offset: 0x00000934
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000273C File Offset: 0x0000093C
		[Category("RJ Code Advance")]
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				this.textBox1.Font = value;
				if (base.DesignMode)
				{
					this.UpdateControlHeight();
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000275F File Offset: 0x0000095F
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000277A File Offset: 0x0000097A
		[Category("RJ Code Advance")]
		public string Texts
		{
			get
			{
				if (this.isPlaceholder)
				{
					return "";
				}
				return this.textBox1.Text;
			}
			set
			{
				this.textBox1.Text = value;
				this.SetPlaceholder();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000278E File Offset: 0x0000098E
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002796 File Offset: 0x00000996
		[Category("RJ Code Advance")]
		public int BorderRadius
		{
			get
			{
				return this.borderRadius;
			}
			set
			{
				if (value >= 0)
				{
					this.borderRadius = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000027A9 File Offset: 0x000009A9
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000027B1 File Offset: 0x000009B1
		[Category("RJ Code Advance")]
		public Color PlaceholderColor
		{
			get
			{
				return this.placeholderColor;
			}
			set
			{
				this.placeholderColor = value;
				if (this.isPlaceholder)
				{
					this.textBox1.ForeColor = value;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000027CE File Offset: 0x000009CE
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000027D6 File Offset: 0x000009D6
		[Category("RJ Code Advance")]
		public string PlaceholderText
		{
			get
			{
				return this.placeholderText;
			}
			set
			{
				this.placeholderText = value;
				this.textBox1.Text = "";
				this.SetPlaceholder();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000027F5 File Offset: 0x000009F5
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (base.DesignMode)
			{
				this.UpdateControlHeight();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000280C File Offset: 0x00000A0C
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.UpdateControlHeight();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000D984 File Offset: 0x0000BB84
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			if (this.borderRadius > 1)
			{
				Rectangle clientRectangle = base.ClientRectangle;
				Rectangle rectangle = Rectangle.Inflate(clientRectangle, -this.borderSize, -this.borderSize);
				int num = ((this.borderSize > 0) ? this.borderSize : 1);
				using (GraphicsPath figurePath = this.GetFigurePath(clientRectangle, this.borderRadius))
				{
					using (GraphicsPath figurePath2 = this.GetFigurePath(rectangle, this.borderRadius - this.borderSize))
					{
						using (Pen pen = new Pen(base.Parent.BackColor, (float)num))
						{
							using (Pen pen2 = new Pen(this.borderColor, (float)this.borderSize))
							{
								base.Region = new Region(figurePath);
								if (this.borderRadius > 15)
								{
									this.SetTextBoxRoundedRegion();
								}
								graphics.SmoothingMode = SmoothingMode.AntiAlias;
								pen2.Alignment = PenAlignment.Center;
								if (this.isFocused)
								{
									pen2.Color = this.borderFocusColor;
								}
								if (this.underlinedStyle)
								{
									graphics.DrawPath(pen, figurePath);
									graphics.SmoothingMode = SmoothingMode.None;
									graphics.DrawLine(pen2, 0, base.Height - 1, base.Width, base.Height - 1);
									return;
								}
								graphics.DrawPath(pen, figurePath);
								graphics.DrawPath(pen2, figurePath2);
								return;
							}
						}
					}
				}
			}
			using (Pen pen3 = new Pen(this.borderColor, (float)this.borderSize))
			{
				base.Region = new Region(base.ClientRectangle);
				pen3.Alignment = PenAlignment.Inset;
				if (this.isFocused)
				{
					pen3.Color = this.borderFocusColor;
				}
				if (this.underlinedStyle)
				{
					graphics.DrawLine(pen3, 0, base.Height - 1, base.Width, base.Height - 1);
				}
				else
				{
					graphics.DrawRectangle(pen3, 0f, 0f, (float)base.Width - 0.5f, (float)base.Height - 0.5f);
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		private void SetPlaceholder()
		{
			if (string.IsNullOrWhiteSpace(this.textBox1.Text) && this.placeholderText != "")
			{
				this.isPlaceholder = true;
				this.textBox1.Text = this.placeholderText;
				this.textBox1.ForeColor = this.placeholderColor;
				if (this.isPasswordChar)
				{
					this.textBox1.UseSystemPasswordChar = false;
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000DC44 File Offset: 0x0000BE44
		private void RemovePlaceholder()
		{
			if (this.isPlaceholder && this.placeholderText != "")
			{
				this.isPlaceholder = false;
				this.textBox1.Text = "";
				this.textBox1.ForeColor = this.ForeColor;
				if (this.isPasswordChar)
				{
					this.textBox1.UseSystemPasswordChar = true;
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		private GraphicsPath GetFigurePath(Rectangle rect, int radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			float num = (float)radius * 2f;
			graphicsPath.StartFigure();
			graphicsPath.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
			graphicsPath.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000DD60 File Offset: 0x0000BF60
		private void SetTextBoxRoundedRegion()
		{
			GraphicsPath graphicsPath;
			if (this.Multiline)
			{
				graphicsPath = this.GetFigurePath(this.textBox1.ClientRectangle, this.borderRadius - this.borderSize);
				this.textBox1.Region = new Region(graphicsPath);
			}
			else
			{
				graphicsPath = this.GetFigurePath(this.textBox1.ClientRectangle, this.borderSize * 2);
				this.textBox1.Region = new Region(graphicsPath);
			}
			graphicsPath.Dispose();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		private void UpdateControlHeight()
		{
			if (!this.textBox1.Multiline)
			{
				int num = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				this.textBox1.Multiline = true;
				this.textBox1.MinimumSize = new Size(0, num);
				this.textBox1.Multiline = false;
				base.Height = this.textBox1.Height + base.Padding.Top + base.Padding.Bottom;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000281B File Offset: 0x00000A1B
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002832 File Offset: 0x00000A32
		private void textBox1_Click(object sender, EventArgs e)
		{
			this.OnClick(e);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000283B File Offset: 0x00000A3B
		private void textBox1_MouseEnter(object sender, EventArgs e)
		{
			this.OnMouseEnter(e);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002844 File Offset: 0x00000A44
		private void textBox1_MouseLeave(object sender, EventArgs e)
		{
			this.OnMouseLeave(e);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000284D File Offset: 0x00000A4D
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.OnKeyPress(e);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002856 File Offset: 0x00000A56
		protected override void OnEnter(EventArgs e)
		{
			this.isFocused = true;
			base.Invalidate();
			this.RemovePlaceholder();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000286B File Offset: 0x00000A6B
		protected override void OnLeave(EventArgs e)
		{
			this.isFocused = false;
			base.Invalidate();
			this.SetPlaceholder();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002880 File Offset: 0x00000A80
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000DE68 File Offset: 0x0000C068
		private void InitializeComponent()
		{
			this.textBox1 = new TextBox();
			base.SuspendLayout();
			this.textBox1.BackColor = Color.Black;
			this.textBox1.BorderStyle = BorderStyle.None;
			this.textBox1.Dock = DockStyle.Fill;
			this.textBox1.Font = new Font("Segoe UI", 10.5f);
			this.textBox1.ForeColor = Color.FromArgb(237, 237, 237);
			this.textBox1.Location = new Point(10, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(229, 19);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.textBox1);
			base.Margin = new Padding(4);
			base.Name = "EpexBox";
			base.Padding = new Padding(10, 7, 10, 8);
			base.Size = new Size(249, 34);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000FA RID: 250
		private Color borderColor = Color.FromArgb(121, 121, 121);

		// Token: 0x040000FB RID: 251
		private Color borderFocusColor = Color.FromArgb(165, 165, 165);

		// Token: 0x040000FC RID: 252
		private int borderSize = 2;

		// Token: 0x040000FD RID: 253
		private bool underlinedStyle;

		// Token: 0x040000FE RID: 254
		private bool isFocused;

		// Token: 0x040000FF RID: 255
		private int borderRadius;

		// Token: 0x04000100 RID: 256
		private Color placeholderColor = Color.FromArgb(151, 151, 151);

		// Token: 0x04000101 RID: 257
		private string placeholderText = "";

		// Token: 0x04000102 RID: 258
		private bool isPlaceholder;

		// Token: 0x04000103 RID: 259
		private bool isPasswordChar;


		// Token: 0x04000105 RID: 261
		private IContainer components;

		// Token: 0x04000106 RID: 262
		private TextBox textBox1;
	}
}
