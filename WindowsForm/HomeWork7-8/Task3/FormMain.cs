using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormMain : Form
    {
        private const int x = 10;
        private const int y = 10;
        private const int width = 180;
        private const int height = 90;
        private const string infoPoint = "Расположение точки";

        public FormMain()
        {
            InitializeComponent();
            MessageBox.Show("Ваша задача найти спрятанный прямоугольник на форме.\nЕсли вы его найдете, то прямоугольник появится на форме", infoPoint, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e) => Text = "Координаты: X = " + e.X + " y = " + e.Y;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Y == y || e.Y == height + y || e.X == x || e.X == width + x)
                {
                    MessageBox.Show("Точка находится на границе прямоугольника", infoPoint,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (e.X > x && e.X < width + x && e.Y > y && e.Y < height + y) 
                    {
                        MessageBox.Show("Точка находится внутри прямоугольника\nУра! Ты нашел прямоугольник!", infoPoint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PaintRectangle();
                    }
                    else
                    {
                        MessageBox.Show("Точка находится снаружи", infoPoint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (ModifierKeys == Keys.Control && e.Button==MouseButtons.Left)
            {
                MessageBox.Show("Зажата клавита CTLR. Приложение будет закрыто", infoPoint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (e.Button == MouseButtons.Right)
                MessageBox.Show($"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}", "Размер клиентской области окна", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        private void PaintRectangle()
        {
            Graphics graphics = this.CreateGraphics();
            graphics.FillRectangle(Brushes.Red, x, y, width, height);
            graphics.Dispose();
        }
    }
}
