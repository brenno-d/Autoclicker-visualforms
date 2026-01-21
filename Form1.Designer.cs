namespace AutoClick
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repeatUntil = new System.Windows.Forms.RadioButton();
            this.repeatUntilStopped = new System.Windows.Forms.RadioButton();
            this.repeatTimes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minuteInterval = new System.Windows.Forms.NumericUpDown();
            this.secondInterval = new System.Windows.Forms.NumericUpDown();
            this.msInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startHotkey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mouseButtonOption = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(137, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(261, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Milliseconds";
            // 
            // repeatUntil
            // 
            this.repeatUntil.AutoSize = true;
            this.repeatUntil.Location = new System.Drawing.Point(436, 40);
            this.repeatUntil.Name = "repeatUntil";
            this.repeatUntil.Size = new System.Drawing.Size(60, 17);
            this.repeatUntil.TabIndex = 8;
            this.repeatUntil.Text = "Repeat";
            this.repeatUntil.UseVisualStyleBackColor = true;
            // 
            // repeatUntilStopped
            // 
            this.repeatUntilStopped.AutoSize = true;
            this.repeatUntilStopped.Checked = true;
            this.repeatUntilStopped.Location = new System.Drawing.Point(436, 77);
            this.repeatUntilStopped.Name = "repeatUntilStopped";
            this.repeatUntilStopped.Size = new System.Drawing.Size(123, 17);
            this.repeatUntilStopped.TabIndex = 9;
            this.repeatUntilStopped.TabStop = true;
            this.repeatUntilStopped.Text = "Repeat until stopped";
            this.repeatUntilStopped.UseVisualStyleBackColor = true;
            // 
            // repeatTimes
            // 
            this.repeatTimes.Location = new System.Drawing.Point(502, 40);
            this.repeatTimes.Name = "repeatTimes";
            this.repeatTimes.Size = new System.Drawing.Size(44, 20);
            this.repeatTimes.TabIndex = 10;
            this.repeatTimes.Text = "1";
            this.repeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(553, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "times";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(48, 297);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(87, 13);
            this.githubLink.TabIndex = 13;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Github repositore";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoClick.Properties.Resources.GitHub_Symbol;
            this.pictureBox1.Location = new System.Drawing.Point(12, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minuteInterval);
            this.groupBox1.Controls.Add(this.secondInterval);
            this.groupBox1.Controls.Add(this.msInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interval per click";
            // 
            // minuteInterval
            // 
            this.minuteInterval.Location = new System.Drawing.Point(32, 48);
            this.minuteInterval.Name = "minuteInterval";
            this.minuteInterval.Size = new System.Drawing.Size(52, 20);
            this.minuteInterval.TabIndex = 23;
            // 
            // secondInterval
            // 
            this.secondInterval.Location = new System.Drawing.Point(140, 48);
            this.secondInterval.Name = "secondInterval";
            this.secondInterval.Size = new System.Drawing.Size(51, 20);
            this.secondInterval.TabIndex = 22;
            // 
            // msInterval
            // 
            this.msInterval.Location = new System.Drawing.Point(236, 48);
            this.msInterval.Name = "msInterval";
            this.msInterval.Size = new System.Drawing.Size(51, 20);
            this.msInterval.TabIndex = 21;
            this.msInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startHotkey);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mouseButtonOption);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(28, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 105);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click options";
            // 
            // startHotkey
            // 
            this.startHotkey.Location = new System.Drawing.Point(126, 53);
            this.startHotkey.MaximumSize = new System.Drawing.Size(120, 25);
            this.startHotkey.MinimumSize = new System.Drawing.Size(100, 25);
            this.startHotkey.Name = "startHotkey";
            this.startHotkey.Size = new System.Drawing.Size(100, 25);
            this.startHotkey.TabIndex = 23;
            this.startHotkey.Text = "F1";
            this.startHotkey.UseVisualStyleBackColor = true;
            this.startHotkey.Click += new System.EventHandler(this.startHotkey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Toggle click hotkey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mouse button";
            // 
            // mouseButtonOption
            // 
            this.mouseButtonOption.FormattingEnabled = true;
            this.mouseButtonOption.Location = new System.Drawing.Point(126, 19);
            this.mouseButtonOption.Name = "mouseButtonOption";
            this.mouseButtonOption.Size = new System.Drawing.Size(121, 21);
            this.mouseButtonOption.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(409, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repeat options";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(409, 134);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(235, 59);
            this.startBtn.TabIndex = 19;
            this.startBtn.Text = "Start click";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(409, 221);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(235, 59);
            this.stop_btn.TabIndex = 20;
            this.stop_btn.Text = "Stop click";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(725, 333);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repeatTimes);
            this.Controls.Add(this.repeatUntilStopped);
            this.Controls.Add(this.repeatUntil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton repeatUntil;
        private System.Windows.Forms.RadioButton repeatUntilStopped;
        private System.Windows.Forms.TextBox repeatTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mouseButtonOption;
        private System.Windows.Forms.Button startHotkey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.NumericUpDown msInterval;
        private System.Windows.Forms.NumericUpDown minuteInterval;
        private System.Windows.Forms.NumericUpDown secondInterval;
    }
}

