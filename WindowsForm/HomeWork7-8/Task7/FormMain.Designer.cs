
namespace Task7
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
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
            this.radioButtonMinute = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.buttonCalcDate = new System.Windows.Forms.Button();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(18, 10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(281, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Введите дату в формате ДД.ММ.ГГГГ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSeconds);
            this.groupBox1.Controls.Add(this.radioButtonMinute);
            this.groupBox1.Controls.Add(this.radioButtonDays);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Controls.Add(this.radioButtonYear);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выдача результата:";
            // 
            // radioButtonSeconds
            // 
            this.radioButtonSeconds.AutoSize = true;
            this.radioButtonSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSeconds.Location = new System.Drawing.Point(6, 134);
            this.radioButtonSeconds.Name = "radioButtonSeconds";
            this.radioButtonSeconds.Size = new System.Drawing.Size(98, 20);
            this.radioButtonSeconds.TabIndex = 8;
            this.radioButtonSeconds.TabStop = true;
            this.radioButtonSeconds.Text = "В секундах";
            this.radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinute
            // 
            this.radioButtonMinute.AutoSize = true;
            this.radioButtonMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMinute.Location = new System.Drawing.Point(6, 108);
            this.radioButtonMinute.Name = "radioButtonMinute";
            this.radioButtonMinute.Size = new System.Drawing.Size(92, 20);
            this.radioButtonMinute.TabIndex = 7;
            this.radioButtonMinute.TabStop = true;
            this.radioButtonMinute.Text = "В минутах";
            this.radioButtonMinute.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDays.Location = new System.Drawing.Point(6, 82);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(67, 20);
            this.radioButtonDays.TabIndex = 6;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "В днях";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMonth.Location = new System.Drawing.Point(6, 56);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(91, 20);
            this.radioButtonMonth.TabIndex = 5;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "В месяцах";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Checked = true;
            this.radioButtonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYear.Location = new System.Drawing.Point(6, 30);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(74, 20);
            this.radioButtonYear.TabIndex = 4;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "В годах";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            // 
            // buttonCalcDate
            // 
            this.buttonCalcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcDate.Location = new System.Drawing.Point(255, 52);
            this.buttonCalcDate.Name = "buttonCalcDate";
            this.buttonCalcDate.Size = new System.Drawing.Size(147, 41);
            this.buttonCalcDate.TabIndex = 4;
            this.buttonCalcDate.Text = "Вычислить";
            this.buttonCalcDate.UseVisualStyleBackColor = true;
            this.buttonCalcDate.Click += new System.EventHandler(this.buttonCalcDate_Click);
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDate.Location = new System.Drawing.Point(316, 7);
            this.maskedTextBoxDate.Mask = "00.00.0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(95, 22);
            this.maskedTextBoxDate.TabIndex = 1;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDate_MaskInputRejected);
            this.maskedTextBoxDate.TextChanged += new System.EventHandler(this.maskedTextBoxDate_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 229);
            this.Controls.Add(this.buttonCalcDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.maskedTextBoxDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление периода";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSeconds;
        private System.Windows.Forms.RadioButton radioButtonMinute;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.Button buttonCalcDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
    }
}

