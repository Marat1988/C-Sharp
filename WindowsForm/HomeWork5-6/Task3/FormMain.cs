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
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
           chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
           chart1.ChartAreas[0].AxisX.Crossing = 0;
           chart1.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void buttonSIN_Click(object sender, EventArgs e)
        {
            double a = -10, b = 10, h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Sin(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void buttonCOS_Click(object sender, EventArgs e)
        {
            double a = -10, b = 10, h = 0.1, x, y;
            this.chart1.Series[1].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Cos(x);
                this.chart1.Series[1].Points.AddXY(x, y);
                x += h;
            }
        }

        private void buttonParabola_Click(object sender, EventArgs e)
        {

            this.chart1.Series[2].Points.Clear();
            double x = -3;
            double y = Math.Pow(x, 2);
            while (x <= 3)
            {
                this.chart1.Series[2].Points.AddXY(x, y);
                x++;
                y = Math.Pow(x, 2);
            }
        }

        private void buttonСircle_Click(object sender, EventArgs e)
        {
             this.chart1.Series[3].Points.Clear();
             double centerX = 0, centerY = 0, radius = 4, amountOfEdges = 100;
             for (int k = 0; k <= amountOfEdges; k++)
             {
                 double x = centerX + radius * Math.Cos(k * 2 * Math.PI / amountOfEdges);
                 double y = centerY + radius * Math.Sin(k * 2 * Math.PI / amountOfEdges);
                 this.chart1.Series[3].Points.AddXY(x, y);
             }
        }
    }
}
