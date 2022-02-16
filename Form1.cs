using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Redactor
{
    public partial class Form1 : Form
    {
        Gallery gallery; //объект класса галереи
        Collage collage = new Collage(); //объект класса коллаж

        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьКадрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gallery == null) 
            {
                int width = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите длину панели"));
                int height = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите ширину панели"));
                collage.AddCollage(width, height, Area);
                Gallery.ClickFlag = false;
            }
            else MessageBox.Show("Сначала сбросьте настройки. Нельзя работать в двух режимах сразу!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void размерностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите количество строк"));
            int columns = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите количество столбцов"));

            Area.Controls.Clear(); //очистка панели

            if (Area.BackgroundImage != null)
            {
                try
                {
                    if (rows <= 50 && columns <= 50)
                    {
                        gallery = new Gallery(rows, columns, Area.BackgroundImage);
                        gallery.Initialize(Area);
                    }
                    else MessageBox.Show("Размеры больше чем 50 на 50 делать не рекомендуется!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("Некорректно введены данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } //создание коллажа
            else MessageBox.Show("Сначала загрузите изображение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void загрузитьФотоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelArea.IsCollage = false;
            MessageBox.Show("Для загрузки фото в кадр, дважды кликните по нему мышкой и выберите фото", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void изменитьРазмерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelArea.IsCollage = true;
            MessageBox.Show("Для изменения размеров кадра, дважды кликните по нему мышкой и введите значения", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void фотоВКадрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelArea.IsCollage = false;
            MessageBox.Show("Для загрузки фото в кадр, дважды кликните по нему мышкой и выберите фото", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void удалитьКадрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите номер кадра"));
            try
            {
                collage.DelCollage(id, Area);
            }
            catch
            {
                MessageBox.Show("Некорректный номер или его не существует!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void обменКадрамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для обмена кадрами кликните левой кнопкой мыши по кадру, затем правой кнопкой на тот, с которым нужно поменять местами", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gallery.ClickFlag = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Area.Controls.Clear();
            Area.BackgroundImage = null;
            collage = null;
            gallery = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Area.Controls.Clear(); //очистка панели для нового изображения
                    Area.BackgroundImage = Image.FromFile(openFileDialog1.FileName); //выбор картинки
                }
            }
            catch
            {
                MessageBox.Show("Некорректно выбрано изображение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } //добавление изображения
        }

        private void перемещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Collage.IsMove = Collage.IsMove ? false : true;
            MessageBox.Show("Режим перемещения "+Collage.IsMove, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нужно собрать из кадров целую картину. Левой и правой кнопками мыши меняйте местами кадры.", "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gallery.GenerateGame();
            PanelArea.IsGame = true;
            Gallery.ClickFlag = true;
            PanelArea.IsCollage = false;
        }

        private void всеЧастиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gallery.SaveImages(saveFileDialog1.FileName);
                MessageBox.Show("Кадры успешно сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } //сохраняем каждый кадр
        }

        private void целикомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gallery.SaveImage(saveFileDialog1.FileName);
                MessageBox.Show("Изображение успешно сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } //сохраняем каждый кадр
        }

        private void всеЧастиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                collage.SaveImages(saveFileDialog1.FileName);
                MessageBox.Show("Кадры успешно сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } //сохраняем каждый кадр
        }

        private void целикомToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                collage.SaveImage(saveFileDialog1.FileName,Area);
                MessageBox.Show("Изображение успешно сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } //сохраняем каждый кадр
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area.BackgroundImage = null; 
            colorDialog1.ShowDialog();
            Area.BackColor = colorDialog1.Color;
        }

        private void нарезкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gallery.Print(printDialog1);
        }

        private void коллажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collage.Print(printDialog1, Area);
        }
    }
}
