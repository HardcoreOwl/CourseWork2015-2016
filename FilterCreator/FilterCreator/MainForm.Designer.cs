namespace FilterCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.kernel_but = new System.Windows.Forms.Button();
            this.h_box = new System.Windows.Forms.TextBox();
            this.w_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mylinf_group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_linear_f = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConvolutionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pixel_box = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImage_but = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqbox = new System.Windows.Forms.GroupBox();
            this.furier_but = new System.Windows.Forms.Button();
            this.Namel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFilter = new System.Windows.Forms.Button();
            this.MFl = new System.Windows.Forms.ComboBox();
            this.undonebut = new System.Windows.Forms.Button();
            this.createNewFilterBut = new System.Windows.Forms.Button();
            this.complexFbox = new System.Windows.Forms.GroupBox();
            this.addChangeBut = new System.Windows.Forms.Button();
            this.Cbut = new System.Windows.Forms.Button();
            this.DeleteCustomBut = new System.Windows.Forms.Button();
            this.mylinf_group.SuspendLayout();
            this.new_linear_f.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.freqbox.SuspendLayout();
            this.complexFbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kernel_but
            // 
            this.kernel_but.Location = new System.Drawing.Point(160, 48);
            this.kernel_but.Name = "kernel_but";
            this.kernel_but.Size = new System.Drawing.Size(95, 27);
            this.kernel_but.TabIndex = 1;
            this.kernel_but.Text = "Задать фильтр";
            this.kernel_but.UseVisualStyleBackColor = true;
            this.kernel_but.Click += new System.EventHandler(this.kernel_but_Click);
            // 
            // h_box
            // 
            this.h_box.Location = new System.Drawing.Point(107, 32);
            this.h_box.Name = "h_box";
            this.h_box.Size = new System.Drawing.Size(47, 20);
            this.h_box.TabIndex = 2;
            this.h_box.Text = "3";
            // 
            // w_box
            // 
            this.w_box.Location = new System.Drawing.Point(107, 55);
            this.w_box.Name = "w_box";
            this.w_box.Size = new System.Drawing.Size(47, 20);
            this.w_box.TabIndex = 3;
            this.w_box.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина матрицы";
            // 
            // mylinf_group
            // 
            this.mylinf_group.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mylinf_group.Controls.Add(this.label1);
            this.mylinf_group.Controls.Add(this.kernel_but);
            this.mylinf_group.Controls.Add(this.w_box);
            this.mylinf_group.Controls.Add(this.label2);
            this.mylinf_group.Controls.Add(this.h_box);
            this.mylinf_group.Location = new System.Drawing.Point(9, 122);
            this.mylinf_group.Name = "mylinf_group";
            this.mylinf_group.Size = new System.Drawing.Size(263, 94);
            this.mylinf_group.TabIndex = 6;
            this.mylinf_group.TabStop = false;
            this.mylinf_group.Text = "Создание матрицы свертки для пользовательского фильтра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина матрицы";
            // 
            // new_linear_f
            // 
            this.new_linear_f.BackColor = System.Drawing.SystemColors.ControlDark;
            this.new_linear_f.Controls.Add(this.label4);
            this.new_linear_f.Controls.Add(this.ConvolutionBox);
            this.new_linear_f.Controls.Add(this.mylinf_group);
            this.new_linear_f.Controls.Add(this.label3);
            this.new_linear_f.Controls.Add(this.pixel_box);
            this.new_linear_f.Location = new System.Drawing.Point(12, 19);
            this.new_linear_f.Name = "new_linear_f";
            this.new_linear_f.Size = new System.Drawing.Size(292, 223);
            this.new_linear_f.TabIndex = 17;
            this.new_linear_f.TabStop = false;
            this.new_linear_f.Text = "Фильтрация в пространственной области";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Готовые матричные фильтры";
            // 
            // ConvolutionBox
            // 
            this.ConvolutionBox.Items.AddRange(new object[] {
            "",
            "Размытие 3x3",
            "Размытие по Гауссу",
            "Выделение границ",
            "Повышение контраста"});
            this.ConvolutionBox.Location = new System.Drawing.Point(9, 95);
            this.ConvolutionBox.Name = "ConvolutionBox";
            this.ConvolutionBox.Size = new System.Drawing.Size(260, 21);
            this.ConvolutionBox.TabIndex = 29;
            this.ConvolutionBox.SelectedIndexChanged += new System.EventHandler(this.ConvolutionBox_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пиксельные фильтры";
            // 
            // pixel_box
            // 
            this.pixel_box.Items.AddRange(new object[] {
            "",
            "Грейскейл",
            "Негатив",
            "Яркость",
            "Гамма",
            "Цвет",
            "Контраст"});
            this.pixel_box.Location = new System.Drawing.Point(6, 43);
            this.pixel_box.Name = "pixel_box";
            this.pixel_box.Size = new System.Drawing.Size(266, 21);
            this.pixel_box.TabIndex = 29;
            this.pixel_box.SelectedIndexChanged += new System.EventHandler(this.pixel_box_SelectedIndexChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изображениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImage_but,
            this.сохранитьToolStripMenuItem});
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            // 
            // openImage_but
            // 
            this.openImage_but.Name = "openImage_but";
            this.openImage_but.Size = new System.Drawing.Size(152, 22);
            this.openImage_but.Text = "Открыть";
            this.openImage_but.Click += new System.EventHandler(this.openImage_but_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // freqbox
            // 
            this.freqbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.freqbox.Controls.Add(this.furier_but);
            this.freqbox.Location = new System.Drawing.Point(12, 248);
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(292, 63);
            this.freqbox.TabIndex = 22;
            this.freqbox.TabStop = false;
            this.freqbox.Text = "Фильтрация в частотной области";
            // 
            // furier_but
            // 
            this.furier_but.Location = new System.Drawing.Point(6, 19);
            this.furier_but.Name = "furier_but";
            this.furier_but.Size = new System.Drawing.Size(154, 35);
            this.furier_but.TabIndex = 1;
            this.furier_but.Text = "Задать частотный фильтр";
            this.furier_but.UseVisualStyleBackColor = true;
            this.furier_but.Click += new System.EventHandler(this.furier_but_Click);
            // 
            // Namel
            // 
            this.Namel.Location = new System.Drawing.Point(661, 37);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(164, 20);
            this.Namel.TabIndex = 25;
            this.Namel.Text = "Новый фильтр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Название моего фильтра:";
            // 
            // saveFilter
            // 
            this.saveFilter.Location = new System.Drawing.Point(716, 63);
            this.saveFilter.Name = "saveFilter";
            this.saveFilter.Size = new System.Drawing.Size(120, 27);
            this.saveFilter.TabIndex = 27;
            this.saveFilter.Text = "Сохранить фильтр";
            this.saveFilter.UseVisualStyleBackColor = true;
            this.saveFilter.Click += new System.EventHandler(this.saveFilter_Click);
            // 
            // MFl
            // 
            this.MFl.Location = new System.Drawing.Point(521, 473);
            this.MFl.Name = "MFl";
            this.MFl.Size = new System.Drawing.Size(211, 21);
            this.MFl.TabIndex = 28;
            this.MFl.SelectedIndexChanged += new System.EventHandler(this.MFl_SelectedIndexChanged);
            // 
            // undonebut
            // 
            this.undonebut.Location = new System.Drawing.Point(178, 317);
            this.undonebut.Name = "undonebut";
            this.undonebut.Size = new System.Drawing.Size(123, 34);
            this.undonebut.TabIndex = 30;
            this.undonebut.Text = "Отменить";
            this.undonebut.UseVisualStyleBackColor = true;
            this.undonebut.Click += new System.EventHandler(this.undonebut_Click);
            // 
            // createNewFilterBut
            // 
            this.createNewFilterBut.Location = new System.Drawing.Point(521, 63);
            this.createNewFilterBut.Name = "createNewFilterBut";
            this.createNewFilterBut.Size = new System.Drawing.Size(116, 27);
            this.createNewFilterBut.TabIndex = 31;
            this.createNewFilterBut.Text = "Создать";
            this.createNewFilterBut.UseVisualStyleBackColor = true;
            this.createNewFilterBut.Click += new System.EventHandler(this.createNewFilterBut_Click);
            // 
            // complexFbox
            // 
            this.complexFbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.complexFbox.Controls.Add(this.addChangeBut);
            this.complexFbox.Controls.Add(this.undonebut);
            this.complexFbox.Controls.Add(this.freqbox);
            this.complexFbox.Controls.Add(this.new_linear_f);
            this.complexFbox.Enabled = false;
            this.complexFbox.Location = new System.Drawing.Point(521, 99);
            this.complexFbox.Name = "complexFbox";
            this.complexFbox.Size = new System.Drawing.Size(315, 357);
            this.complexFbox.TabIndex = 30;
            this.complexFbox.TabStop = false;
            this.complexFbox.Text = "Создание сложносоставного фильтра";
            // 
            // addChangeBut
            // 
            this.addChangeBut.Location = new System.Drawing.Point(12, 317);
            this.addChangeBut.Name = "addChangeBut";
            this.addChangeBut.Size = new System.Drawing.Size(160, 34);
            this.addChangeBut.TabIndex = 32;
            this.addChangeBut.Text = "Добавить последнее изменение";
            this.addChangeBut.UseVisualStyleBackColor = true;
            this.addChangeBut.Click += new System.EventHandler(this.addChangeBut_Click);
            // 
            // Cbut
            // 
            this.Cbut.Location = new System.Drawing.Point(738, 462);
            this.Cbut.Name = "Cbut";
            this.Cbut.Size = new System.Drawing.Size(98, 32);
            this.Cbut.TabIndex = 32;
            this.Cbut.Text = "Использовать";
            this.Cbut.UseVisualStyleBackColor = true;
            this.Cbut.Click += new System.EventHandler(this.Cbut_Click);
            // 
            // DeleteCustomBut
            // 
            this.DeleteCustomBut.Location = new System.Drawing.Point(606, 500);
            this.DeleteCustomBut.Name = "DeleteCustomBut";
            this.DeleteCustomBut.Size = new System.Drawing.Size(126, 32);
            this.DeleteCustomBut.TabIndex = 33;
            this.DeleteCustomBut.Text = "Удалить фильтр";
            this.DeleteCustomBut.UseVisualStyleBackColor = true;
            this.DeleteCustomBut.Click += new System.EventHandler(this.DeleteCustomBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 544);
            this.Controls.Add(this.DeleteCustomBut);
            this.Controls.Add(this.Cbut);
            this.Controls.Add(this.complexFbox);
            this.Controls.Add(this.createNewFilterBut);
            this.Controls.Add(this.MFl);
            this.Controls.Add(this.saveFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FilterCreator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mylinf_group.ResumeLayout(false);
            this.mylinf_group.PerformLayout();
            this.new_linear_f.ResumeLayout(false);
            this.new_linear_f.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.freqbox.ResumeLayout(false);
            this.complexFbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kernel_but;
        private System.Windows.Forms.TextBox h_box;
        private System.Windows.Forms.TextBox w_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mylinf_group;
        private System.Windows.Forms.GroupBox new_linear_f;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImage_but;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox freqbox;
        private System.Windows.Forms.TextBox Namel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveFilter;
        private System.Windows.Forms.ComboBox ConvolutionBox;
        private System.Windows.Forms.ComboBox MFl;
        private System.Windows.Forms.ComboBox pixel_box;
        private System.Windows.Forms.Button undonebut;
        private System.Windows.Forms.Button createNewFilterBut;
        private System.Windows.Forms.GroupBox complexFbox;
        private System.Windows.Forms.Button addChangeBut;
        private System.Windows.Forms.Button furier_but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cbut;
        private System.Windows.Forms.Button DeleteCustomBut;
    }
}

