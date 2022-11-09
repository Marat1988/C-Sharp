
namespace Task9
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
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.buttonSaveProfileTextFile = new System.Windows.Forms.Button();
            this.textBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonIt = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMens = new System.Windows.Forms.RadioButton();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelSurName = new System.Windows.Forms.Label();
            this.groupBoxProfile.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.buttonSaveProfileTextFile);
            this.groupBoxProfile.Controls.Add(this.textBoxAdditionalInfo);
            this.groupBoxProfile.Controls.Add(this.labelAdditionalInfo);
            this.groupBoxProfile.Controls.Add(this.dateTimePickerBirthday);
            this.groupBoxProfile.Controls.Add(this.labelBirthday);
            this.groupBoxProfile.Controls.Add(this.groupBoxGender);
            this.groupBoxProfile.Controls.Add(this.textBoxMiddleName);
            this.groupBoxProfile.Controls.Add(this.labelMiddleName);
            this.groupBoxProfile.Controls.Add(this.textBoxName);
            this.groupBoxProfile.Controls.Add(this.labelName);
            this.groupBoxProfile.Controls.Add(this.textBoxSurName);
            this.groupBoxProfile.Controls.Add(this.labelSurName);
            this.groupBoxProfile.Location = new System.Drawing.Point(16, 15);
            this.groupBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProfile.Size = new System.Drawing.Size(673, 392);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Анкета:";
            // 
            // buttonSaveProfileTextFile
            // 
            this.buttonSaveProfileTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveProfileTextFile.Location = new System.Drawing.Point(408, 306);
            this.buttonSaveProfileTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveProfileTextFile.Name = "buttonSaveProfileTextFile";
            this.buttonSaveProfileTextFile.Size = new System.Drawing.Size(240, 58);
            this.buttonSaveProfileTextFile.TabIndex = 7;
            this.buttonSaveProfileTextFile.Text = "Сохранить в файл";
            this.buttonSaveProfileTextFile.UseVisualStyleBackColor = true;
            this.buttonSaveProfileTextFile.Click += new System.EventHandler(this.buttonSaveProfileTextFile_Click);
            // 
            // textBoxAdditionalInfo
            // 
            this.textBoxAdditionalInfo.Location = new System.Drawing.Point(165, 179);
            this.textBoxAdditionalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdditionalInfo.Multiline = true;
            this.textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            this.textBoxAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAdditionalInfo.Size = new System.Drawing.Size(195, 185);
            this.textBoxAdditionalInfo.TabIndex = 6;
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdditionalInfo.Location = new System.Drawing.Point(17, 193);
            this.labelAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(140, 52);
            this.labelAdditionalInfo.TabIndex = 9;
            this.labelAdditionalInfo.Text = "Дополнительная информация:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(418, 68);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(195, 22);
            this.dateTimePickerBirthday.TabIndex = 4;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(281, 70);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(129, 17);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonIt);
            this.groupBoxGender.Controls.Add(this.radioButtonWoman);
            this.groupBoxGender.Controls.Add(this.radioButtonMens);
            this.groupBoxGender.Location = new System.Drawing.Point(12, 112);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGender.Size = new System.Drawing.Size(333, 59);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол:";
            // 
            // radioButtonIt
            // 
            this.radioButtonIt.AutoSize = true;
            this.radioButtonIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIt.Location = new System.Drawing.Point(271, 23);
            this.radioButtonIt.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonIt.Name = "radioButtonIt";
            this.radioButtonIt.Size = new System.Drawing.Size(59, 21);
            this.radioButtonIt.TabIndex = 2;
            this.radioButtonIt.Text = "Оно";
            this.radioButtonIt.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(133, 23);
            this.radioButtonWoman.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(95, 21);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.Text = "Женский";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMens
            // 
            this.radioButtonMens.AutoSize = true;
            this.radioButtonMens.Checked = true;
            this.radioButtonMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMens.Location = new System.Drawing.Point(8, 23);
            this.radioButtonMens.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMens.Name = "radioButtonMens";
            this.radioButtonMens.Size = new System.Drawing.Size(93, 21);
            this.radioButtonMens.TabIndex = 0;
            this.radioButtonMens.TabStop = true;
            this.radioButtonMens.Text = "Мужской";
            this.radioButtonMens.UseVisualStyleBackColor = true;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(116, 70);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(133, 22);
            this.textBoxMiddleName.TabIndex = 3;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(10, 70);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(84, 17);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(418, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(367, 38);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(116, 33);
            this.textBoxSurName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(133, 22);
            this.textBoxSurName.TabIndex = 1;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurName.Location = new System.Drawing.Point(9, 37);
            this.labelSurName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(82, 17);
            this.labelSurName.TabIndex = 0;
            this.labelSurName.Text = "Фамилия:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.groupBoxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкета";
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAdditionalInfo;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMens;
        private System.Windows.Forms.Button buttonSaveProfileTextFile;
        private System.Windows.Forms.RadioButton radioButtonIt;
    }
}

