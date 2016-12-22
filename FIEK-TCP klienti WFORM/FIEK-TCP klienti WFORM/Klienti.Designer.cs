namespace FIEK_TCP_klienti_WFORM
{
    partial class Klienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klienti));
            this.cboZgjedheMetoden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKerkesa = new System.Windows.Forms.TextBox();
            this.txtPergjigja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.menuInfo = new System.Windows.Forms.TextBox();
            this.pnlMbushjaETedhenave = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlButonat = new System.Windows.Forms.Panel();
            this.pnlPergjigja = new System.Windows.Forms.Panel();
            this.pnlButonat2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstKohaaktuale = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tstKohaStartuese = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnDergo = new System.Windows.Forms.Button();
            this.btnPastro = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsdOpsione = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdndryshoPrapavijen = new System.Windows.Forms.ToolStripMenuItem();
            this.ngjyra1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mundesia2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mundesia3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mundesia4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdmbyll = new System.Windows.Forms.ToolStripMenuItem();
            this.tstInfo = new System.Windows.Forms.ToolStripLabel();
            this.info = new System.Windows.Forms.PictureBox();
            this.pnlMbushjaETedhenave.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlButonat.SuspendLayout();
            this.pnlPergjigja.SuspendLayout();
            this.pnlButonat2.SuspendLayout();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // cboZgjedheMetoden
            // 
            this.cboZgjedheMetoden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboZgjedheMetoden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboZgjedheMetoden.FormattingEnabled = true;
            this.cboZgjedheMetoden.Items.AddRange(new object[] {
            "IP",
            "PORT",
            "ZANORE",
            "PRINTO",
            "HOST",
            "TIME",
            "KENO",
            "KONVERTO",
            "FAKTORIEL",
            "MESATARJA",
            "RENDIT",
            "RENDITR",
            "FIEK"});
            this.cboZgjedheMetoden.Location = new System.Drawing.Point(167, 12);
            this.cboZgjedheMetoden.Name = "cboZgjedheMetoden";
            this.cboZgjedheMetoden.Size = new System.Drawing.Size(175, 21);
            this.cboZgjedheMetoden.TabIndex = 1;
            this.cboZgjedheMetoden.SelectedIndexChanged += new System.EventHandler(this.cboZgjedheMetoden_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 90;
            this.label1.Text = "Zgjedhe Metoden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kërkesa:";
            // 
            // txtKerkesa
            // 
            this.txtKerkesa.Enabled = false;
            this.txtKerkesa.Location = new System.Drawing.Point(100, 14);
            this.txtKerkesa.Name = "txtKerkesa";
            this.txtKerkesa.Size = new System.Drawing.Size(245, 20);
            this.txtKerkesa.TabIndex = 2;
            this.txtKerkesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKerkesa_KeyPress);
            // 
            // txtPergjigja
            // 
            this.txtPergjigja.BackColor = System.Drawing.Color.Snow;
            this.txtPergjigja.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPergjigja.Location = new System.Drawing.Point(6, 26);
            this.txtPergjigja.Multiline = true;
            this.txtPergjigja.Name = "txtPergjigja";
            this.txtPergjigja.ReadOnly = true;
            this.txtPergjigja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPergjigja.Size = new System.Drawing.Size(408, 284);
            this.txtPergjigja.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Përgjigja:";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LightCyan;
            this.txtInfo.Location = new System.Drawing.Point(383, 104);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(230, 62);
            this.txtInfo.TabIndex = 93;
            this.txtInfo.Visible = false;
            // 
            // menuInfo
            // 
            this.menuInfo.BackColor = System.Drawing.Color.LightCyan;
            this.menuInfo.Location = new System.Drawing.Point(92, 28);
            this.menuInfo.Multiline = true;
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.ReadOnly = true;
            this.menuInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.menuInfo.Size = new System.Drawing.Size(275, 138);
            this.menuInfo.TabIndex = 95;
            this.menuInfo.Text = resources.GetString("menuInfo.Text");
            this.menuInfo.Visible = false;
            // 
            // pnlMbushjaETedhenave
            // 
            this.pnlMbushjaETedhenave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlMbushjaETedhenave.Controls.Add(this.panel3);
            this.pnlMbushjaETedhenave.Controls.Add(this.panel2);
            this.pnlMbushjaETedhenave.Location = new System.Drawing.Point(10, 62);
            this.pnlMbushjaETedhenave.Name = "pnlMbushjaETedhenave";
            this.pnlMbushjaETedhenave.Size = new System.Drawing.Size(357, 100);
            this.pnlMbushjaETedhenave.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.txtKerkesa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(5, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 43);
            this.panel3.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboZgjedheMetoden);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 56);
            this.panel2.TabIndex = 91;
            // 
            // pnlButonat
            // 
            this.pnlButonat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlButonat.Controls.Add(this.btnDergo);
            this.pnlButonat.Location = new System.Drawing.Point(92, 191);
            this.pnlButonat.Name = "pnlButonat";
            this.pnlButonat.Size = new System.Drawing.Size(125, 40);
            this.pnlButonat.TabIndex = 97;
            // 
            // pnlPergjigja
            // 
            this.pnlPergjigja.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlPergjigja.Controls.Add(this.txtPergjigja);
            this.pnlPergjigja.Controls.Add(this.label3);
            this.pnlPergjigja.Location = new System.Drawing.Point(392, 62);
            this.pnlPergjigja.Name = "pnlPergjigja";
            this.pnlPergjigja.Size = new System.Drawing.Size(420, 315);
            this.pnlPergjigja.TabIndex = 98;
            // 
            // pnlButonat2
            // 
            this.pnlButonat2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlButonat2.Controls.Add(this.btnPastro);
            this.pnlButonat2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlButonat2.Location = new System.Drawing.Point(237, 191);
            this.pnlButonat2.Name = "pnlButonat2";
            this.pnlButonat2.Size = new System.Drawing.Size(127, 40);
            this.pnlButonat2.TabIndex = 99;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdOpsione,
            this.tstInfo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(820, 25);
            this.menu.TabIndex = 94;
            this.menu.Text = "Menu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tstKohaaktuale,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel5,
            this.tstKohaStartuese});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 100;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstKohaaktuale
            // 
            this.tstKohaaktuale.Name = "tstKohaaktuale";
            this.tstKohaaktuale.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tstKohaStartuese
            // 
            this.tstKohaStartuese.Name = "tstKohaStartuese";
            this.tstKohaStartuese.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnDergo
            // 
            this.btnDergo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDergo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDergo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDergo.ForeColor = System.Drawing.Color.Black;
            this.btnDergo.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Fasticon_Fast_Icon_Users_Send;
            this.btnDergo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDergo.Location = new System.Drawing.Point(2, 3);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(120, 33);
            this.btnDergo.TabIndex = 3;
            this.btnDergo.Text = "  Dergo";
            this.btnDergo.UseVisualStyleBackColor = false;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // btnPastro
            // 
            this.btnPastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPastro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPastro.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastro.ForeColor = System.Drawing.Color.Black;
            this.btnPastro.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Custom_Icon_Design_Flatastic_9_Backup_restore;
            this.btnPastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPastro.Location = new System.Drawing.Point(4, 3);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(119, 33);
            this.btnPastro.TabIndex = 4;
            this.btnPastro.Text = "   Pastro";
            this.btnPastro.UseVisualStyleBackColor = false;
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Network_time_icon;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 16);
            this.toolStripStatusLabel1.Text = "Koha aktuale:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Bogo_D_Project_Stopwatch_Off;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(104, 16);
            this.toolStripStatusLabel5.Text = "Koha Startuese:";
            // 
            // tsdOpsione
            // 
            this.tsdOpsione.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdndryshoPrapavijen,
            this.tsdmbyll});
            this.tsdOpsione.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Ampeross_Qetto_2_Settings;
            this.tsdOpsione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsdOpsione.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdOpsione.Name = "tsdOpsione";
            this.tsdOpsione.Size = new System.Drawing.Size(80, 22);
            this.tsdOpsione.Text = "Opsione";
            // 
            // tsdndryshoPrapavijen
            // 
            this.tsdndryshoPrapavijen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngjyra1ToolStripMenuItem,
            this.mundesia2ToolStripMenuItem,
            this.mundesia3ToolStripMenuItem,
            this.mundesia4ToolStripMenuItem});
            this.tsdndryshoPrapavijen.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_fill_color;
            this.tsdndryshoPrapavijen.Name = "tsdndryshoPrapavijen";
            this.tsdndryshoPrapavijen.Size = new System.Drawing.Size(177, 22);
            this.tsdndryshoPrapavijen.Text = "Ndrysho Prapavijen";
            // 
            // ngjyra1ToolStripMenuItem
            // 
            this.ngjyra1ToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ngjyra1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ngjyra1ToolStripMenuItem.Image")));
            this.ngjyra1ToolStripMenuItem.Name = "ngjyra1ToolStripMenuItem";
            this.ngjyra1ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ngjyra1ToolStripMenuItem.Text = "LightSteelBlue";
            this.ngjyra1ToolStripMenuItem.Click += new System.EventHandler(this.ngjyra1ToolStripMenuItem_Click);
            // 
            // mundesia2ToolStripMenuItem
            // 
            this.mundesia2ToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mundesia2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mundesia2ToolStripMenuItem.Image")));
            this.mundesia2ToolStripMenuItem.Name = "mundesia2ToolStripMenuItem";
            this.mundesia2ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mundesia2ToolStripMenuItem.Text = "LightSkyBlue";
            this.mundesia2ToolStripMenuItem.Click += new System.EventHandler(this.mundesia2ToolStripMenuItem_Click);
            // 
            // mundesia3ToolStripMenuItem
            // 
            this.mundesia3ToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.mundesia3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mundesia3ToolStripMenuItem.Image")));
            this.mundesia3ToolStripMenuItem.Name = "mundesia3ToolStripMenuItem";
            this.mundesia3ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mundesia3ToolStripMenuItem.Text = "PaleGreen";
            this.mundesia3ToolStripMenuItem.Click += new System.EventHandler(this.mundesia3ToolStripMenuItem_Click);
            // 
            // mundesia4ToolStripMenuItem
            // 
            this.mundesia4ToolStripMenuItem.BackColor = System.Drawing.Color.Orchid;
            this.mundesia4ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mundesia4ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mundesia4ToolStripMenuItem.Image")));
            this.mundesia4ToolStripMenuItem.Name = "mundesia4ToolStripMenuItem";
            this.mundesia4ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mundesia4ToolStripMenuItem.Text = "Orchid";
            this.mundesia4ToolStripMenuItem.Click += new System.EventHandler(this.mundesia4ToolStripMenuItem_Click);
            // 
            // tsdmbyll
            // 
            this.tsdmbyll.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.tsdmbyll.Name = "tsdmbyll";
            this.tsdmbyll.Size = new System.Drawing.Size(177, 22);
            this.tsdmbyll.Text = "Mbyll";
            this.tsdmbyll.Click += new System.EventHandler(this.tsdmbyll_Click);
            // 
            // tstInfo
            // 
            this.tstInfo.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.Aroche_Delta_Help;
            this.tstInfo.Name = "tstInfo";
            this.tstInfo.Size = new System.Drawing.Size(50, 22);
            this.tstInfo.Text = "INFO";
            this.tstInfo.Click += new System.EventHandler(this.tstInfo_Click);
            // 
            // info
            // 
            this.info.BackgroundImage = global::FIEK_TCP_klienti_WFORM.Properties.Resources.info_icon;
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.Location = new System.Drawing.Point(372, 80);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(19, 18);
            this.info.TabIndex = 91;
            this.info.TabStop = false;
            this.info.Visible = false;
            this.info.MouseLeave += new System.EventHandler(this.info_MouseLeave);
            this.info.MouseHover += new System.EventHandler(this.info_MouseHover);
            // 
            // Klienti
            // 
            this.AcceptButton = this.btnDergo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnPastro;
            this.ClientSize = new System.Drawing.Size(820, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlButonat2);
            this.Controls.Add(this.menuInfo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pnlPergjigja);
            this.Controls.Add(this.pnlButonat);
            this.Controls.Add(this.pnlMbushjaETedhenave);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Klienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klienti";
            this.pnlMbushjaETedhenave.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlButonat.ResumeLayout(false);
            this.pnlPergjigja.ResumeLayout(false);
            this.pnlPergjigja.PerformLayout();
            this.pnlButonat2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDergo;
        private System.Windows.Forms.ComboBox cboZgjedheMetoden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKerkesa;
        private System.Windows.Forms.TextBox txtPergjigja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPastro;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox menuInfo;
        private System.Windows.Forms.Panel pnlMbushjaETedhenave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlButonat;
        private System.Windows.Forms.Panel pnlPergjigja;
        private System.Windows.Forms.Panel pnlButonat2;
        private System.Windows.Forms.ToolStripDropDownButton tsdOpsione;
        private System.Windows.Forms.ToolStripMenuItem tsdndryshoPrapavijen;
        private System.Windows.Forms.ToolStripMenuItem ngjyra1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mundesia2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mundesia3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mundesia4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsdmbyll;
        private System.Windows.Forms.ToolStripLabel tstInfo;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tstKohaaktuale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tstKohaStartuese;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

