﻿
namespace Task11
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
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(55, 28);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(53, 22);
            this.textBoxDays.TabIndex = 0;
            this.textBoxDays.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            this.textBoxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDays_KeyPress);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(147, 28);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(53, 22);
            this.textBoxMonth.TabIndex = 1;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            this.textBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDays_KeyPress);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(239, 28);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(53, 22);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDays_KeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(360, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDays);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

