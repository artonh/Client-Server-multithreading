namespace FIEK_TCP_klienti_WFORM
{
    partial class Kycja_Fillestare
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
            this.btnPerfundo = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPorti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdKycAuto = new System.Windows.Forms.RadioButton();
            this.rdKycManu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKlikOk = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerfundo
            // 
            this.btnPerfundo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPerfundo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfundo.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.perfundo;
            this.btnPerfundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfundo.Location = new System.Drawing.Point(202, 235);
            this.btnPerfundo.Name = "btnPerfundo";
            this.btnPerfundo.Size = new System.Drawing.Size(147, 38);
            this.btnPerfundo.TabIndex = 9;
            this.btnPerfundo.Text = "   Përfundo";
            this.btnPerfundo.UseVisualStyleBackColor = true;
            this.btnPerfundo.Click += new System.EventHandler(this.btnPerfundo_Click);
            // 
            // txtHost
            // 
            this.txtHost.Enabled = false;
            this.txtHost.Location = new System.Drawing.Point(70, 53);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(73, 20);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::FIEK_TCP_klienti_WFORM.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(89, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 38);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "  OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPorti
            // 
            this.txtPorti.Enabled = false;
            this.txtPorti.Location = new System.Drawing.Point(70, 85);
            this.txtPorti.Name = "txtPorti";
            this.txtPorti.Size = new System.Drawing.Size(73, 20);
            this.txtPorti.TabIndex = 11;
            this.txtPorti.Text = "7000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "PORT:";
            // 
            // rdKycAuto
            // 
            this.rdKycAuto.AutoSize = true;
            this.rdKycAuto.Checked = true;
            this.rdKycAuto.Location = new System.Drawing.Point(29, 3);
            this.rdKycAuto.Name = "rdKycAuto";
            this.rdKycAuto.Size = new System.Drawing.Size(106, 17);
            this.rdKycAuto.TabIndex = 13;
            this.rdKycAuto.TabStop = true;
            this.rdKycAuto.Text = "Kycje automatike";
            this.rdKycAuto.UseVisualStyleBackColor = true;
            this.rdKycAuto.CheckedChanged += new System.EventHandler(this.rdKycAuto_CheckedChanged);
            // 
            // rdKycManu
            // 
            this.rdKycManu.AutoSize = true;
            this.rdKycManu.Location = new System.Drawing.Point(29, 26);
            this.rdKycManu.Name = "rdKycManu";
            this.rdKycManu.Size = new System.Drawing.Size(94, 17);
            this.rdKycManu.TabIndex = 14;
            this.rdKycManu.Text = "Kycje manuale";
            this.rdKycManu.UseVisualStyleBackColor = true;
            this.rdKycManu.CheckedChanged += new System.EventHandler(this.rdKycManu_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPorti);
            this.panel1.Controls.Add(this.rdKycManu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdKycAuto);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(131, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 113);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 60);
            this.label3.TabIndex = 91;
            this.label3.Text = "Keni mundësin të zgjedhni startimin se me cilin HOST dëshironi të komunikoni dhe " +
    "në cilin PORT!";
            // 
            // lblKlikOk
            // 
            this.lblKlikOk.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblKlikOk.Location = new System.Drawing.Point(96, 206);
            this.lblKlikOk.Name = "lblKlikOk";
            this.lblKlikOk.Size = new System.Drawing.Size(253, 26);
            this.lblKlikOk.TabIndex = 92;
            this.lblKlikOk.Text = "Klikoni OK për të vazhduar!";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Kycja_Fillestare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPerfundo;
            this.ClientSize = new System.Drawing.Size(433, 285);
            this.Controls.Add(this.lblKlikOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPerfundo);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Kycja_Fillestare";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kycja Fillestare";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.Kycja_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerfundo;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPorti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdKycAuto;
        private System.Windows.Forms.RadioButton rdKycManu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKlikOk;
        private System.Windows.Forms.Timer timer1;
    }
}