namespace FilterCreator
{
    partial class FreqForm
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
            this.highpass = new System.Windows.Forms.CheckBox();
            this.lowpass = new System.Windows.Forms.CheckBox();
            this.stylebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gobut = new System.Windows.Forms.Button();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.powBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.track = new System.Windows.Forms.TrackBar();
            this.freqbox = new System.Windows.Forms.TextBox();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.SuspendLayout();
            // 
            // highpass
            // 
            this.highpass.AutoSize = true;
            this.highpass.Checked = true;
            this.highpass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highpass.Location = new System.Drawing.Point(9, 42);
            this.highpass.Name = "highpass";
            this.highpass.Size = new System.Drawing.Size(118, 17);
            this.highpass.TabIndex = 0;
            this.highpass.Text = "Высокочастотный";
            this.highpass.UseVisualStyleBackColor = true;
            this.highpass.CheckedChanged += new System.EventHandler(this.highpass_CheckedChanged);
            // 
            // lowpass
            // 
            this.lowpass.AutoSize = true;
            this.lowpass.Location = new System.Drawing.Point(9, 65);
            this.lowpass.Name = "lowpass";
            this.lowpass.Size = new System.Drawing.Size(111, 17);
            this.lowpass.TabIndex = 1;
            this.lowpass.Text = "Низкочастотный";
            this.lowpass.UseVisualStyleBackColor = true;
            this.lowpass.CheckedChanged += new System.EventHandler(this.lowpass_CheckedChanged);
            // 
            // stylebox
            // 
            this.stylebox.Items.AddRange(new object[] {
            "Пробка",
            "Фильтр Гаусса",
            "Фильтр Баттерворта"});
            this.stylebox.Location = new System.Drawing.Point(224, 45);
            this.stylebox.Name = "stylebox";
            this.stylebox.Size = new System.Drawing.Size(186, 21);
            this.stylebox.TabIndex = 2;
            this.stylebox.SelectedIndexChanged += new System.EventHandler(this.stylebox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Частота среза:";
            // 
            // gobut
            // 
            this.gobut.Location = new System.Drawing.Point(113, 251);
            this.gobut.Name = "gobut";
            this.gobut.Size = new System.Drawing.Size(100, 31);
            this.gobut.TabIndex = 5;
            this.gobut.Text = "Фильтровать";
            this.gobut.UseVisualStyleBackColor = true;
            this.gobut.Click += new System.EventHandler(this.gobut_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsBox.Controls.Add(this.track);
            this.settingsBox.Controls.Add(this.powBox);
            this.settingsBox.Controls.Add(this.gobut);
            this.settingsBox.Controls.Add(this.label5);
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.label3);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.freqbox);
            this.settingsBox.Controls.Add(this.stylebox);
            this.settingsBox.Controls.Add(this.highpass);
            this.settingsBox.Controls.Add(this.lowpass);
            this.settingsBox.Location = new System.Drawing.Point(12, 13);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(438, 299);
            this.settingsBox.TabIndex = 6;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Настройки фильтра";
            // 
            // powBox
            // 
            this.powBox.Location = new System.Drawing.Point(278, 262);
            this.powBox.Name = "powBox";
            this.powBox.Size = new System.Drawing.Size(100, 20);
            this.powBox.TabIndex = 7;
            this.powBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Порядок фильтра \r\nБаттерворта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Задайте характеризующие \r\nпараметры:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите функцию фильтра:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Определите смысл фильтра:";
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(121, 120);
            this.track.Maximum = 255;
            this.track.Minimum = 1;
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(257, 45);
            this.track.TabIndex = 8;
            this.track.Value = 1;
            this.track.Scroll += new System.EventHandler(this.track_Scroll);
            // 
            // freqbox
            // 
            this.freqbox.Location = new System.Drawing.Point(6, 145);
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(62, 20);
            this.freqbox.TabIndex = 3;
            this.freqbox.Text = "1";
            this.freqbox.TextChanged += new System.EventHandler(this.freqbox_TextChanged);
            // 
            // FreqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 324);
            this.Controls.Add(this.settingsBox);
            this.Name = "FreqForm";
            this.Text = "FreqForm";
            this.Load += new System.EventHandler(this.FreqForm_Load);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox highpass;
        private System.Windows.Forms.CheckBox lowpass;
        private System.Windows.Forms.ComboBox stylebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gobut;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.TextBox powBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.TextBox freqbox;
    }
}