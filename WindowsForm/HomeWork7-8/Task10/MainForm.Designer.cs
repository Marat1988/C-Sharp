
namespace Task10
{
    partial class MainForm
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
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNumberOfDays = new System.Windows.Forms.Button();
            this.labelCountDays = new System.Windows.Forms.Label();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(278, 160);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBegin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первая дата:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(278, 200);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вторая дата:";
            // 
            // buttonNumberOfDays
            // 
            this.buttonNumberOfDays.Location = new System.Drawing.Point(179, 237);
            this.buttonNumberOfDays.Name = "buttonNumberOfDays";
            this.buttonNumberOfDays.Size = new System.Drawing.Size(151, 48);
            this.buttonNumberOfDays.TabIndex = 4;
            this.buttonNumberOfDays.Text = "Количество дней";
            this.buttonNumberOfDays.UseVisualStyleBackColor = true;
            this.buttonNumberOfDays.Click += new System.EventHandler(this.buttonNumberOfDays_Click);
            // 
            // labelCountDays
            // 
            this.labelCountDays.AutoSize = true;
            this.labelCountDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountDays.ForeColor = System.Drawing.Color.Red;
            this.labelCountDays.Location = new System.Drawing.Point(112, 293);
            this.labelCountDays.Name = "labelCountDays";
            this.labelCountDays.Size = new System.Drawing.Size(0, 20);
            this.labelCountDays.TabIndex = 5;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(351, 237);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(127, 48);
            this.buttonCloseForm.TabIndex = 6;
            this.buttonCloseForm.Text = "Закрыть форму";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.labelCountDays);
            this.Controls.Add(this.buttonNumberOfDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Количество дней между двумя датами";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNumberOfDays;
        private System.Windows.Forms.Label labelCountDays;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}

