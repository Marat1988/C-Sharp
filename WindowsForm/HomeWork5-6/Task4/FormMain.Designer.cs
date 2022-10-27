
namespace Task4
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartExample = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.ColumnNameMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateChart = new System.Windows.Forms.Button();
            this.groupBoxTypeCharts = new System.Windows.Forms.GroupBox();
            this.radioButtonLineShart = new System.Windows.Forms.RadioButton();
            this.radioButtonColumnChart = new System.Windows.Forms.RadioButton();
            this.radioButtonStackedBarChart = new System.Windows.Forms.RadioButton();
            this.buttonSaveChartInFile = new System.Windows.Forms.Button();
            this.buttonRandomGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.groupBoxTypeCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartExample
            // 
            chartArea2.Name = "ChartArea1";
            this.chartExample.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartExample.Legends.Add(legend2);
            this.chartExample.Location = new System.Drawing.Point(1, 1);
            this.chartExample.Name = "chartExample";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Статистика продаж по месяцам";
            series2.Name = "StatisticsSales";
            this.chartExample.Series.Add(series2);
            this.chartExample.Size = new System.Drawing.Size(855, 669);
            this.chartExample.TabIndex = 0;
            this.chartExample.Text = "Диаграмма продаж";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameMonth,
            this.ColumnSalesAmount});
            this.dataGridViewSales.Location = new System.Drawing.Point(862, 1);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(340, 324);
            this.dataGridViewSales.TabIndex = 1;
            // 
            // ColumnNameMonth
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameMonth.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnNameMonth.Frozen = true;
            this.ColumnNameMonth.HeaderText = "Месяц";
            this.ColumnNameMonth.Name = "ColumnNameMonth";
            this.ColumnNameMonth.ReadOnly = true;
            this.ColumnNameMonth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnSalesAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.NullValue = "0";
            this.ColumnSalesAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnSalesAmount.Frozen = true;
            this.ColumnSalesAmount.HeaderText = "Сумма продаж";
            this.ColumnSalesAmount.Name = "ColumnSalesAmount";
            // 
            // buttonCreateChart
            // 
            this.buttonCreateChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateChart.Location = new System.Drawing.Point(862, 463);
            this.buttonCreateChart.Name = "buttonCreateChart";
            this.buttonCreateChart.Size = new System.Drawing.Size(340, 55);
            this.buttonCreateChart.TabIndex = 2;
            this.buttonCreateChart.Text = "Построить диаграмму";
            this.buttonCreateChart.UseVisualStyleBackColor = true;
            this.buttonCreateChart.Click += new System.EventHandler(this.buttonCreateChart_Click);
            // 
            // groupBoxTypeCharts
            // 
            this.groupBoxTypeCharts.Controls.Add(this.radioButtonLineShart);
            this.groupBoxTypeCharts.Controls.Add(this.radioButtonColumnChart);
            this.groupBoxTypeCharts.Controls.Add(this.radioButtonStackedBarChart);
            this.groupBoxTypeCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeCharts.Location = new System.Drawing.Point(862, 340);
            this.groupBoxTypeCharts.Name = "groupBoxTypeCharts";
            this.groupBoxTypeCharts.Size = new System.Drawing.Size(340, 117);
            this.groupBoxTypeCharts.TabIndex = 3;
            this.groupBoxTypeCharts.TabStop = false;
            this.groupBoxTypeCharts.Text = "Тип диаграммы:";
            // 
            // radioButtonLineShart
            // 
            this.radioButtonLineShart.AutoSize = true;
            this.radioButtonLineShart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLineShart.Location = new System.Drawing.Point(6, 79);
            this.radioButtonLineShart.Name = "radioButtonLineShart";
            this.radioButtonLineShart.Size = new System.Drawing.Size(49, 19);
            this.radioButtonLineShart.TabIndex = 2;
            this.radioButtonLineShart.Text = "Line";
            this.radioButtonLineShart.UseVisualStyleBackColor = true;
            // 
            // radioButtonColumnChart
            // 
            this.radioButtonColumnChart.AutoSize = true;
            this.radioButtonColumnChart.Checked = true;
            this.radioButtonColumnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonColumnChart.Location = new System.Drawing.Point(6, 54);
            this.radioButtonColumnChart.Name = "radioButtonColumnChart";
            this.radioButtonColumnChart.Size = new System.Drawing.Size(68, 19);
            this.radioButtonColumnChart.TabIndex = 1;
            this.radioButtonColumnChart.TabStop = true;
            this.radioButtonColumnChart.Text = "Column";
            this.radioButtonColumnChart.UseVisualStyleBackColor = true;
            // 
            // radioButtonStackedBarChart
            // 
            this.radioButtonStackedBarChart.AutoSize = true;
            this.radioButtonStackedBarChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonStackedBarChart.Location = new System.Drawing.Point(6, 29);
            this.radioButtonStackedBarChart.Name = "radioButtonStackedBarChart";
            this.radioButtonStackedBarChart.Size = new System.Drawing.Size(88, 19);
            this.radioButtonStackedBarChart.TabIndex = 0;
            this.radioButtonStackedBarChart.Text = "StackedBar";
            this.radioButtonStackedBarChart.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChartInFile
            // 
            this.buttonSaveChartInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChartInFile.Location = new System.Drawing.Point(862, 533);
            this.buttonSaveChartInFile.Name = "buttonSaveChartInFile";
            this.buttonSaveChartInFile.Size = new System.Drawing.Size(340, 55);
            this.buttonSaveChartInFile.TabIndex = 4;
            this.buttonSaveChartInFile.Text = "Сохранить диаграмму в файл";
            this.buttonSaveChartInFile.UseVisualStyleBackColor = true;
            this.buttonSaveChartInFile.Click += new System.EventHandler(this.buttonSaveChartInFile_Click);
            // 
            // buttonRandomGenerate
            // 
            this.buttonRandomGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandomGenerate.Location = new System.Drawing.Point(862, 605);
            this.buttonRandomGenerate.Name = "buttonRandomGenerate";
            this.buttonRandomGenerate.Size = new System.Drawing.Size(340, 65);
            this.buttonRandomGenerate.TabIndex = 5;
            this.buttonRandomGenerate.Text = "Сгенерировать случайные значения";
            this.buttonRandomGenerate.UseVisualStyleBackColor = true;
            this.buttonRandomGenerate.Click += new System.EventHandler(this.buttonRandomGenerate_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 682);
            this.Controls.Add(this.buttonRandomGenerate);
            this.Controls.Add(this.buttonSaveChartInFile);
            this.Controls.Add(this.groupBoxTypeCharts);
            this.Controls.Add(this.buttonCreateChart);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.chartExample);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример построения диаграмм";
            ((System.ComponentModel.ISupportInitialize)(this.chartExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.groupBoxTypeCharts.ResumeLayout(false);
            this.groupBoxTypeCharts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExample;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonCreateChart;
        private System.Windows.Forms.GroupBox groupBoxTypeCharts;
        private System.Windows.Forms.RadioButton radioButtonLineShart;
        private System.Windows.Forms.RadioButton radioButtonColumnChart;
        private System.Windows.Forms.RadioButton radioButtonStackedBarChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesAmount;
        private System.Windows.Forms.Button buttonSaveChartInFile;
        private System.Windows.Forms.Button buttonRandomGenerate;
    }
}

