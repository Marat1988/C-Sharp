
namespace Task4
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
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonLoadTextFile = new System.Windows.Forms.Button();
            this.ButtonEditTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.BackColor = System.Drawing.Color.White;
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 110);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(688, 386);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // ButtonLoadTextFile
            // 
            this.ButtonLoadTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoadTextFile.Location = new System.Drawing.Point(12, 12);
            this.ButtonLoadTextFile.Name = "ButtonLoadTextFile";
            this.ButtonLoadTextFile.Size = new System.Drawing.Size(194, 75);
            this.ButtonLoadTextFile.TabIndex = 1;
            this.ButtonLoadTextFile.Text = "Загрузить";
            this.ButtonLoadTextFile.UseVisualStyleBackColor = true;
            this.ButtonLoadTextFile.Click += new System.EventHandler(this.ButtonLoadTextFile_Click);
            // 
            // ButtonEditTextFile
            // 
            this.ButtonEditTextFile.Enabled = false;
            this.ButtonEditTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditTextFile.Location = new System.Drawing.Point(276, 12);
            this.ButtonEditTextFile.Name = "ButtonEditTextFile";
            this.ButtonEditTextFile.Size = new System.Drawing.Size(194, 75);
            this.ButtonEditTextFile.TabIndex = 2;
            this.ButtonEditTextFile.Text = "Изменить";
            this.ButtonEditTextFile.UseVisualStyleBackColor = true;
            this.ButtonEditTextFile.Click += new System.EventHandler(this.ButtonEditTextFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 508);
            this.Controls.Add(this.ButtonEditTextFile);
            this.Controls.Add(this.ButtonLoadTextFile);
            this.Controls.Add(this.TextBoxDescription);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonLoadTextFile;
        private System.Windows.Forms.Button ButtonEditTextFile;
    }
}

