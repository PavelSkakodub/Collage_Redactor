using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Collage_Redactor
{
    class Gallery
    {
        private static int Rows { get; set; } //кол-во строк
        private static int Columns { get; set; } //кол-во столбцов
        private static PanelArea[,] collage; //матрица для коллажа
        private static Point[,] game; //массив координат нач.кадров
        private Bitmap image;//изображение для коллажа

        public static bool ClickFlag; //разрешение/запрет на обмен картинок местами

        public Gallery(int Row,int Column, Image img)
        {
            Rows = Row;
            Columns = Column;
            image = new Bitmap(img);
            collage = new PanelArea[Rows, Columns];
            game = new Point[Rows, Columns];
        } //конструктор

        public void Initialize(Panel panel)
        {
            panel.BackgroundImage = null; //убираем картинку у панели

            int id = 0, x = 0, y = 0;
            int width = image.Width / Columns;
            int height = image.Height / Rows;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    collage[i, j] = new PanelArea(++id, new Point(x, y), new Size(width, height));
                    collage[i, j].InitBox(panel);
                    collage[i, j].AddImage(CropImage(image, new Rectangle(x, y, width, height))); //вырезаем часть из картинки
                    x += width;
                }
                y += height; x = 0;
            }
        } //заполнение коллажа
        public void SaveImages(string fileName)
        {
            for (int i = 0; i < Rows; i++) 
            {
                for (int j = 0; j < Columns; j++)
                {
                    collage[i, j].Box.Image.Save(fileName + "(" + collage[i,j].Id + ").jpg");
                }
            }
        } //сохранение всех кадров коллажа
        public void SaveImage(string fileName)
        {
            ImageAssembly().Save(fileName + ".jpg");
        } //сохранение целого изображения
        public void Print(PrintDialog printDialog)
        {
            System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
            Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
            DialogResult result = printDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                Document.Print();
            }

            void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                e.Graphics.DrawImage(ImageAssembly(), new Point(0, 0)); //печать картинки целиком
            }
        } //печать собранной картинки
        public void GenerateGame()
        {
            for(int i = 0; i < Rows;i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    game[i, j] = collage[i,j].Box.Location; //запоминаем координаты нач.кадров
                }
            }
            Random r = new Random(); Point p;
            for (int i = 0; i < Rows * Columns; i++) //меняем рандомно каждый кадр
            {
                //делаем случайные индексы
                int a1 = r.Next(0, Rows);
                int b1 = r.Next(0, Columns);
                int a2 = r.Next(0, Rows);
                int b2 = r.Next(0, Columns);
                ////меняем местами объекты в массиве (для проверки на сборку)
                //PanelArea buf;
                //buf = collage[a1, b1];
                //collage[a1, b1] = collage[a2, b2];
                //collage[a2, b2] = buf;
                //меняем местами кадры с случайными индексами
                p = collage[a1, b1].Box.Location;
                collage[a1, b1].Box.Location = collage[a2, b2].Box.Location;
                collage[a2, b2].Box.Location = p;
            }
        } //случайный разброс кадров

        public static void BoxExchange(PictureBox right)
        {
            Point p;
            for (int i = 0; i < Rows; i++) 
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (collage[i, j].LeftClick) //если была нажата левая кнопка
                    {
                        //устанавливаем начальные значения
                        collage[i, j].Box.BorderStyle = BorderStyle.Fixed3D;
                        collage[i, j].LeftClick = false;
                        //делаем обмен картинками
                        p = collage[i, j].Box.Location;
                        collage[i, j].Box.Location = right.Location;
                        right.Location = p;
                    }
                }
            } //установка значений для обмена
        } //обмен двух картинок
        public static void TestGame()
        {
            int count = 0; //счётчик для айди кадров
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (game[i, j] == collage[i, j].Box.Location) ++count; //если совпадает тек. положение с начальным
                }
            }
            if (count == collage.Length) //если всё совпадает
            MessageBox.Show("Поздравляем! Вы собрали пазл", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //проверка на сборку пазла

        private Bitmap ImageAssembly()
        {
            Bitmap newImage = new Bitmap(collage[0, 0].Box.Width * Columns, collage[0, 0].Box.Height * Rows);
            Graphics g = Graphics.FromImage(newImage);
            for (int i = 0; i < Rows; i++) 
            {
                for (int j = 0; j < Columns; j++) 
                {
                    g.DrawImage(collage[i, j].Box.Image, collage[i, j].Box.Location);
                }
            }
            return newImage;
        } //сборка изображения из частей
        private Bitmap CropImage(Bitmap source, Rectangle section)
        {
            //создаём картинку нужных размеров
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // начало координат это верхний левый угол картинки
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        } //вырезаем изображение из основного

    } //класс для создания нарезки

    class Collage
    {
        public static bool IsMove; //проверка на перемещение

        private int count = 0; //счётчик для панелей
        private List<PanelArea> panels = new List<PanelArea>(); //панели с кадрами

        public Collage() { }

        public void AddCollage(int width, int height,Panel panel)
        {
            panels.Add(new PanelArea(++count, new Point(panel.Width / 2, panel.Height / 2), new Size(width, height)));
            panels[count - 1].InitBox(panel); //инициализация панели
            IsMove = true; //для перемещения
        } //добавление кадра коллажа
        public void DelCollage(int Id,Panel panel)
        {
            panel.Controls.Remove(panels[Id - 1].Box);
            panels.Remove(panels[Id - 1]);
            count--;
        } //удаление кадра
        public void SaveImages(string fileName)
        {
            for (int i = 0; i < panels.Count; i++) 
            {
                panels[i].Box.Image.Save(fileName + "(" + panels[i].Id + ").jpg");
            }
        } //сохранение всех кадров
        public void SaveImage(string fileName, Panel area)
        {
            //сохраняем как скриншот панели с кадрами
            Bitmap newImage = new Bitmap(area.Width, area.Height);
            area.DrawToBitmap(newImage,area.ClientRectangle);
            newImage.Save(fileName + ".jpg");
        } //сохраняем коллаж целиком
        public void Print(PrintDialog printDialog, Panel area)
        {
            Bitmap newImage = new Bitmap(area.Width, area.Height);
            area.DrawToBitmap(newImage, area.ClientRectangle);

            System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
            Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Document.Print();
            }

            void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                e.Graphics.DrawImage(newImage, new Point(0, 0)); //печать картинки целиком
            }
        } //печать картинки панели с кадрами
    } //класс для создания коллажа

    class PanelArea
    {
        private Point Location { get; set; } //координаты 
        private Size Size { get; set; } //размеры
        private bool IsMove; //проверка на перемещение

        public int Id { get; set; } //айди 
        public PictureBox Box; //панель для картинки
        public bool LeftClick; //клик левой кнопкой

        public static bool IsCollage; //проверка на изменение размеров
        public static bool IsGame; //проверка на режим игры

        public PanelArea(int id, Point location, Size size)
        {
            Id = id;
            Location = location;
            Size = size;
        }

        public void InitBox(Panel area)
        {
            Box = new PictureBox();
            Box.Size = Size;
            Box.Location = Location;
            Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Box.BackColor = Color.DeepSkyBlue;
            Box.BorderStyle = BorderStyle.Fixed3D;
            area.Controls.Add(Box);
            Box.MouseClick += Box_MouseClick;
            Box.MouseDoubleClick += Box_MouseDoubleClick;
            Box.MouseDown += Box_MouseDown;
            Box.MouseUp += Box_MouseUp;
            Box.MouseMove += Box_MouseMove;
        } //инициализация и добавление панели
        public void AddImage(Bitmap img)
        {
            Box.Image = img;
        } //дбавление картинки

        private void Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (Gallery.ClickFlag)  //если разрешено сделать обмен
            {
                if (e.Button == MouseButtons.Left) //если левая кнопка то смещаем картинку для видимости
                {
                    LeftClick = true;
                    Box.BorderStyle = BorderStyle.None; //убираем рамку для видимости клика
                }
                if (e.Button == MouseButtons.Right) //если правая кнопка то делаем обмен картинками
                {
                    Gallery.BoxExchange(Box); //вызов метода для обмена с передачей текущей панели
                    if (IsGame) //если был обмен кадрами и это режим игры
                    {
                        Gallery.TestGame(); //проверка на целую картину
                    }
                }
            }
        } //обработка клика для обмена картинки
        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsCollage)
            {
                int width = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Текущая длина " + Box.Width + " ,введите значение"));
                int height = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Текущая ширина " + Box.Height + " ,введите значение"));
                Box.Size = new Size(width, height);
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Box.Image = Image.FromFile(openFile.FileName);
                }
            }
        } //событие двойного клика
        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove && Collage.IsMove) //если можно перемещать и если это коллаж 
            {
                Box.Location = new Point(Cursor.Position.X - Box.Width / 2, Cursor.Position.Y - Box.Height / 2);
            }
        } //перемещение
        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
            IsMove = false;
        } //отпускание мыши
        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            IsMove = true;
        } //нажатие мыши
    } //класс панели с картинкой
}
