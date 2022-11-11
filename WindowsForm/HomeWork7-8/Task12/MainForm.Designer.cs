
namespace Task12
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
            this.buttonLoadTextFile = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonLoadTextFile
            // 
            this.buttonLoadTextFile.Location = new System.Drawing.Point(53, 25);
            this.buttonLoadTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadTextFile.Name = "buttonLoadTextFile";
            this.buttonLoadTextFile.Size = new System.Drawing.Size(219, 28);
            this.buttonLoadTextFile.TabIndex = 0;
            this.buttonLoadTextFile.Text = "Загрузить текстовый файл";
            this.buttonLoadTextFile.UseVisualStyleBackColor = true;
            this.buttonLoadTextFile.Click += new System.EventHandler(this.buttonLoadTextFile_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(53, 61);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(897, 266);
            this.textBoxDescription.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 347);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(899, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 438);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonLoadTextFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример работы progressbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTextFile;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

