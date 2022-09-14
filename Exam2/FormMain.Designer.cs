﻿
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
            this.SuspendLayout();
            // 
            // ButtonSettingUser
            // 
            this.ButtonSettingUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSettingUser.Location = new System.Drawing.Point(62, 364);
            this.ButtonSettingUser.Name = "ButtonSettingUser";
            this.ButtonSettingUser.Size = new System.Drawing.Size(377, 96);
            this.ButtonSettingUser.TabIndex = 4;
            this.ButtonSettingUser.Text = "Настройки";
            this.ButtonSettingUser.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.Location = new System.Drawing.Point(62, 24);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(377, 96);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Начать викторину";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonShowResult
            // 
            this.ButtonShowResult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowResult.Location = new System.Drawing.Point(62, 138);
            this.ButtonShowResult.Name = "ButtonShowResult";
            this.ButtonShowResult.Size = new System.Drawing.Size(377, 96);
            this.ButtonShowResult.TabIndex = 2;
            this.ButtonShowResult.Text = "Посмотреть результаты прошлых викторин";
            this.ButtonShowResult.UseVisualStyleBackColor = true;
            // 
            // ButtonShowTop20
            // 
            this.ButtonShowTop20.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowTop20.Location = new System.Drawing.Point(62, 251);
            this.ButtonShowTop20.Name = "ButtonShowTop20";
            this.ButtonShowTop20.Size = new System.Drawing.Size(377, 96);
            this.ButtonShowTop20.TabIndex = 3;
            this.ButtonShowTop20.Text = "Посмотреть ТОП 20 по викторине";
            this.ButtonShowTop20.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(62, 479);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(377, 96);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ComboBoxChooseQuiz
            // 
            this.ComboBoxChooseQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxChooseQuiz.FormattingEnabled = true;
            this.ComboBoxChooseQuiz.Items.AddRange(new object[] {
            "Смешанная"});
            this.ComboBoxChooseQuiz.Location = new System.Drawing.Point(500, 65);
            this.ComboBoxChooseQuiz.Name = "ComboBoxChooseQuiz";
            this.ComboBoxChooseQuiz.Size = new System.Drawing.Size(284, 28);
            this.ComboBoxChooseQuiz.TabIndex = 0;
            this.ComboBoxChooseQuiz.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseQuiz_SelectedIndexChanged);
            // 
            // LabelChooseQuiz
            // 
            this.LabelChooseQuiz.AutoSize = true;
            this.LabelChooseQuiz.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelChooseQuiz.Location = new System.Drawing.Point(500, 33);
            this.LabelChooseQuiz.Name = "LabelChooseQuiz";
            this.LabelChooseQuiz.Size = new System.Drawing.Size(273, 23);
            this.LabelChooseQuiz.TabIndex = 6;
            this.LabelChooseQuiz.Text = "Выберите тему для викторины";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 587);
            this.Controls.Add(this.LabelChooseQuiz);
            this.Controls.Add(this.ComboBoxChooseQuiz);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonShowTop20);
            this.Controls.Add(this.ButtonShowResult);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonSettingUser);
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
    }
}