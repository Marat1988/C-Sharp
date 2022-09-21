
namespace WinFormsApp1
{
    partial class FormMain
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
            this.ButtonSettingUser = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonShowResult = new System.Windows.Forms.Button();
            this.ButtonShowTop20 = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ComboBoxChooseQuiz = new System.Windows.Forms.ComboBox();
            this.LabelChooseQuiz = new System.Windows.Forms.Label();
            this.LabelHelloUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSettingUser
            // 
            this.ButtonSettingUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ButtonSettingUser.Location = new System.Drawing.Point(20, 276);
            this.ButtonSettingUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSettingUser.Name = "ButtonSettingUser";
            this.ButtonSettingUser.Size = new System.Drawing.Size(283, 74);
            this.ButtonSettingUser.TabIndex = 4;
            this.ButtonSettingUser.Text = "Настройки пользователя";
            this.ButtonSettingUser.UseVisualStyleBackColor = true;
            this.ButtonSettingUser.Click += new System.EventHandler(this.ButtonSettingUser_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ButtonStart.Location = new System.Drawing.Point(20, 15);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(283, 63);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Начать викторину";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonShowResult
            // 
            this.ButtonShowResult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ButtonShowResult.Location = new System.Drawing.Point(20, 96);
            this.ButtonShowResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonShowResult.Name = "ButtonShowResult";
            this.ButtonShowResult.Size = new System.Drawing.Size(283, 71);
            this.ButtonShowResult.TabIndex = 2;
            this.ButtonShowResult.Text = "Посмотреть результаты прошлых викторин";
            this.ButtonShowResult.UseVisualStyleBackColor = true;
            this.ButtonShowResult.Click += new System.EventHandler(this.ButtonShowResult_Click);
            // 
            // ButtonShowTop20
            // 
            this.ButtonShowTop20.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ButtonShowTop20.Location = new System.Drawing.Point(20, 185);
            this.ButtonShowTop20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonShowTop20.Name = "ButtonShowTop20";
            this.ButtonShowTop20.Size = new System.Drawing.Size(283, 70);
            this.ButtonShowTop20.TabIndex = 3;
            this.ButtonShowTop20.Text = "Посмотреть ТОП 20 по викторине";
            this.ButtonShowTop20.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ButtonExit.Location = new System.Drawing.Point(20, 369);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(283, 63);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ComboBoxChooseQuiz
            // 
            this.ComboBoxChooseQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxChooseQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxChooseQuiz.FormattingEnabled = true;
            this.ComboBoxChooseQuiz.Location = new System.Drawing.Point(330, 56);
            this.ComboBoxChooseQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxChooseQuiz.Name = "ComboBoxChooseQuiz";
            this.ComboBoxChooseQuiz.Size = new System.Drawing.Size(333, 33);
            this.ComboBoxChooseQuiz.TabIndex = 0;
            this.ComboBoxChooseQuiz.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseQuiz_SelectedIndexChanged);
            // 
            // LabelChooseQuiz
            // 
            this.LabelChooseQuiz.AutoSize = true;
            this.LabelChooseQuiz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChooseQuiz.Location = new System.Drawing.Point(325, 15);
            this.LabelChooseQuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelChooseQuiz.Name = "LabelChooseQuiz";
            this.LabelChooseQuiz.Size = new System.Drawing.Size(334, 30);
            this.LabelChooseQuiz.TabIndex = 6;
            this.LabelChooseQuiz.Text = "Выберите тему для викторины";
            // 
            // LabelHelloUser
            // 
            this.LabelHelloUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelHelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHelloUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelHelloUser.Location = new System.Drawing.Point(330, 118);
            this.LabelHelloUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHelloUser.Name = "LabelHelloUser";
            this.LabelHelloUser.Size = new System.Drawing.Size(329, 314);
            this.LabelHelloUser.TabIndex = 7;
            this.LabelHelloUser.Text = "label1";
            this.LabelHelloUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelHelloUser.Click += new System.EventHandler(this.LabelHelloUser_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 495);
            this.Controls.Add(this.LabelHelloUser);
            this.Controls.Add(this.LabelChooseQuiz);
            this.Controls.Add(this.ComboBoxChooseQuiz);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonShowTop20);
            this.Controls.Add(this.ButtonShowResult);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonSettingUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSettingUser;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonShowResult;
        private System.Windows.Forms.Button ButtonShowTop20;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ComboBox ComboBoxChooseQuiz;
        private System.Windows.Forms.Label LabelChooseQuiz;
        private System.Windows.Forms.Label LabelHelloUser;
    }
}