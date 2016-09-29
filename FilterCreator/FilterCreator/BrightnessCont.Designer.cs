namespace FilterCreator
{
    partial class BrightnessCont
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
            this.func = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.apply_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // func
            // 
            this.func.AutoSize = true;
            this.func.Location = new System.Drawing.Point(12, 24);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(55, 13);
            this.func.TabIndex = 0;
            this.func.Text = "Значение";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(84, 21);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(111, 20);
            this.level.TabIndex = 1;
            // 
            // apply_but
            // 
            this.apply_but.Location = new System.Drawing.Point(84, 47);
            this.apply_but.Name = "apply_but";
            this.apply_but.Size = new System.Drawing.Size(93, 23);
            this.apply_but.TabIndex = 2;
            this.apply_but.Text = "Принять";
            this.apply_but.UseVisualStyleBackColor = true;
            this.apply_but.Click += new System.EventHandler(this.apply_but_Click);
            // 
            // BrightnessCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 114);
            this.Controls.Add(this.apply_but);
            this.Controls.Add(this.level);
            this.Controls.Add(this.func);
            this.Name = "BrightnessCont";
            this.Text = "Brightness/Contrast";
            this.Load += new System.EventHandler(this.Brightness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label func;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Button apply_but;
    }
}