
namespace Task3
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSIN = new System.Windows.Forms.Button();
            this.buttonCOS = new System.Windows.Forms.Button();
            this.buttonParabola = new System.Windows.Forms.Button();
            this.buttonСircle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "y=sin(x)";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "y=cos(x)";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "y=x^2";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "Круг";
            series4.Name = "Series4";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(846, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Построение математических графиков функций";
            this.chart1.Titles.Add(title1);
            // 
            // buttonSIN
            // 
            this.buttonSIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSIN.Location = new System.Drawing.Point(26, 425);
            this.buttonSIN.Name = "buttonSIN";
            this.buttonSIN.Size = new System.Drawing.Size(261, 71);
            this.buttonSIN.TabIndex = 1;
            this.buttonSIN.Text = "y = sin(x) синусоида";
            this.buttonSIN.UseVisualStyleBackColor = true;
            this.buttonSIN.Click += new System.EventHandler(this.buttonSIN_Click);
            // 
            // buttonCOS
            // 
            this.buttonCOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCOS.Location = new System.Drawing.Point(312, 425);
            this.buttonCOS.Name = "buttonCOS";
            this.buttonCOS.Size = new System.Drawing.Size(261, 71);
            this.buttonCOS.TabIndex = 2;
            this.buttonCOS.Text = "y = cos(x) косинусоида";
            this.buttonCOS.UseVisualStyleBackColor = true;
            this.buttonCOS.Click += new System.EventHandler(this.buttonCOS_Click);
            // 
            // buttonParabola
            // 
            this.buttonParabola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonParabola.Location = new System.Drawing.Point(597, 425);
            this.buttonParabola.Name = "buttonParabola";
            this.buttonParabola.Size = new System.Drawing.Size(261, 71);
            this.buttonParabola.TabIndex = 3;
            this.buttonParabola.Text = "парабола\r\ny = x^2\r\n";
            this.buttonParabola.UseVisualStyleBackColor = true;
            this.buttonParabola.Click += new System.EventHandler(this.buttonParabola_Click);
            // 
            // buttonСircle
            // 
            this.buttonСircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСircle.Location = new System.Drawing.Point(26, 502);
            this.buttonСircle.Name = "buttonСircle";
            this.buttonСircle.Size = new System.Drawing.Size(261, 71);
            this.buttonСircle.TabIndex = 4;
            this.buttonСircle.Text = "Круг";
            this.buttonСircle.UseVisualStyleBackColor = true;
            this.buttonСircle.Click += new System.EventHandler(this.buttonСircle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 579);
            this.Controls.Add(this.buttonСircle);
            this.Controls.Add(this.buttonParabola);
            this.Controls.Add(this.buttonCOS);
            this.Controls.Add(this.buttonSIN);
            this.Controls.Add(this.chart1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример построения графиков функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonSIN;
        private System.Windows.Forms.Button buttonCOS;
        private System.Windows.Forms.Button buttonParabola;
        private System.Windows.Forms.Button buttonСircle;
    }
}

