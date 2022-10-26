using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormChess : Form
    {

        List<PictureBox> figures = new List<PictureBox>();
        public FormChess()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            figures.Clear();
            int sizeRect = 60;
            Rectangle rect1 = new Rectangle();
            rect1.Size = new Size(sizeRect, sizeRect);
            int pointX = 0, pointY = 0;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    rect1.Location = new Point(pointX, pointY);
                    if (row % 2 == 0)
                    {
                        if (col % 2 == 0)
                            graphics.FillRectangle(Brushes.AntiqueWhite, rect1);
                        else
                            graphics.FillRectangle(Brushes.SaddleBrown, rect1);
                    }
                    else
                    {
                        if (col % 2 == 0)
                            graphics.FillRectangle(Brushes.SaddleBrown, rect1);                         
                        else
                            graphics.FillRectangle(Brushes.AntiqueWhite, rect1);
                    
                    }
                    /***************************Пешка***************************/
                    if (row == 1)
                    {
                        figures.Add(new PictureBox
                        {
                            Name = "pictureBoxPawnBlack",
                            Image = new Bitmap(Properties.Resources.PawnBlack),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(sizeRect, sizeRect),
                            Location = rect1.Location,
                            BackColor = (col % 2 == 0) ? Color.SaddleBrown : Color.AntiqueWhite,
                            ContextMenuStrip = new ContextMenuStrip(),
                        });
                        figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Пешка черная. Строка {row + 1} Столбец {col + 1}");
                        this.Controls.Add(figures[figures.Count - 1]);
                    }
                    if (row == 6)
                    {
                        figures.Add(new PictureBox
                        {
                            Name = "pictureBoxPawnWhite",
                            Image = new Bitmap(Properties.Resources.PawnWhite),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(sizeRect, sizeRect),
                            Location = rect1.Location,
                            BackColor = (col % 2 == 0) ? Color.AntiqueWhite : Color.SaddleBrown,
                            ContextMenuStrip = new ContextMenuStrip(),

                        });
                        figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Пешка белая. Строка {row + 1} Столбец {col + 1}");
                        this.Controls.Add(figures[figures.Count - 1]);
                    }
                    /***************************Остальные фигуры***************************/
                    if (row == 0)
                    {
                        /*Конь черный*/
                        if (col == 1 || col == 6)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxHorseBlack",
                                Image = new Bitmap(Properties.Resources.HorseBlack),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 1) ? Color.SaddleBrown : Color.AntiqueWhite,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Конь черный. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Ладья черная*/
                        if (col == 0 || col == 7)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxRookBlack",
                                Image = new Bitmap(Properties.Resources.RookBlack),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 0) ? Color.AntiqueWhite : Color.SaddleBrown,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Ладья черная. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Слон черный*/
                        if (col == 2 || col == 5)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxElephantBlack",
                                Image = new Bitmap(Properties.Resources.ElephantBlack),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 2) ? Color.AntiqueWhite : Color.SaddleBrown,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Слон черный. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Король черный*/
                        if (col == 4)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxKingBlack",
                                Image = new Bitmap(Properties.Resources.KingBlack),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = Color.AntiqueWhite,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Король черный. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Ферзь черный*/
                        if (col == 3)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxFairzBlack",
                                Image = new Bitmap(Properties.Resources.FairzBlack),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = Color.SaddleBrown,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Ферзь черный. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                    }
                    /*Противоположная сторона*/
                    if (row == 7)
                    {
                        /*Конь белый*/
                        if (col == 1 || col == 6)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxHorseBlack",
                                Image = new Bitmap(Properties.Resources.HorseWhite),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 1) ? Color.AntiqueWhite : Color.SaddleBrown,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Конь белый. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Ладья белая*/
                        if (col == 0 || col == 7)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxRookWhite",
                                Image = new Bitmap(Properties.Resources.RookWhite),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 0) ? Color.SaddleBrown : Color.AntiqueWhite,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Ладья белая. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Слон белый*/
                        if (col == 2 || col == 5)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxElephantWhite",
                                Image = new Bitmap(Properties.Resources.ElephantWhite),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = (col == 2) ? Color.SaddleBrown : Color.AntiqueWhite,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Слон белый. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Король белый*/
                        if (col == 4)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxKingWhite",
                                Image = new Bitmap(Properties.Resources.KingWhite),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = Color.SaddleBrown,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Король белый. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                        /*Ферзь белый*/
                        if (col == 3)
                        {
                            figures.Add(new PictureBox
                            {
                                Name = "pictureBoxFairzWhite",
                                Image = new Bitmap(Properties.Resources.FairzWhite),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(sizeRect, sizeRect),
                                Location = rect1.Location,
                                BackColor = Color.AntiqueWhite,
                                ContextMenuStrip = new ContextMenuStrip(),

                            });
                            figures[figures.Count - 1].ContextMenuStrip.Items.Add($"Ферзь белый. Строка {row + 1} Столбец {col + 1}");
                            this.Controls.Add(figures[figures.Count - 1]);
                        }
                    }
                    pointX += sizeRect;
                }
                pointX = 0;
                pointY += sizeRect;
            }
            graphics.Dispose();
        }
    }
}
