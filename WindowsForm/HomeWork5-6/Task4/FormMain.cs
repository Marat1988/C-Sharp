using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task4
{
    public partial class FormChart : Form
    {
        public string[] MonthName = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сетнябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public FormChart()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
                dataGridViewSales.Rows.Add(MonthName[i]);
            buttonRandomGenerate_Click(this, null);
        }

        private void buttonCreateChart_Click(object sender, EventArgs e)
        {
            chartExample.Series[0].Points.Clear();
            if (radioButtonStackedBarChart.Checked) chartExample.Series[0].ChartType = SeriesChartType.StackedBar;
            if (radioButtonColumnChart.Checked) chartExample.Series[0].ChartType = SeriesChartType.Column;
            if (radioButtonLineShart.Checked) chartExample.Series[0].ChartType = SeriesChartType.Line;
            try
            {
                for (int j = 0; j < dataGridViewSales.Rows.Count; j++)
                {
                    chartExample.Series[0].Points.AddXY(j + 1,
                                                              Convert.ToDouble(dataGridViewSales.Rows[j].Cells[1].Value?.ToString() ?? "0"));
                    chartExample.Series[0].Points[j].AxisLabel = dataGridViewSales.Rows[j].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveChartInFile_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Сохранить диаграмму как ...";
                saveFileDialog.Filter = "*.bmp|*.bmp;|*.png|*.png|*.jpg|*.jpg";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "Диаграмма";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            chartExample.SaveImage(saveFileDialog.FileName, ChartImageFormat.Bmp);
                            break;
                        case 2:
                            chartExample.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                            break;
                        case 3:
                            chartExample.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                            break;
                    }
                }
            }
        }

        private void buttonRandomGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int j = 0; j < dataGridViewSales.Rows.Count; j++)
                dataGridViewSales.Rows[j].Cells[1].Value = random.Next(1000, 100000); //Заполняю случайными значениями
        }
    }
}
