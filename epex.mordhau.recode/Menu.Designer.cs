namespace epex.mordhau.recode
{
	// Token: 0x02000005 RID: 5
	public partial class Menu : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000024A9 File Offset: 0x000006A9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006A08 File Offset: 0x00004C08
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ExploitsButton = new System.Windows.Forms.Button();
            this.MiscButton = new System.Windows.Forms.Button();
            this.VisualsButton = new System.Windows.Forms.Button();
            this.LongButton = new System.Windows.Forms.Button();
            this.CombatButton = new System.Windows.Forms.Button();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.combattab = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.ripostefeint = new epex.mordhau.recode.Controls.ToggleButton();
            this.bindbutton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.animbreaker = new epex.mordhau.recode.Controls.ToggleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.turncapSlider = new ColorSlider.ColorSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.turncapbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.combobutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.delaybutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rangedtab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reloadanimbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.accurbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.holdbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.fastbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.visualstab = new System.Windows.Forms.TabPage();
            this.tpvalue = new System.Windows.Forms.Label();
            this.tpslider = new ColorSlider.ColorSlider();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fovlabel = new System.Windows.Forms.Label();
            this.fovslider = new ColorSlider.ColorSlider();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tpbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.fovbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.misctab = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dodgevalue = new System.Windows.Forms.Label();
            this.dodgeslider = new ColorSlider.ColorSlider();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.voicespam = new epex.mordhau.recode.Controls.ToggleButton();
            this.warmupbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.ballistabutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.moonwalkbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.sprintbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.restrictbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.afkbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.exploitstab = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.lagbindbutton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.serveridlabel = new System.Windows.Forms.Label();
            this.ketylabel = new System.Windows.Forms.Label();
            this.savetoken = new System.Windows.Forms.Button();
            this.loadtoken = new System.Windows.Forms.Button();
            this.findtoken = new System.Windows.Forms.Button();
            this.findid = new System.Windows.Forms.Button();
            this.exploitstatuslabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lagbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.debug = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.playfabid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.closeenemy = new System.Windows.Forms.Label();
            this.realyawlabel = new System.Windows.Forms.Label();
            this.sukafovlabel = new System.Windows.Forms.Label();
            this.reqyawlabel = new System.Windows.Forms.Label();
            this.reqpitchlabel = new System.Windows.Forms.Label();
            this.hypolabel = new System.Windows.Forms.Label();
            this.myzlabel = new System.Windows.Forms.Label();
            this.myylabel = new System.Windows.Forms.Label();
            this.myxlabel = new System.Windows.Forms.Label();
            this.enemyzlabel = new System.Windows.Forms.Label();
            this.enemyylabel = new System.Windows.Forms.Label();
            this.enemyxlabel = new System.Windows.Forms.Label();
            this.myyawlabel = new System.Windows.Forms.Label();
            this.mypitchlabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spammer = new epex.mordhau.recode.Controls.ToggleButton();
            this.Wallhack = new epex.mordhau.recode.Controls.ToggleButton();
            this.toggleButton1 = new epex.mordhau.recode.Controls.ToggleButton();
            this.debugbutton = new epex.mordhau.recode.Controls.ToggleButton();
            this.gameclose = new System.Windows.Forms.Timer(this.components);
            this.combat = new System.Windows.Forms.Timer(this.components);
            this.PlayerAlive = new System.Windows.Forms.Timer(this.components);
            this.ranged = new System.Windows.Forms.Timer(this.components);
            this.visuals = new System.Windows.Forms.Timer(this.components);
            this.misc = new System.Windows.Forms.Timer(this.components);
            this.menuswitch = new System.Windows.Forms.Timer(this.components);
            this.binder = new System.Windows.Forms.Timer(this.components);
            this.idfinder = new System.ComponentModel.BackgroundWorker();
            this.tokenfinder = new System.ComponentModel.BackgroundWorker();
            this.Autoblock = new System.Windows.Forms.Timer(this.components);
            this.debuginfo = new System.Windows.Forms.Timer(this.components);
            this.spammertick = new System.Windows.Forms.Timer(this.components);
            this.loxfab = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ParentPanel.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.combattab.SuspendLayout();
            this.rangedtab.SuspendLayout();
            this.visualstab.SuspendLayout();
            this.misctab.SuspendLayout();
            this.exploitstab.SuspendLayout();
            this.debug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.button1.Size = new System.Drawing.Size(50, 33);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "╳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Epex";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.ExploitsButton);
            this.panel2.Controls.Add(this.MiscButton);
            this.panel2.Controls.Add(this.VisualsButton);
            this.panel2.Controls.Add(this.LongButton);
            this.panel2.Controls.Add(this.CombatButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 417);
            this.panel2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "debug";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ExploitsButton
            // 
            this.ExploitsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExploitsButton.FlatAppearance.BorderSize = 0;
            this.ExploitsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ExploitsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ExploitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExploitsButton.Location = new System.Drawing.Point(0, 200);
            this.ExploitsButton.Name = "ExploitsButton";
            this.ExploitsButton.Size = new System.Drawing.Size(50, 50);
            this.ExploitsButton.TabIndex = 4;
            this.ExploitsButton.TabStop = false;
            this.ExploitsButton.Text = " exploits";
            this.ExploitsButton.UseVisualStyleBackColor = true;
            this.ExploitsButton.Click += new System.EventHandler(this.ExploitsButton_Click);
            // 
            // MiscButton
            // 
            this.MiscButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiscButton.FlatAppearance.BorderSize = 0;
            this.MiscButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.MiscButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.MiscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscButton.Location = new System.Drawing.Point(0, 150);
            this.MiscButton.Name = "MiscButton";
            this.MiscButton.Size = new System.Drawing.Size(50, 50);
            this.MiscButton.TabIndex = 3;
            this.MiscButton.TabStop = false;
            this.MiscButton.Text = " misc";
            this.MiscButton.UseVisualStyleBackColor = true;
            this.MiscButton.Click += new System.EventHandler(this.MiscButton_Click);
            // 
            // VisualsButton
            // 
            this.VisualsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VisualsButton.FlatAppearance.BorderSize = 0;
            this.VisualsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.VisualsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.VisualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualsButton.Location = new System.Drawing.Point(0, 100);
            this.VisualsButton.Name = "VisualsButton";
            this.VisualsButton.Size = new System.Drawing.Size(50, 50);
            this.VisualsButton.TabIndex = 2;
            this.VisualsButton.TabStop = false;
            this.VisualsButton.Text = " visuals";
            this.VisualsButton.UseVisualStyleBackColor = true;
            this.VisualsButton.Click += new System.EventHandler(this.VisualsButton_Click);
            // 
            // LongButton
            // 
            this.LongButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LongButton.FlatAppearance.BorderSize = 0;
            this.LongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongButton.Location = new System.Drawing.Point(0, 50);
            this.LongButton.Name = "LongButton";
            this.LongButton.Size = new System.Drawing.Size(50, 50);
            this.LongButton.TabIndex = 1;
            this.LongButton.TabStop = false;
            this.LongButton.Text = "ranged";
            this.LongButton.UseVisualStyleBackColor = true;
            this.LongButton.Click += new System.EventHandler(this.LongButton_Click);
            // 
            // CombatButton
            // 
            this.CombatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CombatButton.FlatAppearance.BorderSize = 0;
            this.CombatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.CombatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CombatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CombatButton.Location = new System.Drawing.Point(0, 0);
            this.CombatButton.Name = "CombatButton";
            this.CombatButton.Size = new System.Drawing.Size(50, 50);
            this.CombatButton.TabIndex = 0;
            this.CombatButton.TabStop = false;
            this.CombatButton.Text = "combat";
            this.CombatButton.UseVisualStyleBackColor = true;
            this.CombatButton.Click += new System.EventHandler(this.CombatButton_Click);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.customTabControl1);
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(50, 33);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(450, 417);
            this.ParentPanel.TabIndex = 5;
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.combattab);
            this.customTabControl1.Controls.Add(this.rangedtab);
            this.customTabControl1.Controls.Add(this.visualstab);
            this.customTabControl1.Controls.Add(this.misctab);
            this.customTabControl1.Controls.Add(this.exploitstab);
            this.customTabControl1.Controls.Add(this.debug);
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Dark;
            this.customTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.customTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.customTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.customTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.White;
            this.customTabControl1.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(232)))));
            this.customTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl1.DisplayStyleProvider.HotTrack = false;
            this.customTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl1.DisplayStyleProvider.Overlap = 0;
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.customTabControl1.DisplayStyleProvider.Radius = 10;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.customTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(232)))));
            this.customTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl1.Location = new System.Drawing.Point(0, 0);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(450, 417);
            this.customTabControl1.TabIndex = 2;
            // 
            // combattab
            // 
            this.combattab.BackColor = System.Drawing.Color.Black;
            this.combattab.Controls.Add(this.label32);
            this.combattab.Controls.Add(this.ripostefeint);
            this.combattab.Controls.Add(this.bindbutton);
            this.combattab.Controls.Add(this.label27);
            this.combattab.Controls.Add(this.animbreaker);
            this.combattab.Controls.Add(this.label11);
            this.combattab.Controls.Add(this.label10);
            this.combattab.Controls.Add(this.turncapSlider);
            this.combattab.Controls.Add(this.label9);
            this.combattab.Controls.Add(this.label8);
            this.combattab.Controls.Add(this.label7);
            this.combattab.Controls.Add(this.turncapbutton);
            this.combattab.Controls.Add(this.combobutton);
            this.combattab.Controls.Add(this.delaybutton);
            this.combattab.Controls.Add(this.label2);
            this.combattab.Controls.Add(this.panel3);
            this.combattab.Location = new System.Drawing.Point(4, 23);
            this.combattab.Name = "combattab";
            this.combattab.Size = new System.Drawing.Size(442, 390);
            this.combattab.TabIndex = 0;
            this.combattab.Text = "Combat";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(72, 290);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(187, 20);
            this.label32.TabIndex = 16;
            this.label32.Text = "Allow to feint after riposte";
            // 
            // ripostefeint
            // 
            this.ripostefeint.AutoSize = true;
            this.ripostefeint.Location = new System.Drawing.Point(17, 291);
            this.ripostefeint.MinimumSize = new System.Drawing.Size(49, 22);
            this.ripostefeint.Name = "ripostefeint";
            this.ripostefeint.OffBackColor = System.Drawing.Color.Black;
            this.ripostefeint.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ripostefeint.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ripostefeint.OnToggleColor = System.Drawing.Color.White;
            this.ripostefeint.Size = new System.Drawing.Size(49, 22);
            this.ripostefeint.TabIndex = 15;
            this.ripostefeint.UseVisualStyleBackColor = true;
            // 
            // bindbutton
            // 
            this.bindbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bindbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bindbutton.FlatAppearance.BorderSize = 0;
            this.bindbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bindbutton.ForeColor = System.Drawing.Color.White;
            this.bindbutton.Location = new System.Drawing.Point(176, 239);
            this.bindbutton.Name = "bindbutton";
            this.bindbutton.Size = new System.Drawing.Size(109, 37);
            this.bindbutton.TabIndex = 14;
            this.bindbutton.TabStop = false;
            this.bindbutton.Text = "Bind";
            this.bindbutton.UseVisualStyleBackColor = false;
            this.bindbutton.Click += new System.EventHandler(this.bindbutton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(72, 247);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 20);
            this.label27.TabIndex = 13;
            this.label27.Text = "Animbreaker";
            // 
            // animbreaker
            // 
            this.animbreaker.AutoSize = true;
            this.animbreaker.Location = new System.Drawing.Point(17, 247);
            this.animbreaker.MinimumSize = new System.Drawing.Size(49, 22);
            this.animbreaker.Name = "animbreaker";
            this.animbreaker.OffBackColor = System.Drawing.Color.Black;
            this.animbreaker.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.animbreaker.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.animbreaker.OnToggleColor = System.Drawing.Color.White;
            this.animbreaker.Size = new System.Drawing.Size(49, 22);
            this.animbreaker.TabIndex = 12;
            this.animbreaker.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label11.Location = new System.Drawing.Point(361, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "600";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label10.Location = new System.Drawing.Point(17, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Turn cap value:";
            // 
            // turncapSlider
            // 
            this.turncapSlider.BackColor = System.Drawing.Color.Black;
            this.turncapSlider.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.turncapSlider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.turncapSlider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.turncapSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.turncapSlider.DrawSemitransparentThumb = false;
            this.turncapSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.Enabled = false;
            this.turncapSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.turncapSlider.ForeColor = System.Drawing.Color.White;
            this.turncapSlider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.turncapSlider.Location = new System.Drawing.Point(134, 204);
            this.turncapSlider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.turncapSlider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.turncapSlider.MouseEffects = false;
            this.turncapSlider.Name = "turncapSlider";
            this.turncapSlider.Padding = 1;
            this.turncapSlider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.turncapSlider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.turncapSlider.ShowDivisionsText = false;
            this.turncapSlider.ShowSmallScale = false;
            this.turncapSlider.Size = new System.Drawing.Size(200, 28);
            this.turncapSlider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.turncapSlider.TabIndex = 9;
            this.turncapSlider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.turncapSlider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.turncapSlider.ThumbSize = new System.Drawing.Size(16, 16);
            this.turncapSlider.TickAdd = 0F;
            this.turncapSlider.TickColor = System.Drawing.Color.White;
            this.turncapSlider.TickDivide = 0F;
            this.turncapSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.turncapSlider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.turncapSlider.ValueChanged += new System.EventHandler(this.turncapSlider_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Turn cap modifier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Always allow combo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Remove parry delay";
            // 
            // turncapbutton
            // 
            this.turncapbutton.AutoSize = true;
            this.turncapbutton.Location = new System.Drawing.Point(17, 171);
            this.turncapbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.turncapbutton.Name = "turncapbutton";
            this.turncapbutton.OffBackColor = System.Drawing.Color.Black;
            this.turncapbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.turncapbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.turncapbutton.OnToggleColor = System.Drawing.Color.White;
            this.turncapbutton.Size = new System.Drawing.Size(49, 22);
            this.turncapbutton.TabIndex = 4;
            this.turncapbutton.UseVisualStyleBackColor = true;
            this.turncapbutton.CheckedChanged += new System.EventHandler(this.turncapbutton_CheckedChanged);
            // 
            // combobutton
            // 
            this.combobutton.AutoSize = true;
            this.combobutton.Location = new System.Drawing.Point(17, 127);
            this.combobutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.combobutton.Name = "combobutton";
            this.combobutton.OffBackColor = System.Drawing.Color.Black;
            this.combobutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.combobutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.combobutton.OnToggleColor = System.Drawing.Color.White;
            this.combobutton.Size = new System.Drawing.Size(49, 22);
            this.combobutton.TabIndex = 3;
            this.combobutton.UseVisualStyleBackColor = true;
            this.combobutton.CheckedChanged += new System.EventHandler(this.combobutton_CheckedChanged);
            // 
            // delaybutton
            // 
            this.delaybutton.AutoSize = true;
            this.delaybutton.Location = new System.Drawing.Point(17, 83);
            this.delaybutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.delaybutton.Name = "delaybutton";
            this.delaybutton.OffBackColor = System.Drawing.Color.Black;
            this.delaybutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.delaybutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.delaybutton.OnToggleColor = System.Drawing.Color.White;
            this.delaybutton.Size = new System.Drawing.Size(49, 22);
            this.delaybutton.TabIndex = 2;
            this.delaybutton.UseVisualStyleBackColor = true;
            this.delaybutton.CheckedChanged += new System.EventHandler(this.delaybutton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label2.Size = new System.Drawing.Size(427, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Combat";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 390);
            this.panel3.TabIndex = 0;
            // 
            // rangedtab
            // 
            this.rangedtab.BackColor = System.Drawing.Color.Black;
            this.rangedtab.Controls.Add(this.label15);
            this.rangedtab.Controls.Add(this.label14);
            this.rangedtab.Controls.Add(this.label13);
            this.rangedtab.Controls.Add(this.label12);
            this.rangedtab.Controls.Add(this.label3);
            this.rangedtab.Controls.Add(this.panel4);
            this.rangedtab.Controls.Add(this.reloadanimbutton);
            this.rangedtab.Controls.Add(this.accurbutton);
            this.rangedtab.Controls.Add(this.holdbutton);
            this.rangedtab.Controls.Add(this.fastbutton);
            this.rangedtab.Location = new System.Drawing.Point(4, 23);
            this.rangedtab.Name = "rangedtab";
            this.rangedtab.Size = new System.Drawing.Size(442, 390);
            this.rangedtab.TabIndex = 1;
            this.rangedtab.Text = "Ranged";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(72, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Remove reloading animation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(72, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Max accurancy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(72, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Infinite holding time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(72, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Fast shooting";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label3.Size = new System.Drawing.Size(427, 80);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ranged";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 390);
            this.panel4.TabIndex = 1;
            // 
            // reloadanimbutton
            // 
            this.reloadanimbutton.AutoSize = true;
            this.reloadanimbutton.Location = new System.Drawing.Point(17, 215);
            this.reloadanimbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.reloadanimbutton.Name = "reloadanimbutton";
            this.reloadanimbutton.OffBackColor = System.Drawing.Color.Black;
            this.reloadanimbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reloadanimbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.reloadanimbutton.OnToggleColor = System.Drawing.Color.White;
            this.reloadanimbutton.Size = new System.Drawing.Size(49, 22);
            this.reloadanimbutton.TabIndex = 10;
            this.reloadanimbutton.UseVisualStyleBackColor = true;
            // 
            // accurbutton
            // 
            this.accurbutton.AutoSize = true;
            this.accurbutton.Location = new System.Drawing.Point(17, 171);
            this.accurbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.accurbutton.Name = "accurbutton";
            this.accurbutton.OffBackColor = System.Drawing.Color.Black;
            this.accurbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.accurbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.accurbutton.OnToggleColor = System.Drawing.Color.White;
            this.accurbutton.Size = new System.Drawing.Size(49, 22);
            this.accurbutton.TabIndex = 9;
            this.accurbutton.UseVisualStyleBackColor = true;
            // 
            // holdbutton
            // 
            this.holdbutton.AutoSize = true;
            this.holdbutton.Location = new System.Drawing.Point(17, 127);
            this.holdbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.holdbutton.Name = "holdbutton";
            this.holdbutton.OffBackColor = System.Drawing.Color.Black;
            this.holdbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.holdbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.holdbutton.OnToggleColor = System.Drawing.Color.White;
            this.holdbutton.Size = new System.Drawing.Size(49, 22);
            this.holdbutton.TabIndex = 8;
            this.holdbutton.UseVisualStyleBackColor = true;
            // 
            // fastbutton
            // 
            this.fastbutton.AutoSize = true;
            this.fastbutton.Location = new System.Drawing.Point(17, 83);
            this.fastbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.fastbutton.Name = "fastbutton";
            this.fastbutton.OffBackColor = System.Drawing.Color.Black;
            this.fastbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fastbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.fastbutton.OnToggleColor = System.Drawing.Color.White;
            this.fastbutton.Size = new System.Drawing.Size(49, 22);
            this.fastbutton.TabIndex = 3;
            this.fastbutton.UseVisualStyleBackColor = true;
            // 
            // visualstab
            // 
            this.visualstab.BackColor = System.Drawing.Color.Black;
            this.visualstab.Controls.Add(this.tpvalue);
            this.visualstab.Controls.Add(this.tpslider);
            this.visualstab.Controls.Add(this.label19);
            this.visualstab.Controls.Add(this.label18);
            this.visualstab.Controls.Add(this.fovlabel);
            this.visualstab.Controls.Add(this.fovslider);
            this.visualstab.Controls.Add(this.label17);
            this.visualstab.Controls.Add(this.label16);
            this.visualstab.Controls.Add(this.label4);
            this.visualstab.Controls.Add(this.panel5);
            this.visualstab.Controls.Add(this.tpbutton);
            this.visualstab.Controls.Add(this.fovbutton);
            this.visualstab.Location = new System.Drawing.Point(4, 23);
            this.visualstab.Name = "visualstab";
            this.visualstab.Size = new System.Drawing.Size(442, 390);
            this.visualstab.TabIndex = 2;
            this.visualstab.Text = "Visuals";
            // 
            // tpvalue
            // 
            this.tpvalue.AutoSize = true;
            this.tpvalue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tpvalue.Location = new System.Drawing.Point(376, 201);
            this.tpvalue.Name = "tpvalue";
            this.tpvalue.Size = new System.Drawing.Size(31, 20);
            this.tpvalue.TabIndex = 18;
            this.tpvalue.Text = "100";
            // 
            // tpslider
            // 
            this.tpslider.BackColor = System.Drawing.Color.Black;
            this.tpslider.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tpslider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tpslider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tpslider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.tpslider.DrawSemitransparentThumb = false;
            this.tpslider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.Enabled = false;
            this.tpslider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.tpslider.ForeColor = System.Drawing.Color.White;
            this.tpslider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tpslider.Location = new System.Drawing.Point(150, 198);
            this.tpslider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tpslider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tpslider.MouseEffects = false;
            this.tpslider.Name = "tpslider";
            this.tpslider.Padding = 1;
            this.tpslider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tpslider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tpslider.ShowDivisionsText = false;
            this.tpslider.ShowSmallScale = false;
            this.tpslider.Size = new System.Drawing.Size(200, 28);
            this.tpslider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tpslider.TabIndex = 17;
            this.tpslider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.tpslider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.tpslider.ThumbSize = new System.Drawing.Size(16, 16);
            this.tpslider.TickAdd = 0F;
            this.tpslider.TickColor = System.Drawing.Color.White;
            this.tpslider.TickDivide = 0F;
            this.tpslider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tpslider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.tpslider.ValueChanged += new System.EventHandler(this.tpslider_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label19.Location = new System.Drawing.Point(17, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "TP distance value:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(72, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(214, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Thirdperson distance modifier";
            // 
            // fovlabel
            // 
            this.fovlabel.AutoSize = true;
            this.fovlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fovlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fovlabel.Location = new System.Drawing.Point(331, 118);
            this.fovlabel.Name = "fovlabel";
            this.fovlabel.Size = new System.Drawing.Size(31, 20);
            this.fovlabel.TabIndex = 13;
            this.fovlabel.Text = "100";
            // 
            // fovslider
            // 
            this.fovslider.BackColor = System.Drawing.Color.Black;
            this.fovslider.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.fovslider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.fovslider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.fovslider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.fovslider.DrawSemitransparentThumb = false;
            this.fovslider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.Enabled = false;
            this.fovslider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.fovslider.ForeColor = System.Drawing.Color.White;
            this.fovslider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fovslider.Location = new System.Drawing.Point(102, 115);
            this.fovslider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fovslider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fovslider.MouseEffects = false;
            this.fovslider.Name = "fovslider";
            this.fovslider.Padding = 1;
            this.fovslider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fovslider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fovslider.ShowDivisionsText = false;
            this.fovslider.ShowSmallScale = false;
            this.fovslider.Size = new System.Drawing.Size(200, 28);
            this.fovslider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fovslider.TabIndex = 12;
            this.fovslider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fovslider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.fovslider.ThumbSize = new System.Drawing.Size(16, 16);
            this.fovslider.TickAdd = 0F;
            this.fovslider.TickColor = System.Drawing.Color.White;
            this.fovslider.TickDivide = 0F;
            this.fovslider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.fovslider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.fovslider.ValueChanged += new System.EventHandler(this.fovslider_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label17.Location = new System.Drawing.Point(17, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "FOV value:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(72, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "FOV modifier";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label4.Size = new System.Drawing.Size(427, 80);
            this.label4.TabIndex = 2;
            this.label4.Text = "Visuals";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 390);
            this.panel5.TabIndex = 1;
            // 
            // tpbutton
            // 
            this.tpbutton.AutoSize = true;
            this.tpbutton.Location = new System.Drawing.Point(17, 165);
            this.tpbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.tpbutton.Name = "tpbutton";
            this.tpbutton.OffBackColor = System.Drawing.Color.Black;
            this.tpbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tpbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tpbutton.OnToggleColor = System.Drawing.Color.White;
            this.tpbutton.Size = new System.Drawing.Size(49, 22);
            this.tpbutton.TabIndex = 14;
            this.tpbutton.UseVisualStyleBackColor = true;
            this.tpbutton.CheckedChanged += new System.EventHandler(this.tpbutton_CheckedChanged);
            // 
            // fovbutton
            // 
            this.fovbutton.AutoSize = true;
            this.fovbutton.Location = new System.Drawing.Point(17, 83);
            this.fovbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.fovbutton.Name = "fovbutton";
            this.fovbutton.OffBackColor = System.Drawing.Color.Black;
            this.fovbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fovbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.fovbutton.OnToggleColor = System.Drawing.Color.White;
            this.fovbutton.Size = new System.Drawing.Size(49, 22);
            this.fovbutton.TabIndex = 3;
            this.fovbutton.UseVisualStyleBackColor = true;
            this.fovbutton.CheckedChanged += new System.EventHandler(this.fovbutton_CheckedChanged);
            // 
            // misctab
            // 
            this.misctab.BackColor = System.Drawing.Color.Black;
            this.misctab.Controls.Add(this.label30);
            this.misctab.Controls.Add(this.label28);
            this.misctab.Controls.Add(this.label25);
            this.misctab.Controls.Add(this.dodgevalue);
            this.misctab.Controls.Add(this.dodgeslider);
            this.misctab.Controls.Add(this.label24);
            this.misctab.Controls.Add(this.label23);
            this.misctab.Controls.Add(this.label22);
            this.misctab.Controls.Add(this.label21);
            this.misctab.Controls.Add(this.label20);
            this.misctab.Controls.Add(this.label5);
            this.misctab.Controls.Add(this.panel6);
            this.misctab.Controls.Add(this.voicespam);
            this.misctab.Controls.Add(this.warmupbutton);
            this.misctab.Controls.Add(this.ballistabutton);
            this.misctab.Controls.Add(this.moonwalkbutton);
            this.misctab.Controls.Add(this.sprintbutton);
            this.misctab.Controls.Add(this.restrictbutton);
            this.misctab.Controls.Add(this.afkbutton);
            this.misctab.Location = new System.Drawing.Point(4, 23);
            this.misctab.Name = "misctab";
            this.misctab.Size = new System.Drawing.Size(442, 390);
            this.misctab.TabIndex = 3;
            this.misctab.Text = "Misc";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(334, 83);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 20);
            this.label30.TabIndex = 26;
            this.label30.Text = "Voice spam";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(72, 337);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(217, 20);
            this.label28.TabIndex = 23;
            this.label28.Text = "Allow to move during warmup";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(72, 293);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 20);
            this.label25.TabIndex = 21;
            this.label25.Text = "Ballista ride";
            // 
            // dodgevalue
            // 
            this.dodgevalue.AutoSize = true;
            this.dodgevalue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dodgevalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dodgevalue.Location = new System.Drawing.Point(370, 253);
            this.dodgevalue.Name = "dodgevalue";
            this.dodgevalue.Size = new System.Drawing.Size(25, 20);
            this.dodgevalue.TabIndex = 19;
            this.dodgevalue.Text = "35";
            // 
            // dodgeslider
            // 
            this.dodgeslider.BackColor = System.Drawing.Color.Black;
            this.dodgeslider.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dodgeslider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dodgeslider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dodgeslider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.dodgeslider.DrawSemitransparentThumb = false;
            this.dodgeslider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.Enabled = false;
            this.dodgeslider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.dodgeslider.ForeColor = System.Drawing.Color.White;
            this.dodgeslider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dodgeslider.Location = new System.Drawing.Point(146, 250);
            this.dodgeslider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dodgeslider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dodgeslider.MouseEffects = false;
            this.dodgeslider.Name = "dodgeslider";
            this.dodgeslider.Padding = 1;
            this.dodgeslider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dodgeslider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dodgeslider.ShowDivisionsText = false;
            this.dodgeslider.ShowSmallScale = false;
            this.dodgeslider.Size = new System.Drawing.Size(200, 28);
            this.dodgeslider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dodgeslider.TabIndex = 17;
            this.dodgeslider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dodgeslider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.dodgeslider.ThumbSize = new System.Drawing.Size(16, 16);
            this.dodgeslider.TickAdd = 0F;
            this.dodgeslider.TickColor = System.Drawing.Color.White;
            this.dodgeslider.TickDivide = 0F;
            this.dodgeslider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.dodgeslider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.dodgeslider.ValueChanged += new System.EventHandler(this.dodgeslider_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label24.Location = new System.Drawing.Point(18, 253);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 20);
            this.label24.TabIndex = 16;
            this.label24.Text = "Dodge duration:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(72, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 15;
            this.label23.Text = "Moonwalk";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(72, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 13;
            this.label22.Text = "Faster sprint";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(72, 127);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 20);
            this.label21.TabIndex = 11;
            this.label21.Text = "Remove movement restriction";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(72, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "Anti-AFK";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label5.Size = new System.Drawing.Size(427, 80);
            this.label5.TabIndex = 2;
            this.label5.Text = "Miscellaneous";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 390);
            this.panel6.TabIndex = 1;
            // 
            // voicespam
            // 
            this.voicespam.AutoSize = true;
            this.voicespam.Location = new System.Drawing.Point(279, 83);
            this.voicespam.MinimumSize = new System.Drawing.Size(49, 22);
            this.voicespam.Name = "voicespam";
            this.voicespam.OffBackColor = System.Drawing.Color.Black;
            this.voicespam.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.voicespam.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.voicespam.OnToggleColor = System.Drawing.Color.White;
            this.voicespam.Size = new System.Drawing.Size(49, 22);
            this.voicespam.TabIndex = 25;
            this.voicespam.UseVisualStyleBackColor = true;
            this.voicespam.CheckedChanged += new System.EventHandler(this.voicespam_CheckedChanged);
            // 
            // warmupbutton
            // 
            this.warmupbutton.AutoSize = true;
            this.warmupbutton.Location = new System.Drawing.Point(17, 337);
            this.warmupbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.warmupbutton.Name = "warmupbutton";
            this.warmupbutton.OffBackColor = System.Drawing.Color.Black;
            this.warmupbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.warmupbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.warmupbutton.OnToggleColor = System.Drawing.Color.White;
            this.warmupbutton.Size = new System.Drawing.Size(49, 22);
            this.warmupbutton.TabIndex = 22;
            this.warmupbutton.UseVisualStyleBackColor = true;
            this.warmupbutton.CheckedChanged += new System.EventHandler(this.warmupbutton_CheckedChanged);
            // 
            // ballistabutton
            // 
            this.ballistabutton.AutoSize = true;
            this.ballistabutton.Location = new System.Drawing.Point(17, 293);
            this.ballistabutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.ballistabutton.Name = "ballistabutton";
            this.ballistabutton.OffBackColor = System.Drawing.Color.Black;
            this.ballistabutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ballistabutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ballistabutton.OnToggleColor = System.Drawing.Color.White;
            this.ballistabutton.Size = new System.Drawing.Size(49, 22);
            this.ballistabutton.TabIndex = 20;
            this.ballistabutton.UseVisualStyleBackColor = true;
            this.ballistabutton.CheckedChanged += new System.EventHandler(this.ballistabutton_CheckedChanged);
            // 
            // moonwalkbutton
            // 
            this.moonwalkbutton.AutoSize = true;
            this.moonwalkbutton.Location = new System.Drawing.Point(17, 215);
            this.moonwalkbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.moonwalkbutton.Name = "moonwalkbutton";
            this.moonwalkbutton.OffBackColor = System.Drawing.Color.Black;
            this.moonwalkbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.moonwalkbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.moonwalkbutton.OnToggleColor = System.Drawing.Color.White;
            this.moonwalkbutton.Size = new System.Drawing.Size(49, 22);
            this.moonwalkbutton.TabIndex = 14;
            this.moonwalkbutton.UseVisualStyleBackColor = true;
            this.moonwalkbutton.CheckedChanged += new System.EventHandler(this.moonwalkbutton_CheckedChanged);
            // 
            // sprintbutton
            // 
            this.sprintbutton.AutoSize = true;
            this.sprintbutton.Location = new System.Drawing.Point(17, 171);
            this.sprintbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.sprintbutton.Name = "sprintbutton";
            this.sprintbutton.OffBackColor = System.Drawing.Color.Black;
            this.sprintbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sprintbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.sprintbutton.OnToggleColor = System.Drawing.Color.White;
            this.sprintbutton.Size = new System.Drawing.Size(49, 22);
            this.sprintbutton.TabIndex = 12;
            this.sprintbutton.UseVisualStyleBackColor = true;
            this.sprintbutton.CheckedChanged += new System.EventHandler(this.sprintbutton_CheckedChanged);
            // 
            // restrictbutton
            // 
            this.restrictbutton.AutoSize = true;
            this.restrictbutton.Location = new System.Drawing.Point(17, 127);
            this.restrictbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.restrictbutton.Name = "restrictbutton";
            this.restrictbutton.OffBackColor = System.Drawing.Color.Black;
            this.restrictbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.restrictbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.restrictbutton.OnToggleColor = System.Drawing.Color.White;
            this.restrictbutton.Size = new System.Drawing.Size(49, 22);
            this.restrictbutton.TabIndex = 10;
            this.restrictbutton.UseVisualStyleBackColor = true;
            // 
            // afkbutton
            // 
            this.afkbutton.AutoSize = true;
            this.afkbutton.Location = new System.Drawing.Point(17, 83);
            this.afkbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.afkbutton.Name = "afkbutton";
            this.afkbutton.OffBackColor = System.Drawing.Color.Black;
            this.afkbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.afkbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.afkbutton.OnToggleColor = System.Drawing.Color.White;
            this.afkbutton.Size = new System.Drawing.Size(49, 22);
            this.afkbutton.TabIndex = 3;
            this.afkbutton.UseVisualStyleBackColor = true;
            this.afkbutton.CheckedChanged += new System.EventHandler(this.afkbutton_CheckedChanged);
            // 
            // exploitstab
            // 
            this.exploitstab.BackColor = System.Drawing.Color.Black;
            this.exploitstab.Controls.Add(this.label34);
            this.exploitstab.Controls.Add(this.lagbindbutton);
            this.exploitstab.Controls.Add(this.label33);
            this.exploitstab.Controls.Add(this.button3);
            this.exploitstab.Controls.Add(this.serveridlabel);
            this.exploitstab.Controls.Add(this.ketylabel);
            this.exploitstab.Controls.Add(this.savetoken);
            this.exploitstab.Controls.Add(this.loadtoken);
            this.exploitstab.Controls.Add(this.findtoken);
            this.exploitstab.Controls.Add(this.findid);
            this.exploitstab.Controls.Add(this.exploitstatuslabel);
            this.exploitstab.Controls.Add(this.label26);
            this.exploitstab.Controls.Add(this.label6);
            this.exploitstab.Controls.Add(this.panel7);
            this.exploitstab.Controls.Add(this.lagbutton);
            this.exploitstab.Location = new System.Drawing.Point(4, 23);
            this.exploitstab.Name = "exploitstab";
            this.exploitstab.Size = new System.Drawing.Size(442, 390);
            this.exploitstab.TabIndex = 4;
            this.exploitstab.Text = "Exploits";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(277, 337);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(149, 20);
            this.label34.TabIndex = 30;
            this.label34.Text = "(better to use f-keys)";
            // 
            // lagbindbutton
            // 
            this.lagbindbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lagbindbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lagbindbutton.FlatAppearance.BorderSize = 0;
            this.lagbindbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lagbindbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lagbindbutton.ForeColor = System.Drawing.Color.White;
            this.lagbindbutton.Location = new System.Drawing.Point(162, 329);
            this.lagbindbutton.Name = "lagbindbutton";
            this.lagbindbutton.Size = new System.Drawing.Size(109, 37);
            this.lagbindbutton.TabIndex = 29;
            this.lagbindbutton.TabStop = false;
            this.lagbindbutton.Text = "Bind";
            this.lagbindbutton.UseVisualStyleBackColor = false;
            this.lagbindbutton.Click += new System.EventHandler(this.lagbindbutton_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(72, 337);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 20);
            this.label33.TabIndex = 28;
            this.label33.Text = "Lag exploit";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(21, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 37);
            this.button3.TabIndex = 25;
            this.button3.TabStop = false;
            this.button3.Text = "Items bypass";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // serveridlabel
            // 
            this.serveridlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serveridlabel.ForeColor = System.Drawing.Color.White;
            this.serveridlabel.Location = new System.Drawing.Point(21, 230);
            this.serveridlabel.Name = "serveridlabel";
            this.serveridlabel.Size = new System.Drawing.Size(413, 37);
            this.serveridlabel.TabIndex = 17;
            this.serveridlabel.Text = "Server id: None";
            this.serveridlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ketylabel
            // 
            this.ketylabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ketylabel.ForeColor = System.Drawing.Color.White;
            this.ketylabel.Location = new System.Drawing.Point(21, 200);
            this.ketylabel.Name = "ketylabel";
            this.ketylabel.Size = new System.Drawing.Size(413, 37);
            this.ketylabel.TabIndex = 16;
            this.ketylabel.Text = "Secret-key: None";
            this.ketylabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // savetoken
            // 
            this.savetoken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savetoken.Enabled = false;
            this.savetoken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.savetoken.FlatAppearance.BorderSize = 0;
            this.savetoken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savetoken.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savetoken.ForeColor = System.Drawing.Color.White;
            this.savetoken.Location = new System.Drawing.Point(208, 161);
            this.savetoken.Name = "savetoken";
            this.savetoken.Size = new System.Drawing.Size(180, 37);
            this.savetoken.TabIndex = 15;
            this.savetoken.TabStop = false;
            this.savetoken.Text = "Save";
            this.savetoken.UseVisualStyleBackColor = false;
            this.savetoken.Click += new System.EventHandler(this.savetoken_Click);
            // 
            // loadtoken
            // 
            this.loadtoken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loadtoken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.loadtoken.FlatAppearance.BorderSize = 0;
            this.loadtoken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadtoken.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadtoken.ForeColor = System.Drawing.Color.White;
            this.loadtoken.Location = new System.Drawing.Point(208, 118);
            this.loadtoken.Name = "loadtoken";
            this.loadtoken.Size = new System.Drawing.Size(180, 37);
            this.loadtoken.TabIndex = 14;
            this.loadtoken.TabStop = false;
            this.loadtoken.Text = "Load";
            this.loadtoken.UseVisualStyleBackColor = false;
            this.loadtoken.Click += new System.EventHandler(this.loadtoken_Click);
            // 
            // findtoken
            // 
            this.findtoken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.findtoken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.findtoken.FlatAppearance.BorderSize = 0;
            this.findtoken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findtoken.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findtoken.ForeColor = System.Drawing.Color.White;
            this.findtoken.Location = new System.Drawing.Point(21, 118);
            this.findtoken.Name = "findtoken";
            this.findtoken.Size = new System.Drawing.Size(180, 37);
            this.findtoken.TabIndex = 0;
            this.findtoken.TabStop = false;
            this.findtoken.Text = "Find secret-key";
            this.findtoken.UseVisualStyleBackColor = false;
            this.findtoken.Click += new System.EventHandler(this.findtoken_Click);
            // 
            // findid
            // 
            this.findid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.findid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.findid.FlatAppearance.BorderSize = 0;
            this.findid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findid.ForeColor = System.Drawing.Color.White;
            this.findid.Location = new System.Drawing.Point(21, 161);
            this.findid.Name = "findid";
            this.findid.Size = new System.Drawing.Size(180, 37);
            this.findid.TabIndex = 0;
            this.findid.TabStop = false;
            this.findid.Text = "Find server Id";
            this.findid.UseVisualStyleBackColor = false;
            this.findid.Click += new System.EventHandler(this.findid_Click);
            // 
            // exploitstatuslabel
            // 
            this.exploitstatuslabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exploitstatuslabel.ForeColor = System.Drawing.Color.White;
            this.exploitstatuslabel.Location = new System.Drawing.Point(164, 69);
            this.exploitstatuslabel.Name = "exploitstatuslabel";
            this.exploitstatuslabel.Size = new System.Drawing.Size(265, 37);
            this.exploitstatuslabel.TabIndex = 13;
            this.exploitstatuslabel.Text = "Status: Idle";
            this.exploitstatuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(21, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 20);
            this.label26.TabIndex = 12;
            this.label26.Text = "Account boosting";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label6.Size = new System.Drawing.Size(427, 80);
            this.label6.TabIndex = 2;
            this.label6.Text = "Exploits";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 390);
            this.panel7.TabIndex = 1;
            // 
            // lagbutton
            // 
            this.lagbutton.AutoSize = true;
            this.lagbutton.Location = new System.Drawing.Point(17, 337);
            this.lagbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.lagbutton.Name = "lagbutton";
            this.lagbutton.OffBackColor = System.Drawing.Color.Black;
            this.lagbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lagbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lagbutton.OnToggleColor = System.Drawing.Color.White;
            this.lagbutton.Size = new System.Drawing.Size(49, 22);
            this.lagbutton.TabIndex = 27;
            this.lagbutton.UseVisualStyleBackColor = true;
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.Black;
            this.debug.Controls.Add(this.label37);
            this.debug.Controls.Add(this.label36);
            this.debug.Controls.Add(this.label35);
            this.debug.Controls.Add(this.playfabid);
            this.debug.Controls.Add(this.button4);
            this.debug.Controls.Add(this.button2);
            this.debug.Controls.Add(this.label31);
            this.debug.Controls.Add(this.closeenemy);
            this.debug.Controls.Add(this.realyawlabel);
            this.debug.Controls.Add(this.sukafovlabel);
            this.debug.Controls.Add(this.reqyawlabel);
            this.debug.Controls.Add(this.reqpitchlabel);
            this.debug.Controls.Add(this.hypolabel);
            this.debug.Controls.Add(this.myzlabel);
            this.debug.Controls.Add(this.myylabel);
            this.debug.Controls.Add(this.myxlabel);
            this.debug.Controls.Add(this.enemyzlabel);
            this.debug.Controls.Add(this.enemyylabel);
            this.debug.Controls.Add(this.enemyxlabel);
            this.debug.Controls.Add(this.myyawlabel);
            this.debug.Controls.Add(this.mypitchlabel);
            this.debug.Controls.Add(this.label29);
            this.debug.Controls.Add(this.panel8);
            this.debug.Controls.Add(this.pictureBox1);
            this.debug.Controls.Add(this.spammer);
            this.debug.Controls.Add(this.Wallhack);
            this.debug.Controls.Add(this.toggleButton1);
            this.debug.Controls.Add(this.debugbutton);
            this.debug.Location = new System.Drawing.Point(4, 23);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(442, 390);
            this.debug.TabIndex = 5;
            this.debug.Text = "Debug";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(170, 60);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(72, 20);
            this.label37.TabIndex = 38;
            this.label37.Text = "spammer";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(90, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 20);
            this.label36.TabIndex = 37;
            this.label36.Text = "autoblock";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(21, 61);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 20);
            this.label35.TabIndex = 36;
            this.label35.Text = "debug";
            // 
            // playfabid
            // 
            this.playfabid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.playfabid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playfabid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playfabid.ForeColor = System.Drawing.Color.Gainsboro;
            this.playfabid.Location = new System.Drawing.Point(259, 107);
            this.playfabid.Name = "playfabid";
            this.playfabid.Size = new System.Drawing.Size(175, 26);
            this.playfabid.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(299, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 40);
            this.button4.TabIndex = 33;
            this.button4.TabStop = false;
            this.button4.Text = "Spoof PlayFabID";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(299, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 32;
            this.button2.TabStop = false;
            this.button2.Text = "Send packet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(77, 346);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 20);
            this.label31.TabIndex = 30;
            this.label31.Text = "ballhack";
            // 
            // closeenemy
            // 
            this.closeenemy.AutoSize = true;
            this.closeenemy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeenemy.ForeColor = System.Drawing.Color.White;
            this.closeenemy.Location = new System.Drawing.Point(18, 310);
            this.closeenemy.Name = "closeenemy";
            this.closeenemy.Size = new System.Drawing.Size(77, 20);
            this.closeenemy.TabIndex = 27;
            this.closeenemy.Text = "Good yaw";
            // 
            // realyawlabel
            // 
            this.realyawlabel.AutoSize = true;
            this.realyawlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realyawlabel.ForeColor = System.Drawing.Color.White;
            this.realyawlabel.Location = new System.Drawing.Point(17, 207);
            this.realyawlabel.Name = "realyawlabel";
            this.realyawlabel.Size = new System.Drawing.Size(73, 20);
            this.realyawlabel.TabIndex = 26;
            this.realyawlabel.Text = "Real yaw:";
            // 
            // sukafovlabel
            // 
            this.sukafovlabel.AutoSize = true;
            this.sukafovlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sukafovlabel.ForeColor = System.Drawing.Color.White;
            this.sukafovlabel.Location = new System.Drawing.Point(165, 247);
            this.sukafovlabel.Name = "sukafovlabel";
            this.sukafovlabel.Size = new System.Drawing.Size(39, 20);
            this.sukafovlabel.TabIndex = 24;
            this.sukafovlabel.Text = "fov: ";
            // 
            // reqyawlabel
            // 
            this.reqyawlabel.AutoSize = true;
            this.reqyawlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqyawlabel.ForeColor = System.Drawing.Color.White;
            this.reqyawlabel.Location = new System.Drawing.Point(165, 207);
            this.reqyawlabel.Name = "reqyawlabel";
            this.reqyawlabel.Size = new System.Drawing.Size(100, 20);
            this.reqyawlabel.TabIndex = 23;
            this.reqyawlabel.Text = "Requied yaw:";
            // 
            // reqpitchlabel
            // 
            this.reqpitchlabel.AutoSize = true;
            this.reqpitchlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqpitchlabel.ForeColor = System.Drawing.Color.White;
            this.reqpitchlabel.Location = new System.Drawing.Point(165, 227);
            this.reqpitchlabel.Name = "reqpitchlabel";
            this.reqpitchlabel.Size = new System.Drawing.Size(111, 20);
            this.reqpitchlabel.TabIndex = 22;
            this.reqpitchlabel.Text = "Requied pitch: ";
            // 
            // hypolabel
            // 
            this.hypolabel.AutoSize = true;
            this.hypolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hypolabel.ForeColor = System.Drawing.Color.White;
            this.hypolabel.Location = new System.Drawing.Point(18, 277);
            this.hypolabel.Name = "hypolabel";
            this.hypolabel.Size = new System.Drawing.Size(95, 20);
            this.hypolabel.TabIndex = 21;
            this.hypolabel.Text = "Hypotenuse:";
            // 
            // myzlabel
            // 
            this.myzlabel.AutoSize = true;
            this.myzlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myzlabel.ForeColor = System.Drawing.Color.White;
            this.myzlabel.Location = new System.Drawing.Point(18, 181);
            this.myzlabel.Name = "myzlabel";
            this.myzlabel.Size = new System.Drawing.Size(48, 20);
            this.myzlabel.TabIndex = 20;
            this.myzlabel.Text = "My Z:";
            // 
            // myylabel
            // 
            this.myylabel.AutoSize = true;
            this.myylabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myylabel.ForeColor = System.Drawing.Color.White;
            this.myylabel.Location = new System.Drawing.Point(18, 161);
            this.myylabel.Name = "myylabel";
            this.myylabel.Size = new System.Drawing.Size(48, 20);
            this.myylabel.TabIndex = 19;
            this.myylabel.Text = "My Y:";
            // 
            // myxlabel
            // 
            this.myxlabel.AutoSize = true;
            this.myxlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myxlabel.ForeColor = System.Drawing.Color.White;
            this.myxlabel.Location = new System.Drawing.Point(18, 141);
            this.myxlabel.Name = "myxlabel";
            this.myxlabel.Size = new System.Drawing.Size(48, 20);
            this.myxlabel.TabIndex = 18;
            this.myxlabel.Text = "My X:";
            // 
            // enemyzlabel
            // 
            this.enemyzlabel.AutoSize = true;
            this.enemyzlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyzlabel.ForeColor = System.Drawing.Color.White;
            this.enemyzlabel.Location = new System.Drawing.Point(165, 181);
            this.enemyzlabel.Name = "enemyzlabel";
            this.enemyzlabel.Size = new System.Drawing.Size(72, 20);
            this.enemyzlabel.TabIndex = 17;
            this.enemyzlabel.Text = "Enemy Z:";
            // 
            // enemyylabel
            // 
            this.enemyylabel.AutoSize = true;
            this.enemyylabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyylabel.ForeColor = System.Drawing.Color.White;
            this.enemyylabel.Location = new System.Drawing.Point(165, 161);
            this.enemyylabel.Name = "enemyylabel";
            this.enemyylabel.Size = new System.Drawing.Size(72, 20);
            this.enemyylabel.TabIndex = 16;
            this.enemyylabel.Text = "Enemy Y:";
            // 
            // enemyxlabel
            // 
            this.enemyxlabel.AutoSize = true;
            this.enemyxlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyxlabel.ForeColor = System.Drawing.Color.White;
            this.enemyxlabel.Location = new System.Drawing.Point(165, 141);
            this.enemyxlabel.Name = "enemyxlabel";
            this.enemyxlabel.Size = new System.Drawing.Size(72, 20);
            this.enemyxlabel.TabIndex = 15;
            this.enemyxlabel.Text = "Enemy X:";
            // 
            // myyawlabel
            // 
            this.myyawlabel.AutoSize = true;
            this.myyawlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myyawlabel.ForeColor = System.Drawing.Color.White;
            this.myyawlabel.Location = new System.Drawing.Point(17, 227);
            this.myyawlabel.Name = "myyawlabel";
            this.myyawlabel.Size = new System.Drawing.Size(40, 20);
            this.myyawlabel.TabIndex = 14;
            this.myyawlabel.Text = "Yaw:";
            // 
            // mypitchlabel
            // 
            this.mypitchlabel.AutoSize = true;
            this.mypitchlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mypitchlabel.ForeColor = System.Drawing.Color.White;
            this.mypitchlabel.Location = new System.Drawing.Point(17, 247);
            this.mypitchlabel.Name = "mypitchlabel";
            this.mypitchlabel.Size = new System.Drawing.Size(51, 20);
            this.mypitchlabel.TabIndex = 13;
            this.mypitchlabel.Text = "Pitch: ";
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(15, 0);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label29.Size = new System.Drawing.Size(427, 80);
            this.label29.TabIndex = 3;
            this.label29.Text = "Debug";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 390);
            this.panel8.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(174, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // spammer
            // 
            this.spammer.AutoSize = true;
            this.spammer.Location = new System.Drawing.Point(155, 92);
            this.spammer.MinimumSize = new System.Drawing.Size(49, 22);
            this.spammer.Name = "spammer";
            this.spammer.OffBackColor = System.Drawing.Color.Black;
            this.spammer.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.spammer.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.spammer.OnToggleColor = System.Drawing.Color.White;
            this.spammer.Size = new System.Drawing.Size(49, 22);
            this.spammer.TabIndex = 31;
            this.spammer.UseVisualStyleBackColor = true;
            // 
            // Wallhack
            // 
            this.Wallhack.AutoSize = true;
            this.Wallhack.Location = new System.Drawing.Point(22, 346);
            this.Wallhack.MinimumSize = new System.Drawing.Size(49, 22);
            this.Wallhack.Name = "Wallhack";
            this.Wallhack.OffBackColor = System.Drawing.Color.Black;
            this.Wallhack.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Wallhack.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Wallhack.OnToggleColor = System.Drawing.Color.White;
            this.Wallhack.Size = new System.Drawing.Size(49, 22);
            this.Wallhack.TabIndex = 29;
            this.Wallhack.UseVisualStyleBackColor = true;
            this.Wallhack.CheckedChanged += new System.EventHandler(this.Wallhack_CheckedChanged);
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(89, 92);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(49, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Black;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.toggleButton1.OnToggleColor = System.Drawing.Color.White;
            this.toggleButton1.Size = new System.Drawing.Size(49, 22);
            this.toggleButton1.TabIndex = 25;
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // debugbutton
            // 
            this.debugbutton.AutoSize = true;
            this.debugbutton.Location = new System.Drawing.Point(21, 92);
            this.debugbutton.MinimumSize = new System.Drawing.Size(49, 22);
            this.debugbutton.Name = "debugbutton";
            this.debugbutton.OffBackColor = System.Drawing.Color.Black;
            this.debugbutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.debugbutton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.debugbutton.OnToggleColor = System.Drawing.Color.White;
            this.debugbutton.Size = new System.Drawing.Size(49, 22);
            this.debugbutton.TabIndex = 4;
            this.debugbutton.UseVisualStyleBackColor = true;
            this.debugbutton.CheckedChanged += new System.EventHandler(this.debugbutton_CheckedChanged);
            // 
            // gameclose
            // 
            this.gameclose.Tick += new System.EventHandler(this.gameclose_Tick);
            // 
            // combat
            // 
            this.combat.Interval = 1;
            this.combat.Tick += new System.EventHandler(this.combat_Tick);
            // 
            // PlayerAlive
            // 
            this.PlayerAlive.Interval = 1;
            this.PlayerAlive.Tick += new System.EventHandler(this.PlayerAlive_Tick);
            // 
            // ranged
            // 
            this.ranged.Interval = 1;
            this.ranged.Tick += new System.EventHandler(this.ranged_Tick);
            // 
            // visuals
            // 
            this.visuals.Interval = 1;
            this.visuals.Tick += new System.EventHandler(this.visuals_Tick);
            // 
            // misc
            // 
            this.misc.Interval = 1;
            this.misc.Tick += new System.EventHandler(this.misc_Tick);
            // 
            // menuswitch
            // 
            this.menuswitch.Enabled = true;
            this.menuswitch.Interval = 30;
            this.menuswitch.Tick += new System.EventHandler(this.menuswitch_Tick);
            // 
            // binder
            // 
            this.binder.Interval = 1;
            this.binder.Tick += new System.EventHandler(this.binder_Tick);
            // 
            // idfinder
            // 
            this.idfinder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.idfinder_DoWork);
            // 
            // tokenfinder
            // 
            this.tokenfinder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tokenfinder_DoWork);
            // 
            // Autoblock
            // 
            this.Autoblock.Interval = 1;
            this.Autoblock.Tick += new System.EventHandler(this.Autoblock_Tick);
            // 
            // debuginfo
            // 
            this.debuginfo.Interval = 1;
            this.debuginfo.Tick += new System.EventHandler(this.debuginfo_Tick);
            // 
            // spammertick
            // 
            this.spammertick.Enabled = true;
            this.spammertick.Interval = 1;
            this.spammertick.Tick += new System.EventHandler(this.spammertick_Tick);
            // 
            // loxfab
            // 
            this.loxfab.Interval = 1;
            this.loxfab.Tick += new System.EventHandler(this.loxfab_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epex";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ParentPanel.ResumeLayout(false);
            this.customTabControl1.ResumeLayout(false);
            this.combattab.ResumeLayout(false);
            this.combattab.PerformLayout();
            this.rangedtab.ResumeLayout(false);
            this.rangedtab.PerformLayout();
            this.visualstab.ResumeLayout(false);
            this.visualstab.PerformLayout();
            this.misctab.ResumeLayout(false);
            this.misctab.PerformLayout();
            this.exploitstab.ResumeLayout(false);
            this.exploitstab.PerformLayout();
            this.debug.ResumeLayout(false);
            this.debug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000023 RID: 35
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel ParentPanel;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button CombatButton;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button VisualsButton;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button LongButton;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button MiscButton;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button ExploitsButton;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.CustomTabControl customTabControl1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.TabPage combattab;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.TabPage rangedtab;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.TabPage visualstab;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.TabPage misctab;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.TabPage exploitstab;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Timer gameclose;

		// Token: 0x0400003F RID: 63
		private global::epex.mordhau.recode.Controls.ToggleButton delaybutton;

		// Token: 0x04000040 RID: 64
		private global::epex.mordhau.recode.Controls.ToggleButton turncapbutton;

		// Token: 0x04000041 RID: 65
		private global::epex.mordhau.recode.Controls.ToggleButton combobutton;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000045 RID: 69
		private global::ColorSlider.ColorSlider turncapSlider;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Timer combat;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Timer PlayerAlive;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400004B RID: 75
		private global::epex.mordhau.recode.Controls.ToggleButton fastbutton;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Timer ranged;

		// Token: 0x0400004D RID: 77
		private global::epex.mordhau.recode.Controls.ToggleButton reloadanimbutton;

		// Token: 0x0400004E RID: 78
		private global::epex.mordhau.recode.Controls.ToggleButton accurbutton;

		// Token: 0x0400004F RID: 79
		private global::epex.mordhau.recode.Controls.ToggleButton holdbutton;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Timer visuals;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label fovlabel;

		// Token: 0x04000055 RID: 85
		private global::ColorSlider.ColorSlider fovslider;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000058 RID: 88
		private global::epex.mordhau.recode.Controls.ToggleButton fovbutton;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label tpvalue;

		// Token: 0x0400005A RID: 90
		private global::ColorSlider.ColorSlider tpslider;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400005D RID: 93
		private global::epex.mordhau.recode.Controls.ToggleButton tpbutton;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400005F RID: 95
		private global::epex.mordhau.recode.Controls.ToggleButton sprintbutton;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000061 RID: 97
		private global::epex.mordhau.recode.Controls.ToggleButton restrictbutton;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000063 RID: 99
		private global::epex.mordhau.recode.Controls.ToggleButton afkbutton;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Timer misc;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000066 RID: 102
		private global::epex.mordhau.recode.Controls.ToggleButton moonwalkbutton;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label dodgevalue;

		// Token: 0x04000068 RID: 104
		private global::ColorSlider.ColorSlider dodgeslider;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400006B RID: 107
		private global::epex.mordhau.recode.Controls.ToggleButton ballistabutton;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400006E RID: 110
		private global::epex.mordhau.recode.Controls.ToggleButton animbreaker;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Timer menuswitch;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Button bindbutton;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Timer binder;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000073 RID: 115
		private global::epex.mordhau.recode.Controls.ToggleButton warmupbutton;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label exploitstatuslabel;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Button findid;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Button findtoken;

		// Token: 0x04000077 RID: 119
		private global::System.ComponentModel.BackgroundWorker idfinder;

		// Token: 0x04000078 RID: 120
		private global::System.ComponentModel.BackgroundWorker tokenfinder;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label serveridlabel;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label ketylabel;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Button savetoken;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Button loadtoken;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.TabPage debug;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label label29;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Timer Autoblock;

		// Token: 0x04000081 RID: 129
		private global::epex.mordhau.recode.Controls.ToggleButton debugbutton;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Timer debuginfo;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label myyawlabel;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label mypitchlabel;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label enemyzlabel;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Label enemyylabel;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label enemyxlabel;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label myzlabel;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label myylabel;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label myxlabel;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label hypolabel;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label reqyawlabel;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label reqpitchlabel;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label sukafovlabel;

		// Token: 0x0400008F RID: 143
		private global::epex.mordhau.recode.Controls.ToggleButton toggleButton1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label realyawlabel;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label closeenemy;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000093 RID: 147
		private global::epex.mordhau.recode.Controls.ToggleButton voicespam;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000095 RID: 149
		private global::epex.mordhau.recode.Controls.ToggleButton Wallhack;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000097 RID: 151
		private global::epex.mordhau.recode.Controls.ToggleButton ripostefeint;

		// Token: 0x04000098 RID: 152
		private global::epex.mordhau.recode.Controls.ToggleButton spammer;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Timer spammertick;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TextBox playfabid;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Timer loxfab;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040000A1 RID: 161
		private global::epex.mordhau.recode.Controls.ToggleButton lagbutton;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button lagbindbutton;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
    }
}
