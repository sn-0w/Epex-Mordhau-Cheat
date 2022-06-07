namespace epex.mordhau.recode
{
	// Token: 0x02000002 RID: 2
	public partial class Overlay : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002142 File Offset: 0x00000342
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002F68 File Offset: 0x00001168
		private void InitializeComponent()
		{
			this.overlay_box = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.overlay_box).BeginInit();
			base.SuspendLayout();
			this.overlay_box.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.overlay_box.Location = new global::System.Drawing.Point(0, 0);
			this.overlay_box.Name = "overlay_box";
			this.overlay_box.Size = new global::System.Drawing.Size(800, 450);
			this.overlay_box.TabIndex = 0;
			this.overlay_box.TabStop = false;
			this.overlay_box.Paint += new global::System.Windows.Forms.PaintEventHandler(this.overlay_box_Paint);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Wheat;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.overlay_box);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Overlay";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Overlay";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.Wheat;
			base.Load += new global::System.EventHandler(this.Overlay_Load);
			((global::System.ComponentModel.ISupportInitialize)this.overlay_box).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.PictureBox overlay_box;
	}
}
