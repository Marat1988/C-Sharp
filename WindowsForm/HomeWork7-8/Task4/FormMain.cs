using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormMain : Form
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int numStatic { get; set; } = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                //определение позиции статика в зависимости с какой стороны его начали расовать
                if (e.X > X && e.Y > Y)
                {
                    label.Location = new Point(X, Y);
                }
                else if (e.X > X && e.Y < Y)
                {
                    label.Location = new Point(X, e.Y);
                }
                else if (e.X < X && e.Y < Y)
                {
                    label.Location = new Point(e.X, e.Y);
                }
                else
                {
                    label.Location = new Point(e.X, Y);
                }
                if (Math.Abs(e.X - X) <= 10 || Math.Abs(e.Y - Y) <= 10)
                {
                    MessageBox.Show("Невозможно создать «статик» меньше чем 10х10", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //заполнение опций нового статика
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = $"{numStatic}";
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Red;
                    Controls.Add(label);//Добавление нвого статика в коллекцию элементов управления.
                    Text = $"«Статик» с номер №{label.Text} создан!";
                    label.MouseClick += LabelMouseClick;//подписываем на два события для статика
                    label.MouseDoubleClick += LabelMouseDoubleClick;
                    numStatic++;
                }
            }
            else
            {
                MessageBox.Show("Для создания «статика» нажмите левую кнопку мышки", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $"«Статик» номер №{item.Text}, Площадь {item.Width * item.Height}, Координаты Х = {item.Location.X} Y = {item.Location.Y}";
                    }
                }
            }
        }
        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numLabel = numStatic;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (numLabel == Convert.ToInt32(item.Text))
                    {
                        Text = $"«Статик» с номер №{item.Text} удалён!";
                        Controls.Remove(item);
                        item.MouseClick -= LabelMouseClick;
                        item.MouseDoubleClick -= LabelMouseDoubleClick;
                    }
                }
            }
        }
    }
}
