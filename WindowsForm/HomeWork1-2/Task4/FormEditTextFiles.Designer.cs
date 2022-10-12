
namespace Task4
{
    partial class FormEditTextFiles
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
            this.TextBoxEditTextFile = new System.Windows.Forms.TextBox();
            this.ButtonSaveTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEditTextFile
            // 
            this.TextBoxEditTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEditTextFile.Location = new System.Drawing.Point(12, 94);
            this.TextBoxEditTextFile.Multiline = true;
            this.TextBoxEditTextFile.Name = "TextBoxEditTextFile";
            this.TextBoxEditTextFile.Size = new System.Drawing.Size(558, 344);
            this.TextBoxEditTextFile.TabIndex = 0;
            // 
            // ButtonSaveTextFile
            // 
            this.ButtonSaveTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSaveTextFile.Location = new System.Drawing.Point(12, 12);
            this.ButtonSaveTextFile.Name = "ButtonSaveTextFile";
            this.ButtonSaveTextFile.Size = new System.Drawing.Size(154, 60);
            this.ButtonSaveTextFile.TabIndex = 1;
            this.ButtonSaveTextFile.Text = "Сохранить изменения";
            this.ButtonSaveTextFile.UseVisualStyleBackColor = true;
            // 
            // FormEditTextFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.ButtonSaveTextFile);
            this.Controls.Add(this.TextBoxEditTextFile);
            this.Name = "FormEditTextFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование текстового файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEditTextFile;
        private System.Windows.Forms.Button ButtonSaveTextFile;
    }
}