namespace Collage_Redactor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотоВКадрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обменКадрамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьКоллажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКадрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьФотоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазмерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКадрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перемещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Area = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.сохранитьКоллажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНарезкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЧастиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЧастиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.целикомToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.загрузитьФотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.нарезкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.Color.DodgerBlue;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton2,
            this.toolStripSeparator4,
            this.toolStripSplitButton1,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripSplitButton3,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.Tools.Location = new System.Drawing.Point(0, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(941, 25);
            this.Tools.Stretch = true;
            this.Tools.TabIndex = 3;
            this.Tools.Text = "Tools";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Collage_Redactor.Properties.Resources._1179272;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton2.Text = "Загрузить фото";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторToolStripMenuItem,
            this.сделатьКоллажToolStripMenuItem,
            this.перемещениеToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::Collage_Redactor.Properties.Resources._890299;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(121, 22);
            this.toolStripSplitButton2.Text = "Режим работы";
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьФотоToolStripMenuItem,
            this.размерностьToolStripMenuItem,
            this.фотоВКадрToolStripMenuItem,
            this.обменКадрамиToolStripMenuItem});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редакторToolStripMenuItem.Text = "Нарезка";
            // 
            // размерностьToolStripMenuItem
            // 
            this.размерностьToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.размерностьToolStripMenuItem.Name = "размерностьToolStripMenuItem";
            this.размерностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размерностьToolStripMenuItem.Text = "Размерность";
            this.размерностьToolStripMenuItem.Click += new System.EventHandler(this.размерностьToolStripMenuItem_Click);
            // 
            // фотоВКадрToolStripMenuItem
            // 
            this.фотоВКадрToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.фотоВКадрToolStripMenuItem.Name = "фотоВКадрToolStripMenuItem";
            this.фотоВКадрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фотоВКадрToolStripMenuItem.Text = "Фото в кадр";
            this.фотоВКадрToolStripMenuItem.Click += new System.EventHandler(this.фотоВКадрToolStripMenuItem_Click);
            // 
            // обменКадрамиToolStripMenuItem
            // 
            this.обменКадрамиToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.обменКадрамиToolStripMenuItem.Name = "обменКадрамиToolStripMenuItem";
            this.обменКадрамиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обменКадрамиToolStripMenuItem.Text = "Обмен кадрами";
            this.обменКадрамиToolStripMenuItem.Click += new System.EventHandler(this.обменКадрамиToolStripMenuItem_Click);
            // 
            // сделатьКоллажToolStripMenuItem
            // 
            this.сделатьКоллажToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.сделатьКоллажToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФонToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.добавитьКадрToolStripMenuItem,
            this.загрузитьФотоToolStripMenuItem1,
            this.изменитьРазмерыToolStripMenuItem,
            this.удалитьКадрToolStripMenuItem});
            this.сделатьКоллажToolStripMenuItem.Name = "сделатьКоллажToolStripMenuItem";
            this.сделатьКоллажToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сделатьКоллажToolStripMenuItem.Text = "Коллаж";
            // 
            // добавитьКадрToolStripMenuItem
            // 
            this.добавитьКадрToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.добавитьКадрToolStripMenuItem.Name = "добавитьКадрToolStripMenuItem";
            this.добавитьКадрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьКадрToolStripMenuItem.Text = "Добавить кадр";
            this.добавитьКадрToolStripMenuItem.Click += new System.EventHandler(this.добавитьКадрToolStripMenuItem_Click);
            // 
            // загрузитьФотоToolStripMenuItem1
            // 
            this.загрузитьФотоToolStripMenuItem1.BackColor = System.Drawing.Color.LightBlue;
            this.загрузитьФотоToolStripMenuItem1.Name = "загрузитьФотоToolStripMenuItem1";
            this.загрузитьФотоToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.загрузитьФотоToolStripMenuItem1.Text = "Добавить фото";
            this.загрузитьФотоToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьФотоToolStripMenuItem1_Click);
            // 
            // изменитьРазмерыToolStripMenuItem
            // 
            this.изменитьРазмерыToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.изменитьРазмерыToolStripMenuItem.Name = "изменитьРазмерыToolStripMenuItem";
            this.изменитьРазмерыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьРазмерыToolStripMenuItem.Text = "Изменить размеры";
            this.изменитьРазмерыToolStripMenuItem.Click += new System.EventHandler(this.изменитьРазмерыToolStripMenuItem_Click);
            // 
            // удалитьКадрToolStripMenuItem
            // 
            this.удалитьКадрToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.удалитьКадрToolStripMenuItem.Name = "удалитьКадрToolStripMenuItem";
            this.удалитьКадрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьКадрToolStripMenuItem.Text = "Удалить кадр";
            this.удалитьКадрToolStripMenuItem.Click += new System.EventHandler(this.удалитьКадрToolStripMenuItem_Click);
            // 
            // перемещениеToolStripMenuItem
            // 
            this.перемещениеToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.перемещениеToolStripMenuItem.Name = "перемещениеToolStripMenuItem";
            this.перемещениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перемещениеToolStripMenuItem.Text = "Перемещение";
            this.перемещениеToolStripMenuItem.Click += new System.EventHandler(this.перемещениеToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНарезкуToolStripMenuItem,
            this.сохранитьКоллажToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Collage_Redactor.Properties.Resources._1221721;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripSplitButton1.Text = "Сохранить";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Collage_Redactor.Properties.Resources.premium_icon_reset_3935969;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Сбросить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Collage_Redactor.Properties.Resources._417090;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton5.Text = "Играть";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // Area
            // 
            this.Area.AutoScroll = true;
            this.Area.BackColor = System.Drawing.Color.LightBlue;
            this.Area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Area.Location = new System.Drawing.Point(0, 25);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(941, 482);
            this.Area.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // сохранитьКоллажToolStripMenuItem
            // 
            this.сохранитьКоллажToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.сохранитьКоллажToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЧастиToolStripMenuItem1,
            this.целикомToolStripMenuItem1});
            this.сохранитьКоллажToolStripMenuItem.Name = "сохранитьКоллажToolStripMenuItem";
            this.сохранитьКоллажToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКоллажToolStripMenuItem.Text = "Сохранить коллаж";
            // 
            // сохранитьНарезкуToolStripMenuItem
            // 
            this.сохранитьНарезкуToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.сохранитьНарезкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЧастиToolStripMenuItem,
            this.целикомToolStripMenuItem});
            this.сохранитьНарезкуToolStripMenuItem.Name = "сохранитьНарезкуToolStripMenuItem";
            this.сохранитьНарезкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьНарезкуToolStripMenuItem.Text = "Сохранить нарезку";
            // 
            // всеЧастиToolStripMenuItem
            // 
            this.всеЧастиToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.всеЧастиToolStripMenuItem.Name = "всеЧастиToolStripMenuItem";
            this.всеЧастиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеЧастиToolStripMenuItem.Text = "Все части";
            this.всеЧастиToolStripMenuItem.Click += new System.EventHandler(this.всеЧастиToolStripMenuItem_Click);
            // 
            // целикомToolStripMenuItem
            // 
            this.целикомToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.целикомToolStripMenuItem.Name = "целикомToolStripMenuItem";
            this.целикомToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.целикомToolStripMenuItem.Text = "Целиком";
            this.целикомToolStripMenuItem.Click += new System.EventHandler(this.целикомToolStripMenuItem_Click);
            // 
            // всеЧастиToolStripMenuItem1
            // 
            this.всеЧастиToolStripMenuItem1.BackColor = System.Drawing.Color.LightBlue;
            this.всеЧастиToolStripMenuItem1.Name = "всеЧастиToolStripMenuItem1";
            this.всеЧастиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.всеЧастиToolStripMenuItem1.Text = "Все части";
            this.всеЧастиToolStripMenuItem1.Click += new System.EventHandler(this.всеЧастиToolStripMenuItem1_Click);
            // 
            // целикомToolStripMenuItem1
            // 
            this.целикомToolStripMenuItem1.BackColor = System.Drawing.Color.LightBlue;
            this.целикомToolStripMenuItem1.Name = "целикомToolStripMenuItem1";
            this.целикомToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.целикомToolStripMenuItem1.Text = "Целиком";
            this.целикомToolStripMenuItem1.Click += new System.EventHandler(this.целикомToolStripMenuItem1_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // загрузитьФотоToolStripMenuItem
            // 
            this.загрузитьФотоToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.загрузитьФотоToolStripMenuItem.Name = "загрузитьФотоToolStripMenuItem";
            this.загрузитьФотоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьФотоToolStripMenuItem.Text = "Загрузить фото";
            this.загрузитьФотоToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // добавитьФонToolStripMenuItem
            // 
            this.добавитьФонToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.добавитьФонToolStripMenuItem.Name = "добавитьФонToolStripMenuItem";
            this.добавитьФонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьФонToolStripMenuItem.Text = "Добавить фон";
            this.добавитьФонToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарезкуToolStripMenuItem,
            this.коллажToolStripMenuItem});
            this.toolStripSplitButton3.Image = global::Collage_Redactor.Properties.Resources._1257477;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(78, 22);
            this.toolStripSplitButton3.Text = "Печать";
            // 
            // нарезкуToolStripMenuItem
            // 
            this.нарезкуToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.нарезкуToolStripMenuItem.Name = "нарезкуToolStripMenuItem";
            this.нарезкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.нарезкуToolStripMenuItem.Text = "Нарезку";
            this.нарезкуToolStripMenuItem.Click += new System.EventHandler(this.нарезкуToolStripMenuItem_Click);
            // 
            // коллажToolStripMenuItem
            // 
            this.коллажToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.коллажToolStripMenuItem.Name = "коллажToolStripMenuItem";
            this.коллажToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.коллажToolStripMenuItem.Text = "Коллаж";
            this.коллажToolStripMenuItem.Click += new System.EventHandler(this.коллажToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 507);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Tools);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Фото редактор";
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.Panel Area;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьКоллажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКадрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКадрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФотоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазмерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотоВКадрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обменКадрамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem перемещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКоллажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНарезкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЧастиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целикомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЧастиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem целикомToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФотоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem нарезкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллажToolStripMenuItem;
    }
}

