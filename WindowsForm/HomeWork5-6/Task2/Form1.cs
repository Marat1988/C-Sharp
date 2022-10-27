using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormMain : Form
    {

        public Color colorFigure { get; set; } = Color.Red; //Заливка фигуры
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public FormMain()
        {
            InitializeComponent();
            panelSettingRectangleOrOval.Visible = false;
            panelSettingAbstractFigure.Visible = false;
            saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
        }

        //Отображение прямоугольника или овала на форме
        private void PaintRectangleOrOval(int width, int height,  bool rectangle = true)  //bool rectangle = 1  - Прямоугольник
        {                                                                                                 //bool rectangle = 0  - Эллипс
            Brush brush = new SolidBrush(colorFigure);                                                //Сделал так для того, чтобы не дублировать код                                               
            Graphics g = pictureBox1.CreateGraphics();
            Size sz = new Size(width, height);
            Rectangle rect1 = new Rectangle(new Point(30, 70), sz);
            if (rectangle)
                g.FillRectangle(brush, rect1);
            else
                g.FillEllipse(brush, rect1);
            g.Dispose();
        }

        //Сохранение нарисованного прямоугольника или овала на диск
        private void SavePaintRectangleOrOval(int width, int height,  string fileName, bool rectangle = true) //bool rectangle = 1  - Прямоугольник
        {                                                                                                                     //bool rectangle = 0  - Эллипс 
            Brush brush = new SolidBrush(colorFigure);                                                                    //Сделал так для того, чтобы не дублировать код
            Bitmap myBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                Size sz = new Size(width, height);
                Rectangle rect1 = new Rectangle(new Point(0, 0), sz);
                if (rectangle)
                    g.FillRectangle(brush, rect1);
                else
                    g.FillEllipse(brush, rect1);
            }
            myBitmap.Save(fileName);
        }

        //Отображение нарисованной абстрактной фигуры на форме
        private void PaintAbstractFigure(PointF point1, PointF point2, PointF point3, PointF point4, PointF point5)
        {
            PointF[] pArray = { point1, point2, point3, point4, point5 };
            Brush brush = new SolidBrush(colorFigure);                                                                                            
            Graphics g = pictureBox1.CreateGraphics();
            g.FillPolygon(brush, pArray);
            g.Dispose();
        }

        //Сохранение абстрактной нарисованной фигуры на диск
        private void SaveAbstractFigure(PointF point1, PointF point2, PointF point3, PointF point4, PointF point5, string fileName)
        {
            PointF[] pArray = { point1, point2, point3, point4, point5 };
            Brush brush = new SolidBrush(colorFigure);
            Bitmap myBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                g.FillPolygon(brush, pArray);
            }
            myBitmap.Save(fileName);
        }

        private void toolStripButtonSettingRectangle_Click(object sender, EventArgs e) 
        {
            panelSettingRectangleOrOval.Visible = true;
            panelSettingRectangleOrOval.Tag = true;
        }

        private void toolStripButtonSettingOval_Click(object sender, EventArgs e)
        {
            panelSettingRectangleOrOval.Visible = true;
            panelSettingRectangleOrOval.Tag = false;
        }

        private void buttonFilling_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Color.Red;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                colorFigure = colorDialog.Color;
        }

        private void buttonShowSaveFigure_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            panelSettingRectangleOrOval.Visible = false;          
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //При необходимости сохраняем в файл
            {
                SavePaintRectangleOrOval((int)numericWidth.Value, (int)numericHeight.Value, saveFileDialog.FileName, (bool)panelSettingRectangleOrOval.Tag);
            }
            PaintRectangleOrOval((int)numericWidth.Value, (int)numericHeight.Value,  (bool)panelSettingRectangleOrOval.Tag); //отображаем на форме        
        }

        private void buttonHidePanel_Click(object sender, EventArgs e)=> panelSettingRectangleOrOval.Visible = false;

        private void toolStripButtonAbstractFigure_Click(object sender, EventArgs e) => panelSettingAbstractFigure.Visible = true;

        private void buttonHidePanelSettingAbstractFigure_Click(object sender, EventArgs e) => panelSettingAbstractFigure.Visible = false;

        private void buttonSaveAbstractFigure_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            panelSettingAbstractFigure.Visible = false;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //При необходимости сохраняем в файл
            {
                SaveAbstractFigure(new PointF((float)numericPoint1_X.Value, (float)numericPoint1_Y.Value),
                                   new PointF((float)numericPoint2_X.Value, (float)numericPoint2_Y.Value),
                                   new PointF((float)numericPoint3_X.Value, (float)numericPoint3_Y.Value),
                                   new PointF((float)numericPoint4_X.Value, (float)numericPoint4_Y.Value),
                                   new PointF((float)numericPoint5_X.Value, (float)numericPoint5_Y.Value),
                                   saveFileDialog.FileName);
            }
            PaintAbstractFigure(new PointF((float)numericPoint1_X.Value, (float)numericPoint1_Y.Value),
                                new PointF((float)numericPoint2_X.Value, (float)numericPoint2_Y.Value),
                                new PointF((float)numericPoint3_X.Value, (float)numericPoint3_Y.Value),
                                new PointF((float)numericPoint4_X.Value, (float)numericPoint4_Y.Value),
                                new PointF((float)numericPoint5_X.Value, (float)numericPoint5_Y.Value));

        }
    }
}
