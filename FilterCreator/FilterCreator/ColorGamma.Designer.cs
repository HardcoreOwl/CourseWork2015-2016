namespace FilterCreator
{
    partial class ColorGamma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.instruct = new System.Windows.Forms.Label();
            this.apply_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue:";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(77, 36);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 20);
            this.R.TabIndex = 3;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(77, 62);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(100, 20);
            this.G.TabIndex = 4;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(77, 88);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 5;
            // 
            // instruct
            // 
            this.instruct.AutoSize = true;
            this.instruct.Location = new System.Drawing.Point(27, 9);
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(164, 13);
            this.instruct.TabIndex = 6;
            this.instruct.Text = "Введите значения от 0,1 до 5,0";
            // 
            // apply_but
            // 
            this.apply_but.Location = new System.Drawing.Point(207, 86);
            this.apply_but.Name = "apply_but";
            this.apply_but.Size = new System.Drawing.Size(75, 23);
            this.apply_but.TabIndex = 7;
            this.apply_but.Text = "Принять";
            this.apply_but.UseVisualStyleBackColor = true;
            this.apply_but.Click += new System.EventHandler(this.apply_but_Click);
            // 
            // ColorGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 120);
            this.Controls.Add(this.apply_but);
            this.Controls.Add(this.instruct);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorGamma";
            this.Text = "Color/Gamma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label instruct;
        private System.Windows.Forms.Button apply_but;
    }
}