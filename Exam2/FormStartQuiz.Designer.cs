
namespace WinFormsApp1
{
    partial class FormStartQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.ButtonNextQuestion = new System.Windows.Forms.Button();
            this.ButtonPreviousQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(9, 7);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(766, 271);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "labelQuestion";
            // 
            // ButtonNextQuestion
            // 
            this.ButtonNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextQuestion.Location = new System.Drawing.Point(157, 304);
            this.ButtonNextQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonNextQuestion.Name = "ButtonNextQuestion";
            this.ButtonNextQuestion.Size = new System.Drawing.Size(273, 57);
            this.ButtonNextQuestion.TabIndex = 1;
            this.ButtonNextQuestion.Text = "Следующий вопрос";
            this.ButtonNextQuestion.UseVisualStyleBackColor = true;
            this.ButtonNextQuestion.Click += new System.EventHandler(this.ButtonNextQuestion_Click);
            // 
            // ButtonPreviousQuestion
            // 
            this.ButtonPreviousQuestion.Enabled = false;
            this.ButtonPreviousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPreviousQuestion.Location = new System.Drawing.Point(448, 304);
            this.ButtonPreviousQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonPreviousQuestion.Name = "ButtonPreviousQuestion";
            this.ButtonPreviousQuestion.Size = new System.Drawing.Size(273, 57);
            this.ButtonPreviousQuestion.TabIndex = 2;
            this.ButtonPreviousQuestion.Text = "Предыдущий вопрос";
            this.ButtonPreviousQuestion.UseVisualStyleBackColor = true;
            this.ButtonPreviousQuestion.Click += new System.EventHandler(this.ButtonPreviousQuestion_Click);
            // 
            // FormStartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.ButtonPreviousQuestion);
            this.Controls.Add(this.ButtonNextQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStartQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викторина";
            this.Load += new System.EventHandler(this.StartQuiz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button ButtonNextQuestion;
        private System.Windows.Forms.Button ButtonPreviousQuestion;
    }
}